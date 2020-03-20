using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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