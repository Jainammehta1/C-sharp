using System.ComponentModel.Design;

class number
{
    public void project(int a, int b, int c)
    {
        Console.WriteLine("ENTER THE NUMBER :" +a+" "+b+" " +c+" ");

        if(a>b && a > c)
        {
            Console.WriteLine(+a);
        }
        else if(b>a && b > c)
        {
            Console.WriteLine(+b);
        }
        else
        {
            Console.WriteLine(+c);
        }


    }
}