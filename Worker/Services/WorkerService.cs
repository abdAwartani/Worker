using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Worker.Data;

namespace Worker.Services
{
    public class WorkerService : IWorkerService

    {
        private readonly WorkerContext _workerContext;

        public WorkerService(WorkerContext workerContext)
        {
            _workerContext = workerContext;
        }

        public IEnumerable<Bundle> GetAllBundles()
        {
            return _workerContext.Bundles.ToList();
        } 
        public IEnumerable<Bundle> GetAllBundlesWithDetails()
        {
            return _workerContext.Bundles.Include(d=>d.BundleDetails).ToList();
        }
        public Bundle GetBundle(int id)
        {
            return _workerContext.Bundles.FirstOrDefault(b => b.Id == id);
        }

        public Bundle GetBundleWithDetails(int id)
        {
            return _workerContext.Bundles.Include(d=>d.BundleDetails).FirstOrDefault(b => b.Id == id);
        }

        public void AddBundle(Bundle bundle)
        {
            _workerContext.Add(bundle);
            _workerContext.SaveChanges();
        }

        public void RemoveBundle(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBundle(int id)
        {
            throw new NotImplementedException();
        }

        public void AddBundleDetails(BundleDetail bundleDet)
        {
            _workerContext.Add(bundleDet);
            _workerContext.SaveChanges();
        }
    }

}
