using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    public class MoneyPool
    {
        decimal PoolValue;
        decimal PoolWithdrawals;
        decimal PoolDeposits;
        public void Build(decimal budgetPerWeek, decimal valueToAdd)
        {
            PoolValue += budgetPerWeek - valueToAdd;
        }
  
        public void Subtract(decimal valueToSub)
        {
            PoolValue -= valueToSub;
            PoolWithdrawals += valueToSub;
        }

        public void Add(decimal valueToAdd)
        {
            PoolValue += valueToAdd;
            PoolDeposits += valueToAdd;
        }
        public decimal GetValue() { return PoolValue; }
        public decimal GetWithdrawals() { return PoolWithdrawals; }
        public decimal GetDeposits() { return PoolDeposits; }
    }
}
