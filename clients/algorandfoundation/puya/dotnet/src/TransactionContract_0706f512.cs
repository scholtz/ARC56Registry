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

namespace Arc56.Generated.algorandfoundation.puya.TransactionContract_0706f512
{


    public class TransactionContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TransactionContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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
        /// <param name="txn"> </param>
        public async Task Pay(PaymentTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 107, 104, 3, 24 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pay_Transactions(PaymentTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 107, 104, 3, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task Key(KeyRegistrationTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 22, 196, 163, 45 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Key_Transactions(KeyRegistrationTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 22, 196, 163, 45 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task AssetConfig(AssetConfigurationTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 99, 152, 114, 214 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetConfig_Transactions(AssetConfigurationTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 99, 152, 114, 214 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task AssetTransfer(AssetTransferTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 80, 248, 241, 195 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetTransfer_Transactions(AssetTransferTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 80, 248, 241, 195 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task AssetFreeze(AssetFreezeTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 91, 58, 0, 207 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetFreeze_Transactions(AssetFreezeTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 91, 58, 0, 207 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task ApplicationCall(ApplicationCallTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 205, 98, 41, 61 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApplicationCall_Transactions(ApplicationCallTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 205, 98, 41, 61 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn1"> </param>
        /// <param name="txn2"> </param>
        /// <param name="txn3"> </param>
        public async Task MultipleTxns(ApplicationCallTransaction txn1, ApplicationCallTransaction txn2, ApplicationCallTransaction txn3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn1, txn2, txn3 });
            byte[] abiHandle = { 2, 234, 114, 229 };

            var result = await base.CallApp(new List<object> { abiHandle, txn1, txn2, txn3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MultipleTxns_Transactions(ApplicationCallTransaction txn1, ApplicationCallTransaction txn2, ApplicationCallTransaction txn3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn1, txn2, txn3 });
            byte[] abiHandle = { 2, 234, 114, 229 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn1, txn2, txn3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn1"> </param>
        /// <param name="txn2"> </param>
        /// <param name="txn3"> </param>
        public async Task AnyTxn(Transaction txn1, Transaction txn2, Transaction txn3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn1, txn2, txn3 });
            byte[] abiHandle = { 48, 86, 132, 11 };

            var result = await base.CallApp(new List<object> { abiHandle, txn1, txn2, txn3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AnyTxn_Transactions(Transaction txn1, Transaction txn2, Transaction txn3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn1, txn2, txn3 });
            byte[] abiHandle = { 48, 86, 132, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn1, txn2, txn3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn1"> </param>
        /// <param name="txn2"> </param>
        /// <param name="txn3"> </param>
        public async Task GroupInit(Transaction txn1, Transaction txn2, Transaction txn3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn1, txn2, txn3 });
            byte[] abiHandle = { 150, 239, 154, 149 };

            var result = await base.CallApp(new List<object> { abiHandle, txn1, txn2, txn3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GroupInit_Transactions(Transaction txn1, Transaction txn2, Transaction txn3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn1, txn2, txn3 });
            byte[] abiHandle = { 150, 239, 154, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn1, txn2, txn3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJhbnNhY3Rpb25Db250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoia2V5cmVnIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2V0X2NvbmZpZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2ZnIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2V0X3RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2V0X2ZyZWV6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZnJ6Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcGxpY2F0aW9uX2NhbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtdWx0aXBsZV90eG5zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG4xIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4bjMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYW55X3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ0eG4iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG4xIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ0eG4iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG4yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ0eG4iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG4zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imdyb3VwX2luaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuMyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzMV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgc2hvdWxkIGJlIGZvciA+MTAwMCBtaWNybyBhbGdvcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyM10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgc2hvdWxkIGJlIGZvciB0aGlzIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNV0sImVycm9yTWVzc2FnZSI6ImFjY291bnRzKDApIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA3XSwiZXJyb3JNZXNzYWdlIjoiYXBwX2FyZ3MoMCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzhdLCJlcnJvck1lc3NhZ2UiOiJhcHBfaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTVdLCJlcnJvck1lc3NhZ2UiOiJhcHByb3ZhbF9wcm9ncmFtIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiYXBwcm92YWxfcHJvZ3JhbV9wYWdlcygwKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNV0sImVycm9yTWVzc2FnZSI6ImFwcHMoMCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjddLCJlcnJvck1lc3NhZ2UiOiJhc3NldF9hbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODddLCJlcnJvck1lc3NhZ2UiOiJhc3NldF9jbG9zZV90byIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMF0sImVycm9yTWVzc2FnZSI6ImFzc2V0X25hbWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODFdLCJlcnJvck1lc3NhZ2UiOiJhc3NldF9yZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NF0sImVycm9yTWVzc2FnZSI6ImFzc2V0X3NlbmRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMF0sImVycm9yTWVzc2FnZSI6ImFzc2V0cygwKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0Ml0sImVycm9yTWVzc2FnZSI6ImNsYXdiYWNrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYwXSwiZXJyb3JNZXNzYWdlIjoiY2xlYXJfc3RhdGVfcHJvZ3JhbSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNl0sImVycm9yTWVzc2FnZSI6ImNsZWFyX3N0YXRlX3Byb2dyYW1fcGFnZXMoMCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzddLCJlcnJvck1lc3NhZ2UiOiJjbG9zZV9yZW1haW5kZXJfdG8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODhdLCJlcnJvck1lc3NhZ2UiOiJjb25maWdfYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJkZWNpbWFscyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMF0sImVycm9yTWVzc2FnZSI6ImRlZmF1bHRfZnJvemVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg4XSwiZXJyb3JNZXNzYWdlIjoiZXh0cmFfcHJvZ3JhbV9wYWdlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxOF0sImVycm9yTWVzc2FnZSI6ImZlZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0OF0sImVycm9yTWVzc2FnZSI6ImZpcnN0X3ZhbGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM2XSwiZXJyb3JNZXNzYWdlIjoiZnJlZXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE1XSwiZXJyb3JNZXNzYWdlIjoiZnJlZXplX2FjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDhdLCJlcnJvck1lc3NhZ2UiOiJmcmVlemVfYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMThdLCJlcnJvck1lc3NhZ2UiOiJmcm96ZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzZdLCJlcnJvck1lc3NhZ2UiOiJnbG9iYWxfbnVtX2J5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyXSwiZXJyb3JNZXNzYWdlIjoiZ2xvYmFsX251bV91aW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQzXSwiZXJyb3JNZXNzYWdlIjoiZ3JvdXBfaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTNdLCJlcnJvck1lc3NhZ2UiOiJsYXN0X2xvZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1M10sImVycm9yTWVzc2FnZSI6Imxhc3RfdmFsaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODRdLCJlcnJvck1lc3NhZ2UiOiJsb2NhbF9udW1fYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODBdLCJlcnJvck1lc3NhZ2UiOiJsb2NhbF9udW1fdWludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMl0sImVycm9yTWVzc2FnZSI6Im1hbmFnZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjhdLCJlcnJvck1lc3NhZ2UiOiJub25fcGFydGljaXBhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzN10sImVycm9yTWVzc2FnZSI6Im5vdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTBdLCJlcnJvck1lc3NhZ2UiOiJudW1fYWNjb3VudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDZdLCJlcnJvck1lc3NhZ2UiOiJudW1fYXBwX2FyZ3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTddLCJlcnJvck1lc3NhZ2UiOiJudW1fYXBwcm92YWxfcHJvZ3JhbV9wYWdlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OF0sImVycm9yTWVzc2FnZSI6Im51bV9hcHBzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY0XSwiZXJyb3JNZXNzYWdlIjoibnVtX2Fzc2V0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMV0sImVycm9yTWVzc2FnZSI6Im51bV9jbGVhcl9zdGF0ZV9wcm9ncmFtX3BhZ2VzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQyXSwiZXJyb3JNZXNzYWdlIjoib25fY29tcGxldGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2MV0sImVycm9yTWVzc2FnZSI6InJla2V5X3RvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI5XSwiZXJyb3JNZXNzYWdlIjoicmVzZXJ2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxM10sImVycm9yTWVzc2FnZSI6InNlbmRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Ml0sImVycm9yTWVzc2FnZSI6InRvdGFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBhY2ZnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAwXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBhZnJ6IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMwLDQ0OCw0NjAsNDcyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBhcHBsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMga2V5cmVnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjNdLCJlcnJvck1lc3NhZ2UiOiJ0eXBlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI5XSwiZXJyb3JNZXNzYWdlIjoidHlwZV9ieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNV0sImVycm9yTWVzc2FnZSI6InVuaXRfbmFtZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNV0sImVycm9yTWVzc2FnZSI6InVybCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MV0sImVycm9yTWVzc2FnZSI6InZvdGVfZmlyc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTddLCJlcnJvck1lc3NhZ2UiOiJ2b3RlX2tleV9kaWx1dGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NV0sImVycm9yTWVzc2FnZSI6InZvdGVfbGFzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2M10sImVycm9yTWVzc2FnZSI6InhmZXJfYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURJZ015QTJDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1Rb2dJQ0FnTHk4Z1kyeGhjM01nVkhKaGJuTmhZM1JwYjI1RGIyNTBjbUZqZENoaGNtTTBMa0ZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0Tm1JMk9EQXpNVGdnTUhneE5tTTBZVE15WkNBd2VEWXpPVGczTW1RMklEQjROVEJtT0dZeFl6TWdNSGcxWWpOaE1EQmpaaUF3ZUdOa05qSXlPVE5rSURCNE1ESmxZVGN5WlRVZ01IZ3pNRFUyT0RRd1lpQXdlRGsyWldZNVlUazFJQzh2SUcxbGRHaHZaQ0FpY0dGNUtIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSnJaWGtvYTJWNWNtVm5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnpjMlYwWDJOdmJtWnBaeWhoWTJabktYWnZhV1FpTENCdFpYUm9iMlFnSW1GemMyVjBYM1J5WVc1elptVnlLR0Y0Wm1WeUtYWnZhV1FpTENCdFpYUm9iMlFnSW1GemMyVjBYMlp5WldWNlpTaGhabko2S1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ3Y0d4cFkyRjBhVzl1WDJOaGJHd29ZWEJ3YkNsMmIybGtJaXdnYldWMGFHOWtJQ0p0ZFd4MGFYQnNaVjkwZUc1ektHRndjR3dzWVhCd2JDeGhjSEJzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ1ZVY5MGVHNG9kSGh1TEhSNGJpeDBlRzRwZG05cFpDSXNJRzFsZEdodlpDQWlaM0p2ZFhCZmFXNXBkQ2gwZUc0c2RIaHVMSFI0YmlsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY0dGNUlHdGxlU0JoYzNObGRGOWpiMjVtYVdjZ1lYTnpaWFJmZEhKaGJuTm1aWElnWVhOelpYUmZabkpsWlhwbElHRndjR3hwWTJGMGFXOXVYMk5oYkd3Z2JYVnNkR2x3YkdWZmRIaHVjeUJoYm5sZmRIaHVJR2R5YjNWd1gybHVhWFFLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TXpvS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QlVjbUZ1YzJGamRHbHZia052Ym5SeVlXTjBLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqTldNMk1XSmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNVFFLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTVRRNkNpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBjbUZ1YzJGamRHbHZiaTVqYjI1MGNtRmpkQzVVY21GdWMyRmpkR2x2YmtOdmJuUnlZV04wTG5CaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJoZVRvS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJSE5sYkdZdVgyTnZiVzF2Ymw5amFHVmphM01vZEhodUtRb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjlqYjIxdGIyNWZZMmhsWTJ0ekNpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnZEhodUxuSmxZMlZwZG1WeUlEMDlJRzl3TGtkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16UXRNellLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnZEhodUxuSmxZMlZwZG1WeUlEMDlJRzl3TGtkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lDOHZJQ2tzSUNKUVlYbHRaVzUwSUhOb2IzVnNaQ0JpWlNCbWIzSWdkR2hwY3lCaGNIQWlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCemFHOTFiR1FnWW1VZ1ptOXlJSFJvYVhNZ1lYQndDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z1lYTnpaWEowSUhSNGJpNWhiVzkxYm5RZ1BpQXhNREF3TENBaVVHRjViV1Z1ZENCemFHOTFiR1FnWW1VZ1ptOXlJRDR4TURBd0lHMXBZM0p2SUdGc1oyOXpJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUhCMWMyaHBiblFnTVRBd01Bb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdjMmh2ZFd4a0lHSmxJR1p2Y2lBK01UQXdNQ0J0YVdOeWJ5QmhiR2R2Y3dvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1WTJ4dmMyVmZjbVZ0WVdsdVpHVnlYM1J2SUQwOUlHOXdMa2RzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01zSUNKamJHOXpaVjl5WlcxaGFXNWtaWEpmZEc4aUNpQWdJQ0JuZEhodWN5QkRiRzl6WlZKbGJXRnBibVJsY2xSdkNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyeHZjMlZmY21WdFlXbHVaR1Z5WDNSdkNpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NTBjbUZ1YzJGamRHbHZiaTVqYjI1MGNtRmpkQzVVY21GdWMyRmpkR2x2YmtOdmJuUnlZV04wTG10bGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXRsZVRvS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJR3RsZVhKbFp3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUd0bGVYSmxad29nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklITmxiR1l1WDJOdmJXMXZibDlqYUdWamEzTW9kSGh1S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOWpiMjF0YjI1ZlkyaGxZMnR6Q2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTUyYjNSbFgydGxlVjlrYVd4MWRHbHZiaXdnSW5admRHVmZhMlY1WDJScGJIVjBhVzl1SWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCV2IzUmxTMlY1Ukdsc2RYUnBiMjRLSUNBZ0lHRnpjMlZ5ZENBdkx5QjJiM1JsWDJ0bGVWOWthV3gxZEdsdmJnb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dWRtOTBaVjltYVhKemRDd2dJblp2ZEdWZlptbHljM1FpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZadmRHVkdhWEp6ZEFvZ0lDQWdZWE56WlhKMElDOHZJSFp2ZEdWZlptbHljM1FLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMblp2ZEdWZmJHRnpkQ3dnSW5admRHVmZiR0Z6ZENJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZtOTBaVXhoYzNRS0lDQWdJR0Z6YzJWeWRDQXZMeUIyYjNSbFgyeGhjM1FLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbTV2Ymw5d1lYSjBhV05wY0dGMGFXOXVMQ0FpYm05dVgzQmhjblJwWTJsd1lYUnBiMjRpQ2lBZ0lDQm5kSGh1Y3lCT2IyNXdZWEowYVdOcGNHRjBhVzl1Q2lBZ0lDQmhjM05sY25RZ0x5OGdibTl1WDNCaGNuUnBZMmx3WVhScGIyNEtJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblJ5WVc1ellXTjBhVzl1TG1OdmJuUnlZV04wTGxSeVlXNXpZV04wYVc5dVEyOXVkSEpoWTNRdVlYTnpaWFJmWTI5dVptbG5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhOelpYUmZZMjl1Wm1sbk9nb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnWVdObVp3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGalptY0tJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCelpXeG1MbDlqYjIxdGIyNWZZMmhsWTJ0ektIUjRiaWtLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZlkyOXRiVzl1WDJOb1pXTnJjd29nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGVHNHVZMjl1Wm1sblgyRnpjMlYwTENBaVkyOXVabWxuWDJGemMyVjBJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJEYjI1bWFXZEJjM05sZEFvZ0lDQWdZWE56WlhKMElDOHZJR052Ym1acFoxOWhjM05sZEFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1ZEc5MFlXd3NJQ0owYjNSaGJDSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRMjl1Wm1sblFYTnpaWFJVYjNSaGJBb2dJQ0FnWVhOelpYSjBJQzh2SUhSdmRHRnNDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z1lYTnpaWEowSUhSNGJpNWtaV05wYldGc2N5d2dJbVJsWTJsdFlXeHpJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJEYjI1bWFXZEJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQmhjM05sY25RZ0x5OGdaR1ZqYVcxaGJITUtJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCaGMzTmxjblFnZEhodUxtUmxabUYxYkhSZlpuSnZlbVZ1TENBaVpHVm1ZWFZzZEY5bWNtOTZaVzRpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVOdmJtWnBaMEZ6YzJWMFJHVm1ZWFZzZEVaeWIzcGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHUmxabUYxYkhSZlpuSnZlbVZ1Q2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTUxYm1sMFgyNWhiV1VzSUNKMWJtbDBYMjVoYldVaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUhWdWFYUmZibUZ0WlFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1WVhOelpYUmZibUZ0WlN3Z0ltRnpjMlYwWDI1aGJXVWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRU52Ym1acFowRnpjMlYwVG1GdFpRb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUmZibUZ0WlFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1ZFhKc0xDQWlkWEpzSWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCRGIyNW1hV2RCYzNObGRGVlNUQW9nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z2RYSnNDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1lYTnpaWEowSUhSNGJpNXRZVzVoWjJWeUxDQWliV0Z1WVdkbGNpSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRMjl1Wm1sblFYTnpaWFJOWVc1aFoyVnlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiV0Z1WVdkbGNnb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TmpRS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dWNtVnpaWEoyWlN3Z0luSmxjMlZ5ZG1VaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklISmxjMlZ5ZG1VS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdkSGh1TG1aeVpXVjZaU3dnSW1aeVpXVjZaU0lLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUTI5dVptbG5RWE56WlhSR2NtVmxlbVVLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJtY21WbGVtVUtJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFnZEhodUxtTnNZWGRpWVdOckxDQWlZMnhoZDJKaFkyc2lDaUFnSUNCbmRIaHVjeUJEYjI1bWFXZEJjM05sZEVOc1lYZGlZV05yQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnWTJ4aGQySmhZMnNLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SeVlXNXpZV04wYVc5dUxtTnZiblJ5WVdOMExsUnlZVzV6WVdOMGFXOXVRMjl1ZEhKaFkzUXVZWE56WlhSZmRISmhibk5tWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjM05sZEY5MGNtRnVjMlpsY2pvS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYaG1aWElLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QnpaV3htTGw5amIyMXRiMjVmWTJobFkydHpLSFI0YmlrS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQmZZMjl0Ylc5dVgyTm9aV05yY3dvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1ZUdabGNsOWhjM05sZEN3Z0luaG1aWEpmWVhOelpYUWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRmhtWlhKQmMzTmxkQW9nSUNBZ1lYTnpaWEowSUM4dklIaG1aWEpmWVhOelpYUUtJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCaGMzTmxjblFnZEhodUxtRnpjMlYwWDJGdGIzVnVkQ3dnSW1GemMyVjBYMkZ0YjNWdWRDSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZEY5aGJXOTFiblFLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbUZ6YzJWMFgzTmxibVJsY2l3Z0ltRnpjMlYwWDNObGJtUmxjaUlLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVhOelpYUlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkRjl6Wlc1a1pYSUtJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjMENpQWdJQ0F2THlCaGMzTmxjblFnZEhodUxtRnpjMlYwWDNKbFkyVnBkbVZ5TENBaVlYTnpaWFJmY21WalpXbDJaWElpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2dvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1WVhOelpYUmZZMnh2YzJWZmRHOHNJQ0poYzNObGRGOWpiRzl6WlY5MGJ5SUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFEyeHZjMlZVYndvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBYMk5zYjNObFgzUnZDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwY21GdWMyRmpkR2x2Ymk1amIyNTBjbUZqZEM1VWNtRnVjMkZqZEdsdmJrTnZiblJ5WVdOMExtRnpjMlYwWDJaeVpXVjZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GemMyVjBYMlp5WldWNlpUb0tJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0ExSUM4dklHRm1jbm9LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5Qmhabko2Q2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNPUW9nSUNBZ0x5OGdjMlZzWmk1ZlkyOXRiVzl1WDJOb1pXTnJjeWgwZUc0cENpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdYMk52YlcxdmJsOWphR1ZqYTNNS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPamd4Q2lBZ0lDQXZMeUJoYzNObGNuUWdkSGh1TG1aeVpXVjZaVjloYzNObGRDd2dJbVp5WldWNlpWOWhjM05sZENJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1JuSmxaWHBsUVhOelpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCbWNtVmxlbVZmWVhOelpYUUtJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCaGMzTmxjblFnZEhodUxtWnlaV1Y2WlY5aFkyTnZkVzUwTENBaVpuSmxaWHBsWDJGalkyOTFiblFpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVaeVpXVjZaVUZ6YzJWMFFXTmpiM1Z1ZEFvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdaeVpXVjZaVjloWTJOdmRXNTBDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z1lYTnpaWEowSUhSNGJpNW1jbTk2Wlc0c0lDSm1jbTk2Wlc0aUNpQWdJQ0JuZEhodWN5QkdjbVZsZW1WQmMzTmxkRVp5YjNwbGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdaeWIzcGxiZ29nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11ZEhKaGJuTmhZM1JwYjI0dVkyOXVkSEpoWTNRdVZISmhibk5oWTNScGIyNURiMjUwY21GamRDNWhjSEJzYVdOaGRHbHZibDlqWVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEJ3YkdsallYUnBiMjVmWTJGc2JEb0tJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHpJQzh2SUdGd2NHd0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGNIQnNDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z2MyVnNaaTVmWTI5dGJXOXVYMk5vWldOcmN5aDBlRzRwQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gyTnZiVzF2Ymw5amFHVmphM01LSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbUZ3Y0Y5cFpDd2dJbUZ3Y0Y5cFpDSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0Y5cFpBb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dWIyNWZZMjl0Y0d4bGRHbHZiaXdnSW05dVgyTnZiWEJzWlhScGIyNGlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZWE56WlhKMElDOHZJRzl1WDJOdmJYQnNaWFJwYjI0S0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUWdkSGh1TG01MWJWOWhjSEJmWVhKbmN5d2dJbTUxYlY5aGNIQmZZWEpuY3lJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWVhOelpYSjBJQzh2SUc1MWJWOWhjSEJmWVhKbmN3b2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dWJuVnRYMkZqWTI5MWJuUnpMQ0FpYm5WdFgyRmpZMjkxYm5Seklnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5Qk9kVzFCWTJOdmRXNTBjd29nSUNBZ1lYTnpaWEowSUM4dklHNTFiVjloWTJOdmRXNTBjd29nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGVHNHVZWEJ3Y205MllXeGZjSEp2WjNKaGJTd2dJbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMGlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRUZ3Y0hKdmRtRnNVSEp2WjNKaGJRb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2NtOTJZV3hmY0hKdlozSmhiUW9nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGVHNHVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU3dnSW1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFTnNaV0Z5VTNSaGRHVlFjbTluY21GdENpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0Q2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzVOQW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTV1ZFcxZllYTnpaWFJ6TENBaWJuVnRYMkZ6YzJWMGN5SUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdUblZ0UVhOelpYUnpDaUFnSUNCaGMzTmxjblFnTHk4Z2JuVnRYMkZ6YzJWMGN3b2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dWJuVnRYMkZ3Y0hNc0lDSnVkVzFmWVhCd2N5SUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdUblZ0UVhCd2JHbGpZWFJwYjI1ekNpQWdJQ0JoYzNObGNuUWdMeThnYm5WdFgyRndjSE1LSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbWRzYjJKaGJGOXVkVzFmZFdsdWRDd2dJbWRzYjJKaGJGOXVkVzFmZFdsdWRDSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdSMnh2WW1Gc1RuVnRWV2x1ZEFvZ0lDQWdZWE56WlhKMElDOHZJR2RzYjJKaGJGOXVkVzFmZFdsdWRBb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dVoyeHZZbUZzWDI1MWJWOWllWFJsY3l3Z0ltZHNiMkpoYkY5dWRXMWZZbmwwWlhNaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFZHNiMkpoYkU1MWJVSjVkR1ZUYkdsalpRb2dJQ0FnWVhOelpYSjBJQzh2SUdkc2IySmhiRjl1ZFcxZllubDBaWE1LSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbXh2WTJGc1gyNTFiVjkxYVc1MExDQWliRzlqWVd4ZmJuVnRYM1ZwYm5RaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFeHZZMkZzVG5WdFZXbHVkQW9nSUNBZ1lYTnpaWEowSUM4dklHeHZZMkZzWDI1MWJWOTFhVzUwQ2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzVPUW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTVzYjJOaGJGOXVkVzFmWW5sMFpYTXNJQ0pzYjJOaGJGOXVkVzFmWW5sMFpYTWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRXh2WTJGc1RuVnRRbmwwWlZOc2FXTmxDaUFnSUNCaGMzTmxjblFnTHk4Z2JHOWpZV3hmYm5WdFgySjVkR1Z6Q2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1WlhoMGNtRmZjSEp2WjNKaGJWOXdZV2RsY3l3Z0ltVjRkSEpoWDNCeWIyZHlZVzFmY0dGblpYTWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRVY0ZEhKaFVISnZaM0poYlZCaFoyVnpDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaDBjbUZmY0hKdlozSmhiVjl3WVdkbGN3b2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCaGMzTmxjblFnZEhodUxteGhjM1JmYkc5bkxDQWliR0Z6ZEY5c2IyY2lDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRXhoYzNSTWIyY0tJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUd4aGMzUmZiRzluQ2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1Ym5WdFgyRndjSEp2ZG1Gc1gzQnliMmR5WVcxZmNHRm5aWE1zSUNKdWRXMWZZWEJ3Y205MllXeGZjSEp2WjNKaGJWOXdZV2RsY3lJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1RuVnRRWEJ3Y205MllXeFFjbTluY21GdFVHRm5aWE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QnVkVzFmWVhCd2NtOTJZV3hmY0hKdlozSmhiVjl3WVdkbGN3b2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCaGMzTmxjblFnZEhodUxtNTFiVjlqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0WDNCaFoyVnpMQ0FpYm5WdFgyTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMWZjR0ZuWlhNaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFNTFiVU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1ZFcxZlkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJWOXdZV2RsY3dvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdkSGh1TG1Gd2NGOWhjbWR6S0RBcExDQWlZWEJ3WDJGeVozTW9NQ2tpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3WDJGeVozTW9NQ2tLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTVoWTJOdmRXNTBjeWd3S1N3Z0ltRmpZMjkxYm5SektEQXBJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjMkVnUVdOamIzVnVkSE1nTUFvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblJ6S0RBcENpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dVlYTnpaWFJ6S0RBcExDQWlZWE56WlhSektEQXBJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjMkVnUVhOelpYUnpJREFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZEhNb01Da0tJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z1lYTnpaWEowSUhSNGJpNWhjSEJ6S0RBcExDQWlZWEJ3Y3lnd0tTSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1Y3lBd0NpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2N5Z3dLUW9nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMWZjR0ZuWlhNb01Da3NJQ0poY0hCeWIzWmhiRjl3Y205bmNtRnRYM0JoWjJWektEQXBJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjMkVnUVhCd2NtOTJZV3hRY205bmNtRnRVR0ZuWlhNZ01Bb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2NtOTJZV3hmY0hKdlozSmhiVjl3WVdkbGN5Z3dLUW9nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTVDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzFmY0dGblpYTW9NQ2tzSUNKamJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdFgzQmhaMlZ6S0RBcElnb2dJQ0FnWjNSNGJuTmhJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNZ01Bb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlY5d1lXZGxjeWd3S1FvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRISmhibk5oWTNScGIyNHVZMjl1ZEhKaFkzUXVWSEpoYm5OaFkzUnBiMjVEYjI1MGNtRmpkQzV0ZFd4MGFYQnNaVjkwZUc1elczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiWFZzZEdsd2JHVmZkSGh1Y3pvS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk15QXZMeUJoY0hCc0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVhCd2JBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6TWdMeThnWVhCd2JBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGd2NHd0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHpJQzh2SUdGd2NHd0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGNIQnNDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnWm05eUlHbHVaR1Y0TENCaGNIQWdhVzRnZFdWdWRXMWxjbUYwWlNnb2RIaHVNU3dnZEhodU1pd2dkSGh1TXlrcE9nb2dJQ0FnYzNkaGNBb0tiWFZzZEdsd2JHVmZkSGh1YzE5bWIzSmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRFNUNpQWdJQ0F2THlCaGMzTmxjblFnWVhCd0xtZHliM1Z3WDJsdVpHVjRJRDA5SUdsdVpHVjRDaUFnSUNCbmRIaHVjeUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEU0Q2lBZ0lDQXZMeUJtYjNJZ2FXNWtaWGdzSUdGd2NDQnBiaUIxWlc1MWJXVnlZWFJsS0NoMGVHNHhMQ0IwZUc0eUxDQjBlRzR6S1NrNkNpQWdJQ0J6ZDJsMFkyZ2diWFZzZEdsd2JHVmZkSGh1YzE5bWIzSmZhR1ZoWkdWeVh6RkFOQ0J0ZFd4MGFYQnNaVjkwZUc1elgyWnZjbDlvWldGa1pYSmZNa0ExQ2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiWFZzZEdsd2JHVmZkSGh1YzE5bWIzSmZhR1ZoWkdWeVh6SkFOVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpQnRkV3gwYVhCc1pWOTBlRzV6WDJadmNsOWliMlI1UURJS0NtMTFiSFJwY0d4bFgzUjRibk5mWm05eVgyaGxZV1JsY2w4eFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklESUtJQ0FnSUdJZ2JYVnNkR2x3YkdWZmRIaHVjMTltYjNKZlltOWtlVUF5Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwY21GdWMyRmpkR2x2Ymk1amIyNTBjbUZqZEM1VWNtRnVjMkZqZEdsdmJrTnZiblJ5WVdOMExtRnVlVjkwZUc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhibmxmZEhodU9nb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ0xRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0F0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEk0Q2lBZ0lDQXZMeUJtYjNJZ2FXNWtaWGdzSUhSNGJpQnBiaUIxWlc1MWJXVnlZWFJsS0NoMGVHNHhMQ0IwZUc0eUxDQjBlRzR6S1NrNkNpQWdJQ0J6ZDJGd0NncGhibmxmZEhodVgyWnZjbDlpYjJSNVFESTZDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCMGVHNHVaM0p2ZFhCZmFXNWtaWGdnUFQwZ2FXNWtaWGdLSUNBZ0lHZDBlRzV6SUVkeWIzVndTVzVrWlhnS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpnS0lDQWdJQzh2SUdadmNpQnBibVJsZUN3Z2RIaHVJR2x1SUhWbGJuVnRaWEpoZEdVb0tIUjRiakVzSUhSNGJqSXNJSFI0YmpNcEtUb0tJQ0FnSUhOM2FYUmphQ0JoYm5sZmRIaHVYMlp2Y2w5b1pXRmtaWEpmTVVBMElHRnVlVjkwZUc1ZlptOXlYMmhsWVdSbGNsOHlRRFVLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXlNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGhibmxmZEhodVgyWnZjbDlvWldGa1pYSmZNa0ExT2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlJR0Z1ZVY5MGVHNWZabTl5WDJKdlpIbEFNZ29LWVc1NVgzUjRibDltYjNKZmFHVmhaR1Z5WHpGQU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JrYVdjZ01nb2dJQ0FnWWlCaGJubGZkSGh1WDJadmNsOWliMlI1UURJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5SeVlXNXpZV04wYVc5dUxtTnZiblJ5WVdOMExsUnlZVzV6WVdOMGFXOXVRMjl1ZEhKaFkzUXVaM0p2ZFhCZmFXNXBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21keWIzVndYMmx1YVhRNkNpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXpDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdMUW9nSUNBZ2MzZGhjQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lITjNZWEFLQ21keWIzVndYMmx1YVhSZlptOXlYMkp2WkhsQU1qb0tJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFek9Rb2dJQ0FnTHk4Z2RIaHVYMlp5YjIxZmFXNWtaWGdnUFNCbmRIaHVMbFJ5WVc1ellXTjBhVzl1S0hSNGJpNW5jbTkxY0Y5cGJtUmxlQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUjNKdmRYQkpibVJsZUFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdkSGh1TG5SNGJsOXBaQ0E5UFNCMGVHNWZabkp2YlY5cGJtUmxlQzUwZUc1ZmFXUUtJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRlI0U1VRS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklGUjRTVVFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJ5WVc1ellXTjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpPQW9nSUNBZ0x5OGdabTl5SUhSNGJpQnBiaUFvZEhodU1Td2dkSGh1TWl3Z2RIaHVNeWs2Q2lBZ0lDQnpkMmwwWTJnZ1ozSnZkWEJmYVc1cGRGOW1iM0pmYUdWaFpHVnlYekZBTkNCbmNtOTFjRjlwYm1sMFgyWnZjbDlvWldGa1pYSmZNa0ExQ2lBZ0lDQndiM0J1SURJS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTVFvZ0lDQWdMeThnWVhOelpYSjBJSFI0YmpFdWRIaHVYMmxrSUQwOUlHZDBlRzR1VkhKaGJuTmhZM1JwYjI0b01Da3VkSGh1WDJsa0NpQWdJQ0JuZEhodWN5QlVlRWxFQ2lBZ0lDQm5kSGh1SURBZ1ZIaEpSQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkSEpoYm5OaFkzUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZHliM1Z3WDJsdWFYUmZabTl5WDJobFlXUmxjbDh5UURVNkNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR0lnWjNKdmRYQmZhVzVwZEY5bWIzSmZZbTlrZVVBeUNncG5jbTkxY0Y5cGJtbDBYMlp2Y2w5b1pXRmtaWEpmTVVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1JwWnlBeUNpQWdJQ0JpSUdkeWIzVndYMmx1YVhSZlptOXlYMkp2WkhsQU1nb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWRISmhibk5oWTNScGIyNHVZMjl1ZEhKaFkzUXVWSEpoYm5OaFkzUnBiMjVEYjI1MGNtRmpkQzVmWTI5dGJXOXVYMk5vWldOcmN5aDBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWDJOdmJXMXZibDlqYUdWamEzTTZDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5pMHhOd29nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVLSUNBZ0lDOHZJR1JsWmlCZlkyOXRiVzl1WDJOb1pXTnJjeWh6Wld4bUxDQjBlRzQ2SUdkMGVHNHVWSEpoYm5OaFkzUnBiMjVDWVhObEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUIwY21GdWMyRmpkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPUW9nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTV6Wlc1a1pYSWdQVDBnYjNBdVIyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSW5ObGJtUmxjaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYzJWdVpHVnlDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhSNGJpNW1aV1VzSUNKbVpXVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRVpsWlFvZ0lDQWdZWE56WlhKMElDOHZJR1psWlFvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI0dlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBlRzR1ZEhsd1pTd2dJblI1Y0dVaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JoYzNObGNuUWdMeThnZEhsd1pRb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dWRIbHdaVjlpZVhSbGN5d2dJblI1Y0dWZllubDBaWE1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZSNWNHVUtJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUhSNWNHVmZZbmwwWlhNS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dUwyTnZiblJ5WVdOMExuQjVPakl6Q2lBZ0lDQXZMeUJoYzNObGNuUWdkSGh1TG01dmRHVWdQVDBnUW5sMFpYTW9ZaUlpS1N3Z0ltNXZkR1VpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUU1dmRHVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNSbENpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnWVhOelpYSjBJSFI0Ymk1bmNtOTFjRjlwYm1SbGVDQTlQU0F3TENBaVozSnZkWEJmYVc1a1pYZ2lDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRWR5YjNWd1NXNWtaWGdLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCbmNtOTFjRjlwYm1SbGVBb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUdGemMyVnlkQ0IwZUc0dVptbHljM1JmZG1Gc2FXUXNJQ0ptYVhKemRGOTJZV3hwWkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1JtbHljM1JXWVd4cFpBb2dJQ0FnWVhOelpYSjBJQzh2SUdacGNuTjBYM1poYkdsa0NpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TmkweU53b2dJQ0FnTHk4Z0l5QmhjM05sY25RZ2RIaHVMbVpwY25OMFgzWmhiR2xrWDNScGJXVXNJQ0ptYVhKemRGOTJZV3hwWkY5MGFXMWxJaUFqSUhSb2FYTWdkbUZzZFdVZ1kyRnVJR0psSUdac1lXdDVJR2x1SUhSbGMzUnpDaUFnSUNBdkx5QmhjM05sY25RZ2RIaHVMbXhoYzNSZmRtRnNhV1FzSUNKc1lYTjBYM1poYkdsa0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5Qk1ZWE4wVm1Gc2FXUUtJQ0FnSUdGemMyVnlkQ0F2THlCc1lYTjBYM1poYkdsa0NpQWdJQ0F2THlCMGNtRnVjMkZqZEdsdmJpOWpiMjUwY21GamRDNXdlVG95T1FvZ0lDQWdMeThnWVhOelpYSjBJSFI0Ymk1eVpXdGxlVjkwYnlBOVBTQnZjQzVIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56TENBaWNtVnJaWGxmZEc4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxhMlY1Vkc4S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCeVpXdGxlVjkwYndvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFJREJqRVpGRVF4R0VFQVI0SUpCR3RvQXhnRUZzU2pMUVJqbUhMV0JGRDQ4Y01FV3pvQXp3VE5ZaWs5QkFMcWN1VUVNRmFFQ3dTVzc1cVZOaG9BamdrQUVRQTJBRlVBbndETUFPc0JZUUdnQWNzQWdBUk1YR0c2TmhvQWpnRUFBUUFpUXpFV0lnbEpPQkFpRWtSSmlBSG1TVGdITWdvU1JFazRDSUhvQncxRU9Ba3lBeEpFSWtNeEZpSUpTVGdRSXhKRVNZZ0J3VWs0RGtSSk9BeEVTVGdOUkRnNVJDSkRNUllpQ1VrNEVDUVNSRW1JQWFKSk9DRkVTVGdpUkVrNEkwUkpPQ1JFU1RnbEZVUkpPQ1lWUkVrNEp4VkVTVGdwTWdNVFJFazRLaklERTBSSk9Dc3lBeE5FT0N3eUF4TkVJa014RmlJSlNUZ1FnUVFTUkVtSUFWZEpPQkZFU1RnU1JFazRFeklERTBSSk9CUXlBeE5FT0JVeUF4TkVJa014RmlJSlNUZ1FnUVVTUkVtSUFTcEpPQzFFU1RndU1nTVRSRGd2UkNKRE1SWWlDVWs0RUNVU1JFbUlBUXhKT0JoRVNUZ1pSRWs0RzBSSk9CMUVTVGdlRlVSSk9COFZSRWs0TVVSSk9ETkVTVGcwUkVrNE5VUkpPRFpFU1RnM1JFazRPRVJKT0Q0VlJFazRRVVJKT0VORVNUa2FBQlZFU1RrY0FESURFMFJKT1RBQVJFazVNZ0JFU1RsQUFCVkVPVUlBRlVRaVF6RVdKQWxKT0JBbEVrUXhGaU1KU1U0Q09CQWxFa1F4RmlJSlNVNENPQkFsRWtTQkFFdzRGa3NCRWtTTkFnQUlBQUlpUXlOTEFVTC83Q0pMQWtMLzVqRVdKQWt4RmlNSlRERVdJZ2xNZ1FCTU9CWkxBUkpFalFJQUNBQUNJa01qU3dGQy8rd2lTd0pDLytZeEZpUUpTVEVXSXdsTU1SWWlDVXlCQUV4Sk9CWk1PQmRNT0JjU1JJMENBQkVBQzBZQ09CY3pBQmNTUkNKREkwc0JRdi9lSWtzQ1F2L1lpZ0VBaS84NEFESUpFa1NML3pnQlJJdi9PQkJFaS84NER4VkVpLzg0QllBQUVrU0wvemdXRkVTTC96Z0NSSXYvT0FSRWkvODRJRElERWtTSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
