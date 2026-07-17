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

namespace Arc56.Generated.algorandfoundation.puya.NestedTuples_257835c0
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

            public class ParentWithList : AVMObjectType
            {
                public Structs.Parent Parent { get; set; } = new Structs.Parent();

                public Structs.Child[] Children { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Parent.ToByteArray();
                    ret.AddRange(new byte[2]);
                    var arrChildren = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Child>(x => Structs.Child.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrChildren.Value = (Children ?? Array.Empty<Structs.Child>()).ToList();
                    stringRef[ret.Count] = arrChildren.Encode();
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

                public static ParentWithList Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ParentWithList();
                    var indexParent = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Parent = Structs.Parent.Parse(bytes.Skip(indexParent + prefixOffset).ToArray());
                    var indexChildren = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrChildren = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Child>(x => Structs.Child.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrChildren.Decode(bytes.Skip(indexChildren + prefixOffset).ToArray());
                    ret.Children = arrChildren.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ParentWithList);
                }
                public bool Equals(ParentWithList? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ParentWithList left, ParentWithList right)
                {
                    return EqualityComparer<ParentWithList>.Default.Equals(left, right);
                }
                public static bool operator !=(ParentWithList left, ParentWithList right)
                {
                    return !(left == right);
                }

            }

            public class SimpleTup : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SimpleTup Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SimpleTup();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SimpleTup);
                }
                public bool Equals(SimpleTup? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SimpleTup left, SimpleTup right)
                {
                    return EqualityComparer<SimpleTup>.Default.Equals(left, right);
                }
                public static bool operator !=(SimpleTup left, SimpleTup right)
                {
                    return !(left == right);
                }

            }

            public class TupleWithMutable : AVMObjectType
            {
                public ulong[] Arr { get; set; }

                public Structs.Child Child { get; set; } = new Structs.Child();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
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

                public static TupleWithMutable Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new TupleWithMutable();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
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
                    return Equals(obj as TupleWithMutable);
                }
                public bool Equals(TupleWithMutable? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TupleWithMutable left, TupleWithMutable right)
                {
                    return EqualityComparer<TupleWithMutable>.Default.Equals(left, right);
                }
                public static bool operator !=(TupleWithMutable left, TupleWithMutable right)
                {
                    return !(left == right);
                }

            }

            public class MaybeLoadTupleFromBoxReturn : AVMObjectType
            {
                public Structs.SimpleTup Field0 { get; set; } = new Structs.SimpleTup();

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static MaybeLoadTupleFromBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MaybeLoadTupleFromBoxReturn();
                    uint count = 0;
                    ret.Field0 = Structs.SimpleTup.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MaybeLoadTupleFromBoxReturn);
                }
                public bool Equals(MaybeLoadTupleFromBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MaybeLoadTupleFromBoxReturn left, MaybeLoadTupleFromBoxReturn right)
                {
                    return EqualityComparer<MaybeLoadTupleFromBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MaybeLoadTupleFromBoxReturn left, MaybeLoadTupleFromBoxReturn right)
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
        /// <param name="pwl"> ParentWithList</param>
        public async Task StoreTuple(Structs.ParentWithList pwl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 62, 30, 139 };

            var result = await base.CallApp(new List<object> { abiHandle, pwl }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StoreTuple_Transactions(Structs.ParentWithList pwl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 62, 30, 139 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pwl }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ParentWithList> LoadTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 203, 237, 215 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ParentWithList.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> LoadTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 203, 237, 215 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> SimpleTup</param>
        public async Task StoreTupleInBox(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 99, 252, 241 };

            var result = await base.CallApp(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StoreTupleInBox_Transactions(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 99, 252, 241 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> SimpleTup</param>
        public async Task<bool> IsTupleInBox(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 195, 115, 57 };

            var result = await base.CallApp(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsTupleInBox_Transactions(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 195, 115, 57 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> SimpleTup</param>
        public async Task<Structs.SimpleTup> LoadTupleFromBox(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 96, 190, 170 };

            var result = await base.CallApp(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SimpleTup.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> LoadTupleFromBox_Transactions(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 96, 190, 170 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> SimpleTup</param>
        public async Task<Structs.MaybeLoadTupleFromBoxReturn> MaybeLoadTupleFromBox(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 194, 21, 255 };

            var result = await base.CallApp(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MaybeLoadTupleFromBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MaybeLoadTupleFromBox_Transactions(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 194, 21, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> SimpleTup</param>
        public async Task<Structs.SimpleTup> LoadTupleFromBoxOrDefault(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 124, 144, 66 };

            var result = await base.CallApp(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SimpleTup.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> LoadTupleFromBoxOrDefault_Transactions(Structs.SimpleTup key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 124, 144, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<Structs.SimpleTup> LoadTupleFromLocalStateOrDefault(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 28, 113, 116 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SimpleTup.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> LoadTupleFromLocalStateOrDefault_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 28, 113, 116 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TupleWithMutable> MutateLocalTuple(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 204, 43, 80 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TupleWithMutable.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MutateLocalTuple_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 204, 43, 80 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task MutateTupleInStorageCurrentlySupportedMethod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 72, 109, 176 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MutateTupleInStorageCurrentlySupportedMethod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 72, 109, 176 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVzdGVkVHVwbGVzIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNoaWxkIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoic3RyaW5nIn1dLCJQYXJlbnQiOlt7Im5hbWUiOiJmb28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZm9vX2FyYyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjaGlsZCIsInR5cGUiOiJDaGlsZCJ9XSwiUGFyZW50V2l0aExpc3QiOlt7Im5hbWUiOiJwYXJlbnQiLCJ0eXBlIjoiUGFyZW50In0seyJuYW1lIjoiY2hpbGRyZW4iLCJ0eXBlIjoiQ2hpbGRbXSJ9XSwiU2ltcGxlVHVwIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XSwiVHVwbGVXaXRoTXV0YWJsZSI6W3sibmFtZSI6ImFyciIsInR5cGUiOiJ1aW50NjRbXSJ9LHsibmFtZSI6ImNoaWxkIiwidHlwZSI6IkNoaWxkIn1dLCJNYXliZUxvYWRUdXBsZUZyb21Cb3hSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiU2ltcGxlVHVwIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifV0sIk5lc3RlZFR1cGxlUGFyYW1zQXJnQXJncyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiTmVzdGVkVHVwbGVQYXJhbXNBcmdBcmdzRmllbGQxIn1dLCJOZXN0ZWRUdXBsZVBhcmFtc0FyZ0FyZ3NGaWVsZDEiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6Ik5lc3RlZFR1cGxlUGFyYW1zQXJnQXJnc0ZpZWxkMUZpZWxkMSJ9XSwiTmVzdGVkVHVwbGVQYXJhbXNBcmdBcmdzRmllbGQxRmllbGQxIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9XSwiTmVzdGVkVHVwbGVQYXJhbXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6Ik5lc3RlZFR1cGxlUGFyYW1zUmV0dXJuRmllbGQxIn1dLCJOZXN0ZWRUdXBsZVBhcmFtc1JldHVybkZpZWxkMSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InN0b3JlX3R1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IigodWludDY0LHVpbnQ2NCwodWludDY0LGJ5dGVbXSxzdHJpbmcpKSwodWludDY0LGJ5dGVbXSxzdHJpbmcpW10pIiwic3RydWN0IjoiUGFyZW50V2l0aExpc3QiLCJuYW1lIjoicHdsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvYWRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKCh1aW50NjQsdWludDY0LCh1aW50NjQsYnl0ZVtdLHN0cmluZykpLCh1aW50NjQsYnl0ZVtdLHN0cmluZylbXSkiLCJzdHJ1Y3QiOiJQYXJlbnRXaXRoTGlzdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0b3JlX3R1cGxlX2luX2JveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTaW1wbGVUdXAiLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX3R1cGxlX2luX2JveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTaW1wbGVUdXAiLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvYWRfdHVwbGVfZnJvbV9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiU2ltcGxlVHVwIiwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTaW1wbGVUdXAiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXliZV9sb2FkX3R1cGxlX2Zyb21fYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlNpbXBsZVR1cCIsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKCh1aW50NjQsdWludDY0KSxib29sKSIsInN0cnVjdCI6Ik1heWJlTG9hZFR1cGxlRnJvbUJveFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvYWRfdHVwbGVfZnJvbV9ib3hfb3JfZGVmYXVsdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTaW1wbGVUdXAiLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlNpbXBsZVR1cCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvYWRfdHVwbGVfZnJvbV9sb2NhbF9zdGF0ZV9vcl9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTaW1wbGVUdXAiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtdXRhdGVfbG9jYWxfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NFtdLCh1aW50NjQsYnl0ZVtdLHN0cmluZykpIiwic3RydWN0IjoiVHVwbGVXaXRoTXV0YWJsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11dGF0ZV90dXBsZV9pbl9zdG9yYWdlX2N1cnJlbnRseV9zdXBwb3J0ZWRfbWV0aG9kIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJ1bl90ZXN0cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuZXN0ZWRfdHVwbGVfcGFyYW1zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsKGJ5dGVbXSwodWludDY0KSkpIiwic3RydWN0IjoiTmVzdGVkVHVwbGVQYXJhbXNBcmdBcmdzIiwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbXSwoc3RyaW5nLHVpbnQ2NCkpIiwic3RydWN0IjoiTmVzdGVkVHVwbGVQYXJhbXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuYW1lZF90dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LGJ5dGVbXSxzdHJpbmcpIiwic3RydWN0IjoiQ2hpbGQiLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGJ5dGVbXSxzdHJpbmcpIiwic3RydWN0IjoiQ2hpbGQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuZXN0ZWRfbmFtZWRfdHVwbGVfcGFyYW1zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LCh1aW50NjQsYnl0ZVtdLHN0cmluZykpIiwic3RydWN0IjoiUGFyZW50IiwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsKHVpbnQ2NCxieXRlW10sc3RyaW5nKSkiLCJzdHJ1Y3QiOiJQYXJlbnQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY1OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94IGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHdsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHdtIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3MV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNSw0NDYsNDcwLDUyNyw1NDgsNzczLDEyMzIsMTI3MSwxMzc3LDEzOTgsMTQ0OSwxNDcwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC50dXBsZTxhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4sYXJjNC50dXBsZTxhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4sYXJjNC50dXBsZTxhcmM0LnVpbnQ2ND4+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy50dXBsZV9zdXBwb3J0Lm5lc3RlZF90dXBsZXMuQ2hpbGQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMudHVwbGVfc3VwcG9ydC5uZXN0ZWRfdHVwbGVzLlBhcmVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0X2Nhc2VzLnR1cGxlX3N1cHBvcnQubmVzdGVkX3R1cGxlcy5QYXJlbnRXaXRoTGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5NCw2MjYsNjU0LDY3NCw3MjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy50dXBsZV9zdXBwb3J0Lm5lc3RlZF90dXBsZXMuU2ltcGxlVHVwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdWludDhbXSksKHVpbnQ2NCkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSwoKGxlbit1aW50OFtdKSwodWludDY0KSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKHVpbnQ2NCx1aW50NjQsKHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdXRmOFtdKSkpLChsZW4rKHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdXRmOFtdKSlbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKChsZW4rdXRmOFtdKSwoKGxlbit1aW50OFtdKSwodWludDY0KSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAoKHVpbnQ2NCx1aW50NjQsKHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdXRmOFtdKSkpLChsZW4rKHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdXRmOFtdKSlbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE3LDUxOSwxMzY5LDE0NDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3V0ZjhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM4LDU0MCwxMzkwLDE0NjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICh1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3V0ZjhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA0LDE0MjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICh1aW50NjQsdWludDY0LCh1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3V0ZjhbXSkpKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyh1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3V0ZjhbXSkpW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgxLDM5OSw0MTIsNDMzLDQ1OSw1MTQsNTM1LDEyMTgsMTIzOSwxMjU3LDEzNjQsMTM4NSwxNDE5LDE0MzYsMTQ1N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ01pQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdJbUp2ZUNJZ0luUjNiU0lnSW1KMWFXeGtYMjVsYzNSbFpGOWpZV3hzWDJOdmRXNTBJaUFpY0hkc0lpQXdlREF3TURRS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRvMU1Bb2dJQ0FnTHk4Z2MyVnNaaTVpZFdsc1pGOXVaWE4wWldSZlkyRnNiRjlqYjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZblZwYkdSZmJtVnpkR1ZrWDJOaGJHeGZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzFNZ29nSUNBZ0x5OGdjMlZzWmk1MGQyMGdQU0JVZFhCc1pWZHBkR2hOZFhSaFlteGxLQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkSGR0SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd05EQXdNRFl3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01HTXdNREJsTURBd01EQXdNREFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRvMU1pMDFPUW9nSUNBZ0x5OGdjMlZzWmk1MGQyMGdQU0JVZFhCc1pWZHBkR2hOZFhSaFlteGxLQW9nSUNBZ0x5OGdJQ0FnSUdGeWNqMWhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGxWSmJuUTJORjBvS1N3S0lDQWdJQzh2SUNBZ0lDQmphR2xzWkQxRGFHbHNaQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZVDFWU1c1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZajFDZVhSbGN5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmpQVk4wY21sdVp5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk5EZ0tJQ0FnSUM4dklHTnNZWE56SUU1bGMzUmxaRlIxY0d4bGN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qTUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VETTRNMlV4WlRoaUlEQjROamhqWW1Wa1pEY2dNSGd5TWpZelptTm1NU0F3ZUdKbVl6TTNNek01SURCNFl6WTJNR0psWVdFZ01IaGlObU15TVRWbVppQXdlRGt3TjJNNU1EUXlJREI0WkRVeFl6Y3hOelFnTUhobU9HTmpNbUkxTUNBd2VETmtORGcyWkdJd0lEQjRPV1UxWVROaVlUY2dNSGhqWldFd05USXhZaUF3ZURNM00yWTFZakkwSURCNFpXTTFPVE13T1RZZ0x5OGdiV1YwYUc5a0lDSnpkRzl5WlY5MGRYQnNaU2dvS0hWcGJuUTJOQ3gxYVc1ME5qUXNLSFZwYm5RMk5DeGllWFJsVzEwc2MzUnlhVzVuS1Nrc0tIVnBiblEyTkN4aWVYUmxXMTBzYzNSeWFXNW5LVnRkS1NsMmIybGtJaXdnYldWMGFHOWtJQ0pzYjJGa1gzUjFjR3hsS0Nrb0tIVnBiblEyTkN4MWFXNTBOalFzS0hWcGJuUTJOQ3hpZVhSbFcxMHNjM1J5YVc1bktTa3NLSFZwYm5RMk5DeGllWFJsVzEwc2MzUnlhVzVuS1Z0ZEtTSXNJRzFsZEdodlpDQWljM1J2Y21WZmRIVndiR1ZmYVc1ZlltOTRLQ2gxYVc1ME5qUXNkV2x1ZERZMEtTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGMxOTBkWEJzWlY5cGJsOWliM2dvS0hWcGJuUTJOQ3gxYVc1ME5qUXBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0lteHZZV1JmZEhWd2JHVmZabkp2YlY5aWIzZ29LSFZwYm5RMk5DeDFhVzUwTmpRcEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWJXRjVZbVZmYkc5aFpGOTBkWEJzWlY5bWNtOXRYMkp2ZUNnb2RXbHVkRFkwTEhWcGJuUTJOQ2twS0NoMWFXNTBOalFzZFdsdWREWTBLU3hpYjI5c0tTSXNJRzFsZEdodlpDQWliRzloWkY5MGRYQnNaVjltY205dFgySnZlRjl2Y2w5a1pXWmhkV3gwS0NoMWFXNTBOalFzZFdsdWREWTBLU2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbXh2WVdSZmRIVndiR1ZmWm5KdmJWOXNiMk5oYkY5emRHRjBaVjl2Y2w5a1pXWmhkV3gwS0hOMGNtbHVaeWtvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbTExZEdGMFpWOXNiMk5oYkY5MGRYQnNaU2dwS0hWcGJuUTJORnRkTENoMWFXNTBOalFzWW5sMFpWdGRMSE4wY21sdVp5a3BJaXdnYldWMGFHOWtJQ0p0ZFhSaGRHVmZkSFZ3YkdWZmFXNWZjM1J2Y21GblpWOWpkWEp5Wlc1MGJIbGZjM1Z3Y0c5eWRHVmtYMjFsZEdodlpDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNuVnVYM1JsYzNSektDbGliMjlzSWl3Z2JXVjBhRzlrSUNKdVpYTjBaV1JmZEhWd2JHVmZjR0Z5WVcxektDaHpkSEpwYm1jc0tHSjVkR1ZiWFN3b2RXbHVkRFkwS1NrcEtTaGllWFJsVzEwc0tITjBjbWx1Wnl4MWFXNTBOalFwS1NJc0lHMWxkR2h2WkNBaWJtRnRaV1JmZEhWd2JHVW9LSFZwYm5RMk5DeGllWFJsVzEwc2MzUnlhVzVuS1Nrb2RXbHVkRFkwTEdKNWRHVmJYU3h6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0p1WlhOMFpXUmZibUZ0WldSZmRIVndiR1ZmY0dGeVlXMXpLQ2gxYVc1ME5qUXNkV2x1ZERZMExDaDFhVzUwTmpRc1lubDBaVnRkTEhOMGNtbHVaeWtwS1NoMWFXNTBOalFzZFdsdWREWTBMQ2gxYVc1ME5qUXNZbmwwWlZ0ZExITjBjbWx1WnlrcElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2djM1J2Y21WZmRIVndiR1VnYkc5aFpGOTBkWEJzWlNCemRHOXlaVjkwZFhCc1pWOXBibDlpYjNnZ2FYTmZkSFZ3YkdWZmFXNWZZbTk0SUd4dllXUmZkSFZ3YkdWZlpuSnZiVjlpYjNnZ2JXRjVZbVZmYkc5aFpGOTBkWEJzWlY5bWNtOXRYMkp2ZUNCc2IyRmtYM1IxY0d4bFgyWnliMjFmWW05NFgyOXlYMlJsWm1GMWJIUWdiRzloWkY5MGRYQnNaVjltY205dFgyeHZZMkZzWDNOMFlYUmxYMjl5WDJSbFptRjFiSFFnYlhWMFlYUmxYMnh2WTJGc1gzUjFjR3hsSUcxMWRHRjBaVjkwZFhCc1pWOXBibDl6ZEc5eVlXZGxYMk4xY25KbGJuUnNlVjl6ZFhCd2IzSjBaV1JmYldWMGFHOWtJSEoxYmw5MFpYTjBjeUJ1WlhOMFpXUmZkSFZ3YkdWZmNHRnlZVzF6SUc1aGJXVmtYM1IxY0d4bElHNWxjM1JsWkY5dVlXMWxaRjkwZFhCc1pWOXdZWEpoYlhNS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXlNem9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZFhCc1pWOXpkWEJ3YjNKMExtNWxjM1JsWkY5MGRYQnNaWE11WjJWMFgzTmxibVJsY2w5cGJtVm1abWxqYVdWdWRHeDVLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOXpaVzVrWlhKZmFXNWxabVpwWTJsbGJuUnNlVG9LSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE9ERUtJQ0FnSUM4dklHeHZaeWdpVDNKa1pYSWdhWE1nYVcxd2IzSjBZVzUwSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpVDNKa1pYSWdhWE1nYVcxd2IzSjBZVzUwSWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk1UZ3lDaUFnSUNBdkx5QnlaWFIxY200Z1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1MGRYQnNaVjl6ZFhCd2IzSjBMbTVsYzNSbFpGOTBkWEJzWlhNdWMybHRjR3hsWDNSMWNDaGhPaUIxYVc1ME5qUXNJR0k2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwTENCMWFXNTBOalE2Q25OcGJYQnNaVjkwZFhBNkNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVGcxTFRFNE5nb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVW9hVzVzYVc1bFBVWmhiSE5sS1FvZ0lDQWdMeThnWkdWbUlITnBiWEJzWlY5MGRYQW9ZVG9nVlVsdWREWTBMQ0JpT2lCVlNXNTBOalFwSUMwK0lGTnBiWEJzWlZSMWNEb0tJQ0FnSUhCeWIzUnZJRElnTWdvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qRTROd29nSUNBZ0x5OGdiRzluS0NKSkoyMGdhblZ6ZENCaElITnBiWEJzWlNCMGRYQWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkpKMjBnYW5WemRDQmhJSE5wYlhCc1pTQjBkWEFpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE9EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCVGFXMXdiR1ZVZFhBb1lTd2dZaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblIxY0d4bFgzTjFjSEJ2Y25RdWJtVnpkR1ZrWDNSMWNHeGxjeTVsWTJodktITTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taV05vYnpvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hPVEV0TVRreUNpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpTaHBibXhwYm1VOVJtRnNjMlVwQ2lBZ0lDQXZMeUJrWldZZ1pXTm9ieWh6T2lCVGRISnBibWNwSUMwK0lGTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pFNU13b2dJQ0FnTHk4Z2JHOW5LQ0pKY3lCMGFHVnlaU0JoYmlCbFkyaHZJR2x1SUdobGNtVS9JaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTWE1nZEdobGNtVWdZVzRnWldOb2J5QnBiaUJvWlhKbFB5SUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakU1TkFvZ0lDQWdMeThnY21WMGRYSnVJSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZFhCc1pWOXpkWEJ3YjNKMExtNWxjM1JsWkY5MGRYQnNaWE11ZEdWemRGOXVaWE4wWldSZmMybHVaMnhsY3lodmJtVTZJSFZwYm5RMk5Dd2djbVZoYzNOcFoyNDZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkR1Z6ZEY5dVpYTjBaV1JmYzJsdVoyeGxjem9LSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveU5EY3RNalE0Q2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlFvZ0lDQWdMeThnWkdWbUlIUmxjM1JmYm1WemRHVmtYM05wYm1kc1pYTW9iMjVsT2lCVlNXNTBOalFzSUNvc0lISmxZWE56YVdkdU9pQmliMjlzS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TWpVd0NpQWdJQ0F2THlBb1ZVbHVkRFkwS0RBcExDa3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakkxTWdvZ0lDQWdMeThnS0ZWSmJuUTJOQ2d5S1N3cExBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3lOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpXekZkV3pCZElEMDlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG95TmpFS0lDQWdJQzh2SUdsbUlISmxZWE56YVdkdU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpYm5vZ2RHVnpkRjl1WlhOMFpXUmZjMmx1WjJ4bGMxOXBabDlpYjJSNVFERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb0tkR1Z6ZEY5dVpYTjBaV1JmYzJsdVoyeGxjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TWpZM0NpQWdJQ0F2THlCaGMzTmxjblFnYzFzd1hWc3dYU0E5UFNBb015QnBaaUJ5WldGemMybG5iaUJsYkhObElEQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdLZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG95TmprS0lDQWdJQzh2SUdGemMyVnlkQ0IwYlhBZ1BUMGdLRFVnYVdZZ2NtVmhjM05wWjI0Z1pXeHpaU0F5S1FvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lIQjFjMmhwYm5RZ05Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakkzTXdvZ0lDQWdMeThnY3pFZ0t6MGdiMjVsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXJDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TWpjMENpQWdJQ0F2THlCaGMzTmxjblFnY3pFZ1BUMGdLRFVnYVdZZ2NtVmhjM05wWjI0Z1pXeHpaU0F5S1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qSTNOUW9nSUNBZ0x5OGdZWE56WlhKMElITmJNVjFiTUYwZ1BUMGdLRFFnYVdZZ2NtVmhjM05wWjI0Z1pXeHpaU0F4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6Wld4bFkzUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhKbGRITjFZZ29LZEdWemRGOXVaWE4wWldSZmMybHVaMnhsYzE5cFpsOWliMlI1UURFNkNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNall6Q2lBZ0lDQXZMeUFvVlVsdWREWTBLRE1wTENrc0NpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveU5qSXRNalkyQ2lBZ0lDQXZMeUJ6SUQwZ0tBb2dJQ0FnTHk4Z0lDQWdJQ2hWU1c1ME5qUW9NeWtzS1N3S0lDQWdJQzh2SUNBZ0lDQW9WVWx1ZERZMEtEUXBMQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0tGVkpiblEyTkNnMUtTd3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TWpZMExUSTJOUW9nSUNBZ0x5OGdLRlZKYm5RMk5DZzBLU3dwTEFvZ0lDQWdMeThnS0ZWSmJuUTJOQ2cxS1N3cExBb2dJQ0FnY0hWemFHbHVkSE1nTkNBMUNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNall5TFRJMk5nb2dJQ0FnTHk4Z2N5QTlJQ2dLSUNBZ0lDOHZJQ0FnSUNBb1ZVbHVkRFkwS0RNcExDa3NDaUFnSUNBdkx5QWdJQ0FnS0ZWSmJuUTJOQ2cwS1N3cExBb2dJQ0FnTHk4Z0lDQWdJQ2hWU1c1ME5qUW9OU2tzS1N3S0lDQWdJQzh2SUNrS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUIwWlhOMFgyNWxjM1JsWkY5emFXNW5iR1Z6WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkSFZ3YkdWZmMzVndjRzl5ZEM1dVpYTjBaV1JmZEhWd2JHVnpMazVsYzNSbFpGUjFjR3hsY3k1emRHOXlaVjkwZFhCc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4wYjNKbFgzUjFjR3hsT2dvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qWXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTUNCdlppQW9LSFZwYm5RMk5DeDFhVzUwTmpRc0tIVnBiblEyTkN3b2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRYUm1PRnRkS1NrcExDaHNaVzRyS0hWcGJuUTJOQ3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFhSbU9GdGRLU2xiWFNrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeUlHOW1JQ2gxYVc1ME5qUXNkV2x1ZERZMExDaDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVjBaamhiWFNrcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2gxYVc1ME5qUXNLR3hsYml0MWFXNTBPRnRkS1N3b2JHVnVLM1YwWmpoYlhTa3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElERTBDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTWlCdlppQW9kV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ2NIVnphR2x1ZENBeU1nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNnb2RXbHVkRFkwTEhWcGJuUTJOQ3dvZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxZEdZNFcxMHBLU2tzS0d4bGJpc29kV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFkR1k0VzEwcEtWdGRLU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3B6ZEc5eVpWOTBkWEJzWlY5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TmpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQThDaUFnSUNCaWVpQnpkRzl5WlY5MGRYQnNaVjloWm5SbGNsOW1iM0pBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQm1iM0lnS0d4bGJpc29kV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFkR1k0VzEwcEtWdGRLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNoMWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWMFpqaGJYU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREUwQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01pQnZaaUFvZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxZEdZNFcxMHBLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ2MzUnZjbVZmZEhWd2JHVmZabTl5WDJobFlXUmxja0F4Q2dwemRHOXlaVjkwZFhCc1pWOWhablJsY2w5bWIzSkFORG9LSUNBZ0lIQnZjRzRnTWdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZOakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RHVnpkRjlqWVhObGN5NTBkWEJzWlY5emRYQndiM0owTG01bGMzUmxaRjkwZFhCc1pYTXVVR0Z5Wlc1MFYybDBhRXhwYzNRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzJNd29nSUNBZ0x5OGdjMlZzWmk1d2Qyd2dQU0J3ZDJ3S0lDQWdJR0o1ZEdWaklEUWdMeThnSW5CM2JDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TmpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZFhCc1pWOXpkWEJ3YjNKMExtNWxjM1JsWkY5MGRYQnNaWE11VG1WemRHVmtWSFZ3YkdWekxteHZZV1JmZEhWd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYjJGa1gzUjFjR3hsT2dvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qWTNDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV3ZDJ3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p3ZDJ3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSGRzSUdWNGFYTjBjd29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhWd2JHVmZjM1Z3Y0c5eWRDNXVaWE4wWldSZmRIVndiR1Z6TGs1bGMzUmxaRlIxY0d4bGN5NXpkRzl5WlY5MGRYQnNaVjlwYmw5aWIzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZEc5eVpWOTBkWEJzWlY5cGJsOWliM2c2Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RHVnpkRjlqWVhObGN5NTBkWEJzWlY5emRYQndiM0owTG01bGMzUmxaRjkwZFhCc1pYTXVVMmx0Y0d4bFZIVndDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZOekVLSUNBZ0lDOHZJSE5sYkdZdVltOTRXMnRsZVYwZ1BTQnJaWGt1WDNKbGNHeGhZMlVvWWoxclpYa3VZaUFySURFcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWlZbTk0SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1MGRYQnNaVjl6ZFhCd2IzSjBMbTVsYzNSbFpGOTBkWEJzWlhNdVRtVnpkR1ZrVkhWd2JHVnpMbWx6WDNSMWNHeGxYMmx1WDJKdmVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx6WDNSMWNHeGxYMmx1WDJKdmVEb0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG8zTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIwWlhOMFgyTmhjMlZ6TG5SMWNHeGxYM04xY0hCdmNuUXVibVZ6ZEdWa1gzUjFjR3hsY3k1VGFXMXdiR1ZVZFhBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzNOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHdGxlU0JwYmlCelpXeG1MbUp2ZUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzNNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SMWNHeGxYM04xY0hCdmNuUXVibVZ6ZEdWa1gzUjFjR3hsY3k1T1pYTjBaV1JVZFhCc1pYTXViRzloWkY5MGRYQnNaVjltY205dFgySnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q214dllXUmZkSFZ3YkdWZlpuSnZiVjlpYjNnNkNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZOemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkR1Z6ZEY5allYTmxjeTUwZFhCc1pWOXpkWEJ3YjNKMExtNWxjM1JsWkY5MGRYQnNaWE11VTJsdGNHeGxWSFZ3Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk56a0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUZ0clpYbGRDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnZlQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjFjR3hsWDNOMWNIQnZjblF1Ym1WemRHVmtYM1IxY0d4bGN5NU9aWE4wWldSVWRYQnNaWE11YldGNVltVmZiRzloWkY5MGRYQnNaVjltY205dFgySnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xaGVXSmxYMnh2WVdSZmRIVndiR1ZmWm5KdmJWOWliM2c2Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk9ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RHVnpkRjlqWVhObGN5NTBkWEJzWlY5emRYQndiM0owTG01bGMzUmxaRjkwZFhCc1pYTXVVMmx0Y0d4bFZIVndDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2T0RNS0lDQWdJQzh2SUcxaGVXSmxYM1poYkhWbExDQmxlR2x6ZEhNZ1BTQnpaV3htTG1KdmVDNXRZWGxpWlNoclpYa3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllaUJ0WVhsaVpWOXNiMkZrWDNSMWNHeGxYMlp5YjIxZlltOTRYM1JsY201aGNubGZabUZzYzJWQU13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvS2JXRjVZbVZmYkc5aFpGOTBkWEJzWlY5bWNtOXRYMkp2ZUY5MFpYSnVZWEo1WDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk9ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0Y1WW1WZmJHOWhaRjkwZFhCc1pWOW1jbTl0WDJKdmVGOTBaWEp1WVhKNVgyWmhiSE5sUURNNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzRNd29nSUNBZ0x5OGdiV0Y1WW1WZmRtRnNkV1VzSUdWNGFYTjBjeUE5SUhObGJHWXVZbTk0TG0xaGVXSmxLR3RsZVNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlJRzFoZVdKbFgyeHZZV1JmZEhWd2JHVmZabkp2YlY5aWIzaGZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnZEdWemRGOWpZWE5sY3k1MGRYQnNaVjl6ZFhCd2IzSjBMbTVsYzNSbFpGOTBkWEJzWlhNdVRtVnpkR1ZrVkhWd2JHVnpMbXh2WVdSZmRIVndiR1ZmWm5KdmJWOWliM2hmYjNKZlpHVm1ZWFZzZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHZZV1JmZEhWd2JHVmZabkp2YlY5aWIzaGZiM0pmWkdWbVlYVnNkRG9LSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRvNE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBYMk5oYzJWekxuUjFjR3hsWDNOMWNIQnZjblF1Ym1WemRHVmtYM1IxY0d4bGN5NVRhVzF3YkdWVWRYQUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG80T0FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMbWRsZENoclpYa3NJR1JsWm1GMWJIUTljMmx0Y0d4bFgzUjFjQ2hWU1c1ME5qUW9OQ2tzSUZWSmJuUTJOQ2d5S1NrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR05oYkd4emRXSWdjMmx0Y0d4bFgzUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5vZ2JHOWhaRjkwZFhCc1pWOW1jbTl0WDJKdmVGOXZjbDlrWldaaGRXeDBYM1JsY201aGNubGZabUZzYzJWQU13b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWRYSjVJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtDbXh2WVdSZmRIVndiR1ZmWm5KdmJWOWliM2hmYjNKZlpHVm1ZWFZzZEY5MFpYSnVZWEo1WDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk9EWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbXh2WVdSZmRIVndiR1ZmWm5KdmJWOWliM2hmYjNKZlpHVm1ZWFZzZEY5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQndiM0FLSUNBZ0lHSWdiRzloWkY5MGRYQnNaVjltY205dFgySnZlRjl2Y2w5a1pXWmhkV3gwWDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklIUmxjM1JmWTJGelpYTXVkSFZ3YkdWZmMzVndjRzl5ZEM1dVpYTjBaV1JmZEhWd2JHVnpMazVsYzNSbFpGUjFjR3hsY3k1c2IyRmtYM1IxY0d4bFgyWnliMjFmYkc5allXeGZjM1JoZEdWZmIzSmZaR1ZtWVhWc2RGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXh2WVdSZmRIVndiR1ZmWm5KdmJWOXNiMk5oYkY5emRHRjBaVjl2Y2w5a1pXWmhkV3gwT2dvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qa3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRvNU1nb2dJQ0FnTHk4Z2JHOWpZV3dnUFNCTWIyTmhiRk4wWVhSbEtGTnBiWEJzWlZSMWNDd2dhMlY1UFdWamFHOG9hMlY1S1NrS0lDQWdJR05oYkd4emRXSWdaV05vYndvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qa3pDaUFnSUNBdkx5QnlaWFIxY200Z2JHOWpZV3d1WjJWMEtHZGxkRjl6Wlc1a1pYSmZhVzVsWm1acFkybGxiblJzZVNncExDQmtaV1poZFd4MFBYTnBiWEJzWlY5MGRYQW9WVWx1ZERZMEtEUXBMQ0JWU1c1ME5qUW9NaWtwS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmYzJWdVpHVnlYMmx1WldabWFXTnBaVzUwYkhrS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdOaGJHeHpkV0lnYzJsdGNHeGxYM1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWW5vZ2JHOWhaRjkwZFhCc1pWOW1jbTl0WDJ4dlkyRnNYM04wWVhSbFgyOXlYMlJsWm1GMWJIUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb0tiRzloWkY5MGRYQnNaVjltY205dFgyeHZZMkZzWDNOMFlYUmxYMjl5WDJSbFptRjFiSFJmZEdWeWJtRnllVjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2prd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHNiMkZrWDNSMWNHeGxYMlp5YjIxZmJHOWpZV3hmYzNSaGRHVmZiM0pmWkdWbVlYVnNkRjkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNCd2IzQUtJQ0FnSUdJZ2JHOWhaRjkwZFhCc1pWOW1jbTl0WDJ4dlkyRnNYM04wWVhSbFgyOXlYMlJsWm1GMWJIUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnZEdWemRGOWpZWE5sY3k1MGRYQnNaVjl6ZFhCd2IzSjBMbTVsYzNSbFpGOTBkWEJzWlhNdVRtVnpkR1ZrVkhWd2JHVnpMbTExZEdGMFpWOXNiMk5oYkY5MGRYQnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xMWRHRjBaVjlzYjJOaGJGOTBkWEJzWlRvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hNRGNLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTZ3pLVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3B0ZFhSaGRHVmZiRzlqWVd4ZmRIVndiR1ZmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakV3TndvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLRE1wT2dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUR3S0lDQWdJR0o2SUcxMWRHRjBaVjlzYjJOaGJGOTBkWEJzWlY5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakV3T0FvZ0lDQWdMeThnWVhOelpYSjBJSFIzYlM1aGNuSmJhVjBnUFQwZ2FRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hNRGNLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTZ3pLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUcxMWRHRjBaVjlzYjJOaGJGOTBkWEJzWlY5bWIzSmZhR1ZoWkdWeVFESUtDbTExZEdGMFpWOXNiMk5oYkY5MGRYQnNaVjloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUbzVOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdOREF3TVdVd01EQXpNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF5TURBd01EQXdNREF3TURBd01EQXdNREF3TUdNd01EQmxNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRIVndiR1ZmYzNWd2NHOXlkQzV1WlhOMFpXUmZkSFZ3YkdWekxrNWxjM1JsWkZSMWNHeGxjeTV0ZFhSaGRHVmZkSFZ3YkdWZmFXNWZjM1J2Y21GblpWOWpkWEp5Wlc1MGJIbGZjM1Z3Y0c5eWRHVmtYMjFsZEdodlpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTExZEdGMFpWOTBkWEJzWlY5cGJsOXpkRzl5WVdkbFgyTjFjbkpsYm5Sc2VWOXpkWEJ3YjNKMFpXUmZiV1YwYUc5a09nb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakV4TmdvZ0lDQWdMeThnWVhKeU1pQTlJSE5sYkdZdWRIZHRMbUZ5Y2k1amIzQjVLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBkMjBpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRIZHRJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRFM0NpQWdJQ0F2THlCaGNuSXlMbUZ3Y0dWdVpDaGhjbU0wTGxWSmJuUTJOQ2d4S1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk1URTNDaUFnSUNBdkx5Qmhjbkl5TG1Gd2NHVnVaQ2hoY21NMExsVkpiblEyTkNneEtTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hNVGdLSUNBZ0lDOHZJSE5sYkdZdWRIZHRJRDBnYzJWc1ppNTBkMjB1WDNKbGNHeGhZMlVvWVhKeVBXRnljakl1WTI5d2VTZ3BLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdPQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQmpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUNzS0lDQWdJR1JwWnlBMENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd01EUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkSGR0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBkWEJzWlY5emRYQndiM0owTG01bGMzUmxaRjkwZFhCc1pYTXVUbVZ6ZEdWa1ZIVndiR1Z6TG5KMWJsOTBaWE4wYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSjFibDkwWlhOMGN6b0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG94TXpZS0lDQWdJQzh2SUhSbGMzUmZhVzUwY21sdWMybGpjeWhWU1c1ME5qUW9NU2tzSUZWSmJuUTJOQ2d5S1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pJeE5Bb2dJQ0FnTHk4Z2JuUWdQU0FvVlVsdWREWTBLREVwTENCdmNDNWhaR1IzS0c1MWJURXNJRzUxYlRJcExDQlZTVzUwTmpRb05ESXBLUW9nSUNBZ1lXUmtkd29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pJeE53b2dJQ0FnTHk4Z1lYTnpaWEowSUc1MFd6RmRJRDA5SUNnd0xDQnVkVzB4SUNzZ2JuVnRNaWtnSUNNZ2RIbHdaVG9nYVdkdWIzSmxXMk52YlhCaGNtbHpiMjR0YjNabGNteGhjRjBLSUNBZ0lITjNZWEFLSUNBZ0lDRUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHUjFjRElLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveU1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCdWRGc3hYVnM2TVYwZ1BUMGdLREFzS1NBZ0l5QjBlWEJsT2lCcFoyNXZjbVZiWTI5dGNHRnlhWE52YmkxdmRtVnliR0Z3WFFvZ0lDQWdjM2RoY0FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNakU1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiblJiTVYxYk1UcGRJRDA5SUNodWRXMHhJQ3NnYm5WdE1pd3BDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE16Z0tJQ0FnSUM4dklIUmxjM1JmYm1WemRHVmtYM05wYm1kc1pYTW9WVWx1ZERZMEtERXBMQ0J5WldGemMybG5iajFVY25WbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wWDI1bGMzUmxaRjl6YVc1bmJHVnpDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRNNUNpQWdJQ0F2THlCMFpYTjBYMjVsYzNSbFpGOXphVzVuYkdWektGVkpiblEyTkNneEtTd2djbVZoYzNOcFoyNDlSbUZzYzJVcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRjl1WlhOMFpXUmZjMmx1WjJ4bGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3lPVFVLSUNBZ0lDOHZJSFJ2ZEdGc0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG95T1RNS0lDQWdJQzh2SUhnZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNamswQ2lBZ0lDQXZMeUI1SUQwZ1ZVbHVkRFkwS0RJcENpQWdJQ0JwYm5Salh6SWdMeThnTWdvS2NuVnVYM1JsYzNSelgyWnZjbDlpYjJSNVFERXlPZ29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pJNU9Rb2dJQ0FnTHk4Z2RHOTBZV3dnS3owZ1lTQXJJR0lLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3lPVGNLSUNBZ0lDOHZJR1p2Y2lCMElHbHVJQ2dvZUN3Z2VTa3NJQ2g1TENCNEtTd2dLSGdzSUhncExDQW9lU3dnZVNrcE9nb2dJQ0FnYzNkaGNBb2dJQ0FnYzNkcGRHTm9JSEoxYmw5MFpYTjBjMTltYjNKZmFHVmhaR1Z5WHpGQU1UTWdjblZ1WDNSbGMzUnpYMlp2Y2w5b1pXRmtaWEpmTWtBeE5DQnlkVzVmZEdWemRITmZabTl5WDJobFlXUmxjbDh6UURFMUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOXVaWE4wWldSZmRIVndiR1Z6TG5CNU9qSTVNd29nSUNBZ0x5OGdlQ0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveU9UUUtJQ0FnSUM4dklIa2dQU0JWU1c1ME5qUW9NaWtLSUNBZ0lHbHVkR05mTWlBdkx5QXlDZ3B5ZFc1ZmRHVnpkSE5mWm05eVgySnZaSGxBTVRjNkNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNekF5Q2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0JoSUNzZ1lnb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ0x5OGdkSFZ3YkdWZmMzVndjRzl5ZEM5dVpYTjBaV1JmZEhWd2JHVnpMbkI1T2pNd01Rb2dJQ0FnTHk4Z1ptOXlJR0VzSUdJZ2FXNGdLQ2g0TENCNUtTd2dLSGtzSUhncExDQW9lQ3dnZUNrc0lDaDVMQ0I1S1NrNkNpQWdJQ0J6ZDJGd0NpQWdJQ0J6ZDJsMFkyZ2djblZ1WDNSbGMzUnpYMlp2Y2w5b1pXRmtaWEpmTVVBeE9DQnlkVzVmZEdWemRITmZabTl5WDJobFlXUmxjbDh5UURFNUlISjFibDkwWlhOMGMxOW1iM0pmYUdWaFpHVnlYek5BTWpBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3pNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBiM1JoYkNBdkx5QTRJRDA5SURNS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXZDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3hOamdLSUNBZ0lDOHZJSE5sYkdZdVluVnBiR1JmYm1WemRHVmtYMk5oYkd4ZlkyOTFiblFnS3owZ01Rb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVluVnBiR1JmYm1WemRHVmtYMk5oYkd4ZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveE1qQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSjFibDkwWlhOMGMxOW1iM0pmYUdWaFpHVnlYek5BTWpBNkNpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveU9UUUtJQ0FnSUM4dklIa2dQU0JWU1c1ME5qUW9NaWtLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdJZ2NuVnVYM1JsYzNSelgyWnZjbDlpYjJSNVFERTNDZ3B5ZFc1ZmRHVnpkSE5mWm05eVgyaGxZV1JsY2w4eVFERTVPZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG95T1RNS0lDQWdJQzh2SUhnZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JrZFhBS0lDQWdJR0lnY25WdVgzUmxjM1J6WDJadmNsOWliMlI1UURFM0NncHlkVzVmZEdWemRITmZabTl5WDJobFlXUmxjbDh4UURFNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3lPVFFLSUNBZ0lDOHZJSGtnUFNCVlNXNTBOalFvTWlrS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwyNWxjM1JsWkY5MGRYQnNaWE11Y0hrNk1qa3pDaUFnSUNBdkx5QjRJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lpQnlkVzVmZEdWemRITmZabTl5WDJKdlpIbEFNVGNLQ25KMWJsOTBaWE4wYzE5bWIzSmZhR1ZoWkdWeVh6TkFNVFU2Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2Ym1WemRHVmtYM1IxY0d4bGN5NXdlVG95T1RRS0lDQWdJQzh2SUhrZ1BTQlZTVzUwTmpRb01pa0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JrZFhBS0lDQWdJR0lnY25WdVgzUmxjM1J6WDJadmNsOWliMlI1UURFeUNncHlkVzVmZEdWemRITmZabTl5WDJobFlXUmxjbDh5UURFME9nb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZibVZ6ZEdWa1gzUjFjR3hsY3k1d2VUb3lPVE1LSUNBZ0lDOHZJSGdnUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSWdjblZ1WDNSbGMzUnpYMlp2Y2w5aWIyUjVRREV5Q2dweWRXNWZkR1Z6ZEhOZlptOXlYMmhsWVdSbGNsOHhRREV6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmJtVnpkR1ZrWDNSMWNHeGxjeTV3ZVRveU9UUUtJQ0FnSUM4dklIa2dQU0JWU1c1ME5qUW9NaWtLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TWprekNpQWdJQ0F2THlCNElEMGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWWlCeWRXNWZkR1Z6ZEhOZlptOXlYMkp2WkhsQU1USUtDZ292THlCMFpYTjBYMk5oYzJWekxuUjFjR3hsWDNOMWNIQnZjblF1Ym1WemRHVmtYM1IxY0d4bGN5NU9aWE4wWldSVWRYQnNaWE11Ym1WemRHVmtYM1IxY0d4bFgzQmhjbUZ0YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtNWxjM1JsWkY5MGRYQnNaVjl3WVhKaGJYTTZDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDI1bGMzUmxaRjkwZFhCc1pYTXVjSGs2TVRRNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURBZ2IyWWdLQ2hzWlc0cmRYUm1PRnRkS1N3b0tHeGxiaXQxYVc1ME9GdGRLU3dvZFdsdWREWTBLU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElERWdiMllnS0Noc1pXNHJkWFJtT0Z0ZEtTd29LR3hsYml0MWFXNTBPRnRkS1N3b2RXbHVkRFkwS1NrcENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QTFDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEQWdiMllnS0Noc1pXNHJkV2x1ZERoYlhTa3NLSFZwYm5RMk5Da3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTBkWEJzWlR4aGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENHNZWEpqTkM1MGRYQnNaVHhoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0c1lYSmpOQzUwZFhCc1pUeGhjbU0wTG5WcGJuUTJORDQrUGdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTWlBNENpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01HRUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQXdOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZFhCc1pWOXpkWEJ3YjNKMExtNWxjM1JsWkY5MGRYQnNaWE11VG1WemRHVmtWSFZ3YkdWekxtNWhiV1ZrWDNSMWNHeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYm1GdFpXUmZkSFZ3YkdVNkNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMMjVsYzNSbFpGOTBkWEJzWlhNdWNIazZNVFUyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F4SUc5bUlDaDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVjBaamhiWFNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURFMENpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNaUJ2WmlBb2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWRHWTRXMTBwS1FvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhSbGMzUmZZMkZ6WlhNdWRIVndiR1ZmYzNWd2NHOXlkQzV1WlhOMFpXUmZkSFZ3YkdWekxrTm9hV3hrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZFhCc1pWOXpkWEJ3YjNKMExtNWxjM1JsWkY5MGRYQnNaWE11VG1WemRHVmtWSFZ3YkdWekxtNWxjM1JsWkY5dVlXMWxaRjkwZFhCc1pWOXdZWEpoYlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHVaWE4wWldSZmJtRnRaV1JmZEhWd2JHVmZjR0Z5WVcxek9nb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzl1WlhOMFpXUmZkSFZ3YkdWekxuQjVPakUyTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4T0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F5SUc5bUlDaDFhVzUwTmpRc2RXbHVkRFkwTENoMWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWMFpqaGJYU2twS1FvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFZ2IyWWdLSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkWFJtT0Z0ZEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UUUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F5SUc5bUlDaDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVjBaamhiWFNrcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0FyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjBaWE4wWDJOaGMyVnpMblIxY0d4bFgzTjFjSEJ2Y25RdWJtVnpkR1ZrWDNSMWNHeGxjeTVRWVhKbGJuUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBQ0NDWUdCQlVmZkhVRFltOTRBM1IzYlJkaWRXbHNaRjl1WlhOMFpXUmZZMkZzYkY5amIzVnVkQU53ZDJ3Q0FBUXhHRUFBSFNzalp5cUFGZ0FFQUFZQUFBQUFBQUFBQUFBQUFBd0FEZ0FBQUFCbk1SdEJBSEV4R1JSRU1SaEVnZzRFT0Q0ZWl3Um95KzNYQkNKai9QRUV2OE56T1FUR1lMNnFCTGJDRmY4RWtIeVFRZ1RWSEhGMEJQak1LMUFFUFVodHNBU2VXanVuQk02Z1Voc0VOejliSkFUc1dUQ1dOaG9Bamc0QXBnRnpBWDRCbmdHNkFjNENBZ0kwQW5RQzNRTjRBKzRFZ0FTMkFERVpGREVZRkJCRGdCSlBjbVJsY2lCcGN5QnBiWEJ2Y25SaGJuU3dNUUNKaWdJQ2dCVkpKMjBnYW5WemRDQmhJSE5wYlhCc1pTQjBkWEN3aS82TC80bUtBUUdBR1VseklIUm9aWEpsSUdGdUlHVmphRzhnYVc0Z2FHVnlaVCt3aS8rSmlnSUFJeVNML2lJU1JJdi9RQUFuaS82TC80RURDNHNBRWtRa2dRV0wvMDJMQVVzQkVrUkxBWXYrQ0JKRUlvRUVpLzlORWtTSmdRT01BSU1DQkFXTUFVTC96allhQVVjQ0ZVbFBBa2tqV1VtQkJCSkVTd0ZNU3dOU1NSVkxBWUVRV1VtQkVoSkVURkpKRlVzQkpWbEpnUXdTUkVzQ1RFc0NVaU5aZ1E0SVN3S0JDbGxKU3dJU1JFOERURThEVWlOWkpBZ0lnUllJU1U0RFN3RWtXVWxQQWhKRVR3SlNTU05aU1U0Q0pBdE1Wd0lBSTBsTEJBeEJBRWhKSkF0TEFrbFBBbGxKVHdWSlRnUVNSRXNCRlZKSkZVc0JKVmxKZ1F3U1JFc0NURXNDVWlOWmdRNElTd0tCQ2xsSlN3SVNSRThEVEU4RFVpTlpKQWdJQ0U0Q0lnaEMvN0ZHQWtVQkpBZ0lFa1FuQkV4bklrTWpKd1JsUkNoTVVMQWlRellhQVVrVmdSQVNSRWxYQUFoTEFTVmJJZ2dwVHdOUVRCWlBBa3hRdnlKRE5ob0JTUldCRUJKRUtVeFF2VVVCZ0FFQUkwOENWQ2hNVUxBaVF6WWFBVWtWZ1JBU1JDbE1VTDVFS0V4UXNDSkROaG9CU1JXQkVCSkVLVXhRdmtsUEFreEJBQmxKSTF0TUpWdE1Ga3dXVUlBQkFDTlBBMVJRS0V4UXNDSkRTSUFBU1VMLzV6WWFBVWtWZ1JBU1JDbE1VSUVFSklqK0RVNENUTDVCQUJWRkFVVUJTU05iVENWYlRCWk1GbEFvVEZDd0lrTklRdi95TmhvQlNTTlpKQWhMQVJVU1JGY0NBSWo5K29qOXY0RUVKSWo5MFU0RFRnSWpUd0pqUVFBVlJRRkZBVWtqVzB3bFcwd1dUQlpRS0V4UXNDSkRTRUwvOGlOSmdRTU1RUUFxU1NVTGdCZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQkFBQUFBQUFBQUFKTUpWaExBUmFvUkNJSVF2L1BnRElWSDN4MUFBUUFIZ0FEQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUFBQUFBQUFBQUNBQUFBQUFBQUFBQUFEQUFPQUFBQUFMQWlReU1xWlVSSkkxbExBU1JaU3dKUEFrc0NVaUlXU3dFaldTSUlGbGNHQUU4Q1RGd0FURkJMQWhWUEEwOERUd0pTU1ZjQUNFc0JKVmxMQW9FS1dVc0RUd0pMQWxKWEFnQkxBeFZQQkU4RFR3SlNWd0lBU3dNVmdRUUlTd0lWRmxjR0FrOERVRThEZ0FJQURGQkxBUldCREFoTEJCVVdWd1lDVHdWUVRCWlhCZ0pQQWt4UVR3SlFURkJNRmxjR0FpY0ZURkJQQWxCTVVDcE1aeUpESWlRZVRCUk1nUU1TU2hCRVRFUkVJa21JL05jaUk0ajgwaU5KSWlRSUNFeU5Bd0JIQUVBQU9DTk1JaVFJQ0V5TkF3QWlBQnNBRXlVS2dRTVNSQ3NpWjRBRkZSOThkWUN3SWtPQkEwd2tTVUwvMmlSTUlrbEMvOU1pVENRaVF2L01nUU5NSkVsQy83VWtUQ0pKUXYrdUlrd2tJa0wvcHpZYUFVa1ZTd0VqV1VtQkJCSkVTd0pMQVVzRFVpTlpnUVlJU3dNa1dVbExBaEpFU3dSTEFVc0ZVa2tWU3dFaldVbUJDaEpFU3dKTVR3SlNTU05aZ1F3SVR3UUlUd1VTUkU0RVRnUlNWd0lBVEZjQ0FFOENWd0lJVndBSVN3RVZGbGNHQWs4Q1VFa1ZnUVFJU3dNVkZsY0dBazhFVUlBQ0FBcFBCRkJNVUV3V1Z3WUNKd1ZNVUU4Q1VFeFFLRXhRc0NKRE5ob0JTUlZMQVNWWlNZRU1Fa1JMQWt4TEFsSWpXWUVPQ0VzQ2dRcFpTVXNDRWtSTEEweExBMUlqV1NRSUNCSkVLRXhRc0NKRE5ob0JTUlZMQVlFUVdVbUJFaEpFU3dKTVN3SlNTUlZMQVNWWlNZRU1Fa1JMQWt4TEFsSWpXWUVPQ0VzQ2dRcFpTVXNDRWtSUEEweFBBMUlqV1NRSUNJRVNDQkpFS0V4UXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
