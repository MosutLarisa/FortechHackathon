using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortechHackathon
{
    internal class DecryptClass
    {
        public static string Decrypt(string input)
        {
            input = Task1(input);
            return input;
        }
        public static string Task1(string text)
        {
            text = text.Replace("^", "");
            text = text.Replace("~", "");
            return Task2(text);
        }

        public static string Task2(string text)
        {   
            text = text.Replace("{", " ");
            text = text.Replace("}", " ");
            text = text.Replace("(", " ");
            text = text.Replace(")", " ");
            return Task3(text);
        }

        public static string Task3(string text)
        {
            Dictionary<char, char> cifreCuLitere = new Dictionary<char, char>
            {
            {'0', 'A'},
            {'1', 'B'},
            {'2', 'C'},
            {'3', 'D'},
            {'4', 'E'},
            {'5', 'F'},
            {'6', 'G'},
            {'7', 'H'},
            {'8', 'I'},
            {'9', 'J'}
            };

            foreach (var kvp in cifreCuLitere)
            {
                text = text.Replace(kvp.Key, kvp.Value);
            }


            return Task4(text);
        }

        private static string Task4(string input)
        {
            string output = "";
            int inputIndex = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                output = output + input[inputIndex];
                inputIndex--;
            }
            return Task5(output);
        }

        public static string Task5(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                int key = i % (Constants.Key.Length);
                int swiftKey = 0;
                for (int k = 0; k < Constants.Alphabet.Length; k++)
                {
                    if (Constants.Key[key] == Constants.Alphabet[k])
                    {
                        swiftKey = k;
                        break;
                    }
                }

                for (int k = 0; k < Constants.Alphabet.Length; k++)
                {
                    if (input[i] == Constants.Alphabet[k])
                    {
                        if ((k - swiftKey) >= 0)
                            output += Constants.Alphabet[(k - swiftKey) % Constants.Alphabet.Length];
                        else
                            output += Constants.Alphabet[Constants.Alphabet.Length + k - swiftKey];
                        break;

                    }

                }
            }
            return output;

        }
    }
}
