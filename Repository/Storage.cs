namespace GitHub.Repository
{
    public static class Storage
    {
        public static TrenerStorage TrenerStorage { get; } = new TrenerStorage();
        public static PlayerStorage PlayerStorage { get; } = new PlayerStorage();
        public static SalaryStorage SalaryStorage { get; } = new SalaryStorage();
        public static ContractStorage ContractStorage { get; } = new ContractStorage();
        public static ClalendarMatchesStorage ClalendarMatchesStorage { get; } = new ClalendarMatchesStorage();
        public static OnlineTicketStorage OnlineTicketStorage { get; } = new OnlineTicketStorage();
        public static TicketOnStadiumStorage TicketOnStadiumStorage { get; } = new TicketOnStadiumStorage();
        public static RatingStorage RatingStorage { get; } = new RatingStorage();
        public static RoleInTeamStorage RoleInTeamStorage { get; } = new RoleInTeamStorage();
        public static SquadOnMatchStorage SquadOnMatchStorage { get; } = new SquadOnMatchStorage();
        public static TrainingScheduleStorage TrainingScheduleStorage { get; } = new TrainingScheduleStorage();
        public static BudgetStorage BudgetStorage { get; } = new BudgetStorage();
    }
}
