using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveMethods
{
    public class DirectoryPrinter : School.SchoolTask
    {
        public DirectoryPrinter() : base("Ordner und unterordner anzeigen") { }

        protected override void Main(string[] args)
        {
            List<string> paths = GetSubdirectories("../../../../");

            foreach(string path in paths)
            {
                Console.WriteLine(path);
            }
        }

        private List<string> GetSubdirectories(string initalPath)
        {
            if (!System.IO.Directory.Exists(initalPath))
            {
                throw new InvalidOperationException(nameof(initalPath) + " has to be a directory");
            }
            initalPath = System.IO.Path.GetFullPath(initalPath);
            List<string> paths = new List<string>()
            {
                initalPath
            };

            try {
                foreach(string path in System.IO.Directory.GetDirectories(initalPath))
                {
                    paths.AddRange(GetSubdirectories(path));
                }
            }catch(UnauthorizedAccessException)
            {}

            return paths;
        }
    }
}
