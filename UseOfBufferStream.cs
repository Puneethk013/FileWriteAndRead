using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
namespace FileWriteAndRead
{
    class UseOfBufferStream
    {
        static void Main()
        {
            MemoryStream ms = new MemoryStream();
            BufferedStream b = new BufferedStream(ms);
            b.WriteByte(1);
            byte[] a = { 1, 2, 3 };
            b.Write(a, 0, a.Length);
            byte[] a1 = new byte[252];
            ms.Write(a1, 0, a1.Length);
            ms.WriteByte(4);
            
            
        }
    }
}
