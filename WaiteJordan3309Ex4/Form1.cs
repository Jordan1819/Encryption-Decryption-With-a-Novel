using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaiteJordan3309Ex4 {
    // Jordan Waite
    /* The purpose of this program is to gain practice and understanding in designing and implementing 
     * multiple classes in a complex program. The program demonstrates reading and modifying txt files, manipulating
     * strings, dictionaries, lists and passing data between classes.
     * This program is designed to encode and decode messages by
     * reading the novel "Pride and Prejudice" by Jane Austen into a dictionary data type. The dictionary
     * keys are the words in the novel, while the values are the # of times that word appears
     * in the text. We will use this dictionary to encode and decode messages. 
     * This assignment was completed by Jordan Waite, with the help and guidance of the resources
     * listed below.
     * Resources Utilized: learn.microsoft.com|geeksforgeeks.org|stackoverflow.com|w3resource.com|
     * My Github Portfolio: github.com/Jordan1819 
     * Development Time: ~20 hours 
     */
    public partial class Form1 : Form {
        // Declare instances of our classes
        private FileHandler fileHandler;
        private Book book;
        // Only declare the statistics class since we need a populated
        // book object in order to construct an instance of statistics
        private Statistics stats;
        private WordPositionMapping wordPositionMapping;
        private Encode encode;
        private Decode decode;

        public Form1() {
            InitializeComponent();
            fileHandler = new FileHandler();
            book = new Book();
            // Initialize the statistics class after book is loaded
            stats = new Statistics(book);
        }
        //btnLoadBook : Load/ read in the book txt file and normalize it
        private void btnLoadBook_Click(object sender, EventArgs e) {
            try {
                string filePath = "PrideAndPrejudiceProjectGutenberg.txt";
                string bookText = fileHandler.ReadText(filePath);
                // Load/ read in the books text into the book object
                book.LoadBook(bookText);
                // Normalize the loaded book text
                book.NormalizeText();
                // Testing output
                //txtOut.Text = book.BookText;
            }
            catch (Exception ex) {
                MessageBox.Show("Error processing book: " + ex.Message);
            }

        }
        // btnShowStatistics: Display the most and least occurring words in the book as
        // well as the specified words within task 1.
        private void btnShowStatistics_Click(object sender, EventArgs e) {
            // Count the word frequencies
            stats.CountWordFrequency();
            // Get and display the most frequent word
            string mostFrequent = stats.GetHighestFrequencyWord();
            lbStatistics.Items.Add("Most frequent word: " + mostFrequent);
            // Get and display the least frequent word
            string leastFrequent = stats.GetLowestFrequencyWord();
            lbStatistics.Items.Add("Least frequent word: " + leastFrequent);
            // Get the frequencies of specific words
            uint atFreq = stats.GetWordFrequency("at");
            uint darcyFreq = stats.GetWordFrequency("darcy");
            uint quagmireFreq = stats.GetWordFrequency("quagmire");
            uint kudgeFreq = stats.GetWordFrequency("kudge");
            // Display them
            lbStatistics.Items.Add($"Number of 'at' occurrences: {atFreq}");
            lbStatistics.Items.Add($"Number of 'darcy' occurences: {darcyFreq}");
            lbStatistics.Items.Add($"Number of 'quagmire' occurrences: {quagmireFreq}");
            lbStatistics.Items.Add($"Number of 'kudge' occurrences: {kudgeFreq}");
        }
        // btnEncode: Display the current clear.txt clear message in txtClearMessage,
        // encode the message, and display the code to txtOut.
        private void btnEncode_Click(object sender, EventArgs e) {
            try {
                // Display the clear message
                string clearMessageFile = "clear.txt";
                string clearMessage = fileHandler.ReadText(clearMessageFile);
                txtClearMessage.Text = clearMessage;
                // Create the word position mapping Dictionary<string, List<int>>
                wordPositionMapping = new WordPositionMapping(book);
                // Encode the message using the mapping and our fileHandler
                encode = new Encode(wordPositionMapping, fileHandler);
                List<int> encodedMessage = encode.EncodeMessage(clearMessage, "encoded.txt");
                // Display the encoded message
                txtOut.Text = string.Join(" ", encodedMessage);
            }
            catch (Exception ex) {
                MessageBox.Show("Error during encoding: " + ex.Message);
            }
        }
        // btnDecode: 
        private void btnDecode_Click(object sender, EventArgs e) {
            string encodedMessageFile = "encoded.txt";
            string decodedMessageFile = "decoded.txt";
            // Instantiate our decode class object
            decode = new Decode(wordPositionMapping, fileHandler);
            // Use the Decode class to decode the message
            string decodedText = decode.DecodeMessage(encodedMessageFile, decodedMessageFile);
            // Display the decoded message
            txtOutDecodedMessage.Text = decodedText;
        }
    }
}
