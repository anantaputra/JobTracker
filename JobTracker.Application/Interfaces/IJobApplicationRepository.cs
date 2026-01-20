using JobTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Application.Interfaces
{
    public interface IJobApplicationRepository
    {
        Task AddAsync(JobApplication jobApplication);
        Task<IReadOnlyList<JobApplication>> GetAllAsync();
    }
}
