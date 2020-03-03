using System;
using System.IO;

namespace EstudoPATH {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\myfolder\file1.txt";

            //utilizamos a classe Path para fazer determinadas
            //operações com strings que contém informações de arquivos ou pastas.
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // \
            Console.WriteLine("PathSeparator: " + Path.PathSeparator); // ;
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // c:\temp\myfolder
            Console.WriteLine("GetFileName: " +  Path.GetFileName(path)); // file1.txt
            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // .txt
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // file1
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // c:\temp\myfolder\file1.txt
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // C:\Users\Sender\AppData\Local\Temp\

        }
    }
}
