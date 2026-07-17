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

namespace Arc56.Generated.algorandfoundation.puya.Contract_7c955978
{


    //
    // Contract docstring
    //
    public class ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EventOnly : AVMObjectType
            {
                public ulong X { get; set; }

                public ulong Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EventOnly Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EventOnly();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is ulong vYValue) { ret.Y = vYValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EventOnly);
                }
                public bool Equals(EventOnly? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EventOnly left, EventOnly right)
                {
                    return EqualityComparer<EventOnly>.Default.Equals(left, right);
                }
                public static bool operator !=(EventOnly left, EventOnly right)
                {
                    return !(left == right);
                }

            }

            public class SharedStruct : AVMObjectType
            {
                public byte[] Foo { get; set; }

                public byte Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SharedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SharedStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is byte[] vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SharedStruct);
                }
                public bool Equals(SharedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SharedStruct left, SharedStruct right)
                {
                    return EqualityComparer<SharedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(SharedStruct left, SharedStruct right)
                {
                    return !(left == right);
                }

            }

            public class StateStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public string B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.From(B);
                    stringRef[ret.Count] = vB.Encode();
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

                public static StateStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new StateStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    var indexB = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.Decode(bytes.Skip(indexB + prefixOffset).ToArray());
                    var valueB = vB.ToValue();
                    if (valueB is string vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StateStruct);
                }
                public bool Equals(StateStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StateStruct left, StateStruct right)
                {
                    return EqualityComparer<StateStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(StateStruct left, StateStruct right)
                {
                    return !(left == right);
                }

            }

            public class TopLevelStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public string B { get; set; }

                public Structs.SharedStruct Shared { get; set; } = new Structs.SharedStruct();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.From(B);
                    stringRef[ret.Count] = vB.Encode();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Shared.ToByteArray();
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

                public static TopLevelStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new TopLevelStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    var indexB = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.Decode(bytes.Skip(indexB + prefixOffset).ToArray());
                    var valueB = vB.ToValue();
                    if (valueB is string vBValue) { ret.B = vBValue; }
                    var indexShared = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Shared = Structs.SharedStruct.Parse(bytes.Skip(indexShared + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TopLevelStruct);
                }
                public bool Equals(TopLevelStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TopLevelStruct left, TopLevelStruct right)
                {
                    return EqualityComparer<TopLevelStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(TopLevelStruct left, TopLevelStruct right)
                {
                    return !(left == right);
                }

            }

            public class TemplateValueReturn : AVMObjectType
            {
                public Structs.SharedStruct Field0 { get; set; } = new Structs.SharedStruct();

                public ulong Field1 { get; set; }

                public string Field2 { get; set; }

                public byte Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Field0.ToByteArray();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
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

                public static TemplateValueReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new TemplateValueReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.SharedStruct.Parse(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
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
                    return Equals(obj as TemplateValueReturn);
                }
                public bool Equals(TemplateValueReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TemplateValueReturn left, TemplateValueReturn right)
                {
                    return EqualityComparer<TemplateValueReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(TemplateValueReturn left, TemplateValueReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class SharedStructEvent
            {
                public static readonly byte[] Selector = new byte[4] { 217, 63, 55, 78 };
                public const string Signature = "SharedStruct(byte[],uint8)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Foo { get; set; }
                public byte Bar { get; set; }

                public static SharedStructEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SharedStructEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is byte[] vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

            }

            public class AnonymousEvent
            {
                public static readonly byte[] Selector = new byte[4] { 30, 114, 175, 78 };
                public const string Signature = "Anonymous(string,(byte[],uint8))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Field1 { get; set; }
                public Structs.SharedStruct Field2 { get; set; }

                public static AnonymousEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AnonymousEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(eventData.Skip(indexField1).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field2 = Structs.SharedStruct.Parse(eventData.Skip(indexField2).ToArray());
                    return ret;

                }

            }

            public class Anonymous2Event
            {
                public static readonly byte[] Selector = new byte[4] { 17, 197, 71, 186 };
                public const string Signature = "Anonymous2((uint64,uint64),(byte[],uint8))";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Structs.EventOnly Field1 { get; set; }
                public Structs.SharedStruct Field2 { get; set; }

                public static Anonymous2Event Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Anonymous2Event();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    ret.Field1 = Structs.EventOnly.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field2 = Structs.SharedStruct.Parse(eventData.Skip(indexField2).ToArray());
                    return ret;

                }

            }

        }

        ///<summary>
        ///Method docstring
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Method docstring2
        ///</summary>
        /// <param name="arg"> TopLevelStruct</param>
        /// <param name="shared"> SharedStruct</param>
        public async Task<ulong> StructArg(Structs.TopLevelStruct arg, Structs.SharedStruct shared, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 232, 228, 167 };

            var result = await base.CallApp(new List<object> { abiHandle, arg, shared }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> StructArg_Transactions(Structs.TopLevelStruct arg, Structs.SharedStruct shared, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 232, 228, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg, shared }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> TopLevelStruct</param>
        public async Task<Structs.SharedStruct> StructReturn(Structs.TopLevelStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 196, 222, 17 };

            var result = await base.SimApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SharedStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> StructReturn_Transactions(Structs.TopLevelStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 196, 222, 17 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> TopLevelStruct</param>
        public async Task EmitsError(Structs.TopLevelStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 202, 119, 9 };

            var result = await base.SimApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmitsError_Transactions(Structs.TopLevelStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 202, 119, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Emitter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 231, 98, 194 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Emitter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 231, 98, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="should_emit"> </param>
        public async Task ConditionalEmit(bool should_emit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 252, 82, 130 };
            var should_emitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); should_emitAbi.From(should_emit);

            var result = await base.CallApp(new List<object> { abiHandle, should_emitAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConditionalEmit_Transactions(bool should_emit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 252, 82, 130 };
            var should_emitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); should_emitAbi.From(should_emit);

            return await base.MakeTransactionList(new List<object> { abiHandle, should_emitAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TemplateValueReturn> TemplateValue(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 158, 236, 176 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TemplateValueReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TemplateValue_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 158, 236, 176 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        /// <param name="d"> EventOnly</param>
        /// <param name="e"> StateStruct</param>
        /// <param name="f"> </param>
        /// <param name="g"> </param>
        /// <param name="h"> </param>
        /// <param name="i"> </param>
        public async Task WithConstantDefaults(ulong a, ulong b, byte[] c, Structs.EventOnly d, Structs.StateStruct e, string[] f, string[] g, ulong h, ulong i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 142, 239, 154 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var fAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.String>(2, "string"); fAbi.From(f);
            var gAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string"); gAbi.From(g);
            var hAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hAbi.From(h);
            var iAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iAbi.From(i);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi, d, e, fAbi, gAbi, hAbi, iAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithConstantDefaults_Transactions(ulong a, ulong b, byte[] c, Structs.EventOnly d, Structs.StateStruct e, string[] f, string[] g, ulong h, ulong i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 142, 239, 154 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cAbi.From(c);
            var fAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.String>(2, "string"); fAbi.From(f);
            var gAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string"); gAbi.From(g);
            var hAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hAbi.From(h);
            var iAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); iAbi.From(i);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi, d, e, fAbi, gAbi, hAbi, iAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjoiQ29udHJhY3QgZG9jc3RyaW5nIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkV2ZW50T25seSI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifV0sIlNoYXJlZFN0cnVjdCI6W3sibmFtZSI6ImZvbyIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJiYXIiLCJ0eXBlIjoidWludDgifV0sIlN0YXRlU3RydWN0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InN0cmluZyJ9XSwiVG9wTGV2ZWxTdHJ1Y3QiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoic2hhcmVkIiwidHlwZSI6IlNoYXJlZFN0cnVjdCJ9XSwiVGVtcGxhdGVWYWx1ZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJTaGFyZWRTdHJ1Y3QifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50OCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiTWV0aG9kIGRvY3N0cmluZyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCIsIk9wdEluIl0sImNhbGwiOlsiTm9PcCIsIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RydWN0X2FyZyIsImRlc2MiOiJNZXRob2QgZG9jc3RyaW5nMiIsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZywoYnl0ZVtdLHVpbnQ4KSkiLCJzdHJ1Y3QiOiJUb3BMZXZlbFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwibmFtZSI6InNoYXJlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0cnVjdF9yZXR1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcsKGJ5dGVbXSx1aW50OCkpIiwic3RydWN0IjoiVG9wTGV2ZWxTdHJ1Y3QiLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWl0c19lcnJvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZywoYnl0ZVtdLHVpbnQ4KSkiLCJzdHJ1Y3QiOiJUb3BMZXZlbFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWl0dGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTaGFyZWRTdHJ1Y3QiLCJkZXNjIjoiVGhpcyBzdHJ1Y3QgaXMgc2hhcmVkIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvbyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBbm9ueW1vdXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiKGJ5dGVbXSx1aW50OCkiLCJzdHJ1Y3QiOiJTaGFyZWRTdHJ1Y3QiLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uZGl0aW9uYWxfZW1pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hvdWxkX2VtaXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFub255bW91czIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRXZlbnRPbmx5IiwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlbXBsYXRlX3ZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IigoYnl0ZVtdLHVpbnQ4KSx1aW50NjQsc3RyaW5nLHVpbnQ4KSIsInN0cnVjdCI6IlRlbXBsYXRlVmFsdWVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoX2NvbnN0YW50X2RlZmF1bHRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFIcz0iLCJ0eXBlIjoidWludDY0In19LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFPbz0iLCJ0eXBlIjoidWludDY0In19LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQU14TWpNPSIsInR5cGUiOiJieXRlW10ifX0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRXZlbnRPbmx5IiwibmFtZSI6ImQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFBRUFBQUFBQUFBQUFnPT0iLCJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIn19LHsidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IlN0YXRlU3RydWN0IiwibmFtZSI6ImUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFDb0FDZ0FMYjI0Z2RHaGxJR1ZrWjJVPSIsInR5cGUiOiIodWludDY0LHN0cmluZykifX0seyJ0eXBlIjoic3RyaW5nWzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsaXRlcmFsIiwiZGF0YSI6IkFBUUFDQUFDYUdrQUJuUm9aWEpsSVE9PSIsInR5cGUiOiJzdHJpbmdbMl0ifX0seyJ0eXBlIjoic3RyaW5nW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxpdGVyYWwiLCJkYXRhIjoiQUFJQUJBQUpBQU52Ym1VQUEzUjNidz09IiwidHlwZSI6InN0cmluZ1tdIn19LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFDbz0iLCJ0eXBlIjoidWludDY0In19LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUJOST0iLCJ0eXBlIjoidWludDY0In19XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiRGVsZXRlQXBwbGljYXRpb24iLCJOb09wIiwiT3B0SW4iXSwiY2FsbCI6WyJOb09wIiwiT3B0SW4iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2NjIsNzMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NiwyMDQsMjM2LDI4MiwzMjAsMzU4LDM5Miw1ODUsNjI3LDY3Niw2OTksNzQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+LCAyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPGFyYzQudWludDY0LGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzAsNTc4LDc3MSw3ODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy5hcmNfNTYuY29udHJhY3QuRXZlbnRPbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMuYXJjXzU2LmNvbnRyYWN0LlNoYXJlZFN0cnVjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNCwzMzAsMzk4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMuYXJjXzU2LmNvbnRyYWN0LlRvcExldmVsU3RydWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk2LDIyOCwzMTIsMzg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1aW50OFtdKSx1aW50OCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50NjQsKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1OCwyNzQsMzUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDY0LChsZW4rdXRmOFtdKSwoKGxlbit1aW50OFtdKSx1aW50OCkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5LDI5NSwzNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICh1aW50NjQsKGxlbit1dGY4W10pLCgobGVuK3VpbnQ4W10pLHVpbnQ4KSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3V0ZjhbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbit1dGY4W10pWzJdIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUzLDE3NCwxOTEsMjIzLDI2OSwyOTAsMzA3LDM0NSwzNjYsMzgzLDYxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDNdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIG1pZ2h0IGVycm9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA2XSwiZXJyb3JNZXNzYWdlIjoidGhpcyB3aWxsIGVycm9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUE0SUZSTlVFeGZRVlpOWDFWSlRsUTJOQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlQ0F3ZURFMU1XWTNZemMxSUZSTlVFeGZRVkpETkY5VlNVNVVPQ0JVVFZCTVgwRldUVjlUVkZKSlRrY2dWRTFRVEY5VFZGSlZRMVFLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE9Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5HTTFZell4WW1FZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpWOXliM1YwWlVBMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNU4yVTRaVFJoTnlBd2VEYzJZelJrWlRFeElEQjRZekZqWVRjM01Ea2dNSGcyWkdVM05qSmpNaUF3ZURVNVptTTFNamd5SURCNE9XUTVaV1ZqWWpBZ01IZzFaVGhsWldZNVlTQXZMeUJ0WlhSb2IyUWdJbk4wY25WamRGOWhjbWNvS0hWcGJuUTJOQ3h6ZEhKcGJtY3NLR0o1ZEdWYlhTeDFhVzUwT0NrcExDaGllWFJsVzEwc2RXbHVkRGdwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYzNSeWRXTjBYM0psZEhWeWJpZ29kV2x1ZERZMExITjBjbWx1Wnl3b1lubDBaVnRkTEhWcGJuUTRLU2twS0dKNWRHVmJYU3gxYVc1ME9Da2lMQ0J0WlhSb2IyUWdJbVZ0YVhSelgyVnljbTl5S0NoMWFXNTBOalFzYzNSeWFXNW5MQ2hpZVhSbFcxMHNkV2x1ZERncEtTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbGJXbDBkR1Z5S0NsMmIybGtJaXdnYldWMGFHOWtJQ0pqYjI1a2FYUnBiMjVoYkY5bGJXbDBLR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWdGNHeGhkR1ZmZG1Gc2RXVW9LU2dvWW5sMFpWdGRMSFZwYm5RNEtTeDFhVzUwTmpRc2MzUnlhVzVuTEhWcGJuUTRLU0lzSUcxbGRHaHZaQ0FpZDJsMGFGOWpiMjV6ZEdGdWRGOWtaV1poZFd4MGN5aDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU3dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeHpkSEpwYm1jcExITjBjbWx1WjFzeVhTeHpkSEpwYm1kYlhTeDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J6ZEhKMVkzUmZZWEpuSUhOMGNuVmpkRjl5WlhSMWNtNGdaWEp5YjNKeklHVnRhWFIwWlhJZ1kyOXVaR2wwYVc5dVlXeGZaVzFwZENCMFpXMXdiR0YwWlY5MllXeDFaU0IzYVhSb1gyTnZibk4wWVc1MFgyUmxabUYxYkhSekNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNakk2Q2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUdOc1lYTnpJRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUltRnNiRzkzSWl3Z1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlMQ0FpVDNCMFNXNGlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnphR3dLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnSmdvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhPRG9LSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhOM2FYUmphQ0J0WVdsdVgySmhjbVZmWTNKbFlYUmxRREU1SUcxaGFXNWZZbUZ5WlY5amNtVmhkR1ZBTVRrZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESXlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qSWdiV0ZwYmw5MGNtRnVjMmxsYm5SQU1qQUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MGNtRnVjMmxsYm5SQU1qQTZDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpd2dZV3hzYjNkZllXTjBhVzl1Y3oxYklrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZlkzSmxZWFJsUURFNU9nb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHTnlaV0YwWlQwaVlXeHNiM2NpTENCaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSXNJQ0pQY0hSSmJpSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEpqWHpVMkxtTnZiblJ5WVdOMExrTnZiblJ5WVdOMExuTjBjblZqZEY5aGNtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZEhKMVkzUmZZWEpuT2dvZ0lDQWdMeThnWVhKalh6VTJMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2gxYVc1ME5qUXNLR3hsYml0MWRHWTRXMTBwTENnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RNEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UUUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F5SUc5bUlDaDFhVzUwTmpRc0tHeGxiaXQxZEdZNFcxMHBMQ2dvYkdWdUszVnBiblE0VzEwcExIVnBiblE0S1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RNEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSFJsYzNSZlkyRnpaWE11WVhKalh6VTJMbU52Ym5SeVlXTjBMbFJ2Y0V4bGRtVnNVM1J5ZFdOMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwT0NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RHVnpkRjlqWVhObGN5NWhjbU5mTlRZdVkyOXVkSEpoWTNRdVUyaGhjbVZrVTNSeWRXTjBDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbWN1YzJoaGNtVmtJRDA5SUhOb1lYSmxaQ3dnSW5Sb2FYTWdiV2xuYUhRZ1pYSnliM0lpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUm9hWE1nYldsbmFIUWdaWEp5YjNJS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXlZUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NWhjbU5mTlRZdVkyOXVkSEpoWTNRdVEyOXVkSEpoWTNRdWMzUnlkV04wWDNKbGRIVnlibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMGNuVmpkRjl5WlhSMWNtNDZDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2gxYVc1ME5qUXNLR3hsYml0MWRHWTRXMTBwTENnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RNEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UUUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F5SUc5bUlDaDFhVzUwTmpRc0tHeGxiaXQxZEdZNFcxMHBMQ2dvYkdWdUszVnBiblE0VzEwcExIVnBiblE0S1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RNEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSFJsYzNSZlkyRnpaWE11WVhKalh6VTJMbU52Ym5SeVlXTjBMbFJ2Y0V4bGRtVnNVM1J5ZFdOMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNtTmZOVFl1WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1WlhKeWIzSnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWlhKeWIzSnpPZ29nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPams1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ibUZ0WlQwaVpXMXBkSE5mWlhKeWIzSWlMQ0J5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNoMWFXNTBOalFzS0d4bGJpdDFkR1k0VzEwcExDZ29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTRLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVFFLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeUlHOW1JQ2gxYVc1ME5qUXNLR3hsYml0MWRHWTRXMTBwTENnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RNEtTa0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEQWdiMllnS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERncENpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIwWlhOMFgyTmhjMlZ6TG1GeVkxODFOaTVqYjI1MGNtRmpkQzVVYjNCTVpYWmxiRk4wY25WamRBb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qRXdNUW9nSUNBZ0x5OGdZWE56WlhKMElHRnlaeTVoTG1KNWRHVnpJRDA5SUdGeVl6UXVWVWx1ZERnb01Da3VZbmwwWlhNc0lDSjBhR2x6SUhkcGJHd2daWEp5YjNJaUNpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkR2hwY3lCM2FXeHNJR1Z5Y205eUNpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNodVlXMWxQU0psYldsMGMxOWxjbkp2Y2lJc0lISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21OZk5UWXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXVaVzFwZEhSbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVZ0YVhSMFpYSTZDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVEExQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvVTJoaGNtVmtVM1J5ZFdOMEtHWnZiejFoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWhpSW1obGJHeHZNU0lwTENCaVlYSTlZWEpqTkM1VlNXNTBPQ2cwTWlrcEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpEa3paak0zTkdVd01EQXpNbUV3TURBMk5qZzJOVFpqTm1NMlpqTXhDaUFnSUNCc2IyY0tJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hNRGN0TVRFeENpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb0NpQWdJQ0F2THlBZ0lDQWdJa0Z1YjI1NWJXOTFjeUlzQ2lBZ0lDQXZMeUFnSUNBZ1UzUnlhVzVuS0NKb1pXeHNieUlwTEFvZ0lDQWdMeThnSUNBZ0lGTm9ZWEpsWkZOMGNuVmpkQ2htYjI4OVlYSmpOQzVFZVc1aGJXbGpRbmwwWlhNb1lpSm9aV3hzYnpJaUtTd2dZbUZ5UFdGeVl6UXVWVWx1ZERnb05ESXBLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREZsTnpKaFpqUmxNREF3TkRBd01HSXdNREExTmpnMk5UWmpObU0yWmpBd01ETXlZVEF3TURZMk9EWTFObU0yWXpabU16SUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZMTgxTmk1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1amIyNWthWFJwYjI1aGJGOWxiV2wwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyOXVaR2wwYVc5dVlXeGZaVzFwZERvS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRveE1UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdhV1lnYzJodmRXeGtYMlZ0YVhRNkNpQWdJQ0JpZWlCamIyNWthWFJwYjI1aGJGOWxiV2wwWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakV4TmkweE1qQUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ0tJQ0FnSUM4dklDQWdJQ0FpUVc1dmJubHRiM1Z6TWlJc0NpQWdJQ0F2THlBZ0lDQWdSWFpsYm5SUGJteDVLR0Z5WXpRdVZVbHVkRFkwS0RReUtTd2dZWEpqTkM1VlNXNTBOalFvTkRNcEtTd0tJQ0FnSUM4dklDQWdJQ0JUYUdGeVpXUlRkSEoxWTNRb1ptOXZQV0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLR0lpYUdWc2JHOHpJaWtzSUdKaGNqMWhjbU0wTGxWSmJuUTRLRFF5S1Nrc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE1XTTFORGRpWVRBd01EQXdNREF3TURBd01EQXdNbUV3TURBd01EQXdNREF3TURBd01ESmlNREF4TWpBd01ETXlZVEF3TURZMk9EWTFObU0yWXpabU16TUtJQ0FnSUd4dlp3b0tZMjl1WkdsMGFXOXVZV3hmWlcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk1URXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYSmpYelUyTG1OdmJuUnlZV04wTGtOdmJuUnlZV04wTG5SbGJYQnNZWFJsWDNaaGJIVmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWdGNHeGhkR1ZmZG1Gc2RXVTZDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVEk0Q2lBZ0lDQXZMeUJVWlcxd2JHRjBaVlpoY2x0aGNtTTBMbFZKYm5RNFhTZ2lRVkpETkY5VlNVNVVPQ0lwTEFvZ0lDQWdZbmwwWldOZk1pQXZMeUJVVFZCTVgwRlNRelJmVlVsT1ZEZ0tJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hNamNLSUNBZ0lDOHZJRlJsYlhCc1lYUmxWbUZ5VzFOMGNtbHVaMTBvSWtGV1RWOVRWRkpKVGtjaUtTd0tJQ0FnSUdKNWRHVmpYek1nTHk4Z1ZFMVFURjlCVmsxZlUxUlNTVTVIQ2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCVVpXMXdiR0YwWlZaaGNsdFZTVzUwTmpSZEtDSkJWazFmVlVsT1ZEWTBJaWtzQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5QlZrMWZWVWxPVkRZMENpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk1USTFDaUFnSUNBdkx5QlVaVzF3YkdGMFpWWmhjbHRUYUdGeVpXUlRkSEoxWTNSZEtDSlRWRkpWUTFRaUtTd0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z1ZFMVFURjlUVkZKVlExUUtJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hNaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TXdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQmtDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNtTmZOVFl1WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1ZDJsMGFGOWpiMjV6ZEdGdWRGOWtaV1poZFd4MGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRwZEdoZlkyOXVjM1JoYm5SZlpHVm1ZWFZzZEhNNkNpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk1UTXhMVEUwTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWVhKbmN6MTdDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSmhJam9nWVhKak5DNVZTVzUwTmpRb01USXpLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJbU1pT2lCQ2VYUmxjeWhpSWpFeU15SXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlZaUk2SUZWSmJuUTJOQ2d5TXpRcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVpDSTZJRVYyWlc1MFQyNXNlU2g0UFdGeVl6UXVWVWx1ZERZMEtERXBMQ0I1UFdGeVl6UXVWVWx1ZERZMEtESXBLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJbVVpT2lBb1ZVbHVkRFkwS0RReUtTd2dVM1J5YVc1bktDSnZiaUIwYUdVZ1pXUm5aU0lwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1ZaU9pQmhjbU0wTGxOMFlYUnBZMEZ5Y21GNUtHRnlZelF1VTNSeWFXNW5LQ0pvYVNJcExDQmhjbU0wTGxOMGNtbHVaeWdpZEdobGNtVWhJaWtwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FpWnlJNklHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNUtHRnlZelF1VTNSeWFXNW5LQ0p2Ym1VaUtTd2dZWEpqTkM1VGRISnBibWNvSW5SM2J5SXBLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJbWdpT2lCamIyNXpkR0Z1ZEY5dFpYUm9iMlFvS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1raU9pQmxZMmh2WDI1MWJXSmxjaWhWU1c1ME5qUW9NVEl6TkNrcExBb2dJQ0FnTHk4Z0lDQWdJSDBLSUNBZ0lDOHZJQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZEdWemRGOWpZWE5sY3k1aGNtTmZOVFl1WTI5dWRISmhZM1F1UlhabGJuUlBibXg1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFZ2IyWWdLSFZwYm5RMk5Dd29iR1Z1SzNWMFpqaGJYU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MGRYQnNaVHhoY21NMExuVnBiblEyTkN4aGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENCtDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3AzYVhSb1gyTnZibk4wWVc1MFgyUmxabUYxYkhSelgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TXpFdE1UUXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOWhjbWR6UFhzS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1FaU9pQmhjbU0wTGxWSmJuUTJOQ2d4TWpNcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVl5STZJRUo1ZEdWektHSWlNVEl6SWlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKaUlqb2dWVWx1ZERZMEtESXpOQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0prSWpvZ1JYWmxiblJQYm14NUtIZzlZWEpqTkM1VlNXNTBOalFvTVNrc0lIazlZWEpqTkM1VlNXNTBOalFvTWlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVpTSTZJQ2hWU1c1ME5qUW9ORElwTENCVGRISnBibWNvSW05dUlIUm9aU0JsWkdkbElpa3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlaaUk2SUdGeVl6UXVVM1JoZEdsalFYSnlZWGtvWVhKak5DNVRkSEpwYm1jb0ltaHBJaWtzSUdGeVl6UXVVM1J5YVc1bktDSjBhR1Z5WlNFaUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSm5Jam9nWVhKak5DNUVlVzVoYldsalFYSnlZWGtvWVhKak5DNVRkSEpwYm1jb0ltOXVaU0lwTENCaGNtTTBMbE4wY21sdVp5Z2lkSGR2SWlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaWFDSTZJR052Ym5OMFlXNTBYMjFsZEdodlpDZ3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlhU0k2SUdWamFHOWZiblZ0WW1WeUtGVkpiblEyTkNneE1qTTBLU2tzQ2lBZ0lDQXZMeUFnSUNBZ2ZRb2dJQ0FnTHk4Z0tRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQQW9nSUNBZ1lub2dkMmwwYUY5amIyNXpkR0Z1ZEY5a1pXWmhkV3gwYzE5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJtYjNJZ0tHeGxiaXQxZEdZNFcxMHBXekpkQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJSGRwZEdoZlkyOXVjM1JoYm5SZlpHVm1ZWFZzZEhOZlptOXlYMmhsWVdSbGNrQXhDZ3AzYVhSb1gyTnZibk4wWVc1MFgyUmxabUYxYkhSelgyRm1kR1Z5WDJadmNrQTBPZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVE14TFRFME13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0FvZ0lDQWdMeThnSUNBZ0lHUmxabUYxYkhSZllYSm5jejE3Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0poSWpvZ1lYSmpOQzVWU1c1ME5qUW9NVEl6S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1NaU9pQkNlWFJsY3loaUlqRXlNeUlwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FpWWlJNklGVkpiblEyTkNneU16UXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlaQ0k2SUVWMlpXNTBUMjVzZVNoNFBXRnlZelF1VlVsdWREWTBLREVwTENCNVBXRnlZelF1VlVsdWREWTBLRElwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1VaU9pQW9WVWx1ZERZMEtEUXlLU3dnVTNSeWFXNW5LQ0p2YmlCMGFHVWdaV1JuWlNJcEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0ltWWlPaUJoY21NMExsTjBZWFJwWTBGeWNtRjVLR0Z5WXpRdVUzUnlhVzVuS0NKb2FTSXBMQ0JoY21NMExsTjBjbWx1WnlnaWRHaGxjbVVoSWlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVp5STZJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVLR0Z5WXpRdVUzUnlhVzVuS0NKdmJtVWlLU3dnWVhKak5DNVRkSEpwYm1jb0luUjNieUlwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1naU9pQmpiMjV6ZEdGdWRGOXRaWFJvYjJRb0tTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0lta2lPaUJsWTJodlgyNTFiV0psY2loVlNXNTBOalFvTVRJek5Da3BMQW9nSUNBZ0x5OGdJQ0FnSUgwS0lDQWdJQzh2SUNrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBpd2dNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ25kcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZabTl5WDJobFlXUmxja0ExT2dvZ0lDQWdMeThnWVhKalh6VTJMMk52Ym5SeVlXTjBMbkI1T2pFek1TMHhORE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMkZ5WjNNOWV3b2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVlTSTZJR0Z5WXpRdVZVbHVkRFkwS0RFeU15a3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSmpJam9nUW5sMFpYTW9ZaUl4TWpNaUtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0ltSWlPaUJWU1c1ME5qUW9Nak0wS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1RaU9pQkZkbVZ1ZEU5dWJIa29lRDFoY21NMExsVkpiblEyTkNneEtTd2dlVDFoY21NMExsVkpiblEyTkNneUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSmxJam9nS0ZWSmJuUTJOQ2cwTWlrc0lGTjBjbWx1WnlnaWIyNGdkR2hsSUdWa1oyVWlLU2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0ptSWpvZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVNoaGNtTTBMbE4wY21sdVp5Z2lhR2tpS1N3Z1lYSmpOQzVUZEhKcGJtY29JblJvWlhKbElTSXBLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJbWNpT2lCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVNoaGNtTTBMbE4wY21sdVp5Z2liMjVsSWlrc0lHRnlZelF1VTNSeWFXNW5LQ0owZDI4aUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSm9Jam9nWTI5dWMzUmhiblJmYldWMGFHOWtLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0pwSWpvZ1pXTm9iMTl1ZFcxaVpYSW9WVWx1ZERZMEtERXlNelFwS1N3S0lDQWdJQzh2SUNBZ0lDQjlDaUFnSUNBdkx5QXBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTJDaUFnSUNBOENpQWdJQ0JpZWlCM2FYUm9YMk52Ym5OMFlXNTBYMlJsWm1GMWJIUnpYMkZtZEdWeVgyWnZja0E0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5aHNaVzRyZFhSbU9GdGRLVnRkS1FvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUIzYVhSb1gyTnZibk4wWVc1MFgyUmxabUYxYkhSelgyWnZjbDlvWldGa1pYSkFOUW9LZDJsMGFGOWpiMjV6ZEdGdWRGOWtaV1poZFd4MGMxOWhablJsY2w5bWIzSkFPRG9LSUNBZ0lIQnZjRzRnTWdvZ0lDQWdMeThnWVhKalh6VTJMMk52Ym5SeVlXTjBMbkI1T2pFek1TMHhORE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMkZ5WjNNOWV3b2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVlTSTZJR0Z5WXpRdVZVbHVkRFkwS0RFeU15a3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSmpJam9nUW5sMFpYTW9ZaUl4TWpNaUtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0ltSWlPaUJWU1c1ME5qUW9Nak0wS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1RaU9pQkZkbVZ1ZEU5dWJIa29lRDFoY21NMExsVkpiblEyTkNneEtTd2dlVDFoY21NMExsVkpiblEyTkNneUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSmxJam9nS0ZWSmJuUTJOQ2cwTWlrc0lGTjBjbWx1WnlnaWIyNGdkR2hsSUdWa1oyVWlLU2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0ptSWpvZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVNoaGNtTTBMbE4wY21sdVp5Z2lhR2tpS1N3Z1lYSmpOQzVUZEhKcGJtY29JblJvWlhKbElTSXBLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJbWNpT2lCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVNoaGNtTTBMbE4wY21sdVp5Z2liMjVsSWlrc0lHRnlZelF1VTNSeWFXNW5LQ0owZDI4aUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSm9Jam9nWTI5dWMzUmhiblJmYldWMGFHOWtLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0pwSWpvZ1pXTm9iMTl1ZFcxaVpYSW9WVWx1ZERZMEtERXlNelFwS1N3S0lDQWdJQzh2SUNBZ0lDQjlDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qRTFOZ29nSUNBZ0x5OGdZWE56WlhKMElHRUtJQ0FnSUdScFp5QTVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakUxTndvZ0lDQWdMeThnWVhOelpYSjBJR0lLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRveE5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCakNpQWdJQ0JrYVdjZ053b2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtMbmdnYjNJZ1pDNTVDaUFnSUNCa2FXY2dOZ29nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW01NklIZHBkR2hmWTI5dWMzUmhiblJmWkdWbVlYVnNkSE5mWW05dmJGOTBjblZsUURFeENpQWdJQ0JrYVdjZ05nb2dJQ0FnWlhoMGNtRmpkQ0E0SURnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nZDJsMGFGOWpiMjV6ZEdGdWRGOWtaV1poZFd4MGMxOWliMjlzWDJaaGJITmxRREV5Q2dwM2FYUm9YMk52Ym5OMFlXNTBYMlJsWm1GMWJIUnpYMkp2YjJ4ZmRISjFaVUF4TVRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwM2FYUm9YMk52Ym5OMFlXNTBYMlJsWm1GMWJIUnpYMkp2YjJ4ZmJXVnlaMlZBTVRNNkNpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk1UVTVDaUFnSUNBdkx5QmhjM05sY25RZ1pDNTRJRzl5SUdRdWVRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdaVnN3WFNCdmNpQmxXekZkQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZbTU2SUhkcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZZbTl2YkY5MGNuVmxRREUxQ2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQmllaUIzYVhSb1gyTnZibk4wWVc1MFgyUmxabUYxYkhSelgySnZiMnhmWm1Gc2MyVkFNVFlLQ25kcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZZbTl2YkY5MGNuVmxRREUxT2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ25kcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZZbTl2YkY5dFpYSm5aVUF4TnpvS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRveE5qQUtJQ0FnSUM4dklHRnpjMlZ5ZENCbFd6QmRJRzl5SUdWYk1WMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdSMWNESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQm1XekJkSUQwOUlDSm9hU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURJMk9EWTVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVFl5Q2lBZ0lDQXZMeUJoYzNObGNuUWdaeTVzWlc1bmRHZ2dQVDBnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qRTJNd29nSUNBZ0x5OGdZWE56WlhKMElHZ2dQVDBnTkRJS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdORElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TmpRS0lDQWdJQzh2SUdGemMyVnlkQ0JwSUQwOUlERXlNelFLSUNBZ0lIQjFjMmhwYm5RZ01USXpOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakV6TVMweE5ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNnS0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFgyRnlaM005ZXdvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FpWVNJNklHRnlZelF1VlVsdWREWTBLREV5TXlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKaklqb2dRbmwwWlhNb1lpSXhNak1pS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1JaU9pQlZTVzUwTmpRb01qTTBLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJbVFpT2lCRmRtVnVkRTl1Ykhrb2VEMWhjbU0wTGxWSmJuUTJOQ2d4S1N3Z2VUMWhjbU0wTGxWSmJuUTJOQ2d5S1Nrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKbElqb2dLRlZKYm5RMk5DZzBNaWtzSUZOMGNtbHVaeWdpYjI0Z2RHaGxJR1ZrWjJVaUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSm1Jam9nWVhKak5DNVRkR0YwYVdOQmNuSmhlU2hoY21NMExsTjBjbWx1WnlnaWFHa2lLU3dnWVhKak5DNVRkSEpwYm1jb0luUm9aWEpsSVNJcEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0ltY2lPaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlU2hoY21NMExsTjBjbWx1WnlnaWIyNWxJaWtzSUdGeVl6UXVVM1J5YVc1bktDSjBkMjhpS1Nrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKb0lqb2dZMjl1YzNSaGJuUmZiV1YwYUc5a0tDa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSnBJam9nWldOb2IxOXVkVzFpWlhJb1ZVbHVkRFkwS0RFeU16UXBLU3dLSUNBZ0lDOHZJQ0FnSUNCOUNpQWdJQ0F2THlBcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncDNhWFJvWDJOdmJuTjBZVzUwWDJSbFptRjFiSFJ6WDJKdmIyeGZabUZzYzJWQU1UWTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCM2FYUm9YMk52Ym5OMFlXNTBYMlJsWm1GMWJIUnpYMkp2YjJ4ZmJXVnlaMlZBTVRjS0NuZHBkR2hmWTI5dWMzUmhiblJmWkdWbVlYVnNkSE5mWW05dmJGOW1ZV3h6WlVBeE1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhkcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZZbTl2YkY5dFpYSm5aVUF4TXdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBQUVDQ0hzbUJRQUVGUjk4ZFFIL0JVaGxiR3h2QndBRC93QUNTR2t4RzBFQVZZQUVURnhodWpZYUFJNEJBRUF4R1JSRU1SaEVnZ2NFbCtqa3B3UjJ4TjRSQk1IS2R3a0ViZWRpd2dSWi9GS0NCSjJlN0xBRVhvN3ZtallhQUk0SEFDQUFsQURnQVNnQldRR01BY0lBSXpFWmtJRURHa014R1kwR0FBVUFCZi9uLytmLzV3QUJBREVZRkVNalF6WWFBVWtWU3dFbFdVbUJEQkpFU3dKTVN3SlNJbG1CRGdoTEFvRUtXVWxMQWhKRVR3Tk1Td05TU1JWTEFTSlpTWUVERWtSTEFreFBBbElpV1lFRkNFOENDRThDRWtRMkdnSkpGVXNCSWxsSmdRTVNSRXNDVEVzQ1VpSlpnUVVJRWtRU1JJQU1GUjk4ZFFBQUFBQUFBQUFxc0NORE5ob0JTUlZMQVNWWlNZRU1Fa1JMQWt4TEFsSWlXWUVPQ0VzQ2dRcFpTVXNDRWtSUEEweExBMUpKRlVzQklsbEpnUU1TUkVzQ1RFOENVaUpaZ1FVSVR3SUlUd0lTUkNsTVVMQWpRellhQVVrVlN3RWxXVW1CREJKRVN3Sk1Td0pTSWxtQkRnaExBb0VLV1VsTEFoSkVTd05NU3dOU1NSVkxBU0paU1lFREVrUk1VaUpaZ1FVSUNCSkVWd0FJZ0FFQUVrUWpRNEFQMlQ4M1RnQURLZ0FHYUdWc2JHOHhzSUFhSG5LdlRnQUVBQXNBQldobGJHeHZBQU1xQUFab1pXeHNiekt3STBNMkdnRkpGU01TUkNKVFFRQWtnQ0VSeFVlNkFBQUFBQUFBQUNvQUFBQUFBQUFBS3dBU0FBTXFBQVpvWld4c2J6T3dJME1xS3lFRUp3UkpGWUVOQ0U4Q0ZvQUNBQTFNVUVzREZSWlhCZ0pQQkZCUEFoWlhCZ0pQQWt4UVR3TlFUd0pRVEZBcFRGQ3dJME0yR2dGSkZTVVNSRFlhQWtrVkpSSkVGellhQTBraVdTUUlTd0VWRWtSWEFnQTJHZ1JKRllFUUVrUTJHZ1ZKRlVzQkpWbEpnUW9TUkVzQ1RFc0NVa2tpV1lFTUNFOENFa1JNSWx0TVZ3SUFnUVEyR2dZaVNTUU1RUUFoU1NRTFN3SkpUd0paU1U4RlNVNEVFa1JMQVJWU0lsa2tDQWhPQWlNSVF2L1pTRWtWVHdJU1JEWWFCMGtpV1VsT0F5UUxUZ0pKRlU0RFZ3SUFJa2xMQmd4QkFDRkpKQXRMQWtsUEFsbEpUd1pKVGdRU1JFc0JGVklpV1NRSUNFNERJd2hDLzloR0Frd2tDRThDRWtRMkdnaEpGU1VTUkJkTU5ob0pTUlVsRWtRWFRFc0pLS2xFU3doRVN3Y1ZSRXNHVndBSUtLbEFBQXBMQmxjSUNDaXBRUUEwSTBSTEJVQUFCa3NFRlVFQUl5TkVTU0paU2xra0NGaUFCQUFDYUdrU1JFOENKQkpFVElFcUVrU0IwZ2tTUkNORElrTC8yaUpDLzhrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlNoYXJlZFN0cnVjdCIsImRlc2MiOiJUaGlzIHN0cnVjdCBpcyBzaGFyZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9vIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFub255bW91cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiIoYnl0ZVtdLHVpbnQ4KSIsInN0cnVjdCI6IlNoYXJlZFN0cnVjdCIsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFub255bW91czIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRXZlbnRPbmx5IiwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJBVk1fVUlOVDY0Ijp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6IkFBQUFBQUFBQUhzPSJ9LCJBUkM0X1VJTlQ4Ijp7InR5cGUiOiJ1aW50OCIsInZhbHVlIjoiL3c9PSJ9LCJBVk1fU1RSSU5HIjp7InR5cGUiOiJBVk1TdHJpbmciLCJ2YWx1ZSI6IlNHVnNiRzg9In0sIlNUUlVDVCI6eyJ0eXBlIjoiU2hhcmVkU3RydWN0IiwidmFsdWUiOiJBQVAvQUFKSWFRPT0ifX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
