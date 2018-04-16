using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace widerstandsrechner
{
    class Rechner
    {
        int[] array;
        Boolean form; //True->Seriel - False->Parallel
        
        public void setArray(int[] array2)
        {
           
            this.array = array2;

        }


        public void setForm(Boolean form)
        {

            this.form = form;
        
        
        }

        public double getSeriel(int[] array)
        {
            double erg=0;

            for (int i = 0; i < array.Length; i++)
            {
                erg=erg+array[i];

            }

            
            return (erg);
        } 

        public double getParallel(int[] array)
        {
            double erg = 0;
            double erg2 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                erg =erg+ (1 / i);
            }

            erg2 = Math.Pow(erg, -1);

            return (erg2);
        }

        public Rechner(int[] array2)
        {
            this.array = array2;
        
        }
        
       


    }
}
