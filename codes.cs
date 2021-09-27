namespace Examples{
 
    public class Stack{

        //State
        //Array of Integers


        //public void Push(Stack this,int item)
        public void Push(int item){  


        }

        public int Pop(){  return default(int); }

        public void Clear(){}
    }

    public class Program{

    public static  void Main(){

        Stack s1=new Stack();
        s1.Push(10);// Stack.Push(s1,10);
        s1.Push(200);
        s1.Push(25);
        s1.Push(45);

    int topItem=s1.Pop();
        Console.WriteLine(topItem); //45
        topItem=s1.Pop();
        Console.WriteLine(topItem);//25
        topItem=s1.Pop();
        Console.WriteLine(topItem);//200
        topItem=s1.Pop();
        Console.WriteLine(topItem);//10
    }

    }
 
}

__________________________________________________________

public class DynamicIntegerArray{​​​​

        private int[] buffer=new int[5];

        public void Set_Item(int index,int item){​​​​

          buffer[index]=item;

        }​​​​

        public int Get_Item(int index){​​​​

            return buffer[index];

        }​​​​

        public void Clear(){​​​​

        }​​​​

    }​​​​

public class Program{​​​​

    public static  void Main(){​​​​

        DynamicIntegerArray _intArray=new DynamicIntegerArray();

        _intArray.Set_Item(0,10); // _intArray[0]=10;

        _intArray.Set_Item(1,20);

        _intArray.Set_Item(2,40);

        _intArray.Set_Item(3,50);

        _intArray.Set_Item(4,60);

        _intArray.Set_Item(5,70);//Exception

        _intArray.Set_Item(6,80);

        _intArray.Set_Item(7,90);

        _intArray.Set_Item(8,100);

        //int _value=_intArray[8];

        int _value=_intArray.Get_Item(8);

    }​​​​

    }​​​​ }​​​​

________________________________________________________

using System;
 
namespace Examples{

    public class Array{

        public static void ReSiize(ref int[] source,int reSize){

            int[] temp =new int[reSize];
            for(int i=0;i<source.Length;i++){

                temp[i]=source[i];
            }
            source=temp;
        }
    }

    public class DynamicIntegerArray{

        private int[] buffer=new int[5];

        public void Set_Item(int index,int item){  

            if(index>=buffer.Length){

                Array.ReSiize(ref buffer,index +1);
            }
          buffer[index]=item;

        }

        public int Get_Item(int index){

            return buffer[index];
        }

        public void Clear(){


        }
    }

    public class Program{

    public static  void Main(){

        DynamicIntegerArray _intArray=new DynamicIntegerArray();
        _intArray.Set_Item(0,10); // _intArray[0]=10;
        _intArray.Set_Item(1,20);
        _intArray.Set_Item(2,40);
        _intArray.Set_Item(3,50);
        _intArray.Set_Item(4,60);
        _intArray.Set_Item(5,70);//Exception
        _intArray.Set_Item(6,80);
        _intArray.Set_Item(7,90);
        _intArray.Set_Item(8,100);

        //int _value=_intArray[8];
        int _value=_intArray.Get_Item(8);
        Console.WriteLine(_value);
        Console.WriteLine(_intArray.ItemsCount);
        Console.WriteLine(_intArray.Capacity);
    }

    }
 
}

___________________________________________________________________

using System;



// dynamic array code with indexor



namespace Examples{



public class Array{



public static void Resize(ref int[] source,int reSize){



int[] temp =new int[reSize];
for(int i=0;i<source.Length;i++){



temp[i]=source[i];
}
source=temp;
}
}



public class DynamicIntegerArray{



private int[] buffer=new int[5];
private int itemCnt;

public int this[int index]
{
set
{
itemCnt++;
if (index >= buffer.Length){
Array.Resize(ref buffer, index + 10);
}
buffer[index] = value;
}
get
{
return buffer[index];
}
}


public void Clear(){}

public int ItemsCnt
{
get{
return itemCnt;
}
}

public int Capacity
{
get{
return buffer.Length;
}
}



}



public class Program{



public static void Main(){



DynamicIntegerArray _intArray=new DynamicIntegerArray();
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



int _value=_intArray[8];
// int _value=_intArray.Get_Item(8);
Console.WriteLine(_value);
Console.WriteLine(_intArray.ItemsCnt);
Console.WriteLine(_intArray.Capacity);
}



}

}

____________________________________________________________

using System;
					
public class StringCalculator
{
	public int Add(string str){
	if(str.Length==0)
	{
	//Console.WriteLine("Invalid Input");
	return 0;
	}
		
	String[] seperator={",","\n"};
	String[] no=str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
	int n,noSum=0;
		foreach (string s in no){
			if(int.TryParse(s, out n))
			noSum=noSum+n;	
		}
		return noSum;
	}
	
	public static void Main()
	{
		
		StringCalculator sc = new StringCalculator();
		int output=sc.Add("1,1");
		Console.WriteLine(output);
	}
}


