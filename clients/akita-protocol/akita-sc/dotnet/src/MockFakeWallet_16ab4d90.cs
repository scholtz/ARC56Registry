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

namespace Arc56.Generated.akita_protocol.akita_sc.MockFakeWallet_16ab4d90
{


    //
    // TEST-ONLY. An app that impersonates an ARC-58 wallet (ACC-01 / SG-04):
    //it stores an attacker-chosen `controlled_address` / `referrer` under the wallet's global
    //keys and registers itself in the EscrowFactory, which accepts any app caller.
    //Never deploy outside tests.
    //
    public class MockFakeWalletProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockFakeWalletProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ResolvedOrigin : AVMObjectType
            {
                public ulong WalletId { get; set; }

                public Algorand.Address Origin { get; set; }

                public Algorand.Address Referrer { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWalletId.From(WalletId);
                    ret.AddRange(vWalletId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOrigin.From(Origin);
                    ret.AddRange(vOrigin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReferrer.From(Referrer);
                    ret.AddRange(vReferrer.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ResolvedOrigin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ResolvedOrigin();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWalletId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWalletId = vWalletId.ToValue();
                    if (valueWalletId is ulong vWalletIdValue) { ret.WalletId = vWalletIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrigin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrigin = vOrigin.ToValue();
                    if (valueOrigin is Algorand.Address vOriginValue) { ret.Origin = vOriginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReferrer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReferrer = vReferrer.ToValue();
                    if (valueReferrer is Algorand.Address vReferrerValue) { ret.Referrer = vReferrerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ResolvedOrigin);
                }
                public bool Equals(ResolvedOrigin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ResolvedOrigin left, ResolvedOrigin right)
                {
                    return EqualityComparer<ResolvedOrigin>.Default.Equals(left, right);
                }
                public static bool operator !=(ResolvedOrigin left, ResolvedOrigin right)
                {
                    return !(left == right);
                }

            }

            public class GatedEnterArgEntries : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[][] Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GatedEnterArgEntries Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GatedEnterArgEntries();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[][] vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GatedEnterArgEntries);
                }
                public bool Equals(GatedEnterArgEntries? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GatedEnterArgEntries left, GatedEnterArgEntries right)
                {
                    return EqualityComparer<GatedEnterArgEntries>.Default.Equals(left, right);
                }
                public static bool operator !=(GatedEnterArgEntries left, GatedEnterArgEntries right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="controlledAddress"> </param>
        /// <param name="referrer"> </param>
        /// <param name="spendingAddress"> </param>
        public async Task Create(Algorand.Address controlledAddress, Algorand.Address referrer, Algorand.Address spendingAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 57, 147, 20 };
            var controlledAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlledAddressAbi.From(controlledAddress);
            var referrerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); referrerAbi.From(referrer);
            var spendingAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spendingAddressAbi.From(spendingAddress);

            var result = await base.CallApp(new List<object> { abiHandle, controlledAddressAbi, referrerAbi, spendingAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address controlledAddress, Algorand.Address referrer, Algorand.Address spendingAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 57, 147, 20 };
            var controlledAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlledAddressAbi.From(controlledAddress);
            var referrerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); referrerAbi.From(referrer);
            var spendingAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spendingAddressAbi.From(spendingAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, controlledAddressAbi, referrerAbi, spendingAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Extra resource slots for grouped calls.
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register this app's own address in the escrow factory (`register(pay, 0)`).
        ///</summary>
        /// <param name="escrowFactory"> </param>
        /// <param name="mbr"> </param>
        public async Task RegisterSelf(ulong escrowFactory, ulong mbr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 122, 251, 214 };
            var escrowFactoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowFactoryAbi.From(escrowFactory);
            var mbrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mbrAbi.From(mbr);

            var result = await base.CallApp(new List<object> { abiHandle, escrowFactoryAbi, mbrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterSelf_Transactions(ulong escrowFactory, ulong mbr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 122, 251, 214 };
            var escrowFactoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowFactoryAbi.From(escrowFactory);
            var mbrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mbrAbi.From(mbr);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowFactoryAbi, mbrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Resolve `address` through the shared helpers exactly as consumer contracts do.
        ///</summary>
        /// <param name="akitaDAO"> </param>
        /// <param name="address"> </param>
        public async Task<Structs.ResolvedOrigin> Probe(ulong akitaDAO, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 44, 15, 123 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ResolvedOrigin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Probe_Transactions(ulong akitaDAO, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 44, 15, 123 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enter a gated staking pool as this app, presenting a gate check for `gateCaller`
        ///(normally the impersonated `controlled_address`).
        ///</summary>
        /// <param name="pool"> </param>
        /// <param name="gate"> </param>
        /// <param name="gateCaller"> </param>
        /// <param name="gateId"> </param>
        /// <param name="gateArgs"> </param>
        /// <param name="payAmount"> </param>
        /// <param name="entries"> GatedEnterArgEntries</param>
        public async Task GatedEnter(ulong pool, ulong gate, Algorand.Address gateCaller, ulong gateId, byte[][] gateArgs, ulong payAmount, Structs.GatedEnterArgEntries[] entries, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 101, 94, 42 };
            var poolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolAbi.From(pool);
            var gateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateAbi.From(gate);
            var gateCallerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); gateCallerAbi.From(gateCaller);
            var gateIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIdAbi.From(gateId);
            var gateArgsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); gateArgsAbi.From(gateArgs);
            var payAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payAmountAbi.From(payAmount);
            var entriesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GatedEnterArgEntries>(x => Structs.GatedEnterArgEntries.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; entriesAbi.From(entries);

            var result = await base.CallApp(new List<object> { abiHandle, poolAbi, gateAbi, gateCallerAbi, gateIdAbi, gateArgsAbi, payAmountAbi, entriesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedEnter_Transactions(ulong pool, ulong gate, Algorand.Address gateCaller, ulong gateId, byte[][] gateArgs, ulong payAmount, Structs.GatedEnterArgEntries[] entries, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 101, 94, 42 };
            var poolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); poolAbi.From(pool);
            var gateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateAbi.From(gate);
            var gateCallerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); gateCallerAbi.From(gateCaller);
            var gateIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); gateIdAbi.From(gateId);
            var gateArgsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); gateArgsAbi.From(gateArgs);
            var payAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payAmountAbi.From(payAmount);
            var entriesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GatedEnterArgEntries>(x => Structs.GatedEnterArgEntries.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; entriesAbi.From(entries);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolAbi, gateAbi, gateCallerAbi, gateIdAbi, gateArgsAbi, payAmountAbi, entriesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0Zha2VXYWxsZXQiLCJkZXNjIjoiVEVTVC1PTkxZLiBBbiBhcHAgdGhhdCBpbXBlcnNvbmF0ZXMgYW4gQVJDLTU4IHdhbGxldCAoQUNDLTAxIC8gU0ctMDQpOlxuaXQgc3RvcmVzIGFuIGF0dGFja2VyLWNob3NlbiBgY29udHJvbGxlZF9hZGRyZXNzYCAvIGByZWZlcnJlcmAgdW5kZXIgdGhlIHdhbGxldCdzIGdsb2JhbFxua2V5cyBhbmQgcmVnaXN0ZXJzIGl0c2VsZiBpbiB0aGUgRXNjcm93RmFjdG9yeSwgd2hpY2ggYWNjZXB0cyBhbnkgYXBwIGNhbGxlci5cbk5ldmVyIGRlcGxveSBvdXRzaWRlIHRlc3RzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJSZXNvbHZlZE9yaWdpbiI6W3sibmFtZSI6IndhbGxldElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im9yaWdpbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVmZXJyZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiR2F0ZWRFbnRlckFyZ0VudHJpZXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJieXRlWzMyXVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJvbGxlZEFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWZlcnJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kaW5nQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcFVwIiwiZGVzYyI6IkV4dHJhIHJlc291cmNlIHNsb3RzIGZvciBncm91cGVkIGNhbGxzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlclNlbGYiLCJkZXNjIjoiUmVnaXN0ZXIgdGhpcyBhcHAncyBvd24gYWRkcmVzcyBpbiB0aGUgZXNjcm93IGZhY3RvcnkgKGByZWdpc3RlcihwYXksIDApYCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd0ZhY3RvcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9iZSIsImRlc2MiOiJSZXNvbHZlIGBhZGRyZXNzYCB0aHJvdWdoIHRoZSBzaGFyZWQgaGVscGVycyBleGFjdGx5IGFzIGNvbnN1bWVyIGNvbnRyYWN0cyBkby4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzKSIsInN0cnVjdCI6IlJlc29sdmVkT3JpZ2luIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2F0ZWRFbnRlciIsImRlc2MiOiJFbnRlciBhIGdhdGVkIHN0YWtpbmcgcG9vbCBhcyB0aGlzIGFwcCwgcHJlc2VudGluZyBhIGdhdGUgY2hlY2sgZm9yIGBnYXRlQ2FsbGVyYFxuKG5vcm1hbGx5IHRoZSBpbXBlcnNvbmF0ZWQgYGNvbnRyb2xsZWRfYWRkcmVzc2ApLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZUNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdhdGVBcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NjQsdWludDY0LGJ5dGVbMzJdW10pW10iLCJzdHJ1Y3QiOiJHYXRlZEVudGVyQXJnRW50cmllcyIsIm5hbWUiOiJlbnRyaWVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzAyXSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5Ml0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJd2x0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE1XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODMsMzk2LDQyMCw3MDJdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjYsNjQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNSw1MzYsNTgwLDYxNCw2NzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGJ5dGVzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL3N0YWtpbmctcG9vbC90eXBlcy50czo6U3Rha2VFbnRyeT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTEsMTIwLDEyOSwyNDEsNTIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NywxNzYsMjI4LDUwMSw1MTAsNTI4LDYwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDIgb2YgKHVpbnQ2NCx1aW50NjQsKGxlbit1aW50OFszMl1bXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50OFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyh1aW50NjQsdWludDY0LChsZW4rdWludDhbMzJdW10pKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWTI5dWRISnZiR3hsWkY5aFpHUnlaWE56SWlBaWNtVm1aWEp5WlhJaUlEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTBaaGEyVlhZV3hzWlhRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGdLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0TlRSa1pXUmxNQ0F3ZURaaU4yRm1ZbVEySURCNFpXSXlZekJtTjJJZ01IZ3pPVFkxTldVeVlTQXZMeUJ0WlhSb2IyUWdJbTl3VlhBb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkR1Z5VTJWc1ppaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkJ5YjJKbEtIVnBiblEyTkN4aFpHUnlaWE56S1NoMWFXNTBOalFzWVdSa2NtVnpjeXhoWkdSeVpYTnpLU0lzSUcxbGRHaHZaQ0FpWjJGMFpXUkZiblJsY2loMWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMExHSjVkR1ZiWFZ0ZExIVnBiblEyTkN3b2RXbHVkRFkwTEhWcGJuUTJOQ3hpZVhSbFd6TXlYVnRkS1Z0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMjl3VlhCZmNtOTFkR1ZBTXlCeVpXZHBjM1JsY2xObGJHWWdjSEp2WW1VZ1oyRjBaV1JGYm5SbGNnb2dJQ0FnWlhKeUNncHRZV2x1WDI5d1ZYQmZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCdmNGVndLQ2s2SUhadmFXUWdleUI5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZabUZyWlMxM1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMXZZMnRHWVd0bFYyRnNiR1YwSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRVek9Ua3pNVFFnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRHWVd0bFYyRnNiR1YwTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5bVlXdGxMWGRoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMlpoYTJVdGQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUdOdmJuUnliMnhzWldSQlpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklFRmljM1J5WVdOMFFXTmpiM1Z1ZEVkc2IySmhiRk4wWVhSbFMyVjVjME52Ym5SeWIyeHNaV1JCWkdSeVpYTnpJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjI1MGNtOXNiR1ZrWDJGa1pISmxjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzEzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdkR2hwY3k1amIyNTBjbTlzYkdWa1FXUmtjbVZ6Y3k1MllXeDFaU0E5SUdOdmJuUnliMnhzWldSQlpHUnlaWE56Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Wm1GclpTMTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2NtVm1aWEp5WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dRV0p6ZEhKaFkzUkJZMk52ZFc1MFIyeHZZbUZzVTNSaGRHVkxaWGx6VW1WbVpYSnlaWElnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbFptVnljbVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0ZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJSFJvYVhNdWNtVm1aWEp5WlhJdWRtRnNkV1VnUFNCeVpXWmxjbkpsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklITndaVzVrYVc1blFXUmtjbVZ6Y3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYTJWNU9pQkJZbk4wY21GamRFRmpZMjkxYm5SSGJHOWlZV3hUZEdGMFpVdGxlWE5UY0dWdVpHbHVaMEZrWkhKbGMzTWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWljM0JsYm1ScGJtZGZZV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCMGFHbHpMbk53Wlc1a2FXNW5RV1JrY21WemN5NTJZV3gxWlNBOUlITndaVzVrYVc1blFXUmtjbVZ6Y3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OW1ZV3RsTFhkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTmIyTnJSbUZyWlZkaGJHeGxkQzV5WldkcGMzUmxjbE5sYkdaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV2RwYzNSbGNsTmxiR1k2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzEzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdjbVZuYVhOMFpYSlRaV3htS0dWelkzSnZkMFpoWTNSdmNuazZJRUZ3Y0d4cFkyRjBhVzl1TENCdFluSTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0ZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFV0TlRFS0lDQWdJQzh2SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRVZ6WTNKdmQwWmhZM1J2Y25rdWNISnZkRzkwZVhCbExuSmxaMmx6ZEdWeVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQmxjMk55YjNkR1lXTjBiM0o1TEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ2FYUjRiaTV3WVhsdFpXNTBLSHNnY21WalpXbDJaWEk2SUdWelkzSnZkMFpoWTNSdmNua3VZV1JrY21WemN5d2dZVzF2ZFc1ME9pQnRZbklnZlNrc0NpQWdJQ0F2THlBZ0lDQWdNQ3dLSUNBZ0lDOHZJQ0FnWFN3S0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzEzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPQW9nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzZ2NtVmpaV2wyWlhJNklHVnpZM0p2ZDBaaFkzUnZjbmt1WVdSa2NtVnpjeXdnWVcxdmRXNTBPaUJ0WW5JZ2ZTa3NDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OW1ZV3RsTFhkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExTFRVeENpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJGYzJOeWIzZEdZV04wYjNKNUxuQnliM1J2ZEhsd1pTNXlaV2RwYzNSbGNqNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2daWE5qY205M1JtRmpkRzl5ZVN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lHbDBlRzR1Y0dGNWJXVnVkQ2g3SUhKbFkyVnBkbVZ5T2lCbGMyTnliM2RHWVdOMGIzSjVMbUZrWkhKbGMzTXNJR0Z0YjNWdWREb2diV0p5SUgwcExBb2dJQ0FnTHk4Z0lDQWdJREFzQ2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYVhSNGJsOXVaWGgwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzEzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5bVlXdGxMWGRoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFMVFV4Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQkZjMk55YjNkR1lXTjBiM0o1TG5CeWIzUnZkSGx3WlM1eVpXZHBjM1JsY2o0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ1pYTmpjbTkzUm1GamRHOXllU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUdsMGVHNHVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUJsYzJOeWIzZEdZV04wYjNKNUxtRmtaSEpsYzNNc0lHRnRiM1Z1ZERvZ2JXSnlJSDBwTEFvZ0lDQWdMeThnSUNBZ0lEQXNDaUFnSUNBdkx5QWdJRjBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpBM1pUY3dORFlnTHk4Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2lod1lYa3NkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Wm1GclpTMTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2NtVm5hWE4wWlhKVFpXeG1LR1Z6WTNKdmQwWmhZM1J2Y25rNklFRndjR3hwWTJGMGFXOXVMQ0J0WW5JNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5bVlXdGxMWGRoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5iMk5yUm1GclpWZGhiR3hsZEM1d2NtOWlaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CeWIySmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCd2NtOWlaU2hoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0c0lHRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQlNaWE52YkhabFpFOXlhV2RwYmlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qSXhDaUFnSUNBdkx5QmpiMjV6ZENCYmIzUm9aWEpCY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpUM1JvWlhKQmNIQk1hWE4wS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSW05aGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNakkyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdaMlYwVDNSb1pYSkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNWxjMk55YjNjS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakl3TmdvZ0lDQWdMeThnWTI5dWMzUWdXMkZ3Y0V4cGMzUkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGEybDBZVVJCVHl3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTkJhMmwwWVVGd2NFeHBjM1FwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRmhiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TXprNENpQWdJQ0F2THlCeVpYUjFjbTRnUVhCd2JHbGpZWFJwYjI0b2JHVm5ZV041VjJGc2JHVjBTVVFvWjJWMFJYTmpjbTkzUm1GamRHOXllU2hoYTJsMFlVUkJUeWtzSUdkbGRFRnJhWFJoUVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1ZDJGc2JHVjBMQ0JoWkdSeVpYTnpLU2tLSUNBZ0lIQjFjMmhwYm5RZ09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalF3TmkwME1Ea0tJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQkZjMk55YjNkR1lXTjBiM0o1TG5CeWIzUnZkSGx3WlM1blpYUStLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJR1Z6WTNKdmQwWmhZM1J2Y25rc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0aFpHUnlaWE56WFFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE0yTXhZVFptTXpNZ0x5OGdiV1YwYUc5a0lDSm5aWFFvWVdSa2NtVnpjeWxpZVhSbFcxMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0o1ZEdWekNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalF4TVFvZ0lDQWdMeThnYVdZZ0tFSjVkR1Z6S0dSaGRHRXBMbXhsYm1kMGFDQWhQVDBnT0NrZ2V3b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdJVDBLSUNBZ0lHSjZJSEJ5YjJKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalF4TWdvZ0lDQWdMeThnY21WMGRYSnVJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3B3Y205aVpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02T214bFoyRmplVmRoYkd4bGRFbEVRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem96TVRRS0lDQWdJQzh2SUdsbUlDaDNZV3hzWlhSSlJDNXBaQ0E5UFQwZ01Da2dld29nSUNBZ1pIVndDaUFnSUNCaWJub2djSEp2WW1WZllXWjBaWEpmYVdaZlpXeHpaVUF4TmdvS2NISnZZbVZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qcHNaV2RoWTNsUGNtbG5hVzVQY2tBeU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk16VTBDaUFnSUNBdkx5QnlaWFIxY200Z2NtVm1aWEp5WlhKUGNpaDNZV3hzWlhSSlJDd2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpLUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pNME53b2dJQ0FnTHk4Z2FXWWdLSGRoYkd4bGRFbEVMbWxrSUQwOVBTQXdLU0I3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTU2SUhCeWIySmxYMkZtZEdWeVgybG1YMlZzYzJWQU16QUtDbkJ5YjJKbFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem82Y21WbVpYSnlaWEpQY2tBek1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0xUWXhDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQjNZV3hzWlhSSlpEb2dkMkZzYkdWMExtbGtMQW9nSUNBZ0x5OGdJQ0J2Y21sbmFXNDZJR3hsWjJGamVVOXlhV2RwYms5eUtIZGhiR3hsZEN3Z1lXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlBZ0lISmxabVZ5Y21WeU9pQnlaV1psY25KbGNrOXlXbVZ5YjBGa1pISmxjM01vZDJGc2JHVjBLU3dLSUNBZ0lDOHZJSDBLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5bVlXdGxMWGRoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QndjbTlpWlNoaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHNJR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUJTWlhOdmJIWmxaRTl5YVdkcGJpQjdDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B3Y205aVpWOWhablJsY2w5cFpsOWxiSE5sUURNd09nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pNMk9DMHpOekVLSUNBZ0lDOHZJR052Ym5OMElGdHlaV1psY25KbGNrSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFJKUkN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselVtVm1aWEp5WlhJcENpQWdJQ0F2THlBcENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TXpjd0NpQWdJQ0F2THlCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOU1pXWmxjbkpsY2lrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbFptVnljbVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem96TmpndE16Y3hDaUFnSUNBdkx5QmpiMjV6ZENCYmNtVm1aWEp5WlhKQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWdLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBTVVFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFKbFptVnljbVZ5S1FvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvek5UUUtJQ0FnSUM4dklISmxkSFZ5YmlCeVpXWmxjbkpsY2s5eUtIZGhiR3hsZEVsRUxDQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXBDaUFnSUNCaUlIQnliMkpsWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZjbVZtWlhKeVpYSlBja0F6TVFvS2NISnZZbVZmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNelU1TFRNMk1nb2dJQ0FnTHk4Z1kyOXVjM1FnVzJOdmJuUnliMnhzWldSQlkyTnZkVzUwUW5sMFpYTXNJR1Y0YVhOMGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5Z0tJQ0FnSUM4dklDQWdkMkZzYkdWMFNVUXNDaUFnSUNBdkx5QWdJRUo1ZEdWektFRmljM1J5WVdOMFFXTmpiM1Z1ZEVkc2IySmhiRk4wWVhSbFMyVjVjME52Ym5SeWIyeHNaV1JCWkdSeVpYTnpLUW9nSUNBZ0x5OGdLUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qTTJNUW9nSUNBZ0x5OGdRbmwwWlhNb1FXSnpkSEpoWTNSQlkyTnZkVzUwUjJ4dlltRnNVM1JoZEdWTFpYbHpRMjl1ZEhKdmJHeGxaRUZrWkhKbGMzTXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiMjUwY205c2JHVmtYMkZrWkhKbGMzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qTTFPUzB6TmpJS0lDQWdJQzh2SUdOdmJuTjBJRnRqYjI1MGNtOXNiR1ZrUVdOamIzVnVkRUo1ZEdWekxDQmxlR2x6ZEhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEVsRUxBb2dJQ0FnTHk4Z0lDQkNlWFJsY3loQlluTjBjbUZqZEVGalkyOTFiblJIYkc5aVlXeFRkR0YwWlV0bGVYTkRiMjUwY205c2JHVmtRV1JrY21WemN5a0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pNMk13b2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR1Y0YVhOMGN5QW1KaUJqYjI1MGNtOXNiR1ZrUVdOamIzVnVkRUo1ZEdWekxteGxibWQwYUNBOVBUMGdNeklzSUdWeWNrbHVkbUZzYVdSWFlXeHNaWFFwQ2lBZ0lDQmllaUJ3Y205aVpWOWliMjlzWDJaaGJITmxRREU1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NISnZZbVZmWW05dmJGOW1ZV3h6WlVBeE9Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuQnliMkpsWDJKdmIyeGZiV1Z5WjJWQU1qQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qTTJNd29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dWNGFYTjBjeUFtSmlCamIyNTBjbTlzYkdWa1FXTmpiM1Z1ZEVKNWRHVnpMbXhsYm1kMGFDQTlQVDBnTXpJc0lHVnlja2x1ZG1Gc2FXUlhZV3hzWlhRcENpQWdJQ0JpYm5vZ2NISnZZbVZmWVdaMFpYSmZZWE56WlhKMFFESXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KSmQyeDBJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2wzYkhRS0NuQnliMkpsWDJGbWRHVnlYMkZ6YzJWeWRFQXlNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNekU0Q2lBZ0lDQXZMeUJwWmlBb2IzSnBaMmx1SUNFOVBTQjNZV3hzWlhSSlJDNWhaR1J5WlhOeklDWW1JRzl5YVdkcGJpQWhQVDBnVkhodUxuTmxibVJsY2lBbUppQnZjbWxuYVc0dVlYVjBhRUZrWkhKbGMzTWdJVDA5SUhkaGJHeGxkRWxFTG1Ga1pISmxjM01wSUhzS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdaR2xuSURJS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ3Y205aVpWOWhablJsY2w5cFpsOWxiSE5sUURJMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdJVDBLSUNBZ0lHSjZJSEJ5YjJKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpZS0lDQWdJR1JwWnlBeENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVGMWRHaEJaR1J5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0FoUFFvZ0lDQWdZbm9nY0hKdlltVmZZV1owWlhKZmFXWmZaV3h6WlVBeU5nb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Wm1GclpTMTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2IzSnBaMmx1T2lCc1pXZGhZM2xQY21sbmFXNVBjaWgzWVd4c1pYUXNJR0ZrWkhKbGMzTXBMQW9nSUNBZ1lpQndjbTlpWlY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPbXhsWjJGamVVOXlhV2RwYms5eVFESTNDZ3B3Y205aVpWOWhablJsY2w5cFpsOWxiSE5sUURJMk9nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5bVlXdGxMWGRoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QnZjbWxuYVc0NklHeGxaMkZqZVU5eWFXZHBiazl5S0hkaGJHeGxkQ3dnWVdSa2NtVnpjeWtzQ2lBZ0lDQmlJSEJ5YjJKbFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem82YkdWbllXTjVUM0pwWjJsdVQzSkFNamNLQ25CeWIySmxYMkp2YjJ4ZlptRnNjMlZBTVRrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ3Y205aVpWOWliMjlzWDIxbGNtZGxRREl3Q2dwd2NtOWlaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qUXhOUW9nSUNBZ0x5OGdZMjl1YzNRZ2QyRnNiR1YwSUQwZ1luUnZhU2hrWVhSaEtRb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pNNE1nb2dJQ0FnTHk4Z2FXWWdLSGRoYkd4bGRDQTlQVDBnTUNCOGZDQjNZV3hzWlhSR1lXTjBiM0o1SUQwOVBTQXdLU0I3Q2lBZ0lDQmllaUJ3Y205aVpWOXBabDlpYjJSNVFEVUtJQ0FnSUdScFp5QXlDaUFnSUNCaWJub2djSEp2WW1WZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2dwd2NtOWlaVjlwWmw5aWIyUjVRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPak00TXdvZ0lDQWdMeThnY21WMGRYSnVJR1poYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvS2NISnZZbVZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qcHBjMEZyYVhSaFYyRnNiR1YwUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME1UWUtJQ0FnSUM4dklISmxkSFZ5YmlCcGMwRnJhWFJoVjJGc2JHVjBLSGRoYkd4bGRDd2dkMkZzYkdWMFJtRmpkRzl5ZVNrZ1B5QjNZV3hzWlhRZ09pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPak01T0FvZ0lDQWdMeThnY21WMGRYSnVJRUZ3Y0d4cFkyRjBhVzl1S0d4bFoyRmplVmRoYkd4bGRFbEVLR2RsZEVWelkzSnZkMFpoWTNSdmNua29ZV3RwZEdGRVFVOHBMQ0JuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbmRoYkd4bGRDd2dZV1JrY21WemN5a3BDaUFnSUNCaUlIQnliMkpsWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZiR1ZuWVdONVYyRnNiR1YwU1VSQU1USUtDbkJ5YjJKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TXpnMUNpQWdJQ0F2THlCamIyNXpkQ0JiWTNKbFlYUnZjaXdnWlhocGMzUnpYU0E5SUc5d0xrRndjRkJoY21GdGN5NWhjSEJEY21WaGRHOXlLSGRoYkd4bGRDa0tJQ0FnSUdSMWNBb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UTNKbFlYUnZjZ29nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPak00TmdvZ0lDQWdMeThnY21WMGRYSnVJR1Y0YVhOMGN5QW1KaUJqY21WaGRHOXlJRDA5UFNCaGNIQkJaR1J5WlhOektIZGhiR3hsZEVaaFkzUnZjbmtwQ2lBZ0lDQmllaUJ3Y205aVpWOWliMjlzWDJaaGJITmxRRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNemMzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdRV05qYjNWdWRDaHZjQzV6YUdFMU1USmZNalUyS0VKNWRHVnpLQ2RoY0hCSlJDY3BMbU52Ym1OaGRDaHBkRzlpS0dGd2NFbGtLU2twS1FvZ0lDQWdaR2xuSURJS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVhCd1NVUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVFV4TWw4eU5UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk16ZzJDaUFnSUNBdkx5QnlaWFIxY200Z1pYaHBjM1J6SUNZbUlHTnlaV0YwYjNJZ1BUMDlJR0Z3Y0VGa1pISmxjM01vZDJGc2JHVjBSbUZqZEc5eWVTa0tJQ0FnSUdScFp5QTBDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NISnZZbVZmWW05dmJGOW1ZV3h6WlVBNUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wTVRZS0lDQWdJQzh2SUhKbGRIVnliaUJwYzBGcmFYUmhWMkZzYkdWMEtIZGhiR3hsZEN3Z2QyRnNiR1YwUm1GamRHOXllU2tnUHlCM1lXeHNaWFFnT2lBd0NpQWdJQ0JpSUhCeWIySmxYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNmFYTkJhMmwwWVZkaGJHeGxkRUF4TVFvS2NISnZZbVZmWW05dmJGOW1ZV3h6WlVBNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRFMkNpQWdJQ0F2THlCeVpYUjFjbTRnYVhOQmEybDBZVmRoYkd4bGRDaDNZV3hzWlhRc0lIZGhiR3hsZEVaaFkzUnZjbmtwSUQ4Z2QyRnNiR1YwSURvZ01Bb2dJQ0FnWWlCd2NtOWlaVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9tbHpRV3RwZEdGWFlXeHNaWFJBTVRFS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzEzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTBaaGEyVlhZV3hzWlhRdVoyRjBaV1JGYm5SbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRoZEdWa1JXNTBaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzEzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQzAzTmdvZ0lDQWdMeThnWjJGMFpXUkZiblJsY2lnS0lDQWdJQzh2SUNBZ2NHOXZiRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lHZGhkR1U2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQm5ZWFJsUTJGc2JHVnlPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0JuWVhSbFNXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdaMkYwWlVGeVozTTZJRWRoZEdWQmNtZHpMQW9nSUNBZ0x5OGdJQ0J3WVhsQmJXOTFiblE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWlc1MGNtbGxjem9nVTNSaGEyVkZiblJ5ZVZ0ZENpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21kaGRHVmtSVzUwWlhKZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ3ROellLSUNBZ0lDOHZJR2RoZEdWa1JXNTBaWElvQ2lBZ0lDQXZMeUFnSUhCdmIydzZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCbllYUmxPaUJCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ1oyRjBaVU5oYkd4bGNqb2dRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdaMkYwWlVsa09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHZGhkR1ZCY21kek9pQkhZWFJsUVhKbmN5d0tJQ0FnSUM4dklDQWdjR0Y1UVcxdmRXNTBPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR1Z1ZEhKcFpYTTZJRk4wWVd0bFJXNTBjbmxiWFFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQm5ZWFJsWkVWdWRHVnlYMkZtZEdWeVgyWnZja0EwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5aHNaVzRyZFdsdWREaGJYU2xiWFNrS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnWjJGMFpXUkZiblJsY2w5bWIzSmZhR1ZoWkdWeVFERUtDbWRoZEdWa1JXNTBaWEpmWVdaMFpYSmZabTl5UURRNkNpQWdJQ0J3YjNCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNExUYzJDaUFnSUNBdkx5Qm5ZWFJsWkVWdWRHVnlLQW9nSUNBZ0x5OGdJQ0J3YjI5c09pQkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnWjJGMFpUb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUdkaGRHVkRZV3hzWlhJNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lHZGhkR1ZKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCbllYUmxRWEpuY3pvZ1IyRjBaVUZ5WjNNc0NpQWdJQ0F2THlBZ0lIQmhlVUZ0YjNWdWREb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmxiblJ5YVdWek9pQlRkR0ZyWlVWdWRISjVXMTBLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhpZVhSbGN6NEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEWUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS2dvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJGMFpXUkZiblJsY2w5bWIzSmZhR1ZoWkdWeVFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Wm1GclpTMTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9DMDNOZ29nSUNBZ0x5OGdaMkYwWldSRmJuUmxjaWdLSUNBZ0lDOHZJQ0FnY0c5dmJEb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUdkaGRHVTZJRUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCbllYUmxRMkZzYkdWeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQm5ZWFJsU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1oyRjBaVUZ5WjNNNklFZGhkR1ZCY21kekxBb2dJQ0FnTHk4Z0lDQndZWGxCYlc5MWJuUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdaVzUwY21sbGN6b2dVM1JoYTJWRmJuUnllVnRkQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lEd0tJQ0FnSUdKNklHZGhkR1ZrUlc1MFpYSmZZV1owWlhKZlptOXlRRGdLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1ptOXlJQ2hzWlc0cktIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Zzek1sMWJYU2twVzEwcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTWlCdlppQW9kV2x1ZERZMExIVnBiblEyTkN3b2JHVnVLM1ZwYm5RNFd6TXlYVnRkS1NrS0lDQWdJSE4zWVhBS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJd0NpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCbllYUmxaRVZ1ZEdWeVgyWnZjbDlvWldGa1pYSkFOUW9LWjJGMFpXUkZiblJsY2w5aFpuUmxjbDltYjNKQU9Eb0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OW1ZV3RsTFhkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0TFRjMkNpQWdJQ0F2THlCbllYUmxaRVZ1ZEdWeUtBb2dJQ0FnTHk4Z0lDQndiMjlzT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdaMkYwWlRvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJR2RoZEdWRFlXeHNaWEk2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdkaGRHVkpaRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JuWVhSbFFYSm5jem9nUjJGMFpVRnlaM01zQ2lBZ0lDQXZMeUFnSUhCaGVVRnRiM1Z1ZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCbGJuUnlhV1Z6T2lCVGRHRnJaVVZ1ZEhKNVcxMEtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeHpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnkxd2IyOXNMM1I1Y0dWekxuUnpPanBUZEdGclpVVnVkSEo1UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyWmhhMlV0ZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemN0T1RJS0lDQWdJQzh2SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRk4wWVd0cGJtZFFiMjlzTG5CeWIzUnZkSGx3WlM1bllYUmxaRVZ1ZEdWeVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQndiMjlzTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ2FYUjRiaTV3WVhsdFpXNTBLSHNnY21WalpXbDJaWEk2SUhCdmIyd3VZV1JrY21WemN5d2dZVzF2ZFc1ME9pQndZWGxCYlc5MWJuUWdmU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYUjRiaTVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUNBZ1lYQndTV1E2SUdkaGRHVXNDaUFnSUNBdkx5QWdJQ0FnSUNCaGNIQkJjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUcxbGRHaHZaRk5sYkdWamRHOXlLRWRoZEdWTmRYTjBRMmhsWTJ0QlltbE5aWFJvYjJRcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCbllYUmxRMkZzYkdWeUxBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCbllYUmxTV1FzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR1Z1WTI5a1pVRnlZelFvWjJGMFpVRnlaM01wTEFvZ0lDQWdMeThnSUNBZ0lDQWdYU3dLSUNBZ0lDOHZJQ0FnSUNCOUtTd0tJQ0FnSUM4dklDQWdJQ0JsYm5SeWFXVnpMQW9nSUNBZ0x5OGdJQ0JkTEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5bVlXdGxMWGRoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QnBkSGh1TG5CaGVXMWxiblFvZXlCeVpXTmxhWFpsY2pvZ2NHOXZiQzVoWkdSeVpYTnpMQ0JoYlc5MWJuUTZJSEJoZVVGdGIzVnVkQ0I5S1N3S0lDQWdJR1JwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OW1ZV3RsTFhkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd4TFRnNUNpQWdJQ0F2THlCcGRIaHVMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5ZWFJsTEFvZ0lDQWdMeThnSUNCaGNIQkJjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdiV1YwYUc5a1UyVnNaV04wYjNJb1IyRjBaVTExYzNSRGFHVmphMEZpYVUxbGRHaHZaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1oyRjBaVU5oYkd4bGNpd0tJQ0FnSUM4dklDQWdJQ0JuWVhSbFNXUXNDaUFnSUNBdkx5QWdJQ0FnWlc1amIyUmxRWEpqTkNobllYUmxRWEpuY3lrc0NpQWdJQ0F2THlBZ0lGMHNDaUFnSUNBdkx5QjlLU3dLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMlpoYTJVdGQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdkaGRHVkpaQ3dLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdlptRnJaUzEzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdiV1YwYUc5a1UyVnNaV04wYjNJb1IyRjBaVTExYzNSRGFHVmphMEZpYVUxbGRHaHZaQ2tzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTXpreU1qWTFOU0F2THlCdFpYUm9iMlFnSW0xMWMzUkRhR1ZqYXloaFpHUnlaWE56TEhWcGJuUTJOQ3hpZVhSbFcxMWJYU2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJaaGEyVXRkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ERXRPRGtLSUNBZ0lDOHZJR2wwZUc0dVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUdkaGRHVXNDaUFnSUNBdkx5QWdJR0Z3Y0VGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCdFpYUm9iMlJUWld4bFkzUnZjaWhIWVhSbFRYVnpkRU5vWldOclFXSnBUV1YwYUc5a0tTd0tJQ0FnSUM4dklDQWdJQ0JuWVhSbFEyRnNiR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHZGhkR1ZKWkN3S0lDQWdJQzh2SUNBZ0lDQmxibU52WkdWQmNtTTBLR2RoZEdWQmNtZHpLU3dLSUNBZ0lDOHZJQ0FnWFN3S0lDQWdJQzh2SUgwcExBb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTltWVd0bExYZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0xUa3lDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCVGRHRnJhVzVuVUc5dmJDNXdjbTkwYjNSNWNHVXVaMkYwWldSRmJuUmxjajRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0c5dmJDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJR2wwZUc0dWNHRjViV1Z1ZENoN0lISmxZMlZwZG1WeU9pQndiMjlzTG1Ga1pISmxjM01zSUdGdGIzVnVkRG9nY0dGNVFXMXZkVzUwSUgwcExBb2dJQ0FnTHk4Z0lDQWdJR2wwZUc0dVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQWdJR0Z3Y0Vsa09pQm5ZWFJsTEFvZ0lDQWdMeThnSUNBZ0lDQWdZWEJ3UVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnRaWFJvYjJSVFpXeGxZM1J2Y2loSFlYUmxUWFZ6ZEVOb1pXTnJRV0pwVFdWMGFHOWtLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdaMkYwWlVOaGJHeGxjaXdLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdaMkYwWlVsa0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCbGJtTnZaR1ZCY21NMEtHZGhkR1ZCY21kektTd0tJQ0FnSUM4dklDQWdJQ0FnSUYwc0NpQWdJQ0F2THlBZ0lDQWdmU2tzQ2lBZ0lDQXZMeUFnSUNBZ1pXNTBjbWxsY3l3S0lDQWdJQzh2SUNBZ1hTd0tJQ0FnSUM4dklIMHBDaUFnSUNCcGRIaHVYMjVsZUhRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptUmpabVJtWmpZZ0x5OGdiV1YwYUc5a0lDSm5ZWFJsWkVWdWRHVnlLSEJoZVN4aGNIQnNMQ2gxYVc1ME5qUXNkV2x1ZERZMExHSjVkR1ZiTXpKZFcxMHBXMTBwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OW1ZV3RsTFhkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0TFRjMkNpQWdJQ0F2THlCbllYUmxaRVZ1ZEdWeUtBb2dJQ0FnTHk4Z0lDQndiMjlzT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdaMkYwWlRvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJR2RoZEdWRFlXeHNaWEk2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdkaGRHVkpaRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JuWVhSbFFYSm5jem9nUjJGMFpVRnlaM01zQ2lBZ0lDQXZMeUFnSUhCaGVVRnRiM1Z1ZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCbGJuUnlhV1Z6T2lCVGRHRnJaVVZ1ZEhKNVcxMEtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUFpWURFbU52Ym5SeWIyeHNaV1JmWVdSa2NtVnpjd2h5WldabGNuSmxjZ1FWSDN4MU1Sa1VSREVZUVFBbWdnUUVoVTN0NEFScmV2dldCT3NzRDNzRU9XVmVLallhQUk0RUFBRUFTZ0NHQVpnQUkwT0FCRlU1a3hRMkdnQ09BUUFCQURZYUFVa1ZnU0FTUkRZYUFra1ZnU0FTUkRZYUEwa1ZnU0FTUkNoUEEyY3BUd0puZ0JCemNHVnVaR2x1WjE5aFpHUnlaWE56VEdjalF6WWFBVWtWSkJKRUZ6WWFBa2tWSkJKRUY3RkxBWElJUkxJSHNnZ2pzaEFpc2dHMkloWk1zaGlBQkdCK2NFYXlHcklhZ1FheUVDS3lBYk1qUXlJMkdnRkpGU1FTUkJjMkdnSkpUZ0pKRllFZ0VrUkxBWUFEYjJGc1pVaUJHRnRQQW9BRFlXRnNaVWlCV0Z0T0E3R3lHSUFFUEJwdk03SWFzaHFCQnJJUUlySUJzN1ErU1ZjRUFFc0JWd0FFS2hKRVNTSlpKUWhNRlJKRVZ3WUFTUlVrRTBFQWRrZ2lTVUFBSERJRFN3RkFBQTFNRms4Q1VFeFFLa3hRc0NORFNFa3BaVWhDLyt0SktHVk1UZ0pCQUVkTEFSV0JJQkpCQUQ0alFBQVBnQXRGVWxJNlpYSnlTWGRzZExBQVNYSUlSRXNDRTBFQUcwc0JNUUFUUVFBVFN3RnpBa1JMQVhJSVJCTkJBQVZGQVVML21rOENTRUwvbENKQy83OFhTVUVBQlVzQ1FBQUlJaUpPQWsxQy8zcEpjZ2RNUlFWQkFCZExBaGFBQldGd2NFbEVURkFEU3dRU1FRQUVJMEwvMlNKQy85VTJHZ0ZKRlNRU1JCYzJHZ0pKRlNRU1JCYzJHZ05KRllFZ0VrUTJHZ1JKRlNRU1JCYzJHZ1ZIQWlKWlNVNENKUXRNU1JWT0FsY0NBQ0pKU3dVTVFRQWhTU1VMU3dKSlR3SlpTVThGU1U0RUVrUkxBUlZTSWxrbENBaE9BaU1JUXYvWVJnSWxDQkpFTmhvR1NSVWtFa1FYTmhvSFNVNENTU0paU1U0Q0pRdE1TUlZPQWxjQ0FDSkpTd1VNUVFBelNTVUxTd0pKVHdKWlNVOEZTVTRFRWtSTEFSVlNTUlZMQVlFUVdVbUJFaEpFVEZJaVdZRWdDNEVVQ0FoT0FpTUlRdi9HUmdKUEFrZ2xDQkpFc1VzSFNYSUlSRThDc2dpeUJ5T3lFQ0t5QWJaTEJCYUFCRU9TSmxXeUdrc0dzaHF5R2tzRHNocExCcklZZ1FheUVDS3lBYmF5R0lBRS9jL2Y5cklhc2hxQkJySVFJcklCc3lORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
