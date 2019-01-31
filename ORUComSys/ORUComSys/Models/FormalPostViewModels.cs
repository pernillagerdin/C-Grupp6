using Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORUComSys.Models {
    public class FormalPostViewModel {
        public int Id { get; set; }
        public ApplicationUser FromUser { get; set; }
        public string PostText { get; set; }
        public HttpPostedFileBase AttachedFile { get; set; }
        public DateTime TimePosted { get; set; }
    }
}