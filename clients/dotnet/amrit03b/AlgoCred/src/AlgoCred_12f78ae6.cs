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

namespace Arc56.Generated.amrit03b.AlgoCred.AlgoCred_12f78ae6
{


    //
    // AlgoCred - Algorand Credential Transfer Smart Contract
    //
    //A simplified version for deployment that provides basic credential management
    //functionality using Algorand Standard Assets (ASAs).
    //
    public class AlgoCredProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoCredProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Register a new issuer organization
        ///</summary>
        /// <param name="organizationName"> </param>
        /// <param name="organizationId"> </param>
        /// <param name="verificationUrl"> </param>
        public async Task<string> RegisterIssuer(string organizationName, string organizationId, string verificationUrl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 182, 243, 248 };
            var organizationNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationNameAbi.From(organizationName);
            var organizationIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationIdAbi.From(organizationId);
            var verificationUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); verificationUrlAbi.From(verificationUrl);

            var result = await base.CallApp(new List<object> { abiHandle, organizationNameAbi, organizationIdAbi, verificationUrlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterIssuer_Transactions(string organizationName, string organizationId, string verificationUrl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 182, 243, 248 };
            var organizationNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationNameAbi.From(organizationName);
            var organizationIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationIdAbi.From(organizationId);
            var verificationUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); verificationUrlAbi.From(verificationUrl);

            return await base.MakeTransactionList(new List<object> { abiHandle, organizationNameAbi, organizationIdAbi, verificationUrlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create and transfer a credential NFT to recipient
        ///</summary>
        /// <param name="recipientAddress"> </param>
        /// <param name="credentialType"> </param>
        /// <param name="credentialDataJson"> </param>
        public async Task<string> CreateCredential(string recipientAddress, string credentialType, string credentialDataJson, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 74, 155, 180 };
            var recipientAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAddressAbi.From(recipientAddress);
            var credentialTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); credentialTypeAbi.From(credentialType);
            var credentialDataJsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); credentialDataJsonAbi.From(credentialDataJson);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAddressAbi, credentialTypeAbi, credentialDataJsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateCredential_Transactions(string recipientAddress, string credentialType, string credentialDataJson, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 74, 155, 180 };
            var recipientAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAddressAbi.From(recipientAddress);
            var credentialTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); credentialTypeAbi.From(credentialType);
            var credentialDataJsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); credentialDataJsonAbi.From(credentialDataJson);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAddressAbi, credentialTypeAbi, credentialDataJsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify a credential by ASA ID
        ///</summary>
        /// <param name="asaIdStr"> </param>
        public async Task<string> VerifyCredential(string asaIdStr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 110, 140, 144 };
            var asaIdStrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asaIdStrAbi.From(asaIdStr);

            var result = await base.CallApp(new List<object> { abiHandle, asaIdStrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyCredential_Transactions(string asaIdStr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 110, 140, 144 };
            var asaIdStrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asaIdStrAbi.From(asaIdStr);

            return await base.MakeTransactionList(new List<object> { abiHandle, asaIdStrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get issuer information
        ///</summary>
        public async Task<string> GetIssuerInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 226, 165, 214 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetIssuerInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 226, 165, 214 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update issuer status
        ///</summary>
        /// <param name="isActive"> </param>
        public async Task<string> UpdateIssuerStatus(string isActive, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 35, 69, 40 };
            var isActiveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); isActiveAbi.From(isActive);

            var result = await base.CallApp(new List<object> { abiHandle, isActiveAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateIssuerStatus_Transactions(string isActive, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 35, 69, 40 };
            var isActiveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); isActiveAbi.From(isActive);

            return await base.MakeTransactionList(new List<object> { abiHandle, isActiveAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb0NyZWQiLCJkZXNjIjoiQWxnb0NyZWQgLSBBbGdvcmFuZCBDcmVkZW50aWFsIFRyYW5zZmVyIFNtYXJ0IENvbnRyYWN0XG5cbkEgc2ltcGxpZmllZCB2ZXJzaW9uIGZvciBkZXBsb3ltZW50IHRoYXQgcHJvdmlkZXMgYmFzaWMgY3JlZGVudGlhbCBtYW5hZ2VtZW50XG5mdW5jdGlvbmFsaXR5IHVzaW5nIEFsZ29yYW5kIFN0YW5kYXJkIEFzc2V0cyAoQVNBcykuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InJlZ2lzdGVySXNzdWVyIiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IGlzc3VlciBvcmdhbml6YXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemF0aW9uTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemF0aW9uSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcmlmaWNhdGlvblVybCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZUNyZWRlbnRpYWwiLCJkZXNjIjoiQ3JlYXRlIGFuZCB0cmFuc2ZlciBhIGNyZWRlbnRpYWwgTkZUIHRvIHJlY2lwaWVudCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnRBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVkZW50aWFsVHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlZGVudGlhbERhdGFKc29uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5Q3JlZGVudGlhbCIsImRlc2MiOiJWZXJpZnkgYSBjcmVkZW50aWFsIGJ5IEFTQSBJRCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc2FJZFN0ciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldElzc3VlckluZm8iLCJkZXNjIjoiR2V0IGlzc3VlciBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUlzc3VlclN0YXR1cyIsImRlc2MiOiJVcGRhdGUgaXNzdWVyIHN0YXR1cyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc0FjdGl2ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjQsOTQsMTQyLDE5MiwyMzRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Nyw5NywxNDUsMTk1LDIzN10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOWpjbVZrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnNaMjlEY21Wa0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNREppTm1ZelpqZ2dNSGhpTkRSaE9XSmlOQ0F3ZURobE5tVTRZemt3SURCNE9HSmxNbUUxWkRZZ01IaGhOakl6TkRVeU9DQXZMeUJ0WlhSb2IyUWdJbkpsWjJsemRHVnlTWE56ZFdWeUtITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZM0psWVhSbFEzSmxaR1Z1ZEdsaGJDaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblpsY21sbWVVTnlaV1JsYm5ScFlXd29jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBTWE56ZFdWeVNXNW1ieWdwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0oxY0dSaGRHVkpjM04xWlhKVGRHRjBkWE1vYzNSeWFXNW5LWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmNtVm5hWE4wWlhKSmMzTjFaWEpmY205MWRHVkFNeUJ0WVdsdVgyTnlaV0YwWlVOeVpXUmxiblJwWVd4ZmNtOTFkR1ZBTkNCdFlXbHVYM1psY21sbWVVTnlaV1JsYm5ScFlXeGZjbTkxZEdWQU5TQnRZV2x1WDJkbGRFbHpjM1ZsY2tsdVptOWZjbTkxZEdWQU5pQnRZV2x1WDNWd1pHRjBaVWx6YzNWbGNsTjBZWFIxYzE5eWIzVjBaVUEzQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlqY21Wa0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZzWjI5RGNtVmtJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR2x1ZENBd0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxY0dSaGRHVkpjM04xWlhKVGRHRjBkWE5mY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJOeVpXUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdkWEJrWVhSbFNYTnpkV1Z5VTNSaGRIVnpLR2x6UVdOMGFYWmxPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlqY21Wa0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZzWjI5RGNtVmtJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYMk55WldRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2RYQmtZWFJsU1hOemRXVnlVM1JoZEhWektHbHpRV04wYVhabE9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVkpjM04xWlhKVGRHRjBkWE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRWx6YzNWbGNrbHVabTlmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJOeVpXUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdaMlYwU1hOemRXVnlTVzVtYnlncE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01XVTFORFkxTnpNM05ESXdOVFUyWlRZNU56WTJOVGN5TnpNMk9UYzBOemt5TURJNE56UTJOVGN6TnpReVpEYzFObVUyT1RKa016QXpNRE14TWprS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkyWlhKcFpubERjbVZrWlc1MGFXRnNYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMTlqY21Wa0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklIWmxjbWxtZVVOeVpXUmxiblJwWVd3b1lYTmhTV1JUZEhJNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBeU1EUXpOekkyTlRZME5qVTJaVGMwTmprMk1UWmpNakEzTmpZMU56STJPVFkyTmprMk5UWTBNakEzTXpjMU5qTTJNelkxTnpNM016WTJOelUyWXpaak56a0tJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZEY21Wa1pXNTBhV0ZzWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5amNtVmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV0TWprS0lDQWdJQzh2SUdOeVpXRjBaVU55WldSbGJuUnBZV3dvQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZEVGa1pISmxjM002SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWTNKbFpHVnVkR2xoYkZSNWNHVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZM0psWkdWdWRHbGhiRVJoZEdGS2MyOXVPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYMk55WldRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV3huYjBOeVpXUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5amNtVmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV0TWprS0lDQWdJQzh2SUdOeVpXRjBaVU55WldSbGJuUnBZV3dvQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZEVGa1pISmxjM002SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWTNKbFpHVnVkR2xoYkZSNWNHVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZM0psWkdWdWRHbGhiRVJoZEdGS2MyOXVPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVU55WldSbGJuUnBZV3dLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxaMmx6ZEdWeVNYTnpkV1Z5WDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5amNtVmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF0TVRnS0lDQWdJQzh2SUhKbFoybHpkR1Z5U1hOemRXVnlLQW9nSUNBZ0x5OGdJQ0J2Y21kaGJtbDZZWFJwYjI1T1lXMWxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJRzl5WjJGdWFYcGhkR2x2Ymtsa09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lIWmxjbWxtYVdOaGRHbHZibFZ5YkRvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5amNtVmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGc1oyOURjbVZrSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZZM0psWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMExURTRDaUFnSUNBdkx5QnlaV2RwYzNSbGNrbHpjM1ZsY2lnS0lDQWdJQzh2SUNBZ2IzSm5ZVzVwZW1GMGFXOXVUbUZ0WlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCdmNtZGhibWw2WVhScGIyNUpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0IyWlhKcFptbGpZWFJwYjI1VmNtdzZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnY21WbmFYTjBaWEpKYzNOMVpYSUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJOeVpXUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd4bmIwTnlaV1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyTnlaV1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVd4bmIwTnlaV1F1Y21WbmFYTjBaWEpKYzNOMVpYSW9iM0puWVc1cGVtRjBhVzl1VG1GdFpUb2dZbmwwWlhNc0lHOXlaMkZ1YVhwaGRHbHZia2xrT2lCaWVYUmxjeXdnZG1WeWFXWnBZMkYwYVc5dVZYSnNPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbkpsWjJsemRHVnlTWE56ZFdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZZM0psWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMExURTRDaUFnSUNBdkx5QnlaV2RwYzNSbGNrbHpjM1ZsY2lnS0lDQWdJQzh2SUNBZ2IzSm5ZVzVwZW1GMGFXOXVUbUZ0WlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCdmNtZGhibWw2WVhScGIyNUpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0IyWlhKcFptbGpZWFJwYjI1VmNtdzZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZlkzSmxaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRWx6YzNWbGNpQWtlMjl5WjJGdWFYcGhkR2x2Yms1aGJXVjlJSEpsWjJsemRHVnlaV1FnYzNWalkyVnpjMloxYkd4NVlBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKSmMzTjFaWElnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUhKbFoybHpkR1Z5WldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5amNtVmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5RGNtVmtMbU55WldGMFpVTnlaV1JsYm5ScFlXd29jbVZqYVhCcFpXNTBRV1JrY21WemN6b2dZbmwwWlhNc0lHTnlaV1JsYm5ScFlXeFVlWEJsT2lCaWVYUmxjeXdnWTNKbFpHVnVkR2xoYkVSaGRHRktjMjl1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21OeVpXRjBaVU55WldSbGJuUnBZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjE5amNtVmtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV0TWprS0lDQWdJQzh2SUdOeVpXRjBaVU55WldSbGJuUnBZV3dvQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZEVGa1pISmxjM002SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWTNKbFpHVnVkR2xoYkZSNWNHVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZM0psWkdWdWRHbGhiRVJoZEdGS2MyOXVPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyTnlaV1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnY21WMGRYSnVJR0JEY21Wa1pXNTBhV0ZzSUU1R1ZDQmpjbVZoZEdWa0lHWnZjaUFrZTNKbFkybHdhV1Z1ZEVGa1pISmxjM045WUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pEY21Wa1pXNTBhV0ZzSUU1R1ZDQmpjbVZoZEdWa0lHWnZjaUFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZlkzSmxaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYkdkdlEzSmxaQzUxY0dSaGRHVkpjM04xWlhKVGRHRjBkWE1vYVhOQlkzUnBkbVU2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LZFhCa1lYUmxTWE56ZFdWeVUzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZlkzSmxaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUIxY0dSaGRHVkpjM04xWlhKVGRHRjBkWE1vYVhOQlkzUnBkbVU2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYMk55WldRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCSmMzTjFaWElnYzNSaGRIVnpJSFZ3WkdGMFpXUWdkRzhnSkh0cGMwRmpkR2wyWlgxZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtsemMzVmxjaUJ6ZEdGMGRYTWdkWEJrWVhSbFpDQjBieUFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBU1lCQkJVZmZIVXhHMEVCQVlJRkJBSzI4L2dFdEVxYnRBU09ib3lRQkl2aXBkWUVwaU5GS0RZYUFJNEZBSzBBZ3dCUkFDRUFBNEVBUXpFWkZFUXhHRVEyR2dGWEFnQ0lBUjVKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VTQUpCVWZmSFVBSGxSbGMzUWdWVzVwZG1WeWMybDBlU0FvZEdWemRDMTFibWt0TURBeEtiQWlRekVaRkVReEdFU0FKaFVmZkhVQUlFTnlaV1JsYm5ScFlXd2dkbVZ5YVdacFpXUWdjM1ZqWTJWemMyWjFiR3g1c0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBMWNDQUlnQWJra1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQURZYUExY0NBSWdBR1VrVkZsY0dBa3hRS0V4UXNDSkRNUmxBL3lReEdCUkVJa09LQXdHQUIwbHpjM1ZsY2lDTC9WQ0FHQ0J5WldkcGMzUmxjbVZrSUhOMVkyTmxjM05tZFd4c2VWQ0ppZ01CZ0J0RGNtVmtaVzUwYVdGc0lFNUdWQ0JqY21WaGRHVmtJR1p2Y2lDTC9WQ0ppZ0VCZ0JsSmMzTjFaWElnYzNSaGRIVnpJSFZ3WkdGMFpXUWdkRzhnaS85UWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
