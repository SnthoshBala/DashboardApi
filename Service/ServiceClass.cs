using DashboardApi.Model;
using DashboardApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Service
{
    public class ServiceClass : IService
    {
        IAccelerator _accRepo;

        public ServiceClass()
        {
        }

        public List<Accelerator> getAllAccelerators()
        {
            _accRepo = new RepoClass();
            return _accRepo.getAllAccelerators();
        }
    }
}
