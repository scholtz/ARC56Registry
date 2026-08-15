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

namespace Arc56.Generated.quantalabss.algo_pqc_kit.PQCDao_cbcf978b
{


    //
    // 
    //    Post-Quantum DAO
    //
    //    A decentralized autonomous organization where all governance
    //    decisions are authorized by Falcon-1024 multi-signatures verified
    //    on-chain. No Ed25519. No classical multisig. Fully PQC.
    //
    //    Governance flow
    //    ---------------
    //    1. Any committee member creates a proposal (spending amount + recipient)
    //    2. Committee members sign the proposal message off-chain (Falcon-1024)
    //    3. Proposer submits M signatures → contract verifies on-chain
    //    4. If M-of-N verified → proposal executes, treasury pays out
    //
    //    Storage layout (box storage)
    //    ----------------------------
    //    b"pk_{index:8}"      → Falcon-1024 public key (1793 bytes)
    //    b"prop_{id:8}"       → Proposal data (ABI-encoded)
    //    
    //
    public class PQCDaoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PQCDaoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the DAO.
        ///</summary>
        /// <param name="dao_name">Human-readable name for the DAO. </param>
        /// <param name="threshold">M — minimum Falcon-1024 signatures required to pass a proposal. </param>
        /// <param name="public_keys">Falcon-1024 public keys of all N committee members. </param>
        public async Task Create(string dao_name, ulong threshold, byte[][] public_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 132, 61, 57 };
            var dao_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dao_nameAbi.From(dao_name);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);

            var result = await base.CallApp(new List<object> { abiHandle, dao_nameAbi, thresholdAbi, public_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string dao_name, ulong threshold, byte[][] public_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 132, 61, 57 };
            var dao_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dao_nameAbi.From(dao_name);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);

            return await base.MakeTransactionList(new List<object> { abiHandle, dao_nameAbi, thresholdAbi, public_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allocate boxes for the public keys.
        ///Requires the app to be funded first.
        ///</summary>
        /// <param name="public_keys"> </param>
        public async Task Bootstrap(byte[][] public_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 103, 229, 176 };
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);

            var result = await base.CallApp(new List<object> { abiHandle, public_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(byte[][] public_keys, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 103, 229, 176 };
            var public_keysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); public_keysAbi.From(public_keys);

            return await base.MakeTransactionList(new List<object> { abiHandle, public_keysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit a spending proposal with M-of-N Falcon signatures.
        ///If the quorum is reached, the proposal is immediately executed (treasury pays out to recipient).
        ///</summary>
        /// <param name="description">Human-readable description of the proposal (stored on-chain). </param>
        /// <param name="recipient">Beneficiary of the treasury payment. </param>
        /// <param name="amount">Payment amount in microALGO. </param>
        /// <param name="signatures">Falcon-1024 signatures from M committee members. </param>
        /// <param name="signer_indices">Indices of the signing committee members. </param>
        public async Task<ulong> SubmitProposal(string description, Algorand.Address recipient, ulong amount, byte[][] signatures, ulong[] signer_indices, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 51, 197, 35 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var signaturesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); signaturesAbi.From(signatures);
            var signer_indicesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); signer_indicesAbi.From(signer_indices);

            var result = await base.CallApp(new List<object> { abiHandle, descriptionAbi, recipientAbi, amountAbi, signaturesAbi, signer_indicesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SubmitProposal_Transactions(string description, Algorand.Address recipient, ulong amount, byte[][] signatures, ulong[] signer_indices, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 51, 197, 35 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var signaturesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); signaturesAbi.From(signatures);
            var signer_indicesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); signer_indicesAbi.From(signer_indices);

            return await base.MakeTransactionList(new List<object> { abiHandle, descriptionAbi, recipientAbi, amountAbi, signaturesAbi, signer_indicesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return total number of proposals submitted.
        ///</summary>
        public async Task<ulong> GetProposalCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 143, 186, 116 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetProposalCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 143, 186, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the DAO's signature threshold (M).
        ///</summary>
        public async Task<ulong> GetThreshold(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 80, 213, 164 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetThreshold_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 80, 213, 164 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return total committee size (N).
        ///</summary>
        public async Task<ulong> GetMemberCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 125, 80, 29 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMemberCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 125, 80, 29 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUFFDRGFvIiwiZGVzYyI6IlxuICAgIFBvc3QtUXVhbnR1bSBEQU9cblxuICAgIEEgZGVjZW50cmFsaXplZCBhdXRvbm9tb3VzIG9yZ2FuaXphdGlvbiB3aGVyZSBhbGwgZ292ZXJuYW5jZVxuICAgIGRlY2lzaW9ucyBhcmUgYXV0aG9yaXplZCBieSBGYWxjb24tMTAyNCBtdWx0aS1zaWduYXR1cmVzIHZlcmlmaWVkXG4gICAgb24tY2hhaW4uIE5vIEVkMjU1MTkuIE5vIGNsYXNzaWNhbCBtdWx0aXNpZy4gRnVsbHkgUFFDLlxuXG4gICAgR292ZXJuYW5jZSBmbG93XG4gICAgLS0tLS0tLS0tLS0tLS0tXG4gICAgMS4gQW55IGNvbW1pdHRlZSBtZW1iZXIgY3JlYXRlcyBhIHByb3Bvc2FsIChzcGVuZGluZyBhbW91bnQgKyByZWNpcGllbnQpXG4gICAgMi4gQ29tbWl0dGVlIG1lbWJlcnMgc2lnbiB0aGUgcHJvcG9zYWwgbWVzc2FnZSBvZmYtY2hhaW4gKEZhbGNvbi0xMDI0KVxuICAgIDMuIFByb3Bvc2VyIHN1Ym1pdHMgTSBzaWduYXR1cmVzIOKGkiBjb250cmFjdCB2ZXJpZmllcyBvbi1jaGFpblxuICAgIDQuIElmIE0tb2YtTiB2ZXJpZmllZCDihpIgcHJvcG9zYWwgZXhlY3V0ZXMsIHRyZWFzdXJ5IHBheXMgb3V0XG5cbiAgICBTdG9yYWdlIGxheW91dCAoYm94IHN0b3JhZ2UpXG4gICAgLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLVxuICAgIGJcInBrX3tpbmRleDo4fVwiICAgICAg4oaSIEZhbGNvbi0xMDI0IHB1YmxpYyBrZXkgKDE3OTMgYnl0ZXMpXG4gICAgYlwicHJvcF97aWQ6OH1cIiAgICAgICDihpIgUHJvcG9zYWwgZGF0YSAoQUJJLWVuY29kZWQpXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBEQU8uIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhb19uYW1lIiwiZGVzYyI6Ikh1bWFuLXJlYWRhYmxlIG5hbWUgZm9yIHRoZSBEQU8uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aHJlc2hvbGQiLCJkZXNjIjoiTSDigJQgbWluaW11bSBGYWxjb24tMTAyNCBzaWduYXR1cmVzIHJlcXVpcmVkIHRvIHBhc3MgYSBwcm9wb3NhbC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVibGljX2tleXMiLCJkZXNjIjoiRmFsY29uLTEwMjQgcHVibGljIGtleXMgb2YgYWxsIE4gY29tbWl0dGVlIG1lbWJlcnMuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOiJBbGxvY2F0ZSBib3hlcyBmb3IgdGhlIHB1YmxpYyBrZXlzLlxuUmVxdWlyZXMgdGhlIGFwcCB0byBiZSBmdW5kZWQgZmlyc3QuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVibGljX2tleXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0X3Byb3Bvc2FsIiwiZGVzYyI6IlN1Ym1pdCBhIHNwZW5kaW5nIHByb3Bvc2FsIHdpdGggTS1vZi1OIEZhbGNvbiBzaWduYXR1cmVzLlxuSWYgdGhlIHF1b3J1bSBpcyByZWFjaGVkLCB0aGUgcHJvcG9zYWwgaXMgaW1tZWRpYXRlbHkgZXhlY3V0ZWQgKHRyZWFzdXJ5IHBheXMgb3V0IHRvIHJlY2lwaWVudCkuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlc2NyaXB0aW9uIiwiZGVzYyI6Ikh1bWFuLXJlYWRhYmxlIGRlc2NyaXB0aW9uIG9mIHRoZSBwcm9wb3NhbCAoc3RvcmVkIG9uLWNoYWluKS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjoiQmVuZWZpY2lhcnkgb2YgdGhlIHRyZWFzdXJ5IHBheW1lbnQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiUGF5bWVudCBhbW91bnQgaW4gbWljcm9BTEdPLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmVzIiwiZGVzYyI6IkZhbGNvbi0xMDI0IHNpZ25hdHVyZXMgZnJvbSBNIGNvbW1pdHRlZSBtZW1iZXJzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduZXJfaW5kaWNlcyIsImRlc2MiOiJJbmRpY2VzIG9mIHRoZSBzaWduaW5nIGNvbW1pdHRlZSBtZW1iZXJzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJQcm9wb3NhbCBJRCAoMC1pbmRleGVkKS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcHJvcG9zYWxfY291bnQiLCJkZXNjIjoiUmV0dXJuIHRvdGFsIG51bWJlciBvZiBwcm9wb3NhbHMgc3VibWl0dGVkLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RocmVzaG9sZCIsImRlc2MiOiJSZXR1cm4gdGhlIERBTydzIHNpZ25hdHVyZSB0aHJlc2hvbGQgKE0pLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X21lbWJlcl9jb3VudCIsImRlc2MiOiJSZXR1cm4gdG90YWwgY29tbWl0dGVlIHNpemUgKE4pLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNTFdLCJlcnJvck1lc3NhZ2UiOiJEQU8gcmVxdWlyZXMgYXQgbGVhc3QgMSBtZW1iZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDRdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgc2lnbmF0dXJlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxMV0sImVycm9yTWVzc2FnZSI6Ik1lbWJlciBpbmRleCBvdXQgb2YgcmFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MThdLCJlcnJvck1lc3NhZ2UiOiJQdWJsaWMga2V5IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2MF0sImVycm9yTWVzc2FnZSI6IlF1b3J1bSBub3QgcmVhY2hlZCDigJQgcHJvcG9zYWwgcmVqZWN0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDhdLCJlcnJvck1lc3NhZ2UiOiJTaWcvaW5kZXggY291bnQgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDldLCJlcnJvck1lc3NhZ2UiOiJUaHJlc2hvbGQgY2Fubm90IGV4Y2VlZCBtZW1iZXIgY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDFdLCJlcnJvck1lc3NhZ2UiOiJUaHJlc2hvbGQgbXVzdCBiZSA+PSAxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA3LDc3M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubnVtX21lbWJlcnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI3LDc1MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJvcG9zYWxfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM3LDY1Niw3NjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRocmVzaG9sZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzUsNjIxXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMywzMTYsNDcwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OCwxNzMsMjE3LDI4NiwzMzAsNDA1LDQ0MCw0ODQsNTEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3LDM1MCw1MDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NSw0MTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Niw0MzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTEsMzI0LDQ3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyhsZW4rdWludDhbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeUNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURJZ01TQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklDSjBhSEpsYzJodmJHUWlJQ0p3Y205d2IzTmhiRjlqYjNWdWRDSWdNSGd4TlRGbU4yTTNOU0FpYm5WdFgyMWxiV0psY25NaUlEQjROekEyWWpWbUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3pPQW9nSUNBZ0x5OGdZMnhoYzNNZ1VGRkRSR0Z2S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFeENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1qYzJOMlUxWWpBZ01IZ3hPRE16WXpVeU15QXdlRFprT0daaVlUYzBJREI0WXpZMU1HUTFZVFFnTUhobE1qZGtOVEF4WkNBdkx5QnRaWFJvYjJRZ0ltSnZiM1J6ZEhKaGNDaGllWFJsVzExYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKemRXSnRhWFJmY0hKdmNHOXpZV3dvYzNSeWFXNW5MR0ZrWkhKbGMzTXNkV2x1ZERZMExHSjVkR1ZiWFZ0ZExIVnBiblEyTkZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYM0J5YjNCdmMyRnNYMk52ZFc1MEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkwYUhKbGMyaHZiR1FvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyMWxiV0psY2w5amIzVnVkQ2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWW05dmRITjBjbUZ3SUhOMVltMXBkRjl3Y205d2IzTmhiQ0JuWlhSZmNISnZjRzl6WVd4ZlkyOTFiblFnWjJWMFgzUm9jbVZ6YUc5c1pDQm5aWFJmYldWdFltVnlYMk52ZFc1MENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1URTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG96T0FvZ0lDQWdMeThnWTJ4aGMzTWdVRkZEUkdGdktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczWXpnME0yUXpPU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaU2h6ZEhKcGJtY3NkV2x1ZERZMExHSjVkR1ZiWFZ0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWhjbU0wTG1SNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5aWVYUmxYMnhsYm1kMGFGOWxiR1Z0Wlc1MEtHRnljbUY1T2lCaWVYUmxjeXdnYVc1a1pYZzZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbVI1Ym1GdGFXTmZZWEp5WVhsZmNtVmhaRjlpZVhSbFgyeGxibWQwYUY5bGJHVnRaVzUwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSEJ4WTE5a1lXOHVVRkZEUkdGdkxtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qWTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwamNtVmhkR1ZmWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZOalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkTENCamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdQQW9nSUNBZ1lub2dZM0psWVhSbFgyRm1kR1Z5WDJadmNrQTBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWm05eUlDaHNaVzRyS0d4bGJpdDFhVzUwT0Z0ZEtWdGRLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURVS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdZM0psWVhSbFgyWnZjbDlvWldGa1pYSkFNUW9LWTNKbFlYUmxYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk5qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBqNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPamcxQ2lBZ0lDQXZMeUJoYzNObGNuUWdkR2h5WlhOb2IyeGtJRDQ5SUZWSmJuUTJOQ2d4S1N3Z0lsUm9jbVZ6YUc5c1pDQnRkWE4wSUdKbElENDlJREVpQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdWR2h5WlhOb2IyeGtJRzExYzNRZ1ltVWdQajBnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk9EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGFISmxjMmh2YkdRZ1BEMGdiaXdnSWxSb2NtVnphRzlzWkNCallXNXViM1FnWlhoalpXVmtJRzFsYldKbGNpQmpiM1Z1ZENJS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJVYUhKbGMyaHZiR1FnWTJGdWJtOTBJR1Y0WTJWbFpDQnRaVzFpWlhJZ1kyOTFiblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pnM0NpQWdJQ0F2THlCaGMzTmxjblFnYmlBK1BTQlZTVzUwTmpRb01Ta3NJQ0pFUVU4Z2NtVnhkV2x5WlhNZ1lYUWdiR1ZoYzNRZ01TQnRaVzFpWlhJaUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJFUVU4Z2NtVnhkV2x5WlhNZ1lYUWdiR1ZoYzNRZ01TQnRaVzFpWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qZzVDaUFnSUNBdkx5QnpaV3htTG1SaGIxOXVZVzFsTG5aaGJIVmxJRDBnWkdGdlgyNWhiV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QWlaR0Z2WDI1aGJXVWlDaUFnSUNCa2FXY2dPUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2prd0NpQWdJQ0F2THlCelpXeG1MblJvY21WemFHOXNaQzUyWVd4MVpTQTlJSFJvY21WemFHOXNaQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkR2h5WlhOb2IyeGtJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZPVEVLSUNBZ0lDOHZJSE5sYkdZdWNISnZjRzl6WVd4ZlkyOTFiblF1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkJ5YjNCdmMyRnNYMk52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUbzVNZ29nSUNBZ0x5OGdjMlZzWmk1dWRXMWZiV1Z0WW1WeWN5NTJZV3gxWlNBOUlHNEtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltNTFiVjl0WlcxaVpYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTd2dZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCd2NXTmZaR0Z2TGxCUlEwUmhieTVpYjI5MGMzUnlZWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWIyOTBjM1J5WVhBNkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk9UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWW05dmRITjBjbUZ3WDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPamswQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEVUtJQ0FnSUR3S0lDQWdJR0o2SUdKdmIzUnpkSEpoY0Y5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR1p2Y2lBb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHSnZiM1J6ZEhKaGNGOW1iM0pmYUdWaFpHVnlRREVLQ21KdmIzUnpkSEpoY0Y5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPamswQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0K0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hNREFLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaHdkV0pzYVdOZmEyVjVjeTVzWlc1bmRHZ3BPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKMWNua2dOd29LWW05dmRITjBjbUZ3WDJadmNsOW9aV0ZrWlhKQU5qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakV3TUFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSEIxWW14cFkxOXJaWGx6TG14bGJtZDBhQ2s2Q2lBZ0lDQmthV2NnTmdvZ0lDQWdaR2xuSURVS0lDQWdJRHdLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E1Q2lBZ0lDQmllaUJpYjI5MGMzUnlZWEJmWVdaMFpYSmZabTl5UURrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRXdNUW9nSUNBZ0x5OGdZbTk0WDJ0bGVTQTlJR0lpY0d0ZklpQXJJRzl3TG1sMGIySW9hU2tLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTURaaU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGtLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TURJS0lDQWdJQzh2SUc5d0xrSnZlQzV3ZFhRb1ltOTRYMnRsZVN3Z2NIVmliR2xqWDJ0bGVYTmJhVjB1WW5sMFpYTXBDaUFnSUNCa2FXY2dOd29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjl5WldGa1gySjVkR1ZmYkdWdVozUm9YMlZzWlcxbGJuUUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFd01Bb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hCMVlteHBZMTlyWlhsekxteGxibWQwYUNrNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0EzQ2lBZ0lDQmlJR0p2YjNSemRISmhjRjltYjNKZmFHVmhaR1Z5UURZS0NtSnZiM1J6ZEhKaGNGOWhablJsY2w5bWIzSkFPVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2prMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QndjV05mWkdGdkxsQlJRMFJoYnk1emRXSnRhWFJmY0hKdmNHOXpZV3hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemRXSnRhWFJmY0hKdmNHOXpZV3c2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUEwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UQTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncHpkV0p0YVhSZmNISnZjRzl6WVd4ZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRBMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lEd0tJQ0FnSUdKNklITjFZbTFwZEY5d2NtOXdiM05oYkY5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR1p2Y2lBb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlITjFZbTFwZEY5d2NtOXdiM05oYkY5bWIzSmZhR1ZoWkdWeVFERUtDbk4xWW0xcGRGOXdjbTl3YjNOaGJGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFd05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RMk5ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakV6TndvZ0lDQWdMeThnY0hKdmNHOXpZV3hmYVdRZ1BTQnpaV3htTG5CeWIzQnZjMkZzWDJOdmRXNTBMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0hKdmNHOXpZV3hmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKdmNHOXpZV3hmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hNemdLSUNBZ0lDOHZJSE5sYkdZdWNISnZjRzl6WVd4ZlkyOTFiblF1ZG1Gc2RXVWdQU0J3Y205d2IzTmhiRjlwWkNBcklGVkpiblEyTkNneEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWljSEp2Y0c5ellXeGZZMjkxYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVFF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMmxuYm1GMGRYSmxjeTVzWlc1bmRHZ2dQajBnYzJWc1ppNTBhSEpsYzJodmJHUXVkbUZzZFdVc0lDSkpibk4xWm1acFkybGxiblFnYzJsbmJtRjBkWEpsY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYUhKbGMyaHZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHaHlaWE5vYjJ4a0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQnphV2R1WVhSMWNtVnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TkRFS0lDQWdJQzh2SUdGemMyVnlkQ0J6YVdkdVlYUjFjbVZ6TG14bGJtZDBhQ0E5UFNCemFXZHVaWEpmYVc1a2FXTmxjeTVzWlc1bmRHZ3NJQ0pUYVdjdmFXNWtaWGdnWTI5MWJuUWdiV2x6YldGMFkyZ2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMmxuTDJsdVpHVjRJR052ZFc1MElHMXBjMjFoZEdOb0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hORE10TVRRMUNpQWdJQ0F2THlBaklFSjFhV3hrSUhSb1pTQmpZVzV2Ym1sallXd2djSEp2Y0c5ellXd2diV1Z6YzJGblpUb0tJQ0FnSUM4dklDTWdjSEp2Y0c5ellXeGZhV1FnZkh3Z2NtVmphWEJwWlc1MElIeDhJR0Z0YjNWdWRDQjhmQ0J6YUdFeU5UWW9aR1Z6WTNKcGNIUnBiMjRwQ2lBZ0lDQXZMeUJrWlhOalgyaGhjMmdnUFNCdmNDNXphR0V5TlRZb1pHVnpZM0pwY0hScGIyNHVZbmwwWlhNcENpQWdJQ0JrYVdjZ09Rb2dJQ0FnYzJoaE1qVTJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFME53b2dJQ0FnTHk4Z2IzQXVhWFJ2WWlod2NtOXdiM05oYkY5cFpDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRRM0xURTBPQW9nSUNBZ0x5OGdiM0F1YVhSdllpaHdjbTl3YjNOaGJGOXBaQ2tLSUNBZ0lDOHZJQ3NnY21WamFYQnBaVzUwTG1KNWRHVnpDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE5Ea0tJQ0FnSUM4dklDc2diM0F1YVhSdllpaGhiVzkxYm5RcENpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TkRjdE1UUTVDaUFnSUNBdkx5QnZjQzVwZEc5aUtIQnliM0J2YzJGc1gybGtLUW9nSUNBZ0x5OGdLeUJ5WldOcGNHbGxiblF1WW5sMFpYTUtJQ0FnSUM4dklDc2diM0F1YVhSdllpaGhiVzkxYm5RcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakUwTnkweE5UQUtJQ0FnSUM4dklHOXdMbWwwYjJJb2NISnZjRzl6WVd4ZmFXUXBDaUFnSUNBdkx5QXJJSEpsWTJsd2FXVnVkQzVpZVhSbGN3b2dJQ0FnTHk4Z0t5QnZjQzVwZEc5aUtHRnRiM1Z1ZENrS0lDQWdJQzh2SUNzZ1pHVnpZMTlvWVhOb0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNVFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFMU15MHhOVFFLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJRTB0YjJZdFRpQkdZV3hqYjI0Z2MybG5ibUYwZFhKbGN5QnZiaTFqYUdGcGJnb2dJQ0FnTHk4Z2RtVnlhV1pwWldRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlERXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TlRVS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2h6YVdkdVlYUjFjbVZ6TG14bGJtZDBhQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F4TVFvS2MzVmliV2wwWDNCeWIzQnZjMkZzWDJadmNsOW9aV0ZrWlhKQU5qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakUxTlFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSE5wWjI1aGRIVnlaWE11YkdWdVozUm9LVG9LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaR2xuSURVS0lDQWdJRHdLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TXdvZ0lDQWdZbm9nYzNWaWJXbDBYM0J5YjNCdmMyRnNYMkZtZEdWeVgyWnZja0F4TVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UVTJDaUFnSUNBdkx5QnBaSGdnUFNCemFXZHVaWEpmYVc1a2FXTmxjMXRwWFM1dVlYUnBkbVVLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFMU53b2dJQ0FnTHk4Z1lYTnpaWEowSUdsa2VDQThJSE5sYkdZdWJuVnRYMjFsYldKbGNuTXVkbUZzZFdVc0lDSk5aVzFpWlhJZ2FXNWtaWGdnYjNWMElHOW1JSEpoYm1kbElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW01MWJWOXRaVzFpWlhKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTUxYlY5dFpXMWlaWEp6SUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCTlpXMWlaWElnYVc1a1pYZ2diM1YwSUc5bUlISmhibWRsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE5Ua0tJQ0FnSUM4dklHSnZlRjlyWlhrZ1BTQmlJbkJyWHlJZ0t5QnZjQzVwZEc5aUtHbGtlQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTURaaU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRZd0NpQWdJQ0F2THlCd2RXSnJaWGtzSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb1ltOTRYMnRsZVNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakUyTVFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbEIxWW14cFl5QnJaWGtnYm05MElHWnZkVzVrSWdvZ0lDQWdZWE56WlhKMElDOHZJRkIxWW14cFl5QnJaWGtnYm05MElHWnZkVzVrQ2lBZ0lDQmthV2NnTVRNS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0hGalgyUmhieTV3ZVRveE5qTUtJQ0FnSUM4dklHbG1JRzl3TG1aaGJHTnZibDkyWlhKcFpua29iV1Z6YzJGblpTd2djMmxuYm1GMGRYSmxjMXRwWFM1aWVYUmxjeXdnY0hWaWEyVjVLVG9LSUNBZ0lHUnBaeUEzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJKNWRHVmZiR1Z1WjNSb1gyVnNaVzFsYm5RS0lDQWdJR1JwWnlBeE53b2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQm1ZV3hqYjI1ZmRtVnlhV1o1Q2lBZ0lDQmllaUJ6ZFdKdGFYUmZjSEp2Y0c5ellXeGZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hOalFLSUNBZ0lDOHZJSFpsY21sbWFXVmtJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREV3Q2dwemRXSnRhWFJmY0hKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRVMUNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYzJsbmJtRjBkWEpsY3k1c1pXNW5kR2dwT2dvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4TVFvZ0lDQWdZaUJ6ZFdKdGFYUmZjSEp2Y0c5ellXeGZabTl5WDJobFlXUmxja0EyQ2dwemRXSnRhWFJmY0hKdmNHOXpZV3hmWVdaMFpYSmZabTl5UURFeE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVFkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdkbVZ5YVdacFpXUWdQajBnYzJWc1ppNTBhSEpsYzJodmJHUXVkbUZzZFdVc0lDSlJkVzl5ZFcwZ2JtOTBJSEpsWVdOb1pXUWc0b0NVSUhCeWIzQnZjMkZzSUhKbGFtVmpkR1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJvY21WemFHOXNaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGFISmxjMmh2YkdRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVWFZ2Y25WdElHNXZkQ0J5WldGamFHVmtJT0tBbENCd2NtOXdiM05oYkNCeVpXcGxZM1JsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1UWTRMVEUzTkFvZ0lDQWdMeThnSXlCUmRXOXlkVzBnY21WaFkyaGxaQ0RpZ0pRZ1pYaGxZM1YwWlNCMGFHVWdkSEpsWVhOMWNua2djR0Y1YldWdWRBb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhKbFkybHdhV1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdJQ0FnSUc1dmRHVTlZaUpoYkdkdkxYQnhZeTFyYVhRNlpHRnZPbkJ5YjNCdmMyRnNPaUlnS3lCdmNDNXBkRzlpS0hCeWIzQnZjMkZzWDJsa0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRTNNZ29nSUNBZ0x5OGdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJR2RzYjJKaGJDQk5hVzVVZUc1R1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdjV05mWkdGdkxuQjVPakUzTXdvZ0lDQWdMeThnYm05MFpUMWlJbUZzWjI4dGNIRmpMV3RwZERwa1lXODZjSEp2Y0c5ellXdzZJaUFySUc5d0xtbDBiMklvY0hKdmNHOXpZV3hmYVdRcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qRTJZelkzTm1ZeVpEY3dOekUyTXpKa05tSTJPVGMwTTJFMk5EWXhObVl6WVRjd056STJaamN3Tm1ZM016WXhObU16WVFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FYUjRibDltYVdWc1pDQk9iM1JsQ2lBZ0lDQmthV2NnT0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdScFp5QTVDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRTJPQzB4TmprS0lDQWdJQzh2SUNNZ1VYVnZjblZ0SUhKbFlXTm9aV1FnNG9DVUlHVjRaV04xZEdVZ2RHaGxJSFJ5WldGemRYSjVJSEJoZVcxbGJuUUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTWlBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjSEZqWDJSaGJ5NXdlVG94TmpndE1UYzBDaUFnSUNBdkx5QWpJRkYxYjNKMWJTQnlaV0ZqYUdWa0lPS0FsQ0JsZUdWamRYUmxJSFJvWlNCMGNtVmhjM1Z5ZVNCd1lYbHRaVzUwQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljbVZqYVhCcFpXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0F2THlBZ0lDQWdibTkwWlQxaUltRnNaMjh0Y0hGakxXdHBkRHBrWVc4NmNISnZjRzl6WVd3NklpQXJJRzl3TG1sMGIySW9jSEp2Y0c5ellXeGZhV1FwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3Y1dOZlpHRnZMbkI1T2pFM09DMHhOemtLSUNBZ0lDOHZJRzl3TG1sMGIySW9jSEp2Y0c5ellXeGZhV1FwQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvWVcxdmRXNTBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hOemd0TVRnd0NpQWdJQ0F2THlCdmNDNXBkRzlpS0hCeWIzQnZjMkZzWDJsa0tRb2dJQ0FnTHk4Z0t5QnZjQzVwZEc5aUtHRnRiM1Z1ZENrS0lDQWdJQzh2SUNzZ2NtVmphWEJwWlc1MExtSjVkR1Z6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRTNPQzB4T0RFS0lDQWdJQzh2SUc5d0xtbDBiMklvY0hKdmNHOXpZV3hmYVdRcENpQWdJQ0F2THlBcklHOXdMbWwwYjJJb1lXMXZkVzUwS1FvZ0lDQWdMeThnS3lCeVpXTnBjR2xsYm5RdVlubDBaWE1LSUNBZ0lDOHZJQ3NnWkdWelkxOW9ZWE5vQ2lBZ0lDQmthV2NnTVRnS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVGd5Q2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvVlVsdWREWTBLRkJTVDFCUFUwRk1YMFZZUlVOVlZFVkVLU2tLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVGM0TFRFNE1nb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlod2NtOXdiM05oYkY5cFpDa0tJQ0FnSUM4dklDc2diM0F1YVhSdllpaGhiVzkxYm5RcENpQWdJQ0F2THlBcklISmxZMmx3YVdWdWRDNWllWFJsY3dvZ0lDQWdMeThnS3lCa1pYTmpYMmhoYzJnS0lDQWdJQzh2SUNzZ2IzQXVhWFJ2WWloVlNXNTBOalFvVUZKUFVFOVRRVXhmUlZoRlExVlVSVVFwS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hPRFFLSUNBZ0lDOHZJRzl3TGtKdmVDNXdkWFFvWWlKd2NtOXdYeUlnS3lCdmNDNXBkRzlpS0hCeWIzQnZjMkZzWDJsa0tTd2djSEp2Y0Y5a1lYUmhLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROekEzTWpabU56QTFaZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzQnhZMTlrWVc4dWNIazZNVEEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCd2NXTmZaR0Z2TGxCUlEwUmhieTVuWlhSZmNISnZjRzl6WVd4ZlkyOTFiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjSEp2Y0c5ellXeGZZMjkxYm5RNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hPVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5CeWIzQnZjMkZzWDJOdmRXNTBMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0hKdmNHOXpZV3hmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKdmNHOXpZV3hmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNIRmpYMlJoYnk1d2VUb3hPRGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSEJ4WTE5a1lXOHVVRkZEUkdGdkxtZGxkRjkwYUhKbGMyaHZiR1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZkR2h5WlhOb2IyeGtPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0J4WTE5a1lXOHVjSGs2TVRrMkNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBhSEpsYzJodmJHUXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYUhKbGMyaHZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHaHlaWE5vYjJ4a0lHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNCeFkxOWtZVzh1Y0hrNk1Ua3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QndjV05mWkdGdkxsQlJRMFJoYnk1blpYUmZiV1Z0WW1WeVgyTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMjFsYldKbGNsOWpiM1Z1ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qSXdNUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Ym5WdFgyMWxiV0psY25NdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnVkVzFmYldWdFltVnljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dWRXMWZiV1Z0WW1WeWN5QmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2NXTmZaR0Z2TG5CNU9qRTVPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV5Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkRDQUVBQUlCQ0NZRkNYUm9jbVZ6YUc5c1pBNXdjbTl3YjNOaGJGOWpiM1Z1ZEFRVkgzeDFDMjUxYlY5dFpXMWlaWEp6QTNCclh6RVpGRVF4R0VFQUs0SUZCQ2RuNWJBRUdEUEZJd1J0ajdwMEJNWlExYVFFNG4xUUhUWWFBSTRGQUtzQkh3S0NBbzBDbUFDQUJIeUVQVGsyR2dDT0FRQVhBSW9DQVl2K1Z3SUFpLzhqQzBzQlRGbEtXU01JV0lrMkdnRkpJbGtqQ0VzQkZSSkVWd0lBTmhvQ1NSVWxFa1FYTmhvRFNTSlpTVTRDSXd0TVNSVk1Wd0lBSWtsTEJReEJBQ1JIQWlNTFN3TkpUd0paU1VzSFNVNEVFa1JMQVJWU0lsa2pDQWhGQlNRSVJRRkMvOVZMQXlNSVN3TVNSRXNGU1VSSlN3WkpUZ0lPUkVsRWdBaGtZVzlmYm1GdFpVc0paeWhQQW1jcEltY3JUR2NrUTRBQVNUWWFBVWNDSWxsSlRnSWpDMHhKRlV4WEFnQWlTVXNGREVFQUpFY0NJd3RMQTBsUEFsbEpTd2RKVGdRU1JFc0JGVklpV1NNSUNFVUZKQWhGQVVMLzFVc0RJd2hMQXhKRUlrVUhTd1pMQlF4SlJRbEJBQnBMQmtrV0p3Uk1VRXNKUkVzSFN3S0kvdnEvSkFoRkIwTC8yeVJESWtjRWdBQkhBallhQVVraVdTTUlTd0VWRWtSWEFnQTJHZ0pKRllFZ0VrUTJHZ05KRlNVU1JCYzJHZ1JIQWlKWlNVNENJd3RNU1JWTVZ3SUFJa2xMQlF4QkFDUkhBaU1MU3dOSlR3SlpTVXNIU1U0RUVrUkxBUlZTSWxrakNBaEZCU1FJUlFGQy85VkxBeU1JU3dNU1JEWWFCVWxGRUVraVdVa2xDeU1JVHdJVkVrUWlLV1ZFU1NRSUtVeG5JaWhsUkVzSFNVOENEMFJQQWhKRVN3a0JTVVVUVEJaSlJSQkxDVkJMQ0JaSlJSQlFURkJGRUNKRkNpSkZDMHNLU3dVTVNVVU5RUUErU3c1WEFnQkxDMGxPQWlVTFd5SXJaVVJMQVExRUZpY0VURkMrUkVzTlJFc0hUd0tJL2dSTEVVeFBBb1ZCQUFaTENTUUlSUXBMQ2lRSVJRdEMvN2NpS0dWRVN3b09STEV5QUlBYVlXeG5ieTF3Y1dNdGEybDBPbVJoYnpwd2NtOXdiM05oYkRwTEQwbE9BMUN5QlVzSXNnaExDVW15QnlTeUVFeXlBYk5MQVVzUFVFeFFTeEpRZ1FNV1VJQUZjSEp2Y0Y5TEFsQk12eXBNVUxBa1F5SXBaVVFXS2t4UXNDUkRJaWhsUkJZcVRGQ3dKRU1pSzJWRUZpcE1VTEFrUXc9PSIsImNsZWFyIjoiRElFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
