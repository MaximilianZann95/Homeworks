using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_HomeWork
{
    class Program
    {
        static string name = null;
        static int numberOfApproaches = 0;

        List<Gym> trainee = new List<Gym>();

        static void Main(string[] args)
        {
            List<Gym> trainee = new List<Gym>();
            Console.WriteLine(
                "UpArrow - to add New Trainee." +
                "\nSpaceBar - to Train" +
                "\nEscape - to Exit.\n");
            var isDone = true;

            while (isDone)
            {
                var key = Console.ReadKey();
                Console.Clear();
                Console.WriteLine(
                "UpArrow - to add New Trainee." +
                "\nSpaceBar - to Train" +
                "\nEscape - to Exit.\n");
                switch (key.Key)
                {
                    case ConsoleKey.Spacebar:
                        foreach (Gym i in trainee)
                        {
                            i.toTrain();
                            
                             // Вот тут пытался выгонять качков, после того, как они закончили упражнения.
                             // Но если удалять их во время действия foreach, то происходит ошибка.
                             // Как их лучше выгонять из качалки?
                              
                             /* if (i.numberOfApproaches == 0)
                            {
                                trainee.Remove(i);
                            }*/
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("First - enter a Name and press 'Enter', next - Numbers of Approaches.");
                        trainee.Add(new Gym(name, numberOfApproaches) { name = Console.ReadLine(), numberOfApproaches = Int32.Parse(Console.ReadLine()) });
                        foreach (Gym i in trainee)
                        {
                            Console.WriteLine($"Name {i.name}, Approaches: {i.numberOfApproaches} in the Gym.");
                        }
                        break;
                    case ConsoleKey.Escape:
                        isDone = false;
                        break;
                }
            }
        }
    }
}
