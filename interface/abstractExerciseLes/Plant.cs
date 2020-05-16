using System;
using System.Collections.Generic;
using System.Text;

namespace abstractExerciseLes
{
    public class Plant : Organisme
    {
        public virtual ConsoleColor Color { get; } // virtual is optional to inherete while abstract MUST be inherete

        public override string Sort => "Organism";
    }
}
