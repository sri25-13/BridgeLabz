// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooManager.ManagerInterface;
using FundooModel.Notes;
using FundooRepository.RepositoryInterface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooManager.ManagerImplementation
{
    using FundooManager.ManagerInterface;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for NoteManager
    /// </summary>
    public class NoteManager : INoteManager
    {
        private readonly INoteRepository noteRepository;

        /// <summary>
        /// Parameterized constructor for NoteManager
        /// </summary>
        /// <param name="noteRepository"></param>
        public NoteManager(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository;
        }

        public NoteManager()
        {
        }

        /// <summary>
        /// Adds the Notes
        /// </summary>
        /// <param name="notesModel"></param>
        /// <returns></returns>
        public async Task AddNotes(NotesModel notesModel)
        {
            await this.noteRepository.AddNotes(notesModel);
        }

        /// <summary>
        /// Changes the color
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<string> Color(int id, string color)
        {
            await this.noteRepository.Color(id, color);
            return "color added";
        }

        /// <summary>
        /// Deletes the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            await this.noteRepository.Delete(id);
        }

        /// <summary>
        /// gets Archeived data
        /// </summary>
        /// <returns></returns>
        public List<NotesModel> GetArcheive()
        {
            return this.noteRepository.GetArcheive();
        }

        /// <summary>
        /// Gives the TrashList
        /// </summary>
        /// <returns></returns>
        public List<NotesModel> Trashlist()
        {
            return this.noteRepository.TrashList();
        }

        /// <summary>
        /// Gives the required Note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<NotesModel> GetNote(int id)
        {
            var a = this.noteRepository.GetNote(id);
            return a;
        }

        /// <summary>
        /// Gets all the NotesList
        /// </summary>
        /// <returns></returns>
        public List<NotesModel> GetNotes()
        {
            return this.noteRepository.GetNotes();
        }

        /// <summary>
        /// Archeives the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task IsArchive(int id)
        {
            return this.noteRepository.IsArchive(id);
        }

        /// <summary>
        /// Pins the Note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<string> Ispin(int id)
        {
            await this.noteRepository.Ispin(id);
            return "pinned";
        }

        /// <summary>
        /// Adds the Reminder
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Reminder"></param>
        /// <returns></returns>
        public Task Reminder(int id, string Reminder)
        {
            return this.noteRepository.Reminder(id, Reminder);
        }

        /// <summary>
        /// Restores the given Note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Restore(int id)
        {
            return this.noteRepository.Restore(id);
        }

        /// <summary>
        /// Unarcheives the Notes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task UnArchive(int id)
        {
            return this.noteRepository.UnArchive(id);
        }

        /// <summary>
        /// Unpin the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Unpin(int id)
        {
            return this.noteRepository.Unpin(id);
        }

        /// <summary>
        /// Updates the Notes
        /// </summary>
        /// <param name="noteId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="changeColor"></param>
        /// <param name="addImg"></param>
        /// <returns></returns>
        public async Task Update(int noteId, string title, string description, string changeColor, string addImg)
        {
            await this.noteRepository.Update(noteId, title, description, changeColor, addImg);
        }

        /// <summary>
        /// Uploads the image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public async Task UploadImg(int id, string img)
        {
            await this.noteRepository.UploadImg(id, img);
        }

        /// <summary>
        /// moves the note to trash
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Trash(int id)
        {
            return this.noteRepository.Trash(id);
        }

        /// <summary>
        /// gives the trashlist
        /// </summary>
        /// <returns></returns>
        public List<NotesModel> GetTrashList()
        {
            return this.noteRepository.TrashList();
        }

        /// <summary>
        /// removes from the trash
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task RemoveTrash(int id)
        {
            return this.noteRepository.RemoveTrash(id);
        }

        /// <summary>
        /// restores all the notes
        /// </summary>
        /// <returns></returns>
        public Task RestoreAll()
        {
            return this.noteRepository.RestoreAll();
        }
    }
}