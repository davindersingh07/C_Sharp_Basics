using System;

namespace C_Sharp_Basics
{
    public class Program
    {
        private string id;

        public string Id
        {
            get 
            {
                return id; 
            }
            set
            { 
                id = value; 
            }
        }
        public static void Main(string[] args) 
        { 
            Program p = new Program();
            p.Id = "4526";
            Console.WriteLine(p.Id);
            Console.ReadLine();
        }
    }
}
