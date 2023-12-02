using System;

class Program
{
    static void Main(string[] args)
    {
        Video BestVideo = new Video("Best Video", "Cool Guy", 72);
        BestVideo.AddComment("Cool Dude", "This is the best video ever!");

        BestVideo.DisplayVideo();
        BestVideo.DispalyNumComments();
        BestVideo.DisplayComments();
    }
}