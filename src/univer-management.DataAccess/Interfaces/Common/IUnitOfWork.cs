using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.Interfaces.Main;

namespace univer_management.DataAccess.Interfaces.Common
{
    public interface IUnitOfWork
    {
        public IAuditoriyaRepository Auditoriyalar { get; }
        public IAuditoriyaTipiRepository AuditoriyaTiplari { get; }
        public IFanRepository Fanlar { get; }
        public IGuruxRepository Guruxlar { get; }
        public IKafedraRepository Kafedralar { get; }
        public IMashgulotRepository Mashgulotlar { get; }
        public IMutaxasislikRepository Mutaxasisliklar { get; }
        public IOqituvchiRepository Oqituvchilar { get; }
        public IOqituvchiFanRepository OqituvchiFanlari { get; }
        public IOqituvchiMutaxasislikRepository OqituvchiMutaxasisliklar { get; }
        public IOqituvchiRejasiRepository OqituvchiRejalar { get; } 
        public IOquvRejaRepository Oquvrejalar { get; }
        public IOquvRejaMashgulotRepository OquvRejaMashgulotlar { get; }
        public IYuklamaRepository Yuklamalar { get; }
        public IDarsJadvalRepository DarsJadvallari { get; }

        public Task<int> SaveChangesAsync();
    }
}
