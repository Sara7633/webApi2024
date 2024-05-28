using Entities;
using Repository;
using System.Threading.Tasks;

namespace Service
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            this.ratingRepository = ratingRepository;
        }

        public async Task<int> AddRating(Rating rating)
        {
            return await ratingRepository.AddRating(rating);
        }
    }
}