using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEVAPPDsktp.DBAccess
{
    public static class UsuariosORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<USUARIOS> SelectAllEntidades()
        {
            List<USUARIOS> _entidades = (from e in DBAccess.ORM.dbe.USUARIOS
                                         orderby e.email
                                         select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por ID
        public static List<USUARIOS> SelectById(int id)
        {
            List<USUARIOS> _entidades = (from e in DBAccess.ORM.dbe.USUARIOS
                                         where e.id.Equals(id)
                                         select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por DELEGACIONES
        public static List<USUARIOS> SelectByDelegacion(int iddelegacion)
        {
            List<USUARIOS> _entidades = (from e in DBAccess.ORM.dbe.USUARIOS
                                         orderby e.email
                                         where e.iddelegacion.Equals(iddelegacion)
                                         select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por EMAIL, ESTADO, IDSOCIO, IDDELEGACION
        public static List<USUARIOS> SelectByFilters(string email, int estado, string idsocio, int iddelegacion)
        {
            String theW = "";
            if (email.Length >= 0) { theW += (theW.Length > 0 ? " AND " : "") + "(u.email LIKE '%" + email + "%')"; }
            if (estado == 1 ) { theW += (theW.Length > 0 ? " AND " : "") + "(u.estado = 1)"; }
            else if (estado == 2) { theW += (theW.Length > 0 ? " AND " : "") + "(u.estado = 0)"; }
            if (idsocio.Length >= 0) { theW += (theW.Length > 0 ? " AND " : "") + "(u.idsocio LIKE '%" + idsocio + "%')"; }
            if (iddelegacion > 0) { theW += (theW.Length > 0 ? " AND " : "") + "(u.iddelegacion = " + iddelegacion + ")"; }
            theW = (theW.Length > 0 ? " WHERE " : "") + theW;
            String theQ = "SELECT u.id,  u.estado, u.cidapp, u.idsocio, u.email, u.imei, u.fechaestado, u.notaestado, u.iddelegacion, u.iddsktuser FROM USUARIOS AS u" +
                theW + " ORDER BY u.email ASC";
            // Console.WriteLine("email.Length: " + email.Length);
            // Console.WriteLine("estado: " + estado);
            // Console.WriteLine("idsocio.Length: " + idsocio.Length);
            // Console.WriteLine("iddelegacion: " + iddelegacion);
            // Console.WriteLine("theQ: " + theQ);
            List<USUARIOS> _entidades = ORM.dbe.USUARIOS.SqlQuery(theQ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(USUARIOS entidad)
        {
            ORM.dbe.USUARIOS.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(USUARIOS entidad)
        {
            USUARIOS e = DBAccess.ORM.dbe.USUARIOS.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(USUARIOS entidad)
        {
            ORM.dbe.USUARIOS.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }
    }
}