using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Alarma.Interfaces
{
    public interface IEstadoAlarma
    {
        void ActivarAlarma(Alarma _alarma);

        void DesactivarAlarma(Alarma _alarma);
    }
}
