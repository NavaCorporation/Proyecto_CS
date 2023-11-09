using NUnit.Framework;
// Prueba en Beta, usar la conexion Sql Una ves este Operativa ATT// NavaCorp
[TestFixture]
public class Tests
{
    [Test]
    public void TestIdValidation()
    {
        // Arrange
        string cedulaRepetida = "1234567890";
        string cedulaNoRepetida = "0987654321";

        // Simular la base de datos en memoria
        var baseDeDatos = new Dictionary<string, bool>();
        baseDeDatos["1234567890"] = true; // Simula una cédula repetida

        // Act
        bool resultadoCedulaRepetida = CedulaRepetida(cedulaRepetida, baseDeDatos);
        bool resultadoCedulaNoRepetida = CedulaRepetida(cedulaNoRepetida, baseDeDatos);

        // Assert
        Assert.IsTrue(resultadoCedulaRepetida);
        Assert.IsFalse(resultadoCedulaNoRepetida);
    }

    public bool CedulaRepetida(string cedula, Dictionary<string, bool> baseDeDatos)
    {
        return baseDeDatos.ContainsKey(cedula);
    }
}
