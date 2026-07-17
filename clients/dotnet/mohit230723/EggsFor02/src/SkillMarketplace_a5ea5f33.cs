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

namespace Arc56.Generated.mohit230723.EggsFor02.SkillMarketplace_a5ea5f33
{


    public class SkillMarketplaceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SkillMarketplaceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SkillMetadata : AVMObjectType
            {
                public byte[] Name { get; set; }

                public byte[] Description { get; set; }

                public byte[] SkillType { get; set; }

                public byte[] Version { get; set; }

                public ulong Price { get; set; }

                public Algorand.Address Seller { get; set; }

                public byte[] IpcsCid { get; set; }

                public ulong SoldCount { get; set; }

                public ulong ListedAt { get; set; }

                public ulong Active { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vName.From(Name);
                    ret.AddRange(vName.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[256]");
                    vDescription.From(Description);
                    ret.AddRange(vDescription.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSkillType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    vSkillType.From(SkillType);
                    ret.AddRange(vSkillType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    vVersion.From(Version);
                    ret.AddRange(vVersion.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpcsCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vIpcsCid.From(IpcsCid);
                    ret.AddRange(vIpcsCid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSoldCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSoldCount.From(SoldCount);
                    ret.AddRange(vSoldCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vListedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vListedAt.From(ListedAt);
                    ret.AddRange(vListedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SkillMetadata Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SkillMetadata();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vName.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueName = vName.ToValue();
                    if (valueName is byte[] vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[256]");
                    count = vDescription.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is byte[] vDescriptionValue) { ret.Description = vDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSkillType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    count = vSkillType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSkillType = vSkillType.ToValue();
                    if (valueSkillType is byte[] vSkillTypeValue) { ret.SkillType = vSkillTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    count = vVersion.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is byte[] vVersionValue) { ret.Version = vVersionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpcsCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vIpcsCid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIpcsCid = vIpcsCid.ToValue();
                    if (valueIpcsCid is byte[] vIpcsCidValue) { ret.IpcsCid = vIpcsCidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSoldCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSoldCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSoldCount = vSoldCount.ToValue();
                    if (valueSoldCount is ulong vSoldCountValue) { ret.SoldCount = vSoldCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vListedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vListedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueListedAt = vListedAt.ToValue();
                    if (valueListedAt is ulong vListedAtValue) { ret.ListedAt = vListedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is ulong vActiveValue) { ret.Active = vActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SkillMetadata);
                }
                public bool Equals(SkillMetadata? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SkillMetadata left, SkillMetadata right)
                {
                    return EqualityComparer<SkillMetadata>.Default.Equals(left, right);
                }
                public static bool operator !=(SkillMetadata left, SkillMetadata right)
                {
                    return !(left == right);
                }

            }

            public class PurchaseRecord : AVMObjectType
            {
                public Algorand.Address Buyer { get; set; }

                public ulong PurchasedAt { get; set; }

                public ulong SkillId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBuyer.From(Buyer);
                    ret.AddRange(vBuyer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurchasedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPurchasedAt.From(PurchasedAt);
                    ret.AddRange(vPurchasedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSkillId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSkillId.From(SkillId);
                    ret.AddRange(vSkillId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PurchaseRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PurchaseRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurchasedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPurchasedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePurchasedAt = vPurchasedAt.ToValue();
                    if (valuePurchasedAt is ulong vPurchasedAtValue) { ret.PurchasedAt = vPurchasedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSkillId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSkillId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSkillId = vSkillId.ToValue();
                    if (valueSkillId is ulong vSkillIdValue) { ret.SkillId = vSkillIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PurchaseRecord);
                }
                public bool Equals(PurchaseRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PurchaseRecord left, PurchaseRecord right)
                {
                    return EqualityComparer<PurchaseRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(PurchaseRecord left, PurchaseRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///List a new skill on the marketplace.
        ///Requires an MBR payment for box storage.
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="name"> </param>
        /// <param name="description"> </param>
        /// <param name="skillType"> </param>
        /// <param name="version"> </param>
        /// <param name="price"> </param>
        /// <param name="ipcsCid"> </param>
        public async Task<ulong> ListSkill(PaymentTransaction mbrPayment, byte[] name, byte[] description, byte[] skillType, byte[] version, ulong price, byte[] ipcsCid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 75, 182, 108, 86 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(256, "byte"); descriptionAbi.From(description);
            var skillTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); skillTypeAbi.From(skillType);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); versionAbi.From(version);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var ipcsCidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); ipcsCidAbi.From(ipcsCid);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, nameAbi, descriptionAbi, skillTypeAbi, versionAbi, priceAbi, ipcsCidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListSkill_Transactions(PaymentTransaction mbrPayment, byte[] name, byte[] description, byte[] skillType, byte[] version, ulong price, byte[] ipcsCid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 75, 182, 108, 86 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(256, "byte"); descriptionAbi.From(description);
            var skillTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); skillTypeAbi.From(skillType);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); versionAbi.From(version);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var ipcsCidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); ipcsCidAbi.From(ipcsCid);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, nameAbi, descriptionAbi, skillTypeAbi, versionAbi, priceAbi, ipcsCidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Purchase a skill. Splits payment between seller and platform.
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="skillId"> </param>
        public async Task BuySkill(PaymentTransaction payment, ulong skillId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 187, 92, 172, 86 };
            var skillIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); skillIdAbi.From(skillId);

            var result = await base.CallApp(new List<object> { abiHandle, payment, skillIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuySkill_Transactions(PaymentTransaction payment, ulong skillId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 187, 92, 172, 86 };
            var skillIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); skillIdAbi.From(skillId);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, skillIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a buyer has purchased a skill. Used by x402 content gate.
        ///</summary>
        /// <param name="skillId"> </param>
        /// <param name="buyer"> </param>
        public async Task<ulong> HasAccess(ulong skillId, Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 45, 116, 114 };
            var skillIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); skillIdAbi.From(skillId);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            var result = await base.CallApp(new List<object> { abiHandle, skillIdAbi, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasAccess_Transactions(ulong skillId, Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 45, 116, 114 };
            var skillIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); skillIdAbi.From(skillId);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            return await base.MakeTransactionList(new List<object> { abiHandle, skillIdAbi, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delist a skill. Only the seller can delist their own skill.
        ///</summary>
        /// <param name="skillId"> </param>
        public async Task DelistSkill(ulong skillId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 42, 78, 97 };
            var skillIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); skillIdAbi.From(skillId);

            var result = await base.CallApp(new List<object> { abiHandle, skillIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DelistSkill_Transactions(ulong skillId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 42, 78, 97 };
            var skillIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); skillIdAbi.From(skillId);

            return await base.MakeTransactionList(new List<object> { abiHandle, skillIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update platform fee (admin only)
        ///</summary>
        /// <param name="feeBps"> </param>
        public async Task SetPlatformFee(ulong feeBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 7, 156, 8 };
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);

            var result = await base.CallApp(new List<object> { abiHandle, feeBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPlatformFee_Transactions(ulong feeBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 7, 156, 8 };
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, feeBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJTa2lsbE1hcmtldHBsYWNlIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTa2lsbE1ldGFkYXRhIjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJieXRlWzY0XSJ9LHsibmFtZSI6ImRlc2NyaXB0aW9uIiwidHlwZSI6ImJ5dGVbMjU2XSJ9LHsibmFtZSI6InNraWxsVHlwZSIsInR5cGUiOiJieXRlWzE2XSJ9LHsibmFtZSI6InZlcnNpb24iLCJ0eXBlIjoiYnl0ZVsxNl0ifSx7Im5hbWUiOiJwcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzZWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImlwY3NDaWQiLCJ0eXBlIjoiYnl0ZVs2NF0ifSx7Im5hbWUiOiJzb2xkQ291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGlzdGVkQXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aXZlIiwidHlwZSI6InVpbnQ2NCJ9XSwiUHVyY2hhc2VSZWNvcmQiOlt7Im5hbWUiOiJidXllciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicHVyY2hhc2VkQXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2tpbGxJZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Imxpc3RTa2lsbCIsImRlc2MiOiJMaXN0IGEgbmV3IHNraWxsIG9uIHRoZSBtYXJrZXRwbGFjZS5cblJlcXVpcmVzIGFuIE1CUiBwYXltZW50IGZvciBib3ggc3RvcmFnZS4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs2NF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzI1Nl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVsxNl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJza2lsbFR5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMTZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNjRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBjc0NpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJidXlTa2lsbCIsImRlc2MiOiJQdXJjaGFzZSBhIHNraWxsLiBTcGxpdHMgcGF5bWVudCBiZXR3ZWVuIHNlbGxlciBhbmQgcGxhdGZvcm0uIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNraWxsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Imhhc0FjY2VzcyIsImRlc2MiOiJDaGVjayBpZiBhIGJ1eWVyIGhhcyBwdXJjaGFzZWQgYSBza2lsbC4gVXNlZCBieSB4NDAyIGNvbnRlbnQgZ2F0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2tpbGxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImRlbGlzdFNraWxsIiwiZGVzYyI6IkRlbGlzdCBhIHNraWxsLiBPbmx5IHRoZSBzZWxsZXIgY2FuIGRlbGlzdCB0aGVpciBvd24gc2tpbGwuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNraWxsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InNldFBsYXRmb3JtRmVlIiwiZGVzYyI6IlVwZGF0ZSBwbGF0Zm9ybSBmZWUgKGFkbWluIG9ubHkpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZUJwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURnZ01DQTJOQ0F4TmlBek1pQXpOVElnTXpZd0lESTFOaUF6TWpBZ016TTJJRE01TWlBME5UWWdORFkwSURRM01ncGllWFJsWTJKc2IyTnJJREI0SURCNE5qRTJOQ0F3ZURjek5qTWdNSGczTURZMklEQjRNREF3TURBd01EQXdNREF3TURBd01DQXdlREUxTVdZM1l6YzFJREI0TldZS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLbU55WldGMFpWOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJBb0tLazVQVkY5SlRWQk1SVTFGVGxSRlJEb0tDUzh2SUZSb1pTQnlaWEYxWlhOMFpXUWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdseklHTnZiblJ5WVdOMExpQkJjbVVnZVc5MUlIVnphVzVuSUhSb1pTQmpiM0p5WldOMElFOXVRMjl0Y0d4bGRHVS9JRVJwWkNCNWIzVWdjMlYwSUhsdmRYSWdZWEJ3SUVsRVB3b0paWEp5Q2dvdkx5QmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkFvcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb0pMeThnWlhobFkzVjBaU0JqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpBb0pZMkZzYkhOMVlpQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tUb2dkbTlwWkFwamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0NYQnliM1J2SURBZ01Bb0tDUzh2SUdOdmJuUnlZV04wYzF4VGEybHNiRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TXpVS0NTOHZJSFJvYVhNdWMydHBiR3hEYjNWdWRDNTJZV3gxWlNBOUlEQUtDV0o1ZEdWaklESWdMeThnSUNKell5SUtDV2x1ZEdNZ01pQXZMeUF3Q2dsaGNIQmZaMnh2WW1Gc1gzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk16WUtDUzh2SUhSb2FYTXVjR3hoZEdadmNtMUdaV1ZDY0hNdWRtRnNkV1VnUFNBMU1EQUtDV0o1ZEdWaklETWdMeThnSUNKd1ppSUtDWEIxYzJocGJuUWdOVEF3Q2dsaGNIQmZaMnh2WW1Gc1gzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk16Y0tDUzh2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnUFNCMGFHbHpMblI0Ymk1elpXNWtaWElLQ1dKNWRHVmpJREVnTHk4Z0lDSmhaQ0lLQ1hSNGJpQlRaVzVrWlhJS0NXRndjRjluYkc5aVlXeGZjSFYwQ2dseVpYUnpkV0lLQ2k4dklHeHBjM1JUYTJsc2JDaHdZWGtzWW5sMFpWczJORjBzWW5sMFpWc3lOVFpkTEdKNWRHVmJNVFpkTEdKNWRHVmJNVFpkTEhWcGJuUTJOQ3hpZVhSbFd6WTBYU2wxYVc1ME5qUUtLbUZpYVY5eWIzVjBaVjlzYVhOMFUydHBiR3c2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1dKNWRHVmpJRFVnTHk4Z01IZ3hOVEZtTjJNM05Rb0tDUzh2SUdsd1kzTkRhV1E2SUdKNWRHVmJOalJkQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXpJQzh2SURZMENnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElEQWdLR2x3WTNORGFXUXBJR1p2Y2lCc2FYTjBVMnRwYkd3Z2JYVnpkQ0JpWlNCaElHSjVkR1ZiTmpSZENnbGhjM05sY25RS0Nna3ZMeUJ3Y21salpUb2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2dsaWRHOXBDZ29KTHk4Z2RtVnljMmx2YmpvZ1lubDBaVnN4TmwwS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLQ1dSMWNBb0piR1Z1Q2dscGJuUmpJRFFnTHk4Z01UWUtDVDA5Q2dvSkx5OGdZWEpuZFcxbGJuUWdNaUFvZG1WeWMybHZiaWtnWm05eUlHeHBjM1JUYTJsc2JDQnRkWE4wSUdKbElHRWdZbmwwWlZzeE5sMEtDV0Z6YzJWeWRBb0tDUzh2SUhOcmFXeHNWSGx3WlRvZ1lubDBaVnN4TmwwS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LQ1dSMWNBb0piR1Z1Q2dscGJuUmpJRFFnTHk4Z01UWUtDVDA5Q2dvSkx5OGdZWEpuZFcxbGJuUWdNeUFvYzJ0cGJHeFVlWEJsS1NCbWIzSWdiR2x6ZEZOcmFXeHNJRzExYzNRZ1ltVWdZU0JpZVhSbFd6RTJYUW9KWVhOelpYSjBDZ29KTHk4Z1pHVnpZM0pwY0hScGIyNDZJR0o1ZEdWYk1qVTJYUW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb0paSFZ3Q2dsc1pXNEtDV2x1ZEdNZ09DQXZMeUF5TlRZS0NUMDlDZ29KTHk4Z1lYSm5kVzFsYm5RZ05DQW9aR1Z6WTNKcGNIUnBiMjRwSUdadmNpQnNhWE4wVTJ0cGJHd2diWFZ6ZENCaVpTQmhJR0o1ZEdWYk1qVTJYUW9KWVhOelpYSjBDZ29KTHk4Z2JtRnRaVG9nWW5sMFpWczJORjBLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV1IxY0FvSmJHVnVDZ2xwYm5SaklETWdMeThnTmpRS0NUMDlDZ29KTHk4Z1lYSm5kVzFsYm5RZ05TQW9ibUZ0WlNrZ1ptOXlJR3hwYzNSVGEybHNiQ0J0ZFhOMElHSmxJR0VnWW5sMFpWczJORjBLQ1dGemMyVnlkQW9LQ1M4dklHMWljbEJoZVcxbGJuUTZJSEJoZVFvSmRIaHVJRWR5YjNWd1NXNWtaWGdLQ1dsdWRHTWdNQ0F2THlBeENna3RDZ2xrZFhBS0NXZDBlRzV6SUZSNWNHVkZiblZ0Q2dscGJuUmpJREFnTHk4Z0lIQmhlUW9KUFQwS0Nna3ZMeUJoY21kMWJXVnVkQ0EySUNodFluSlFZWGx0Wlc1MEtTQm1iM0lnYkdsemRGTnJhV3hzSUcxMWMzUWdZbVVnWVNCd1lYa2dkSEpoYm5OaFkzUnBiMjRLQ1dGemMyVnlkQW9LQ1M4dklHVjRaV04xZEdVZ2JHbHpkRk5yYVd4c0tIQmhlU3hpZVhSbFd6WTBYU3hpZVhSbFd6STFObDBzWW5sMFpWc3hObDBzWW5sMFpWc3hObDBzZFdsdWREWTBMR0o1ZEdWYk5qUmRLWFZwYm5RMk5Bb0pZMkZzYkhOMVlpQnNhWE4wVTJ0cGJHd0tDV2wwYjJJS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QnNhWE4wVTJ0cGJHd29iV0p5VUdGNWJXVnVkRG9nVUdGNVZIaHVMQ0J1WVcxbE9pQlRkR0YwYVdOQmNuSmhlVHhpZVhSbExDQTJORDRzSUdSbGMyTnlhWEIwYVc5dU9pQlRkR0YwYVdOQmNuSmhlVHhpZVhSbExDQXlOVFkrTENCemEybHNiRlI1Y0dVNklGTjBZWFJwWTBGeWNtRjVQR0o1ZEdVc0lERTJQaXdnZG1WeWMybHZiam9nVTNSaGRHbGpRWEp5WVhrOFlubDBaU3dnTVRZK0xDQndjbWxqWlRvZ2RXbHVkRFkwTENCcGNHTnpRMmxrT2lCVGRHRjBhV05CY25KaGVUeGllWFJsTENBMk5ENHBPaUIxYVc1ME5qUUtMeThLTHk4Z1RHbHpkQ0JoSUc1bGR5QnphMmxzYkNCdmJpQjBhR1VnYldGeWEyVjBjR3hoWTJVdUNpOHZJRkpsY1hWcGNtVnpJR0Z1SUUxQ1VpQndZWGx0Wlc1MElHWnZjaUJpYjNnZ2MzUnZjbUZuWlM0S2JHbHpkRk5yYVd4c09nb0pjSEp2ZEc4Z055QXhDZ29KTHk4Z1VIVnphQ0JsYlhCMGVTQmllWFJsY3lCaFpuUmxjaUIwYUdVZ1puSmhiV1VnY0c5cGJuUmxjaUIwYnlCeVpYTmxjblpsSUhOd1lXTmxJR1p2Y2lCc2IyTmhiQ0IyWVhKcFlXSnNaWE1LQ1dKNWRHVmpJREFnTHk4Z01IZ0tDV1IxY0c0Z01nb0tDUzh2SUdOdmJuUnlZV04wYzF4VGEybHNiRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TlRVS0NTOHZJRzFwYmsxaWNpQTlJREkxTURBZ0t5QmliM2hUYVhwbElDb2dOREF3Q2dsd2RYTm9hVzUwSURFNU5EVXdNQW9KWm5KaGJXVmZZblZ5ZVNBd0lDOHZJRzFwYmsxaWNqb2dkV2x1ZERZMENnb0pMeThnWTI5dWRISmhZM1J6WEZOcmFXeHNUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem8xTmdvSkx5OGdkbVZ5YVdaNVVHRjVWSGh1S0cxaWNsQmhlVzFsYm5Rc0lIc0tDUzh2SUNBZ0lDQWdJSEpsWTJWcGRtVnlPaUIwYUdsekxtRndjQzVoWkdSeVpYTnpMQW9KTHk4Z0lDQWdJQ0FnWVcxdmRXNTBPaUI3SUdkeVpXRjBaWEpVYUdGdVJYRjFZV3hVYnpvZ2JXbHVUV0p5SUgwc0Nna3ZMeUFnSUNBZ2ZTa0tDUzh2SUhabGNtbG1lU0J5WldObGFYWmxjZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJRzFpY2xCaGVXMWxiblE2SUZCaGVWUjRiZ29KWjNSNGJuTWdVbVZqWldsMlpYSUtDV2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNnazlQUW9LQ1M4dklIUnlZVzV6WVdOMGFXOXVJSFpsY21sbWFXTmhkR2x2YmlCbVlXbHNaV1E2SUhzaWRIaHVJam9pYldKeVVHRjViV1Z1ZENJc0ltWnBaV3hrSWpvaWNtVmpaV2wyWlhJaUxDSmxlSEJsWTNSbFpDSTZJblJvYVhNdVlYQndMbUZrWkhKbGMzTWlmUW9KWVhOelpYSjBDZ29KTHk4Z2RtVnlhV1o1SUdGdGIzVnVkQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJRzFpY2xCaGVXMWxiblE2SUZCaGVWUjRiZ29KWjNSNGJuTWdRVzF2ZFc1MENnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCdGFXNU5Zbkk2SUhWcGJuUTJOQW9KUGowS0Nna3ZMeUIwY21GdWMyRmpkR2x2YmlCMlpYSnBabWxqWVhScGIyNGdabUZwYkdWa09pQjdJblI0YmlJNkltMWljbEJoZVcxbGJuUWlMQ0ptYVdWc1pDSTZJbUZ0YjNWdWRDSXNJbU52Ym1ScGRHbHZiaUk2SW1keVpXRjBaWEpVYUdGdVJYRjFZV3hVYnlJc0ltVjRjR1ZqZEdWa0lqb2lQajF0YVc1TlluSWlmUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGTnJhV3hzVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvMk1Rb0pMeThnWVhOelpYSjBLSEJ5YVdObElENGdNQ3dnSjFCeWFXTmxJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBbktRb0pabkpoYldWZlpHbG5JQzAySUM4dklIQnlhV05sT2lCMWFXNTBOalFLQ1dsdWRHTWdNaUF2THlBd0NnaytDZ29KTHk4Z1VISnBZMlVnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEZOcmFXeHNUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem8yTlFvSkx5OGdjMnRwYkd4SlpDQTlJSFJvYVhNdWMydHBiR3hEYjNWdWRDNTJZV3gxWlNBcklERUtDV0o1ZEdWaklESWdMeThnSUNKell5SUtDV0Z3Y0Y5bmJHOWlZV3hmWjJWMENnbHBiblJqSURBZ0x5OGdNUW9KS3dvSlpuSmhiV1ZmWW5WeWVTQXhJQzh2SUhOcmFXeHNTV1E2SUhWcGJuUTJOQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk5qWUtDUzh2SUhSb2FYTXVjMnRwYkd4RGIzVnVkQzUyWVd4MVpTQTlJSE5yYVd4c1NXUUtDV0o1ZEdWaklESWdMeThnSUNKell5SUtDV1p5WVcxbFgyUnBaeUF4SUM4dklITnJhV3hzU1dRNklIVnBiblEyTkFvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNVMnRwYkd4TllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qWTVDZ2t2THlCemEybHNiRG9nVTJ0cGJHeE5aWFJoWkdGMFlTQTlJSHNLQ1M4dklDQWdJQ0FnSUc1aGJXVTZJRzVoYldVc0Nna3ZMeUFnSUNBZ0lDQmtaWE5qY21sd2RHbHZiam9nWkdWelkzSnBjSFJwYjI0c0Nna3ZMeUFnSUNBZ0lDQnphMmxzYkZSNWNHVTZJSE5yYVd4c1ZIbHdaU3dLQ1M4dklDQWdJQ0FnSUhabGNuTnBiMjQ2SUhabGNuTnBiMjRzQ2drdkx5QWdJQ0FnSUNCd2NtbGpaVG9nY0hKcFkyVXNDZ2t2THlBZ0lDQWdJQ0J6Wld4c1pYSTZJSFJvYVhNdWRIaHVMbk5sYm1SbGNpd0tDUzh2SUNBZ0lDQWdJR2x3WTNORGFXUTZJR2x3WTNORGFXUXNDZ2t2THlBZ0lDQWdJQ0J6YjJ4a1EyOTFiblE2SURBc0Nna3ZMeUFnSUNBZ0lDQnNhWE4wWldSQmREb2daMnh2WW1Gc2N5NXliM1Z1WkN3S0NTOHZJQ0FnSUNBZ0lHRmpkR2wyWlRvZ01Td0tDUzh2SUNBZ0lDQjlDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdibUZ0WlRvZ1UzUmhkR2xqUVhKeVlYazhZbmwwWlN3Z05qUStDZ2xtY21GdFpWOWthV2NnTFRNZ0x5OGdaR1Z6WTNKcGNIUnBiMjQ2SUZOMFlYUnBZMEZ5Y21GNVBHSjVkR1VzSURJMU5qNEtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzAwSUM4dklITnJhV3hzVkhsd1pUb2dVM1JoZEdsalFYSnlZWGs4WW5sMFpTd2dNVFkrQ2dsamIyNWpZWFFLQ1daeVlXMWxYMlJwWnlBdE5TQXZMeUIyWlhKemFXOXVPaUJUZEdGMGFXTkJjbkpoZVR4aWVYUmxMQ0F4Tmo0S0NXTnZibU5oZEFvSlpuSmhiV1ZmWkdsbklDMDJJQzh2SUhCeWFXTmxPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSmRIaHVJRk5sYm1SbGNnb0pZMjl1WTJGMENnbG1jbUZ0WlY5a2FXY2dMVGNnTHk4Z2FYQmpjME5wWkRvZ1UzUmhkR2xqUVhKeVlYazhZbmwwWlN3Z05qUStDZ2xqYjI1allYUUtDV0o1ZEdWaklEUWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2dsamIyNWpZWFFLQ1dkc2IySmhiQ0JTYjNWdVpBb0phWFJ2WWdvSlkyOXVZMkYwQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBeENnbGpiMjVqWVhRS0NXWnlZVzFsWDJKMWNua2dNaUF2THlCemEybHNiRG9nVTJ0cGJHeE5aWFJoWkdGMFlRb0tDUzh2SUdOdmJuUnlZV04wYzF4VGEybHNiRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T0RJS0NTOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1emEybHNiSE1vYzJ0cGJHeEpaQ2t1WlhocGMzUnpMQ0FuVTJ0cGJHd2dZV3h5WldGa2VTQmxlR2x6ZEhNZ2QybDBhQ0IwYUdseklFbEVKeWtLQ1daeVlXMWxYMlJwWnlBeElDOHZJSE5yYVd4c1NXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlltOTRYMnhsYmdvSmMzZGhjQW9KY0c5d0Nna2hDZ29KTHk4Z1UydHBiR3dnWVd4eVpXRmtlU0JsZUdsemRITWdkMmwwYUNCMGFHbHpJRWxFQ2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNVMnRwYkd4TllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qZzBDZ2t2THlCMGFHbHpMbk5yYVd4c2N5aHphMmxzYkVsa0tTNTJZV3gxWlNBOUlITnJhV3hzQ2dsbWNtRnRaVjlrYVdjZ01TQXZMeUJ6YTJsc2JFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXWnlZVzFsWDJScFp5QXlJQzh2SUhOcmFXeHNPaUJUYTJsc2JFMWxkR0ZrWVhSaENnbGliM2hmY0hWMENnb0pMeThnWTI5dWRISmhZM1J6WEZOcmFXeHNUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem80TmdvSkx5OGdjbVYwZFhKdUlITnJhV3hzU1dRN0NnbG1jbUZ0WlY5a2FXY2dNU0F2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ2drdkx5QnpaWFFnZEdobElITjFZbkp2ZFhScGJtVWdjbVYwZFhKdUlIWmhiSFZsQ2dsbWNtRnRaVjlpZFhKNUlEQUtDZ2t2THlCd2IzQWdZV3hzSUd4dlkyRnNJSFpoY21saFlteGxjeUJtY205dElIUm9aU0J6ZEdGamF3b0pjRzl3YmlBeUNnbHlaWFJ6ZFdJS0NpOHZJR0oxZVZOcmFXeHNLSEJoZVN4MWFXNTBOalFwZG05cFpBb3FZV0pwWDNKdmRYUmxYMkoxZVZOcmFXeHNPZ29KTHk4Z2MydHBiR3hKWkRvZ2RXbHVkRFkwQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xpZEc5cENnb0pMeThnY0dGNWJXVnVkRG9nY0dGNUNnbDBlRzRnUjNKdmRYQkpibVJsZUFvSmFXNTBZeUF3SUM4dklERUtDUzBLQ1dSMWNBb0paM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0NXbHVkR01nTUNBdkx5QWdjR0Y1Q2drOVBRb0tDUzh2SUdGeVozVnRaVzUwSURFZ0tIQmhlVzFsYm5RcElHWnZjaUJpZFhsVGEybHNiQ0J0ZFhOMElHSmxJR0VnY0dGNUlIUnlZVzV6WVdOMGFXOXVDZ2xoYzNObGNuUUtDZ2t2THlCbGVHVmpkWFJsSUdKMWVWTnJhV3hzS0hCaGVTeDFhVzUwTmpRcGRtOXBaQW9KWTJGc2JITjFZaUJpZFhsVGEybHNiQW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdZblY1VTJ0cGJHd29jR0Y1YldWdWREb2dVR0Y1VkhodUxDQnphMmxzYkVsa09pQjFhVzUwTmpRcE9pQjJiMmxrQ2k4dkNpOHZJRkIxY21Ob1lYTmxJR0VnYzJ0cGJHd3VJRk53YkdsMGN5QndZWGx0Wlc1MElHSmxkSGRsWlc0Z2MyVnNiR1Z5SUdGdVpDQndiR0YwWm05eWJTNEtZblY1VTJ0cGJHdzZDZ2x3Y205MGJ5QXlJREFLQ2drdkx5QlFkWE5vSUdWdGNIUjVJR0o1ZEdWeklHRm1kR1Z5SUhSb1pTQm1jbUZ0WlNCd2IybHVkR1Z5SUhSdklISmxjMlZ5ZG1VZ2MzQmhZMlVnWm05eUlHeHZZMkZzSUhaaGNtbGhZbXhsY3dvSllubDBaV01nTUNBdkx5QXdlQW9KWkhWd2JpQTFDZ29KTHk4Z1kyOXVkSEpoWTNSelhGTnJhV3hzVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvNU5nb0pMeThnWVhOelpYSjBLSFJvYVhNdWMydHBiR3h6S0hOcmFXeHNTV1FwTG1WNGFYTjBjeXdnSjFOcmFXeHNJRzV2ZENCbWIzVnVaQ2NwQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnYzJ0cGJHeEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGliM2hmYkdWdUNnbHpkMkZ3Q2dsd2IzQUtDZ2t2THlCVGEybHNiQ0J1YjNRZ1ptOTFibVFLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk9UY0tDUzh2SUhOcmFXeHNJRDBnZEdocGN5NXphMmxzYkhNb2MydHBiR3hKWkNrdWRtRnNkV1VLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJ6YTJsc2JFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXWnlZVzFsWDJKMWNua2dNQ0F2THlCemRHOXlZV2RsSUd0bGVTOHZjMnRwYkd3S0Nna3ZMeUJqYjI1MGNtRmpkSE5jVTJ0cGJHeE5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPams0Q2drdkx5QmhjM05sY25Rb2MydHBiR3d1WVdOMGFYWmxJRDA5UFNBeExDQW5VMnRwYkd3Z2FYTWdibThnYkc5dVoyVnlJR0ZqZEdsMlpTY3BDZ2xwYm5SaklERTBJQzh2SUNCb1pXRmtUMlptYzJWMENnbHBiblJqSURFZ0x5OGdPQW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJSE5yYVd4c1NXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOTJaWElnTWdvSlltOTRYMlY0ZEhKaFkzUUtDV0owYjJrS0NXbHVkR01nTUNBdkx5QXhDZ2s5UFFvS0NTOHZJRk5yYVd4c0lHbHpJRzV2SUd4dmJtZGxjaUJoWTNScGRtVUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4VGEybHNiRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T1RrS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG5SNGJpNXpaVzVrWlhJZ0lUMDlJSE5yYVd4c0xuTmxiR3hsY2l3Z0owTmhibTV2ZENCaWRYa2dlVzkxY2lCdmQyNGdjMnRwYkd3bktRb0pkSGh1SUZObGJtUmxjZ29KYVc1MFl5QTNJQzh2SUNCb1pXRmtUMlptYzJWMENnbHBiblJqSURVZ0x5OGdNeklLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJ6YTJsc2JFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZkbVZ5SURJS0NXSnZlRjlsZUhSeVlXTjBDZ2toUFFvS0NTOHZJRU5oYm01dmRDQmlkWGtnZVc5MWNpQnZkMjRnYzJ0cGJHd0tDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4VGEybHNiRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRBeENna3ZMeUIyWlhKcFpubFFZWGxVZUc0b2NHRjViV1Z1ZEN3Z2V3b0pMeThnSUNBZ0lDQWdjbVZqWldsMlpYSTZJSFJvYVhNdVlYQndMbUZrWkhKbGMzTXNDZ2t2THlBZ0lDQWdJQ0JoYlc5MWJuUTZJSHNnWjNKbFlYUmxjbFJvWVc1RmNYVmhiRlJ2T2lCemEybHNiQzV3Y21salpTQjlMQW9KTHk4Z0lDQWdJSDBwQ2drdkx5QjJaWEpwWm5rZ2NtVmpaV2wyWlhJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCd1lYbHRaVzUwT2lCUVlYbFVlRzRLQ1dkMGVHNXpJRkpsWTJWcGRtVnlDZ2xuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b0pQVDBLQ2drdkx5QjBjbUZ1YzJGamRHbHZiaUIyWlhKcFptbGpZWFJwYjI0Z1ptRnBiR1ZrT2lCN0luUjRiaUk2SW5CaGVXMWxiblFpTENKbWFXVnNaQ0k2SW5KbFkyVnBkbVZ5SWl3aVpYaHdaV04wWldRaU9pSjBhR2x6TG1Gd2NDNWhaR1J5WlhOekluMEtDV0Z6YzJWeWRBb0tDUzh2SUhabGNtbG1lU0JoYlc5MWJuUUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QndZWGx0Wlc1ME9pQlFZWGxVZUc0S0NXZDBlRzV6SUVGdGIzVnVkQW9KYVc1MFl5QTJJQzh2SUNCb1pXRmtUMlptYzJWMENnbHBiblJqSURFZ0x5OGdPQW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJSE5yYVd4c1NXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOTJaWElnTWdvSlltOTRYMlY0ZEhKaFkzUUtDV0owYjJrS0NUNDlDZ29KTHk4Z2RISmhibk5oWTNScGIyNGdkbVZ5YVdacFkyRjBhVzl1SUdaaGFXeGxaRG9nZXlKMGVHNGlPaUp3WVhsdFpXNTBJaXdpWm1sbGJHUWlPaUpoYlc5MWJuUWlMQ0pqYjI1a2FYUnBiMjRpT2lKbmNtVmhkR1Z5VkdoaGJrVnhkV0ZzVkc4aUxDSmxlSEJsWTNSbFpDSTZJajQ5YzJ0cGJHd3VjSEpwWTJVaWZRb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEZOcmFXeHNUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TURjS0NTOHZJSEIxY21Ob1lYTmxTMlY1SUQwZ2FYUnZZaWh6YTJsc2JFbGtLU0FySUNkZkp5QXJJSEpoZDBKNWRHVnpLSFJvYVhNdWRIaHVMbk5sYm1SbGNpa0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QnphMmxzYkVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dKNWRHVmpJRFlnTHk4Z0lDSmZJZ29KWTI5dVkyRjBDZ2wwZUc0Z1UyVnVaR1Z5Q2dsamIyNWpZWFFLQ1daeVlXMWxYMkoxY25rZ01TQXZMeUJ3ZFhKamFHRnpaVXRsZVRvZ1lubDBaVnRkQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRk5yYVd4c1RXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hNRGdLQ1M4dklHRnpjMlZ5ZENnaGRHaHBjeTV3ZFhKamFHRnpaWE1vY0hWeVkyaGhjMlZMWlhrcExtVjRhWE4wY3l3Z0owRnNjbVZoWkhrZ2NIVnlZMmhoYzJWa0lIUm9hWE1nYzJ0cGJHd25LUW9KWm5KaGJXVmZaR2xuSURFZ0x5OGdjSFZ5WTJoaGMyVkxaWGs2SUdKNWRHVmJYUW9KWkhWd0NnbHNaVzRLQ1dsMGIySUtDV1Y0ZEhKaFkzUWdOaUF5Q2dsemQyRndDZ2xqYjI1allYUUtDV0p2ZUY5c1pXNEtDWE4zWVhBS0NYQnZjQW9KSVFvS0NTOHZJRUZzY21WaFpIa2djSFZ5WTJoaGMyVmtJSFJvYVhNZ2MydHBiR3dLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1URXhDZ2t2THlCd2JHRjBabTl5YlVabFpTQTlJQ2h6YTJsc2JDNXdjbWxqWlNBcUlIUm9hWE11Y0d4aGRHWnZjbTFHWldWQ2NITXVkbUZzZFdVcElDOGdNVEF3TURBS0NXbHVkR01nTmlBdkx5QWdhR1ZoWkU5bVpuTmxkQW9KYVc1MFl5QXhJQzh2SURnS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052ZG1WeUlESUtDV0p2ZUY5bGVIUnlZV04wQ2dsaWRHOXBDZ2xpZVhSbFl5QXpJQzh2SUNBaWNHWWlDZ2xoY0hCZloyeHZZbUZzWDJkbGRBb0pLZ29KY0hWemFHbHVkQ0F4TURBd01Bb0pMd29KWm5KaGJXVmZZblZ5ZVNBeUlDOHZJSEJzWVhSbWIzSnRSbVZsT2lCMWFXNTBOalFLQ2drdkx5QmpiMjUwY21GamRITmNVMnRwYkd4TllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRXhNZ29KTHk4Z2MyVnNiR1Z5UVcxdmRXNTBJRDBnYzJ0cGJHd3VjSEpwWTJVZ0xTQndiR0YwWm05eWJVWmxaUW9KYVc1MFl5QTJJQzh2SUNCb1pXRmtUMlptYzJWMENnbHBiblJqSURFZ0x5OGdPQW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJSE5yYVd4c1NXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOTJaWElnTWdvSlltOTRYMlY0ZEhKaFkzUUtDV0owYjJrS0NXWnlZVzFsWDJScFp5QXlJQzh2SUhCc1lYUm1iM0p0Um1WbE9pQjFhVzUwTmpRS0NTMEtDV1p5WVcxbFgySjFjbmtnTXlBdkx5QnpaV3hzWlhKQmJXOTFiblE2SUhWcGJuUTJOQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1URTFDZ2t2THlCelpXNWtVR0Y1YldWdWRDaDdDZ2t2THlBZ0lDQWdJQ0J5WldObGFYWmxjam9nYzJ0cGJHd3VjMlZzYkdWeUxBb0pMeThnSUNBZ0lDQWdZVzF2ZFc1ME9pQnpaV3hzWlhKQmJXOTFiblFzQ2drdkx5QWdJQ0FnZlNrS0NXbDBlRzVmWW1WbmFXNEtDV2x1ZEdNZ01DQXZMeUFnY0dGNUNnbHBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDZ29KTHk4Z1kyOXVkSEpoWTNSelhGTnJhV3hzVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE1UWUtDUzh2SUhKbFkyVnBkbVZ5T2lCemEybHNiQzV6Wld4c1pYSUtDV2x1ZEdNZ055QXZMeUFnYUdWaFpFOW1abk5sZEFvSmFXNTBZeUExSUM4dklETXlDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdjMnRwYkd4SlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIzWmxjaUF5Q2dsaWIzaGZaWGgwY21GamRBb0phWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1URTNDZ2t2THlCaGJXOTFiblE2SUhObGJHeGxja0Z0YjNWdWRBb0pabkpoYldWZlpHbG5JRE1nTHk4Z2MyVnNiR1Z5UVcxdmRXNTBPaUIxYVc1ME5qUUtDV2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDZ29KTHk4Z1JtVmxJR1pwWld4a0lHNXZkQ0J6WlhRc0lHUmxabUYxYkhScGJtY2dkRzhnTUFvSmFXNTBZeUF5SUM4dklEQUtDV2wwZUc1ZlptbGxiR1FnUm1WbENnb0pMeThnVTNWaWJXbDBJR2x1Ym1WeUlIUnlZVzV6WVdOMGFXOXVDZ2xwZEhodVgzTjFZbTFwZEFvS0NTOHZJQ3BwWmpCZlkyOXVaR2wwYVc5dUNna3ZMeUJqYjI1MGNtRmpkSE5jVTJ0cGJHeE5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakV5TVFvSkx5OGdjR3hoZEdadmNtMUdaV1VnUGlBd0NnbG1jbUZ0WlY5a2FXY2dNaUF2THlCd2JHRjBabTl5YlVabFpUb2dkV2x1ZERZMENnbHBiblJqSURJZ0x5OGdNQW9KUGdvSllub2dLbWxtTUY5bGJtUUtDZ2t2THlBcWFXWXdYMk52Ym5ObGNYVmxiblFLQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1USXlDZ2t2THlCelpXNWtVR0Y1YldWdWRDaDdDZ2t2THlBZ0lDQWdJQ0FnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUZrYldsdUxuWmhiSFZsTEFvSkx5OGdJQ0FnSUNBZ0lDQmhiVzkxYm5RNklIQnNZWFJtYjNKdFJtVmxMQW9KTHk4Z0lDQWdJQ0FnZlNrS0NXbDBlRzVmWW1WbmFXNEtDV2x1ZEdNZ01DQXZMeUFnY0dGNUNnbHBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDZ29KTHk4Z1kyOXVkSEpoWTNSelhGTnJhV3hzVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE1qTUtDUzh2SUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUZrYldsdUxuWmhiSFZsQ2dsaWVYUmxZeUF4SUM4dklDQWlZV1FpQ2dsaGNIQmZaMnh2WW1Gc1gyZGxkQW9KYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvS0NTOHZJR052Ym5SeVlXTjBjMXhUYTJsc2JFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVEkwQ2drdkx5QmhiVzkxYm5RNklIQnNZWFJtYjNKdFJtVmxDZ2xtY21GdFpWOWthV2NnTWlBdkx5QndiR0YwWm05eWJVWmxaVG9nZFdsdWREWTBDZ2xwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9LQ1M4dklFWmxaU0JtYVdWc1pDQnViM1FnYzJWMExDQmtaV1poZFd4MGFXNW5JSFJ2SURBS0NXbHVkR01nTWlBdkx5QXdDZ2xwZEhodVgyWnBaV3hrSUVabFpRb0tDUzh2SUZOMVltMXBkQ0JwYm01bGNpQjBjbUZ1YzJGamRHbHZiZ29KYVhSNGJsOXpkV0p0YVhRS0NpcHBaakJmWlc1a09nb0pMeThnWTI5dWRISmhZM1J6WEZOcmFXeHNUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TWprS0NTOHZJSEpsWTI5eVpEb2dVSFZ5WTJoaGMyVlNaV052Y21RZ1BTQjdDZ2t2THlBZ0lDQWdJQ0JpZFhsbGNqb2dkR2hwY3k1MGVHNHVjMlZ1WkdWeUxBb0pMeThnSUNBZ0lDQWdjSFZ5WTJoaGMyVmtRWFE2SUdkc2IySmhiSE11Y205MWJtUXNDZ2t2THlBZ0lDQWdJQ0J6YTJsc2JFbGtPaUJ6YTJsc2JFbGtMQW9KTHk4Z0lDQWdJSDBLQ1hSNGJpQlRaVzVrWlhJS0NXZHNiMkpoYkNCU2IzVnVaQW9KYVhSdllnb0pZMjl1WTJGMENnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2MydHBiR3hKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV1p5WVcxbFgySjFjbmtnTkNBdkx5QnlaV052Y21RNklGQjFjbU5vWVhObFVtVmpiM0prQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRk5yYVd4c1RXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hNelFLQ1M4dklIUm9hWE11Y0hWeVkyaGhjMlZ6S0hCMWNtTm9ZWE5sUzJWNUtTNTJZV3gxWlNBOUlISmxZMjl5WkFvSlpuSmhiV1ZmWkdsbklERWdMeThnY0hWeVkyaGhjMlZMWlhrNklHSjVkR1ZiWFFvSlpIVndDZ2xzWlc0S0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbHpkMkZ3Q2dsamIyNWpZWFFLQ1daeVlXMWxYMlJwWnlBMElDOHZJSEpsWTI5eVpEb2dVSFZ5WTJoaGMyVlNaV052Y21RS0NXSnZlRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVTJ0cGJHeE5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakV6TndvSkx5OGdkWEJrWVhSbFpGTnJhV3hzT2lCVGEybHNiRTFsZEdGa1lYUmhJRDBnZXdvSkx5OGdJQ0FnSUNBZ2JtRnRaVG9nYzJ0cGJHd3VibUZ0WlN3S0NTOHZJQ0FnSUNBZ0lHUmxjMk55YVhCMGFXOXVPaUJ6YTJsc2JDNWtaWE5qY21sd2RHbHZiaXdLQ1M4dklDQWdJQ0FnSUhOcmFXeHNWSGx3WlRvZ2MydHBiR3d1YzJ0cGJHeFVlWEJsTEFvSkx5OGdJQ0FnSUNBZ2RtVnljMmx2YmpvZ2MydHBiR3d1ZG1WeWMybHZiaXdLQ1M4dklDQWdJQ0FnSUhCeWFXTmxPaUJ6YTJsc2JDNXdjbWxqWlN3S0NTOHZJQ0FnSUNBZ0lITmxiR3hsY2pvZ2MydHBiR3d1YzJWc2JHVnlMQW9KTHk4Z0lDQWdJQ0FnYVhCamMwTnBaRG9nYzJ0cGJHd3VhWEJqYzBOcFpDd0tDUzh2SUNBZ0lDQWdJSE52YkdSRGIzVnVkRG9nYzJ0cGJHd3VjMjlzWkVOdmRXNTBJQ3NnTVN3S0NTOHZJQ0FnSUNBZ0lHeHBjM1JsWkVGME9pQnphMmxzYkM1c2FYTjBaV1JCZEN3S0NTOHZJQ0FnSUNBZ0lHRmpkR2wyWlRvZ2MydHBiR3d1WVdOMGFYWmxMQW9KTHk4Z0lDQWdJSDBLQ1dsdWRHTWdNaUF2THlBd0NnbHBiblJqSURNZ0x5OGdOalFLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJ6YTJsc2JFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZkbVZ5SURJS0NXSnZlRjlsZUhSeVlXTjBDZ2xwYm5SaklETWdMeThnSUdobFlXUlBabVp6WlhRS0NXbHVkR01nT0NBdkx5QXlOVFlLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJ6YTJsc2JFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZkbVZ5SURJS0NXSnZlRjlsZUhSeVlXTjBDZ2xqYjI1allYUUtDV2x1ZEdNZ09TQXZMeUFnYUdWaFpFOW1abk5sZEFvSmFXNTBZeUEwSUM4dklERTJDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdjMnRwYkd4SlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIzWmxjaUF5Q2dsaWIzaGZaWGgwY21GamRBb0pZMjl1WTJGMENnbHBiblJqSURFd0lDOHZJQ0JvWldGa1QyWm1jMlYwQ2dscGJuUmpJRFFnTHk4Z01UWUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QnphMmxzYkVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmRtVnlJRElLQ1dKdmVGOWxlSFJ5WVdOMENnbGpiMjVqWVhRS0NXbHVkR01nTmlBdkx5QWdhR1ZoWkU5bVpuTmxkQW9KYVc1MFl5QXhJQzh2SURnS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052ZG1WeUlESUtDV0p2ZUY5bGVIUnlZV04wQ2dsaWRHOXBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXbHVkR01nTnlBdkx5QWdhR1ZoWkU5bVpuTmxkQW9KYVc1MFl5QTFJQzh2SURNeUNnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2MydHBiR3hKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjNabGNpQXlDZ2xpYjNoZlpYaDBjbUZqZEFvSlkyOXVZMkYwQ2dscGJuUmpJREV4SUM4dklDQm9aV0ZrVDJabWMyVjBDZ2xwYm5SaklETWdMeThnTmpRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052ZG1WeUlESUtDV0p2ZUY5bGVIUnlZV04wQ2dsamIyNWpZWFFLQ1dsdWRHTWdNVElnTHk4Z0lHaGxZV1JQWm1aelpYUUtDV2x1ZEdNZ01TQXZMeUE0Q2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnYzJ0cGJHeEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiM1psY2lBeUNnbGliM2hmWlhoMGNtRmpkQW9KWW5SdmFRb0phVzUwWXlBd0lDOHZJREVLQ1NzS0NXbDBiMklLQ1dOdmJtTmhkQW9KYVc1MFl5QXhNeUF2THlBZ2FHVmhaRTltWm5ObGRBb0phVzUwWXlBeElDOHZJRGdLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJ6YTJsc2JFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZkbVZ5SURJS0NXSnZlRjlsZUhSeVlXTjBDZ2xpZEc5cENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dsdWRHTWdNVFFnTHk4Z0lHaGxZV1JQWm1aelpYUUtDV2x1ZEdNZ01TQXZMeUE0Q2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnYzJ0cGJHeEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiM1psY2lBeUNnbGliM2hmWlhoMGNtRmpkQW9KWW5SdmFRb0phWFJ2WWdvSlkyOXVZMkYwQ2dsbWNtRnRaVjlpZFhKNUlEVWdMeThnZFhCa1lYUmxaRk5yYVd4c09pQlRhMmxzYkUxbGRHRmtZWFJoQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRk5yYVd4c1RXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hORGtLQ1M4dklIUm9hWE11YzJ0cGJHeHpLSE5yYVd4c1NXUXBMblpoYkhWbElEMGdkWEJrWVhSbFpGTnJhV3hzQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnYzJ0cGJHeEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbG1jbUZ0WlY5a2FXY2dOU0F2THlCMWNHUmhkR1ZrVTJ0cGJHdzZJRk5yYVd4c1RXVjBZV1JoZEdFS0NXSnZlRjl3ZFhRS0NYSmxkSE4xWWdvS0x5OGdhR0Z6UVdOalpYTnpLSFZwYm5RMk5DeGhaR1J5WlhOektYVnBiblEyTkFvcVlXSnBYM0p2ZFhSbFgyaGhjMEZqWTJWemN6b0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdZblY1WlhJNklHRmtaSEpsYzNNS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLQ1dSMWNBb0piR1Z1Q2dscGJuUmpJRFVnTHk4Z016SUtDVDA5Q2dvSkx5OGdZWEpuZFcxbGJuUWdNQ0FvWW5WNVpYSXBJR1p2Y2lCb1lYTkJZMk5sYzNNZ2JYVnpkQ0JpWlNCaElHRmtaSEpsYzNNS0NXRnpjMlZ5ZEFvS0NTOHZJSE5yYVd4c1NXUTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlluUnZhUW9LQ1M4dklHVjRaV04xZEdVZ2FHRnpRV05qWlhOektIVnBiblEyTkN4aFpHUnlaWE56S1hWcGJuUTJOQW9KWTJGc2JITjFZaUJvWVhOQlkyTmxjM01LQ1dsMGIySUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJvWVhOQlkyTmxjM01vYzJ0cGJHeEpaRG9nZFdsdWREWTBMQ0JpZFhsbGNqb2dRV1JrY21WemN5azZJSFZwYm5RMk5Bb3ZMd292THlCRGFHVmpheUJwWmlCaElHSjFlV1Z5SUdoaGN5QndkWEpqYUdGelpXUWdZU0J6YTJsc2JDNGdWWE5sWkNCaWVTQjROREF5SUdOdmJuUmxiblFnWjJGMFpTNEthR0Z6UVdOalpYTnpPZ29KY0hKdmRHOGdNaUF4Q2dvSkx5OGdVSFZ6YUNCbGJYQjBlU0JpZVhSbGN5QmhablJsY2lCMGFHVWdabkpoYldVZ2NHOXBiblJsY2lCMGJ5QnlaWE5sY25abElITndZV05sSUdadmNpQnNiMk5oYkNCMllYSnBZV0pzWlhNS0NXSjVkR1ZqSURBZ0x5OGdNSGdLQ2drdkx5QmpiMjUwY21GamRITmNVMnRwYkd4TllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRTFOZ29KTHk4Z2NIVnlZMmhoYzJWTFpYa2dQU0JwZEc5aUtITnJhV3hzU1dRcElDc2dKMThuSUNzZ2NtRjNRbmwwWlhNb1luVjVaWElwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYzJ0cGJHeEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGllWFJsWXlBMklDOHZJQ0FpWHlJS0NXTnZibU5oZEFvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdKMWVXVnlPaUJCWkdSeVpYTnpDZ2xqYjI1allYUUtDV1p5WVcxbFgySjFjbmtnTUNBdkx5QndkWEpqYUdGelpVdGxlVG9nWW5sMFpWdGRDZ29KTHk4Z1kyOXVkSEpoWTNSelhGTnJhV3hzVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE5UY0tDUzh2SUhKbGRIVnliaUIwYUdsekxuQjFjbU5vWVhObGN5aHdkWEpqYUdGelpVdGxlU2t1WlhocGMzUnpJRDhnTVNBNklEQTdDZ2xtY21GdFpWOWthV2NnTUNBdkx5QndkWEpqYUdGelpVdGxlVG9nWW5sMFpWdGRDZ2xrZFhBS0NXeGxiZ29KYVhSdllnb0paWGgwY21GamRDQTJJRElLQ1hOM1lYQUtDV052Ym1OaGRBb0pZbTk0WDJ4bGJnb0pjM2RoY0FvSmNHOXdDZ2xpZWlBcWRHVnlibUZ5ZVRCZlptRnNjMlVLQ1dsdWRHTWdNQ0F2THlBeENnbGlJQ3AwWlhKdVlYSjVNRjlsYm1RS0NpcDBaWEp1WVhKNU1GOW1ZV3h6WlRvS0NXbHVkR01nTWlBdkx5QXdDZ29xZEdWeWJtRnllVEJmWlc1a09nb0pMeThnYzJWMElIUm9aU0J6ZFdKeWIzVjBhVzVsSUhKbGRIVnliaUIyWVd4MVpRb0pabkpoYldWZlluVnllU0F3Q2dseVpYUnpkV0lLQ2k4dklHUmxiR2x6ZEZOcmFXeHNLSFZwYm5RMk5DbDJiMmxrQ2lwaFltbGZjbTkxZEdWZlpHVnNhWE4wVTJ0cGJHdzZDZ2t2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV0owYjJrS0Nna3ZMeUJsZUdWamRYUmxJR1JsYkdsemRGTnJhV3hzS0hWcGJuUTJOQ2wyYjJsa0NnbGpZV3hzYzNWaUlHUmxiR2x6ZEZOcmFXeHNDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmtaV3hwYzNSVGEybHNiQ2h6YTJsc2JFbGtPaUIxYVc1ME5qUXBPaUIyYjJsa0NpOHZDaTh2SUVSbGJHbHpkQ0JoSUhOcmFXeHNMaUJQYm14NUlIUm9aU0J6Wld4c1pYSWdZMkZ1SUdSbGJHbHpkQ0IwYUdWcGNpQnZkMjRnYzJ0cGJHd3VDbVJsYkdsemRGTnJhV3hzT2dvSmNISnZkRzhnTVNBd0Nnb0pMeThnVUhWemFDQmxiWEIwZVNCaWVYUmxjeUJoWm5SbGNpQjBhR1VnWm5KaGJXVWdjRzlwYm5SbGNpQjBieUJ5WlhObGNuWmxJSE53WVdObElHWnZjaUJzYjJOaGJDQjJZWEpwWVdKc1pYTUtDV0o1ZEdWaklEQWdMeThnTUhnS0NXUjFjQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFRhMmxzYkUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UWTBDZ2t2THlCaGMzTmxjblFvZEdocGN5NXphMmxzYkhNb2MydHBiR3hKWkNrdVpYaHBjM1J6TENBblUydHBiR3dnYm05MElHWnZkVzVrSnlrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV0p2ZUY5c1pXNEtDWE4zWVhBS0NYQnZjQW9LQ1M4dklGTnJhV3hzSUc1dmRDQm1iM1Z1WkFvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRk5yYVd4c1RXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hOalVLQ1M4dklITnJhV3hzSUQwZ2RHaHBjeTV6YTJsc2JITW9jMnRwYkd4SlpDa3VkbUZzZFdVS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV1p5WVcxbFgySjFjbmtnTUNBdkx5QnpkRzl5WVdkbElHdGxlUzh2YzJ0cGJHd0tDZ2t2THlCamIyNTBjbUZqZEhOY1UydHBiR3hOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFMk5nb0pMeThnWVhOelpYSjBLSFJvYVhNdWRIaHVMbk5sYm1SbGNpQTlQVDBnYzJ0cGJHd3VjMlZzYkdWeUlIeDhJSFJvYVhNdWRIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWhaRzFwYmk1MllXeDFaU3dnSjA1dmRDQmhkWFJvYjNKcGVtVmtKeWtLQ1hSNGJpQlRaVzVrWlhJS0NXbHVkR01nTnlBdkx5QWdhR1ZoWkU5bVpuTmxkQW9KYVc1MFl5QTFJQzh2SURNeUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2MydHBiR3hKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjNabGNpQXlDZ2xpYjNoZlpYaDBjbUZqZEFvSlBUMEtDV1IxY0FvSlltNTZJQ3B6YTJsd1gyOXlNQW9KZEhodUlGTmxibVJsY2dvSllubDBaV01nTVNBdkx5QWdJbUZrSWdvSllYQndYMmRzYjJKaGJGOW5aWFFLQ1QwOUNnbDhmQW9LS25OcmFYQmZiM0l3T2dvSkx5OGdUbTkwSUdGMWRHaHZjbWw2WldRS0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhUYTJsc2JFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVFk0Q2drdkx5QjFjR1JoZEdWa1UydHBiR3c2SUZOcmFXeHNUV1YwWVdSaGRHRWdQU0I3Q2drdkx5QWdJQ0FnSUNCdVlXMWxPaUJ6YTJsc2JDNXVZVzFsTEFvSkx5OGdJQ0FnSUNBZ1pHVnpZM0pwY0hScGIyNDZJSE5yYVd4c0xtUmxjMk55YVhCMGFXOXVMQW9KTHk4Z0lDQWdJQ0FnYzJ0cGJHeFVlWEJsT2lCemEybHNiQzV6YTJsc2JGUjVjR1VzQ2drdkx5QWdJQ0FnSUNCMlpYSnphVzl1T2lCemEybHNiQzUyWlhKemFXOXVMQW9KTHk4Z0lDQWdJQ0FnY0hKcFkyVTZJSE5yYVd4c0xuQnlhV05sTEFvSkx5OGdJQ0FnSUNBZ2MyVnNiR1Z5T2lCemEybHNiQzV6Wld4c1pYSXNDZ2t2THlBZ0lDQWdJQ0JwY0dOelEybGtPaUJ6YTJsc2JDNXBjR056UTJsa0xBb0pMeThnSUNBZ0lDQWdjMjlzWkVOdmRXNTBPaUJ6YTJsc2JDNXpiMnhrUTI5MWJuUXNDZ2t2THlBZ0lDQWdJQ0JzYVhOMFpXUkJkRG9nYzJ0cGJHd3ViR2x6ZEdWa1FYUXNDZ2t2THlBZ0lDQWdJQ0JoWTNScGRtVTZJREFzQ2drdkx5QWdJQ0FnZlFvSmFXNTBZeUF5SUM4dklEQUtDV2x1ZEdNZ015QXZMeUEyTkFvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUhOcmFXeHNTV1E2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjkyWlhJZ01nb0pZbTk0WDJWNGRISmhZM1FLQ1dsdWRHTWdNeUF2THlBZ2FHVmhaRTltWm5ObGRBb0phVzUwWXlBNElDOHZJREkxTmdvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUhOcmFXeHNTV1E2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjkyWlhJZ01nb0pZbTk0WDJWNGRISmhZM1FLQ1dOdmJtTmhkQW9KYVc1MFl5QTVJQzh2SUNCb1pXRmtUMlptYzJWMENnbHBiblJqSURRZ0x5OGdNVFlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJ6YTJsc2JFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZkbVZ5SURJS0NXSnZlRjlsZUhSeVlXTjBDZ2xqYjI1allYUUtDV2x1ZEdNZ01UQWdMeThnSUdobFlXUlBabVp6WlhRS0NXbHVkR01nTkNBdkx5QXhOZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJSE5yYVd4c1NXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOTJaWElnTWdvSlltOTRYMlY0ZEhKaFkzUUtDV052Ym1OaGRBb0phVzUwWXlBMklDOHZJQ0JvWldGa1QyWm1jMlYwQ2dscGJuUmpJREVnTHk4Z09Bb0pabkpoYldWZlpHbG5JQzB4SUM4dklITnJhV3hzU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5MlpYSWdNZ29KWW05NFgyVjRkSEpoWTNRS0NXSjBiMmtLQ1dsMGIySUtDV052Ym1OaGRBb0phVzUwWXlBM0lDOHZJQ0JvWldGa1QyWm1jMlYwQ2dscGJuUmpJRFVnTHk4Z016SUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QnphMmxzYkVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmRtVnlJRElLQ1dKdmVGOWxlSFJ5WVdOMENnbGpiMjVqWVhRS0NXbHVkR01nTVRFZ0x5OGdJR2hsWVdSUFptWnpaWFFLQ1dsdWRHTWdNeUF2THlBMk5Bb0pabkpoYldWZlpHbG5JQzB4SUM4dklITnJhV3hzU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5MlpYSWdNZ29KWW05NFgyVjRkSEpoWTNRS0NXTnZibU5oZEFvSmFXNTBZeUF4TWlBdkx5QWdhR1ZoWkU5bVpuTmxkQW9KYVc1MFl5QXhJQzh2SURnS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCemEybHNiRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052ZG1WeUlESUtDV0p2ZUY5bGVIUnlZV04wQ2dsaWRHOXBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXbHVkR01nTVRNZ0x5OGdJR2hsWVdSUFptWnpaWFFLQ1dsdWRHTWdNU0F2THlBNENnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2MydHBiR3hKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjNabGNpQXlDZ2xpYjNoZlpYaDBjbUZqZEFvSlluUnZhUW9KYVhSdllnb0pZMjl1WTJGMENnbGllWFJsWXlBMElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9KWTI5dVkyRjBDZ2xtY21GdFpWOWlkWEo1SURFZ0x5OGdkWEJrWVhSbFpGTnJhV3hzT2lCVGEybHNiRTFsZEdGa1lYUmhDZ29KTHk4Z1kyOXVkSEpoWTNSelhGTnJhV3hzVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE9EQUtDUzh2SUhSb2FYTXVjMnRwYkd4ektITnJhV3hzU1dRcExuWmhiSFZsSUQwZ2RYQmtZWFJsWkZOcmFXeHNDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdjMnRwYkd4SlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsbWNtRnRaVjlrYVdjZ01TQXZMeUIxY0dSaGRHVmtVMnRwYkd3NklGTnJhV3hzVFdWMFlXUmhkR0VLQ1dKdmVGOXdkWFFLQ1hKbGRITjFZZ29LTHk4Z2MyVjBVR3hoZEdadmNtMUdaV1VvZFdsdWREWTBLWFp2YVdRS0ttRmlhVjl5YjNWMFpWOXpaWFJRYkdGMFptOXliVVpsWlRvS0NTOHZJR1psWlVKd2N6b2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsaWRHOXBDZ29KTHk4Z1pYaGxZM1YwWlNCelpYUlFiR0YwWm05eWJVWmxaU2gxYVc1ME5qUXBkbTlwWkFvSlkyRnNiSE4xWWlCelpYUlFiR0YwWm05eWJVWmxaUW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjMlYwVUd4aGRHWnZjbTFHWldVb1ptVmxRbkJ6T2lCMWFXNTBOalFwT2lCMmIybGtDaTh2Q2k4dklGVndaR0YwWlNCd2JHRjBabTl5YlNCbVpXVWdLR0ZrYldsdUlHOXViSGtwQ25ObGRGQnNZWFJtYjNKdFJtVmxPZ29KY0hKdmRHOGdNU0F3Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRk5yYVd4c1RXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hPRGNLQ1M4dklHRnpjMlZ5ZENoMGFHbHpMblI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVdSdGFXNHVkbUZzZFdVc0lDZEJaRzFwYmlCdmJteDVKeWtLQ1hSNGJpQlRaVzVrWlhJS0NXSjVkR1ZqSURFZ0x5OGdJQ0poWkNJS0NXRndjRjluYkc5aVlXeGZaMlYwQ2drOVBRb0tDUzh2SUVGa2JXbHVJRzl1YkhrS0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhUYTJsc2JFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVGc0Q2drdkx5QmhjM05sY25Rb1ptVmxRbkJ6SUR3OUlERXdNREFzSUNkTllYZ2dabVZsSUdseklERXdKU2NwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWm1WbFFuQnpPaUIxYVc1ME5qUUtDWEIxYzJocGJuUWdNVEF3TUFvSlBEMEtDZ2t2THlCTllYZ2dabVZsSUdseklERXdKUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGTnJhV3hzVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE9Ea0tDUzh2SUhSb2FYTXVjR3hoZEdadmNtMUdaV1ZDY0hNdWRtRnNkV1VnUFNCbVpXVkNjSE1LQ1dKNWRHVmpJRE1nTHk4Z0lDSndaaUlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJtWldWQ2NITTZJSFZwYm5RMk5Bb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0NYSmxkSE4xWWdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlRFJpWWpZMll6VTJJQzh2SUcxbGRHaHZaQ0FpYkdsemRGTnJhV3hzS0hCaGVTeGllWFJsV3pZMFhTeGllWFJsV3pJMU5sMHNZbmwwWlZzeE5sMHNZbmwwWlZzeE5sMHNkV2x1ZERZMExHSjVkR1ZiTmpSZEtYVnBiblEyTkNJS0NYQjFjMmhpZVhSbGN5QXdlR0ppTldOaFl6VTJJQzh2SUcxbGRHaHZaQ0FpWW5WNVUydHBiR3dvY0dGNUxIVnBiblEyTkNsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNE9Ua3laRGMwTnpJZ0x5OGdiV1YwYUc5a0lDSm9ZWE5CWTJObGMzTW9kV2x1ZERZMExHRmtaSEpsYzNNcGRXbHVkRFkwSWdvSmNIVnphR0o1ZEdWeklEQjRZakF5WVRSbE5qRWdMeThnYldWMGFHOWtJQ0prWld4cGMzUlRhMmxzYkNoMWFXNTBOalFwZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZUdFNE1EYzVZekE0SUM4dklHMWxkR2h2WkNBaWMyVjBVR3hoZEdadmNtMUdaV1VvZFdsdWREWTBLWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJ4cGMzUlRhMmxzYkNBcVlXSnBYM0p2ZFhSbFgySjFlVk5yYVd4c0lDcGhZbWxmY205MWRHVmZhR0Z6UVdOalpYTnpJQ3BoWW1sZmNtOTFkR1ZmWkdWc2FYTjBVMnRwYkd3Z0ttRmlhVjl5YjNWMFpWOXpaWFJRYkdGMFptOXliVVpsWlFvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCallXeHNJRTV2VDNBS0NXVnljZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOm51bGwsImNvbXBpbGVySW5mbyI6bnVsbCwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
