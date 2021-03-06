﻿using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;

        public decimal GetHourlyWage(decimal annualSalary) => annualSalary / HoursInYear;

    }
}
