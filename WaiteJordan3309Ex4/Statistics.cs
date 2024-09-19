using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Jordan Waite
// The statistics class handles all of the frequency-related methods
// from the book class. 

namespace WaiteJordan3309Ex4 {
    public class Statistics {
        // Declare a field for a Book obect
        private Book book;
        public Statistics(Book book) {
            // Assign the specific Book instance to the previously
            // declared field
            this.book = book;
        }

        // Accessor methods that delegate to the Book class:
        // Retrieve the word frequency dictionary from the 
        // Book object (accessing another classes property)
        public Dictionary<string, uint> GetWordFrequency() {
            return book.WordFrequency;
        }
        public void CountWordFrequency() {
            book.CountWordFrequency();
        }
        public string GetHighestFrequencyWord() {
            return book.GetHighestFrequencyWord();
        }
        public string GetLowestFrequencyWord() {
            return book.GetLowestFrequencyWord();
        }
        public uint GetWordFrequency(string word) {
            return book.GetWordFrequency(word);
        }
    }
}
