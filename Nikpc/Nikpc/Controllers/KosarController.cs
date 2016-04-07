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
		/// 
		/// <param name="ertek"></param>
		/// <param name="szoveg"></param>
		public void Ertekeles(int ertek, string szoveg){

		}

		/// 
		/// <param name="termek"></param>
		public void KepMegnyitas(Termek termek){

		}

		/// 
		/// <param name="termekNev"></param>
		/// <param name="termekKategoria"></param>
		/// <param name="arAlso"></param>
		/// <param name="arFelso"></param>
		/// <param name="raktaron"></param>
		public void Kereses(string termekNev, string termekKategoria, int arAlso, int arFelso, bool raktaron){

		}

		/// 
		/// <param name="termek"></param>
		public void ITermekListaMegtekintesKezelo.KosarbaHelyez(Termek termek){

		}

		/// 
		/// <param name="termek"></param>
		public void ITermekListaMegtekintesKezelo.KosarbolTorol(Termek termek){

		}

		/// 
		/// <param name="rendezesiParameter"></param>
		/// <param name="novekvo"></param>
		public void Rendezes(string rendezesiParameter, bool novekvo){

		}

		/// 
		/// <param name="termek"></param>
		public void ITermekMegtekintesKezelo.KosarbaHelyez(Termek termek){

		}

		/// 
		/// <param name="termek"></param>
		public void ITermekMegtekintesKezelo.KosarbolTorol(Termek termek){

		}

	}//end KosárCtrl

}
