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

namespace Arc56.Generated.harsh_a_parihar.Hackpay.TaxComplianceContract_7adedc87
{


    //
    // Tax Compliance Contract
    //Handles automated tax reporting and document generation
    //
    public class TaxComplianceContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TaxComplianceContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the tax compliance contract
        ///PRODUCTION READY: Configurable tax authority with proper validation
        ///</summary>
        /// <param name="authority"> </param>
        /// <param name="reportingPeriodDays"> </param>
        /// <param name="taxRateBps"> </param>
        public async Task Initialize(byte[] authority, ulong reportingPeriodDays, ulong taxRateBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 173, 19, 191 };
            var authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorityAbi.From(authority);
            var reportingPeriodDaysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reportingPeriodDaysAbi.From(reportingPeriodDays);
            var taxRateBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); taxRateBpsAbi.From(taxRateBps);

            var result = await base.CallApp(new List<object> { abiHandle, authorityAbi, reportingPeriodDaysAbi, taxRateBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(byte[] authority, ulong reportingPeriodDays, ulong taxRateBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 173, 19, 191 };
            var authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorityAbi.From(authority);
            var reportingPeriodDaysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reportingPeriodDaysAbi.From(reportingPeriodDays);
            var taxRateBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); taxRateBpsAbi.From(taxRateBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, authorityAbi, reportingPeriodDaysAbi, taxRateBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Change tax authority (governance)
        ///PRODUCTION READY: Allows authority transfer for governance
        ///</summary>
        /// <param name="newAuthority"> </param>
        public async Task ChangeTaxAuthority(byte[] newAuthority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 38, 133, 144 };
            var newAuthorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newAuthorityAbi.From(newAuthority);

            var result = await base.CallApp(new List<object> { abiHandle, newAuthorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeTaxAuthority_Transactions(byte[] newAuthority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 38, 133, 144 };
            var newAuthorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newAuthorityAbi.From(newAuthority);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAuthorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record a distribution for tax purposes
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="recipient"> </param>
        public async Task RecordDistribution(ulong amount, byte[] recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 163, 117, 169 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordDistribution_Transactions(ulong amount, byte[] recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 163, 117, 169 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Generate tax report
        ///</summary>
        public async Task GenerateTaxReport(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 180, 4, 196 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GenerateTaxReport_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 180, 4, 196 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update tax rate (authority only)
        ///PRODUCTION READY: Enhanced validation for tax rate updates
        ///</summary>
        /// <param name="newRateBps"> </param>
        public async Task UpdateTaxRate(ulong newRateBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 143, 55, 222 };
            var newRateBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newRateBpsAbi.From(newRateBps);

            var result = await base.CallApp(new List<object> { abiHandle, newRateBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateTaxRate_Transactions(ulong newRateBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 143, 55, 222 };
            var newRateBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newRateBpsAbi.From(newRateBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, newRateBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total distributions
        ///</summary>
        public async Task<ulong> GetTotalDistributions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 229, 236, 226 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalDistributions_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 229, 236, 226 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total tax collected
        ///</summary>
        public async Task<ulong> GetTotalTaxCollected(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 48, 141, 73 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalTaxCollected_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 48, 141, 73 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current tax rate
        ///</summary>
        public async Task<ulong> GetTaxRate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 52, 71, 27 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTaxRate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 52, 71, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get compliance status
        ///</summary>
        public async Task<ulong> GetComplianceStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 4, 58, 214 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetComplianceStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 4, 58, 214 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate tax for a given amount
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> CalculateTax(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 113, 3, 71 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.SimApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateTax_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 113, 3, 71 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGF4Q29tcGxpYW5jZUNvbnRyYWN0IiwiZGVzYyI6IlRheCBDb21wbGlhbmNlIENvbnRyYWN0XG5IYW5kbGVzIGF1dG9tYXRlZCB0YXggcmVwb3J0aW5nIGFuZCBkb2N1bWVudCBnZW5lcmF0aW9uIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgdGF4IGNvbXBsaWFuY2UgY29udHJhY3RcblBST0RVQ1RJT04gUkVBRFk6IENvbmZpZ3VyYWJsZSB0YXggYXV0aG9yaXR5IHdpdGggcHJvcGVyIHZhbGlkYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBvcnRpbmdQZXJpb2REYXlzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXhSYXRlQnBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoYW5nZVRheEF1dGhvcml0eSIsImRlc2MiOiJDaGFuZ2UgdGF4IGF1dGhvcml0eSAoZ292ZXJuYW5jZSlcblBST0RVQ1RJT04gUkVBRFk6IEFsbG93cyBhdXRob3JpdHkgdHJhbnNmZXIgZm9yIGdvdmVybmFuY2UiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QXV0aG9yaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZERpc3RyaWJ1dGlvbiIsImRlc2MiOiJSZWNvcmQgYSBkaXN0cmlidXRpb24gZm9yIHRheCBwdXJwb3NlcyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZW5lcmF0ZVRheFJlcG9ydCIsImRlc2MiOiJHZW5lcmF0ZSB0YXggcmVwb3J0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVRheFJhdGUiLCJkZXNjIjoiVXBkYXRlIHRheCByYXRlIChhdXRob3JpdHkgb25seSlcblBST0RVQ1RJT04gUkVBRFk6IEVuaGFuY2VkIHZhbGlkYXRpb24gZm9yIHRheCByYXRlIHVwZGF0ZXMiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3UmF0ZUJwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb3RhbERpc3RyaWJ1dGlvbnMiLCJkZXNjIjoiR2V0IHRvdGFsIGRpc3RyaWJ1dGlvbnMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRvdGFsVGF4Q29sbGVjdGVkIiwiZGVzYyI6IkdldCB0b3RhbCB0YXggY29sbGVjdGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUYXhSYXRlIiwiZGVzYyI6IkdldCBjdXJyZW50IHRheCByYXRlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb21wbGlhbmNlU3RhdHVzIiwiZGVzYyI6IkdldCBjb21wbGlhbmNlIHN0YXR1cyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlVGF4IiwiZGVzYyI6IkNhbGN1bGF0ZSB0YXggZm9yIGEgZ2l2ZW4gYW1vdW50IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGVsbG8iLCJkZXNjIjoiSGVsbG8gbWV0aG9kIGZvciB0ZXN0aW5nIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo2LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTAyXSwiZXJyb3JNZXNzYWdlIjoiTmV3IGF1dGhvcml0eSBhZGRyZXNzIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMF0sImVycm9yTWVzc2FnZSI6Ik5ldyBhdXRob3JpdHkgbXVzdCBiZSBkaWZmZXJlbnQgZnJvbSBjdXJyZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk4LDIyNSwyNDYsMjYzLDI4MCwyOTcsMzE0LDMzMCwzNDIsMzY0LDM4Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3VycmVudCB0YXggYXV0aG9yaXR5IGNhbiBjaGFuZ2UgYXV0aG9yaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY0XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0YXggYXV0aG9yaXR5IGNhbiBnZW5lcmF0ZSByZXBvcnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI2XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0YXggYXV0aG9yaXR5IGNhbiByZWNvcmQgZGlzdHJpYnV0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGF4IGF1dGhvcml0eSBjYW4gdXBkYXRlIHRheCByYXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI1XSwiZXJyb3JNZXNzYWdlIjoiUmVwb3J0aW5nIHBlcmlvZCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIyXSwiZXJyb3JNZXNzYWdlIjoiVGF4IGF1dGhvcml0eSBhZGRyZXNzIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzOV0sImVycm9yTWVzc2FnZSI6IlRheCByYXRlIG11c3QgYmUgYmV0d2VlbiAxIGFuZCAxMDAwMCBiYXNpcyBwb2ludHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OThdLCJlcnJvck1lc3NhZ2UiOiJUYXggcmF0ZSBtdXN0IGJlIGJldHdlZW4gMSBhbmQgMTAwMDAgYmFzaXMgcG9pbnRzICgwLjAxJSB0byAxMDAlKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMSwyMjgsMjQ5LDI2NiwyODMsMzAwLDMxNywzMzMsMzQ1LDM2NywzODVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk2LDUwNiw1MjQsNTMwLDU0MCw1NTAsNTYyLDU4Miw2MTEsNjE3LDYyMiw2MjgsNjM2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURFd01EQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSjBZWGhCZFhSb2IzSnBkSGtpSURCNE1UVXhaamRqTnpVZ0luUmhlRkpoZEdVaUlDSjBiM1JoYkVScGMzUnlhV0oxZEdsdmJuTWlJQ0owYjNSaGJGUmhlRU52Ykd4bFkzUmxaQ0lnSW1OdmJYQnNhV0Z1WTJWVGRHRjBkWE1pSUNKc1lYTjBVbVZ3YjNKMFJHRjBaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVZWGhEYjIxd2JHbGhibU5sUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRZS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoak9HRmtNVE5pWmlBd2VEZzBNalk0TlRrd0lEQjROakpoTXpjMVlUa2dNSGd4WVdJME1EUmpOQ0F3ZUdNeE9HWXpOMlJsSURCNFpURmxOV1ZqWlRJZ01IaGtOVE13T0dRME9TQXdlRFUxTXpRME56RmlJREI0TlRjd05ETmhaRFlnTUhnM1pEY3hNRE0wTnlBd2VHVXdPRE00WW1KaElDOHZJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaU2hpZVhSbFcxMHNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0pqYUdGdVoyVlVZWGhCZFhSb2IzSnBkSGtvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxZMjl5WkVScGMzUnlhV0oxZEdsdmJpaDFhVzUwTmpRc1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsYm1WeVlYUmxWR0Y0VW1Wd2IzSjBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWVVlYaFNZWFJsS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJVYjNSaGJFUnBjM1J5YVdKMWRHbHZibk1vS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFZHOTBZV3hVWVhoRGIyeHNaV04wWldRb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBWR0Y0VW1GMFpTZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJEYjIxd2JHbGhibU5sVTNSaGRIVnpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5oYkdOMWJHRjBaVlJoZUNoMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pvWld4c2J5aGllWFJsVzEwcFlubDBaVnRkSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlwYm1sMGFXRnNhWHBsWDNKdmRYUmxRRE1nYldGcGJsOWphR0Z1WjJWVVlYaEJkWFJvYjNKcGRIbGZjbTkxZEdWQU5DQnRZV2x1WDNKbFkyOXlaRVJwYzNSeWFXSjFkR2x2Ymw5eWIzVjBaVUExSUcxaGFXNWZaMlZ1WlhKaGRHVlVZWGhTWlhCdmNuUmZjbTkxZEdWQU5pQnRZV2x1WDNWd1pHRjBaVlJoZUZKaGRHVmZjbTkxZEdWQU55QnRZV2x1WDJkbGRGUnZkR0ZzUkdsemRISnBZblYwYVc5dWMxOXliM1YwWlVBNElHMWhhVzVmWjJWMFZHOTBZV3hVWVhoRGIyeHNaV04wWldSZmNtOTFkR1ZBT1NCdFlXbHVYMmRsZEZSaGVGSmhkR1ZmY205MWRHVkFNVEFnYldGcGJsOW5aWFJEYjIxd2JHbGhibU5sVTNSaGRIVnpYM0p2ZFhSbFFERXhJRzFoYVc1ZlkyRnNZM1ZzWVhSbFZHRjRYM0p2ZFhSbFFERXlJRzFoYVc1ZmFHVnNiRzlmY205MWRHVkFNVE1LQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVVlYaERiMjF3YkdsaGJtTmxRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyaGxiR3h2WDNKdmRYUmxRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdGNFEyOXRjR3hwWVc1alpVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOaGJHTjFiR0YwWlZSaGVGOXliM1YwWlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUmhlRU52YlhCc2FXRnVZMlZEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR05oYkd4emRXSWdZMkZzWTNWc1lYUmxWR0Y0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEVOdmJYQnNhV0Z1WTJWVGRHRjBkWE5mY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwUTI5dGNHeHBZVzVqWlZOMFlYUjFjd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJVWVhoU1lYUmxYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlJoZUZKaGRHVUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWRzkwWVd4VVlYaERiMnhzWldOMFpXUmZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUlViM1JoYkZSaGVFTnZiR3hsWTNSbFpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlViM1JoYkVScGMzUnlhV0oxZEdsdmJuTmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUlViM1JoYkVScGMzUnlhV0oxZEdsdmJuTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsVkdGNFVtRjBaVjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVZWGhEYjIxd2JHbGhibU5sUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFZHRjRVbUYwWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlc1bGNtRjBaVlJoZUZKbGNHOXlkRjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVnVaWEpoZEdWVVlYaFNaWEJ2Y25RS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY21WamIzSmtSR2x6ZEhKcFluVjBhVzl1WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJoZUVOdmJYQnNhV0Z1WTJWRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdjbVZqYjNKa1JHbHpkSEpwWW5WMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTm9ZVzVuWlZSaGVFRjFkR2h2Y21sMGVWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVVlYaERiMjF3YkdsaGJtTmxRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdOb1lXNW5aVlJoZUVGMWRHaHZjbWwwZVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYm1sMGFXRnNhWHBsWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJoZUVOdmJYQnNhV0Z1WTJWRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdhVzVwZEdsaGJHbDZaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdGNFEyOXRjR3hwWVc1alpVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkdGNFEyOXRjR3hwWVc1alpVTnZiblJ5WVdOMExtbHVhWFJwWVd4cGVtVW9ZWFYwYUc5eWFYUjVPaUJpZVhSbGN5d2djbVZ3YjNKMGFXNW5VR1Z5YVc5a1JHRjVjem9nZFdsdWREWTBMQ0IwWVhoU1lYUmxRbkJ6T2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21sdWFYUnBZV3hwZW1VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUzB5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVVvQ2lBZ0lDQXZMeUFnSUdGMWRHaHZjbWwwZVRvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFnSUhKbGNHOXlkR2x1WjFCbGNtbHZaRVJoZVhNNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2RHRjRVbUYwWlVKd2N6b2dkV2x1ZERZMENpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdGemMyVnlkQ2hoZFhSb2IzSnBkSGt1YkdWdVozUm9JRDRnTUN3Z0oxUmhlQ0JoZFhSb2IzSnBkSGtnWVdSa2NtVnpjeUJqWVc1dWIzUWdZbVVnWlcxd2RIa25LVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHRjRJR0YxZEdodmNtbDBlU0JoWkdSeVpYTnpJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHlaWEJ2Y25ScGJtZFFaWEpwYjJSRVlYbHpJRDRnTUN3Z0oxSmxjRzl5ZEdsdVp5QndaWEpwYjJRZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQ2NwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZ3YjNKMGFXNW5JSEJsY21sdlpDQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSaGVGSmhkR1ZDY0hNZ1BpQXdJQ1ltSUhSaGVGSmhkR1ZDY0hNZ1BEMGdNVEF3TURBc0lDZFVZWGdnY21GMFpTQnRkWE4wSUdKbElHSmxkSGRsWlc0Z01TQmhibVFnTVRBd01EQWdZbUZ6YVhNZ2NHOXBiblJ6SnlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o2SUdsdWFYUnBZV3hwZW1WZlltOXZiRjltWVd4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQXdNQW9nSUNBZ1BEMEtJQ0FnSUdKNklHbHVhWFJwWVd4cGVtVmZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYVc1cGRHbGhiR2w2WlY5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnWVhOelpYSjBLSFJoZUZKaGRHVkNjSE1nUGlBd0lDWW1JSFJoZUZKaGRHVkNjSE1nUEQwZ01UQXdNREFzSUNkVVlYZ2djbUYwWlNCdGRYTjBJR0psSUdKbGRIZGxaVzRnTVNCaGJtUWdNVEF3TURBZ1ltRnphWE1nY0c5cGJuUnpKeWs3Q2lBZ0lDQmhjM05sY25RZ0x5OGdWR0Y0SUhKaGRHVWdiWFZ6ZENCaVpTQmlaWFIzWldWdUlERWdZVzVrSURFd01EQXdJR0poYzJseklIQnZhVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2RHRjRRWFYwYUc5eWFYUjVJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMFlYaEJkWFJvYjNKcGRIa2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnZEdocGN5NTBZWGhCZFhSb2IzSnBkSGt1ZG1Gc2RXVWdQU0JoZFhSb2IzSnBkSGs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2NtVndiM0owYVc1blVHVnlhVzlrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPeUF2THlCRVlYbHpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luSmxjRzl5ZEdsdVoxQmxjbWx2WkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QjBhR2x6TG5KbGNHOXlkR2x1WjFCbGNtbHZaQzUyWVd4MVpTQTlJSEpsY0c5eWRHbHVaMUJsY21sdlpFUmhlWE03Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2JHRnpkRkpsY0c5eWRFUmhkR1VnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnNZWE4wVW1Wd2IzSjBSR0YwWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QjBhR2x6TG14aGMzUlNaWEJ2Y25SRVlYUmxMblpoYkhWbElEMGdNRHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUhSdmRHRnNSR2x6ZEhKcFluVjBhVzl1Y3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1JHbHpkSEpwWW5WMGFXOXVjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JHbHpkSEpwWW5WMGFXOXVjeTUyWVd4MVpTQTlJREE3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCMGIzUmhiRlJoZUVOdmJHeGxZM1JsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJ2ZEdGc1ZHRjRRMjlzYkdWamRHVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VVlYaERiMnhzWldOMFpXUXVkbUZzZFdVZ1BTQXdPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnZEdGNFVtRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnUW1GemFYTWdjRzlwYm5SeklDaGxMbWN1TENBeE1EQXdJRDBnTVRBbEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHRjRVbUYwWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QjBhR2x6TG5SaGVGSmhkR1V1ZG1Gc2RXVWdQU0IwWVhoU1lYUmxRbkJ6T3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHTnZiWEJzYVdGdVkyVlRkR0YwZFhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklEQTlibTl1TFdOdmJYQnNhV0Z1ZEN3Z01UMWpiMjF3YkdsaGJuUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiWEJzYVdGdVkyVlRkR0YwZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdkR2hwY3k1amIyMXdiR2xoYm1ObFUzUmhkSFZ6TG5aaGJIVmxJRDBnTVRzZ0x5OGdRMjl0Y0d4cFlXNTBJR2x1YVhScFlXeHNlUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ21sdWFYUnBZV3hwZW1WZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2FXNXBkR2xoYkdsNlpWOWliMjlzWDIxbGNtZGxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkdGNFEyOXRjR3hwWVc1alpVTnZiblJ5WVdOMExtTm9ZVzVuWlZSaGVFRjFkR2h2Y21sMGVTaHVaWGRCZFhSb2IzSnBkSGs2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BqYUdGdVoyVlVZWGhCZFhSb2IzSnBkSGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5TMDBPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHTm9ZVzVuWlZSaGVFRjFkR2h2Y21sMGVTZ0tJQ0FnSUM4dklDQWdibVYzUVhWMGFHOXlhWFI1T2lCaWVYUmxjd29nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1MFlYaEJkWFJvYjNKcGRIa3VkbUZzZFdVc0lDZFBibXg1SUdOMWNuSmxiblFnZEdGNElHRjFkR2h2Y21sMGVTQmpZVzRnWTJoaGJtZGxJR0YxZEdodmNtbDBlU2NwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEdGNFFYVjBhRzl5YVhSNUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkR0Y0UVhWMGFHOXlhWFI1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTUwWVhoQmRYUm9iM0pwZEhrdWRtRnNkV1VzSUNkUGJteDVJR04xY25KbGJuUWdkR0Y0SUdGMWRHaHZjbWwwZVNCallXNGdZMmhoYm1kbElHRjFkR2h2Y21sMGVTY3BPd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR04xY25KbGJuUWdkR0Y0SUdGMWRHaHZjbWwwZVNCallXNGdZMmhoYm1kbElHRjFkR2h2Y21sMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGRCZFhSb2IzSnBkSGt1YkdWdVozUm9JRDRnTUN3Z0owNWxkeUJoZFhSb2IzSnBkSGtnWVdSa2NtVnpjeUJqWVc1dWIzUWdZbVVnWlcxd2RIa25LVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1RtVjNJR0YxZEdodmNtbDBlU0JoWkdSeVpYTnpJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdkR0Y0UVhWMGFHOXlhWFI1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHRjRRWFYwYUc5eWFYUjVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzUVhWMGFHOXlhWFI1SUNFOVBTQjBhR2x6TG5SaGVFRjFkR2h2Y21sMGVTNTJZV3gxWlN3Z0owNWxkeUJoZFhSb2IzSnBkSGtnYlhWemRDQmlaU0JrYVdabVpYSmxiblFnWm5KdmJTQmpkWEp5Wlc1MEp5azdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnVG1WM0lHRjFkR2h2Y21sMGVTQnRkWE4wSUdKbElHUnBabVpsY21WdWRDQm1jbTl0SUdOMWNuSmxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhSaGVFRjFkR2h2Y21sMGVTQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWdwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEdGNFFYVjBhRzl5YVhSNUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJvYVhNdWRHRjRRWFYwYUc5eWFYUjVMblpoYkhWbElEMGdibVYzUVhWMGFHOXlhWFI1T3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmhlRU52YlhCc2FXRnVZMlZEYjI1MGNtRmpkQzV5WldOdmNtUkVhWE4wY21saWRYUnBiMjRvWVcxdmRXNTBPaUIxYVc1ME5qUXNJSEpsWTJsd2FXVnVkRG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbkpsWTI5eVpFUnBjM1J5YVdKMWRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZd0xUWTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NtVmpiM0prUkdsemRISnBZblYwYVc5dUtBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2NtVmphWEJwWlc1ME9pQmllWFJsY3dvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnZEdocGN5NTBZWGhCZFhSb2IzSnBkSGt1ZG1Gc2RXVXNJQ2RQYm14NUlIUmhlQ0JoZFhSb2IzSnBkSGtnWTJGdUlISmxZMjl5WkNCa2FYTjBjbWxpZFhScGIyNXpKeWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUIwWVhoQmRYUm9iM0pwZEhrZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBZWGhCZFhSb2IzSnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMblJoZUVGMWRHaHZjbWwwZVM1MllXeDFaU3dnSjA5dWJIa2dkR0Y0SUdGMWRHaHZjbWwwZVNCallXNGdjbVZqYjNKa0lHUnBjM1J5YVdKMWRHbHZibk1uS1RzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMFlYZ2dZWFYwYUc5eWFYUjVJR05oYmlCeVpXTnZjbVFnWkdsemRISnBZblYwYVc5dWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSFJ2ZEdGc1JHbHpkSEpwWW5WMGFXOXVjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRVJwYzNSeWFXSjFkR2x2Ym5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeEVhWE4wY21saWRYUnBiMjV6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVScGMzUnlhV0oxZEdsdmJuTXVkbUZzZFdVZ0t5QmhiVzkxYm5RN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCMGIzUmhiRVJwYzNSeWFXSjFkR2x2Ym5NZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJFUnBjM1J5YVdKMWRHbHZibk1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFUnBjM1J5YVdKMWRHbHZibk11ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUkdsemRISnBZblYwYVc5dWN5NTJZV3gxWlNBcklHRnRiM1Z1ZERzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdkR0Y0VW1GMFpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdRbUZ6YVhNZ2NHOXBiblJ6SUNobExtY3VMQ0F4TURBd0lEMGdNVEFsS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJoZUZKaGRHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJR052Ym5OMElIUmhlRUZ0YjNWdWREb2dkV2x1ZERZMElEMGdLR0Z0YjNWdWRDQXFJSFJvYVhNdWRHRjRVbUYwWlM1MllXeDFaU2tnTHlBeE1EQXdNRHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURFd01EQXdDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdkRzkwWVd4VVlYaERiMnhzWldOMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEc5MFlXeFVZWGhEYjJ4c1pXTjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4VVlYaERiMnhzWldOMFpXUXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNWR0Y0UTI5c2JHVmpkR1ZrTG5aaGJIVmxJQ3NnZEdGNFFXMXZkVzUwT3dvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhSdmRHRnNWR0Y0UTI5c2JHVmpkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ1lubDBaV01nTkNBdkx5QWlkRzkwWVd4VVlYaERiMnhzWldOMFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkZSaGVFTnZiR3hsWTNSbFpDNTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeFVZWGhEYjJ4c1pXTjBaV1F1ZG1Gc2RXVWdLeUIwWVhoQmJXOTFiblE3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmhlRU52YlhCc2FXRnVZMlZEYjI1MGNtRmpkQzVuWlc1bGNtRjBaVlJoZUZKbGNHOXlkQ2dwSUMwK0lIWnZhV1E2Q21kbGJtVnlZWFJsVkdGNFVtVndiM0owT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOVBTQjBhR2x6TG5SaGVFRjFkR2h2Y21sMGVTNTJZV3gxWlN3Z0owOXViSGtnZEdGNElHRjFkR2h2Y21sMGVTQmpZVzRnWjJWdVpYSmhkR1VnY21Wd2IzSjBjeWNwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnZEdGNFFYVjBhRzl5YVhSNUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkR0Y0UVhWMGFHOXlhWFI1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTUwWVhoQmRYUm9iM0pwZEhrdWRtRnNkV1VzSUNkUGJteDVJSFJoZUNCaGRYUm9iM0pwZEhrZ1kyRnVJR2RsYm1WeVlYUmxJSEpsY0c5eWRITW5LVHNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0IwWVhnZ1lYVjBhRzl5YVhSNUlHTmhiaUJuWlc1bGNtRjBaU0J5WlhCdmNuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnYkdGemRGSmxjRzl5ZEVSaGRHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKc1lYTjBVbVZ3YjNKMFJHRjBaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCMGFHbHpMbXhoYzNSU1pYQnZjblJFWVhSbExuWmhiSFZsSUQwZ01Ec2dMeThnVjJsc2JDQmlaU0J6WlhRZ2RHOGdZM1Z5Y21WdWRDQjBhVzFsYzNSaGJYQWdkMmhsYmlCdVpXVmtaV1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdOdmJYQnNhV0Z1WTJWVGRHRjBkWE1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdJQzh2SURBOWJtOXVMV052YlhCc2FXRnVkQ3dnTVQxamIyMXdiR2xoYm5RS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJYQnNhV0Z1WTJWVGRHRjBkWE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2RHaHBjeTVqYjIxd2JHbGhibU5sVTNSaGRIVnpMblpoYkhWbElEMGdNVHNnTHk4Z1RXRnlheUJoY3lCamIyMXdiR2xoYm5RS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1JoZUY5amIyMXdiR2xoYm1ObEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmhlRU52YlhCc2FXRnVZMlZEYjI1MGNtRmpkQzUxY0dSaGRHVlVZWGhTWVhSbEtHNWxkMUpoZEdWQ2NITTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkWEJrWVhSbFZHRjRVbUYwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3dMVGt6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdkWEJrWVhSbFZHRjRVbUYwWlNnS0lDQWdJQzh2SUNBZ2JtVjNVbUYwWlVKd2N6b2dkV2x1ZERZMENpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMblJoZUVGMWRHaHZjbWwwZVM1MllXeDFaU3dnSjA5dWJIa2dkR0Y0SUdGMWRHaHZjbWwwZVNCallXNGdkWEJrWVhSbElIUmhlQ0J5WVhSbEp5azdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QjBZWGhCZFhSb2IzSnBkSGtnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMFlYaEJkWFJvYjNKcGRIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlQU0IwYUdsekxuUmhlRUYxZEdodmNtbDBlUzUyWVd4MVpTd2dKMDl1YkhrZ2RHRjRJR0YxZEdodmNtbDBlU0JqWVc0Z2RYQmtZWFJsSUhSaGVDQnlZWFJsSnlrN0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHRjRJR0YxZEdodmNtbDBlU0JqWVc0Z2RYQmtZWFJsSUhSaGVDQnlZWFJsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGQxSmhkR1ZDY0hNZ1BpQXdJQ1ltSUc1bGQxSmhkR1ZDY0hNZ1BEMGdNVEF3TURBc0lDZFVZWGdnY21GMFpTQnRkWE4wSUdKbElHSmxkSGRsWlc0Z01TQmhibVFnTVRBd01EQWdZbUZ6YVhNZ2NHOXBiblJ6SUNnd0xqQXhKU0IwYnlBeE1EQWxLU2NwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllaUIxY0dSaGRHVlVZWGhTWVhSbFgySnZiMnhmWm1Gc2MyVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREFLSUNBZ0lEdzlDaUFnSUNCaWVpQjFjR1JoZEdWVVlYaFNZWFJsWDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuVndaR0YwWlZSaGVGSmhkR1ZmWW05dmJGOXRaWEpuWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGRTWVhSbFFuQnpJRDRnTUNBbUppQnVaWGRTWVhSbFFuQnpJRHc5SURFd01EQXdMQ0FuVkdGNElISmhkR1VnYlhWemRDQmlaU0JpWlhSM1pXVnVJREVnWVc1a0lERXdNREF3SUdKaGMybHpJSEJ2YVc1MGN5QW9NQzR3TVNVZ2RHOGdNVEF3SlNrbktUc0tJQ0FnSUdGemMyVnlkQ0F2THlCVVlYZ2djbUYwWlNCdGRYTjBJR0psSUdKbGRIZGxaVzRnTVNCaGJtUWdNVEF3TURBZ1ltRnphWE1nY0c5cGJuUnpJQ2d3TGpBeEpTQjBieUF4TURBbEtRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJSFJoZUZKaGRHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJRUpoYzJseklIQnZhVzUwY3lBb1pTNW5MaXdnTVRBd01DQTlJREV3SlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SaGVGSmhkR1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkR0Y0WDJOdmJYQnNhV0Z1WTJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU53b2dJQ0FnTHk4Z2RHaHBjeTUwWVhoU1lYUmxMblpoYkhWbElEMGdibVYzVW1GMFpVSndjenNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS2RYQmtZWFJsVkdGNFVtRjBaVjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUIxY0dSaGRHVlVZWGhTWVhSbFgySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWVhoRGIyMXdiR2xoYm1ObFEyOXVkSEpoWTNRdVoyVjBWRzkwWVd4RWFYTjBjbWxpZFhScGIyNXpLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUlViM1JoYkVScGMzUnlhV0oxZEdsdmJuTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnZEc5MFlXeEVhWE4wY21saWRYUnBiMjV6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzUkdsemRISnBZblYwYVc5dWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5SdmRHRnNSR2x6ZEhKcFluVjBhVzl1Y3k1MllXeDFaVHNLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBZWGhmWTI5dGNHeHBZVzVqWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVlYaERiMjF3YkdsaGJtTmxRMjl1ZEhKaFkzUXVaMlYwVkc5MFlXeFVZWGhEYjJ4c1pXTjBaV1FvS1NBdFBpQjFhVzUwTmpRNkNtZGxkRlJ2ZEdGc1ZHRjRRMjlzYkdWamRHVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhSdmRHRnNWR0Y0UTI5c2JHVmpkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZkR0ZzVkdGNFEyOXNiR1ZqZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNd29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeFVZWGhEYjJ4c1pXTjBaV1F1ZG1Gc2RXVTdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkdGNFEyOXRjR3hwWVc1alpVTnZiblJ5WVdOMExtZGxkRlJoZUZKaGRHVW9LU0F0UGlCMWFXNTBOalE2Q21kbGRGUmhlRkpoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEdGNFgyTnZiWEJzYVdGdVkyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdkR0Y0VW1GMFpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdRbUZ6YVhNZ2NHOXBiblJ6SUNobExtY3VMQ0F4TURBd0lEMGdNVEFsS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJoZUZKaGRHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MFlYaFNZWFJsTG5aaGJIVmxPd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSaGVFTnZiWEJzYVdGdVkyVkRiMjUwY21GamRDNW5aWFJEYjIxd2JHbGhibU5sVTNSaGRIVnpLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUkRiMjF3YkdsaGJtTmxVM1JoZEhWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSaGVGOWpiMjF3YkdsaGJtTmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR052YlhCc2FXRnVZMlZUZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJREE5Ym05dUxXTnZiWEJzYVdGdWRDd2dNVDFqYjIxd2JHbGhiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmpiMjF3YkdsaGJtTmxVM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WTI5dGNHeHBZVzVqWlZOMFlYUjFjeTUyWVd4MVpUc0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MFlYaGZZMjl0Y0d4cFlXNWpaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBVWVhoRGIyMXdiR2xoYm1ObFEyOXVkSEpoWTNRdVkyRnNZM1ZzWVhSbFZHRjRLR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbU5oYkdOMWJHRjBaVlJoZURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwWVhoZlkyOXRjR3hwWVc1alpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpOUzB4TXpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQXZMeUJqWVd4amRXeGhkR1ZVWVhnb1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMWFXNTBOalFnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHRjRYMk52YlhCc2FXRnVZMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnZEdGNFVtRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnUW1GemFYTWdjRzlwYm5SeklDaGxMbWN1TENBeE1EQXdJRDBnTVRBbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SaGVGSmhkR1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUmhlRjlqYjIxd2JHbGhibU5sTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNM0NpQWdJQ0F2THlCeVpYUjFjbTRnS0dGdGIzVnVkQ0FxSUhSb2FYTXVkR0Y0VW1GMFpTNTJZV3gxWlNrZ0x5QXhNREF3TURzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklERXdNREF3Q2lBZ0lDQXZDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFHUVRpWUhESFJoZUVGMWRHaHZjbWwwZVFRVkgzeDFCM1JoZUZKaGRHVVNkRzkwWVd4RWFYTjBjbWxpZFhScGIyNXpFWFJ2ZEdGc1ZHRjRRMjlzYkdWamRHVmtFR052YlhCc2FXRnVZMlZUZEdGMGRYTU9iR0Z6ZEZKbGNHOXlkRVJoZEdVeEcwRUJLSUlMQk1pdEU3OEVoQ2FGa0FSaW8zV3BCQnEwQk1RRXdZODMzZ1RoNWV6aUJOVXdqVWtFVlRSSEd3UlhCRHJXQkgxeEEwY0U0SU9MdWpZYUFJNExBTG9BcUFDU0FJWUFkZ0JsQUZRQVF3QXlBQjBBQWlKRE1Sa1VSREVZUkRZYUFWY0NBRWtWRmxjR0FreFFLVXhRc0NORE1Sa1VSREVZUkRZYUFSZUlBWW9XS1V4UXNDTkRNUmtVUkRFWVJJZ0JjeFlwVEZDd0kwTXhHUlJFTVJoRWlBRmRGaWxNVUxBalF6RVpGRVF4R0VTSUFVWVdLVXhRc0NORE1Sa1VSREVZUklnQk1CWXBURkN3STBNeEdSUkVNUmhFTmhvQkY0Z0ErU05ETVJrVVJERVlSSWdBM0NORE1Sa1VSREVZUkRZYUFSYzJHZ0pYQWdDSUFKMGpRekVaRkVReEdFUTJHZ0ZYQWdDSUFHOGpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVhOaG9ERjRnQURTTkRNUmxBL3ljeEdCUkVJME9LQXdDTC9SVkVpLzVFaS85QkFEV0wveVFPUVFBdUkwUW9pLzFuZ0E5eVpYQnZjblJwYm1kUVpYSnBiMlNML21jbkJpSm5LeUpuSndRaVp5cUwvMmNuQlNObmlTSkMvOCtLQVFBeEFDSW9aVVFTUkl2L0ZVUWlLR1ZFaS84VFJDaUwvMmVKaWdJQU1RQWlLR1ZFRWtRaUsyVkVpLzRJSzB4bklpcGxSSXYrQ3lRS0lpY0VaVVFJSndSTVo0a3hBQ0lvWlVRU1JDY0dJbWNuQlNObmlZb0JBREVBSWlobFJCSkVpLzlCQUE2TC95UU9RUUFISTBRcWkvOW5pU0pDLy9ZaUsyVkVpU0luQkdWRWlTSXFaVVNKSWljRlpVU0ppZ0VCSWlwbFJJdi9DeVFLaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
