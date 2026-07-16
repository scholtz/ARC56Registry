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

namespace Arc56.Generated.Algorand_Developer_Retreat.smart_wallet_for_agent_to_agent_interaction.Listing_672a1061
{


    public class ListingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ListingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ListingInfo : AVMObjectType
            {
                public ulong Id { get; set; }

                public ulong AssetId { get; set; }

                public string Name { get; set; }

                public string UnitName { get; set; }

                public ulong Decimals { get; set; }

                public Algorand.Address Seller { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDecimals.From(Decimals);
                    ret.AddRange(vDecimals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ListingInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ListingInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDecimals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDecimals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDecimals = vDecimals.ToValue();
                    if (valueDecimals is ulong vDecimalsValue) { ret.Decimals = vDecimalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ListingInfo);
                }
                public bool Equals(ListingInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ListingInfo left, ListingInfo right)
                {
                    return EqualityComparer<ListingInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(ListingInfo left, ListingInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///create the listing application
        ///</summary>
        /// <param name="asset">the asa ID that is to be sold </param>
        /// <param name="seller">the wallet of the account selling the asset </param>
        public async Task CreateApplication(ulong asset, Algorand.Address seller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 124, 231, 216, 184 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, sellerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong asset, Algorand.Address seller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 124, 231, 216, 184 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, sellerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="price"> </param>
        public async Task RecordNegotiatedPrice(ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 40, 117, 13 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            var result = await base.CallApp(new List<object> { abiHandle, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordNegotiatedPrice_Transactions(ulong price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 40, 117, 13 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);

            return await base.MakeTransactionList(new List<object> { abiHandle, priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///optin tells the contract to opt into an asa
        ///</summary>
        /// <param name="payment">The payment transaction </param>
        /// <param name="asset">The asset to be opted into </param>
        public async Task OptinToListingAsset(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 198, 11, 209, 132 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, payment, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptinToListingAsset_Transactions(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 198, 11, 209, 132 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment">- the payment for purchasing the asset </param>
        /// <param name="buyer">- the buyer of the asset </param>
        public async Task Purchase(PaymentTransaction payment, Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 82, 201, 6, 174 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            var result = await base.CallApp(new List<object> { abiHandle, payment, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Purchase_Transactions(PaymentTransaction payment, Algorand.Address buyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 82, 201, 6, 174 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, buyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes the app and returns the asset/mbr to the seller
        ///</summary>
        /// <param name="caller"> </param>
        public async Task Delist(Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 232, 99, 67 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delist_Transactions(Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 232, 99, 67 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ListingInfo> GetInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 140, 105, 4 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ListingInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 140, 105, 4 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGlzdGluZyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMaXN0aW5nSW5mbyI6W3sibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0SUQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1bml0TmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJkZWNpbWFscyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzZWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOiJjcmVhdGUgdGhlIGxpc3RpbmcgYXBwbGljYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJ0aGUgYXNhIElEIHRoYXQgaXMgdG8gYmUgc29sZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGxlciIsImRlc2MiOiJ0aGUgd2FsbGV0IG9mIHRoZSBhY2NvdW50IHNlbGxpbmcgdGhlIGFzc2V0IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZE5lZ290aWF0ZWRQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRpblRvTGlzdGluZ0Fzc2V0IiwiZGVzYyI6Im9wdGluIHRlbGxzIHRoZSBjb250cmFjdCB0byBvcHQgaW50byBhbiBhc2EiLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiJUaGUgcGF5bWVudCB0cmFuc2FjdGlvbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiVGhlIGFzc2V0IHRvIGJlIG9wdGVkIGludG8iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHVyY2hhc2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiItIHRoZSBwYXltZW50IGZvciBwdXJjaGFzaW5nIHRoZSBhc3NldCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyIiwiZGVzYyI6Ii0gdGhlIGJ1eWVyIG9mIHRoZSBhc3NldCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsaXN0IiwiZGVzYyI6IkRlbGV0ZXMgdGhlIGFwcCBhbmQgcmV0dXJucyB0aGUgYXNzZXQvbWJyIHRvIHRoZSBzZWxsZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0SW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCxzdHJpbmcsc3RyaW5nLHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6Ikxpc3RpbmdJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE4OCwyMDRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IERlbGV0ZUFwcGxpY2F0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2LDIyOSwyNTUsMjcxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMyXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBvcHRlZCBpbnRvIGFzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcxLDU2Niw1NzMsNTgwXSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA5LDE5MSwyMDcsMjMyLDI1OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTMsMzgxLDM5OCw0MTIsNDI5LDQzNiw0NjAsNDY0LDQ2OCw1MDYsNTE0LDUxOCw1MjIsNTI2LDU1OSw1NjMsNTcwLDU3Nyw1ODRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTUsMzE1LDM3Nyw1MDJdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IGJlIGNhbGxlZCBmcm9tIHRoZSBmYWN0b3J5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEwXSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgc2VsbGVyIGNhbiBkZWxpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjldLCJlcnJvck1lc3NhZ2UiOiJvcHRpblRvTGlzdGluZ0Fzc2V0IG11c3QgYmUgY2FsbGVkIGJ5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDhdLCJlcnJvck1lc3NhZ2UiOiJwYXltZW50IGFtb3VudCBtdXN0IGJlIGFzc2V0IG9wdGluIG1pbiBiYWxhbmNlICsgbWluIGFjY291bnQgbWJyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM3XSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCByZWNlaXZlciBtdXN0IGJlIHRoaXMgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgyXSwiZXJyb3JNZXNzYWdlIjoicHJpY2UgaGFzbid0IGJlZW4gbmVnb3RpYXRlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTcsMjQyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRFFnTlFvZ0lDQWdZbmwwWldOaWJHOWpheUFpWVhOelpYUWlJQ0p6Wld4c1pYSWlJQ0p1WldkdmRHbGhkR1ZrWDNCeWFXTmxJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWMzUmhiblJ6TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamIyNXpkQ0JPUlVkUFZFbEJWRVZFWDFCU1NVTkZYMHRGV1NBOUlDZHVaV2R2ZEdsaGRHVmtYM0J5YVdObEp3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJtVm5iM1JwWVhSbFpGOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJRzVsWjI5MGFXRjBaV1JRY21salpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREFzSUd0bGVUb2dUa1ZIVDFSSlFWUkZSRjlRVWtsRFJWOUxSVmtnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUR2x6ZEdsdVp5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGczWTJVM1pEaGlPQ0F3ZUdFMk1qZzNOVEJrSURCNFl6WXdZbVF4T0RRZ01IZzFNbU01TURaaFpTQXdlRFk0WlRnMk16UXpJREI0TURBNFl6WTVNRFFnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmloaGMzTmxkQ3hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxZMjl5WkU1bFoyOTBhV0YwWldSUWNtbGpaU2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWIzQjBhVzVVYjB4cGMzUnBibWRCYzNObGRDaHdZWGtzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQjFjbU5vWVhObEtIQmhlU3hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxiR2x6ZENoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEVsdVptOG9LU2gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBMR0ZrWkhKbGMzTXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBMUlHMWhhVzVmY21WamIzSmtUbVZuYjNScFlYUmxaRkJ5YVdObFgzSnZkWFJsUURZZ2JXRnBibDl2Y0hScGJsUnZUR2x6ZEdsdVowRnpjMlYwWDNKdmRYUmxRRGNnYldGcGJsOXdkWEpqYUdGelpWOXliM1YwWlVBNElHMWhhVzVmWkdWc2FYTjBYM0p2ZFhSbFFEa2diV0ZwYmw5blpYUkpibVp2WDNKdmRYUmxRREV3Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUR2x6ZEdsdVp5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBTVzVtYjE5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJKYm1adkNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklEVUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpZd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWXdJQzh2SURZd0NpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaR1ZzYVhOMFgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjBSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SnlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh6SUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFeHBjM1JwYm1jZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjBSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SnlCOUtRb2dJQ0FnWTJGc2JITjFZaUJrWld4cGMzUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNIVnlZMmhoYzJWZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRuSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYek1nTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RHbHpkR2x1WnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZEVaV3hsZEdWQmNIQnNhV05oZEdsdmJpY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2NIVnlZMmhoYzJVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYjNCMGFXNVViMHhwYzNScGJtZEJjM05sZEY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdjSFZpYkdsaklHOXdkR2x1Vkc5TWFYTjBhVzVuUVhOelpYUW9jR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxDQmhjM05sZERvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJNYVhOMGFXNW5JR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM0IwYVc1VWIweHBjM1JwYm1kQmMzTmxkQ2h3WVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJR0Z6YzJWME9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJR05oYkd4emRXSWdiM0IwYVc1VWIweHBjM1JwYm1kQmMzTmxkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV052Y21ST1pXZHZkR2xoZEdWa1VISnBZMlZmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklIQjFZbXhwWXlCeVpXTnZjbVJPWldkdmRHbGhkR1ZrVUhKcFkyVW9jSEpwWTJVNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVEdsemRHbHVaeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklIQjFZbXhwWXlCeVpXTnZjbVJPWldkdmRHbGhkR1ZrVUhKcFkyVW9jSEpwWTJVNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdZMkZzYkhOMVlpQnlaV052Y21ST1pXZHZkR2xoZEdWa1VISnBZMlVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUV4cGMzUnBibWNnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQmMzTmxkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Z0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VEdsemRHbHVaeTVqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWhoYzNObGREb2dkV2x1ZERZMExDQnpaV3hzWlhJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemd0TnprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZWE56WlhRNklFRnpjMlYwTENCelpXeHNaWEk2SUVGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnWVhOelpYSjBLRWRzYjJKaGJDNWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrbGtJQ0U5UFNBd0xDQk5WVk5VWDBKRlgwTkJURXhGUkY5R1VrOU5YMFpCUTFSUFVsa3BDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJRzExYzNRZ1ltVWdZMkZzYkdWa0lHWnliMjBnZEdobElHWmhZM1J2Y25rS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5OMFlXNTBjeTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTI5dWMzUWdRVk5UUlZSZlMwVlpJRDBnSjJGemMyVjBKd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZWE56WlhRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUIwYUdsekxtRnpjMlYwTG5aaGJIVmxJRDBnWVhOelpYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuTjBZVzUwY3k1MGN6bzVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyOXVjM1FnVTBWTVRFVlNYMHRGV1NBOUlDZHpaV3hzWlhJbkNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKelpXeHNaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QjBhR2x6TG5ObGJHeGxjaTUyWVd4MVpTQTlJSE5sYkd4bGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VEdsemRHbHVaeTV5WldOdmNtUk9aV2R2ZEdsaGRHVmtVSEpwWTJVb2NISnBZMlU2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LY21WamIzSmtUbVZuYjNScFlYUmxaRkJ5YVdObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWTI5eVpFNWxaMjkwYVdGMFpXUlFjbWxqWlNod2NtbGpaVG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbk5sYkd4bGNpNTJZV3gxWlM1dVlYUnBkbVVzSUUxVlUxUmZRa1ZmUTBGTVRFVkVYMFpTVDAxZlJrRkRWRTlTV1NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZibk4wWVc1MGN5NTBjem81Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMjl1YzNRZ1UwVk1URVZTWDB0RldTQTlJQ2R6Wld4c1pYSW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWMyVnNiR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxuTmxiR3hsY2k1MllXeDFaUzV1WVhScGRtVXNJRTFWVTFSZlFrVmZRMEZNVEVWRVgwWlNUMDFmUmtGRFZFOVNXU2tLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JYVnpkQ0JpWlNCallXeHNaV1FnWm5KdmJTQjBhR1VnWm1GamRHOXllUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVjM1JoYm5SekxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiMjV6ZENCT1JVZFBWRWxCVkVWRVgxQlNTVU5GWDB0RldTQTlJQ2R1WldkdmRHbGhkR1ZrWDNCeWFXTmxKd29nSUNBZ1lubDBaV05mTWlBdkx5QWlibVZuYjNScFlYUmxaRjl3Y21salpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUhSb2FYTXVibVZuYjNScFlYUmxaRkJ5YVdObExuWmhiSFZsSUQwZ2NISnBZMlVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9reHBjM1JwYm1jdWIzQjBhVzVVYjB4cGMzUnBibWRCYzNObGRDaHdZWGx0Wlc1ME9pQjFhVzUwTmpRc0lHRnpjMlYwT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q205d2RHbHVWRzlNYVhOMGFXNW5RWE56WlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiM0IwYVc1VWIweHBjM1JwYm1kQmMzTmxkQ2h3WVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJR0Z6YzJWME9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU53b2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVFXUmtjbVZ6Y3l3Z0oyOXdkR2x1Vkc5TWFYTjBhVzVuUVhOelpYUWdiWFZ6ZENCaVpTQmpZV3hzWldRZ1lua2dZM0psWVhSdmNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM0IwYVc1VWIweHBjM1JwYm1kQmMzTmxkQ0J0ZFhOMElHSmxJR05oYkd4bFpDQmllU0JqY21WaGRHOXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUNkd1lYbHRaVzUwSUhKbFkyVnBkbVZ5SUcxMWMzUWdZbVVnZEdocGN5QmhjSEFuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YldWdWRDQnlaV05sYVhabGNpQnRkWE4wSUdKbElIUm9hWE1nWVhCd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams1Q2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNWhiVzkxYm5RZ1BUMDlJQ2hIYkc5aVlXd3VZWE56WlhSUGNIUkpiazFwYmtKaGJHRnVZMlVnS2lBeUtTd2dKM0JoZVcxbGJuUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1lYTnpaWFFnYjNCMGFXNGdiV2x1SUdKaGJHRnVZMlVnS3lCdGFXNGdZV05qYjNWdWRDQnRZbkluS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHZHNiMkpoYkNCQmMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNvS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YldWdWRDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCaGMzTmxkQ0J2Y0hScGJpQnRhVzRnWW1Gc1lXNWpaU0FySUcxcGJpQmhZMk52ZFc1MElHMWljZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ERXRNVEE0Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFFLSUNBZ0lDOHZJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURFdE1UQTNDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05nb2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNUzB4TURnS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTWFYTjBhVzVuTG5CMWNtTm9ZWE5sS0hCaGVXMWxiblE2SUhWcGJuUTJOQ3dnWW5WNVpYSTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHdkWEpqYUdGelpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNExURXhPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMFJsYkdWMFpVRndjR3hwWTJGMGFXOXVKeUI5S1FvZ0lDQWdMeThnY0hWaWJHbGpJSEIxY21Ob1lYTmxLSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2dZblY1WlhJNklFRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qQUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lFMVZVMVJmUWtWZlEwRk1URVZFWDBaU1QwMWZSa0ZEVkU5U1dTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnRkWE4wSUdKbElHTmhiR3hsWkNCbWNtOXRJSFJvWlNCbVlXTjBiM0o1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjV6ZEdGdWRITXVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR052Ym5OMElFNUZSMDlVU1VGVVJVUmZVRkpKUTBWZlMwVlpJRDBnSjI1bFoyOTBhV0YwWldSZmNISnBZMlVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlibVZuYjNScFlYUmxaRjl3Y21salpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWJtVm5iM1JwWVhSbFpGQnlhV05sTG5aaGJIVmxJRDRnTUN3Z1VGSkpRMFZmVGs5VVgwNUZSMDlVU1VGVVJVUXBDaUFnSUNCaGMzTmxjblFnTHk4Z2NISnBZMlVnYUdGemJpZDBJR0psWlc0Z2JtVm5iM1JwWVhSbFpDQjVaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXpDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1elpXNWtaWElnUFQwOUlFZHNiMkpoYkM1amNtVmhkRzl5UVdSa2NtVnpjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkQzVoYlc5MWJuUWdQVDA5SUhSb2FYTXVibVZuYjNScFlYUmxaRkJ5YVdObExuWmhiSFZsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZibk4wWVc1MGN5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMjl1YzNRZ1RrVkhUMVJKUVZSRlJGOVFVa2xEUlY5TFJWa2dQU0FuYm1WbmIzUnBZWFJsWkY5d2NtbGpaU2NLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVaV2R2ZEdsaGRHVmtYM0J5YVdObElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNWhiVzkxYm5RZ1BUMDlJSFJvYVhNdWJtVm5iM1JwWVhSbFpGQnlhV05sTG5aaGJIVmxLUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qVUtJQ0FnSUM4dklHRnpjMlZ5ZENod1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1emRHRnVkSE11ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOdmJuTjBJRUZUVTBWVVgwdEZXU0E5SUNkaGMzTmxkQ2NLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhjM05sZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QnBaaUFvWW5WNVpYSXVhWE5QY0hSbFpFbHVLSFJvYVhNdVlYTnpaWFF1ZG1Gc2RXVXBLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjNZWEFLSUNBZ0lHRnpjMlYwWDJodmJHUnBibWRmWjJWMElFRnpjMlYwUW1Gc1lXNWpaUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJ3ZFhKamFHRnpaVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjdE5UVUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRMnh2YzJWVWJ6b2dZblY1WlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1luVjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJSFJvYVhNdVlYTnpaWFF1ZG1Gc2RXVXVZbUZzWVc1alpTaEhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUIwYUdsekxtRnpjMlYwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nZEdocGN5NWhjM05sZEM1MllXeDFaUzVpWVd4aGJtTmxLRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOektTd0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNXpkR0Z1ZEhNdWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnZibk4wSUVGVFUwVlVYMHRGV1NBOUlDZGhjM05sZENjS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYzNObGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJoYzNObGRFRnRiM1Z1ZERvZ2RHaHBjeTVoYzNObGRDNTJZV3gxWlM1aVlXeGhibU5sS0Vkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpLU3dLSUNBZ0lHRnpjMlYwWDJodmJHUnBibWRmWjJWMElFRnpjMlYwUW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ2IzQjBaV1FnYVc1MGJ5QmhjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1YzNSaGJuUnpMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYjI1emRDQkJVMU5GVkY5TFJWa2dQU0FuWVhOelpYUW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlYTnpaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJEYkc5elpWUnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0xUVTBDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRU5zYjNObFZHODZJR0oxZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHSjFlV1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUIwYUdsekxtRnpjMlYwTG5aaGJIVmxMbUpoYkdGdVkyVW9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNcExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nZEdocGN5NWhjM05sZEM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0JwYm5Salh6SWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNMVFUxQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVOc2IzTmxWRzg2SUdKMWVXVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJR0oxZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCMGFHbHpMbUZ6YzJWMExuWmhiSFZsTG1KaGJHRnVZMlVvUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXBMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ2RHaHBjeTVoYzNObGRDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbkIxY21Ob1lYTmxYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFdE5qZ0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQjBhR2x6TG5ObGJHeGxjaTUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2dkR2hwY3k1elpXeHNaWEl1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbE9pQjBhR2x6TG1GemMyVjBMblpoYkhWbExtNWhiV1V1ZEc5VGRISnBibWNvS1NBcklDY2dVMjlzWkNjc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWMzUmhiblJ6TG5Sek9qa0tJQ0FnSUM4dklHVjRjRzl5ZENCamIyNXpkQ0JUUlV4TVJWSmZTMFZaSUQwZ0ozTmxiR3hsY2ljS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6Wld4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5ObGJHeGxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNXpkR0Z1ZEhNdWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnZibk4wSUVGVFUwVlVYMHRGV1NBOUlDZGhjM05sZENjS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYzNObGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJ1YjNSbE9pQjBhR2x6TG1GemMyVjBMblpoYkhWbExtNWhiV1V1ZEc5VGRISnBibWNvS1NBcklDY2dVMjlzWkNjc0NpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFRtRnRaUW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ2NIVnphR0o1ZEdWeklDSWdVMjlzWkNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNiM05sVW1WdFlXbHVaR1Z5Vkc4S0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRXROamNLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUIwYUdsekxuTmxiR3hsY2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nZEdocGN5NXpaV3hzWlhJdWRtRnNkV1V1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxPaUIwYUdsekxtRnpjMlYwTG5aaGJIVmxMbTVoYldVdWRHOVRkSEpwYm1jb0tTQXJJQ2NnVTI5c1pDY3NDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeExUWTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dkR2hwY3k1elpXeHNaWEl1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJSFJvYVhNdWMyVnNiR1Z5TG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJQ0FnYm05MFpUb2dkR2hwY3k1aGMzTmxkQzUyWVd4MVpTNXVZVzFsTG5SdlUzUnlhVzVuS0NrZ0t5QW5JRk52YkdRbkxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJHbHpkR2x1WjE5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTWFYTjBhVzVuTG1SbGJHbHpkQ2hqWVd4c1pYSTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGtaV3hwYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TlMweE16WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZEVaV3hsZEdWQmNIQnNhV05oZEdsdmJpY2dmU2tLSUNBZ0lDOHZJR1JsYkdsemRDaGpZV3hzWlhJNklFRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lFMVZVMVJmUWtWZlEwRk1URVZFWDBaU1QwMWZSa0ZEVkU5U1dTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnRkWE4wSUdKbElHTmhiR3hsWkNCbWNtOXRJSFJvWlNCbVlXTjBiM0o1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjV6ZEdGdWRITXVkSE02T1FvZ0lDQWdMeThnWlhod2IzSjBJR052Ym5OMElGTkZURXhGVWw5TFJWa2dQU0FuYzJWc2JHVnlKd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luTmxiR3hsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YzJWc2JHVnlMblpoYkhWbElEMDlQU0JqWVd4c1pYSXNJRTlPVEZsZlUwVk1URVZTWDBOQlRsOUVSVXhKVTFRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCMGFHVWdjMlZzYkdWeUlHTmhiaUJrWld4cGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5c2FYTjBhVzVuWDJOdmJuUnlZV04wTDJOdmJuTjBZVzUwY3k1MGN6bzVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyOXVjM1FnVTBWTVRFVlNYMHRGV1NBOUlDZHpaV3hzWlhJbkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzJWc2JHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKelpXeHNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVjM1JoYm5SekxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiMjV6ZENCQlUxTkZWRjlMUlZrZ1BTQW5ZWE56WlhRbkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVhOelpYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWMzUmhiblJ6TG5Sek9qa0tJQ0FnSUM4dklHVjRjRzl5ZENCamIyNXpkQ0JUUlV4TVJWSmZTMFZaSUQwZ0ozTmxiR3hsY2ljS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6Wld4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUdsMGVHNHVjM1ZpYldsMFIzSnZkWEFvWVhOelpYUlVjbUZ1YzJabGNpd2djR0Y1YldWdWRDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFEyeHZjMlZVYndvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTUMweE5EVUtJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBWSEpoYm5ObVpYSWdQU0JwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUIwYUdsekxuTmxiR3hsY2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFEyeHZjMlZVYnpvZ2RHaHBjeTV6Wld4c1pYSXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNCNFptVnlRWE56WlhRNklIUm9hWE11WVhOelpYUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUgwcENpQWdJQ0JwYm5Salh6SWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EUUtJQ0FnSUM4dklHWmxaVG9nTUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJR2wwZUc0dWMzVmliV2wwUjNKdmRYQW9ZWE56WlhSVWNtRnVjMlpsY2l3Z2NHRjViV1Z1ZENrS0lDQWdJR2wwZUc1ZmJtVjRkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiRzl6WlZKbGJXRnBibVJsY2xSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTnkweE5UQUtJQ0FnSUM4dklHTnZibk4wSUhCaGVXMWxiblFnUFNCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0JqYkc5elpWSmxiV0ZwYm1SbGNsUnZPaUIwYUdsekxuTmxiR3hsY2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGtLSUNBZ0lDOHZJR1psWlRvZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUdsMGVHNHVjM1ZpYldsMFIzSnZkWEFvWVhOelpYUlVjbUZ1YzJabGNpd2djR0Y1YldWdWRDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YkdsemRHbHVaMTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBNYVhOMGFXNW5MbWRsZEVsdVptOG9LU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJOQ3dnWW5sMFpYTXNJR0o1ZEdWekxDQjFhVzUwTmpRc0lHSjVkR1Z6T2dwblpYUkpibVp2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVGdLSUNBZ0lDOHZJR2xrT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRdWFXUXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5OMFlXNTBjeTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTI5dWMzUWdRVk5UUlZSZlMwVlpJRDBnSjJGemMyVjBKd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnpjMlYwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhjM05sZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiR2x6ZEdsdVoxOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdibUZ0WlRvZ1UzUnlhVzVuS0hSb2FYTXVZWE56WlhRdWRtRnNkV1V1Ym1GdFpTa3NDaUFnSUNCaGMzTmxkRjl3WVhKaGJYTmZaMlYwSUVGemMyVjBUbUZ0WlFvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWMElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMnhwYzNScGJtZGZZMjl1ZEhKaFkzUXZZMjl1YzNSaGJuUnpMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYjI1emRDQkJVMU5GVkY5TFJWa2dQU0FuWVhOelpYUW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlYTnpaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyeHBjM1JwYm1kZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qRUtJQ0FnSUM4dklIVnVhWFJPWVcxbE9pQlRkSEpwYm1jb2RHaHBjeTVoYzNObGRDNTJZV3gxWlM1MWJtbDBUbUZ0WlNrc0NpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGRDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlzYVhOMGFXNW5YMk52Ym5SeVlXTjBMMk52Ym5OMFlXNTBjeTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTI5dWMzUWdRVk5UUlZSZlMwVlpJRDBnSjJGemMyVjBKd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnpjMlYwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXNhWE4wYVc1blgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXlDaUFnSUNBdkx5QmtaV05wYldGc2N6b2dkR2hwY3k1aGMzTmxkQzUyWVd4MVpTNWtaV05wYldGc2N5d0tJQ0FnSUdGemMyVjBYM0JoY21GdGMxOW5aWFFnUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWMzUmhiblJ6TG5Sek9qa0tJQ0FnSUM4dklHVjRjRzl5ZENCamIyNXpkQ0JUUlV4TVJWSmZTMFZaSUQwZ0ozTmxiR3hsY2ljS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6Wld4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJ4cGMzUnBibWRmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRjdE1UWTBDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQnBaRG9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTG1sa0xBb2dJQ0FnTHk4Z0lDQmhjM05sZEVsRU9pQjBhR2x6TG1GemMyVjBMblpoYkhWbExtbGtMQW9nSUNBZ0x5OGdJQ0J1WVcxbE9pQlRkSEpwYm1jb2RHaHBjeTVoYzNObGRDNTJZV3gxWlM1dVlXMWxLU3dLSUNBZ0lDOHZJQ0FnZFc1cGRFNWhiV1U2SUZOMGNtbHVaeWgwYUdsekxtRnpjMlYwTG5aaGJIVmxMblZ1YVhST1lXMWxLU3dLSUNBZ0lDOHZJQ0FnWkdWamFXMWhiSE02SUhSb2FYTXVZWE56WlhRdWRtRnNkV1V1WkdWamFXMWhiSE1zQ2lBZ0lDQXZMeUFnSUhObGJHeGxjam9nZEdocGN5NXpaV3hzWlhJdWRtRnNkV1VzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRUVCU1lEQldGemMyVjBCbk5sYkd4bGNoQnVaV2R2ZEdsaGRHVmtYM0J5YVdObE1SaEFBQU1xSW1jeEcwRUFNWUlHQkh6bjJMZ0VwaWgxRFFUR0M5R0VCRkxKQnE0RWFPaGpRd1FBakdrRU5ob0FqZ1lBcHdDWEFIMEFZd0JUQUFJaVF6RVpGRVF4R0VTSUFibFBCUlpQQlJaTEJSVVdWd1lDVHdaUVN3VVZGbGNHQWs4R1VFOEZGazhFVHdSUWdBSUFQRkJMQXhXQlBBZ1dWd1lDVUV4UVR3TlFUd0pRVEZDQUJCVWZmSFZNVUxBalF6RVpKUkpFTVJoRU5ob0JpQUVvSTBNeEdTVVNSREVZUkRFV0l3bEpPQkFqRWtRMkdnR0lBSkVqUXpFWkZFUXhHRVF4RmlNSlNUZ1FJeEpFTmhvQkY0Z0FSeU5ETVJrVVJERVlSRFlhQVJlSUFDY2pRekVaRkVReEdCUkVOaG9CRjhBd05ob0NpQUFDSTBPS0FnQXlEVVFvaS81bktZdi9aNG1LQVFBeEFDSXBaVVFTUkNxTC8yZUppZ0lBTVFBeUNSSkVpLzQ0QnpJS0VrU0wvamdJTWhDQkFnc1NSTEV5Q292L3NoRWlzaEt5RkNTeUVDS3lBYk9KaWdJQU1RQXlDUkpFSWlwbFJFU0wvamdBTWdrU1JJditPQWdpS21WRUVrU0wvamdITWdvU1JDSW9aVVNMLzB4d0FFVUJRUUFoc1RJS0lpaGxSSEFBUkNJb1pVU3lFYklTaS8reUZJdi9zaFVrc2hBaXNnR3pzU0lwWlVRaUtXVkVJaWhsUkhFRVJJQUZJRk52YkdSUXNnV3lDYklISTdJUUlySUJzNG1LQVFBeEFESUpFa1FpS1dWRWkvOFNSQ0lwWlVRaUtXVkVJaWhsUkNJcFpVU3hUTElSVExJVlRMSVVKTElRSXJJQnRySUpJN0lRSXJJQnM0a3lDQ0lvWlVRaUtHVkVjUVJFSWlobFJIRURSQ0lvWlVSeEFVUWlLV1ZFaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjUsInBhdGNoIjozLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
