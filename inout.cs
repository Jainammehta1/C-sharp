class read
{
    public void getdata()
    {
        String loc = @"D:\Jainam\jj.txt";
        if (File.Exists(loc))
        {
            Console.WriteLine("File Exists");
            String line;
            line = File.ReadAllText(loc);
            Console.WriteLine(line);
        }
        Console.ReadKey();
    }

    public void writedat(String value)
    {

        File.WriteAllText(@"D:\Jainam\jj.txt", value);


    }

}
