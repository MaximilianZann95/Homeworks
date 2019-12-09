using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_HomeWork
{
    public class Gym
    {
        public string name { get; set; }
        public int numberOfApproaches { get; set; }

        public Gym(string name, int numberOfApproaches)
        {
            this.name = name;
            this.numberOfApproaches = numberOfApproaches;
        }

        public void toTrain()
        {
            if (numberOfApproaches > 0)
            {
                Console.WriteLine($"{name}: {numberOfApproaches} approaches left, so much!");
                numberOfApproaches--;
            }
            else
            {
                Console.WriteLine($"Finally! {name}, you are done!");
            }
        }
    }
}
