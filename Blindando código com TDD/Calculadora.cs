using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blindando_código_com_TDD
{
	public class Calculadora
	{
		private List<string> listaHistorico;

		public Calculadora()
		{
			listaHistorico = new List<string>();
		}
		public int somar(int val1, int val2)
		{
			int res = val1 + val2;
			return res;
		}

		public int subtrair(int val1, int val2)
		{
			int res = val1 - val2;
			listaHistorico.Insert(0, "Res" + res);
			return res;
		}

		public int multiplicar(int val1, int val2)
		{
			int res = val1 * val2;
			listaHistorico.Insert(0, "Res" + res);
			return res;
		}

		public int dividir(int val1, int val2)
		{
			int res = val1 / val2;
			listaHistorico.Insert(0, "Res" + res);
			return res;
		}

		public List<string> historico()
		{
			listaHistorico.RemoveRange(3, listaHistorico.Count -2);
			return listaHistorico;
		}
	}
}
