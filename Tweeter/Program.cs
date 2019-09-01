namespace Tweeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show all tweets in the local file
            TweetManager.ShowAll();
            // Search for a tag 'Leaf' in the local file
            TweetManager.ShowAll("Leaf");
            // Search for a tag 'LEAF' in the local file - Case Insensitive
            TweetManager.ShowAll("LEAF");
            // Search for a tag 'JAKE', which dose not exist in the local file
            TweetManager.ShowAll("JAKE");
        }
    }
}
