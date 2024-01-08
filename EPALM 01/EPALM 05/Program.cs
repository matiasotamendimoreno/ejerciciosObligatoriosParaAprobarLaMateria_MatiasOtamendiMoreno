using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_05
{
    internal class Program
    {
        static void EntregarCosas(Random random, Serie[] serie, Videojuego[] videojuegos)
        {
            for (int i = 0; i > serie.Length; i++)
            {
                if (random.Next(0, 2) == 1)
                {
                    serie[i].entregar();
                }
                if (random.Next(0, 2) == 1)
                {
                    videojuegos[i].entregar();
                }
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Serie[] series = new Serie[5];
                Videojuego[] videojuegos = new Videojuego[5];
                Random random = new Random();

                series[0] = new Serie("Dios", "Floppa");
                series[1] = new Serie("El Diablo anda Suelto", "Bingus");
                series[2] = new Serie("Quien fue Obama?", "Obama");
                series[3] = new Serie("White", 4, "Terror", "HPLovecraft");
                series[4] = new Serie("Black", 2, "Super Heroes", "Julio Cesar");

                videojuegos[0] = new Videojuego("Shreck", 10);
                videojuegos[1] = new Videojuego("Ultra Knight", 8);
                videojuegos[2] = new Videojuego("Ultra Knight 2", 2);
                videojuegos[3] = new Videojuego("Adios", 4, "Suspenso", "Hola Studios");
                videojuegos[4] = new Videojuego("Hello", 6, "Accion", "Goodby Estudios");

                Serie masTempordas = series[0];
                Videojuego masHoras = videojuegos[0];

                EntregarCosas(random, series, videojuegos);

                for(int i = 0; i < series.Count(); i++)
                {
                    if (series[i].NTemporadas > masTempordas.NTemporadas)
                    {
                        masTempordas = series[i];
                    }
                    if (videojuegos[i].HorasEstimadas > masHoras.HorasEstimadas)
                    {
                        masHoras = videojuegos[i];
                    }
                }

                Console.WriteLine($"| Cantidad de series entregadas: {series.Count(ser => ser.isEntregado())}");
                Console.WriteLine($"| Cantidad de videojuegos entregados: {series.Count(vid => vid.isEntregado())}");

                Console.WriteLine($"| Serie con más temporadas: {masTempordas.Titulo} \n| Videojuego con más horas: {masHoras.Titulo}");

                Console.ReadKey();
            }
        }
    }
}
