using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = CreateVideos();
        DisplayVideos(videos);
    }

    static List<Video> CreateVideos()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Tried it and loved it."));
        video1.AddComment(new Comment("Charlie", "That's a spicy meatball."));
        videos.Add(video1);

        Video video2 = new Video("Coding Tips with Keyboard ASMR", "KeebLovr89", 900);
        video2.AddComment(new Comment("Dave", "Very relaxing."));
        video2.AddComment(new Comment("Eve", "Who likes this stuff!?"));
        video2.AddComment(new Comment("Frank", "Thanks for the tips!"));
        videos.Add(video2);

        Video video3 = new Video("Learn C# in 10 Minutes!", "CodeMaster", 700);
        video3.AddComment(new Comment("Grace", "Awesome tutorial!"));
        video3.AddComment(new Comment("Heidi", "You look weird."));
        video3.AddComment(new Comment("Ivan", "This video bad."));
        videos.Add(video3);

        return videos;
    }

    static void DisplayVideos(List<Video> videos)
    {
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
