using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Interfaces.Common;
using univer_management.DataAccess.Interfaces.Main;
using univer_management.DataAccess.Repositories.Main;

namespace univer_management.DataAccess.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public IAuditoriyaRepository Auditoriyalar { get; }

        public IAuditoriyaTipiRepository AuditoriyaTiplari { get; }

        public IFanRepository Fanlar { get; }

        public IGuruxRepository Guruxlar { get; }

        public IKafedraRepository Kafedralar { get; }

        public IMashgulotRepository Mashgulotlar { get; }

        public IMutaxasislikRepository Mutaxasisliklar { get; }

        public IOqituvchiFanRepository OqituvchiFanlari { get; }

        public IOqituvchiMutaxasislikRepository OqituvchiMutaxasisliklar { get; }

        public IOqituvchiRejasiRepository OqituvchiRejalar { get; }

        public IOquvRejaRepository Oquvrejalar { get; }
        public IOqituvchiRepository Oqituvchilar { get; }

        public IOquvRejaMashgulotRepository OquvRejaMashgulotlar { get; }

        public IYuklamaRepository Yuklamalar { get; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
            Auditoriyalar = new AuditoriyaRepository(appDbContext);
            AuditoriyaTiplari = new AuditoriyaTipiRepository(appDbContext);
            Fanlar = new FanRepository(appDbContext);
            Guruxlar = new GuruxRepository(appDbContext);   
            Kafedralar = new KafedraRepository(appDbContext);
            Mashgulotlar = new MashgulotRepository(appDbContext);
            Mutaxasisliklar = new MutaxasislikRepository(appDbContext);
            OqituvchiFanlari = new OqituvchiFanRepository(appDbContext);
            OqituvchiMutaxasisliklar = new OqituvchiMutaxasislikRepository(appDbContext);
            OqituvchiRejalar = new OqituvchiRejasiRepository(appDbContext);
            Oquvrejalar = new OquvRejaRepository(appDbContext);
            Oqituvchilar = new OqituvchiRepository(appDbContext);
            OquvRejaMashgulotlar = new OquvRejaMashgulotRepository(appDbContext);
            Yuklamalar = new YuklamaRepository(appDbContext);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
