using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();

Smartphone nokia = new Nokia(numero: "123456", modelo: "NOKIA C20", imei: "1212121212", memoria: 128);
Console.WriteLine($"Smartphone {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Iphone 14", imei: "2323232323", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");