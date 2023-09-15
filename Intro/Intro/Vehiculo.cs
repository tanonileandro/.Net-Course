using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    // namespaace => sirve para organizar y diferenciar las clases, se puede tener clases del mismo nombre pero en espacios diferentes, ver ejemplo TestClase
    class Vehiculo
    {
        /*
          Modificadores de acceso:
            public - no tiene restricciones de acceso
            private - solo son accesibles desde la clase en la que se generan
            internal - acceso solo desde el mismo proyecto
            protected - solo accesible desde la clase ue se genera y sus clases derivadas
         */

        // Propiedades => 1-modificador de acceso 2-tipo de dato que es 3- nombre de la propiedad 4- get y set para darle valor
        public decimal VelocidadMaxima { get; set; }
        public decimal ConsumoPorKilometro { get; set; }

        // Metodos => son bloques de codigo que realizan acciones, el mas comun en todas las clases es el constructor, se llama igual que la clase y se le da los valores de las propiedades
        public Vehiculo(decimal velocidadMaxima, decimal consumoPorKilometro)
        {
            VelocidadMaxima = velocidadMaxima;
            ConsumoPorKilometro = consumoPorKilometro;
        }

        // El comentario siguiente es mas completo y nos indica que es lo que hace una funcion

        /// <summary>
        /// Calcula el consumo total de kilometros
        /// </summary>
        /// <param name="kilometrosTotales">Distancia recorrida en km</param>
        /// <returns>Consumo total de litros de gasolina</returns>
        public decimal ConsumoTotal(decimal kilometrosTotales)
        {
            return ConsumoPorKilometro * kilometrosTotales;
        }

    }
}
