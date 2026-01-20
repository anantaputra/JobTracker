using JobTracker.Application.Interfaces;
using JobTracker.Domain.Entities;
using JobTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Infrastructure.Repositories;

public class JobApplicationRepository : IJobApplicationRepository
{
    public readonly ApplicationDbContext _context;

    public JobApplicationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(JobApplication jobApplication)
    {
        await _context.JobApplications.AddAsync(jobApplication);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<JobApplication>> GetAllAsync()
    {
        return await _context.JobApplications.ToListAsync();
    }
}
