using GymStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GymStore.Pages.Categories
{
    public class EditModel : PageModel
    {
        public Category Category { get; set; }
        public void OnGet()
        {
        }
    }
}
