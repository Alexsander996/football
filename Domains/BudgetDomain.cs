using System;

namespace GitHub
{
   public class Budget
    {
        public int BudgetID { get; set; }
        public int BalanceFromSale { get; set; }
        public int BalanceFromContract { get; set; }
        public int BalanceFromSalary { get; set; }
        public int BalanceFromTransfer { get; set; }
    }
}