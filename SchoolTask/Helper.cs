using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace School
{
    public static class Helper
    {

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
                        TryRepeatedConsoleParse(out values[currentIndex], tryParse, validationFunction, errorMessage);

                    amount--;
                } while (amount > 0);

                return values;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount), nameof(amount) + " muss größer als 0 sein.");
            }
        }

        public static void TryRepeatedConsoleParse<T>(out T output, TryParse<T> tryParse = null, Predicate<T> validationFunction = null, string errorMessage = null)
        {
            while (!TryGenericParse(Console.ReadLine(), out output, tryParse, validationFunction, errorMessage));
        }

        public delegate bool ActionForEachValue<T>(int currentIndex, T lastValue = default(T));
        public delegate bool TryParse<T>(string input, out T output);

        public static bool TryGenericParse<T>(string input, out T output, TryParse<T> tryParse = null, Predicate<T> validationFunction = null, string errorMessage = null)
        {
            if (validationFunction == null)
                validationFunction = variable => true;

            if (tryParse == null)
            {
                MethodInfo tryParseMethod = GetTryParse<T>();

                tryParse = (TryParse<T>)Delegate.CreateDelegate(typeof(TryParse<T>), tryParseMethod);
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
    }
}
