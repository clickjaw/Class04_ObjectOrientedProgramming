using System;
using System.Collections.Generic;

namespace ClassesAndObjects
{

    class Pet
    {
        public string name;
        public Breed breed;
        public int age;
        
        public bool friendly;

        // public Dictionary<string, string> favToy;
                public Pet(string name, Breed breed, int age, bool friendly)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.friendly = friendly;
            // this.favToy = favToy;
        }
    }

    enum Breed{
        Basset, Boxer, Corgi, Cat, dalmation
    }

    struct friendliness{
        public bool friendly;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet thisDog = new Pet("Fido", Breed.dalmation, 5, true);
            Pet thisCar = new Pet("Oscar", Breed.Cat, 9, false);

            Dictionary<string, string> petToys = new Dictionary<string, string>();

            petToys.Add("red", "ball" );
            petToys.Add("green", "toy" );
            petToys.Add("purple", "bone" );

            Console.WriteLine($"My dog {thisDog.name} is a {thisDog.breed}. He's {thisDog.age} years old. Is he friendly: {thisDog.friendly}. Favorite toy: {petToys}");
        }
    }

    
}