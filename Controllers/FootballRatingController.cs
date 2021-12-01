using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GitHub;
using GitHub.Repository;

namespace footaball.Controllers
{
    [ApiController]
    [Route("/rating")]
    public class RatingController : ControllerBase
    {
        [HttpPut]
        public RatingPlayer Create(RatingPlayer rating)
        {
            Storage.RatingStorage.Create(rating);
            return rating;
        }

        [HttpGet]
        public RatingPlayer Read(int ratingID)
        {
            return Storage.RatingStorage.Read(ratingID);
        }

        [HttpPatch]
        public RatingPlayer Update(int ratingID, RatingPlayer newRating)
        {
            return Storage.RatingStorage.Update(ratingID, newRating);
        }

        [HttpDelete]
        public bool Delete(int ratingID)
        {
            return Storage.RatingStorage.Delete(ratingID);
        }
    }
}