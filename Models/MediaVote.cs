using System;

namespace intevent_api.Models
{
    public class MediaVote
    {
        public int Id { get; set; }

        public int MediaId { get; set; }

        public int MediaVoteSetId { get; set; }

        public int TotalVotes { get; set; }

        public DateTimeOffset? TimeUserVoted { get; set; }
    }
}
