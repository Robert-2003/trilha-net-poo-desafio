using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("(21)12345-6789", "iPhone 14", "1234567FDA", 256);
Nokia nokia = new Nokia("(11)54268-6779", "Tijolão", "41552KMNA", 32);


Console.WriteLine("\nTestando o iPhone:\n");

Console.WriteLine($"Número: {iphone.Numero}\n");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");

Console.WriteLine("\nTestando o Nokia:\n");

Console.WriteLine($"Número: {nokia.Numero}\n");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");