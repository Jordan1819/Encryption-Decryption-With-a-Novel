using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Jordan Waite
// The purpose of the Decode class is to decode encoded messages. We will implement
// this by using the position number used to generate the original word.
namespace WaiteJordan3309Ex4 {
    public class Decode {
        // Instance variables
        // We'll need our position map and our filehandler
        private readonly WordPositionMapping mapping;
        private readonly FileHandler fileHandler;
        // Constructor
        public Decode(WordPositionMapping mapping, FileHandler fileHandler) {
            this.mapping = mapping;
            this.fileHandler = fileHandler;
        }
        // Class methods:
        // DecodeMessage(): Decode the encoded message
        public string DecodeMessage(string encodedMessageFile, string outputFile) {
            // Instantiate a new stringbuilder object to hold our decodedMessage
            var decodedMessage = new StringBuilder();
            string encodedMessage = fileHandler.ReadText(encodedMessageFile);
            // Split the encoded message file strng by spaces
            string[] encodedWords = encodedMessage.Split(' ');
            // Iterate through each string
            foreach (string encodedWord in encodedWords) {
                // Convert the current string (number) to an integer
                int wordPosition = int.Parse(encodedWord);
                // If the word didn't initially exist in the book text:
                if (wordPosition == -1) {
                    decodedMessage.Append("-1 ");
                }
                else {
                    // Iterate through the position mapping to find the word
                    foreach (var pair in mapping.WordToPositions) {
                        // If the current position matches one of the
                        // position values for a word
                        if (pair.Value.Contains(wordPosition)) {
                            // Append that word to the decoded message string
                            decodedMessage.Append(pair.Key + " ");
                            break;
                        }
                    }
                }
            }
            // Write the decoded message to the outputFile
            fileHandler.WriteText(outputFile, decodedMessage.ToString());
            // Return the decoded message
            return decodedMessage.ToString();
        }
    }
}
