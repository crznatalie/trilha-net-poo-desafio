using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Smartphone nokiaG21 = new Nokia(numero: "97322-2619", modelo: "G21", imei: "111111111111111", memoria: 128);
Smartphone nokiaC21Plus = new Nokia(numero: "98515-9568", modelo: "C21 Plua", imei: "222222222222222", memoria: 64);

Console.WriteLine("------------------------");
Console.WriteLine("Smartphone Nokia G21: ");
Console.WriteLine($"Número: {nokiaG21.Numero}");
nokiaG21.Ligar();
nokiaG21.InstalarAplicativo("Instagram");
nokiaG21.InstalarAplicativo("WhatsApp");
nokiaG21.InstalarAplicativo("Facebook");
nokiaG21.ReceberLigacao();
Console.WriteLine("------------------------");
Console.WriteLine();

Console.WriteLine("------------------------");
Console.WriteLine("Smartphone Nokia C21 Plus: ");
Console.WriteLine($"Número: {nokiaC21Plus.Numero}");
nokiaC21Plus.Ligar();
nokiaC21Plus.InstalarAplicativo("Cytus II");
nokiaG21.InstalarAplicativo("Cats&Soup");
nokiaG21.InstalarAplicativo("Genshin Impact");
nokiaG21.ReceberLigacao();
Console.WriteLine("------------------------");
Console.WriteLine();

Smartphone iphone15Pro = new Iphone(numero: "98256-4647", modelo: "15 Pro", imei: "333333333333333", memoria: 512);
Smartphone iphone12 = new Iphone(numero: "97353-8851", modelo: "12", imei: "333333333333333", memoria: 256);

Console.WriteLine("------------------------");
Console.WriteLine("Smartphone iPhone 15 Pro: ");
Console.WriteLine($"Número: {iphone15Pro.Numero}");
iphone15Pro.Ligar();
iphone15Pro.ReceberLigacao();
iphone15Pro.InstalarAplicativo("Pinterest");
iphone15Pro.InstalarAplicativo("VSCO");
iphone15Pro.InstalarAplicativo("Phonto");
Console.WriteLine("------------------------");
Console.WriteLine();

Console.WriteLine("------------------------");
Console.WriteLine("Smartphone iPhone 12: ");
Console.WriteLine($"Número: {iphone12.Numero}");
iphone12.Ligar();
iphone12.InstalarAplicativo("X");
iphone12.InstalarAplicativo("Tumblr");
iphone12.InstalarAplicativo("Duolingo");
iphone12.ReceberLigacao();
Console.WriteLine("------------------------");
Console.WriteLine();