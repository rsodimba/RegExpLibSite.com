using RegExpLibSite.UseCases.Contributors;
using RegExpLibSite.UseCases.Contributors.List;

namespace RegExpLibSite.Infrastructure.Data.Queries;

public class FakeListContributorsQueryService : IListContributorsQueryService
{
  public Task<IEnumerable<ContributorDTO>> ListAsync()
  {
    var result = new List<ContributorDTO>() { new ContributorDTO(1, "Ardalis"), new ContributorDTO(2, "Snowfrog") };
    return Task.FromResult(result.AsEnumerable());
  }
}
