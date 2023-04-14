using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;
using univer_management.Service.Interfaces;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Services
{
    public class TeacherService : ITechaerService
    {
        public UnitOfWork _db;
        public TeacherService()
        {
                _db = new UnitOfWork(new AppDbContext());
        }
        public IEnumerable<OqituvchiViewModel> GetAllTeachers()
        {
            var teachers = _db.Oqituvchilar.GetAll().Select(x=>(OqituvchiViewModel)x).ToList();
            if (teachers != null) return teachers;
            else return new List<OqituvchiViewModel>();
        }
    }
}
