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

namespace Arc56.Generated.AdityaWagh19.Credencia.LendingPool_6ac2a313
{


    //
    // 
    //    Single unified ALGO lending pool.
    //
    //    Access control:
    //        - deposit / withdraw: any KYC-verified lender
    //        - disburse: LoanManager contract only (inner app call)
    //        - return_funds: LoanManager / RepaymentEscrow (inner app call)
    //        - admin methods: admin only
    //    
    //
    public class LendingPoolProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LendingPoolProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DepositRecord : AVMObjectType
            {
                public ulong Shares { get; set; }

                public ulong DepositedAt { get; set; }

                public ulong TotalDeposited { get; set; }

                public ulong TotalWithdrawn { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vShares.From(Shares);
                    ret.AddRange(vShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDepositedAt.From(DepositedAt);
                    ret.AddRange(vDepositedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDeposited = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalDeposited.From(TotalDeposited);
                    ret.AddRange(vTotalDeposited.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalWithdrawn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalWithdrawn.From(TotalWithdrawn);
                    ret.AddRange(vTotalWithdrawn.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DepositRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DepositRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueShares = vShares.ToValue();
                    if (valueShares is ulong vSharesValue) { ret.Shares = vSharesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDepositedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDepositedAt = vDepositedAt.ToValue();
                    if (valueDepositedAt is ulong vDepositedAtValue) { ret.DepositedAt = vDepositedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDeposited = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalDeposited.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalDeposited = vTotalDeposited.ToValue();
                    if (valueTotalDeposited is ulong vTotalDepositedValue) { ret.TotalDeposited = vTotalDepositedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalWithdrawn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalWithdrawn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalWithdrawn = vTotalWithdrawn.ToValue();
                    if (valueTotalWithdrawn is ulong vTotalWithdrawnValue) { ret.TotalWithdrawn = vTotalWithdrawnValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DepositRecord);
                }
                public bool Equals(DepositRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DepositRecord left, DepositRecord right)
                {
                    return EqualityComparer<DepositRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(DepositRecord left, DepositRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the pool. Called once at deployment.
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
        ///Set the authorized LoanManager app ID. Admin-only.
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task SetLoanManager(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 252, 65, 29 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLoanManager_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 252, 65, 29 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Emergency pause/unpause. Admin-only. Halts new disbursements.
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
        ///Deposit ALGO into the pool.
        ///The lender must include a PaymentTransaction to this app address as a preceding transaction in the atomic group. Shares are minted pro-rata.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Deposit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw ALGO by burning shares.
        ///Enforces 7-day lock period from last deposit.
        ///</summary>
        /// <param name="share_amount"> </param>
        public async Task Withdraw(ulong share_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var share_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_amountAbi.From(share_amount);

            var result = await base.CallApp(new List<object> { abiHandle, share_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong share_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var share_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_amountAbi.From(share_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, share_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Disburse ALGO to a borrower. LoanManager only (inner app call).
        ///Enforces utilization cap at 90%.
        ///Uses arc4.Address (32-byte raw address) instead of ABI Account type so that inner application calls from LoanManager work correctly — the ABI Account type (uint8 index) cannot be used across inner calls because the callee cannot resolve the caller's accounts array.
        ///</summary>
        /// <param name="borrower"> </param>
        /// <param name="amount"> </param>
        public async Task Disburse(Algorand.Address borrower, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 115, 14, 226 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Disburse_Transactions(Algorand.Address borrower, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 115, 14, 226 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return repaid ALGO to the pool. Called by RepaymentEscrow
        ///as part of the repayment split.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task ReturnFunds(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 229, 167, 121 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReturnFunds_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 229, 167, 121 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Current utilization rate in basis points.
        ///</summary>
        public async Task<ulong> GetUtilizationBps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 0, 167, 154 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUtilizationBps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 0, 167, 154 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return (total_liquidity, outstanding_loans, total_shares, total_depositors).
        ///</summary>
        public async Task<Structs.DepositRecord> GetPoolStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 23, 246, 146 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DepositRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPoolStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 23, 246, 146 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get deposit record for a lender. Reverts if not found.
        ///</summary>
        /// <param name="depositor"> </param>
        public async Task<Structs.DepositRecord> GetDeposit(Algorand.Address depositor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 96, 92, 182 };
            var depositorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); depositorAbi.From(depositor);

            var result = await base.SimApp(new List<object> { abiHandle, depositorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DepositRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetDeposit_Transactions(Algorand.Address depositor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 96, 92, 182 };
            var depositorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); depositorAbi.From(depositor);

            return await base.MakeTransactionList(new List<object> { abiHandle, depositorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate the ALGO value of a given number of shares.
        ///</summary>
        /// <param name="shares"> </param>
        public async Task<ulong> GetShareValue(ulong shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 163, 220, 111 };
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);

            var result = await base.SimApp(new List<object> { abiHandle, sharesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetShareValue_Transactions(ulong shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 163, 220, 111 };
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);

            return await base.MakeTransactionList(new List<object> { abiHandle, sharesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGVuZGluZ1Bvb2wiLCJkZXNjIjoiXG4gICAgU2luZ2xlIHVuaWZpZWQgQUxHTyBsZW5kaW5nIHBvb2wuXG5cbiAgICBBY2Nlc3MgY29udHJvbDpcbiAgICAgICAgLSBkZXBvc2l0IC8gd2l0aGRyYXc6IGFueSBLWUMtdmVyaWZpZWQgbGVuZGVyXG4gICAgICAgIC0gZGlzYnVyc2U6IExvYW5NYW5hZ2VyIGNvbnRyYWN0IG9ubHkgKGlubmVyIGFwcCBjYWxsKVxuICAgICAgICAtIHJldHVybl9mdW5kczogTG9hbk1hbmFnZXIgLyBSZXBheW1lbnRFc2Nyb3cgKGlubmVyIGFwcCBjYWxsKVxuICAgICAgICAtIGFkbWluIG1ldGhvZHM6IGFkbWluIG9ubHlcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRGVwb3NpdFJlY29yZCI6W3sibmFtZSI6InNoYXJlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkZXBvc2l0ZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfZGVwb3NpdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX3dpdGhkcmF3biIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHBvb2wuIENhbGxlZCBvbmNlIGF0IGRlcGxveW1lbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yYWNsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfbG9hbl9tYW5hZ2VyIiwiZGVzYyI6IlNldCB0aGUgYXV0aG9yaXplZCBMb2FuTWFuYWdlciBhcHAgSUQuIEFkbWluLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfZXNjcm93IiwiZGVzYyI6IlNldCB0aGUgUmVwYXltZW50RXNjcm93IGFwcCBJRC4gQWRtaW4tb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9wYXVzZWQiLCJkZXNjIjoiRW1lcmdlbmN5IHBhdXNlL3VucGF1c2UuIEFkbWluLW9ubHkuIEhhbHRzIG5ldyBkaXNidXJzZW1lbnRzLiIsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF1c2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiRGVwb3NpdCBBTEdPIGludG8gdGhlIHBvb2wuXG5UaGUgbGVuZGVyIG11c3QgaW5jbHVkZSBhIFBheW1lbnRUcmFuc2FjdGlvbiB0byB0aGlzIGFwcCBhZGRyZXNzIGFzIGEgcHJlY2VkaW5nIHRyYW5zYWN0aW9uIGluIHRoZSBhdG9taWMgZ3JvdXAuIFNoYXJlcyBhcmUgbWludGVkIHByby1yYXRhLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IldpdGhkcmF3IEFMR08gYnkgYnVybmluZyBzaGFyZXMuXG5FbmZvcmNlcyA3LWRheSBsb2NrIHBlcmlvZCBmcm9tIGxhc3QgZGVwb3NpdC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRpc2J1cnNlIiwiZGVzYyI6IkRpc2J1cnNlIEFMR08gdG8gYSBib3Jyb3dlci4gTG9hbk1hbmFnZXIgb25seSAoaW5uZXIgYXBwIGNhbGwpLlxuRW5mb3JjZXMgdXRpbGl6YXRpb24gY2FwIGF0IDkwJS5cblVzZXMgYXJjNC5BZGRyZXNzICgzMi1ieXRlIHJhdyBhZGRyZXNzKSBpbnN0ZWFkIG9mIEFCSSBBY2NvdW50IHR5cGUgc28gdGhhdCBpbm5lciBhcHBsaWNhdGlvbiBjYWxscyBmcm9tIExvYW5NYW5hZ2VyIHdvcmsgY29ycmVjdGx5IOKAlCB0aGUgQUJJIEFjY291bnQgdHlwZSAodWludDggaW5kZXgpIGNhbm5vdCBiZSB1c2VkIGFjcm9zcyBpbm5lciBjYWxscyBiZWNhdXNlIHRoZSBjYWxsZWUgY2Fubm90IHJlc29sdmUgdGhlIGNhbGxlcidzIGFjY291bnRzIGFycmF5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9ycm93ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXR1cm5fZnVuZHMiLCJkZXNjIjoiUmV0dXJuIHJlcGFpZCBBTEdPIHRvIHRoZSBwb29sLiBDYWxsZWQgYnkgUmVwYXltZW50RXNjcm93XG5hcyBwYXJ0IG9mIHRoZSByZXBheW1lbnQgc3BsaXQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXRpbGl6YXRpb25fYnBzIiwiZGVzYyI6IkN1cnJlbnQgdXRpbGl6YXRpb24gcmF0ZSBpbiBiYXNpcyBwb2ludHMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcG9vbF9zdGF0cyIsImRlc2MiOiJSZXR1cm4gKHRvdGFsX2xpcXVpZGl0eSwgb3V0c3RhbmRpbmdfbG9hbnMsIHRvdGFsX3NoYXJlcywgdG90YWxfZGVwb3NpdG9ycykuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRGVwb3NpdFJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2RlcG9zaXQiLCJkZXNjIjoiR2V0IGRlcG9zaXQgcmVjb3JkIGZvciBhIGxlbmRlci4gUmV2ZXJ0cyBpZiBub3QgZm91bmQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXBvc2l0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJEZXBvc2l0UmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc2hhcmVfdmFsdWUiLCJkZXNjIjoiQ2FsY3VsYXRlIHRoZSBBTEdPIHZhbHVlIG9mIGEgZ2l2ZW4gbnVtYmVyIG9mIHNoYXJlcy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6OCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM4OV0sImVycm9yTWVzc2FnZSI6ImJlbG93IG1pbmltdW0gZGVwb3NpdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OCwzMjIsMzQ1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRlcG9zaXRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZXNjcm93X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4Miw3NzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxvYW5fbWFuYWdlcl9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzQsNjg4LDc4Miw3OTcsODMwLDg1Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3V0c3RhbmRpbmdfbG9hbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcxLDUyOCw2NzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODksODYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9kZXBvc2l0b3JzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNyw1MDksNTcwLDYzMiw3MDEsODE0LDgzOCw4NDcsOTM2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9saXF1aWRpdHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9sb2Fuc19kaXNidXJzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkzLDQxNyw1MDIsNTg3LDg1Nyw5MjAsOTQzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9zaGFyZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY2XSwiZXJyb3JNZXNzYWdlIjoiZGVwb3NpdCBzdGlsbCBsb2NrZWQgKDctZGF5IG1pbmltdW0pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAzXSwiZXJyb3JNZXNzYWdlIjoiZGVwb3NpdCB0b28gc21hbGwgZm9yIHNoYXJlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxN10sImVycm9yTWVzc2FnZSI6Imluc3VmZmljaWVudCBwb29sIGZ1bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk2XSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IHBvb2wgbGlxdWlkaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUzXSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IHNoYXJlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjksMjM3LDY2MCw4ODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkwLDMxNCw1MjMsNjY4LDc1Myw5MTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDIsODk4XSwiZXJyb3JNZXNzYWdlIjoibm8gZGVwb3NpdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4NF0sImVycm9yTWVzc2FnZSI6Im9ubHkgTG9hbk1hbmFnZXIgY2FuIGRpc2J1cnNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAwLDMyNCwzNDddLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgwXSwiZXJyb3JNZXNzYWdlIjoicGF5IHRvIHBvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzMsNTMwLDY3NV0sImVycm9yTWVzc2FnZSI6InBvb2wgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzhdLCJlcnJvck1lc3NhZ2UiOiJ1bmF1dGhvcml6ZWQgY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzEwXSwiZXJyb3JNZXNzYWdlIjoidXRpbGl6YXRpb24gY2FwIHJlYWNoZWQgKDkwJSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlkRzkwWVd4ZmJHbHhJaUFpYjNWMFgyeHZZVzV6SWlBaWRHOTBZV3hmYzJoaGNtVnpJaUFpY0dGMWMyVmtJaUFpWVdSdGFXNGlJQ0pzYjJGdVgyMW5jaUlnSW1SbGNHOXphWFJ2Y25NaUlEQjRNVFV4Wmpkak56VWdJbVZ6WTNKdmQxOXBaQ0lnSW14dllXNXpYMjkxZENJZ01IZzJORFkxTnpBMVppQXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUbzFOZ29nSUNBZ0x5OGdZMnhoYzNNZ1RHVnVaR2x1WjFCdmIyd29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVGNLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0T1daak5ERXhaQ0F3ZURGaE56WXdNMll4SURCNFpXTXdPRFV3Wm1RZ01IZ3pOakkxWlRSbFlpQXdlREl4WmpGa1pHWm1JREI0TmpFM016QmxaVElnTUhnMU4yVTFZVGMzT1NBd2VEaGtNREJoTnpsaElEQjRZbU14TjJZMk9USWdNSGcxWWpZd05XTmlOaUF3ZURjNVlUTmtZelptSUM4dklHMWxkR2h2WkNBaWMyVjBYMnh2WVc1ZmJXRnVZV2RsY2loMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJWelkzSnZkeWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYM0JoZFhObFpDaGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsY0c5emFYUW9jR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa2FYTmlkWEp6WlNoaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWFIxY201ZlpuVnVaSE1vZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjkxZEdsc2FYcGhkR2x2Ymw5aWNITW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNCdmIyeGZjM1JoZEhNb0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZlpHVndiM05wZENoaFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmYzJoaGNtVmZkbUZzZFdVb2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhObGRGOXNiMkZ1WDIxaGJtRm5aWElnYzJWMFgyVnpZM0p2ZHlCelpYUmZjR0YxYzJWa0lHUmxjRzl6YVhRZ2QybDBhR1J5WVhjZ1pHbHpZblZ5YzJVZ2NtVjBkWEp1WDJaMWJtUnpJR2RsZEY5MWRHbHNhWHBoZEdsdmJsOWljSE1nWjJWMFgzQnZiMnhmYzNSaGRITWdaMlYwWDJSbGNHOXphWFFnWjJWMFgzTm9ZWEpsWDNaaGJIVmxDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVGM2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TlRZS0lDQWdJQzh2SUdOc1lYTnpJRXhsYm1ScGJtZFFiMjlzS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRZVGsyT1Rnd1pTQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaGhaR1J5WlhOekxHRmtaSEpsYzNNcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ29LTHk4Z1kyRmtaVzVqYVdFdVRHVnVaR2x1WjFCdmIyd3ViR1Z1WkdsdVoxOXdiMjlzTGt4bGJtUnBibWRRYjI5c0xtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRvNU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPamt6Q2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1TG5aaGJIVmxJRDBnWVdSdGFXNEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPamswQ2lBZ0lDQXZMeUJ6Wld4bUxtOXlZV05zWlM1MllXeDFaU0E5SUc5eVlXTnNaUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnZjbUZqYkdVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qazFDaUFnSUNBdkx5QnpaV3htTG14dllXNWZiV0Z1WVdkbGNsOXBaQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWliRzloYmw5dFozSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUbzVOZ29nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2RmYVdRdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1WelkzSnZkMTlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2prM0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyeHBjWFZwWkdsMGVTNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmYkdseElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk9UZ0tJQ0FnSUM4dklITmxiR1l1YjNWMGMzUmhibVJwYm1kZmJHOWhibk11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkxZEY5c2IyRnVjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPams1Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOb1lYSmxjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZmMyaGhjbVZ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TVRBd0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhSdmNuTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltUmxjRzl6YVhSdmNuTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hNREVLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYkc5aGJuTmZaR2x6WW5WeWMyVmtMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnNiMkZ1YzE5dmRYUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hNRElLSUNBZ0lDOHZJSE5sYkdZdWNHRjFjMlZrTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3WVhWelpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUbzVNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTJGa1pXNWphV0V1VEdWdVpHbHVaMUJ2YjJ3dWJHVnVaR2x1WjE5d2IyOXNMa3hsYm1ScGJtZFFiMjlzTG5ObGRGOXNiMkZ1WDIxaGJtRm5aWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZiRzloYmw5dFlXNWhaMlZ5T2dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFd05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1UQTNDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpYjI1c2VTQmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JoWkcxcGJnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qRXdPQW9nSUNBZ0x5OGdjMlZzWmk1c2IyRnVYMjFoYm1GblpYSmZhV1F1ZG1Gc2RXVWdQU0JoY0hCZmFXUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lteHZZVzVmYldkeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hNRFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOaFpHVnVZMmxoTGt4bGJtUnBibWRRYjI5c0xteGxibVJwYm1kZmNHOXZiQzVNWlc1a2FXNW5VRzl2YkM1elpYUmZaWE5qY205M1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDJWelkzSnZkem9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG94TVRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFeE13b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJbTl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveE1UUUtJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNYMmxrTG5aaGJIVmxJRDBnWVhCd1gybGtDaUFnSUNCaWVYUmxZeUE0SUM4dklDSmxjMk55YjNkZmFXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakV4TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyRmtaVzVqYVdFdVRHVnVaR2x1WjFCdmIyd3ViR1Z1WkdsdVoxOXdiMjlzTGt4bGJtUnBibWRRYjI5c0xuTmxkRjl3WVhWelpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmNHRjFjMlZrT2dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFeE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFeE9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJbTl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveE1qQUtJQ0FnSUM4dklITmxiR1l1Y0dGMWMyVmtMblpoYkhWbElEMGdWVWx1ZERZMEtERXBJR2xtSUhCaGRYTmxaQzV1WVhScGRtVWdaV3h6WlNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TVRFMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpZV1JsYm1OcFlTNU1aVzVrYVc1blVHOXZiQzVzWlc1a2FXNW5YM0J2YjJ3dVRHVnVaR2x1WjFCdmIyd3VaR1Z3YjNOcGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsY0c5emFYUTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hNaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1UTXhDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV3WVhWelpXUXVkbUZzZFdVZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpY0c5dmJDQnBjeUJ3WVhWelpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCd2IyOXNJR2x6SUhCaGRYTmxaQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakV6TWdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSW5CaGVTQjBieUJ3YjI5c0lnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY0dGNUlIUnZJSEJ2YjJ3S0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveE16TUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCTlNVNWZSRVZRVDFOSlZDd2dJbUpsYkc5M0lHMXBibWx0ZFcwZ1pHVndiM05wZENJS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZbVZzYjNjZ2JXbHVhVzExYlNCa1pYQnZjMmwwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TVRNM0xURXpPQW9nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnYzJoaGNtVnpJSFJ2SUcxcGJuUUtJQ0FnSUM4dklHbG1JSE5sYkdZdWRHOTBZV3hmYzJoaGNtVnpMblpoYkhWbElEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5emFHRnlaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzJoaGNtVnpJR1Y0YVhOMGN3b2dJQ0FnWW01NklHUmxjRzl6YVhSZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpDZ3BrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hORFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnVaWGRmYzJoaGNtVnpJRDRnVlVsdWREWTBLREFwTENBaVpHVndiM05wZENCMGIyOGdjMjFoYkd3Z1ptOXlJSE5vWVhKbGN5SUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCa1pYQnZjMmwwSUhSdmJ5QnpiV0ZzYkNCbWIzSWdjMmhoY21WekNpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1UUTNMVEUwT0FvZ0lDQWdMeThnSXlCVmNHUmhkR1VnY0c5dmJDQjBiM1JoYkhNS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmJHbHhkV2xrYVhSNUxuWmhiSFZsSUNzOUlHUmxjRzl6YVhSZllXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZmJHbHhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMnhwY1hWcFpHbDBlU0JsZUdsemRITUtJQ0FnSUdScFp5QXlDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjlzYVhFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qRTBPUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6YUdGeVpYTXVkbUZzZFdVZ0t6MGdibVYzWDNOb1lYSmxjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNOb1lYSmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6YUdGeVpYTWdaWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXphR0Z5WlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qRTFNUzB4TlRJS0lDQWdJQzh2SUNNZ1ZYQmtZWFJsSUc5eUlHTnlaV0YwWlNCc1pXNWtaWElnY21WamIzSmtDaUFnSUNBdkx5QmtaWEJ2YzJsMGIzSWdQU0J3WVhsdFpXNTBMbk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qRTFNd29nSUNBZ0x5OGdhV1lnWkdWd2IzTnBkRzl5SUdsdUlITmxiR1l1WkdWd2IzTnBkSE02Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURZME5qVTNNRFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmtaWEJ2YzJsMFgyVnNjMlZmWW05a2VVQTJDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNVFUwQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtUmxjRzl6YVhSelcyUmxjRzl6YVhSdmNsMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxjRzl6YVhSeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakUxTlFvZ0lDQWdMeThnY21WamIzSmtMbk5vWVhKbGN5QTlJR0Z5WXpRdVZVbHVkRFkwS0hKbFkyOXlaQzV6YUdGeVpYTXVibUYwYVhabElDc2dibVYzWDNOb1lYSmxjeWtLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dOUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFMU5nb2dJQ0FnTHk4Z2NtVmpiM0prTG1SbGNHOXphWFJsWkY5aGRDQTlJR0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa2dJQ01nVW1WelpYUWdiRzlqYXlCMGFXMWxjZ29nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBNENpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1UVTRDaUFnSUNBdkx5QnlaV052Y21RdWRHOTBZV3hmWkdWd2IzTnBkR1ZrTG01aGRHbDJaU0FySUdSbGNHOXphWFJmWVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ013b2dJQ0FnS3dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFMU55MHhOVGtLSUNBZ0lDOHZJSEpsWTI5eVpDNTBiM1JoYkY5a1pYQnZjMmwwWldRZ1BTQmhjbU0wTGxWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTnZjbVF1ZEc5MFlXeGZaR1Z3YjNOcGRHVmtMbTVoZEdsMlpTQXJJR1JsY0c5emFYUmZZVzF2ZFc1MENpQWdJQ0F2THlBcENpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF4TmdvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFMk1Bb2dJQ0FnTHk4Z2MyVnNaaTVrWlhCdmMybDBjMXRrWlhCdmMybDBiM0pkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ1ltOTRYM0IxZEFvS1pHVndiM05wZEY5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TVRJeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21SbGNHOXphWFJmWld4elpWOWliMlI1UURZNkNpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1UWXpDaUFnSUNBdkx5QnphR0Z5WlhNOVlYSmpOQzVWU1c1ME5qUW9ibVYzWDNOb1lYSmxjeWtzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFMk5Bb2dJQ0FnTHk4Z1pHVndiM05wZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hOalVLSUNBZ0lDOHZJSFJ2ZEdGc1gyUmxjRzl6YVhSbFpEMWhjbU0wTGxWSmJuUTJOQ2hrWlhCdmMybDBYMkZ0YjNWdWRDa3NDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakUyTWkweE5qY0tJQ0FnSUM4dklISmxZMjl5WkNBOUlFUmxjRzl6YVhSU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhjbVZ6UFdGeVl6UXVWVWx1ZERZMEtHNWxkMTl6YUdGeVpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbGNHOXphWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gyUmxjRzl6YVhSbFpEMWhjbU0wTGxWSmJuUTJOQ2hrWlhCdmMybDBYMkZ0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkMmwwYUdSeVlYZHVQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveE5qWUtJQ0FnSUM4dklIUnZkR0ZzWDNkcGRHaGtjbUYzYmoxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakUyTWkweE5qY0tJQ0FnSUM4dklISmxZMjl5WkNBOUlFUmxjRzl6YVhSU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhjbVZ6UFdGeVl6UXVWVWx1ZERZMEtHNWxkMTl6YUdGeVpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbGNHOXphWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gyUmxjRzl6YVhSbFpEMWhjbU0wTGxWSmJuUTJOQ2hrWlhCdmMybDBYMkZ0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkMmwwYUdSeVlYZHVQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNVFk0Q2lBZ0lDQXZMeUJ6Wld4bUxtUmxjRzl6YVhSelcyUmxjRzl6YVhSdmNsMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNVFk1Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJSbGNHOXphWFJ2Y25NdWRtRnNkV1VnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWkdWd2IzTnBkRzl5Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwYjNKeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltUmxjRzl6YVhSdmNuTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lpQmtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvS1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hOREl0TVRRekNpQWdJQ0F2THlBaklGQnlieTF5WVhSaE9pQnVaWGRmYzJoaGNtVnpJRDBnWkdWd2IzTnBkQ0FxSUhSdmRHRnNYM05vWVhKbGN5QXZJSFJ2ZEdGc1gyeHBjWFZwWkdsMGVRb2dJQ0FnTHk4Z2JtVjNYM05vWVhKbGN5QTlJQ2hrWlhCdmMybDBYMkZ0YjNWdWRDQXFJSE5sYkdZdWRHOTBZV3hmYzJoaGNtVnpMblpoYkhWbEtTQXZMeUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNOb1lYSmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6YUdGeVpYTWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyeHBjU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlzYVhGMWFXUnBkSGtnWlhocGMzUnpDaUFnSUNBdkNpQWdJQ0JpZFhKNUlETUtJQ0FnSUdJZ1pHVndiM05wZEY5aFpuUmxjbDlwWmw5bGJITmxRRFFLQ2dvdkx5QmpZV1JsYm1OcFlTNU1aVzVrYVc1blVHOXZiQzVzWlc1a2FXNW5YM0J2YjJ3dVRHVnVaR2x1WjFCdmIyd3VkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG94TnpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFM053b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVjR0YxYzJWa0xuWmhiSFZsSUQwOUlGVkpiblEyTkNnd0tTd2dJbkJ2YjJ3Z2FYTWdjR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d1lYVnpaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnY0c5dmJDQnBjeUJ3WVhWelpXUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3hOemdLSUNBZ0lDOHZJR1JsY0c5emFYUnZjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG94TnprS0lDQWdJQzh2SUdGemMyVnlkQ0JrWlhCdmMybDBiM0lnYVc0Z2MyVnNaaTVrWlhCdmMybDBjeXdnSW01dklHUmxjRzl6YVhRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURZME5qVTNNRFZtQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJR1JsY0c5emFYUWdabTkxYm1RS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveE9ERUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WkdWd2IzTnBkSE5iWkdWd2IzTnBkRzl5WFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TVRneUNpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk5vWVhKbGN5NXVZWFJwZG1VZ1BqMGdjMmhoY21WZllXMXZkVzUwTENBaWFXNXpkV1ptYVdOcFpXNTBJSE5vWVhKbGN5SUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1YzNWbVptbGphV1Z1ZENCemFHRnlaWE1LSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG94T0RZS0lDQWdJQzh2SUVkc2IySmhiQzV5YjNWdVpDQStQU0J5WldOdmNtUXVaR1Z3YjNOcGRHVmtYMkYwTG01aGRHbDJaU0FySUUxSlRsOU1UME5MWDFKUFZVNUVVd29nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURNM09EQXdDaUFnSUNBckNpQWdJQ0ErUFFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFNE5DMHhPRGNLSUNBZ0lDOHZJQ01nUlc1bWIzSmpaU0JzYjJOcklIQmxjbWx2WkFvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCSGJHOWlZV3d1Y205MWJtUWdQajBnY21WamIzSmtMbVJsY0c5emFYUmxaRjloZEM1dVlYUnBkbVVnS3lCTlNVNWZURTlEUzE5U1QxVk9SRk1LSUNBZ0lDOHZJQ2tzSUNKa1pYQnZjMmwwSUhOMGFXeHNJR3h2WTJ0bFpDQW9OeTFrWVhrZ2JXbHVhVzExYlNraUNpQWdJQ0JoYzNObGNuUWdMeThnWkdWd2IzTnBkQ0J6ZEdsc2JDQnNiMk5yWldRZ0tEY3RaR0Y1SUcxcGJtbHRkVzBwQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TVRnNUxURTVNQW9nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnUVV4SFR5QjBieUJ5WlhSMWNtNDZJR0ZzWjI4Z1BTQnphR0Z5WlhNZ0tpQjBiM1JoYkY5c2FYRjFhV1JwZEhrZ0x5QjBiM1JoYkY5emFHRnlaWE1LSUNBZ0lDOHZJR0YyWVdsc1lXSnNaVjlzYVhGMWFXUnBkSGtnUFNCelpXeG1MblJ2ZEdGc1gyeHBjWFZwWkdsMGVTNTJZV3gxWlNBdElITmxiR1l1YjNWMGMzUmhibVJwYm1kZmJHOWhibk11ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjlzYVhFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmJHbHhkV2xrYVhSNUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkxZEY5c2IyRnVjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmRYUnpkR0Z1WkdsdVoxOXNiMkZ1Y3lCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNVGt4Q2lBZ0lDQXZMeUJoYkdkdlgyRnRiM1Z1ZENBOUlDaHphR0Z5WlY5aGJXOTFiblFnS2lCelpXeG1MblJ2ZEdGc1gyeHBjWFZwWkdsMGVTNTJZV3gxWlNrZ0x5OGdjMlZzWmk1MGIzUmhiRjl6YUdGeVpYTXVkbUZzZFdVS0lDQWdJR1JwWnlBMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl6YUdGeVpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjMmhoY21WeklHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJQzhLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG94T1RJS0lDQWdJQzh2SUdGemMyVnlkQ0JoYkdkdlgyRnRiM1Z1ZENBOFBTQmhkbUZwYkdGaWJHVmZiR2x4ZFdsa2FYUjVMQ0FpYVc1emRXWm1hV05wWlc1MElIQnZiMndnYkdseGRXbGthWFI1SWdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1emRXWm1hV05wWlc1MElIQnZiMndnYkdseGRXbGthWFI1Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TVRrMExURTVOUW9nSUNBZ0x5OGdJeUJDZFhKdUlITm9ZWEpsY3dvZ0lDQWdMeThnY21WamIzSmtMbk5vWVhKbGN5QTlJR0Z5WXpRdVZVbHVkRFkwS0hKbFkyOXlaQzV6YUdGeVpYTXVibUYwYVhabElDMGdjMmhoY21WZllXMXZkVzUwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dOZ29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNVGszQ2lBZ0lDQXZMeUJ5WldOdmNtUXVkRzkwWVd4ZmQybDBhR1J5WVhkdUxtNWhkR2wyWlNBcklHRnNaMjlmWVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnS3dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pFNU5pMHhPVGdLSUNBZ0lDOHZJSEpsWTI5eVpDNTBiM1JoYkY5M2FYUm9aSEpoZDI0Z1BTQmhjbU0wTGxWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTnZjbVF1ZEc5MFlXeGZkMmwwYUdSeVlYZHVMbTVoZEdsMlpTQXJJR0ZzWjI5ZllXMXZkVzUwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXlOQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakU1T1FvZ0lDQWdMeThnYzJWc1ppNWtaWEJ2YzJsMGMxdGtaWEJ2YzJsMGIzSmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1qQXhDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM05vWVhKbGN5NTJZV3gxWlNBdFBTQnphR0Z5WlY5aGJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZjMmhoY21Weklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lNRElLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYkdseGRXbGthWFI1TG5aaGJIVmxJQzA5SUdGc1oyOWZZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZiR2x4SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5c2FYRWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakl3TkMweU1Ea0tJQ0FnSUM4dklDTWdVMlZ1WkNCQlRFZFBJR0poWTJzZ2RHOGdiR1Z1WkdWeUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5WkdWd2IzTnBkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJHZHZYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1qQTBMVEl3TlFvZ0lDQWdMeThnSXlCVFpXNWtJRUZNUjA4Z1ltRmpheUIwYnlCc1pXNWtaWElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG95TURnS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNakEwTFRJd09Rb2dJQ0FnTHk4Z0l5QlRaVzVrSUVGTVIwOGdZbUZqYXlCMGJ5QnNaVzVrWlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFrWlhCdmMybDBiM0lzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGc1oyOWZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveE56RUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR05oWkdWdVkybGhMa3hsYm1ScGJtZFFiMjlzTG14bGJtUnBibWRmY0c5dmJDNU1aVzVrYVc1blVHOXZiQzVrYVhOaWRYSnpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21ScGMySjFjbk5sT2dvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pJeE1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveU1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbkJoZFhObFpDNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0p3YjI5c0lHbHpJSEJoZFhObFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd1lYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUhCdmIyd2dhWE1nY0dGMWMyVmtDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNakkwQ2lBZ0lDQXZMeUJIYkc5aVlXd3VZMkZzYkdWeVgyRndjR3hwWTJGMGFXOXVYMmxrSUQwOUlITmxiR1l1Ykc5aGJsOXRZVzVoWjJWeVgybGtMblpoYkhWbENpQWdJQ0JuYkc5aVlXd2dRMkZzYkdWeVFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lteHZZVzVmYldkeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXh2WVc1ZmJXRnVZV2RsY2w5cFpDQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TWpJekxUSXlOUW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0JIYkc5aVlXd3VZMkZzYkdWeVgyRndjR3hwWTJGMGFXOXVYMmxrSUQwOUlITmxiR1l1Ykc5aGJsOXRZVzVoWjJWeVgybGtMblpoYkhWbENpQWdJQ0F2THlBcExDQWliMjVzZVNCTWIyRnVUV0Z1WVdkbGNpQmpZVzRnWkdselluVnljMlVpQ2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCTWIyRnVUV0Z1WVdkbGNpQmpZVzRnWkdselluVnljMlVLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG95TWpjdE1qSTRDaUFnSUNBdkx5QWpJRU5vWldOcklIVjBhV3hwZW1GMGFXOXVJR05oY0FvZ0lDQWdMeThnYm1WM1gyOTFkSE4wWVc1a2FXNW5JRDBnYzJWc1ppNXZkWFJ6ZEdGdVpHbHVaMTlzYjJGdWN5NTJZV3gxWlNBcklHRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkxZEY5c2IyRnVjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmRYUnpkR0Z1WkdsdVoxOXNiMkZ1Y3lCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lDc0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lNamtLSUNBZ0lDOHZJSFYwYVd4cGVtRjBhVzl1SUQwZ0tHNWxkMTl2ZFhSemRHRnVaR2x1WnlBcUlFSlFVMTlFUlU1UFRVbE9RVlJQVWlrZ0x5OGdjMlZzWmk1MGIzUmhiRjlzYVhGMWFXUnBkSGt1ZG1Gc2RXVUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyeHBjU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlzYVhGMWFXUnBkSGtnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0x3b2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSXpNQW9nSUNBZ0x5OGdZWE56WlhKMElIVjBhV3hwZW1GMGFXOXVJRHdnVlZSSlRFbGFRVlJKVDA1ZlEwRlFYMEpRVXl3Z0luVjBhV3hwZW1GMGFXOXVJR05oY0NCeVpXRmphR1ZrSUNnNU1DVXBJZ29nSUNBZ2NIVnphR2x1ZENBNU1EQXdDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnZFhScGJHbDZZWFJwYjI0Z1kyRndJSEpsWVdOb1pXUWdLRGt3SlNrS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveU16SXRNak16Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJR0YyWVdsc1lXSnNaU0JpWVd4aGJtTmxDaUFnSUNBdkx5QmhkbUZwYkdGaWJHVWdQU0J6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVM1MllXeDFaU0F0SUhObGJHWXViM1YwYzNSaGJtUnBibWRmYkc5aGJuTXVkbUZzZFdVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSXpOQW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBOFBTQmhkbUZwYkdGaWJHVXNJQ0pwYm5OMVptWnBZMmxsYm5RZ2NHOXZiQ0JtZFc1a2N5SUtJQ0FnSUdScFp5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWMzVm1abWxqYVdWdWRDQndiMjlzSUdaMWJtUnpDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNak0yQ2lBZ0lDQXZMeUJ6Wld4bUxtOTFkSE4wWVc1a2FXNW5YMnh2WVc1ekxuWmhiSFZsSUQwZ2JtVjNYMjkxZEhOMFlXNWthVzVuQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2ZFhSZmJHOWhibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pJek53b2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXNiMkZ1YzE5a2FYTmlkWEp6WldRdWRtRnNkV1VnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYkc5aGJuTmZiM1YwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJ4dllXNXpYMlJwYzJKMWNuTmxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0pzYjJGdWMxOXZkWFFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pJek9TMHlORFFLSUNBZ0lDOHZJQ01nVTJWdVpDQkJURWRQSUhSdklHSnZjbkp2ZDJWeUlPS0FsQ0JqYjI1MlpYSjBJR0Z5WXpRdVFXUmtjbVZ6Y3lCMGJ5QnVZWFJwZG1VZ1FXTmpiM1Z1ZEFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQV0p2Y25KdmQyVnlMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveU16a3RNalF3Q2lBZ0lDQXZMeUFqSUZObGJtUWdRVXhIVHlCMGJ5QmliM0p5YjNkbGNpRGlnSlFnWTI5dWRtVnlkQ0JoY21NMExrRmtaSEpsYzNNZ2RHOGdibUYwYVhabElFRmpZMjkxYm5RS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveU5ETUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TWpNNUxUSTBOQW9nSUNBZ0x5OGdJeUJUWlc1a0lFRk1SMDhnZEc4Z1ltOXljbTkzWlhJZzRvQ1VJR052Ym5abGNuUWdZWEpqTkM1QlpHUnlaWE56SUhSdklHNWhkR2wyWlNCQlkyTnZkVzUwQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlZbTl5Y205M1pYSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pJeE1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMkZrWlc1amFXRXVUR1Z1WkdsdVoxQnZiMnd1YkdWdVpHbHVaMTl3YjI5c0xreGxibVJwYm1kUWIyOXNMbkpsZEhWeWJsOW1kVzVrYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxkSFZ5Ymw5bWRXNWtjem9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG95TkRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTJGa1pXNWphV0V2VEdWdVpHbHVaMUJ2YjJ3dmJHVnVaR2x1WjE5d2IyOXNMbkI1T2pJMU13b2dJQ0FnTHk4Z1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxtVnpZM0p2ZDE5cFpDNTJZV3gxWlFvZ0lDQWdaMnh2WW1Gc0lFTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKbGMyTnliM2RmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaWE5qY205M1gybGtJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveU5UTXRNalUwQ2lBZ0lDQXZMeUJIYkc5aVlXd3VZMkZzYkdWeVgyRndjR3hwWTJGMGFXOXVYMmxrSUQwOUlITmxiR1l1WlhOamNtOTNYMmxrTG5aaGJIVmxDaUFnSUNBdkx5QnZjaUJIYkc5aVlXd3VZMkZzYkdWeVgyRndjR3hwWTJGMGFXOXVYMmxrSUQwOUlITmxiR1l1Ykc5aGJsOXRZVzVoWjJWeVgybGtMblpoYkhWbENpQWdJQ0JpYm5vZ2NtVjBkWEp1WDJaMWJtUnpYMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TWpVMENpQWdJQ0F2THlCdmNpQkhiRzlpWVd3dVkyRnNiR1Z5WDJGd2NHeHBZMkYwYVc5dVgybGtJRDA5SUhObGJHWXViRzloYmw5dFlXNWhaMlZ5WDJsa0xuWmhiSFZsQ2lBZ0lDQm5iRzlpWVd3Z1EyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW14dllXNWZiV2R5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHZZVzVmYldGdVlXZGxjbDlwWkNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNalV6TFRJMU5Bb2dJQ0FnTHk4Z1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxtVnpZM0p2ZDE5cFpDNTJZV3gxWlFvZ0lDQWdMeThnYjNJZ1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxteHZZVzVmYldGdVlXZGxjbDlwWkM1MllXeDFaUW9nSUNBZ1lub2djbVYwZFhKdVgyWjFibVJ6WDJKdmIyeGZabUZzYzJWQU5Bb0tjbVYwZFhKdVgyWjFibVJ6WDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuSmxkSFZ5Ymw5bWRXNWtjMTlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1qVXlMVEkxTlFvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCSGJHOWlZV3d1WTJGc2JHVnlYMkZ3Y0d4cFkyRjBhVzl1WDJsa0lEMDlJSE5sYkdZdVpYTmpjbTkzWDJsa0xuWmhiSFZsQ2lBZ0lDQXZMeUFnSUNBZ2IzSWdSMnh2WW1Gc0xtTmhiR3hsY2w5aGNIQnNhV05oZEdsdmJsOXBaQ0E5UFNCelpXeG1MbXh2WVc1ZmJXRnVZV2RsY2w5cFpDNTJZV3gxWlFvZ0lDQWdMeThnS1N3Z0luVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSWlDaUFnSUNCaGMzTmxjblFnTHk4Z2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSTFOeTB5TlRnS0lDQWdJQzh2SUNNZ1VtVmtkV05sSUc5MWRITjBZVzVrYVc1bklHeHZZVzV6Q2lBZ0lDQXZMeUJwWmlCaGJXOTFiblFnUGlCelpXeG1MbTkxZEhOMFlXNWthVzVuWDJ4dllXNXpMblpoYkhWbE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW05MWRGOXNiMkZ1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkWFJ6ZEdGdVpHbHVaMTlzYjJGdWN5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E4Q2lBZ0lDQmllaUJ5WlhSMWNtNWZablZ1WkhOZlpXeHpaVjlpYjJSNVFEY0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lOVGtLSUNBZ0lDOHZJSE5sYkdZdWIzVjBjM1JoYm1ScGJtZGZiRzloYm5NdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW05MWRGOXNiMkZ1Y3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2NtVjBkWEp1WDJaMWJtUnpYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lORFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVYwZFhKdVgyWjFibVJ6WDJWc2MyVmZZbTlrZVVBM09nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSTJNUW9nSUNBZ0x5OGdjMlZzWmk1dmRYUnpkR0Z1WkdsdVoxOXNiMkZ1Y3k1MllXeDFaU0F0UFNCaGJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZkWFJmYkc5aGJuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNWMGMzUmhibVJwYm1kZmJHOWhibk1nWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzVjBYMnh2WVc1eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdJZ2NtVjBkWEp1WDJaMWJtUnpYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb0tjbVYwZFhKdVgyWjFibVJ6WDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhKbGRIVnlibDltZFc1a2MxOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QmpZV1JsYm1OcFlTNU1aVzVrYVc1blVHOXZiQzVzWlc1a2FXNW5YM0J2YjJ3dVRHVnVaR2x1WjFCdmIyd3VaMlYwWDNWMGFXeHBlbUYwYVc5dVgySndjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTFkR2xzYVhwaGRHbHZibDlpY0hNNkNpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1qWTRDaUFnSUNBdkx5QnBaaUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVM1MllXeDFaU0E5UFNCVlNXNTBOalFvTUNrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZiR2x4SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVNCbGVHbHpkSE1LSUNBZ0lHSnVlaUJuWlhSZmRYUnBiR2w2WVhScGIyNWZZbkJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakkyT1FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0NtZGxkRjkxZEdsc2FYcGhkR2x2Ymw5aWNITmZZV1owWlhKZmFXNXNhVzVsWkY5allXUmxibU5wWVM1TVpXNWthVzVuVUc5dmJDNXNaVzVrYVc1blgzQnZiMnd1VEdWdVpHbHVaMUJ2YjJ3dVoyVjBYM1YwYVd4cGVtRjBhVzl1WDJKd2MwQTBPZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakkyTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmZFhScGJHbDZZWFJwYjI1ZlluQnpYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lOekFLSUNBZ0lDOHZJSFYwYVd3Z1BTQW9jMlZzWmk1dmRYUnpkR0Z1WkdsdVoxOXNiMkZ1Y3k1MllXeDFaU0FxSUVKUVUxOUVSVTVQVFVsT1FWUlBVaWtnTHk4Z2MyVnNaaTUwYjNSaGJGOXNhWEYxYVdScGRIa3VkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2ZFhSZmJHOWhibk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzVjBjM1JoYm1ScGJtZGZiRzloYm5NZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElERXdNREF3Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmYkdseElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyeHBjWFZwWkdsMGVTQmxlR2x6ZEhNS0lDQWdJQzhLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG95TnpFS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoMWRHbHNLUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakkyTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOTFkR2xzYVhwaGRHbHZibDlpY0hOZllXWjBaWEpmYVc1c2FXNWxaRjlqWVdSbGJtTnBZUzVNWlc1a2FXNW5VRzl2YkM1c1pXNWthVzVuWDNCdmIyd3VUR1Z1WkdsdVoxQnZiMnd1WjJWMFgzVjBhV3hwZW1GMGFXOXVYMkp3YzBBMENnb0tMeThnWTJGa1pXNWphV0V1VEdWdVpHbHVaMUJ2YjJ3dWJHVnVaR2x1WjE5d2IyOXNMa3hsYm1ScGJtZFFiMjlzTG1kbGRGOXdiMjlzWDNOMFlYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzQnZiMnhmYzNSaGRITTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNamM0Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gyeHBjWFZwWkdsMGVTNTJZV3gxWlNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZiR2x4SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR05oWkdWdVkybGhMMHhsYm1ScGJtZFFiMjlzTDJ4bGJtUnBibWRmY0c5dmJDNXdlVG95TnprS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1YjNWMGMzUmhibVJwYm1kZmJHOWhibk11ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTFkRjlzYjJGdWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZFhSemRHRnVaR2x1WjE5c2IyRnVjeUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lPREFLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZmMyaGhjbVZ6TG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5emFHRnlaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzJoaGNtVnpJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSTRNUW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwYjNKekxuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0prWlhCdmMybDBiM0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJSbGNHOXphWFJ2Y25NZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TWpjMkxUSTRNd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9DaUFnSUNBdkx5QWdJQ0FnS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gyeHBjWFZwWkdsMGVTNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1YjNWMGMzUmhibVJwYm1kZmJHOWhibk11ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNOb1lYSmxjeTUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmWkdWd2IzTnBkRzl5Y3k1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZUR1Z1WkdsdVoxQnZiMnd2YkdWdVpHbHVaMTl3YjI5c0xuQjVPakkzTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTJGa1pXNWphV0V1VEdWdVpHbHVaMUJ2YjJ3dWJHVnVaR2x1WjE5d2IyOXNMa3hsYm1ScGJtZFFiMjlzTG1kbGRGOWtaWEJ2YzJsMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJSbGNHOXphWFE2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlNWlc1a2FXNW5VRzl2YkM5c1pXNWthVzVuWDNCdmIyd3VjSGs2TWpnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSTRPQW9nSUNBZ0x5OGdZWE56WlhKMElHUmxjRzl6YVhSdmNpQnBiaUJ6Wld4bUxtUmxjRzl6YVhSekxDQWlibThnWkdWd2IzTnBkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjROalEyTlRjd05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YnlCa1pYQnZjMmwwSUdadmRXNWtDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNamc1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1a1pYQnZjMmwwYzF0a1pYQnZjMmwwYjNKZENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lPRFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR05oWkdWdVkybGhMa3hsYm1ScGJtZFFiMjlzTG14bGJtUnBibWRmY0c5dmJDNU1aVzVrYVc1blVHOXZiQzVuWlhSZmMyaGhjbVZmZG1Gc2RXVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmMyaGhjbVZmZG1Gc2RXVTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNamt4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTmhaR1Z1WTJsaEwweGxibVJwYm1kUWIyOXNMMnhsYm1ScGJtZGZjRzl2YkM1d2VUb3lPVFFLSUNBZ0lDOHZJR2xtSUhObGJHWXVkRzkwWVd4ZmMyaGhjbVZ6TG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXphR0Z5WlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMyaGhjbVZ6SUdWNGFYTjBjd29nSUNBZ1ltNTZJR2RsZEY5emFHRnlaVjkyWVd4MVpWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDB4bGJtUnBibWRRYjI5c0wyeGxibVJwYm1kZmNHOXZiQzV3ZVRveU9UVUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDZ3BuWlhSZmMyaGhjbVZmZG1Gc2RXVmZZV1owWlhKZmFXNXNhVzVsWkY5allXUmxibU5wWVM1TVpXNWthVzVuVUc5dmJDNXNaVzVrYVc1blgzQnZiMnd1VEdWdVpHbHVaMUJ2YjJ3dVoyVjBYM05vWVhKbFgzWmhiSFZsUURRNkNpQWdJQ0F2THlCallXUmxibU5wWVM5TVpXNWthVzVuVUc5dmJDOXNaVzVrYVc1blgzQnZiMnd1Y0hrNk1qa3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGOXphR0Z5WlY5MllXeDFaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOU1aVzVrYVc1blVHOXZiQzlzWlc1a2FXNW5YM0J2YjJ3dWNIazZNamsyQ2lBZ0lDQXZMeUIyWVd4MVpTQTlJQ2h6YUdGeVpYTWdLaUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVM1MllXeDFaU2tnTHk4Z2MyVnNaaTUwYjNSaGJGOXphR0Z5WlhNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5c2FYRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiR2x4ZFdsa2FYUjVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXphR0Z5WlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMyaGhjbVZ6SUdWNGFYTjBjd29nSUNBZ0x3b2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSTVOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLSFpoYkhWbEtRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdlRHVnVaR2x1WjFCdmIyd3ZiR1Z1WkdsdVoxOXdiMjlzTG5CNU9qSTVNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR2RsZEY5emFHRnlaVjkyWVd4MVpWOWhablJsY2w5cGJteHBibVZrWDJOaFpHVnVZMmxoTGt4bGJtUnBibWRRYjI5c0xteGxibVJwYm1kZmNHOXZiQzVNWlc1a2FXNW5VRzl2YkM1blpYUmZjMmhoY21WZmRtRnNkV1ZBTkFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJSUNZTUNYUnZkR0ZzWDJ4cGNRbHZkWFJmYkc5aGJuTU1kRzkwWVd4ZmMyaGhjbVZ6Qm5CaGRYTmxaQVZoWkcxcGJnaHNiMkZ1WDIxbmNncGtaWEJ2YzJsMGIzSnpCQlVmZkhVSlpYTmpjbTkzWDJsa0NXeHZZVzV6WDI5MWRBUmtaWEJmQ0FBQUFBQUFBQUFBTVJrVVJERVlRUUJWZ2dzRWlmeEJIUVFhZGdQeEJPd0lVUDBFTmlYazZ3UWg4ZDMvQkdGekR1SUVWK1duZVFTTkFLZWFCTHdYOXBJRVcyQmN0Z1I1bzl4dk5ob0FqZ3NBVEFCa0FId0FsQUUxQWI0Q0d3SmNBbjBDb3dLOUFJQUVpcGFZRGpZYUFJNEJBQUVBTmhvQlNSVWxFa1EyR2dKSkZTVVNSQ2NFVHdKbmdBWnZjbUZqYkdWTVp5Y0ZJbWNuQ0NKbktDSm5LU0puS2lKbkp3WWlaeWNKSW1jckltY2pRellhQVVrVkpCSkVGekVBSWljRVpVUVNSQ2NGVEdjalF6WWFBVWtWSkJKRUZ6RUFJaWNFWlVRU1JDY0lUR2NqUXpZYUFVa1ZJeEpFTVFBaUp3UmxSQkpFSWxNclRHY2pRNEFBTVJZakNVY0NPQkFqRWtRaUsyVkVGRVJKT0FjeUNoSkVPQWhKZ2NDRVBROUVJaXBsUkVBQVprbEZBMHNDU1VRaUtHVkVTd0lJS0V4bklpcGxSQWdxVEdkTEFUZ0FKd3BNVUVtOVJRRkJBQjVKdmtSSklsdExCUWdXWEFBeUJoWmNDRW1CRUZ0TEF3Z1dYQkMvSTBOTEF4WXlCaFpMQXhaT0FsQk1VQ2NMVUw4aUp3WmxSQ01JSndaTVowTC8zaUlxWlVSTEFRc2lLR1ZFQ2tVRFF2K01OaG9CU1JVa0VrUVhJaXRsUkJSRU1RQW5Da3NCVUVtOVJRRkVTYjVJU1NKYlNVc0ZEMFF5QmtzQ0pGdUJxS2NDQ0E5RUlpaGxSQ0lwWlVSTEFVd0pTd1pQQWdzaUttVkVURXNCQ2tsUEF3NUVUd0pMQmdrV1R3Tk1YQUJKZ1JoYlN3SUlGbHdZVHdOTXYweFBBd2txVEdjaUtHVkVTd0VKS0V4bnNiSUlzZ2Nqc2hBaXNnR3pJME0yR2dGSkZTVVNSRFlhQWtrVkpCSkVGeUlyWlVRVVJESU5JaWNGWlVRU1JDSXBaVVJKU3dJSVNZR1FUZ3NpS0dWRVRFc0JDb0dvUmd4RVR3SUpTd0lQUkNsTVp5SW5DV1ZFSXdnbkNVeG5zYklJc2djanNoQWlzZ0d6STBNMkdnRkpGU1FTUkJjeURTSW5DR1ZFRWtBQUN6SU5JaWNGWlVRU1FRQWVJMFFpS1dWRVN3RU1RUUFGS1NKbkkwTWlLV1ZFU3dFSktVeG5Rdi94SWtMLzN5SW9aVVJBQUFrbkN5Y0hURkN3STBNaUtXVkVnWkJPQ3lJb1pVUUtGa0wvNkNJb1pVUVdJaWxsUkJZaUttVkVGaUluQm1WRUZrOERUd05RVHdKUVRGQW5CMHhRc0NORE5ob0JTUlVsRWtRbkNreFFTYjFGQVVTK1NDY0hURkN3STBNMkdnRkpGU1FTUkJjaUttVkVRQUFKSndzbkIweFFzQ05ESWlobFJFc0JDeUlxWlVRS0ZrTC82UT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
