using Datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Models {
    public class MeetingProposalModel : IIdentifiable<int> {
        public int Id { get; set; }

        [ForeignKey("Host")]
        public virtual string HostId { get; set; }
        public virtual ApplicationUser Host { get; set; }

        public string Location { get; set; }

        [Display(Name = "Start time")]
        [DataType(DataType.Date)]
        public DateTime StartTimes { get; set; }

        public List<ApplicationUser> Invitees { get; set; }
        public MeetingType Type { get; set; }
        public string Description { get; set; }
    }

    public enum MeetingType {
        Public,
        Private,
        Secret
    }
}
