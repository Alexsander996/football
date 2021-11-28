using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class RatingStorage
    {
        private Dictionary<int, RatingPlayer> Ratings { get; } = new Dictionary<int, RatingPlayer>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(RatingPlayer rating)
        {
            Ratings.Add(rating.RatingID, rating);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
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