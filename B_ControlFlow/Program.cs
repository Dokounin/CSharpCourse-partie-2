namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void SwitchCase()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch(month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
                System.Console.WriteLine(season);


            Console.ReadLine();
            
            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch(weddingYears)
            {
                case 5:
                    name = "Деревяная свадьба";
                    break;
                case 10:
                    name = "Деревяная свадьба";
                    break;
                case 15:
                    name = "Деревяная свадьба";
                    break;
                case 20:
                    name = "Деревяная свадьба";
                    break;
                case 25:
                    name = "Деревяная свадьба";
                    break;
                default:
                    name = "не знаем такого юбилея";
                    break;
            }
        }
        static void BreakContinue()
        {
            int[] numbers = {0, 3, 2, 1, 4, 5, 6, 7, 8, 9};

            foreach (int n in numbers)
            {
                // if(n % 2 == 0)
                // System.Console.WriteLine(n);

                if(n % 2 != 0)
                continue;

            System.Console.WriteLine(n);
            }

            Console.ReadLine();
            

            char[] letters = {'a', 'b', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};

            for(int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine($"Number={numbers[i]}");

                for(int j = 0; j < letters.Length; j++)
                {
                    if(numbers[i] == j)
                        break;
                    System.Console.Write($" {letters[j]} ");

                }
                    System.Console.WriteLine();
            }
            
            Console.ReadLine();
            
            int[] numbers2 = {1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                 if(counter == 3)
                    {
                        break;
                    }
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if(atI + atJ == 0)
                    {
                        System.Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if(counter == 3)
                    {
                        break;
                    }
                }

            }
        }
        static void WhileDoWhile()
        {
            int age = 30;

            while(age < 18)
            {
                System.Console.WriteLine("First while loop");
                System.Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            do 
            {
                System.Console.WriteLine("Do \\While");
                System.Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);

            int[] numbers = {1,2,3,4,5};
            int i = 0;
            while (i < numbers.Length)
            {
                System.Console.WriteLine(numbers[i] + " ");
                i++;
            }

            System.Console.WriteLine("Good!");
        }
        static void NestedFor()
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
            System.Console.WriteLine();


            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for(int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for(int k = j + 1; k < numbers.Length; k++)
                    {

                    int atI = numbers[i];
                    int atJ = numbers[j];
                    int atK = numbers[k];

                    if(atI + atJ + atK == 0)
                    {
                        System.Console.WriteLine($"Triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                    }
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
