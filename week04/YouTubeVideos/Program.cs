using System;

namespace YouTubeVideos
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videosList = new List<Video>();

            // ---------------- VIDEO 1 ----------------
            Video v1 = new Video("Aprenda C# en 10 min", "PildorasInformaticas", 600);
            
            v1.AddComment(new Comment("Juan", "Excelente video", "2023-10-01"));
            v1.AddComment(new Comment("Maria", "No entendi un poco la parte de abstraccion", "2023-10-02"));
            v1.AddComment(new Comment("Pedro", "Gracias!", "2023-10-03"));
           
            videosList.Add(v1);

            // ---------------- VIDEO 2 ----------------
            Video v2 = new Video("Gatos Traviesos", "gatoMania", 120);
            v2.AddComment(new Comment("Luis", "Jajaja el gato naranja", "Hace 2 hora"));
            v2.AddComment(new Comment("Elena", "Que lindo miauu", "Hace 2 horas"));
            videosList.Add(v2);

            // ---------------- VIDEO 3 ----------------
            Video v3 = new Video("Tutorial de Cocina", "ChefPepito", 1800);
            v3.AddComment(new Comment("Carlos", "Se ve delicioso", "Ayer"));
            videosList.Add(v3);

            
            Console.WriteLine("Bienvenido a YouTube Console!");

            foreach (Video v in videosList)
            {
               
                v.DisplayInfo();
            }
        }
    }
}
