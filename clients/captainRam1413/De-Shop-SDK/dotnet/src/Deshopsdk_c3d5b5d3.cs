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

namespace Arc56.Generated.captainRam1413.De_Shop_SDK.Deshopsdk_c3d5b5d3
{


    public class DeshopsdkProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DeshopsdkProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ListingRecord : AVMObjectType
            {
                public Algorand.Address Seller { get; set; }

                public ulong Price { get; set; }

                public Algorand.Address Creator { get; set; }

                public ulong RoyaltyBps { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoyaltyBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRoyaltyBps.From(RoyaltyBps);
                    ret.AddRange(vRoyaltyBps.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ListingRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ListingRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoyaltyBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoyaltyBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoyaltyBps = vRoyaltyBps.ToValue();
                    if (valueRoyaltyBps is ulong vRoyaltyBpsValue) { ret.RoyaltyBps = vRoyaltyBpsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ListingRecord);
                }
                public bool Equals(ListingRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ListingRecord left, ListingRecord right)
                {
                    return EqualityComparer<ListingRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ListingRecord left, ListingRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="mbr_pay"> </param>
        public async Task SetupAsset(PaymentTransaction mbr_pay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 187, 36, 14, 151 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, mbr_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetupAsset_Transactions(PaymentTransaction mbr_pay, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 187, 36, 14, 151 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, mbr_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="axfer"> </param>
        /// <param name="price"> </param>
        /// <param name="creator"> </param>
        /// <param name="royalty_bps"> </param>
        public async Task ListAsset(AssetTransferTransaction axfer, ulong price, Algorand.Address creator, ulong royalty_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 23, 213, 168, 50 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var royalty_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); royalty_bpsAbi.From(royalty_bps);

            var result = await base.CallApp(new List<object> { abiHandle, axfer, priceAbi, creatorAbi, royalty_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ListAsset_Transactions(AssetTransferTransaction axfer, ulong price, Algorand.Address creator, ulong royalty_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 23, 213, 168, 50 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var royalty_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); royalty_bpsAbi.From(royalty_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, axfer, priceAbi, creatorAbi, royalty_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="payment"> </param>
        public async Task BuyAsset(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 52, 190, 121, 210 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyAsset_Transactions(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 52, 190, 121, 210 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task CancelListing(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 57, 212, 188 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelListing_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 57, 212, 188 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVzaG9wc2RrIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ikxpc3RpbmdSZWNvcmQiOlt7Im5hbWUiOiJzZWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJveWFsdHlfYnBzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXR1cEFzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imxpc3RBc3NldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJveWFsdHlfYnBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eUFzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbExpc3RpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTldLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGxpc3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6ImF4ZmVyIG5vdCB0byBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4Nl0sImVycm9yTWVzc2FnZSI6Imluc3VmZmljaWVudCBwYXltZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4LDE0MSwxNTgsMjIxLDM4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MV0sImVycm9yTWVzc2FnZSI6Im11c3QgYmUgc2VuZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0XSwiZXJyb3JNZXNzYWdlIjoibXVzdCBwYXkgMC4xIEFMR08gZm9yIEFTQSBNQlIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzNdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IHRyYW5zZmVyIDEgYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDYsMzkzXSwiZXJyb3JNZXNzYWdlIjoibm90IGxpc3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwM10sImVycm9yTWVzc2FnZSI6Im5vdCBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OF0sImVycm9yTWVzc2FnZSI6InBheSBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2XSwiZXJyb3JNZXNzYWdlIjoicGF5IGV4YWN0IG1iciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NV0sImVycm9yTWVzc2FnZSI6InByaWNlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NF0sImVycm9yTWVzc2FnZSI6InNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OSwyMzNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0NBMENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE5tTTJPVGN6TnpRMVpnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUbzVDaUFnSUNBdkx5QmpiR0Z6Y3lCRVpYTm9iM0J6Wkdzb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFekNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVlqSTBNR1U1TnlBd2VERTNaRFZoT0RNeUlEQjRNelJpWlRjNVpESWdNSGhpTmpNNVpEUmlZeUF2THlCdFpYUm9iMlFnSW5ObGRIVndRWE56WlhRb2RXbHVkRFkwTEhCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKc2FYTjBRWE56WlhRb1lYaG1aWElzZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1KMWVVRnpjMlYwS0hWcGJuUTJOQ3h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJGdVkyVnNUR2x6ZEdsdVp5aDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhObGRIVndRWE56WlhRZ2JHbHpkRUZ6YzJWMElHSjFlVUZ6YzJWMElHTmhibU5sYkV4cGMzUnBibWNLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE16b0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1SbGMyaHZjSE5rYXk1amIyNTBjbUZqZEM1RVpYTm9iM0J6WkdzdWMyVjBkWEJCYzNObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEhWd1FYTnpaWFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxjMmh2Y0hOa2F5OWpiMjUwY21GamRDNXdlVG94TlMweE5nb2dJQ0FnTHk4Z0l5QkRiMjUwY21GamRDQnVaV1ZrY3lCMGJ5QnZjSFF0YVc0Z2RHOGdkR2hsSUdGemMyVjBMaUJTWlhGMWFYSmxjeUF4TURBc01EQXdJRUZNUjA4Z1ptOXlJRTFDVWlCc2IyZHBZeTRLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZbkpmY0dGNUxuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0p3WVhrZ1pYaGhZM1FnYldKeUlnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY0dGNUlHVjRZV04wSUcxaWNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdZWE56WlhKMElHMWljbDl3WVhrdVlXMXZkVzUwSUQwOUlGVkpiblEyTkNneE1EQmZNREF3S1N3Z0ltMTFjM1FnY0dGNUlEQXVNU0JCVEVkUElHWnZjaUJCVTBFZ1RVSlNJZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdGRYTjBJSEJoZVNBd0xqRWdRVXhIVHlCbWIzSWdRVk5CSUUxQ1Vnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUb3hPQzB5TXdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TUN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxjMmh2Y0hOa2F5OWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnphRzl3YzJSckwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWemFHOXdjMlJyTDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pYTm9iM0J6WkdzdlkyOXVkSEpoWTNRdWNIazZNaklLSUNBZ0lDOHZJR1psWlQwd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlhOb2IzQnpaR3N2WTI5dWRISmhZM1F1Y0hrNk1UZ3RNak1LSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnphRzl3YzJSckwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdWemFHOXdjMlJyTG1OdmJuUnlZV04wTGtSbGMyaHZjSE5rYXk1c2FYTjBRWE56WlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHNhWE4wUVhOelpYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnphRzl3YzJSckwyTnZiblJ5WVdOMExuQjVPakkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eklDOHZJR0Y0Wm1WeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVhobVpYSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaWE5vYjNCelpHc3ZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUdGemMyVnlkQ0JoZUdabGNpNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlZWGhtWlhJZ2JtOTBJSFJ2SUdOdmJuUnlZV04wSWdvZ0lDQWdaR2xuSURNS0lDQWdJR2QwZUc1eklFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRjRabVZ5SUc1dmRDQjBieUJqYjI1MGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxjMmh2Y0hOa2F5OWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnWVhOelpYSjBJR0Y0Wm1WeUxtRnpjMlYwWDJGdGIzVnVkQ0E5UFNCVlNXNTBOalFvTVNrc0lDSnRkWE4wSUhSeVlXNXpabVZ5SURFZ1lYTnpaWFFpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzExYzNRZ2RISmhibk5tWlhJZ01TQmhjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYzJodmNITmtheTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGNFptVnlMbk5sYm1SbGNpQTlQU0JVZUc0dWMyVnVaR1Z5TENBaWJYVnpkQ0JpWlNCelpXNWtaWElpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUcxMWMzUWdZbVVnYzJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnphRzl3YzJSckwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJoYzNObGNuUWdjSEpwWTJVdWJtRjBhWFpsSUQ0Z01Dd2dJbkJ5YVdObElENGdNQ0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmhjM05sY25RZ0x5OGdjSEpwWTJVZ1BpQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnphRzl3YzJSckwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJoYzNObGRGOXBaQ0E5SUdGNFptVnlMbmhtWlhKZllYTnpaWFF1YVdRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUmZhV1FnYm05MElHbHVJSE5sYkdZdWJHbHpkR2x1WjNNc0lDSmhiSEpsWVdSNUlHeHBjM1JsWkNJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMll6WTVOek0zTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1lXeHlaV0ZrZVNCc2FYTjBaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaWE5vYjNCelpHc3ZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pYTm9iM0J6WkdzdlkyOXVkSEpoWTNRdWNIazZNelV0TkRBS0lDQWdJQzh2SUhObGJHWXViR2x6ZEdsdVozTmJZWE56WlhSZmFXUmRJRDBnVEdsemRHbHVaMUpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnY0hKcFkyVXNDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUnZjaXdLSUNBZ0lDOHZJQ0FnSUNCeWIzbGhiSFI1WDJKd2N3b2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYzJodmNITmtheTlqYjI1MGNtRmpkQzV3ZVRveU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxjMmh2Y0hOa2F5NWpiMjUwY21GamRDNUVaWE5vYjNCelpHc3VZblY1UVhOelpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpZFhsQmMzTmxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaWE5vYjNCelpHc3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pYTm9iM0J6WkdzdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjM05sZEY5cFpDQnBiaUJ6Wld4bUxteHBjM1JwYm1kekxDQWlibTkwSUd4cGMzUmxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyWXpZNU56TTNORFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnYkdsemRHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnphRzl3YzJSckwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJzYVhOMGFXNW5JRDBnYzJWc1ppNXNhWE4wYVc1bmMxdGhjM05sZEY5cFpGMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pYTm9iM0J6WkdzdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJSEJ5YVdObElEMGdiR2x6ZEdsdVp5NXdjbWxqWlM1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pYTm9iM0J6WkdzdlkyOXVkSEpoWTNRdWNIazZORGtLSUNBZ0lDOHZJSE5sYkd4bGNpQTlJR3hwYzNScGJtY3VjMlZzYkdWeUxtNWhkR2wyWlFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdZM0psWVhSdmNpQTlJR3hwYzNScGJtY3VZM0psWVhSdmNpNXVZWFJwZG1VS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRFF3SURNeUNpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnphRzl3YzJSckwyTnZiblJ5WVdOMExuQjVPalV4Q2lBZ0lDQXZMeUJ5YjNsaGJIUjVYMkp3Y3lBOUlHeHBjM1JwYm1jdWNtOTVZV3gwZVY5aWNITXVibUYwYVhabENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRGN5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYzJodmNITmtheTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z0luQmhlU0JqYjI1MGNtRmpkQ0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1SUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzVoYlc5MWJuUWdQajBnY0hKcFkyVXNJQ0pwYm5OMVptWnBZMmxsYm5RZ2NHRjViV1Z1ZENJS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1JwWnlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1YzNWbVptbGphV1Z1ZENCd1lYbHRaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkQzV6Wlc1a1pYSWdQVDBnVkhodUxuTmxibVJsY2l3Z0luTmxibVJsY2lCdGFYTnRZWFJqYUNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdjbTk1WVd4MGVTQTlJQ2h3Y21salpTQXFJSEp2ZVdGc2RIbGZZbkJ6S1NBdkx5QlZTVzUwTmpRb01UQmZNREF3S1FvZ0lDQWdaR2xuSURFS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01UQXdNREFLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxjMmh2Y0hOa2F5OWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnYzJWc2JHVnlYMkZ0YjNWdWRDQTlJSEJ5YVdObElDMGdjbTk1WVd4MGVRb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCcFppQnpaV3hzWlhKZllXMXZkVzUwSUQ0Z01Eb0tJQ0FnSUdKNklHSjFlVUZ6YzJWMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYzJodmNITmtheTlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLSEpsWTJWcGRtVnlQWE5sYkd4bGNpd2dZVzF2ZFc1MFBYTmxiR3hsY2w5aGJXOTFiblFzSUdabFpUMHdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLQ21KMWVVRnpjMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaWE5vYjNCelpHc3ZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUdsbUlISnZlV0ZzZEhrZ1BpQXdPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjZJR0oxZVVGemMyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0hKbFkyVnBkbVZ5UFdOeVpXRjBiM0lzSUdGdGIzVnVkRDF5YjNsaGJIUjVMQ0JtWldVOU1Da3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLQ21KMWVVRnpjMlYwWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaWE5vYjNCelpHc3ZZMjl1ZEhKaFkzUXVjSGs2TmpVdE56RUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWTJ4dmMyVmZkRzg5YzJWc2JHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWemFHOXdjMlJyTDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkRiRzl6WlZSdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWemFHOXdjMlJyTDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR1JwWnlBMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYzJodmNITmtheTlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWemFHOXdjMlJyTDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5Qm1aV1U5TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pZMUxUY3hDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB4TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJOc2IzTmxYM1J2UFhObGJHeGxjaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pYTm9iM0J6WkdzdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJR1JsYkNCelpXeG1MbXhwYzNScGJtZHpXMkZ6YzJWMFgybGtYUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYzJodmNITmtheTlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxjMmh2Y0hOa2F5NWpiMjUwY21GamRDNUVaWE5vYjNCelpHc3VZMkZ1WTJWc1RHbHpkR2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhibU5sYkV4cGMzUnBibWM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pjMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlhOb2IzQnpaR3N2WTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGMzTmxkRjlwWkNCcGJpQnpaV3htTG14cGMzUnBibWR6TENBaWJtOTBJR3hwYzNSbFpDSUtJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWmpOamszTXpjME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2JHbHpkR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCc2FYTjBhVzVuSUQwZ2MyVnNaaTVzYVhOMGFXNW5jMXRoYzNObGRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxjMmh2Y0hOa2F5OWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnWVhOelpYSjBJR3hwYzNScGJtY3VjMlZzYkdWeUxtNWhkR2wyWlNBOVBTQlVlRzR1YzJWdVpHVnlMQ0FpYm05MElHOTNibVZ5SWdvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQnZkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYzJodmNITmtheTlqYjI1MGNtRmpkQzV3ZVRvNE1pMDRPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5amJHOXpaVjkwYnoxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z6YUc5d2MyUnJMMk52Ym5SeVlXTjBMbkI1T2pnMENpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxjMmh2Y0hOa2F5OWpiMjUwY21GamRDNXdlVG80TmdvZ0lDQWdMeThnWVhOelpYUmZZMnh2YzJWZmRHODlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVOc2IzTmxWRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaWE5vYjNCelpHc3ZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdGemMyVjBYMkZ0YjNWdWREMHhMQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pYTm9iM0J6WkdzdlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTXlBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxjMmh2Y0hOa2F5OWpiMjUwY21GamRDNXdlVG80TndvZ0lDQWdMeThnWm1WbFBUQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUbzRNaTA0T0FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Td0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWpiRzl6WlY5MGJ6MVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGMyaHZjSE5rYXk5amIyNTBjbUZqZEM1d2VUbzVNQW9nSUNBZ0x5OGdaR1ZzSUhObGJHWXViR2x6ZEdsdVozTmJZWE56WlhSZmFXUmRDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaWE5vYjNCelpHc3ZZMjl1ZEhKaFkzUXVjSGs2TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUlCQ1lCQld4cGMzUmZNUnRCQUNzeEdSUkVNUmhFZ2dRRXV5UU9sd1FYMWFneUJEUytlZElFdGpuVXZEWWFBSTRFQUFrQVBnQ1lBVGtBTVJrVU1SZ1VFRU0yR2dGSkZTUVNSQmN4RmlJSlNUZ1FJaEpFU1RnSE1nb1NSRGdJZ2FDTkJoSkVzVElLSTdJU3NoU3lFU1d5RUNPeUFiTWlRekVXSWdsSk9CQWxFa1EyR2dGSkZTUVNSRFlhQWtrVmdTQVNSRFlhQTBrVkpCSkVTd000RkRJS0VrUkxBemdTSWhKRVN3TTRBREVBRWtSTEFoZEVUd000RVJZb1RGQkp2VVVCRkVReEFFOEVVRThEVUU4Q1VMOGlRellhQVVrVkpCSkVGMGt4RmlJSlNUZ1FJaEpFVEJZb1RGQkpUZ0pKdlVVQlJMNUlTWUVnVzBzQlZ3QWdUZ05MQVZjb0lFNERUSUZJVzBzQ09BY3lDaEpFU3dJNENFc0NEMFJQQWpnQU1RQVNSRXNCQzRHUVRncEpUZ0lKU1VFQUQ3RkpzZ2hMQTdJSElySVFJN0lCczBzQlFRQVFzVXNCc2doTEFySUhJcklRSTdJQnM3RXhBRXNFc2hVaXNoS3lGRXNGc2hFbHNoQWpzZ0d6U3dTOFNDSkROaG9CU1JVa0VrUVhTUllvVEZCSnZVVUJSRW0rU0ZjQUlERUFFa1N4TVFCSnNoVWlzaEt5RkV5eUVTV3lFQ095QWJPOFNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
