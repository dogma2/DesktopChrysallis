using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    public static class IdiomasORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<IDIOMAS> SelectAllEntidades()
        {
            List<IDIOMAS> _entidades = (from e in DBAccess.ORM.dbe.IDIOMAS
                                        orderby e.nombre
                                             select e
                                          ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por ID
        public static List<IDIOMAS> SelectById(int id)
        {
            List<IDIOMAS> _entidades = (from e in DBAccess.ORM.dbe.IDIOMAS
                                        where e.id.Equals(id)
                                           select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(IDIOMAS entidad)
        {
            ORM.dbe.IDIOMAS.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(IDIOMAS entidad)
        {
            IDIOMAS e = DBAccess.ORM.dbe.IDIOMAS.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(IDIOMAS entidad)
        {
            ORM.dbe.IDIOMAS.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }
    }
}