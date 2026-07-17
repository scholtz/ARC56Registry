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

namespace Arc56.Generated.Athiran_dev.DocChain.DocumentVerification_9bf244f4
{


    //
    // 
    //    Document Verification Contract
    //    Stores: document_hash -> candidate_address
    //    Any org can register docs; anyone can verify.
    //    
    //
    public class DocumentVerificationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DocumentVerificationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Register a document on-chain.
        ///Stores: document_hash -> candidate_address|issuer|timestamp|org_name
        ///</summary>
        /// <param name="document_hash"> </param>
        /// <param name="candidate_address"> </param>
        /// <param name="org_name"> </param>
        public async Task<bool> RegisterDocument(string document_hash, string candidate_address, string org_name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 232, 34, 143 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);
            var candidate_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); candidate_addressAbi.From(candidate_address);
            var org_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); org_nameAbi.From(org_name);

            var result = await base.CallApp(new List<object> { abiHandle, document_hashAbi, candidate_addressAbi, org_nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterDocument_Transactions(string document_hash, string candidate_address, string org_name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 232, 34, 143 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);
            var candidate_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); candidate_addressAbi.From(candidate_address);
            var org_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); org_nameAbi.From(org_name);

            return await base.MakeTransactionList(new List<object> { abiHandle, document_hashAbi, candidate_addressAbi, org_nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify that this document belongs to this candidate.
        ///Returns: VALID | NOT_FOUND | REVOKED | MISMATCH
        ///</summary>
        /// <param name="document_hash"> </param>
        /// <param name="candidate_address"> </param>
        public async Task<string> VerifyDocument(string document_hash, string candidate_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 230, 137, 126 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);
            var candidate_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); candidate_addressAbi.From(candidate_address);

            var result = await base.SimApp(new List<object> { abiHandle, document_hashAbi, candidate_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyDocument_Transactions(string document_hash, string candidate_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 230, 137, 126 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);
            var candidate_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); candidate_addressAbi.From(candidate_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, document_hashAbi, candidate_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return raw packed bytes — parse off-chain.
        ///</summary>
        /// <param name="document_hash"> </param>
        public async Task<byte[]> GetDocumentDetails(string document_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 88, 137, 24 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);

            var result = await base.SimApp(new List<object> { abiHandle, document_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetDocumentDetails_Transactions(string document_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 88, 137, 24 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, document_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="document_hash"> </param>
        public async Task<bool> DocumentExists(string document_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 71, 76, 125 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);

            var result = await base.SimApp(new List<object> { abiHandle, document_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DocumentExists_Transactions(string document_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 71, 76, 125 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, document_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Only the original issuer can revoke.
        ///</summary>
        /// <param name="document_hash"> </param>
        /// <param name="reason"> </param>
        public async Task<bool> RevokeDocument(string document_hash, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 192, 165, 90 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            var result = await base.CallApp(new List<object> { abiHandle, document_hashAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RevokeDocument_Transactions(string document_hash, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 192, 165, 90 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            return await base.MakeTransactionList(new List<object> { abiHandle, document_hashAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="document_hash"> </param>
        public async Task<bool> IsRevoked(string document_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 230, 33, 128 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);

            var result = await base.SimApp(new List<object> { abiHandle, document_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsRevoked_Transactions(string document_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 230, 33, 128 };
            var document_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); document_hashAbi.From(document_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, document_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRG9jdW1lbnRWZXJpZmljYXRpb24iLCJkZXNjIjoiXG4gICAgRG9jdW1lbnQgVmVyaWZpY2F0aW9uIENvbnRyYWN0XG4gICAgU3RvcmVzOiBkb2N1bWVudF9oYXNoIC0+IGNhbmRpZGF0ZV9hZGRyZXNzXG4gICAgQW55IG9yZyBjYW4gcmVnaXN0ZXIgZG9jczsgYW55b25lIGNhbiB2ZXJpZnkuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InJlZ2lzdGVyX2RvY3VtZW50IiwiZGVzYyI6IlJlZ2lzdGVyIGEgZG9jdW1lbnQgb24tY2hhaW4uXG5TdG9yZXM6IGRvY3VtZW50X2hhc2ggLT4gY2FuZGlkYXRlX2FkZHJlc3N8aXNzdWVyfHRpbWVzdGFtcHxvcmdfbmFtZSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkb2N1bWVudF9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYW5kaWRhdGVfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnX25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X2RvY3VtZW50IiwiZGVzYyI6IlZlcmlmeSB0aGF0IHRoaXMgZG9jdW1lbnQgYmVsb25ncyB0byB0aGlzIGNhbmRpZGF0ZS5cblJldHVybnM6IFZBTElEIHwgTk9UX0ZPVU5EIHwgUkVWT0tFRCB8IE1JU01BVENIIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvY3VtZW50X2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbmRpZGF0ZV9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZG9jdW1lbnRfZGV0YWlscyIsImRlc2MiOiJSZXR1cm4gcmF3IHBhY2tlZCBieXRlcyDigJQgcGFyc2Ugb2ZmLWNoYWluLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkb2N1bWVudF9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkb2N1bWVudF9leGlzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jdW1lbnRfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZV9kb2N1bWVudCIsImRlc2MiOiJPbmx5IHRoZSBvcmlnaW5hbCBpc3N1ZXIgY2FuIHJldm9rZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jdW1lbnRfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX3Jldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jdW1lbnRfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDUzXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSByZXZva2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxXSwiZXJyb3JNZXNzYWdlIjoiRG9jdW1lbnQgYWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU5LDQ0NF0sImVycm9yTWVzc2FnZSI6IkRvY3VtZW50IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MF0sImVycm9yTWVzc2FnZSI6IkRvY3VtZW50IHdhcyBwcmV2aW91c2x5IHJldm9rZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUsMTI4LDE0MSwyMDgsMjI0LDM0MywzODEsNDE0LDQyNyw0ODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjIsMTM1LDE0OCwyMTUsMjMwLDM1MCwzODgsNDIxLDQzNCw0ODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNUW9nSUNBZ1lubDBaV05pYkc5amF5QXdlRGRqSUNKa2IyTWlJQ0p5WlhZaUlEQjRNVFV4Wmpkak56VWdNSGd4TlRGbU4yTTNOVGd3SURCNE1EQXdPRFJrTkRrMU16UmtOREUxTkRRek5EZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFUnZZM1Z0Wlc1MFZtVnlhV1pwWTJGMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRORGhsT0RJeU9HWWdNSGd6TjJVMk9EazNaU0F3ZUdZeU5UZzRPVEU0SURCNE1USTBOelJqTjJRZ01IZ3pOMk13WVRVMVlTQXdlR000WlRZeU1UZ3dJQzh2SUcxbGRHaHZaQ0FpY21WbmFYTjBaWEpmWkc5amRXMWxiblFvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcFltOXZiQ0lzSUcxbGRHaHZaQ0FpZG1WeWFXWjVYMlJ2WTNWdFpXNTBLSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUmZaRzlqZFcxbGJuUmZaR1YwWVdsc2N5aHpkSEpwYm1jcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKa2IyTjFiV1Z1ZEY5bGVHbHpkSE1vYzNSeWFXNW5LV0p2YjJ3aUxDQnRaWFJvYjJRZ0luSmxkbTlyWlY5a2IyTjFiV1Z1ZENoemRISnBibWNzYzNSeWFXNW5LV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltbHpYM0psZG05clpXUW9jM1J5YVc1bktXSnZiMndpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCeVpXZHBjM1JsY2w5a2IyTjFiV1Z1ZENCMlpYSnBabmxmWkc5amRXMWxiblFnWjJWMFgyUnZZM1Z0Wlc1MFgyUmxkR0ZwYkhNZ1pHOWpkVzFsYm5SZlpYaHBjM1J6SUhKbGRtOXJaVjlrYjJOMWJXVnVkQ0JwYzE5eVpYWnZhMlZrQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExrUnZZM1Z0Wlc1MFZtVnlhV1pwWTJGMGFXOXVMbkpsWjJsemRHVnlYMlJ2WTNWdFpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEpmWkc5amRXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWkc5algydGxlU0E5SUc5d0xuTm9ZVEkxTmloa2IyTjFiV1Z1ZEY5b1lYTm9MbUo1ZEdWektRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmhjM05sY25RZ1pHOWpYMnRsZVNCdWIzUWdhVzRnYzJWc1ppNWtiMk4xYldWdWRITXNJQ0pFYjJOMWJXVnVkQ0JoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prYjJNaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFUnZZM1Z0Wlc1MElHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtiMk5mYTJWNUlHNXZkQ0JwYmlCelpXeG1MbkpsZG05clpXUXNJQ0pFYjJOMWJXVnVkQ0IzWVhNZ2NISmxkbWx2ZFhOc2VTQnlaWFp2YTJWa0lnb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNtVjJJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFUnZZM1Z0Wlc1MElIZGhjeUJ3Y21WMmFXOTFjMng1SUhKbGRtOXJaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCamRYSnlaVzUwWDNScGJXVWdQU0J2Y0M1cGRHOWlLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOREF0TkRFS0lDQWdJQzh2SUdOaGJtUnBaR0YwWlY5aFpHUnlaWE56TG1KNWRHVnpJQ0FnSXlCallXNWthV1JoZEdVbmN5QkJiR2R2Y21GdVpDQmhaR1J5WlhOeklDaHpkSEpwYm1jcENpQWdJQ0F2THlBcklHSWlmQ0lLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJQ3NnWWlKOElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEZGpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8wTUMwME1Rb2dJQ0FnTHk4Z1kyRnVaR2xrWVhSbFgyRmtaSEpsYzNNdVlubDBaWE1nSUNBaklHTmhibVJwWkdGMFpTZHpJRUZzWjI5eVlXNWtJR0ZrWkhKbGMzTWdLSE4wY21sdVp5a0tJQ0FnSUM4dklDc2dZaUo4SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdLeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ0FnSUNBZ0lDQWpJR2x6YzNWbGNpZHpJRE15TFdKNWRHVWdZV1JrY21WemN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5EQXRORElLSUNBZ0lDOHZJR05oYm1ScFpHRjBaVjloWkdSeVpYTnpMbUo1ZEdWeklDQWdJeUJqWVc1a2FXUmhkR1VuY3lCQmJHZHZjbUZ1WkNCaFpHUnlaWE56SUNoemRISnBibWNwQ2lBZ0lDQXZMeUFySUdJaWZDSUtJQ0FnSUM4dklDc2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QWdJQ0FnSUNBZ0l5QnBjM04xWlhJbmN5QXpNaTFpZVhSbElHRmtaSEpsYzNNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJQ3NnWWlKOElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEZGpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8wTUMwME13b2dJQ0FnTHk4Z1kyRnVaR2xrWVhSbFgyRmtaSEpsYzNNdVlubDBaWE1nSUNBaklHTmhibVJwWkdGMFpTZHpJRUZzWjI5eVlXNWtJR0ZrWkhKbGMzTWdLSE4wY21sdVp5a0tJQ0FnSUM4dklDc2dZaUo4SWdvZ0lDQWdMeThnS3lCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUNBZ0lDQWdJQ0FqSUdsemMzVmxjaWR6SURNeUxXSjVkR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdLeUJpSW53aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalF3TFRRMENpQWdJQ0F2THlCallXNWthV1JoZEdWZllXUmtjbVZ6Y3k1aWVYUmxjeUFnSUNNZ1kyRnVaR2xrWVhSbEozTWdRV3huYjNKaGJtUWdZV1JrY21WemN5QW9jM1J5YVc1bktRb2dJQ0FnTHk4Z0t5QmlJbndpQ2lBZ0lDQXZMeUFySUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nSUNBZ0lDQWdJQ01nYVhOemRXVnlKM01nTXpJdFlubDBaU0JoWkdSeVpYTnpDaUFnSUNBdkx5QXJJR0lpZkNJS0lDQWdJQzh2SUNzZ1kzVnljbVZ1ZEY5MGFXMWxJQ0FnSUNBZ0lDQWdJQ0FnSXlBNExXSjVkR1VnZEdsdFpYTjBZVzF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QXJJR0lpZkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM1l3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOREF0TkRVS0lDQWdJQzh2SUdOaGJtUnBaR0YwWlY5aFpHUnlaWE56TG1KNWRHVnpJQ0FnSXlCallXNWthV1JoZEdVbmN5QkJiR2R2Y21GdVpDQmhaR1J5WlhOeklDaHpkSEpwYm1jcENpQWdJQ0F2THlBcklHSWlmQ0lLSUNBZ0lDOHZJQ3NnVkhodUxuTmxibVJsY2k1aWVYUmxjeUFnSUNBZ0lDQWdJeUJwYzNOMVpYSW5jeUF6TWkxaWVYUmxJR0ZrWkhKbGMzTUtJQ0FnSUM4dklDc2dZaUo4SWdvZ0lDQWdMeThnS3lCamRYSnlaVzUwWDNScGJXVWdJQ0FnSUNBZ0lDQWdJQ0FqSURndFlubDBaU0IwYVcxbGMzUmhiWEFLSUNBZ0lDOHZJQ3NnWWlKOElnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8wTUMwME5nb2dJQ0FnTHk4Z1kyRnVaR2xrWVhSbFgyRmtaSEpsYzNNdVlubDBaWE1nSUNBaklHTmhibVJwWkdGMFpTZHpJRUZzWjI5eVlXNWtJR0ZrWkhKbGMzTWdLSE4wY21sdVp5a0tJQ0FnSUM4dklDc2dZaUo4SWdvZ0lDQWdMeThnS3lCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUNBZ0lDQWdJQ0FqSUdsemMzVmxjaWR6SURNeUxXSjVkR1VnWVdSa2NtVnpjd29nSUNBZ0x5OGdLeUJpSW53aUNpQWdJQ0F2THlBcklHTjFjbkpsYm5SZmRHbHRaU0FnSUNBZ0lDQWdJQ0FnSUNNZ09DMWllWFJsSUhScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnS3lCaUlud2lDaUFnSUNBdkx5QXJJRzl5WjE5dVlXMWxMbUo1ZEdWeklDQWdJQ0FnSUNBZ0lDTWdiM0puSUc1aGJXVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdjMlZzWmk1a2IyTjFiV1Z1ZEhOYlpHOWpYMnRsZVYwZ1BTQmtiMk5mWkdGMFlRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExrUnZZM1Z0Wlc1MFZtVnlhV1pwWTJGMGFXOXVMblpsY21sbWVWOWtiMk4xYldWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWOWtiMk4xYldWdWREb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdSdlkxOXJaWGtnUFNCdmNDNXphR0V5TlRZb1pHOWpkVzFsYm5SZmFHRnphQzVpZVhSbGN5a0tJQ0FnSUhOb1lUSTFOZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnYVdZZ1pHOWpYMnRsZVNCdWIzUWdhVzRnYzJWc1ppNWtiMk4xYldWdWRITTZDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmtiMk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dkbVZ5YVdaNVgyUnZZM1Z0Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWs1UFZGOUdUMVZPUkNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTVOR1UwWmpVME5XWTBOalJtTlRVMFpUUTBDZ3AyWlhKcFpubGZaRzlqZFcxbGJuUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11ZG1Gc2FXUmhkR2x2Ymk1amIyNTBjbUZqZEM1RWIyTjFiV1Z1ZEZabGNtbG1hV05oZEdsdmJpNTJaWEpwWm5sZlpHOWpkVzFsYm5SQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZG1WeWFXWjVYMlJ2WTNWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJwWmlCa2IyTmZhMlY1SUdsdUlITmxiR1l1Y21WMmIydGxaRG9LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsZGlJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nZG1WeWFXWjVYMlJ2WTNWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsSkZWazlMUlVRaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdOelV5TkRVMU5qUm1OR0kwTlRRMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCMlpYSnBabmxmWkc5amRXMWxiblJmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRtRnNhV1JoZEdsdmJpNWpiMjUwY21GamRDNUViMk4xYldWdWRGWmxjbWxtYVdOaGRHbHZiaTUyWlhKcFpubGZaRzlqZFcxbGJuUkFNVEFLQ25abGNtbG1lVjlrYjJOMWJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8zTlMwM053b2dJQ0FnTHk4Z0l5QmpZVzVrYVdSaGRHVmZZV1JrY21WemN5QnBjeUJ6ZEc5eVpXUWdZWFFnZEdobElITjBZWEowTENCaVpXWnZjbVVnWm1seWMzUWdKM3duQ2lBZ0lDQXZMeUFqSUZkbElHTnZiWEJoY21VZ1lua2dZMmhsWTJ0cGJtY2dhV1lnWkc5algyUmhkR0VnYzNSaGNuUnpJSGRwZEdnZ1kyRnVaR2xrWVhSbFgyRmtaSEpsYzNNZ1lubDBaWE1nS3lBaWZDSUtJQ0FnSUM4dklHVjRjR1ZqZEdWa1gzQnlaV1pwZUNBOUlHTmhibVJwWkdGMFpWOWhaR1J5WlhOekxtSjVkR1Z6SUNzZ1lpSjhJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczWXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJSEJ5WldacGVGOXNaVzRnUFNCbGVIQmxZM1JsWkY5d2NtVm1hWGd1YkdWdVozUm9DaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnYVdZZ1pHOWpYMlJoZEdFdWJHVnVaM1JvSUR3Z2NISmxabWw0WDJ4bGJqb0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQndiM0FLSUNBZ0lENEtJQ0FnSUdKNklIWmxjbWxtZVY5a2IyTjFiV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pneENpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pOU1ZOTlFWUkRTQ0lwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBd09EUmtORGsxTXpSa05ERTFORFF6TkRnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUhabGNtbG1lVjlrYjJOMWJXVnVkRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1MllXeHBaR0YwYVc5dUxtTnZiblJ5WVdOMExrUnZZM1Z0Wlc1MFZtVnlhV1pwWTJGMGFXOXVMblpsY21sbWVWOWtiMk4xYldWdWRFQXhNQW9LZG1WeWFXWjVYMlJ2WTNWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJ6ZEc5eVpXUmZjSEpsWm1sNElEMGdiM0F1WlhoMGNtRmpkQ2hrYjJOZlpHRjBZU3dnVlVsdWREWTBLREFwTENCd2NtVm1hWGhmYkdWdUtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURVS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z2FXWWdjM1J2Y21Wa1gzQnlaV1pwZUNBOVBTQmxlSEJsWTNSbFpGOXdjbVZtYVhnNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhabGNtbG1lVjlrYjJOMWJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamcxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSldRVXhKUkNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTFOVFkwTVRSak5EazBOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdkbVZ5YVdaNVgyUnZZM1Z0Wlc1MFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblpoYkdsa1lYUnBiMjR1WTI5dWRISmhZM1F1Ukc5amRXMWxiblJXWlhKcFptbGpZWFJwYjI0dWRtVnlhV1o1WDJSdlkzVnRaVzUwUURFd0NncDJaWEpwWm5sZlpHOWpkVzFsYm5SZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWsxSlUwMUJWRU5JSWlrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01EQTROR1EwT1RVek5HUTBNVFUwTkRNME9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ2RtVnlhV1o1WDJSdlkzVnRaVzUwWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVSRzlqZFcxbGJuUldaWEpwWm1sallYUnBiMjR1ZG1WeWFXWjVYMlJ2WTNWdFpXNTBRREV3Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuWmhiR2xrWVhScGIyNHVZMjl1ZEhKaFkzUXVSRzlqZFcxbGJuUldaWEpwWm1sallYUnBiMjR1WjJWMFgyUnZZM1Z0Wlc1MFgyUmxkR0ZwYkhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWkc5amRXMWxiblJmWkdWMFlXbHNjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnWkc5algydGxlU0E5SUc5d0xuTm9ZVEkxTmloa2IyTjFiV1Z1ZEY5b1lYTm9MbUo1ZEdWektRb2dJQ0FnYzJoaE1qVTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG81TndvZ0lDQWdMeThnWVhOelpYSjBJR1J2WTE5clpYa2dhVzRnYzJWc1ppNWtiMk4xYldWdWRITXNJQ0pFYjJOMWJXVnVkQ0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prYjJNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdSRzlqZFcxbGJuUWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVpHOWpkVzFsYm5SelcyUnZZMTlyWlhsZENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUyWVd4cFpHRjBhVzl1TG1OdmJuUnlZV04wTGtSdlkzVnRaVzUwVm1WeWFXWnBZMkYwYVc5dUxtUnZZM1Z0Wlc1MFgyVjRhWE4wYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUnZZM1Z0Wlc1MFgyVjRhWE4wY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QmtiMk5mYTJWNUlEMGdiM0F1YzJoaE1qVTJLR1J2WTNWdFpXNTBYMmhoYzJndVlubDBaWE1wQ2lBZ0lDQnphR0V5TlRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlHUnZZMTlyWlhrZ2FXNGdjMlZzWmk1a2IyTjFiV1Z1ZEhNS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Sdll5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVFYjJOMWJXVnVkRlpsY21sbWFXTmhkR2x2Ymk1eVpYWnZhMlZmWkc5amRXMWxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYWnZhMlZmWkc5amRXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1Ea0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URXlDaUFnSUNBdkx5QmtiMk5mYTJWNUlEMGdiM0F1YzJoaE1qVTJLR1J2WTNWdFpXNTBYMmhoYzJndVlubDBaWE1wQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdZWE56WlhKMElHUnZZMTlyWlhrZ2FXNGdjMlZzWmk1a2IyTjFiV1Z1ZEhNc0lDSkViMk4xYldWdWRDQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmtiMk1pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkViMk4xYldWdWRDQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnWVhOelpYSjBJR1J2WTE5clpYa2dibTkwSUdsdUlITmxiR1l1Y21WMmIydGxaQ3dnSWtGc2NtVmhaSGtnY21WMmIydGxaQ0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkpsZGlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUhKbGRtOXJaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z0t5QmlJbndpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TjJNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpOQzB4TXpVS0lDQWdJQzh2SUc5d0xtbDBiMklvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBDaUFnSUNBdkx5QXJJR0lpZkNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVE0wTFRFek5nb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tLSUNBZ0lDOHZJQ3NnWWlKOElnb2dJQ0FnTHk4Z0t5QnlaV0Z6YjI0dVlubDBaWE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TXpjS0lDQWdJQzh2SUNzZ1lpSjhJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGRqQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE16UXRNVE0zQ2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tRb2dJQ0FnTHk4Z0t5QmlJbndpQ2lBZ0lDQXZMeUFySUhKbFlYTnZiaTVpZVhSbGN3b2dJQ0FnTHk4Z0t5QmlJbndpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpPQW9nSUNBZ0x5OGdLeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNelF0TVRNNENpQWdJQ0F2THlCdmNDNXBkRzlpS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLUW9nSUNBZ0x5OGdLeUJpSW53aUNpQWdJQ0F2THlBcklISmxZWE52Ymk1aWVYUmxjd29nSUNBZ0x5OGdLeUJpSW53aUNpQWdJQ0F2THlBcklGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFF3Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxkbTlyWldSYlpHOWpYMnRsZVYwZ1BTQnlaWFp2YTJWZlpHRjBZUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEE1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbUZzYVdSaGRHbHZiaTVqYjI1MGNtRmpkQzVFYjJOMWJXVnVkRlpsY21sbWFXTmhkR2x2Ymk1cGMxOXlaWFp2YTJWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE5mY21WMmIydGxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFME13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCa2IyTmZhMlY1SUQwZ2IzQXVjMmhoTWpVMktHUnZZM1Z0Wlc1MFgyaGhjMmd1WW5sMFpYTXBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFME5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdSdlkxOXJaWGtnYVc0Z2MyVnNaaTV5WlhadmEyVmtDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnlaWFlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRRekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBSUJKZ1lCZkFOa2IyTURjbVYyQkJVZmZIVUZGUjk4ZFlBS0FBaE5TVk5OUVZSRFNERWJRUUE1TVJrVVJERVlSSUlHQkVqb0lvOEVOK2FKZmdUeVdJa1lCQkpIVEgwRU44Q2xXZ1RJNWlHQU5ob0FqZ1lBQ1FCakFPMEJFd0UwQVhnQU1Sa1VNUmdVRUVNMkdnRkpJbGtqQ0VzQkZSSkVOaG9DU1NKWkl3aExBUlVTUkRZYUEwa2lXU01JU3dFVkVrUlBBZ0VwU3dGUVNiMUZBUlJFS2s4Q1VMMUZBUlJFTWdjV1R3TW9VREVBVUNoUVRGQW9VRThDVUVzQnZFaS9Kd1N3SkVNaWdBQTJHZ0ZKSWxrakNFc0JGUkpFTmhvQ1NVNENTU0paSXdoTUZSSkVBVWtwVEZCSnZVVUJRQUFUZ0FzQUNVNVBWRjlHVDFWT1JDdE1VTEFrUXlwTEFsQzlSUUZCQUE2QUNRQUhVa1ZXVDB0RlJFTC80a3NDS0ZCSlJRWVZTVVVGU3dHOVNBMUJBQVVuQlVML3lra2lTd1c2U3dVU1FRQU1nQWNBQlZaQlRFbEVRdit6SndWQy82NDJHZ0ZKSWxrakNFc0JGUkpFQVNsTVVFbTlSUUZFdmtoSkZSWlhCZ0pNVUN0TVVMQWtRellhQVVraVdTTUlTd0VWRWtRQktVeFF2VVVCZ0FFQUlrOENWQ3RNVUxBa1F6WWFBVWtpV1NNSVN3RVZFa1EyR2dKSklsa2pDRXNCRlJKRVRBRXBTd0ZRdlVVQlJDcE1VRW05UlFFVVJESUhGaWhRVHdKUUtGQXhBRkJMQWJ4SXZ5Y0VzQ1JETmhvQlNTSlpJd2hMQVJVU1JBRXFURkM5UlFHQUFRQWlUd0pVSzB4UXNDUkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
