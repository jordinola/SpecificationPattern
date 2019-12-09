using Specification.ClientAdministrator.DataSource;
using Specification.ClientAdministrator.Models;
using System;
using System.Collections.Generic;

namespace Specification.ClientAdministrator.Repository
{
    public class ClientRepository
    {
        private readonly List<Client> _data;

        public ClientRepository()
        {
            _data = new ClientDataSource().GetClientsData();
        }


    }
}
