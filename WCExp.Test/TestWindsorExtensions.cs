using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCExp.Test
{
    public static class TestWindsorExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// 
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="componentRegistration"></param>
        /// <returns></returns>
        public static ComponentRegistration<T> OverridesExistingRegistration<T>(this ComponentRegistration<T> componentRegistration) where T : class
        {
            return componentRegistration
                                .Named(Guid.NewGuid().ToString())
                                .IsDefault();
        }
    }
}
