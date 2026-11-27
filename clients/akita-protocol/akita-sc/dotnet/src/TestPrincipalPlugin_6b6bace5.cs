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

namespace Arc56.Generated.akita_protocol.akita_sc.TestPrincipalPlugin_6b6bace5
{


    //
    // TEST-ONLY. Installable ARC-58 plugin for the principal-resolution suite
    //(docs/principal-resolution/PHASE-0-SPEC.md §5.1). Every method takes the wallet first
    //(`appArgs(1) == W`, required by the wallet's window pinning). Never deploy outside tests.
    //
    public class TestPrincipalPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestPrincipalPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CtxOwnsResult : AVMObjectType
            {
                public Structs.GateCtx Ctx { get; set; } = new Structs.GateCtx();

                public bool Owns { get; set; }

                public Algorand.Address ThirdParty { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Ctx.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwns = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vOwns.From(Owns);
                    ret.AddRange(vOwns.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThirdParty = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vThirdParty.From(ThirdParty);
                    ret.AddRange(vThirdParty.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CtxOwnsResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CtxOwnsResult();
                    uint count = 0;
                    ret.Ctx = Structs.GateCtx.Parse(queue.ToArray());
                    { var consumedCtx = ret.Ctx.ToByteArray().Length; for (int i = 0; i < consumedCtx && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwns = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vOwns.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwns = vOwns.ToValue();
                    if (valueOwns is bool vOwnsValue) { ret.Owns = vOwnsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThirdParty = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vThirdParty.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueThirdParty = vThirdParty.ToValue();
                    if (valueThirdParty is Algorand.Address vThirdPartyValue) { ret.ThirdParty = vThirdPartyValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CtxOwnsResult);
                }
                public bool Equals(CtxOwnsResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CtxOwnsResult left, CtxOwnsResult right)
                {
                    return EqualityComparer<CtxOwnsResult>.Default.Equals(left, right);
                }
                public static bool operator !=(CtxOwnsResult left, CtxOwnsResult right)
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
        ///`probe.probe(hint)` sent as the wallet's spending account S; rekeys S back when `rekeyBack`.
        ///NON-COMPLIANT on purpose: it forwards a caller-chosen `hint` (§3.8 rule 6 violation) so the suite can
        ///aim any hint at the open window. A shipping plugin forwards `windowHint(wallet)` (see `callProbeWindow`).
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<Structs.Principal> CallProbe(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 55, 22 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CallProbe_Transactions(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 55, 22 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T47 positive control: the compliant shape (§3.8 rule 6). The hint is `windowHint(wallet)`, the
        ///wallet whose window this call serves, never a caller-supplied value. Compare `callProbe`, whose
        ///caller-chosen `hint` is the T47 negative control.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        public async Task<Structs.Principal> CallProbeWindow(ulong wallet, bool rekeyBack, ulong probe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 104, 190, 224 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CallProbeWindow_Transactions(ulong wallet, bool rekeyBack, ulong probe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 104, 190, 224 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///`probe.tryProbe(hint)` sent as S (T27).
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<Structs.Principal> CallTryProbe(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 26, 94, 113 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CallTryProbe_Transactions(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 26, 94, 113 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T32: `probe.probeCost(hint)` sent as S: opcode cost of the strict resolution in the target.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<ulong> CallProbeCost(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 246, 139, 165 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallProbeCost_Transactions(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 246, 139, 165 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///V0.1: `probe.probeAuth(hint)` sent as S, returning what the callee sees as S.authAddress.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<Algorand.Address> CallProbeAuth(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 132, 58, 169 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> CallProbeAuth_Transactions(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 132, 58, 169 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///E11/T16: the plugin calls the probe as ITS OWN address with hint W, then rekeys S back.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<Structs.Principal> CallProbeAsSelf(ulong wallet, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 29, 13, 74 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CallProbeAsSelf_Transactions(ulong wallet, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 29, 13, 74 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T27: `tryProbe` as the plugin's own address, then rekeys S back.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<Structs.Principal> CallTryProbeAsSelf(ulong wallet, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 33, 237, 104 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CallTryProbeAsSelf_Transactions(ulong wallet, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 33, 237, 104 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///E9/T14 proxy chain (compliant P): rekey S to `proxy` in the SAME inner group as the proxy call
        ///(§3.8 rule 3(b)); the proxy probes as S and hands S back to this plugin before it returns.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="proxy"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<Structs.Principal> ProxyProbe(ulong wallet, bool rekeyBack, ulong proxy, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 125, 201, 129 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var proxyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proxyAbi.From(proxy);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, proxyAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProxyProbe_Transactions(ulong wallet, bool rekeyBack, ulong proxy, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 125, 201, 129 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var proxyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proxyAbi.From(proxy);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, proxyAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Negative control: the proxy is told to KEEP S (§3.8 rule 3(b) violation).
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="proxy"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        public async Task<Structs.Principal> ProxyProbeKeep(ulong wallet, ulong proxy, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 83, 229, 254 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var proxyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proxyAbi.From(proxy);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, proxyAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProxyProbeKeep_Transactions(ulong wallet, ulong proxy, ulong probe, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 83, 229, 254 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var proxyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proxyAbi.From(proxy);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, proxyAbi, probeAbi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T30: the plugin-side answer (`pluginPrincipal`) for this wallet. Call before S is rekeyed back.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.Principal> Principal(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 133, 208, 70 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Principal_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 133, 208, 70 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///E12/T17: sending as S, call `probe.relay(probe2, hint)`; probe2 then sees caller = probe.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="probe2"> </param>
        /// <param name="hint"> </param>
        public async Task<Structs.Principal> CallRelay(ulong wallet, bool rekeyBack, ulong probe, ulong probe2, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 254, 15, 237 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var probe2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probe2Abi.From(probe2);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, probe2Abi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Principal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CallRelay_Transactions(ulong wallet, bool rekeyBack, ulong probe, ulong probe2, ulong hint, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 254, 15, 237 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var probe2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probe2Abi.From(probe2);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, probe2Abi, hintAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///V0.2/T23: mid-window call-out to `MockPrincipalReenter.poke(this, forgedWallet, probe)`, which
        ///tries to re-enter this plugin with a forged wallet. The AVM rejects the re-entry.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="reenter"> </param>
        /// <param name="forgedWallet"> </param>
        /// <param name="probe"> </param>
        public async Task CallReenter(ulong wallet, ulong reenter, ulong forgedWallet, ulong probe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 7, 47, 226 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var reenterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reenterAbi.From(reenter);
            var forgedWalletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); forgedWalletAbi.From(forgedWallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, reenterAbi, forgedWalletAbi, probeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CallReenter_Transactions(ulong wallet, ulong reenter, ulong forgedWallet, ulong probe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 7, 47, 226 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var reenterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reenterAbi.From(reenter);
            var forgedWalletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); forgedWalletAbi.From(forgedWallet);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, reenterAbi, forgedWalletAbi, probeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T28 "escrow mid-window": `probe.owns(wallet.id, account)` while the window is open.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="account"> </param>
        public async Task<bool> CallOwns(ulong wallet, bool rekeyBack, ulong probe, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 98, 175, 160 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallOwns_Transactions(ulong wallet, bool rekeyBack, ulong probe, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 98, 175, 160 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T38–T40: `probe.probeCtx(hint)` as S (no rekey), then in the same window `probe.ctxOwns(ctx, account)`
        ///and, when `alsoThirdParty`, `probe.thirdParty(account, hint)` for the E23 comparison.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="hint"> </param>
        /// <param name="account"> </param>
        /// <param name="alsoThirdParty"> </param>
        public async Task<Structs.CtxOwnsResult> CallCtxOwns(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Algorand.Address account, bool alsoThirdParty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 74, 170, 155 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var alsoThirdPartyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); alsoThirdPartyAbi.From(alsoThirdParty);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi, accountAbi, alsoThirdPartyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CtxOwnsResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CallCtxOwns_Transactions(ulong wallet, bool rekeyBack, ulong probe, ulong hint, Algorand.Address account, bool alsoThirdParty, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 74, 170, 155 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var hintAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hintAbi.From(hint);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var alsoThirdPartyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); alsoThirdPartyAbi.From(alsoThirdParty);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, hintAbi, accountAbi, alsoThirdPartyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///T48: `probe.tipWalletOf(creator, stored)` while the window is open (E23: a held creator gets 0).
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="probe"> </param>
        /// <param name="creator"> </param>
        /// <param name="stored"> </param>
        public async Task<ulong> CallTipWallet(ulong wallet, bool rekeyBack, ulong probe, Algorand.Address creator, ulong stored, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 209, 42, 236 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var storedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); storedAbi.From(stored);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, creatorAbi, storedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallTipWallet_Transactions(ulong wallet, bool rekeyBack, ulong probe, Algorand.Address creator, ulong stored, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 209, 42, 236 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var probeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); probeAbi.From(probe);
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var storedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); storedAbi.From(stored);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, probeAbi, creatorAbi, storedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Hand S back to the wallet (closes a window opened with rekeyBack = false).
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task Done(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 93, 168, 67 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Done_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 93, 168, 67 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdFByaW5jaXBhbFBsdWdpbiIsImRlc2MiOiJURVNULU9OTFkuIEluc3RhbGxhYmxlIEFSQy01OCBwbHVnaW4gZm9yIHRoZSBwcmluY2lwYWwtcmVzb2x1dGlvbiBzdWl0ZVxuKGRvY3MvcHJpbmNpcGFsLXJlc29sdXRpb24vUEhBU0UtMC1TUEVDLm1kIMKnNS4xKS4gRXZlcnkgbWV0aG9kIHRha2VzIHRoZSB3YWxsZXQgZmlyc3RcbihgYXBwQXJncygxKSA9PSBXYCwgcmVxdWlyZWQgYnkgdGhlIHdhbGxldCdzIHdpbmRvdyBwaW5uaW5nKS4gTmV2ZXIgZGVwbG95IG91dHNpZGUgdGVzdHMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkN0eE93bnNSZXN1bHQiOlt7Im5hbWUiOiJjdHgiLCJ0eXBlIjoiR2F0ZUN0eCJ9LHsibmFtZSI6Im93bnMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6InRoaXJkUGFydHkiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiR2F0ZUN0eCI6W3sibmFtZSI6InByaW5jaXBhbCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoid2FsbGV0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNwZW5kZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiUHJpbmNpcGFsIjpbeyJuYW1lIjoid2FsbGV0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByaW5jaXBhbCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3JpZ2luIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzcGVuZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJyZWZlcnJlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidmlhUGx1Z2luIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxQcm9iZSIsImRlc2MiOiJgcHJvYmUucHJvYmUoaGludClgIHNlbnQgYXMgdGhlIHdhbGxldCdzIHNwZW5kaW5nIGFjY291bnQgUzsgcmVrZXlzIFMgYmFjayB3aGVuIGByZWtleUJhY2tgLlxuTk9OLUNPTVBMSUFOVCBvbiBwdXJwb3NlOiBpdCBmb3J3YXJkcyBhIGNhbGxlci1jaG9zZW4gYGhpbnRgICjCpzMuOCBydWxlIDYgdmlvbGF0aW9uKSBzbyB0aGUgc3VpdGUgY2FuXG5haW0gYW55IGhpbnQgYXQgdGhlIG9wZW4gd2luZG93LiBBIHNoaXBwaW5nIHBsdWdpbiBmb3J3YXJkcyBgd2luZG93SGludCh3YWxsZXQpYCAoc2VlIGBjYWxsUHJvYmVXaW5kb3dgKS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGludCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCkiLCJzdHJ1Y3QiOiJQcmluY2lwYWwiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsUHJvYmVXaW5kb3ciLCJkZXNjIjoiVDQ3IHBvc2l0aXZlIGNvbnRyb2w6IHRoZSBjb21wbGlhbnQgc2hhcGUgKMKnMy44IHJ1bGUgNikuIFRoZSBoaW50IGlzIGB3aW5kb3dIaW50KHdhbGxldClgLCB0aGVcbndhbGxldCB3aG9zZSB3aW5kb3cgdGhpcyBjYWxsIHNlcnZlcywgbmV2ZXIgYSBjYWxsZXItc3VwcGxpZWQgdmFsdWUuIENvbXBhcmUgYGNhbGxQcm9iZWAsIHdob3NlXG5jYWxsZXItY2hvc2VuIGBoaW50YCBpcyB0aGUgVDQ3IG5lZ2F0aXZlIGNvbnRyb2wuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvYmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGJvb2wpIiwic3RydWN0IjoiUHJpbmNpcGFsIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbFRyeVByb2JlIiwiZGVzYyI6ImBwcm9iZS50cnlQcm9iZShoaW50KWAgc2VudCBhcyBTIChUMjcpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxQcm9iZUNvc3QiLCJkZXNjIjoiVDMyOiBgcHJvYmUucHJvYmVDb3N0KGhpbnQpYCBzZW50IGFzIFM6IG9wY29kZSBjb3N0IG9mIHRoZSBzdHJpY3QgcmVzb2x1dGlvbiBpbiB0aGUgdGFyZ2V0LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbFByb2JlQXV0aCIsImRlc2MiOiJWMC4xOiBgcHJvYmUucHJvYmVBdXRoKGhpbnQpYCBzZW50IGFzIFMsIHJldHVybmluZyB3aGF0IHRoZSBjYWxsZWUgc2VlcyBhcyBTLmF1dGhBZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxQcm9iZUFzU2VsZiIsImRlc2MiOiJFMTEvVDE2OiB0aGUgcGx1Z2luIGNhbGxzIHRoZSBwcm9iZSBhcyBJVFMgT1dOIGFkZHJlc3Mgd2l0aCBoaW50IFcsIHRoZW4gcmVrZXlzIFMgYmFjay4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGludCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCkiLCJzdHJ1Y3QiOiJQcmluY2lwYWwiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsVHJ5UHJvYmVBc1NlbGYiLCJkZXNjIjoiVDI3OiBgdHJ5UHJvYmVgIGFzIHRoZSBwbHVnaW4ncyBvd24gYWRkcmVzcywgdGhlbiByZWtleXMgUyBiYWNrLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3h5UHJvYmUiLCJkZXNjIjoiRTkvVDE0IHByb3h5IGNoYWluIChjb21wbGlhbnQgUCk6IHJla2V5IFMgdG8gYHByb3h5YCBpbiB0aGUgU0FNRSBpbm5lciBncm91cCBhcyB0aGUgcHJveHkgY2FsbFxuKMKnMy44IHJ1bGUgMyhiKSk7IHRoZSBwcm94eSBwcm9iZXMgYXMgUyBhbmQgaGFuZHMgUyBiYWNrIHRvIHRoaXMgcGx1Z2luIGJlZm9yZSBpdCByZXR1cm5zLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3h5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGludCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCkiLCJzdHJ1Y3QiOiJQcmluY2lwYWwiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm94eVByb2JlS2VlcCIsImRlc2MiOiJOZWdhdGl2ZSBjb250cm9sOiB0aGUgcHJveHkgaXMgdG9sZCB0byBLRUVQIFMgKMKnMy44IHJ1bGUgMyhiKSB2aW9sYXRpb24pLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3h5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGludCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCkiLCJzdHJ1Y3QiOiJQcmluY2lwYWwiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcmluY2lwYWwiLCJkZXNjIjoiVDMwOiB0aGUgcGx1Z2luLXNpZGUgYW5zd2VyIChgcGx1Z2luUHJpbmNpcGFsYCkgZm9yIHRoaXMgd2FsbGV0LiBDYWxsIGJlZm9yZSBTIGlzIHJla2V5ZWQgYmFjay4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxib29sKSIsInN0cnVjdCI6IlByaW5jaXBhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxSZWxheSIsImRlc2MiOiJFMTIvVDE3OiBzZW5kaW5nIGFzIFMsIGNhbGwgYHByb2JlLnJlbGF5KHByb2JlMiwgaGludClgOyBwcm9iZTIgdGhlbiBzZWVzIGNhbGxlciA9IHByb2JlLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZTIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhpbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGJvb2wpIiwic3RydWN0IjoiUHJpbmNpcGFsIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbFJlZW50ZXIiLCJkZXNjIjoiVjAuMi9UMjM6IG1pZC13aW5kb3cgY2FsbC1vdXQgdG8gYE1vY2tQcmluY2lwYWxSZWVudGVyLnBva2UodGhpcywgZm9yZ2VkV2FsbGV0LCBwcm9iZSlgLCB3aGljaFxudHJpZXMgdG8gcmUtZW50ZXIgdGhpcyBwbHVnaW4gd2l0aCBhIGZvcmdlZCB3YWxsZXQuIFRoZSBBVk0gcmVqZWN0cyB0aGUgcmUtZW50cnkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVlbnRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9yZ2VkV2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9iZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsT3ducyIsImRlc2MiOiJUMjggXCJlc2Nyb3cgbWlkLXdpbmRvd1wiOiBgcHJvYmUub3ducyh3YWxsZXQuaWQsIGFjY291bnQpYCB3aGlsZSB0aGUgd2luZG93IGlzIG9wZW4uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvYmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxDdHhPd25zIiwiZGVzYyI6IlQzOOKAk1Q0MDogYHByb2JlLnByb2JlQ3R4KGhpbnQpYCBhcyBTIChubyByZWtleSksIHRoZW4gaW4gdGhlIHNhbWUgd2luZG93IGBwcm9iZS5jdHhPd25zKGN0eCwgYWNjb3VudClgXG5hbmQsIHdoZW4gYGFsc29UaGlyZFBhcnR5YCwgYHByb2JlLnRoaXJkUGFydHkoYWNjb3VudCwgaGludClgIGZvciB0aGUgRTIzIGNvbXBhcmlzb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvYmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhpbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWxzb1RoaXJkUGFydHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKChhZGRyZXNzLHVpbnQ2NCxhZGRyZXNzKSxib29sLGFkZHJlc3MpIiwic3RydWN0IjoiQ3R4T3duc1Jlc3VsdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxUaXBXYWxsZXQiLCJkZXNjIjoiVDQ4OiBgcHJvYmUudGlwV2FsbGV0T2YoY3JlYXRvciwgc3RvcmVkKWAgd2hpbGUgdGhlIHdpbmRvdyBpcyBvcGVuIChFMjM6IGEgaGVsZCBjcmVhdG9yIGdldHMgMCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvYmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdG9yZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkb25lIiwiZGVzYyI6IkhhbmQgUyBiYWNrIHRvIHRoZSB3YWxsZXQgKGNsb3NlcyBhIHdpbmRvdyBvcGVuZWQgd2l0aCByZWtleUJhY2sgPSBmYWxzZSkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ2Niw1NTEsNjQ1LDc0Myw4NDAsOTA3LDk4MSwxMTE1LDEyMzEsMTczMCwxODk3LDIwMjgsMjA3MiwyMTMyLDIyNDJdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwMywxNDQxXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckhuYmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjc3LDEzNzBdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySG53bCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOTBdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySHRvcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OTJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySXdsdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMywxMzE4XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5hdGgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDNdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OSwxMDU1LDExNzNdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjU0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQ2LDIxMzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMiw0OTYsNTgwLDY3NCw3NzEsMTAxNywxNjQ5LDE4MzksMTkzMiwxOTc4LDIxNzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1OSwxOTcwLDIxOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc4LDM5Myw0MTIsNDIxLDQ4Niw1MDYsNTcxLDU5MCw1OTksNjY1LDY4NCw2OTMsNzYyLDc4MSw3OTAsODYwLDg2OSw4NzgsOTMzLDk0Miw5NTEsMTAwNywxMDI3LDEwMzYsMTA0NCwxMTM1LDExNDUsMTE1NCwxMTYyLDEyNDcsMTY0MCwxNjU5LDE2NjgsMTY3NiwxNzUwLDE3NTksMTc2OCwxNzc3LDE4MjksMTg0OSwxOTIyLDE5NDMsMTk1OCwyMTY3LDIxODYsMjIwNCwyMjY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkwMiwyMDc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy91dGlscy9wcmluY2lwYWwudHM6OkdhdGVDdHgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzIsNTU3LDY1MSw5MTMsOTg3LDE3MzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3V0aWxzL3ByaW5jaXBhbC50czo6UHJpbmNpcGFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ4LDIyNDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dPQ0F3SURFZ05pQXhNemNLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpYzNCbGJtUnBibWRmWVdSa2NtVnpjeUlnTUhnd01DQXdlRE15WkRrd1lXRmhJQ0pGVWxJNlpYSnlUbUYwYUNJZ0ltRnJhWFJoWDJSaGJ5SWdNSGc0TldWbFlqRTVPQ0F3ZUdNeE5XSTVZakkwSUNKRlVsSTZaWEp5U0c1M2JDSWdJa1ZTVWpwbGNuSklibUprSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSUWNtbHVZMmx3WVd4UWJIVm5hVzRnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FESXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRObVJtTkRNM01UWWdNSGd5TmpZNFltVmxNQ0F3ZURFMk1XRTFaVGN4SURCNE4yRm1OamhpWVRVZ01IaGpOamcwTTJGaE9TQXdlR1F5TVdRd1pEUmhJREI0TVdZeU1XVmtOamdnTUhneVlUZGtZems0TVNBd2VHUm1OVE5sTldabElEQjRNbVU0TldRd05EWWdNSGc1WldabE1HWmxaQ0F3ZUdRek1EY3labVV5SURCNE1tTTJNbUZtWVRBZ01IZzFOVFJoWVdFNVlpQXdlR1ZqWkRFeVlXVmpJREI0TWprMVpHRTRORE1nTHk4Z2JXVjBhRzlrSUNKallXeHNVSEp2WW1Vb2RXbHVkRFkwTEdKdmIyd3NkV2x1ZERZMExIVnBiblEyTkNrb2RXbHVkRFkwTEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbTl2YkNraUxDQnRaWFJvYjJRZ0ltTmhiR3hRY205aVpWZHBibVJ2ZHloMWFXNTBOalFzWW05dmJDeDFhVzUwTmpRcEtIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0p2YjJ3cElpd2diV1YwYUc5a0lDSmpZV3hzVkhKNVVISnZZbVVvZFdsdWREWTBMR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ2tvZFdsdWREWTBMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1OaGJHeFFjbTlpWlVOdmMzUW9kV2x1ZERZMExHSnZiMndzZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTmhiR3hRY205aVpVRjFkR2dvZFdsdWREWTBMR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0pqWVd4c1VISnZZbVZCYzFObGJHWW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHSnZiMndwSWl3Z2JXVjBhRzlrSUNKallXeHNWSEo1VUhKdlltVkJjMU5sYkdZb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKdmIyd3BJaXdnYldWMGFHOWtJQ0p3Y205NGVWQnliMkpsS0hWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpY0hKdmVIbFFjbTlpWlV0bFpYQW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpY0hKcGJtTnBjR0ZzS0hWcGJuUTJOQ2tvZFdsdWREWTBMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1OaGJHeFNaV3hoZVNoMWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tvZFdsdWREWTBMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1OaGJHeFNaV1Z1ZEdWeUtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKallXeHNUM2R1Y3loMWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0pqWVd4c1EzUjRUM2R1Y3loMWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zWW05dmJDa29LR0ZrWkhKbGMzTXNkV2x1ZERZMExHRmtaSEpsYzNNcExHSnZiMndzWVdSa2NtVnpjeWtpTENCdFpYUm9iMlFnSW1OaGJHeFVhWEJYWVd4c1pYUW9kV2x1ZERZMExHSnZiMndzZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHOXVaU2gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTmhiR3hRY205aVpTQmpZV3hzVUhKdlltVlhhVzVrYjNjZ1kyRnNiRlJ5ZVZCeWIySmxJR05oYkd4UWNtOWlaVU52YzNRZ1kyRnNiRkJ5YjJKbFFYVjBhQ0JqWVd4c1VISnZZbVZCYzFObGJHWWdZMkZzYkZSeWVWQnliMkpsUVhOVFpXeG1JSEJ5YjNoNVVISnZZbVVnY0hKdmVIbFFjbTlpWlV0bFpYQWdjSEpwYm1OcGNHRnNJR05oYkd4U1pXeGhlU0JqWVd4c1VtVmxiblJsY2lCallXeHNUM2R1Y3lCallXeHNRM1I0VDNkdWN5QmpZV3hzVkdsd1YyRnNiR1YwSUdSdmJtVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXlNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVaWE4wVUhKcGJtTnBjR0ZzVUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNalF3WkRKbU5qY2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9tbHpSMlZ1ZFdsdVpWZGhiR3hsZENoM1lXeHNaWFE2SUhWcGJuUTJOQ3dnZDJGc2JHVjBSbUZqZEc5eWVUb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbWx6UjJWdWRXbHVaVmRoYkd4bGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UQXhDaUFnSUNBdkx5QmxlSEJ2Y25RZ1puVnVZM1JwYjI0Z2FYTkhaVzUxYVc1bFYyRnNiR1YwS0hkaGJHeGxkRG9nZFdsdWREWTBMQ0IzWVd4c1pYUkdZV04wYjNKNU9pQjFhVzUwTmpRcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVEF5Q2lBZ0lDQXZMeUJwWmlBb2QyRnNiR1YwSUQwOVBTQXdJSHg4SUhkaGJHeGxkRVpoWTNSdmNua2dQVDA5SURBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5vZ2FYTkhaVzUxYVc1bFYyRnNiR1YwWDJsbVgySnZaSGxBTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlibm9nYVhOSFpXNTFhVzVsVjJGc2JHVjBYMkZtZEdWeVgybG1YMlZzYzJWQU13b0thWE5IWlc1MWFXNWxWMkZzYkdWMFgybG1YMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z1ptRnNjMlVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21selIyVnVkV2x1WlZkaGJHeGxkRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXdOUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyTnlaV0YwYjNJc0lHVjRhWE4wYzEwZ1BTQnZjQzVCY0hCUVlYSmhiWE11WVhCd1EzSmxZWFJ2Y2loM1lXeHNaWFFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFTnlaV0YwYjNJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94TURZS0lDQWdJQzh2SUhKbGRIVnliaUJsZUdsemRITWdKaVlnWTNKbFlYUnZjaUE5UFQwZ1lYQndRV1JrY21WemMwOW1LSGRoYkd4bGRFWmhZM1J2Y25rcENpQWdJQ0JpZWlCcGMwZGxiblZwYm1WWFlXeHNaWFJmWW05dmJGOW1ZV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pjMENpQWdJQ0F2THlCeVpYUjFjbTRnUVdOamIzVnVkQ2h2Y0M1emFHRTFNVEpmTWpVMktFSjVkR1Z6S0NkaGNIQkpSQ2NwTG1OdmJtTmhkQ2h2Y0M1cGRHOWlLR0Z3Y0Vsa0tTa3BLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRndjRWxFSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6YUdFMU1USmZNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakV3TmdvZ0lDQWdMeThnY21WMGRYSnVJR1Y0YVhOMGN5QW1KaUJqY21WaGRHOXlJRDA5UFNCaGNIQkJaR1J5WlhOelQyWW9kMkZzYkdWMFJtRmpkRzl5ZVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQTlQUW9nSUNBZ1lub2dhWE5IWlc1MWFXNWxWMkZzYkdWMFgySnZiMnhmWm1Gc2MyVkFOZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtDbWx6UjJWdWRXbHVaVmRoYkd4bGRGOWliMjlzWDIxbGNtZGxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakV3TmdvZ0lDQWdMeThnY21WMGRYSnVJR1Y0YVhOMGN5QW1KaUJqY21WaGRHOXlJRDA5UFNCaGNIQkJaR1J5WlhOelQyWW9kMkZzYkdWMFJtRmpkRzl5ZVNrS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0thWE5IWlc1MWFXNWxWMkZzYkdWMFgySnZiMnhmWm1Gc2MyVkFOam9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHbHpSMlZ1ZFdsdVpWZGhiR3hsZEY5aWIyOXNYMjFsY21kbFFEY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pwblpYUkRiMjUwY205c2JHVmtVM0JsYm1ScGJtZEJZMk52ZFc1MEtIZGhiR3hsZERvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1oyVjBRMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5RV05qYjNWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5URXdDaUFnSUNBdkx5QmxlSEJ2Y25RZ1puVnVZM1JwYjI0Z1oyVjBRMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5RV05qYjNWdWRDaDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVLVG9nUVdOamIzVnVkQ0I3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EazNMVFV3TUFvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBPVGtLSUNBZ0lDOHZJRUo1ZEdWektFRmljM1J5WVdOMFFXTmpiM1Z1ZEVkc2IySmhiRk4wWVhSbFMyVjVjMU53Wlc1a2FXNW5RV1JrY21WemN5a0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luTndaVzVrYVc1blgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRNU55MDFNREFLSUNBZ0lDOHZJR052Ym5OMElGdHpjR1Z1WkdsdVowRmtaSEpsYzNOQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWdLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0JDZVhSbGN5aEJZbk4wY21GamRFRmpZMjkxYm5SSGJHOWlZV3hUZEdGMFpVdGxlWE5UY0dWdVpHbHVaMEZrWkhKbGMzTXBDaUFnSUNBdkx5QXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOVEV5Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2MyVnVaR1Z5TG1GMWRHaEJaR1J5WlhOeklEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2daWEp5VUd4MVoybHVUbTkwUVhWMGFFRmtaSElwQ2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUYxZEdoQlpHUnlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR2RsZEVOdmJuUnliMnhzWldSVGNHVnVaR2x1WjBGalkyOTFiblJmWVdaMFpYSmZZWE56WlhKMFFESUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrVlNVanBsY25KT1lYUm9JZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazVoZEdnS0NtZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUmZZV1owWlhKZllYTnpaWEowUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pVeE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJtUmxjZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZjbVZyWlhsQ1lXTnJTV1pPWldObGMzTmhjbmtvY21WclpYbENZV05yT2lCMWFXNTBOalFzSUhkaGJHeGxkRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3B5Wld0bGVVSmhZMnRKWms1bFkyVnpjMkZ5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TlRVd0NpQWdJQ0F2THlCbGVIQnZjblFnWm5WdVkzUnBiMjRnY21WclpYbENZV05yU1daT1pXTmxjM05oY25rb2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxDQjNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TlRVeENpQWdJQ0F2THlCcFppQW9jbVZyWlhsQ1lXTnJLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjZJSEpsYTJWNVFtRmphMGxtVG1WalpYTnpZWEo1WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBPVGN0TlRBd0NpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalE1T1FvZ0lDQWdMeThnUW5sMFpYTW9RV0p6ZEhKaFkzUkJZMk52ZFc1MFIyeHZZbUZzVTNSaGRHVkxaWGx6VTNCbGJtUnBibWRCWkdSeVpYTnpLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljM0JsYm1ScGJtZGZZV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EazNMVFV3TUFvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TlRVekxUVTJNQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJ6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8xTlRnS0lDQWdJQzh2SUhKbGEyVjVWRzg2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJ5Wld0bGVVRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WclpYbFVid29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzFOVGNLSUNBZ0lDOHZJR0Z0YjNWdWREb2dNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8xTlRNdE5UVTVDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5UVXpMVFUyTUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbkpsYTJWNVFtRmphMGxtVG1WalpYTnpZWEo1WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPbkpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzNklIVnBiblEyTkN3Z2QyRnNiR1YwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dweVpXdGxlVUZrWkhKbGMzTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qVTJOQW9nSUNBZ0x5OGdaWGh3YjNKMElHWjFibU4wYVc5dUlISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0cE9pQkJZMk52ZFc1MElIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8xTmpVS0lDQWdJQzh2SUdsbUlDZ2hjbVZyWlhsQ1lXTnJLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnVlaUJ5Wld0bGVVRmtaSEpsYzNOZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalUyTmdvZ0lDQWdMeThnY21WMGRYSnVJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0J5WlhSemRXSUtDbkpsYTJWNVFXUmtjbVZ6YzE5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalUyT1FvZ0lDQWdMeThnY21WMGRYSnVJSGRoYkd4bGRDNWhaR1J5WlhOekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmxjM1JRY21sdVkybHdZV3hRYkhWbmFXNHVZM0psWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUIwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsSUQwZ1FYQndiR2xqWVhScGIyNG9ZV3RwZEdGRVFVOHBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWlhOMFVISnBibU5wY0dGc1VHeDFaMmx1TG1OaGJHeFFjbTlpWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhiR3hRY205aVpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJR05oYkd4UWNtOWlaU2gzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TENCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0lIQnliMkpsT2lCQmNIQnNhV05oZEdsdmJpd2dhR2x1ZERvZ2RXbHVkRFkwS1RvZ1VISnBibU5wY0dGc0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa0tJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdkbGRFTnZiblJ5YjJ4c1pXUlRjR1Z1WkdsdVowRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQXRORFVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhZbWxEWVd4c1BIUjVjR1Z2WmlCTmIyTnJVSEpwYm1OcGNHRnNVSEp2WW1VdWNISnZkRzkwZVhCbExuQnliMkpsUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCd2NtOWlaU3dLSUNBZ0lDOHZJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJhR2x1ZEYwc0NpQWdJQ0F2THlBZ0lISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlISmxhMlY1UVdSa2NtVnpjd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV3RsZVZSdkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd0xUUTFDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnVFc5amExQnlhVzVqYVhCaGJGQnliMkpsTG5CeWIzUnZkSGx3WlM1d2NtOWlaVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0hKdlltVXNDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyaHBiblJkTEFvZ0lDQWdMeThnSUNCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR0o1ZEdWalh6TWdMeThnYldWMGFHOWtJQ0p3Y205aVpTaDFhVzUwTmpRcEtIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0p2YjJ3cElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwYm5Salh6TWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpJRFFnTHk4Z01UTTNDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwUWNtbHVZMmx3WVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHTmhiR3hRY205aVpTaDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0J5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzSUhCeWIySmxPaUJCY0hCc2FXTmhkR2x2Yml3Z2FHbHVkRG9nZFdsdWREWTBLVG9nVUhKcGJtTnBjR0ZzSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVpYTjBVSEpwYm1OcGNHRnNVR3gxWjJsdUxtTmhiR3hRY205aVpWZHBibVJ2ZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhiR3hRY205aVpWZHBibVJ2ZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHTmhiR3hRY205aVpWZHBibVJ2ZHloM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNJSEJ5YjJKbE9pQkJjSEJzYVdOaGRHbHZiaWs2SUZCeWFXNWphWEJoYkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0JuWlhSRGIyNTBjbTlzYkdWa1UzQmxibVJwYm1kQlkyTnZkVzUwS0hkaGJHeGxkQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFV0TmpBS0lDQWdJQzh2SUhKbGRIVnliaUJoWW1sRFlXeHNQSFI1Y0dWdlppQk5iMk5yVUhKcGJtTnBjR0ZzVUhKdlltVXVjSEp2ZEc5MGVYQmxMbkJ5YjJKbFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQndjbTlpWlN3S0lDQWdJQzh2SUNBZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiZDJsdVpHOTNTR2x1ZENoM1lXeHNaWFFwWFN3S0lDQWdJQzh2SUNBZ2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ2NtVnJaWGxCWkdSeVpYTnpDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxhMlY1Vkc4S0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVdE5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCaFltbERZV3hzUEhSNWNHVnZaaUJOYjJOclVISnBibU5wY0dGc1VISnZZbVV1Y0hKdmRHOTBlWEJsTG5CeWIySmxQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ3Y205aVpTd0tJQ0FnSUM4dklDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmQybHVaRzkzU0dsdWRDaDNZV3hzWlhRcFhTd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCaWVYUmxZMTh6SUM4dklHMWxkR2h2WkNBaWNISnZZbVVvZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWIyOXNLU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FXNTBZMTh6SUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWXlBMElDOHZJREV6TndvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzZVSEpwYm1OcGNHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJqWVd4c1VISnZZbVZYYVc1a2IzY29kMkZzYkdWME9pQkJjSEJzYVdOaGRHbHZiaXdnY21WclpYbENZV05yT2lCaWIyOXNaV0Z1TENCd2NtOWlaVG9nUVhCd2JHbGpZWFJwYjI0cE9pQlFjbWx1WTJsd1lXd2dld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFJsYzNSUWNtbHVZMmx3WVd4UWJIVm5hVzR1WTJGc2JGUnllVkJ5YjJKbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMkZzYkZSeWVWQnliMkpsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z1kyRnNiRlJ5ZVZCeWIySmxLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3Z2NISnZZbVU2SUVGd2NHeHBZMkYwYVc5dUxDQm9hVzUwT2lCMWFXNTBOalFwT2lCUWNtbHVZMmx3WVd3Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2lBOUlHZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUW9kMkZzYkdWMEtRb2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFEyOXVkSEp2Ykd4bFpGTndaVzVrYVc1blFXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5pMDNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRmlhVU5oYkd3OGRIbHdaVzltSUUxdlkydFFjbWx1WTJsd1lXeFFjbTlpWlM1d2NtOTBiM1I1Y0dVdWRISjVVSEp2WW1VK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIQnliMkpsTEFvZ0lDQWdMeThnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRvYVc1MFhTd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwTEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdjbVZyWlhsQlpHUnlaWE56Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsYTJWNVZHOEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWXROekVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhZbWxEWVd4c1BIUjVjR1Z2WmlCTmIyTnJVSEpwYm1OcGNHRnNVSEp2WW1VdWNISnZkRzkwZVhCbExuUnllVkJ5YjJKbFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQndjbTlpWlN3S0lDQWdJQzh2SUNBZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiYUdsdWRGMHNDaUFnSUNBdkx5QWdJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ1lubDBaV01nTmlBdkx5QnRaWFJvYjJRZ0luUnllVkJ5YjJKbEtIVnBiblEyTkNrb2RXbHVkRFkwTEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbTl2YkNraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk15QXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTWdOQ0F2THlBeE16Y0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02T2xCeWFXNWphWEJoYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z1kyRnNiRlJ5ZVZCeWIySmxLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3Z2NISnZZbVU2SUVGd2NHeHBZMkYwYVc5dUxDQm9hVzUwT2lCMWFXNTBOalFwT2lCUWNtbHVZMmx3WVd3Z2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmxjM1JRY21sdVkybHdZV3hRYkhWbmFXNHVZMkZzYkZCeWIySmxRMjl6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhiR3hRY205aVpVTnZjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCallXeHNVSEp2WW1WRGIzTjBLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3Z2NISnZZbVU2SUVGd2NHeHBZMkYwYVc5dUxDQm9hVzUwT2lCMWFXNTBOalFwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklHTnZibk4wSUhObGJtUmxjaUE5SUdkbGRFTnZiblJ5YjJ4c1pXUlRjR1Z1WkdsdVowRmpZMjkxYm5Rb2QyRnNiR1YwS1FvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdaMlYwUTI5dWRISnZiR3hsWkZOd1pXNWthVzVuUVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTnkwNE1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRTF2WTJ0UWNtbHVZMmx3WVd4UWNtOWlaUzV3Y205MGIzUjVjR1V1Y0hKdlltVkRiM04wUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCd2NtOWlaU3dLSUNBZ0lDOHZJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJhR2x1ZEYwc0NpQWdJQ0F2THlBZ0lISmxhMlY1Vkc4NklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z2NtVnJaWGxVYnpvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLU3dLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlISmxhMlY1UVdSa2NtVnpjd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV3RsZVZSdkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0xUZ3lDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnVFc5amExQnlhVzVqYVhCaGJGQnliMkpsTG5CeWIzUnZkSGx3WlM1d2NtOWlaVU52YzNRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIQnliMkpsTEFvZ0lDQWdMeThnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRvYVc1MFhTd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1N3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxNemszWVRoa09DQXZMeUJ0WlhSb2IyUWdJbkJ5YjJKbFEyOXpkQ2gxYVc1ME5qUXBkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwYm5Salh6TWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJqWVd4c1VISnZZbVZEYjNOMEtIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdnY0hKdlltVTZJRUZ3Y0d4cFkyRjBhVzl1TENCb2FXNTBPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFJsYzNSUWNtbHVZMmx3WVd4UWJIVm5hVzR1WTJGc2JGQnliMkpsUVhWMGFGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oYkd4UWNtOWlaVUYxZEdnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QmpZV3hzVUhKdlltVkJkWFJvS0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd2djSEp2WW1VNklFRndjR3hwWTJGMGFXOXVMQ0JvYVc1ME9pQjFhVzUwTmpRcE9pQkJZMk52ZFc1MElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa0tJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdkbGRFTnZiblJ5YjJ4c1pXUlRjR1Z1WkdsdVowRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EZ3RPVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhZbWxEWVd4c1BIUjVjR1Z2WmlCTmIyTnJVSEpwYm1OcGNHRnNVSEp2WW1VdWNISnZkRzkwZVhCbExuQnliMkpsUVhWMGFENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djSEp2WW1Vc0NpQWdJQ0F2THlBZ0lITmxibVJsY2l3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJocGJuUmRMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVWUnZPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcExBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJSEpsYTJWNVZHODZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrc0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTJGc2JITjFZaUJ5Wld0bGVVRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WclpYbFVid29nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPQzA1TXdvZ0lDQWdMeThnY21WMGRYSnVJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFMXZZMnRRY21sdVkybHdZV3hRY205aVpTNXdjbTkwYjNSNWNHVXVjSEp2WW1WQmRYUm9QaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ3Y205aVpTd0tJQ0FnSUM4dklDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmFHbHVkRjBzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVWRzg2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa3NDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJZMlkyTTNZemNnTHk4Z2JXVjBhRzlrSUNKd2NtOWlaVUYxZEdnb2RXbHVkRFkwS1dGa1pISmxjM01pQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTXlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklHTmhiR3hRY205aVpVRjFkR2dvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxDQndjbTlpWlRvZ1FYQndiR2xqWVhScGIyNHNJR2hwYm5RNklIVnBiblEyTkNrNklFRmpZMjkxYm5RZ2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmxjM1JRY21sdVkybHdZV3hRYkhWbmFXNHVZMkZzYkZCeWIySmxRWE5UWld4bVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMkZzYkZCeWIySmxRWE5UWld4bU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdZMkZzYkZCeWIySmxRWE5UWld4bUtIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNJSEJ5YjJKbE9pQkJjSEJzYVdOaGRHbHZiaXdnYUdsdWREb2dkV2x1ZERZMEtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RndE1UQXhDaUFnSUNBdkx5QmpiMjV6ZENCeVpYTjFiSFFnUFNCaFltbERZV3hzUEhSNWNHVnZaaUJOYjJOclVISnBibU5wY0dGc1VISnZZbVV1Y0hKdmRHOTBlWEJsTG5CeWIySmxQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ3Y205aVpTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyaHBiblJkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNeUF2THlCdFpYUm9iMlFnSW5CeWIySmxLSFZwYm5RMk5Da29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zWW05dmJDa2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsdWRHTmZNeUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR01nTkNBdkx5QXhNemNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9sQnlhVzVqYVhCaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJSEpsYTJWNVFtRmphMGxtVG1WalpYTnpZWEo1S0hSeWRXVXNJSGRoYkd4bGRDa0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnJaWGxDWVdOclNXWk9aV05sYzNOaGNua0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJR05oYkd4UWNtOWlaVUZ6VTJWc1ppaDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0J3Y205aVpUb2dRWEJ3YkdsallYUnBiMjRzSUdocGJuUTZJSFZwYm5RMk5DazZJRkJ5YVc1amFYQmhiQ0I3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkdWemRGQnlhVzVqYVhCaGJGQnNkV2RwYmk1allXeHNWSEo1VUhKdlltVkJjMU5sYkdaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hzVkhKNVVISnZZbVZCYzFObGJHWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TndvZ0lDQWdMeThnWTJGc2JGUnllVkJ5YjJKbFFYTlRaV3htS0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lIQnliMkpsT2lCQmNIQnNhV05oZEdsdmJpd2dhR2x1ZERvZ2RXbHVkRFkwS1RvZ1VISnBibU5wY0dGc0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE0TFRFeE1Rb2dJQ0FnTHk4Z1kyOXVjM1FnY21WemRXeDBJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdUVzlqYTFCeWFXNWphWEJoYkZCeWIySmxMbkJ5YjNSdmRIbHdaUzUwY25sUWNtOWlaVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0hKdlltVXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdG9hVzUwWFN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z2JXVjBhRzlrSUNKMGNubFFjbTlpWlNoMWFXNTBOalFwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHSnZiMndwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5SaklEUWdMeThnTVRNM0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPanBRY21sdVkybHdZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeUNpQWdJQ0F2THlCeVpXdGxlVUpoWTJ0SlprNWxZMlZ6YzJGeWVTaDBjblZsTENCM1lXeHNaWFFwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJSEpsYTJWNVFtRmphMGxtVG1WalpYTnpZWEo1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z1kyRnNiRlJ5ZVZCeWIySmxRWE5UWld4bUtIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNJSEJ5YjJKbE9pQkJjSEJzYVdOaGRHbHZiaXdnYUdsdWREb2dkV2x1ZERZMEtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWlhOMFVISnBibU5wY0dGc1VHeDFaMmx1TG5CeWIzaDVVSEp2WW1WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdjbTk0ZVZCeWIySmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpBS0lDQWdJQzh2SUhCeWIzaDVVSEp2WW1Vb2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd2djbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0J3Y205NGVUb2dRWEJ3YkdsallYUnBiMjRzSUhCeWIySmxPaUJCY0hCc2FXTmhkR2x2Yml3Z2FHbHVkRG9nZFdsdWREWTBLVG9nVUhKcGJtTnBjR0ZzSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa0tJQ0FnSUdScFp5QTBDaUFnSUNCallXeHNjM1ZpSUdkbGRFTnZiblJ5YjJ4c1pXUlRjR1Z1WkdsdVowRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXlDaUFnSUNBdkx5QnBkSGh1UTI5dGNHOXpaUzVpWldkcGJpaHBkSGh1TG5CaGVXMWxiblFvZXlCelpXNWtaWElzSUhKbFkyVnBkbVZ5T2lCelpXNWtaWElzSUdGdGIzVnVkRG9nTUN3Z2NtVnJaWGxVYnpvZ2NISnZlSGt1WVdSa2NtVnpjeUI5S1NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsYTJWNVZHOEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qTXRNVEkyQ2lBZ0lDQXZMeUJwZEhodVEyOXRjRzl6WlM1dVpYaDBQSFI1Y0dWdlppQk5iMk5yVUhKcGJtTnBjR0ZzVUhKdmVIa3VjSEp2ZEc5MGVYQmxMbVp2Y25kaGNtUStLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSEJ5YjNoNUxBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmQyRnNiR1YwTG1sa0xDQndjbTlpWlN3Z2FHbHVkQ3dnZEhKMVpWMHNDaUFnSUNBdkx5QjlLUW9nSUNBZ2FYUjRibDl1WlhoMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ055QXZMeUJ0WlhSb2IyUWdJbVp2Y25kaGNtUW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDa29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zWW05dmJDa2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5Rb2dJQ0FnTHk4Z1lYSm5jem9nVzNkaGJHeGxkQzVwWkN3Z2NISnZZbVVzSUdocGJuUXNJSFJ5ZFdWZExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU15MHhNallLSUNBZ0lDOHZJR2wwZUc1RGIyMXdiM05sTG01bGVIUThkSGx3Wlc5bUlFMXZZMnRRY21sdVkybHdZV3hRY205NGVTNXdjbTkwYjNSNWNHVXVabTl5ZDJGeVpENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djSEp2ZUhrc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0M1lXeHNaWFF1YVdRc0lIQnliMkpsTENCb2FXNTBMQ0IwY25WbFhTd0tJQ0FnSUM4dklIMHBDaUFnSUNCcGJuUmpYek1nTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOd29nSUNBZ0x5OGdhWFI0YmtOdmJYQnZjMlV1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5T0FvZ0lDQWdMeThnWTI5dWMzUWdjbVZ6ZFd4MElEMGdaR1ZqYjJSbFFYSmpORHhRY21sdVkybHdZV3crS0c5d0xrZEpWSGh1TG14aGMzUk1iMmNvTVNrc0lDZHNiMmNuS1FvZ0lDQWdaMmwwZUc0Z01TQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEk1Q2lBZ0lDQXZMeUJ5Wld0bGVVSmhZMnRKWms1bFkyVnpjMkZ5ZVNoeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCeVpXdGxlVUpoWTJ0SlprNWxZMlZ6YzJGeWVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakFLSUNBZ0lDOHZJSEJ5YjNoNVVISnZZbVVvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxDQndjbTk0ZVRvZ1FYQndiR2xqWVhScGIyNHNJSEJ5YjJKbE9pQkJjSEJzYVdOaGRHbHZiaXdnYUdsdWREb2dkV2x1ZERZMEtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWlhOMFVISnBibU5wY0dGc1VHeDFaMmx1TG5CeWIzaDVVSEp2WW1WTFpXVndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0hKdmVIbFFjbTlpWlV0bFpYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnY0hKdmVIbFFjbTlpWlV0bFpYQW9kMkZzYkdWME9pQkJjSEJzYVdOaGRHbHZiaXdnY0hKdmVIazZJRUZ3Y0d4cFkyRjBhVzl1TENCd2NtOWlaVG9nUVhCd2JHbGpZWFJwYjI0c0lHaHBiblE2SUhWcGJuUTJOQ2s2SUZCeWFXNWphWEJoYkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TmdvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdVltVm5hVzRvYVhSNGJpNXdZWGx0Wlc1MEtIc2djMlZ1WkdWeUxDQnlaV05sYVhabGNqb2djMlZ1WkdWeUxDQmhiVzkxYm5RNklEQXNJSEpsYTJWNVZHODZJSEJ5YjNoNUxtRmtaSEpsYzNNZ2ZTa3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ013b2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXdGxlVlJ2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0zTFRFME1Bb2dJQ0FnTHk4Z2FYUjRia052YlhCdmMyVXVibVY0ZER4MGVYQmxiMllnVFc5amExQnlhVzVqYVhCaGJGQnliM2g1TG5CeWIzUnZkSGx3WlM1bWIzSjNZWEprUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCd2NtOTRlU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXM2RoYkd4bGRDNXBaQ3dnY0hKdlltVXNJR2hwYm5Rc0lHWmhiSE5sWFN3S0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUEzSUM4dklHMWxkR2h2WkNBaVptOXlkMkZ5WkNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzS1NoMWFXNTBOalFzWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGliMjlzS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE01Q2lBZ0lDQXZMeUJoY21kek9pQmJkMkZzYkdWMExtbGtMQ0J3Y205aVpTd2dhR2x1ZEN3Z1ptRnNjMlZkTEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjdE1UUXdDaUFnSUNBdkx5QnBkSGh1UTI5dGNHOXpaUzV1WlhoMFBIUjVjR1Z2WmlCTmIyTnJVSEpwYm1OcGNHRnNVSEp2ZUhrdWNISnZkRzkwZVhCbExtWnZjbmRoY21RK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIQnliM2g1TEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiZDJGc2JHVjBMbWxrTENCd2NtOWlaU3dnYUdsdWRDd2dabUZzYzJWZExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdsdWRHTmZNeUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5QnBkSGh1UTI5dGNHOXpaUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdaR1ZqYjJSbFFYSmpORHhRY21sdVkybHdZV3crS0c5d0xrZEpWSGh1TG14aGMzUk1iMmNvTVNrc0lDZHNiMmNuS1FvZ0lDQWdaMmwwZUc0Z01TQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0wQ2lBZ0lDQXZMeUJ3Y205NGVWQnliMkpsUzJWbGNDaDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0J3Y205NGVUb2dRWEJ3YkdsallYUnBiMjRzSUhCeWIySmxPaUJCY0hCc2FXTmhkR2x2Yml3Z2FHbHVkRG9nZFdsdWREWTBLVG9nVUhKcGJtTnBjR0ZzSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVpYTjBVSEpwYm1OcGNHRnNVR3gxWjJsdUxuQnlhVzVqYVhCaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YVc1amFYQmhiRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEyQ2lBZ0lDQXZMeUJ3Y21sdVkybHdZV3dvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2YmlrNklGQnlhVzVqYVhCaGJDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRM0NpQWdJQ0F2THlCeVpYUjFjbTRnY0d4MVoybHVVSEpwYm1OcGNHRnNUMllvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z2QyRnNiR1YwS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTndvZ0lDQWdMeThnY21WMGRYSnVJSEJzZFdkcGJsQnlhVzVqYVhCaGJFOW1LSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUhkaGJHeGxkQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXdOZ29nSUNBZ0x5OGdZMjl1YzNRZ1cyRndjRXhwYzNSQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoYTJsMFlVUkJUeXdnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVUZ3Y0V4cGMzUXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prM013b2dJQ0FnTHk4Z2NtVjBkWEp1SUhCc2RXZHBibEJ5YVc1amFYQmhiQ2gzWVd4c1pYUXNJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VkMkZzYkdWMEtRb2dJQ0FnY0hWemFHbHVkQ0E0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pvek1qWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hwYzBkbGJuVnBibVZYWVd4c1pYUW9kMkZzYkdWMExtbGtMQ0IzWVd4c1pYUkdZV04wYjNKNUtTd2daWEp5U0dsdWRFNXZkRmRoYkd4bGRDa0tJQ0FnSUdOaGJHeHpkV0lnYVhOSFpXNTFhVzVsVjJGc2JHVjBDaUFnSUNCaWJub2djSEpwYm1OcGNHRnNYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKRlVsSTZaWEp5U0c1M2JDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSklibmRzQ2dwd2NtbHVZMmx3WVd4ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPak15TndvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5MQ0J6Y0dWdVpHbHVaMFY0YVhOMGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5aDNZV3hzWlhRc0lFSjVkR1Z6S0ZCU1NVNURTVkJCVEY5TFJWbGZVMUJGVGtSSlRrY3BLUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnpjR1Z1WkdsdVoxOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TXpJNENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9jM0JsYm1ScGJtZEZlR2x6ZEhNZ0ppWWdjM0JsYm1ScGJtY3ViR1Z1WjNSb0lEMDlQU0F6TWl3Z1pYSnlTR2x1ZEU1dmRFSnZkVzVrS1FvZ0lDQWdZbm9nY0hKcGJtTnBjR0ZzWDJKdmIyeGZabUZzYzJWQU5nb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSEJ5YVc1amFYQmhiRjlpYjI5c1gyWmhiSE5sUURZS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwd2NtbHVZMmx3WVd4ZlltOXZiRjl0WlhKblpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3pNamdLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoemNHVnVaR2x1WjBWNGFYTjBjeUFtSmlCemNHVnVaR2x1Wnk1c1pXNW5kR2dnUFQwOUlETXlMQ0JsY25KSWFXNTBUbTkwUW05MWJtUXBDaUFnSUNCaWJub2djSEpwYm1OcGNHRnNYMkZtZEdWeVgyRnpjMlZ5ZEVBNUNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKRlVsSTZaWEp5U0c1aVpDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSklibUprQ2dwd2NtbHVZMmx3WVd4ZllXWjBaWEpmWVhOelpYSjBRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPamcxQ2lBZ0lDQXZMeUJqYjI1emRDQmJZWFYwYUYwZ1BTQnZjQzVCWTJOMFVHRnlZVzF6TG1GalkzUkJkWFJvUVdSa2NpaGhZMk52ZFc1MEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFYVjBhRUZrWkhJS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem96TXpBS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaGhkWFJvUVdSa2NrOW1LSE53Wlc1a1pYSXBJRDA5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnWlhKeVNHbHVkRkJzZFdkcGJrNXZkRUYxZEdncENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCd2NtbHVZMmx3WVd4ZllXWjBaWEpmWVhOelpYSjBRREV4Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pGVWxJNlpYSnlUbUYwYUNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KT1lYUm9DZ3B3Y21sdVkybHdZV3hmWVdaMFpYSmZZWE56WlhKMFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3pNelVLSUNBZ0lDOHZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVwWkN3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3pNellLSUNBZ0lDOHZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdKMWNua2dOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hORGdLSUNBZ0lDOHZJR2xtSUNob2FXNTBJRDA5UFNBd0tTQjdDaUFnSUNCa2RYQUtJQ0FnSUdKdWVpQndjbWx1WTJsd1lXeGZZV1owWlhKZmFXWmZaV3h6WlVBeE13b2dJQ0FnY0c5d2JpQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qa3pDaUFnSUNBdkx5QnZjbWxuYVc0NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem81TlFvZ0lDQWdMeThnY21WbVpYSnlaWEk2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem81TVFvZ0lDQWdMeThnZDJGc2JHVjBPaUF3TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPVEF0T1RjS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nTUN3S0lDQWdJQzh2SUNBZ2NISnBibU5wY0dGc09pQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHOXlhV2RwYmpvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnpjR1Z1WkdWeU9pQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lISmxabVZ5Y21WeU9pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSFpwWVZCc2RXZHBiam9nWm1Gc2MyVXNDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdZMjl1WTJGMENncHdjbWx1WTJsd1lXeGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pweVpYTnZiSFpsVUhKcGJtTnBjR0ZzUTNSNFFEUXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRZS0lDQWdJQzh2SUhCeWFXNWphWEJoYkNoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUtUb2dVSEpwYm1OcGNHRnNJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25CeWFXNWphWEJoYkY5aFpuUmxjbDlwWmw5bGJITmxRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94TlRJS0lDQWdJQzh2SUdsbUlDZ2hhWE5IWlc1MWFXNWxWMkZzYkdWMEtHaHBiblFzSUhkaGJHeGxkRVpoWTNSdmNua3BLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJwYzBkbGJuVnBibVZYWVd4c1pYUUtJQ0FnSUdKdWVpQndjbWx1WTJsd1lXeGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE5UUUtJQ0FnSUM4dklHeHZaMmRsWkVWeWNpaGxjbkpJYVc1MFRtOTBWMkZzYkdWMEtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVJWSlNPbVZ5Y2todWQyd2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTRzUzYkFvS2NISnBibU5wY0dGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFMU9Rb2dJQ0FnTHk4Z2FXWWdLR05oYkd4bGNrRndjQ0E5UFQwZ01Da2dld29nSUNBZ1pHbG5JREVLSUNBZ0lHSnVlaUJ3Y21sdVkybHdZV3hmWVdaMFpYSmZhV1pmWld4elpVQXhOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hOakVLSUNBZ0lDOHZJR3h2WjJkbFpFVnljaWhsY25KSWFXNTBWRzl3VEdWMlpXd3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KSWRHOXdJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2gwYjNBS0NuQnlhVzVqYVhCaGJGOWhablJsY2w5cFpsOWxiSE5sUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE5qWUtJQ0FnSUM4dklHeGxkQ0IyYVdGUWJIVm5hVzRnUFNCbVlXeHpaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVFkzQ2lBZ0lDQXZMeUJwWmlBb1kyRnNiR1Z5UVhCd0lDRTlQU0JvYVc1MEtTQjdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0lUMEtJQ0FnSUdKNklIQnlhVzVqYVhCaGJGOWhablJsY2w5cFpsOWxiSE5sUURJMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hOekVLSUNBZ0lDOHZJR052Ym5OMElGdHpjR1Z1WkdsdVp5d2djM0JsYm1ScGJtZEZlR2x6ZEhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb2FHbHVkQ3dnUW5sMFpYTW9VRkpKVGtOSlVFRk1YMHRGV1Y5VFVFVk9SRWxPUnlrcENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5Od1pXNWthVzVuWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTNNZ29nSUNBZ0x5OGdhV1lnS0NFb2MzQmxibVJwYm1kRmVHbHpkSE1nSmlZZ2MzQmxibVJwYm1jdWJHVnVaM1JvSUQwOVBTQXpNaUFtSmlCemNHVnVaR2x1WnlBOVBUMGdjMlZ1WkdWeUxtSjVkR1Z6SUNZbUlITmxibVJsY2lBaFBUMGdZMkZzYkdWeVFXUmtjaWtwSUhzS0lDQWdJR0o2SUhCeWFXNWphWEJoYkY5cFpsOWliMlI1UURJeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lub2djSEpwYm1OcGNHRnNYMmxtWDJKdlpIbEFNaklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSEJ5YVc1amFYQmhiRjlwWmw5aWIyUjVRREl5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURRS0lDQWdJQ0U5Q2lBZ0lDQmlibm9nY0hKcGJtTnBjR0ZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNak1LQ25CeWFXNWphWEJoYkY5cFpsOWliMlI1UURJeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE56UUtJQ0FnSUM4dklHeHZaMmRsWkVWeWNpaGxjbkpJYVc1MFRtOTBRbTkxYm1RcENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKRlVsSTZaWEp5U0c1aVpDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSklibUprQ2dwd2NtbHVZMmx3WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF5TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRjNENpQWdJQ0F2THlCMmFXRlFiSFZuYVc0Z1BTQjBjblZsQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1kyOTJaWElnTWdvS2NISnBibU5wY0dGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFNE1Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzJOdmJuUnliMnhzWldSQ2VYUmxjeXdnWTI5dWRISnZiR3hsWkVWNGFYTjBjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhvYVc1MExDQkNlWFJsY3loUVVrbE9RMGxRUVV4ZlMwVlpYME5QVGxSU1QweE1SVVFwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbU52Ym5SeWIyeHNaV1JmWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFNE1nb2dJQ0FnTHk4Z2FXWWdLQ0VvWTI5dWRISnZiR3hsWkVWNGFYTjBjeUFtSmlCamIyNTBjbTlzYkdWa1FubDBaWE11YkdWdVozUm9JRDA5UFNBek1pa3BJSHNLSUNBZ0lHSjZJSEJ5YVc1amFYQmhiRjlwWmw5aWIyUjVRREkyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCd2NtbHVZMmx3WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF5TndvS2NISnBibU5wY0dGc1gybG1YMkp2WkhsQU1qWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTROQW9nSUNBZ0x5OGdiRzluWjJWa1JYSnlLR1Z5Y2tocGJuUkNZV1JYWVd4c1pYUXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KSmQyeDBJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2wzYkhRS0NuQnlhVzVqYVhCaGJGOWhablJsY2w5cFpsOWxiSE5sUURJM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE1Ua0tJQ0FnSUM4dklHbG1JQ2hqYjI1MGNtOXNiR1ZrSUQwOVBTQnpjR1Z1WkdWeUtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NISnBibU5wY0dGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWprS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRJd0NpQWdJQ0F2THlCeVpYUjFjbTRnZEhKMVpRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR052ZG1WeUlESUtDbkJ5YVc1amFYQmhiRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9uZGhiR3hsZEVOdmJuUnliMnh6VEdsMlpVQXpORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVGt4Q2lBZ0lDQXZMeUJqYjI1emRDQmJjbVZtWlhKeVpYSkNlWFJsY3l3Z2NtVm1aWEp5WlhKRmVHbHpkSE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vYUdsdWRDd2dRbmwwWlhNb1VGSkpUa05KVUVGTVgwdEZXVjlTUlVaRlVsSkZVaWtwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p5WldabGNuSmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFNU1nb2dJQ0FnTHk4Z1kyOXVjM1FnY21WbVpYSnlaWElnUFNCeVpXWmxjbkpsY2tWNGFYTjBjeUFtSmlCeVpXWmxjbkpsY2tKNWRHVnpMbXhsYm1kMGFDQTlQVDBnTXpJZ1B5QkJZMk52ZFc1MEtISmxabVZ5Y21WeVFubDBaWE1wSURvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekNpQWdJQ0JpZWlCd2NtbHVZMmx3WVd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JpZWlCd2NtbHVZMmx3WVd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TndvZ0lDQWdZMjkyWlhJZ05Bb0tjSEpwYm1OcGNHRnNYM1JsY201aGNubGZiV1Z5WjJWQU16ZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTVOZ29nSUNBZ0x5OGdjSEpwYm1OcGNHRnNPaUJzYVhabElEOGdZMjl1ZEhKdmJHeGxaQ0E2SUhObGJtUmxjaXdLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE9UY0tJQ0FnSUM4dklHOXlhV2RwYmpvZ2JHbDJaU0EvSUdOdmJuUnliMnhzWldRZ09pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNCaWVpQndjbWx1WTJsd1lXeGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME1Bb0tjSEpwYm1OcGNHRnNYM1JsY201aGNubGZiV1Z5WjJWQU5ERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTVOQzB5TURFS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nYUdsdWRDd0tJQ0FnSUM4dklDQWdjSEpwYm1OcGNHRnNPaUJzYVhabElEOGdZMjl1ZEhKdmJHeGxaQ0E2SUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnYjNKcFoybHVPaUJzYVhabElEOGdZMjl1ZEhKdmJHeGxaQ0E2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2MzQmxibVJsY2pvZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCeVpXWmxjbkpsY2l3S0lDQWdJQzh2SUNBZ2RtbGhVR3gxWjJsdUxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNek14TFRNek9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbGMyOXNkbVZRY21sdVkybHdZV3hEZEhnb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEVaaFkzUnZjbmtzQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkQzVwWkN3S0lDQWdJQzh2SUNBZ2MzQmxibVJsY2l3S0lDQWdJQzh2SUNBZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2Ymtsa0xtbGtMQW9nSUNBZ0x5OGdJQ0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdkSEoxWlFvZ0lDQWdMeThnS1FvZ0lDQWdZaUJ3Y21sdVkybHdZV3hmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qcHlaWE52YkhabFVISnBibU5wY0dGc1EzUjRRRFF5Q2dwd2NtbHVZMmx3WVd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTURvS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94T1RjS0lDQWdJQzh2SUc5eWFXZHBiam9nYkdsMlpTQS9JR052Ym5SeWIyeHNaV1FnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHSWdjSEpwYm1OcGNHRnNYM1JsY201aGNubGZiV1Z5WjJWQU5ERUtDbkJ5YVc1amFYQmhiRjkwWlhKdVlYSjVYMlpoYkhObFFETTNPZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTVNZ29nSUNBZ0x5OGdZMjl1YzNRZ2NtVm1aWEp5WlhJZ1BTQnlaV1psY25KbGNrVjRhWE4wY3lBbUppQnlaV1psY25KbGNrSjVkR1Z6TG14bGJtZDBhQ0E5UFQwZ016SWdQeUJCWTJOdmRXNTBLSEpsWm1WeWNtVnlRbmwwWlhNcElEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdJZ2NISnBibU5wY0dGc1gzUmxjbTVoY25sZmJXVnlaMlZBTXpnS0NuQnlhVzVqYVhCaGJGOWhablJsY2w5cFpsOWxiSE5sUURJNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE1qSUtJQ0FnSUM4dklHTnZibk4wSUZ0M1lXeHNaWFJCWkdSeVpYTnpMQ0IzWVd4c1pYUkZlR2x6ZEhOZElEMGdiM0F1UVhCd1VHRnlZVzF6TG1Gd2NFRmtaSEpsYzNNb2QyRnNiR1YwS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVEl6Q2lBZ0lDQXZMeUJwWmlBb0lYZGhiR3hsZEVWNGFYTjBjeWtnZXdvZ0lDQWdZbTU2SUhCeWFXNWphWEJoYkY5aFpuUmxjbDlwWmw5bGJITmxRRE14Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE1qUUtJQ0FnSUM4dklISmxkSFZ5YmlCbVlXeHpaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVGc1Q2lBZ0lDQXZMeUJqYjI1emRDQnNhWFpsSUQwZ2QyRnNiR1YwUTI5dWRISnZiSE5NYVhabEtHaHBiblFzSUdOdmJuUnliMnhzWldRc0lITmxibVJsY2lrS0lDQWdJR0lnY0hKcGJtTnBjR0ZzWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6bzZkMkZzYkdWMFEyOXVkSEp2YkhOTWFYWmxRRE0wQ2dwd2NtbHVZMmx3WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF6TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRJMkNpQWdJQ0F2THlCcFppQW9ZMjl1ZEhKdmJHeGxaQ0E5UFQwZ2QyRnNiR1YwUVdSa2NtVnpjeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQVDBLSUNBZ0lHSjZJSEJ5YVc1amFYQmhiRjloWm5SbGNsOXBabDlsYkhObFFETXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qZzFDaUFnSUNBdkx5QmpiMjV6ZENCYllYVjBhRjBnUFNCdmNDNUJZMk4wVUdGeVlXMXpMbUZqWTNSQmRYUm9RV1JrY2loaFkyTnZkVzUwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFRjFkR2hCWkdSeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRJM0NpQWdJQ0F2THlCeVpYUjFjbTRnWVhWMGFFRmtaSEpQWmloM1lXeHNaWFJCWkdSeVpYTnpLU0E5UFQwZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakU0T1FvZ0lDQWdMeThnWTI5dWMzUWdiR2wyWlNBOUlIZGhiR3hsZEVOdmJuUnliMnh6VEdsMlpTaG9hVzUwTENCamIyNTBjbTlzYkdWa0xDQnpaVzVrWlhJcENpQWdJQ0JpSUhCeWFXNWphWEJoYkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPbmRoYkd4bGRFTnZiblJ5YjJ4elRHbDJaVUF6TkFvS2NISnBibU5wY0dGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pnMUNpQWdJQ0F2THlCamIyNXpkQ0JiWVhWMGFGMGdQU0J2Y0M1QlkyTjBVR0Z5WVcxekxtRmpZM1JCZFhSb1FXUmtjaWhoWTJOdmRXNTBLUW9nSUNBZ1pIVndDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFRjFkR2hCWkdSeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRJNUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhWMGFFRmtaSEpQWmloamIyNTBjbTlzYkdWa0tTQTlQVDBnZDJGc2JHVjBRV1JrY21WemN3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem94T0RrS0lDQWdJQzh2SUdOdmJuTjBJR3hwZG1VZ1BTQjNZV3hzWlhSRGIyNTBjbTlzYzB4cGRtVW9hR2x1ZEN3Z1kyOXVkSEp2Ykd4bFpDd2djMlZ1WkdWeUtRb2dJQ0FnWWlCd2NtbHVZMmx3WVd4ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPanAzWVd4c1pYUkRiMjUwY205c2MweHBkbVZBTXpRS0NuQnlhVzVqYVhCaGJGOWliMjlzWDJaaGJITmxRRFk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQndjbWx1WTJsd1lXeGZZbTl2YkY5dFpYSm5aVUEzQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkdWemRGQnlhVzVqYVhCaGJGQnNkV2RwYmk1allXeHNVbVZzWVhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hzVW1Wc1lYazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTVFvZ0lDQWdMeThnWTJGc2JGSmxiR0Y1S0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd2djSEp2WW1VNklFRndjR3hwWTJGMGFXOXVMQ0J3Y205aVpUSTZJRUZ3Y0d4cFkyRjBhVzl1TENCb2FXNTBPaUIxYVc1ME5qUXBPaUJRY21sdVkybHdZV3dnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQm5aWFJEYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRCWTJOdmRXNTBLSGRoYkd4bGRDa0tJQ0FnSUdScFp5QTBDaUFnSUNCallXeHNjM1ZpSUdkbGRFTnZiblJ5YjJ4c1pXUlRjR1Z1WkdsdVowRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXpMVEUxT0FvZ0lDQWdMeThnY21WMGRYSnVJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFMXZZMnRRY21sdVkybHdZV3hRY205aVpTNXdjbTkwYjNSNWNHVXVjbVZzWVhrK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIQnliMkpsTEFvZ0lDQWdMeThnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR3Y205aVpUSXNJR2hwYm5SZExBb2dJQ0FnTHk4Z0lDQnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTNDaUFnSUNBdkx5QnlaV3RsZVZSdk9pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwTEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR05oYkd4emRXSWdjbVZyWlhsQlpHUnlaWE56Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsYTJWNVZHOEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRNdE1UVTRDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnVFc5amExQnlhVzVqYVhCaGJGQnliMkpsTG5CeWIzUnZkSGx3WlM1eVpXeGhlVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0hKdlltVXNDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czQnliMkpsTWl3Z2FHbHVkRjBzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVWRzg2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa3NDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpVMVl6Y3daV01nTHk4Z2JXVjBhRzlrSUNKeVpXeGhlU2gxYVc1ME5qUXNkV2x1ZERZMEtTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXhpYjI5c0tTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTXlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdNZ05DQXZMeUF4TXpjS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPbEJ5YVc1amFYQmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRFS0lDQWdJQzh2SUdOaGJHeFNaV3hoZVNoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNJSEJ5YjJKbE9pQkJjSEJzYVdOaGRHbHZiaXdnY0hKdlltVXlPaUJCY0hCc2FXTmhkR2x2Yml3Z2FHbHVkRG9nZFdsdWREWTBLVG9nVUhKcGJtTnBjR0ZzSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVpYTjBVSEpwYm1OcGNHRnNVR3gxWjJsdUxtTmhiR3hTWldWdWRHVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGc2JGSmxaVzUwWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOUW9nSUNBZ0x5OGdZMkZzYkZKbFpXNTBaWElvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVmxiblJsY2pvZ1FYQndiR2xqWVhScGIyNHNJR1p2Y21kbFpGZGhiR3hsZERvZ2RXbHVkRFkwTENCd2NtOWlaVG9nUVhCd2JHbGpZWFJwYjI0cE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkyTFRFM05nb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQkpaRG9nY21WbGJuUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQkJjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdJQ0J0WlhSb2IyUlRaV3hsWTNSdmNpZ25jRzlyWlNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSnlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVwWkNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLR1p2Y21kbFpGZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLSEJ5YjJKbExtbGtLU3dLSUNBZ0lDOHZJQ0FnSUNCZExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN4Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVwWkNrc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjeUNpQWdJQ0F2THlCdmNDNXBkRzlpS0dadmNtZGxaRmRoYkd4bGRDa3NDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3pDaUFnSUNBdkx5QnZjQzVwZEc5aUtIQnliMkpsTG1sa0tTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56QUtJQ0FnSUM4dklHMWxkR2h2WkZObGJHVmpkRzl5S0Nkd2IydGxLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUW5LU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREl5WXpaak9HUXlJQzh2SUcxbGRHaHZaQ0FpY0c5clpTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5pMHhOelVLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3U1dRNklISmxaVzUwWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUNBZ2JXVjBhRzlrVTJWc1pXTjBiM0lvSjNCdmEyVW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDY3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2IzQXVhWFJ2WWloSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRdWFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2IzQXVhWFJ2WWlobWIzSm5aV1JYWVd4c1pYUXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2IzQXVhWFJ2WWlod2NtOWlaUzVwWkNrc0NpQWdJQ0F2THlBZ0lDQWdYU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkyTFRFM05nb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQkpaRG9nY21WbGJuUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQkJjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdJQ0J0WlhSb2IyUlRaV3hsWTNSdmNpZ25jRzlyWlNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSnlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVwWkNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLR1p2Y21kbFpGZGhiR3hsZENrc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLSEJ5YjJKbExtbGtLU3dLSUNBZ0lDOHZJQ0FnSUNCZExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTndvZ0lDQWdMeThnY21WclpYbENZV05yU1daT1pXTmxjM05oY25rb2RISjFaU3dnZDJGc2JHVjBLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnY21WclpYbENZV05yU1daT1pXTmxjM05oY25rS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTFDaUFnSUNBdkx5QmpZV3hzVW1WbGJuUmxjaWgzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TENCeVpXVnVkR1Z5T2lCQmNIQnNhV05oZEdsdmJpd2dabTl5WjJWa1YyRnNiR1YwT2lCMWFXNTBOalFzSUhCeWIySmxPaUJCY0hCc2FXTmhkR2x2YmlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSbGMzUlFjbWx1WTJsd1lXeFFiSFZuYVc0dVkyRnNiRTkzYm5OYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hzVDNkdWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd4Q2lBZ0lDQXZMeUJqWVd4c1QzZHVjeWgzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TENCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0lIQnliMkpsT2lCQmNIQnNhV05oZEdsdmJpd2dZV05qYjNWdWREb2dRV05qYjNWdWRDazZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ESXRNVGcxQ2lBZ0lDQXZMeUJqYjI1emRDQnlaWE4xYkhRZ1BTQmhZbWxEWVd4c1BIUjVjR1Z2WmlCTmIyTnJVSEpwYm1OcGNHRnNVSEp2WW1VdWNISnZkRzkwZVhCbExtOTNibk0rS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhCeWIySmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJkMkZzYkdWMExtbGtMQ0JoWTJOdmRXNTBYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNNE16RmlORFkxSUM4dklHMWxkR2h2WkNBaWIzZHVjeWgxYVc1ME5qUXNZV1JrY21WemN5bGliMjlzSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZbTl2YkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EWUtJQ0FnSUM4dklISmxhMlY1UW1GamEwbG1UbVZqWlhOellYSjVLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLUW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJSEpsYTJWNVFtRmphMGxtVG1WalpYTnpZWEo1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE1Rb2dJQ0FnTHk4Z1kyRnNiRTkzYm5Nb2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd2djbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0J3Y205aVpUb2dRWEJ3YkdsallYUnBiMjRzSUdGalkyOTFiblE2SUVGalkyOTFiblFwT2lCaWIyOXNaV0Z1SUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVpYTjBVSEpwYm1OcGNHRnNVR3gxWjJsdUxtTmhiR3hEZEhoUGQyNXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGc2JFTjBlRTkzYm5NNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOQzB5TURFS0lDQWdJQzh2SUdOaGJHeERkSGhQZDI1ektBb2dJQ0FnTHk4Z0lDQjNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVVSmhZMnM2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUhCeWIySmxPaUJCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ2FHbHVkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JoWTJOdmRXNTBPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0JoYkhOdlZHaHBjbVJRWVhKMGVUb2dZbTl2YkdWaGJnb2dJQ0FnTHk4Z0tUb2dRM1I0VDNkdWMxSmxjM1ZzZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURJS0lDQWdJQzh2SUdOdmJuTjBJSE5sYm1SbGNpQTlJR2RsZEVOdmJuUnliMnhzWldSVGNHVnVaR2x1WjBGalkyOTFiblFvZDJGc2JHVjBLUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJR2RsZEVOdmJuUnliMnhzWldSVGNHVnVaR2x1WjBGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBekxUSXdOd29nSUNBZ0x5OGdZMjl1YzNRZ1kzUjRJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdUVzlqYTFCeWFXNWphWEJoYkZCeWIySmxMbkJ5YjNSdmRIbHdaUzV3Y205aVpVTjBlRDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY0hKdlltVXNDaUFnSUNBdkx5QWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyaHBiblJkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtTjJaaFlUTTJPQ0F2THlCdFpYUm9iMlFnSW5CeWIySmxRM1I0S0hWcGJuUTJOQ2tvWVdSa2NtVnpjeXgxYVc1ME5qUXNZV1JrY21WemN5a2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhVzUwWTE4eklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQTFDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEY3lDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwSFlYUmxRM1I0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmNISnBibU5wY0dGc0xYQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd09DMHlNVEVLSUNBZ0lDOHZJR052Ym5OMElHOTNibk1nUFNCaFltbERZV3hzUEhSNWNHVnZaaUJOYjJOclVISnBibU5wY0dGc1VISnZZbVV1Y0hKdmRHOTBlWEJsTG1OMGVFOTNibk0rS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhCeWIySmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJZM1I0TENCaFkyTnZkVzUwWFN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0dKbFpERmxZallnTHk4Z2JXVjBhRzlrSUNKamRIaFBkMjV6S0NoaFpHUnlaWE56TEhWcGJuUTJOQ3hoWkdSeVpYTnpLU3hoWkdSeVpYTnpLV0p2YjJ3aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGJuUmpYek1nTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ltOXZiQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNCeWFXNWphWEJoYkMxd2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRJS0lDQWdJQzh2SUd4bGRDQjBhR2x5WkZCaGNuUjVJRDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFekNpQWdJQ0F2THlCcFppQW9ZV3h6YjFSb2FYSmtVR0Z5ZEhrcElIc0tJQ0FnSUdKNklHTmhiR3hEZEhoUGQyNXpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVFF0TWpFM0NpQWdJQ0F2THlCMGFHbHlaRkJoY25SNUlEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXOWphMUJ5YVc1amFYQmhiRkJ5YjJKbExuQnliM1J2ZEhsd1pTNTBhR2x5WkZCaGNuUjVQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ3Y205aVpTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyRmpZMjkxYm5Rc0lHaHBiblJkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1JwWnlBM0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERXpaVEpsTmpSaUlDOHZJRzFsZEdodlpDQWlkR2hwY21SUVlYSjBlU2hoWkdSeVpYTnpMSFZwYm5RMk5DbGhaR1J5WlhOeklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0oxY25rZ053b2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGalkyOTFiblFLQ21OaGJHeERkSGhQZDI1elgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTVDaUFnSUNBdkx5QnlaV3RsZVVKaFkydEpaazVsWTJWemMyRnllU2h5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlISmxhMlY1UW1GamEwbG1UbVZqWlhOellYSjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TUFvZ0lDQWdMeThnY21WMGRYSnVJSHNnWTNSNExDQnZkMjV6TENCMGFHbHlaRkJoY25SNUlIMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5d2NtbHVZMmx3WVd3dGNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMExUSXdNUW9nSUNBZ0x5OGdZMkZzYkVOMGVFOTNibk1vQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdjSEp2WW1VNklFRndjR3hwWTJGMGFXOXVMQW9nSUNBZ0x5OGdJQ0JvYVc1ME9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lHRnNjMjlVYUdseVpGQmhjblI1T2lCaWIyOXNaV0Z1Q2lBZ0lDQXZMeUFwT2lCRGRIaFBkMjV6VW1WemRXeDBJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWlhOMFVISnBibU5wY0dGc1VHeDFaMmx1TG1OaGJHeFVhWEJYWVd4c1pYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVd4c1ZHbHdWMkZzYkdWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNalFLSUNBZ0lDOHZJR05oYkd4VWFYQlhZV3hzWlhRb2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd2djbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0J3Y205aVpUb2dRWEJ3YkdsallYUnBiMjRzSUdOeVpXRjBiM0k2SUVGalkyOTFiblFzSUhOMGIzSmxaRG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Y0hKcGJtTnBjR0ZzTFhCc2RXZHBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TlMweU1qZ0tJQ0FnSUM4dklHTnZibk4wSUhKbGMzVnNkQ0E5SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRTF2WTJ0UWNtbHVZMmx3WVd4UWNtOWlaUzV3Y205MGIzUjVjR1V1ZEdsd1YyRnNiR1YwVDJZK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIQnliMkpsTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWTNKbFlYUnZjaXdnYzNSdmNtVmtYU3dLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaRE01Tm1ZME1tVWdMeThnYldWMGFHOWtJQ0owYVhCWFlXeHNaWFJQWmloaFpHUnlaWE56TEhWcGJuUTJOQ2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjSEpwYm1OcGNHRnNMWEJzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlPUW9nSUNBZ0x5OGdjbVZyWlhsQ1lXTnJTV1pPWldObGMzTmhjbmtvY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnY21WclpYbENZV05yU1daT1pXTmxjM05oY25rS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTBDaUFnSUNBdkx5QmpZV3hzVkdsd1YyRnNiR1YwS0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd2djSEp2WW1VNklFRndjR3hwWTJGMGFXOXVMQ0JqY21WaGRHOXlPaUJCWTJOdmRXNTBMQ0J6ZEc5eVpXUTZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM0J5YVc1amFYQmhiQzF3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWR1Z6ZEZCeWFXNWphWEJoYkZCc2RXZHBiaTVrYjI1bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taRzl1WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXdjbWx1WTJsd1lXd3RjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTBDaUFnSUNBdkx5QmtiMjVsS0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0cE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl3Y21sdVkybHdZV3d0Y0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0xQ2lBZ0lDQXZMeUJ5Wld0bGVVSmhZMnRKWms1bFkyVnpjMkZ5ZVNoMGNuVmxMQ0IzWVd4c1pYUXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJ5Wld0bGVVSmhZMnRKWms1bFkyVnpjMkZ5ZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzQnlhVzVqYVhCaGJDMXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16UUtJQ0FnSUM4dklHUnZibVVvZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2YmlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZDQUFCQm9rQkpnb0VGUjk4ZFJCemNHVnVaR2x1WjE5aFpHUnlaWE56QVFBRU10a0txZ3RGVWxJNlpYSnlUbUYwYUFsaGEybDBZVjlrWVc4RWhlNnhtQVRCVzVza0MwVlNVanBsY25KSWJuZHNDMFZTVWpwbGNuSklibUprTVJrVVJERVlRUUI0Z2hBRWJmUTNGZ1FtYUw3Z0JCWWFYbkVFZXZhTHBRVEdoRHFwQk5JZERVb0VIeUh0YUFRcWZjbUJCTjlUNWY0RUxvWFFSZ1NlL2cvdEJOTUhMK0lFTEdLdm9BUlZTcXFiQk96Ukt1d0VLVjJvUXpZYUFJNFFBS0lBL3dGVUFiSUNFd0oxQXI0RENBT0lBL1lGZ1FYdkJqNEdtd2VRQi9RQWdBUWtEUzluTmhvQWpnRUFoUUNLQWdFamkvNUJBQVdMLzBBQUF5Tk1pWXYrY2dkTWpBQkJBQmFML3hhQUJXRndjRWxFVEZBRGl3QVNRUUFESkV5SkkwTC8rb29CQVl2L0tXVklTWE1DUkRJS0VrQUFCQ2NFc0FDSmlnSUFpLzVCQUI2TC95bGxTTEdML292L2lBQVNzaUFqc2doSnNnZXlBQ1N5RUNPeUFiT0ppZ0lCaS81QUFBTXlBNG1MLzNJSVJJazJHZ0ZKRlNJU1JCY25CVXhuSkVNMkdnRkpGU0lTUkJjMkdnSkpGU1FTUkNOVE5ob0RTUlVpRWtRWE5ob0VTUlVpRWtSTEE0ai9lYkZQQTA4RWlQK3ZzaUN5QUV5eUdDdXlHcklhSmJJUUk3SUJzN1ErU1ZjRUFFeFhBQVFvRWtSSkZTRUVFa1FvVEZDd0pFTTJHZ0ZKRlNJU1JFa1hOaG9DU1JVa0VrUWpVellhQTBrVkloSkVGMHNDaVA4anNVOENUd09JLzFteUlMSUFzaGdyc2hxeUdpV3lFQ095QWJPMFBrbFhCQUJNVndBRUtCSkVTUlVoQkJKRUtFeFFzQ1JETmhvQlNSVWlFa1FYTmhvQ1NSVWtFa1FqVXpZYUEwa1ZJaEpFRnpZYUJFa1ZJaEpFU3dPSS9zZXhUd05QQklqKy9iSWdzZ0JNc2hnbkJySWFzaG9sc2hBanNnR3p0RDVKVndRQVRGY0FCQ2dTUkVrVklRUVNSQ2hNVUxBa1F6WWFBVWtWSWhKRUZ6WWFBa2tWSkJKRUkxTTJHZ05KRlNJU1JCYzJHZ1JKRlNJU1JFc0RpUDVwc1U4RFR3U0kvcCt5SUxJQVRMSVlnQVRqbDZqWXNocXlHaVd5RUNPeUFiTzBQa2xYQkFCTVZ3QUVLQkpFU1JVaUVrUW9URkN3SkVNMkdnRkpGU0lTUkJjMkdnSkpGU1FTUkNOVE5ob0RTUlVpRWtRWE5ob0VTUlVpRWtSTEE0aitDTEZQQTA4RWlQNCtzaUN5QUV5eUdJQUV6MnpIeDdJYXNob2xzaEFqc2dHenRENUpWd1FBVEZjQUJDZ1NSRWtWZ1NBU1JDaE1VTEFrUXpZYUFVa1ZJaEpFRnpZYUFra1ZJaEpFRnpZYUEwa1ZJaEpFc1V5eUdDdXlHcklhSmJJUUk3SUJzN1ErU1ZjRUFFeFhBQVFvRWtSSkZTRUVFa1FrVHdLSS9hTW9URkN3SkVNMkdnRkpGU0lTUkJjMkdnSkpGU0lTUkJjMkdnTkpGU0lTUkxGTXNoZ25Ccklhc2hvbHNoQWpzZ0d6dEQ1SlZ3UUFURmNBQkNnU1JFa1ZJUVFTUkNSUEFvajlXU2hNVUxBa1F6WWFBVWtWSWhKRVNSYzJHZ0pKRlNRU1JDTlROaG9EU1JVaUVrUVhOaG9FU1JVaUVrUTJHZ1ZKRlNJU1JFc0VpUDBLc1VzRGNnaEVzaUFqc2doSnNnZXlBQ1N5RUNPeUFiWlBBcklZSndleUdrOEVzaHBNc2hxeUdvQUJnTElhSmJJUUk3SUJzN2NCUGtsWEJBQk1Wd0FFS0JKRVRFOENpUHpaS0V4UXNDUkROaG9CU1JVaUVrUkpGellhQWtrVkloSkVGellhQTBrVkloSkVOaG9FU1JVaUVrUlBBNGo4bExGTEEzSUlSTElnSTdJSVNiSUhzZ0Frc2hBanNnRzJUd0t5R0NjSHNocFBBcklhVExJYXNob3FzaG9sc2hBanNnR3p0d0UrU1ZjRUFFeFhBQVFvRWtRb1RGQ3dKRU1qU1RZYUFVa1ZJaEpFRjBrakp3VmxSSUFEWVdGc1pVaUJXRnRKVGdPSSsvaEFBQVFuQ0xBQVNTbGxURTREUVFGV1N3SVZnU0FTUVFGTkpFQUFCQ2NKc0FCTEFuTUNTRElLRWtBQUJDY0VzQUF5Q0V3eUNrVUdTVUFBSEVZRE1nTkpJeFpQQTBsT0FsQlBBMUJNVUV4UUtsQW9URkN3SkVOSlR3T0krNXRBQUFRbkNMQUFTd0ZBQUErQUMwVlNVanBsY25KSWRHOXdzQUFqVGdOTVN3RVRRUUFzVHdKSVNTbGxURVVFUVFBWlN3SVZnU0FTUVFBUVN3SkxBaEpCQUFoTEFVc0VFMEFBQkNjSnNBQWtUZ0pKZ0JKamIyNTBjbTlzYkdWa1gyRmtaSEpsYzNObFFRQUlTUldCSUJKQUFBK0FDMFZTVWpwbGNuSkpkMngwc0FCSlN3TVNRUUJPSkU0Q1N3R0FDSEpsWm1WeWNtVnlaVUVBTTBrVmdTQVNRUUFyVGdSTEEwc0JUd1JKVGdOTlRnTkJBQlJNRms4Q1VFeFFURkJNVUNvalR3TlVVRUwvTEVneUEwTC81a2d5QTA0RVF2L1BTd0Z5Q0V4T0EwQUFDVThDU0NOT0FrTC9va2xMQXhKQkFBMVBBbk1DU0RJREVrNENRditPU1hNQ1NFOERFazRDUXYrQ0kwTCtzRFlhQVVrVkloSkVGellhQWtrVkpCSkVJMU0yR2dOSkZTSVNSQmMyR2dSSkZTSVNSRFlhQlVrVkloSkVTd1NJK3BLeFR3UlBCWWo2eUxJZ3NnQlBBcklZZ0FTMVhIRHNzaHBNc2hxeUdpV3lFQ095QWJPMFBrbFhCQUJNVndBRUtCSkVTUlVoQkJKRUtFeFFzQ1JETmhvQlNSVWlFa1FYTmhvQ1NSVWlFa1FYTmhvRFNSVWlFa1FYTmhvRVNSVWlFa1FYc1RJSUZrOENGazhDRm9BRUlzYkkwcklhVHdLeUdreXlHcklhc2hnbHNoQWpzZ0d6SkV5SStoOGtRellhQVVrVkloSkVTUmMyR2dKSkZTUVNSQ05UTmhvRFNSVWlFa1FYTmhvRVNSV0JJQkpFc1V5eUdJQUVPREcwWmJJYVR3T3lHcklhSmJJUUk3SUJzN1ErU1ZjRUFFeFhBQVFvRWtSSkZTUVNSRXhQQW9qNXhpaE1VTEFrUXpZYUFVa1ZJaEpFRjBrMkdnSkpGU1FTUkNOVFREWWFBMGtWSWhKRUYwbE9CRFlhQkVsT0JVa1ZJaEpFTmhvRlNVNEdTUldCSUJKRU5ob0dTUlVrRWtRalUwOEVpUGxpc2JJQVN3T3lHSUFFOS9xamFMSWFUd0t5R2lXeUVDT3lBYk8wUGtsWEJBQkpUZ0pPQlZjQUJDZ1NSRWtWZ1VnU1JMRlBBN0lZZ0FTTDdSNjJzaHF5R2t5eUdpV3lFQ095QWJPMFBrbFhCQUJNVndBRUtCSkVTUlVrRWtRalUwd3lBMDRGUVFBeXNVc0hzaGlBQkJQaTVrdXlHa3NGc2hwTEJySWFKYklRSTdJQnM3UStTVmNFQUVsT0FrVUhWd0FFS0JKRUZZRWdFa1JQQWs4RGlQamFLaU5QQWxSUVN3RlFLRXhRc0NSRE5ob0JTUlVpRWtRWE5ob0NTUlVrRWtRalV6WWFBMGtWSWhKRUZ6WWFCRWtWZ1NBU1JEWWFCVWtWSWhKRXNVOENzaGlBQk5PVzlDNnlHa3l5R3JJYUpiSVFJN0lCczdRK1NWY0VBRXhYQUFRb0VrUkpGU0lTUkV4UEFvajRiU2hNVUxBa1F6WWFBVWtWSWhKRUZ5Uk1pUGhaSkVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
