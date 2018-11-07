using System;


//  인덱서, 제너릭 실습과제 2번
class DataStore

{



    private string[] strArr = new string[10]; // internal data storage
    

    public DataStore() { }

    public string this[int index]

    {

        get

        {

            if (index < 0 || index >= strArr.Length)

                throw new IndexOutOfRangeException("Cannot store more than 10 objects");



            return strArr[index];

        }

        set

        {

            if (index < 0 || index >= strArr.Length)

                throw new IndexOutOfRangeException("Cannot store more than 10 objects");



            strArr[index] = value;

        }

    }



    public string this[string s]

    {
        
        get

        {

            foreach (string name in strArr)

            {

                if (s.ToLower() == name.ToLower())

                    return s;

            }



            return null;

        }

    }

}



class Program

{

    static void Main(string[] args)

    {

        DataStore strStore = new DataStore();



        strStore[0] = "One";

        strStore[1] = "Two";

        strStore[2] = "Three";

        strStore[3] = "Four";



        Console.WriteLine(strStore["one"]);

        Console.WriteLine(strStore["two"]);

        Console.WriteLine(strStore["Three"]);

        Console.WriteLine(strStore["FOUR"]);

    }

}