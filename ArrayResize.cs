using System;

namespace Examples
{

    public class Array
    {

        public static void ReSiize(ref int[] source, int reSize)
        {

            int[] temp = new int[reSize];
            for (int i = 0; i < source.Length; i++)
            {

                temp[i] = source[i];
            }
            source = temp;
        }
    }

    public class DynamicIntegerArray
    {

        private int[] buffer = new int[5];

        public void Set_Item(int index, int item)
        {

            if (index >= buffer.Length)
            {

                Array.ReSiize(ref buffer, index + 1);
            }
            buffer[index] = item;

        }

        public int Get_Item(int index)
        {

            return buffer[index];
        }

        public void Clear()
        {


        }
    }

    public class Program
    {

        public static void Main()
        {

            DynamicIntegerArray _intArray = new DynamicIntegerArray();
            _intArray.Set_Item(0, 10); // _intArray[0]=10;
            _intArray.Set_Item(1, 20);
            _intArray.Set_Item(2, 40);
            _intArray.Set_Item(3, 50);
            _intArray.Set_Item(4, 60);
            _intArray.Set_Item(5, 70);//Exception
            _intArray.Set_Item(6, 80);
            _intArray.Set_Item(7, 90);
            _intArray.Set_Item(8, 100);

            //int _value=_intArray[8];
            int _value = _intArray.Get_Item(8);
            Console.WriteLine(_value);
            Console.WriteLine(_intArray.ItemsCount);
            Console.WriteLine(_intArray.Capacity);
        }

    }

}