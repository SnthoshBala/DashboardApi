using DashboardApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Repository
{
    public class RepoClass : IAccelerator
    {
        public RepoClass()
        {
        }

        public readonly AcceleratorContext db;

        public List<Accelerator> getAllAccelerators()
        {
            using (var db = new AcceleratorContext())
            {
                return db.accelerators.ToList();
            }

        }

    }
}
