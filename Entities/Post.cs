namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Post
    {
        public int PostId { get; set; }

        public int PostedBy { get; set; }

        [StringLength(500)]
        public string PostDesc { get; set; }

        public DateTime postTime { get; set; }

        public int global { get; set; }

        public int class_id { get; set; }

        public int? file_id { get; set; }
    }
}
