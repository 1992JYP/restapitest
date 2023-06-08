// See https://aka.ms/new-console-template for more information
using RestSharp;
using EGIO_DOTNET.API.seibro.bond;
using System.Xml;
using EGIO_DOTNET.Controller;
using EGIO_DOTNET.DB;

Controller controller = new();
controller.Fn_Contol();




mysql mysql = new mysql();
Console.WriteLine(mysql.selectTest());

Console.ReadLine();