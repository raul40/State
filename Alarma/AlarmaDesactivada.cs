using State.Alarma.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Alarma
{
    public class AlarmaDesactivada : IEstadoAlarma
    {
        private Alarma contextAlarma;

        public void ActivarAlarma(Alarma _alarma)
        {
            contextAlarma = _alarma;
            Console.WriteLine("La Alarma se Activo");
            setAlarma(new AlarmaActivada());
        }

        public void DesactivarAlarma(Alarma _alarma)
        {
            contextAlarma = _alarma;
            Console.WriteLine("La Alarma se encuentra desactivada actualmente");
        }

        public void setAlarma(IEstadoAlarma newState)
        {
            contextAlarma.CambiarEstado(newState);
        }
    }
}
