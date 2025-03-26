using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class ArtigoCollection : Collection<Artigo>
    {
        public int TotalRegistos()
        {
            int total = (from element in this
                         select element).Count();

            return total;
        }
    }
}
