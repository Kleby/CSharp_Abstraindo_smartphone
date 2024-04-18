
using POO_desafio.Models;

Console.WriteLine("Instanciando um Nokia");
Nokia nk1 = new Nokia("11223344", "modelo 1", "111111", 2);
nk1.Ligar();
nk1.ReceberLigacao();
nk1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nInstanciando um Iphone 14");
Iphone ip1 = new Iphone("223311", "Model 14", "445566", 6);
ip1.Ligar();
ip1.ReceberLigacao();
ip1.InstalarAplicativo("Instagram");


