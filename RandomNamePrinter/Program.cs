using System;

namespace RandomNamePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] names = new string[30];
            int numberOfNames = 30;
            //asks the user to enter a name - note Console.ReadKey() may work in this 
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter a name:");
                string name = Console.ReadLine();
                //if(name == "")
                if(String.IsNullOrEmpty(name))
                {
                    numberOfNames = i;
                    break;
                }
                names[i] = name;
            }
            int randomInt = new Random().Next(0, numberOfNames);
            string nameWinner = names[randomInt];
            
            Console.WriteLine($"The winner is: {nameWinner}");
            Console.WriteLine("The losers are:");
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                if(names[i] != nameWinner)
                {
                    names[i] = name;
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();


        }

           // string namesList = names.ToList();
                                             
             //store the name in an arrary
            //repeat this for up to 30 names
            //not: if the user hits enter w/o a name, assume they are done and stop asking them
            //get a random number between 0 and the number of names entered -1
            //Get the name from the index of the random number
            //print this name as a winner
            //print list of the other names that did not win
            //pause with readline

            
        }
    }

