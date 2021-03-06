﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBAStatistics.Models
{
    public class PlayerSeasonPointsPerGame
    {
        [Key, Column(Order = 0)]
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }

        [Key, Column(Order = 1)]
        public string SeasonId { get; set; }

        public virtual Season Season { get; set; }

        public double PointsPerGame { get; set; }
    }
}
