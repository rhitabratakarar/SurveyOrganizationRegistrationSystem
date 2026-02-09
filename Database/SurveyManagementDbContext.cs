using Microsoft.EntityFrameworkCore;
using SurveyOrganizationRegistrationSystem.Classes;

namespace SurveyOrganizationRegistrationSystem.Database;

public class SurveyManagementDbContext(DbContextOptions<SurveyManagementDbContext> options) : DbContext(options)
{
    public DbSet<OrgSurvey> OrgSurveys { get; set; }
}