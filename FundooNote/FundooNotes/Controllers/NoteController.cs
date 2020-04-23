using FundooManager.ManagerInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FundooModel.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooNote.Controllers
{
    [Authorize]
    public class NoteController : ControllerBase
    {
        private readonly INoteManager noteManager;
        public NoteController(INoteManager noteManager)
        {
            this.noteManager = noteManager;
        }
        [HttpPost]
        [Route("AddNote")]
        public async Task<IActionResult> AddNotes([FromBody]NotesModel noteModel)
        {
            try
            {
                await this.noteManager.AddNotes(noteModel);
                return Ok(noteModel);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("getallnotes")]
        public IActionResult GetNotes()
        {
            try
            {
                List<NotesModel> n = this.noteManager.GetNotes();
                return Ok(n);
            }
            catch (Exception f)
            {
                return BadRequest(f.Message);
            }
        }
        [HttpGet]
        [Route("getnote")]
        public IActionResult Get(int id)
        {
            try
            {
                List<NotesModel> notes = this.noteManager.GetNote(id);
                return Ok(notes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(int id, string tittle, string Decription, string color, string img)
        {
            try
            {
                await this.noteManager.Update(id, tittle, Decription, color, img);
                return Ok(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                var a = this.noteManager.Delete(id);
                return Ok(a);
            }
            catch (Exception g)
            {
                return BadRequest(g.Message);
            }
        }
        [HttpPut]
        [Route("UploadImage")]
        public async Task<IActionResult> Uploadimg(int id, string img)
        {
            try
            {
                await this.noteManager.UploadImg(id, img);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("ChangeColor")]
        public async Task<IActionResult> Color(int id, string color)
        {
            try
            {
                var result = await this.noteManager.Color(id, color);
                return Ok(new { result });
            }
            catch (Exception d)
            {
                return BadRequest(d.Message);
            }
        }
        [HttpPut]
        [Route("Ispin")]
        public async Task<IActionResult> Ispin(int id)
        {
            try
            {
                await this.noteManager.Ispin(id);
                return Ok();
            }
            catch (Exception d)
            {
                return BadRequest(d.Message);
            }
        }
        [HttpPut]
        [Route("Unpin")]
        public async Task<IActionResult> Unpin(int id)
        {
            try
            {
                await this.noteManager.Unpin(id);
                return Ok();
            }
            catch (Exception h)
            {
                return BadRequest(h.Message);
            }
        }
        [HttpPut]
        [Route("IsArchive")]
        public async Task<IActionResult> IsArchive(int id)
        {
            try
            {
                await this.noteManager.IsArchive(id);
                return Ok();
            }
            catch (Exception h)
            {
                return BadRequest(h.Message);
            }
        }
        [HttpPut]
        [Route("UnArchive")]
        public async Task<IActionResult> UnArchive(int id)
        {
            try
            {
                await this.noteManager.UnArchive(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("GetArchive")]
        public IActionResult Getarchive()
        {
            try
            {
                var result = this.noteManager.GetArcheive();
                return Ok(new { result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("Reminder")]
        public async Task<IActionResult> Reminder(int id, string Reminder)
        {
            try
            {
                await this.noteManager.Reminder(id, Reminder);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("Trash")]
        public async Task<IActionResult> Trash(int id)
        {
            try
            {
                await this.noteManager.Trash(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("RemoveTrash")]
        public async Task<IActionResult> RemoveTrash(int id)
        {
            try
            {
                await this.noteManager.RemoveTrash(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("trashlist")]
        public List<NotesModel> TrashList()
        {
            return this.noteManager.GetTrashList();
        }
        [HttpGet]
        [Route("RestoreallTrash")]
        public async Task<IActionResult> RestoreAllTrash()
        {
            try
            {
                await this.noteManager.RestoreAll();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("restore")]
        public async Task<IActionResult> Restore(int id)
        {
            try
            {
                await this.noteManager.Restore(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}

