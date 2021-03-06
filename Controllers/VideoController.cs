﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/
        //index funcion mostrar los videos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int idVideo,string titulo,int repro,string url)
        {
            //guardas video
            List<SqlParameter>Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            Parametros.Add(new SqlParameter("@titulo", titulo));
            Parametros.Add(new SqlParameter("@repro", repro));
            Parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_insertar",CommandType.StoredProcedure,Parametros);


            //lo manda a ver la lista de todos los videos
            return RedirectToAction("Index","Video");
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("idVideo", idVideo));

            BaseHelper.ejecutarConsulta("sp_video_eliminar", CommandType.StoredProcedure, Parametros);
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo, string titulo, int repro, string url)
        {
            return View();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarConsulta("sp_video_actualizar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }
        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buscar(int idVideo)
        {
            return View();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarConsulta("sp_video_buscar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }
    }
}
