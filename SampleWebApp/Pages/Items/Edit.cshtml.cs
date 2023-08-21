using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleWebApp.Data;
using SampleWebApp.Model;

namespace SampleWebApp.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;
        public Category Category { get; set; }

        public EditModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }
        public async Task<IActionResult> OnPost(Category category)
        {
            if (category.Name == null || category.Name.ToLower() == "null")
                ModelState.AddModelError("Category.Name", "Name cannot be Null");

            if (ModelState.IsValid)
            {
                _db.Category.Update(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category edited successfully";
                return RedirectToPage("Index");
            }
            else
                return Page();

        }
    }
}
