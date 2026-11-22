using System;

class Program
{
    static void Main(string[] args)
    {
        VideoLibrary videoLibrary = new VideoLibrary();

        Video video1 = new Video("El amor - El gran mandamiento", "Canal Nefita", 437);
        video1.AddComment(new Comment("Matias", "Qué buen video, me gustó mucho."));
        video1.AddComment(new Comment("Ana", "Muy edificante."));
        video1.AddComment(new Comment("Luis", "Gracias por compartirlo."));

        Video video2 = new Video("How to Build a Successful Morning Routine", "James Carter", 506);
        video2.AddComment(new Comment("Javier", "This was exactly what I needed."));
        video2.AddComment(new Comment("Sofia", "Great tips, thank you."));
        video2.AddComment(new Comment("Pedro", "I'll try this tomorrow."));

        Video video3 = new Video("Faith in Jesus Christ", "Canal Nefita", 312);
        video3.AddComment(new Comment("Carla", "It helped me a lot."));
        video3.AddComment(new Comment("Diego", "Excellent message."));
        video3.AddComment(new Comment("Laura", "Thanks for uploading it."));

        videoLibrary.AddVideo(video1);
        videoLibrary.AddVideo(video2);
        videoLibrary.AddVideo(video3);

        videoLibrary.GetDisplay();
   }    
}

