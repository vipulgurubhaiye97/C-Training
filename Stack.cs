namespace Examples
{

    public class Stack
    {

        //State
        //Array of Integers


        //public void Push(Stack this,int item)
        public void Push(int item)
        {


        }

        public int Pop() { return default(int); }

        public void Clear() { }
    }

    public class Program
    {

        public static void Main()
        {

            Stack s1 = new Stack();
            s1.Push(10);// Stack.Push(s1,10);
            s1.Push(200);
            s1.Push(25);
            s1.Push(45);

            int topItem = s1.Pop();
            Console.WriteLine(topItem); //45
            topItem = s1.Pop();
            Console.WriteLine(topItem);//25
            topItem = s1.Pop();
            Console.WriteLine(topItem);//200
            topItem = s1.Pop();
            Console.WriteLine(topItem);//10
        }

    }

}