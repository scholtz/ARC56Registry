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

namespace Arc56.Generated.harsh_mogalgiddikar.cadencia_lending_pool.CreditScore_cc0b8b89
{


    //
    // 
    //    On-chain credit score registry.
    //
    //    Access control:
    //        - initialize_score / update_score / increment_loans: oracle + authorized apps
    //        - get_score / get_record: anyone (read-only)
    //    
    //
    public class CreditScoreProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CreditScoreProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ScoreRecord : AVMObjectType
            {
                public ulong Score { get; set; }

                public ulong TotalLoans { get; set; }

                public ulong SuccessfulRepayments { get; set; }

                public ulong Defaults { get; set; }

                public ulong LastUpdated { get; set; }

                public ulong InitializedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScore.From(Score);
                    ret.AddRange(vScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLoans = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalLoans.From(TotalLoans);
                    ret.AddRange(vTotalLoans.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccessfulRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSuccessfulRepayments.From(SuccessfulRepayments);
                    ret.AddRange(vSuccessfulRepayments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaults = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDefaults.From(Defaults);
                    ret.AddRange(vDefaults.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdated.From(LastUpdated);
                    ret.AddRange(vLastUpdated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitializedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInitializedAt.From(InitializedAt);
                    ret.AddRange(vInitializedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ScoreRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ScoreRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScore = vScore.ToValue();
                    if (valueScore is ulong vScoreValue) { ret.Score = vScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLoans = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalLoans.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalLoans = vTotalLoans.ToValue();
                    if (valueTotalLoans is ulong vTotalLoansValue) { ret.TotalLoans = vTotalLoansValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccessfulRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSuccessfulRepayments.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSuccessfulRepayments = vSuccessfulRepayments.ToValue();
                    if (valueSuccessfulRepayments is ulong vSuccessfulRepaymentsValue) { ret.SuccessfulRepayments = vSuccessfulRepaymentsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaults = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDefaults.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDefaults = vDefaults.ToValue();
                    if (valueDefaults is ulong vDefaultsValue) { ret.Defaults = vDefaultsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdated = vLastUpdated.ToValue();
                    if (valueLastUpdated is ulong vLastUpdatedValue) { ret.LastUpdated = vLastUpdatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitializedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInitializedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitializedAt = vInitializedAt.ToValue();
                    if (valueInitializedAt is ulong vInitializedAtValue) { ret.InitializedAt = vInitializedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ScoreRecord);
                }
                public bool Equals(ScoreRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ScoreRecord left, ScoreRecord right)
                {
                    return EqualityComparer<ScoreRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ScoreRecord left, ScoreRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the contract. Called once at deployment.
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="oracle"> </param>
        public async Task Create(Algorand.Address admin, Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address admin, Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the authorized app ID (e.g., LoanManager). Admin-only.
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task SetAuthorizedApp(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 219, 214, 26 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAuthorizedApp_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 219, 214, 26 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the oracle address. Admin-only.
        ///</summary>
        /// <param name="new_oracle"> </param>
        public async Task SetOracle(Algorand.Address new_oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var new_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_oracleAbi.From(new_oracle);

            var result = await base.CallApp(new List<object> { abiHandle, new_oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOracle_Transactions(Algorand.Address new_oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var new_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_oracleAbi.From(new_oracle);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new credit score box for a borrower. Oracle-only.
        ///Rejects if score already exists (no double-init).
        ///Caller must include a payment transaction covering box MBR.
        ///</summary>
        /// <param name="borrower"> </param>
        public async Task InitializeScore(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 231, 235, 192 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitializeScore_Transactions(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 231, 235, 192 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increase a borrower's score by delta. Oracle/authorized app only.
        ///Score is clamped to SCORE_MAX (900).
        ///</summary>
        /// <param name="borrower"> </param>
        /// <param name="delta"> </param>
        public async Task IncreaseScore(Algorand.Address borrower, ulong delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 90, 240, 22 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var deltaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deltaAbi.From(delta);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi, deltaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncreaseScore_Transactions(Algorand.Address borrower, ulong delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 90, 240, 22 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var deltaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deltaAbi.From(delta);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi, deltaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Decrease a borrower's score by delta. Oracle/authorized app only.
        ///Score is clamped to SCORE_MIN (300).
        ///</summary>
        /// <param name="borrower"> </param>
        /// <param name="delta"> </param>
        public async Task DecreaseScore(Algorand.Address borrower, ulong delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 105, 92, 194 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var deltaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deltaAbi.From(delta);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi, deltaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DecreaseScore_Transactions(Algorand.Address borrower, ulong delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 105, 92, 194 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var deltaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deltaAbi.From(delta);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi, deltaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a loan repayment outcome. Oracle/authorized app only.
        ///Increments successful_repayments or defaults counter.
        ///</summary>
        /// <param name="borrower"> </param>
        /// <param name="is_successful"> </param>
        public async Task RecordRepayment(Algorand.Address borrower, bool is_successful, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 59, 64, 177 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var is_successfulAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_successfulAbi.From(is_successful);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi, is_successfulAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordRepayment_Transactions(Algorand.Address borrower, bool is_successful, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 59, 64, 177 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var is_successfulAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_successfulAbi.From(is_successful);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi, is_successfulAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increment the total loans counter. Oracle/authorized app only.
        ///</summary>
        /// <param name="borrower"> </param>
        public async Task IncrementTotalLoans(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 128, 126, 223 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncrementTotalLoans_Transactions(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 128, 126, 223 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the current score for a borrower. Returns 0 if not initialized.
        ///</summary>
        /// <param name="borrower"> </param>
        public async Task<ulong> GetScore(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.SimApp(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetScore_Transactions(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the full score record. Reverts if not initialized.
        ///</summary>
        /// <param name="borrower"> </param>
        public async Task<Structs.ScoreRecord> GetRecord(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 99, 25, 116 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.SimApp(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ScoreRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRecord_Transactions(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 99, 25, 116 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a borrower has an initialized score.
        ///</summary>
        /// <param name="borrower"> </param>
        public async Task<bool> HasScore(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 164, 216, 151 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            var result = await base.SimApp(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasScore_Transactions(Algorand.Address borrower, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 164, 216, 151 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlZGl0U2NvcmUiLCJkZXNjIjoiXG4gICAgT24tY2hhaW4gY3JlZGl0IHNjb3JlIHJlZ2lzdHJ5LlxuXG4gICAgQWNjZXNzIGNvbnRyb2w6XG4gICAgICAgIC0gaW5pdGlhbGl6ZV9zY29yZSAvIHVwZGF0ZV9zY29yZSAvIGluY3JlbWVudF9sb2Fuczogb3JhY2xlICsgYXV0aG9yaXplZCBhcHBzXG4gICAgICAgIC0gZ2V0X3Njb3JlIC8gZ2V0X3JlY29yZDogYW55b25lIChyZWFkLW9ubHkpXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlNjb3JlUmVjb3JkIjpbeyJuYW1lIjoic2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfbG9hbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3VjY2Vzc2Z1bF9yZXBheW1lbnRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRlZmF1bHRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RfdXBkYXRlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpbml0aWFsaXplZF9hdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGNvbnRyYWN0LiBDYWxsZWQgb25jZSBhdCBkZXBsb3ltZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmFjbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2F1dGhvcml6ZWRfYXBwIiwiZGVzYyI6IlNldCB0aGUgYXV0aG9yaXplZCBhcHAgSUQgKGUuZy4sIExvYW5NYW5hZ2VyKS4gQWRtaW4tb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9vcmFjbGUiLCJkZXNjIjoiVXBkYXRlIHRoZSBvcmFjbGUgYWRkcmVzcy4gQWRtaW4tb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19vcmFjbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdGlhbGl6ZV9zY29yZSIsImRlc2MiOiJDcmVhdGUgYSBuZXcgY3JlZGl0IHNjb3JlIGJveCBmb3IgYSBib3Jyb3dlci4gT3JhY2xlLW9ubHkuXG5SZWplY3RzIGlmIHNjb3JlIGFscmVhZHkgZXhpc3RzIChubyBkb3VibGUtaW5pdCkuXG5DYWxsZXIgbXVzdCBpbmNsdWRlIGEgcGF5bWVudCB0cmFuc2FjdGlvbiBjb3ZlcmluZyBib3ggTUJSLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVhc2Vfc2NvcmUiLCJkZXNjIjoiSW5jcmVhc2UgYSBib3Jyb3dlcidzIHNjb3JlIGJ5IGRlbHRhLiBPcmFjbGUvYXV0aG9yaXplZCBhcHAgb25seS5cblNjb3JlIGlzIGNsYW1wZWQgdG8gU0NPUkVfTUFYICg5MDApLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlY3JlYXNlX3Njb3JlIiwiZGVzYyI6IkRlY3JlYXNlIGEgYm9ycm93ZXIncyBzY29yZSBieSBkZWx0YS4gT3JhY2xlL2F1dGhvcml6ZWQgYXBwIG9ubHkuXG5TY29yZSBpcyBjbGFtcGVkIHRvIFNDT1JFX01JTiAoMzAwKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWx0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfcmVwYXltZW50IiwiZGVzYyI6IlJlY29yZCBhIGxvYW4gcmVwYXltZW50IG91dGNvbWUuIE9yYWNsZS9hdXRob3JpemVkIGFwcCBvbmx5LlxuSW5jcmVtZW50cyBzdWNjZXNzZnVsX3JlcGF5bWVudHMgb3IgZGVmYXVsdHMgY291bnRlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXNfc3VjY2Vzc2Z1bCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZW1lbnRfdG90YWxfbG9hbnMiLCJkZXNjIjoiSW5jcmVtZW50IHRoZSB0b3RhbCBsb2FucyBjb3VudGVyLiBPcmFjbGUvYXV0aG9yaXplZCBhcHAgb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zY29yZSIsImRlc2MiOiJHZXQgdGhlIGN1cnJlbnQgc2NvcmUgZm9yIGEgYm9ycm93ZXIuIFJldHVybnMgMCBpZiBub3QgaW5pdGlhbGl6ZWQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlY29yZCIsImRlc2MiOiJHZXQgdGhlIGZ1bGwgc2NvcmUgcmVjb3JkLiBSZXZlcnRzIGlmIG5vdCBpbml0aWFsaXplZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvcnJvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTY29yZVJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzX3Njb3JlIiwiZGVzYyI6IkNoZWNrIGlmIGEgYm9ycm93ZXIgaGFzIGFuIGluaXRpYWxpemVkIHNjb3JlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwNiwyMjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYXV0aG9yaXplZF9hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcmFjbGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zY29yZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9ib3Jyb3dlcnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjcsMTc1LDIyMSwyNDIsMzIxLDM5Miw0NzIsNTQzLDU3NSw2MTksNjQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OSwzMjksNDAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA4LDIyOV0sImVycm9yTWVzc2FnZSI6Im9ubHkgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTRdLCJlcnJvck1lc3NhZ2UiOiJzY29yZSBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ1LDQxOSw0OTUsNTU0LDYyN10sImVycm9yTWVzc2FnZSI6InNjb3JlIG5vdCBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5NF0sImVycm9yTWVzc2FnZSI6InVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTXpJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEY3pOak0yWmpjeU5qVTFaaUFpWVdSdGFXNGlJQ0p2Y21GamJHVWlJQ0poZFhSb1gyRndjQ0lnSW5SdmRHRnNYMkp2Y25KdmQyVnljeUlnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPalUyQ2lBZ0lDQXZMeUJqYkdGemN5QkRjbVZrYVhSVFkyOXlaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TmdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURnelpHSmtOakZoSURCNE16TTJPR1kxTlRZZ01IZ3dZMlUzWldKak1DQXdlRGRtTldGbU1ERTJJREI0TjJVMk9UVmpZeklnTUhnMU1ETmlOREJpTVNBd2VEYzNPREEzWldSbUlEQjRNakExWWpjeU1HTWdNSGhsWVRZek1UazNOQ0F3ZURZM1lUUmtPRGszSUM4dklHMWxkR2h2WkNBaWMyVjBYMkYxZEdodmNtbDZaV1JmWVhCd0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZmIzSmhZMnhsS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaVjl6WTI5eVpTaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1sdVkzSmxZWE5sWDNOamIzSmxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbFkzSmxZWE5sWDNOamIzSmxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFkyOXlaRjl5WlhCaGVXMWxiblFvWVdSa2NtVnpjeXhpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW1sdVkzSmxiV1Z1ZEY5MGIzUmhiRjlzYjJGdWN5aGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXpZMjl5WlNoaFpHUnlaWE56S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzSmxZMjl5WkNoaFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1oaGMxOXpZMjl5WlNoaFpHUnlaWE56S1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J6WlhSZllYVjBhRzl5YVhwbFpGOWhjSEFnYzJWMFgyOXlZV05zWlNCcGJtbDBhV0ZzYVhwbFgzTmpiM0psSUdsdVkzSmxZWE5sWDNOamIzSmxJR1JsWTNKbFlYTmxYM05qYjNKbElISmxZMjl5WkY5eVpYQmhlVzFsYm5RZ2FXNWpjbVZ0Wlc1MFgzUnZkR0ZzWDJ4dllXNXpJR2RsZEY5elkyOXlaU0JuWlhSZmNtVmpiM0prSUdoaGMxOXpZMjl5WlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFMk9nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pVMkNpQWdJQ0F2THlCamJHRnpjeUJEY21Wa2FYUlRZMjl5WlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRPR0U1TmprNE1HVWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9ZV1JrY21WemN5eGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklHTmhaR1Z1WTJsaExtTnlaV1JwZEY5elkyOXlaUzVEY21Wa2FYUlRZMjl5WlM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZOelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG8zT0FvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmk1MllXeDFaU0E5SUdGa2JXbHVDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUbzNPUW9nSUNBZ0x5OGdjMlZzWmk1dmNtRmpiR1V1ZG1Gc2RXVWdQU0J2Y21GamJHVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltOXlZV05zWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCallXUmxibU5wWVM5amNtVmthWFJmYzJOdmNtVXVjSGs2T0RBS0lDQWdJQzh2SUhObGJHWXVZWFYwYUc5eWFYcGxaRjloY0hBdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1GMWRHaGZZWEJ3SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZPREVLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWW05eWNtOTNaWEp6TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owYjNSaGJGOWliM0p5YjNkbGNuTWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRvM05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMkZrWlc1amFXRXVZM0psWkdsMFgzTmpiM0psTGtOeVpXUnBkRk5qYjNKbExuTmxkRjloZFhSb2IzSnBlbVZrWDJGd2NGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5aGRYUm9iM0pwZW1Wa1gyRndjRG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUbzRNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk9EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0p2Ym14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJR0ZrYldsdUNpQWdJQ0F2THlCallXUmxibU5wWVM5amNtVmthWFJmYzJOdmNtVXVjSGs2T0RjS0lDQWdJQzh2SUhObGJHWXVZWFYwYUc5eWFYcGxaRjloY0hBdWRtRnNkV1VnUFNCaGNIQmZhV1FLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUYxZEdoZllYQndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUbzRNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTJGa1pXNWphV0V1WTNKbFpHbDBYM05qYjNKbExrTnlaV1JwZEZOamIzSmxMbk5sZEY5dmNtRmpiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZiM0poWTJ4bE9nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pnNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZZM0psWkdsMFgzTmpiM0psTG5CNU9qa3lDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpYjI1c2VTQmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JoWkcxcGJnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2prekNpQWdJQ0F2THlCelpXeG1MbTl5WVdOc1pTNTJZV3gxWlNBOUlHNWxkMTl2Y21GamJHVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltOXlZV05zWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCallXUmxibU5wWVM5amNtVmthWFJmYzJOdmNtVXVjSGs2T0RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTmhaR1Z1WTJsaExtTnlaV1JwZEY5elkyOXlaUzVEY21Wa2FYUlRZMjl5WlM1cGJtbDBhV0ZzYVhwbFgzTmpiM0psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoYkdsNlpWOXpZMjl5WlRvS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG81TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE1ETUtJQ0FnSUM4dklITmxiR1l1WDJGemMyVnlkRjloZFhSb2IzSnBlbVZrS0NrS0lDQWdJR05oYkd4emRXSWdYMkZ6YzJWeWRGOWhkWFJvYjNKcGVtVmtDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1UQTBDaUFnSUNBdkx5QmhjM05sY25RZ1ltOXljbTkzWlhJZ2JtOTBJR2x1SUhObGJHWXVjMk52Y21WekxDQWljMk52Y21VZ1lXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNell6Tm1ZM01qWTFOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6WTI5eVpTQmhiSEpsWVdSNUlHbHVhWFJwWVd4cGVtVmtDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1URXhDaUFnSUNBdkx5QnNZWE4wWDNWd1pHRjBaV1E5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLU3dLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZZM0psWkdsMFgzTmpiM0psTG5CNU9qRXhNZ29nSUNBZ0x5OGdhVzVwZEdsaGJHbDZaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakV3TmkweE1UTUtJQ0FnSUM4dklISmxZMjl5WkNBOUlGTmpiM0psVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhOamIzSmxQV0Z5WXpRdVZVbHVkRFkwS0ZORFQxSkZYMGxPU1ZSSlFVd3BMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYMnh2WVc1elBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lITjFZMk5sYzNObWRXeGZjbVZ3WVhsdFpXNTBjejFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBjejFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JzWVhOMFgzVndaR0YwWldROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQnBibWwwYVdGc2FYcGxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01ESTFPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakV4TkFvZ0lDQWdMeThnYzJWc1ppNXpZMjl5WlhOYlltOXljbTkzWlhKZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFeE5Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOWliM0p5YjNkbGNuTXVkbUZzZFdVZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHOTBZV3hmWW05eWNtOTNaWEp6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJKdmNuSnZkMlZ5Y3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIzUmhiRjlpYjNKeWIzZGxjbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPamsxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCallXUmxibU5wWVM1amNtVmthWFJmYzJOdmNtVXVRM0psWkdsMFUyTnZjbVV1YVc1amNtVmhjMlZmYzJOdmNtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm1OeVpXRnpaVjl6WTI5eVpUb0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE1UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCallXUmxibU5wWVM5amNtVmthWFJmYzJOdmNtVXVjSGs2TVRJekNpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZWFYwYUc5eWFYcGxaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlGOWhjM05sY25SZllYVjBhRzl5YVhwbFpBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFeU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdKdmNuSnZkMlZ5SUdsdUlITmxiR1l1YzJOdmNtVnpMQ0FpYzJOdmNtVWdibTkwSUdsdWFYUnBZV3hwZW1Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3pOak0yWmpjeU5qVTFaZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6WTI5eVpTQnViM1FnYVc1cGRHbGhiR2w2WldRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG94TWpZS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVjMk52Y21WelcySnZjbkp2ZDJWeVhTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1USTNDaUFnSUNBdkx5QmpkWEp5Wlc1MElEMGdjbVZqYjNKa0xuTmpiM0psTG01aGRHbDJaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1USTRDaUFnSUNBdkx5QnVaWGRmYzJOdmNtVWdQU0JqZFhKeVpXNTBJQ3NnWkdWc2RHRUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakV6TUMweE16RUtJQ0FnSUM4dklDTWdRMnhoYlhBZ2RHOGdiV0Y0Q2lBZ0lDQXZMeUJwWmlCdVpYZGZjMk52Y21VZ1BpQlZTVzUwTmpRb1UwTlBVa1ZmVFVGWUtUb0tJQ0FnSUhCMWMyaHBiblFnT1RBd0NpQWdJQ0ErQ2lBZ0lDQmllaUJwYm1OeVpXRnpaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG94TXpJS0lDQWdJQzh2SUc1bGQxOXpZMjl5WlNBOUlGVkpiblEyTkNoVFEwOVNSVjlOUVZncENpQWdJQ0J3ZFhOb2FXNTBJRGt3TUFvZ0lDQWdZblZ5ZVNBeENncHBibU55WldGelpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNVE0wQ2lBZ0lDQXZMeUJ5WldOdmNtUXVjMk52Y21VZ1BTQmhjbU0wTGxWSmJuUTJOQ2h1WlhkZmMyTnZjbVVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1UTTFDaUFnSUNBdkx5QnlaV052Y21RdWJHRnpkRjkxY0dSaGRHVmtJRDBnWVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLUW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBek1nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFek5nb2dJQ0FnTHk4Z2MyVnNaaTV6WTI5eVpYTmJZbTl5Y205M1pYSmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUb3hNVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOaFpHVnVZMmxoTG1OeVpXUnBkRjl6WTI5eVpTNURjbVZrYVhSVFkyOXlaUzVrWldOeVpXRnpaVjl6WTI5eVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsWTNKbFlYTmxYM05qYjNKbE9nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFek9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFME5Bb2dJQ0FnTHk4Z2MyVnNaaTVmWVhOelpYSjBYMkYxZEdodmNtbDZaV1FvS1FvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgyRjFkR2h2Y21sNlpXUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaWIzSnliM2RsY2lCcGJpQnpaV3htTG5OamIzSmxjeXdnSW5OamIzSmxJRzV2ZENCcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNell6Tm1ZM01qWTFOV1lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYzJOdmNtVWdibTkwSUdsdWFYUnBZV3hwZW1Wa0NpQWdJQ0F2THlCallXUmxibU5wWVM5amNtVmthWFJmYzJOdmNtVXVjSGs2TVRRM0NpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1Mbk5qYjNKbGMxdGliM0p5YjNkbGNsMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZZM0psWkdsMFgzTmpiM0psTG5CNU9qRTBPQW9nSUNBZ0x5OGdZM1Z5Y21WdWRDQTlJSEpsWTI5eVpDNXpZMjl5WlM1dVlYUnBkbVVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNVFV3TFRFMU1Rb2dJQ0FnTHk4Z0l5QlFjbVYyWlc1MElIVnVaR1Z5Wm14dmR6b2dhV1lnWkdWc2RHRWdQaUJqZFhKeVpXNTBJQzBnVTBOUFVrVmZUVWxPTENCamJHRnRjQ0IwYnlCVFEwOVNSVjlOU1U0S0lDQWdJQzh2SUdsbUlHUmxiSFJoSUQ0OUlHTjFjbkpsYm5RZ0xTQlZTVzUwTmpRb1UwTlBVa1ZmVFVsT0tUb0tJQ0FnSUhCMWMyaHBiblFnTXpBd0NpQWdJQ0F0Q2lBZ0lDQStQUW9nSUNBZ1lub2daR1ZqY21WaGMyVmZjMk52Y21WZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE5USUtJQ0FnSUM4dklHNWxkMTl6WTI5eVpTQTlJRlZKYm5RMk5DaFRRMDlTUlY5TlNVNHBDaUFnSUNCd2RYTm9hVzUwSURNd01Bb0taR1ZqY21WaGMyVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakUxTmdvZ0lDQWdMeThnY21WamIzSmtMbk5qYjNKbElEMGdZWEpqTkM1VlNXNTBOalFvYm1WM1gzTmpiM0psS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUb3hOVGNLSUNBZ0lDOHZJSEpsWTI5eVpDNXNZWE4wWDNWd1pHRjBaV1FnUFNCaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1UVTRDaUFnSUNBdkx5QnpaV3htTG5OamIzSmxjMXRpYjNKeWIzZGxjbDBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakV6T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BrWldOeVpXRnpaVjl6WTI5eVpWOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUb3hOVFFLSUNBZ0lDOHZJRzVsZDE5elkyOXlaU0E5SUdOMWNuSmxiblFnTFNCa1pXeDBZUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ0xRb2dJQ0FnWWlCa1pXTnlaV0Z6WlY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlCallXUmxibU5wWVM1amNtVmthWFJmYzJOdmNtVXVRM0psWkdsMFUyTnZjbVV1Y21WamIzSmtYM0psY0dGNWJXVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRjl5WlhCaGVXMWxiblE2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNVFl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE5qWUtJQ0FnSUM4dklITmxiR1l1WDJGemMyVnlkRjloZFhSb2IzSnBlbVZrS0NrS0lDQWdJR05oYkd4emRXSWdYMkZ6YzJWeWRGOWhkWFJvYjNKcGVtVmtDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1UWTNDaUFnSUNBdkx5QmhjM05sY25RZ1ltOXljbTkzWlhJZ2FXNGdjMlZzWmk1elkyOXlaWE1zSUNKelkyOXlaU0J1YjNRZ2FXNXBkR2xoYkdsNlpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROek0yTXpabU56STJOVFZtQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUhOamIzSmxJRzV2ZENCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFMk9Rb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV6WTI5eVpYTmJZbTl5Y205M1pYSmRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1UY3dDaUFnSUNBdkx5QnBaaUJwYzE5emRXTmpaWE56Wm5Wc0xtNWhkR2wyWlRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o2SUhKbFkyOXlaRjl5WlhCaGVXMWxiblJmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG94TnpJS0lDQWdJQzh2SUhKbFkyOXlaQzV6ZFdOalpYTnpablZzWDNKbGNHRjViV1Z1ZEhNdWJtRjBhWFpsSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFM01TMHhOek1LSUNBZ0lDOHZJSEpsWTI5eVpDNXpkV05qWlhOelpuVnNYM0psY0dGNWJXVnVkSE1nUFNCaGNtTTBMbFZKYm5RMk5DZ0tJQ0FnSUM4dklDQWdJQ0J5WldOdmNtUXVjM1ZqWTJWemMyWjFiRjl5WlhCaGVXMWxiblJ6TG01aGRHbDJaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdMeThnS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNVFlLQ25KbFkyOXlaRjl5WlhCaGVXMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZZM0psWkdsMFgzTmpiM0psTG5CNU9qRTNOd29nSUNBZ0x5OGdjbVZqYjNKa0xteGhjM1JmZFhCa1lYUmxaQ0E5SUdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ016SUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE56Z0tJQ0FnSUM4dklITmxiR1l1YzJOdmNtVnpXMkp2Y25KdmQyVnlYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNVFl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsWTI5eVpGOXlaWEJoZVcxbGJuUmZaV3h6WlY5aWIyUjVRRE02Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNVGMxQ2lBZ0lDQXZMeUJ5WldOdmNtUXVaR1ZtWVhWc2RITWdQU0JoY21NMExsVkpiblEyTkNoeVpXTnZjbVF1WkdWbVlYVnNkSE11Ym1GMGFYWmxJQ3NnVlVsdWREWTBLREVwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREkwQ2lBZ0lDQmlJSEpsWTI5eVpGOXlaWEJoZVcxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBMENnb0tMeThnWTJGa1pXNWphV0V1WTNKbFpHbDBYM05qYjNKbExrTnlaV1JwZEZOamIzSmxMbWx1WTNKbGJXVnVkRjkwYjNSaGJGOXNiMkZ1YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVZM0psYldWdWRGOTBiM1JoYkY5c2IyRnVjem9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUb3hPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCallXUmxibU5wWVM5amNtVmthWFJmYzJOdmNtVXVjSGs2TVRnekNpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZWFYwYUc5eWFYcGxaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlGOWhjM05sY25SZllYVjBhRzl5YVhwbFpBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFNE5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdKdmNuSnZkMlZ5SUdsdUlITmxiR1l1YzJOdmNtVnpMQ0FpYzJOdmNtVWdibTkwSUdsdWFYUnBZV3hwZW1Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3pOak0yWmpjeU5qVTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUhOamIzSmxJRzV2ZENCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pFNE5nb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV6WTI5eVpYTmJZbTl5Y205M1pYSmRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE9EY0tJQ0FnSUM4dklISmxZMjl5WkM1MGIzUmhiRjlzYjJGdWN5QTlJR0Z5WXpRdVZVbHVkRFkwS0hKbFkyOXlaQzUwYjNSaGJGOXNiMkZ1Y3k1dVlYUnBkbVVnS3lCVlNXNTBOalFvTVNrcENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1UZzNMVEU0T0FvZ0lDQWdMeThnY21WamIzSmtMblJ2ZEdGc1gyeHZZVzV6SUQwZ1lYSmpOQzVWU1c1ME5qUW9jbVZqYjNKa0xuUnZkR0ZzWDJ4dllXNXpMbTVoZEdsMlpTQXJJRlZKYm5RMk5DZ3hLU2tLSUNBZ0lDOHZJSE5sYkdZdWMyTnZjbVZ6VzJKdmNuSnZkMlZ5WFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakU0TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyRmtaVzVqYVdFdVkzSmxaR2wwWDNOamIzSmxMa055WldScGRGTmpiM0psTG1kbGRGOXpZMjl5WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl6WTI5eVpUb0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwyTnlaV1JwZEY5elkyOXlaUzV3ZVRveE9USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1UazFDaUFnSUNBdkx5QnBaaUJpYjNKeWIzZGxjaUJwYmlCelpXeG1Mbk5qYjNKbGN6b0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNell6Tm1ZM01qWTFOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHZGxkRjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG94T1RZS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxuTmpiM0psYzF0aWIzSnliM2RsY2wwdWMyTnZjbVVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzJOdmNtVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdaWGgwY21GamRDQXdJRGdLQ21kbGRGOXpZMjl5WlY5aFpuUmxjbDlwYm14cGJtVmtYMk5oWkdWdVkybGhMbU55WldScGRGOXpZMjl5WlM1RGNtVmthWFJUWTI5eVpTNW5aWFJmYzJOdmNtVkFORG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUb3hPVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG94T1RjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakU1TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOXpZMjl5WlY5aFpuUmxjbDlwYm14cGJtVmtYMk5oWkdWdVkybGhMbU55WldScGRGOXpZMjl5WlM1RGNtVmthWFJUWTI5eVpTNW5aWFJmYzJOdmNtVkFOQW9LQ2k4dklHTmhaR1Z1WTJsaExtTnlaV1JwZEY5elkyOXlaUzVEY21Wa2FYUlRZMjl5WlM1blpYUmZjbVZqYjNKa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNKbFkyOXlaRG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUb3hPVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNakF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZbTl5Y205M1pYSWdhVzRnYzJWc1ppNXpZMjl5WlhNc0lDSnpZMjl5WlNCdWIzUWdhVzVwZEdsaGJHbDZaV1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpNMk16Wm1OekkyTlRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdjMk52Y21VZ2JtOTBJR2x1YVhScFlXeHBlbVZrQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNakF6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1elkyOXlaWE5iWW05eWNtOTNaWEpkQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG94T1RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOaFpHVnVZMmxoTG1OeVpXUnBkRjl6WTI5eVpTNURjbVZrYVhSVFkyOXlaUzVvWVhOZmMyTnZjbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwb1lYTmZjMk52Y21VNkNpQWdJQ0F2THlCallXUmxibU5wWVM5amNtVmthWFJmYzJOdmNtVXVjSGs2TWpBMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlkzSmxaR2wwWDNOamIzSmxMbkI1T2pJd09Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoaWIzSnliM2RsY2lCcGJpQnpaV3htTG5OamIzSmxjeWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczTXpZek5tWTNNalkxTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1qQTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpZV1JsYm1OcFlTNWpjbVZrYVhSZmMyTnZjbVV1UTNKbFpHbDBVMk52Y21VdVgyRnpjMlZ5ZEY5aGRYUm9iM0pwZW1Wa0tDa2dMVDRnZG05cFpEb0tYMkZ6YzJWeWRGOWhkWFJvYjNKcGVtVmtPZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZZM0psWkdsMFgzTmpiM0psTG5CNU9qSXhNaTB5TVRNS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYMkZ6YzJWeWRGOWhkWFJvYjNKcGVtVmtLSE5sYkdZcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXdJREFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMk55WldScGRGOXpZMjl5WlM1d2VUb3lNVFVLSUNBZ0lDOHZJR2x6WDI5eVlXTnNaU0E5SUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dmNtRmpiR1V1ZG1Gc2RXVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p2Y21GamJHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNKaFkyeGxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG95TVRjS0lDQWdJQzh2SUVkc2IySmhiQzVqWVd4c1pYSmZZWEJ3YkdsallYUnBiMjVmYVdRZ0lUMGdWVWx1ZERZMEtEQXBDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnWTJGa1pXNWphV0V2WTNKbFpHbDBYM05qYjNKbExuQjVPakl4TnkweU1UZ0tJQ0FnSUM4dklFZHNiMkpoYkM1allXeHNaWEpmWVhCd2JHbGpZWFJwYjI1ZmFXUWdJVDBnVlVsdWREWTBLREFwQ2lBZ0lDQXZMeUJoYm1RZ1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxtRjFkR2h2Y21sNlpXUmZZWEJ3TG5aaGJIVmxDaUFnSUNCaWVpQmZZWE56WlhKMFgyRjFkR2h2Y21sNlpXUmZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlqY21Wa2FYUmZjMk52Y21VdWNIazZNakU0Q2lBZ0lDQXZMeUJoYm1RZ1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxtRjFkR2h2Y21sNlpXUmZZWEJ3TG5aaGJIVmxDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUYxZEdoZllYQndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GMWRHaHZjbWw2WldSZllYQndJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJOeVpXUnBkRjl6WTI5eVpTNXdlVG95TVRjdE1qRTRDaUFnSUNBdkx5QkhiRzlpWVd3dVkyRnNiR1Z5WDJGd2NHeHBZMkYwYVc5dVgybGtJQ0U5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnWVc1a0lFZHNiMkpoYkM1allXeHNaWEpmWVhCd2JHbGpZWFJwYjI1ZmFXUWdQVDBnYzJWc1ppNWhkWFJvYjNKcGVtVmtYMkZ3Y0M1MllXeDFaUW9nSUNBZ1lub2dYMkZ6YzJWeWRGOWhkWFJvYjNKcGVtVmtYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ2w5aGMzTmxjblJmWVhWMGFHOXlhWHBsWkY5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOWpjbVZrYVhSZmMyTnZjbVV1Y0hrNk1qSXdDaUFnSUNBdkx5QmhjM05sY25RZ2FYTmZiM0poWTJ4bElHOXlJR2x6WDJGMWRHaHZjbWw2WldSZllYQndMQ0FpZFc1aGRYUm9iM0pwZW1Wa0lnb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSHg4Q2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVoZFhSb2IzSnBlbVZrQ2lBZ0lDQnlaWFJ6ZFdJS0NsOWhjM05sY25SZllYVjBhRzl5YVhwbFpGOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQmZZWE56WlhKMFgyRjFkR2h2Y21sNlpXUmZZbTl2YkY5dFpYSm5aVUEwQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFnQ0NZR0JuTmpiM0psWHdWaFpHMXBiZ1p2Y21GamJHVUlZWFYwYUY5aGNIQVBkRzkwWVd4ZlltOXljbTkzWlhKekJCVWZmSFV4R1JSRU1SaEJBRTZDQ2dTRDI5WWFCRE5vOVZZRURPZnJ3QVIvV3ZBV0JINXBYTUlFVUR0QXNRUjNnSDdmQkNCYmNnd0U2bU1aZEFSbnBOaVhOaG9BamdvQUx3QkZBRm9BcVFEd0FVQUJod0duQWRNQjdBQ0FCSXFXbUE0MkdnQ09BUUFCQURZYUFVa1ZKQkpFTmhvQ1NSVWtFa1FwVHdKbktreG5LeU5uSndRalp5SkROaG9CU1JVbEVrUVhNUUFqS1dWRUVrUXJUR2NpUXpZYUFVa1ZKQkpFTVFBaktXVkVFa1FxVEdjaVF6WWFBVWtWSkJKRWlBR2pLRXhRU2IxRkFSUkVNZ1lXTWdZV2dDQUFBQUFBQUFBQ1dBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUU4Q1VFeFF2eU1uQkdWRUlnZ25CRXhuSWtNMkdnRkpGU1FTUkRZYUFra1ZKUkpFRjRnQlN5aFBBbEJKVGdKSnZVVUJSTDVJU1U0Q0kxc0lTWUdFQncxQkFBV0JoQWRGQVVrV1N3Sk1YQUF5QmhaY0lFc0RUTDhpUXpZYUFVa1ZKQkpFTmhvQ1NSVWxFa1FYU1U0Q2lBRUJLRThDVUVsT0FrbTlSUUZFdmtoSlRnSWpXMGxPQW9Hc0Fna1BRUUFVZ2F3Q0Zrc0NURndBTWdZV1hDQkxBMHkvSWtOSlN3UUpRdi9vTmhvQlNSVWtFa1EyR2dKSkZTSVNSSWdBdFNoUEFsQkpUZ0pKdlVVQlJMNUlUQ05UUVFBVVNZRVFXeUlJRmx3UU1nWVdYQ0JMQVV5L0lrTkpnUmhiSWdnV1hCaEMvK2syR2dGSkZTUVNSSWdBZGloTVVFbTlSUUZFU2I1SUpWc2lDQllsVExzaVF6WWFBVWtWSkJKRUtFeFFTYjFGQVVFQURVbStSRmNBQ0NjRlRGQ3dJa09BQ0FBQUFBQUFBQUFBUXYvc05ob0JTUlVrRWtRb1RGQkp2VVVCUkw1SUp3Vk1VTEFpUXpZYUFVa1ZKQkpFS0V4UXZVVUJnQUVBSTA4Q1ZDY0ZURkN3SWtPS0FBQXhBQ01xWlVRU01nMUJBQkF5RFNNclpVUVNRUUFHSW9zQUVVU0pJMEwvOXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
