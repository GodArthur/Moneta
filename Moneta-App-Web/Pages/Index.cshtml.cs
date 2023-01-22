using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Moneta_App_Web.Data;
using Moneta_App_Web.Models;

namespace Moneta_App_Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _context;
    public IEnumerable<Transactions> many_transactions { get; set; }
    public IEnumerable<Categories> many_categories { get; set; }
    [BindProperty]
    public Transactions transaction { get; set; }

    [BindProperty]
    public Categories category { get; set; }
    public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        many_transactions = _context.Transactions;
        many_categories= _context.Categories;
    }

    public async Task<IActionResult> OnPost(Transactions transaction, Categories category)
    {
        if (transaction != null)
        {
            transaction.user_id = 1;
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
        if (category != null)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        return RedirectToPage("Index");


    }
}

