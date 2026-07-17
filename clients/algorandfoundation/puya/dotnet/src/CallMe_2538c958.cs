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

namespace Arc56.Generated.algorandfoundation.puya.CallMe_2538c958
{


    public class CallMeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CallMeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DynamicStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong B { get; set; }

                public byte[] C { get; set; }

                public string D { get; set; }

                public Structs.FixedStruct[] E { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.From(D);
                    stringRef[ret.Count] = vD.Encode();
                    ret.AddRange(new byte[2]);
                    var arrE = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrE.Value = (E ?? Array.Empty<Structs.FixedStruct>()).ToList();
                    stringRef[ret.Count] = arrE.Encode();
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

                public static DynamicStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new DynamicStruct();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is byte[] vCValue) { ret.C = vCValue; }
                    var indexD = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.Decode(bytes.Skip(indexD + prefixOffset).ToArray());
                    var valueD = vD.ToValue();
                    if (valueD is string vDValue) { ret.D = vDValue; }
                    var indexE = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrE = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrE.Decode(bytes.Skip(indexE + prefixOffset).ToArray());
                    ret.E = arrE.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DynamicStruct);
                }
                public bool Equals(DynamicStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DynamicStruct left, DynamicStruct right)
                {
                    return EqualityComparer<DynamicStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(DynamicStruct left, DynamicStruct right)
                {
                    return !(left == right);
                }

            }

            public class FixedStruct : AVMObjectType
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

                public static FixedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FixedStruct();
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
                    return Equals(obj as FixedStruct);
                }
                public bool Equals(FixedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FixedStruct left, FixedStruct right)
                {
                    return EqualityComparer<FixedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(FixedStruct left, FixedStruct right)
                {
                    return !(left == right);
                }

            }

            public class NestedStruct : AVMObjectType
            {
                public Structs.FixedStruct Fixed { get; set; } = new Structs.FixedStruct();

                public ulong C { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Fixed.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NestedStruct();
                    uint count = 0;
                    ret.Fixed = Structs.FixedStruct.Parse(queue.ToArray());
                    { var consumedFixed = ret.Fixed.ToByteArray().Length; for (int i = 0; i < consumedFixed && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is ulong vCValue) { ret.C = vCValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedStruct);
                }
                public bool Equals(NestedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedStruct left, NestedStruct right)
                {
                    return EqualityComparer<NestedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedStruct left, NestedStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Delete(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> FixedStruct</param>
        public async Task FixedStructArg(Structs.FixedStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 177, 155, 149 };

            var result = await base.CallApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FixedStructArg_Transactions(Structs.FixedStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 177, 155, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.FixedStruct> FixedStructRet(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 139, 150, 74 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FixedStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> FixedStructRet_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 139, 150, 74 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> NestedStruct</param>
        public async Task NestedStructArg(Structs.NestedStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 24, 101, 95 };

            var result = await base.CallApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NestedStructArg_Transactions(Structs.NestedStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 24, 101, 95 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.NestedStruct> NestedStructRet(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 59, 253, 183 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NestedStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestedStructRet_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 59, 253, 183 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> DynamicStruct</param>
        public async Task DynamicStructArg(Structs.DynamicStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 236, 20, 160 };

            var result = await base.CallApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DynamicStructArg_Transactions(Structs.DynamicStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 236, 20, 160 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.DynamicStruct> DynamicStructRet(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 77, 9, 38 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DynamicStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> DynamicStructRet_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 77, 9, 38 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> FixedStruct</param>
        public async Task FixedArrArg(Structs.FixedStruct[] arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 13, 235, 80 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FixedArrArg_Transactions(Structs.FixedStruct[] arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 13, 235, 80 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.FixedStruct[]> FixedArrRet(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 102, 74, 182 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> FixedArrRet_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 102, 74, 182 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> FixedStruct</param>
        public async Task NativeArrArg(Structs.FixedStruct[] arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 93, 19, 118 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; argAbi.From(arg);

            var result = await base.CallApp(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NativeArrArg_Transactions(Structs.FixedStruct[] arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 93, 19, 118 };
            var argAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; argAbi.From(arg);

            return await base.MakeTransactionList(new List<object> { abiHandle, argAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.FixedStruct[]> NativeArrRet(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 142, 74, 98 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> NativeArrRet_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 142, 74, 98 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task LogIt(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 190, 16, 50 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogIt_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 190, 16, 50 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FsbE1lIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkR5bmFtaWNTdHJ1Y3QiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYyIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImUiLCJ0eXBlIjoiRml4ZWRTdHJ1Y3RbXSJ9XSwiRml4ZWRTdHJ1Y3QiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In1dLCJOZXN0ZWRTdHJ1Y3QiOlt7Im5hbWUiOiJmaXhlZCIsInR5cGUiOiJGaXhlZFN0cnVjdCJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlbGV0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZml4ZWRfc3RydWN0X2FyZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJGaXhlZFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZml4ZWRfc3RydWN0X3JldCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJGaXhlZFN0cnVjdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5lc3RlZF9zdHJ1Y3RfYXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IigodWludDY0LHVpbnQ2NCksdWludDY0KSIsInN0cnVjdCI6Ik5lc3RlZFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibmVzdGVkX3N0cnVjdF9yZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKCh1aW50NjQsdWludDY0KSx1aW50NjQpIiwic3RydWN0IjoiTmVzdGVkU3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZHluYW1pY19zdHJ1Y3RfYXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LGJ5dGVbXSxzdHJpbmcsKHVpbnQ2NCx1aW50NjQpW10pIiwic3RydWN0IjoiRHluYW1pY1N0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZHluYW1pY19zdHJ1Y3RfcmV0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LGJ5dGVbXSxzdHJpbmcsKHVpbnQ2NCx1aW50NjQpW10pIiwic3RydWN0IjoiRHluYW1pY1N0cnVjdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpeGVkX2Fycl9hcmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpWzNdIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJuYW1lIjoiYXJnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpeGVkX2Fycl9yZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpWzNdIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuYXRpdmVfYXJyX2FyZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IkZpeGVkU3RydWN0IiwibmFtZSI6ImFyZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuYXRpdmVfYXJyX3JldCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IkZpeGVkU3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nX2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6NX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzMwLDQwOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZHluYW1pY19zdHJ1Y3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU2LDQxNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZml4ZWRfYXJyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMCwzOThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmZpeGVkX3N0cnVjdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODgsNDIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uYXRpdmVfYXJyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NCw0MDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5lc3RlZF9zdHJ1Y3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcyLDI5MywzMTQsMzY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmFiaV9jYWxsLkZpeGVkU3RydWN0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTx0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmFiaV9jYWxsLkZpeGVkU3RydWN0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmFiaV9jYWxsLkR5bmFtaWNTdHJ1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy5tdXRhYmxlX25hdGl2ZV90eXBlcy5hYmlfY2FsbC5GaXhlZFN0cnVjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmFiaV9jYWxsLk5lc3RlZFN0cnVjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDIgb2YgKHVpbnQ2NCx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3V0ZjhbXSksKGxlbisodWludDY0LHVpbnQ2NClbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMyBvZiAodWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdXRmOFtdKSwobGVuKyh1aW50NjQsdWludDY0KVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA0IG9mICh1aW50NjQsdWludDY0LChsZW4rdWludDhbXSksKGxlbit1dGY4W10pLChsZW4rKHVpbnQ2NCx1aW50NjQpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OSwyODAsMzAxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTVRZZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSm1hWGhsWkY5emRISjFZM1FpSUNKdVpYTjBaV1JmYzNSeWRXTjBJaUFpWkhsdVlXMXBZMTl6ZEhKMVkzUWlJQ0ptYVhobFpGOWhjbklpSUNKdVlYUnBkbVZmWVhKeUlnb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZV0pwWDJOaGJHd3VjSGs2TkRFS0lDQWdJQzh2SUdOc1lYTnpJRU5oYkd4TlpTaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpRek56aGtNMk1nTHk4Z2JXVjBhRzlrSUNKa1pXeGxkR1VvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyUmxiR1YwWlY5eWIzVjBaVUExQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd4TVdJeE9XSTVOU0F3ZUdReU9HSTVOalJoSURCNFpXRXhPRFkxTldZZ01IaGlZak5pWm1SaU55QXdlRFEyWldNeE5HRXdJREI0T1dJMFpEQTVNallnTUhnMFpqQmtaV0kxTUNBd2VEVTVOalkwWVdJMklEQjRNVEkxWkRFek56WWdNSGc0TVRobE5HRTJNaUF3ZURsaVltVXhNRE15SUM4dklHMWxkR2h2WkNBaVptbDRaV1JmYzNSeWRXTjBYMkZ5Wnlnb2RXbHVkRFkwTEhWcGJuUTJOQ2twZG05cFpDSXNJRzFsZEdodlpDQWlabWw0WldSZmMzUnlkV04wWDNKbGRDZ3BLSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSnVaWE4wWldSZmMzUnlkV04wWDJGeVp5Z29LSFZwYm5RMk5DeDFhVzUwTmpRcExIVnBiblEyTkNrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYm1WemRHVmtYM04wY25WamRGOXlaWFFvS1Nnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEpuS0NoMWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYlhTeHpkSEpwYm1jc0tIVnBiblEyTkN4MWFXNTBOalFwVzEwcEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SNWJtRnRhV05mYzNSeWRXTjBYM0psZENncEtIVnBiblEyTkN4MWFXNTBOalFzWW5sMFpWdGRMSE4wY21sdVp5d29kV2x1ZERZMExIVnBiblEyTkNsYlhTa2lMQ0J0WlhSb2IyUWdJbVpwZUdWa1gyRnljbDloY21jb0tIVnBiblEyTkN4MWFXNTBOalFwV3pOZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1acGVHVmtYMkZ5Y2w5eVpYUW9LU2gxYVc1ME5qUXNkV2x1ZERZMEtWc3pYU0lzSUcxbGRHaHZaQ0FpYm1GMGFYWmxYMkZ5Y2w5aGNtY29LSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWJtRjBhWFpsWDJGeWNsOXlaWFFvS1NoMWFXNTBOalFzZFdsdWREWTBLVnRkSWl3Z2JXVjBhRzlrSUNKc2IyZGZhWFFvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JtYVhobFpGOXpkSEoxWTNSZllYSm5JR1pwZUdWa1gzTjBjblZqZEY5eVpYUWdibVZ6ZEdWa1gzTjBjblZqZEY5aGNtY2dibVZ6ZEdWa1gzTjBjblZqZEY5eVpYUWdaSGx1WVcxcFkxOXpkSEoxWTNSZllYSm5JR1I1Ym1GdGFXTmZjM1J5ZFdOMFgzSmxkQ0JtYVhobFpGOWhjbkpmWVhKbklHWnBlR1ZrWDJGeWNsOXlaWFFnYm1GMGFYWmxYMkZ5Y2w5aGNtY2dibUYwYVhabFgyRnljbDl5WlhRZ2JHOW5YMmwwQ2lBZ0lDQmxjbklLQ20xaGFXNWZaR1ZzWlhSbFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWhZbWxmWTJGc2JDNXdlVG8wT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakk2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVlXSnBYMk5oYkd3dVEyRnNiRTFsTG1acGVHVmtYM04wY25WamRGOWhjbWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWFYaGxaRjl6ZEhKMVkzUmZZWEpuT2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdllXSnBYMk5oYkd3dWNIazZOVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtRmlhVjlqWVd4c0xrWnBlR1ZrVTNSeWRXTjBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTloWW1sZlkyRnNiQzV3ZVRvMU5Rb2dJQ0FnTHk4Z2MyVnNaaTVtYVhobFpGOXpkSEoxWTNRdWRtRnNkV1VnUFNCaGNtY0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltWnBlR1ZrWDNOMGNuVmpkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5aFltbGZZMkZzYkM1d2VUbzFNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbUZpYVY5allXeHNMa05oYkd4TlpTNW1hWGhsWkY5emRISjFZM1JmY21WMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tabWw0WldSZmMzUnlkV04wWDNKbGREb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2pVNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNW1hWGhsWkY5emRISjFZM1F1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbWFYaGxaRjl6ZEhKMVkzUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Wm1sNFpXUmZjM1J5ZFdOMElHVjRhWE4wY3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdllXSnBYMk5oYkd3dWNIazZOVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTVoWW1sZlkyRnNiQzVEWVd4c1RXVXVibVZ6ZEdWa1gzTjBjblZqZEY5aGNtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B1WlhOMFpXUmZjM1J5ZFdOMFgyRnlaem9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJGaWFWOWpZV3hzTG5CNU9qWXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WVdKcFgyTmhiR3d1VG1WemRHVmtVM1J5ZFdOMENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWhZbWxmWTJGc2JDNXdlVG8yTXdvZ0lDQWdMeThnYzJWc1ppNXVaWE4wWldSZmMzUnlkV04wTG5aaGJIVmxJRDBnWVhKbkNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdVpYTjBaV1JmYzNSeWRXTjBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJGaWFWOWpZV3hzTG5CNU9qWXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZV0pwWDJOaGJHd3VRMkZzYkUxbExtNWxjM1JsWkY5emRISjFZM1JmY21WMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tibVZ6ZEdWa1gzTjBjblZqZEY5eVpYUTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTloWW1sZlkyRnNiQzV3ZVRvMk53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVibVZ6ZEdWa1gzTjBjblZqZEM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltNWxjM1JsWkY5emRISjFZM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVnpkR1ZrWDNOMGNuVmpkQ0JsZUdsemRITUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVlXSnBYMk5oYkd3dVEyRnNiRTFsTG1SNWJtRnRhV05mYzNSeWRXTjBYMkZ5WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUjVibUZ0YVdOZmMzUnlkV04wWDJGeVp6b0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2pZNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01qSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01pQnZaaUFvZFdsdWREWTBMSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkWFJtT0Z0ZEtTd29iR1Z1S3loMWFXNTBOalFzZFdsdWREWTBLVnRkS1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElERTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXpJRzltSUNoMWFXNTBOalFzZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cktIVnBiblEyTkN4MWFXNTBOalFwVzEwcEtRb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElESXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQTBJRzltSUNoMWFXNTBOalFzZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrc0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cktIVnBiblEyTkN4MWFXNTBOalFwVzEwcEtRb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWhZbWxmWTJGc2JDNUVlVzVoYldsalUzUnlkV04wQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5aFltbGZZMkZzYkM1d2VUbzNNUW9nSUNBZ0x5OGdjMlZzWmk1a2VXNWhiV2xqWDNOMGNuVmpkQzUyWVd4MVpTQTlJR0Z5Wnk1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbVI1Ym1GdGFXTmZjM1J5ZFdOMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2pZNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVlXSnBYMk5oYkd3dVEyRnNiRTFsTG1SNWJtRnRhV05mYzNSeWRXTjBYM0psZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUjVibUZ0YVdOZmMzUnlkV04wWDNKbGREb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2pjMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWtlVzVoYldsalgzTjBjblZqZEM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltUjVibUZ0YVdOZmMzUnlkV04wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUjVibUZ0YVdOZmMzUnlkV04wSUdWNGFYTjBjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WVdKcFgyTmhiR3d1Y0hrNk56TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWhZbWxmWTJGc2JDNURZV3hzVFdVdVptbDRaV1JmWVhKeVgyRnlaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21acGVHVmtYMkZ5Y2w5aGNtYzZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTloWW1sZlkyRnNiQzV3ZVRvM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4MFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbUZpYVY5allXeHNMa1pwZUdWa1UzUnlkV04wTENBelBnb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZV0pwWDJOaGJHd3VjSGs2TnprS0lDQWdJQzh2SUhObGJHWXVabWw0WldSZllYSnlMblpoYkhWbElEMGdZWEpuTG1OdmNIa29LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlabWw0WldSZllYSnlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJGaWFWOWpZV3hzTG5CNU9qYzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZV0pwWDJOaGJHd3VRMkZzYkUxbExtWnBlR1ZrWDJGeWNsOXlaWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWFYaGxaRjloY25KZmNtVjBPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WVdKcFgyTmhiR3d1Y0hrNk9ETUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbVpwZUdWa1gyRnljaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1acGVHVmtYMkZ5Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW1hWGhsWkY5aGNuSWdaWGhwYzNSekNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWhZbWxmWTJGc2JDNXdlVG80TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1GaWFWOWpZV3hzTGtOaGJHeE5aUzV1WVhScGRtVmZZWEp5WDJGeVoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTVoZEdsMlpWOWhjbkpmWVhKbk9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZV0pwWDJOaGJHd3VjSGs2T0RVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWhZbWxmWTJGc2JDNUdhWGhsWkZOMGNuVmpkRDRLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJGaWFWOWpZV3hzTG5CNU9qZzNDaUFnSUNBdkx5QnpaV3htTG01aGRHbDJaVjloY25JdWRtRnNkV1VnUFNCaGNtY3VZMjl3ZVNncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKdVlYUnBkbVZmWVhKeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2pnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVlXSnBYMk5oYkd3dVEyRnNiRTFsTG01aGRHbDJaVjloY25KZmNtVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYm1GMGFYWmxYMkZ5Y2w5eVpYUTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTloWW1sZlkyRnNiQzV3ZVRvNU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVibUYwYVhabFgyRnljaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW01aGRHbDJaVjloY25JaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVibUYwYVhabFgyRnljaUJsZUdsemRITUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2pnNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVlXSnBYMk5oYkd3dVEyRnNiRTFsTG14dloxOXBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q214dloxOXBkRG9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJGaWFWOWpZV3hzTG5CNU9qazFDaUFnSUNBdkx5QnNiMmNvYzJWc1ppNW1hWGhsWkY5emRISjFZM1F1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVptbDRaV1JmYzNSeWRXTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1acGVHVmtYM04wY25WamRDQmxlR2x6ZEhNS0lDQWdJR3h2WndvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdllXSnBYMk5oYkd3dWNIazZPVFlLSUNBZ0lDOHZJR3h2WnloelpXeG1MbTVsYzNSbFpGOXpkSEoxWTNRdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlibVZ6ZEdWa1gzTjBjblZqZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWE4wWldSZmMzUnlkV04wSUdWNGFYTjBjd29nSUNBZ2JHOW5DaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTloWW1sZlkyRnNiQzV3ZVRvNU53b2dJQ0FnTHk4Z2JHOW5LSE5sYkdZdVpIbHVZVzFwWTE5emRISjFZM1F1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVpIbHVZVzFwWTE5emRISjFZM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpIbHVZVzFwWTE5emRISjFZM1FnWlhocGMzUnpDaUFnSUNCc2IyY0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMkZpYVY5allXeHNMbkI1T2prNENpQWdJQ0F2THlCc2IyY29jMlZzWmk1bWFYaGxaRjloY25JdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlabWw0WldSZllYSnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1acGVHVmtYMkZ5Y2lCbGVHbHpkSE1LSUNBZ0lHeHZad29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WVdKcFgyTmhiR3d1Y0hrNk9Ua0tJQ0FnSUM4dklHeHZaeWh6Wld4bUxtNWhkR2wyWlY5aGNuSXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYm1GMGFYWmxYMkZ5Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVZWFJwZG1WZllYSnlJR1Y0YVhOMGN3b2dJQ0FnYkc5bkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWhZbWxmWTJGc2JDNXdlVG81TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRVFBaVlHQkJVZmZIVU1abWw0WldSZmMzUnlkV04wRFc1bGMzUmxaRjl6ZEhKMVkzUU9aSGx1WVcxcFkxOXpkSEoxWTNRSlptbDRaV1JmWVhKeUNtNWhkR2wyWlY5aGNuSXhHMEVBY29BRUpEZU5QRFlhQUk0QkFGd3hHUlJFTVJoRWdnc0VFYkdibFFUU2k1WktCT29ZWlY4RXV6djl0d1JHN0JTZ0JKdE5DU1lFVHczclVBUlpaa3EyQkJKZEUzWUVnWTVLWWdTYnZoQXlOaG9BamdzQUVnQWZBQ2tBTndCQkFJMEFsd0NtQUxFQXhnRFJBREVaZ1FVU01SZ1FRekVaRkRFWUZCQkROaG9CU1JVa0VrUXBUR2NqUXlJcFpVUW9URkN3STBNMkdnRkpGWUVZRWtRcVRHY2pReUlxWlVRb1RGQ3dJME0yR2dGSkZVc0JKRmxKZ1JZU1JFc0NURXNDVWlKWmdSZ0lTd0tCRWxsSlN3SVNSRXNEVEVzRFVpSlpKUWdJU3dLQkZGbEpTd0lTUkVzRFRFc0RVaUpaSkFzbENBZ1NSQ3RNWnlORElpdGxSQ2hNVUxBalF6WWFBVWtWZ1RBU1JDY0VUR2NqUXlJbkJHVkVLRXhRc0NORE5ob0JTU0paSkFzbENFc0JGUkpFSndWTVp5TkRJaWNGWlVRb1RGQ3dJME1pS1dWRXNDSXFaVVN3SWl0bFJMQWlKd1JsUkxBaUp3VmxSTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
