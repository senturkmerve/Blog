using BlogProject.DAL.ORM.Entity;
using BlogProject.UI.Areas.Admin.Models.DTO;
using BlogProject.UI.Areas.Admin.Models.VM;
using BlogProject.UI.Areas.Author.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.UI.Areas.Admin.Controllers
{
    public class ArticleController : BaseController
    {

        public ActionResult Add()
        {
            AddArticleVM model = new AddArticleVM()
            {
                Categories = service.CategoryService.GetActive(),

                AppUsers = service.AppUserService.GetActive(),

            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Article data)
        {
            service.ArticleService.Add(data);
            return Redirect("/Admin/Article/List");
        }

        public ActionResult List()
        {
            List<Article> model = service.ArticleService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Article article = service.ArticleService.GetById(id);
           AddArticleVM  model = new AddArticleVM();
            //model.Articles = service.ArticleService.GetById(id);
            model.Article.ID = article.ID;
            model.Article.Content = article.Content;
            model.Article.Header = article.Header;
            model.Article.PublishDate = article.PublishDate;
            List<Category> categories = service.CategoryService.GetActive();
            List<AppUser> appUsers = service.AppUserService.GetActive();
            model.Categories = categories;
            model.AppUsers = apppUsers;
       
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(ArticleDTO data)
        {
            Article article = service.ArticleService.GetById(data.ID);
            article.Header = data.Header;
            article.Content = data.Content;
            article.CategoryID = data.CategoryID;
            article.AppUserID = data.AppUserID;
            service.ArticleService.Update(article);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Article/List");
        }

        public ActionResult Delete(Guid id)
        {
            service.ArticleService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Article/List");
        }

    }
}