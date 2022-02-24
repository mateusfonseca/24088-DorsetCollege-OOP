using System;

namespace Ex6_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxPayer[] taxPayers = new TaxPayer[10];
            
            for (int i=1; i<=taxPayers.Length; i++) {
                taxPayers[i-1] = new TaxPayer("", 0, 0);
                System.Console.Write("Social Security Number: ");
                taxPayers[i-1].SocialSecurityNumber = Console.ReadLine();
                System.Console.Write("Yearly Gross Income: ");
                taxPayers[i-1].YearlyGrossIncome = decimal.Parse(Console.ReadLine());
            }

            foreach (TaxPayer taxPayer in taxPayers) {
                System.Console.WriteLine(taxPayer.SocialSecurityNumber);
                System.Console.WriteLine(taxPayer.YearlyGrossIncome);
                System.Console.WriteLine(taxPayer.TaxOwed);
            }
        }
    }

    class TaxPayer
    {
        private string socialSecurityNumber;
        private decimal yearlyGrossIncome, taxOwed;

        public TaxPayer(string socialSecurityNumber, decimal yearlyGrossIncome, decimal taxOwed) {
            this.SocialSecurityNumber = socialSecurityNumber;
            this.YearlyGrossIncome = yearlyGrossIncome;
            this.TaxOwed = taxOwed;
        }

        public string SocialSecurityNumber {
            get {
                return socialSecurityNumber;
            }
            set {
                socialSecurityNumber = value;
            }
        }
        public decimal YearlyGrossIncome {
            get {
                return yearlyGrossIncome;
            }
            set {
                yearlyGrossIncome = value;
                this.TaxOwed = yearlyGrossIncome < 30000 ? yearlyGrossIncome*(decimal)0.15 : yearlyGrossIncome*(decimal)0.28;
            }
        }
        public decimal TaxOwed {
            get {
                return taxOwed;
            }
            private set {
                taxOwed = value;
            }
        }
    }
}
