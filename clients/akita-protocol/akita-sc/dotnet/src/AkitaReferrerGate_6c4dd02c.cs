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

namespace Arc56.Generated.akita_protocol.akita_sc.AkitaReferrerGate_6c4dd02c
{


    //
    // Passes when the acting Akita wallet's `referrer` is the registered referrer. The referrer is
    //self-asserted (residual R-REFERRER): it was chosen at wallet creation and an admin-updated
    //wallet can rewrite it.
    //
    //Context-aware (principal-resolution spec §6.9): `checkFor(ctx, ...)` uses `ctx.wallet`, the
    //wallet the first hop verified for this action. No registry read, so it also works for wallets
    //with an external controlled address and for wallets that never registered. Args are ignored.
    //The plain `check(caller, ...)` keeps the legacy registry rule (args = the 8-byte wallet id
    //registered for `caller`) but returns false instead of reverting when `caller` is unregistered.
    //
    public class AkitaReferrerGateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AkitaReferrerGateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AkitaReferrerGateRegistryInfo : AVMObjectType
            {
                public Algorand.Address Referrer { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
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

                public static AkitaReferrerGateRegistryInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AkitaReferrerGateRegistryInfo();
                    uint count = 0;
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
                    return Equals(obj as AkitaReferrerGateRegistryInfo);
                }
                public bool Equals(AkitaReferrerGateRegistryInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AkitaReferrerGateRegistryInfo left, AkitaReferrerGateRegistryInfo right)
                {
                    return EqualityComparer<AkitaReferrerGateRegistryInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(AkitaReferrerGateRegistryInfo left, AkitaReferrerGateRegistryInfo right)
                {
                    return !(left == right);
                }

            }

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

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="version"> </param>
        /// <param name="akitaDAO"> </param>
        public async Task Create(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="args"> </param>
        public async Task<ulong> Cost(byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 159, 4, 238 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Cost_Transactions(byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 159, 4, 238 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="args"> </param>
        public async Task<ulong> Register(PaymentTransaction mbrPayment, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 119, 187, 121, 185 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Register_Transactions(PaymentTransaction mbrPayment, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 119, 187, 121, 185 };
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///LEGACY subject rule (EscrowFactory registry): `args` is the 8-byte wallet id registered for
        ///`caller`. Returns false (no revert) when `caller` is not registered or is registered to
        ///another wallet, so OR groups keep working.
        ///</summary>
        /// <param name="caller"> </param>
        /// <param name="registryID"> </param>
        /// <param name="args"> </param>
        public async Task<bool> Check(Algorand.Address caller, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 245, 10 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Check_Transactions(Algorand.Address caller, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 245, 10 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Context-aware check: rule `ctx.wallet != 0 && referrer(ctx.wallet) == registered`. `ctx.wallet`
        ///is the actor's own wallet, verified by the first hop (spec §3.5), so no one can borrow another
        ///wallet's referrer. `args` are ignored (any value, including the legacy 8-byte wallet id).
        ///Resource: P(ctx.wallet).
        ///</summary>
        /// <param name="ctx"> GateCtx</param>
        /// <param name="registryID"> </param>
        /// <param name="args"> </param>
        public async Task<bool> CheckFor(Structs.GateCtx ctx, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 52, 170, 220 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            var result = await base.CallApp(new List<object> { abiHandle, ctx, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CheckFor_Transactions(Structs.GateCtx ctx, ulong registryID, byte[] args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 52, 170, 220 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);
            var argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); argsAbi.From(args);

            return await base.MakeTransactionList(new List<object> { abiHandle, ctx, registryIDAbi, argsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registryID"> </param>
        public async Task<byte[]> GetEntry(ulong registryID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 212, 250, 93 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);

            var result = await base.SimApp(new List<object> { abiHandle, registryIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetEntry_Transactions(ulong registryID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 212, 250, 93 };
            var registryIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryIDAbi.From(registryID);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        public async Task UpdateAkitaDao(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAkitaDao_Transactions(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFSZWZlcnJlckdhdGUiLCJkZXNjIjoiUGFzc2VzIHdoZW4gdGhlIGFjdGluZyBBa2l0YSB3YWxsZXQncyBgcmVmZXJyZXJgIGlzIHRoZSByZWdpc3RlcmVkIHJlZmVycmVyLiBUaGUgcmVmZXJyZXIgaXNcbnNlbGYtYXNzZXJ0ZWQgKHJlc2lkdWFsIFItUkVGRVJSRVIpOiBpdCB3YXMgY2hvc2VuIGF0IHdhbGxldCBjcmVhdGlvbiBhbmQgYW4gYWRtaW4tdXBkYXRlZFxud2FsbGV0IGNhbiByZXdyaXRlIGl0LlxuXG5Db250ZXh0LWF3YXJlIChwcmluY2lwYWwtcmVzb2x1dGlvbiBzcGVjIMKnNi45KTogYGNoZWNrRm9yKGN0eCwgLi4uKWAgdXNlcyBgY3R4LndhbGxldGAsIHRoZVxud2FsbGV0IHRoZSBmaXJzdCBob3AgdmVyaWZpZWQgZm9yIHRoaXMgYWN0aW9uLiBObyByZWdpc3RyeSByZWFkLCBzbyBpdCBhbHNvIHdvcmtzIGZvciB3YWxsZXRzXG53aXRoIGFuIGV4dGVybmFsIGNvbnRyb2xsZWQgYWRkcmVzcyBhbmQgZm9yIHdhbGxldHMgdGhhdCBuZXZlciByZWdpc3RlcmVkLiBBcmdzIGFyZSBpZ25vcmVkLlxuVGhlIHBsYWluIGBjaGVjayhjYWxsZXIsIC4uLilgIGtlZXBzIHRoZSBsZWdhY3kgcmVnaXN0cnkgcnVsZSAoYXJncyA9IHRoZSA4LWJ5dGUgd2FsbGV0IGlkXG5yZWdpc3RlcmVkIGZvciBgY2FsbGVyYCkgYnV0IHJldHVybnMgZmFsc2UgaW5zdGVhZCBvZiByZXZlcnRpbmcgd2hlbiBgY2FsbGVyYCBpcyB1bnJlZ2lzdGVyZWQuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFraXRhUmVmZXJyZXJHYXRlUmVnaXN0cnlJbmZvIjpbeyJuYW1lIjoicmVmZXJyZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiR2F0ZUN0eCI6W3sibmFtZSI6InByaW5jaXBhbCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoid2FsbGV0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNwZW5kZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29zdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrIiwiZGVzYyI6IkxFR0FDWSBzdWJqZWN0IHJ1bGUgKEVzY3Jvd0ZhY3RvcnkgcmVnaXN0cnkpOiBgYXJnc2AgaXMgdGhlIDgtYnl0ZSB3YWxsZXQgaWQgcmVnaXN0ZXJlZCBmb3JcbmBjYWxsZXJgLiBSZXR1cm5zIGZhbHNlIChubyByZXZlcnQpIHdoZW4gYGNhbGxlcmAgaXMgbm90IHJlZ2lzdGVyZWQgb3IgaXMgcmVnaXN0ZXJlZCB0b1xuYW5vdGhlciB3YWxsZXQsIHNvIE9SIGdyb3VwcyBrZWVwIHdvcmtpbmcuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tGb3IiLCJkZXNjIjoiQ29udGV4dC1hd2FyZSBjaGVjazogcnVsZSBgY3R4LndhbGxldCAhPSAwICYmIHJlZmVycmVyKGN0eC53YWxsZXQpID09IHJlZ2lzdGVyZWRgLiBgY3R4LndhbGxldGBcbmlzIHRoZSBhY3RvcidzIG93biB3YWxsZXQsIHZlcmlmaWVkIGJ5IHRoZSBmaXJzdCBob3AgKHNwZWMgwqczLjUpLCBzbyBubyBvbmUgY2FuIGJvcnJvdyBhbm90aGVyXG53YWxsZXQncyByZWZlcnJlci4gYGFyZ3NgIGFyZSBpZ25vcmVkIChhbnkgdmFsdWUsIGluY2x1ZGluZyB0aGUgbGVnYWN5IDgtYnl0ZSB3YWxsZXQgaWQpLlxuUmVzb3VyY2U6IFAoY3R4LndhbGxldCkuIiwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkdhdGVDdHgiLCJuYW1lIjoiY3R4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeUlEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEVudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5SUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MjksNTcwLDYwNl0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODNdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE5LDQxNV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJYXJnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMzLDM0OF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI3LDU2OF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJcmdhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjY3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5kYW8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDhdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTIsNDM3LDYzNSw2ODBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTcsMjU5LDI5OCwzOTMsNDg2LDU1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNCwyNjUsMzA1LDQwMCw1NTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNSwzODYsNTQzLDYwMiw2MjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3V0aWxzL3ByaW5jaXBhbC50czo6R2F0ZUN0eCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVlXdHBkR0ZmWkdGdklpQXdlREUxTVdZM1l6YzFJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlJQ0pGVWxJNlpYSnlTV0Z5WnlJZ0lrVlNVanBsY25KSmNHRjVJaUFpUlZKU09tVnlja2x5WjJFaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhKbFoybHpkSEo1UTNWeWMyOXlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTVN3Z2EyVjVPaUJIWVhSbFIyeHZZbUZzVTNSaGRHVkxaWGxTWldkcGMzUnllVU4xY25OdmNpQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljbVZuYVhOMGNubGZZM1Z5YzI5eUlnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklISmxaMmx6ZEhKaGRHbHZibE5vWVhCbElEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dKMkZrWkhKbGMzTW5MQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVWSmxaMmx6ZEhKaGRHbHZibE5vWVhCbElIMHBDaUFnSUNCd2RYTm9ZbmwwWlhOeklDSnlaV2RwYzNSeVlYUnBiMjVmYzJoaGNHVWlJQ0poWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllXdHBkR0V0Y21WbVpYSnlaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnWTJobFkydFRhR0Z3WlNBOUlFZHNiMkpoYkZOMFlYUmxQSE4wY21sdVp6NG9leUJwYm1sMGFXRnNWbUZzZFdVNklDY25MQ0JyWlhrNklFZGhkR1ZIYkc5aVlXeFRkR0YwWlV0bGVVTm9aV05yVTJoaGNHVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbU5vWldOclgzTm9ZWEJsSWlBaUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV3RwZEdGU1pXWmxjbkpsY2tkaGRHVWdaWGgwWlc1a2N5QkJhMmwwWVVKaGMyVkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFekNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE16STVaakEwWldVZ01IZzNOMkppTnpsaU9TQXdlRFpsTURObU5UQmhJREI0WWprek5HRmhaR01nTUhnNU1HUTBabUUxWkNBd2VETXpaVGt5WXprMElEQjRPRFUwWkdWa1pUQWdMeThnYldWMGFHOWtJQ0pqYjNOMEtHSjVkR1ZiWFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5KbFoybHpkR1Z5S0hCaGVTeGllWFJsVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamFHVmpheWhoWkdSeVpYTnpMSFZwYm5RMk5DeGllWFJsVzEwcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWTJobFkydEdiM0lvS0dGa1pISmxjM01zZFdsdWREWTBMR0ZrWkhKbGMzTXBMSFZwYm5RMk5DeGllWFJsVzEwcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFJXNTBjbmtvZFdsdWREWTBLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlkWEJrWVhSbFFXdHBkR0ZFUVU4b2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3VlhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamIzTjBJSEpsWjJsemRHVnlJR05vWldOcklHTm9aV05yUm05eUlHZGxkRVZ1ZEhKNUlIVndaR0YwWlVGcmFYUmhSRUZQSUcxaGFXNWZiM0JWY0Y5eWIzVjBaVUF4TVFvZ0lDQWdaWEp5Q2dwdFlXbHVYMjl3VlhCZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TXpBS0lDQWdJQzh2SUc5d1ZYQW9LVG9nZG05cFpDQjdJSDBLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCYTJsMFlWSmxabVZ5Y21WeVIyRjBaU0JsZUhSbGJtUnpJRUZyYVhSaFFtRnpaVU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR05rT1dGa05qZGxJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSE4wY21sdVp5eDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYTJsMFlTMXlaV1psY25KbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJhMmwwWVZKbFptVnljbVZ5UjJGMFpTNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUwQ2lBZ0lDQXZMeUIyWlhKemFXOXVJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbFdaWEp6YVc5dUlIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luWmxjbk5wYjI0aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklIUm9hWE11ZG1WeWMybHZiaTUyWVd4MVpTQTlJSFpsY25OcGIyNEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem94TmdvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVd0cGRHRXRjbVZtWlhKeVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU0E5SUVGd2NHeHBZMkYwYVc5dUtHRnJhWFJoUkVGUEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVd0cGRHRXRjbVZtWlhKeVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRnJhWFJoVW1WbVpYSnlaWEpIWVhSbExtTnZjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIzTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGEybDBZUzF5WldabGNuSmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJqYjNOMEtHRnlaM002SUdKNWRHVnpLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQTBPV1EwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGcmFYUmhMWEpsWm1WeWNtVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZyYVhSaFVtVm1aWEp5WlhKSFlYUmxMbkpsWjJsemRHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUhKbFoybHpkR1Z5S0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lYSm5jem9nWW5sMFpYTXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGcmFYUmhMWEpsWm1WeWNtVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoaGNtZHpMbXhsYm1kMGFDQTlQVDBnTXpJc0lHVnlja2x1ZG1Gc2FXUkJjbWREYjNWdWRDa0tJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldkcGMzUmxjbDloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2tsaGNtY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTV0Z5WndvS2NtVm5hWE4wWlhKZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnWlhKeVNXNTJZV3hwWkZCaGVXMWxiblFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhKbFoybHpkR1Z5WDJGbWRHVnlYMkZ6YzJWeWRFQTFDaUFnSUNCaWVYUmxZeUEwSUM4dklDSkZVbEk2WlhKeVNYQmhlU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpKY0dGNUNncHlaV2RwYzNSbGNsOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRzFpY2xCaGVXMWxiblF1WVcxdmRXNTBJRDA5UFNCQmEybDBZVkpsWm1WeWNtVnlSMkYwWlZKbFoybHpkSEo1VFVKU0xDQmxjbkpKYm5aaGJHbGtVR0Y1YldWdWRDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnY0hWemFHbHVkQ0F4T0Rrd01Bb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5aFpuUmxjbDloYzNObGNuUkFOd29nSUNBZ1lubDBaV01nTkNBdkx5QWlSVkpTT21WeWNrbHdZWGtpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1hCaGVRb0tjbVZuYVhOMFpYSmZZV1owWlhKZllYTnpaWEowUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklHTnZibk4wSUdsa0lEMGdkR2hwY3k1eVpXZHBjM1J5ZVVOMWNuTnZjaTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NtVm5hWE4wY25sRGRYSnpiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBeExDQnJaWGs2SUVkaGRHVkhiRzlpWVd4VGRHRjBaVXRsZVZKbFoybHpkSEo1UTNWeWMyOXlJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p5WldkcGMzUnllVjlqZFhKemIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGcmFYUmhMWEpsWm1WeWNtVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR052Ym5OMElHbGtJRDBnZEdocGN5NXlaV2RwYzNSeWVVTjFjbk52Y2k1MllXeDFaUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVd0cGRHRXRjbVZtWlhKeVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdkR2hwY3k1eVpXZHBjM1J5ZVVOMWNuTnZjaTUyWVd4MVpTQXJQU0F4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklISmxaMmx6ZEhKNVEzVnljMjl5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01Td2dhMlY1T2lCSFlYUmxSMnh2WW1Gc1UzUmhkR1ZMWlhsU1pXZHBjM1J5ZVVOMWNuTnZjaUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY21WbmFYTjBjbmxmWTNWeWMyOXlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGEybDBZUzF5WldabGNuSmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUIwYUdsekxuSmxaMmx6ZEhKNVEzVnljMjl5TG5aaGJIVmxJQ3M5SURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Ea0tJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbmtvYVdRcExuWmhiSFZsSUQwZ1pHVmpiMlJsUVhKak5EeEJhMmwwWVZKbFptVnljbVZ5UjJGMFpWSmxaMmx6ZEhKNVNXNW1iejRvWVhKbmN5a0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklISmxaMmx6ZEdWeUtHMWljbEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2dZWEpuY3pvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllXdHBkR0V0Y21WbVpYSnlaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVd0cGRHRlNaV1psY25KbGNrZGhkR1V1WTJobFkydGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYUdWamF6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVd0cGRHRXRjbVZtWlhKeVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPQW9nSUNBZ0x5OGdZMmhsWTJzb1kyRnNiR1Z5T2lCQlkyTnZkVzUwTENCeVpXZHBjM1J5ZVVsRU9pQjFhVzUwTmpRc0lHRnlaM002SUdKNWRHVnpLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGcmFYUmhMWEpsWm1WeWNtVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoaGNtZHpMbXhsYm1kMGFDQTlQVDBnT0N3Z1pYSnlTVzUyWVd4cFpFRnlaME52ZFc1MEtRb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJqYUdWamExOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldOZk15QXZMeUFpUlZKU09tVnlja2xoY21jaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNXRnlad29LWTJobFkydGZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXdDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEdocGN5NXlaV2RwYzNSeWVTaHlaV2RwYzNSeWVVbEVLUzVsZUdsemRITXNJR1Z5Y2tsdWRtRnNhV1JTWldkcGMzUnllVUZ5WnlrS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dZMmhsWTJ0ZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJa1ZTVWpwbGNuSkpjbWRoSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tseVoyRUtDbU5vWldOclgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCeVpXWmxjbkpsY2lCOUlEMGdZMnh2Ym1Vb2RHaHBjeTV5WldkcGMzUnllU2h5WldkcGMzUnllVWxFS1M1MllXeDFaU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllXdHBkR0V0Y21WbVpYSnlaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURRdE1UQTNDaUFnSUNBdkx5QmpiMjV6ZENCeVpXZHBjM1JsY21Wa0lEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1JYTmpjbTkzUm1GamRHOXllUzV3Y205MGIzUjVjR1V1WjJWMFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5aWFJQZEdobGNrRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VaWE5qY205M0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlkyRnNiR1Z5WFFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklHRndjRWxrT2lCblpYUlBkR2hsY2tGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdVpYTmpjbTkzTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklHRndjRWxrT2lCblpYUlBkR2hsY2tGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdVpYTmpjbTkzTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNakl4Q2lBZ0lDQXZMeUJqYjI1emRDQmJiM1JvWlhKQmNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VDNSb1pYSkJjSEJNYVhOMEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWIyRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z1lYQndTV1E2SUdkbGRFOTBhR1Z5UVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1bGMyTnliM2NzQ2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMExURXdOd29nSUNBZ0x5OGdZMjl1YzNRZ2NtVm5hWE4wWlhKbFpDQTlJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFVnpZM0p2ZDBaaFkzUnZjbmt1Y0hKdmRHOTBlWEJsTG1kbGRENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2daMlYwVDNSb1pYSkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbVZ6WTNKdmR5d0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyTmhiR3hsY2wwS0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pZekZoTm1Zek15QXZMeUJ0WlhSb2IyUWdJbWRsZENoaFpHUnlaWE56S1dKNWRHVmJYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmllWFJsY3dvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllXdHBkR0V0Y21WbVpYSnlaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURrS0lDQWdJQzh2SUdsbUlDaHlaV2RwYzNSbGNtVmtJQ0U5UFNCaGNtZHpLU0I3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdJVDBLSUNBZ0lHSjZJR05vWldOclgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdjRzl3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5QnlaWFIxY200Z1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BqYUdWamExOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXdHBkR0ZTWldabGNuSmxja2RoZEdVdVkyaGxZMnRBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z1kyaGxZMnNvWTJGc2JHVnlPaUJCWTJOdmRXNTBMQ0J5WldkcGMzUnllVWxFT2lCMWFXNTBOalFzSUdGeVozTTZJR0o1ZEdWektUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFekNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXlaV1psY25KbGNrZGhkR1VvWW5SdmFTaGhjbWR6S1N3Z2NtVm1aWEp5WlhJcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJSEpsWm1WeWNtVnlSMkYwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCamFHVmpheWhqWVd4c1pYSTZJRUZqWTI5MWJuUXNJSEpsWjJsemRISjVTVVE2SUhWcGJuUTJOQ3dnWVhKbmN6b2dZbmwwWlhNcE9pQmliMjlzWldGdUlIc0tJQ0FnSUdJZ1kyaGxZMnRmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGcmFYUmhMWEpsWm1WeWNtVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZyYVhSaFVtVm1aWEp5WlhKSFlYUmxMbU5vWldOclFEa0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRnJhWFJoVW1WbVpYSnlaWEpIWVhSbExtTm9aV05yUm05eVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMmhsWTJ0R2IzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGcmFYUmhMWEpsWm1WeWNtVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUJqYUdWamEwWnZjaWhqZEhnNklFZGhkR1ZEZEhnc0lISmxaMmx6ZEhKNVNVUTZJSFZwYm5RMk5Dd2dZWEpuY3pvZ1lubDBaWE1wT2lCaWIyOXNaV0Z1SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEY3lDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwSFlYUmxRM1I0Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllXdHBkR0V0Y21WbVpYSnlaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpNS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBhR2x6TG5KbFoybHpkSEo1S0hKbFoybHpkSEo1U1VRcExtVjRhWE4wY3l3Z1pYSnlTVzUyWVd4cFpGSmxaMmx6ZEhKNVFYSm5LUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCamFHVmphMFp2Y2w5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV01nTlNBdkx5QWlSVkpTT21WeWNrbHlaMkVpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1hKbllRb0tZMmhsWTJ0R2IzSmZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5QmpiMjV6ZENCN0lISmxabVZ5Y21WeUlIMGdQU0JqYkc5dVpTaDBhR2x6TG5KbFoybHpkSEo1S0hKbFoybHpkSEo1U1VRcExuWmhiSFZsS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjbVZtWlhKeVpYSkhZWFJsS0dOMGVDNTNZV3hzWlhRc0lISmxabVZ5Y21WeUtRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdjbVZtWlhKeVpYSkhZWFJsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeUNpQWdJQ0F2THlCamFHVmphMFp2Y2loamRIZzZJRWRoZEdWRGRIZ3NJSEpsWjJsemRISjVTVVE2SUhWcGJuUTJOQ3dnWVhKbmN6b2dZbmwwWlhNcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGcmFYUmhVbVZtWlhKeVpYSkhZWFJsTG1kbGRFVnVkSEo1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBSVzUwY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16QUtJQ0FnSUM4dklISmxkSFZ5YmlCbGJtTnZaR1ZCY21NMEtIUm9hWE11Y21WbmFYTjBjbmtvY21WbmFYTjBjbmxKUkNrdWRtRnNkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem82UVd0cGRHRkNZWE5sUTI5dWRISmhZM1F1ZFhCa1lYUmxRV3RwZEdGRVFVOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVkJhMmwwWVVSQlR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5Rb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1pYSnlUbTkwUVd0cGRHRkVZVzhwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1Ua0tJQ0FnSUM4dklHTnZibk4wSUZ0M1lXeHNaWFJKUkYwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaFZhVzUwTmpRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5YWVd4c1pYUXBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hPUW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2NIVnphR0o1ZEdWeklDSjNZV3hzWlhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1pYSnlUbTkwUVd0cGRHRkVZVzhwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSFZ3WkdGMFpVRnJhWFJoUkVGUFgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpwbGNuSk9aR0Z2SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2s1a1lXOEtDblZ3WkdGMFpVRnJhWFJoUkVGUFgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJM0NpQWdJQ0F2THlCMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbElEMGdZV3RwZEdGRVFVOEtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qVUtJQ0FnSUM4dklIVndaR0YwWlVGcmFYUmhSRUZQS0dGcmFYUmhSRUZQT2lCQmNIQnNhV05oZEdsdmJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXdHBkR0ZTWldabGNuSmxja2RoZEdVdWNtVm1aWEp5WlhKSFlYUmxLSGRoYkd4bGREb2dkV2x1ZERZMExDQnlaV1psY25KbGNqb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tjbVZtWlhKeVpYSkhZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCd2NtbDJZWFJsSUhKbFptVnljbVZ5UjJGMFpTaDNZV3hzWlhRNklIVnBiblEyTkN3Z2NtVm1aWEp5WlhJNklFRmpZMjkxYm5RcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllXdHBkR0V0Y21WbVpYSnlaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWTI5dWMzUWdabUZqZEc5eWVTQTlJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzUzWVd4c1pYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGhkR1Z6TDNOMVlpMW5ZWFJsY3k5aGEybDBZUzF5WldabGNuSmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJqYjI1emRDQm1ZV04wYjNKNUlEMGdaMlYwUVd0cGRHRkJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMbmRoYkd4bGRBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpBMkNpQWdJQ0F2THlCamIyNXpkQ0JiWVhCd1RHbHpkRUo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektHRnJhWFJoUkVGUExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMEZyYVhSaFFYQndUR2x6ZENrcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1GaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5ZWFJsY3k5emRXSXRaMkYwWlhNdllXdHBkR0V0Y21WbVpYSnlaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWTI5dWMzUWdabUZqZEc5eWVTQTlJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzUzWVd4c1pYUUtJQ0FnSUhCMWMyaHBiblFnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJGMFpYTXZjM1ZpTFdkaGRHVnpMMkZyYVhSaExYSmxabVZ5Y21WeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHbG1JQ2gzWVd4c1pYUWdQVDA5SURBZ2ZId2dJV2x6UjJWdWRXbHVaVmRoYkd4bGRDaDNZV3hzWlhRc0lHWmhZM1J2Y25rcEtTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKNklISmxabVZ5Y21WeVIyRjBaVjlwWmw5aWIyUjVRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVEF5Q2lBZ0lDQXZMeUJwWmlBb2QyRnNiR1YwSUQwOVBTQXdJSHg4SUhkaGJHeGxkRVpoWTNSdmNua2dQVDA5SURBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5vZ2NtVm1aWEp5WlhKSFlYUmxYMmxtWDJKdlpIbEFNVElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWJub2djbVZtWlhKeVpYSkhZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LQ25KbFptVnljbVZ5UjJGMFpWOXBabDlpYjJSNVFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hNRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ25KbFptVnljbVZ5UjJGMFpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02T21selIyVnVkV2x1WlZkaGJHeGxkRUF4T0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2FXWWdLSGRoYkd4bGRDQTlQVDBnTUNCOGZDQWhhWE5IWlc1MWFXNWxWMkZzYkdWMEtIZGhiR3hsZEN3Z1ptRmpkRzl5ZVNrcElIc0tJQ0FnSUdKdWVpQnlaV1psY25KbGNrZGhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpDZ3B5WldabGNuSmxja2RoZEdWZmFXWmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYTJsMFlTMXlaV1psY25KbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QnlaWFIxY200Z1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LY21WbVpYSnlaWEpIWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z1kyOXVjM1FnVzNKaGR5d2daWGhwYzNSelhTQTlJRUZ3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0hkaGJHeGxkQ3dnUW5sMFpYTW9VRkpKVGtOSlVFRk1YMHRGV1Y5U1JVWkZVbEpGVWlrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJoaWVYUmxjeUFpY21WbVpYSnlaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYTJsMFlTMXlaV1psY25KbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QnBaaUFvSVdWNGFYTjBjeUI4ZkNCaWFYUk1aVzVuZEdnb2NtRjNLU0E4UFNBMk5Da2dld29nSUNBZ1lub2djbVZtWlhKeVpYSkhZWFJsWDJsbVgySnZaSGxBTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lEdzlDaUFnSUNCaWVpQnlaV1psY25KbGNrZGhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTJDZ3B5WldabGNuSmxja2RoZEdWZmFXWmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkaGRHVnpMM04xWWkxbllYUmxjeTloYTJsMFlTMXlaV1psY25KbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QnlaWFIxY200Z2NtVm1aWEp5WlhJZ1BUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS2NtVm1aWEp5WlhKSFlYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bllYUmxjeTl6ZFdJdFoyRjBaWE12WVd0cGRHRXRjbVZtWlhKeVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdjbVYwZFhKdUlDaHlZWGN1YkdWdVozUm9JRDA5UFNBek1pQS9JRUZqWTI5MWJuUW9jbUYzS1NBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5a2dQVDA5SUhKbFptVnljbVZ5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0o2SUhKbFptVnljbVZ5UjJGMFpWOTBaWEp1WVhKNVgyWmhiSE5sUURnS0NuSmxabVZ5Y21WeVIyRjBaVjkwWlhKdVlYSjVYMjFsY21kbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyRjBaWE12YzNWaUxXZGhkR1Z6TDJGcmFYUmhMWEpsWm1WeWNtVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSEpsZEhWeWJpQW9jbUYzTG14bGJtZDBhQ0E5UFQwZ016SWdQeUJCWTJOdmRXNTBLSEpoZHlrZ09pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXBJRDA5UFNCeVpXWmxjbkpsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ25KbFptVnljbVZ5UjJGMFpWOTBaWEp1WVhKNVgyWmhiSE5sUURnNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWVhSbGN5OXpkV0l0WjJGMFpYTXZZV3RwZEdFdGNtVm1aWEp5WlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUNoeVlYY3ViR1Z1WjNSb0lEMDlQU0F6TWlBL0lFRmpZMjkxYm5Rb2NtRjNLU0E2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lrZ1BUMDlJSEpsWm1WeWNtVnlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0lnY21WbVpYSnlaWEpIWVhSbFgzUmxjbTVoY25sZmJXVnlaMlZBT1FvS2NtVm1aWEp5WlhKSFlYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXdOUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyTnlaV0YwYjNJc0lHVjRhWE4wYzEwZ1BTQnZjQzVCY0hCUVlYSmhiWE11WVhCd1EzSmxZWFJ2Y2loM1lXeHNaWFFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFTnlaV0YwYjNJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94TURZS0lDQWdJQzh2SUhKbGRIVnliaUJsZUdsemRITWdKaVlnWTNKbFlYUnZjaUE5UFQwZ1lYQndRV1JrY21WemMwOW1LSGRoYkd4bGRFWmhZM1J2Y25rcENpQWdJQ0JpZWlCeVpXWmxjbkpsY2tkaGRHVmZZbTl2YkY5bVlXeHpaVUF4TmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem8zTkFvZ0lDQWdMeThnY21WMGRYSnVJRUZqWTI5MWJuUW9iM0F1YzJoaE5URXlYekkxTmloQ2VYUmxjeWduWVhCd1NVUW5LUzVqYjI1allYUW9iM0F1YVhSdllpaGhjSEJKWkNrcEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1Gd2NFbEVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0UxTVRKZk1qVTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXdOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHVjRhWE4wY3lBbUppQmpjbVZoZEc5eUlEMDlQU0JoY0hCQlpHUnlaWE56VDJZb2QyRnNiR1YwUm1GamRHOXllU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtVm1aWEp5WlhKSFlYUmxYMkp2YjJ4ZlptRnNjMlZBTVRZS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMkYwWlhNdmMzVmlMV2RoZEdWekwyRnJhWFJoTFhKbFptVnljbVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUdsbUlDaDNZV3hzWlhRZ1BUMDlJREFnZkh3Z0lXbHpSMlZ1ZFdsdVpWZGhiR3hsZENoM1lXeHNaWFFzSUdaaFkzUnZjbmtwS1NCN0NpQWdJQ0JpSUhKbFptVnljbVZ5UjJGMFpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02T21selIyVnVkV2x1WlZkaGJHeGxkRUF4T0FvS2NtVm1aWEp5WlhKSFlYUmxYMkp2YjJ4ZlptRnNjMlZBTVRZNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRoZEdWekwzTjFZaTFuWVhSbGN5OWhhMmwwWVMxeVpXWmxjbkpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCcFppQW9kMkZzYkdWMElEMDlQU0F3SUh4OElDRnBjMGRsYm5WcGJtVlhZV3hzWlhRb2QyRnNiR1YwTENCbVlXTjBiM0o1S1NrZ2V3b2dJQ0FnWWlCeVpXWmxjbkpsY2tkaGRHVmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwcGMwZGxiblZwYm1WWFlXeHNaWFJBTVRnSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0NZR0NXRnJhWFJoWDJSaGJ3UVZIM3gxRDNKbFoybHpkSEo1WDJOMWNuTnZjZ3RGVWxJNlpYSnlTV0Z5Wnd0RlVsSTZaWEp5U1hCaGVRdEZVbEk2WlhKeVNYSm5ZVEVZUUFBeEtpTm5nZ0lTY21WbmFYTjBjbUYwYVc5dVgzTm9ZWEJsQjJGa1pISmxjM05uZ2dJTFkyaGxZMnRmYzJoaGNHVUFaekVaRkVReEdFRUFPNElIQkRLZkJPNEVkN3Q1dVFSdUEvVUtCTGswcXR3RWtOVDZYUVF6NlN5VUJJVk43ZUEyR2dDT0J3QTdBRmdBcndGTUFaQUJxZ0FCQUNORGdBVE5tdForTmhvQWpnRUFBUUEyR2dGSklsa2tDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUVhnQWQyWlhKemFXOXVUd0puS0V4bkkwTTJHZ0ZKSWxra0NFd1ZFa1NBREJVZmZIVUFBQUFBQUFCSjFMQWpRekVXSXdsSk9CQWpFa1EyR2dGSklsa2tDRXNCRlJKRVZ3SUFTUldCSUJKQUFBTXJzQUJMQVRnSE1nb1NRQUFFSndTd0FFdzRDSUhVa3dFU1FBQUVKd1N3QUNJcVpVUkpJd2dxVEdjV1NVOEN2eWxNVUxBalF6WWFBVWtWZ1NBU1JEWWFBa2tWSlJKRUZ6WWFBMGtpV1NRSVN3RVZFa1JYQWdCSlRnSVZKUkpBQUFNcnNBQVdTYjFGQVVBQUJDY0ZzQUMrUkZjQUlMRWlLR1ZFZ0FOdllXeGxTSUVZVzdJWWdBUThHbTh6c2hwUEFySWFnUWF5RUNLeUFiTzBQa2xYQkFCTEFWY0FCQ2tTUkVraVdTUUlUQlVTUkZjR0FFc0NFMEVBRUVZQ0lvQUJBQ0pQQWxRcFRGQ3dJME5NRjB5SUFKVkMvK28yR2dGSkZZRklFa1EyR2dKSkZTVVNSQmMyR2dOSklsa2tDRXdWRWtRV1NiMUZBVUFBQkNjRnNBQytSRmNBSUV5QklGdE1pQUJiZ0FFQUlrOENWQ2xNVUxBalF6WWFBVWtWSlJKRUZ4YStSRWtWRmxjR0FreFFLVXhRc0NORE5ob0JTUlVsRWtRWE1RQWlLR1ZFZ0FaM1lXeHNaWFJsU0hJSVJCSkFBQStBQzBWU1VqcGxjbkpPWkdGdnNBQW9UR2NqUTRvQ0FTSkpLR1ZFZ0FOaFlXeGxTSUZZVzR2K1FRQU9pLzVCQUFXTEFVQUFQQ0pBQUFRaWpBQ0ppLzZBQ0hKbFptVnljbVZ5WlVFQUNFbVRnVUFPUVFBSWkvOHlBeEtNQUlsSkZZRWdFa0VBQm92L0Vvd0FpVWd5QTBMLzlJditjZ2RNakFCQkFCZUxBUmFBQldGd2NFbEVURkFEaXdBU1FRQUVJMEwvcENKQy82QT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
