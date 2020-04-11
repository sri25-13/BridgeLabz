﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ICollaboratorManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.ManagerInterface
{
    using Model.Collaborators;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for CollaboratorManager
    /// </summary>
    public interface ICollaboratorManager
    {

        /// <summary>
        /// Adds the Collaborator
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task AddCollaborator(CollaboratorModel model);

        /// <summary>
        /// Deletes the Collaborator
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteCollaborator(int id);
    }
}