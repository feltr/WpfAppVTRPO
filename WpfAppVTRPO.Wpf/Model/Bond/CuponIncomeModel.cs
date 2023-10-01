using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Bond
{
    public class CuponIncomeModel : ModelBase
    {
        public override decimal Result 
        {
            get 
            {
                try
                {
                    return Finance.CalcAccumulatedCouponIncome(N, r, (Do - Dn).TotalDays, n);
                }
                catch
                {
                    return 0;
                }
            } 
        }
    }
}
