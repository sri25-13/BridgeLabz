using Model.Label;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
   public interface ILabelManager
    {
        Task AddLabel(string name,int id);
        List<Labelmodel> GetAllLabels();
        Task UpdateLabel(string name, int id);
        Task DeleteLabel(int id);
    }
}
