using Model.Label;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
    public interface ILabelRepository
    {
        Task AddLabel(string name,int id);
        List<Labelmodel> GetAllLabels();
        Task UpdateLabel(string name,int id);
        Task DeleteLabel(int id);
    }
}
