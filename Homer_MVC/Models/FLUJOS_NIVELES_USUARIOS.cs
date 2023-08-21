namespace Homer_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FLUJOS_NIVELES_USUARIOS
    {
        public int id { get; set; }

        public int id_flujonivel { get; set; }

        public int? id_usuario { get; set; }

        public virtual FLUJOS_NIVELES FLUJOS_NIVELES { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
