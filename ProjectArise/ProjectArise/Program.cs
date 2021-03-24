using System;

namespace ProjectArise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Player = new User("Achraf", "Faress", "A.faress.010@gmail.com", new DateTime(2000, 04, 03));

            Player.GetClass();
            Player.GetBar();
            Player.AddPoints(11);
            Player.GetBar();
        }
    }
}
