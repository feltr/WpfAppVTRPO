using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Bond
{
    public class MacaulayDurationEffectivModel : ModelBase
    {
        public override decimal Result
        { 
            get 
            {
                try
                {
                    return Finance.CalcMacaulayDurationEffectiv(P, C, y, n, M, UpP, DownP, UpI, DownI);
                }
                catch
                {
                    return 0;
                }
            } 
        }
    }
}
