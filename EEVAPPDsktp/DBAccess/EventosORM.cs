using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    public static class EventosORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<EVENTOS> SelectAllEntidades()
        {
            List<EVENTOS> _entidades = (    from e in DBAccess.ORM.dbe.EVENTOS
                                            orderby e.titulo
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por ID
        public static List<EVENTOS> SelectById(int id)
        {
            List<EVENTOS> _entidades = (    from e in DBAccess.ORM.dbe.EVENTOS
                                            where e.id.Equals(id)
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por DELEGACIONES
        public static List<EVENTOS> SelectByDelegacion(int iddelegacion)
        {
            List<EVENTOS> _entidades = (    from e in DBAccess.ORM.dbe.EVENTOS
                                            orderby e.titulo
                                            where e.iddelegacion.Equals(iddelegacion)
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(EVENTOS entidad)
        {
            ORM.dbe.EVENTOS.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(EVENTOS entidad)
        {
            EVENTOS e = DBAccess.ORM.dbe.EVENTOS.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(EVENTOS entidad)
        {
            ORM.dbe.EVENTOS.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - retorna LISTA de entidades por TITULO, ESTADO, CIUDAD, IDDELEGACION
        //Fecha inicio, titulo, estado, ciudad y delegación
        public static List<EVENTOS> SelectByFilters(string titulo, byte estado, string ciudad, int iddelegacion)
        {
            String theW = "";
            if(titulo.Length > 0) { theW += (theW.Length > 0 ? " AND " : "") + "(e.titulo LIKE '%" + titulo + "%')"; }
            if (estado == 1) { theW += (theW.Length > 0 ? " AND " : "") + "(e.estado = 1)"; }
            else if (estado == 2) { theW += (theW.Length > 0 ? " AND " : "") + "(e.estado = 0)"; }
            if (ciudad.Length > 0) { theW += (theW.Length > 0 ? " AND " : "") + "(e.ciudad LIKE '%" + ciudad + "%')"; }
            if (iddelegacion > 0) { theW += (theW.Length > 0 ? " AND " : "") + "(e.iddelegacion = " + iddelegacion + ")"; }
            theW = (theW.Length > 0 ? " WHERE " : "") + theW;
            // String theQ = "SELECT e.cidevento,  e.fechainicio, e.titulo, e.estado, e.ciudad, e.iddelegacion FROM EVENTOS AS e" +
            //    theW + " ORDER BY e.cidevento DESC";
            String theQ = "SELECT * FROM EVENTOS AS e" +
                theW + " ORDER BY e.cidevento DESC";
            // Console.WriteLine("email.Length: " + email.Length);
            // Console.WriteLine("estado: " + estado);
            // Console.WriteLine("idsocio.Length: " + idsocio.Length);
            // Console.WriteLine("iddelegacion: " + iddelegacion);
            // Console.WriteLine("theQ: " + theQ);
            List<EVENTOS> _entidades = ORM.dbe.EVENTOS.SqlQuery(theQ).ToList();
            return _entidades;
        }
    }
}