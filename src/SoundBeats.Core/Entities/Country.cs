﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeats.Core.Entities
{
    [Table("Country")]
    public class Country
    {
        public int Id { get; set; }
        public string NameEs { get; set; }
        public string NameEn { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }

        public ICollection<Artist>? Artist { get; set; }
    }
}
