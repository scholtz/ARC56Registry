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

namespace Arc56.Generated.algorand_devrel.fractional_realestate_ts.FractionalRealEstate_78ba7f7d
{


    public class FractionalRealEstateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FractionalRealEstateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PropertyStruct : AVMObjectType
            {
                public string Address { get; set; }

                public ulong TotalShares { get; set; }

                public ulong AvailableShares { get; set; }

                public ulong PricePerShare { get; set; }

                public ulong PropertyAssetId { get; set; }

                public Algorand.Address OwnerAddress { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAddress.From(Address);
                    stringRef[ret.Count] = vAddress.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalShares.From(TotalShares);
                    ret.AddRange(vTotalShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAvailableShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAvailableShares.From(AvailableShares);
                    ret.AddRange(vAvailableShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPricePerShare.From(PricePerShare);
                    ret.AddRange(vPricePerShare.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPropertyAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPropertyAssetId.From(PropertyAssetId);
                    ret.AddRange(vPropertyAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwnerAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwnerAddress.From(OwnerAddress);
                    ret.AddRange(vOwnerAddress.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PropertyStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PropertyStruct();
                    uint count = 0;
                    var indexAddress = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAddress.Decode(bytes.Skip(indexAddress + prefixOffset).ToArray());
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is string vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalShares = vTotalShares.ToValue();
                    if (valueTotalShares is ulong vTotalSharesValue) { ret.TotalShares = vTotalSharesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAvailableShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAvailableShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAvailableShares = vAvailableShares.ToValue();
                    if (valueAvailableShares is ulong vAvailableSharesValue) { ret.AvailableShares = vAvailableSharesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPricePerShare.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePricePerShare = vPricePerShare.ToValue();
                    if (valuePricePerShare is ulong vPricePerShareValue) { ret.PricePerShare = vPricePerShareValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPropertyAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPropertyAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePropertyAssetId = vPropertyAssetId.ToValue();
                    if (valuePropertyAssetId is ulong vPropertyAssetIdValue) { ret.PropertyAssetId = vPropertyAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwnerAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwnerAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwnerAddress = vOwnerAddress.ToValue();
                    if (valueOwnerAddress is Algorand.Address vOwnerAddressValue) { ret.OwnerAddress = vOwnerAddressValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PropertyStruct);
                }
                public bool Equals(PropertyStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PropertyStruct left, PropertyStruct right)
                {
                    return EqualityComparer<PropertyStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(PropertyStruct left, PropertyStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///List a new property for fractional ownership. Creates an ASA representing shares
        ///and stores property details in a BoxMap.
        ///</summary>
        /// <param name="mbrPayment">Covers the Minimum Balance Requirement for box storage </param>
        /// <param name="propertyAddress"> </param>
        /// <param name="shares"> </param>
        /// <param name="pricePerShare"> </param>
        public async Task<ulong> CreatePropertyListing(PaymentTransaction mbrPayment, string propertyAddress, ulong shares, ulong pricePerShare, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 51, 29, 172, 84 };
            var propertyAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); propertyAddressAbi.From(propertyAddress);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, propertyAddressAbi, sharesAbi, pricePerShareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreatePropertyListing_Transactions(PaymentTransaction mbrPayment, string propertyAddress, ulong shares, ulong pricePerShare, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 51, 29, 172, 84 };
            var propertyAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); propertyAddressAbi.From(propertyAddress);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, propertyAddressAbi, sharesAbi, pricePerShareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Purchase shares from the original lister. Buyer must opt in to the ASA beforehand.
        ///</summary>
        /// <param name="propertyId"> </param>
        /// <param name="shares"> </param>
        /// <param name="payment"> </param>
        public async Task<bool> PurchaseFromLister(PaymentTransaction payment, ulong propertyId, ulong shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 10, 61, 229, 28 };
            var propertyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); propertyIdAbi.From(propertyId);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);

            var result = await base.CallApp(new List<object> { abiHandle, propertyIdAbi, sharesAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PurchaseFromLister_Transactions(PaymentTransaction payment, ulong propertyId, ulong shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 10, 61, 229, 28 };
            var propertyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); propertyIdAbi.From(propertyId);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);

            return await base.MakeTransactionList(new List<object> { abiHandle, propertyIdAbi, sharesAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delist a property. Only the owner can delist, and no shares can have been sold.
        ///Deleting the box reclaims the MBR.
        ///</summary>
        /// <param name="propertyId"> </param>
        public async Task DelistProperty(ulong propertyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 158, 57, 69 };
            var propertyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); propertyIdAbi.From(propertyId);

            var result = await base.CallApp(new List<object> { abiHandle, propertyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DelistProperty_Transactions(ulong propertyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 158, 57, 69 };
            var propertyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); propertyIdAbi.From(propertyId);

            return await base.MakeTransactionList(new List<object> { abiHandle, propertyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="propertyId"> </param>
        public async Task<Structs.PropertyStruct> GetPropertyInfo(ulong propertyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 206, 81, 132 };
            var propertyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); propertyIdAbi.From(propertyId);

            var result = await base.SimApp(new List<object> { abiHandle, propertyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PropertyStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPropertyInfo_Transactions(ulong propertyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 206, 81, 132 };
            var propertyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); propertyIdAbi.From(propertyId);

            return await base.MakeTransactionList(new List<object> { abiHandle, propertyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRnJhY3Rpb25hbFJlYWxFc3RhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJvcGVydHlTdHJ1Y3QiOlt7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRvdGFsU2hhcmVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImF2YWlsYWJsZVNoYXJlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcmljZVBlclNoYXJlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3BlcnR5QXNzZXRJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvd25lckFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVQcm9wZXJ0eUxpc3RpbmciLCJkZXNjIjoiTGlzdCBhIG5ldyBwcm9wZXJ0eSBmb3IgZnJhY3Rpb25hbCBvd25lcnNoaXAuIENyZWF0ZXMgYW4gQVNBIHJlcHJlc2VudGluZyBzaGFyZXNcbmFuZCBzdG9yZXMgcHJvcGVydHkgZGV0YWlscyBpbiBhIEJveE1hcC4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOiJDb3ZlcnMgdGhlIE1pbmltdW0gQmFsYW5jZSBSZXF1aXJlbWVudCBmb3IgYm94IHN0b3JhZ2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3BlcnR5QWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZVBlclNoYXJlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHVyY2hhc2VGcm9tTGlzdGVyIiwiZGVzYyI6IlB1cmNoYXNlIHNoYXJlcyBmcm9tIHRoZSBvcmlnaW5hbCBsaXN0ZXIuIEJ1eWVyIG11c3Qgb3B0IGluIHRvIHRoZSBBU0EgYmVmb3JlaGFuZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcGVydHlJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGlzdFByb3BlcnR5IiwiZGVzYyI6IkRlbGlzdCBhIHByb3BlcnR5LiBPbmx5IHRoZSBvd25lciBjYW4gZGVsaXN0LCBhbmQgbm8gc2hhcmVzIGNhbiBoYXZlIGJlZW4gc29sZC5cbkRlbGV0aW5nIHRoZSBib3ggcmVjbGFpbXMgdGhlIE1CUi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcGVydHlJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQcm9wZXJ0eUluZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcGVydHlJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IlByb3BlcnR5U3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUyNF0sImVycm9yTWVzc2FnZSI6IkNhbm5vdCBkZWxpc3QgcHJvcGVydHkgd2l0aCBzb2xkIHNoYXJlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NF0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgcGF5bWVudCB0cmFuc2FjdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1OV0sImVycm9yTWVzc2FnZSI6Ik1CUiBwYXltZW50IGFtb3VudCBpcyBpbnN1ZmZpY2llbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzVdLCJlcnJvck1lc3NhZ2UiOiJNQlIgcGF5bWVudCBtdXN0IGJlIGZyb20gdGhlIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6Ik1CUiBwYXltZW50IG11c3QgYmUgdG8gdGhlIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMl0sImVycm9yTWVzc2FnZSI6Ik11c3QgcHVyY2hhc2UgYXQgbGVhc3Qgb25lIHNoYXJlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc3XSwiZXJyb3JNZXNzYWdlIjoiTm90IGVub3VnaCBzaGFyZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA5XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgb3duZXIgY2FuIGRlbGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzN10sImVycm9yTWVzc2FnZSI6IlByaWNlIHBlciBzaGFyZSBtdXN0IGJlIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEzLDQ5OSw1NDZdLCJlcnJvck1lc3NhZ2UiOiJQcm9wZXJ0eSBub3QgbGlzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2XSwiZXJyb3JNZXNzYWdlIjoiU2hhcmVzIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxLDEzMSwyNzksMjg4LDQ4OSw1MzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NSwyOTldLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBeElEQWdNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbkJ5YjNCbGNuUnBaWE1pSURCNE1EQTBNaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnWlhod2IzSjBJR1JsWm1GMWJIUWdZMnhoYzNNZ1JuSmhZM1JwYjI1aGJGSmxZV3hGYzNSaGRHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRFS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE16TXhaR0ZqTlRRZ01IZ3dZVE5rWlRVeFl5QXdlRE5pT1dVek9UUTFJREI0WmpOalpUVXhPRFFnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZRY205d1pYSjBlVXhwYzNScGJtY29jR0Y1TEhOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNIVnlZMmhoYzJWR2NtOXRUR2x6ZEdWeUtIVnBiblEyTkN4MWFXNTBOalFzY0dGNUtXSnZiMndpTENCdFpYUm9iMlFnSW1SbGJHbHpkRkJ5YjNCbGNuUjVLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUlFjbTl3WlhKMGVVbHVabThvZFdsdWREWTBLU2h6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxVSEp2Y0dWeWRIbE1hWE4wYVc1bklIQjFjbU5vWVhObFJuSnZiVXhwYzNSbGNpQmtaV3hwYzNSUWNtOXdaWEowZVNCblpYUlFjbTl3WlhKMGVVbHVabThLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJuSmhZM1JwYjI1aGJGSmxZV3hGYzNSaGRHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nUm5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUdjbUZqZEdsdmJtRnNVbVZoYkVWemRHRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBHY21GamRHbHZibUZzVW1WaGJFVnpkR0YwWlM1amNtVmhkR1ZRY205d1pYSjBlVXhwYzNScGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVlFjbTl3WlhKMGVVeHBjM1JwYm1jNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5pMDBNUW9nSUNBZ0x5OGdjSFZpYkdsaklHTnlaV0YwWlZCeWIzQmxjblI1VEdsemRHbHVaeWdLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TEFvZ0lDQWdMeThnSUNCd2NtOXdaWEowZVVGa1pISmxjM002SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnYzJoaGNtVnpPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJSEJ5YVdObFVHVnlVMmhoY21VNklIVnBiblEyTkN3S0lDQWdJQzh2SUNrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWVhOelpYSjBLSE5vWVhKbGN5QStJREFzSUNkVGFHRnlaWE1nYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DY3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYTnpaWEowSUM4dklGTm9ZWEpsY3lCdGRYTjBJR0psSUdkeVpXRjBaWElnZEdoaGJpQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJuSmhZM1JwYjI1aGJGSmxZV3hGYzNSaGRHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdZWE56WlhKMEtIQnlhV05sVUdWeVUyaGhjbVVnUGlBd0xDQW5VSEpwWTJVZ2NHVnlJSE5vWVhKbElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFuS1FvZ0lDQWdZWE56WlhKMElDOHZJRkJ5YVdObElIQmxjaUJ6YUdGeVpTQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWTI5dWMzUWdZbTk0VFdKeVEyOXpkRG9nZFdsdWREWTBJRDBnTWpVd01DQXJJRFF3TUNBcUlDZ3hPQ0FySURZNElDc2dRbmwwWlhNb2NISnZjR1Z5ZEhsQlpHUnlaWE56S1M1c1pXNW5kR2dwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZzJJQzh2SURnMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdjSFZ6YUdsdWRDQTBNREFnTHk4Z05EQXdDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJREkxTURBZ0x5OGdNalV3TUFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbUZ0YjNWdWRDQStQU0JpYjNoTlluSkRiM04wTENBblRVSlNJSEJoZVcxbGJuUWdZVzF2ZFc1MElHbHpJR2x1YzNWbVptbGphV1Z1ZENjcENpQWdJQ0JrYVdjZ053b2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRTFDVWlCd1lYbHRaVzUwSUdGdGIzVnVkQ0JwY3lCcGJuTjFabVpwWTJsbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QmhjM05sY25Rb2JXSnlVR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJQ2ROUWxJZ2NHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklIUm9aU0JoY0hBbktRb2dJQ0FnWkdsbklEWUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTlFsSWdjR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJSFJvWlNCaGNIQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QmhjM05sY25Rb2JXSnlVR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMDlJRlI0Ymk1elpXNWtaWElzSUNkTlFsSWdjR0Y1YldWdWRDQnRkWE4wSUdKbElHWnliMjBnZEdobElHTmhiR3hsY2ljcENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJOUWxJZ2NHRjViV1Z1ZENCdGRYTjBJR0psSUdaeWIyMGdkR2hsSUdOaGJHeGxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOell0T0RZS0lDQWdJQzh2SUdOdmJuTjBJSFI0YmxKbGMzVnNkQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEU1aGJXVTZJRUo1ZEdWektIQnliM0JsY25SNVFXUmtjbVZ6Y3lrdWMyeHBZMlVvTUN3Z016SXBMblJ2VTNSeWFXNW5LQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRTVoYldVNklDZFFVazlRSnl3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkRvZ2MyaGhjbVZ6TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4ek9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnWVhOelpYUk9ZVzFsT2lCQ2VYUmxjeWh3Y205d1pYSjBlVUZrWkhKbGMzTXBMbk5zYVdObEtEQXNJRE15S1M1MGIxTjBjbWx1WnlncExBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1JwWnlBeENpQWdJQ0ErUFFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z2JXRnVZV2RsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUhKbGMyVnlkbVU2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlHY21GamRHbHZibUZzVW1WaGJFVnpkR0YwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCa1pXTnBiV0ZzY3pvZ01Dd0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Rb2dJQ0FnTHk4Z2RXNXBkRTVoYldVNklDZFFVazlRSnl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpVUZKUFVDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUdjbUZqZEdsdmJtRnNVbVZoYkVWemRHRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyTFRnMUNpQWdJQ0F2THlCamIyNXpkQ0IwZUc1U1pYTjFiSFFnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRFTnZibVpwWnloN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhST1lXMWxPaUJDZVhSbGN5aHdjbTl3WlhKMGVVRmtaSEpsYzNNcExuTnNhV05sS0RBc0lETXlLUzUwYjFOMGNtbHVaeWdwTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJPWVcxbE9pQW5VRkpQVUNjc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3NklITm9ZWEpsY3l3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6b2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOell0T0RZS0lDQWdJQzh2SUdOdmJuTjBJSFI0YmxKbGMzVnNkQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEU1aGJXVTZJRUo1ZEdWektIQnliM0JsY25SNVFXUmtjbVZ6Y3lrdWMyeHBZMlVvTUN3Z016SXBMblJ2VTNSeWFXNW5LQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRTVoYldVNklDZFFVazlRSnl3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkRvZ2MyaGhjbVZ6TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4ek9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJSEJ5YjNCbGNuUjVRWE56WlhSSlpEb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtHRnpjMlYwU1dRcExBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHOTNibVZ5UVdSa2NtVnpjem9nYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUdjbUZqZEdsdmJtRnNVbVZoYkVWemRHRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall3TFRZM0NpQWdJQ0F2THlCamIyNXpkQ0J3Y205d1pYSjBlVk4wY25WamRDQTlJRzVsZHlCUWNtOXdaWEowZVZOMGNuVmpkQ2g3Q2lBZ0lDQXZMeUFnSUdGa1pISmxjM002SUc1bGR5QmhjbU0wTGxOMGNpaHdjbTl3WlhKMGVVRmtaSEpsYzNNcExBb2dJQ0FnTHk4Z0lDQjBiM1JoYkZOb1lYSmxjem9nYm1WM0lHRnlZelF1VldsdWREWTBLSE5vWVhKbGN5a3NDaUFnSUNBdkx5QWdJR0YyWVdsc1lXSnNaVk5vWVhKbGN6b2dibVYzSUdGeVl6UXVWV2x1ZERZMEtITm9ZWEpsY3lrc0NpQWdJQ0F2THlBZ0lIQnlhV05sVUdWeVUyaGhjbVU2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2h3Y21salpWQmxjbE5vWVhKbEtTd0tJQ0FnSUM4dklDQWdjSEp2Y0dWeWRIbEJjM05sZEVsa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb1lYTnpaWFJKWkNrc0NpQWdJQ0F2THlBZ0lHOTNibVZ5UVdSa2NtVnpjem9nYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQTBNZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJR3hwYzNSbFpGQnliM0JsY25ScFpYTWdQU0JDYjNoTllYQThkV2x1ZERZMExDQlFjbTl3WlhKMGVWTjBjblZqZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R3Y205d1pYSjBhV1Z6SnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNISnZjR1Z5ZEdsbGN5SUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUdjbUZqZEdsdmJtRnNVbVZoYkVWemRHRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUIwYUdsekxteHBjM1JsWkZCeWIzQmxjblJwWlhNb1lYTnpaWFJKWkNrdWRtRnNkV1VnUFNCamJHOXVaU2h3Y205d1pYSjBlVk4wY25WamRDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmkwME1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVkJ5YjNCbGNuUjVUR2x6ZEdsdVp5Z0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQW9nSUNBZ0x5OGdJQ0J3Y205d1pYSjBlVUZrWkhKbGMzTTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdjMmhoY21Wek9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lIQnlhV05sVUdWeVUyaGhjbVU2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1p5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTG5CMWNtTm9ZWE5sUm5KdmJVeHBjM1JsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQjFjbU5vWVhObFJuSnZiVXhwYzNSbGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QndkV0pzYVdNZ2NIVnlZMmhoYzJWR2NtOXRUR2x6ZEdWeUtIQnliM0JsY25SNVNXUTZJSFZwYm5RMk5Dd2djMmhoY21Wek9pQjFhVzUwTmpRc0lIQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJuSmhZM1JwYjI1aGJGSmxZV3hGYzNSaGRHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdZWE56WlhKMEtITm9ZWEpsY3lBK0lEQXNJQ2ROZFhOMElIQjFjbU5vWVhObElHRjBJR3hsWVhOMElHOXVaU0J6YUdGeVpTY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnY0hWeVkyaGhjMlVnWVhRZ2JHVmhjM1FnYjI1bElITm9ZWEpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWJHbHpkR1ZrVUhKdmNHVnlkR2xsY3lod2NtOXdaWEowZVVsa0tTNWxlR2x6ZEhNc0lDZFFjbTl3WlhKMGVTQnViM1FnYkdsemRHVmtKeWtLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIQjFZbXhwWXlCc2FYTjBaV1JRY205d1pYSjBhV1Z6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnVUhKdmNHVnlkSGxUZEhKMVkzUStLSHNnYTJWNVVISmxabWw0T2lBbmNISnZjR1Z5ZEdsbGN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjNCbGNuUnBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlHY21GamRHbHZibUZzVW1WaGJFVnpkR0YwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXNhWE4wWldSUWNtOXdaWEowYVdWektIQnliM0JsY25SNVNXUXBMbVY0YVhOMGN5d2dKMUJ5YjNCbGNuUjVJRzV2ZENCc2FYTjBaV1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtOXdaWEowZVNCdWIzUWdiR2x6ZEdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9DMHhNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0hCaGVXMWxiblFzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCemFHRnlaWE1nS2lCd2NtOXdaWEowZVM1d2NtbGpaVkJsY2xOb1lYSmxMbUZ6VldsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnYzJWdVpHVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lISmxhMlY1Vkc4NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklIMHNJQ2RKYm5aaGJHbGtJSEJoZVcxbGJuUWdkSEpoYm5OaFkzUnBiMjRuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUdGdGIzVnVkRG9nYzJoaGNtVnpJQ29nY0hKdmNHVnlkSGt1Y0hKcFkyVlFaWEpUYUdGeVpTNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UZ2dMeThnTVRnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pIVndDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dOUW9nSUNBZ0tnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ3RNVEEwQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNod1lYbHRaVzUwTENCN0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2MyaGhjbVZ6SUNvZ2NISnZjR1Z5ZEhrdWNISnBZMlZRWlhKVGFHRnlaUzVoYzFWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhObGJtUmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnlaV3RsZVZSdk9pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QjlMQ0FuU1c1MllXeHBaQ0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1SnlrS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdaR2xuSURRS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9DMHhNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0hCaGVXMWxiblFzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCemFHRnlaWE1nS2lCd2NtOXdaWEowZVM1d2NtbGpaVkJsY2xOb1lYSmxMbUZ6VldsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnYzJWdVpHVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lISmxhMlY1Vkc4NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklIMHNJQ2RKYm5aaGJHbGtJSEJoZVcxbGJuUWdkSEpoYm5OaFkzUnBiMjRuS1FvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dOQW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJuSmhZM1JwYjI1aGJGSmxZV3hGYzNSaGRHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazRMVEV3TkFvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2NHRjViV1Z1ZEN3Z2V3b2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklITm9ZWEpsY3lBcUlIQnliM0JsY25SNUxuQnlhV05sVUdWeVUyaGhjbVV1WVhOVmFXNTBOalFvS1N3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCelpXNWtaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ0x5OGdmU3dnSjBsdWRtRnNhV1FnY0dGNWJXVnVkQ0IwY21GdWMyRmpkR2x2YmljcENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQm5kSGh1Y3lCRGJHOXpaVkpsYldGcGJtUmxjbFJ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGd0TVRBMENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGx0Wlc1MExDQjdDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2djMmhoY21WeklDb2djSEp2Y0dWeWRIa3VjSEpwWTJWUVpYSlRhR0Z5WlM1aGMxVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0J5Wld0bGVWUnZPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQXZMeUI5TENBblNXNTJZV3hwWkNCd1lYbHRaVzUwSUhSeVlXNXpZV04wYVc5dUp5a0tJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCbmRIaHVjeUJTWld0bGVWUnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJuSmhZM1JwYjI1aGJGSmxZV3hGYzNSaGRHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRE1LSUNBZ0lDOHZJSEpsYTJWNVZHODZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ3RNVEEwQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNod1lYbHRaVzUwTENCN0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2MyaGhjbVZ6SUNvZ2NISnZjR1Z5ZEhrdWNISnBZMlZRWlhKVGFHRnlaUzVoYzFWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUhObGJtUmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnlaV3RsZVZSdk9pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QjlMQ0FuU1c1MllXeHBaQ0J3WVhsdFpXNTBJSFJ5WVc1ellXTjBhVzl1SnlrS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ2NHRjViV1Z1ZENCMGNtRnVjMkZqZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QmhjM05sY25Rb2MyaGhjbVZ6SUR3OUlIQnliM0JsY25SNUxtRjJZV2xzWVdKc1pWTm9ZWEpsY3k1aGMxVnBiblEyTkNncExDQW5UbTkwSUdWdWIzVm5hQ0J6YUdGeVpYTW5LUW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01UQWdMeThnTVRBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0JsYm05MVoyZ2djMmhoY21WekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBJRDBnUVhOelpYUW9jSEp2Y0dWeWRIa3VjSEp2Y0dWeWRIbEJjM05sZEVsa0xtRnpWV2x1ZERZMEtDa3BDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBeU5pQXZMeUF5TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2RYQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPUzB4TWpFS0lDQWdJQzh2SUdsMGVHNHVjM1ZpYldsMFIzSnZkWEFvQ2lBZ0lDQXZMeUFnSUdsMGVHNHVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQnphR0Z5WlhNc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLU3dLSUNBZ0lDOHZJQ0FnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSEJoZVcxbGJuUXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJ3Y205d1pYSjBlUzV2ZDI1bGNrRmtaSEpsYzNNdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlHY21GamRHbHZibUZzVW1WaGJFVnpkR0YwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1nb2dJQ0FnTHk4Z1lYTnpaWFJTWldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRBdE1URTFDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ2MyaGhjbVZ6TEFvZ0lDQWdMeThnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUI5S1N3S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUyTFRFeU1Bb2dJQ0FnTHk4Z2FYUjRiaTV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJ3WVhsdFpXNTBMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJSEJ5YjNCbGNuUjVMbTkzYm1WeVFXUmtjbVZ6Y3k1aWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdmU2tzQ2lBZ0lDQnBkSGh1WDI1bGVIUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdjbVZqWldsMlpYSTZJSEJ5YjNCbGNuUjVMbTkzYm1WeVFXUmtjbVZ6Y3k1aWVYUmxjeXdLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElETTBJQzh2SURNMENpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOaTB4TWpBS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2djR0Y1YldWdWRDNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQndjbTl3WlhKMGVTNXZkMjVsY2tGa1pISmxjM011WW5sMFpYTXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklIMHBMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlHY21GamRHbHZibUZzVW1WaGJFVnpkR0YwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE9Rb2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURrdE1USXhDaUFnSUNBdkx5QnBkSGh1TG5OMVltMXBkRWR5YjNWd0tBb2dJQ0FnTHk4Z0lDQnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nYzJoaGNtVnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrc0NpQWdJQ0F2THlBZ0lHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCd1lYbHRaVzUwTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ2NISnZjR1Z5ZEhrdWIzZHVaWEpCWkdSeVpYTnpMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUIwYUdsekxuVndaR0YwWlVGMllXbHNZV0pzWlZOb1lYSmxjeWh3Y205d1pYSjBlVWxrTENCd2NtOXdaWEowZVM1aGRtRnBiR0ZpYkdWVGFHRnlaWE11WVhOVmFXNTBOalFvS1NBdElITm9ZWEpsY3lrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRjS0lDQWdJQzh2SUdOdmJuTjBJSEJ5YjNCbGNuUjVVM1J5ZFdOMElEMGdZMnh2Ym1Vb2RHaHBjeTVzYVhOMFpXUlFjbTl3WlhKMGFXVnpLSEJ5YjNCbGNuUjVTV1FwTG5aaGJIVmxLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNUNpQWdJQ0F2THlBdUxpNXdjbTl3WlhKMGVWTjBjblZqZEN3S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5QmhkbUZwYkdGaWJHVlRhR0Z5WlhNNklHNWxkeUJoY21NMExsVnBiblEyTkNodVpYZEJkbUZwYkdGaWJHVlRhR0Z5WlhNcExBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRndE1UVXhDaUFnSUNBdkx5QmpiMjV6ZENCMWNHUmhkR1ZrVTNSeWRXTjBJRDBnYm1WM0lGQnliM0JsY25SNVUzUnlkV04wS0hzS0lDQWdJQzh2SUNBZ0xpNHVjSEp2Y0dWeWRIbFRkSEoxWTNRc0NpQWdJQ0F2THlBZ0lHRjJZV2xzWVdKc1pWTm9ZWEpsY3pvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0c1bGQwRjJZV2xzWVdKc1pWTm9ZWEpsY3lrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdORElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXpDaUFnSUNBdkx5QjBhR2x6TG14cGMzUmxaRkJ5YjNCbGNuUnBaWE1vY0hKdmNHVnlkSGxKWkNrdWRtRnNkV1VnUFNCamJHOXVaU2gxY0dSaGRHVmtVM1J5ZFdOMEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUhCMVlteHBZeUJ3ZFhKamFHRnpaVVp5YjIxTWFYTjBaWElvY0hKdmNHVnlkSGxKWkRvZ2RXbHVkRFkwTENCemFHRnlaWE02SUhWcGJuUTJOQ3dnY0dGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJuSmhZM1JwYjI1aGJGSmxZV3hGYzNSaGRHVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSbkpoWTNScGIyNWhiRkpsWVd4RmMzUmhkR1V1WkdWc2FYTjBVSEp2Y0dWeWRIbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4cGMzUlFjbTl3WlhKMGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNQW9nSUNBZ0x5OGdjSFZpYkdsaklHUmxiR2x6ZEZCeWIzQmxjblI1S0hCeWIzQmxjblI1U1dRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVzYVhOMFpXUlFjbTl3WlhKMGFXVnpLSEJ5YjNCbGNuUjVTV1FwTG1WNGFYTjBjeXdnSjFCeWIzQmxjblI1SUc1dmRDQnNhWE4wWldRbktRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIQjFZbXhwWXlCc2FYTjBaV1JRY205d1pYSjBhV1Z6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnVUhKdmNHVnlkSGxUZEhKMVkzUStLSHNnYTJWNVVISmxabWw0T2lBbmNISnZjR1Z5ZEdsbGN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjNCbGNuUnBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlHY21GamRHbHZibUZzVW1WaGJFVnpkR0YwWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXViR2x6ZEdWa1VISnZjR1Z5ZEdsbGN5aHdjbTl3WlhKMGVVbGtLUzVsZUdsemRITXNJQ2RRY205d1pYSjBlU0J1YjNRZ2JHbHpkR1ZrSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1VISnZjR1Z5ZEhrZ2JtOTBJR3hwYzNSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTFDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnY0hKdmNHVnlkSGt1YjNkdVpYSkJaR1J5WlhOekxtNWhkR2wyWlN3Z0owOXViSGtnZEdobElHOTNibVZ5SUdOaGJpQmtaV3hwYzNRbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNelFnTHk4Z016UUtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMGFHVWdiM2R1WlhJZ1kyRnVJR1JsYkdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QndjbTl3WlhKMGVTNWhkbUZwYkdGaWJHVlRhR0Z5WlhNdVlYTlZhVzUwTmpRb0tTQTlQVDBnY0hKdmNHVnlkSGt1ZEc5MFlXeFRhR0Z5WlhNdVlYTlZhVzUwTmpRb0tTd0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TUNBdkx5QXhNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUdjbUZqZEdsdmJtRnNVbVZoYkVWemRHRjBaUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TmkweE16a0tJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ2NISnZjR1Z5ZEhrdVlYWmhhV3hoWW14bFUyaGhjbVZ6TG1GelZXbHVkRFkwS0NrZ1BUMDlJSEJ5YjNCbGNuUjVMblJ2ZEdGc1UyaGhjbVZ6TG1GelZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lDZERZVzV1YjNRZ1pHVnNhWE4wSUhCeWIzQmxjblI1SUhkcGRHZ2djMjlzWkNCemFHRnlaWE1uTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhKMElDOHZJRU5oYm01dmRDQmtaV3hwYzNRZ2NISnZjR1Z5ZEhrZ2QybDBhQ0J6YjJ4a0lITm9ZWEpsY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRReENpQWdJQ0F2THlCMGFHbHpMbXhwYzNSbFpGQnliM0JsY25ScFpYTW9jSEp2Y0dWeWRIbEpaQ2t1WkdWc1pYUmxLQ2tLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNd0NpQWdJQ0F2THlCd2RXSnNhV01nWkdWc2FYTjBVSEp2Y0dWeWRIa29jSEp2Y0dWeWRIbEpaRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBaeVlXTjBhVzl1WVd4U1pXRnNSWE4wWVhSbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMbWRsZEZCeWIzQmxjblI1U1c1bWIxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZCeWIzQmxjblI1U1c1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5R2NtRmpkR2x2Ym1Gc1VtVmhiRVZ6ZEdGMFpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbXhwYzNSbFpGQnliM0JsY25ScFpYTW9jSEp2Y0dWeWRIbEpaQ2t1WlhocGMzUnpMQ0FuVUhKdmNHVnlkSGtnYm05MElHeHBjM1JsWkNjcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUd4cGMzUmxaRkJ5YjNCbGNuUnBaWE1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JRY205d1pYSjBlVk4wY25WamRENG9leUJyWlhsUWNtVm1hWGc2SUNkd2NtOXdaWEowYVdWekp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljSEp2Y0dWeWRHbGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFp5WVdOMGFXOXVZV3hTWldGc1JYTjBZWFJsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXNhWE4wWldSUWNtOXdaWEowYVdWektIQnliM0JsY25SNVNXUXBMbVY0YVhOMGN5d2dKMUJ5YjNCbGNuUjVJRzV2ZENCc2FYTjBaV1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtOXdaWEowZVNCdWIzUWdiR2x6ZEdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Um5KaFkzUnBiMjVoYkZKbFlXeEZjM1JoZEdVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5Ua0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbXhwYzNSbFpGQnliM0JsY25ScFpYTW9jSEp2Y0dWeWRIbEpaQ2t1ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwWnlZV04wYVc5dVlXeFNaV0ZzUlhOMFlYUmxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUNBRUFJQ1lEQ25CeWIzQmxjblJwWlhNQ0FFSUVGUjk4ZFRFYlFRQXJNUmtVUkRFWVJJSUVCRE1kckZRRUNqM2xIQVE3bmpsRkJQUE9VWVEyR2dDT0JBQUxBTVVCbHdIR0FERVpGREVZRkJCRUkwTXhGaU1KU1RnUUl4SkVOaG9CU1NSWmdRSUlTd0VWRWtSSlZ3SUFOaG9DU1JVaUVrUkpGellhQTBrVkloSkVTUmRMQWtSRVN3TVZnVlpMQVFpQmtBTUxnY1FUQ0VzSE9BZ09SRXNHT0FjeUNoSkVUd1k0QURFQUVrU3hKRXNCRHlSTEFrOENUU1ZMQWc4bFR3TlBBazFQQlU0Q1VqSUtTYklxc2lra3NpTlBBcklpZ0FSUVVrOVFzaVd5Sm9FRHNoQWtzZ0d6dER3V01RQXBTd1JRVHdSUVR3TlFTd0pRVEZCUEFsQW9Td0pRU2J4SVRMOHFURkN3STBNMkdnRkpGU0lTUkJjMkdnSkpGU0lTUkJjeEZpTUpTVGdRSXhKRVN3RkVUd0lXS0V4UVNiMUZBVVJMQVRnSVN3R0JFaUs2U1JkTEJRdExBaEpMQkRnSE1nb1NFRXNFT0FBeEFCSVFTd1E0Q1RJREVoQlBCRGdnTWdNU0VFUkxBb0VLSXJvWFN3UkxBUTVFU3dPQkdpSzZTUmV4TVFCTEI3SVNzaFN5RVlFRXNoQWtzZ0cyU3dTQklpVzZTYklIVHdTeUNDT3lFQ1N5QWJOUEFrOEZDVXNFdmtoSkpGbExBUlZTU3dXQkFpSzZUd0lXS1U4Q1VFeFFUd1JRVHdOUVR3SlFURkJMQWJ4SXY0QUZGUjk4ZFlDd0kwTTJHZ0ZKRlNJU1JCY1dLRXhRU2IxRkFVUXhBRXNCZ1NJbHVoSkVTWUVLSXJvWFN3R0JBaUs2RnhKRXZFZ2pRellhQVVrVkloSkVGeFlvVEZCSnZVVUJSTDVJS2t4UXNDTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
