using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviokompanijaL.Zadatak2
{
    public interface IPosilljka
    {
        bool MoguceRealizovati(string jmbg, double distanca, int klasa);
    }
}
