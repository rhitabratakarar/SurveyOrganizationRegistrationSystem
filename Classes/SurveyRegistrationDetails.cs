using System.ComponentModel.DataAnnotations;

namespace SurveyOrganizationRegistrationSystem.Classes;

public class SurveyRegistrationDetails
{
    [Required]
    public string OrgName { get; set; } = default!;

    [Required]
    public string OrgSurveyName { get; set; } = default!;
    
    public string? OrgSurveyDesc { get; set; }
}