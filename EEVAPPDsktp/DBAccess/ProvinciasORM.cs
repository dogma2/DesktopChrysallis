using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    public static class ProvinciasORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<PROVINCIAS> SelectAllEntidades()
        {
            List<PROVINCIAS> _entidades = (from e in DBAccess.ORM.dbe.PROVINCIAS
                                           orderby e.nombre
                                             select e
                                          ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por ID
        public static List<PROVINCIAS> SelectById(int id)
        {
            List<PROVINCIAS> _entidades = ( from e in DBAccess.ORM.dbe.PROVINCIAS
                                            where e.id.Equals(id)
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades
        public static List<PROVINCIAS> SelectByCCAA(int idccaa)
        {
            List<PROVINCIAS> _entidades = ( from e in DBAccess.ORM.dbe.PROVINCIAS
                                            orderby e.nombre
                                            where e.idccaa.Equals(idccaa)
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(PROVINCIAS entidad)
        {
            ORM.dbe.PROVINCIAS.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(PROVINCIAS entidad)
        {
            PROVINCIAS e = DBAccess.ORM.dbe.PROVINCIAS.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(PROVINCIAS entidad)
        {
            ORM.dbe.PROVINCIAS.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }
    }
}