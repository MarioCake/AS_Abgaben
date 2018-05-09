using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using static School.Helper;

namespace School
{
    public abstract class SchoolTask
    {
        public string Name { get; private set; }

        private SchoolTask() { }

        protected SchoolTask(string name)
        {
            this.Name = name;
        }

        protected abstract void Main(string[] args);

        public static void LoadAssembly(Assembly assembly, string[] args)
        {
            IEnumerable<Type> schoolTaskTypes = assembly.GetTypes().Where(type => type.BaseType == typeof(SchoolTask));

            List<SchoolTask> tasks = schoolTaskTypes.Select(type => Activator.CreateInstance(type) as SchoolTask).ToList();


            Console.WriteLine("Welche Anwendung möchten Sie starten?");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i+1}: {tasks[i].Name}");
            }

            int selection = -1;
            do
            {
                Console.Write("Anwendung: ");
            } while (!TryGenericParse(Console.ReadLine(), out selection, validationFunction: input => input <= tasks.Count && input > 0 , errorMessage: "Wählen Sie eine der oben genannten Zahlen aus."));

            selection--;

            Console.Clear();

            tasks[selection].Main(args);

            Console.WriteLine("Drücken Sie eine beliebige Taste um die Anwendung zu beenden...");
            Console.ReadKey();
        }


    }
}
