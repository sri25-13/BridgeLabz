using FundooModel.Collaborators;
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
    public class CollaboratorRepository : ICollaboratorRepository
    {
        private readonly Context context;
        public CollaboratorRepository(Context context)
        {
            this.context = context;
        }
        public Task AddCollaborator(CollaboratorModel model)
        {
            try
            {
                bool result = this.context.Notes.Any(option => option.Email == model.SenderEmail && option.NoteId == model.NoteId);
                if (result)
                {
                    var user = this.context.Accountregister.Where(usr => usr.Email == model.ReceiverEmail).SingleOrDefault();
                    {
                        var addCollaborator = new CollaboratorModel()
                        {
                            NoteId = model.NoteId,
                            SenderEmail = model.SenderEmail,
                            ReceiverEmail = model.ReceiverEmail
                        };
                        context.Collaborators.Add(model);
                        var res = Task.Run(() => context.SaveChanges());
                        return res;
                    }
                }
                return default;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public Task DeleteCollaborator(int id)
        {
            try
            {
                var result = this.context.Collaborators.Where(op => op.Id == id).SingleOrDefault();
                if (result != null)
                {
                    this.context.Collaborators.Remove(result);
                    var res = Task.Run(() => context.SaveChanges());
                    return res;

                }
                return default;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        //delete all the notes with collabor reeiveremailid of xyz@gmail.com
        //get all the notes with collabor recemail of xyz@gmail.com
        //get all the notes which doesnt have image and with receiveremail of xyz@gmail.com
        //1.delete notes with collab receiveremail of xyz@gmail.com
        public async Task<bool> DelNotewithCollab(string email, int id)
        {
            var res = this.context.Collaborators.Where(a => a.ReceiverEmail == email && a.NoteId == id).SingleOrDefault();
            if (res != null)
            {
                this.context.Remove(res);
                if (await context.SaveChangesAsync() > 0)
                    return true;
            }
            return false;

        }
        //2.get all notes with collab receiveremail of xyz@gmail.com
        public List<NotesModel> getnoteswithcollab(string email)
        {
            List<NotesModel> notesModels = new List<NotesModel>();
            var res = this.context.Collaborators.Where(a => a.ReceiverEmail == email).ToList();
            if (res != null)
            {
                foreach (var result in res)
                {
                    notesModels.Add(context.Notes.FirstOrDefault(a => a.Email == result.SenderEmail && a.NoteId == result.NoteId));
                }
                return notesModels;
            }
            return null;
        }
        //3.get count of email having same password has xyz
        public int getEmailcount(string password)
        {
            var res = this.context.Accountregister.Where(a => a.Password == password).Select(a => a.Email);
            if (res != null)
            {
                return res.Count();
            }
            return 0;
        }
        //4.get notes which doesnt have image and with recieveremail of xyz@gmail.com
        public List<NotesModel> getnotes(string img, string email)
        {
            List<NotesModel> notesModels = new List<NotesModel>();
            var res = this.context.Collaborators.Where(a => a.ReceiverEmail == email).ToList();
            if (res != null)
            {
                foreach (var result in res)
                {
                    notesModels.Add(context.Notes.FirstOrDefault(a => a.AddImg == null));
                }
                return notesModels;
            }
            return null;
        }
        //5.get noteswith labels
        public IQueryable GetnoteswithLabels(int Id, string email)
        {
            var result = context.Notes.Where(a => a.NoteId == Id && a.Email == email)
                .Join(context.Labels,
                notes => notes.NoteId,
                Labels => Labels.NoteId,
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

