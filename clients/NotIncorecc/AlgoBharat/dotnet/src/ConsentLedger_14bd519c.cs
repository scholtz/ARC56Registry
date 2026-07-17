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

namespace Arc56.Generated.NotIncorecc.AlgoBharat.ConsentLedger_14bd519c
{


    //
    // 
    //    ConsentLedger - Decentralized ZK consent management on Algorand.
    //
    //    Phase 2: data_type/purpose replaced with a Poseidon commitment hash.
    //    A nullifier prevents replay attacks. DPDP Act section recorded on-chain.
    //    Consent is minted as an ASA; revoking freezes it on-chain.
    //    
    //
    public class ConsentLedgerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConsentLedgerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ConsentRecord : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public Algorand.Address Requester { get; set; }

                public byte[] Commitment { get; set; }

                public byte[] Nullifier { get; set; }

                public ulong Expiry { get; set; }

                public ulong AssetId { get; set; }

                public byte DpdpSection { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRequester.From(Requester);
                    ret.AddRange(vRequester.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCommitment.From(Commitment);
                    ret.AddRange(vCommitment.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNullifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vNullifier.From(Nullifier);
                    ret.AddRange(vNullifier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiry.From(Expiry);
                    ret.AddRange(vExpiry.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDpdpSection = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDpdpSection.From(DpdpSection);
                    ret.AddRange(vDpdpSection.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ConsentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ConsentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRequester.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequester = vRequester.ToValue();
                    if (valueRequester is Algorand.Address vRequesterValue) { ret.Requester = vRequesterValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCommitment.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitment = vCommitment.ToValue();
                    if (valueCommitment is byte[] vCommitmentValue) { ret.Commitment = vCommitmentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNullifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNullifier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNullifier = vNullifier.ToValue();
                    if (valueNullifier is byte[] vNullifierValue) { ret.Nullifier = vNullifierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiry.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiry = vExpiry.ToValue();
                    if (valueExpiry is ulong vExpiryValue) { ret.Expiry = vExpiryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDpdpSection = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDpdpSection.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDpdpSection = vDpdpSection.ToValue();
                    if (valueDpdpSection is byte vDpdpSectionValue) { ret.DpdpSection = vDpdpSectionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ConsentRecord);
                }
                public bool Equals(ConsentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ConsentRecord left, ConsentRecord right)
                {
                    return EqualityComparer<ConsentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ConsentRecord left, ConsentRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Mint a consent ASA and store the ZK-committed record in box storage.
        ///commitment = Poseidon(data_type_hash, purpose_hash, salt) — data never touches the chain in plaintext. nullifier = SHA256(identity_secret || consent_id) — anti-replay.
        ///Returns the newly created asset ID.
        ///</summary>
        /// <param name="requester"> </param>
        /// <param name="commitment"> </param>
        /// <param name="nullifier"> </param>
        /// <param name="expiry"> </param>
        /// <param name="dpdp_section"> </param>
        public async Task<ulong> GrantConsent(Algorand.Address requester, byte[] commitment, byte[] nullifier, ulong expiry, byte dpdp_section, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 105, 167, 82 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); nullifierAbi.From(nullifier);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);
            var dpdp_sectionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); dpdp_sectionAbi.From(dpdp_section);

            var result = await base.CallApp(new List<object> { abiHandle, requesterAbi, commitmentAbi, nullifierAbi, expiryAbi, dpdp_sectionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GrantConsent_Transactions(Algorand.Address requester, byte[] commitment, byte[] nullifier, ulong expiry, byte dpdp_section, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 105, 167, 82 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentAbi.From(commitment);
            var nullifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); nullifierAbi.From(nullifier);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);
            var dpdp_sectionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); dpdp_sectionAbi.From(dpdp_section);

            return await base.MakeTransactionList(new List<object> { abiHandle, requesterAbi, commitmentAbi, nullifierAbi, expiryAbi, dpdp_sectionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freeze the consent ASA to represent on-chain revocation.
        ///Only the original owner of the consent may call this.
        ///</summary>
        /// <param name="requester"> </param>
        public async Task RevokeConsent(Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 45, 203, 152 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            var result = await base.CallApp(new List<object> { abiHandle, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeConsent_Transactions(Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 45, 203, 152 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            return await base.MakeTransactionList(new List<object> { abiHandle, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only verifier: returns True if consent is active and not expired.
        ///Checks: record exists, expiry not passed, ASA not frozen.
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="requester"> </param>
        public async Task<bool> IsConsentValid(Algorand.Address owner, Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 86, 155, 31 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsConsentValid_Transactions(Algorand.Address owner, Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 86, 155, 31 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only: returns the full consent record.
        ///commitment is a hash — no plaintext data is ever stored or returned.
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="requester"> </param>
        public async Task<Structs.ConsentRecord> GetConsentRecord(Algorand.Address owner, Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 219, 161, 124 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ConsentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConsentRecord_Transactions(Algorand.Address owner, Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 219, 161, 124 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uc2VudExlZGdlciIsImRlc2MiOiJcbiAgICBDb25zZW50TGVkZ2VyIC0gRGVjZW50cmFsaXplZCBaSyBjb25zZW50IG1hbmFnZW1lbnQgb24gQWxnb3JhbmQuXG5cbiAgICBQaGFzZSAyOiBkYXRhX3R5cGUvcHVycG9zZSByZXBsYWNlZCB3aXRoIGEgUG9zZWlkb24gY29tbWl0bWVudCBoYXNoLlxuICAgIEEgbnVsbGlmaWVyIHByZXZlbnRzIHJlcGxheSBhdHRhY2tzLiBEUERQIEFjdCBzZWN0aW9uIHJlY29yZGVkIG9uLWNoYWluLlxuICAgIENvbnNlbnQgaXMgbWludGVkIGFzIGFuIEFTQTsgcmV2b2tpbmcgZnJlZXplcyBpdCBvbi1jaGFpbi5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ29uc2VudFJlY29yZCI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJyZXF1ZXN0ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImNvbW1pdG1lbnQiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoibnVsbGlmaWVyIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImV4cGlyeSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkcGRwX3NlY3Rpb24iLCJ0eXBlIjoidWludDgifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ3JhbnRfY29uc2VudCIsImRlc2MiOiJNaW50IGEgY29uc2VudCBBU0EgYW5kIHN0b3JlIHRoZSBaSy1jb21taXR0ZWQgcmVjb3JkIGluIGJveCBzdG9yYWdlLlxuY29tbWl0bWVudCA9IFBvc2VpZG9uKGRhdGFfdHlwZV9oYXNoLCBwdXJwb3NlX2hhc2gsIHNhbHQpIOKAlCBkYXRhIG5ldmVyIHRvdWNoZXMgdGhlIGNoYWluIGluIHBsYWludGV4dC4gbnVsbGlmaWVyID0gU0hBMjU2KGlkZW50aXR5X3NlY3JldCB8fCBjb25zZW50X2lkKSDigJQgYW50aS1yZXBsYXkuXG5SZXR1cm5zIHRoZSBuZXdseSBjcmVhdGVkIGFzc2V0IElELiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb21taXRtZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudWxsaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkcGRwX3NlY3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfY29uc2VudCIsImRlc2MiOiJGcmVlemUgdGhlIGNvbnNlbnQgQVNBIHRvIHJlcHJlc2VudCBvbi1jaGFpbiByZXZvY2F0aW9uLlxuT25seSB0aGUgb3JpZ2luYWwgb3duZXIgb2YgdGhlIGNvbnNlbnQgbWF5IGNhbGwgdGhpcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19jb25zZW50X3ZhbGlkIiwiZGVzYyI6IlJlYWQtb25seSB2ZXJpZmllcjogcmV0dXJucyBUcnVlIGlmIGNvbnNlbnQgaXMgYWN0aXZlIGFuZCBub3QgZXhwaXJlZC5cbkNoZWNrczogcmVjb3JkIGV4aXN0cywgZXhwaXJ5IG5vdCBwYXNzZWQsIEFTQSBub3QgZnJvemVuLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29uc2VudF9yZWNvcmQiLCJkZXNjIjoiUmVhZC1vbmx5OiByZXR1cm5zIHRoZSBmdWxsIGNvbnNlbnQgcmVjb3JkLlxuY29tbWl0bWVudCBpcyBhIGhhc2gg4oCUIG5vIHBsYWludGV4dCBkYXRhIGlzIGV2ZXIgc3RvcmVkIG9yIHJldHVybmVkLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDgpIiwic3RydWN0IjoiQ29uc2VudFJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MDldLCJlcnJvck1lc3NhZ2UiOiJObyBjb25zZW50IHJlY29yZCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMV0sImVycm9yTWVzc2FnZSI6Ik51bGxpZmllciBhbHJlYWR5IHVzZWQgKHJlcGxheSBhdHRhY2spIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc5XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgb3duZXIgY2FuIHJldm9rZSBjb25zZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcxLDM0NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29uc2VudHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODIsOTAsOTgsMjY1LDMxMiwzMjAsMzk1LDQwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXpNaUF4SURBZ01UTTJDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdNSGd3TUNBd2VEZ3dDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklHTnNZWE56SUVOdmJuTmxiblJNWldSblpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXpDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGhNelk1WVRjMU1pQXdlRFF4TW1SallqazRJREI0TkdFMU5qbGlNV1lnTUhoalpHUmlZVEUzWXlBdkx5QnRaWFJvYjJRZ0ltZHlZVzUwWDJOdmJuTmxiblFvWVdSa2NtVnpjeXgxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTJOQ3gxYVc1ME9DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxkbTlyWlY5amIyNXpaVzUwS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlhWE5mWTI5dWMyVnVkRjkyWVd4cFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyTnZibk5sYm5SZmNtVmpiM0prS0dGa1pISmxjM01zWVdSa2NtVnpjeWtvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwT0NraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQm5jbUZ1ZEY5amIyNXpaVzUwSUhKbGRtOXJaVjlqYjI1elpXNTBJR2x6WDJOdmJuTmxiblJmZG1Gc2FXUWdaMlYwWDJOdmJuTmxiblJmY21WamIzSmtDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRNNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1elpXNTBYMnhsWkdkbGNpNWpiMjUwY21GamRDNURiMjV6Wlc1MFRHVmtaMlZ5TG1keVlXNTBYMk52Ym5ObGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuY21GdWRGOWpiMjV6Wlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk5nb2dJQ0FnTHk4Z1lYTnpaWEowSUc1MWJHeGZhMlY1SUc1dmRDQnBiaUJ6Wld4bUxtNTFiR3hwWm1sbGNuTXNJQ0pPZFd4c2FXWnBaWElnWVd4eVpXRmtlU0IxYzJWa0lDaHlaWEJzWVhrZ1lYUjBZV05yS1NJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURabE56VTJZelpqTldZS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RuVnNiR2xtYVdWeUlHRnNjbVZoWkhrZ2RYTmxaQ0FvY21Wd2JHRjVJR0YwZEdGamF5a0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z2MyVnNaaTV1ZFd4c2FXWnBaWEp6VzI1MWJHeGZhMlY1WFNBOUlHRnlZelF1UW05dmJDaFVjblZsS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURnd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qa3RPRElLSUNBZ0lDOHZJQ01nVFdsdWRDQXhJR052Ym5ObGJuUWdkRzlyWlc0Z0tFNUdWQzF6ZEhsc1pTd2dhVzVrYVhacGMybGliR1VwQ2lBZ0lDQXZMeUJ0YVc1MFgzSmxjM1ZzZENBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OU1Td0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejB3TEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJmYm1GdFpUMWlJa05QVGxORlRsUWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOVlpSkRiMjV6Wlc1MFZHOXJaVzRpTEFvZ0lDQWdMeThnSUNBZ0lHNXZkR1U5WWlKRGIyNXpaVzUwVEdWa1oyVnlmSHByWDJOdmJXMXBkSFJsWkNJc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWm5KdmVtVnVQVVpoYkhObExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPamMyQ2lBZ0lDQXZMeUJ0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qYzNMVGM1Q2lBZ0lDQXZMeUJ5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5Qm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQmtkWEJ1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnWkdWbVlYVnNkRjltY205NlpXNDlSbUZzYzJVc0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVSbFptRjFiSFJHY205NlpXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkRiR0YzWW1GamF3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFWnlaV1Y2WlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZKbGMyVnlkbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJOWVc1aFoyVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklHNXZkR1U5WWlKRGIyNXpaVzUwVEdWa1oyVnlmSHByWDJOdmJXMXBkSFJsWkNJc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME16Wm1ObVUzTXpZMU5tVTNORFJqTmpVMk5EWTNOalUzTWpkak4yRTJZalZtTmpNMlpqWmtObVEyT1RjME56UTJOVFkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRTV2ZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnWVhOelpYUmZibUZ0WlQxaUlrTnZibk5sYm5SVWIydGxiaUlzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTXpabU5tVTNNelkxTm1VM05EVTBObVkyWWpZMU5tVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDFpSWtOUFRsTkZUbFFpTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRNMFpqUmxOVE0wTlRSbE5UUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUIwYjNSaGJEMHhMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPalk1TFRjd0NpQWdJQ0F2THlBaklFMXBiblFnTVNCamIyNXpaVzUwSUhSdmEyVnVJQ2hPUmxRdGMzUjViR1VzSUdsdVpHbDJhWE5wWW14bEtRb2dJQ0FnTHk4Z2JXbHVkRjl5WlhOMWJIUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG8yT1MwNE1nb2dJQ0FnTHk4Z0l5Qk5hVzUwSURFZ1kyOXVjMlZ1ZENCMGIydGxiaUFvVGtaVUxYTjBlV3hsTENCcGJtUnBkbWx6YVdKc1pTa0tJQ0FnSUM4dklHMXBiblJmY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdJaVEwOU9VMFZPVkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDFpSWtOdmJuTmxiblJVYjJ0bGJpSXNDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMWlJa052Ym5ObGJuUk1aV1JuWlhKOGVtdGZZMjl0YldsMGRHVmtJaXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QnZkMjVsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RNS0lDQWdJQzh2SUdGemMyVjBYMmxrUFdGeVl6UXVWVWx1ZERZMEtHNWxkMTloYzNObGRGOXBaQ2tzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZPRFl0T1RVS0lDQWdJQzh2SUNNZ1UzUnZjbVVnV2tzdFkyOXRiV2wwZEdWa0lHTnZibk5sYm5RZ2NtVmpiM0prSUd0bGVXVmtJR0o1SUhObGJtUmxjbng4Y21WeGRXVnpkR1Z5SUNnMk5DQmllWFJsY3lrS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUVOdmJuTmxiblJTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYjNkdVpYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSEpsY1hWbGMzUmxjajF5WlhGMVpYTjBaWElzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXRiV2wwYldWdWREMWpiMjF0YVhSdFpXNTBMbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0J1ZFd4c2FXWnBaWEk5Ym5Wc2JHbG1hV1Z5TG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCbGVIQnBjbms5Wlhod2FYSjVMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMmxrUFdGeVl6UXVWVWx1ZERZMEtHNWxkMTloYzNObGRGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pIQmtjRjl6WldOMGFXOXVQV1J3WkhCZmMyVmpkR2x2Yml3S0lDQWdJQzh2SUNrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJR0p2ZUY5clpYa2dQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnY21WeGRXVnpkR1Z5TG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZibk5sYm5SelcySnZlRjlyWlhsZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVkRjlzWldSblpYSXVZMjl1ZEhKaFkzUXVRMjl1YzJWdWRFeGxaR2RsY2k1eVpYWnZhMlZmWTI5dWMyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGRtOXJaVjlqYjI1elpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNRGNLSUNBZ0lDOHZJR0p2ZUY5clpYa2dQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnY21WeGRXVnpkR1Z5TG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1Ea0tJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WTI5dWMyVnVkSE5iWW05NFgydGxlVjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjI1elpXNTBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXViM2R1WlhJZ1BUMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExDQWlUMjVzZVNCMGFHVWdiM2R1WlhJZ1kyRnVJSEpsZG05clpTQmpiMjV6Wlc1MElnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0IwYUdVZ2IzZHVaWElnWTJGdUlISmxkbTlyWlNCamIyNXpaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJ1WVhScGRtVmZZWE56WlhSZmFXUWdQU0J5WldOdmNtUXVZWE56WlhSZmFXUXVibUYwYVhabENpQWdJQ0JwYm5Salh6TWdMeThnTVRNMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeE5DMHhNVGtLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJHY21WbGVtVW9DaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxYMkZ6YzJWMFBVRnpjMlYwS0c1aGRHbDJaVjloYzNObGRGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsWDJGalkyOTFiblE5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbWNtOTZaVzQ5VkhKMVpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TVRZS0lDQWdJQzh2SUdaeVpXVjZaVjloWTJOdmRXNTBQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXhOd29nSUNBZ0x5OGdabkp2ZW1WdVBWUnlkV1VzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkdjbVZsZW1WQmMzTmxkRVp5YjNwbGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR2NtVmxlbVZCYzNObGRFRmpZMjkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm5KbFpYcGxRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSR2NtVmxlbVVvQ2lBZ0lDQndkWE5vYVc1MElEVWdMeThnWVdaeWVnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1UUXRNVEU1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwUm5KbFpYcGxLQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVjloYzNObGREMUJjM05sZENodVlYUnBkbVZmWVhOelpYUmZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlY5aFkyTnZkVzUwUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSnZlbVZ1UFZSeWRXVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFd01Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblJmYkdWa1oyVnlMbU52Ym5SeVlXTjBMa052Ym5ObGJuUk1aV1JuWlhJdWFYTmZZMjl1YzJWdWRGOTJZV3hwWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpYMk52Ym5ObGJuUmZkbUZzYVdRNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1ltOTRYMnRsZVNBOUlHOTNibVZ5TG1KNWRHVnpJQ3NnY21WeGRXVnpkR1Z5TG1KNWRHVnpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdhV1lnWW05NFgydGxlU0J1YjNRZ2FXNGdjMlZzWmk1amIyNXpaVzUwY3pvS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR2x6WDJOdmJuTmxiblJmZG1Gc2FXUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2dwcGMxOWpiMjV6Wlc1MFgzWmhiR2xrWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5SZmJHVmtaMlZ5TG1OdmJuUnlZV04wTGtOdmJuTmxiblJNWldSblpYSXVhWE5mWTI5dWMyVnVkRjkyWVd4cFpFQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXlNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0thWE5mWTI5dWMyVnVkRjkyWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNMkNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbU52Ym5ObGJuUnpXMkp2ZUY5clpYbGRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dWMyVnVkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCcFppQnlaV052Y21RdVpYaHdhWEo1TG01aGRHbDJaU0FoUFNBd0lHRnVaQ0J5WldOdmNtUXVaWGh3YVhKNUxtNWhkR2wyWlNBOElFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhNamdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdZbm9nYVhOZlkyOXVjMlZ1ZEY5MllXeHBaRjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUdScFp5QXhDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBOENpQWdJQ0JpZWlCcGMxOWpiMjV6Wlc1MFgzWmhiR2xrWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXpPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaEdZV3h6WlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJwYzE5amIyNXpaVzUwWDNaaGJHbGtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblJmYkdWa1oyVnlMbU52Ym5SeVlXTjBMa052Ym5ObGJuUk1aV1JuWlhJdWFYTmZZMjl1YzJWdWRGOTJZV3hwWkVBNUNncHBjMTlqYjI1elpXNTBYM1poYkdsa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TkRFS0lDQWdJQzh2SUc1aGRHbDJaVjloYzNObGRGOXBaQ0E5SUhKbFkyOXlaQzVoYzNObGRGOXBaQzV1WVhScGRtVUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYek1nTHk4Z01UTTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTBOUW9nSUNBZ0x5OGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dZWE56WlhRS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRRMExURTBOZ29nSUNBZ0x5OGdhWE5mWm5KdmVtVnVMQ0JmWlhocGMzUnpJRDBnYjNBdVFYTnpaWFJJYjJ4a2FXNW5SMlYwTG1GemMyVjBYMlp5YjNwbGJpZ0tJQ0FnSUM4dklDQWdJQ0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0JoYzNObGRBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkdjbTk2Wlc0S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnYVdZZ2FYTmZabkp2ZW1WdU9nb2dJQ0FnWW5vZ2FYTmZZMjl1YzJWdWRGOTJZV3hwWkY5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29SbUZzYzJVcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnYVhOZlkyOXVjMlZ1ZEY5MllXeHBaRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1amIyNXpaVzUwWDJ4bFpHZGxjaTVqYjI1MGNtRmpkQzVEYjI1elpXNTBUR1ZrWjJWeUxtbHpYMk52Ym5ObGJuUmZkbUZzYVdSQU9Rb0thWE5mWTI5dWMyVnVkRjkyWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRVd0NpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRPREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNakVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ2FYTmZZMjl1YzJWdWRGOTJZV3hwWkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MFgyeGxaR2RsY2k1amIyNTBjbUZqZEM1RGIyNXpaVzUwVEdWa1oyVnlMbWx6WDJOdmJuTmxiblJmZG1Gc2FXUkFPUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyNXpaVzUwWDJ4bFpHZGxjaTVqYjI1MGNtRmpkQzVEYjI1elpXNTBUR1ZrWjJWeUxtZGxkRjlqYjI1elpXNTBYM0psWTI5eVpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5amIyNXpaVzUwWDNKbFkyOXlaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRZeUNpQWdJQ0F2THlCaWIzaGZhMlY1SUQwZ2IzZHVaWEl1WW5sMFpYTWdLeUJ5WlhGMVpYTjBaWEl1WW5sMFpYTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTJNd29nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjlyWlhrZ2FXNGdjMlZzWmk1amIyNXpaVzUwY3l3Z0lrNXZJR052Ym5ObGJuUWdjbVZqYjNKa0lHWnZkVzVrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmpiMjV6Wlc1MElISmxZMjl5WkNCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTJOQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WTI5dWMyVnVkSE5iWW05NFgydGxlVjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFSUFFQWlBRW1Bd1FWSDN4MUFRQUJnREViUVFBck1Sa1VSREVZUklJRUJLTnBwMUlFUVMzTG1BUktWcHNmQk0zYm9YdzJHZ0NPQkFBSkFNQUE3QUZDQURFWkZERVlGQkJETmhvQlNSVWlFa1EyR2dKSkZTSVNSRFlhQTBrVkloSkVOaG9FU1JXQkNCSkVOaG9GU1JVakVrU0FCVzUxYkd4ZlN3TlFTYjFGQVJSRUtyK3hNZ3BIQXlTeUpMSXNzaXV5S3JJcGdCcERiMjV6Wlc1MFRHVmtaMlZ5ZkhwclgyTnZiVzFwZEhSbFpMSUZnQXhEYjI1elpXNTBWRzlyWlc2eUpvQUhRMDlPVTBWT1ZMSWxKTElqSTdJaWdRT3lFQ1N5QWJNeEFMUThGa3hMQmxCUEJWQlBCRkJQQTFCTEFWQlBBbEF4QUU4RFVFeS9LRXhRc0NORE5ob0JTUlVpRWtReEFFeFF2a1JKVndBZ01RQVNSQ1Zic1RJS0k3SXZzaTZ5TFlFRnNoQWtzZ0d6STBNa2dBQTJHZ0ZKRlNJU1JEWWFBa2tWSWhKRVVFbTlSUUZBQUFjcEtFeFFzQ05EU2I1TVNVNENSUVZFZ1lBQlcwbEZBMEVBREVzQk1nY01RUUFFS1VMLzIwc0NKVnN5Q2t4d0FVaEJBQVFwUXYvS0trTC94allhQVVrVkloSkVOaG9DU1JVaUVrUlFTYjFGQVVTK1NDaE1VTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
