using System;

public class StringCalculator
{
    public int Add(string str)
    {
        if (str.Length == 0)
        {
            //Console.WriteLine("Invalid Input");
            return 0;
        }

        String[] seperator = { ",", "\n" };
        String[] no = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        int n, noSum = 0;
        foreach (string s in no)
        {
            if (int.TryParse(s, out n))
                noSum = noSum + n;
        }
        return noSum;
    }

    public static void Main()
    {

        StringCalculator sc = new StringCalculator();
        int output = sc.Add("1,1");
        Console.WriteLine(output);
    }
}