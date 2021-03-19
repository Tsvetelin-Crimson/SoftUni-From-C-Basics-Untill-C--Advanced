using System;

namespace Nether_Realms
{
    class NetherR
    {
        static void Main(string[] args)
        {
            //headache with regex
            string healthPatern = @"(?<health>[^\d\+\-\/\.\*])";
            string addOrRemoveDamagePatern = @"([\-|\+]\d+\.?\d*)";
        }
    }
}
