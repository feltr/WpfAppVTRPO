using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Bond
{
    public class MacaulayDurationModel : ModelBase
    {
        public override decimal Result
        {
            get
            {
                try
                {
                    return Finance.CalcMacaulayDurationModificir(P, C, y, n, M);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
