using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurveyOrganizationRegistrationSystem.Classes;
using SurveyOrganizationRegistrationSystem.Database;

namespace SurveyOrganizationRegistrationSystem.Pages;

public class IndexModel(SurveyManagementDbContext surveyManagementDbContext) : PageModel
{
    private readonly SurveyManagementDbContext _surveyMamangementDbContext = surveyManagementDbContext;

    [BindProperty]
    public SurveyRegistrationDetails SurveyRegistrationDetails { get; set; } = default!;

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            await _surveyMamangementDbContext.OrgSurveys.AddAsync(new OrgSurvey()
            {
                OrgName = SurveyRegistrationDetails.OrgName,
                OrgSurveyName = SurveyRegistrationDetails.OrgSurveyName,
                OrgSurveyDesc = SurveyRegistrationDetails.OrgSurveyDesc
            });
            await _surveyMamangementDbContext.SaveChangesAsync();

            TempData["CanAccess"] = true;
            return RedirectToPage("./Success");
        }
        else
        {
            return Page();
        }
    }
}
