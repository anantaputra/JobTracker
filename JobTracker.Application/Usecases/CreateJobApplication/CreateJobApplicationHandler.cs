using JobTracker.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Application.Usecases.CreateJobApplication;

public class CreateJobApplicationHandler
{
    private readonly IJobApplicationRepository _repository;

    public CreateJobApplicationHandler(IJobApplicationRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(CreateJobApplicationCommand command)
    {
        var jobApplication = new Domain.Entities.JobApplication(
            command.CompanyName,
            command.Position,
            command.AppliedAt
        );
        await _repository.AddAsync(jobApplication);
    }
}
