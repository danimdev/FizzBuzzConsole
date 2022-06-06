ShowMenu();

void ShowMenu()
{
    Console.WriteLine("1.Show 1-100 with the FizzBuzz Scheme");
    Console.WriteLine("2.FizzBuzz PlayMode");
    Console.Write("Choice:");
    int input = Convert.ToInt32(Console.ReadLine());

    switch(input)
    {
        case 1:
            for (int i = 1; i <= 105; i++)
            {
                Console.WriteLine(ReturnString(i));
            }
            Console.Write("Press Any Key to Close the Program...");
            Console.ReadKey();
            break;
        case 2:
            PlayFizzBuzz();
            break;
        default:
            return;
    }
}

string ReturnString(int number)
{
    if(number % 3 == 0 && number % 5 == 0)
    {
        return "fizzbuzz";
    }
    else if(number % 3 == 0)
    {
        return "fizz";
    }
    else if(number  % 5 == 0)
    {
        return "buzz";
    }

    return number.ToString();
}

void PlayFizzBuzz()
{
    Console.WriteLine("How Long do you want to play?(number to count to)");
    Console.Write("HighestNumber:");

    int length = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    int lifes = 3;
    do
    {
        if (lifes == 0) return;
        if (i % 3 == 0 && i % 5 == 0)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("What comes next?");
            Console.Write("Choice:");
            string choice = Console.ReadLine();
            if (choice == "fizzbuzz" || choice == "Fizzbuzz" || choice == "FIZZBUZZ")
            {
                Console.WriteLine("Correct");
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("Incorrect");
                lifes--;
                Console.WriteLine(lifes + " lifes left");
                Thread.Sleep(250);
            }
        }
        if (i % 5 == 0)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("What comes next?");
            Console.Write("Choice:");
            string choice = Console.ReadLine();
            if (choice == "buzz" || choice == "Buzz" || choice == "BUZZ")
            {
                Console.WriteLine("Correct");
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("Incorrect");
                lifes--;
                Console.WriteLine(lifes + " lifes left");
                Thread.Sleep(250);
            }
        }
        if (i % 3 == 0)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("What comes next?");
            Console.Write("Choice:");
            string choice = Console.ReadLine();
            if (choice == "fizz" || choice == "Fizz" || choice == "FIZZ")
            {
                Console.WriteLine("Correct");
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("Incorrect");
                lifes--;
                Console.WriteLine(lifes + " lifes left");
                Thread.Sleep(250);
            }
        }
        Console.WriteLine(i);
        i++;
    } while (i < length);
}