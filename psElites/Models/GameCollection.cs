using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace psElites.Models
{
    public class GameCollection
    {
        public GameCollection() { }
        [Key]
        public int GameCollectionID { get; set; }
        [Required]
        public ICollection<Game> Games { get; set; }
        public User UserID { get; set; }

        public static implicit operator DbSet<object>(GameCollection v)
        {
            throw new NotImplementedException();
        }
    }
}