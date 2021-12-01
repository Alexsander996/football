using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class SalaryStorage
    {
        private Dictionary<int, Salary> Salaries { get; } = new Dictionary<int, Salary>();

        public void Create(Salary salary)
        {
            Salaries.Add(salary.SalaryID, salary);
        }

        public Salary Read(int salaryID)
        {
            return Salaries[salaryID];
        }

        public Salary Update(int SalaryID, Salary newSalary)
        {
            Salaries[SalaryID] = newSalary;
            return Salaries[SalaryID];
        }

        public bool Delete(int SalaryID)
        {
            return Salaries.Remove(SalaryID);
        }
    }
}