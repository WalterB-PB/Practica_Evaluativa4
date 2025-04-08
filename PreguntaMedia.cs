using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Evaluativa4
{
    public class PreguntaMedia : Preguntas
    {
        public override int ObtenerPuntaje()
        {
            return 20;


        }

        public override int ObtenerTiempoLimite()
        {
            return 30;
        }
    }
}
