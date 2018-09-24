using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveMethods
{
    public class Encryption : School.SchoolTask
    {
        public Encryption(): base("Verschlüsselung"){ }

        protected override void Main(string[] args)
        {
            Console.WriteLine("Wollen Sie einen Text aus einer Datei lesen oder einen selbst schreiben?");
            Console.WriteLine("1: Pfad");
            Console.WriteLine("2: Eigener Text");

            School.Helper.TryRepeatedConsoleParse(out int selectedValue, "Wähl eines der oben genannten Optionen aus.", value => value >= 1 && value <= 2);

            string clearText;

            if (selectedValue == 1)
            {
                Console.WriteLine("Geben Sie einen Pfad ein:");
                clearText = GetTextFromPath();
            }
            else
            {
                Console.WriteLine("Geben Sie einen Text ein:");
                clearText = GetTextFromInput();
            }
            
            string encryptedText = Encrypt(clearText);
            string decryptedText = Decrypt(encryptedText);

            Console.WriteLine("Unverschlüsselter Text: {1}{0}Verschlüsselter Text: {2}{0}Entschlüsselter Text: {3}", Console.Out.NewLine, clearText, encryptedText, decryptedText);

            
            SaveTextInFile(encryptedText);
        }

        private void SaveTextInFile(string text)
        {
            Console.WriteLine("Wo möchten Sie den Text abspeichern?");

            School.Helper.TryRepeatedConsoleParse(out string path, "Der Ordner in der die Datei liegt muss existieren.", (string checkPath) =>
            {
                string directoryPath = System.IO.Path.GetDirectoryName(checkPath);
                if (directoryPath.Length == 0)
                    directoryPath = "./";
                return System.IO.Directory.Exists(directoryPath);
            });
            System.IO.File.WriteAllText(path, text, Encoding.UTF8);
            Console.WriteLine("Der Text wurde in der Datei gespeichert: {0}", System.IO.Path.GetFullPath(path));
        }

        private string GetTextFromInput()
        {
            return Console.ReadLine();
        }

        private string GetTextFromPath()
        {
            School.Helper.TryRepeatedConsoleParse(out string path, "Es muss ein valider Pfad zur Textdatei eingegeben werden.", (string checkPath) =>
            {
                return System.IO.File.Exists(checkPath) && checkPath.EndsWith(".txt");
            });
            try
            {
                return System.IO.File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Kann die angegebende Datei nicht lesen.{0}{1}", Console.Error.NewLine, ex.Message);
                return "";
            }
        }

        private List<char> StringToCharlist(string text)
        {
            List<char> charsToEncrypt = text.ToCharArray().ToList();
            return charsToEncrypt;
        }

        private string CharlistToString(List<char> chars)
        {
            return String.Join("", chars);
        }

        private string Encrypt(string clearText)
        {
            List<char> chars = StringToCharlist(clearText);
            EncryptRecursive(chars);
            return CharlistToString(chars);
        }

        private void EncryptRecursive(List<char> chars, int index = 0)
        {
            if(chars.Count < index + 2) return;

            chars.Insert(index + 2, RandomChar());

            EncryptRecursive(chars, index + 3);
        }

        private string Decrypt(string encryptedText)
        {
            List<char> chars = StringToCharlist(encryptedText);
            DecryptRecursive(chars);
            return CharlistToString(chars);
        }

        private void DecryptRecursive(List<char> chars, int index = 0)
        {
            if (chars.Count < index + 2) return;

            chars.RemoveAt(index+2);

            DecryptRecursive(chars, index + 2);
        }

        private readonly Random random = new Random();
        private char RandomChar()
        {
            return (char)random.Next(Int16.MaxValue * 2);
        }
    }
}
