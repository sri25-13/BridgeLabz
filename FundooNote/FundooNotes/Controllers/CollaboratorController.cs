// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooNote.Controllers
{
    using FundooManager.ManagerInterface;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using FundooModel.Collaborators;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Controller class for Collaborator
    /// </summary>
   /*  [Authorize]*/
    public class CollaboratorController : ControllerBase
    {
        private readonly ICollaboratorManager collaboratorManager;

        /// <summary>
        /// Parameterized Constructor for CollaboratorController
        /// </summary>
        /// <param name="collaboratorManager"></param>
        public CollaboratorController(ICollaboratorManager collaboratorManager)
        {
            this.collaboratorManager = collaboratorManager;
        }

        /// <summary>
        /// Adds the Collaborator
        /// </summary>
        /// <param name="collaboratorModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/addcollaborator")]
        public async Task<IActionResult> AddCollaborator([FromBody]CollaboratorModel collaboratorModel)
        {
            try
            {
                await this.collaboratorManager.AddCollaborator(collaboratorModel);
                return this.Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the Collaborator
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/DeleteCollaborator")]
        public async Task<IActionResult> DeleteCollaborator(int id)
        {
            try
            {
                await this.collaboratorManager.DeleteCollaborator(id);
                return this.Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
        [HttpDelete]
        [Route("api/delnotewith collab")]
        public async Task<IActionResult> Delnotewithcollab(string email,int id)
        {
            try
            {
                await this.collaboratorManager.DelNotewithCollab(email,id);
                return this.Ok();
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
