namespace ObserverPatternExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            EstacaoMeteorologica estacaoMeteorologica = new EstacaoMeteorologica();
            NovasAgenciasNoticias agenciasNoticiasBH = new NovasAgenciasNoticias("Canal GLOBO BH");
            estacaoMeteorologica.Anexar(agenciasNoticiasBH);

            NovasAgenciasNoticias agenciasNoticiasSP = new NovasAgenciasNoticias("Canal SBT BH");
            estacaoMeteorologica.Anexar(agenciasNoticiasSP);



            estacaoMeteorologica.Temperatura = 31.5f;
            estacaoMeteorologica.Temperatura = 25f;
            estacaoMeteorologica.Temperatura = 27.4f;
            estacaoMeteorologica.Temperatura = 34.4f;



            estacaoMeteorologica.Remover(agenciasNoticiasSP);
            Console.WriteLine("\n\r \n\r ------- Removendo SP ---------- \n\r \n\r");

            estacaoMeteorologica.Temperatura = 22.7f;
            estacaoMeteorologica.Temperatura = 15.9f;

            Console.ReadLine();
        }
    }
}
