namespace Func_Delegate_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Func with Named Method
            Func<int, int, int, int> add = Add;

            var result = add(10, 10, 10);
            Console.WriteLine(result);


            // Func with Anonymous Method
            Func<string, string, string> getFullName = delegate(string name, string surName)
            {
                return $"{name} {surName}";
            };

            var fullName = getFullName("Aijaz", "Abro");
            Console.WriteLine(fullName);


            // Func with lambda expression
            Func<int, int> square = (int val) => val * val;

            Console.WriteLine(square(5));
        }

        // Named method
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
