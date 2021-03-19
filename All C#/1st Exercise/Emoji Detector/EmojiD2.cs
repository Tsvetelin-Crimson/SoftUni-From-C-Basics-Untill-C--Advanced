using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class EmojiD2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string numbersPatern = @"[0-9]";
            string emojiPatern = @"[*]{2}([A-Z][a-z]{2,})[*]{2}|[:]{2}([A-Z][a-z]{2,})[:]{2}";

            MatchCollection matches = Regex.Matches(input, numbersPatern);


            long coolThreshold = 1;
            foreach (Match number in matches)
            {
                int currNumber = int.Parse(number.ToString());
                coolThreshold *= currNumber;
            }
            //Console.WriteLine(coolThreshold);
            MatchCollection emojiMatches = Regex.Matches(input, emojiPatern);
            List<string> validEmojis = new List<string>();
            int countOfEmojis = 0;
            foreach (Match emoji in emojiMatches)
            {
                countOfEmojis++;
                string starEmoji = emoji.Groups[1].ToString();
                string semiColonEmoji = emoji.Groups[2].ToString();
                if (starEmoji == "")
                {
                    int coolness = 0;
                    for (int i = 0; i < semiColonEmoji.Length; i++)
                    {
                        coolness += semiColonEmoji[i];
                    }
                    if (coolness > coolThreshold) //could need an "="
                    {
                        semiColonEmoji = "::" + semiColonEmoji + "::";
                        validEmojis.Add(semiColonEmoji);
                    }
                }
                else
                {
                    int coolness = 0;
                    for (int i = 0; i < starEmoji.Length; i++)
                    {
                        coolness += starEmoji[i];
                    }
                    if (coolness > coolThreshold) //could need an "="
                    {
                        starEmoji = "**" + starEmoji + "**";
                        validEmojis.Add(starEmoji);
                    }
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{countOfEmojis} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", validEmojis));
        }
    }
}
