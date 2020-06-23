using System;

namespace hussein_free_youtube
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter tweet to post: ");
            string tweet = Console.ReadLine();
            Console.Write("Your Tweet is: ");
            Console.WriteLine(tweet);
            Console.WriteLine("Your tweet length is: " + tweet.Length);
            
        }
    }
}