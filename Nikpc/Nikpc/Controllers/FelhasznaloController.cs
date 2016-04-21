using Nikpc.Classes;
using Nikpc.Interfaces;
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

		public void Adatellenorzes(string felhasznalonev, string jelszo, string email){

		}

		public bool AutentikaciosEllenorzes(string felhasznalonev, string jelszo){

			return false;
		}

		public void Belépés(){

		}

		public void CimModositas(string ujCim){

		}

		public void EmailModositas(string ujEmail){

		}

		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo){

		}

		public void HibaVisszajelzés(){

		}

		public void JelszoModositas(string ujJelszo){

		}

		public void Regisztráció(){

		}

		public bool TerheltsegEllenorzes(){

			return false;
		}
	}
}
