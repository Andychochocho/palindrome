using System.Collections.Generic;
using System;

namespace Allergies.Objects
{
  public class AllergyScore
  {
    private int _score;
    private static Tuple<string, int>[] _allergyArray =
    {
      Tuple.Create("cats", 128),
      Tuple.Create("pollen", 64),
      Tuple.Create("chocolate", 32),
      Tuple.Create("tomatoes", 16),
      Tuple.Create("strawberries", 8),
      Tuple.Create("shellfish", 4),
      Tuple.Create("peanuts", 2),
      Tuple.Create("eggs", 1)
    };

    public AllergyScore(int score)
    {
      _score = score;
    }
    public Tuple<string, int>[] GetAllergyArray()
    {
      return _allergyArray;
    }
    public List<string> AllergiesList()
    {
      int loopCounter = 0;
      List<string> outputList = new List<string>{};
      Tuple<string, int>[] allergyArray = this.GetAllergyArray();
      int currentScore = this._score;
      while (currentScore>0)
      {
        // loopCounter++;
        // if (loopCounter>500){break;}
        {
          for (int i=0; i<allergyArray.Length; i++)
          {
            if(currentScore>=allergyArray[i].Item2)
            {
              outputList.Add(allergyArray[i].Item1);
              currentScore -= allergyArray[i].Item2;
            }
          }
        }
      }
      return outputList;
    }
  }
}
