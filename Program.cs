using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time < 12 && time >= 7)
            {
                Console.WriteLine("İyi Günler");

            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi akşamlar");
            }
            string sonuc = time <= 18 ?" iyi günler": "iyi geceler";
                Console.WriteLine(sonuc);
            sonuc = time>=6 && time<=11 ? "Günaydın": time <= 18 ? "iyi günler": "iyi geceler";

        }
    }
}