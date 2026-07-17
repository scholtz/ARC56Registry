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

namespace Arc56.Generated.iskysun96.fractional_realestate.FractionalRealestate_33e7c027
{


    //
    // Smart contract for fractional real estate ownership.
    //
    //    This contract allows properties to be listed, bought, and sold in fractions.
    //    Each property is represented as an asset, and shares can be bought and sold
    //    using ALGO payments.
    //    
    //
    public class FractionalRealestateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FractionalRealestateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PropertyStruct : AVMObjectType
            {
                public string Address { get; set; }

                public ulong PriceInMicroAlgo { get; set; }

                public ulong PropertyAssetId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAddress.From(Address);
                    stringRef[ret.Count] = vAddress.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceInMicroAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPriceInMicroAlgo.From(PriceInMicroAlgo);
                    ret.AddRange(vPriceInMicroAlgo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPropertyAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPropertyAssetId.From(PropertyAssetId);
                    ret.AddRange(vPropertyAssetId.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceInMicroAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPriceInMicroAlgo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePriceInMicroAlgo = vPriceInMicroAlgo.ToValue();
                    if (valuePriceInMicroAlgo is ulong vPriceInMicroAlgoValue) { ret.PriceInMicroAlgo = vPriceInMicroAlgoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPropertyAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPropertyAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePropertyAssetId = vPropertyAssetId.ToValue();
                    if (valuePropertyAssetId is ulong vPropertyAssetIdValue) { ret.PropertyAssetId = vPropertyAssetIdValue; }
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
        ///List a new property for fractional ownership.
        ///</summary>
        /// <param name="property_address"> </param>
        /// <param name="price_in_micro_algo">Total price of the property in microALGO </param>
        public async Task<ulong> ListProperty(string property_address, ulong price_in_micro_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 69, 42, 67 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);
            var price_in_micro_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_in_micro_algoAbi.From(price_in_micro_algo);

            var result = await base.CallApp(new List<object> { abiHandle, property_addressAbi, price_in_micro_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListProperty_Transactions(string property_address, ulong price_in_micro_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 69, 42, 67 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);
            var price_in_micro_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_in_micro_algoAbi.From(price_in_micro_algo);

            return await base.MakeTransactionList(new List<object> { abiHandle, property_addressAbi, price_in_micro_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy shares of a listed property.
        ///</summary>
        /// <param name="property_address"> </param>
        /// <param name="shares">Number of shares to buy </param>
        /// <param name="payment">Payment transaction containing the ALGO payment </param>
        public async Task<bool> BuyPropertyShares(PaymentTransaction payment, string property_address, ulong shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 150, 176, 91, 132 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);

            var result = await base.CallApp(new List<object> { abiHandle, property_addressAbi, sharesAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyPropertyShares_Transactions(PaymentTransaction payment, string property_address, ulong shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 150, 176, 91, 132 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);

            return await base.MakeTransactionList(new List<object> { abiHandle, property_addressAbi, sharesAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sell shares of a property back to the contract.
        ///</summary>
        /// <param name="property_address"> </param>
        /// <param name="sell_txn">Asset transfer transaction containing the shares to sell </param>
        public async Task<ulong> SellPropertyShares(AssetTransferTransaction sell_txn, string property_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { sell_txn });
            byte[] abiHandle = { 141, 168, 104, 104 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);

            var result = await base.CallApp(new List<object> { abiHandle, property_addressAbi, sell_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SellPropertyShares_Transactions(AssetTransferTransaction sell_txn, string property_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { sell_txn });
            byte[] abiHandle = { 141, 168, 104, 104 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, property_addressAbi, sell_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get information about a listed property.
        ///</summary>
        /// <param name="property_address"> </param>
        public async Task<Structs.PropertyStruct> GetPropertyInfo(string property_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 109, 121, 156 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);

            var result = await base.SimApp(new List<object> { abiHandle, property_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PropertyStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPropertyInfo_Transactions(string property_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 109, 121, 156 };
            var property_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); property_addressAbi.From(property_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, property_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRnJhY3Rpb25hbFJlYWxlc3RhdGUiLCJkZXNjIjoiU21hcnQgY29udHJhY3QgZm9yIGZyYWN0aW9uYWwgcmVhbCBlc3RhdGUgb3duZXJzaGlwLlxuXG4gICAgVGhpcyBjb250cmFjdCBhbGxvd3MgcHJvcGVydGllcyB0byBiZSBsaXN0ZWQsIGJvdWdodCwgYW5kIHNvbGQgaW4gZnJhY3Rpb25zLlxuICAgIEVhY2ggcHJvcGVydHkgaXMgcmVwcmVzZW50ZWQgYXMgYW4gYXNzZXQsIGFuZCBzaGFyZXMgY2FuIGJlIGJvdWdodCBhbmQgc29sZFxuICAgIHVzaW5nIEFMR08gcGF5bWVudHMuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlByb3BlcnR5U3RydWN0IjpbeyJuYW1lIjoiYWRkcmVzcyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJwcmljZV9pbl9taWNyb19hbGdvIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3BlcnR5X2Fzc2V0X2lkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJsaXN0X3Byb3BlcnR5IiwiZGVzYyI6Ikxpc3QgYSBuZXcgcHJvcGVydHkgZm9yIGZyYWN0aW9uYWwgb3duZXJzaGlwLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wZXJ0eV9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZV9pbl9taWNyb19hbGdvIiwiZGVzYyI6IlRvdGFsIHByaWNlIG9mIHRoZSBwcm9wZXJ0eSBpbiBtaWNyb0FMR08iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGFzc2V0IElEIG9mIHRoZSBjcmVhdGVkIHByb3BlcnR5IHRva2VuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5X3Byb3BlcnR5X3NoYXJlcyIsImRlc2MiOiJCdXkgc2hhcmVzIG9mIGEgbGlzdGVkIHByb3BlcnR5LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wZXJ0eV9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXMiLCJkZXNjIjoiTnVtYmVyIG9mIHNoYXJlcyB0byBidXkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiUGF5bWVudCB0cmFuc2FjdGlvbiBjb250YWluaW5nIHRoZSBBTEdPIHBheW1lbnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBQcm9wZXJ0eVN0cnVjdCBvZiB0aGUgcHVyY2hhc2VkIHByb3BlcnR5In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2VsbF9wcm9wZXJ0eV9zaGFyZXMiLCJkZXNjIjoiU2VsbCBzaGFyZXMgb2YgYSBwcm9wZXJ0eSBiYWNrIHRvIHRoZSBjb250cmFjdC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcGVydHlfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsX3R4biIsImRlc2MiOiJBc3NldCB0cmFuc2ZlciB0cmFuc2FjdGlvbiBjb250YWluaW5nIHRoZSBzaGFyZXMgdG8gc2VsbCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgYW1vdW50IG9mIEFMR08gcmVjZWl2ZWQgZm9yIHRoZSBzb2xkIHNoYXJlcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wcm9wZXJ0eV9pbmZvIiwiZGVzYyI6IkdldCBpbmZvcm1hdGlvbiBhYm91dCBhIGxpc3RlZCBwcm9wZXJ0eS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcGVydHlfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUHJvcGVydHlTdHJ1Y3QiLCJkZXNjIjoiVGhlIFByb3BlcnR5U3RydWN0IGNvbnRhaW5pbmcgdGhlIHByb3BlcnR5J3MgaW5mb3JtYXRpb24ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzc2XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBhc3NldCBJRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5OF0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgYXNzZXQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg0XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBhc3NldCByZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5Ml0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgYXNzZXQgc2VuZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE4XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBwYXltZW50IGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNl0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgcGF5bWVudCByZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNF0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgcGF5bWVudCBzZW5kZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTBdLCJlcnJvck1lc3NhZ2UiOiJOb3QgZW5vdWdoIHNoYXJlcyBhdmFpbGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NSw4NywxMjAsMTYzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwXSwiZXJyb3JNZXNzYWdlIjoiUHJvcGVydHkgYWxyZWFkeSBsaXN0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTUsMzY2LDQyN10sImVycm9yTWVzc2FnZSI6IlByb3BlcnR5IG5vdCBsaXN0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OCw5MCwxMjMsMTY2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5NywzNjgsNDI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5saXN0ZWRfcHJvcGVydGllcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpuSmhZM1JwYjI1aGJGOXlaV0ZzWlhOMFlYUmxMbU52Ym5SeVlXTjBMa1p5WVdOMGFXOXVZV3hTWldGc1pYTjBZWFJsTGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ01DQTBJREV3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW5WelpYSnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1kyeGhjM01nUm5KaFkzUnBiMjVoYkZKbFlXeGxjM1JoZEdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEE1Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WlRnME5USmhORE1nTUhnNU5tSXdOV0k0TkNBd2VEaGtZVGcyT0RZNElEQjRaamsyWkRjNU9XTWdMeThnYldWMGFHOWtJQ0pzYVhOMFgzQnliM0JsY25SNUtITjBjbWx1Wnl4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ppZFhsZmNISnZjR1Z5ZEhsZmMyaGhjbVZ6S0hOMGNtbHVaeXgxYVc1ME5qUXNjR0Y1S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbk5sYkd4ZmNISnZjR1Z5ZEhsZmMyaGhjbVZ6S0hOMGNtbHVaeXhoZUdabGNpbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjl3Y205d1pYSjBlVjlwYm1adktITjBjbWx1Wnlrb2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXNhWE4wWDNCeWIzQmxjblI1WDNKdmRYUmxRRFVnYldGcGJsOWlkWGxmY0hKdmNHVnlkSGxmYzJoaGNtVnpYM0p2ZFhSbFFEWWdiV0ZwYmw5elpXeHNYM0J5YjNCbGNuUjVYM05vWVhKbGMxOXliM1YwWlVBM0lHMWhhVzVmWjJWMFgzQnliM0JsY25SNVgybHVabTlmY205MWRHVkFPQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWTJ4aGMzTWdSbkpoWTNScGIyNWhiRkpsWVd4bGMzUmhkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYM0J5YjNCbGNuUjVYMmx1Wm05ZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltY21GamRHbHZibUZzWDNKbFlXeGxjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVFV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWNtRmpkR2x2Ym1Gc1gzSmxZV3hsYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUdOc1lYTnpJRVp5WVdOMGFXOXVZV3hTWldGc1pYTjBZWFJsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TlRJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM0J5YjNCbGNuUjVYMmx1Wm04S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzJWc2JGOXdjbTl3WlhKMGVWOXphR0Z5WlhOZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltY21GamRHbHZibUZzWDNKbFlXeGxjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1jbUZqZEdsdmJtRnNYM0psWVd4bGMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1qQUtJQ0FnSUM4dklHTnNZWE56SUVaeVlXTjBhVzl1WVd4U1pXRnNaWE4wWVhSbEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzJWc2JGOXdjbTl3WlhKMGVWOXphR0Z5WlhNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW5WNVgzQnliM0JsY25SNVgzTm9ZWEpsYzE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuSmhZM1JwYjI1aGJGOXlaV0ZzWlhOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCamJHRnpjeUJHY21GamRHbHZibUZzVW1WaGJHVnpkR0YwWlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCaWRYbGZjSEp2Y0dWeWRIbGZjMmhoY21WekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMnhwYzNSZmNISnZjR1Z5ZEhsZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltY21GamRHbHZibUZzWDNKbFlXeGxjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCR2NtRmpkR2x2Ym1Gc1VtVmhiR1Z6ZEdGMFpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1jbUZqZEdsdmJtRnNYM0psWVd4bGMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCc2FYTjBYM0J5YjNCbGNuUjVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3lNQW9nSUNBZ0x5OGdZMnhoYzNNZ1JuSmhZM1JwYjI1aGJGSmxZV3hsYzNSaGRHVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTNWpiMjUwY21GamRDNUdjbUZqZEdsdmJtRnNVbVZoYkdWemRHRjBaUzVzYVhOMFgzQnliM0JsY25SNUtIQnliM0JsY25SNVgyRmtaSEpsYzNNNklHSjVkR1Z6TENCd2NtbGpaVjlwYmw5dGFXTnliMTloYkdkdk9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tiR2x6ZEY5d2NtOXdaWEowZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltY21GamRHbHZibUZzWDNKbFlXeGxjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNekV0TXpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR3hwYzNSZmNISnZjR1Z5ZEhrb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3Z2NISnZjR1Z5ZEhsZllXUmtjbVZ6Y3pvZ1UzUnlhVzVuTENCd2NtbGpaVjlwYmw5dGFXTnliMTloYkdkdk9pQlZTVzUwTmpRS0lDQWdJQzh2SUNrZ0xUNGdWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QmhjM05sY25RZ2NISnZjR1Z5ZEhsZllXUmtjbVZ6Y3lCdWIzUWdhVzRnYzJWc1ppNXNhWE4wWldSZmNISnZjR1Z5ZEdsbGN5d2dJbEJ5YjNCbGNuUjVJR0ZzY21WaFpIa2diR2x6ZEdWa0lnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRYTmxjbk1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJRY205d1pYSjBlU0JoYkhKbFlXUjVJR3hwYzNSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG8wT1MwMU5nb2dJQ0FnTHk4Z2RIaHVYM0psYzNWc2RDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQxd2NtOXdaWEowZVY5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJmYm1GdFpUMGlVRkpQVUNJc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OWNISnBZMlZmYVc1ZmJXbGpjbTlmWVd4bmJ5d0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejB3TEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltY21GamRHbHZibUZzWDNKbFlXeGxjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pRVWs5UUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaVVGSlBVQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJWYm1sMFRtRnRaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdkSGh1WDNKbGMzVnNkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qUTVMVFUyQ2lBZ0lDQXZMeUIwZUc1ZmNtVnpkV3gwSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQWEJ5YjNCbGNuUjVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFNKUVVrOVFJaXdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDF3Y21salpWOXBibDl0YVdOeWIxOWhiR2R2TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5KaFkzUnBiMjVoYkY5eVpXRnNaWE4wWVhSbEwyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJoWkdSeVpYTnpQV0Z5WXpRdVUzUnlhVzVuS0hCeWIzQmxjblI1WDJGa1pISmxjM01wTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2NISnBZMlZmYVc1ZmJXbGpjbTlmWVd4bmJ6MWhjbU0wTGxWSmJuUTJOQ2h3Y21salpWOXBibDl0YVdOeWIxOWhiR2R2S1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdjSEp2Y0dWeWRIbGZZWE56WlhSZmFXUTlZWEpqTkM1VlNXNTBOalFvZEhodVgzSmxjM1ZzZEM1amNtVmhkR1ZrWDJGemMyVjBMbWxrS1N3S0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5KaFkzUnBiMjVoYkY5eVpXRnNaWE4wWVhSbEwyTnZiblJ5WVdOMExuQjVPalU0TFRZeUNpQWdJQ0F2THlCelpXeG1MbXhwYzNSbFpGOXdjbTl3WlhKMGFXVnpXM0J5YjNCbGNuUjVYMkZrWkhKbGMzTmRJRDBnVUhKdmNHVnlkSGxUZEhKMVkzUW9DaUFnSUNBdkx5QWdJQ0FnWVdSa2NtVnpjejFoY21NMExsTjBjbWx1Wnlod2NtOXdaWEowZVY5aFpHUnlaWE56S1N3S0lDQWdJQzh2SUNBZ0lDQndjbWxqWlY5cGJsOXRhV055YjE5aGJHZHZQV0Z5WXpRdVZVbHVkRFkwS0hCeWFXTmxYMmx1WDIxcFkzSnZYMkZzWjI4cExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNCbGNuUjVYMkZ6YzJWMFgybGtQV0Z5WXpRdVZVbHVkRFkwS0hSNGJsOXlaWE4xYkhRdVkzSmxZWFJsWkY5aGMzTmxkQzVwWkNrc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ERXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUjRibDl5WlhOMWJIUXVZM0psWVhSbFpGOWhjM05sZEM1cFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTNWpiMjUwY21GamRDNUdjbUZqZEdsdmJtRnNVbVZoYkdWemRHRjBaUzVpZFhsZmNISnZjR1Z5ZEhsZmMyaGhjbVZ6S0hCeWIzQmxjblI1WDJGa1pISmxjM002SUdKNWRHVnpMQ0J6YUdGeVpYTTZJSFZwYm5RMk5Dd2djR0Y1YldWdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbUoxZVY5d2NtOXdaWEowZVY5emFHRnlaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qWTJMVFk1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1luVjVYM0J5YjNCbGNuUjVYM05vWVhKbGN5Z0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxDQndjbTl3WlhKMGVWOWhaR1J5WlhOek9pQlRkSEpwYm1jc0lITm9ZWEpsY3pvZ1ZVbHVkRFkwTENCd1lYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdLU0F0UGlCaWIyOXNPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5KaFkzUnBiMjVoYkY5eVpXRnNaWE4wWVhSbEwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJoYzNObGNuUWdjSEp2Y0dWeWRIbGZZV1JrY21WemN5QnBiaUJ6Wld4bUxteHBjM1JsWkY5d2NtOXdaWEowYVdWekxDQWlVSEp2Y0dWeWRIa2dibTkwSUd4cGMzUmxaQ0lLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblZ6WlhKeklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVSEp2Y0dWeWRIa2dibTkwSUd4cGMzUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvNE9Rb2dJQ0FnTHk4Z2NISnZjR1Z5ZEhsZmMzUnlkV04wSUQwZ2MyVnNaaTVzYVhOMFpXUmZjSEp2Y0dWeWRHbGxjMXR3Y205d1pYSjBlVjloWkdSeVpYTnpYUzVqYjNCNUtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXhwYzNSbFpGOXdjbTl3WlhKMGFXVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzVNQW9nSUNBZ0x5OGdjSEp2Y0dWeWRIbGZZWE56WlhSZmFXUWdQU0J3Y205d1pYSjBlVjl6ZEhKMVkzUXVjSEp2Y0dWeWRIbGZZWE56WlhSZmFXUXVibUYwYVhabENpQWdJQ0JwYm5Salh6TWdMeThnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5KaFkzUnBiMjVoYkY5eVpXRnNaWE4wWVhSbEwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1jbUZqZEdsdmJtRnNYM0psWVd4bGMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk9USXRPVFVLSUNBZ0lDOHZJR0Z6YzJWMFgySmhiR0Z1WTJVc0lHSnZiMndnUFNCdmNDNUJjM05sZEVodmJHUnBibWRIWlhRdVlYTnpaWFJmWW1Gc1lXNWpaU2dLSUNBZ0lDOHZJQ0FnSUNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lIQnliM0JsY25SNVgyRnpjMlYwWDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5KaFkzUnBiMjVoYkY5eVpXRnNaWE4wWVhSbEwyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMmhoY21WeklEdzlJR0Z6YzJWMFgySmhiR0Z1WTJVc0lDSk9iM1FnWlc1dmRXZG9JSE5vWVhKbGN5QmhkbUZwYkdGaWJHVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHVnViM1ZuYUNCemFHRnlaWE1nWVhaaGFXeGhZbXhsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1aGJXOTFiblFnUFQwZ2MyaGhjbVZ6TENBaVNXNTJZV3hwWkNCd1lYbHRaVzUwSUdGdGIzVnVkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0J3WVhsdFpXNTBJR0Z0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXdNQzB4TURJS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExDQWlTVzUyWVd4cFpDQndZWGx0Wlc1MElISmxZMlZwZG1WeUlnb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnY0dGNWJXVnVkQ0J5WldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5ObGJtUmxjaUE5UFNCVWVHNHVjMlZ1WkdWeUxDQWlTVzUyWVd4cFpDQndZWGx0Wlc1MElITmxibVJsY2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnY0dGNWJXVnVkQ0J6Wlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWNtRmpkR2x2Ym1Gc1gzSmxZV3hsYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRBMUxURXdPUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROWNISnZjR1Z5ZEhsZllYTnpaWFJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWMyaGhjbVZ6TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklHRnpjMlYwWDNKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1jbUZqZEdsdmJtRnNYM0psWVd4bGMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYeklnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TURVdE1UQTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxd2NtOXdaWEowZVY5aGMzTmxkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxemFHRnlaWE1zQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklISmxkSFZ5YmlCVWNuVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTNWpiMjUwY21GamRDNUdjbUZqZEdsdmJtRnNVbVZoYkdWemRHRjBaUzV6Wld4c1gzQnliM0JsY25SNVgzTm9ZWEpsY3lod2NtOXdaWEowZVY5aFpHUnlaWE56T2lCaWVYUmxjeXdnYzJWc2JGOTBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwelpXeHNYM0J5YjNCbGNuUjVYM05vWVhKbGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWNtRmpkR2x2Ym1Gc1gzSmxZV3hsYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRFekxURXhOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhObGJHeGZjSEp2Y0dWeWRIbGZjMmhoY21WektBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0lIQnliM0JsY25SNVgyRmtaSEpsYzNNNklGTjBjbWx1Wnl3Z2MyVnNiRjkwZUc0NklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUnlZVzV6WVdOMGFXOXVDaUFnSUNBdkx5QXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0J3Y205d1pYSjBlVjloWkdSeVpYTnpJR2x1SUhObGJHWXViR2x6ZEdWa1gzQnliM0JsY25ScFpYTXNJQ0pRY205d1pYSjBlU0J1YjNRZ2JHbHpkR1ZrSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZFhObGNuTWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJRY205d1pYSjBlU0J1YjNRZ2JHbHpkR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdjSEp2Y0dWeWRIbGZjM1J5ZFdOMElEMGdjMlZzWmk1c2FYTjBaV1JmY0hKdmNHVnlkR2xsYzF0d2NtOXdaWEowZVY5aFpHUnlaWE56WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14cGMzUmxaRjl3Y205d1pYSjBhV1Z6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TXpZS0lDQWdJQzh2SUhCeWIzQmxjblI1WDJGemMyVjBYMmxrSUQwZ2NISnZjR1Z5ZEhsZmMzUnlkV04wTG5CeWIzQmxjblI1WDJGemMyVjBYMmxrTG01aGRHbDJaUW9nSUNBZ2FXNTBZMTh6SUM4dklERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnlZV04wYVc5dVlXeGZjbVZoYkdWemRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeHNYM1I0Ymk1NFptVnlYMkZ6YzJWMExtbGtJRDA5SUhCeWIzQmxjblI1WDJGemMyVjBYMmxrTENBaVNXNTJZV3hwWkNCaGMzTmxkQ0JKUkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdZWE56WlhRZ1NVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWNtRmpkR2x2Ym1Gc1gzSmxZV3hsYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRRd0NpQWdJQ0F2THlCelpXeHNYM1I0Ymk1aGMzTmxkRjl5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaeVlXTjBhVzl1WVd4ZmNtVmhiR1Z6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TXprdE1UUXhDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJSE5sYkd4ZmRIaHVMbUZ6YzJWMFgzSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pKYm5aaGJHbGtJR0Z6YzJWMElISmxZMlZwZG1WeUlnb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWVhOelpYUWdjbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWNtRmpkR2x2Ym1Gc1gzSmxZV3hsYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRReUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc2JGOTBlRzR1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSkpiblpoYkdsa0lHRnpjMlYwSUhObGJtUmxjaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdZWE56WlhRZ2MyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR3hmZEhodUxtRnpjMlYwWDJGdGIzVnVkQ0ErUFNBeExDQWlTVzUyWVd4cFpDQmhjM05sZENCaGJXOTFiblFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJR0Z6YzJWMElHRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp5WVdOMGFXOXVZV3hmY21WaGJHVnpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hORFV0TVRRNENpQWdJQ0F2THlCMGVHNWZjbVZ6ZFd4MElEMGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxelpXeHNYM1I0Ymk1aGMzTmxkRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1jbUZqZEdsdmJtRnNYM0psWVd4bGMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UUTNDaUFnSUNBdkx5QnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWNtRmpkR2x2Ym1Gc1gzSmxZV3hsYzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCMGVHNWZjbVZ6ZFd4MElEMGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuSmhZM1JwYjI1aGJGOXlaV0ZzWlhOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFME5TMHhORGdLSUNBZ0lDOHZJSFI0Ymw5eVpYTjFiSFFnUFNCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWE5sYkd4ZmRIaHVMbUZ6YzJWMFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5KaFkzUnBiMjVoYkY5eVpXRnNaWE4wWVhSbEwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnY21WMGRYSnVJSFI0Ymw5eVpYTjFiSFF1WVcxdmRXNTBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpuSmhZM1JwYjI1aGJGOXlaV0ZzWlhOMFlYUmxMbU52Ym5SeVlXTjBMa1p5WVdOMGFXOXVZV3hTWldGc1pYTjBZWFJsTG1kbGRGOXdjbTl3WlhKMGVWOXBibVp2S0hCeWIzQmxjblI1WDJGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFgzQnliM0JsY25SNVgybHVabTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabkpoWTNScGIyNWhiRjl5WldGc1pYTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRTFNaTB4TlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZjSEp2Y0dWeWRIbGZhVzVtYnloelpXeG1MQ0J3Y205d1pYSjBlVjloWkdSeVpYTnpPaUJUZEhKcGJtY3BJQzArSUZCeWIzQmxjblI1VTNSeWRXTjBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5KaFkzUnBiMjVoYkY5eVpXRnNaWE4wWVhSbEwyTnZiblJ5WVdOMExuQjVPakUyTlFvZ0lDQWdMeThnWVhOelpYSjBJSEJ5YjNCbGNuUjVYMkZrWkhKbGMzTWdhVzRnYzJWc1ppNXNhWE4wWldSZmNISnZjR1Z5ZEdsbGN5d2dJbEJ5YjNCbGNuUjVJRzV2ZENCc2FYTjBaV1FpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oxYzJWeWN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRkJ5YjNCbGNuUjVJRzV2ZENCc2FYTjBaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1jbUZqZEdsdmJtRnNYM0psWVd4bGMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UWTJDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVzYVhOMFpXUmZjSEp2Y0dWeWRHbGxjMXR3Y205d1pYSjBlVjloWkdSeVpYTnpYUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YkdsemRHVmtYM0J5YjNCbGNuUnBaWE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQUVDaVlDQkJVZmZIVUZkWE5sY25NeEcwRUFvb0lFQk9oRktrTUVsckJiaEFTTnFHaG9CUGx0ZVp3MkdnQ09CQUJrQURrQUdBQUNJME14R1JSRU1SaEVOaG9CVndJQWlBRlNLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBREVXSWdsSk9CQWtFa1NJQVBVV0tFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBaGN4RmlJSlNUZ1FJaEpFaUFDSmdBRUFJMDhDVkNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSVhpQUFTRmloTVVMQWlRekVaUVA5OE1SZ1VSQ0pEaWdJQktZditVRW05UlFFVVJMRXlDa215S3JJcEk3SWppLyt5SW9BRVVGSlBVTElsaS82eUpvRURzaEFqc2dHenREeUwvaFVXVndZQ2kvNVFpLzhXU3dJV2dBSUFFazhDVUV4UVRGQkxBcnhJVHdKTXY0bUtBd0VwaS8xUVNiMUZBVVMrUkNWYk1ncExBWEFBU0l2K0QwU0wvemdJaS80U1JJdi9PQWN5Q2hKRWkvODRBREVBRWtTeE1RQ0wvcklTc2hTeUVTU3lFQ095QWJNaWlZb0NBU21ML2xCSnZVVUJSTDVFSlZ1TC96Z1JFa1NML3pnVU1nb1NSSXYvT0FBeEFCSkVpLzg0RWtsRXNURUFzZ2V5Q0NLeUVDT3lBYk8wQ0ltS0FRRXBpLzlRU2IxRkFVUytSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
