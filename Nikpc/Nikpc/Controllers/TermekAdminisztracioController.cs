using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    class TermekAdminisztracioController  : ITermekKezelo, ITermekListaKezelo {

        public FelhasznaloController ()
	    {

	    }

		/// 
		/// <param name="termekNev"></param>
		/// <param name="termekKategoria"></param>
		/// <param name="arAlso"></param>
		/// <param name="arFelso"></param>
		/// <param name="raktaron"></param>
		public void Kereses(string termekNev, string termekKategoria, int arAlso, int arFelso, bool raktaron){

		}

		public void KészletTörlés(){

		}

		/// 
		/// <param name="rendezesiParameter"></param>
		/// <param name="novekvo"></param>
		public void Rendezes(string rendezesiParameter, bool novekvo){

		}

		public void TermékekeExportálás(){

		}

		/// 
		/// <param name="termek"></param>
		public void ITermekKezelo.TermekHozzaadas(Termek termek){

		}

		public void ITermekListaKezelo.TermekHozzaadas(){

		}

		public void TermékImportálás(){

		}

		/// 
		/// <param name="termek"></param>
		/// <param name="int"></param>
		public void TermékLefoglalása(Termék termek, darab int){

		}

		/// 
		/// <param name="termek"></param>
		public void TermekModositas(Termek termek){

		}

		/// 
		/// <param name="termek"></param>
		public void TermekTorles(Termek termek){

		}
    }
}
