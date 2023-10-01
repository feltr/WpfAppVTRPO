using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace VTRPO.Wpf.Model
{
    public class ModelBase : ICloneable
    {
        public bool IsConvert {  get; set; }
        public virtual decimal Result { get; }
        public virtual double GCO { get; set; }
        public virtual double NCD { get; set; }
        public virtual double N { get; set; }
        public virtual double r { get; set; }
        public virtual DateTime Dn { get; set; }
        public virtual DateTime Do { get; set; }
        public virtual int n { get; set; }
        public virtual double C { get; set; }
        public virtual double P { get; set; }
        public virtual double M { get; set; }
        public virtual double y { get; set; }
        public virtual double UpP { get; set; }
        public virtual double DownP { get; set; }
        public virtual double UpI { get; set; }
        public virtual double DownI { get; set; }
        public virtual double S { get; set; }
        public virtual double rf { get; set; }
        public virtual double Time { get; set; }
        public virtual double dayV { get; set; }
        public virtual double Z { get; set; }
        public virtual double PV { get; set; }
        public virtual double t { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
