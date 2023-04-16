using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univer_management.Service.Interfaces
{
    public interface IOquvRejaService
    {
        public Task<(bool, string)> CreateAsync();
    }
}
