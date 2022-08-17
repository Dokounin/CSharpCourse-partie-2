namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void ifElseOperation()
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
