using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace datascience_project
{
    public partial class View_Link_Content : Form
    {
        SpeechSynthesizer synthesizer;
        private static readonly HashSet<string> StopWords = new HashSet<string>
        {
            // Add common stop words
            "a", "about", "above", "after", "again", "against", "all", "am", "an", "and",
            "any", "are", "aren't", "as", "at", "be", "because", "been", "before", "being",
            "below", "between", "both", "but", "by", "can't", "cannot", "could", "couldn't",
            "did", "didn't", "do", "does", "doesn't", "doing", "don't", "down", "during",
            "each", "few", "for", "from", "further", "had", "hadn't", "has", "hasn't",
            "have", "haven't", "having", "he", "he'd", "he'll", "he's", "her", "here",
            "here's", "hers", "herself", "him", "himself", "his", "how", "how's", "i",
            "i'd", "i'll", "i'm", "i've", "if", "in", "into", "is", "isn't", "it", "it's",
            "its", "itself", "let's", "me", "more", "most", "mustn't", "my", "myself", "no",
            "nor", "not", "of", "off", "on", "once", "only", "or", "other", "ought", "our",
            "ours", "ourselves", "out", "over", "own", "same", "shan't", "she", "she'd",
            "she'll", "she's", "should", "shouldn't", "so", "some", "such", "than", "that",
            "that's", "the", "their", "theirs", "them", "themselves", "then", "there",
            "there's", "these", "they", "they'd", "they'll", "they're", "they've", "this",
            "those", "through", "to", "too", "under", "until", "up", "very", "was", "wasn't",
            "we", "we'd", "we'll", "we're", "we've", "were", "weren't", "what", "what's",
            "when", "when's", "where", "where's", "which", "while", "who", "who's", "whom",
            "why", "why's", "with", "won't", "would", "wouldn't", "you", "you'd", "you'll",
            "you're", "you've", "your", "yours", "yourself", "yourselves",
            // Add additional stop words as needed
        };


        public View_Link_Content()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string textToSpeak = view_content_textbox.Text;
            if (!string.IsNullOrEmpty(textToSpeak))
            {
                synthesizer.SpeakAsync(textToSpeak);
            }
            else
            {
                MessageBox.Show("Please enter some text to be narrated.");
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            string sentence = view_content_textbox.Text;
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                Dictionary<string, int> wordCount = CountWords(sentence);
                DisplayWordCount(wordCount);
            }
            else
            {
                MessageBox.Show("Please enter a sentence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Dictionary<string, int> CountWords(string sentence)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string[] words = sentence.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string cleanedWord = word.Trim().ToLower(); // Convert to lowercase and remove leading/trailing spaces
                if (!StopWords.Contains(cleanedWord))
                {
                    if (wordCount.ContainsKey(cleanedWord))
                        wordCount[cleanedWord]++;
                    else
                        wordCount[cleanedWord] = 1;
                }
            }

            return wordCount;
        }

        private void DisplayWordCount(Dictionary<string, int> wordCount)
        {
            var sortedWordCount = wordCount.OrderByDescending(pair => pair.Value);
            lstWordOccurrence.Items.Clear();
            foreach (var pair in sortedWordCount)
            {
                lstWordOccurrence.Items.Add($"{pair.Key}: {pair.Value}");
            }

            // Clear existing data in chart
            chart1.Series.Clear();

            // Add new series to chart
            Series series = chart1.Series.Add("Word Occurrences");

            // Populate data from wordCount dictionary into chart
            foreach (var pair in wordCount)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }
        }

        private void lstWordOccurrence_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure that at least one item is selected
            if (lstWordOccurrence.SelectedIndex != -1)
            {
                // Get the selected item
                string selectedItem = lstWordOccurrence.SelectedItem.ToString();
                // Define a regular expression pattern to match alphabetic characters
                string pattern = "[^a-zA-Z]+";

                // Create a Regex object
                Regex regex = new Regex(pattern);

                // Use Regex.Replace method to remove non-alphabetic characters
                string filteredSentence = regex.Replace(selectedItem, "");


                // Find the sentence containing the selected word
                foreach (string sentence in view_content_textbox.Lines)
                {
                    // Check if the sentence contains the selected word
                    if (sentence.Contains(filteredSentence))
                    {
                        // Highlight the entire sentence
                        HighlightSentence(sentence);
                        break; // Exit the loop after highlighting the first occurrence
                    }
                }

                // Remove numeric value after colon (:) symbol
                int colonIndex = selectedItem.IndexOf(':');
                if (colonIndex != -1)
                {
                    selectedItem = selectedItem.Substring(0, colonIndex);
                }

                // Check if the item already exists in the column
                bool itemExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["columnKeyword"].Value != null && row.Cells["columnKeyword"].Value.ToString() == selectedItem)
                    {
                        itemExists = true;
                        break;
                    }
                }

                // Add the item only if it doesn't already exist
                if (!itemExists)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells["columnKeyword"].Value = selectedItem;
                }
            }
        }
        private void HighlightSentence(string sentence)
        {
            // Find the index of the sentence in the textbox text
            int startIndex = view_content_textbox.Text.IndexOf(sentence);

            // If the sentence is found, select and highlight it
            if (startIndex != -1)
            {
                view_content_textbox.Select(startIndex, sentence.Length);
                view_content_textbox.SelectionBackColor = Color.Yellow; // Change background color
                view_content_textbox.Focus(); // Ensure the textbox has focus
            }
        }
    }
}
