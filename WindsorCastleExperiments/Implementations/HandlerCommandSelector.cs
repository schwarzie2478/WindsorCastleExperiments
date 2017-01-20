using Castle.MicroKernel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindsorCastleExperiments.Implementations
{
    public class HandlerCommandSelector : IHandlerSelector
    {
        private string _originalType;//= "LoadTestAssembly.StandardWorker";
        private string _deferredType;// = "LoadTestAssembly.BusyWorker";
        public HandlerCommandSelector(string originalType,string deferredType)
        {
            _originalType = originalType;
            _deferredType = deferredType;
        }
        public bool HasOpinionAbout(string key, Type service)
        {
            if (key == _originalType) return true;

            return false;
        }

        public IHandler SelectHandler(string key, Type service, IHandler[] handlers)
        {
            foreach (var handler in handlers)
            {
                if(handler.ComponentModel.Name == _deferredType)
                {
                    return handler;
                }
            }
            //Should never get here
            System.Diagnostics.Debug.Assert(false);
            return null;
        }
    }
}
