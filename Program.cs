namespace The_Hang_Man_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var mystery_words = new List<string> (){ "Apple", "Bat", "Cat", "Dog", "Empty", "Flowers", "Gummy", "Hospital", "Ice Coffee", "Joy Stick" };
            Console.WriteLine("list count is " +mystery_words.Count+ ".");
            Console.WriteLine(mystery_words[6]);
        }
    }
}
