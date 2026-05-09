using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_25_ADV_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:
            //Generic Class:
            // A generic class is a class defined with type parameters(like T) that act as placeholders for actual data types,
            // which are specified only when the code is used.
            //Why use Generics:
            //*Type Safety.
            //*Performance.
            //* Code Reuse.
            //* IntelliSense.
            #endregion

            #region Q2:
            //Container<int> container = new Container<int>();
            //container.Add(10);
            //container.Add(40);
            //container.Add(14);
            //for (int i = 0; i < container._count; i++)
            //{
            //    Console.WriteLine($"Element at Container {i}: {container.Get(i)}");
            //}
            #endregion

            #region Q3:
            //Multiple Type Parameters:
            // Generic classes and methods are not limited to a single placeholder like T.
            // You can define them with multiple type parameters to handle different types of data simultaneously within the same class.
            //Pair<int,string> Pair01 = new Pair<int,string> (1, "One");
            //Pair<string,bool> Pair02 = new Pair<string,bool>("Open?",true);
            //Console.WriteLine($"Pair01:{Pair01}");
            //Console.WriteLine($"Pair02:{Pair02}");
            #endregion

            #region Q4:

            //Generic Method: 
            //  A generic method is a method that is declared with type parameters for its return type or its parameters.
            //  It allows the method to work with any data type while maintaining type safety. These methods can exist within both generic and non - generic classes.
            //  Often, the compiler can infer the type argument based on the data passed to the method.
            //int x = 10, y = 20;
            //Utilities.Swap(ref x, ref y); 
            //Console.WriteLine($"x = {x}, y = {y}"); //x = 20, y = 10
            #endregion

            #region Q5:
         
            //int maxInt = Utilities.FindMax(10, 20); 
            //string maxStr = Utilities.FindMax("A", "B"); 
            //Console.WriteLine($"The max int is: {maxInt}");//  20
            //Console.WriteLine($"The max string is: {maxStr}");// B
            #endregion



        }
    }
}
