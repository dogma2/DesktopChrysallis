using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    public static class DelegacionesORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<DELEGACIONES> SelectAllEntidades()
        {
            List<DELEGACIONES> _entidades = (from e in DBAccess.ORM.dbe.DELEGACIONES
                                      orderby e.nombre
                                      select e
                                          ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(DELEGACIONES entidad)
        {
            ORM.dbe.DELEGACIONES.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(DELEGACIONES entidad)
        {
            DELEGACIONES e = DBAccess.ORM.dbe.DELEGACIONES.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(DELEGACIONES entidad)
        {
            ORM.dbe.DELEGACIONES.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }
    }
}