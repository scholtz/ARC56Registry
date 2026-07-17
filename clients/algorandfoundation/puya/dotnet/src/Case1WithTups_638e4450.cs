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

namespace Arc56.Generated.algorandfoundation.puya.Case1WithTups_638e4450
{


    public class Case1WithTupsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Case1WithTupsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FzZTFXaXRoVHVwcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJOYW1lZFR1cCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifV0sIlR1cEJhZyI6W3sibmFtZSI6ImNvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Iml0ZW1zIiwidHlwZSI6Ik5hbWVkVHVwWzhdIn0seyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFwcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b29fYmlnIiwidHlwZSI6ImJ5dGVbNDA5Nl0ifSx7Im5hbWUiOiJib290c3RyYXBwZWQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im51bV90dXBzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX3R1cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJOYW1lZFR1cCIsIm5hbWUiOiJ0dXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3R1cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJOYW1lZFR1cCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1bSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9tYW55X3R1cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJOYW1lZFR1cCIsIm5hbWUiOiJ0dXBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9maXhlZF90dXBzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KVszXSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwibmFtZSI6InR1cHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2EiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF8zX3R1cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpWzNdIiwic3RydWN0IjoiTmFtZWRUdXAiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWxsX3R1cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJOYW1lZFR1cCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzM3XSwiZXJyb3JNZXNzYWdlIjoiYXBwIG5vdCBib290c3RyYXBwZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzZdLCJlcnJvck1lc3NhZ2UiOiJib3ggYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjYsMjU4LDMyMiwzNjMsNDE4LDQ4Niw1NDksNTY4LDU4OCw2NDZdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MywxNTMsMTY3LDE3MywyMTEsMjE2LDIyMSwyMzcsMjUyLDM5NSw0MDksNDMxLDQ0MCw0NjMsNDc3LDQ5OCw1MDcsNTI3LDU0MCw2MjUsNjQwLDY5Myw3MTUsNzE5LDcyOCw3MzQsNzQ0LDc1NF0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RfY2FzZXMubXV0YWJsZV9uYXRpdmVfdHlwZXMuY2FzZTFfd2l0aF90dXBzLk5hbWVkVHVwPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTx0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmNhc2UxX3dpdGhfdHVwcy5OYW1lZFR1cCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDYsMzg3LDQ1NSw1MjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy5tdXRhYmxlX25hdGl2ZV90eXBlcy5jYXNlMV93aXRoX3R1cHMuTmFtZWRUdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzVdLCJlcnJvck1lc3NhZ2UiOiJub3QgZW5vdWdoIGl0ZW1zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ4XSwiZXJyb3JNZXNzYWdlIjoic2VuZGVyIG5vdCBhdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzU5XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBlcnJvciBzaG91bGQgYmUgaW1wb3NzaWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5OF0sImVycm9yTWVzc2FnZSI6InRvbyBtYW55IHR1cHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURBZ01TQXhOaUF4TWpnZ05ESTNNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlkSFZ3WDJKaFp5SWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2pReENpQWdJQ0F2THlCamJHRnpjeUJEWVhObE1WZHBkR2hVZFhCektHRnlZelF1UVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREl3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhoTmpkbFlUSmhZaUF3ZURBeU9EZzBNR1ZoSURCNFpqYzFZMlZsT1dRZ01IZzRPREJpTlRVek5DQXdlRFV6TURNd1lqUXhJREI0TjJRek9XUm1OVEVnTUhnM1lURmxOMkkwTXlBd2VETTBORGM0TkRkbUlEQjRNbUpoTmpRNE5USWdNSGhoWW1NNVltVTNPQ0F3ZURjek5EVTNZVEU1SUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJKdmVDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWJuVnRYM1IxY0hNb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlXUmtYM1IxY0Nnb2RXbHVkRFkwTEhWcGJuUTJOQ2twZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDNSMWNDaDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKemRXMG9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZV1JrWDIxaGJubGZkSFZ3Y3lnb2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0poWkdSZlptbDRaV1JmZEhWd2N5Z29kV2x1ZERZMExIVnBiblEyTkNsYk0xMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYMkVvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjlpS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmTTE5MGRYQnpLSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkNsYk0xMGlMQ0J0WlhSb2IyUWdJbWRsZEY5aGJHeGZkSFZ3Y3lncEtIVnBiblEyTkN4MWFXNTBOalFwVzEwaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWZlltOTRJRzUxYlY5MGRYQnpJR0ZrWkY5MGRYQWdaMlYwWDNSMWNDQnpkVzBnWVdSa1gyMWhibmxmZEhWd2N5QmhaR1JmWm1sNFpXUmZkSFZ3Y3lCelpYUmZZU0J6WlhSZllpQm5aWFJmTTE5MGRYQnpJR2RsZEY5aGJHeGZkSFZ3Y3dvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFESXdPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OaGMyVXhYM2RwZEdoZmRIVndjeTVEWVhObE1WZHBkR2hVZFhCekxtTnlaV0YwWlY5aWIzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZZbTk0T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qUTNDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTUwZFhCZlltRm5MbU55WldGMFpTZ3BMQ0FpWW05NElHRnNjbVZoWkhrZ1pYaHBjM1J6SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhWd1gySmhaeUlLSUNBZ0lIQjFjMmhwYm5RZ05ESTNNd29nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnWVhOelpYSjBJQzh2SUdKdmVDQmhiSEpsWVdSNUlHVjRhWE4wY3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qUTRDaUFnSUNBdkx5QnpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXViM2R1WlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBkWEJmWW1Gbklnb2dJQ0FnY0hWemFHbHVkQ0F4TXpZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTVY5M2FYUm9YM1IxY0hNdWNIazZORGtLSUNBZ0lDOHZJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVoY0hBZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOXBaQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdjSFZ6YUdsdWRDQXhOamdLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXhYM2RwZEdoZmRIVndjeTV3ZVRvMU1Bb2dJQ0FnTHk4Z2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtSnZiM1J6ZEhKaGNIQmxaQ0E5SUZSeWRXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjRjlpWVdjaUNpQWdJQ0JwYm5SaklEVWdMeThnTkRJM01nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3WDJKaFp5SUtJQ0FnSUdsdWRHTWdOU0F2THlBME1qY3lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2TkRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNVjkzYVhSb1gzUjFjSE11UTJGelpURlhhWFJvVkhWd2N5NXVkVzFmZEhWd2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTUxYlY5MGRYQnpPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2pVMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1OdmRXNTBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBkWEJmWW1Gbklnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRGZmQybDBhRjkwZFhCekxuQjVPalV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTJGelpURmZkMmwwYUY5MGRYQnpMa05oYzJVeFYybDBhRlIxY0hNdVlXUmtYM1IxY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRjkwZFhBNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTVY5M2FYUm9YM1IxY0hNdWNIazZOVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1T1lXMWxaRlIxY0FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVeFgzZHBkR2hmZEhWd2N5NURZWE5sTVZkcGRHaFVkWEJ6TG1Ga1pGOTBkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OaGMyVXhYM2RwZEdoZmRIVndjeTVEWVhObE1WZHBkR2hVZFhCekxtZGxkRjkwZFhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmZEhWd09nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRGZmQybDBhRjkwZFhCekxuQjVPall6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qWTFDaUFnSUNBdkx5QmhjM05sY25RZ2FXNWtaWGdnUENCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVkyOTFiblFzSUNKcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1Seklnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2pZMkNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1sMFpXMXpXMmx1WkdWNFhRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVEk0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qWXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlRGZmQybDBhRjkwZFhCekxrTmhjMlV4VjJsMGFGUjFjSE11YzNWdFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjM1Z0T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qY3dDaUFnSUNBdkx5QjBiM1JoYkNBOUlGVkpiblEyTkNncENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qY3hDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtTnZkVzUwS1RvS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LYzNWdFgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXhYM2RwZEdoZmRIVndjeTV3ZVRvM01Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hObGJHWXVkSFZ3WDJKaFp5NTJZV3gxWlM1amIzVnVkQ2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQnpkVzFmWVdaMFpYSmZabTl5UURVS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzNNZ29nSUNBZ0x5OGdkSFZ3SUQwZ2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtbDBaVzF6VzJsZENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR01nTkNBdkx5QXhNamdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2pjekNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCMGRYQXVZUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVeFgzZHBkR2hmZEhWd2N5NXdlVG8zTkFvZ0lDQWdMeThnZEc5MFlXd2dLejBnZEhWd0xtSUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzNNUW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNWpiM1Z1ZENrNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnpkVzFmWm05eVgyaGxZV1JsY2tBeUNncHpkVzFmWVdaMFpYSmZabTl5UURVNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzJPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVeFgzZHBkR2hmZEhWd2N5NURZWE5sTVZkcGRHaFVkWEJ6TG1Ga1pGOXRZVzU1WDNSMWNITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSZmJXRnVlVjkwZFhCek9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRGZmQybDBhRjkwZFhCekxuQjVPamMzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpZWE5sTVY5M2FYUm9YM1IxY0hNdVRtRnRaV1JVZFhBK0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvS1lXUmtYMjFoYm5sZmRIVndjMTltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTVY5M2FYUm9YM1IxY0hNdWNIazZOemtLSUNBZ0lDOHZJR1p2Y2lCMGRYQWdhVzRnZEhWd2N6b0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdGa1pGOXRZVzU1WDNSMWNITmZZV1owWlhKZlptOXlRRFVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzRNQW9nSUNBZ0x5OGdjMlZzWmk1aFpHUmZkSFZ3S0hSMWNDa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpZWE5sTVY5M2FYUm9YM1IxY0hNdVEyRnpaVEZYYVhSb1ZIVndjeTVoWkdSZmRIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUJoWkdSZmJXRnVlVjkwZFhCelgyWnZjbDlvWldGa1pYSkFNZ29LWVdSa1gyMWhibmxmZEhWd2MxOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXhYM2RwZEdoZmRIVndjeTV3ZVRvM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1RFlYTmxNVmRwZEdoVWRYQnpMbUZrWkY5bWFYaGxaRjkwZFhCelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV1JrWDJacGVHVmtYM1IxY0hNNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTVY5M2FYUm9YM1IxY0hNdWNIazZPRElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNVjkzYVhSb1gzUjFjSE11VG1GdFpXUlVkWEFzSURNK0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvS1lXUmtYMlpwZUdWa1gzUjFjSE5mWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRGZmQybDBhRjkwZFhCekxuQjVPamcwQ2lBZ0lDQXZMeUJtYjNJZ2RIVndJR2x1SUhSMWNITTZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2dZV1JrWDJacGVHVmtYM1IxY0hOZllXWjBaWEpmWm05eVFEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXhYM2RwZEdoZmRIVndjeTV3ZVRvNE5Rb2dJQ0FnTHk4Z2MyVnNaaTVoWkdSZmRIVndLSFIxY0NrS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNVjkzYVhSb1gzUjFjSE11UTJGelpURlhhWFJvVkhWd2N5NWhaR1JmZEhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQmhaR1JmWm1sNFpXUmZkSFZ3YzE5bWIzSmZhR1ZoWkdWeVFESUtDbUZrWkY5bWFYaGxaRjkwZFhCelgyRm1kR1Z5WDJadmNrQTFPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVEZmZDJsMGFGOTBkWEJ6TGtOaGMyVXhWMmwwYUZSMWNITXVjMlYwWDJGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmWVRvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzROd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXhYM2RwZEdoZmRIVndjeTV3ZVRvNE9Rb2dJQ0FnTHk4Z2MyVnNaaTVmWTJobFkydGZiM2R1WlhJb0tRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydGZiM2R1WlhJS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzVNQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNWpiM1Z1ZENrNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLQ25ObGRGOWhYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzVNQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNWpiM1Z1ZENrNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJ6WlhSZllWOWhablJsY2w5bWIzSkFOUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2preENpQWdJQ0F2THlCMGRYQWdQU0J6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1YVhSbGJYTmJhVjBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFl5QTBJQzh2SURFeU9Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lDb0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pYaDBjbUZqZENBNElEZ0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVeFgzZHBkR2hmZEhWd2N5NXdlVG81TWdvZ0lDQWdMeThnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1sMFpXMXpXMmxkSUQwZ2RIVndMbDl5WlhCc1lXTmxLR0U5WVNrS0lDQWdJR1JwWnlBMENpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2T1RBS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnYzJWMFgyRmZabTl5WDJobFlXUmxja0F5Q2dwelpYUmZZVjloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzROd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVeFgzZHBkR2hmZEhWd2N5NURZWE5sTVZkcGRHaFVkWEJ6TG5ObGRGOWlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgySTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2T1RRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTVY5M2FYUm9YM1IxY0hNdWNIazZPVFlLSUNBZ0lDOHZJSE5sYkdZdVgyTm9aV05yWDI5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yWDI5M2JtVnlDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2T1RjS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3WDJKaFp5SUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NncHpaWFJmWWw5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2T1RjS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ2MyVjBYMkpmWVdaMFpYSmZabTl5UURVS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzVPQW9nSUNBZ0x5OGdkSFZ3SUQwZ2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtbDBaVzF6VzJsZENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR01nTkNBdkx5QXhNamdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1Y0ZEhKaFkzUWdNQ0E0Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk9Ua0tJQ0FnSUM4dklITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNXBkR1Z0YzF0cFhTQTlJSFIxY0M1ZmNtVndiR0ZqWlNoaVBXSXBDaUFnSUNCa2FXY2dOQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qazNDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtTnZkVzUwS1RvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlITmxkRjlpWDJadmNsOW9aV0ZrWlhKQU1nb0tjMlYwWDJKZllXWjBaWEpmWm05eVFEVTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2T1RRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNVjkzYVhSb1gzUjFjSE11UTJGelpURlhhWFJvVkhWd2N5NW5aWFJmTTE5MGRYQnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFh6TmZkSFZ3Y3pvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUb3hNREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk1UQXpDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtTnZkVzUwSUQ0OUlITjBZWEowSUNzZ015d2dJbTV2ZENCbGJtOTFaMmdnYVhSbGJYTWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBkWEJmWW1Gbklnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdLd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdaVzV2ZFdkb0lHbDBaVzF6Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk1UQTBDaUFnSUNBdkx5QnBkR1Z0Y3lBOUlITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNXBkR1Z0Y3k1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2TVRBNENpQWdJQ0F2THlCcGRHVnRjMXR6ZEdGeWRGMHNDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFl5QTBJQzh2SURFeU9Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lDb0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0E0SURnS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUb3hNRGtLSUNBZ0lDOHZJR2wwWlcxelczTjBZWEowSUNzZ01WMHNDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdLZ29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTRDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURnZ09Bb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRGZmQybDBhRjkwZFhCekxuQjVPakV4TUFvZ0lDQWdMeThnYVhSbGJYTmJjM1JoY25RZ0t5QXlYU3dLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUNvS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTVY5M2FYUm9YM1IxY0hNdWNIazZNVEEyTFRFeE1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUVacGVHVmtRWEp5WVhsYlRtRnRaV1JVZFhBc0lIUjVjR2x1Wnk1TWFYUmxjbUZzV3pOZFhTZ0tJQ0FnSUM4dklDQWdJQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR2wwWlcxelczTjBZWEowWFN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYVhSbGJYTmJjM1JoY25RZ0t5QXhYU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdhWFJsYlhOYmMzUmhjblFnS3lBeVhTd0tJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2TVRBeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVEZmZDJsMGFGOTBkWEJ6TGtOaGMyVXhWMmwwYUZSMWNITXVaMlYwWDJGc2JGOTBkWEJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkZzYkY5MGRYQnpPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2pFeE5nb2dJQ0FnTHk4Z2NtVnpkV3gwSUQwZ1RtRjBhWFpsUVhKeVlYbGJUbUZ0WldSVWRYQmRLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUb3hNVGd0TVRFNUNpQWdJQ0F2THlBaklGUlBSRTg2SUdsdGNISnZkbVVnZEdocGN5QnZibU5sSUhOc2FXTnBibWNnYVhNZ2MzVndjRzl5ZEdWa0NpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1OdmRXNTBLVG9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb0taMlYwWDJGc2JGOTBkWEJ6WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVeFgzZHBkR2hmZEhWd2N5NXdlVG94TVRndE1URTVDaUFnSUNBdkx5QWpJRlJQUkU4NklHbHRjSEp2ZG1VZ2RHaHBjeUJ2Ym1ObElITnNhV05wYm1jZ2FYTWdjM1Z3Y0c5eWRHVmtDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtTnZkVzUwS1RvS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5aGJHeGZkSFZ3YzE5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRGZmQybDBhRjkwZFhCekxuQjVPakV4TndvZ0lDQWdMeThnYVhSbGJYTWdQU0J6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1YVhSbGJYTXVZMjl3ZVNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEZmZDJsMGFGOTBkWEJ6TG5CNU9qRXlNQW9nSUNBZ0x5OGdjbVZ6ZFd4MExtRndjR1Z1WkNocGRHVnRjMXRwWFNrS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVEk0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBeE5nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ09DQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUb3hNakFLSUNBZ0lDOHZJSEpsYzNWc2RDNWhjSEJsYm1Rb2FYUmxiWE5iYVYwcENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRGZmQybDBhRjkwZFhCekxuQjVPakV4T0MweE1Ua0tJQ0FnSUM4dklDTWdWRTlFVHpvZ2FXMXdjbTkyWlNCMGFHbHpJRzl1WTJVZ2MyeHBZMmx1WnlCcGN5QnpkWEJ3YjNKMFpXUUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVkyOTFiblFwT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ1oyVjBYMkZzYkY5MGRYQnpYMlp2Y2w5b1pXRmtaWEpBTWdvS1oyVjBYMkZzYkY5MGRYQnpYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk1URTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlRGZmQybDBhRjkwZFhCekxrTmhjMlV4VjJsMGFGUjFjSE11WVdSa1gzUjFjQ2gwZFhBdVlUb2dkV2x1ZERZMExDQjBkWEF1WWpvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU5oYzJVeFgzZHBkR2hmZEhWd2N5NURZWE5sTVZkcGRHaFVkWEJ6TG1Ga1pGOTBkWEE2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk5UWXROVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWVdSa1gzUjFjQ2h6Wld4bUxDQjBkWEE2SUU1aGJXVmtWSFZ3S1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1WOTNhWFJvWDNSMWNITXVjSGs2TlRnS0lDQWdJQzh2SUhObGJHWXVYMk5vWldOclgyOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclgyOTNibVZ5Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk5Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVkyOTFiblFnUENCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdWFYUmxiWE11YkdWdVozUm9MQ0FpZEc5dklHMWhibmtnZEhWd2N5SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjRjlpWVdjaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z2RHOXZJRzFoYm5rZ2RIVndjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpURmZkMmwwYUY5MGRYQnpMbkI1T2pZd0NpQWdJQ0F2THlCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdWFYUmxiWE5iYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1OdmRXNTBYU0E5SUhSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUbzJNUW9nSUNBZ0x5OGdjMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbU52ZFc1MElDczlJREVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhWd1gySmhaeUlLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OaGMyVXhYM2RwZEdoZmRIVndjeTVEWVhObE1WZHBkR2hVZFhCekxsOWphR1ZqYTE5dmQyNWxjaWdwSUMwK0lIWnZhV1E2Q2w5amFHVmphMTl2ZDI1bGNqb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVeFgzZHBkR2hmZEhWd2N5NXdlVG94TWpVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WW05dmRITjBjbUZ3Y0dWa0xDQWlZWEJ3SUc1dmRDQmliMjkwYzNSeVlYQndaV1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owZFhCZlltRm5JZ29nSUNBZ2FXNTBZeUExSUM4dklEUXlOeklLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0NCdWIzUWdZbTl2ZEhOMGNtRndjR1ZrQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk1USTJDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtOTNibVZ5SUQwOUlGUjRiaTV6Wlc1a1pYSXNJQ0p6Wlc1a1pYSWdibTkwSUdGMWRHaHZjbWw2WldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdjSFZ6YUdsdWRITWdNVE0ySURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6Wlc1a1pYSWdibTkwSUdGMWRHaHZjbWw2WldRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV4WDNkcGRHaGZkSFZ3Y3k1d2VUb3hNamdLSUNBZ0lDOHZJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVoY0hBZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCd2RYTm9hVzUwSURFMk9Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNVjkzYVhSb1gzUjFjSE11Y0hrNk1USTNMVEV5T1FvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVlYQndJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJsa0NpQWdJQ0F2THlBcExDQWlkR2hwY3lCbGNuSnZjaUJ6YUc5MWJHUWdZbVVnYVcxd2IzTnphV0pzWlNJS0lDQWdJR0Z6YzJWeWRDQXZMeUIwYUdseklHVnljbTl5SUhOb2IzVnNaQ0JpWlNCcGJYQnZjM05wWW14bENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFHQ0FBQkVJQUJzQ0VtQWdkMGRYQmZZbUZuQkJVZmZIVXhHMEVBWERFWkZFUXhHRVNDQ3dTbWZxS3JCQUtJUU9vRTkxenVuUVNJQzFVMEJGTURDMEVFZlRuZlVRUjZIbnREQkRSSGhIOEVLNlpJVWdTcnliNTRCSE5GZWhrMkdnQ09Dd0FKQURBQU9nQk5BRzhBb3dEWkFRSUJSZ0dKQWZBQU1Sa1VNUmdVRUVNb2diRWh1VVFvZ1lnQk1RQzdNZ2dXS0lHb0FVOEN1eWdoQlNTNkl5UlVLQ0VGVHdLN0pFTW9JeUs2S1V4UXNDUkROaG9CU1JVbEVrUkpJMXRNSWx1SUFlY2tRellhQVVrVkloSkVGeWdqSXJvWFN3RU5SQ2dpSVFTNlRDVUxKVmdwVEZDd0pFTWpLQ01pdWhkTUkwbExBd3hCQUIwb0lpRUV1a3NCSlFzbFdFa2pXMHdpVzA4RFR3SUlDRXdrQ0VMLzNFZ1dLVXhRc0NSRE5ob0JSd0lqV1VsT0FpVUxnUUlJVEJVU1JDTkpTd0lNUVFBWlN3SlhBZ0JMQVNVTEpWaEpJMXRNSWx1SUFXQWtDRUwvNENSRE5ob0JTUldCTUJKRUkwbUJBd3hCQUJaSkpRdExBa3dsV0Vralcwd2lXNGdCTnlRSVF2L2pKRU0yR2dGSkZTSVNSQmVJQVZJb0l5SzZGeU5KU3dJTVFRQXBLQ0loQkxwTEFTVUxURXNCSlZoWENBaExCQlpNVUVzQ0lneEVJazhDQ0NoTVR3SzdKQWhDLzlBa1F6WWFBVWtWSWhKRUY0Z0JEaWdqSXJvWEkwbExBZ3hCQUNnb0lpRUV1a3NCSlF0TVN3RWxXRmNBQ0VzRUZsQkxBaUlNUkNKUEFnZ29URThDdXlRSVF2L1JKRU0yR2dGSkZTSVNSQmNvSXlLNkYwc0JnUU1JRDBRb0lpRUV1a3NCSlF0TEFVd2xXRWxYQUFoTVZ3Z0lTd01rQ0NVTFN3Tk1KVmhKVndBSVRGY0lDRThGZ1FJSUpRdFBCVXdsV0VsWEFBaE1Wd2dJVHdWUEJWQlBCRThFVUZCT0FsQlFLVXhRc0NSRGdBSUFBQ2dqSXJvWFRDTkpTd01NUVFBcEtDSWhCTHBMQVNVTEpWaEpWd0FJVEZjSUNGQlBBa2tqV1NRSUZsY0dBRndBVEZCTUpBaEMvOUJJS1V4UXNDUkRpZ0lBaUFBb0tDTWl1aGRKSWd4RWkvNFdpLzhXVUV3bEN5SUlLRXhQQXJzb0l5SzZGeVFJRmlnalR3SzdpU2doQlNTNkkxTkVLSU1DaUFFZ3VqRUFFa1FvZ2FnQklyb1hNZ2dTUklrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
