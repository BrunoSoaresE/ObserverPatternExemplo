using ObserverPatternExemplo.Interfaces;

namespace ObserverPatternExemplo
{
    internal class EstacaoMeteorologica : ISubject
    {
        private List<IObserver> observers;
       
        private float _temperatura { get; set; }

        public float Temperatura 
        { get { return _temperatura; } 
          set { _temperatura = value; Notificar(); } 
        }

        public EstacaoMeteorologica()
        {
            this.observers = new List<IObserver>();
        }

        public void Anexar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remover(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notificar()
        {
            observers.ForEach(o =>
            {
                o.Atualizar(this);
            });
        }



       
    }
}
