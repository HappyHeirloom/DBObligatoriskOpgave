namespace DBObligatoriskOpgaveWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomType
    {
        [Key]
        [StringLength(1)]
        public string Type { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
