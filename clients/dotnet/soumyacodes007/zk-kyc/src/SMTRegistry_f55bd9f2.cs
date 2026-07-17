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

namespace Arc56.Generated.soumyacodes007.zk_kyc.SMTRegistry_f55bd9f2
{


    //
    // On-chain store for the Sparse Merkle Tree root.
    //
    public class SMTRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SMTRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize with the genesis SMT root (32 zero bytes = empty tree).
        ///</summary>
        /// <param name="initial_root"> </param>
        public async Task Create(byte[] initial_root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 121, 53, 141 };
            var initial_rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); initial_rootAbi.From(initial_root);

            var result = await base.CallApp(new List<object> { abiHandle, initial_rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(byte[] initial_root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 121, 53, 141 };
            var initial_rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); initial_rootAbi.From(initial_root);

            return await base.MakeTransactionList(new List<object> { abiHandle, initial_rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update SMT root. Issuer-only.
        ///Called after every credential issuance or revocation. 1 Algorand tx = all revocations reflected immediately.
        ///</summary>
        /// <param name="new_root"> </param>
        public async Task UpdateRoot(byte[] new_root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 1, 85, 133 };
            var new_rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_rootAbi.From(new_root);

            var result = await base.CallApp(new List<object> { abiHandle, new_rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRoot_Transactions(byte[] new_root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 1, 85, 133 };
            var new_rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_rootAbi.From(new_root);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return current SMT root for client-side SMT inclusion proof verification.
        ///</summary>
        public async Task<byte[]> GetRoot(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 103, 203, 2 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetRoot_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 103, 203, 2 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Algorand round at which root was last updated.
        ///</summary>
        public async Task<ulong> GetLastUpdatedRound(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 91, 88, 154 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetLastUpdatedRound_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 91, 88, 154 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Total root updates (audit counter).
        ///</summary>
        public async Task<ulong> GetUpdateCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 150, 116, 199 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUpdateCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 150, 116, 199 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer issuer role. Issuer-only.
        ///</summary>
        /// <param name="new_issuer"> </param>
        public async Task UpdateIssuer(Algorand.Address new_issuer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 188, 4, 14 };
            var new_issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_issuerAbi.From(new_issuer);

            var result = await base.CallApp(new List<object> { abiHandle, new_issuerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateIssuer_Transactions(Algorand.Address new_issuer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 188, 4, 14 };
            var new_issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_issuerAbi.From(new_issuer);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_issuerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU01UUmVnaXN0cnkiLCJkZXNjIjoiT24tY2hhaW4gc3RvcmUgZm9yIHRoZSBTcGFyc2UgTWVya2xlIFRyZWUgcm9vdC4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUgd2l0aCB0aGUgZ2VuZXNpcyBTTVQgcm9vdCAoMzIgemVybyBieXRlcyA9IGVtcHR5IHRyZWUpLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbml0aWFsX3Jvb3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3Jvb3QiLCJkZXNjIjoiVXBkYXRlIFNNVCByb290LiBJc3N1ZXItb25seS5cbkNhbGxlZCBhZnRlciBldmVyeSBjcmVkZW50aWFsIGlzc3VhbmNlIG9yIHJldm9jYXRpb24uIDEgQWxnb3JhbmQgdHggPSBhbGwgcmV2b2NhdGlvbnMgcmVmbGVjdGVkIGltbWVkaWF0ZWx5LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcm9vdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcm9vdCIsImRlc2MiOiJSZXR1cm4gY3VycmVudCBTTVQgcm9vdCBmb3IgY2xpZW50LXNpZGUgU01UIGluY2x1c2lvbiBwcm9vZiB2ZXJpZmljYXRpb24uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbGFzdF91cGRhdGVkX3JvdW5kIiwiZGVzYyI6IkFsZ29yYW5kIHJvdW5kIGF0IHdoaWNoIHJvb3Qgd2FzIGxhc3QgdXBkYXRlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91cGRhdGVfY291bnQiLCJkZXNjIjoiVG90YWwgcm9vdCB1cGRhdGVzIChhdWRpdCBjb3VudGVyKS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9pc3N1ZXIiLCJkZXNjIjoiVHJhbnNmZXIgaXNzdWVyIHJvbGUuIElzc3Vlci1vbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2lzc3VlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwMSwyNzldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGlzc3VlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OSwyNzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzc3VlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxhc3RfdXBkYXRlZF9yb3VuZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNtdF9yb290IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMiwyNTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVwZGF0ZV9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTEsMTgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4LDE5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlhWE56ZFdWeUlpQWlkWEJrWVhSbFgyTnZkVzUwSWlBaWMyMTBYM0p2YjNRaUlDSnNZWE4wWDNWd1pHRjBaV1JmY205MWJtUWlJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emJYUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUhObGJHWXVhWE56ZFdWeUlEMGdRV05qYjNWdWRDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBjM04xWlhJaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjEwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBMVEUxQ2lBZ0lDQXZMeUFqSUZOTlZDQnliMjkwSU9LQWxDQXpNaUJpZVhSbGN5QW9VRzl6Wldsa2IyNGdhR0Z6YUNCdlppQjBhR1VnWm5Wc2JDQjBjbVZsS1FvZ0lDQWdMeThnYzJWc1ppNXpiWFJmY205dmRDQTlJRUo1ZEdWektDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTnRkRjl5YjI5MElnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdGRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnYzJWc1ppNXNZWE4wWDNWd1pHRjBaV1JmY205MWJtUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbXhoYzNSZmRYQmtZWFJsWkY5eWIzVnVaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnRkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z2MyVnNaaTUxY0dSaGRHVmZZMjkxYm5RZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luVndaR0YwWlY5amIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzIxMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamtLSUNBZ0lDOHZJR05zWVhOeklGTk5WRkpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV4Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WkdFd01UVTFPRFVnTUhnd1pEWTNZMkl3TWlBd2VHVTBOV0kxT0RsaElEQjRaamc1TmpjMFl6Y2dNSGd5WTJKak1EUXdaU0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVjl5YjI5MEtHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmNtOXZkQ2dwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0puWlhSZmJHRnpkRjkxY0dSaGRHVmtYM0p2ZFc1a0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkxY0dSaGRHVmZZMjkxYm5Rb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsWDJsemMzVmxjaWhoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQjFjR1JoZEdWZmNtOXZkQ0JuWlhSZmNtOXZkQ0JuWlhSZmJHRnpkRjkxY0dSaGRHVmtYM0p2ZFc1a0lHZGxkRjkxY0dSaGRHVmZZMjkxYm5RZ2RYQmtZWFJsWDJsemMzVmxjZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM050ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzVDaUFnSUNBdkx5QmpiR0Z6Y3lCVFRWUlNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0dVM09UTTFPR1FnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvWW5sMFpWdGRLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpiWFJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VTAxVVVtVm5hWE4wY25rdVkzSmxZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM050ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnRkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z2MyVnNaaTVwYzNOMVpYSWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYzNOMVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdGRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnYzJWc1ppNXpiWFJmY205dmRDQTlJR2x1YVhScFlXeGZjbTl2ZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYzIxMFgzSnZiM1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM050ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lOQW9nSUNBZ0x5OGdjMlZzWmk1c1lYTjBYM1Z3WkdGMFpXUmZjbTkxYm1RZ1BTQkhiRzlpWVd3dWNtOTFibVFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbXhoYzNSZmRYQmtZWFJsWkY5eWIzVnVaQ0lLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiWFJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklITmxiR1l1ZFhCa1lYUmxYMk52ZFc1MElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjFjR1JoZEdWZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiWFJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpiWFJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VTAxVVVtVm5hWE4wY25rdWRYQmtZWFJsWDNKdmIzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVmZjbTl2ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YlhSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM050ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXBjM04xWlhJc0lDSlBibXg1SUdsemMzVmxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKcGMzTjFaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTnpkV1Z5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR2x6YzNWbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdGRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnYzJWc1ppNXpiWFJmY205dmRDQTlJRzVsZDE5eWIyOTBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpiWFJmY205dmRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyMTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCelpXeG1MbXhoYzNSZmRYQmtZWFJsWkY5eWIzVnVaQ0E5SUVkc2IySmhiQzV5YjNWdVpBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJHRnpkRjkxY0dSaGRHVmtYM0p2ZFc1a0lnb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdGRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnYzJWc1ppNTFjR1JoZEdWZlkyOTFiblFnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZFhCa1lYUmxYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ3WkdGMFpWOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMWNHUmhkR1ZmWTI5MWJuUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnRkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjEwWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGxOTlZGSmxaMmx6ZEhKNUxtZGxkRjl5YjI5MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNKdmIzUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyMTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXpiWFJmY205dmRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5OdGRGOXliMjkwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTnRkRjl5YjI5MElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM050ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emJYUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVVMDFVVW1WbmFYTjBjbmt1WjJWMFgyeGhjM1JmZFhCa1lYUmxaRjl5YjNWdVpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5c1lYTjBYM1Z3WkdGMFpXUmZjbTkxYm1RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzIxMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1c1lYTjBYM1Z3WkdGMFpXUmZjbTkxYm1RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pzWVhOMFgzVndaR0YwWldSZmNtOTFibVFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHRnpkRjkxY0dSaGRHVmtYM0p2ZFc1a0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM050ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTnRkRjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVUVFZSU1pXZHBjM1J5ZVM1blpYUmZkWEJrWVhSbFgyTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM1Z3WkdGMFpWOWpiM1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YlhSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5Wd1pHRjBaVjlqYjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5Wd1pHRjBaVjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUxY0dSaGRHVmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjEwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyMTBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMbE5OVkZKbFoybHpkSEo1TG5Wd1pHRjBaVjlwYzNOMVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVmZhWE56ZFdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdGRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emJYUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YVhOemRXVnlMQ0FpVDI1c2VTQnBjM04xWlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhWE56ZFdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx6YzNWbGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCcGMzTjFaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiWFJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklITmxiR1l1YVhOemRXVnlJRDBnYm1WM1gybHpjM1ZsY2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOemRXVnlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiWFJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFQ0pnVUdhWE56ZFdWeURIVndaR0YwWlY5amIzVnVkQWh6YlhSZmNtOXZkQkpzWVhOMFgzVndaR0YwWldSZmNtOTFibVFFRlI5OGRURVlRQUFPS0RJRFp5cUFBR2NySW1jcEltY3hHUlJFTVJoQkFDdUNCUVRhQVZXRkJBMW55d0lFNUZ0WW1nVDRsblRIQkN5OEJBNDJHZ0NPQlFBdkFGa0FiQUI0QUlRQWdBU09lVFdOTmhvQWpnRUFBUUEyR2dGSklsa2tDRXNCRlJKRVZ3SUFLREVBWnlwTVp5c3lCbWNwSW1jalF6WWFBVWtpV1NRSVN3RVZFa1JYQWdBeEFDSW9aVVFTUkNwTVp5c3lCbWNpS1dWRUl3Z3BUR2NqUXlJcVpVUkpGUlpYQmdKTVVDY0VURkN3STBNaUsyVkVGaWNFVEZDd0kwTWlLV1ZFRmljRVRGQ3dJME0yR2dGSkZZRWdFa1F4QUNJb1pVUVNSQ2hNWnlORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
