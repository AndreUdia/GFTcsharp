using System;
using System.Collections.Generic;
using dio_series.Interfaces;

namespace dio_series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public List<Serie> Lista()
        {
            throw NotImplementedException();
        }
        public Serie RetornaPorId(int id)
        {
            throw NotImplementedException();
        }
        public void Insere(Serie entidade)
        {
            throw NotImplementedException();
        }
        public void Exclui(int id)
        {
            throw NotImplementedException();
        }
        public void Atualiza(int id, Serie entidade)
        {
            throw NotImplementedException();
        }
        public int ProximoId()
        {
            throw NotImplementedException();
        }
    }
}