using GymStore.Data;
using GymStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GymStore.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public IEnumerable<Category> Categories;

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories=_db.Categories;
        }
    }
}
