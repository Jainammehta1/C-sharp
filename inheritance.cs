class pen
{
    public void getname() {
        Console.WriteLine("p4n pen");
    }
}
class price : pen{ 

    public void getprice() {
        Console.WriteLine(300);
    }
}
class money : price { 
public void getmoney()
    {
        Console.WriteLine(500);
    }
}
class srname : money
{


   public void getsrname()
    {
        Console.WriteLine("mehta");

    }
}
