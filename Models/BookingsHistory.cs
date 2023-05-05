using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Airbnb.Models
{

    [Table("Housing")]
    public partial class BookingsHistory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdClient { get; set; }

        public int IdHousing { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime DateEntry { get; set; }
    }
}
