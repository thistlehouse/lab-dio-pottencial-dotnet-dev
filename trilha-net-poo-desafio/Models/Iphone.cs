namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero) : base(numero) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp + " instalado com sucesso.");
        }
    }
}