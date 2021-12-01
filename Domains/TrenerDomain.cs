using System;

namespace GitHub
{
    public class Trener
    {
        public int TrenerID { get; set; } 
        public TrainingSchedule TraningSchedule { get; set; }
        public RatingPlayer RatingPlayer { get; set; }
        public SquadOnMatch SquadOfTheMatch { get; set; }
    }
}