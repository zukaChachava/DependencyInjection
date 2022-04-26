using MyDependencyInjection.CApp;
using MyDependencyInjection.DI;

Console.WriteLine("Singleton- - -");

MyDI myDi = new MyDI();

myDi.AddSingleton<TestService>();

var service = myDi.GetService<TestService>();
Console.WriteLine(service.GetGuid.ToString());

var sameService = myDi.GetService<TestService>();
Console.WriteLine(sameService.GetGuid.ToString());

// --------------------------------------------------------

Console.WriteLine("Transient- - -");

MyDI myDiTwo = new MyDI();
myDiTwo.AddTransient(typeof(TestService));

var serviceTwo = myDiTwo.GetService<TestService>();
Console.WriteLine(serviceTwo.GetGuid.ToString());

var sameServiceTwo = myDiTwo.GetService<TestService>();
Console.WriteLine(sameServiceTwo.GetGuid.ToString());