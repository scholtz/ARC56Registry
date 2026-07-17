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

namespace Arc56.Generated.harsh_a_parihar.Hackpay.ReputationSystemContract_0ecb1d6c
{


    //
    // Reputation System Contract
    //Handles organizer reputation tracking and ratings
    //
    public class ReputationSystemContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReputationSystemContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the reputation system
        ///PRODUCTION READY: Configurable system owner with proper validation
        ///</summary>
        /// <param name="threshold"> </param>
        /// <param name="systemOwnerAddress"> </param>
        public async Task Initialize(ulong threshold, byte[] systemOwnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 128, 117, 64 };
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var systemOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); systemOwnerAddressAbi.From(systemOwnerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, thresholdAbi, systemOwnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(ulong threshold, byte[] systemOwnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 128, 117, 64 };
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var systemOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); systemOwnerAddressAbi.From(systemOwnerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, thresholdAbi, systemOwnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Change system owner (governance)
        ///PRODUCTION READY: Allows authority transfer for governance
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task ChangeSystemOwner(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 162, 112, 208 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeSystemOwner_Transactions(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 162, 112, 208 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update reputation threshold (owner only)
        ///PRODUCTION READY: Allows threshold updates with validation
        ///</summary>
        /// <param name="newThreshold"> </param>
        public async Task UpdateReputationThreshold(ulong newThreshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 137, 175, 182 };
            var newThresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newThresholdAbi.From(newThreshold);

            var result = await base.CallApp(new List<object> { abiHandle, newThresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateReputationThreshold_Transactions(ulong newThreshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 137, 175, 182 };
            var newThresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newThresholdAbi.From(newThreshold);

            return await base.MakeTransactionList(new List<object> { abiHandle, newThresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new organizer
        ///</summary>
        /// <param name="organizerAddress"> </param>
        public async Task RegisterOrganizer(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 143, 39, 171 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterOrganizer_Transactions(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 143, 39, 171 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit a rating for an organizer
        ///</summary>
        /// <param name="organizerAddress"> </param>
        /// <param name="rating"> </param>
        public async Task SubmitRating(byte[] organizerAddress, ulong rating, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 224, 91, 176 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);
            var ratingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ratingAbi.From(rating);

            var result = await base.CallApp(new List<object> { abiHandle, organizerAddressAbi, ratingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitRating_Transactions(byte[] organizerAddress, ulong rating, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 224, 91, 176 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);
            var ratingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ratingAbi.From(rating);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizerAddressAbi, ratingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Blacklist an organizer
        ///</summary>
        /// <param name="organizerAddress"> </param>
        public async Task BlacklistOrganizer(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 208, 235, 75 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BlacklistOrganizer_Transactions(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 208, 235, 75 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove organizer from blacklist
        ///</summary>
        /// <param name="organizerAddress"> </param>
        public async Task UnblacklistOrganizer(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 241, 114, 56 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnblacklistOrganizer_Transactions(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 241, 114, 56 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if organizer is blacklisted
        ///</summary>
        /// <param name="organizerAddress"> </param>
        public async Task<ulong> IsBlacklisted(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 87, 254, 145 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            var result = await base.SimApp(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBlacklisted_Transactions(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 87, 254, 145 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get average rating
        ///</summary>
        public async Task<ulong> GetAverageRating(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 206, 127, 42 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAverageRating_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 206, 127, 42 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total organizers count
        ///</summary>
        public async Task<ulong> GetTotalOrganizers(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 228, 241, 141 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalOrganizers_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 228, 241, 141 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total ratings count
        ///</summary>
        public async Task<ulong> GetTotalRatings(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 65, 156, 2 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalRatings_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 65, 156, 2 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get reputation threshold
        ///</summary>
        public async Task<ulong> GetReputationThreshold(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 30, 227, 205 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetReputationThreshold_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 30, 227, 205 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if organizer meets reputation threshold
        ///</summary>
        /// <param name="organizerAddress"> </param>
        public async Task<ulong> MeetsThreshold(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 203, 48, 142 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            var result = await base.SimApp(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MeetsThreshold_Transactions(byte[] organizerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 203, 48, 142 };
            var organizerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); organizerAddressAbi.From(organizerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwdXRhdGlvblN5c3RlbUNvbnRyYWN0IiwiZGVzYyI6IlJlcHV0YXRpb24gU3lzdGVtIENvbnRyYWN0XG5IYW5kbGVzIG9yZ2FuaXplciByZXB1dGF0aW9uIHRyYWNraW5nIGFuZCByYXRpbmdzIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgcmVwdXRhdGlvbiBzeXN0ZW1cblBST0RVQ1RJT04gUkVBRFk6IENvbmZpZ3VyYWJsZSBzeXN0ZW0gb3duZXIgd2l0aCBwcm9wZXIgdmFsaWRhdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aHJlc2hvbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5c3RlbU93bmVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGFuZ2VTeXN0ZW1Pd25lciIsImRlc2MiOiJDaGFuZ2Ugc3lzdGVtIG93bmVyIChnb3Zlcm5hbmNlKVxuUFJPRFVDVElPTiBSRUFEWTogQWxsb3dzIGF1dGhvcml0eSB0cmFuc2ZlciBmb3IgZ292ZXJuYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVSZXB1dGF0aW9uVGhyZXNob2xkIiwiZGVzYyI6IlVwZGF0ZSByZXB1dGF0aW9uIHRocmVzaG9sZCAob3duZXIgb25seSlcblBST0RVQ1RJT04gUkVBRFk6IEFsbG93cyB0aHJlc2hvbGQgdXBkYXRlcyB3aXRoIHZhbGlkYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VGhyZXNob2xkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyT3JnYW5pemVyIiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IG9yZ2FuaXplciIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmdhbml6ZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdFJhdGluZyIsImRlc2MiOiJTdWJtaXQgYSByYXRpbmcgZm9yIGFuIG9yZ2FuaXplciIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmdhbml6ZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyYXRpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmxhY2tsaXN0T3JnYW5pemVyIiwiZGVzYyI6IkJsYWNrbGlzdCBhbiBvcmdhbml6ZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bmJsYWNrbGlzdE9yZ2FuaXplciIsImRlc2MiOiJSZW1vdmUgb3JnYW5pemVyIGZyb20gYmxhY2tsaXN0IiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZ2FuaXplckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNCbGFja2xpc3RlZCIsImRlc2MiOiJDaGVjayBpZiBvcmdhbml6ZXIgaXMgYmxhY2tsaXN0ZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemVyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QXZlcmFnZVJhdGluZyIsImRlc2MiOiJHZXQgYXZlcmFnZSByYXRpbmciLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRvdGFsT3JnYW5pemVycyIsImRlc2MiOiJHZXQgdG90YWwgb3JnYW5pemVycyBjb3VudCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxSYXRpbmdzIiwiZGVzYyI6IkdldCB0b3RhbCByYXRpbmdzIGNvdW50IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZXB1dGF0aW9uVGhyZXNob2xkIiwiZGVzYyI6IkdldCByZXB1dGF0aW9uIHRocmVzaG9sZCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWVldHNUaHJlc2hvbGQiLCJkZXNjIjoiQ2hlY2sgaWYgb3JnYW5pemVyIG1lZXRzIHJlcHV0YXRpb24gdGhyZXNob2xkIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZ2FuaXplckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImhlbGxvIiwiZGVzYyI6IkhlbGxvIG1ldGhvZCBmb3IgdGVzdGluZyIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU1MV0sImVycm9yTWVzc2FnZSI6Ik5ldyBvd25lciBhZGRyZXNzIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1OV0sImVycm9yTWVzc2FnZSI6Ik5ldyBvd25lciBtdXN0IGJlIGRpZmZlcmVudCBmcm9tIGN1cnJlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjQsMjUxLDI3NSwyOTIsMzA5LDMyNiwzNDMsMzY3LDM4NSw0MDMsNDI1LDQ0Myw0NTksNDc3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjdXJyZW50IHN5c3RlbSBvd25lciBjYW4gY2hhbmdlIG93bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjcwXSwiZXJyb3JNZXNzYWdlIjoiT25seSBzeXN0ZW0gb3duZXIgY2FuIGJsYWNrbGlzdCBvcmdhbml6ZXJzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBzeXN0ZW0gb3duZXIgY2FuIHJlZ2lzdGVyIG9yZ2FuaXplcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHN5c3RlbSBvd25lciBjYW4gdW5ibGFja2xpc3Qgb3JnYW5pemVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgc3lzdGVtIG93bmVyIGNhbiB1cGRhdGUgdGhyZXNob2xkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIzXSwiZXJyb3JNZXNzYWdlIjoiUmF0aW5nIG11c3QgYmUgYmV0d2VlbiAxIGFuZCA1IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE2LDU3OF0sImVycm9yTWVzc2FnZSI6IlJlcHV0YXRpb24gdGhyZXNob2xkIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTNdLCJlcnJvck1lc3NhZ2UiOiJTeXN0ZW0gb3duZXIgYWRkcmVzcyBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDRdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjcsMjU0LDI3OCwyOTUsMzEyLDMyOSwzNDYsMzcwLDM4OCw0MDYsNDI4LDQ0Niw0NjIsNDgwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NSw1NTUsNTczLDU5Myw1OTksNjI4LDYzMiw2MzcsNjQ5LDY2OCw2NzUsNjkyLDcwMCw3MDUsNzEwLDcxNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKemVYTjBaVzFQZDI1bGNpSWdJblJ2ZEdGc1VtRjBhVzVuY3lJZ01IZ3hOVEZtTjJNM05TQWlkRzkwWVd4UGNtZGhibWw2WlhKeklpQWlZWFpsY21GblpWSmhkR2x1WnlJZ0luSmxjSFYwWVhScGIyNVVhSEpsYzJodmJHUWlJQ0ppYkdGamEyeHBjM1JsWkU5eVoyRnVhWHBsY25NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VtVndkWFJoZEdsdmJsTjVjM1JsYlVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFptUTRNRGMxTkRBZ01IZ3lOR0V5TnpCa01DQXdlRGRoT0RsaFptSTJJREI0WkRnNFpqSTNZV0lnTUhnM09XVXdOV0ppTUNBd2VEWTFaREJsWWpSaUlEQjRaV0ptTVRjeU16Z2dNSGhtWVRVM1ptVTVNU0F3ZURRNVkyVTNaakpoSURCNE1HTmxOR1l4T0dRZ01IZzJOVFF4T1dNd01pQXdlR0V3TVdWbE0yTmtJREI0Wm1KallqTXdPR1VnTUhobE1EZ3pPR0ppWVNBdkx5QnRaWFJvYjJRZ0ltbHVhWFJwWVd4cGVtVW9kV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0pqYUdGdVoyVlRlWE4wWlcxUGQyNWxjaWhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsVW1Wd2RYUmhkR2x2YmxSb2NtVnphRzlzWkNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSlBjbWRoYm1sNlpYSW9ZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5OMVltMXBkRkpoZEdsdVp5aGllWFJsVzEwc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUpzWVdOcmJHbHpkRTl5WjJGdWFYcGxjaWhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWRXNWliR0ZqYTJ4cGMzUlBjbWRoYm1sNlpYSW9ZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1selFteGhZMnRzYVhOMFpXUW9ZbmwwWlZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRWFpsY21GblpWSmhkR2x1WnlncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUlViM1JoYkU5eVoyRnVhWHBsY25Nb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBWRzkwWVd4U1lYUnBibWR6S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGSmxjSFYwWVhScGIyNVVhSEpsYzJodmJHUW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWliV1ZsZEhOVWFISmxjMmh2YkdRb1lubDBaVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYUdWc2JHOG9ZbmwwWlZ0ZEtXSjVkR1ZiWFNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmYVc1cGRHbGhiR2w2WlY5eWIzVjBaVUF6SUcxaGFXNWZZMmhoYm1kbFUzbHpkR1Z0VDNkdVpYSmZjbTkxZEdWQU5DQnRZV2x1WDNWd1pHRjBaVkpsY0hWMFlYUnBiMjVVYUhKbGMyaHZiR1JmY205MWRHVkFOU0J0WVdsdVgzSmxaMmx6ZEdWeVQzSm5ZVzVwZW1WeVgzSnZkWFJsUURZZ2JXRnBibDl6ZFdKdGFYUlNZWFJwYm1kZmNtOTFkR1ZBTnlCdFlXbHVYMkpzWVdOcmJHbHpkRTl5WjJGdWFYcGxjbDl5YjNWMFpVQTRJRzFoYVc1ZmRXNWliR0ZqYTJ4cGMzUlBjbWRoYm1sNlpYSmZjbTkxZEdWQU9TQnRZV2x1WDJselFteGhZMnRzYVhOMFpXUmZjbTkxZEdWQU1UQWdiV0ZwYmw5blpYUkJkbVZ5WVdkbFVtRjBhVzVuWDNKdmRYUmxRREV4SUcxaGFXNWZaMlYwVkc5MFlXeFBjbWRoYm1sNlpYSnpYM0p2ZFhSbFFERXlJRzFoYVc1ZloyVjBWRzkwWVd4U1lYUnBibWR6WDNKdmRYUmxRREV6SUcxaGFXNWZaMlYwVW1Wd2RYUmhkR2x2YmxSb2NtVnphRzlzWkY5eWIzVjBaVUF4TkNCdFlXbHVYMjFsWlhSelZHaHlaWE5vYjJ4a1gzSnZkWFJsUURFMUlHMWhhVzVmYUdWc2JHOWZjbTkxZEdWQU1UWUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCU1pYQjFkR0YwYVc5dVUzbHpkR1Z0UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURFMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVW1Wd2RYUmhkR2x2YmxONWMzUmxiVU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM013b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjFsWlhSelZHaHlaWE5vYjJ4a1gzSnZkWFJsUURFMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlNaWEIxZEdGMGFXOXVWR2h5WlhOb2IyeGtYM0p2ZFhSbFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEZKbGNIVjBZWFJwYjI1VWFISmxjMmh2YkdRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFZHOTBZV3hTWVhScGJtZHpYM0p2ZFhSbFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEZSdmRHRnNVbUYwYVc1bmN3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlViM1JoYkU5eVoyRnVhWHBsY25OZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBWRzkwWVd4UGNtZGhibWw2WlhKekNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRFRjJaWEpoWjJWU1lYUnBibWRmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFFYWmxjbUZuWlZKaGRHbHVad29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjMEpzWVdOcmJHbHpkR1ZrWDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxYm1Kc1lXTnJiR2x6ZEU5eVoyRnVhWHBsY2w5eWIzVjBaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVbVZ3ZFhSaGRHbHZibE41YzNSbGJVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2RXNWliR0ZqYTJ4cGMzUlBjbWRoYm1sNlpYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllteGhZMnRzYVhOMFQzSm5ZVzVwZW1WeVgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkpsY0hWMFlYUnBiMjVUZVhOMFpXMURiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lteGhZMnRzYVhOMFQzSm5ZVzVwZW1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOMVltMXBkRkpoZEdsdVoxOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJTWlhCMWRHRjBhVzl1VTNsemRHVnRRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlITjFZbTFwZEZKaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV2RwYzNSbGNrOXlaMkZ1YVhwbGNsOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJTWlhCMWRHRjBhVzl1VTNsemRHVnRRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlISmxaMmx6ZEdWeVQzSm5ZVzVwZW1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWd1pHRjBaVkpsY0hWMFlYUnBiMjVVYUhKbGMyaHZiR1JmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VtVndkWFJoZEdsdmJsTjVjM1JsYlVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVkpsY0hWMFlYUnBiMjVVYUhKbGMyaHZiR1FLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMmhoYm1kbFUzbHpkR1Z0VDNkdVpYSmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVW1Wd2RYUmhkR2x2YmxONWMzUmxiVU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmphR0Z1WjJWVGVYTjBaVzFQZDI1bGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5cGJtbDBhV0ZzYVhwbFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkpsY0hWMFlYUnBiMjVUZVhOMFpXMURiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2FXNXBkR2xoYkdsNlpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVW1Wd2RYUmhkR2x2YmxONWMzUmxiVU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU13b2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVZ3ZFhSaGRHbHZibE41YzNSbGJVTnZiblJ5WVdOMExtbHVhWFJwWVd4cGVtVW9kR2h5WlhOb2IyeGtPaUIxYVc1ME5qUXNJSE41YzNSbGJVOTNibVZ5UVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbWx1YVhScFlXeHBlbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNQzB5TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVVvQ2lBZ0lDQXZMeUFnSUhSb2NtVnphRzlzWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCemVYTjBaVzFQZDI1bGNrRmtaSEpsYzNNNklHSjVkR1Z6Q2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdGemMyVnlkQ2h6ZVhOMFpXMVBkMjVsY2tGa1pISmxjM011YkdWdVozUm9JRDRnTUN3Z0oxTjVjM1JsYlNCdmQyNWxjaUJoWkdSeVpYTnpJR05oYm01dmRDQmlaU0JsYlhCMGVTY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCVGVYTjBaVzBnYjNkdVpYSWdZV1JrY21WemN5QmpZVzV1YjNRZ1ltVWdaVzF3ZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2h5WlhOb2IyeGtJRDRnTUN3Z0oxSmxjSFYwWVhScGIyNGdkR2h5WlhOb2IyeGtJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhOelpYSjBJQzh2SUZKbGNIVjBZWFJwYjI0Z2RHaHlaWE5vYjJ4a0lHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklITjVjM1JsYlU5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemVYTjBaVzFQZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCMGFHbHpMbk41YzNSbGJVOTNibVZ5TG5aaGJIVmxJRDBnYzNsemRHVnRUM2R1WlhKQlpHUnlaWE56T3lBdkx5QkRiMjVtYVdkMWNtRmliR1VnYjNkdVpYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCMGIzUmhiRTl5WjJGdWFYcGxjbk1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkU5eVoyRnVhWHBsY25NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkU5eVoyRnVhWHBsY25NdWRtRnNkV1VnUFNBd093b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnWVhabGNtRm5aVkpoZEdsdVp5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdVMk5oYkdWa0lHSjVJREV3TUNBb1pTNW5MaXdnTkRVd0lEMGdOQzQxSUhOMFlYSnpLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZWFpsY21GblpWSmhkR2x1WnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUIwYUdsekxtRjJaWEpoWjJWU1lYUnBibWN1ZG1Gc2RXVWdQU0F3T3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdkRzkwWVd4U1lYUnBibWR6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4U1lYUnBibWR6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hTWVhScGJtZHpMblpoYkhWbElEMGdNRHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklISmxjSFYwWVhScGIyNVVhSEpsYzJodmJHUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJRTFwYm1sdGRXMGdjbVZ3ZFhSaGRHbHZiaUIwYnlCd1lYSjBhV05wY0dGMFpRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNtVndkWFJoZEdsdmJsUm9jbVZ6YUc5c1pDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCMGFHbHpMbkpsY0hWMFlYUnBiMjVVYUhKbGMyaHZiR1F1ZG1Gc2RXVWdQU0IwYUhKbGMyaHZiR1E3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVZ3ZFhSaGRHbHZibE41YzNSbGJVTnZiblJ5WVdOMExtTm9ZVzVuWlZONWMzUmxiVTkzYm1WeUtHNWxkMDkzYm1WeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1kyaGhibWRsVTNsemRHVnRUM2R1WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVMwME5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdOb1lXNW5aVk41YzNSbGJVOTNibVZ5S0FvZ0lDQWdMeThnSUNCdVpYZFBkMjVsY2pvZ1lubDBaWE1LSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUhSb2FYTXVjM2x6ZEdWdFQzZHVaWEl1ZG1Gc2RXVXNJQ2RQYm14NUlHTjFjbkpsYm5RZ2MzbHpkR1Z0SUc5M2JtVnlJR05oYmlCamFHRnVaMlVnYjNkdVpYSW5LVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhONWMzUmxiVTkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM2x6ZEdWdFQzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOVBTQjBhR2x6TG5ONWMzUmxiVTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0JqZFhKeVpXNTBJSE41YzNSbGJTQnZkMjVsY2lCallXNGdZMmhoYm1kbElHOTNibVZ5SnlrN0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzVnljbVZ1ZENCemVYTjBaVzBnYjNkdVpYSWdZMkZ1SUdOb1lXNW5aU0J2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkUGQyNWxjaTVzWlc1bmRHZ2dQaUF3TENBblRtVjNJRzkzYm1WeUlHRmtaSEpsYzNNZ1kyRnVibTkwSUdKbElHVnRjSFI1SnlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJRTVsZHlCdmQyNWxjaUJoWkdSeVpYTnpJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnYzNsemRHVnRUM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhpZVhSbGN6NG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnplWE4wWlcxUGQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z1lYTnpaWEowS0c1bGQwOTNibVZ5SUNFOVBTQjBhR2x6TG5ONWMzUmxiVTkzYm1WeUxuWmhiSFZsTENBblRtVjNJRzkzYm1WeUlHMTFjM1FnWW1VZ1pHbG1abVZ5Wlc1MElHWnliMjBnWTNWeWNtVnVkQ2NwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFNWxkeUJ2ZDI1bGNpQnRkWE4wSUdKbElHUnBabVpsY21WdWRDQm1jbTl0SUdOMWNuSmxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklITjVjM1JsYlU5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemVYTjBaVzFQZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCMGFHbHpMbk41YzNSbGJVOTNibVZ5TG5aaGJIVmxJRDBnYm1WM1QzZHVaWEk3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVbVZ3ZFhSaGRHbHZibE41YzNSbGJVTnZiblJ5WVdOMExuVndaR0YwWlZKbGNIVjBZWFJwYjI1VWFISmxjMmh2YkdRb2JtVjNWR2h5WlhOb2IyeGtPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblZ3WkdGMFpWSmxjSFYwWVhScGIyNVVhSEpsYzJodmJHUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5pMDFPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIVndaR0YwWlZKbGNIVjBZWFJwYjI1VWFISmxjMmh2YkdRb0NpQWdJQ0F2THlBZ0lHNWxkMVJvY21WemFHOXNaRG9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlQU0IwYUdsekxuTjVjM1JsYlU5M2JtVnlMblpoYkhWbExDQW5UMjVzZVNCemVYTjBaVzBnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0IwYUhKbGMyaHZiR1FuS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklITjVjM1JsYlU5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNsemRHVnRUM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlQU0IwYUdsekxuTjVjM1JsYlU5M2JtVnlMblpoYkhWbExDQW5UMjVzZVNCemVYTjBaVzBnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0IwYUhKbGMyaHZiR1FuS1RzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCemVYTjBaVzBnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0IwYUhKbGMyaHZiR1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNWR2h5WlhOb2IyeGtJRDRnTUN3Z0oxSmxjSFYwWVhScGIyNGdkR2h5WlhOb2IyeGtJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhOelpYSjBJQzh2SUZKbGNIVjBZWFJwYjI0Z2RHaHlaWE5vYjJ4a0lHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QnlaWEIxZEdGMGFXOXVWR2h5WlhOb2IyeGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJOYVc1cGJYVnRJSEpsY0hWMFlYUnBiMjRnZEc4Z2NHRnlkR2xqYVhCaGRHVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luSmxjSFYwWVhScGIyNVVhSEpsYzJodmJHUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z2RHaHBjeTV5WlhCMWRHRjBhVzl1VkdoeVpYTm9iMnhrTG5aaGJIVmxJRDBnYm1WM1ZHaHlaWE5vYjJ4a093b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xKbGNIVjBZWFJwYjI1VGVYTjBaVzFEYjI1MGNtRmpkQzV5WldkcGMzUmxjazl5WjJGdWFYcGxjaWh2Y21kaGJtbDZaWEpCWkdSeVpYTnpPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSlBjbWRoYm1sNlpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9TMDNNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklISmxaMmx6ZEdWeVQzSm5ZVzVwZW1WeUtBb2dJQ0FnTHk4Z0lDQnZjbWRoYm1sNlpYSkJaR1J5WlhOek9pQmllWFJsY3dvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTV6ZVhOMFpXMVBkMjVsY2k1MllXeDFaU3dnSjA5dWJIa2djM2x6ZEdWdElHOTNibVZ5SUdOaGJpQnlaV2RwYzNSbGNpQnZjbWRoYm1sNlpYSnpKeWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCemVYTjBaVzFQZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk41YzNSbGJVOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1emVYTjBaVzFQZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnYzNsemRHVnRJRzkzYm1WeUlHTmhiaUJ5WldkcGMzUmxjaUJ2Y21kaGJtbDZaWEp6SnlrN0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2MzbHpkR1Z0SUc5M2JtVnlJR05oYmlCeVpXZHBjM1JsY2lCdmNtZGhibWw2WlhKekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnZEc5MFlXeFBjbWRoYm1sNlpYSnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNUM0puWVc1cGVtVnljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFOXlaMkZ1YVhwbGNuTXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNUM0puWVc1cGVtVnljeTUyWVd4MVpTQXJJREU3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUhSdmRHRnNUM0puWVc1cGVtVnljeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzVDNKbllXNXBlbVZ5Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVDNKbllXNXBlbVZ5Y3k1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4UGNtZGhibWw2WlhKekxuWmhiSFZsSUNzZ01Uc0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVtVndkWFJoZEdsdmJsTjVjM1JsYlVOdmJuUnlZV04wTG5OMVltMXBkRkpoZEdsdVp5aHZjbWRoYm1sNlpYSkJaR1J5WlhOek9pQmllWFJsY3l3Z2NtRjBhVzVuT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25OMVltMXBkRkpoZEdsdVp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneExUZzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2MzVmliV2wwVW1GMGFXNW5LQW9nSUNBZ0x5OGdJQ0J2Y21kaGJtbDZaWEpCWkdSeVpYTnpPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdjbUYwYVc1bk9pQjFhVzUwTmpRS0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hKaGRHbHVaeUErUFNBeElDWW1JSEpoZEdsdVp5QThQU0ExTENBblVtRjBhVzVuSUcxMWMzUWdZbVVnWW1WMGQyVmxiaUF4SUdGdVpDQTFKeWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjZJSE4xWW0xcGRGSmhkR2x1WjE5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0ExSUM4dklEVUtJQ0FnSUR3OUNpQWdJQ0JpZWlCemRXSnRhWFJTWVhScGJtZGZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYzNWaWJXbDBVbUYwYVc1blgySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QmhjM05sY25Rb2NtRjBhVzVuSUQ0OUlERWdKaVlnY21GMGFXNW5JRHc5SURVc0lDZFNZWFJwYm1jZ2JYVnpkQ0JpWlNCaVpYUjNaV1Z1SURFZ1lXNWtJRFVuS1RzS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWVhScGJtY2diWFZ6ZENCaVpTQmlaWFIzWldWdUlERWdZVzVrSURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJoZG1WeVlXZGxVbUYwYVc1bklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3lBdkx5QlRZMkZzWldRZ1lua2dNVEF3SUNobExtY3VMQ0EwTlRBZ1BTQTBMalVnYzNSaGNuTXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlYWmxjbUZuWlZKaGRHbHVaeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2RHOTBZV3hTWVhScGJtZHpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNVbUYwYVc1bmN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnWTI5dWMzUWdZM1Z5Y21WdWRGUnZkR0ZzT2lCMWFXNTBOalFnUFNCMGFHbHpMbUYyWlhKaFoyVlNZWFJwYm1jdWRtRnNkV1VnS2lCMGFHbHpMblJ2ZEdGc1VtRjBhVzVuY3k1MllXeDFaVHNLSUNBZ0lDb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCMGIzUmhiRkpoZEdsdVozTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeFNZWFJwYm1keklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVW1GMGFXNW5jeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hTWVhScGJtZHpMblpoYkhWbElDc2dNVHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnZEc5MFlXeFNZWFJwYm1keklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeFNZWFJwYm1keklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RBS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4U1lYUnBibWR6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkZKaGRHbHVaM011ZG1Gc2RXVWdLeUF4T3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUIwYUdsekxtRjJaWEpoWjJWU1lYUnBibWN1ZG1Gc2RXVWdQU0FvWTNWeWNtVnVkRlJ2ZEdGc0lDc2djbUYwYVc1bktTQXZJSFJvYVhNdWRHOTBZV3hTWVhScGJtZHpMblpoYkhWbE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3ZFhSaGRHbHZibDl6ZVhOMFpXMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdkRzkwWVd4U1lYUnBibWR6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzVW1GMGFXNW5jeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z2RHaHBjeTVoZG1WeVlXZGxVbUYwYVc1bkxuWmhiSFZsSUQwZ0tHTjFjbkpsYm5SVWIzUmhiQ0FySUhKaGRHbHVaeWtnTHlCMGFHbHpMblJ2ZEdGc1VtRjBhVzVuY3k1MllXeDFaVHNLSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCaGRtVnlZV2RsVW1GMGFXNW5JRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJUWTJGc1pXUWdZbmtnTVRBd0lDaGxMbWN1TENBME5UQWdQU0EwTGpVZ2MzUmhjbk1wQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poZG1WeVlXZGxVbUYwYVc1bklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUhSb2FYTXVZWFpsY21GblpWSmhkR2x1Wnk1MllXeDFaU0E5SUNoamRYSnlaVzUwVkc5MFlXd2dLeUJ5WVhScGJtY3BJQzhnZEdocGN5NTBiM1JoYkZKaGRHbHVaM011ZG1Gc2RXVTdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwemRXSnRhWFJTWVhScGJtZGZZbTl2YkY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdjM1ZpYldsMFVtRjBhVzVuWDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBTWlhCMWRHRjBhVzl1VTNsemRHVnRRMjl1ZEhKaFkzUXVZbXhoWTJ0c2FYTjBUM0puWVc1cGVtVnlLRzl5WjJGdWFYcGxja0ZrWkhKbGMzTTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGliR0ZqYTJ4cGMzUlBjbWRoYm1sNlpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU55MHhNREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmliR0ZqYTJ4cGMzUlBjbWRoYm1sNlpYSW9DaUFnSUNBdkx5QWdJRzl5WjJGdWFYcGxja0ZrWkhKbGMzTTZJR0o1ZEdWekNpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXhDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1emVYTjBaVzFQZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnYzNsemRHVnRJRzkzYm1WeUlHTmhiaUJpYkdGamEyeHBjM1FnYjNKbllXNXBlbVZ5Y3ljcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdjM2x6ZEdWdFQzZHVaWElnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemVYTjBaVzFQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbk41YzNSbGJVOTNibVZ5TG5aaGJIVmxMQ0FuVDI1c2VTQnplWE4wWlcwZ2IzZHVaWElnWTJGdUlHSnNZV05yYkdsemRDQnZjbWRoYm1sNlpYSnpKeWs3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnYzNsemRHVnRJRzkzYm1WeUlHTmhiaUJpYkdGamEyeHBjM1FnYjNKbllXNXBlbVZ5Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hWMFlYUnBiMjVmYzNsemRHVnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR0pzWVdOcmJHbHpkR1ZrVDNKbllXNXBlbVZ5Y3lBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpZ3BPeUF2THlCSVlYTm9JRzltSUdKc1lXTnJiR2x6ZEdWa0lHRmtaSEpsYzNObGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1Kc1lXTnJiR2x6ZEdWa1QzSm5ZVzVwZW1WeWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhSb2FYTXVZbXhoWTJ0c2FYTjBaV1JQY21kaGJtbDZaWEp6TG5aaGJIVmxJRDBnZEdocGN5NWliR0ZqYTJ4cGMzUmxaRTl5WjJGdWFYcGxjbk11ZG1Gc2RXVXVZMjl1WTJGMEtHOXlaMkZ1YVhwbGNrRmtaSEpsYzNNcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCaWJHRmphMnhwYzNSbFpFOXlaMkZ1YVhwbGNuTWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzZ0x5OGdTR0Z6YUNCdlppQmliR0ZqYTJ4cGMzUmxaQ0JoWkdSeVpYTnpaWE1LSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUpzWVdOcmJHbHpkR1ZrVDNKbllXNXBlbVZ5Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnZEdocGN5NWliR0ZqYTJ4cGMzUmxaRTl5WjJGdWFYcGxjbk11ZG1Gc2RXVWdQU0IwYUdsekxtSnNZV05yYkdsemRHVmtUM0puWVc1cGVtVnljeTUyWVd4MVpTNWpiMjVqWVhRb2IzSm5ZVzVwZW1WeVFXUmtjbVZ6Y3lrN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xKbGNIVjBZWFJwYjI1VGVYTjBaVzFEYjI1MGNtRmpkQzUxYm1Kc1lXTnJiR2x6ZEU5eVoyRnVhWHBsY2lodmNtZGhibWw2WlhKQlpHUnlaWE56T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZFc1aWJHRmphMnhwYzNSUGNtZGhibWw2WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURrdE1URXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2RXNWliR0ZqYTJ4cGMzUlBjbWRoYm1sNlpYSW9DaUFnSUNBdkx5QWdJRzl5WjJGdWFYcGxja0ZrWkhKbGMzTTZJR0o1ZEdWekNpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXpDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1emVYTjBaVzFQZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnYzNsemRHVnRJRzkzYm1WeUlHTmhiaUIxYm1Kc1lXTnJiR2x6ZENCdmNtZGhibWw2WlhKekp5azdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJ6ZVhOMFpXMVBkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjVjM1JsYlU5M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlIUm9hWE11YzNsemRHVnRUM2R1WlhJdWRtRnNkV1VzSUNkUGJteDVJSE41YzNSbGJTQnZkMjVsY2lCallXNGdkVzVpYkdGamEyeHBjM1FnYjNKbllXNXBlbVZ5Y3ljcE93b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlITjVjM1JsYlNCdmQyNWxjaUJqWVc0Z2RXNWliR0ZqYTJ4cGMzUWdiM0puWVc1cGVtVnljd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSFYwWVhScGIyNWZjM2x6ZEdWdEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sSmxjSFYwWVhScGIyNVRlWE4wWlcxRGIyNTBjbUZqZEM1blpYUkJkbVZ5WVdkbFVtRjBhVzVuS0NrZ0xUNGdkV2x1ZERZME9ncG5aWFJCZG1WeVlXZGxVbUYwYVc1bk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNIVjBZWFJwYjI1ZmMzbHpkR1Z0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUdGMlpYSmhaMlZTWVhScGJtY2dQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJRk5qWVd4bFpDQmllU0F4TURBZ0tHVXVaeTRzSURRMU1DQTlJRFF1TlNCemRHRnljeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhkbVZ5WVdkbFVtRjBhVzVuSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WVhabGNtRm5aVkpoZEdsdVp5NTJZV3gxWlRzS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBTWlhCMWRHRjBhVzl1VTNsemRHVnRRMjl1ZEhKaFkzUXVaMlYwVkc5MFlXeFBjbWRoYm1sNlpYSnpLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUlViM1JoYkU5eVoyRnVhWHBsY25NNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnZEc5MFlXeFBjbWRoYm1sNlpYSnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNUM0puWVc1cGVtVnljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMblJ2ZEdGc1QzSm5ZVzVwZW1WeWN5NTJZV3gxWlRzS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCMWRHRjBhVzl1WDNONWMzUmxiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBTWlhCMWRHRjBhVzl1VTNsemRHVnRRMjl1ZEhKaFkzUXVaMlYwVkc5MFlXeFNZWFJwYm1kektDa2dMVDRnZFdsdWREWTBPZ3BuWlhSVWIzUmhiRkpoZEdsdVozTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndkWFJoZEdsdmJsOXplWE4wWlcwdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2RHOTBZV3hTWVhScGJtZHpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNVbUYwYVc1bmN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2RYUmhkR2x2Ymw5emVYTjBaVzB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRBS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuUnZkR0ZzVW1GMGFXNW5jeTUyWVd4MVpUc0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwU1pYQjFkR0YwYVc5dVUzbHpkR1Z0UTI5dWRISmhZM1F1WjJWMFVtVndkWFJoZEdsdmJsUm9jbVZ6YUc5c1pDZ3BJQzArSUhWcGJuUTJORG9LWjJWMFVtVndkWFJoZEdsdmJsUm9jbVZ6YUc5c1pEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQjFkR0YwYVc5dVgzTjVjM1JsYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCeVpYQjFkR0YwYVc5dVZHaHlaWE5vYjJ4a0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3lBdkx5Qk5hVzVwYlhWdElISmxjSFYwWVhScGIyNGdkRzhnY0dGeWRHbGphWEJoZEdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p5WlhCMWRHRjBhVzl1VkdoeVpYTm9iMnhrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEIxZEdGMGFXOXVYM041YzNSbGJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Y21Wd2RYUmhkR2x2YmxSb2NtVnphRzlzWkM1MllXeDFaVHNLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1Cd3R6ZVhOMFpXMVBkMjVsY2d4MGIzUmhiRkpoZEdsdVozTUVGUjk4ZFE5MGIzUmhiRTl5WjJGdWFYcGxjbk1OWVhabGNtRm5aVkpoZEdsdVp4TnlaWEIxZEdGMGFXOXVWR2h5WlhOb2IyeGtGV0pzWVdOcmJHbHpkR1ZrVDNKbllXNXBlbVZ5Y3pFYlFRRitnZzRFL1lCMVFBUWtvbkRRQkhxSnI3WUUySThucXdSNTRGdXdCR1hRNjBzRTYvRnlPQVQ2Vi82UkJFbk9meW9FRE9UeGpRUmxRWndDQktBZTQ4MEUrOHN3amdUZ2c0dTZOaG9Bamc0QS93RHRBTjBBeXdDMUFLTUFrUUI1QUdnQVZ3QkdBRFVBSFFBQ0lrTXhHUlJFTVJoRU5ob0JWd0lBU1JVV1Z3WUNURkFxVEZDd0kwTXhHUlJFTVJoRWdBd1ZIM3gxQUFBQUFBQUFBQUd3STBNeEdSUkVNUmhFaUFHdUZpcE1VTEFqUXpFWkZFUXhHRVNJQVpnV0treFFzQ05ETVJrVVJERVlSSWdCZ2hZcVRGQ3dJME14R1JSRU1SaEVpQUZyRmlwTVVMQWpRekVaRkVReEdFU0FEQlVmZkhVQUFBQUFBQUFBQUxBalF6RVpGRVF4R0VRMkdnRlhBZ0NJQVRBalF6RVpGRVF4R0VRMkdnRlhBZ0NJQVFZalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dJWGlBQzZJME14R1JSRU1SaEVOaG9CVndJQWlBQ1RJME14R1JSRU1SaEVOaG9CRjRnQWJ5TkRNUmtVUkRFWVJEWWFBVmNDQUlnQVFTTkRNUmtVUkRFWVJEWWFBUmMyR2dKWEFnQ0lBQTBqUXpFWlFQN21NUmdVUkNORGlnSUFpLzhWUkl2K1JDaUwvMmNySW1jbkJDSm5LU0puSndXTC9tZUppZ0VBTVFBaUtHVkVFa1NML3hWRUlpaGxSSXYvRTBRb2kvOW5pWW9CQURFQUlpaGxSQkpFaS85RUp3V0wvMmVKaWdFQU1RQWlLR1ZFRWtRaUsyVkVJd2dyVEdlSmlnSUFpLzlCQUNxTC80RUZEa0VBSWlORUlpY0VaVVFpS1dWRUN5SXBaVVFqQ0NsTVo0di9DQ0lwWlVRS0p3Uk1aNGtpUXYvYmlnRUFNUUFpS0dWRUVrUWlKd1psUkl2L1VDY0dUR2VKaWdFQU1RQWlLR1ZFRWtTSklpY0VaVVNKSWl0bFJJa2lLV1ZFaVNJbkJXVkVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
