using System;
class Program
{
    public static void Main()
    {
        byte[] array = new byte[200000];
        int ptr = 0; array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        while (array[ptr] != 0)
        {
            ++ptr;
            array[ptr]++;
            array[ptr]++;
            array[ptr]++;
            array[ptr]++;
            while (array[ptr] != 0)
            {
                ++ptr;
                array[ptr]++;
                array[ptr]++;
                ++ptr;
                array[ptr]++;
                array[ptr]++;
                array[ptr]++;
                ++ptr;
                array[ptr]++;
                array[ptr]++;
                array[ptr]++;
                ++ptr;
                array[ptr]++;
                --ptr;
                --ptr;
                --ptr;
                --ptr;
                array[ptr]--;
            }
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]--;
            ++ptr;
            ++ptr;
            array[ptr]++;
            while (array[ptr] != 0)
            {
                --ptr;
            }
            --ptr;
            array[ptr]--;
        }
        ++ptr;
        ++ptr;
        Console.Write(Convert.ToChar(array[ptr]));
        ++ptr;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        Console.Write(Convert.ToChar(array[ptr]));
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        Console.Write(Convert.ToChar(array[ptr]));
        ++ptr;
        ++ptr;
        Console.Write(Convert.ToChar(array[ptr]));
        --ptr;
        array[ptr]--;
        Console.Write(Convert.ToChar(array[ptr]));
        --ptr;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr]++;
        array[ptr]++;
        array[ptr]++;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        array[ptr]--;
        Console.Write(Convert.ToChar(array[ptr]));
        ++ptr;
        ++ptr;
        array[ptr]++;
        Console.Write(Convert.ToChar(array[ptr]));
        ++ptr;
        array[ptr]++;
        array[ptr]++;
        Console.Write(Convert.ToChar(array[ptr]));
    }
}