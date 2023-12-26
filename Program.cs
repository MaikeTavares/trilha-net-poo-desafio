using DesafioPOO.Models;


Console.WriteLine("Teste do nokia");
Smartphone nokia = new Nokia(numero: "95672-2222", modelo: "NokiaL4", imei: "000000000", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Android");


Console.WriteLine("\n");


Console.WriteLine("Teste do Iphone");
Smartphone iphone = new Iphone(numero: "94567-2222", modelo: "14 Pro Max", imei: "111111111", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("IOS");

