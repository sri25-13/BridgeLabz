// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.ManagerImplementation
{
    using Manager.ManagerInterface;
    using Model.Label;
    using Repository.RepositoryInterface;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for LabelManager
    /// </summary>
    public class LabelManager : ILabelManager
    {
        public readonly ILabelRepository labelRepository;
        public LabelManager()
        {
        }
        /// <summary>
        /// Parameterized constructor for LabelManager
        /// </summary>
        /// <param name="labelRepository"></param>
        public LabelManager(ILabelRepository labelRepository)
        {
            this.labelRepository = labelRepository;
        }

        /// <summary>
        /// Adds the Label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task AddLabel(string name, int id)
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

        /// <summary>
        /// Deletes the Label
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all the labels
        /// </summary>
        /// <returns></returns>
        public List<Labelmodel> GetAllLabels()
        {
            return this.labelRepository.GetAllLabels();
        }

        /// <summary>
        /// Updates the label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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