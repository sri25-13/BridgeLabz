// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryImplementation
{
    using Model.Label;
    using Repository.AccountContext;
    using Repository.RepositoryInterface;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for implementinglabel repository
    /// </summary>
    public class LabelRepository : ILabelRepository
    {
        private readonly Context context;
        public LabelRepository()
        {
        }

        /// <summary>
        /// Parameterized constructor for labelrepository
        /// </summary>
        /// <param name="context"></param>
        public LabelRepository(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the Label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Deletes the Label
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteLabel(int id)
        {
            var label = context.labels.Where(r => r.LabelId == id).SingleOrDefault();
            if (label != null)
            {
                this.context.labels.Remove(label);
                var res = Task.Run(() => context.SaveChanges());
                return res;
            }

            return default;
        }

        /// <summary>
        /// Gives all the Label
        /// </summary>
        /// <returns></returns>
        public List<Labelmodel> GetAllLabels()
        {
            return this.context.labels.ToList();
        }

        /// <summary>
        /// Updates the Label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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