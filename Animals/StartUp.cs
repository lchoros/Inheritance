using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                string[] animalLine = Console.ReadLine().Split(" ");
                try
                {
                    string name = animalLine[0];
                    int age = int.Parse(animalLine[1]);
                    string gender = string.Empty;

                    switch (animalType)
                    {
                        case "Cat":
                            gender = animalLine[2];
                            var cat = new Cat(name, age, gender);
                            Console.WriteLine(cat);
                            break;
                        case "Dog":
                            gender = animalLine[2];
                            var dog = new Dog(name, age, gender);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            gender = animalLine[2];
                            var frog = new Frog(name, age, gender);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(name, age);
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(name, age);
                            Console.WriteLine(tomcat);
                            break;

                        default:
                            throw new ArgumentException("Invalid input!");
                    }

                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }               

                animalType = Console.ReadLine();
            }
        }
    }
}
