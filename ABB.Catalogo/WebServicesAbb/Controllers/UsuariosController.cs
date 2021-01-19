using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ABB.Catalogo.LogicaNegocio.Core;
using ABB.Catalogo.Entidades.Core;

namespace WebServicesAbb.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        public IEnumerable<Usuarios> Get()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            usuarios = new UsuariosLN().ListarUsuarios();

            return usuarios;
        }

        // GET: api/Usuarios/5
        public int Get([FromUri] string pUsuario, [FromUri] string pPassword)
        {
            try
            {
                UsuariosLN usuario = new UsuariosLN();
                return usuario.GetUsuarioId(pUsuario, pPassword);
            }
            catch (Exception ex)
            {
string innerException = (ex.InnerException == null) ? "" : ex.InnerException.ToString();
                //Logger.paginaNombre = this.GetType().Name;
  //Logger.Escribir("Error en Logica de Negocio: " + ex.Message + ". " + ex.StackTrace + ". " + innerException);
                return -1;
            }


        }


        // POST: api/Usuarios
        public void Post([FromBody]Usuarios value)
        {
            Usuarios usuario = new UsuariosLN().InsertarUsuario(value);
        }


        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody] Usuarios value)
        {
            Usuarios usuario = new Usuarios();
            usuario = new UsuariosLN().ModificarUsuario(id, value);
        }


        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
            int usuario = new UsuariosLN().EliminarUsuario(id);
        }

        public Usuarios GetUserId([FromUri] int IdUsuario)
        {
            try
            {
                UsuariosLN usuario = new UsuariosLN();
                return usuario.BuscaUsuarioId(IdUsuario);
            }
            catch (Exception ex)
            {
                string innerException = (ex.InnerException == null) ? "" : ex.InnerException.ToString();
                //Logger.paginaNombre = this.GetType().Name;
                //Logger.Escribir("Error en Logica de Negocio: " + ex.Message + ". " + ex.StackTrace + ". " + innerException);
                throw;
            }


        }

    }
}
