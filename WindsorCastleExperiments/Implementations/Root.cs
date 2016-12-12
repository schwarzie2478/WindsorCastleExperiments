using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class Root : IRoot
    {
        public ICommandManager CommandManager
        {
            get; set;
        }

        public IGlobalParameterTable GlobalParameterTable
        {
            get; set;
        }

        public IIOMapper IOMapper
        {
            get; set;
        }

        public IObjectBuilder ObjectBuilder
        {
            get; set;
        }

        public IResourceManager ResourceManager
        {
            get; set;
        }
    }
}
