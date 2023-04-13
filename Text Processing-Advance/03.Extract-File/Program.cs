﻿using System;

namespace _03.Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string fileInfo = filePath.Substring(filePath.LastIndexOf('\\') + 1);

            int dotIndex = fileInfo.IndexOf('.');
            string fileName = fileInfo.Substring(0, dotIndex);
            string fileExtension = fileInfo.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

            Console.WriteLine();
        }
    }
}
