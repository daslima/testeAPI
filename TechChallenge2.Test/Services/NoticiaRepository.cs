using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechChallenge2.Domain.Entities;

namespace TechChallenge2.Test.Services
{
    public class NoticiaRepository : INoticiaRepository
    {
        //Gerando os dados
        private List<Noticia> Noticias = new List<Noticia>()
        {
            new Noticia("Era uma vez","Texto do contéudo", DateTime.Now,"David Lima"),
            new Noticia("Era uma outra vez","Texto do contéudo", DateTime.Now,"Fernanda Lima"),
            new Noticia("Assim que acabou","Texto do contéudo", DateTime.Now,"Diego Lima"),
        };

        public List<Noticia> GetNoticias()
        {
            return Noticias.OrderBy(x => x.DataPublicacao).ToList();
        }
    }
}