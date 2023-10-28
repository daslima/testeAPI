using System;
using TechChallenge2.Test.Services;
using Xunit;

namespace TechChallenge2.Test
{
    public class NoticiaTest
    {
        [Fact]
        public void TestaBuscarNoticias()
        {
            //Arrange
            NoticiaRepository Noticia = new NoticiaRepository();
            bool isvalid = false;
            //Act
            try
            {
                if(Noticia.GetNoticias().Count > 0)
                    isvalid = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Conectar a base de dados");
            }

            Assert.True(isvalid);
        }
    }
}