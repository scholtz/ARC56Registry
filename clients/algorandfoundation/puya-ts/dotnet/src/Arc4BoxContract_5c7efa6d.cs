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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJveENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkR5bmFtaWNBcnJheUluQVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXJyIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcnIyIiwidHlwZSI6InVpbnQ2NFtdIn1dLCJMYXJnZVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImQiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZiIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiZyIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiaCIsInR5cGUiOiJ1aW50NjQifV0sIlJlYWRCb3hlc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkJveGVzRXhpc3RSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrS2V5cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtTWFueUludHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmRpcmVjdEV4dHJhY3RBbmRSZXBsYWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGJ5dGVbXSxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IlJlYWRCb3hlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJveGVzRXhpc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiQm94ZXNFeGlzdFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsaWNlQm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzRCb3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEJveFJlZiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVCb29scyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRCb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtQm9vbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcEF0VG90YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQyMiw0NDcsODY1LDk5MCw5OTksMTAwNSwxMzg4XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNTRdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNSw4NDksODgzLDk3NSw5ODUsMTAxMCwxMzYzLDE0MTFdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI4LDM0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM4LDM1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjEsODMxLDg0MCwxMzI0LDEzNzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjIxXSwiZXJyb3JNZXNzYWdlIjoibm8gZGF0YSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNaUEwTURrMkNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKQ1QxaGZReUlnSW1Kc2IySWlJQ0ppYjNoTVlYSm5aU0lnSW1KdmVFRWlJQ0ppYjNoRUlpQWlZaUlnSW5SdmIwMWhibmxDYjI5c2N5SWdNSGd3TURBeE1ESXdNeUFpYldGdWVVbHVkSE1pSURCNE1UVXhaamRqTnpVZ0lqQWlJREI0TURZNE1UQXhJREI0TURBd01qTTBNeklnSWpReUlpQWlhR1ZzYkc4aUlDSmliM2hTWldZaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EQUtJQ0FnSUM4dklHTnNZWE56SUVGeVl6UkNiM2hEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJR0Z5WXpRdVEyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREkwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd5TjJZM05tSTJPU0F3ZURreE1qTTJNVGRoSURCNFpqY3lOak01TkRnZ01IZ3dPV0pqWW1FMVpTQXdlRGRoTUdRelpHTTRJREI0TjJRd016bGlORE1nTUhnelltTXpZakptT1NBd2VHUmpaR1UyTVRSa0lEQjRaVEV6T1RFM01qRWdNSGcyT0ROaU5XTTJOQ0F3ZUdFMVlUWXlObVpsSURCNE9UQXpPV1ZrWkdVZ01IZ3lPR0l5WlRJME1TQXdlRGhrWTJWa056bGlJREI0TVdNM04yWTBPVFlnTHk4Z2JXVjBhRzlrSUNKelpYUkNiM2hsY3loMWFXNTBOalFzWW5sMFpWdGRMSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKamFHVmphMHRsZVhNb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1OeVpXRjBaVTFoYm5sSmJuUnpLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJOWVc1NVNXNTBjeWgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5OMWJVMWhibmxKYm5SektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltUmxiR1YwWlVKdmVHVnpLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnBibVJwY21WamRFVjRkSEpoWTNSQmJtUlNaWEJzWVdObEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXRmtRbTk0WlhNb0tTaDFhVzUwTmpRc1lubDBaVnRkTEhOMGNtbHVaeXgxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0ppYjNobGMwVjRhWE4wS0Nrb1ltOXZiQ3hpYjI5c0xHSnZiMndzWW05dmJDa2lMQ0J0WlhSb2IyUWdJbk5zYVdObFFtOTRLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjbU0wUW05NEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBRbTk0VW1WbUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamNtVmhkR1ZDYjI5c2N5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBRbTl2YkNoMWFXNTBOalFzWW05dmJDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKemRXMUNiMjlzY3loMWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFFtOTRaWE1nYldGcGJsOWphR1ZqYTB0bGVYTmZjbTkxZEdWQU55QnRZV2x1WDJOeVpXRjBaVTFoYm5sSmJuUnpYM0p2ZFhSbFFEZ2djMlYwVFdGdWVVbHVkSE1nYzNWdFRXRnVlVWx1ZEhNZ1pHVnNaWFJsUW05NFpYTWdhVzVrYVhKbFkzUkZlSFJ5WVdOMFFXNWtVbVZ3YkdGalpTQnlaV0ZrUW05NFpYTWdZbTk0WlhORmVHbHpkQ0J6YkdsalpVSnZlQ0JoY21NMFFtOTRJSFJsYzNSQ2IzaFNaV1lnYldGcGJsOWpjbVZoZEdWQ2IyOXNjMTl5YjNWMFpVQXhPQ0J6WlhSQ2IyOXNJSE4xYlVKdmIyeHpDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsUW05dmJITmZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOVElLSUNBZ0lDOHZJSFJ2YjAxaGJubENiMjlzY3lBOUlFSnZlRHhHYVhobFpFRnljbUY1UEdKdmIyeGxZVzRzSURNelh6QXdNRDQrS0hzZ2EyVjVPaUFuZEc5dlRXRnVlVUp2YjJ4ekp5QjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkRzl2VFdGdWVVSnZiMnh6SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRBekNpQWdJQ0F2THlCMGFHbHpMblJ2YjAxaGJubENiMjlzY3k1amNtVmhkR1VvS1FvZ0lDQWdjSFZ6YUdsdWRDQTBNVEkxQ2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qVXdNZ29nSUNBZ0x5OGdZM0psWVhSbFFtOXZiSE1vS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVTFoYm5sSmJuUnpYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGdLSUNBZ0lDOHZJRzFoYm5sSmJuUnpJRDBnUW05NFBFMWhibmxKYm5SelBpaDdJR3RsZVRvZ0oyMWhibmxKYm5Sekp5QjlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWliV0Z1ZVVsdWRITWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNRElLSUNBZ0lDOHZJSFJvYVhNdWJXRnVlVWx1ZEhNdVkzSmxZWFJsS0NrS0lDQWdJSEIxYzJocGJuUWdOREV3TkFvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNREVLSUNBZ0lDOHZJR055WldGMFpVMWhibmxKYm5SektDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWphR1ZqYTB0bGVYTmZjbTkxZEdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTVOQW9nSUNBZ0x5OGdZMmhsWTJ0TFpYbHpLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNalE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRBS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSQ2IzaERiMjUwY21GamRDQmxlSFJsYm1SeklHRnlZelF1UTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1ZFhScGJDNWxibk4xY21WZlluVmtaMlYwS0hKbGNYVnBjbVZrWDJKMVpHZGxkRG9nZFdsdWREWTBMQ0JtWldWZmMyOTFjbU5sT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21WdWMzVnlaVjlpZFdSblpYUTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ0t3b0taVzV6ZFhKbFgySjFaR2RsZEY5M2FHbHNaVjkwYjNCQU1Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JuYkc5aVlXd2dUM0JqYjJSbFFuVmtaMlYwQ2lBZ0lDQStDaUFnSUNCaWVpQmxibk4xY21WZlluVmtaMlYwWDJGbWRHVnlYM2RvYVd4bFFEWUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQTJPREV3TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCeWIzWmhiRkJ5YjJkeVlXMEtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNRFk0TVRBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjNhWFJqYUNCbGJuTjFjbVZmWW5Wa1oyVjBYM04zYVhSamFGOWpZWE5sWHpCQU15Qmxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6RkFOQW9LWlc1emRYSmxYMkoxWkdkbGRGOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEVTZDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWWlCbGJuTjFjbVZmWW5Wa1oyVjBYM2RvYVd4bFgzUnZjRUF4Q2dwbGJuTjFjbVZmWW5Wa1oyVjBYM04zYVhSamFGOWpZWE5sWHpGQU5Eb0tJQ0FnSUdkc2IySmhiQ0JOYVc1VWVHNUdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmlJR1Z1YzNWeVpWOWlkV1JuWlhSZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMUNncGxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFh6QkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1lpQmxibk4xY21WZlluVmtaMlYwWDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTlFvS1pXNXpkWEpsWDJKMVpHZGxkRjloWm5SbGNsOTNhR2xzWlVBMk9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk9rRnlZelJDYjNoRGIyNTBjbUZqZEM1elpYUkNiM2hsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRUp2ZUdWek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16VTVDaUFnSUNBdkx5QnpaWFJDYjNobGN5aGhPaUIxYVc1ME5qUXNJR0k2SUdKNWRHVnpMQ0JqT2lCaGNtTTBMbE4wY2lrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTVFvZ0lDQWdMeThnZEdocGN5NWliM2hCTG5aaGJIVmxJRDBnWVFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOREVLSUNBZ0lDOHZJR0p2ZUVFZ1BTQkNiM2c4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMkp2ZUVFbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmliM2hCSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpZeENpQWdJQ0F2THlCMGFHbHpMbUp2ZUVFdWRtRnNkV1VnUFNCaENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORElLSUNBZ0lDOHZJR0p2ZUVJZ1BTQkNiM2c4WVhKak5DNUVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuWWljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltSWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOaklLSUNBZ0lDOHZJSFJvYVhNdVltOTRRaTUyWVd4MVpTQTlJR1I1Ym1GdGFXTkNlWFJsY3dvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ESUtJQ0FnSUM4dklHSnZlRUlnUFNCQ2IzZzhZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5ZaWNnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1JaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5qSUtJQ0FnSUM4dklIUm9hWE11WW05NFFpNTJZV3gxWlNBOUlHUjVibUZ0YVdOQ2VYUmxjd29nSUNBZ1pHbG5JRFVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME13b2dJQ0FnTHk4Z1ltOTRReUE5SUVKdmVEeGhjbU0wTGxOMGNqNG9leUJyWlhrNklDZENUMWhmUXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrSlBXRjlESWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpZekNpQWdJQ0F2THlCMGFHbHpMbUp2ZUVNdWRtRnNkV1VnUFNCakNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNd29nSUNBZ0x5OGdZbTk0UXlBOUlFSnZlRHhoY21NMExsTjBjajRvZXlCclpYazZJQ2RDVDFoZlF5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0pQV0Y5RElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16WXpDaUFnSUNBdkx5QjBhR2x6TG1KdmVFTXVkbUZzZFdVZ1BTQmpDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRMENpQWdJQ0F2THlCaWIzaEVJRDBnUW05NFBHSjVkR1Z6UGloN0lHdGxlVG9nSjJKdmVFUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppYjNoRUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16WTBDaUFnSUNBdkx5QjBhR2x6TG1KdmVFUXVkbUZzZFdVZ1BTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTkFvZ0lDQWdMeThnWW05NFJDQTlJRUp2ZUR4aWVYUmxjejRvZXlCclpYazZJQ2RpYjNoRUp5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZbTk0UkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMk5Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoRUxuWmhiSFZsSUQwZ1pIbHVZVzFwWTBKNWRHVnpMbTVoZEdsMlpRb2dJQ0FnWkdsbklETUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTndvZ0lDQWdMeThnWW05NFRHRnlaMlVnUFNCQ2IzZzhUR0Z5WjJWVGRISjFZM1ErS0hzZ2EyVjVPaUFuWW05NFRHRnlaMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaE1ZWEpuWlNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMk5Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTVlYSm5aUzVqY21WaGRHVW9LUW9nSUNBZ2NIVnphR2x1ZENBMk1UWXdDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMk5nb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTVlYSm5aUzUyWVd4MVpTNWxJRDBnTkRJS0lDQWdJSEIxYzJocGJuUWdORElLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTndvZ0lDQWdMeThnWW05NFRHRnlaMlVnUFNCQ2IzZzhUR0Z5WjJWVGRISjFZM1ErS0hzZ2EyVjVPaUFuWW05NFRHRnlaMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaE1ZWEpuWlNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMk5nb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTVlYSm5aUzUyWVd4MVpTNWxJRDBnTkRJS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EY0tJQ0FnSUM4dklHSnZlRXhoY21kbElEMGdRbTk0UEV4aGNtZGxVM1J5ZFdOMFBpaDdJR3RsZVRvZ0oySnZlRXhoY21kbEp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZbTk0VEdGeVoyVWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOamNLSUNBZ0lDOHZJSFJvYVhNdVltOTRUR0Z5WjJVdWNtVndiR0ZqWlNoaGNtTTBMbk5wZW1WUFpqeENlWFJsY3pFd01qUStLQ2tnS2lBMExDQnVaWGNnWVhKak5DNVZhVzUwTmpRb05ESXBMbUo1ZEdWektRb2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TW1FS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRFS0lDQWdJQzh2SUdKdmVFRWdQU0JDYjNnOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJKdmVFRW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ppYjNoQklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16Y3hDaUFnSUNBdkx5QjBhR2x6TG1KdmVFRXVkbUZzZFdVZ0t6MGdNd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReENpQWdJQ0F2THlCaWIzaEJJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEJKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFFTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTNNUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaEJMblpoYkhWbElDczlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1Rb2dJQ0FnTHk4Z1ltOTRRU0E5SUVKdmVEeDFhVzUwTmpRK0tIc2dhMlY1T2lBblltOTRRU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVFRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOelFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFRXViR1Z1WjNSb0lEMDlQU0E0S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReUNpQWdJQ0F2THlCaWIzaENJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpjMUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hDTG14bGJtZDBhQ0E5UFQwZ1pIbHVZVzFwWTBKNWRHVnpMbUo1ZEdWekxteGxibWQwYUNrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0zTmdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRReTVzWlc1bmRHZ2dQVDA5SUdNdVlubDBaWE11YkdWdVozUm9LUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTkFvZ0lDQWdMeThnWW05NFJDQTlJRUp2ZUR4aWVYUmxjejRvZXlCclpYazZJQ2RpYjNoRUp5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZbTk0UkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNM053b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UkM1c1pXNW5kR2dnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTV1WVhScGRtVXViR1Z1WjNSb0tRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJR0p2ZUVNZ1BTQkNiM2c4WVhKak5DNVRkSEkrS0hzZ2EyVjVPaUFuUWs5WVgwTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pDVDFoZlF5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTRNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFF5NTJZV3gxWlM1aWVYUmxjeTVoZENnd0tTQTlQVDBnWXk1aWVYUmxjeTVoZENnd0tTa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHUnBaeUExQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemd4Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaERMblpoYkhWbExtSjVkR1Z6TG1GMEtDMHhLU0E5UFQwZ1l5NWllWFJsY3k1aGRDZ3RNU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNd29nSUNBZ0x5OGdZbTk0UXlBOUlFSnZlRHhoY21NMExsTjBjajRvZXlCclpYazZJQ2RDVDFoZlF5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0pQV0Y5RElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16Z3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoRExuWmhiSFZsTG1KNWRHVnpMbUYwS0MweEtTQTlQVDBnWXk1aWVYUmxjeTVoZENndE1Ta3BDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pHbG5JRFlLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpneUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hETG5aaGJIVmxMbUo1ZEdWekxuTnNhV05sS0RBc0lDMHhLU0E5UFQwZ1l5NWllWFJsY3k1emJHbGpaU2d3TENBdE1Ta3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkdsbklETUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaR2xuSURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1pHbG5JRFFLSUNBZ0lENDlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklEVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaERMblpoYkhWbExtSjVkR1Z6TG5Oc2FXTmxLREFzSUMweEtTQTlQVDBnWXk1aWVYUmxjeTV6YkdsalpTZ3dMQ0F0TVNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdScFp5QTJDaUFnSUNBK1BRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1JwWnlBM0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHUnBaeUEzQ2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdScFp5QTRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklEY0tJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBNENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNNE13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UXk1MllXeDFaUzVpZVhSbGN5NXpiR2xqWlNnd0xDQXlLU0E5UFQwZ1l5NWllWFJsY3k1emJHbGpaU2d3TENBeUtTa0tJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ01nb2dJQ0FnTFFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRekNpQWdJQ0F2THlCaWIzaERJRDBnUW05NFBHRnlZelF1VTNSeVBpaDdJR3RsZVRvZ0owSlBXRjlESnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVFrOVlYME1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRU11ZG1Gc2RXVXVZbmwwWlhNdWMyeHBZMlVvTUN3Z01pa2dQVDA5SUdNdVlubDBaWE11YzJ4cFkyVW9NQ3dnTWlrcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQmthV2NnTlFvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EUUtJQ0FnSUM4dklHSnZlRVFnUFNCQ2IzZzhZbmwwWlhNK0tIc2dhMlY1T2lBblltOTRSQ2NnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1KdmVFUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFUXVkbUZzZFdVdVlYUW9NQ2tnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTV1WVhScGRtVXVZWFFvTUNrcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRVF1ZG1Gc2RXVXVZWFFvTFRFcElEMDlQU0JrZVc1aGJXbGpRbmwwWlhNdWJtRjBhWFpsTG1GMEtDMHhLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTBDaUFnSUNBdkx5QmliM2hFSUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0oySnZlRVFuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaWIzaEVJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemczQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEVMblpoYkhWbExtRjBLQzB4S1NBOVBUMGdaSGx1WVcxcFkwSjVkR1Z6TG01aGRHbDJaUzVoZENndE1Ta3BDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpnNENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hFTG5aaGJIVmxMbk5zYVdObEtEQXNJQzB4S1NBOVBUMGdaSGx1WVcxcFkwSjVkR1Z6TG01aGRHbDJaUzV6YkdsalpTZ3dMQ0F0TVNrcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJRDQ5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklETUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdaR2xuSURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdZbTk0UkNBOUlFSnZlRHhpZVhSbGN6NG9leUJyWlhrNklDZGliM2hFSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVltOTRSQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00T0FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRSQzUyWVd4MVpTNXpiR2xqWlNnd0xDQXRNU2tnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTV1WVhScGRtVXVjMnhwWTJVb01Dd2dMVEVwS1FvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCa2FXY2dOQW9nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JrYVdjZ05Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTmdvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RrS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRVF1ZG1Gc2RXVXVjMnhwWTJVb01Dd2dOU2tnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTV1WVhScGRtVXVjMnhwWTJVb01Dd2dOU2twQ2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUdScFp5QTBDaUFnSUNBK1BRb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQmthV2NnTlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXRDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORFFLSUNBZ0lDOHZJR0p2ZUVRZ1BTQkNiM2c4WW5sMFpYTStLSHNnYTJWNU9pQW5ZbTk0UkNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSnZlRVFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RrS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRVF1ZG1Gc2RXVXVjMnhwWTJVb01Dd2dOU2tnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTV1WVhScGRtVXVjMnhwWTJVb01Dd2dOU2twQ2lBZ0lDQmthV2NnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQmthV2NnTkFvZ0lDQWdQajBLSUNBZ0lIQjFjMmhwYm5RZ05Rb2dJQ0FnWkdsbklEVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemt3Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEVMblpoYkhWbExuTnNhV05sS0RBc0lGVnBiblEyTkNneUtTa2dQVDA5SUdSNWJtRnRhV05DZVhSbGN5NXVZWFJwZG1VdWMyeHBZMlVvTUN3Z1ZXbHVkRFkwS0RJcEtTa0tJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ01nb2dJQ0FnTFFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRMENpQWdJQ0F2THlCaWIzaEVJRDBnUW05NFBHSjVkR1Z6UGloN0lHdGxlVG9nSjJKdmVFUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppYjNoRUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16a3dDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoRUxuWmhiSFZsTG5Oc2FXTmxLREFzSUZWcGJuUTJOQ2d5S1NrZ1BUMDlJR1I1Ym1GdGFXTkNlWFJsY3k1dVlYUnBkbVV1YzJ4cFkyVW9NQ3dnVldsdWREWTBLRElwS1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME53b2dJQ0FnTHk4Z1ltOTRUR0Z5WjJVZ1BTQkNiM2c4VEdGeVoyVlRkSEoxWTNRK0tIc2dhMlY1T2lBblltOTRUR0Z5WjJVbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmliM2hNWVhKblpTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTVNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFRHRnlaMlV1YkdWdVozUm9JRDA5UFNCaGNtTTBMbk5wZW1WUFpqeE1ZWEpuWlZOMGNuVmpkRDRvS1NrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnY0hWemFHbHVkQ0EyTVRZd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5Ua0tJQ0FnSUM4dklITmxkRUp2ZUdWektHRTZJSFZwYm5RMk5Dd2dZam9nWW5sMFpYTXNJR002SUdGeVl6UXVVM1J5S1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02T2tGeVl6UkNiM2hEYjI1MGNtRmpkQzV6WlhSTllXNTVTVzUwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRTFoYm5sSmJuUnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREExQ2lBZ0lDQXZMeUJ6WlhSTllXNTVTVzUwY3locGJtUmxlRG9nZFdsdWREWTBMQ0IyWVd4MVpUb2dkV2x1ZERZMEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1EWUtJQ0FnSUM4dklIUm9hWE11YldGdWVVbHVkSE11ZG1Gc2RXVmJhVzVrWlhoZElEMGdkbUZzZFdVS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGdLSUNBZ0lDOHZJRzFoYm5sSmJuUnpJRDBnUW05NFBFMWhibmxKYm5SelBpaDdJR3RsZVRvZ0oyMWhibmxKYm5Sekp5QjlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWliV0Z1ZVVsdWRITWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNRFlLSUNBZ0lDOHZJSFJvYVhNdWJXRnVlVWx1ZEhNdWRtRnNkV1ZiYVc1a1pYaGRJRDBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXdOUW9nSUNBZ0x5OGdjMlYwVFdGdWVVbHVkSE1vYVc1a1pYZzZJSFZwYm5RMk5Dd2dkbUZzZFdVNklIVnBiblEyTkNrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pwQmNtTTBRbTk0UTI5dWRISmhZM1F1YzNWdFRXRnVlVWx1ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkVzFOWVc1NVNXNTBjem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF4TUFvZ0lDQWdMeThnWlc1emRYSmxRblZrWjJWMEtERXdYelV3TUNrS0lDQWdJSEIxYzJocGJuUWdNVEExTURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlHVnVjM1Z5WlY5aWRXUm5aWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF4TVFvZ0lDQWdMeThnYkdWMElIUnZkR0ZzSUQwZ1ZXbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRNENpQWdJQ0F2THlCdFlXNTVTVzUwY3lBOUlFSnZlRHhOWVc1NVNXNTBjejRvZXlCclpYazZJQ2R0WVc1NVNXNTBjeWNnZlNrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW0xaGJubEpiblJ6SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRFeUNpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElIWmhiQ0J2WmlCMGFHbHpMbTFoYm5sSmJuUnpMblpoYkhWbEtTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LYzNWdFRXRnVlVWx1ZEhOZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREV5Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhaaGJDQnZaaUIwYUdsekxtMWhibmxKYm5SekxuWmhiSFZsS1NCN0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOVEV6Q2lBZ0lDQThDaUFnSUNCaWVpQnpkVzFOWVc1NVNXNTBjMTloWm5SbGNsOW1iM0pBTlFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdLZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelE0Q2lBZ0lDQXZMeUJ0WVc1NVNXNTBjeUE5SUVKdmVEeE5ZVzU1U1c1MGN6NG9leUJyWlhrNklDZHRZVzU1U1c1MGN5Y2dmU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbTFoYm5sSmJuUnpJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREV5Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhaaGJDQnZaaUIwYUdsekxtMWhibmxKYm5SekxuWmhiSFZsS1NCN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXhNd29nSUNBZ0x5OGdkRzkwWVd3Z1BTQjBiM1JoYkNBcklIWmhiQW9nSUNBZ1pHbG5JRE1LSUNBZ0lDc0tJQ0FnSUdKMWNua2dNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCemRXMU5ZVzU1U1c1MGMxOW1iM0pmYUdWaFpHVnlRRElLQ25OMWJVMWhibmxKYm5SelgyRm1kR1Z5WDJadmNrQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREE1Q2lBZ0lDQXZMeUJ6ZFcxTllXNTVTVzUwY3lncElIc0tJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk9rRnlZelJDYjNoRGIyNTBjbUZqZEM1a1pXeGxkR1ZDYjNobGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsYkdWMFpVSnZlR1Z6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReENpQWdJQ0F2THlCaWIzaEJJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEJKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFFTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXhPUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaEJMbVJsYkdWMFpTZ3BDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTWdvZ0lDQWdMeThnWW05NFFpQTlJRUp2ZUR4aGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3o0b2V5QnJaWGs2SUNkaUp5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF5TUFvZ0lDQWdMeThnZEdocGN5NWliM2hDTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME13b2dJQ0FnTHk4Z1ltOTRReUE5SUVKdmVEeGhjbU0wTGxOMGNqNG9leUJyWlhrNklDZENUMWhmUXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrSlBXRjlESWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRJeENpQWdJQ0F2THlCMGFHbHpMbUp2ZUVNdVpHVnNaWFJsS0NrS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXhDaUFnSUNBdkx5QmliM2hCSUQwZ1FtOTRQSFZwYm5RMk5ENG9leUJyWlhrNklDZGliM2hCSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVltOTRRU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF5TWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRRUzVuWlhRb2V5QmtaV1poZFd4ME9pQlZhVzUwTmpRb05ESXBJSDBwSUQwOVBTQTBNaWtLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdORElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjMlZzWldOMENpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRJS0lDQWdJQzh2SUdKdmVFSWdQU0JDYjNnOFlYSmpOQzVFZVc1aGJXbGpRbmwwWlhNK0tIc2dhMlY1T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTWpNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRUl1WjJWMEtIc2daR1ZtWVhWc2REb2dibVYzSUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S0VKNWRHVnpLQ2MwTWljcEtTQjlLUzV1WVhScGRtVWdQVDA5SUVKNWRHVnpLQ2MwTWljcEtRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TURBeU16UXpNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ01UTWdMeThnSWpReUlnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXpDaUFnSUNBdkx5QmliM2hESUQwZ1FtOTRQR0Z5WXpRdVUzUnlQaWg3SUd0bGVUb2dKMEpQV0Y5REp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlRazlZWDBNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1qUUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUVNdVoyVjBLSHNnWkdWbVlYVnNkRG9nYm1WM0lHRnlZelF1VTNSeUtDYzBNaWNwSUgwcExtNWhkR2wyWlNBOVBUMGdKelF5SnlrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREF3TWpNME16SUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0kwTWlJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pReU53b2dJQ0FnTHk4Z1lYTnpaWEowS0NGaFJYaHBjM1J6S1FvZ0lDQWdjM2RoY0FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTWpnS0lDQWdJQzh2SUdGemMyVnlkQ2hoSUQwOVBTQXdLUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGNLSUNBZ0lDOHZJR0p2ZUV4aGNtZGxJRDBnUW05NFBFeGhjbWRsVTNSeWRXTjBQaWg3SUd0bGVUb2dKMkp2ZUV4aGNtZGxKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NFRHRnlaMlVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTWprS0lDQWdJQzh2SUhSb2FYTXVZbTk0VEdGeVoyVXVaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREU0Q2lBZ0lDQXZMeUJrWld4bGRHVkNiM2hsY3lncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvNlFYSmpORUp2ZUVOdmJuUnlZV04wTG1sdVpHbHlaV04wUlhoMGNtRmpkRUZ1WkZKbGNHeGhZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJtUnBjbVZqZEVWNGRISmhZM1JCYm1SU1pYQnNZV05sT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRM0NpQWdJQ0F2THlCaWIzaE1ZWEpuWlNBOUlFSnZlRHhNWVhKblpWTjBjblZqZEQ0b2V5QnJaWGs2SUNkaWIzaE1ZWEpuWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSnZlRXhoY21kbElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETXlMVFF6TXdvZ0lDQWdMeThnWTI5dWMzUWdiR0Z5WjJVZ1BTQmpiRzl1WlNoMGFHbHpMbUp2ZUV4aGNtZGxMblpoYkhWbEtRb2dJQ0FnTHk4Z2JHRnlaMlV1WlNBclBTQXhDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTXpNS0lDQWdJQzh2SUd4aGNtZGxMbVVnS3owZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTndvZ0lDQWdMeThnWW05NFRHRnlaMlVnUFNCQ2IzZzhUR0Z5WjJWVGRISjFZM1ErS0hzZ2EyVjVPaUFuWW05NFRHRnlaMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaE1ZWEpuWlNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRek15MDBNelFLSUNBZ0lDOHZJR3hoY21kbExtVWdLejBnTVFvZ0lDQWdMeThnZEdocGN5NWliM2hNWVhKblpTNTJZV3gxWlNBOUlHTnNiMjVsS0d4aGNtZGxLUW9nSUNBZ2FXNTBZeUEwSUM4dklEUXdPVFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF6TVFvZ0lDQWdMeThnYVc1a2FYSmxZM1JGZUhSeVlXTjBRVzVrVW1Wd2JHRmpaU2dwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem82UVhKak5FSnZlRU52Ym5SeVlXTjBMbkpsWVdSQ2IzaGxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFlXUkNiM2hsY3pvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1Rb2dJQ0FnTHk4Z1ltOTRRU0E5SUVKdmVEeDFhVzUwTmpRK0tIc2dhMlY1T2lBblltOTRRU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVFRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNallLSUNBZ0lDOHZJSEpsZEhWeWJpQlZhVzUwTmpRb1ltOTRMblpoYkhWbElDc2dNU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETTRDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNoblpYUkNiM2hXWVd4MVpWQnNkWE14S0hSb2FYTXVZbTk0UVNrZ0xTQXhLU3dnZEdocGN5NWliM2hDTG5aaGJIVmxMbTVoZEdsMlpTd2dkR2hwY3k1aWIzaERMblpoYkhWbExDQjBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxMbVZkSUdGeklHTnZibk4wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXlDaUFnSUNBdkx5QmliM2hDSUQwZ1FtOTRQR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETTRDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNoblpYUkNiM2hXWVd4MVpWQnNkWE14S0hSb2FYTXVZbTk0UVNrZ0xTQXhLU3dnZEdocGN5NWliM2hDTG5aaGJIVmxMbTVoZEdsMlpTd2dkR2hwY3k1aWIzaERMblpoYkhWbExDQjBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxMbVZkSUdGeklHTnZibk4wQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMVZwYm5RMk5DaG5aWFJDYjNoV1lXeDFaVkJzZFhNeEtIUm9hWE11WW05NFFTa2dMU0F4S1N3Z2RHaHBjeTVpYjNoQ0xuWmhiSFZsTG01aGRHbDJaU3dnZEdocGN5NWliM2hETG5aaGJIVmxMQ0IwYUdsekxtSnZlRXhoY21kbExuWmhiSFZsTG1WZElHRnpJR052Ym5OMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTNDaUFnSUNBdkx5QmliM2hNWVhKblpTQTlJRUp2ZUR4TVlYSm5aVk4wY25WamRENG9leUJyWlhrNklDZGliM2hNWVhKblpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUV4aGNtZGxJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMVZwYm5RMk5DaG5aWFJDYjNoV1lXeDFaVkJzZFhNeEtIUm9hWE11WW05NFFTa2dMU0F4S1N3Z2RHaHBjeTVpYjNoQ0xuWmhiSFZsTG01aGRHbDJaU3dnZEdocGN5NWliM2hETG5aaGJIVmxMQ0IwYUdsekxtSnZlRXhoY21kbExuWmhiSFZsTG1WZElHRnpJR052Ym5OMENpQWdJQ0JwYm5SaklEUWdMeThnTkRBNU5nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNemNLSUNBZ0lDOHZJSEpsWVdSQ2IzaGxjeWdwT2lCeVpXRmtiMjVzZVNCYmRXbHVkRFkwTENCaWVYUmxjeXdnWVhKak5DNVRkSElzSUhWcGJuUTJORjBnZXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01UUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU1Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02T2tGeVl6UkNiM2hEYjI1MGNtRmpkQzVpYjNobGMwVjRhWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOTRaWE5GZUdsemREb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNUW9nSUNBZ0x5OGdZbTk0UVNBOUlFSnZlRHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZbTk0UVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSnZlRUVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTkRJS0lDQWdJQzh2SUhKbGRIVnliaUJiZEdocGN5NWliM2hCTG1WNGFYTjBjeXdnZEdocGN5NWliM2hDTG1WNGFYTjBjeXdnZEdocGN5NWliM2hETG1WNGFYTjBjeXdnZEdocGN5NWliM2hNWVhKblpTNWxlR2x6ZEhOZElHRnpJR052Ym5OMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTWdvZ0lDQWdMeThnWW05NFFpQTlJRUp2ZUR4aGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3o0b2V5QnJaWGs2SUNkaUp5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEwTWdvZ0lDQWdMeThnY21WMGRYSnVJRnQwYUdsekxtSnZlRUV1WlhocGMzUnpMQ0IwYUdsekxtSnZlRUl1WlhocGMzUnpMQ0IwYUdsekxtSnZlRU11WlhocGMzUnpMQ0IwYUdsekxtSnZlRXhoY21kbExtVjRhWE4wYzEwZ1lYTWdZMjl1YzNRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF6Q2lBZ0lDQXZMeUJpYjNoRElEMGdRbTk0UEdGeVl6UXVVM1J5UGloN0lHdGxlVG9nSjBKUFdGOURKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpUWs5WVgwTWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBORElLSUNBZ0lDOHZJSEpsZEhWeWJpQmJkR2hwY3k1aWIzaEJMbVY0YVhOMGN5d2dkR2hwY3k1aWIzaENMbVY0YVhOMGN5d2dkR2hwY3k1aWIzaERMbVY0YVhOMGN5d2dkR2hwY3k1aWIzaE1ZWEpuWlM1bGVHbHpkSE5kSUdGeklHTnZibk4wQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOd29nSUNBZ0x5OGdZbTk0VEdGeVoyVWdQU0JDYjNnOFRHRnlaMlZUZEhKMVkzUStLSHNnYTJWNU9pQW5ZbTk0VEdGeVoyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppYjNoTVlYSm5aU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEwTWdvZ0lDQWdMeThnY21WMGRYSnVJRnQwYUdsekxtSnZlRUV1WlhocGMzUnpMQ0IwYUdsekxtSnZlRUl1WlhocGMzUnpMQ0IwYUdsekxtSnZlRU11WlhocGMzUnpMQ0IwYUdsekxtSnZlRXhoY21kbExtVjRhWE4wYzEwZ1lYTWdZMjl1YzNRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFF4Q2lBZ0lDQXZMeUJpYjNobGMwVjRhWE4wS0NrNklISmxZV1J2Ym14NUlGdGliMjlzWldGdUxDQmliMjlzWldGdUxDQmliMjlzWldGdUxDQmliMjlzWldGdVhTQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qcEJjbU0wUW05NFEyOXVkSEpoWTNRdWMyeHBZMlZDYjNoYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpiR2xqWlVKdmVEb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTBOd29nSUNBZ0x5OGdZbTk0TUM1MllXeDFaU0E5SUVKNWRHVnpLQ2RVWlhOMGFXNW5JSFJsYzNScGJtY2dNVEl6SnlrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNJd0lnb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlNQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QWlWR1Z6ZEdsdVp5QjBaWE4wYVc1bklERXlNeUlLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dKdmVEQXVkbUZzZFdVdWMyeHBZMlVvTUN3Z055a2dQVDA5SUVKNWRHVnpLQ2RVWlhOMGFXNW5KeWtwQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpTUNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQndkWE5vYVc1MElEY0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxSbGMzUnBibWNpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalExTUFvZ0lDQWdMeThnZEdocGN5NWliM2hETG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1VTNSeUtDZElaV3hzYnljcENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNd29nSUNBZ0x5OGdZbTk0UXlBOUlFSnZlRHhoY21NMExsTjBjajRvZXlCclpYazZJQ2RDVDFoZlF5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0pQV0Y5RElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EVXdDaUFnSUNBdkx5QjBhR2x6TG1KdmVFTXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVRkSElvSjBobGJHeHZKeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURVME9EWTFObU0yWXpabUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJR0p2ZUVNZ1BTQkNiM2c4WVhKak5DNVRkSEkrS0hzZ2EyVjVPaUFuUWs5WVgwTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pDVDFoZlF5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTFNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFF5NTJZV3gxWlM1aWVYUmxjeTV6YkdsalpTZ3lMQ0F4TUNrZ1BUMDlJRUo1ZEdWektDZElaV3hzYnljcEtRb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUhCMWMyaGllWFJsY3lBaVNHVnNiRzhpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTkRVS0lDQWdJQzh2SUhOc2FXTmxRbTk0S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pwQmNtTTBRbTk0UTI5dWRISmhZM1F1WVhKak5FSnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GeVl6UkNiM2c2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTlRZS0lDQWdJQzh2SUdKdmVFUXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVRkR0YwYVdOQmNuSmhlU2h1WlhjZ1lYSmpOQzVWYVc1ME9DZ3dLU3dnYm1WM0lHRnlZelF1VldsdWREZ29NU2tzSUc1bGR5QmhjbU0wTGxWcGJuUTRLRElwTENCdVpYY2dZWEpqTkM1VmFXNTBPQ2d6S1NrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWkNJS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXhNREl3TXdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdNREV3TWpBekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENoaWIzaEVMblpoYkhWbFd6QmRMbUZ6VldsdWREWTBLQ2tnUFQwOUlEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFlubDBaUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBOVFlLSUNBZ0lDOHZJR0p2ZUVRdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VGRHRjBhV05CY25KaGVTaHVaWGNnWVhKak5DNVZhVzUwT0Nnd0tTd2dibVYzSUdGeVl6UXVWV2x1ZERnb01Ta3NJRzVsZHlCaGNtTTBMbFZwYm5RNEtESXBMQ0J1WlhjZ1lYSmpOQzVWYVc1ME9DZ3pLU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TURBeE1ESXdNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZbTk0UkM1MllXeDFaVnN4WFM1aGMxVnBiblEyTkNncElEMDlQU0F4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHZGxkR0o1ZEdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTlRZS0lDQWdJQzh2SUdKdmVFUXVkbUZzZFdVZ1BTQnVaWGNnWVhKak5DNVRkR0YwYVdOQmNuSmhlU2h1WlhjZ1lYSmpOQzVWYVc1ME9DZ3dLU3dnYm1WM0lHRnlZelF1VldsdWREZ29NU2tzSUc1bGR5QmhjbU0wTGxWcGJuUTRLRElwTENCdVpYY2dZWEpqTkM1VmFXNTBPQ2d6S1NrS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXhNREl3TXdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRVNUNpQWdJQ0F2THlCaGMzTmxjblFvWW05NFJDNTJZV3gxWlZzeVhTNWhjMVZwYm5RMk5DZ3BJRDA5UFNBeUtRb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5UWUtJQ0FnSUM4dklHSnZlRVF1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVNodVpYY2dZWEpqTkM1VmFXNTBPQ2d3S1N3Z2JtVjNJR0Z5WXpRdVZXbHVkRGdvTVNrc0lHNWxkeUJoY21NMExsVnBiblE0S0RJcExDQnVaWGNnWVhKak5DNVZhVzUwT0NnektTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNREF4TURJd013b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EWXdDaUFnSUNBdkx5QmhjM05sY25Rb1ltOTRSQzUyWVd4MVpWc3pYUzVoYzFWcGJuUTJOQ2dwSUQwOVBTQXpLUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JuWlhSaWVYUmxDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMU5Bb2dJQ0FnTHk4Z1lYSmpORUp2ZUNncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvNlFYSmpORUp2ZUVOdmJuUnlZV04wTG5SbGMzUkNiM2hTWldaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wUW05NFVtVm1PZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9JV0p2ZUZKbFpqRXVaWGhwYzNSekxDQW5ibThnWkdGMFlTY3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliRzlpSWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1pHRjBZUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGN4Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZbTk0VW1WbU1TNWpjbVZoZEdVb2V5QnphWHBsT2lCVmFXNTBOalFvTXpJcElIMHBLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGMwQ2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhKQ2VYUmxjeUE5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTNOUW9nSUNBZ0x5OGdZMjl1YzNRZ1lYQndRV1JrY21WemN5QTlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxtSjVkR1Z6Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRjM0NpQWdJQ0F2THlCaWIzaFNaV1l4TG5KbGNHeGhZMlVvTUN3Z2MyVnVaR1Z5UW5sMFpYTXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliRzlpSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGM0Q2lBZ0lDQXZMeUJpYjNoU1pXWXhMbkpsYzJsNlpTZzRNREF3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14dllpSUtJQ0FnSUhCMWMyaHBiblFnT0RBd01Bb2dJQ0FnWW05NFgzSmxjMmw2WlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRjNUNpQWdJQ0F2THlCaWIzaFNaV1l4TG5Od2JHbGpaU2d3TENBd0xDQmhjSEJCWkdSeVpYTnpLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmYzNCc2FXTmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBPREFLSUNBZ0lDOHZJR0p2ZUZKbFpqRXVjbVZ3YkdGalpTZzJOQ3dnZG1Gc2RXVXpLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pvWld4c2J5SUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME9ERUtJQ0FnSUM4dklHTnZibk4wSUhCeVpXWnBlQ0E5SUdKdmVGSmxaakV1WlhoMGNtRmpkQ2d3TENBek1pQXFJRElnS3lCMllXeDFaVE11YkdWdVozUm9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQndkWE5vYVc1MElEWTVDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EZ3lDaUFnSUNBdkx5QmhjM05sY25Rb2NISmxabWw0SUQwOVBTQmhjSEJCWkdSeVpYTnpMbU52Ym1OaGRDaHpaVzVrWlhKQ2VYUmxjeWt1WTI5dVkyRjBLSFpoYkhWbE15a3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW1obGJHeHZJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wT0RRS0lDQWdJQzh2SUdKdmVGSmxaakV1WkdWc1pYUmxLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTROd29nSUNBZ0x5OGdZMjl1YzNRZ1czWmhiSFZsTENCbGVHbHpkSE5kSUQwZ1ltOTRVbVZtTVM1dFlYbGlaU2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkc5aUlnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGc0Q2lBZ0lDQXZMeUJoYzNObGNuUW9JV1Y0YVhOMGN5a0tJQ0FnSUdSMWNBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENoMllXeDFaU0E5UFQwZ1FubDBaWE1vSnljcEtRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5Ea3dDaUFnSUNBdkx5QmhjM05sY25Rb1ltOTRVbVZtTVM1blpYUW9leUJrWldaaGRXeDBPaUJ6Wlc1a1pYSkNlWFJsY3lCOUtTQTlQVDBnYzJWdVpHVnlRbmwwWlhNcENpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRreUNpQWdJQ0F2THlCaWIzaFNaV1l4TG5aaGJIVmxJRDBnYzJWdVpHVnlRbmwwWlhNdVkyOXVZMkYwS0dGd2NFRmtaSEpsYzNNcENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Kc2IySWlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wT1RNS0lDQWdJQzh2SUdGemMyVnlkQ2hpYjNoU1pXWXhMbVY0YVhOMGN5d2dKMEpzYjJJZ1pYaHBjM1J6SnlrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Kc2IySWlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalE1TkFvZ0lDQWdMeThnWVhOelpYSjBLR0p2ZUZKbFpqRXViR1Z1WjNSb0lEMDlQU0EyTkNrS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTmdvZ0lDQWdMeThnWW05NFVtVm1JRDBnUW05NFBHSjVkR1Z6UGloN0lHdGxlVG9nSjJKdmVGSmxaaWNnZlNrS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKaWIzaFNaV1lpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wT1RjS0lDQWdJQzh2SUhSb2FYTXVZbTk0VW1WbUxtTnlaV0YwWlNoN0lITnBlbVU2SUZWcGJuUTJOQ2d6TWlrZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEyQ2lBZ0lDQXZMeUJpYjNoU1pXWWdQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUFuWW05NFVtVm1KeUI5S1FvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW1KdmVGSmxaaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalE1T1FvZ0lDQWdMeThnZEdocGN5NWliM2hTWldZdVpHVnNaWFJsS0NrS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EWXpDaUFnSUNBdkx5QjBaWE4wUW05NFVtVm1LQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPanBCY21NMFFtOTRRMjl1ZEhKaFkzUXVjMlYwUW05dmJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEVKdmIydzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNRFlLSUNBZ0lDOHZJSE5sZEVKdmIyd29hVzVrWlhnNklIVnBiblEyTkN3Z2RtRnNkV1U2SUdKdmIyeGxZVzRwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNRGNLSUNBZ0lDOHZJSFJvYVhNdWRHOXZUV0Z1ZVVKdmIyeHpMblpoYkhWbFcybHVaR1Y0WFNBOUlIWmhiSFZsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDOEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTFNZ29nSUNBZ0x5OGdkRzl2VFdGdWVVSnZiMnh6SUQwZ1FtOTRQRVpwZUdWa1FYSnlZWGs4WW05dmJHVmhiaXdnTXpOZk1EQXdQajRvZXlCclpYazZJQ2QwYjI5TllXNTVRbTl2YkhNbklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiMjlOWVc1NVFtOXZiSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8xTURjS0lDQWdJQzh2SUhSb2FYTXVkRzl2VFdGdWVVSnZiMnh6TG5aaGJIVmxXMmx1WkdWNFhTQTlJSFpoYkhWbENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMU1nb2dJQ0FnTHk4Z2RHOXZUV0Z1ZVVKdmIyeHpJRDBnUW05NFBFWnBlR1ZrUVhKeVlYazhZbTl2YkdWaGJpd2dNek5mTURBd1BqNG9leUJyWlhrNklDZDBiMjlOWVc1NVFtOXZiSE1uSUgwcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIyOU5ZVzU1UW05dmJITWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNRGNLSUNBZ0lDOHZJSFJvYVhNdWRHOXZUV0Z1ZVVKdmIyeHpMblpoYkhWbFcybHVaR1Y0WFNBOUlIWmhiSFZsQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOVEEyQ2lBZ0lDQXZMeUJ6WlhSQ2IyOXNLR2x1WkdWNE9pQjFhVzUwTmpRc0lIWmhiSFZsT2lCaWIyOXNaV0Z1S1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02T2tGeVl6UkNiM2hEYjI1MGNtRmpkQzV6ZFcxQ2IyOXNjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMWJVSnZiMnh6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRFd0NpQWdJQ0F2THlCemRXMUNiMjlzY3loemRHOXdRWFJVYjNSaGJEb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TVFvZ0lDQWdMeThnWlc1emRYSmxRblZrWjJWMEtERXpYekF3TUNrS0lDQWdJSEIxYzJocGJuUWdNVE13TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlHVnVjM1Z5WlY5aWRXUm5aWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TWdvZ0lDQWdMeThnYkdWMElIUnZkR0ZzT2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpVeUNpQWdJQ0F2THlCMGIyOU5ZVzU1UW05dmJITWdQU0JDYjNnOFJtbDRaV1JCY25KaGVUeGliMjlzWldGdUxDQXpNMTh3TURBK1BpaDdJR3RsZVRvZ0ozUnZiMDFoYm5sQ2IyOXNjeWNnZlNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5SdmIwMWhibmxDYjI5c2N5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qVXhNd29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0IyWVd4MVpTQnZaaUIwYUdsekxuUnZiMDFoYm5sQ2IyOXNjeTUyWVd4MVpTa2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLQ25OMWJVSnZiMnh6WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qVXhNd29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0IyWVd4MVpTQnZaaUIwYUdsekxuUnZiMDFoYm5sQ2IyOXNjeTUyWVd4MVpTa2dld29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNek1EQXdDaUFnSUNBOENpQWdJQ0JpZWlCemRXMUNiMjlzYzE5aWJHOWphMEF4TUFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMd29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMU1nb2dJQ0FnTHk4Z2RHOXZUV0Z1ZVVKdmIyeHpJRDBnUW05NFBFWnBlR1ZrUVhKeVlYazhZbTl2YkdWaGJpd2dNek5mTURBd1BqNG9leUJyWlhrNklDZDBiMjlOWVc1NVFtOXZiSE1uSUgwcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIyOU5ZVzU1UW05dmJITWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNVE1LSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZG1Gc2RXVWdiMllnZEdocGN5NTBiMjlOWVc1NVFtOXZiSE11ZG1Gc2RXVXBJSHNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TkFvZ0lDQWdMeThnYVdZZ0tIWmhiSFZsS1NCN0NpQWdJQ0JpZWlCemRXMUNiMjlzYzE5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TlFvZ0lDQWdMeThnZEc5MFlXd2dLejBnTVFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRElLQ25OMWJVSnZiMnh6WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TndvZ0lDQWdMeThnYVdZZ0tIUnZkR0ZzSUQwOVBTQnpkRzl3UVhSVWIzUmhiQ2tnZXdvZ0lDQWdaR2xuSURFS0lDQWdJR1JwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhOMWJVSnZiMnh6WDJKc2IyTnJRREV3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2MzVnRRbTl2YkhOZlptOXlYMmhsWVdSbGNrQXlDZ3B6ZFcxQ2IyOXNjMTlpYkc5amEwQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TUFvZ0lDQWdMeThnYzNWdFFtOXZiSE1vYzNSdmNFRjBWRzkwWVd3NklIVnBiblEyTkNrNklIVnBiblEyTkNCN0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFBSUFvQWdKaEFGUWs5WVgwTUVZbXh2WWdoaWIzaE1ZWEpuWlFSaWIzaEJCR0p2ZUVRQllneDBiMjlOWVc1NVFtOXZiSE1FQUFFQ0F3aHRZVzU1U1c1MGN3UVZIM3gxQVRBREJvRUJCQUFDTkRJQ05ESUZhR1ZzYkc4R1ltOTRVbVZtTVJ0QkFJd3hHUlJFTVJoRWdnOEVKL2RyYVFTUkkyRjZCUGNtT1VnRUNieTZYZ1I2RFQzSUJIMERtME1FTzhPeStRVGMzbUZOQk9FNUZ5RUVhRHRjWkFTbHBpYitCSkE1N2Q0RUtMTGlRUVNOenRlYkJCeDM5SlkyR2dDT0R3QllBQk1BQ2dKV0FuSUNxUUxwQXZvRFB3TnVBN2tEM2dBQkJFTUVkQUFuQm9HZElMbElJa01uQ0lHSUlMbElJa01pUXpFWkZERVlGQkJEaWdJQWkvNkJDZ2lMQURJTURVRUFLckdCQnJJUWdRV3lHU2NMc2g0bkM3SWZpLytOQWdBTEFBU3pRdi9iTWdDeUFVTC85U095QVVMLzc0azJHZ0ZKRlNRU1JCYzJHZ0pKSTFrbENFc0JGVWxQQWhKRVN3RlhBZ0EyR2dOSkkxa2xDRXNCRlVsUEFoSkVUd1VXSzB5L0p3VzhTQ2NGU3dXL0tMeElLRXNDdnljRXZFZ25CRXNEdnlxQmtEQzVTSUVxRmlvaEJFOEN1eW9oQklBSUFBQUFBQUFBQUNxN0s3NUVGNEVEQ0JZclRMOHJ2VWdrRWtRbkJiMUlUd1FTUkNpOVJFbExBaEpFSndTOVNFc0VGVW9TUkNnaklycExCVmNBQVJKRVN3SWlDU2hNSXJwTEJDSUpTd1pNSWxnU1JDTkxBdzhqU3dSUEFrMGlTd1FQSWtzRlR3Sk5Td1JNQ1VsTEFneExBa3hOU3dFSktFc0NUd0s2STBzR0R5TkxCMDhDVFNKTEJ3OGlTd2hQQWsxTEIwd0pTVXNDREVzQ1RFMUxDRXNDVHdKU1R3SVNSQ1ZMQlE4bFR3WlBBazFMQWdrb1R3TlBBcm9sU3dVUEpVOEdUd0pOVHdWUEEwOENVaEpFSndRaklycFBCRmNDQVJKRVN3RWlDU2NFVENLNlN3RWlDVXNFVENKWUVrUWpTd0lQSTBzRFR3Sk5Ja3NERHlKTEJFOENUVXNEVEFsSlN3SU1Td0pNVFVzQkNTY0VTd0pQQXJvalN3TVBJMHNFVHdKTklrc0VEeUpMQlU4Q1RVc0VUQWxKU3dJTVN3Sk1UVXNHU3dKUEFsSlBBaEpFZ1FWTEJBK0JCVXNGVHdKTlN3SUpKd1JMQTA4Q3VvRUZTd1FQZ1FWTEJVOENUVXNHU3dOUEFsSVNSQ1ZMQkE4bFR3VlBBazFMQWdrbkJFOERUd0s2SlVzRER5VlBCRThDVFU4RFR3TlBBbElTUkNxOVNJR1FNQkpFSWtNMkdnRkpGU1FTUkJjMkdnSkpGU1FTUkV3a0N5Y0lURThDdXlKRGdZUlNJNGo5cENNbkNMMUZBVVFqU1lHQkJBeEJBQlpIQWlRTEp3aE1KTG9YU3dNSVJRTWlDRVVCUXYvaVN3RVdKd2xNVUxBaVF5dThTQ2NGdkVnb3ZFZ3J2a3dYZ1NwTEFVc0RUWUVxRWtRbkJiNG5ERTRDVFZjQ0FDY05Fa1FvdmljTVRnSk5Wd0lBSncwU1JFd1VSQlJFS3J4SUlrTXFJUVFrdWhjaUNCWXFJUVJQQXJzaVF5dStSQmNpQ0NJSkp3VytSRmNDQUNpK1JDb2hCQ1M2RjA4REZrc0RGUlpYQmdKUEJGQk1nQUlBRkZCTEFSV0JGQWdXVndZQ1VFOENGbEJNVUV4UUp3bE1VTEFpUXl1OVJRRW5CYjFPQWtnb3ZVNERTQ3E5VGdSSWdBRUFJMDhDVkNKUEFsUWxUd0pVZ1FOUEFsUW5DVXhRc0NKREp3cThTQ2NLZ0JOVVpYTjBhVzVuSUhSbGMzUnBibWNnTVRJenZ5Y0tJNEVIdW9BSFZHVnpkR2x1WnhKRUtMeElLSUFIQUFWSVpXeHNiNzhvSllFRnVvQUZTR1ZzYkc4U1JDSkRnQUZrSndlL0p3Y2pWUlJFSndjaVZTSVNSQ2NISlZVbEVrUW5CNEVEVllFREVrUWlReW05UlFFVVJDbUJJTGxFTVFBeUNpa2pTd083S1lIQVB0TXBJMGxMQTlJcGdVQW5EcnNwSTRGRnVrc0JTd05RSnc1UUVrUXB2RWdwdmtrVVJFc0JnQUFTUkVzRFRnSk5Td0lTUkZBcHZFZ3BUTDhwdlVpQlFCSkVKdytCSUxsSUp3KzhTQ0pETmhvQlNSVWtFa1FYTmhvQ1NSVWlFa1FqVTBzQkpBcFBBaVFZSndaTEFpSzZTd0VrREVSTVR3TlVKd1pPQXJzaVF6WWFBVWtWSkJKRUY0SElaU09JKzVrakp3YTlSUUZFSTBtQjZJRUNERUVBS0VjQ0pBcE1KQmduQms4Q0lycE1VMEVBQmtzQklnaEZBa3NCU3dNU1FBQUlTU0lJUlFGQy84OUxBUlluQ1V4UXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
