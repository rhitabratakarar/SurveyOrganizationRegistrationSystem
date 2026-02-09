using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurveyOrganizationRegistrationSystem.Classes;

namespace SurveyOrganizationRegistrationSystem.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public SurveyRegistrationDetails SurveyRegistrationDetails { get; set; } = default!;

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine(SurveyRegistrationDetails.OrgName);
            Console.WriteLine(SurveyRegistrationDetails.OrgSurveyName);
            Console.WriteLine(SurveyRegistrationDetails.OrgSurveyDesc);

            TempData["CanAccess"] = true;
            
            return RedirectToPage("./Success");
        }
        else
        {
            return RedirectToPage("./Index");
        }
    }
}
