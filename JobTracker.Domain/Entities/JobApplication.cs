using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Domain.Entities
{
    public class JobApplication
    {
        protected JobApplication() { }

        public Guid Id { get; private set; }
        public string CompanyName { get; private set; } = default!;
        public string Position { get; private set; } = default!;
        public DateTime AppliedAt { get; private set; }

        public JobApplication(
            string companyName,
            string position,
            DateTime appliedAt)
        {
            Id = Guid.NewGuid();
            CompanyName = companyName;
            Position = position;
            AppliedAt = appliedAt;
        }
    }
}
