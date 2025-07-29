using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia");
Nokia nokia = new Nokia(numero: "11 11111-1111", modelo: "A35", imei: "1315489642337438738438", memoria: 125);
nokia.Ligar();
nokia.InstalarAplicativo("Zap Zap");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
Iphone iphone = new Iphone(numero: "22 22222-2222", modelo: "21", imei: "3949489642337438738438", memoria: 125);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");