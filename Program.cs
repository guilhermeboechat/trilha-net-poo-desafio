using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "1312345", modelo: "Modelo 1",imei: "12345", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero: "871238", modelo: "Modelo 2",imei: "14245", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Linux");
