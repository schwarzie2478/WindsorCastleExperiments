using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindsorCastleExperiments.Interfaces
{
    public interface IRoot
    {
        IObjectBuilder ObjectBuilder { get; set; }
        ICommandManager CommandManager { get; set; }
        IGlobalParameterTable GlobalParameterTable { get; set; }
        IResourceManager ResourceManager { get; set; }
        IIOMapper  IOMapper { get; set; }
    }
}
