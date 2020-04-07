using Manager.ManagerImplementation;
using Manager.ManagerInterface;
using Microsoft.AspNetCore.Mvc;
using Model.Label;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooNote.Controllers
{
    public class LabelController : ControllerBase
    {
        private readonly ILabelManager labelManager;
        public LabelController(ILabelManager label)
        {
            labelManager = label;
        }
        [HttpPost]
        [Route("AddLabel")]
        public async Task<IActionResult> AddLabel(string name,int id)
        {
            try
            {
                await this.labelManager.AddLabel(name,id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
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
        [HttpDelete]
        [Route("Deletelabel")]
        public async Task <IActionResult> Delete(int id)
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