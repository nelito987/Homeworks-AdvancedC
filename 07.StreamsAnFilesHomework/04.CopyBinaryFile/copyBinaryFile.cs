using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class copyBinaryFile
    {
        public const string INPUT_FILE = "../../copyBinary.jpg";
        public const string OUTPUT_FILE = "../../copyBinary2.jpg";
 
        static void Main(string[] args)
        {
            using (

            FileStream inFile = new FileStream(INPUT_FILE, FileMode.Open),
                       outFile = new FileStream(OUTPUT_FILE, FileMode.Create))
            {
                byte[] buf = new byte[4096];
                while (true)
                {
                    int bytesRead = inFile.Read(buf, 0, buf.Length);
                    if (bytesRead == 0)
                        break;
                    outFile.Write(buf, 0, bytesRead);
                }
            }          
        }
    }
}
