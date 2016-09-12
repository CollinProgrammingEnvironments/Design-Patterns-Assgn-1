using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_and_Factory_Method
{
    public class Universal_Remote_Turntable
    {
        private Twins m_ts;
        private MutilatorDefAtLast m_mdl;
        private TradFoolsEP m_tfep;
        private Innocent m_inno;
        private PopSong m_ps;
        
        public Universal_Remote_Turntable (Twins ts, MutilatorDefAtLast mdl, TradFoolsEP tfep, Innocent inno, PopSong ps)
        {
            m_ts = ts;
            m_mdl = mdl;
            m_tfep = tfep;
            m_inno = inno;
            m_ps = ps;
        }

        /*public bool TwinsBool(string Song, string Volume, string RPM)
        {
            bool RetVal;

            RetVal = m_ts.TwinsBool(FreeEnd, BladeHeight);
            m_dc.m_State = DustCollector.DustCollectorState.medium;
            m_af.m_AirFilterState = AirFilter.AirFilterState.off;

            return RetVal;
        }*/
    }

    
}
