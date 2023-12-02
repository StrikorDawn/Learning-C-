using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video BestVideo = new Video("Best Video", "Cool Guy", 72);
        videos.Add(BestVideo);
        BestVideo.AddComment("Cool Dude", "This is the best video ever!");
        BestVideo.AddComment("Random Dude", "This Video made me cry!");
        BestVideo.AddComment("Rock Dude", "Epic content my guy!");
        BestVideo.AddComment("Batman", "I think my video is better, but good job!");
        
        Video CoolVideo = new Video("Cool Video", "Some Guy", 98);
        videos.Add(CoolVideo);
        CoolVideo.AddComment("Chicken_man", "This video ruffled my feathers!");
        CoolVideo.AddComment("Spookyman872", "Cool spooky game!");
        CoolVideo.AddComment("Sick Dude", "This is the craziest video ever!");
        CoolVideo.AddComment("Cool Dude", "If you like this video check out Cool Guy's Channel!");
        
        Video Avengers = new Video("Avengers", "Robert Downey Jr.", 82);
        videos.Add(Avengers);
        Avengers.AddComment("Mark Ruffelo", "Hulk is the best!");
        Avengers.AddComment("Chris Hemsworth", "Thor Looks so good!");
        Avengers.AddComment("Chris Pratt", "Wait were is StarLord!");
        Avengers.AddComment("Robert Downey Jr.", "Wrong movie, but Ironman is the best!");
        
        Video Batman = new Video("Batman", "Michal Bay", 79);
        videos.Add(Batman);
        Batman.AddComment("Batman1234", "This video was sick!!!");
        Batman.AddComment("Joker2341", "Could have used a little more Chaos if you ask me.");
        Batman.AddComment("Riddler?", "Riddle Me this... Where is my scene?");
        Batman.AddComment("Superman", "Good work Batman.");

        foreach (var movie in videos)
        {
            Console.WriteLine("===========================================");
            movie.DisplayVideo();
            Console.WriteLine("-------------------------------------------");
            movie.DispalyNumComments();
            Console.WriteLine();
            movie.DisplayComments();
            Console.WriteLine("===========================================");
        }
    }
}