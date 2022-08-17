using System.Text;

namespace CSharpFirst
{
class Program
{
    static void Main(string[] args)
    {

    }
    static void Homework03()
    {
        System.Console.WriteLine("Enter your data to calculate your body mass index");
        System.Console.WriteLine("Enter your Lastname :");
        string lastName = Console.ReadLine();

        System.Console.WriteLine("Enter your FirstName :");
        string firstName = Console.ReadLine();

        System.Console.WriteLine("Enter your age :");
        int age = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your weight :");
        double weight = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your height in metres:");
        double height = double.Parse(Console.ReadLine());

        double bodyMassIndex = weight / (height * height);

        System.Console.WriteLine($"Your profile:\nFull name: {lastName} {firstName}\nAge: {age}\nWeight:{weight}\nHeight: {height}\nBody Mass Index: {bodyMassIndex}");        
    }
    static void Homework02()
    {
        System.Console.WriteLine("Enter the first side  of the triangle AB :");
        double ab = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the seconde side of the triangle BC : ");
        double bc = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the third side of the triangle AC :");
        double ac = double.Parse(Console.ReadLine());

        double p = (ab + bc + ac) / 2;

        double square = p * (p - ab) * (p - bc) * (p - ac);

        double result = Math.Sqrt(square);

        System.Console.WriteLine($"The square of your triangle is {result} ");
    }
    static void Homework01()
    {
        System.Console.WriteLine("Hey, tell me please your name");
        string name = Console.ReadLine();
        System.Console.WriteLine($"Hello {name}");

        System.Console.WriteLine("Please enter numbers");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter numbers two");
        int number2 = int.Parse(Console.ReadLine());
        //  number1 = number2;
        //  number2 = number1 + number2;
        int number3 = number1;
        number1 = number2;
        number2 = number3;
        System.Console.WriteLine($"It's number one : {number1}, I'ts number two : {number2} ");

        System.Console.WriteLine("Please enter number");
        int number = int.Parse(Console.ReadLine());
        int numberQuantity = number.ToString().Length;
        System.Console.WriteLine($"Your number : {number}, Your number has {numberQuantity} digits");
        
    }
    static void DateTimeDemo()
    {
        DateTime now = DateTime.Now;
        System.Console.WriteLine(now.ToString());

        System.Console.WriteLine($"It's {now.Date}, {now.Hour} : {now.Minute}");

        DateTime dt = new DateTime(2016, 2, 28);
        DateTime newDt = dt.AddDays(1);
        System.Console.WriteLine(newDt);

        TimeSpan ts = now - dt;
        // ts = now.Subtract(dt);
        System.Console.WriteLine(ts.Days);
    }
    static void IntroToArrays()
    {
        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];
        int[] a3 = new int[5] {1, 3, -2, 4, 5};

       

        int[] a4 = {1, 3, 2, 4, 10};

        System.Console.WriteLine(a4[0]);

        int number = a4[4];
        System.Console.WriteLine(number);

        a4[4] = 6;
        System.Console.WriteLine(a4[4]); 

        System.Console.WriteLine(a4.Length);
        System.Console.WriteLine(a4[a4.Length - 1]);

        string s1 = "abcdefgh";
        char first = s1[0];
        char last = s1[s1.Length - 1];

        System.Console.WriteLine($"First : {first}  Last : {last}");

