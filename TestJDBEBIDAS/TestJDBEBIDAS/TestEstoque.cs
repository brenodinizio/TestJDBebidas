namespace TestJDBEBIDAS
{
    [TestClass]
    public class TestandoEstoque
    {
        [TestMethod]
        public void TestAtualizarEstoque()
        {
            int esperado=20;
            bool resultado;

            ProTipo reposicao = new ProTipo() ;

            resultado= reposicao.AtualizarEstoque(10);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestRetirarEstoque()
        {
            int esperado = 10;
            bool resultado;

            ProTipo reposicao = new ProTipo();

            resultado = reposicao.RetirarEstoque(10);

            Assert.AreEqual(esperado, resultado);
        }
    }
}