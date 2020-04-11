using Model.Collaborators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryInterface
{
    public interface ICollaboratorRepository
    {
        Task AddCollaborator(CollaboratorModel model);
        Task DeleteCollaborator(int id);
    }
}
