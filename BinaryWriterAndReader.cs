using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileWriteAndRead
{
    class BinaryWriterAndReader
    {
        static void Main()
        {
            FileStream f = new FileStream(@"binary.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(f);
            bw.Write(10);
            bw.Write(3.35);
            //bw.Write(128);
            bw.Write("hello");
            bw.Close();
            f.Close();
            FileStream f1 = new FileStream(@"binary.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(f1);
            
            int b = br.ReadInt32();
            double a = br.ReadDouble();
            string s = br.ReadString();
            Console.WriteLine($"double value is: {a}\nInteger value is: {b}\nString value is: {s}");
         
            br.Close();
            f1.Close();
            Console.ReadLine();
        }
    }
}
