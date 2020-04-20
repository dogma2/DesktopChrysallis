using OC.Core.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.Classes
{
    public static class Publica
    {
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONSTANTES PUBLICAS
        public const string FILE_PATH = @"..\..\JsonFiles\";
        public const string FILE_DATA = "AsociationData.json";
        public const string FILE_DAPP = "DeviceAppDefaultData.json";
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ATRIBUTOS PUBLICOS
        public static string superadmin = "SuperAdmin";
        public static string superclave = "P!nt@lo20#20";
        public static string usuario = "";
        public static int idusuario = 0;
        public static int iddelegacion = 0;
        public static bool master = false;
        public static byte idccaa = 0;

        // - - - - - retorna la clave en hash512
        public static String getHashString(String pass)
        {
            Hash encrypt = new Hash();
            return (String)encrypt.Sha512(pass);
        }

    }
}
