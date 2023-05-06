using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {

        word = word.ToLower();

        for(int i=0;i<word.Length;i++)
        for(int n = 0; n < word.Length; n++)
        if((word[i] == word[n]) && (i != n) && (word[i] != '') && (word[i] != '-'))

        return false;

        return true;
    }

}
