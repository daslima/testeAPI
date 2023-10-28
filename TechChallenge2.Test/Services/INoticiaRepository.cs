using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechChallenge2.Domain.Entities;

namespace TechChallenge2.Test.Services
{
    public interface INoticiaRepository
    {
        protected List<Noticia> GetNoticias();
    }
}