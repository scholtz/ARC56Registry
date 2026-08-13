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

namespace Arc56.Generated.Peaktolerance.algodiff.DiffRegistry_61ddcc2e
{


    //
    // 
    //    AlgoDiff — Verifiable Git Contributions Smart Contract
    //    Records and verifies cryptographic diff fingerprints on Algorand TestNet using Box Storage.
    //    
    //
    public class DiffRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DiffRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Registers a cryptographic contribution proof on Algorand Box Storage.
        ///</summary>
        /// <param name="diff_id"> </param>
        /// <param name="repo_id"> </param>
        /// <param name="from_commit"> </param>
        /// <param name="to_commit"> </param>
        /// <param name="diff_hash"> </param>
        public async Task<string> RegisterDiff(byte[] diff_id, string repo_id, string from_commit, string to_commit, string diff_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 247, 0, 108 };
            var diff_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); diff_idAbi.From(diff_id);
            var repo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); repo_idAbi.From(repo_id);
            var from_commitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); from_commitAbi.From(from_commit);
            var to_commitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); to_commitAbi.From(to_commit);
            var diff_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); diff_hashAbi.From(diff_hash);

            var result = await base.CallApp(new List<object> { abiHandle, diff_idAbi, repo_idAbi, from_commitAbi, to_commitAbi, diff_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterDiff_Transactions(byte[] diff_id, string repo_id, string from_commit, string to_commit, string diff_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 247, 0, 108 };
            var diff_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); diff_idAbi.From(diff_id);
            var repo_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); repo_idAbi.From(repo_id);
            var from_commitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); from_commitAbi.From(from_commit);
            var to_commitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); to_commitAbi.From(to_commit);
            var diff_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); diff_hashAbi.From(diff_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, diff_idAbi, repo_idAbi, from_commitAbi, to_commitAbi, diff_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the registered contribution proof record for a given diff_id.
        ///</summary>
        /// <param name="diff_id"> </param>
        public async Task<string> GetDiff(byte[] diff_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 169, 159, 247 };
            var diff_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); diff_idAbi.From(diff_id);

            var result = await base.SimApp(new List<object> { abiHandle, diff_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetDiff_Transactions(byte[] diff_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 169, 159, 247 };
            var diff_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); diff_idAbi.From(diff_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, diff_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verifies if the stored on-chain hash for diff_id matches the provided diff_hash.
        ///</summary>
        /// <param name="diff_id"> </param>
        /// <param name="diff_hash"> </param>
        public async Task<bool> VerifyDiff(byte[] diff_id, string diff_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 139, 218, 211 };
            var diff_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); diff_idAbi.From(diff_id);
            var diff_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); diff_hashAbi.From(diff_hash);

            var result = await base.SimApp(new List<object> { abiHandle, diff_idAbi, diff_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyDiff_Transactions(byte[] diff_id, string diff_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 139, 218, 211 };
            var diff_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); diff_idAbi.From(diff_id);
            var diff_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); diff_hashAbi.From(diff_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, diff_idAbi, diff_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlmZlJlZ2lzdHJ5IiwiZGVzYyI6IlxuICAgIEFsZ29EaWZmIOKAlCBWZXJpZmlhYmxlIEdpdCBDb250cmlidXRpb25zIFNtYXJ0IENvbnRyYWN0XG4gICAgUmVjb3JkcyBhbmQgdmVyaWZpZXMgY3J5cHRvZ3JhcGhpYyBkaWZmIGZpbmdlcnByaW50cyBvbiBBbGdvcmFuZCBUZXN0TmV0IHVzaW5nIEJveCBTdG9yYWdlLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWdpc3Rlcl9kaWZmIiwiZGVzYyI6IlJlZ2lzdGVycyBhIGNyeXB0b2dyYXBoaWMgY29udHJpYnV0aW9uIHByb29mIG9uIEFsZ29yYW5kIEJveCBTdG9yYWdlLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaWZmX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBvX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tX2NvbW1pdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9fY29tbWl0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaWZmX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZGlmZiIsImRlc2MiOiJSZXRyaWV2ZXMgdGhlIHJlZ2lzdGVyZWQgY29udHJpYnV0aW9uIHByb29mIHJlY29yZCBmb3IgYSBnaXZlbiBkaWZmX2lkLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaWZmX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfZGlmZiIsImRlc2MiOiJWZXJpZmllcyBpZiB0aGUgc3RvcmVkIG9uLWNoYWluIGhhc2ggZm9yIGRpZmZfaWQgbWF0Y2hlcyB0aGUgcHJvdmlkZWQgZGlmZl9oYXNoLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaWZmX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaWZmX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1MF0sImVycm9yTWVzc2FnZSI6IkNvbnRyaWJ1dGlvbiBwcm9vZiBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjVdLCJlcnJvck1lc3NhZ2UiOiJQcm9vZiBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OSw4NSwxMDEsMTE3LDEzMywyMTMsMjQ1LDI2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2LDkyLDEwOCwxMjQsMTQwLDIyMCwyNTIsMjY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElnTVFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURkaklEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1ptWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBDaUFnSUNBdkx5QmpiR0Z6Y3lCRWFXWm1VbVZuYVhOMGNua29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXlDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pZMlkzTURBMll5QXdlRE15WVRrNVptWTNJREI0WlRRNFltUmhaRE1nTHk4Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2w5a2FXWm1LR0o1ZEdWYlhTeHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJmWkdsbVppaGllWFJsVzEwcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxmWkdsbVppaGllWFJsVzEwc2MzUnlhVzVuS1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J5WldkcGMzUmxjbDlrYVdabUlHZGxkRjlrYVdabUlIWmxjbWxtZVY5a2FXWm1DaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGtScFptWlNaV2RwYzNSeWVTNXlaV2RwYzNSbGNsOWthV1ptVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm5hWE4wWlhKZlpHbG1aam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdabVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWm1aZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNelV0TXpZS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYVdZZ1ltOTRJR0ZzY21WaFpIa2daWGhwYzNSekNpQWdJQ0F2THlCaWIzaGZaR0YwWVN3Z1pYaHBjM1J6SUQwZ2IzQXVRbTk0TG1kbGRDaGthV1ptWDJsa0tRb2dJQ0FnWkdsbklEUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFptWmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TXpjS0lDQWdJQzh2SUdsbUlHVjRhWE4wY3pvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiMjUwY21saWRYUnBiMjRnY0hKdmIyWWdZV3h5WldGa2VTQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xtWmw5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBNQzAwTWdvZ0lDQWdMeThnSXlCRGIyNXpkSEoxWTNRZ2MyVnlhV0ZzYVhwbFpDQnlaV052Y21RZ2MzUnlhVzVuT2dvZ0lDQWdMeThnSXlCeVpYQnZYMmxrZkdaeWIyMWZZMjl0YldsMGZIUnZYMk52YlcxcGRIeGthV1ptWDJoaGMyaDhjM1ZpYldsMGRHVnlmSFJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMlZ1WkdWeVgzTjBjaUE5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1ptWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUTBMVFExQ2lBZ0lDQXZMeUJ5WlhCdlgybGtMbUo1ZEdWekNpQWdJQ0F2THlBcklFSjVkR1Z6S0dJaWZDSXBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5a2FXWm1YM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlBcklFSjVkR1Z6S0dJaWZDSXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROMk1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdabVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalEwTFRRMUNpQWdJQ0F2THlCeVpYQnZYMmxrTG1KNWRHVnpDaUFnSUNBdkx5QXJJRUo1ZEdWektHSWlmQ0lwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5a2FXWm1YM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRMExUUTJDaUFnSUNBdkx5QnlaWEJ2WDJsa0xtSjVkR1Z6Q2lBZ0lDQXZMeUFySUVKNWRHVnpLR0lpZkNJcENpQWdJQ0F2THlBcklHWnliMjFmWTI5dGJXbDBMbUo1ZEdWekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFptWmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNZd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWm1aZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORFF0TkRjS0lDQWdJQzh2SUhKbGNHOWZhV1F1WW5sMFpYTUtJQ0FnSUM4dklDc2dRbmwwWlhNb1lpSjhJaWtLSUNBZ0lDOHZJQ3NnWm5KdmJWOWpiMjF0YVhRdVlubDBaWE1LSUNBZ0lDOHZJQ3NnUW5sMFpYTW9ZaUo4SWlrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBabVpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EUXRORGdLSUNBZ0lDOHZJSEpsY0c5ZmFXUXVZbmwwWlhNS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUM4dklDc2dabkp2YlY5amIyMXRhWFF1WW5sMFpYTUtJQ0FnSUM4dklDc2dRbmwwWlhNb1lpSjhJaWtLSUNBZ0lDOHZJQ3NnZEc5ZlkyOXRiV2wwTG1KNWRHVnpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBabVpmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklDc2dRbmwwWlhNb1lpSjhJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczWXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFptWmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRRdE5Ea0tJQ0FnSUM4dklISmxjRzlmYVdRdVlubDBaWE1LSUNBZ0lDOHZJQ3NnUW5sMFpYTW9ZaUo4SWlrS0lDQWdJQzh2SUNzZ1puSnZiVjlqYjIxdGFYUXVZbmwwWlhNS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUM4dklDc2dkRzlmWTI5dGJXbDBMbUo1ZEdWekNpQWdJQ0F2THlBcklFSjVkR1Z6S0dJaWZDSXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdabVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalEwTFRVd0NpQWdJQ0F2THlCeVpYQnZYMmxrTG1KNWRHVnpDaUFnSUNBdkx5QXJJRUo1ZEdWektHSWlmQ0lwQ2lBZ0lDQXZMeUFySUdaeWIyMWZZMjl0YldsMExtSjVkR1Z6Q2lBZ0lDQXZMeUFySUVKNWRHVnpLR0lpZkNJcENpQWdJQ0F2THlBcklIUnZYMk52YlcxcGRDNWllWFJsY3dvZ0lDQWdMeThnS3lCQ2VYUmxjeWhpSW53aUtRb2dJQ0FnTHk4Z0t5QmthV1ptWDJoaGMyZ3VZbmwwWlhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WkdsbVpsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnS3lCQ2VYUmxjeWhpSW53aUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEZGpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xtWmw5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBOQzAxTVFvZ0lDQWdMeThnY21Wd2IxOXBaQzVpZVhSbGN3b2dJQ0FnTHk4Z0t5QkNlWFJsY3loaUlud2lLUW9nSUNBZ0x5OGdLeUJtY205dFgyTnZiVzFwZEM1aWVYUmxjd29nSUNBZ0x5OGdLeUJDZVhSbGN5aGlJbndpS1FvZ0lDQWdMeThnS3lCMGIxOWpiMjF0YVhRdVlubDBaWE1LSUNBZ0lDOHZJQ3NnUW5sMFpYTW9ZaUo4SWlrS0lDQWdJQzh2SUNzZ1pHbG1abDlvWVhOb0xtSjVkR1Z6Q2lBZ0lDQXZMeUFySUVKNWRHVnpLR0lpZkNJcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1ptWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUTBMVFV5Q2lBZ0lDQXZMeUJ5WlhCdlgybGtMbUo1ZEdWekNpQWdJQ0F2THlBcklFSjVkR1Z6S0dJaWZDSXBDaUFnSUNBdkx5QXJJR1p5YjIxZlkyOXRiV2wwTG1KNWRHVnpDaUFnSUNBdkx5QXJJRUo1ZEdWektHSWlmQ0lwQ2lBZ0lDQXZMeUFySUhSdlgyTnZiVzFwZEM1aWVYUmxjd29nSUNBZ0x5OGdLeUJDZVhSbGN5aGlJbndpS1FvZ0lDQWdMeThnS3lCa2FXWm1YMmhoYzJndVlubDBaWE1LSUNBZ0lDOHZJQ3NnUW5sMFpYTW9ZaUo4SWlrS0lDQWdJQzh2SUNzZ2MyVnVaR1Z5WDNOMGNnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xtWmw5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdLeUJDZVhSbGN5aGlJbndpS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURkakNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbG1abDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME5DMDFNd29nSUNBZ0x5OGdjbVZ3YjE5cFpDNWllWFJsY3dvZ0lDQWdMeThnS3lCQ2VYUmxjeWhpSW53aUtRb2dJQ0FnTHk4Z0t5Qm1jbTl0WDJOdmJXMXBkQzVpZVhSbGN3b2dJQ0FnTHk4Z0t5QkNlWFJsY3loaUlud2lLUW9nSUNBZ0x5OGdLeUIwYjE5amIyMXRhWFF1WW5sMFpYTUtJQ0FnSUM4dklDc2dRbmwwWlhNb1lpSjhJaWtLSUNBZ0lDOHZJQ3NnWkdsbVpsOW9ZWE5vTG1KNWRHVnpDaUFnSUNBdkx5QXJJRUo1ZEdWektHSWlmQ0lwQ2lBZ0lDQXZMeUFySUhObGJtUmxjbDl6ZEhJS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWm1aZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJQ3NnYjNBdWFYUnZZaWhIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1ptWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUTBMVFUwQ2lBZ0lDQXZMeUJ5WlhCdlgybGtMbUo1ZEdWekNpQWdJQ0F2THlBcklFSjVkR1Z6S0dJaWZDSXBDaUFnSUNBdkx5QXJJR1p5YjIxZlkyOXRiV2wwTG1KNWRHVnpDaUFnSUNBdkx5QXJJRUo1ZEdWektHSWlmQ0lwQ2lBZ0lDQXZMeUFySUhSdlgyTnZiVzFwZEM1aWVYUmxjd29nSUNBZ0x5OGdLeUJDZVhSbGN5aGlJbndpS1FvZ0lDQWdMeThnS3lCa2FXWm1YMmhoYzJndVlubDBaWE1LSUNBZ0lDOHZJQ3NnUW5sMFpYTW9ZaUo4SWlrS0lDQWdJQzh2SUNzZ2MyVnVaR1Z5WDNOMGNnb2dJQ0FnTHk4Z0t5QkNlWFJsY3loaUlud2lLUW9nSUNBZ0x5OGdLeUJ2Y0M1cGRHOWlLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xtWmw5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFOeTAxT0FvZ0lDQWdMeThnSXlCVGRHOXlaU0JwYmlCQmJHZHZjbUZ1WkNCQ2IzZ2dVM1J2Y21GblpRb2dJQ0FnTHk4Z2IzQXVRbTk0TG5CMWRDaGthV1ptWDJsa0xDQnlaV052Y21SZmRtRnNkV1VwQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbG1abDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TVRBMU1EVXlOR1kwWmpRMk5XWTFNalExTkRjME9UVXpOVFEwTlRVeU5EVTBOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVJHbG1abEpsWjJsemRISjVMbWRsZEY5a2FXWm1XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyUnBabVk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WkdsbVpsOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWm1aZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJR0p2ZUY5a1lYUmhMQ0JsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0dScFptWmZhV1FwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbG1abDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjeXdnSWxCeWIyOW1JRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFjbTl2WmlCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5a2FXWm1YM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1F1UkdsbVpsSmxaMmx6ZEhKNUxuWmxjbWxtZVY5a2FXWm1XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVYMlJwWm1ZNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbG1abDl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1ptWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QmliM2hmWkdGMFlTd2daWGhwYzNSeklEMGdiM0F1UW05NExtZGxkQ2hrYVdabVgybGtLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFptWmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUdsbUlHNXZkQ0JsZUdsemRITTZDaUFnSUNCaWJub2dkbVZ5YVdaNVgyUnBabVpmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCd2IzQnVJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdabVgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdSbUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwMlpYSnBabmxmWkdsbVpsOWhablJsY2w5cGJteHBibVZrWDJOdmJuUnlZV04wTGtScFptWlNaV2RwYzNSeWVTNTJaWEpwWm5sZlpHbG1aa0EwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFptWmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2RtVnlhV1o1WDJScFptWmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NuWmxjbWxtZVY5a2FXWm1YM2RvYVd4bFgzUnZjRUEyT2dvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ1BEMEtJQ0FnSUdKNklIWmxjbWxtZVY5a2FXWm1YMkZtZEdWeVgzZG9hV3hsUURFd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pHbG5JRE1LSUNBZ0lEMDlDaUFnSUNCaWVpQjJaWEpwWm5sZlpHbG1abDloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUhCdmNHNGdNd29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1ptWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdkbVZ5YVdaNVgyUnBabVpmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRDNUVhV1ptVW1WbmFYTjBjbmt1ZG1WeWFXWjVYMlJwWm1aQU5Bb0tkbVZ5YVdaNVgyUnBabVpmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnZG1WeWFXWjVYMlJwWm1aZmQyaHBiR1ZmZEc5d1FEWUtDblpsY21sbWVWOWthV1ptWDJGbWRHVnlYM2RvYVd4bFFERXdPZ29nSUNBZ2NHOXdiaUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWm1aZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUIyWlhKcFpubGZaR2xtWmw5aFpuUmxjbDlwYm14cGJtVmtYMk52Ym5SeVlXTjBMa1JwWm1aU1pXZHBjM1J5ZVM1MlpYSnBabmxmWkdsbVprQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBSUJKZ0lCZkFRVkgzeDFNUnRCQUNReEdSUkVNUmhFZ2dNRVBQY0FiQVF5cVovM0JPU0wydE0yR2dDT0F3QUpBSmtBdVFBeEdSUXhHQlFRUXpZYUFVa2lXU01JU3dFVkVrUlhBZ0EyR2dKSklsa2pDRXNCRlJKRVZ3SUFOaG9EU1NKWkl3aExBUlVTUkZjQ0FEWWFCRWtpV1NNSVN3RVZFa1JYQWdBMkdnVkpJbGtqQ0VzQkZSSkVWd0lBU3dTOVJRRVVSREVBVHdRb1VFOEVVQ2hRVHdOUUtGQlBBbEFvVUV4UUtGQXlCeFpRdjRBV0ZSOThkUUFRVUZKUFQwWmZVa1ZIU1ZOVVJWSkZSTEFrUXpZYUFVa2lXU01JU3dFVkVrUlhBZ0MrUkVrVkZsY0dBa3hRS1V4UXNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FEWWFBa2tpV1NNSVN3RVZFa1JYQWdCTXZrQUFFRVlDSW9BQkFDSlBBbFFwVEZDd0pFTWlTd0lWU3dFSVNVc0RGUTVCQUJoTEFrc0NUd0pTU3dNU1FRQUdSZ01rUXYvUkpBaEMvOXBHQkNKQy84WT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
