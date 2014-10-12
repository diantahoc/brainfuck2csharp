using System;
class Program
{
    public static void Main()
    {
        byte[] array = new byte[200000];
        int ptr = 0;
        array[ptr] += 10;
        while (array[ptr] != 0)
        {
            ++ptr;
            array[ptr] += 10;
            --ptr;
            array[ptr]--;
        }
        ptr += 2;
        array[ptr] += 10;
        ++ptr;
        array[ptr]--;
        ptr += 16;
        array[ptr] -= 2;
        ++ptr;
        array[ptr] += 7;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            ++ptr;
            array[ptr] += 10;
            --ptr;
        }
        ++ptr;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ptr -= 4;
        }
        array[ptr] += 3;
        ptr += 2;
        array[ptr] += 3;
        ptr += 3;
        array[ptr] += 8;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            --ptr;
            array[ptr] += 4;
            --ptr;
            array[ptr] += 4;
            --ptr;
            array[ptr] += 4;
            ptr += 3;
        }
        array[ptr] += 5;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            --ptr;
            array[ptr] += 4;
            --ptr;
            array[ptr] += 4;
            ptr += 2;
        }
        ptr += 2;
        array[ptr] -= 2;
        ++ptr;
        array[ptr] += 6;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            ++ptr;
            array[ptr] += 11;
            --ptr;
        }
        ++ptr;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ++ptr;
            array[ptr]++;
            ptr -= 4;
        }
        array[ptr] += 5;
        ptr += 2;
        array[ptr]++;
        ++ptr;
        array[ptr] += 6;
        ++ptr;
        array[ptr] += 6;
        ++ptr;
        array[ptr] += 8;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            --ptr;
            array[ptr] += 4;
            --ptr;
            array[ptr] += 4;
            --ptr;
            array[ptr] += 4;
            ptr += 3;
        }
        array[ptr] += 6;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            --ptr;
            array[ptr] += 3;
            --ptr;
            array[ptr] += 3;
            --ptr;
            array[ptr] += 3;
            ptr += 3;
        }
        ptr += 2;
        array[ptr] -= 2;
        ++ptr;
        array[ptr] -= 3;
        array[ptr]++;
        while (array[ptr] != 0)
        {
            array[ptr]--;
            --ptr;
            array[ptr]++;
        }
        array[ptr]--;
        --ptr;
        while (array[ptr] != 0)
        {
            array[ptr]++;
            while (array[ptr] != 0)
            {
                array[ptr]--;
                ++ptr;
                array[ptr]++;
            }
            array[ptr]--;
            ptr -= 2;
            array[ptr]--;
            ptr += 3;
            array[ptr]++;
            ++ptr;
            while (array[ptr] != 0)
            {
                array[ptr]--;
            }
            array[ptr] += 2;
            while (array[ptr] != 0)
            {
                array[ptr] -= 2;
                ++ptr;
                array[ptr] += 2;
            }
            array[ptr] -= 2;
            ++ptr;
            array[ptr] += 3;
            while (array[ptr] != 0)
            {
                array[ptr] -= 3;
                array[ptr] += 2;
                while (array[ptr] != 0)
                {
                    array[ptr] -= 2;
                    --ptr;
                    array[ptr] += 2;
                }
                array[ptr] -= 4;
                ptr += 2;
                array[ptr]--;
                --ptr;
                array[ptr]++;
                ++ptr;
                while (array[ptr] != 0)
                {
                    array[ptr] += 4;
                    while (array[ptr] != 0)
                    {
                        array[ptr] -= 4;
                        --ptr;
                        array[ptr] += 4;
                    }
                    array[ptr] -= 2;
                    while (array[ptr] != 0)
                    {
                        ++ptr;
                    }
                    array[ptr] += 2;
                    while (array[ptr] != 0)
                    {
                        array[ptr] -= 2;
                        ++ptr;
                        array[ptr] += 2;
                    }
                    array[ptr] -= 2;
                    --ptr;
                }
                ++ptr;
                array[ptr] += 2;
                while (array[ptr] != 0)
                {
                    array[ptr] -= 2;
                    array[ptr]++;
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                        --ptr;
                        array[ptr]++;
                    }
                    array[ptr]--;
                    ptr += 2;
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                    }
                    array[ptr] += 5;
                    while (array[ptr] != 0)
                    {
                        array[ptr] -= 4;
                        ++ptr;
                        array[ptr] += 4;
                    }
                    array[ptr] -= 2;
                    ++ptr;
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                        ++ptr;
                        array[ptr]++;
                        --ptr;
                    }
                    ptr += 2;
                    while (array[ptr] != 0)
                    {
                        Console.Write(Convert.ToChar(array[ptr]));
                        ++ptr;
                    }
                    array[ptr] += 2;
                    while (array[ptr] != 0)
                    {
                        array[ptr] -= 2;
                        ++ptr;
                        array[ptr] += 2;
                    }
                }
                array[ptr] -= 2;
                ++ptr;
                array[ptr] += 3;
            }
            array[ptr] -= 3;
            array[ptr]++;
            while (array[ptr] != 0)
            {
                array[ptr]--;
                --ptr;
                array[ptr]++;
            }
            array[ptr]--;
            ptr += 2;
            array[ptr]--;
            while (array[ptr] != 0)
            {
                array[ptr]++;
                ptr += 3;
                array[ptr]++;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                    --ptr;
                    array[ptr]++;
                }
                array[ptr]--;
                ptr += 3;
                array[ptr] += 10;
                ptr -= 2;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                    ++ptr;
                    array[ptr]++;
                    ++ptr;
                    array[ptr]--;
                    while (array[ptr] != 0)
                    {
                        ++ptr;
                        array[ptr]++;
                        ptr += 2;
                    }
                    ++ptr;
                    while (array[ptr] != 0)
                    {
                        array[ptr]++;
                        while (array[ptr] != 0)
                        {
                            array[ptr]--;
                            --ptr;
                            array[ptr]++;
                            ++ptr;
                        }
                        ++ptr;
                        array[ptr]++;
                        ptr += 2;
                    }
                    ptr -= 6;
                }
                ptr += 2;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                }
                ptr += 3;
                array[ptr] += 10;
                --ptr;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                    ++ptr;
                    array[ptr]--;
                    while (array[ptr] != 0)
                    {
                        ++ptr;
                        array[ptr]++;
                        ptr += 2;
                    }
                    ++ptr;
                    while (array[ptr] != 0)
                    {
                        array[ptr]++;
                        while (array[ptr] != 0)
                        {
                            array[ptr]--;
                            --ptr;
                            array[ptr]++;
                            ++ptr;
                        }
                        ++ptr;
                        array[ptr]++;
                        ptr += 2;
                    }
                    ptr -= 5;
                }
                ++ptr;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                }
                ptr += 2;
                while (array[ptr] != 0)
                {
                    ++ptr;
                    array[ptr] += 6;
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                        --ptr;
                        array[ptr] += 8;
                        ++ptr;
                    }
                    --ptr;
                    Console.Write(Convert.ToChar(array[ptr]));
                    ptr -= 2;
                    array[ptr]++;
                    ++ptr;
                    array[ptr]++;
                    ++ptr;
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                    }
                }
                --ptr;
                while (array[ptr] != 0)
                {
                    --ptr;
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                        ++ptr;
                        array[ptr]--;
                        --ptr;
                    }
                    array[ptr] += 6;
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                        ++ptr;
                        array[ptr] += 8;
                        --ptr;
                    }
                    ++ptr;
                    Console.Write(Convert.ToChar(array[ptr]));
                    while (array[ptr] != 0)
                    {
                        array[ptr]--;
                    }
                }
                ptr -= 2;
                array[ptr] += 6;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                    --ptr;
                    array[ptr] += 8;
                    ++ptr;
                }
                --ptr;
                Console.Write(Convert.ToChar(array[ptr]));
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                }
                ptr -= 2;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                    --ptr;
                    array[ptr]++;
                    ++ptr;
                }
                array[ptr]++;
                while (array[ptr] != 0)
                {
                    array[ptr]--;
                    --ptr;
                    array[ptr]++;
                }
                array[ptr]--;
                ptr += 2;
            }
            array[ptr]++;
            while (array[ptr] != 0)
            {
                array[ptr]--;
            }
            ptr -= 3;
            Console.Write(Convert.ToChar(array[ptr]));
            ptr += 3;
            array[ptr]++;
            while (array[ptr] != 0)
            {
                array[ptr]--;
                --ptr;
                array[ptr]++;
            }
            array[ptr]--;
            ptr -= 2;
        }
    }
}