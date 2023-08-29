// See https://aka.ms/new-console-template for more information
using DIP;

Console.WriteLine("Hello, World!");

BusinessLogic obj = new BusinessLogic(new DataAccess());
obj.EditDetails();
obj.SaveDetails();

Console.Read();
