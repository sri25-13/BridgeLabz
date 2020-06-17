// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooManager.ManagerInterface
{
    using FundooModel.Notes;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// interface for NoteManager
    /// </summary>
    public interface INoteManager
    {
        /// <summary>
        /// Adds the Notes
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        Task AddNotes(NotesModel notes);

        /// <summary>
        /// Get akk the notes
        /// </summary>
        /// <returns></returns>
        List<NotesModel> GetNotes();

        /// <summary>
        /// Gives the givesn note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<NotesModel> GetNote(int id);

        /// <summary>
        /// Deletes the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(int id);

        /// <summary>
        /// Updates the note
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="tittle"></param>
        /// <param name="description"></param>
        /// <param name="changeColor"></param>
        /// <param name="addImg"></param>
        /// <returns></returns>
        Task Update(NotesModel notesModel);

        /// <summary>
        /// Uploads the image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        Task UploadImg(int id, string img);

        /// <summary>
        /// Changes the color
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        Task<string> Color(int id, string color);

        /// <summary>
        /// pins the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<string> Ispin(int id);

        /// <summary>
        /// unpin the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Unpin(int id);

        /// <summary>
        /// Archeives the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task IsArchive(int id);

        /// <summary>
        /// Removes from Archeive
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task UnArchive(int id);

        /// <summary>
        /// Gives the Archeivedlist
        /// </summary>
        /// <returns></returns>
        List<NotesModel> GetArcheive();

        /// <summary>
        /// Adds the Reminder
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Reminder"></param>
        /// <returns></returns>
        Task Reminder(int id, string Reminder);
        Task DeleteReminder(int id);
        /// <summary>
        /// Moves to Trash
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Trash(int id);
        Task<IQueryable<NotesModel>> Search(string searchParameter);

        /// <summary>
        /// Gives the trashlist
        /// </summary>
        /// <returns></returns>
        List<NotesModel> GetTrashList();

        /// <summary>
        /// Removes the note from trash
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveTrash(int id);

        /// <summary>
        /// Restores the given note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Restore(int id);

        /// <summary>
        /// Restores all the notes
        /// </summary>
        /// <returns></returns>
        Task RestoreAll();
        List<NotesModel> GetReminders();
    }
}
