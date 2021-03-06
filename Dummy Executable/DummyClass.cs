﻿using System;
using System.IO;

namespace Test
{
   class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*FileInfo info = new FileInfo("D:/Practice/Git_Repos/Windows_Programming/Utils/Sample_Text");
                Console.WriteLine("Access Credentials : {0}", (System.Security.Principal.WindowsIdentity.GetCurrent()).Name);

                using (FileStream fileStream = info.OpenRead())
                using (StreamReader fileReader = new StreamReader(fileStream))
                {
                    fileReader.ReadToEnd();
                }
                Console.WriteLine("Data Read Successfully");*/

                var value = System.Environment.GetEnvironmentVariable("TA_ENV123");
                if (value != null)
                {
                    string value3 = value.ToString();
                    Console.WriteLine(value3);
                }
                else
                    Console.WriteLine("Null Value Found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while Reading Data");
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
