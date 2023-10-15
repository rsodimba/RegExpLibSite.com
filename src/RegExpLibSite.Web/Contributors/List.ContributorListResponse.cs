using RegExpLibSite.Web.ContributorEndpoints;

namespace RegExpLibSite.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
