using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepOnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //the below is three palindrome  tests which is a word
            //that begins and ends with the same letter
            if (!IsPalindrome("mom")) { Console.WriteLine("error!"); } else { Console.WriteLine("Ola"); }
            if (!IsPalindromeReverseString("mom")) { Console.WriteLine("error!"); } else { Console.WriteLine("Ola"); }
            if (!IsPalindrome("mom")) { Console.WriteLine("error!"); } else { Console.WriteLine("Ola"); }
            if (!isPalindromeStringBuilder("BABAB")) { Console.WriteLine("error!"); } else { Console.WriteLine("Ola"); }
            //writing a method that revomes any charater
            //loop through the string and if its that character you delete
            //removing a in sasa
            string kept = remove("sasa", 'a');
            Console.WriteLine(kept);
            //placing similar to removing
            string replace = replacement("sasa", 'a', 'f');
            Console.WriteLine(replace);

            //about to check for thee first non repeating character in string
            char firstnonrepeating = FirstNonRepeatingChar("swiss");
            Console.WriteLine(firstnonrepeating);
            char firstrepeating = FirstRepeatingChar("swiss");
            Console.WriteLine(firstrepeating);
            //counting the occurence of the character in a string
            int countedAmount = CountCharacterOccurrence("Stringing", 'n');
            Console.WriteLine(countedAmount);

            //checking different combinations of a string so if abc
            //output should be abc,acb, bac, bca, cba,cab
            string str = "ABC";
            Permute(str, 0,str.Length );
            //string str2 = "ABCB";
            //Permute(str2, 0, str2.Length);
            //string strNums = "1253";
            //Permute(strNums, 0, strNums.Length);

            //to check if a string is an anagram of thee other make the strrings char arrays
            //and then sort   
            //if they the same array then its an anagram
            if (!(IsAnagram("fried", "fired"))) { Console.WriteLine("Error"); } else { Console.WriteLine("True for days"); }
            if (!(IsAnagram("wasp", "swap"))) { Console.WriteLine("Error"); } else { Console.WriteLine("True for days"); }
            int letsee = ParsingOutStringInt("1320");
            Console.WriteLine(letsee);
            // whats left is creating a number to word number

            Console.ReadKey();
        }
        public static int ParsingOutStringInt(string number)
        {
           try
            {
                int i = int.Parse(number);
                return i;

            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public static int CountCharacterOccurrence(string word, char charCounted)
        {
            int count = 0;
            char[] lettersInWord = word.ToCharArray();
            foreach (char c in lettersInWord)
            {
                if (c == charCounted)
                {

                    count++;

                }
              
            }


            return count;

        }

        public static bool IsAnagram(string word, string anagram)
        {
            char[] charArrayFromWord = word.ToCharArray();
            char[] charArrayFromAnagram = anagram.ToCharArray();

            Array.Sort(charArrayFromWord);
            Array.Sort(charArrayFromAnagram);

            //string[] doesstringarrayhavesort = new string[21];
            //doesstringarrayhavesort doesnt have sort function/method
            bool bValidArray = true;
           for (int i = 0; i < word.Length - 1; i++)
            {
                if (charArrayFromAnagram[i] != charArrayFromWord[i])
                    return false;
            }
            return  bValidArray;
        }
     
        public static string Swap(string a, int leftSwap, int rightSwap )
        {

            char cTemp;//kept char
            char[] charArray = a.ToCharArray();
            cTemp = charArray[leftSwap];
            charArray[leftSwap] = charArray[rightSwap];
            charArray[rightSwap] = cTemp;

            string s = new string(charArray);
            return s;

        }

        public static void Permute(string str, int startingIndex, int endingIndex)
        {
if(startingIndex == endingIndex)
            {
                Console.WriteLine(str);
            }
else
            {
                for (int i = startingIndex; i < endingIndex; i++)
                {
                    str = Swap(str, startingIndex, i);
                    Permute(str, startingIndex + 1, endingIndex);
                    str = Swap(str, startingIndex, i);

                }
            }

        }

        public static char FirstNonRepeatingChar(string word)
        {
            List<char> repeating = new List<char>();
            List<char> nonrepeating = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetterInWord =  word[i] ;
                if(repeating.Contains(currentLetterInWord))
                {
                    continue;
                }
                if(nonrepeating.Contains(currentLetterInWord))
                {
                   nonrepeating.Remove(currentLetterInWord);
                    repeating.Add(currentLetterInWord);
                }else
                {
                    nonrepeating.Add(currentLetterInWord);
                }

            }

            return nonrepeating[0];

        }
        public static char FirstRepeatingChar(string word)
        {
            List<char> repeating = new List<char>();
            List<char> nonrepeating = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetterInWord = char.Parse(word.Substring(i, 1));
                if (repeating.Contains(currentLetterInWord))
                {
                    continue;
                }
                if (!nonrepeating.Contains(currentLetterInWord))
                {
                    repeating.Remove(currentLetterInWord);
                    nonrepeating.Add(currentLetterInWord);
                }
                else
                {
                    repeating.Add(currentLetterInWord);
                }

            }

            return repeating[0];

        }

        public static string remove(string word, char cUnwanted)
        {
            string skeep = String.Empty;
            StringBuilder sb = new StringBuilder();
            char[] lettersInWord = word.ToCharArray();
            foreach  (char c in lettersInWord)
            {
                if(c != cUnwanted)
                {
                    //adding everything except unwanted char
                    skeep += c;
                    sb.Append(c);
                }
            }

            return skeep ;//return sb
        }
        public static string replacement(string word, char cUnwanted, char replacementChar)
        {
           
            StringBuilder sb = new StringBuilder();
            char[] lettersInWord = word.ToCharArray();
            foreach (char c in lettersInWord)
            {
                if (c == cUnwanted)
                {

                    sb.Append(replacementChar);
                 
                }
                else
                {
                   
                    sb.Append(c);
                }
            }


            return sb.ToString();
        }



        public static bool IsPalindromeReverseString(string text)
        {
            string reverse = string.Empty;

            if (text.Length == 0 || text == null) { return false; }
            string plain = text.ToLower();
            char[] charPlain = new char[text.Length];
            charPlain = plain.ToCharArray();
            for (int i = charPlain.Length -1 ; i >= 0 ; i--)
            {
                reverse += charPlain[i];
                //or just creat a string an use string to charArray indexing String[1] 
                //reserve[i] = charPlain[i];
            }

            return (reverse).Equals(plain);
             
        }
        //reverse using string builder

            public static bool isPalindromeStringBuilder(String text)
        {
            if (text.Length == 0 || text == null) { return false; }
            StringBuilder sb = new StringBuilder();
            char[] array = text.ToCharArray();
            for(int i = text.Length -1; i>= 0; i--)
            {
                sb.Append(array[i]);
            }
           
            string reverseOfString = sb.ToString();
            return text.Equals(reverseOfString);

        }
            public static Boolean IsPalindrome(string text)
        {
            // we going to iterate through a giving string, forward and back word using on charater at a time
            string clean = text.ToLower();
            int length = clean.Length;

            int iForwardWeGo = 0;
            int iBackward = length - 1;

            while (iBackward > iForwardWeGo)
            {
                //we going to check character by charcter if the string belows there
                //char forwardChar = clean[iForwardWeGo];
                //char backwardChar = clean[iBackward];
                char forwardChar = char.Parse(clean.Substring(iForwardWeGo,1));
                char backwardChar = char.Parse(clean.Substring(iBackward, 1));


                if (forwardChar != backwardChar)
                {
                    return false;
                }
                iBackward--;
                iForwardWeGo++;
                
            }
            return true;

        }
        //below is using recursive


        public static String reversethisrecusively(string input)
        {

            if (input == null || input == string.Empty || string.IsNullOrEmpty(input)) { return input; }
            return input.Substring(input.Length - 1, 1) + reversethisrecusively(input.Substring(0, input.Length - 1));

        }
        public static bool isPalindromeString(string text)
        {
            string reverse = reversethisrecusively(text);
            if (text.Equals(reverse))
            {
                return true;
            }
            return false;
        }
    }
}
