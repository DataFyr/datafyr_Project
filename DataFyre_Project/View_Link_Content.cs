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
using System.Data.SqlClient;

namespace datascience_project
{
    public partial class View_Link_Content : Form
    {
        HashSet<string> selectedSentencesAdded = new HashSet<string>();

        Color[] highlightColors = { Color.Yellow, Color.Cyan, Color.Magenta, Color.Orange, Color.LightBlue, Color.LightGreen, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSteelBlue, Color.LightYellow };
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
        }

        private void lstWordOccurrence_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the selected word from the list box
            string selectedWord = lstWordOccurrence.SelectedItem?.ToString();
            string textOnly = Regex.Replace(selectedWord, @"[^a-zA-Z]+", "");

            if (!string.IsNullOrEmpty(textOnly))
            {
                // Get the text from the textbox
                string text = view_content_textbox.Text;

                // Split the text into sentences using a regular expression
                string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");

                // Loop through each sentence
                for (int i = 0; i < sentences.Length; i++)
                {
                    // Check if the sentence contains the selected word
                    if (sentences[i].Contains(textOnly))
                    {
                        // Find the index of the current sentence in the textbox text
                        int startIndex = text.IndexOf(sentences[i]);

                        // Check if the sentence is already highlighted
                        bool alreadyHighlighted = IsSentenceHighlighted(startIndex, sentences[i].Length);

                        // If the sentence is not already highlighted, highlight it
                        if (!alreadyHighlighted)
                        {
                            // Select the sentence
                            view_content_textbox.Select(startIndex, sentences[i].Length);

                            // Apply a different highlight color to each sentence
                            view_content_textbox.SelectionBackColor = highlightColors[i % highlightColors.Length];

                            // Ensure the textbox has focus
                            view_content_textbox.Focus();
                        }
                    }
                }
            }
        }

      
        private bool IsSentenceHighlighted(int startIndex, int length)
        {
            // Get the selection start and length
            int selectionStart = view_content_textbox.SelectionStart;
            int selectionLength = view_content_textbox.SelectionLength;

            // Check if the current sentence overlaps with the selection
            if (startIndex <= selectionStart + selectionLength &&
                startIndex + length >= selectionStart)
            {
                return true;
            }

            return false;
        }

       
        private string GetClickedSentence()
        {
            // Get the index of the clicked character in the TextBox
            int clickedIndex = view_content_textbox.SelectionStart;

            // Find the start and end indices of the clicked sentence
            int startIndex = clickedIndex;
            while (startIndex > 0 && !".!?".Contains(view_content_textbox.Text[startIndex - 1]))
            {
                startIndex--;
            }

            int endIndex = clickedIndex;
            while (endIndex < view_content_textbox.Text.Length - 1 && !".!?".Contains(view_content_textbox.Text[endIndex]))
            {
                endIndex++;
            }

            // Extract the clicked sentence from the TextBox
            string clickedSentence = view_content_textbox.Text.Substring(startIndex, endIndex - startIndex + 1);

            return clickedSentence;
        }

        private void view_content_textbox_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void view_content_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            int startIndex = view_content_textbox.SelectionStart;
            int length = view_content_textbox.SelectionLength;

            // Check if any text is selected
            if (length > 0)
            {
                // Perform your desired action with the selected text
                string selectedText = view_content_textbox.Text.Substring(startIndex, length);
                dataGridView1.Rows.Add(selectedText);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
        }

        private void BtnCateogry_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
        }

        private void BtnLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void BtnViewTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view().ShowDialog();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new user_management().ShowDialog();
        }

        private void BtnLogingOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().ShowDialog();
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Link_Content().ShowDialog();

        }

     

   
    }
}
