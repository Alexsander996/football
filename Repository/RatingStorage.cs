using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class RatingStorage
    {
        private Dictionary<int, RatingPlayer> Ratings { get; } = new Dictionary<int, RatingPlayer>();

        public void Create(RatingPlayer rating)
        {
            Ratings.Add(rating.RatingID, rating);
        }

        public RatingPlayer Read(int RatingID)
        {
            return Ratings[RatingID];
        }

        public RatingPlayer Update(int RatingID, RatingPlayer newRating)
        {
            Ratings[RatingID] = newRating;
            return Ratings[RatingID];
        }

        public bool Delete(int RatingID)
        {
            return Ratings.Remove(RatingID);
        }
    }
}