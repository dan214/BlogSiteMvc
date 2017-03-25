using BlogSiteMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace BlogSiteMvc.Controllers
{
    public class CommentSurfaceController : SurfaceController
    {
        // GET: CommentSurface
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HandleFormPost(CommentsModel model)
        {
            var newComment = Services.ContentService.CreateContent(model.Email, CurrentPage.Parent.Id, "comments");
            newComment.SetValue("commentName", model.CommentName);
            newComment.SetValue("email", model.Email);
            newComment.SetValue("phone", model.Phone);
            newComment.SetValue("message", model.Message);

            Services.ContentService.SaveAndPublishWithStatus(newComment);
            return RedirectToCurrentUmbracoPage();
        }
    }
}