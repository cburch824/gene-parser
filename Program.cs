// See https://aka.ms/new-console-template for more information

using gene_parser;

List<string> geneFilepaths = new List<string>();
List<string> geneStrings = new List<string>();
List<string> genes = new List<string>();

geneFilepaths = Directory.GetFiles("resources").ToList();

geneFilepaths.ForEach(filepath => geneStrings.AddRange(GeneString.GetGeneStringsFromFile(filepath)));
geneStrings.ForEach(geneString => genes.AddRange(GeneString.GetGenesFromString(geneString)));
genes = genes.Distinct().ToList();

File.WriteAllLines("AllGenes.txt", genes);
