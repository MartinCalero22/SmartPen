namespace SmartPen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo Boli1 = new Boligrafo("Azul", 5);
            Boligrafo Boli2 = new Boligrafo("Rojo", 15);

            Console.WriteLine("Metodo Mostrar Información");
            Console.WriteLine(Boli1.INFO());
            Console.WriteLine(Boli2.INFO());
            Console.WriteLine("=========================================");
            Console.WriteLine("Metodo Escribir");
            Console.WriteLine(Boli1.Escribir("Entrega super tardía"));
            Console.WriteLine(Boli1.INFO());
            Console.WriteLine("=========================================");
            Console.WriteLine(Boli2.Escribir("Entrega aún más tardía"));
            Console.WriteLine(Boli2.INFO());
            Console.WriteLine("=========================================");
            Console.WriteLine("Metodo Recargar");
            Console.WriteLine(Boli1.RecargarTinta(10));
            Console.WriteLine(Boli1.INFO());
            Console.WriteLine("=========================================");
            Console.WriteLine(Boli2.RecargarTinta(100));
            Console.WriteLine(Boli2.INFO());



        }
    }
}
