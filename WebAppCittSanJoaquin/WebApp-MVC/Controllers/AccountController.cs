﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC.Models;

namespace WebApp_MVC.Controllers
{
    public class AccountController : Controller
    {
        satcEntities dtb = new satcEntities();

        // El index se accesa cuando no se
        // tiene ningun parametro cuando se accede al controlador
        public ActionResult Index()
        {
            return View();
        }

        // Este metodo procesa el formulario
        // luego de eso, redirecciona a otra pagina
        #warning Notese que el parametro es de tipo FormModel
        [HttpPost]
        public ActionResult FormLogin(usuario user)
        {
            if(!string.IsNullOrEmpty(user.correo) && !string.IsNullOrEmpty(user.password))
            {
                if (dtb.usuario.FirstOrDefault(u => u.correo.Equals(user.correo) && u.password.Equals(user.password)) != null)
                {
                    var userE = from u in dtb.usuario
                                where u.correo.Equals(user.correo) & u.password.Equals(user.password)
                                select u;

                    TempData["login"] = "Login Correcto";
                    ViewBag.Login = TempData["login"];
                    return View("Exito");
                }
                else
                {
                    TempData["Error"] = "Email o constraseña incorrectos";
                    ViewBag.Error = TempData["Error"];
                    return View("Index");
                }
            }
            return RedirectToAction("Exito");
        }

        // Este metodo recibe el parametro "parametro"
        // comprueba que no este vacio, y luego,
        // se lo pasa a la vista
#warning Notese que el parametro que se entrega tiene el mismo nombre que la clase anonima pasada por metodo RedirectToAction

        public ActionResult Exito(string parametro)
        {
            // Si no esta vacia, entonces pasamos el parametro a la vista
            if (!string.IsNullOrEmpty(parametro))
            {
                ViewBag.Resultado = parametro;
            }
            return View();
        }

        public ActionResult Recuperacion()
        {
            return View();
        }

        public ActionResult Registrarse(usuario user)
        {
            log_acciones log = new log_acciones();
            if(!string.IsNullOrEmpty(user.nombre) && !string.IsNullOrEmpty(user.apellidos) &&
               !string.IsNullOrEmpty(user.correo) && !string.IsNullOrEmpty(user.password))
            {
                if(dtb.usuario.FirstOrDefault(u => u.correo.Equals(user.correo)) != null)
                {
                    TempData["error"] = "El email ya esta en uso";
                    ViewBag.Error = TempData["error"];
                    return View("Registrarse");
                }
                else
                {
                    //se genera un log de accion
                    log.fecha = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yy hh:mm:ss"));
                    log.accion = "Creacion de Usuario Alumno";
                    log.nombre_ejecutor = "Usuario Nuevo";
                    log.id_ejecutor = 0;
                    //se le da la habilitacion, 0 = no habilitado, y el tipo usuario.
                    user.habilitado = 0;
                    user.tipo_usuario = "a";
                    //se guardan los cambios en la base de datos.
                    dtb.usuario.Add(user);
                    dtb.log_acciones.Add(log);
                    dtb.SaveChanges();
                    //se retorna el mensaje correspondiente.
                    TempData["creado"] = "El Usuario se ha registrado exitosamente.";
                    ViewBag.Registrado = TempData["creado"];
                    return View("Exito");
                }

            }
            return View();
        }
    }
}