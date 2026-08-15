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

namespace Arc56.Generated.wiseman_umanah.captre.CaptreApp_166648ce
{


    //
    // 
    //    On-chain attestation registry.
    //
    //    Stores first-claim attestations keyed by ``content_hash`` and provides a
    //    secondary index from ``attestation_id`` (UUID) to ``content_hash``.
    //
    //    Attributes
    //    ----------
    //    attestations : BoxMap[Bytes, Bytes]
    //        Maps ``content_hash_key`` (32-byte SHA-256 digest of the original
    //        content_hash string) → serialised JSON metadata blob.
    //        Box key prefix: ``b"a:"``. Box name is always 34 bytes.
    //    id_index : BoxMap[Bytes, Bytes]
    //        Maps ``attestation_id`` → ``content_hash_str`` (the original human-
    //        readable content_hash string, e.g. ``"sha256:<hex>"``).
    //        Box key prefix: ``b"i:"``.
    //    
    //
    public class CaptreAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CaptreAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Write a new attestation. Fails if the ``content_hash_key`` is already claimed.
        ///</summary>
        /// <param name="content_hash_key">32-byte SHA-256 digest of the original content_hash string. Used as the ``attestations`` box key. Must not already exist — aborts with ``ERR_ALREADY_CLAIMED`` if so. </param>
        /// <param name="content_hash_str">The original content_hash string (e.g. ``b"sha256:abc123..."``), UTF-8 encoded. Stored in ``id_index`` so callers can recover it via ``resolve_id()``. </param>
        /// <param name="attestation_id">Server-generated UUID for this attestation (UTF-8 encoded). Used as the key in ``id_index``. </param>
        /// <param name="author">Algorand address of the payer (from the x402 payment payload). Stored inside ``metadata_json``; validated non-empty here. </param>
        /// <param name="metadata_json">Full JSON-serialised ``Attestation`` record. Written verbatim to the ``attestations`` box. </param>
        public async Task Attest(byte[] content_hash_key, byte[] content_hash_str, byte[] attestation_id, string author, byte[] metadata_json, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 134, 23, 53 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);
            var content_hash_strAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_strAbi.From(content_hash_str);
            var attestation_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); attestation_idAbi.From(attestation_id);
            var authorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); authorAbi.From(author);
            var metadata_jsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_jsonAbi.From(metadata_json);

            var result = await base.CallApp(new List<object> { abiHandle, content_hash_keyAbi, content_hash_strAbi, attestation_idAbi, authorAbi, metadata_jsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Attest_Transactions(byte[] content_hash_key, byte[] content_hash_str, byte[] attestation_id, string author, byte[] metadata_json, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 134, 23, 53 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);
            var content_hash_strAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_strAbi.From(content_hash_str);
            var attestation_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); attestation_idAbi.From(attestation_id);
            var authorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); authorAbi.From(author);
            var metadata_jsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_jsonAbi.From(metadata_json);

            return await base.MakeTransactionList(new List<object> { abiHandle, content_hash_keyAbi, content_hash_strAbi, attestation_idAbi, authorAbi, metadata_jsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Overwrite an existing attestation box with updated (revoked) metadata.
        ///</summary>
        /// <param name="content_hash_key">32-byte SHA-256 digest key of the attestation box to update. Must already exist — aborts with ``ERR_NOT_FOUND`` if not. </param>
        /// <param name="author">Algorand address of the revoking payer (included for audit; not re-validated on-chain — authorization is enforced off-chain in ``revoke_attestation()`` before this call is submitted). </param>
        /// <param name="updated_metadata_json">Updated JSON blob with ``status`` set to ``"revoked"``. </param>
        public async Task Revoke(byte[] content_hash_key, string author, byte[] updated_metadata_json, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 113, 0, 153 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);
            var authorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); authorAbi.From(author);
            var updated_metadata_jsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); updated_metadata_jsonAbi.From(updated_metadata_json);

            var result = await base.CallApp(new List<object> { abiHandle, content_hash_keyAbi, authorAbi, updated_metadata_jsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Revoke_Transactions(byte[] content_hash_key, string author, byte[] updated_metadata_json, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 113, 0, 153 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);
            var authorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); authorAbi.From(author);
            var updated_metadata_jsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); updated_metadata_jsonAbi.From(updated_metadata_json);

            return await base.MakeTransactionList(new List<object> { abiHandle, content_hash_keyAbi, authorAbi, updated_metadata_jsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read an attestation record by ``content_hash_key``.
        ///</summary>
        /// <param name="content_hash_key">The 32-byte SHA-256 digest key to look up. </param>
        public async Task<byte[]> GetAttestation(byte[] content_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 122, 17, 116 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);

            var result = await base.SimApp(new List<object> { abiHandle, content_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetAttestation_Transactions(byte[] content_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 122, 17, 116 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, content_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Resolve an ``attestation_id`` UUID to its ``content_hash``.
        ///</summary>
        /// <param name="attestation_id">UTF-8 encoded UUID (e.g. ``b"a00fe88e-..."``) to look up in the ``id_index`` BoxMap. </param>
        public async Task<byte[]> ResolveId(byte[] attestation_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 120, 238, 152 };
            var attestation_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); attestation_idAbi.From(attestation_id);

            var result = await base.SimApp(new List<object> { abiHandle, attestation_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ResolveId_Transactions(byte[] attestation_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 120, 238, 152 };
            var attestation_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); attestation_idAbi.From(attestation_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, attestation_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check whether a ``content_hash_key`` has already been attested.
        ///</summary>
        /// <param name="content_hash_key">The 32-byte SHA-256 digest key to check. </param>
        public async Task<bool> Exists(byte[] content_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 239, 30, 245 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);

            var result = await base.SimApp(new List<object> { abiHandle, content_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Exists_Transactions(byte[] content_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 239, 30, 245 };
            var content_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); content_hash_keyAbi.From(content_hash_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, content_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FwdHJlQXBwIiwiZGVzYyI6IlxuICAgIE9uLWNoYWluIGF0dGVzdGF0aW9uIHJlZ2lzdHJ5LlxuXG4gICAgU3RvcmVzIGZpcnN0LWNsYWltIGF0dGVzdGF0aW9ucyBrZXllZCBieSBgYGNvbnRlbnRfaGFzaGBgIGFuZCBwcm92aWRlcyBhXG4gICAgc2Vjb25kYXJ5IGluZGV4IGZyb20gYGBhdHRlc3RhdGlvbl9pZGBgIChVVUlEKSB0byBgYGNvbnRlbnRfaGFzaGBgLlxuXG4gICAgQXR0cmlidXRlc1xuICAgIC0tLS0tLS0tLS1cbiAgICBhdHRlc3RhdGlvbnMgOiBCb3hNYXBbQnl0ZXMsIEJ5dGVzXVxuICAgICAgICBNYXBzIGBgY29udGVudF9oYXNoX2tleWBgICgzMi1ieXRlIFNIQS0yNTYgZGlnZXN0IG9mIHRoZSBvcmlnaW5hbFxuICAgICAgICBjb250ZW50X2hhc2ggc3RyaW5nKSDihpIgc2VyaWFsaXNlZCBKU09OIG1ldGFkYXRhIGJsb2IuXG4gICAgICAgIEJveCBrZXkgcHJlZml4OiBgYGJcImE6XCJgYC4gQm94IG5hbWUgaXMgYWx3YXlzIDM0IGJ5dGVzLlxuICAgIGlkX2luZGV4IDogQm94TWFwW0J5dGVzLCBCeXRlc11cbiAgICAgICAgTWFwcyBgYGF0dGVzdGF0aW9uX2lkYGAg4oaSIGBgY29udGVudF9oYXNoX3N0cmBgICh0aGUgb3JpZ2luYWwgaHVtYW4tXG4gICAgICAgIHJlYWRhYmxlIGNvbnRlbnRfaGFzaCBzdHJpbmcsIGUuZy4gYGBcInNoYTI1Njo8aGV4PlwiYGApLlxuICAgICAgICBCb3gga2V5IHByZWZpeDogYGBiXCJpOlwiYGAuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImF0dGVzdCIsImRlc2MiOiJXcml0ZSBhIG5ldyBhdHRlc3RhdGlvbi4gRmFpbHMgaWYgdGhlIGBgY29udGVudF9oYXNoX2tleWBgIGlzIGFscmVhZHkgY2xhaW1lZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udGVudF9oYXNoX2tleSIsImRlc2MiOiIzMi1ieXRlIFNIQS0yNTYgZGlnZXN0IG9mIHRoZSBvcmlnaW5hbCBjb250ZW50X2hhc2ggc3RyaW5nLiBVc2VkIGFzIHRoZSBgYGF0dGVzdGF0aW9uc2BgIGJveCBrZXkuIE11c3Qgbm90IGFscmVhZHkgZXhpc3Qg4oCUIGFib3J0cyB3aXRoIGBgRVJSX0FMUkVBRFlfQ0xBSU1FRGBgIGlmIHNvLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udGVudF9oYXNoX3N0ciIsImRlc2MiOiJUaGUgb3JpZ2luYWwgY29udGVudF9oYXNoIHN0cmluZyAoZS5nLiBgYGJcInNoYTI1NjphYmMxMjMuLi5cImBgKSwgVVRGLTggZW5jb2RlZC4gU3RvcmVkIGluIGBgaWRfaW5kZXhgYCBzbyBjYWxsZXJzIGNhbiByZWNvdmVyIGl0IHZpYSBgYHJlc29sdmVfaWQoKWBgLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXR0ZXN0YXRpb25faWQiLCJkZXNjIjoiU2VydmVyLWdlbmVyYXRlZCBVVUlEIGZvciB0aGlzIGF0dGVzdGF0aW9uIChVVEYtOCBlbmNvZGVkKS4gVXNlZCBhcyB0aGUga2V5IGluIGBgaWRfaW5kZXhgYC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvciIsImRlc2MiOiJBbGdvcmFuZCBhZGRyZXNzIG9mIHRoZSBwYXllciAoZnJvbSB0aGUgeDQwMiBwYXltZW50IHBheWxvYWQpLiBTdG9yZWQgaW5zaWRlIGBgbWV0YWRhdGFfanNvbmBgOyB2YWxpZGF0ZWQgbm9uLWVtcHR5IGhlcmUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhZGF0YV9qc29uIiwiZGVzYyI6IkZ1bGwgSlNPTi1zZXJpYWxpc2VkIGBgQXR0ZXN0YXRpb25gYCByZWNvcmQuIFdyaXR0ZW4gdmVyYmF0aW0gdG8gdGhlIGBgYXR0ZXN0YXRpb25zYGAgYm94LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2UiLCJkZXNjIjoiT3ZlcndyaXRlIGFuIGV4aXN0aW5nIGF0dGVzdGF0aW9uIGJveCB3aXRoIHVwZGF0ZWQgKHJldm9rZWQpIG1ldGFkYXRhLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb250ZW50X2hhc2hfa2V5IiwiZGVzYyI6IjMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IG9mIHRoZSBhdHRlc3RhdGlvbiBib3ggdG8gdXBkYXRlLiBNdXN0IGFscmVhZHkgZXhpc3Qg4oCUIGFib3J0cyB3aXRoIGBgRVJSX05PVF9GT1VORGBgIGlmIG5vdC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvciIsImRlc2MiOiJBbGdvcmFuZCBhZGRyZXNzIG9mIHRoZSByZXZva2luZyBwYXllciAoaW5jbHVkZWQgZm9yIGF1ZGl0OyBub3QgcmUtdmFsaWRhdGVkIG9uLWNoYWluIOKAlCBhdXRob3JpemF0aW9uIGlzIGVuZm9yY2VkIG9mZi1jaGFpbiBpbiBgYHJldm9rZV9hdHRlc3RhdGlvbigpYGAgYmVmb3JlIHRoaXMgY2FsbCBpcyBzdWJtaXR0ZWQpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBkYXRlZF9tZXRhZGF0YV9qc29uIiwiZGVzYyI6IlVwZGF0ZWQgSlNPTiBibG9iIHdpdGggYGBzdGF0dXNgYCBzZXQgdG8gYGBcInJldm9rZWRcImBgLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXR0ZXN0YXRpb24iLCJkZXNjIjoiUmVhZCBhbiBhdHRlc3RhdGlvbiByZWNvcmQgYnkgYGBjb250ZW50X2hhc2hfa2V5YGAuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRlbnRfaGFzaF9rZXkiLCJkZXNjIjoiVGhlIDMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IHRvIGxvb2sgdXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSByYXcgSlNPTiBtZXRhZGF0YSBibG9iIHN0b3JlZCBpbiB0aGUgYm94LCBvciBgYGJcIlwiYGAgaWYgbm8gYm94IGV4aXN0cyBmb3IgdGhpcyBrZXkuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlX2lkIiwiZGVzYyI6IlJlc29sdmUgYW4gYGBhdHRlc3RhdGlvbl9pZGBgIFVVSUQgdG8gaXRzIGBgY29udGVudF9oYXNoYGAuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF0dGVzdGF0aW9uX2lkIiwiZGVzYyI6IlVURi04IGVuY29kZWQgVVVJRCAoZS5nLiBgYGJcImEwMGZlODhlLS4uLlwiYGApIHRvIGxvb2sgdXAgaW4gdGhlIGBgaWRfaW5kZXhgYCBCb3hNYXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBgYGNvbnRlbnRfaGFzaGBgIGJ5dGVzIHN0b3JlZCBhdCB0aGlzIFVVSUQga2V5LCBvciBgYGJcIlwiYGAgaWYgdGhlIFVVSUQgaGFzIG5ldmVyIGJlZW4gYXR0ZXN0ZWQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleGlzdHMiLCJkZXNjIjoiQ2hlY2sgd2hldGhlciBhIGBgY29udGVudF9oYXNoX2tleWBgIGhhcyBhbHJlYWR5IGJlZW4gYXR0ZXN0ZWQuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRlbnRfaGFzaF9rZXkiLCJkZXNjIjoiVGhlIDMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IHRvIGNoZWNrLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiYGBUcnVlYGAgaWYgYSBib3ggZXhpc3RzIGZvciB0aGlzIGtleSwgYGBGYWxzZWBgIG90aGVyd2lzZS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjoiRVJSX0FMUkVBRFlfQ0xBSU1FRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OF0sImVycm9yTWVzc2FnZSI6IkVSUl9FTVBUWV9BVVRIT1IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzZdLCJlcnJvck1lc3NhZ2UiOiJFUlJfRU1QVFlfSEFTSCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MF0sImVycm9yTWVzc2FnZSI6IkVSUl9FTVBUWV9IQVNIX1NUUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NF0sImVycm9yTWVzc2FnZSI6IkVSUl9FTVBUWV9JRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MiwyNjRdLCJlcnJvck1lc3NhZ2UiOiJFUlJfRU1QVFlfTUVUQURBVEEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjBdLCJlcnJvck1lc3NhZ2UiOiJFUlJfTk9UX0ZPVU5EIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hdHRlc3RhdGlvbnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pZF9pbmRleCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OCwxMDQsMTIwLDEzNiwxNTIsMjEzLDIyOSwyNDEsMjc3LDMyNCwzNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NSwxMTEsMTI3LDE0MywxNTksMjIwLDIzNSwyNDgsMjg0LDMzMSwzNzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNUW9nSUNBZ1lubDBaV05pYkc5amF5QXdlRFl4TTJFZ01IZ3hOVEZtTjJNM05TQXdlRFk1TTJFZ01IZ0tJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveU9Bb2dJQ0FnTHk4Z1kyeGhjM01nUTJGd2RISmxRWEJ3S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TXpjNE5qRTNNelVnTUhobE9EY3hNREE1T1NBd2VHVTROMkV4TVRjMElEQjRPRFUzT0dWbE9UZ2dNSGcxWldWbU1XVm1OU0F2THlCdFpYUm9iMlFnSW1GMGRHVnpkQ2hpZVhSbFcxMHNZbmwwWlZ0ZExHSjVkR1ZiWFN4emRISnBibWNzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxkbTlyWlNoaWVYUmxXMTBzYzNSeWFXNW5MR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZZWFIwWlhOMFlYUnBiMjRvWW5sMFpWdGRLV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWljbVZ6YjJ4MlpWOXBaQ2hpZVhSbFcxMHBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSmxlR2x6ZEhNb1lubDBaVnRkS1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JoZEhSbGMzUWdjbVYyYjJ0bElHZGxkRjloZEhSbGMzUmhkR2x2YmlCeVpYTnZiSFpsWDJsa0lHVjRhWE4wY3dvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpZWEIwY21WZllYQndMa05oY0hSeVpVRndjQzVoZEhSbGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoZEhSbGMzUTZDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwyTmhjSFJ5WlY5aGNIQXVjSGs2T1RnS0lDQWdJQzh2SUdGemMyVnlkQ0JqYjI1MFpXNTBYMmhoYzJoZmEyVjVJRzV2ZENCcGJpQnpaV3htTG1GMGRHVnpkR0YwYVc5dWN5d2dJa1ZTVWw5QlRGSkZRVVJaWDBOTVFVbE5SVVFpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpFellRb2dJQ0FnWkdsbklEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpmUVV4U1JVRkVXVjlEVEVGSlRVVkVDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCamIyNTBaVzUwWDJoaGMyaGZhMlY1TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrVlNVbDlGVFZCVVdWOUlRVk5JSWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSmZSVTFRVkZsZlNFRlRTQW9nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzlqWVhCMGNtVmZZWEJ3TG5CNU9qRXdNQW9nSUNBZ0x5OGdZWE56WlhKMElHTnZiblJsYm5SZmFHRnphRjl6ZEhJdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RBcExDQWlSVkpTWDBWTlVGUlpYMGhCVTBoZlUxUlNJZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklFVlNVbDlGVFZCVVdWOUlRVk5JWDFOVVVnb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pFd01Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGMGRHVnpkR0YwYVc5dVgybGtMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3dLU3dnSWtWU1VsOUZUVkJVV1Y5SlJDSUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSmZSVTFRVkZsZlNVUUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE1ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGRYUm9iM0l1WW5sMFpYTXViR1Z1WjNSb0lENGdWVWx1ZERZMEtEQXBMQ0FpUlZKU1gwVk5VRlJaWDBGVlZFaFBVaUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1gwVk5VRlJaWDBGVlZFaFBVZ29nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzlqWVhCMGNtVmZZWEJ3TG5CNU9qRXdNd29nSUNBZ0x5OGdZWE56WlhKMElHMWxkR0ZrWVhSaFgycHpiMjR1YkdWdVozUm9JRDRnVlVsdWREWTBLREFwTENBaVJWSlNYMFZOVUZSWlgwMUZWRUZFUVZSQklnb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VsOUZUVkJVV1Y5TlJWUkJSRUZVUVFvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakV3TkFvZ0lDQWdMeThnYzJWc1ppNWhkSFJsYzNSaGRHbHZibk5iWTI5dWRHVnVkRjlvWVhOb1gydGxlVjBnUFNCdFpYUmhaR0YwWVY5cWMyOXVDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakV3TlFvZ0lDQWdMeThnYzJWc1ppNXBaRjlwYm1SbGVGdGhkSFJsYzNSaGRHbHZibDlwWkYwZ1BTQmpiMjUwWlc1MFgyaGhjMmhmYzNSeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5qa3pZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pVeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpZWEIwY21WZllYQndMa05oY0hSeVpVRndjQzV5WlhadmEyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhadmEyVTZDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk1UQTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk1UTTJDaUFnSUNBdkx5QmhjM05sY25RZ1kyOXVkR1Z1ZEY5b1lYTm9YMnRsZVNCcGJpQnpaV3htTG1GMGRHVnpkR0YwYVc5dWN5d2dJa1ZTVWw5T1QxUmZSazlWVGtRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRXpZUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTWDA1UFZGOUdUMVZPUkFvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakV6TndvZ0lDQWdMeThnWVhOelpYSjBJSFZ3WkdGMFpXUmZiV1YwWVdSaGRHRmZhbk52Ymk1c1pXNW5kR2dnUGlCVlNXNTBOalFvTUNrc0lDSkZVbEpmUlUxUVZGbGZUVVZVUVVSQlZFRWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNYMFZOVUZSWlgwMUZWRUZFUVZSQkNpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwyTmhjSFJ5WlY5aGNIQXVjSGs2TVRNNENpQWdJQ0F2THlCelpXeG1MbUYwZEdWemRHRjBhVzl1YzF0amIyNTBaVzUwWDJoaGMyaGZhMlY1WFNBOUlIVndaR0YwWldSZmJXVjBZV1JoZEdGZmFuTnZiZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdlkyRndkSEpsWDJGd2NDNXdlVG94TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTmhjSFJ5WlY5aGNIQXVRMkZ3ZEhKbFFYQndMbWRsZEY5aGRIUmxjM1JoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5aGRIUmxjM1JoZEdsdmJqb0tJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE5EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdlkyRndkSEpsWDJGd2NDNXdlVG94TlRZS0lDQWdJQzh2SUdsbUlHTnZiblJsYm5SZmFHRnphRjlyWlhrZ2FXNGdjMlZzWmk1aGRIUmxjM1JoZEdsdmJuTTZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakV6WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwWDJGMGRHVnpkR0YwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakUxTndvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVlYUjBaWE4wWVhScGIyNXpXMk52Ym5SbGJuUmZhR0Z6YUY5clpYbGRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoZEhSbGMzUmhkR2x2Ym5NZ1pXNTBjbmtnWlhocGMzUnpDZ3BuWlhSZllYUjBaWE4wWVhScGIyNWZZV1owWlhKZmFXNXNhVzVsWkY5allYQjBjbVZmWVhCd0xrTmhjSFJ5WlVGd2NDNW5aWFJmWVhSMFpYTjBZWFJwYjI1QU5Eb0tJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE5EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5aGRIUmxjM1JoZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdlkyRndkSEpsWDJGd2NDNXdlVG94TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJDZVhSbGN5aGlJaUlwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Q2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDJOaGNIUnlaVjloY0hBdWNIazZNVFF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWjJWMFgyRjBkR1Z6ZEdGMGFXOXVYMkZtZEdWeVgybHViR2x1WldSZlkyRndkSEpsWDJGd2NDNURZWEIwY21WQmNIQXVaMlYwWDJGMGRHVnpkR0YwYVc5dVFEUUtDZ292THlCallYQjBjbVZmWVhCd0xrTmhjSFJ5WlVGd2NDNXlaWE52YkhabFgybGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WemIyeDJaVjlwWkRvS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdlkyRndkSEpsWDJGd2NDNXdlVG94TmpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2WTJGd2RISmxYMkZ3Y0M1d2VUb3hOemNLSUNBZ0lDOHZJR2xtSUdGMGRHVnpkR0YwYVc5dVgybGtJR2x1SUhObGJHWXVhV1JmYVc1a1pYZzZDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROamt6WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2djbVZ6YjJ4MlpWOXBaRjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE56Z0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbWxrWDJsdVpHVjRXMkYwZEdWemRHRjBhVzl1WDJsa1hRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhV1JmYVc1a1pYZ2daVzUwY25rZ1pYaHBjM1J6Q2dweVpYTnZiSFpsWDJsa1gyRm1kR1Z5WDJsdWJHbHVaV1JmWTJGd2RISmxYMkZ3Y0M1RFlYQjBjbVZCY0hBdWNtVnpiMngyWlY5cFpFQTBPZ29nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzlqWVhCMGNtVmZZWEJ3TG5CNU9qRTJNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WemIyeDJaVjlwWkY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2WTJGd2RISmxYMkZ3Y0M1d2VUb3hOemtLSUNBZ0lDOHZJSEpsZEhWeWJpQkNlWFJsY3loaUlpSXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk1UWXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdjbVZ6YjJ4MlpWOXBaRjloWm5SbGNsOXBibXhwYm1Wa1gyTmhjSFJ5WlY5aGNIQXVRMkZ3ZEhKbFFYQndMbkpsYzI5c2RtVmZhV1JBTkFvS0NpOHZJR05oY0hSeVpWOWhjSEF1UTJGd2RISmxRWEJ3TG1WNGFYTjBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WNGFYTjBjem9LSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2WTJGd2RISmxYMkZ3Y0M1d2VUb3hPREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE9UWUtJQ0FnSUM4dklISmxkSFZ5YmlCamIyNTBaVzUwWDJoaGMyaGZhMlY1SUdsdUlITmxiR1l1WVhSMFpYTjBZWFJwYjI1ekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRXpZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE9ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFJQkpnUUNZVG9FRlI5OGRRSnBPZ0F4RzBFQU1qRVpGRVF4R0VTQ0JRUTNoaGMxQk9oeEFKa0U2SG9SZEFTRmVPNllCRjd2SHZVMkdnQ09CUUFKQUlZQXhnRDFBU1FBTVJrVU1SZ1VFRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFOaG9DU1NKWkl3aExBUlVTUkZjQ0FEWWFBMGtpV1NNSVN3RVZFa1JYQWdBMkdnUkpJbGtqQ0VzQkZSSkVWd0lBTmhvRlNTSlpJd2hMQVJVU1JGY0NBQ2hMQlZCSnZVVUJGRVJQQlJWRVN3UVZSRXNERlVSUEFoVkVTd0VWUkVtOFNFeS9La3hRU2J4SVRMOGtRellhQVVraVdTTUlTd0VWRWtSWEFnQTJHZ0pKSWxrakNFd1ZFa1EyR2dOSklsa2pDRXNCRlJKRVZ3SUFLRThDVUVtOVJRRkVTd0VWUkVtOFNFeS9KRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFLRXhRU2IxRkFVRUFFTDVFU1JVV1Z3WUNURkFwVEZDd0pFTklLMEwvN1RZYUFVa2lXU01JU3dFVkVrUlhBZ0FxVEZCSnZVVUJRUUFRdmtSSkZSWlhCZ0pNVUNsTVVMQWtRMGdyUXYvdE5ob0JTU0paSXdoTEFSVVNSRmNDQUNoTVVMMUZBWUFCQUNKUEFsUXBURkN3SkVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
