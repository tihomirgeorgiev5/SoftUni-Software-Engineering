using NavalVessels.Models.Contracts;
using NavalVessels.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Repositories
{
    internal class VesselRepository : IRepository<IVessel>
    {
        private HashSet<IVessel> models;

        public VesselRepository()
        {
            models = new HashSet<IVessel>();
        }

        public IReadOnlyCollection<IVessel> Models => models;

        public void Add(IVessel model)
        {
            this.models.Add(model);
        }

        public IVessel FindByName(string name)
        {
            return this.models.FirstOrDefault(d => d.Name == name);
        }

        public bool Remove(IVessel model)
        {
            return this.models.Remove(model);
        }
    }
}
