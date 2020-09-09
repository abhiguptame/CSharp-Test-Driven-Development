using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SalaryCalculatorTestProject
{
    /*
     To get hourly, divide annual salary by 2080
     $100,006.40/ 2080 = $48.08 hr

     To get annual, multiply hourly by 2080
     $48.08 * 2080 = $100,006.40
     */

    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange 
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert
            Assert.AreEqual(104000, annualSalary);
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange 
            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetEmployeeTypeValue("Permanent")).Returns(() =>
            1
            );

            var salary = mock.Object.GetEmployeeTypeValue("Permanent") == 1 ? 52000 : 50000;

            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(salary);

            // Assert
            Assert.AreEqual(25, hourlyWage);
        }
    }
}
