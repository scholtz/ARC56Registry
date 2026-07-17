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

namespace Arc56.Generated.brandonjsellam_Releone.trelyan_falcon_inscription.TrelyanInscription_6210053f
{


    //
    // 
    //    TRELYAN post-quantum inscription application.
    //
    //    Storage:
    //      - committed_pubkey   : BoxMap[cell_id -> 1793B] immutable, written ONLY at register_cell (the
    //                                                       Cell mint record). The FULL Falcon-1024 public
    //                                                       key, NOT a hash: inscribe reads it from here so
    //                                                       the key never travels as a call arg (A9). I4/C5.
    //      - inscriptions       : BoxMap[cell_id -> InscriptionRecord]  write-once. Spec I1/C2.
    //      - controlling_owner  : BoxMap[cell_id -> 32B]    address allowed to inscribe. Spec C1.
    //      - (network pin)      : the native Global.genesis_hash is read in _build_message — no stored
    //                             genesis value, no deploy-time arg, so the chain can never be mis-pinned (A2).
    //      - admin              : the Foundation/Stiftung address permitted to register cells
    //                             ONLY (mint). It has NO power over inscriptions. Spec governance.
    //    
    //
    public class TrelyanInscriptionProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TrelyanInscriptionProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class InscriptionRecord : AVMObjectType
            {
                public byte Version { get; set; }

                public ulong CellId { get; set; }

                public byte[] ArtifactHash { get; set; }

                public ulong InscribedRound { get; set; }

                public Algorand.Address Inscriber { get; set; }

