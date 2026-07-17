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

namespace Arc56.Generated.algorandfoundation.puya.ValidationContract_e5178a19
{


    public class ValidationContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ValidationContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint64(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 123, 143, 223 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint64_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 123, 143, 223 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint8(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 151, 187, 177 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint8_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 151, 187, 177 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint512(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 28, 249, 65 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint512_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 28, 249, 65 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUfixed64(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 206, 233, 15 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUfixed64_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 206, 233, 15 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint8Arr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 235, 247, 28 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint8Arr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 235, 247, 28 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint8Arr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 250, 80, 64 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint8Arr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 250, 80, 64 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBool(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 4, 207, 27 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBool_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 4, 207, 27 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateByte(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 209, 109, 152 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateByte_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 209, 109, 152 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateString(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 151, 248, 180 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateString_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 151, 248, 180 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBytes(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 104, 183, 209 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBytes_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 104, 183, 209 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateAddress(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 91, 165, 174 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateAddress_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 91, 165, 174 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateAccount(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 73, 187, 202 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateAccount_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 73, 187, 202 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBoolArr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 213, 106, 252 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBoolArr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 213, 106, 252 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBoolArr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 71, 13, 192 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBoolArr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 71, 13, 192 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateStaticTuple(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 143, 105, 96 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticTuple_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 143, 105, 96 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateDynamicTuple(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 12, 68, 154 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicTuple_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 12, 68, 154 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateStaticStruct(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 238, 67, 81 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticStruct_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 238, 67, 81 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateDynamicStruct(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 158, 19, 250 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStruct_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 158, 19, 250 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateStaticStructArr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 208, 206, 175 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticStructArr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 208, 206, 175 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateStaticStructArr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 207, 233, 77 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticStructArr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 207, 233, 77 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateDynamicStructArr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 76, 130, 53 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStructArr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 76, 130, 53 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateDynamicStructArr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 234, 124, 129 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStructArr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 234, 124, 129 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateDynamicStructWithABool(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 121, 177, 218 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStructWithABool_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 121, 177, 218 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeDynamicStructImmArr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 118, 121, 169 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStructImmArr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 118, 121, 169 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeDynamicStructImmArr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 219, 148, 104 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStructImmArr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 219, 148, 104 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task DecodeUint64WithValidate(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 149, 133, 240 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DecodeUint64WithValidate_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 149, 133, 240 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task DecodeUint64WithoutValidate(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 229, 156, 103 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DecodeUint64WithoutValidate_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 229, 156, 103 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeStaticStruct(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 33, 218, 107 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeStaticStruct_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 33, 218, 107 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeDynamicStruct(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 109, 138, 181 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStruct_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 109, 138, 181 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeStaticStructArr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 211, 103, 120 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeStaticStructArr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 211, 103, 120 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeStaticStructArr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 144, 254, 107 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeStaticStructArr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 144, 254, 107 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeDynamicStructArr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 33, 231, 232 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStructArr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 33, 231, 232 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateNativeDynamicStructArr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 144, 246, 226 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStructArr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 144, 246, 226 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmFsaWRhdGlvbkNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InZhbGlkYXRlX3VpbnQ2NCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV91aW50OCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV91aW50NTEyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX3VmaXhlZDY0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX3VpbnQ4X2FyciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV91aW50OF9hcnIzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX2Jvb2wiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYnl0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9zdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9hY2NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX2Jvb2xfYXJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX2Jvb2xfYXJyMyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9zdGF0aWNfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfZHluYW1pY190dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9zdGF0aWNfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX2R5bmFtaWNfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX3N0YXRpY19zdHJ1Y3RfYXJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX3N0YXRpY19zdHJ1Y3RfYXJyMyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9keW5hbWljX3N0cnVjdF9hcnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfZHluYW1pY19zdHJ1Y3RfYXJyMyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9keW5hbWljX3N0cnVjdF93aXRoX2FfYm9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9uYXRpdmVfZHluYW1pY19zdHJ1Y3RfaW1tX2FyciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9uYXRpdmVfZHluYW1pY19zdHJ1Y3RfaW1tX2FycjMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVjb2RlX3VpbnQ2NF93aXRoX3ZhbGlkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlY29kZV91aW50NjRfd2l0aG91dF92YWxpZGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9uYXRpdmVfc3RhdGljX3N0cnVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9uYXRpdmVfZHluYW1pY19zdHJ1Y3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfbmF0aXZlX3N0YXRpY19zdHJ1Y3RfYXJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX25hdGl2ZV9zdGF0aWNfc3RydWN0X2FycjMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfbmF0aXZlX2R5bmFtaWNfc3RydWN0X2FyciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9uYXRpdmVfZHluYW1pY19zdHJ1Y3RfYXJyMyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYyOSw3MDEsODIxLDg5NywxMTE0LDExOTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI5LDM4Myw0MDAsNDQzLDUwNiw1NTAsNTY2LDU5OSw2NTYsNzI4LDc3MCw3OTEsODQ4LDkyNCw5NDcsOTcwLDEwMjMsMTA0MywxMDg0LDExNDEsMTIxN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC5ib29sPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNSwzODksNDA2LDk1NCw5NzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx0ZXN0X2Nhc2VzLmFyYzRfdmFsaWRhdGlvbi5jb250cmFjdC5BUkM0RHluYW1pY1N0cnVjdD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0LkFSQzRGcm96ZW5EeW5hbWljU3RydWN0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dGVzdF9jYXNlcy5hcmM0X3ZhbGlkYXRpb24uY29udHJhY3QuQVJDNFN0YXRpY1N0cnVjdD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx0ZXN0X2Nhc2VzLmFyYzRfdmFsaWRhdGlvbi5jb250cmFjdC5OYXRpdmVEeW5hbWljU3RydWN0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0Lk5hdGl2ZVN0YXRpY1N0cnVjdD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC5ib29sLCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8dGVzdF9jYXNlcy5hcmM0X3ZhbGlkYXRpb24uY29udHJhY3QuQVJDNER5bmFtaWNTdHJ1Y3QsIDM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0LkFSQzRGcm96ZW5EeW5hbWljU3RydWN0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTx0ZXN0X2Nhc2VzLmFyYzRfdmFsaWRhdGlvbi5jb250cmFjdC5BUkM0U3RhdGljU3RydWN0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8dGVzdF9jYXNlcy5hcmM0X3ZhbGlkYXRpb24uY29udHJhY3QuTmF0aXZlRHluYW1pY1N0cnVjdCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0Lk5hdGl2ZVN0YXRpY1N0cnVjdCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC50dXBsZTxhcmM0LnVpbnQ2NCxhcmM0LnVpbnQ4LGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC50dXBsZTxhcmM0LnVpbnQ2NCxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVmaXhlZDY0eDIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkyLDM3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0LkFSQzREeW5hbWljU3RydWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0LkFSQzRTdGF0aWNTdHJ1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0Lk5hdGl2ZUR5bmFtaWNTdHJ1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy5hcmM0X3ZhbGlkYXRpb24uY29udHJhY3QuTmF0aXZlU3RhdGljU3RydWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMuYXJjNF92YWxpZGF0aW9uLmNvbnRyYWN0LldpdGhBQm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB1aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50OCwobGVuK3VpbnQ4W10pLGJvb2wxKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OCw1NDIsNjUyLDcyNCw4NDQsOTIwLDEwMTUsMTEzNywxMjEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMiBvZiAodWludDY0LHVpbnQ4LChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzcsODI5LDExMjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisodWludDY0LHVpbnQ4LChsZW4rdXRmOFtdKSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDksOTA1LDExOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKHVpbnQ2NCx1aW50OCwobGVuK3V0ZjhbXSkpWzNdIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDkzLDUzNyw2NDcsNzE5LDc1Nyw4MzksOTE1LDEwMTAsMTEzMiwxMjA4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTWlBNUNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKMklnb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QmpiR0Z6Y3lCV1lXeHBaR0YwYVc5dVEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBMQ0J6ZEdGMFpWOTBiM1JoYkhNOVUzUmhkR1ZVYjNSaGJITW9aMnh2WW1Gc1gySjVkR1Z6UFRFcEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRRFF3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcxTlRkaU9HWmtaaUF3ZURZeE9UZGlZbUl4SURCNFlUVXhZMlk1TkRFZ01IZzRaV05sWlRrd1ppQXdlRFF5WldKbU56RmpJREI0T1RabVlUVXdOREFnTUhnd05qQTBZMll4WWlBd2VEQm1aREUyWkRrNElEQjRNR1U1TjJZNFlqUWdNSGd6WmpZNFlqZGtNU0F3ZURFM05XSmhOV0ZsSURCNFpXUTBPV0ppWTJFZ01IZ3dNbVExTm1GbVl5QXdlREZqTkRjd1pHTXdJREI0TWpRNFpqWTVOakFnTUhobU1EQmpORFE1WVNBd2VHUXlaV1UwTXpVeElEQjROV1k1WlRFelptRWdNSGd6TkdRd1kyVmhaaUF3ZURoaFkyWmxPVFJrSURCNE1EQTBZemd5TXpVZ01IZzBNbVZoTjJNNE1TQXdlRGsxTnpsaU1XUmhJREI0TmpZM05qYzVZVGtnTUhnelptUmlPVFEyT0NBd2VEUmhPVFU0TldZd0lEQjRabUpsTlRsak5qY2dNSGhqTWpJeFpHRTJZaUF3ZURVMk5tUTRZV0kxSURCNFpXSmtNelkzTnpnZ01IZzNOamt3Wm1VMllpQXdlR1kzTWpGbE4yVTRJREI0TjJNNU1HWTJaVElnTHk4Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5MWFXNTBOalFvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgzVnBiblE0S0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOTFhVzUwTlRFeUtHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjkxWm1sNFpXUTJOQ2hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWRtRnNhV1JoZEdWZmRXbHVkRGhmWVhKeUtHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjkxYVc1ME9GOWhjbkl6S0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOWliMjlzS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOWllWFJsS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOXpkSEpwYm1jb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJblpoYkdsa1lYUmxYMko1ZEdWektHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjloWkdSeVpYTnpLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5aFkyTnZkVzUwS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOWliMjlzWDJGeWNpaGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1Gc2FXUmhkR1ZmWW05dmJGOWhjbkl6S0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOXpkR0YwYVdOZmRIVndiR1VvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmRIVndiR1VvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgzTjBZWFJwWTE5emRISjFZM1FvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNpaGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1Gc2FXUmhkR1ZmYzNSaGRHbGpYM04wY25WamRGOWhjbkl6S0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSW9ZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pNb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgzZHBkR2hmWVY5aWIyOXNLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZhVzF0WDJGeWNpaGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgybHRiVjloY25JektHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0prWldOdlpHVmZkV2x1ZERZMFgzZHBkR2hmZG1Gc2FXUmhkR1VvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxZMjlrWlY5MWFXNTBOalJmZDJsMGFHOTFkRjkyWVd4cFpHRjBaU2hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWRtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUW9ZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5aaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRDaGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWhjbkl6S0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjJZV3hwWkdGMFpWOXVZWFJwZG1WZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeUtHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNeWhpZVhSbFcxMHBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lIWmhiR2xrWVhSbFgzVnBiblEyTkNCMllXeHBaR0YwWlY5MWFXNTBPQ0IyWVd4cFpHRjBaVjkxYVc1ME5URXlJSFpoYkdsa1lYUmxYM1ZtYVhobFpEWTBJSFpoYkdsa1lYUmxYM1ZwYm5RNFgyRnljaUIyWVd4cFpHRjBaVjkxYVc1ME9GOWhjbkl6SUhaaGJHbGtZWFJsWDJKdmIyd2dkbUZzYVdSaGRHVmZZbmwwWlNCMllXeHBaR0YwWlY5emRISnBibWNnZG1Gc2FXUmhkR1ZmWW5sMFpYTWdkbUZzYVdSaGRHVmZZV1JrY21WemN5QjJZV3hwWkdGMFpWOWhZMk52ZFc1MElIWmhiR2xrWVhSbFgySnZiMnhmWVhKeUlIWmhiR2xrWVhSbFgySnZiMnhmWVhKeU15QjJZV3hwWkdGMFpWOXpkR0YwYVdOZmRIVndiR1VnZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTkwZFhCc1pTQjJZV3hwWkdGMFpWOXpkR0YwYVdOZmMzUnlkV04wSUhaaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBJSFpoYkdsa1lYUmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlJSFpoYkdsa1lYUmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlNeUIyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbklnZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5TXlCMllXeHBaR0YwWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjkzYVhSb1gyRmZZbTl2YkNCMllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZhVzF0WDJGeWNpQjJZV3hwWkdGMFpWOXVZWFJwZG1WZlpIbHVZVzFwWTE5emRISjFZM1JmYVcxdFgyRnljak1nWkdWamIyUmxYM1ZwYm5RMk5GOTNhWFJvWDNaaGJHbGtZWFJsSUdSbFkyOWtaVjkxYVc1ME5qUmZkMmwwYUc5MWRGOTJZV3hwWkdGMFpTQjJZV3hwWkdGMFpWOXVZWFJwZG1WZmMzUmhkR2xqWDNOMGNuVmpkQ0IyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNRZ2RtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5SUhaaGJHbGtZWFJsWDI1aGRHbDJaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgyRnljak1nZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljaUIyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURRd09nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZelJmZG1Gc2FXUmhkR2x2Ymk1amIyNTBjbUZqZEM1V1lXeHBaR0YwYVc5dVEyOXVkSEpoWTNRdWRtRnNhV1JoZEdWZmRXbHVkRFkwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtRnNhV1JoZEdWZmRXbHVkRFkwT2dvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPall4Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkM1bWNtOXRYMko1ZEdWektIWmhiSFZsS1M1MllXeHBaR0YwWlNncENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYSmpORjkyWVd4cFpHRjBhVzl1TG1OdmJuUnlZV04wTGxaaGJHbGtZWFJwYjI1RGIyNTBjbUZqZEM1MllXeHBaR0YwWlY5MWFXNTBPRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsWDNWcGJuUTRPZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9kbUZzYVdSaGRHVmZaVzVqYjJScGJtYzlJblZ1YzJGbVpWOWthWE5oWW14bFpDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTRMbVp5YjIxZllubDBaWE1vZG1Gc2RXVXBMblpoYkdsa1lYUmxLQ2tLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhKak5GOTJZV3hwWkdGMGFXOXVMbU52Ym5SeVlXTjBMbFpoYkdsa1lYUnBiMjVEYjI1MGNtRmpkQzUyWVd4cFpHRjBaVjkxYVc1ME5URXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmZFdsdWREVXhNam9LSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOVEV5TG1aeWIyMWZZbmwwWlhNb2RtRnNkV1VwTG5aaGJHbGtZWFJsS0NrS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDJZV3hwWkdGMFpWOWxibU52WkdsdVp6MGlkVzV6WVdabFgyUnBjMkZpYkdWa0lpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZelJmZG1Gc2FXUmhkR2x2Ymk1amIyNTBjbUZqZEM1V1lXeHBaR0YwYVc5dVEyOXVkSEpoWTNRdWRtRnNhV1JoZEdWZmRXWnBlR1ZrTmpSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOTFabWw0WldRMk5Eb0tJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvM013b2dJQ0FnTHk4Z1lYSmpOQzVWUm1sNFpXUk9lRTFiZEhsd2FXNW5Ma3hwZEdWeVlXeGJOalJkTENCMGVYQnBibWN1VEdsMFpYSmhiRnN5WFYwdVpuSnZiVjlpZVhSbGN5aDJZV3gxWlNrdWRtRnNhV1JoZEdVb0tRb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdacGVHVmtOalI0TWdvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21NMFgzWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVWbUZzYVdSaGRHbHZia052Ym5SeVlXTjBMblpoYkdsa1lYUmxYM1ZwYm5RNFgyRnljbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsWDNWcGJuUTRYMkZ5Y2pvS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvM05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8zTndvZ0lDQWdMeThnWVhKak5DNUVlVzVoYldsalFYSnlZWGxiWVhKak5DNVZTVzUwT0YwdVpuSnZiVjlpZVhSbGN5aDJZV3gxWlNrdWRtRnNhV1JoZEdVb0tRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2gyWVd4cFpHRjBaVjlsYm1OdlpHbHVaejBpZFc1ellXWmxYMlJwYzJGaWJHVmtJaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUZ5WXpSZmRtRnNhV1JoZEdsdmJpNWpiMjUwY21GamRDNVdZV3hwWkdGMGFXOXVRMjl1ZEhKaFkzUXVkbUZzYVdSaGRHVmZkV2x1ZERoZllYSnlNMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsWDNWcGJuUTRYMkZ5Y2pNNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoMllXeHBaR0YwWlY5bGJtTnZaR2x1WnowaWRXNXpZV1psWDJScGMyRmliR1ZrSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUdGeVl6UXVVM1JoZEdsalFYSnlZWGxiWVhKak5DNVZTVzUwT0N3Z2RIbHdhVzVuTGt4cGRHVnlZV3hiTTExZExtWnliMjFmWW5sMFpYTW9kbUZzZFdVcExuWmhiR2xrWVhSbEtDa0tJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6UGdvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21NMFgzWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVWbUZzYVdSaGRHbHZia052Ym5SeVlXTjBMblpoYkdsa1lYUmxYMkp2YjJ4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOWliMjlzT2dvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pnekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamcxQ2lBZ0lDQXZMeUJoY21NMExrSnZiMnd1Wm5KdmJWOWllWFJsY3loMllXeDFaU2t1ZG1Gc2FXUmhkR1VvS1FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoMllXeHBaR0YwWlY5bGJtTnZaR2x1WnowaWRXNXpZV1psWDJScGMyRmliR1ZrSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVXWVd4cFpHRjBhVzl1UTI5dWRISmhZM1F1ZG1Gc2FXUmhkR1ZmWW5sMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpoYkdsa1lYUmxYMko1ZEdVNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoMllXeHBaR0YwWlY5bGJtTnZaR2x1WnowaWRXNXpZV1psWDJScGMyRmliR1ZrSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUdGeVl6UXVRbmwwWlM1bWNtOXRYMko1ZEdWektIWmhiSFZsS1M1MllXeHBaR0YwWlNncENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTRDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDJZV3hwWkdGMFpWOWxibU52WkdsdVp6MGlkVzV6WVdabFgyUnBjMkZpYkdWa0lpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZelJmZG1Gc2FXUmhkR2x2Ymk1amIyNTBjbUZqZEM1V1lXeHBaR0YwYVc5dVEyOXVkSEpoWTNRdWRtRnNhV1JoZEdWZmMzUnlhVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtRnNhV1JoZEdWZmMzUnlhVzVuT2dvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2preENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJoY21NMExsTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektIWmhiSFZsS1M1MllXeHBaR0YwWlNncENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG81TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEpqTkY5MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExsWmhiR2xrWVhScGIyNURiMjUwY21GamRDNTJZV3hwWkdGMFpWOWllWFJsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgySjVkR1Z6T2dvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJoY21NMExrUjVibUZ0YVdOQ2VYUmxjeTVtY205dFgySjVkR1Z6S0haaGJIVmxLUzUyWVd4cFpHRjBaU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzVOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYSmpORjkyWVd4cFpHRjBhVzl1TG1OdmJuUnlZV04wTGxaaGJHbGtZWFJwYjI1RGIyNTBjbUZqZEM1MllXeHBaR0YwWlY5aFpHUnlaWE56VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtRnNhV1JoZEdWZllXUmtjbVZ6Y3pvS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUdGeVl6UXVRV1JrY21WemN5NW1jbTl0WDJKNWRHVnpLSFpoYkhWbEtTNTJZV3hwWkdGMFpTZ3BDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2RtRnNhV1JoZEdWZlpXNWpiMlJwYm1jOUluVnVjMkZtWlY5a2FYTmhZbXhsWkNJcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNtTTBYM1poYkdsa1lYUnBiMjR1WTI5dWRISmhZM1F1Vm1Gc2FXUmhkR2x2YmtOdmJuUnlZV04wTG5aaGJHbGtZWFJsWDJGalkyOTFiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5aFkyTnZkVzUwT2dvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUVGalkyOTFiblF1Wm5KdmJWOWllWFJsY3loMllXeDFaU2t1ZG1Gc2FXUmhkR1VvS1FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21NMFgzWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVWbUZzYVdSaGRHbHZia052Ym5SeVlXTjBMblpoYkdsa1lYUmxYMkp2YjJ4ZllYSnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmWW05dmJGOWhjbkk2Q2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3T1FvZ0lDQWdMeThnWVhKak5DNUVlVzVoYldsalFYSnlZWGxiWVhKak5DNUNiMjlzWFM1bWNtOXRYMko1ZEdWektIWmhiSFZsS1M1MllXeHBaR0YwWlNncENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURjS0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTHdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVZbTl2YkQ0S0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoMllXeHBaR0YwWlY5bGJtTnZaR2x1WnowaWRXNXpZV1psWDJScGMyRmliR1ZrSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVXWVd4cFpHRjBhVzl1UTI5dWRISmhZM1F1ZG1Gc2FXUmhkR1ZmWW05dmJGOWhjbkl6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtRnNhV1JoZEdWZlltOXZiRjloY25Jek9nb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1UTUtJQ0FnSUM4dklHRnlZelF1VTNSaGRHbGpRWEp5WVhsYllYSmpOQzVDYjI5c0xDQjBlWEJwYm1jdVRHbDBaWEpoYkZzelhWMHVabkp2YlY5aWVYUmxjeWgyWVd4MVpTa3VkbUZzYVdSaGRHVW9LUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNWliMjlzTENBelBnb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYSmpORjkyWVd4cFpHRjBhVzl1TG1OdmJuUnlZV04wTGxaaGJHbGtZWFJwYjI1RGIyNTBjbUZqZEM1MllXeHBaR0YwWlY5emRHRjBhV05mZEhWd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWVd4cFpHRjBaVjl6ZEdGMGFXTmZkSFZ3YkdVNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2RtRnNhV1JoZEdWZlpXNWpiMlJwYm1jOUluVnVjMkZtWlY5a2FYTmhZbXhsWkNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z1FWSkRORk4wWVhScFkxUjFjR3hsTG1aeWIyMWZZbmwwWlhNb2RtRnNkV1VwTG5aaGJHbGtZWFJsS0NrS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZEhWd2JHVThZWEpqTkM1MWFXNTBOalFzWVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoMllXeHBaR0YwWlY5bGJtTnZaR2x1WnowaWRXNXpZV1psWDJScGMyRmliR1ZrSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVXWVd4cFpHRjBhVzl1UTI5dWRISmhZM1F1ZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTkwZFhCc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZkSFZ3YkdVNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2RtRnNhV1JoZEdWZlpXNWpiMlJwYm1jOUluVnVjMkZtWlY5a2FYTmhZbXhsWkNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1FWSkRORVI1Ym1GdGFXTlVkWEJzWlM1bWNtOXRYMko1ZEdWektIWmhiSFZsS1M1MllXeHBaR0YwWlNncENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElESWdiMllnS0hWcGJuUTJOQ3gxYVc1ME9Dd29iR1Z1SzNWMFpqaGJYU2twQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE13b2dJQ0FnS3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MGRYQnNaVHhoY21NMExuVnBiblEyTkN4aGNtTTBMblZwYm5RNExHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQajRLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2gyWVd4cFpHRjBaVjlsYm1OdlpHbHVaejBpZFc1ellXWmxYMlJwYzJGaWJHVmtJaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUZ5WXpSZmRtRnNhV1JoZEdsdmJpNWpiMjUwY21GamRDNVdZV3hwWkdGMGFXOXVRMjl1ZEhKaFkzUXVkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgzTjBZWFJwWTE5emRISjFZM1E2Q2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV5TlFvZ0lDQWdMeThnUVZKRE5GTjBZWFJwWTFOMGNuVmpkQzVtY205dFgySjVkR1Z6S0haaGJIVmxLUzUyWVd4cFpHRjBaU2dwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBYMk5oYzJWekxtRnlZelJmZG1Gc2FXUmhkR2x2Ymk1amIyNTBjbUZqZEM1QlVrTTBVM1JoZEdsalUzUnlkV04wQ2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21NMFgzWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVWbUZzYVdSaGRHbHZia052Ym5SeVlXTjBMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNRNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1USTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2RtRnNhV1JoZEdWZlpXNWpiMlJwYm1jOUluVnVjMkZtWlY5a2FYTmhZbXhsWkNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1FWSkRORVI1Ym1GdGFXTlRkSEoxWTNRdVpuSnZiVjlpZVhSbGN5aDJZV3gxWlNrdWRtRnNhV1JoZEdVb0tRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnT1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXlJRzltSUNoMWFXNTBOalFzZFdsdWREZ3NLR3hsYml0MWRHWTRXMTBwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UTUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSFJsYzNSZlkyRnpaWE11WVhKak5GOTJZV3hwWkdGMGFXOXVMbU52Ym5SeVlXTjBMa0ZTUXpSRWVXNWhiV2xqVTNSeWRXTjBDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9kbUZzYVdSaGRHVmZaVzVqYjJScGJtYzlJblZ1YzJGbVpWOWthWE5oWW14bFpDSXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NWhjbU0wWDNaaGJHbGtZWFJwYjI0dVkyOXVkSEpoWTNRdVZtRnNhV1JoZEdsdmJrTnZiblJ5WVdOMExuWmhiR2xrWVhSbFgzTjBZWFJwWTE5emRISjFZM1JmWVhKeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSTZDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9kbUZzYVdSaGRHVmZaVzVqYjJScGJtYzlJblZ1YzJGbVpWOWthWE5oWW14bFpDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdZWEpqTkM1RWVXNWhiV2xqUVhKeVlYbGJRVkpETkZOMFlYUnBZMU4wY25WamRGMHVabkp2YlY5aWVYUmxjeWgyWVd4MVpTa3VkbUZzYVdSaGRHVW9LUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRGtLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDBaWE4wWDJOaGMyVnpMbUZ5WXpSZmRtRnNhV1JoZEdsdmJpNWpiMjUwY21GamRDNUJVa00wVTNSaGRHbGpVM1J5ZFdOMFBnb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYSmpORjkyWVd4cFpHRjBhVzl1TG1OdmJuUnlZV04wTGxaaGJHbGtZWFJwYjI1RGIyNTBjbUZqZEM1MllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2pOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNqTTZDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9kbUZzYVdSaGRHVmZaVzVqYjJScGJtYzlJblZ1YzJGbVpWOWthWE5oWW14bFpDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdZWEpqTkM1VGRHRjBhV05CY25KaGVWdEJVa00wVTNSaGRHbGpVM1J5ZFdOMExDQjBlWEJwYm1jdVRHbDBaWEpoYkZzelhWMHVabkp2YlY5aWVYUmxjeWgyWVd4MVpTa3VkbUZzYVdSaGRHVW9LUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJM0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHgwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVCVWtNMFUzUmhkR2xqVTNSeWRXTjBMQ0F6UGdvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhKak5GOTJZV3hwWkdGMGFXOXVMbU52Ym5SeVlXTjBMbFpoYkdsa1lYUnBiMjVEYjI1MGNtRmpkQzUyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25JNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2RtRnNhV1JoZEdWZlpXNWpiMlJwYm1jOUluVnVjMkZtWlY5a2FYTmhZbXhsWkNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRReENpQWdJQ0F2THlCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0QlVrTTBSSGx1WVcxcFkxTjBjblZqZEYwdVpuSnZiVjlpZVhSbGN5aDJZV3gxWlNrdWRtRnNhV1JoZEdVb0tRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtDblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljbDltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UUXhDaUFnSUNBdkx5QmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdEJVa00wUkhsdVlXMXBZMU4wY25WamRGMHVabkp2YlY5aWVYUmxjeWgyWVd4MVpTa3VkbUZzYVdSaGRHVW9LUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1BBb2dJQ0FnWW5vZ2RtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeVgyRm1kR1Z5WDJadmNrQTFDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdadmNpQW9iR1Z1S3loMWFXNTBOalFzZFdsdWREZ3NLR3hsYml0MWRHWTRXMTBwS1Z0ZEtRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeUlHOW1JQ2gxYVc1ME5qUXNkV2x1ZERnc0tHeGxiaXQxZEdZNFcxMHBLUW9nSUNBZ2MzZGhjQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UTUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlIWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOW1iM0pmYUdWaFpHVnlRRElLQ25aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2w5aFpuUmxjbDltYjNKQU5Ub0tJQ0FnSUhCdmNHNGdNZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTVFvZ0lDQWdMeThnWVhKak5DNUVlVzVoYldsalFYSnlZWGxiUVZKRE5FUjVibUZ0YVdOVGRISjFZM1JkTG1aeWIyMWZZbmwwWlhNb2RtRnNkV1VwTG5aaGJHbGtZWFJsS0NrS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGRHVnpkRjlqWVhObGN5NWhjbU0wWDNaaGJHbGtZWFJwYjI0dVkyOXVkSEpoWTNRdVFWSkRORVI1Ym1GdGFXTlRkSEoxWTNRK0NpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2RtRnNhV1JoZEdWZlpXNWpiMlJwYm1jOUluVnVjMkZtWlY5a2FYTmhZbXhsWkNJcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNtTTBYM1poYkdsa1lYUnBiMjR1WTI5dWRISmhZM1F1Vm1Gc2FXUmhkR2x2YmtOdmJuUnlZV04wTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpPZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJR0Z5WXpRdVUzUmhkR2xqUVhKeVlYbGJRVkpETkVSNWJtRnRhV05UZEhKMVkzUXNJSFI1Y0dsdVp5NU1hWFJsY21Gc1d6TmRYUzVtY205dFgySjVkR1Z6S0haaGJIVmxLUzUyWVd4cFpHRjBaU2dwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NncDJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5EVUtJQ0FnSUM4dklHRnlZelF1VTNSaGRHbGpRWEp5WVhsYlFWSkRORVI1Ym1GdGFXTlRkSEoxWTNRc0lIUjVjR2x1Wnk1TWFYUmxjbUZzV3pOZFhTNW1jbTl0WDJKNWRHVnpLSFpoYkhWbEtTNTJZV3hwWkdGMFpTZ3BDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNMTloWm5SbGNsOW1iM0pBTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQm1iM0lnS0hWcGJuUTJOQ3gxYVc1ME9Dd29iR1Z1SzNWMFpqaGJYU2twV3pOZENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QTVDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURJZ2IyWWdLSFZwYm5RMk5DeDFhVzUwT0N3b2JHVnVLM1YwWmpoYlhTa3BDaUFnSUNCemQyRndDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE13b2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ2RtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeU0xOW1iM0pmYUdWaFpHVnlRRElLQ25aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pOZllXWjBaWEpmWm05eVFEVTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJR0Z5WXpRdVUzUmhkR2xqUVhKeVlYbGJRVkpETkVSNWJtRnRhV05UZEhKMVkzUXNJSFI1Y0dsdVp5NU1hWFJsY21Gc1d6TmRYUzVtY205dFgySjVkR1Z6S0haaGJIVmxLUzUyWVd4cFpHRjBaU2dwQ2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBIUmxjM1JmWTJGelpYTXVZWEpqTkY5MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExrRlNRelJFZVc1aGJXbGpVM1J5ZFdOMExDQXpQZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEpqTkY5MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExsWmhiR2xrWVhScGIyNURiMjUwY21GamRDNTJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5M2FYUm9YMkZmWW05dmJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgzZHBkR2hmWVY5aWIyOXNPZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hORGtLSUNBZ0lDOHZJRmRwZEdoQlFtOXZiQzVtY205dFgySjVkR1Z6S0haaGJIVmxLUzUyWVd4cFpHRjBaU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTVNCdlppQW9kV2x1ZERnc0tHeGxiaXQxYVc1ME9GdGRLU3hpYjI5c01Ta0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhSbGMzUmZZMkZ6WlhNdVlYSmpORjkyWVd4cFpHRjBhVzl1TG1OdmJuUnlZV04wTGxkcGRHaEJRbTl2YkFvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFME53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhKak5GOTJZV3hwWkdGMGFXOXVMbU52Ym5SeVlXTjBMbFpoYkdsa1lYUnBiMjVEYjI1MGNtRmpkQzUyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZmFXMXRYMkZ5Y2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjlwYlcxZllYSnlPZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUxTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTFNd29nSUNBZ0x5OGdZaUE5SUVkc2IySmhiRk4wWVhSbEtFSjVkR1Z6TENCclpYazlJbllpS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZGlJS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklHSXVkbUZzZFdVZ1BTQjJZV3gxWlFvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QnVMblpoYkhWbExuWmhiR2xrWVhSbEtDa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3AyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZmFXMXRYMkZ5Y2w5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFUyQ2lBZ0lDQXZMeUJ1TG5aaGJIVmxMblpoYkdsa1lYUmxLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lEd0tJQ0FnSUdKNklIWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjlwYlcxZllYSnlYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5aDFhVzUwTmpRc2RXbHVkRGdzS0d4bGJpdDFkR1k0VzEwcEtWdGRLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnT1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXlJRzltSUNoMWFXNTBOalFzZFdsdWREZ3NLR3hsYml0MWRHWTRXMTBwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVE1LSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJSFpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5cGJXMWZZWEp5WDJadmNsOW9aV0ZrWlhKQU1nb0tkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJsdGJWOWhjbkpmWVdaMFpYSmZabTl5UURVNkNpQWdJQ0J3YjNCdUlESUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOVFlLSUNBZ0lDOHZJRzR1ZG1Gc2RXVXVkbUZzYVdSaGRHVW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVCVWtNMFJuSnZlbVZ1UkhsdVlXMXBZMU4wY25WamRENEtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDJZV3hwWkdGMFpWOWxibU52WkdsdVp6MGlkVzV6WVdabFgyUnBjMkZpYkdWa0lpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZelJmZG1Gc2FXUmhkR2x2Ymk1amIyNTBjbUZqZEM1V1lXeHBaR0YwYVc5dVEyOXVkSEpoWTNRdWRtRnNhV1JoZEdWZmJtRjBhWFpsWDJSNWJtRnRhV05mYzNSeWRXTjBYMmx0YlY5aGNuSXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgybHRiVjloY25Jek9nb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTFPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFMk1Bb2dJQ0FnTHk4Z1lpQTlJRWRzYjJKaGJGTjBZWFJsS0VKNWRHVnpMQ0JyWlhrOUluWWlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkaUlLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TmpFS0lDQWdJQzh2SUdJdWRtRnNkV1VnUFNCMllXeDFaUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TmpNS0lDQWdJQzh2SUc0dWRtRnNkV1V1ZG1Gc2FXUmhkR1VvS1FvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb0tkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJsdGJWOWhjbkl6WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJRzR1ZG1Gc2RXVXVkbUZzYVdSaGRHVW9LUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRHdLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5cGJXMWZZWEp5TTE5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJtYjNJZ0tIVnBiblEyTkN4MWFXNTBPQ3dvYkdWdUszVjBaamhiWFNrcFd6TmRDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElESWdiMllnS0hWcGJuUTJOQ3gxYVc1ME9Dd29iR1Z1SzNWMFpqaGJYU2twQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXhNd29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJsdGJWOWhjbkl6WDJadmNsOW9aV0ZrWlhKQU1nb0tkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJsdGJWOWhjbkl6WDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UWXpDaUFnSUNBdkx5QnVMblpoYkhWbExuWmhiR2xrWVhSbEtDa0tJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4ZEdWemRGOWpZWE5sY3k1aGNtTTBYM1poYkdsa1lYUnBiMjR1WTI5dWRISmhZM1F1UVZKRE5FWnliM3BsYmtSNWJtRnRhV05UZEhKMVkzUXNJRE0rQ2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21NMFgzWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVWbUZzYVdSaGRHbHZia052Ym5SeVlXTjBMbVJsWTI5a1pWOTFhVzUwTmpSZmQybDBhRjkyWVd4cFpHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbFkyOWtaVjkxYVc1ME5qUmZkMmwwYUY5MllXeHBaR0YwWlRvS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUyTndvZ0lDQWdMeThnWVhKak5DNWtaV052WkdVb1ZVbHVkRFkwTENCMllXeDFaU2tLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIxYVc1ME5qUUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NWhjbU0wWDNaaGJHbGtZWFJwYjI0dVkyOXVkSEpoWTNRdVZtRnNhV1JoZEdsdmJrTnZiblJ5WVdOMExtUmxZMjlrWlY5MWFXNTBOalJmZDJsMGFHOTFkRjkyWVd4cFpHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbFkyOWtaVjkxYVc1ME5qUmZkMmwwYUc5MWRGOTJZV3hwWkdGMFpUb0tJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVXWVd4cFpHRjBhVzl1UTI5dWRISmhZM1F1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOXVZWFJwZG1WZmMzUmhkR2xqWDNOMGNuVmpkRG9LSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TnpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2gyWVd4cFpHRjBaVjlsYm1OdlpHbHVaejBpZFc1ellXWmxYMlJwYzJGaWJHVmtJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVGMxQ2lBZ0lDQXZMeUJpSUQwZ1IyeHZZbUZzVTNSaGRHVW9RbmwwWlhNc0lHdGxlVDBpZGlJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTNOZ29nSUNBZ0x5OGdZaTUyWVd4MVpTQTlJSFpoYkhWbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOemdLSUNBZ0lDOHZJRzR1ZG1Gc2RXVXVkbUZzYVdSaGRHVW9LUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZEdWemRGOWpZWE5sY3k1aGNtTTBYM1poYkdsa1lYUnBiMjR1WTI5dWRISmhZM1F1VG1GMGFYWmxVM1JoZEdsalUzUnlkV04wQ2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRjekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZG1Gc2FXUmhkR1ZmWlc1amIyUnBibWM5SW5WdWMyRm1aVjlrYVhOaFlteGxaQ0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY21NMFgzWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVWbUZzYVdSaGRHbHZia052Ym5SeVlXTjBMblpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRG9LSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94T0RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2gyWVd4cFpHRjBaVjlsYm1OdlpHbHVaejBpZFc1ellXWmxYMlJwYzJGaWJHVmtJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QmhjbU0wWDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVGd5Q2lBZ0lDQXZMeUJpSUQwZ1IyeHZZbUZzVTNSaGRHVW9RbmwwWlhNc0lHdGxlVDBpZGlJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMklnb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTRNd29nSUNBZ0x5OGdZaTUyWVd4MVpTQTlJSFpoYkhWbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPRFVLSUNBZ0lDOHZJRzR1ZG1Gc2RXVXVkbUZzYVdSaGRHVW9LUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z09Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F5SUc5bUlDaDFhVzUwTmpRc2RXbHVkRGdzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVE1LSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhSbGMzUmZZMkZ6WlhNdVlYSmpORjkyWVd4cFpHRjBhVzl1TG1OdmJuUnlZV04wTGs1aGRHbDJaVVI1Ym1GdGFXTlRkSEoxWTNRS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE9EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoMllXeHBaR0YwWlY5bGJtTnZaR2x1WnowaWRXNXpZV1psWDJScGMyRmliR1ZrSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVXWVd4cFpHRjBhVzl1UTI5dWRISmhZM1F1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlPZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakU0TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPRGtLSUNBZ0lDOHZJR0lnUFNCSGJHOWlZV3hUZEdGMFpTaENlWFJsY3l3Z2EyVjVQU0oySWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ZaUNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1Ua3dDaUFnSUNBdkx5QmlMblpoYkhWbElEMGdkbUZzZFdVS0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTVNZ29nSUNBZ0x5OGdiaTUyWVd4MVpTNTJZV3hwWkdGMFpTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBIUmxjM1JmWTJGelpYTXVZWEpqTkY5MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExrNWhkR2wyWlZOMFlYUnBZMU4wY25WamRENEtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPRGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDJZV3hwWkdGMFpWOWxibU52WkdsdVp6MGlkVzV6WVdabFgyUnBjMkZpYkdWa0lpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnlZelJmZG1Gc2FXUmhkR2x2Ymk1amIyNTBjbUZqZEM1V1lXeHBaR0YwYVc5dVEyOXVkSEpoWTNRdWRtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5TTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgyNWhkR2wyWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2pNNkNpQWdJQ0F2THlCaGNtTTBYM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UazBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2RtRnNhV1JoZEdWZlpXNWpiMlJwYm1jOUluVnVjMkZtWlY5a2FYTmhZbXhsWkNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFNU5nb2dJQ0FnTHk4Z1lpQTlJRWRzYjJKaGJGTjBZWFJsS0VKNWRHVnpMQ0JyWlhrOUluWWlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkaUlLSUNBZ0lDOHZJR0Z5WXpSZmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94T1RjS0lDQWdJQzh2SUdJdWRtRnNkV1VnUFNCMllXeDFaUW9nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRrNUNpQWdJQ0F2THlCdUxuWmhiSFZsTG5aaGJHbGtZWFJsS0NrS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOGRHVnpkRjlqWVhObGN5NWhjbU0wWDNaaGJHbGtZWFJwYjI0dVkyOXVkSEpoWTNRdVRtRjBhWFpsVTNSaGRHbGpVM1J5ZFdOMExDQXpQZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakU1TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEpqTkY5MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExsWmhiR2xrWVhScGIyNURiMjUwY21GamRDNTJZV3hwWkdGMFpWOXVZWFJwZG1WZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNqb0tJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lNREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDJZV3hwWkdGMFpWOWxibU52WkdsdVp6MGlkVzV6WVdabFgyUnBjMkZpYkdWa0lpa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU1ETUtJQ0FnSUM4dklHSWdQU0JIYkc5aVlXeFRkR0YwWlNoQ2VYUmxjeXdnYTJWNVBTSjJJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbllpQ2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpBMENpQWdJQ0F2THlCaUxuWmhiSFZsSUQwZ2RtRnNkV1VLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJd05nb2dJQ0FnTHk4Z2JpNTJZV3gxWlM1MllXeHBaR0YwWlNncENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb0tkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUJoY21NMFgzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpBMkNpQWdJQ0F2THlCdUxuWmhiSFZsTG5aaGJHbGtZWFJsS0NrS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURVS0lDQWdJRHdLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSmZZV1owWlhKZlptOXlRRFVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1ptOXlJQ2hzWlc0cktIVnBiblEyTkN4MWFXNTBPQ3dvYkdWdUszVjBaamhiWFNrcFcxMHBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElESWdiMllnS0hWcGJuUTJOQ3gxYVc1ME9Dd29iR1Z1SzNWMFpqaGJYU2twQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXhNd29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOW1iM0pmYUdWaFpHVnlRRElLQ25aaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkpmWVdaMFpYSmZabTl5UURVNkNpQWdJQ0J3YjNCdUlESUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lNRFlLSUNBZ0lDOHZJRzR1ZG1Gc2RXVXVkbUZzYVdSaGRHVW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVPWVhScGRtVkVlVzVoYldsalUzUnlkV04wUGdvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJd01Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhKak5GOTJZV3hwWkdGMGFXOXVMbU52Ym5SeVlXTjBMbFpoYkdsa1lYUnBiMjVEYjI1MGNtRmpkQzUyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkl6T2dvZ0lDQWdMeThnWVhKak5GOTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJd09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0haaGJHbGtZWFJsWDJWdVkyOWthVzVuUFNKMWJuTmhabVZmWkdsellXSnNaV1FpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakl4TUFvZ0lDQWdMeThnWWlBOUlFZHNiMkpoYkZOMFlYUmxLRUo1ZEdWekxDQnJaWGs5SW5ZaUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRpSUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lNVEVLSUNBZ0lDOHZJR0l1ZG1Gc2RXVWdQU0IyWVd4MVpRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRnlZelJmZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJRzR1ZG1Gc2RXVXVkbUZzYVdSaGRHVW9LUW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvS2RtRnNhV1JoZEdWZmJtRjBhWFpsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pOZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdZWEpqTkY5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakl4TXdvZ0lDQWdMeThnYmk1MllXeDFaUzUyWVd4cFpHRjBaU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUEFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWVdaMFpYSmZabTl5UURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoMWFXNTBOalFzZFdsdWREZ3NLR3hsYml0MWRHWTRXMTBwS1ZzelhRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeUlHOW1JQ2gxYVc1ME5qUXNkV2x1ZERnc0tHeGxiaXQxZEdZNFcxMHBLUW9nSUNBZ2MzZGhjQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UTUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlIWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25JelgyWnZjbDlvWldGa1pYSkFNZ29LZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWVdaMFpYSmZabTl5UURVNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUdGeVl6UmZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU1UTUtJQ0FnSUM4dklHNHVkbUZzZFdVdWRtRnNhV1JoZEdVb0tRb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHgwWlhOMFgyTmhjMlZ6TG1GeVl6UmZkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVPWVhScGRtVkVlVzVoYldsalUzUnlkV04wTENBelBnb2dJQ0FnTHk4Z1lYSmpORjkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSXdPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIWmhiR2xrWVhSbFgyVnVZMjlrYVc1blBTSjFibk5oWm1WZlpHbHpZV0pzWldRaUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBQ0NTWUJBWFl4RzBFQTlqRVpGRVF4R0VTQ0lRUlZlNC9mQkdHWHU3RUVwUno1UVFTT3p1a1BCRUxyOXh3RWx2cFFRQVFHQk04YkJBL1JiWmdFRHBmNHRBUS9hTGZSQkJkYnBhNEU3VW03eWdRQzFXcjhCQnhIRGNBRUpJOXBZQVR3REVTYUJOTHVRMUVFWDU0VCtnUTAwTTZ2QklyUDZVMEVBRXlDTlFSQzZueUJCSlY1c2RvRVpuWjVxUVEvMjVSb0JFcVZoZkFFKytXY1p3VENJZHByQkZadGlyVUU2OU5uZUFSMmtQNXJCUGNoNStnRWZKRDI0allhQUk0aEFBa0FGZ0FpQUM4QVBBQk5BRm9BWmdCeUFJTUFsQUNoQUs0QXhRRFJBTjBBL1FFSkFTa0JQQUZKQVo4QjVRSUZBbDhDcVFMQUFzNEMzZ01DQXhrREtnT0VBREVaRkRFWUZCQkROaG9CVndJQUZZRUlFa1FpUXpZYUFWY0NBQlVpRWtRaVF6WWFBVmNDQUJXQlFCSkVJa00yR2dGWEFnQVZnUWdTUkNKRE5ob0JWd0lBU1NOWkpBaE1GUkpFSWtNMkdnRlhBZ0FWZ1FNU1JDSkROaG9CVndJQUZTSVNSQ0pETmhvQlZ3SUFGU0lTUkNKRE5ob0JWd0lBU1NOWkpBaE1GUkpFSWtNMkdnRlhBZ0JKSTFra0NFd1ZFa1FpUXpZYUFWY0NBQldCSUJKRUlrTTJHZ0ZYQWdBVmdTQVNSQ0pETmhvQlZ3SUFTU05aZ1FjSWdRZ0tKQWhNRlJKRUlrTTJHZ0ZYQWdBVkloSkVJa00yR2dGWEFnQVZKUkpFSWtNMkdnRlhBZ0JKRlVzQkpWbEpnUXNTUkU4Q1RFc0NVaU5aZ1EwSUVrUWlRellhQVZjQ0FCVWxFa1FpUXpZYUFWY0NBRWtWU3dFbFdVbUJDeEpFVHdKTVN3SlNJMW1CRFFnU1JDSkROaG9CVndJQVNTTlpKUXNrQ0V3VkVrUWlRellhQVZjQ0FCV0JHeEpFSWtNMkdnRkpWd0lBU1NOWlNVNERKQXRPQWhWT0FsY0VBQ05KU3dVTVFRQXZTU1FMU3dKSlR3SlpTVThGU1U0RUVrUkxBUlZTU1JWTEFTVlpTWUVMRWtSTVVpTlpnUTBJQ0U0Q0lnaEMvOHBHQWlRSUVrUWlRellhQVZjQ0FJRUdUQ05KZ1FNTVFRQXZTU1FMU3dKSlR3SlpTVThGU1U0RUVrUkxBUlZTU1JWTEFTVlpTWUVMRWtSTVVpTlpnUTBJQ0U0Q0lnaEMvOHBJRlJKRUlrTTJHZ0ZYQWdCSkZVc0JJbGxKZ1FRU1JFOENURXNDVWlOWmdRWUlFa1FpUXpZYUFVbFhBZ0FvU3dGblNTTlpTVTRESkF0T0FoVk9BbGNFQUNOSlN3VU1RUUF2U1NRTFN3SkpUd0paU1U4RlNVNEVFa1JMQVJWU1NSVkxBU1ZaU1lFTEVrUk1VaU5aZ1EwSUNFNENJZ2hDLzhwR0FpUUlFa1FpUXpZYUFWY0NBRWtvVEdlQkJrd2pTWUVEREVFQUwwa2tDMHNDU1U4Q1dVbFBCVWxPQkJKRVN3RVZVa2tWU3dFbFdVbUJDeEpFVEZJaldZRU5DQWhPQWlJSVF2L0tTQlVTUkNKRE5ob0JTU05aSkFoTEFSVVNSRmNDQUJXQkNCSkVJa00yR2dGSkkxa2tDRXdWRWtRaVF6WWFBVmNDQUNoTEFXY1ZKUkpFSWtNMkdnRlhBZ0FvU3dGblNSVkxBU1ZaU1lFTEVrUlBBa3hMQWxJaldZRU5DQkpFSWtNMkdnRlhBZ0FvU3dGblNTTlpKUXNrQ0V3VkVrUWlRellhQVZjQ0FDaExBV2NWZ1JzU1JDSkROaG9CU1ZjQ0FDaExBV2RKSTFsSlRnTWtDMDRDRlU0Q1Z3UUFJMGxMQlF4QkFDOUpKQXRMQWtsUEFsbEpUd1ZKVGdRU1JFc0JGVkpKRlVzQkpWbEpnUXNTUkV4U0kxbUJEUWdJVGdJaUNFTC95a1lDSkFnU1JDSkROaG9CVndJQVNTaE1aNEVHVENOSmdRTU1RUUF2U1NRTFN3SkpUd0paU1U4RlNVNEVFa1JMQVJWU1NSVkxBU1ZaU1lFTEVrUk1VaU5aZ1EwSUNFNENJZ2hDLzhwSUZSSkVJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
