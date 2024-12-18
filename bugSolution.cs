public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty with a default value

    public void MyMethod()
    {
        // Now MyProperty is initialized before being accessed.
        Console.WriteLine(MyProperty); 
    }

    // Alternative Solution: Initialize in the constructor.
    public ExampleClass() { MyProperty = 0; }
} 