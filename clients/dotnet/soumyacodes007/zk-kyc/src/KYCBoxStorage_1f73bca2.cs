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

namespace Arc56.Generated.soumyacodes007.zk_kyc.KYCBoxStorage_1f73bca2
{


    //
    // Box storage for ECIES-encrypted identity blobs keyed by nullifier.
    //
    public class KYCBoxStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public KYCBoxStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize — deployer becomes issuer.
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Store ECIES-encrypted identity blob. Issuer-only.
        ///encrypted_blob = ECIES.encrypt(identity, issuer_public_key) Generated in user's browser — zero PII transmitted to contract.
        ///</summary>
        /// <param name="nullifier"> </param>
        /// <param name="encrypted_blob"> </param>
        public async Task StoreBlob(byte[] nullifier, byte[] encrypted_blob, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 115, 122, 176 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);
            var encrypted_blobAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); encrypted_blobAbi.From(encrypted_blob);

            var result = await base.CallApp(new List<object> { abiHandle, nullifierAbi, encrypted_blobAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StoreBlob_Transactions(byte[] nullifier, byte[] encrypted_blob, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 115, 122, 176 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);
            var encrypted_blobAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); encrypted_blobAbi.From(encrypted_blob);

            return await base.MakeTransactionList(new List<object> { abiHandle, nullifierAbi, encrypted_blobAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve encrypted blob. Issuer-only.
        ///Backend decrypts with reconstructed Shamir issuer key during court order.
        ///</summary>
        /// <param name="nullifier"> </param>
        public async Task<byte[]> GetBlob(byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 181, 53, 138 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            var result = await base.CallApp(new List<object> { abiHandle, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetBlob_Transactions(byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 181, 53, 138 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete identity blob (DPDP Right to Erasure). Issuer-only.
        ///Called on full credential revocation.
        ///</summary>
        /// <param name="nullifier"> </param>
        public async Task DeleteBlob(byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 133, 222, 80 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            var result = await base.CallApp(new List<object> { abiHandle, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBlob_Transactions(byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 133, 222, 80 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check whether an encrypted blob exists for this nullifier.
        ///</summary>
        /// <param name="nullifier"> </param>
        public async Task<bool> HasBlob(byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 1, 104, 38 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            var result = await base.SimApp(new List<object> { abiHandle, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasBlob_Transactions(byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 1, 104, 38 };
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Total encrypted blobs currently stored.
        ///</summary>
        public async Task<ulong> GetTotalBlobs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 79, 170, 83 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalBlobs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 79, 170, 83 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS1lDQm94U3RvcmFnZSIsImRlc2MiOiJCb3ggc3RvcmFnZSBmb3IgRUNJRVMtZW5jcnlwdGVkIGlkZW50aXR5IGJsb2JzIGtleWVkIGJ5IG51bGxpZmllci4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUg4oCUIGRlcGxveWVyIGJlY29tZXMgaXNzdWVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdG9yZV9ibG9iIiwiZGVzYyI6IlN0b3JlIEVDSUVTLWVuY3J5cHRlZCBpZGVudGl0eSBibG9iLiBJc3N1ZXItb25seS5cbmVuY3J5cHRlZF9ibG9iID0gRUNJRVMuZW5jcnlwdChpZGVudGl0eSwgaXNzdWVyX3B1YmxpY19rZXkpIEdlbmVyYXRlZCBpbiB1c2VyJ3MgYnJvd3NlciDigJQgemVybyBQSUkgdHJhbnNtaXR0ZWQgdG8gY29udHJhY3QuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bGxpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5jcnlwdGVkX2Jsb2IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Jsb2IiLCJkZXNjIjoiUmV0cmlldmUgZW5jcnlwdGVkIGJsb2IuIElzc3Vlci1vbmx5LlxuQmFja2VuZCBkZWNyeXB0cyB3aXRoIHJlY29uc3RydWN0ZWQgU2hhbWlyIGlzc3VlciBrZXkgZHVyaW5nIGNvdXJ0IG9yZGVyLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudWxsaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfYmxvYiIsImRlc2MiOiJEZWxldGUgaWRlbnRpdHkgYmxvYiAoRFBEUCBSaWdodCB0byBFcmFzdXJlKS4gSXNzdWVyLW9ubHkuXG5DYWxsZWQgb24gZnVsbCBjcmVkZW50aWFsIHJldm9jYXRpb24uIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bGxpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoYXNfYmxvYiIsImRlc2MiOiJDaGVjayB3aGV0aGVyIGFuIGVuY3J5cHRlZCBibG9iIGV4aXN0cyBmb3IgdGhpcyBudWxsaWZpZXIuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bGxpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9ibG9icyIsImRlc2MiOiJUb3RhbCBlbmNyeXB0ZWQgYmxvYnMgY3VycmVudGx5IHN0b3JlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjI1LDI3M10sImVycm9yTWVzc2FnZSI6IkJsb2Igbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY0LDIxNywyNjVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGlzc3VlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MiwyMTUsMjYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc3N1ZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2LDI3OSwyODYsMzMyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9ibG9icyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzAsMTQ2LDE5OSwyNDcsMjk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3LDE1MywyMDYsMjU0LDMwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHOTBZV3hmWW14dlluTWlJQ0pwYzNOMVpYSWlJREI0TmpJMll6Wm1OakkxWmlBd2VERTFNV1kzWXpjMUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhM2xqWDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakUwQ2lBZ0lDQXZMeUJ6Wld4bUxtbHpjM1ZsY2lBOUlFRmpZMjkxYm5Rb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFYTnpkV1Z5SWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydDVZMTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlpYkc5aWN5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZllteHZZbk1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0NVkxOWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1Bb2dJQ0FnTHk4Z1kyeGhjM01nUzFsRFFtOTRVM1J2Y21GblpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFUyTnpNM1lXSXdJREI0Tm1OaU5UTTFPR0VnTUhnek16ZzFaR1UxTUNBd2VHUTJNREUyT0RJMklEQjROV0kwWm1GaE5UTWdMeThnYldWMGFHOWtJQ0p6ZEc5eVpWOWliRzlpS0dKNWRHVmJYU3hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYMkpzYjJJb1lubDBaVnRkS1dKNWRHVmJYU0lzSUcxbGRHaHZaQ0FpWkdWc1pYUmxYMkpzYjJJb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWhoYzE5aWJHOWlLR0o1ZEdWYlhTbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUmZkRzkwWVd4ZllteHZZbk1vS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhOMGIzSmxYMkpzYjJJZ1oyVjBYMkpzYjJJZ1pHVnNaWFJsWDJKc2IySWdhR0Z6WDJKc2IySWdaMlYwWDNSdmRHRnNYMkpzYjJKekNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEzbGpYMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXdDaUFnSUNBdkx5QmpiR0Z6Y3lCTFdVTkNiM2hUZEc5eVlXZGxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6VmpOakZpWVNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG10NVkxOWliM2hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVMV1VOQ2IzaFRkRzl5WVdkbExtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyZVdOZlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJS0lDQWdJQzh2SUhObGJHWXVhWE56ZFdWeUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlhWE56ZFdWeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyZVdOZlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZllteHZZbk1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMkpzYjJKeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTNsalgySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWEzbGpYMkp2ZUY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGt0WlEwSnZlRk4wYjNKaFoyVXVjM1J2Y21WZllteHZZbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMGIzSmxYMkpzYjJJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTNsalgySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhM2xqWDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbWx6YzNWbGNpd2dJazl1YkhrZ2FYTnpkV1Z5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltbHpjM1ZsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBjM04xWlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnYVhOemRXVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEzbGpYMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qTXpDaUFnSUNBdkx5QnBjMTl1WlhjZ1BTQnVkV3hzYVdacFpYSWdibTkwSUdsdUlITmxiR1l1WW14dlluTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJNalpqTm1ZMk1qVm1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJlV05mWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNelFLSUNBZ0lDOHZJSE5sYkdZdVlteHZZbk5iYm5Wc2JHbG1hV1Z5WFNBOUlHVnVZM0o1Y0hSbFpGOWliRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhM2xqWDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJwWmlCcGMxOXVaWGM2Q2lBZ0lDQmlibm9nYzNSdmNtVmZZbXh2WWw5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJlV05mWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNellLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWW14dlluTWdLejBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZllteHZZbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWW14dlluTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZllteHZZbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2MzUnZjbVZmWW14dllsOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTNsalgySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXJlV05mWW05NFgzTjBiM0poWjJVdVkyOXVkSEpoWTNRdVMxbERRbTk0VTNSdmNtRm5aUzVuWlhSZllteHZZbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWliRzlpT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnQ1WTE5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTNsalgySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1semMzVmxjaXdnSWs5dWJIa2dhWE56ZFdWeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWx6YzNWbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzNOMVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2FYTnpkV1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhM2xqWDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJoYzNObGNuUWdiblZzYkdsbWFXVnlJR2x1SUhObGJHWXVZbXh2WW5Nc0lDSkNiRzlpSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMk1qWmpObVkyTWpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbXh2WWlCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlyZVdOZlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnNiMkp6VzI1MWJHeHBabWxsY2wwS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0NVkxOWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtdDVZMTlpYjNoZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1TFdVTkNiM2hUZEc5eVlXZGxMbVJsYkdWMFpWOWliRzlpVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsWDJKc2IySTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEzbGpYMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJlV05mWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVhWE56ZFdWeUxDQWlUMjVzZVNCcGMzTjFaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFYTnpkV1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHpjM1ZsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JwYzNOMVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cmVXTmZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCdWRXeHNhV1pwWlhJZ2FXNGdjMlZzWmk1aWJHOWljeXdnSWtKc2IySWdibTkwSUdadmRXNWtJZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFl5Tm1NMlpqWXlOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2JHOWlJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwydDVZMTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdaR1ZzSUhObGJHWXVZbXh2WW5OYmJuVnNiR2xtYVdWeVhRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEzbGpYMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QnBaaUJ6Wld4bUxuUnZkR0ZzWDJKc2IySnpJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gySnNiMkp6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJKc2IySnpJR1Y0YVhOMGN3b2dJQ0FnWW5vZ1pHVnNaWFJsWDJKc2IySmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTNsalgySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gySnNiMkp6SUMwOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMkpzYjJKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gySnNiMkp6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMkpzYjJKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbVJsYkdWMFpWOWliRzlpWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJlV05mWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG10NVkxOWliM2hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVMV1VOQ2IzaFRkRzl5WVdkbExtaGhjMTlpYkc5aVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thR0Z6WDJKc2IySTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEzbGpYMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YTNsalgySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCeVpYUjFjbTRnYm5Wc2JHbG1hV1Z5SUdsdUlITmxiR1l1WW14dlluTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJNalpqTm1ZMk1qVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ0NVkxOWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbXQ1WTE5aWIzaGZjM1J2Y21GblpTNWpiMjUwY21GamRDNUxXVU5DYjNoVGRHOXlZV2RsTG1kbGRGOTBiM1JoYkY5aWJHOWljMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTBiM1JoYkY5aWJHOWljem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXJlV05mWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5SdmRHRnNYMkpzYjJKekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZZbXh2WW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZllteHZZbk1nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmEzbGpYMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUNKZ1FMZEc5MFlXeGZZbXh2WW5NR2FYTnpkV1Z5QldKc2IySmZCQlVmZkhVeEdFQUFCeWt5QTJjb0ltY3hHUlJFTVJoQkFDdUNCUVJXYzNxd0JHeTFOWW9FTTRYZVVBVFdBV2dtQkZ0UHFsTTJHZ0NPQlFBWUFGMEFqUURCQU9RQWdBUk1YR0c2TmhvQWpnRUFBUUFwTVFCbktDSm5JME0yR2dGSklsa2tDRXNCRlJKRVZ3SUFOaG9DU1NKWkpBaExBUlVTUkZjQ0FERUFJaWxsUkJKRUtrOENVRW05VGdKSVNieElUd0svUUFBSklpaGxSQ01JS0V4bkkwTTJHZ0ZKSWxra0NFc0JGUkpFVndJQU1RQWlLV1ZFRWtRcVRGQkp2VVVCUkw1SVNSVVdWd1lDVEZBclRGQ3dJME0yR2dGSklsa2tDRXNCRlJKRVZ3SUFNUUFpS1dWRUVrUXFURkJKdlVVQlJMeElJaWhsUkVFQUNTSW9aVVFqQ1NoTVp5TkROaG9CU1NKWkpBaExBUlVTUkZjQ0FDcE1VTDFGQVlBQkFDSlBBbFFyVEZDd0kwTWlLR1ZFRml0TVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
