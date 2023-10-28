using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechChallenge2.Test.Services;
using Xunit;

namespace TechChallenge2.Test
{
    public class ContextTest
    {
        [Fact]
        public void TestaDataContextComSqlServer()
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