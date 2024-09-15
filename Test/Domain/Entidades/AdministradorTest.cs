using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange: Preparação das variáveis e instância do objeto 'Administrador' para o teste.
        var adm = new Administrador();

        // Act: Atribuição de valores às propriedades do objeto 'Administrador'.
        adm.Id = 1;
        adm.Email = "administrador@teste.com";
        adm.Senha = "1234";
        adm.Perfil = "Adm";

        // Assert: Verificação se as propriedades retornam os valores esperados.
        Assert.AreEqual(1, adm.Id);  // Verifica se o Id foi atribuído corretamente.
        Assert.AreEqual("administrador@teste.com", adm.Email);  // Verifica se o Email foi atribuído corretamente.
        Assert.AreEqual("1234", adm.Senha);  // Verifica se a Senha foi atribuída corretamente.
        Assert.AreEqual("Adm", adm.Perfil);  // Verifica se o Perfil foi atribuído corretamente.
    }

}