// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryInterface
{
    using Model.Label;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// interface for labelrepository
    /// </summary>
    public interface ILabelRepository
    {
        /// <summary>
        /// method for addinglabels
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task AddLabel(string name,int id);

        /// <summary>
        /// method to Getalllabels
        /// </summary>
        /// <returns></returns>
        List<Labelmodel> GetAllLabels();

        /// <summary>
        /// Method to update the labels
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task UpdateLabel(string name,int id);

        /// <summary>
        /// Deletes the Label
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteLabel(int id);
    }
}
