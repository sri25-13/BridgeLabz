using Model.Label;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
   public interface ILabelRepository
    {
         Task AddLabel(string name, string id);
        List<Labelmodel> GetLabel();
        Task Update(int id, string name);
        Task Delete(int id);
    }
}
