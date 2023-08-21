using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homer_MVC.Models.DAO
{
    public class solicitud_nivel_adjunto_dao
    {
        Model1 ctx = new Model1();

        public IQueryable<SOLICITUD_NIVEL_ADJUNTO> Todo
        {
            get { return ctx.SOLICITUD_NIVEL_ADJUNTO; }
        }

        public void Insertar(SOLICITUD_NIVEL_ADJUNTO datos)
        {
            ctx.SOLICITUD_NIVEL_ADJUNTO.Add(datos);
        }

        public void Actualizar(SOLICITUD_NIVEL_ADJUNTO datos)
        {
            if (datos.id != default(int))
            {
                ctx.Entry(datos).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public SOLICITUD_NIVEL_ADJUNTO Encontrar(int id)
        {
            return ctx.SOLICITUD_NIVEL_ADJUNTO.Find(id);
        }

        public void Eliminar(int id)
        {
            var registro = Encontrar(id);

            if (registro != null)
            {
                ctx.SOLICITUD_NIVEL_ADJUNTO.Remove(registro);
            }
        }

        public void GuardarCambios()
        {
            ctx.SaveChanges();
        }
    }
}