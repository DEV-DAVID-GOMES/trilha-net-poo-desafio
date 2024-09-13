using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone nokia");
Console.WriteLine("");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Smartphone iphone");
Console.WriteLine("");
Iphone iphone = new Iphone(numero: "987654", modelo: "iPhone 13",  imei: "987654321", memoria: 128);
nokia.ReceberLigacao();
iphone.InstalarAplicativo("facebook");
Console.WriteLine("-------------------------------------------");

