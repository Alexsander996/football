using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class BudgetStorage
    {
        private Dictionary<int, Budget> Budgets { get; } = new Dictionary<int, Budget>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open()

        public void Create(Budget budget)
        {
            Budgets.Add(budget.BudgetID, budget);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Budget Read(int BudgetID)
        {
            return Budgets[BudgetID];
        }


        public Budget Update(int BudgetID, Budget newBudget)
        {
            Budgets[BudgetID] = newBudget;
            return Budgets[BudgetID];
        }

        public bool Delete(int BudgetID)
        {
            return Budgets.Remove(BudgetID);
        }
    }
}