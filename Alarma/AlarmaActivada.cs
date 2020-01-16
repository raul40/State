using State.Alarma.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Alarma
{
    public class AlarmaActivada : IEstadoAlarma
    {
        private Alarma contextAlarma;

        public void ActivarAlarma(Alarma _alarma)
        {
            contextAlarma = _alarma;
            Console.WriteLine("La Alarma se encuentra Activa actualmente");
        }

        public void DesactivarAlarma(Alarma _alarma)
        {
            contextAlarma = _alarma;
            Console.WriteLine("La Alarma se desactivo");
            setAlarma(new AlarmaDesactivada());
        }

        public void setAlarma(IEstadoAlarma newState)
        {
            contextAlarma.CambiarEstado(newState);
        }
    }
}
