using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Precent
{
    public class СontinuousPrecentModel : ModelBase
    {
        public override decimal Result
        {
            get
            {
                try
                {
                    return Finance.CalcInvestmentСontinuous(PV, r, t);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
