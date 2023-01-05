﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeats.Core.Entities
{

    [Table("GroupMember")]
    public class GroupMember
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int JoinInYear { get; set; }
        public int LeftYear { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public int MusicianId { get; set; }
        public virtual Musician Musician { get; set; }
    }
}