﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.ManagerImplementation
{
    using Manager.ManagerInterface;
    using Model.Collaborators;
    using Repository.RepositoryInterface;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for CollaboratorManager
    /// </summary>
    public class CollaboratorManager : ICollaboratorManager
    {
        private readonly ICollaboratorRepository repository;

        public CollaboratorManager()
        {
        }

        /// <summary>
        /// Parameterized Constructor for CollaboratorManager
        /// </summary>
        /// <param name="repository"></param>
        public CollaboratorManager(ICollaboratorRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the Collaborator
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task AddCollaborator(CollaboratorModel model)
        {
            await this.repository.AddCollaborator(model);
        }

        /// <summary>
        /// Deletes the Collaborator
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteCollaborator(int id)
        {
            await this.repository.DeleteCollaborator(id);
        }
    }
}