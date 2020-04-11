using Manager.ManagerInterface;
using Model.Collaborators;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ManagerImplementation
{
    public class CollaboratorManager : ICollaboratorManager
    {
        private readonly ICollaboratorRepository repository;

        public CollaboratorManager()
        {
        }

        public CollaboratorManager(ICollaboratorRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddCollaborator(CollaboratorModel model)
        {
            await this.repository.AddCollaborator(model);
        }

        public async  Task DeleteCollaborator(int id)
        {
            await this.repository.DeleteCollaborator(id);
        }
    }
}
