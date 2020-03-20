using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    public static class ComunidadesORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<CCAA> SelectAllEntidades()
        {
            List<CCAA> _entidades = (from e in DBAccess.ORM.dbe.CCAA
                                     orderby e.nombre
                                             select e
                                          ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(CCAA entidad)
        {
            ORM.dbe.CCAA.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(CCAA entidad)
        {
            CCAA e = DBAccess.ORM.dbe.CCAA.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(CCAA entidad)
        {
            ORM.dbe.CCAA.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }
    }
}