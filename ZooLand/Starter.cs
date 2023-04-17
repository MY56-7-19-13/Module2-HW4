using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLand.Models.Herbivores;
using ZooLand.Models.Predators;

namespace ZooLand
{
    public class Starter
    {
        public void Run()
        {
            var index = 0;
            Section section = new Section();
            Animals[] animalsInSection = new Animals[10];

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nWelcome to *San Diego Zoo Safari Park*");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("-----");
                Console.WriteLine("1. Show animals");
                Console.WriteLine("2. Subscribe a section");
                Console.WriteLine("3. Find animal in your section");
                Console.WriteLine("4. Contact us");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-4): ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("San Diego Zoo Safari Park*");
                        Console.WriteLine("\nList of animals:");
                        Console.WriteLine("\n" + new string('-', 40));
                        Feliformia[] feliformias = section.GetFeliformias();
                        Caniformia[] caniformias = section.GetCaniformias();
                        Monkey[] monkeys = section.GetMonkeys();
                        Deer[] deers = section.GetDeers();
                        Console.WriteLine(new string('-', 40));
                        Console.Write("\nWhat animal you want to add: ");
                        int takeAnimal = Convert.ToInt32(Console.ReadLine());
                        if (takeAnimal >= 1 && takeAnimal <= 5)
                        {
                            for (int i = 0; i < feliformias.Length; i++)
                            {
                                if (i == (takeAnimal - 1))
                                {
                                    animalsInSection[index] = feliformias[i];
                                    index++;
                                }
                            }

                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeAnimal >= 6 && takeAnimal <= 10)
                        {
                            for (int i = 0; i < caniformias.Length; i++)
                            {
                                if (i == (takeAnimal - 6))
                                {
                                    animalsInSection[index] = caniformias[i];
                                    index++;
                                }
                            }

                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeAnimal >= 11 && takeAnimal <= 15)
                        {
                            for (int i = 0; i < monkeys.Length; i++)
                            {
                                if (i == (takeAnimal - 11))
                                {
                                    animalsInSection[index] = monkeys[i];
                                    index++;
                                }
                            }

                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeAnimal >= 16 && takeAnimal <= 20)
                        {
                            for (int i = 0; i < deers.Length; i++)
                            {
                                if (i == (takeAnimal - 16))
                                {
                                    animalsInSection[index] = deers[i];
                                    index++;
                                }
                            }

                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        break;
                    case "2":
                        Console.Clear();
                        var sumOfAnimals = 0;
                        Console.WriteLine("Your personal section with animals!");
                        Console.WriteLine("\n" + new string('-', 40));
                        Array.Sort(animalsInSection);
                        for (int i = 0; i < animalsInSection.Length; i++)
                        {
                            if (animalsInSection[i] != null)
                            {
                                Console.WriteLine(animalsInSection[i].GetInfoAnimals());
                            }
                            else
                            {
                                animalsInSection[i] = animalsInSection[i];
                            }
                        }

                        for (int i = 0; i < animalsInSection.Length; i++)
                        {
                            if (animalsInSection[i] != null)
                            {
                                sumOfAnimals++;
                            }
                            else
                            {
                                animalsInSection[i] = animalsInSection[i];
                            }
                        }

                        Console.WriteLine(new string('-', 40));
                        Console.WriteLine($"\nTotal animals: {sumOfAnimals}");

                        break;
                    case "3":
                        int standart = 0;
                        Console.Write("Find by standart (write weight): ");
                        int findItem = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < animalsInSection.Length; i++)
                        {
                            if (animalsInSection[i] != null)
                            {
                                animalsInSection[standart] = animalsInSection[i];
                                if (findItem == animalsInSection[standart].Weight)
                                {
                                    Console.WriteLine(animalsInSection[standart].GetInfoAnimals());
                                }
                            }
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Contact Us:\n");
                        ContactUs contacntUs = new ContactUs();
                        contacntUs.GetContacts();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("We don`t have this option!\nTry again!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
