namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public int Memoria {get;set;}
        public string Modelo {get;set;}
        public string IMEI {get;set;}

        public Smartphone(string numero,int memoria, string modelo, string imei)
        {
            Numero = numero;
            Memoria = memoria;
            Modelo = modelo;
            IMEI = imei;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}