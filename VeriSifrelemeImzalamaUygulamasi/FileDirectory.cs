using System;
using System.IO;

namespace VeriSifrelemeImzalamaUygulamasi
{
    static class FileDirectory
    {
        // Ana dizinde islemler
        static string mainDirectory = Directory.GetParent(Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString();
        public static string Create(string dirName)
        {
            string dirPath = mainDirectory + "\\" + dirName;
            Directory.CreateDirectory(dirPath);
            return dirPath;
        }
    }
}
