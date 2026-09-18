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
        ///Delete a single box by its key (without prefix). Creator-only.
        ///Used during MBR reclaim before contract migration. Each deletion releases the box's MBR back to the contract account so the balance can be recovered before the app is deleted.
        ///</summary>
        /// <param name="box_key">The key portion of the box name **without** the prefix. For attestation boxes this is the 32-byte SHA-256 digest. For id_index boxes this is the UUID bytes. </param>
        /// <param name="is_attestation">``True`` to delete from ``attestations`` (prefix ``b"a:"``). ``False`` to delete from ``id_index`` (prefix ``b"i:"``). </param>
        public async Task AdminDeleteBox(byte[] box_key, bool is_attestation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 102, 128, 221 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); box_keyAbi.From(box_key);
            var is_attestationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_attestationAbi.From(is_attestation);

            var result = await base.CallApp(new List<object> { abiHandle, box_keyAbi, is_attestationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminDeleteBox_Transactions(byte[] box_key, bool is_attestation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 102, 128, 221 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); box_keyAbi.From(box_key);
            var is_attestationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_attestationAbi.From(is_attestation);

            return await base.MakeTransactionList(new List<object> { abiHandle, box_keyAbi, is_attestationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FwdHJlQXBwIiwiZGVzYyI6IlxuICAgIE9uLWNoYWluIGF0dGVzdGF0aW9uIHJlZ2lzdHJ5LlxuXG4gICAgU3RvcmVzIGZpcnN0LWNsYWltIGF0dGVzdGF0aW9ucyBrZXllZCBieSBgYGNvbnRlbnRfaGFzaGBgIGFuZCBwcm92aWRlcyBhXG4gICAgc2Vjb25kYXJ5IGluZGV4IGZyb20gYGBhdHRlc3RhdGlvbl9pZGBgIChVVUlEKSB0byBgYGNvbnRlbnRfaGFzaGBgLlxuXG4gICAgQXR0cmlidXRlc1xuICAgIC0tLS0tLS0tLS1cbiAgICBhdHRlc3RhdGlvbnMgOiBCb3hNYXBbQnl0ZXMsIEJ5dGVzXVxuICAgICAgICBNYXBzIGBgY29udGVudF9oYXNoX2tleWBgICgzMi1ieXRlIFNIQS0yNTYgZGlnZXN0IG9mIHRoZSBvcmlnaW5hbFxuICAgICAgICBjb250ZW50X2hhc2ggc3RyaW5nKSDihpIgc2VyaWFsaXNlZCBKU09OIG1ldGFkYXRhIGJsb2IuXG4gICAgICAgIEJveCBrZXkgcHJlZml4OiBgYGJcImE6XCJgYC4gQm94IG5hbWUgaXMgYWx3YXlzIDM0IGJ5dGVzLlxuICAgIGlkX2luZGV4IDogQm94TWFwW0J5dGVzLCBCeXRlc11cbiAgICAgICAgTWFwcyBgYGF0dGVzdGF0aW9uX2lkYGAg4oaSIGBgY29udGVudF9oYXNoX3N0cmBgICh0aGUgb3JpZ2luYWwgaHVtYW4tXG4gICAgICAgIHJlYWRhYmxlIGNvbnRlbnRfaGFzaCBzdHJpbmcsIGUuZy4gYGBcInNoYTI1Njo8aGV4PlwiYGApLlxuICAgICAgICBCb3gga2V5IHByZWZpeDogYGBiXCJpOlwiYGAuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImF0dGVzdCIsImRlc2MiOiJXcml0ZSBhIG5ldyBhdHRlc3RhdGlvbi4gRmFpbHMgaWYgdGhlIGBgY29udGVudF9oYXNoX2tleWBgIGlzIGFscmVhZHkgY2xhaW1lZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udGVudF9oYXNoX2tleSIsImRlc2MiOiIzMi1ieXRlIFNIQS0yNTYgZGlnZXN0IG9mIHRoZSBvcmlnaW5hbCBjb250ZW50X2hhc2ggc3RyaW5nLiBVc2VkIGFzIHRoZSBgYGF0dGVzdGF0aW9uc2BgIGJveCBrZXkuIE11c3Qgbm90IGFscmVhZHkgZXhpc3Qg4oCUIGFib3J0cyB3aXRoIGBgRVJSX0FMUkVBRFlfQ0xBSU1FRGBgIGlmIHNvLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udGVudF9oYXNoX3N0ciIsImRlc2MiOiJUaGUgb3JpZ2luYWwgY29udGVudF9oYXNoIHN0cmluZyAoZS5nLiBgYGJcInNoYTI1NjphYmMxMjMuLi5cImBgKSwgVVRGLTggZW5jb2RlZC4gU3RvcmVkIGluIGBgaWRfaW5kZXhgYCBzbyBjYWxsZXJzIGNhbiByZWNvdmVyIGl0IHZpYSBgYHJlc29sdmVfaWQoKWBgLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXR0ZXN0YXRpb25faWQiLCJkZXNjIjoiU2VydmVyLWdlbmVyYXRlZCBVVUlEIGZvciB0aGlzIGF0dGVzdGF0aW9uIChVVEYtOCBlbmNvZGVkKS4gVXNlZCBhcyB0aGUga2V5IGluIGBgaWRfaW5kZXhgYC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvciIsImRlc2MiOiJBbGdvcmFuZCBhZGRyZXNzIG9mIHRoZSBwYXllciAoZnJvbSB0aGUgeDQwMiBwYXltZW50IHBheWxvYWQpLiBTdG9yZWQgaW5zaWRlIGBgbWV0YWRhdGFfanNvbmBgOyB2YWxpZGF0ZWQgbm9uLWVtcHR5IGhlcmUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhZGF0YV9qc29uIiwiZGVzYyI6IkZ1bGwgSlNPTi1zZXJpYWxpc2VkIGBgQXR0ZXN0YXRpb25gYCByZWNvcmQuIFdyaXR0ZW4gdmVyYmF0aW0gdG8gdGhlIGBgYXR0ZXN0YXRpb25zYGAgYm94LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2UiLCJkZXNjIjoiT3ZlcndyaXRlIGFuIGV4aXN0aW5nIGF0dGVzdGF0aW9uIGJveCB3aXRoIHVwZGF0ZWQgKHJldm9rZWQpIG1ldGFkYXRhLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb250ZW50X2hhc2hfa2V5IiwiZGVzYyI6IjMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IG9mIHRoZSBhdHRlc3RhdGlvbiBib3ggdG8gdXBkYXRlLiBNdXN0IGFscmVhZHkgZXhpc3Qg4oCUIGFib3J0cyB3aXRoIGBgRVJSX05PVF9GT1VORGBgIGlmIG5vdC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvciIsImRlc2MiOiJBbGdvcmFuZCBhZGRyZXNzIG9mIHRoZSByZXZva2luZyBwYXllciAoaW5jbHVkZWQgZm9yIGF1ZGl0OyBub3QgcmUtdmFsaWRhdGVkIG9uLWNoYWluIOKAlCBhdXRob3JpemF0aW9uIGlzIGVuZm9yY2VkIG9mZi1jaGFpbiBpbiBgYHJldm9rZV9hdHRlc3RhdGlvbigpYGAgYmVmb3JlIHRoaXMgY2FsbCBpcyBzdWJtaXR0ZWQpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBkYXRlZF9tZXRhZGF0YV9qc29uIiwiZGVzYyI6IlVwZGF0ZWQgSlNPTiBibG9iIHdpdGggYGBzdGF0dXNgYCBzZXQgdG8gYGBcInJldm9rZWRcImBgLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXR0ZXN0YXRpb24iLCJkZXNjIjoiUmVhZCBhbiBhdHRlc3RhdGlvbiByZWNvcmQgYnkgYGBjb250ZW50X2hhc2hfa2V5YGAuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRlbnRfaGFzaF9rZXkiLCJkZXNjIjoiVGhlIDMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IHRvIGxvb2sgdXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSByYXcgSlNPTiBtZXRhZGF0YSBibG9iIHN0b3JlZCBpbiB0aGUgYm94LCBvciBgYGJcIlwiYGAgaWYgbm8gYm94IGV4aXN0cyBmb3IgdGhpcyBrZXkuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlX2lkIiwiZGVzYyI6IlJlc29sdmUgYW4gYGBhdHRlc3RhdGlvbl9pZGBgIFVVSUQgdG8gaXRzIGBgY29udGVudF9oYXNoYGAuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF0dGVzdGF0aW9uX2lkIiwiZGVzYyI6IlVURi04IGVuY29kZWQgVVVJRCAoZS5nLiBgYGJcImEwMGZlODhlLS4uLlwiYGApIHRvIGxvb2sgdXAgaW4gdGhlIGBgaWRfaW5kZXhgYCBCb3hNYXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBgYGNvbnRlbnRfaGFzaGBgIGJ5dGVzIHN0b3JlZCBhdCB0aGlzIFVVSUQga2V5LCBvciBgYGJcIlwiYGAgaWYgdGhlIFVVSUQgaGFzIG5ldmVyIGJlZW4gYXR0ZXN0ZWQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleGlzdHMiLCJkZXNjIjoiQ2hlY2sgd2hldGhlciBhIGBgY29udGVudF9oYXNoX2tleWBgIGhhcyBhbHJlYWR5IGJlZW4gYXR0ZXN0ZWQuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRlbnRfaGFzaF9rZXkiLCJkZXNjIjoiVGhlIDMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IHRvIGNoZWNrLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiYGBUcnVlYGAgaWYgYSBib3ggZXhpc3RzIGZvciB0aGlzIGtleSwgYGBGYWxzZWBgIG90aGVyd2lzZS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkbWluX2RlbGV0ZV9ib3giLCJkZXNjIjoiRGVsZXRlIGEgc2luZ2xlIGJveCBieSBpdHMga2V5ICh3aXRob3V0IHByZWZpeCkuIENyZWF0b3Itb25seS5cblVzZWQgZHVyaW5nIE1CUiByZWNsYWltIGJlZm9yZSBjb250cmFjdCBtaWdyYXRpb24uIEVhY2ggZGVsZXRpb24gcmVsZWFzZXMgdGhlIGJveCdzIE1CUiBiYWNrIHRvIHRoZSBjb250cmFjdCBhY2NvdW50IHNvIHRoZSBiYWxhbmNlIGNhbiBiZSByZWNvdmVyZWQgYmVmb3JlIHRoZSBhcHAgaXMgZGVsZXRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm94X2tleSIsImRlc2MiOiJUaGUga2V5IHBvcnRpb24gb2YgdGhlIGJveCBuYW1lICoqd2l0aG91dCoqIHRoZSBwcmVmaXguIEZvciBhdHRlc3RhdGlvbiBib3hlcyB0aGlzIGlzIHRoZSAzMi1ieXRlIFNIQS0yNTYgZGlnZXN0LiBGb3IgaWRfaW5kZXggYm94ZXMgdGhpcyBpcyB0aGUgVVVJRCBieXRlcy4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc19hdHRlc3RhdGlvbiIsImRlc2MiOiJgYFRydWVgYCB0byBkZWxldGUgZnJvbSBgYGF0dGVzdGF0aW9uc2BgIChwcmVmaXggYGBiXCJhOlwiYGApLiBgYEZhbHNlYGAgdG8gZGVsZXRlIGZyb20gYGBpZF9pbmRleGBgIChwcmVmaXggYGBiXCJpOlwiYGApLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3OV0sImVycm9yTWVzc2FnZSI6IkVSUl9BTFJFQURZX0NMQUlNRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTAsNDYyXSwiZXJyb3JNZXNzYWdlIjoiRVJSX0JPWF9OT1RfRk9VTkQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOiJFUlJfRU1QVFlfQVVUSE9SIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgzXSwiZXJyb3JNZXNzYWdlIjoiRVJSX0VNUFRZX0hBU0giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOiJFUlJfRU1QVFlfSEFTSF9TVFIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTFdLCJlcnJvck1lc3NhZ2UiOiJFUlJfRU1QVFlfSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTksMjcxXSwiZXJyb3JNZXNzYWdlIjoiRVJSX0VNUFRZX01FVEFEQVRBIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM5XSwiZXJyb3JNZXNzYWdlIjoiRVJSX05PVF9DUkVBVE9SIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY3XSwiZXJyb3JNZXNzYWdlIjoiRVJSX05PVF9GT1VORCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYXR0ZXN0YXRpb25zIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaWRfaW5kZXggZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTUsMTExLDEyNywxNDMsMTU5LDIyMCwyMzYsMjQ4LDI4NCwzMzEsMzc4LDQxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDIsMTE4LDEzNCwxNTAsMTY2LDIyNywyNDIsMjU1LDI5MSwzMzgsMzg1LDQyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURJZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEWXhNMkVnTUhnMk9UTmhJREI0TVRVeFpqZGpOelVnTUhnS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdlkyRndkSEpsWDJGd2NDNXdlVG96TXdvZ0lDQWdMeThnWTJ4aGMzTWdRMkZ3ZEhKbFFYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNemM0TmpFM016VWdNSGhsT0RjeE1EQTVPU0F3ZUdVNE4yRXhNVGMwSURCNE9EVTNPR1ZsT1RnZ01IZzFaV1ZtTVdWbU5TQXdlRGRoTmpZNE1HUmtJQzh2SUcxbGRHaHZaQ0FpWVhSMFpYTjBLR0o1ZEdWYlhTeGllWFJsVzEwc1lubDBaVnRkTEhOMGNtbHVaeXhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVjJiMnRsS0dKNWRHVmJYU3h6ZEhKcGJtY3NZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOWhkSFJsYzNSaGRHbHZiaWhpZVhSbFcxMHBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSnlaWE52YkhabFgybGtLR0o1ZEdWYlhTbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0ltVjRhWE4wY3loaWVYUmxXMTBwWW05dmJDSXNJRzFsZEdodlpDQWlZV1J0YVc1ZlpHVnNaWFJsWDJKdmVDaGllWFJsVzEwc1ltOXZiQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZWFIwWlhOMElISmxkbTlyWlNCblpYUmZZWFIwWlhOMFlYUnBiMjRnY21WemIyeDJaVjlwWkNCbGVHbHpkSE1nWVdSdGFXNWZaR1ZzWlhSbFgySnZlQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCallYQjBjbVZmWVhCd0xrTmhjSFJ5WlVGd2NDNWhkSFJsYzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhkSFJsYzNRNkNpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwyTmhjSFJ5WlY5aGNIQXVjSGs2TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDJOaGNIUnlaVjloY0hBdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdZMjl1ZEdWdWRGOW9ZWE5vWDJ0bGVTQnViM1FnYVc0Z2MyVnNaaTVoZEhSbGMzUmhkR2x2Ym5Nc0lDSkZVbEpmUVV4U1JVRkVXVjlEVEVGSlRVVkVJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TTJFS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNYMEZNVWtWQlJGbGZRMHhCU1UxRlJBb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pFd05Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJuUmxiblJmYUdGemFGOXJaWGt1YkdWdVozUm9JRDRnVlVsdWREWTBLREFwTENBaVJWSlNYMFZOVUZSWlgwaEJVMGdpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VsOUZUVkJVV1Y5SVFWTklDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk1UQTFDaUFnSUNBdkx5QmhjM05sY25RZ1kyOXVkR1Z1ZEY5b1lYTm9YM04wY2k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTUNrc0lDSkZVbEpmUlUxUVZGbGZTRUZUU0Y5VFZGSWlDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNYMFZOVUZSWlgwaEJVMGhmVTFSU0NpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwyTmhjSFJ5WlY5aGNIQXVjSGs2TVRBMkNpQWdJQ0F2THlCaGMzTmxjblFnWVhSMFpYTjBZWFJwYjI1ZmFXUXViR1Z1WjNSb0lENGdWVWx1ZERZMEtEQXBMQ0FpUlZKU1gwVk5VRlJaWDBsRUlnb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1VsOUZUVkJVV1Y5SlJBb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pFd053b2dJQ0FnTHk4Z1lYTnpaWEowSUdGMWRHaHZjaTVpZVhSbGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01Da3NJQ0pGVWxKZlJVMVFWRmxmUVZWVVNFOVNJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKZlJVMVFWRmxmUVZWVVNFOVNDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk1UQTRDaUFnSUNBdkx5QmhjM05sY25RZ2JXVjBZV1JoZEdGZmFuTnZiaTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NQ2tzSUNKRlVsSmZSVTFRVkZsZlRVVlVRVVJCVkVFaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1gwVk5VRlJaWDAxRlZFRkVRVlJCQ2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDJOaGNIUnlaVjloY0hBdWNIazZNVEE1Q2lBZ0lDQXZMeUJ6Wld4bUxtRjBkR1Z6ZEdGMGFXOXVjMXRqYjI1MFpXNTBYMmhoYzJoZmEyVjVYU0E5SUcxbGRHRmtZWFJoWDJwemIyNEtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDJOaGNIUnlaVjloY0hBdWNIazZNVEV3Q2lBZ0lDQXZMeUJ6Wld4bUxtbGtYMmx1WkdWNFcyRjBkR1Z6ZEdGMGFXOXVYMmxrWFNBOUlHTnZiblJsYm5SZmFHRnphRjl6ZEhJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMk9UTmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwyTmhjSFJ5WlY5aGNIQXVjSGs2TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTmhjSFJ5WlY5aGNIQXVRMkZ3ZEhKbFFYQndMbkpsZG05clpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsZG05clpUb0tJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE1USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE5ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCamIyNTBaVzUwWDJoaGMyaGZhMlY1SUdsdUlITmxiR1l1WVhSMFpYTjBZWFJwYjI1ekxDQWlSVkpTWDA1UFZGOUdUMVZPUkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1UTmhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVbEpmVGs5VVgwWlBWVTVFQ2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDJOaGNIUnlaVjloY0hBdWNIazZNVFF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdkWEJrWVhSbFpGOXRaWFJoWkdGMFlWOXFjMjl1TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrVlNVbDlGVFZCVVdWOU5SVlJCUkVGVVFTSUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSmZSVTFRVkZsZlRVVlVRVVJCVkVFS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdlkyRndkSEpsWDJGd2NDNXdlVG94TkRNS0lDQWdJQzh2SUhObGJHWXVZWFIwWlhOMFlYUnBiMjV6VzJOdmJuUmxiblJmYUdGemFGOXJaWGxkSUQwZ2RYQmtZWFJsWkY5dFpYUmhaR0YwWVY5cWMyOXVDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakV4TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyRndkSEpsWDJGd2NDNURZWEIwY21WQmNIQXVaMlYwWDJGMGRHVnpkR0YwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJGMGRHVnpkR0YwYVc5dU9nb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pFME5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakUyTVFvZ0lDQWdMeThnYVdZZ1kyOXVkR1Z1ZEY5b1lYTm9YMnRsZVNCcGJpQnpaV3htTG1GMGRHVnpkR0YwYVc5dWN6b0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVE5oQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQm5aWFJmWVhSMFpYTjBZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDJOaGNIUnlaVjloY0hBdWNIazZNVFl5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aGRIUmxjM1JoZEdsdmJuTmJZMjl1ZEdWdWRGOW9ZWE5vWDJ0bGVWMEtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUYwZEdWemRHRjBhVzl1Y3lCbGJuUnllU0JsZUdsemRITUtDbWRsZEY5aGRIUmxjM1JoZEdsdmJsOWhablJsY2w5cGJteHBibVZrWDJOaGNIUnlaVjloY0hBdVEyRndkSEpsUVhCd0xtZGxkRjloZEhSbGMzUmhkR2x2YmtBME9nb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pFME5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taMlYwWDJGMGRHVnpkR0YwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakUyTXdvZ0lDQWdMeThnY21WMGRYSnVJRUo1ZEdWektHSWlJaWtLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGdLSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2WTJGd2RISmxYMkZ3Y0M1d2VUb3hORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZllYUjBaWE4wWVhScGIyNWZZV1owWlhKZmFXNXNhVzVsWkY5allYQjBjbVZmWVhCd0xrTmhjSFJ5WlVGd2NDNW5aWFJmWVhSMFpYTjBZWFJwYjI1QU5Bb0tDaTh2SUdOaGNIUnlaVjloY0hBdVEyRndkSEpsUVhCd0xuSmxjMjlzZG1WZmFXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhOdmJIWmxYMmxrT2dvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5allYQjBjbVZmWVhCd0xuQjVPakUyTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzlqWVhCMGNtVmZZWEJ3TG5CNU9qRTRNZ29nSUNBZ0x5OGdhV1lnWVhSMFpYTjBZWFJwYjI1ZmFXUWdhVzRnYzJWc1ppNXBaRjlwYm1SbGVEb0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJPVE5oQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnlaWE52YkhabFgybGtYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pFNE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVhV1JmYVc1a1pYaGJZWFIwWlhOMFlYUnBiMjVmYVdSZENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBaRjlwYm1SbGVDQmxiblJ5ZVNCbGVHbHpkSE1LQ25KbGMyOXNkbVZmYVdSZllXWjBaWEpmYVc1c2FXNWxaRjlqWVhCMGNtVmZZWEJ3TGtOaGNIUnlaVUZ3Y0M1eVpYTnZiSFpsWDJsa1FEUTZDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMMk5oY0hSeVpWOWhjSEF1Y0hrNk1UWTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WlhOdmJIWmxYMmxrWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzlqWVhCMGNtVmZZWEJ3TG5CNU9qRTROQW9nSUNBZ0x5OGdjbVYwZFhKdUlFSjVkR1Z6S0dJaUlpa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ0tJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveE5qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lpQnlaWE52YkhabFgybGtYMkZtZEdWeVgybHViR2x1WldSZlkyRndkSEpsWDJGd2NDNURZWEIwY21WQmNIQXVjbVZ6YjJ4MlpWOXBaRUEwQ2dvS0x5OGdZMkZ3ZEhKbFgyRndjQzVEWVhCMGNtVkJjSEF1WlhocGMzUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWlhocGMzUnpPZ29nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzlqWVhCMGNtVmZZWEJ3TG5CNU9qRTROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pJd01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdOdmJuUmxiblJmYUdGemFGOXJaWGtnYVc0Z2MyVnNaaTVoZEhSbGMzUmhkR2x2Ym5NS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1UTmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pFNE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTJGd2RISmxYMkZ3Y0M1RFlYQjBjbVZCY0hBdVlXUnRhVzVmWkdWc1pYUmxYMkp2ZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtiV2x1WDJSbGJHVjBaVjlpYjNnNkNpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwyTmhjSFJ5WlY5aGNIQXVjSGs2TWpBekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOWpZWEIwY21WZllYQndMbkI1T2pJeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrVlNVbDlPVDFSZlExSkZRVlJQVWlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSmZUazlVWDBOU1JVRlVUMUlLSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2WTJGd2RISmxYMkZ3Y0M1d2VUb3lNekFLSUNBZ0lDOHZJR2xtSUdselgyRjBkR1Z6ZEdGMGFXOXVPZ29nSUNBZ1lub2dZV1J0YVc1ZlpHVnNaWFJsWDJKdmVGOWxiSE5sWDJKdlpIbEFNd29nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzlqWVhCMGNtVmZZWEJ3TG5CNU9qSXpNUW9nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjlyWlhrZ2FXNGdjMlZzWmk1aGRIUmxjM1JoZEdsdmJuTXNJQ0pGVWxKZlFrOVlYMDVQVkY5R1QxVk9SQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTVROaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTWDBKUFdGOU9UMVJmUms5VlRrUUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZZMkZ3ZEhKbFgyRndjQzV3ZVRveU16SUtJQ0FnSUM4dklHUmxiQ0J6Wld4bUxtRjBkR1Z6ZEdGMGFXOXVjMXRpYjNoZmEyVjVYUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2dwaFpHMXBibDlrWld4bGRHVmZZbTk0WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2WTJGd2RISmxYMkZ3Y0M1d2VUb3lNRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZV1J0YVc1ZlpHVnNaWFJsWDJKdmVGOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2WTJGd2RISmxYMkZ3Y0M1d2VUb3lNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmliM2hmYTJWNUlHbHVJSE5sYkdZdWFXUmZhVzVrWlhnc0lDSkZVbEpmUWs5WVgwNVBWRjlHVDFWT1JDSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJPVE5oQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSlNYMEpQV0Y5T1QxUmZSazlWVGtRS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdlkyRndkSEpsWDJGd2NDNXdlVG95TXpVS0lDQWdJQzh2SUdSbGJDQnpaV3htTG1sa1gybHVaR1Y0VzJKdmVGOXJaWGxkQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0lnWVdSdGFXNWZaR1ZzWlhSbFgySnZlRjloWm5SbGNsOXBabDlsYkhObFFEUUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFJQkpnUUNZVG9DYVRvRUZSOThkUUF4RzBFQU9URVpGRVF4R0VTQ0JnUTNoaGMxQk9oeEFKa0U2SG9SZEFTRmVPNllCRjd2SHZVRWVtYUEzVFlhQUk0R0FBa0FoZ0RHQVBVQkpBRkhBREVaRkRFWUZCQkROaG9CU1NKWkl3aExBUlVTUkZjQ0FEWWFBa2tpV1NNSVN3RVZFa1JYQWdBMkdnTkpJbGtqQ0VzQkZSSkVWd0lBTmhvRVNTSlpJd2hMQVJVU1JGY0NBRFlhQlVraVdTTUlTd0VWRWtSWEFnQW9Td1ZRU2IxRkFSUkVUd1VWUkVzRUZVUkxBeFZFVHdJVlJFc0JGVVJKdkVoTXZ5bE1VRW04U0V5L0pFTTJHZ0ZKSWxrakNFc0JGUkpFVndJQU5ob0NTU0paSXdoTUZSSkVOaG9EU1NKWkl3aExBUlVTUkZjQ0FDaFBBbEJKdlVVQlJFc0JGVVJKdkVoTXZ5UkROaG9CU1NKWkl3aExBUlVTUkZjQ0FDaE1VRW05UlFGQkFCQytSRWtWRmxjR0FreFFLa3hRc0NSRFNDdEMvKzAyR2dGSklsa2pDRXNCRlJKRVZ3SUFLVXhRU2IxRkFVRUFFTDVFU1JVV1Z3WUNURkFxVEZDd0pFTklLMEwvN1RZYUFVa2lXU01JU3dFVkVrUlhBZ0FvVEZDOVJRR0FBUUFpVHdKVUtreFFzQ1JETmhvQlNTSlpJd2hMQVJVU1JGY0NBRFlhQWtrVkpCSkVJbE14QURJSkVrUkJBQXdvVEZCSnZVVUJSTHhJSkVNcFRGQkp2VVVCUkx4SVF2L3giLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
