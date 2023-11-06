
//hirechay:when child has child too
//multiple :when one superparent has 3 childs
//single :only parent and child
class glass
{
    public void getwater()
    {
        Console.WriteLine("this is the glass of water");
    }
}

class drink:glass
{
    public void getdrink()
    {
        Console.WriteLine("i love coco");
    }
}
class ice : glass
{
    public void getice()
    {
        Console.WriteLine("give me ice");
    }
}
class choc : glass
{
    public void getchoc()
    {
        Console.WriteLine("give me some chocolaate");
    }
}


class happ : choc
{
    public void gethapp()
    {
        Console.WriteLine("i am happy");
    }
}
