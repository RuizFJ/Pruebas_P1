using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjPromedio_Prueba
{
    internal class ClCalificacion
    {
        public int[] notas { set; get; } = new int[3];

        public string nombre { set; get; }

        public int ObtenerPromedio()
        {
            int promedio = 0;
            int suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            promedio = suma / 3;

            return promedio;
        }
    }
}
