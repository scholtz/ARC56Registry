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

namespace Arc56.Generated.algorandecosystem.algokit_core.application_4e04370a
{


    public class TestingAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestingAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<string> CallAbi(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 126, 128, 165 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.SimApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallAbi_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 126, 128, 165 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        /// <param name="value"> </param>
        public async Task<string> CallAbiTxn(PaymentTransaction txn, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 10, 146, 168, 30 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, txn, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallAbiTxn_Transactions(PaymentTransaction txn, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 10, 146, 168, 30 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, txn, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> CallAbiForeignRefs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 117, 96, 44 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallAbiForeignRefs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 117, 96, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="int1"> </param>
        /// <param name="int2"> </param>
        /// <param name="bytes1"> </param>
        /// <param name="bytes2"> </param>
        public async Task SetGlobal(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 207, 141, 234 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            var result = await base.CallApp(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGlobal_Transactions(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 207, 141, 234 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            return await base.MakeTransactionList(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="int1"> </param>
        /// <param name="int2"> </param>
        /// <param name="bytes1"> </param>
        /// <param name="bytes2"> </param>
        public async Task SetLocal(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 194, 131, 74 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            var result = await base.CallApp(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLocal_Transactions(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 194, 131, 74 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            return await base.MakeTransactionList(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="value"> </param>
        public async Task SetBox(byte[] name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 180, 162, 48 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBox_Transactions(byte[] name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 180, 162, 48 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Error(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 208, 218, 13 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Error_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 208, 218, 13 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<string> CreateAbi(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 82, 48, 64 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateAbi_Transactions(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 82, 48, 64 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<string> UpdateAbi(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 165, 206, 183 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateAbi_Transactions(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 165, 206, 183 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<string> DeleteAbi(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 27, 78, 233 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DeleteAbi_Transactions(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 27, 78, 233 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<string> DefaultValue(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 75, 85, 200 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DefaultValue_Transactions(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 75, 85, 200 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<string> DefaultValueFromAbi(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 210, 17, 163 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DefaultValueFromAbi_Transactions(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 210, 17, 163 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<ulong> DefaultValueFromGlobalState(ulong arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 252, 187, 0 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DefaultValueFromGlobalState_Transactions(ulong arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 252, 187, 0 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<string> DefaultValueFromLocalState(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 240, 186, 248 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DefaultValueFromLocalState_Transactions(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 240, 186, 248 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbXSwibmFtZSI6IlRlc3RpbmdBcHAiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY2FsbF9hYmkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNhbGxfYWJpX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjYWxsX2FiaV9mb3JlaWduX3JlZnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InNldF9nbG9iYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoic2V0X2xvY2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludDEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ5dGVzMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ5dGVzMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InNldF9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZXJyb3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJ1cGRhdGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZGVsZXRlX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnB1dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJkZWZhdWx0X3ZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ193aXRoX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJaR1ZtWVhWc2RDQjJZV3gxWlE9PSIsInR5cGUiOiJBVk1TdHJpbmcifX1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZGVmYXVsdF92YWx1ZV9mcm9tX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6Im1ldGhvZCIsImRhdGEiOiJkZWZhdWx0X3ZhbHVlIiwidHlwZSI6bnVsbH19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9nbG9iYWxfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJnbG9iYWwiLCJkYXRhIjoiYVc1ME1RPT0iLCJ0eXBlIjoidWludDY0In19XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9sb2NhbF9zdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxvY2FsIiwiZGF0YSI6ImJHOWpZV3hmWW5sMFpYTXgiLCJ0eXBlIjoiQVZNU3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjIsImJ5dGVzIjoyfX0sImtleXMiOnsiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiLCJPcHRJbiJdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIiwiVXBkYXRlQXBwbGljYXRpb24iXX0sInNvdXJjZUluZm8iOm51bGwsInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURnS2FXNTBZMkpzYjJOcklEQWdNU0F4TUNBMUlGUk5VRXhmVlZCRVFWUkJRa3hGSUZSTlVFeGZSRVZNUlZSQlFreEZDbUo1ZEdWallteHZZMnNnTUhnZ01IZ3hOVEZtTjJNM05RcDBlRzRnVG5WdFFYQndRWEpuY3dwcGJuUmpYekFnTHk4Z01BbzlQUXBpYm5vZ2JXRnBibDlzTXpJS2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQXB3ZFhOb1lubDBaWE1nTUhobU1UZGxPREJoTlNBdkx5QWlZMkZzYkY5aFlta29jM1J5YVc1bktYTjBjbWx1WnlJS1BUMEtZbTU2SUcxaGFXNWZiRE14Q25SNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtjSFZ6YUdKNWRHVnpJREI0TUdFNU1tRTRNV1VnTHk4Z0ltTmhiR3hmWVdKcFgzUjRiaWh3WVhrc2MzUnlhVzVuS1hOMGNtbHVaeUlLUFQwS1ltNTZJRzFoYVc1ZmJETXdDblI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS2NIVnphR0o1ZEdWeklEQjRZV1EzTlRZd01tTWdMeThnSW1OaGJHeGZZV0pwWDJadmNtVnBaMjVmY21WbWN5Z3BjM1J5YVc1bklnbzlQUXBpYm5vZ2JXRnBibDlzTWprS2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQXB3ZFhOb1lubDBaWE1nTUhoaE5HTm1PR1JsWVNBdkx5QWljMlYwWDJkc2IySmhiQ2gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1Wnl4aWVYUmxXelJkS1hadmFXUWlDajA5Q21KdWVpQnRZV2x1WDJ3eU9BcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q25CMWMyaGllWFJsY3lBd2VHTmxZekk0TXpSaElDOHZJQ0p6WlhSZmJHOWpZV3dvZFdsdWREWTBMSFZwYm5RMk5DeHpkSEpwYm1jc1lubDBaVnMwWFNsMmIybGtJZ285UFFwaWJub2diV0ZwYmw5c01qY0tkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFwd2RYTm9ZbmwwWlhNZ01IaGhOR0kwWVRJek1DQXZMeUFpYzJWMFgySnZlQ2hpZVhSbFd6UmRMSE4wY21sdVp5bDJiMmxrSWdvOVBRcGlibm9nYldGcGJsOXNNallLZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01BcHdkWE5vWW5sMFpYTWdNSGcwTkdRd1pHRXdaQ0F2THlBaVpYSnliM0lvS1hadmFXUWlDajA5Q21KdWVpQnRZV2x1WDJ3eU5RcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q25CMWMyaGllWFJsY3lBd2VEbGtOVEl6TURRd0lDOHZJQ0pqY21WaGRHVmZZV0pwS0hOMGNtbHVaeWx6ZEhKcGJtY2lDajA5Q21KdWVpQnRZV2x1WDJ3eU5BcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q25CMWMyaGllWFJsY3lBd2VETmpZVFZqWldJM0lDOHZJQ0oxY0dSaGRHVmZZV0pwS0hOMGNtbHVaeWx6ZEhKcGJtY2lDajA5Q21KdWVpQnRZV2x1WDJ3eU13cDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q25CMWMyaGllWFJsY3lBd2VESTNNV0kwWldVNUlDOHZJQ0prWld4bGRHVmZZV0pwS0hOMGNtbHVaeWx6ZEhKcGJtY2lDajA5Q21KdWVpQnRZV2x1WDJ3eU1ncDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q25CMWMyaGllWFJsY3lBd2VETXdZelprTlRoaElDOHZJQ0p2Y0hSZmFXNG9LWFp2YVdRaUNqMDlDbUp1ZWlCdFlXbHVYMnd5TVFwMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDbkIxYzJoaWVYUmxjeUF3ZURVM05HSTFOV000SUM4dklDSmtaV1poZFd4MFgzWmhiSFZsS0hOMGNtbHVaeWx6ZEhKcGJtY2lDajA5Q21KdWVpQnRZV2x1WDJ3eU1BcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q25CMWMyaGllWFJsY3lBd2VEUTJaREl4TVdFeklDOHZJQ0prWldaaGRXeDBYM1poYkhWbFgyWnliMjFmWVdKcEtITjBjbWx1WnlsemRISnBibWNpQ2owOUNtSnVlaUJ0WVdsdVgyd3hPUXAwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NuQjFjMmhpZVhSbGN5QXdlREJqWm1OaVlqQXdJQzh2SUNKa1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZloyeHZZbUZzWDNOMFlYUmxLSFZwYm5RMk5DbDFhVzUwTmpRaUNqMDlDbUp1ZWlCdFlXbHVYMnd4T0FwMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDbkIxYzJoaWVYUmxjeUF3ZUdRd1pqQmlZV1k0SUM4dklDSmtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZiRzlqWVd4ZmMzUmhkR1VvYzNSeWFXNW5LWE4wY21sdVp5SUtQVDBLWW01NklHMWhhVzVmYkRFM0NtVnljZ3B0WVdsdVgyd3hOem9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ3BwYm5Salh6QWdMeThnVG05UGNBbzlQUXAwZUc0Z1FYQndiR2xqWVhScGIyNUpSQXBwYm5Salh6QWdMeThnTUFvaFBRb21KZ3BoYzNObGNuUUtZMkZzYkhOMVlpQmtaV1poZFd4MGRtRnNkV1ZtY205dGJHOWpZV3h6ZEdGMFpXTmhjM1JsY2w4ek13cHBiblJqWHpFZ0x5OGdNUXB5WlhSMWNtNEtiV0ZwYmw5c01UZzZDblI0YmlCUGJrTnZiWEJzWlhScGIyNEthVzUwWTE4d0lDOHZJRTV2VDNBS1BUMEtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUthVzUwWTE4d0lDOHZJREFLSVQwS0ppWUtZWE56WlhKMENtTmhiR3h6ZFdJZ1pHVm1ZWFZzZEhaaGJIVmxabkp2Yldkc2IySmhiSE4wWVhSbFkyRnpkR1Z5WHpNeUNtbHVkR05mTVNBdkx5QXhDbkpsZEhWeWJncHRZV2x1WDJ3eE9Ub0tkSGh1SUU5dVEyOXRjR3hsZEdsdmJncHBiblJqWHpBZ0x5OGdUbTlQY0FvOVBRcDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBcHBiblJqWHpBZ0x5OGdNQW9oUFFvbUpncGhjM05sY25RS1kyRnNiSE4xWWlCa1pXWmhkV3gwZG1Gc2RXVm1jbTl0WVdKcFkyRnpkR1Z5WHpNeENtbHVkR05mTVNBdkx5QXhDbkpsZEhWeWJncHRZV2x1WDJ3eU1Eb0tkSGh1SUU5dVEyOXRjR3hsZEdsdmJncHBiblJqWHpBZ0x5OGdUbTlQY0FvOVBRcDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBcHBiblJqWHpBZ0x5OGdNQW9oUFFvbUpncGhjM05sY25RS1kyRnNiSE4xWWlCa1pXWmhkV3gwZG1Gc2RXVmpZWE4wWlhKZk16QUthVzUwWTE4eElDOHZJREVLY21WMGRYSnVDbTFoYVc1ZmJESXhPZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDbWx1ZEdOZk1TQXZMeUJQY0hSSmJnbzlQUXAwZUc0Z1FYQndiR2xqWVhScGIyNUpSQXBwYm5Salh6QWdMeThnTUFvaFBRb21KZ3BoYzNObGNuUUtZMkZzYkhOMVlpQnZjSFJwYm1OaGMzUmxjbDh5T1FwcGJuUmpYekVnTHk4Z01RcHlaWFIxY200S2JXRnBibDlzTWpJNkNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S2FXNTBZMTh6SUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNqMDlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDbWx1ZEdOZk1DQXZMeUF3Q2lFOUNpWW1DbUZ6YzJWeWRBcGpZV3hzYzNWaUlHUmxiR1YwWldGaWFXTmhjM1JsY2w4eU9BcHBiblJqWHpFZ0x5OGdNUXB5WlhSMWNtNEtiV0ZwYmw5c01qTTZDblI0YmlCUGJrTnZiWEJzWlhScGIyNEtjSFZ6YUdsdWRDQTBJQzh2SUZWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1Q2owOUNuUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNtbHVkR05mTUNBdkx5QXdDaUU5Q2lZbUNtRnpjMlZ5ZEFwallXeHNjM1ZpSUhWd1pHRjBaV0ZpYVdOaGMzUmxjbDh5TndwcGJuUmpYekVnTHk4Z01RcHlaWFIxY200S2JXRnBibDlzTWpRNkNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S2FXNTBZMTh3SUM4dklFNXZUM0FLUFQwS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS2FXNTBZMTh3SUM4dklEQUtQVDBLSmlZS1lYTnpaWEowQ21OaGJHeHpkV0lnWTNKbFlYUmxZV0pwWTJGemRHVnlYekkyQ21sdWRHTmZNU0F2THlBeENuSmxkSFZ5YmdwdFlXbHVYMnd5TlRvS2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdwcGJuUmpYekFnTHk4Z1RtOVBjQW85UFFwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFwcGJuUmpYekFnTHk4Z01Bb2hQUW9tSmdwaGMzTmxjblFLWTJGc2JITjFZaUJsY25KdmNtTmhjM1JsY2w4eU5RcHBiblJqWHpFZ0x5OGdNUXB5WlhSMWNtNEtiV0ZwYmw5c01qWTZDblI0YmlCUGJrTnZiWEJzWlhScGIyNEthVzUwWTE4d0lDOHZJRTV2VDNBS1BUMEtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUthVzUwWTE4d0lDOHZJREFLSVQwS0ppWUtZWE56WlhKMENtTmhiR3h6ZFdJZ2MyVjBZbTk0WTJGemRHVnlYekkwQ21sdWRHTmZNU0F2THlBeENuSmxkSFZ5YmdwdFlXbHVYMnd5TnpvS2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdwcGJuUmpYekFnTHk4Z1RtOVBjQW85UFFwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFwcGJuUmpYekFnTHk4Z01Bb2hQUW9tSmdwaGMzTmxjblFLWTJGc2JITjFZaUJ6WlhSc2IyTmhiR05oYzNSbGNsOHlNd3BwYm5Salh6RWdMeThnTVFweVpYUjFjbTRLYldGcGJsOXNNamc2Q25SNGJpQlBia052YlhCc1pYUnBiMjRLYVc1MFkxOHdJQzh2SUU1dlQzQUtQVDBLZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLYVc1MFkxOHdJQzh2SURBS0lUMEtKaVlLWVhOelpYSjBDbU5oYkd4emRXSWdjMlYwWjJ4dlltRnNZMkZ6ZEdWeVh6SXlDbWx1ZEdOZk1TQXZMeUF4Q25KbGRIVnliZ3B0WVdsdVgyd3lPVG9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ3BwYm5Salh6QWdMeThnVG05UGNBbzlQUXAwZUc0Z1FYQndiR2xqWVhScGIyNUpSQXBwYm5Salh6QWdMeThnTUFvaFBRb21KZ3BoYzNObGNuUUtZMkZzYkhOMVlpQmpZV3hzWVdKcFptOXlaV2xuYm5KbFpuTmpZWE4wWlhKZk1qRUthVzUwWTE4eElDOHZJREVLY21WMGRYSnVDbTFoYVc1ZmJETXdPZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDbWx1ZEdOZk1DQXZMeUJPYjA5d0NqMDlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDbWx1ZEdOZk1DQXZMeUF3Q2lFOUNpWW1DbUZ6YzJWeWRBcGpZV3hzYzNWaUlHTmhiR3hoWW1sMGVHNWpZWE4wWlhKZk1qQUthVzUwWTE4eElDOHZJREVLY21WMGRYSnVDbTFoYVc1ZmJETXhPZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDbWx1ZEdOZk1DQXZMeUJPYjA5d0NqMDlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDbWx1ZEdOZk1DQXZMeUF3Q2lFOUNpWW1DbUZ6YzJWeWRBcGpZV3hzYzNWaUlHTmhiR3hoWW1sallYTjBaWEpmTVRrS2FXNTBZMTh4SUM4dklERUtjbVYwZFhKdUNtMWhhVzVmYkRNeU9ncDBlRzRnVDI1RGIyMXdiR1YwYVc5dUNtbHVkR05mTUNBdkx5Qk9iMDl3Q2owOUNtSnVlaUJ0WVdsdVgydzBNQXAwZUc0Z1QyNURiMjF3YkdWMGFXOXVDbWx1ZEdOZk1TQXZMeUJQY0hSSmJnbzlQUXBpYm5vZ2JXRnBibDlzTXprS2RIaHVJRTl1UTI5dGNHeGxkR2x2Ymdwd2RYTm9hVzUwSURRZ0x5OGdWWEJrWVhSbFFYQndiR2xqWVhScGIyNEtQVDBLWW01NklHMWhhVzVmYkRNNENuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S2FXNTBZMTh6SUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNqMDlDbUp1ZWlCdFlXbHVYMnd6TndwbGNuSUtiV0ZwYmw5c016YzZDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDbWx1ZEdOZk1DQXZMeUF3Q2lFOUNtRnpjMlZ5ZEFwallXeHNjM1ZpSUdSbGJHVjBaVjh4TWdwcGJuUmpYekVnTHk4Z01RcHlaWFIxY200S2JXRnBibDlzTXpnNkNuUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNtbHVkR05mTUNBdkx5QXdDaUU5Q21GemMyVnlkQXBqWVd4c2MzVmlJSFZ3WkdGMFpWOHhNQXBwYm5Salh6RWdMeThnTVFweVpYUjFjbTRLYldGcGJsOXNNems2Q25SNGJpQkJjSEJzYVdOaGRHbHZia2xFQ21sdWRHTmZNQ0F2THlBd0NqMDlDbUZ6YzJWeWRBcGpZV3hzYzNWaUlHTnlaV0YwWlY4NENtbHVkR05mTVNBdkx5QXhDbkpsZEhWeWJncHRZV2x1WDJ3ME1Eb0tkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUthVzUwWTE4d0lDOHZJREFLUFQwS1lYTnpaWEowQ21OaGJHeHpkV0lnWTNKbFlYUmxYemdLYVc1MFkxOHhJQzh2SURFS2NtVjBkWEp1Q2dvdkx5QmpZV3hzWDJGaWFRcGpZV3hzWVdKcFh6QTZDbkJ5YjNSdklERWdNUXBpZVhSbFkxOHdJQzh2SUNJaUNuQjFjMmhpZVhSbGN5QXdlRFE0TmpVMll6WmpObVl5WXpJd0lDOHZJQ0pJWld4c2J5d2dJZ3BtY21GdFpWOWthV2NnTFRFS1pYaDBjbUZqZENBeUlEQUtZMjl1WTJGMENtWnlZVzFsWDJKMWNua2dNQXBtY21GdFpWOWthV2NnTUFwc1pXNEthWFJ2WWdwbGVIUnlZV04wSURZZ01BcG1jbUZ0WlY5a2FXY2dNQXBqYjI1allYUUtabkpoYldWZlluVnllU0F3Q25KbGRITjFZZ29LTHk4Z2FYUnZZUXBwZEc5aFh6RTZDbkJ5YjNSdklERWdNUXBtY21GdFpWOWthV2NnTFRFS2FXNTBZMTh3SUM4dklEQUtQVDBLWW01NklHbDBiMkZmTVY5c05RcG1jbUZ0WlY5a2FXY2dMVEVLYVc1MFkxOHlJQzh2SURFd0NpOEthVzUwWTE4d0lDOHZJREFLUGdwaWJub2dhWFJ2WVY4eFgydzBDbUo1ZEdWalh6QWdMeThnSWlJS2FYUnZZVjh4WDJ3ek9ncHdkWE5vWW5sMFpYTWdNSGd6TURNeE16SXpNek0wTXpVek5qTTNNemd6T1NBdkx5QWlNREV5TXpRMU5qYzRPU0lLWm5KaGJXVmZaR2xuSUMweENtbHVkR05mTWlBdkx5QXhNQW9sQ21sdWRHTmZNU0F2THlBeENtVjRkSEpoWTNRekNtTnZibU5oZEFwaUlHbDBiMkZmTVY5c05ncHBkRzloWHpGZmJEUTZDbVp5WVcxbFgyUnBaeUF0TVFwcGJuUmpYeklnTHk4Z01UQUtMd3BqWVd4c2MzVmlJR2wwYjJGZk1RcGlJR2wwYjJGZk1WOXNNd3BwZEc5aFh6RmZiRFU2Q25CMWMyaGllWFJsY3lBd2VETXdJQzh2SUNJd0lncHBkRzloWHpGZmJEWTZDbkpsZEhOMVlnb0tMeThnWTJGc2JGOWhZbWxmZEhodUNtTmhiR3hoWW1sMGVHNWZNam9LY0hKdmRHOGdNaUF4Q21KNWRHVmpYekFnTHk4Z0lpSUtjSFZ6YUdKNWRHVnpJREI0TlRNMk5UWmxOelF5TUNBdkx5QWlVMlZ1ZENBaUNtWnlZVzFsWDJScFp5QXRNZ3BuZEhodWN5QkJiVzkxYm5RS1kyRnNiSE4xWWlCcGRHOWhYekVLWTI5dVkyRjBDbkIxYzJoaWVYUmxjeUF3ZURKbE1qQWdMeThnSWk0Z0lncGpiMjVqWVhRS1puSmhiV1ZmWkdsbklDMHhDbVY0ZEhKaFkzUWdNaUF3Q21OdmJtTmhkQXBtY21GdFpWOWlkWEo1SURBS1puSmhiV1ZmWkdsbklEQUtiR1Z1Q21sMGIySUtaWGgwY21GamRDQTJJREFLWm5KaGJXVmZaR2xuSURBS1kyOXVZMkYwQ21aeVlXMWxYMkoxY25rZ01BcHlaWFJ6ZFdJS0NpOHZJR05oYkd4ZllXSnBYMlp2Y21WcFoyNWZjbVZtY3dwallXeHNZV0pwWm05eVpXbG5ibkpsWm5OZk16b0tjSEp2ZEc4Z01DQXhDbUo1ZEdWalh6QWdMeThnSWlJS2NIVnphR0o1ZEdWeklEQjROREUzTURjd00yRXlNQ0F2THlBaVFYQndPaUFpQ25SNGJtRWdRWEJ3YkdsallYUnBiMjV6SURFS1kyRnNiSE4xWWlCcGRHOWhYekVLWTI5dVkyRjBDbkIxYzJoaWVYUmxjeUF3ZURKak1qQTBNVGN6TnpNMk5UYzBNMkV5TUNBdkx5QWlMQ0JCYzNObGREb2dJZ3BqYjI1allYUUtkSGh1WVNCQmMzTmxkSE1nTUFwallXeHNjM1ZpSUdsMGIyRmZNUXBqYjI1allYUUtjSFZ6YUdKNWRHVnpJREI0TW1NeU1EUXhOak0yTXpabU56VTJaVGMwTTJFeU1DQXZMeUFpTENCQlkyTnZkVzUwT2lBaUNtTnZibU5oZEFwMGVHNWhJRUZqWTI5MWJuUnpJREFLYVc1MFkxOHdJQzh2SURBS1oyVjBZbmwwWlFwallXeHNjM1ZpSUdsMGIyRmZNUXBqYjI1allYUUtjSFZ6YUdKNWRHVnpJREI0TTJFZ0x5OGdJam9pQ21OdmJtTmhkQXAwZUc1aElFRmpZMjkxYm5SeklEQUthVzUwWTE4eElDOHZJREVLWjJWMFlubDBaUXBqWVd4c2MzVmlJR2wwYjJGZk1RcGpiMjVqWVhRS1puSmhiV1ZmWW5WeWVTQXdDbVp5WVcxbFgyUnBaeUF3Q214bGJncHBkRzlpQ21WNGRISmhZM1FnTmlBd0NtWnlZVzFsWDJScFp5QXdDbU52Ym1OaGRBcG1jbUZ0WlY5aWRYSjVJREFLY21WMGMzVmlDZ292THlCelpYUmZaMnh2WW1Gc0NuTmxkR2RzYjJKaGJGODBPZ3B3Y205MGJ5QTBJREFLY0hWemFHSjVkR1Z6SURCNE5qazJaVGMwTXpFZ0x5OGdJbWx1ZERFaUNtWnlZVzFsWDJScFp5QXROQXBoY0hCZloyeHZZbUZzWDNCMWRBcHdkWE5vWW5sMFpYTWdNSGcyT1RabE56UXpNaUF2THlBaWFXNTBNaUlLWm5KaGJXVmZaR2xuSUMwekNtRndjRjluYkc5aVlXeGZjSFYwQ25CMWMyaGllWFJsY3lBd2VEWXlOemszTkRZMU56TXpNU0F2THlBaVlubDBaWE14SWdwbWNtRnRaVjlrYVdjZ0xUSUtaWGgwY21GamRDQXlJREFLWVhCd1gyZHNiMkpoYkY5d2RYUUtjSFZ6YUdKNWRHVnpJREI0TmpJM09UYzBOalUzTXpNeUlDOHZJQ0ppZVhSbGN6SWlDbVp5WVcxbFgyUnBaeUF0TVFwaGNIQmZaMnh2WW1Gc1gzQjFkQXB5WlhSemRXSUtDaTh2SUhObGRGOXNiMk5oYkFwelpYUnNiMk5oYkY4MU9ncHdjbTkwYnlBMElEQUtkSGh1SUZObGJtUmxjZ3B3ZFhOb1lubDBaWE1nTUhnMll6Wm1Oak0yTVRaak5XWTJPVFpsTnpRek1TQXZMeUFpYkc5allXeGZhVzUwTVNJS1puSmhiV1ZmWkdsbklDMDBDbUZ3Y0Y5c2IyTmhiRjl3ZFhRS2RIaHVJRk5sYm1SbGNncHdkWE5vWW5sMFpYTWdNSGcyWXpabU5qTTJNVFpqTldZMk9UWmxOelF6TWlBdkx5QWliRzlqWVd4ZmFXNTBNaUlLWm5KaGJXVmZaR2xuSUMwekNtRndjRjlzYjJOaGJGOXdkWFFLZEhodUlGTmxibVJsY2dwd2RYTm9ZbmwwWlhNZ01IZzJZelptTmpNMk1UWmpOV1kyTWpjNU56UTJOVGN6TXpFZ0x5OGdJbXh2WTJGc1gySjVkR1Z6TVNJS1puSmhiV1ZmWkdsbklDMHlDbVY0ZEhKaFkzUWdNaUF3Q21Gd2NGOXNiMk5oYkY5d2RYUUtkSGh1SUZObGJtUmxjZ3B3ZFhOb1lubDBaWE1nTUhnMll6Wm1Oak0yTVRaak5XWTJNamM1TnpRMk5UY3pNeklnTHk4Z0lteHZZMkZzWDJKNWRHVnpNaUlLWm5KaGJXVmZaR2xuSUMweENtRndjRjlzYjJOaGJGOXdkWFFLY21WMGMzVmlDZ292THlCelpYUmZZbTk0Q25ObGRHSnZlRjgyT2dwd2NtOTBieUF5SURBS1puSmhiV1ZmWkdsbklDMHlDbUp2ZUY5a1pXd0tjRzl3Q21aeVlXMWxYMlJwWnlBdE1ncG1jbUZ0WlY5a2FXY2dMVEVLWlhoMGNtRmpkQ0F5SURBS1ltOTRYM0IxZEFweVpYUnpkV0lLQ2k4dklHVnljbTl5Q21WeWNtOXlYemM2Q25CeWIzUnZJREFnTUFwcGJuUmpYekFnTHk4Z01Bb3ZMeUJFWld4cFltVnlZWFJsSUdWeWNtOXlDbUZ6YzJWeWRBcHlaWFJ6ZFdJS0NpOHZJR055WldGMFpRcGpjbVZoZEdWZk9Eb0tjSEp2ZEc4Z01DQXdDblI0YmlCVFpXNWtaWElLWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNqMDlDaTh2SUhWdVlYVjBhRzl5YVhwbFpBcGhjM05sY25RS2NIVnphR0o1ZEdWeklEQjROelkyTVRaak56VTJOU0F2THlBaWRtRnNkV1VpQ25CMWMyaHBiblFnVkUxUVRGOVdRVXhWUlNBdkx5QlVUVkJNWDFaQlRGVkZDbUZ3Y0Y5bmJHOWlZV3hmY0hWMENuSmxkSE4xWWdvS0x5OGdZM0psWVhSbFgyRmlhUXBqY21WaGRHVmhZbWxmT1RvS2NISnZkRzhnTVNBeENtSjVkR1ZqWHpBZ0x5OGdJaUlLZEhodUlGTmxibVJsY2dwbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtQVDBLTHk4Z2RXNWhkWFJvYjNKcGVtVmtDbUZ6YzJWeWRBcG1jbUZ0WlY5a2FXY2dMVEVLWlhoMGNtRmpkQ0F5SURBS1puSmhiV1ZmWW5WeWVTQXdDbVp5WVcxbFgyUnBaeUF3Q214bGJncHBkRzlpQ21WNGRISmhZM1FnTmlBd0NtWnlZVzFsWDJScFp5QXdDbU52Ym1OaGRBcG1jbUZ0WlY5aWRYSjVJREFLY21WMGMzVmlDZ292THlCMWNHUmhkR1VLZFhCa1lYUmxYekV3T2dwd2NtOTBieUF3SURBS2RIaHVJRk5sYm1SbGNncG5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LUFQwS0x5OGdkVzVoZFhSb2IzSnBlbVZrQ21GemMyVnlkQXBwYm5SaklEUWdMeThnVkUxUVRGOVZVRVJCVkVGQ1RFVUtMeThnUTJobFkyc2dZWEJ3SUdseklIVndaR0YwWVdKc1pRcGhjM05sY25RS2NtVjBjM1ZpQ2dvdkx5QjFjR1JoZEdWZllXSnBDblZ3WkdGMFpXRmlhVjh4TVRvS2NISnZkRzhnTVNBeENtSjVkR1ZqWHpBZ0x5OGdJaUlLZEhodUlGTmxibVJsY2dwbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtQVDBLTHk4Z2RXNWhkWFJvYjNKcGVtVmtDbUZ6YzJWeWRBcHBiblJqSURRZ0x5OGdWRTFRVEY5VlVFUkJWRUZDVEVVS0x5OGdRMmhsWTJzZ1lYQndJR2x6SUhWd1pHRjBZV0pzWlFwaGMzTmxjblFLWm5KaGJXVmZaR2xuSUMweENtVjRkSEpoWTNRZ01pQXdDbVp5WVcxbFgySjFjbmtnTUFwbWNtRnRaVjlrYVdjZ01BcHNaVzRLYVhSdllncGxlSFJ5WVdOMElEWWdNQXBtY21GdFpWOWthV2NnTUFwamIyNWpZWFFLWm5KaGJXVmZZblZ5ZVNBd0NuSmxkSE4xWWdvS0x5OGdaR1ZzWlhSbENtUmxiR1YwWlY4eE1qb0tjSEp2ZEc4Z01DQXdDblI0YmlCVFpXNWtaWElLWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNqMDlDaTh2SUhWdVlYVjBhRzl5YVhwbFpBcGhjM05sY25RS2FXNTBZeUExSUM4dklGUk5VRXhmUkVWTVJWUkJRa3hGQ2k4dklFTm9aV05ySUdGd2NDQnBjeUJrWld4bGRHRmliR1VLWVhOelpYSjBDbkpsZEhOMVlnb0tMeThnWkdWc1pYUmxYMkZpYVFwa1pXeGxkR1ZoWW1sZk1UTTZDbkJ5YjNSdklERWdNUXBpZVhSbFkxOHdJQzh2SUNJaUNuUjRiaUJUWlc1a1pYSUtaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2owOUNpOHZJSFZ1WVhWMGFHOXlhWHBsWkFwaGMzTmxjblFLYVc1MFl5QTFJQzh2SUZSTlVFeGZSRVZNUlZSQlFreEZDaTh2SUVOb1pXTnJJR0Z3Y0NCcGN5QmtaV3hsZEdGaWJHVUtZWE56WlhKMENtWnlZVzFsWDJScFp5QXRNUXBsZUhSeVlXTjBJRElnTUFwbWNtRnRaVjlpZFhKNUlEQUtabkpoYldWZlpHbG5JREFLYkdWdUNtbDBiMklLWlhoMGNtRmpkQ0EySURBS1puSmhiV1ZmWkdsbklEQUtZMjl1WTJGMENtWnlZVzFsWDJKMWNua2dNQXB5WlhSemRXSUtDaTh2SUc5d2RGOXBiZ3B2Y0hScGJsOHhORG9LY0hKdmRHOGdNQ0F3Q21sdWRHTmZNU0F2THlBeENuSmxkSFZ5YmdvS0x5OGdaR1ZtWVhWc2RGOTJZV3gxWlFwa1pXWmhkV3gwZG1Gc2RXVmZNVFU2Q25CeWIzUnZJREVnTVFwaWVYUmxZMTh3SUM4dklDSWlDbVp5WVcxbFgyUnBaeUF0TVFwbGVIUnlZV04wSURJZ01BcG1jbUZ0WlY5aWRYSjVJREFLWm5KaGJXVmZaR2xuSURBS2JHVnVDbWwwYjJJS1pYaDBjbUZqZENBMklEQUtabkpoYldWZlpHbG5JREFLWTI5dVkyRjBDbVp5WVcxbFgySjFjbmtnTUFweVpYUnpkV0lLQ2k4dklHUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOWhZbWtLWkdWbVlYVnNkSFpoYkhWbFpuSnZiV0ZpYVY4eE5qb0tjSEp2ZEc4Z01TQXhDbUo1ZEdWalh6QWdMeThnSWlJS2NIVnphR0o1ZEdWeklEQjROREUwTWpRNU1tTXlNQ0F2THlBaVFVSkpMQ0FpQ21aeVlXMWxYMlJwWnlBdE1RcGxlSFJ5WVdOMElESWdNQXBqYjI1allYUUtabkpoYldWZlluVnllU0F3Q21aeVlXMWxYMlJwWnlBd0NteGxiZ3BwZEc5aUNtVjRkSEpoWTNRZ05pQXdDbVp5WVcxbFgyUnBaeUF3Q21OdmJtTmhkQXBtY21GdFpWOWlkWEo1SURBS2NtVjBjM1ZpQ2dvdkx5QmtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZaMnh2WW1Gc1gzTjBZWFJsQ21SbFptRjFiSFIyWVd4MVpXWnliMjFuYkc5aVlXeHpkR0YwWlY4eE56b0tjSEp2ZEc4Z01TQXhDbWx1ZEdOZk1DQXZMeUF3Q21aeVlXMWxYMlJwWnlBdE1RcG1jbUZ0WlY5aWRYSjVJREFLY21WMGMzVmlDZ292THlCa1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZmJHOWpZV3hmYzNSaGRHVUtaR1ZtWVhWc2RIWmhiSFZsWm5KdmJXeHZZMkZzYzNSaGRHVmZNVGc2Q25CeWIzUnZJREVnTVFwaWVYUmxZMTh3SUM4dklDSWlDbkIxYzJoaWVYUmxjeUF3ZURSak5tWTJNell4Tm1NeU1EY3pOelEyTVRjME5qVXlZekl3SUM4dklDSk1iMk5oYkNCemRHRjBaU3dnSWdwbWNtRnRaVjlrYVdjZ0xURUtaWGgwY21GamRDQXlJREFLWTI5dVkyRjBDbVp5WVcxbFgySjFjbmtnTUFwbWNtRnRaVjlrYVdjZ01BcHNaVzRLYVhSdllncGxlSFJ5WVdOMElEWWdNQXBtY21GdFpWOWthV2NnTUFwamIyNWpZWFFLWm5KaGJXVmZZblZ5ZVNBd0NuSmxkSE4xWWdvS0x5OGdZMkZzYkY5aFltbGZZMkZ6ZEdWeUNtTmhiR3hoWW1sallYTjBaWEpmTVRrNkNuQnliM1J2SURBZ01BcGllWFJsWTE4d0lDOHZJQ0lpQ21SMWNBcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q21aeVlXMWxYMkoxY25rZ01RcG1jbUZ0WlY5a2FXY2dNUXBqWVd4c2MzVmlJR05oYkd4aFltbGZNQXBtY21GdFpWOWlkWEo1SURBS1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDbVp5WVcxbFgyUnBaeUF3Q21OdmJtTmhkQXBzYjJjS2NtVjBjM1ZpQ2dvdkx5QmpZV3hzWDJGaWFWOTBlRzVmWTJGemRHVnlDbU5oYkd4aFltbDBlRzVqWVhOMFpYSmZNakE2Q25CeWIzUnZJREFnTUFwaWVYUmxZMTh3SUM4dklDSWlDbWx1ZEdOZk1DQXZMeUF3Q21KNWRHVmpYekFnTHk4Z0lpSUtkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFwbWNtRnRaVjlpZFhKNUlESUtkSGh1SUVkeWIzVndTVzVrWlhnS2FXNTBZMTh4SUM4dklERUtMUXBtY21GdFpWOWlkWEo1SURFS1puSmhiV1ZmWkdsbklERUtaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS2FXNTBZMTh4SUM4dklIQmhlUW85UFFwaGMzTmxjblFLWm5KaGJXVmZaR2xuSURFS1puSmhiV1ZmWkdsbklESUtZMkZzYkhOMVlpQmpZV3hzWVdKcGRIaHVYeklLWm5KaGJXVmZZblZ5ZVNBd0NtSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUXBtY21GdFpWOWthV2NnTUFwamIyNWpZWFFLYkc5bkNuSmxkSE4xWWdvS0x5OGdZMkZzYkY5aFltbGZabTl5WldsbmJsOXlaV1p6WDJOaGMzUmxjZ3BqWVd4c1lXSnBabTl5WldsbmJuSmxabk5qWVhOMFpYSmZNakU2Q25CeWIzUnZJREFnTUFwaWVYUmxZMTh3SUM4dklDSWlDbU5oYkd4emRXSWdZMkZzYkdGaWFXWnZjbVZwWjI1eVpXWnpYek1LWm5KaGJXVmZZblZ5ZVNBd0NtSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUXBtY21GdFpWOWthV2NnTUFwamIyNWpZWFFLYkc5bkNuSmxkSE4xWWdvS0x5OGdjMlYwWDJkc2IySmhiRjlqWVhOMFpYSUtjMlYwWjJ4dlltRnNZMkZ6ZEdWeVh6SXlPZ3B3Y205MGJ5QXdJREFLYVc1MFkxOHdJQzh2SURBS1pIVndDbUo1ZEdWalh6QWdMeThnSWlJS1pIVndDblI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS1luUnZhUXBtY21GdFpWOWlkWEo1SURBS2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ3BpZEc5cENtWnlZVzFsWDJKMWNua2dNUXAwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNtWnlZVzFsWDJKMWNua2dNZ3AwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENtWnlZVzFsWDJKMWNua2dNd3BtY21GdFpWOWthV2NnTUFwbWNtRnRaVjlrYVdjZ01RcG1jbUZ0WlY5a2FXY2dNZ3BtY21GdFpWOWthV2NnTXdwallXeHNjM1ZpSUhObGRHZHNiMkpoYkY4MENuSmxkSE4xWWdvS0x5OGdjMlYwWDJ4dlkyRnNYMk5oYzNSbGNncHpaWFJzYjJOaGJHTmhjM1JsY2w4eU16b0tjSEp2ZEc4Z01DQXdDbWx1ZEdOZk1DQXZMeUF3Q21SMWNBcGllWFJsWTE4d0lDOHZJQ0lpQ21SMWNBcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q21KMGIya0tabkpoYldWZlluVnllU0F3Q25SNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtZblJ2YVFwbWNtRnRaVjlpZFhKNUlERUtkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdwbWNtRnRaVjlpZFhKNUlESUtkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFwbWNtRnRaVjlpZFhKNUlETUtabkpoYldWZlpHbG5JREFLWm5KaGJXVmZaR2xuSURFS1puSmhiV1ZmWkdsbklESUtabkpoYldWZlpHbG5JRE1LWTJGc2JITjFZaUJ6WlhSc2IyTmhiRjgxQ25KbGRITjFZZ29LTHk4Z2MyVjBYMkp2ZUY5allYTjBaWElLYzJWMFltOTRZMkZ6ZEdWeVh6STBPZ3B3Y205MGJ5QXdJREFLWW5sMFpXTmZNQ0F2THlBaUlncGtkWEFLZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01RcG1jbUZ0WlY5aWRYSjVJREFLZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01ncG1jbUZ0WlY5aWRYSjVJREVLWm5KaGJXVmZaR2xuSURBS1puSmhiV1ZmWkdsbklERUtZMkZzYkhOMVlpQnpaWFJpYjNoZk5ncHlaWFJ6ZFdJS0NpOHZJR1Z5Y205eVgyTmhjM1JsY2dwbGNuSnZjbU5oYzNSbGNsOHlOVG9LY0hKdmRHOGdNQ0F3Q21OaGJHeHpkV0lnWlhKeWIzSmZOd3B5WlhSemRXSUtDaTh2SUdOeVpXRjBaVjloWW1sZlkyRnpkR1Z5Q21OeVpXRjBaV0ZpYVdOaGMzUmxjbDh5TmpvS2NISnZkRzhnTUNBd0NtSjVkR1ZqWHpBZ0x5OGdJaUlLWkhWd0NuUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLWm5KaGJXVmZZblZ5ZVNBeENtWnlZVzFsWDJScFp5QXhDbU5oYkd4emRXSWdZM0psWVhSbFlXSnBYemtLWm5KaGJXVmZZblZ5ZVNBd0NtSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUXBtY21GdFpWOWthV2NnTUFwamIyNWpZWFFLYkc5bkNuSmxkSE4xWWdvS0x5OGdkWEJrWVhSbFgyRmlhVjlqWVhOMFpYSUtkWEJrWVhSbFlXSnBZMkZ6ZEdWeVh6STNPZ3B3Y205MGJ5QXdJREFLWW5sMFpXTmZNQ0F2THlBaUlncGtkWEFLZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01RcG1jbUZ0WlY5aWRYSjVJREVLWm5KaGJXVmZaR2xuSURFS1kyRnNiSE4xWWlCMWNHUmhkR1ZoWW1sZk1URUtabkpoYldWZlluVnllU0F3Q21KNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05RcG1jbUZ0WlY5a2FXY2dNQXBqYjI1allYUUtiRzluQ25KbGRITjFZZ29LTHk4Z1pHVnNaWFJsWDJGaWFWOWpZWE4wWlhJS1pHVnNaWFJsWVdKcFkyRnpkR1Z5WHpJNE9ncHdjbTkwYnlBd0lEQUtZbmwwWldOZk1DQXZMeUFpSWdwa2RYQUtkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFwbWNtRnRaVjlpZFhKNUlERUtabkpoYldWZlpHbG5JREVLWTJGc2JITjFZaUJrWld4bGRHVmhZbWxmTVRNS1puSmhiV1ZmWW5WeWVTQXdDbUo1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFwbWNtRnRaVjlrYVdjZ01BcGpiMjVqWVhRS2JHOW5DbkpsZEhOMVlnb0tMeThnYjNCMFgybHVYMk5oYzNSbGNncHZjSFJwYm1OaGMzUmxjbDh5T1RvS2NISnZkRzhnTUNBd0NtTmhiR3h6ZFdJZ2IzQjBhVzVmTVRRS2NtVjBjM1ZpQ2dvdkx5QmtaV1poZFd4MFgzWmhiSFZsWDJOaGMzUmxjZ3BrWldaaGRXeDBkbUZzZFdWallYTjBaWEpmTXpBNkNuQnliM1J2SURBZ01BcGllWFJsWTE4d0lDOHZJQ0lpQ21SMWNBcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q21aeVlXMWxYMkoxY25rZ01RcG1jbUZ0WlY5a2FXY2dNUXBqWVd4c2MzVmlJR1JsWm1GMWJIUjJZV3gxWlY4eE5RcG1jbUZ0WlY5aWRYSjVJREFLWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNtWnlZVzFsWDJScFp5QXdDbU52Ym1OaGRBcHNiMmNLY21WMGMzVmlDZ292THlCa1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZllXSnBYMk5oYzNSbGNncGtaV1poZFd4MGRtRnNkV1ZtY205dFlXSnBZMkZ6ZEdWeVh6TXhPZ3B3Y205MGJ5QXdJREFLWW5sMFpXTmZNQ0F2THlBaUlncGtkWEFLZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01RcG1jbUZ0WlY5aWRYSjVJREVLWm5KaGJXVmZaR2xuSURFS1kyRnNiSE4xWWlCa1pXWmhkV3gwZG1Gc2RXVm1jbTl0WVdKcFh6RTJDbVp5WVcxbFgySjFjbmtnTUFwaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtabkpoYldWZlpHbG5JREFLWTI5dVkyRjBDbXh2WndweVpYUnpkV0lLQ2k4dklHUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOW5iRzlpWVd4ZmMzUmhkR1ZmWTJGemRHVnlDbVJsWm1GMWJIUjJZV3gxWldaeWIyMW5iRzlpWVd4emRHRjBaV05oYzNSbGNsOHpNam9LY0hKdmRHOGdNQ0F3Q21sdWRHTmZNQ0F2THlBd0NtUjFjQXAwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENtSjBiMmtLWm5KaGJXVmZZblZ5ZVNBeENtWnlZVzFsWDJScFp5QXhDbU5oYkd4emRXSWdaR1ZtWVhWc2RIWmhiSFZsWm5KdmJXZHNiMkpoYkhOMFlYUmxYekUzQ21aeVlXMWxYMkoxY25rZ01BcGllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLWm5KaGJXVmZaR2xuSURBS2FYUnZZZ3BqYjI1allYUUtiRzluQ25KbGRITjFZZ29LTHk4Z1pHVm1ZWFZzZEY5MllXeDFaVjltY205dFgyeHZZMkZzWDNOMFlYUmxYMk5oYzNSbGNncGtaV1poZFd4MGRtRnNkV1ZtY205dGJHOWpZV3h6ZEdGMFpXTmhjM1JsY2w4ek16b0tjSEp2ZEc4Z01DQXdDbUo1ZEdWalh6QWdMeThnSWlJS1pIVndDblI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS1puSmhiV1ZmWW5WeWVTQXhDbVp5WVcxbFgyUnBaeUF4Q21OaGJHeHpkV0lnWkdWbVlYVnNkSFpoYkhWbFpuSnZiV3h2WTJGc2MzUmhkR1ZmTVRnS1puSmhiV1ZmWW5WeWVTQXdDbUo1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFwbWNtRnRaVjlrYVdjZ01BcGpiMjVqWVhRS2JHOW5DbkpsZEhOMVlnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURnS2NIVnphR2x1ZENBd0lDOHZJREFLY21WMGRYSnUifSwiYnl0ZUNvZGUiOm51bGwsImNvbXBpbGVySW5mbyI6bnVsbCwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
