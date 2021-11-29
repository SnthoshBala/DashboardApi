using DashboardApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Repository
{
    public interface IAccelerator
    {
        public List<Accelerator> getAllAccelerators();
    }
}
