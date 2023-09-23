namespace CustomeDelelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action DElegate for void function 
            Action<int, int> mulPtr = Multiply;
            mulPtr(10, 20);


            //PREDECATE FOR BOOL RETURN TYPE
            Predicate<string> longNamePtr = CheckIsLongName;
            Console.WriteLine(longNamePtr("Joshit"));

            //FUNC DELEGATE FOR VALUES

            Func<int, int, int> addPtr = Add;
            Console.WriteLine(addPtr(10,20));


        }

        static bool CheckIsLongName(string name)
        {
            return name.Length > 20;
        }

        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        static void Multiply(int n1,int n2)
        {
            Console.WriteLine("Miltiplication Answer IS "+n1*n2);
        }
    }
}