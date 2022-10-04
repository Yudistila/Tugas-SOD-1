using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string file = @"Yudi_Istilandani_file_lama.txt";
        string file_copy = @"Yudi_Istilandani_file_lama_copy.txt";
        File.Copy(file, file_copy, true);
        Console.WriteLine("File Ter-Copy");
        Console.ReadKey();
    }
}
