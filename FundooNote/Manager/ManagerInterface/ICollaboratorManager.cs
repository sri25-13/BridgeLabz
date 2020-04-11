using Model.Collaborators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerInterface
{
   public interface ICollaboratorManager
    {
        Task AddCollaborator(CollaboratorModel model);
        Task DeleteCollaborator(int id);
    }
}
