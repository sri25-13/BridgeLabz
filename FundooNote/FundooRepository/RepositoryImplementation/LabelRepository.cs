// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.RepositoryImplementation
{
    using FundooModel.Label;
    using FundooRepository.FundooContext;
    using FundooRepository.RepositoryInterface;
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
        public async Task AddLabel(Labelmodel labelmodel)
        {
            Labelmodel label = new Labelmodel()
            {
                LabelName = labelmodel.LabelName,
                LabelId = labelmodel.LabelId,
                Email = labelmodel.Email,
                NoteId = labelmodel.NoteId
            };
            this.context.Labels.Add(label);
            await Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// Deletes the Label
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteLabel(int id)
        {
            var label = context.Labels.Where(r => r.LabelId == id).SingleOrDefault();
            if (label != null)
            {
                this.context.Labels.Remove(label);
                await Task.Run(() => context.SaveChanges());
            }

        }

        /// <summary>
        /// Gives all the Label
        /// </summary>
        /// <returns></returns>
        public List<Labelmodel> GetAllLabels()
        {
            return this.context.Labels.ToList();
        }

        /// <summary>
        /// Updates the Label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task UpdateLabel(string name, int id)
        {
            var result = this.context.Labels.Where(op => op.LabelId == id).SingleOrDefault();
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
