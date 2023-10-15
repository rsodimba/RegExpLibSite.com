using Ardalis.Result;
using Ardalis.SharedKernel;

namespace RegExpLibSite.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
