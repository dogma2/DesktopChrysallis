using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEVAPPDsktp.Classes
{
    public class DeviceAppDataes
    {
        public bool m_set_GPS { get; set; }
        public bool m_set_Sound { get; set; }
        public int m_set_Lang { get; set; }
        public int m_set_Update { get; set; }
        public bool m_set_LongAlertAct { get; set; }
        public int m_set_LongAlert { get; set; }
        public bool m_set_ShortAlertAct { get; set; }
        public int m_set_ShortAlert { get; set; }
        public int m_set_AlertFromHH { get; set; }
        public int m_set_AlertFromMM { get; set; }
        public int m_set_AlertToHH { get; set; }
        public int m_set_AlertToMM { get; set; }
        public bool m_app_state { get; set; }
        public string m_app_cidapp { get; set; }
        public int[] m_app_installdata { get; set; }
        public int[] m_app_lastupdate { get; set; }
        public byte m_user_idCCAA { get; set; }
        public byte m_user_idProvincia { get; set; }
        public string m_user_IMEI { get; set; }
        public string m_user_email { get; set; }
        public int m_user_idsocio { get; set; }
    }
}
