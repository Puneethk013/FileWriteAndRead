using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileWriteAndRead
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream f = new FileStream(@"result.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamWriter sw=new StreamWriter(f))
                {
                    string str;
                    Console.WriteLine("enter the content to write a file, enter ? to quit: ");
                    for (; ; )
                    {
                        str = Console.ReadLine();
                        if (str == "?")
                        {
                            break;
                        }
                        else{
                            sw.WriteLine(str); 
                        }
                    }
                }
                using (StreamReader sr=new StreamReader(@"result.txt"))
                {
                    Console.WriteLine("the content of the file is: ");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            Console.ReadLine();
        }
    }
}
