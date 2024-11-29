namespace AnagramGenerator
{
    public class Program
    {
        public static void Main()
        {
            List<String> anagrams = AnagramGeneration("abcd");
            foreach(String anagram in anagrams) 
            {
                Console.WriteLine(anagram);
            }

            Console.WriteLine($"\nThere are {anagrams.Count} anagrams.");
        }

        private static List<String> AnagramGeneration(String word)
        {
            // Base case, only one letter is left in the word
            if (word.Length == 1)
            {
                return [word];
            }

            List<String> anagrams = [];

            // Calls the method with the first character removed
            List<String> subAnagrams = AnagramGeneration(word.Substring(1));

            // Iterating over each substring anagram
            foreach(String subAnagram in subAnagrams) 
            {
                for(int i = 0; i < word.Length; i++) 
                {
                    anagrams.Add(subAnagram.Insert(i, word[0].ToString()));
                }
            }

            return anagrams;
        }
    }
}
