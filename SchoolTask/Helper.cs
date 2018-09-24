﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace School
{
    public static class Helper
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public static T[] GetArrayOf<T>(int amount, ActionForEachValue<T> actionForEachValue = null, TryParse<T> tryParse = null, Predicate<T> validationFunction = null, string errorMessage = null)
        {
            if (amount > 0)
            {
                T[] values = new T[amount];
                do
                {
                    T lastValue = default(T);
                    int currentIndex = values.Length - amount;

                    if (currentIndex != 0)
                        lastValue = values[currentIndex - 1];

                    if (actionForEachValue == null || actionForEachValue(currentIndex, lastValue))
                        TryRepeatedConsoleParse(out values[currentIndex], errorMessage, validationFunction, tryParse);

                    amount--;
                } while (amount > 0);

                return values;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount), nameof(amount) + " muss größer als 0 sein.");
            }
        }

        public static void TryRepeatedConsoleParse<T>(out T output, string errorMessage = null, Predicate<T> validationFunction = null, TryParse<T> tryParse = null)
        {
            while (!TryGenericParse(Console.ReadLine(), out output, errorMessage, validationFunction, tryParse));
        }

        public delegate bool ActionForEachValue<T>(int currentIndex, T lastValue = default(T));
        public delegate bool TryParse<T>(string input, out T output);

        public static bool TryGenericParse<T>(string input, out T output, string errorMessage = null, Predicate<T> validationFunction = null, TryParse <T> tryParse = null)
        {
            if (validationFunction == null)
                validationFunction = variable => true;

            if (tryParse == null)
                if(typeof(T) != typeof(string))
                {
                    MethodInfo tryParseMethod = GetTryParse<T>();

                    tryParse = (TryParse<T>)Delegate.CreateDelegate(typeof(TryParse<T>), tryParseMethod);
                }
                else
                {
                    tryParse = (string parseInput, out T parseOutput) =>
                    {
                        parseOutput = (T)(object)parseInput;
                        return true;
                    };
                }
            if (tryParse(input, out output) && validationFunction(output))
                return true;

            if (errorMessage != null)
                Console.WriteLine(errorMessage);
            else
                Console.WriteLine("Konnte die Eingabe nicht als '" + typeof(T).FullName + "' erkennen.");
            

            return false;
        }

        private static MethodInfo GetTryParse<T>()
        {
            return typeof(T).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(method =>
                    method.Name == "TryParse" &&
                    method.ReturnType == typeof(bool) &&
                    method.GetParameters().Length == 2 &&
                    method.GetParameters()[0].ParameterType == typeof(string) &&
                    method.GetParameters()[1].ParameterType == Type.GetType(typeof(T).FullName + "&")).Single();
        }

        public static T RandomEnumValue<T>()
        {
            Array enumValues = Enum.GetValues(typeof(T));
            return (T)enumValues.GetValue(random.Next(enumValues.Length));
        }

        public static bool RandomBool(double probability = 0.5)
        {
            double randomValue = random.NextDouble();

            return randomValue < probability;
        }

    }
}
