using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClassTuttorialsEu
{
    internal class AbstructClassTuttorialsEu
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();
            cat.MakeSound();
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeSound();

    }
    public class Dog : Animal
    {
        public override void MakeSound() {
            Console.WriteLine("woof");
        }
        
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("meow");
            }

    }
}

