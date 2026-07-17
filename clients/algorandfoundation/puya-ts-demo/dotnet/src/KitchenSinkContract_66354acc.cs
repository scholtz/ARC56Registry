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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.KitchenSinkContract_66354acc
{


    public class KitchenSinkContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public KitchenSinkContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task UseState(ulong a, string b, ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 172, 113, 93 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UseState_Transactions(ulong a, string b, ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 172, 113, 93 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 12, 110, 77 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 12, 110, 77 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        /// <param name="x"> </param>
        public async Task AddToBox(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 67, 206, 33 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddToBox_Transactions(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 67, 206, 33 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            return await base.MakeTransactionList(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task AddToBoxMap(string x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 73, 178, 163 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddToBoxMap_Transactions(string x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 73, 178, 163 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); xAbi.From(x);

            return await base.MakeTransactionList(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="content"> </param>
        /// <param name="offset"> </param>
        /// <param name="boxSize"> </param>
        public async Task InsertIntoBoxRef(byte[] content, ulong offset, ulong boxSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 216, 152, 183 };
            var contentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); contentAbi.From(content);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var boxSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxSizeAbi.From(boxSize);

            var result = await base.CallApp(new List<object> { abiHandle, contentAbi, offsetAbi, boxSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InsertIntoBoxRef_Transactions(byte[] content, ulong offset, ulong boxSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 216, 152, 183 };
            var contentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); contentAbi.From(content);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var boxSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxSizeAbi.From(boxSize);

            return await base.MakeTransactionList(new List<object> { abiHandle, contentAbi, offsetAbi, boxSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="a"> </param>
        public async Task<string> SayHello(string name, ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 224, 244, 181 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SayHello_Transactions(string name, ulong a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 224, 244, 181 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task CheckTransaction(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 73, 165, 90, 232 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckTransaction_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 73, 165, 90, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS2l0Y2hlblNpbmtDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ1c2VTdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZUFwcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkVG9Cb3giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRUb0JveE1hcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imluc2VydEludG9Cb3hSZWYiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udGVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2Zmc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3hTaXplIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNheUhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVja1RyYW5zYWN0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0OSwzNDVdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgT3B0SW4gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1M10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Nl0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTUsMTcxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUzXSwiZXJyb3JNZXNzYWdlIjoibWF4IGFycmF5IGxlbmd0aCBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0ppSWlBd2VHWm1JQ0puYkc5aVlXeEpiblFpSUNKamRYTjBiMjFMWlhraUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJuYkc5aVlXeEpiblFnUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RRcElIMHBPd29nSUNBZ1lubDBaV05mTWlBdkx5QWlaMnh2WW1Gc1NXNTBJZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJMYVhSamFHVnVVMmx1YTBOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWprek1UUmtPVFVnTHk4Z2JXVjBhRzlrSUNKdmNIUkpiaWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmIzQjBTVzVmY205MWRHVkFOQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNbVJoWXpjeE5XUWdNSGhtTnpRelkyVXlNU0F3ZUROaE5EbGlNbUV6SURCNFpqVmtPRGs0WWpjZ01IZzJZMlV3WmpSaU5TQXdlRFE1WVRVMVlXVTRJQzh2SUcxbGRHaHZaQ0FpZFhObFUzUmhkR1VvZFdsdWREWTBMSE4wY21sdVp5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSa1ZHOUNiM2dvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRlJ2UW05NFRXRndLSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGJuTmxjblJKYm5SdlFtOTRVbVZtS0dKNWRHVmJYU3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5OaGVVaGxiR3h2S0hOMGNtbHVaeXgxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSmphR1ZqYTFSeVlXNXpZV04wYVc5dUtIQmhlU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkWE5sVTNSaGRHVWdZV1JrVkc5Q2IzZ2dZV1JrVkc5Q2IzaE5ZWEFnYVc1elpYSjBTVzUwYjBKdmVGSmxaaUJ6WVhsSVpXeHNieUJqYUdWamExUnlZVzV6WVdOMGFXOXVDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1MybDBZMmhsYmxOcGJtdERiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTmpNR00yWlRSa0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbFFYQndDaUFnSUNCbGNuSUtDbTFoYVc1ZmIzQjBTVzVmY205MWRHVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlyYVhSamFHVnVMWE5wYm1zdmEybDBZMmhsYmkxemFXNXJMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNpVDNCMFNXNGlYU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU5d2RFbHVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRnTHk4Z2IyNGdaWEp5YjNJNklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTl3ZEVsdUlDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0Nnb3ZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPanBMYVhSamFHVnVVMmx1YTBOdmJuUnlZV04wTG5WelpWTjBZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYTmxVM1JoZEdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCMWMyVlRkR0YwWlNoaE9pQjFhVzUwTmpRc0lHSTZJSE4wY21sdVp5d2dZem9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCemQyRndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUIwYUdsekxtZHNiMkpoYkVsdWRDNTJZV3gxWlNBcVBTQmhPd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHZHNiMkpoYkVsdWRDQTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9OQ2tnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbmJHOWlZV3hKYm5RaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCMGFHbHpMbWRzYjJKaGJFbHVkQzUyWVd4MVpTQXFQU0JoT3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHZHNiMkpoYkVsdWRDQTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9OQ2tnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbmJHOWlZV3hKYm5RaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCMGFHbHpMbWRzYjJKaGJFbHVkQzUyWVd4MVpTQXFQU0JoT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG1kc2IySmhiRk4wY21sdVp5NW9ZWE5XWVd4MVpTa2dld29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHZHNiMkpoYkZOMGNtbHVaeUE5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b2V5QnJaWGs2SUNKamRYTjBiMjFMWlhraUlIMHBPd29nSUNBZ1lubDBaV05mTXlBdkx5QWlZM1Z6ZEc5dFMyVjVJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnRwZEdOb1pXNHRjMmx1YXk5cmFYUmphR1Z1TFhOcGJtc3VZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXVaMnh2WW1Gc1UzUnlhVzVuTG1oaGMxWmhiSFZsS1NCN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUIxYzJWVGRHRjBaVjlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJ0cGRHTm9aVzR0YzJsdWF5OXJhWFJqYUdWdUxYTnBibXN1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnZEdocGN5NW5iRzlpWVd4VGRISnBibWN1ZG1Gc2RXVWdLejBnWWpzS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJuYkc5aVlXeFRkSEpwYm1jZ1BTQkhiRzlpWVd4VGRHRjBaVHh6ZEhKcGJtYytLSHNnYTJWNU9pQWlZM1Z6ZEc5dFMyVjVJaUI5S1RzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1OMWMzUnZiVXRsZVNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhSb2FYTXVaMnh2WW1Gc1UzUnlhVzVuTG5aaGJIVmxJQ3M5SUdJN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbmJHOWlZV3hUZEhKcGJtY2dQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUFpWTNWemRHOXRTMlY1SWlCOUtUc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTjFjM1J2YlV0bGVTSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIUm9hWE11WjJ4dlltRnNVM1J5YVc1bkxuWmhiSFZsSUNzOUlHSTdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LZFhObFUzUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnRwZEdOb1pXNHRjMmx1YXk5cmFYUmphR1Z1TFhOcGJtc3VZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdhV1lnS0ZSNGJpNXpaVzVrWlhJdWFYTlBjSFJsWkVsdUtFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDa3BJSHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWEJ3WDI5d2RHVmtYMmx1Q2lBZ0lDQmllaUIxYzJWVGRHRjBaVjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeENhV2RKYm5Rb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQkNhV2RWYVc1MEtHTXBJQ29nUW1sblZXbHVkQ2hoS1RzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJR2wwYjJJS0lDQWdJR0lxQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QnNiMk5oYkVKcFowbHVkQ0E5SUV4dlkyRnNVM1JoZEdVOFltbG5kV2x1ZEQ0b0tUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJHOWpZV3hDYVdkSmJuUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNRbWxuU1c1MEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdRbWxuVldsdWRDaGpLU0FxSUVKcFoxVnBiblFvWVNrN0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLQ25WelpWTjBZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlyYVhSamFHVnVMWE5wYm1zdmEybDBZMmhsYmkxemFXNXJMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJSFZ6WlZOMFlYUmxLR0U2SUhWcGJuUTJOQ3dnWWpvZ2MzUnlhVzVuTENCak9pQjFhVzUwTmpRcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDblZ6WlZOMFlYUmxYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJ0cGRHTm9aVzR0YzJsdWF5OXJhWFJqYUdWdUxYTnBibXN1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWjJ4dlltRnNVM1J5YVc1bklEMGdSMnh2WW1Gc1UzUmhkR1U4YzNSeWFXNW5QaWg3SUd0bGVUb2dJbU4xYzNSdmJVdGxlU0lnZlNrN0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKamRYTjBiMjFMWlhraUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGFHbHpMbWRzYjJKaGJGTjBjbWx1Wnk1MllXeDFaU0E5SUdJN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWWlCMWMyVlRkR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRFFLQ2dvdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qcExhWFJqYUdWdVUybHVhME52Ym5SeVlXTjBMbU55WldGMFpVRndjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0RvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdkc2IySmhiRWx1ZENBOUlFZHNiMkpoYkZOMFlYUmxLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb05Da2dmU2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0puYkc5aVlXeEpiblFpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUIwYUdsekxtZHNiMkpoYkVsdWRDNTJZV3gxWlNBOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDNXBaRHNLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSW5KbGNYVnBjbVVpTENCaGJHeHZkMEZqZEdsdmJuTTZJQ0pPYjA5d0lpQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk9rdHBkR05vWlc1VGFXNXJRMjl1ZEhKaFkzUXVZV1JrVkc5Q2IzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSVWIwSnZlRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlyYVhSamFHVnVMWE5wYm1zdmEybDBZMmhsYmkxemFXNXJMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR0ZrWkZSdlFtOTRLSGc2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJ0cGRHTm9aVzR0YzJsdWF5OXJhWFJqYUdWdUxYTnBibXN1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnWW05NFQyWkJjbkpoZVNBOUlFSnZlRHhFZVc1aGJXbGpRWEp5WVhrOFZXbHVkRHcyTkQ0K1BpaDdJR3RsZVRvZ0ltSWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1aWIzaFBaa0Z5Y21GNUxtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWVdSa1ZHOUNiM2hmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhSb2FYTXVZbTk0VDJaQmNuSmhlUzUyWVd4MVpTQTlJRzVsZHlCRWVXNWhiV2xqUVhKeVlYa29ibVYzSUZWcGJuUThOalErS0hncEtUc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJ0cGRHTm9aVzR0YzJsdWF5OXJhWFJqYUdWdUxYTnBibXN1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnWW05NFQyWkJjbkpoZVNBOUlFSnZlRHhFZVc1aGJXbGpRWEp5WVhrOFZXbHVkRHcyTkQ0K1BpaDdJR3RsZVRvZ0ltSWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhSb2FYTXVZbTk0VDJaQmNuSmhlUzUyWVd4MVpTQTlJRzVsZHlCRWVXNWhiV2xqUVhKeVlYa29ibVYzSUZWcGJuUThOalErS0hncEtUc0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnRwZEdOb1pXNHRjMmx1YXk5cmFYUmphR1Z1TFhOcGJtc3VZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdZbTk0VDJaQmNuSmhlU0E5SUVKdmVEeEVlVzVoYldsalFYSnlZWGs4VldsdWREdzJORDQrUGloN0lHdGxlVG9nSW1JaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlyYVhSamFHVnVMWE5wYm1zdmEybDBZMmhsYmkxemFXNXJMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJSFJvYVhNdVltOTRUMlpCY25KaGVTNTJZV3gxWlNBOUlHNWxkeUJFZVc1aGJXbGpRWEp5WVhrb2JtVjNJRlZwYm5ROE5qUStLSGdwS1RzS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtDbUZrWkZSdlFtOTRYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHRmtaRlJ2UW05NEtIZzZJSFZwYm5RMk5Da2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWVdSa1ZHOUNiM2hmWld4elpWOWliMlI1UURNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCaWIzaFBaa0Z5Y21GNUlEMGdRbTk0UEVSNWJtRnRhV05CY25KaGVUeFZhVzUwUERZMFBqNCtLSHNnYTJWNU9pQWlZaUlnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwydHBkR05vWlc0dGMybHVheTlyYVhSamFHVnVMWE5wYm1zdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoUFprRnljbUY1TG5aaGJIVmxMbkIxYzJnb2JtVjNJRlZwYm5ROE5qUStLSGdwS1RzS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwSUM4dklHOXVJR1Z5Y205eU9pQnRZWGdnWVhKeVlYa2diR1Z1WjNSb0lHVjRZMlZsWkdWa0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJ0cGRHTm9aVzR0YzJsdWF5OXJhWFJqYUdWdUxYTnBibXN1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnWW05NFQyWkJjbkpoZVNBOUlFSnZlRHhFZVc1aGJXbGpRWEp5WVhrOFZXbHVkRHcyTkQ0K1BpaDdJR3RsZVRvZ0ltSWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhSb2FYTXVZbTk0VDJaQmNuSmhlUzUyWVd4MVpTNXdkWE5vS0c1bGR5QlZhVzUwUERZMFBpaDRLU2s3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdKdmVFOW1RWEp5WVhrZ1BTQkNiM2c4UkhsdVlXMXBZMEZ5Y21GNVBGVnBiblE4TmpRK1BqNG9leUJyWlhrNklDSmlJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1JaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCMGFHbHpMbUp2ZUU5bVFYSnlZWGt1ZG1Gc2RXVXVjSFZ6YUNodVpYY2dWV2x1ZER3Mk5ENG9lQ2twT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCaFpHUlViMEp2ZUY5aFpuUmxjbDlwWmw5bGJITmxRRFFLQ2dvdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qcExhWFJqYUdWdVUybHVhME52Ym5SeVlXTjBMbUZrWkZSdlFtOTRUV0Z3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtWRzlDYjNoTllYQTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QmhaR1JVYjBKdmVFMWhjQ2g0T2lCemRISnBibWNwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxtSnZlRTFoY0NoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlFSjVkR1Z6S0hncE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklHRmtaRlJ2UW05NFRXRndLSGc2SUhOMGNtbHVaeWtnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlyYVhSamFHVnVMWE5wYm1zdmEybDBZMmhsYmkxemFXNXJMbUZzWjI4dWRITTZPa3RwZEdOb1pXNVRhVzVyUTI5dWRISmhZM1F1YVc1elpYSjBTVzUwYjBKdmVGSmxabHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWMyVnlkRWx1ZEc5Q2IzaFNaV1k2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJwYm5ObGNuUkpiblJ2UW05NFVtVm1LR052Ym5SbGJuUTZJR0o1ZEdWekxDQnZabVp6WlhRNklIVnBiblEyTkN3Z1ltOTRVMmw2WlRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnRwZEdOb1pXNHRjMmx1YXk5cmFYUmphR1Z1TFhOcGJtc3VZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdZWE56WlhKMEtHOW1abk5sZENBcklHTnZiblJsYm5RdWJHVnVaM1JvSUR3Z1ltOTRVMmw2WlNrN0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnRwZEdOb1pXNHRjMmx1YXk5cmFYUmphR1Z1TFhOcGJtc3VZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdZbTk0VW1WbUlEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dRbmwwWlhNdVpuSnZiVWhsZUNnaVJrWWlLU0I5S1RzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhobVpnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwydHBkR05vWlc0dGMybHVheTlyYVhSamFHVnVMWE5wYm1zdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdVltOTRVbVZtTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnBibk5sY25SSmJuUnZRbTk0VW1WbVgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmliM2hTWldZZ1BTQkNiM2c4WW5sMFpYTStLSHNnYTJWNU9pQkNlWFJsY3k1bWNtOXRTR1Y0S0NKR1JpSXBJSDBwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUdabUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCMGFHbHpMbUp2ZUZKbFppNWpjbVZoZEdVb2V5QnphWHBsT2lCaWIzaFRhWHBsSUgwcE93b2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvS2FXNXpaWEowU1c1MGIwSnZlRkpsWmw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJpYjNoU1pXWWdQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUJDZVhSbGN5NW1jbTl0U0dWNEtDSkdSaUlwSUgwcE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VHWm1DaUFnSUNBdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QjBhR2x6TG1KdmVGSmxaaTV6Y0d4cFkyVW9iMlptYzJWMExDQnZabVp6WlhRZ0t5QmpiMjUwWlc1MExteGxibWQwYUN3Z1kyOXVkR1Z1ZENrN0NpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QTJDaUFnSUNCaWIzaGZjM0JzYVdObENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCcGJuTmxjblJKYm5SdlFtOTRVbVZtS0dOdmJuUmxiblE2SUdKNWRHVnpMQ0J2Wm1aelpYUTZJSFZwYm5RMk5Dd2dZbTk0VTJsNlpUb2dkV2x1ZERZMEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BwYm5ObGNuUkpiblJ2UW05NFVtVm1YMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJ0cGRHTm9aVzR0YzJsdWF5OXJhWFJqYUdWdUxYTnBibXN1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWW05NFVtVm1JRDBnUW05NFBHSjVkR1Z6UGloN0lHdGxlVG9nUW5sMFpYTXVabkp2YlVobGVDZ2lSa1lpS1NCOUtUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IaG1aZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMnRwZEdOb1pXNHRjMmx1YXk5cmFYUmphR1Z1TFhOcGJtc3VZV3huYnk1MGN6bzNNZ29nSUNBZ0x5OGdmU0JsYkhObElHbG1JQ2gwYUdsekxtSnZlRkpsWmk1c1pXNW5kR2dnSVQwOUlHSnZlRk5wZW1VcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCa2FXY2dNZ29nSUNBZ0lUMEtJQ0FnSUdKNklHbHVjMlZ5ZEVsdWRHOUNiM2hTWldaZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJpYjNoU1pXWWdQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUJDZVhSbGN5NW1jbTl0U0dWNEtDSkdSaUlwSUgwcE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VHWm1DaUFnSUNBdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QjBhR2x6TG1KdmVGSmxaaTV5WlhOcGVtVW9ZbTk0VTJsNlpTazdDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYM0psYzJsNlpRb2dJQ0FnWWlCcGJuTmxjblJKYm5SdlFtOTRVbVZtWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29LQ2k4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk9rdHBkR05vWlc1VGFXNXJRMjl1ZEhKaFkzUXVjMkY1U0dWc2JHOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WVhsSVpXeHNiem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlyYVhSamFHVnVMWE5wYm1zdmEybDBZMmhsYmkxemFXNXJMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJSE5oZVVobGJHeHZLRzVoYldVNklITjBjbWx1Wnl3Z1lUb2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pjNUNpQWdJQ0F2THlCeVpYUjFjbTRnWUNSN2RHaHBjeTVuWlhSSVpXeHNieWdwZlNBa2UyNWhiV1Y5SUNSN1FubDBaWE1vWVNsOVlEc0tJQ0FnSUhCMWMyaGllWFJsY3lBaVNHVnNiRzhnSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCellYbElaV3hzYnlodVlXMWxPaUJ6ZEhKcGJtY3NJR0U2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwydHBkR05vWlc0dGMybHVheTlyYVhSamFHVnVMWE5wYm1zdVlXeG5ieTUwY3pvNlMybDBZMmhsYmxOcGJtdERiMjUwY21GamRDNWphR1ZqYTFSeVlXNXpZV04wYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMmhsWTJ0VWNtRnVjMkZqZEdsdmJqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHTm9aV05yVkhKaGJuTmhZM1JwYjI0b2NHRjVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwydHBkR05vWlc0dGMybHVheTlyYVhSamFHVnVMWE5wYm1zdVlXeG5ieTUwY3pvNE15MDRPQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvY0dGNUxDQjdDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dleUJpWlhSM1pXVnVPaUJiTVRBd01Dd2dNakF3TUYwZ2ZTd0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtPaUI3SUdkeVpXRjBaWEpVYUdGdU9pQkhiRzlpWVd3dWNtOTFibVFnZlN3S0lDQWdJQzh2SUNBZ2MyVnVaR1Z5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtMbUZrWkhKbGMzTXNDaUFnSUNBdkx5QjlLVHNLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk9EUUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ2V5QmlaWFIzWldWdU9pQmJNVEF3TUN3Z01qQXdNRjBnZlN3S0lDQWdJSEIxYzJocGJuUWdNakF3TUNBdkx5QXlNREF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPamd6TFRnNENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGtzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCN0lHSmxkSGRsWlc0NklGc3hNREF3TENBeU1EQXdYU0I5TEFvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIc2daM0psWVhSbGNsUm9ZVzQ2SUVkc2IySmhiQzV5YjNWdVpDQjlMQW9nSUNBZ0x5OGdJQ0J6Wlc1a1pYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRdVlXUmtjbVZ6Y3l3S0lDQWdJQzh2SUgwcE93b2dJQ0FnUEQwS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdGdGIzVnVkRG9nZXlCaVpYUjNaV1Z1T2lCYk1UQXdNQ3dnTWpBd01GMGdmU3dLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNQ0F2THlBeE1EQXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhMmwwWTJobGJpMXphVzVyTDJ0cGRHTm9aVzR0YzJsdWF5NWhiR2R2TG5Sek9qZ3pMVGc0Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNod1lYa3NJSHNLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUI3SUdKbGRIZGxaVzQ2SUZzeE1EQXdMQ0F5TURBd1hTQjlMQW9nSUNBZ0x5OGdJQ0JzWVhOMFZtRnNhV1E2SUhzZ1ozSmxZWFJsY2xSb1lXNDZJRWRzYjJKaGJDNXliM1Z1WkNCOUxBb2dJQ0FnTHk4Z0lDQnpaVzVrWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1F1WVdSa2NtVnpjeXdLSUNBZ0lDOHZJSDBwT3dvZ0lDQWdQajBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nVEdGemRGWmhiR2xrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJzWVhOMFZtRnNhV1E2SUhzZ1ozSmxZWFJsY2xSb1lXNDZJRWRzYjJKaGJDNXliM1Z1WkNCOUxBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmEybDBZMmhsYmkxemFXNXJMMnRwZEdOb1pXNHRjMmx1YXk1aGJHZHZMblJ6T2pnekxUZzRDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2h3WVhrc0lIc0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQjdJR0psZEhkbFpXNDZJRnN4TURBd0xDQXlNREF3WFNCOUxBb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSHNnWjNKbFlYUmxjbFJvWVc0NklFZHNiMkpoYkM1eWIzVnVaQ0I5TEFvZ0lDQWdMeThnSUNCelpXNWtaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNXUXVZV1JrY21WemN5d0tJQ0FnSUM4dklIMHBPd29nSUNBZ1Bnb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cmFYUmphR1Z1TFhOcGJtc3ZhMmwwWTJobGJpMXphVzVyTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhObGJtUmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlyYVhSamFHVnVMWE5wYm1zdmEybDBZMmhsYmkxemFXNXJMbUZzWjI4dWRITTZPRE10T0RnS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tIQmhlU3dnZXdvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhzZ1ltVjBkMlZsYmpvZ1d6RXdNREFzSURJd01EQmRJSDBzQ2lBZ0lDQXZMeUFnSUd4aGMzUldZV3hwWkRvZ2V5Qm5jbVZoZEdWeVZHaGhiam9nUjJ4dlltRnNMbkp2ZFc1a0lIMHNDaUFnSUNBdkx5QWdJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKWkM1aFpHUnlaWE56TEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YTJsMFkyaGxiaTF6YVc1ckwydHBkR05vWlc0dGMybHVheTVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJ5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTG1Ga1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk9ETXRPRGdLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0hCaGVTd2dld29nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSHNnWW1WMGQyVmxiam9nV3pFd01EQXNJREl3TURCZElIMHNDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaRG9nZXlCbmNtVmhkR1Z5VkdoaGJqb2dSMnh2WW1Gc0xuSnZkVzVrSUgwc0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVoWkdSeVpYTnpMQW9nSUNBZ0x5OGdmU2s3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXJhWFJqYUdWdUxYTnBibXN2YTJsMFkyaGxiaTF6YVc1ckxtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHTm9aV05yVkhKaGJuTmhZM1JwYjI0b2NHRjVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBJSHNLSUNBZ0lISmxkSFZ5YmlBdkx5QnZiaUJsY25KdmNqb2dZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUJBRmlBZjhKWjJ4dlltRnNTVzUwQ1dOMWMzUnZiVXRsZVRFWVFBQUVLb0VFWjRBRUtURk5sVFlhQUk0QkFFa3hHUlJFTVJoQkFES0NCZ1F0ckhGZEJQZER6aUVFT2tteW93VDEySmkzQkd6ZzlMVUVTYVZhNkRZYUFJNEdBQmNBY0FDakFMSUErQUVuQUlBRXpBeHVUVFlhQUk0QkFGd0FNUmtpRWpFWUVFTTJHZ0VYU1RZYUFsY0NBRXcyR2dNWFRnSWpLbVZFQ3lwTVp5TXJaVVVCUVFBckl5dGxSRXhRSzB4bk1RQXlDR0ZCQUJoSkZrc0NGcU14QUlBTGJHOWpZV3hDYVdkSmJuUlBBbVlpUXl0TVowTC8yQ295Q0djaVF6WWFBU2k5UlFGQUFBNkFBZ0FCVEZBb3ZFZ29UTDhpUXlpK1JFbFBBbEJNSTFraUNCWlhCZ0pjQUNpOFNDaE12MEwvNHpZYUFWY0NBREVBU2J4SVRMOGlRellhQVZjQ0FFazJHZ0lYU1U0Q05ob0RGMGxPQWs0RFR3SVZDRWxQQWd4RUtiMUZBVUVBRHlsTEFybElLVXNEU3dKTEJ0SWlReW05UkVzQ0UwSC83U2xMQXROQy8rWTJHZ0ZYQWdBMkdnSVhnQVpJWld4c2J5QlBBbENBQVNCUVRCWlFTUlVXVndZQ1RGQ0FCQlVmZkhWTVVMQWlRekVXSWdsSk9CQWlFa1JKT0FoSmdkQVBEa3lCNkFjUEVFc0JPQVF5QmcwUVN3RTRBREVBRWhCTU9BY3lDSElJUkJJUVF3PT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
