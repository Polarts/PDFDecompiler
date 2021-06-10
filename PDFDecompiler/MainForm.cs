using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFDecompiler
{
    public partial class MainForm : Form
    {

        static Regex regex = new Regex(@"([^א-ת])+", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static Regex letterNumbers = new Regex(@"([A-Za-z\d])+", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public MainForm()
        {
            InitializeComponent();
            flipTextCheckBox.Checked = true;
        }

        private void BrowseSourceBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                FileName = "Select PDF",
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Open Source PDF File"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SourceTB.Text = dialog.FileName;
            }
        }

        private void BrowseDestinationBtn_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                Description = "Select a destination folder"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DestinationTB.Text = dialog.SelectedPath;
            }
        }

        private void ExtractBtn_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = $"Processing...";
            ExtractBtn.Enabled = false;
            try
            {
                using (Stream fileStream = new FileStream(SourceTB.Text, FileMode.Open, FileAccess.Read)) 
                {
                    PdfLoadedDocument loadedDocument = new PdfLoadedDocument(fileStream);
                    string output = "";
                    var path = DestinationTB.Text;
                    for (int i = 0; i < loadedDocument.Pages.Count; i++)
                    {
                        Directory.CreateDirectory($"{path}\\Images");

                        PdfPageBase page = loadedDocument.Pages[i];

                        var text = page.ExtractText(true);

                        output += $"{(flipTextCheckBox.Checked? FlipText(text) : text)}\n\n\n";
                        var images = page.ExtractImages().Cast<Bitmap>();

                        for (int j = 0; j < images.Count(); j++)
                        {
                            images.ElementAt(j).Save($"{path}\\Images\\Page {i+1} Image {j+1}.png", ImageFormat.Png);
                        }

                    }


                    using (StreamWriter writer = new StreamWriter(path+"\\Text.txt"))
                    {
                        writer.Write(output);
                        writer.Close();
                    }

                    loadedDocument.Close(true);
                    fileStream.Close();

                    OutputLabel.ForeColor = Color.DarkGreen;
                    OutputLabel.Text = $"Great Success!";
                }
            }
            catch (Exception ex)
            {
                OutputLabel.ForeColor = Color.Red;
                OutputLabel.Text = $"Error: {ex.Message}";
            }
            ExtractBtn.Enabled = true;
        }

        private string FlipText(string text)
        {
            var lines = Regex.Split(text, "\r\n|\r|\n");
            var result = "";
            foreach(var line in lines)
            {
                var reverseLine = string.Join("", line.Reverse());
                var matches = regex.Matches(reverseLine);
                foreach(Match match in matches)
                {
                    if (!string.IsNullOrWhiteSpace(match.Value) 
                        && letterNumbers.IsMatch(match.Value))
                    {
                        var reverseMatch = string.Join("", match.Value.Reverse());

                        Debug.WriteLine($"Match: {match.Value} => {reverseMatch} :Reverse");
                        reverseLine = reverseLine.Replace(match.Value, reverseMatch);
                    }
                }

                string finalResult = reverseLine;
                var innerMatches = regex.Matches(reverseLine).Select(m => m.Value).Where(m => !string.IsNullOrWhiteSpace(m));
                if (innerMatches.Any() && !string.IsNullOrWhiteSpace(reverseLine))
                {
                    finalResult = "";
                    var splitInner = reverseLine.Split(innerMatches.First());

                    for (int i = 1; i < innerMatches.Count(); i++)
                    {
                        List<string> output = new List<string>();
                        foreach (var str in splitInner)
                        {
                            output.AddRange(str.Split(innerMatches.ElementAt(i)));
                        }
                        splitInner = output.ToArray();
                    }

                    int matchIndex = innerMatches.Count() - 1;
                    for (int i = splitInner.Length - 1; i >= 0; i--)
                    {
                        finalResult += splitInner[i] + ((i == 0 || matchIndex <= 0) ? "" : innerMatches.ElementAt(matchIndex));
                        matchIndex--;
                    }

                    //foreach (string innerMatch in innerMatches)
                    //{
                    //    var splitInner = finalResult.Split(innerMatch).Reverse();
                    //    string innerResult = "";
                    //    for (int i=0; i<splitInner.Count(); i++)
                    //    {
                    //        innerResult 
                    //            += splitInner.ElementAt(i) 
                    //            + (i == splitInner.Count()-1? "" : innerMatch);
                    //    }
                    //    Debug.WriteLine($"Inner result: {innerResult}");
                    //    finalResult = innerResult;
                    //}
                    Debug.WriteLine($"Result: {finalResult}");
                }
                result += finalResult + "\n";
            }
            return result;
        }
    }
}
