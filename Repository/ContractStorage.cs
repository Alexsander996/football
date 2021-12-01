using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class ContractStorage
    {
        private Dictionary<int, Contract> Contracts { get; } = new Dictionary<int, Contract>();

        public void Create(Contract contract)
        {
            Contracts.Add(contract.ContractID, contract);
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