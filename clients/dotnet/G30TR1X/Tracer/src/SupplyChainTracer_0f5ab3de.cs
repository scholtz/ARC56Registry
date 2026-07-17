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

namespace Arc56.Generated.G30TR1X.Tracer.SupplyChainTracer_0f5ab3de
{


    public class SupplyChainTracerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SupplyChainTracerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Grant write permission to an account.
        ///Only the contract creator may do this.
        ///</summary>
        /// <param name="account"> </param>
        public async Task Authorize(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 188, 101, 1 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Authorize_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 188, 101, 1 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove write permission from an account.
        ///</summary>
        /// <param name="account"> </param>
        public async Task Revoke(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 131, 21, 151 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Revoke_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 131, 21, 151 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new batch entry.
        ///Assigns an incremental batch_id and stores initial metadata.
        ///</summary>
        /// <param name="first_record"> </param>
        public async Task<ulong> RegisterBatch(byte[] first_record, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 240, 37, 121 };
            var first_recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); first_recordAbi.From(first_record);

            var result = await base.CallApp(new List<object> { abiHandle, first_recordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterBatch_Transactions(byte[] first_record, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 240, 37, 121 };
            var first_recordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); first_recordAbi.From(first_record);

            return await base.MakeTransactionList(new List<object> { abiHandle, first_recordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Link an ASA to a batch for tracking.
        ///Only the contract creator may do this.
        ///</summary>
        /// <param name="batch_id"> </param>
        /// <param name="asset_id"> </param>
        public async Task LinkAsset(ulong batch_id, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 161, 147, 53 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LinkAsset_Transactions(ulong batch_id, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 161, 147, 53 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Append a new record to an existing batch.
        ///Only authorized participants can call this.
        ///</summary>
        /// <param name="batch_id"> </param>
        /// <param name="new_data"> </param>
        public async Task RecordEvent(ulong batch_id, byte[] new_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 110, 1, 2 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);
            var new_dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_dataAbi.From(new_data);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi, new_dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordEvent_Transactions(ulong batch_id, byte[] new_data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 110, 1, 2 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);
            var new_dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_dataAbi.From(new_data);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi, new_dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the full record string for a given batch.
        ///</summary>
        /// <param name="batch_id"> </param>
        public async Task<byte[]> GetBatchRecord(ulong batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 224, 69, 45 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetBatchRecord_Transactions(ulong batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 224, 69, 45 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the linked ASA id for a given batch.
        ///</summary>
        /// <param name="batch_id"> </param>
        public async Task<ulong> GetAssetForBatch(ulong batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 251, 147, 115 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetForBatch_Transactions(ulong batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 251, 147, 115 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batch_idAbi.From(batch_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3VwcGx5Q2hhaW5UcmFjZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYXV0aG9yaXplIiwiZGVzYyI6IkdyYW50IHdyaXRlIHBlcm1pc3Npb24gdG8gYW4gYWNjb3VudC5cbk9ubHkgdGhlIGNvbnRyYWN0IGNyZWF0b3IgbWF5IGRvIHRoaXMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZSIsImRlc2MiOiJSZW1vdmUgd3JpdGUgcGVybWlzc2lvbiBmcm9tIGFuIGFjY291bnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX2JhdGNoIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBiYXRjaCBlbnRyeS5cbkFzc2lnbnMgYW4gaW5jcmVtZW50YWwgYmF0Y2hfaWQgYW5kIHN0b3JlcyBpbml0aWFsIG1ldGFkYXRhLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXJzdF9yZWNvcmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsaW5rX2Fzc2V0IiwiZGVzYyI6IkxpbmsgYW4gQVNBIHRvIGEgYmF0Y2ggZm9yIHRyYWNraW5nLlxuT25seSB0aGUgY29udHJhY3QgY3JlYXRvciBtYXkgZG8gdGhpcy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmF0Y2hfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9ldmVudCIsImRlc2MiOiJBcHBlbmQgYSBuZXcgcmVjb3JkIHRvIGFuIGV4aXN0aW5nIGJhdGNoLlxuT25seSBhdXRob3JpemVkIHBhcnRpY2lwYW50cyBjYW4gY2FsbCB0aGlzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXRjaF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2RhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JhdGNoX3JlY29yZCIsImRlc2MiOiJSZXR1cm4gdGhlIGZ1bGwgcmVjb3JkIHN0cmluZyBmb3IgYSBnaXZlbiBiYXRjaC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmF0Y2hfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfZm9yX2JhdGNoIiwiZGVzYyI6IlJldHVybiB0aGUgbGlua2VkIEFTQSBpZCBmb3IgYSBnaXZlbiBiYXRjaC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmF0Y2hfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE5Nl0sImVycm9yTWVzc2FnZSI6IkFjY291bnQgbm90IGF1dGhvcml6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODUsMzM3LDM3N10sImVycm9yTWVzc2FnZSI6IkJhdGNoIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Niw0MTBdLCJlcnJvck1lc3NhZ2UiOiJObyBhc3NldCBsaW5rZWQgdG8gdGhpcyBiYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBhdXRob3JpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGxpbmsgYXNzZXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiByZWdpc3RlciBiYXRjaGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiByZXZva2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjhdLCJlcnJvck1lc3NhZ2UiOiJVbmF1dGhvcml6ZWQgcGFydGljaXBhbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2JhdGNoZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA2LDMwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNCwzMTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwLDE4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTksMjY4LDMwMiwzNzAsMzk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEZ2dNQ0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWW1GMFkyaGZjbVZqYjNKa2N5SWdJblJ2ZEdGc1gySmhkR05vWlhNaUlDSmhkWFJvYjNKcGVtVmtJaUF3ZURFMU1XWTNZemMxSUNKaVlYUmphRjloYzNObGRITWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUbzJMVGNLSUNBZ0lDOHZJQ01nVkhKaFkyc2dkRzkwWVd3Z2NtVm5hWE4wWlhKbFpDQmlZWFJqYUdWekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gySmhkR05vWlhNZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOWlZWFJqYUdWeklnb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRk4xY0hCc2VVTm9ZV2x1VkhKaFkyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGczTTJKak5qVXdNU0F3ZURJek9ETXhOVGszSURCNE56Rm1NREkxTnprZ01IZ3pObUV4T1RNek5TQXdlR1JpTm1Vd01UQXlJREI0T1dObE1EUTFNbVFnTUhnME5tWmlPVE0zTXlBdkx5QnRaWFJvYjJRZ0ltRjFkR2h2Y21sNlpTaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGRtOXJaU2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxaMmx6ZEdWeVgySmhkR05vS0dKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbXhwYm10ZllYTnpaWFFvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXTnZjbVJmWlhabGJuUW9kV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZlltRjBZMmhmY21WamIzSmtLSFZwYm5RMk5DbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0ltZGxkRjloYzNObGRGOW1iM0pmWW1GMFkyZ29kV2x1ZERZMEtYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHRjFkR2h2Y21sNlpTQnlaWFp2YTJVZ2NtVm5hWE4wWlhKZlltRjBZMmdnYkdsdWExOWhjM05sZENCeVpXTnZjbVJmWlhabGJuUWdaMlYwWDJKaGRHTm9YM0psWTI5eVpDQm5aWFJmWVhOelpYUmZabTl5WDJKaGRHTm9DaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRZNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMbU52Ym5SeVlXTjBMbE4xY0hCc2VVTm9ZV2x1VkhKaFkyVnlMbUYxZEdodmNtbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GMWRHaHZjbWw2WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFhCd2JIbGZZMmhoYVc1ZmRISmhZMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYQndiSGxmWTJoaGFXNWZkSEpoWTJWeUwyTnZiblJ5WVdOMExuQjVPakk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJoZFhSb2IzSnBlbVVpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJoZFhSb2IzSnBlbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCelpXeG1MbUYxZEdodmNtbDZaV1JiWVdOamIzVnVkRjBnUFNCVlNXNTBOalFvTVNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GMWRHaHZjbWw2WldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVndjR3g1WDJOb1lXbHVYM1J5WVdObGNpOWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMbU52Ym5SeVlXTjBMbE4xY0hCc2VVTm9ZV2x1VkhKaFkyVnlMbkpsZG05clpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsZG05clpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYQndiSGxmWTJoaGFXNWZkSEpoWTJWeUwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVQyNXNlU0JqY21WaGRHOXlJR05oYmlCeVpYWnZhMlVpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ5WlhadmEyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYQndiSGxmWTJoaGFXNWZkSEpoWTJWeUwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJpWVd4aGJtTmxMQ0JoWkcxcGJpQTlJSE5sYkdZdVlYVjBhRzl5YVhwbFpDNXRZWGxpWlNoaFkyTnZkVzUwS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhWMGFHOXlhWHBsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCaGMzTmxjblFnWVdSdGFXNHNJQ0pCWTJOdmRXNTBJRzV2ZENCaGRYUm9iM0pwZW1Wa0lnb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyOTFiblFnYm05MElHRjFkR2h2Y21sNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYQndiSGxmWTJoaGFXNWZkSEpoWTJWeUwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVoZFhSb2IzSnBlbVZrVzJGalkyOTFiblJkQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFhCd2JIbGZZMmhoYVc1ZmRISmhZMlZ5TDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OMWNIQnNlVjlqYUdGcGJsOTBjbUZqWlhJdVkyOXVkSEpoWTNRdVUzVndjR3g1UTJoaGFXNVVjbUZqWlhJdWNtVm5hWE4wWlhKZlltRjBZMmhiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5aVlYUmphRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xY0hCc2VWOWphR0ZwYmw5MGNtRmpaWEl2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlISmxaMmx6ZEdWeUlHSmhkR05vWlhNaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCeVpXZHBjM1JsY2lCaVlYUmphR1Z6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z3Y0d4NVgyTm9ZV2x1WDNSeVlXTmxjaTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1ltRjBZMmhmYVdRZ1BTQnpaV3htTG5SdmRHRnNYMkpoZEdOb1pYTXVkbUZzZFdVZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjlpWVhSamFHVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMkpoZEdOb1pYTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFjSEJzZVY5amFHRnBibDkwY21GalpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUhObGJHWXVZbUYwWTJoZmNtVmpiM0prYzF0aVlYUmphRjlwWkYwZ1BTQm1hWEp6ZEY5eVpXTnZjbVFLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbUYwWTJoZmNtVmpiM0prY3lJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYQndiSGxmWTJoaGFXNWZkSEpoWTJWeUwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJKaGRHTm9aWE11ZG1Gc2RXVWdQU0JpWVhSamFGOXBaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZlltRjBZMmhsY3lJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4xY0hCc2VWOWphR0ZwYmw5MGNtRmpaWEl1WTI5dWRISmhZM1F1VTNWd2NHeDVRMmhoYVc1VWNtRmpaWEl1YkdsdWExOWhjM05sZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHBibXRmWVhOelpYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVndjR3g1WDJOb1lXbHVYM1J5WVdObGNpOWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFjSEJzZVY5amFHRnBibDkwY21GalpYSXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKUGJteDVJR055WldGMGIzSWdZMkZ1SUd4cGJtc2dZWE56WlhSeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2JHbHVheUJoYzNObGRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYQndiSGxmWTJoaGFXNWZkSEpoWTJWeUwyTnZiblJ5WVdOMExuQjVPalkzQ2lBZ0lDQXZMeUJwWkN3Z1pYaHBjM1J6SUQwZ2MyVnNaaTVpWVhSamFGOXlaV052Y21SekxtMWhlV0psS0dKaGRHTm9YMmxrS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1GMFkyaGZjbVZqYjNKa2N5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWNIQnNlVjlqYUdGcGJsOTBjbUZqWlhJdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNc0lDSkNZWFJqYUNCdWIzUWdabTkxYm1RaUNpQWdJQ0JoYzNObGNuUWdMeThnUW1GMFkyZ2dibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVndjR3g1WDJOb1lXbHVYM1J5WVdObGNpOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnYzJWc1ppNWlZWFJqYUY5aGMzTmxkSE5iWW1GMFkyaGZhV1JkSUQwZ1lYTnpaWFJmYVdRS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1KaGRHTm9YMkZ6YzJWMGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xY0hCc2VWOWphR0ZwYmw5MGNtRmpaWEl2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k1amIyNTBjbUZqZEM1VGRYQndiSGxEYUdGcGJsUnlZV05sY2k1eVpXTnZjbVJmWlhabGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldOdmNtUmZaWFpsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUbzNNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pjNENpQWdJQ0F2THlCaVlXeGhibU5sTENCaFpHMXBiaUE5SUhObGJHWXVZWFYwYUc5eWFYcGxaQzV0WVhsaVpTaFVlRzR1YzJWdVpHVnlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWFYwYUc5eWFYcGxaQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUbzNPUW9nSUNBZ0x5OGdZWE56WlhKMElHRmtiV2x1TENBaVZXNWhkWFJvYjNKcGVtVmtJSEJoY25ScFkybHdZVzUwSWdvZ0lDQWdZWE56WlhKMElDOHZJRlZ1WVhWMGFHOXlhWHBsWkNCd1lYSjBhV05wY0dGdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWNIQnNlVjlqYUdGcGJsOTBjbUZqWlhJdlkyOXVkSEpoWTNRdWNIazZPREVLSUNBZ0lDOHZJRzlzWkY5a1lYUmhMQ0JsZUdsemRITWdQU0J6Wld4bUxtSmhkR05vWDNKbFkyOXlaSE11YldGNVltVW9ZbUYwWTJoZmFXUXBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlZWFJqYUY5eVpXTnZjbVJ6SWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVndjR3g1WDJOb1lXbHVYM1J5WVdObGNpOWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJa0poZEdOb0lHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCQ1lYUmphQ0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWEJ3YkhsZlkyaGhhVzVmZEhKaFkyVnlMMk52Ym5SeVlXTjBMbkI1T2pnMENpQWdJQ0F2THlCaGMzTmxkRjlwWkN3Z1lYTnpaWFJmYkdsdWEyVmtJRDBnYzJWc1ppNWlZWFJqYUY5aGMzTmxkSE11YldGNVltVW9ZbUYwWTJoZmFXUXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlZWFJqYUY5aGMzTmxkSE1pQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUbzROUW9nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwWDJ4cGJtdGxaQ3dnSWs1dklHRnpjMlYwSUd4cGJtdGxaQ0IwYnlCMGFHbHpJR0poZEdOb0lnb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklHRnpjMlYwSUd4cGJtdGxaQ0IwYnlCMGFHbHpJR0poZEdOb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUbzROeTA0T0FvZ0lDQWdMeThnSXlCRGIyNWpZWFJsYm1GMFpTQnVaWGNnWkdGMFlTQjBieUJsZUdsemRHbHVaeUJ5WldOdmNtUWdjM1J5YVc1bkNpQWdJQ0F2THlCamIyMWlhVzVsWkNBOUlHOXNaRjlrWVhSaElDc2dZaUlnZkNBaUlDc2dibVYzWDJSaGRHRUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESXdOMk15TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xY0hCc2VWOWphR0ZwYmw5MGNtRmpaWEl2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklITmxiR1l1WW1GMFkyaGZjbVZqYjNKa2MxdGlZWFJqYUY5cFpGMGdQU0JqYjIxaWFXNWxaQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWNIQnNlVjlqYUdGcGJsOTBjbUZqWlhJdlkyOXVkSEpoWTNRdWNIazZOeklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzVndjR3g1WDJOb1lXbHVYM1J5WVdObGNpNWpiMjUwY21GamRDNVRkWEJ3YkhsRGFHRnBibFJ5WVdObGNpNW5aWFJmWW1GMFkyaGZjbVZqYjNKa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJKaGRHTm9YM0psWTI5eVpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYQndiSGxmWTJoaGFXNWZkSEpoWTJWeUwyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJSEpsWTI5eVpDd2daWGhwYzNSeklEMGdjMlZzWmk1aVlYUmphRjl5WldOdmNtUnpMbTFoZVdKbEtHSmhkR05vWDJsa0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltRjBZMmhmY21WamIzSmtjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWNIQnNlVjlqYUdGcGJsOTBjbUZqWlhJdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlRbUYwWTJnZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWVhOelpYSjBJQzh2SUVKaGRHTm9JRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFjSEJzZVY5amFHRnBibDkwY21GalpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTjFjSEJzZVY5amFHRnBibDkwY21GalpYSXVZMjl1ZEhKaFkzUXVVM1Z3Y0d4NVEyaGhhVzVVY21GalpYSXVaMlYwWDJGemMyVjBYMlp2Y2w5aVlYUmphRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWhjM05sZEY5bWIzSmZZbUYwWTJnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUb3hNRFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFhCd2JIbGZZMmhoYVc1ZmRISmhZMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdZWE56WlhSZmFXUXNJR1Y0YVhOMGN5QTlJSE5sYkdZdVltRjBZMmhmWVhOelpYUnpMbTFoZVdKbEtHSmhkR05vWDJsa0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVltRjBZMmhmWVhOelpYUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWd2NHeDVYMk5vWVdsdVgzUnlZV05sY2k5amIyNTBjbUZqZEM1d2VUb3hNVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNc0lDSk9ieUJoYzNObGRDQnNhVzVyWldRZ2RHOGdkR2hwY3lCaVlYUmphQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9ieUJoYzNObGRDQnNhVzVyWldRZ2RHOGdkR2hwY3lCaVlYUmphQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFjSEJzZVY5amFHRnBibDkwY21GalpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRBMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ0FJQ1lGRFdKaGRHTm9YM0psWTI5eVpITU5kRzkwWVd4ZlltRjBZMmhsY3dwaGRYUm9iM0pwZW1Wa0JCVWZmSFVNWW1GMFkyaGZZWE56WlhSek1SaEFBQU1wSkdjeEcwRUFRREVaRkVReEdFU0NCd1J6dkdVQkJDT0RGWmNFY2ZBbGVRUTJvWk0xQk50dUFRSUVuT0JGTFFSRys1TnpOaG9BamdjQUN3QWhBRHNBYmdDWkFOMEErZ0F4R1JReEdCUVFSQ0pETmhvQlNSVWxFa1F4QURJSkVrUXFURkFpRnI4aVF6WWFBVWtWSlJKRU1RQXlDUkpFS2t4UVNiMUZBVVM4U0NKRE5ob0JTU1JaZ1FJSVN3RVZFa1JYQWdBeEFESUpFa1FrS1dWRUlnaEpGaWhMQVZCSnZFaFBBNzhwVHdKbksweFFzQ0pETmhvQlNSVWpFa1FYTmhvQ1NSVWpFa1FYTVFBeUNSSkVUQllvU3dGUXZVVUJSQ2NFVEZCTUZyOGlRellhQVVrVkl4SkVGellhQWtra1dZRUNDRXNCRlJKRVZ3SUFLakVBVUwxRkFVUk1GaWhMQVZCSnZrUW5CRThEVUwxRkFVU0FBeUI4SUZCUEFsQkxBYnhJdnlKRE5ob0JTUlVqRWtRWEZpaE1VTDVFU1JVV1Z3WUNURkFyVEZDd0lrTTJHZ0ZKRlNNU1JCY1dKd1JNVUw1TUYweEVGaXRNVUxBaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo0LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
