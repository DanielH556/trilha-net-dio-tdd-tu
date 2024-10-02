using CalculadoraTDD.Console.Services;

namespace CalculadoraTDD.Tests;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        Calculadora calc = new Calculadora("01/10/2024");
        return calc;
    }

    [Theory]
    [InlineData(40, 385, 425)]
    [InlineData(10, -30, -20)]
    [InlineData(5.5, 3.2, 8.7)]
    public void SomarDoisNumeros(double val1, double val2, double resultado)
    {
        Calculadora calc = construirClasse();
        var resultadoCalculado = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(50, 40, 10)]
    [InlineData(10, -30, 40)]
    [InlineData(5.5, 3.2, 2.3)]
    public void SubtrairDoisNumeros(double val1, double val2, double resultado)
    {
        Calculadora calc = construirClasse();
        var resultadoCalculado = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(50, 40, 2000)]
    [InlineData(10, -30, -300)]
    [InlineData(5.5, 3.2, 17.6)]
    public void MultiplicarDoisNumeros(double val1, double val2, double resultado)
    {
        Calculadora calc = construirClasse();
        var resultadoCalculado = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(50, 40, 1.25)]
    [InlineData(10, -2, -5)]
    [InlineData(5.5, 3.2, 1.71875)]
    public void DividirDoisNumeros(double val1, double val2, double resultado)
    {
        Calculadora calc = construirClasse();
        var resultadoCalculado = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.Somar(1, 2);
        calc.Somar(2, 5);
        calc.Somar(9, 8);
        calc.Somar(3, 2);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}