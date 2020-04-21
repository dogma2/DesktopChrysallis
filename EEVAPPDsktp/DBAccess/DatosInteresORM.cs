using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    public static class DatosInteresORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<DATOSINTERES> SelectAllEntidades()
        {
            List<DATOSINTERES> _entidades = (   from e in DBAccess.ORM.dbe.DATOSINTERES
                                                orderby e.nombre
                                                select e
                                                ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por ID
        public static List<DATOSINTERES> SelectById(int id)
        {
            List<DATOSINTERES> _entidades = (   from e in DBAccess.ORM.dbe.DATOSINTERES
                                                where e.id.Equals(id)
                                                select e
                                                ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por DELEGACIONES
        public static List<DATOSINTERES> SelectByDelegacion(int iddelegacion)
        {
            List<DATOSINTERES> _entidades = (from e in DBAccess.ORM.dbe.DATOSINTERES
                                             orderby e.nombre
                                             where e.iddelegacion.Equals(iddelegacion)
                                             select e
                                          ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(DATOSINTERES entidad)
        {
            ORM.dbe.DATOSINTERES.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(DATOSINTERES entidad)
        {
            DATOSINTERES e = DBAccess.ORM.dbe.DATOSINTERES.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(DATOSINTERES entidad)
        {
            ORM.dbe.DATOSINTERES.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }
        public static List<DATOSINTERES> SelectByFilters(string nombre, byte estado, string ciudad, int iddelegacion)
        {
            String theW = "";
            if (nombre.Length >= 0) { theW += (theW.Length > 0 ? " AND " : "") + "(d.nombre LIKE '%" + nombre + "%')"; }
            if (estado == 1) { theW += (theW.Length > 0 ? " AND " : "") + "(d.estado = 1)"; }
            else if (estado == 2) { theW += (theW.Length > 0 ? " AND " : "") + "(d.estado = 0)"; }
            if (ciudad.Length >= 0) { theW += (theW.Length > 0 ? " AND " : "") + "(d.ciudad LIKE '%" + ciudad + "%')"; }
            if (iddelegacion > 0) { theW += (theW.Length > 0 ? " AND " : "") + "(d.iddelegacion = " + iddelegacion + ")"; }
            theW = (theW.Length > 0 ? " WHERE " : "") + theW;
            String theQ = "SELECT d.id, d.estado, d.nombre, d.descripcion, d.direccion, d.ciudad, d.cp, d.idprovincia, d.idccaa, d.telefono, d.email , d.contacto, d.ctrlglobal, d.iddelegacion, d.iddsktuser FROM DATOSINTERES AS d" +
                theW + " ORDER BY d.ciudad ASC";
           
            // Console.WriteLine("email.Length: " + email.Length);
            // Console.WriteLine("estado: " + estado);
            // Console.WriteLine("idsocio.Length: " + idsocio.Length);
            // Console.WriteLine("iddelegacion: " + iddelegacion);
            // Console.WriteLine("theQ: " + theQ);
            List<DATOSINTERES> _entidades = ORM.dbe.DATOSINTERES.SqlQuery(theQ).ToList();
            return _entidades;
        }
    }
}