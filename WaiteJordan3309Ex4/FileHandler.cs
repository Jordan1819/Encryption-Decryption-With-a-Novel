using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Jordan Waite
/* The purpose of the FileHandler class is to read in the text from a raw txt file
 * to pass on to other classes in the program. This class can also write to a txt file.*/

namespace WaiteJordan3309Ex4 {
    public class FileHandler {
        // Class methods:
        // ReadText: Read text from a file
        public string ReadText(string fileName) {
            try {
                return File.ReadAllText(fileName);
            }
            // If there's any trouble reading the file, get a specific
            // explanation of what went wrong with ex.Message.
            catch (Exception ex) {
                throw new Exception("Error reading the file: " + ex.Message);
            }
        }
        // WriteText: Write text to a file
        public void WriteText(string fileName, string text) {
            try {
                File.WriteAllText(fileName, text);
            }
            catch (Exception ex) { throw new Exception("Error writing the file: " + ex.Message); }
        }
    }
}
