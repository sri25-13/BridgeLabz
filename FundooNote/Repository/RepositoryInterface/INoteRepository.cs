using Model.Notes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
   public interface INoteRepository
    {
        Task AddNotes(NotesModel notesModel);
        List<NotesModel> GetNotes();
        List<NotesModel> GetNote(int id);
        Task Update(int id, string tittle, string Decription, string color, string img);
        Task Delete(int id);
        Task UploadImg(int id, string img);
        Task Color(int id, string color);
        Task Ispin(int id);
        Task Unpin(int id);
        Task IsArchive(int id);
        Task UnArchive(int id);
        Task Reminder(int id, string Reminder);
        List<NotesModel> GetArcheive();
        Task Trash(int id);
        List<NotesModel> TrashList();
        Task RemoveTrash(int id);
        Task Restore(int id);
        Task RestoreAll();

    }
}
