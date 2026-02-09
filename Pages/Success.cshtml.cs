using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class SuccessModel : PageModel
{
    public IActionResult OnGet()
    {
        bool accessConfirmation = Convert.ToBoolean(TempData["CanAccess"]);
        if (accessConfirmation)
            return Page();

        TempData.Remove("CanAccess");
        return RedirectToPage("./Index");
    }
}