namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, int memoria, string modelo, string imei) : base(numero, memoria, modelo, imei)
        {
        }



        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}