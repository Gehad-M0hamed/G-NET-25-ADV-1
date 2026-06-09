using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
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

            #region Q6:
            //Generic Interface:
            //  A generic interface is an interface that defines a contract with one or more type parameters.Classes that implement a generic interface must specify the actual data types to fulfill that contract.
            //They are widely used in C# for collections (like IEnumerable<T>) and patterns that handle multiple data models with the same set of operations.
            //ProductRepository repo = new ProductRepository();

            //foreach (var product in repo.GetAll())
            //{
            //    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}");
            //}
            #endregion

            #region Q7:
            //The struct constraint restricts the type parameter <T> to value types only.
            //This ensures that <T> cannot be a reference type (like a class or string) and cannot be null (unless explicitly declared as nullable).
            //ValueContainer<int> IntContainer = new ValueContainer<int>(44);
            //ValueContainer<double> DoubleContainer = new ValueContainer<double>(4.44);
            //Console.WriteLine($"int:{IntContainer.Value}");
            //Console.WriteLine($"double:{DoubleContainer.Value}");
            #endregion

            #region Q8:
            //The class constraint specifies that the type argument <T> must be a reference type. This includes any class, interface, delegate, or array type.
            //It ensures that <T> cannot be a value type, such as int, bool, or a struct.
            //Cache<string> messageCache = new Cache<string>();
            //messageCache.Set("Hello from Route!");
            //string? data = messageCache.Get();
            //Console.WriteLine($"Cached Data: {data}");
            //string myString = "Route";
            //Cache<string> anotherCache = new Cache<string>();
            //anotherCache.Set(myString);

            //Console.WriteLine($"Is Same Reference? {anotherCache.IsSame(myString)}");
            #endregion

            #region Q9:
            //he new() constraint is a generic constraint that specifies that any type argument used for <T> must have a public,
            //parameterless constructor. This allows you to create a new instance of the type $T$ directly inside your generic class or method using the syntax new T().
            //Factory<Person> PersonFactory= new Factory<Person>();
            //Person P1 = PersonFactory.Create();
            //P1.Name = "Ali";
            //P1.Age = 20;
            //Console.WriteLine($"Created:{P1}");
            #endregion

            #region Q10:
            //An interface constraint specifies that the type argument <T> must implement a particular interface.
            //This is one of the most powerful constraints because it allows the generic code to call methods, properties, or events defined by that interface on the type parameter.
            //Without this constraint, the compiler treats <T> as a basic object and will not allow you to call specific members belonging to a custom interface.
            //int[] numbers = { 5, 4, 7, 8, 1, 2 };
            //string[] names = { "sara", "ali", "heba" };
            //Console.WriteLine($"max:{ComparableHelper.FindMax(numbers)}");
            //Console.WriteLine($"min:{ComparableHelper.FindMin(numbers)}");
            //Console.WriteLine($"max:{ComparableHelper.FindMax(names)}");
            //Console.WriteLine($"min:{ComparableHelper.FindMin(names)}");

            #endregion

            #region Q11:
            //The base class constraint specifies that a type argument must inherit from a specific base class.
            //This allows the generic class or method to access all public and protected members of that base class directly on the type parameter <T>.

            #endregion

            #region Q12:
            //list them sequentially after the where T: clause, separated by commas.
            //    public class DataMapper<TSource, TDest>
            //    where TSource : class
            //    where TDest : class, new()
            //{
            //    public TDest Map(TSource source)
            //    {
            //        TDest destination = new TDest();

            //        return destination;
            //    }
            //}

            #endregion

            #region Q13:
            //The default keyword in generics is used to get the default value of a type parameter T at runtime.

            #endregion

            #region Q14:

            //var safeInts = new SafeList<int>();
            //safeInts.Add(10);
            //safeInts.Add(20);

            //Console.WriteLine($"Valid Index (1): {safeInts[1]}");
            //Console.WriteLine($"Invalid Index (5): {safeInts[5]}");

            //var safeStrings = new SafeList<string>();
            //safeStrings.Add("Route");

            //Console.WriteLine($"Valid Index (0): {safeStrings[0]}");
            //Console.WriteLine($"Invalid Index (2) is null: {safeStrings[2] == null}");


            #endregion

            #region Q15:

            #endregion

        }
    }

}
    

