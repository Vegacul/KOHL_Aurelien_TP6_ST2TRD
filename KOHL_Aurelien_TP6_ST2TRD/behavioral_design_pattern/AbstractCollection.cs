using System;
using System.Collections.Generic;
using System.Text;

namespace behavioral_design_pattern
{
    interface AbstractCollection
    {
        Iterator CreateIterator();
    }
}