using System;
using Xunit;
using Blindando_código_com_TDD;


namespace TesteTDD
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(1,2,3)]
		[InlineData(4,5, 9)]
		public void Testesomar(int val1, int val2, int res)
		{
			Calculadora calc = new Calculadora();
			int resultadoCalculadora = calc.somar(val1,val2);

			Assert.Equal(res, resultadoCalculadora);
		}

		[Theory]
		[InlineData(1, 2, 2)]
		[InlineData(4, 5, 20)]
		public void Testemultilpicar(int val1, int val2, int res)
		{
			Calculadora calc = new Calculadora();
			int resultadoCalculadora = calc.multiplicar(val1, val2);

			Assert.Equal(res, resultadoCalculadora);
		}

		[Theory]
		[InlineData(6, 2, 3)]
		[InlineData(5, 5, 1)]
		[InlineData(30, 10, 3)]
		public void Testedividir(int val1, int val2, int res)
		{
			Calculadora calc = new Calculadora();
			int resultadoCalculadora = calc.dividir(val1, val2);

			Assert.Equal(res, resultadoCalculadora);
		}

		[Theory]
		[InlineData(6, 2, 4)]
		[InlineData(5, 5, 0)]
		public void Testesubtrair(int val1, int val2, int res)
		{
			Calculadora calc = new Calculadora();
			int resultadoCalculadora = calc.subtrair(val1, val2);

			Assert.Equal(res, resultadoCalculadora);
		}

		[Fact]
		public void TestarDivisaoPorZero()
		{
			Calculadora calc = new Calculadora();
			Assert.Throws<System.DivideByZeroException>(() => calc.dividir(3, 0));
		}

		[Fact]
		public void Testarhistorico()
		{
			Calculadora calc = new Calculadora();
			Assert.NotEmpty(calc.historico());

			calc.somar(1, 2);
			calc.somar(2, 8);
			calc.somar(3, 7);
			calc.somar(4, 1);

			var lista = calc.historico();

			Assert.NotEmpty(lista);
			Assert.Equal(2, lista.Count);	

		}
	}
}