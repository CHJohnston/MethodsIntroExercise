using System;

namespace LearningMethodsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise #1 Create a adlib story from user inputs
            Console.WriteLine("Let's make up a Silly Story!");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            Console.WriteLine("What is favorite color?");
            string userColor = Console.ReadLine();
            Console.WriteLine("What is favorite food?");
            string userFood = Console.ReadLine();
            Console.WriteLine("What is favorite animal?");
            string userAnimal = Console.ReadLine();
            var story = MySillyStory(userName, userAge, userColor, userFood, userAnimal);
            Console.WriteLine(story);

            //Exercise # 2 Math Operators

            Console.WriteLine("Let's Do Some Fun Math!!");
            Console.WriteLine("Enter a number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int secondNum = int.Parse(Console.ReadLine());

            int additionAnswer = Addition(firstNum, secondNum);
            Console.WriteLine($"The Sum is {additionAnswer}");

            int subtractionAnswer = Subtraction(firstNum, secondNum);
            Console.WriteLine($"The Difference is {subtractionAnswer}");

            int multiplicationAnswer = Multiplication(firstNum, secondNum);
            Console.WriteLine($"The Product is {multiplicationAnswer}");

            int divisionAnswer = Division(firstNum, secondNum);
            Console.WriteLine($"The Quotient is {divisionAnswer}");




        }
        public static string MySillyStory(string name, string age, string color, string food, string animal)
        //Exercise #1 This method builds MySillyStory 
        {
            return $"I have a pet {animal} named {name} who loves to eat {age} year old {color} {food}.";
        }

        public static int Addition(int num1, int num2)
        {//Exercise #2 Addition Method
            var result = num1 + num2;
            return result;
        }
        public static int Subtraction(int num1, int num2)
        {//Exercise #2 Subtraction Method
            var result = num1 - num2;
            return result;
         }
        public static int Multiplication(int num1, int num2)
        {//Exercise #2 Multiplication Method
            var result = num1 * num2;
            return result;
        }
        public static int Division(int num1, int num2)
        {//Exercise #2 Division Method
            if (num2 == 0)
             {
                var result = 0;
                return result;
             }
            else
            {
                var result = num1 / num2;
                return result;
            }            
        }

    }
}