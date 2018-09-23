/*
 * Ecuaciones.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Resuelve un sistema de ecuaciones por método de matriz inversa
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matemáticas.Tipos;
using Matemáticas.Procesos;
using SistemasEcuaciones.Tipos;

namespace SistemasEcuaciones.Procesos
{
    public static class Ecuaciones
    {
        /// <summary>
        /// Resuelve el sistema de ecuaciones proporcionado por método de matriz inversa.
        /// </summary>
        /// <param name="ecuaciones">Sistema de ecuaciones a resolver</param>
        /// <returns>Una matriz de n x 1 con los valores de las incógnitas</returns>
         public static Matriz<Fracción> Resolver (SistemaEcuaciones ecuaciones)
        {
            return new Matriz<Fracción>(ecuaciones.Independientes / ecuaciones.Coeficientes);
        }
    }
}
