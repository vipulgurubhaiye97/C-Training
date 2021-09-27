using System;

// dynamic array code with indexor

namespace Examples
{

    public class Array
    {

        public static void Resize(ref int[] source, int reSize)
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
        private int itemCnt;

        public int this[int index]
        {
            set
            {
                itemCnt++;
                if (index >= buffer.Length)
                {
                    Array.Resize(ref buffer, index + 10);
                }
                buffer[index] = value;
            }
            get
            {
                return buffer[index];
            }
        }

        public void Clear() { }

        public int ItemsCnt
        {
            get
            {
                return itemCnt;
            }
        }

        public int Capacity
        {
            get
            {
                return buffer.Length;
            }
        }

    }


    public class Program
    {

        public static void Main()
        {
            DynamicIntegerArray _intArray = new DynamicIntegerArray();
            // _intArray.Set_Item(0,10); // _intArray[0]=10;

            _intArray[0] = 10;
            _intArray[1] = 20;
            _intArray[2] = 30;
            _intArray[3] = 40;
            _intArray[4] = 50;
            _intArray[5] = 60;
            _intArray[6] = 70;
            _intArray[7] = 80;
            _intArray[8] = 90;
            _intArray[9] = 100;

            int _value = _intArray[8];
            // int _value=_intArray.Get_Item(8);
            Console.WriteLine(_value);
            Console.WriteLine(_intArray.ItemsCnt);
            Console.WriteLine(_intArray.Capacity);
        }

    }
}