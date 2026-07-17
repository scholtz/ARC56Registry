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

namespace Arc56.Generated.prasun151.Certichain.CredentialVerifier_98517b28
{


    //
    // Algorand Credential Verifier Smart Contract
    //
    public class CredentialVerifierProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CredentialVerifierProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the contract with the authorized institution
        ///</summary>
        /// <param name="institution"> </param>
        public async Task Create(Algorand.Address institution, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 105, 78, 170 };
            var institutionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); institutionAbi.From(institution);

            var result = await base.CallApp(new List<object> { abiHandle, institutionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address institution, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 105, 78, 170 };
            var institutionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); institutionAbi.From(institution);

            return await base.MakeTransactionList(new List<object> { abiHandle, institutionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Issue a credential to a student.
        ///Mints an NFT and returns the Asset ID. Only the authorized institution can call this.
        ///</summary>
        /// <param name="student_address"> </param>
        /// <param name="credential_name"> </param>
        /// <param name="metadata_url"> </param>
        public async Task<ulong> IssueCredential(Algorand.Address student_address, string credential_name, string metadata_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 140, 175, 251 };
            var student_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); student_addressAbi.From(student_address);
            var credential_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); credential_nameAbi.From(credential_name);
            var metadata_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_urlAbi.From(metadata_url);

            var result = await base.CallApp(new List<object> { abiHandle, student_addressAbi, credential_nameAbi, metadata_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IssueCredential_Transactions(Algorand.Address student_address, string credential_name, string metadata_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 140, 175, 251 };
            var student_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); student_addressAbi.From(student_address);
            var credential_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); credential_nameAbi.From(credential_name);
            var metadata_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_urlAbi.From(metadata_url);

            return await base.MakeTransactionList(new List<object> { abiHandle, student_addressAbi, credential_nameAbi, metadata_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify if a credential is valid (dummy for now)
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task<string> VerifyCredential(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 106, 47, 83 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.SimApp(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyCredential_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 106, 47, 83 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract information
        ///</summary>
        public async Task<string> GetContractInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 238, 187, 185 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetContractInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 238, 187, 185 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlZGVudGlhbFZlcmlmaWVyIiwiZGVzYyI6IkFsZ29yYW5kIENyZWRlbnRpYWwgVmVyaWZpZXIgU21hcnQgQ29udHJhY3QiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGNvbnRyYWN0IHdpdGggdGhlIGF1dGhvcml6ZWQgaW5zdGl0dXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imluc3RpdHV0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imlzc3VlX2NyZWRlbnRpYWwiLCJkZXNjIjoiSXNzdWUgYSBjcmVkZW50aWFsIHRvIGEgc3R1ZGVudC5cbk1pbnRzIGFuIE5GVCBhbmQgcmV0dXJucyB0aGUgQXNzZXQgSUQuIE9ubHkgdGhlIGF1dGhvcml6ZWQgaW5zdGl0dXRpb24gY2FuIGNhbGwgdGhpcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0dWRlbnRfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlZGVudGlhbF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhZGF0YV91cmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfY3JlZGVudGlhbCIsImRlc2MiOiJWZXJpZnkgaWYgYSBjcmVkZW50aWFsIGlzIHZhbGlkIChkdW1teSBmb3Igbm93KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbnRyYWN0X2luZm8iLCJkZXNjIjoiR2V0IGNvbnRyYWN0IGluZm9ybWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwMl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGF1dGhvcml6ZWQgaW5zdGl0dXRpb24gY2FuIGlzc3VlIGNyZWRlbnRpYWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hdXRob3JpemVkX2luc3RpdHV0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OCwxODRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzUsMTkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OSwxNjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNeklnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWVhWMGFHOXlhWHBsWkY5cGJuTjBhWFIxZEdsdmJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFTnlaV1JsYm5ScFlXeFdaWEpwWm1sbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTVDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNemc0WTJGbVptSWdNSGd6TURaaE1tWTFNeUF3ZURKbFpXVmlZbUk1SUM4dklHMWxkR2h2WkNBaWFYTnpkV1ZmWTNKbFpHVnVkR2xoYkNoaFpHUnlaWE56TEhOMGNtbHVaeXh6ZEhKcGJtY3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSjJaWEpwWm5sZlkzSmxaR1Z1ZEdsaGJDaDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUmZZMjl1ZEhKaFkzUmZhVzVtYnlncGMzUnlhVzVuSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2FYTnpkV1ZmWTNKbFpHVnVkR2xoYkNCMlpYSnBabmxmWTNKbFpHVnVkR2xoYkNCdFlXbHVYMmRsZEY5amIyNTBjbUZqZEY5cGJtWnZYM0p2ZFhSbFFEY0tJQ0FnSUdWeWNnb0tiV0ZwYmw5blpYUmZZMjl1ZEhKaFkzUmZhVzVtYjE5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBeVpqUXpOekkyTlRZME5qVTJaVGMwTmprMk1UWmpOVFkyTlRjeU5qazJOalk1TmpVM01qSXdNbVF5TURReE5tTTJOelptTnpJMk1UWmxOalF5TURRek56STJOVFkwTmpVMlpUYzBOamsyTVRaak1qQTFNemM1TnpNM05EWTFObVFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmZG1WeWFXWnBaWEl2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTNKbFpHVnVkR2xoYkZabGNtbG1hV1Z5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpZelk1TkdWaFlTQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amNtVmtaVzUwYVdGc1gzWmxjbWxtYVdWeUxtTnZiblJ5WVdOMExrTnlaV1JsYm5ScFlXeFdaWEpwWm1sbGNpNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnYzJWc1ppNWhkWFJvYjNKcGVtVmtYMmx1YzNScGRIVjBhVzl1TG5aaGJIVmxJRDBnYVc1emRHbDBkWFJwYjI0S0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GMWRHaHZjbWw2WldSZmFXNXpkR2wwZFhScGIyNGlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZM0psWkdWdWRHbGhiRjkyWlhKcFptbGxjaTVqYjI1MGNtRmpkQzVEY21Wa1pXNTBhV0ZzVm1WeWFXWnBaWEl1YVhOemRXVmZZM0psWkdWdWRHbGhiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21semMzVmxYMk55WldSbGJuUnBZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRjFkR2h2Y21sNlpXUmZhVzV6ZEdsMGRYUnBiMjR1ZG1Gc2RXVXNJQ0pQYm14NUlIUm9aU0JoZFhSb2IzSnBlbVZrSUdsdWMzUnBkSFYwYVc5dUlHTmhiaUJwYzNOMVpTQmpjbVZrWlc1MGFXRnNjeUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGRYUm9iM0pwZW1Wa1gybHVjM1JwZEhWMGFXOXVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GMWRHaHZjbWw2WldSZmFXNXpkR2wwZFhScGIyNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHaGxJR0YxZEdodmNtbDZaV1FnYVc1emRHbDBkWFJwYjI0Z1kyRnVJR2x6YzNWbElHTnlaV1JsYm5ScFlXeHpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG95Tnkwek5nb2dJQ0FnTHk4Z0l5Qk5hVzUwSUhSb1pTQk9SbFFnZFhOcGJtY2dZVzRnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJR0Z6YzJWMFgyTnlaV0YwWlNBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OU1Td0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejB3TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlZM0psWkdWdWRHbGhiRjl1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFUZEhKcGJtY29Ja05GVWxRaUtTd0tJQ0FnSUM4dklDQWdJQ0IxY213OWJXVjBZV1JoZEdGZmRYSnNMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSUNNZ1EyOXVkSEpoWTNRZ2FYTWdkR2hsSUcxaGJtRm5aWElLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFhOMGRXUmxiblJmWVdSa2NtVnpjeXdnSXlCU1pYTmxjblpsSUdseklIUm9aU0J6ZEhWa1pXNTBDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5MlpYSnBabWxsY2k5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWdJeUJEYjI1MGNtRmpkQ0JwY3lCMGFHVWdiV0Z1WVdkbGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZKbGMyVnlkbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJOWVc1aFoyVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVkpNQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRvek1nb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBWTjBjbWx1WnlnaVEwVlNWQ0lwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pEUlZKVUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZkbVZ5YVdacFpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdSbFkybHRZV3h6UFRBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z2RHOTBZV3c5TVN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVkc5MFlXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gzWmxjbWxtYVdWeUwyTnZiblJ5WVdOMExuQjVPakkzTFRJNENpQWdJQ0F2THlBaklFMXBiblFnZEdobElFNUdWQ0IxYzJsdVp5QmhiaUJwYm01bGNpQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdZWE56WlhSZlkzSmxZWFJsSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDNabGNtbG1hV1Z5TDJOdmJuUnlZV04wTG5CNU9qSTNMVE0yQ2lBZ0lDQXZMeUFqSUUxcGJuUWdkR2hsSUU1R1ZDQjFjMmx1WnlCaGJpQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb2dJQ0FnTHk4Z1lYTnpaWFJmWTNKbFlYUmxJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQxamNtVmtaVzUwYVdGc1gyNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBWTjBjbWx1WnlnaVEwVlNWQ0lwTEFvZ0lDQWdMeThnSUNBZ0lIVnliRDF0WlhSaFpHRjBZVjkxY213c0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWdJeUJEYjI1MGNtRmpkQ0JwY3lCMGFHVWdiV0Z1WVdkbGNnb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTljM1IxWkdWdWRGOWhaR1J5WlhOekxDQWpJRkpsYzJWeWRtVWdhWE1nZEdobElITjBkV1JsYm5RS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCYzNObGRFbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOTJaWEpwWm1sbGNpOWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnlaV1JsYm5ScFlXeGZkbVZ5YVdacFpYSXVZMjl1ZEhKaFkzUXVRM0psWkdWdWRHbGhiRlpsY21sbWFXVnlMblpsY21sbWVWOWpjbVZrWlc1MGFXRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVYMk55WldSbGJuUnBZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjkyWlhKcFptbGxjaTlqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EZzFOalkxTnpJMk9UWTJOamsyTlRZMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFnQWlZQkZtRjFkR2h2Y21sNlpXUmZhVzV6ZEdsMGRYUnBiMjR4R1JSRU1SaEJBRmVDQXdRNGpLLzdCREJxTDFNRUx1Njd1VFlhQUk0REFGWUF0d0FCQUlBMUZSOThkUUF2UTNKbFpHVnVkR2xoYkZabGNtbG1hV1Z5SUMwZ1FXeG5iM0poYm1RZ1EzSmxaR1Z1ZEdsaGJDQlRlWE4wWlcyd0lrT0FCTXhwVHFvMkdnQ09BUUFCQURZYUFVa1ZKQkpFS0V4bklrTTJHZ0ZKRlNRU1JEWWFBa2tqV1NVSVN3RVZFa1JYQWdBMkdnTkpJMWtsQ0VzQkZSSkVWd0lBTVFBaktHVkVFa1N4TWdwUEE3SXFzaW15SjRBRVEwVlNWTElsc2lZanNpTWlzaUtCQTdJUUk3SUJzN1E4Rm9BRUZSOThkVXhRc0NKRE5ob0JGWUVJRWtTQURoVWZmSFVBQ0ZabGNtbG1hV1Zrc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
