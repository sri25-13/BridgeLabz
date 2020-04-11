// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooNote.Controllers
{
    using Manager.ManagerImplementation;
    using Manager.ManagerInterface;
    using Microsoft.AspNetCore.Mvc;
    using Model.Label;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Controller for Label
    /// </summary>
    public class LabelController : ControllerBase
    {
        private readonly ILabelManager labelManager;
        public LabelController(ILabelManager label)
        {
            labelManager = label;
        }

        /// <summary>
        /// Adding label
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddLabel")]
        public async Task<IActionResult> AddLabel(string name, int id)
        {
            try
            {
                await this.labelManager.AddLabel(name, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Updating the label
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("updatelabel")]
        public async Task<IActionResult> Update(int id, string name)
        {
            try
            {
                await this.labelManager.UpdateLabel(name, id);
                return Ok();
            }
            catch (Exception d)
            {
                return this.BadRequest(d.Message);
            }
        }

        /// <summary>
        /// Deletes the Label
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Deletelabel")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await this.labelManager.DeleteLabel(id);
                return Ok();
            }
            catch (Exception d)
            {
                return this.BadRequest(d.Message);
            }
        }

        /// <summary>
        /// Gets all the labels.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/getalllabels")]
        public IActionResult GetAllLabels()
        {
            try
            {
                List<Labelmodel> labelmodels = this.labelManager.GetAllLabels();
                return Ok(new { labelmodels });
            }
            catch (Exception d)
            {
                return this.BadRequest(d.Message);
            }
        }
    }
}