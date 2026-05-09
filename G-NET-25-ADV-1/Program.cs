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
            Container<int> container = new Container<int>();
            container.Add(10);
            container.Add(40);
            container.Add(14);
            for (int i = 0; i < container._count; i++)
            {
                Console.WriteLine($"Element at Container {i}: {container.Get(i)}");
            }
            #endregion
        }
    }
}
