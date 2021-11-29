using DashboardApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Service
{
    public interface IService
    {
        public List<Accelerator> getAllAccelerators();
    }
}
