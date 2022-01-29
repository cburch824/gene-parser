using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gene_parser
{
  public static class GeneString
  {

    public static List<string> GetGeneStringsFromFile(string filepath)
    {
      List<string> geneStrings = File.ReadAllLines(filepath).ToList();
      geneStrings.RemoveAt(0); // remove header

      return geneStrings;
    }

    public static List<string> GetGenesFromString(string geneString)
    {
      List<string> geneStringSplit = geneString.Split("\t").ToList();
      List<string> genes = new List<string> {geneStringSplit[0], geneStringSplit[1]};

      return genes;
    }
  }
}
