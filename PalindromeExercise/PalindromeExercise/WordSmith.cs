﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string word)
        {
            //var reversed = "";

            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    reversed += word.ToLower()[i];
            //}

            //if (reversed == word.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return word.ToLower().SequenceEqual(word.ToLower().Reverse());

        }
    }
}
