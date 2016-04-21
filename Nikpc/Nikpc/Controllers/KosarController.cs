using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    class KosarController : ITermekListaMegtekintesKezelo, ITermekMegtekintesKezelo {

        public KosarController()
        {
            
        }

		public void Ertekeles(int ertek, string szoveg){

		}

		public void KepMegnyitas(Termek termek){

		}

		public void Kereses(string termekNev, string termekKategoria, int arAlso, int arFelso, bool raktaron){

		}

		/*public void ITermekListaMegtekintesKezelo.KosarbaHelyez(Termek termek){

		}

		public void ITermekListaMegtekintesKezelo.KosarbolTorol(Termek termek){

		}*/

		public void Rendezes(string rendezesiParameter, bool novekvo){

		}

        /*public void ITermekMegtekintesKezelo.KosarbaHelyez(Termek termek)
        {

        }

		public void ITermekMegtekintesKezelo.KosarbolTorol(Termek termek){

		}*/
	}

}
