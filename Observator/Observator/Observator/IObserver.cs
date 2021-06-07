using System;
using System.Collections.Generic;
using System.Text;

namespace Observator
{
    public interface IObserver
    {
        void update(string availability);
    }
}
