using Nikpc.Classes;
using Nikpc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Controllers
{
    class TermekAdminisztracioController  : ITermekKezelo, ITermekListaKezelo {

        public TermekAdminisztracioController()
	    {

	    }

		public void Kereses(string termekNev, string termekKategoria, int arAlso, int arFelso, bool raktaron){

		}

		public void KészletTörlés(){

		}

		public void Rendezes(string rendezesiParameter, bool novekvo){

		}

		public void TermékekeExportálás(){

		}

		/*public void ITermekKezelo.TermekHozzaadas(Termek termek){

		}

		public void ITermekListaKezelo.TermekHozzaadas(){

		}*/

		public void TermékImportálás(){

		}

		public void TermékLefoglalása(Termek termek, int darab){

		}

		public void TermekModositas(Termek termek){

		}

		public void TermekTorles(Termek termek){

		}
    }
}
