using System.Collections.Generic;
using System;

namespace PalidromeProject.Objects
{
  public class Palidrome
  {
    private string _word;

    public Palidrome(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public bool IsPalidrome()
    {
      string word = this.GetWord();

      string[] specialCharacter = {"!","@","#","$","%","^","&","*","_","-","+","=", " ", ".",","};

      word = word.Trim();
      word = word.ToLower();

       foreach (string element in specialCharacter)
       {
         word = word.Replace(element, "");
       }

      int wordLength = word.Length;

      for (int i = 0; i<wordLength; i++)
      {
        if (word[i] != word[wordLength-(1+i)])
        {
          return false;
        }
      }
        return true;

    }
  }
}
