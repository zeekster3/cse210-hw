using System;
using System.Collections.Generic;

public class Comment
{
    private string commenterName;
    private string commentText;

    public Comment(string commenterName, string commentText)
    {
        this.commenterName = commenterName;
        this.commentText = commentText;
    }

    public string GetCommenterName() => commenterName;
    public string GetCommenterText() => commentText;
}

public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment) => comments.Add(comment);
    public int GetNumberOfComments() => comments.Count;
    public string GetTitle() => title;
    public string GetAuthor() => author;
    public int GetLengthInSeconds() => lengthInSeconds;
    public List<Comment> GetComments() => comments;
}

public class Channel
{
    private string channelName;
    private int subscriberCount;
    private List<Video> videos;

    public Channel(string channelName, int subscriberCount)
    {
        this.channelName = channelName;
        this.subscriberCount = subscriberCount;
        videos = new List<Video>();
    }

    public void AddVideo(Video video) => videos.Add(video);
    public int GetTotalVideos() => videos.Count;

    public int GetTotalComments()
    {
        int total = 0;
        foreach (var video in videos)
        {
            total += video.GetNumberOfComments();
        }
        return total;
    }

    public void DisplayChannelSummary()
    {
        Console.WriteLine($"Channel: {channelName}");
        Console.WriteLine($"Subscribers: {subscriberCount}");
        Console.WriteLine($"Total Videos: {GetTotalVideos()}");
        Console.WriteLine($"Total Comments: {GetTotalComments()}\n");

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommenterText()}");
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Beat This Race, Win this Lamborghini", "Mr.Beast", 1200000);
        video1.AddComment(new Comment("Braiden", "So cool"));
        video1.AddComment(new Comment("Ben", "Wow such a great video"));
        video1.AddComment(new Comment("Maddy", "I wish I could win that!"));
        video1.AddComment(new Comment("Connor", "Better luck next time"));

        Video video2 = new Video("How Jesus Christ Restores What Is Broken", "The Church Of Jesus Christ Of Latter Day Saints", 153000);
        video2.AddComment(new Comment("Suzy", "So inspirational"));
        video2.AddComment(new Comment("Mark", "I love this!"));
        video2.AddComment(new Comment("Cary Ann", "The Savior does restore what is broken"));
        video2.AddComment(new Comment("Jeff", "This one hits hard"));

        Video video3 = new Video("Making Homemade Pizza", "Chef", 350);
        video3.AddComment(new Comment("Gary", "Looks tasty"));
        video3.AddComment(new Comment("Michelle", "I'll definitely have to try this out"));
        video3.AddComment(new Comment("Hank", "This is a great recipe, thank you!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Print videos summary
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommenterText()}");
            }
            Console.WriteLine(new string('-', 40));
        }

        // Optional: create a channel and add videos to see the channel summary
        Channel channel = new Channel("Awesome Channel", 50000);
        channel.AddVideo(video1);
        channel.AddVideo(video2);
        channel.AddVideo(video3);

        Console.WriteLine("\nChannel Summary:\n");
        channel.DisplayChannelSummary();
    }
}