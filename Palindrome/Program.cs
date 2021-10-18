using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] {  "one", "two", "three", "nOoN", 
                                        "Madam, I'm Adam", "madam", 
                                        "Hello", "Diowa", "lemon" , "Ten"};

            GetPalindromeNames(names); 
        }
         
        static void GetPalindromeNames(string[] names)
        {
            if(names != null)
            {
                foreach (var name in names)
                {
                    //removing the special characters
                    var cleanName = RemoveSpecialCharacters(name);

                    //process palindrome string
                    if (isPalindrome(cleanName))
                    {
                        Console.WriteLine(name);
                    }

                }
            } 
        }

        static bool isPalindrome(string cleanName)
        {

            //instantiate arrays of char
            (var reversedcharArr, var charArr) = (new char[cleanName.Length], new char[cleanName.Length]);

            //iterate through each chracters 
            for (var i = 0; i < cleanName.Length; i++)
            {
                charArr[i] = Char.ToLower(cleanName[i]);
                reversedcharArr[i] = Char.ToLower(cleanName[i]);
            }

            //reverse array
            Array.Reverse(reversedcharArr); 
             
            var result = false;

            //iterate and compare for equality
            for (var i = 0; i < charArr.Length; i++)
            {
                return (!charArr[i].Equals(reversedcharArr[i])) ? false : true;
            }

            return result;

        }


        static string RemoveSpecialCharacters(string word)
        {
            var unwantedCharacters = new Char[] { ' ', '\'', '.', ',' };

            foreach (char character in unwantedCharacters)
            {
                if (word.Contains(character))
                {
                    word.Replace(character.ToString(), string.Empty);
                }
            }

            return word;

        }  
    }
}
