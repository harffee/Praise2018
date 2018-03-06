namespace Praise2018.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detail
    {
        public string Alias { get; set; }
        public string Name { get; set; }

        public DateTime? Datetime { get; set; }


        public string Desc { get; set; }


        public string ToWho { get; set; }

        public int Month { get; set; }
    }
}
