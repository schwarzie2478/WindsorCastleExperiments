using Castle.Facilities.TypedFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindsorCastleExperiments.Implementations
{
    public class Command2Factory : DefaultTypedFactoryComponentSelector
    {
        protected override string GetComponentName(MethodInfo method, object[] arguments)
        {
            string componentName = null;
            if (arguments != null && arguments.Length > 0)
            {
                componentName = arguments[0] as string;
            }

            if (string.IsNullOrEmpty(componentName))
                componentName = base.GetComponentName(method, arguments);

            return componentName;
        }
    }
}
