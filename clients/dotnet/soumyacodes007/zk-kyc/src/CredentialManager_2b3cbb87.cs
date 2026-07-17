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

namespace Arc56.Generated.soumyacodes007.zk_kyc.CredentialManager_2b3cbb87
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
        ///Initialize — deployer becomes issuer. Fund app with 0.3 ALGO then call initialize_asa().
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
        ///Create the KYC credential ASA. Must be called AFTER funding app with >= 0.3 ALGO.
        ///Returns the new ASA ID. App address is manager/clawback/freeze.
        ///</summary>
        public async Task<ulong> InitializeAsa(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 93, 144, 53 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InitializeAsa_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 93, 144, 53 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Issue a KYC credential to a verified wallet. Issuer-only.
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
        ///
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
        ///
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlZGVudGlhbE1hbmFnZXIiLCJkZXNjIjoiSXNzdWVzIGFuZCByZXZva2VzIG5vbi10cmFuc2ZlcmFibGUgS1lDIGNyZWRlbnRpYWwgQVNBcy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUg4oCUIGRlcGxveWVyIGJlY29tZXMgaXNzdWVyLiBGdW5kIGFwcCB3aXRoIDAuMyBBTEdPIHRoZW4gY2FsbCBpbml0aWFsaXplX2FzYSgpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0aWFsaXplX2FzYSIsImRlc2MiOiJDcmVhdGUgdGhlIEtZQyBjcmVkZW50aWFsIEFTQS4gTXVzdCBiZSBjYWxsZWQgQUZURVIgZnVuZGluZyBhcHAgd2l0aCA+PSAwLjMgQUxHTy5cblJldHVybnMgdGhlIG5ldyBBU0EgSUQuIEFwcCBhZGRyZXNzIGlzIG1hbmFnZXIvY2xhd2JhY2svZnJlZXplLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imlzc3VlX2NyZWRlbnRpYWwiLCJkZXNjIjoiSXNzdWUgYSBLWUMgY3JlZGVudGlhbCB0byBhIHZlcmlmaWVkIHdhbGxldC4gSXNzdWVyLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bGxpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfY3JlZGVudGlhbCIsImRlc2MiOiJSZXZva2UgY3JlZGVudGlhbCB2aWEgY2xhd2JhY2suIElzc3Vlci1vbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudWxsaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NyZWRlbnRpYWxfYXNhX2lkIiwiZGVzYyI6IlJldHVybiB0aGUgY3JlZGVudGlhbCBBU0EgSUQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfaXNzdWVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfcmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2lzc3VlciIsImRlc2MiOiJUcmFuc2ZlciBpc3N1ZXIgcm9sZS4gSXNzdWVyLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfaXNzdWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTg5XSwiZXJyb3JNZXNzYWdlIjoiQVNBIGFscmVhZHkgY3JlYXRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MywzMjUsNDI5LDUyMF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgaXNzdWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3LDMyOSw0MzQsNDcyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jcmVkZW50aWFsX2FzYV9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODEsMzIzLDQyNyw1MThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzc3VlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTAsNDg0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9pc3N1ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYxLDQ5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcmV2b2tlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDcsNDExXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE0LDQxOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDEsNDA1LDUxMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SWdNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlhWE56ZFdWeUlpQWlZM0psWkdWdWRHbGhiRjloYzJGZmFXUWlJQ0owYjNSaGJGOXBjM04xWldRaUlDSjBiM1JoYkY5eVpYWnZhMlZrSWlBd2VERTFNV1kzWXpjMUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFM0NpQWdJQ0F2THlCelpXeG1MbWx6YzNWbGNpQTlJRUZqWTI5MWJuUW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhWE56ZFdWeUlnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE9Bb2dJQ0FnTHk4Z2MyVnNaaTVqY21Wa1pXNTBhV0ZzWDJGellWOXBaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTNKbFpHVnVkR2xoYkY5aGMyRmZhV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmFYTnpkV1ZrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlwYzNOMVpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WMmIydGxaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZjbVYyYjJ0bFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFekNpQWdJQ0F2THlCamJHRnpjeUJEY21Wa1pXNTBhV0ZzVFdGdVlXZGxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdGaE5XUTVNRE0xSURCNFpEYzRNVFE0WldFZ01IZ3pOV1kwT0dFellpQXdlR0ppWldRMU1EZ3pJREI0Tldaa01qSmlaV0VnTUhnNU9XWmlNell5T1NBd2VESmpZbU13TkRCbElDOHZJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaVjloYzJFb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWFYTnpkV1ZmWTNKbFpHVnVkR2xoYkNoaFpHUnlaWE56TEdKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWFp2YTJWZlkzSmxaR1Z1ZEdsaGJDaGhaR1J5WlhOekxHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZlkzSmxaR1Z1ZEdsaGJGOWhjMkZmYVdRb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYM1J2ZEdGc1gybHpjM1ZsWkNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZkRzkwWVd4ZmNtVjJiMnRsWkNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZmYVhOemRXVnlLR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHbHVhWFJwWVd4cGVtVmZZWE5oSUdsemMzVmxYMk55WldSbGJuUnBZV3dnY21WMmIydGxYMk55WldSbGJuUnBZV3dnWjJWMFgyTnlaV1JsYm5ScFlXeGZZWE5oWDJsa0lHZGxkRjkwYjNSaGJGOXBjM04xWldRZ1oyVjBYM1J2ZEdGc1gzSmxkbTlyWldRZ2RYQmtZWFJsWDJsemMzVmxjZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE13b2dJQ0FnTHk4Z1kyeGhjM01nUTNKbFpHVnVkR2xoYkUxaGJtRm5aWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExrTnlaV1JsYm5ScFlXeE5ZVzVoWjJWeUxtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklITmxiR1l1YVhOemRXVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOemRXVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNallLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYVhOemRXVmtJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXBjM04xWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qY0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjbVYyYjJ0bFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmNtVjJiMnRsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpNWpiMjUwY21GamRDNURjbVZrWlc1MGFXRnNUV0Z1WVdkbGNpNXBibWwwYVdGc2FYcGxYMkZ6WVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVhWFJwWVd4cGVtVmZZWE5oT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvek5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1cGMzTjFaWElzSUNKUGJteDVJR2x6YzNWbGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pwYzNOMVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOemRXVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHbHpjM1ZsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZM0psWkdWdWRHbGhiRjloYzJGZmFXUWdQVDBnVlVsdWREWTBLREFwTENBaVFWTkJJR0ZzY21WaFpIa2dZM0psWVhSbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamNtVmtaVzUwYVdGc1gyRnpZVjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpjbVZrWlc1MGFXRnNYMkZ6WVY5cFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJVMEVnWVd4eVpXRmtlU0JqY21WaGRHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak00TFRVd0NpQWdJQ0F2THlCeVpYTjFiSFFnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFRGZk1EQXdYekF3TUY4d01EQXNDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TUN3S0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFgyWnliM3BsYmoxVWNuVmxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxaUlrdFpRMUpGUkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDFpSWtGc1oyOUxXVU1nUTNKbFpHVnVkR2xoYkNJc0NpQWdJQ0F2THlBZ0lDQWdkWEpzUFdJaWFIUjBjSE02THk5aGJHZHZhM2xqTG1SbGRpSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRZdE5EZ0tJQ0FnSUM4dklHTnNZWGRpWVdOclBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlCbWNtVmxlbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdSMWNHNGdNd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkdjbVZsZW1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRGJHRjNZbUZqYXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEUxaGJtRm5aWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUhWeWJEMWlJbWgwZEhCek9pOHZZV3huYjJ0NVl5NWtaWFlpTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpnM05EYzBOekEzTXpOaE1tWXlaall4Tm1NMk56Wm1ObUkzT1RZek1tVTJORFkxTnpZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVlVrd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJR0Z6YzJWMFgyNWhiV1U5WWlKQmJHZHZTMWxESUVOeVpXUmxiblJwWVd3aUxBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5ERTJZelkzTm1ZMFlqVTVORE15TURRek56STJOVFkwTmpVMlpUYzBOamsyTVRaakNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnZFc1cGRGOXVZVzFsUFdJaVMxbERVa1ZFSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSaU5UazBNelV5TkRVME5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QmtaV1poZFd4MFgyWnliM3BsYmoxVWNuVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV1poZFd4MFJuSnZlbVZ1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvek9Rb2dJQ0FnTHk4Z2RHOTBZV3c5TVY4d01EQmZNREF3WHpBd01Dd0tJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRrS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPak00TFRVd0NpQWdJQ0F2THlCeVpYTjFiSFFnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFRGZk1EQXdYekF3TUY4d01EQXNDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TUN3S0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFgyWnliM3BsYmoxVWNuVmxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQxaUlrdFpRMUpGUkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDFpSWtGc1oyOUxXVU1nUTNKbFpHVnVkR2xoYkNJc0NpQWdJQ0F2THlBZ0lDQWdkWEpzUFdJaWFIUjBjSE02THk5aGJHZHZhM2xqTG1SbGRpSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ6YzJWMFNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJSE5sYkdZdVkzSmxaR1Z1ZEdsaGJGOWhjMkZmYVdRZ1BTQnlaWE4xYkhRdVkzSmxZWFJsWkY5aGMzTmxkQzVwWkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTNKbFpHVnVkR2xoYkY5aGMyRmZhV1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU55WldSbGJuUnBZV3hmYldGdVlXZGxjaTVqYjI1MGNtRmpkQzVEY21Wa1pXNTBhV0ZzVFdGdVlXZGxjaTVwYzNOMVpWOWpjbVZrWlc1MGFXRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVhOemRXVmZZM0psWkdWdWRHbGhiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtbHpjM1ZsY2l3Z0lrOXViSGtnYVhOemRXVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1semMzVmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMzTjFaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dhWE56ZFdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QmhjMkVnUFNCQmMzTmxkQ2h6Wld4bUxtTnlaV1JsYm5ScFlXeGZZWE5oWDJsa0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OeVpXUmxiblJwWVd4ZllYTmhYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnlaV1JsYm5ScFlXeGZZWE5oWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk1pMDJOd29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRVp5WldWNlpTZ0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVmZZWE56WlhROVlYTmhMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVjloWTJOdmRXNTBQWEpsWTJsd2FXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5Qm1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdjbVZsZW1WQmMzTmxkRVp5YjNwbGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JuSmxaWHBsUVhOelpYUkJZMk52ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm5KbFpYcGxRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkdjbVZsZW1Vb0NpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1lXWnllZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qSXROamNLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJHY21WbGVtVW9DaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxYMkZ6YzJWMFBXRnpZU3dLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVZmWVdOamIzVnVkRDF5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1puSnZlbVZ1UFVaaGJITmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOamt0TnpVS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6WVN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxeVpXTnBjR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRFc0NpQWdJQ0F2THlBZ0lDQWdibTkwWlQxdWRXeHNhV1pwWlhJc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTV2ZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklHRnpjMlYwWDJGdGIzVnVkRDB4TEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qa3ROelVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpZU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEVzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDF1ZFd4c2FXWnBaWElzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8zTnkwNE1nb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFWnlaV1Y2WlNnS0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1WZllYTnpaWFE5WVhOaExBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpWOWhZMk52ZFc1MFBYSmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtY205NlpXNDlWSEoxWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUdaeWIzcGxiajFVY25WbExBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm5KbFpYcGxRWE56WlhSR2NtOTZaVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbkpsWlhwbFFYTnpaWFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbkpsWlhwbFFYTnpaWFJCWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwUm5KbFpYcGxLQW9nSUNBZ2NIVnphR2x1ZENBMUlDOHZJR0ZtY25vS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamMzTFRneUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFJuSmxaWHBsS0FvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlY5aGMzTmxkRDFoYzJFc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbFgyRmpZMjkxYm5ROWNtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJR1p5YjNwbGJqMVVjblZsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmFYTnpkV1ZrSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYMmx6YzNWbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXBjM04xWldRZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYVhOemRXVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpNWpiMjUwY21GamRDNURjbVZrWlc1MGFXRnNUV0Z1WVdkbGNpNXlaWFp2YTJWZlkzSmxaR1Z1ZEdsaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsZG05clpWOWpjbVZrWlc1MGFXRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG80TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWFYTnpkV1Z5TENBaVQyNXNlU0JwYzNOMVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOemRXVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1semMzVmxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnBjM04xWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9URXRPVGdLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVZM0psWkdWdWRHbGhiRjloYzJGZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM05sYm1SbGNqMTNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsUFc1MWJHeHBabWxsY2l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RJS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNWpjbVZrWlc1MGFXRnNYMkZ6WVY5cFpDa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkzSmxaR1Z1ZEdsaGJGOWhjMkZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWkdWdWRHbGhiRjloYzJGZmFXUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQk9iM1JsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTlNU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkzSmxaR1Z1ZEdsaGJGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9UY0tJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2preExUazRDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtTnlaV1JsYm5ScFlXeGZZWE5oWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXpaVzVrWlhJOWQyRnNiR1YwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEVzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDF1ZFd4c2FXWnBaWElzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNtVjJiMnRsWkNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjl5WlhadmEyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM0psZG05clpXUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmNtVjJiMnRsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl1WTI5dWRISmhZM1F1UTNKbFpHVnVkR2xoYkUxaGJtRm5aWEl1WjJWMFgyTnlaV1JsYm5ScFlXeGZZWE5oWDJsa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJOeVpXUmxiblJwWVd4ZllYTmhYMmxrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1EVUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbU55WldSbGJuUnBZV3hmWVhOaFgybGtDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkzSmxaR1Z1ZEdsaGJGOWhjMkZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWkdWdWRHbGhiRjloYzJGZmFXUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTNKbFpHVnVkR2xoYkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnlaV1JsYm5ScFlXeGZiV0Z1WVdkbGNpNWpiMjUwY21GamRDNURjbVZrWlc1MGFXRnNUV0Z1WVdkbGNpNW5aWFJmZEc5MFlXeGZhWE56ZFdWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNSdmRHRnNYMmx6YzNWbFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEE1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1MGIzUmhiRjlwYzNOMVpXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlwYzNOMVpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZhWE56ZFdWa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdVkyOXVkSEpoWTNRdVEzSmxaR1Z1ZEdsaGJFMWhibUZuWlhJdVoyVjBYM1J2ZEdGc1gzSmxkbTlyWldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmZEc5MFlXeGZjbVYyYjJ0bFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amNtVmtaVzUwYVdGc1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1MGIzUmhiRjl5WlhadmEyVmtDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmY21WMmIydGxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl5WlhadmEyVmtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOeVpXUmxiblJwWVd4ZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpjbVZrWlc1MGFXRnNYMjFoYm1GblpYSXVZMjl1ZEhKaFkzUXVRM0psWkdWdWRHbGhiRTFoYm1GblpYSXVkWEJrWVhSbFgybHpjM1ZsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlY5cGMzTjFaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk55WldSbGJuUnBZV3hmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWFYTnpkV1Z5TENBaVQyNXNlU0JwYzNOMVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVhOemRXVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1semMzVmxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnBjM04xWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqY21Wa1pXNTBhV0ZzWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1URTVDaUFnSUNBdkx5QnpaV3htTG1semMzVmxjaUE5SUc1bGQxOXBjM04xWlhJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1semMzVmxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZM0psWkdWdWRHbGhiRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQWlZRkJtbHpjM1ZsY2hGamNtVmtaVzUwYVdGc1gyRnpZVjlwWkF4MGIzUmhiRjlwYzNOMVpXUU5kRzkwWVd4ZmNtVjJiMnRsWkFRVkgzeDFNUmhBQUEwb01nTm5LU0puS2lKbkt5Sm5NUmtVUkRFWVFRQTVnZ2NFcWwyUU5RVFhnVWpxQkRYMGlqc0V1KzFRZ3dSZjBpdnFCSm43TmlrRUxMd0VEallhQUk0SEFCc0FrUUQ1QVVBQlRBRllBV1FBZ0FSTVhHRzZOaG9BamdFQUFRQW9NUUJuS2lKbkt5Sm5JME14QUNJb1pVUVNSQ0lwWlVRVVJMRXlDa2NEc2lxeUs3SXNzaW1BRTJoMGRIQnpPaTh2WVd4bmIydDVZeTVrWlhheUo0QVNRV3huYjB0WlF5QkRjbVZrWlc1MGFXRnNzaWFBQmt0WlExSkZSTElsSTdJa0lySWpnWUNVNjl3RHNpS0JBN0lRSXJJQnM3UThLVXNCWnhZbkJFeFFzQ05ETmhvQlNSVWtFa1EyR2dKSklsa2xDRXNCRlJKRVZ3SUFNUUFpS0dWRUVrUWlLV1ZFc1NLeUwwc0NzaTVKc2kyQkJiSVFJcklCczdGTXNnVWpzaEpMQWJJVVNiSVJnUVN5RUNLeUFiT3hJN0l2c2kyeUxvRUZzaEFpc2dHeklpcGxSQ01JS2t4bkkwTTJHZ0ZKRlNRU1JEWWFBa2tpV1NVSVN3RVZFa1JYQWdBeEFDSW9aVVFTUkxFaUtXVkVNZ3BQQXJJRkk3SVNzaFN5RWJJVGdRU3lFQ0t5QWJNaUsyVkVJd2dyVEdjalF5SXBaVVFXSndSTVVMQWpReUlxWlVRV0p3Uk1VTEFqUXlJclpVUVdKd1JNVUxBalF6WWFBVWtWSkJKRU1RQWlLR1ZFRWtRb1RHY2pRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
