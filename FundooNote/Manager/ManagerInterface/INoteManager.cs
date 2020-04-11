using Model.Notes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
   public interface INoteManager
    {
        Task AddNotes(NotesModel notes);
         List<NotesModel> GetNotes(); 
         List<NotesModel> GetNote(int id); 
        Task Delete(int id);
        Task Update(int nodeId, string tittle, string description, string changeColor, string addImg);
        Task UploadImg(int id, string img);
         Task<string> Color(int id, string color); 
        Task<string> Ispin(int id);
        Task Unpin(int id);
        Task IsArchive(int id);
        Task UnArchive(int id);
        List<NotesModel> GetArcheive();
        Task Reminder(int id, string Reminder);
        Task Trash(int id);
        List<NotesModel> GetTrashList();
        Task RemoveTrash(int id);
        Task Restore(int id);
        Task RestoreAll();
    }
}
