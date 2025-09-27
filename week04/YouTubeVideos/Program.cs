using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videos = new List<Video>();

        Video video1 = new Video("OOP in C#", "Juan", 240);
        video1.AddComment(new Comment("Charles", "I wish they have tought me that way in school."));
        video1.AddComment(new Comment("Charles", "Nice!"));
        video1.AddComment(new Comment("Charles", "So clear!"));

        Video video2 = new Video("Do While loop", "Juan", 185);
        video2.AddComment(new Comment("Erica", "Great work!"));
        video2.AddComment(new Comment("Jason", "Great tutorial!"));
        video2.AddComment(new Comment("David", "Thanks!"));


        Video video3 = new Video("Argentina World Champion","Rodrigo" ,850);
        video3.AddComment(new Comment("José", "El GOAT se lo merece"));
        video3.AddComment(new Comment("Claudia", "Te amamos Messi"));
        video3.AddComment(new Comment("Primero, Messi se lo merecía. Segundo, Francia", "Nahuel"));

        Video video4 = new Video("How to Bake a Chocolate Cake", "Anna", 432);
        video4.AddComment(new Comment("Alicia", "Yummy!"));
        video4.AddComment(new Comment("Isaias", "It looks tasty!"));
        video4.AddComment(new Comment("Alicia", "I can't wait to try it!"));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video v in videos)
        {
            Console.WriteLine(v.GetDisplayText());
        }
    }
}