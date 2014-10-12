using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck2CSharp
{
    /// <summary>
    /// Increment the data at the current position ( + command )
    /// </summary>
    class IncrementDS
    {
        public int Count = 1;

        public override string ToString()
        {
            if (this.Count == 1)
            {
                return "array[ptr]++;";
            }
            else
            {
                return string.Format("array[ptr]+={0};", this.Count);
            }
        }
    }

    /// <summary>
    /// Decrement the data at the current position ( - command )
    /// </summary>
    class DecrementDS
    {
        public int Count = 1;

        public override string ToString()
        {
            if (this.Count == 1)
            {
                return "array[ptr]--;";
            }
            else
            {
                return string.Format("array[ptr]-={0};", this.Count);
            }
        }
    }

    /// <summary>
    /// > command
    /// </summary>
    class IncrementPC 
    {
        public int Count = 1;

        public override string ToString()
        {
            if (this.Count == 1)
            {
                return "++ptr;";
            }
            else
            {
                return string.Format("ptr+={0};", this.Count);
            }
        }
    }

    /// <summary>
    /// < command
    /// </summary>
    class DecrementPC 
    {
        public int Count = 1;

        public override string ToString()
        {
            if (this.Count == 1)
            {
                return "--ptr;";
            }
            else
            {
                return string.Format("ptr-={0};", this.Count);
            }
        }
    }
}
