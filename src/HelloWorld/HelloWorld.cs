using System;
using System.IO;

namespace HelloWorld;


/// <summary>
/// This class represents a simple Hello World program.
/// </summary>
public class HelloWorld
{
    /// <summary>
    /// Prints "Hello World" to the console.
    /// </summary>
    /// <param name="tw">The text writer to write the output to.</param>
    public void Print(TextWriter tw) => tw.WriteLine("Hello World");
}
