 // See https://aka.ms/new-console-template for more information

// classname objectname = new classname();

Student stu = new Student();
stu.getinfo();
stu.Info("codeswithpankaj");
Console.WriteLine(stu.getname());


//add mul
// highest number using if-else
number jai = new number();
jai.project( 10  , 23 , 11);


//client constructors

Clients clients1 = new Clients("welcome...");//PARAMETERS
Clients clients2 = new Clients("dot...net");//PARAMETERS
Clients clients3 = new Clients(45);//PARAMETERS
clients3.Funct(90, 90);


// books class object

Books books = new Books(1200,"DOTNET","publishers",9321642759);

Console.WriteLine("Books Name : " + books.getBookname());
Console.WriteLine("Books Price : " + books.getPrice());
Console.WriteLine("Book author : " + books.getAuthor());
Console.WriteLine("phone number: " + books.getPhonenumber());

books.setPrice(456);

Console.WriteLine("Books Name : " + books.getBookname());
Console.WriteLine("Books Price : " + books.getPrice());

books.setBookname("c#");

Console.WriteLine("Books Name : " + books.getBookname());
Console.WriteLine("Books Price : " + books.getPrice());

books.setAuthor("Keerti institute");

Console.WriteLine("Books Name : " + books.getBookname());
Console.WriteLine("Books Price : " + books.getPrice());
Console.WriteLine("Book author : " + books.getAuthor());

books.setPhonenumber(1234567890);
Console.WriteLine("Books Name : " + books.getBookname());
Console.WriteLine("Books Price : " + books.getPrice());
Console.WriteLine("Book author : " + books.getAuthor());
Console.WriteLine("phone number: " + books.getPhonenumber());


srname p = new srname();
p.getname();
p.getprice();
p.getmoney();
p.getsrname();

ice j = new ice();
drink i = new drink();
choc d = new choc();
j.getwater();
j.getice();

i.getwater();
i.getdrink();

d.getchoc();
d.getwater();

//polymoface
Customer customer = new Customer();
Customer customer1 = new Customer(45);
Customer customer2 = new Customer("jainam");
Customer customer3 = new Customer(6.1f);
Customer customer4 = new Customer(6123456789);

customer.info();
customer.info("jain");
customer.info("dadar west",5622);
customer.info(56);

SamplesArrayList sa = new SamplesArrayList();
sa.print();