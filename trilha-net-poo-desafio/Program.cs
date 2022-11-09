using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789");
Iphone iphone = new Iphone("987654321");

Console.WriteLine("Númbero nokia: " + nokia.Numero);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Cronomoter");

Console.WriteLine("Número iphone: " + iphone.Numero);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("MyFitnessPal");


