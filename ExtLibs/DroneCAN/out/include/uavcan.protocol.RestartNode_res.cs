

using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DroneCAN
{
    public partial class DroneCAN {




        public const int UAVCAN_PROTOCOL_RESTARTNODE_RES_MAX_PACK_SIZE = 1;
        public const ulong UAVCAN_PROTOCOL_RESTARTNODE_RES_DT_SIG = 0x569E05394A3017F0;

        public const int UAVCAN_PROTOCOL_RESTARTNODE_RES_DT_ID = 5;






        public partial class uavcan_protocol_RestartNode_res: IDroneCANSerialize {



            public bool ok = new bool();




            public void encode(dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx)
            {
                encode_uavcan_protocol_RestartNode_res(this, chunk_cb, ctx);
            }

            public void decode(CanardRxTransfer transfer)
            {
                decode_uavcan_protocol_RestartNode_res(transfer, this);
            }
        }
    }
}
