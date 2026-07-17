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

namespace Arc56.Generated.CompsciiNikhil.GenMark_AI_Content_Origin_Misuse_Detection.GenMark_003b90ec
{


    //
    // 
    //    GenMark — AI Content Origin Registry
    //
    //    Core innovation: every AI-generated image receives a silent, unforgeable
    //    digital birth certificate at the moment of creation. The perceptual hash
    //    (pHash) fingerprint enables tracking even through resizing, compression,
    //    format conversion, and minor editing — unlike SHA-256 which changes on
    //    any pixel modification.
    //
    //    Registration flow (invisible to users):
    //      1. User generates image on the GenMark platform
    //      2. Backend computes pHash using the imagehash Python library
    //      3. Backend calls register_content() in an atomic transaction group
    //      4. A soulbound ASA is minted as the cryptographic ownership credential
    //      5. Record is permanently stored in Algorand Box storage
    //      6. User sees only a small "Content Stamped ✓" badge
    //
    //    Verification flow:
    //      1. Investigator uploads suspicious image to the verify portal
    //      2. Backend computes pHash of the uploaded image
    //      3. Backend calls verify_content() (read-only, no fees)
    //      4. Full origin record is returned: creator, platform, exact timestamp
    //      5. Investigator can download a forensic PDF certificate
    //
    //    Misuse flagging:
    //      1. Investigator clicks "Report Misuse" with a description
    //      2. Backend calls flag_misuse() in an atomic transaction
    //      3. Immutable flag record stored in a dedicated box (cannot be deleted)
    //      4. Transaction ID serves as evidence of the report being filed
    //
    //    Design decisions:
    //      • Box namespace "reg_" separates registry boxes from flag boxes ("flg_")
    //      • Soulbound ASA: total=1, decimals=0, default_frozen=True, all roles=contract
    //      • flag_count is the only field updated post-registration → box size stays constant
    //      • Payment requirements prevent spam and cover box Minimum Balance Requirements
    //    
    //
    public class GenMarkProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GenMarkProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ContentRecord : AVMObjectType
            {
                public string CreatorName { get; set; }

                public Algorand.Address CreatorAddress { get; set; }

                public string Platform { get; set; }

                public ulong Timestamp { get; set; }

                public ulong AsaId { get; set; }

                public ulong FlagCount { get; set; }

                public string OriginalPhash { get; set; }

                public string MorphedBy { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatorName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCreatorName.From(CreatorName);
                    stringRef[ret.Count] = vCreatorName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatorAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreatorAddress.From(CreatorAddress);
                    ret.AddRange(vCreatorAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlatform = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPlatform.From(Platform);
                    stringRef[ret.Count] = vPlatform.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsaId.From(AsaId);
                    ret.AddRange(vAsaId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlagCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFlagCount.From(FlagCount);
                    ret.AddRange(vFlagCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOriginalPhash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOriginalPhash.From(OriginalPhash);
                    stringRef[ret.Count] = vOriginalPhash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMorphedBy = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMorphedBy.From(MorphedBy);
                    stringRef[ret.Count] = vMorphedBy.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ContentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ContentRecord();
                    uint count = 0;
                    var indexCreatorName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatorName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCreatorName.Decode(bytes.Skip(indexCreatorName + prefixOffset).ToArray());
                    var valueCreatorName = vCreatorName.ToValue();
                    if (valueCreatorName is string vCreatorNameValue) { ret.CreatorName = vCreatorNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatorAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreatorAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatorAddress = vCreatorAddress.ToValue();
                    if (valueCreatorAddress is Algorand.Address vCreatorAddressValue) { ret.CreatorAddress = vCreatorAddressValue; }
                    var indexPlatform = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlatform = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPlatform.Decode(bytes.Skip(indexPlatform + prefixOffset).ToArray());
                    var valuePlatform = vPlatform.ToValue();
                    if (valuePlatform is string vPlatformValue) { ret.Platform = vPlatformValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsaId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsaId = vAsaId.ToValue();
                    if (valueAsaId is ulong vAsaIdValue) { ret.AsaId = vAsaIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlagCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFlagCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFlagCount = vFlagCount.ToValue();
                    if (valueFlagCount is ulong vFlagCountValue) { ret.FlagCount = vFlagCountValue; }
                    var indexOriginalPhash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOriginalPhash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOriginalPhash.Decode(bytes.Skip(indexOriginalPhash + prefixOffset).ToArray());
                    var valueOriginalPhash = vOriginalPhash.ToValue();
                    if (valueOriginalPhash is string vOriginalPhashValue) { ret.OriginalPhash = vOriginalPhashValue; }
                    var indexMorphedBy = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMorphedBy = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMorphedBy.Decode(bytes.Skip(indexMorphedBy + prefixOffset).ToArray());
                    var valueMorphedBy = vMorphedBy.ToValue();
                    if (valueMorphedBy is string vMorphedByValue) { ret.MorphedBy = vMorphedByValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ContentRecord);
                }
                public bool Equals(ContentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ContentRecord left, ContentRecord right)
                {
                    return EqualityComparer<ContentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ContentRecord left, ContentRecord right)
                {
                    return !(left == right);
                }

            }

            public class VerifyContentReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public Structs.ContentRecord Field1 { get; set; } = new Structs.ContentRecord();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    stringRef[ret.Count] = Field1.ToByteArray();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VerifyContentReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new VerifyContentReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.ContentRecord.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VerifyContentReturn);
                }
                public bool Equals(VerifyContentReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VerifyContentReturn left, VerifyContentReturn right)
                {
                    return EqualityComparer<VerifyContentReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(VerifyContentReturn left, VerifyContentReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Register a new AI-generated content item with its perceptual fingerprint.
        ///Called silently at the moment of image generation. The user never sees blockchain terminology — they see only a "Content Stamped ✓" badge.
        ///</summary>
        /// <param name="phash"> </param>
        /// <param name="creator_name">Display name of the content creator. </param>
        /// <param name="platform"> </param>
        /// <param name="original_phash"> </param>
        /// <param name="morphed_by"> </param>
        /// <param name="pay_txn"> </param>
        public async Task<ulong> RegisterContent(PaymentTransaction pay_txn, string phash, string creator_name, string platform, string original_phash, string morphed_by, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 120, 247, 105, 69 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);
            var creator_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); creator_nameAbi.From(creator_name);
            var platformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); platformAbi.From(platform);
            var original_phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); original_phashAbi.From(original_phash);
            var morphed_byAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); morphed_byAbi.From(morphed_by);

            var result = await base.CallApp(new List<object> { abiHandle, phashAbi, creator_nameAbi, platformAbi, original_phashAbi, morphed_byAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterContent_Transactions(PaymentTransaction pay_txn, string phash, string creator_name, string platform, string original_phash, string morphed_by, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 120, 247, 105, 69 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);
            var creator_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); creator_nameAbi.From(creator_name);
            var platformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); platformAbi.From(platform);
            var original_phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); original_phashAbi.From(original_phash);
            var morphed_byAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); morphed_byAbi.From(morphed_by);

