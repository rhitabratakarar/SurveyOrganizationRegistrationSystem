
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace SurveyOrganizationRegistrationSystem.Classes;

[Index(nameof(OrgName), nameof(OrgSurveyName), IsUnique = true)]
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