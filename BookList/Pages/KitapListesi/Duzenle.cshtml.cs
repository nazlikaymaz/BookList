using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages.KitapListesi
{
    public class DuzenleModel : PageModel
    {
        private KLDbContext _db;
        public DuzenleModel(KLDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var DBGelenKitap = await _db.Book.FindAsync(Book.Id);
                DBGelenKitap.BookName = Book.BookName;
                DBGelenKitap.Writer = Book.Writer;
                DBGelenKitap.ISBN = Book.ISBN;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
