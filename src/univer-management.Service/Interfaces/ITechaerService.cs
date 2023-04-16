using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Interfaces
{
    public interface ITechaerService
    {
        public IEnumerable<OqituvchiViewModel> GetAllTeachers();
    }
}
