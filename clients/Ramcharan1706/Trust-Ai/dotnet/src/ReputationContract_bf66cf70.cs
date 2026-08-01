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

namespace Arc56.Generated.Ramcharan1706.Trust_Ai.ReputationContract_bf66cf70
{


    //
    // Maintains deterministic trust metrics for agents.
    //
    public class ReputationContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReputationContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReputationRecord : AVMObjectType
            {
                public Algorand.Address Wallet { get; set; }

                public ulong SuccessfulJobs { get; set; }

                public ulong FailedJobs { get; set; }

                public ulong Refunds { get; set; }

                public ulong Disputes { get; set; }

                public ulong TrustScore { get; set; }

                public ulong LastUpdated { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vWallet.From(Wallet);
                    ret.AddRange(vWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccessfulJobs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSuccessfulJobs.From(SuccessfulJobs);
                    ret.AddRange(vSuccessfulJobs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFailedJobs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFailedJobs.From(FailedJobs);
                    ret.AddRange(vFailedJobs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefunds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRefunds.From(Refunds);
                    ret.AddRange(vRefunds.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisputes.From(Disputes);
                    ret.AddRange(vDisputes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrustScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTrustScore.From(TrustScore);
                    ret.AddRange(vTrustScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdated.From(LastUpdated);
                    ret.AddRange(vLastUpdated.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReputationRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReputationRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWallet = vWallet.ToValue();
                    if (valueWallet is Algorand.Address vWalletValue) { ret.Wallet = vWalletValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccessfulJobs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSuccessfulJobs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSuccessfulJobs = vSuccessfulJobs.ToValue();
                    if (valueSuccessfulJobs is ulong vSuccessfulJobsValue) { ret.SuccessfulJobs = vSuccessfulJobsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFailedJobs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFailedJobs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFailedJobs = vFailedJobs.ToValue();
                    if (valueFailedJobs is ulong vFailedJobsValue) { ret.FailedJobs = vFailedJobsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefunds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRefunds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRefunds = vRefunds.ToValue();
                    if (valueRefunds is ulong vRefundsValue) { ret.Refunds = vRefundsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputes = vDisputes.ToValue();
                    if (valueDisputes is ulong vDisputesValue) { ret.Disputes = vDisputesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrustScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTrustScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTrustScore = vTrustScore.ToValue();
                    if (valueTrustScore is ulong vTrustScoreValue) { ret.TrustScore = vTrustScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdated = vLastUpdated.ToValue();
                    if (valueLastUpdated is ulong vLastUpdatedValue) { ret.LastUpdated = vLastUpdatedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReputationRecord);
                }
                public bool Equals(ReputationRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReputationRecord left, ReputationRecord right)
                {
                    return EqualityComparer<ReputationRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ReputationRecord left, ReputationRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the admin and authorized escrow application id.
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="escrow_app_id"> </param>
        public async Task Initialize(Algorand.Address admin, ulong escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 220, 85, 187 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address admin, ulong escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 220, 85, 187 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a completed job for the specified wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task RecordSuccess(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 175, 35, 150 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordSuccess_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 175, 35, 150 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a failed job for the specified wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task RecordFailure(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 64, 163, 254 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordFailure_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 64, 163, 254 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a refund for the specified wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task RecordRefund(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 17, 165, 49 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordRefund_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 17, 165, 49 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a dispute for the specified wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task RecordDispute(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 172, 28, 128 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordDispute_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 172, 28, 128 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Recalculate and persist the trust score for the specified wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task UpdateTrustScore(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 96, 81, 248 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateTrustScore_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 96, 81, 248 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the reputation record for the specified wallet.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.ReputationRecord> GetReputation(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 171, 206, 164 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReputationRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetReputation_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 171, 206, 164 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwdXRhdGlvbkNvbnRyYWN0IiwiZGVzYyI6Ik1haW50YWlucyBkZXRlcm1pbmlzdGljIHRydXN0IG1ldHJpY3MgZm9yIGFnZW50cy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUmVwdXRhdGlvblJlY29yZCI6W3sibmFtZSI6IndhbGxldCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3VjY2Vzc2Z1bF9qb2JzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZhaWxlZF9qb2JzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlZnVuZHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGlzcHV0ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidHJ1c3Rfc2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdF91cGRhdGVkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGFkbWluIGFuZCBhdXRob3JpemVkIGVzY3JvdyBhcHBsaWNhdGlvbiBpZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9zdWNjZXNzIiwiZGVzYyI6IlJlY29yZCBhIGNvbXBsZXRlZCBqb2IgZm9yIHRoZSBzcGVjaWZpZWQgd2FsbGV0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9mYWlsdXJlIiwiZGVzYyI6IlJlY29yZCBhIGZhaWxlZCBqb2IgZm9yIHRoZSBzcGVjaWZpZWQgd2FsbGV0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9yZWZ1bmQiLCJkZXNjIjoiUmVjb3JkIGEgcmVmdW5kIGZvciB0aGUgc3BlY2lmaWVkIHdhbGxldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfZGlzcHV0ZSIsImRlc2MiOiJSZWNvcmQgYSBkaXNwdXRlIGZvciB0aGUgc3BlY2lmaWVkIHdhbGxldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfdHJ1c3Rfc2NvcmUiLCJkZXNjIjoiUmVjYWxjdWxhdGUgYW5kIHBlcnNpc3QgdGhlIHRydXN0IHNjb3JlIGZvciB0aGUgc3BlY2lmaWVkIHdhbGxldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVwdXRhdGlvbiIsImRlc2MiOiJSZXR1cm4gdGhlIHJlcHV0YXRpb24gcmVjb3JkIGZvciB0aGUgc3BlY2lmaWVkIHdhbGxldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJSZXB1dGF0aW9uUmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1NV0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NiwyMjIsMjU5LDI5NiwzMzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcHV0YXRpb25zIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNywxNzIsMjA4LDI0NSwyODIsMzE5LDM0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzcsMjEzLDI1MCwyODcsMzI0LDM1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgd2FsbGV0IGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjBdLCJlcnJvck1lc3NhZ2UiOiJ1bmtub3duIHdhbGxldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE15SURFd01DQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnlaWEIxZEdGMGFXOXVjeUlnSW1Ga2JXbHVJaUFpWlhOamNtOTNYMkZ3Y0Y5cFpDSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVMblpoYkhWbElEMGdRV1JrY21WemN5Z3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCelpXeG1MbVZ6WTNKdmQxOWhjSEJmYVdRdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1WelkzSnZkMTloY0hCZmFXUWlDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklHTnNZWE56SUZKbGNIVjBZWFJwYjI1RGIyNTBjbUZqZENoaGNtTTBMa0ZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRObVJrWXpVMVltSWdNSGhrTjJGbU1qTTVOaUF3ZUdSbE5EQmhNMlpsSURCNFpERXhNV0UxTXpFZ01IZzRNMkZqTVdNNE1DQXdlRGd6TmpBMU1XWTRJREI0TjJGaFltTmxZVFFnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbEtHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsWTI5eVpGOXpkV05qWlhOektHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WamIzSmtYMlpoYVd4MWNtVW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXTnZjbVJmY21WbWRXNWtLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVmpiM0prWDJScGMzQjFkR1VvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWZmRISjFjM1JmYzJOdmNtVW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZjbVZ3ZFhSaGRHbHZiaWhoWkdSeVpYTnpLU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2x1YVhScFlXeHBlbVVnY21WamIzSmtYM04xWTJObGMzTWdjbVZqYjNKa1gyWmhhV3gxY21VZ2NtVmpiM0prWDNKbFpuVnVaQ0J5WldOdmNtUmZaR2x6Y0hWMFpTQjFjR1JoZEdWZmRISjFjM1JmYzJOdmNtVWdaMlYwWDNKbGNIVjBZWFJwYjI0S0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjSFYwWVhScGIyNHVZMjl1ZEhKaFkzUXVVbVZ3ZFhSaGRHbHZia052Ym5SeVlXTjBMbWx1YVhScFlXeHBlbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJtbDBhV0ZzYVhwbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWhaRzFwYmk1MllXeDFaU0E5UFNCQlpHUnlaWE56S0Nrc0lDSmhiSEpsWVdSNUlHbHVhWFJwWVd4cGVtVmtJZ29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0ZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCelpXeG1MbUZrYldsdUxuWmhiSFZsSUQwZ1lXUnRhVzRLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNYMkZ3Y0Y5cFpDNTJZV3gxWlNBOUlHVnpZM0p2ZDE5aGNIQmZhV1FLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbVZ6WTNKdmQxOWhjSEJmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVndkWFJoZEdsdmJpNWpiMjUwY21GamRDNVNaWEIxZEdGMGFXOXVRMjl1ZEhKaFkzUXVjbVZqYjNKa1gzTjFZMk5sYzNOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZmMzVmpZMlZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdkMkZzYkdWMElDRTlJRUZrWkhKbGMzTW9LU3dnSW1sdWRtRnNhV1FnZDJGc2JHVjBJR0ZrWkhKbGMzTWlDaUFnSUNCa2RYQUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIZGhiR3hsZENCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z2MyVnNaaTVmWlc1emRYSmxYM0psY0hWMFlYUnBiMjRvZDJGc2JHVjBLUW9nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUY5bGJuTjFjbVZmY21Wd2RYUmhkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1Y21Wd2RYUmhkR2x2Ym5OYmQyRnNiR1YwWFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkpsY0hWMFlYUnBiMjV6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWEIxZEdGMGFXOXVjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QnlaV052Y21RdWMzVmpZMlZ6YzJaMWJGOXFiMkp6SUQwZ1FYSmpORlZKYm5RMk5DaHlaV052Y21RdWMzVmpZMlZ6YzJaMWJGOXFiMkp6TG01aGRHbDJaU0FySUZWSmJuUTJOQ2d4S1NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURNeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1ZmNtVm1jbVZ6YUY5elkyOXlaU2h5WldOdmNtUXBDaUFnSUNCallXeHNjM1ZpSUY5eVpXWnlaWE5vWDNOamIzSmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjSFYwWVhScGIyNHVZMjl1ZEhKaFkzUXVVbVZ3ZFhSaGRHbHZia052Ym5SeVlXTjBMbkpsWTI5eVpGOW1ZV2xzZFhKbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZqYjNKa1gyWmhhV3gxY21VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnWVhOelpYSjBJSGRoYkd4bGRDQWhQU0JCWkdSeVpYTnpLQ2tzSUNKcGJuWmhiR2xrSUhkaGJHeGxkQ0JoWkdSeVpYTnpJZ29nSUNBZ1pIVndDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjNZV3hzWlhRZ1lXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklITmxiR1l1WDJWdWMzVnlaVjl5WlhCMWRHRjBhVzl1S0hkaGJHeGxkQ2tLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZlpXNXpkWEpsWDNKbGNIVjBZWFJwYjI0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG5KbGNIVjBZWFJwYjI1elczZGhiR3hsZEYwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WlhCMWRHRjBhVzl1Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZ3ZFhSaGRHbHZibk1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdjbVZqYjNKa0xtWmhhV3hsWkY5cWIySnpJRDBnUVhKak5GVkpiblEyTkNoeVpXTnZjbVF1Wm1GcGJHVmtYMnB2WW5NdWJtRjBhWFpsSUNzZ1ZVbHVkRFkwS0RFcEtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURRd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdjMlZzWmk1ZmNtVm1jbVZ6YUY5elkyOXlaU2h5WldOdmNtUXBDaUFnSUNCallXeHNjM1ZpSUY5eVpXWnlaWE5vWDNOamIzSmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalF6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjSFYwWVhScGIyNHVZMjl1ZEhKaFkzUXVVbVZ3ZFhSaGRHbHZia052Ym5SeVlXTjBMbkpsWTI5eVpGOXlaV1oxYm1SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZmNtVm1kVzVrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjNZV3hzWlhRZ0lUMGdRV1JrY21WemN5Z3BMQ0FpYVc1MllXeHBaQ0IzWVd4c1pYUWdZV1JrY21WemN5SUtJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2QyRnNiR1YwSUdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCelpXeG1MbDlsYm5OMWNtVmZjbVZ3ZFhSaGRHbHZiaWgzWVd4c1pYUXBDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDJWdWMzVnlaVjl5WlhCMWRHRjBhVzl1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV5WlhCMWRHRjBhVzl1YzF0M1lXeHNaWFJkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljbVZ3ZFhSaGRHbHZibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxjSFYwWVhScGIyNXpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklISmxZMjl5WkM1eVpXWjFibVJ6SUQwZ1FYSmpORlZKYm5RMk5DaHlaV052Y21RdWNtVm1kVzVrY3k1dVlYUnBkbVVnS3lCVlNXNTBOalFvTVNrcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdORGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTkRnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnpaV3htTGw5eVpXWnlaWE5vWDNOamIzSmxLSEpsWTI5eVpDa0tJQ0FnSUdOaGJHeHpkV0lnWDNKbFpuSmxjMmhmYzJOdmNtVUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVndkWFJoZEdsdmJpNWpiMjUwY21GamRDNVNaWEIxZEdGMGFXOXVRMjl1ZEhKaFkzUXVjbVZqYjNKa1gyUnBjM0IxZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZlpHbHpjSFYwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdkMkZzYkdWMElDRTlJRUZrWkhKbGMzTW9LU3dnSW1sdWRtRnNhV1FnZDJGc2JHVjBJR0ZrWkhKbGMzTWlDaUFnSUNCa2RYQUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIZGhiR3hsZENCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z2MyVnNaaTVmWlc1emRYSmxYM0psY0hWMFlYUnBiMjRvZDJGc2JHVjBLUW9nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUY5bGJuTjFjbVZmY21Wd2RYUmhkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5qWUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1Y21Wd2RYUmhkR2x2Ym5OYmQyRnNiR1YwWFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkpsY0hWMFlYUnBiMjV6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWEIxZEdGMGFXOXVjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QnlaV052Y21RdVpHbHpjSFYwWlhNZ1BTQkJjbU0wVlVsdWREWTBLSEpsWTI5eVpDNWthWE53ZFhSbGN5NXVZWFJwZG1VZ0t5QlZTVzUwTmpRb01Ta3BDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTlRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJ6Wld4bUxsOXlaV1p5WlhOb1gzTmpiM0psS0hKbFkyOXlaQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gzSmxabkpsYzJoZmMyTnZjbVVLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZ3ZFhSaGRHbHZiaTVqYjI1MGNtRmpkQzVTWlhCMWRHRjBhVzl1UTI5dWRISmhZM1F1ZFhCa1lYUmxYM1J5ZFhOMFgzTmpiM0psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsWDNSeWRYTjBYM05qYjNKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUdGemMyVnlkQ0IzWVd4c1pYUWdJVDBnUVdSa2NtVnpjeWdwTENBaWFXNTJZV3hwWkNCM1lXeHNaWFFnWVdSa2NtVnpjeUlLSUNBZ0lHUjFjQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkMkZzYkdWMElHRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QnpaV3htTGw5bGJuTjFjbVZmY21Wd2RYUmhkR2x2YmloM1lXeHNaWFFwQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gyVnVjM1Z5WlY5eVpYQjFkR0YwYVc5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1eVpYQjFkR0YwYVc5dWMxdDNZV3hzWlhSZExtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY21Wd2RYUmhkR2x2Ym5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY0hWMFlYUnBiMjV6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJSE5sYkdZdVgzSmxabkpsYzJoZmMyTnZjbVVvY21WamIzSmtLUW9nSUNBZ1kyRnNiSE4xWWlCZmNtVm1jbVZ6YUY5elkyOXlaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEIxZEdGMGFXOXVMbU52Ym5SeVlXTjBMbEpsY0hWMFlYUnBiMjVEYjI1MGNtRmpkQzVuWlhSZmNtVndkWFJoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5eVpYQjFkR0YwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPREVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjNZV3hzWlhRZ0lUMGdRV1JrY21WemN5Z3BMQ0FpYVc1MllXeHBaQ0IzWVd4c1pYUWdZV1JrY21WemN5SUtJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2QyRnNiR1YwSUdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhkaGJHeGxkQ0JwYmlCelpXeG1MbkpsY0hWMFlYUnBiMjV6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WlhCMWRHRjBhVzl1Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZhR0Z6WDNKbGNIVjBZWFJwYjI0b2QyRnNiR1YwS1N3Z0luVnVhMjV2ZDI0Z2QyRnNiR1YwSWdvZ0lDQWdZWE56WlhKMElDOHZJSFZ1YTI1dmQyNGdkMkZzYkdWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Y21Wd2RYUmhkR2x2Ym5OYmQyRnNiR1YwWFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEIxZEdGMGFXOXVMbU52Ym5SeVlXTjBMbEpsY0hWMFlYUnBiMjVEYjI1MGNtRmpkQzVmWlc1emRYSmxYM0psY0hWMFlYUnBiMjRvZDJGc2JHVjBPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tYMlZ1YzNWeVpWOXlaWEIxZEdGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdSbFppQmZaVzV6ZFhKbFgzSmxjSFYwWVhScGIyNG9jMlZzWml3Z2QyRnNiR1YwT2lCQlpHUnlaWE56S1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpRS0lDQWdJQzh2SUhKbGRIVnliaUIzWVd4c1pYUWdhVzRnYzJWc1ppNXlaWEIxZEdGMGFXOXVjd29nSUNBZ1lubDBaV05mTUNBdkx5QWljbVZ3ZFhSaGRHbHZibk1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamcyQ2lBZ0lDQXZMeUJwWmlCdWIzUWdjMlZzWmk1ZmFHRnpYM0psY0hWMFlYUnBiMjRvZDJGc2JHVjBLVG9LSUNBZ0lHSnVlaUJmWlc1emRYSmxYM0psY0hWMFlYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJpOWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnYzNWalkyVnpjMloxYkY5cWIySnpQVUZ5WXpSVlNXNTBOalFvVlVsdWREWTBLREFwS1N3S0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNE55MDVOUW9nSUNBZ0x5OGdjMlZzWmk1eVpYQjFkR0YwYVc5dWMxdDNZV3hzWlhSZElEMGdVbVZ3ZFhSaGRHbHZibEpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0IzWVd4c1pYUTlkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQWdJSE4xWTJObGMzTm1kV3hmYW05aWN6MUJjbU0wVlVsdWREWTBLRlZKYm5RMk5DZ3dLU2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptRnBiR1ZrWDJwdlluTTlRWEpqTkZWSmJuUTJOQ2hWU1c1ME5qUW9NQ2twTEFvZ0lDQWdMeThnSUNBZ0lISmxablZ1WkhNOVFYSmpORlZKYm5RMk5DaFZTVzUwTmpRb01Da3BMQW9nSUNBZ0x5OGdJQ0FnSUdScGMzQjFkR1Z6UFVGeVl6UlZTVzUwTmpRb1ZVbHVkRFkwS0RBcEtTd0tJQ0FnSUM4dklDQWdJQ0IwY25WemRGOXpZMjl5WlQxQmNtTTBWVWx1ZERZMEtGVkpiblEyTkNnd0tTa3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOTFjR1JoZEdWa1BVRnlZelJWU1c1ME5qUW9WVWx1ZERZMEtEQXBLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9LWDJWdWMzVnlaVjl5WlhCMWRHRjBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEIxZEdGMGFXOXVMbU52Ym5SeVlXTjBMbEpsY0hWMFlYUnBiMjVEYjI1MGNtRmpkQzVmY21WbWNtVnphRjl6WTI5eVpTaHlaV052Y21RNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gzSmxabkpsYzJoZmMyTnZjbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNU53b2dJQ0FnTHk4Z1pHVm1JRjl5WldaeVpYTm9YM05qYjNKbEtITmxiR1lzSUhKbFkyOXlaRG9nVW1Wd2RYUmhkR2x2YmxKbFkyOXlaQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUIwYjNSaGJDQTlJSEpsWTI5eVpDNXpkV05qWlhOelpuVnNYMnB2WW5NdWJtRjBhWFpsSUNzZ2NtVmpiM0prTG1aaGFXeGxaRjlxYjJKekxtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklITjFZMk5sYzNOZmNtRjBaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z2FXWWdkRzkwWVd3Z1BpQlZTVzUwTmpRb01DazZDaUFnSUNCaWVpQmZjbVZtY21WemFGOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd01Rb2dJQ0FnTHk4Z2MzVmpZMlZ6YzE5eVlYUmxJRDBnS0hKbFkyOXlaQzV6ZFdOalpYTnpablZzWDJwdlluTXVibUYwYVhabElDb2dWVWx1ZERZMEtERXdNQ2twSUM4dklIUnZkR0ZzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FXNTBZMTh5SUM4dklERXdNQW9nSUNBZ0tnb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJQzhLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9LWDNKbFpuSmxjMmhmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJ5WldaMWJtUmZjbUYwWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5QnBaaUIwYjNSaGJDQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCaWVpQmZjbVZtY21WemFGOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z2NtVm1kVzVrWDNKaGRHVWdQU0FvY21WamIzSmtMbkpsWm5WdVpITXVibUYwYVhabElDb2dWVWx1ZERZMEtERXdNQ2twSUM4dklIUnZkR0ZzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ05EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdDaUFnSUNBcUNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdMd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3BmY21WbWNtVnphRjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNRGNLSUNBZ0lDOHZJR1JwYzNCMWRHVmZjbUYwWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QnBaaUIwYjNSaGJDQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCaWVpQmZjbVZtY21WemFGOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd09Rb2dJQ0FnTHk4Z1pHbHpjSFYwWlY5eVlYUmxJRDBnS0hKbFkyOXlaQzVrYVhOd2RYUmxjeTV1WVhScGRtVWdLaUJWU1c1ME5qUW9NVEF3S1NrZ0x5OGdkRzkwWVd3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQTFOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTWlBdkx5QXhNREFLSUNBZ0lDb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0F2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ2w5eVpXWnlaWE5vWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TVFvZ0lDQWdMeThnY21Wc2FXRmlhV3hwZEhrZ1BTQW9LSE4xWTJObGMzTmZjbUYwWlNBcUlGVkpiblEyTkNnME1Da3BJQzh2SUZWSmJuUTJOQ2d4TURBcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBNQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURFd01Bb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URXlDaUFnSUNBdkx5QnlaV3hwWVdKcGJHbDBlU0FyUFNBb0tISmxablZ1WkY5eVlYUmxJQ29nVlVsdWREWTBLREl3S1NrZ0x5OGdWVWx1ZERZMEtERXdNQ2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeU1Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TUFvZ0lDQWdMd29nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJ5Wld4cFlXSnBiR2wwZVNBclBTQW9LR1JwYzNCMWRHVmZjbUYwWlNBcUlGVkpiblEyTkNneU1Da3BJQzh2SUZWSmJuUTJOQ2d4TURBcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJocGJuUWdNakFLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQUtJQ0FnSUM4S0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeE5Bb2dJQ0FnTHk4Z2NtVnNhV0ZpYVd4cGRIa2dLejBnS0NoemRXTmpaWE56WDNKaGRHVWdLaUJWU1c1ME5qUW9NakFwS1NBdkx5QlZTVzUwTmpRb01UQXdLU2tLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01qQUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBS0lDQWdJQzhLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNVFlLSUNBZ0lDOHZJR2xtSUhKbGJHbGhZbWxzYVhSNUlENGdWVWx1ZERZMEtERXdNQ2s2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3Q2lBZ0lDQStDaUFnSUNCaWVpQmZjbVZtY21WemFGOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z2NtVnNhV0ZpYVd4cGRIa2dQU0JWU1c1ME5qUW9NVEF3S1FvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TUFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2dwZmNtVm1jbVZ6YUY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUhKbFkyOXlaQzUwY25WemRGOXpZMjl5WlNBOUlFRnlZelJWU1c1ME5qUW9jbVZzYVdGaWFXeHBkSGtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEl3Q2lBZ0lDQXZMeUJ5WldOdmNtUXViR0Z6ZEY5MWNHUmhkR1ZrSUQwZ1FYSmpORlZKYm5RMk5DaFZTVzUwTmpRb01Da3BDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUEzTWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qRUtJQ0FnSUM4dklITmxiR1l1Y21Wd2RYUmhkR2x2Ym5OYmNtVmpiM0prTG5kaGJHeGxkRjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSmxjSFYwWVhScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBU0JrQUNZREMzSmxjSFYwWVhScGIyNXpCV0ZrYldsdURXVnpZM0p2ZDE5aGNIQmZhV1F4R0VBQUJ5a3lBMmNxSldjeEcwRUFRREVaRkVReEdFU0NCd1J0M0ZXN0JOZXZJNVlFM2tDai9nVFJFYVV4QklPc0hJQUVnMkJSK0FSNnE4NmtOaG9BamdjQUNRQXNBRkFBZFFDYUFMOEEyd0F4R1JReEdCUVFRellhQVVrVkl4SkVOaG9DU1JXQkNCSkVGeVVwWlVReUF4SkVLVThDWnlwTVp5SkROaG9CU1JVakVrUkpNZ01UUkVtSUFNQW9URkMrUkVrald5SUlGbHdnaUFEWVNDSkROaG9CU1JVakVrUkpNZ01UUkVtSUFKd29URkMrUkVtQktGc2lDQlpjS0lnQXMwZ2lRellhQVVrVkl4SkVTVElERTBSSmlBQjNLRXhRdmtSSmdUQmJJZ2dXWERDSUFJNUlJa00yR2dGSkZTTVNSRWt5QXhORVNZZ0FVaWhNVUw1RVNZRTRXeUlJRmx3NGlBQnBTQ0pETmhvQlNSVWpFa1JKTWdNVFJFbUlBQzBvVEZDK1JJZ0FUVWdpUXpZYUFVa1ZJeEpFU1RJREUwUW9URkJKdlVVQlJMNUlnQVFWSDN4MVRGQ3dJa09LQVFBb2kvOVFTYjFGQVVBQUdTVVdpLzlMQVZCTEFWQkxBVkJMQVZCTEFWQk1VSXNBVEwrSmlnRUJnQUJIQW92L0kxdEppLytCS0ZzSVNTVk1RUUFKaXdNa0M0c0VDb3dGSll3Qml3UkJBQXlMLzRFd1d5UUxpd1FLakFFbGpBQ0xCRUVBREl2L2dUaGJKQXVMQkFxTUFJc0ZTWUVvQ3lRS2l3R0JGQXNrQ2dpTEFJRVVDeVFLQ0V5QkZBc2tDZ2hKakFJa0RVRUFBeVNNQW9zQ0Zvdi9URnhBalA4bEZvdi9URnhJU1l6L1Z3QWdLRXhRaS8rL2kvK01BSWs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
