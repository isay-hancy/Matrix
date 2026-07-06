using System;

class IndexerProgram
{
    private int[] data = new int[5];

    public int this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }

     static void Main(string[] args)
    {
        IndexerProgram obj = new IndexerProgram();

        obj[0] = 10;
        obj[1] = 20;
        obj[2] = 30;
        obj[3] = 40;
        obj[4] = 50;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(obj[i]);
        }
    }
}