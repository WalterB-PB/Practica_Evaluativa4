using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Evaluativa4
{
    public class PreguntaFacil : Preguntas
    {
        public override int ObtenerPuntaje()
        {
            return 10;
        }

        public override int ObtenerTiempoLimite()
        {
            return 60;
        }
    }
}
