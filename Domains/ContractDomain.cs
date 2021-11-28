using System;

namespace GitHub
{
    public class Contract
    {
        public int ContractID { get; set; }
        public int Duration { get; set; }
        public Salary Salary { get; set; }
        public RoleInTeam Role { get; set; }
        public Budget Bonus { get; set; }
    }
}