using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Evaluativa4
{
    public static class PreguntaFactory
    {
        private static Dictionary<string, List<Preguntas>> preguntasDisponibles = new Dictionary<string, List<Preguntas>>();

        static PreguntaFactory()
        {
            Inicializar("Ciencia", "Fácil");
            Inicializar("Ciencia", "Medio");
            Inicializar("Ciencia", "Difícil");

            Inicializar("Historia", "Fácil");
            Inicializar("Historia", "Medio");
            Inicializar("Historia", "Difícil");

            Inicializar("Cultura General", "Fácil");
            Inicializar("Cultura General", "Medio");
            Inicializar("Cultura General", "Difícil");

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es el hueso más largo del cuerpo humano?",
                Opciones = new List<string> { "Fémur", "Tibia", "Húmero", "Radio" },
                RespuestaCorrecta = "Fémur",
                Categoria = "Ciencia",
                Nivel = "Fácil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué elemento químico tiene el símbolo 'Au'?",
                Opciones = new List<string> { "Plata", "Oro", "Aluminio", "Argón" },
                RespuestaCorrecta = "Oro",
                Categoria = "Ciencia",
                Nivel = "Fácil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es la velocidad de la luz en el vacío?",
                Opciones = new List<string> { "300,000 km/s", "150,000 km/s", "450,000 km/s", "600,000 km/s" },
                RespuestaCorrecta = "300,000 km/s",
                Categoria = "Ciencia",
                Nivel = "Medio"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué científico descubrió la penicilina?",
                Opciones = new List<string> { "Marie Curie", "Alexander Fleming", "Louis Pasteur", "Gregor Mendel" },
                RespuestaCorrecta = "Alexander Fleming",
                Categoria = "Ciencia",
                Nivel = "Medio"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué partícula subatómica tiene carga positiva?",
                Opciones = new List<string> { "Electrón", "Neutrón", "Protón", "Fotón" },
                RespuestaCorrecta = "Protón",
                Categoria = "Ciencia",
                Nivel = "Difícil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿En qué año cayó el Muro de Berlín?",
                Opciones = new List<string> { "1985", "1989", "1991", "1979" },
                RespuestaCorrecta = "1989",
                Categoria = "Historia",
                Nivel = "Fácil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Quién fue el primer presidente de Estados Unidos?",
                Opciones = new List<string> { "Thomas Jefferson", "Abraham Lincoln", "George Washington", "John Adams" },
                RespuestaCorrecta = "George Washington",
                Categoria = "Historia",
                Nivel = "Fácil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué civilización construyó los Machu Picchu?",
                Opciones = new List<string> { "Aztecas", "Mayas", "Incas", "Olmecas" },
                RespuestaCorrecta = "Incas",
                Categoria = "Historia",
                Nivel = "Medio"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿En qué siglo llegó Colón a América?",
                Opciones = new List<string> { "XV", "XVI", "XIV", "XVII" },
                RespuestaCorrecta = "XV",
                Categoria = "Historia",
                Nivel = "Medio"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué emperador romano dividió el imperio en Oriente y Occidente?",
                Opciones = new List<string> { "Julio César", "Constantino", "Diocleciano", "Trajano" },
                RespuestaCorrecta = "Diocleciano",
                Categoria = "Historia",
                Nivel = "Difícil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es el río más largo del mundo?",
                Opciones = new List<string> { "Nilo", "Amazonas", "Yangtsé", "Misisipi" },
                RespuestaCorrecta = "Amazonas",
                Categoria = "Cultura General",
                Nivel = "Fácil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué artista pintó 'La noche estrellada'?",
                Opciones = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Claude Monet", "Salvador Dalí" },
                RespuestaCorrecta = "Vincent van Gogh",
                Categoria = "Cultura General",
                Nivel = "Fácil"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Cuál es el país con mayor superficie del mundo?",
                Opciones = new List<string> { "China", "Estados Unidos", "Canadá", "Rusia" },
                RespuestaCorrecta = "Rusia",
                Categoria = "Cultura General",
                Nivel = "Medio"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿Qué escritor creó a Harry Potter?",
                Opciones = new List<string> { "J.R.R. Tolkien", "J.K. Rowling", "George R.R. Martin", "Stephen King" },
                RespuestaCorrecta = "J.K. Rowling",
                Categoria = "Cultura General",
                Nivel = "Medio"
            });

            AgregarPregunta(new Preguntaslistas
            {
                Texto = "¿En qué ciudad se encuentra la Torre de Pisa?",
                Opciones = new List<string> { "Roma", "Venecia", "Florencia", "Pisa" },
                RespuestaCorrecta = "Pisa",
                Categoria = "Cultura General",
                Nivel = "Difícil"
            }); ;
        }



        private static void Inicializar(string categoria, string nivel)
        {
            string clave = $"{categoria}-{nivel}";
            if (!preguntasDisponibles.ContainsKey(clave))
            {
                preguntasDisponibles[clave] = new List<Preguntas>();
            }
        }

        public static void AgregarPregunta(Preguntas pregunta)
        {
            string clave = $"{pregunta.Categoria}-{pregunta.Nivel}";
            if (preguntasDisponibles.ContainsKey(clave))
            {
                preguntasDisponibles[clave].Add(pregunta);
            }
        }

        public static Preguntas ObtenerPregunta(string categoria, string nivel)
        {
            string clave = $"{categoria}-{nivel}";
            if (preguntasDisponibles.ContainsKey(clave) && preguntasDisponibles[clave].Count > 0)
            {
                var lista = preguntasDisponibles[clave];
                var random = new Random();
                int indice = random.Next(lista.Count);
                var pregunta = lista[indice];
                lista.RemoveAt(indice);
                return pregunta;
            }
            else
            {
                throw new Exception("No hay preguntas disponibles");
            }


        }

        public static void ReiniciarPreguntas()
        {
            preguntasDisponibles.Clear();

            Inicializar("Ciencia", "Fácil");
            Inicializar("Ciencia", "Medio");
            Inicializar("Ciencia", "Difícil");

            Inicializar("Historia", "Fácil");
            Inicializar("Historia", "Medio");
            Inicializar("Historia", "Difícil");

            Inicializar("Cultura General", "Fácil");
            Inicializar("Cultura General", "Medio");
            Inicializar("Cultura General", "Difícil");

            Preguntaslistas.CargarTodasLasPreguntas();

        }


    }
}

