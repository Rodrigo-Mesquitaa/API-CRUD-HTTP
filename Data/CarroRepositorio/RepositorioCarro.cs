using Business.InterfaceGenerics;
using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.Carro;

namespace Data.CarroRepositorio
{
    public class RepositorioProduto : RepositoryGenerics<CarroViewModel>, ICarro
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioProduto()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

    }
}
