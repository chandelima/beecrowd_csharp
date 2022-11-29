using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {
        string[] months = new string[]{
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        string strInput = Console.ReadLine();
        int input = int.Parse(strInput);

        for (int i = 0; i < months.Length; i++)
        {
            if (input == (i + 1))
                System.Console.WriteLine(months[i]);
        }

        
    }
}