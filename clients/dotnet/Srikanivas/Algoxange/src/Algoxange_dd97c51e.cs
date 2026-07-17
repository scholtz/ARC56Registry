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

namespace Arc56.Generated.Srikanivas.Algoxange.Algoxange_dd97c51e
{


    public class AlgoxangeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoxangeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        /// <param name="unitary_price"> </param>
        public async Task CreateApplication(ulong asset_id, ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 135, 140, 187, 61 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idRefIndex, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong asset_id, ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 135, 140, 187, 61 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idRefIndex, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task UpdateAssetId(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 12, 46, 190, 149 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAssetId_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 12, 46, 190, 149 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="unitary_price"> </param>
        public async Task SetPrice(ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 118, 0, 55 };
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            var result = await base.CallApp(new List<object> { abiHandle, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPrice_Transactions(ulong unitary_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 118, 0, 55 };
            var unitary_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitary_priceAbi.From(unitary_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, unitary_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrpay"> </param>
        public async Task OptInToAsset(PaymentTransaction mbrpay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrpay });
            byte[] abiHandle = { 21, 116, 83, 90 };

            var result = await base.CallApp(new List<object> { abiHandle, mbrpay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(PaymentTransaction mbrpay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrpay });
            byte[] abiHandle = { 21, 116, 83, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrpay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="buyerTxn"> </param>
        public async Task<ulong> DebugBuyCheck(PaymentTransaction buyerTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buyerTxn });
            byte[] abiHandle = { 173, 107, 223, 12 };

            var result = await base.CallApp(new List<object> { abiHandle, buyerTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DebugBuyCheck_Transactions(PaymentTransaction buyerTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buyerTxn });
            byte[] abiHandle = { 173, 107, 223, 12 };

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="buyerTxn"> </param>
        public async Task Buy(PaymentTransaction buyerTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buyerTxn });
            byte[] abiHandle = { 149, 141, 61, 249 };

            var result = await base.CallApp(new List<object> { abiHandle, buyerTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Buy_Transactions(PaymentTransaction buyerTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { buyerTxn });
            byte[] abiHandle = { 149, 141, 61, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 179, 73, 158 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 179, 73, 158 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb3hhbmdlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0YXJ5X3ByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9hc3NldF9pZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhc3NldCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9wcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0YXJ5X3ByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl90b19hc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVidWdfYnV5X2NoZWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgRGVsZXRlQXBwbGljYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTEsMTMzLDE2NSwxODcsMjAzLDIyMV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMiwxMTQsMTM2LDE2OCwxOTAsMjA2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NSwzMjUsNDIxLDQ0OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYXNzZXRpZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzgsNDE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51bml0YXJ5cHJpY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0LDE0NiwxNzhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTkNBeE1EQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmhjM05sZEdsa0lpQWlkVzVwZEdGeWVYQnlhV05sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5NFlXNW5aUzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJCYkdkdmVHRnVaMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0TnpoalltSXpaQ0F3ZURCak1tVmlaVGsxSURCNFkyTTNOakF3TXpjZ01IZ3hOVGMwTlRNMVlTQXdlR0ZrTm1Ka1pqQmpJREI0T1RVNFpETmtaamtnTUhnek0ySXpORGs1WlNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJpaGhjM05sZEN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkWEJrWVhSbFgyRnpjMlYwWDJsa0tHRnpjMlYwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5d2NtbGpaU2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWIzQjBYMmx1WDNSdlgyRnpjMlYwS0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pXSjFaMTlpZFhsZlkyaGxZMnNvY0dGNUtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVluVjVLSEJoZVNsMmIybGtJaXdnYldWMGFHOWtJQ0prWld4bGRHVmZZWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJsOXliM1YwWlVBeklHMWhhVzVmZFhCa1lYUmxYMkZ6YzJWMFgybGtYM0p2ZFhSbFFEUWdiV0ZwYmw5elpYUmZjSEpwWTJWZmNtOTFkR1ZBTlNCdFlXbHVYMjl3ZEY5cGJsOTBiMTloYzNObGRGOXliM1YwWlVBMklHMWhhVzVmWkdWaWRXZGZZblY1WDJOb1pXTnJYM0p2ZFhSbFFEY2diV0ZwYmw5aWRYbGZjbTkxZEdWQU9DQnRZV2x1WDJSbGJHVjBaVjloY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUE1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFRnNaMjk0WVc1blpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlrWld4bGRHVmZZWEJ3YkdsallYUnBiMjVmY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TmpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdSbGJHVjBaVjloY0hCc2FXTmhkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpZFhsZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk5URXROVElLSUNBZ0lDOHZJQ01nWW5WNUlIUm9aU0JoYzNObGRBb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1FXeG5iM2hoYm1kbEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZOVEV0TlRJS0lDQWdJQzh2SUNNZ1luVjVJSFJvWlNCaGMzTmxkQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHSjFlUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtaV0oxWjE5aWRYbGZZMmhsWTJ0ZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFRnNaMjk0WVc1blpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdaR1ZpZFdkZlluVjVYMk5vWldOckNpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYjNCMFgybHVYM1J2WDJGemMyVjBYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPakkxTFRJMkNpQWdJQ0F2THlBaklHOXdkQ0JwYmlCMGJ5QjBhR1VnWVhOelpYUWdkR2hoZENCM2FXeHNJR0psSUhOdmJHUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFRnNaMjk0WVc1blpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPakkxTFRJMkNpQWdJQ0F2THlBaklHOXdkQ0JwYmlCMGJ5QjBhR1VnWVhOelpYUWdkR2hoZENCM2FXeHNJR0psSUhOdmJHUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCdmNIUmZhVzVmZEc5ZllYTnpaWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMlYwWDNCeWFXTmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPakU1TFRJd0NpQWdJQ0F2THlBamRYQmtZWFJsSUhSb1pTQnNhWE4wYVc1bklIQnlhV05sQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5NFlXNW5aUzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJCYkdkdmVHRnVaMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZNVGt0TWpBS0lDQWdJQzh2SUNOMWNHUmhkR1VnZEdobElHeHBjM1JwYm1jZ2NISnBZMlVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnpaWFJmY0hKcFkyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsWDJGemMyVjBYMmxrWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pFMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCQmJHZHZlR0Z1WjJVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjk0WVc1blpTOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSFZ3WkdGMFpWOWhjM05sZEY5cFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkTENCamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUVd4bmIzaGhibWRsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCYzNObGRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXeG5iM2hoYm1kbExtTnZiblJ5WVdOMExrRnNaMjk0WVc1blpTNWpjbVZoZEdWZllYQndiR2xqWVhScGIyNG9ZWE56WlhSZmFXUTZJSFZwYm5RMk5Dd2dkVzVwZEdGeWVWOXdjbWxqWlRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzaGhibWRsTDJOdmJuUnlZV04wTG5CNU9qa3RNVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTd2dZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUM4dklHUmxaaUJqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRvYzJWc1ppd2dZWE56WlhSZmFXUTZJRUZ6YzJWMExDQjFibWwwWVhKNVgzQnlhV05sT2lCVlNXNTBOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZNVEVLSUNBZ0lDOHZJSE5sYkdZdVlYTnpaWFJwWkNBOUlHRnpjMlYwWDJsa0xtbGtDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhjM05sZEdsa0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUb3hNZ29nSUNBZ0x5OGdjMlZzWmk1MWJtbDBZWEo1Y0hKcFkyVWdQU0IxYm1sMFlYSjVYM0J5YVdObENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMWJtbDBZWEo1Y0hKcFkyVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXeG5iM2hoYm1kbExtTnZiblJ5WVdOMExrRnNaMjk0WVc1blpTNTFjR1JoZEdWZllYTnpaWFJmYVdRb1lYTnpaWFJmYVdRNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsWDJGemMyVjBYMmxrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5NFlXNW5aUzlqYjI1MGNtRmpkQzV3ZVRveE5DMHhOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2RYQmtZWFJsWDJGemMyVjBYMmxrS0hObGJHWXNJR0Z6YzJWMFgybGtPaUJCYzNObGRDa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5NFlXNW5aUzlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPakUzQ2lBZ0lDQXZMeUJ6Wld4bUxtRnpjMlYwYVdRZ1BTQmhjM05sZEY5cFpDNXBaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWE56WlhScFpDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJHZHZlR0Z1WjJVdVkyOXVkSEpoWTNRdVFXeG5iM2hoYm1kbExuTmxkRjl3Y21salpTaDFibWwwWVhKNVgzQnlhV05sT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25ObGRGOXdjbWxqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk1Ua3RNakVLSUNBZ0lDOHZJQ04xY0dSaGRHVWdkR2hsSUd4cGMzUnBibWNnY0hKcFkyVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhObGRGOXdjbWxqWlNoelpXeG1MQ0IxYm1sMFlYSjVYM0J5YVdObE9pQlZTVzUwTmpRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdjMlZzWmk1MWJtbDBZWEo1Y0hKcFkyVWdQU0IxYm1sMFlYSjVYM0J5YVdObENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMWJtbDBZWEo1Y0hKcFkyVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXeG5iM2hoYm1kbExtTnZiblJ5WVdOMExrRnNaMjk0WVc1blpTNXZjSFJmYVc1ZmRHOWZZWE56WlhRb2JXSnljR0Y1T2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q205d2RGOXBibDkwYjE5aGMzTmxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpVdE1qY0tJQ0FnSUM4dklDTWdiM0IwSUdsdUlIUnZJSFJvWlNCaGMzTmxkQ0IwYUdGMElIZHBiR3dnWW1VZ2MyOXNaQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2IzQjBYMmx1WDNSdlgyRnpjMlYwS0hObGJHWXNJRzFpY25CaGVUb2daM1I0Ymk1UVlYbHRaVzUwVkhKaGJuTmhZM1JwYjI0cElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpnS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdZWE56WlhKMElHNXZkQ0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMbWx6WDI5d2RHVmtYMmx1S0VGemMyVjBLSE5sYkdZdVlYTnpaWFJwWkNrcENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GemMyVjBhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlYTnpaWFJwWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlYwWDJodmJHUnBibWRmWjJWMElFRnpjMlYwUW1Gc1lXNWpaUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdGemMyVnlkQ0J0WW5Kd1lYa3VjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0J0WW5Kd1lYa3VZVzF2ZFc1MElEMDlJRWRzYjJKaGJDNXRhVzVmWW1Gc1lXNWpaU0FySUVkc2IySmhiQzVoYzNObGRGOXZjSFJmYVc1ZmJXbHVYMkpoYkdGdVkyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JuYkc5aVlXd2dUV2x1UW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVGemMyVjBUM0IwU1c1TmFXNUNZV3hoYm1ObENpQWdJQ0FyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pNMUxUTTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQwZ2MyVnNaaTVoYzNObGRHbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMGdNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZNellLSUNBZ0lDOHZJSGhtWlhKZllYTnpaWFE5SUhObGJHWXVZWE56WlhScFpDd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGMzTmxkR2xrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnpjMlYwYVdRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTlJREFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjk0WVc1blpTOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdhVzUwWTE4eUlDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TXpVdE16a0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFNCelpXeG1MbUZ6YzJWMGFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBTQXdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJHZHZlR0Z1WjJVdVkyOXVkSEpoWTNRdVFXeG5iM2hoYm1kbExtUmxZblZuWDJKMWVWOWphR1ZqYXloaWRYbGxjbFI0YmpvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtUmxZblZuWDJKMWVWOWphR1ZqYXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk5ERXRORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHUmxZblZuWDJKMWVWOWphR1ZqYXloelpXeG1MQ0JpZFhsbGNsUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZISmhibk5oWTNScGIyNHBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdhV1lnWW5WNVpYSlVlRzR1YzJWdVpHVnlJQ0U5SUZSNGJpNXpaVzVrWlhJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0lUMEtJQ0FnSUdKNklHUmxZblZuWDJKMWVWOWphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUnpkV0lLQ21SbFluVm5YMkoxZVY5amFHVmphMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJwWmlCaWRYbGxjbFI0Ymk1eVpXTmxhWFpsY2lBaFBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOek9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JpZWlCa1pXSjFaMTlpZFhsZlkyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtESXBDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ2NtVjBjM1ZpQ2dwa1pXSjFaMTlpZFhsZlkyaGxZMnRmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjk0WVc1blpTOWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnYVdZZ1luVjVaWEpVZUc0dVlXMXZkVzUwSUNFOUlITmxiR1l1ZFc1cGRHRnllWEJ5YVdObE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oxYm1sMFlYSjVjSEpwWTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkVzVwZEdGeWVYQnlhV05sSUdWNGFYTjBjd29nSUNBZ0lUMEtJQ0FnSUdKNklHUmxZblZuWDJKMWVWOWphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NeWtLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUF6Q2lBZ0lDQnlaWFJ6ZFdJS0NtUmxZblZuWDJKMWVWOWphR1ZqYTE5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwSUNBaklFRnNiQ0JuYjI5a0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZzWjI5NFlXNW5aUzVqYjI1MGNtRmpkQzVCYkdkdmVHRnVaMlV1WW5WNUtHSjFlV1Z5VkhodU9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtSjFlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TlRFdE5UTUtJQ0FnSUM4dklDTWdZblY1SUhSb1pTQmhjM05sZEFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdZblY1S0hObGJHWXNJR0oxZVdWeVZIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWNtRnVjMkZqZEdsdmJpa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5NFlXNW5aUzlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dKMWVXVnlWSGh1TG5ObGJtUmxjaUE5UFNCVWVHNHVjMlZ1WkdWeUlDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCaGMzTmxjblFvWW5WNVpYSlVlRzR1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3lBcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdZWE56WlhKMEtHSjFlV1Z5VkhodUxtRnRiM1Z1ZENBOVBTQnpaV3htTG5WdWFYUmhjbmx3Y21salpTQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5WdWFYUmhjbmx3Y21salpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUxYm1sMFlYSjVjSEpwWTJVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pVNUxUWTBDaUFnSUNBdkx5QWpJRkJsY21admNtMGdZWE56WlhRZ2RISmhibk5tWlhJS0lDQWdJQzh2SUNBZ0lDQnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lIaG1aWEpmWVhOelpYUTljMlZzWmk1aGMzTmxkR2xrTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJQzh2SUNBZ0lDQXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzaGhibWRsTDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QjRabVZ5WDJGemMyVjBQWE5sYkdZdVlYTnpaWFJwWkN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYzNObGRHbGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GemMyVjBhV1FnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFRFc0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5NFlXNW5aUzlqYjI1MGNtRmpkQzV3ZVRvMU9TMDJNQW9nSUNBZ0x5OGdJeUJRWlhKbWIzSnRJR0Z6YzJWMElIUnlZVzV6Wm1WeUNpQWdJQ0F2THlBZ0lDQWdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZOVGt0TmpRS0lDQWdJQzh2SUNNZ1VHVnlabTl5YlNCaGMzTmxkQ0IwY21GdWMyWmxjZ29nSUNBZ0x5OGdJQ0FnSUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1MbUZ6YzJWMGFXUXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHhMQW9nSUNBZ0x5OGdJQ0FnSUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3huYjNoaGJtZGxMbU52Ym5SeVlXTjBMa0ZzWjI5NFlXNW5aUzVrWld4bGRHVmZZWEJ3YkdsallYUnBiMjRvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1ZmWVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzaGhibWRsTDJOdmJuUnlZV04wTG5CNU9qWTVDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpFdE9ERUtJQ0FnSUM4dklDTWdVMlZ1WkNCaGJHd2dkR2hsSUhWdWMyOXNaQ0JoYzNObGRITWdkRzhnZEdobElHTnlaV0YwYjNJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWE5sYkdZdVlYTnpaWFJwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUNNZ1ZHaGxJR0Z0YjNWdWRDQnBjeUF3TENCaWRYUWdkR2hsSUdGemMyVjBYMk5zYjNObFgzUnZJR1pwWld4a0lHbHpJSE5sZEFvZ0lDQWdMeThnSUNBZ0lDTWdWR2hwY3lCdFpXRnVjeUIwYUdGMElFRk1UQ0JoYzNObGRITWdZWEpsSUdKbGFXNW5JSE5sYm5RZ2RHOGdkR2hsSUdGemMyVjBYMk5zYjNObFgzUnZJR0ZrWkhKbGMzTUtJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDQWdJQ0FqSUVOc2IzTmxJSFJvWlNCaGMzTmxkQ0IwYnlCMWJteHZZMnNnZEdobElEQXVNU0JCVEVkUElIUm9ZWFFnZDJGeklHeHZZMnRsWkNCcGJpQnZjSFJmYVc1ZmRHOWZZWE56WlhRS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5amJHOXpaVjkwYnoxSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHhYekF3TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROWMyVnNaaTVoYzNObGRHbGtMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnpjMlYwYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhScFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZOemd0TnprS0lDQWdJQzh2SUNNZ1EyeHZjMlVnZEdobElHRnpjMlYwSUhSdklIVnViRzlqYXlCMGFHVWdNQzR4SUVGTVIwOGdkR2hoZENCM1lYTWdiRzlqYTJWa0lHbHVJRzl3ZEY5cGJsOTBiMTloYzNObGRBb2dJQ0FnTHk4Z1lYTnpaWFJmWTJ4dmMyVmZkRzg5UjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRU5zYjNObFZHOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZlR0Z1WjJVdlkyOXVkSEpoWTNRdWNIazZOelV0TnpjS0lDQWdJQzh2SUNNZ1ZHaGxJR0Z0YjNWdWRDQnBjeUF3TENCaWRYUWdkR2hsSUdGemMyVjBYMk5zYjNObFgzUnZJR1pwWld4a0lHbHpJSE5sZEFvZ0lDQWdMeThnSXlCVWFHbHpJRzFsWVc1eklIUm9ZWFFnUVV4TUlHRnpjMlYwY3lCaGNtVWdZbVZwYm1jZ2MyVnVkQ0IwYnlCMGFHVWdZWE56WlhSZlkyeHZjMlZmZEc4Z1lXUmtjbVZ6Y3dvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUbzNNUzAzTWdvZ0lDQWdMeThnSXlCVFpXNWtJR0ZzYkNCMGFHVWdkVzV6YjJ4a0lHRnpjMlYwY3lCMGJ5QjBhR1VnWTNKbFlYUnZjZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh5SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM2hoYm1kbEwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJtWldVOU1WOHdNREFzQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk56RXRPREVLSUNBZ0lDOHZJQ01nVTJWdVpDQmhiR3dnZEdobElIVnVjMjlzWkNCaGMzTmxkSE1nZEc4Z2RHaGxJR055WldGMGIzSUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFhObGJHWXVZWE56WlhScFpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lDTWdWR2hsSUdGdGIzVnVkQ0JwY3lBd0xDQmlkWFFnZEdobElHRnpjMlYwWDJOc2IzTmxYM1J2SUdacFpXeGtJR2x6SUhObGRBb2dJQ0FnTHk4Z0lDQWdJQ01nVkdocGN5QnRaV0Z1Y3lCMGFHRjBJRUZNVENCaGMzTmxkSE1nWVhKbElHSmxhVzVuSUhObGJuUWdkRzhnZEdobElHRnpjMlYwWDJOc2IzTmxYM1J2SUdGa1pISmxjM01LSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNBaklFTnNiM05sSUhSb1pTQmhjM05sZENCMGJ5QjFibXh2WTJzZ2RHaGxJREF1TVNCQlRFZFBJSFJvWVhRZ2QyRnpJR3h2WTJ0bFpDQnBiaUJ2Y0hSZmFXNWZkRzlmWVhOelpYUUtJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWpiRzl6WlY5MGJ6MUhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB4WHpBd01Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzaGhibWRsTDJOdmJuUnlZV04wTG5CNU9qZ3pMVGt3Q2lBZ0lDQXZMeUFqSUZObGJtUWdkR2hsSUhKbGJXRnBibWx1WnlCaVlXeGhibU5sSUhSdklIUm9aU0JqY21WaGRHOXlDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVIyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5TUN3S0lDQWdJQzh2SUNBZ0lDQWpJRU5zYjNObElIUm9aU0JoWTJOdmRXNTBJSFJ2SUdkbGRDQmlZV05ySUVGTVRDQjBhR1VnUVV4SFR5QnBiaUIwYUdVZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sWDNKbGJXRnBibVJsY2w5MGJ6MUhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB4WHpBd01Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmVHRnVaMlV2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklISmxZMlZwZG1WeVBVZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2ZUdGdVoyVXZZMjl1ZEhKaFkzUXVjSGs2T0RjdE9EZ0tJQ0FnSUM4dklDTWdRMnh2YzJVZ2RHaGxJR0ZqWTI5MWJuUWdkRzhnWjJWMElHSmhZMnNnUVV4TUlIUm9aU0JCVEVkUElHbHVJSFJvWlNCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJqYkc5elpWOXlaVzFoYVc1a1pYSmZkRzg5UjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHOXpaVkpsYldGcGJtUmxjbFJ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCaGJXOTFiblE5TUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5NFlXNW5aUzlqYjI1MGNtRmpkQzV3ZVRvNE15MDROQW9nSUNBZ0x5OGdJeUJUWlc1a0lIUm9aU0J5WlcxaGFXNXBibWNnWW1Gc1lXNWpaU0IwYnlCMGFHVWdZM0psWVhSdmNnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOTRZVzVuWlM5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdabVZsUFRGZk1EQXdMQW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNoaGJtZGxMMk52Ym5SeVlXTjBMbkI1T2pnekxUa3dDaUFnSUNBdkx5QWpJRk5sYm1RZ2RHaGxJSEpsYldGcGJtbHVaeUJpWVd4aGJtTmxJSFJ2SUhSb1pTQmpjbVZoZEc5eUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5UjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNBaklFTnNiM05sSUhSb1pTQmhZMk52ZFc1MElIUnZJR2RsZENCaVlXTnJJRUZNVENCMGFHVWdRVXhIVHlCcGJpQjBhR1VnWVdOamIzVnVkQW9nSUNBZ0x5OGdJQ0FnSUdOc2IzTmxYM0psYldGcGJtUmxjbDkwYnoxSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHhYekF3TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVFBRTZBY21BZ2RoYzNObGRHbGtESFZ1YVhSaGNubHdjbWxqWlRFYlFRQTRnZ2NFaDR5N1BRUU1McjZWQk14MkFEY0VGWFJUV2dTdGE5OE1CSldOUGZrRU03TkpuallhQUk0SEFINEFiQUJjQUVZQUpnQVFBQUlqUXpFWmdRVVNSREVZUklnQlRTSkRNUmtVUkRFWVJERVdJZ2xKT0JBaUVrU0lBUVFpUXpFWkZFUXhHRVF4RmlJSlNUZ1FJaEpFaUFEQkZvQUVGUjk4ZFV4UXNDSkRNUmtVUkRFWVJERVdJZ2xKT0JBaUVrU0lBR01pUXpFWkZFUXhHRVEyR2dFWGlBQkZJa014R1JSRU1SaEVOaG9CRjhBd2lBQWxJa014R1JSRU1SZ1VSRFlhQVJmQU1EWWFBaGVJQUFJaVE0b0NBQ2lML21jcGkvOW5pWW9CQURFQU1na1NSQ2lMLzJlSmlnRUFNUUF5Q1JKRUtZdi9aNG1LQVFBeEFESUpFa1F5Q2lNb1pVUndBRVVCRkVTTC96Z0hNZ29TUkl2L09BZ3lBVElRQ0JKRXNTTW9aVVF5Q2lPeUVySVVzaEVrc2hBanNnR3ppWW9CQVl2L09BQXhBQk5CQUFJaWlZdi9PQWN5Q2hOQkFBT0JBb21ML3pnSUl5bGxSQk5CQUFPQkE0a2ppWW9CQUl2L09BQXhBQkpFaS84NEJ6SUtFa1NML3pnSUl5bGxSQkpFc1NNb1pVUXhBQ0t5RXJJVXNoRWtzaEFqc2dHemlURUFNZ2tTUkxFaktHVkVNZ2xKc2hVanNoS3lGTElSSkxJUUpiSUJzN0V5Q1VteUNTT3lDTElISXJJUUpiSUJzNGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
