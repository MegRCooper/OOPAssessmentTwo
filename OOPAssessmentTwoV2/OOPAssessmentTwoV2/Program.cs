using System;
using System.IO;

namespace OOPAssessmentTwoV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads the texts from the files provided. 
            //Need to change so it reads from resources/ GitHub rather than private storage.
            string fileOne = File.ReadAllText("C:\\Users\\megrc\\source\\repos\\OOPAssessmentTwoV2\\OOPAssessmentTwoV2\\Resources\\GitRepositories_1a.txt");
            string fileTwo = File.ReadAllText("C:\\Users\\megrc\\source\\repos\\OOPAssessmentTwoV2\\OOPAssessmentTwoV2\\Resources\\GitRepositories_1b.txt");

            int linematch = 0;
            int fileOneLen = fileOne.Length;
            int fileTwoLen = fileTwo.Length;
            
            if (fileOneLen == fileTwoLen) //Checks the byte len.
            {
                for (int i = 0; i < fileOneLen; i++) //Checks the lines one at a time.
                {
                    if (fileOne[i] == fileTwo[i])
                    {
                        linematch++; //Checks if all lines match
                    }
                }
                if (linematch == fileOneLen) //If all lines match, gives good output
                {
                    Console.WriteLine("[OUTPUT] Files match");
                }
                else
                {
                    Console.WriteLine("[OUTPUT] Files do not match");
                }
            }
            else //If lengths do not match
            {
                Console.WriteLine("[OUTPUT] Files do not match");
            }
        }

    }
}
