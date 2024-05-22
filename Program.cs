using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "1235", modelo: "Motototo", imei: "234545", memoria: 435);
nokia.Ligar();
nokia.InstalarAplicativo("Nagazap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "453453", modelo: "Moto2434234toto", imei: "234543534534545", memoria: 435);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Insta");


