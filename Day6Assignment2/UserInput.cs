using System;
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
    }
}
