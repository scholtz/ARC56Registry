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

namespace Arc56.Generated.harsh_mogalgiddikar.cadencia_lending_pool.LoanManager_35563b1b
{


    //
    // 
    //    Central loan management contract.
    //
    //    Access control:
    //        - create_loan: any KYC-verified borrower
    //        - approve_loan / mark_default: oracle only
    //        - repay: borrower of that specific loan
    //        - admin methods: admin only
    //    
    //
    public class LoanManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoanManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class LoanRecord : AVMObjectType
            {
                public Algorand.Address Borrower { get; set; }

                public ulong Amount { get; set; }

                public ulong TenureRounds { get; set; }

                public ulong InterestBps { get; set; }

                public ulong State { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong DisbursedAt { get; set; }

                public ulong DueAt { get; set; }

                public ulong RepaidAmount { get; set; }

                public ulong RepaidAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBorrower.From(Borrower);
                    ret.AddRange(vBorrower.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTenureRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTenureRounds.From(TenureRounds);
                    ret.AddRange(vTenureRounds.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterestBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInterestBps.From(InterestBps);
                    ret.AddRange(vInterestBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vState = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vState.From(State);
                    ret.AddRange(vState.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisbursedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisbursedAt.From(DisbursedAt);
                    ret.AddRange(vDisbursedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDueAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDueAt.From(DueAt);
                    ret.AddRange(vDueAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepaidAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRepaidAmount.From(RepaidAmount);
                    ret.AddRange(vRepaidAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepaidAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRepaidAt.From(RepaidAt);
                    ret.AddRange(vRepaidAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LoanRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LoanRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBorrower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrower = vBorrower.ToValue();
                    if (valueBorrower is Algorand.Address vBorrowerValue) { ret.Borrower = vBorrowerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTenureRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTenureRounds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTenureRounds = vTenureRounds.ToValue();
                    if (valueTenureRounds is ulong vTenureRoundsValue) { ret.TenureRounds = vTenureRoundsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterestBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInterestBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInterestBps = vInterestBps.ToValue();
                    if (valueInterestBps is ulong vInterestBpsValue) { ret.InterestBps = vInterestBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vState = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vState.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueState = vState.ToValue();
                    if (valueState is ulong vStateValue) { ret.State = vStateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisbursedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisbursedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisbursedAt = vDisbursedAt.ToValue();
                    if (valueDisbursedAt is ulong vDisbursedAtValue) { ret.DisbursedAt = vDisbursedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDueAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDueAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDueAt = vDueAt.ToValue();
                    if (valueDueAt is ulong vDueAtValue) { ret.DueAt = vDueAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepaidAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRepaidAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRepaidAmount = vRepaidAmount.ToValue();
                    if (valueRepaidAmount is ulong vRepaidAmountValue) { ret.RepaidAmount = vRepaidAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepaidAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRepaidAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRepaidAt = vRepaidAt.ToValue();
                    if (valueRepaidAt is ulong vRepaidAtValue) { ret.RepaidAt = vRepaidAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LoanRecord);
                }
                public bool Equals(LoanRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LoanRecord left, LoanRecord right)
                {
                    return EqualityComparer<LoanRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(LoanRecord left, LoanRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the LoanManager. Called once at deployment.
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="oracle"> </param>
        /// <param name="kyc_registry_id"> </param>
        /// <param name="credit_score_id"> </param>
        /// <param name="lending_pool_id"> </param>
        public async Task Create(Algorand.Address admin, Algorand.Address oracle, ulong kyc_registry_id, ulong credit_score_id, ulong lending_pool_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 58, 27, 181 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);
            var kyc_registry_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); kyc_registry_idAbi.From(kyc_registry_id);
            var credit_score_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credit_score_idAbi.From(credit_score_id);
            var lending_pool_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lending_pool_idAbi.From(lending_pool_id);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, oracleAbi, kyc_registry_idAbi, credit_score_idAbi, lending_pool_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address admin, Algorand.Address oracle, ulong kyc_registry_id, ulong credit_score_id, ulong lending_pool_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 58, 27, 181 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);
            var kyc_registry_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); kyc_registry_idAbi.From(kyc_registry_id);
            var credit_score_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credit_score_idAbi.From(credit_score_id);
            var lending_pool_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lending_pool_idAbi.From(lending_pool_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, oracleAbi, kyc_registry_idAbi, credit_score_idAbi, lending_pool_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the RepaymentEscrow app ID. Admin-only.
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task SetEscrow(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 118, 3, 241 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEscrow_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 118, 3, 241 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency pause/unpause. Admin-only.
        ///</summary>
        /// <param name="paused"> </param>
        public async Task SetPaused(bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 8, 80, 253 };
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            var result = await base.CallApp(new List<object> { abiHandle, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPaused_Transactions(bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 8, 80, 253 };
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            return await base.MakeTransactionList(new List<object> { abiHandle, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new loan request. Caller must be KYC-verified.
        ///Returns the loan_id.
        ///Caller must include a payment transaction covering box MBR for the new loan record box.
        ///Enforces:     - Borrower must be KYC verified (via KYCRegistry foreign read)     - Borrower must not have another active loan     - Amount must be within the score-based cap
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="tenure_rounds"> </param>
        /// <param name="interest_bps"> </param>
        public async Task<ulong> CreateLoan(ulong amount, ulong tenure_rounds, ulong interest_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 83, 240, 213 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var tenure_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tenure_roundsAbi.From(tenure_rounds);
            var interest_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interest_bpsAbi.From(interest_bps);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, tenure_roundsAbi, interest_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateLoan_Transactions(ulong amount, ulong tenure_rounds, ulong interest_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 83, 240, 213 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var tenure_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tenure_roundsAbi.From(tenure_rounds);
            var interest_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interest_bpsAbi.From(interest_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, tenure_roundsAbi, interest_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approve a pending loan and disburse funds. Oracle-only.
        ///Atomically:     1. Set loan state to ACTIVE     2. Call LendingPool.disburse() to send ALGO to borrower     3. Record the active loan for the borrower
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task ApproveAndDisburse(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 172, 59, 103 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveAndDisburse_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 172, 59, 103 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Repay a loan. Called by the borrower.
        ///The borrower must include a PaymentTransaction to this app address as a preceding transaction in the group.
        ///</summary>
        /// <param name="loan_id"> </param>
        /// <param name="payment"> </param>
        public async Task Repay(PaymentTransaction payment, ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 65, 138, 42, 79 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Repay_Transactions(PaymentTransaction payment, ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 65, 138, 42, 79 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark a loan as defaulted. Oracle-only.
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task MarkDefault(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 115, 72, 61 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.CallApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkDefault_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 115, 72, 61 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a loan record by ID. Reverts if not found.
        ///</summary>
        /// <param name="loan_id"> </param>
        public async Task<Structs.LoanRecord> GetLoan(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 238, 114, 102 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            var result = await base.SimApp(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LoanRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetLoan_Transactions(ulong loan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 238, 114, 102 };
            var loan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); loan_idAbi.From(loan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, loan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the active loan ID for a borrower. Returns max uint64 if none.
        ///</summary>
        /// <param name="borrower"> </param>
        public async Task<ulong> GetActiveLoanId(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 225, 131, 193 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.SimApp(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetActiveLoanId_Transactions(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 225, 131, 193 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Total number of loans ever created.
        ///</summary>
        public async Task<ulong> GetLoanCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 138, 62, 244 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetLoanCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 138, 62, 244 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Number of currently active loans.
        ///</summary>
        public async Task<ulong> GetActiveCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 61, 16, 147 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetActiveCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 61, 16, 147 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9hbk1hbmFnZXIiLCJkZXNjIjoiXG4gICAgQ2VudHJhbCBsb2FuIG1hbmFnZW1lbnQgY29udHJhY3QuXG5cbiAgICBBY2Nlc3MgY29udHJvbDpcbiAgICAgICAgLSBjcmVhdGVfbG9hbjogYW55IEtZQy12ZXJpZmllZCBib3Jyb3dlclxuICAgICAgICAtIGFwcHJvdmVfbG9hbiAvIG1hcmtfZGVmYXVsdDogb3JhY2xlIG9ubHlcbiAgICAgICAgLSByZXBheTogYm9ycm93ZXIgb2YgdGhhdCBzcGVjaWZpYyBsb2FuXG4gICAgICAgIC0gYWRtaW4gbWV0aG9kczogYWRtaW4gb25seVxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMb2FuUmVjb3JkIjpbeyJuYW1lIjoiYm9ycm93ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0ZW51cmVfcm91bmRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImludGVyZXN0X2JwcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRpc2J1cnNlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkdWVfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVwYWlkX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZXBhaWRfYXQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBMb2FuTWFuYWdlci4gQ2FsbGVkIG9uY2UgYXQgZGVwbG95bWVudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JhY2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJreWNfcmVnaXN0cnlfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWRpdF9zY29yZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZGluZ19wb29sX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9lc2Nyb3ciLCJkZXNjIjoiU2V0IHRoZSBSZXBheW1lbnRFc2Nyb3cgYXBwIElELiBBZG1pbi1vbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3BhdXNlZCIsImRlc2MiOiJFbWVyZ2VuY3kgcGF1c2UvdW5wYXVzZS4gQWRtaW4tb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdXNlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfbG9hbiIsImRlc2MiOiJDcmVhdGUgYSBuZXcgbG9hbiByZXF1ZXN0LiBDYWxsZXIgbXVzdCBiZSBLWUMtdmVyaWZpZWQuXG5SZXR1cm5zIHRoZSBsb2FuX2lkLlxuQ2FsbGVyIG11c3QgaW5jbHVkZSBhIHBheW1lbnQgdHJhbnNhY3Rpb24gY292ZXJpbmcgYm94IE1CUiBmb3IgdGhlIG5ldyBsb2FuIHJlY29yZCBib3guXG5FbmZvcmNlczogICAgIC0gQm9ycm93ZXIgbXVzdCBiZSBLWUMgdmVyaWZpZWQgKHZpYSBLWUNSZWdpc3RyeSBmb3JlaWduIHJlYWQpICAgICAtIEJvcnJvd2VyIG11c3Qgbm90IGhhdmUgYW5vdGhlciBhY3RpdmUgbG9hbiAgICAgLSBBbW91bnQgbXVzdCBiZSB3aXRoaW4gdGhlIHNjb3JlLWJhc2VkIGNhcCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRlbnVyZV9yb3VuZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0X2JwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmVfYW5kX2Rpc2J1cnNlIiwiZGVzYyI6IkFwcHJvdmUgYSBwZW5kaW5nIGxvYW4gYW5kIGRpc2J1cnNlIGZ1bmRzLiBPcmFjbGUtb25seS5cbkF0b21pY2FsbHk6ICAgICAxLiBTZXQgbG9hbiBzdGF0ZSB0byBBQ1RJVkUgICAgIDIuIENhbGwgTGVuZGluZ1Bvb2wuZGlzYnVyc2UoKSB0byBzZW5kIEFMR08gdG8gYm9ycm93ZXIgICAgIDMuIFJlY29yZCB0aGUgYWN0aXZlIGxvYW4gZm9yIHRoZSBib3Jyb3dlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2FuX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcGF5IiwiZGVzYyI6IlJlcGF5IGEgbG9hbi4gQ2FsbGVkIGJ5IHRoZSBib3Jyb3dlci5cblRoZSBib3Jyb3dlciBtdXN0IGluY2x1ZGUgYSBQYXltZW50VHJhbnNhY3Rpb24gdG8gdGhpcyBhcHAgYWRkcmVzcyBhcyBhIHByZWNlZGluZyB0cmFuc2FjdGlvbiBpbiB0aGUgZ3JvdXAuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxvYW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya19kZWZhdWx0IiwiZGVzYyI6Ik1hcmsgYSBsb2FuIGFzIGRlZmF1bHRlZC4gT3JhY2xlLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxvYW5faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2xvYW4iLCJkZXNjIjoiR2V0IGEgbG9hbiByZWNvcmQgYnkgSUQuIFJldmVydHMgaWYgbm90IGZvdW5kLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2FuX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkxvYW5SZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hY3RpdmVfbG9hbl9pZCIsImRlc2MiOiJHZXQgdGhlIGFjdGl2ZSBsb2FuIElEIGZvciBhIGJvcnJvd2VyLiBSZXR1cm5zIG1heCB1aW50NjQgaWYgbm9uZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbG9hbl9jb3VudCIsImRlc2MiOiJUb3RhbCBudW1iZXIgb2YgbG9hbnMgZXZlciBjcmVhdGVkLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FjdGl2ZV9jb3VudCIsImRlc2MiOiJOdW1iZXIgb2YgY3VycmVudGx5IGFjdGl2ZSBsb2Fucy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo3LCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzg5XSwiZXJyb3JNZXNzYWdlIjoiYWN0aXZlIGxvYW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzcyXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hY3RpdmVfbG9hbl9ieV9ib3Jyb3dlciBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzUsNzUyLDg4MCw5NjNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFjdGl2ZV9sb2FucyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTIsMzM1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODYsNzY3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5sZW5kaW5nX3Bvb2xfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA2LDk1Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubG9hbl9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OCw4MjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9yYWNsZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzYsNTA1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXVzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYwXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDYsMjE0LDkyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjIsMjMxLDI0MCwzMDQsMzUzLDM2MSwzNzEsNDkwLDYyOSw4MjAsODk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0ZW51cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjMsODUwXSwiZXJyb3JNZXNzYWdlIjoibG9hbiBub3QgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE3LDY1Myw4MzksOTA1XSwiZXJyb3JNZXNzYWdlIjoibG9hbiBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjZdLCJlcnJvck1lc3NhZ2UiOiJsb2FuIG5vdCBwZW5kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjcyXSwiZXJyb3JNZXNzYWdlIjoibm90IHRoZSBib3Jyb3dlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNCwzMzddLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAwLDgzMF0sImVycm9yTWVzc2FnZSI6Im9ubHkgb3JhY2xlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc4LDUwN10sImVycm9yTWVzc2FnZSI6InBhdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4MF0sImVycm9yTWVzc2FnZSI6InBheSB0byBMb2FuTWFuYWdlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMV0sImVycm9yTWVzc2FnZSI6InRlbnVyZSB0b28gbG9uZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWVdOMGFYWmxJaUF3ZURZeE5qTTNORFpqTldZZ01IZzJZelptTmpFMlpUVm1JREI0TVRVeFpqZGpOelVnSW14dllXNWZZM1J5SWlBaWNHRjFjMlZrSWlBaVlXUnRhVzRpSUNKdmNtRmpiR1VpSUNKd2IyOXNYMmxrSWlBaVpYTmpjbTkzWDJsa0lpQXdlREF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TURBd01EQXdNREF3TURBd01EQTBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZOekFLSUNBZ0lDOHZJR05zWVhOeklFeHZZVzVOWVc1aFoyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUyQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TVdFM05qQXpaakVnTUhobFl6QTROVEJtWkNBd2VEQmtOVE5tTUdRMUlEQjRNVFpoWXpOaU5qY2dNSGcwTVRoaE1tRTBaaUF3ZURoaE56TTBPRE5rSURCNE5UVmxaVGN5TmpZZ01IaGpNR1V4T0ROak1TQXdlRFV3T0dFelpXWTBJREI0TmpBelpERXdPVE1nTHk4Z2JXVjBhRzlrSUNKelpYUmZaWE5qY205M0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZmNHRjFjMlZrS0dKdmIyd3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsWDJ4dllXNG9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0poY0hCeWIzWmxYMkZ1WkY5a2FYTmlkWEp6WlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZ3WVhrb2RXbHVkRFkwTEhCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdFlYSnJYMlJsWm1GMWJIUW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXNiMkZ1S0hWcGJuUTJOQ2tvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1kbGRGOWhZM1JwZG1WZmJHOWhibDlwWkNoaFpHUnlaWE56S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyeHZZVzVmWTI5MWJuUW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDJGamRHbDJaVjlqYjNWdWRDZ3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2djMlYwWDJWelkzSnZkeUJ6WlhSZmNHRjFjMlZrSUdOeVpXRjBaVjlzYjJGdUlHRndjSEp2ZG1WZllXNWtYMlJwYzJKMWNuTmxJSEpsY0dGNUlHMWhjbXRmWkdWbVlYVnNkQ0JuWlhSZmJHOWhiaUJuWlhSZllXTjBhWFpsWDJ4dllXNWZhV1FnWjJWMFgyeHZZVzVmWTI5MWJuUWdaMlYwWDJGamRHbDJaVjlqYjNWdWRBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTJPZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZURzloYmsxaGJtRm5aWEl2Ykc5aGJsOXRZVzVoWjJWeUxuQjVPamN3Q2lBZ0lDQXZMeUJqYkdGemN5Qk1iMkZ1VFdGdVlXZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE16SXpZVEZpWWpVZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklHTmhaR1Z1WTJsaExreHZZVzVOWVc1aFoyVnlMbXh2WVc1ZmJXRnVZV2RsY2k1TWIyRnVUV0Z1WVdkbGNpNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1UQTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNYjJGdVRXRnVZV2RsY2k5c2IyRnVYMjFoYm1GblpYSXVjSGs2TVRFMENpQWdJQ0F2THlCelpXeG1MbUZrYldsdUxuWmhiSFZsSUQwZ1lXUnRhVzRLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFeE5Rb2dJQ0FnTHk4Z2MyVnNaaTV2Y21GamJHVXVkbUZzZFdVZ1BTQnZjbUZqYkdVS0lDQWdJR0o1ZEdWaklEY2dMeThnSW05eVlXTnNaU0lLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3hNVFlLSUNBZ0lDOHZJSE5sYkdZdWEzbGpYM0psWjJsemRISjVYMmxrTG5aaGJIVmxJRDBnYTNsalgzSmxaMmx6ZEhKNVgybGtDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltdDVZMTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG94TVRjS0lDQWdJQzh2SUhObGJHWXVZM0psWkdsMFgzTmpiM0psWDJsa0xuWmhiSFZsSUQwZ1kzSmxaR2wwWDNOamIzSmxYMmxrQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk5qYjNKbFgybGtJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qRXhPQW9nSUNBZ0x5OGdjMlZzWmk1c1pXNWthVzVuWDNCdmIyeGZhV1F1ZG1Gc2RXVWdQU0JzWlc1a2FXNW5YM0J2YjJ4ZmFXUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luQnZiMnhmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qRXhPUW9nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2RmYVdRdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1WelkzSnZkMTlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFeU1Bb2dJQ0FnTHk4Z2MyVnNaaTVzYjJGdVgyTnZkVzUwWlhJdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW14dllXNWZZM1J5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNYjJGdVRXRnVZV2RsY2k5c2IyRnVYMjFoYm1GblpYSXVjSGs2TVRJeENpQWdJQ0F2THlCelpXeG1MbUZqZEdsMlpWOXNiMkZ1Y3k1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdOMGFYWmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNVEl5Q2lBZ0lDQXZMeUJ6Wld4bUxuQmhkWE5sWkM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNVEEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCallXUmxibU5wWVM1TWIyRnVUV0Z1WVdkbGNpNXNiMkZ1WDIxaGJtRm5aWEl1VEc5aGJrMWhibUZuWlhJdWMyVjBYMlZ6WTNKdmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5bGMyTnliM2M2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNYjJGdVRXRnVZV2RsY2k5c2IyRnVYMjFoYm1GblpYSXVjSGs2TVRJMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveE1qY0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0p2Ym14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR0ZrYldsdUNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1USTRDaUFnSUNBdkx5QnpaV3htTG1WelkzSnZkMTlwWkM1MllXeDFaU0E5SUdGd2NGOXBaQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlaWE5qY205M1gybGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG94TWpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTmhaR1Z1WTJsaExreHZZVzVOWVc1aFoyVnlMbXh2WVc1ZmJXRnVZV2RsY2k1TWIyRnVUV0Z1WVdkbGNpNXpaWFJmY0dGMWMyVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgzQmhkWE5sWkRvS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveE16QUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveE16TUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0p2Ym14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR0ZrYldsdUNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1UTTBDaUFnSUNBdkx5QnpaV3htTG5CaGRYTmxaQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3hLU0JwWmlCd1lYVnpaV1F1Ym1GMGFYWmxJR1ZzYzJVZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKd1lYVnpaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFek1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMkZrWlc1amFXRXVURzloYmsxaGJtRm5aWEl1Ykc5aGJsOXRZVzVoWjJWeUxreHZZVzVOWVc1aFoyVnlMbU55WldGMFpWOXNiMkZ1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJ4dllXNDZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNVE0yQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qRTFOUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Y0dGMWMyVmtMblpoYkhWbElEMDlJRlZKYm5RMk5DZ3dLU3dnSW5CaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSndZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklIQmhkWE5sWkFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFMU5nb2dJQ0FnTHk4Z1ltOXljbTkzWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1UVTRMVEUxT1FvZ0lDQWdMeThnSXlCRmJtWnZjbU5sT2lCdWJ5QmxlR2x6ZEdsdVp5QmhZM1JwZG1VZ2JHOWhiZ29nSUNBZ0x5OGdZWE56WlhKMElHSnZjbkp2ZDJWeUlHNXZkQ0JwYmlCelpXeG1MbUZqZEdsMlpWOXNiMkZ1WDJKNVgySnZjbkp2ZDJWeUxDQWlZV04wYVhabElHeHZZVzRnWlhocGMzUnpJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFl4TmpNM05EWmpOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdGamRHbDJaU0JzYjJGdUlHVjRhWE4wY3dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFMk1TMHhOaklLSUNBZ0lDOHZJQ01nVm1Gc2FXUmhkR1VnZEdWdWRYSmxDaUFnSUNBdkx5QmhjM05sY25RZ2RHVnVkWEpsWDNKdmRXNWtjeUErSUZWSmJuUTJOQ2d3S1N3Z0ltbHVkbUZzYVdRZ2RHVnVkWEpsSWdvZ0lDQWdaR2xuSURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJsYm5WeVpRb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qRTJNd29nSUNBZ0x5OGdZWE56WlhKMElIUmxiblZ5WlY5eWIzVnVaSE1nUEQwZ1RVRllYMVJGVGxWU1JWOVNUMVZPUkZNc0lDSjBaVzUxY21VZ2RHOXZJR3h2Ym1jaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ09EWTBNREF3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBaVzUxY21VZ2RHOXZJR3h2Ym1jS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveE5qVXRNVFkyQ2lBZ0lDQXZMeUFqSUVGemMybG5iaUJzYjJGdUlFbEVDaUFnSUNBdkx5QnNiMkZ1WDJsa0lEMGdjMlZzWmk1c2IyRnVYMk52ZFc1MFpYSXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pzYjJGdVgyTjBjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c2IyRnVYMk52ZFc1MFpYSWdaWGhwYzNSekNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1UWTNDaUFnSUNBdkx5QnpaV3htTG14dllXNWZZMjkxYm5SbGNpNTJZV3gxWlNBOUlHeHZZVzVmYVdRZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WVc1ZlkzUnlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG94TnpZS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFMk9TMHhPREVLSUNBZ0lDOHZJQ01nUTNKbFlYUmxJR3h2WVc0Z2NtVmpiM0prQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0JNYjJGdVVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lHSnZjbkp2ZDJWeVBXRnlZelF1UVdSa2NtVnpjeWhpYjNKeWIzZGxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtHRnRiM1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdkR1Z1ZFhKbFgzSnZkVzVrY3oxaGNtTTBMbFZKYm5RMk5DaDBaVzUxY21WZmNtOTFibVJ6S1N3S0lDQWdJQzh2SUNBZ0lDQnBiblJsY21WemRGOWljSE05WVhKak5DNVZTVzUwTmpRb2FXNTBaWEpsYzNSZlluQnpLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBaVDFoY21NMExsVkpiblEyTkNoVFZFRlVSVjlRUlU1RVNVNUhLU3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdaR2x6WW5WeWMyVmtYMkYwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSMVpWOWhkRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J5WlhCaGFXUmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lISmxjR0ZwWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFM05Rb2dJQ0FnTHk4Z2MzUmhkR1U5WVhKak5DNVZTVzUwTmpRb1UxUkJWRVZmVUVWT1JFbE9SeWtzQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG94TmprdE1UZ3hDaUFnSUNBdkx5QWpJRU55WldGMFpTQnNiMkZ1SUhKbFkyOXlaQW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdURzloYmxKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCaWIzSnliM2RsY2oxaGNtTTBMa0ZrWkhKbGMzTW9ZbTl5Y205M1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoY21NMExsVkpiblEyTkNoaGJXOTFiblFwTEFvZ0lDQWdMeThnSUNBZ0lIUmxiblZ5WlY5eWIzVnVaSE05WVhKak5DNVZTVzUwTmpRb2RHVnVkWEpsWDNKdmRXNWtjeWtzQ2lBZ0lDQXZMeUFnSUNBZ2FXNTBaWEpsYzNSZlluQnpQV0Z5WXpRdVZVbHVkRFkwS0dsdWRHVnlaWE4wWDJKd2N5a3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRHVTlZWEpqTkM1VlNXNTBOalFvVTFSQlZFVmZVRVZPUkVsT1J5a3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lHUnBjMkoxY25ObFpGOWhkRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JrZFdWZllYUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZ3WVdsa1gyRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpYQmhhV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNVGd5Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZVzV6VzJ4dllXNWZhV1JkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFpqTm1ZMk1UWmxOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pFek5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMkZrWlc1amFXRXVURzloYmsxaGJtRm5aWEl1Ykc5aGJsOXRZVzVoWjJWeUxreHZZVzVOWVc1aFoyVnlMbUZ3Y0hKdmRtVmZZVzVrWDJScGMySjFjbk5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYQndjbTkyWlY5aGJtUmZaR2x6WW5WeWMyVTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNVGcyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG94T1RZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNKaFkyeGxMblpoYkhWbExDQWliMjVzZVNCdmNtRmpiR1VpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWIzSmhZMnhsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXlZV05zWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0J2Y21GamJHVUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3hPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5CaGRYTmxaQzUyWVd4MVpTQTlQU0JWU1c1ME5qUW9NQ2tzSUNKd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWljR0YxYzJWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJoZFhObFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWFZ6WldRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveE9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCc2IyRnVYMmxrSUdsdUlITmxiR1l1Ykc5aGJuTXNJQ0pzYjJGdUlHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJZelptTmpFMlpUVm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUd4dllXNGdibTkwSUdadmRXNWtDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNakF3Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxteHZZVzV6VzJ4dllXNWZhV1JkTG1OdmNIa29LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TURFS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEdVdWJtRjBhWFpsSUQwOUlGTlVRVlJGWDFCRlRrUkpUa2NzSUNKc2IyRnVJRzV2ZENCd1pXNWthVzVuSWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEVTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUd4dllXNGdibTkwSUhCbGJtUnBibWNLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TURNS0lDQWdJQzh2SUdKdmNuSnZkMlZ5SUQwZ2NtVmpiM0prTG1KdmNuSnZkMlZ5TG01aGRHbDJaUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lNRFV0TWpBMkNpQWdJQ0F2THlBaklGVndaR0YwWlNCc2IyRnVJSE4wWVhSbENpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGRHVWdQU0JoY21NMExsVkpiblEyTkNoVFZFRlVSVjlCUTFSSlZrVXBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBeUNpQWdJQ0J5WlhCc1lXTmxNaUExTmdvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pJd053b2dJQ0FnTHk4Z2NtVmpiM0prTG1ScGMySjFjbk5sWkY5aGRDQTlJR0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTnpJS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveU1EZ0tJQ0FnSUM4dklISmxZMjl5WkM1a2RXVmZZWFFnUFNCaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFnS3lCeVpXTnZjbVF1ZEdWdWRYSmxYM0p2ZFc1a2N5NXVZWFJwZG1VcENpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ09EQUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lNRGtLSUNBZ0lDOHZJSE5sYkdZdWJHOWhibk5iYkc5aGJsOXBaRjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNakV4TFRJeE1nb2dJQ0FnTHk4Z0l5QlVjbUZqYXlCaFkzUnBkbVVnYkc5aGJnb2dJQ0FnTHk4Z2MyVnNaaTVoWTNScGRtVmZiRzloYmw5aWVWOWliM0p5YjNkbGNsdGliM0p5YjNkbGNsMGdQU0JzYjJGdVgybGtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROakUyTXpjME5tTTFaZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNYjJGdVRXRnVZV2RsY2k5c2IyRnVYMjFoYm1GblpYSXVjSGs2TWpFekNpQWdJQ0F2THlCelpXeG1MbUZqZEdsMlpWOXNiMkZ1Y3k1MllXeDFaU0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdOMGFYWmxYMnh2WVc1eklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmpkR2wyWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1qRTFMVEl5TmdvZ0lDQWdMeThnSXlCRFlXeHNJRXhsYm1ScGJtZFFiMjlzTG1ScGMySjFjbk5sSU9LQWxDQnBibTVsY2lCaGNIQnNhV05oZEdsdmJpQmpZV3hzQ2lBZ0lDQXZMeUFqSUdGeVl6UXVRV1JrY21WemN5QmpiMjF3YVd4bGN5QjBieUJCUWtrZ2RIbHdaU0FpWVdSa2NtVnpjeUlnNG9hU0lITmxiR1ZqZEc5eUlHWnZjaUJrYVhOaWRYSnpaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrQ2lBZ0lDQXZMeUJwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROWMyVnNaaTVzWlc1a2FXNW5YM0J2YjJ4ZmFXUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJGeVozTTlLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0prYVhOaWRYSnpaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVRV1JrY21WemN5aGliM0p5YjNkbGNpa3VZbmwwWlhNc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtISmxZMjl5WkM1aGJXOTFiblF1Ym1GMGFYWmxLUzVpZVhSbGN5d0tJQ0FnSUM4dklDQWdJQ0FwTEFvZ0lDQWdMeThnSUNBZ0lHRmpZMjkxYm5SelBTaGliM0p5YjNkbGNpd3BMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qSXhPQW9nSUNBZ0x5OGdZWEJ3WDJsa1BYTmxiR1l1YkdWdVpHbHVaMTl3YjI5c1gybGtMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5CdmIyeGZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHVnVaR2x1WjE5d2IyOXNYMmxrSUdWNGFYTjBjd29nSUNBZ0x5OGdZMkZrWlc1amFXRXZURzloYmsxaGJtRm5aWEl2Ykc5aGJsOXRZVzVoWjJWeUxuQjVPakl5TWdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2NtVmpiM0prTG1GdGIzVnVkQzV1WVhScGRtVXBMbUo1ZEdWekxBb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBNENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQlkyTnZkVzUwY3dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pJeU1Bb2dJQ0FnTHk4Z1lYSmpOQzVoY21NMFgzTnBaMjVoZEhWeVpTZ2laR2x6WW5WeWMyVW9ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpFM016QmxaVElnTHk4Z2JXVjBhRzlrSUNKa2FYTmlkWEp6WlNoaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lNVFV0TWpFM0NpQWdJQ0F2THlBaklFTmhiR3dnVEdWdVpHbHVaMUJ2YjJ3dVpHbHpZblZ5YzJVZzRvQ1VJR2x1Ym1WeUlHRndjR3hwWTJGMGFXOXVJR05oYkd3S0lDQWdJQzh2SUNNZ1lYSmpOQzVCWkdSeVpYTnpJR052YlhCcGJHVnpJSFJ2SUVGQ1NTQjBlWEJsSUNKaFpHUnlaWE56SWlEaWhwSWdjMlZzWldOMGIzSWdabTl5SUdScGMySjFjbk5sS0dGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRS0lDQWdJQzh2SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lNalVLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1qRTFMVEl5TmdvZ0lDQWdMeThnSXlCRFlXeHNJRXhsYm1ScGJtZFFiMjlzTG1ScGMySjFjbk5sSU9LQWxDQnBibTVsY2lCaGNIQnNhV05oZEdsdmJpQmpZV3hzQ2lBZ0lDQXZMeUFqSUdGeVl6UXVRV1JrY21WemN5QmpiMjF3YVd4bGN5QjBieUJCUWtrZ2RIbHdaU0FpWVdSa2NtVnpjeUlnNG9hU0lITmxiR1ZqZEc5eUlHWnZjaUJrYVhOaWRYSnpaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrQ2lBZ0lDQXZMeUJwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROWMyVnNaaTVzWlc1a2FXNW5YM0J2YjJ4ZmFXUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJGeVozTTlLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0prYVhOaWRYSnpaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVRV1JrY21WemN5aGliM0p5YjNkbGNpa3VZbmwwWlhNc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtISmxZMjl5WkM1aGJXOTFiblF1Ym1GMGFYWmxLUzVpZVhSbGN5d0tJQ0FnSUM4dklDQWdJQ0FwTEFvZ0lDQWdMeThnSUNBZ0lHRmpZMjkxYm5SelBTaGliM0p5YjNkbGNpd3BMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3hPRFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOaFpHVnVZMmxoTGt4dllXNU5ZVzVoWjJWeUxteHZZVzVmYldGdVlXZGxjaTVNYjJGdVRXRnVZV2RsY2k1eVpYQmhlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGNHRjVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lNamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1qTTJDaUFnSUNBdkx5QmhjM05sY25RZ2JHOWhibDlwWkNCcGJpQnpaV3htTG14dllXNXpMQ0FpYkc5aGJpQnViM1FnWm05MWJtUWlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObU0yWmpZeE5tVTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2JHOWhiaUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TXpnS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXViRzloYm5OYmJHOWhibDlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveU16a0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRHVXVibUYwYVhabElEMDlJRk5VUVZSRlgwRkRWRWxXUlN3Z0lteHZZVzRnYm05MElHRmpkR2wyWlNJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJzYjJGdUlHNXZkQ0JoWTNScGRtVUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzVpYjNKeWIzZGxjaTV1WVhScGRtVXNJQ0p1YjNRZ2RHaGxJR0p2Y25KdmQyVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2RHaGxJR0p2Y25KdmQyVnlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNalF4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpY0dGNUlIUnZJRXh2WVc1TllXNWhaMlZ5SWdvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3WVhrZ2RHOGdURzloYmsxaGJtRm5aWElLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TkRNS0lDQWdJQzh2SUhKbGNHRjVYMkZ0YjNWdWRDQTlJSEJoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qSTBOUzB5TkRZS0lDQWdJQzh2SUNNZ1ZYQmtZWFJsSUhKbGNHRnBaQ0JoYlc5MWJuUUtJQ0FnSUM4dklHNWxkMTkwYjNSaGJDQTlJSEpsWTI5eVpDNXlaWEJoYVdSZllXMXZkVzUwTG01aGRHbDJaU0FySUhKbGNHRjVYMkZ0YjNWdWRBb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FyQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNYjJGdVRXRnVZV2RsY2k5c2IyRnVYMjFoYm1GblpYSXVjSGs2TWpRM0NpQWdJQ0F2THlCeVpXTnZjbVF1Y21Wd1lXbGtYMkZ0YjNWdWRDQTlJR0Z5WXpRdVZVbHVkRFkwS0c1bGQxOTBiM1JoYkNrS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBNE9Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNalE1TFRJMU13b2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCcFppQm1kV3hzZVNCeVpYQmhhV1FnS0dGdGIzVnVkQ0FySUdsdWRHVnlaWE4wS1FvZ0lDQWdMeThnSXlCSmJuUmxjbVZ6ZENCallXeGpkV3hoZEdsdmJqb2dZVzF2ZFc1MElDb2dhVzUwWlhKbGMzUmZZbkJ6SUNvZ2RHVnVkWEpsWDNKdmRXNWtjeUF2SUNnek5qVmZaR0Y1YzE5cGJsOXliM1Z1WkhNZ0tpQXhNREF3TUNrS0lDQWdJQzh2SUNNZ1JtOXlJRTFXVUNCemFXMXdiR2xqYVhSNUxDQjNaU0JqYUdWamF5QmhaMkZwYm5OMElIUm9aU0J2Y21sbmFXNWhiQ0JoYlc5MWJuUUtJQ0FnSUM4dklDTWdLR1oxYkd3Z2FXNTBaWEpsYzNRZ1kyRnNZM1ZzWVhScGIyNGdaRzl1WlNCdlptWXRZMmhoYVc0Z1lua2diM0poWTJ4bEtRb2dJQ0FnTHk4Z2RHOTBZV3hmWkhWbElEMGdjbVZqYjNKa0xtRnRiM1Z1ZEM1dVlYUnBkbVVnSUNNZ1UybHRjR3hwWm1sbFpEb2diM0poWTJ4bElHaGhibVJzWlhNZ2FXNTBaWEpsYzNRS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveU5UVUtJQ0FnSUM4dklHbG1JRzVsZDE5MGIzUmhiQ0ErUFNCMGIzUmhiRjlrZFdVNkNpQWdJQ0ErUFFvZ0lDQWdZbm9nY21Wd1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1qVTJDaUFnSUNBdkx5QnlaV052Y21RdWMzUmhkR1VnUFNCaGNtTTBMbFZKYm5RMk5DaFRWRUZVUlY5U1JWQkJTVVFwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ETUtJQ0FnSUhKbGNHeGhZMlV5SURVMkNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1qVTNDaUFnSUNBdkx5QnlaV052Y21RdWNtVndZV2xrWDJGMElEMGdZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbkp2ZFc1a0tRb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUE1TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveU5Ua3RNall3Q2lBZ0lDQXZMeUFqSUZKbGJXOTJaU0JoWTNScGRtVWdiRzloYmlCMGNtRmphMlZ5Q2lBZ0lDQXZMeUJwWmlCeVpXTnZjbVF1WW05eWNtOTNaWEl1Ym1GMGFYWmxJR2x1SUhObGJHWXVZV04wYVhabFgyeHZZVzVmWW5sZlltOXljbTkzWlhJNkNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMk1UWXpOelEyWXpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTFDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUhKbGNHRjVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qSTJNUW9nSUNBZ0x5OGdaR1ZzSUhObGJHWXVZV04wYVhabFgyeHZZVzVmWW5sZlltOXljbTkzWlhKYmNtVmpiM0prTG1KdmNuSnZkMlZ5TG01aGRHbDJaVjBLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0NuSmxjR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TmpJS0lDQWdJQzh2SUhObGJHWXVZV04wYVhabFgyeHZZVzV6TG5aaGJIVmxJQzA5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWTNScGRtVmZiRzloYm5NZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXTjBhWFpsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NuSmxjR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TmpRS0lDQWdJQzh2SUhObGJHWXViRzloYm5OYmJHOWhibDlwWkYwZ1BTQnlaV052Y21RdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lOall0TWpZNENpQWdJQ0F2THlBaklFWnZjbmRoY21RZ2NtVndZWGx0Wlc1MElIUnZJRXhsYm1ScGJtZFFiMjlzSUhSdklIVndaR0YwWlNCd2IyOXNJR0ZqWTI5MWJuUnBibWNLSUNBZ0lDOHZJQ01nVTNSbGNDQXhPaUJUWlc1a0lFRk1SMDhnWm5KdmJTQjBhR2x6SUdOdmJuUnlZV04wSjNNZ1ltRnNZVzVqWlNCMGJ5QjBhR1VnY0c5dmJBb2dJQ0FnTHk4Z2NHOXZiRjloY0hBZ1BTQkJjSEJzYVdOaGRHbHZiaWh6Wld4bUxteGxibVJwYm1kZmNHOXZiRjlwWkM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSndiMjlzWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhsYm1ScGJtZGZjRzl2YkY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveU5qa3RNamN6Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljRzl2YkY5aGNIQXVZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljbVZ3WVhsZllXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZURzloYmsxaGJtRm5aWEl2Ykc5aGJsOXRZVzVoWjJWeUxuQjVPakkzTUFvZ0lDQWdMeThnY21WalpXbDJaWEk5Y0c5dmJGOWhjSEF1WVdSa2NtVnpjeXdLSUNBZ0lHUjFjQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveU5qa0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lOeklLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1qWTVMVEkzTXdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWEJ2YjJ4ZllYQndMbUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEpsY0dGNVgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNYjJGdVRXRnVZV2RsY2k5c2IyRnVYMjFoYm1GblpYSXVjSGs2TWpjMUxUSTRNUW9nSUNBZ0x5OGdJeUJUZEdWd0lESTZJRTV2ZEdsbWVTQjBhR1VnY0c5dmJDQjBieUJ5WldSMVkyVWdiM1YwYzNSaGJtUnBibWRmYkc5aGJuTWdZMjkxYm5SbGNnb2dJQ0FnTHk4Z2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQWE5sYkdZdWJHVnVaR2x1WjE5d2IyOXNYMmxrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOWhjbWR6UFNoaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtDSnlaWFIxY201ZlpuVnVaSE1vZFdsdWREWTBLWFp2YVdRaUtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0lDQWdJQ0FnWVhKak5DNVZTVzUwTmpRb2NtVndZWGxmWVcxdmRXNTBLUzVpZVhSbGN5a3NDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk1qYzVDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h5WlhCaGVWOWhiVzkxYm5RcExtSjVkR1Z6S1N3S0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRveU56Z0tJQ0FnSUM4dklHRndjRjloY21kelBTaGhjbU0wTG1GeVl6UmZjMmxuYm1GMGRYSmxLQ0p5WlhSMWNtNWZablZ1WkhNb2RXbHVkRFkwS1hadmFXUWlLU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFUzWlRWaE56YzVJQzh2SUcxbGRHaHZaQ0FpY21WMGRYSnVYMloxYm1SektIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TnpVdE1qYzJDaUFnSUNBdkx5QWpJRk4wWlhBZ01qb2dUbTkwYVdaNUlIUm9aU0J3YjI5c0lIUnZJSEpsWkhWalpTQnZkWFJ6ZEdGdVpHbHVaMTlzYjJGdWN5QmpiM1Z1ZEdWeUNpQWdJQ0F2THlCcGRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDZ0tJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNamd3Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qSTNOUzB5T0RFS0lDQWdJQzh2SUNNZ1UzUmxjQ0F5T2lCT2IzUnBabmtnZEdobElIQnZiMndnZEc4Z2NtVmtkV05sSUc5MWRITjBZVzVrYVc1blgyeHZZVzV6SUdOdmRXNTBaWElLSUNBZ0lDOHZJR2wwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzS0FvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxelpXeG1MbXhsYm1ScGJtZGZjRzl2YkY5cFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmWVhKbmN6MG9ZWEpqTkM1aGNtTTBYM05wWjI1aGRIVnlaU2dpY21WMGRYSnVYMloxYm1SektIVnBiblEyTkNsMmIybGtJaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNBZ0lHRnlZelF1VlVsdWREWTBLSEpsY0dGNVgyRnRiM1Z1ZENrdVlubDBaWE1wTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95TWpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTmhaR1Z1WTJsaExreHZZVzVOWVc1aFoyVnlMbXh2WVc1ZmJXRnVZV2RsY2k1TWIyRnVUV0Z1WVdkbGNpNXRZWEpyWDJSbFptRjFiSFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdFlYSnJYMlJsWm1GMWJIUTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNamd6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95T0RZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNKaFkyeGxMblpoYkhWbExDQWliMjVzZVNCdmNtRmpiR1VpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWIzSmhZMnhsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXlZV05zWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0J2Y21GamJHVUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lPRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnNiMkZ1WDJsa0lHbHVJSE5sYkdZdWJHOWhibk1zSUNKc2IyRnVJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyWXpabU5qRTJaVFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2JHOWhiaUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95T0RrS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXViRzloYm5OYmJHOWhibDlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pJNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbFkyOXlaQzV6ZEdGMFpTNXVZWFJwZG1VZ1BUMGdVMVJCVkVWZlFVTlVTVlpGTENBaWJHOWhiaUJ1YjNRZ1lXTjBhWFpsSWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEVTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR3h2WVc0Z2JtOTBJR0ZqZEdsMlpRb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qSTVNZ29nSUNBZ0x5OGdjbVZqYjNKa0xuTjBZWFJsSUQwZ1lYSmpOQzVWU1c1ME5qUW9VMVJCVkVWZlJFVkdRVlZNVkVWRUtRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBMENpQWdJQ0J5WlhCc1lXTmxNaUExTmdvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pJNU1pMHlPVE1LSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0YwWlNBOUlHRnlZelF1VlVsdWREWTBLRk5VUVZSRlgwUkZSa0ZWVEZSRlJDa0tJQ0FnSUM4dklITmxiR1l1Ykc5aGJuTmJiRzloYmw5cFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRFUyQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNYjJGdVRXRnVZV2RsY2k5c2IyRnVYMjFoYm1GblpYSXVjSGs2TWpreUNpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGRHVWdQU0JoY21NMExsVkpiblEyTkNoVFZFRlVSVjlFUlVaQlZVeFVSVVFwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNRFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG95T1RJdE1qa3pDaUFnSUNBdkx5QnlaV052Y21RdWMzUmhkR1VnUFNCaGNtTTBMbFZKYm5RMk5DaFRWRUZVUlY5RVJVWkJWVXhVUlVRcENpQWdJQ0F2THlCelpXeG1MbXh2WVc1elcyeHZZVzVmYVdSZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3lPVFV0TWprMkNpQWdJQ0F2THlBaklGSmxiVzkyWlNCaFkzUnBkbVVnYkc5aGJpQjBjbUZqYTJWeUNpQWdJQ0F2THlCaWIzSnliM2RsY2lBOUlISmxZMjl5WkM1aWIzSnliM2RsY2k1dVlYUnBkbVVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZURzloYmsxaGJtRm5aWEl2Ykc5aGJsOXRZVzVoWjJWeUxuQjVPakk1TndvZ0lDQWdMeThnYVdZZ1ltOXljbTkzWlhJZ2FXNGdjMlZzWmk1aFkzUnBkbVZmYkc5aGJsOWllVjlpYjNKeWIzZGxjam9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyTVRZek56UTJZelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnRZWEpyWDJSbFptRjFiSFJmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNams0Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVoWTNScGRtVmZiRzloYmw5aWVWOWliM0p5YjNkbGNsdGliM0p5YjNkbGNsMEtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDZ3B0WVhKclgyUmxabUYxYkhSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pJNU9Rb2dJQ0FnTHk4Z2MyVnNaaTVoWTNScGRtVmZiRzloYm5NdWRtRnNkV1VnTFQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdOMGFYWmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GamRHbDJaVjlzYjJGdWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhZM1JwZG1VaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qSTRNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTJGa1pXNWphV0V1VEc5aGJrMWhibUZuWlhJdWJHOWhibDl0WVc1aFoyVnlMa3h2WVc1TllXNWhaMlZ5TG1kbGRGOXNiMkZ1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMnh2WVc0NkNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk16QXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRvek1EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCc2IyRnVYMmxrSUdsdUlITmxiR1l1Ykc5aGJuTXNJQ0pzYjJGdUlHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJZelptTmpFMlpUVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYkc5aGJpQnViM1FnWm05MWJtUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3pNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG14dllXNXpXMnh2WVc1ZmFXUmRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHh2WVc1TllXNWhaMlZ5TDJ4dllXNWZiV0Z1WVdkbGNpNXdlVG96TURNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOaFpHVnVZMmxoTGt4dllXNU5ZVzVoWjJWeUxteHZZVzVmYldGdVlXZGxjaTVNYjJGdVRXRnVZV2RsY2k1blpYUmZZV04wYVhabFgyeHZZVzVmYVdSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWVdOMGFYWmxYMnh2WVc1ZmFXUTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNekE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEc5aGJrMWhibUZuWlhJdmJHOWhibDl0WVc1aFoyVnlMbkI1T2pNeE1nb2dJQ0FnTHk4Z2FXWWdZbTl5Y205M1pYSWdhVzRnYzJWc1ppNWhZM1JwZG1WZmJHOWhibDlpZVY5aWIzSnliM2RsY2pvS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMk1UWXpOelEyWXpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZllXTjBhWFpsWDJ4dllXNWZhV1JmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNekV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWhZM1JwZG1WZmJHOWhibDlpZVY5aWIzSnliM2RsY2x0aWIzSnliM2RsY2wwcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmpkR2wyWlY5c2IyRnVYMko1WDJKdmNuSnZkMlZ5SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb0taMlYwWDJGamRHbDJaVjlzYjJGdVgybGtYMkZtZEdWeVgybHViR2x1WldSZlkyRmtaVzVqYVdFdVRHOWhiazFoYm1GblpYSXViRzloYmw5dFlXNWhaMlZ5TGt4dllXNU5ZVzVoWjJWeUxtZGxkRjloWTNScGRtVmZiRzloYmw5cFpFQTBPZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZURzloYmsxaGJtRm5aWEl2Ykc5aGJsOXRZVzVoWjJWeUxuQjVPak13T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmWVdOMGFYWmxYMnh2WVc1ZmFXUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHOWhiazFoYm1GblpYSXZiRzloYmw5dFlXNWhaMlZ5TG5CNU9qTXhOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLREFwSUNBaklEQWc0b0NVSUc1dklHRmpkR2wyWlNCc2IyRnVDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3pNRGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZllXTjBhWFpsWDJ4dllXNWZhV1JmWVdaMFpYSmZhVzVzYVc1bFpGOWpZV1JsYm1OcFlTNU1iMkZ1VFdGdVlXZGxjaTVzYjJGdVgyMWhibUZuWlhJdVRHOWhiazFoYm1GblpYSXVaMlYwWDJGamRHbDJaVjlzYjJGdVgybGtRRFFLQ2dvdkx5QmpZV1JsYm1OcFlTNU1iMkZ1VFdGdVlXZGxjaTVzYjJGdVgyMWhibUZuWlhJdVRHOWhiazFoYm1GblpYSXVaMlYwWDJ4dllXNWZZMjkxYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYkc5aGJsOWpiM1Z1ZERvS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4dllXNU5ZVzVoWjJWeUwyeHZZVzVmYldGdVlXZGxjaTV3ZVRvek1Ua0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG14dllXNWZZMjkxYm5SbGNpNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pzYjJGdVgyTjBjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c2IyRnVYMk52ZFc1MFpYSWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCallXUmxibU5wWVM5TWIyRnVUV0Z1WVdkbGNpOXNiMkZ1WDIxaGJtRm5aWEl1Y0hrNk16RTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpZV1JsYm1OcFlTNU1iMkZ1VFdGdVlXZGxjaTVzYjJGdVgyMWhibUZuWlhJdVRHOWhiazFoYm1GblpYSXVaMlYwWDJGamRHbDJaVjlqYjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5aFkzUnBkbVZmWTI5MWJuUTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1iMkZ1VFdGdVlXZGxjaTlzYjJGdVgyMWhibUZuWlhJdWNIazZNekkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWhZM1JwZG1WZmJHOWhibk11ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXTjBhWFpsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmpkR2wyWlY5c2IyRnVjeUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweHZZVzVOWVc1aFoyVnlMMnh2WVc1ZmJXRnVZV2RsY2k1d2VUb3pNakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJSUNZTUJtRmpkR2wyWlFWaFkzUnNYd1ZzYjJGdVh3UVZIM3gxQ0d4dllXNWZZM1J5Qm5CaGRYTmxaQVZoWkcxcGJnWnZjbUZqYkdVSGNHOXZiRjlwWkFsbGMyTnliM2RmYVdRSUFBQUFBQUFBQUFBSUFBQUFBQUFBQUFReEdSUkVNUmhCQUU2Q0NnUWFkZ1B4Qk93SVVQMEVEVlB3MVFRV3JEdG5CRUdLS2s4RWluTklQUVJWN25KbUJNRGhnOEVFVUlvKzlBUmdQUkNUTmhvQWpnb0FjUUNKQUtJQkt3RzFBblVDd0FMYUF2d0RDQUNBQkRJNkc3VTJHZ0NPQVFBQkFEWWFBVWtWSlJKRU5ob0NTUlVsRWtRMkdnTkpGU1FTUkJjMkdnUkpGU1FTUkJjMkdnVkpGU1FTUkJjbkJrOEZaeWNIVHdSbmdBWnJlV05mYVdSUEEyZUFDSE5qYjNKbFgybGtUd0puSndoTVp5Y0pJbWNuQkNKbktDSm5Kd1VpWnlORE5ob0JTUlVrRWtRWE1RQWlKd1psUkJKRUp3bE1aeU5ETmhvQlNSVWpFa1F4QUNJbkJtVkVFa1FpVXljRlRHY2pRellhQVVrVkpCSkVOaG9DU1JVa0VrUkpGellhQTBrVkpCSkVJaWNGWlVRVVJERUFLVXNCVUwxRkFSUkVTd0pFVHdLQmdLeVBCQTVFSWljRVpVUkpJd2duQkV4bk1nWVdUd0pQQlZCUEJGQlBBMUFuQ2xCTVVJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCUVRCWXFTd0ZRVHdLL0sweFFzQ05ETmhvQlNSVWtFa1FYTVFBaUp3ZGxSQkpFSWljRlpVUVVSQllxU3dGUVNiMUZBVVJKdmtoSmdUaGJGRVJKVndBZ1RJQUlBQUFBQUFBQUFBSmNPRElHRmx4SU1nWkxBWUVvV3dnV1hGQlBBa3NCdnlsTEFsQlBBNzhpS0dWRUl3Z29UR2V4SWljSVpVUk1WeUFJU3dLeUhJQUVZWE1PNHJJYVR3S3lHcklhc2hpQkJySVFJcklCc3lORElqWWFBVWtWSkJKRUZ6RVdJd2xKT0JBakVrUk1GaXBNVUVsT0FrbTlSUUZFdmtoSmdUaGJnUUlTUkRFQVN3RlhBQ0FTUkVzQk9BY3lDaEpFVERnSVNVNENTd0dCV0ZzSVNSWlBBa3hjV0VsT0FpVmJEMEVBTVVtQUNBQUFBQUFBQUFBRFhEZ3lCaFpjWUVsRkFsY0FJQ2xNVUVsRkJiMUZBVUVBQkVzRHZFZ2lLR1ZFSXdrb1RHZExBa3NCdnlJbkNHVkVzVWx5Q0VSTEEwbE9BcklJc2djanNoQWlzZ0d6c1JhQUJGZmxwM215R3JJYXNoaUJCcklRSXJJQnN5TkROaG9CU1JVa0VrUVhNUUFpSndkbFJCSkVGaXBNVUVtOVJRRkVTYjVJU1lFNFc0RUNFa1FuQzF3NFRJRTRKd3U3VndBZ0tVeFFTYjFGQVVFQUEwbThTQ0lvWlVRakNTaE1aeU5ETmhvQlNSVWtFa1FYRmlwTVVFbTlSUUZFdmtnclRGQ3dJME0yR2dGSkZTVVNSQ2xNVUVtOVJRRkJBQXRKdmtRWEZpdE1VTEFqUXljS1F2LzFJaWNFWlVRV0sweFFzQ05ESWlobFJCWXJURkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
