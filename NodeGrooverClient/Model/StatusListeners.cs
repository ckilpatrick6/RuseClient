using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NodeGrooverClient.Net
{
    public interface StatusListeners
    {
        void updateStatus(Status s);
    }
}
