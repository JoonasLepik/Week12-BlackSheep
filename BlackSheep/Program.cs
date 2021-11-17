using System;
using System.IO;

namespace BlackSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\opilane\samples\BlackSheep.txt";
            string[] dataFromFile = File.ReadAllLines(directoryPath);
            for(int i = 0; i < dataFromFile.Length; i++)
            {
                dataFromFile[i] = dataFromFile[i].Replace('1', 'i');
                dataFromFile[i] = dataFromFile[i].Replace('3', 'e');
                dataFromFile[i] = dataFromFile[i].Replace('4', 'a');
                dataFromFile[i] = dataFromFile[i].Replace('0', 'o');
            }
            foreach(string line in dataFromFile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(directoryPath, dataFromFile);
        }
        
        
            
              
    }
}
