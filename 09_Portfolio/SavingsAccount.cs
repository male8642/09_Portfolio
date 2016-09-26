using System;

namespace _09_Portfolio
{
    internal class SavingsAccount : IAsset
    {
        private string account;
        private double value;
        private double interestRate;
        
        public double InterestRate { get; set; }
        public string Account { get; set; }
        public double Value { get; set; }
        
        public SavingsAccount()
        {

        }
      
        public SavingsAccount(string v1, double v2, double v3)
        {
            account = v1;
            value = v2;
            interestRate = v3;
        }

        public double GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            
            {
                return "SavingsAccount[" + "value=" + value + ".0," + "interestRate=" + interestRate + "]";
            }
        }
    }
}