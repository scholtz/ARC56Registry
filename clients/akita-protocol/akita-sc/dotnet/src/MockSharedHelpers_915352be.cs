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

namespace Arc56.Generated.akita_protocol.akita_sc.MockSharedHelpers_915352be
{


    //
    // TEST-ONLY harness exposing the Wave 0 shared helpers so they can be exercised directly
    //on LocalNet. Never deploy outside tests.
    //
    public class MockSharedHelpersProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockSharedHelpersProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="sender"> </param>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task CheckPayment(PaymentTransaction payment, Algorand.Address sender, Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 244, 115, 191, 76 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, payment, senderAbi, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckPayment_Transactions(PaymentTransaction payment, Algorand.Address sender, Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 244, 115, 191, 76 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, senderAbi, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="sender"> </param>
        public async Task CheckSafePayment(PaymentTransaction payment, Algorand.Address sender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 131, 57, 73, 57 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            var result = await base.CallApp(new List<object> { abiHandle, payment, senderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckSafePayment_Transactions(PaymentTransaction payment, Algorand.Address sender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 131, 57, 73, 57 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, senderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task CheckPlainPayment(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 102, 200, 28, 73 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckPlainPayment_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 102, 200, 28, 73 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task CheckExactPayment(PaymentTransaction payment, Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 168, 125, 24, 45 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, payment, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckExactPayment_Transactions(PaymentTransaction payment, Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 168, 125, 24, 45 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Holds a deposit of `amount` for the caller's `record`. Anyone may pay it; a payer other than the
        ///caller is remembered and also funds its payer record.
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="record"> </param>
        /// <param name="amount"> </param>
        public async Task Hold(PaymentTransaction payment, byte[] record, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 222, 83, 15, 161 };
            var recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordAbi.From(record);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, payment, recordAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Hold_Transactions(PaymentTransaction payment, byte[] record, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 222, 83, 15, 161 };
            var recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordAbi.From(record);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, recordAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="record"> </param>
        /// <param name="owner"> </param>
        public async Task<Algorand.Address> HeldBy(byte[] record, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 218, 74, 244 };
            var recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordAbi.From(record);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, recordAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> HeldBy_Transactions(byte[] record, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 218, 74, 244 };
            var recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordAbi.From(record);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, recordAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Releases the deposit of `amount` held for `record` and pays it to whoever funded it. Returns that account.
        ///</summary>
        /// <param name="record"> </param>
        /// <param name="owner"> </param>
        /// <param name="amount"> </param>
        public async Task<Algorand.Address> Release(byte[] record, Algorand.Address owner, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 29, 50, 73 };
            var recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordAbi.From(record);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, recordAbi, ownerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Release_Transactions(byte[] record, Algorand.Address owner, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 29, 50, 73 };
            var recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordAbi.From(record);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, recordAbi, ownerAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xfer"> </param>
        /// <param name="sender"> </param>
        /// <param name="receiver"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        public async Task CheckAssetTransfer(AssetTransferTransaction xfer, Algorand.Address sender, Algorand.Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer });
            byte[] abiHandle = { 169, 191, 184, 151 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, xfer, senderAbi, receiverAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckAssetTransfer_Transactions(AssetTransferTransaction xfer, Algorand.Address sender, Algorand.Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer });
            byte[] abiHandle = { 169, 191, 184, 151 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, xfer, senderAbi, receiverAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xfer"> </param>
        /// <param name="sender"> </param>
        public async Task CheckSafeAssetTransfer(AssetTransferTransaction xfer, Algorand.Address sender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer });
            byte[] abiHandle = { 123, 253, 244, 72 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            var result = await base.CallApp(new List<object> { abiHandle, xfer, senderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckSafeAssetTransfer_Transactions(AssetTransferTransaction xfer, Algorand.Address sender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer });
            byte[] abiHandle = { 123, 253, 244, 72 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            return await base.MakeTransactionList(new List<object> { abiHandle, xfer, senderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Algorand.Address> ControlledSpending(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 56, 174, 239 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> ControlledSpending_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 56, 174, 239 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="approvalSize"> </param>
        /// <param name="clearSize"> </param>
        /// <param name="minExtraPages"> </param>
        public async Task<ulong> ExtraPages(ulong approvalSize, ulong clearSize, ulong minExtraPages, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 47, 28, 166 };
            var approvalSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalSizeAbi.From(approvalSize);
            var clearSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); clearSizeAbi.From(clearSize);
            var minExtraPagesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minExtraPagesAbi.From(minExtraPages);

            var result = await base.CallApp(new List<object> { abiHandle, approvalSizeAbi, clearSizeAbi, minExtraPagesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ExtraPages_Transactions(ulong approvalSize, ulong clearSize, ulong minExtraPages, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 47, 28, 166 };
            var approvalSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalSizeAbi.From(approvalSize);
            var clearSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); clearSizeAbi.From(clearSize);
            var minExtraPagesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minExtraPagesAbi.From(minExtraPages);

            return await base.MakeTransactionList(new List<object> { abiHandle, approvalSizeAbi, clearSizeAbi, minExtraPagesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a child app and fund it with `funding` µALGO on top of nothing (caller pays via app balance).
        ///</summary>
        /// <param name="funding"> </param>
        public async Task<ulong> Spawn(ulong funding, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 3, 240, 32 };
            var fundingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fundingAbi.From(funding);

            var result = await base.CallApp(new List<object> { abiHandle, fundingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Spawn_Transactions(ulong funding, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 3, 240, 32 };
            var fundingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fundingAbi.From(funding);

            return await base.MakeTransactionList(new List<object> { abiHandle, fundingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete `child` (it closes its balance back here) and pay `receiver` the released refund,
        ///capped at `recorded`. Returns the refund.
        ///</summary>
        /// <param name="child"> </param>
        /// <param name="recorded"> </param>
        /// <param name="receiver"> </param>
        public async Task<ulong> Reap(ulong child, ulong recorded, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 180, 36, 169 };
            var childAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); childAbi.From(child);
            var recordedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); recordedAbi.From(recorded);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, childAbi, recordedAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Reap_Transactions(ulong child, ulong recorded, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 180, 36, 169 };
            var childAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); childAbi.From(child);
            var recordedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); recordedAbi.From(recorded);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, childAbi, recordedAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja1NoYXJlZEhlbHBlcnMiLCJkZXNjIjoiVEVTVC1PTkxZIGhhcm5lc3MgZXhwb3NpbmcgdGhlIFdhdmUgMCBzaGFyZWQgaGVscGVycyBzbyB0aGV5IGNhbiBiZSBleGVyY2lzZWQgZGlyZWN0bHlcbm9uIExvY2FsTmV0LiBOZXZlciBkZXBsb3kgb3V0c2lkZSB0ZXN0cy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVja1BheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tTYWZlUGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrUGxhaW5QYXltZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tFeGFjdFBheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaG9sZCIsImRlc2MiOiJIb2xkcyBhIGRlcG9zaXQgb2YgYGFtb3VudGAgZm9yIHRoZSBjYWxsZXIncyBgcmVjb3JkYC4gQW55b25lIG1heSBwYXkgaXQ7IGEgcGF5ZXIgb3RoZXIgdGhhbiB0aGVcbmNhbGxlciBpcyByZW1lbWJlcmVkIGFuZCBhbHNvIGZ1bmRzIGl0cyBwYXllciByZWNvcmQuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY29yZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImhlbGRCeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNvcmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlIiwiZGVzYyI6IlJlbGVhc2VzIHRoZSBkZXBvc2l0IG9mIGBhbW91bnRgIGhlbGQgZm9yIGByZWNvcmRgIGFuZCBwYXlzIGl0IHRvIHdob2V2ZXIgZnVuZGVkIGl0LiBSZXR1cm5zIHRoYXQgYWNjb3VudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjb3JkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVja0Fzc2V0VHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tTYWZlQXNzZXRUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InhmZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29udHJvbGxlZFNwZW5kaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleHRyYVBhZ2VzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmFsU2l6ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xlYXJTaXplIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5FeHRyYVBhZ2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Bhd24iLCJkZXNjIjoiQ3JlYXRlIGEgY2hpbGQgYXBwIGFuZCBmdW5kIGl0IHdpdGggYGZ1bmRpbmdgIMK1QUxHTyBvbiB0b3Agb2Ygbm90aGluZyAoY2FsbGVyIHBheXMgdmlhIGFwcCBiYWxhbmNlKS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnVuZGluZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYXAiLCJkZXNjIjoiRGVsZXRlIGBjaGlsZGAgKGl0IGNsb3NlcyBpdHMgYmFsYW5jZSBiYWNrIGhlcmUpIGFuZCBwYXkgYHJlY2VpdmVyYCB0aGUgcmVsZWFzZWQgcmVmdW5kLFxuY2FwcGVkIGF0IGByZWNvcmRlZGAuIFJldHVybnMgdGhlIHJlZnVuZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hpbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY29yZGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzkwOF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJYWFtIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYxXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhcmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySWFzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Miw0NTNdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySXBtYSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OCw0NDJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySXBtciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MCwzMzRdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySXBtcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4OF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOYXRoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIyLDMwMywzNzJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmNscyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1OV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOY2x3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM1LDMxNiwzODVdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTnJreSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTVdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyUHRsZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2NywxMjQxLDEyNDksMTI4NywxMzAyXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTgxXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQxLDYxNiw2NjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDksNjI0LDY3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDUsNDEzLDQ3Myw1MTEsNjM3LDY4NCw4MDIsODEwLDkyOSwxMjMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMSw1MTksNTYxLDY5Miw4MTgsODI5LDk0MiwxMDAyLDEwMTEsMTAyMCwxMDkyLDEyMDksMTIxOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NCw5MjFdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk3LDQ2NSw0ODgsNTAzLDUzNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0E0SURBZ016SWdNamcxTURBS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaVJWSlNPbVZ5Y2s1amJITWlJQ0pGVWxJNlpYSnlUbkpyZVNJZ0lpUWlJQ0pGVWxJNlpYSnlTWEJ0Y2lJZ0lrVlNVanBsY25KSmNHMWhJaUFpUlZKU09tVnlja2x3YlhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjMmhoY21Wa0xXaGxiSEJsY25NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTF2WTJ0VGFHRnlaV1JJWld4d1pYSnpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURJeENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNE5UUmtaV1JsTUNBd2VHWTBOek5pWmpSaklEQjRPRE16T1RRNU16a2dNSGcyTm1NNE1XTTBPU0F3ZUdFNE4yUXhPREprSURCNFpHVTFNekJtWVRFZ01IaGlOR1JoTkdGbU5DQXdlR0UyTVdRek1qUTVJREI0WVRsaVptSTRPVGNnTUhnM1ltWmtaalEwT0NBd2VHSmpNemhoWldWbUlEQjRORFF5WmpGallUWWdNSGhsWXpBelpqQXlNQ0F3ZURKbVlqUXlOR0U1SUM4dklHMWxkR2h2WkNBaWIzQlZjQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlZMmhsWTJ0UVlYbHRaVzUwS0hCaGVTeGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5vWldOclUyRm1aVkJoZVcxbGJuUW9jR0Y1TEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlZMmhsWTJ0UWJHRnBibEJoZVcxbGJuUW9jR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5vWldOclJYaGhZM1JRWVhsdFpXNTBLSEJoZVN4aFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm9iMnhrS0hCaGVTeGllWFJsVzEwc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWhsYkdSQ2VTaGllWFJsVzEwc1lXUmtjbVZ6Y3lsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKeVpXeGxZWE5sS0dKNWRHVmJYU3hoWkdSeVpYTnpMSFZwYm5RMk5DbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSmphR1ZqYTBGemMyVjBWSEpoYm5ObVpYSW9ZWGhtWlhJc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkyaGxZMnRUWVdabFFYTnpaWFJVY21GdWMyWmxjaWhoZUdabGNpeGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1OdmJuUnliMnhzWldSVGNHVnVaR2x1WnloMWFXNTBOalFwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpWlhoMGNtRlFZV2RsY3loMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luTndZWGR1S0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsWVhBb2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmIzQlZjRjl5YjNWMFpVQTBJR05vWldOclVHRjViV1Z1ZENCamFHVmphMU5oWm1WUVlYbHRaVzUwSUdOb1pXTnJVR3hoYVc1UVlYbHRaVzUwSUdOb1pXTnJSWGhoWTNSUVlYbHRaVzUwSUdodmJHUWdhR1ZzWkVKNUlISmxiR1ZoYzJVZ1kyaGxZMnRCYzNObGRGUnlZVzV6Wm1WeUlHTm9aV05yVTJGbVpVRnpjMlYwVkhKaGJuTm1aWElnWTI5dWRISnZiR3hsWkZOd1pXNWthVzVuSUdWNGRISmhVR0ZuWlhNZ2MzQmhkMjRnY21WaGNBb2dJQ0FnWlhKeUNncHRZV2x1WDI5d1ZYQmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl6YUdGeVpXUXRhR1ZzY0dWeWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QnZjRlZ3S0NrNklIWnZhV1FnZXlCOUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXphR0Z5WldRdGFHVnNjR1Z5Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTFOb1lYSmxaRWhsYkhCbGNuTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9tRnpjMlZ5ZEZCc1lXbHVVR0Y1YldWdWRDaDBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWVhOelpYSjBVR3hoYVc1UVlYbHRaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8yTndvZ0lDQWdMeThnWlhod2IzSjBJR1oxYm1OMGFXOXVJR0Z6YzJWeWRGQnNZV2x1VUdGNWJXVnVkQ2gwZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qWTRDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEhodUxtTnNiM05sVW1WdFlXbHVaR1Z5Vkc4Z1BUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdnWlhKeVEyeHZjMlZHYjNKaWFXUmtaVzRwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVOc2IzTmxVbVZ0WVdsdVpHVnlWRzhLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCaGMzTmxjblJRYkdGcGJsQmhlVzFsYm5SZllXWjBaWEpmWVhOelpYSjBRRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJa1ZTVWpwbGNuSk9ZMnh6SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2s1amJITUtDbUZ6YzJWeWRGQnNZV2x1VUdGNWJXVnVkRjloWm5SbGNsOWhjM05sY25SQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5qa0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2gwZUc0dWNtVnJaWGxVYnlBOVBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQ0JsY25KU1pXdGxlVVp2Y21KcFpHUmxiaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WclpYbFVid29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdGemMyVnlkRkJzWVdsdVVHRjViV1Z1ZEY5aFpuUmxjbDloYzNObGNuUkFOQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlSVkpTT21WeWNrNXlhM2tpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VG5KcmVRb0tZWE56WlhKMFVHeGhhVzVRWVhsdFpXNTBYMkZtZEdWeVgyRnpjMlZ5ZEVBME9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNllYTnpaWEowUlhoaFkzUlFZWGx0Wlc1MEtIUjRiam9nZFdsdWREWTBMQ0J5WldObGFYWmxjam9nWW5sMFpYTXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGhjM05sY25SRmVHRmpkRkJoZVcxbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qYzJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1puVnVZM1JwYjI0Z1lYTnpaWEowUlhoaFkzUlFZWGx0Wlc1MEtIUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0J5WldObGFYWmxjam9nUVdOamIzVnVkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8zTndvZ0lDQWdMeThnWVhOelpYSjBVR3hoYVc1UVlYbHRaVzUwS0hSNGJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUlFiR0ZwYmxCaGVXMWxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOemdLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGVHNHVjbVZqWldsMlpYSWdQVDA5SUhKbFkyVnBkbVZ5TENCbGNuSkpiblpoYkdsa1VHRjViV1Z1ZEZKbFkyVnBkbVZ5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR0Z6YzJWeWRFVjRZV04wVUdGNWJXVnVkRjloWm5SbGNsOWhjM05sY25SQU1nb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVJWSlNPbVZ5Y2tsd2JYSWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTWEJ0Y2dvS1lYTnpaWEowUlhoaFkzUlFZWGx0Wlc1MFgyRm1kR1Z5WDJGemMyVnlkRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8zT1FvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUjRiaTVoYlc5MWJuUWdQVDA5SUdGdGIzVnVkQ3dnWlhKeVNXNTJZV3hwWkZCaGVXMWxiblJCYlc5MWJuUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdGemMyVnlkRVY0WVdOMFVHRjViV1Z1ZEY5aFpuUmxjbDloYzNObGNuUkFOQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlSVkpTT21WeWNrbHdiV0VpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1hCdFlRb0tZWE56WlhKMFJYaGhZM1JRWVhsdFpXNTBYMkZtZEdWeVgyRnpjMlZ5ZEVBME9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNllYTnpaWEowVTJGbVpWQmhlVzFsYm5Rb2RIaHVPaUIxYVc1ME5qUXNJSE5sYm1SbGNqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtRnpjMlZ5ZEZOaFptVlFZWGx0Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE5UVUtJQ0FnSUM4dklHVjRjRzl5ZENCbWRXNWpkR2x2YmlCaGMzTmxjblJUWVdabFVHRjViV1Z1ZENoMGVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2djMlZ1WkdWeU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVFUyQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RIaHVMbk5sYm1SbGNpQTlQVDBnYzJWdVpHVnlMQ0JsY25KSmJuWmhiR2xrVUdGNWJXVnVkRk5sYm1SbGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWVhOelpYSjBVMkZtWlZCaGVXMWxiblJmWVdaMFpYSmZZWE56WlhKMFFESUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lrVlNVanBsY25KSmNHMXpJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2x3YlhNS0NtRnpjMlZ5ZEZOaFptVlFZWGx0Wlc1MFgyRm1kR1Z5WDJGemMyVnlkRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TlRjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBlRzR1WTJ4dmMyVlNaVzFoYVc1a1pYSlVieUE5UFQwZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxDQmxjbkpEYkc5elpVWnZjbUpwWkdSbGJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR0Z6YzJWeWRGTmhabVZRWVhsdFpXNTBYMkZtZEdWeVgyRnpjMlZ5ZEVBMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKRlVsSTZaWEp5VG1Oc2N5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9ZMnh6Q2dwaGMzTmxjblJUWVdabFVHRjViV1Z1ZEY5aFpuUmxjbDloYzNObGNuUkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVFU0Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RIaHVMbkpsYTJWNVZHOGdQVDA5SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3Z1pYSnlVbVZyWlhsR2IzSmlhV1JrWlc0cENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2QwZUc1eklGSmxhMlY1Vkc4S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmhjM05sY25SVFlXWmxVR0Y1YldWdWRGOWhablJsY2w5aGMzTmxjblJBTmdvZ0lDQWdZbmwwWldOZk1pQXZMeUFpUlZKU09tVnljazV5YTNraUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVRuSnJlUW9LWVhOelpYSjBVMkZtWlZCaGVXMWxiblJmWVdaMFpYSmZZWE56WlhKMFFEWTZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qcGhjM05sY25SVFlXWmxRWE56WlhSVWNtRnVjMlpsY2loMGVHNDZJSFZwYm5RMk5Dd2djMlZ1WkdWeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1lYTnpaWEowVTJGbVpVRnpjMlYwVkhKaGJuTm1aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakUzTmdvZ0lDQWdMeThnWlhod2IzSjBJR1oxYm1OMGFXOXVJR0Z6YzJWeWRGTmhabVZCYzNObGRGUnlZVzV6Wm1WeUtIUjRiam9nWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUxDQnpaVzVrWlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3hOemNLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGVHNHVjMlZ1WkdWeUlEMDlQU0J6Wlc1a1pYSXNJR1Z5Y2tsdWRtRnNhV1JRWVhsdFpXNTBVMlZ1WkdWeUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJoYzNObGNuUlRZV1psUVhOelpYUlVjbUZ1YzJabGNsOWhablJsY2w5aGMzTmxjblJBTWdvZ0lDQWdZbmwwWldNZ05pQXZMeUFpUlZKU09tVnlja2x3YlhNaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYQnRjd29LWVhOelpYSjBVMkZtWlVGemMyVjBWSEpoYm5ObVpYSmZZV1owWlhKZllYTnpaWEowUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pFM09Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFI0Ymk1aGMzTmxkRk5sYm1SbGNpQTlQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TENCbGNuSkRiR0YzWW1GamEwWnZjbUpwWkdSbGJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdRWE56WlhSVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCaGMzTmxjblJUWVdabFFYTnpaWFJVY21GdWMyWmxjbDloWm5SbGNsOWhjM05sY25SQU5Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VG1Oc2R5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9ZMngzQ2dwaGMzTmxjblJUWVdabFFYTnpaWFJVY21GdWMyWmxjbDloWm5SbGNsOWhjM05sY25SQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1UYzVDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEhodUxtRnpjMlYwUTJ4dmMyVlVieUE5UFQwZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxDQmxjbkpEYkc5elpVWnZjbUpwWkdSbGJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdRWE56WlhSRGJHOXpaVlJ2Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1lYTnpaWEowVTJGbVpVRnpjMlYwVkhKaGJuTm1aWEpmWVdaMFpYSmZZWE56WlhKMFFEWUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lrVlNVanBsY25KT1kyeHpJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazVqYkhNS0NtRnpjMlZ5ZEZOaFptVkJjM05sZEZSeVlXNXpabVZ5WDJGbWRHVnlYMkZ6YzJWeWRFQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3hPREFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGVHNHVjbVZyWlhsVWJ5QTlQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TENCbGNuSlNaV3RsZVVadmNtSnBaR1JsYmlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaM1I0Ym5NZ1VtVnJaWGxVYndvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWW01NklHRnpjMlZ5ZEZOaFptVkJjM05sZEZSeVlXNXpabVZ5WDJGbWRHVnlYMkZ6YzJWeWRFQTRDaUFnSUNCaWVYUmxZMTh5SUM4dklDSkZVbEk2WlhKeVRuSnJlU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpPY210NUNncGhjM05sY25SVFlXWmxRWE56WlhSVWNtRnVjMlpsY2w5aFpuUmxjbDloYzNObGNuUkFPRG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclUyaGhjbVZrU0dWc2NHVnljeTVqYUdWamExQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGphR1ZqYTFCaGVXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnWTJobFkydFFZWGx0Wlc1MEtIQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z2MyVnVaR1Z5T2lCQlkyTnZkVzUwTENCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZEN3Z1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TVRZMkNpQWdJQ0F2THlCaGMzTmxjblJUWVdabFVHRjViV1Z1ZENoMGVHNHNJSE5sYm1SbGNpa0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdZWE56WlhKMFUyRm1aVkJoZVcxbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1UWTNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEhodUxuSmxZMlZwZG1WeUlEMDlQU0J5WldObGFYWmxjaXdnWlhKeVNXNTJZV3hwWkZCaGVXMWxiblJTWldObGFYWmxjaWtLSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR05vWldOclVHRjViV1Z1ZEY5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV01nTkNBdkx5QWlSVkpTT21WeWNrbHdiWElpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5U1hCdGNnb0tZMmhsWTJ0UVlYbHRaVzUwWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3hOamdLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGVHNHVZVzF2ZFc1MElEMDlQU0JoYlc5MWJuUXNJR1Z5Y2tsdWRtRnNhV1JRWVhsdFpXNTBRVzF2ZFc1MEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdOb1pXTnJVR0Y1YldWdWRGOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpUlZKU09tVnlja2x3YldFaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYQnRZUW9LWTJobFkydFFZWGx0Wlc1MFgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzTm9ZWEpsWkMxb1pXeHdaWEp6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUdOb1pXTnJVR0Y1YldWdWRDaHdZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lITmxibVJsY2pvZ1FXTmpiM1Z1ZEN3Z2NtVmpaV2wyWlhJNklFRmpZMjkxYm5Rc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNOb1lYSmxaQzFvWld4d1pYSnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazF2WTJ0VGFHRnlaV1JJWld4d1pYSnpMbU5vWldOclUyRm1aVkJoZVcxbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYUdWamExTmhabVZRWVhsdFpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNOb1lYSmxaQzFvWld4d1pYSnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR05vWldOclUyRm1aVkJoZVcxbGJuUW9jR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxDQnpaVzVrWlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YzJoaGNtVmtMV2hsYkhCbGNuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZWE56WlhKMFUyRm1aVkJoZVcxbGJuUW9jR0Y1YldWdWRDd2djMlZ1WkdWeUtRb2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUlRZV1psVUdGNWJXVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNOb1lYSmxaQzFvWld4d1pYSnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR05vWldOclUyRm1aVkJoZVcxbGJuUW9jR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxDQnpaVzVrWlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amExTm9ZWEpsWkVobGJIQmxjbk11WTJobFkydFFiR0ZwYmxCaGVXMWxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamFHVmphMUJzWVdsdVVHRjViV1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXphR0Z5WldRdGFHVnNjR1Z5Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCamFHVmphMUJzWVdsdVVHRjViV1Z1ZENod1lYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM05vWVhKbFpDMW9aV3h3WlhKekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHRnpjMlZ5ZEZCc1lXbHVVR0Y1YldWdWRDaHdZWGx0Wlc1MEtRb2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUlFiR0ZwYmxCaGVXMWxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJqYUdWamExQnNZV2x1VUdGNWJXVnVkQ2h3WVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjMmhoY21Wa0xXaGxiSEJsY25NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXOWphMU5vWVhKbFpFaGxiSEJsY25NdVkyaGxZMnRGZUdGamRGQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGphR1ZqYTBWNFlXTjBVR0Y1YldWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl6YUdGeVpXUXRhR1ZzY0dWeWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QmphR1ZqYTBWNFlXTjBVR0Y1YldWdWRDaHdZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MExDQmhiVzkxYm5RNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJoYzNObGNuUkZlR0ZqZEZCaGVXMWxiblFvY0dGNWJXVnVkQ3dnY21WalpXbDJaWElzSUdGdGIzVnVkQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYTnpaWEowUlhoaFkzUlFZWGx0Wlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjMmhoY21Wa0xXaGxiSEJsY25NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z1kyaGxZMnRGZUdGamRGQmhlVzFsYm5Rb2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZEN3Z1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YzJoaGNtVmtMV2hsYkhCbGNuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTFOb1lYSmxaRWhsYkhCbGNuTXVhRzlzWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtaHZiR1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnYUc5c1pDaHdZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lISmxZMjl5WkRvZ1lubDBaWE1zSUdGdGIzVnVkRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNOb1lYSmxaQzFvWld4d1pYSnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR0Z6YzJWeWRFVjRZV04wVUdGNWJXVnVkQ2h3WVhsdFpXNTBMQ0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dZVzF2ZFc1MElDc2djM0J2Ym5OdmNrTnZjM1FvY0dGNWJXVnVkQzV6Wlc1a1pYSXNJRlI0Ymk1elpXNWtaWElwS1FvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCd1lYbGxjaUE5UFQwZ2IzZHVaWElnUHlBd0lEb2dVR0Y1WlhKU1pXTnZjbVJOUWxJS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzTm9ZWEpsWkMxb1pXeHdaWEp6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdGemMyVnlkRVY0WVdOMFVHRjViV1Z1ZENod1lYbHRaVzUwTENCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnWVcxdmRXNTBJQ3NnYzNCdmJuTnZja052YzNRb2NHRjViV1Z1ZEM1elpXNWtaWElzSUZSNGJpNXpaVzVrWlhJcEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TURFS0lDQWdJQzh2SUhKbGRIVnliaUJ3WVhsbGNpQTlQVDBnYjNkdVpYSWdQeUF3SURvZ1VHRjVaWEpTWldOdmNtUk5RbElLSUNBZ0lEMDlDaUFnSUNCcGJuUmpJRFFnTHk4Z01qZzFNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM05vWVhKbFpDMW9aV3h3WlhKekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHRnpjMlZ5ZEVWNFlXTjBVR0Y1YldWdWRDaHdZWGx0Wlc1MExDQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3Z1lXMXZkVzUwSUNzZ2MzQnZibk52Y2tOdmMzUW9jR0Y1YldWdWRDNXpaVzVrWlhJc0lGUjRiaTV6Wlc1a1pYSXBLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUdGemMyVnlkRVY0WVdOMFVHRjViV1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzTm9ZWEpsWkMxb1pXeHdaWEp6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUhKbFkyOXlaRkJoZVdWeUtISmxZMjl5WkN3Z2NHRjViV1Z1ZEM1elpXNWtaWElzSUZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakV3TmdvZ0lDQWdMeThnYVdZZ0tIQmhlV1Z5SUNFOVBTQnZkMjVsY2lrZ2V3b2dJQ0FnSVQwS0lDQWdJR0o2SUdodmJHUmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prMkNpQWdJQ0F2THlCeVpYUjFjbTRnUW5sMFpYTW9VR0Y1WlhKQ2IzaFFjbVZtYVhncExtTnZibU5oZENoemFHRXlOVFlvY21WamIzSmtLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1UQTNDaUFnSUNBdkx5QnZjQzVDYjNndWNIVjBLSEJoZVdWeVVtVmpiM0prUzJWNUtISmxZMjl5WkNrc0lIQmhlV1Z5TG1KNWRHVnpLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0NtaHZiR1JmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNOb1lYSmxaQzFvWld4d1pYSnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR2h2YkdRb2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCeVpXTnZjbVE2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXphR0Z5WldRdGFHVnNjR1Z5Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTmIyTnJVMmhoY21Wa1NHVnNjR1Z5Y3k1b1pXeGtRbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwb1pXeGtRbms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnYUdWc1pFSjVLSEpsWTI5eVpEb2dZbmwwWlhNc0lHOTNibVZ5T2lCQlkyTnZkVzUwS1RvZ1FXTmpiM1Z1ZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVOZ29nSUNBZ0x5OGdjbVYwZFhKdUlFSjVkR1Z6S0ZCaGVXVnlRbTk0VUhKbFptbDRLUzVqYjI1allYUW9jMmhoTWpVMktISmxZMjl5WkNrcENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lpUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVEV6Q2lBZ0lDQXZMeUJqYjI1emRDQmJjR0Y1WlhJc0lITndiMjV6YjNKbFpGMGdQU0J2Y0M1Q2IzZ3VaMlYwS0hCaGVXVnlVbVZqYjNKa1MyVjVLSEpsWTI5eVpDa3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakV4TkFvZ0lDQWdMeThnY21WMGRYSnVJSE53YjI1emIzSmxaQ0EvSUVGalkyOTFiblFvY0dGNVpYSXBJRG9nYjNkdVpYSUtJQ0FnSUdKNklHaGxiR1JDZVY5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lHSjFjbmtnTVFvS2FHVnNaRUo1WDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJvWld4a1Fua29jbVZqYjNKa09pQmllWFJsY3l3Z2IzZHVaWEk2SUVGalkyOTFiblFwT2lCQlkyTnZkVzUwSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtaGxiR1JDZVY5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQndiM0FLSUNBZ0lHSWdhR1ZzWkVKNVgzUmxjbTVoY25sZmJXVnlaMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclUyaGhjbVZrU0dWc2NHVnljeTV5Wld4bFlYTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21Wc1pXRnpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJ5Wld4bFlYTmxLSEpsWTI5eVpEb2dZbmwwWlhNc0lHOTNibVZ5T2lCQlkyTnZkVzUwTENCaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUVGalkyOTFiblFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQkNlWFJsY3loUVlYbGxja0p2ZUZCeVpXWnBlQ2t1WTI5dVkyRjBLSE5vWVRJMU5paHlaV052Y21RcEtRb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSWtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVFF5Q2lBZ0lDQXZMeUJqYjI1emRDQmJjR0Y1WlhJc0lITndiMjV6YjNKbFpGMGdQU0J2Y0M1Q2IzZ3VaMlYwS0d0bGVTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TVRRekNpQWdJQ0F2THlCcFppQW9JWE53YjI1emIzSmxaQ2tnZXdvZ0lDQWdZbTU2SUhKbGJHVmhjMlZmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCd2IzQnVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVFEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMjkzYm1WeUxDQmhiVzkxYm5SZENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtDbkpsYkdWaGMyVmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pweVpXeGxZWE5sUkdWd2IzTnBkRUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXphR0Z5WldRdGFHVnNjR1Z5Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCamIyNXpkQ0JiY21WalpXbDJaWElzSUhSdmRHRnNYU0E5SUhKbGJHVmhjMlZFWlhCdmMybDBLSEpsWTI5eVpDd2diM2R1WlhJc0lHRnRiM1Z1ZENrS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc2djbVZqWldsMlpYSXNJR0Z0YjNWdWREb2dkRzkwWVd3Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjMmhoY21Wa0xXaGxiSEJsY25NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z2NtVnNaV0Z6WlNoeVpXTnZjbVE2SUdKNWRHVnpMQ0J2ZDI1bGNqb2dRV05qYjNWdWRDd2dZVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQkJZMk52ZFc1MElIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsYkdWaGMyVmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE5EWUtJQ0FnSUM4dklHOXdMa0p2ZUM1a1pXeGxkR1VvYTJWNUtRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qRTBOd29nSUNBZ0x5OGdZMjl1YzNRZ2RHOTBZV3c2SUhWcGJuUTJOQ0E5SUdGdGIzVnVkQ0FySUZCaGVXVnlVbVZqYjNKa1RVSlNDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpJRFFnTHk4Z01qZzFNREFLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1UTXdDaUFnSUNBdkx5QmpiMjV6ZENCYkxDQm1kVzVrWldSZElEMGdiM0F1UVdOamRGQmhjbUZ0Y3k1aFkyTjBRbUZzWVc1alpTaHlaV05sYVhabGNpa0tJQ0FnSUdScFp5QXhDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFSmhiR0Z1WTJVS0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE16RUtJQ0FnSUM4dklISmxkSFZ5YmlCbWRXNWtaV1FnZkh3Z1lXMXZkVzUwSUQ0OUlFZHNiMkpoYkM1dGFXNUNZV3hoYm1ObENpQWdJQ0JpYm5vZ2NtVnNaV0Z6WlY5aWIyOXNYM1J5ZFdWQU5Rb2dJQ0FnWkhWd0NpQWdJQ0JuYkc5aVlXd2dUV2x1UW1Gc1lXNWpaUW9nSUNBZ1BqMEtJQ0FnSUdKNklISmxiR1ZoYzJWZlltOXZiRjltWVd4elpVQTJDZ3B5Wld4bFlYTmxYMkp2YjJ4ZmRISjFaVUExT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ25KbGJHVmhjMlZmWW05dmJGOXRaWEpuWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE5EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCYlkyRnVVbVZqWldsMlpVRnNaMjhvUVdOamIzVnVkQ2h3WVhsbGNpa3NJSFJ2ZEdGc0tTQS9JRUZqWTI5MWJuUW9jR0Y1WlhJcElEb2diM2R1WlhJc0lIUnZkR0ZzWFFvZ0lDQWdZbm9nY21Wc1pXRnpaVjkwWlhKdVlYSjVYMlpoYkhObFFEa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2dweVpXeGxZWE5sWDNSbGNtNWhjbmxmYldWeVoyVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakUwT0FvZ0lDQWdMeThnY21WMGRYSnVJRnRqWVc1U1pXTmxhWFpsUVd4bmJ5aEJZMk52ZFc1MEtIQmhlV1Z5S1N3Z2RHOTBZV3dwSUQ4Z1FXTmpiM1Z1ZENod1lYbGxjaWtnT2lCdmQyNWxjaXdnZEc5MFlXeGRDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJqYjI1emRDQmJjbVZqWldsMlpYSXNJSFJ2ZEdGc1hTQTlJSEpsYkdWaGMyVkVaWEJ2YzJsMEtISmxZMjl5WkN3Z2IzZHVaWElzSUdGdGIzVnVkQ2tLSUNBZ0lHSWdjbVZzWldGelpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02T25KbGJHVmhjMlZFWlhCdmMybDBRREV4Q2dweVpXeGxZWE5sWDNSbGNtNWhjbmxmWm1Gc2MyVkFPVG9LSUNBZ0lHSjFjbmtnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZaUJ5Wld4bFlYTmxYM1JsY201aGNubGZiV1Z5WjJWQU1UQUtDbkpsYkdWaGMyVmZZbTl2YkY5bVlXeHpaVUEyT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdjbVZzWldGelpWOWliMjlzWDIxbGNtZGxRRGNLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YzJoaGNtVmtMV2hsYkhCbGNuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTFOb1lYSmxaRWhsYkhCbGNuTXVZMmhsWTJ0QmMzTmxkRlJ5WVc1elptVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJobFkydEJjM05sZEZSeVlXNXpabVZ5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzTm9ZWEpsWkMxb1pXeHdaWEp6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUdOb1pXTnJRWE56WlhSVWNtRnVjMlpsY2loNFptVnlPaUJuZEhodUxrRnpjMlYwVkhKaGJuTm1aWEpVZUc0c0lITmxibVJsY2pvZ1FXTmpiM1Z1ZEN3Z2NtVmpaV2wyWlhJNklFRmpZMjkxYm5Rc0lHRnpjMlYwT2lCQmMzTmxkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pFNU5Bb2dJQ0FnTHk4Z1lYTnpaWEowVTJGbVpVRnpjMlYwVkhKaGJuTm1aWElvZEhodUxDQnpaVzVrWlhJcENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlZ5ZEZOaFptVkJjM05sZEZSeVlXNXpabVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakU1TlFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUjRiaTVoYzNObGRGSmxZMlZwZG1WeUlEMDlQU0J5WldObGFYWmxjaXdnWlhKeVNXNTJZV3hwWkVGemMyVjBVbVZqWldsMlpYSXBDaUFnSUNCemQyRndDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdOb1pXTnJRWE56WlhSVWNtRnVjMlpsY2w5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2WlhKeVNXRnlaU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpKWVhKbENncGphR1ZqYTBGemMyVjBWSEpoYm5ObVpYSmZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pFNU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFI0Ymk1NFptVnlRWE56WlhRZ1BUMDlJR0Z6YzJWMExDQmxjbkpKYm5aaGJHbGtRWE56WlhRcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdXR1psY2tGemMyVjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWTJobFkydEJjM05sZEZSeVlXNXpabVZ5WDJGbWRHVnlYMkZ6YzJWeWRFQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KSllYTjBJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2xoYzNRS0NtTm9aV05yUVhOelpYUlVjbUZ1YzJabGNsOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TVRrM0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kSGh1TG1GemMyVjBRVzF2ZFc1MElEMDlQU0JoYlc5MWJuUXNJR1Z5Y2tsdWRtRnNhV1JCYzNObGRFRnRiM1Z1ZENrS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNBOVBRb2dJQ0FnWW01NklHTm9aV05yUVhOelpYUlVjbUZ1YzJabGNsOWhablJsY2w5aGMzTmxjblJBTndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlTV0ZoYlNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KSllXRnRDZ3BqYUdWamEwRnpjMlYwVkhKaGJuTm1aWEpmWVdaMFpYSmZZWE56WlhKMFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YzJoaGNtVmtMV2hsYkhCbGNuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdZMmhsWTJ0QmMzTmxkRlJ5WVc1elptVnlLSGhtWlhJNklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUjRiaXdnYzJWdVpHVnlPaUJCWTJOdmRXNTBMQ0J5WldObGFYWmxjam9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMExDQmhiVzkxYm5RNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBOYjJOclUyaGhjbVZrU0dWc2NHVnljeTVqYUdWamExTmhabVZCYzNObGRGUnlZVzV6Wm1WeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMmhsWTJ0VFlXWmxRWE56WlhSVWNtRnVjMlpsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXphR0Z5WldRdGFHVnNjR1Z5Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCamFHVmphMU5oWm1WQmMzTmxkRlJ5WVc1elptVnlLSGhtWlhJNklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUjRiaXdnYzJWdVpHVnlPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUlRZV1psUVhOelpYUlVjbUZ1YzJabGNpaDRabVZ5TENCelpXNWtaWElwQ2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlZ5ZEZOaFptVkJjM05sZEZSeVlXNXpabVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnWTJobFkydFRZV1psUVhOelpYUlVjbUZ1YzJabGNpaDRabVZ5T2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHNJSE5sYm1SbGNqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXphR0Z5WldRdGFHVnNjR1Z5Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTmIyTnJVMmhoY21Wa1NHVnNjR1Z5Y3k1amIyNTBjbTlzYkdWa1UzQmxibVJwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjUwY205c2JHVmtVM0JsYm1ScGJtYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YzJoaGNtVmtMV2hsYkhCbGNuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdZMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5LSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRwT2lCQlkyTnZkVzUwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EazVDaUFnSUNBdkx5QkNlWFJsY3loQlluTjBjbUZqZEVGalkyOTFiblJIYkc5aVlXeFRkR0YwWlV0bGVYTlRjR1Z1WkdsdVowRmtaSEpsYzNNcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5Od1pXNWthVzVuWDJGa1pISmxjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalE1TnkwMU1EQUtJQ0FnSUM4dklHTnZibk4wSUZ0emNHVnVaR2x1WjBGa1pISmxjM05DZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5Z0tJQ0FnSUM4dklDQWdkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQkNlWFJsY3loQlluTjBjbUZqZEVGalkyOTFiblJIYkc5aVlXeFRkR0YwWlV0bGVYTlRjR1Z1WkdsdVowRmtaSEpsYzNNcENpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5URXlDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYzJWdVpHVnlMbUYxZEdoQlpHUnlaWE56SUQwOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3Z1pYSnlVR3gxWjJsdVRtOTBRWFYwYUVGa1pISXBDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFRjFkR2hCWkdSeUNpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWW01NklHTnZiblJ5YjJ4c1pXUlRjR1Z1WkdsdVoxOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlUbUYwYUNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KT1lYUm9DZ3BqYjI1MGNtOXNiR1ZrVTNCbGJtUnBibWRmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YzJoaGNtVmtMV2hsYkhCbGNuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdZMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5LSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRwT2lCQlkyTnZkVzUwSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amExTm9ZWEpsWkVobGJIQmxjbk11WlhoMGNtRlFZV2RsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtVjRkSEpoVUdGblpYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YzJoaGNtVmtMV2hsYkhCbGNuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdaWGgwY21GUVlXZGxjeWhoY0hCeWIzWmhiRk5wZW1VNklIVnBiblEyTkN3Z1kyeGxZWEpUYVhwbE9pQjFhVzUwTmpRc0lHMXBia1Y0ZEhKaFVHRm5aWE02SUhWcGJuUTJOQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEp2WjNKaGJYTXVkSE02TXpJS0lDQWdJQzh2SUdOdmJuTjBJSEJoWjJWek9pQjFhVzUwTmpRZ1BTQW9ZWEJ3Y205MllXeFRhWHBsSUNzZ1kyeGxZWEpUYVhwbElDc2dVRkpQUjFKQlRWOVFRVWRGWDFOSldrVWdMU0F4S1NBdklGQlNUMGRTUVUxZlVFRkhSVjlUU1ZwRkNpQWdJQ0FyQ2lBZ0lDQndkWE5vYVc1MElESXdORGdLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQndkWE5vYVc1MElESXdORGdLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YjJkeVlXMXpMblJ6T2pNekNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9jR0ZuWlhNZ1BEMGdUVUZZWDFCU1QwZFNRVTFmVkU5VVFVeGZVRUZIUlZNc0lHVnljbEJ5YjJkeVlXMVViMjlNWVhKblpTa0tJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E4UFFvZ0lDQWdZbTU2SUdWNGRISmhVR0ZuWlhOZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNsQjBiR2NpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VUhSc1p3b0taWGgwY21GUVlXZGxjMTloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y205bmNtRnRjeTUwY3pvME13b2dJQ0FnTHk4Z1kyOXVjM1FnWlhoMGNtRTZJSFZwYm5RMk5DQTlJSEJoWjJWeklENGdNQ0EvSUhCaFoyVnpJQzBnTVNBNklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5vZ1pYaDBjbUZRWVdkbGMxOTBaWEp1WVhKNVgyWmhiSE5sUURVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDZ3BsZUhSeVlWQmhaMlZ6WDNSbGNtNWhjbmxmYldWeVoyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtOW5jbUZ0Y3k1MGN6bzBOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHVjRkSEpoSUQ0Z2JXbHVSWGgwY21GUVlXZGxjeUEvSUdWNGRISmhJRG9nYldsdVJYaDBjbUZRWVdkbGN3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdQZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjMmhoY21Wa0xXaGxiSEJsY25NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z1pYaDBjbUZRWVdkbGN5aGhjSEJ5YjNaaGJGTnBlbVU2SUhWcGJuUTJOQ3dnWTJ4bFlYSlRhWHBsT2lCMWFXNTBOalFzSUcxcGJrVjRkSEpoVUdGblpYTTZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BsZUhSeVlWQmhaMlZ6WDNSbGNtNWhjbmxmWm1Gc2MyVkFOVG9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWIyZHlZVzF6TG5Sek9qUXpDaUFnSUNBdkx5QmpiMjV6ZENCbGVIUnlZVG9nZFdsdWREWTBJRDBnY0dGblpYTWdQaUF3SUQ4Z2NHRm5aWE1nTFNBeElEb2dNQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ1pYaDBjbUZRWVdkbGMxOTBaWEp1WVhKNVgyMWxjbWRsUURZS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amExTm9ZWEpsWkVobGJIQmxjbk11YzNCaGQyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6Y0dGM2Jqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl6YUdGeVpXUXRhR1ZzY0dWeWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QnpjR0YzYmlobWRXNWthVzVuT2lCMWFXNTBOalFwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM05vWVhKbFpDMW9aV3h3WlhKekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56a0tJQ0FnSUM4dklHTnZibk4wSUdOb2FXeGtJRDBnWTI5dGNHbHNaVUZ5WXpRb1RXOWphMUpsWVhCaFlteGxRMmhwYkdRcExtSmhjbVZEY21WaGRHVW9LUzVqY21WaGRHVmtRWEJ3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVFkwS0VNMFJVSlJkejA5S1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYkdWaGNsTjBZWFJsVUhKdlozSmhiVkJoWjJWekNpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUWTBLRU42UldKUlVVRmhaMEZTWVZCMmJsQk9hRzlCYW1kRlFVRlJRWGhIV1VWR1JXcEZXVVZGVWtOQlFXZDRSMUpSZUVkQ1VWRlJOMFY1UTJKSlNtZFJSM2xGU1VWQmMyZEhlbWRSUmtRcENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZjMmhoY21Wa0xXaGxiSEJsY25NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z2FYUjRiaTV3WVhsdFpXNTBLSHNnY21WalpXbDJaWEk2SUdOb2FXeGtMbUZrWkhKbGMzTXNJR0Z0YjNWdWREb2dablZ1WkdsdVp5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkhWd0NpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwzTm9ZWEpsWkMxb1pXeHdaWEp6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhOd1lYZHVLR1oxYm1ScGJtYzZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMM05vWVhKbFpDMW9aV3h3WlhKekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnRUYUdGeVpXUklaV3h3WlhKekxuSmxZWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXRndPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDNOb1lYSmxaQzFvWld4d1pYSnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJSEpsWVhBb1kyaHBiR1E2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV052Y21SbFpEb2dkV2x1ZERZMExDQnlaV05sYVhabGNqb2dRV05qYjNWdWRDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl6YUdGeVpXUXRhR1ZzY0dWeWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QmpiMjV6ZENCaVlXeGhibU5sUW1WbWIzSmxJRDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXVZbUZzWVc1alpRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFtRnNZVzVqWlFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJqYjI1emRDQnRhVzVDWldadmNtVWdQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5NXRhVzVDWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXphR0Z5WldRdGFHVnNjR1Z5Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCamIyMXdhV3hsUVhKak5DaE5iMk5yVW1WaGNHRmliR1ZEYUdsc1pDa3VZMkZzYkM1eVpXRndLSHNnWVhCd1NXUTZJR05vYVd4a0lIMHBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURWaE0yVm1PV05tSUM4dklHMWxkR2h2WkNBaWNtVmhjQ2dwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMlpoWTNSdmNua3VkSE02TkRnS0lDQWdJQzh2SUdOdmJuTjBJSE5sYkdZZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwyWmhZM1J2Y25rdWRITTZORGtLSUNBZ0lDOHZJR052Ym5OMElHZHliM056T2lCMWFXNTBOalFnUFNCelpXeG1MbUpoYkdGdVkyVWdLeUJtYjNKM1lYSmtaV1FLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRbUZzWVc1alpRb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5bVlXTjBiM0o1TG5Sek9qVXdDaUFnSUNBdkx5QmpiMjV6ZENCeVpXTmxhWFpsWkRvZ2RXbHVkRFkwSUQwZ1ozSnZjM01nUGlCaVlXeGhibU5sUW1WbWIzSmxJRDhnWjNKdmMzTWdMU0JpWVd4aGJtTmxRbVZtYjNKbElEb2dNQW9nSUNBZ1BBb2dJQ0FnWW5vZ2NtVmhjRjkwWlhKdVlYSjVYMlpoYkhObFFEZ0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdMUW9LY21WaGNGOTBaWEp1WVhKNVgyMWxjbWRsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlptRmpkRzl5ZVM1MGN6bzFNUW9nSUNBZ0x5OGdZMjl1YzNRZ2JXbHVRV1owWlhJNklIVnBiblEyTkNBOUlITmxiR1l1YldsdVFtRnNZVzVqWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZabUZqZEc5eWVTNTBjem8xTWdvZ0lDQWdMeThnWTI5dWMzUWdjbVZzWldGelpXUTZJSFZwYm5RMk5DQTlJRzFwYmtKbFptOXlaU0ErSUcxcGJrRm1kR1Z5SUQ4Z2JXbHVRbVZtYjNKbElDMGdiV2x1UVdaMFpYSWdPaUF3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQQW9nSUNBZ1lub2djbVZoY0Y5MFpYSnVZWEo1WDJaaGJITmxRREV4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0NuSmxZWEJmZEdWeWJtRnllVjl0WlhKblpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTltWVdOMGIzSjVMblJ6T2pVekNpQWdJQ0F2THlCamIyNXpkQ0J5WldaMWJtUTZJSFZwYm5RMk5DQTlJSEpsWTJWcGRtVmtJQ3NnY21Wc1pXRnpaV1FLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OW1ZV04wYjNKNUxuUnpPalUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjbVZtZFc1a0lENGdjbVZqYjNKa1pXUWdQeUJ5WldOdmNtUmxaQ0E2SUhKbFpuVnVaQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1Bnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUJwWmlBb2NtVm1kVzVrSUQ0Z01Da2dld29nSUNBZ1lub2djbVZoY0Y5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5emFHRnlaV1F0YUdWc2NHVnljeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJwZEhodUxuQmhlVzFsYm5Rb2V5QnlaV05sYVhabGNpd2dZVzF2ZFc1ME9pQnlaV1oxYm1RZ2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tjbVZoY0Y5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmMyaGhjbVZrTFdobGJIQmxjbk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnY21WaGNDaGphR2xzWkRvZ1FYQndiR2xqWVhScGIyNHNJSEpsWTI5eVpHVmtPaUIxYVc1ME5qUXNJSEpsWTJWcGRtVnlPaUJCWTJOdmRXNTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbFlYQmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Ub0tJQ0FnSUhCdmNBb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZabUZqZEc5eWVTNTBjem8xTWdvZ0lDQWdMeThnWTI5dWMzUWdjbVZzWldGelpXUTZJSFZwYm5RMk5DQTlJRzFwYmtKbFptOXlaU0ErSUcxcGJrRm1kR1Z5SUQ4Z2JXbHVRbVZtYjNKbElDMGdiV2x1UVdaMFpYSWdPaUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQnlaV0Z3WDNSbGNtNWhjbmxmYldWeVoyVkFNVElLQ25KbFlYQmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE9nb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMlpoWTNSdmNua3VkSE02TlRBS0lDQWdJQzh2SUdOdmJuTjBJSEpsWTJWcGRtVmtPaUIxYVc1ME5qUWdQU0JuY205emN5QStJR0poYkdGdVkyVkNaV1p2Y21VZ1B5Qm5jbTl6Y3lBdElHSmhiR0Z1WTJWQ1pXWnZjbVVnT2lBd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ5WldGd1gzUmxjbTVoY25sZmJXVnlaMlZBT1FvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBUWdBSU5UZUFTWUhCQlVmZkhVTFJWSlNPbVZ5Y2s1amJITUxSVkpTT21WeWNrNXlhM2tCSkF0RlVsSTZaWEp5U1hCdGNndEZVbEk2WlhKeVNYQnRZUXRGVWxJNlpYSnlTWEJ0Y3pFYlFRQnpNUmtVUkRFWVJJSU9CSVZON2VBRTlITy9UQVNET1VrNUJHYklIRWtFcUgwWUxRVGVVdytoQkxUYVN2UUVwaDB5U1FTcHY3aVhCSHY5OUVnRXZEaXU3d1JFTHh5bUJPd0Q4Q0FFTDdRa3FUWWFBSTRPQUFFQXZ3RUVBUnNCS2dGS0FaOEJ6Z0pMQXNzQzR3TWZBM2tEN2dBaVF6RVpGREVZRkJCRGlnRUFpLzg0Q1RJREVrQUFBeW13QUl2L09DQXlBeEpBQUFNcXNBQ0ppZ01BaS8ySS85cUwvVGdIaS80U1FBQUVKd1N3QUl2OU9BaUwveEpBQUFRbkJiQUFpWW9DQUl2K09BQ0wveEpBQUFRbkJyQUFpLzQ0Q1RJREVrQUFBeW13QUl2K09DQXlBeEpBQUFNcXNBQ0ppZ0lBaS80NEFJdi9Fa0FBQkNjR3NBQ0wvamdUTWdNU1FBQVBnQXRGVWxJNlpYSnlUbU5zZDdBQWkvNDRGVElERWtBQUF5bXdBSXYrT0NBeUF4SkFBQU1xc0FDSk1SWWlDVWNDT0JBaUVrUTJHZ0ZKRlNVU1JEWWFBa2tWSlJKRU5ob0RTUlVqRWtRWFRnTkxBazhDaVA5aVREZ0hFa0FBQkNjRXNBQk1PQWdTUUFBRUp3V3dBQ0pETVJZaUNVazRFQ0lTUkRZYUFVa1ZKUkpFaVA4MUlrTXhGaUlKU1RnUUloSkVpUDdqSWtNeEZpSUpTVGdRSWhKRU5ob0JTUlVsRWtRMkdnSkpGU01TUkJlSS91RWlRekVXSWdsSk9CQWlFa1EyR2dGSkpGbUJBZ2hMQVJVU1JGY0NBRXcyR2dKSkZTTVNSQmN5Q2tzQ09BQkpUZ1JKTVFBU0lRUWtUd0pOVHdNSVR3TlBBMDhDaVA2Yk1RQVRRUUFKU3dFQksweFFTd0cvSWtNMkdnRkpKRm1CQWdoTEFSVVNSRmNDQURZYUFrbE9BaFVsRWtRQksweFF2a0VBQ0VVQktFeFFzQ0pEU0VMLzlqWWFBVWtrV1lFQ0NFc0JGUkpFVndJQU5ob0NTVTRDRlNVU1JEWWFBMGtWSXhKRUYwd0JLMHhRU2I1TVRnSkFBQjVHQWhaUVNWY0FJRXdsVzdHeUNFbXlCeUt5RUNTeUFiTW9URkN3SWtPOFNFd2hCQWhMQVhNQVJRRkFBQWRKTWdFUFFRQVVJa0VBQ2s4Q1NFeE1GbEJDLzhKRkFVeEMvL1FrUXYvcE1SWWlDVWNDT0JDQkJCSkVOaG9CU1JVbEVrUTJHZ0pKRlNVU1JEWWFBMGtWSXhKRUYwNEVOaG9FU1JVakVrUVhUZ05MQWs4Q2lQMzJURGdVRWtBQUQ0QUxSVkpTT21WeWNrbGhjbVd3QUVzQk9CRlBBeEpBQUErQUMwVlNVanBsY25KSllYTjBzQUJNT0JJU1FBQVBnQXRGVWxJNlpYSnlTV0ZoYmJBQUlrTXhGaUlKU1RnUWdRUVNSRFlhQVVrVkpSSkVpUDJaSWtNMkdnRkpGU01TUkJlQUVITndaVzVrYVc1blgyRmtaSEpsYzNObFNFbHpBa1F5Q2hKQUFBK0FDMFZTVWpwbGNuSk9ZWFJvc0FBb1RGQ3dJa00yR2dGSkZTTVNSQmMyR2dKSkZTTVNSQmMyR2dOSkZTTVNSQmRPQWdpQmdCQUlJZ21CZ0JBS1NTTU9RQUFQZ0F0RlVsSTZaWEp5VUhSc1o3QUFTVUVBRkNJSlNVOENTVTRDRFV4T0FrMFdLRXhRc0NKRFNDUkMvK2syR2dGSkZTTVNSQmV4Z0FRTGdRRkRza0tBT1FzeEcwRUFHb0FFV2o3NXp6WWFBSTRCQUFFQU1SbUJCUkl4R0JCRVFnQUlNUmtVTVJnVUVFT3hNZ215Q1lFQnNoQ0JBTElCczRFQlE3SkFKTElaZ1FheUVDU3lBYk8wUGJGSmNnaEVUd0t5Q0xJSElySVFKTElCc3hZb1RGQ3dJa00yR2dGSkZTTVNSQmMyR2dKSkZTTVNSQmRNTmhvRFNVNERGU1VTUkRJS2N3Qk1TVTRDVGdORU1ncHpBVXhPQTBTeGdRV3lHVXl5R0lBRVdqNzV6N0lhZ1FheUVDU3lBYk15Q2tsT0FuTUFURWxPQWs0RFJBeEJBRDlQQXdsTWN3Rk1TVThDUkVzRERFRUFKMDhDVEFrSVNVc0NEVXhPQWsxSlFRQVBzVW15Q0VzQnNnY2lzaEFrc2dHekZpaE1VTEFpUTBoRkFTUkMvOVpJVHdKSUpFTC92QT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
