using Ardalis.Result;
using Ardalis.SharedKernel;

namespace RegExpLibSite.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
