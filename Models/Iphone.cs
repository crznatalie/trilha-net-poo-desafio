namespace DesafioPOO.Models
{

    // Implementado!!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Implementado!! 
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine ($"Aplicativo {nomeApp} instalado com sucesso em seu Iphone");
        }
    }
}