using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static List<String> processData(IEnumerable<string> lines)
        {
            /* 
             * Do not make any changes outside this method.
             *
             * Modify this method to process `array` as indicated
             * in the question. At the end, return the size of the
             * array. 
             *
             * Do not print anything in this method
             *
             * Submit this entire program (not just this function)
             * as your answer
             *           

             */

            //just change

            List<string> l1 = new List<string>();
            List<string> l2 = new List<string>();
            string s1 = null;
            l1.AddRange(lines);

            foreach(var s in l1)
            {
                s1 = s.Split(",")[0];

               for(int i=0;i<l1.Count;i++)
                {
                    if(s1 == (l1[i].Split(","))[0])
                    {
                        if(!l2.Contains(s1))
                        {
                            l2.Add(s1);
                        }
                    }
                }
            }

            return l2;

       
        }

        static void Main(string[] args)
        {
            try
            {
                List<String> retVal = processData(File.ReadAllLines(@"E:\testproject\QuickTest\input.txt"));
                File.WriteAllLines(@"E:\testproject\QuickTest\output.txt", retVal);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}


