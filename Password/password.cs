// See https://aka.ms/new-console-template for more information

using System.Net.Security;

string correctpassword = "jainam123";
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("enter the password");
    string enteredpassword = Console.ReadLine();
    if (enteredpassword == correctpassword)
    {
        Console.WriteLine("the password is correct,ACCESS GRANTED");
        startexam();
        break;
    }

    else
    {
        Console.WriteLine("try again it is incorrect");
    }
}
Console.WriteLine("Access denied");

static void startexam()
{
    string[] questions =
    {
        "1. What is the capital of france?",
        "a)paris\n b)rome\n c)Madrid",
        "2. Who is the prime minister of india?",
        "a)Narendra modi\n b)Rahul gandhi\n c)Ms dhoni"
    };
    string[] answers =
    {
        "a","b"
    };
    
}


