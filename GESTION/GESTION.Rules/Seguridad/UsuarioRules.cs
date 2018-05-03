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
        private Gestion_TdeAEntities Entities = null;

        public UsuarioRules() {
            this.Entities = new Gestion_TdeAEntities();        
        }
    }
}
