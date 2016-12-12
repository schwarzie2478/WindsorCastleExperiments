using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindsorCastleExperiments.Interfaces
{
    public interface ICommand<Tin, TOut>
    {
        Tin Target { get; set; }
        TOut Result { get; set; }
        bool IsSucceeded { get; set; }
        bool HasExecuted { get; set; }
        bool ExecuteAction();
        void ExecuteAction<T1, T2>();
    }
}