            return await base.MakeTransactionList(new List<object> { abiHandle, phashAbi, creator_nameAbi, platformAbi, original_phashAbi, morphed_byAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Look up a content item by its perceptual hash and return the origin record.
        ///This is a READ-ONLY method (readonly=True). It can be simulated without submitting a transaction — zero fees, zero state changes. Anyone, anywhere, can verify any image without a wallet or any blockchain knowledge.
        ///</summary>
        /// <param name="phash">Perceptual hash of the image to verify (16-char hex string). </param>
        public async Task<Structs.VerifyContentReturn> VerifyContent(string phash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 246, 34, 172 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);

            var result = await base.SimApp(new List<object> { abiHandle, phashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VerifyContentReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyContent_Transactions(string phash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 246, 34, 172 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);

            return await base.MakeTransactionList(new List<object> { abiHandle, phashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///File an immutable misuse report against a registered content item.
        ///Each flag is stored in a dedicated box with a composite key:     key = b"flg_" + arc4_encode(phash) + itob(flag_index)
        ///The transaction ID of this call is legally meaningful evidence — it proves a report was filed at a specific time and included a specific description. Flags can never be deleted or modified, creating a tamper-proof evidence chain.
        ///</summary>
        /// <param name="phash"> </param>
        /// <param name="description"> </param>
        /// <param name="pay_txn"> </param>
        public async Task<ulong> FlagMisuse(PaymentTransaction pay_txn, string phash, string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 241, 161, 250, 225 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            var result = await base.CallApp(new List<object> { abiHandle, phashAbi, descriptionAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FlagMisuse_Transactions(PaymentTransaction pay_txn, string phash, string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 241, 161, 250, 225 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            return await base.MakeTransactionList(new List<object> { abiHandle, phashAbi, descriptionAbi, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve the description text of a specific misuse flag.
        ///Flags are immutable and indexed sequentially from 0. Use verify_content() first to get the flag_count, then iterate.
        ///</summary>
        /// <param name="phash"> </param>
        /// <param name="flag_index"> </param>
        public async Task<string> GetFlag(string phash, ulong flag_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 3, 252, 156 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);
            var flag_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); flag_indexAbi.From(flag_index);

            var result = await base.SimApp(new List<object> { abiHandle, phashAbi, flag_indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetFlag_Transactions(string phash, ulong flag_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 3, 252, 156 };
            var phashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phashAbi.From(phash);
            var flag_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); flag_indexAbi.From(flag_index);

            return await base.MakeTransactionList(new List<object> { abiHandle, phashAbi, flag_indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2VuTWFyayIsImRlc2MiOiJcbiAgICBHZW5NYXJrIOKAlCBBSSBDb250ZW50IE9yaWdpbiBSZWdpc3RyeVxuXG4gICAgQ29yZSBpbm5vdmF0aW9uOiBldmVyeSBBSS1nZW5lcmF0ZWQgaW1hZ2UgcmVjZWl2ZXMgYSBzaWxlbnQsIHVuZm9yZ2VhYmxlXG4gICAgZGlnaXRhbCBiaXJ0aCBjZXJ0aWZpY2F0ZSBhdCB0aGUgbW9tZW50IG9mIGNyZWF0aW9uLiBUaGUgcGVyY2VwdHVhbCBoYXNoXG4gICAgKHBIYXNoKSBmaW5nZXJwcmludCBlbmFibGVzIHRyYWNraW5nIGV2ZW4gdGhyb3VnaCByZXNpemluZywgY29tcHJlc3Npb24sXG4gICAgZm9ybWF0IGNvbnZlcnNpb24sIGFuZCBtaW5vciBlZGl0aW5nIOKAlCB1bmxpa2UgU0hBLTI1NiB3aGljaCBjaGFuZ2VzIG9uXG4gICAgYW55IHBpeGVsIG1vZGlmaWNhdGlvbi5cblxuICAgIFJlZ2lzdHJhdGlvbiBmbG93IChpbnZpc2libGUgdG8gdXNlcnMpOlxuICAgICAgMS4gVXNlciBnZW5lcmF0ZXMgaW1hZ2Ugb24gdGhlIEdlbk1hcmsgcGxhdGZvcm1cbiAgICAgIDIuIEJhY2tlbmQgY29tcHV0ZXMgcEhhc2ggdXNpbmcgdGhlIGltYWdlaGFzaCBQeXRob24gbGlicmFyeVxuICAgICAgMy4gQmFja2VuZCBjYWxscyByZWdpc3Rlcl9jb250ZW50KCkgaW4gYW4gYXRvbWljIHRyYW5zYWN0aW9uIGdyb3VwXG4gICAgICA0LiBBIHNvdWxib3VuZCBBU0EgaXMgbWludGVkIGFzIHRoZSBjcnlwdG9ncmFwaGljIG93bmVyc2hpcCBjcmVkZW50aWFsXG4gICAgICA1LiBSZWNvcmQgaXMgcGVybWFuZW50bHkgc3RvcmVkIGluIEFsZ29yYW5kIEJveCBzdG9yYWdlXG4gICAgICA2LiBVc2VyIHNlZXMgb25seSBhIHNtYWxsIFwiQ29udGVudCBTdGFtcGVkIOKck1wiIGJhZGdlXG5cbiAgICBWZXJpZmljYXRpb24gZmxvdzpcbiAgICAgIDEuIEludmVzdGlnYXRvciB1cGxvYWRzIHN1c3BpY2lvdXMgaW1hZ2UgdG8gdGhlIHZlcmlmeSBwb3J0YWxcbiAgICAgIDIuIEJhY2tlbmQgY29tcHV0ZXMgcEhhc2ggb2YgdGhlIHVwbG9hZGVkIGltYWdlXG4gICAgICAzLiBCYWNrZW5kIGNhbGxzIHZlcmlmeV9jb250ZW50KCkgKHJlYWQtb25seSwgbm8gZmVlcylcbiAgICAgIDQuIEZ1bGwgb3JpZ2luIHJlY29yZCBpcyByZXR1cm5lZDogY3JlYXRvciwgcGxhdGZvcm0sIGV4YWN0IHRpbWVzdGFtcFxuICAgICAgNS4gSW52ZXN0aWdhdG9yIGNhbiBkb3dubG9hZCBhIGZvcmVuc2ljIFBERiBjZXJ0aWZpY2F0ZVxuXG4gICAgTWlzdXNlIGZsYWdnaW5nOlxuICAgICAgMS4gSW52ZXN0aWdhdG9yIGNsaWNrcyBcIlJlcG9ydCBNaXN1c2VcIiB3aXRoIGEgZGVzY3JpcHRpb25cbiAgICAgIDIuIEJhY2tlbmQgY2FsbHMgZmxhZ19taXN1c2UoKSBpbiBhbiBhdG9taWMgdHJhbnNhY3Rpb25cbiAgICAgIDMuIEltbXV0YWJsZSBmbGFnIHJlY29yZCBzdG9yZWQgaW4gYSBkZWRpY2F0ZWQgYm94IChjYW5ub3QgYmUgZGVsZXRlZClcbiAgICAgIDQuIFRyYW5zYWN0aW9uIElEIHNlcnZlcyBhcyBldmlkZW5jZSBvZiB0aGUgcmVwb3J0IGJlaW5nIGZpbGVkXG5cbiAgICBEZXNpZ24gZGVjaXNpb25zOlxuICAgICAg4oCiIEJveCBuYW1lc3BhY2UgXCJyZWdfXCIgc2VwYXJhdGVzIHJlZ2lzdHJ5IGJveGVzIGZyb20gZmxhZyBib3hlcyAoXCJmbGdfXCIpXG4gICAgICDigKIgU291bGJvdW5kIEFTQTogdG90YWw9MSwgZGVjaW1hbHM9MCwgZGVmYXVsdF9mcm96ZW49VHJ1ZSwgYWxsIHJvbGVzPWNvbnRyYWN0XG4gICAgICDigKIgZmxhZ19jb3VudCBpcyB0aGUgb25seSBmaWVsZCB1cGRhdGVkIHBvc3QtcmVnaXN0cmF0aW9uIOKGkiBib3ggc2l6ZSBzdGF5cyBjb25zdGFudFxuICAgICAg4oCiIFBheW1lbnQgcmVxdWlyZW1lbnRzIHByZXZlbnQgc3BhbSBhbmQgY292ZXIgYm94IE1pbmltdW0gQmFsYW5jZSBSZXF1aXJlbWVudHNcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ29udGVudFJlY29yZCI6W3sibmFtZSI6ImNyZWF0b3JfbmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjcmVhdG9yX2FkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBsYXRmb3JtIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc2FfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmxhZ19jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvcmlnaW5hbF9waGFzaCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJtb3JwaGVkX2J5IiwidHlwZSI6InN0cmluZyJ9XSwiVmVyaWZ5Q29udGVudFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6IkNvbnRlbnRSZWNvcmQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVnaXN0ZXJfY29udGVudCIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyBBSS1nZW5lcmF0ZWQgY29udGVudCBpdGVtIHdpdGggaXRzIHBlcmNlcHR1YWwgZmluZ2VycHJpbnQuXG5DYWxsZWQgc2lsZW50bHkgYXQgdGhlIG1vbWVudCBvZiBpbWFnZSBnZW5lcmF0aW9uLiBUaGUgdXNlciBuZXZlciBzZWVzIGJsb2NrY2hhaW4gdGVybWlub2xvZ3kg4oCUIHRoZXkgc2VlIG9ubHkgYSBcIkNvbnRlbnQgU3RhbXBlZCDinJNcIiBiYWRnZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGhhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3JfbmFtZSIsImRlc2MiOiJEaXNwbGF5IG5hbWUgb2YgdGhlIGNvbnRlbnQgY3JlYXRvci4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmlnaW5hbF9waGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibW9ycGhlZF9ieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5X3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgQWxnb3JhbmQgU3RhbmRhcmQgQXNzZXQgSUQgb2YgdGhlIG1pbnRlZCBzb3VsYm91bmQgY2VydGlmaWNhdGUuIFRoaXMgSUQgaXMgc3RvcmVkIGluIHRoZSByZWNvcmQgYW5kIHJldHVybmVkIHRvIHRoZSBmcm9udGVuZC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfY29udGVudCIsImRlc2MiOiJMb29rIHVwIGEgY29udGVudCBpdGVtIGJ5IGl0cyBwZXJjZXB0dWFsIGhhc2ggYW5kIHJldHVybiB0aGUgb3JpZ2luIHJlY29yZC5cblRoaXMgaXMgYSBSRUFELU9OTFkgbWV0aG9kIChyZWFkb25seT1UcnVlKS4gSXQgY2FuIGJlIHNpbXVsYXRlZCB3aXRob3V0IHN1Ym1pdHRpbmcgYSB0cmFuc2FjdGlvbiDigJQgemVybyBmZWVzLCB6ZXJvIHN0YXRlIGNoYW5nZXMuIEFueW9uZSwgYW55d2hlcmUsIGNhbiB2ZXJpZnkgYW55IGltYWdlIHdpdGhvdXQgYSB3YWxsZXQgb3IgYW55IGJsb2NrY2hhaW4ga25vd2xlZGdlLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwaGFzaCIsImRlc2MiOiJQZXJjZXB0dWFsIGhhc2ggb2YgdGhlIGltYWdlIHRvIHZlcmlmeSAoMTYtY2hhciBoZXggc3RyaW5nKS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsKHN0cmluZyxhZGRyZXNzLHN0cmluZyx1aW50NjQsdWludDY0LHVpbnQ2NCxzdHJpbmcsc3RyaW5nKSkiLCJzdHJ1Y3QiOiJWZXJpZnlDb250ZW50UmV0dXJuIiwiZGVzYyI6Iihmb3VuZCwgcmVjb3JkKTogQVJDLTQgdHVwbGUgd2hlcmU6IGZvdW5kPVRydWUgIOKGkiBjb250ZW50IHdhcyByZWdpc3RlcmVkOyByZWNvcmQgaGFzIGZ1bGwgb3JpZ2luIGRldGFpbHMgZm91bmQ9RmFsc2Ug4oaSIG5vIHJlZ2lzdHJhdGlvbiBmb3VuZDsgdHJlYXQgYXMgdW5yZWdpc3RlcmVkIChzdXNwaWNpb3VzKSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZmxhZ19taXN1c2UiLCJkZXNjIjoiRmlsZSBhbiBpbW11dGFibGUgbWlzdXNlIHJlcG9ydCBhZ2FpbnN0IGEgcmVnaXN0ZXJlZCBjb250ZW50IGl0ZW0uXG5FYWNoIGZsYWcgaXMgc3RvcmVkIGluIGEgZGVkaWNhdGVkIGJveCB3aXRoIGEgY29tcG9zaXRlIGtleTogICAgIGtleSA9IGJcImZsZ19cIiArIGFyYzRfZW5jb2RlKHBoYXNoKSArIGl0b2IoZmxhZ19pbmRleClcblRoZSB0cmFuc2FjdGlvbiBJRCBvZiB0aGlzIGNhbGwgaXMgbGVnYWxseSBtZWFuaW5nZnVsIGV2aWRlbmNlIOKAlCBpdCBwcm92ZXMgYSByZXBvcnQgd2FzIGZpbGVkIGF0IGEgc3BlY2lmaWMgdGltZSBhbmQgaW5jbHVkZWQgYSBzcGVjaWZpYyBkZXNjcmlwdGlvbi4gRmxhZ3MgY2FuIG5ldmVyIGJlIGRlbGV0ZWQgb3IgbW9kaWZpZWQsIGNyZWF0aW5nIGEgdGFtcGVyLXByb29mIGV2aWRlbmNlIGNoYWluLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVzY3JpcHRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiWmVyby1iYXNlZCBpbmRleCBvZiB0aGlzIGZsYWcgZm9yIHRoaXMgY29udGVudCBpdGVtLiBVc2UgKHBoYXNoICsgZmxhZ19pbmRleCkgdG8gcmV0cmlldmUgdGhlIGZsYWcgdmlhIGdldF9mbGFnKCkuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2ZsYWciLCJkZXNjIjoiUmV0cmlldmUgdGhlIGRlc2NyaXB0aW9uIHRleHQgb2YgYSBzcGVjaWZpYyBtaXN1c2UgZmxhZy5cbkZsYWdzIGFyZSBpbW11dGFibGUgYW5kIGluZGV4ZWQgc2VxdWVudGlhbGx5IGZyb20gMC4gVXNlIHZlcmlmeV9jb250ZW50KCkgZmlyc3QgdG8gZ2V0IHRoZSBmbGFnX2NvdW50LCB0aGVuIGl0ZXJhdGUuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBoYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmbGFnX2luZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBBUkMtNCBlbmNvZGVkIGRlc2NyaXB0aW9uIHN0cmluZyBvZiB0aGUgZmxhZy4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTU1XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IGZpbGUgYSBtaXN1c2UgcmVwb3J0OiBjb250ZW50IG5vdCByZWdpc3RlcmVkIG9uIEdlbk1hcmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjddLCJlcnJvck1lc3NhZ2UiOiJGbGFnIG5vdCBmb3VuZCBhdCB0aGUgc3BlY2lmaWVkIGluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTczXSwiZXJyb3JNZXNzYWdlIjoiTWluaW11bSAwLjA1IEFMR08gKDUwLDAwMCBtaWNyb0FsZ29zKSByZXF1aXJlZCBmb3IgZmxhZyBib3ggc3RvcmFnZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NV0sImVycm9yTWVzc2FnZSI6Ik1pbmltdW0gMC4yIEFMR08gKDIwMCwwMDAgbWljcm9BbGdvcykgcmVxdWlyZWQgZm9yIGJveCBNQlIgKyBBU0EgY3JlYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NSwxMTcsMTQ5LDE3Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2M10sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSBkaXJlY3RlZCB0byB0aGUgR2VuTWFyayBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSBkaXJlY3RlZCB0byB0aGUgR2VuTWFyayBjb250cmFjdCB0byBmdW5kIGJveCBzdG9yYWdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU1XSwiZXJyb3JNZXNzYWdlIjoiVGhpcyBjb250ZW50IGZpbmdlcnByaW50IGhhcyBhbHJlYWR5IGJlZW4gcmVnaXN0ZXJlZCBvbiBHZW5NYXJrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTgsMTIwLDE1MiwxNzldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU2LDU3Niw2MDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlZ2lzdHJ5IGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcmVnaXN0cmF0aW9ucyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzYsMjA0XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVoyVnViV0Z5YXk1amIyNTBjbUZqZEM1SFpXNU5ZWEpyTGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSjBiM1JoYkY5eVpXZHBjM1J5WVhScGIyNXpJaUF3ZURjeU5qVTJOelZtSURCNE5qWTJZelkzTldZS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aVzV0WVhKckwyTnZiblJ5WVdOMExuQjVPakV5TndvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5eVpXZHBjM1J5WVhScGIyNXpJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXlaV2RwYzNSeVlYUnBiMjV6SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpXNXRZWEpyTDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QmpiR0Z6Y3lCSFpXNU5ZWEpyS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFPUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGM0WmpjMk9UUTFJREI0TnpkbU5qSXlZV01nTUhobU1XRXhabUZsTVNBd2VEYzFNRE5tWXpsaklDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZZMjl1ZEdWdWRDaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIQmhlU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVWOWpiMjUwWlc1MEtITjBjbWx1Wnlrb1ltOXZiQ3dvYzNSeWFXNW5MR0ZrWkhKbGMzTXNjM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5eHpkSEpwYm1jcEtTSXNJRzFsZEdodlpDQWlabXhoWjE5dGFYTjFjMlVvYzNSeWFXNW5MSE4wY21sdVp5eHdZWGtwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZlpteGhaeWh6ZEhKcGJtY3NkV2x1ZERZMEtYTjBjbWx1WnlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmY21WbmFYTjBaWEpmWTI5dWRHVnVkRjl5YjNWMFpVQTFJRzFoYVc1ZmRtVnlhV1o1WDJOdmJuUmxiblJmY205MWRHVkFOaUJ0WVdsdVgyWnNZV2RmYldsemRYTmxYM0p2ZFhSbFFEY2diV0ZwYmw5blpYUmZabXhoWjE5eWIzVjBaVUE0Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdZMnhoYzNNZ1IyVnVUV0Z5YXloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmWm14aFoxOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk16VXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlc1dFlYSnJMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCamJHRnpjeUJIWlc1TllYSnJLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWdWJXRnlheTlqYjI1MGNtRmpkQzV3ZVRvek5UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdaMlYwWDJac1lXY0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpteGhaMTl0YVhOMWMyVmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpXNXRZWEpyTDJOdmJuUnlZV04wTG5CNU9qSTVNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aVzV0WVhKckwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJqYkdGemN5QkhaVzVOWVhKcktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpXNXRZWEpyTDJOdmJuUnlZV04wTG5CNU9qSTVNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHWnNZV2RmYldsemRYTmxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzWmxjbWxtZVY5amIyNTBaVzUwWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG95TXpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxibTFoY21zdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJR05zWVhOeklFZGxiazFoY21zb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aVzV0WVhKckwyTnZiblJ5WVdOMExuQjVPakl6TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCMlpYSnBabmxmWTI5dWRHVnVkQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVm5hWE4wWlhKZlkyOXVkR1Z1ZEY5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk9EQUtJQ0FnSUM4dklHTnNZWE56SUVkbGJrMWhjbXNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnY21WbmFYTjBaWEpmWTI5dWRHVnVkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlc1dFlYSnJMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCamJHRnpjeUJIWlc1TllYSnJLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1blpXNXRZWEpyTG1OdmJuUnlZV04wTGtkbGJrMWhjbXN1Y21WbmFYTjBaWEpmWTI5dWRHVnVkQ2h3YUdGemFEb2dZbmwwWlhNc0lHTnlaV0YwYjNKZmJtRnRaVG9nWW5sMFpYTXNJSEJzWVhSbWIzSnRPaUJpZVhSbGN5d2diM0pwWjJsdVlXeGZjR2hoYzJnNklHSjVkR1Z6TENCdGIzSndhR1ZrWDJKNU9pQmllWFJsY3l3Z2NHRjVYM1I0YmpvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2NtVm5hWE4wWlhKZlkyOXVkR1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlc1dFlYSnJMMk52Ym5SeVlXTjBMbkI1T2pFek15MHhORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlISmxaMmx6ZEdWeVgyTnZiblJsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQndhR0Z6YURvZ1lYSmpOQzVUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUnZjbDl1WVcxbE9pQmhjbU0wTGxOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2JHRjBabTl5YlRvZ1lYSmpOQzVUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnYjNKcFoybHVZV3hmY0doaGMyZzZJR0Z5WXpRdVUzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHMXZjbkJvWldSZlluazZJR0Z5WXpRdVUzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIQmhlVjkwZUc0NklHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1TEFvZ0lDQWdMeThnS1NBdFBpQmhjbU0wTGxWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURZZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk1UY3pMVEUzTkFvZ0lDQWdMeThnSXlEaWxJRGlsSUFnVm1Gc2FXUmhkR1VnY0dGNWJXVnVkQ0IwYnlCamIzWmxjaUJ2YmkxamFHRnBiaUJ6ZEc5eVlXZGxJR052YzNSeklPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ0FvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVY5MGVHNHVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnS0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG94TnpNdE1UYzJDaUFnSUNBdkx5QWpJT0tVZ09LVWdDQldZV3hwWkdGMFpTQndZWGx0Wlc1MElIUnZJR052ZG1WeUlHOXVMV05vWVdsdUlITjBiM0poWjJVZ1kyOXpkSE1nNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0FDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVYM1I0Ymk1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQW9DaUFnSUNBdkx5QWdJQ0FnSWxCaGVXMWxiblFnYlhWemRDQmlaU0JrYVhKbFkzUmxaQ0IwYnlCMGFHVWdSMlZ1VFdGeWF5QmpiMjUwY21GamRDQjBieUJtZFc1a0lHSnZlQ0J6ZEc5eVlXZGxJZ29nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCa2FYSmxZM1JsWkNCMGJ5QjBhR1VnUjJWdVRXRnlheUJqYjI1MGNtRmpkQ0IwYnlCbWRXNWtJR0p2ZUNCemRHOXlZV2RsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG94TnpjS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsZmRIaHVMbUZ0YjNWdWRDQStQU0JWU1c1ME5qUW9NakF3WHpBd01Da3NJQ2dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCd2RYTm9hVzUwSURJd01EQXdNQ0F2THlBeU1EQXdNREFLSUNBZ0lENDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUb3hOemN0TVRjNUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNVgzUjRiaTVoYlc5MWJuUWdQajBnVlVsdWREWTBLREl3TUY4d01EQXBMQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lrMXBibWx0ZFcwZ01DNHlJRUZNUjA4Z0tESXdNQ3d3TURBZ2JXbGpjbTlCYkdkdmN5a2djbVZ4ZFdseVpXUWdabTl5SUdKdmVDQk5RbElnS3lCQlUwRWdZM0psWVhScGIyNGlDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1RXbHVhVzExYlNBd0xqSWdRVXhIVHlBb01qQXdMREF3TUNCdGFXTnliMEZzWjI5ektTQnlaWEYxYVhKbFpDQm1iM0lnWW05NElFMUNVaUFySUVGVFFTQmpjbVZoZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk1UZ3hMVEU0TkFvZ0lDQWdMeThnSXlEaWxJRGlsSUFnVUhKbGRtVnVkQ0JrZFhCc2FXTmhkR1VnY21WbmFYTjBjbUYwYVc5dWN5QW9ZbUZqYTJSaGRHbHVaeUJoZEhSaFkyc2diV2wwYVdkaGRHbHZiaWtnNHBTQTRwU0E0cFNBQ2lBZ0lDQXZMeUFqSUVWaFkyZ2djR1Z5WTJWd2RIVmhiQ0JvWVhOb0lHTmhiaUJ2Ym14NUlHSmxJSEpsWjJsemRHVnlaV1FnYjI1alpTNGdRVzU1SUdGMGRHVnRjSFFnZEc4Z2NtVm5hWE4wWlhJS0lDQWdJQzh2SUNNZ2RHaGxJSE5oYldVZ1ptbHVaMlZ5Y0hKcGJuUWdkSGRwWTJVZ2FYTWdjbVZxWldOMFpXUXNJR1Z1YzNWeWFXNW5JSFJsYlhCdmNtRnNJR2x1ZEdWbmNtbDBlUzRLSUNBZ0lDOHZJR0Z6YzJWeWRDQndhR0Z6YUNCdWIzUWdhVzRnYzJWc1ppNXlaV2RwYzNSeWVTd2dLQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRGN5TmpVMk56Vm1DaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aVzV0WVhKckwyTnZiblJ5WVdOMExuQjVPakU0TVMweE9EWUtJQ0FnSUM4dklDTWc0cFNBNHBTQUlGQnlaWFpsYm5RZ1pIVndiR2xqWVhSbElISmxaMmx6ZEhKaGRHbHZibk1nS0dKaFkydGtZWFJwYm1jZ1lYUjBZV05ySUcxcGRHbG5ZWFJwYjI0cElPS1VnT0tVZ09LVWdBb2dJQ0FnTHk4Z0l5QkZZV05vSUhCbGNtTmxjSFIxWVd3Z2FHRnphQ0JqWVc0Z2IyNXNlU0JpWlNCeVpXZHBjM1JsY21Wa0lHOXVZMlV1SUVGdWVTQmhkSFJsYlhCMElIUnZJSEpsWjJsemRHVnlDaUFnSUNBdkx5QWpJSFJvWlNCellXMWxJR1pwYm1kbGNuQnlhVzUwSUhSM2FXTmxJR2x6SUhKbGFtVmpkR1ZrTENCbGJuTjFjbWx1WnlCMFpXMXdiM0poYkNCcGJuUmxaM0pwZEhrdUNpQWdJQ0F2THlCaGMzTmxjblFnY0doaGMyZ2dibTkwSUdsdUlITmxiR1l1Y21WbmFYTjBjbmtzSUNnS0lDQWdJQzh2SUNBZ0lDQWlWR2hwY3lCamIyNTBaVzUwSUdacGJtZGxjbkJ5YVc1MElHaGhjeUJoYkhKbFlXUjVJR0psWlc0Z2NtVm5hWE4wWlhKbFpDQnZiaUJIWlc1TllYSnJJZ29nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowSUM4dklGUm9hWE1nWTI5dWRHVnVkQ0JtYVc1blpYSndjbWx1ZENCb1lYTWdZV3h5WldGa2VTQmlaV1Z1SUhKbFoybHpkR1Z5WldRZ2IyNGdSMlZ1VFdGeWF3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk1UZzRMVEl4TUFvZ0lDQWdMeThnSXlEaWxJRGlsSUFnVFdsdWRDQnpiM1ZzWW05MWJtUWdiM2R1WlhKemFHbHdJR055WldSbGJuUnBZV3dnUVZOQklPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdBb2dJQ0FnTHk4Z0l5QkJiaUJwYm01bGNpQjBjbUZ1YzJGamRHbHZiaUJqY21WaGRHVnpJR0VnYm05dUxYUnlZVzV6Wm1WeVlXSnNaU0JCVTBFZ1ltOTFibVFnZEc4Z2RHaHBjeUJqYjI1MFpXNTBMZ29nSUNBZ0x5OGdJeUJVYUdVZ1FWTkJJRWxFSUhObGNuWmxjeUJoY3lCMGFHVWdZMlZ5ZEdsbWFXTmhkR1VnYm5WdFltVnlJR2x1SUdadmNtVnVjMmxqSUdSdlkzVnRaVzUwWVhScGIyNHVDaUFnSUNBdkx5QWpDaUFnSUNBdkx5QWpJRmRvZVNCemIzVnNZbTkxYm1RL0lGUm9aU0JqYjIxaWFXNWhkR2x2YmlCdlppQmtaV1poZFd4MFgyWnliM3BsYmoxVWNuVmxJR0Z1WkNCaGMzTnBaMjVwYm1jZ1lXeHNDaUFnSUNBdkx5QWpJRzFoYm1GblpXMWxiblFnY205c1pYTWdkRzhnZEdobElHTnZiblJ5WVdOMElHMWxZVzV6SUc1dklHVjRkR1Z5Ym1Gc0lIQmhjblI1SUdOaGJpQjBjbUZ1YzJabGNpd0tJQ0FnSUM4dklDTWdiVzlrYVdaNUxDQnZjaUJrWlhOMGNtOTVJSFJvYVhNZ1FWTkJJT0tBbENCdmJteDVJSFJvWlNCamIyNTBjbUZqZENCb1lYTWdZWFYwYUc5eWFYUjVMZ29nSUNBZ0x5OGdZWE56WlhSZmNtVnpkV3gwSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQweExDQWdJeUJPYjI0dFpuVnVaMmxpYkdVNklHVjRZV04wYkhrZ2IyNWxJSFZ1YVhRZ1pYaHBjM1J6SUdsdUlIUm9aU0IxYm1sMlpYSnpaUW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRBc0lDQWpJRWx1WkdsMmFYTnBZbXhsT2lCdWJ5Qm1jbUZqZEdsdmJtRnNJRzkzYm1WeWMyaHBjQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJmWm5KdmVtVnVQVlJ5ZFdVc0lDQWpJRkpsWTJsd2FXVnVkSE1nWVhKbElHWnliM3BsYmlEaWdKUWdZMkZ1Ym05MElIUnlZVzV6WVdOMENpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDFpSWtkbGJrMWhjbXNnUTJWeWRHbG1hV05oZEdVaUxDQWdJeUJJZFcxaGJpMXlaV0ZrWVdKc1pTQnVZVzFsQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBXSWlSMDFESWl3Z0lDTWdWR2xqYTJWeUlITjViV0p2YkNCbWIzSWdkMkZzYkdWMEwyVjRjR3h2Y21WeUlHUnBjM0JzWVhrS0lDQWdJQzh2SUNBZ0lDQjFjbXc5WWlKb2RIUndjem92TDJkbGJtMWhjbXN1WVhCd0lpd2dJQ01nVW1WbVpYSmxibU5sSUZWU1RDQm1iM0lnWVdSa2FYUnBiMjVoYkNCdFpYUmhaR0YwWVFvZ0lDQWdMeThnSUNBZ0lDTWdRWE56YVdkdWFXNW5JR0ZzYkNCamIyNTBjbTlzSUhKdmJHVnpJSFJ2SUhSb1pTQmpiMjUwY21GamRDQnRZV3RsY3lCMGFHbHpJRUZUUVNCemIzVnNZbTkxYm1RNkNpQWdJQ0F2THlBZ0lDQWdJeUJ1YnlCbGVIUmxjbTVoYkNCM1lXeHNaWFFnWTJGdUlHMWhibUZuWlN3Z1puSmxaWHBsTENCdmNpQmpiR0YzWW1GamF5QjBhR2x6SUdGemMyVjBDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ0l5Qm1aV1U5TUNCdFpXRnVjeUIwYUdseklHWmxaU0JwY3lCd2IyOXNaV1FnWm5KdmJTQjBhR1VnYjNWMFpYSWdkSEpoYm5OaFkzUnBiMjR1Q2lBZ0lDQXZMeUFnSUNBZ0l5QkRZV3hzWlhKeklHMTFjM1FnYzJWMElHOTFkR1Z5WDNSNGJpNW1aV1VnUFNBeUlDb2diV2x1WDJabFpTQjBieUJqYjNabGNpQjBhR2x6SUdsdWJtVnlJSFI0Ymk0S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aVzV0WVhKckwyTnZiblJ5WVdOMExuQjVPakl3TWkweU1EUUtJQ0FnSUM4dklDTWdRWE56YVdkdWFXNW5JR0ZzYkNCamIyNTBjbTlzSUhKdmJHVnpJSFJ2SUhSb1pTQmpiMjUwY21GamRDQnRZV3RsY3lCMGFHbHpJRUZUUVNCemIzVnNZbTkxYm1RNkNpQWdJQ0F2THlBaklHNXZJR1Y0ZEdWeWJtRnNJSGRoYkd4bGRDQmpZVzRnYldGdVlXZGxMQ0JtY21WbGVtVXNJRzl5SUdOc1lYZGlZV05ySUhSb2FYTWdZWE56WlhRS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG95TURVdE1qQTJDaUFnSUNBdkx5Qm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRGJHRjNZbUZqYXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVaeVpXVjZaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTFoYm1GblpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpXNXRZWEpyTDJOdmJuUnlZV04wTG5CNU9qSXdNUW9nSUNBZ0x5OGdkWEpzUFdJaWFIUjBjSE02THk5blpXNXRZWEpyTG1Gd2NDSXNJQ0FqSUZKbFptVnlaVzVqWlNCVlVrd2dabTl5SUdGa1pHbDBhVzl1WVd3Z2JXVjBZV1JoZEdFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZNE56UTNORGN3TnpNellUSm1NbVkyTnpZMU5tVTJaRFl4TnpJMllqSmxOakUzTURjd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZWSk1DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUb3lNREFLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDFpSWtkTlF5SXNJQ0FqSUZScFkydGxjaUJ6ZVcxaWIyd2dabTl5SUhkaGJHeGxkQzlsZUhCc2IzSmxjaUJrYVhOd2JHRjVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBOelJrTkRNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVmJtbDBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNUNpQWdJQ0F2THlCaGMzTmxkRjl1WVcxbFBXSWlSMlZ1VFdGeWF5QkRaWEowYVdacFkyRjBaU0lzSUNBaklFaDFiV0Z1TFhKbFlXUmhZbXhsSUc1aGJXVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTNOalUyWlRSa05qRTNNalppTWpBME16WTFOekkzTkRZNU5qWTJPVFl6TmpFM05EWTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCa1pXWmhkV3gwWDJaeWIzcGxiajFVY25WbExDQWdJeUJTWldOcGNHbGxiblJ6SUdGeVpTQm1jbTk2Wlc0ZzRvQ1VJR05oYm01dmRDQjBjbUZ1YzJGamRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXWmhkV3gwUm5KdmVtVnVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUb3hPVGNLSUNBZ0lDOHZJR1JsWTJsdFlXeHpQVEFzSUNBaklFbHVaR2wyYVhOcFlteGxPaUJ1YnlCbWNtRmpkR2x2Ym1Gc0lHOTNibVZ5YzJocGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCMGIzUmhiRDB4TENBZ0l5Qk9iMjR0Wm5WdVoybGliR1U2SUdWNFlXTjBiSGtnYjI1bElIVnVhWFFnWlhocGMzUnpJR2x1SUhSb1pTQjFibWwyWlhKelpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxibTFoY21zdlkyOXVkSEpoWTNRdWNIazZNVGc0TFRFNU5Rb2dJQ0FnTHk4Z0l5RGlsSURpbElBZ1RXbHVkQ0J6YjNWc1ltOTFibVFnYjNkdVpYSnphR2x3SUdOeVpXUmxiblJwWVd3Z1FWTkJJT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnQW9nSUNBZ0x5OGdJeUJCYmlCcGJtNWxjaUIwY21GdWMyRmpkR2x2YmlCamNtVmhkR1Z6SUdFZ2JtOXVMWFJ5WVc1elptVnlZV0pzWlNCQlUwRWdZbTkxYm1RZ2RHOGdkR2hwY3lCamIyNTBaVzUwTGdvZ0lDQWdMeThnSXlCVWFHVWdRVk5CSUVsRUlITmxjblpsY3lCaGN5QjBhR1VnWTJWeWRHbG1hV05oZEdVZ2JuVnRZbVZ5SUdsdUlHWnZjbVZ1YzJsaklHUnZZM1Z0Wlc1MFlYUnBiMjR1Q2lBZ0lDQXZMeUFqQ2lBZ0lDQXZMeUFqSUZkb2VTQnpiM1ZzWW05MWJtUS9JRlJvWlNCamIyMWlhVzVoZEdsdmJpQnZaaUJrWldaaGRXeDBYMlp5YjNwbGJqMVVjblZsSUdGdVpDQmhjM05wWjI1cGJtY2dZV3hzQ2lBZ0lDQXZMeUFqSUcxaGJtRm5aVzFsYm5RZ2NtOXNaWE1nZEc4Z2RHaGxJR052Ym5SeVlXTjBJRzFsWVc1eklHNXZJR1Y0ZEdWeWJtRnNJSEJoY25SNUlHTmhiaUIwY21GdWMyWmxjaXdLSUNBZ0lDOHZJQ01nYlc5a2FXWjVMQ0J2Y2lCa1pYTjBjbTk1SUhSb2FYTWdRVk5CSU9LQWxDQnZibXg1SUhSb1pTQmpiMjUwY21GamRDQm9ZWE1nWVhWMGFHOXlhWFI1TGdvZ0lDQWdMeThnWVhOelpYUmZjbVZ6ZFd4MElEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUhCMWMyaHBiblFnTXlBdkx5QmhZMlpuQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUb3lNRGN0TWpBNUNpQWdJQ0F2THlBaklHWmxaVDB3SUcxbFlXNXpJSFJvYVhNZ1ptVmxJR2x6SUhCdmIyeGxaQ0JtY205dElIUm9aU0J2ZFhSbGNpQjBjbUZ1YzJGamRHbHZiaTRLSUNBZ0lDOHZJQ01nUTJGc2JHVnljeUJ0ZFhOMElITmxkQ0J2ZFhSbGNsOTBlRzR1Wm1WbElEMGdNaUFxSUcxcGJsOW1aV1VnZEc4Z1kyOTJaWElnZEdocGN5QnBibTVsY2lCMGVHNHVDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TVRnNExUSXhNQW9nSUNBZ0x5OGdJeURpbElEaWxJQWdUV2x1ZENCemIzVnNZbTkxYm1RZ2IzZHVaWEp6YUdsd0lHTnlaV1JsYm5ScFlXd2dRVk5CSU9LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ0FvZ0lDQWdMeThnSXlCQmJpQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJpQmpjbVZoZEdWeklHRWdibTl1TFhSeVlXNXpabVZ5WVdKc1pTQkJVMEVnWW05MWJtUWdkRzhnZEdocGN5QmpiMjUwWlc1MExnb2dJQ0FnTHk4Z0l5QlVhR1VnUVZOQklFbEVJSE5sY25abGN5QmhjeUIwYUdVZ1kyVnlkR2xtYVdOaGRHVWdiblZ0WW1WeUlHbHVJR1p2Y21WdWMybGpJR1J2WTNWdFpXNTBZWFJwYjI0dUNpQWdJQ0F2THlBakNpQWdJQ0F2THlBaklGZG9lU0J6YjNWc1ltOTFibVEvSUZSb1pTQmpiMjFpYVc1aGRHbHZiaUJ2WmlCa1pXWmhkV3gwWDJaeWIzcGxiajFVY25WbElHRnVaQ0JoYzNOcFoyNXBibWNnWVd4c0NpQWdJQ0F2THlBaklHMWhibUZuWlcxbGJuUWdjbTlzWlhNZ2RHOGdkR2hsSUdOdmJuUnlZV04wSUcxbFlXNXpJRzV2SUdWNGRHVnlibUZzSUhCaGNuUjVJR05oYmlCMGNtRnVjMlpsY2l3S0lDQWdJQzh2SUNNZ2JXOWthV1o1TENCdmNpQmtaWE4wY205NUlIUm9hWE1nUVZOQklPS0FsQ0J2Ym14NUlIUm9aU0JqYjI1MGNtRmpkQ0JvWVhNZ1lYVjBhRzl5YVhSNUxnb2dJQ0FnTHk4Z1lYTnpaWFJmY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TENBZ0l5Qk9iMjR0Wm5WdVoybGliR1U2SUdWNFlXTjBiSGtnYjI1bElIVnVhWFFnWlhocGMzUnpJR2x1SUhSb1pTQjFibWwyWlhKelpRb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVEFzSUNBaklFbHVaR2wyYVhOcFlteGxPaUJ1YnlCbWNtRmpkR2x2Ym1Gc0lHOTNibVZ5YzJocGNBb2dJQ0FnTHk4Z0lDQWdJR1JsWm1GMWJIUmZabkp2ZW1WdVBWUnlkV1VzSUNBaklGSmxZMmx3YVdWdWRITWdZWEpsSUdaeWIzcGxiaURpZ0pRZ1kyRnVibTkwSUhSeVlXNXpZV04wQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMWlJa2RsYmsxaGNtc2dRMlZ5ZEdsbWFXTmhkR1VpTENBZ0l5QklkVzFoYmkxeVpXRmtZV0pzWlNCdVlXMWxDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdJaVIwMURJaXdnSUNNZ1ZHbGphMlZ5SUhONWJXSnZiQ0JtYjNJZ2QyRnNiR1YwTDJWNGNHeHZjbVZ5SUdScGMzQnNZWGtLSUNBZ0lDOHZJQ0FnSUNCMWNtdzlZaUpvZEhSd2N6b3ZMMmRsYm0xaGNtc3VZWEJ3SWl3Z0lDTWdVbVZtWlhKbGJtTmxJRlZTVENCbWIzSWdZV1JrYVhScGIyNWhiQ0J0WlhSaFpHRjBZUW9nSUNBZ0x5OGdJQ0FnSUNNZ1FYTnphV2R1YVc1bklHRnNiQ0JqYjI1MGNtOXNJSEp2YkdWeklIUnZJSFJvWlNCamIyNTBjbUZqZENCdFlXdGxjeUIwYUdseklFRlRRU0J6YjNWc1ltOTFibVE2Q2lBZ0lDQXZMeUFnSUNBZ0l5QnVieUJsZUhSbGNtNWhiQ0IzWVd4c1pYUWdZMkZ1SUcxaGJtRm5aU3dnWm5KbFpYcGxMQ0J2Y2lCamJHRjNZbUZqYXlCMGFHbHpJR0Z6YzJWMENpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSXlCbVpXVTlNQ0J0WldGdWN5QjBhR2x6SUdabFpTQnBjeUJ3YjI5c1pXUWdabkp2YlNCMGFHVWdiM1YwWlhJZ2RISmhibk5oWTNScGIyNHVDaUFnSUNBdkx5QWdJQ0FnSXlCRFlXeHNaWEp6SUcxMWMzUWdjMlYwSUc5MWRHVnlYM1I0Ymk1bVpXVWdQU0F5SUNvZ2JXbHVYMlpsWlNCMGJ5QmpiM1psY2lCMGFHbHpJR2x1Ym1WeUlIUjRiaTRLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWdWJXRnlheTlqYjI1MGNtRmpkQzV3ZVRveU1Ua0tJQ0FnSUM4dklHTnlaV0YwYjNKZllXUmtjbVZ6Y3oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUb3lNakVLSUNBZ0lDOHZJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG95TWpJS0lDQWdJQzh2SUdGellWOXBaRDFoY21NMExsVkpiblEyTkNoaGMzTmxkRjlwWkNrc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aVzV0WVhKckwyTnZiblJ5WVdOMExuQjVPakl4TkMweU1qWUtJQ0FnSUM4dklDTWc0cFNBNHBTQUlGZHlhWFJsSUhCbGNtMWhibVZ1ZENCeVpXZHBjM1J5WVhScGIyNGdjbVZqYjNKa0lIUnZJR0p2ZUNCemRHOXlZV2RsSU9LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdBb2dJQ0FnTHk4Z0l5QkNiM2dnYTJWNUlEMGdZaUp5WldkZklpQXJJR0Z5WXpSZlpXNWpiMlJsS0hCb1lYTm9LUW9nSUNBZ0x5OGdJeUJVYUdseklHTnlaV0YwWlhNZ1lXNGdhVzF0ZFhSaFlteGxJRzl1TFdOb1lXbHVJSEpsWTI5eVpDQjBhR0YwSUdGdWVXOXVaU0JqWVc0Z2NYVmxjbmtnWm05eVpYWmxjaTRLSUNBZ0lDOHZJSE5sYkdZdWNtVm5hWE4wY25sYmNHaGhjMmhkSUQwZ1EyOXVkR1Z1ZEZKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkRzl5WDI1aGJXVTlZM0psWVhSdmNsOXVZVzFsTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwYjNKZllXUmtjbVZ6Y3oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ2NHeGhkR1p2Y20wOWNHeGhkR1p2Y20wc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMyRmZhV1E5WVhKak5DNVZTVzUwTmpRb1lYTnpaWFJmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR1pzWVdkZlkyOTFiblE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYjNKcFoybHVZV3hmY0doaGMyZzliM0pwWjJsdVlXeGZjR2hoYzJnc0lDQWpJRVZ0Y0hSNUlITjBjbWx1WnlCbWIzSWdiM0pwWjJsdVlXd2dZMjl1ZEdWdWRBb2dJQ0FnTHk4Z0lDQWdJRzF2Y25Cb1pXUmZZbms5Ylc5eWNHaGxaRjlpZVN3Z0lDQWdJQ0FnSUNBZ0l5QkZiWEIwZVNCemRISnBibWNnWm05eUlHOXlhV2RwYm1Gc0lHTnZiblJsYm5RS0lDQWdJQzh2SUNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBJQzh2SURZMENpQWdJQ0FyQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURRd0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWdWJXRnlheTlqYjI1MGNtRmpkQzV3ZVRveU1qTUtJQ0FnSUM4dklHWnNZV2RmWTI5MWJuUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG95TVRRdE1qSTJDaUFnSUNBdkx5QWpJT0tVZ09LVWdDQlhjbWwwWlNCd1pYSnRZVzVsYm5RZ2NtVm5hWE4wY21GMGFXOXVJSEpsWTI5eVpDQjBieUJpYjNnZ2MzUnZjbUZuWlNEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJQUtJQ0FnSUM4dklDTWdRbTk0SUd0bGVTQTlJR0lpY21Wblh5SWdLeUJoY21NMFgyVnVZMjlrWlNod2FHRnphQ2tLSUNBZ0lDOHZJQ01nVkdocGN5QmpjbVZoZEdWeklHRnVJR2x0YlhWMFlXSnNaU0J2YmkxamFHRnBiaUJ5WldOdmNtUWdkR2hoZENCaGJubHZibVVnWTJGdUlIRjFaWEo1SUdadmNtVjJaWEl1Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxaMmx6ZEhKNVczQm9ZWE5vWFNBOUlFTnZiblJsYm5SU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJ2Y2w5dVlXMWxQV055WldGMGIzSmZibUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEc5eVgyRmtaSEpsYzNNOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lIQnNZWFJtYjNKdFBYQnNZWFJtYjNKdExBb2dJQ0FnTHk4Z0lDQWdJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTmhYMmxrUFdGeVl6UXVWVWx1ZERZMEtHRnpjMlYwWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0JtYkdGblgyTnZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUc5eWFXZHBibUZzWDNCb1lYTm9QVzl5YVdkcGJtRnNYM0JvWVhOb0xDQWdJeUJGYlhCMGVTQnpkSEpwYm1jZ1ptOXlJRzl5YVdkcGJtRnNJR052Ym5SbGJuUUtJQ0FnSUM4dklDQWdJQ0J0YjNKd2FHVmtYMko1UFcxdmNuQm9aV1JmWW5rc0lDQWdJQ0FnSUNBZ0lDTWdSVzF3ZEhrZ2MzUnlhVzVuSUdadmNpQnZjbWxuYVc1aGJDQmpiMjUwWlc1MENpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWdWJXRnlheTlqYjI1MGNtRmpkQzV3ZVRveU1qZ3RNakk1Q2lBZ0lDQXZMeUFqSU9LVWdPS1VnQ0JKYm1OeVpXMWxiblFnWjJ4dlltRnNJSEpsWjJsemRISmhkR2x2YmlCamIzVnVkR1Z5SU9LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl5WldkcGMzUnlZWFJwYjI1eklDczlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDNKbFoybHpkSEpoZEdsdmJuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjbVZuYVhOMGNtRjBhVzl1Y3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl5WldkcGMzUnlZWFJwYjI1eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5blpXNXRZWEpyTDJOdmJuUnlZV04wTG5CNU9qSXpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLR0Z6YzJWMFgybGtLUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtZGxibTFoY21zdVkyOXVkSEpoWTNRdVIyVnVUV0Z5YXk1MlpYSnBabmxmWTI5dWRHVnVkQ2h3YUdGemFEb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS2RtVnlhV1o1WDJOdmJuUmxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG95TXpjdE1qUXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdkbVZ5YVdaNVgyTnZiblJsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQndhR0Z6YURvZ1lYSmpOQzVUZEhKcGJtY3NDaUFnSUNBdkx5QXBJQzArSUhSMWNHeGxXMkZ5WXpRdVFtOXZiQ3dnUTI5dWRHVnVkRkpsWTI5eVpGMDZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlc1dFlYSnJMMk52Ym5SeVlXTjBMbkI1T2pJMk9Rb2dJQ0FnTHk4Z2FXWWdjR2hoYzJnZ2FXNGdjMlZzWmk1eVpXZHBjM1J5ZVRvS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01qWTFOamMxWmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQjJaWEpwWm5sZlkyOXVkR1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aVzV0WVhKckwyTnZiblJ5WVdOMExuQjVPakkzTUMweU56RUtJQ0FnSUM4dklDTWc0cFNBNHBTQUlFTnZiblJsYm5RZ1ptOTFibVE2SUhKbGRIVnliaUJtZFd4c0lIQnliM1psYm1GdVkyVWdjbVZqYjNKa0lPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaFVjblZsS1N3Z2MyVnNaaTV5WldkcGMzUnllVnR3YUdGemFGMHVZMjl3ZVNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVm5hWE4wY25rZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhSemRXSUtDblpsY21sbWVWOWpiMjUwWlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlc1dFlYSnJMMk52Ym5SeVlXTjBMbkI1T2pJM015MHlPRFVLSUNBZ0lDOHZJQ01nNHBTQTRwU0FJRU52Ym5SbGJuUWdibTkwSUdadmRXNWtPaUJ5WlhSMWNtNGdjMlZ1ZEdsdVpXd2daVzF3ZEhrZ2NtVmpiM0prSU9LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdBb2dJQ0FnTHk4Z0l5QlVhR1VnWTJGc2JHVnlJSE5vYjNWc1pDQmphR1ZqYXlCMGFHVWdRbTl2YkNCbWJHRm5JR0psWm05eVpTQjFjMmx1WnlCMGFHVWdjbVZqYjNKa0lHWnBaV3hrY3k0S0lDQWdJQzh2SUNNZ1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5QnBjeUIwYUdVZ016SXRZbmwwWlNCNlpYSnZJR0ZrWkhKbGMzTWdkWE5sWkNCaGN5QmhJRzUxYkd3Z2NHeGhZMlZvYjJ4a1pYSXVDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1N3Z1EyOXVkR1Z1ZEZKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkRzl5WDI1aGJXVTlZWEpqTkM1VGRISnBibWNvSWlJcExBb2dJQ0FnTHk4Z0lDQWdJR055WldGMGIzSmZZV1JrY21WemN6MWhjbU0wTGtGa1pISmxjM01vUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlBZ0lDQWdjR3hoZEdadmNtMDlZWEpqTkM1VGRISnBibWNvSWlJcExBb2dJQ0FnTHk4Z0lDQWdJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzJGZmFXUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdabXhoWjE5amIzVnVkRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J2Y21sbmFXNWhiRjl3YUdGemFEMWhjbU0wTGxOMGNtbHVaeWdpSWlrc0NpQWdJQ0F2THlBZ0lDQWdiVzl5Y0dobFpGOWllVDFoY21NMExsTjBjbWx1WnlnaUlpa3NDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNREFnWW1GelpUTXlLRUZDUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCU1VsQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkNRMEZCVWxGQlFVRkJRVUZCUVVGQlFVRkJLU0F2THlBd2VEQXdMQ0JpWVhObE16SW9RVUpCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZKU1VGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVSkRRVUZTVVVGQlFVRkJRVUZCUVVGQlFVRXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVuWlc1dFlYSnJMbU52Ym5SeVlXTjBMa2RsYmsxaGNtc3VabXhoWjE5dGFYTjFjMlVvY0doaGMyZzZJR0o1ZEdWekxDQmtaWE5qY21sd2RHbHZiam9nWW5sMFpYTXNJSEJoZVY5MGVHNDZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbVpzWVdkZmJXbHpkWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TWpreExUSTVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ1pteGhaMTl0YVhOMWMyVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J3YUdGemFEb2dZWEpqTkM1VGRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1pHVnpZM0pwY0hScGIyNDZJR0Z5WXpRdVUzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIQmhlVjkwZUc0NklHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1TEFvZ0lDQWdMeThnS1NBdFBpQmhjbU0wTGxWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk16SXpMVE15TkFvZ0lDQWdMeThnSXlEaWxJRGlsSUFnVm1WeWFXWjVJSFJvWlNCamIyNTBaVzUwSUdWNGFYTjBjeUJpWldadmNtVWdZV3hzYjNkcGJtY2dabXhoWjJkcGJtY2c0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR2hoYzJnZ2FXNGdjMlZzWmk1eVpXZHBjM1J5ZVN3Z0lrTmhibTV2ZENCbWFXeGxJR0VnYldsemRYTmxJSEpsY0c5eWREb2dZMjl1ZEdWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNCdmJpQkhaVzVOWVhKcklnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEY3lOalUyTnpWbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRZVzV1YjNRZ1ptbHNaU0JoSUcxcGMzVnpaU0J5WlhCdmNuUTZJR052Ym5SbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRZ2IyNGdSMlZ1VFdGeWF3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk16STJMVE15TndvZ0lDQWdMeThnSXlEaWxJRGlsSUFnVm1Gc2FXUmhkR1VnY0dGNWJXVnVkQ0JtYjNJZ1pteGhaeUJpYjNnZ2MzUnZjbUZuWlNCamIzTjBjeURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJQUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbGZkSGh1TG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk16STJMVE15T1FvZ0lDQWdMeThnSXlEaWxJRGlsSUFnVm1Gc2FXUmhkR1VnY0dGNWJXVnVkQ0JtYjNJZ1pteGhaeUJpYjNnZ2MzUnZjbUZuWlNCamIzTjBjeURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJQUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbGZkSGh1TG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDZ0tJQ0FnSUM4dklDQWdJQ0FpVUdGNWJXVnVkQ0J0ZFhOMElHSmxJR1JwY21WamRHVmtJSFJ2SUhSb1pTQkhaVzVOWVhKcklHTnZiblJ5WVdOMElnb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQmlaU0JrYVhKbFkzUmxaQ0IwYnlCMGFHVWdSMlZ1VFdGeWF5QmpiMjUwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbGJtMWhjbXN2WTI5dWRISmhZM1F1Y0hrNk16TXdDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVYM1I0Ymk1aGJXOTFiblFnUGowZ1ZVbHVkRFkwS0RVd1h6QXdNQ2tzSUNnS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQndkWE5vYVc1MElEVXdNREF3SUM4dklEVXdNREF3Q2lBZ0lDQStQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZGxibTFoY21zdlkyOXVkSEpoWTNRdWNIazZNek13TFRNek1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVWOTBlRzR1WVcxdmRXNTBJRDQ5SUZWSmJuUTJOQ2cxTUY4d01EQXBMQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lrMXBibWx0ZFcwZ01DNHdOU0JCVEVkUElDZzFNQ3d3TURBZ2JXbGpjbTlCYkdkdmN5a2djbVZ4ZFdseVpXUWdabTl5SUdac1lXY2dZbTk0SUhOMGIzSmhaMlVpQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjM05sY25RZ0x5OGdUV2x1YVcxMWJTQXdMakExSUVGTVIwOGdLRFV3TERBd01DQnRhV055YjBGc1oyOXpLU0J5WlhGMWFYSmxaQ0JtYjNJZ1pteGhaeUJpYjNnZ2MzUnZjbUZuWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TXpNMExUTXpOUW9nSUNBZ0x5OGdJeURpbElEaWxJQWdSR1YwWlhKdGFXNWxJSE5sY1hWbGJuUnBZV3dnWm14aFp5QnBibVJsZUNEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSURpbElEaWxJRGlsSUFLSUNBZ0lDOHZJR1pzWVdkZmFXNWtaWGdnUFNCelpXeG1MbkpsWjJsemRISjVXM0JvWVhOb1hTNW1iR0ZuWDJOdmRXNTBMbTVoZEdsMlpRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaV2RwYzNSeWVTQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ05USWdMeThnTlRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJWdWJXRnlheTlqYjI1MGNtRmpkQzV3ZVRvek16Y3RNek00Q2lBZ0lDQXZMeUFqSU9LVWdPS1VnQ0JUZEc5eVpTQm1iR0ZuSUdSbGMyTnlhWEIwYVc5dUlHbHVJR0VnWkdWa2FXTmhkR1ZrSUc1aGJXVnpjR0ZqWldRZ1ltOTRJT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdBb2dJQ0FnTHk4Z1pteGhaMTlpYjNoZmEyVjVJRDBnUW5sMFpYTW9ZaUptYkdkZklpa2dLeUJ3YUdGemFDNWllWFJsY3lBcklHOXdMbWwwYjJJb1pteGhaMTlwYm1SbGVDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzJOalpqTmpjMVpnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG96TXprS0lDQWdJQzh2SUc5d0xrSnZlQzV3ZFhRb1pteGhaMTlpYjNoZmEyVjVMQ0JrWlhOamNtbHdkR2x2Ymk1aWVYUmxjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRsYm0xaGNtc3ZZMjl1ZEhKaFkzUXVjSGs2TXpReExUTTBNZ29nSUNBZ0x5OGdJeURpbElEaWxJQWdTVzVqY21WdFpXNTBJR1pzWVdjZ1kyOTFiblFnYVc0Z2RHaGxJSEpsWjJsemRISmhkR2x2YmlCeVpXTnZjbVFnNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQUNpQWdJQ0F2THlCelpXeG1MbkpsWjJsemRISjVXM0JvWVhOb1hTNW1iR0ZuWDJOdmRXNTBJRDBnWVhKak5DNVZTVzUwTmpRb1pteGhaMTlwYm1SbGVDQXJJRlZKYm5RMk5DZ3hLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZuYVhOMGNua2daVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQTFNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG96TkRRS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNobWJHRm5YMmx1WkdWNEtRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1kbGJtMWhjbXN1WTI5dWRISmhZM1F1UjJWdVRXRnlheTVuWlhSZlpteGhaeWh3YUdGemFEb2dZbmwwWlhNc0lHWnNZV2RmYVc1a1pYZzZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwWDJac1lXYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUb3pOVEF0TXpVMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYMlpzWVdjb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQndhR0Z6YURvZ1lYSmpOQzVUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWm14aFoxOXBibVJsZURvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMlZ1YldGeWF5OWpiMjUwY21GamRDNXdlVG96TnpJS0lDQWdJQzh2SUdac1lXZGZZbTk0WDJ0bGVTQTlJRUo1ZEdWektHSWlabXhuWHlJcElDc2djR2hoYzJndVlubDBaWE1nS3lCdmNDNXBkRzlpS0dac1lXZGZhVzVrWlhndWJtRjBhWFpsS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURZMk5tTTJOelZtQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlc1dFlYSnJMMk52Ym5SeVlXTjBMbkI1T2pNM013b2dJQ0FnTHk4Z1pteGhaMTlpZVhSbGN5d2dabXhoWjE5bGVHbHpkSE1nUFNCdmNDNUNiM2d1WjJWMEtHWnNZV2RmWW05NFgydGxlU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWlc1dFlYSnJMMk52Ym5SeVlXTjBMbkI1T2pNM05Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdac1lXZGZaWGhwYzNSekxDQWlSbXhoWnlCdWIzUWdabTkxYm1RZ1lYUWdkR2hsSUhOd1pXTnBabWxsWkNCcGJtUmxlQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdiR0ZuSUc1dmRDQm1iM1Z1WkNCaGRDQjBhR1VnYzNCbFkybG1hV1ZrSUdsdVpHVjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyVnViV0Z5YXk5amIyNTBjbUZqZEM1d2VUb3pOelVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxOMGNtbHVaeTVtY205dFgySjVkR1Z6S0dac1lXZGZZbmwwWlhNcENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1CQVFWSDN4MUUzUnZkR0ZzWDNKbFoybHpkSEpoZEdsdmJuTUVjbVZuWHdSbWJHZGZNUmhBQUFNcEkyY3hHMEVBbjRJRUJIajNhVVVFZC9ZaXJBVHhvZnJoQkhVRC9KdzJHZ0NPQkFCVEFEZ0FHQUFDSTBNeEdSUkVNUmhFTmhvQk5ob0NpQUg2S0V4UXNDSkRNUmtVUkRFWVJEWWFBVFlhQWpFV0lnbEpPQkFpRWtTSUFaUW9URkN3SWtNeEdSUkVNUmhFTmhvQmlBRVlUSUFDQUFOUVRGQW9URkN3SWtNeEdSUkVNUmhFTmhvQk5ob0NOaG9ETmhvRU5ob0ZNUllpQ1VrNEVDSVNSSWdBRVNoTVVMQWlRekVaUVA5L01SZ1VSQ0pEaWdZQmkvODRCeklLRWtTTC96Z0lnY0NhREE5RUtvdjZVRW05UlFFVVJMRXlDa2NDc2l5eUs3SXBnQk5vZEhSd2N6b3ZMMmRsYm0xaGNtc3VZWEJ3c2llQUEwZE5RN0lsZ0JOSFpXNU5ZWEpySUVObGNuUnBabWxqWVhSbHNpWWlzaVFqc2lNaXNpS0JBN0lRSTdJQnM3UThNUUF5QnhaUEFoYUwreFdCUUFpQUFnQkFUd1JRU3dFV1Z3WUNVSXY4RlU4Q0NFeFBBMUJMQWxDQUNBQUFBQUFBQUFBQVVFc0JGbGNHQWxDTC9SVlBBZ2dXVndZQ1VJdjdVSXY4VUl2OVVJditVRXNDdkVoUEFreS9JeWxsUkNJSUtVeG5pWW9CQWlxTC8xQkp2VVVCUVFBTGl3QytSSUFCZ0V4UEFvbUNBZ0VBU0FCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJFQUVZQUFBQUFBQUFBQUU4Q2lZb0RBU3FML1ZCSnZVVUJSSXYvT0FjeUNoSkVpLzg0Q0lIUWhnTVBSRW0rUklFMFd5dUwvVkJMQVJaTVN3RlFpLzYvVENJSUZrc0N2a1JNWERSTEFyeElUd0pNdjRtS0FnRXJpLzVRaS84WEZsQytSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
