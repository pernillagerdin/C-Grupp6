using Datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datalayer.Models {
    
    public class FormalPostModel : IIdentifiable<int> {
        [Key]
        public int Id { get; set; }

        [ForeignKey("FromUser")]
        public string PostFromUserId { get; set; }
        public virtual ApplicationUser FromUser { get; set; }

        public string PostText { get; set; }

        public DateTime TimePosted { get; set; }

        public byte[] AttachedFiles { get; set; }

        //public bool Formal { get; set; }
    }
}
