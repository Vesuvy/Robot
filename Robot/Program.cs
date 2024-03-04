using System;
using System.Threading;
using RobotLibrary;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RobotClass robot1 = new RobotClass("Робот 1", 10, 10);
            RobotClass robot2 = new RobotClass("Робот 2", 0, 0);

            for (int i = 0; i < 8; i++)
            {
                Thread moving1 = new Thread(robot1.Moving);
                Thread moving2 = new Thread(robot2.Moving);

                moving1.Start();
                Thread.Sleep(20); // Минипауза во избежание одинакового выбора направлений
                moving2.Start();

                Thread.Sleep(2000); // Пауза между итерациями, чтобы увидеть результаты

                moving1.Abort(); // Остановка потока перед созданием нового для следующей итерации
                moving2.Abort();
            }

            Console.ReadLine();
        }
    }
}
