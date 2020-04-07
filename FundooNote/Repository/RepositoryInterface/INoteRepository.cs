using Model.Notes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
    interface INoteRepository
    {
        Task<string> AddNote(NotesModel noteModel); 
        Task<int> DeleteNote(int NoteID);
        Task<string> UpdateNote(NotesModel notemodel);
        List<NotesModel> GetNote(int NoteID);
        Task Trash(int noteid); 
        List<NotesModel> GetTrash();
        Task RemoveTrash(int NoteId);
        Task RestoreTrash(int NoteId);
        Task RestoreAllTrash(int NoteId);
        int Remainder(int NoteId);
        Task Archieve(int NoteId);
        Task UnArchieve(int NoteId); 
        List<NotesModel> GetArchieveList(); 

    }
}
