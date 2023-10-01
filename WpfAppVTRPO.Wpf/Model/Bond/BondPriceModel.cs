using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Bond
{
    public class BondPriceModel : ModelBase
    {
        public override decimal Result
        {
            get 
            {
                try
                {
                    return Finance.CalcBondPrice(GCO, NCD);
                }
                catch 
                {
                    return 0;
                }
            }
        }
    }
}
