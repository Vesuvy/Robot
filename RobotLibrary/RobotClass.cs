using System;
using System.Threading;

namespace RobotLibrary
{
    public class RobotClass
    {
        private string Name { get; set; }
        private int X { get; set; }
        private int Y { get; set; }
        public RobotClass(string name, int x, int y) { 
            Name = name;
            X = x;
            Y = y;
        }

        public void Moving()
        {

            Random rnd = new Random();

            int direction = 0;
            string[] directions = { "вперед", "назад", "вправо", "влево" };

            direction = rnd.Next(0, 4);
            switch (direction)
            {
                case 0:
                    Y++;
                    Console.WriteLine($"{Name} движется {directions[direction]} -> (X,Y) - ({X},{Y})");
                    break;
                case 1:
                    Y--;
                    Console.WriteLine($"{Name} движется {directions[direction]} -> (X,Y) - ({X},{Y})");
                    break;
                case 2:
                    X++;
                    Console.WriteLine($"{Name} движется {directions[direction]} -> (X,Y) - ({X},{Y})");
                    break;
                case 3:
                    X--;
                    Console.WriteLine($"{Name}  движется {directions[direction]} -> (X,Y) - ({X},{Y})");
                    break;
            }
            Thread.Sleep(550);
        }
    }        
}
