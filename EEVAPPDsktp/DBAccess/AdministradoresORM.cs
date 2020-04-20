using EEVAPPDsktp.Classes;
using OC.Core.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEVAPPDsktp.DBAccess
{
    class AdministradoresORM
    {
        // - - - - - retorna LISTA de entidades
        public static List<DSKTUSERS> SelectAllEntidades()
        {
            List<DSKTUSERS> _entidades = (  from e in DBAccess.ORM.dbe.DSKTUSERS
                                            orderby e.nickname
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por ID
        public static List<DSKTUSERS> SelectById(int id)
        {
            List<DSKTUSERS> _entidades = (  from e in DBAccess.ORM.dbe.DSKTUSERS
                                            where e.id.Equals(id)
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna LISTA de entidades por DELEGACIONES
        public static List<DSKTUSERS> SelectByDelegacion(int iddelegacion)
        {
            List<DSKTUSERS> _entidades = (  from e in DBAccess.ORM.dbe.DSKTUSERS
                                            orderby e.nickname
                                            where e.iddelegacion.Equals(iddelegacion)
                                            select e
                                            ).ToList();
            return _entidades;
        }

        // - - - - - retorna DSKTUSERS por usuario y password
        public static DSKTUSERS LoginDsktUser(String user, String pass)
        {
            String hello = Publica.getHashString(pass);
            DSKTUSERS retu = null;
            List <DSKTUSERS> _entidades = ( from e in DBAccess.ORM.dbe.DSKTUSERS
                                            where e.nickname.Equals(user) && e.password.Equals(hello)
                                            select e
                                            ).ToList();
            if (_entidades != null && _entidades.Count>0 ) { retu = _entidades[0]; }
            return retu;
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