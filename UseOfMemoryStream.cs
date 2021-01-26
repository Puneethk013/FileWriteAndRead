using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileWriteAndRead
{
    class UseOfMemoryStream
    {
        static void Main()
        {
            MemoryStream ms = new MemoryStream();
            ms.WriteByte(7);
            byte[] b = {1,2,3 };
            ms.Write(b,0,b.Length);
            byte[] b1 = new byte[252];
            ms.Write(b1,0,b1.Length);
            ms.WriteByte(4);
            MemoryStream ms1 = new MemoryStream(2);
            ms1.WriteByte(1);
            ms1.WriteByte(2);
            ms1.WriteByte(3);
            MemoryStream ms2 = new MemoryStream(b,false);
            //ms2.WriteByte(3);
            Console.ReadLine();


        }
    }
}
