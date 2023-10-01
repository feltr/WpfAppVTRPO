using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Forward
{
    public class CurrenciesModel : ModelBase
    {
        public override decimal Result 
        {
            get 
            {
                try
                {
                    return Finance.CalcForwardСurrencies(S, r, rf, Time, dayV);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
