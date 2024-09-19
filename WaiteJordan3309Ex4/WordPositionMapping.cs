using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jordan Waite
// The WordPositionMapping Class manages the creation of our
// Dictionary<string, List<int>> which maps each word to a list of 
// positions (indexes) in the book.
namespace WaiteJordan3309Ex4 {
    public class WordPositionMapping {
        // Instance Variables
        // We need the book object
        private readonly Book book;
        // Make dictionary readable outside the class with get
        // Make dictionary writeable only within this class with private set
        public Dictionary<string, List<int>> WordToPositions { get; private set; }
        // Constructor
        public WordPositionMapping(Book book) {
            // We'll need a dictionary to hold the word | positions
            WordToPositions = new Dictionary<string, List<int>>();
            this.book = book;
            // Normalize the book text here in case it hasn't been already
            this.book.NormalizeText();
            CreateWordToPositionMapping();
        }

        // Class Methods:
        // CreateWordToPositionMapping(): Iterate through the normalized text of
        // the book and record the position/ positions of each unique word
        private void CreateWordToPositionMapping() {
            if (string.IsNullOrWhiteSpace(book.BookText)) {
                throw new InvalidOperationException("The book text is empty.");
            }
            // Split the book text into individual words
            string[] words = book.BookText.Split(' ');            
            // Iterate through the words
            for (int i = 0; i < words.Length; i++) {
                // Word = the current word in the iteration
                string word = words[i];
                // Ignore empty strings or unexpected spaces
                if (string.IsNullOrWhiteSpace(word)) {
                    continue;
                }
                // If the current word isn't already in the position map
                if (!WordToPositions.ContainsKey(word)) {
                    // Create a new int list for the word's positions
                    WordToPositions[word] = new List<int>();
                }
                // Regardless, add the current index to the position map
                // for the current word
                WordToPositions[word].Add(i);
            }
        }
    }
}
