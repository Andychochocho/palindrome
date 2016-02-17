using System.Collections.Generic;
using Xunit;
namespace Allergies.Objects
{
  public class AllergyScoreTest
  {
    [Fact]
    public void testAllergiesList_1_eggs()
    {
      AllergyScore newAllergyScore = new AllergyScore(1);
      List<string> dummyList = new List<string> {"eggs"};
      Assert.Equal(newAllergyScore.AllergiesList(), dummyList);
    }
    [Fact]
    public void testAllergiesList_160_catschocolate()
    {
      AllergyScore newAllergyScore = new AllergyScore(160);
      List<string> dummyList = new List<string> {"cats", "chocolate"};
      Assert.Equal(newAllergyScore.AllergiesList(), dummyList);
    }
  }

}
