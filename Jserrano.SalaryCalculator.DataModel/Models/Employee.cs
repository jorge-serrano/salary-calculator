﻿namespace Jserrano.SalaryCalculator.DataModel.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public object roleDescription { get; set; }
        public double hourlySalary { get; set; }
        public double monthlySalary { get; set; }
    }
}
