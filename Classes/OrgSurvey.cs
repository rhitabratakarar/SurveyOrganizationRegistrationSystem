
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SurveyOrganizationRegistrationSystem.Classes;

public class OrgSurvey
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }

    [NotNull]
    public string OrgName { get; set; } = default!;

    [NotNull]
    public string OrgSurveyName { get; set; } = default!;

    public string? OrgSurveyDesc { get; set; }
}