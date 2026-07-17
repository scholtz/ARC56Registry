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

namespace Arc56.Generated.aorumbayev.puya.Contract_e17348ae
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjoiQ29udHJhY3QgZG9jc3RyaW5nIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkV2ZW50T25seSI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifV0sIlNoYXJlZFN0cnVjdCI6W3sibmFtZSI6ImZvbyIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJiYXIiLCJ0eXBlIjoidWludDgifV0sIlN0YXRlU3RydWN0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InN0cmluZyJ9XSwiVG9wTGV2ZWxTdHJ1Y3QiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoic2hhcmVkIiwidHlwZSI6IlNoYXJlZFN0cnVjdCJ9XSwiVGVtcGxhdGVWYWx1ZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJTaGFyZWRTdHJ1Y3QifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50OCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiTWV0aG9kIGRvY3N0cmluZyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCIsIk9wdEluIl0sImNhbGwiOlsiTm9PcCIsIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RydWN0X2FyZyIsImRlc2MiOiJNZXRob2QgZG9jc3RyaW5nMiIsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZywoYnl0ZVtdLHVpbnQ4KSkiLCJzdHJ1Y3QiOiJUb3BMZXZlbFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwibmFtZSI6InNoYXJlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0cnVjdF9yZXR1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcsKGJ5dGVbXSx1aW50OCkpIiwic3RydWN0IjoiVG9wTGV2ZWxTdHJ1Y3QiLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWl0c19lcnJvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZywoYnl0ZVtdLHVpbnQ4KSkiLCJzdHJ1Y3QiOiJUb3BMZXZlbFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWl0dGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTaGFyZWRTdHJ1Y3QiLCJkZXNjIjoiVGhpcyBzdHJ1Y3QgaXMgc2hhcmVkIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvbyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBbm9ueW1vdXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiKGJ5dGVbXSx1aW50OCkiLCJzdHJ1Y3QiOiJTaGFyZWRTdHJ1Y3QiLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uZGl0aW9uYWxfZW1pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hvdWxkX2VtaXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFub255bW91czIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRXZlbnRPbmx5IiwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlbXBsYXRlX3ZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IigoYnl0ZVtdLHVpbnQ4KSx1aW50NjQsc3RyaW5nLHVpbnQ4KSIsInN0cnVjdCI6IlRlbXBsYXRlVmFsdWVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoX2NvbnN0YW50X2RlZmF1bHRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFIcz0iLCJ0eXBlIjoidWludDY0In19LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFPbz0iLCJ0eXBlIjoidWludDY0In19LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQU14TWpNPSIsInR5cGUiOiJieXRlW10ifX0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRXZlbnRPbmx5IiwibmFtZSI6ImQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFBRUFBQUFBQUFBQUFnPT0iLCJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIn19LHsidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IlN0YXRlU3RydWN0IiwibmFtZSI6ImUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFDb0FDZ0FMYjI0Z2RHaGxJR1ZrWjJVPSIsInR5cGUiOiIodWludDY0LHN0cmluZykifX0seyJ0eXBlIjoic3RyaW5nWzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsaXRlcmFsIiwiZGF0YSI6IkFBUUFDQUFDYUdrQUJuUm9aWEpsSVE9PSIsInR5cGUiOiJzdHJpbmdbMl0ifX0seyJ0eXBlIjoic3RyaW5nW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxpdGVyYWwiLCJkYXRhIjoiQUFJQUJBQUpBQU52Ym1VQUEzUjNidz09IiwidHlwZSI6InN0cmluZ1tdIn19LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFDbz0iLCJ0eXBlIjoidWludDY0In19LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUJOST0iLCJ0eXBlIjoidWludDY0In19XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiRGVsZXRlQXBwbGljYXRpb24iLCJOb09wIiwiT3B0SW4iXSwiY2FsbCI6WyJOb09wIiwiT3B0SW4iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszOTYsNTE1LDUyNV0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzLDE3NywyMzQsMjUxLDI2MywyNzgsMjk3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBvbmUgb2YgTm9PcCwgT3B0SW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTYsMTgwLDIzNywyNTQsMjY2LDI4MSwzMDBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBtaWdodCBlcnJvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwM10sImVycm9yTWVzc2FnZSI6InRoaXMgd2lsbCBlcnJvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZMTgxTmk1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1ZlgyRnNaMjl3ZVY5bGJuUnllWEJ2YVc1MFgzZHBkR2hmYVc1cGRDZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNVEFnTkRJZ1ZFMVFURjlCVmsxZlZVbE9WRFkwQ2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnTUhnd01EQXdNREF3TURBd01EQXdNREF3SUZSTlVFeGZRVkpETkY5VlNVNVVPQ0JVVFZCTVgxTlVVbFZEVkNCVVRWQk1YMEZXVFY5VFZGSkpUa2NLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE13b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEUmpOV00yTVdKaElEQjRPVGRsT0dVMFlUY2dNSGczTm1NMFpHVXhNU0F3ZUdNeFkyRTNOekE1SURCNE5tUmxOell5WXpJZ01IZzFPV1pqTlRJNE1pQXdlRGxrT1dWbFkySXdJREI0TldVNFpXVm1PV0VnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4wY25WamRGOWhjbWNvS0hWcGJuUTJOQ3h6ZEhKcGJtY3NLR0o1ZEdWYlhTeDFhVzUwT0NrcExDaGllWFJsVzEwc2RXbHVkRGdwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYzNSeWRXTjBYM0psZEhWeWJpZ29kV2x1ZERZMExITjBjbWx1Wnl3b1lubDBaVnRkTEhWcGJuUTRLU2twS0dKNWRHVmJYU3gxYVc1ME9Da2lMQ0J0WlhSb2IyUWdJbVZ0YVhSelgyVnljbTl5S0NoMWFXNTBOalFzYzNSeWFXNW5MQ2hpZVhSbFcxMHNkV2x1ZERncEtTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbGJXbDBkR1Z5S0NsMmIybGtJaXdnYldWMGFHOWtJQ0pqYjI1a2FYUnBiMjVoYkY5bGJXbDBLR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWdGNHeGhkR1ZmZG1Gc2RXVW9LU2dvWW5sMFpWdGRMSFZwYm5RNEtTeDFhVzUwTmpRc2MzUnlhVzVuTEhWcGJuUTRLU0lzSUcxbGRHaHZaQ0FpZDJsMGFGOWpiMjV6ZEdGdWRGOWtaV1poZFd4MGN5aDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU3dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeHpkSEpwYm1jcExITjBjbWx1WjFzeVhTeHpkSEpwYm1kYlhTeDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlY5eWIzVjBaVUExSUcxaGFXNWZjM1J5ZFdOMFgyRnlaMTl5YjNWMFpVQTJJRzFoYVc1ZmMzUnlkV04wWDNKbGRIVnlibDl5YjNWMFpVQTNJRzFoYVc1ZlpXMXBkSE5mWlhKeWIzSmZjbTkxZEdWQU9DQnRZV2x1WDJWdGFYUjBaWEpmY205MWRHVkFPU0J0WVdsdVgyTnZibVJwZEdsdmJtRnNYMlZ0YVhSZmNtOTFkR1ZBTVRBZ2JXRnBibDkwWlcxd2JHRjBaVjkyWVd4MVpWOXliM1YwWlVBeE1TQnRZV2x1WDNkcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZjbTkxZEdWQU1USUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TmpvS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmQybDBhRjlqYjI1emRHRnVkRjlrWldaaGRXeDBjMTl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TXpJdE1UUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOWhjbWR6UFhzS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1FaU9pQmhjbU0wTGxWSmJuUTJOQ2d4TWpNcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVl5STZJRUo1ZEdWektHSWlNVEl6SWlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKaUlqb2dWVWx1ZERZMEtESXpOQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0prSWpvZ1JYWmxiblJQYm14NUtIZzlZWEpqTkM1VlNXNTBOalFvTVNrc0lIazlZWEpqTkM1VlNXNTBOalFvTWlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVpTSTZJQ2hWU1c1ME5qUW9ORElwTENCVGRISnBibWNvSW05dUlIUm9aU0JsWkdkbElpa3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlaaUk2SUdGeVl6UXVVM1JoZEdsalFYSnlZWGtvWVhKak5DNVRkSEpwYm1jb0ltaHBJaWtzSUdGeVl6UXVVM1J5YVc1bktDSjBhR1Z5WlNFaUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSm5Jam9nWVhKak5DNUVlVzVoYldsalFYSnlZWGtvWVhKak5DNVRkSEpwYm1jb0ltOXVaU0lwTENCaGNtTTBMbE4wY21sdVp5Z2lkSGR2SWlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaWFDSTZJR052Ym5OMFlXNTBYMjFsZEdodlpDZ3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlhU0k2SUdWamFHOWZiblZ0WW1WeUtGVkpiblEyTkNneE1qTTBLU2tzQ2lBZ0lDQXZMeUFnSUNBZ2ZRb2dJQ0FnTHk4Z0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklHTnNZWE56SUVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGtLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TXpJdE1UUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOWhjbWR6UFhzS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1FaU9pQmhjbU0wTGxWSmJuUTJOQ2d4TWpNcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVl5STZJRUo1ZEdWektHSWlNVEl6SWlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKaUlqb2dWVWx1ZERZMEtESXpOQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0prSWpvZ1JYWmxiblJQYm14NUtIZzlZWEpqTkM1VlNXNTBOalFvTVNrc0lIazlZWEpqTkM1VlNXNTBOalFvTWlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaVpTSTZJQ2hWU1c1ME5qUW9ORElwTENCVGRISnBibWNvSW05dUlIUm9aU0JsWkdkbElpa3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlaaUk2SUdGeVl6UXVVM1JoZEdsalFYSnlZWGtvWVhKak5DNVRkSEpwYm1jb0ltaHBJaWtzSUdGeVl6UXVVM1J5YVc1bktDSjBhR1Z5WlNFaUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSm5Jam9nWVhKak5DNUVlVzVoYldsalFYSnlZWGtvWVhKak5DNVRkSEpwYm1jb0ltOXVaU0lwTENCaGNtTTBMbE4wY21sdVp5Z2lkSGR2SWlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBaWFDSTZJR052Ym5OMFlXNTBYMjFsZEdodlpDZ3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWlhU0k2SUdWamFHOWZiblZ0WW1WeUtGVkpiblEyTkNneE1qTTBLU2tzQ2lBZ0lDQXZMeUFnSUNBZ2ZRb2dJQ0FnTHk4Z0tRb2dJQ0FnWTJGc2JITjFZaUIzYVhSb1gyTnZibk4wWVc1MFgyUmxabUYxYkhSekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGJYQnNZWFJsWDNaaGJIVmxYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakV5TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakV5T1FvZ0lDQWdMeThnVkdWdGNHeGhkR1ZXWVhKYllYSmpOQzVWU1c1ME9GMG9Ja0ZTUXpSZlZVbE9WRGdpS1N3S0lDQWdJR0o1ZEdWalh6SWdMeThnVkUxUVRGOUJVa00wWDFWSlRsUTRDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVEkyQ2lBZ0lDQXZMeUJVWlcxd2JHRjBaVlpoY2x0VGFHRnlaV1JUZEhKMVkzUmRLQ0pUVkZKVlExUWlLU3dLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdWRTFRVEY5VFZGSlZRMVFLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TWpnS0lDQWdJQzh2SUZSbGJYQnNZWFJsVm1GeVcxTjBjbWx1WjEwb0lrRldUVjlUVkZKSlRrY2lLU3dLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdWRTFRVEY5QlZrMWZVMVJTU1U1SENpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk1USTNDaUFnSUNBdkx5QlVaVzF3YkdGMFpWWmhjbHRWU1c1ME5qUmRLQ0pCVmsxZlZVbE9WRFkwSWlrc0NpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOUJWazFmVlVsT1ZEWTBDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVEl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREV6SUM4dklERXpDaUFnSUNBckNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQmtDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTI5dVpHbDBhVzl1WVd4ZlpXMXBkRjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnWTJ4aGMzTWdRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRveE1UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR052Ym1ScGRHbHZibUZzWDJWdGFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXMXBkSFJsY2w5eWIzVjBaVUE1T2dvZ0lDQWdMeThnWVhKalh6VTJMMk52Ym5SeVlXTjBMbkI1T2pFd05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmxiV2wwZEdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWdGFYUnpYMlZ5Y205eVgzSnZkWFJsUURnNkNpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk1UQXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpWlcxcGRITmZaWEp5YjNJaUxDQnlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUdOc1lYTnpJRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk1UQXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2JtRnRaVDBpWlcxcGRITmZaWEp5YjNJaUxDQnlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQmxjbkp2Y25NS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzNSeWRXTjBYM0psZEhWeWJsOXliM1YwWlVBM09nb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qazFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJqYkdGemN5QkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnWVhKalh6VTJMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnYzNSeWRXTjBYM0psZEhWeWJnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5emRISjFZM1JmWVhKblgzSnZkWFJsUURZNkNpQWdJQ0F2THlCaGNtTmZOVFl2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYzNSeWRXTjBYMkZ5WndvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaVlXeHNiM2NpTENCaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSXNJQ0pQY0hSSmJpSmRLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lITm9iQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJRE1LSUNBZ0lDWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElHOXVaU0J2WmlCT2IwOXdMQ0JQY0hSSmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVE02Q2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2TlRRS0lDQWdJQzh2SUdOc1lYTnpJRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCemQybDBZMmdnYldGcGJsOWlZWEpsWDJOeVpXRjBaVUF4TkNCdFlXbHVYMkpoY21WZlkzSmxZWFJsUURFMElHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTJJRzFoYVc1ZmRISmhibk5wWlc1MFFERTFDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOZ29LYldGcGJsOTBjbUZ1YzJsbGJuUkFNVFU2Q2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaXdnWVd4c2IzZGZZV04wYVc5dWN6MWJJa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDJOeVpXRjBaVUF4TkRvS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRvM053b2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoamNtVmhkR1U5SW1Gc2JHOTNJaXdnWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaUxDQWlUM0IwU1c0aVhTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZMTgxTmk1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1emRISjFZM1JmWVhKbktHRnlaem9nWW5sMFpYTXNJSE5vWVhKbFpEb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tjM1J5ZFdOMFgyRnlaem9LSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG80T1MwNU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQnpkSEoxWTNSZllYSm5LSE5sYkdZc0lHRnlaem9nVkc5d1RHVjJaV3hUZEhKMVkzUXNJSE5vWVhKbFpEb2dVMmhoY21Wa1UzUnlkV04wS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG81TWdvZ0lDQWdMeThnWVhOelpYSjBJR0Z5Wnk1emFHRnlaV1FnUFQwZ2MyaGhjbVZrTENBaWRHaHBjeUJ0YVdkb2RDQmxjbkp2Y2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSb2FYTWdiV2xuYUhRZ1pYSnliM0lLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG81TXdvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZzBNaWtLSUNBZ0lHbHVkR05mTXlBdkx5QTBNZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21OZk5UWXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXVjM1J5ZFdOMFgzSmxkSFZ5YmloaGNtYzZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjM1J5ZFdOMFgzSmxkSFZ5YmpvS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRvNU5TMDVOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ2MzUnlkV04wWDNKbGRIVnliaWh6Wld4bUxDQmhjbWM2SUZSdmNFeGxkbVZzVTNSeWRXTjBLU0F0UGlCVGFHRnlaV1JUZEhKMVkzUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRvNU53b2dJQ0FnTHk4Z1lYTnpaWEowSUdGeVp5NXphR0Z5WldRZ1BUMGdaV05vYnloaGNtY3VjMmhoY21Wa0tTd2dJblJvYVhNZ2QyOXVKM1FnWlhKeWIzSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVp5NXphR0Z5WldRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYSmpYelUyTG1OdmJuUnlZV04wTGtOdmJuUnlZV04wTG1WeWNtOXljeWhoY21jNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwbGNuSnZjbk02Q2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2TVRBd0xURXdNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5SW1WdGFYUnpYMlZ5Y205eUlpd2djbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQmxjbkp2Y25Nb2MyVnNaaXdnWVhKbk9pQlViM0JNWlhabGJGTjBjblZqZENrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnWVhOelpYSjBJR0Z5Wnk1aExtSjVkR1Z6SUQwOUlHRnlZelF1VlVsdWREZ29NQ2t1WW5sMFpYTXNJQ0owYUdseklIZHBiR3dnWlhKeWIzSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTUNBNElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkR2hwY3lCM2FXeHNJR1Z5Y205eUNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZMTgxTmk1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1bGJXbDBkR1Z5S0NrZ0xUNGdkbTlwWkRvS1pXMXBkSFJsY2pvS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRveE1EWUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDaFRhR0Z5WldSVGRISjFZM1FvWm05dlBXRnlZelF1UkhsdVlXMXBZMEo1ZEdWektHSWlhR1ZzYkc4eElpa3NJR0poY2oxaGNtTTBMbFZKYm5RNEtEUXlLU2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrT1RObU16YzBaVEF3TURNeVlUQXdNRFkyT0RZMU5tTTJZelptTXpFS0lDQWdJR3h2WndvZ0lDQWdMeThnWVhKalh6VTJMMk52Ym5SeVlXTjBMbkI1T2pFd09DMHhNVElLSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dLSUNBZ0lDOHZJQ0FnSUNBaVFXNXZibmx0YjNWeklpd0tJQ0FnSUM4dklDQWdJQ0JUZEhKcGJtY29JbWhsYkd4dklpa3NDaUFnSUNBdkx5QWdJQ0FnVTJoaGNtVmtVM1J5ZFdOMEtHWnZiejFoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWhpSW1obGJHeHZNaUlwTENCaVlYSTlZWEpqTkM1VlNXNTBPQ2cwTWlrcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XVTNNbUZtTkdVd01EQTBNREF3WWpBd01EVTJPRFkxTm1NMll6Wm1NREF3TXpKaE1EQXdOalk0TmpVMll6WmpObVl6TWdvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeVkxODFOaTVqYjI1MGNtRmpkQzVEYjI1MGNtRmpkQzVqYjI1a2FYUnBiMjVoYkY5bGJXbDBLSE5vYjNWc1pGOWxiV2wwT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21OdmJtUnBkR2x2Ym1Gc1gyVnRhWFE2Q2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2TVRFMExURXhOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJqYjI1a2FYUnBiMjVoYkY5bGJXbDBLSE5sYkdZc0lITm9iM1ZzWkY5bGJXbDBPaUJpYjI5c0tTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJoY21OZk5UWXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkNpQWdJQ0F2THlCcFppQnphRzkxYkdSZlpXMXBkRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lub2dZMjl1WkdsMGFXOXVZV3hmWlcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdGeVkxODFOaTlqYjI1MGNtRmpkQzV3ZVRveE1UY3RNVEl4Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ0lrRnViMjU1Ylc5MWN6SWlMQW9nSUNBZ0x5OGdJQ0FnSUVWMlpXNTBUMjVzZVNoaGNtTTBMbFZKYm5RMk5DZzBNaWtzSUdGeVl6UXVWVWx1ZERZMEtEUXpLU2tzQ2lBZ0lDQXZMeUFnSUNBZ1UyaGhjbVZrVTNSeWRXTjBLR1p2YnoxaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3loaUltaGxiR3h2TXlJcExDQmlZWEk5WVhKak5DNVZTVzUwT0NnME1pa3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVEZqTlRRM1ltRXdNREF3TURBd01EQXdNREF3TURKaE1EQXdNREF3TURBd01EQXdNREF5WWpBd01USXdNREF6TW1Fd01EQTJOamcyTlRaak5tTTJaak16Q2lBZ0lDQnNiMmNLQ21OdmJtUnBkR2x2Ym1Gc1gyVnRhWFJmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21OZk5UWXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXVkMmwwYUY5amIyNXpkR0Z1ZEY5a1pXWmhkV3gwY3loaE9pQmllWFJsY3l3Z1lqb2dkV2x1ZERZMExDQmpPaUJpZVhSbGN5d2daRG9nWW5sMFpYTXNJR1V1TURvZ2RXbHVkRFkwTENCbExqRTZJR0o1ZEdWekxDQm1PaUJpZVhSbGN5d2daem9nWW5sMFpYTXNJR2c2SUhWcGJuUTJOQ3dnYVRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwM2FYUm9YMk52Ym5OMFlXNTBYMlJsWm1GMWJIUnpPZ29nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakV6TWkweE5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNnS0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFgyRnlaM005ZXdvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FpWVNJNklHRnlZelF1VlVsdWREWTBLREV5TXlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKaklqb2dRbmwwWlhNb1lpSXhNak1pS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSW1JaU9pQlZTVzUwTmpRb01qTTBLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJbVFpT2lCRmRtVnVkRTl1Ykhrb2VEMWhjbU0wTGxWSmJuUTJOQ2d4S1N3Z2VUMWhjbU0wTGxWSmJuUTJOQ2d5S1Nrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKbElqb2dLRlZKYm5RMk5DZzBNaWtzSUZOMGNtbHVaeWdpYjI0Z2RHaGxJR1ZrWjJVaUtTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSm1Jam9nWVhKak5DNVRkR0YwYVdOQmNuSmhlU2hoY21NMExsTjBjbWx1WnlnaWFHa2lLU3dnWVhKak5DNVRkSEpwYm1jb0luUm9aWEpsSVNJcEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0ltY2lPaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlU2hoY21NMExsTjBjbWx1WnlnaWIyNWxJaWtzSUdGeVl6UXVVM1J5YVc1bktDSjBkMjhpS1Nrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNKb0lqb2dZMjl1YzNSaGJuUmZiV1YwYUc5a0tDa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDSnBJam9nWldOb2IxOXVkVzFpWlhJb1ZVbHVkRFkwS0RFeU16UXBLU3dLSUNBZ0lDOHZJQ0FnSUNCOUNpQWdJQ0F2THlBcENpQWdJQ0F2THlCa1pXWWdkMmwwYUY5amIyNXpkR0Z1ZEY5a1pXWmhkV3gwY3lnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lHRTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHSTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JqT2lCQ2VYUmxjeXdLSUNBZ0lDOHZJQ0FnSUNCa09pQkZkbVZ1ZEU5dWJIa3NDaUFnSUNBdkx5QWdJQ0FnWlRvZ2RIVndiR1ZiVlVsdWREWTBMQ0JUZEhKcGJtZGRMQW9nSUNBZ0x5OGdJQ0FnSUdZNklHRnlZelF1VTNSaGRHbGpRWEp5WVhsYllYSmpOQzVUZEhKcGJtY3NJSFI1Y0dsdVp5NU1hWFJsY21Gc1d6SmRYU3dLSUNBZ0lDOHZJQ0FnSUNCbk9pQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGxOMGNtbHVaMTBzQ2lBZ0lDQXZMeUFnSUNBZ2FEb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR2s2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFd0lEQUtJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qRTFPQW9nSUNBZ0x5OGdZWE56WlhKMElHSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE9Rb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhjbU5mTlRZdlkyOXVkSEpoWTNRdWNIazZNVFU1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZd29nSUNBZ1puSmhiV1ZmWkdsbklDMDRDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEpqWHpVMkwyTnZiblJ5WVdOMExuQjVPakUyTUFvZ0lDQWdMeThnWVhOelpYSjBJR1F1ZUNCdmNpQmtMbmtLSUNBZ0lHWnlZVzFsWDJScFp5QXROd29nSUNBZ1pYaDBjbUZqZENBd0lEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHSnVlaUIzYVhSb1gyTnZibk4wWVc1MFgyUmxabUYxYkhSelgySnZiMnhmZEhKMVpVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUY0tJQ0FnSUdWNGRISmhZM1FnT0NBNElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDRTlDaUFnSUNCaWVpQjNhWFJvWDJOdmJuTjBZVzUwWDJSbFptRjFiSFJ6WDJKdmIyeGZabUZzYzJWQU13b0tkMmwwYUY5amIyNXpkR0Z1ZEY5a1pXWmhkV3gwYzE5aWIyOXNYM1J5ZFdWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENncDNhWFJvWDJOdmJuTjBZVzUwWDJSbFptRjFiSFJ6WDJKdmIyeGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtMbmdnYjNJZ1pDNTVDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TmpFS0lDQWdJQzh2SUdGemMyVnlkQ0JsV3pCZElHOXlJR1ZiTVYwS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdZbTU2SUhkcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZZbTl2YkY5MGNuVmxRRFlLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2JHVnVDaUFnSUNCaWVpQjNhWFJvWDJOdmJuTjBZVzUwWDJSbFptRjFiSFJ6WDJKdmIyeGZabUZzYzJWQU53b0tkMmwwYUY5amIyNXpkR0Z1ZEY5a1pXWmhkV3gwYzE5aWIyOXNYM1J5ZFdWQU5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENncDNhWFJvWDJOdmJuTjBZVzUwWDJSbFptRjFiSFJ6WDJKdmIyeGZiV1Z5WjJWQU9Eb0tJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxXekJkSUc5eUlHVmJNVjBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhKalh6VTJMMk52Ym5SeVlXTjBMbkI1T2pFMk1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdaYk1GMGdQVDBnSW1ocElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TWpZNE5qa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHRnlZMTgxTmk5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDQm5MbXhsYm1kMGFDQTlQU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0Z5WTE4MU5pOWpiMjUwY21GamRDNXdlVG94TmpRS0lDQWdJQzh2SUdGemMyVnlkQ0JvSUQwOUlEUXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNeUF2THlBME1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYSmpYelUyTDJOdmJuUnlZV04wTG5CNU9qRTJOUW9nSUNBZ0x5OGdZWE56WlhKMElHa2dQVDBnTVRJek5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJREV5TXpRZ0x5OGdNVEl6TkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjbVYwYzNWaUNncDNhWFJvWDJOdmJuTjBZVzUwWDJSbFptRjFiSFJ6WDJKdmIyeGZabUZzYzJWQU56b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUhkcGRHaGZZMjl1YzNSaGJuUmZaR1ZtWVhWc2RITmZZbTl2YkY5dFpYSm5aVUE0Q2dwM2FYUm9YMk52Ym5OMFlXNTBYMlJsWm1GMWJIUnpYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJSGRwZEdoZlkyOXVjM1JoYm5SZlpHVm1ZWFZzZEhOZlltOXZiRjl0WlhKblpVQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZBUUFLS25zbUJRUVZIM3gxQ0FBQUFBQUFBQUFBQWY4SEFBUC9BQUpJYVFWSVpXeHNiekViUVFFYWdnZ0VURnhodWdTWDZPU25CSGJFM2hFRXdjcDNDUVJ0NTJMQ0JGbjhVb0lFblo3c3NBUmVqdSthTmhvQWpnZ0EwUUM2QUtjQW1BQ01BSHNBUWdBQ0kwTXhHUlJFTVJoRU5ob0JOaG9DRnpZYUExY0NBRFlhQkRZYUJVa2pXMHNCZ1FoWlN3SVZUd05PQWxKWEFnQTJHZ1kyR2djMkdnZ1hOaG9KRjRnQlJpSkRNUmtVUkRFWVJDb3JKd1FoQkJaTEFSVVdWd1lDVHdKUVN3SVZnUTBJZ0FJQURVOERVRXdXVndZQ1VFOERVRThDVUV4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVNOVGlBRFBJa014R1JSRU1SaEVpQUNUSWtNeEdSUkVNUmhFTmhvQmlBQjJJa014R1JSRU1SaEVOaG9CaUFCWEtFeFFzQ0pETVJrVVJERVlSRFlhQVRZYUFvZ0FMQllvVEZDd0lrTWlNUm1RZ1FNYVJDSkRNUm1OQmdBSkFBbi9GZjhWL3hVQUEwTC9FakVZRkVRaVF5SkRpZ0lCaS80a1dZditGWXYrVGdKU2kvOFNSQ1dKaWdFQmkvOGtXWXYvRll2L1RnSlNpWW9CQUl2L1Z3QUlnQUVBRWtTSmdBL1pQemRPQUFNcUFBWm9aV3hzYnpHd2dCb2VjcTlPQUFRQUN3QUZhR1ZzYkc4QUF5b0FCbWhsYkd4dk1yQ0ppZ0VBaS85QkFDU0FJUkhGUjdvQUFBQUFBQUFBS2dBQUFBQUFBQUFyQUJJQUF5b0FCbWhsYkd4dk03Q0ppZ29BaS9ZcEUwU0w5MFNMK0JWRWkvbFhBQWdwRTBBQUNvdjVWd2dJS1JOQkFFRWlSSXY2UUFBR2kvc1ZRUUF3SWtTTC9DTlppL3hMQVZtQkFnaUwvRTRDV0lBRUFBSm9hUkpFaS8waldZRUNFa1NML2lVU1JJdi9nZElKRWtTSkkwTC96U05DLzd3PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlNoYXJlZFN0cnVjdCIsImRlc2MiOiJUaGlzIHN0cnVjdCBpcyBzaGFyZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9vIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFub255bW91cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiIoYnl0ZVtdLHVpbnQ4KSIsInN0cnVjdCI6IlNoYXJlZFN0cnVjdCIsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFub255bW91czIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRXZlbnRPbmx5IiwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6IihieXRlW10sdWludDgpIiwic3RydWN0IjoiU2hhcmVkU3RydWN0IiwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJBVk1fVUlOVDY0Ijp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6IkFBQUFBQUFBQUhzPSJ9LCJBUkM0X1VJTlQ4Ijp7InR5cGUiOiJ1aW50OCIsInZhbHVlIjoiL3c9PSJ9LCJTVFJVQ1QiOnsidHlwZSI6IlNoYXJlZFN0cnVjdCIsInZhbHVlIjoiQUFQL0FBSklhUT09In0sIkFWTV9TVFJJTkciOnsidHlwZSI6IkFWTVN0cmluZyIsInZhbHVlIjoiU0dWc2JHOD0ifX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
