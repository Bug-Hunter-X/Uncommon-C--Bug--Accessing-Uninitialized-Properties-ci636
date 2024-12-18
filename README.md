# Uninitialized Property Access in C#

This example highlights a potential issue in C# where accessing a property before it's been explicitly assigned a value can lead to unexpected behavior. The program shows the danger of not initializing class members before using them.

## Bug Description
The bug lies in the `MyMethod` function of `ExampleClass`. The `MyProperty` is accessed before it's assigned a value, which is undefined behavior.  The result will vary depending on the property type and the context in which the class is used. For instance, a `int` will likely return 0, whereas a `string` will return `null`.