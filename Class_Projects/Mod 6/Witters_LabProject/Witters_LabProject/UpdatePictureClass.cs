using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witters_LabProject
{
    public class UpdatePictureClass
    {
        public System.Drawing.Bitmap GetPicture(string pictureName)
        {
            switch (pictureName)
            {
                case "Bablizz":
                    return Properties.Resources.Bablizz;
                case "BlackNakk":
                    return Properties.Resources.BlackNakk;
                case "Cactuar":
                    return Properties.Resources.Cactuar;
                case "Chocobo":
                    return Properties.Resources.Chocobo;
                case "Fritt":
                    return Properties.Resources.Fritt;
                case "Moogle":
                    return Properties.Resources.Moogle;
                case "Moomba":
                    return Properties.Resources.Moomba;
                case "Mu":
                    return Properties.Resources.Mu;
                case "Pupu":
                    return Properties.Resources.Pupu;
                case "Quacho":
                    return Properties.Resources.Quacho;
                case "ReaverMu":
                    return Properties.Resources.ReaverMu;
                case "Serafie":
                    return Properties.Resources.Serafie;
                case "Tama":
                    return Properties.Resources.Tama;
                case "WhiteNakk":
                    return Properties.Resources.WhiteNakk;
                case "Zapt":
                    return Properties.Resources.Zapt;
                default:
                    return Properties.Resources.TripleTriadBack;
            }
        }
    }
}
