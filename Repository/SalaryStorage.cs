using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class SalaryStorage
    {
        private Dictionary<int, Salary> Salaries { get; } = new Dictionary<int, Salary>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Salary salary)
        {
            Salaries.Add(salary.SalaryID, salary);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
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