// See https://aka.ms/new-console-template for more information
using AllCsharp;

Console.WriteLine("Hello, World!");


//static void Main(string[] args)
//{
MethodOverloading methodOverloading = new MethodOverloading();
methodOverloading.Method();
methodOverloading.Method(5);


Constructor constructor=new Constructor();
constructor.Dispaly();
ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor(10);
parameterizedConstructor.Display();

StaticNonconstructors staticNonconstructors=new StaticNonconstructors();

Console.ReadKey();
//}