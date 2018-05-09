using System;
using System.Collections.Generic;
using System.Text;

namespace Auswahlstrukturen
{
    public class SchoolTask
    {
        public static List<SchoolTask> AllSchoolTasks { get; set; } = new List<SchoolTask>();

        protected SchoolTask()
        {
            AllSchoolTasks.Add(this);
        }

        virtual public void Init(){}

        virtual public void RunTask()
        {
            Console.WriteLine("Can't run default school task.");
        }
    }
}
