using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class ContractStorage
    {
        private Dictionary<int, Contract> Contracts { get; } = new Dictionary<int, Contract>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Contract contract)
        {
            Contracts.Add(contract.ContractID, contract);
            // var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Contract Read(int ContractID)
        {
            return Contracts[ContractID];
        }

        public Contract Update(int ContractID, Contract newContract)
        {
            Contracts[ContractID] = newContract;
            return Contracts[ContractID];
        }

        public bool Delete(int ContractID)
        {
            return Contracts.Remove(ContractID);
        }
    }
}