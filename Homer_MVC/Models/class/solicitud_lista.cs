using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homer_MVC.Models
{
    public class solicitud_lista
    {
    public SOLICITUDES datasol { get; set; }
    public CLIENTES datacliente { get; set; }    
    public USUARIOS usu_creador { get; set; }
    public USUARIOS usu_asignado { get; set; }
    public SOLICITUD_NIVELES lastNiv { get; set; }
    }
}