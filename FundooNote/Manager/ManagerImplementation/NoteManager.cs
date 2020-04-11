using Manager.ManagerInterface;
using Model.Notes;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImplementation
{
   public class NoteManager :INoteManager
    {
        private readonly INoteRepository noteRepository;
        public NoteManager(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository;
        }

        public NoteManager()
        {
        }

        public async Task AddNotes(NotesModel notesModel) 
        {
            await this.noteRepository.AddNotes(notesModel);
        }
        public async Task<string> Color(int id, string color) 
        {
            await this.noteRepository.Color(id, color);
            return "color added";
        }
        public async Task Delete(int id) 
        {
            await this.noteRepository.Delete(id); 
        }
        public List<NotesModel> GetArcheive()
        { 
            return this.noteRepository.GetArcheive(); 
        }
        public List<NotesModel> Trashlist()
        {
            return this.noteRepository.TrashList();
        }
        public List<NotesModel> GetNote(int id)
        {
            var a = this.noteRepository.GetNote(id); 
            return a;
        }
        public List<NotesModel> GetNotes()
        { 
            return this.noteRepository.GetNotes();
        }
        public Task IsArchive(int id)
        {
            return this.noteRepository.IsArchive(id);
        }
        public async Task<string> Ispin(int id)
        {
            await this.noteRepository.Ispin(id);
            return "pinned";
            
        }
        public Task Reminder(int id, string Reminder) 
        {
           return this.noteRepository.Reminder(id, Reminder);
            

        }
        public  Task Restore(int id)
        {
            return  this.noteRepository.Restore(id);
        }
        public Task UnArchive(int id) 
        {
            return this.noteRepository.UnArchive(id);
        }
        public  Task Unpin(int id)
        {
            return this.noteRepository.Unpin(id);
        }
        public async Task Update(int noteId,string title,string description,string changeColor,string addImg)
        {
            await this.noteRepository.Update(noteId, title, description, changeColor, addImg);
        }
        public async Task UploadImg(int id,string img)
        {
            await this.noteRepository.UploadImg(id, img);
        }

        public Task Trash(int id)
        {
            return this.noteRepository.Trash(id);
        }

        public List<NotesModel> GetTrashList()
        {
            return this.noteRepository.TrashList();
        }

        public Task RemoveTrash(int id)
        {
            return this.noteRepository.RemoveTrash(id);
        }

        public Task RestoreAll()
        {
            return this.noteRepository.RestoreAll();
        }
    }
}
