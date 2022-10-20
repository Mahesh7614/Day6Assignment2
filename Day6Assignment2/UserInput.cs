﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment2
{
    // Vending Machine Problem
    public class UserInput
    {
        public void vendingMachineProblem()
        {
            var vm = VendingMachine.UserInputForVendingMachine();
            VendingMachine machine = new VendingMachine(vm.Number);
            machine.calculateChange();  
        }
        // Day Of Week Problem
        public void dayOfWeekProblem()
        {
            var w = DayOfWeek.UserInputForDayOfWeek();
            DayOfWeek week = new DayOfWeek(w.Date,w.Month,w.Year);
            week.FindDayOfWeek();
        }
        // Temperature Conversion Problem
        public void temperatureConversionProblem()
        {
            var tm = TemperatureConversion.UserInputForTemperature();
            TemperatureConversion temperature = new TemperatureConversion(tm.Option);
            temperature.TemperatureConversionCalculation();
        }
        // Monthly Payment Problem
        public void MonthlyPaymentProblem()
        {
            var mp = MonthlyPayment.UserInputForMonthlyPayment();
            MonthlyPayment payment = new MonthlyPayment(mp.Principal, mp.InterestRate, mp.Year);
            payment.CalculateMonthlyPayment();
        }
        // Square Root Of Number Problem
        public void SquareRootProblem()
        {
            var sq = SquareRoot.UserInputForSquareRoot();
            SquareRoot root = new SquareRoot(sq.Number);
            root.CalculateSquareRoot();
        }
    }
}
