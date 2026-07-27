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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4BoxContract_5c7efa6d
{


    public class Arc4BoxContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc4BoxContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DynamicArrayInAStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong[] Arr { get; set; }

                public ulong B { get; set; }

                public ulong[] Arr2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr2.From(Arr2);
                    ret.AddRange(vArr2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DynamicArrayInAStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DynamicArrayInAStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr2 = vArr2.ToValue();
                    if (valueArr2 is ulong[] vArr2Value) { ret.Arr2 = vArr2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DynamicArrayInAStruct);
                }
                public bool Equals(DynamicArrayInAStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DynamicArrayInAStruct left, DynamicArrayInAStruct right)
                {
                    return EqualityComparer<DynamicArrayInAStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(DynamicArrayInAStruct left, DynamicArrayInAStruct right)
                {
                    return !(left == right);
                }

            }

            public class LargeStruct : AVMObjectType
            {
                public byte[] A { get; set; }

                public byte[] B { get; set; }

                public byte[] C { get; set; }

                public byte[] D { get; set; }

                public ulong E { get; set; }

                public byte[] F { get; set; }

                public byte[] G { get; set; }

                public ulong H { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vD.From(D);
                    ret.AddRange(vD.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vE.From(E);
                    ret.AddRange(vE.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vF = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vF.From(F);
                    ret.AddRange(vF.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vG = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vG.From(G);
                    ret.AddRange(vG.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vH = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vH.From(H);
                    ret.AddRange(vH.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LargeStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LargeStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is byte[] vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is byte[] vCValue) { ret.C = vCValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vD.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueD = vD.ToValue();
                    if (valueD is byte[] vDValue) { ret.D = vDValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vE.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueE = vE.ToValue();
                    if (valueE is ulong vEValue) { ret.E = vEValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vF = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vF.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueF = vF.ToValue();
                    if (valueF is byte[] vFValue) { ret.F = vFValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vG = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vG.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueG = vG.ToValue();
                    if (valueG is byte[] vGValue) { ret.G = vGValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vH = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vH.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueH = vH.ToValue();
                    if (valueH is ulong vHValue) { ret.H = vHValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LargeStruct);
                }
                public bool Equals(LargeStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LargeStruct left, LargeStruct right)
                {
                    return EqualityComparer<LargeStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(LargeStruct left, LargeStruct right)
                {
                    return !(left == right);
                }

            }

            public class ReadBoxesReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public string Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static ReadBoxesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ReadBoxesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReadBoxesReturn);
                }
                public bool Equals(ReadBoxesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadBoxesReturn left, ReadBoxesReturn right)
                {
                    return EqualityComparer<ReadBoxesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadBoxesReturn left, ReadBoxesReturn right)
                {
                    return !(left == right);
                }

            }

            public class BoxesExistReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

                public bool Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static BoxesExistReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BoxesExistReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BoxesExistReturn);
                }
                public bool Equals(BoxesExistReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BoxesExistReturn left, BoxesExistReturn right)
                {
                    return EqualityComparer<BoxesExistReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(BoxesExistReturn left, BoxesExistReturn right)
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
        /// <param name="c"> </param>
        public async Task SetBoxes(ulong a, byte[] b, string c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 247, 107, 105 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBoxes_Transactions(ulong a, byte[] b, string c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 247, 107, 105 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CheckKeys(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 35, 97, 122 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckKeys_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 35, 97, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateManyInts(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 38, 57, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateManyInts_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 38, 57, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="value"> </param>
        public async Task SetManyInts(ulong index, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 188, 186, 94 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetManyInts_Transactions(ulong index, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 188, 186, 94 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> SumManyInts(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 13, 61, 200 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SumManyInts_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 13, 61, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 3, 155, 67 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 3, 155, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task IndirectExtractAndReplace(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 195, 178, 249 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IndirectExtractAndReplace_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 195, 178, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ReadBoxesReturn> ReadBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 222, 97, 77 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReadBoxesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 222, 97, 77 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.BoxesExistReturn> BoxesExist(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 57, 23, 33 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BoxesExistReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BoxesExist_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 57, 23, 33 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task SliceBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 59, 92, 100 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SliceBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 59, 92, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc4Box(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 166, 38, 254 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc4Box_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 166, 38, 254 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestBoxRef(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 57, 237, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBoxRef_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 57, 237, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateBools(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 178, 226, 65 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateBools_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 178, 226, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="value"> </param>
        public async Task SetBool(ulong index, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 206, 215, 155 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBool_Transactions(ulong index, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 206, 215, 155 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stopAtTotal"> </param>
        public async Task<ulong> SumBools(ulong stopAtTotal, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 119, 244, 150 };
            var stopAtTotalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAtTotalAbi.From(stopAtTotal);

            var result = await base.CallApp(new List<object> { abiHandle, stopAtTotalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SumBools_Transactions(ulong stopAtTotal, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 119, 244, 150 };
            var stopAtTotalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAtTotalAbi.From(stopAtTotal);

            return await base.MakeTransactionList(new List<object> { abiHandle, stopAtTotalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJveENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkR5bmFtaWNBcnJheUluQVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXJyIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcnIyIiwidHlwZSI6InVpbnQ2NFtdIn1dLCJMYXJnZVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImQiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZiIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiZyIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiaCIsInR5cGUiOiJ1aW50NjQifV0sIlJlYWRCb3hlc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkJveGVzRXhpc3RSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrS2V5cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtTWFueUludHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmRpcmVjdEV4dHJhY3RBbmRSZXBsYWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGJ5dGVbXSxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IlJlYWRCb3hlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJveGVzRXhpc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiQm94ZXNFeGlzdFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsaWNlQm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzRCb3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEJveFJlZiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVCb29scyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRCb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtQm9vbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcEF0VG90YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQxMyw0MzgsODU2LDk3Niw5ODUsOTkxLDEzNzRdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0MF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA0LDg0MCw4NzMsOTYxLDk3MSw5OTYsMTM0OSwxMzk3XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNywzNDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzE5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNywzNThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwLDgyMiw4MzEsMTMxMCwxMzU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIwN10sImVycm9yTWVzc2FnZSI6Im5vIGRhdGEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRGdnTWlBME1EazJDaUFnSUNCaWVYUmxZMkpzYjJOcklDSkNUMWhmUXlJZ0ltSnNiMklpSUNKaWIzaE1ZWEpuWlNJZ0ltSnZlRUVpSUNKaWIzaEVJaUFpWWlJZ0luUnZiMDFoYm5sQ2IyOXNjeUlnTUhnd01EQXhNREl3TXlBaWJXRnVlVWx1ZEhNaUlEQjRNVFV4Wmpkak56VWdJakFpSURCNE1EWTRNVEF4SURCNE1EQXdNak0wTXpJZ0lqUXlJaUFpYUdWc2JHOGlJQ0ppYjNoU1pXWWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOREFLSUNBZ0lDOHZJR05zWVhOeklFRnlZelJDYjNoRGIyNTBjbUZqZENCbGVIUmxibVJ6SUdGeVl6UXVRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURJMENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneU4yWTNObUkyT1NBd2VEa3hNak0yTVRkaElEQjRaamN5TmpNNU5EZ2dNSGd3T1dKalltRTFaU0F3ZURkaE1HUXpaR000SURCNE4yUXdNemxpTkRNZ01IZ3pZbU16WWpKbU9TQXdlR1JqWkdVMk1UUmtJREI0WlRFek9URTNNakVnTUhnMk9ETmlOV00yTkNBd2VHRTFZVFl5Tm1abElEQjRPVEF6T1dWa1pHVWdNSGd5T0dJeVpUSTBNU0F3ZURoa1kyVmtOemxpSURCNE1XTTNOMlkwT1RZZ0x5OGdiV1YwYUc5a0lDSnpaWFJDYjNobGN5aDFhVzUwTmpRc1lubDBaVnRkTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSmphR1ZqYTB0bGVYTW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTnlaV0YwWlUxaGJubEpiblJ6S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSTllXNTVTVzUwY3loMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTjFiVTFoYm5sSmJuUnpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbVJsYkdWMFpVSnZlR1Z6S0NsMmIybGtJaXdnYldWMGFHOWtJQ0pwYm1ScGNtVmpkRVY0ZEhKaFkzUkJibVJTWlhCc1lXTmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV0ZrUW05NFpYTW9LU2gxYVc1ME5qUXNZbmwwWlZ0ZExITjBjbWx1Wnl4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKaWIzaGxjMFY0YVhOMEtDa29ZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ2tpTENCdFpYUm9iMlFnSW5Oc2FXTmxRbTk0S0NsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NMFFtOTRLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wUW05NFVtVm1LQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpjbVZoZEdWQ2IyOXNjeWdwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwUW05dmJDaDFhVzUwTmpRc1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpkVzFDYjI5c2N5aDFhVzUwTmpRcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2MyVjBRbTk0WlhNZ2JXRnBibDlqYUdWamEwdGxlWE5mY205MWRHVkFOeUJ0WVdsdVgyTnlaV0YwWlUxaGJubEpiblJ6WDNKdmRYUmxRRGdnYzJWMFRXRnVlVWx1ZEhNZ2MzVnRUV0Z1ZVVsdWRITWdaR1ZzWlhSbFFtOTRaWE1nYVc1a2FYSmxZM1JGZUhSeVlXTjBRVzVrVW1Wd2JHRmpaU0J5WldGa1FtOTRaWE1nWW05NFpYTkZlR2x6ZENCemJHbGpaVUp2ZUNCaGNtTTBRbTk0SUhSbGMzUkNiM2hTWldZZ2JXRnBibDlqY21WaGRHVkNiMjlzYzE5eWIzVjBaVUF4T0NCelpYUkNiMjlzSUhOMWJVSnZiMnh6Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFFtOXZiSE5mY205MWRHVkFNVGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TlRJS0lDQWdJQzh2SUhSdmIwMWhibmxDYjI5c2N5QTlJRUp2ZUR4R2FYaGxaRUZ5Y21GNVBHSnZiMnhsWVc0c0lETXpYekF3TUQ0K0tIc2dhMlY1T2lBbmRHOXZUV0Z1ZVVKdmIyeHpKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZEc5dlRXRnVlVUp2YjJ4eklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5UQXpDaUFnSUNBdkx5QjBhR2x6TG5SdmIwMWhibmxDYjI5c2N5NWpjbVZoZEdVb0tRb2dJQ0FnY0hWemFHbHVkQ0EwTVRJMUNpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV3TWdvZ0lDQWdMeThnWTNKbFlYUmxRbTl2YkhNb0tTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlUxaGJubEpiblJ6WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRnS0lDQWdJQzh2SUcxaGJubEpiblJ6SUQwZ1FtOTRQRTFoYm5sSmJuUnpQaWg3SUd0bGVUb2dKMjFoYm5sSmJuUnpKeUI5S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYldGdWVVbHVkSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTURJS0lDQWdJQzh2SUhSb2FYTXViV0Z1ZVVsdWRITXVZM0psWVhSbEtDa0tJQ0FnSUhCMWMyaHBiblFnTkRFd05Bb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTURFS0lDQWdJQzh2SUdOeVpXRjBaVTFoYm5sSmJuUnpLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqYUdWamEwdGxlWE5mY205MWRHVkFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak01TkFvZ0lDQWdMeThnWTJobFkydExaWGx6S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTWpRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EQUtJQ0FnSUM4dklHTnNZWE56SUVGeVl6UkNiM2hEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJR0Z5WXpRdVEyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCZmNIVjVZVjlzYVdJdWRYUnBiQzVsYm5OMWNtVmZZblZrWjJWMEtISmxjWFZwY21Wa1gySjFaR2RsZERvZ2RXbHVkRFkwTENCbVpXVmZjMjkxY21ObE9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtVnVjM1Z5WlY5aWRXUm5aWFE2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdLd29LWlc1emRYSmxYMkoxWkdkbGRGOTNhR2xzWlY5MGIzQkFNVG9LSUNBZ0lHUjFjQW9nSUNBZ1oyeHZZbUZzSUU5d1kyOWtaVUoxWkdkbGRBb2dJQ0FnUGdvZ0lDQWdZbm9nWlc1emRYSmxYMkoxWkdkbGRGOWhablJsY2w5M2FHbHNaVUEyQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TmpneE1ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZDJsMFkyZ2daVzV6ZFhKbFgySjFaR2RsZEY5emQybDBZMmhmWTJGelpWOHdRRE1nWlc1emRYSmxYMkoxWkdkbGRGOXpkMmwwWTJoZlkyRnpaVjh4UURRS0NtVnVjM1Z5WlY5aWRXUm5aWFJmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUExT2dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHSWdaVzV6ZFhKbFgySjFaR2RsZEY5M2FHbHNaVjkwYjNCQU1Rb0taVzV6ZFhKbFgySjFaR2RsZEY5emQybDBZMmhmWTJGelpWOHhRRFE2Q2lBZ0lDQm5iRzlpWVd3Z1RXbHVWSGh1Um1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWWlCbGJuTjFjbVZmWW5Wa1oyVjBYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOUW9LWlc1emRYSmxYMkoxWkdkbGRGOXpkMmwwWTJoZlkyRnpaVjh3UURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR0lnWlc1emRYSmxYMkoxWkdkbGRGOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEVUtDbVZ1YzNWeVpWOWlkV1JuWlhSZllXWjBaWEpmZDJocGJHVkFOam9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPanBCY21NMFFtOTRRMjl1ZEhKaFkzUXVjMlYwUW05NFpYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSQ2IzaGxjem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0xT1FvZ0lDQWdMeThnYzJWMFFtOTRaWE1vWVRvZ2RXbHVkRFkwTENCaU9pQmllWFJsY3l3Z1l6b2dZWEpqTkM1VGRISXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5qRUtJQ0FnSUM4dklIUm9hWE11WW05NFFTNTJZV3gxWlNBOUlHRUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReENpQWdJQ0F2THlCaWIzaEJJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEJKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFFTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTJNUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaEJMblpoYkhWbElEMGdZUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReUNpQWdJQ0F2THlCaWIzaENJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpZeUNpQWdJQ0F2THlCMGFHbHpMbUp2ZUVJdWRtRnNkV1VnUFNCa2VXNWhiV2xqUW5sMFpYTUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF5Q2lBZ0lDQXZMeUJpYjNoQ0lEMGdRbTk0UEdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6UGloN0lHdGxlVG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNell5Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRUl1ZG1Gc2RXVWdQU0JrZVc1aGJXbGpRbmwwWlhNS0lDQWdJR1JwWnlBMUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJR0p2ZUVNZ1BTQkNiM2c4WVhKak5DNVRkSEkrS0hzZ2EyVjVPaUFuUWs5WVgwTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pDVDFoZlF5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTJNd29nSUNBZ0x5OGdkR2hwY3k1aWIzaERMblpoYkhWbElEMGdZd29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTXdvZ0lDQWdMeThnZEdocGN5NWliM2hETG5aaGJIVmxJRDBnWXdvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdZbTk0UkNBOUlFSnZlRHhpZVhSbGN6NG9leUJyWlhrNklDZGliM2hFSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVltOTRSQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTkFvZ0lDQWdMeThnZEdocGN5NWliM2hFTG5aaGJIVmxJRDBnWkhsdVlXMXBZMEo1ZEdWekxtNWhkR2wyWlFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EUUtJQ0FnSUM4dklHSnZlRVFnUFNCQ2IzZzhZbmwwWlhNK0tIc2dhMlY1T2lBblltOTRSQ2NnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1KdmVFUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOalFLSUNBZ0lDOHZJSFJvYVhNdVltOTRSQzUyWVd4MVpTQTlJR1I1Ym1GdGFXTkNlWFJsY3k1dVlYUnBkbVVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EY0tJQ0FnSUM4dklHSnZlRXhoY21kbElEMGdRbTk0UEV4aGNtZGxVM1J5ZFdOMFBpaDdJR3RsZVRvZ0oySnZlRXhoY21kbEp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZbTk0VEdGeVoyVWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOalVLSUNBZ0lDOHZJSFJvYVhNdVltOTRUR0Z5WjJVdVkzSmxZWFJsS0NrS0lDQWdJSEIxYzJocGJuUWdOakUyTUFvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOallLSUNBZ0lDOHZJSFJvYVhNdVltOTRUR0Z5WjJVdWRtRnNkV1V1WlNBOUlEUXlDaUFnSUNCd2RYTm9hVzUwSURReUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EY0tJQ0FnSUM4dklHSnZlRXhoY21kbElEMGdRbTk0UEV4aGNtZGxVM1J5ZFdOMFBpaDdJR3RsZVRvZ0oySnZlRXhoY21kbEp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZbTk0VEdGeVoyVWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOallLSUNBZ0lDOHZJSFJvYVhNdVltOTRUR0Z5WjJVdWRtRnNkV1V1WlNBOUlEUXlDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EY0tJQ0FnSUM4dklHSnZlRXhoY21kbElEMGdRbTk0UEV4aGNtZGxVM1J5ZFdOMFBpaDdJR3RsZVRvZ0oySnZlRXhoY21kbEp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZbTk0VEdGeVoyVWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOamNLSUNBZ0lDOHZJSFJvYVhNdVltOTRUR0Z5WjJVdWNtVndiR0ZqWlNoaGNtTTBMbk5wZW1WUFpqeENlWFJsY3pFd01qUStLQ2tnS2lBMExDQnVaWGNnWVhKak5DNVZhVzUwTmpRb05ESXBMbUo1ZEdWektRb2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTVFvZ0lDQWdMeThnWW05NFFTQTlJRUp2ZUR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW05NFFTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2ZUVFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek56RUtJQ0FnSUM4dklIUm9hWE11WW05NFFTNTJZV3gxWlNBclBTQXpDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRFS0lDQWdJQzh2SUdKdmVFRWdQU0JDYjNnOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJKdmVFRW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ppYjNoQklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16Y3hDaUFnSUNBdkx5QjBhR2x6TG1KdmVFRXVkbUZzZFdVZ0t6MGdNd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReENpQWdJQ0F2THlCaWIzaEJJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEJKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFFTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTNOQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFFTNXNaVzVuZEdnZ1BUMDlJRGdwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRJS0lDQWdJQzh2SUdKdmVFSWdQU0JDYjNnOFlYSmpOQzVFZVc1aGJXbGpRbmwwWlhNK0tIc2dhMlY1T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TnpVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRUl1YkdWdVozUm9JRDA5UFNCa2VXNWhiV2xqUW5sMFpYTXVZbmwwWlhNdWJHVnVaM1JvS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemMyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaERMbXhsYm1kMGFDQTlQVDBnWXk1aWVYUmxjeTVzWlc1bmRHZ3BDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEwQ2lBZ0lDQXZMeUJpYjNoRUlEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dKMkp2ZUVRbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmliM2hFSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpjM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hFTG14bGJtZDBhQ0E5UFQwZ1pIbHVZVzFwWTBKNWRHVnpMbTVoZEdsMlpTNXNaVzVuZEdncENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCd2IzQUtJQ0FnSUdScFp5QTBDaUFnSUNCc1pXNEtJQ0FnSUdSMWNESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNd29nSUNBZ0x5OGdZbTk0UXlBOUlFSnZlRHhoY21NMExsTjBjajRvZXlCclpYazZJQ2RDVDFoZlF5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0pQV0Y5RElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16Z3dDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoRExuWmhiSFZsTG1KNWRHVnpMbUYwS0RBcElEMDlQU0JqTG1KNWRHVnpMbUYwS0RBcEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHVjRkSEpoWTNRZ01DQXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pPREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFTXVkbUZzZFdVdVlubDBaWE11WVhRb0xURXBJRDA5UFNCakxtSjVkR1Z6TG1GMEtDMHhLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXpDaUFnSUNBdkx5QmliM2hESUQwZ1FtOTRQR0Z5WXpRdVUzUnlQaWg3SUd0bGVUb2dKMEpQV0Y5REp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlRazlZWDBNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek9ERUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUVNdWRtRnNkV1V1WW5sMFpYTXVZWFFvTFRFcElEMDlQU0JqTG1KNWRHVnpMbUYwS0MweEtTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2FXY2dOZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRU11ZG1Gc2RXVXVZbmwwWlhNdWMyeHBZMlVvTUN3Z0xURXBJRDA5UFNCakxtSjVkR1Z6TG5Oc2FXTmxLREFzSUMweEtTa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCa2FXY2dOQW9nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JrYVdjZ05Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF6Q2lBZ0lDQXZMeUJpYjNoRElEMGdRbTk0UEdGeVl6UXVVM1J5UGloN0lHdGxlVG9nSjBKUFdGOURKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpUWs5WVgwTWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pPRElLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFTXVkbUZzZFdVdVlubDBaWE11YzJ4cFkyVW9NQ3dnTFRFcElEMDlQU0JqTG1KNWRHVnpMbk5zYVdObEtEQXNJQzB4S1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkdsbklEWUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaR2xuSURjS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1pHbG5JRGNLSUNBZ0lENDlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklEZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ053b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURnS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpnekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hETG5aaGJIVmxMbUo1ZEdWekxuTnNhV05sS0RBc0lESXBJRDA5UFNCakxtSjVkR1Z6TG5Oc2FXTmxLREFzSURJcEtRb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR1JwWnlBMUNpQWdJQ0ErUFFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBeUNpQWdJQ0F0Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRReTUyWVd4MVpTNWllWFJsY3k1emJHbGpaU2d3TENBeUtTQTlQVDBnWXk1aWVYUmxjeTV6YkdsalpTZ3dMQ0F5S1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHUnBaeUExQ2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME5Bb2dJQ0FnTHk4Z1ltOTRSQ0E5SUVKdmVEeGllWFJsY3o0b2V5QnJaWGs2SUNkaWIzaEVKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWW05NFJDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTROZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFJDNTJZV3gxWlM1aGRDZ3dLU0E5UFQwZ1pIbHVZVzFwWTBKNWRHVnpMbTVoZEdsMlpTNWhkQ2d3S1NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaWGgwY21GamRDQXlJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00TndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRSQzUyWVd4MVpTNWhkQ2d0TVNrZ1BUMDlJR1I1Ym1GdGFXTkNlWFJsY3k1dVlYUnBkbVV1WVhRb0xURXBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EUUtJQ0FnSUM4dklHSnZlRVFnUFNCQ2IzZzhZbmwwWlhNK0tIc2dhMlY1T2lBblltOTRSQ2NnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1KdmVFUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pPRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFUXVkbUZzZFdVdVlYUW9MVEVwSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbUYwS0MweEtTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRVF1ZG1Gc2RXVXVjMnhwWTJVb01Dd2dMVEVwSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbk5zYVdObEtEQXNJQzB4S1NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2FXY2dNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JrYVdjZ013b2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTBDaUFnSUNBdkx5QmliM2hFSUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0oySnZlRVFuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaWIzaEVJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemc0Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEVMblpoYkhWbExuTnNhV05sS0RBc0lDMHhLU0E5UFQwZ1pIbHVZVzFwWTBKNWRHVnpMbTVoZEdsMlpTNXpiR2xqWlNnd0xDQXRNU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1JwWnlBekNpQWdJQ0ErUFFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdScFp5QTBDaUFnSUNBK1BRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1JwWnlBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00T1FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRSQzUyWVd4MVpTNXpiR2xqWlNnd0xDQTFLU0E5UFQwZ1pIbHVZVzFwWTBKNWRHVnpMbTVoZEdsMlpTNXpiR2xqWlNnd0xDQTFLU2tLSUNBZ0lIQjFjMmhwYm5RZ05Rb2dJQ0FnWkdsbklEUUtJQ0FnSUQ0OUNpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lHUnBaeUExQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JRElLSUNBZ0lDMEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdZbTk0UkNBOUlFSnZlRHhpZVhSbGN6NG9leUJyWlhrNklDZGliM2hFSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVltOTRSQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00T1FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRSQzUyWVd4MVpTNXpiR2xqWlNnd0xDQTFLU0E5UFQwZ1pIbHVZVzFwWTBKNWRHVnpMbTVoZEdsMlpTNXpiR2xqWlNnd0xDQTFLU2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQStQUW9nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBMkNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFUXVkbUZzZFdVdWMyeHBZMlVvTUN3Z1ZXbHVkRFkwS0RJcEtTQTlQVDBnWkhsdVlXMXBZMEo1ZEdWekxtNWhkR2wyWlM1emJHbGpaU2d3TENCVmFXNTBOalFvTWlrcEtRb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR1JwWnlBMENpQWdJQ0ErUFFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBeUNpQWdJQ0F0Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRRS0lDQWdJQzh2SUdKdmVFUWdQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUFuWW05NFJDY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUp2ZUVRaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek9UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUVRdWRtRnNkV1V1YzJ4cFkyVW9NQ3dnVldsdWREWTBLRElwS1NBOVBUMGdaSGx1WVcxcFkwSjVkR1Z6TG01aGRHbDJaUzV6YkdsalpTZ3dMQ0JWYVc1ME5qUW9NaWtwS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1pHbG5JRE1LSUNBZ0lENDlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRM0NpQWdJQ0F2THlCaWIzaE1ZWEpuWlNBOUlFSnZlRHhNWVhKblpWTjBjblZqZEQ0b2V5QnJaWGs2SUNkaWIzaE1ZWEpuWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSnZlRXhoY21kbElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16a3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoTVlYSm5aUzVzWlc1bmRHZ2dQVDA5SUdGeVl6UXVjMmw2WlU5bVBFeGhjbWRsVTNSeWRXTjBQaWdwS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0J3ZFhOb2FXNTBJRFl4TmpBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMU9Rb2dJQ0FnTHk4Z2MyVjBRbTk0WlhNb1lUb2dkV2x1ZERZMExDQmlPaUJpZVhSbGN5d2dZem9nWVhKak5DNVRkSElwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem82UVhKak5FSnZlRU52Ym5SeVlXTjBMbk5sZEUxaGJubEpiblJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBUV0Z1ZVVsdWRITTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNRFVLSUNBZ0lDOHZJSE5sZEUxaGJubEpiblJ6S0dsdVpHVjRPaUIxYVc1ME5qUXNJSFpoYkhWbE9pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRd05nb2dJQ0FnTHk4Z2RHaHBjeTV0WVc1NVNXNTBjeTUyWVd4MVpWdHBibVJsZUYwZ1BTQjJZV3gxWlFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBPQW9nSUNBZ0x5OGdiV0Z1ZVVsdWRITWdQU0JDYjNnOFRXRnVlVWx1ZEhNK0tIc2dhMlY1T2lBbmJXRnVlVWx1ZEhNbklIMHBDaUFnSUNCaWVYUmxZeUE0SUM4dklDSnRZVzU1U1c1MGN5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXdOZ29nSUNBZ0x5OGdkR2hwY3k1dFlXNTVTVzUwY3k1MllXeDFaVnRwYm1SbGVGMGdQU0IyWVd4MVpRb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EQTFDaUFnSUNBdkx5QnpaWFJOWVc1NVNXNTBjeWhwYm1SbGVEb2dkV2x1ZERZMExDQjJZV3gxWlRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02T2tGeVl6UkNiM2hEYjI1MGNtRmpkQzV6ZFcxTllXNTVTVzUwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFiVTFoYm5sSmJuUnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREV3Q2lBZ0lDQXZMeUJsYm5OMWNtVkNkV1JuWlhRb01UQmZOVEF3S1FvZ0lDQWdjSFZ6YUdsdWRDQXhNRFV3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pXNXpkWEpsWDJKMVpHZGxkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREV4Q2lBZ0lDQXZMeUJzWlhRZ2RHOTBZV3dnUFNCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRnS0lDQWdJQzh2SUcxaGJubEpiblJ6SUQwZ1FtOTRQRTFoYm5sSmJuUnpQaWg3SUd0bGVUb2dKMjFoYm5sSmJuUnpKeUI5S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYldGdWVVbHVkSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTVRJS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2RtRnNJRzltSUhSb2FYTXViV0Z1ZVVsdWRITXVkbUZzZFdVcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3B6ZFcxTllXNTVTVzUwYzE5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNVElLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZG1Gc0lHOW1JSFJvYVhNdWJXRnVlVWx1ZEhNdWRtRnNkV1VwSUhzS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFNVE1LSUNBZ0lEd0tJQ0FnSUdKNklITjFiVTFoYm5sSmJuUnpYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EZ0tJQ0FnSUM4dklHMWhibmxKYm5SeklEMGdRbTk0UEUxaGJubEpiblJ6UGloN0lHdGxlVG9nSjIxaGJubEpiblJ6SnlCOUtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWJXRnVlVWx1ZEhNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1USUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdkbUZzSUc5bUlIUm9hWE11YldGdWVVbHVkSE11ZG1Gc2RXVXBJSHNLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRFekNpQWdJQ0F2THlCMGIzUmhiQ0E5SUhSdmRHRnNJQ3NnZG1Gc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJSE4xYlUxaGJubEpiblJ6WDJadmNsOW9aV0ZrWlhKQU1nb0tjM1Z0VFdGdWVVbHVkSE5mWVdaMFpYSmZabTl5UURVNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRd09Rb2dJQ0FnTHk4Z2MzVnRUV0Z1ZVVsdWRITW9LU0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBNUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZPa0Z5WXpSQ2IzaERiMjUwY21GamRDNWtaV3hsZEdWQ2IzaGxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGJHVjBaVUp2ZUdWek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXhDaUFnSUNBdkx5QmliM2hCSUQwZ1FtOTRQSFZwYm5RMk5ENG9leUJyWlhrNklDZGliM2hCSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVltOTRRU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF4T1FvZ0lDQWdMeThnZEdocGN5NWliM2hCTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1nb2dJQ0FnTHk4Z1ltOTRRaUE5SUVKdmVEeGhjbU0wTGtSNWJtRnRhV05DZVhSbGN6NG9leUJyWlhrNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pReU1Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoQ0xtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNd29nSUNBZ0x5OGdZbTk0UXlBOUlFSnZlRHhoY21NMExsTjBjajRvZXlCclpYazZJQ2RDVDFoZlF5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0pQV0Y5RElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ESXhDaUFnSUNBdkx5QjBhR2x6TG1KdmVFTXVaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF4Q2lBZ0lDQXZMeUJpYjNoQklEMGdRbTk0UEhWcGJuUTJORDRvZXlCclpYazZJQ2RpYjNoQkp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZbTk0UVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pReU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UVM1blpYUW9leUJrWldaaGRXeDBPaUJWYVc1ME5qUW9ORElwSUgwcElEMDlQU0EwTWlrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTkRJS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ013b2dJQ0FnYzJWc1pXTjBDaUFnSUNCd2RYTm9hVzUwSURReUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ESUtJQ0FnSUM4dklHSnZlRUlnUFNCQ2IzZzhZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5ZaWNnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1JaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1qTUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUVJdVoyVjBLSHNnWkdWbVlYVnNkRG9nYm1WM0lHRnlZelF1UkhsdVlXMXBZMEo1ZEdWektFSjVkR1Z6S0NjME1pY3BLU0I5S1M1dVlYUnBkbVVnUFQwOUlFSjVkR1Z6S0NjME1pY3BLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd01EQXlNelF6TWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0lqUXlJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF6Q2lBZ0lDQXZMeUJpYjNoRElEMGdRbTk0UEdGeVl6UXVVM1J5UGloN0lHdGxlVG9nSjBKUFdGOURKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpUWs5WVgwTWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFTXVaMlYwS0hzZ1pHVm1ZWFZzZERvZ2JtVjNJR0Z5WXpRdVUzUnlLQ2MwTWljcElIMHBMbTVoZEdsMlpTQTlQVDBnSnpReUp5a0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURBd01qTTBNeklLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNJME1pSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXlOd29nSUNBZ0x5OGdZWE56WlhKMEtDRmhSWGhwYzNSektRb2dJQ0FnYzNkaGNBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoaElEMDlQU0F3S1FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRjS0lDQWdJQzh2SUdKdmVFeGhjbWRsSUQwZ1FtOTRQRXhoY21kbFUzUnlkV04wUGloN0lHdGxlVG9nSjJKdmVFeGhjbWRsSnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVltOTRUR0Z5WjJVaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1qa0tJQ0FnSUM4dklIUm9hWE11WW05NFRHRnlaMlV1WkdWc1pYUmxLQ2tLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRFNENpQWdJQ0F2THlCa1pXeGxkR1ZDYjNobGN5Z3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzZRWEpqTkVKdmVFTnZiblJ5WVdOMExtbHVaR2x5WldOMFJYaDBjbUZqZEVGdVpGSmxjR3hoWTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibVJwY21WamRFVjRkSEpoWTNSQmJtUlNaWEJzWVdObE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTNDaUFnSUNBdkx5QmliM2hNWVhKblpTQTlJRUp2ZUR4TVlYSm5aVk4wY25WamRENG9leUJyWlhrNklDZGliM2hNWVhKblpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUV4aGNtZGxJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE15TFRRek13b2dJQ0FnTHk4Z1kyOXVjM1FnYkdGeVoyVWdQU0JqYkc5dVpTaDBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxLUW9nSUNBZ0x5OGdiR0Z5WjJVdVpTQXJQU0F4Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREE1TmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME16TUtJQ0FnSUM4dklHeGhjbWRsTG1VZ0t6MGdNUW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME53b2dJQ0FnTHk4Z1ltOTRUR0Z5WjJVZ1BTQkNiM2c4VEdGeVoyVlRkSEoxWTNRK0tIc2dhMlY1T2lBblltOTRUR0Z5WjJVbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmliM2hNWVhKblpTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXpNeTAwTXpRS0lDQWdJQzh2SUd4aGNtZGxMbVVnS3owZ01Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTVlYSm5aUzUyWVd4MVpTQTlJR05zYjI1bEtHeGhjbWRsS1FvZ0lDQWdhVzUwWXlBMElDOHZJRFF3T1RZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRek1Rb2dJQ0FnTHk4Z2FXNWthWEpsWTNSRmVIUnlZV04wUVc1a1VtVndiR0ZqWlNncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvNlFYSmpORUp2ZUVOdmJuUnlZV04wTG5KbFlXUkNiM2hsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZV1JDYjNobGN6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNUW9nSUNBZ0x5OGdZbTk0UVNBOUlFSnZlRHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZbTk0UVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSnZlRUVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8xTWpZS0lDQWdJQzh2SUhKbGRIVnliaUJWYVc1ME5qUW9ZbTk0TG5aaGJIVmxJQ3NnTVNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMVZwYm5RMk5DaG5aWFJDYjNoV1lXeDFaVkJzZFhNeEtIUm9hWE11WW05NFFTa2dMU0F4S1N3Z2RHaHBjeTVpYjNoQ0xuWmhiSFZsTG01aGRHbDJaU3dnZEdocGN5NWliM2hETG5aaGJIVmxMQ0IwYUdsekxtSnZlRXhoY21kbExuWmhiSFZsTG1WZElHRnpJR052Ym5OMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF5Q2lBZ0lDQXZMeUJpYjNoQ0lEMGdRbTk0UEdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6UGloN0lHdGxlVG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMVZwYm5RMk5DaG5aWFJDYjNoV1lXeDFaVkJzZFhNeEtIUm9hWE11WW05NFFTa2dMU0F4S1N3Z2RHaHBjeTVpYjNoQ0xuWmhiSFZsTG01aGRHbDJaU3dnZEdocGN5NWliM2hETG5aaGJIVmxMQ0IwYUdsekxtSnZlRXhoY21kbExuWmhiSFZsTG1WZElHRnpJR052Ym5OMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME13b2dJQ0FnTHk4Z1ltOTRReUE5SUVKdmVEeGhjbU0wTGxOMGNqNG9leUJyWlhrNklDZENUMWhmUXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrSlBXRjlESWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRNNENpQWdJQ0F2THlCeVpYUjFjbTRnVzFWcGJuUTJOQ2huWlhSQ2IzaFdZV3gxWlZCc2RYTXhLSFJvYVhNdVltOTRRU2tnTFNBeEtTd2dkR2hwY3k1aWIzaENMblpoYkhWbExtNWhkR2wyWlN3Z2RHaHBjeTVpYjNoRExuWmhiSFZsTENCMGFHbHpMbUp2ZUV4aGNtZGxMblpoYkhWbExtVmRJR0Z6SUdOdmJuTjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEzQ2lBZ0lDQXZMeUJpYjNoTVlYSm5aU0E5SUVKdmVEeE1ZWEpuWlZOMGNuVmpkRDRvZXlCclpYazZJQ2RpYjNoTVlYSm5aU2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVFeGhjbWRsSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRNNENpQWdJQ0F2THlCeVpYUjFjbTRnVzFWcGJuUTJOQ2huWlhSQ2IzaFdZV3gxWlZCc2RYTXhLSFJvYVhNdVltOTRRU2tnTFNBeEtTd2dkR2hwY3k1aWIzaENMblpoYkhWbExtNWhkR2wyWlN3Z2RHaHBjeTVpYjNoRExuWmhiSFZsTENCMGFHbHpMbUp2ZUV4aGNtZGxMblpoYkhWbExtVmRJR0Z6SUdOdmJuTjBDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTXpjS0lDQWdJQzh2SUhKbFlXUkNiM2hsY3lncE9pQnlaV0ZrYjI1c2VTQmJkV2x1ZERZMExDQmllWFJsY3l3Z1lYSmpOQzVUZEhJc0lIVnBiblEyTkYwZ2V3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlNQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk9rRnlZelJDYjNoRGIyNTBjbUZqZEM1aWIzaGxjMFY0YVhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTk0WlhORmVHbHpkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTVFvZ0lDQWdMeThnWW05NFFTQTlJRUp2ZUR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW05NFFTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2ZUVFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCYmRHaHBjeTVpYjNoQkxtVjRhWE4wY3l3Z2RHaHBjeTVpYjNoQ0xtVjRhWE4wY3l3Z2RHaHBjeTVpYjNoRExtVjRhWE4wY3l3Z2RHaHBjeTVpYjNoTVlYSm5aUzVsZUdsemRITmRJR0Z6SUdOdmJuTjBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1nb2dJQ0FnTHk4Z1ltOTRRaUE5SUVKdmVEeGhjbU0wTGtSNWJtRnRhV05DZVhSbGN6NG9leUJyWlhrNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0MGFHbHpMbUp2ZUVFdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVJdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVNdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUV4aGNtZGxMbVY0YVhOMGMxMGdZWE1nWTI5dWMzUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRekNpQWdJQ0F2THlCaWIzaERJRDBnUW05NFBHRnlZelF1VTNSeVBpaDdJR3RsZVRvZ0owSlBXRjlESnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVFrOVlYME1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTkRJS0lDQWdJQzh2SUhKbGRIVnliaUJiZEdocGN5NWliM2hCTG1WNGFYTjBjeXdnZEdocGN5NWliM2hDTG1WNGFYTjBjeXdnZEdocGN5NWliM2hETG1WNGFYTjBjeXdnZEdocGN5NWliM2hNWVhKblpTNWxlR2x6ZEhOZElHRnpJR052Ym5OMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTndvZ0lDQWdMeThnWW05NFRHRnlaMlVnUFNCQ2IzZzhUR0Z5WjJWVGRISjFZM1ErS0hzZ2EyVjVPaUFuWW05NFRHRnlaMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaE1ZWEpuWlNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0MGFHbHpMbUp2ZUVFdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVJdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVNdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUV4aGNtZGxMbVY0YVhOMGMxMGdZWE1nWTI5dWMzUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRReENpQWdJQ0F2THlCaWIzaGxjMFY0YVhOMEtDazZJSEpsWVdSdmJteDVJRnRpYjI5c1pXRnVMQ0JpYjI5c1pXRnVMQ0JpYjI5c1pXRnVMQ0JpYjI5c1pXRnVYU0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPanBCY21NMFFtOTRRMjl1ZEhKaFkzUXVjMnhwWTJWQ2IzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6YkdsalpVSnZlRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEwTndvZ0lDQWdMeThnWW05NE1DNTJZV3gxWlNBOUlFSjVkR1Z6S0NkVVpYTjBhVzVuSUhSbGMzUnBibWNnTVRJekp5a0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSXdJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpTUNJS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkdWemRHbHVaeUIwWlhOMGFXNW5JREV5TXlJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTBPQW9nSUNBZ0x5OGdZWE56WlhKMEtHSnZlREF1ZG1Gc2RXVXVjMnhwWTJVb01Dd2dOeWtnUFQwOUlFSjVkR1Z6S0NkVVpYTjBhVzVuSnlrcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaU1DSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUmxjM1JwYm1jaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHSnZlRU1nUFNCQ2IzZzhZWEpqTkM1VGRISStLSHNnYTJWNU9pQW5RazlZWDBNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkNUMWhmUXlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMU1Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoRExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVUzUnlLQ2RJWld4c2J5Y3BDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFV3Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRU11ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVUZEhJb0owaGxiR3h2SnlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EVTBPRFkxTm1NMll6Wm1DaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalExTVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRReTUyWVd4MVpTNWllWFJsY3k1emJHbGpaU2d5TENBeE1Da2dQVDA5SUVKNWRHVnpLQ2RJWld4c2J5Y3BLUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTR1ZzYkc4aUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5EVUtJQ0FnSUM4dklITnNhV05sUW05NEtDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qcEJjbU0wUW05NFEyOXVkSEpoWTNRdVlYSmpORUp2ZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRnlZelJDYjNnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5UWUtJQ0FnSUM4dklHSnZlRVF1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVNodVpYY2dZWEpqTkM1VmFXNTBPQ2d3S1N3Z2JtVjNJR0Z5WXpRdVZXbHVkRGdvTVNrc0lHNWxkeUJoY21NMExsVnBiblE0S0RJcExDQnVaWGNnWVhKak5DNVZhVzUwT0NnektTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVpDSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNREF4TURJd013b2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3TURFd01qQXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaGliM2hFTG5aaGJIVmxXekJkTG1GelZXbHVkRFkwS0NrZ1BUMDlJREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTlRZS0lDQWdJQzh2SUdKdmVFUXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVRkR0YwYVdOQmNuSmhlU2h1WlhjZ1lYSmpOQzVWYVc1ME9DZ3dLU3dnYm1WM0lHRnlZelF1VldsdWREZ29NU2tzSUc1bGR5QmhjbU0wTGxWcGJuUTRLRElwTENCdVpYY2dZWEpqTkM1VmFXNTBPQ2d6S1NrS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXhNREl3TXdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRVNENpQWdJQ0F2THlCaGMzTmxjblFvWW05NFJDNTJZV3gxWlZzeFhTNWhjMVZwYm5RMk5DZ3BJRDA5UFNBeEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5UWUtJQ0FnSUM4dklHSnZlRVF1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVNodVpYY2dZWEpqTkM1VmFXNTBPQ2d3S1N3Z2JtVjNJR0Z5WXpRdVZXbHVkRGdvTVNrc0lHNWxkeUJoY21NMExsVnBiblE0S0RJcExDQnVaWGNnWVhKak5DNVZhVzUwT0NnektTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNREF4TURJd013b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EVTVDaUFnSUNBdkx5QmhjM05sY25Rb1ltOTRSQzUyWVd4MVpWc3lYUzVoYzFWcGJuUTJOQ2dwSUQwOVBTQXlLUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUdkbGRHSjVkR1VLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBOVFlLSUNBZ0lDOHZJR0p2ZUVRdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VGRHRjBhV05CY25KaGVTaHVaWGNnWVhKak5DNVZhVzUwT0Nnd0tTd2dibVYzSUdGeVl6UXVWV2x1ZERnb01Ta3NJRzVsZHlCaGNtTTBMbFZwYm5RNEtESXBMQ0J1WlhjZ1lYSmpOQzVWYVc1ME9DZ3pLU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TURBeE1ESXdNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFl3Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZbTk0UkM1MllXeDFaVnN6WFM1aGMxVnBiblEyTkNncElEMDlQU0F6S1FvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTFOQW9nSUNBZ0x5OGdZWEpqTkVKdmVDZ3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzZRWEpqTkVKdmVFTnZiblJ5WVdOMExuUmxjM1JDYjNoU1pXWmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFFtOTRVbVZtT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRZMkNpQWdJQ0F2THlCaGMzTmxjblFvSVdKdmVGSmxaakV1WlhocGMzUnpMQ0FuYm04Z1pHRjBZU2NwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkc5aUlnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdaR0YwWVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRjeENpQWdJQ0F2THlCaGMzTmxjblFvWW05NFVtVm1NUzVqY21WaGRHVW9leUJ6YVhwbE9pQlZhVzUwTmpRb016SXBJSDBwS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14dllpSUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRjMENpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSkNlWFJsY3lBOUlGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEzTlFvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3UVdSa2NtVnpjeUE5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMbUo1ZEdWekNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EYzNDaUFnSUNBdkx5QmliM2hTWldZeExuSmxjR3hoWTJVb01Dd2djMlZ1WkdWeVFubDBaWE1wQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkc5aUlnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRjNENpQWdJQ0F2THlCaWIzaFNaV1l4TG5KbGMybDZaU2c0TURBd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlteHZZaUlLSUNBZ0lIQjFjMmhwYm5RZ09EQXdNQW9nSUNBZ1ltOTRYM0psYzJsNlpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EYzVDaUFnSUNBdkx5QmliM2hTWldZeExuTndiR2xqWlNnd0xDQXdMQ0JoY0hCQlpHUnlaWE56S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14dllpSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZmMzQnNhV05sQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wT0RBS0lDQWdJQzh2SUdKdmVGSmxaakV1Y21Wd2JHRmpaU2cyTkN3Z2RtRnNkV1V6S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14dllpSUtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKb1pXeHNieUlLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBPREVLSUNBZ0lDOHZJR052Ym5OMElIQnlaV1pwZUNBOUlHSnZlRkpsWmpFdVpYaDBjbUZqZENnd0xDQXpNaUFxSURJZ0t5QjJZV3gxWlRNdWJHVnVaM1JvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14dllpSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRFk1Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9jSEpsWm1sNElEMDlQU0JoY0hCQlpHUnlaWE56TG1OdmJtTmhkQ2h6Wlc1a1pYSkNlWFJsY3lrdVkyOXVZMkYwS0haaGJIVmxNeWtwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0ltaGxiR3h2SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME9EUUtJQ0FnSUM4dklHSnZlRkpsWmpFdVpHVnNaWFJsS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Kc2IySWlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalE0TndvZ0lDQWdMeThnWTI5dWMzUWdXM1poYkhWbExDQmxlR2x6ZEhOZElEMGdZbTk0VW1WbU1TNXRZWGxpWlNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJHOWlJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRnNENpQWdJQ0F2THlCaGMzTmxjblFvSVdWNGFYTjBjeWtLSUNBZ0lHUjFjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBPRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDJZV3gxWlNBOVBUMGdRbmwwWlhNb0p5Y3BLUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGt3Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZbTk0VW1WbU1TNW5aWFFvZXlCa1pXWmhkV3gwT2lCelpXNWtaWEpDZVhSbGN5QjlLU0E5UFQwZ2MyVnVaR1Z5UW5sMFpYTXBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5Ea3lDaUFnSUNBdkx5QmliM2hTWldZeExuWmhiSFZsSUQwZ2MyVnVaR1Z5UW5sMFpYTXVZMjl1WTJGMEtHRndjRUZrWkhKbGMzTXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME9UTUtJQ0FnSUM4dklHRnpjMlZ5ZENoaWIzaFNaV1l4TG1WNGFYTjBjeXdnSjBKc2IySWdaWGhwYzNSekp5a0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRNU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dKdmVGSmxaakV1YkdWdVozUm9JRDA5UFNBMk5Da0tJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME5nb2dJQ0FnTHk4Z1ltOTRVbVZtSUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0oySnZlRkpsWmljZ2ZTa0tJQ0FnSUdKNWRHVmpJREUxSUM4dklDSmliM2hTWldZaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME9UY0tJQ0FnSUM4dklIUm9hWE11WW05NFVtVm1MbU55WldGMFpTaDdJSE5wZW1VNklGVnBiblEyTkNnek1pa2dmU2tLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRMkNpQWdJQ0F2THlCaWIzaFNaV1lnUFNCQ2IzZzhZbmwwWlhNK0tIc2dhMlY1T2lBblltOTRVbVZtSnlCOUtRb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0ltSnZlRkpsWmlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRNU9Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoU1pXWXVaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFl6Q2lBZ0lDQXZMeUIwWlhOMFFtOTRVbVZtS0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pwQmNtTTBRbTk0UTI5dWRISmhZM1F1YzJWMFFtOXZiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRFSnZiMnc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8xTURZS0lDQWdJQzh2SUhObGRFSnZiMndvYVc1a1pYZzZJSFZwYm5RMk5Dd2dkbUZzZFdVNklHSnZiMnhsWVc0cElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8xTURjS0lDQWdJQzh2SUhSb2FYTXVkRzl2VFdGdWVVSnZiMnh6TG5aaGJIVmxXMmx1WkdWNFhTQTlJSFpoYkhWbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQzhLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0xTWdvZ0lDQWdMeThnZEc5dlRXRnVlVUp2YjJ4eklEMGdRbTk0UEVacGVHVmtRWEp5WVhrOFltOXZiR1ZoYml3Z016TmZNREF3UGo0b2V5QnJaWGs2SUNkMGIyOU5ZVzU1UW05dmJITW5JSDBwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjI5TllXNTVRbTl2YkhNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvMU1EY0tJQ0FnSUM4dklIUm9hWE11ZEc5dlRXRnVlVUp2YjJ4ekxuWmhiSFZsVzJsdVpHVjRYU0E5SUhaaGJIVmxDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTFNZ29nSUNBZ0x5OGdkRzl2VFdGdWVVSnZiMnh6SUQwZ1FtOTRQRVpwZUdWa1FYSnlZWGs4WW05dmJHVmhiaXdnTXpOZk1EQXdQajRvZXlCclpYazZJQ2QwYjI5TllXNTVRbTl2YkhNbklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiMjlOWVc1NVFtOXZiSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8xTURjS0lDQWdJQzh2SUhSb2FYTXVkRzl2VFdGdWVVSnZiMnh6TG5aaGJIVmxXMmx1WkdWNFhTQTlJSFpoYkhWbENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRBMkNpQWdJQ0F2THlCelpYUkNiMjlzS0dsdVpHVjRPaUIxYVc1ME5qUXNJSFpoYkhWbE9pQmliMjlzWldGdUtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk9rRnlZelJDYjNoRGIyNTBjbUZqZEM1emRXMUNiMjlzYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFiVUp2YjJ4ek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5URXdDaUFnSUNBdkx5QnpkVzFDYjI5c2N5aHpkRzl3UVhSVWIzUmhiRG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE1Rb2dJQ0FnTHk4Z1pXNXpkWEpsUW5Wa1oyVjBLREV6WHpBd01Da0tJQ0FnSUhCMWMyaHBiblFnTVRNd01EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJR1Z1YzNWeVpWOWlkV1JuWlhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE1nb2dJQ0FnTHk4Z2JHVjBJSFJ2ZEdGc09pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16VXlDaUFnSUNBdkx5QjBiMjlOWVc1NVFtOXZiSE1nUFNCQ2IzZzhSbWw0WldSQmNuSmhlVHhpYjI5c1pXRnVMQ0F6TTE4d01EQStQaWg3SUd0bGVUb2dKM1J2YjAxaGJubENiMjlzY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUnZiMDFoYm5sQ2IyOXNjeUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TXdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCMllXeDFaU0J2WmlCMGFHbHpMblJ2YjAxaGJubENiMjlzY3k1MllXeDFaU2tnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NuTjFiVUp2YjJ4elgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TXdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCMllXeDFaU0J2WmlCMGFHbHpMblJ2YjAxaGJubENiMjlzY3k1MllXeDFaU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETXpNREF3Q2lBZ0lDQThDaUFnSUNCaWVpQnpkVzFDYjI5c2MxOWliRzlqYTBBeE1Bb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTFNZ29nSUNBZ0x5OGdkRzl2VFdGdWVVSnZiMnh6SUQwZ1FtOTRQRVpwZUdWa1FYSnlZWGs4WW05dmJHVmhiaXdnTXpOZk1EQXdQajRvZXlCclpYazZJQ2QwYjI5TllXNTVRbTl2YkhNbklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiMjlOWVc1NVFtOXZiSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8xTVRNS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2RtRnNkV1VnYjJZZ2RHaHBjeTUwYjI5TllXNTVRbTl2YkhNdWRtRnNkV1VwSUhzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE5Bb2dJQ0FnTHk4Z2FXWWdLSFpoYkhWbEtTQjdDaUFnSUNCaWVpQnpkVzFDYjI5c2MxOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE5Rb2dJQ0FnTHk4Z2RHOTBZV3dnS3owZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lITjNZWEFLQ25OMWJVSnZiMnh6WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TndvZ0lDQWdMeThnYVdZZ0tIUnZkR0ZzSUQwOVBTQnpkRzl3UVhSVWIzUmhiQ2tnZXdvZ0lDQWdaR2xuSURFS0lDQWdJR1JwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhOMWJVSnZiMnh6WDJKc2IyTnJRREV3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCemRXMUNiMjlzYzE5bWIzSmZhR1ZoWkdWeVFESUtDbk4xYlVKdmIyeHpYMkpzYjJOclFERXdPZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNVEFLSUNBZ0lDOHZJSE4xYlVKdmIyeHpLSE4wYjNCQmRGUnZkR0ZzT2lCMWFXNTBOalFwT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBUUFJQW9BZ0poQUZRazlZWDBNRVlteHZZZ2hpYjNoTVlYSm5aUVJpYjNoQkJHSnZlRVFCWWd4MGIyOU5ZVzU1UW05dmJITUVBQUVDQXdodFlXNTVTVzUwY3dRVkgzeDFBVEFEQm9FQkJBQUNORElDTkRJRmFHVnNiRzhHWW05NFVtVm1NUnRCQUl3eEdSUkVNUmhFZ2c4RUovZHJhUVNSSTJGNkJQY21PVWdFQ2J5NlhnUjZEVDNJQkgwRG0wTUVPOE95K1FUYzNtRk5CT0U1RnlFRWFEdGNaQVNscGliK0JKQTU3ZDRFS0xMaVFRU056dGViQkJ4MzlKWTJHZ0NPRHdCWEFCTUFDZ0pOQW1rQ213TGJBdXdETVFOZ0E2c0QwQUFCQkRVRVpnQW5Cb0dkSUxsSUlrTW5DSUdJSUxsSUlrTWlRekVaRkRFWUZCQkRpZ0lBaS82QkNnaEpNZ3dOUVFBcXNZRUdzaENCQmJJWkp3dXlIaWNMc2grTC80MENBQXNBQkxOQy85d3lBTElCUXYvMUk3SUJRdi92aVRZYUFVa1ZKQkpFRnpZYUFra2pXU1VJU3dFVlNVOENFa1JMQVZjQ0FEWWFBMGtqV1NVSVN3RVZTVThDRWtSUEJSWXJUTDhuQmJ4SUp3VkxCYjhvdkVnb1N3Sy9Kd1M4U0NjRVN3Ty9Lb0dRTUxsSWdTb1dLaUVFU3dLN0tpRUVUd0s3Szc1RUY0RURDQllyVEw4cnZVZ2tFa1FuQmIxSVR3UVNSQ2k5UkVsTEFoSkVKd1M5U0VzRUZVb1NSQ2dqSXJwTEJWY0FBUkpFU3dJaUNTaE1JcnBMQkNJSlN3Wk1JbGdTUkNOTEF3OGpTd1JQQWswaVN3UVBJa3NGVHdKTlN3Uk1DVWxMQWd4TEFreE5Td0VKS0VzQ1R3SzZJMHNHRHlOTEIwOENUU0pMQnc4aVN3aFBBazFMQjB3SlNVc0NERXNDVEUxTENFc0NUd0pTVHdJU1JDVkxCUThsVHdaUEFrMUxBZ2tvVHdOUEFyb2xTd1VQSlU4R1R3Sk5Ud1ZQQTA4Q1VoSkVKd1FqSXJwUEJGY0NBUkpFU3dFaUNTY0VUQ0s2U3dFaUNVc0VUQ0pZRWtRalN3SVBJMHNEVHdKTklrc0REeUpMQkU4Q1RVc0RUQWxKU3dJTVN3Sk1UVXNCQ1NjRVN3SlBBcm9qU3dNUEkwc0VUd0pOSWtzRUR5SkxCVThDVFVzRVRBbEpTd0lNU3dKTVRVc0dTd0pQQWxKUEFoSkVnUVZMQkErQkJVc0ZUd0pOU3dJSkp3UkxBMDhDdW9FRlN3UVBnUVZMQlU4Q1RVc0dTd05QQWxJU1JDVkxCQThsVHdWUEFrMUxBZ2tuQkU4RFR3SzZKVXNERHlWUEJFOENUVThEVHdOUEFsSVNSQ3E5U0lHUU1CSkVJa00yR2dGSkZTUVNSQmMyR2dKSkZTUVNSRXdrQ3ljSVRFOEN1eUpEZ1lSU0k0ajlyU01uQ0wxRkFVUWpTWUdCQkF4QkFCSkpKQXNuQ0V3a3VoZFBBZ2hNSWdoQy8rWklGaWNKVEZDd0lrTXJ2RWduQmJ4SUtMeElLNzVNRjRFcVN3RkxBMDJCS2hKRUp3VytKd3hPQWsxWEFnQW5EUkpFS0w0bkRFNENUVmNDQUNjTkVrUk1GRVFVUkNxOFNDSkRLaUVFSkxvWElnZ1dLaUVFVHdLN0lrTXJ2a1FYSWdnaUNTY0Z2a1JYQWdBb3ZrUXFJUVFrdWhkUEF4WkxBeFVXVndZQ1R3UlFUSUFDQUJSUVN3RVZnUlFJRmxjR0FsQlBBaFpRVEZCTVVDY0pURkN3SWtNcnZVVUJKd1c5VGdKSUtMMU9BMGdxdlU0RVNJQUJBQ05QQWxRaVR3SlVKVThDVklFRFR3SlVKd2xNVUxBaVF5Y0t2RWduQ29BVFZHVnpkR2x1WnlCMFpYTjBhVzVuSURFeU03OG5DaU9CQjdxQUIxUmxjM1JwYm1jU1JDaThTQ2lBQndBRlNHVnNiRysvS0NXQkJicUFCVWhsYkd4dkVrUWlRNEFCWkNjSHZ5Y0hJMVVVUkNjSElsVWlFa1FuQnlWVkpSSkVKd2VCQTFXQkF4SkVJa01wdlVVQkZFUXBnU0M1UkRFQU1nb3BJMHNEdXltQndEN1RLU05KU3dQU0tZRkFKdzY3S1NPQlJicExBVXNEVUNjT1VCSkVLYnhJS2I1SkZFUkxBWUFBRWtSTEEwNENUVXNDRWtSUUtieElLVXkvS2IxSWdVQVNSQ2NQZ1NDNVNDY1B2RWdpUXpZYUFVa1ZKQkpFRnpZYUFra1ZJaEpFSTFOTEFTUUtUd0lrR0NjR1N3SWl1a3NCSkF4RVRFOERWQ2NHVGdLN0lrTTJHZ0ZKRlNRU1JCZUJ5R1VqaVB1bkl5Y0d2VVVCUkNOSmdlaUJBZ3hCQUNOSEFpUUtUQ1FZSndaUEFpSzZURk5CQUFSTUlnaE1Td0ZMQXhKQUFBVWlDRUwvMUVnV0p3bE1VTEFpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
