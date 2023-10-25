// See https://aka.ms/new-console-template for more information
using DesignPatternSingleton;

Console.WriteLine("Hello, World!");


Singleton employe = Singleton.getInstance;
employe.PrintMessage("test singleton 1");
Singleton student = Singleton.getInstance;
student.PrintMessage("test singleton 2");

Console.ReadLine();