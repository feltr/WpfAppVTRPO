using FastReport.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Precent
{
    public class OneYersModel : ModelBase
    {
        public override decimal Result
        {
            get 
            {
                try
                {
                    return Finance.CalcInvestment(PV, r);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
