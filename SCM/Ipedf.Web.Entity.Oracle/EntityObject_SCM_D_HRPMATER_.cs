using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Ipedf.Web.Entity
{
    public partial class EntityObject_SCM_D_HRPMATER
    {
        System.String _MATNR;
        [DataMember]
        public System.String MATNR
        {
            get
            {
                if (!string.IsNullOrEmpty(_MATNR))
                {
                    return _MATNR.Trim();
                }
                return _MATNR;
            }
            set { _MATNR = value; }
        }

        System.String _MAKTX;
        [DataMember]
        public System.String MAKTX
        {
            get
            {
                if (!string.IsNullOrEmpty(_MAKTX))
                {
                    return _MAKTX.Trim();
                }
                return _MAKTX;
            }
            set { _MAKTX = value; }
        }
    }
}
