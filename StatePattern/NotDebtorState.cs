using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NotDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            //Si el monto que se quiere gastar es menor o igual al saldo que tiene el cliente
            if (amount <= customerContext.Residue)
            {
                //Se le descuenta el monto que gasto
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud permitida, gasta {amount} y le queda saldo de {customerContext.Residue}");
                //Si el saldo que le queda es menor o igual a 0 se cambia el estado del cliente a DebterState
                if (customerContext.Residue <= 0)
                    customerContext.SetState(new DebterState());
            }
            else
            {
                //Si el monto que se quiere gastar es mayor al saldo que tiene el cliente
                Console.WriteLine($"No tiene saldo suficiente, saldo actual {customerContext.Residue}");
            }
        }
    }
}
