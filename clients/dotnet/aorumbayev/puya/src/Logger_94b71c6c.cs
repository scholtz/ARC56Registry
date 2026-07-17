using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.aorumbayev.puya.Logger_94b71c6c
{


    public class LoggerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoggerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class LogMessage : AVMObjectType
            {
                public ulong Level { get; set; }

                public string Message { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLevel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLevel.From(Level);
                    ret.AddRange(vLevel.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.From(Message);
                    stringRef[ret.Count] = vMessage.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LogMessage Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new LogMessage();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLevel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLevel.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLevel = vLevel.ToValue();
                    if (valueLevel is ulong vLevelValue) { ret.Level = vLevelValue; }
                    var indexMessage = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.Decode(bytes.Skip(indexMessage + prefixOffset).ToArray());
                    var valueMessage = vMessage.ToValue();
                    if (valueMessage is string vMessageValue) { ret.Message = vMessageValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LogMessage);
                }
                public bool Equals(LogMessage? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LogMessage left, LogMessage right)
                {
                    return EqualityComparer<LogMessage>.Default.Equals(left, right);
                }
                public static bool operator !=(LogMessage left, LogMessage right)
                {
                    return !(left == right);
                }

            }

            public class EchoNativeTupleReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public ulong Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNativeTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EchoNativeTupleReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNativeTupleReturn);
                }
                public bool Equals(EchoNativeTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNativeTupleReturn left, EchoNativeTupleReturn right)
                {
                    return EqualityComparer<EchoNativeTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNativeTupleReturn left, EchoNativeTupleReturn right)
                {
                    return !(left == right);
                }

            }

            public class EchoNestedTupleArgTupleOfTuples : AVMObjectType
            {
                public Structs.EchoNestedTupleArgTupleOfTuplesField0 Field0 { get; set; } = new Structs.EchoNestedTupleArgTupleOfTuplesField0();

                public Structs.EchoNestedTupleArgTupleOfTuplesField1 Field1 { get; set; } = new Structs.EchoNestedTupleArgTupleOfTuplesField1();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Field0.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Field1.ToByteArray();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNestedTupleArgTupleOfTuples Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EchoNestedTupleArgTupleOfTuples();
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.EchoNestedTupleArgTupleOfTuplesField0.Parse(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.EchoNestedTupleArgTupleOfTuplesField1.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNestedTupleArgTupleOfTuples);
                }
                public bool Equals(EchoNestedTupleArgTupleOfTuples? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNestedTupleArgTupleOfTuples left, EchoNestedTupleArgTupleOfTuples right)
                {
                    return EqualityComparer<EchoNestedTupleArgTupleOfTuples>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNestedTupleArgTupleOfTuples left, EchoNestedTupleArgTupleOfTuples right)
                {
                    return !(left == right);
                }

            }

            public class EchoNestedTupleArgTupleOfTuplesField0 : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNestedTupleArgTupleOfTuplesField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EchoNestedTupleArgTupleOfTuplesField0();
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNestedTupleArgTupleOfTuplesField0);
                }
                public bool Equals(EchoNestedTupleArgTupleOfTuplesField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNestedTupleArgTupleOfTuplesField0 left, EchoNestedTupleArgTupleOfTuplesField0 right)
                {
                    return EqualityComparer<EchoNestedTupleArgTupleOfTuplesField0>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNestedTupleArgTupleOfTuplesField0 left, EchoNestedTupleArgTupleOfTuplesField0 right)
                {
                    return !(left == right);
                }

            }

            public class EchoNestedTupleArgTupleOfTuplesField1 : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoNestedTupleArgTupleOfTuplesField1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EchoNestedTupleArgTupleOfTuplesField1();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoNestedTupleArgTupleOfTuplesField1);
                }
                public bool Equals(EchoNestedTupleArgTupleOfTuplesField1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoNestedTupleArgTupleOfTuplesField1 left, EchoNestedTupleArgTupleOfTuplesField1 right)
                {
                    return EqualityComparer<EchoNestedTupleArgTupleOfTuplesField1>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoNestedTupleArgTupleOfTuplesField1 left, EchoNestedTupleArgTupleOfTuplesField1 right)
                {
                    return !(left == right);
                }

            }

            public class ReturnArgsAfter14ThArgA19 : AVMObjectType
            {
                public byte Field0 { get; set; }

                public byte Field1 { get; set; }

                public byte Field2 { get; set; }

                public byte Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReturnArgsAfter14ThArgA19 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReturnArgsAfter14ThArgA19();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReturnArgsAfter14ThArgA19);
                }
                public bool Equals(ReturnArgsAfter14ThArgA19? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReturnArgsAfter14ThArgA19 left, ReturnArgsAfter14ThArgA19 right)
                {
                    return EqualityComparer<ReturnArgsAfter14ThArgA19>.Default.Equals(left, right);
                }
                public static bool operator !=(ReturnArgsAfter14ThArgA19 left, ReturnArgsAfter14ThArgA19 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task IsAB(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 114, 18, 188 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IsAB_Transactions(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 114, 18, 188 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> Echo(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 248, 25, 19 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Echo_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 248, 25, 19 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> NoArgs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 98, 238, 25 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NoArgs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 98, 238, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 16, 88, 217 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 16, 88, 217 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 244, 89, 48 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 244, 89, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 180, 51, 78 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 180, 51, 78 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 237, 126, 195 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 237, 126, 195 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Log(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 0, 225, 17 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 0, 225, 17 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="account"> </param>
        /// <param name="app"> </param>
        public async Task Log(ulong app, Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 205, 114, 123, 113 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, accountRefIndex, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(ulong app, Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 205, 114, 123, 113 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, accountRefIndex, appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task Log(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 55, 177, 126 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Log_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 55, 177, 126 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> EchoNativeString(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 68, 76, 119 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EchoNativeString_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 68, 76, 119 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<byte[]> EchoNativeBytes(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 89, 232, 24 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> EchoNativeBytes_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 89, 232, 24 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<ulong> EchoNativeUint64(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 251, 108, 241 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EchoNativeUint64_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 251, 108, 241 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> EchoNativeBiguint(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 204, 54, 59 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> EchoNativeBiguint_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 204, 54, 59 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="s"> </param>
        /// <param name="b"> </param>
        /// <param name="u"> </param>
        /// <param name="bu"> </param>
        public async Task<Structs.EchoNativeTupleReturn> EchoNativeTuple(string s, byte[] b, ulong u, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 bu, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 224, 57, 25 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            var result = await base.CallApp(new List<object> { abiHandle, sAbi, bAbi, uAbi, bu }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoNativeTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoNativeTuple_Transactions(string s, byte[] b, ulong u, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 bu, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 224, 57, 25 };
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); sAbi.From(s);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            return await base.MakeTransactionList(new List<object> { abiHandle, sAbi, bAbi, uAbi, bu }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tuple_of_tuples"> EchoNestedTupleArgTupleOfTuples</param>
        public async Task<Structs.EchoNestedTupleArgTupleOfTuples> EchoNestedTuple(Structs.EchoNestedTupleArgTupleOfTuples tuple_of_tuples, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 39, 28, 228 };

            var result = await base.CallApp(new List<object> { abiHandle, tuple_of_tuples }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoNestedTupleArgTupleOfTuples.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoNestedTuple_Transactions(Structs.EchoNestedTupleArgTupleOfTuples tuple_of_tuples, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 39, 28, 228 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tuple_of_tuples }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_a1"> </param>
        /// <param name="_a2"> </param>
        /// <param name="_a3"> </param>
        /// <param name="_a4"> </param>
        /// <param name="_a5"> </param>
        /// <param name="_a6"> </param>
        /// <param name="_a7"> </param>
        /// <param name="_a8"> </param>
        /// <param name="_a9"> </param>
        /// <param name="_a10"> </param>
        /// <param name="_a11"> </param>
        /// <param name="_a12"> </param>
        /// <param name="_a13"> </param>
        /// <param name="_a14"> </param>
        /// <param name="a15"> </param>
        /// <param name="a16"> </param>
        /// <param name="a17"> </param>
        /// <param name="a18"> </param>
        /// <param name="a19"> ReturnArgsAfter14ThArgA19</param>
        /// <param name="a20"> </param>
        public async Task<byte[]> ReturnArgsAfter14Th(ulong _a1, ulong _a2, ulong _a3, ulong _a4, ulong _a5, ulong _a6, ulong _a7, ulong _a8, ulong _a9, ulong _a10, ulong _a11, ulong _a12, ulong _a13, ulong _a14, byte a15, byte a16, byte a17, byte a18, Structs.ReturnArgsAfter14ThArgA19 a19, byte a20, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 11, 67, 129 };
            var _a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a1Abi.From(_a1);
            var _a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a2Abi.From(_a2);
            var _a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a3Abi.From(_a3);
            var _a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a4Abi.From(_a4);
            var _a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a5Abi.From(_a5);
            var _a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a6Abi.From(_a6);
            var _a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a7Abi.From(_a7);
            var _a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a8Abi.From(_a8);
            var _a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a9Abi.From(_a9);
            var _a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a10Abi.From(_a10);
            var _a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a11Abi.From(_a11);
            var _a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a12Abi.From(_a12);
            var _a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a13Abi.From(_a13);
            var _a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a14Abi.From(_a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a17Abi.From(a17);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a18Abi.From(a18);
            var a20Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a20Abi.From(a20);

            var result = await base.CallApp(new List<object> { abiHandle, _a1Abi, _a2Abi, _a3Abi, _a4Abi, _a5Abi, _a6Abi, _a7Abi, _a8Abi, _a9Abi, _a10Abi, _a11Abi, _a12Abi, _a13Abi, _a14Abi, a15Abi, a16Abi, a17Abi, a18Abi, a19, a20Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ReturnArgsAfter14Th_Transactions(ulong _a1, ulong _a2, ulong _a3, ulong _a4, ulong _a5, ulong _a6, ulong _a7, ulong _a8, ulong _a9, ulong _a10, ulong _a11, ulong _a12, ulong _a13, ulong _a14, byte a15, byte a16, byte a17, byte a18, Structs.ReturnArgsAfter14ThArgA19 a19, byte a20, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 11, 67, 129 };
            var _a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a1Abi.From(_a1);
            var _a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a2Abi.From(_a2);
            var _a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a3Abi.From(_a3);
            var _a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a4Abi.From(_a4);
            var _a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a5Abi.From(_a5);
            var _a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a6Abi.From(_a6);
            var _a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a7Abi.From(_a7);
            var _a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a8Abi.From(_a8);
            var _a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a9Abi.From(_a9);
            var _a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a10Abi.From(_a10);
            var _a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a11Abi.From(_a11);
            var _a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a12Abi.From(_a12);
            var _a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a13Abi.From(_a13);
            var _a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _a14Abi.From(_a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a17Abi.From(a17);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a18Abi.From(a18);
            var a20Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); a20Abi.From(a20);

            return await base.MakeTransactionList(new List<object> { abiHandle, _a1Abi, _a2Abi, _a3Abi, _a4Abi, _a5Abi, _a6Abi, _a7Abi, _a8Abi, _a9Abi, _a10Abi, _a11Abi, _a12Abi, _a13Abi, _a14Abi, a15Abi, a16Abi, a17Abi, a18Abi, a19, a20Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="log_1"> LogMessage</param>
        /// <param name="log_2"> LogMessage</param>
        public async Task<bool> LogsAreEqual(Structs.LogMessage log_1, Structs.LogMessage log_2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 208, 113, 133 };

            var result = await base.CallApp(new List<object> { abiHandle, log_1, log_2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LogsAreEqual_Transactions(Structs.LogMessage log_1, Structs.LogMessage log_2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 208, 113, 133 };

            return await base.MakeTransactionList(new List<object> { abiHandle, log_1, log_2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9nZ2VyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkxvZ01lc3NhZ2UiOlt7Im5hbWUiOiJsZXZlbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtZXNzYWdlIiwidHlwZSI6InN0cmluZyJ9XSwiRWNob05hdGl2ZVR1cGxlUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ1MTIifV0sIkVjaG9OZXN0ZWRUdXBsZUFyZ1R1cGxlT2ZUdXBsZXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiRWNob05lc3RlZFR1cGxlQXJnVHVwbGVPZlR1cGxlc0ZpZWxkMCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJFY2hvTmVzdGVkVHVwbGVBcmdUdXBsZU9mVHVwbGVzRmllbGQxIn1dLCJFY2hvTmVzdGVkVHVwbGVBcmdUdXBsZU9mVHVwbGVzRmllbGQwIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifV0sIkVjaG9OZXN0ZWRUdXBsZUFyZ1R1cGxlT2ZUdXBsZXNGaWVsZDEiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJieXRlW10ifV0sIlJldHVybkFyZ3NBZnRlcjE0VGhBcmdBMTkiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDgifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaXNfYV9iIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNobyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5vX2FyZ3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsaWNhdGlvbiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19uYXRpdmVfc3RyaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19uYXRpdmVfYnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlY2hvX25hdGl2ZV91aW50NjQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlY2hvX25hdGl2ZV9iaWd1aW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlY2hvX25hdGl2ZV90dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxieXRlW10sdWludDY0LHVpbnQ1MTIpIiwic3RydWN0IjoiRWNob05hdGl2ZVR1cGxlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19uZXN0ZWRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKChzdHJpbmcsc3RyaW5nKSwodWludDY0LHVpbnQ2NCxieXRlW10pKSIsInN0cnVjdCI6IkVjaG9OZXN0ZWRUdXBsZUFyZ1R1cGxlT2ZUdXBsZXMiLCJuYW1lIjoidHVwbGVfb2ZfdHVwbGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iigoc3RyaW5nLHN0cmluZyksKHVpbnQ2NCx1aW50NjQsYnl0ZVtdKSkiLCJzdHJ1Y3QiOiJFY2hvTmVzdGVkVHVwbGVBcmdUdXBsZU9mVHVwbGVzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV0dXJuX2FyZ3NfYWZ0ZXJfMTR0aCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9hMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2EzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9hNSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2E2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9hOCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2E5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTEwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTExIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTEyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTEzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYTE0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExNSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTE3IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExOCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ4LHVpbnQ4LHVpbnQ4LHVpbnQ4KSIsInN0cnVjdCI6IlJldHVybkFyZ3NBZnRlcjE0VGhBcmdBMTkiLCJuYW1lIjoiYTE5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEyMCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ3NfYXJlX2VxdWFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IkxvZ01lc3NhZ2UiLCJuYW1lIjoibG9nXzEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IkxvZ01lc3NhZ2UiLCJuYW1lIjoibG9nXzIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyODMsMjg5LDI5NSwzMDEsMzA3LDMxMywzOTNdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OSwyMzQsMzI4LDQ5Myw1ODgsNjE1LDYzNiw2NjYsNjk2LDcxMSw3NDEsNzU2LDc3MSw3ODYsODAxLDgxNiw4NDAsODU5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTAwXSwiZXJyb3JNZXNzYWdlIjoiYSBpcyBub3QgYSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDNdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTVdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDddLCJlcnJvck1lc3NhZ2UiOiJiIGlzIG5vdCBiIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcyLDIzNywzMzEsNDk2LDU5MSw2MTgsNjM5LDY2OSw2OTksNzE0LDc0NCw3NTksNzc0LDc4OSw4MDQsODE5LDg0Myw4NjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3LDYwMl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdOalFnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSURCNE5qVTJNelk0Tm1ZellUSXdJREI0TURBd05DQXdlREF4Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNalVLSUNBZ0lDOHZJR05zWVhOeklFeHZaMmRsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREl6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WXpjM01qRXlZbU1nTUhnNVltWTRNVGt4TXlBd2VHSTROakpsWlRFNUlEQjRNMk14TURVNFpEa2dNSGcyWVdZME5Ua3pNQ0F3ZUdJMFlqUXpNelJsSURCNE5tVmxaRGRsWXpNZ01IaGlOVEF3WlRFeE1TQXdlR05rTnpJM1lqY3hJREI0TURRek4ySXhOMlVnTUhnMFlUUTBOR00zTnlBd2VESTJOVGxsT0RFNElEQjRZVGxtWWpaalpqRWdNSGhrT0dOak16WXpZaUF3ZURFMlpUQXpPVEU1SURCNFlXSXlOekZqWlRRZ01IaGlZVEJpTkRNNE1TQXdlR1JrWkRBM01UZzFJQzh2SUcxbGRHaHZaQ0FpYVhOZllWOWlLR0o1ZEdWYlhTeGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWldOb2J5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKdWIxOWhjbWR6S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW14dlp5aDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYkc5bktIVnBiblExTVRJcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYkc5bktITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0pzYjJjb1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnNiMmNvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0lteHZaeWhoYzNObGRDeGhZMk52ZFc1MExHRndjR3hwWTJGMGFXOXVLWFp2YVdRaUxDQnRaWFJvYjJRZ0lteHZaeWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltVmphRzlmYm1GMGFYWmxYM04wY21sdVp5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbFkyaHZYMjVoZEdsMlpWOWllWFJsY3loaWVYUmxXMTBwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0psWTJodlgyNWhkR2wyWlY5MWFXNTBOalFvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaV05vYjE5dVlYUnBkbVZmWW1sbmRXbHVkQ2gxYVc1ME5URXlLWFZwYm5RMU1USWlMQ0J0WlhSb2IyUWdJbVZqYUc5ZmJtRjBhWFpsWDNSMWNHeGxLSE4wY21sdVp5eGllWFJsVzEwc2RXbHVkRFkwTEhWcGJuUTFNVElwS0hOMGNtbHVaeXhpZVhSbFcxMHNkV2x1ZERZMExIVnBiblExTVRJcElpd2diV1YwYUc5a0lDSmxZMmh2WDI1bGMzUmxaRjkwZFhCc1pTZ29LSE4wY21sdVp5eHpkSEpwYm1jcExDaDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU2twS1Nnb2MzUnlhVzVuTEhOMGNtbHVaeWtzS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZEtTa2lMQ0J0WlhSb2IyUWdJbkpsZEhWeWJsOWhjbWR6WDJGbWRHVnlYekUwZEdnb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBPQ3gxYVc1ME9DeDFhVzUwT0N4MWFXNTBPQ3dvZFdsdWREZ3NkV2x1ZERnc2RXbHVkRGdzZFdsdWREZ3BMSFZwYm5RNEtXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaWJHOW5jMTloY21WZlpYRjFZV3dvS0hWcGJuUTJOQ3h6ZEhKcGJtY3BMQ2gxYVc1ME5qUXNjM1J5YVc1bktTbGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlwYzE5aFgySmZjbTkxZEdWQU15QnRZV2x1WDJWamFHOWZjbTkxZEdWQU5DQnRZV2x1WDI1dlgyRnlaM05mY205MWRHVkFOU0J0WVdsdVgyeHZaMTl5YjNWMFpVQTJJRzFoYVc1ZmJHOW5YM0p2ZFhSbFFEY2diV0ZwYmw5c2IyZGZjbTkxZEdWQU9DQnRZV2x1WDJ4dloxOXliM1YwWlVBNUlHMWhhVzVmYkc5blgzSnZkWFJsUURFd0lHMWhhVzVmYkc5blgzSnZkWFJsUURFeElHMWhhVzVmYkc5blgzSnZkWFJsUURFeUlHMWhhVzVmWldOb2IxOXVZWFJwZG1WZmMzUnlhVzVuWDNKdmRYUmxRREV6SUcxaGFXNWZaV05vYjE5dVlYUnBkbVZmWW5sMFpYTmZjbTkxZEdWQU1UUWdiV0ZwYmw5bFkyaHZYMjVoZEdsMlpWOTFhVzUwTmpSZmNtOTFkR1ZBTVRVZ2JXRnBibDlsWTJodlgyNWhkR2wyWlY5aWFXZDFhVzUwWDNKdmRYUmxRREUySUcxaGFXNWZaV05vYjE5dVlYUnBkbVZmZEhWd2JHVmZjbTkxZEdWQU1UY2diV0ZwYmw5bFkyaHZYMjVsYzNSbFpGOTBkWEJzWlY5eWIzVjBaVUF4T0NCdFlXbHVYM0psZEhWeWJsOWhjbWR6WDJGbWRHVnlYekUwZEdoZmNtOTFkR1ZBTVRrZ2JXRnBibDlzYjJkelgyRnlaVjlsY1hWaGJGOXliM1YwWlVBeU1Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREkzT2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakkxQ2lBZ0lDQXZMeUJqYkdGemN5Qk1iMmRuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZiRzluYzE5aGNtVmZaWEYxWVd4ZmNtOTFkR1ZBTWpBNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TVRJNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCTWIyZG5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qRXlPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR3h2WjNOZllYSmxYMlZ4ZFdGc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psZEhWeWJsOWhjbWR6WDJGbWRHVnlYekUwZEdoZmNtOTFkR1ZBTVRrNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TVRBd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCTWIyZG5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEZ0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRVS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVFVLSUNBZ0lHVjRkSEpoWTNRZ01TQXhJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UVUtJQ0FnSUdWNGRISmhZM1FnTWlBeElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRVS0lDQWdJR1Y0ZEhKaFkzUWdNeUF4SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVFVLSUNBZ0lHVjRkSEpoWTNRZ05DQTBJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UVUtJQ0FnSUdWNGRISmhZM1FnT0NBeElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakV3TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhKbGRIVnlibDloY21kelgyRm1kR1Z5WHpFMGRHZ0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXTm9iMTl1WlhOMFpXUmZkSFZ3YkdWZmNtOTFkR1ZBTVRnNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2T0RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1qVUtJQ0FnSUM4dklHTnNZWE56SUV4dloyZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ09DQTRJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2T0RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCbFkyaHZYMjVsYzNSbFpGOTBkWEJzWlFvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z05Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXTm9iMTl1WVhScGRtVmZkSFZ3YkdWZmNtOTFkR1ZBTVRjNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2T0RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1qVUtJQ0FnSUM4dklHTnNZWE56SUV4dloyZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZPRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJsWTJodlgyNWhkR2wyWlY5MGRYQnNaUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEYzJJQzh2SURjMkNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREEwWXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWamFHOWZibUYwYVhabFgySnBaM1ZwYm5SZmNtOTFkR1ZBTVRZNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TnprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1qVUtJQ0FnSUM4dklHTnNZWE56SUV4dloyZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pjNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1pXTm9iMTl1WVhScGRtVmZZbWxuZFdsdWRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWldOb2IxOXVZWFJwZG1WZmRXbHVkRFkwWDNKdmRYUmxRREUxT2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPamMxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pJMUNpQWdJQ0F2THlCamJHRnpjeUJNYjJkblpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG8zTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUdWamFHOWZibUYwYVhabFgzVnBiblEyTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlsWTJodlgyNWhkR2wyWlY5aWVYUmxjMTl5YjNWMFpVQXhORG9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzNNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG95TlFvZ0lDQWdMeThnWTJ4aGMzTWdURzluWjJWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qY3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdaV05vYjE5dVlYUnBkbVZmWW5sMFpYTUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWamFHOWZibUYwYVhabFgzTjBjbWx1WjE5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG8yTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveU5Rb2dJQ0FnTHk4Z1kyeGhjM01nVEc5bloyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPalkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWldOb2IxOXVZWFJwZG1WZmMzUnlhVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXNiMmRmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFV4UFIxOU5SVlJJVDBSZlRrRk5SU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCTWIyZG5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvMk13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0c1aGJXVTlURTlIWDAxRlZFaFBSRjlPUVUxRktRb2dJQ0FnWTJGc2JITjFZaUJzYjJkZllXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlzYjJkZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TlRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakkxQ2lBZ0lDQXZMeUJqYkdGemN5Qk1iMmRuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGd2NHeHBZMkYwYVc5dWN3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvYm1GdFpUMU1UMGRmVFVWVVNFOUVYMDVCVFVVcENpQWdJQ0JqWVd4c2MzVmlJR3h2WjE5aGMzTmxkRjloWTJOdmRXNTBYMkZ3Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlzYjJkZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakkxQ2lBZ0lDQXZMeUJqYkdGemN5Qk1iMmRuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzFOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5VEU5SFgwMUZWRWhQUkY5T1FVMUZLUW9nSUNBZ1kyRnNiSE4xWWlCc2IyZGZZbmwwWlhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYkc5blgzSnZkWFJsUURrNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TlRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakkxQ2lBZ0lDQXZMeUJqYkdGemN5Qk1iMmRuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzFNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5VEU5SFgwMUZWRWhQUkY5T1FVMUZLUW9nSUNBZ1kyRnNiSE4xWWlCc2IyZGZZbTl2YkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlzYjJkZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG8wTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLRzVoYldVOVRFOUhYMDFGVkVoUFJGOU9RVTFGS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNalVLSUNBZ0lDOHZJR05zWVhOeklFeHZaMmRsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qUTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDFNVDBkZlRVVlVTRTlFWDA1QlRVVXBDaUFnSUNCallXeHNjM1ZpSUd4dloxOXpkSEpwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYkc5blgzSnZkWFJsUURjNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TkRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakkxQ2lBZ0lDQXZMeUJqYkdGemN5Qk1iMmRuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzBNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5VEU5SFgwMUZWRWhQUkY5T1FVMUZLUW9nSUNBZ1kyRnNiSE4xWWlCc2IyZGZkV2x1ZERVeE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5c2IyZGZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvek9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0c1aGJXVTlURTlIWDAxRlZFaFBSRjlPUVUxRktRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TWpVS0lDQWdJQzh2SUdOc1lYTnpJRXh2WjJkbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPak01Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQxTVQwZGZUVVZVU0U5RVgwNUJUVVVwQ2lBZ0lDQmpZV3hzYzNWaUlHeHZaMTkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmJtOWZZWEpuYzE5eWIzVjBaVUExT2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPak0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREpoQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaV05vYjE5eWIzVjBaVUEwT2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPak14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pJMUNpQWdJQ0F2THlCamJHRnpjeUJNYjJkblpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG96TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUdWamFHOEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmFYTmZZVjlpWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TWpVS0lDQWdJQzh2SUdOc1lYTnpJRXh2WjJkbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk1qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQnBjMTloWDJJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFESXpPZ29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCTWIyZG5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpjS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JDNXNiMmRuWlhJdVRHOW5aMlZ5TG1selgyRmZZaWhoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21selgyRmZZam9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUb3lOaTB5TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYVhOZllWOWlLSE5sYkdZc0lHRTZJRUo1ZEdWekxDQmlPaUJDZVhSbGN5a2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdZU0E5UFNCaUltRWlMQ0FpWVNCcGN5QnViM1FnWVNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZU0JwY3lCdWIzUWdZUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qSTVDaUFnSUNBdkx5QmhjM05sY25RZ1lpQTlQU0JpSW1JaUxDQWlZaUJwY3lCdWIzUWdZaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROaklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lpQnBjeUJ1YjNRZ1lnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBlWEJsWkY5aFltbGZZMkZzYkM1c2IyZG5aWEl1VEc5bloyVnlMbVZqYUc4b2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWldOb2J6b0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvek1TMHpNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdaV05vYnloelpXeG1MQ0IyWVd4MVpUb2dZWEpqTkM1VGRISnBibWNwSUMwK0lHRnlZelF1VTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TXpNS0lDQWdJQzh2SUhKbGRIVnliaUFpWldOb2J6b2dJaUFySUhaaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qVTJNelk0Tm1ZellUSXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblI1Y0dWa1gyRmlhVjlqWVd4c0xteHZaMmRsY2k1TWIyZG5aWEl1Ykc5blgzVnBiblEyTkNoMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbXh2WjE5MWFXNTBOalE2Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZNemt0TkRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBVeFBSMTlOUlZSSVQwUmZUa0ZOUlNrS0lDQWdJQzh2SUdSbFppQnNiMmRmZFdsdWREWTBLSE5sYkdZc0lIWmhiSFZsT2lCaGNtTTBMbFZKYm5RMk5Da2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPalF4Q2lBZ0lDQXZMeUJzYjJjb2RtRnNkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeHZad29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JDNXNiMmRuWlhJdVRHOW5aMlZ5TG14dloxOTFhVzUwTlRFeUtIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LYkc5blgzVnBiblExTVRJNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TkRNdE5EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNodVlXMWxQVXhQUjE5TlJWUklUMFJmVGtGTlJTa0tJQ0FnSUM4dklHUmxaaUJzYjJkZmRXbHVkRFV4TWloelpXeG1MQ0IyWVd4MVpUb2dZWEpqTkM1VlNXNTBOVEV5S1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk5EVUtJQ0FnSUM4dklHeHZaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkblpYSXViRzluWDNOMGNtbHVaeWgyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNteHZaMTl6ZEhKcGJtYzZDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk5EY3RORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFV4UFIxOU5SVlJJVDBSZlRrRk5SU2tLSUNBZ0lDOHZJR1JsWmlCc2IyZGZjM1J5YVc1bktITmxiR1lzSUhaaGJIVmxPaUJoY21NMExsTjBjbWx1WnlrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qUTVDaUFnSUNBdkx5QnNiMmNvZG1Gc2RXVXVibUYwYVhabEtTQWdJeUJrWldOdlpHVWdkRzhnY21WdGIzWmxJR2hsWVdSbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SNWNHVmtYMkZpYVY5allXeHNMbXh2WjJkbGNpNU1iMmRuWlhJdWJHOW5YMkp2YjJ3b2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BzYjJkZlltOXZiRG9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzFNUzAxTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLRzVoYldVOVRFOUhYMDFGVkVoUFJGOU9RVTFGS1FvZ0lDQWdMeThnWkdWbUlHeHZaMTlpYjI5c0tITmxiR1lzSUhaaGJIVmxPaUJoY21NMExrSnZiMndwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvMU13b2dJQ0FnTHk4Z2JHOW5LRUo1ZEdWektHSWlWSEoxWlNJcElHbG1JSFpoYkhWbExtNWhkR2wyWlNCbGJITmxJRUo1ZEdWektHSWlSbUZzYzJVaUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEUTJOakUyWXpjek5qVWdNSGcxTkRjeU56VTJOU0F2THlBd2VEUTJOakUyWXpjek5qVXNJREI0TlRRM01qYzFOalVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSGx3WldSZllXSnBYMk5oYkd3dWJHOW5aMlZ5TGt4dloyZGxjaTVzYjJkZllubDBaWE1vZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHNiMmRmWW5sMFpYTTZDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk5UVXROVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFV4UFIxOU5SVlJJVDBSZlRrRk5SU2tLSUNBZ0lDOHZJR1JsWmlCc2IyZGZZbmwwWlhNb2MyVnNaaXdnZG1Gc2RXVTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TlRjS0lDQWdJQzh2SUd4dlp5aDJZV3gxWlM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSGx3WldSZllXSnBYMk5oYkd3dWJHOW5aMlZ5TGt4dloyZGxjaTVzYjJkZllYTnpaWFJmWVdOamIzVnVkRjloY0hBb1lYTnpaWFE2SUhWcGJuUTJOQ3dnWVdOamIzVnVkRG9nWW5sMFpYTXNJR0Z3Y0RvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwc2IyZGZZWE56WlhSZllXTmpiM1Z1ZEY5aGNIQTZDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk5Ua3ROakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHVZVzFsUFV4UFIxOU5SVlJJVDBSZlRrRk5SU2tLSUNBZ0lDOHZJR1JsWmlCc2IyZGZZWE56WlhSZllXTmpiM1Z1ZEY5aGNIQW9jMlZzWml3Z1lYTnpaWFE2SUVGemMyVjBMQ0JoWTJOdmRXNTBPaUJCWTJOdmRXNTBMQ0JoY0hBNklFRndjR3hwWTJGMGFXOXVLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TmpFS0lDQWdJQzh2SUd4dlp5aGhjM05sZEM1dVlXMWxMQ0JoWTJOdmRXNTBMbUo1ZEdWekxDQmhjSEF1WVdSa2NtVnpjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRTVoYldVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuUjVjR1ZrWDJGaWFWOWpZV3hzTG14dloyZGxjaTVNYjJkblpYSXViRzluWDJGa1pISmxjM01vWVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbXh2WjE5aFpHUnlaWE56T2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPall6TFRZMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvYm1GdFpUMU1UMGRmVFVWVVNFOUVYMDVCVFVVcENpQWdJQ0F2THlCa1pXWWdiRzluWDJGa1pISmxjM01vYzJWc1ppd2dZV1JrY21WemN6b2dZWEpqTkM1QlpHUnlaWE56S1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QjBlWEJsWkY5aFltbGZZMkZzYkM5c2IyZG5aWEl1Y0hrNk5qVUtJQ0FnSUM4dklHeHZaeWhoWkdSeVpYTnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSGx3WldSZllXSnBYMk5oYkd3dWJHOW5aMlZ5TGt4dloyZGxjaTVsWTJodlgyNWhkR2wyWlY5emRISnBibWNvZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taV05vYjE5dVlYUnBkbVZmYzNSeWFXNW5PZ29nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qWTNMVFk0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJsWTJodlgyNWhkR2wyWlY5emRISnBibWNvYzJWc1ppd2dkbUZzZFdVNklGTjBjbWx1WnlrZ0xUNGdVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOamtLSUNBZ0lDOHZJSEpsZEhWeWJpQWlaV05vYnpvZ0lpQXJJSFpoYkhWbENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbFkyaHZPaUFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1MGVYQmxaRjloWW1sZlkyRnNiQzVzYjJkblpYSXVURzluWjJWeUxtVmphRzlmYm1GMGFYWmxYMko1ZEdWektIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21WamFHOWZibUYwYVhabFgySjVkR1Z6T2dvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPamN4TFRjeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCbFkyaHZYMjVoZEdsMlpWOWllWFJsY3loelpXeG1MQ0IyWVd4MVpUb2dRbmwwWlhNcElDMCtJRUo1ZEdWek9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZOek1LSUNBZ0lDOHZJSEpsZEhWeWJpQmlJbVZqYUc4NklDSWdLeUIyWVd4MVpRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWTFOak0yT0RabU0yRXlNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhsd1pXUmZZV0pwWDJOaGJHd3ViRzluWjJWeUxreHZaMmRsY2k1bFkyaHZYMjVoZEdsMlpWOTFhVzUwTmpRb2RtRnNkV1U2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwbFkyaHZYMjVoZEdsMlpWOTFhVzUwTmpRNkNpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TnpVdE56WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHVmphRzlmYm1GMGFYWmxYM1ZwYm5RMk5DaHpaV3htTENCMllXeDFaVG9nVlVsdWREWTBLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvM053b2dJQ0FnTHk4Z2NtVjBkWEp1SUhaaGJIVmxJQ3NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBlWEJsWkY5aFltbGZZMkZzYkM1c2IyZG5aWEl1VEc5bloyVnlMbVZqYUc5ZmJtRjBhWFpsWDJKcFozVnBiblFvZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taV05vYjE5dVlYUnBkbVZmWW1sbmRXbHVkRG9LSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUbzNPUzA0TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWldOb2IxOXVZWFJwZG1WZlltbG5kV2x1ZENoelpXeG1MQ0IyWVd4MVpUb2dRbWxuVlVsdWRDa2dMVDRnUW1sblZVbHVkRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pneENpQWdJQ0F2THlCeVpYUjFjbTRnZG1Gc2RXVWdLeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVFvZ0lDQWdZaXNLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhsd1pXUmZZV0pwWDJOaGJHd3ViRzluWjJWeUxreHZaMmRsY2k1bFkyaHZYMjVoZEdsMlpWOTBkWEJzWlNoek9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNc0lIVTZJSFZwYm5RMk5Dd2dZblU2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTXNJSFZwYm5RMk5Dd2dZbmwwWlhNNkNtVmphRzlmYm1GMGFYWmxYM1IxY0d4bE9nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pnekxUZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmxZMmh2WDI1aGRHbDJaVjkwZFhCc1pTZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxDQnpPaUJUZEhKcGJtY3NJR0k2SUVKNWRHVnpMQ0IxT2lCVlNXNTBOalFzSUdKMU9pQkNhV2RWU1c1MENpQWdJQ0F2THlBcElDMCtJSFIxY0d4bFcxTjBjbWx1Wnl3Z1FubDBaWE1zSUZWSmJuUTJOQ3dnUW1sblZVbHVkRjA2Q2lBZ0lDQndjbTkwYnlBMElEUUtJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUNKbFkyaHZPaUFpSUNzZ2N5d2dZaUpsWTJodk9pQWlJQ3NnWWl3Z2RTQXJJREVzSUdKMUlDc2dNUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaV05vYnpvZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJOVFl6TmpnMlpqTmhNakFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Rb2dJQ0FnWWlzS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRIbHdaV1JmWVdKcFgyTmhiR3d1Ykc5bloyVnlMa3h2WjJkbGNpNWxZMmh2WDI1bGMzUmxaRjkwZFhCc1pTaDBkWEJzWlY5dlpsOTBkWEJzWlhNdU1DNHdPaUJpZVhSbGN5d2dkSFZ3YkdWZmIyWmZkSFZ3YkdWekxqQXVNVG9nWW5sMFpYTXNJSFIxY0d4bFgyOW1YM1IxY0d4bGN5NHhMakE2SUhWcGJuUTJOQ3dnZEhWd2JHVmZiMlpmZEhWd2JHVnpMakV1TVRvZ1lubDBaWE1zSUhSMWNHeGxYMjltWDNSMWNHeGxjeTR4TGpJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE1zSUhWcGJuUTJOQ3dnWW5sMFpYTXNJR0o1ZEdWek9ncGxZMmh2WDI1bGMzUmxaRjkwZFhCc1pUb0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRvNE9TMDVNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdaV05vYjE5dVpYTjBaV1JmZEhWd2JHVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd2dkSFZ3YkdWZmIyWmZkSFZ3YkdWek9pQjBkWEJzWlZ0MGRYQnNaVnRUZEhKcGJtY3NJR0Z5WXpRdVUzUnlhVzVuWFN3Z2RIVndiR1ZiVlVsdWREWTBMQ0JoY21NMExsVkpiblEyTkN3Z1FubDBaWE5kWFFvZ0lDQWdMeThnS1NBdFBpQjBkWEJzWlZ0MGRYQnNaVnRUZEhKcGJtY3NJR0Z5WXpRdVUzUnlhVzVuWFN3Z2RIVndiR1ZiVlVsdWREWTBMQ0JoY21NMExsVkpiblEyTkN3Z1FubDBaWE5kWFRvS0lDQWdJSEJ5YjNSdklEVWdOUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qazBDaUFnSUNBdkx5QnlaWFIxY200Z0tDSmxZMmh2T2lBaUlDc2djM1J5YVc1bkxDQWlaV05vYnpvZ0lpQXJJR0Z5WXpSZmMzUnlhVzVuS1N3Z0tBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpXTm9iem9nSWdvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyTlRZek5qZzJaak5oTWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG81TlFvZ0lDQWdMeThnZFRZMElDc2dNU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG81TmdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb1lYSmpORjkxTmpRdWJtRjBhWFpsSUNzZ01Ta3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUIwZVhCbFpGOWhZbWxmWTJGc2JDOXNiMmRuWlhJdWNIazZPVGNLSUNBZ0lDOHZJR0lpWldOb2J6b2dJaUFySUdKNWRHVjZMQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFkxTmpNMk9EWm1NMkV5TUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSNWNHVmtYMkZpYVY5allXeHNMMnh2WjJkbGNpNXdlVG81TkMwNU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUNnaVpXTm9iem9nSWlBcklITjBjbWx1Wnl3Z0ltVmphRzg2SUNJZ0t5QmhjbU0wWDNOMGNtbHVaeWtzSUNnS0lDQWdJQzh2SUNBZ0lDQjFOalFnS3lBeExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0dGeVl6UmZkVFkwTG01aGRHbDJaU0FySURFcExBb2dJQ0FnTHk4Z0lDQWdJR0lpWldOb2J6b2dJaUFySUdKNWRHVjZMQW9nSUNBZ0x5OGdLUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZVhCbFpGOWhZbWxmWTJGc2JDNXNiMmRuWlhJdVRHOW5aMlZ5TG5KbGRIVnlibDloY21kelgyRm1kR1Z5WHpFMGRHZ29YMkV4T2lCaWVYUmxjeXdnWDJFeU9pQmllWFJsY3l3Z1gyRXpPaUJpZVhSbGN5d2dYMkUwT2lCaWVYUmxjeXdnWDJFMU9pQmllWFJsY3l3Z1gyRTJPaUJpZVhSbGN5d2dYMkUzT2lCaWVYUmxjeXdnWDJFNE9pQmllWFJsY3l3Z1gyRTVPaUJpZVhSbGN5d2dYMkV4TURvZ1lubDBaWE1zSUY5aE1URTZJR0o1ZEdWekxDQmZZVEV5T2lCaWVYUmxjeXdnWDJFeE16b2dZbmwwWlhNc0lGOWhNVFE2SUdKNWRHVnpMQ0JoTVRVNklHSjVkR1Z6TENCaE1UWTZJR0o1ZEdWekxDQmhNVGM2SUdKNWRHVnpMQ0JoTVRnNklHSjVkR1Z6TENCaE1UazZJR0o1ZEdWekxDQmhNakE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LY21WMGRYSnVYMkZ5WjNOZllXWjBaWEpmTVRSMGFEb0tJQ0FnSUM4dklIUjVjR1ZrWDJGaWFWOWpZV3hzTDJ4dloyZGxjaTV3ZVRveE1EQXRNVEl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJ5WlhSMWNtNWZZWEpuYzE5aFpuUmxjbDh4TkhSb0tBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdYMkV4T2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JmWVRJNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUY5aE16b2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1gyRTBPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQmZZVFU2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJRjloTmpvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWDJFM09pQmhjbU0wTGxWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCZllUZzZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lGOWhPVG9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdYMkV4TURvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWDJFeE1Ub2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1gyRXhNam9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdYMkV4TXpvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWDJFeE5Eb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1lURTFPaUJoY21NMExsVkpiblE0TEFvZ0lDQWdMeThnSUNBZ0lHRXhOam9nWVhKak5DNVZTVzUwT0N3S0lDQWdJQzh2SUNBZ0lDQmhNVGM2SUdGeVl6UXVWVWx1ZERnc0NpQWdJQ0F2THlBZ0lDQWdZVEU0T2lCaGNtTTBMbFZKYm5RNExBb2dJQ0FnTHk4Z0lDQWdJR0V4T1RvZ1lYSmpOQzVVZFhCc1pWdGhjbU0wTGxWSmJuUTRMQ0JoY21NMExsVkpiblE0TENCaGNtTTBMbFZKYm5RNExDQmhjbU0wTGxWSmJuUTRYU3dLSUNBZ0lDOHZJQ0FnSUNCaE1qQTZJR0Z5WXpRdVZVbHVkRGdzQ2lBZ0lDQXZMeUFwSUMwK0lHRnlZelF1UkhsdVlXMXBZMEo1ZEdWek9nb2dJQ0FnY0hKdmRHOGdNakFnTVFvZ0lDQWdMeThnZEhsd1pXUmZZV0pwWDJOaGJHd3ZiRzluWjJWeUxuQjVPakV5TkFvZ0lDQWdMeThnYkdGemRGOWhjbWNnUFNCaGNtTTBMbFIxY0d4bEtDaGhNVFVzSUdFeE5pd2dZVEUzTENCaE1UZ3NJR0V4T1N3Z1lUSXdLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXROZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMGVYQmxaRjloWW1sZlkyRnNiQzlzYjJkblpYSXVjSGs2TVRJMUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxtRndjR3hwWTJGMGFXOXVYMkZ5WjNNb01UVXBJRDA5SUd4aGMzUmZZWEpuTG1KNWRHVnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhOUW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFI1Y0dWa1gyRmlhVjlqWVd4c0wyeHZaMmRsY2k1d2VUb3hNallLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aHNZWE4wWDJGeVp5NWllWFJsY3lrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SNWNHVmtYMkZpYVY5allXeHNMbXh2WjJkbGNpNU1iMmRuWlhJdWJHOW5jMTloY21WZlpYRjFZV3dvYkc5blh6RXViR1YyWld3NklIVnBiblEyTkN3Z2JHOW5YekV1YldWemMyRm5aVG9nWW5sMFpYTXNJR3h2WjE4eUxteGxkbVZzT2lCMWFXNTBOalFzSUd4dloxOHlMbTFsYzNOaFoyVTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbXh2WjNOZllYSmxYMlZ4ZFdGc09nb2dJQ0FnTHk4Z2RIbHdaV1JmWVdKcFgyTmhiR3d2Ykc5bloyVnlMbkI1T2pFeU9DMHhNamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR3h2WjNOZllYSmxYMlZ4ZFdGc0tITmxiR1lzSUd4dloxOHhPaUJNYjJkTlpYTnpZV2RsTENCc2IyZGZNam9nVEc5blRXVnpjMkZuWlNrZ0xUNGdZbTl2YkRvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ0x5OGdkSGx3WldSZllXSnBYMk5oYkd3dmJHOW5aMlZ5TG5CNU9qRXpNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHeHZaMTh4SUQwOUlHeHZaMTh5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1BUMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVFCQUNDWUVCQlVmZkhVR1pXTm9iem9nQWdBRUFRRXhHMEVEVVlJU0JNZHlFcndFbS9nWkV3UzRZdTRaQkR3UVdOa0VhdlJaTUFTMHRETk9CRzd0ZnNNRXRRRGhFUVROY250eEJBUTNzWDRFU2tSTWR3UW1XZWdZQktuN2JQRUUyTXcyT3dRVzREa1pCS3NuSE9RRXVndERnUVRkMEhHRk5ob0FqaElDdEFLaEFva0NlZ0pyQWx3Q1RRSStBaUFDRVFIekFkVUJ3QUdsQVVZQW9RQkRBQUlqUXpFWkZFUXhHRVEyR2dGSkkxdExBU1ZaU3dJVlR3Tk9BbEpYQWdBMkdnSkpJMXRMQVNWWlN3SVZUd05PQWxKWEFnQ0lBNXFBQVFBalR3SlVLRXhRc0NKRE1Sa1VSREVZUkRZYUFUWWFBallhQXpZYUJEWWFCVFlhQmpZYUJ6WWFDRFlhQ1RZYUNqWWFDellhRERZYURUWWFEallhRDFjQUFUWWFEMWNCQVRZYUQxY0NBVFlhRDFjREFUWWFEMWNFQkRZYUQxY0lBWWdERVNoTVVMQWlRekVaRkVReEdFUTJHZ0ZKSTFsTEFZRUNXVXNDVHdKTEFsSkpJMWxMQVlFQ1dVc0NUd0pMQWxKWEFnQkxBaFZQQTA4RFR3SlNTd01WVHdSUEJFOENVa2tqVzBzQlZ3Z0lTd0tCRUZsTEF4VlBCRTRDVWxjQ0FJZ0NpMHNFRlJaWEJnSlBCVkJKRllFRUNCWlhCZ0lxVEZCTVVFOEVVRThERmtzQ0ZSWlhCZ0pQQTFCTVR3TlFnQUlBRWxCTVVFc0JGWUVFQ0JaWEJnSXFURkJQQWxCTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTVhOaG9FaUFJUFN3TVZGbGNHQWs4RVVFc0RGUlpYQmdKUEJGQlBBeFpMQXhVa0RrUWtyMDhFcTBzREZZRk1DQlpYQmdLQUFnQk1URkJQQWxCTVVFOENVRXhRS0V4UXNDSkRNUmtVUkRFWVJEWWFBWWdCdUVrVkpBNUVKSytyS0V4UXNDSkRNUmtVUkRFWVJEWWFBUmVJQVpRV0tFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FJZ0JkVWtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBSWdCVDBrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBWWdCTFNKRE1Sa1VSREVZUkRZYUFSZkFNRFlhQWhmQUhEWWFBeGZBTW9nQS9DSkRNUmtVUkRFWVJEWWFBWWdBNHlKRE1Sa1VSREVZUkRZYUFZZ0F1eUpETVJrVVJERVlSRFlhQVlnQW9pSkRNUmtVUkRFWVJEWWFBWWdBakNKRE1Sa1VSREVZUkRZYUFZZ0FkaUpETVJrVVJERVlSSUFNRlI5OGRRQUFBQUFBQUFBcXNDSkRNUmtVUkRFWVJEWWFBWWdBT3loTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0NJQUEwaVF6RVpRUDB2TVJnVVJDSkRpZ0lBaS82QUFXRVNSSXYvZ0FGaUVrU0ppZ0VCaS85WEFnQXBURkJKRlJaWEJnSk1VSW1LQVFDTC83Q0ppZ0VBaS8rd2lZb0JBSXYvVndJQXNJbUtBUUNML3lOVGdnSUZSbUZzYzJVRVZISjFaVThDVGJDSmlnRUFpLzlYQWdDd2lZb0RBSXY5Y1FSRWkvNVFpLzl5Q0VSUXNJbUtBUUNMLzdDSmlnRUJLWXYvVUltS0FRRXBpLzlRaVlvQkFZdi9JZ2lKaWdFQmkvOHJvSW1LQkFRcGkveFFLWXY5VUl2K0lnaUwveXVnaVlvRkJTbUwrMUNML0ZjQ0FDbE1VRWtWRmxjR0FreFFpLzBpQ0l2K0Z5SUlGaW1MLzFDSmloUUJpL3FMKzFDTC9GQ0wvVkNML2xDTC8xQTJHZzlMQVJKRVNSVVdWd1lDVEZDSmlnUUJpL3lML2hLTC9Zdi9FaENKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
