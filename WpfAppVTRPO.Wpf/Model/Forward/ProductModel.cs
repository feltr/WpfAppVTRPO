using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Library;

namespace VTRPO.Wpf.Model.Forward
{
    public class ProductModel : ModelBase
    {
        public override decimal Result 
        {
            get 
            {
                try
                {
                    return Finance.CalcForwardProduct(S, r, Time, dayV, Z);
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
