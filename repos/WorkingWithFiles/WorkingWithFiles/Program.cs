using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"C:\somefile.jpg";
            //File.Copy(@"C:\temp\myfile.jpg", @"C:\scripts\myfile.jpg", true);
            //File.Delete(path);
            //if(File.Exists(path))
            //{
            //    //
            //}

            //var content = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("...");
            //fileInfo.Delete();
            //if(fileInfo.Exists)
            //{
            //    //
            //}

            //Directory.CreateDirectory(@"C:\temp\folder1");
            //var files = Directory.GetFiles(@"C:\Users\Michal\source\repos", "*.sln", SearchOption.AllDirectories);
            //foreach(var file in files)
            //    Console.WriteLine(file);

            //var directories = Directory.GetDirectories(@"C:\Users\Michal\source\repos", "*.*", SearchOption.AllDirectories);

            //foreach(var directory in directories)
            //    Console.WriteLine(directory);


            //var directoryInfo = new DirectoryInfo("...");
            //directoryInfo.GetFiles();
            //directoryInfo.Delete();
            Path1();

        }

        static void Path1()
        {
            var path = @"C:\Users\Michal\source\repos\Test1_udemy\test1_udemy.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
        }
    }
}
