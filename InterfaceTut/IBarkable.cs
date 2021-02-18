using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTut {
    interface IBarkable {
        
        string Bark();
        string GetName();
        void SetName(string name);
    }
}
