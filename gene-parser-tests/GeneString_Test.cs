using gene_parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace gene_parser_tests
{
  public class GeneString_Test
  {
    [Fact]
    public void GetGeneStringsFromFile_TestFileInput_GetCorrectStrings()
    {
      string testFilepath = "resources_test/ydcNsutRstring_interactions_short_test";

      List<string> expected = new List<string>
      {
        "adeQ	ydcO	511145.b3664	511145.b1433	0	0	0	0	0	0	0	0.730	0.730",
        "frlA	srlR	511145.b3370	511145.b2707	0	0	0	0	0	0	0	0.421	0.420",
        "yhaJ	yjjQ	511145.b3105	511145.b4365	0	0	0	0	0	0	0	0.479	0.479"
      };

      List<string> result = GeneString.GetGeneStringsFromFile(testFilepath);

      Assert.Equal(expected, result);
    }

    [Fact]
    public void GetGenesFromString_TestStringInput_GetsCorrect2Genes()
    {
      string testGeneString = "adeQ	ydcO	511145.b3664	511145.b1433	0	0	0	0	0	0	0	0.730	0.730";

      List<string> expected = new List<string>
      {
        "adeQ",
        "ydcO"
      };

      List<string> result = GeneString.GetGenesFromString(testGeneString);

      Assert.Equal(expected, result);
    }
  }
}
