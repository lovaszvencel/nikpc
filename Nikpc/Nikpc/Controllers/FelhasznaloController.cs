using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    class FelhasznaloController  : IBelepesKezelo, IUjFelhasznaloKezelo, IAdatKezelo {

        public FelhasznaloController ()
	    {

	    }

		/// 
		/// <param name="felhasznalonev"></param>
		/// <param name="jelszo"></param>
		/// <param name="email"></param>
		public void Adatellenorzes(string felhasznalonev, string jelszo, string email){

		}

		/// 
		/// <param name="felhasznalonev"></param>
		/// <param name="jelszo"></param>
		public bool AutentikaciosEllenorzes(string felhasznalonev, string jelszo){

			return false;
		}

		public void Belépés(){

		}

		/// 
		/// <param name="ujCim"></param>
		public void CimModositas(string ujCim){

		}

		/// 
		/// <param name="ujEmail"></param>
		public void EmailModositas(string ujEmail){

		}

		/// 
		/// <param name="felhasznalo"></param>
		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo){

		}

		public void HibaVisszajelzés(){

		}

		/// 
		/// <param name="ujJelszo"></param>
		public void JelszoModositas(string ujJelszo){

		}

		public void Regisztráció(){

		}

		public bool TerheltsegEllenorzes(){

			return false;
		}

	}//end FelhasználóCtrl
}
