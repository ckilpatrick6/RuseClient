using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Net
{
    public interface IStatusListener
    {
        void updateStatus(Status status);
    }
}
