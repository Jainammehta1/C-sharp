using System;
using System.Collections;
public class SamplesArrayList
{

    //collection
    
    
    public void print() { 
    
        

        ArrayList data = new ArrayList();

        data.Add(1);
        data.Add(2);
        data.Add(3);
        data.Add(4);
        data.Add(5);
        data.Add(6);
        data.Add(7);

        Console.WriteLine("Array List ITEM : "+data[3]);

        foreach (int i in data) { 
        
        Console.WriteLine(i);
        }

        ArrayList data1 = new ArrayList();


        data1.Add("sdfsf");
        data1.Add("sdfsf");
        data1.Add("sdfsf");
        data1.Add("sdfsf");
        data1.Add("sdfsf");
        data1.Add("sdfsf");
        data1.Add("sdfsf");
      

        Console.WriteLine("Array List ITEM : " + data1[3]);

        foreach(string i in data1)
        {

            Console.WriteLine(i);
        }

        List<string> parts = new List<string>();
        parts.Add("abc");
        parts.Add("abc");
        parts.Add("abc");
        parts.Add("abc");
        parts.Add("abc");
        parts.Add("abc");

        foreach(string i in parts)
        {
            Console.WriteLine(i);
        }


        int[] num = new int[3];

        num[0] = 6;
        num[1] = 4;
        num[2] = 3;

        for (int i = 0; i < num.Length; i++) {
            Console.WriteLine("item in num - " + i);
        }

        string[] name = new string[10];

        name[0] ="jainam";
        name[1] = "qwed";
        name[2] = "assdd";
        name[3] = "assdd";
        name[4] = "hdhdhd";
        name[5] = "hdhdhd";
        name[6] = "hdhdhd";
        name[7] = "hdhdhd";
        name[8] = "hdhdhd";
        name[9] = "hdhdhd";
        name[10] = "hdhdhd";


        for(int i =0;i< name.Length;i++)
        {
            Console.WriteLine("item in name - " +i);
        }


    }


}




