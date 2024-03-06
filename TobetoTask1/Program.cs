
Console.WriteLine("Hello, World!");

Example1();
//Example4();

static void Example1()
{
    string orderInput = Console.ReadLine();

    switch (orderInput)
    {
        case "1":
            Console.WriteLine("Apple phone");
            break;
        case "2":
            Console.WriteLine("Xiaomi phone");
            break;
        case "3":
            Console.WriteLine("Samsung phone");
            break;
        default:
            Console.WriteLine("Please input right number");
            break;
    }
}

static void Example2()
{
    Console.Write("Order count:");
    int numberOfOrders = Convert.ToInt32(Console.ReadLine());
    int totalPrice = 0;
    for (int i = 0; i < numberOfOrders; i++)
    {
        Console.Write("Order price :");
        int orderPrice = Convert.ToInt32(Console.ReadLine());
        totalPrice += orderPrice;
    }
    Console.WriteLine("Total Price:" + totalPrice);
}

static void Example3()
{
    bool loginStatus = false;
    do
    {
        Console.WriteLine("Lütfen şifrenizi giriniz");
        string userPassword = Console.ReadLine();
        if (userPassword == "123")
        {
            Console.WriteLine("Giriş başarılı");
            loginStatus = true;
        }

    } while (loginStatus);
}

static void Example4()
{
    Random random = new Random();
    int maxNumberToGuess = 20;
    Console.WriteLine($"Bilgisayarın tuttuğu sayıyı tahmin etmeye çalışın(1-{maxNumberToGuess} arasında)");
    int randomNumber = random.Next(1, maxNumberToGuess + 1);

    while (true)
    {
        int userGuess = Convert.ToInt32(Console.ReadLine());
        if (userGuess == randomNumber)
        {
            Console.WriteLine($"Tebrikler, bilgisayarın tuttuğu sayı {randomNumber}");
            break;
        }
        else if (userGuess < randomNumber && userGuess > 0 && userGuess <= maxNumberToGuess)
            Console.WriteLine("Çık");
        else if (userGuess > randomNumber && userGuess > 0 && userGuess <= maxNumberToGuess)
            Console.WriteLine("İn");
        else
            Console.WriteLine("Lütfen geçerli bir sayı giriniz");
    }
}

static void Example5()
{
    Console.Write("Mükemmel olup olmadığını kontrol etmek istediğiniz sayıyı giriniz");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    int sumOfDivisors = 0;
    for (int i = 1; i < inputNumber; i++)
    {
        if (inputNumber % i == 0) sumOfDivisors += i;
    }
    string isPerfectNumber = sumOfDivisors == inputNumber ? "Perfect number" : "Not perfect number";
    Console.WriteLine(isPerfectNumber);
}

static void Example6()
{
    string message = "Sen misin ilacım";
    int text = message.Length;
    Console.WriteLine($"Stringin bütün karakterlerinin küçük karaktere çevrilmiş hali : {message.ToLower()}");
    Console.WriteLine($"Stringin bütün karakterlerinin büyük karaktere çevrilmiş hali : {message.ToUpper()}");
    string firstWord = message.Substring(0, message.IndexOf(' '));
    Console.WriteLine($"Stringdeki ilk kelime : {firstWord}");
}

static void Example7()
{
    List<Student> students = new();

    Console.Write("Enter the number of students");
    int numberOfStudents = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < numberOfStudents; i++)
    {
        Student student = new();
        Console.Write($"{i + 1}. students firstname:");
        student.FirstName = Console.ReadLine();
        Console.Write($"{i + 1}. students lastname:");
        student.LastName = Console.ReadLine();
        Console.Write($"{i + 1}. students math exam result:");
        student.MathExamResult = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{i + 1}. students history exam result:");
        student.HistoryExamResult = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{i + 1}. students science exam result:");
        student.ScienceExamResult = Convert.ToInt32(Console.ReadLine());

        students.Add(student);
    }

    foreach (Student student in students)
    {
        Console.WriteLine($"{student.FirstName} exam result average : {(double)(student.MathExamResult + student.HistoryExamResult + student.ScienceExamResult) / 3}");
    }
}

public class Student
{
    public string FirstName;
    public string LastName;
    public int MathExamResult;
    public int HistoryExamResult;
    public int ScienceExamResult;
}