namespace Praise2018.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        public string Alias { get; set; }
        public string Name { get; set; }

        
        

        
        public string Role { get; set; }

        public int Got { get; set; }
        public int Give { get; set; }

        //头像
        public string Picture { get; set; }
    }
}
