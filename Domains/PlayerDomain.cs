using System;

namespace GitHub
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string FIO { get; set; }
        public int Number { get; set; }
        public RatingPlayer Rating { get; set; }
        public PositionOnField PositionInField { get; set; }
    }
}