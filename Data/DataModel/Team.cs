﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerCore.DataModel
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual Event Event { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Cross reference for pre-reserved rooms (PD only)
        /// </summary>
        public int? RoomID { get; set; }

        /// <summary>
        /// String formatted rooms for events that don't pre-reserve rooms
        /// </summary>
        public string CustomRoom { get; set; }
        public virtual TeamMembers Members { get; set; }

        public virtual List<Invitation> Invitations { get; set; }

        public string PrimaryContactEmail { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
    }
}
