using System;
using System.IO;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ~~~~~ Document Merger Two ~~~~~ ");
            Console.WriteLine();

            // Displays if less than 3 arguments
            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
                Environment.Exit(1);
            }
            else
            {
            
            int i = 0;
            string content;
            string line = "";
            string Text = "";
            string newText = "";

                for (i = 0; i < args.Length - 1; i++)
                {
                    string Reader = args[i]; //reads file content
                    {
                        StreamReader sr = new StreamReader(Reader);

                        content = sr.ReadLine();

                        while (content != null)
                        {
                            content += line;

                            content = sr.ReadLine();
                        }

                    }

                    string NewText = args[i]; //combines file content
                    {
                        try
                        {
                            StreamWriter sw = new StreamWriter(newText);

                            sw.WriteLine(content);

                            sw.Close();
                        }

                        catch (Exception N)
                        {
                            Console.WriteLine("An Error Has Occured: " + N.Message); //gives exceptions
                        }

                    }

                    string MergedNames = args[args.Length - 1]; //combines file names and adds .txt

                    try
                    {
                        StreamWriter sw = new StreamWriter(MergedNames + ".txt");

                        sw.Write(Text);

                        Console.WriteLine("{0} was successfully saved. The document contains {1} characters", MergedNames, NewText.Length);
                        Environment.Exit(2);
                    }

                    catch (Exception M)
                    {
                        Console.WriteLine("An Error Has Occured: " + M.Message); //gives exceptions

                    }
                }
            }
        }
    }          
}