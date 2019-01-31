using Datalayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Repositories {
    class ProposalRepository : Repository<MeetingProposalModel, int> {
        public ProposalRepository(ApplicationDbContext context) : base(context) { }


    }
}
