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

namespace Arc56.Generated.akita_protocol.akita_sc.MockPrincipalProbe_b4b6c7b2
{


    //
    // TEST-ONLY. Principal-resolution probe (docs/principal-resolution/PHASE-0-SPEC.md §5.1).
    //Every method resolves through the DAO-aware wrappers in utils/functions.ts, with the wallet
    //factory pinned to `AkitaAppList(this.akitaDAO).wallet`. Never deploy outside tests.
    //
    public class MockPrincipalProbeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockPrincipalProbeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GateCtx : AVMObjectType
            {
                public Algorand.Address Principal { get; set; }

                public ulong Wallet { get; set; }

                public Algorand.Address Spender { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPrincipal.From(Principal);
                    ret.AddRange(vPrincipal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSpender.From(Spender);
                    ret.AddRange(vSpender.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GateCtx Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GateCtx();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrincipal = vPrincipal.ToValue();
                    if (valuePrincipal is Algorand.Address vPrincipalValue) { ret.Principal = vPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is ulong vWalletValue) { ret.Wallet = vWalletValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GateCtx);
                }
                public bool Equals(GateCtx? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GateCtx left, GateCtx right)
                {
                    return EqualityComparer<GateCtx>.Default.Equals(left, right);
                }
                public static bool operator !=(GateCtx left, GateCtx right)
                {
                    return !(left == right);
                }

            }

            public class Principal : AVMObjectType
            {
                public ulong Wallet { get; set; }

                public Algorand.Address Principal { get; set; }

                public Algorand.Address Origin { get; set; }

                public Algorand.Address Spender { get; set; }

                public Algorand.Address Referrer { get; set; }

                public bool ViaPlugin { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPrincipal.From(Principal);
                    ret.AddRange(vPrincipal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOrigin.From(Origin);
                    ret.AddRange(vOrigin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSpender.From(Spender);
                    ret.AddRange(vSpender.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReferrer.From(Referrer);
                    ret.AddRange(vReferrer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vViaPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vViaPlugin.From(ViaPlugin);
                    ret.AddRange(vViaPlugin.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Principal Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Principal();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is ulong vWalletValue) { ret.Wallet = vWalletValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrincipal = vPrincipal.ToValue();
                    if (valuePrincipal is Algorand.Address vPrincipalValue) { ret.Principal = vPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrigin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrigin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrigin = vOrigin.ToValue();
                    if (valueOrigin is Algorand.Address vOriginValue) { ret.Origin = vOriginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReferrer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReferrer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReferrer = vReferrer.ToValue();
                    if (valueReferrer is Algorand.Address vReferrerValue) { ret.Referrer = vReferrerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vViaPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vViaPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueViaPlugin = vViaPlugin.ToValue();
                    if (valueViaPlugin is bool vViaPluginValue) { ret.ViaPlugin = vViaPluginValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Principal);
                }
                public bool Equals(Principal? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Principal left, Principal right)
                {
                    return EqualityComparer<Principal>.Default.Equals(left, right);
                }
                public static bool operator !=(Principal left, Principal right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        public async Task Create(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Strict first-hop resolution (`principalOf`).
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.Principal> Probe(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 217, 10, 170 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Probe_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 217, 10, 170 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Non-reverting variant (`tryPrincipalOf`).
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.Principal> TryProbe(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 238, 177, 152 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TryProbe_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 238, 177, 152 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T32: opcode cost of the strict `principalOf(dao, wallet)` call (Global.opcodeBudget delta; includes the
        ///AkitaAppList read and the subroutine call overhead).
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<ulong> ProbeCost(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 151, 168, 216 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProbeCost_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 151, 168, 216 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///V0.1: what the callee observes as `Txn.sender.authAddress` (RekeyTo is already applied).
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Algorand.Address> ProbeAuth(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 108, 199, 199 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> ProbeAuth_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 108, 199, 199 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Algorand.Address> Quote(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 180, 151, 183 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Quote_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 180, 151, 183 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="account"> </param>
        public async Task<bool> Owns(ulong wallet, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 49, 180, 101 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Owns_Transactions(ulong wallet, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 49, 180, 101 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="wallet"> </param>
        /// <param name="stored"> </param>
        public async Task<Algorand.Address> AtRest(Algorand.Address account, ulong wallet, Algorand.Address stored, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 120, 160, 173 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var storedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); storedAbi.From(stored);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi, walletAbi, storedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> AtRest_Transactions(Algorand.Address account, ulong wallet, Algorand.Address stored, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 120, 160, 173 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var storedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); storedAbi.From(stored);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, walletAbi, storedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///QUOTE-ONLY variant that reads W.controlled_address.
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="wallet"> </param>
        public async Task<Algorand.Address> ThirdParty(Algorand.Address account, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 226, 230, 75 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> ThirdParty_Transactions(Algorand.Address account, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 226, 230, 75 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ctx"> GateCtx</param>
        /// <param name="account"> </param>
        public async Task<bool> CtxOwns(Structs.GateCtx ctx, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 237, 30, 182 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, ctx, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CtxOwns_Transactions(Structs.GateCtx ctx, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 237, 30, 182 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, ctx, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///`tipWallet(dao, creator, stored)`: the tip-routing wallet, or 0 for a direct tip.
        ///</summary>
        /// <param name="creator"> </param>
        /// <param name="stored"> </param>
        public async Task<ulong> TipWalletOf(Algorand.Address creator, ulong stored, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 150, 244, 46 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var storedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); storedAbi.From(stored);

            var result = await base.SimApp(new List<object> { abiHandle, creatorAbi, storedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TipWalletOf_Transactions(Algorand.Address creator, ulong stored, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 150, 244, 46 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var storedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); storedAbi.From(stored);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorAbi, storedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///`gateCheckCtx(gateTxn, dao, ctx, id)` against the gate named by this probe's DAO.
        ///</summary>
        /// <param name="gateTxn"> </param>
        /// <param name="ctx"> GateCtx</param>
        /// <param name="id"> </param>
        public async Task<bool> GateCheckCtxOf(ApplicationCallTransaction gateTxn, Structs.GateCtx ctx, ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn });
            byte[] abiHandle = { 200, 217, 165, 150 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, gateTxn, ctx, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GateCheckCtxOf_Transactions(ApplicationCallTransaction gateTxn, Structs.GateCtx ctx, ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { gateTxn });
            byte[] abiHandle = { 200, 217, 165, 150 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, gateTxn, ctx, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Strict resolution, returned as the gate context `{ principal, wallet, spender }`.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.GateCtx> ProbeCtx(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 250, 163, 104 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GateCtx.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProbeCtx_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 250, 163, 104 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Nested-call test (E12/T17): this app calls `target.probe(wallet)` as itself.
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="wallet"> </param>
        public async Task<Structs.Principal> Relay(ulong target, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 92, 112, 236 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAbi.From(target);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Relay_Transactions(ulong target, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 92, 112, 236 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAbi.From(target);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T27: `relay` with the non-reverting `target.tryProbe(wallet)`.
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="wallet"> </param>
        public async Task<Structs.Principal> TryRelay(ulong target, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 212, 33, 214 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAbi.From(target);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TryRelay_Transactions(ulong target, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 212, 33, 214 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAbi.From(target);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T43: resolve with the factory read from THIS app's own DAO only (never from the wallet).
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.Principal> PinnedFactoryProbe(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 28, 26, 99 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PinnedFactoryProbe_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 28, 26, 99 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T43 negative control: the FORBIDDEN derivation `AkitaAppList(W.akita_dao).wallet`. A wallet admin
        ///can repoint `akita_dao`, so this value is attacker-controlled.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<ulong> UnpinnedFactory(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 95, 97, 67 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UnpinnedFactory_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 95, 97, 67 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///`isGenuineWallet(wallet, factory)` for an arbitrary factory (T43 negative control).
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="factory"> </param>
        public async Task<bool> GenuineFor(ulong wallet, ulong factory, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 58, 192, 226 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var factoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factoryAbi.From(factory);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi, factoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GenuineFor_Transactions(ulong wallet, ulong factory, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 58, 192, 226 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var factoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factoryAbi.From(factory);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, factoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///The DAO's wallet factory as this probe pins it.
        ///</summary>
        public async Task<ulong> PinnedFactory(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 143, 33, 121 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PinnedFactory_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 143, 33, 121 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///The caller-app context this call observes (diagnostics).
        ///</summary>
        public async Task<ulong> CallerApp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 54, 37, 171 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallerApp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 54, 37, 171 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja1ByaW5jaXBhbFByb2JlIiwiZGVzYyI6IlRFU1QtT05MWS4gUHJpbmNpcGFsLXJlc29sdXRpb24gcHJvYmUgKGRvY3MvcHJpbmNpcGFsLXJlc29sdXRpb24vUEhBU0UtMC1TUEVDLm1kIMKnNS4xKS5cbkV2ZXJ5IG1ldGhvZCByZXNvbHZlcyB0aHJvdWdoIHRoZSBEQU8tYXdhcmUgd3JhcHBlcnMgaW4gdXRpbHMvZnVuY3Rpb25zLnRzLCB3aXRoIHRoZSB3YWxsZXRcbmZhY3RvcnkgcGlubmVkIHRvIGBBa2l0YUFwcExpc3QodGhpcy5ha2l0YURBTykud2FsbGV0YC4gTmV2ZXIgZGVwbG95IG91dHNpZGUgdGVzdHMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdhdGVDdHgiOlt7Im5hbWUiOiJwcmluY2lwYWwiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6IndhbGxldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzcGVuZGVyIiwidHlwZSI6ImFkZHJlc3MifV0sIlByaW5jaXBhbCI6W3sibmFtZSI6IndhbGxldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcmluY2lwYWwiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im9yaWdpbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3BlbmRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVmZXJyZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InZpYVBsdWdpbiIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJha2l0YURBTyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcFVwIiwiZGVzYyI6IkV4dHJhIHJlc291cmNlIHNsb3RzIGZvciBncm91cGVkIGNhbGxzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9iZSIsImRlc2MiOiJTdHJpY3QgZmlyc3QtaG9wIHJlc29sdXRpb24gKGBwcmluY2lwYWxPZmApLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGJvb2wpIiwic3RydWN0IjoiUHJpbmNpcGFsIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJ5UHJvYmUiLCJkZXNjIjoiTm9uLXJldmVydGluZyB2YXJpYW50IChgdHJ5UHJpbmNpcGFsT2ZgKS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2JlQ29zdCIsImRlc2MiOiJUMzI6IG9wY29kZSBjb3N0IG9mIHRoZSBzdHJpY3QgYHByaW5jaXBhbE9mKGRhbywgd2FsbGV0KWAgY2FsbCAoR2xvYmFsLm9wY29kZUJ1ZGdldCBkZWx0YTsgaW5jbHVkZXMgdGhlXG5Ba2l0YUFwcExpc3QgcmVhZCBhbmQgdGhlIHN1YnJvdXRpbmUgY2FsbCBvdmVyaGVhZCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2JlQXV0aCIsImRlc2MiOiJWMC4xOiB3aGF0IHRoZSBjYWxsZWUgb2JzZXJ2ZXMgYXMgYFR4bi5zZW5kZXIuYXV0aEFkZHJlc3NgIChSZWtleVRvIGlzIGFscmVhZHkgYXBwbGllZCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJxdW90ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvd25zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhdFJlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0b3JlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRoaXJkUGFydHkiLCJkZXNjIjoiUVVPVEUtT05MWSB2YXJpYW50IHRoYXQgcmVhZHMgVy5jb250cm9sbGVkX2FkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjdHhPd25zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkdhdGVDdHgiLCJuYW1lIjoiY3R4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRpcFdhbGxldE9mIiwiZGVzYyI6ImB0aXBXYWxsZXQoZGFvLCBjcmVhdG9yLCBzdG9yZWQpYDogdGhlIHRpcC1yb3V0aW5nIHdhbGxldCwgb3IgMCBmb3IgYSBkaXJlY3QgdGlwLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnYXRlQ2hlY2tDdHhPZiIsImRlc2MiOiJgZ2F0ZUNoZWNrQ3R4KGdhdGVUeG4sIGRhbywgY3R4LCBpZClgIGFnYWluc3QgdGhlIGdhdGUgbmFtZWQgYnkgdGhpcyBwcm9iZSdzIERBTy4iLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdhdGVUeG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkdhdGVDdHgiLCJuYW1lIjoiY3R4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9iZUN0eCIsImRlc2MiOiJTdHJpY3QgcmVzb2x1dGlvbiwgcmV0dXJuZWQgYXMgdGhlIGdhdGUgY29udGV4dCBgeyBwcmluY2lwYWwsIHdhbGxldCwgc3BlbmRlciB9YC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkdhdGVDdHgiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxheSIsImRlc2MiOiJOZXN0ZWQtY2FsbCB0ZXN0IChFMTIvVDE3KTogdGhpcyBhcHAgY2FsbHMgYHRhcmdldC5wcm9iZSh3YWxsZXQpYCBhcyBpdHNlbGYuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyeVJlbGF5IiwiZGVzYyI6IlQyNzogYHJlbGF5YCB3aXRoIHRoZSBub24tcmV2ZXJ0aW5nIGB0YXJnZXQudHJ5UHJvYmUod2FsbGV0KWAuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBpbm5lZEZhY3RvcnlQcm9iZSIsImRlc2MiOiJUNDM6IHJlc29sdmUgd2l0aCB0aGUgZmFjdG9yeSByZWFkIGZyb20gVEhJUyBhcHAncyBvd24gREFPIG9ubHkgKG5ldmVyIGZyb20gdGhlIHdhbGxldCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCkiLCJzdHJ1Y3QiOiJQcmluY2lwYWwiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnBpbm5lZEZhY3RvcnkiLCJkZXNjIjoiVDQzIG5lZ2F0aXZlIGNvbnRyb2w6IHRoZSBGT1JCSURERU4gZGVyaXZhdGlvbiBgQWtpdGFBcHBMaXN0KFcuYWtpdGFfZGFvKS53YWxsZXRgLiBBIHdhbGxldCBhZG1pblxuY2FuIHJlcG9pbnQgYGFraXRhX2Rhb2AsIHNvIHRoaXMgdmFsdWUgaXMgYXR0YWNrZXItY29udHJvbGxlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZW51aW5lRm9yIiwiZGVzYyI6ImBpc0dlbnVpbmVXYWxsZXQod2FsbGV0LCBmYWN0b3J5KWAgZm9yIGFuIGFyYml0cmFyeSBmYWN0b3J5IChUNDMgbmVnYXRpdmUgY29udHJvbCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmFjdG9yeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBpbm5lZEZhY3RvcnkiLCJkZXNjIjoiVGhlIERBTydzIHdhbGxldCBmYWN0b3J5IGFzIHRoaXMgcHJvYmUgcGlucyBpdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxlckFwcCIsImRlc2MiOiJUaGUgY2FsbGVyLWFwcCBjb250ZXh0IHRoaXMgY2FsbCBvYnNlcnZlcyAoZGlhZ25vc3RpY3MpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTM0LDE1OTVdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIxXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckhuYmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDFdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySG53bCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzM10sImVycm9yTWVzc2FnZSI6IkVSUjplcnJIdG9wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckl3bHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDcsNzcwLDgxMSw4NjYsOTMwLDk4NiwxMDc5LDExNjUsMTI1MywxMzU5LDE0NTcsMTYyMSwxNzA3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI2LDk2MSw5ODIsMTA2MywxMTYxLDEyMzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI4LDc0Miw3NjUsODA0LDg0MSw4NjAsOTE3LDk2OSwxMDcxLDEyNDcsMTM1MywxNDUyLDE0OTQsMTUwMywxNTU1LDE1NjQsMTYxNiwxNjU1LDE2NzksMTY4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTAsMTM0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvdXRpbHMvcHJpbmNpcGFsLnRzOjpHYXRlQ3R4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0MSwxNjAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy91dGlscy9wcmluY2lwYWwudHM6OlByaW5jaXBhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFwcGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaVlXdHBkR0ZmWkdGdklpQWlZV0ZzSWlBd2VEQXdJQ0pqYjI1MGNtOXNiR1ZrWDJGa1pISmxjM01pSURCNE16SmtPVEJoWVdFZ01IZzROV1ZsWWpFNU9DQWljbVZtWlhKeVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmIyTnJVSEpwYm1OcGNHRnNVSEp2WW1VZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREkwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TlRSa1pXUmxNQ0F2THlCdFpYUm9iMlFnSW05d1ZYQW9LWFp2YVdRaUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUcxbGRHaHZaQ0FpY0hKdlltVW9kV2x1ZERZMEtTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhpYjI5c0tTSUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z2JXVjBhRzlrSUNKMGNubFFjbTlpWlNoMWFXNTBOalFwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHSnZiMndwSWdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdVek9UZGhPR1E0SURCNFkyWTJZMk0zWXpjZ01IZ3hNMkkwT1RkaU55QXdlRE00TXpGaU5EWTFJREI0TTJJM09HRXdZV1FnTUhneE0yVXlaVFkwWWlBd2VEaGlaV1F4WldJMklEQjRaRE01Tm1ZME1tVWdNSGhqT0dRNVlUVTVOaUF3ZUdZM1ptRmhNelk0SURCNFlqVTFZemN3WldNZ01IaGlaR1EwTWpGa05pQXdlR0ZqTVdNeFlUWXpJREI0TmpRMVpqWXhORE1nTUhnNE56TmhZekJsTWlBd2VETmpPR1l5TVRjNUlEQjRaalF6TmpJMVlXSWdMeThnYldWMGFHOWtJQ0p3Y205aVpVTnZjM1FvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljSEp2WW1WQmRYUm9LSFZwYm5RMk5DbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSnhkVzkwWlNoMWFXNTBOalFwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpYjNkdWN5aDFhVzUwTmpRc1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0poZEZKbGMzUW9ZV1JrY21WemN5eDFhVzUwTmpRc1lXUmtjbVZ6Y3lsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKMGFHbHlaRkJoY25SNUtHRmtaSEpsYzNNc2RXbHVkRFkwS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1OMGVFOTNibk1vS0dGa1pISmxjM01zZFdsdWREWTBMR0ZrWkhKbGMzTXBMR0ZrWkhKbGMzTXBZbTl2YkNJc0lHMWxkR2h2WkNBaWRHbHdWMkZzYkdWMFQyWW9ZV1JrY21WemN5eDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKbllYUmxRMmhsWTJ0RGRIaFBaaWhoY0hCc0xDaGhaR1J5WlhOekxIVnBiblEyTkN4aFpHUnlaWE56S1N4MWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWljSEp2WW1WRGRIZ29kV2x1ZERZMEtTaGhaR1J5WlhOekxIVnBiblEyTkN4aFpHUnlaWE56S1NJc0lHMWxkR2h2WkNBaWNtVnNZWGtvZFdsdWREWTBMSFZwYm5RMk5Da29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zWW05dmJDa2lMQ0J0WlhSb2IyUWdJblJ5ZVZKbGJHRjVLSFZwYm5RMk5DeDFhVzUwTmpRcEtIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0p2YjJ3cElpd2diV1YwYUc5a0lDSndhVzV1WldSR1lXTjBiM0o1VUhKdlltVW9kV2x1ZERZMEtTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhpYjI5c0tTSXNJRzFsZEdodlpDQWlkVzV3YVc1dVpXUkdZV04wYjNKNUtIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGJuVnBibVZHYjNJb2RXbHVkRFkwTEhWcGJuUTJOQ2xpYjI5c0lpd2diV1YwYUc5a0lDSndhVzV1WldSR1lXTjBiM0o1S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1OaGJHeGxja0Z3Y0NncGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl2Y0ZWd1gzSnZkWFJsUURNZ2NISnZZbVVnZEhKNVVISnZZbVVnY0hKdlltVkRiM04wSUhCeWIySmxRWFYwYUNCeGRXOTBaU0J2ZDI1eklHRjBVbVZ6ZENCMGFHbHlaRkJoY25SNUlHTjBlRTkzYm5NZ2RHbHdWMkZzYkdWMFQyWWdaMkYwWlVOb1pXTnJRM1I0VDJZZ2NISnZZbVZEZEhnZ2NtVnNZWGtnZEhKNVVtVnNZWGtnY0dsdWJtVmtSbUZqZEc5eWVWQnliMkpsSUhWdWNHbHVibVZrUm1GamRHOXllU0JuWlc1MWFXNWxSbTl5SUhCcGJtNWxaRVpoWTNSdmNua2dZMkZzYkdWeVFYQndDaUFnSUNCbGNuSUtDbTFoYVc1ZmIzQlZjRjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJ2Y0ZWd0tDazZJSFp2YVdRZ2V5QjlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREkwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTFCeWFXNWphWEJoYkZCeWIySmxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNalF3WkRKbU5qY2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9uQnNZV2x1VUhKcGJtTnBjR0ZzS0hObGJtUmxjam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3B3YkdGcGJsQnlhVzVqYVhCaGJEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9Ea0tJQ0FnSUM4dklHWjFibU4wYVc5dUlIQnNZV2x1VUhKcGJtTnBjR0ZzS0hObGJtUmxjam9nUVdOamIzVnVkQ2s2SUZCeWFXNWphWEJoYkNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPVE1LSUNBZ0lDOHZJRzl5YVdkcGJqb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2prMUNpQWdJQ0F2THlCeVpXWmxjbkpsY2pvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2preENpQWdJQ0F2THlCM1lXeHNaWFE2SURBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem81TUMwNU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lBd0xBb2dJQ0FnTHk4Z0lDQndjbWx1WTJsd1lXdzZJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdiM0pwWjJsdU9pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSE53Wlc1a1pYSTZJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjbVZtWlhKeVpYSTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnZG1saFVHeDFaMmx1T2lCbVlXeHpaU3dLSUNBZ0lDOHZJSDBLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9tbHpSMlZ1ZFdsdVpWZGhiR3hsZENoM1lXeHNaWFE2SUhWcGJuUTJOQ3dnZDJGc2JHVjBSbUZqZEc5eWVUb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbWx6UjJWdWRXbHVaVmRoYkd4bGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UQXhDaUFnSUNBdkx5QmxlSEJ2Y25RZ1puVnVZM1JwYjI0Z2FYTkhaVzUxYVc1bFYyRnNiR1YwS0hkaGJHeGxkRG9nZFdsdWREWTBMQ0IzWVd4c1pYUkdZV04wYjNKNU9pQjFhVzUwTmpRcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVEF5Q2lBZ0lDQXZMeUJwWmlBb2QyRnNiR1YwSUQwOVBTQXdJSHg4SUhkaGJHeGxkRVpoWTNSdmNua2dQVDA5SURBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5vZ2FYTkhaVzUxYVc1bFYyRnNiR1YwWDJsbVgySnZaSGxBTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlibm9nYVhOSFpXNTFhVzVsVjJGc2JHVjBYMkZtZEdWeVgybG1YMlZzYzJWQU13b0thWE5IWlc1MWFXNWxWMkZzYkdWMFgybG1YMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21selIyVnVkV2x1WlZkaGJHeGxkRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXdOUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyTnlaV0YwYjNJc0lHVjRhWE4wYzEwZ1BTQnZjQzVCY0hCUVlYSmhiWE11WVhCd1EzSmxZWFJ2Y2loM1lXeHNaWFFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFTnlaV0YwYjNJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94TURZS0lDQWdJQzh2SUhKbGRIVnliaUJsZUdsemRITWdKaVlnWTNKbFlYUnZjaUE5UFQwZ1lYQndRV1JrY21WemMwOW1LSGRoYkd4bGRFWmhZM1J2Y25rcENpQWdJQ0JpZWlCcGMwZGxiblZwYm1WWFlXeHNaWFJmWW05dmJGOW1ZV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pjMENpQWdJQ0F2THlCeVpYUjFjbTRnUVdOamIzVnVkQ2h2Y0M1emFHRTFNVEpmTWpVMktFSjVkR1Z6S0NkaGNIQkpSQ2NwTG1OdmJtTmhkQ2h2Y0M1cGRHOWlLR0Z3Y0Vsa0tTa3BLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRndjRWxFSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6YUdFMU1USmZNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakV3TmdvZ0lDQWdMeThnY21WMGRYSnVJR1Y0YVhOMGN5QW1KaUJqY21WaGRHOXlJRDA5UFNCaGNIQkJaR1J5WlhOelQyWW9kMkZzYkdWMFJtRmpkRzl5ZVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQTlQUW9nSUNBZ1lub2dhWE5IWlc1MWFXNWxWMkZzYkdWMFgySnZiMnhmWm1Gc2MyVkFOZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbWx6UjJWdWRXbHVaVmRoYkd4bGRGOWliMjlzWDIxbGNtZGxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakV3TmdvZ0lDQWdMeThnY21WMGRYSnVJR1Y0YVhOMGN5QW1KaUJqY21WaGRHOXlJRDA5UFNCaGNIQkJaR1J5WlhOelQyWW9kMkZzYkdWMFJtRmpkRzl5ZVNrS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0thWE5IWlc1MWFXNWxWMkZzYkdWMFgySnZiMnhmWm1Gc2MyVkFOam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHbHpSMlZ1ZFdsdVpWZGhiR3hsZEY5aWIyOXNYMjFsY21kbFFEY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwM1lXeHNaWFJEYjI1MGNtOXNjMHhwZG1Vb2QyRnNiR1YwT2lCMWFXNTBOalFzSUdOdmJuUnliMnhzWldRNklHSjVkR1Z6TENCemNHVnVaR1Z5T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwM1lXeHNaWFJEYjI1MGNtOXNjMHhwZG1VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFeE9Bb2dJQ0FnTHk4Z1puVnVZM1JwYjI0Z2QyRnNiR1YwUTI5dWRISnZiSE5NYVhabEtIZGhiR3hsZERvZ2RXbHVkRFkwTENCamIyNTBjbTlzYkdWa09pQkJZMk52ZFc1MExDQnpjR1Z1WkdWeU9pQkJZMk52ZFc1MEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRFNUNpQWdJQ0F2THlCcFppQW9ZMjl1ZEhKdmJHeGxaQ0E5UFQwZ2MzQmxibVJsY2lrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDA5Q2lBZ0lDQmllaUIzWVd4c1pYUkRiMjUwY205c2MweHBkbVZmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXlNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUnpkV0lLQ25kaGJHeGxkRU52Ym5SeWIyeHpUR2wyWlY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakV5TWdvZ0lDQWdMeThnWTI5dWMzUWdXM2RoYkd4bGRFRmtaSEpsYzNNc0lIZGhiR3hsZEVWNGFYTjBjMTBnUFNCdmNDNUJjSEJRWVhKaGJYTXVZWEJ3UVdSa2NtVnpjeWgzWVd4c1pYUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVEl6Q2lBZ0lDQXZMeUJwWmlBb0lYZGhiR3hsZEVWNGFYTjBjeWtnZXdvZ0lDQWdZbTU2SUhkaGJHeGxkRU52Ym5SeWIyeHpUR2wyWlY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVEkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdabUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NuZGhiR3hsZEVOdmJuUnliMnh6VEdsMlpWOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFeU5nb2dJQ0FnTHk4Z2FXWWdLR052Ym5SeWIyeHNaV1FnUFQwOUlIZGhiR3hsZEVGa1pISmxjM01wSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmllaUIzWVd4c1pYUkRiMjUwY205c2MweHBkbVZmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qZzFDaUFnSUNBdkx5QmpiMjV6ZENCYllYVjBhRjBnUFNCdmNDNUJZMk4wVUdGeVlXMXpMbUZqWTNSQmRYUm9RV1JrY2loaFkyTnZkVzUwS1FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JCZFhSb1FXUmtjZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXlOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRjFkR2hCWkdSeVQyWW9kMkZzYkdWMFFXUmtjbVZ6Y3lrZ1BUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdjbVYwYzNWaUNncDNZV3hzWlhSRGIyNTBjbTlzYzB4cGRtVmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pvNE5Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzJGMWRHaGRJRDBnYjNBdVFXTmpkRkJoY21GdGN5NWhZMk4wUVhWMGFFRmtaSElvWVdOamIzVnVkQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUkJkWFJvUVdSa2Nnb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFeU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGMWRHaEJaR1J5VDJZb1kyOXVkSEp2Ykd4bFpDa2dQVDA5SUhkaGJHeGxkRUZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pweVpYTnZiSFpsVUhKcGJtTnBjR0ZzUTNSNEtIZGhiR3hsZEVaaFkzUnZjbms2SUhWcGJuUTJOQ3dnYUdsdWREb2dkV2x1ZERZMExDQnpaVzVrWlhJNklHSjVkR1Z6TENCallXeHNaWEpCY0hBNklIVnBiblEyTkN3Z1kyRnNiR1Z5UVdSa2Nqb2dZbmwwWlhNc0lITjBjbWxqZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2NtVnpiMngyWlZCeWFXNWphWEJoYkVOMGVEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UUXdMVEUwTndvZ0lDQWdMeThnWm5WdVkzUnBiMjRnY21WemIyeDJaVkJ5YVc1amFYQmhiRU4wZUNnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwUm1GamRHOXllVG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JvYVc1ME9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1kyRnNiR1Z5UVhCd09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHTmhiR3hsY2tGa1pISTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJSE4wY21samREb2dZbTl2YkdWaGJnb2dJQ0FnTHk4Z0tUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lIQnliM1J2SURZZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRRNENpQWdJQ0F2THlCcFppQW9hR2x1ZENBOVBUMGdNQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmlibm9nY21WemIyeDJaVkJ5YVc1amFYQmhiRU4wZUY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVFE1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjR3hoYVc1UWNtbHVZMmx3WVd3b2MyVnVaR1Z5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpZV3hzYzNWaUlIQnNZV2x1VUhKcGJtTnBjR0ZzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NuSmxjMjlzZG1WUWNtbHVZMmx3WVd4RGRIaGZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE5USUtJQ0FnSUM4dklHbG1JQ2doYVhOSFpXNTFhVzVsVjJGc2JHVjBLR2hwYm5Rc0lIZGhiR3hsZEVaaFkzUnZjbmtwS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdZMkZzYkhOMVlpQnBjMGRsYm5WcGJtVlhZV3hzWlhRS0lDQWdJR0p1ZWlCeVpYTnZiSFpsVUhKcGJtTnBjR0ZzUTNSNFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94TlRNS0lDQWdJQzh2SUdsbUlDaHpkSEpwWTNRcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5vZ2NtVnpiMngyWlZCeWFXNWphWEJoYkVOMGVGOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRVMENpQWdJQ0F2THlCc2IyZG5aV1JGY25Jb1pYSnlTR2x1ZEU1dmRGZGhiR3hsZENrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnlja2h1ZDJ3aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNHNTNiQW9LY21WemIyeDJaVkJ5YVc1amFYQmhiRU4wZUY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakUxTmdvZ0lDQWdMeThnY21WMGRYSnVJSEJzWVdsdVVISnBibU5wY0dGc0tITmxibVJsY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMkZzYkhOMVlpQndiR0ZwYmxCeWFXNWphWEJoYkFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncHlaWE52YkhabFVISnBibU5wY0dGc1EzUjRYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UVTVDaUFnSUNBdkx5QnBaaUFvWTJGc2JHVnlRWEJ3SUQwOVBTQXdLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSnVlaUJ5WlhOdmJIWmxVSEpwYm1OcGNHRnNRM1I0WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVFl3Q2lBZ0lDQXZMeUJwWmlBb2MzUnlhV04wS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o2SUhKbGMyOXNkbVZRY21sdVkybHdZV3hEZEhoZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakUyTVFvZ0lDQWdMeThnYkc5bloyVmtSWEp5S0dWeWNraHBiblJVYjNCTVpYWmxiQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNraDBiM0FpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U0hSdmNBb0tjbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlRjloWm5SbGNsOXBabDlsYkhObFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTJNd29nSUNBZ0x5OGdjbVYwZFhKdUlIQnNZV2x1VUhKcGJtTnBjR0ZzS0hObGJtUmxjaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyRnNiSE4xWWlCd2JHRnBibEJ5YVc1amFYQmhiQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dweVpYTnZiSFpsVUhKcGJtTnBjR0ZzUTNSNFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFMk5nb2dJQ0FnTHk4Z2JHVjBJSFpwWVZCc2RXZHBiaUE5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE5qY0tJQ0FnSUM4dklHbG1JQ2hqWVd4c1pYSkJjSEFnSVQwOUlHaHBiblFwSUhzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQWhQUW9nSUNBZ1lub2djbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlRjloWm5SbGNsOXBabDlsYkhObFFERTVDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UY3hDaUFnSUNBdkx5QmpiMjV6ZENCYmMzQmxibVJwYm1jc0lITndaVzVrYVc1blJYaHBjM1J6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0docGJuUXNJRUo1ZEdWektGQlNTVTVEU1ZCQlRGOUxSVmxmVTFCRlRrUkpUa2NwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk53Wlc1a2FXNW5YMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakUzTWdvZ0lDQWdMeThnYVdZZ0tDRW9jM0JsYm1ScGJtZEZlR2x6ZEhNZ0ppWWdjM0JsYm1ScGJtY3ViR1Z1WjNSb0lEMDlQU0F6TWlBbUppQnpjR1Z1WkdsdVp5QTlQVDBnYzJWdVpHVnlMbUo1ZEdWeklDWW1JSE5sYm1SbGNpQWhQVDBnWTJGc2JHVnlRV1JrY2lrcElIc0tJQ0FnSUdKNklISmxjMjlzZG1WUWNtbHVZMmx3WVd4RGRIaGZhV1pmWW05a2VVQXhOUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WemIyeDJaVkJ5YVc1amFYQmhiRU4wZUY5cFpsOWliMlI1UURFMUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQTlQUW9nSUNBZ1lub2djbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlRjlwWmw5aWIyUjVRREUxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0lUMEtJQ0FnSUdKdWVpQnlaWE52YkhabFVISnBibU5wY0dGc1EzUjRYMkZtZEdWeVgybG1YMlZzYzJWQU1UZ0tDbkpsYzI5c2RtVlFjbWx1WTJsd1lXeERkSGhmYVdaZlltOWtlVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRjekNpQWdJQ0F2THlCcFppQW9jM1J5YVdOMEtTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNklISmxjMjlzZG1WUWNtbHVZMmx3WVd4RGRIaGZZV1owWlhKZmFXWmZaV3h6WlVBeE53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE56UUtJQ0FnSUM4dklHeHZaMmRsWkVWeWNpaGxjbkpJYVc1MFRtOTBRbTkxYm1RcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1VqcGxjbkpJYm1Ka0lnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNraHVZbVFLQ25KbGMyOXNkbVZRY21sdVkybHdZV3hEZEhoZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRjMkNpQWdJQ0F2THlCeVpYUjFjbTRnY0d4aGFXNVFjbWx1WTJsd1lXd29jMlZ1WkdWeUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqWVd4c2MzVmlJSEJzWVdsdVVISnBibU5wY0dGc0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbkpsYzI5c2RtVlFjbWx1WTJsd1lXeERkSGhmWVdaMFpYSmZhV1pmWld4elpVQXhPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVGM0Q2lBZ0lDQXZMeUIyYVdGUWJIVm5hVzRnUFNCMGNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tjbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlRjloWm5SbGNsOXBabDlsYkhObFFERTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hPREVLSUNBZ0lDOHZJR052Ym5OMElGdGpiMjUwY205c2JHVmtRbmwwWlhNc0lHTnZiblJ5YjJ4c1pXUkZlR2x6ZEhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb2FHbHVkQ3dnUW5sMFpYTW9VRkpKVGtOSlVFRk1YMHRGV1Y5RFQwNVVVazlNVEVWRUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVkyOXVkSEp2Ykd4bFpGOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVGd5Q2lBZ0lDQXZMeUJwWmlBb0lTaGpiMjUwY205c2JHVmtSWGhwYzNSeklDWW1JR052Ym5SeWIyeHNaV1JDZVhSbGN5NXNaVzVuZEdnZ1BUMDlJRE15S1NrZ2V3b2dJQ0FnWW5vZ2NtVnpiMngyWlZCeWFXNWphWEJoYkVOMGVGOXBabDlpYjJSNVFESXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhKbGMyOXNkbVZRY21sdVkybHdZV3hEZEhoZllXWjBaWEpmYVdaZlpXeHpaVUF5TkFvS2NtVnpiMngyWlZCeWFXNWphWEJoYkVOMGVGOXBabDlpYjJSNVFESXhPZ29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakU0TXdvZ0lDQWdMeThnYVdZZ0tITjBjbWxqZENrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZWlCeVpYTnZiSFpsVUhKcGJtTnBjR0ZzUTNSNFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRnMENpQWdJQ0F2THlCc2IyZG5aV1JGY25Jb1pYSnlTR2x1ZEVKaFpGZGhiR3hsZENrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnlja2wzYkhRaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYZHNkQW9LY21WemIyeDJaVkJ5YVc1amFYQmhiRU4wZUY5aFpuUmxjbDlwWmw5bGJITmxRREl6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94T0RZS0lDQWdJQzh2SUhKbGRIVnliaUJ3YkdGcGJsQnlhVzVqYVhCaGJDaHpaVzVrWlhJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR05oYkd4emRXSWdjR3hoYVc1UWNtbHVZMmx3WVd3S0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tjbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlRjloWm5SbGNsOXBabDlsYkhObFFESTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hPRGtLSUNBZ0lDOHZJR052Ym5OMElHeHBkbVVnUFNCM1lXeHNaWFJEYjI1MGNtOXNjMHhwZG1Vb2FHbHVkQ3dnWTI5dWRISnZiR3hsWkN3Z2MyVnVaR1Z5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpZV3hzYzNWaUlIZGhiR3hsZEVOdmJuUnliMnh6VEdsMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE9URUtJQ0FnSUM4dklHTnZibk4wSUZ0eVpXWmxjbkpsY2tKNWRHVnpMQ0J5WldabGNuSmxja1Y0YVhOMGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5aG9hVzUwTENCQ2VYUmxjeWhRVWtsT1EwbFFRVXhmUzBWWlgxSkZSa1ZTVWtWU0tTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWNtVm1aWEp5WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hPVElLSUNBZ0lDOHZJR052Ym5OMElISmxabVZ5Y21WeUlEMGdjbVZtWlhKeVpYSkZlR2x6ZEhNZ0ppWWdjbVZtWlhKeVpYSkNlWFJsY3k1c1pXNW5kR2dnUFQwOUlETXlJRDhnUVdOamIzVnVkQ2h5WldabGNuSmxja0o1ZEdWektTQTZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1lub2djbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlRjkwWlhKdVlYSjVYMlpoYkhObFFESTNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WemIyeDJaVkJ5YVc1amFYQmhiRU4wZUY5MFpYSnVZWEo1WDJaaGJITmxRREkzQ2lBZ0lDQnpkMkZ3Q2dweVpYTnZiSFpsVUhKcGJtTnBjR0ZzUTNSNFgzUmxjbTVoY25sZmJXVnlaMlZBTWpnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFNU5nb2dJQ0FnTHk4Z2NISnBibU5wY0dGc09pQnNhWFpsSUQ4Z1kyOXVkSEp2Ykd4bFpDQTZJSE5sYm1SbGNpd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UazNDaUFnSUNBdkx5QnZjbWxuYVc0NklHeHBkbVVnUHlCamIyNTBjbTlzYkdWa0lEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ1lub2djbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlRjkwWlhKdVlYSjVYMlpoYkhObFFETXdDaUFnSUNCemQyRndDZ3B5WlhOdmJIWmxVSEpwYm1OcGNHRnNRM1I0WDNSbGNtNWhjbmxmYldWeVoyVkFNekU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakU1TkMweU1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ2FHbHVkQ3dLSUNBZ0lDOHZJQ0FnY0hKcGJtTnBjR0ZzT2lCc2FYWmxJRDhnWTI5dWRISnZiR3hsWkNBNklITmxibVJsY2l3S0lDQWdJQzh2SUNBZ2IzSnBaMmx1T2lCc2FYWmxJRDhnWTI5dWRISnZiR3hsWkNBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdjM0JsYm1SbGNqb2djMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQnlaV1psY25KbGNpd0tJQ0FnSUM4dklDQWdkbWxoVUd4MVoybHVMQW9nSUNBZ0x5OGdmUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NuSmxjMjlzZG1WUWNtbHVZMmx3WVd4RGRIaGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Eb0tJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hPVGNLSUNBZ0lDOHZJRzl5YVdkcGJqb2diR2wyWlNBL0lHTnZiblJ5YjJ4c1pXUWdPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdJZ2NtVnpiMngyWlZCeWFXNWphWEJoYkVOMGVGOTBaWEp1WVhKNVgyMWxjbWRsUURNeENncHlaWE52YkhabFVISnBibU5wY0dGc1EzUjRYM1JsY201aGNubGZabUZzYzJWQU1qYzZDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1Ua3lDaUFnSUNBdkx5QmpiMjV6ZENCeVpXWmxjbkpsY2lBOUlISmxabVZ5Y21WeVJYaHBjM1J6SUNZbUlISmxabVZ5Y21WeVFubDBaWE11YkdWdVozUm9JRDA5UFNBek1pQS9JRUZqWTI5MWJuUW9jbVZtWlhKeVpYSkNlWFJsY3lrZ09pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdjM2RoY0FvZ0lDQWdZaUJ5WlhOdmJIWmxVSEpwYm1OcGNHRnNRM1I0WDNSbGNtNWhjbmxmYldWeVoyVkFNamdLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qcHZkMjV6UVhSU1pYTjBLSGRoYkd4bGRFWmhZM1J2Y25rNklIVnBiblEyTkN3Z2QyRnNiR1YwT2lCMWFXNTBOalFzSUdGalkyOTFiblE2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q205M2JuTkJkRkpsYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pJMU1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdaMWJtTjBhVzl1SUc5M2JuTkJkRkpsYzNRb2QyRnNiR1YwUm1GamRHOXllVG9nZFdsdWREWTBMQ0IzWVd4c1pYUTZJSFZwYm5RMk5Dd2dZV05qYjNWdWREb2dRV05qYjNWdWRDazZJR0p2YjJ4bFlXNGdld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pJMU13b2dJQ0FnTHk4Z2FXWWdLQ0ZwYzBkbGJuVnBibVZYWVd4c1pYUW9kMkZzYkdWMExDQjNZV3hzWlhSR1lXTjBiM0o1S1NrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR05oYkd4emRXSWdhWE5IWlc1MWFXNWxWMkZzYkdWMENpQWdJQ0JpYm5vZ2IzZHVjMEYwVW1WemRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TWpVMENpQWdJQ0F2THlCeVpYUjFjbTRnWm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSemRXSUtDbTkzYm5OQmRGSmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzNPUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyRmtaSEpsYzNOZElEMGdiM0F1UVhCd1VHRnlZVzF6TG1Gd2NFRmtaSEpsYzNNb2QyRnNiR1YwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem95TlRjS0lDQWdJQzh2SUdsbUlDaGhZMk52ZFc1MElEMDlQU0IzWVd4c1pYUkJaR1J5WlhOektTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JpZWlCdmQyNXpRWFJTWlhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem80TlFvZ0lDQWdMeThnWTI5dWMzUWdXMkYxZEdoZElEMGdiM0F1UVdOamRGQmhjbUZ0Y3k1aFkyTjBRWFYwYUVGa1pISW9ZV05qYjNWdWRDa0tJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFYVjBhRUZrWkhJS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem95TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJoZFhSb1FXUmtjazltS0hkaGJHeGxkRUZrWkhKbGMzTXBJRDA5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUhKbGRITjFZZ29LYjNkdWMwRjBVbVZ6ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPamcxQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWFYwYUYwZ1BTQnZjQzVCWTJOMFVHRnlZVzF6TG1GalkzUkJkWFJvUVdSa2NpaGhZMk52ZFc1MEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVGMWRHaEJaR1J5Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNall3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWFYwYUVGa1pISlBaaWhoWTJOdmRXNTBLU0E5UFQwZ2QyRnNiR1YwUVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9uQnlhVzVqYVhCaGJFOW1LR0ZyYVhSaFJFRlBPaUIxYVc1ME5qUXNJR2hwYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuQnlhVzVqYVhCaGJFOW1PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVNemNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQm1kVzVqZEdsdmJpQndjbWx1WTJsd1lXeFBaaWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0c0lHaHBiblE2SUhWcGJuUTJOQ2s2SUZCeWFXNWphWEJoYkNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNakEyQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWEJ3VEdsemRFSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dGcmFYUmhSRUZQTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMwRnJhWFJoUVhCd1RHbHpkQ2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UTTRDaUFnSUNBdkx5QnlaWFIxY200Z2NtVnpiMngyWlZCeWFXNWphWEJoYkNoblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG5kaGJHeGxkQ3dnYUdsdWRDa0tJQ0FnSUhCMWMyaHBiblFnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pJeE1nb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TWpFekNpQWdJQ0F2THlCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKWkN3S0lDQWdJR2RzYjJKaGJDQkRZV3hzWlhKQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qSXhOQW9nSUNBZ0x5OGdSMnh2WW1Gc0xtTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRZV3hzWlhKQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TWpBNUxUSXhOZ29nSUNBZ0x5OGdjbVYwZFhKdUlISmxjMjlzZG1WUWNtbHVZMmx3WVd4RGRIZ29DaUFnSUNBdkx5QWdJSGRoYkd4bGRFWmhZM1J2Y25rc0NpQWdJQ0F2THlBZ0lHaHBiblFzQ2lBZ0lDQXZMeUFnSUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lFZHNiMkpoYkM1allXeHNaWEpCY0hCc2FXTmhkR2x2Ymtsa0xBb2dJQ0FnTHk4Z0lDQkhiRzlpWVd3dVkyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCMGNuVmxDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3lNVFVLSUNBZ0lDOHZJSFJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakl3T1MweU1UWUtJQ0FnSUM4dklISmxkSFZ5YmlCeVpYTnZiSFpsVUhKcGJtTnBjR0ZzUTNSNEtBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhSR1lXTjBiM0o1TEFvZ0lDQWdMeThnSUNCb2FXNTBMQW9nSUNBZ0x5OGdJQ0JVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKWkN3S0lDQWdJQzh2SUNBZ1IyeHZZbUZzTG1OaGJHeGxja0Z3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnZEhKMVpRb2dJQ0FnTHk4Z0tRb2dJQ0FnWTJGc2JITjFZaUJ5WlhOdmJIWmxVSEpwYm1OcGNHRnNRM1I0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPamt6T0FvZ0lDQWdMeThnY21WMGRYSnVJSEpsYzI5c2RtVlFjbWx1WTJsd1lXd29aMlYwUVd0cGRHRkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNTNZV3hzWlhRc0lHaHBiblFwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxdlkydFFjbWx1WTJsd1lXeFFjbTlpWlM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQkJjSEJzYVdOaGRHbHZiaWhoYTJsMFlVUkJUeWtLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclVISnBibU5wY0dGc1VISnZZbVV1Y0hKdlltVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3Y205aVpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdjSEp2WW1Vb2QyRnNiR1YwT2lCMWFXNTBOalFwT2lCUWNtbHVZMmx3WVd3Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjSEpwYm1OcGNHRnNUMllvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z2QyRnNiR1YwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIQnlhVzVqYVhCaGJFOW1LSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUhkaGJHeGxkQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUhCeWFXNWphWEJoYkU5bUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIQnliMkpsS0hkaGJHeGxkRG9nZFdsdWREWTBLVG9nVUhKcGJtTnBjR0ZzSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxdlkydFFjbWx1WTJsd1lXeFFjbTlpWlM1MGNubFFjbTlpWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnllVkJ5YjJKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QjBjbmxRY205aVpTaDNZV3hzWlhRNklIVnBiblEyTkNrNklGQnlhVzVqYVhCaGJDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUhKbGRIVnliaUIwY25sUWNtbHVZMmx3WVd4UFppaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0IzWVd4c1pYUXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCeVpYUjFjbTRnZEhKNVVISnBibU5wY0dGc1QyWW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnZDJGc2JHVjBLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qQTJDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhRWEJ3VEdsemRDa3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prME13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSeWVWSmxjMjlzZG1WUWNtbHVZMmx3WVd3b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1M1lXeHNaWFFzSUdocGJuUXBDaUFnSUNCd2RYTm9hVzUwSURnNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveU1qZ0tJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pJeU9Rb2dJQ0FnTHk4Z1IyeHZZbUZzTG1OaGJHeGxja0Z3Y0d4cFkyRjBhVzl1U1dRc0NpQWdJQ0JuYkc5aVlXd2dRMkZzYkdWeVFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3lNekFLSUNBZ0lDOHZJRWRzYjJKaGJDNWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRMkZzYkdWeVFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pJeU5TMHlNeklLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaWE52YkhabFVISnBibU5wY0dGc1EzUjRLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUkdZV04wYjNKNUxBb2dJQ0FnTHk4Z0lDQm9hVzUwTEFvZ0lDQWdMeThnSUNCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQkhiRzlpWVd3dVkyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1SlpDd0tJQ0FnSUM4dklDQWdSMnh2WW1Gc0xtTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1ptRnNjMlVLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3lNekVLSUNBZ0lDOHZJR1poYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem95TWpVdE1qTXlDaUFnSUNBdkx5QnlaWFIxY200Z2NtVnpiMngyWlZCeWFXNWphWEJoYkVOMGVDZ0tJQ0FnSUM4dklDQWdkMkZzYkdWMFJtRmpkRzl5ZVN3S0lDQWdJQzh2SUNBZ2FHbHVkQ3dLSUNBZ0lDOHZJQ0FnVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ1IyeHZZbUZzTG1OaGJHeGxja0Z3Y0d4cFkyRjBhVzl1U1dRc0NpQWdJQ0F2THlBZ0lFZHNiMkpoYkM1allXeHNaWEpCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdaaGJITmxDaUFnSUNBdkx5QXBDaUFnSUNCallXeHNjM1ZpSUhKbGMyOXNkbVZRY21sdVkybHdZV3hEZEhnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2RISjVVSEp2WW1Vb2QyRnNiR1YwT2lCMWFXNTBOalFwT2lCUWNtbHVZMmx3WVd3Z2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXOWphMUJ5YVc1amFYQmhiRkJ5YjJKbExuQnliMkpsUTI5emRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YjJKbFEyOXpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnY0hKdlltVkRiM04wS0hkaGJHeGxkRG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnWW1WbWIzSmxJRDBnUjJ4dlltRnNMbTl3WTI5a1pVSjFaR2RsZEFvZ0lDQWdaMnh2WW1Gc0lFOXdZMjlrWlVKMVpHZGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJqYjI1emRDQndJRDBnY0hKcGJtTnBjR0ZzVDJZb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dkMkZzYkdWMEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWTI5dWMzUWdjQ0E5SUhCeWFXNWphWEJoYkU5bUtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJSGRoYkd4bGRDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2NISnBibU5wY0dGc1QyWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdZMjl1YzNRZ1lXWjBaWElnUFNCSGJHOWlZV3d1YjNCamIyUmxRblZrWjJWMENpQWdJQ0JuYkc5aVlXd2dUM0JqYjJSbFFuVmtaMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUdGemMyVnlkQ2h3TG5Od1pXNWtaWElnUFQwOUlGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURjeUlETXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklISmxkSFZ5YmlCaVpXWnZjbVVnTFNCaFpuUmxjZ29nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QndjbTlpWlVOdmMzUW9kMkZzYkdWME9pQjFhVzUwTmpRcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXOWphMUJ5YVc1amFYQmhiRkJ5YjJKbExuQnliMkpsUVhWMGFGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YjJKbFFYVjBhRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnY0hKdlltVkJkWFJvS0hkaGJHeGxkRG9nZFdsdWREWTBLVG9nUVdOamIzVnVkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QmpiMjV6ZENCYllYVjBhRjBnUFNCdmNDNUJZMk4wVUdGeVlXMXpMbUZqWTNSQmRYUm9RV1JrY2loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JCZFhSb1FXUmtjZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJSEJ5YjJKbFFYVjBhQ2gzWVd4c1pYUTZJSFZwYm5RMk5DazZJRUZqWTI5MWJuUWdld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTFCeWFXNWphWEJoYkZCeWIySmxMbkYxYjNSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjWFZ2ZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUhKbGRIVnliaUJ4ZFc5MFpWSmxabVZ5Y21WeVQyWW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnZDJGc2JHVjBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhGMWIzUmxVbVZtWlhKeVpYSlBaaWgwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCM1lXeHNaWFFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lNRFlLSUNBZ0lDOHZJR052Ym5OMElGdGhjSEJNYVhOMFFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselFXdHBkR0ZCY0hCTWFYTjBLU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UUTRDaUFnSUNBdkx5QnlaWFIxY200Z2NYVnZkR1ZTWldabGNuSmxjaWhuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbmRoYkd4bGRDd2dhR2x1ZENrS0lDQWdJSEIxYzJocGJuUWdPRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakkwTUFvZ0lDQWdMeThnYVdZZ0tDRnBjMGRsYm5WcGJtVlhZV3hzWlhRb2FHbHVkQ3dnZDJGc2JHVjBSbUZqZEc5eWVTa3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2FYTkhaVzUxYVc1bFYyRnNiR1YwQ2lBZ0lDQmlibm9nY1hWdmRHVmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TWpReENpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtDbkYxYjNSbFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem82Y1hWdmRHVlNaV1psY25KbGNrQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuRjFiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNalF6Q2lBZ0lDQXZMeUJqYjI1emRDQmJjbVZtWlhKeVpYSkNlWFJsY3l3Z2NtVm1aWEp5WlhKRmVHbHpkSE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vYUdsdWRDd2dRbmwwWlhNb1VGSkpUa05KVUVGTVgwdEZXVjlTUlVaRlVsSkZVaWtwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p5WldabGNuSmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pJME5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbFptVnljbVZ5UlhocGMzUnpJQ1ltSUhKbFptVnljbVZ5UW5sMFpYTXViR1Z1WjNSb0lEMDlQU0F6TWlBL0lFRmpZMjkxYm5Rb2NtVm1aWEp5WlhKQ2VYUmxjeWtnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR0o2SUhGMWIzUmxYM1JsY201aGNubGZabUZzYzJWQU5nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSEYxYjNSbFgzUmxjbTVoY25sZlptRnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem81TkRnS0lDQWdJQzh2SUhKbGRIVnliaUJ4ZFc5MFpWSmxabVZ5Y21WeUtHZGxkRUZyYVhSaFFYQndUR2x6ZENoaGEybDBZVVJCVHlrdWQyRnNiR1YwTENCb2FXNTBLUW9nSUNBZ1lpQnhkVzkwWlY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPbkYxYjNSbFVtVm1aWEp5WlhKQU9Bb0tjWFZ2ZEdWZmRHVnlibUZ5ZVY5bVlXeHpaVUEyT2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakkwTkFvZ0lDQWdMeThnY21WMGRYSnVJSEpsWm1WeWNtVnlSWGhwYzNSeklDWW1JSEpsWm1WeWNtVnlRbmwwWlhNdWJHVnVaM1JvSUQwOVBTQXpNaUEvSUVGalkyOTFiblFvY21WbVpYSnlaWEpDZVhSbGN5a2dPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNU5EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCeGRXOTBaVkpsWm1WeWNtVnlLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VkMkZzYkdWMExDQm9hVzUwS1FvZ0lDQWdZaUJ4ZFc5MFpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02T25GMWIzUmxVbVZtWlhKeVpYSkFPQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTFCeWFXNWphWEJoYkZCeWIySmxMbTkzYm5OYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZkMjV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM2R1YzBGMFVtVnpkRTltS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVc0lIZGhiR3hsZEN3Z1lXTmpiM1Z1ZENrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJSEpsZEhWeWJpQnZkMjV6UVhSU1pYTjBUMllvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z2QyRnNiR1YwTENCaFkyTnZkVzUwS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNakEyQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWEJ3VEdsemRFSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dGcmFYUmhSRUZQTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMwRnJhWFJoUVhCd1RHbHpkQ2twQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qazFNd29nSUNBZ0x5OGdjbVYwZFhKdUlHOTNibk5CZEZKbGMzUW9aMlYwUVd0cGRHRkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNTNZV3hzWlhRc0lIZGhiR3hsZEN3Z1lXTmpiM1Z1ZENrS0lDQWdJSEIxYzJocGJuUWdPRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRzkzYm5OQmRGSmxjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amExQnlhVzVqYVhCaGJGQnliMkpsTG1GMFVtVnpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GMFVtVnpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUhKbGRIVnliaUJoZEZKbGMzUlFjbWx1WTJsd1lXeFBaaWgwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCaFkyTnZkVzUwTENCM1lXeHNaWFFzSUhOMGIzSmxaQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklISmxkSFZ5YmlCaGRGSmxjM1JRY21sdVkybHdZV3hQWmloMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQmhZMk52ZFc1MExDQjNZV3hzWlhRc0lITjBiM0psWkNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakl3TmdvZ0lDQWdMeThnWTI5dWMzUWdXMkZ3Y0V4cGMzUkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGEybDBZVVJCVHl3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTkJhMmwwWVVGd2NFeHBjM1FwS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVdGc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVOVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhkRkpsYzNSUWNtbHVZMmx3WVd3b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1M1lXeHNaWFFzSUdGalkyOTFiblFzSUhkaGJHeGxkQ3dnYzNSdmNtVmtLUW9nSUNBZ2NIVnphR2x1ZENBNE9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNamN4Q2lBZ0lDQXZMeUJwWmlBb2MzUnZjbVZrSUQwOVBTQmhZMk52ZFc1MEtTQjdDaUFnSUNBOVBRb2dJQ0FnWW5vZ1lYUlNaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ2NHOXdiaUF6Q2dwaGRGSmxjM1JmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qcGhkRkpsYzNSUWNtbHVZMmx3WVd4QU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwaGRGSmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3lOelFLSUNBZ0lDOHZJR2xtSUNnaGIzZHVjMEYwVW1WemRDaDNZV3hzWlhSR1lXTjBiM0o1TENCM1lXeHNaWFFzSUdGalkyOTFiblFwS1NCN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEUUtJQ0FnSUdOaGJHeHpkV0lnYjNkdWMwRjBVbVZ6ZEFvZ0lDQWdZbTU2SUdGMFVtVnpkRjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhCdmNHNGdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVOVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhkRkpsYzNSUWNtbHVZMmx3WVd3b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1M1lXeHNaWFFzSUdGalkyOTFiblFzSUhkaGJHeGxkQ3dnYzNSdmNtVmtLUW9nSUNBZ1lpQmhkRkpsYzNSZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPanBoZEZKbGMzUlFjbWx1WTJsd1lXeEFPQW9LWVhSU1pYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk56a0tJQ0FnSUM4dklHTnZibk4wSUZ0aFpHUnlaWE56WFNBOUlHOXdMa0Z3Y0ZCaGNtRnRjeTVoY0hCQlpHUnlaWE56S0hkaGJHeGxkQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakkzT0FvZ0lDQWdMeThnYVdZZ0tITjBiM0psWkNBOVBUMGdkMkZzYkdWMFFXUmtjbVZ6Y3lrZ2V3b2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGRGSmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qZzFDaUFnSUNBdkx5QmpiMjV6ZENCYllYVjBhRjBnUFNCdmNDNUJZMk4wVUdGeVlXMXpMbUZqWTNSQmRYUm9RV1JrY2loaFkyTnZkVzUwS1FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JCZFhSb1FXUmtjZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qSTNPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRjFkR2hCWkdSeVQyWW9kMkZzYkdWMFFXUmtjbVZ6Y3lrZ1BUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeUEvSUhOMGIzSmxaQ0E2SUdGalkyOTFiblFLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNU5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaGRGSmxjM1JRY21sdVkybHdZV3dvWjJWMFFXdHBkR0ZCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzUzWVd4c1pYUXNJR0ZqWTI5MWJuUXNJSGRoYkd4bGRDd2djM1J2Y21Wa0tRb2dJQ0FnWWlCaGRGSmxjM1JmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qcGhkRkpsYzNSUWNtbHVZMmx3WVd4QU9Bb0tZWFJTWlhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02T0RVS0lDQWdJQzh2SUdOdmJuTjBJRnRoZFhSb1hTQTlJRzl3TGtGalkzUlFZWEpoYlhNdVlXTmpkRUYxZEdoQlpHUnlLR0ZqWTI5MWJuUXBDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFYVjBhRUZrWkhJS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem95T0RFS0lDQWdJQzh2SUhKbGRIVnliaUJoZFhSb1FXUmtjazltS0hOMGIzSmxaQ2tnUFQwOUlIZGhiR3hsZEVGa1pISmxjM01nUHlCemRHOXlaV1FnT2lCaFkyTnZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UVTRDaUFnSUNBdkx5QnlaWFIxY200Z1lYUlNaWE4wVUhKcGJtTnBjR0ZzS0dkbGRFRnJhWFJoUVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1ZDJGc2JHVjBMQ0JoWTJOdmRXNTBMQ0IzWVd4c1pYUXNJSE4wYjNKbFpDa0tJQ0FnSUdJZ1lYUlNaWE4wWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzZZWFJTWlhOMFVISnBibU5wY0dGc1FEZ0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRRY21sdVkybHdZV3hRY205aVpTNTBhR2x5WkZCaGNuUjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdocGNtUlFZWEowZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjbVJRWVhKMGVWQnlhVzVqYVhCaGJFOW1LSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUdGalkyOTFiblFzSUhkaGJHeGxkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHlaRkJoY25SNVVISnBibU5wY0dGc1QyWW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnWVdOamIzVnVkQ3dnZDJGc2JHVjBLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qQTJDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhRWEJ3VEdsemRDa3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prMk13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYSmtVR0Z5ZEhsUWNtbHVZMmx3WVd3b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1M1lXeHNaWFFzSUdGalkyOTFiblFzSUhkaGJHeGxkQ2tLSUNBZ0lIQjFjMmhwYm5RZ09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qSTVNUW9nSUNBZ0x5OGdhV1lnS0NGdmQyNXpRWFJTWlhOMEtIZGhiR3hsZEVaaFkzUnZjbmtzSUhkaGJHeGxkQ3dnWVdOamIzVnVkQ2twSUhzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCdmQyNXpRWFJTWlhOMENpQWdJQ0JpYm5vZ2RHaHBjbVJRWVhKMGVWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJSEJ2Y0FvS2RHaHBjbVJRWVhKMGVWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02T25Sb2FYSmtVR0Z5ZEhsUWNtbHVZMmx3WVd4QU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwMGFHbHlaRkJoY25SNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TWprMENpQWdJQ0F2THlCamIyNXpkQ0JiWTI5dWRISnZiR3hsWkVKNWRHVnpMQ0JqYjI1MGNtOXNiR1ZrUlhocGMzUnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLSGRoYkd4bGRDd2dRbmwwWlhNb1VGSkpUa05KVUVGTVgwdEZXVjlEVDA1VVVrOU1URVZFS1NrS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTI5dWRISnZiR3hsWkY5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1qazFDaUFnSUNBdkx5QnBaaUFvSVNoamIyNTBjbTlzYkdWa1JYaHBjM1J6SUNZbUlHTnZiblJ5YjJ4c1pXUkNlWFJsY3k1c1pXNW5kR2dnUFQwOUlETXlLU2tnZXdvZ0lDQWdZbm9nZEdocGNtUlFZWEowZVY5cFpsOWliMlI1UURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaWJub2dkR2hwY21SUVlYSjBlVjloWm5SbGNsOXBabDlsYkhObFFEWUtDblJvYVhKa1VHRnlkSGxmYVdaZlltOWtlVUExT2dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prMk13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYSmtVR0Z5ZEhsUWNtbHVZMmx3WVd3b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1M1lXeHNaWFFzSUdGalkyOTFiblFzSUhkaGJHeGxkQ2tLSUNBZ0lHSWdkR2hwY21SUVlYSjBlVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9uUm9hWEprVUdGeWRIbFFjbWx1WTJsd1lXeEFOd29LZEdocGNtUlFZWEowZVY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakk1T1FvZ0lDQWdMeThnY21WMGRYSnVJSGRoYkd4bGRFTnZiblJ5YjJ4elRHbDJaU2gzWVd4c1pYUXNJR052Ym5SeWIyeHNaV1FzSUdGalkyOTFiblFwSUQ4Z1kyOXVkSEp2Ykd4bFpDQTZJR0ZqWTI5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnZDJGc2JHVjBRMjl1ZEhKdmJITk1hWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UWXpDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjbVJRWVhKMGVWQnlhVzVqYVhCaGJDaG5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExuZGhiR3hsZEN3Z1lXTmpiM1Z1ZEN3Z2QyRnNiR1YwS1FvZ0lDQWdZaUIwYUdseVpGQmhjblI1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzZkR2hwY21SUVlYSjBlVkJ5YVc1amFYQmhiRUEzQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclVISnBibU5wY0dGc1VISnZZbVV1WTNSNFQzZHVjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OMGVFOTNibk02Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EzTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzZSMkYwWlVOMGVBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdjbVYwZFhKdUlHTjBlRTkzYm5OUFppaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JqZEhnc0lHRmpZMjkxYm5RcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZM1I0VDNkdWMwOW1LSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUdOMGVDd2dZV05qYjNWdWRDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJd05nb2dJQ0FnTHk4Z1kyOXVjM1FnVzJGd2NFeHBjM1JDZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5aGhhMmwwWVVSQlR5d2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5CYTJsMFlVRndjRXhwYzNRcEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem81TmpnS0lDQWdJQzh2SUhKbGRIVnliaUJqZEhoUGQyNXpLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VkMkZzYkdWMExDQmpkSGdzSUdGalkyOTFiblFwQ2lBZ0lDQndkWE5vYVc1MElEZzRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem96TVRNS0lDQWdJQzh2SUdsbUlDaGhZMk52ZFc1MElEMDlQU0JqZEhndWNISnBibU5wY0dGc0lIeDhJR0ZqWTI5MWJuUWdQVDA5SUdOMGVDNXpjR1Z1WkdWeUtTQjdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1kzUjRUM2R1YzE5cFpsOWliMlI1UURNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBNQ0F6TWdvZ0lDQWdaR2xuSURNS0lDQWdJRDA5Q2lBZ0lDQmllaUJqZEhoUGQyNXpYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb0tZM1I0VDNkdWMxOXBabDlpYjJSNVFETTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk16RTBDaUFnSUNBdkx5QnlaWFIxY200Z2RISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtDbU4wZUU5M2JuTmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwamRIaFBkMjV6UURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU4wZUU5M2JuTmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pvek1UWUtJQ0FnSUM4dklISmxkSFZ5YmlCamRIZ3VkMkZzYkdWMElDRTlQU0F3SUNZbUlHOTNibk5CZEZKbGMzUW9kMkZzYkdWMFJtRmpkRzl5ZVN3Z1kzUjRMbmRoYkd4bGRDd2dZV05qYjNWdWRDa0tJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTBDaUFnSUNCaWVpQmpkSGhQZDI1elgySnZiMnhmWm1Gc2MyVkFOd29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHTmhiR3h6ZFdJZ2IzZHVjMEYwVW1WemRBb2dJQ0FnWW5vZ1kzUjRUM2R1YzE5aWIyOXNYMlpoYkhObFFEY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prMk9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdOMGVFOTNibk1vWjJWMFFXdHBkR0ZCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzUzWVd4c1pYUXNJR04wZUN3Z1lXTmpiM1Z1ZENrS0lDQWdJR0lnWTNSNFQzZHVjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9tTjBlRTkzYm5OQU9Rb0tZM1I0VDNkdWMxOWliMjlzWDJaaGJITmxRRGM2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVOamdLSUNBZ0lDOHZJSEpsZEhWeWJpQmpkSGhQZDI1ektHZGxkRUZyYVhSaFFYQndUR2x6ZENoaGEybDBZVVJCVHlrdWQyRnNiR1YwTENCamRIZ3NJR0ZqWTI5MWJuUXBDaUFnSUNCaUlHTjBlRTkzYm5OZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPanBqZEhoUGQyNXpRRGtLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazF2WTJ0UWNtbHVZMmx3WVd4UWNtOWlaUzUwYVhCWFlXeHNaWFJQWmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnBjRmRoYkd4bGRFOW1PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFYQlhZV3hzWlhRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dZM0psWVhSdmNpd2djM1J2Y21Wa0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnY21WMGRYSnVJSFJwY0ZkaGJHeGxkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCamNtVmhkRzl5TENCemRHOXlaV1FwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lNRFlLSUNBZ0lDOHZJR052Ym5OMElGdGhjSEJNYVhOMFFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselFXdHBkR0ZCY0hCTWFYTjBLU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1UQTBOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUnBjRmRoYkd4bGRFWnZjaWhuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbmRoYkd4bGRDd2dZM0psWVhSdmNpd2djM1J2Y21Wa0tRb2dJQ0FnY0hWemFHbHVkQ0E0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk16Y3hDaUFnSUNBdkx5QnBaaUFvYzNSdmNtVmtJRDA5UFNBd0lIeDhJQ0Z2ZDI1elFYUlNaWE4wS0hkaGJHeGxkRVpoWTNSdmNua3NJSE4wYjNKbFpDd2dZM0psWVhSdmNpa3BJSHNLSUNBZ0lHSjZJSFJwY0ZkaGJHeGxkRTltWDJsbVgySnZaSGxBTXdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJ2ZDI1elFYUlNaWE4wQ2lBZ0lDQmlibm9nZEdsd1YyRnNiR1YwVDJaZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2dwMGFYQlhZV3hzWlhSUFpsOXBabDlpYjJSNVFETTZDaUFnSUNCd2IzQnVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNemN5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDblJwY0ZkaGJHeGxkRTltWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzZkR2x3VjJGc2JHVjBSbTl5UURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZEdsd1YyRnNiR1YwVDJaZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem96TnpRS0lDQWdJQzh2SUdOdmJuTjBJRnRqYjI1MGNtOXNiR1ZrUW5sMFpYTXNJR052Ym5SeWIyeHNaV1JGZUdsemRITmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9jM1J2Y21Wa0xDQkNlWFJsY3loUVVrbE9RMGxRUVV4ZlMwVlpYME5QVGxSU1QweE1SVVFwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqYjI1MGNtOXNiR1ZrWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pvek56VUtJQ0FnSUM4dklHbG1JQ2doS0dOdmJuUnliMnhzWldSRmVHbHpkSE1nSmlZZ1kyOXVkSEp2Ykd4bFpFSjVkR1Z6TG14bGJtZDBhQ0E5UFQwZ016SXBLU0I3Q2lBZ0lDQmllaUIwYVhCWFlXeHNaWFJQWmw5cFpsOWliMlI1UURZS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaWJub2dkR2x3VjJGc2JHVjBUMlpmWVdaMFpYSmZhV1pmWld4elpVQTNDZ3AwYVhCWFlXeHNaWFJQWmw5cFpsOWliMlI1UURZNkNpQWdJQ0J3YjNCdUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk16YzJDaUFnSUNBdkx5QnlaWFIxY200Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TVRBME5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhScGNGZGhiR3hsZEVadmNpaG5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExuZGhiR3hsZEN3Z1kzSmxZWFJ2Y2l3Z2MzUnZjbVZrS1FvZ0lDQWdZaUIwYVhCWFlXeHNaWFJQWmw5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPblJwY0ZkaGJHeGxkRVp2Y2tBNENncDBhWEJYWVd4c1pYUlBabDloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qTTNPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIZGhiR3hsZEVOdmJuUnliMnh6VEdsMlpTaHpkRzl5WldRc0lFRmpZMjkxYm5Rb1kyOXVkSEp2Ykd4bFpFSjVkR1Z6S1N3Z1kzSmxZWFJ2Y2lrZ1B5QnpkRzl5WldRZ09pQXdDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUhkaGJHeGxkRU52Ym5SeWIyeHpUR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE1EUTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHbHdWMkZzYkdWMFJtOXlLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VkMkZzYkdWMExDQmpjbVZoZEc5eUxDQnpkRzl5WldRcENpQWdJQ0JpSUhScGNGZGhiR3hsZEU5bVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem82ZEdsd1YyRnNiR1YwUm05eVFEZ0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRRY21sdVkybHdZV3hRY205aVpTNW5ZWFJsUTJobFkydERkSGhQWmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGhkR1ZEYUdWamEwTjBlRTltT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCbllYUmxRMmhsWTJ0RGRIaFBaaWhuWVhSbFZIaHVPaUJuZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkZSNGJpd2dZM1I0T2lCSFlYUmxRM1I0TENCcFpEb2dkV2x1ZERZMEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWEJ3YkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9rZGhkR1ZEZEhnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHZGhkR1ZEYUdWamEwTjBlQ2huWVhSbFZIaHVMQ0IwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCamRIZ3NJR2xrS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHZGhkR1ZEYUdWamEwTjBlQ2huWVhSbFZIaHVMQ0IwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCamRIZ3NJR2xrS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPVGd6Q2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXdOZ29nSUNBZ0x5OGdZMjl1YzNRZ1cyRndjRXhwYzNSQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoYTJsMFlVUkJUeXdnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVUZ3Y0V4cGMzUXBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNU9ETUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem81T0RNdE9UZzBDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRWxrSUQwOVBTQkJjSEJzYVdOaGRHbHZiaWhuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbWRoZEdVcElDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtOXVRMjl0Y0d4bGRHbHZiaUE5UFQwZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdJQ1ltQ2lBZ0lDQmllaUJuWVhSbFEyaGxZMnREZEhoUFpsOWliMjlzWDJaaGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPVGcwQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3SUNZbUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWjNSNGJuTWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPams0TXkwNU9EUUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWIyNURiMjF3YkdWMGFXOXVJRDA5UFNCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQWdKaVlLSUNBZ0lHSnVlaUJuWVhSbFEyaGxZMnREZEhoUFpsOWliMjlzWDJaaGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPVGcxQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTUxYlVGd2NFRnlaM01nUFQwOUlEUWdKaVlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qazRNeTA1T0RVS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1NXUWdQVDA5SUVGd2NHeHBZMkYwYVc5dUtHZGxkRUZyYVhSaFFYQndUR2x6ZENoaGEybDBZVVJCVHlrdVoyRjBaU2tnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1YjI1RGIyMXdiR1YwYVc5dUlEMDlQU0JQYmtOdmJYQnNaWFJsUVdOMGFXOXVMazV2VDNBZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWJuVnRRWEJ3UVhKbmN5QTlQVDBnTkNBbUpnb2dJQ0FnWW5vZ1oyRjBaVU5vWldOclEzUjRUMlpmWW05dmJGOW1ZV3h6WlVBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prNE5nb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkJjbWR6S0RBcElEMDlQU0J0WlhSb2IyUlRaV3hsWTNSdmNpaEhZWFJsVFhWemRFTm9aV05yUm05eVFXSnBUV1YwYUc5a0tTQW1KZ29nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1dJeE5EZGtNbU1nTHk4Z2JXVjBhRzlrSUNKdGRYTjBRMmhsWTJ0R2IzSW9LR0ZrWkhKbGMzTXNkV2x1ZERZMExHRmtaSEpsYzNNcExIVnBiblEyTkN4aWVYUmxXMTFiWFNsMmIybGtJZ29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UZ3pMVGs0TmdvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCSlpDQTlQVDBnUVhCd2JHbGpZWFJwYjI0b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1bllYUmxLU0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV2YmtOdmJYQnNaWFJwYjI0Z1BUMDlJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dWRXMUJjSEJCY21keklEMDlQU0EwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFRnlaM01vTUNrZ1BUMDlJRzFsZEdodlpGTmxiR1ZqZEc5eUtFZGhkR1ZOZFhOMFEyaGxZMnRHYjNKQlltbE5aWFJvYjJRcElDWW1DaUFnSUNCaWVpQm5ZWFJsUTJobFkydERkSGhQWmw5aWIyOXNYMlpoYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UZzNDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRUZ5WjNNb01Ta2dQVDA5SUdWdVkyOWtaVUZ5WXpRb1kzUjRLU0FtSmdvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prNE15MDVPRGNLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3U1dRZ1BUMDlJRUZ3Y0d4cFkyRjBhVzl1S0dkbGRFRnJhWFJoUVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1WjJGMFpTa2dKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHViMjVEYjIxd2JHVjBhVzl1SUQwOVBTQlBia052YlhCc1pYUmxRV04wYVc5dUxrNXZUM0FnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1Ym5WdFFYQndRWEpuY3lBOVBUMGdOQ0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCQmNtZHpLREFwSUQwOVBTQnRaWFJvYjJSVFpXeGxZM1J2Y2loSFlYUmxUWFZ6ZEVOb1pXTnJSbTl5UVdKcFRXVjBhRzlrS1NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkJjbWR6S0RFcElEMDlQU0JsYm1OdlpHVkJjbU0wS0dOMGVDa2dKaVlLSUNBZ0lHSjZJR2RoZEdWRGFHVmphME4wZUU5bVgySnZiMnhmWm1Gc2MyVkFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVPRGdLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3UVhKbmN5Z3lLU0E5UFQwZ2FYUnZZaWhwWkNrS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNU9ETXRPVGc0Q2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3SUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG01MWJVRndjRUZ5WjNNZ1BUMDlJRFFnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1FYSm5jeWd3S1NBOVBUMGdiV1YwYUc5a1UyVnNaV04wYjNJb1IyRjBaVTExYzNSRGFHVmphMFp2Y2tGaWFVMWxkR2h2WkNrZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndRWEpuY3lneEtTQTlQVDBnWlc1amIyUmxRWEpqTkNoamRIZ3BJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0VGeVozTW9NaWtnUFQwOUlHbDBiMklvYVdRcENpQWdJQ0JpZWlCbllYUmxRMmhsWTJ0RGRIaFBabDlpYjI5c1gyWmhiSE5sUURnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwbllYUmxRMmhsWTJ0RGRIaFBabDlpYjI5c1gyMWxjbWRsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklHZGhkR1ZEYUdWamEwTjBlRTltS0dkaGRHVlVlRzQ2SUdkMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c1ZIaHVMQ0JqZEhnNklFZGhkR1ZEZEhnc0lHbGtPaUIxYVc1ME5qUXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWVhSbFEyaGxZMnREZEhoUFpsOWliMjlzWDJaaGJITmxRRGc2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQm5ZWFJsUTJobFkydERkSGhQWmw5aWIyOXNYMjFsY21kbFFEa0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRRY21sdVkybHdZV3hRY205aVpTNXdjbTlpWlVOMGVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YjJKbFEzUjRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnY0hKdlltVkRkSGdvZDJGc2JHVjBPaUIxYVc1ME5qUXBPaUJIWVhSbFEzUjRJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklISmxkSFZ5YmlCbllYUmxRM1I0S0hCeWFXNWphWEJoYkU5bUtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJSGRoYkd4bGRDa3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd013b2dJQ0FnTHk4Z2NtVjBkWEp1SUdkaGRHVkRkSGdvY0hKcGJtTnBjR0ZzVDJZb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dkMkZzYkdWMEtTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJSEJ5YVc1amFYQmhiRTltQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPak13TkFvZ0lDQWdMeThnY21WMGRYSnVJSHNnY0hKcGJtTnBjR0ZzT2lCd0xuQnlhVzVqYVhCaGJDd2dkMkZzYkdWME9pQndMbmRoYkd4bGRDd2djM0JsYm1SbGNqb2djQzV6Y0dWdVpHVnlJSDBLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBNElETXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQTNNaUF6TWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNISnZZbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUhCeWIySmxRM1I0S0hkaGJHeGxkRG9nZFdsdWREWTBLVG9nUjJGMFpVTjBlQ0I3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclVISnBibU5wY0dGc1VISnZZbVV1Y21Wc1lYbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5Wld4aGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSEpsYkdGNUtIUmhjbWRsZERvZ1FYQndiR2xqWVhScGIyNHNJSGRoYkd4bGREb2dkV2x1ZERZMEtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGd0TVRFeENpQWdJQ0F2THlCeVpYUjFjbTRnWVdKcFEyRnNiRHgwZVhCbGIyWWdUVzlqYTFCeWFXNWphWEJoYkZCeWIySmxMbkJ5YjNSdmRIbHdaUzV3Y205aVpUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkR0Z5WjJWMExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmQyRnNiR1YwWFN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z2JXVjBhRzlrSUNKd2NtOWlaU2gxYVc1ME5qUXBLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKdmIyd3BJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREV6TndvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzZVSEpwYm1OcGNHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEzQ2lBZ0lDQXZMeUJ5Wld4aGVTaDBZWEpuWlhRNklFRndjR3hwWTJGMGFXOXVMQ0IzWVd4c1pYUTZJSFZwYm5RMk5DazZJRkJ5YVc1amFYQmhiQ0I3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclVISnBibU5wY0dGc1VISnZZbVV1ZEhKNVVtVnNZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNubFNaV3hoZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklIUnllVkpsYkdGNUtIUmhjbWRsZERvZ1FYQndiR2xqWVhScGIyNHNJSGRoYkd4bGREb2dkV2x1ZERZMEtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFl0TVRFNUNpQWdJQ0F2THlCeVpYUjFjbTRnWVdKcFEyRnNiRHgwZVhCbGIyWWdUVzlqYTFCeWFXNWphWEJoYkZCeWIySmxMbkJ5YjNSdmRIbHdaUzUwY25sUWNtOWlaVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdGeVoyVjBMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJkMkZzYkdWMFhTd0tJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdiV1YwYUc5a0lDSjBjbmxRY205aVpTaDFhVzUwTmpRcEtIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0p2YjJ3cElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERXpOd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pvNlVISnBibU5wY0dGc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QjBjbmxTWld4aGVTaDBZWEpuWlhRNklFRndjR3hwWTJGMGFXOXVMQ0IzWVd4c1pYUTZJSFZwYm5RMk5DazZJRkJ5YVc1amFYQmhiQ0I3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclVISnBibU5wY0dGc1VISnZZbVV1Y0dsdWJtVmtSbUZqZEc5eWVWQnliMkpsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NHbHVibVZrUm1GamRHOXllVkJ5YjJKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdjR2x1Ym1Wa1JtRmpkRzl5ZVZCeWIySmxLSGRoYkd4bGREb2dkV2x1ZERZMEtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklISmxkSFZ5YmlCeVpYTnZiSFpsVUhKcGJtTnBjR0ZzS0dkbGRFRnJhWFJoUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1M1lXeHNaWFFzSUhkaGJHeGxkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5QnlaWFIxY200Z2NtVnpiMngyWlZCeWFXNWphWEJoYkNoblpYUkJhMmwwWVVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWQyRnNiR1YwTENCM1lXeHNaWFFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lNRFlLSUNBZ0lDOHZJR052Ym5OMElGdGhjSEJNYVhOMFFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselFXdHBkR0ZCY0hCTWFYTjBLU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalFLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaWE52YkhabFVISnBibU5wY0dGc0tHZGxkRUZyYVhSaFFYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtTNTNZV3hzWlhRc0lIZGhiR3hsZENrS0lDQWdJSEIxYzJocGJuUWdPRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakl4TWdvZ0lDQWdMeThnVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNakV6Q2lBZ0lDQXZMeUJIYkc5aVlXd3VZMkZzYkdWeVFYQndiR2xqWVhScGIyNUpaQ3dLSUNBZ0lHZHNiMkpoYkNCRFlXeHNaWEpCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pJeE5Bb2dJQ0FnTHk4Z1IyeHZZbUZzTG1OaGJHeGxja0Z3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRFlXeHNaWEpCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNakE1TFRJeE5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbGMyOXNkbVZRY21sdVkybHdZV3hEZEhnb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEVaaFkzUnZjbmtzQ2lBZ0lDQXZMeUFnSUdocGJuUXNDaUFnSUNBdkx5QWdJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUVkc2IySmhiQzVqWVd4c1pYSkJjSEJzYVdOaGRHbHZia2xrTEFvZ0lDQWdMeThnSUNCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0IwY25WbENpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TWpFMUNpQWdJQ0F2THlCMGNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveU1Ea3RNakUyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjbVZ6YjJ4MlpWQnlhVzVqYVhCaGJFTjBlQ2dLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBSbUZqZEc5eWVTd0tJQ0FnSUM4dklDQWdhR2x1ZEN3S0lDQWdJQzh2SUNBZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdSMnh2WW1Gc0xtTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNXUXNDaUFnSUNBdkx5QWdJRWRzYjJKaGJDNWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIUnlkV1VLSUNBZ0lDOHZJQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnpiMngyWlZCeWFXNWphWEJoYkVOMGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdjR2x1Ym1Wa1JtRmpkRzl5ZVZCeWIySmxLSGRoYkd4bGREb2dkV2x1ZERZMEtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazF2WTJ0UWNtbHVZMmx3WVd4UWNtOWlaUzUxYm5CcGJtNWxaRVpoWTNSdmNubGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxYm5CcGJtNWxaRVpoWTNSdmNuazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE14Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0hKdlltVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNek1LSUNBZ0lDOHZJR052Ym5OMElGdGtZVzlkSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFZXbHVkRFkwS0hkaGJHeGxkQ3dnUW5sMFpYTW9SMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCeWIySmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0wQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWEJ3VEdsemRFSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dSaGJ5d2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5CYTJsMFlVRndjRXhwYzNRcEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdSbFkyOWtaVUZ5WXpROFFXdHBkR0ZCY0hCTWFYTjBQaWhoY0hCTWFYTjBRbmwwWlhNcExuZGhiR3hsZEFvZ0lDQWdaWGgwY21GamRDQTRPQ0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRRY21sdVkybHdZV3hRY205aVpTNW5aVzUxYVc1bFJtOXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWdWRXbHVaVVp2Y2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3Y205aVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHbHpSMlZ1ZFdsdVpWZGhiR3hsZENoM1lXeHNaWFFzSUdaaFkzUnZjbmtwQ2lBZ0lDQmpZV3hzYzNWaUlHbHpSMlZ1ZFdsdVpWZGhiR3hsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdjbTlpWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjSEp2WW1VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXOWphMUJ5YVc1amFYQmhiRkJ5YjJKbExuQnBibTVsWkVaaFkzUnZjbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd2FXNXVaV1JHWVdOMGIzSjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2NtOWlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTndvZ0lDQWdMeThnY21WMGRYSnVJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzUzWVd4c1pYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRM0NpQWdJQ0F2THlCeVpYUjFjbTRnWjJWMFFXdHBkR0ZCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwTG5kaGJHeGxkQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qQTJDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhRWEJ3VEdsemRDa3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTNDaUFnSUNBdkx5QnlaWFIxY200Z1oyVjBRV3RwZEdGQmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExuZGhiR3hsZEFvZ0lDQWdaWGgwY21GamRDQTRPQ0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRRY21sdVkybHdZV3hRY205aVpTNWpZV3hzWlhKQmNIQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVd4c1pYSkJjSEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnliMkpsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbU5oYkd4bGNrRndjR3hwWTJGMGFXOXVTV1FLSUNBZ0lHZHNiMkpoYkNCRFlXeHNaWEpCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJ5YjJKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lJQkJVZmZIVUpZV3RwZEdGZlpHRnZBMkZoYkFFQUVtTnZiblJ5YjJ4c1pXUmZZV1JrY21WemN3UXkyUXFxQklYdXNaZ0ljbVZtWlhKeVpYSXhHUlJFTVJoQkFKR0FCSVZON2VBbkJTY0dnaEVFNDVlbzJBVFBiTWZIQkJPMGw3Y0VPREcwWlFRN2VLQ3RCQlBpNWtzRWkrMGV0Z1RUbHZRdUJNalpwWllFOS9xamFBUzFYSERzQkwzVUlkWUVyQndhWXdSa1gyRkRCSWM2d09JRVBJOGhlUVQwTmlXck5ob0FqaFFBQVFJRUFoc0NRZ0pvQW5vQ3N3TGVBMFFEbUFQMUJGQUV5Z1QwQlRFRmJnV1ZCYTBGelFYZEFDTkRnQVFrRFM5bk5ob0FqZ0VCNWdDS0FRRXlBMGtpRm92L1VFOENVSXYvVUV4UUsxQ0ppZ0lCSW92K1FRQUZpLzlBQUFNaVRJbUwvbklIVEl3QVFRQVdpLzhXZ0FWaGNIQkpSRXhRQTRzQUVrRUFBeU5NaVNKQy8vcUtBd0dML292L0VrRUFBaU9KaS8xeUNFQUFBeUpNaVl2K1N3RVNRUUFIY3dKSU1nTVNpWXYrY3dKSUVvbUtCZ0VpaS90QUFBZUwvSWovZWt5SmkvdUwrb2ovaDBBQUc0di9RUUFQZ0F0RlVsSTZaWEp5U0c1M2JMQUFpL3lJLzFWTWlZdjlRQUFiaS85QkFBK0FDMFZTVWpwbGNuSklkRzl3c0FDTC9Jai9OVXlKSW92OWkvc1RRUUJRU0l2N2dCQnpjR1Z1WkdsdVoxOWhaR1J5WlhOelpVeU1BRUVBR0lzQUZTVVNRUUFRaXdDTC9CSkJBQWlML0l2K0UwQUFHNHYvUVFBUGdBdEZVbEk2WlhKeVNHNWlaTEFBaS95SS90MU1pU09MK3ljRVpVRUFCMGtWSlJKQUFCMUdBb3YvUVFBUGdBdEZVbEk2WlhKeVNYZHNkTEFBaS95SS9yQk1pWXY3U3dHTC9Jais4RXlMK3ljSFpVRUFNMGtWSlJKQkFDeE1pL3hMQVU4RVNVNERUVXhCQUJaTWkvc1dUd0pRVEZDTC9GQk1VQ3NpVHdOVVVFeUpSUUV5QTBMLzVFZ3lBMHhDLzg2S0F3R0wvb3Y5aVA1dVFBQUNJb21ML25JSVNFbUwveEpCQUFkekFrZ3lBeEtKaS85ekFrZ1NpWW9DQVl2K0ttVklnVmhiTVFBeURUSU9Ud09MLzA0RVRnUWppUDZVaVRZYUFVa1ZKQkpFRnlsTVp5TkROaG9CU1JVa0VrUVhJaWxsUkV5SS84TW9URkN3STBNMkdnRkpGU1FTUkJjaUtXVkVLbVZJZ1ZoYk1RQXlEVElPVHdOT0JDS0kvazBvVEZDd0kwTTJHZ0ZKRlNRU1JCY3lEQ0lwWlVSUEFvai9naklNVEZkSUlERUFFa1FKRmloTVVMQWpRellhQVJVa0VrUXhBSE1DU0NoTVVMQWpRellhQVVrVkpCSkVGMGtpS1dWRUttVklnVmhiaVAyV1FBQUpTRElES0V4UXNDTkRKd2RsUVFBS1NSVWxFa0VBQTBMLzZrZ3lBMEwvNURZYUFVa1ZKQkpFRnpZYUFra1ZKUkpFSWlsbFJDcGxTSUZZVzA0Q2lQN2NLeUpQQWxRb1RGQ3dJME0yR2dGSEFoVWxFa1EyR2dKSkZTUVNSQmRNTmhvRFNVNENTUlVsRWtRaUtXVkVLbVZJZ1ZoYlRnSVNRUUFJUmdNb1RGQ3dJME5MQWtzRWlQNlVRQUFGUmdKQy8rdE1jZ2hJU1VzQ0VrRUFDbk1DU0RJREVrMUMvOVpNU1hNQ1NFOENFazFDLzhvMkdnRkhBaFVsRWtRMkdnSkpGU1FTUkJkSlRnSWlLV1ZFS21WSWdWaGJURThDaVA1R1FBQUhTQ2hNVUxBalEwa25CR1ZCQUFkSkZTVVNRQUFGUmdKQy8rZEpUZ0pQQTBsT0E0ajh5MHhPQWsxQy85V0FBRFlhQVVjQ0ZZRklFa1EyR2dKSlRnTkpGU1VTUkNJcFpVUXFaVWlCV0Z0T0EweFhBQ0FTUUFBS1NWY29JRXNERWtFQURVZ2pLeUpQQWxRb1RGQ3dJME1sVzBsRkJFRUFEMGxMQTBzRGlQM0ZRUUFFSTBMLzNpSkMvOW8yR2dGSkZTVVNSRFlhQWtrVkpCSkVGMGtpS1dWRUttVklnVmhiVGdOQkFBeExBa3NCU3dPSS9aQkFBQXBHQWlJV0tFeFFzQ05EU1NjRVpVRUFCMGtWSlJKQUFBWkdBeUpDLytWTVNVOENUd09JL0JNaVRnSk5Rdi9WTVJZakNVY0NPQkNCQmhKRU5ob0JTVTRDRllGSUVrUTJHZ0pKRlNRU1JCZE1JaWxsUkV3NEdFd3FaVWlCS0ZzU1FRQkRTd0k0R1VBQVBFc0NPQnVCQkJKQkFESkxBamthQUlBRW14UjlMQkpCQUNOTEFqa2FBVXNDRWtFQUdFc0NPUm9DU3dFV0VrRUFEQ01ySWs4Q1ZDaE1VTEFqUXlKQy8vRTJHZ0ZKRlNRU1JCY2lLV1ZFVElqOC9VbFhDQ0JMQVZjQUNFOENWMGdnVGdKUVRGQW9URkN3STBNMkdnRkpGU1FTUkJjMkdnSkpGU1FTUkxGTXNoZ25CYklhc2hxQkJySVFJcklCczdRK1NWY0VBRXhYQUFRb0VrUkpGWUdKQVJKRUtFeFFzQ05ETmhvQlNSVWtFa1FYTmhvQ1NSVWtFa1N4VExJWUp3YXlHcklhZ1FheUVDS3lBYk8wUGtsWEJBQk1Wd0FFS0JKRVNSV0JpUUVTUkNoTVVMQWpRellhQVVrVkpCSkVGeUlwWlVRcVpVaUJXRnN4QURJTk1nNVBBMDRFSTRqNitpaE1VTEFqUXpZYUFVa1ZKQkpFRnlsbFNDcGxTRmRZQ0NoTVVMQWpRellhQVVrVkpCSkVGellhQWtrVkpCSkVGNGo2WlNzaVR3SlVLRXhRc0NORElpbGxSQ3BsU0ZkWUNDaE1VTEFqUXpJTkZpaE1VTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
