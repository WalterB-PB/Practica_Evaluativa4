﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Evaluativa4
{
    public class Preguntaslistas : Preguntas
    {
        public override int ObtenerPuntaje()
        {
            switch (Nivel)
            {
                case "Fácil":
                    return 10;
                case "Medio":
                    return 20;
                case "Difícil":
                    return 30;
                default:
                    return 0;
            }
        }

        public override int ObtenerTiempoLimite()
        {
            switch (Nivel)
            {
                case "Fácil":
                    return 60;
                case "Medio":
                    return 30;
                case "Difícil":
                    return 15;
                default:
                    return 0;
            }
        }

        public static void CargarTodasLasPreguntas()
        {

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es el planeta más cercano al Sol?",
                Opciones = new List<string> { "Mercurio", "Venus", "Tierra", "Marte" },
                RespuestaCorrecta = "Mercurio",
                Categoria = "Ciencia",
                Nivel = "Fácil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es el planeta más cercano al Sol?",
                Opciones = new List<string> { "Mercurio", "Venus", "Tierra", "Marte" },
                RespuestaCorrecta = "Mercurio",
                Categoria = "Ciencia",
                Nivel = "Fácil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Quién propuso la teoría de la relatividad?",
                Opciones = new List<string> { "Isaac Newton", "Albert Einstein", "Nikola Tesla", "Stephen Hawking" },
                RespuestaCorrecta = "Albert Einstein",
                Categoria = "Ciencia",
                Nivel = "Medio"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es la fórmula química del ozono?",
                Opciones = new List<string> { "O3", "CO2", "H2O", "O2" },
                RespuestaCorrecta = "O3",
                Categoria = "Ciencia",
                Nivel = "Difícil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿En qué año comenzó la Segunda Guerra Mundial?",
                Opciones = new List<string> { "1939", "1945", "1914", "1925" },
                RespuestaCorrecta = "1939",
                Categoria = "Historia",
                Nivel = "Fácil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Quién fue Simón Bolívar?",
                Opciones = new List<string> { "Un conquistador español", "Un libertador sudamericano", "Un emperador inca", "Un rey portugués" },
                RespuestaCorrecta = "Un libertador sudamericano",
                Categoria = "Historia",
                Nivel = "Medio"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué imperio fue liderado por Justiniano I?",
                Opciones = new List<string> { "Imperio Romano", "Imperio Bizantino", "Imperio Otomano", "Imperio Persa" },
                RespuestaCorrecta = "Imperio Bizantino",
                Categoria = "Historia",
                Nivel = "Difícil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuántos continentes hay en el mundo?",
                Opciones = new List<string> { "5", "6", "7", "8" },
                RespuestaCorrecta = "7",
                Categoria = "Cultura General",
                Nivel = "Fácil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué idioma tiene más hablantes nativos en el mundo?",
                Opciones = new List<string> { "Español", "Inglés", "Chino Mandarín", "Árabe" },
                RespuestaCorrecta = "Chino Mandarín",
                Categoria = "Cultura General",
                Nivel = "Medio"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué país tiene la mayor cantidad de premios Nobel de la Paz?",
                Opciones = new List<string> { "Estados Unidos", "Noruega", "Alemania", "Suiza" },
                RespuestaCorrecta = "Estados Unidos",
                Categoria = "Cultura General",
                Nivel = "Difícil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es el estado del agua a temperatura ambiente?",
                Opciones = new List<string> { "Sólido", "Líquido", "Gaseoso", "Plasma" },
                RespuestaCorrecta = "Líquido",
                Categoria = "Ciencia",
                Nivel = "Fácil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué gas respiramos principalmente del aire?",
                Opciones = new List<string> { "Dióxido de carbono", "Hidrógeno", "Oxígeno", "Nitrógeno" },
                RespuestaCorrecta = "Nitrógeno",
                Categoria = "Ciencia",
                Nivel = "Fácil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿En qué año comenzó la Segunda Guerra Mundial?",
                Opciones = new List<string> { "1935", "1939", "1945", "1929" },
                RespuestaCorrecta = "1939",
                Categoria = "Historia",
                Nivel = "Medio"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Quién fue el libertador de gran parte de Sudamérica?",
                Opciones = new List<string> { "Cristóbal Colón", "Simón Bolívar", "Benito Juárez", "José Martí" },
                RespuestaCorrecta = "Simón Bolívar",
                Categoria = "Historia",
                Nivel = "Medio"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es el país más poblado del mundo en 2023?",
                Opciones = new List<string> { "India", "China", "Estados Unidos", "Indonesia" },
                RespuestaCorrecta = "India",
                Categoria = "Cultura General",
                Nivel = "Difícil"
            });

            PreguntaFactory.AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué filósofo escribió 'La República'?",
                Opciones = new List<string> { "Aristóteles", "Platón", "Sócrates", "Descartes" },
                RespuestaCorrecta = "Platón",
                Categoria = "Cultura General",
                Nivel = "Difícil"
            });
        }




        /*  public virtual bool EvaluarRespuesta(string respuesta)
          {
              return respuesta.Trim().Equals(RespuestaCorrecta.Trim(), StringComparison.OrdinalIgnoreCase);
          }
  */

    }
}
