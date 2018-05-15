using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GESTION.Entity;
using GESTION.Dto;

namespace GESTION.Rules
{
    public class CiudadRules
    {
        private EntitiesDataContext db = null;

        public CiudadRules()
        {
            this.db = new EntitiesDataContext();
        }

        public List<CiudadDto> GetAll()
        {
            return db.Ciudades.Select(e => new CiudadDto()
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Codigo = e.Codigo,
                IdDepartamento = (int)e.IdDepartamento,
            }).ToList();
        }
    }
}
