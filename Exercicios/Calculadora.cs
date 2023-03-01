﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDllCalculadora
{
    public class Calculadora
    {
        #region [propriedades publicas -> encapsulamento]
        private double N1 { get; set; }//propriedade
        #endregion

        #region [atributos da classe -> de regra devem ser privados]
        private double N2; //atributo
        #endregion  

        #region [Getters e Setters -> encapsulamento ]
        public void SetN2 (double n2)
        {
            this.N2 = n2
        }
        public double GetN2()
        {
            return this.N2;
        }
        #endregion

        #region [METODOS PUBLICOS DA CLASSE]
        public double Somar(double n1,double n2)
        {
            double Adicao = 0;
            this.N1 = n1;this.N2 = n2;
            Adicao= this.N1 + this.N2;  
            return Adicao;  
        }
        #endregion
    }
}
