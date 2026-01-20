using JobTracker.Application.Interfaces;
using JobTracker.Application.Usecases.CreateJobApplication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace JobTracker.API.Controllers;

[ApiController]
[Route("api/job-applications")]
public class JobApplicationController : ControllerBase
{
    private readonly CreateJobApplicationHandler _createHandler;
    public readonly IJobApplicationRepository _repository;

    public JobApplicationController(
        CreateJobApplicationHandler createHandler,
        IJobApplicationRepository repository)
    {
        _createHandler = createHandler;
        _repository = repository;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateJobApplicationCommand command)
    {
        await _createHandler.HandleAsync(command);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _repository.GetAllAsync();
        return Ok(result);
    }

}
