using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForInterview.ProxyPattern
{
    public interface IComponentPrice
    {
        decimal CpuPrice { get; }
        decimal RamPrice { get; }
        decimal SsdPrice { get; }
    }
}
