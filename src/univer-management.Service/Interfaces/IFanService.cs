﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Interfaces
{
    public interface IFanService
    {
        public Task<(bool, string)> CreateAsync(Fan entity, string kafedraName);
        public IEnumerable<FanViewModel> GetAll();
    }
}
