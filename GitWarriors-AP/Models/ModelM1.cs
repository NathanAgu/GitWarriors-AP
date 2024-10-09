using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWarriors_AP.Models
{
    internal class ModelM1
    {
        private static GitwarriorsContext modelProjetM1;

        public static void init()
        {
            modelProjetM1 = new GitwarriorsContext();
        }
    }
}
