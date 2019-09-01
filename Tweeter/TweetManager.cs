using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tweeter
{
    class TweetManager
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME = @"test.txt";

        static TweetManager()
        {
            TWEETS = new List<Tweet>();
            string line;

            using (TextReader reader = new StreamReader(FILENAME))
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    TWEETS.Add(Tweet.Parse(line));

                    line = reader.ReadLine();
                }
            }
        }

        public static void Initialize()
        {
            TWEETS = new List<Tweet>();

            TWEETS.Add(new Tweet("Raptors", "Obama", "Drake", "Go Raptors! Go!", "10001"));
            TWEETS.Add(new Tweet("Raptors", "Drake", "Tory", "Yes Toronto will get them!", "10002"));
            TWEETS.Add(new Tweet("Raptors", "Obama", "Tory", "Toronto joins cities around the world to celebrate International Day Against Homophobia & Transphobia", "10003"));
            TWEETS.Add(new Tweet("Taxes", "Bieber", "Drake", "Go Raptors! Go!", "10004"));
            TWEETS.Add(new Tweet("COYS", "Sonny", "Harry Kane", "We gotta win!", "10005"));
        }

        public static void ShowAll()
        {
            foreach (var tweet in TWEETS)
            {
                Console.WriteLine(tweet);
            }
        }

        public static void ShowAll(string tag)
        {
            // Check if a certain tag exists
            var isFound = TWEETS.Any(t => t.Tag.ToUpper() == tag.ToUpper());

            if (isFound)
            {
                // Set the ConsoleColor to White
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"[ Tweets with a Tag #{tag} ]\n");

                foreach (var tweet in TWEETS)
                {
                    if (tweet.Tag.ToUpper() == tag.ToUpper())
                    {
                        Console.WriteLine(tweet);
                    }
                }
            }
            else
            {
                // Set the ConsoleColor to Red
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"[ Tweets with a Tag #{tag} are not found in the list ]\n");
            }
        }
    }
}
