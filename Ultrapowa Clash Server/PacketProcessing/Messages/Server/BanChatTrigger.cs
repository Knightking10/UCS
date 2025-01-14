﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCS.Logic;
using UCS.Core;
using UCS.Helpers;

namespace UCS.PacketProcessing
{
    //Packet 20118
    class BanChatTrigger : Message
    {
        private int m_vCode;

        public BanChatTrigger(Client client)
            : base(client)
        {
            SetMessageType(20118);
        }

        public override void Encode()
        {
            List<Byte> data = new List<Byte>();
            data.AddInt32(m_vCode);
            SetData(data.ToArray());
        }

        public void SetCode(int code)
        {
            m_vCode = code;
        }
    }
}
