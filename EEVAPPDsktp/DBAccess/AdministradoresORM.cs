﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.DBAccess
{
    class AdministradoresORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<DSKTUSERS> SelectAllEntidades()
        {
            List<DSKTUSERS> _entidades = (from e in DBAccess.ORM.dbe.DSKTUSERS
                                          orderby e.nickname
                                             select e
                                          ).ToList();
            return _entidades;
        }

        // - - - - - INSERTA una entidad el la tabla
        public static string InsertaEntidad(DSKTUSERS entidad)
        {
            ORM.dbe.DSKTUSERS.Add(entidad);
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - MODIFICA una entidad el la tabla
        public static string ModificaEntidad(DSKTUSERS entidad)
        {
            DSKTUSERS e = DBAccess.ORM.dbe.DSKTUSERS.Find(entidad.id);
            e = entidad;
            return DBAccess.ORM.SaveChanges();
        }

        // - - - - - ELIMINA una entidad de la tabla
        public static string DeleteEntidad(DSKTUSERS entidad)
        {
            ORM.dbe.DSKTUSERS.Remove(entidad);
            return DBAccess.ORM.SaveChanges();
        }
    }
}