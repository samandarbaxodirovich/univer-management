using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;

namespace univer_management.Service.Interfaces
{
	public interface IGuruxService
	{
		public Task<Gurux> GetById(long id);
		public Task<IEnumerable<Gurux>> GetAll();
		public IEnumerable<Gurux> GetByKeyword(string keyword);
		public Task<(bool, string)> CreateAsync(Gurux  entity);
		public Task<(bool, string)> DeleteAsync(long id);
		public Task<Gurux> UpdateAsync(string name, long id);
	}
}