        // impossible
        // s1[0] = "s";
         foreach (var item in a4)
        {
            System.Console.WriteLine(item);
        }

    }
    static void MathDemo()
    {
        System.Console.WriteLine(Math.Pow(2,3));
        System.Console.WriteLine(Math.Sqrt(9));
        System.Console.WriteLine(Math.Sqrt(8));

        System.Console.WriteLine();

        System.Console.WriteLine(Math.Round(1.7));
        System.Console.WriteLine(Math.Round(1.4));

        System.Console.WriteLine();

        System.Console.WriteLine(Math.Round(2.5));
        System.Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
        System.Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
    }   
    static void CastingAndParsing()
    {
        byte b = 3; // 0000 0011
        int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
        long j = i;// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

        float f = i; // 3.0

        b = (byte)i;

        i = (int)f;

        f = 3.1f;
        i = (int)f;
        System.Console.WriteLine(i);

        string str = "1";
        // i = int(str);
        i = int.Parse(str);
        System.Console.WriteLine(i);

        int x = 5;
        int result = x / 2;
        System.Console.WriteLine(result);

        double result2 = (double)x / 2;
        System.Console.WriteLine(result2);
    }
    static void ConsoleBasics()
    {
        // System.Console.WriteLine("Hi, please tell me your name");

        // string name = Console.ReadLine();
        // string sentence = $"Your name is {name}";
        // System.Console.WriteLine(sentence);

        System.Console.WriteLine("Hi, please tell me your age.");

        string input = Console.ReadLine();
        int age = int.Parse(input);

        string sentence = $"Your age is {age}";
        System.Console.WriteLine(sentence);

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.Write("New Style ");
        Console.Write("New Style\n");
    }
    static void ComparingStrings()
    {
        string str1 = "abcde";
        string str2 = "abcde";

        bool areEqual = str1 == str2;
        System.Console.WriteLine(areEqual);

        areEqual = string.Equals(str1,str2, StringComparison.Ordinal);
        System.Console.WriteLine(areEqual);
    }
    static void StringFormat()
    {
        string name = "John";
        int age = 30;

        string str1 = string.Format("My name is {0} and I'm {1}", name, age);
        System.Console.WriteLine(str1);

        string str2 = $"My name is {name} and I'm {age}";
        System.Console.WriteLine(str2);

        string str3 = "My name is \nJohn";
        System.Console.WriteLine(str3);

        str3 = $"My name is {Environment.NewLine}John";
        System.Console.WriteLine(str3);

        string str4 = "I'm \t30";
        System.Console.WriteLine(str4);

        // string str5 = "I'm John and I'm "good" programmer";
        string str5 = "I'm John and I'm \"good\" programmer";
        System.Console.WriteLine(str5);

        // string str6 = "C:\\tmp\\test_file.txt";
        string str6 = @"C:\tmp\test_file.txt";
        System.Console.WriteLine(str6);

        double answer = 42.08;

        // string result = string.Format("{0:d}", answer);
        // string result2 = string.Format("{0:d4}", answer);

        string result = string.Format("{0:f}", answer);
        string result2 = string.Format("{0:f4}", answer);

        System.Console.WriteLine(result);
        System.Console.WriteLine(result2);
        
        Console.OutputEncoding = Encoding.UTF8;

        double money = 12.8;

        result = string.Format("{0:C}", money);
        result2 = string.Format("{0:C2}", money);

        result = $"{money:C2}";

        System.Console.WriteLine(result);
        System.Console.WriteLine(result2);
    }
    static void StringBuilderDemo()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("My ");
        sb.Append("name ");
        sb.Append("is ");
        sb.Append("John");
        sb.AppendLine("!");
        sb.AppendLine("Hello!");

