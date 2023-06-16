// See https://aka.ms/new-console-template for more information
using RestSharp;
using EGIO_DOTNET.API.seibro.bond;
using System.Xml;
using EGIO_DOTNET.Controller;
using EGIO_DOTNET.DB;
using EGIO_DOTNET.Controller.bond;

using System.Data;
using YamlDotNet.RepresentationModel;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

//Controller controller = new();
//controller.Fn_Contol();


GetBondController getBondController = new();
getBondController.Fn_Contol();


//mysql mysql = new();
//Console.WriteLine(mysql.selectTest());

Console.ReadLine();


