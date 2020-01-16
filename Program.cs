using State.Alarma;
using State.Alarma.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        public static Alarma.Alarma entAlarma;
        static void Main(string[] args)
        {
            IEstadoAlarma InicialState = new AlarmaActivada();
            entAlarma = new Alarma.Alarma(InicialState);

            ActivarDesactivarAlarma();
        }

        private static void ActivarDesactivarAlarma()
        {
            Console.WriteLine("Selecciona una opcion:\n1.- Activar Alarma\n2.- Desactivar Alarma\n3.- Salir");
            string cOpc = Console.ReadLine();

            RealizarAccion(cOpc);
        }

        private static void RealizarAccion(string cOpc)
        {
            bool lSalir = false;
            switch (cOpc)
            {
                case "1":
                    entAlarma.ActivarAlarma();
                    break;
                case "2":
                    entAlarma.DesactivarAlarma();
                    break;
                case "3":
                    lSalir = true;
                    break;
                default:
                    ActivarDesactivarAlarma();
                    break;
            }

            if (!lSalir)
            {
                ActivarDesactivarAlarma();
            }
        }
    }
}
