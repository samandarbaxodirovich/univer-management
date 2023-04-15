using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.Domain.Entities;

namespace univer_management.Service.Interfaces
{
	public interface IKafedraService
	{
		public Task<Kafedra> GetById(long id);
		public Task<IEnumerable<Kafedra>> GetAll();
		public IEnumerable<Kafedra> GetByKeyword(string keyword);
		public Task<(bool, string)> CreateAsync(Kafedra entity);
		public Task<(bool, string)> DeleteAsync(long id);
		public Task<Kafedra> UpdateAsync(string name, long id);
	}
}
