class Books {

    int price;
    String bookname;
    String author;
    long phonenumber;

   public Books(int Price,String Bookname,String Author,long Phonenumber) { 
    
        this.price = Price;
        this.bookname = Bookname;
         this.author = Author;
        this.phonenumber = Phonenumber;

    }

    public int getPrice()
    {
        return price;
    }

    public String getBookname()
    {
        return bookname;
    }

    public void setPrice(int Price)
    {
        this.price = Price;
    }
    public  void setBookname(String Bookname) { 
        this.bookname=Bookname;
    }
    public void setAuthor(string Author)
    {
        this.author = Author;
    }
    public String getAuthor()
    {
        return author;
    }
    public void setPhonenumber(int Phonenumber)
    {
        this.phonenumber = Phonenumber;
    }
    public long getPhonenumber()
    {
        return phonenumber;
    }



}