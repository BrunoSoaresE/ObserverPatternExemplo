using ObserverPatternExemplo.Interfaces;

namespace ObserverPatternExemplo
{
    public class NovasAgenciasNoticias: IObserver
    {   
        public string NomeAgencia { get; set; }

        public NovasAgenciasNoticias(string NomeAgencia)
        {
            this.NomeAgencia = NomeAgencia;
        }

        public void Atualizar(ISubject subject)
        {
            if (subject is EstacaoMeteorologica estacaoMeteorologica)
            {
                Console.WriteLine(string.Format("\n\r {0} reportando a temperatura {1} graus celsius", NomeAgencia, estacaoMeteorologica.Temperatura));
            }

        }
    }
}
