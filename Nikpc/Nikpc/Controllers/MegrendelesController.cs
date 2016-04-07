using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    class MegrendelesController : IMegrendelesekKezelese, IMegrendelesKezelo {

        public MegrendelesController()
        {

        }

		/// 
		/// <param name="mod"></param>
		public void FizetesiModValtas(FizetesiMod mod){

		}

		/// 
		/// <param name="nev"></param>
		/// <param name="osszeg"></param>
		/// <param name="mod"></param>
		/// <param name="termekek"></param>
		public void Kereses(string nev, string osszeg, FizetesiMod mod, List<Termek> termekek){

		}

		public void KosarKiurites(){

		}

		/// 
		/// <param name="kosar"></param>
		/// <param name="mod"></param>
		public void MegrendelesLeadas(Kosar kosar, FizetesiMod mod){

		}

		/// 
		/// <param name="megrendeles"></param>
		public void IMegrendelesekKezelese.MegrendelesTorles(Megrendeles megrendeles){

		}

		public void MegrendelésSzerkesztése(){

		}

		/// 
		/// <param name="rendezesParameter"></param>
		/// <param name="novekvo"></param>
		public void Rendezes(string rendezesParameter, bool novekvo){

		}

		/// 
		/// <param name="termek"></param>
		/// <param name="darab"></param>
		public void TermekMennyisegModositas(Termek termek, int darab){

		}

		/// 
		/// <param name="megrendeles"></param>
		public void IMegrendelesKezelo.MegrendelesTorles(Megrendeles megrendeles){

		}

	}//end MegrendelésCtrl
}
