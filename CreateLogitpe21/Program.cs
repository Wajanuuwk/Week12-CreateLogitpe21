using System;
using System.IO;

namespace CreateLogitpe21
{
    class Program
    {
        static void Main(string[] args)
        {
            string newDirectory = "logitpe21";
            CreateMyDirectory(newDirectory);
        }

        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userDirectory = "logitpe21";
            string directoryFullPath = $@"{rootDirectory}\{userDirectory}";

            bool directoryExists = Directory.Exists(directoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userDirectory} already exists in {rootDirectory}.");
            }
            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"{userDirectory} has been created in {rootDirectory}.");
            }
        }

        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = $@"C: \Users\opilane\samples";
            string directoryFullPath = $@"{rootDirectory}\{newDirectory}";
        }
    }
}