﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDateTime
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 25)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            //var summary = String.Join(" ", summaryWords) + "...";
            //return summary;
            return String.Join(" ", summaryWords) + "...";
        }

    }
}