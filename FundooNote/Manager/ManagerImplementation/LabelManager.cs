using Manager.ManagerInterface;
using Model.Label;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImplementation
{
    public class LabelManager : ILabelManager
    {
        public readonly ILabelRepository labelRepository;
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }

        public async Task AddLabel(string name,int id)
        {
            try
            {
                await this.labelRepository.AddLabel(name, id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task DeleteLabel(int id)
        {
            try
            {
                await this.labelRepository.DeleteLabel(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Labelmodel> GetAllLabels()
        {
            return this.labelRepository.GetAllLabels();
        }



        public async Task UpdateLabel(string name, int id)
        {
            try
            {
               await this.labelRepository.UpdateLabel(name, id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}