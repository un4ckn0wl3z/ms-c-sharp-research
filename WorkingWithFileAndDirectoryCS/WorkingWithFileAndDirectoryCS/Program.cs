using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFileAndDirectoryCS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // File
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path)) Console.WriteLine("Found the file.");
            var content = File.ReadAllText(path);
            Console.WriteLine(content);
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"d:\temp\myfile.jpg", true);
            fileInfo.Delete();
            if (fileInfo.Exists) Console.WriteLine("Found the file.");
            var fileInfoContent = fileInfo.OpenRead();
            Console.WriteLine(fileInfoContent);

            //------------------------------------------------------------------

            // Directory
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\temp\folder1", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\temp\folder1", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            if (Directory.Exists(@"c:\temp\folder1"))
            {
                Console.WriteLine("Found the directory.");
            }

            var directoryInfo = new DirectoryInfo(@"c:\temp\folder1");
            var fileInfos = directoryInfo.GetFiles();
            var directoryInfos = directoryInfo.GetDirectories();

            //---------------------------------------------------------------------------------
            var tmpPath = @"C:\Users\anuwat\AppData\Local\Temp\file.txt";
            var ext = Path.GetExtension(tmpPath);
            var fileName = Path.GetFileName(tmpPath);
            var fileNameWithoutExt = Path.GetFileNameWithoutExtension(tmpPath);
            var dirName = Path.GetDirectoryName(tmpPath);
            Console.WriteLine(ext);
            Console.WriteLine(fileName);
            Console.WriteLine(fileNameWithoutExt);
            Console.WriteLine(dirName);
        }
    }
}