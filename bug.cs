public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it is initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); // Accessing MyProperty before assignment
    }
}