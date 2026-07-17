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

namespace Arc56.Generated.sh2900.zk_digi_web.Vault_95a84c67
{


    //
    // Vault Smart Contract
    //
    //Algorand Box Storage for document hash management.
    //
    public class VaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task Initialize(byte[] admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 234, 10, 207 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(byte[] admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 234, 10, 207 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a document hash to the user's vault
        ///</summary>
        /// <param name="docType"> </param>
        /// <param name="docHash"> </param>
        public async Task<bool> AddDocument(byte[] docType, byte[] docHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 41, 39, 232 };
            var docTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); docTypeAbi.From(docType);
            var docHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); docHashAbi.From(docHash);

            var result = await base.CallApp(new List<object> { abiHandle, docTypeAbi, docHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddDocument_Transactions(byte[] docType, byte[] docHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 41, 39, 232 };
            var docTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); docTypeAbi.From(docType);
            var docHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); docHashAbi.From(docHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, docTypeAbi, docHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all document hashes for a wallet
        ///</summary>
        public async Task<byte[]> GetDocuments(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 66, 183, 91 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetDocuments_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 66, 183, 91 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify a document hash exists in the vault
        ///</summary>
        /// <param name="docHash"> </param>
        public async Task<bool> VerifyDocument(byte[] docHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 198, 163, 168 };
            var docHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); docHashAbi.From(docHash);

            var result = await base.CallApp(new List<object> { abiHandle, docHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyDocument_Transactions(byte[] docHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 198, 163, 168 };
            var docHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); docHashAbi.From(docHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, docHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetDocumentCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 59, 96, 8 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDocumentCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 59, 96, 8 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task TransferOwnership(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 61, 74, 21 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(byte[] newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 61, 74, 21 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmF1bHQiLCJkZXNjIjoiVmF1bHQgU21hcnQgQ29udHJhY3RcblxuQWxnb3JhbmQgQm94IFN0b3JhZ2UgZm9yIGRvY3VtZW50IGhhc2ggbWFuYWdlbWVudC4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGREb2N1bWVudCIsImRlc2MiOiJBZGQgYSBkb2N1bWVudCBoYXNoIHRvIHRoZSB1c2VyJ3MgdmF1bHQiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jVHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXREb2N1bWVudHMiLCJkZXNjIjoiR2V0IGFsbCBkb2N1bWVudCBoYXNoZXMgZm9yIGEgd2FsbGV0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5RG9jdW1lbnQiLCJkZXNjIjoiVmVyaWZ5IGEgZG9jdW1lbnQgaGFzaCBleGlzdHMgaW4gdGhlIHZhdWx0IiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRvY0hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RG9jdW1lbnRDb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyT3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjEwLDI3NywzMTldLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTAsMTc3LDE5MywyOTgsMzg5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3LDE4NCwyMDAsMzA0LDM5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRElnTVRBS0lDQWdJR0o1ZEdWallteHZZMnNnSW1SdlkzTWlJREI0TXpBek1UTXlNek16TkRNMU16WXpOek00TXprZ0ltOGlJQ0o4SWlBd2VERTFNV1kzWXpjMU9EQWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGWmhkV3gwSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXpDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1ZqWldFd1lXTm1JREI0WmpReU9USTNaVGdnTUhoall6UXlZamMxWWlBd2VETmxZelpoTTJFNElEQjROVFF6WWpZd01EZ2dNSGhtTWpOa05HRXhOU0F2THlCdFpYUm9iMlFnSW1sdWFYUnBZV3hwZW1Vb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZrWkVSdlkzVnRaVzUwS0dKNWRHVmJYU3hpZVhSbFcxMHBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBSRzlqZFcxbGJuUnpLQ2xpZVhSbFcxMGlMQ0J0WlhSb2IyUWdJblpsY21sbWVVUnZZM1Z0Wlc1MEtHSjVkR1ZiWFNsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSRWIyTjFiV1Z1ZEVOdmRXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlUM2R1WlhKemFHbHdLR0o1ZEdWYlhTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2FXNXBkR2xoYkdsNlpTQmhaR1JFYjJOMWJXVnVkQ0JuWlhSRWIyTjFiV1Z1ZEhNZ2RtVnlhV1o1Ukc5amRXMWxiblFnWjJWMFJHOWpkVzFsYm5SRGIzVnVkQ0IwY21GdWMyWmxjazkzYm1WeWMyaHBjQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCV1lYVnNkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2NIVjVZUzEwY3pvNmFYUnZZU2hwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwcGRHOWhPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk15QXZMeUF4TUFvZ0lDQWdQQW9nSUNBZ1lub2dhWFJ2WVY5bGJITmxYMkp2WkhsQU1nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VETXdNekV6TWpNek16UXpOVE0yTXpjek9ETTVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVjBjM1ZpQ2dwcGRHOWhYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEFLSUNBZ0lDOEtJQ0FnSUdOaGJHeHpkV0lnYVhSdllRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6TWdMeThnTVRBS0lDQWdJQ1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd6TURNeE16SXpNek0wTXpVek5qTTNNemd6T1FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBXWVhWc2RDNXBibWwwYVdGc2FYcGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1cGRHbGhiR2w2WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdjSFZpYkdsaklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tIc2dhMlY1T2lBbmJ5Y2dmU2tnSUNBZ0lDQWdJQ0FnSUM4dklHTnZiblJ5WVdOMElHOTNibVZ5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklIUm9hWE11YjNkdVpYSXVkbUZzZFdVZ1BTQmhaRzFwYmdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QndkV0pzYVdNZ2RtRjFiSFJEYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RqSnlCOUtTQWdJQ0F2THlCMGIzUmhiQ0IyWVhWc2RITUtJQ0FnSUhCMWMyaGllWFJsY3lBaVl5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUIwYUdsekxuWmhkV3gwUTI5MWJuUXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZtRjFiSFF1WVdSa1JHOWpkVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhaR1JFYjJOMWJXVnVkRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QndkV0pzYVdNZ1pHOWpkVzFsYm5SQ2IzZ2dQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUFuWkc5amN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJ2WTNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdZMjl1YzNRZ1pYaHBjM1JwYm1jZ1BTQjBhR2x6TG1SdlkzVnRaVzUwUW05NExuWmhiSFZsSUh4OElFSjVkR1Z6S0NjbktRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQnNaVzRLSUNBZ0lHSjZJR0ZrWkVSdlkzVnRaVzUwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFFLQ21Ga1pFUnZZM1Z0Wlc1MFgzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmpiMjV6ZENCMGFXMWxjM1JoYlhBZ1BTQkNlWFJsY3loSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMblJ2VTNSeWFXNW5LQ2twQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmpZV3hzYzNWaUlHbDBiMkVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCamIyNXpkQ0J1WlhkRWIyTWdQU0JrYjJOVWVYQmxMbU52Ym1OaGRDaENlWFJsY3lnbmZDY3BLUzVqYjI1allYUW9aRzlqU0dGemFDa3VZMjl1WTJGMEtFSjVkR1Z6S0NkOEp5a3BMbU52Ym1OaGRDaDBhVzFsYzNSaGJYQXBDaUFnSUNCa2FXY2dNd29nSUNBZ1lubDBaV05mTXlBdkx5QWlmQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWZDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z2FXWWdLR1Y0YVhOMGFXNW5MbXhsYm1kMGFDQTlQVDBnTUNrZ2V3b2dJQ0FnWkdsbklEUUtJQ0FnSUd4bGJnb2dJQ0FnWW01NklHRmtaRVJ2WTNWdFpXNTBYMlZzYzJWZlltOWtlVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdSdlkzVnRaVzUwUW05NElEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dKMlJ2WTNNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtiMk56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklIUm9hWE11Wkc5amRXMWxiblJDYjNndWRtRnNkV1VnUFNCdVpYZEViMk1LSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklIQjFZbXhwWXlCa2IyTjFiV1Z1ZEVKdmVDQTlJRUp2ZUR4aWVYUmxjejRvZXlCclpYazZJQ2RrYjJOekp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaRzlqY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QjBhR2x6TG1SdlkzVnRaVzUwUW05NExuWmhiSFZsSUQwZ2JtVjNSRzlqQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENncGhaR1JFYjJOMWJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGhaR1JFYjJOMWJXVnVkRjlsYkhObFgySnZaSGxBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QjBhR2x6TG1SdlkzVnRaVzUwUW05NExuWmhiSFZsSUQwZ1pYaHBjM1JwYm1jdVkyOXVZMkYwS0VKNWRHVnpLQ2NzSnlrcExtTnZibU5oZENodVpYZEViMk1wQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lzSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaRzlqZFcxbGJuUkNiM2dnUFNCQ2IzZzhZbmwwWlhNK0tIc2dhMlY1T2lBblpHOWpjeWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1SdlkzTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnZEdocGN5NWtiMk4xYldWdWRFSnZlQzUyWVd4MVpTQTlJR1Y0YVhOMGFXNW5MbU52Ym1OaGRDaENlWFJsY3lnbkxDY3BLUzVqYjI1allYUW9ibVYzUkc5aktRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnY0hWaWJHbGpJR1J2WTNWdFpXNTBRbTk0SUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0oyUnZZM01uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa2IyTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhSb2FYTXVaRzlqZFcxbGJuUkNiM2d1ZG1Gc2RXVWdQU0JsZUdsemRHbHVaeTVqYjI1allYUW9RbmwwWlhNb0p5d25LU2t1WTI5dVkyRjBLRzVsZDBSdll5a0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHSWdZV1JrUkc5amRXMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQTNDZ3BoWkdSRWIyTjFiV1Z1ZEY5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z1kyOXVjM1FnWlhocGMzUnBibWNnUFNCMGFHbHpMbVJ2WTNWdFpXNTBRbTk0TG5aaGJIVmxJSHg4SUVKNWRHVnpLQ2NuS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmlkWEo1SURRS0lDQWdJR0lnWVdSa1JHOWpkVzFsYm5SZmRHVnlibUZ5ZVY5dFpYSm5aVUEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xaaGRXeDBMbWRsZEVSdlkzVnRaVzUwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRVJ2WTNWdFpXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCd2RXSnNhV01nWkc5amRXMWxiblJDYjNnZ1BTQkNiM2c4WW5sMFpYTStLSHNnYTJWNU9pQW5aRzlqY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUnZZM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVaRzlqZFcxbGJuUkNiM2d1ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwV1lYVnNkQzUyWlhKcFpubEViMk4xYldWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVVUnZZM1Z0Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFpoZFd4MExtZGxkRVJ2WTNWdFpXNTBRMjkxYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJFYjJOMWJXVnVkRU52ZFc1ME9nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QndkV0pzYVdNZ1pHOWpkVzFsYm5SQ2IzZ2dQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUFuWkc5amN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVJ2WTNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZMjl1YzNRZ1pHOWpjeUE5SUhSb2FYTXVaRzlqZFcxbGJuUkNiM2d1ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHbG1JQ2hrYjJOekxteGxibWQwYUNBOVBUMGdNQ2tnY21WMGRYSnVJREFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCaWJub2daMlYwUkc5amRXMWxiblJEYjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlkWEo1SURFS0NtZGxkRVJ2WTNWdFpXNTBRMjkxYm5SZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZtRjFiSFF1WjJWMFJHOWpkVzFsYm5SRGIzVnVkRUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSRWIyTjFiV1Z1ZEVOdmRXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJzWlhRZ1kyOTFiblE2SUhWcGJuUTJOQ0E5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2daRzlqY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dNd29LWjJWMFJHOWpkVzFsYm5SRGIzVnVkRjkzYUdsc1pWOTBiM0JBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2daRzlqY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJFYjJOMWJXVnVkRU52ZFc1MFgyRm1kR1Z5WDNkb2FXeGxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCcFppQW9iM0F1WjJWMFFubDBaU2hrYjJOekxDQnBLU0E5UFQwZ05EUXBJSHNnTHk4Z05EUWdhWE1nUVZORFNVa2dabTl5SUNjc0p3b2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQndkWE5vYVc1MElEUTBJQzh2SURRMENpQWdJQ0E5UFFvZ0lDQWdZbm9nWjJWMFJHOWpkVzFsYm5SRGIzVnVkRjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJqYjNWdWRDQTlJR052ZFc1MElDc2dNUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlEUUtDbWRsZEVSdlkzVnRaVzUwUTI5MWJuUmZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JrYjJOekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNd29nSUNBZ1lpQm5aWFJFYjJOMWJXVnVkRU52ZFc1MFgzZG9hV3hsWDNSdmNFQTBDZ3BuWlhSRWIyTjFiV1Z1ZEVOdmRXNTBYMkZtZEdWeVgzZG9hV3hsUURnNkNpQWdJQ0JrYVdjZ013b2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JpSUdkbGRFUnZZM1Z0Wlc1MFEyOTFiblJmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82Vm1GMWJIUXVaMlYwUkc5amRXMWxiblJEYjNWdWRFQTVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFpoZFd4MExuUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUhCMVlteHBZeUJ2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWg3SUd0bGVUb2dKMjhuSUgwcElDQWdJQ0FnSUNBZ0lDQXZMeUJqYjI1MGNtRmpkQ0J2ZDI1bGNnb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUIwYUdsekxtOTNibVZ5TG5aaGJIVmxJRDBnYm1WM1QzZHVaWElLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBQ0NpWUdCR1J2WTNNS01ERXlNelExTmpjNE9RRnZBWHdGRlI5OGRZQUVGUjk4ZFRFYlFRQTVNUmtVUkRFWVJJSUdCT3pxQ3M4RTlDa242QVRNUXJkYkJEN0dvNmdFVkR0Z0NBVHlQVW9WTmhvQWpnWUFMQUJHQUs0QXdBRFJBUnNBTVJrVU1SZ1VFRVFpUTRvQkFZdi9KUXhCQUFZcGkvOGlXSW1ML3lVS2lQL3BpLzhsR0NsTUlsaFFpVFlhQVVraldTUUlTd0VWRWtSWEFnQXFUR2VBQVdNalp5SkRJellhQVVraldTUUlTd0VWRWtSWEFnQTJHZ0pKSTFra0NFc0JGUkpFVndJQUtMNU1TVThDUkJWQkFEVkpSUVF5QjRqL2tVc0RLMUJMQTFBclVFeFFTd1FWUUFBTEtMeElLRXkvSndTd0lrTkxCSUFCTEZCTVVDaThTQ2hNdjBMLzZvQUFSUVJDLzhjb3ZrUkpGUlpYQmdKTVVDY0ZURkN3SWtNMkdnRkpJMWtrQ0V3VkVrUW5CTEFpUTRBQVNTaStURWxQQWtRVlNVQUFEQ05GQVVrV0p3Vk1VTEFpUXlKRkJDTkZBMHNDU3dFTVFRQWFTd0ZMQTFXQkxCSkJBQVpMQXlJSVJRUkxBaUlJUlFOQy85NUxBMFVCUXYvSU5ob0JTU05aSkFoTEFSVVNSRmNDQUNwTVp5SkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
