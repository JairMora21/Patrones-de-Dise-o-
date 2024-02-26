using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class CustomerContext
    {
        //Esta es la clase que se encarga de manejar el estado del cliente
        private IState _state;

        private decimal _risidue;

        //Esto es el saldo que tiene el cliente
        public decimal Residue {
            get => _risidue;
            set => _risidue = value;
        }
        //Cuando se crea la instancia de la clase se inicializa en el estado NewState
        public CustomerContext()
        {
            _state = new NewState();
        }
        //Se encarga de cambiar el estado del cliente
        public void SetState(IState state) => _state = state;
        public IState GetState() => _state;
        //This hace referencia a que se enviara la misma instancia de la clase y realiza la accion que se le indique
        public void Request(decimal amount) => _state.Action(this, amount);
        public void Discount(decimal discount) => _risidue -= discount;

    }
}
