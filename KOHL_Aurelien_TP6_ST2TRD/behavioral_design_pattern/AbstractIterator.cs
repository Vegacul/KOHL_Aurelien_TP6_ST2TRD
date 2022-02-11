using System;
using System.Collections.Generic;
using System.Text;

namespace behavioral_design_pattern
{
    interface AbstractIterator
    {
        Student First();
        Student Next();
        bool IsCompleted { get; }
    }
}