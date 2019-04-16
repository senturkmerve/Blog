using BlogProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.UI.Areas.Admin.Models.VM
{
    public class UpdateArticleVM:BaseVM
    {
        public UpdateArticleVM()
        {
            AppUsers = new List<AppUser>();
            Categories = new List<Categories>();

        }
        

    }
    public List<AppUser> AppUsers { get; set; }
    public List<Category> Categories { get; set; }

    public Guid AppUserID { get; set; }
    public Guid CategoryID { get; set; }
}