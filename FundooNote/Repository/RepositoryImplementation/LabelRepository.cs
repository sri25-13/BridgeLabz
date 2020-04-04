using Model.Label;
using Repository.AccountContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImplementation
{
    public class LabelRepository
    {
        private readonly Context context;
        public LabelRepository(Context context)
        {
            this.context = context;
        }
        public Task AddLabel(string name, int id)
        {
            Labelmodel label1 = new Labelmodel()
            {
                LabelName = name,
                Noteid = id,
            };
            this.context.labels.Add(label1);
            var res = Task.Run(() => context.SaveChanges());
            return res;
        }
        /// <summary> /// Purpose:Create the Deletelabel using label id. /// </summary> /// <param name="id"></param> /// <returns></returns> 
        public async Task Delete(int id)
        {
            var result = this.context.labels.Where(op => op.LabelId == id).FirstOrDefault();
            if (result != null)
            {
                this.context.labels.Remove(result);
            }
            await Task.Run(() => context.SaveChanges());
        }
        /// <summary> /// Purpose:create the Getlabel using get the all the label list. /// </summary> /// <returns></returns> 
        public List<Labelmodel> Getlabel()
        {
            return this.context.labels.ToList();
        }
        /// <summary> /// Purpose:Create the Update label using specific part of upadated. /// </summary> /// <param name="id"></param> /// <param name="name"></param> /// <returns></returns> 
        public Task Update(int id, string name)
        {
            var result = this.context.labels.Where(op => op.LabelId == id).FirstOrDefault();
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



