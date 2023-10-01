// See https://aka.ms/new-console-template for more information
using System;
using VTRPO.Library;
double PV, r, n, t, S, rf, T, Z, F, GCO, NCD, Dn, Do, C, N, P, _i, С, m, dDn, M, y , UpP, DownP, UpI, DownI;
decimal result = 0;
int k;
int dayV;
Console.WriteLine("Что хотите рассчиать?");
Console.WriteLine("Выбирите следующий расстет. Введите число, которое в начале");
Console.WriteLine("1. расчет будущей стоимости вклада при открытии депозитного вклада");
Console.WriteLine("2. расчет форвардной цены валюты, товара");
Console.WriteLine("3. расчет цены облигации и ее параметров");
string count;
count = Console.ReadLine();
switch (count) 
{
    case "1":
        Console.WriteLine("1. при вкладе на 1 год (при начислении простого процента)");
        Console.WriteLine("2. при вкладе более чем на 1 год (при начислении простого процента)");
        Console.WriteLine("3. при вкладе не кратном одному году (при начислении простого процента)");
        Console.WriteLine("4. при вкладе на 1 год (при начислении сложного процента)");
        Console.WriteLine("5. при вкладе более чем на 1 год (при начислении сложного процента)");
        Console.WriteLine("6. при вкладе не кратном одному году (при начислении сложного процента)");
        Console.WriteLine("7. при вкладе на 1 год (при начислении непрерывного процента)");
        count = Console.ReadLine();
        switch (count) 
        {
            case "1":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("будущая стоимость вложения");
                Console.WriteLine("ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы");
                PV = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcInvestment(PV, r);
                break;
            case "2":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("будущая стоимость вложения");
                Console.WriteLine("ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы");
                Console.WriteLine("количество начисления процентов под ставку r");
                PV = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                n = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcInvestment(PV, r, n);
                break;
            case "3":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("будущая стоимость вложения");
                Console.WriteLine("ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы");
                Console.WriteLine("количество начисления процентов под ставку r");
                Console.WriteLine("количество дней в году");
                PV = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                n = Convert.ToDouble(Console.ReadLine());
                dayV = Convert.ToInt32(Console.ReadLine());
                result = Finance.CalcInvestment(PV, r, n, dayV);
                break;
            case "4":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("будущая стоимость вложения");
                Console.WriteLine("ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы");
                PV = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcInvestment(PV, r);
                break;
            case "5":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("будущая стоимость вложения");
                Console.WriteLine("ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы");
                Console.WriteLine("количество начисления процентов под ставку r");
                PV = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                n = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcInvestment(PV, r, n);
                break;
            case "6":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("будущая стоимость вложения");
                Console.WriteLine("ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы");
                Console.WriteLine("количество начисления процентов под ставку r");
                Console.WriteLine("количество дней в году");
                PV = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                n = Convert.ToDouble(Console.ReadLine());
                dayV = Convert.ToInt32(Console.ReadLine());
                result = Finance.CalcInvestment(PV, r, n, dayV);
                break;
            case "7":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("будущая стоимость вложения");
                Console.WriteLine("ставка процента под который размещаются средства в расчете на 1 год, выраженный в долях еденицы");
                Console.WriteLine("период начисления в годах");
                PV = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                T = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcInvestmentСontinuous(PV, r, T);
                break;
            default:
                Console.WriteLine("числа нет в списке!");
                break;
        }
        break;
    case "2":
        Console.WriteLine("1. форвардная цена валюты");
        Console.WriteLine("2. форвардная цена товара");
        count = Console.ReadLine();
        switch (count)
        {
            case "1":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("цена спот валюты");
                Console.WriteLine("ставка без риска, той валюты которая бы конвертировалась");
                Console.WriteLine("ставка без риска, той валюты по которой определяем форвардную цену");
                Console.WriteLine("период времени до истечения контракта");
                Console.WriteLine("количество дней в году");
                S = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                rf = Convert.ToDouble(Console.ReadLine());
                T = Convert.ToDouble(Console.ReadLine());
                dayV = Convert.ToInt32(Console.ReadLine());
                result = Finance.CalcForwardСurrencies(S, r, rf, T, dayV);
                break;
            case "2":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("цена спот валюты");
                Console.WriteLine("ставка без риска, той валюты которая бы конвертировалась");
                Console.WriteLine("период времени до истечения контракта");
                Console.WriteLine("количество дней в году");
                Console.WriteLine("расходы по хранения и страхованию за период T");
                S = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                T = Convert.ToDouble(Console.ReadLine());
                dayV = Convert.ToInt32(Console.ReadLine());
                Z = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcForwardProduct(S, r, T, dayV, Z);
                break;
            default:
                Console.WriteLine("числа нет в списке!");
                break;
        }
        break;
    case "3":
        Console.WriteLine("1. текущая стоимость облигации, купонной");
        Console.WriteLine("2. текущая стоимость облигации, дисконтной");
        Console.WriteLine("3. чистая цена облигации");
        Console.WriteLine("4. накопленный купонный доход");
        Console.WriteLine("5. дюрации Маколея");
        Console.WriteLine("6. модифицированная дюрация");
        Console.WriteLine("7. эффективная дюрация");
        count = Console.ReadLine();
        switch (count)
        {
            case "1":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("размер выплачиваемого купона");
                Console.WriteLine("ставка без риска, выраженный в долях еденицы");
                Console.WriteLine("кол-во лет жизни облигации");
                Console.WriteLine("номинал облигации");
                C = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                n = Convert.ToDouble(Console.ReadLine());
                N = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcValueDondCoupon(C, r, n, N);
                break;
            case "2":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("номинал облигации");
                Console.WriteLine("ставка без риска, выраженный в долях еденицы");
                Console.WriteLine("кол-во лет жизни облигации");
                N = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                n = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcValueDondDiscount(N, r, n);
                break;
            case "3":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("грязная цена облигации");
                Console.WriteLine("чистая цена облигации");
                GCO = Convert.ToDouble(Console.ReadLine());
                NCD = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcBondPrice(GCO, NCD);
                break;
            case "4":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("номинал облигации");
                Console.WriteLine("ставка без риска, выраженный в долях еденицы");
                Console.WriteLine("разница дня начала и конца купонного периода");
                Console.WriteLine("кол-во лет жизни облигации");
                N = Convert.ToDouble(Console.ReadLine());
                r = Convert.ToDouble(Console.ReadLine());
                dDn = Convert.ToDouble(Console.ReadLine());
                n = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcAccumulatedCouponIncome(N, r, dDn , n);
                break;
            case "5":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("текущая цена облигации");
                Console.WriteLine("размер купонной выплаты");
                Console.WriteLine("доходность облигации");
                Console.WriteLine("общее число купонов");
                Console.WriteLine("номинал облигации");
                P = Convert.ToDouble(Console.ReadLine());
                C = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                k = Convert.ToInt32(Console.ReadLine());
                M = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcMacaulayDuration(P, C, y, k, M);
                break;
            case "6":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("текущая цена облигации");
                Console.WriteLine("размер купонной выплаты");
                Console.WriteLine("доходность облигации");
                Console.WriteLine("общее число купонов");
                Console.WriteLine("номинал облигации");
                P = Convert.ToDouble(Console.ReadLine());
                C = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                k = Convert.ToInt32(Console.ReadLine());
                M = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcMacaulayDurationModificir(P, C, y, k, M);
                break;
            case "7":
                Console.WriteLine("Введите значения по порядку:");
                Console.WriteLine("текущая цена облигации");
                Console.WriteLine("размер купонной выплаты");
                Console.WriteLine("доходность облигации");
                Console.WriteLine("общее число купонов");
                Console.WriteLine("номинал облигации");
                Console.WriteLine("рыночная цена в случае понижения процентных ставок");
                Console.WriteLine("рыночная цена в случае повышения процентных ставок");
                Console.WriteLine("размер повышенной ставки");
                Console.WriteLine("размер пониженной ставки");
                P = Convert.ToDouble(Console.ReadLine());
                C = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                k = Convert.ToInt32(Console.ReadLine());
                M = Convert.ToDouble(Console.ReadLine());
                UpP = Convert.ToDouble(Console.ReadLine());
                DownP = Convert.ToDouble(Console.ReadLine());
                UpI = Convert.ToDouble(Console.ReadLine());
                DownI = Convert.ToDouble(Console.ReadLine());
                result = Finance.CalcMacaulayDurationEffectiv(P, C, y, k, M, UpP, DownP, UpI, DownI);
                break;
            default:
                Console.WriteLine("числа нет в списке!");
                break;
        }
        break;
    default:
        Console.WriteLine("числа нет в списке!");
        break;
}
Console.WriteLine($"Результат: {result}");

