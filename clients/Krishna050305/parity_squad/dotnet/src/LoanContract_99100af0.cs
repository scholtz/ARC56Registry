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

namespace Arc56.Generated.Krishna050305.parity_squad.LoanContract_99100af0
{


    //
    // A P2P lending escrow contract. Lenders fund the loan, borrower repays,
    //    lenders claim their pro-rata share via pull model.
    //
    public class LoanContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LoanContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class LoanInfo : AVMObjectType
            {
                public ulong GoalAmount { get; set; }

                public ulong FundedAmount { get; set; }

                public ulong RepaidAmount { get; set; }

                public ulong Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGoalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGoalAmount.From(GoalAmount);
                    ret.AddRange(vGoalAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFundedAmount.From(FundedAmount);
                    ret.AddRange(vFundedAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepaidAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRepaidAmount.From(RepaidAmount);
                    ret.AddRange(vRepaidAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LoanInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LoanInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGoalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGoalAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGoalAmount = vGoalAmount.ToValue();
                    if (valueGoalAmount is ulong vGoalAmountValue) { ret.GoalAmount = vGoalAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFundedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFundedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFundedAmount = vFundedAmount.ToValue();
                    if (valueFundedAmount is ulong vFundedAmountValue) { ret.FundedAmount = vFundedAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepaidAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRepaidAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRepaidAmount = vRepaidAmount.ToValue();
                    if (valueRepaidAmount is ulong vRepaidAmountValue) { ret.RepaidAmount = vRepaidAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LoanInfo);
                }
                public bool Equals(LoanInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LoanInfo left, LoanInfo right)
                {
                    return EqualityComparer<LoanInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(LoanInfo left, LoanInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize a new loan request. Only callable during app creation.
        ///</summary>
        /// <param name="goal_amount"> </param>
        /// <param name="duration_days"> </param>
        /// <param name="tier_required"> </param>
        /// <param name="badge_asa_id"> </param>
        public async Task CreateLoan(ulong goal_amount, ulong duration_days, ulong tier_required, ulong badge_asa_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 133, 240, 118 };
            var goal_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goal_amountAbi.From(goal_amount);
            var duration_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_daysAbi.From(duration_days);
            var tier_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tier_requiredAbi.From(tier_required);
            var badge_asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); badge_asa_idAbi.From(badge_asa_id);

            var result = await base.CallApp(new List<object> { abiHandle, goal_amountAbi, duration_daysAbi, tier_requiredAbi, badge_asa_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateLoan_Transactions(ulong goal_amount, ulong duration_days, ulong tier_required, ulong badge_asa_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 133, 240, 118 };
            var goal_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goal_amountAbi.From(goal_amount);
            var duration_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_daysAbi.From(duration_days);
            var tier_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tier_requiredAbi.From(tier_required);
            var badge_asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); badge_asa_idAbi.From(badge_asa_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, goal_amountAbi, duration_daysAbi, tier_requiredAbi, badge_asa_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Lender funds the loan. Payment must go to the app address.
        ///The lender opts in so local state is available.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task FundLoan(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 74, 205, 147, 157 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundLoan_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 74, 205, 147, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Manual release funds to borrower. Only callable when fully funded.
        ///</summary>
        public async Task ReleaseFunds(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 74, 68, 77 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleaseFunds_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 74, 68, 77 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Borrower repays the loan. Payment must go to the app address.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task RepayLoan(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 227, 25, 212, 35 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RepayLoan_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 227, 25, 212, 35 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Lender claims their pro-rata share of repaid funds.
        ///Pull model: each lender calls this individually.
        ///</summary>
        public async Task ClaimRepayment(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 32, 105, 122 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimRepayment_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 32, 105, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Borrower can add a guarantor while the loan is still open.
        ///</summary>
        /// <param name="guarantor"> </param>
        public async Task AddGuarantor(Algorand.Address guarantor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 224, 249, 55 };
            var guarantorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); guarantorAbi.From(guarantor);

            var result = await base.CallApp(new List<object> { abiHandle, guarantorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddGuarantor_Transactions(Algorand.Address guarantor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 224, 249, 55 };
            var guarantorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); guarantorAbi.From(guarantor);

            return await base.MakeTransactionList(new List<object> { abiHandle, guarantorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark the loan as defaulted if repayment deadline has passed.
        ///</summary>
        public async Task MarkDefault(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 174, 110, 203 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkDefault_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 174, 110, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns loan information.
        ///</summary>
        public async Task<Structs.LoanInfo> GetLoanInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 180, 9, 93 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LoanInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetLoanInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 180, 9, 93 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9hbkNvbnRyYWN0IiwiZGVzYyI6IkEgUDJQIGxlbmRpbmcgZXNjcm93IGNvbnRyYWN0LiBMZW5kZXJzIGZ1bmQgdGhlIGxvYW4sIGJvcnJvd2VyIHJlcGF5cyxcbiAgICBsZW5kZXJzIGNsYWltIHRoZWlyIHByby1yYXRhIHNoYXJlIHZpYSBwdWxsIG1vZGVsLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMb2FuSW5mbyI6W3sibmFtZSI6ImdvYWxfYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZ1bmRlZF9hbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVwYWlkX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9sb2FuIiwiZGVzYyI6IkluaXRpYWxpemUgYSBuZXcgbG9hbiByZXF1ZXN0LiBPbmx5IGNhbGxhYmxlIGR1cmluZyBhcHAgY3JlYXRpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdvYWxfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkdXJhdGlvbl9kYXlzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWVyX3JlcXVpcmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYWRnZV9hc2FfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZF9sb2FuIiwiZGVzYyI6IkxlbmRlciBmdW5kcyB0aGUgbG9hbi4gUGF5bWVudCBtdXN0IGdvIHRvIHRoZSBhcHAgYWRkcmVzcy5cblRoZSBsZW5kZXIgb3B0cyBpbiBzbyBsb2NhbCBzdGF0ZSBpcyBhdmFpbGFibGUuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2VfZnVuZHMiLCJkZXNjIjoiTWFudWFsIHJlbGVhc2UgZnVuZHMgdG8gYm9ycm93ZXIuIE9ubHkgY2FsbGFibGUgd2hlbiBmdWxseSBmdW5kZWQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcGF5X2xvYW4iLCJkZXNjIjoiQm9ycm93ZXIgcmVwYXlzIHRoZSBsb2FuLiBQYXltZW50IG11c3QgZ28gdG8gdGhlIGFwcCBhZGRyZXNzLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltX3JlcGF5bWVudCIsImRlc2MiOiJMZW5kZXIgY2xhaW1zIHRoZWlyIHByby1yYXRhIHNoYXJlIG9mIHJlcGFpZCBmdW5kcy5cblB1bGwgbW9kZWw6IGVhY2ggbGVuZGVyIGNhbGxzIHRoaXMgaW5kaXZpZHVhbGx5LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfZ3VhcmFudG9yIiwiZGVzYyI6IkJvcnJvd2VyIGNhbiBhZGQgYSBndWFyYW50b3Igd2hpbGUgdGhlIGxvYW4gaXMgc3RpbGwgb3Blbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imd1YXJhbnRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXJrX2RlZmF1bHQiLCJkZXNjIjoiTWFyayB0aGUgbG9hbiBhcyBkZWZhdWx0ZWQgaWYgcmVwYXltZW50IGRlYWRsaW5lIGhhcyBwYXNzZWQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9sb2FuX2luZm8iLCJkZXNjIjoiUmV0dXJucyBsb2FuIGluZm9ybWF0aW9uLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkxvYW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NywiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjoyLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU0MV0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgY2xhaW1lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwMF0sImVycm9yTWVzc2FnZSI6IkNhbiBvbmx5IGFkZCBndWFyYW50b3Igd2hlbiBsb2FuIGlzIE9QRU4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjJdLCJlcnJvck1lc3NhZ2UiOiJEZWFkbGluZSBoYXMgbm90IHBhc3NlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzldLCJlcnJvck1lc3NhZ2UiOiJGdW5kaW5nIGRlYWRsaW5lIGhhcyBwYXNzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjJdLCJlcnJvck1lc3NhZ2UiOiJMb2FuIGlzIG5vdCBjbG9zZWQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM5XSwiZXJyb3JNZXNzYWdlIjoiTG9hbiBpcyBub3QgaW4gT1BFTiBzdGF0dXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzFdLCJlcnJvck1lc3NhZ2UiOiJMb2FuIGlzIG5vdCBpbiByZXBheW1lbnQgcGhhc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzBdLCJlcnJvck1lc3NhZ2UiOiJMb2FuIGlzIG5vdCBvcGVuIGZvciBmdW5kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjEzXSwiZXJyb3JNZXNzYWdlIjoiTG9hbiBtdXN0IGJlIGluIFJFUEFZSU5HIHN0YXR1cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0OV0sImVycm9yTWVzc2FnZSI6IkxvYW4gbm90IGZ1bGx5IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MCw0OTFdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHNlbmQgYSBwb3NpdGl2ZSBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDNdLCJlcnJvck1lc3NhZ2UiOiJObyBjb250cmlidXRpb24gZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGJvcnJvd2VyIGNhbiBhZGQgZ3VhcmFudG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgwXSwiZXJyb3JNZXNzYWdlIjoiT25seSBib3Jyb3dlciBjYW4gcmVwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODYsNDg3XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGdvIHRvIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3OCw1OTEsNjc5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ib3Jyb3dlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNvbnRyaWJ1dGlvbiBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzcsNjIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZWFkbGluZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTQsNDQzLDYzN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZnVuZGVkX2Ftb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjMsNDQ3LDUwNCw1NTIsNjMyLDY3NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ29hbF9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk1LDU0Nyw2NDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcGFpZF9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY3LDQzNiw0NjgsNTE4LDU5Nyw2MTAsNjQ3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGF0dXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NiwyODQsMjkyLDMwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2Myw0NjRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBekNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKemRHRjBkWE1pSUNKbmIyRnNYMkZ0YjNWdWRDSWdJbVoxYm1SbFpGOWhiVzkxYm5RaUlDSnlaWEJoYVdSZllXMXZkVzUwSWlBaVltOXljbTkzWlhJaUlDSmtaV0ZrYkdsdVpTSWdJbWQxWVhKaGJuUnZjaUlnSW1OdmJuUnlhV0oxZEdsdmJpSWdJblJwWlhKZmNtVnhkV2x5WldRaUlDSjBhV1Z5WDJKaFpHZGxYMmxrSWlBaVkyeGhhVzFsWkNJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qTXpMVE0wQ2lBZ0lDQXZMeUFqSU9LVWdPS1VnQ0JIYkc5aVlXd2dVM1JoZEdVZzRwU0E0cFNBQ2lBZ0lDQXZMeUJ6Wld4bUxtSnZjbkp2ZDJWeUlEMGdSMnh2WW1Gc1UzUmhkR1VvWVhKak5DNUJaR1J5WlhOektDa3NJR3RsZVQwaVltOXljbTkzWlhJaUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVltOXljbTkzWlhJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdjMlZzWmk1bmIyRnNYMkZ0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1N3Z2EyVjVQU0puYjJGc1gyRnRiM1Z1ZENJcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbmIyRnNYMkZ0YjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUhObGJHWXVablZ1WkdWa1gyRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DZ3dLU3dnYTJWNVBTSm1kVzVrWldSZllXMXZkVzUwSWlrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1aMWJtUmxaRjloYlc5MWJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCelpXeG1MbkpsY0dGcFpGOWhiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2tzSUd0bGVUMGljbVZ3WVdsa1gyRnRiM1Z1ZENJcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKeVpYQmhhV1JmWVcxdmRXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrc0lHdGxlVDBpYzNSaGRIVnpJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUhObGJHWXVaR1ZoWkd4cGJtVWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrc0lHdGxlVDBpWkdWaFpHeHBibVVpS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWkdWaFpHeHBibVVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QnpaV3htTG1kMVlYSmhiblJ2Y2lBOUlFZHNiMkpoYkZOMFlYUmxLR0Z5WXpRdVFXUmtjbVZ6Y3lncExDQnJaWGs5SW1kMVlYSmhiblJ2Y2lJcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmRXRnlZVzUwYjNJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1MGFXVnlYM0psY1hWcGNtVmtJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcExDQnJaWGs5SW5ScFpYSmZjbVZ4ZFdseVpXUWlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkR2xsY2w5eVpYRjFhWEpsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJSE5sYkdZdWRHbGxjbDlpWVdSblpWOXBaQ0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTd2dhMlY1UFNKMGFXVnlYMkpoWkdkbFgybGtJaWtLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJwWlhKZlltRmtaMlZmYVdRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklHTnNZWE56SUV4dllXNURiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdGalpEa3pPV1FnTHk4Z2JXVjBhRzlrSUNKbWRXNWtYMnh2WVc0b2NHRjVLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJaMWJtUmZiRzloYmw5eWIzVjBaVUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QmpiR0Z6Y3lCTWIyRnVRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVFFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsT1RSaE5EUTBaQ0F3ZUdVek1UbGtOREl6SURCNFptSXlNRFk1TjJFZ01IaGpOV1V3Wmprek55QXdlRFUyWVdVMlpXTmlJREI0WmpWaU5EQTVOV1FnTHk4Z2JXVjBhRzlrSUNKeVpXeGxZWE5sWDJaMWJtUnpLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWEJoZVY5c2IyRnVLSEJoZVNsMmIybGtJaXdnYldWMGFHOWtJQ0pqYkdGcGJWOXlaWEJoZVcxbGJuUW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRjluZFdGeVlXNTBiM0lvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnRZWEpyWDJSbFptRjFiSFFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5c2IyRnVYMmx1Wm04b0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21Wc1pXRnpaVjltZFc1a2N5QnlaWEJoZVY5c2IyRnVJR05zWVdsdFgzSmxjR0Y1YldWdWRDQmhaR1JmWjNWaGNtRnVkRzl5SUcxaGNtdGZaR1ZtWVhWc2RDQm5aWFJmYkc5aGJsOXBibVp2Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnWTJ4aGMzTWdURzloYmtOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtZemcxWmpBM05pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpWOXNiMkZ1S0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYMnh2WVc0S0lDQWdJR1Z5Y2dvS2JXRnBibDltZFc1a1gyeHZZVzVmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs5d2RFbHVJbDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnVDNCMFNXNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQm1kVzVrWDJ4dllXNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ykc5aGJsOWpiMjUwY21GamRDNWpiMjUwY21GamRDNU1iMkZ1UTI5dWRISmhZM1F1WTNKbFlYUmxYMnh2WVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWZmJHOWhiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCelpXeG1MbUp2Y25KdmQyVnlMblpoYkhWbElEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaWIzSnliM2RsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdjMlZzWmk1bmIyRnNYMkZ0YjNWdWRDNTJZV3gxWlNBOUlHZHZZV3hmWVcxdmRXNTBMbTVoZEdsMlpRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0puYjJGc1gyRnRiM1Z1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnYzJWc1ppNW1kVzVrWldSZllXMXZkVzUwTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ptZFc1a1pXUmZZVzF2ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnYzJWc1ppNXlaWEJoYVdSZllXMXZkVzUwTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p5WlhCaGFXUmZZVzF2ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnUFNCVlNXNTBOalFvTVNrZ0l5QlBVRVZPQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCelpXeG1MbVJsWVdSc2FXNWxMblpoYkhWbElEMGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ0t5QmtkWEpoZEdsdmJsOWtZWGx6TG01aGRHbDJaU0FxSUZWSmJuUTJOQ2c0TmpRd01Da0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZblJ2YVFvZ0lDQWdjSFZ6YUdsdWRDQTROalF3TUFvZ0lDQWdLZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOU0F2THlBaVpHVmhaR3hwYm1VaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUhObGJHWXVaM1ZoY21GdWRHOXlMblpoYkhWbElEMGdZWEpqTkM1QlpHUnlaWE56S0NrZ0lDTWdaVzF3ZEhrZ2RXNTBhV3dnYzJWMENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmRXRnlZVzUwYjNJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdjMlZzWmk1MGFXVnlYM0psY1hWcGNtVmtMblpoYkhWbElEMGdkR2xsY2w5eVpYRjFhWEpsWkM1dVlYUnBkbVVLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJwWlhKZmNtVnhkV2x5WldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUhObGJHWXVkR2xsY2w5aVlXUm5aVjlwWkM1MllXeDFaU0E5SUdKaFpHZGxYMkZ6WVY5cFpDNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5ScFpYSmZZbUZrWjJWZmFXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNiMkZ1WDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGt4dllXNURiMjUwY21GamRDNW1kVzVrWDJ4dllXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtZFc1a1gyeHZZVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwOUlGVkpiblEyTkNneEtTd2dJa3h2WVc0Z2FYTWdibTkwSUc5d1pXNGdabTl5SUdaMWJtUnBibWNpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhSMWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFeHZZVzRnYVhNZ2JtOTBJRzl3Wlc0Z1ptOXlJR1oxYm1ScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQQ0J6Wld4bUxtUmxZV1JzYVc1bExuWmhiSFZsTENBaVJuVnVaR2x1WnlCa1pXRmtiR2x1WlNCb1lYTWdjR0Z6YzJWa0lnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1SbFlXUnNhVzVsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxZV1JzYVc1bElHVjRhWE4wY3dvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFWjFibVJwYm1jZ1pHVmhaR3hwYm1VZ2FHRnpJSEJoYzNObFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKUVlYbHRaVzUwSUcxMWMzUWdaMjhnZEc4Z1lYQndJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJR2R2SUhSdklHRndjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrMTFjM1FnYzJWdVpDQmhJSEJ2YzJsMGFYWmxJR0Z0YjNWdWRDSUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQnpaVzVrSUdFZ2NHOXphWFJwZG1VZ1lXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzNOaTAzTndvZ0lDQWdMeThnSXlCVWNtRmpheUJzWlc1a1pYSWdZMjl1ZEhKcFluVjBhVzl1SUdsdUlHeHZZMkZzSUhOMFlYUmxDaUFnSUNBdkx5QnpaV3htTG1OdmJuUnlhV0oxZEdsdmJsdFVlRzR1YzJWdVpHVnlYU0E5SUhObGJHWXVZMjl1ZEhKcFluVjBhVzl1TG1kbGRDaFVlRzR1YzJWdVpHVnlMQ0JrWldaaGRXeDBQVlZKYm5RMk5DZ3dLU2tnS3lCd1lYbHRaVzUwTG1GdGIzVnVkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1OdmJuUnlhV0oxZEdsdmJpSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmpiMjUwY21saWRYUnBiMjRpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pjNENpQWdJQ0F2THlCelpXeG1MbVoxYm1SbFpGOWhiVzkxYm5RdWRtRnNkV1VnS3owZ2NHRjViV1Z1ZEM1aGJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSm1kVzVrWldSZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtWjFibVJsWkY5aGJXOTFiblFnWlhocGMzUnpDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbWRXNWtaV1JmWVcxdmRXNTBJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzRNQzA0TVFvZ0lDQWdMeThnSXlCQmRYUnZMWEpsYkdWaGMyVWdkMmhsYmlCbmIyRnNJR2x6SUcxbGRBb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1bWRXNWtaV1JmWVcxdmRXNTBMblpoYkhWbElENDlJSE5sYkdZdVoyOWhiRjloYlc5MWJuUXVkbUZzZFdVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWjI5aGJGOWhiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaMjloYkY5aGJXOTFiblFnWlhocGMzUnpDaUFnSUNBK1BRb2dJQ0FnWW5vZ1puVnVaRjlzYjJGdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnh2WVc1ZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJSE5sYkdZdVgzSmxiR1ZoYzJWZmRHOWZZbTl5Y205M1pYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCZmNtVnNaV0Z6WlY5MGIxOWliM0p5YjNkbGNnb0tablZ1WkY5c2IyRnVYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazl3ZEVsdUlsMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG14dllXNWZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVURzloYmtOdmJuUnlZV04wTG5KbGJHVmhjMlZmWm5WdVpITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5Wld4bFlYTmxYMloxYm1Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTVNrc0lDSk1iMkZ1SUdseklHNXZkQ0JwYmlCUFVFVk9JSE4wWVhSMWN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhkSFZ6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEc5aGJpQnBjeUJ1YjNRZ2FXNGdUMUJGVGlCemRHRjBkWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVtZFc1a1pXUmZZVzF2ZFc1MExuWmhiSFZsSUQ0OUlITmxiR1l1WjI5aGJGOWhiVzkxYm5RdWRtRnNkV1VzSUNKTWIyRnVJRzV2ZENCbWRXeHNlU0JtZFc1a1pXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVpuVnVaR1ZrWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bWRXNWtaV1JmWVcxdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1kdllXeGZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWR2WVd4ZllXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCTWIyRnVJRzV2ZENCbWRXeHNlU0JtZFc1a1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pnNUNpQWdJQ0F2THlCelpXeG1MbDl5Wld4bFlYTmxYM1J2WDJKdmNuSnZkMlZ5S0NrS0lDQWdJR05oYkd4emRXSWdYM0psYkdWaGMyVmZkRzlmWW05eWNtOTNaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJHOWhibDlqYjI1MGNtRmpkQzVqYjI1MGNtRmpkQzVNYjJGdVEyOXVkSEpoWTNRdWNtVndZWGxmYkc5aGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsY0dGNVgyeHZZVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWMzUmhkSFZ6TG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d6S1N3Z0lreHZZVzRnYVhNZ2JtOTBJR2x1SUhKbGNHRjViV1Z1ZENCd2FHRnpaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eklDOHZJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHOWhiaUJwY3lCdWIzUWdhVzRnY21Wd1lYbHRaVzUwSUhCb1lYTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVltOXljbTkzWlhJdWRtRnNkV1V1Ym1GMGFYWmxMQ0FpVDI1c2VTQmliM0p5YjNkbGNpQmpZVzRnY21Wd1lYa2lDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWW05eWNtOTNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOXljbTkzWlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWW05eWNtOTNaWElnWTJGdUlISmxjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1oyOGdkRzhnWVhCd0lnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0J0ZFhOMElHZHZJSFJ2SUdGd2NBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRBMkNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzVoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tzSUNKTmRYTjBJSE5sYm1RZ1lTQndiM05wZEdsMlpTQmhiVzkxYm5RaUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRTExYzNRZ2MyVnVaQ0JoSUhCdmMybDBhWFpsSUdGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QnpaV3htTG5KbGNHRnBaRjloYlc5MWJuUXVkbUZzZFdVZ0t6MGdjR0Y1YldWdWRDNWhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p5WlhCaGFXUmZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY0dGcFpGOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnlaWEJoYVdSZllXMXZkVzUwSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUdsbUlITmxiR1l1Y21Wd1lXbGtYMkZ0YjNWdWRDNTJZV3gxWlNBK1BTQnpaV3htTG1kdllXeGZZVzF2ZFc1MExuWmhiSFZsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWR2WVd4ZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZHZZV3hmWVcxdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnUGowS0lDQWdJR0o2SUhKbGNHRjVYMnh2WVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSFZ6TG5aaGJIVmxJRDBnVlVsdWREWTBLRFFwSUNNZ1EweFBVMFZFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHlaWEJoZVY5c2IyRnVYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViRzloYmw5amIyNTBjbUZqZEM1amIyNTBjbUZqZEM1TWIyRnVRMjl1ZEhKaFkzUXVZMnhoYVcxZmNtVndZWGx0Wlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnhoYVcxZmNtVndZWGx0Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRFM0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RRcExDQWlURzloYmlCcGN5QnViM1FnWTJ4dmMyVmtJSGxsZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGRIVnpJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFeHZZVzRnYVhNZ2JtOTBJR05zYjNObFpDQjVaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXhPUW9nSUNBZ0x5OGdiR1Z1WkdWeVgyTnZiblJ5YVdKMWRHbHZiaUE5SUhObGJHWXVZMjl1ZEhKcFluVjBhVzl1VzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZMjl1ZEhKcFluVjBhVzl1SWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOXVkSEpwWW5WMGFXOXVJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QmhiSEpsWVdSNVgyTnNZV2x0WldRZ1BTQnpaV3htTG1Oc1lXbHRaV1F1WjJWMEtGUjRiaTV6Wlc1a1pYSXNJR1JsWm1GMWJIUTlWVWx1ZERZMEtEQXBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKamJHRnBiV1ZrSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QmhjM05sY25RZ1lXeHlaV0ZrZVY5amJHRnBiV1ZrSUQwOUlGVkpiblEyTkNnd0tTd2dJa0ZzY21WaFpIa2dZMnhoYVcxbFpDSUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYkhKbFlXUjVJR05zWVdsdFpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUd4bGJtUmxjbDlqYjI1MGNtbGlkWFJwYjI0Z1BpQlZTVzUwTmpRb01Da3NJQ0pPYnlCamIyNTBjbWxpZFhScGIyNGdabTkxYm1RaUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCamIyNTBjbWxpZFhScGIyNGdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV5TkMweE1qVUtJQ0FnSUM4dklDTWdVSEp2TFhKaGRHRWdjMmhoY21VNklDaGpiMjUwY21saWRYUnBiMjRnS2lCeVpYQmhhV1JmWVcxdmRXNTBLU0F2THlCbmIyRnNYMkZ0YjNWdWRBb2dJQ0FnTHk4Z2MyaGhjbVVnUFNBb2JHVnVaR1Z5WDJOdmJuUnlhV0oxZEdsdmJpQXFJSE5sYkdZdWNtVndZV2xrWDJGdGIzVnVkQzUyWVd4MVpTa2dMeThnYzJWc1ppNW5iMkZzWDJGdGIzVnVkQzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5KbGNHRnBaRjloYlc5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21Wd1lXbGtYMkZ0YjNWdWRDQmxlR2x6ZEhNS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSm5iMkZzWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmIyRnNYMkZ0YjNWdWRDQmxlR2x6ZEhNS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXlOeTB4TXpFS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMmhoY21Vc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV6TUFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFeU55MHhNekVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWMyaGhjbVVzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUhObGJHWXVZMnhoYVcxbFpGdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbU5zWVdsdFpXUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNiMkZ1WDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGt4dllXNURiMjUwY21GamRDNWhaR1JmWjNWaGNtRnVkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtYMmQxWVhKaGJuUnZjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakV6T0FvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVpYjNKeWIzZGxjaTUyWVd4MVpTNXVZWFJwZG1Vc0lDSlBibXg1SUdKdmNuSnZkMlZ5SUdOaGJpQmhaR1FnWjNWaGNtRnVkRzl5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSnZjbkp2ZDJWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2Y25KdmQyVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHSnZjbkp2ZDJWeUlHTmhiaUJoWkdRZ1ozVmhjbUZ1ZEc5eUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TXprS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTVNrc0lDSkRZVzRnYjI1c2VTQmhaR1FnWjNWaGNtRnVkRzl5SUhkb1pXNGdiRzloYmlCcGN5QlBVRVZPSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRZVzRnYjI1c2VTQmhaR1FnWjNWaGNtRnVkRzl5SUhkb1pXNGdiRzloYmlCcGN5QlBVRVZPQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJSE5sYkdZdVozVmhjbUZ1ZEc5eUxuWmhiSFZsSUQwZ1ozVmhjbUZ1ZEc5eUNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmRXRnlZVzUwYjNJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXNiMkZ1WDJOdmJuUnlZV04wTG1OdmJuUnlZV04wTGt4dllXNURiMjUwY21GamRDNXRZWEpyWDJSbFptRjFiSFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdFlYSnJYMlJsWm1GMWJIUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHOWhibDlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveE5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5NTJZV3gxWlNBOVBTQlZTVzUwTmpRb015a3NJQ0pNYjJGdUlHMTFjM1FnWW1VZ2FXNGdVa1ZRUVZsSlRrY2djM1JoZEhWeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emRHRjBkWE1nWlhocGMzUnpDaUFnSUNCcGJuUmpYek1nTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNYjJGdUlHMTFjM1FnWW1VZ2FXNGdVa1ZRUVZsSlRrY2djM1JoZEhWekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TkRZS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQStJSE5sYkdZdVpHVmhaR3hwYm1VdWRtRnNkV1VzSUNKRVpXRmtiR2x1WlNCb1lYTWdibTkwSUhCaGMzTmxaQ0I1WlhRaUNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWkdWaFpHeHBibVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHVmhaR3hwYm1VZ1pYaHBjM1J6Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1JHVmhaR3hwYm1VZ2FHRnpJRzV2ZENCd1lYTnpaV1FnZVdWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG94TkRjS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RVcElDTWdSRVZHUVZWTVZFVkVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG14dllXNWZZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVURzloYmtOdmJuUnlZV04wTG1kbGRGOXNiMkZ1WDJsdVptOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmJHOWhibDlwYm1adk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4dllXNWZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCbmIyRnNYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtZHZZV3hmWVcxdmRXNTBMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbmIyRnNYMkZ0YjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVuYjJGc1gyRnRiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdablZ1WkdWa1gyRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1aMWJtUmxaRjloYlc5MWJuUXVkbUZzZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1aMWJtUmxaRjloYlc5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Wm5WdVpHVmtYMkZ0YjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYjJGdVgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExuQjVPakUxTlFvZ0lDQWdMeThnY21Wd1lXbGtYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuSmxjR0ZwWkY5aGJXOTFiblF1ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luSmxjR0ZwWkY5aGJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVndZV2xrWDJGdGIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFMU5nb2dJQ0FnTHk4Z2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1YzNSaGRIVnpMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhkSFZ6SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UVXlMVEUxTndvZ0lDQWdMeThnY21WMGRYSnVJRXh2WVc1SmJtWnZLQW9nSUNBZ0x5OGdJQ0FnSUdkdllXeGZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLSE5sYkdZdVoyOWhiRjloYlc5MWJuUXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR1oxYm1SbFpGOWhiVzkxYm5ROVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1bWRXNWtaV1JmWVcxdmRXNTBMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0J5WlhCaGFXUmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLSE5sYkdZdWNtVndZV2xrWDJGdGIzVnVkQzUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjM1JoZEhWekxuWmhiSFZsS1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2pFME9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ykc5aGJsOWpiMjUwY21GamRDNWpiMjUwY21GamRDNU1iMkZ1UTI5dWRISmhZM1F1WDNKbGJHVmhjMlZmZEc5ZlltOXljbTkzWlhJb0tTQXRQaUIyYjJsa09ncGZjbVZzWldGelpWOTBiMTlpYjNKeWIzZGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNiMkZ1WDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qa3pMVGszQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYTmxiR1l1WjI5aGJGOWhiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVpYjNKeWIzZGxjaTUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzVOQW9nSUNBZ0x5OGdZVzF2ZFc1MFBYTmxiR1l1WjI5aGJGOWhiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaMjloYkY5aGJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVoyOWhiRjloYlc5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ykc5aGJsOWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnY21WalpXbDJaWEk5YzJWc1ppNWliM0p5YjNkbGNpNTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZbTl5Y205M1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05eWNtOTNaWElnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2IyRnVYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbkI1T2prMkNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHZZVzVmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk9UTXRPVGNLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWMyVnNaaTVuYjJGc1gyRnRiM1Z1ZEM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbUp2Y25KdmQyVnlMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiRzloYmw5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NeWtnSXlCU1JWQkJXVWxPUndvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ2FXNTBZMTh6SUM4dklETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlBeVlMQm5OMFlYUjFjd3RuYjJGc1gyRnRiM1Z1ZEExbWRXNWtaV1JmWVcxdmRXNTBEWEpsY0dGcFpGOWhiVzkxYm5RSVltOXljbTkzWlhJSVpHVmhaR3hwYm1VSlozVmhjbUZ1ZEc5eURHTnZiblJ5YVdKMWRHbHZiZzEwYVdWeVgzSmxjWFZwY21Wa0RYUnBaWEpmWW1Ga1oyVmZhV1FIWTJ4aGFXMWxaREVZUUFBaUp3UXlBMmNwSW1jcUltY3JJbWNvSW1jbkJTSm5Kd1l5QTJjbkNDSm5Kd2tpWjRBRVNzMlRuVFlhQUk0QkFFa3hHUlJFTVJoQkFES0NCZ1RwU2tSTkJPTVoxQ01FK3lCcGVnVEY0UGszQkZhdWJzc0U5YlFKWFRZYUFJNEdBTDRBMUFFUUFVMEJiQUdDQUlBRTNJWHdkallhQUk0QkFBd0FNUmtqRWpFWUVFUkNBRlUyR2dGSkZTUVNSRFlhQWtrVkpCSkVOaG9EU1JVa0VrUTJHZ1JKRlNRU1JDY0VNUUJuVHdNWEtVeG5LaUpuS3lKbktDTm5NZ2RQQXhlQmdLTUZDd2duQlV4bkp3WXlBMmRNRnljSVRHY1hKd2xNWnlORE1SWWpDVWs0RUNNU1JDSW9aVVFqRWtReUJ5SW5CV1ZFREVSSk9BY3lDaEpFT0FoSlJERUFJaWNIWXlKT0FrMUxBUWd4QUNjSFR3Sm1JaXBsUkFncVN3Rm5JaWxsUkE5QkFBT0lBTzhqUXlJb1pVUWpFa1FpS21WRUlpbGxSQTlFaUFEWkkwTXhGaU1KU1RnUUl4SkVJaWhsUkNVU1JERUFJaWNFWlVRU1JFazRCeklLRWtRNENFbEVJaXRsUkFnclN3Rm5JaWxsUkE5QkFBUW9nUVJuSTBNaUtHVkVnUVFTUkRFQUlpY0hZMFF4QUNJbkNtTWlUZ0pORkVSSlJDSXJaVVFMSWlsbFJBcXhNUUN5QjdJSUk3SVFJcklCc3pFQUp3b2paaU5ETmhvQlNSV0JJQkpFTVFBaUp3UmxSQkpFSWlobFJDTVNSQ2NHVEdjalF5SW9aVVFsRWtReUJ5SW5CV1ZFRFVRb2dRVm5JME1pS1dWRUZpSXFaVVFXSWl0bFJCWWlLR1ZFRms4RFR3TlFUd0pRVEZDQUJCVWZmSFZNVUxBalE3RWlLV1ZFSWljRVpVU3lCN0lJSTdJUUlySUJzeWdsWjRrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
