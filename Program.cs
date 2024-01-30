using SistemaParaAbstracaoDeCelular.Models;

// Nokia nokia = new Nokia("123456789", "Nokia 9", "001970-01-010000-0", 1);
// Iphone iphone = new Iphone("987654321", "iPhone 12", "001970-01-010000-1", 4);

Nokia nokia = new Nokia();
Iphone iphone = new Iphone();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");