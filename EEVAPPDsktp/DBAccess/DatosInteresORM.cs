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
            List<DATOSINTERES> _entidades = (from e in DBAccess.ORM.dbe.DATOSINTERES
                                             orderby e.nombre
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
    }
}