﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCore.DataModel
{
    public class PuzzleStatePerTeam
    {
        // Note: No ID here. See PuzzleServerContext.OnModelCreating for the declaration of the key.

        public int PuzzleID { get; set; }
        public virtual Puzzle Puzzle { get; set; }

        public int TeamID { get; set; }
        public virtual Team Team { get; set; }

        /// <summary>
        /// Whether or not the puzzle has been unlocked
        /// </summary>
        [NotMapped]
        public bool IsUnlocked
        {
            get { return UnlockedTime != null; }
            set
            {
                if (IsUnlocked != value)
                {
                    UnlockedTime = value ? (DateTime?)DateTime.UtcNow : null;
                }
            }
        }

        /// <summary>
        /// Whether or not the puzzle has been unlocked
        /// </summary>
        [NotMapped]
        public bool IsSolved
        {
            get { return SolvedTime != null; }
            set
            {
                if (IsSolved != value)
                {
                    SolvedTime = value ? (DateTime?)DateTime.UtcNow : null;
                }
            }
        }

        /// <summary>
        /// Whether or not the puzzle has been unlocked by this team, and if so when
        /// </summary>
        public DateTime? UnlockedTime { get; set; }

        /// <summary>
        /// Whether or not the puzzle has been solved by this team, and if so when
        /// </summary>
        public DateTime? SolvedTime { get; set; }

        /// <summary>
        /// Whether or not the team has checked the "Printed" checkbox for this puzzle
        /// </summary>
        public bool Printed { get; set; }

        /// <summary>
        /// Notes input by the team for this puzzle
        /// </summary>
        public string Notes { get; set; }
    }
}
