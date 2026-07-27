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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4BoxContract_0eab2b63
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJveENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkR5bmFtaWNBcnJheUluQVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXJyIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcnIyIiwidHlwZSI6InVpbnQ2NFtdIn1dLCJMYXJnZVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImQiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZiIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiZyIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiaCIsInR5cGUiOiJ1aW50NjQifV0sIlJlYWRCb3hlc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkJveGVzRXhpc3RSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrS2V5cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtTWFueUludHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmRpcmVjdEV4dHJhY3RBbmRSZXBsYWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGJ5dGVbXSxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IlJlYWRCb3hlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJveGVzRXhpc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiQm94ZXNFeGlzdFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsaWNlQm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzRCb3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEJveFJlZiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVCb29scyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRCb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtQm9vbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcEF0VG90YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0OSw2MjQsNjMzLDYzOSw3ODUsOTYxLDk4Nl0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDFdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MiwzNTAsNjQ0LDY5NSw3MDUsODAyLDg0Nyw5NTJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc1LDg5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODUsOTA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNCwzMTEsODI5LDgzOCw4NjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjddLCJlcnJvck1lc3NhZ2UiOiJubyBkYXRhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ01pQTBNRGsyQ2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pDVDFoZlF5SWdJbUpzYjJJaUlDSmliM2hNWVhKblpTSWdJbUp2ZUVFaUlDSmliM2hFSWlBaVlpSWdJblJ2YjAxaGJubENiMjlzY3lJZ01IZ3dNREF4TURJd015QXdlREUxTVdZM1l6YzFJQ0p0WVc1NVNXNTBjeUlnSWpBaUlDSm9aV3hzYnlJZ0ltSnZlRkpsWmlJZ01IZ3dNREF5TXpRek1pQWlORElpSURCNE1EWTRNVEF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRBS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSQ2IzaERiMjUwY21GamRDQmxlSFJsYm1SeklHRnlZelF1UTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFESTBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3lOMlkzTm1JMk9TQXdlRGt4TWpNMk1UZGhJREI0WmpjeU5qTTVORGdnTUhnd09XSmpZbUUxWlNBd2VEZGhNR1F6WkdNNElEQjROMlF3TXpsaU5ETWdNSGd6WW1NellqSm1PU0F3ZUdSalpHVTJNVFJrSURCNFpURXpPVEUzTWpFZ01IZzJPRE5pTldNMk5DQXdlR0UxWVRZeU5tWmxJREI0T1RBek9XVmtaR1VnTUhneU9HSXlaVEkwTVNBd2VEaGtZMlZrTnpsaUlEQjRNV00zTjJZME9UWWdMeThnYldWMGFHOWtJQ0p6WlhSQ2IzaGxjeWgxYVc1ME5qUXNZbmwwWlZ0ZExITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0pqYUdWamEwdGxlWE1vS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU55WldGMFpVMWhibmxKYm5SektDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUk5ZVzU1U1c1MGN5aDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4xYlUxaGJubEpiblJ6S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1SbGJHVjBaVUp2ZUdWektDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGJtUnBjbVZqZEVWNGRISmhZM1JCYm1SU1pYQnNZV05sS0NsMmIybGtJaXdnYldWMGFHOWtJQ0p5WldGa1FtOTRaWE1vS1NoMWFXNTBOalFzWW5sMFpWdGRMSE4wY21sdVp5eDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSmliM2hsYzBWNGFYTjBLQ2tvWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkNraUxDQnRaWFJvYjJRZ0luTnNhV05sUW05NEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGNtTTBRbTk0S0NsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFFtOTRVbVZtS0NsMmIybGtJaXdnYldWMGFHOWtJQ0pqY21WaGRHVkNiMjlzY3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFFtOXZiQ2gxYVc1ME5qUXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZFcxQ2IyOXNjeWgxYVc1ME5qUXBkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5elpYUkNiM2hsYzE5eWIzVjBaVUEySUcxaGFXNWZZMmhsWTJ0TFpYbHpYM0p2ZFhSbFFEY2diV0ZwYmw5amNtVmhkR1ZOWVc1NVNXNTBjMTl5YjNWMFpVQTRJRzFoYVc1ZmMyVjBUV0Z1ZVVsdWRITmZjbTkxZEdWQU9TQnRZV2x1WDNOMWJVMWhibmxKYm5SelgzSnZkWFJsUURFd0lHMWhhVzVmWkdWc1pYUmxRbTk0WlhOZmNtOTFkR1ZBTVRFZ2JXRnBibDlwYm1ScGNtVmpkRVY0ZEhKaFkzUkJibVJTWlhCc1lXTmxYM0p2ZFhSbFFERXlJRzFoYVc1ZmNtVmhaRUp2ZUdWelgzSnZkWFJsUURFeklHMWhhVzVmWW05NFpYTkZlR2x6ZEY5eWIzVjBaVUF4TkNCdFlXbHVYM05zYVdObFFtOTRYM0p2ZFhSbFFERTFJRzFoYVc1ZllYSmpORUp2ZUY5eWIzVjBaVUF4TmlCdFlXbHVYM1JsYzNSQ2IzaFNaV1pmY205MWRHVkFNVGNnYldGcGJsOWpjbVZoZEdWQ2IyOXNjMTl5YjNWMFpVQXhPQ0J0WVdsdVgzTmxkRUp2YjJ4ZmNtOTFkR1ZBTVRrZ2JXRnBibDl6ZFcxQ2IyOXNjMTl5YjNWMFpVQXlNQW9nSUNBZ1pYSnlDZ3B0WVdsdVgzTjFiVUp2YjJ4elgzSnZkWFJsUURJd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5URXdDaUFnSUNBdkx5QnpkVzFDYjI5c2N5aHpkRzl3UVhSVWIzUmhiRG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE1Rb2dJQ0FnTHk4Z1pXNXpkWEpsUW5Wa1oyVjBLREV6WHpBd01Da0tJQ0FnSUhCMWMyaHBiblFnTVRNd01EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJR1Z1YzNWeVpWOWlkV1JuWlhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE1nb2dJQ0FnTHk4Z2JHVjBJSFJ2ZEdGc09pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16VXlDaUFnSUNBdkx5QjBiMjlOWVc1NVFtOXZiSE1nUFNCQ2IzZzhSbWw0WldSQmNuSmhlVHhpYjI5c1pXRnVMQ0F6TTE4d01EQStQaWg3SUd0bGVUb2dKM1J2YjAxaGJubENiMjlzY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUnZiMDFoYm5sQ2IyOXNjeUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TXdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCMllXeDFaU0J2WmlCMGFHbHpMblJ2YjAxaGJubENiMjlzY3k1MllXeDFaU2tnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBeU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qVXhNd29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0IyWVd4MVpTQnZaaUIwYUdsekxuUnZiMDFoYm5sQ2IyOXNjeTUyWVd4MVpTa2dld29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNek1EQXdDaUFnSUNBOENpQWdJQ0JpZWlCdFlXbHVYMkpzYjJOclFETTFDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdKUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelV5Q2lBZ0lDQXZMeUIwYjI5TllXNTVRbTl2YkhNZ1BTQkNiM2c4Um1sNFpXUkJjbkpoZVR4aWIyOXNaV0Z1TENBek0xOHdNREErUGloN0lHdGxlVG9nSjNSdmIwMWhibmxDYjI5c2N5Y2dmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2YjAxaGJubENiMjlzY3lJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE13b2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQjJZV3gxWlNCdlppQjBhR2x6TG5SdmIwMWhibmxDYjI5c2N5NTJZV3gxWlNrZ2V3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSE4zWVhBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5URTBDaUFnSUNBdkx5QnBaaUFvZG1Gc2RXVXBJSHNLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6TVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRFMUNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2MzZGhjQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5URTNDaUFnSUNBdkx5QnBaaUFvZEc5MFlXd2dQVDA5SUhOMGIzQkJkRlJ2ZEdGc0tTQjdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRE1LSUNBZ0lEMDlDaUFnSUNCaWJub2diV0ZwYmw5aWJHOWphMEF6TlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ2JXRnBibDltYjNKZmFHVmhaR1Z5UURJNENncHRZV2x1WDJKc2IyTnJRRE0xT2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8xTVRBS0lDQWdJQzh2SUhOMWJVSnZiMnh6S0hOMGIzQkJkRlJ2ZEdGc09pQjFhVzUwTmpRcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUkNiMjlzWDNKdmRYUmxRREU1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRBMkNpQWdJQ0F2THlCelpYUkNiMjlzS0dsdVpHVjRPaUIxYVc1ME5qUXNJSFpoYkhWbE9pQmliMjlzWldGdUtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRBM0NpQWdJQ0F2THlCMGFHbHpMblJ2YjAxaGJubENiMjlzY3k1MllXeDFaVnRwYm1SbGVGMGdQU0IyWVd4MVpRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0FsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TlRJS0lDQWdJQzh2SUhSdmIwMWhibmxDYjI5c2N5QTlJRUp2ZUR4R2FYaGxaRUZ5Y21GNVBHSnZiMnhsWVc0c0lETXpYekF3TUQ0K0tIc2dhMlY1T2lBbmRHOXZUV0Z1ZVVKdmIyeHpKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZEc5dlRXRnVlVUp2YjJ4eklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5UQTNDaUFnSUNBdkx5QjBhR2x6TG5SdmIwMWhibmxDYjI5c2N5NTJZV3gxWlZ0cGJtUmxlRjBnUFNCMllXeDFaUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOVElLSUNBZ0lDOHZJSFJ2YjAxaGJubENiMjlzY3lBOUlFSnZlRHhHYVhobFpFRnljbUY1UEdKdmIyeGxZVzRzSURNelh6QXdNRDQrS0hzZ2EyVjVPaUFuZEc5dlRXRnVlVUp2YjJ4ekp5QjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkRzl2VFdGdWVVSnZiMnh6SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRBM0NpQWdJQ0F2THlCMGFHbHpMblJ2YjAxaGJubENiMjlzY3k1MllXeDFaVnRwYm1SbGVGMGdQU0IyWVd4MVpRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVd05nb2dJQ0FnTHk4Z2MyVjBRbTl2YkNocGJtUmxlRG9nZFdsdWREWTBMQ0IyWVd4MVpUb2dZbTl2YkdWaGJpa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWQ2IyOXNjMTl5YjNWMFpVQXhPRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0xTWdvZ0lDQWdMeThnZEc5dlRXRnVlVUp2YjJ4eklEMGdRbTk0UEVacGVHVmtRWEp5WVhrOFltOXZiR1ZoYml3Z016TmZNREF3UGo0b2V5QnJaWGs2SUNkMGIyOU5ZVzU1UW05dmJITW5JSDBwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjI5TllXNTVRbTl2YkhNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvMU1ETUtJQ0FnSUM4dklIUm9hWE11ZEc5dlRXRnVlVUp2YjJ4ekxtTnlaV0YwWlNncENpQWdJQ0J3ZFhOb2FXNTBJRFF4TWpVS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOVEF5Q2lBZ0lDQXZMeUJqY21WaGRHVkNiMjlzY3lncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRUp2ZUZKbFpsOXliM1YwWlVBeE56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTJOZ29nSUNBZ0x5OGdZWE56WlhKMEtDRmliM2hTWldZeExtVjRhWE4wY3l3Z0oyNXZJR1JoZEdFbktRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlteHZZaUlLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2SUdSaGRHRUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTNNUW9nSUNBZ0x5OGdZWE56WlhKMEtHSnZlRkpsWmpFdVkzSmxZWFJsS0hzZ2MybDZaVG9nVldsdWREWTBLRE15S1NCOUtTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTNOQW9nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5UW5sMFpYTWdQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME56VUtJQ0FnSUM4dklHTnZibk4wSUdGd2NFRmtaSEpsYzNNZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3k1aWVYUmxjd29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEzTndvZ0lDQWdMeThnWW05NFVtVm1NUzV5WlhCc1lXTmxLREFzSUhObGJtUmxja0o1ZEdWektRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlteHZZaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTNPQW9nSUNBZ0x5OGdZbTk0VW1WbU1TNXlaWE5wZW1Vb09EQXdNQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0J3ZFhOb2FXNTBJRGd3TURBS0lDQWdJR0p2ZUY5eVpYTnBlbVVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEzT1FvZ0lDQWdMeThnWW05NFVtVm1NUzV6Y0d4cFkyVW9NQ3dnTUN3Z1lYQndRV1JrY21WemN5a0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYM053YkdsalpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EZ3dDaUFnSUNBdkx5QmliM2hTWldZeExuSmxjR3hoWTJVb05qUXNJSFpoYkhWbE15a0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlhR1ZzYkc4aUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRneENpQWdJQ0F2THlCamIyNXpkQ0J3Y21WbWFYZ2dQU0JpYjNoU1pXWXhMbVY0ZEhKaFkzUW9NQ3dnTXpJZ0tpQXlJQ3NnZG1Gc2RXVXpMbXhsYm1kMGFDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2NIVnphR2x1ZENBMk9Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRNE1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hCeVpXWnBlQ0E5UFQwZ1lYQndRV1JrY21WemN5NWpiMjVqWVhRb2MyVnVaR1Z5UW5sMFpYTXBMbU52Ym1OaGRDaDJZV3gxWlRNcEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pvWld4c2J5SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGcwQ2lBZ0lDQXZMeUJpYjNoU1pXWXhMbVJsYkdWMFpTZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliRzlpSWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME9EY0tJQ0FnSUM4dklHTnZibk4wSUZ0MllXeDFaU3dnWlhocGMzUnpYU0E5SUdKdmVGSmxaakV1YldGNVltVW9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTRPQW9nSUNBZ0x5OGdZWE56WlhKMEtDRmxlR2x6ZEhNcENpQWdJQ0JrZFhBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRnNUNpQWdJQ0F2THlCaGMzTmxjblFvZG1Gc2RXVWdQVDA5SUVKNWRHVnpLQ2NuS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dKdmVGSmxaakV1WjJWMEtIc2daR1ZtWVhWc2REb2djMlZ1WkdWeVFubDBaWE1nZlNrZ1BUMDlJSE5sYm1SbGNrSjVkR1Z6S1FvZ0lDQWdaR2xuSURNS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalE1TWdvZ0lDQWdMeThnWW05NFVtVm1NUzUyWVd4MVpTQTlJSE5sYm1SbGNrSjVkR1Z6TG1OdmJtTmhkQ2hoY0hCQlpHUnlaWE56S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJHOWlJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkc5aUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGt6Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZbTk0VW1WbU1TNWxlR2x6ZEhNc0lDZENiRzlpSUdWNGFYTjBjeWNwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkc5aUlnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBPVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaGliM2hTWldZeExteGxibWQwYUNBOVBUMGdOalFwQ2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORFlLSUNBZ0lDOHZJR0p2ZUZKbFppQTlJRUp2ZUR4aWVYUmxjejRvZXlCclpYazZJQ2RpYjNoU1pXWW5JSDBwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWW05NFVtVm1JZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGszQ2lBZ0lDQXZMeUIwYUdsekxtSnZlRkpsWmk1amNtVmhkR1VvZXlCemFYcGxPaUJWYVc1ME5qUW9NeklwSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOZ29nSUNBZ0x5OGdZbTk0VW1WbUlEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dKMkp2ZUZKbFppY2dmU2tLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0ppYjNoU1pXWWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBPVGtLSUNBZ0lDOHZJSFJvYVhNdVltOTRVbVZtTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMk13b2dJQ0FnTHk4Z2RHVnpkRUp2ZUZKbFppZ3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTkVKdmVGOXliM1YwWlVBeE5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTFOZ29nSUNBZ0x5OGdZbTk0UkM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxOMFlYUnBZMEZ5Y21GNUtHNWxkeUJoY21NMExsVnBiblE0S0RBcExDQnVaWGNnWVhKak5DNVZhVzUwT0NneEtTd2dibVYzSUdGeVl6UXVWV2x1ZERnb01pa3NJRzVsZHlCaGNtTTBMbFZwYm5RNEtETXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmtJZ29nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3TURFd01qQXpDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBd01UQXlNRE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalExTndvZ0lDQWdMeThnWVhOelpYSjBLR0p2ZUVRdWRtRnNkV1ZiTUYwdVlYTlZhVzUwTmpRb0tTQTlQVDBnTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMU5nb2dJQ0FnTHk4Z1ltOTRSQzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbE4wWVhScFkwRnljbUY1S0c1bGR5QmhjbU0wTGxWcGJuUTRLREFwTENCdVpYY2dZWEpqTkM1VmFXNTBPQ2d4S1N3Z2JtVjNJR0Z5WXpRdVZXbHVkRGdvTWlrc0lHNWxkeUJoY21NMExsVnBiblE0S0RNcEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdNREV3TWpBekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoaWIzaEVMblpoYkhWbFd6RmRMbUZ6VldsdWREWTBLQ2tnUFQwOUlERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWjJWMFlubDBaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTFOZ29nSUNBZ0x5OGdZbTk0UkM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxOMFlYUnBZMEZ5Y21GNUtHNWxkeUJoY21NMExsVnBiblE0S0RBcExDQnVaWGNnWVhKak5DNVZhVzUwT0NneEtTd2dibVYzSUdGeVl6UXVWV2x1ZERnb01pa3NJRzVsZHlCaGNtTTBMbFZwYm5RNEtETXBLUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3TURFd01qQXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaGliM2hFTG5aaGJIVmxXekpkTG1GelZXbHVkRFkwS0NrZ1BUMDlJRElwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalExTmdvZ0lDQWdMeThnWW05NFJDNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsTjBZWFJwWTBGeWNtRjVLRzVsZHlCaGNtTTBMbFZwYm5RNEtEQXBMQ0J1WlhjZ1lYSmpOQzVWYVc1ME9DZ3hLU3dnYm1WM0lHRnlZelF1VldsdWREZ29NaWtzSUc1bGR5QmhjbU0wTGxWcGJuUTRLRE1wS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd01ERXdNakF6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTmpBS0lDQWdJQzh2SUdGemMyVnlkQ2hpYjNoRUxuWmhiSFZsV3pOZExtRnpWV2x1ZERZMEtDa2dQVDA5SURNcENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lHZGxkR0o1ZEdVS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFUwQ2lBZ0lDQXZMeUJoY21NMFFtOTRLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6YkdsalpVSnZlRjl5YjNWMFpVQXhOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEwTndvZ0lDQWdMeThnWW05NE1DNTJZV3gxWlNBOUlFSjVkR1Z6S0NkVVpYTjBhVzVuSUhSbGMzUnBibWNnTVRJekp5a0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSXdJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpTUNJS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkdWemRHbHVaeUIwWlhOMGFXNW5JREV5TXlJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTBPQW9nSUNBZ0x5OGdZWE56WlhKMEtHSnZlREF1ZG1Gc2RXVXVjMnhwWTJVb01Dd2dOeWtnUFQwOUlFSjVkR1Z6S0NkVVpYTjBhVzVuSnlrcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaU1DSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUmxjM1JwYm1jaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHSnZlRU1nUFNCQ2IzZzhZWEpqTkM1VGRISStLSHNnYTJWNU9pQW5RazlZWDBNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkNUMWhmUXlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMU1Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoRExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVUzUnlLQ2RJWld4c2J5Y3BDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORFV3Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRU11ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVUZEhJb0owaGxiR3h2SnlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EVTBPRFkxTm1NMll6Wm1DaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalExTVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRReTUyWVd4MVpTNWllWFJsY3k1emJHbGpaU2d5TENBeE1Da2dQVDA5SUVKNWRHVnpLQ2RJWld4c2J5Y3BLUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTR1ZzYkc4aUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5EVUtJQ0FnSUM4dklITnNhV05sUW05NEtDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWliM2hsYzBWNGFYTjBYM0p2ZFhSbFFERTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF4Q2lBZ0lDQXZMeUJpYjNoQklEMGdRbTk0UEhWcGJuUTJORDRvZXlCclpYazZJQ2RpYjNoQkp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZbTk0UVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0MGFHbHpMbUp2ZUVFdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVJdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVNdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUV4aGNtZGxMbVY0YVhOMGMxMGdZWE1nWTI5dWMzUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReUNpQWdJQ0F2THlCaWIzaENJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRReUNpQWdJQ0F2THlCeVpYUjFjbTRnVzNSb2FYTXVZbTk0UVM1bGVHbHpkSE1zSUhSb2FYTXVZbTk0UWk1bGVHbHpkSE1zSUhSb2FYTXVZbTk0UXk1bGVHbHpkSE1zSUhSb2FYTXVZbTk0VEdGeVoyVXVaWGhwYzNSelhTQmhjeUJqYjI1emRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEwTWdvZ0lDQWdMeThnY21WMGRYSnVJRnQwYUdsekxtSnZlRUV1WlhocGMzUnpMQ0IwYUdsekxtSnZlRUl1WlhocGMzUnpMQ0IwYUdsekxtSnZlRU11WlhocGMzUnpMQ0IwYUdsekxtSnZlRXhoY21kbExtVjRhWE4wYzEwZ1lYTWdZMjl1YzNRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEzQ2lBZ0lDQXZMeUJpYjNoTVlYSm5aU0E5SUVKdmVEeE1ZWEpuWlZOMGNuVmpkRDRvZXlCclpYazZJQ2RpYjNoTVlYSm5aU2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVFeGhjbWRsSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRReUNpQWdJQ0F2THlCeVpYUjFjbTRnVzNSb2FYTXVZbTk0UVM1bGVHbHpkSE1zSUhSb2FYTXVZbTk0UWk1bGVHbHpkSE1zSUhSb2FYTXVZbTk0UXk1bGVHbHpkSE1zSUhSb2FYTXVZbTk0VEdGeVoyVXVaWGhwYzNSelhTQmhjeUJqYjI1emRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTkRFS0lDQWdJQzh2SUdKdmVHVnpSWGhwYzNRb0tUb2djbVZoWkc5dWJIa2dXMkp2YjJ4bFlXNHNJR0p2YjJ4bFlXNHNJR0p2YjJ4bFlXNHNJR0p2YjJ4bFlXNWRJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psWVdSQ2IzaGxjMTl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTVFvZ0lDQWdMeThnWW05NFFTQTlJRUp2ZUR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW05NFFTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2ZUVFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvMU1qWUtJQ0FnSUM4dklISmxkSFZ5YmlCVmFXNTBOalFvWW05NExuWmhiSFZsSUNzZ01Ta0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRNNENpQWdJQ0F2THlCeVpYUjFjbTRnVzFWcGJuUTJOQ2huWlhSQ2IzaFdZV3gxWlZCc2RYTXhLSFJvYVhNdVltOTRRU2tnTFNBeEtTd2dkR2hwY3k1aWIzaENMblpoYkhWbExtNWhkR2wyWlN3Z2RHaHBjeTVpYjNoRExuWmhiSFZsTENCMGFHbHpMbUp2ZUV4aGNtZGxMblpoYkhWbExtVmRJR0Z6SUdOdmJuTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReUNpQWdJQ0F2THlCaWIzaENJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRNNENpQWdJQ0F2THlCeVpYUjFjbTRnVzFWcGJuUTJOQ2huWlhSQ2IzaFdZV3gxWlZCc2RYTXhLSFJvYVhNdVltOTRRU2tnTFNBeEtTd2dkR2hwY3k1aWIzaENMblpoYkhWbExtNWhkR2wyWlN3Z2RHaHBjeTVpYjNoRExuWmhiSFZsTENCMGFHbHpMbUp2ZUV4aGNtZGxMblpoYkhWbExtVmRJR0Z6SUdOdmJuTjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNd29nSUNBZ0x5OGdZbTk0UXlBOUlFSnZlRHhoY21NMExsTjBjajRvZXlCclpYazZJQ2RDVDFoZlF5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0pQV0Y5RElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETTRDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNoblpYUkNiM2hXWVd4MVpWQnNkWE14S0hSb2FYTXVZbTk0UVNrZ0xTQXhLU3dnZEdocGN5NWliM2hDTG5aaGJIVmxMbTVoZEdsMlpTd2dkR2hwY3k1aWIzaERMblpoYkhWbExDQjBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxMbVZkSUdGeklHTnZibk4wQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRM0NpQWdJQ0F2THlCaWIzaE1ZWEpuWlNBOUlFSnZlRHhNWVhKblpWTjBjblZqZEQ0b2V5QnJaWGs2SUNkaWIzaE1ZWEpuWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSnZlRXhoY21kbElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETTRDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNoblpYUkNiM2hXWVd4MVpWQnNkWE14S0hSb2FYTXVZbTk0UVNrZ0xTQXhLU3dnZEdocGN5NWliM2hDTG5aaGJIVmxMbTVoZEdsMlpTd2dkR2hwY3k1aWIzaERMblpoYkhWbExDQjBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxMbVZkSUdGeklHTnZibk4wQ2lBZ0lDQnBiblJqSURRZ0x5OGdOREE1TmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME16Y0tJQ0FnSUM4dklISmxZV1JDYjNobGN5Z3BPaUJ5WldGa2IyNXNlU0JiZFdsdWREWTBMQ0JpZVhSbGN5d2dZWEpqTkM1VGRISXNJSFZwYm5RMk5GMGdld29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TVRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5TUFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmx1WkdseVpXTjBSWGgwY21GamRFRnVaRkpsY0d4aFkyVmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGNLSUNBZ0lDOHZJR0p2ZUV4aGNtZGxJRDBnUW05NFBFeGhjbWRsVTNSeWRXTjBQaWg3SUd0bGVUb2dKMkp2ZUV4aGNtZGxKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NFRHRnlaMlVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTXpJdE5ETXpDaUFnSUNBdkx5QmpiMjV6ZENCc1lYSm5aU0E5SUdOc2IyNWxLSFJvYVhNdVltOTRUR0Z5WjJVdWRtRnNkV1VwQ2lBZ0lDQXZMeUJzWVhKblpTNWxJQ3M5SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXpNd29nSUNBZ0x5OGdiR0Z5WjJVdVpTQXJQU0F4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTNDaUFnSUNBdkx5QmliM2hNWVhKblpTQTlJRUp2ZUR4TVlYSm5aVk4wY25WamRENG9leUJyWlhrNklDZGliM2hNWVhKblpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUV4aGNtZGxJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE16TFRRek5Bb2dJQ0FnTHk4Z2JHRnlaMlV1WlNBclBTQXhDaUFnSUNBdkx5QjBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxJRDBnWTJ4dmJtVW9iR0Z5WjJVcENpQWdJQ0JwYm5SaklEUWdMeThnTkRBNU5nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETXhDaUFnSUNBdkx5QnBibVJwY21WamRFVjRkSEpoWTNSQmJtUlNaWEJzWVdObEtDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtaV3hsZEdWQ2IzaGxjMTl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTVFvZ0lDQWdMeThnWW05NFFTQTlJRUp2ZUR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW05NFFTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2ZUVFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1Ua0tJQ0FnSUM4dklIUm9hWE11WW05NFFTNWtaV3hsZEdVb0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORElLSUNBZ0lDOHZJR0p2ZUVJZ1BTQkNiM2c4WVhKak5DNUVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuWWljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltSWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNakFLSUNBZ0lDOHZJSFJvYVhNdVltOTRRaTVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF5TVFvZ0lDQWdMeThnZEdocGN5NWliM2hETG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1Rb2dJQ0FnTHk4Z1ltOTRRU0E5SUVKdmVEeDFhVzUwTmpRK0tIc2dhMlY1T2lBblltOTRRU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVFRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNaklLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFRXVaMlYwS0hzZ1pHVm1ZWFZzZERvZ1ZXbHVkRFkwS0RReUtTQjlLU0E5UFQwZ05ESXBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQndkWE5vYVc1MElEUXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRE1LSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjSFZ6YUdsdWRDQTBNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF5Q2lBZ0lDQXZMeUJpYjNoQ0lEMGdRbTk0UEdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6UGloN0lHdGxlVG9nSjJJbklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREl6Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaENMbWRsZENoN0lHUmxabUYxYkhRNklHNWxkeUJoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWhDZVhSbGN5Z25OREluS1NrZ2ZTa3VibUYwYVhabElEMDlQU0JDZVhSbGN5Z25OREluS1NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjRNREF3TWpNME16SUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0kwTWlJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME13b2dJQ0FnTHk4Z1ltOTRReUE5SUVKdmVEeGhjbU0wTGxOMGNqNG9leUJyWlhrNklDZENUMWhmUXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrSlBXRjlESWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRJMENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hETG1kbGRDaDdJR1JsWm1GMWJIUTZJRzVsZHlCaGNtTTBMbE4wY2lnbk5ESW5LU0I5S1M1dVlYUnBkbVVnUFQwOUlDYzBNaWNwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEQXdNREl6TkRNeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWlORElpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTWpjS0lDQWdJQzh2SUdGemMyVnlkQ2doWVVWNGFYTjBjeWtLSUNBZ0lITjNZWEFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZU0E5UFQwZ01Da0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTNDaUFnSUNBdkx5QmliM2hNWVhKblpTQTlJRUp2ZUR4TVlYSm5aVk4wY25WamRENG9leUJyWlhrNklDZGliM2hNWVhKblpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUV4aGNtZGxJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREk1Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRXhoY21kbExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXhPQW9nSUNBZ0x5OGdaR1ZzWlhSbFFtOTRaWE1vS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOMWJVMWhibmxKYm5SelgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ERXdDaUFnSUNBdkx5Qmxibk4xY21WQ2RXUm5aWFFvTVRCZk5UQXdLUW9nSUNBZ2NIVnphR2x1ZENBeE1EVXdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdOaGJHeHpkV0lnWlc1emRYSmxYMkoxWkdkbGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ERXhDaUFnSUNBdkx5QnNaWFFnZEc5MFlXd2dQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGdLSUNBZ0lDOHZJRzFoYm5sSmJuUnpJRDBnUW05NFBFMWhibmxKYm5SelBpaDdJR3RsZVRvZ0oyMWhibmxKYm5Sekp5QjlLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWliV0Z1ZVVsdWRITWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNVElLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZG1Gc0lHOW1JSFJvYVhNdWJXRnVlVWx1ZEhNdWRtRnNkV1VwSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NncHRZV2x1WDJadmNsOW9aV0ZrWlhKQU5UWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNVElLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZG1Gc0lHOW1JSFJvYVhNdWJXRnVlVWx1ZEhNdWRtRnNkV1VwSUhzS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFNVE1LSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURVNENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGdLSUNBZ0lDOHZJRzFoYm5sSmJuUnpJRDBnUW05NFBFMWhibmxKYm5SelBpaDdJR3RsZVRvZ0oyMWhibmxKYm5Sekp5QjlLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWliV0Z1ZVVsdWRITWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNVElLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZG1Gc0lHOW1JSFJvYVhNdWJXRnVlVWx1ZEhNdWRtRnNkV1VwSUhzS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ERXpDaUFnSUNBdkx5QjBiM1JoYkNBOUlIUnZkR0ZzSUNzZ2RtRnNDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0ExTmdvS2JXRnBibDloWm5SbGNsOW1iM0pBTlRnNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRd09Rb2dJQ0FnTHk4Z2MzVnRUV0Z1ZVVsdWRITW9LU0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM05sZEUxaGJubEpiblJ6WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTURVS0lDQWdJQzh2SUhObGRFMWhibmxKYm5SektHbHVaR1Y0T2lCMWFXNTBOalFzSUhaaGJIVmxPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXdOZ29nSUNBZ0x5OGdkR2hwY3k1dFlXNTVTVzUwY3k1MllXeDFaVnRwYm1SbGVGMGdQU0IyWVd4MVpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wT0FvZ0lDQWdMeThnYldGdWVVbHVkSE1nUFNCQ2IzZzhUV0Z1ZVVsdWRITStLSHNnYTJWNU9pQW5iV0Z1ZVVsdWRITW5JSDBwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p0WVc1NVNXNTBjeUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF3TmdvZ0lDQWdMeThnZEdocGN5NXRZVzU1U1c1MGN5NTJZV3gxWlZ0cGJtUmxlRjBnUFNCMllXeDFaUW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREExQ2lBZ0lDQXZMeUJ6WlhSTllXNTVTVzUwY3locGJtUmxlRG9nZFdsdWREWTBMQ0IyWVd4MVpUb2dkV2x1ZERZMEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlUxaGJubEpiblJ6WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRnS0lDQWdJQzh2SUcxaGJubEpiblJ6SUQwZ1FtOTRQRTFoYm5sSmJuUnpQaWg3SUd0bGVUb2dKMjFoYm5sSmJuUnpKeUI5S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYldGdWVVbHVkSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTURJS0lDQWdJQzh2SUhSb2FYTXViV0Z1ZVVsdWRITXVZM0psWVhSbEtDa0tJQ0FnSUhCMWMyaHBiblFnTkRFd05Bb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTURFS0lDQWdJQzh2SUdOeVpXRjBaVTFoYm5sSmJuUnpLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqYUdWamEwdGxlWE5mY205MWRHVkFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak01TkFvZ0lDQWdMeThnWTJobFkydExaWGx6S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUkNiM2hsYzE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpVNUNpQWdJQ0F2THlCelpYUkNiM2hsY3loaE9pQjFhVzUwTmpRc0lHSTZJR0o1ZEdWekxDQmpPaUJoY21NMExsTjBjaWtnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTJNUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaEJMblpoYkhWbElEMGdZUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ERUtJQ0FnSUM4dklHSnZlRUVnUFNCQ2IzZzhkV2x1ZERZMFBpaDdJR3RsZVRvZ0oySnZlRUVuSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaWIzaEJJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNell4Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRUV1ZG1Gc2RXVWdQU0JoQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ESUtJQ0FnSUM4dklHSnZlRUlnUFNCQ2IzZzhZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5ZaWNnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1JaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5qSUtJQ0FnSUM4dklIUm9hWE11WW05NFFpNTJZV3gxWlNBOUlHUjVibUZ0YVdOQ2VYUmxjd29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRJS0lDQWdJQzh2SUdKdmVFSWdQU0JDYjNnOFlYSmpOQzVFZVc1aGJXbGpRbmwwWlhNK0tIc2dhMlY1T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TmpJS0lDQWdJQzh2SUhSb2FYTXVZbTk0UWk1MllXeDFaU0E5SUdSNWJtRnRhV05DZVhSbGN3b2dJQ0FnWkdsbklEVUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNell6Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRU11ZG1Gc2RXVWdQU0JqQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME13b2dJQ0FnTHk4Z1ltOTRReUE5SUVKdmVEeGhjbU0wTGxOMGNqNG9leUJyWlhrNklDZENUMWhmUXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrSlBXRjlESWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpZekNpQWdJQ0F2THlCMGFHbHpMbUp2ZUVNdWRtRnNkV1VnUFNCakNpQWdJQ0JrYVdjZ01nb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEwQ2lBZ0lDQXZMeUJpYjNoRUlEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dKMkp2ZUVRbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmliM2hFSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpZMENpQWdJQ0F2THlCMGFHbHpMbUp2ZUVRdWRtRnNkV1VnUFNCa2VXNWhiV2xqUW5sMFpYTXVibUYwYVhabENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdZbTk0UkNBOUlFSnZlRHhpZVhSbGN6NG9leUJyWlhrNklDZGliM2hFSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVltOTRSQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTkFvZ0lDQWdMeThnZEdocGN5NWliM2hFTG5aaGJIVmxJRDBnWkhsdVlXMXBZMEo1ZEdWekxtNWhkR2wyWlFvZ0lDQWdaR2xuSURNS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOd29nSUNBZ0x5OGdZbTk0VEdGeVoyVWdQU0JDYjNnOFRHRnlaMlZUZEhKMVkzUStLSHNnYTJWNU9pQW5ZbTk0VEdGeVoyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppYjNoTVlYSm5aU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTlFvZ0lDQWdMeThnZEdocGN5NWliM2hNWVhKblpTNWpjbVZoZEdVb0tRb2dJQ0FnY0hWemFHbHVkQ0EyTVRZd0NpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTmdvZ0lDQWdMeThnZEdocGN5NWliM2hNWVhKblpTNTJZV3gxWlM1bElEMGdORElLSUNBZ0lIQjFjMmhwYm5RZ05ESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOd29nSUNBZ0x5OGdZbTk0VEdGeVoyVWdQU0JDYjNnOFRHRnlaMlZUZEhKMVkzUStLSHNnYTJWNU9pQW5ZbTk0VEdGeVoyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppYjNoTVlYSm5aU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTmdvZ0lDQWdMeThnZEdocGN5NWliM2hNWVhKblpTNTJZV3gxWlM1bElEMGdORElLSUNBZ0lHbHVkR01nTkNBdkx5QTBNRGsyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOd29nSUNBZ0x5OGdZbTk0VEdGeVoyVWdQU0JDYjNnOFRHRnlaMlZUZEhKMVkzUStLSHNnYTJWNU9pQW5ZbTk0VEdGeVoyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppYjNoTVlYSm5aU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTndvZ0lDQWdMeThnZEdocGN5NWliM2hNWVhKblpTNXlaWEJzWVdObEtHRnlZelF1YzJsNlpVOW1QRUo1ZEdWek1UQXlORDRvS1NBcUlEUXNJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZzBNaWt1WW5sMFpYTXBDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReENpQWdJQ0F2THlCaWIzaEJJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEJKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFFTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTNNUW9nSUNBZ0x5OGdkR2hwY3k1aWIzaEJMblpoYkhWbElDczlJRE1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1Rb2dJQ0FnTHk4Z1ltOTRRU0E5SUVKdmVEeDFhVzUwTmpRK0tIc2dhMlY1T2lBblltOTRRU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVFRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOekVLSUNBZ0lDOHZJSFJvYVhNdVltOTRRUzUyWVd4MVpTQXJQU0F6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ERUtJQ0FnSUM4dklHSnZlRUVnUFNCQ2IzZzhkV2x1ZERZMFBpaDdJR3RsZVRvZ0oySnZlRUVuSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaWIzaEJJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemMwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEJMbXhsYm1kMGFDQTlQVDBnT0NrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1nb2dJQ0FnTHk4Z1ltOTRRaUE5SUVKdmVEeGhjbU0wTGtSNWJtRnRhV05DZVhSbGN6NG9leUJyWlhrNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNM05Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UWk1c1pXNW5kR2dnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTVpZVhSbGN5NXNaVzVuZEdncENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCd2IzQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRekNpQWdJQ0F2THlCaWIzaERJRDBnUW05NFBHRnlZelF1VTNSeVBpaDdJR3RsZVRvZ0owSlBXRjlESnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVFrOVlYME1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TnpZS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRU11YkdWdVozUm9JRDA5UFNCakxtSjVkR1Z6TG14bGJtZDBhQ2tLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRRS0lDQWdJQzh2SUdKdmVFUWdQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUFuWW05NFJDY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUp2ZUVRaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek56Y0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUVRdWJHVnVaM1JvSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbXhsYm1kMGFDa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lIQnZjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF6Q2lBZ0lDQXZMeUJpYjNoRElEMGdRbTk0UEdGeVl6UXVVM1J5UGloN0lHdGxlVG9nSjBKUFdGOURKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpUWs5WVgwTWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pPREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFTXVkbUZzZFdVdVlubDBaWE11WVhRb01Da2dQVDA5SUdNdVlubDBaWE11WVhRb01Da3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaWGgwY21GamRDQXdJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00TVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRReTUyWVd4MVpTNWllWFJsY3k1aGRDZ3RNU2tnUFQwOUlHTXVZbmwwWlhNdVlYUW9MVEVwS1FvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJR0p2ZUVNZ1BTQkNiM2c4WVhKak5DNVRkSEkrS0hzZ2EyVjVPaUFuUWs5WVgwTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pDVDFoZlF5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTRNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFF5NTJZV3gxWlM1aWVYUmxjeTVoZENndE1Ta2dQVDA5SUdNdVlubDBaWE11WVhRb0xURXBLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNNE1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UXk1MllXeDFaUzVpZVhSbGN5NXpiR2xqWlNnd0xDQXRNU2tnUFQwOUlHTXVZbmwwWlhNdWMyeHBZMlVvTUN3Z0xURXBLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdScFp5QXpDaUFnSUNBK1BRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1JwWnlBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdScFp5QTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00TWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRReTUyWVd4MVpTNWllWFJsY3k1emJHbGpaU2d3TENBdE1Ta2dQVDA5SUdNdVlubDBaWE11YzJ4cFkyVW9NQ3dnTFRFcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2FXY2dOZ29nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrYVdjZ053b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmthV2NnTndvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCa2FXY2dPQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QTNDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek9ETUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUVNdWRtRnNkV1V1WW5sMFpYTXVjMnhwWTJVb01Dd2dNaWtnUFQwOUlHTXVZbmwwWlhNdWMyeHBZMlVvTUN3Z01pa3BDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnWkdsbklEVUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklESUtJQ0FnSUMwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME13b2dJQ0FnTHk4Z1ltOTRReUE5SUVKdmVEeGhjbU0wTGxOMGNqNG9leUJyWlhrNklDZENUMWhmUXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrSlBXRjlESWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpnekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hETG5aaGJIVmxMbUo1ZEdWekxuTnNhV05sS0RBc0lESXBJRDA5UFNCakxtSjVkR1Z6TG5Oc2FXTmxLREFzSURJcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdaR2xuSURVS0lDQWdJRDQ5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTBDaUFnSUNBdkx5QmliM2hFSUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0oySnZlRVFuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaWIzaEVJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemcyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEVMblpoYkhWbExtRjBLREFwSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbUYwS0RBcEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JsZUhSeVlXTjBJRElnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpnM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hFTG5aaGJIVmxMbUYwS0MweEtTQTlQVDBnWkhsdVlXMXBZMEo1ZEdWekxtNWhkR2wyWlM1aGRDZ3RNU2twQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdZbTk0UkNBOUlFSnZlRHhpZVhSbGN6NG9leUJyWlhrNklDZGliM2hFSnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVltOTRSQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00TndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRSQzUyWVd4MVpTNWhkQ2d0TVNrZ1BUMDlJR1I1Ym1GdGFXTkNlWFJsY3k1dVlYUnBkbVV1WVhRb0xURXBLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UkM1MllXeDFaUzV6YkdsalpTZ3dMQ0F0TVNrZ1BUMDlJR1I1Ym1GdGFXTkNlWFJsY3k1dVlYUnBkbVV1YzJ4cFkyVW9NQ3dnTFRFcEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0ErUFFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdScFp5QXpDaUFnSUNBK1BRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1JwWnlBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORFFLSUNBZ0lDOHZJR0p2ZUVRZ1BTQkNiM2c4WW5sMFpYTStLSHNnYTJWNU9pQW5ZbTk0UkNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSnZlRVFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RnS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRVF1ZG1Gc2RXVXVjMnhwWTJVb01Dd2dMVEVwSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbk5zYVdObEtEQXNJQzB4S1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkdsbklETUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaR2xuSURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1pHbG5JRFFLSUNBZ0lENDlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklEVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURZS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpnNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hFTG5aaGJIVmxMbk5zYVdObEtEQXNJRFVwSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbk5zYVdObEtEQXNJRFVwS1FvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNCa2FXY2dOQW9nSUNBZ1BqMEtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdaR2xuSURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdMUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEwQ2lBZ0lDQXZMeUJpYjNoRUlEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dKMkp2ZUVRbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmliM2hFSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpnNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hFTG5aaGJIVmxMbk5zYVdObEtEQXNJRFVwSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbk5zYVdObEtEQXNJRFVwS1FvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdaR2xuSURRS0lDQWdJRDQ5Q2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUdScFp5QTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklEWUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak01TUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRSQzUyWVd4MVpTNXpiR2xqWlNnd0xDQlZhVzUwTmpRb01pa3BJRDA5UFNCa2VXNWhiV2xqUW5sMFpYTXVibUYwYVhabExuTnNhV05sS0RBc0lGVnBiblEyTkNneUtTa3BDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnWkdsbklEUUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklESUtJQ0FnSUMwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME5Bb2dJQ0FnTHk4Z1ltOTRSQ0E5SUVKdmVEeGllWFJsY3o0b2V5QnJaWGs2SUNkaWIzaEVKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWW05NFJDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTVNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFJDNTJZV3gxWlM1emJHbGpaU2d3TENCVmFXNTBOalFvTWlrcElEMDlQU0JrZVc1aGJXbGpRbmwwWlhNdWJtRjBhWFpsTG5Oc2FXTmxLREFzSUZWcGJuUTJOQ2d5S1NrcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRjS0lDQWdJQzh2SUdKdmVFeGhjbWRsSUQwZ1FtOTRQRXhoY21kbFUzUnlkV04wUGloN0lHdGxlVG9nSjJKdmVFeGhjbWRsSnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVltOTRUR0Z5WjJVaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek9URUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUV4aGNtZGxMbXhsYm1kMGFDQTlQVDBnWVhKak5DNXphWHBsVDJZOFRHRnlaMlZUZEhKMVkzUStLQ2twQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJSEIxYzJocGJuUWdOakUyTUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpVNUNpQWdJQ0F2THlCelpYUkNiM2hsY3loaE9pQjFhVzUwTmpRc0lHSTZJR0o1ZEdWekxDQmpPaUJoY21NMExsTjBjaWtnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNalE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRBS0lDQWdJQzh2SUdOc1lYTnpJRUZ5WXpSQ2IzaERiMjUwY21GamRDQmxlSFJsYm1SeklHRnlZelF1UTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1ZFhScGJDNWxibk4xY21WZlluVmtaMlYwS0hKbGNYVnBjbVZrWDJKMVpHZGxkRG9nZFdsdWREWTBMQ0JtWldWZmMyOTFjbU5sT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21WdWMzVnlaVjlpZFdSblpYUTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ0t3b0taVzV6ZFhKbFgySjFaR2RsZEY5M2FHbHNaVjkwYjNCQU1Ub0tJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRTl3WTI5a1pVSjFaR2RsZEFvZ0lDQWdQZ29nSUNBZ1lub2daVzV6ZFhKbFgySjFaR2RsZEY5aFpuUmxjbDkzYUdsc1pVQTJDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0ExSUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZ3dOamd4TURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2NtOTJZV3hRY205bmNtRnRDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QXdlREEyT0RFd01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpkMmwwWTJnZ1pXNXpkWEpsWDJKMVpHZGxkRjl6ZDJsMFkyaGZZMkZ6WlY4d1FETWdaVzV6ZFhKbFgySjFaR2RsZEY5emQybDBZMmhmWTJGelpWOHhRRFFLQ21WdWMzVnlaVjlpZFdSblpYUmZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFPZ29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdJZ1pXNXpkWEpsWDJKMVpHZGxkRjkzYUdsc1pWOTBiM0JBTVFvS1pXNXpkWEpsWDJKMVpHZGxkRjl6ZDJsMFkyaGZZMkZ6WlY4eFFEUTZDaUFnSUNCbmJHOWlZV3dnVFdsdVZIaHVSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdZaUJsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Rb0taVzV6ZFhKbFgySjFaR2RsZEY5emQybDBZMmhmWTJGelpWOHdRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHSWdaVzV6ZFhKbFgySjFaR2RsZEY5emQybDBZMmhmWTJGelpWOXVaWGgwUURVS0NtVnVjM1Z5WlY5aWRXUm5aWFJmWVdaMFpYSmZkMmhwYkdWQU5qb0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFRQUlBb0FnSmhBRlFrOVlYME1FWW14dllnaGliM2hNWVhKblpRUmliM2hCQkdKdmVFUUJZZ3gwYjI5TllXNTVRbTl2YkhNRUFBRUNBd1FWSDN4MUNHMWhibmxKYm5SekFUQUZhR1ZzYkc4R1ltOTRVbVZtQkFBQ05ESUNORElEQm9FQk1SdEJCT1V4R1JSRU1SaEVnZzhFSi9kcmFRU1JJMkY2QlBjbU9VZ0VDYnk2WGdSNkRUM0lCSDBEbTBNRU84T3krUVRjM21GTkJPRTVGeUVFYUR0Y1pBU2xwaWIrQkpBNTdkNEVLTExpUVFTTnp0ZWJCQngzOUpZMkdnQ09Ed0o3QW5rQ2NBSlVBaUlCNGdIUkFZd0JYUUVTQU8wQWlBQi9BRTRBQVFBMkdnRkpGU1FTUkJlQnlHVWppQVJsSXljR3ZVVUJSQ05KZ2VpQkFneEJBQ05IQWlRS1RDUVlKd1pQQWlLNlRGTkJBQVJNSWdoTVN3RkxBeEpBQUFVaUNFTC8xRWdXSndoTVVMQWlRellhQVVrVkpCSkVGellhQWtrVkloSkVJMU5MQVNRS1R3SWtHQ2NHU3dJaXVrc0JKQXhFVEU4RFZDY0dUZ0s3SWtNbkJvR2RJTGxJSWtNcHZVVUJGRVFwZ1NDNVJERUFNZ29wSTBzRHV5bUJ3RDdUS1NOSlN3UFNLWUZBSnd1N0tTT0JSYnBMQVVzRFVDY0xVQkpFS2J4SUtiNUpGRVJMQVlBQUVrUkxBMDRDVFVzQ0VrUlFLYnhJS1V5L0tiMUlnVUFTUkNjTWdTQzVTQ2NNdkVnaVE0QUJaQ2NIdnljSEkxVVVSQ2NISWxVaUVrUW5CeVZWSlJKRUp3ZUJBMVdCQXhKRUlrTW5DcnhJSndxQUUxUmxjM1JwYm1jZ2RHVnpkR2x1WnlBeE1qTy9Kd29qZ1FlNmdBZFVaWE4wYVc1bkVrUW92RWdvZ0FjQUJVaGxiR3h2dnlnbGdRVzZnQVZJWld4c2J4SkVJa01ydlVVQkp3VzlUZ0pJS0wxT0EwZ3F2VTRFU0lBQkFDTlBBbFFpVHdKVUpVOENWSUVEVHdKVUp3aE1VTEFpUXl1K1JCY2lDQ0lKSndXK1JGY0NBQ2krUkNvaEJDUzZGMDhERmtzREZSWlhCZ0pQQkZCTWdBSUFGRkJMQVJXQkZBZ1dWd1lDVUU4Q0ZsQk1VRXhRSndoTVVMQWlReW9oQkNTNkZ5SUlGaW9oQkU4Q3V5SkRLN3hJSndXOFNDaThTQ3UrVEJlQktrc0JTd05OZ1NvU1JDY0Z2aWNOVGdKTlZ3SUFKdzRTUkNpK0p3MU9BazFYQWdBbkRoSkVUQlJFRkVRcXZFZ2lRNEdFVWlPSUFrMGpKd205UlFGRUkwbUJnUVFNUVFBU1NTUUxKd2xNSkxvWFR3SUlUQ0lJUXYvbVNCWW5DRXhRc0NKRE5ob0JTUlVrRWtRWE5ob0NTUlVrRWtSTUpBc25DVXhQQXJzaVF5Y0pnWWdndVVnaVF5SkROaG9CU1JVa0VrUVhOaG9DU1NOWkpRaExBUlZKVHdJU1JFc0JWd0lBTmhvRFNTTlpKUWhMQVJWSlR3SVNSRThGRml0TXZ5Y0Z2RWduQlVzRnZ5aThTQ2hMQXI4bkJMeElKd1JMQTc4cWdaQXd1VWlCS2hZcUlRUkxBcnNxSVFSUEFyc3J2a1FYZ1FNSUZpdE12eXU5U0NRU1JDY0Z2VWhQQkJKRUtMMUVTVXNDRWtRbkJMMUlTd1FWU2hKRUtDTWl1a3NGVndBQkVrUkxBaUlKS0V3aXVrc0VJZ2xMQmt3aVdCSkVJMHNERHlOTEJFOENUU0pMQkE4aVN3VlBBazFMQkV3SlNVc0NERXNDVEUxTEFRa29Td0pQQXJvalN3WVBJMHNIVHdKTklrc0hEeUpMQ0U4Q1RVc0hUQWxKU3dJTVN3Sk1UVXNJU3dKUEFsSlBBaEpFSlVzRkR5VlBCazhDVFVzQ0NTaFBBMDhDdWlWTEJROGxUd1pQQWsxUEJVOERUd0pTRWtRbkJDTWl1azhFVndJQkVrUkxBU0lKSndSTUlycExBU0lKU3dSTUlsZ1NSQ05MQWc4alN3TlBBazBpU3dNUElrc0VUd0pOU3dOTUNVbExBZ3hMQWt4TlN3RUpKd1JMQWs4Q3VpTkxBdzhqU3dSUEFrMGlTd1FQSWtzRlR3Sk5Td1JNQ1VsTEFneExBa3hOU3daTEFrOENVazhDRWtTQkJVc0VENEVGU3dWUEFrMUxBZ2tuQkVzRFR3SzZnUVZMQkErQkJVc0ZUd0pOU3daTEEwOENVaEpFSlVzRUR5VlBCVThDVFVzQ0NTY0VUd05QQXJvbFN3TVBKVThFVHdKTlRFNERVaEpFS3IxSWdaQXdFa1FpUXpFWkZERVlGQkJEaWdJQWkvNkJDZ2hKTWd3TlFRQXFzWUVHc2hDQkJiSVpKdyt5SGljUHNoK0wvNDBDQUFzQUJMTkMvOXd5QUxJQlF2LzFJN0lCUXYvdmlRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
