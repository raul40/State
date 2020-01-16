using State.Alarma.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Alarma
{
    public class Alarma
    {
        private IEstadoAlarma state;

        public Alarma(IEstadoAlarma state)
        {
            this.state = state;

        }

        public void CambiarEstado(IEstadoAlarma newState)
        {
            this.state = newState;
        }

        public void ActivarAlarma()
        {
            this.state.ActivarAlarma(this);
        }

        public void DesactivarAlarma()
        {
            this.state.DesactivarAlarma(this);
        }
    }
}
