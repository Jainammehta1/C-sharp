class Clients {

    public Clients() {
        Console.WriteLine("welcome- codes with pankaj");
    }
    public Clients(string msg) {
        Console.WriteLine("p4n.in - " + msg);
    }
    public void Funct(int a, int b)
    {
        Console.WriteLine("enter the number :" + a + " ", +b + " ");

        if (a == b)
        {
            Console.WriteLine("the variable a is equal to b", +a, +b);
        }
        else
        {
            Console.WriteLine("a is not equal to b");
        }
    }
    public Clients(int num)
    {
        Console.WriteLine(+num);
    }
}




