using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MsgBase
{
    public const string AckHead = "[ACK_MSG]";
    public const string ReqHead = "[REQ_MSG]";

    public virtual string Tag { get { return this.GetType().Name; } }

    public static string Serialize<T>(T _msg) where T : MsgBase , Google.Protobuf.IMessage
    {
        return Google.Protobuf.JsonFormatter.Default.Format(_msg);
    }
    public static T Deserialize<T>(string _msg) where T : MsgBase, Google.Protobuf.IMessage, new()
    {
        return Google.Protobuf.JsonParser.Default.Parse<T>(_msg);
    }
}
