using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
// Jordan Waite
/* The purpose of the book class is to normalize the text from the txt file
 * version of a book (Pride and Prejudice) obtained from the FileHandler class.*/

namespace WaiteJordan3309Ex4 {
    public class Book {
        // Instance Variables
        // Make them readable outside the class with get
        // Make them writeable only within this class with private set
        public string BookText { get; private set; }
        public Dictionary<string, uint> WordFrequency { get; private set; }

        // Constructor
        public Book() {
            WordFrequency = new Dictionary<string, uint>();
        }

        // Class methods:
        // LoadBook: Load the book text
        public void LoadBook(string text) {
            BookText = text;
        }
        // NormalizeText: Normalize the raw text by removing non alphabetic characters,
        // multiple spaces, and converting letters to lower-case
        public void NormalizeText() {
            // Remove anything that isn't a non-alphabetic character
            BookText = Regex.Replace(BookText, @"[^a-zA-Z\s]", string.Empty);
            // Replace multiple spaces and newlines with a single space
            // and convert the entire remaining string to lowercase
            BookText = Regex.Replace(BookText, @"\s+", " ").ToLower().Trim();
        }
        // CountWordFrequency: Calculate and store word frequencies
        public void CountWordFrequency() {
            // Split the book string by spaces into an array of strings
            // that are each individual word
            string[] words = BookText.Split(' ');
            // Iterate through the newly split string and count each word's freq.
            foreach (string word in words) {
                if (WordFrequency.ContainsKey(word)) {
                    // If there is more than one occurrence
                    WordFrequency[word]++;
                }
                else {
                    // If there is only one occurrence of the current word
                    WordFrequency[word] = 1;
                }
            }
        }
        // GetHighestFrequencyWord: Get the most frequent word
        public string GetHighestFrequencyWord() {
            // Declare empty string and lowest uint value for comparison
            string mostFrequent = null;
            uint maxFrequency = 0;
            // Iterate through our frequency of each word and return the highest value
            foreach (var word in WordFrequency) {
                if (word.Value > maxFrequency) {
                    mostFrequent = word.Key;
                    maxFrequency = word.Value;
                }
            }
            return mostFrequent;
        }
        // GetLowestFrequencyWord: Get the least frequent word
        public string GetLowestFrequencyWord() {
            string leastFrequent = null;
            uint minFrequency = uint.MaxValue;
            foreach (var word in WordFrequency) {
                if (word.Value < minFrequency) {
                    leastFrequent = word.Key;
                    minFrequency = word.Value;
                }
            }
            return leastFrequent;
        }
        // GetWordFrequency: Get the # of occurrences of a specific word
        public uint GetWordFrequency(string word) {
            // Ensure the argument passed is lower case since our book text will
            // be all lower case.
            word = word.ToLower();
            // Use ternary operator: if the specified word is in our dictionary,
            // return its frequency and if not return a 0
            return WordFrequency.ContainsKey(word) ? WordFrequency[word] : 0;
        }
    }
}
