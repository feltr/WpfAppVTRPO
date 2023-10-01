using System;
using VTRPO.Library;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase (1,1,2)]
        [TestCase (123,0.12,137.76)]
        public void Equal_InvestmentOneYers(double PV, double r, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcInvestment(PV, r) * 100) / 100;
            Assert.AreEqual(result, expected);
        }



        [TestCase(1, -1)]
        [TestCase(-1, 1)]
        public void NegativeException_InvestmentOneYers(double PV, double r)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcInvestment(PV, r));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }





        [TestCase(1, 1, 1, 2)]
        [TestCase(123, 0.12, 5, 196.8)]
        public void Equal_InvestmentManyYers(double PV, double r, double n, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcInvestment(PV, r, n) * 100) / 100;
            Assert.AreEqual(result, expected);
        }



        [TestCase(1, 1, -1)]
        [TestCase(1, -1, 1)]
        [TestCase(-1, 1, 1)]
        public void NegativeException_InvestmentManyYers(double PV, double r, double n)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcInvestment(PV, r, n));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }




        [TestCase(1, 1, 1, 1, 2)]
        [TestCase(123, 0.12, 5, 120, 123.61)]
        public void Equal_InvestmentMultipleYers(double PV, double r, double n, int dayV, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcInvestment(PV, r, n, dayV) * 100)/ 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, 1, -1)]
        [TestCase(1, 1, -1, 1)]
        [TestCase(1, -1, 1, 1)]
        [TestCase(-1, 1, 1, 1)]
        public void NegativeException_InvestmentMultipleYers(double PV, double r, double n, int dayV)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcInvestment(PV, r, n, dayV));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }



        [TestCase(123, 0.12, 5, 216.76)]
        public void Equal_InvestmentHardManyYers(double PV, double r, double n, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcInvestmentHard(PV, r, n) * 100) / 100;
            Assert.AreEqual(result, expected);
        }



        [TestCase(1, 1, -1)]
        [TestCase(1, -1, 1)]
        [TestCase(-1, 1, 1)]
        public void NegativeException_InvestmentHardManyYers(double PV, double r, double n)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcInvestmentHard(PV, r, n));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }



        [TestCase(123, 0.12, 5, 224.12)]
        public void Equal_Investment—ontinuousdManyYers(double PV, double r, double t, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcInvestment—ontinuous(PV, r, t) * 100) / 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, -1)]
        [TestCase(1, -1, 1)]
        [TestCase(-1, 1, 1)]
        public void NegativeException_Investment—ontinuousdManyYers(double PV, double r, double t)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcInvestment—ontinuous(PV, r, t));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }


        [TestCase(123, 0.08, 0.12, 5, 120, 122.79)]
        public void Equal_Forward—urrencies(double S, double r, double rf, double T, double dayV, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcForward—urrencies(S, r, rf, T, dayV) * 100) / 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, 1, 1, -1)]
        [TestCase(1, 1, 1, -1, 1)]
        [TestCase(1, 1, -1, 1, 1)]
        [TestCase(1, -1, 1, 1, 1)]
        [TestCase(-1, 1, 1, 1, 1)]
        public void NegativeException_Forward—urrencies(double S, double r, double rf, double T, double dayV)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcForward—urrencies(S, r, rf, T, dayV));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }


        [TestCase(123, 0.08, 5, 120, 50, 173.41)]
        public void Equal_ForwardProduct(double S, double r, double T, double dayV, double Z, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcForwardProduct(S, r, T, dayV, Z) * 100) / 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, 1, 1, -1)]
        [TestCase(1, 1, 1, -1, 1)]
        [TestCase(1, 1, -1, 1, 1)]
        [TestCase(1, -1, 1, 1, 1)]
        [TestCase(-1, 1, 1, 1, 1)]
        public void NegativeException_ForwardProduct(double S, double r, double T, double dayV, double Z)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcForwardProduct(S, r, T, dayV, Z));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }



        [TestCase(123, 0.08, 5, 50, 525.13)]
        public void Equal_ValueDondCoupon(double C, double r, double n, double N, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcValueDondCoupon(C, r, n, N) * 100) / 100;
            Assert.AreEqual(result, expected);
        }



        [TestCase(1, 1, 1, -1)]
        [TestCase(1, 1, -1, 1)]
        [TestCase(1, -1, 1, 1)]
        [TestCase(-1, 1, 1, 1)]
        public void NegativeException_ValueDondCoupon(double C, double r, double n, double N)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcValueDondCoupon(C, r, n, N));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }



        [TestCase(123, 0.08, 5, 83.71)]
        public void Equal_ValueDondDiscount(double N, double r, double n, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcValueDondDiscount(N, r, n) * 100) / 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, -1)]
        [TestCase(1, -1, 1)]
        [TestCase(-1, 1, 1)]
        public void NegativeException_ValueDondDiscount(double N, double r, double n)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcValueDondDiscount(N, r, n));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }



        [TestCase(123, 50, 73)]
        public void Equal_BondPrice(double GCO, double NCD, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcBondPrice(GCO, NCD) * 100) / 100;
            Assert.AreEqual(result, expected);
        }

        [TestCase(1, -1)]
        [TestCase(-1, 1)]
        public void NegativeException_BondPrice(double GCO, double NCD)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcBondPrice(GCO, NCD));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }


        [TestCase(123, 0.08, 100, 5, 669.69)]
        public void Equal_AccumulatedCouponIncome(double N, double r, double dDn, double n, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcAccumulatedCouponIncome(N, r, dDn, n) * 100) / 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, 1, -1)]
        [TestCase(1, 1, -1, 1)]
        [TestCase(1, -1, 1, 1)]
        [TestCase(-1, 1, 1, 1)]
        public void NegativeException_AccumulatedCouponIncome(double N, double r, double dDn, double n)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcAccumulatedCouponIncome(N, r, dDn, n));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }


        [TestCase(1000, 0.1, 0.1 ,2, 1000, 1.90)]
        public void Equal_MacaulayDuration(double P, double C, double y, int n, double M, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcMacaulayDuration(P, C, y, n, M) * 100) / 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, 1, 1, -1)]
        [TestCase(1, 1, 1, -1, 1)]
        [TestCase(1, 1, -1, 1, 1)]
        [TestCase(1, -1, 1, 1, 1)]
        [TestCase(-1, 1, 1, 1, 1)]
        public void NegativeException_MacaulayDuration(double P, double C, double y, int n, double M)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcMacaulayDuration(P, C, y, n, M));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }



        [TestCase(1000, 0.1, 0.1, 2, 1000, 1.80)]
        public void Equal_MacaulayDurationModificir(double P, double C, double y, int n, double M, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcMacaulayDurationModificir(P, C, y, n, M) * 100) / 100;
            Assert.AreEqual(result, expected);
        }




        [TestCase(1, 1, 1, 1, -1)]
        [TestCase(1, 1, 1, -1, 1)]
        [TestCase(1, 1, -1, 1, 1)]
        [TestCase(1, -1, 1, 1, 1)]
        [TestCase(-1, 1, 1, 1, 1)]
        public void NegativeException_MacaulayDurationModificir(double P, double C, double y, int n, double M)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcMacaulayDurationModificir(P, C, y, n, M));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }


        [TestCase(1000, 0.1, 0.1, 2, 1000, 0.02, 0.03, 0.12,0.07, 0.00)]
        public void Equal_MacaulayDurationEffectiv(double P, double C, double y, int n, double M, double UpP, double DownP, double UpI, double DownI, decimal expected)
        {
            var result = Math.Truncate(Finance.CalcMacaulayDurationEffectiv(P, C, y, n, M, UpP, DownP, UpI, DownI) * 100) / 100;
            Assert.AreEqual(result, expected);
        }


        [TestCase(1, 1, 1, 1, 1, 1, 1, 1, -1)]
        [TestCase(1, 1, 1, 1, 1, 1, 1, -1, 1)]
        [TestCase(1, 1, 1, 1, 1, 1, -1, 1, 1)]
        [TestCase(1, 1, 1, 1, 1, -1, 1, 1, 1)]
        [TestCase(1, 1, 1, 1, -1, 1, 1, 1, 1)]
        [TestCase(1, 1, 1, -1, 1, 1, 1, 1, 1)]
        [TestCase(1, 1, -1, 1, 1, 1, 1, 1, 1)]
        [TestCase(1, -1, 1, 1, 1, 1, 1, 1, 1)]
        [TestCase(-1, 1, 1, 1, 1, 1, 1, 1, 1)]
        public void NegativeException_MacaulayDurationEffectiv(double P, double C, double y, int n, double M, double UpP, double DownP, double UpI, double DownI)
        {
            string expectedErrorMessage = "Negative value";
            var ex = Assert.Throws<Exception>(() => Finance.CalcMacaulayDurationEffectiv(P, C, y, n, M, UpP, DownP, UpI, DownI));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

    }
}