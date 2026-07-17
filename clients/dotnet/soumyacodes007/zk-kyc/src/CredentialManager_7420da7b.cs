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

namespace Arc56.Generated.soumyacodes007.zk_kyc.CredentialManager_7420da7b
{


    //
    // Issues and revokes non-transferable KYC credential ASAs.
    //
    public class CredentialManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CredentialManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize contract and create the KYC credential ASA.
        ///Returns new ASA ID. App address becomes clawback/freeze/manager. Fund this contract with ≥ 0.2 ALGO before calling (for ASA creation MBR).
        ///</summary>
        public async Task<ulong> Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 40, 90, 116 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 40, 90, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Issue a KYC credential to a verified wallet. Issuer-only.
        ///Recipient MUST have opted into credential ASA before this call. Flow: unfreeze → transfer 1 unit → re-freeze (non-transferable). Nullifier stored in note field for on-chain auditability.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="nullifier"> </param>
        public async Task IssueCredential(Algorand.Address recipient, byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 129, 72, 234 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IssueCredential_Transactions(Algorand.Address recipient, byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 129, 72, 234 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke credential via clawback. Issuer-only.
        ///Called on: fraud detection, Aadhaar cancel, court order, expiry.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="nullifier"> </param>
        public async Task RevokeCredential(Algorand.Address wallet, byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 244, 138, 59 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeCredential_Transactions(Algorand.Address wallet, byte[] nullifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 244, 138, 59 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nullifierAbi.From(nullifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, nullifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the credential ASA ID.
        ///</summary>
        public async Task<ulong> GetCredentialAsaId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 237, 80, 131 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCredentialAsaId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 237, 80, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Total credentials issued.
        ///</summary>
        public async Task<ulong> GetTotalIssued(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 210, 43, 234 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalIssued_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 210, 43, 234 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Total credentials revoked.
        ///</summary>
        public async Task<ulong> GetTotalRevoked(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 251, 54, 41 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalRevoked_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 251, 54, 41 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlZGVudGlhbE1hbmFnZXIiLCJkZXNjIjoiSXNzdWVzIGFuZCByZXZva2VzIG5vbi10cmFuc2ZlcmFibGUgS1lDIGNyZWRlbnRpYWwgQVNBcy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUgY29udHJhY3QgYW5kIGNyZWF0ZSB0aGUgS1lDIGNyZWRlbnRpYWwgQVNBLlxuUmV0dXJucyBuZXcgQVNBIElELiBBcHAgYWRkcmVzcyBiZWNvbWVzIGNsYXdiYWNrL2ZyZWV6ZS9tYW5hZ2VyLiBGdW5kIHRoaXMgY29udHJhY3Qgd2l0aCDiiaUgMC4yIEFMR08gYmVmb3JlIGNhbGxpbmcgKGZvciBBU0EgY3JlYXRpb24gTUJSKS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc3N1ZV9jcmVkZW50aWFsIiwiZGVzYyI6Iklzc3VlIGEgS1lDIGNyZWRlbnRpYWwgdG8gYSB2ZXJpZmllZCB3YWxsZXQuIElzc3Vlci1vbmx5LlxuUmVjaXBpZW50IE1VU1QgaGF2ZSBvcHRlZCBpbnRvIGNyZWRlbnRpYWwgQVNBIGJlZm9yZSB0aGlzIGNhbGwuIEZsb3c6IHVuZnJlZXplIOKGkiB0cmFuc2ZlciAxIHVuaXQg4oaSIHJlLWZyZWV6ZSAobm9uLXRyYW5zZmVyYWJsZSkuIE51bGxpZmllciBzdG9yZWQgaW4gbm90ZSBmaWVsZCBmb3Igb24tY2hhaW4gYXVkaXRhYmlsaXR5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudWxsaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlX2NyZWRlbnRpYWwiLCJkZXNjIjoiUmV2b2tlIGNyZWRlbnRpYWwgdmlhIGNsYXdiYWNrLiBJc3N1ZXItb25seS5cbkNhbGxlZCBvbjogZnJhdWQgZGV0ZWN0aW9uLCBBYWRoYWFyIGNhbmNlbCwgY291cnQgb3JkZXIsIGV4cGlyeS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVsbGlmaWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jcmVkZW50aWFsX2FzYV9pZCIsImRlc2MiOiJSZXR1cm4gdGhlIGNyZWRlbnRpYWwgQVNBIElELiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX2lzc3VlZCIsImRlc2MiOiJUb3RhbCBjcmVkZW50aWFscyBpc3N1ZWQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfcmV2b2tlZCIsImRlc2MiOiJUb3RhbCBjcmVkZW50aWFscyByZXZva2VkLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2lzc3VlciIsImRlc2MiOiJUcmFuc2ZlciBpc3N1ZXIgcm9sZS4gSXNzdWVyLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfaXNzdWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzAyLDQwNiw0OTddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGlzc3VlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNiw0MTEsNDQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jcmVkZW50aWFsX2FzYV9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDAsNDA0LDQ5NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNzdWVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2Nyw0NjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2lzc3VlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzgsNDczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZXZva2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NCwzODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTEsMzk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OCwzODIsNDg5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWFYTnpkV1Z5SWlBaVkzSmxaR1Z1ZEdsaGJGOWhjMkZmYVdRaUlDSjBiM1JoYkY5cGMzTjFaV1FpSUNKMGIzUmhiRjl5WlhadmEyVmtJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakkxQ2lBZ0lDQXZMeUJ6Wld4bUxtbHpjM1ZsY2lBOUlFRmpZMjkxYm5Rb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYTnpkV1Z5SWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnYzJWc1ppNWpjbVZrWlc1MGFXRnNYMkZ6WVY5cFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM0psWkdWdWRHbGhiRjloYzJGZmFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYVhOemRXVmtJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXBjM04xWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjbVYyYjJ0bFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmNtVjJiMnRsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJqYkdGemN5QkRjbVZrWlc1MGFXRnNUV0Z1WVdkbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1EzT0RFME9HVmhJREI0TXpWbU5EaGhNMklnTUhoaVltVmtOVEE0TXlBd2VEVm1aREl5WW1WaElEQjRPVGxtWWpNMk1qa2dNSGd5WTJKak1EUXdaU0F2THlCdFpYUm9iMlFnSW1semMzVmxYMk55WldSbGJuUnBZV3dvWVdSa2NtVnpjeXhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVjJiMnRsWDJOeVpXUmxiblJwWVd3b1lXUmtjbVZ6Y3l4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDJOeVpXUmxiblJwWVd4ZllYTmhYMmxrS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOTBiM1JoYkY5cGMzTjFaV1FvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzUnZkR0ZzWDNKbGRtOXJaV1FvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxYMmx6YzNWbGNpaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCcGMzTjFaVjlqY21Wa1pXNTBhV0ZzSUhKbGRtOXJaVjlqY21Wa1pXNTBhV0ZzSUdkbGRGOWpjbVZrWlc1MGFXRnNYMkZ6WVY5cFpDQm5aWFJmZEc5MFlXeGZhWE56ZFdWa0lHZGxkRjkwYjNSaGJGOXlaWFp2YTJWa0lIVndaR0YwWlY5cGMzTjFaWElLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklHTnNZWE56SUVOeVpXUmxiblJwWVd4TllXNWhaMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtPVEk0TldFM05DQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTZ3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMbU52Ym5SeVlXTjBMa055WldSbGJuUnBZV3hOWVc1aFoyVnlMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJSE5sYkdZdWFYTnpkV1Z5SUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYTnpkV1Z5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmFYTnpkV1ZrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlwYzNOMVpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WMmIydGxaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZjbVYyYjJ0bFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzBNUzAxTlFvZ0lDQWdMeThnSXlCRGNtVmhkR1VnYm05dUxYUnlZVzV6Wm1WeVlXSnNaU0JqY21Wa1pXNTBhV0ZzSUVGVFFRb2dJQ0FnTHk4Z0l5QkJjSEFnWVdSa2NtVnpjeUJwY3lCdFlXNWhaMlZ5TDJOc1lYZGlZV05yTDJaeVpXVjZaU0J6YnlCdmJteDVJSFJvYVhNZ1kyOXVkSEpoWTNRZ1kyRnVJRzl3WlhKaGRHVWdhWFFLSUNBZ0lDOHZJSEpsYzNWc2RDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlNVjh3TURCZk1EQXdYekF3TUN3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6MHdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWm5KdmVtVnVQVlJ5ZFdVc0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJeUJtY205NlpXNGdZbmtnWkdWbVlYVnNkQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxaUlrdFpRMUpGUkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDFpSWtGc1oyOUxXVU1nUTNKbFpHVnVkR2xoYkNJc0NpQWdJQ0F2THlBZ0lDQWdkWEpzUFdJaWFIUjBjSE02THk5aGJHZHZhM2xqTG1SbGRpSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TENBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSXlCbVpXVWdjRzl2YkdsdVp3b2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5URXROVE1LSUNBZ0lDOHZJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5Qm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHUjFjRzRnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZKbGMyVnlkbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJHY21WbGVtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkRiR0YzWW1GamF3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklIVnliRDFpSW1oMGRIQnpPaTh2WVd4bmIydDVZeTVrWlhZaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qZzNORGMwTnpBM016TmhNbVl5WmpZeE5tTTJOelptTm1JM09UWXpNbVUyTkRZMU56WUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZVa3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUdGemMyVjBYMjVoYldVOVlpSkJiR2R2UzFsRElFTnlaV1JsYm5ScFlXd2lMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROREUyWXpZM05tWTBZalU1TkRNeU1EUXpOekkyTlRZME5qVTJaVGMwTmprMk1UWmpDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBXSWlTMWxEVWtWRUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmlOVGswTXpVeU5EVTBOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJrWldaaGRXeDBYMlp5YjNwbGJqMVVjblZsTENBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDTWdabkp2ZW1WdUlHSjVJR1JsWm1GMWJIUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVm1ZWFZzZEVaeWIzcGxiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnWkdWamFXMWhiSE05TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUhSdmRHRnNQVEZmTURBd1h6QXdNRjh3TURBc0NpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd01EQXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJVYjNSaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzBNUzAwTXdvZ0lDQWdMeThnSXlCRGNtVmhkR1VnYm05dUxYUnlZVzV6Wm1WeVlXSnNaU0JqY21Wa1pXNTBhV0ZzSUVGVFFRb2dJQ0FnTHk4Z0l5QkJjSEFnWVdSa2NtVnpjeUJwY3lCdFlXNWhaMlZ5TDJOc1lYZGlZV05yTDJaeVpXVjZaU0J6YnlCdmJteDVJSFJvYVhNZ1kyOXVkSEpoWTNRZ1kyRnVJRzl3WlhKaGRHVWdhWFFLSUNBZ0lDOHZJSEpsYzNWc2RDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnWm1WbFBUQXNJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWpJR1psWlNCd2IyOXNhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRFdE5UVUtJQ0FnSUM4dklDTWdRM0psWVhSbElHNXZiaTEwY21GdWMyWmxjbUZpYkdVZ1kzSmxaR1Z1ZEdsaGJDQkJVMEVLSUNBZ0lDOHZJQ01nUVhCd0lHRmtaSEpsYzNNZ2FYTWdiV0Z1WVdkbGNpOWpiR0YzWW1GamF5OW1jbVZsZW1VZ2MyOGdiMjVzZVNCMGFHbHpJR052Ym5SeVlXTjBJR05oYmlCdmNHVnlZWFJsSUdsMENpQWdJQ0F2THlCeVpYTjFiSFFnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFRGZk1EQXdYekF3TUY4d01EQXNDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TUN3S0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFgyWnliM3BsYmoxVWNuVmxMQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNNZ1puSnZlbVZ1SUdKNUlHUmxabUYxYkhRS0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlZaUpMV1VOU1JVUWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOVlpSkJiR2R2UzFsRElFTnlaV1JsYm5ScFlXd2lMQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEMWlJbWgwZEhCek9pOHZZV3huYjJ0NVl5NWtaWFlpTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd2dJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDTWdabVZsSUhCdmIyeHBibWNLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QnpaV3htTG1OeVpXUmxiblJwWVd4ZllYTmhYMmxrSUQwZ2NtVnpkV3gwTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU55WldSbGJuUnBZV3hmWVhOaFgybGtJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExrTnlaV1JsYm5ScFlXeE5ZVzVoWjJWeUxtbHpjM1ZsWDJOeVpXUmxiblJwWVd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjM04xWlY5amNtVmtaVzUwYVdGc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YVhOemRXVnlMQ0FpVDI1c2VTQnBjM04xWlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhWE56ZFdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWx6YzNWbGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCcGMzTjFaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpBS0lDQWdJQzh2SUdGellTQTlJRUZ6YzJWMEtITmxiR1l1WTNKbFpHVnVkR2xoYkY5aGMyRmZhV1FwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM0psWkdWdWRHbGhiRjloYzJGZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNKbFpHVnVkR2xoYkY5aGMyRmZhV1FnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamN5TFRjNENpQWdJQ0F2THlBaklGTjBaWEFnTVRvZ1ZXNW1jbVZsZW1VZ2MyOGdjbVZqYVhCcFpXNTBJR05oYmlCeVpXTmxhWFpsQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwUm5KbFpYcGxLQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVjloYzNObGREMWhjMkVzQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsWDJGalkyOTFiblE5Y21WamFYQnBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWnliM3BsYmoxR1lXeHpaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJR1p5YjNwbGJqMUdZV3h6WlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVp5WldWNlpVRnpjMlYwUm5KdmVtVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkdjbVZsZW1WQmMzTmxkRUZqWTI5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR2NtVmxlbVZCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzNNaTAzTXdvZ0lDQWdMeThnSXlCVGRHVndJREU2SUZWdVpuSmxaWHBsSUhOdklISmxZMmx3YVdWdWRDQmpZVzRnY21WalpXbDJaUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRVp5WldWNlpTZ0tJQ0FnSUhCMWMyaHBiblFnTlNBdkx5Qmhabko2Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzNNaTAzT0FvZ0lDQWdMeThnSXlCVGRHVndJREU2SUZWdVpuSmxaWHBsSUhOdklISmxZMmx3YVdWdWRDQmpZVzRnY21WalpXbDJaUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRVp5WldWNlpTZ0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVmZZWE56WlhROVlYTmhMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVjloWTJOdmRXNTBQWEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzRNQzA0TndvZ0lDQWdMeThnSXlCVGRHVndJREk2SUZSeVlXNXpabVZ5SURFZ1kzSmxaR1Z1ZEdsaGJDQjFibWwwSUNodWRXeHNhV1pwWlhJZ2FXNGdibTkwWlNCbWIzSWdZWFZrYVhRcENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzJFc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWNtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQweExBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOWJuVnNiR2xtYVdWeUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JPYjNSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pnd0xUZ3hDaUFnSUNBdkx5QWpJRk4wWlhBZ01qb2dWSEpoYm5ObVpYSWdNU0JqY21Wa1pXNTBhV0ZzSUhWdWFYUWdLRzUxYkd4cFptbGxjaUJwYmlCdWIzUmxJR1p2Y2lCaGRXUnBkQ2tLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RBdE9EY0tJQ0FnSUM4dklDTWdVM1JsY0NBeU9pQlVjbUZ1YzJabGNpQXhJR055WldSbGJuUnBZV3dnZFc1cGRDQW9iblZzYkdsbWFXVnlJR2x1SUc1dmRHVWdabTl5SUdGMVpHbDBLUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTmhMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNU3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxQVzUxYkd4cFptbGxjaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamc1TFRrMUNpQWdJQ0F2THlBaklGTjBaWEFnTXpvZ1VtVXRabkpsWlhwbElPS0FsQ0J1YjI0dGRISmhibk5tWlhKaFlteGxDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBSbkpsWlhwbEtBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpWOWhjM05sZEQxaGMyRXNDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxYMkZqWTI5MWJuUTljbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdaeWIzcGxiajFVY25WbExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z1puSnZlbVZ1UFZSeWRXVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR2NtVmxlbVZCYzNObGRFWnliM3BsYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHY21WbGVtVkJjM05sZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHY21WbGVtVkJjM05sZEVGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RrdE9UQUtJQ0FnSUM4dklDTWdVM1JsY0NBek9pQlNaUzFtY21WbGVtVWc0b0NVSUc1dmJpMTBjbUZ1YzJabGNtRmliR1VLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJHY21WbGVtVW9DaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdZV1p5ZWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZPRGt0T1RVS0lDQWdJQzh2SUNNZ1UzUmxjQ0F6T2lCU1pTMW1jbVZsZW1VZzRvQ1VJRzV2YmkxMGNtRnVjMlpsY21GaWJHVUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkdjbVZsZW1Vb0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbFgyRnpjMlYwUFdGellTd0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVmZZV05qYjNWdWREMXlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnWm5KdmVtVnVQVlJ5ZFdVc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNU53b2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXBjM04xWldRZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYVhOemRXVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMmx6YzNWbFpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5cGMzTjFaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMbU52Ym5SeVlXTjBMa055WldSbGJuUnBZV3hOWVc1aFoyVnlMbkpsZG05clpWOWpjbVZrWlc1MGFXRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WMmIydGxYMk55WldSbGJuUnBZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVhWE56ZFdWeUxDQWlUMjVzZVNCcGMzTjFaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYTnpkV1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHpjM1ZsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JwYzNOMVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEEzTFRFeE5Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1amNtVmtaVzUwYVdGc1gyRnpZVjlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmMyVnVaR1Z5UFhkaGJHeGxkQ3dnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBaklHTnNZWGRpWVdOcklITnZkWEpqWlFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNBaklISmxkSFZ5YmlCMGJ5QmhjSEFLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNU3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxQVzUxYkd4cFptbGxjaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEE0Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVkzSmxaR1Z1ZEdsaGJGOWhjMkZmYVdRcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OeVpXUmxiblJwWVd4ZllYTmhYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnlaV1JsYm5ScFlXeGZZWE5oWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1UQUtJQ0FnSUM4dklHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNBaklISmxkSFZ5YmlCMGJ5QmhjSEFLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1RtOTBaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TVRFS0lDQWdJQzh2SUdGemMyVjBYMkZ0YjNWdWREMHhMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEEzQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1URXpDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1EY3RNVEUwQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbU55WldSbGJuUnBZV3hmWVhOaFgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl6Wlc1a1pYSTlkMkZzYkdWMExDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ01nWTJ4aGQySmhZMnNnYzI5MWNtTmxDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJQ01nY21WMGRYSnVJSFJ2SUdGd2NBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQweExBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOWJuVnNiR2xtYVdWeUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM0psZG05clpXUWdLejBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmNtVjJiMnRsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5eVpYWnZhMlZrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYM0psZG05clpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG81T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExrTnlaV1JsYm5ScFlXeE5ZVzVoWjJWeUxtZGxkRjlqY21Wa1pXNTBhV0ZzWDJGellWOXBaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWpjbVZrWlc1MGFXRnNYMkZ6WVY5cFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1amNtVmtaVzUwYVdGc1gyRnpZVjlwWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU55WldSbGJuUnBZV3hmWVhOaFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OeVpXUmxiblJwWVd4ZllYTmhYMmxrSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl1WTI5dWRISmhZM1F1UTNKbFpHVnVkR2xoYkUxaGJtRm5aWEl1WjJWMFgzUnZkR0ZzWDJsemMzVmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTBiM1JoYkY5cGMzTjFaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVkRzkwWVd4ZmFYTnpkV1ZrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZmFYTnpkV1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJsemMzVmxaQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMbU52Ym5SeVlXTjBMa055WldSbGJuUnBZV3hOWVc1aFoyVnlMbWRsZEY5MGIzUmhiRjl5WlhadmEyVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUnZkR0ZzWDNKbGRtOXJaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVkRzkwWVd4ZmNtVjJiMnRsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gzSmxkbTlyWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmNtVjJiMnRsWkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TG1OdmJuUnlZV04wTGtOeVpXUmxiblJwWVd4TllXNWhaMlZ5TG5Wd1pHRjBaVjlwYzNOMVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVmZhWE56ZFdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVE0yQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbWx6YzNWbGNpd2dJazl1YkhrZ2FYTnpkV1Z5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHpjM1ZsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBjM04xWlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnYVhOemRXVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV6TndvZ0lDQWdMeThnYzJWc1ppNXBjM04xWlhJZ1BTQnVaWGRmYVhOemRXVnlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBjM04xWlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdBaVlGQm1semMzVmxjaEZqY21Wa1pXNTBhV0ZzWDJGellWOXBaQXgwYjNSaGJGOXBjM04xWldRTmRHOTBZV3hmY21WMmIydGxaQVFWSDN4MU1SaEFBQTBvTWdObktTSm5LaUpuS3lKbk1Sa1VSREVZUVFBeWdnWUUxNEZJNmdRMTlJbzdCTHZ0VUlNRVg5SXI2Z1NaK3pZcEJDeThCQTQyR2dDT0JnQ0JBT2tCTUFFOEFVZ0JWQUNBQk5rb1duUTJHZ0NPQVFBQkFDZ3hBR2NxSW1jckltZXhNZ3BIQTdJcXNpdXlMTElwZ0JOb2RIUndjem92TDJGc1oyOXJlV011WkdWMnNpZUFFa0ZzWjI5TFdVTWdRM0psWkdWdWRHbGhiTEltZ0FaTFdVTlNSVVN5SlNPeUpDS3lJNEdBbE92Y0E3SWlnUU95RUNLeUFiTzBQQ2xMQVdjV0p3Uk1VTEFqUXpZYUFVa1ZKQkpFTmhvQ1NTSlpKUWhMQVJVU1JGY0NBREVBSWlobFJCSkVJaWxsUkxFaXNpOUxBckl1U2JJdGdRV3lFQ0t5QWJPeFRMSUZJN0lTU3dHeUZFbXlFWUVFc2hBaXNnR3pzU095TDdJdHNpNkJCYklRSXJJQnN5SXFaVVFqQ0NwTVp5TkROaG9CU1JVa0VrUTJHZ0pKSWxrbENFc0JGUkpFVndJQU1RQWlLR1ZFRWtTeElpbGxSRElLVHdLeUJTT3lFcklVc2hHeUU0RUVzaEFpc2dHeklpdGxSQ01JSzB4bkkwTWlLV1ZFRmljRVRGQ3dJME1pS21WRUZpY0VURkN3STBNaUsyVkVGaWNFVEZDd0kwTTJHZ0ZKRlNRU1JERUFJaWhsUkJKRUtFeG5JME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
