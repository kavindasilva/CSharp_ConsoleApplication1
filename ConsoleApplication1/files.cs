using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * MS documentation on files: https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
 * Set of online sample codes: https://www.dotnetperls.com/file
 * This file contains,
 *      specifying file/folder path
 *      opening a file
 *      
 *
 */


using System.IO; //file handler

namespace ConsoleApplication1
{
    class files
    {
        private int ID;
        private string name;
        public int age;
        private string path = @"c:\temp\MyTest.txt";

        public files()
        {
            Console.WriteLine("constructor 1");
            path = "../../../stext.txt";
            read2();
        }
        public files(int agein)
        {
            Console.WriteLine("Constructor 2 with age");
            path = "../../../stext.txt";
            read1();
        }
        public files(int x, int y)
        {
            Console.WriteLine("Constructor 3 called");
            path = "../../../";
            write1();
        }

        // https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx
        public void read1(){
            //string path = @"c:\temp\MyTest.txt";
            if (File.Exists(path))
            {
                int lineCount = File.ReadAllLines(path).Length;
                Console.WriteLine(path+" has "+lineCount+" lines");

                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                
                Console.WriteLine("file not found in ");
                Console.Write(Environment.CurrentDirectory);
            }
        } //end of read1()


        // https://www.dotnetperls.com/file
        public void read2()
        {
            try
            {
                File.Exists(path);
                Console.WriteLine(path + " found");
                //continue;
            }
            catch(Exception e)
            {
                Console.Write(e);
            }

            Console.WriteLine("\r\r\r\r\r\r\r\r\r\ropening " + path);
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                //string[] parts; parts[0] = "s";
                int i = 0;

                while ((line = reader.ReadLine()) != null) //line-by-line
                {
                    // Do something with the line.
                    String[] parts = line.Split(' ');
                    //Console.WriteLine(parts[i]);
                    Console.WriteLine("__________________________________");
                    i++;
                }
                //Console.WriteLine(parts[0]);
            }
        } //end of read2()

        private bool write1()
        {
            bool res = false;
            path = path + "ks.txt";

            try
            {
                File.WriteAllText(path, "1st file writing");
                res = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return res;
        }


    } // end of the class "std"___________________________________________
}
