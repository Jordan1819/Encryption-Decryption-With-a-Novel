using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// The purpose of the Encode Class is to work with with the Dictionary<string, List<int>>
// from WordPositionMapping in addition to reading/ writing to txt files. For each word in the clear message, Encode.cs
// can randomly select one of it's occurences/ positions from the dictionary and use that index value
// as it's code representation. 
namespace WaiteJordan3309Ex4 {
    public class Encode {
        // Instance variables
        // We'll need WordPositionMapping for mapping each word to
        // it's position/positions, a randomizer, and the FileHandler.
        private WordPositionMapping mapping;
        private Random random;
        private FileHandler fileHandler;
        //Constructor
        public Encode(WordPositionMapping mapping, FileHandler fileHandler) {
            this.mapping = mapping;
            random = new Random();
            this.fileHandler = fileHandler;
        }

        //Class Methods:
        // EncodeMessage(): Encode the clear.txt message into a List<int> and return it
        public List<int> EncodeMessage(string clearMessage, string outputFile) {
            // Create new empty List<int> object to store the encoded message 
            List<int> encodedMessage = new List<int>();
            try { 
                // Split the clear message into an array of strings (lower-case words)
                string[] words = clearMessage.ToLower().Split(' ');

                // Iterate through the words in the message
                foreach (var word in words) {
                    if (mapping.WordToPositions.ContainsKey(word)) {
                        // Get the positions for the word
                        var positions = mapping.WordToPositions[word];
                        // Randomly pick one of the positions
                        int randomIndex = random.Next(positions.Count);
                        encodedMessage.Add(positions[randomIndex]);
                    }
                    // if the word doesn't appear in the book/ mapping
                    else {
                        encodedMessage.Add(-1);
                    }
                }
                // Convert the encoded message to a string for writing to txt file
                string encodedMessageString = string.Join(" ", encodedMessage);
                // Use FileHandler write() to write the encoded message
                fileHandler.WriteText(outputFile, encodedMessageString);
            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred during encoding: " + ex.Message);
            }
            return encodedMessage;
        }
    }
}
