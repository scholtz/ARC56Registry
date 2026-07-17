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

namespace Arc56.Generated.algorandfoundation.TEALScript.BinaryTest_1535f562
{


    public class BinaryTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BinaryTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task And(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 209, 58, 19 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> And_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 209, 58, 19 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task Or(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 10, 168, 135 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Or_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 10, 168, 135 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task Equal(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 60, 135, 239 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Equal_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 60, 135, 239 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task NotEqual(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 255, 185, 211 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NotEqual_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 255, 185, 211 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task BitAnd(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 133, 24, 142 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BitAnd_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 133, 24, 142 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task BitOr(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 45, 199, 63 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BitOr_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 45, 199, 63 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task BitXor(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 70, 80, 74 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BitXor_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 70, 80, 74 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task Combo(ulong a, ulong b, ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 220, 81, 80 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Combo_Transactions(ulong a, ulong b, ulong c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 220, 81, 80 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task BitwiseXorOp(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 194, 165, 111 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BitwiseXorOp_Transactions(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 194, 165, 111 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task BitwiseAndOp(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 114, 62, 94 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BitwiseAndOp_Transactions(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 114, 62, 94 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task BitwiseOrOp(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 200, 53, 133 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BitwiseOrOp_Transactions(byte[] a, byte[] b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 200, 53, 133 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task BitwiseNotOp(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 107, 206, 167 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BitwiseNotOp_Transactions(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 107, 206, 167 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJCaW5hcnlUZXN0IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJhbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoib3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZXF1YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoibm90RXF1YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiYml0QW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImJpdE9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImJpdFhvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjb21ibyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJiaXR3aXNlWG9yT3AiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiYml0d2lzZUFuZE9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImJpdHdpc2VPck9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImJpdHdpc2VOb3RPcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NCJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NCJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NCJ9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NCJ9LHsicGMiOls0MCw0MSw0Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo1In0seyJwYyI6WzQzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjUifSx7InBjIjpbNDQsNDUsNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NSJ9LHsicGMiOls0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo1In0seyJwYyI6WzQ4LDQ5LDUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjUifSx7InBjIjpbNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NSJ9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo1In0seyJwYyI6WzUzLDU0LDU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjUifSx7InBjIjpbNTYsNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NiJ9LHsicGMiOls1OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo2In0seyJwYyI6WzU5LDYwLDYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjYifSx7InBjIjpbNjIsNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NiJ9LHsicGMiOls2NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo2In0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjYifSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NSJ9LHsicGMiOls2Nyw2OCw2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo5In0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjkifSx7InBjIjpbNzEsNzIsNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6OSJ9LHsicGMiOls3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo5In0seyJwYyI6Wzc1LDc2LDc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjkifSx7InBjIjpbNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6OSJ9LHsicGMiOls3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo5In0seyJwYyI6WzgwLDgxLDgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjkifSx7InBjIjpbODMsODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTAifSx7InBjIjpbODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTAifSx7InBjIjpbODYsODcsODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTAifSx7InBjIjpbODksOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTAifSx7InBjIjpbOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTAifSx7InBjIjpbOTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTAifSx7InBjIjpbOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6OSJ9LHsicGMiOls5NCw5NSw5Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoxMyJ9LHsicGMiOls5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoxMyJ9LHsicGMiOls5OCw5OSwxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTMifSx7InBjIjpbMTAxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjEzIn0seyJwYyI6WzEwMiwxMDMsMTA0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjEzIn0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTMifSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoxMyJ9LHsicGMiOlsxMDcsMTA4LDEwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTMifSx7InBjIjpbMTEwLDExMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTQifSx7InBjIjpbMTEyLDExM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTQifSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoxNCJ9LHsicGMiOlsxMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjE0In0seyJwYyI6WzExNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTMifSx7InBjIjpbMTE3LDExOCwxMTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjE3In0seyJwYyI6WzEyMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTcifSx7InBjIjpbMTIxLDEyMiwxMjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjE3In0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTcifSx7InBjIjpbMTI1LDEyNiwxMjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjE3In0seyJwYyI6WzEyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTcifSx7InBjIjpbMTI5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoxNyJ9LHsicGMiOlsxMzAsMTMxLDEzMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTcifSx7InBjIjpbMTMzLDEzNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTgifSx7InBjIjpbMTM1LDEzNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTgifSx7InBjIjpbMTM3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoxOCJ9LHsicGMiOlsxMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjE4In0seyJwYyI6WzEzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MTcifSx7InBjIjpbMTQwLDE0MSwxNDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjIxIn0seyJwYyI6WzE0M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjEifSx7InBjIjpbMTQ0LDE0NSwxNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjIxIn0seyJwYyI6WzE0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjEifSx7InBjIjpbMTQ4LDE0OSwxNTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjIxIn0seyJwYyI6WzE1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjEifSx7InBjIjpbMTUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoyMSJ9LHsicGMiOlsxNTMsMTU0LDE1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjEifSx7InBjIjpbMTU2LDE1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjIifSx7InBjIjpbMTU4LDE1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTY0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjIifSx7InBjIjpbMTYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoyMiJ9LHsicGMiOlsxNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzE2Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTY3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjEifSx7InBjIjpbMTYzLDE2NCwxNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjI1In0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTczLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjUifSx7InBjIjpbMTY3LDE2OCwxNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjI1In0seyJwYyI6WzE3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTc3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjUifSx7InBjIjpbMTcxLDE3MiwxNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjI1In0seyJwYyI6WzE3NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjUifSx7InBjIjpbMTc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxODIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoyNSJ9LHsicGMiOlsxNzYsMTc3LDE3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjUifSx7InBjIjpbMTc5LDE4MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTkwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjYifSx7InBjIjpbMTgxLDE4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTkxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjYifSx7InBjIjpbMTgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoyNiJ9LHsicGMiOlsxODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE4NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTk0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjUifSx7InBjIjpbMTg2LDE4NywxODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjI5In0seyJwYyI6WzE4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjkifSx7InBjIjpbMTkwLDE5MSwxOTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjI5In0seyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjA0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjkifSx7InBjIjpbMTk0LDE5NSwxOTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjI5In0seyJwYyI6WzE5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjA4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjkifSx7InBjIjpbMTk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czoyOSJ9LHsicGMiOlsxOTksMjAwLDIwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjkifSx7InBjIjpbMjAyLDIwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzAifSx7InBjIjpbMjA0LDIwNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzAifSx7InBjIjpbMjA2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozMCJ9LHsicGMiOlsyMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjMwIn0seyJwYyI6WzIwOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MjkifSx7InBjIjpbMjA5LDIxMCwyMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjMzIn0seyJwYyI6WzIxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjI3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzMifSx7InBjIjpbMjEzLDIxNCwyMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIzMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjMzIn0seyJwYyI6WzIxNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjMxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzMifSx7InBjIjpbMjE3LDIxOCwyMTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIzNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjMzIn0seyJwYyI6WzIyMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzMifSx7InBjIjpbMjIxLDIyMiwyMjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIzOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjMzIn0seyJwYyI6WzIyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzMifSx7InBjIjpbMjI1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozMyJ9LHsicGMiOlsyMjYsMjI3LDIyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjQ0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzMifSx7InBjIjpbMjI5LDIzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzQifSx7InBjIjpbMjMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozNCJ9LHsicGMiOlsyMzIsMjMzLDIzNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzQifSx7InBjIjpbMjM1LDIzNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzQifSx7InBjIjpbMjM3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozNCJ9LHsicGMiOlsyMzgsMjM5LDI0MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjUzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzQifSx7InBjIjpbMjQxLDI0Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzQifSx7InBjIjpbMjQzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozNCJ9LHsicGMiOlsyNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjM0In0seyJwYyI6WzI0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzQifSx7InBjIjpbMjQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozMyJ9LHsicGMiOlsyNDcsMjQ4LDI0OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjY3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzcifSx7InBjIjpbMjUwLDI1MSwyNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjM3In0seyJwYyI6WzI1MywyNTQsMjU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozNyJ9LHsicGMiOlsyNTYsMjU3LDI1OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzcifSx7InBjIjpbMjU5LDI2MCwyNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI3NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjM3In0seyJwYyI6WzI2Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjc2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzcifSx7InBjIjpbMjYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozNyJ9LHsicGMiOlsyNjQsMjY1LDI2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjgxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzcifSx7InBjIjpbMjY3LDI2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjg1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzgifSx7InBjIjpbMjY5LDI3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6MzgifSx7InBjIjpbMjcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyODcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czozOCJ9LHsicGMiOlsyNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI4OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjM3In0seyJwYyI6WzI3MywyNzQsMjc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0MSJ9LHsicGMiOlsyNzYsMjc3LDI3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjk0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDEifSx7InBjIjpbMjc5LDI4MCwyODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI5Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQxIn0seyJwYyI6WzI4MiwyODMsMjg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0MSJ9LHsicGMiOlsyODUsMjg2LDI4N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDEifSx7InBjIjpbMjg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMDIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0MSJ9LHsicGMiOlsyODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQxIn0seyJwYyI6WzI5MCwyOTEsMjkyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0MSJ9LHsicGMiOlsyOTMsMjk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0MiJ9LHsicGMiOlsyOTUsMjk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0MiJ9LHsicGMiOlsyOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMxMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQyIn0seyJwYyI6WzI5OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDEifSx7InBjIjpbMjk5LDMwMCwzMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ1In0seyJwYyI6WzMwMiwzMDMsMzA0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0NSJ9LHsicGMiOlszMDUsMzA2LDMwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzIzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDUifSx7InBjIjpbMzA4LDMwOSwzMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ1In0seyJwYyI6WzMxMSwzMTIsMzEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0NSJ9LHsicGMiOlszMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ1In0seyJwYyI6WzMxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzI5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDUifSx7InBjIjpbMzE2LDMxNywzMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ1In0seyJwYyI6WzMxOSwzMjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ2In0seyJwYyI6WzMyMSwzMjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ2In0seyJwYyI6WzMyM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDYifSx7InBjIjpbMzI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0NSJ9LHsicGMiOlszMjUsMzI2LDMyN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQ1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDkifSx7InBjIjpbMzI4LDMyOSwzMzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ5In0seyJwYyI6WzMzMSwzMzIsMzMzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0OSJ9LHsicGMiOlszMzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ5In0seyJwYyI6WzMzNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NDkifSx7InBjIjpbMzM2LDMzNywzMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQ5In0seyJwYyI6WzMzOSwzNDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjUwIn0seyJwYyI6WzM0MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NTAifSx7InBjIjpbMzQyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0OSJ9LHsicGMiOlszNDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQifSx7InBjIjpbMzQ0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM0NSwzNDYsMzQ3LDM0OCwzNDksMzUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM1MSwzNTIsMzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM1NCwzNTUsMzU2LDM1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzcwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYmluYXJ5LmFsZ28udHM6NCJ9LHsicGMiOlszNThdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjozNzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM1OSwzNjAsMzYxLDM2MiwzNjMsMzY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM2NSwzNjYsMzY3LDM2OCwzNjksMzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM3MSwzNzIsMzczLDM3NCwzNzUsMzc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM3NywzNzgsMzc5LDM4MCwzODEsMzgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM4MywzODQsMzg1LDM4NiwzODcsMzg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM4OSwzOTAsMzkxLDM5MiwzOTMsMzk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzM5NSwzOTYsMzk3LDM5OCwzOTksNDAwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzQwMSw0MDIsNDAzLDQwNCw0MDUsNDA2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzQwNyw0MDgsNDA5LDQxMCw0MTEsNDEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzQxMyw0MTQsNDE1LDQxNiw0MTcsNDE4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzQxOSw0MjAsNDIxLDQyMiw0MjMsNDI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzQyNSw0MjYsNDI3LDQyOCw0MjksNDMwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzQzMSw0MzIsNDMzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozODgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9iaW5hcnkuYWxnby50czo0In0seyJwYyI6WzQzNCw0MzUsNDM2LDQzNyw0MzgsNDM5LDQ0MCw0NDEsNDQyLDQ0Myw0NDQsNDQ1LDQ0Niw0NDcsNDQ4LDQ0OSw0NTAsNDUxLDQ1Miw0NTMsNDU0LDQ1NSw0NTYsNDU3LDQ1OCw0NTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM4OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQifSx7InBjIjpbNDYwXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjM5Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2JpbmFyeS5hbGdvLnRzOjQifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4Q2dvdkx5QlVhR2x6SUZSRlFVd2dkMkZ6SUdkbGJtVnlZWFJsWkNCaWVTQlVSVUZNVTJOeWFYQjBJSFl3TGpFd055NHlDaTh2SUdoMGRIQnpPaTh2WjJsMGFIVmlMbU52YlM5aGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dlZFVkJURk5qY21sd2RBb0tMeThnVkdocGN5QmpiMjUwY21GamRDQnBjeUJqYjIxd2JHbGhiblFnZDJsMGFDQmhibVF2YjNJZ2FXMXdiR1Z0Wlc1MGN5QjBhR1VnWm05c2JHOTNhVzVuSUVGU1EzTTZJRnNnUVZKRE5DQmRDZ292THlCVWFHVWdabTlzYkc5M2FXNW5JSFJsYmlCc2FXNWxjeUJ2WmlCVVJVRk1JR2hoYm1Sc1pTQnBibWwwYVdGc0lIQnliMmR5WVcwZ1pteHZkd292THlCVWFHbHpJSEJoZEhSbGNtNGdhWE1nZFhObFpDQjBieUJ0WVd0bElHbDBJR1ZoYzNrZ1ptOXlJR0Z1ZVc5dVpTQjBieUJ3WVhKelpTQjBhR1VnYzNSaGNuUWdiMllnZEdobElIQnliMmR5WVcwZ1lXNWtJR1JsZEdWeWJXbHVaU0JwWmlCaElITndaV05wWm1saklHRmpkR2x2YmlCcGN5QmhiR3h2ZDJWa0NpOHZJRWhsY21Vc0lHRmpkR2x2YmlCeVpXWmxjbk1nZEc4Z2RHaGxJRTl1UTI5dGNHeGxkR1VnYVc0Z1kyOXRZbWx1WVhScGIyNGdkMmwwYUNCM2FHVjBhR1Z5SUhSb1pTQmhjSEFnYVhNZ1ltVnBibWNnWTNKbFlYUmxaQ0J2Y2lCallXeHNaV1FLTHk4Z1JYWmxjbmtnY0c5emMybGliR1VnWVdOMGFXOXVJR1p2Y2lCMGFHbHpJR052Ym5SeVlXTjBJR2x6SUhKbGNISmxjMlZ1ZEdWa0lHbHVJSFJvWlNCemQybDBZMmdnYzNSaGRHVnRaVzUwQ2k4dklFbG1JSFJvWlNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9aU0JqYjI1MGNtRmpkQ3dnYVhSeklISmxjM0JsWTNScGRtVWdZbkpoYm1Ob0lIZHBiR3dnWW1VZ0lpcE9UMVJmU1UxUVRFVk5SVTVVUlVRaUlIZG9hV05vSUdwMWMzUWdZMjl1ZEdGcGJuTWdJbVZ5Y2lJS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lRcHdkWE5vYVc1MElEWUtLZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaXNLYzNkcGRHTm9JQ3BqWVd4c1gwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcGpjbVZoZEdWZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRS0NpcE9UMVJmU1UxUVRFVk5SVTVVUlVRNkNna3ZMeUJVYUdVZ2NtVnhkV1Z6ZEdWa0lHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hwY3lCamIyNTBjbUZqZEM0Z1FYSmxJSGx2ZFNCMWMybHVaeUIwYUdVZ1kyOXljbVZqZENCUGJrTnZiWEJzWlhSbFB5QkVhV1FnZVc5MUlITmxkQ0I1YjNWeUlHRndjQ0JKUkQ4S0NXVnljZ29LTHk4Z1lXNWtLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJGdVpEb0tDUzh2SUdJNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29KWW5SdmFRb0tDUzh2SUdFNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9KWW5SdmFRb0tDUzh2SUdWNFpXTjFkR1VnWVc1a0tIVnBiblEyTkN4MWFXNTBOalFwZG05cFpBb0pZMkZzYkhOMVlpQmhibVFLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR0Z1WkNoaE9pQjFhVzUwTmpRc0lHSTZJSFZwYm5RMk5DazZJSFp2YVdRS1lXNWtPZ29KY0hKdmRHOGdNaUF3Q2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwySnBibUZ5ZVM1aGJHZHZMblJ6T2pZS0NTOHZJR0Z6YzJWeWRDaGhJQ1ltSUdJcENnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1lUb2dkV2x1ZERZMENnbGtkWEFLQ1dKNklDcHphMmx3WDJGdVpEQUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QmlPaUIxYVc1ME5qUUtDU1ltQ2dvcWMydHBjRjloYm1Rd09nb0pZWE56WlhKMENnbHlaWFJ6ZFdJS0NpOHZJRzl5S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkFvcVlXSnBYM0p2ZFhSbFgyOXlPZ29KTHk4Z1lqb2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2dsaWRHOXBDZ29KTHk4Z1lUb2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsaWRHOXBDZ29KTHk4Z1pYaGxZM1YwWlNCdmNpaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUUtDV05oYkd4emRXSWdiM0lLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJRzl5S0dFNklIVnBiblEyTkN3Z1lqb2dkV2x1ZERZMEtUb2dkbTlwWkFwdmNqb0tDWEJ5YjNSdklESWdNQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aWFXNWhjbmt1WVd4bmJ5NTBjem94TUFvSkx5OGdZWE56WlhKMEtHRWdmSHdnWWlrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaE9pQjFhVzUwTmpRS0NXUjFjQW9KWW01NklDcHphMmx3WDI5eU1Bb0pabkpoYldWZlpHbG5JQzB5SUM4dklHSTZJSFZwYm5RMk5Bb0pmSHdLQ2lwemEybHdYMjl5TURvS0NXRnpjMlZ5ZEFvSmNtVjBjM1ZpQ2dvdkx5QmxjWFZoYkNoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRS0ttRmlhVjl5YjNWMFpWOWxjWFZoYkRvS0NTOHZJR0k2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb0pZblJ2YVFvS0NTOHZJR0U2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0pZblJ2YVFvS0NTOHZJR1Y0WldOMWRHVWdaWEYxWVd3b2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0NnbGpZV3hzYzNWaUlHVnhkV0ZzQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJsY1hWaGJDaGhPaUIxYVc1ME5qUXNJR0k2SUhWcGJuUTJOQ2s2SUhadmFXUUtaWEYxWVd3NkNnbHdjbTkwYnlBeUlEQUtDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WW1sdVlYSjVMbUZzWjI4dWRITTZNVFFLQ1M4dklHRnpjMlZ5ZENoaElEMDlQU0JpS1FvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUdFNklIVnBiblEyTkFvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdJNklIVnBiblEyTkFvSlBUMEtDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3ZMeUJ1YjNSRmNYVmhiQ2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FLS21GaWFWOXliM1YwWlY5dWIzUkZjWFZoYkRvS0NTOHZJR0k2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb0pZblJ2YVFvS0NTOHZJR0U2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0pZblJ2YVFvS0NTOHZJR1Y0WldOMWRHVWdibTkwUlhGMVlXd29kV2x1ZERZMExIVnBiblEyTkNsMmIybGtDZ2xqWVd4c2MzVmlJRzV2ZEVWeGRXRnNDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QnViM1JGY1hWaGJDaGhPaUIxYVc1ME5qUXNJR0k2SUhWcGJuUTJOQ2s2SUhadmFXUUtibTkwUlhGMVlXdzZDZ2x3Y205MGJ5QXlJREFLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdlltbHVZWEo1TG1Gc1oyOHVkSE02TVRnS0NTOHZJR0Z6YzJWeWRDaGhJQ0U5UFNCaUtRb0pabkpoYldWZlpHbG5JQzB4SUM4dklHRTZJSFZwYm5RMk5Bb0pabkpoYldWZlpHbG5JQzB5SUM4dklHSTZJSFZwYm5RMk5Bb0pJVDBLQ1dGemMyVnlkQW9KY21WMGMzVmlDZ292THlCaWFYUkJibVFvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrQ2lwaFltbGZjbTkxZEdWZlltbDBRVzVrT2dvSkx5OGdZam9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGlkRzlwQ2dvSkx5OGdZVG9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENnbGlkRzlwQ2dvSkx5OGdaWGhsWTNWMFpTQmlhWFJCYm1Rb2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0NnbGpZV3hzYzNWaUlHSnBkRUZ1WkFvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWW1sMFFXNWtLR0U2SUhWcGJuUTJOQ3dnWWpvZ2RXbHVkRFkwS1RvZ2RtOXBaQXBpYVhSQmJtUTZDZ2x3Y205MGJ5QXlJREFLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdlltbHVZWEo1TG1Gc1oyOHVkSE02TWpJS0NTOHZJR0Z6YzJWeWRDaGhJQ1lnWWlrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaE9pQjFhVzUwTmpRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCaU9pQjFhVzUwTmpRS0NTWUtDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3ZMeUJpYVhSUGNpaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUUtLbUZpYVY5eWIzVjBaVjlpYVhSUGNqb0tDUzh2SUdJNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29KWW5SdmFRb0tDUzh2SUdFNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9KWW5SdmFRb0tDUzh2SUdWNFpXTjFkR1VnWW1sMFQzSW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtDZ2xqWVd4c2MzVmlJR0pwZEU5eUNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCaWFYUlBjaWhoT2lCMWFXNTBOalFzSUdJNklIVnBiblEyTkNrNklIWnZhV1FLWW1sMFQzSTZDZ2x3Y205MGJ5QXlJREFLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdlltbHVZWEo1TG1Gc1oyOHVkSE02TWpZS0NTOHZJR0Z6YzJWeWRDaGhJSHdnWWlrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaE9pQjFhVzUwTmpRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCaU9pQjFhVzUwTmpRS0NYd0tDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3ZMeUJpYVhSWWIzSW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWW1sMFdHOXlPZ29KTHk4Z1lqb2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2dsaWRHOXBDZ29KTHk4Z1lUb2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsaWRHOXBDZ29KTHk4Z1pYaGxZM1YwWlNCaWFYUlliM0lvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrQ2dsallXeHNjM1ZpSUdKcGRGaHZjZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdZbWwwV0c5eUtHRTZJSFZwYm5RMk5Dd2dZam9nZFdsdWREWTBLVG9nZG05cFpBcGlhWFJZYjNJNkNnbHdjbTkwYnlBeUlEQUtDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WW1sdVlYSjVMbUZzWjI4dWRITTZNekFLQ1M4dklHRnpjMlZ5ZENoaElGNGdZaWtLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJoT2lCMWFXNTBOalFLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJpT2lCMWFXNTBOalFLQ1Y0S0NXRnpjMlZ5ZEFvSmNtVjBjM1ZpQ2dvdkx5QmpiMjFpYnloMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrQ2lwaFltbGZjbTkxZEdWZlkyOXRZbTg2Q2drdkx5QmpPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0NXSjBiMmtLQ2drdkx5QmlPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0NXSjBiMmtLQ2drdkx5QmhPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHTnZiV0p2S0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FLQ1dOaGJHeHpkV0lnWTI5dFltOEtDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHTnZiV0p2S0dFNklIVnBiblEyTkN3Z1lqb2dkV2x1ZERZMExDQmpPaUIxYVc1ME5qUXBPaUIyYjJsa0NtTnZiV0p2T2dvSmNISnZkRzhnTXlBd0Nnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkpwYm1GeWVTNWhiR2R2TG5Sek9qTTBDZ2t2THlCaGMzTmxjblFvWVNCOGZDQW9ZaUFtSmlCaktTa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhPaUIxYVc1ME5qUUtDV1IxY0FvSlltNTZJQ3B6YTJsd1gyOXlNUW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJR0k2SUhWcGJuUTJOQW9KWkhWd0NnbGllaUFxYzJ0cGNGOWhibVF4Q2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnWXpvZ2RXbHVkRFkwQ2drbUpnb0tLbk5yYVhCZllXNWtNVG9LQ1h4OENnb3FjMnRwY0Y5dmNqRTZDZ2xoYzNObGNuUUtDWEpsZEhOMVlnb0tMeThnWW1sMGQybHpaVmh2Y2s5d0tHSjVkR1ZiWFN4aWVYUmxXMTBwZG05cFpBb3FZV0pwWDNKdmRYUmxYMkpwZEhkcGMyVlliM0pQY0RvS0NTOHZJR0k2SUdKNWRHVmJYUW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb0paWGgwY21GamRDQXlJREFLQ2drdkx5QmhPaUJpZVhSbFcxMEtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z1pYaGxZM1YwWlNCaWFYUjNhWE5sV0c5eVQzQW9ZbmwwWlZ0ZExHSjVkR1ZiWFNsMmIybGtDZ2xqWVd4c2MzVmlJR0pwZEhkcGMyVlliM0pQY0FvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWW1sMGQybHpaVmh2Y2s5d0tHRTZJR0o1ZEdWekxDQmlPaUJpZVhSbGN5azZJSFp2YVdRS1ltbDBkMmx6WlZodmNrOXdPZ29KY0hKdmRHOGdNaUF3Q2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwySnBibUZ5ZVM1aGJHZHZMblJ6T2pNNENna3ZMeUJpYVhSM2FYTmxXRzl5S0dFc0lHSXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZVG9nWW5sMFpYTUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QmlPaUJpZVhSbGN3b0pZbDRLQ1hKbGRITjFZZ29LTHk4Z1ltbDBkMmx6WlVGdVpFOXdLR0o1ZEdWYlhTeGllWFJsVzEwcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJKcGRIZHBjMlZCYm1SUGNEb0tDUzh2SUdJNklHSjVkR1ZiWFFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29KWlhoMGNtRmpkQ0F5SURBS0Nna3ZMeUJoT2lCaWVYUmxXMTBLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV1Y0ZEhKaFkzUWdNaUF3Q2dvSkx5OGdaWGhsWTNWMFpTQmlhWFIzYVhObFFXNWtUM0FvWW5sMFpWdGRMR0o1ZEdWYlhTbDJiMmxrQ2dsallXeHNjM1ZpSUdKcGRIZHBjMlZCYm1SUGNBb0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z1ltbDBkMmx6WlVGdVpFOXdLR0U2SUdKNWRHVnpMQ0JpT2lCaWVYUmxjeWs2SUhadmFXUUtZbWwwZDJselpVRnVaRTl3T2dvSmNISnZkRzhnTWlBd0Nnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkpwYm1GeWVTNWhiR2R2TG5Sek9qUXlDZ2t2THlCaWFYUjNhWE5sUVc1a0tHRXNJR0lwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWVRvZ1lubDBaWE1LQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJpT2lCaWVYUmxjd29KWWlZS0NYSmxkSE4xWWdvS0x5OGdZbWwwZDJselpVOXlUM0FvWW5sMFpWdGRMR0o1ZEdWYlhTbDJiMmxrQ2lwaFltbGZjbTkxZEdWZlltbDBkMmx6WlU5eVQzQTZDZ2t2THlCaU9pQmllWFJsVzEwS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLQ1dWNGRISmhZM1FnTWlBd0Nnb0pMeThnWVRvZ1lubDBaVnRkQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJR1Y0WldOMWRHVWdZbWwwZDJselpVOXlUM0FvWW5sMFpWdGRMR0o1ZEdWYlhTbDJiMmxrQ2dsallXeHNjM1ZpSUdKcGRIZHBjMlZQY2s5d0NnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCaWFYUjNhWE5sVDNKUGNDaGhPaUJpZVhSbGN5d2dZam9nWW5sMFpYTXBPaUIyYjJsa0NtSnBkSGRwYzJWUGNrOXdPZ29KY0hKdmRHOGdNaUF3Q2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwySnBibUZ5ZVM1aGJHZHZMblJ6T2pRMkNna3ZMeUJpYVhSM2FYTmxUM0lvWVN3Z1lpa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhPaUJpZVhSbGN3b0pabkpoYldWZlpHbG5JQzB5SUM4dklHSTZJR0o1ZEdWekNnbGlmQW9KY21WMGMzVmlDZ292THlCaWFYUjNhWE5sVG05MFQzQW9ZbmwwWlZ0ZEtYWnZhV1FLS21GaWFWOXliM1YwWlY5aWFYUjNhWE5sVG05MFQzQTZDZ2t2THlCaE9pQmllWFJsVzEwS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dWNGRISmhZM1FnTWlBd0Nnb0pMeThnWlhobFkzVjBaU0JpYVhSM2FYTmxUbTkwVDNBb1lubDBaVnRkS1hadmFXUUtDV05oYkd4emRXSWdZbWwwZDJselpVNXZkRTl3Q2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJpYVhSM2FYTmxUbTkwVDNBb1lUb2dZbmwwWlhNcE9pQjJiMmxrQ21KcGRIZHBjMlZPYjNSUGNEb0tDWEJ5YjNSdklERWdNQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aWFXNWhjbmt1WVd4bmJ5NTBjem8xTUFvSkx5OGdZbWwwZDJselpVNXZkQ2hoS1FvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUdFNklHSjVkR1Z6Q2dsaWZnb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlRFptWkRFellURXpJQzh2SUcxbGRHaHZaQ0FpWVc1a0tIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZURjd01HRmhPRGczSUM4dklHMWxkR2h2WkNBaWIzSW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNE56SXpZemczWldZZ0x5OGdiV1YwYUc5a0lDSmxjWFZoYkNoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUNnbHdkWE5vWW5sMFpYTWdNSGhsTjJabVlqbGtNeUF2THlCdFpYUm9iMlFnSW01dmRFVnhkV0ZzS0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJS0NYQjFjMmhpZVhSbGN5QXdlRGt5T0RVeE9EaGxJQzh2SUcxbGRHaHZaQ0FpWW1sMFFXNWtLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VEVTVNbVJqTnpObUlDOHZJRzFsZEdodlpDQWlZbWwwVDNJb2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lnb0pjSFZ6YUdKNWRHVnpJREI0Tm1RME5qVXdOR0VnTHk4Z2JXVjBhRzlrSUNKaWFYUlliM0lvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWdvSmNIVnphR0o1ZEdWeklEQjROelJrWXpVeE5UQWdMeThnYldWMGFHOWtJQ0pqYjIxaWJ5aDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lnb0pjSFZ6YUdKNWRHVnpJREI0TkROak1tRTFObVlnTHk4Z2JXVjBhRzlrSUNKaWFYUjNhWE5sV0c5eVQzQW9ZbmwwWlZ0ZExHSjVkR1ZiWFNsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNFl6azNNak5sTldVZ0x5OGdiV1YwYUc5a0lDSmlhWFIzYVhObFFXNWtUM0FvWW5sMFpWdGRMR0o1ZEdWYlhTbDJiMmxrSWdvSmNIVnphR0o1ZEdWeklEQjRabVpqT0RNMU9EVWdMeThnYldWMGFHOWtJQ0ppYVhSM2FYTmxUM0pQY0NoaWVYUmxXMTBzWW5sMFpWdGRLWFp2YVdRaUNnbHdkWE5vWW5sMFpYTWdNSGhpWkRaaVkyVmhOeUF2THlCdFpYUm9iMlFnSW1KcGRIZHBjMlZPYjNSUGNDaGllWFJsVzEwcGRtOXBaQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZZVzVrSUNwaFltbGZjbTkxZEdWZmIzSWdLbUZpYVY5eWIzVjBaVjlsY1hWaGJDQXFZV0pwWDNKdmRYUmxYMjV2ZEVWeGRXRnNJQ3BoWW1sZmNtOTFkR1ZmWW1sMFFXNWtJQ3BoWW1sZmNtOTFkR1ZmWW1sMFQzSWdLbUZpYVY5eWIzVjBaVjlpYVhSWWIzSWdLbUZpYVY5eWIzVjBaVjlqYjIxaWJ5QXFZV0pwWDNKdmRYUmxYMkpwZEhkcGMyVlliM0pQY0NBcVlXSnBYM0p2ZFhSbFgySnBkSGRwYzJWQmJtUlBjQ0FxWVdKcFgzSnZkWFJsWDJKcGRIZHBjMlZQY2s5d0lDcGhZbWxmY205MWRHVmZZbWwwZDJselpVNXZkRTl3Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOaGJHd2dUbTlQY0FvSlpYSnkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBVEVZRklFR0N6RVpDSTBNQVVBQUFBQUFBQUFBQUFBQUFUSUFBQUFBQUFBQUFBQUFBRFlhQWhjMkdnRVhpQUFDSWtPS0FnQ0wvMGxCQUFPTC9oQkVpVFlhQWhjMkdnRVhpQUFDSWtPS0FnQ0wvMGxBQUFPTC9oRkVpVFlhQWhjMkdnRVhpQUFDSWtPS0FnQ0wvNHYrRWtTSk5ob0NGellhQVJlSUFBSWlRNG9DQUl2L2kvNFRSSWsyR2dJWE5ob0JGNGdBQWlKRGlnSUFpLytML2hwRWlUWWFBaGMyR2dFWGlBQUNJa09LQWdDTC80ditHVVNKTmhvQ0Z6WWFBUmVJQUFJaVE0b0NBSXYvaS80YlJJazJHZ01YTmhvQ0Z6WWFBUmVJQUFJaVE0b0RBSXYvU1VBQUNvditTVUVBQTR2OUVCRkVpVFlhQWxjQ0FEWWFBVmNDQUlnQUFpSkRpZ0lBaS8rTC9xMkpOaG9DVndJQU5ob0JWd0lBaUFBQ0lrT0tBZ0NMLzR2K3JJazJHZ0pYQWdBMkdnRlhBZ0NJQUFJaVE0b0NBSXYvaS82cmlUWWFBVmNDQUlnQUFpSkRpZ0VBaS8rdWlTSkRnQVM0UkhzMk5ob0FqZ0gvOFFDQUJHL1JPaE9BQkhBS3FJZUFCSEk4aCsrQUJPZi91ZE9BQkpLRkdJNkFCRmt0eHorQUJHMUdVRXFBQkhUY1VWQ0FCRVBDcFcrQUJNbHlQbDZBQlAvSU5ZV0FCTDFyenFjMkdnQ09EUDVjL25mK2t2NnAvc0QrMS83dS93WC9LLzlGLzEvL2VRQT0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
