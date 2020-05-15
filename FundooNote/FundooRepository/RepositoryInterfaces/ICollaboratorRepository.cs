using FundooModel.Collaborators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.RepositoryInterface
{
    public interface ICollaboratorRepository
    {
        Task AddCollaborator(CollaboratorModel model);
        Task DeleteCollaborator(int id);
        Task<bool> DelNotewithCollab(string email,int id);
    }
}
