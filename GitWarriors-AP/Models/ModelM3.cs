using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWarriors_AP.Models
{
    internal class ModelM3
    {
        private static GitwarriorsContext modelProjetM3;

        public static GitwarriorsContext ModelProjetM3 { get => modelProjetM3; set => modelProjetM3 = value; }

        public static void init()
        {
            ModelM3 modelProjetM3 = new ModelM3();
        }
    }
}
