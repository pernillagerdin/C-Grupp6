using Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORUComSys.Controllers {
    public class MeetingController : Controller {
        // GET: Index
        public ActionResult Index() {
            return View();
        }

        // GET: Proposal
        public ActionResult ProposeMeeting() {

            return View();
        }

        // POST: Proposal
        [HttpPost]
        public ActionResult ProposeMeeting(MeetingProposalModel model) {
            
            return RedirectToAction("Index");
        }
    }
}