using Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Datalayer.Repositories;
using System.IO;
using ORUComSys.Models;

namespace ORUComSys.Controllers {
    [Authorize]
    public class FormalPostController : Controller {
        public FormalPostRepository formalPostRepo { get; set; }

        public FormalPostController() {
            ApplicationDbContext context = new ApplicationDbContext();
            formalPostRepo = new FormalPostRepository(context);
        }

        // GET: FormalPost
        public ActionResult Index() {
            FormalPostViewModel viewModel = new FormalPostViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(FormalPostViewModel postModel) {
            
            // check modelstate.
            if (ModelState.IsValid) {
                // get current user id (the poster's id).
                string currentUser = User.Identity.GetUserId();

                // declare a byte array, set it to the length of the possibly attached file from the view model.
                byte[] attachmentData = new byte[postModel.AttachedFile.InputStream.Length];
                // transfer the byte data to the view model's attached file field.
                postModel.AttachedFile.InputStream.Read(attachmentData, 0, attachmentData.Length);

                // convert to FormalPostModel.
                FormalPostModel modelToSave = new FormalPostModel { PostFromUserId = currentUser, PostText = postModel.PostText, TimePosted = DateTime.Now, AttachedFiles = attachmentData };

                // add to db and save changes.
                formalPostRepo.Add(modelToSave);
                formalPostRepo.Save();

                return RedirectToAction("Index", "Home");
            } else {
                return View();
            }

        }
    }
}