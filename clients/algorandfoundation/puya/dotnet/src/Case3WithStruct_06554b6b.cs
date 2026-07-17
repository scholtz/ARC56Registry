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

namespace Arc56.Generated.algorandfoundation.puya.Case3WithStruct_06554b6b
{


    public class Case3WithStructProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Case3WithStructProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NamedTup : AVMObjectType
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

                public static NamedTup Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NamedTup();
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
                    return Equals(obj as NamedTup);
                }
                public bool Equals(NamedTup? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NamedTup left, NamedTup right)
                {
                    return EqualityComparer<NamedTup>.Default.Equals(left, right);
                }
                public static bool operator !=(NamedTup left, NamedTup right)
                {
                    return !(left == right);
                }

            }

            public class TupBag : AVMObjectType
            {
                public ulong Count { get; set; }

                public Structs.NamedTup[] Items { get; set; }

                public Algorand.Address Owner { get; set; }

                public ulong App { get; set; }

                public byte[] TooBig { get; set; }

                public bool Bootstrapped { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCount.From(Count);
                    ret.AddRange(vCount.Encode());
                    var arrItems = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = true, FixedLength = 8 };
                    arrItems.Value = (Items ?? Array.Empty<Structs.NamedTup>()).ToList();
                    ret.AddRange(arrItems.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApp.From(App);
                    ret.AddRange(vApp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTooBig = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096]");
                    vTooBig.From(TooBig);
                    ret.AddRange(vTooBig.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBootstrapped = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vBootstrapped.From(Bootstrapped);
                    ret.AddRange(vBootstrapped.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TupBag Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TupBag();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCount = vCount.ToValue();
                    if (valueCount is ulong vCountValue) { ret.Count = vCountValue; }
                    var arrItems = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = true, FixedLength = 8 };
                    { var consumedItems = (int)arrItems.Decode(queue.ToArray()); for (int i = 0; i < consumedItems && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Items = arrItems.Value.ToArray();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTooBig = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096]");
                    count = vTooBig.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTooBig = vTooBig.ToValue();
                    if (valueTooBig is byte[] vTooBigValue) { ret.TooBig = vTooBigValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBootstrapped = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vBootstrapped.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBootstrapped = vBootstrapped.ToValue();
                    if (valueBootstrapped is bool vBootstrappedValue) { ret.Bootstrapped = vBootstrappedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TupBag);
                }
                public bool Equals(TupBag? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TupBag left, TupBag right)
                {
                    return EqualityComparer<TupBag>.Default.Equals(left, right);
                }
                public static bool operator !=(TupBag left, TupBag right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 126, 162, 171 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 126, 162, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> NumTups(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 136, 64, 234 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NumTups_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 136, 64, 234 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tup"> NamedTup</param>
        public async Task AddTup(Structs.NamedTup tup, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 92, 238, 157 };

            var result = await base.CallApp(new List<object> { abiHandle, tup }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddTup_Transactions(Structs.NamedTup tup, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 92, 238, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tup }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task<Structs.NamedTup> GetTup(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 11, 85, 52 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NamedTup.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTup_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 11, 85, 52 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Sum(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 3, 11, 65 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Sum_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 3, 11, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tups"> NamedTup</param>
        public async Task AddManyTups(Structs.NamedTup[] tups, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 57, 223, 81 };
            var tupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; tupsAbi.From(tups);

            var result = await base.CallApp(new List<object> { abiHandle, tupsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddManyTups_Transactions(Structs.NamedTup[] tups, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 57, 223, 81 };
            var tupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; tupsAbi.From(tups);

            return await base.MakeTransactionList(new List<object> { abiHandle, tupsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tups"> NamedTup</param>
        public async Task AddFixedTups(Structs.NamedTup[] tups, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 30, 123, 67 };
            var tupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; tupsAbi.From(tups);

            var result = await base.CallApp(new List<object> { abiHandle, tupsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddFixedTups_Transactions(Structs.NamedTup[] tups, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 30, 123, 67 };
            var tupsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; tupsAbi.From(tups);

            return await base.MakeTransactionList(new List<object> { abiHandle, tupsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task SetA(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 71, 132, 127 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetA_Transactions(ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 71, 132, 127 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="b"> </param>
        public async Task SetB(ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 166, 72, 82 };
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetB_Transactions(ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 166, 72, 82 };
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="start"> </param>
        public async Task<Structs.NamedTup[]> Get3Tups(ulong start, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 201, 190, 120 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);

            var result = await base.CallApp(new List<object> { abiHandle, startAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = true, FixedLength = 3 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> Get3Tups_Transactions(ulong start, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 201, 190, 120 };
            var startAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startAbi.From(start);

            return await base.MakeTransactionList(new List<object> { abiHandle, startAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.NamedTup[]> GetAllTups(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 69, 122, 25 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NamedTup>(x => Structs.NamedTup.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetAllTups_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 69, 122, 25 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FzZTNXaXRoU3RydWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik5hbWVkVHVwIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XSwiVHVwQmFnIjpbeyJuYW1lIjoiY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXRlbXMiLCJ0eXBlIjoiTmFtZWRUdXBbOF0ifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXBwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvb19iaWciLCJ0eXBlIjoiYnl0ZVs0MDk2XSJ9LHsibmFtZSI6ImJvb3RzdHJhcHBlZCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibnVtX3R1cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfdHVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwibmFtZSI6InR1cCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdHVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX21hbnlfdHVwcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwibmFtZSI6InR1cHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX2ZpeGVkX3R1cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpWzNdIiwic3RydWN0IjoiTmFtZWRUdXAiLCJuYW1lIjoidHVwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9iIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0XzNfdHVwcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NClbM10iLCJzdHJ1Y3QiOiJOYW1lZFR1cCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hbGxfdHVwcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2MjZdLCJlcnJvck1lc3NhZ2UiOiJhcHAgbm90IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNl0sImVycm9yTWVzc2FnZSI6ImJveCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMSwyNTMsMzE1LDM1MSw0ODcsNDk4LDUxMCw1NTBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MywxNTMsMTY3LDE3MywyMDYsMjExLDIxNiwyMzIsMjQ3LDM3NywzOTAsNDAwLDQyMiw0MzUsNDQ1LDQ2NSw0NzgsNTI5LDU0NCw1ODgsNjAyLDYwNiw2MTUsNjIzLDYzMyw2NDNdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmNhc2UzX3dpdGhfbXV0YWJsZV9zdHJ1Y3QuTmFtZWRUdXA+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PHRlc3RfY2FzZXMubXV0YWJsZV9uYXRpdmVfdHlwZXMuY2FzZTNfd2l0aF9tdXRhYmxlX3N0cnVjdC5OYW1lZFR1cCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDEsMzcwLDQxNSw0NjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy5tdXRhYmxlX25hdGl2ZV90eXBlcy5jYXNlM193aXRoX211dGFibGVfc3RydWN0Lk5hbWVkVHVwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDczXSwiZXJyb3JNZXNzYWdlIjoibm90IGVub3VnaCBpdGVtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzN10sImVycm9yTWVzc2FnZSI6InNlbmRlciBub3QgYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0OF0sImVycm9yTWVzc2FnZSI6InRoaXMgZXJyb3Igc2hvdWxkIGJlIGltcG9zc2libGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTNdLCJlcnJvck1lc3NhZ2UiOiJ0b28gbWFueSB0dXBzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBNElERWdNQ0F4TmlBeE1qZ2dOREkzTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpZEhWd1gySmhaeUlnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyRnpaVE5YYVhSb1UzUnlkV04wS0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFESXdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhOamRsWVRKaFlpQXdlREF5T0RnME1HVmhJREI0WmpjMVkyVmxPV1FnTUhnNE9EQmlOVFV6TkNBd2VEVXpNRE13WWpReElEQjROMlF6T1dSbU5URWdNSGczWVRGbE4ySTBNeUF3ZURNME5EYzRORGRtSURCNE1tSmhOalE0TlRJZ01IaGhZbU01WW1VM09DQXdlRGN6TkRVM1lURTVJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMkp2ZUNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYm5WdFgzUjFjSE1vS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWVdSa1gzUjFjQ2dvZFdsdWREWTBMSFZwYm5RMk5Da3BkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYM1IxY0NoMWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0p6ZFcwb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlXUmtYMjFoYm5sZmRIVndjeWdvZFdsdWREWTBMSFZwYm5RMk5DbGJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmhaR1JmWm1sNFpXUmZkSFZ3Y3lnb2RXbHVkRFkwTEhWcGJuUTJOQ2xiTTEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFgyRW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOWlLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZNMTkwZFhCektIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ2xiTTEwaUxDQnRaWFJvYjJRZ0ltZGxkRjloYkd4ZmRIVndjeWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXBXMTBpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1ZmWW05NElHNTFiVjkwZFhCeklHRmtaRjkwZFhBZ1oyVjBYM1IxY0NCemRXMGdZV1JrWDIxaGJubGZkSFZ3Y3lCaFpHUmZabWw0WldSZmRIVndjeUJ6WlhSZllTQnpaWFJmWWlCblpYUmZNMTkwZFhCeklHZGxkRjloYkd4ZmRIVndjd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURJd09nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVRMkZ6WlROWGFYUm9VM1J5ZFdOMExtTnlaV0YwWlY5aWIzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZZbTk0T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1ZEhWd1gySmhaeTVqY21WaGRHVW9LU3dnSW1KdmVDQmhiSEpsWVdSNUlHVjRhWE4wY3lJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQndkWE5vYVc1MElEUXlOek1LSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUdGemMyVnlkQ0F2THlCaWIzZ2dZV3h5WldGa2VTQmxlR2x6ZEhNS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOREVLSUNBZ0lDOHZJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzV2ZDI1bGNpQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCd2RYTm9hVzUwSURFek5nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TkRJS0lDQWdJQzh2SUhObGJHWXVkSFZ3WDJKaFp5NTJZV3gxWlM1aGNIQWdQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDlwWkFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBkWEJmWW1Gbklnb2dJQ0FnY0hWemFHbHVkQ0F4TmpnS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZORE1LSUNBZ0lDOHZJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVpYjI5MGMzUnlZWEJ3WldRZ1BTQlVjblZsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owZFhCZlltRm5JZ29nSUNBZ2FXNTBZeUExSUM4dklEUXlOeklLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQnBiblJqSURVZ0x5OGdOREkzTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVRMkZ6WlROWGFYUm9VM1J5ZFdOMExtNTFiVjkwZFhCelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiblZ0WDNSMWNITTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE0xOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pRM0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1OdmRXNTBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBkWEJmWW1Gbklnb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8wTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1UTJGelpUTlhhWFJvVTNSeWRXTjBMbUZrWkY5MGRYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSZmRIVndPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzVPWVcxbFpGUjFjQW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVRMkZ6WlROWGFYUm9VM1J5ZFdOMExtRmtaRjkwZFhBS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1RFlYTmxNMWRwZEdoVGRISjFZM1F1WjJWMFgzUjFjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTBkWEE2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdsdVpHVjRJRHdnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1OdmRXNTBMQ0FpYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3lJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TlRrS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1YVhSbGJYTmJhVzVrWlhoZENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR01nTkNBdkx5QXhNamdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNURZWE5sTTFkcGRHaFRkSEoxWTNRdWMzVnRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNWdE9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8yTXdvZ0lDQWdMeThnZEc5MFlXd2dQU0JWU1c1ME5qUW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TmpRS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3WDJKaFp5SUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NncHpkVzFmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8yTkFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVqYjNWdWRDazZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNBOENpQWdJQ0JpZWlCemRXMWZZV1owWlhKZlptOXlRRFVLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk5qVUtJQ0FnSUM4dklIUjFjQ0E5SUhObGJHWXVkSFZ3WDJKaFp5NTJZV3gxWlM1cGRHVnRjMXRwWFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE0xOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pZMUxUWTJDaUFnSUNBdkx5QjBkWEFnUFNCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdWFYUmxiWE5iYVYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0IwZFhBdVlRb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TWpnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8yTmdvZ0lDQWdMeThnZEc5MFlXd2dLejBnZEhWd0xtRUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8yTlMwMk5nb2dJQ0FnTHk4Z2RIVndJRDBnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1sMFpXMXpXMmxkTG1OdmNIa29LUW9nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdkSFZ3TG1FS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qWTJDaUFnSUNBdkx5QjBiM1JoYkNBclBTQjBkWEF1WVFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8yTndvZ0lDQWdMeThnZEc5MFlXd2dLejBnZEhWd0xtSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNWpiM1Z1ZENrNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnpkVzFmWm05eVgyaGxZV1JsY2tBeUNncHpkVzFmWVdaMFpYSmZabTl5UURVNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTVqWVhObE0xOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMa05oYzJVelYybDBhRk4wY25WamRDNWhaR1JmYldGdWVWOTBkWEJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtYMjFoYm5sZmRIVndjem9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk56QUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1VG1GdFpXUlVkWEErQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qY3lDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2RIVndjeTVzWlc1bmRHZ3BPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtDbUZrWkY5dFlXNTVYM1IxY0hOZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hSMWNITXViR1Z1WjNSb0tUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdGa1pGOXRZVzU1WDNSMWNITmZZV1owWlhKZlptOXlRRFVLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk56TUtJQ0FnSUM4dklITmxiR1l1WVdSa1gzUjFjQ2gwZFhCelcybGRMbU52Y0hrb0tTa0tJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBeE5nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTGtOaGMyVXpWMmwwYUZOMGNuVmpkQzVoWkdSZmRIVndDaUFnSUNCd2IzQUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpJS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2gwZFhCekxteGxibWQwYUNrNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQmhaR1JmYldGdWVWOTBkWEJ6WDJadmNsOW9aV0ZrWlhKQU1nb0tZV1JrWDIxaGJubGZkSFZ3YzE5aFpuUmxjbDltYjNKQU5Ub0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTGtOaGMyVXpWMmwwYUZOMGNuVmpkQzVoWkdSZlptbDRaV1JmZEhWd2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZrWkY5bWFYaGxaRjkwZFhCek9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG8zTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHgwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdVRtRnRaV1JVZFhBc0lETStDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE0xOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjM0NpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvZEhWd2N5NXNaVzVuZEdncE9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0NtRmtaRjltYVhobFpGOTBkWEJ6WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpjS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2gwZFhCekxteGxibWQwYUNrNkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BBb2dJQ0FnWW5vZ1lXUmtYMlpwZUdWa1gzUjFjSE5mWVdaMFpYSmZabTl5UURVS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOemdLSUNBZ0lDOHZJSE5sYkdZdVlXUmtYM1IxY0NoMGRYQnpXMmxkTG1OdmNIa29LU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNBcUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpZWE5sTTE5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExrTmhjMlV6VjJsMGFGTjBjblZqZEM1aFpHUmZkSFZ3Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk56Y0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoMGRYQnpMbXhsYm1kMGFDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUJoWkdSZlptbDRaV1JmZEhWd2MxOW1iM0pmYUdWaFpHVnlRRElLQ21Ga1pGOW1hWGhsWkY5MGRYQnpYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVRMkZ6WlROWGFYUm9VM1J5ZFdOMExuTmxkRjloVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMkU2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qZ3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z2MyVnNaaTVmWTJobFkydGZiM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydGZiM2R1WlhJS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPRE1LSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaHpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVZMjkxYm5RcE9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2dwelpYUmZZVjltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTTE5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamd6Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbU52ZFc1MEtUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUhObGRGOWhYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qZzBDaUFnSUNBdkx5QnpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVhWFJsYlhOYmFWMHVZU0E5SUdFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T0RNS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnYzJWMFgyRmZabTl5WDJobFlXUmxja0F5Q2dwelpYUmZZVjloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTVqWVhObE0xOTNhWFJvWDIxMWRHRmliR1ZmYzNSeWRXTjBMa05oYzJVelYybDBhRk4wY25WamRDNXpaWFJmWWx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlpT2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk9EZ0tJQ0FnSUM4dklITmxiR1l1WDJOb1pXTnJYMjkzYm1WeUtDa0tJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJYMjkzYm1WeUNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTTE5M2FYUm9YMjExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamc1Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbU52ZFc1MEtUb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjRjlpWVdjaUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6SWdMeThnTUFvS2MyVjBYMkpmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG80T1FvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVqYjNWdWRDazZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCelpYUmZZbDloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzVNQW9nSUNBZ0x5OGdjMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbWwwWlcxelcybGRMbUlnUFNCaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMENpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvNE9Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hObGJHWXVkSFZ3WDJKaFp5NTJZV3gxWlM1amIzVnVkQ2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCelpYUmZZbDltYjNKZmFHVmhaR1Z5UURJS0NuTmxkRjlpWDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG80TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1UTJGelpUTlhhWFJvVTNSeWRXTjBMbWRsZEY4elgzUjFjSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZNMTkwZFhCek9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG81TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVZMjkxYm5RZ1BqMGdjM1JoY25RZ0t5QXpMQ0FpYm05MElHVnViM1ZuYUNCcGRHVnRjeUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0FyQ2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0JsYm05MVoyZ2dhWFJsYlhNS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPVFVLSUNBZ0lDOHZJR2wwWlcxeklEMGdjMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbWwwWlcxekxtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhWd1gySmhaeUlLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklHbDBaVzF6VzNOMFlYSjBYUzVqYjNCNUtDa3NDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFl5QTBJQzh2SURFeU9Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lDb0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklHbDBaVzF6VzNOMFlYSjBJQ3NnTVYwdVkyOXdlU2dwTEFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUNvS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TURFS0lDQWdJQzh2SUdsMFpXMXpXM04wWVhKMElDc2dNbDB1WTI5d2VTZ3BMQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNeUF2THlBeE5nb2dJQ0FnS2dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvNU55MHhNRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQkdhWGhsWkVGeWNtRjVXMDVoYldWa1ZIVndMQ0IwZVhCcGJtY3VUR2wwWlhKaGJGc3pYVjBvQ2lBZ0lDQXZMeUFnSUNBZ0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCcGRHVnRjMXR6ZEdGeWRGMHVZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCcGRHVnRjMXR6ZEdGeWRDQXJJREZkTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdhWFJsYlhOYmMzUmhjblFnS3lBeVhTNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T1RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTGtOaGMyVXpWMmwwYUZOMGNuVmpkQzVuWlhSZllXeHNYM1IxY0hOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWVd4c1gzUjFjSE02Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdjbVZ6ZFd4MElEMGdUbUYwYVhabFFYSnlZWGxiVG1GdFpXUlVkWEJkS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRBNUxURXhNQW9nSUNBZ0x5OGdJeUJVVDBSUE9pQnBiWEJ5YjNabElIUm9hWE1nYjI1alpTQnpiR2xqYVc1bklHbHpJSE4xY0hCdmNuUmxaQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNWpiM1Z1ZENrNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLQ21kbGRGOWhiR3hmZEhWd2MxOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXdPUzB4TVRBS0lDQWdJQzh2SUNNZ1ZFOUVUem9nYVcxd2NtOTJaU0IwYUdseklHOXVZMlVnYzJ4cFkybHVaeUJwY3lCemRYQndiM0owWldRS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBYMkZzYkY5MGRYQnpYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdhWFJsYlhNZ1BTQnpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVhWFJsYlhNdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owZFhCZlltRm5JZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1URUtJQ0FnSUM4dklISmxjM1ZzZEM1aGNIQmxibVFvYVhSbGJYTmJhVjB1WTI5d2VTZ3BLUW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1qZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJSEpsYzNWc2RDNWhjSEJsYm1Rb2FYUmxiWE5iYVYwdVkyOXdlU2dwS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEE1TFRFeE1Bb2dJQ0FnTHk4Z0l5QlVUMFJQT2lCcGJYQnliM1psSUhSb2FYTWdiMjVqWlNCemJHbGphVzVuSUdseklITjFjSEJ2Y25SbFpBb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hObGJHWXVkSFZ3WDJKaFp5NTJZV3gxWlM1amIzVnVkQ2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCblpYUmZZV3hzWDNSMWNITmZabTl5WDJobFlXUmxja0F5Q2dwblpYUmZZV3hzWDNSMWNITmZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlROZmQybDBhRjl0ZFhSaFlteGxYM04wY25WamRDNURZWE5sTTFkcGRHaFRkSEoxWTNRdVlXUmtYM1IxY0NoMGRYQTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTGtOaGMyVXpWMmwwYUZOMGNuVmpkQzVoWkdSZmRIVndPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvME9TMDFNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJoWkdSZmRIVndLSE5sYkdZc0lIUjFjRG9nVG1GdFpXUlVkWEFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TlRFS0lDQWdJQzh2SUhObGJHWXVYMk5vWldOclgyOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclgyOTNibVZ5Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qVXlDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtTnZkVzUwSUR3Z2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtbDBaVzF6TG14bGJtZDBhQ3dnSW5SdmJ5QnRZVzU1SUhSMWNITWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBkWEJmWW1Gbklnb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklIUnZieUJ0WVc1NUlIUjFjSE1LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXpYM2RwZEdoZmJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk5UTUtJQ0FnSUM4dklITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNXBkR1Z0YzF0elpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVkyOTFiblJkSUQwZ2RIVndMbU52Y0hrb0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVelgzZHBkR2hmYlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TlRRS0lDQWdJQzh2SUhObGJHWXVkSFZ3WDJKaFp5NTJZV3gxWlM1amIzVnVkQ0FyUFNBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjRjlpWVdjaUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdVEyRnpaVE5YYVhSb1UzUnlkV04wTGw5amFHVmphMTl2ZDI1bGNpZ3BJQzArSUhadmFXUTZDbDlqYUdWamExOXZkMjVsY2pvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV6WDNkcGRHaGZiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEUyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbUp2YjNSemRISmhjSEJsWkN3Z0ltRndjQ0J1YjNRZ1ltOXZkSE4wY21Gd2NHVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3WDJKaFp5SUtJQ0FnSUdsdWRHTWdOU0F2THlBME1qY3lDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEFnYm05MElHSnZiM1J6ZEhKaGNIQmxaQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUTmZkMmwwYUY5dGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdWIzZHVaWElnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJbk5sYm1SbGNpQnViM1FnWVhWMGFHOXlhWHBsWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQndkWE5vYVc1MGN5QXhNellnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5sYm1SbGNpQnViM1FnWVhWMGFHOXlhWHBsWkFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVE5mZDJsMGFGOXRkWFJoWW14bFgzTjBjblZqZEM1d2VUb3hNVGtLSUNBZ0lDOHZJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVoY0hBZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCd2RYTm9hVzUwSURFMk9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNMTkzYVhSb1gyMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXhPQzB4TWpBS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtRndjQ0E5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5cFpBb2dJQ0FnTHk4Z0tTd2dJblJvYVhNZ1pYSnliM0lnYzJodmRXeGtJR0psSUdsdGNHOXpjMmxpYkdVaUNpQWdJQ0JoYzNObGNuUWdMeThnZEdocGN5Qmxjbkp2Y2lCemFHOTFiR1FnWW1VZ2FXMXdiM056YVdKc1pRb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBR0NBRUFFSUFCc0NFbUFnZDBkWEJmWW1GbkJCVWZmSFV4RzBFQVhERVpGRVF4R0VTQ0N3U21mcUtyQkFLSVFPb0U5MXp1blFTSUMxVTBCRk1EQzBFRWZUbmZVUVI2SG50REJEUkhoSDhFSzZaSVVnU3J5YjU0QkhORmVoazJHZ0NPQ3dBSkFEQUFPZ0JJQUdvQW5BRE5BUEVCSGdGTEFaQUFNUmtVTVJnVUVFTW9nYkVodVVRb2dZZ0JNUUM3TWdnV0tJR29BVThDdXlnaEJTTzZKQ05VS0NFRlR3SzdJME1vSkNLNktVeFFzQ05ETmhvQlNSVWxFa1NJQVlSSUkwTTJHZ0ZKRlNJU1JCY29KQ0s2RjBzQkRVUW9JaUVFdWt3bEN5VllLVXhRc0NOREpDZ2tJcm9YVENSSlN3TU1RUUFiS0NJaEJMcExBU1VMSlZoSkpGdFBBd2hNSWxzSVRDTUlRdi9lU0JZcFRGQ3dJME0yR2dGSEFpUlpTVTRDSlF1QkFnaE1GUkpFSkVsTEFneEJBQlJMQWxjQ0FFc0JKUXNsV0lnQkJFZ2pDRUwvNVNORE5ob0JTUldCTUJKRUpFbUJBd3hCQUJGSkpRdExBa3dsV0lnQTRFZ2pDRUwvNkNORE5ob0JTUlVpRWtTSUFQVW9KQ0s2RnlSSlN3SU1RUUFUU1NJTVJFa2xDeUlJS0V4TEJMc2pDRUwvNWlORE5ob0JTUlVpRWtTSUFNZ29KQ0s2RnlSSlN3SU1RUUFUU1NJTVJFa2xDeVVJS0V4TEJMc2pDRUwvNWlORE5ob0JTUlVpRWtRWEtDUWl1aGRMQVlFRENBOUVLQ0loQkxwTEFTVUxTd0ZNSlZoTEFpTUlKUXRMQWt3bFdFOERnUUlJSlF0UEEwd2xXRTRDVUV4UUtVeFFzQ05EZ0FJQUFDZ2tJcm9YVENSSlN3TU1RUUFnS0NJaEJMcExBU1VMSlZoUEFra2tXU01JRmxjR0FGd0FURkJNSXdoQy85bElLVXhRc0NORGlnRUJpQUFpS0NRaXVoZEpJZ3hFSlFzaUNDaE1pLys3S0NRaXVoY2pDQllvSkU4Q3U0di9pU2doQlNPNkpGTkVLSU1DaUFFZ3VqRUFFa1FvZ2FnQklyb1hNZ2dTUklrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
