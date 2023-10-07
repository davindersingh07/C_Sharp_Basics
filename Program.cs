using System;
using System.IO;
using System.Text;

namespace C_Sharp_Basics
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            //To write content to file
            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World!");
            fs.Write(info, 0, info.Length);
            fs.Close();

            //To read content from file
            StreamReader sr = new StreamReader(path);
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);
            Console.ReadLine();
        }
    }
}
