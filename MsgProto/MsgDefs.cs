using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Protocol;

namespace Protocol
{
    #region Req
    public partial class TestMsg1Req : ReqMsgBase
    {

    }
    public partial class TestRegistReq : ReqMsgBase
    {

    }
    public partial class TestLoginReq : ReqMsgBase
    {

    }
    public partial class TestVersionReq : ReqMsgBase
    {

    }
    #endregion

    /// <summary>
    /// ================================================== ^_^ ===========================================================
    /// </summary>

    #region Ack
    public partial class TestMsg1Ack : AckMsgBase
    {

    }
    public partial class TestRegistAck : AckMsgBase
    {

    }
    public partial class TestLoginAck : AckMsgBase
    {

    }
    public partial class TestVersionAck : AckMsgBase
    {

    }
    #endregion
}