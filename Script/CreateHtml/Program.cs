namespace CreateHtml
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var EAN8directoryPath = @"..\..\..\..\..\PDFBarcode\EAN8";
			var EAN8directoryAbsoluthPath = Path.GetFullPath(EAN8directoryPath);
			var EAN8exampleRelativePath = @"..\..\..\..\..\PDFBarcode\EAN8template.html";
			var EAN8exampleAbsoluthPath = Path.GetFullPath(EAN8exampleRelativePath);

			var EAN13directoryPath = @"..\..\..\..\..\PDFBarcode\EAN13";
			var EAN13directoryAbsoluthPath = Path.GetFullPath(EAN13directoryPath);
			var EAN13exampleRelativePath = @"..\..\..\..\..\PDFBarcode\EAN13template.html";
			var EAN13exampleAbsoluthPath = Path.GetFullPath(EAN13exampleRelativePath);

			UpdateFiles(EAN8directoryAbsoluthPath, EAN8exampleAbsoluthPath);
			UpdateFiles(EAN13directoryAbsoluthPath, EAN13exampleAbsoluthPath);
		}

		private static void UpdateFiles(string directoryAbsoluthPath, string exampleAbsoluthPath)
		{
			var files = Directory.GetFiles(directoryAbsoluthPath, "*.html");
			var exampleFile = File.ReadAllLines(exampleAbsoluthPath);

			foreach (var file in files)
			{
				var fileLines = File.ReadAllLines(file);

				for (var i = 0; i < exampleFile.Length; i++)
				{
					var line = exampleFile[i];
					if (string.IsNullOrEmpty(line)) continue;

					fileLines[i] = line;
				}

				File.WriteAllLines(file, fileLines);
			}
		}
	}
}
