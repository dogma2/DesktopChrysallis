using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    public static class Eventos
    {
        // - - - - - retorna LISTA de entidades
        public static List<EVENTOS> SelectAllEntidades()
        {
            List<EVENTOS> _entidades = (from e in DBAccess.ORM.dbe.EVENTOS
                                        orderby e.titulo
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
    }
}