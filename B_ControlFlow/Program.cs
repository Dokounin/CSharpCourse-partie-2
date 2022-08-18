namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if(atI + atJ == 0)
                    {
                        System.Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }
            
        }
        static void ForForeach()
        {
            int[] numbers = {1, 2, 3 , 4, 5, 6, 7, 8, 9};

            for(int i = 0; i < numbers.Length; i++)
            {
                System.Console.Write(numbers[i] + " ");
            }

            System.Console.WriteLine();

            for(int i = numbers.Length - 1; i >= 0;i--)
            {
                System.Console.Write(numbers[i] + " ");
            }

            System.Console.WriteLine();

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                System.Console.Write(numbers[i] + " ");
                }
            }

            System.Console.WriteLine();

            foreach(int val in numbers)
            {
                System.Console.Write(val + " ");
            }
        }
        static void HomeworkGetMax()
        {
         System.Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter seconde number");
            int number2 = int.Parse(Console.ReadLine());
            // 1-st method
            // int max = number1;

            // if(number2 > number1)
            // {
            //     max = number2;
            // }
            // System.Console.WriteLine($"Max = {max}");
            // 
            double max = number1 > number2 ? number1 : number2;
            System.Console.WriteLine($"Max = {max}");   
        }
        static void ifElse()
        {
            System.Console.WriteLine("Enter your age :");
            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your weight :");
            double weight = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your height in metres:");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            bool isTooLow =  bodyMassIndex <= 18.5;
            bool isNormal = bodyMassIndex < 18.5 && bodyMassIndex < 25;
            bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isAboveNormal || isTooFat;

            if(isFat)
            {
                System.Console.WriteLine("Your'd better lose some weight");
            }else{
                System.Console.WriteLine("Oh, you're in a good shape");
            }

            if(!isFat)
            {
                System.Console.WriteLine("You're definitely not fat!");
            }

            if(isTooLow)
            {
                System.Console.WriteLine("Not enough weight");
            }
            else if(isAboveNormal)
            {
                System.Console.WriteLine("Be careful");
            }else{
                System.Console.WriteLine("You need to lose some weight");
            }

            if(isFat || isTooFat)
            {
                System.Console.WriteLine("Anyway it's time to get on diet");
            }

            // ternary operation
            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";

            System.Console.WriteLine(description);
        }
    }
}
