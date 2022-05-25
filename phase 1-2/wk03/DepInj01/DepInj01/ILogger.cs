using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInj01
{
    //make interface that the concrete logger classes would implement
    public interface ILogger
    {
        void Log(string message);
    }
}