        string str = sb.ToString();
        System.Console.WriteLine(str);
    }
    static void StringModification()
    {
      string nameConcat = string.Concat("My ", "name ", "is ", "John");
      System.Console.WriteLine(nameConcat);

      nameConcat = string.Join(" ", "My","name", "is", "John");
      System.Console.WriteLine(nameConcat);

      nameConcat = nameConcat.Insert(0, "By the way,");
      System.Console.WriteLine(nameConcat);

      nameConcat = nameConcat.Remove(0, 1);
      System.Console.WriteLine(nameConcat);

      string replaced = nameConcat.Replace('n', 'z');
      System.Console.WriteLine(replaced);

      string data = "28;35;64;12;37";
      string[] dataSplit = data.Split(";");
      string firstElement = dataSplit[0];
      System.Console.WriteLine(firstElement);

      char[] chars = nameConcat.ToCharArray();
      System.Console.WriteLine(chars[0]);
      System.Console.WriteLine(nameConcat[0]);

      string lower = nameConcat.ToLower();
      System.Console.WriteLine(lower);

      string upper = nameConcat.ToUpper();
      System.Console.WriteLine(upper);

      string john = " My name is John ";
      System.Console.WriteLine(john);
      System.Console.WriteLine(john.Trim());
    }
    static void StringEmptiness()
    {
      string str = string.Empty; // same as "";

      string empty = "";
      string withSpaced = " ";
      string notEmpty = " b";
      string? nullString = null;

      System.Console.WriteLine("IsNullOrEmpty");
      bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
      System.Console.WriteLine(isNullOrEmpty);

      isNullOrEmpty = string.IsNullOrEmpty(withSpaced);
      System.Console.WriteLine(isNullOrEmpty);

      isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
      System.Console.WriteLine(isNullOrEmpty);

      isNullOrEmpty = string.IsNullOrEmpty(empty);
      System.Console.WriteLine(isNullOrEmpty);

      System.Console.WriteLine();
      System.Console.WriteLine("IsNullOrWithSpace");

      bool isNullOrWithSpace = string.IsNullOrWhiteSpace(nullString);
      System.Console.WriteLine(isNullOrWithSpace);

      isNullOrWithSpace = string.IsNullOrWhiteSpace(withSpaced);
      System.Console.WriteLine(isNullOrWithSpace);

      isNullOrWithSpace = string.IsNullOrWhiteSpace(notEmpty);
      System.Console.WriteLine(isNullOrWithSpace);

      isNullOrWithSpace = string.IsNullOrWhiteSpace(empty);
      System.Console.WriteLine(isNullOrWithSpace);
    }
    static void QueryingStrings()
    {
      string name = "abracadabra";
      bool containA = name.Contains('a');
      bool containE = name.Contains('E');

      System.Console.WriteLine(containA);
      System.Console.WriteLine(containE);

      bool endWithAbra = name.EndsWith("abra");
      System.Console.WriteLine(endWithAbra);

      bool startWithAbra = name.StartsWith("abra");
      System.Console.WriteLine(startWithAbra);

      int indexOfA = name.IndexOf('a', 1);
      System.Console.WriteLine(indexOfA);

      int lastIndexOfR = name.LastIndexOf('r');
      System.Console.WriteLine(lastIndexOfR);

      System.Console.WriteLine(name.Length);

      string substrFrom5 = name.Substring(5);
      System.Console.WriteLine(substrFrom5);

      string substrFromTo = name.Substring(0, 3);
      System.Console.WriteLine(substrFromTo);
    }
    static void StaticAndInstanceMembers()
    {
      string name = "abracadabra";
      bool containA = name.Contains('a');
      bool containE = name.Contains('E');

      System.Console.WriteLine(containA);
      System.Console.WriteLine(containE);

      string abc = string.Concat("a", "b", "c");
      System.Console.WriteLine(abc);

      System.Console.WriteLine(int.MinValue);

      int x = 1;
      string xStr = x.ToString();

      System.Console.WriteLine(xStr);
      System.Console.WriteLine(x);  
    }
    static void Overflow()
    {
        checked 
            {
                    uint x = uint.MaxValue;
                    System.Console.WriteLine(x);

                    x = x + 1;
                    System.Console.WriteLine(x);

                    x = x - 1;
                    System.Console.WriteLine(x);
            }
    }
    static void VariablesScope()
    {
          var a = 1;
        {
            var b = 2;
            {
                var c = 3;
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
                System.Console.WriteLine(c);
                
            }
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
                // System.Console.WriteLine(c);
        }
        System.Console.WriteLine(a);
        // System.Console.WriteLine(b);
        // System.Console.WriteLine(c);
    }
    static void Literals()
    {
        int x = 0b11;
        int y = 0b1001;
        int k = 0b10001001;
        int m = 0b1000_1001;

        System.Console.WriteLine(x);
        System.Console.WriteLine(y);
        System.Console.WriteLine(k);
        System.Console.WriteLine(m);

        System.Console.WriteLine();

        x = 0x1F;
        y = 0xFF0D;
        k = 0x1FAB30EF;
        m = 0x1FAB_30EF;

        System.Console.WriteLine(x);
        System.Console.WriteLine(y);
        System.Console.WriteLine(k);
        System.Console.WriteLine(m);

        System.Console.WriteLine();

        System.Console.WriteLine(4.5e2);
        System.Console.WriteLine(3.1E-1);

        System.Console.WriteLine();

        System.Console.WriteLine('\x78');
        System.Console.WriteLine('\x5A');

        System.Console.WriteLine('\u0420');
        System.Console.WriteLine('\u0421');

    }
    static void Variables() 
    {
        int x = -1;
        int y;
        y = 2;

        // int32 x1 =  -1;
        // uint z = -1;

        float f = 1.0f;

        double d = 2.3;

        int x2 = 0;
        int x3 = new int();

        var a = 1;
        var b = 1.2;

        // Dictionary<int,string> dict = new Dictionary<int, string>();
        var dict = new Dictionary<int, string>();
        // var v;

        decimal money = 3.0m;
        
        char @char = 'A';
        string name = "John";

        bool canDrive = true;
        bool canDraw  = false;

        System.Console.WriteLine(a);
        System.Console.WriteLine(name);
    }
}
}
