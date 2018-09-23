/*
 * SistemaEcuaciones.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Define una clase de Sistema de Ecuaciones
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matemáticas.Tipos;
using Matemáticas.Procesos;

namespace SistemasEcuaciones.Tipos
{
    public class SistemaEcuaciones
    {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        /// <summary>
        /// Arreglo de los coeficientes de las incógnitas, ordenados
        /// por [número de ecuación, número de coeficiente]
        /// </summary>
        public Matriz<Fracción> Coeficientes { set; get; }

        /// <summary>
        /// Arreglo de los términos independientes de la ecuación,
        /// ordenados por [número de ecuación, 0]
        /// </summary>
        public Matriz<Fracción> Independientes { set; get; }


        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Constructores
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

            /// <summary>
            /// Crea un sistema de ecuaciones con n incógnitas y n ecuaciones
            /// </summary>
            /// <param name="nIncógnitas">Número de incógnitas</param>
        public SistemaEcuaciones(int nIncógnitas)
        {
            Coeficientes = new Matriz<Fracción>(nIncógnitas, nIncógnitas);
            Independientes = new Matriz<Fracción>(nIncógnitas, 1);

        }

    }
}
