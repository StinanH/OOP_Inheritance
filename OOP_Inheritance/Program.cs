//Stina Hedman
//NET23

namespace OOP_Inheritance

{
    class Animal // base class
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double HeightCm { get; set; }
        public double WeightKg { get; set; }

        //class cat with method for sleeping.
        public Animal(string name, string species, int age, double heightCM, double weightKG)
        {
            Name = name;
            Species = species;
            Age = age;
            HeightCm = heightCM;
            WeightKg = weightKG;
        }

        public virtual void MakeSound() //shared method for printing height
        {
            Console.WriteLine($"{this.Name}makes a Sound!");
        }

        public override string ToString()
        {
            return $"Name : {this.Name} (the {this.Species}), Age: {this.Age}, Weight: {this.WeightKg} kg, Height : {this.HeightCm} cm";
        }

        public void PrintWeight()
        {
            Console.WriteLine(this.WeightKg);
        }
    }

    //class cat with method for sleeping.
    class Cat : Animal
    {
        public bool IsCuddly = true;

        public Cat (bool isCuddly, string name, int age, double heightCm, double weightKg) : base (name, "Cat", age, heightCm, weightKg)
        {
            IsCuddly = isCuddly;
        }

        public override void MakeSound() //shared method for printing height
        {
            Console.WriteLine($"{this.Name} the {this.Species} meows!");
        }

        public void Sleep()
        {
            Console.WriteLine($"{this.Name} is having a nap.. zzzZZz..");
        }

    }

    class Dog : Animal
    {
        public bool IsPlayfull = true;

        public Dog(bool isPlayfull, string name, int age, double heightCm, double weightKg) : base(name, "Dog", age, heightCm, weightKg)
        {
            IsPlayfull = isPlayfull;
        }

        public override void MakeSound() //shared method for printing height
        {
            Console.WriteLine($"{this.Name} the {this.Species} starts barking! woof!");
        }

        public void Feed()
        {
            Console.WriteLine($"{Name} is eating!");
        }

    }
    class Fish : Animal
    {
        public string Colour = "blue";

        public Fish(string color, string name, int age, double heightCm, double weightKg) : base(name, "Fish", age , heightCm, weightKg)
        {
            Colour = color;
        }
        public override void MakeSound() //shared method for printing height
        {
            Console.WriteLine($"{Name} the {Species} burps, you can see bubbles in the water!");
        }

        public void Dance()
        {
            Console.WriteLine($"{Name} the {Colour.ToLower()} fish is dancing!");
        }
    }

    class GoldFish : Fish
    {
        public int lapsInBowl = 0;
        public GoldFish(string color, string name, int age, double heightCm, double weightKg) : base(color, name, age, heightCm, weightKg) 
         {
            this.Species = "GoldFish";
        }

        public void swimLap()
        {
            Console.WriteLine($"{Name} is swam a lap in the fisbowl");
            lapsInBowl++;
        }
    }
    class Shark : Fish
    {
        public int NrOfTeeth = 0;

        public Shark(int nrOfTeeth, string color, string name, int age, double heightCm,double weightKg) : base(color, name, age, heightCm, weightKg)
        {
            NrOfTeeth = nrOfTeeth;
            this.Species = "Shark";
            brushTeeth();
        }

        public void brushTeeth()
        {
            Console.WriteLine($"You brushed {Name} the {Species}'s {NrOfTeeth}..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat(true, "Mittens", 2, 20, 2));
            animals.Add(new Dog(true, "Spot", 4, 40, 23));
            animals.Add(new Fish("Red", "Finny", 1, 2, 0.2));
            animals.Add(new Shark(10, "GRAY", "Gary", 7, 90, 1540));
            animals.Add(new GoldFish("yellow", "Arnold", 1, 4, 0.2));

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

        }
    }
} 