// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ICollaboratorManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooManager.ManagerInterface
{
    using FundooModel.Collaborators;
    using System.Collections.Generic;
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
        List<CollaboratorModel> getcollaborators();

        /// <summary>
        /// Deletes the Collaborator
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteCollaborator(int id);
        Task DelNotewithCollab(string email,int id);
    }
}
