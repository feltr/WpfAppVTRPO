using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Precent
{
    public class HardPrecentModel : ModelBase
    {
        public override decimal Result 
        {
            get 
            {
                try
                {
                    return Finance.CalcInvestmentHard(PV, r, n);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
