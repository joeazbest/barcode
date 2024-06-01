namespace CreateHtml
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var directoryPath = @"..\..\..\..\..\PDFBarcode\EAN8";
			var directoryAbsoluthPath = Path.GetFullPath(directoryPath);
			var exampleRelativePath = @"..\..\..\..\..\PDFBarcode\EAN8template.html";
			var exampleAbsoluthPath = Path.GetFullPath(exampleRelativePath);

			var files = Directory.GetFiles(directoryAbsoluthPath);
			var exampleFile = File.ReadAllLines(exampleAbsoluthPath);

			foreach (var file in files)
			{
				var fileLines = File.ReadAllLines(file);
				var i = 0;
				foreach (var line in exampleFile)
				{
					if (string.IsNullOrEmpty(line)) continue;

					i++;

					fileLines[i] = line;
				}
			}
		}
	}
}
