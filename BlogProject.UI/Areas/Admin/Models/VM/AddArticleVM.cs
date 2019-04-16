using BlogProject.DAL.ORM.Entity;
using BlogProject.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.UI.Areas.Admin.Models.VM
{
    public class AddArticleVM
    {
        public AddArticleVM()
        {
            AppUsers = new List<AppUser>();
            Categories = new List<Category>();
            Article = new ArticleDTO();
        }

        public List<AppUser> AppUsers { get; set; }
        public List<Category> Categories { get; set; }
        public ArticleDTO Article { get; set; }
    }
}