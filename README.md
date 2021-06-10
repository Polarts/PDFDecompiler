# PDFDecompiler

A simple tool to "decompile" PDF files into separate text and images. Made to support Hebrew! 

## Intent and purpose

I made this tool for the specific purpose of splitting PDF files with text and images into a TXT file and a folder of image files, to assist in later processing.

For Hebrew (or any RTL language) there's a checkbox to flip text. The algorithm to flip the text was handwritten by me, inspired by old "Visual Hebrew vs. Logical Hebrew" conundrums. 

If you're unfamiliar with the subject, feel free to [expand your knowledge](https://www.w3.org/International/questions/qa-visual-vs-logical).

## Technical details

This project was written in Windows Forms, based on .NET 5. No specific design pattern was applied since the app performs one simple function.

You <i>should</i> be able to run it on any platform, thanks to .NET 5's cross-platform support. However, keep in mind that I currently expand the paths using Windows' `\` rather than the universal `/`.

If you want to add features for cross-platform support, feel free to open a PR.

## Future plans

Given the time, I might want to expand this tool to generate either HTML or DOCX files (or both, sounds fun actually). 

For now, the text flipping algorithm is not yet perfect, so I'll keep my focus at it with this project.

## Credits

Thanks to Syncfusion for their amazing [PDF Package](https://help.syncfusion.com/file-formats/pdf/overview) which is free to use for non-commercial projects!
