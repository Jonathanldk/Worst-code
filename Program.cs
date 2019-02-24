using System;

namespace HomeExercise


{


    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hello User");


            while (true)
            {
                Console.WriteLine("Type numbers or words");
                //Her læser den mit string input 
                string input = Console.ReadLine();
                //Jeg tror switch medfører at man kan taste noget ind ?????
                switch (input)
                {
                    //Beskriver hvad der skal ske når jeg skriver "numbers"
                    case "numbers":
                        Console.WriteLine("You choose wisely");

                        Console.WriteLine("Choose a number between 1-10");

                        //Dette medfører at man kan skrive en string som consolen læser 
                        string numbers = Console.ReadLine();

                        //Denne medfører at string bliver lavet om til int 
                        int choosenumber = int.Parse(numbers);


                        string numberstwo = Console.ReadLine();

                        int choosenumbertwo = int.Parse(numberstwo);



                        if(choosenumber == choosenumbertwo)
                        {
                            Console.WriteLine((choosenumber + choosenumber) * 3);
                        }

                        else
                        {
                            Console.WriteLine((choosenumber + choosenumbertwo));
                        }

                        break;



                    case "words":

                        Console.WriteLine("You are stupid!");

                        break;




                    case "quit":
                           return;


                    default:
                        Console.WriteLine("Wrong input");
                        break;          

                }

            }

        }
    }
}

