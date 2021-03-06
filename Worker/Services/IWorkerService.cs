using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Data;

namespace Worker.Services
{
    public interface IWorkerService
    {
        IEnumerable<Bundle> GetAllBundles();
        IEnumerable<Bundle> GetAllBundlesWithDetails();
        Bundle GetBundle(int id);
        Bundle GetBundleWithDetails(int id);
        void AddBundle(Bundle bundle);
        void RemoveBundle(int id);
        void UpdateBundle(int id);
        void AddBundleDetails(BundleDetail bundleDet);
    }
}
