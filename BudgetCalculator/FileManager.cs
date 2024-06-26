﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BudgetCalculator
{
    class FileManager
    {
        decimal MaintenanceLoan;
        decimal HouseCost;
        decimal BudgetPerDay;
        decimal BudgetPerWeek;
        decimal PoolWithdrawals;
        decimal PoolDeposits;
        DateTime StartDate;
        DateTime EndDate;
        MoneyPool Pool = new MoneyPool();
        DayManager dayManager = new DayManager();

        public void LoadFile(string FileName)
        {
            List<string> Lines = new List<string>();
            StreamReader reader = new StreamReader(FileName);
            int noOfLines = File.ReadAllLines(FileName).Length;
            try
            {
                for (int i = 0; i < noOfLines; ++i)
                {
                    Lines.Add(reader.ReadLine());
                }
            }
            finally
            {
                reader.Close();
                FundManager(Lines);
                if (Lines.Count() > 5)
                {
                    DayInfoManager(Lines);
                }
                PoolBuilder();
            }
        }

        public void SaveFile(string FileName)
        {
            StreamWriter writer = new StreamWriter(FileName);
            writer.WriteLine("Maintenance Loan: " + MaintenanceLoan);
            writer.WriteLine("Housing Cost: " + HouseCost);
            writer.WriteLine("Pool Transactions: " + (PoolWithdrawals + Pool.GetWithdrawals()) + ", " + (PoolDeposits + Pool.GetDeposits()));
            writer.WriteLine("Start Date: " + StartDate.ToString("dd/MM/yyyy"));
            writer.WriteLine("End Date: " + EndDate.ToString("dd/MM/yyyy"));
            foreach(DayInfo day in dayManager.GetList())
            {
                writer.WriteLine(day.GetDate().ToString("dd/MM/yyyy") + ", " + day.GetSpend());
            }
            writer.Flush();
            writer.Close();
        }

        public void DayInfoManager(List<string> Lines)
        {
            
            for (int i = 5; i < Lines.Count; ++i)
            {
                DateTime Date = DateTime.ParseExact(Lines[i].Split(',')[0], "dd/MM/yyyy", null);
                decimal Spend = decimal.Parse(Lines[i].Split(',')[1]);
                DayInfo newDay = new DayInfo(Date, Spend);
                dayManager.AddDay(newDay);
            }
        }

        public void PoolBuilder()
        {
            WeekHandler weekHandler = new WeekHandler();
            int startWeek = weekHandler.GetWeekOfYear(StartDate);
            int currentWeek = weekHandler.GetWeekOfYear(DateTime.Now);
            if (currentWeek < startWeek) { return;  }
            decimal Spend = 0;
            
            foreach (DayInfo day in dayManager.GetList())
            {
                int week = day.GetWeek();
                if (week >= startWeek && week < currentWeek)
                {
                    Spend += day.GetSpend();
                }
            }
            Spend += (PoolWithdrawals - PoolDeposits);
            Pool.Build((BudgetPerWeek * (currentWeek - startWeek)), Spend); 
        }

        public void FundManager(List<string> Lines)
        {
            try
            {
                MaintenanceLoan = decimal.Parse(Lines[0].Split(':')[1]);
                HouseCost = decimal.Parse(Lines[1].Split(':')[1]);
                decimal MoneyLeft = MaintenanceLoan - HouseCost;
                string PoolTransactions = Lines[2].Split(':')[1];
                PoolWithdrawals = decimal.Parse(PoolTransactions.Split(',')[0]);
                PoolDeposits = decimal.Parse(PoolTransactions.Split(',')[1]);
                StartDate = DateTime.ParseExact(Lines[3].Split(':')[1].Trim(), "dd/MM/yyyy", null);
                EndDate = DateTime.ParseExact(Lines[4].Split(':')[1].Trim(), "dd/MM/yyyy", null);
                int ContractLength = Convert.ToInt32((EndDate - StartDate).TotalDays);
                BudgetPerDay = MoneyLeft / ContractLength;
                BudgetPerWeek = BudgetPerDay * 7;
            }
            catch (Exception)
            {
                Initial_Setup wnd = new Initial_Setup();
                wnd.ShowDialog();
                FundManager(wnd.GetList());
            }
        }
        public decimal GetWeeklyBudget() { return BudgetPerWeek; }
        public decimal GetDailyBudget() { return BudgetPerDay; }
        public DayManager GetTransactions() { return dayManager; }
        public MoneyPool GetPool() { return Pool; }
    }
}
