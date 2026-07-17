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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestGlobalMap_d9ace1d6
{


    public class TestGlobalMapProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestGlobalMapProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdEdsb2JhbE1hcCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRBbmRHZXRVaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QW5kR2V0Qnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRBbmRHZXRTdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVWYWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzVmFsdWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RLZXlQcmVmaXgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdFByZWZpeGVkTWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEwLCJieXRlcyI6MTB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ5MF0sImVycm9yTWVzc2FnZSI6ImJ5dGVzIHZhbHVlIHNob3VsZCBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1OSw0ODYsNTEzLDYwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4MF0sImVycm9yTWVzc2FnZSI6ImRlZmF1bHQga2V5IHByZWZpeCBzaG91bGQgYmUgcHJvcGVydHkgbmFtZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NF0sImVycm9yTWVzc2FnZSI6ImV4cGxpY2l0IGtleSBwcmVmaXggc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExLDI0NiwyNjQsMjkwLDMwOCwzMzQsMzYwLDQxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMCwyNTUsMjczLDI5OSwzMTcsMzQzLDM2OSw0MjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxLDQzMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxMV0sImVycm9yTWVzc2FnZSI6InByZWZpeGVkIG1hcCB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDBdLCJlcnJvck1lc3NhZ2UiOiJzaG91bGQgaGF2ZSB2YWx1ZSBiZWZvcmUgZGVsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU1XSwiZXJyb3JNZXNzYWdlIjoic2hvdWxkIG5vdCBoYXZlIHZhbHVlIGFmdGVyIGRlbGV0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxN10sImVycm9yTWVzc2FnZSI6InN0cmluZyB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjNdLCJlcnJvck1lc3NhZ2UiOiJ1aW50IHZhbHVlIHNob3VsZCBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWlkV2x1ZEUxaGNDSWdJbkF2SWlBaVlubDBaWE5OWVhBaUlDSnpkSEpwYm1kTllYQWlDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TkMwMUNpQWdJQ0F2THlCQVkyOXVkSEpoWTNRb2V5QnpkR0YwWlZSdmRHRnNjem9nZXlCbmJHOWlZV3hWYVc1MGN6b2dNVEFzSUdkc2IySmhiRUo1ZEdWek9pQXhNQ0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEVkc2IySmhiRTFoY0NCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFMENpQWdJQ0JpSUcxaGFXNWZZV0pwWDNKdmRYUnBibWRBTWdvS2JXRnBibDloWW1sZmNtOTFkR2x1WjBBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMExUVUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE4wWVhSbFZHOTBZV3h6T2lCN0lHZHNiMkpoYkZWcGJuUnpPaUF4TUN3Z1oyeHZZbUZzUW5sMFpYTTZJREV3SUgwZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVWlhOMFIyeHZZbUZzVFdGd0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVElLSUNBZ0lHSWdiV0ZwYmw5allXeHNYMDV2VDNCQU13b0tiV0ZwYmw5allXeHNYMDV2VDNCQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk5DMDFDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6ZEdGMFpWUnZkR0ZzY3pvZ2V5Qm5iRzlpWVd4VmFXNTBjem9nTVRBc0lHZHNiMkpoYkVKNWRHVnpPaUF4TUNCOUlIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdWemRFZHNiMkpoYkUxaGNDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhNVEkwWWpjeklDOHZJRzFsZEdodlpDQWljMlYwUVc1a1IyVjBWV2x1ZENoemRISnBibWNzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaFpXTTBOREZpT0NBdkx5QnRaWFJvYjJRZ0luTmxkRUZ1WkVkbGRFSjVkR1Z6S0hOMGNtbHVaeXhpZVhSbFcxMHBkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFeVpESXdNemt5SUM4dklHMWxkR2h2WkNBaWMyVjBRVzVrUjJWMFUzUnlhVzVuS0hOMGNtbHVaeXh6ZEhKcGJtY3BkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURkaVl6RXlOamxrSUM4dklHMWxkR2h2WkNBaVpHVnNaWFJsVm1Gc2RXVW9jM1J5YVc1bktYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczWkRRMFlXTTVOaUF2THlCdFpYUm9iMlFnSW1oaGMxWmhiSFZsS0hOMGNtbHVaeWxpYjI5c0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE16YzJOR0l4WldRZ0x5OGdiV1YwYUc5a0lDSjBaWE4wUzJWNVVISmxabWw0S0NsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZak0yWTJKbE1tRWdMeThnYldWMGFHOWtJQ0owWlhOMFVISmxabWw0WldSTllYQW9jM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNObGRFRnVaRWRsZEZWcGJuUmZjbTkxZEdWQU5DQnRZV2x1WDNObGRFRnVaRWRsZEVKNWRHVnpYM0p2ZFhSbFFEVWdiV0ZwYmw5elpYUkJibVJIWlhSVGRISnBibWRmY205MWRHVkFOaUJ0WVdsdVgyUmxiR1YwWlZaaGJIVmxYM0p2ZFhSbFFEY2diV0ZwYmw5b1lYTldZV3gxWlY5eWIzVjBaVUE0SUcxaGFXNWZkR1Z6ZEV0bGVWQnlaV1pwZUY5eWIzVjBaVUE1SUcxaGFXNWZkR1Z6ZEZCeVpXWnBlR1ZrVFdGd1gzSnZkWFJsUURFd0NpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNUW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXhPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE16b0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pRdE5Rb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUhzZ1oyeHZZbUZzVldsdWRITTZJREV3TENCbmJHOWlZV3hDZVhSbGN6b2dNVEFnZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSSGJHOWlZV3hOWVhBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRGQnlaV1pwZUdWa1RXRndYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdkR1Z6ZEZCeVpXWnBlR1ZrVFdGd0tHdGxlVG9nYzNSeWFXNW5MQ0IyWVd4MVpUb2dkV2x1ZERZMEtTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUlFjbVZtYVhobFpFMWhjQW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRFS0NtMWhhVzVmZEdWemRFdGxlVkJ5WldacGVGOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z2RHVnpkRXRsZVZCeVpXWnBlQ2dwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEV0bGVWQnlaV1pwZUFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1URUtDbTFoYVc1ZmFHRnpWbUZzZFdWZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdoaGMxWmhiSFZsS0d0bGVUb2djM1J5YVc1bktUb2dZbTl2YkdWaGJpQjdDaUFnSUNCallXeHNjM1ZpSUdoaGMxWmhiSFZsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Rb0tiV0ZwYmw5a1pXeGxkR1ZXWVd4MVpWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1pHVnNaWFJsVm1Gc2RXVW9hMlY1T2lCemRISnBibWNwSUhzS0lDQWdJR05oYkd4emRXSWdaR1ZzWlhSbFZtRnNkV1VLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFeENncHRZV2x1WDNObGRFRnVaRWRsZEZOMGNtbHVaMTl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdjMlYwUVc1a1IyVjBVM1J5YVc1bktHdGxlVG9nYzNSeWFXNW5MQ0IyWVd4MVpUb2djM1J5YVc1bktTQjdDaUFnSUNCallXeHNjM1ZpSUhObGRFRnVaRWRsZEZOMGNtbHVad29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRFS0NtMWhhVzVmYzJWMFFXNWtSMlYwUW5sMFpYTmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklITmxkRUZ1WkVkbGRFSjVkR1Z6S0d0bGVUb2djM1J5YVc1bkxDQjJZV3gxWlRvZ1lubDBaWE1wSUhzS0lDQWdJR05oYkd4emRXSWdjMlYwUVc1a1IyVjBRbmwwWlhNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXhDZ3B0WVdsdVgzTmxkRUZ1WkVkbGRGVnBiblJmY205MWRHVkFORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJSE5sZEVGdVpFZGxkRlZwYm5Rb2EyVjVPaUJ6ZEhKcGJtY3NJSFpoYkhWbE9pQjFhVzUwTmpRcElIc0tJQ0FnSUdOaGJHeHpkV0lnYzJWMFFXNWtSMlYwVldsdWRBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVEVLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRJNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE13b0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pRdE5Rb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUhzZ1oyeHZZbUZzVldsdWRITTZJREV3TENCbmJHOWlZV3hDZVhSbGN6b2dNVEFnZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSSGJHOWlZV3hOWVhBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjQzV6WlhSQmJtUkhaWFJWYVc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwUVc1a1IyVjBWV2x1ZERvS0lDQWdJR0lnYzJWMFFXNWtSMlYwVldsdWRGOWliRzlqYTBBd0NncHpaWFJCYm1SSFpYUlZhVzUwWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJ6WlhSQmJtUkhaWFJWYVc1MEtHdGxlVG9nYzNSeWFXNW5MQ0IyWVd4MVpUb2dkV2x1ZERZMEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjQzV6WlhSQmJtUkhaWFJWYVc1MENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNDNXpaWFJCYm1SSFpYUkNlWFJsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRUZ1WkVkbGRFSjVkR1Z6T2dvZ0lDQWdZaUJ6WlhSQmJtUkhaWFJDZVhSbGMxOWliRzlqYTBBd0NncHpaWFJCYm1SSFpYUkNlWFJsYzE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnYzJWMFFXNWtSMlYwUW5sMFpYTW9hMlY1T2lCemRISnBibWNzSUhaaGJIVmxPaUJpZVhSbGN5a2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNDNXpaWFJCYm1SSFpYUkNlWFJsY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSSGJHOWlZV3hOWVhBdWMyVjBRVzVrUjJWMFUzUnlhVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBRVzVrUjJWMFUzUnlhVzVuT2dvZ0lDQWdZaUJ6WlhSQmJtUkhaWFJUZEhKcGJtZGZZbXh2WTJ0QU1Bb0tjMlYwUVc1a1IyVjBVM1J5YVc1blgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCelpYUkJibVJIWlhSVGRISnBibWNvYTJWNU9pQnpkSEpwYm1jc0lIWmhiSFZsT2lCemRISnBibWNwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JIYkc5aVlXeE5ZWEF1YzJWMFFXNWtSMlYwVTNSeWFXNW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjQzVrWld4bGRHVldZV3gxWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlZaaGJIVmxPZ29nSUNBZ1lpQmtaV3hsZEdWV1lXeDFaVjlpYkc5amEwQXdDZ3BrWld4bGRHVldZV3gxWlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWkdWc1pYUmxWbUZzZFdVb2EyVjVPaUJ6ZEhKcGJtY3BJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBSMnh2WW1Gc1RXRndMbVJsYkdWMFpWWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0M1b1lYTldZV3gxWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtaGhjMVpoYkhWbE9nb2dJQ0FnWWlCb1lYTldZV3gxWlY5aWJHOWphMEF3Q2dwb1lYTldZV3gxWlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnYUdGelZtRnNkV1VvYTJWNU9pQnpkSEpwYm1jcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFIyeHZZbUZzVFdGd0xtaGhjMVpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUkhiRzlpWVd4TllYQXVkR1Z6ZEV0bGVWQnlaV1pwZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JMWlhsUWNtVm1hWGc2Q2lBZ0lDQmlJSFJsYzNSTFpYbFFjbVZtYVhoZllteHZZMnRBTUFvS2RHVnpkRXRsZVZCeVpXWnBlRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdkR1Z6ZEV0bGVWQnlaV1pwZUNncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNDNTBaWE4wUzJWNVVISmxabWw0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0M1MFpYTjBVSEpsWm1sNFpXUk5ZWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBVSEpsWm1sNFpXUk5ZWEE2Q2lBZ0lDQmlJSFJsYzNSUWNtVm1hWGhsWkUxaGNGOWliRzlqYTBBd0NncDBaWE4wVUhKbFptbDRaV1JOWVhCZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUhSbGMzUlFjbVZtYVhobFpFMWhjQ2hyWlhrNklITjBjbWx1Wnl3Z2RtRnNkV1U2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSSGJHOWlZV3hOWVhBdWRHVnpkRkJ5WldacGVHVmtUV0Z3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0M1elpYUkJibVJIWlhSVmFXNTBLR3RsZVRvZ1lubDBaWE1zSUhaaGJIVmxPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSSGJHOWlZV3hOWVhBdWMyVjBRVzVrUjJWMFZXbHVkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJSE5sZEVGdVpFZGxkRlZwYm5Rb2EyVjVPaUJ6ZEhKcGJtY3NJSFpoYkhWbE9pQjFhVzUwTmpRcElIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFIyeHZZbUZzVFdGd0xuTmxkRUZ1WkVkbGRGVnBiblJmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNDNXpaWFJCYm1SSFpYUlZhVzUwWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFZwYm5STllYQWdQU0JIYkc5aVlXeE5ZWEE4YzNSeWFXNW5MQ0IxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZwYm5STllYQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdkR2hwY3k1MWFXNTBUV0Z3S0d0bGVTa3VkbUZzZFdVZ1BTQjJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUIxYVc1MFRXRndJRDBnUjJ4dlltRnNUV0Z3UEhOMGNtbHVaeXdnZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYVc1MFRXRndJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5WcGJuUk5ZWEFvYTJWNUtTNTJZV3gxWlNBOVBUMGdkbUZzZFdVc0lDZDFhVzUwSUhaaGJIVmxJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFZwYm5RZ2RtRnNkV1VnYzJodmRXeGtJRzFoZEdOb0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBSMnh2WW1Gc1RXRndMbk5sZEVGdVpFZGxkRUo1ZEdWektHdGxlVG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjQzV6WlhSQmJtUkhaWFJDZVhSbGN6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklITmxkRUZ1WkVkbGRFSjVkR1Z6S0d0bGVUb2djM1J5YVc1bkxDQjJZV3gxWlRvZ1lubDBaWE1wSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3TG5ObGRFRnVaRWRsZEVKNWRHVnpYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSSGJHOWlZV3hOWVhBdWMyVjBRVzVrUjJWMFFubDBaWE5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdZbmwwWlhOTllYQWdQU0JIYkc5aVlXeE5ZWEE4YzNSeWFXNW5MQ0JpZVhSbGN6NG9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZbmwwWlhOTllYQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdkR2hwY3k1aWVYUmxjMDFoY0NoclpYa3BMblpoYkhWbElEMGdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWW5sMFpYTk5ZWEFnUFNCSGJHOWlZV3hOWVhBOGMzUnlhVzVuTENCaWVYUmxjejRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW5sMFpYTk5ZWEFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlubDBaWE5OWVhBb2EyVjVLUzUyWVd4MVpTQTlQVDBnZG1Gc2RXVXNJQ2RpZVhSbGN5QjJZV3gxWlNCemFHOTFiR1FnYldGMFkyZ25LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaWVYUmxjeUIyWVd4MVpTQnphRzkxYkdRZ2JXRjBZMmdLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSSGJHOWlZV3hOWVhBdWMyVjBRVzVrUjJWMFUzUnlhVzVuS0d0bGVUb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNDNXpaWFJCYm1SSFpYUlRkSEpwYm1jNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCelpYUkJibVJIWlhSVGRISnBibWNvYTJWNU9pQnpkSEpwYm1jc0lIWmhiSFZsT2lCemRISnBibWNwSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3TG5ObGRFRnVaRWRsZEZOMGNtbHVaMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFIyeHZZbUZzVFdGd0xuTmxkRUZ1WkVkbGRGTjBjbWx1WjE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJ6ZEhKcGJtZE5ZWEFnUFNCSGJHOWlZV3hOWVhBOGMzUnlhVzVuTENCemRISnBibWMrS0NrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5OMGNtbHVaMDFoY0NJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCMGFHbHpMbk4wY21sdVowMWhjQ2hyWlhrcExuWmhiSFZsSUQwZ2RtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdjM1J5YVc1blRXRndJRDBnUjJ4dlltRnNUV0Z3UEhOMGNtbHVaeXdnYzNSeWFXNW5QaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6ZEhKcGJtZE5ZWEFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWMzUnlhVzVuVFdGd0tHdGxlU2t1ZG1Gc2RXVWdQVDA5SUhaaGJIVmxMQ0FuYzNSeWFXNW5JSFpoYkhWbElITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklITjBjbWx1WnlCMllXeDFaU0J6YUc5MWJHUWdiV0YwWTJnS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUkhiRzlpWVd4TllYQXVaR1ZzWlhSbFZtRnNkV1VvYTJWNU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjQzVrWld4bGRHVldZV3gxWlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdSbGJHVjBaVlpoYkhWbEtHdGxlVG9nYzNSeWFXNW5LU0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjQzVrWld4bGRHVldZV3gxWlY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBSMnh2WW1Gc1RXRndMbVJsYkdWMFpWWmhiSFZsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFZwYm5STllYQWdQU0JIYkc5aVlXeE5ZWEE4YzNSeWFXNW5MQ0IxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZwYm5STllYQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdkR2hwY3k1MWFXNTBUV0Z3S0d0bGVTa3VkbUZzZFdVZ1BTQXhNak1LSUNBZ0lIQjFjMmhwYm5RZ01USXpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QjFhVzUwVFdGd0lEMGdSMnh2WW1Gc1RXRndQSE4wY21sdVp5d2dkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjFhVzUwVFdGd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblZwYm5STllYQW9hMlY1S1M1b1lYTldZV3gxWlN3Z0ozTm9iM1ZzWkNCb1lYWmxJSFpoYkhWbElHSmxabTl5WlNCa1pXeGxkR1VuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QnphRzkxYkdRZ2FHRjJaU0IyWVd4MVpTQmlaV1p2Y21VZ1pHVnNaWFJsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJSFZwYm5STllYQWdQU0JIYkc5aVlXeE5ZWEE4YzNSeWFXNW5MQ0IxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZwYm5STllYQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdkR2hwY3k1MWFXNTBUV0Z3S0d0bGVTa3VaR1ZzWlhSbEtDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZlpHVnNDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklIVnBiblJOWVhBZ1BTQkhiRzlpWVd4TllYQThjM1J5YVc1bkxDQjFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnBiblJOWVhBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMblZwYm5STllYQW9hMlY1S1M1b1lYTldZV3gxWlN3Z0ozTm9iM1ZzWkNCdWIzUWdhR0YyWlNCMllXeDFaU0JoWm5SbGNpQmtaV3hsZEdVbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnphRzkxYkdRZ2JtOTBJR2hoZG1VZ2RtRnNkV1VnWVdaMFpYSWdaR1ZzWlhSbENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBSMnh2WW1Gc1RXRndMbWhoYzFaaGJIVmxLR3RsZVRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjQzVvWVhOV1lXeDFaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR2hoYzFaaGJIVmxLR3RsZVRvZ2MzUnlhVzVuS1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0M1b1lYTldZV3gxWlY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBSMnh2WW1Gc1RXRndMbWhoYzFaaGJIVmxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qWUtJQ0FnSUM4dklIVnBiblJOWVhBZ1BTQkhiRzlpWVd4TllYQThjM1J5YVc1bkxDQjFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnBiblJOWVhBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkV2x1ZEUxaGNDaHJaWGtwTG1oaGMxWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBSMnh2WW1Gc1RXRndMblJsYzNSTFpYbFFjbVZtYVhnb0tTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3TG5SbGMzUkxaWGxRY21WbWFYZzZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JIYkc5aVlXeE5ZWEF1ZEdWemRFdGxlVkJ5WldacGVGOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3TG5SbGMzUkxaWGxRY21WbWFYaGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblZwYm5STllYQXVhMlY1VUhKbFptbDRJRDA5UFNCQ2VYUmxjeWduZFdsdWRFMWhjQ2NwTENBblpHVm1ZWFZzZENCclpYa2djSEpsWm1sNElITm9iM1ZzWkNCaVpTQndjbTl3WlhKMGVTQnVZVzFsSnlrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5WcGJuUk5ZWEFpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYVc1MFRXRndJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCa1pXWmhkV3gwSUd0bGVTQndjbVZtYVhnZ2MyaHZkV3hrSUdKbElIQnliM0JsY25SNUlHNWhiV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5CeVpXWnBlR1ZrVFdGd0xtdGxlVkJ5WldacGVDQTlQVDBnUW5sMFpYTW9KM0F2Snlrc0lDZGxlSEJzYVdOcGRDQnJaWGtnY0hKbFptbDRJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0x5SUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQXZJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQnNhV05wZENCclpYa2djSEpsWm1sNElITm9iM1ZzWkNCdFlYUmphQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0M1MFpYTjBVSEpsWm1sNFpXUk5ZWEFvYTJWNU9pQmllWFJsY3l3Z2RtRnNkV1U2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNDNTBaWE4wVUhKbFptbDRaV1JOWVhBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCMFpYTjBVSEpsWm1sNFpXUk5ZWEFvYTJWNU9pQnpkSEpwYm1jc0lIWmhiSFZsT2lCMWFXNTBOalFwSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3TG5SbGMzUlFjbVZtYVhobFpFMWhjRjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFIyeHZZbUZzVFdGd0xuUmxjM1JRY21WbWFYaGxaRTFoY0Y5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJ3Y21WbWFYaGxaRTFoY0NBOUlFZHNiMkpoYkUxaGNEeHpkSEpwYm1jc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R3THljZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQXZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSFJvYVhNdWNISmxabWw0WldSTllYQW9hMlY1S1M1MllXeDFaU0E5SUhaaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIQnlaV1pwZUdWa1RXRndJRDBnUjJ4dlltRnNUV0Z3UEhOMGNtbHVaeXdnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozQXZKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0M4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjSEpsWm1sNFpXUk5ZWEFvYTJWNUtTNTJZV3gxWlNBOVBUMGdkbUZzZFdVc0lDZHdjbVZtYVhobFpDQnRZWEFnZG1Gc2RXVWdjMmh2ZFd4a0lHMWhkR05vSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjSEpsWm1sNFpXUWdiV0Z3SUhaaGJIVmxJSE5vYjNWc1pDQnRZWFJqYUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNDNWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVNkNpQWdJQ0JpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdDZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0NDWUVCM1ZwYm5STllYQUNjQzhJWW5sMFpYTk5ZWEFKYzNSeWFXNW5UV0Z3UWdBQVFnQUFNUnNpRTBFQWlFSUFBREVaSWhKRU1SZ2lFMEVBZGtJQUFEWWFBSUFFQVJKTGM0QUVyc1JCdUlBRW90SURrb0FFZThFbW5ZQUVmVVNzbG9BRU4yU3g3WUFFczJ5K0trOEhqZ2NBTGdBb0FDSUFIQUFXQUJBQUNrSUFBRUlBQUVJQUFBQ0lBUUZDLy9PSUFQTkMvKzJJQU1KQy8rZUlBS0pDLytHSUFIQkMvOXVJQUQ1Qy85V0lBQlZDLzg5Qy84OHhHU0lTTVJnaUVoQkVpQUdjSTBOQ0FBQTJHZ0ZKSWxrakN5UUlTd0VWRWtSWEFnQTJHZ0pKRlNVU1JCZUlBTW9qUTBJQUFEWWFBVWtpV1NNTEpBaExBUlVTUkZjQ0FEWWFBa2tpV1NNTEpBaExBUlVTUkZjQ0FJZ0F1U05EUWdBQU5ob0JTU0paSXdza0NFc0JGUkpFVndJQU5ob0NTU0paSXdza0NFc0JGUkpFVndJQWlBQ29JME5DQUFBMkdnRkpJbGtqQ3lRSVN3RVZFa1JYQWdDSUFLa2pRMElBQURZYUFVa2lXU01MSkFoTEFSVVNSRmNDQUlnQXRZQUJBQ0pQQWxTQUJCVWZmSFZQQVZDd0kwTkNBQUNJQUswalEwSUFBRFlhQVVraVdTTUxKQWhMQVJVU1JGY0NBRFlhQWtrVkpSSkVGNGdBbGlORGlnSUFRZ0FBS0l2K1VJdi9aeWlML2xBaVR3RmxSSXYvRWtTSmlnSUFRZ0FBS292K1VJdi9aeXFML2xBaVR3RmxSSXYvRWtTSmlnSUFRZ0FBSzR2K1VJdi9aeXVML2xBaVR3RmxSSXYvRWtTSmlnRUFRZ0FBS0l2L1VJRjdaeWlMLzFBaVR3RmxSQ2lMLzFCcEtJdi9VQ0pQQVdVVVJJbUtBUUZDQUFBb2kvOVFJazhCWlU4QmlVSUFBQ2dvRWtRcEtSSkVpWW9DQUVJQUFDbUwvbENMLzJjcGkvNVFJazhCWlVTTC94SkVpVUlBQUlrPSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
