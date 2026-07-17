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

namespace Arc56.Generated.harsh_a_parihar.Hackpay.MultiSigWalletContract_21df8993
{


    //
    // Multi-Signature Wallet Contract
    //Handles multi-signature approvals for large distributions
    //
    public class MultiSigWalletContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MultiSigWalletContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the multi-sig wallet
        ///PRODUCTION READY: Configurable signers with proper validation
        ///</summary>
        /// <param name="signersList"> </param>
        /// <param name="requiredSigs"> </param>
        public async Task Initialize(byte[] signersList, ulong requiredSigs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 165, 102, 205 };
            var signersListAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signersListAbi.From(signersList);
            var requiredSigsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredSigsAbi.From(requiredSigs);

            var result = await base.CallApp(new List<object> { abiHandle, signersListAbi, requiredSigsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(byte[] signersList, ulong requiredSigs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 165, 102, 205 };
            var signersListAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signersListAbi.From(signersList);
            var requiredSigsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredSigsAbi.From(requiredSigs);

            return await base.MakeTransactionList(new List<object> { abiHandle, signersListAbi, requiredSigsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update signers list (governance)
        ///PRODUCTION READY: Allows signers management for governance
        ///</summary>
        /// <param name="newSignersList"> </param>
        public async Task UpdateSigners(byte[] newSignersList, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 199, 29, 243 };
            var newSignersListAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newSignersListAbi.From(newSignersList);

            var result = await base.CallApp(new List<object> { abiHandle, newSignersListAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateSigners_Transactions(byte[] newSignersList, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 199, 29, 243 };
            var newSignersListAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newSignersListAbi.From(newSignersList);

            return await base.MakeTransactionList(new List<object> { abiHandle, newSignersListAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update required signatures (governance)
        ///PRODUCTION READY: Allows threshold updates with validation
        ///</summary>
        /// <param name="newRequiredSigs"> </param>
        public async Task UpdateRequiredSignatures(ulong newRequiredSigs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 81, 60, 239 };
            var newRequiredSigsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newRequiredSigsAbi.From(newRequiredSigs);

            var result = await base.CallApp(new List<object> { abiHandle, newRequiredSigsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRequiredSignatures_Transactions(ulong newRequiredSigs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 81, 60, 239 };
            var newRequiredSigsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newRequiredSigsAbi.From(newRequiredSigs);

            return await base.MakeTransactionList(new List<object> { abiHandle, newRequiredSigsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Propose a transaction
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        public async Task ProposeTransaction(byte[] recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 221, 243, 62 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ProposeTransaction_Transactions(byte[] recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 221, 243, 62 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approve a pending transaction
        ///</summary>
        public async Task ApproveTransaction(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 218, 115, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveTransaction_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 218, 115, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute transaction if enough approvals
        ///</summary>
        public async Task ExecuteTransaction(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 7, 132, 212 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExecuteTransaction_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 7, 132, 212 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if address is authorized signer
        ///PRODUCTION READY: Real validation against signers list
        ///</summary>
        /// <param name="address"> </param>
        public async Task<ulong> IsAuthorizedSigner(byte[] address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 219, 232, 180 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsAuthorizedSigner_Transactions(byte[] address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 219, 232, 180 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get pending transaction info
        ///</summary>
        public async Task<byte[]> GetPendingTransaction(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 204, 182, 131 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetPendingTransaction_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 204, 182, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current approvals count
        ///</summary>
        public async Task<ulong> GetApprovalsCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 67, 59, 25 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetApprovalsCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 67, 59, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get required signatures
        ///</summary>
        public async Task<ulong> GetRequiredSignatures(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 161, 83, 54 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRequiredSignatures_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 161, 83, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get transaction amount
        ///</summary>
        public async Task<ulong> GetTransactionAmount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 199, 37, 49 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTransactionAmount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 199, 37, 49 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Hello method for testing
        ///</summary>
        /// <param name="name"> </param>
        public async Task<byte[]> Hello(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 131, 139, 186 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            var result = await base.SimApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Hello_Transactions(byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 131, 139, 186 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXVsdGlTaWdXYWxsZXRDb250cmFjdCIsImRlc2MiOiJNdWx0aS1TaWduYXR1cmUgV2FsbGV0IENvbnRyYWN0XG5IYW5kbGVzIG11bHRpLXNpZ25hdHVyZSBhcHByb3ZhbHMgZm9yIGxhcmdlIGRpc3RyaWJ1dGlvbnMiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBtdWx0aS1zaWcgd2FsbGV0XG5QUk9EVUNUSU9OIFJFQURZOiBDb25maWd1cmFibGUgc2lnbmVycyB3aXRoIHByb3BlciB2YWxpZGF0aW9uIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25lcnNMaXN0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1aXJlZFNpZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlU2lnbmVycyIsImRlc2MiOiJVcGRhdGUgc2lnbmVycyBsaXN0IChnb3Zlcm5hbmNlKVxuUFJPRFVDVElPTiBSRUFEWTogQWxsb3dzIHNpZ25lcnMgbWFuYWdlbWVudCBmb3IgZ292ZXJuYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdTaWduZXJzTGlzdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVSZXF1aXJlZFNpZ25hdHVyZXMiLCJkZXNjIjoiVXBkYXRlIHJlcXVpcmVkIHNpZ25hdHVyZXMgKGdvdmVybmFuY2UpXG5QUk9EVUNUSU9OIFJFQURZOiBBbGxvd3MgdGhyZXNob2xkIHVwZGF0ZXMgd2l0aCB2YWxpZGF0aW9uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1JlcXVpcmVkU2lncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NlVHJhbnNhY3Rpb24iLCJkZXNjIjoiUHJvcG9zZSBhIHRyYW5zYWN0aW9uIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmVUcmFuc2FjdGlvbiIsImRlc2MiOiJBcHByb3ZlIGEgcGVuZGluZyB0cmFuc2FjdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleGVjdXRlVHJhbnNhY3Rpb24iLCJkZXNjIjoiRXhlY3V0ZSB0cmFuc2FjdGlvbiBpZiBlbm91Z2ggYXBwcm92YWxzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzQXV0aG9yaXplZFNpZ25lciIsImRlc2MiOiJDaGVjayBpZiBhZGRyZXNzIGlzIGF1dGhvcml6ZWQgc2lnbmVyXG5QUk9EVUNUSU9OIFJFQURZOiBSZWFsIHZhbGlkYXRpb24gYWdhaW5zdCBzaWduZXJzIGxpc3QiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UGVuZGluZ1RyYW5zYWN0aW9uIiwiZGVzYyI6IkdldCBwZW5kaW5nIHRyYW5zYWN0aW9uIGluZm8iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFwcHJvdmFsc0NvdW50IiwiZGVzYyI6IkdldCBjdXJyZW50IGFwcHJvdmFscyBjb3VudCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVxdWlyZWRTaWduYXR1cmVzIiwiZGVzYyI6IkdldCByZXF1aXJlZCBzaWduYXR1cmVzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUcmFuc2FjdGlvbkFtb3VudCIsImRlc2MiOiJHZXQgdHJhbnNhY3Rpb24gYW1vdW50IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoZWxsbyIsImRlc2MiOiJIZWxsbyBtZXRob2QgZm9yIHRlc3RpbmciLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NzddLCJlcnJvck1lc3NhZ2UiOiJOZXcgc2lnbmVycyBsaXN0IGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2Ml0sImVycm9yTWVzc2FnZSI6Ik5vIHBlbmRpbmcgdHJhbnNhY3Rpb24gdG8gYXBwcm92ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5NV0sImVycm9yTWVzc2FnZSI6Ik5vIHBlbmRpbmcgdHJhbnNhY3Rpb24gdG8gZXhlY3V0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OF0sImVycm9yTWVzc2FnZSI6Ik5vdCBlbm91Z2ggYXBwcm92YWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4LDIxNSwyMzIsMjQ5LDI2NiwyOTAsMzEzLDMyNSwzMzcsMzU5LDM3NSwzOTNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGF1dGhvcml6ZWQgc2lnbmVycyBjYW4gYXBwcm92ZSB0cmFuc2FjdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzhdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGF1dGhvcml6ZWQgc2lnbmVycyBjYW4gZXhlY3V0ZSB0cmFuc2FjdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGF1dGhvcml6ZWQgc2lnbmVycyBjYW4gcHJvcG9zZSB0cmFuc2FjdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGF1dGhvcml6ZWQgc2lnbmVycyBjYW4gdXBkYXRlIHNpZ25lcnMgbGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Ml0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYXV0aG9yaXplZCBzaWduZXJzIGNhbiB1cGRhdGUgdGhyZXNob2xkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEzXSwiZXJyb3JNZXNzYWdlIjoiUmVjaXBpZW50IGFkZHJlc3MgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMyLDQ5NV0sImVycm9yTWVzc2FnZSI6IlJlcXVpcmVkIHNpZ25hdHVyZXMgbXVzdCBiZSBncmVhdGVyIHRoYW4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyOV0sImVycm9yTWVzc2FnZSI6IlNpZ25lcnMgbGlzdCBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTZdLCJlcnJvck1lc3NhZ2UiOiJUcmFuc2FjdGlvbiBhbW91bnQgbXVzdCBiZSBncmVhdGVyIHRoYW4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MSwyMTgsMjM1LDI1MiwyNjksMjkzLDMxNiwzMjgsMzQwLDM2MiwzNzgsMzk2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MCw1NjYsNTgyLDU4Niw1OTMsNjMwLDY2Myw2NjgsNjczLDY3OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmhjSEJ5YjNaaGJITWlJREI0TVRVeFpqZGpOelVnSW5KbGNYVnBjbVZrVTJsbmJtRjBkWEpsY3lJZ0luUnlZVzV6WVdOMGFXOXVRVzF2ZFc1MElpQWljMmxuYm1WeWN5SWdJbkJsYm1ScGJtZFVjbUZ1YzJGamRHbHZiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFoxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUWFZzZEdsVGFXZFhZV3hzWlhSRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE53b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEUXhZVFUyTm1Oa0lEQjRaalJqTnpGa1pqTWdNSGhpTkRVeE0yTmxaaUF3ZURGaVpHUm1Nek5sSURCNFlXVmtZVGN6WVRjZ01IaGpaVEEzT0RSa05DQXdlR0k0WkdKbE9HSTBJREI0T1RKalkySTJPRE1nTUhnM01UUXpNMkl4T1NBd2VEZzNZVEUxTXpNMklEQjROemRqTnpJMU16RWdNSGhsTURnek9HSmlZU0F2THlCdFpYUm9iMlFnSW1sdWFYUnBZV3hwZW1Vb1lubDBaVnRkTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWVGFXZHVaWEp6S0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWU1pYRjFhWEpsWkZOcFoyNWhkSFZ5WlhNb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkJ5YjNCdmMyVlVjbUZ1YzJGamRHbHZiaWhpZVhSbFcxMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVZVY21GdWMyRmpkR2x2YmlncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWlhobFkzVjBaVlJ5WVc1ellXTjBhVzl1S0NsMmIybGtJaXdnYldWMGFHOWtJQ0pwYzBGMWRHaHZjbWw2WldSVGFXZHVaWElvWW5sMFpWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwVUdWdVpHbHVaMVJ5WVc1ellXTjBhVzl1S0NsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW1kbGRFRndjSEp2ZG1Gc2MwTnZkVzUwS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGSmxjWFZwY21Wa1UybG5ibUYwZFhKbGN5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJVY21GdWMyRmpkR2x2YmtGdGIzVnVkQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pvWld4c2J5aGllWFJsVzEwcFlubDBaVnRkSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlwYm1sMGFXRnNhWHBsWDNKdmRYUmxRRE1nYldGcGJsOTFjR1JoZEdWVGFXZHVaWEp6WDNKdmRYUmxRRFFnYldGcGJsOTFjR1JoZEdWU1pYRjFhWEpsWkZOcFoyNWhkSFZ5WlhOZmNtOTFkR1ZBTlNCdFlXbHVYM0J5YjNCdmMyVlVjbUZ1YzJGamRHbHZibDl5YjNWMFpVQTJJRzFoYVc1ZllYQndjbTkyWlZSeVlXNXpZV04wYVc5dVgzSnZkWFJsUURjZ2JXRnBibDlsZUdWamRYUmxWSEpoYm5OaFkzUnBiMjVmY205MWRHVkFPQ0J0WVdsdVgybHpRWFYwYUc5eWFYcGxaRk5wWjI1bGNsOXliM1YwWlVBNUlHMWhhVzVmWjJWMFVHVnVaR2x1WjFSeVlXNXpZV04wYVc5dVgzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFFYQndjbTkyWVd4elEyOTFiblJmY205MWRHVkFNVEVnYldGcGJsOW5aWFJTWlhGMWFYSmxaRk5wWjI1aGRIVnlaWE5mY205MWRHVkFNVElnYldGcGJsOW5aWFJVY21GdWMyRmpkR2x2YmtGdGIzVnVkRjl5YjNWMFpVQXhNeUJ0WVdsdVgyaGxiR3h2WDNKdmRYUmxRREUwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMTFiSFJwVTJsblYyRnNiR1YwUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk5kV3gwYVZOcFoxZGhiR3hsZEVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFoxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVWNtRnVjMkZqZEdsdmJrRnRiM1Z1ZEY5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZISmhibk5oWTNScGIyNUJiVzkxYm5RS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFVtVnhkV2x5WldSVGFXZHVZWFIxY21WelgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUlNaWEYxYVhKbFpGTnBaMjVoZEhWeVpYTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRWEJ3Y205MllXeHpRMjkxYm5SZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRFRndjSEp2ZG1Gc2MwTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZCbGJtUnBibWRVY21GdWMyRmpkR2x2Ymw5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFVHVnVaR2x1WjFSeVlXNXpZV04wYVc5dUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYzBGMWRHaHZjbWw2WldSVGFXZHVaWEpmY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFoxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVFhWc2RHbFRhV2RYWVd4c1pYUkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1kyRnNiSE4xWWlCcGMwRjFkR2h2Y21sNlpXUlRhV2R1WlhJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWlhobFkzVjBaVlJ5WVc1ellXTjBhVzl1WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR1Y0WldOMWRHVlVjbUZ1YzJGamRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjSEJ5YjNabFZISmhibk5oWTNScGIyNWZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCaGNIQnliM1psVkhKaGJuTmhZM1JwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY0hKdmNHOXpaVlJ5WVc1ellXTjBhVzl1WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVFhWc2RHbFRhV2RYWVd4c1pYUkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhCeWIzQnZjMlZVY21GdWMyRmpkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxY0dSaGRHVlNaWEYxYVhKbFpGTnBaMjVoZEhWeVpYTmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk5kV3gwYVZOcFoxZGhiR3hsZEVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVlNaWEYxYVhKbFpGTnBaMjVoZEhWeVpYTUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsVTJsbmJtVnljMTl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTExYkhScFUybG5WMkZzYkdWMFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVlRhV2R1WlhKekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJsdWFYUnBZV3hwZW1WZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmRXeDBhVk5wWjFkaGJHeGxkRU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2FXNXBkR2xoYkdsNlpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTExYkhScFUybG5WMkZzYkdWMFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl4Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFhWc2RHbFRhV2RYWVd4c1pYUkRiMjUwY21GamRDNXBibWwwYVdGc2FYcGxLSE5wWjI1bGNuTk1hWE4wT2lCaWVYUmxjeXdnY21WeGRXbHlaV1JUYVdkek9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtbHVhWFJwWVd4cGVtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJdE1qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCcGJtbDBhV0ZzYVhwbEtBb2dJQ0FnTHk4Z0lDQnphV2R1WlhKelRHbHpkRG9nWW5sMFpYTXNDaUFnSUNBdkx5QWdJSEpsY1hWcGNtVmtVMmxuY3pvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9jMmxuYm1WeWMweHBjM1F1YkdWdVozUm9JRDRnTUN3Z0oxTnBaMjVsY25NZ2JHbHpkQ0JqWVc1dWIzUWdZbVVnWlcxd2RIa25LVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1UybG5ibVZ5Y3lCc2FYTjBJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJoYzNObGNuUW9jbVZ4ZFdseVpXUlRhV2R6SUQ0Z01Dd2dKMUpsY1hWcGNtVmtJSE5wWjI1aGRIVnlaWE1nYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1VtVnhkV2x5WldRZ2MybG5ibUYwZFhKbGN5QnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklITnBaMjVsY25NZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNnTHk4Z1NHRnphQ0J2WmlCemFXZHVaWEp6SUd4cGMzUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTnBaMjVsY25NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSFJvYVhNdWMybG5ibVZ5Y3k1MllXeDFaU0E5SUhOcFoyNWxjbk5NYVhOME93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJ5WlhGMWFYSmxaRk5wWjI1aGRIVnlaWE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnlaWEYxYVhKbFpGTnBaMjVoZEhWeVpYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhSb2FYTXVjbVZ4ZFdseVpXUlRhV2R1WVhSMWNtVnpMblpoYkhWbElEMGdjbVZ4ZFdseVpXUlRhV2R6T3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QjBiM1JoYkZOcFoyNWxjbk1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luUnZkR0ZzVTJsbmJtVnljeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFoxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTnBaMjVsY25NdWRtRnNkV1VnUFNBd095QXZMeUJYYVd4c0lHSmxJR05oYkdOMWJHRjBaV1FnWm5KdmJTQnphV2R1WlhKeklHeHBjM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCaGNIQnliM1poYkhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklFNTFiV0psY2lCdlppQmhjSEJ5YjNaaGJITWdjbVZqWldsMlpXUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRndjSEp2ZG1Gc2N5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnZEdocGN5NWhjSEJ5YjNaaGJITXVkbUZzZFdVZ1BTQXdPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUhSeVlXNXpZV04wYVc5dVFXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ1lubDBaV05mTXlBdkx5QWlkSEpoYm5OaFkzUnBiMjVCYlc5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSb2FYTXVkSEpoYm5OaFkzUnBiMjVCYlc5MWJuUXVkbUZzZFdVZ1BTQXdPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxMWJIUnBVMmxuVjJGc2JHVjBRMjl1ZEhKaFkzUXVkWEJrWVhSbFUybG5ibVZ5Y3lodVpYZFRhV2R1WlhKelRHbHpkRG9nWW5sMFpYTXBJQzArSUhadmFXUTZDblZ3WkdGMFpWTnBaMjVsY25NNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFF0TkRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUIxY0dSaGRHVlRhV2R1WlhKektBb2dJQ0FnTHk4Z0lDQnVaWGRUYVdkdVpYSnpUR2x6ZERvZ1lubDBaWE1LSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1selFYVjBhRzl5YVhwbFpGTnBaMjVsY2loVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6S1N3Z0owOXViSGtnWVhWMGFHOXlhWHBsWkNCemFXZHVaWEp6SUdOaGJpQjFjR1JoZEdVZ2MybG5ibVZ5Y3lCc2FYTjBKeWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUdselFYVjBhRzl5YVhwbFpGTnBaMjVsY2dvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lYVjBhRzl5YVhwbFpDQnphV2R1WlhKeklHTmhiaUIxY0dSaGRHVWdjMmxuYm1WeWN5QnNhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENodVpYZFRhV2R1WlhKelRHbHpkQzVzWlc1bmRHZ2dQaUF3TENBblRtVjNJSE5wWjI1bGNuTWdiR2x6ZENCallXNXViM1FnWW1VZ1pXMXdkSGtuS1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbVYzSUhOcFoyNWxjbk1nYkdsemRDQmpZVzV1YjNRZ1ltVWdaVzF3ZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdjMmxuYm1WeWN5QTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWdwT3lBdkx5QklZWE5vSUc5bUlITnBaMjVsY25NZ2JHbHpkQW9nSUNBZ1lubDBaV01nTkNBdkx5QWljMmxuYm1WeWN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnZEdocGN5NXphV2R1WlhKekxuWmhiSFZsSUQwZ2JtVjNVMmxuYm1WeWMweHBjM1E3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMTFiSFJwVTJsblYyRnNiR1YwUTI5dWRISmhZM1F1ZFhCa1lYUmxVbVZ4ZFdseVpXUlRhV2R1WVhSMWNtVnpLRzVsZDFKbGNYVnBjbVZrVTJsbmN6b2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDFjR1JoZEdWU1pYRjFhWEpsWkZOcFoyNWhkSFZ5WlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGt0TmpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUIxY0dSaGRHVlNaWEYxYVhKbFpGTnBaMjVoZEhWeVpYTW9DaUFnSUNBdkx5QWdJRzVsZDFKbGNYVnBjbVZrVTJsbmN6b2dkV2x1ZERZMENpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBjMEYxZEdodmNtbDZaV1JUYVdkdVpYSW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5a3NJQ2RQYm14NUlHRjFkR2h2Y21sNlpXUWdjMmxuYm1WeWN5QmpZVzRnZFhCa1lYUmxJSFJvY21WemFHOXNaQ2NwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCcGMwRjFkR2h2Y21sNlpXUlRhV2R1WlhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRjFkR2h2Y21sNlpXUWdjMmxuYm1WeWN5QmpZVzRnZFhCa1lYUmxJSFJvY21WemFHOXNaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCaGMzTmxjblFvYm1WM1VtVnhkV2x5WldSVGFXZHpJRDRnTUN3Z0oxSmxjWFZwY21Wa0lITnBaMjVoZEhWeVpYTWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnTUNjcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGNuUWdMeThnVW1WeGRXbHlaV1FnYzJsbmJtRjBkWEpsY3lCdGRYTjBJR0psSUdkeVpXRjBaWElnZEdoaGJpQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUhKbGNYVnBjbVZrVTJsbmJtRjBkWEpsY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsY1hWcGNtVmtVMmxuYm1GMGRYSmxjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFoxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2RHaHBjeTV5WlhGMWFYSmxaRk5wWjI1aGRIVnlaWE11ZG1Gc2RXVWdQU0J1WlhkU1pYRjFhWEpsWkZOcFozTTdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxMWJIUnBVMmxuVjJGc2JHVjBRMjl1ZEhKaFkzUXVjSEp2Y0c5elpWUnlZVzV6WVdOMGFXOXVLSEpsWTJsd2FXVnVkRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncHdjbTl3YjNObFZISmhibk5oWTNScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpNdE56Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2NtOXdiM05sVkhKaGJuTmhZM1JwYjI0b0NpQWdJQ0F2THlBZ0lISmxZMmx3YVdWdWREb2dZbmwwWlhNc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGMwRjFkR2h2Y21sNlpXUlRhV2R1WlhJb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lrc0lDZFBibXg1SUdGMWRHaHZjbWw2WldRZ2MybG5ibVZ5Y3lCallXNGdjSEp2Y0c5elpTQjBjbUZ1YzJGamRHbHZibk1uS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTmhiR3h6ZFdJZ2FYTkJkWFJvYjNKcGVtVmtVMmxuYm1WeUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmhkWFJvYjNKcGVtVmtJSE5wWjI1bGNuTWdZMkZ1SUhCeWIzQnZjMlVnZEhKaGJuTmhZM1JwYjI1ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRElLSUNBZ0lDOHZJR0Z6YzJWeWRDaHlaV05wY0dsbGJuUXViR1Z1WjNSb0lENGdNQ3dnSjFKbFkybHdhV1Z1ZENCaFpHUnlaWE56SUdOaGJtNXZkQ0JpWlNCbGJYQjBlU2NwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaV05wY0dsbGJuUWdZV1JrY21WemN5QmpZVzV1YjNRZ1ltVWdaVzF3ZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdZWE56WlhKMEtHRnRiM1Z1ZENBK0lEQXNJQ2RVY21GdWMyRmpkR2x2YmlCaGJXOTFiblFnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZISmhibk5oWTNScGIyNGdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFoxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2RISmhibk5oWTNScGIyNUJiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owY21GdWMyRmpkR2x2YmtGdGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVhOcFoxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z2RHaHBjeTUwY21GdWMyRmpkR2x2YmtGdGIzVnVkQzUyWVd4MVpTQTlJR0Z0YjNWdWREc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnZEhKaGJuTmhZM1JwYjI1U1pXTnBjR2xsYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlkSEpoYm5OaFkzUnBiMjVTWldOcGNHbGxiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklIUm9hWE11ZEhKaGJuTmhZM1JwYjI1U1pXTnBjR2xsYm5RdWRtRnNkV1VnUFNCeVpXTnBjR2xsYm5RN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR0Z3Y0hKdmRtRnNjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnVG5WdFltVnlJRzltSUdGd2NISnZkbUZzY3lCeVpXTmxhWFpsWkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVhCd2NtOTJZV3h6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QjBhR2x6TG1Gd2NISnZkbUZzY3k1MllXeDFaU0E5SURFN0lDOHZJRkJ5YjNCdmMyVnlJR052ZFc1MGN5QmhjeUJtYVhKemRDQmhjSEJ5YjNaaGJBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazExYkhScFUybG5WMkZzYkdWMFEyOXVkSEpoWTNRdVlYQndjbTkyWlZSeVlXNXpZV04wYVc5dUtDa2dMVDRnZG05cFpEb0tZWEJ3Y205MlpWUnlZVzV6WVdOMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBjMEYxZEdodmNtbDZaV1JUYVdkdVpYSW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5a3NJQ2RQYm14NUlHRjFkR2h2Y21sNlpXUWdjMmxuYm1WeWN5QmpZVzRnWVhCd2NtOTJaU0IwY21GdWMyRmpkR2x2Ym5NbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdhWE5CZFhSb2IzSnBlbVZrVTJsbmJtVnlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoZFhSb2IzSnBlbVZrSUhOcFoyNWxjbk1nWTJGdUlHRndjSEp2ZG1VZ2RISmhibk5oWTNScGIyNXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhCbGJtUnBibWRVY21GdWMyRmpkR2x2YmlBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpZ3BPeUF2THlCSVlYTm9JRzltSUhCbGJtUnBibWNnZEhKaGJuTmhZM1JwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p3Wlc1a2FXNW5WSEpoYm5OaFkzUnBiMjRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXdaVzVrYVc1blZISmhibk5oWTNScGIyNHVkbUZzZFdVdWJHVnVaM1JvSUQ0Z01Dd2dKMDV2SUhCbGJtUnBibWNnZEhKaGJuTmhZM1JwYjI0Z2RHOGdZWEJ3Y205MlpTY3BPd29nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdjR1Z1WkdsdVp5QjBjbUZ1YzJGamRHbHZiaUIwYnlCaGNIQnliM1psQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHRndjSEp2ZG1Gc2N5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdUblZ0WW1WeUlHOW1JR0Z3Y0hKdmRtRnNjeUJ5WldObGFYWmxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRndjSEp2ZG1Gc2N5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJSFJvYVhNdVlYQndjbTkyWVd4ekxuWmhiSFZsSUQwZ2RHaHBjeTVoY0hCeWIzWmhiSE11ZG1Gc2RXVWdLeUF4T3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWVhCd2NtOTJZV3h6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPeUF2THlCT2RXMWlaWElnYjJZZ1lYQndjbTkyWVd4eklISmxZMlZwZG1Wa0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGNIQnliM1poYkhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJSFJvYVhNdVlYQndjbTkyWVd4ekxuWmhiSFZsSUQwZ2RHaHBjeTVoY0hCeWIzWmhiSE11ZG1Gc2RXVWdLeUF4T3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUWFZzZEdsVGFXZFhZV3hzWlhSRGIyNTBjbUZqZEM1bGVHVmpkWFJsVkhKaGJuTmhZM1JwYjI0b0tTQXRQaUIyYjJsa09ncGxlR1ZqZFhSbFZISmhibk5oWTNScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBjMEYxZEdodmNtbDZaV1JUYVdkdVpYSW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5a3NJQ2RQYm14NUlHRjFkR2h2Y21sNlpXUWdjMmxuYm1WeWN5QmpZVzRnWlhobFkzVjBaU0IwY21GdWMyRmpkR2x2Ym5NbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdhWE5CZFhSb2IzSnBlbVZrVTJsbmJtVnlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoZFhSb2IzSnBlbVZrSUhOcFoyNWxjbk1nWTJGdUlHVjRaV04xZEdVZ2RISmhibk5oWTNScGIyNXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUdGd2NISnZkbUZzY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNnTHk4Z1RuVnRZbVZ5SUc5bUlHRndjSEp2ZG1Gc2N5QnlaV05sYVhabFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Gd2NISnZkbUZzY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklISmxjWFZwY21Wa1UybG5ibUYwZFhKbGN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p5WlhGMWFYSmxaRk5wWjI1aGRIVnlaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd09Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZWEJ3Y205MllXeHpMblpoYkhWbElENDlJSFJvYVhNdWNtVnhkV2x5WldSVGFXZHVZWFIxY21WekxuWmhiSFZsTENBblRtOTBJR1Z1YjNWbmFDQmhjSEJ5YjNaaGJITW5LVHNLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJR1Z1YjNWbmFDQmhjSEJ5YjNaaGJITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnY0dWdVpHbHVaMVJ5WVc1ellXTjBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdJQzh2SUVoaGMyZ2diMllnY0dWdVpHbHVaeUIwY21GdWMyRmpkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbkJsYm1ScGJtZFVjbUZ1YzJGamRHbHZiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXdaVzVrYVc1blZISmhibk5oWTNScGIyNHVkbUZzZFdVdWJHVnVaM1JvSUQ0Z01Dd2dKMDV2SUhCbGJtUnBibWNnZEhKaGJuTmhZM1JwYjI0Z2RHOGdaWGhsWTNWMFpTY3BPd29nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdjR1Z1WkdsdVp5QjBjbUZ1YzJGamRHbHZiaUIwYnlCbGVHVmpkWFJsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHRndjSEp2ZG1Gc2N5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdUblZ0WW1WeUlHOW1JR0Z3Y0hKdmRtRnNjeUJ5WldObGFYWmxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWEJ3Y205MllXeHpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z2RHaHBjeTVoY0hCeWIzWmhiSE11ZG1Gc2RXVWdQU0F3T3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklIUnlZVzV6WVdOMGFXOXVRVzF2ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEhKaGJuTmhZM1JwYjI1QmJXOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTBDaUFnSUNBdkx5QjBhR2x6TG5SeVlXNXpZV04wYVc5dVFXMXZkVzUwTG5aaGJIVmxJRDBnTURzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5kV3gwYVZOcFoxZGhiR3hsZEVOdmJuUnlZV04wTG1selFYVjBhRzl5YVhwbFpGTnBaMjVsY2loaFpHUnlaWE56T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwcGMwRjFkR2h2Y21sNlpXUlRhV2R1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl5TFRFeU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJQzh2SUdselFYVjBhRzl5YVhwbFpGTnBaMjVsY2loaFpHUnlaWE56T2lCaWVYUmxjeWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpVS0lDQWdJQzh2SUdsbUlDaGhaR1J5WlhOekxteGxibWQwYUNBOVBUMGdNQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1ltNTZJR2x6UVhWMGFHOXlhWHBsWkZOcFoyNWxjbDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpZS0lDQWdJQzh2SUhKbGRIVnliaUF3T3lBdkx5Qk9iM1FnWVhWMGFHOXlhWHBsWkNBdElHVnRjSFI1SUdGa1pISmxjM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21selFYVjBhRzl5YVhwbFpGTnBaMjVsY2w5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QnBaaUFvWVdSa2NtVnpjeTVzWlc1bmRHZ2dQQ0F6TWlrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQQW9nSUNBZ1lub2dhWE5CZFhSb2IzSnBlbVZrVTJsbmJtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5T1FvZ0lDQWdMeThnY21WMGRYSnVJREE3SUM4dklFNXZkQ0JoZFhSb2IzSnBlbVZrSUMwZ1lXUmtjbVZ6Y3lCMGIyOGdjMmh2Y25RZ0tITjFjM0JwWTJsdmRYTXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3BwYzBGMWRHaHZjbWw2WldSVGFXZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCemFXZHVaWEp6SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdJQzh2SUVoaGMyZ2diMllnYzJsbmJtVnljeUJzYVhOMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYzJsbmJtVnljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRReENpQWdJQ0F2THlCcFppQW9kR2hwY3k1emFXZHVaWEp6TG5aaGJIVmxMbXhsYm1kMGFDQTlQVDBnTUNrZ2V3b2dJQ0FnYkdWdUNpQWdJQ0JpYm5vZ2FYTkJkWFJvYjNKcGVtVmtVMmxuYm1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNZ29nSUNBZ0x5OGdjbVYwZFhKdUlEQTdJQzh2SUU1dmRDQmhkWFJvYjNKcGVtVmtJQzBnYm04Z2MybG5ibVZ5Y3lCamIyNW1hV2QxY21Wa0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncHBjMEYxZEdodmNtbDZaV1JUYVdkdVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0FvZ0lDQWdMeThnYVdZZ0tHRmtaSEpsYzNNdWJHVnVaM1JvSUQ0OUlETXlJQ1ltSUdGa1pISmxjM011YkdWdVozUm9JRHc5SURZMEtTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0ErUFFvZ0lDQWdZbm9nYVhOQmRYUm9iM0pwZW1Wa1UybG5ibVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaWVpQnBjMEYxZEdodmNtbDZaV1JUYVdkdVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFE1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdNVHNnTHk4Z1FYVjBhRzl5YVhwbFpDQW9jR0Z6YzJWa0lHSmhjMmxqSUhaaGJHbGtZWFJwYjI0cENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncHBjMEYxZEdodmNtbDZaV1JUYVdkdVpYSmZZV1owWlhKZmFXWmZaV3h6WlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBjMmxuWDNkaGJHeGxkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnY21WMGRYSnVJREE3SUM4dklFNXZkQ0JoZFhSb2IzSnBlbVZrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTmRXeDBhVk5wWjFkaGJHeGxkRU52Ym5SeVlXTjBMbWRsZEZCbGJtUnBibWRVY21GdWMyRmpkR2x2YmlncElDMCtJR0o1ZEdWek9ncG5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklIQmxibVJwYm1kVWNtRnVjMkZqZEdsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWdwT3lBdkx5QklZWE5vSUc5bUlIQmxibVJwYm1jZ2RISmhibk5oWTNScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKd1pXNWthVzVuVkhKaGJuTmhZM1JwYjI0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Y0dWdVpHbHVaMVJ5WVc1ellXTjBhVzl1TG5aaGJIVmxPd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwYzJsblgzZGhiR3hsZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTmRXeDBhVk5wWjFkaGJHeGxkRU52Ym5SeVlXTjBMbWRsZEVGd2NISnZkbUZzYzBOdmRXNTBLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUkJjSEJ5YjNaaGJITkRiM1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdZWEJ3Y205MllXeHpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJPZFcxaVpYSWdiMllnWVhCd2NtOTJZV3h6SUhKbFkyVnBkbVZrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWEJ3Y205MllXeHpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpnS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtRndjSEp2ZG1Gc2N5NTJZV3gxWlRzS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFYTnBaMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUWFZzZEdsVGFXZFhZV3hzWlhSRGIyNTBjbUZqZEM1blpYUlNaWEYxYVhKbFpGTnBaMjVoZEhWeVpYTW9LU0F0UGlCMWFXNTBOalE2Q21kbGRGSmxjWFZwY21Wa1UybG5ibUYwZFhKbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhWE5wWjE5M1lXeHNaWFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnY21WeGRXbHlaV1JUYVdkdVlYUjFjbVZ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxjWFZwY21Wa1UybG5ibUYwZFhKbGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbHphV2RmZDJGc2JHVjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1eVpYRjFhWEpsWkZOcFoyNWhkSFZ5WlhNdWRtRnNkV1U3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsemFXZGZkMkZzYkdWMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMTFiSFJwVTJsblYyRnNiR1YwUTI5dWRISmhZM1F1WjJWMFZISmhibk5oWTNScGIyNUJiVzkxYm5Rb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEZSeVlXNXpZV04wYVc5dVFXMXZkVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScGMybG5YM2RoYkd4bGRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QjBjbUZ1YzJGamRHbHZia0Z0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owY21GdWMyRmpkR2x2YmtGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2x6YVdkZmQyRnNiR1YwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NTBjbUZ1YzJGamRHbHZia0Z0YjNWdWRDNTJZV3gxWlRzS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVnSmdZSllYQndjbTkyWVd4ekJCVWZmSFVTY21WeGRXbHlaV1JUYVdkdVlYUjFjbVZ6RVhSeVlXNXpZV04wYVc5dVFXMXZkVzUwQjNOcFoyNWxjbk1TY0dWdVpHbHVaMVJ5WVc1ellXTjBhVzl1TVJ0QkFVQ0NEQVJCcFdiTkJQVEhIZk1FdEZFODd3UWIzZk0rQks3YWM2Y0V6Z2VFMUFTNDIraTBCSkxNdG9NRWNVTTdHUVNIb1ZNMkJIZkhKVEVFNElPTHVqWWFBSTRNQU04QXZRQ3RBSmNBaXdCL0FHZ0FVQUEvQUM0QUhRQUNJa014R1JSRU1SaEVOaG9CVndJQVNSVVdWd1lDVEZBcFRGQ3dJME14R1JSRU1SaEVpQUhGRmlsTVVMQWpRekVaRkVReEdFU0lBYThXS1V4UXNDTkRNUmtVUkRFWVJJZ0JtUllwVEZDd0kwTXhHUlJFTVJoRWlBR0NTUlVXVndZQ1RGQXBURkN3STBNeEdSUkVNUmhFTmhvQlZ3SUFpQUVzRmlsTVVMQWpRekVaRkVReEdFU0lBUDBqUXpFWkZFUXhHRVNJQU5valF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBQ1RJME14R1JSRU1SaEVOaG9CRjRnQWNpTkRNUmtVUkRFWVJEWWFBVmNDQUlnQVRTTkRNUmtVUkRFWVJEWWFBVmNDQURZYUFoZUlBQTBqUXpFWlFQOFdNUmdVUkNORGlnSUFpLzRWUkl2L1JDY0VpLzVuS292L1o0QU1kRzkwWVd4VGFXZHVaWEp6SW1jb0ltY3JJbWVKaWdFQU1RQ0lBSUpFaS84VlJDY0VpLzluaVlvQkFERUFpQUJ2Ukl2L1JDcUwvMmVKaWdJQU1RQ0lBRjVFaS80VlJJdi9SQ3VMLzJlQUZIUnlZVzV6WVdOMGFXOXVVbVZqYVhCcFpXNTBpLzVuS0NObmlURUFpQUF3UkNJbkJXVkVGVVFpS0dWRUl3Z29UR2VKTVFDSUFCbEVJaWhsUkNJcVpVUVBSQ0luQldWRUZVUW9JbWNySW1lSmlnRUJpLzhWU1VBQUF5Sk1pWXNBSkF4QkFBTWlUSWtpSndSbFJCVkFBQU1pVEltTEFDUVBRUUFMaXdDQlFBNUJBQU1qVElraVRJa2lKd1ZsUklraUtHVkVpU0lxWlVTSklpdGxSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
