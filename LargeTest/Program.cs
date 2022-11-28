using Learning.CSharp;
using static Learning.CSharp.DelegateTest;

class Program
{
    public static event IncrementDelegate MyEvent;
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle { Length = 5, Width = 3 };
        Console.WriteLine($"The length is {rect.Length} and the width is {rect.Width}");
        LearnCSharp.OtherInterestingFeatures();
        // Refer to the Increment method by instantiating the delegate
        // and passing the method itself in as an argument
        IncrementDelegate inc = new IncrementDelegate(Increment);
        Console.WriteLine(inc());  // => 1

        // Delegates can be composed with the + operator
        IncrementDelegate composedInc = inc;
        composedInc += inc;
        composedInc += inc;

        // composedInc will run Increment 3 times
        Console.WriteLine(composedInc());  // => 4


        // Subscribe to the event with the delegate
        MyEvent += new IncrementDelegate(Increment);
        MyEvent += new IncrementDelegate(Increment);

        // Trigger the event
        // ie. run all delegates subscribed to this event
        Console.WriteLine(MyEvent());  // => 6
        string username = "User";
        Console.WriteLine($@"C:\Users\{username}\Desktop");
        PragmaWarning.ObsoleteMethod(); // CS0618: 'ObsoleteMethod is obsolete: Use NewMethod instead'
#pragma warning disable CS0618
        PragmaWarning.ObsoleteMethod(); // CS0618: 'ObsoleteMethod is obsolete: Use NewMethod instead'
#pragma warning restore CS0618
        PragmaWarning.ObsoleteMethod(); // CS0618: 'ObsoleteMethod is obsolete: Use NewMethod instead'
    }
}
