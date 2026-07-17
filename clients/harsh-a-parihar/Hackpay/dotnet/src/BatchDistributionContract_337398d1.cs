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

namespace Arc56.Generated.harsh_a_parihar.Hackpay.BatchDistributionContract_337398d1
{


    //
    // Batch Distribution Contract
    //Handles efficient batch processing for large winner lists
    //
    public class BatchDistributionContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BatchDistributionContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the batch distribution
        ///PRODUCTION READY: Configurable batch owner with proper validation
        ///</summary>
        /// <param name="parentAppId"> </param>
        /// <param name="batchNum"> </param>
        /// <param name="batchSize"> </param>
        /// <param name="batchOwnerAddress"> </param>
        public async Task Initialize(ulong parentAppId, ulong batchNum, ulong batchSize, byte[] batchOwnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 252, 194, 27 };
            var parentAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); parentAppIdAbi.From(parentAppId);
            var batchNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchNumAbi.From(batchNum);
            var batchSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchSizeAbi.From(batchSize);
            var batchOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); batchOwnerAddressAbi.From(batchOwnerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, parentAppIdAbi, batchNumAbi, batchSizeAbi, batchOwnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(ulong parentAppId, ulong batchNum, ulong batchSize, byte[] batchOwnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 252, 194, 27 };
            var parentAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); parentAppIdAbi.From(parentAppId);
            var batchNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchNumAbi.From(batchNum);
            var batchSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchSizeAbi.From(batchSize);
            var batchOwnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); batchOwnerAddressAbi.From(batchOwnerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, parentAppIdAbi, batchNumAbi, batchSizeAbi, batchOwnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Change batch owner (governance)
        ///PRODUCTION READY: Allows authority transfer for governance
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task ChangeBatchOwner(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 85, 95, 154 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ChangeBatchOwner_Transactions(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 85, 95, 154 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update batch size (owner only)
        ///PRODUCTION READY: Allows batch size updates with validation
        ///</summary>
        /// <param name="newBatchSize"> </param>
        public async Task UpdateBatchSize(ulong newBatchSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 177, 175, 95 };
            var newBatchSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newBatchSizeAbi.From(newBatchSize);

            var result = await base.CallApp(new List<object> { abiHandle, newBatchSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateBatchSize_Transactions(ulong newBatchSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 177, 175, 95 };
            var newBatchSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newBatchSizeAbi.From(newBatchSize);

            return await base.MakeTransactionList(new List<object> { abiHandle, newBatchSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Start processing the batch
        ///</summary>
        public async Task StartProcessing(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 243, 99, 171 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StartProcessing_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 243, 99, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Process a single item in the batch
        ///</summary>
        /// <param name="itemData"> </param>
        public async Task ProcessItem(byte[] itemData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 174, 78, 218 };
            var itemDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); itemDataAbi.From(itemData);

            var result = await base.CallApp(new List<object> { abiHandle, itemDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ProcessItem_Transactions(byte[] itemData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 174, 78, 218 };
            var itemDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); itemDataAbi.From(itemData);

            return await base.MakeTransactionList(new List<object> { abiHandle, itemDataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark batch as failed
        ///</summary>
        public async Task MarkFailed(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 162, 159, 24 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkFailed_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 162, 159, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get batch status
        ///</summary>
        public async Task<ulong> GetBatchStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 91, 59, 200 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBatchStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 91, 59, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total processed count
        ///</summary>
        public async Task<ulong> GetTotalProcessed(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 42, 2, 192 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalProcessed_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 42, 2, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get batch progress percentage
        ///</summary>
        public async Task<ulong> GetProgressPercentage(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 244, 185, 11 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetProgressPercentage_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 244, 185, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get parent distribution app ID
        ///</summary>
        public async Task<ulong> GetParentDistribution(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 153, 185, 84 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetParentDistribution_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 153, 185, 84 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmF0Y2hEaXN0cmlidXRpb25Db250cmFjdCIsImRlc2MiOiJCYXRjaCBEaXN0cmlidXRpb24gQ29udHJhY3RcbkhhbmRsZXMgZWZmaWNpZW50IGJhdGNoIHByb2Nlc3NpbmcgZm9yIGxhcmdlIHdpbm5lciBsaXN0cyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGJhdGNoIGRpc3RyaWJ1dGlvblxuUFJPRFVDVElPTiBSRUFEWTogQ29uZmlndXJhYmxlIGJhdGNoIG93bmVyIHdpdGggcHJvcGVyIHZhbGlkYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFyZW50QXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoTnVtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXRjaFNpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoT3duZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoYW5nZUJhdGNoT3duZXIiLCJkZXNjIjoiQ2hhbmdlIGJhdGNoIG93bmVyIChnb3Zlcm5hbmNlKVxuUFJPRFVDVElPTiBSRUFEWTogQWxsb3dzIGF1dGhvcml0eSB0cmFuc2ZlciBmb3IgZ292ZXJuYW5jZSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVCYXRjaFNpemUiLCJkZXNjIjoiVXBkYXRlIGJhdGNoIHNpemUgKG93bmVyIG9ubHkpXG5QUk9EVUNUSU9OIFJFQURZOiBBbGxvd3MgYmF0Y2ggc2l6ZSB1cGRhdGVzIHdpdGggdmFsaWRhdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdCYXRjaFNpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RhcnRQcm9jZXNzaW5nIiwiZGVzYyI6IlN0YXJ0IHByb2Nlc3NpbmcgdGhlIGJhdGNoIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2Nlc3NJdGVtIiwiZGVzYyI6IlByb2Nlc3MgYSBzaW5nbGUgaXRlbSBpbiB0aGUgYmF0Y2giLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbURhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya0ZhaWxlZCIsImRlc2MiOiJNYXJrIGJhdGNoIGFzIGZhaWxlZCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCYXRjaFN0YXR1cyIsImRlc2MiOiJHZXQgYmF0Y2ggc3RhdHVzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb3RhbFByb2Nlc3NlZCIsImRlc2MiOiJHZXQgdG90YWwgcHJvY2Vzc2VkIGNvdW50IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQcm9ncmVzc1BlcmNlbnRhZ2UiLCJkZXNjIjoiR2V0IGJhdGNoIHByb2dyZXNzIHBlcmNlbnRhZ2UiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBhcmVudERpc3RyaWJ1dGlvbiIsImRlc2MiOiJHZXQgcGFyZW50IGRpc3RyaWJ1dGlvbiBhcHAgSUQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImhlbGxvIiwiZGVzYyI6IkhlbGxvIG1ldGhvZCBmb3IgdGVzdGluZyIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUxM10sImVycm9yTWVzc2FnZSI6IkJhdGNoIG11c3QgYmUgaW4gY3JlYXRlZCBzdGF0dXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzVdLCJlcnJvck1lc3NhZ2UiOiJCYXRjaCBtdXN0IGJlIGluIHByb2Nlc3Npbmcgc3RhdHVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk4XSwiZXJyb3JNZXNzYWdlIjoiQmF0Y2ggbnVtYmVyIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDVdLCJlcnJvck1lc3NhZ2UiOiJCYXRjaCBvd25lciBhZGRyZXNzIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMSw0ODhdLCJlcnJvck1lc3NhZ2UiOiJCYXRjaCBzaXplIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTRdLCJlcnJvck1lc3NhZ2UiOiJDYW4gb25seSB1cGRhdGUgYmF0Y2ggc2l6ZSB3aGVuIGluIGNyZWF0ZWQgc3RhdHVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYxXSwiZXJyb3JNZXNzYWdlIjoiTmV3IG93bmVyIGFkZHJlc3MgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY5XSwiZXJyb3JNZXNzYWdlIjoiTmV3IG93bmVyIG11c3QgYmUgZGlmZmVyZW50IGZyb20gY3VycmVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MSwyMDgsMjI1LDI0MiwyNTksMjc2LDI4OCwzMDYsMzE4LDMzNCwzNTJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODNdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGJhdGNoIG93bmVyIGNhbiBtYXJrIGFzIGZhaWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyOF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYmF0Y2ggb3duZXIgY2FuIHByb2Nlc3MgaXRlbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGJhdGNoIG93bmVyIGNhbiBzdGFydCBwcm9jZXNzaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBiYXRjaCBvd25lciBjYW4gdXBkYXRlIGJhdGNoIHNpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGN1cnJlbnQgYmF0Y2ggb3duZXIgY2FuIGNoYW5nZSBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5NV0sImVycm9yTWVzc2FnZSI6IlBhcmVudCBhcHAgSUQgbXVzdCBiZSBncmVhdGVyIHRoYW4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4N10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NCwyMTEsMjI4LDI0NSwyNjIsMjc5LDI5MSwzMDksMzIxLDMzNywzNTVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU1LDQ2NSw0ODMsNDkyLDUwNSw1MTEsNTI2LDUzMiw1NDAsNTUxLDU2Miw1NjYsNTgxLDU5Miw1OTgsNjAzLDYxMyw2MjAsNjI3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p6ZEdGMGRYTWlJQ0ppWVhSamFFOTNibVZ5SWlBd2VERTFNV1kzWXpjMUlDSmlZWFJqYUZOcGVtVWlJQ0pqZFhKeVpXNTBTVzVrWlhnaUlDSjBiM1JoYkZCeWIyTmxjM05sWkNJZ0luQmhjbVZ1ZEVScGMzUnlhV0oxZEdsdmJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbUYwWTJoRWFYTjBjbWxpZFhScGIyNURiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhOZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGhoWm1Oak1qRmlJREI0WmpZMU5UVm1PV0VnTUhoak4ySXhZV1kxWmlBd2VEbGtaak0yTTJGaUlEQjRNakJoWlRSbFpHRWdNSGhsT0dFeU9XWXhPQ0F3ZURFM05XSXpZbU00SURCNFptUXlZVEF5WXpBZ01IZzBNbVkwWWprd1lpQXdlRGcwT1RsaU9UVTBJREI0WlRBNE16aGlZbUVnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamFHRnVaMlZDWVhSamFFOTNibVZ5S0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWQ1lYUmphRk5wZW1Vb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4wWVhKMFVISnZZMlZ6YzJsdVp5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNISnZZMlZ6YzBsMFpXMG9ZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW0xaGNtdEdZV2xzWldRb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRFSmhkR05vVTNSaGRIVnpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEZSdmRHRnNVSEp2WTJWemMyVmtLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEZCeWIyZHlaWE56VUdWeVkyVnVkR0ZuWlNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUlFZWEpsYm5SRWFYTjBjbWxpZFhScGIyNG9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlhR1ZzYkc4b1lubDBaVnRkS1dKNWRHVmJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZhVzVwZEdsaGJHbDZaVjl5YjNWMFpVQXpJRzFoYVc1ZlkyaGhibWRsUW1GMFkyaFBkMjVsY2w5eWIzVjBaVUEwSUcxaGFXNWZkWEJrWVhSbFFtRjBZMmhUYVhwbFgzSnZkWFJsUURVZ2JXRnBibDl6ZEdGeWRGQnliMk5sYzNOcGJtZGZjbTkxZEdWQU5pQnRZV2x1WDNCeWIyTmxjM05KZEdWdFgzSnZkWFJsUURjZ2JXRnBibDl0WVhKclJtRnBiR1ZrWDNKdmRYUmxRRGdnYldGcGJsOW5aWFJDWVhSamFGTjBZWFIxYzE5eWIzVjBaVUE1SUcxaGFXNWZaMlYwVkc5MFlXeFFjbTlqWlhOelpXUmZjbTkxZEdWQU1UQWdiV0ZwYmw5blpYUlFjbTluY21WemMxQmxjbU5sYm5SaFoyVmZjbTkxZEdWQU1URWdiV0ZwYmw5blpYUlFZWEpsYm5SRWFYTjBjbWxpZFhScGIyNWZjbTkxZEdWQU1USWdiV0ZwYmw5b1pXeHNiMTl5YjNWMFpVQXhNd29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNZWFJqYUVScGMzUnlhV0oxZEdsdmJrTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5b1pXeHNiMTl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbUYwWTJoRWFYTjBjbWxpZFhScGIyNURiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVUdGeVpXNTBSR2x6ZEhKcFluVjBhVzl1WDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUlFZWEpsYm5SRWFYTjBjbWxpZFhScGIyNEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVSEp2WjNKbGMzTlFaWEpqWlc1MFlXZGxYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSUWNtOW5jbVZ6YzFCbGNtTmxiblJoWjJVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFZHOTBZV3hRY205alpYTnpaV1JmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGUnZkR0ZzVUhKdlkyVnpjMlZrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEVKaGRHTm9VM1JoZEhWelgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRUpoZEdOb1UzUmhkSFZ6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjFoY210R1lXbHNaV1JmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnYldGeWEwWmhhV3hsWkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl3Y205alpYTnpTWFJsYlY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUpoZEdOb1JHbHpkSEpwWW5WMGFXOXVRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQndjbTlqWlhOelNYUmxiUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpkR0Z5ZEZCeWIyTmxjM05wYm1kZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCemRHRnlkRkJ5YjJObGMzTnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFFtRjBZMmhUYVhwbFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW1GMFkyaEVhWE4wY21saWRYUnBiMjVEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnZFhCa1lYUmxRbUYwWTJoVGFYcGxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTm9ZVzVuWlVKaGRHTm9UM2R1WlhKZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJDWVhSamFFUnBjM1J5YVdKMWRHbHZia052Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdZMmhoYm1kbFFtRjBZMmhQZDI1bGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5cGJtbDBhV0ZzYVhwbFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW1GMFkyaEVhWE4wY21saWRYUnBiMjVEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2x1YVhScFlXeHBlbVVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNZWFJqYUVScGMzUnlhV0oxZEdsdmJrTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSmhkR05vUkdsemRISnBZblYwYVc5dVEyOXVkSEpoWTNRdWFXNXBkR2xoYkdsNlpTaHdZWEpsYm5SQmNIQkpaRG9nZFdsdWREWTBMQ0JpWVhSamFFNTFiVG9nZFdsdWREWTBMQ0JpWVhSamFGTnBlbVU2SUhWcGJuUTJOQ3dnWW1GMFkyaFBkMjVsY2tGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BwYm1sMGFXRnNhWHBsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TFRJM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnYVc1cGRHbGhiR2w2WlNnS0lDQWdJQzh2SUNBZ2NHRnlaVzUwUVhCd1NXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZbUYwWTJoT2RXMDZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZbUYwWTJoVGFYcGxPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR0poZEdOb1QzZHVaWEpCWkdSeVpYTnpPaUJpZVhSbGN3b2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QTBJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdZWE56WlhKMEtIQmhjbVZ1ZEVGd2NFbGtJRDRnTUN3Z0oxQmhjbVZ1ZENCaGNIQWdTVVFnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRnlaVzUwSUdGd2NDQkpSQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUdGemMyVnlkQ2hpWVhSamFFNTFiU0ErSURBc0lDZENZWFJqYUNCdWRXMWlaWElnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaGMzTmxjblFnTHk4Z1FtRjBZMmdnYm5WdFltVnlJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWVhOelpYSjBLR0poZEdOb1UybDZaU0ErSURBc0lDZENZWFJqYUNCemFYcGxJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhOelpYSjBJQzh2SUVKaGRHTm9JSE5wZW1VZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QmhjM05sY25Rb1ltRjBZMmhQZDI1bGNrRmtaSEpsYzNNdWJHVnVaM1JvSUQ0Z01Dd2dKMEpoZEdOb0lHOTNibVZ5SUdGa1pISmxjM01nWTJGdWJtOTBJR0psSUdWdGNIUjVKeWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklFSmhkR05vSUc5M2JtVnlJR0ZrWkhKbGMzTWdZMkZ1Ym05MElHSmxJR1Z0Y0hSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnY0dGeVpXNTBSR2x6ZEhKcFluVjBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPeUF2THlCUVlYSmxiblFnWkdsemRISnBZblYwYVc5dUlHRndjQ0JKUkFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpY0dGeVpXNTBSR2x6ZEhKcFluVjBhVzl1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUIwYUdsekxuQmhjbVZ1ZEVScGMzUnlhV0oxZEdsdmJpNTJZV3gxWlNBOUlIQmhjbVZ1ZEVGd2NFbGtPd29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QmlZWFJqYUU1MWJXSmxjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaVltRjBZMmhPZFcxaVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklIUm9hWE11WW1GMFkyaE9kVzFpWlhJdWRtRnNkV1VnUFNCaVlYUmphRTUxYlRzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnWW1GMFkyaFRhWHBsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ1lubDBaV05mTXlBdkx5QWlZbUYwWTJoVGFYcGxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBhR2x6TG1KaGRHTm9VMmw2WlM1MllXeDFaU0E5SUdKaGRHTm9VMmw2WlRzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYzNSaGRIVnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUF3UFdOeVpXRjBaV1FzSURFOWNISnZZMlZ6YzJsdVp5d2dNajFqYjIxd2JHVjBaV1FzSURNOVptRnBiR1ZrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIUm9hWE11YzNSaGRIVnpMblpoYkhWbElEMGdNRHNnTHk4Z1EzSmxZWFJsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJSFJ2ZEdGc1VISnZZMlZ6YzJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeFFjbTlqWlhOelpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeFFjbTlqWlhOelpXUXVkbUZzZFdVZ1BTQXdPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHSmhkR05vVDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KaGRHTm9UM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhSb2FYTXVZbUYwWTJoUGQyNWxjaTUyWVd4MVpTQTlJR0poZEdOb1QzZHVaWEpCWkdSeVpYTnpPeUF2THlCRGIyNW1hV2QxY21GaWJHVWdiM2R1WlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnWTNWeWNtVnVkRWx1WkdWNElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTNWeWNtVnVkRWx1WkdWNElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCMGFHbHpMbU4xY25KbGJuUkpibVJsZUM1MllXeDFaU0E5SURBN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW1GMFkyaEVhWE4wY21saWRYUnBiMjVEYjI1MGNtRmpkQzVqYUdGdVoyVkNZWFJqYUU5M2JtVnlLRzVsZDA5M2JtVnlPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZMmhoYm1kbFFtRjBZMmhQZDI1bGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME55MDFNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHTm9ZVzVuWlVKaGRHTm9UM2R1WlhJb0NpQWdJQ0F2THlBZ0lHNWxkMDkzYm1WeU9pQmllWFJsY3dvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlIUm9hWE11WW1GMFkyaFBkMjVsY2k1MllXeDFaU3dnSjA5dWJIa2dZM1Z5Y21WdWRDQmlZWFJqYUNCdmQyNWxjaUJqWVc0Z1kyaGhibWRsSUc5M2JtVnlKeWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHSmhkR05vVDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppWVhSamFFOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMDlJSFJvYVhNdVltRjBZMmhQZDI1bGNpNTJZV3gxWlN3Z0owOXViSGtnWTNWeWNtVnVkQ0JpWVhSamFDQnZkMjVsY2lCallXNGdZMmhoYm1kbElHOTNibVZ5SnlrN0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzVnljbVZ1ZENCaVlYUmphQ0J2ZDI1bGNpQmpZVzRnWTJoaGJtZGxJRzkzYm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkUGQyNWxjaTVzWlc1bmRHZ2dQaUF3TENBblRtVjNJRzkzYm1WeUlHRmtaSEpsYzNNZ1kyRnVibTkwSUdKbElHVnRjSFI1SnlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJRTVsZHlCdmQyNWxjaUJoWkdSeVpYTnpJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCaVlYUmphRTkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbUYwWTJoUGQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHRnpjMlZ5ZENodVpYZFBkMjVsY2lBaFBUMGdkR2hwY3k1aVlYUmphRTkzYm1WeUxuWmhiSFZsTENBblRtVjNJRzkzYm1WeUlHMTFjM1FnWW1VZ1pHbG1abVZ5Wlc1MElHWnliMjBnWTNWeWNtVnVkQ2NwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFNWxkeUJ2ZDI1bGNpQnRkWE4wSUdKbElHUnBabVpsY21WdWRDQm1jbTl0SUdOMWNuSmxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdZbUYwWTJoUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGlncE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVltRjBZMmhQZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z2RHaHBjeTVpWVhSamFFOTNibVZ5TG5aaGJIVmxJRDBnYm1WM1QzZHVaWEk3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0poZEdOb1JHbHpkSEpwWW5WMGFXOXVRMjl1ZEhKaFkzUXVkWEJrWVhSbFFtRjBZMmhUYVhwbEtHNWxkMEpoZEdOb1UybDZaVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3AxY0dSaGRHVkNZWFJqYUZOcGVtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSXROalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QjFjR1JoZEdWQ1lYUmphRk5wZW1Vb0NpQWdJQ0F2THlBZ0lHNWxkMEpoZEdOb1UybDZaVG9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnZEdocGN5NWlZWFJqYUU5M2JtVnlMblpoYkhWbExDQW5UMjVzZVNCaVlYUmphQ0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJR0poZEdOb0lITnBlbVVuS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdZbUYwWTJoUGQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KaGRHTm9UM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQVDBnZEdocGN5NWlZWFJqYUU5M2JtVnlMblpoYkhWbExDQW5UMjVzZVNCaVlYUmphQ0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJR0poZEdOb0lITnBlbVVuS1RzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaVlYUmphQ0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJR0poZEdOb0lITnBlbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdZWE56WlhKMEtHNWxkMEpoZEdOb1UybDZaU0ErSURBc0lDZENZWFJqYUNCemFYcGxJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhOelpYSjBJQzh2SUVKaGRHTm9JSE5wZW1VZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnpkR0YwZFhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklEQTlZM0psWVhSbFpDd2dNVDF3Y205alpYTnphVzVuTENBeVBXTnZiWEJzWlhSbFpDd2dNejFtWVdsc1pXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BUMDlJREFzSUNkRFlXNGdiMjVzZVNCMWNHUmhkR1VnWW1GMFkyZ2djMmw2WlNCM2FHVnVJR2x1SUdOeVpXRjBaV1FnYzNSaGRIVnpKeWs3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyRnVJRzl1YkhrZ2RYQmtZWFJsSUdKaGRHTm9JSE5wZW1VZ2QyaGxiaUJwYmlCamNtVmhkR1ZrSUhOMFlYUjFjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QmlZWFJqYUZOcGVtVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaVlYUmphRk5wZW1VaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUhSb2FYTXVZbUYwWTJoVGFYcGxMblpoYkhWbElEMGdibVYzUW1GMFkyaFRhWHBsT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDWVhSamFFUnBjM1J5YVdKMWRHbHZia052Ym5SeVlXTjBMbk4wWVhKMFVISnZZMlZ6YzJsdVp5Z3BJQzArSUhadmFXUTZDbk4wWVhKMFVISnZZMlZ6YzJsdVp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwOUlIUm9hWE11WW1GMFkyaFBkMjVsY2k1MllXeDFaU3dnSjA5dWJIa2dZbUYwWTJnZ2IzZHVaWElnWTJGdUlITjBZWEowSUhCeWIyTmxjM05wYm1jbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWW1GMFkyaFBkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSmhkR05vVDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFQwZ2RHaHBjeTVpWVhSamFFOTNibVZ5TG5aaGJIVmxMQ0FuVDI1c2VTQmlZWFJqYUNCdmQyNWxjaUJqWVc0Z2MzUmhjblFnY0hKdlkyVnpjMmx1WnljcE93b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHSmhkR05vSUc5M2JtVnlJR05oYmlCemRHRnlkQ0J3Y205alpYTnphVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSE4wWVhSMWN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdNRDFqY21WaGRHVmtMQ0F4UFhCeWIyTmxjM05wYm1jc0lESTlZMjl0Y0d4bGRHVmtMQ0F6UFdaaGFXeGxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlQVDBnTUN3Z0owSmhkR05vSUcxMWMzUWdZbVVnYVc0Z1kzSmxZWFJsWkNCemRHRjBkWE1uS1RzS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNZWFJqYUNCdGRYTjBJR0psSUdsdUlHTnlaV0YwWldRZ2MzUmhkSFZ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSE4wWVhSMWN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdNRDFqY21WaGRHVmtMQ0F4UFhCeWIyTmxjM05wYm1jc0lESTlZMjl0Y0d4bGRHVmtMQ0F6UFdaaGFXeGxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOUlERTdJQzh2SUZCeWIyTmxjM05wYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDWVhSamFFUnBjM1J5YVdKMWRHbHZia052Ym5SeVlXTjBMbkJ5YjJObGMzTkpkR1Z0S0dsMFpXMUVZWFJoT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LY0hKdlkyVnpjMGwwWlcwNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RjdE9UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2NtOWpaWE56U1hSbGJTZ0tJQ0FnSUM4dklDQWdhWFJsYlVSaGRHRTZJR0o1ZEdWekNpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBUMGdkR2hwY3k1aVlYUmphRTkzYm1WeUxuWmhiSFZsTENBblQyNXNlU0JpWVhSamFDQnZkMjVsY2lCallXNGdjSEp2WTJWemN5QnBkR1Z0Y3ljcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJpWVhSamFFOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVltRjBZMmhQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5UFNCMGFHbHpMbUpoZEdOb1QzZHVaWEl1ZG1Gc2RXVXNJQ2RQYm14NUlHSmhkR05vSUc5M2JtVnlJR05oYmlCd2NtOWpaWE56SUdsMFpXMXpKeWs3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWW1GMFkyZ2diM2R1WlhJZ1kyRnVJSEJ5YjJObGMzTWdhWFJsYlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYzNSaGRIVnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUF3UFdOeVpXRjBaV1FzSURFOWNISnZZMlZ6YzJsdVp5d2dNajFqYjIxd2JHVjBaV1FzSURNOVptRnBiR1ZrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWMzUmhkSFZ6TG5aaGJIVmxJRDA5UFNBeExDQW5RbUYwWTJnZ2JYVnpkQ0JpWlNCcGJpQndjbTlqWlhOemFXNW5JSE4wWVhSMWN5Y3BPd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW1GMFkyZ2diWFZ6ZENCaVpTQnBiaUJ3Y205alpYTnphVzVuSUhOMFlYUjFjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmpkWEp5Wlc1MFNXNWtaWGdnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVkzVnljbVZ1ZEVsdVpHVjRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z2RHaHBjeTVqZFhKeVpXNTBTVzVrWlhndWRtRnNkV1VnUFNCMGFHbHpMbU4xY25KbGJuUkpibVJsZUM1MllXeDFaU0FySURFN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmpkWEp5Wlc1MFNXNWtaWGdnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpkWEp5Wlc1MFNXNWtaWGdpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJSFJvYVhNdVkzVnljbVZ1ZEVsdVpHVjRMblpoYkhWbElEMGdkR2hwY3k1amRYSnlaVzUwU1c1a1pYZ3VkbUZzZFdVZ0t5QXhPd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdkRzkwWVd4UWNtOWpaWE56WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkRzkwWVd4UWNtOWpaWE56WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVUhKdlkyVnpjMlZrTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkZCeWIyTmxjM05sWkM1MllXeDFaU0FySURFN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QjBiM1JoYkZCeWIyTmxjM05sWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1VISnZZMlZ6YzJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1VISnZZMlZ6YzJWa0xuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJGQnliMk5sYzNObFpDNTJZV3gxWlNBcklERTdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmpkWEp5Wlc1MFNXNWtaWGdnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVkzVnljbVZ1ZEVsdVpHVjRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1ltRjBZMmhUYVhwbElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUpoZEdOb1UybDZaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxtTjFjbkpsYm5SSmJtUmxlQzUyWVd4MVpTQStQU0IwYUdsekxtSmhkR05vVTJsNlpTNTJZV3gxWlNrZ2V3b2dJQ0FnUGowS0lDQWdJR0o2SUhCeWIyTmxjM05KZEdWdFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJREE5WTNKbFlYUmxaQ3dnTVQxd2NtOWpaWE56YVc1bkxDQXlQV052YlhCc1pYUmxaQ3dnTXoxbVlXbHNaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Rb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQXlPeUF2THlCRGIyMXdiR1YwWldRS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tjSEp2WTJWemMwbDBaVzFmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhkR05vWDJScGMzUnlhV0oxZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENZWFJqYUVScGMzUnlhV0oxZEdsdmJrTnZiblJ5WVdOMExtMWhjbXRHWVdsc1pXUW9LU0F0UGlCMmIybGtPZ3B0WVhKclJtRnBiR1ZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3T0FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUhSb2FYTXVZbUYwWTJoUGQyNWxjaTUyWVd4MVpTd2dKMDl1YkhrZ1ltRjBZMmdnYjNkdVpYSWdZMkZ1SUcxaGNtc2dZWE1nWm1GcGJHVmtKeWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHSmhkR05vVDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppWVhSamFFOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWFJqYUY5a2FYTjBjbWxpZFhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlQU0IwYUdsekxtSmhkR05vVDNkdVpYSXVkbUZzZFdVc0lDZFBibXg1SUdKaGRHTm9JRzkzYm1WeUlHTmhiaUJ0WVhKcklHRnpJR1poYVd4bFpDY3BPd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0poZEdOb0lHOTNibVZ5SUdOaGJpQnRZWEpySUdGeklHWmhhV3hsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJREE5WTNKbFlYUmxaQ3dnTVQxd2NtOWpaWE56YVc1bkxDQXlQV052YlhCc1pYUmxaQ3dnTXoxbVlXbHNaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYUmphRjlrYVhOMGNtbGlkWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UQUtJQ0FnSUM4dklIUm9hWE11YzNSaGRIVnpMblpoYkhWbElEMGdNenNnTHk4Z1JtRnBiR1ZrQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW1GMFkyaEVhWE4wY21saWRYUnBiMjVEYjI1MGNtRmpkQzVuWlhSQ1lYUmphRk4wWVhSMWN5Z3BJQzArSUhWcGJuUTJORG9LWjJWMFFtRjBZMmhUZEdGMGRYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklITjBZWFIxY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNnTHk4Z01EMWpjbVZoZEdWa0xDQXhQWEJ5YjJObGMzTnBibWNzSURJOVkyOXRjR3hsZEdWa0xDQXpQV1poYVd4bFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTRDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVN0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKaGRHTm9SR2x6ZEhKcFluVjBhVzl1UTI5dWRISmhZM1F1WjJWMFZHOTBZV3hRY205alpYTnpaV1FvS1NBdFBpQjFhVzUwTmpRNkNtZGxkRlJ2ZEdGc1VISnZZMlZ6YzJWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGRHTm9YMlJwYzNSeWFXSjFkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCMGIzUmhiRkJ5YjJObGMzTmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRkJ5YjJObGMzTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTJDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUwYjNSaGJGQnliMk5sYzNObFpDNTJZV3gxWlRzS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW1GMFkyaEVhWE4wY21saWRYUnBiMjVEYjI1MGNtRmpkQzVuWlhSUWNtOW5jbVZ6YzFCbGNtTmxiblJoWjJVb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEZCeWIyZHlaWE56VUdWeVkyVnVkR0ZuWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnWW1GMFkyaFRhWHBsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSmhkR05vVTJsNlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMENpQWdJQ0F2THlCcFppQW9kR2hwY3k1aVlYUmphRk5wZW1VdWRtRnNkV1VnUFQwOUlEQXBJSEpsZEhWeWJpQXdPd29nSUNBZ1ltNTZJR2RsZEZCeWIyZHlaWE56VUdWeVkyVnVkR0ZuWlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUnpkV0lLQ21kbGRGQnliMmR5WlhOelVHVnlZMlZ1ZEdGblpWOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GMFkyaGZaR2x6ZEhKcFluVjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUdOMWNuSmxiblJKYm1SbGVDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqZFhKeVpXNTBTVzVrWlhnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TlFvZ0lDQWdMeThnY21WMGRYSnVJQ2gwYUdsekxtTjFjbkpsYm5SSmJtUmxlQzUyWVd4MVpTQXFJREV3TUNrZ0x5QjBhR2x6TG1KaGRHTm9VMmw2WlM1MllXeDFaVHNLSUNBZ0lIQjFjMmhwYm5RZ01UQXdJQzh2SURFd01Bb2dJQ0FnS2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoZEdOb1gyUnBjM1J5YVdKMWRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJpWVhSamFGTnBlbVVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVltRjBZMmhUYVhwbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhSamFGOWthWE4wY21saWRYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUhKbGRIVnliaUFvZEdocGN5NWpkWEp5Wlc1MFNXNWtaWGd1ZG1Gc2RXVWdLaUF4TURBcElDOGdkR2hwY3k1aVlYUmphRk5wZW1VdWRtRnNkV1U3Q2lBZ0lDQXZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSmhkR05vUkdsemRISnBZblYwYVc5dVEyOXVkSEpoWTNRdVoyVjBVR0Z5Wlc1MFJHbHpkSEpwWW5WMGFXOXVLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUlFZWEpsYm5SRWFYTjBjbWxpZFhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRjBZMmhmWkdsemRISnBZblYwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2NHRnlaVzUwUkdsemRISnBZblYwYVc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3lBdkx5QlFZWEpsYm5RZ1pHbHpkSEpwWW5WMGFXOXVJR0Z3Y0NCSlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5CaGNtVnVkRVJwYzNSeWFXSjFkR2x2YmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUYwWTJoZlpHbHpkSEpwWW5WMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1d1lYSmxiblJFYVhOMGNtbGlkWFJwYjI0dWRtRnNkV1U3Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1Cd1p6ZEdGMGRYTUtZbUYwWTJoUGQyNWxjZ1FWSDN4MUNXSmhkR05vVTJsNlpReGpkWEp5Wlc1MFNXNWtaWGdPZEc5MFlXeFFjbTlqWlhOelpXUVNjR0Z5Wlc1MFJHbHpkSEpwWW5WMGFXOXVNUnRCQVIrQ0N3U0svTUliQlBaVlg1b0V4N0d2WHdTZDgyT3JCQ0N1VHRvRTZLS2ZHQVFYV3p2SUJQMHFBc0FFUXZTNUN3U0VtYmxVQk9DRGk3bzJHZ0NPQ3dDdEFKc0Fpd0IvQUcwQVlRQlFBRDhBTGdBZEFBSWlRekVaRkVReEdFUTJHZ0ZYQWdCSkZSWlhCZ0pNVUNwTVVMQWpRekVaRkVReEdFU0lBWmdXS2t4UXNDTkRNUmtVUkRFWVJJZ0JjQllxVEZDd0kwTXhHUlJFTVJoRWlBRlpGaXBNVUxBalF6RVpGRVF4R0VTSUFVTVdLa3hRc0NORE1Sa1VSREVZUklnQkpTTkRNUmtVUkRFWVJEWWFBVmNDQUlnQTJTTkRNUmtVUkRFWVJJZ0F1eU5ETVJrVVJERVlSRFlhQVJlSUFKSWpRekVaRkVReEdFUTJHZ0ZYQWdDSUFHUWpRekVaRkVReEdFUTJHZ0VYTmhvQ0Z6WWFBeGMyR2dSWEFnQ0lBQTBqUXpFWlFQOHdNUmdVUkNORGlnUUFpL3hFaS8xRWkvNUVpLzhWUkNjR2kveG5nQXRpWVhSamFFNTFiV0psY292OVp5dUwvbWNvSW1jbkJTSm5LWXYvWnljRUltZUppZ0VBTVFBaUtXVkVFa1NML3hWRUlpbGxSSXYvRTBRcGkvOW5pWW9CQURFQUlpbGxSQkpFaS85RUlpaGxSQlJFSzR2L1o0a3hBQ0lwWlVRU1JDSW9aVVFVUkNnalo0bUtBUUF4QUNJcFpVUVNSQ0lvWlVRakVrUWlKd1JsUkNNSUp3Uk1aeUluQldWRUl3Z25CVXhuSWljRVpVUWlLMlZFRDBFQUJDaUJBbWVKTVFBaUtXVkVFa1FvZ1FObmlTSW9aVVNKSWljRlpVU0pJaXRsUkVBQUFpS0pJaWNFWlVTQlpBc2lLMlZFQ29raUp3WmxSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
