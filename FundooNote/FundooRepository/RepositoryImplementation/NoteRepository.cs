using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using FundooModel.Notes;
using FundooRepository.FundooContext;
using FundooRepository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.RepositoryImplementation
{
    public class NoteRepository : INoteRepository
    {
        private readonly Context context;
        public NoteRepository(Context context)
        {
            this.context = context;
        }

        public NoteRepository()
        {
        }

        public Task AddNotes(NotesModel notesModel)
        {
            NotesModel notesModel1 = new NotesModel()
            {
                NoteId = notesModel.NoteId,
                Email = notesModel.Email,
                Title = notesModel.Title,
                Description = notesModel.Description,
                Createdate1 = notesModel.Createdate1,
                Modifieddate = notesModel.Modifieddate,
                Archeive = notesModel.Archeive,
                Pin = notesModel.Pin,
                ChangeColor = notesModel.ChangeColor,
                AddImg = notesModel.AddImg,
                Trash = notesModel.Trash
            };
            this.context.Notes.Add(notesModel1);
            var s = Task.Run(() => context.SaveChanges());
            return s;
        }
        public Task Delete(int id)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id).FirstOrDefault();
            if (result != null)
            {
                this.context.Notes.Remove(result);
                return Task.Run(() => context.SaveChanges());
            }
            return default;
        }
        public List<NotesModel> GetNotes()
        {
            return this.context.Notes.ToList();
        }
        public List<NotesModel> GetNote(int id)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                return this.context.Notes.Where(op => op.NoteId == id).ToList();
            }
            return null;
        }
        public Task Update(int id, string tittle, string Decription, string color, string img)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                result.Title = tittle;
                result.Description = Decription;
                result.ChangeColor = color;
                result.AddImg = img;
                this.context.Notes.Update(result);
                return Task.Run(() => context.SaveChanges());
            }
            return default;
        }
        public Task UploadImg(int id, string img)
        {
            var file = this.context.Notes.Where(op => op.NoteId == id).SingleOrDefault();
            if (file != null)
            {
                var Filename = img;
                Account account = new Account("dp0053lac", "599234279678327", "zimXDzrf5DAW_L90NebMgGOJw6o");
                Cloudinary cloudinary = new Cloudinary(account);
                var UploadFile = new ImageUploadParams()
                {
                    File = new FileDescription(Filename)
                };
                var Result = cloudinary.Upload(UploadFile);
                file.AddImg = Result.Uri.ToString();
                var res = Task.Run(() => context.SaveChanges());
                return res;
            }
            return default;
        }
        public Task Color(int id, string color)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                result.ChangeColor = color;
                this.context.Notes.Update(result);
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;
        }

        public Task Ispin(int id)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                result.Pin = true;
                this.context.Notes.Update(result);
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;
        }
        public Task Unpin(int id)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                result.Pin = false;
                this.context.Notes.Update(result);
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;
        }
        public Task IsArchive(int id)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                result.Archeive = true;
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;
        }
        public Task UnArchive(int id)
        {
            var result = this.context.Notes.Where(op => op.NoteId == id && op.Archeive == true).SingleOrDefault();
            if (result != null)
            {
                result.Archeive = false;
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;
        }
        public Task Reminder(int id, string Reminder)
        {
            var result = this.context.Notes.Where(OP => OP.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                result.Reminder = Reminder.ToString();
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;
        }
        public List<NotesModel> GetArcheive()
        {
            var a = this.context.Notes.Where(op => op.Archeive == true).SingleOrDefault();
            if (a != null)
            {
                return this.context.Notes.Where(op => op.Archeive == true).ToList();
            }
            return default;
        }

        public Task Trash(int id)
        {
            var result = this.context.Notes.Where(note => note.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                result.Trash = true;
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;

        }
        public List<NotesModel> TrashList()
        {

            var result = this.context.Notes.Where(list => list.Trash == true).SingleOrDefault();
            if (result != null)
            {
                return this.context.Notes.Where(list => list.Trash == true).ToList<NotesModel>();
            }
            return null;

        }
        public Task RemoveTrash(int id)
        {
            var result = this.context.Notes.Where(note => note.NoteId == id).SingleOrDefault();
            if (result != null)
            {
                this.context.Notes.Remove(result);
            }
            return null;
        }
        public Task Restore(int id)
        {
            var data = this.context.Notes.Where(op => op.NoteId == id && op.Trash == true).SingleOrDefault();
            if (data != null)
            {
                data.Trash = false;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }
        public Task RestoreAll()
        {
            var result = from NotesModel in context.Notes where NotesModel.Trash == true select NotesModel;
            if (result != null)
            {
                foreach (var res in result)
                {
                    res.Trash = false;
                }
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }
        public IQueryable GetnotesAndLabels(int Id,string email)
        {
            var result = context.Notes.Where(a => a.NoteId == Id&& a.Email==email).Join(context.Labels,
                Notes => Notes.NoteId,
                Labels => Labels.LabelId,
                (Notes, Labels) => new
                {
                    NotesID = Notes.NoteId,
                    NotesDescription = Notes.Description,
                    NotesTitle = Notes.Title,
                    LabelID = Labels.LabelId,
                    LabelNAME = Labels.LabelName
                });
            return result;
                
        }
    }
}

