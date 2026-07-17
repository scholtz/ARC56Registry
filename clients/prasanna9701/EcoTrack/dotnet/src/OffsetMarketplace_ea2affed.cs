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

namespace Arc56.Generated.prasanna9701.EcoTrack.OffsetMarketplace_ea2affed
{


    public class OffsetMarketplaceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OffsetMarketplaceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class OfferRecord : AVMObjectType
            {
                public byte[] Seller { get; set; }

                public ulong AssetId { get; set; }

                public ulong Amount { get; set; }

                public ulong Remaining { get; set; }

                public ulong PricePerUnit { get; set; }

                public ulong Active { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRemaining = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRemaining.From(Remaining);
                    ret.AddRange(vRemaining.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerUnit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPricePerUnit.From(PricePerUnit);
                    ret.AddRange(vPricePerUnit.Encode());
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

                public static OfferRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new OfferRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is byte[] vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRemaining = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRemaining.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRemaining = vRemaining.ToValue();
                    if (valueRemaining is ulong vRemainingValue) { ret.Remaining = vRemainingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerUnit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPricePerUnit.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePricePerUnit = vPricePerUnit.ToValue();
                    if (valuePricePerUnit is ulong vPricePerUnitValue) { ret.PricePerUnit = vPricePerUnitValue; }
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
                    return Equals(obj as OfferRecord);
                }
                public bool Equals(OfferRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(OfferRecord left, OfferRecord right)
                {
                    return EqualityComparer<OfferRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(OfferRecord left, OfferRecord right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class OffsetRetiredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 196, 5, 177, 48 };
                public const string Signature = "OffsetRetired(byte[32],uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field0 { get; set; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }
                public ulong Field3 { get; set; }

                public static OffsetRetiredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OffsetRetiredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Called on application creation.
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
        ///Opt the contract into an ASA so it can receive tokens.
        ///</summary>
        /// <param name="asset">- The ASA to opt into </param>
        /// <param name="mbrPay">- Payment to cover ASA opt-in MBR </param>
        public async Task OptInToAsset(PaymentTransaction mbrPay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 92, 1, 41, 137 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(PaymentTransaction mbrPay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 92, 1, 41, 137 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///List carbon credits for sale.
        ///Seller transfers ASA tokens to the contract as escrow.
        ///</summary>
        /// <param name="assetId">- The ASA ID being listed </param>
        /// <param name="amount">- Number of credits to list </param>
        /// <param name="pricePerUnit">- Price per credit in microAlgos </param>
        /// <param name="axferTxn">- Asset transfer of credits into escrow </param>
        /// <param name="mbrPay">- Payment for box MBR </param>
        public async Task<ulong> ListOffer(AssetTransferTransaction axferTxn, PaymentTransaction mbrPay, ulong assetId, ulong amount, ulong pricePerUnit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axferTxn, mbrPay });
            byte[] abiHandle = { 122, 248, 109, 226 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var pricePerUnitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerUnitAbi.From(pricePerUnit);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, amountAbi, pricePerUnitAbi, axferTxn, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListOffer_Transactions(AssetTransferTransaction axferTxn, PaymentTransaction mbrPay, ulong assetId, ulong amount, ulong pricePerUnit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axferTxn, mbrPay });
            byte[] abiHandle = { 122, 248, 109, 226 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var pricePerUnitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerUnitAbi.From(pricePerUnit);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, amountAbi, pricePerUnitAbi, axferTxn, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy and retire carbon credits (Option B: contract holds ASA, records retirement on buyer's behalf).
        ///Buyer sends ALGO, contract records the retirement immutably.
        ///</summary>
        /// <param name="offerId">- The offer to buy from </param>
        /// <param name="amount">- Number of credits to buy and retire </param>
        /// <param name="payTxn">- ALGO payment from buyer </param>
        public async Task BuyAndRetire(PaymentTransaction payTxn, ulong offerId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 219, 42, 36, 179 };
            var offerIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offerIdAbi.From(offerId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, offerIdAbi, amountAbi, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyAndRetire_Transactions(PaymentTransaction payTxn, ulong offerId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 219, 42, 36, 179 };
            var offerIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offerIdAbi.From(offerId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, offerIdAbi, amountAbi, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel an offer and return escrowed tokens to the seller.
        ///</summary>
        /// <param name="offerId">- The offer to cancel </param>
        public async Task CancelOffer(ulong offerId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 114, 79, 137 };
            var offerIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offerIdAbi.From(offerId);

            var result = await base.CallApp(new List<object> { abiHandle, offerIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelOffer_Transactions(ulong offerId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 114, 79, 137 };
            var offerIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offerIdAbi.From(offerId);

            return await base.MakeTransactionList(new List<object> { abiHandle, offerIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the next offer ID (for reading current offer count).
        ///</summary>
        public async Task<ulong> GetNextOfferId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 120, 130, 124 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNextOfferId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 120, 130, 124 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT2Zmc2V0TWFya2V0cGxhY2UiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2ZmZXJSZWNvcmQiOlt7Im5hbWUiOiJzZWxsZXIiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYXNzZXRJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVtYWluaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByaWNlUGVyVW5pdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkNhbGxlZCBvbiBhcHBsaWNhdGlvbiBjcmVhdGlvbi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Ub0Fzc2V0IiwiZGVzYyI6Ik9wdCB0aGUgY29udHJhY3QgaW50byBhbiBBU0Egc28gaXQgY2FuIHJlY2VpdmUgdG9rZW5zLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiItIFRoZSBBU0EgdG8gb3B0IGludG8iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheSIsImRlc2MiOiItIFBheW1lbnQgdG8gY292ZXIgQVNBIG9wdC1pbiBNQlIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGlzdE9mZmVyIiwiZGVzYyI6Ikxpc3QgY2FyYm9uIGNyZWRpdHMgZm9yIHNhbGUuXG5TZWxsZXIgdHJhbnNmZXJzIEFTQSB0b2tlbnMgdG8gdGhlIGNvbnRyYWN0IGFzIGVzY3Jvdy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOiItIFRoZSBBU0EgSUQgYmVpbmcgbGlzdGVkIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiLSBOdW1iZXIgb2YgY3JlZGl0cyB0byBsaXN0IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZVBlclVuaXQiLCJkZXNjIjoiLSBQcmljZSBwZXIgY3JlZGl0IGluIG1pY3JvQWxnb3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXhmZXJUeG4iLCJkZXNjIjoiLSBBc3NldCB0cmFuc2ZlciBvZiBjcmVkaXRzIGludG8gZXNjcm93IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXkiLCJkZXNjIjoiLSBQYXltZW50IGZvciBib3ggTUJSIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBvZmZlciBJRCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eUFuZFJldGlyZSIsImRlc2MiOiJCdXkgYW5kIHJldGlyZSBjYXJib24gY3JlZGl0cyAoT3B0aW9uIEI6IGNvbnRyYWN0IGhvbGRzIEFTQSwgcmVjb3JkcyByZXRpcmVtZW50IG9uIGJ1eWVyJ3MgYmVoYWxmKS5cbkJ1eWVyIHNlbmRzIEFMR08sIGNvbnRyYWN0IHJlY29yZHMgdGhlIHJldGlyZW1lbnQgaW1tdXRhYmx5LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvZmZlcklkIiwiZGVzYyI6Ii0gVGhlIG9mZmVyIHRvIGJ1eSBmcm9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiLSBOdW1iZXIgb2YgY3JlZGl0cyB0byBidXkgYW5kIHJldGlyZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5VHhuIiwiZGVzYyI6Ii0gQUxHTyBwYXltZW50IGZyb20gYnV5ZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik9mZnNldFJldGlyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsT2ZmZXIiLCJkZXNjIjoiQ2FuY2VsIGFuIG9mZmVyIGFuZCByZXR1cm4gZXNjcm93ZWQgdG9rZW5zIHRvIHRoZSBzZWxsZXIuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9mZmVySWQiLCJkZXNjIjoiLSBUaGUgb2ZmZXIgdG8gY2FuY2VsIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE5leHRPZmZlcklkIiwiZGVzYyI6IkdldCB0aGUgbmV4dCBvZmZlciBJRCAoZm9yIHJlYWRpbmcgY3VycmVudCBvZmZlciBjb3VudCkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMTgsMzQ2XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTddLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgY3JlZGl0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Myw0OTJdLCJlcnJvck1lc3NhZ2UiOiJPZmZlciBub3QgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI5LDQ3N10sImVycm9yTWVzc2FnZSI6Ik9mZmVyIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIHNlbGxlciBjYW4gY2FuY2VsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIwXSwiZXJyb3JNZXNzYWdlIjoiUHJpY2UgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOCwyMDksMjE1LDM4Ml0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjQsNTY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxLDE0NSwxNTQsMTYzLDI5MiwzMDQsNDY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMiwxODUsMzE1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJREFnTkFvZ0lDQWdZbmwwWldOaWJHOWpheUFpYm1WNGRFbGtJaUFpYnlJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUMlptYzJWMFRXRnlhMlYwY0d4aFkyVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEVmpNREV5T1RnNUlEQjROMkZtT0Raa1pUSWdNSGhrWWpKaE1qUmlNeUF3ZURjMk56STBaamc1SURCNFkyRTNPRGd5TjJNZ0x5OGdiV1YwYUc5a0lDSnZjSFJKYmxSdlFYTnpaWFFvZFdsdWREWTBMSEJoZVNsMmIybGtJaXdnYldWMGFHOWtJQ0pzYVhOMFQyWm1aWElvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lYaG1aWElzY0dGNUtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVluVjVRVzVrVW1WMGFYSmxLSFZwYm5RMk5DeDFhVzUwTmpRc2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTmhibU5sYkU5bVptVnlLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUk9aWGgwVDJabVpYSkpaQ2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYjNCMFNXNVViMEZ6YzJWMElHeHBjM1JQWm1abGNpQmlkWGxCYm1SU1pYUnBjbVVnWTJGdVkyVnNUMlptWlhJZ1oyVjBUbVY0ZEU5bVptVnlTV1FLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1QyWm1jMlYwVFdGeWEyVjBjR3hoWTJVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVkJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQXhNQW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCdVpYaDBUMlptWlhKSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R1WlhoMFNXUW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p1WlhoMFNXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklIUm9hWE11Ym1WNGRFOW1abVZ5U1dRdWRtRnNkV1VnUFNCVmFXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pwUFptWnpaWFJOWVhKclpYUndiR0ZqWlM1dmNIUkpibFJ2UVhOelpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0hSSmJsUnZRWE56WlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhCMVlteHBZeUJ2Y0hSSmJsUnZRWE56WlhRb1lYTnpaWFE2SUVGemMyVjBMQ0J0WW5KUVlYazZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TlRZdE5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LRzFpY2xCaGVTd2dld29nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QjlLUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvMU5pMDFPQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvYldKeVVHRjVMQ0I3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlZ5ZENCMFlYSm5aWFFnYVhNZ2JXRjBZMmdnWm05eUlHTnZibVJwZEdsdmJuTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvMk1DMDJOd29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUdGemMyVjBRVzF2ZFc1ME9pQXdMQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvMk1DMDJOZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0JwYm5Salh6TWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Wm1aelpYUmZiV0Z5YTJWMGNHeGhZMlV2VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem8yTUMwMk53b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdjSFZpYkdsaklHOXdkRWx1Vkc5QmMzTmxkQ2hoYzNObGREb2dRWE56WlhRc0lHMWljbEJoZVRvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qcFBabVp6WlhSTllYSnJaWFJ3YkdGalpTNXNhWE4wVDJabVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYVhOMFQyWm1aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZPREV0T0RjS0lDQWdJQzh2SUhCMVlteHBZeUJzYVhOMFQyWm1aWElvQ2lBZ0lDQXZMeUFnSUdGemMyVjBTV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSEJ5YVdObFVHVnlWVzVwZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCaGVHWmxjbFI0YmpvZ1ozUjRiaTVCYzNObGRGUnlZVzV6Wm1WeVZIaHVMQW9nSUNBZ0x5OGdJQ0J0WW5KUVlYazZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd0tJQ0FnSUM4dklDazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pvNE9TMDVNd29nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvWVhobVpYSlVlRzRzSUhzS0lDQWdJQzh2SUNBZ2VHWmxja0Z6YzJWME9pQkJjM05sZENoaGMzTmxkRWxrS1N3S0lDQWdJQzh2SUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnWkdsbklEVUtJQ0FnSUQwOUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPamt4Q2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T0RrdE9UTUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LR0Y0Wm1WeVZIaHVMQ0I3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvWVhOelpYUkpaQ2tzQ2lBZ0lDQXZMeUFnSUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkdsbklEUUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6bzVOUzA1TndvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2JXSnlVR0Y1TENCN0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUgwcENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPamsxTFRrM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHRZbkpRWVhrc0lIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPams1Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZVzF2ZFc1MElENGdWV2x1ZERZMEtEQXBMQ0FuUVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVW5LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWVhOelpYSjBLSEJ5YVdObFVHVnlWVzVwZENBK0lGVnBiblEyTkNnd0tTd2dKMUJ5YVdObElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VbktRb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVUhKcFkyVWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z1kyOXVjM1FnYjJabVpYSkpaRG9nZFdsdWREWTBJRDBnZEdocGN5NXVaWGgwVDJabVpYSkpaQzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Wm1aelpYUmZiV0Z5YTJWMGNHeGhZMlV2VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnYm1WNGRFOW1abVZ5U1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ibVY0ZEVsa0p5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlibVY0ZEVsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z1kyOXVjM1FnYjJabVpYSkpaRG9nZFdsdWREWTBJRDBnZEdocGN5NXVaWGgwVDJabVpYSkpaQzUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Wm1aelpYUmZiV0Z5YTJWMGNHeGhZMlV2VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TURRdE1URXhDaUFnSUNBdkx5QmpiMjV6ZENCdlptWmxjam9nVDJabVpYSlNaV052Y21RZ1BTQjdDaUFnSUNBdkx5QWdJSE5sYkd4bGNqb2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN5d0tJQ0FnSUM4dklDQWdZWE56WlhSSlpEb2dZWE56WlhSSlpDd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lISmxiV0ZwYm1sdVp6b2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQndjbWxqWlZCbGNsVnVhWFE2SUhCeWFXTmxVR1Z5Vlc1cGRDd0tJQ0FnSUM4dklDQWdZV04wYVhabE9pQlZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QjlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVEExQ2lBZ0lDQXZMeUJ6Wld4c1pYSTZJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRBMExURXhNUW9nSUNBZ0x5OGdZMjl1YzNRZ2IyWm1aWEk2SUU5bVptVnlVbVZqYjNKa0lEMGdld29nSUNBZ0x5OGdJQ0J6Wld4c1pYSTZJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFNXUTZJR0Z6YzJWMFNXUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQnlaVzFoYVc1cGJtYzZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdjSEpwWTJWUVpYSlZibWwwT2lCd2NtbGpaVkJsY2xWdWFYUXNDaUFnSUNBdkx5QWdJR0ZqZEdsMlpUb2dWV2x1ZERZMEtERXBMQW9nSUNBZ0x5OGdmUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNbUVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVEV3Q2lBZ0lDQXZMeUJoWTNScGRtVTZJRlZwYm5RMk5DZ3hLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UQTBMVEV4TVFvZ0lDQWdMeThnWTI5dWMzUWdiMlptWlhJNklFOW1abVZ5VW1WamIzSmtJRDBnZXdvZ0lDQWdMeThnSUNCelpXeHNaWEk2SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUdGemMyVjBTV1E2SUdGemMyVjBTV1FzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0J5WlcxaGFXNXBibWM2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnY0hKcFkyVlFaWEpWYm1sME9pQndjbWxqWlZCbGNsVnVhWFFzQ2lBZ0lDQXZMeUFnSUdGamRHbDJaVG9nVldsdWREWTBLREVwTEFvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE1USUtJQ0FnSUM4dklIUm9hWE11YjJabVpYSnpLRzltWm1WeVNXUXBMblpoYkhWbElEMGdZMnh2Ym1Vb2IyWm1aWElwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJ2Wm1abGNuTWdQU0JDYjNoTllYQThkV2x1ZERZMExDQlBabVpsY2xKbFkyOXlaRDRvZXlCclpYbFFjbVZtYVhnNklDZHZKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYnlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE1USUtJQ0FnSUM4dklIUm9hWE11YjJabVpYSnpLRzltWm1WeVNXUXBMblpoYkhWbElEMGdZMnh2Ym1Vb2IyWm1aWElwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUIwYUdsekxtNWxlSFJQWm1abGNrbGtMblpoYkhWbElEMGdiMlptWlhKSlpDQXJJRlZwYm5RMk5DZ3hLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Wm1aelpYUmZiV0Z5YTJWMGNHeGhZMlV2VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnYm1WNGRFOW1abVZ5U1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ibVY0ZEVsa0p5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlibVY0ZEVsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z2RHaHBjeTV1WlhoMFQyWm1aWEpKWkM1MllXeDFaU0E5SUc5bVptVnlTV1FnS3lCVmFXNTBOalFvTVNrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02T0RFdE9EY0tJQ0FnSUM4dklIQjFZbXhwWXlCc2FYTjBUMlptWlhJb0NpQWdJQ0F2THlBZ0lHRnpjMlYwU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhCeWFXTmxVR1Z5Vlc1cGREb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmhlR1psY2xSNGJqb2daM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSGh1TEFvZ0lDQWdMeThnSUNCdFluSlFZWGs2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qcFBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWlkWGxCYm1SU1pYUnBjbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWRYbEJibVJTWlhScGNtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1USTJMVEV6TUFvZ0lDQWdMeThnY0hWaWJHbGpJR0oxZVVGdVpGSmxkR2x5WlNnS0lDQWdJQzh2SUNBZ2IyWm1aWEpKWkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnY0dGNVZIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXZabVpsY25Nb2IyWm1aWEpKWkNrdVpYaHBjM1J6TENBblQyWm1aWElnYm05MElHWnZkVzVrSnlrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnZabVpsY25NZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCUFptWmxjbEpsWTI5eVpENG9leUJyWlhsUWNtVm1hWGc2SUNkdkp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlieUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXZabVpsY25Nb2IyWm1aWEpKWkNrdVpYaHBjM1J6TENBblQyWm1aWElnYm05MElHWnZkVzVrSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyWm1aWElnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVE16Q2lBZ0lDQXZMeUJqYjI1emRDQnZabVpsY2lBOUlHTnNiMjVsS0hSb2FYTXViMlptWlhKektHOW1abVZ5U1dRcExuWmhiSFZsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE16TXRNVE0wQ2lBZ0lDQXZMeUJqYjI1emRDQnZabVpsY2lBOUlHTnNiMjVsS0hSb2FYTXViMlptWlhKektHOW1abVZ5U1dRcExuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRzltWm1WeUxtRmpkR2wyWlNBOVBUMGdWV2x1ZERZMEtERXBMQ0FuVDJabVpYSWdibTkwSUdGamRHbDJaU2NwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016UWdMeThnTXpRS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdZWE56WlhKMEtHOW1abVZ5TG1GamRHbDJaU0E5UFQwZ1ZXbHVkRFkwS0RFcExDQW5UMlptWlhJZ2JtOTBJR0ZqZEdsMlpTY3BDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQWm1abGNpQnViM1FnWVdOMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UTTFDaUFnSUNBdkx5QmhjM05sY25Rb1lXMXZkVzUwSUQ0Z1ZXbHVkRFkwS0RBcExDQW5RVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VbktRb2dJQ0FnWkdsbklETUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJXOTFiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRXpOZ29nSUNBZ0x5OGdZWE56WlhKMEtHOW1abVZ5TG5KbGJXRnBibWx1WnlBK1BTQmhiVzkxYm5Rc0lDZEpibk4xWm1acFkybGxiblFnWTNKbFpHbDBjeWNwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UZ2dMeThnTVRnS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dOUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdZM0psWkdsMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z1kyOXVjM1FnZEc5MFlXeERiM04wT2lCMWFXNTBOalFnUFNCdlptWmxjaTV3Y21salpWQmxjbFZ1YVhRZ0tpQmhiVzkxYm5RS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNallnTHk4Z01qWUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURRS0lDQWdJQ29LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hOREl0TVRRMUNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGxVZUc0c0lIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIUnZkR0ZzUTI5emRDd0tJQ0FnSUM4dklIMHBDaUFnSUNCa2FXY2dNZ29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hORE1LSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UUXlMVEUwTlFvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2NHRjVWSGh1TENCN0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMGIzUmhiRU52YzNRc0NpQWdJQ0F2THlCOUtRb2dJQ0FnUFQwS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakUwT0MweE5UUUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MEtHOW1abVZ5TG5ObGJHeGxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCMGIzUmhiRU52YzNRc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE5UQUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQkJZMk52ZFc1MEtHOW1abVZ5TG5ObGJHeGxjaWtzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVFE0TFRFMU13b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklFRmpZMjkxYm5Rb2IyWm1aWEl1YzJWc2JHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhSdmRHRnNRMjl6ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UUTRMVEUxTkFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUVGalkyOTFiblFvYjJabVpYSXVjMlZzYkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSFJ2ZEdGc1EyOXpkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Wm1aelpYUmZiV0Z5YTJWMGNHeGhZMlV2VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94TlRjS0lDQWdJQzh2SUc5bVptVnlMbkpsYldGcGJtbHVaeUE5SUc5bVptVnlMbkpsYldGcGJtbHVaeUF0SUdGdGIzVnVkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXhPQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5QnBaaUFvYjJabVpYSXVjbVZ0WVdsdWFXNW5JRDA5UFNCVmFXNTBOalFvTUNrcElIc0tJQ0FnSUhCMWMyaHBiblFnTVRnZ0x5OGdNVGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmlibm9nWW5WNVFXNWtVbVYwYVhKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakUxT1FvZ0lDQWdMeThnYjJabVpYSXVZV04wYVhabElEMGdWV2x1ZERZMEtEQXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTXpRS0NtSjFlVUZ1WkZKbGRHbHlaVjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UWXhDaUFnSUNBdkx5QjBhR2x6TG05bVptVnljeWh2Wm1abGNrbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtHOW1abVZ5S1FvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UWTFDaUFnSUNBdkx5QlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakUyT0FvZ0lDQWdMeThnUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE5qUXRNVFk1Q2lBZ0lDQXZMeUJsYldsMFBFOW1abk5sZEZKbGRHbHlaV1ErS0NkUFptWnpaWFJTWlhScGNtVmtKeXdLSUNBZ0lDOHZJQ0FnVkhodUxuTmxibVJsY2k1aWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0J2Wm1abGNrbGtMQW9nSUNBZ0x5OGdJQ0JIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoak5EQTFZakV6TUNBdkx5QnRaWFJvYjJRZ0lrOW1abk5sZEZKbGRHbHlaV1FvWW5sMFpWc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE1qWXRNVE13Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZblY1UVc1a1VtVjBhWEpsS0FvZ0lDQWdMeThnSUNCdlptWmxja2xrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J3WVhsVWVHNDZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Wm1aelpYUmZiV0Z5YTJWMGNHeGhZMlV2VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem82VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WTJGdVkyVnNUMlptWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZVzVqWld4UFptWmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hOemNLSUNBZ0lDOHZJSEIxWW14cFl5QmpZVzVqWld4UFptWmxjaWh2Wm1abGNrbGtPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hOemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG05bVptVnljeWh2Wm1abGNrbGtLUzVsZUdsemRITXNJQ2RQWm1abGNpQnViM1FnWm05MWJtUW5LUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnZabVpsY25NZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCUFptWmxjbEpsWTI5eVpENG9leUJyWlhsUWNtVm1hWGc2SUNkdkp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlieUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRjNENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXZabVpsY25Nb2IyWm1aWEpKWkNrdVpYaHBjM1J6TENBblQyWm1aWElnYm05MElHWnZkVzVrSnlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFOW1abVZ5SUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakU0TUFvZ0lDQWdMeThnWTI5dWMzUWdiMlptWlhJZ1BTQmpiRzl1WlNoMGFHbHpMbTltWm1WeWN5aHZabVpsY2tsa0tTNTJZV3gxWlNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOW1abk5sZEY5dFlYSnJaWFJ3YkdGalpTOVBabVp6WlhSTllYSnJaWFJ3YkdGalpTNWhiR2R2TG5Sek9qRTRNQzB4T0RFS0lDQWdJQzh2SUdOdmJuTjBJRzltWm1WeUlEMGdZMnh2Ym1Vb2RHaHBjeTV2Wm1abGNuTW9iMlptWlhKSlpDa3VkbUZzZFdVcENpQWdJQ0F2THlCaGMzTmxjblFvYjJabVpYSXVZV04wYVhabElEMDlQU0JWYVc1ME5qUW9NU2tzSUNkUFptWmxjaUJ1YjNRZ1lXTjBhWFpsSnlrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpOQ0F2THlBek5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNVGd4Q2lBZ0lDQXZMeUJoYzNObGNuUW9iMlptWlhJdVlXTjBhWFpsSUQwOVBTQlZhVzUwTmpRb01Ta3NJQ2RQWm1abGNpQnViM1FnWVdOMGFYWmxKeWtLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5bVptVnlJRzV2ZENCaFkzUnBkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hPRE1LSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDA5SUc5bVptVnlMbk5sYkd4bGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBekNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRneUxURTROUW9nSUNBZ0x5OGdZWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlQU0J2Wm1abGNpNXpaV3hzWlhJc0NpQWdJQ0F2THlBZ0lDZFBibXg1SUhSb1pTQnpaV3hzWlhJZ1kyRnVJR05oYm1ObGJDY3NDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0IwYUdVZ2MyVnNiR1Z5SUdOaGJpQmpZVzVqWld3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Wm1aelpYUmZiV0Z5YTJWMGNHeGhZMlV2VDJabWMyVjBUV0Z5YTJWMGNHeGhZMlV1WVd4bmJ5NTBjem94T0RnS0lDQWdJQzh2SUdsbUlDaHZabVpsY2k1eVpXMWhhVzVwYm1jZ1BpQlZhVzUwTmpRb01Da3BJSHNLSUNBZ0lIQjFjMmhwYm5RZ01UZ2dMeThnTVRnS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCaWVpQmpZVzVqWld4UFptWmxjbDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveE9Ea3RNVGsyQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtHOW1abVZ5TG1GemMyVjBTV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUc5bVptVnlMbkpsYldGcGJtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakU1TVFvZ0lDQWdMeThnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2h2Wm1abGNpNWhjM05sZEVsa0tTd0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TVRreUNpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZabVp6WlhSZmJXRnlhMlYwY0d4aFkyVXZUMlptYzJWMFRXRnlhMlYwY0d4aFkyVXVZV3huYnk1MGN6b3hPRGt0TVRrMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUVGemMyVjBLRzltWm1WeUxtRnpjMlYwU1dRcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklHOW1abVZ5TG5KbGJXRnBibWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPakU1TkFvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UZzVMVEU1TmdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJCYzNObGRDaHZabVpsY2k1aGMzTmxkRWxrS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCdlptWmxjaTV5WlcxaGFXNXBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncGpZVzVqWld4UFptWmxjbDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qQXdDaUFnSUNBdkx5QnZabVpsY2k1aFkzUnBkbVVnUFNCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJSEpsY0d4aFkyVXlJRE0wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMlptYzJWMFgyMWhjbXRsZEhCc1lXTmxMMDltWm5ObGRFMWhjbXRsZEhCc1lXTmxMbUZzWjI4dWRITTZNakF4Q2lBZ0lDQXZMeUJ2Wm1abGNpNXlaVzFoYVc1cGJtY2dQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlERTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1qQXlDaUFnSUNBdkx5QjBhR2x6TG05bVptVnljeWh2Wm1abGNrbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtHOW1abVZ5S1FvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyWm1jMlYwWDIxaGNtdGxkSEJzWVdObEwwOW1abk5sZEUxaGNtdGxkSEJzWVdObExtRnNaMjh1ZEhNNk1UYzNDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnVZMlZzVDJabVpYSW9iMlptWlhKSlpEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjltWm5ObGRGOXRZWEpyWlhSd2JHRmpaUzlQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVoYkdkdkxuUnpPanBQWm1aelpYUk5ZWEpyWlhSd2JHRmpaUzVuWlhST1pYaDBUMlptWlhKSlpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEU1bGVIUlBabVpsY2tsa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pJd09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVibVY0ZEU5bVptVnlTV1F1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjJabWMyVjBYMjFoY210bGRIQnNZV05sTDA5bVpuTmxkRTFoY210bGRIQnNZV05sTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUc1bGVIUlBabVpsY2tsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMjVsZUhSSlpDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTVsZUhSSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dlptWnpaWFJmYldGeWEyVjBjR3hoWTJVdlQyWm1jMlYwVFdGeWEyVjBjR3hoWTJVdVlXeG5ieTUwY3pveU1Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbTVsZUhSUFptWmxja2xrTG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5bVpuTmxkRjl0WVhKclpYUndiR0ZqWlM5UFptWnpaWFJOWVhKclpYUndiR0ZqWlM1aGJHZHZMblJ6T2pJd09Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFNWxlSFJQWm1abGNrbGtLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRZ0FCQ1lEQm01bGVIUkpaQUZ2QkJVZmZIVXhHUlJFTVJoQkFDdUNCUVJjQVNtSkJIcjRiZUlFMnlva3N3UjJjaytKQk1wNGdudzJHZ0NPQlFBVUFFQUEwZ0dCQWV3QWdBUzRSSHMyTmhvQWpnRUFBUUFvSW1jaVF6WWFBVWtWSXhKRUZ6RVdJZ2xKT0JBaUVrUTRCeklLRWtTeE1nb2tzaEt5RkxJUkpiSVFKTElCc3lKRE5ob0JTUlVqRWtRWE5ob0NTUlVqRWtRWE5ob0RTUlVqRWtRWE1SYUJBZ2xKT0JBbEVrUXhGaUlKU1RnUUloSkVTd0U0RVVzRkVrc0NPQlF5Q2hJUVR3STRFa3NFRWhCRU9BY3lDaEpFU3dGRVNVUWtLR1ZFZ0FJQUlERUFVRThFRm9BQ0FDcE1VRThFRmt4TEFWQk1VRThERmxBaUZsQk1VRXNCRmlsTEFWQkp2RWhQQXI5TUlnZ29UR2NxVEZDd0lrTTJHZ0ZIQWhVakVrUVhOaG9DU1U0Q1NSVWpFa1FYTVJZaUNVazRFQ0lTUkU4Q0ZpbE1VRWxPQTBtOVJRRkVTYjVJVGdKSmdTSWp1aGNpRWtSTEEwUkpnUklqdWhkSlN3VVBSRXlCR2lPNkYwc0VDMHNDT0FjeUNoSlBBemdJU3dJU0VFU3hTd0lrV1VzREZVc0VUZ0pTVndJQXNnZXlDQ0t5RUNTeUFiTlBBZ2tXWEJKSmdSSmJRQUFFSkJaY0lrc0JTYnhJVEw4eEFESUhGa3hMQTFCTEJGQk1VSUFFeEFXeE1FeFFzQ0pETmhvQlNSVWpFa1FYRmlsTVVFY0N2VVVCUkVtK1NFbFBBa21CSWlPNkZ5SVNSREVBU3dJa1dVc0RGVThFVGdKU1Z3SUFFa1NCRWlPNkYwbEJBQm14U3dLQkFpTzZGekVBU3dLeUVySVVzaEVsc2hBa3NnR3pKQlpMQWtzQlhDSk1YQkpMQTBtOFNFeS9Ja01rS0dWRUZpcE1VTEFpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6Ik9mZnNldFJldGlyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIzIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
