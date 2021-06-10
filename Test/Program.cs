using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PdfReader reader = new PdfReader("sample.pdf");
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += $"\nPAGE {page}:\n" + PdfTextExtractor.GetTextFromPage(reader, page) + "\n--------------------\n";
            }
            reader.Close();
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
