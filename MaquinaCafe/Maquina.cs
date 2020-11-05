using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    class Maquina
    {
        double  _saldo;

        #region "Propriedades"
        public double Saldo
        {
            get
            {                
                return _saldo;
            }
            set
            {                
                 _saldo = value;
                               
            }
        }

        public double Cappuccino
        {
            get
            {
                return 3.50;                
            }
        }

        public double Mocha
        {
            get
            {
                return 4.00;
            }
        }

        public double Latte
        {
            get
            {
                return 3.00;
            }
        }
        #endregion

        #region "Métodos e funções"
        public double Troco(double _cafe)
        {
            if(_saldo >= _cafe)
            {                
                return this._saldo -= _cafe;
            }
            else
            {
                return 0;
            }            
        }


        public double InsereMoeda( double _valor)
        {            
            return this._saldo += _valor;
        }
        #endregion
    }
}
