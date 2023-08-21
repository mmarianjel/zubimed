using Homer_MVC.Models;
using Homer_MVC.Models.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homer_MVC.Controllers
{
    public class SolicitudesController : Controller
    {
        Model1 ctx = new Model1();
        int sess_idempresa = 1;
        int sess_idusuario = 1;

        solicitud_nivel_adjunto_dao dao_adjuntonivel = new solicitud_nivel_adjunto_dao();

        public ActionResult Index(string x1 = null)
        {
            List<solicitud_lista> dataRet = new List<solicitud_lista>();
            var data = ctx.SOLICITUDES.Where(x => x.FLUJOS.EMPRESA.id == sess_idempresa).ToList();
            //if (!string.IsNullOrEmpty(x1))
            //{
            //    if (x1 == "H")
            //    {

            //    }
            //}
            foreach (var reg in data)
            {
                var lastniv = reg.SOLICITUD_NIVELES.OrderByDescending(x => x.id).FirstOrDefault();
                var usuAsig = new USUARIOS();
                try
                {
                    if (lastniv.id_usuario > 0)
                        usuAsig = ctx.USUARIOS.Where(x => x.ID_USUARIO == lastniv.id_usuario).FirstOrDefault();

                }
                catch { }

                var add = new solicitud_lista();
                add.datasol = reg;
                add.datacliente = reg.COTIZACION.CLIENTES;
                add.usu_creador = reg.USUARIOS;
                add.usu_asignado = usuAsig;
                add.lastNiv = lastniv;
                dataRet.Add(add);
            }

            ViewBag.x1 = x1;



            var t = Tuple.Create(dataRet);
            return View(t);
        }

        public ActionResult Listar()
        {
            return View();
        }

        public ActionResult vermov()
        {
            int id = Convert.ToInt32(Request["x1"]);
            var datasol = ctx.SOLICITUDES.Where(x => x.id == id).FirstOrDefault();
            var dataUsu = ctx.USUARIOS.Where(x => x.PERFILES.EMPRESA.id == sess_idempresa).ToList();
            ViewBag.colorbtn = Convert.ToString(Request["x2"]);

            var t = Tuple.Create(datasol, dataUsu);
            return View(t);
        }

        public ActionResult ver()
        {
            int id = Convert.ToInt32(Request["x1"]);
            ViewBag.colorbtn = Convert.ToString(Request["x2"]);
            var data = ctx.SOLICITUDES.Where(x => x.id == id).FirstOrDefault();
            return View(data);
        }

        public ActionResult continuar()
        {
            int id = Convert.ToInt32(Request["x1"]);
            ViewBag.colorbtn = Convert.ToString(Request["x2"]);
            var data = ctx.SOLICITUDES.Where(x => x.id == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public JsonResult upld_adjunto()
        {
            int status = 0;
            string mensaje = string.Empty;

            try
            {
                if (Request.Files.Count > 0)
                {
                    string tipo = Convert.ToString(Request["tipo"]);
                    string descripcion = Convert.ToString(Request["descripcion"]);
                    int idSol = Convert.ToInt32(Request["idSol"]);

                    string path = Server.MapPath("~/Uploads");
                    string strDate = DateTime.Now.ToString("yyyyMM");
                    string strDay = DateTime.Now.ToString("dd");
                    path = Path.Combine(path, strDate);
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    path = Path.Combine(path, strDay);
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    for (int i = 0; i < Request.Files.Count; i++)
                    {
                        string rnd = DateTime.Now.ToString("yyyyMMddHHmmss");
                        HttpPostedFileBase fileUpload = Request.Files[i];

                        string fileid = Convert.ToString(Request.Files.Keys[i]);
                        string filename = Convert.ToString(Path.GetFileName(fileUpload.FileName));
                        string fileExten = Convert.ToString(Path.GetExtension(filename));
                        string filetype = Convert.ToString(fileUpload.ContentType);
                        string filesize = Convert.ToString(fileUpload.ContentLength);
                        string nombre_file = string.Concat(rnd, fileExten);



                        string[] array = { ".PDF", ".JPG", ".JPEG", ".PNG" };
                        string currpath = Path.Combine(path, nombre_file);
                        string path_str = string.Concat("../../Uploads/", strDate + "/", strDay + "/", nombre_file);

                        if (fileUpload.ContentLength > 0)
                        {
                            try
                            {
                                if (array.Contains(fileExten.ToUpper()))
                                {
                                    fileUpload.SaveAs(currpath);

                                    var add = new SOLICITUD_NIVEL_ADJUNTO();
                                    add.descripcion = descripcion;
                                    add.fecha_alta = DateTime.Now;
                                    add.id_solnivel = 1;
                                    add.nombre = nombre_file;
                                    add.tipo = tipo;
                                    add.url = path_str;

                                    dao_adjuntonivel.Insertar(add);
                                    dao_adjuntonivel.GuardarCambios();
                                    status = 1;
                                }

                            }
                            catch (Exception ex)
                            {
                                mensaje = "ERROR: No se pudo cargar el registro.";
                            }
                        }
                        else
                        {
                            mensaje = "ERROR: Archivo sin contenido.";
                        }
                    }
                }
            }
            catch(Exception ex) {
                status = 0;
                mensaje = ex.ToString();
            }
            return Json(new { status, mensaje }, JsonRequestBehavior.AllowGet);

        }
    }
}