                public byte[] PayloadUri { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vVersion.From(Version);
                    ret.AddRange(vVersion.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCellId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCellId.From(CellId);
                    ret.AddRange(vCellId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArtifactHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vArtifactHash.From(ArtifactHash);
                    ret.AddRange(vArtifactHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInscribedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInscribedRound.From(InscribedRound);
                    ret.AddRange(vInscribedRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInscriber = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vInscriber.From(Inscriber);
                    ret.AddRange(vInscriber.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayloadUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vPayloadUri.From(PayloadUri);
                    ret.AddRange(vPayloadUri.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static InscriptionRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new InscriptionRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vVersion.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is byte vVersionValue) { ret.Version = vVersionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCellId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCellId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCellId = vCellId.ToValue();
                    if (valueCellId is ulong vCellIdValue) { ret.CellId = vCellIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArtifactHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vArtifactHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArtifactHash = vArtifactHash.ToValue();
                    if (valueArtifactHash is byte[] vArtifactHashValue) { ret.ArtifactHash = vArtifactHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInscribedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInscribedRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInscribedRound = vInscribedRound.ToValue();
                    if (valueInscribedRound is ulong vInscribedRoundValue) { ret.InscribedRound = vInscribedRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInscriber = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vInscriber.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInscriber = vInscriber.ToValue();
                    if (valueInscriber is Algorand.Address vInscriberValue) { ret.Inscriber = vInscriberValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayloadUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vPayloadUri.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayloadUri = vPayloadUri.ToValue();
                    if (valuePayloadUri is byte[] vPayloadUriValue) { ret.PayloadUri = vPayloadUriValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as InscriptionRecord);
                }
                public bool Equals(InscriptionRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(InscriptionRecord left, InscriptionRecord right)
                {
                    return EqualityComparer<InscriptionRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(InscriptionRecord left, InscriptionRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploy. Sets the admin (mint authority). The network is pinned via the NATIVE
        ///Global.genesis_hash read in _build_message (A2 resolved) — there is no deploy-time genesis argument, so a wrong value can never silently scope signatures to the wrong network.
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
        ///Mint record for a Cell. Sets the immutable committed Falcon-1024 public key and the
        ///controlling owner ATOMICALLY (spec C5/I4/[Hermes#4]).
        ///Only the admin (Foundation) may register; only ONCE per cell; only up to 1,024 cells. The registration is BOUND to a real Cell ASA — a pure NFT created by the admin — so a commitment cannot be registered under an arbitrary or nonexistent integer id. This closes the I4/M1 gap found in pre-audit review: `cid` derives from a real `Asset` (cell.id), exactly as inscribe() does, so the two can never key off different id spaces.
        ///The FULL public key is stored (not a hash): inscribe READS it from state, so the 1,793-byte key never has to travel as a call argument — the AVM caps total ApplicationArgs at 2,048 B, which pubkey + signature would overflow (AUDIT-NOTE A9). The exact key length is enforced HERE, at the only point a key ever enters state, so a malformed key can never be committed [council: validate-at-register]. After this call committed_pubkey[cell.id] is immutable (no method rewrites it) — the controlling key is bound to the cell by construction.
        ///</summary>
        /// <param name="cell"> </param>
        /// <param name="controlling_owner"> </param>
        /// <param name="committed_pubkey"> </param>
        public async Task RegisterCell(ulong cell, Algorand.Address controlling_owner, byte[] committed_pubkey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 68, 125, 253 };
            var cellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cellAbi.From(cell);
            var controlling_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlling_ownerAbi.From(controlling_owner);
            var committed_pubkeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); committed_pubkeyAbi.From(committed_pubkey);

            var result = await base.CallApp(new List<object> { abiHandle, cellAbi, controlling_ownerAbi, committed_pubkeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterCell_Transactions(ulong cell, Algorand.Address controlling_owner, byte[] committed_pubkey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 68, 125, 253 };
            var cellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cellAbi.From(cell);
            var controlling_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlling_ownerAbi.From(controlling_owner);
            var committed_pubkeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); committed_pubkeyAbi.From(committed_pubkey);

            return await base.MakeTransactionList(new List<object> { abiHandle, cellAbi, controlling_ownerAbi, committed_pubkeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Inscribe `cell` with `artifact_hash`, authorized by a Falcon-1024 signature over the
        ///domain-separated message M.
        ///The controlling public key is NOT a parameter — it was committed in full at register_cell and is READ from state here (AUDIT-NOTE A9). That (1) keeps the 1,793 B key out of the 2,048 B ApplicationArgs budget — only the signature (<=1423 B) rides in the args — and (2) binds the key to the cell by construction: a caller cannot substitute a key.
        ///Budget note [Hermes#5]: falcon_verify is opcode-heavy (~1700). ensure_budget pools the extra budget via OpUp inner txns funded from the group's fee surplus (GroupCredit) — the caller attaches surplus fee, so inscribe is self-budgeting (no hand-assembled OpUp group needed).
        ///</summary>
        /// <param name="cell"> </param>
        /// <param name="artifact_hash"> </param>
        /// <param name="falcon_sig"> </param>
        /// <param name="payload_uri"> </param>
        public async Task Inscribe(ulong cell, byte[] artifact_hash, byte[] falcon_sig, byte[] payload_uri, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 48, 12, 242 };
            var cellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cellAbi.From(cell);
            var artifact_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); artifact_hashAbi.From(artifact_hash);
            var falcon_sigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); falcon_sigAbi.From(falcon_sig);
            var payload_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payload_uriAbi.From(payload_uri);

            var result = await base.CallApp(new List<object> { abiHandle, cellAbi, artifact_hashAbi, falcon_sigAbi, payload_uriAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Inscribe_Transactions(ulong cell, byte[] artifact_hash, byte[] falcon_sig, byte[] payload_uri, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 48, 12, 242 };
            var cellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cellAbi.From(cell);
            var artifact_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); artifact_hashAbi.From(artifact_hash);
            var falcon_sigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); falcon_sigAbi.From(falcon_sig);
            var payload_uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payload_uriAbi.From(payload_uri);

            return await base.MakeTransactionList(new List<object> { abiHandle, cellAbi, artifact_hashAbi, falcon_sigAbi, payload_uriAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reassign the controlling owner. Only the CURRENT controlling owner may do this, and
        ///only if the cell is NOT yet inscribed. This is the authorized way ownership moves for inscription purposes — distinct from raw ASA transfer, so flash-custody of the ASA does not confer inscription rights. [Hermes#2]
        ///</summary>
        /// <param name="cell"> </param>
        /// <param name="new_owner"> </param>
        public async Task UpdateOwner(ulong cell, Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 249, 117, 171 };
            var cellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cellAbi.From(cell);
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            var result = await base.CallApp(new List<object> { abiHandle, cellAbi, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateOwner_Transactions(ulong cell, Algorand.Address new_owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 249, 117, 171 };
            var cellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cellAbi.From(cell);
            var new_ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_ownerAbi.From(new_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, cellAbi, new_ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the inscription record so anyone can re-verify off-chain. Spec I3.
        ///NOTE: subscripts the box directly; for a not-yet-inscribed cell this RAISES (per A3 a missing box read fails — it never returns a zero record). Callers treat a failed read as 'not inscribed'. The controlling public key for re-verification is read separately from committed_pubkey[cell_id] (A9). This is the only unguarded box read in the contract.
        ///</summary>
        /// <param name="cell_id"> </param>
        public async Task<Structs.InscriptionRecord> GetInscription(ulong cell_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 223, 223, 211 };
            var cell_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cell_idAbi.From(cell_id);

            var result = await base.SimApp(new List<object> { abiHandle, cell_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.InscriptionRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetInscription_Transactions(ulong cell_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 223, 223, 211 };
            var cell_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cell_idAbi.From(cell_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, cell_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJlbHlhbkluc2NyaXB0aW9uIiwiZGVzYyI6IlxuICAgIFRSRUxZQU4gcG9zdC1xdWFudHVtIGluc2NyaXB0aW9uIGFwcGxpY2F0aW9uLlxuXG4gICAgU3RvcmFnZTpcbiAgICAgIC0gY29tbWl0dGVkX3B1YmtleSAgIDogQm94TWFwW2NlbGxfaWQgLT4gMTc5M0JdIGltbXV0YWJsZSwgd3JpdHRlbiBPTkxZIGF0IHJlZ2lzdGVyX2NlbGwgKHRoZVxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIENlbGwgbWludCByZWNvcmQpLiBUaGUgRlVMTCBGYWxjb24tMTAyNCBwdWJsaWNcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBrZXksIE5PVCBhIGhhc2g6IGluc2NyaWJlIHJlYWRzIGl0IGZyb20gaGVyZSBzb1xuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHRoZSBrZXkgbmV2ZXIgdHJhdmVscyBhcyBhIGNhbGwgYXJnIChBOSkuIEk0L0M1LlxuICAgICAgLSBpbnNjcmlwdGlvbnMgICAgICAgOiBCb3hNYXBbY2VsbF9pZCAtPiBJbnNjcmlwdGlvblJlY29yZF0gIHdyaXRlLW9uY2UuIFNwZWMgSTEvQzIuXG4gICAgICAtIGNvbnRyb2xsaW5nX293bmVyICA6IEJveE1hcFtjZWxsX2lkIC0+IDMyQl0gICAgYWRkcmVzcyBhbGxvd2VkIHRvIGluc2NyaWJlLiBTcGVjIEMxLlxuICAgICAgLSAobmV0d29yayBwaW4pICAgICAgOiB0aGUgbmF0aXZlIEdsb2JhbC5nZW5lc2lzX2hhc2ggaXMgcmVhZCBpbiBfYnVpbGRfbWVzc2FnZSDigJQgbm8gc3RvcmVkXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgIGdlbmVzaXMgdmFsdWUsIG5vIGRlcGxveS10aW1lIGFyZywgc28gdGhlIGNoYWluIGNhbiBuZXZlciBiZSBtaXMtcGlubmVkIChBMikuXG4gICAgICAtIGFkbWluICAgICAgICAgICAgICA6IHRoZSBGb3VuZGF0aW9uL1N0aWZ0dW5nIGFkZHJlc3MgcGVybWl0dGVkIHRvIHJlZ2lzdGVyIGNlbGxzXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgIE9OTFkgKG1pbnQpLiBJdCBoYXMgTk8gcG93ZXIgb3ZlciBpbnNjcmlwdGlvbnMuIFNwZWMgZ292ZXJuYW5jZS5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSW5zY3JpcHRpb25SZWNvcmQiOlt7Im5hbWUiOiJ2ZXJzaW9uIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiY2VsbF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcnRpZmFjdF9oYXNoIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiaW5zY3JpYmVkX3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imluc2NyaWJlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGF5bG9hZF91cmkiLCJ0eXBlIjoiYnl0ZVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJEZXBsb3kuIFNldHMgdGhlIGFkbWluIChtaW50IGF1dGhvcml0eSkuIFRoZSBuZXR3b3JrIGlzIHBpbm5lZCB2aWEgdGhlIE5BVElWRVxuR2xvYmFsLmdlbmVzaXNfaGFzaCByZWFkIGluIF9idWlsZF9tZXNzYWdlIChBMiByZXNvbHZlZCkg4oCUIHRoZXJlIGlzIG5vIGRlcGxveS10aW1lIGdlbmVzaXMgYXJndW1lbnQsIHNvIGEgd3JvbmcgdmFsdWUgY2FuIG5ldmVyIHNpbGVudGx5IHNjb3BlIHNpZ25hdHVyZXMgdG8gdGhlIHdyb25nIG5ldHdvcmsuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX2NlbGwiLCJkZXNjIjoiTWludCByZWNvcmQgZm9yIGEgQ2VsbC4gU2V0cyB0aGUgaW1tdXRhYmxlIGNvbW1pdHRlZCBGYWxjb24tMTAyNCBwdWJsaWMga2V5IGFuZCB0aGVcbmNvbnRyb2xsaW5nIG93bmVyIEFUT01JQ0FMTFkgKHNwZWMgQzUvSTQvW0hlcm1lcyM0XSkuXG5Pbmx5IHRoZSBhZG1pbiAoRm91bmRhdGlvbikgbWF5IHJlZ2lzdGVyOyBvbmx5IE9OQ0UgcGVyIGNlbGw7IG9ubHkgdXAgdG8gMSwwMjQgY2VsbHMuIFRoZSByZWdpc3RyYXRpb24gaXMgQk9VTkQgdG8gYSByZWFsIENlbGwgQVNBIOKAlCBhIHB1cmUgTkZUIGNyZWF0ZWQgYnkgdGhlIGFkbWluIOKAlCBzbyBhIGNvbW1pdG1lbnQgY2Fubm90IGJlIHJlZ2lzdGVyZWQgdW5kZXIgYW4gYXJiaXRyYXJ5IG9yIG5vbmV4aXN0ZW50IGludGVnZXIgaWQuIFRoaXMgY2xvc2VzIHRoZSBJNC9NMSBnYXAgZm91bmQgaW4gcHJlLWF1ZGl0IHJldmlldzogYGNpZGAgZGVyaXZlcyBmcm9tIGEgcmVhbCBgQXNzZXRgIChjZWxsLmlkKSwgZXhhY3RseSBhcyBpbnNjcmliZSgpIGRvZXMsIHNvIHRoZSB0d28gY2FuIG5ldmVyIGtleSBvZmYgZGlmZmVyZW50IGlkIHNwYWNlcy5cblRoZSBGVUxMIHB1YmxpYyBrZXkgaXMgc3RvcmVkIChub3QgYSBoYXNoKTogaW5zY3JpYmUgUkVBRFMgaXQgZnJvbSBzdGF0ZSwgc28gdGhlIDEsNzkzLWJ5dGUga2V5IG5ldmVyIGhhcyB0byB0cmF2ZWwgYXMgYSBjYWxsIGFyZ3VtZW50IOKAlCB0aGUgQVZNIGNhcHMgdG90YWwgQXBwbGljYXRpb25BcmdzIGF0IDIsMDQ4IEIsIHdoaWNoIHB1YmtleSArIHNpZ25hdHVyZSB3b3VsZCBvdmVyZmxvdyAoQVVESVQtTk9URSBBOSkuIFRoZSBleGFjdCBrZXkgbGVuZ3RoIGlzIGVuZm9yY2VkIEhFUkUsIGF0IHRoZSBvbmx5IHBvaW50IGEga2V5IGV2ZXIgZW50ZXJzIHN0YXRlLCBzbyBhIG1hbGZvcm1lZCBrZXkgY2FuIG5ldmVyIGJlIGNvbW1pdHRlZCBbY291bmNpbDogdmFsaWRhdGUtYXQtcmVnaXN0ZXJdLiBBZnRlciB0aGlzIGNhbGwgY29tbWl0dGVkX3B1YmtleVtjZWxsLmlkXSBpcyBpbW11dGFibGUgKG5vIG1ldGhvZCByZXdyaXRlcyBpdCkg4oCUIHRoZSBjb250cm9sbGluZyBrZXkgaXMgYm91bmQgdG8gdGhlIGNlbGwgYnkgY29uc3RydWN0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZWxsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJvbGxpbmdfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbW1pdHRlZF9wdWJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5zY3JpYmUiLCJkZXNjIjoiSW5zY3JpYmUgYGNlbGxgIHdpdGggYGFydGlmYWN0X2hhc2hgLCBhdXRob3JpemVkIGJ5IGEgRmFsY29uLTEwMjQgc2lnbmF0dXJlIG92ZXIgdGhlXG5kb21haW4tc2VwYXJhdGVkIG1lc3NhZ2UgTS5cblRoZSBjb250cm9sbGluZyBwdWJsaWMga2V5IGlzIE5PVCBhIHBhcmFtZXRlciDigJQgaXQgd2FzIGNvbW1pdHRlZCBpbiBmdWxsIGF0IHJlZ2lzdGVyX2NlbGwgYW5kIGlzIFJFQUQgZnJvbSBzdGF0ZSBoZXJlIChBVURJVC1OT1RFIEE5KS4gVGhhdCAoMSkga2VlcHMgdGhlIDEsNzkzIEIga2V5IG91dCBvZiB0aGUgMiwwNDggQiBBcHBsaWNhdGlvbkFyZ3MgYnVkZ2V0IOKAlCBvbmx5IHRoZSBzaWduYXR1cmUgKDw9MTQyMyBCKSByaWRlcyBpbiB0aGUgYXJncyDigJQgYW5kICgyKSBiaW5kcyB0aGUga2V5IHRvIHRoZSBjZWxsIGJ5IGNvbnN0cnVjdGlvbjogYSBjYWxsZXIgY2Fubm90IHN1YnN0aXR1dGUgYSBrZXkuXG5CdWRnZXQgbm90ZSBbSGVybWVzIzVdOiBmYWxjb25fdmVyaWZ5IGlzIG9wY29kZS1oZWF2eSAofjE3MDApLiBlbnN1cmVfYnVkZ2V0IHBvb2xzIHRoZSBleHRyYSBidWRnZXQgdmlhIE9wVXAgaW5uZXIgdHhucyBmdW5kZWQgZnJvbSB0aGUgZ3JvdXAncyBmZWUgc3VycGx1cyAoR3JvdXBDcmVkaXQpIOKAlCB0aGUgY2FsbGVyIGF0dGFjaGVzIHN1cnBsdXMgZmVlLCBzbyBpbnNjcmliZSBpcyBzZWxmLWJ1ZGdldGluZyAobm8gaGFuZC1hc3NlbWJsZWQgT3BVcCBncm91cCBuZWVkZWQpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZWxsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFydGlmYWN0X2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZhbGNvbl9zaWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWxvYWRfdXJpIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9vd25lciIsImRlc2MiOiJSZWFzc2lnbiB0aGUgY29udHJvbGxpbmcgb3duZXIuIE9ubHkgdGhlIENVUlJFTlQgY29udHJvbGxpbmcgb3duZXIgbWF5IGRvIHRoaXMsIGFuZFxub25seSBpZiB0aGUgY2VsbCBpcyBOT1QgeWV0IGluc2NyaWJlZC4gVGhpcyBpcyB0aGUgYXV0aG9yaXplZCB3YXkgb3duZXJzaGlwIG1vdmVzIGZvciBpbnNjcmlwdGlvbiBwdXJwb3NlcyDigJQgZGlzdGluY3QgZnJvbSByYXcgQVNBIHRyYW5zZmVyLCBzbyBmbGFzaC1jdXN0b2R5IG9mIHRoZSBBU0EgZG9lcyBub3QgY29uZmVyIGluc2NyaXB0aW9uIHJpZ2h0cy4gW0hlcm1lcyMyXSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZWxsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X293bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9pbnNjcmlwdGlvbiIsImRlc2MiOiJSZXR1cm4gdGhlIGluc2NyaXB0aW9uIHJlY29yZCBzbyBhbnlvbmUgY2FuIHJlLXZlcmlmeSBvZmYtY2hhaW4uIFNwZWMgSTMuXG5OT1RFOiBzdWJzY3JpcHRzIHRoZSBib3ggZGlyZWN0bHk7IGZvciBhIG5vdC15ZXQtaW5zY3JpYmVkIGNlbGwgdGhpcyBSQUlTRVMgKHBlciBBMyBhIG1pc3NpbmcgYm94IHJlYWQgZmFpbHMg4oCUIGl0IG5ldmVyIHJldHVybnMgYSB6ZXJvIHJlY29yZCkuIENhbGxlcnMgdHJlYXQgYSBmYWlsZWQgcmVhZCBhcyAnbm90IGluc2NyaWJlZCcuIFRoZSBjb250cm9sbGluZyBwdWJsaWMga2V5IGZvciByZS12ZXJpZmljYXRpb24gaXMgcmVhZCBzZXBhcmF0ZWx5IGZyb20gY29tbWl0dGVkX3B1YmtleVtjZWxsX2lkXSAoQTkpLiBUaGlzIGlzIHRoZSBvbmx5IHVuZ3VhcmRlZCBib3ggcmVhZCBpbiB0aGUgY29udHJhY3QuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNlbGxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCxieXRlWzMyXSx1aW50NjQsYWRkcmVzcyxieXRlW10pIiwic3RydWN0IjoiSW5zY3JpcHRpb25SZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiIsIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjc0XSwiZXJyb3JNZXNzYWdlIjoiYWxsIDEwMjQgY2VsbHMgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzM10sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgaW5zY3JpYmVkOyBvd25lciBmcm96ZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQsMjA0LDIxNSwyMjUsMjMzLDI0MV0sImVycm9yTWVzc2FnZSI6ImFzc2V0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NF0sImVycm9yTWVzc2FnZSI6ImJhZCBjb21taXR0ZWQgcHVia2V5IGhlYWRlciAobG9nbj0xMCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTddLCJlcnJvck1lc3NhZ2UiOiJiYWQgY29tbWl0dGVkIHB1YmtleSBsZW5ndGgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjFdLCJlcnJvck1lc3NhZ2UiOiJjZWxsIEFTQSBub3QgY3JlYXRlZCBieSBhZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2Ml0sImVycm9yTWVzc2FnZSI6ImNlbGwgYWxyZWFkeSBpbnNjcmliZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJjZWxsIGFscmVhZHkgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OF0sImVycm9yTWVzc2FnZSI6ImNlbGwgYWxyZWFkeSByZWdpc3RlcmVkIChvd25lcikiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDVdLCJlcnJvck1lc3NhZ2UiOiJjZWxsIG1hbmFnZXIgbXVzdCBiZSBjbGVhcmVkIChpbW11dGFibGUgY29uZmlnKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOV0sImVycm9yTWVzc2FnZSI6ImNlbGwgbXVzdCBiZSBhIHB1cmUgTkZUIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI5XSwiZXJyb3JNZXNzYWdlIjoiY2VsbCBtdXN0IGhhdmUgbm8gY2xhd2JhY2siLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzddLCJlcnJvck1lc3NhZ2UiOiJjZWxsIG11c3QgaGF2ZSBubyBmcmVlemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTQsNjE3XSwiZXJyb3JNZXNzYWdlIjoiY2VsbCBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OSwyMTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY2VsbHNfcmVnaXN0ZXJlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNvbW1pdHRlZF9wdWJrZXkgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pbnNjcmlwdGlvbnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3XSwiZXJyb3JNZXNzYWdlIjoiY29udHJhY3QgaXMgbm9uLWRlbGV0YWJsZSAoSTEvSTUpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQxXSwiZXJyb3JNZXNzYWdlIjoiY29udHJhY3QgaXMgbm9uLXVwZ3JhZGFibGUgKEk1KSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwN10sImVycm9yTWVzc2FnZSI6ImZhbGNvbiBzaWcgdG9vIGxhcmdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ5XSwiZXJyb3JNZXNzYWdlIjoiZmFsY29uIHNpZ25hdHVyZSBpbnZhbGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc2LDM1MiwzNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODMsMzYwLDM3N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjcsMzQ2LDYwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTUsMzM1LDU5Nyw2NDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDRdLCJlcnJvck1lc3NhZ2UiOiJubyBjb250cm9sbGluZyBvd25lciBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTFdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIG1heSByZWdpc3RlciBjZWxscyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNF0sImVycm9yTWVzc2FnZSI6Im9ubHkgY29udHJvbGxpbmcgb3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTZdLCJlcnJvck1lc3NhZ2UiOiJwYXlsb2FkX3VyaSB0b28gbG9uZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMl0sImVycm9yTWVzc2FnZSI6InNlbmRlciBkb2VzIG5vdCBob2xkIHRoZSBjZWxsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUwXSwiZXJyb3JNZXNzYWdlIjoic2VuZGVyIG5vdCBjb250cm9sbGluZyBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV5Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVlXUnRhVzRpSUNKalpXeHNjMTl5WldkcGMzUmxjbVZrSWlBd2VEWm1OV1lnTUhnMk9UVm1JREI0Tm1JMVppQXdlREEyT0RFd01Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYVc1elkzSnBjSFJwYjI0dWNIazZNVFUyTFRFMU53b2dJQ0FnTHk4Z0l5Qm5iM1psY201aGJtTmxJQ2h1WlhSM2IzSnJJR2x6SUhCcGJtNWxaQ0IyYVdFZ2JtRjBhWFpsSUVkc2IySmhiQzVuWlc1bGMybHpYMmhoYzJnZ2FXNGdYMkoxYVd4a1gyMWxjM05oWjJVZzRvQ1VJRUV5S1FvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmlBOUlFRmpZMjkxYm5Rb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnBibk5qY21sd2RHbHZiaTV3ZVRveE5UZ0tJQ0FnSUM4dklITmxiR1l1WTJWc2JITmZjbVZuYVhOMFpYSmxaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTJWc2JITmZjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCcGJuTmpjbWx3ZEdsdmJpNXdlVG94TWprS0lDQWdJQzh2SUdOc1lYTnpJRlJ5Wld4NVlXNUpibk5qY21sd2RHbHZiaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTFDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFeENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9XSTBORGRrWm1RZ01IZzVaRE13TUdObU1pQXdlR0ZrWmprM05XRmlJREI0WVdGa1ptUm1aRE1nTHk4Z2JXVjBhRzlrSUNKeVpXZHBjM1JsY2w5alpXeHNLSFZwYm5RMk5DeGhaR1J5WlhOekxHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0pwYm5OamNtbGlaU2gxYVc1ME5qUXNZbmwwWlZzek1sMHNZbmwwWlZ0ZExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVmZiM2R1WlhJb2RXbHVkRFkwTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDJsdWMyTnlhWEIwYVc5dUtIVnBiblEyTkNrb2RXbHVkRGdzZFdsdWREWTBMR0o1ZEdWYk16SmRMSFZwYm5RMk5DeGhaR1J5WlhOekxHSjVkR1ZiWFNraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnlaV2RwYzNSbGNsOWpaV3hzSUdsdWMyTnlhV0psSUhWd1pHRjBaVjl2ZDI1bGNpQm5aWFJmYVc1elkzSnBjSFJwYjI0S0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Ub0tJQ0FnSUM4dklHbHVjMk55YVhCMGFXOXVMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1kyeGhjM01nVkhKbGJIbGhia2x1YzJOeWFYQjBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBZelZqTmpGaVlTQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE5Ub0tJQ0FnSUM4dklHbHVjMk55YVhCMGFXOXVMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1kyeGhjM01nVkhKbGJIbGhia2x1YzJOeWFYQjBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9hVzUwY3lBMElEVWdMeThnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRzSUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J0WVhSamFDQnRZV2x1WDI5dVgzVndaR0YwWlVBeE5pQnRZV2x1WDI5dVgyUmxiR1YwWlVBeE53b2dJQ0FnWlhKeUNncHRZV2x1WDI5dVgyUmxiR1YwWlVBeE56b0tJQ0FnSUM4dklHbHVjMk55YVhCMGFXOXVMbkI1T2pNMU13b2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qTTFOZ29nSUNBZ0x5OGdZWE56WlhKMElFWmhiSE5sTENBaVkyOXVkSEpoWTNRZ2FYTWdibTl1TFdSbGJHVjBZV0pzWlNBb1NURXZTVFVwSWlBZ0l5QnViM0ZoT2lCQ01ERXhDaUFnSUNCbGNuSWdMeThnWTI5dWRISmhZM1FnYVhNZ2JtOXVMV1JsYkdWMFlXSnNaU0FvU1RFdlNUVXBDZ3B0WVdsdVgyOXVYM1Z3WkdGMFpVQXhOam9LSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qTTBPQW9nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdsdWMyTnlhWEIwYVc5dUxuQjVPak0xTVFvZ0lDQWdMeThnWVhOelpYSjBJRVpoYkhObExDQWlZMjl1ZEhKaFkzUWdhWE1nYm05dUxYVndaM0poWkdGaWJHVWdLRWsxS1NJZ0lDTWdibTl4WVRvZ1FqQXhNUW9nSUNBZ1pYSnlJQzh2SUdOdmJuUnlZV04wSUdseklHNXZiaTExY0dkeVlXUmhZbXhsSUNoSk5Ta0tDZ292THlCcGJuTmpjbWx3ZEdsdmJpNVVjbVZzZVdGdVNXNXpZM0pwY0hScGIyNHVZM0psWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbE9nb2dJQ0FnTHk4Z2FXNXpZM0pwY0hScGIyNHVjSGs2TVRZNUNpQWdJQ0F2THlCelpXeG1MbUZrYldsdUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYVc1elkzSnBjSFJwYjI0dWNIazZNVFkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCcGJuTmpjbWx3ZEdsdmJpNVVjbVZzZVdGdVNXNXpZM0pwY0hScGIyNHVjbVZuYVhOMFpYSmZZMlZzYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxaMmx6ZEdWeVgyTmxiR3c2Q2lBZ0lDQXZMeUJwYm5OamNtbHdkR2x2Ymk1d2VUb3hOekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2FXNXpZM0pwY0hScGIyNHVjSGs2TVRrMkxURTVOd29nSUNBZ0x5OGdJeUJoWkcxcGJpMXZibXg1SUcxcGJuUWdZWFYwYUc5eWFYUjVDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaWIyNXNlU0JoWkcxcGJpQnRZWGtnY21WbmFYTjBaWElnWTJWc2JITWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ1lXUnRhVzRnYldGNUlISmxaMmx6ZEdWeUlHTmxiR3h6Q2lBZ0lDQXZMeUJwYm5OamNtbHdkR2x2Ymk1d2VUb3hPVGd0TVRrNUNpQWdJQ0F2THlBaklHSnBibVFnZEc4Z1lTQlNSVUZNSUVObGJHd2dRVk5CT2lCd2RYSmxJRTVHVkNBb2RHOTBZV3dnTVNBdklHUmxZMmx0WVd4eklEQXBJR055WldGMFpXUWdZbmtnZEdobElHRmtiV2x1SUNoSk5DOU5NU2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpaV3hzTG5SdmRHRnNJRDA5SUZWSmJuUTJOQ2d4S1NCaGJtUWdZMlZzYkM1a1pXTnBiV0ZzY3lBOVBTQlZTVzUwTmpRb01Da3NJQ0pqWld4c0lHMTFjM1FnWW1VZ1lTQndkWEpsSUU1R1ZDSUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUlViM1JoYkFvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaV2RwYzNSbGNsOWpaV3hzWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnWW01NklISmxaMmx6ZEdWeVgyTmxiR3hmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2NtVm5hWE4wWlhKZlkyVnNiRjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCcGJuTmpjbWx3ZEdsdmJpNXdlVG94T1RndE1UazVDaUFnSUNBdkx5QWpJR0pwYm1RZ2RHOGdZU0JTUlVGTUlFTmxiR3dnUVZOQk9pQndkWEpsSUU1R1ZDQW9kRzkwWVd3Z01TQXZJR1JsWTJsdFlXeHpJREFwSUdOeVpXRjBaV1FnWW5rZ2RHaGxJR0ZrYldsdUlDaEpOQzlOTVNrS0lDQWdJQzh2SUdGemMyVnlkQ0JqWld4c0xuUnZkR0ZzSUQwOUlGVkpiblEyTkNneEtTQmhibVFnWTJWc2JDNWtaV05wYldGc2N5QTlQU0JWU1c1ME5qUW9NQ2tzSUNKalpXeHNJRzExYzNRZ1ltVWdZU0J3ZFhKbElFNUdWQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpaV3hzSUcxMWMzUWdZbVVnWVNCd2RYSmxJRTVHVkFvZ0lDQWdMeThnYVc1elkzSnBjSFJwYjI0dWNIazZNakF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZMlZzYkM1amNtVmhkRzl5SUQwOUlITmxiR1l1WVdSdGFXNHNJQ0pqWld4c0lFRlRRU0J1YjNRZ1kzSmxZWFJsWkNCaWVTQmhaRzFwYmlJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWMFgzQmhjbUZ0YzE5blpYUWdRWE56WlhSRGNtVmhkRzl5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHTmxiR3dnUVZOQklHNXZkQ0JqY21WaGRHVmtJR0o1SUdGa2JXbHVDaUFnSUNBdkx5QnBibk5qY21sd2RHbHZiaTV3ZVRveU1ERXRNakExQ2lBZ0lDQXZMeUFqSUVObGJHeHpJRzExYzNRZ1ltVWdhVzF0ZFhSaFlteGxMQ0J2ZDI1bGNpMWpiMjUwY205c2JHVmtJRTVHVkhNNklHNXZJR05zWVhkaVlXTnJJQ2hqWVc0bmRDQmlaU0J6WldsNlpXUWdiM0lnWW1Gc1lXNWpaUzFuWVcxbFpBb2dJQ0FnTHk4Z0l5QjBieUJtWVd0bElIUm9aU0JETVNCb2IyeGthVzVuSUdOb1pXTnJLU3dnYm04Z1puSmxaWHBsSUNoallXNG5kQ0JpWlNCbWNtOTZaVzRnZEc4Z1lteHZZMnNnYVc1elkzSnBjSFJwYjI0cExDQnVieUJ0WVc1aFoyVnlDaUFnSUNBdkx5QWpJQ2h6YnlCamJHRjNZbUZqYXk5bWNtVmxlbVVnWTJGdUlHNWxkbVZ5SUdKbElISmxMV0ZrWkdWa0lHeGhkR1Z5S1M0Z1cyTnZkVzVqYVd3dlIzSnZhem9nWTJ4dmMyVnpJSFJvWlNCQmMzTmxkRWh2YkdScGJtZEhaWFFLSUNBZ0lDOHZJQ01nWTJ4aGQySmhZMnNnTHlCbWNtVmxlbVVnTHlCamJHOXpaUzF2ZFhRZ2RHbHRhVzVuSUhabFkzUnZjaUJoZENCMGFHVWdjMjkxY21ObExsMEtJQ0FnSUM4dklHRnpjMlZ5ZENCalpXeHNMbU5zWVhkaVlXTnJJRDA5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0lDSmpaV3hzSUcxMWMzUWdhR0YyWlNCdWJ5QmpiR0YzWW1GamF5SUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYUmZjR0Z5WVcxelgyZGxkQ0JCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdaWGhwYzNSekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyVnNiQ0J0ZFhOMElHaGhkbVVnYm04Z1kyeGhkMkpoWTJzS0lDQWdJQzh2SUdsdWMyTnlhWEIwYVc5dUxuQjVPakl3TmdvZ0lDQWdMeThnWVhOelpYSjBJR05sYkd3dVpuSmxaWHBsSUQwOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXNJQ0pqWld4c0lHMTFjM1FnYUdGMlpTQnVieUJtY21WbGVtVWlDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkdjbVZsZW1VS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCalpXeHNJRzExYzNRZ2FHRjJaU0J1YnlCbWNtVmxlbVVLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qSXdOd29nSUNBZ0x5OGdZWE56WlhKMElHTmxiR3d1YldGdVlXZGxjaUE5UFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxDQWlZMlZzYkNCdFlXNWhaMlZ5SUcxMWMzUWdZbVVnWTJ4bFlYSmxaQ0FvYVcxdGRYUmhZbXhsSUdOdmJtWnBaeWtpQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJOWVc1aFoyVnlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMlZzYkNCdFlXNWhaMlZ5SUcxMWMzUWdZbVVnWTJ4bFlYSmxaQ0FvYVcxdGRYUmhZbXhsSUdOdmJtWnBaeWtLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qSXdPQzB5TVRBS0lDQWdJQzh2SUNNZ2RtRnNhV1JoZEdVZ2RHaGxJR052YlcxcGRIUmxaQ0JyWlhrZ2JHVnVaM1JvSUdGMElIUm9aU0JQVGt4WklIQnZhVzUwSUdFZ2EyVjVJR1Z1ZEdWeWN5QnpkR0YwWlNBb1F6VXZTVFF2UVRrcExnb2dJQ0FnTHk4Z0l5QkJJRzFoYkdadmNtMWxaQ0FvZDNKdmJtY3RiR1Z1WjNSb0tTQnJaWGtnZDI5MWJHUWdZbkpwWTJzZ2RHaGxJR05sYkd3ZzRvQ1VJSEpsYW1WamRDQnBkQ0JoZENCMGFHVWdjMjkxY21ObExnb2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJXMXBkSFJsWkY5d2RXSnJaWGt1Ym1GMGFYWmxMbXhsYm1kMGFDQTlQU0JRVlVKTFJWbGZURVZPTENBaVltRmtJR052YlcxcGRIUmxaQ0J3ZFdKclpYa2diR1Z1WjNSb0lpQWdJeUF1Ym1GMGFYWmxJRDBnY21GM0lHSjVkR1Z6SUNodWJ5QkJVa00wSUd4bGJpQndjbVZtYVhncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERTNPVE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ltRmtJR052YlcxcGRIUmxaQ0J3ZFdKclpYa2diR1Z1WjNSb0NpQWdJQ0F2THlCcGJuTmpjbWx3ZEdsdmJpNXdlVG95TVRFdE1qRTFDaUFnSUNBdkx5QWpJRnRVTkM5Uk1UTmRJR2hsWVdSbGNpMWllWFJsSUhkbGJHd3RabTl5YldWa2JtVnpjem9nWVNCRVpYUmxjbTFwYm1semRHbGpJRVpoYkdOdmJpMHhNREkwSUNoc2IyZHVQVEV3S1NCd2RXSnNhV01nYTJWNUNpQWdJQ0F2THlBaklHSmxaMmx1Y3lCM2FYUm9JREI0TUVFZ0tFWkJURU5QVGw5RlRrTlBSRWxPUjE4eU1ESTJMVEEyTFRBeExtMWtPeUJqYjI1bWFYSnRaV1FnWVdkaGFXNXpkQ0IwYUdVZ1lXeG5iM0poYm1RdlptRnNZMjl1Q2lBZ0lDQXZMeUFqSUd0bGVXZGxiaWt1SUVOb1pXTnJaV1FnWVhRZ2RHaGxJRTlPVEZrZ2NHOXBiblFnWVNCclpYa2daVzUwWlhKeklITjBZWFJsTENCemJ5QmhJSGR5YjI1bkxXTjFjblpsTDIxaGJHWnZjbTFsWkNCclpYa2dZMkZ1Q2lBZ0lDQXZMeUFqSUc1bGRtVnlJR0psSUdOdmJXMXBkSFJsWkM0Z1FVSkpMV052YlhCaGRHbGliR1U2SUdGa1pHVmtJR0Z6YzJWeWRDQnZibXg1TENCdWJ5QnphV2R1WVhSMWNtVXZjMlZzWldOMGIzSWdZMmhoYm1kbExnb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xtZGxkR0o1ZEdVb1kyOXRiV2wwZEdWa1gzQjFZbXRsZVM1dVlYUnBkbVVzSUZWSmJuUTJOQ2d3S1NrZ1BUMGdWVWx1ZERZMEtEQjRNRUVwTENBaVltRmtJR052YlcxcGRIUmxaQ0J3ZFdKclpYa2dhR1ZoWkdWeUlDaHNiMmR1UFRFd0tTSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZbUZrSUdOdmJXMXBkSFJsWkNCd2RXSnJaWGtnYUdWaFpHVnlJQ2hzYjJkdVBURXdLUW9nSUNBZ0x5OGdhVzV6WTNKcGNIUnBiMjR1Y0hrNk1qRTJMVEl4TndvZ0lDQWdMeThnSXlBeExEQXlOQ0JqWld4c0lHaGhjbVFnWTJGd0lDaHpjR1ZqSU1Lbk1pa0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbU5sYkd4elgzSmxaMmx6ZEdWeVpXUWdQQ0JVVDFSQlRGOURSVXhNVXl3Z0ltRnNiQ0F4TURJMElHTmxiR3h6SUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTJWc2JITmZjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1alpXeHNjMTl5WldkcGMzUmxjbVZrSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd01qUUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJoYkd3Z01UQXlOQ0JqWld4c2N5QnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QnBibk5qY21sd2RHbHZiaTV3ZVRveU1UZ3RNakU1Q2lBZ0lDQXZMeUFqSUhKbFoybHpkR1Z5TFc5dVkyVTZJR052YlcxcGRIUmxaQ0JyWlhrZ1lXNWtJRzkzYm1WeUlHMTFjM1FnYm05MElHRnNjbVZoWkhrZ1pYaHBjM1FLSUNBZ0lDOHZJR0Z6YzJWeWRDQmphV1FnYm05MElHbHVJSE5sYkdZdVkyOXRiV2wwZEdWa1gzQjFZbXRsZVN3Z0ltTmxiR3dnWVd4eVpXRmtlU0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRObUkxWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCalpXeHNJR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdhVzV6WTNKcGNIUnBiMjR1Y0hrNk1qSXdDaUFnSUNBdkx5QmhjM05sY25RZ1kybGtJRzV2ZENCcGJpQnpaV3htTG1OdmJuUnliMnhzYVc1blgyOTNibVZ5TENBaVkyVnNiQ0JoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FnS0c5M2JtVnlLU0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyWmpWbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWld4c0lHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpDQW9iM2R1WlhJcENpQWdJQ0F2THlCcGJuTmpjbWx3ZEdsdmJpNXdlVG95TWpJdE1qSXpDaUFnSUNBdkx5QWpJSGR5YVhSbElHbHRiWFYwWVdKc1pTQmpiMjF0YVhSdFpXNTBjeUJoZEc5dGFXTmhiR3g1Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZiVzFwZEhSbFpGOXdkV0pyWlhsYlkybGtYU0E5SUdOdmJXMXBkSFJsWkY5d2RXSnJaWGt1Ym1GMGFYWmxJQ0FnSXlCemRHOXlaU0IwYUdVZ2NtRjNJREUzT1RNZ1FpQnJaWGtzSUU1UFZDQjBhR1VnUVZKRE5DMXdjbVZtYVhobFpDQmxibU52WkdsdVp3b2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnBibk5qY21sd2RHbHZiaTV3ZVRveU1qUUtJQ0FnSUM4dklITmxiR1l1WTI5dWRISnZiR3hwYm1kZmIzZHVaWEpiWTJsa1hTQTlJR052Ym5SeWIyeHNhVzVuWDI5M2JtVnlMbUo1ZEdWekNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWkdsbklETUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qSXlOUW9nSUNBZ0x5OGdjMlZzWmk1alpXeHNjMTl5WldkcGMzUmxjbVZrSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU5sYkd4elgzSmxaMmx6ZEdWeVpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdhVzV6WTNKcGNIUnBiMjR1Y0hrNk1UY3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxaMmx6ZEdWeVgyTmxiR3hmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnY21WbmFYTjBaWEpmWTJWc2JGOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnBibk5qY21sd2RHbHZiaTVVY21Wc2VXRnVTVzV6WTNKcGNIUnBiMjR1YVc1elkzSnBZbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJuTmpjbWxpWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUdsdWMyTnlhWEIwYVc5dUxuQjVPakl6TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnBibk5qY21sd2RHbHZiaTV3ZVRveU5UVXRNalUyQ2lBZ0lDQXZMeUFqSUMwdExTQnpkSEoxWTNSMWNtRnNJSEJ5WldOdmJtUnBkR2x2Ym5NZ0xTMHRDaUFnSUNBdkx5QmhjM05sY25RZ1kybGtJR2x1SUhObGJHWXVZMjl0YldsMGRHVmtYM0IxWW10bGVTd2dJbU5sYkd3Z2JtOTBJSEpsWjJsemRHVnlaV1FpSUNBZ0lDQWdJQ0FnSUNBZ0lDTWdiWFZ6ZENCaVpTQnRhVzUwWldRS0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzJZalZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMlZzYkNCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdhVzV6WTNKcGNIUnBiMjR1Y0hrNk1qVTNDaUFnSUNBdkx5QmhjM05sY25RZ1ptRnNZMjl1WDNOcFp5NXVZWFJwZG1VdWJHVnVaM1JvSUR3OUlGTkpSMTlEVDAxUVVrVlRVMFZFWDAxQldFeEZUaXdnSW1aaGJHTnZiaUJ6YVdjZ2RHOXZJR3hoY21kbElpQWdJeUF1Ym1GMGFYWmxJQ2h1YnlCQlVrTTBJSEJ5WldacGVDazdJR1JsZERFd01qUWdZMjl0Y0hKbGMzTmxaQ0E4UFRFME1qTkNPaUJqYUdWaGNDQndjbVV0ZG1WeWFXWjVJRVJ2VXlCaWIzVnVaQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFME1qTUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnWm1Gc1kyOXVJSE5wWnlCMGIyOGdiR0Z5WjJVS0lDQWdJQzh2SUdsdWMyTnlhWEIwYVc5dUxuQjVPakkxT1FvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVd4dllXUmZkWEpwTG01aGRHbDJaUzVzWlc1bmRHZ2dQRDBnVlZKSlgwMUJXRXhGVGl3Z0luQmhlV3h2WVdSZmRYSnBJSFJ2YnlCc2IyNW5JaUFnSXlBdWJtRjBhWFpsSUNodWJ5QkJVa00wSUhCeVpXWnBlQ2s3SUhOd1pXTWd3cWN6SUR3OU1USTRRam9nWW05MWJtUnpJSFJvWlNCM2NtbDBaUzF2Ym1ObElHSnZlQ0J6YVhwbElDaE5NeWtLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRJNENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVd4dllXUmZkWEpwSUhSdmJ5QnNiMjVuQ2lBZ0lDQXZMeUJwYm5OamNtbHdkR2x2Ymk1d2VUb3lOakV0TWpZMkNpQWdJQ0F2THlBaklDMHRMU0JETVRvZ2IzZHVaWEp6YUdsd0xDQklRVkpFUlU1RlJDQmJTR1Z5YldWekl6SmRJQzB0TFFvZ0lDQWdMeThnSXlCVFpXNWtaWElnYlhWemRDQW9ZU2tnWTNWeWNtVnVkR3g1SUdodmJHUWdaWGhoWTNSc2VTQjBhR1VnUTJWc2JDd2dRVTVFSUNoaUtTQmlaU0IwYUdVZ1kyOXVkSEp2Ykd4cGJtY2diM2R1WlhJZ2NtVmpiM0prWldRS0lDQWdJQzh2SUNNZ1lYUWdiV2x1ZEM0Z0tHSXBJR1JsWm1WaGRITWdkSEpoYm5OcFpXNTBMMlpzWVhOb0xXTjFjM1J2WkhrNklHRWdkR1Z0Y0c5eVlYSjVJRUZUUVNCb2IyeGtaWElnYVhNZ2JtOTBJSFJvWlNCeVpXTnZjbVJsWkFvZ0lDQWdMeThnSXlCamIyNTBjbTlzYkdsdVp5QnZkMjVsY2k0Z1FXNGdiM2R1WlhJZ2RISmhibk5tWlhJZ2JYVnpkQ0JuYnlCMGFISnZkV2RvSUhWd1pHRjBaVjl2ZDI1bGNpQW9ZbVZzYjNjcExDQjNhR2xqYUNCeVpYRjFhWEpsY3dvZ0lDQWdMeThnSXlCMGFHVWdjSEpwYjNJZ2IzZHVaWEluY3lCaGRYUm9iM0pwZW1GMGFXOXVJT0tBbENCdWIzUWdZU0JpWVhKbElHSmhiR0Z1WTJVZ1pteHBjQzRLSUNBZ0lDOHZJR0poYkdGdVkyVXNJR1Y0YVhOMGN5QTlJRzl3TGtGemMyVjBTRzlzWkdsdVowZGxkQzVoYzNObGRGOWlZV3hoYm1ObEtGUjRiaTV6Wlc1a1pYSXNJR05sYkd3cENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sZEY5b2IyeGthVzVuWDJkbGRDQkJjM05sZEVKaGJHRnVZMlVLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qSTJOd29nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3lCaGJtUWdZbUZzWVc1alpTQTlQU0JWU1c1ME5qUW9NU2tzSUNKelpXNWtaWElnWkc5bGN5QnViM1FnYUc5c1pDQjBhR1VnWTJWc2JDSUtJQ0FnSUdKNklHbHVjMk55YVdKbFgySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdsdWMyTnlhV0psWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtbHVjMk55YVdKbFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qSTJOd29nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3lCaGJtUWdZbUZzWVc1alpTQTlQU0JWU1c1ME5qUW9NU2tzSUNKelpXNWtaWElnWkc5bGN5QnViM1FnYUc5c1pDQjBhR1VnWTJWc2JDSUtJQ0FnSUdGemMyVnlkQ0F2THlCelpXNWtaWElnWkc5bGN5QnViM1FnYUc5c1pDQjBhR1VnWTJWc2JBb2dJQ0FnTHk4Z2FXNXpZM0pwY0hScGIyNHVjSGs2TWpZNENpQWdJQ0F2THlCaGMzTmxjblFnWTJsa0lHbHVJSE5sYkdZdVkyOXVkSEp2Ykd4cGJtZGZiM2R1WlhJc0lDSnVieUJqYjI1MGNtOXNiR2x1WnlCdmQyNWxjaUJ6WlhRaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5tWTFaZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJR052Ym5SeWIyeHNhVzVuSUc5M2JtVnlJSE5sZEFvZ0lDQWdMeThnYVc1elkzSnBjSFJwYjI0dWNIazZNalk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1amIyNTBjbTlzYkdsdVoxOXZkMjVsY2x0amFXUmRJRDA5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1zSUNKelpXNWtaWElnYm05MElHTnZiblJ5YjJ4c2FXNW5JRzkzYm1WeUlnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5sYm1SbGNpQnViM1FnWTI5dWRISnZiR3hwYm1jZ2IzZHVaWElLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qSTNNUzB5TnpJS0lDQWdJQzh2SUNNZ0xTMHRJRU15T2lCemFXNW5iR1V0ZFhObElDOGdkM0pwZEdVdGIyNWpaU0FvU1RFcElDMHRMUW9nSUNBZ0x5OGdZWE56WlhKMElHTnBaQ0J1YjNRZ2FXNGdjMlZzWmk1cGJuTmpjbWx3ZEdsdmJuTXNJQ0pqWld4c0lHRnNjbVZoWkhrZ2FXNXpZM0pwWW1Wa0lnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWTVOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyVnNiQ0JoYkhKbFlXUjVJR2x1YzJOeWFXSmxaQW9nSUNBZ0x5OGdhVzV6WTNKcGNIUnBiMjR1Y0hrNk1qYzBMVEkzT0FvZ0lDQWdMeThnSXlBdExTMGdRelU2SUhSb1pTQmpiMjUwY205c2JHbHVaeUJyWlhrZ2FYTWdkR2hsSUc5dVpTQmpiMjF0YVhSMFpXUWdZWFFnYldsdWRDd2djbVZoWkNCbWNtOXRJSFJvWlNCSlRVMVZWRUZDVEVVZ2JXbHVkQW9nSUNBZ0x5OGdJeUJ5WldOdmNtUWdXMGhsY20xbGN5TTBYUzRnVkdobGNtVWdhWE1nYm04Z2NIVmlhMlY1SUdGeVozVnRaVzUwSUhSdklIWmhiR2xrWVhSbElHRm5ZV2x1YzNRZ1lTQm9ZWE5vSUdGdWVXMXZjbVVnS0VFNUtUb2dkR2hsQ2lBZ0lDQXZMeUFqSUdOdmJuUnlZV04wSUhWelpYTWdkR2hsSUdOdmJXMXBkSFJsWkNCclpYa2dSRWxTUlVOVVRGa3NJSE52SUd0bGVTMXpkV0p6ZEdsMGRYUnBiMjRnYVhNZ2FXMXdiM056YVdKc1pTQmllU0JqYjI1emRISjFZM1JwYjI0S0lDQWdJQzh2SUNNZzRvQ1VJSE4wY21samRHeDVJSE4wY205dVoyVnlJSFJvWVc0Z2RHaGxJSEJ5YVc5eUlISmxkbVZoYkMxaGJtUXRhR0Z6YUMxamFHVmpheTRnTFMwdENpQWdJQ0F2THlCd2RXSnJaWGtnUFNCelpXeG1MbU52YlcxcGRIUmxaRjl3ZFdKclpYbGJZMmxrWFFvZ0lDQWdaR2xuSURNS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU52YlcxcGRIUmxaRjl3ZFdKclpYa2daVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJwYm5OamNtbHdkR2x2Ymk1d2VUb3pNRGNLSUNBZ0lDOHZJQ3NnYjNBdWFYUnZZaWhIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDlwWkM1cFpDa2dJQ0FqSUZ0SVpYSnRaWE1qTTEwZ1ltbHVaQ0IwYnlCVVNFbFRJR0Z3Y0FvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnBibk5qY21sd2RHbHZiaTV3ZVRvek1EWUtJQ0FnSUM4dklFUlBUVUZKVGw5VVFVY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVTBOVEkwTlRSak5UazBNVFJsTW1RME9UUmxOVE0wTXpVeU5EazFNRFUwTkRrMFpqUmxNbVEzTmpNeENpQWdJQ0F2THlCcGJuTmpjbWx3ZEdsdmJpNXdlVG96TURZdE16QTNDaUFnSUNBdkx5QkVUMDFCU1U1ZlZFRkhDaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1F1YVdRcElDQWdJeUJiU0dWeWJXVnpJek5kSUdKcGJtUWdkRzhnVkVoSlV5QmhjSEFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYVc1elkzSnBjSFJwYjI0dWNIazZNekEyTFRNd09Bb2dJQ0FnTHk4Z1JFOU5RVWxPWDFSQlJ3b2dJQ0FnTHk4Z0t5QnZjQzVwZEc5aUtFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgybGtMbWxrS1NBZ0lDTWdXMGhsY20xbGN5TXpYU0JpYVc1a0lIUnZJRlJJU1ZNZ1lYQndDaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9ZMlZzYkY5cFpDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdhVzV6WTNKcGNIUnBiMjR1Y0hrNk16QTJMVE13T1FvZ0lDQWdMeThnUkU5TlFVbE9YMVJCUndvZ0lDQWdMeThnS3lCdmNDNXBkRzlpS0Vkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJsa0xtbGtLU0FnSUNNZ1cwaGxjbTFsY3lNelhTQmlhVzVrSUhSdklGUklTVk1nWVhCd0NpQWdJQ0F2THlBcklHOXdMbWwwYjJJb1kyVnNiRjlwWkNrS0lDQWdJQzh2SUNzZ1lYSjBhV1poWTNSZmFHRnphQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYVc1elkzSnBjSFJwYjI0dWNIazZNekV3Q2lBZ0lDQXZMeUFySUVkc2IySmhiQzVuWlc1bGMybHpYMmhoYzJnZ0lDQWdJQ0FnSUNBZ0l5QkJNam9nYm1GMGFYWmxJRzVsZEhkdmNtc2daMlZ1WlhOcGN5QW9ibTkwSUdFZ1pHVndiRzk1TFhScGJXVWdZWEpuS1FvZ0lDQWdaMnh2WW1Gc0lFZGxibVZ6YVhOSVlYTm9DaUFnSUNBdkx5QnBibk5qY21sd2RHbHZiaTV3ZVRvek1EWXRNekV3Q2lBZ0lDQXZMeUJFVDAxQlNVNWZWRUZIQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmYVdRdWFXUXBJQ0FnSXlCYlNHVnliV1Z6SXpOZElHSnBibVFnZEc4Z1ZFaEpVeUJoY0hBS0lDQWdJQzh2SUNzZ2IzQXVhWFJ2WWloalpXeHNYMmxrS1FvZ0lDQWdMeThnS3lCaGNuUnBabUZqZEY5b1lYTm9DaUFnSUNBdkx5QXJJRWRzYjJKaGJDNW5aVzVsYzJselgyaGhjMmdnSUNBZ0lDQWdJQ0FnSXlCQk1qb2dibUYwYVhabElHNWxkSGR2Y21zZ1oyVnVaWE5wY3lBb2JtOTBJR0VnWkdWd2JHOTVMWFJwYldVZ1lYSm5LUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURFd0NncHBibk5qY21saVpWOTNhR2xzWlY5MGIzQkFPVG9LSUNBZ0lIQjFjMmhwYm5RZ01qRXhNQW9nSUNBZ1oyeHZZbUZzSUU5d1kyOWtaVUoxWkdkbGRBb2dJQ0FnUGdvZ0lDQWdZbm9nYVc1elkzSnBZbVZmWVdaMFpYSmZkMmhwYkdWQU1UUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EWTRNVEF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0hKdmRtRnNVSEp2WjNKaGJRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQTJPREV3TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYkdWaGNsTjBZWFJsVUhKdlozSmhiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWWlCcGJuTmpjbWxpWlY5M2FHbHNaVjkwYjNCQU9Rb0thVzV6WTNKcFltVmZZV1owWlhKZmQyaHBiR1ZBTVRRNkNpQWdJQ0F2THlCcGJuTmpjbWx3ZEdsdmJpNXdlVG95T0RjdE1qZzRDaUFnSUNBdkx5QWpJQzB0TFNCRE5Eb2dSbUZzWTI5dUxURXdNalFnYzJsbmJtRjBkWEpsSUdOb1pXTnJJR0ZuWVdsdWMzUWdkR2hsSUVOUFRVMUpWRlJGUkNCclpYa2dLSFJvWlNCbGVIQmxibk5wZG1VZ2IzQmpiMlJsTENCeWRXNGdiR0Z6ZENrZ0xTMHRDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVabUZzWTI5dVgzWmxjbWxtZVNodExDQm1ZV3hqYjI1ZmMybG5MbTVoZEdsMlpTd2djSFZpYTJWNUtTd2dJbVpoYkdOdmJpQnphV2R1WVhSMWNtVWdhVzUyWVd4cFpDSWdJQ01nTG01aGRHbDJaVG9nY21GM0lHTnZiWEJ5WlhOelpXUWdjMmxuTENCdWJ5QkJVa00wSUd4bGJpQndjbVZtYVhnS0lDQWdJR1JwWnlBNUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEa0tJQ0FnSUdaaGJHTnZibDkyWlhKcFpua0tJQ0FnSUdGemMyVnlkQ0F2THlCbVlXeGpiMjRnYzJsbmJtRjBkWEpsSUdsdWRtRnNhV1FLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qSTVOZ29nSUNBZ0x5OGdhVzV6WTNKcFltVmtYM0p2ZFc1a1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdsdWMyTnlhWEIwYVc5dUxuQjVPakk1TndvZ0lDQWdMeThnYVc1elkzSnBZbVZ5UFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHbHVjMk55YVhCMGFXOXVMbkI1T2pJNU13b2dJQ0FnTHk4Z2RtVnljMmx2YmoxaGNtTTBMbFZKYm5RNEtFbE9VMTlXUlZKVFNVOU9LU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4Q2lBZ0lDQXZMeUJwYm5OamNtbHdkR2x2Ymk1d2VUb3lPVEF0TWprNUNpQWdJQ0F2THlBaklDMHRMU0JsWm1abFkzUTZJSGR5YVhSbElIUm9aU0IzY21sMFpTMXZibU5sSUhKbFkyOXlaQzRnVkdobElHTnZiVzFwZEhSbFpDQndkV0pyWlhrZ2FYTWdUazlVSUdSMWNHeHBZMkYwWldRZ2FHVnlaU0RpZ0pRZ2FYUUtJQ0FnSUM4dklDTWdZV3h5WldGa2VTQnNhWFpsY3lCd1pYSnRZVzVsYm5Sc2VTQnBiaUJqYjIxdGFYUjBaV1JmY0hWaWEyVjVXMk5wWkYwN0lHRnVJRWt6SUhKbExYWmxjbWxtYVdWeUlISmxZV1J6SUdKdmRHZ2dZbTk0WlhNdUlDMHRMUW9nSUNBZ0x5OGdjbVZqSUQwZ1NXNXpZM0pwY0hScGIyNVNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdkbVZ5YzJsdmJqMWhjbU0wTGxWSmJuUTRLRWxPVTE5V1JWSlRTVTlPS1N3S0lDQWdJQzh2SUNBZ0lDQmpaV3hzWDJsa1BXRnlZelF1VlVsdWREWTBLR05wWkNrc0NpQWdJQ0F2THlBZ0lDQWdZWEowYVdaaFkzUmZhR0Z6YUQxaGNuUnBabUZqZEY5b1lYTm9MbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0JwYm5OamNtbGlaV1JmY205MWJtUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbkp2ZFc1a0tTd0tJQ0FnSUM4dklDQWdJQ0JwYm5OamNtbGlaWEk5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXeHZZV1JmZFhKcFBYQmhlV3h2WVdSZmRYSnBMbU52Y0hrb0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd05UTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYVc1elkzSnBjSFJwYjI0dWNIazZNekF3Q2lBZ0lDQXZMeUJ6Wld4bUxtbHVjMk55YVhCMGFXOXVjMXRqYVdSZElEMGdjbVZqTG1OdmNIa29LUW9nSUNBZ1pHbG5JRGtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCcGJuTmpjbWx3ZEdsdmJpNXdlVG95TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYVc1elkzSnBZbVZmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYVc1elkzSnBZbVZmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYVc1elkzSnBjSFJwYjI0dVZISmxiSGxoYmtsdWMyTnlhWEIwYVc5dUxuVndaR0YwWlY5dmQyNWxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVjl2ZDI1bGNqb0tJQ0FnSUM4dklHbHVjMk55YVhCMGFXOXVMbkI1T2pNeE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdsdWMyTnlhWEIwYVc5dUxuQjVPak15TmdvZ0lDQWdMeThnWVhOelpYSjBJR05wWkNCcGJpQnpaV3htTG1OdmJuUnliMnhzYVc1blgyOTNibVZ5TENBaVkyVnNiQ0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJaalZtQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHTmxiR3dnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklHbHVjMk55YVhCMGFXOXVMbkI1T2pNeU53b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZMjl1ZEhKdmJHeHBibWRmYjNkdVpYSmJZMmxrWFNBOVBTQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxDQWliMjVzZVNCamIyNTBjbTlzYkdsdVp5QnZkMjVsY2lJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWTI5dWRISnZiR3hwYm1jZ2IzZHVaWElLSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qTXlPQW9nSUNBZ0x5OGdZWE56WlhKMElHTnBaQ0J1YjNRZ2FXNGdjMlZzWmk1cGJuTmpjbWx3ZEdsdmJuTXNJQ0poYkhKbFlXUjVJR2x1YzJOeWFXSmxaRHNnYjNkdVpYSWdabkp2ZW1WdUlnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWTVOV1lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhiSEpsWVdSNUlHbHVjMk55YVdKbFpEc2diM2R1WlhJZ1puSnZlbVZ1Q2lBZ0lDQXZMeUJwYm5OamNtbHdkR2x2Ymk1d2VUb3pNamtLSUNBZ0lDOHZJSE5sYkdZdVkyOXVkSEp2Ykd4cGJtZGZiM2R1WlhKYlkybGtYU0E5SUc1bGQxOXZkMjVsY2k1aWVYUmxjd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdsdWMyTnlhWEIwYVc5dUxuQjVPak14TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2FXNXpZM0pwY0hScGIyNHVWSEpsYkhsaGJrbHVjMk55YVhCMGFXOXVMbWRsZEY5cGJuTmpjbWx3ZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5cGJuTmpjbWx3ZEdsdmJqb0tJQ0FnSUM4dklHbHVjMk55YVhCMGFXOXVMbkI1T2pNek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJwYm5OamNtbHdkR2x2Ymk1d2VUb3pORElLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1sdWMyTnlhWEIwYVc5dWMxdGpaV3hzWDJsa0xtNWhkR2wyWlYwS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMk9UVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1sdWMyTnlhWEIwYVc5dWN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJR2x1YzJOeWFYQjBhVzl1TG5CNU9qTXpOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRENBRUFBRUlJQ1lHQldGa2JXbHVFR05sYkd4elgzSmxaMmx6ZEdWeVpXUUNiMThDYVY4Q2ExOERCb0VCTVJoQUFBY29NZ05uS1NKbk1SdEJBRHN4R1JSRU1SaEJBQ1NDQkFTYlJIMzlCSjB3RFBJRXJmbDFxd1NxMzkvVE5ob0FqZ1FBS2dEYUFlUUNGd0NBQkV4Y1libzJHZ0NPQVFBV0FJTUNCQVV4R1k0Q0FBVUFBUUF4R0VRQU1SaEVBQ2d4QUdjalF6WWFBVWtWSkJKRUYwazJHZ0pKVGdJVkpSSkVOaG9EU1U0Q1NTSlpnUUlJVEJVU1JERUFJaWhsUkJKRWNRQkVJeEpCQUhoTEFuRUJSRUFBY0NORVN3SkpjUXRFSWlobFJCSkVTWEVLUkRJREVrUkpjUWxFTWdNU1JFbHhCMFF5QXhKRVN3RlhBZ0JKRllHQkRoSkVTU0pWZ1FvU1JDSXBaVVJKZ1lBSURFUlBBaFluQkVzQlVFbTlSUUVVUkNwUEFsQkp2VVVCRkVSTEFieElURThEdjBtOFNFc0R2eU1JS1V4bkkwTWlRditOSWtjQ05ob0JSd0lWSkJKRUZ6WWFBa2xPQWhVbEVrUTJHZ05KSWxtQkFnaExBUlVTUkRZYUJFbE9BMGtpV1lFQ0NFc0JGUkpFU3dJV1NVNEVKd1JNVUVsT0JMMUZBVVJNVndJQVNVNERGWUdQQ3c1RVZ3SUFGWUdBQVE1RU1RQk1jQUJCQUtGSkl4SkJBSnNqUkNwTEJFbE9BbEJKdlVVQlJMNUlNUUFTUkN0TEFWQkpSUXU5UlFFVVJFc0R2a3hGQ2tReUNCYUFGbFJTUlV4WlFVNHRTVTVUUTFKSlVGUkpUMDR0ZGpGTVVFeFFTd1pRTWhGUVJRcUJ2aEF5REExQkFCaXhnUWF5RUlFRnNoa25CYkllSndXeUh5S3lBYk5DLzk5TENVc0NTd21GUkRJR0ZqRUFnQUVCU3dsUVN3aFFUd0pRVEZDQUFnQlRVRXNGVUVzSlNieElUTDhqUXlKQy8ySTJHZ0ZKRlNRU1JCYzJHZ0pKRlNVU1JFd1dLa3NCVUVtOVJRRkVTYjVJTVFBU1JDdFBBbEM5UlFFVVJFbThTRXkvSTBNMkdnRkpGU1FTUkJjV0sweFF2a1NBQkJVZmZIVk1VTEFqUXc9PSIsImNsZWFyIjoiRElFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
