namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero) : base(numero) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp + " inslado com sucesso.");
        }
    }
}