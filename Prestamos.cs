using System;
class Prestamos
{
        #region Variables
        double dinero, 
        Interes_pagado, 
        Capital_pagado, 
        Monto_del_prestamo, 
        interes_anual, 
        interes_mensual ;
    
        
        public int tabla, plazo, i;
        #endregion
        public void entrada_datos ()
        {
            Console.WriteLine("CALCULADORA DE PRÉSTAMOS");
            Console.WriteLine("Bienvenidos al Simulador de Préstamos de Consumo de la Superintendencia de Bancos de la República Dominicana.");
            Console.WriteLine("");
            Console.Write("Monto del préstamo en RD$ : ");
            double.TryParse(Console.ReadLine(), out Monto_del_prestamo);
            Console.Write("Tasa de Porcentaje Anual %: ");
            double.TryParse(Console.ReadLine(), out interes_anual);
            Console.Write("Plazo De Meses            : ");
            int.TryParse(Console.ReadLine(), out plazo);
        }   
        public void interes ()
        {
          //Tasa Mensual    //Tasa Anual  
          interes_mensual = (interes_anual / 100) / 12;
        }
        public void cuota_mensual ()
        {
            dinero = interes_mensual + 1;
            dinero = (float)Math.Pow(dinero, plazo);
            dinero = dinero - 1;
        }    
        public void carculo_interes ()
        {
            dinero = interes_mensual / dinero;
            dinero = interes_mensual + dinero;
            dinero = Monto_del_prestamo * dinero;
        }    
        public void salida ()
        {
            Console.WriteLine();
            tabla = 1;
            Console.WriteLine("  _____________________________________\n" +
            $"\n |1 Monto del prestamo en RD$: {Monto_del_prestamo}"  +
            $"\n |2 Tasa de Porcentaje Anual : %{interes_anual}" +
            $"\n |3 Plazo                    : {plazo} Meses"  +
            $"\n |4 Valor De Cuota           : RD$ {dinero.ToString("0.00")}" +
            "\n  _____________________________________");

            Console.WriteLine();
           
            Console.Write("\tPago \t");
            Console.Write("Cuota \t");
            Console.Write("Interes"); 
            Console.Write("\t\tCapital");
            Console.Write("\t\tBalance");
            
            
           

            Console.WriteLine();
            Console.WriteLine();
            
do
{          
                Console.Write("\t{0}\t", tabla);

               
                Console.Write("{0}\t",dinero.ToString("0.00"));
                /*---------------------------------------------------------------------------------------------------*/
                //EL Interes va Igual a la Tasa_Mensual x Monto del Prestamo
                Interes_pagado = interes_mensual * Monto_del_prestamo;
                Console.Write("{0}\t",Interes_pagado.ToString("0.00"));
                /*---------------------------------------------------------------------------------------------------*/
                //EL Capital va hacer igual a Dinero Pagado - EL Interes_Pagado
                Capital_pagado = dinero - Interes_pagado;
                Console.Write("\t{0}\t",Capital_pagado.ToString("0.00"));
                //Ojo :Otra Forma de Tener el mismo resultado : Console.Write("\t{0}\t",Math.Round(Capital_pagado));
                /*---------------------------------------------------------------------------------------------------*/
                //Monto va hacer igual a Monto del Prestamo - El Capital Pagado
                Monto_del_prestamo = Monto_del_prestamo - Capital_pagado;
                /*---------------------------------------------------------------------------------------------------*/
                //If para que siempre Quede en 0
               if (tabla == plazo || Monto_del_prestamo<0)
               {
                    Console.Write("\t{0}\t",(Monto_del_prestamo=0));
               }
               else
               {
                    Console.Write("\t{0}\t",Monto_del_prestamo.ToString("0.00"));
               }
                /*---------------------------------------------------------------------------------------------------*/

                tabla = tabla + 1;
                Console.WriteLine();


                i++;
                } while (i < plazo);

          

        }
    
}