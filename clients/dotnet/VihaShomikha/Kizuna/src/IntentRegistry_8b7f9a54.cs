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

namespace Arc56.Generated.VihaShomikha.Kizuna.IntentRegistry_8b7f9a54
{


    //
    // On-chain registry of payment intents with state machine transitions.
    //
    public class IntentRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public IntentRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class IntentRecord : AVMObjectType
            {
                public Algorand.Address User { get; set; }

                public Algorand.Address Solver { get; set; }

                public ulong AmountInr { get; set; }

                public ulong AmountCrypto { get; set; }

                public ulong AssetId { get; set; }

                public ulong LockedRate { get; set; }

                public byte Status { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong Expiry { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vUser.From(User);
                    ret.AddRange(vUser.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSolver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSolver.From(Solver);
                    ret.AddRange(vSolver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountInr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountInr.From(AmountInr);
                    ret.AddRange(vAmountInr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountCrypto = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountCrypto.From(AmountCrypto);
                    ret.AddRange(vAmountCrypto.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLockedRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLockedRate.From(LockedRate);
                    ret.AddRange(vLockedRate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiry.From(Expiry);
                    ret.AddRange(vExpiry.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static IntentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new IntentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vUser.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUser = vUser.ToValue();
                    if (valueUser is Algorand.Address vUserValue) { ret.User = vUserValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSolver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSolver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSolver = vSolver.ToValue();
                    if (valueSolver is Algorand.Address vSolverValue) { ret.Solver = vSolverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountInr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountInr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountInr = vAmountInr.ToValue();
                    if (valueAmountInr is ulong vAmountInrValue) { ret.AmountInr = vAmountInrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountCrypto = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountCrypto.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountCrypto = vAmountCrypto.ToValue();
                    if (valueAmountCrypto is ulong vAmountCryptoValue) { ret.AmountCrypto = vAmountCryptoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLockedRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLockedRate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLockedRate = vLockedRate.ToValue();
                    if (valueLockedRate is ulong vLockedRateValue) { ret.LockedRate = vLockedRateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiry.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiry = vExpiry.ToValue();
                    if (valueExpiry is ulong vExpiryValue) { ret.Expiry = vExpiryValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as IntentRecord);
                }
                public bool Equals(IntentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(IntentRecord left, IntentRecord right)
                {
                    return EqualityComparer<IntentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(IntentRecord left, IntentRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new payment intent on-chain.
        ///</summary>
        /// <param name="intent_id"> </param>
        /// <param name="amount_inr"> </param>
        /// <param name="amount_crypto"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="locked_rate"> </param>
        /// <param name="expiry"> </param>
        /// <param name="mbr_pay"> </param>
        public async Task CreateIntent(PaymentTransaction mbr_pay, string intent_id, ulong amount_inr, ulong amount_crypto, ulong asset_id, ulong locked_rate, ulong expiry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 213, 119, 85, 239 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var amount_inrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inrAbi.From(amount_inr);
            var amount_cryptoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_cryptoAbi.From(amount_crypto);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var locked_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); locked_rateAbi.From(locked_rate);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi, amount_inrAbi, amount_cryptoAbi, asset_idAbi, locked_rateAbi, expiryAbi, mbr_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateIntent_Transactions(PaymentTransaction mbr_pay, string intent_id, ulong amount_inr, ulong amount_crypto, ulong asset_id, ulong locked_rate, ulong expiry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 213, 119, 85, 239 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var amount_inrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inrAbi.From(amount_inr);
            var amount_cryptoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_cryptoAbi.From(amount_crypto);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var locked_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); locked_rateAbi.From(locked_rate);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi, amount_inrAbi, amount_cryptoAbi, asset_idAbi, locked_rateAbi, expiryAbi, mbr_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Assign a solver to an intent. Admin only.
        ///</summary>
        /// <param name="intent_id"> </param>
        /// <param name="solver"> </param>
        public async Task MatchIntent(string intent_id, Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 15, 169, 72 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MatchIntent_Transactions(string intent_id, Algorand.Address solver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 15, 169, 72 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var solverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); solverAbi.From(solver);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi, solverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Advance the intent state machine. Admin only.
        ///</summary>
        /// <param name="intent_id"> </param>
        /// <param name="new_status"> </param>
        public async Task UpdateStatus(string intent_id, ulong new_status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 141, 22, 117 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var new_statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_statusAbi.From(new_status);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi, new_statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateStatus_Transactions(string intent_id, ulong new_status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 141, 22, 117 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var new_statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_statusAbi.From(new_status);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi, new_statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark an intent as expired. Anyone can call if it's past expiry.
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task ExpireIntent(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 241, 105, 80 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExpireIntent_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 241, 105, 80 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel an intent. Only the creator can cancel, and only before matching.
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task CancelIntent(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 254, 94, 138 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelIntent_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 254, 94, 138 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task<Structs.IntentRecord> GetIntent(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 60, 179, 158 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.SimApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.IntentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetIntent_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 60, 179, 158 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task<bool> IntentExists(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 96, 224, 19 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.SimApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IntentExists_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 96, 224, 19 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task<ulong> GetIntentStatus(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 147, 107, 91 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.SimApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetIntentStatus_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 147, 107, 91 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW50ZW50UmVnaXN0cnkiLCJkZXNjIjoiT24tY2hhaW4gcmVnaXN0cnkgb2YgcGF5bWVudCBpbnRlbnRzIHdpdGggc3RhdGUgbWFjaGluZSB0cmFuc2l0aW9ucy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSW50ZW50UmVjb3JkIjpbeyJuYW1lIjoidXNlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic29sdmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnRfaW5yIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFtb3VudF9jcnlwdG8iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXRfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibG9ja2VkX3JhdGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiY3JlYXRlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleHBpcnkiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfaW50ZW50IiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IHBheW1lbnQgaW50ZW50IG9uLWNoYWluLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9pbnIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9jcnlwdG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2NrZWRfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hdGNoX2ludGVudCIsImRlc2MiOiJBc3NpZ24gYSBzb2x2ZXIgdG8gYW4gaW50ZW50LiBBZG1pbiBvbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzb2x2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3N0YXR1cyIsImRlc2MiOiJBZHZhbmNlIHRoZSBpbnRlbnQgc3RhdGUgbWFjaGluZS4gQWRtaW4gb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfc3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4cGlyZV9pbnRlbnQiLCJkZXNjIjoiTWFyayBhbiBpbnRlbnQgYXMgZXhwaXJlZC4gQW55b25lIGNhbiBjYWxsIGlmIGl0J3MgcGFzdCBleHBpcnkuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxfaW50ZW50IiwiZGVzYyI6IkNhbmNlbCBhbiBpbnRlbnQuIE9ubHkgdGhlIGNyZWF0b3IgY2FuIGNhbmNlbCwgYW5kIG9ubHkgYmVmb3JlIG1hdGNoaW5nLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2ludGVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJJbnRlbnRSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImludGVudF9leGlzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2ludGVudF9zdGF0dXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY5NF0sImVycm9yTWVzc2FnZSI6IkNhbiBvbmx5IGNhbmNlbCBjcmVhdGVkIGludGVudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODFdLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgZXhwaXJlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQwXSwiZXJyb3JNZXNzYWdlIjoiRXhwaXJ5IGluIHBhc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzRdLCJlcnJvck1lc3NhZ2UiOiJJbnRlbnQgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDddLCJlcnJvck1lc3NhZ2UiOiJNQlIgcGF5IHRvIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzM10sImVycm9yTWVzc2FnZSI6Ik5vdCBpbiBjcmVhdGVkIHN0YXR1cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5OF0sImVycm9yTWVzc2FnZSI6Ik5vdCB5ZXQgZXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOSw0MzBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBpbnRlbnQgY3JlYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNyw0MjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNiw0NDIsNTYyLDY4Nyw3ODgsODQ2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pbnRlbnRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfaW50ZW50cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3NldHRsZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY1LDI5NCw0MDIsNTQ1LDY3NCw3NzYsODAxLDgzNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MiwzMDEsNDA5LDU1Miw2ODEsNzgzLDgwOCw4NDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MCwxODgsMTk2LDIwNCwyMTIsNDE3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk1XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE5qazJaVGMwTldZZ01IZ3dNU0FpZEc5MFlXeGZhVzUwWlc1MGN5SWdJblJ2ZEdGc1gzTmxkSFJzWldRaUlDSmhaRzFwYmlJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5cGJuUmxiblJ6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlwYm5SbGJuUnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM05sZEhSc1pXUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gzTmxkSFJzWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdZMnhoYzNNZ1NXNTBaVzUwVW1WbmFYTjBjbmtvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRRS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoa05UYzNOVFZsWmlBd2VEWTRNR1poT1RRNElEQjRZMk00WkRFMk56VWdNSGc1WW1ZeE5qazFNQ0F3ZUdFeVptVTFaVGhoSURCNFpHRXpZMkl6T1dVZ01IaGpZVFl3WlRBeE15QXdlREF5T1RNMllqVmlJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMmx1ZEdWdWRDaHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaWJXRjBZMmhmYVc1MFpXNTBLSE4wY21sdVp5eGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjl6ZEdGMGRYTW9jM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0psZUhCcGNtVmZhVzUwWlc1MEtITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0pqWVc1alpXeGZhVzUwWlc1MEtITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmFXNTBaVzUwS0hOMGNtbHVaeWtvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWFXNTBaVzUwWDJWNGFYTjBjeWh6ZEhKcGJtY3BZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBYMmx1ZEdWdWRGOXpkR0YwZFhNb2MzUnlhVzVuS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVjlwYm5SbGJuUWdiV0YwWTJoZmFXNTBaVzUwSUhWd1pHRjBaVjl6ZEdGMGRYTWdaWGh3YVhKbFgybHVkR1Z1ZENCallXNWpaV3hmYVc1MFpXNTBJR2RsZEY5cGJuUmxiblFnYVc1MFpXNTBYMlY0YVhOMGN5Qm5aWFJmYVc1MFpXNTBYM04wWVhSMWN3b2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdZMnhoYzNNZ1NXNTBaVzUwVW1WbmFYTjBjbmtvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNTBaVzUwWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtsdWRHVnVkRkpsWjJsemRISjVMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklITmxiR1l1WVdSdGFXNHVkbUZzZFdVZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1MFpXNTBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa2x1ZEdWdWRGSmxaMmx6ZEhKNUxtTnlaV0YwWlY5cGJuUmxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZmYVc1MFpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEWUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZeENpQWdJQ0F2THlCaGMzTmxjblFnYVc1MFpXNTBYMmxrSUc1dmRDQnBiaUJ6Wld4bUxtbHVkR1Z1ZEhNc0lDSkpiblJsYm5RZ1lXeHlaV0ZrZVNCbGVHbHpkSE1pQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmprMlpUYzBOV1lLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkR1Z1ZENCaGJISmxZV1I1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdZWE56WlhKMElHVjRjR2x5ZVNBK0lFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3TENBaVJYaHdhWEo1SUdsdUlIQmhjM1FpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJGZUhCcGNua2dhVzRnY0dGemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1lYTnpaWEowSUcxaWNsOXdZWGt1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z0lrMUNVaUJ3WVhrZ2RHOGdZWEJ3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTFDVWlCd1lYa2dkRzhnWVhCd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCMWMyVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUhOdmJIWmxjajFoY21NMExrRmtaSEpsYzNNb1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5a3NDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk5TMDNOUW9nSUNBZ0x5OGdjMlZzWmk1cGJuUmxiblJ6VzJsdWRHVnVkRjlwWkYwZ1BTQkpiblJsYm5SU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnYzI5c2RtVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOektTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUmZhVzV5UFdGeVl6UXVWVWx1ZERZMEtHRnRiM1Z1ZEY5cGJuSXBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRjlqY25sd2RHODlZWEpqTkM1VlNXNTBOalFvWVcxdmRXNTBYMk55ZVhCMGJ5a3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E5WVhKak5DNVZTVzUwTmpRb1lYTnpaWFJmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR3h2WTJ0bFpGOXlZWFJsUFdGeVl6UXVWVWx1ZERZMEtHeHZZMnRsWkY5eVlYUmxLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoSlRsUkZUbFJmUTFKRlFWUkZSQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJQ0FnWlhod2FYSjVQV0Z5WXpRdVZVbHVkRFkwS0dWNGNHbHllU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QnpkR0YwZFhNOVlYSmpOQzVWU1c1ME9DaEpUbFJGVGxSZlExSkZRVlJGUkNrc0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qVXROelVLSUNBZ0lDOHZJSE5sYkdZdWFXNTBaVzUwYzF0cGJuUmxiblJmYVdSZElEMGdTVzUwWlc1MFVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lIVnpaWEk5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUhOdmJIWmxjajFoY21NMExrRmtaSEpsYzNNb1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5a3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMmx1Y2oxaGNtTTBMbFZKYm5RMk5DaGhiVzkxYm5SZmFXNXlLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmWTNKNWNIUnZQV0Z5WXpRdVZVbHVkRFkwS0dGdGIzVnVkRjlqY25sd2RHOHBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMmxrUFdGeVl6UXVWVWx1ZERZMEtHRnpjMlYwWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0JzYjJOclpXUmZjbUYwWlQxaGNtTTBMbFZKYm5RMk5DaHNiMk5yWldSZmNtRjBaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb1NVNVVSVTVVWDBOU1JVRlVSVVFwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHllVDFoY21NMExsVkpiblEyTkNobGVIQnBjbmtwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMmx1ZEdWdWRITWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gybHVkR1Z1ZEhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmFXNTBaVzUwY3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlwYm5SbGJuUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1sdWRHVnVkRjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVKYm5SbGJuUlNaV2RwYzNSeWVTNXRZWFJqYUY5cGJuUmxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdFlYUmphRjlwYm5SbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1YVc1MFpXNTBjMXRwYm5SbGJuUmZhV1JkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFk1Tm1VM05EVm1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBiblJsYm5SeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdZWE56WlhKMElISmxZMjl5WkM1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DaEpUbFJGVGxSZlExSkZRVlJGUkNrc0lDSk9iM1FnYVc0Z1kzSmxZWFJsWkNCemRHRjBkWE1pQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4Q2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1FnYVc0Z1kzSmxZWFJsWkNCemRHRjBkWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRFlLSUNBZ0lDOHZJSFZ6WlhJOWNtVmpiM0prTG5WelpYSXNDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z1lXMXZkVzUwWDJsdWNqMXlaV052Y21RdVlXMXZkVzUwWDJsdWNpd0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURZMElEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklHRnRiM1Z1ZEY5amNubHdkRzg5Y21WamIzSmtMbUZ0YjNWdWRGOWpjbmx3ZEc4c0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0EzTWlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCaGMzTmxkRjlwWkQxeVpXTnZjbVF1WVhOelpYUmZhV1FzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQTRNQ0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJzYjJOclpXUmZjbUYwWlQxeVpXTnZjbVF1Ykc5amEyVmtYM0poZEdVc0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkQ0E0T0NBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCamNtVmhkR1ZrWDJGMFBYSmxZMjl5WkM1amNtVmhkR1ZrWDJGMExBb2dJQ0FnWkdsbklEVUtJQ0FnSUdWNGRISmhZM1FnT1RjZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z1pYaHdhWEo1UFhKbFkyOXlaQzVsZUhCcGNua3NDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR1Y0ZEhKaFkzUWdNVEExSURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RVdE9UVUtJQ0FnSUM4dklITmxiR1l1YVc1MFpXNTBjMXRwYm5SbGJuUmZhV1JkSUQwZ1NXNTBaVzUwVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSTljbVZqYjNKa0xuVnpaWElzQ2lBZ0lDQXZMeUFnSUNBZ2MyOXNkbVZ5UFdGeVl6UXVRV1JrY21WemN5aHpiMngyWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRGOXBibkk5Y21WamIzSmtMbUZ0YjNWdWRGOXBibklzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDJOeWVYQjBiejF5WldOdmNtUXVZVzF2ZFc1MFgyTnllWEIwYnl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5cFpEMXlaV052Y21RdVlYTnpaWFJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdiRzlqYTJWa1gzSmhkR1U5Y21WamIzSmtMbXh2WTJ0bFpGOXlZWFJsTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtFbE9WRVZPVkY5TlFWUkRTRVZFS1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQWEpsWTI5eVpDNWpjbVZoZEdWa1gyRjBMQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHllVDF5WldOdmNtUXVaWGh3YVhKNUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVElLSUNBZ0lDOHZJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTRLRWxPVkVWT1ZGOU5RVlJEU0VWRUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZzFMVGsxQ2lBZ0lDQXZMeUJ6Wld4bUxtbHVkR1Z1ZEhOYmFXNTBaVzUwWDJsa1hTQTlJRWx1ZEdWdWRGSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UFhKbFkyOXlaQzUxYzJWeUxBb2dJQ0FnTHk4Z0lDQWdJSE52YkhabGNqMWhjbU0wTGtGa1pISmxjM01vYzI5c2RtVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmYVc1eVBYSmxZMjl5WkM1aGJXOTFiblJmYVc1eUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRGOWpjbmx3ZEc4OWNtVmpiM0prTG1GdGIzVnVkRjlqY25sd2RHOHNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E5Y21WamIzSmtMbUZ6YzJWMFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUd4dlkydGxaRjl5WVhSbFBYSmxZMjl5WkM1c2IyTnJaV1JmY21GMFpTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2hKVGxSRlRsUmZUVUZVUTBoRlJDa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxeVpXTnZjbVF1WTNKbFlYUmxaRjloZEN3S0lDQWdJQzh2SUNBZ0lDQmxlSEJwY25rOWNtVmpiM0prTG1WNGNHbHllU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzUwWlc1MFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrbHVkR1Z1ZEZKbFoybHpkSEo1TG5Wd1pHRjBaVjl6ZEdGMGRYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVmZjM1JoZEhWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pQYm14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd01Rb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVwYm5SbGJuUnpXMmx1ZEdWdWRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROamsyWlRjME5XWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1sdWRHVnVkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z2FXWWdibVYzWDNOMFlYUjFjeUE5UFNCVlNXNTBOalFvU1U1VVJVNVVYMU5GVkZSTVJVUXBPZ29nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0E5UFFvZ0lDQWdZbm9nZFhCa1lYUmxYM04wWVhSMWMxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzTmxkSFJzWldRZ0t6MGdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDNObGRIUnNaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzJWMGRHeGxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXpaWFIwYkdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDblZ3WkdGMFpWOXpkR0YwZFhOZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUhWelpYSTljbVZqYjNKa0xuVnpaWElzQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TURnS0lDQWdJQzh2SUhOdmJIWmxjajF5WldOdmNtUXVjMjlzZG1WeUxBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQTVDaUFnSUNBdkx5QmhiVzkxYm5SZmFXNXlQWEpsWTI5eVpDNWhiVzkxYm5SZmFXNXlMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05qUWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNVEFLSUNBZ0lDOHZJR0Z0YjNWdWRGOWpjbmx3ZEc4OWNtVmpiM0prTG1GdGIzVnVkRjlqY25sd2RHOHNDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBM01pQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXhNUW9nSUNBZ0x5OGdZWE56WlhSZmFXUTljbVZqYjNKa0xtRnpjMlYwWDJsa0xBb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnT0RBZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklHeHZZMnRsWkY5eVlYUmxQWEpsWTI5eVpDNXNiMk5yWldSZmNtRjBaU3dLSUNBZ0lHUnBaeUExQ2lBZ0lDQmxlSFJ5WVdOMElEZzRJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJ6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2h1WlhkZmMzUmhkSFZ6S1N3S0lDQWdJR1JwWnlBNUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTnlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1kzSmxZWFJsWkY5aGREMXlaV052Y21RdVkzSmxZWFJsWkY5aGRDd0tJQ0FnSUdScFp5QTNDaUFnSUNCbGVIUnlZV04wSURrM0lEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1URTFDaUFnSUNBdkx5QmxlSEJwY25rOWNtVmpiM0prTG1WNGNHbHllU3dLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWlhoMGNtRmpkQ0F4TURVZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1EWXRNVEUyQ2lBZ0lDQXZMeUJ6Wld4bUxtbHVkR1Z1ZEhOYmFXNTBaVzUwWDJsa1hTQTlJRWx1ZEdWdWRGSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UFhKbFkyOXlaQzUxYzJWeUxBb2dJQ0FnTHk4Z0lDQWdJSE52YkhabGNqMXlaV052Y21RdWMyOXNkbVZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEY5cGJuSTljbVZqYjNKa0xtRnRiM1Z1ZEY5cGJuSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMk55ZVhCMGJ6MXlaV052Y21RdVlXMXZkVzUwWDJOeWVYQjBieXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjlwWkQxeVpXTnZjbVF1WVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2JHOWphMlZrWDNKaGRHVTljbVZqYjNKa0xteHZZMnRsWkY5eVlYUmxMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0c1bGQxOXpkR0YwZFhNcExBb2dJQ0FnTHk4Z0lDQWdJR055WldGMFpXUmZZWFE5Y21WamIzSmtMbU55WldGMFpXUmZZWFFzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1UFhKbFkyOXlaQzVsZUhCcGNua3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXBiblJsYm5SZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVNXNTBaVzUwVW1WbmFYTjBjbmt1Wlhod2FYSmxYMmx1ZEdWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVY0Y0dseVpWOXBiblJsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtbHVkR1Z1ZEhOYmFXNTBaVzUwWDJsa1hTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk9UWmxOelExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYm5SbGJuUnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvU1U1VVJVNVVYME5TUlVGVVJVUXBJRzl5SUhKbFkyOXlaQzV6ZEdGMGRYTWdQVDBnWVhKak5DNVZTVzUwT0NnS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0k5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWpJdE1USTBDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RNEtFbE9WRVZPVkY5RFVrVkJWRVZFS1NCdmNpQnlaV052Y21RdWMzUmhkSFZ6SUQwOUlHRnlZelF1VlVsdWREZ29DaUFnSUNBdkx5QWdJQ0FnU1U1VVJVNVVYMDFCVkVOSVJVUUtJQ0FnSUM4dklDa3NJQ0pEWVc1dWIzUWdaWGh3YVhKbElnb2dJQ0FnWW01NklHVjRjR2x5WlY5cGJuUmxiblJmWW05dmJGOTBjblZsUURNS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURJS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWlhod2FYSmxYMmx1ZEdWdWRGOWliMjlzWDJaaGJITmxRRFFLQ21WNGNHbHlaVjlwYm5SbGJuUmZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWlhod2FYSmxYMmx1ZEdWdWRGOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV5TWkweE1qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb1NVNVVSVTVVWDBOU1JVRlVSVVFwSUc5eUlISmxZMjl5WkM1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DZ0tJQ0FnSUM4dklDQWdJQ0JKVGxSRlRsUmZUVUZVUTBoRlJBb2dJQ0FnTHk4Z0tTd2dJa05oYm01dmRDQmxlSEJwY21VaUNpQWdJQ0JoYzNObGNuUWdMeThnUTJGdWJtOTBJR1Y0Y0dseVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0ErSUhKbFkyOXlaQzVsZUhCcGNua3VibUYwYVhabExDQWlUbTkwSUhsbGRDQmxlSEJwY21Wa0lnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F4TURVZ09Bb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRBMUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJSGxsZENCbGVIQnBjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV5T0FvZ0lDQWdMeThnZFhObGNqMXlaV052Y21RdWRYTmxjaXdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEk1Q2lBZ0lDQXZMeUJ6YjJ4MlpYSTljbVZqYjNKa0xuTnZiSFpsY2l3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z1lXMXZkVzUwWDJsdWNqMXlaV052Y21RdVlXMXZkVzUwWDJsdWNpd0tJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURZMElEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UTXhDaUFnSUNBdkx5QmhiVzkxYm5SZlkzSjVjSFJ2UFhKbFkyOXlaQzVoYlc5MWJuUmZZM0o1Y0hSdkxBb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTnpJZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE16SUtJQ0FnSUM4dklHRnpjMlYwWDJsa1BYSmxZMjl5WkM1aGMzTmxkRjlwWkN3S0lDQWdJR1JwWnlBMUNpQWdJQ0JsZUhSeVlXTjBJRGd3SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCc2IyTnJaV1JmY21GMFpUMXlaV052Y21RdWJHOWphMlZrWDNKaGRHVXNDaUFnSUNCa2FXY2dOZ29nSUNBZ1pYaDBjbUZqZENBNE9DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdZM0psWVhSbFpGOWhkRDF5WldOdmNtUXVZM0psWVhSbFpGOWhkQ3dLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWlhoMGNtRmpkQ0E1TnlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU55MHhNemNLSUNBZ0lDOHZJSE5sYkdZdWFXNTBaVzUwYzF0cGJuUmxiblJmYVdSZElEMGdTVzUwWlc1MFVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lIVnpaWEk5Y21WamIzSmtMblZ6WlhJc0NpQWdJQ0F2THlBZ0lDQWdjMjlzZG1WeVBYSmxZMjl5WkM1emIyeDJaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDJsdWNqMXlaV052Y21RdVlXMXZkVzUwWDJsdWNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUmZZM0o1Y0hSdlBYSmxZMjl5WkM1aGJXOTFiblJmWTNKNWNIUnZMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMmxrUFhKbFkyOXlaQzVoYzNObGRGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCc2IyTnJaV1JmY21GMFpUMXlaV052Y21RdWJHOWphMlZrWDNKaGRHVXNDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvU1U1VVJVNVVYMFZZVUVsU1JVUXBMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhROWNtVmpiM0prTG1OeVpXRjBaV1JmWVhRc0NpQWdJQ0F2THlBZ0lDQWdaWGh3YVhKNVBYSmxZMjl5WkM1bGVIQnBjbmtzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE16UUtJQ0FnSUM4dklITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtFbE9WRVZPVkY5RldGQkpVa1ZFS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU55MHhNemNLSUNBZ0lDOHZJSE5sYkdZdWFXNTBaVzUwYzF0cGJuUmxiblJmYVdSZElEMGdTVzUwWlc1MFVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lIVnpaWEk5Y21WamIzSmtMblZ6WlhJc0NpQWdJQ0F2THlBZ0lDQWdjMjlzZG1WeVBYSmxZMjl5WkM1emIyeDJaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDJsdWNqMXlaV052Y21RdVlXMXZkVzUwWDJsdWNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUmZZM0o1Y0hSdlBYSmxZMjl5WkM1aGJXOTFiblJmWTNKNWNIUnZMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMmxrUFhKbFkyOXlaQzVoYzNObGRGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCc2IyTnJaV1JmY21GMFpUMXlaV052Y21RdWJHOWphMlZrWDNKaGRHVXNDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvU1U1VVJVNVVYMFZZVUVsU1JVUXBMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhROWNtVmpiM0prTG1OeVpXRjBaV1JmWVhRc0NpQWdJQ0F2THlBZ0lDQWdaWGh3YVhKNVBYSmxZMjl5WkM1bGVIQnBjbmtzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwbGVIQnBjbVZmYVc1MFpXNTBYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR1Y0Y0dseVpWOXBiblJsYm5SZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1sdWRHVnVkRjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVKYm5SbGJuUlNaV2RwYzNSeWVTNWpZVzVqWld4ZmFXNTBaVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnVZMlZzWDJsdWRHVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVE01Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5ESUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1YVc1MFpXNTBjMXRwYm5SbGJuUmZhV1JkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFk1Tm1VM05EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVc1MFpXNTBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRekNpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblE0S0VsT1ZFVk9WRjlEVWtWQlZFVkVLU3dnSWtOaGJpQnZibXg1SUdOaGJtTmxiQ0JqY21WaGRHVmtJR2x1ZEdWdWRITWlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnT1RZZ01Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXhDaUFnSUNCaVBUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRFlXNGdiMjVzZVNCallXNWpaV3dnWTNKbFlYUmxaQ0JwYm5SbGJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnY21WamIzSmtMblZ6WlhJdWJtRjBhWFpsTENBaVQyNXNlU0JwYm5SbGJuUWdZM0psWVhSdmNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2FXNTBaVzUwSUdOeVpXRjBiM0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJ6YjJ4MlpYSTljbVZqYjNKa0xuTnZiSFpsY2l3S0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME9Rb2dJQ0FnTHk4Z1lXMXZkVzUwWDJsdWNqMXlaV052Y21RdVlXMXZkVzUwWDJsdWNpd0tJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURZMElEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UVXdDaUFnSUNBdkx5QmhiVzkxYm5SZlkzSjVjSFJ2UFhKbFkyOXlaQzVoYlc5MWJuUmZZM0o1Y0hSdkxBb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTnpJZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5URUtJQ0FnSUM4dklHRnpjMlYwWDJsa1BYSmxZMjl5WkM1aGMzTmxkRjlwWkN3S0lDQWdJR1JwWnlBMENpQWdJQ0JsZUhSeVlXTjBJRGd3SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRVeUNpQWdJQ0F2THlCc2IyTnJaV1JmY21GMFpUMXlaV052Y21RdWJHOWphMlZrWDNKaGRHVXNDaUFnSUNCa2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBNE9DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdZM0psWVhSbFpGOWhkRDF5WldOdmNtUXVZM0psWVhSbFpGOWhkQ3dLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmxlSFJ5WVdOMElEazNJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFUxQ2lBZ0lDQXZMeUJsZUhCcGNuazljbVZqYjNKa0xtVjRjR2x5ZVN3S0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1pYaDBjbUZqZENBeE1EVWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hORFl0TVRVMkNpQWdJQ0F2THlCelpXeG1MbWx1ZEdWdWRITmJhVzUwWlc1MFgybGtYU0E5SUVsdWRHVnVkRkpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVBYSmxZMjl5WkM1MWMyVnlMQW9nSUNBZ0x5OGdJQ0FnSUhOdmJIWmxjajF5WldOdmNtUXVjMjlzZG1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRGOXBibkk5Y21WamIzSmtMbUZ0YjNWdWRGOXBibklzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDJOeWVYQjBiejF5WldOdmNtUXVZVzF2ZFc1MFgyTnllWEIwYnl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5cFpEMXlaV052Y21RdVlYTnpaWFJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdiRzlqYTJWa1gzSmhkR1U5Y21WamIzSmtMbXh2WTJ0bFpGOXlZWFJsTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtFbE9WRVZPVkY5RFFVNURSVXhNUlVRcExBb2dJQ0FnTHk4Z0lDQWdJR055WldGMFpXUmZZWFE5Y21WamIzSmtMbU55WldGMFpXUmZZWFFzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1UFhKbFkyOXlaQzVsZUhCcGNua3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRNS0lDQWdJQzh2SUhOMFlYUjFjejFoY21NMExsVkpiblE0S0VsT1ZFVk9WRjlEUVU1RFJVeE1SVVFwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMkxURTFOZ29nSUNBZ0x5OGdjMlZzWmk1cGJuUmxiblJ6VzJsdWRHVnVkRjlwWkYwZ1BTQkpiblJsYm5SU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxjajF5WldOdmNtUXVkWE5sY2l3S0lDQWdJQzh2SUNBZ0lDQnpiMngyWlhJOWNtVmpiM0prTG5OdmJIWmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmYVc1eVBYSmxZMjl5WkM1aGJXOTFiblJmYVc1eUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRGOWpjbmx3ZEc4OWNtVmpiM0prTG1GdGIzVnVkRjlqY25sd2RHOHNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E5Y21WamIzSmtMbUZ6YzJWMFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUd4dlkydGxaRjl5WVhSbFBYSmxZMjl5WkM1c2IyTnJaV1JmY21GMFpTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2hKVGxSRlRsUmZRMEZPUTBWTVRFVkVLU3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBYSmxZMjl5WkM1amNtVmhkR1ZrWDJGMExBb2dJQ0FnTHk4Z0lDQWdJR1Y0Y0dseWVUMXlaV052Y21RdVpYaHdhWEo1TEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXpPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1MFpXNTBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa2x1ZEdWdWRGSmxaMmx6ZEhKNUxtZGxkRjlwYm5SbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmFXNTBaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TmpBS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtbHVkR1Z1ZEhOYmFXNTBaVzUwWDJsa1hRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTVObVUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx1ZEdWdWRITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUxT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1ZEdWdWRGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUpiblJsYm5SU1pXZHBjM1J5ZVM1cGJuUmxiblJmWlhocGMzUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1MFpXNTBYMlY0YVhOMGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UWTBDaUFnSUNBdkx5QnlaWFIxY200Z2FXNTBaVzUwWDJsa0lHbHVJSE5sYkdZdWFXNTBaVzUwY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZNU5tVTNORFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJuUmxiblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1U1c1MFpXNTBVbVZuYVhOMGNua3VaMlYwWDJsdWRHVnVkRjl6ZEdGMGRYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmFXNTBaVzUwWDNOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFk0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1cGJuUmxiblJ6VzJsdWRHVnVkRjlwWkYwdWMzUmhkSFZ6TG01aGRHbDJaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFk1Tm1VM05EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1sdWRHVnVkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRGsyQ2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMk5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lHQkdsdWRGOEJBUTEwYjNSaGJGOXBiblJsYm5SekRYUnZkR0ZzWDNObGRIUnNaV1FGWVdSdGFXNEVGUjk4ZFRFWVFBQUdLaUpuS3lKbk1Sa1VSREVZUVFCQWdnZ0UxWGRWN3dSb0Q2bElCTXlORm5VRW0vRnBVQVNpL2w2S0JObzhzNTRFeW1EZ0V3UUNrMnRiTmhvQWpnZ0FGZ0NYQVFNQmtnSVRBbmtDa2dLekFJQUVURnhodWpZYUFJNEJBQUVBSndReEFHY2pRellhQVVraVdTUUlTd0VWRWtRMkdnSkpGU1VTUkRZYUEwa1ZKUkpFTmhvRVNSVWxFa1EyR2dWSkZTVVNSRFlhQmtrVkpSSkVTUmN4RmlNSlNUZ1FJeEpFS0U4SVVFbTlSUUVVUkRJSFR3TU1SRXc0QnpJS0VrUXhBRElETWdjV1RnSlFUd2RRVHdaUVR3VlFUd1JRS1ZCTVVFOENVTDhpS21WRUl3Z3FUR2NqUXpZYUFVa2lXU1FJU3dFVkVrUTJHZ0pKRllFZ0VrUXhBQ0luQkdWRUVrUW9Ud0pRU2I1RVNWZGdBU21vUkVsWEFDQkxBVmRBQ0VzQ1YwZ0lTd05YVUFoTEJGZFlDRXNGVjJFSVR3WlhhUWhQQms4SVVFOEdVRThGVUU4RVVFOERVSUFCQWxCUEFsQk1VTDhqUXpZYUFVa2lXU1FJU3dFVkVrUTJHZ0pKRlNVU1JCZEpUZ0l4QUNJbkJHVkVFa1FvVHdKUVNVNEN2a3hPQWtTQkJSSkJBQWtpSzJWRUl3Z3JUR2RIQWxjQUlFc0JWeUFnU3dKWFFBaExBMWRJQ0VzRVYxQUlTd1ZYV0FoTENSWkpreVVPUkZjSEFVc0hWMkVJVHdoWGFRaFBDRThJVUU4SFVFOEdVRThGVUU4RVVFOERVRThDVUV4UVN3Sk12eU5ETmhvQlNTSlpKQWhMQVJVU1JDaE1VRW0rVEVsUEFrUlhZQUZKS2FoQUFBaEpnQUVDcUVFQVZTTkVNZ2RMQWtsWGFRaExBWUZwVzA4RERFUkxBVmNBSUVzQ1Z5QWdTd05YUUFoTEJGZElDRXNGVjFBSVN3WlhXQWhQQjFkaENFOEdUd1pRVHdWUVR3UlFUd05RVHdKUWdBRUhVRXhRVEZCTEEweS9JME1pUXYrb05ob0JTU0paSkFoTEFSVVNSQ2hNVUVtK1JFbFhZQUVwcUVReEFFc0JWd0FnVEVzQkVrUkxBVmNnSUVzQ1YwQUlTd05YU0FoTEJGZFFDRXNGVjFnSVN3WlhZUWhQQjFkcENFOEhUd2RRVHdaUVR3VlFUd1JRVHdOUWdBRUlVRThDVUV4UXZ5TkROaG9CU1NKWkpBaExBUlVTUkNoTVVMNUVKd1ZNVUxBalF6WWFBVWtpV1NRSVN3RVZFa1FvVEZDOVJRR0FBUUFpVHdKVUp3Vk1VTEFqUXpZYUFVa2lXU1FJU3dFVkVrUW9URkMrUklGZ1ZSWW5CVXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
