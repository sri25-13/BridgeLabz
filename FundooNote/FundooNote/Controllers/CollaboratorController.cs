using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;
using Model.Collaborators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooNote.Controllers
{
    public class CollaboratorController :ControllerBase
    {
        private readonly ICollaboratorManager collaboratorManager;
        public CollaboratorController(ICollaboratorManager collaboratorManager)
        {
            this.collaboratorManager = collaboratorManager;
        }
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
    }
}
