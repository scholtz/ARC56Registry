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

namespace Arc56.Generated.algorandecosystem.algokit_core.application_6ef00234
{


    public class TestContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///A method that takes two numbers and does either addition or subtraction
        ///</summary>
        /// <param name="a">The first number </param>
        /// <param name="b">The second number </param>
        /// <param name="operation">The operation to perform. Can be either 'sum' or 'difference' </param>
        public async Task<ulong> DoMath(ulong a, ulong b, string operation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 167, 239, 51 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var operationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); operationAbi.From(operation);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, operationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DoMath_Transactions(ulong a, ulong b, string operation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 167, 239, 51 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var operationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); operationAbi.From(operation);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, operationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task<Algorand.Address> TxnArg(PaymentTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 139, 177, 201, 211 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> TxnArg_Transactions(PaymentTransaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 139, 177, 201, 211 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> HelloWorld(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 184, 183, 206 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> HelloWorld_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 184, 183, 206 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="call"> </param>
        public async Task<ulong> MethodArg(ApplicationCallTransaction call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { call });
            byte[] abiHandle = { 218, 22, 18, 108 };

            var result = await base.CallApp(new List<object> { abiHandle, call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MethodArg_Transactions(ApplicationCallTransaction call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { call });
            byte[] abiHandle = { 218, 22, 18, 108 };

            return await base.MakeTransactionList(new List<object> { abiHandle, call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        /// <param name="call"> </param>
        public async Task<ulong> NestedTxnArg(PaymentTransaction txn, ApplicationCallTransaction call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn, call });
            byte[] abiHandle = { 167, 198, 24, 2 };

            var result = await base.CallApp(new List<object> { abiHandle, txn, call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NestedTxnArg_Transactions(PaymentTransaction txn, ApplicationCallTransaction call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn, call });
            byte[] abiHandle = { 167, 198, 24, 2 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn, call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn0"> </param>
        /// <param name="call1"> </param>
        /// <param name="txn2"> </param>
        /// <param name="call3"> </param>
        public async Task<ulong> DoubleNestedTxnArg(PaymentTransaction txn0, ApplicationCallTransaction call1, PaymentTransaction txn2, ApplicationCallTransaction call3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn0, call1, txn2, call3 });
            byte[] abiHandle = { 213, 98, 191, 25 };

            var result = await base.CallApp(new List<object> { abiHandle, txn0, call1, txn2, call3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DoubleNestedTxnArg_Transactions(PaymentTransaction txn0, ApplicationCallTransaction call1, PaymentTransaction txn2, ApplicationCallTransaction call3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn0, call1, txn2, call3 });
            byte[] abiHandle = { 213, 98, 191, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn0, call1, txn2, call3 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbXSwibmFtZSI6IlRlc3RDb250cmFjdCIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZG9NYXRoIiwiZGVzYyI6IkEgbWV0aG9kIHRoYXQgdGFrZXMgdHdvIG51bWJlcnMgYW5kIGRvZXMgZWl0aGVyIGFkZGl0aW9uIG9yIHN1YnRyYWN0aW9uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjoiVGhlIGZpcnN0IG51bWJlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOiJUaGUgc2Vjb25kIG51bWJlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0aW9uIiwiZGVzYyI6IlRoZSBvcGVyYXRpb24gdG8gcGVyZm9ybS4gQ2FuIGJlIGVpdGhlciAnc3VtJyBvciAnZGlmZmVyZW5jZSciLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHJlc3VsdCBvZiB0aGUgb3BlcmF0aW9uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJ0eG5BcmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiaGVsbG9Xb3JsZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoibWV0aG9kQXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJuZXN0ZWRUeG5BcmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZG91YmxlTmVzdGVkVHhuQXJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4bjAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGwzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjpudWxsLCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDZ292THlCVWFHbHpJRlJGUVV3Z2QyRnpJR2RsYm1WeVlYUmxaQ0JpZVNCVVJVRk1VMk55YVhCMElIWXdMamcyTGpBS0x5OGdhSFIwY0hNNkx5OW5hWFJvZFdJdVkyOXRMMkZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTlVUlVGTVUyTnlhWEIwQ2dvdkx5QlVhR2x6SUdOdmJuUnlZV04wSUdseklHTnZiWEJzYVdGdWRDQjNhWFJvSUdGdVpDOXZjaUJwYlhCc1pXMWxiblJ6SUhSb1pTQm1iMnhzYjNkcGJtY2dRVkpEY3pvZ1d5QkJVa00wSUYwS0NpOHZJRlJvWlNCbWIyeHNiM2RwYm1jZ2RHVnVJR3hwYm1WeklHOW1JRlJGUVV3Z2FHRnVaR3hsSUdsdWFYUnBZV3dnY0hKdlozSmhiU0JtYkc5M0NpOHZJRlJvYVhNZ2NHRjBkR1Z5YmlCcGN5QjFjMlZrSUhSdklHMWhhMlVnYVhRZ1pXRnplU0JtYjNJZ1lXNTViMjVsSUhSdklIQmhjbk5sSUhSb1pTQnpkR0Z5ZENCdlppQjBhR1VnY0hKdlozSmhiU0JoYm1RZ1pHVjBaWEp0YVc1bElHbG1JR0VnYzNCbFkybG1hV01nWVdOMGFXOXVJR2x6SUdGc2JHOTNaV1FLTHk4Z1NHVnlaU3dnWVdOMGFXOXVJSEpsWm1WeWN5QjBieUIwYUdVZ1QyNURiMjF3YkdWMFpTQnBiaUJqYjIxaWFXNWhkR2x2YmlCM2FYUm9JSGRvWlhSb1pYSWdkR2hsSUdGd2NDQnBjeUJpWldsdVp5QmpjbVZoZEdWa0lHOXlJR05oYkd4bFpBb3ZMeUJGZG1WeWVTQndiM056YVdKc1pTQmhZM1JwYjI0Z1ptOXlJSFJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdjbVZ3Y21WelpXNTBaV1FnYVc0Z2RHaGxJSE4zYVhSamFDQnpkR0YwWlcxbGJuUUtMeThnU1dZZ2RHaGxJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdobElHTnZiblJ5WVdOMExDQnBkSE1nY21WemNHVmpkR2wyWlNCaWNtRnVZMmdnZDJsc2JDQmlaU0FpS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0lnZDJocFkyZ2dhblZ6ZENCamIyNTBZV2x1Y3lBaVpYSnlJZ3AwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9oQ21sdWRDQTJDaW9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29yQ25OM2FYUmphQ0FxWTJGc2JGOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFZM0psWVhSbFgwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUNnb3FUazlVWDBsTlVFeEZUVVZPVkVWRU9nb0paWEp5Q2dvdkx5Qm5aWFJUZFcwb1lUb2diblZ0WW1WeUxDQmlPaUJ1ZFcxaVpYSXBPaUJ1ZFcxaVpYSUtMeThLTHk4Z1EyRnNZM1ZzWVhSbGN5QjBhR1VnYzNWdElHOW1JSFIzYnlCdWRXMWlaWEp6Q2k4dkNpOHZJRUJ3WVhKaGJTQmhDaTh2SUVCd1lYSmhiU0JpQ2k4dklFQnlaWFIxY201eklGUm9aU0J6ZFcwZ2IyWWdZU0JoYm1RZ1lncG5aWFJUZFcwNkNnbHdjbTkwYnlBeUlERUtDZ2t2THlCMFpYTjBYMk52Ym5SeVlXTjBMM1JsYzNRdVlXeG5ieTUwY3pveE1nb0pMeThnY21WMGRYSnVJR0VnS3lCaU93b0pabkpoYldWZlpHbG5JQzB4SUM4dklHRTZJRzUxYldKbGNnb0pabkpoYldWZlpHbG5JQzB5SUM4dklHSTZJRzUxYldKbGNnb0pLd29KY21WMGMzVmlDZ292THlCblpYUkVhV1ptWlhKbGJtTmxLR0U2SUc1MWJXSmxjaXdnWWpvZ2JuVnRZbVZ5S1RvZ2JuVnRZbVZ5Q2k4dkNpOHZJRU5oYkdOMWJHRjBaWE1nZEdobElHUnBabVpsY21WdVkyVWdZbVYwZDJWbGJpQjBkMjhnYm5WdFltVnljd292THdvdkx5QkFjR0Z5WVcwZ1lRb3ZMeUJBY0dGeVlXMGdZZ292THlCQWNtVjBkWEp1Y3lCVWFHVWdaR2xtWm1WeVpXNWpaU0JpWlhSM1pXVnVJR0VnWVc1a0lHSXVDbWRsZEVScFptWmxjbVZ1WTJVNkNnbHdjbTkwYnlBeUlERUtDZ2t2THlCMFpYTjBYMk52Ym5SeVlXTjBMM1JsYzNRdVlXeG5ieTUwY3pveU13b0pMeThnY21WMGRYSnVJR0VnUGowZ1lpQS9JR0VnTFNCaUlEb2dZaUF0SUdFN0NnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1lUb2diblZ0WW1WeUNnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z1lqb2diblZ0WW1WeUNnaytQUW9KWW5vZ0tuUmxjbTVoY25rd1gyWmhiSE5sQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWVRvZ2JuVnRZbVZ5Q2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnWWpvZ2JuVnRZbVZ5Q2drdENnbGlJQ3AwWlhKdVlYSjVNRjlsYm1RS0NpcDBaWEp1WVhKNU1GOW1ZV3h6WlRvS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCaU9pQnVkVzFpWlhJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaE9pQnVkVzFpWlhJS0NTMEtDaXAwWlhKdVlYSjVNRjlsYm1RNkNnbHlaWFJ6ZFdJS0NpOHZJR1J2VFdGMGFDaDFhVzUwTmpRc2RXbHVkRFkwTEhOMGNtbHVaeWwxYVc1ME5qUUtLbUZpYVY5eWIzVjBaVjlrYjAxaGRHZzZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDV0o1ZEdVZ01IZ3hOVEZtTjJNM05Rb0tDUzh2SUc5d1pYSmhkR2x2YmpvZ2MzUnlhVzVuQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJR0k2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb0pZblJ2YVFvS0NTOHZJR0U2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0pZblJ2YVFvS0NTOHZJR1Y0WldOMWRHVWdaRzlOWVhSb0tIVnBiblEyTkN4MWFXNTBOalFzYzNSeWFXNW5LWFZwYm5RMk5Bb0pZMkZzYkhOMVlpQmtiMDFoZEdnS0NXbDBiMklLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblFnTVFvSmNtVjBkWEp1Q2dvdkx5QmtiMDFoZEdnb1lUb2diblZ0WW1WeUxDQmlPaUJ1ZFcxaVpYSXNJRzl3WlhKaGRHbHZiam9nYzNSeWFXNW5LVG9nYm5WdFltVnlDaTh2Q2k4dklFRWdiV1YwYUc5a0lIUm9ZWFFnZEdGclpYTWdkSGR2SUc1MWJXSmxjbk1nWVc1a0lHUnZaWE1nWldsMGFHVnlJR0ZrWkdsMGFXOXVJRzl5SUhOMVluUnlZV04wYVc5dUNpOHZDaTh2SUVCd1lYSmhiU0JoSUZSb1pTQm1hWEp6ZENCdWRXMWlaWElLTHk4Z1FIQmhjbUZ0SUdJZ1ZHaGxJSE5sWTI5dVpDQnVkVzFpWlhJS0x5OGdRSEJoY21GdElHOXdaWEpoZEdsdmJpQlVhR1VnYjNCbGNtRjBhVzl1SUhSdklIQmxjbVp2Y20wdUlFTmhiaUJpWlNCbGFYUm9aWElnSjNOMWJTY2diM0lnSjJScFptWmxjbVZ1WTJVbkNpOHZDaTh2SUVCeVpYUjFjbTV6SUZSb1pTQnlaWE4xYkhRZ2IyWWdkR2hsSUc5d1pYSmhkR2x2Ymdwa2IwMWhkR2c2Q2dsd2NtOTBieUF6SURFS0Nna3ZMeUJRZFhOb0lHVnRjSFI1SUdKNWRHVnpJR0ZtZEdWeUlIUm9aU0JtY21GdFpTQndiMmx1ZEdWeUlIUnZJSEpsYzJWeWRtVWdjM0JoWTJVZ1ptOXlJR3h2WTJGc0lIWmhjbWxoWW14bGN3b0pZbmwwWlNBd2VBb0tDUzh2SUNwcFpqQmZZMjl1WkdsMGFXOXVDZ2t2THlCMFpYTjBYMk52Ym5SeVlXTjBMM1JsYzNRdVlXeG5ieTUwY3pvek9Bb0pMeThnYjNCbGNtRjBhVzl1SUQwOVBTQW5jM1Z0SndvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUc5d1pYSmhkR2x2YmpvZ2MzUnlhVzVuQ2dsaWVYUmxJREI0TnpNM05UWmtJQzh2SUNKemRXMGlDZ2s5UFFvSllub2dLbWxtTUY5bGJITmxhV1l4WDJOdmJtUnBkR2x2YmdvS0NTOHZJQ3BwWmpCZlkyOXVjMlZ4ZFdWdWRBb0pMeThnZEdWemRGOWpiMjUwY21GamRDOTBaWE4wTG1Gc1oyOHVkSE02TXprS0NTOHZJSEpsYzNWc2RDQTlJSFJvYVhNdVoyVjBVM1Z0S0dFc0lHSXBDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdZam9nYm5WdFltVnlDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZVG9nYm5WdFltVnlDZ2xqWVd4c2MzVmlJR2RsZEZOMWJRb0pabkpoYldWZlluVnllU0F3SUM4dklISmxjM1ZzZERvZ2JuVnRZbVZ5Q2dsaUlDcHBaakJmWlc1a0Nnb3FhV1l3WDJWc2MyVnBaakZmWTI5dVpHbDBhVzl1T2dvSkx5OGdkR1Z6ZEY5amIyNTBjbUZqZEM5MFpYTjBMbUZzWjI4dWRITTZOREFLQ1M4dklHOXdaWEpoZEdsdmJpQTlQVDBnSjJScFptWmxjbVZ1WTJVbkNnbG1jbUZ0WlY5a2FXY2dMVE1nTHk4Z2IzQmxjbUYwYVc5dU9pQnpkSEpwYm1jS0NXSjVkR1VnTUhnMk5EWTVOalkyTmpZMU56STJOVFpsTmpNMk5TQXZMeUFpWkdsbVptVnlaVzVqWlNJS0NUMDlDZ2xpZWlBcWFXWXdYMlZzYzJVS0Nna3ZMeUFxYVdZd1gyVnNjMlZwWmpGZlkyOXVjMlZ4ZFdWdWRBb0pMeThnZEdWemRGOWpiMjUwY21GamRDOTBaWE4wTG1Gc1oyOHVkSE02TkRFS0NTOHZJSEpsYzNWc2RDQTlJSFJvYVhNdVoyVjBSR2xtWm1WeVpXNWpaU2hoTENCaUtRb0pabkpoYldWZlpHbG5JQzB5SUM4dklHSTZJRzUxYldKbGNnb0pabkpoYldWZlpHbG5JQzB4SUM4dklHRTZJRzUxYldKbGNnb0pZMkZzYkhOMVlpQm5aWFJFYVdabVpYSmxibU5sQ2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnY21WemRXeDBPaUJ1ZFcxaVpYSUtDV0lnS21sbU1GOWxibVFLQ2lwcFpqQmZaV3h6WlRvS0NXVnljaUF2THlBblNXNTJZV3hwWkNCdmNHVnlZWFJwYjI0bkNnb3FhV1l3WDJWdVpEb0tDUzh2SUhSbGMzUmZZMjl1ZEhKaFkzUXZkR1Z6ZEM1aGJHZHZMblJ6T2pRMENna3ZMeUJ5WlhSMWNtNGdjbVZ6ZFd4ME93b0pabkpoYldWZlpHbG5JREFnTHk4Z2NtVnpkV3gwT2lCdWRXMWlaWElLQ2drdkx5QnpaWFFnZEdobElITjFZbkp2ZFhScGJtVWdjbVYwZFhKdUlIWmhiSFZsQ2dsbWNtRnRaVjlpZFhKNUlEQUtDWEpsZEhOMVlnb0tMeThnZEhodVFYSm5LSEJoZVNsaFpHUnlaWE56Q2lwaFltbGZjbTkxZEdWZmRIaHVRWEpuT2dvSkx5OGdWR2hsSUVGQ1NTQnlaWFIxY200Z2NISmxabWw0Q2dsaWVYUmxJREI0TVRVeFpqZGpOelVLQ2drdkx5QjBlRzQ2SUhCaGVRb0pkSGh1SUVkeWIzVndTVzVrWlhnS0NXbHVkQ0F4Q2drdENnbGtkWEFLQ1dkMGVHNXpJRlI1Y0dWRmJuVnRDZ2xwYm5RZ2NHRjVDZ2s5UFFvSllYTnpaWEowQ2dvSkx5OGdaWGhsWTNWMFpTQjBlRzVCY21jb2NHRjVLV0ZrWkhKbGMzTUtDV05oYkd4emRXSWdkSGh1UVhKbkNnbGpiMjVqWVhRS0NXeHZad29KYVc1MElERUtDWEpsZEhWeWJnb0tMeThnZEhodVFYSm5LSFI0YmpvZ1VHRjVWSGh1S1RvZ1FXUmtjbVZ6Y3dwMGVHNUJjbWM2Q2dsd2NtOTBieUF4SURFS0Nna3ZMeUIwWlhOMFgyTnZiblJ5WVdOMEwzUmxjM1F1WVd4bmJ5NTBjem8wT0FvSkx5OGdjbVYwZFhKdUlIUjRiaTV6Wlc1a1pYSTdDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdkSGh1T2lCUVlYbFVlRzRLQ1dkMGVHNXpJRk5sYm1SbGNnb0pjbVYwYzNWaUNnb3ZMeUJvWld4c2IxZHZjbXhrS0NsemRISnBibWNLS21GaWFWOXliM1YwWlY5b1pXeHNiMWR2Y214a09nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbGllWFJsSURCNE1UVXhaamRqTnpVS0Nna3ZMeUJsZUdWamRYUmxJR2hsYkd4dlYyOXliR1FvS1hOMGNtbHVad29KWTJGc2JITjFZaUJvWld4c2IxZHZjbXhrQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTI5dVkyRjBDZ2xzYjJjS0NXbHVkQ0F4Q2dseVpYUjFjbTRLQ2k4dklHaGxiR3h2VjI5eWJHUW9LVG9nYzNSeWFXNW5DbWhsYkd4dlYyOXliR1E2Q2dsd2NtOTBieUF3SURFS0Nna3ZMeUIwWlhOMFgyTnZiblJ5WVdOMEwzUmxjM1F1WVd4bmJ5NTBjem8xTWdvSkx5OGdjbVYwZFhKdUlDZElaV3hzYnl3Z1YyOXliR1FoSnpzS0NXSjVkR1VnTUhnME9EWTFObU0yWXpabU1tTXlNRFUzTm1ZM01qWmpOalF5TVNBdkx5QWlTR1ZzYkc4c0lGZHZjbXhrSVNJS0NYSmxkSE4xWWdvS0x5OGdiV1YwYUc5a1FYSm5LR0Z3Y0d3cGRXbHVkRFkwQ2lwaFltbGZjbTkxZEdWZmJXVjBhRzlrUVhKbk9nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbGllWFJsSURCNE1UVXhaamRqTnpVS0Nna3ZMeUJqWVd4c09pQmhjSEJzQ2dsMGVHNGdSM0p2ZFhCSmJtUmxlQW9KYVc1MElERUtDUzBLQ1dSMWNBb0paM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0NXbHVkQ0JoY0hCc0NnazlQUW9KWVhOelpYSjBDZ29KTHk4Z1pYaGxZM1YwWlNCdFpYUm9iMlJCY21jb1lYQndiQ2wxYVc1ME5qUUtDV05oYkd4emRXSWdiV1YwYUc5a1FYSm5DZ2xwZEc5aUNnbGpiMjVqWVhRS0NXeHZad29KYVc1MElERUtDWEpsZEhWeWJnb0tMeThnYldWMGFHOWtRWEpuS0dOaGJHdzZJRUZ3Y0VOaGJHeFVlRzRwT2lCQmNIQkpSQXB0WlhSb2IyUkJjbWM2Q2dsd2NtOTBieUF4SURFS0Nna3ZMeUIwWlhOMFgyTnZiblJ5WVdOMEwzUmxjM1F1WVd4bmJ5NTBjem8xTmdvSkx5OGdjbVYwZFhKdUlHTmhiR3d1WVhCd2JHbGpZWFJwYjI1SlJBb0pabkpoYldWZlpHbG5JQzB4SUM4dklHTmhiR3c2SUVGd2NFTmhiR3hVZUc0S0NXZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtDWEpsZEhOMVlnb0tMeThnYm1WemRHVmtWSGh1UVhKbktIQmhlU3hoY0hCc0tYVnBiblEyTkFvcVlXSnBYM0p2ZFhSbFgyNWxjM1JsWkZSNGJrRnlaem9LQ1M4dklGUm9aU0JCUWtrZ2NtVjBkWEp1SUhCeVpXWnBlQW9KWW5sMFpTQXdlREUxTVdZM1l6YzFDZ29KTHk4Z1kyRnNiRG9nWVhCd2JBb0pkSGh1SUVkeWIzVndTVzVrWlhnS0NXbHVkQ0F4Q2drdENnbGtkWEFLQ1dkMGVHNXpJRlI1Y0dWRmJuVnRDZ2xwYm5RZ1lYQndiQW9KUFQwS0NXRnpjMlZ5ZEFvS0NTOHZJSFI0YmpvZ2NHRjVDZ2wwZUc0Z1IzSnZkWEJKYm1SbGVBb0phVzUwSURJS0NTMEtDV1IxY0FvSlozUjRibk1nVkhsd1pVVnVkVzBLQ1dsdWRDQndZWGtLQ1QwOUNnbGhjM05sY25RS0Nna3ZMeUJsZUdWamRYUmxJRzVsYzNSbFpGUjRia0Z5Wnlod1lYa3NZWEJ3YkNsMWFXNTBOalFLQ1dOaGJHeHpkV0lnYm1WemRHVmtWSGh1UVhKbkNnbHBkRzlpQ2dsamIyNWpZWFFLQ1d4dlp3b0phVzUwSURFS0NYSmxkSFZ5YmdvS0x5OGdibVZ6ZEdWa1ZIaHVRWEpuS0hSNGJqb2dVR0Y1VkhodUxDQmpZV3hzT2lCQmNIQkRZV3hzVkhodUtUb2dRWEJ3U1VRS2JtVnpkR1ZrVkhodVFYSm5PZ29KY0hKdmRHOGdNaUF4Q2dvSkx5OGdkR1Z6ZEY5amIyNTBjbUZqZEM5MFpYTjBMbUZzWjI4dWRITTZOakFLQ1M4dklISmxkSFZ5YmlCallXeHNMbUZ3Y0d4cFkyRjBhVzl1U1VRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCallXeHNPaUJCY0hCRFlXeHNWSGh1Q2dsbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNnbHlaWFJ6ZFdJS0NpOHZJR1J2ZFdKc1pVNWxjM1JsWkZSNGJrRnlaeWh3WVhrc1lYQndiQ3h3WVhrc1lYQndiQ2wxYVc1ME5qUUtLbUZpYVY5eWIzVjBaVjlrYjNWaWJHVk9aWE4wWldSVWVHNUJjbWM2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1dKNWRHVWdNSGd4TlRGbU4yTTNOUW9LQ1M4dklHTmhiR3d6T2lCaGNIQnNDZ2wwZUc0Z1IzSnZkWEJKYm1SbGVBb0phVzUwSURFS0NTMEtDV1IxY0FvSlozUjRibk1nVkhsd1pVVnVkVzBLQ1dsdWRDQmhjSEJzQ2drOVBRb0pZWE56WlhKMENnb0pMeThnZEhodU1qb2djR0Y1Q2dsMGVHNGdSM0p2ZFhCSmJtUmxlQW9KYVc1MElESUtDUzBLQ1dSMWNBb0paM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0NXbHVkQ0J3WVhrS0NUMDlDZ2xoYzNObGNuUUtDZ2t2THlCallXeHNNVG9nWVhCd2JBb0pkSGh1SUVkeWIzVndTVzVrWlhnS0NXbHVkQ0F6Q2drdENnbGtkWEFLQ1dkMGVHNXpJRlI1Y0dWRmJuVnRDZ2xwYm5RZ1lYQndiQW9KUFQwS0NXRnpjMlZ5ZEFvS0NTOHZJSFI0YmpBNklIQmhlUW9KZEhodUlFZHliM1Z3U1c1a1pYZ0tDV2x1ZENBMENna3RDZ2xrZFhBS0NXZDBlRzV6SUZSNWNHVkZiblZ0Q2dscGJuUWdjR0Y1Q2drOVBRb0pZWE56WlhKMENnb0pMeThnWlhobFkzVjBaU0JrYjNWaWJHVk9aWE4wWldSVWVHNUJjbWNvY0dGNUxHRndjR3dzY0dGNUxHRndjR3dwZFdsdWREWTBDZ2xqWVd4c2MzVmlJR1J2ZFdKc1pVNWxjM1JsWkZSNGJrRnlad29KYVhSdllnb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRDQXhDZ2x5WlhSMWNtNEtDaTh2SUdSdmRXSnNaVTVsYzNSbFpGUjRia0Z5WnloMGVHNHdPaUJRWVhsVWVHNHNJR05oYkd3eE9pQkJjSEJEWVd4c1ZIaHVMQ0IwZUc0eU9pQlFZWGxVZUc0c0lHTmhiR3d6T2lCQmNIQkRZV3hzVkhodUtUb2dRWEJ3U1VRS1pHOTFZbXhsVG1WemRHVmtWSGh1UVhKbk9nb0pjSEp2ZEc4Z05DQXhDZ29KTHk4Z2RHVnpkRjlqYjI1MGNtRmpkQzkwWlhOMExtRnNaMjh1ZEhNNk5qUUtDUzh2SUhKbGRIVnliaUJqWVd4c01TNWhjSEJzYVdOaGRHbHZia2xFQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnWTJGc2JERTZJRUZ3Y0VOaGJHeFVlRzRLQ1dkMGVHNXpJRUZ3Y0d4cFkyRjBhVzl1U1VRS0NYSmxkSE4xWWdvS0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tDV2x1ZENBeENnbHlaWFIxY200S0NpcGpjbVZoZEdWZlRtOVBjRG9LQ1cxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNnbGxjbklLQ2lwallXeHNYMDV2VDNBNkNnbHRaWFJvYjJRZ0ltUnZUV0YwYUNoMWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5bDFhVzUwTmpRaUNnbHRaWFJvYjJRZ0luUjRia0Z5Wnlod1lYa3BZV1JrY21WemN5SUtDVzFsZEdodlpDQWlhR1ZzYkc5WGIzSnNaQ2dwYzNSeWFXNW5JZ29KYldWMGFHOWtJQ0p0WlhSb2IyUkJjbWNvWVhCd2JDbDFhVzUwTmpRaUNnbHRaWFJvYjJRZ0ltNWxjM1JsWkZSNGJrRnlaeWh3WVhrc1lYQndiQ2wxYVc1ME5qUWlDZ2x0WlhSb2IyUWdJbVJ2ZFdKc1pVNWxjM1JsWkZSNGJrRnlaeWh3WVhrc1lYQndiQ3h3WVhrc1lYQndiQ2wxYVc1ME5qUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyUnZUV0YwYUNBcVlXSnBYM0p2ZFhSbFgzUjRia0Z5WnlBcVlXSnBYM0p2ZFhSbFgyaGxiR3h2VjI5eWJHUWdLbUZpYVY5eWIzVjBaVjl0WlhSb2IyUkJjbWNnS21GaWFWOXliM1YwWlY5dVpYTjBaV1JVZUc1QmNtY2dLbUZpYVY5eWIzVjBaVjlrYjNWaWJHVk9aWE4wWldSVWVHNUJjbWNLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
