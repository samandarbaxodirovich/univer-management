﻿using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Domain.Entities;
using univer_management.Service.Dtos.CreateDtos;
using univer_management.Service.Interfaces;
using univer_management.Service.ViewModels;

namespace univer_management.Service.Services
{
    public class OquvRejaService :IOquvRejaService
    {
        UnitOfWork _work = SingeltonUnitOfWork.Instance;
        MutaxasislikService mService = new();
        MashgulotService tService = new();
        public async Task<(bool, string)> CreateAsync(OquvRejaFanCreateDto dto)
        {
            try
            {
                _work.Oquvrejalar.Add(
                new Oquv_Reja
                {
                    MutaxasislikId = dto.Mutaxasislik,
                    Semestr = dto.Semestr,
                    Hafta = dto.HaftalarSoni,
                    FanId = dto.Fan,
                    CreatedAt = DateTime.UtcNow.AddHours(5.0),
                    UpdatedAt = DateTime.UtcNow.AddHours(5.0),
                    Soat = dto.UmumiyDarsSoati,
                    Year = dto.Year
                }
            );
                if (await _work.SaveChangesAsync() != 0)
                {
                    var oquvRejaId = (await CurrentGet(dto)).Id;
                    _work.OquvRejaMashgulotlar.Add(new Oquv_Reja_Mashgulot()
                    {
                        MashgulotId = 3,
                        MashgulotLength = dto.Lektsiya,
                        OquvRejaId = oquvRejaId,
                    });
                    _work.OquvRejaMashgulotlar.Add(new Oquv_Reja_Mashgulot()
                    {
                        MashgulotId = 4,
                        MashgulotLength = dto.Seminar,
                        OquvRejaId = oquvRejaId,
                    });
                    _work.OquvRejaMashgulotlar.Add(new Oquv_Reja_Mashgulot()
                    {
                        MashgulotId = 5,
                        MashgulotLength = dto.Imtihon,
                        OquvRejaId = oquvRejaId,
                    });
                    _work.OquvRejaMashgulotlar.Add(new Oquv_Reja_Mashgulot()
                    {
                        MashgulotId = 6,
                        MashgulotLength = dto.MustaqilTalim,
                        OquvRejaId = oquvRejaId,
                    });
                    if (await _work.SaveChangesAsync() != 0)
                        return (true, "Oquv reja muvaffaqiyatli qo'shildi");
                    else throw new Exception();
                }
                else
                    return (false, "Oquv reja qo'shishda xatolik");
            }
            catch 
            {
                return (false, "Oquv reja qo'shishda xatolik");
            }
            
            
        }
        public IEnumerable<OquvRejaViewModel> GetAll(long mutaxasislikId,int semestr,int year)
        {
            var trainings = _work.Oquvrejalar.GetAll().Where(x=>x.MutaxasislikId == mutaxasislikId&&x.Semestr == semestr&&x.Year == year).ToList();
            return trainings.Select(x => (OquvRejaViewModel)x).ToList();
        }
        public IEnumerable<Oquv_Reja> GetAllR()
        {
            return _work.Oquvrejalar.GetAll().ToList();

        }




        public async Task<Oquv_Reja> CurrentGet(OquvRejaFanCreateDto dto)
        {
            return await _work.Oquvrejalar.FirstOrDefaultAsync(x=>x.FanId == dto.Fan&&x.MutaxasislikId == dto.Mutaxasislik&&x.Semestr == dto.Semestr);
        }
    }
}
