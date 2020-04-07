using Model.Label;
using Repository.AccountContext;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImplementation
{
    public class LabelRepository : ILabelRepository
    {
        private readonly Context context;
        public LabelRepository(Context context)
        {
            this.context = context;
        }
        public Task AddLabel(string name, int id)
        {

            Labelmodel label = new Labelmodel()
            {
                LabelName = name,

            };
            this.context.labels.Add(label);
            var res = Task.Run(() => context.SaveChanges());
            return res;


        }
        public  Task DeleteLabel(int id)
        {
            var label = context.labels.Where(r => r.LabelId == id).SingleOrDefault();
            if (label != null)
            {
                this.context.labels.Remove(label);

                var res= Task.Run(() => context.SaveChanges());
                return res;
            }
            return default;
        }
        public List<Labelmodel> GetAllLabels()
        {
            return this.context.labels.ToList();
        }
        
        public Task UpdateLabel(string name, int id)
        {
            var result = this.context.labels.Where(op => op.LabelId == id).SingleOrDefault();
            if (result != null)
            {
                result.LabelName = name;
                var res = Task.Run(() => context.SaveChanges());
                return res;
            }
            return default;
            
        }
    }
}

