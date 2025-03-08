using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("eating","mukbang", 90);
        Video video2 = new Video("running","speed", 80);
        Video video3 = new Video("fighting","lefthookmaster", 70);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Comment v1comment1 = new Comment("John", "That looks delicious!");
        Comment v1comment2 = new Comment("James", "I wish that was me eating that!");
        Comment v1comment3 = new Comment("karen", "Lame video...");
        video1._comments.Add(v1comment1);
        video1._comments.Add(v1comment2);
        video1._comments.Add(v1comment3);

        Comment v2comment1 = new Comment("Patty", "You're an inspiration!");
        Comment v2comment2 = new Comment("Patrick", "Wow that's amazing!");
        Comment v2comment3 = new Comment("Pizza", "You probably take steroids");
        video2._comments.Add(v2comment1);
        video2._comments.Add(v2comment2);
        video2._comments.Add(v2comment3);

        Comment v3comment1 = new Comment("Tyrone", "I bet I can beat you in a street fight");
        Comment v3comment2 = new Comment("Tyler", "You're distance control is really good");
        Comment v3comment3 = new Comment("Taylor", "I love you so much......");
        video3._comments.Add(v3comment1);
        video3._comments.Add(v3comment2);
        video3._comments.Add(v3comment3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }

}