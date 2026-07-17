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

namespace Arc56.Generated.aorumbayev.puya.NestedTuples_40b9ad68
{


    public class NestedTuplesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NestedTuplesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Child : AVMObjectType
            {
                public ulong A { get; set; }

                public byte[] B { get; set; }

                public string C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vC.From(C);
                    stringRef[ret.Count] = vC.Encode();
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

                public static Child Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Child();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    var indexC = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vC.Decode(bytes.Skip(indexC + prefixOffset).ToArray());
                    var valueC = vC.ToValue();
                    if (valueC is string vCValue) { ret.C = vCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Child);
                }
                public bool Equals(Child? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Child left, Child right)
                {
                    return EqualityComparer<Child>.Default.Equals(left, right);
                }
                public static bool operator !=(Child left, Child right)
                {
                    return !(left == right);
                }

            }

            public class Parent : AVMObjectType
            {
                public ulong Foo { get; set; }

                public ulong FooArc { get; set; }

                public Structs.Child Child { get; set; } = new Structs.Child();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFooArc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFooArc.From(FooArc);
                    ret.AddRange(vFooArc.Encode());
                    stringRef[ret.Count] = Child.ToByteArray();
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

                public static Parent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Parent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is ulong vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFooArc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFooArc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFooArc = vFooArc.ToValue();
                    if (valueFooArc is ulong vFooArcValue) { ret.FooArc = vFooArcValue; }
                    var indexChild = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Child = Structs.Child.Parse(bytes.Skip(indexChild + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Parent);
                }
                public bool Equals(Parent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Parent left, Parent right)
                {
                    return EqualityComparer<Parent>.Default.Equals(left, right);
                }
                public static bool operator !=(Parent left, Parent right)
                {
                    return !(left == right);
                }

            }

            public class NestedTupleParamsArgArgs : AVMObjectType
            {
                public string Field0 { get; set; }

                public Structs.NestedTupleParamsArgArgsField1 Field1 { get; set; } = new Structs.NestedTupleParamsArgArgsField1();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
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

                public static NestedTupleParamsArgArgs Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedTupleParamsArgArgs();
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.NestedTupleParamsArgArgsField1.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleParamsArgArgs);
                }
                public bool Equals(NestedTupleParamsArgArgs? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleParamsArgArgs left, NestedTupleParamsArgArgs right)
                {
                    return EqualityComparer<NestedTupleParamsArgArgs>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleParamsArgArgs left, NestedTupleParamsArgArgs right)
                {
                    return !(left == right);
                }

            }

            public class NestedTupleParamsArgArgsField1 : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public Structs.NestedTupleParamsArgArgsField1Field1 Field1 { get; set; } = new Structs.NestedTupleParamsArgArgsField1Field1();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    ret.AddRange(Field1.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedTupleParamsArgArgsField1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NestedTupleParamsArgArgsField1();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    ret.Field1 = Structs.NestedTupleParamsArgArgsField1Field1.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleParamsArgArgsField1);
                }
                public bool Equals(NestedTupleParamsArgArgsField1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleParamsArgArgsField1 left, NestedTupleParamsArgArgsField1 right)
                {
                    return EqualityComparer<NestedTupleParamsArgArgsField1>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleParamsArgArgsField1 left, NestedTupleParamsArgArgsField1 right)
                {
                    return !(left == right);
                }

            }

            public class NestedTupleParamsArgArgsField1Field1 : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedTupleParamsArgArgsField1Field1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NestedTupleParamsArgArgsField1Field1();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleParamsArgArgsField1Field1);
                }
                public bool Equals(NestedTupleParamsArgArgsField1Field1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleParamsArgArgsField1Field1 left, NestedTupleParamsArgArgsField1Field1 right)
                {
                    return EqualityComparer<NestedTupleParamsArgArgsField1Field1>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleParamsArgArgsField1Field1 left, NestedTupleParamsArgArgsField1Field1 right)
                {
                    return !(left == right);
                }

            }

            public class NestedTupleParamsReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public Structs.NestedTupleParamsReturnField1 Field1 { get; set; } = new Structs.NestedTupleParamsReturnField1();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
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

                public static NestedTupleParamsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedTupleParamsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.NestedTupleParamsReturnField1.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleParamsReturn);
                }
                public bool Equals(NestedTupleParamsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleParamsReturn left, NestedTupleParamsReturn right)
                {
                    return EqualityComparer<NestedTupleParamsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleParamsReturn left, NestedTupleParamsReturn right)
                {
                    return !(left == right);
                }

            }

            public class NestedTupleParamsReturnField1 : AVMObjectType
            {
                public string Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedTupleParamsReturnField1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedTupleParamsReturnField1();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedTupleParamsReturnField1);
                }
                public bool Equals(NestedTupleParamsReturnField1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedTupleParamsReturnField1 left, NestedTupleParamsReturnField1 right)
                {
                    return EqualityComparer<NestedTupleParamsReturnField1>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedTupleParamsReturnField1 left, NestedTupleParamsReturnField1 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> RunTests(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 90, 59, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RunTests_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 90, 59, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="args"> NestedTupleParamsArgArgs</param>
        public async Task<Structs.NestedTupleParamsReturn> NestedTupleParams(Structs.NestedTupleParamsArgArgs args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 160, 82, 27 };

            var result = await base.CallApp(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NestedTupleParamsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedTupleParams_Transactions(Structs.NestedTupleParamsArgArgs args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 160, 82, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="args"> Child</param>
        public async Task<Structs.Child> NamedTuple(Structs.Child args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 63, 91, 36 };

            var result = await base.CallApp(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Child.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NamedTuple_Transactions(Structs.Child args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 63, 91, 36 };

            return await base.MakeTransactionList(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="args"> Parent</param>
        public async Task<Structs.Parent> NestedNamedTupleParams(Structs.Parent args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 89, 48, 150 };

            var result = await base.CallApp(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Parent.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedNamedTupleParams_Transactions(Structs.Parent args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 89, 48, 150 };

            return await base.MakeTransactionList(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVzdGVkVHVwbGVzIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNoaWxkIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoic3RyaW5nIn1dLCJQYXJlbnQiOlt7Im5hbWUiOiJmb28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZm9vX2FyYyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjaGlsZCIsInR5cGUiOiJDaGlsZCJ9XSwiTmVzdGVkVHVwbGVQYXJhbXNBcmdBcmdzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJOZXN0ZWRUdXBsZVBhcmFtc0FyZ0FyZ3NGaWVsZDEifV0sIk5lc3RlZFR1cGxlUGFyYW1zQXJnQXJnc0ZpZWxkMSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiTmVzdGVkVHVwbGVQYXJhbXNBcmdBcmdzRmllbGQxRmllbGQxIn1dLCJOZXN0ZWRUdXBsZVBhcmFtc0FyZ0FyZ3NGaWVsZDFGaWVsZDEiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In1dLCJOZXN0ZWRUdXBsZVBhcmFtc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiTmVzdGVkVHVwbGVQYXJhbXNSZXR1cm5GaWVsZDEifV0sIk5lc3RlZFR1cGxlUGFyYW1zUmV0dXJuRmllbGQxIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicnVuX3Rlc3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5lc3RlZF90dXBsZV9wYXJhbXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZywoYnl0ZVtdLCh1aW50NjQpKSkiLCJzdHJ1Y3QiOiJOZXN0ZWRUdXBsZVBhcmFtc0FyZ0FyZ3MiLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVtdLChzdHJpbmcsdWludDY0KSkiLCJzdHJ1Y3QiOiJOZXN0ZWRUdXBsZVBhcmFtc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5hbWVkX3R1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsYnl0ZVtdLHN0cmluZykiLCJzdHJ1Y3QiOiJDaGlsZCIsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYnl0ZVtdLHN0cmluZykiLCJzdHJ1Y3QiOiJDaGlsZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5lc3RlZF9uYW1lZF90dXBsZV9wYXJhbXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsKHVpbnQ2NCxieXRlW10sc3RyaW5nKSkiLCJzdHJ1Y3QiOiJQYXJlbnQiLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCwodWludDY0LGJ5dGVbXSxzdHJpbmcpKSIsInN0cnVjdCI6IlBhcmVudCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTA2LDM2OF0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQsMjI0LDMxOSw0MzRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NywyMjcsMzIyLDQzN10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjEsNjMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5idWlsZF9uZXN0ZWRfY2FsbF9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblIxY0d4bFgzTjFjSEJ2Y25RdWJtVnpkR1ZrWDNSMWNHeGxjeTVPWlhOMFpXUlVkWEJzWlhNdVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRElnTXdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWW5WcGJHUmZibVZ6ZEdWa1gyTmhiR3hmWTI5MWJuUWlJREI0TVRVeFpqZGpOelVnTUhnd01EQmpDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNakFLSUNBZ0lDOHZJSE5sYkdZdVluVnBiR1JmYm1WemRHVmtYMk5oYkd4ZlkyOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KMWFXeGtYMjVsYzNSbFpGOWpZV3hzWDJOdmRXNTBJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hPQW9nSUNBZ0x5OGdZMnhoYzNNZ1RtVnpkR1ZrVkhWd2JHVnpLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU9Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEbGxOV0V6WW1FM0lEQjRZMlZoTURVeU1XSWdNSGd6TnpObU5XSXlOQ0F3ZUdWak5Ua3pNRGsySUM4dklHMWxkR2h2WkNBaWNuVnVYM1JsYzNSektDbGliMjlzSWl3Z2JXVjBhRzlrSUNKdVpYTjBaV1JmZEhWd2JHVmZjR0Z5WVcxektDaHpkSEpwYm1jc0tHSjVkR1ZiWFN3b2RXbHVkRFkwS1NrcEtTaGllWFJsVzEwc0tITjBjbWx1Wnl4MWFXNTBOalFwS1NJc0lHMWxkR2h2WkNBaWJtRnRaV1JmZEhWd2JHVW9LSFZwYm5RMk5DeGllWFJsVzEwc2MzUnlhVzVuS1Nrb2RXbHVkRFkwTEdKNWRHVmJYU3h6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0p1WlhOMFpXUmZibUZ0WldSZmRIVndiR1ZmY0dGeVlXMXpLQ2gxYVc1ME5qUXNkV2x1ZERZMExDaDFhVzUwTmpRc1lubDBaVnRkTEhOMGNtbHVaeWtwS1NoMWFXNTBOalFzZFdsdWREWTBMQ2gxYVc1ME5qUXNZbmwwWlZ0ZExITjBjbWx1WnlrcElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5eWRXNWZkR1Z6ZEhOZmNtOTFkR1ZBTlNCdFlXbHVYMjVsYzNSbFpGOTBkWEJzWlY5d1lYSmhiWE5mY205MWRHVkFOaUJ0WVdsdVgyNWhiV1ZrWDNSMWNHeGxYM0p2ZFhSbFFEY2diV0ZwYmw5dVpYTjBaV1JmYm1GdFpXUmZkSFZ3YkdWZmNHRnlZVzF6WDNKdmRYUmxRRGdLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG94T0FvZ0lDQWdMeThnWTJ4aGMzTWdUbVZ6ZEdWa1ZIVndiR1Z6S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyNWxjM1JsWkY5dVlXMWxaRjkwZFhCc1pWOXdZWEpoYlhOZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzJNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakU0Q2lBZ0lDQXZMeUJqYkdGemN5Qk9aWE4wWldSVWRYQnNaWE1vUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0E0SURnZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhOaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREV3SUM4dklERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qWXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQmpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01USWdMeThnTVRJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREV5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dVlXMWxaRjkwZFhCc1pWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPalU0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRnS0lDQWdJQzh2SUdOc1lYTnpJRTVsYzNSbFpGUjFjR3hsY3loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURnZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElERXdJQzh2SURFd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdZd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERXlJQzh2SURFeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjVsYzNSbFpGOTBkWEJzWlY5d1lYSmhiWE5mY205MWRHVkFOam9LSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRvMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTRDaUFnSUNBdkx5QmpiR0Z6Y3lCT1pYTjBaV1JVZFhCc1pYTW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUE0SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TlRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREJoQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNuVnVYM1JsYzNSelgzSnZkWFJsUURVNkNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnY25WdVgzUmxjM1J6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEE1T2dvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTRDaUFnSUNBdkx5QmpiR0Z6Y3lCT1pYTjBaV1JVZFhCc1pYTW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBkWEJzWlY5emRYQndiM0owTG01bGMzUmxaRjkwZFhCc1pYTXVkR1Z6ZEY5dVpYTjBaV1JmYzJsdVoyeGxjeWh2Ym1VNklIVnBiblEyTkN3Z2NtVmhjM05wWjI0NklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2RHVnpkRjl1WlhOMFpXUmZjMmx1WjJ4bGN6b0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG94TXpFdE1UTXlDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUhSbGMzUmZibVZ6ZEdWa1gzTnBibWRzWlhNb2IyNWxPaUJWU1c1ME5qUXNJQ29zSUhKbFlYTnphV2R1T2lCaWIyOXNLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVE0wQ2lBZ0lDQXZMeUFvVlVsdWREWTBLREFwTENrc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRXpOZ29nSUNBZ0x5OGdLRlZKYm5RMk5DZ3lLU3dwTEFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE5EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCeld6RmRXekJkSUQwOUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTBOUW9nSUNBZ0x5OGdhV1lnY21WaGMzTnBaMjQ2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjZJSFJsYzNSZmJtVnpkR1ZrWDNOcGJtZHNaWE5mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRRM0NpQWdJQ0F2THlBb1ZVbHVkRFkwS0RNcExDa3NDaUFnSUNCcGJuUmpYek1nTHk4Z013b2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakUwTmkweE5UQUtJQ0FnSUM4dklITWdQU0FvQ2lBZ0lDQXZMeUFnSUNBZ0tGVkpiblEyTkNnektTd3BMQW9nSUNBZ0x5OGdJQ0FnSUNoVlNXNTBOalFvTkNrc0tTd0tJQ0FnSUM4dklDQWdJQ0FvVlVsdWREWTBLRFVwTENrc0NpQWdJQ0F2THlBcENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hORGdLSUNBZ0lDOHZJQ2hWU1c1ME5qUW9OQ2tzS1N3S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVFEyTFRFMU1Bb2dJQ0FnTHk4Z2N5QTlJQ2dLSUNBZ0lDOHZJQ0FnSUNBb1ZVbHVkRFkwS0RNcExDa3NDaUFnSUNBdkx5QWdJQ0FnS0ZWSmJuUTJOQ2cwS1N3cExBb2dJQ0FnTHk4Z0lDQWdJQ2hWU1c1ME5qUW9OU2tzS1N3S0lDQWdJQzh2SUNrS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTBPUW9nSUNBZ0x5OGdLRlZKYm5RMk5DZzFLU3dwTEFvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SURVS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hORFl0TVRVd0NpQWdJQ0F2THlCeklEMGdLQW9nSUNBZ0x5OGdJQ0FnSUNoVlNXNTBOalFvTXlrc0tTd0tJQ0FnSUM4dklDQWdJQ0FvVlVsdWREWTBLRFFwTENrc0NpQWdJQ0F2THlBZ0lDQWdLRlZKYm5RMk5DZzFLU3dwTEFvZ0lDQWdMeThnS1FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2dwMFpYTjBYMjVsYzNSbFpGOXphVzVuYkdWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpXekJkV3pCZElEMDlJQ2d6SUdsbUlISmxZWE56YVdkdUlHVnNjMlVnTUNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eklDOHZJRE1LSUNBZ0lDb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVFV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdkRzF3SUQwOUlDZzFJR2xtSUhKbFlYTnphV2R1SUdWc2MyVWdNaWtLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdOUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pFMU53b2dJQ0FnTHk4Z2N6RWdLejBnYjI1bENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCek1TQTlQU0FvTlNCcFppQnlaV0Z6YzJsbmJpQmxiSE5sSURJcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVFU1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMXN4WFZzd1hTQTlQU0FvTkNCcFppQnlaV0Z6YzJsbmJpQmxiSE5sSURFcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMlZzWldOMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuUjFjR3hsWDNOMWNIQnZjblF1Ym1WemRHVmtYM1IxY0d4bGN5NU9aWE4wWldSVWRYQnNaWE11Y25WdVgzUmxjM1J6S0NrZ0xUNGdkV2x1ZERZME9ncHlkVzVmZEdWemRITTZDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TWpJdE1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjblZ1WDNSbGMzUnpLSE5sYkdZcElDMCtJR0p2YjJ3NkNpQWdJQ0J3Y205MGJ5QXdJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pNNENpQWdJQ0F2THlCMFpYTjBYMmx1ZEhKcGJuTnBZM01vVlVsdWREWTBLREVwTENCVlNXNTBOalFvTWlrcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRvNU9Bb2dJQ0FnTHk4Z2JuUWdQU0FvVlVsdWREWTBLREVwTENCdmNDNWhaR1IzS0c1MWJURXNJRzUxYlRJcExDQlZTVzUwTmpRb05ESXBLUW9nSUNBZ1lXUmtkd29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pFd01Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1MFd6RmRJRDA5SUNnd0xDQnVkVzB4SUNzZ2JuVnRNaWtnSUNNZ2RIbHdaVG9nYVdkdWIzSmxXMk52YlhCaGNtbHpiMjR0YjNabGNteGhjRjBLSUNBZ0lITjNZWEFLSUNBZ0lDRUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNeUF2THlBekNpQWdJQ0E5UFFvZ0lDQWdaSFZ3TWdvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRXdNZ29nSUNBZ0x5OGdZWE56WlhKMElHNTBXekZkV3pveFhTQTlQU0FvTUN3cElDQWpJSFI1Y0dVNklHbG5ibTl5WlZ0amIyMXdZWEpwYzI5dUxXOTJaWEpzWVhCZENpQWdJQ0J6ZDJGd0NpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG94TURNS0lDQWdJQzh2SUdGemMyVnlkQ0J1ZEZzeFhWc3hPbDBnUFQwZ0tHNTFiVEVnS3lCdWRXMHlMQ2tLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qUXdDaUFnSUNBdkx5QjBaWE4wWDI1bGMzUmxaRjl6YVc1bmJHVnpLRlZKYm5RMk5DZ3hLU3dnY21WaGMzTnBaMjQ5VkhKMVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEY5dVpYTjBaV1JmYzJsdVoyeGxjd29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pReENpQWdJQ0F2THlCMFpYTjBYMjVsYzNSbFpGOXphVzVuYkdWektGVkpiblEyTkNneEtTd2djbVZoYzNOcFoyNDlSbUZzYzJVcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRjl1WlhOMFpXUmZjMmx1WjJ4bGN3b2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakUzT1FvZ0lDQWdMeThnZEc5MFlXd2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRjM0NpQWdJQ0F2THlCNElEMGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakUzT0FvZ0lDQWdMeThnZVNBOUlGVkpiblEyTkNneUtRb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2dweWRXNWZkR1Z6ZEhOZlptOXlYMkp2WkhsQU1USTZDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRnekNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCaElDc2dZZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTRNUW9nSUNBZ0x5OGdabTl5SUhRZ2FXNGdLQ2g0TENCNUtTd2dLSGtzSUhncExDQW9lQ3dnZUNrc0lDaDVMQ0I1S1NrNkNpQWdJQ0J6ZDJsMFkyZ2djblZ1WDNSbGMzUnpYMlp2Y2w5b1pXRmtaWEpmTVVBeE15QnlkVzVmZEdWemRITmZabTl5WDJobFlXUmxjbDh5UURFMElISjFibDkwWlhOMGMxOW1iM0pmYUdWaFpHVnlYek5BTVRVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk1UYzNDaUFnSUNBdkx5QjRJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pFNE5Rb2dJQ0FnTHk4Z1ptOXlJR0VzSUdJZ2FXNGdLQ2g0TENCNUtTd2dLSGtzSUhncExDQW9lQ3dnZUNrc0lDaDVMQ0I1S1NrNkNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hOemdLSUNBZ0lDOHZJSGtnUFNCVlNXNTBOalFvTWlrS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk1UZzFDaUFnSUNBdkx5Qm1iM0lnWVN3Z1lpQnBiaUFvS0hnc0lIa3BMQ0FvZVN3Z2VDa3NJQ2g0TENCNEtTd2dLSGtzSUhrcEtUb0tJQ0FnSUhOM1lYQUtDbkoxYmw5MFpYTjBjMTltYjNKZlltOWtlVUF4TnpvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hPRFlLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJR0VnS3lCaUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRnMUNpQWdJQ0F2THlCbWIzSWdZU3dnWWlCcGJpQW9LSGdzSUhrcExDQW9lU3dnZUNrc0lDaDRMQ0I0S1N3Z0tIa3NJSGtwS1RvS0lDQWdJSE4zYVhSamFDQnlkVzVmZEdWemRITmZabTl5WDJobFlXUmxjbDh4UURFNElISjFibDkwWlhOMGMxOW1iM0pmYUdWaFpHVnlYekpBTVRrZ2NuVnVYM1JsYzNSelgyWnZjbDlvWldGa1pYSmZNMEF5TUFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTRPQW9nSUNBZ0x5OGdZWE56WlhKMElIUnZkR0ZzSUM4dklEZ2dQVDBnTXdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQXZDaUFnSUNCcGJuUmpYek1nTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPamMxQ2lBZ0lDQXZMeUJ6Wld4bUxtSjFhV3hrWDI1bGMzUmxaRjlqWVd4c1gyTnZkVzUwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWRXbHNaRjl1WlhOMFpXUmZZMkZzYkY5amIzVnVkQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pjd0NpQWdJQ0F2THlCelpXeG1MbUoxYVd4a1gyNWxjM1JsWkY5allXeHNYMk52ZFc1MElDczlJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlkV2xzWkY5dVpYTjBaV1JmWTJGc2JGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlkV2xzWkY5dVpYTjBaV1JmWTJGc2JGOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWRXbHNaRjl1WlhOMFpXUmZZMkZzYkY5amIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk56Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUoxYVd4a1gyNWxjM1JsWkY5allXeHNYMk52ZFc1MElEMDlJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlkV2xzWkY5dVpYTjBaV1JmWTJGc2JGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlkV2xzWkY5dVpYTjBaV1JmWTJGc2JGOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TkRrS0lDQWdJQzh2SUhKbGRIVnliaUJVY25WbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NuSjFibDkwWlhOMGMxOW1iM0pmYUdWaFpHVnlYek5BTWpBNkNpQWdJQ0JwYm5Salh6TWdMeThnTXdvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTNPQW9nSUNBZ0x5OGdlU0E5SUZWSmJuUTJOQ2d5S1FvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE9EVUtJQ0FnSUM4dklHWnZjaUJoTENCaUlHbHVJQ2dvZUN3Z2VTa3NJQ2g1TENCNEtTd2dLSGdzSUhncExDQW9lU3dnZVNrcE9nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVGM0Q2lBZ0lDQXZMeUI1SUQwZ1ZVbHVkRFkwS0RJcENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTROUW9nSUNBZ0x5OGdabTl5SUdFc0lHSWdhVzRnS0NoNExDQjVLU3dnS0hrc0lIZ3BMQ0FvZUN3Z2VDa3NJQ2g1TENCNUtTazZDaUFnSUNCemQyRndDaUFnSUNCaUlISjFibDkwWlhOMGMxOW1iM0pmWW05a2VVQXhOd29LY25WdVgzUmxjM1J6WDJadmNsOW9aV0ZrWlhKZk1rQXhPVG9LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRjM0NpQWdJQ0F2THlCNElEMGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakU0TlFvZ0lDQWdMeThnWm05eUlHRXNJR0lnYVc0Z0tDaDRMQ0I1S1N3Z0tIa3NJSGdwTENBb2VDd2dlQ2tzSUNoNUxDQjVLU2s2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE56Y0tJQ0FnSUM4dklIZ2dQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRnMUNpQWdJQ0F2THlCbWIzSWdZU3dnWWlCcGJpQW9LSGdzSUhrcExDQW9lU3dnZUNrc0lDaDRMQ0I0S1N3Z0tIa3NJSGtwS1RvS0lDQWdJSE4zWVhBS0lDQWdJR0lnY25WdVgzUmxjM1J6WDJadmNsOWliMlI1UURFM0NncHlkVzVmZEdWemRITmZabTl5WDJobFlXUmxjbDh4UURFNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hOemdLSUNBZ0lDOHZJSGtnUFNCVlNXNTBOalFvTWlrS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk1UZzFDaUFnSUNBdkx5Qm1iM0lnWVN3Z1lpQnBiaUFvS0hnc0lIa3BMQ0FvZVN3Z2VDa3NJQ2g0TENCNEtTd2dLSGtzSUhrcEtUb0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakUzTndvZ0lDQWdMeThnZUNBOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hPRFVLSUNBZ0lDOHZJR1p2Y2lCaExDQmlJR2x1SUNnb2VDd2dlU2tzSUNoNUxDQjRLU3dnS0hnc0lIZ3BMQ0FvZVN3Z2VTa3BPZ29nSUNBZ2MzZGhjQW9nSUNBZ1lpQnlkVzVmZEdWemRITmZabTl5WDJKdlpIbEFNVGNLQ25KMWJsOTBaWE4wYzE5bWIzSmZhR1ZoWkdWeVh6TkFNVFU2Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNd29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pFM09Bb2dJQ0FnTHk4Z2VTQTlJRlZKYm5RMk5DZ3lLUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG94T0RFS0lDQWdJQzh2SUdadmNpQjBJR2x1SUNnb2VDd2dlU2tzSUNoNUxDQjRLU3dnS0hnc0lIZ3BMQ0FvZVN3Z2VTa3BPZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRjNENpQWdJQ0F2THlCNUlEMGdWVWx1ZERZMEtESXBDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakU0TVFvZ0lDQWdMeThnWm05eUlIUWdhVzRnS0NoNExDQjVLU3dnS0hrc0lIZ3BMQ0FvZUN3Z2VDa3NJQ2g1TENCNUtTazZDaUFnSUNCemQyRndDaUFnSUNCaUlISjFibDkwWlhOMGMxOW1iM0pmWW05a2VVQXhNZ29LY25WdVgzUmxjM1J6WDJadmNsOW9aV0ZrWlhKZk1rQXhORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRjM0NpQWdJQ0F2THlCNElEMGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakU0TVFvZ0lDQWdMeThnWm05eUlIUWdhVzRnS0NoNExDQjVLU3dnS0hrc0lIZ3BMQ0FvZUN3Z2VDa3NJQ2g1TENCNUtTazZDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG94TnpjS0lDQWdJQzh2SUhnZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVGd4Q2lBZ0lDQXZMeUJtYjNJZ2RDQnBiaUFvS0hnc0lIa3BMQ0FvZVN3Z2VDa3NJQ2g0TENCNEtTd2dLSGtzSUhrcEtUb0tJQ0FnSUhOM1lYQUtJQ0FnSUdJZ2NuVnVYM1JsYzNSelgyWnZjbDlpYjJSNVFERXlDZ3B5ZFc1ZmRHVnpkSE5mWm05eVgyaGxZV1JsY2w4eFFERXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG94TnpnS0lDQWdJQzh2SUhrZ1BTQlZTVzUwTmpRb01pa0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVGd4Q2lBZ0lDQXZMeUJtYjNJZ2RDQnBiaUFvS0hnc0lIa3BMQ0FvZVN3Z2VDa3NJQ2g0TENCNEtTd2dLSGtzSUhrcEtUb0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakUzTndvZ0lDQWdMeThnZUNBOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hPREVLSUNBZ0lDOHZJR1p2Y2lCMElHbHVJQ2dvZUN3Z2VTa3NJQ2g1TENCNEtTd2dLSGdzSUhncExDQW9lU3dnZVNrcE9nb2dJQ0FnYzNkaGNBb2dJQ0FnWWlCeWRXNWZkR1Z6ZEhOZlptOXlYMkp2WkhsQU1USUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQUNBeVlERjJKMWFXeGtYMjVsYzNSbFpGOWpZV3hzWDJOdmRXNTBCQlVmZkhVQ0FBd3hHRUFBQXlnalp6RWJRUUdRZ2dRRW5sbzdwd1RPb0ZJYkJEYy9XeVFFN0Zrd2xqWWFBSTRFQVZZQTR3Q0VBQUlqUXpFWkZFUXhHRVEyR2dGSkkxdExBVmNJQ0VzQ2dSQlpTd01WVHdST0FsSkpJMXRMQVlFSVdVc0NnUXBaU3dOUEFrc0NVbGNDQUVzREZVOEVUd05QQWxKWEFnQlBCQlpQQXhaTEF4VVdWd1lDVHdSUVN3TVZGbGNHQWs4RVVFOENLbEJMQWhXQkRBZ1dWd1lDVUU4Q1VFeFFURThDVUlBQ0FCSlFURkFwVEZDd0lrTXhHUlJFTVJoRU5ob0JTU05iU3dHQkNGbExBb0VLV1VzRFR3SkxBbEpYQWdCTEF4VlBCRThEVHdKU1Z3SUFUd0lXU3dJVkZsY0dBazhEVUVzQ0ZSWlhCZ0pQQTFCUEFpcFFTd0lWZ1F3SUZsY0dBbEJQQWxCTVVDbE1VTEFpUXpFWkZFUXhHRVEyR2dGSkkxbExBU1JaU3dKUEFrc0NVbGNDQUVzQ0ZVOERUd05QQWxKSkkxbExBUlZMQWs0Q1VsY0NBRXhYQWdnalcwc0JGUlpYQmdKUEFsQkxBaFVXVndZQ1R3TlFUd0lXZ0FJQUNreFFURkJMQVJXQkJBZ1dWd1lDZ0FJQUJFeFFUd0pRVEZBcFRGQ3dJa014R1JSRU1SaEVpQUJiZ0FFQUkwOENWQ2xNVUxBaVF6RVpRUDZPTVJnVVJDSkRpZ0lBSXlTTC9pSVNSSXYraS85QkFBc2xqQUNCQkl3Q2dRV01BWXYvSlF1TEFCSkVKSUVGaS85Tml3RkxBUkpFaXdKSlRnS0wvZ2dTUkNLQkJJdi9UUkpFaVlvQUFZQUFJaVFlVEJSTUpSSktFRVJNUkVRaVNZai9wU0lqaVArZ0l5SWtJNHNDVHdJSWl3RUlqQUdOQXdCa0FGc0FVaU1pakFBa1RJc0FUd0lJaXdFSWpBR05Bd0F4QUNnQUg0c0JnUWdLSlJKRUtDTm5JeWhsUkNJSUtFeG5JeWhsUkNJU1JDS01BSWtsSkl3QUpFeEMvOFlrSW93QUlreEMvNzBpSkl3QUlreEMvN1FsSkl3Q0pFeEMvNU1rSW93Q0lreEMvNG9pSkl3Q0lreEMvNEU9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
