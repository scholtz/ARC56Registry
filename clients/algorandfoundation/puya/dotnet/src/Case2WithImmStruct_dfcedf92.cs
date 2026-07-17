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

namespace Arc56.Generated.algorandfoundation.puya.Case2WithImmStruct_dfcedf92
{


    public class Case2WithImmStructProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Case2WithImmStructProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FzZTJXaXRoSW1tU3RydWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik5hbWVkVHVwIjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XSwiVHVwQmFnIjpbeyJuYW1lIjoiY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXRlbXMiLCJ0eXBlIjoiTmFtZWRUdXBbOF0ifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXBwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvb19iaWciLCJ0eXBlIjoiYnl0ZVs0MDk2XSJ9LHsibmFtZSI6ImJvb3RzdHJhcHBlZCIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibnVtX3R1cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfdHVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwibmFtZSI6InR1cCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdHVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX21hbnlfdHVwcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwibmFtZSI6InR1cHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX2ZpeGVkX3R1cHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpWzNdIiwic3RydWN0IjoiTmFtZWRUdXAiLCJuYW1lIjoidHVwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9iIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0XzNfdHVwcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NClbM10iLCJzdHJ1Y3QiOiJOYW1lZFR1cCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hbGxfdHVwcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2NjZdLCJlcnJvck1lc3NhZ2UiOiJhcHAgbm90IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNl0sImVycm9yTWVzc2FnZSI6ImJveCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMCwyNTIsMzE0LDM0OSwzOTgsNDY2LDUyOSw1NDAsNTUyLDU5Ml0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzLDE1MywxNjcsMTczLDIwNSwyMTAsMjE1LDIzMSwyNDYsMzc1LDM4OSw0MTEsNDIwLDQ0Myw0NTcsNDc4LDQ4Nyw1MDcsNTIwLDU3MSw1ODYsNjMwLDY0NCw2NDgsNjU3LDY2Myw2NzMsNjgzXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dGVzdF9jYXNlcy5tdXRhYmxlX25hdGl2ZV90eXBlcy5jYXNlMl93aXRoX2ltbXV0YWJsZV9zdHJ1Y3QuTmFtZWRUdXA+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PHRlc3RfY2FzZXMubXV0YWJsZV9uYXRpdmVfdHlwZXMuY2FzZTJfd2l0aF9pbW11dGFibGVfc3RydWN0Lk5hbWVkVHVwLCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMCwzNjcsNDM1LDUwMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmNhc2UyX3dpdGhfaW1tdXRhYmxlX3N0cnVjdC5OYW1lZFR1cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNV0sImVycm9yTWVzc2FnZSI6Im5vdCBlbm91Z2ggaXRlbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzddLCJlcnJvck1lc3NhZ2UiOiJzZW5kZXIgbm90IGF1dGhvcml6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODhdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGVycm9yIHNob3VsZCBiZSBpbXBvc3NpYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM1XSwiZXJyb3JNZXNzYWdlIjoidG9vIG1hbnkgdHVwcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QTRJREVnTVRZZ01DQXhNamdnTkRJM01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRIVndYMkpoWnlJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pNMENpQWdJQ0F2THlCamJHRnpjeUJEWVhObE1sZHBkR2hKYlcxVGRISjFZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRTJOMlZoTW1GaUlEQjRNREk0T0RRd1pXRWdNSGhtTnpWalpXVTVaQ0F3ZURnNE1HSTFOVE0wSURCNE5UTXdNekJpTkRFZ01IZzNaRE01WkdZMU1TQXdlRGRoTVdVM1lqUXpJREI0TXpRME56ZzBOMllnTUhneVltRTJORGcxTWlBd2VHRmlZemxpWlRjNElEQjROek0wTlRkaE1Ua2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZZbTk0S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p1ZFcxZmRIVndjeWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0poWkdSZmRIVndLQ2gxYVc1ME5qUXNkV2x1ZERZMEtTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZkSFZ3S0hWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbk4xYlNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKaFpHUmZiV0Z1ZVY5MGRYQnpLQ2gxYVc1ME5qUXNkV2x1ZERZMEtWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRjltYVhobFpGOTBkWEJ6S0NoMWFXNTBOalFzZFdsdWREWTBLVnN6WFNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZllTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFgySW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOHpYM1IxY0hNb2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBLVnN6WFNJc0lHMWxkR2h2WkNBaVoyVjBYMkZzYkY5MGRYQnpLQ2tvZFdsdWREWTBMSFZwYm5RMk5DbGJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVjlpYjNnZ2JuVnRYM1IxY0hNZ1lXUmtYM1IxY0NCblpYUmZkSFZ3SUhOMWJTQmhaR1JmYldGdWVWOTBkWEJ6SUdGa1pGOW1hWGhsWkY5MGRYQnpJSE5sZEY5aElITmxkRjlpSUdkbGRGOHpYM1IxY0hNZ1oyVjBYMkZzYkY5MGRYQnpDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTWpBNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMa05oYzJVeVYybDBhRWx0YlZOMGNuVmpkQzVqY21WaGRHVmZZbTk0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJKdmVEb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVeVgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVkSFZ3WDJKaFp5NWpjbVZoZEdVb0tTd2dJbUp2ZUNCaGJISmxZV1I1SUdWNGFYTjBjeUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCd2RYTm9hVzUwSURReU56TUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJR0Z6YzJWeWRDQXZMeUJpYjNnZ1lXeHlaV0ZrZVNCbGVHbHpkSE1LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXlYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbTkzYm1WeUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3WDJKaFp5SUtJQ0FnSUhCMWMyaHBiblFnTVRNMkNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pReUNpQWdJQ0F2THlCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVlYQndJRDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmYVdRS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3WDJKaFp5SUtJQ0FnSUhCMWMyaHBiblFnTVRZNENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TkRNS0lDQWdJQzh2SUhObGJHWXVkSFZ3WDJKaFp5NTJZV3gxWlM1aWIyOTBjM1J5WVhCd1pXUWdQU0JVY25WbENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdhVzUwWXlBMUlDOHZJRFF5TnpJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjRjlpWVdjaUNpQWdJQ0JwYm5SaklEVWdMeThnTkRJM01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExrTmhjMlV5VjJsMGFFbHRiVk4wY25WamRDNXVkVzFmZEhWd2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTUxYlY5MGRYQnpPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qUTNDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtTnZkVzUwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owZFhCZlltRm5JZ29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qUTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMa05oYzJVeVYybDBhRWx0YlZOMGNuVmpkQzVoWkdSZmRIVndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSa1gzUjFjRG9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXlYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExrNWhiV1ZrVkhWd0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExrTmhjMlV5VjJsMGFFbHRiVk4wY25WamRDNWhaR1JmZEhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVRMkZ6WlRKWGFYUm9TVzF0VTNSeWRXTjBMbWRsZEY5MGRYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmRIVndPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sY25RZ2FXNWtaWGdnUENCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVkyOTFiblFzSUNKcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1Seklnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qVTVDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtbDBaVzF6VzJsdVpHVjRYUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3WDJKaFp5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5SaklEUWdMeThnTVRJNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExrTmhjMlV5VjJsMGFFbHRiVk4wY25WamRDNXpkVzFiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemRXMDZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1sOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk5qTUtJQ0FnSUM4dklIUnZkR0ZzSUQwZ1ZVbHVkRFkwS0NrS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOalFLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaHpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVZMjkxYm5RcE9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2dwemRXMWZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPalkwQ2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbU52ZFc1MEtUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUR3S0lDQWdJR0o2SUhOMWJWOWhablJsY2w5bWIzSkFOUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qWTFDaUFnSUNBdkx5QjBkWEFnUFNCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdWFYUmxiWE5iYVYwS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOalV0TmpZS0lDQWdJQzh2SUhSMWNDQTlJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVwZEdWdGMxdHBYUW9nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdkSFZ3TG1FS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVEk0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG8yTmdvZ0lDQWdMeThnZEc5MFlXd2dLejBnZEhWd0xtRUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pZMUxUWTJDaUFnSUNBdkx5QjBkWEFnUFNCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdWFYUmxiWE5iYVYwS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUhSMWNDNWhDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pZMkNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCMGRYQXVZUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPalkzQ2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0IwZFhBdVlnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOalFLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaHpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVZMjkxYm5RcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdjM1Z0WDJadmNsOW9aV0ZrWlhKQU1nb0tjM1Z0WDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TmpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdVEyRnpaVEpYYVhSb1NXMXRVM1J5ZFdOMExtRmtaRjl0WVc1NVgzUjFjSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUmZiV0Z1ZVY5MGRYQnpPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qY3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdVRtRnRaV1JVZFhBK0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvS1lXUmtYMjFoYm5sZmRIVndjMTltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpJS0lDQWdJQzh2SUdadmNpQjBkWEFnYVc0Z2RIVndjem9LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHRmtaRjl0WVc1NVgzUjFjSE5mWVdaMFpYSmZabTl5UURVS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXlYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzNNd29nSUNBZ0x5OGdjMlZzWmk1aFpHUmZkSFZ3S0hSMWNDa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVRMkZ6WlRKWGFYUm9TVzF0VTNSeWRXTjBMbUZrWkY5MGRYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJR0ZrWkY5dFlXNTVYM1IxY0hOZlptOXlYMmhsWVdSbGNrQXlDZ3BoWkdSZmJXRnVlVjkwZFhCelgyRm1kR1Z5WDJadmNrQTFPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qY3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMa05oYzJVeVYybDBhRWx0YlZOMGNuVmpkQzVoWkdSZlptbDRaV1JmZEhWd2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZrWkY5bWFYaGxaRjkwZFhCek9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05EZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMazVoYldWa1ZIVndMQ0F6UGdvZ0lDQWdhVzUwWTE4eklDOHZJREFLQ21Ga1pGOW1hWGhsWkY5MGRYQnpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG8zTndvZ0lDQWdMeThnWm05eUlIUjFjQ0JwYmlCMGRYQnpPZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRHdLSUNBZ0lHSjZJR0ZrWkY5bWFYaGxaRjkwZFhCelgyRm1kR1Z5WDJadmNrQTFDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnS2dvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TnpnS0lDQWdJQzh2SUhObGJHWXVZV1JrWDNSMWNDaDBkWEFwQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTGtOaGMyVXlWMmwwYUVsdGJWTjBjblZqZEM1aFpHUmZkSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCaFpHUmZabWw0WldSZmRIVndjMTltYjNKZmFHVmhaR1Z5UURJS0NtRmtaRjltYVhobFpGOTBkWEJ6WDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pjMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExrTmhjMlV5VjJsMGFFbHRiVk4wY25WamRDNXpaWFJmWVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjloT2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamd3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamd5Q2lBZ0lDQXZMeUJ6Wld4bUxsOWphR1ZqYTE5dmQyNWxjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTE5dmQyNWxjZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qZ3pDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtTnZkVzUwS1RvS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9LYzJWMFgyRmZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamd6Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9jMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbU52ZFc1MEtUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUhObGRGOWhYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPRFFLSUNBZ0lDOHZJSFIxY0NBOUlITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNXBkR1Z0YzF0cFhRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG80TkMwNE5Rb2dJQ0FnTHk4Z2RIVndJRDBnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1sMFpXMXpXMmxkQ2lBZ0lDQXZMeUJ6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1YVhSbGJYTmJhVjBnUFNCMGRYQXVYM0psY0d4aFkyVW9ZVDFoS1FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR01nTkNBdkx5QXhNamdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1Y0ZEhKaFkzUWdPQ0E0Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPRFVLSUNBZ0lDOHZJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVwZEdWdGMxdHBYU0E5SUhSMWNDNWZjbVZ3YkdGalpTaGhQV0VwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBkWEJmWW1Gbklnb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2pnekNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1OdmRXNTBLVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUhObGRGOWhYMlp2Y2w5b1pXRmtaWEpBTWdvS2MyVjBYMkZmWVdaMFpYSmZabTl5UURVNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T0RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdVEyRnpaVEpYYVhSb1NXMXRVM1J5ZFdOMExuTmxkRjlpVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMkk2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPRGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPRGtLSUNBZ0lDOHZJSE5sYkdZdVgyTm9aV05yWDI5M2JtVnlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yWDI5M2JtVnlDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1sOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk9UQUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVkyOTFiblFwT2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhWd1gySmhaeUlLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTXlBdkx5QXdDZ3B6WlhSZllsOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPVEFLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaHpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVZMjkxYm5RcE9nb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZbm9nYzJWMFgySmZZV1owWlhKZlptOXlRRFVLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXlYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdkSFZ3SUQwZ2MyVnNaaTUwZFhCZlltRm5MblpoYkhWbExtbDBaVzF6VzJsZENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamt4TFRreUNpQWdJQ0F2THlCMGRYQWdQU0J6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1YVhSbGJYTmJhVjBLSUNBZ0lDOHZJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVwZEdWdGMxdHBYU0E5SUhSMWNDNWZjbVZ3YkdGalpTaGlQV0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZeUEwSUM4dklERXlPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJQ29LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOaGMyVXlYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdjMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbWwwWlcxelcybGRJRDBnZEhWd0xsOXlaWEJzWVdObEtHSTlZaWtLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjRjlpWVdjaUNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2T1RBS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnYzJWMFgySmZabTl5WDJobFlXUmxja0F5Q2dwelpYUmZZbDloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG80TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OaGMyVXlYM2RwZEdoZmFXMXRkWFJoWW14bFgzTjBjblZqZEM1RFlYTmxNbGRwZEdoSmJXMVRkSEoxWTNRdVoyVjBYek5mZEhWd2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY4elgzUjFjSE02Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZPVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVZMjkxYm5RZ1BqMGdjM1JoY25RZ0t5QXpMQ0FpYm05MElHVnViM1ZuYUNCcGRHVnRjeUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0FyQ2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0JsYm05MVoyZ2dhWFJsYlhNS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG81TndvZ0lDQWdMeThnYVhSbGJYTWdQU0J6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1YVhSbGJYTXVZMjl3ZVNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGRYQmZZbUZuSWdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV3TVFvZ0lDQWdMeThnYVhSbGJYTmJjM1JoY25SZExBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TWpnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNBcUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVeVgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklHbDBaVzF6VzNOMFlYSjBJQ3NnTVYwc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ0tnb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqWVhObE1sOTNhWFJvWDJsdGJYVjBZV0pzWlY5emRISjFZM1F1Y0hrNk1UQXpDaUFnSUNBdkx5QnBkR1Z0YzF0emRHRnlkQ0FySURKZExBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdLZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMkZ6WlRKZmQybDBhRjlwYlcxMWRHRmliR1ZmYzNSeWRXTjBMbkI1T2prNUxURXdOUW9nSUNBZ0x5OGdjbVYwZFhKdUlFWnBlR1ZrUVhKeVlYbGJUbUZ0WldSVWRYQXNJSFI1Y0dsdVp5NU1hWFJsY21Gc1d6TmRYU2dLSUNBZ0lDOHZJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdsMFpXMXpXM04wWVhKMFhTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2FYUmxiWE5iYzNSaGNuUWdLeUF4WFN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYVhSbGJYTmJjM1JoY25RZ0t5QXlYU3dLSUNBZ0lDOHZJQ0FnSUNBcENpQWdJQ0F2THlBcENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPamswQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTGtOaGMyVXlWMmwwYUVsdGJWTjBjblZqZEM1blpYUmZZV3hzWDNSMWNITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZllXeHNYM1IxY0hNNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRBNUNpQWdJQ0F2THlCeVpYTjFiSFFnUFNCT1lYUnBkbVZCY25KaGVWdE9ZVzFsWkZSMWNGMG9LUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TUFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV4TVMweE1USUtJQ0FnSUM4dklDTWdWRTlFVHpvZ2FXMXdjbTkyWlNCMGFHbHpJRzl1WTJVZ2MyeHBZMmx1WnlCcGN5QnpkWEJ3YjNKMFpXUUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdVkyOTFiblFwT2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhWd1gySmhaeUlLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDZ3BuWlhSZllXeHNYM1IxY0hOZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXhNUzB4TVRJS0lDQWdJQzh2SUNNZ1ZFOUVUem9nYVcxd2NtOTJaU0IwYUdseklHOXVZMlVnYzJ4cFkybHVaeUJwY3lCemRYQndiM0owWldRS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1WTI5MWJuUXBPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBYMkZzYkY5MGRYQnpYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEV3Q2lBZ0lDQXZMeUJwZEdWdGN5QTlJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVwZEdWdGN5NWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJ5WlhOMWJIUXVZWEJ3Wlc1a0tHbDBaVzF6VzJsZEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TWpnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdjbVZ6ZFd4MExtRndjR1Z1WkNocGRHVnRjMXRwWFNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TVRFeExURXhNZ29nSUNBZ0x5OGdJeUJVVDBSUE9pQnBiWEJ5YjNabElIUm9hWE1nYjI1alpTQnpiR2xqYVc1bklHbHpJSE4xY0hCdmNuUmxaQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNWpiM1Z1ZENrNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQm5aWFJmWVd4c1gzUjFjSE5mWm05eVgyaGxZV1JsY2tBeUNncG5aWFJmWVd4c1gzUjFjSE5mWVdaMFpYSmZabTl5UURVNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdVEyRnpaVEpYYVhSb1NXMXRVM1J5ZFdOMExtRmtaRjkwZFhBb2RIVndPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdVEyRnpaVEpYYVhSb1NXMXRVM1J5ZFdOMExtRmtaRjkwZFhBNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TkRrdE5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdZV1JrWDNSMWNDaHpaV3htTENCMGRYQTZJRTVoYldWa1ZIVndLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpZWE5sTWw5M2FYUm9YMmx0YlhWMFlXSnNaVjl6ZEhKMVkzUXVjSGs2TlRFS0lDQWdJQzh2SUhObGJHWXVYMk5vWldOclgyOTNibVZ5S0NrS0lDQWdJR05oYkd4emRXSWdYMk5vWldOclgyOTNibVZ5Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5allYTmxNbDkzYVhSb1gybHRiWFYwWVdKc1pWOXpkSEoxWTNRdWNIazZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVZMjkxYm5RZ1BDQnpaV3htTG5SMWNGOWlZV2N1ZG1Gc2RXVXVhWFJsYlhNdWJHVnVaM1JvTENBaWRHOXZJRzFoYm5rZ2RIVndjeUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0Y5aVlXY2lDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdkRzl2SUcxaGJua2dkSFZ3Y3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPalV6Q2lBZ0lDQXZMeUJ6Wld4bUxuUjFjRjlpWVdjdWRtRnNkV1V1YVhSbGJYTmJjMlZzWmk1MGRYQmZZbUZuTG5aaGJIVmxMbU52ZFc1MFhTQTlJSFIxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhWd1gySmhaeUlLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG8xTkFvZ0lDQWdMeThnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1OdmRXNTBJQ3M5SURFS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndYMkpoWnlJS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXlaWEJzWVdObElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNURZWE5sTWxkcGRHaEpiVzFUZEhKMVkzUXVYMk5vWldOclgyOTNibVZ5S0NrZ0xUNGdkbTlwWkRvS1gyTm9aV05yWDI5M2JtVnlPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTJGelpUSmZkMmwwYUY5cGJXMTFkR0ZpYkdWZmMzUnlkV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1ZEhWd1gySmhaeTUyWVd4MVpTNWliMjkwYzNSeVlYQndaV1FzSUNKaGNIQWdibTkwSUdKdmIzUnpkSEpoY0hCbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjRjlpWVdjaUNpQWdJQ0JwYm5SaklEVWdMeThnTkRJM01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndJRzV2ZENCaWIyOTBjM1J5WVhCd1pXUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk5oYzJVeVgzZHBkR2hmYVcxdGRYUmhZbXhsWDNOMGNuVmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MblIxY0Y5aVlXY3VkbUZzZFdVdWIzZHVaWElnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJbk5sYm1SbGNpQnViM1FnWVhWMGFHOXlhWHBsWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNGOWlZV2NpQ2lBZ0lDQndkWE5vYVc1MGN5QXhNellnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5sYm1SbGNpQnViM1FnWVhWMGFHOXlhWHBsWkFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyRnpaVEpmZDJsMGFGOXBiVzExZEdGaWJHVmZjM1J5ZFdOMExuQjVPakV5TVFvZ0lDQWdMeThnYzJWc1ppNTBkWEJmWW1GbkxuWmhiSFZsTG1Gd2NDQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDlwWkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhWd1gySmhaeUlLSUNBZ0lIQjFjMmhwYm5RZ01UWTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnUFQwS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTmhjMlV5WDNkcGRHaGZhVzF0ZFhSaFlteGxYM04wY25WamRDNXdlVG94TWpBdE1USXlDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZdWRIVndYMkpoWnk1MllXeDFaUzVoY0hBZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1FLSUNBZ0lDOHZJQ2tzSUNKMGFHbHpJR1Z5Y205eUlITm9iM1ZzWkNCaVpTQnBiWEJ2YzNOcFlteGxJZ29nSUNBZ1lYTnpaWEowSUM4dklIUm9hWE1nWlhKeWIzSWdjMmh2ZFd4a0lHSmxJR2x0Y0c5emMybGliR1VLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUdDQUVRQUlBQnNDRW1BZ2QwZFhCZlltRm5CQlVmZkhVeEcwRUFYREVaRkVReEdFU0NDd1NtZnFLckJBS0lRT29FOTF6dW5RU0lDMVUwQkZNREMwRUVmVG5mVVFSNkhudERCRFJIaEg4RUs2WklVZ1NyeWI1NEJITkZlaGsyR2dDT0N3QUpBREFBT2dCSEFHa0Ftd0RMQU80Qk1nRjFBYm9BTVJrVU1SZ1VFRU1vZ2JFaHVVUW9nWWdCTVFDN01nZ1dLSUdvQVU4Q3V5Z2hCU082SlNOVUtDRUZUd0s3STBNb0pTSzZLVXhRc0NORE5ob0JTUlVrRWtTSUFhNGpRellhQVVrVkloSkVGeWdsSXJvWFN3RU5SQ2dpSVFTNlRDUUxKRmdwVEZDd0kwTWxLQ1VpdWhkTUpVbExBd3hCQUJzb0lpRUV1a3NCSkFza1dFa2xXMDhEQ0V3aVd3aE1Jd2hDLzk1SUZpbE1VTEFqUXpZYUFVY0NKVmxKVGdJa0M0RUNDRXdWRWtRbFNVc0NERUVBRTBzQ1Z3SUFTd0VrQ3lSWWlBRXZJd2hDLytZalF6WWFBVWtWZ1RBU1JDVkpnUU1NUVFBUVNTUUxTd0pNSkZpSUFRd2pDRUwvNlNORE5ob0JTUlVpRWtRWGlBRWZLQ1VpdWhjbFNVc0NERUVBS1NnaUlRUzZTd0VrQzB4TEFTUllWd2dJU3dRV1RGQkxBaUlNUkNKUEFnZ29URThDdXlNSVF2L1FJME0yR2dGSkZTSVNSQmVJQU5zb0pTSzZGeVZKU3dJTVFRQW9LQ0loQkxwTEFTUUxURXNCSkZoWEFBaExCQlpRU3dJaURFUWlUd0lJS0V4UEFyc2pDRUwvMFNORE5ob0JTUlVpRWtRWEtDVWl1aGRMQVlFRENBOUVLQ0loQkxwTEFTUUxTd0ZNSkZoTEFpTUlKQXRMQWt3a1dFOERnUUlJSkF0UEEwd2tXRTRDVUV4UUtVeFFzQ05EZ0FJQUFDZ2xJcm9YVENWSlN3TU1RUUFnS0NJaEJMcExBU1FMSkZoUEFra2xXU01JRmxjR0FGd0FURkJNSXdoQy85bElLVXhRc0NORGlnRUFpQUFnS0NVaXVoZEpJZ3hFSkFzaUNDaE1pLys3S0NVaXVoY2pDQllvSlU4Q3U0a29JUVVqdWlWVFJDaURBb2dCSUxveEFCSkVLSUdvQVNLNkZ6SUlFa1NKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
