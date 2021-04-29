using System;

namespace Proyecto_Final
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
        #region metodo
        Prestamos resultado = new Prestamos();
        #endregion
        #region resultado
        resultado.entrada_datos();
        resultado.interes();
        resultado.cuota_mensual();
        resultado.carculo_interes();
        resultado.salida();
        #endregion
        }
    }
}

