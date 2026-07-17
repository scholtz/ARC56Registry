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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestLocalMap_026458f4
{


    public class TestLocalMapProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestLocalMapProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetAndGetUint(string key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 18, 75, 115 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAndGetUint_Transactions(string key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 18, 75, 115 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetAndGetBytes(string key, byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 196, 65, 184 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAndGetBytes_Transactions(string key, byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 196, 65, 184 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetAndGetString(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 210, 3, 146 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAndGetString_Transactions(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 210, 3, 146 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task DeleteValue(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 193, 38, 157 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteValue_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 193, 38, 157 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<bool> HasValue(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 68, 172, 150 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasValue_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 68, 172, 150 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestKeyPrefix(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 100, 177, 237 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestKeyPrefix_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 100, 177, 237 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task TestPrefixedMap(string key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 108, 190, 42 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestPrefixedMap_Transactions(string key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 108, 190, 42 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetAndGetUintViaLocalState(string key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 206, 150, 5 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAndGetUintViaLocalState_Transactions(string key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 206, 150, 5 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdExvY2FsTWFwIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wdEluIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRBbmRHZXRVaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QW5kR2V0Qnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRBbmRHZXRTdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVWYWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzVmFsdWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RLZXlQcmVmaXgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdFByZWZpeGVkTWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QW5kR2V0VWludFZpYUxvY2FsU3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjo4LCJieXRlcyI6OH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU5N10sImVycm9yTWVzc2FnZSI6ImJ5dGVzIHZhbHVlIHNob3VsZCBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MCw1OTMsNjI2LDczOCw3NzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBMb2NhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwNV0sImVycm9yTWVzc2FnZSI6ImRlZmF1bHQga2V5IHByZWZpeCBzaG91bGQgYmUgcHJvcGVydHkgbmFtZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwOV0sImVycm9yTWVzc2FnZSI6ImV4cGxpY2l0IGtleSBwcmVmaXggc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY3LDMwMiwzMjAsMzQ2LDM2NCwzOTAsNDE2LDQ2Nyw1MDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzYsMzExLDMyOSwzNTUsMzczLDM5OSw0MjUsNDc2LDUxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODcsNDg3LDUyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0Ml0sImVycm9yTWVzc2FnZSI6InByZWZpeGVkIG1hcCB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTldLCJlcnJvck1lc3NhZ2UiOiJzaG91bGQgaGF2ZSB2YWx1ZSBiZWZvcmUgZGVsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc4XSwiZXJyb3JNZXNzYWdlIjoic2hvdWxkIG5vdCBoYXZlIHZhbHVlIGFmdGVyIGRlbGV0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzMF0sImVycm9yTWVzc2FnZSI6InN0cmluZyB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjRdLCJlcnJvck1lc3NhZ2UiOiJ1aW50IHZhbHVlIHNob3VsZCBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3NV0sImVycm9yTWVzc2FnZSI6InVpbnQgdmFsdWUgdmlhIExvY2FsU3RhdGUgc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRXbHVkRTFoY0NJZ0luQXZJaUFpWW5sMFpYTk5ZWEFpSUNKemRISnBibWROWVhBaUNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzBMVFVLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUhOMFlYUmxWRzkwWVd4ek9pQjdJR3h2WTJGc1ZXbHVkSE02SURnc0lHeHZZMkZzUW5sMFpYTTZJRGdnZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSTWIyTmhiRTFoY0NCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFM0NpQWdJQ0JpSUcxaGFXNWZZV0pwWDNKdmRYUnBibWRBTWdvS2JXRnBibDloWW1sZmNtOTFkR2x1WjBBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pRdE5Rb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUhzZ2JHOWpZV3hWYVc1MGN6b2dPQ3dnYkc5allXeENlWFJsY3pvZ09DQjlJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZHVnpkRXh2WTJGc1RXRndJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamt6TVRSa09UVWdMeThnYldWMGFHOWtJQ0p2Y0hSSmJpZ3BkbTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2JXRjBZMmdnYldGcGJsOXZjSFJKYmw5eWIzVjBaVUF6Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMENncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8wTFRVS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3SUd4dlkyRnNWV2x1ZEhNNklEZ3NJR3h2WTJGc1FubDBaWE02SURnZ2ZTQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSbGMzUk1iMk5oYkUxaGNDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUxQ2lBZ0lDQmlJRzFoYVc1ZlkyRnNiRjlPYjA5d1FEVUtDbTFoYVc1ZlkyRnNiRjlPYjA5d1FEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5DMDFDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6ZEdGMFpWUnZkR0ZzY3pvZ2V5QnNiMk5oYkZWcGJuUnpPaUE0TENCc2IyTmhiRUo1ZEdWek9pQTRJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVaWE4wVEc5allXeE5ZWEFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVRFeU5HSTNNeUF2THlCdFpYUm9iMlFnSW5ObGRFRnVaRWRsZEZWcGJuUW9jM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZV1ZqTkRReFlqZ2dMeThnYldWMGFHOWtJQ0p6WlhSQmJtUkhaWFJDZVhSbGN5aHpkSEpwYm1jc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhNbVF5TURNNU1pQXZMeUJ0WlhSb2IyUWdJbk5sZEVGdVpFZGxkRk4wY21sdVp5aHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNZbU14TWpZNVpDQXZMeUJ0WlhSb2IyUWdJbVJsYkdWMFpWWmhiSFZsS0hOMGNtbHVaeWwyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE4yUTBOR0ZqT1RZZ0x5OGdiV1YwYUc5a0lDSm9ZWE5XWVd4MVpTaHpkSEpwYm1jcFltOXZiQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE0zTmpSaU1XVmtJQzh2SUcxbGRHaHZaQ0FpZEdWemRFdGxlVkJ5WldacGVDZ3BkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdJek5tTmlaVEpoSUM4dklHMWxkR2h2WkNBaWRHVnpkRkJ5WldacGVHVmtUV0Z3S0hOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdSbFkyVTVOakExSUM4dklHMWxkR2h2WkNBaWMyVjBRVzVrUjJWMFZXbHVkRlpwWVV4dlkyRnNVM1JoZEdVb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM05sZEVGdVpFZGxkRlZwYm5SZmNtOTFkR1ZBTmlCdFlXbHVYM05sZEVGdVpFZGxkRUo1ZEdWelgzSnZkWFJsUURjZ2JXRnBibDl6WlhSQmJtUkhaWFJUZEhKcGJtZGZjbTkxZEdWQU9DQnRZV2x1WDJSbGJHVjBaVlpoYkhWbFgzSnZkWFJsUURrZ2JXRnBibDlvWVhOV1lXeDFaVjl5YjNWMFpVQXhNQ0J0WVdsdVgzUmxjM1JMWlhsUWNtVm1hWGhmY205MWRHVkFNVEVnYldGcGJsOTBaWE4wVUhKbFptbDRaV1JOWVhCZmNtOTFkR1ZBTVRJZ2JXRnBibDl6WlhSQmJtUkhaWFJWYVc1MFZtbGhURzlqWVd4VGRHRjBaVjl5YjNWMFpVQXhNd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkRvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMkNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFk2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4T0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTRPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qUXROUW9nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2diRzlqWVd4VmFXNTBjem9nT0N3Z2JHOWpZV3hDZVhSbGN6b2dPQ0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEV4dlkyRnNUV0Z3SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM05sZEVGdVpFZGxkRlZwYm5SV2FXRk1iMk5oYkZOMFlYUmxYM0p2ZFhSbFFERXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QnpaWFJCYm1SSFpYUlZhVzUwVm1saFRHOWpZV3hUZEdGMFpTaHJaWGs2SUhOMGNtbHVaeXdnZG1Gc2RXVTZJSFZwYm5RMk5Da2dld29nSUNBZ1kyRnNiSE4xWWlCelpYUkJibVJIWlhSVmFXNTBWbWxoVEc5allXeFRkR0YwWlFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UUUtDbTFoYVc1ZmRHVnpkRkJ5WldacGVHVmtUV0Z3WDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUIwWlhOMFVISmxabWw0WldSTllYQW9hMlY1T2lCemRISnBibWNzSUhaaGJIVmxPaUIxYVc1ME5qUXBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRkJ5WldacGVHVmtUV0Z3Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE5Bb0tiV0ZwYmw5MFpYTjBTMlY1VUhKbFptbDRYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QjBaWE4wUzJWNVVISmxabWw0S0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMFMyVjVVSEpsWm1sNENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOQW9LYldGcGJsOW9ZWE5XWVd4MVpWOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2FHRnpWbUZzZFdVb2EyVjVPaUJ6ZEhKcGJtY3BPaUJpYjI5c1pXRnVJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2FHRnpWbUZzZFdVS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgyUmxiR1YwWlZaaGJIVmxYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHUmxiR1YwWlZaaGJIVmxLR3RsZVRvZ2MzUnlhVzVuS1NCN0NpQWdJQ0JqWVd4c2MzVmlJR1JsYkdWMFpWWmhiSFZsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE5Bb0tiV0ZwYmw5elpYUkJibVJIWlhSVGRISnBibWRmY205MWRHVkFPRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdjMlYwUVc1a1IyVjBVM1J5YVc1bktHdGxlVG9nYzNSeWFXNW5MQ0IyWVd4MVpUb2djM1J5YVc1bktTQjdDaUFnSUNCallXeHNjM1ZpSUhObGRFRnVaRWRsZEZOMGNtbHVad29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmYzJWMFFXNWtSMlYwUW5sMFpYTmZjbTkxZEdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2MyVjBRVzVrUjJWMFFubDBaWE1vYTJWNU9pQnpkSEpwYm1jc0lIWmhiSFZsT2lCaWVYUmxjeWtnZXdvZ0lDQWdZMkZzYkhOMVlpQnpaWFJCYm1SSFpYUkNlWFJsY3dvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UUUtDbTFoYVc1ZmMyVjBRVzVrUjJWMFZXbHVkRjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QnpaWFJCYm1SSFpYUlZhVzUwS0d0bGVUb2djM1J5YVc1bkxDQjJZV3gxWlRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSE5sZEVGdVpFZGxkRlZwYm5RS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUxT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZS0NtMWhhVzVmYjNCMFNXNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owOXdkRWx1SnlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklFOXdkRWx1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1kyRnNiSE4xWWlCdmNIUkpiZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkFvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOQzAxQ2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCemRHRjBaVlJ2ZEdGc2N6b2dleUJzYjJOaGJGVnBiblJ6T2lBNExDQnNiMk5oYkVKNWRHVnpPaUE0SUgwZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVWlhOMFRHOWpZV3hOWVhBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXViM0IwU1c1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZjSFJKYmpvS0lDQWdJR0lnYjNCMFNXNWZZbXh2WTJ0QU1Bb0tiM0IwU1c1ZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA5d2RFbHVKeUI5S1FvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjQzV2Y0hSSmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xuTmxkRUZ1WkVkbGRGVnBiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkJibVJIWlhSVmFXNTBPZ29nSUNBZ1lpQnpaWFJCYm1SSFpYUlZhVzUwWDJKc2IyTnJRREFLQ25ObGRFRnVaRWRsZEZWcGJuUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z2MyVjBRVzVrUjJWMFZXbHVkQ2hyWlhrNklITjBjbWx1Wnl3Z2RtRnNkV1U2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3TG5ObGRFRnVaRWRsZEZWcGJuUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNDNXpaWFJCYm1SSFpYUkNlWFJsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRUZ1WkVkbGRFSjVkR1Z6T2dvZ0lDQWdZaUJ6WlhSQmJtUkhaWFJDZVhSbGMxOWliRzlqYTBBd0NncHpaWFJCYm1SSFpYUkNlWFJsYzE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ6WlhSQmJtUkhaWFJDZVhSbGN5aHJaWGs2SUhOMGNtbHVaeXdnZG1Gc2RXVTZJR0o1ZEdWektTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0M1elpYUkJibVJIWlhSQ2VYUmxjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndMbk5sZEVGdVpFZGxkRk4wY21sdVoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEVGdVpFZGxkRk4wY21sdVp6b0tJQ0FnSUdJZ2MyVjBRVzVrUjJWMFUzUnlhVzVuWDJKc2IyTnJRREFLQ25ObGRFRnVaRWRsZEZOMGNtbHVaMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnpaWFJCYm1SSFpYUlRkSEpwYm1jb2EyVjVPaUJ6ZEhKcGJtY3NJSFpoYkhWbE9pQnpkSEpwYm1jcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3TG5ObGRFRnVaRWRsZEZOMGNtbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndMbVJsYkdWMFpWWmhiSFZsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsVm1Gc2RXVTZDaUFnSUNCaUlHUmxiR1YwWlZaaGJIVmxYMkpzYjJOclFEQUtDbVJsYkdWMFpWWmhiSFZsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR1JsYkdWMFpWWmhiSFZsS0d0bGVUb2djM1J5YVc1bktTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhBdVpHVnNaWFJsVm1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNDNW9ZWE5XWVd4MVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWhoYzFaaGJIVmxPZ29nSUNBZ1lpQm9ZWE5XWVd4MVpWOWliRzlqYTBBd0NncG9ZWE5XWVd4MVpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCb1lYTldZV3gxWlNoclpYazZJSE4wY21sdVp5azZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xtaGhjMVpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xuUmxjM1JMWlhsUWNtVm1hWGhiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBTMlY1VUhKbFptbDRPZ29nSUNBZ1lpQjBaWE4wUzJWNVVISmxabWw0WDJKc2IyTnJRREFLQ25SbGMzUkxaWGxRY21WbWFYaGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2RHVnpkRXRsZVZCeVpXWnBlQ2dwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEF1ZEdWemRFdGxlVkJ5WldacGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xuUmxjM1JRY21WbWFYaGxaRTFoY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JRY21WbWFYaGxaRTFoY0RvS0lDQWdJR0lnZEdWemRGQnlaV1pwZUdWa1RXRndYMkpzYjJOclFEQUtDblJsYzNSUWNtVm1hWGhsWkUxaGNGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCMFpYTjBVSEpsWm1sNFpXUk5ZWEFvYTJWNU9pQnpkSEpwYm1jc0lIWmhiSFZsT2lCMWFXNTBOalFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0M1MFpYTjBVSEpsWm1sNFpXUk5ZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjQzV6WlhSQmJtUkhaWFJWYVc1MFZtbGhURzlqWVd4VGRHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRFRnVaRWRsZEZWcGJuUldhV0ZNYjJOaGJGTjBZWFJsT2dvZ0lDQWdZaUJ6WlhSQmJtUkhaWFJWYVc1MFZtbGhURzlqWVd4VGRHRjBaVjlpYkc5amEwQXdDZ3B6WlhSQmJtUkhaWFJWYVc1MFZtbGhURzlqWVd4VGRHRjBaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QnpaWFJCYm1SSFpYUlZhVzUwVm1saFRHOWpZV3hUZEdGMFpTaHJaWGs2SUhOMGNtbHVaeXdnZG1Gc2RXVTZJSFZwYm5RMk5Da2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndMbk5sZEVGdVpFZGxkRlZwYm5SV2FXRk1iMk5oYkZOMFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXViM0IwU1c0b0tTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjQzV2Y0hSSmJqb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXViM0IwU1c1ZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXViM0IwU1c1ZllteHZZMnRBTURvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xuTmxkRUZ1WkVkbGRGVnBiblFvYTJWNU9pQmllWFJsY3l3Z2RtRnNkV1U2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhBdWMyVjBRVzVrUjJWMFZXbHVkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdjMlYwUVc1a1IyVjBWV2x1ZENoclpYazZJSE4wY21sdVp5d2dkbUZzZFdVNklIVnBiblEyTkNrZ2V3b2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3TG5ObGRFRnVaRWRsZEZWcGJuUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEF1YzJWMFFXNWtSMlYwVldsdWRGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhWcGJuUk5ZWEFnUFNCTWIyTmhiRTFoY0R4emRISnBibWNzSUhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFdsdWRFMWhjQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJSFJvYVhNdWRXbHVkRTFoY0NoclpYa3NJRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnZG1Gc2RXVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2RXbHVkRTFoY0NBOUlFeHZZMkZzVFdGd1BITjBjbWx1Wnl3Z2RXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMWFXNTBUV0Z3SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRXbHVkRTFoY0NoclpYa3NJRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDA5UFNCMllXeDFaU3dnSjNWcGJuUWdkbUZzZFdVZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFZwYm5RZ2RtRnNkV1VnYzJodmRXeGtJRzFoZEdOb0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNDNXpaWFJCYm1SSFpYUkNlWFJsY3loclpYazZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xuTmxkRUZ1WkVkbGRFSjVkR1Z6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ6WlhSQmJtUkhaWFJDZVhSbGN5aHJaWGs2SUhOMGNtbHVaeXdnZG1Gc2RXVTZJR0o1ZEdWektTQjdDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhBdWMyVjBRVzVrUjJWMFFubDBaWE5mWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhBdWMyVjBRVzVrUjJWMFFubDBaWE5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmllWFJsYzAxaGNDQTlJRXh2WTJGc1RXRndQSE4wY21sdVp5d2dZbmwwWlhNK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSjVkR1Z6VFdGd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z2RHaHBjeTVpZVhSbGMwMWhjQ2hyWlhrc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdkbUZzZFdVS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWW5sMFpYTk5ZWEFnUFNCTWIyTmhiRTFoY0R4emRISnBibWNzSUdKNWRHVnpQaWdwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppZVhSbGMwMWhjQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KNWRHVnpUV0Z3S0d0bGVTd2dWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQVDA5SUhaaGJIVmxMQ0FuWW5sMFpYTWdkbUZzZFdVZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0o1ZEdWeklIWmhiSFZsSUhOb2IzVnNaQ0J0WVhSamFBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXVjMlYwUVc1a1IyVjBVM1J5YVc1bktHdGxlVG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXVjMlYwUVc1a1IyVjBVM1J5YVc1bk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCelpYUkJibVJIWlhSVGRISnBibWNvYTJWNU9pQnpkSEpwYm1jc0lIWmhiSFZsT2lCemRISnBibWNwSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjQzV6WlhSQmJtUkhaWFJUZEhKcGJtZGZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEF1YzJWMFFXNWtSMlYwVTNSeWFXNW5YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z2MzUnlhVzVuVFdGd0lEMGdURzlqWVd4TllYQThjM1J5YVc1bkxDQnpkSEpwYm1jK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luTjBjbWx1WjAxaGNDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklIUm9hWE11YzNSeWFXNW5UV0Z3S0d0bGVTd2dWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0IyWVd4MVpRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCemRISnBibWROWVhBZ1BTQk1iMk5oYkUxaGNEeHpkSEpwYm1jc0lITjBjbWx1Wno0b0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWMzUnlhVzVuVFdGd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjM1J5YVc1blRXRndLR3RsZVN3Z1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BUMDlJSFpoYkhWbExDQW5jM1J5YVc1bklIWmhiSFZsSUhOb2IzVnNaQ0J0WVhSamFDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnpkSEpwYm1jZ2RtRnNkV1VnYzJodmRXeGtJRzFoZEdOb0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNDNWtaV3hsZEdWV1lXeDFaU2hyWlhrNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNDNWtaV3hsZEdWV1lXeDFaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdaR1ZzWlhSbFZtRnNkV1VvYTJWNU9pQnpkSEpwYm1jcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0M1a1pXeGxkR1ZXWVd4MVpWOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjQzVrWld4bGRHVldZV3gxWlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFZwYm5STllYQWdQU0JNYjJOaGJFMWhjRHh6ZEhKcGJtY3NJSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkV2x1ZEUxaGNDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUm9hWE11ZFdsdWRFMWhjQ2hyWlhrc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdNVEl6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJSEIxYzJocGJuUWdNVEl6Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdkV2x1ZEUxaGNDQTlJRXh2WTJGc1RXRndQSE4wY21sdVp5d2dkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjFhVzUwVFdGd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVkV2x1ZEUxaGNDaHJaWGtzSUZSNGJpNXpaVzVrWlhJcExtaGhjMVpoYkhWbExDQW5jMmh2ZFd4a0lHaGhkbVVnZG1Gc2RXVWdZbVZtYjNKbElHUmxiR1YwWlNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z2MyaHZkV3hrSUdoaGRtVWdkbUZzZFdVZ1ltVm1iM0psSUdSbGJHVjBaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjBhR2x6TG5WcGJuUk5ZWEFvYTJWNUxDQlVlRzR1YzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhWcGJuUk5ZWEFnUFNCTWIyTmhiRTFoY0R4emRISnBibWNzSUhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFdsdWRFMWhjQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSFJvYVhNdWRXbHVkRTFoY0NoclpYa3NJRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmhjSEJmYkc5allXeGZaR1ZzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdkV2x1ZEUxaGNDQTlJRXh2WTJGc1RXRndQSE4wY21sdVp5d2dkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjFhVzUwVFdGd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMblZwYm5STllYQW9hMlY1TENCVWVHNHVjMlZ1WkdWeUtTNW9ZWE5XWVd4MVpTd2dKM05vYjNWc1pDQnViM1FnYUdGMlpTQjJZV3gxWlNCaFpuUmxjaUJrWld4bGRHVW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklITm9iM1ZzWkNCdWIzUWdhR0YyWlNCMllXeDFaU0JoWm5SbGNpQmtaV3hsZEdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xtaGhjMVpoYkhWbEtHdGxlVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhBdWFHRnpWbUZzZFdVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUdoaGMxWmhiSFZsS0d0bGVUb2djM1J5YVc1bktUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhBdWFHRnpWbUZzZFdWZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXVhR0Z6Vm1Gc2RXVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCMWFXNTBUV0Z3SUQwZ1RHOWpZV3hOWVhBOGMzUnlhVzVuTENCMWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5WcGJuUk5ZWEFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1MWFXNTBUV0Z3S0d0bGVTd2dWSGh1TG5ObGJtUmxjaWt1YUdGelZtRnNkV1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEF1ZEdWemRFdGxlVkJ5WldacGVDZ3BJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3TG5SbGMzUkxaWGxRY21WbWFYZzZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndMblJsYzNSTFpYbFFjbVZtYVhoZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXVkR1Z6ZEV0bGVWQnlaV1pwZUY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1MWFXNTBUV0Z3TG10bGVWQnlaV1pwZUNBOVBUMGdRbmwwWlhNb0ozVnBiblJOWVhBbktTd2dKMlJsWm1GMWJIUWdhMlY1SUhCeVpXWnBlQ0J6YUc5MWJHUWdZbVVnY0hKdmNHVnlkSGtnYm1GdFpTY3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjFhVzUwVFdGd0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRXbHVkRTFoY0NJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaR1ZtWVhWc2RDQnJaWGtnY0hKbFptbDRJSE5vYjNWc1pDQmlaU0J3Y205d1pYSjBlU0J1WVcxbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuQnlaV1pwZUdWa1RXRndMbXRsZVZCeVpXWnBlQ0E5UFQwZ1FubDBaWE1vSjNBdkp5a3NJQ2RsZUhCc2FXTnBkQ0JyWlhrZ2NISmxabWw0SUhOb2IzVnNaQ0J0WVhSamFDY3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndMeUlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkF2SWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJzYVdOcGRDQnJaWGtnY0hKbFptbDRJSE5vYjNWc1pDQnRZWFJqYUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhBdWRHVnpkRkJ5WldacGVHVmtUV0Z3S0d0bGVUb2dZbmwwWlhNc0lIWmhiSFZsT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd0xuUmxjM1JRY21WbWFYaGxaRTFoY0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnZEdWemRGQnlaV1pwZUdWa1RXRndLR3RsZVRvZ2MzUnlhVzVuTENCMllXeDFaVG9nZFdsdWREWTBLU0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQXVkR1Z6ZEZCeVpXWnBlR1ZrVFdGd1gySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndMblJsYzNSUWNtVm1hWGhsWkUxaGNGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUhCeVpXWnBlR1ZrVFdGd0lEMGdURzlqWVd4TllYQThjM1J5YVc1bkxDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuY0M4bklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndMeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSFJvYVhNdWNISmxabWw0WldSTllYQW9hMlY1TENCVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIWmhiSFZsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSEJ5WldacGVHVmtUV0Z3SUQwZ1RHOWpZV3hOWVhBOGMzUnlhVzVuTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQW5jQzhuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0x5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbkJ5WldacGVHVmtUV0Z3S0d0bGVTd2dWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQVDA5SUhaaGJIVmxMQ0FuY0hKbFptbDRaV1FnYldGd0lIWmhiSFZsSUhOb2IzVnNaQ0J0WVhSamFDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QndjbVZtYVhobFpDQnRZWEFnZG1Gc2RXVWdjMmh2ZFd4a0lHMWhkR05vQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0M1elpYUkJibVJIWlhSVmFXNTBWbWxoVEc5allXeFRkR0YwWlNoclpYazZJR0o1ZEdWekxDQjJZV3gxWlRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNDNXpaWFJCYm1SSFpYUlZhVzUwVm1saFRHOWpZV3hUZEdGMFpUb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2MyVjBRVzVrUjJWMFZXbHVkRlpwWVV4dlkyRnNVM1JoZEdVb2EyVjVPaUJ6ZEhKcGJtY3NJSFpoYkhWbE9pQjFhVzUwTmpRcElIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0M1elpYUkJibVJIWlhSVmFXNTBWbWxoVEc5allXeFRkR0YwWlY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNDNXpaWFJCYm1SSFpYUlZhVzUwVm1saFRHOWpZV3hUZEdGMFpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhWcGJuUk5ZWEFnUFNCTWIyTmhiRTFoY0R4emRISnBibWNzSUhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFdsdWRFMWhjQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSFJvYVhNdWRXbHVkRTFoY0NoclpYa3BLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnZG1Gc2RXVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2RXbHVkRTFoY0NBOUlFeHZZMkZzVFdGd1BITjBjbWx1Wnl3Z2RXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMWFXNTBUV0Z3SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWRXbHVkRTFoY0NoclpYa3BLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDA5UFNCMllXeDFaU3dnSjNWcGJuUWdkbUZzZFdVZ2RtbGhJRXh2WTJGc1UzUmhkR1VnYzJodmRXeGtJRzFoZEdOb0p5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIVnBiblFnZG1Gc2RXVWdkbWxoSUV4dlkyRnNVM1JoZEdVZ2MyaHZkV3hrSUcxaGRHTm9DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjQzVmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVW9LU0F0UGlCMmIybGtPZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVTZDaUFnSUNCaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3Q2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lFQjNWcGJuUk5ZWEFDY0M4SVlubDBaWE5OWVhBSmMzUnlhVzVuVFdGd1FnQUFRZ0FBTVJzaUUwRUF1RUlBQURZYUFJQUVLVEZObFU4QmpnRUFsa0lBQURFWkloSkVNUmdpRTBFQWhFSUFBRFlhQUlBRUFSSkxjNEFFcnNSQnVJQUVvdElEa29BRWU4RW1uWUFFZlVTc2xvQUVOMlN4N1lBRXMyeStLb0FFM3M2V0JVOElqZ2dBTkFBdUFDZ0FJZ0FjQUJZQUVBQUtRZ0FBUWdBQVFnQUFBSWdCUWtMLzg0Z0JHVUwvN1lnQkMwTC81NGdBMmtMLzRZZ0F1a0wvMjRnQWlFTC8xWWdBVmtML3o0Z0FMVUwveVVML3lURVpJeEl4R0NJVEVFU0lBQkpDLzEweEdTSVNNUmdpRWhCRWlBSVFJME5DQUFDSUFSQWpRMElBQURZYUFVa2lXU01MSkFoTEFSVVNSRmNDQURZYUFra1ZKUkpFRjRnQThTTkRRZ0FBTmhvQlNTSlpJd3NrQ0VzQkZSSkVWd0lBTmhvQ1NTSlpJd3NrQ0VzQkZSSkVWd0lBaUFEbUkwTkNBQUEyR2dGSklsa2pDeVFJU3dFVkVrUlhBZ0EyR2dKSklsa2pDeVFJU3dFVkVrUlhBZ0NJQU5zalEwSUFBRFlhQVVraVdTTUxKQWhMQVJVU1JGY0NBSWdBNGlORFFnQUFOaG9CU1NKWkl3c2tDRXNCRlJKRVZ3SUFpQUQ0Z0FFQUlrOENWSUFFRlI5OGRVOEJVTEFqUTBJQUFJZ0E4aU5EUWdBQU5ob0JTU0paSXdza0NFc0JGUkpFVndJQU5ob0NTUlVsRWtRWGlBRGJJME5DQUFBMkdnRkpJbGtqQ3lRSVN3RVZFa1JYQWdBMkdnSkpGU1VTUkJlSUFOa2pRMElBQUltS0FnQkNBQUFvaS81UU1RQlBBWXYvWmlpTC9sQXhBQ0pQQW1ORWkvOFNSSW1LQWdCQ0FBQXFpLzVRTVFCUEFZdi9aaXFML2xBeEFDSlBBbU5FaS84U1JJbUtBZ0JDQUFBcmkvNVFNUUJQQVl2L1ppdUwvbEF4QUNKUEFtTkVpLzhTUkltS0FRQkNBQUFvaS85UU1RQlBBWUY3WmlpTC8xQXhBQ0pQQW1ORU1RQW9pLzlRYUNpTC8xQXhBQ0pQQW1NVVJJbUtBUUZDQUFBb2kvOVFNUUFpVHdKalR3R0pRZ0FBS0NnU1JDa3BFa1NKaWdJQVFnQUFLWXYrVURFQVR3R0wvMllwaS81UU1RQWlUd0pqUkl2L0VrU0ppZ0lBUWdBQUtJditVREVBVHdHTC8yWW9pLzVRTVFBaVR3SmpSSXYvRWtTSlFnQUFpUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
