using System;

// 인덱서, 제너릭 실습과제 3번

/// <summary>

///     Implements overloaded indexers.

/// </summary>

class OvrIndexer
{
    private string[] myData;
    private int arrSize;

    public OvrIndexer(int size)
    {
        arrSize = size;
        myData = new string[size];

        for (int i = 0; i < size; i++)
        {
            //myData setting
            myData[i] = "empty";
        }
    }
    // myInd[9] = "Some Value"; / [9] / 9 가 숫자이기때문에 int로 받는다 
    public string this[int data] // 여기서 data가 쓸수 있는 경우는 스코프개념 
    {
        get
        {
            return myData[data];
        }
        set
        {
            myData[data] = value;
        }
    }


    // myInd["empty"] = "no value"; / "empty" :string 이기때문에 string으로 받음 
    public string this[string data]
    {

        get
        {
            int count = 0;

            for (int i = 0; i < arrSize; i++)
            {
                if (myData[i] == data)
                {
                    count++;
                }
            }
            return count.ToString();
        }

        set
        {
            for (int i = 0; i < arrSize; i++)
            {
                if (myData[i] == data)
                {
                    myData[i] = value;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int size = 10;
        OvrIndexer myInd = new OvrIndexer(size);

        //  myInd[9] = "Some Value"; set
        myInd[9] = "Some Value";
        myInd[3] = "Another Value";
        myInd[5] = "Any Value";
        myInd["empty"] = "no value";

        Console.WriteLine("\nIndexer Output\n");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
        }
        Console.WriteLine("\nNumber of \"no value\" entries: {0}", myInd["no value"]);
        // myInd["no value"] : get 
    }
}


