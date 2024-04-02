using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCN72040_Project_Group11_ChoreMe
{
    // Concrete observer
    public class FileWriteObserver : IChoreObserver
    {
        public void Update(string message)
        {
            string filePath = "logging.txt";

            try
            {
                // Open the file for writing
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Write some text to the file
                    writer.WriteLine(message + ", written to file");
                }

                Console.WriteLine("Text has been written to the file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
