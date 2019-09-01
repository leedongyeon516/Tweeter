using System;

namespace Tweeter
{
    class Tweet
    {
        private static int CURRENT_ID;

        public string Tag { get; }
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Id { get; }

        public Tweet(string tag, string from, string to, string body)
        {
            Tag = tag;
            From = from;
            To = to;
            Body = body;
            Id = Convert.ToString(CURRENT_ID);

            CURRENT_ID++;
        }

        public Tweet(string tag, string from, string to, string body, string id)
        {
            Tag = tag;
            From = from;
            To = to;
            Body = body;
            Id = id;
        }

        public static Tweet Parse(string line)
        {
            string[] data = line.Split(new char[] { '\t' });

            Tweet tweet = new Tweet(data[0], data[1], data[2], data[3], data[4]);

            return tweet;
        }

        public override string ToString()
        {
            const int MaxLength = 37;
            string summarizedBody;

            // Set the ConsoleColor to Cyan
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Show a part of the body content using the Substring() method
            summarizedBody = Body.Length > MaxLength ? Body.Substring(0, MaxLength) + "..." : Body;

            return $"*\nTo: {To}\nFrom: @{From}({Id})\n" +
                   $"________________________________________________________________________________\n" +
                   $"{summarizedBody} #{Tag}\n\n";
        }
    }
}
