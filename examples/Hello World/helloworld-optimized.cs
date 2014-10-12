using System;
class Program
{
    public static void Main()
    {
        byte[] array = new byte[200000];
        int ptr = 0;
        array[ptr] += 8;
        while (array[ptr] != 0)
        {
            ++ptr;
            array[ptr] += 4;
            while (array[ptr] != 0)
            {
                ++ptr;
                array[ptr] += 2;
                ++ptr;
                array[ptr] += 3;
                ++ptr;
                array[ptr] += 3;
                ++ptr;
                array[ptr]++;
                ptr -= 4;
                array[ptr]--;
            }
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]--;
            ptr += 2;
            array[ptr]++;
            while (array[ptr] != 0)
            {
                --ptr;
            }
            --ptr;
            array[ptr]--;
        }
        ptr += 2;
        Console.Write(Convert.ToChar(array[ptr]));
        ++ptr;
        array[ptr] -= 3;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr] += 7;
        Console.Write(Convert.ToChar(array[ptr]));
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr] += 3;
        Console.Write(Convert.ToChar(array[ptr]));
        ptr += 2;
        Console.Write(Convert.ToChar(array[ptr]));
        --ptr;
        array[ptr]--;
        Console.Write(Convert.ToChar(array[ptr]));
        --ptr;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr] += 3;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr] -= 6;
        Console.Write(Convert.ToChar(array[ptr]));
        array[ptr] -= 8;
        Console.Write(Convert.ToChar(array[ptr]));
        ptr += 2;
        array[ptr]++;
        Console.Write(Convert.ToChar(array[ptr]));
        ++ptr;
        array[ptr] += 2;
        Console.Write(Convert.ToChar(array[ptr]));
    }
}