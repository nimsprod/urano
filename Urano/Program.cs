using Urano;
using Urano.Implementations.Crazy;
using Urano.Implementations.Standard;

Console.WriteLine("Hello, World! Here comes number 5");
Console.WriteLine(new UranoStringReader().ReadNumber(5));
Console.WriteLine(new CrazyUranoStringReader().ReadNumber(5));

IStringReader anotherStringReader = new CrazyUranoStringReader();
Console.WriteLine(anotherStringReader.ReadNumber(5));

