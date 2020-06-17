using FundooModel.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.RepositoryInterface
{
    public interface INoteRepository
    {
        Task AddNotes(NotesModel notesModel);
        List<NotesModel> GetNotes();
        List<NotesModel> GetNote(int id);
        Task Update(NotesModel notesModel);
        Task Delete(int id);
        Task DeleteReminder(int id);
        Task UploadImg(int id, string img);
        Task Color(int id, string color);
        Task Ispin(int id);
        Task Unpin(int id);
        Task IsArchive(int id);
        Task UnArchive(int id);
        Task Reminder(int id, string Reminder);
        List<NotesModel> GetReminders();
        List<NotesModel> GetArcheive();
        Task Trash(int id);
        List<NotesModel> TrashList();
        Task RemoveTrash(int id);
        Task Restore(int id);
        Task RestoreAll();
        Task<IQueryable<NotesModel>> Search(string searchParameter);

    }
}

