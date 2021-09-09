﻿using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_EmployeeAttendance.GetAttendance();
            UC2_EmpWage.EmpWage();
            UC3_PartTimeEmpWage.PartTimeEmpWage();
            UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("Infosys",20,30,8);
            Console.ReadKey();
        }
    }
}
