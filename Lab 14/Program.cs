using System;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal()
        {
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("Животное: {0}", Name);
            Say();
        }
    }
    class Cat: Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Cat()
            : base()
        {
            Name = "Кошка";
        }
        public override void Say()
        {
           Console.WriteLine("Говорит: Мяу");
        }

    }
    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Dog()
            : base()
        {
            Name = "Собака";
        }
        public override void Say()
        {
            Console.WriteLine("Говорит: Гав");
        }

    }
}
