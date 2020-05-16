using System;
using System.Collections.Generic;
using System.Text;

namespace abstractExerciseLes
{
    public abstract class Organisme
    {
        public abstract string Sort { get; } // do not need set as we set it in overridde
        public string Name { get; set; }

    }
}
