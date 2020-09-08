using System;
using FirstLib;

namespace FirstcoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("I am in .net project");

            var ob;
            string choice = "add";
            switch(choice){
                case "add" : ob = new Addition();
                ob.display();
                break;

                case "sub" : ob = new Subtraction();
                ob.display();
                break;

            }
        }
    }
}
