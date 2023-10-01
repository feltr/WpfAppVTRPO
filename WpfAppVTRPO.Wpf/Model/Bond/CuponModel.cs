using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Bond
{
    public class CuponModel : ModelBase
    {
        public override decimal Result
        {
            get
            {
                try
                {
                    return Finance.CalcValueDondCoupon(C, r, n, N);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
