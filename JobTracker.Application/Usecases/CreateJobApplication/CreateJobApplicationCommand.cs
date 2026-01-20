using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Application.Usecases.CreateJobApplication;

public record CreateJobApplicationCommand(
    string CompanyName,
    string Position,
    DateTime AppliedAt
);
