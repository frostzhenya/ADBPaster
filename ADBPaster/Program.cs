using System;
using System.IO;

namespace ADBParser
{
    class Program
    {
        private static void Main(string[] args)
        {
            string adbFolderName = "adb";
            if (!Directory.Exists(adbFolderName))
            {
                Console.WriteLine("adb folder does not exist!");
                return;
            }
            var adbParser = new ADBParser(adbFolderName);
        }
    }
}
