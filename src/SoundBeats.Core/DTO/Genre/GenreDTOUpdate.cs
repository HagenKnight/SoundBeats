﻿namespace SoundBeats.Core.DTO.Genre
{
    public class GenreDTOUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? AccountIdUpdateDate { get; set; }
    }
}