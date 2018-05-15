using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GESTION.Entity;
using GESTION.Dto;

namespace GESTION.Rules
{
    public class UsuarioRules
    {
        private EntitiesDataContext Entities = null;

        public UsuarioRules() {
            this.Entities = new EntitiesDataContext();        
        }
    }
}
