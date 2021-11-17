using System;
using System.IO;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\opilane\samples\winter.txt";
            string winterPath = @"C:\Users\opilane\samples\autumn.txt";
            string[] dataFromFile = File.ReadAllLines(directoryPath);
            string[] autumnData = File.ReadAllLines(winterPath);
            File.WriteAllLines(directoryPath, autumnData);
            File.WriteAllLines(winterPath, autumnData);
        }
    }
}
