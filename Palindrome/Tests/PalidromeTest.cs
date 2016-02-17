using System.Collections.Generic;
using Xunit;
namespace PalidromeProject.Objects
{
  public class PalidromeTest
  {
    [Fact]
    public void testPalidrome_race_false()
    {
      Palidrome newPalidrome = new Palidrome("race");
      Assert.Equal(newPalidrome.IsPalidrome(),false);
    }
    [Fact]
    public void testPalidrome_racecar_true()
    {
      Palidrome newPalidrome = new Palidrome("racecar");
      Assert.Equal(newPalidrome.IsPalidrome(),true);
    }
    [Fact]
    public void testPalidrome_NurseIspygypsiesrun_true()
    {
      Palidrome newPalidrome = new Palidrome("Nurse, I spy gypsies, run!");
      Assert.Equal(newPalidrome.IsPalidrome(),true);
    }
  }
}
