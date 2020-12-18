using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5_LISTA_1_V2
{
    class Conversor
    {
        #region atributos
        private double milha;
        private double km;
        #endregion
        #region construtor
        public Conversor() 
        {
            milha = 0;
            calcularKm();
        }
        #endregion
        #region set e gets
        public void setMilha(double milha) 
        {
            this.milha = milha;
        }
        public Double getMilha()
        {
            return milha;
        }
        public Double getKm()
        {
            return km;
        }
        #endregion
        #region metodos
        public void calcularKm()
        {
            km= (milha * 1852) / 1000;
        }
        #endregion
    }
}
