using static System.Net.WebRequestMethods;

namespace VTRPO.Library
{
    static public class Finance
    {
        //Расчет будущей стоимости вложений при начислении простого процента.

        //при вкладе на 1 год;
        static public decimal CalcInvestment(double PV, double r) 
        {
            if (PV < 0 || r < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate(PV * (r + 1) * 100) / 100;
        }
        //при вкладе более чем на 1 год;
        static public decimal CalcInvestment(double PV, double r, double n)
        {
            if (PV < 0 || r < 0 || n < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate(PV * (r * n + 1) * 100) / 100;
        }
        //при вкладе не кратном одному году  
        static public decimal CalcInvestment(double PV, double r , double n, int dayV)
        {
            if (PV < 0 || r < 0 || n < 0 || dayV < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate(PV * ((n / dayV) * r + 1) * 100) / 100;
        }
        static public decimal CalcInvestmentHard(double PV, double r, double n)
        {
            if (PV < 0 || r < 0 || n < 0 )
                throw new Exception("Negative value");
            return (decimal)Math.Truncate(PV * Math.Pow((r + 1), n) * 100) / 100;
        }

        //Расчет будущей стоимости вложений при начислении непрерывного процента.
        static public decimal CalcInvestmentСontinuous(double PV, double r, double t)
        {
            if (PV < 0 || r < 0 || t < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate((PV * Math.Pow(Math.E, r * t)) * 100) / 100;
        }
        /* Где:

             результат – будущая стоимость вложения;
             PV – текущая стоимость вложения;    
             r - ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы;
             T – период начисления в годах;
             e – 2.71
        */

        //РАСЧЕТ ФОРВАРДНОЙ ЦЕНЫ ВАЛЮТЫ, ТОВАРА
        //Расчет валюты
        static public decimal CalcForwardСurrencies(double S, double r, double rf , double T, double dayV)
        {
            if (S < 0 || r < 0 || rf < 0 || T < 0 || dayV < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate(S * ((1 + r * (T / dayV)) / (1 + rf * (T / dayV))) * 100) / 100;
        }


        /*Где, для валюты:

            результат – форвардная цена валюты;
            S – цена спот валюты;
            r- ставка без риска, той валюты которая бы конвертировалась;
            rf - ставка без риска, той валюты по которой определяем форвардную цену;
            T – период времени до истечения контракта;
        */
        //Расчет товара
        static public decimal CalcForwardProduct(double S, double r, double T, double dayV, double Z)
        {
            if (S < 0 || r < 0 || T < 0 || dayV < 0 || Z < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate((S * (1 + r * (T / dayV)) + Z) * 100) / 100;
        }
        /*Где, для валюты:

            F – форвардная цена валюты;
            S – цена спот валюты;
            r- ставка без риска, той валюты которая бы конвертировалась;
            rf - ставка без риска, той валюты по которой определяем форвардную цену;    
            T – период времени до истечения контракта;
            Z - расходы по хранения и страхованию за период T;
        */
        //РАСЧЕТ ЦЕНЫ ОБЛИГАЦИИ И ЕЕ ПАРАМЕТРОВ.

        //текущая стоимость облигации, купонной
        static public decimal CalcValueDondCoupon(double C, double r, double n, double N)
        {
            if (C < 0 || r < 0 || n < 0 || N < 0)
                throw new Exception("Negative value");
            double PV = 0;
            for (int i = 1; i <= n; i++)
            {
                PV += C / Math.Pow((1 + r), i);
            }
            return (decimal)Math.Truncate((PV + (N / Math.Pow(1 + r, n))) * 100) / 100;
        }
        //текущая стоимость облигации, дисконтной;
        static public decimal CalcValueDondDiscount(double N, double r, double n)
        {
            if (r < 0 || n < 0 || N < 0)
                throw new Exception("Negative value");
            decimal PV = 0;
            PV = (decimal)(N / Math.Pow(1 + r, n));
            return Math.Truncate(PV * 100) / 100;
        }
        //чистая цена облигации;
        static public decimal CalcBondPrice(double GCO, double NCD)
        {
            if (NCD < 0 || GCO < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate((GCO - NCD) * 100) / 100;
        }
        //накопленный купонный доход;
        static public decimal CalcAccumulatedCouponIncome(double N, double r, double dDn, double n)
        {
            if (r < 0 || n < 0 || N < 0 || dDn < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate((N * r * (dDn) / Math.Pow(1 + r, n)) * 100) / 100;
        }
        //Формула дюрации Маколея:
        static public decimal CalcMacaulayDuration(double P, double C, double y, int n, double M) 
        {
            if(P < 0 || C < 0 || y < 0 || n < 0 || M < 0)
                throw new Exception("Negative value");
            decimal D = 0;
            for (int i = 1; i <= n; i++)
            {
                D += (decimal)((i * C) / Math.Pow(1 + y, i));
            }
            D += (decimal)(((n * M) / Math.Pow(1 + y, n))/P);
            return Math.Truncate(D * 100) / 100;
        }
        /* D — дюрация Маколея; 
         * P — текущая цена облигации; 
         * t — период обращения бумаги; 
         * C — размер купонной выплаты; 
         * y — доходность облигации; 
         * n — общее число купонов; 
         * M — номинал облигации.*/
        //модифицированная дюрация
        static public decimal CalcMacaulayDurationModificir(double P, double C, double y, int n, double M) 
        {
            if (P < 0 || C < 0 || y < 0 || n < 0 || M < 0)
                throw new Exception("Negative value");
            return (decimal)Math.Truncate((double)CalcMacaulayDuration(P, C, y, n, M) / (1 + y / n) * 100) / 100;
        }

        //эффективная дюрация
        static public decimal CalcMacaulayDurationEffectiv(double P, double C, double y, int n, double M, double UpP, double DownP, double UpI, double DownI) 
        {
            if (P < 0 || C < 0 || y < 0 || n < 0 || M < 0 || UpP < 0 || DownP < 0 || UpI < 0 || DownI < 0)
                throw new Exception("Negative value");

            double De = (double)CalcMacaulayDurationModificir(P, C, y, n, M);

            return (decimal)Math.Truncate((P - (De * P * (DownP + 1)) - (P - De * P * (UpP + 1))) / (P * (UpI * 100 - DownI * 100)) * 100) / 100;
        }

        /*De — эффективная дюрация; 
         * Pi− — рыночная цена в случае понижения процентных ставок; 
         * Pi+ — рыночная цена в случае повышения процентных ставок; 
         * Po — исходная цена; 
         * i+ — размер повышенной ставки; 
         * i− — размер пониженной ставки.*/


        //дюрация Маколея (при выплате купона один раз в год) - показывает, когда в среднем будут получены
        //платежи по облигации, включая купоны и номинал, измеряется в годах;
        /*static public decimal CalcMacaulayDurationOneYers(double C, double n, double N, double P, double _i)
        {
            if (C < 0 || n < 0 || N < 0 || P < 0 || _i < 0)
                throw new Exception("Negative value");
            double D = 0;
            for (int i = 1; i <= n; i++)
            {
                D += i * C / Math.Pow(1 + _i, i);
            }
            return (decimal)(D * (1 / P));
        }
        //дюрация Маколея (при выплате купона несколько раз в год);
        static public decimal CalcMacalayDurationTwoYers(double C, double n, double N, double P, double m, double r)
        {
            if (r < 0 || n < 0 || N < 0 || C < 0 || P < 0 || m < 0)
                throw new Exception("Negative value");
            decimal D = (decimal)(C / P * ((Math.Pow(1 + (r / m), m * n + 1) - n * r - (1 + (r / m))) / Math.Pow(r, 2) * Math.Pow(1 + (r / m), m * n)) + (n * N) / P * Math.Pow(1 + (r / m), m * n));
            return D;
        }
        // дюрация Маколея (при выплате купона раз в год и сроки жизни облигации много лет);
        static public decimal CalcMacalayDurationManyYers(double C, double n, double N, double P, double r)
        {
            if (r < 0 || n < 0 || N < 0 || C < 0 || P < 0)
                throw new Exception("Negative value");
            decimal D = ((decimal)(C / P * ((Math.Pow(1 + r, n + 1) - n * r - (1 + r)) / (Math.Pow(r, 2) * Math.Pow(1 + r, n))) + n * N / (P * Math.Pow(1 + r, n))));
            return D;
        }
        *//*Где:CalcValueDondDiscount

            PV – текущая стоимость облигации;
            N – номинал облигации;
        r - ставка без риска, выраженный в долях еденицы;
        С – размер выплачиваемого купона;
            n – кол-во лет жизни облигации;
        ЧЦО – чистая цена облигации;
            GCO – грязная цена облигации;
            NCD – накопленный купонный доход
            Dn – день начала купонного периода;
        Do – день окончания или дня расчета НКД;
        D – дюрация Маколея;*/

    }
}