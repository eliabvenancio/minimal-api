



using MinimalApi.Dominio.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange: Preparação das variáveis e instância do objeto 'Administrador' para o teste.
        var veiculo = new Veiculo();

        // Act: Atribuição de valores às propriedades do objeto 'Administrador'.
        veiculo.Id = 1;
        veiculo.Nome = "Mobi";
        veiculo.Marca = "Fiat";
        veiculo.Ano = 2018;


        // Assert: Verificação se as propriedades retornam os valores esperados.
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Mobi", veiculo.Nome);
        Assert.AreEqual("Fiat", veiculo.Marca);
        Assert.AreEqual(2018, veiculo.Ano);

    }
}