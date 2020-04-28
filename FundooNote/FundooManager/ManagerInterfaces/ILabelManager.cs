// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooManager.ManagerInterface
{
    using FundooModel.Label;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for LabelManager
    /// </summary>
    public interface ILabelManager
    {
        /// <summary>
        /// Adds the Label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        string AddLabel(Labelmodel labelmodel);

        /// <summary>
        /// Gets all the labels
        /// </summary>
        /// <returns></returns>
        List<Labelmodel> GetAllLabels();

        /// <summary>
        /// Updates the Label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task UpdateLabel(string name, int id);

        /// <summary>
        /// Deletes the label
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteLabel(int id);
    }
}
