﻿using Newtonsoft.Json;

namespace Miki.API.RocketLeague
{
    public class RocketLeagueRankedStats
    {
        [JsonProperty("rankPoints")]
        public int RankPoints { get; internal set; }

        [JsonProperty("matchesPlayed", NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchesPlayed { get; internal set; }

        [JsonProperty("tier", NullValueHandling = NullValueHandling.Ignore)]
        public int? Tier { get; internal set; }

        [JsonProperty("division", NullValueHandling = NullValueHandling.Ignore)]
        public int? Division { get; internal set; }
    }
}