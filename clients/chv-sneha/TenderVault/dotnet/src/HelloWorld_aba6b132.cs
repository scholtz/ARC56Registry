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

namespace Arc56.Generated.chv_sneha.TenderVault.HelloWorld_aba6b132
{


    //
    // TenderVault Smart Contract - Immutable Tender and Bid Storage with Cryptographic Verification
    //
    public class HelloWorldProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HelloWorldProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize application state on creation
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 44, 58, 192 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 44, 58, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Store tender hash on blockchain with state management
        ///Blockchain Features: - Global state storage for counters - Transaction validation - Immutable record keeping - Access control via transaction sender
        ///</summary>
        /// <param name="tender_id"> </param>
        /// <param name="hash_value"> </param>
        public async Task<string> StoreTenderHash(string tender_id, string hash_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 31, 188, 166 };
            var tender_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tender_idAbi.From(tender_id);
            var hash_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hash_valueAbi.From(hash_value);

            var result = await base.CallApp(new List<object> { abiHandle, tender_idAbi, hash_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> StoreTenderHash_Transactions(string tender_id, string hash_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 31, 188, 166 };
            var tender_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tender_idAbi.From(tender_id);
            var hash_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hash_valueAbi.From(hash_value);

            return await base.MakeTransactionList(new List<object> { abiHandle, tender_idAbi, hash_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Store bid hash with tender linkage and state tracking
        ///Blockchain Features: - Global state management - Transaction validation - Cryptographic hash storage - Immutable audit trail
        ///</summary>
        /// <param name="bid_id"> </param>
        /// <param name="tender_id"> </param>
        /// <param name="hash_value"> </param>
        public async Task<string> StoreBidHash(string bid_id, string tender_id, string hash_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 0, 31, 59 };
            var bid_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bid_idAbi.From(bid_id);
            var tender_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tender_idAbi.From(tender_id);
            var hash_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hash_valueAbi.From(hash_value);

            var result = await base.CallApp(new List<object> { abiHandle, bid_idAbi, tender_idAbi, hash_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> StoreBidHash_Transactions(string bid_id, string tender_id, string hash_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 0, 31, 59 };
            var bid_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bid_idAbi.From(bid_id);
            var tender_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tender_idAbi.From(tender_id);
            var hash_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hash_valueAbi.From(hash_value);

            return await base.MakeTransactionList(new List<object> { abiHandle, bid_idAbi, tender_idAbi, hash_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cryptographic verification of hash integrity
        ///Blockchain Features: - Hash comparison for data integrity - Immutability verification - Transaction-based validation
        ///</summary>
        /// <param name="record_id"> </param>
        /// <param name="hash_value"> </param>
        public async Task<string> VerifyHash(string record_id, string hash_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 169, 175, 149 };
            var record_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); record_idAbi.From(record_id);
            var hash_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hash_valueAbi.From(hash_value);

            var result = await base.CallApp(new List<object> { abiHandle, record_idAbi, hash_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyHash_Transactions(string record_id, string hash_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 169, 175, 149 };
            var record_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); record_idAbi.From(record_id);
            var hash_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hash_valueAbi.From(hash_value);

            return await base.MakeTransactionList(new List<object> { abiHandle, record_idAbi, hash_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get blockchain statistics from global state
        ///Demonstrates: - Global state reading - On-chain data persistence - State management
        ///</summary>
        public async Task<string> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 152, 157, 43 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 152, 157, 43 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGVsbG9Xb3JsZCIsImRlc2MiOiJUZW5kZXJWYXVsdCBTbWFydCBDb250cmFjdCAtIEltbXV0YWJsZSBUZW5kZXIgYW5kIEJpZCBTdG9yYWdlIHdpdGggQ3J5cHRvZ3JhcGhpYyBWZXJpZmljYXRpb24iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6IkluaXRpYWxpemUgYXBwbGljYXRpb24gc3RhdGUgb24gY3JlYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RvcmVfdGVuZGVyX2hhc2giLCJkZXNjIjoiU3RvcmUgdGVuZGVyIGhhc2ggb24gYmxvY2tjaGFpbiB3aXRoIHN0YXRlIG1hbmFnZW1lbnRcbkJsb2NrY2hhaW4gRmVhdHVyZXM6IC0gR2xvYmFsIHN0YXRlIHN0b3JhZ2UgZm9yIGNvdW50ZXJzIC0gVHJhbnNhY3Rpb24gdmFsaWRhdGlvbiAtIEltbXV0YWJsZSByZWNvcmQga2VlcGluZyAtIEFjY2VzcyBjb250cm9sIHZpYSB0cmFuc2FjdGlvbiBzZW5kZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGVuZGVyX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoYXNoX3ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RvcmVfYmlkX2hhc2giLCJkZXNjIjoiU3RvcmUgYmlkIGhhc2ggd2l0aCB0ZW5kZXIgbGlua2FnZSBhbmQgc3RhdGUgdHJhY2tpbmdcbkJsb2NrY2hhaW4gRmVhdHVyZXM6IC0gR2xvYmFsIHN0YXRlIG1hbmFnZW1lbnQgLSBUcmFuc2FjdGlvbiB2YWxpZGF0aW9uIC0gQ3J5cHRvZ3JhcGhpYyBoYXNoIHN0b3JhZ2UgLSBJbW11dGFibGUgYXVkaXQgdHJhaWwiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmlkX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0ZW5kZXJfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imhhc2hfdmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfaGFzaCIsImRlc2MiOiJDcnlwdG9ncmFwaGljIHZlcmlmaWNhdGlvbiBvZiBoYXNoIGludGVncml0eVxuQmxvY2tjaGFpbiBGZWF0dXJlczogLSBIYXNoIGNvbXBhcmlzb24gZm9yIGRhdGEgaW50ZWdyaXR5IC0gSW1tdXRhYmlsaXR5IHZlcmlmaWNhdGlvbiAtIFRyYW5zYWN0aW9uLWJhc2VkIHZhbGlkYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjb3JkX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoYXNoX3ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3N0YXRzIiwiZGVzYyI6IkdldCBibG9ja2NoYWluIHN0YXRpc3RpY3MgZnJvbSBnbG9iYWwgc3RhdGVcbkRlbW9uc3RyYXRlczogLSBHbG9iYWwgc3RhdGUgcmVhZGluZyAtIE9uLWNoYWluIGRhdGEgcGVyc2lzdGVuY2UgLSBTdGF0ZSBtYW5hZ2VtZW50IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyODQsNDc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5iaWRfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzLDQ2OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGVuZGVyX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMywxNDksMjM4LDI1NCwyNzAsMzYyLDM3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MCwxNTYsMjQ1LDI2MSwyNzcsMzY5LDM4NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHVnVaR1Z5WDJOdmRXNTBJaUFpWW1sa1gyTnZkVzUwSWlBd2VERTFNV1kzWXpjMUlDSWdmQ0JJWVhOb09pQWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZNVEF0TVRFS0lDQWdJQzh2SUNNZ1IyeHZZbUZzSUhOMFlYUmxPaUJVY21GamF5QjBiM1JoYkNCMFpXNWtaWEp6SUdGdVpDQmlhV1J6SUhOMGIzSmxaQ0J2YmkxamFHRnBiZ29nSUNBZ0x5OGdjMlZzWmk1MFpXNWtaWEpmWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMFpXNWtaWEpmWTI5MWJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnYzJWc1ppNWlhV1JmWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWFXUmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRWhsYkd4dlYyOXliR1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGczTlRKak0yRmpNQ0F3ZUdNeU1XWmlZMkUySURCNE5ERXdNREZtTTJJZ01IZzFOV0U1WVdZNU5TQXdlREUwT1RnNVpESmlJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZEc5eVpWOTBaVzVrWlhKZmFHRnphQ2h6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMzUnZjbVZmWW1sa1gyaGhjMmdvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmYUdGemFDaHpkSEpwYm1jc2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFgzTjBZWFJ6S0NsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0Z2MzUnZjbVZmZEdWdVpHVnlYMmhoYzJnZ2MzUnZjbVZmWW1sa1gyaGhjMmdnZG1WeWFXWjVYMmhoYzJnZ1oyVjBYM04wWVhSekNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFE2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW9aV3hzYjE5M2IzSnNaQzVqYjI1MGNtRmpkQzVJWld4c2IxZHZjbXhrTG1OeVpXRjBaVjloY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnYzJWc1ppNTBaVzVrWlhKZlkyOTFiblF1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJsYm1SbGNsOWpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QnpaV3htTG1KcFpGOWpiM1Z1ZEM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW1sa1gyTnZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1b1pXeHNiMTkzYjNKc1pDNWpiMjUwY21GamRDNUlaV3hzYjFkdmNteGtMbk4wYjNKbFgzUmxibVJsY2w5b1lYTm9XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNSdmNtVmZkR1Z1WkdWeVgyaGhjMmc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1Y0hrNk1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TXpBdE16RUtJQ0FnSUM4dklDTWdVM1JoZEdVZ2JXRnVZV2RsYldWdWREb2dTVzVqY21WdFpXNTBJSFJsYm1SbGNpQmpiM1Z1ZENCdmJpMWphR0ZwYmdvZ0lDQWdMeThnYzJWc1ppNTBaVzVrWlhKZlkyOTFiblF1ZG1Gc2RXVWdLejBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkR1Z1WkdWeVgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUmxibVJsY2w5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owWlc1a1pYSmZZMjkxYm5RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG96TXkwek5Bb2dJQ0FnTHk4Z0l5QlNaWFIxY200Z1kyOXVabWx5YldGMGFXOXVJSGRwZEdnZ1lteHZZMnRqYUdGcGJpQnpkR0YwWlFvZ0lDQWdMeThnWTI5MWJuUmZZbmwwWlhNZ1BTQnZjQzVwZEc5aUtITmxiR1l1ZEdWdVpHVnlYMk52ZFc1MExuWmhiSFZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QnlaWFIxY200Z0lsUmxibVJsY2lCemRHOXlaV1E2SUNJZ0t5QjBaVzVrWlhKZmFXUWdLeUFpSUh3Z1NHRnphRG9nSWlBcklHaGhjMmhmZG1Gc2RXVWdLeUFpSUh3Z1QyNURhR0ZwYmlCRGIzVnVkRG9nSWlBcklGTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektHTnZkVzUwWDJKNWRHVnpLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlVaVzVrWlhJZ2MzUnZjbVZrT2lBaUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUFpSUh3Z1NHRnphRG9nSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnZkNCUGJrTm9ZV2x1SUVOdmRXNTBPaUFpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtaGxiR3h2WDNkdmNteGtMbU52Ym5SeVlXTjBMa2hsYkd4dlYyOXliR1F1YzNSdmNtVmZZbWxrWDJoaGMyaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZEc5eVpWOWlhV1JmYUdGemFEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVjSGs2TkRjdE5EZ0tJQ0FnSUM4dklDTWdVM1JoZEdVZ2JXRnVZV2RsYldWdWREb2dTVzVqY21WdFpXNTBJR0pwWkNCamIzVnVkQ0J2YmlCaWJHOWphMk5vWVdsdUNpQWdJQ0F2THlCelpXeG1MbUpwWkY5amIzVnVkQzUyWVd4MVpTQXJQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmlhV1JmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW1sa1gyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KcFpGOWpiM1Z1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOVEF0TlRFS0lDQWdJQzh2SUNNZ1VtVjBkWEp1SUhkcGRHZ2dZbXh2WTJ0amFHRnBiaUJ6ZEdGMFpTQmpiMjVtYVhKdFlYUnBiMjRLSUNBZ0lDOHZJSEpsZEhWeWJpQWlRbWxrSUhOMGIzSmxaRG9nSWlBcklHSnBaRjlwWkNBcklDSWdabTl5SUZSbGJtUmxjam9nSWlBcklIUmxibVJsY2w5cFpDQXJJQ0lnZkNCSVlYTm9PaUFpSUNzZ2FHRnphRjkyWVd4MVpTQXJJQ0lnZkNCUGJrTm9ZV2x1SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pDYVdRZ2MzUnZjbVZrT2lBaUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnWm05eUlGUmxibVJsY2pvZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaUlId2dTR0Z6YURvZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJSHdnVDI1RGFHRnBiaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG5CNU9qTTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1obGJHeHZYM2R2Y214a0xtTnZiblJ5WVdOMExraGxiR3h2VjI5eWJHUXVkbVZ5YVdaNVgyaGhjMmhiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxmYUdGemFEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUbzJNaTAyTkFvZ0lDQWdMeThnSXlCRGNubHdkRzluY21Gd2FHbGpJSFpsY21sbWFXTmhkR2x2YmpvZ1UybHRkV3hoZEdVZ2FHRnphQ0J0WVhSamFHbHVad29nSUNBZ0x5OGdJeUJKYmlCd2NtOWtkV04wYVc5dUxDQjBhR2x6SUhkdmRXeGtJR052YlhCaGNtVWdZV2RoYVc1emRDQnpkRzl5WldRZ1lteHZZMnRqYUdGcGJpQmtZWFJoQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdJbFpGVWtsR1NVVkVPaUFpSUNzZ2NtVmpiM0prWDJsa0lDc2dJaUI4SUVoaGMyZzZJQ0lnS3lCb1lYTm9YM1poYkhWbElDc2dJaUI4SUVsdGJYVjBZV0pzWlRvZ1ZGSlZSU0I4SUVKc2IyTnJZMmhoYVc0NklFRnNaMjl5WVc1a0lnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKV1JWSkpSa2xGUkRvZ0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlCOElFaGhjMmc2SUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQjhJRWx0YlhWMFlXSnNaVG9nVkZKVlJTQjhJRUpzYjJOclkyaGhhVzQ2SUVGc1oyOXlZVzVrSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFHVnNiRzlmZDI5eWJHUXVZMjl1ZEhKaFkzUXVTR1ZzYkc5WGIzSnNaQzVuWlhSZmMzUmhkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjM1JoZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJSFJsYm1SbGNsOWllWFJsY3lBOUlHOXdMbWwwYjJJb2MyVnNaaTUwWlc1a1pYSmZZMjkxYm5RdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkR1Z1WkdWeVgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUmxibVJsY2w5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNXdlVG8zTmdvZ0lDQWdMeThnWW1sa1gySjVkR1Z6SUQwZ2IzQXVhWFJ2WWloelpXeG1MbUpwWkY5amIzVnVkQzUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWFXUmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbWxrWDJOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJobGJHeHZYM2R2Y214a0wyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdJazl1UTJoaGFXNGdVM1JoZEhNZ2ZDQlVaVzVrWlhKek9pQWlJQ3NnVTNSeWFXNW5MbVp5YjIxZllubDBaWE1vZEdWdVpHVnlYMko1ZEdWektTQXJJQ0lnZkNCQ2FXUnpPaUFpSUNzZ1UzUnlhVzVuTG1aeWIyMWZZbmwwWlhNb1ltbGtYMko1ZEdWektRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKUGJrTm9ZV2x1SUZOMFlYUnpJSHdnVkdWdVpHVnljem9nSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJSHdnUW1sa2N6b2dJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUNKZ1FNZEdWdVpHVnlYMk52ZFc1MENXSnBaRjlqYjNWdWRBUVZIM3gxQ1NCOElFaGhjMmc2SURFWVFBQUdLQ0puS1NKbk1SdEJBREl4R1JSRU1SaEVnZ1VFZFN3NndBVENIN3ltQkVFQUh6c0VWYW12bFFRVW1KMHJOaG9BamdVQUNRQVJBSG9BOWdGakFERVpGREVZRkJCREtDSm5LU0puSTBNMkdnRkpJbGtrQ0VzQkZSSkVWd0lBTmhvQ1NTSlpKQWhMQVJVU1JGY0NBQ0lvWlVRakNDaExBV2NXZ0E5VVpXNWtaWElnYzNSdmNtVmtPaUJQQTFBclVFOENVSUFTSUh3Z1QyNURhR0ZwYmlCRGIzVnVkRG9nVUV4UVNSVVdWd1lDVEZBcVRGQ3dJME0yR2dGSklsa2tDRXNCRlJKRVZ3SUFOaG9DU1NKWkpBaExBUlVTUkZjQ0FEWWFBMGtpV1NRSVN3RVZFa1JYQWdBaUtXVkVJd2dwVEdlQURFSnBaQ0J6ZEc5eVpXUTZJRThEVUlBTklHWnZjaUJVWlc1a1pYSTZJRkJQQWxBclVFeFFnQW9nZkNCUGJrTm9ZV2x1VUVrVkZsY0dBa3hRS2t4UXNDTkROaG9CU1NKWkpBaExBUlVTUkZjQ0FEWWFBa2tpV1NRSVN3RVZFa1JYQWdDQUNsWkZVa2xHU1VWRU9pQlBBbEFyVUV4UWdDa2dmQ0JKYlcxMWRHRmliR1U2SUZSU1ZVVWdmQ0JDYkc5amEyTm9ZV2x1T2lCQmJHZHZjbUZ1WkZCSkZSWlhCZ0pNVUNwTVVMQWpReUlvWlVRV0lpbGxSQmFBR1U5dVEyaGhhVzRnVTNSaGRITWdmQ0JVWlc1a1pYSnpPaUJQQWxDQUNTQjhJRUpwWkhNNklGQk1VRWtWRmxjR0FreFFLa3hRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
