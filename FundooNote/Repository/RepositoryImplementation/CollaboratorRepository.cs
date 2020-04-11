using Model.Collaborators;
using Repository.AccountContext;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImplementation
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
    }

    
}
