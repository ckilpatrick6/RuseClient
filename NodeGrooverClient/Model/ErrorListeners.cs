using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NodeGrooverClient.Net
{
    public interface ErrorListener
    {
         void raiseError(String message);
    }
}
