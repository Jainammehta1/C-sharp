class Customer {

    // methods overloding 

   public void info() {
        Console.WriteLine("Customer Name : joy");
    }

    public void info(int age) {
        Console.WriteLine("customer - age " + age);
    }

    public void info(string name) 
    { 
        Console.WriteLine("customer last name" + name); 
    }
    public void info(string address,int pin) {
        Console.WriteLine("Customer Address : " + address);
        Console.WriteLine("Customer Address PIN code " + pin);
    }


    public Customer() { 
        Console.WriteLine("AWS food");
    }

    public Customer(int age)
    {
        Console.WriteLine("---------"+age);
    }

   public Customer(string name)
    {
        Console.WriteLine("--------"+name);
    }
    public Customer(float height)
    {
        Console.WriteLine("-------"+height);
    }
    public Customer(long phone)
    {
        Console.WriteLine("-------"+phone);
    }

}