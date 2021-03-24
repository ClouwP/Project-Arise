using System;
namespace ProjectArise
{
    public class User
    {
        // Standart user information
        public string FirstName;
        public string LastName;
        public string Email;
        public DateTime Birtday;


        // Level based information
        private int _point = 0;
        private char _class = 'F';

        // Class point requirments
        private int _E = 10;
        private int _D = 50;
        private int _C = 100;
        private int _B = 200;
        private int _A = 400;
        private int _S = 1000;

        // Xp bar related information
        private int _barEnd = 10;
        private char[] _bar = new char[100];


        public User(string firstName, string lastName, string email, DateTime birtday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Birtday = birtday;
        }


        // Getting the information about the class
        public void GetClass()
        {
            Console.WriteLine($"Your level is {this._class}!");
        }


        // Setting up the point system
        public void AddPoints(int points)
        {
            if (this._class == 'F')
            {
                this._point += points;

                if (this._point >= this._E)
                {
                    this._class = 'E';
                    this._point -= 10;
                    this._barEnd = this._D;
                    Console.WriteLine($"Congratulations you achieved {this._class}class!");
                }

            }
            else if (this._class == 'E')
            {
                this._point += points;

                if (this._point >= this._D)
                {
                    this._class = 'D';
                    this._point -= 50;
                    this._barEnd = this._C;
                    Console.WriteLine($"Congratulations you achieved {this._class}class!");
                }
            }

            else if (this._class == 'D')
            {
                this._point += points;

                if (this._point >= this._C)
                {
                    this._class = 'C';
                    this._point -= 100;
                    this._barEnd = this._B;
                    Console.WriteLine($"Congratulations you achieved {this._class}class!");
                }
            }

            else if (this._class == 'C')
            {
                this._point += points;

                if (this._point >= this._B)
                {
                    this._class = 'B';
                    this._point -= 200;
                    this._barEnd = this._A;
                    Console.WriteLine($"Congratulations you achieved {this._class}class!");
                }
            }

            else if (this._class == 'B')
            {
                this._point += points;

                if (this._point >= this._A)
                {
                    this._class = 'A';
                    this._point -= 400;
                    this._barEnd = this._S;
                    Console.WriteLine($"Congratulations you achieved {this._class}class!");
                }
            }

            else if (this._class == 'A')
            {
                this._point += points;

                if (this._point >= this._S)
                {
                    this._class = 'S';
                    this._point -= 1000;
                    Console.WriteLine($"Congratulations you achieved {this._class}class!");
                }
            }
        }


        public void GetBar()
        {
            int Barpresention = 0;

            if (this._point != 0)
            {
                int Presention = this._barEnd / this._point;
                Barpresention = 100 / Presention;
            }

            for (int xp = 0; xp < Barpresention ; xp++)
            {
                this._bar[xp] = 'x';
            }
            for (int i = Barpresention; i < 100; i++)
            {
                this._bar[i] = '_';
            }

            Console.WriteLine("[{0}] {1}XP", string.Join("",this._bar),this._point);
        }


    }
}
