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

namespace Arc56.Generated.nickthelegend.irion_contracts.CreditScore_829f8322
{


    public class CreditScoreProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CreditScoreProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CreditProfile : AVMObjectType
            {
                public ulong Score { get; set; }

                public ulong TotalBorrowed { get; set; }

                public ulong TotalRepaid { get; set; }

                public ulong ActiveLoans { get; set; }

                public ulong OnTimeRepayments { get; set; }

                public ulong LateRepayments { get; set; }

                public ulong LendingPoolDeposits { get; set; }

                public ulong LastUpdatedRound { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScore.From(Score);
                    ret.AddRange(vScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBorrowed.From(TotalBorrowed);
                    ret.AddRange(vTotalBorrowed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalRepaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalRepaid.From(TotalRepaid);
                    ret.AddRange(vTotalRepaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActiveLoans = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActiveLoans.From(ActiveLoans);
                    ret.AddRange(vActiveLoans.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnTimeRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOnTimeRepayments.From(OnTimeRepayments);
                    ret.AddRange(vOnTimeRepayments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLateRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLateRepayments.From(LateRepayments);
                    ret.AddRange(vLateRepayments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLendingPoolDeposits = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLendingPoolDeposits.From(LendingPoolDeposits);
                    ret.AddRange(vLendingPoolDeposits.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdatedRound.From(LastUpdatedRound);
                    ret.AddRange(vLastUpdatedRound.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CreditProfile Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CreditProfile();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScore = vScore.ToValue();
                    if (valueScore is ulong vScoreValue) { ret.Score = vScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBorrowed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBorrowed = vTotalBorrowed.ToValue();
                    if (valueTotalBorrowed is ulong vTotalBorrowedValue) { ret.TotalBorrowed = vTotalBorrowedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalRepaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalRepaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalRepaid = vTotalRepaid.ToValue();
                    if (valueTotalRepaid is ulong vTotalRepaidValue) { ret.TotalRepaid = vTotalRepaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActiveLoans = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActiveLoans.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActiveLoans = vActiveLoans.ToValue();
                    if (valueActiveLoans is ulong vActiveLoansValue) { ret.ActiveLoans = vActiveLoansValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnTimeRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOnTimeRepayments.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnTimeRepayments = vOnTimeRepayments.ToValue();
                    if (valueOnTimeRepayments is ulong vOnTimeRepaymentsValue) { ret.OnTimeRepayments = vOnTimeRepaymentsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLateRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLateRepayments.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLateRepayments = vLateRepayments.ToValue();
                    if (valueLateRepayments is ulong vLateRepaymentsValue) { ret.LateRepayments = vLateRepaymentsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLendingPoolDeposits = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLendingPoolDeposits.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLendingPoolDeposits = vLendingPoolDeposits.ToValue();
                    if (valueLendingPoolDeposits is ulong vLendingPoolDepositsValue) { ret.LendingPoolDeposits = vLendingPoolDepositsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdatedRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdatedRound = vLastUpdatedRound.ToValue();
                    if (valueLastUpdatedRound is ulong vLastUpdatedRoundValue) { ret.LastUpdatedRound = vLastUpdatedRoundValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CreditProfile);
                }
                public bool Equals(CreditProfile? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CreditProfile left, CreditProfile right)
                {
                    return EqualityComparer<CreditProfile>.Default.Equals(left, right);
                }
                public static bool operator !=(CreditProfile left, CreditProfile right)
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
        ///
        ///</summary>
        public async Task Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateProfile(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 101, 140, 169 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateProfile_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 101, 140, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="amount"> </param>
        public async Task UpdateScoreOnDeposit(Algorand.Address user, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 241, 223, 236 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateScoreOnDeposit_Transactions(Algorand.Address user, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 241, 223, 236 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="amount"> </param>
        public async Task UpdateScoreOnBorrow(Algorand.Address user, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 42, 69, 150 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateScoreOnBorrow_Transactions(Algorand.Address user, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 42, 69, 150 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="amount"> </param>
        /// <param name="on_time"> </param>
        public async Task UpdateScoreOnRepay(Algorand.Address user, ulong amount, bool on_time, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 62, 140, 205 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var on_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); on_timeAbi.From(on_time);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, amountAbi, on_timeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateScoreOnRepay_Transactions(Algorand.Address user, ulong amount, bool on_time, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 62, 140, 205 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var on_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); on_timeAbi.From(on_time);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, amountAbi, on_timeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task UpdateScoreOnDefault(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 181, 19, 205 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateScoreOnDefault_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 181, 19, 205 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetScore(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetScore_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 91, 114, 12 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetBorrowLimit(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 165, 173, 48 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBorrowLimit_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 165, 173, 48 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<Structs.CreditProfile> GetCreditProfile(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 224, 253, 71 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CreditProfile.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCreditProfile_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 224, 253, 71 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task SetLendingPoolApp(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 203, 158, 37 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLendingPoolApp_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 203, 158, 37 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlZGl0U2NvcmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ3JlZGl0UHJvZmlsZSI6W3sibmFtZSI6InNjb3JlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX2JvcnJvd2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX3JlcGFpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmVfbG9hbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib25fdGltZV9yZXBheW1lbnRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImxhdGVfcmVwYXltZW50cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsZW5kaW5nX3Bvb2xfZGVwb3NpdHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdF91cGRhdGVkX3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIiwiT3B0SW4iXSwiY2FsbCI6WyJOb09wIiwiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfcHJvZmlsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfc2NvcmVfb25fZGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9zY29yZV9vbl9ib3Jyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfc2NvcmVfb25fcmVwYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uX3RpbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3Njb3JlX29uX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Njb3JlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYm9ycm93X2xpbWl0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY3JlZGl0X3Byb2ZpbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQ3JlZGl0UHJvZmlsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2xlbmRpbmdfcG9vbF9hcHAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjkwLDM1OSw0NDQsNTU3LDgzNCw5NjBdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgb25lIG9mIE5vT3AsIE9wdEluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MywzNDIsNDA4LDU1MSw1ODUsNjAzLDc0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODIsMzUxLDQxNyw5MDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRE15SURNd01DQTROVEFnTVRBd01EQXdNREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbU1pSURCNE1UVXhaamRqTnpVZ0lteGxibVJwYm1kZmNHOXZiRjloY0hCZmFXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGNtVmthWFJUWTI5eVpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSmxZemMyWkRnM0lDOHZJRzFsZEdodlpDQWlZbTl2ZEhOMGNtRndLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5aWIyOTBjM1J5WVhCZmNtOTFkR1ZBTWdvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkRjbVZrYVhSVFkyOXlaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFV3TmpVNFkyRTVJREI0TldObU1XUm1aV01nTUhoaU9ESmhORFU1TmlBd2VEazNNMlU0WTJOa0lEQjRZakppTlRFelkyUWdNSGd5TURWaU56SXdZeUF3ZUdGbVlUVmhaRE13SURCNFpUSmxNR1prTkRjZ01IZzVOV05pT1dVeU5TQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpWOXdjbTltYVd4bEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZmYzJOdmNtVmZiMjVmWkdWd2IzTnBkQ2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZmYzJOdmNtVmZiMjVmWW05eWNtOTNLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjl6WTI5eVpWOXZibDl5WlhCaGVTaGhaR1J5WlhOekxIVnBiblEyTkN4aWIyOXNLWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlY5elkyOXlaVjl2Ymw5a1pXWmhkV3gwS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDNOamIzSmxLR0ZrWkhKbGMzTXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWW05eWNtOTNYMnhwYldsMEtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZZM0psWkdsMFgzQnliMlpwYkdVb1lXUmtjbVZ6Y3lrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbk5sZEY5c1pXNWthVzVuWDNCdmIyeGZZWEJ3S0hWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbFgzQnliMlpwYkdVZ2RYQmtZWFJsWDNOamIzSmxYMjl1WDJSbGNHOXphWFFnZFhCa1lYUmxYM05qYjNKbFgyOXVYMkp2Y25KdmR5QjFjR1JoZEdWZmMyTnZjbVZmYjI1ZmNtVndZWGtnZFhCa1lYUmxYM05qYjNKbFgyOXVYMlJsWm1GMWJIUWdaMlYwWDNOamIzSmxJR2RsZEY5aWIzSnliM2RmYkdsdGFYUWdaMlYwWDJOeVpXUnBkRjl3Y205bWFXeGxJSE5sZEY5c1pXNWthVzVuWDNCdmIyeGZZWEJ3Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJEY21Wa2FYUlRZMjl5WlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSak5XTTJNV0poSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTVRZS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZjbTkxZEdWQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVG05UGNDZGRMQ0J2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKdmIzUnpkSEpoY0Y5eWIzVjBaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lCYkowNXZUM0FuTENBblQzQjBTVzRuWFN3Z2IyNURjbVZoZEdVNklDZGhiR3h2ZHljZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCemFHd0tJQ0FnSUhCMWMyaHBiblFnTXlBdkx5QXpDaUFnSUNBbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ2IyNWxJRzltSUU1dlQzQXNJRTl3ZEVsdUNpQWdJQ0JpSUdKdmIzUnpkSEpoY0FvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTNKbFpHbDBVMk52Y21VdVltOXZkSE4wY21Gd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl2ZEhOMGNtRndPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ0YVc1ZmMyTnZjbVVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJXbHVYM05qYjNKbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QjBhR2x6TG0xcGJsOXpZMjl5WlM1MllXeDFaU0E5SUUxSlRsOVRRMDlTUlFvZ0lDQWdhVzUwWTE4eklDOHZJRE13TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2JXRjRYM05qYjNKbElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbTFoZUY5elkyOXlaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnZEdocGN5NXRZWGhmYzJOdmNtVXVkbUZzZFdVZ1BTQk5RVmhmVTBOUFVrVUtJQ0FnSUdsdWRHTWdOQ0F2THlBNE5UQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJR3hsYm1ScGJtZGZjRzl2YkY5aGNIQmZhV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteGxibVJwYm1kZmNHOXZiRjloY0hCZmFXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJSFJvYVhNdWJHVnVaR2x1WjE5d2IyOXNYMkZ3Y0Y5cFpDNTJZV3gxWlNBOUlGVnBiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25UbTlQY0Njc0lDZFBjSFJKYmlkZExDQnZia055WldGMFpUb2dKMkZzYkc5M0p5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRM0psWkdsMFUyTnZjbVV1WTNKbFlYUmxYM0J5YjJacGJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZjSEp2Wm1sc1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdiR0Z6ZEY5MWNHUmhkR1ZrWDNKdmRXNWtPaUJIYkc5aVlXd3VjbTkxYm1Rc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5TMDJOQW9nSUNBZ0x5OGdZMjl1YzNRZ2FXNXBkR2xoYkY5d2NtOW1hV3hsT2lCRGNtVmthWFJRY205bWFXeGxJRDBnZXdvZ0lDQWdMeThnSUNCelkyOXlaVG9nVFVsT1gxTkRUMUpGTEFvZ0lDQWdMeThnSUNCMGIzUmhiRjlpYjNKeWIzZGxaRG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNCMGIzUmhiRjl5WlhCaGFXUTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnWVdOMGFYWmxYMnh2WVc1ek9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJRzl1WDNScGJXVmZjbVZ3WVhsdFpXNTBjem9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNCc1lYUmxYM0psY0dGNWJXVnVkSE02SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2JHVnVaR2x1WjE5d2IyOXNYMlJsY0c5emFYUnpPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUd4aGMzUmZkWEJrWVhSbFpGOXliM1Z1WkRvZ1IyeHZZbUZzTG5KdmRXNWtMQW9nSUNBZ0x5OGdmUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURFeVl6QXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklHTnlaV1JwZEY5d2NtOW1hV3hsY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCRGNtVmthWFJRY205bWFXeGxQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCMGFHbHpMbU55WldScGRGOXdjbTltYVd4bGN5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJR05zYjI1bEtHbHVhWFJwWVd4ZmNISnZabWxzWlNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWTNKbFpHbDBYM0J5YjJacGJHVnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU55WldScGRGQnliMlpwYkdVK0tIc2dhMlY1VUhKbFptbDRPaUFuWXljZ2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxtTnlaV1JwZEY5d2NtOW1hV3hsY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHTnNiMjVsS0dsdWFYUnBZV3hmY0hKdlptbHNaU2tLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERjbVZrYVhSVFkyOXlaUzUxY0dSaGRHVmZjMk52Y21WZmIyNWZaR1Z3YjNOcGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpWOXpZMjl5WlY5dmJsOWtaWEJ2YzJsME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QndkV0pzYVdNZ2RYQmtZWFJsWDNOamIzSmxYMjl1WDJSbGNHOXphWFFvZFhObGNqb2dRV05qYjNWdWRDd2dZVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJqY21Wa2FYUmZjSEp2Wm1sc1pYTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRM0psWkdsMFVISnZabWxzWlQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVl5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklHTnZibk4wSUhCeWIyWnBiR1VnUFNCamJHOXVaU2gwYUdsekxtTnlaV1JwZEY5d2NtOW1hV3hsY3loMWMyVnlLUzUyWVd4MVpTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdZMjl1YzNRZ1pHVndiM05wZEY5cGJtTnlaV0Z6WlRvZ2RXbHVkRFkwSUQwZ1lXMXZkVzUwSUM4Z1ZXbHVkRFkwS0RFd1h6QXdNRjh3TURBcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFl5QTFJQzh2SURFd01EQXdNREF3Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJR052Ym5OMElHTmhjSEJsWkY5aWIyNTFjem9nZFdsdWREWTBJRDBnYzJOdmNtVmZZbTl1ZFhNZ1BpQk5RVmhmUkVWUVQxTkpWRjlDVDA1VlV5QS9JRTFCV0Y5RVJWQlBVMGxVWDBKUFRsVlRJRG9nYzJOdmNtVmZZbTl1ZFhNS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXlNREFnTHk4Z01qQXdDaUFnSUNBK0NpQWdJQ0J3ZFhOb2FXNTBJREl3TUNBdkx5QXlNREFLSUNBZ0lITjNZWEFLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0J1WlhkZmMyTnZjbVU2SUhWcGJuUTJOQ0E5SUhSb2FYTXVZMnhoYlhCZmMyTnZjbVVvY0hKdlptbHNaUzV6WTI5eVpTQXJJR05oY0hCbFpGOWliMjUxY3lrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQ3NLSUNBZ0lHTmhiR3h6ZFdJZ1kyeGhiWEJmYzJOdmNtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdjSEp2Wm1sc1pTNXpZMjl5WlNBOUlHNWxkMTl6WTI5eVpRb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCd2NtOW1hV3hsTG14bGJtUnBibWRmY0c5dmJGOWtaWEJ2YzJsMGN5QTlJSEJ5YjJacGJHVXViR1Z1WkdsdVoxOXdiMjlzWDJSbGNHOXphWFJ6SUNzZ1lXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EZ2dMeThnTkRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURRNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Z0tJQ0FnSUM4dklIQnliMlpwYkdVdWJHRnpkRjkxY0dSaGRHVmtYM0p2ZFc1a0lEMGdSMnh2WW1Gc0xuSnZkVzVrQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEVTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJSFJvYVhNdVkzSmxaR2wwWDNCeWIyWnBiR1Z6S0hWelpYSXBMblpoYkhWbElEMGdZMnh2Ym1Vb2NISnZabWxzWlNrS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdjSFZpYkdsaklIVndaR0YwWlY5elkyOXlaVjl2Ymw5a1pYQnZjMmwwS0hWelpYSTZJRUZqWTI5MWJuUXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGNtVmthWFJUWTI5eVpTNTFjR1JoZEdWZmMyTnZjbVZmYjI1ZlltOXljbTkzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsWDNOamIzSmxYMjl1WDJKdmNuSnZkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnY0hWaWJHbGpJSFZ3WkdGMFpWOXpZMjl5WlY5dmJsOWliM0p5YjNjb2RYTmxjam9nUVdOamIzVnVkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCamNtVmthWFJmY0hKdlptbHNaWE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUTNKbFpHbDBVSEp2Wm1sc1pUNG9leUJyWlhsUWNtVm1hWGc2SUNkakp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZeUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJR052Ym5OMElIQnliMlpwYkdVZ1BTQmpiRzl1WlNoMGFHbHpMbU55WldScGRGOXdjbTltYVd4bGN5aDFjMlZ5S1M1MllXeDFaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWTI5dWMzUWdibVYzWDNOamIzSmxPaUIxYVc1ME5qUWdQU0IwYUdsekxtTnNZVzF3WDNOamIzSmxLSEJ5YjJacGJHVXVjMk52Y21VZ0xTQk9SVmRmVEU5QlRsOVFSVTVCVEZSWktRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdOU0F2THlBMUNpQWdJQ0F0Q2lBZ0lDQmpZV3hzYzNWaUlHTnNZVzF3WDNOamIzSmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJSEJ5YjJacGJHVXVjMk52Y21VZ1BTQnVaWGRmYzJOdmNtVUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z2NISnZabWxzWlM1MGIzUmhiRjlpYjNKeWIzZGxaQ0E5SUhCeWIyWnBiR1V1ZEc5MFlXeGZZbTl5Y205M1pXUWdLeUJoYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPUW9nSUNBZ0x5OGdjSEp2Wm1sc1pTNWhZM1JwZG1WZmJHOWhibk1nUFNCd2NtOW1hV3hsTG1GamRHbDJaVjlzYjJGdWN5QXJJRlZwYm5RMk5DZ3hLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMElDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURJMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklIQnliMlpwYkdVdWJHRnpkRjkxY0dSaGRHVmtYM0p2ZFc1a0lEMGdSMnh2WW1Gc0xuSnZkVzVrQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEVTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJSFJvYVhNdVkzSmxaR2wwWDNCeWIyWnBiR1Z6S0hWelpYSXBMblpoYkhWbElEMGdZMnh2Ym1Vb2NISnZabWxzWlNrS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdjSFZpYkdsaklIVndaR0YwWlY5elkyOXlaVjl2Ymw5aWIzSnliM2NvZFhObGNqb2dRV05qYjNWdWRDd2dZVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOeVpXUnBkRk5qYjNKbExuVndaR0YwWlY5elkyOXlaVjl2Ymw5eVpYQmhlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVjl6WTI5eVpWOXZibDl5WlhCaGVUb0tJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazFDaUFnSUNBdkx5QndkV0pzYVdNZ2RYQmtZWFJsWDNOamIzSmxYMjl1WDNKbGNHRjVLSFZ6WlhJNklFRmpZMjkxYm5Rc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwTENCdmJsOTBhVzFsT2lCaWIyOXNaV0Z1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWTNKbFpHbDBYM0J5YjJacGJHVnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRU55WldScGRGQnliMlpwYkdVK0tIc2dhMlY1VUhKbFptbDRPaUFuWXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR052Ym5OMElIQnliMlpwYkdVZ1BTQmpiRzl1WlNoMGFHbHpMbU55WldScGRGOXdjbTltYVd4bGN5aDFjMlZ5S1M1MllXeDFaU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklHbG1JQ2h2Ymw5MGFXMWxLU0I3Q2lBZ0lDQmllaUIxY0dSaGRHVmZjMk52Y21WZmIyNWZjbVZ3WVhsZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREFLSUNBZ0lDOHZJSEJ5YjJacGJHVXViMjVmZEdsdFpWOXlaWEJoZVcxbGJuUnpJRDBnY0hKdlptbHNaUzV2Ymw5MGFXMWxYM0psY0dGNWJXVnVkSE1nS3lCVmFXNTBOalFvTVNrS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlETXlDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUhOamIzSmxYMk5vWVc1blpTQTlJRTlPWDFSSlRVVmZVa1ZRUVZsTlJVNVVYMEpQVGxWVENpQWdJQ0J3ZFhOb2FXNTBJREl3SUM4dklESXdDaUFnSUNCaWRYSjVJRFVLQ25Wd1pHRjBaVjl6WTI5eVpWOXZibDl5WlhCaGVWOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTRMVEV4TUFvZ0lDQWdMeThnWTI5dWMzUWdibVYzWDNOamIzSmxPaUIxYVc1ME5qUWdQU0J2Ymw5MGFXMWxDaUFnSUNBdkx5QWdJRDhnZEdocGN5NWpiR0Z0Y0Y5elkyOXlaU2h3Y205bWFXeGxMbk5qYjNKbElDc2djMk52Y21WZlkyaGhibWRsS1FvZ0lDQWdMeThnSUNBNklIUm9hWE11WTJ4aGJYQmZjMk52Y21Vb2NISnZabWxzWlM1elkyOXlaU0F0SUhOamIzSmxYMk5vWVc1blpTa0tJQ0FnSUdScFp5QXlDaUFnSUNCaWVpQjFjR1JoZEdWZmMyTnZjbVZmYjI1ZmNtVndZWGxmZEdWeWJtRnllVjltWVd4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUEvSUhSb2FYTXVZMnhoYlhCZmMyTnZjbVVvY0hKdlptbHNaUzV6WTI5eVpTQXJJSE5qYjNKbFgyTm9ZVzVuWlNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdLd29nSUNBZ1kyRnNiSE4xWWlCamJHRnRjRjl6WTI5eVpRb0tkWEJrWVhSbFgzTmpiM0psWDI5dVgzSmxjR0Y1WDNSbGNtNWhjbmxmYldWeVoyVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUhCeWIyWnBiR1V1YzJOdmNtVWdQU0J1WlhkZmMyTnZjbVVLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV5Q2lBZ0lDQXZMeUJ3Y205bWFXeGxMblJ2ZEdGc1gzSmxjR0ZwWkNBOUlIQnliMlpwYkdVdWRHOTBZV3hmY21Wd1lXbGtJQ3NnWVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ01UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVE1LSUNBZ0lDOHZJSEJ5YjJacGJHVXVZV04wYVhabFgyeHZZVzV6SUQwZ2NISnZabWxzWlM1aFkzUnBkbVZmYkc5aGJuTWdMU0JWYVc1ME5qUW9NU2tLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5DQXZMeUF5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBeU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOQW9nSUNBZ0x5OGdjSEp2Wm1sc1pTNXNZWE4wWDNWd1pHRjBaV1JmY205MWJtUWdQU0JIYkc5aVlXd3VjbTkxYm1RS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdOVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUhSb2FYTXVZM0psWkdsMFgzQnliMlpwYkdWektIVnpaWElwTG5aaGJIVmxJRDBnWTJ4dmJtVW9jSEp2Wm1sc1pTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUhCMVlteHBZeUIxY0dSaGRHVmZjMk52Y21WZmIyNWZjbVZ3WVhrb2RYTmxjam9nUVdOamIzVnVkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXNJRzl1WDNScGJXVTZJR0p2YjJ4bFlXNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDblZ3WkdGMFpWOXpZMjl5WlY5dmJsOXlaWEJoZVY5MFpYSnVZWEo1WDJaaGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFd0NpQWdJQ0F2THlBNklIUm9hWE11WTJ4aGJYQmZjMk52Y21Vb2NISnZabWxzWlM1elkyOXlaU0F0SUhOamIzSmxYMk5vWVc1blpTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnTFFvZ0lDQWdZMkZzYkhOMVlpQmpiR0Z0Y0Y5elkyOXlaUW9nSUNBZ1lpQjFjR1JoZEdWZmMyTnZjbVZmYjI1ZmNtVndZWGxmZEdWeWJtRnllVjl0WlhKblpVQTNDZ3AxY0dSaGRHVmZjMk52Y21WZmIyNWZjbVZ3WVhsZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJ3Y205bWFXeGxMbXhoZEdWZmNtVndZWGx0Wlc1MGN5QTlJSEJ5YjJacGJHVXViR0YwWlY5eVpYQmhlVzFsYm5SeklDc2dWV2x1ZERZMEtERXBDaUFnSUNCa2RYQnVJRElLSUNBZ0lIQjFjMmhwYm5RZ05EQWdMeThnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05EQUtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TkFvZ0lDQWdMeThnYzJOdmNtVmZZMmhoYm1kbElEMGdURUZVUlY5U1JWQkJXVTFGVGxSZlVFVk9RVXhVV1FvZ0lDQWdjSFZ6YUdsdWRDQXpNQ0F2THlBek1Bb2dJQ0FnWW5WeWVTQTFDaUFnSUNCaUlIVndaR0YwWlY5elkyOXlaVjl2Ymw5eVpYQmhlVjloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnlaV1JwZEZOamIzSmxMblZ3WkdGMFpWOXpZMjl5WlY5dmJsOWtaV1poZFd4MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgzTmpiM0psWDI5dVgyUmxabUYxYkhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QndkV0pzYVdNZ2RYQmtZWFJsWDNOamIzSmxYMjl1WDJSbFptRjFiSFFvZFhObGNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklHTnlaV1JwZEY5d2NtOW1hV3hsY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCRGNtVmthWFJRY205bWFXeGxQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXdDaUFnSUNBdkx5QmpiMjV6ZENCd2NtOW1hV3hsSUQwZ1kyeHZibVVvZEdocGN5NWpjbVZrYVhSZmNISnZabWxzWlhNb2RYTmxjaWt1ZG1Gc2RXVXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUJqYjI1emRDQnVaWGRmYzJOdmNtVTZJSFZwYm5RMk5DQTlJSFJvYVhNdVkyeGhiWEJmYzJOdmNtVW9jSEp2Wm1sc1pTNXpZMjl5WlNBdElFUkZSa0ZWVEZSZlVFVk9RVXhVV1NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElERXdNQ0F2THlBeE1EQUtJQ0FnSUMwS0lDQWdJR05oYkd4emRXSWdZMnhoYlhCZmMyTnZjbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpNS0lDQWdJQzh2SUhCeWIyWnBiR1V1YzJOdmNtVWdQU0J1WlhkZmMyTnZjbVVLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalFLSUNBZ0lDOHZJSEJ5YjJacGJHVXViR0Z6ZEY5MWNHUmhkR1ZrWDNKdmRXNWtJRDBnUjJ4dlltRnNMbkp2ZFc1a0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRFUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCMGFHbHpMbU55WldScGRGOXdjbTltYVd4bGN5aDFjMlZ5S1M1MllXeDFaU0E5SUdOc2IyNWxLSEJ5YjJacGJHVXBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNUNpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxYM05qYjNKbFgyOXVYMlJsWm1GMWJIUW9kWE5sY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTNKbFpHbDBVMk52Y21VdVoyVjBYM05qYjNKbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNOamIzSmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEY21Wa2FYUlRZMjl5WlM1blpYUmZjMk52Y21VS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOeVpXUnBkRk5qYjNKbExtZGxkRjlpYjNKeWIzZGZiR2x0YVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWW05eWNtOTNYMnhwYldsME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRrS0lDQWdJQzh2SUdOdmJuTjBJSE5qYjNKbE9pQjFhVzUwTmpRZ1BTQjBhR2x6TG1kbGRGOXpZMjl5WlNoMWMyVnlLUW9nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnlaV1JwZEZOamIzSmxMbWRsZEY5elkyOXlaUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV4Q2lBZ0lDQXZMeUJwWmlBb2MyTnZjbVVnUENCVmFXNTBOalFvTXpBd0tTa2dld29nSUNBZ2FXNTBZMTh6SUM4dklETXdNQW9nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBYMkp2Y25KdmQxOXNhVzFwZEY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUhKbGRIVnliaUJWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3BuWlhSZlltOXljbTkzWDJ4cGJXbDBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERjbVZrYVhSVFkyOXlaUzVuWlhSZlltOXljbTkzWDJ4cGJXbDBRREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSZlltOXljbTkzWDJ4cGJXbDBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFFLSUNBZ0lDOHZJR2xtSUNoelkyOXlaU0E4SUZWcGJuUTJOQ2d6TlRBcEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXpVd0lDOHZJRE0xTUFvZ0lDQWdQQW9nSUNBZ1lub2daMlYwWDJKdmNuSnZkMTlzYVcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklISmxkSFZ5YmlCVmFXNTBOalFvTVRCZk1EQXdYekF3TUNrZ0lDQWdJQ0FnTHk4Z0pERXdJQzBnVG1WM0lIVnpaWElnYzNSaGNuUmxjaUJzYVcxcGRBb2dJQ0FnYVc1MFl5QTFJQzh2SURFd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdJZ1oyVjBYMkp2Y25KdmQxOXNhVzFwZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTNKbFpHbDBVMk52Y21VdVoyVjBYMkp2Y25KdmQxOXNhVzFwZEVBeE9Bb0taMlYwWDJKdmNuSnZkMTlzYVcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTNDaUFnSUNBdkx5QnBaaUFvYzJOdmNtVWdQQ0JWYVc1ME5qUW9OREF3S1NrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF3TUNBdkx5QTBNREFLSUNBZ0lEd0tJQ0FnSUdKNklHZGxkRjlpYjNKeWIzZGZiR2x0YVhSZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCeVpYUjFjbTRnVldsdWREWTBLREkxWHpBd01GOHdNREFwSUNBZ0lDQWdJQzh2SUNReU5TQXRJRUZtZEdWeUlERWdiMjR0ZEdsdFpTQnlaWEJoZVcxbGJuUUtJQ0FnSUhCMWMyaHBiblFnTWpVd01EQXdNREFnTHk4Z01qVXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQm5aWFJmWW05eWNtOTNYMnhwYldsMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGNtVmthWFJUWTI5eVpTNW5aWFJmWW05eWNtOTNYMnhwYldsMFFERTRDZ3BuWlhSZlltOXljbTkzWDJ4cGJXbDBYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOakFLSUNBZ0lDOHZJR2xtSUNoelkyOXlaU0E4SUZWcGJuUTJOQ2cwTlRBcEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTkRVd0lDOHZJRFExTUFvZ0lDQWdQQW9nSUNBZ1lub2daMlYwWDJKdmNuSnZkMTlzYVcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qRUtJQ0FnSUM4dklISmxkSFZ5YmlCVmFXNTBOalFvTlRCZk1EQXdYekF3TUNrZ0lDQWdJQ0FnTHk4Z0pEVXdJQzBnUVdaMFpYSWdNaUJ2YmkxMGFXMWxJSEpsY0dGNWJXVnVkSE1LSUNBZ0lIQjFjMmhwYm5RZ05UQXdNREF3TURBZ0x5OGdOVEF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZaUJuWlhSZlltOXljbTkzWDJ4cGJXbDBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERjbVZrYVhSVFkyOXlaUzVuWlhSZlltOXljbTkzWDJ4cGJXbDBRREU0Q2dwblpYUmZZbTl5Y205M1gyeHBiV2wwWDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpNS0lDQWdJQzh2SUdsbUlDaHpZMjl5WlNBOElGVnBiblEyTkNnMU1EQXBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05UQXdJQzh2SURVd01Bb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFgySnZjbkp2ZDE5c2FXMXBkRjloWm5SbGNsOXBabDlsYkhObFFERXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWV2x1ZERZMEtERXdNRjh3TURCZk1EQXdLU0FnSUNBZ0lDOHZJQ1F4TURBZ0xTQkJablJsY2lBekt5QnZiaTEwYVcxbElISmxjR0Y1YldWdWRITUtJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3SUM4dklERXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmlJR2RsZEY5aWIzSnliM2RmYkdsdGFYUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnlaV1JwZEZOamIzSmxMbWRsZEY5aWIzSnliM2RmYkdsdGFYUkFNVGdLQ21kbGRGOWliM0p5YjNkZmJHbHRhWFJmWVdaMFpYSmZhV1pmWld4elpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpZS0lDQWdJQzh2SUdsbUlDaHpZMjl5WlNBOElGVnBiblEyTkNnMk1EQXBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05qQXdJQzh2SURZd01Bb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFgySnZjbkp2ZDE5c2FXMXBkRjloWm5SbGNsOXBabDlsYkhObFFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWV2x1ZERZMEtEVXdNRjh3TURCZk1EQXdLU0FnSUNBZ0lDOHZJQ1ExTURBS0lDQWdJSEIxYzJocGJuUWdOVEF3TURBd01EQXdJQzh2SURVd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaUlHZGxkRjlpYjNKeWIzZGZiR2x0YVhSZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOeVpXUnBkRk5qYjNKbExtZGxkRjlpYjNKeWIzZGZiR2x0YVhSQU1UZ0tDbWRsZEY5aWIzSnliM2RmYkdsdGFYUmZZV1owWlhKZmFXWmZaV3h6WlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamtLSUNBZ0lDOHZJR2xtSUNoelkyOXlaU0E4SUZWcGJuUTJOQ2czTURBcEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTnpBd0lDOHZJRGN3TUFvZ0lDQWdQQW9nSUNBZ1lub2daMlYwWDJKdmNuSnZkMTlzYVcxcGRGOWhablJsY2w5cFpsOWxiSE5sUURFMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3dDaUFnSUNBdkx5QnlaWFIxY200Z1ZXbHVkRFkwS0RKZk1EQXdYekF3TUY4d01EQXBJQ0FnSUM4dklDUXlMREF3TUFvZ0lDQWdjSFZ6YUdsdWRDQXlNREF3TURBd01EQXdJQzh2SURJd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQm5aWFJmWW05eWNtOTNYMnhwYldsMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGNtVmthWFJUWTI5eVpTNW5aWFJmWW05eWNtOTNYMnhwYldsMFFERTRDZ3BuWlhSZlltOXljbTkzWDJ4cGJXbDBYMkZtZEdWeVgybG1YMlZzYzJWQU1UVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJwWmlBb2MyTnZjbVVnUENCVmFXNTBOalFvTnpVd0tTa2dld29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURjMU1DQXZMeUEzTlRBS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5aWIzSnliM2RmYkdsdGFYUmZZV1owWlhKZmFXWmZaV3h6WlVBeE53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdjbVYwZFhKdUlGVnBiblEyTkNnMVh6QXdNRjh3TURCZk1EQXdLU0FnSUNBdkx5QWtOU3d3TURBS0lDQWdJSEIxYzJocGJuUWdOVEF3TURBd01EQXdNQ0F2THlBMU1EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSWdaMlYwWDJKdmNuSnZkMTlzYVcxcGRGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEzSmxaR2wwVTJOdmNtVXVaMlYwWDJKdmNuSnZkMTlzYVcxcGRFQXhPQW9LWjJWMFgySnZjbkp2ZDE5c2FXMXBkRjloWm5SbGNsOXBabDlsYkhObFFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTlFvZ0lDQWdMeThnY21WMGRYSnVJRlZwYm5RMk5DZ3hNRjh3TURCZk1EQXdYekF3TUNrZ0lDQWdJQzh2SUNReE1Dd3dNREFLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNREF3TURBd01EQWdMeThnTVRBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQm5aWFJmWW05eWNtOTNYMnhwYldsMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGNtVmthWFJUWTI5eVpTNW5aWFJmWW05eWNtOTNYMnhwYldsMFFERTRDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERjbVZrYVhSVFkyOXlaUzVuWlhSZlkzSmxaR2wwWDNCeWIyWnBiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZM0psWkdsMFgzQnliMlpwYkdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJqY21Wa2FYUmZjSEp2Wm1sc1pYTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRM0psWkdsMFVISnZabWxzWlQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVl5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd5Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11WTNKbFpHbDBYM0J5YjJacGJHVnpLSFZ6WlhJcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWjJWMFgyTnlaV1JwZEY5d2NtOW1hV3hsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TXkweE9USUtJQ0FnSUM4dklISmxkSFZ5YmlCYkNpQWdJQ0F2THlBZ0lFMUpUbDlUUTA5U1JTd0tJQ0FnSUM4dklDQWdWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0JWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnVldsdWREWTBLREFwTEFvZ0lDQWdMeThnWFFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01ERXlZekF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0NtZGxkRjlqY21Wa2FYUmZjSEp2Wm1sc1pWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEzSmxaR2wwVTJOdmNtVXVaMlYwWDJOeVpXUnBkRjl3Y205bWFXeGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5amNtVmthWFJmY0hKdlptbHNaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGswQ2lBZ0lDQXZMeUJqYjI1emRDQndjbTltYVd4bElEMGdZMnh2Ym1Vb2RHaHBjeTVqY21Wa2FYUmZjSEp2Wm1sc1pYTW9kWE5sY2lrdWRtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMkNpQWdJQ0F2THlCd2NtOW1hV3hsTG5OamIzSmxMQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOd29nSUNBZ0x5OGdjSEp2Wm1sc1pTNTBiM1JoYkY5aWIzSnliM2RsWkN3S0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRGdnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU9Bb2dJQ0FnTHk4Z2NISnZabWxzWlM1MGIzUmhiRjl5WlhCaGFXUXNDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeE5pQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGs1Q2lBZ0lDQXZMeUJ3Y205bWFXeGxMbUZqZEdsMlpWOXNiMkZ1Y3l3S0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJREkwSURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EQUtJQ0FnSUM4dklIQnliMlpwYkdVdWIyNWZkR2x0WlY5eVpYQmhlVzFsYm5SekxBb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTXpJZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdNUW9nSUNBZ0x5OGdjSEp2Wm1sc1pTNXNZWFJsWDNKbGNHRjViV1Z1ZEhNc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWlhoMGNtRmpkQ0EwTUNBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXlDaUFnSUNBdkx5QndjbTltYVd4bExteGxibVJwYm1kZmNHOXZiRjlrWlhCdmMybDBjeXdLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmxlSFJ5WVdOMElEUTRJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURNS0lDQWdJQzh2SUhCeWIyWnBiR1V1YkdGemRGOTFjR1JoZEdWa1gzSnZkVzVrTEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCbGVIUnlZV04wSURVMklEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVFV0TWpBMENpQWdJQ0F2THlCeVpYUjFjbTRnV3dvZ0lDQWdMeThnSUNCd2NtOW1hV3hsTG5OamIzSmxMQW9nSUNBZ0x5OGdJQ0J3Y205bWFXeGxMblJ2ZEdGc1gySnZjbkp2ZDJWa0xBb2dJQ0FnTHk4Z0lDQndjbTltYVd4bExuUnZkR0ZzWDNKbGNHRnBaQ3dLSUNBZ0lDOHZJQ0FnY0hKdlptbHNaUzVoWTNScGRtVmZiRzloYm5Nc0NpQWdJQ0F2THlBZ0lIQnliMlpwYkdVdWIyNWZkR2x0WlY5eVpYQmhlVzFsYm5SekxBb2dJQ0FnTHk4Z0lDQndjbTltYVd4bExteGhkR1ZmY21Wd1lYbHRaVzUwY3l3S0lDQWdJQzh2SUNBZ2NISnZabWxzWlM1c1pXNWthVzVuWDNCdmIyeGZaR1Z3YjNOcGRITXNDaUFnSUNBdkx5QWdJSEJ5YjJacGJHVXViR0Z6ZEY5MWNHUmhkR1ZrWDNKdmRXNWtMQW9nSUNBZ0x5OGdYUW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56Z0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQm5aWFJmWTNKbFpHbDBYM0J5YjJacGJHVmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTnlaV1JwZEZOamIzSmxMbWRsZEY5amNtVmthWFJmY0hKdlptbHNaVUEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEY21Wa2FYUlRZMjl5WlM1elpYUmZiR1Z1WkdsdVoxOXdiMjlzWDJGd2NGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5c1pXNWthVzVuWDNCdmIyeGZZWEJ3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd053b2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRGOXNaVzVrYVc1blgzQnZiMnhmWVhCd0tHRndjRjlwWkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJR3hsYm1ScGJtZGZjRzl2YkY5aGNIQmZhV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteGxibVJwYm1kZmNHOXZiRjloY0hCZmFXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakE0Q2lBZ0lDQXZMeUIwYUdsekxteGxibVJwYm1kZmNHOXZiRjloY0hCZmFXUXVkbUZzZFdVZ1BTQmhjSEJmYVdRS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHbDBYM05qYjNKbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTNDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBYMnhsYm1ScGJtZGZjRzl2YkY5aGNIQW9ZWEJ3WDJsa09pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOeVpXUnBkRk5qYjNKbExtTnNZVzF3WDNOamIzSmxLSE5qYjNKbE9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tZMnhoYlhCZmMyTnZjbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJNUNpQWdJQ0F2THlCd2NtbDJZWFJsSUdOc1lXMXdYM05qYjNKbEtITmpiM0psT2lCMWFXNTBOalFwT2lCMWFXNTBOalFnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR2wwWDNOamIzSmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE13Q2lBZ0lDQXZMeUJwWmlBb2MyTnZjbVVnUENCTlNVNWZVME5QVWtVcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHpJQzh2SURNd01Bb2dJQ0FnUEFvZ0lDQWdZbm9nWTJ4aGJYQmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCeVpYUjFjbTRnVFVsT1gxTkRUMUpGQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNekF3Q2lBZ0lDQnlaWFJ6ZFdJS0NtTnNZVzF3WDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNek1LSUNBZ0lDOHZJR2xtSUNoelkyOXlaU0ErSUUxQldGOVRRMDlTUlNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5SaklEUWdMeThnT0RVd0NpQWdJQ0ErQ2lBZ0lDQmllaUJqYkdGdGNGOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUhKbGRIVnliaUJOUVZoZlUwTlBVa1VLSUNBZ0lHbHVkR01nTkNBdkx5QTROVEFLSUNBZ0lISmxkSE4xWWdvS1kyeGhiWEJmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUnBkRjl6WTI5eVpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpOZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmpiM0psQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrYVhSZmMyTnZjbVV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTNKbFpHbDBVMk52Y21VdVoyVjBYM05qYjNKbEtIVnpaWEk2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q25OdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEzSmxaR2wwVTJOdmNtVXVaMlYwWDNOamIzSmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T1MweE5EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ0x5OGdjSFZpYkdsaklHZGxkRjl6WTI5eVpTaDFjMlZ5T2lCQlkyTnZkVzUwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJqY21Wa2FYUmZjSEp2Wm1sc1pYTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRM0psWkdsMFVISnZabWxzWlQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVl5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmthWFJmYzJOdmNtVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREVLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVqY21Wa2FYUmZjSEp2Wm1sc1pYTW9kWE5sY2lrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdsMFgzTmpiM0psTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOeVpXUnBkRk5qYjNKbExtZGxkRjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa2FYUmZjMk52Y21VdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCTlNVNWZVME5QVWtVS0lDQWdJR2x1ZEdOZk15QXZMeUF6TURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JwZEY5elkyOXlaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEY21Wa2FYUlRZMjl5WlM1blpYUmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldScGRGOXpZMjl5WlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZM0psWkdsMFgzQnliMlpwYkdWektIVnpaWElwTG5aaGJIVmxMbk5qYjNKbENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUdBUUFnckFMU0JvQ3Q0Z1FtQXdGakJCVWZmSFVUYkdWdVpHbHVaMTl3YjI5c1gyRndjRjlwWklBRXZzZHRoellhQUk0QkFHQXhHUlJFTVJoQkFFZUNDUVJRWll5cEJGengzK3dFdUNwRmxnU1hQb3pOQkxLMUU4MEVJRnR5REFTdnBhMHdCT0xnL1VjRWxjdWVKVFlhQUk0SkFEd0Fnd0RJQVFnQm1RRzdBYzBDWHdMOEFJQUVURnhodWpZYUFJNEJBQUVBSWtNaU1SbVFnUU1hUkVJQUFJQUpiV2x1WDNOamIzSmxKV2VBQ1cxaGVGOXpZMjl5WlNFRVp5b2paeUpETWdZV2dEZ0FBQUFBQUFBQkxBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRXhRS0RFQVVFeS9Ja00yR2dGSkZTUVNSRFlhQWtrVmdRZ1NSQmNvVHdKUVNiNUVTd0loQlFwSmdjZ0JEWUhJQVV4TlN3RWpXd2lJQWxnV1hBQkpnVEJiVHdNSUZsd3dNZ1lXWERpL0lrTTJHZ0ZKRlNRU1JEWWFBa2tWZ1FnU1JCY29Ud0pRU2I1RVNTTmJnUVVKaUFJaEZsd0FTWUVJVzA4RENCWmNDRW1CR0ZzaUNCWmNHRElHRmx3NHZ5SkRnQUEyR2dGSkZTUVNSRFlhQWtrVmdRZ1NSQmRNTmhvRFNSVWlFa1FqVTBsT0FpaFBBbEJKVGdLK1RFNENSRUVBVFVjQ0pGc2lDQlpjSUVVQmdSUkZCVXNDUVFBdFNTTmJTd1VJaUFHMUZrc0JURndBU1lFUVcwc0ZDQlpjRUVtQkdGc2lDUlpjR0RJR0ZsdzRTd0pNdnlKRFNTTmJTd1VKaUFHSVF2L1FSd0tCS0ZzaUNCWmNLRVVCZ1I1RkJVTC9yellhQVVrVkpCSkVLRXhRU2I1RVNTTmJnV1FKaUFGYkZsd0FNZ1lXWERpL0lrTTJHZ0ZKRlNRU1JJZ0JYeFlwVEZDd0lrTTJHZ0ZKRlNRU1JJZ0JUVWtsREVFQUNDTVdLVXhRc0NKRFNZSGVBZ3hCQUFVaEJVTC83RW1Ca0FNTVFRQUlnY0R3OVF0Qy85eEpnY0lEREVFQUNJR0E0ZXNYUXYvTVNZSDBBd3hCQUFpQmdNTFhMMEwvdkVtQjJBUU1RUUFKZ1lES3RlNEJRdityU1lHOEJReEJBQW1CZ0tqV3VRZEMvNXBKZ2U0RkRFRUFDWUdBNUpmUUVrTC9pWUdBeUsrZ0pVTC9nRFlhQVVrVkpCSkVLRXhRU2IxRkFVQUFTSUJBQUFBQUFBQUFBU3dBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNsTVVMQWlRMG0rUkVsWEFBaExBVmNJQ0VzQ1Z4QUlTd05YR0FoTEJGY2dDRXNGVnlnSVN3WlhNQWhQQjFjNENFOEhUd2RRVHdaUVR3VlFUd1JRVHdOUVR3SlFURkJDLzdjMkdnRkpGWUVJRWtRWEtreG5Ja09LQVFHTC95VU1RUUFDSlltTC95RUVEVUVBQXlFRWlZdi9pWW9CQVNpTC8xQkp2VVVCUUFBREpVeUppd0MrUkNOYlRJaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
