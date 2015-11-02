using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrbitCalculator
{
    //A KSP body that has a gravitational Affect. These bodies cannot have their orbit changed per KSP.
    public class KSPGravitationalBody : KSPBody, IRailedBody
    {
        int equitorialRadius;
        double standardGravitataionalParameter;
        int soi;
        int rotationalPeriod;
        int mass;
        int atmosphereicHeight;
    }
}