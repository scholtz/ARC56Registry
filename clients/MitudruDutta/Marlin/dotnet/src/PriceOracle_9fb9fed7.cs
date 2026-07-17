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

namespace Arc56.Generated.MitudruDutta.Marlin.PriceOracle_9fb9fed7
{


    //
    // Price oracle for reliable price feeds
    //
    public class PriceOracleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PriceOracleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetPriceInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetPriceInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPriceInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPriceInfoReturn);
                }
                public bool Equals(GetPriceInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPriceInfoReturn left, GetPriceInfoReturn right)
                {
                    return EqualityComparer<GetPriceInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPriceInfoReturn left, GetPriceInfoReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetThresholdInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetThresholdInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetThresholdInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetThresholdInfoReturn);
                }
                public bool Equals(GetThresholdInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetThresholdInfoReturn left, GetThresholdInfoReturn right)
                {
                    return EqualityComparer<GetThresholdInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetThresholdInfoReturn left, GetThresholdInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the price oracle
        ///</summary>
        public async Task<string> Initialize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 122, 209, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 122, 209, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a price updater (admin only)
        ///</summary>
        /// <param name="updater"> </param>
        public async Task<string> AddPriceUpdater(byte[] updater, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 153, 213, 154 };
            var updaterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); updaterAbi.From(updater);

            var result = await base.CallApp(new List<object> { abiHandle, updaterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AddPriceUpdater_Transactions(byte[] updater, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 153, 213, 154 };
            var updaterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); updaterAbi.From(updater);

            return await base.MakeTransactionList(new List<object> { abiHandle, updaterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update price with validation
        ///</summary>
        /// <param name="new_price"> </param>
        /// <param name="confidence"> </param>
        public async Task<string> UpdatePrice(ulong new_price, ulong confidence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 193, 18, 111 };
            var new_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_priceAbi.From(new_price);
            var confidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); confidenceAbi.From(confidence);

            var result = await base.CallApp(new List<object> { abiHandle, new_priceAbi, confidenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdatePrice_Transactions(ulong new_price, ulong confidence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 193, 18, 111 };
            var new_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_priceAbi.From(new_price);
            var confidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); confidenceAbi.From(confidence);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_priceAbi, confidenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set price threshold for monitoring
        ///</summary>
        /// <param name="threshold"> </param>
        public async Task<string> SetThreshold(ulong threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 198, 72, 60 };
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);

            var result = await base.CallApp(new List<object> { abiHandle, thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetThreshold_Transactions(ulong threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 198, 72, 60 };
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);

            return await base.MakeTransactionList(new List<object> { abiHandle, thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current price
        ///</summary>
        public async Task<ulong> GetPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 56, 120, 208 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 56, 120, 208 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get detailed price information
        ///</summary>
        public async Task<Structs.GetPriceInfoReturn> GetPriceInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 79, 228, 249 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPriceInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPriceInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 79, 228, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if price is stale
        ///</summary>
        public async Task<ulong> IsPriceStale(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 118, 222, 242 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsPriceStale_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 118, 222, 242 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if threshold has been reached
        ///</summary>
        public async Task<ulong> ThresholdReached(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 140, 255, 45 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ThresholdReached_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 140, 255, 45 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get threshold information
        ///</summary>
        public async Task<Structs.GetThresholdInfoReturn> GetThresholdInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 156, 83, 224 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetThresholdInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetThresholdInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 156, 83, 224 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Activate circuit breaker (admin only)
        ///</summary>
        public async Task<string> ActivateCircuitBreaker(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 160, 91, 48 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ActivateCircuitBreaker_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 160, 91, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reset circuit breaker (admin only)
        ///</summary>
        public async Task<string> ResetCircuitBreaker(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 69, 30, 170 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ResetCircuitBreaker_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 69, 30, 170 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause the oracle (admin only)
        ///</summary>
        public async Task<string> PauseOracle(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 228, 15, 225 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PauseOracle_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 228, 15, 225 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unpause the oracle (admin only)
        ///</summary>
        public async Task<string> UnpauseOracle(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 172, 85, 211 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnpauseOracle_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 172, 85, 211 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get oracle status
        ///</summary>
        public async Task<Structs.GetPriceInfoReturn> GetOracleStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 182, 88, 118 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPriceInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetOracleStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 182, 88, 118 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove active threshold (admin only)
        ///</summary>
        public async Task<string> RemoveThreshold(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 55, 105, 80 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RemoveThreshold_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 55, 105, 80 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get price history summary (simplified)
        ///</summary>
        public async Task<Structs.GetPriceInfoReturn> GetPriceHistorySummary(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 243, 100, 90 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPriceInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPriceHistorySummary_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 243, 100, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJpY2VPcmFjbGUiLCJkZXNjIjoiUHJpY2Ugb3JhY2xlIGZvciByZWxpYWJsZSBwcmljZSBmZWVkcyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRQcmljZUluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIkdldFRocmVzaG9sZEluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHByaWNlIG9yYWNsZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9wcmljZV91cGRhdGVyIiwiZGVzYyI6IkFkZCBhIHByaWNlIHVwZGF0ZXIgKGFkbWluIG9ubHkpIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVwZGF0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfcHJpY2UiLCJkZXNjIjoiVXBkYXRlIHByaWNlIHdpdGggdmFsaWRhdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbmZpZGVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdGhyZXNob2xkIiwiZGVzYyI6IlNldCBwcmljZSB0aHJlc2hvbGQgZm9yIG1vbml0b3JpbmciLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGhyZXNob2xkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ByaWNlIiwiZGVzYyI6IkdldCBjdXJyZW50IHByaWNlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcHJpY2VfaW5mbyIsImRlc2MiOiJHZXQgZGV0YWlsZWQgcHJpY2UgaW5mb3JtYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFByaWNlSW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfcHJpY2Vfc3RhbGUiLCJkZXNjIjoiQ2hlY2sgaWYgcHJpY2UgaXMgc3RhbGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRocmVzaG9sZF9yZWFjaGVkIiwiZGVzYyI6IkNoZWNrIGlmIHRocmVzaG9sZCBoYXMgYmVlbiByZWFjaGVkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdGhyZXNob2xkX2luZm8iLCJkZXNjIjoiR2V0IHRocmVzaG9sZCBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRUaHJlc2hvbGRJbmZvUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY3RpdmF0ZV9jaXJjdWl0X2JyZWFrZXIiLCJkZXNjIjoiQWN0aXZhdGUgY2lyY3VpdCBicmVha2VyIChhZG1pbiBvbmx5KSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc2V0X2NpcmN1aXRfYnJlYWtlciIsImRlc2MiOiJSZXNldCBjaXJjdWl0IGJyZWFrZXIgKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2Vfb3JhY2xlIiwiZGVzYyI6IlBhdXNlIHRoZSBvcmFjbGUgKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZV9vcmFjbGUiLCJkZXNjIjoiVW5wYXVzZSB0aGUgb3JhY2xlIChhZG1pbiBvbmx5KSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9vcmFjbGVfc3RhdHVzIiwiZGVzYyI6IkdldCBvcmFjbGUgc3RhdHVzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRQcmljZUluZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZV90aHJlc2hvbGQiLCJkZXNjIjoiUmVtb3ZlIGFjdGl2ZSB0aHJlc2hvbGQgKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ByaWNlX2hpc3Rvcnlfc3VtbWFyeSIsImRlc2MiOiJHZXQgcHJpY2UgaGlzdG9yeSBzdW1tYXJ5IChzaW1wbGlmaWVkKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0UHJpY2VJbmZvUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjExLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjEsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTAxMV0sImVycm9yTWVzc2FnZSI6IkNpcmN1aXQgYnJlYWtlciBhY3RpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDE5XSwiZXJyb3JNZXNzYWdlIjoiQ29uZmlkZW5jZSBjYW5ub3QgZXhjZWVkIDEwMCUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDQ4XSwiZXJyb3JNZXNzYWdlIjoiTm8gcHJpY2UgYXZhaWxhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0M10sImVycm9yTWVzc2FnZSI6Ik5vdCBhdXRob3JpemVkIHRvIHNldCB0aHJlc2hvbGQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQzXSwiZXJyb3JNZXNzYWdlIjoiTm90IGF1dGhvcml6ZWQgdG8gdXBkYXRlIHByaWNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM5LDQ1NSw0NzksNDk1LDUxOSw1NDMsNTY3LDU5MSw2MDcsNjI0LDY0MSw2NTcsNjc0LDcwMiw3MzQsNzY0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxM10sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIGFjdGl2YXRlIGNpcmN1aXQgYnJlYWtlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyMl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIGFkZCB1cGRhdGVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NDldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBwYXVzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MDldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiByZW1vdmUgdGhyZXNob2xkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHJlc2V0IGNpcmN1aXQgYnJlYWtlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NjddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiB1bnBhdXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBpbml0aWFsaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwNF0sImVycm9yTWVzc2FnZSI6Ik9yYWNsZSBpcyBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg4XSwiZXJyb3JNZXNzYWdlIjoiUHJpY2UgZGV2aWF0aW9uIHRvbyBsYXJnZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NjBdLCJlcnJvck1lc3NhZ2UiOiJQcmljZSBpcyBzdGFsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTRdLCJlcnJvck1lc3NhZ2UiOiJQcmljZSBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxOV0sImVycm9yTWVzc2FnZSI6IlRocmVzaG9sZCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA3NV0sImVycm9yTWVzc2FnZSI6IlVwZGF0ZSB0b28gZnJlcXVlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDIsNDU4LDQ4Miw0OTgsNTIyLDU0Niw1NzAsNTk0LDYxMCw2MjcsNjQ0LDY2MCw2NzcsNzA1LDczNyw3NjddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIwLDEwMjUsMTMyNSwxNjExLDE2MjksMTY0NywxNjY1LDE3MDddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDksMTY4OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY2lyY3VpdF9icmVha2VyX2FjdGl2ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDAyLDE2ODJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzX3BhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM2LDEzMzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzX3VwZGF0ZXIgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWF4X3ByaWNlX2RldmlhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taW5fdXBkYXRlX2ludGVydmFsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnByaWNlX2NvbmZpZGVuY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2MCwxNDQ1LDE0NzAsMTQ5NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJpY2VfdGltZXN0YW1wIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NTUsMTUwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3RhbGVuZXNzX3RocmVzaG9sZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTI0LDE1MzEsMTYwMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGhyZXNob2xkX2FjdGl2ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQwLDE1NTYsMTU5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGhyZXNob2xkX3ByaWNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTMsMTQ0MSwxNDY1LDE1NDgsMTc3NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG9rZW5fcHJpY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI3LDE2OTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVwZGF0ZXJfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjSEpwWTJWZmIzSmhZMnhsTG1OdmJuUnlZV04wTGxCeWFXTmxUM0poWTJ4bExsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0F4TURBd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSmhaRzFwYmlJZ0luUnZhMlZ1WDNCeWFXTmxJaUFpY0hKcFkyVmZkR2x0WlhOMFlXMXdJaUFpZEdoeVpYTm9iMnhrWDNCeWFXTmxJaUFpZEdoeVpYTm9iMnhrWDJGamRHbDJaU0lnSW1OcGNtTjFhWFJmWW5KbFlXdGxjaUlnSW1selgzQmhkWE5sWkNJZ0luVndaR0YwWlhKZlkyOTFiblFpSUNKemRHRnNaVzVsYzNOZmRHaHlaWE5vYjJ4a0lpQWljSEpwWTJWZlkyOXVabWxrWlc1alpTSWdJbWx6WDNWd1pHRjBaWElpSUNKdFlYaGZjSEpwWTJWZlpHVjJhV0YwYVc5dUlpQWliV2x1WDNWd1pHRjBaVjlwYm5SbGNuWmhiQ0lnTUhnME16WTVOekkyTXpjMU5qazNOREl3TmpJM01qWTFOakUyWWpZMU56SXlNRFl4TmpNM05EWTVOelkyTVRjME5qVTJOQ0F3ZURRek5qazNNall6TnpVMk9UYzBNakEyTWpjeU5qVTJNVFppTmpVM01qSXdOekkyTlRjek5qVTNOQ0F3ZURSbU56STJNVFl6Tm1NMk5USXdOekEyTVRjMU56TTJOVFkwSURCNE5HWTNNall4TmpNMll6WTFNakEzTlRabE56QTJNVGMxTnpNMk5UWTBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPalF4TFRReUNpQWdJQ0F2THlBaklGQnlhV05sSUdOdmJuTjBZVzUwY3dvZ0lDQWdMeThnYzJWc1ppNXRZWGhmY0hKcFkyVmZaR1YyYVdGMGFXOXVJRDBnVlVsdWREWTBLREV3TURBcElDQWpJREV3SlNCcGJpQmlZWE5wY3lCd2IybHVkSE1LSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0p0WVhoZmNISnBZMlZmWkdWMmFXRjBhVzl1SWdvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3SUM4dklERXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnpaV3htTG0xcGJsOTFjR1JoZEdWZmFXNTBaWEoyWVd3Z1BTQlZTVzUwTmpRb016QXdLU0FnSUNNZ05TQnRhVzUxZEdWekNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaWJXbHVYM1Z3WkdGMFpWOXBiblJsY25aaGJDSUtJQ0FnSUhCMWMyaHBiblFnTXpBd0lDOHZJRE13TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJSE5sYkdZdWMzUmhiR1Z1WlhOelgzUm9jbVZ6YUc5c1pDQTlJRlZKYm5RMk5DZ3pOakF3S1NBZ0l5QXhJR2h2ZFhJS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5OMFlXeGxibVZ6YzE5MGFISmxjMmh2YkdRaUNpQWdJQ0J3ZFhOb2FXNTBJRE0yTURBZ0x5OGdNell3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1kyeGhjM01nVUhKcFkyVlBjbUZqYkdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF5TVFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURnNU4yRmtNV0UzSURCNFpHUTVPV1ExT1dFZ01IZ3hNbU14TVRJMlppQXdlRGRrWXpZME9ETmpJREI0TldRek9EYzRaREFnTUhneE5EUm1aVFJtT1NBd2VEWmhOelprWldZeUlEQjRabUU0WTJabU1tUWdNSGhtWkRsak5UTmxNQ0F3ZURRMVlUQTFZak13SURCNE4yRTBOVEZsWVdFZ01IZzJabVUwTUdabE1TQXdlRGhrWVdNMU5XUXpJREI0TnpSaU5qVTROellnTUhneU5UTTNOamsxTUNBd2VEUmpaak0yTkRWaElDOHZJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaU2dwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0poWkdSZmNISnBZMlZmZFhCa1lYUmxjaWhpZVhSbFcxMHBjM1J5YVc1bklpd2diV1YwYUc5a0lDSjFjR1JoZEdWZmNISnBZMlVvZFdsdWREWTBMSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTmxkRjkwYUhKbGMyaHZiR1FvZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwWDNCeWFXTmxLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5d2NtbGpaVjlwYm1adktDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKcGMxOXdjbWxqWlY5emRHRnNaU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owYUhKbGMyaHZiR1JmY21WaFkyaGxaQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZmRHaHlaWE5vYjJ4a1gybHVabThvS1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWVdOMGFYWmhkR1ZmWTJseVkzVnBkRjlpY21WaGEyVnlLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbkpsYzJWMFgyTnBjbU4xYVhSZlluSmxZV3RsY2lncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKd1lYVnpaVjl2Y21GamJHVW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkVzV3WVhWelpWOXZjbUZqYkdVb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBYMjl5WVdOc1pWOXpkR0YwZFhNb0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW5KbGJXOTJaVjkwYUhKbGMyaHZiR1FvS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFgzQnlhV05sWDJocGMzUnZjbmxmYzNWdGJXRnllU2dwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmFXNXBkR2xoYkdsNlpWOXliM1YwWlVBMUlHMWhhVzVmWVdSa1gzQnlhV05sWDNWd1pHRjBaWEpmY205MWRHVkFOaUJ0WVdsdVgzVndaR0YwWlY5d2NtbGpaVjl5YjNWMFpVQTNJRzFoYVc1ZmMyVjBYM1JvY21WemFHOXNaRjl5YjNWMFpVQTRJRzFoYVc1ZloyVjBYM0J5YVdObFgzSnZkWFJsUURrZ2JXRnBibDluWlhSZmNISnBZMlZmYVc1bWIxOXliM1YwWlVBeE1DQnRZV2x1WDJselgzQnlhV05sWDNOMFlXeGxYM0p2ZFhSbFFERXhJRzFoYVc1ZmRHaHlaWE5vYjJ4a1gzSmxZV05vWldSZmNtOTFkR1ZBTVRJZ2JXRnBibDluWlhSZmRHaHlaWE5vYjJ4a1gybHVabTlmY205MWRHVkFNVE1nYldGcGJsOWhZM1JwZG1GMFpWOWphWEpqZFdsMFgySnlaV0ZyWlhKZmNtOTFkR1ZBTVRRZ2JXRnBibDl5WlhObGRGOWphWEpqZFdsMFgySnlaV0ZyWlhKZmNtOTFkR1ZBTVRVZ2JXRnBibDl3WVhWelpWOXZjbUZqYkdWZmNtOTFkR1ZBTVRZZ2JXRnBibDkxYm5CaGRYTmxYMjl5WVdOc1pWOXliM1YwWlVBeE55QnRZV2x1WDJkbGRGOXZjbUZqYkdWZmMzUmhkSFZ6WDNKdmRYUmxRREU0SUcxaGFXNWZjbVZ0YjNabFgzUm9jbVZ6YUc5c1pGOXliM1YwWlVBeE9TQnRZV2x1WDJkbGRGOXdjbWxqWlY5b2FYTjBiM0o1WDNOMWJXMWhjbmxmY205MWRHVkFNakFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5YVdObFQzSmhZMnhsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl3Y21salpWOW9hWE4wYjNKNVgzTjFiVzFoY25sZmNtOTFkR1ZBTWpBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakk1TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzQnlhV05sWDJocGMzUnZjbmxmYzNWdGJXRnllUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaVzF2ZG1WZmRHaHlaWE5vYjJ4a1gzSnZkWFJsUURFNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG95TmpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhKbGJXOTJaVjkwYUhKbGMyaHZiR1FLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl2Y21GamJHVmZjM1JoZEhWelgzSnZkWFJsUURFNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG95TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5dmNtRmpiR1ZmYzNSaGRIVnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzVnVjR0YxYzJWZmIzSmhZMnhsWDNKdmRYUmxRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3lORGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJSFZ1Y0dGMWMyVmZiM0poWTJ4bENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl3WVhWelpWOXZjbUZqYkdWZmNtOTFkR1ZBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakl6T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnY0dGMWMyVmZiM0poWTJ4bENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WlhObGRGOWphWEpqZFdsMFgySnlaV0ZyWlhKZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnY21WelpYUmZZMmx5WTNWcGRGOWljbVZoYTJWeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWTNScGRtRjBaVjlqYVhKamRXbDBYMkp5WldGclpYSmZjbTkxZEdWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJeE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1lXTjBhWFpoZEdWZlkybHlZM1ZwZEY5aWNtVmhhMlZ5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmZEdoeVpYTm9iMnhrWDJsdVptOWZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJeE1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzUm9jbVZ6YUc5c1pGOXBibVp2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JvY21WemFHOXNaRjl5WldGamFHVmtYM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE9Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhSb2NtVnphRzlzWkY5eVpXRmphR1ZrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmx6WDNCeWFXTmxYM04wWVd4bFgzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TnpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2x6WDNCeWFXTmxYM04wWVd4bENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXdjbWxqWlY5cGJtWnZYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE5qY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOXdjbWxqWlY5cGJtWnZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl3Y21salpWOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TlRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5d2NtbGpaUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJmZEdoeVpYTm9iMnhrWDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qRXpPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJR05zWVhOeklGQnlhV05sVDNKaFkyeGxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhObGRGOTBhSEpsYzJodmJHUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWd1pHRjBaVjl3Y21salpWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdOc1lYTnpJRkJ5YVdObFQzSmhZMnhsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2RYQmtZWFJsWDNCeWFXTmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpHUmZjSEpwWTJWZmRYQmtZWFJsY2w5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJR05zWVhOeklGQnlhV05sVDNKaFkyeGxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR0ZrWkY5d2NtbGpaVjkxY0dSaGRHVnlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5cGJtbDBhV0ZzYVhwbFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJwYm1sMGFXRnNhWHBsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJqYkdGemN5QlFjbWxqWlU5eVlXTnNaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TXdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNISnBZMlZmYjNKaFkyeGxMbU52Ym5SeVlXTjBMbEJ5YVdObFQzSmhZMnhsTG1sdWFYUnBZV3hwZW1Vb0tTQXRQaUJpZVhSbGN6b0thVzVwZEdsaGJHbDZaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHbHVhWFJwWVd4cGVtVWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnBibWwwYVdGc2FYcGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCelpXeG1MbUZrYldsdUxuWmhiSFZsSUQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG8yTmdvZ0lDQWdMeThnYzJWc1ppNWphWEpqZFdsMFgySnlaV0ZyWlhKZllXTjBhWFpsTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pqYVhKamRXbDBYMkp5WldGclpYSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUhObGJHWXVhWE5mY0dGMWMyVmtMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnBjMTl3WVhWelpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUhObGJHWXVkWEJrWVhSbGNsOWpiM1Z1ZEM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZFhCa1lYUmxjbDlqYjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnYzJWc1ppNTBiMnRsYmw5d2NtbGpaUzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzlyWlc1ZmNISnBZMlVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklITmxiR1l1Y0hKcFkyVmZkR2x0WlhOMFlXMXdMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndjbWxqWlY5MGFXMWxjM1JoYlhBaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJSE5sYkdZdWNISnBZMlZmWTI5dVptbGtaVzVqWlM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5CeWFXTmxYMk52Ym1acFpHVnVZMlVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklITmxiR1l1ZEdoeVpYTm9iMnhrWDNCeWFXTmxMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBhSEpsYzJodmJHUmZjSEpwWTJVaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJSE5sYkdZdWRHaHlaWE5vYjJ4a1gyRmpkR2wyWlM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEdoeVpYTm9iMnhrWDJGamRHbDJaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRvM05TMDNOZ29nSUNBZ0x5OGdJeUJCWkdRZ1lXUnRhVzRnWVhNZ1ptbHljM1FnY0hKcFkyVWdkWEJrWVhSbGNnb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5MWNHUmhkR1Z5VzFSNGJpNXpaVzVrWlhKZElEMGdWVWx1ZERZMEtERXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWFYTmZkWEJrWVhSbGNpSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJ6Wld4bUxuVndaR0YwWlhKZlkyOTFiblF1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblZ3WkdGMFpYSmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZOemtLSUNBZ0lDOHZJR3h2WnloaUlsQnlhV05sVDNKaFkyeGxJR2x1YVhScFlXeHBlbVZrSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVd056STJPVFl6TmpVMFpqY3lOakUyTXpaak5qVXlNRFk1Tm1VMk9UYzBOamsyTVRaak5qazNZVFkxTmpRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVVISnBZMlVnYjNKaFkyeGxJR2x1YVhScFlXeHBlbVZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsQnlhV05sSUc5eVlXTnNaU0JwYm1sMGFXRnNhWHBsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNISnBZMlZmYjNKaFkyeGxMbU52Ym5SeVlXTjBMbEJ5YVdObFQzSmhZMnhsTG1Ga1pGOXdjbWxqWlY5MWNHUmhkR1Z5S0hWd1pHRjBaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWVdSa1gzQnlhV05sWDNWd1pHRjBaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qZ3lMVGd6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJoWkdSZmNISnBZMlZmZFhCa1lYUmxjaWh6Wld4bUxDQjFjR1JoZEdWeU9pQkNlWFJsY3lrZ0xUNGdVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlUMjVzZVNCaFpHMXBiaUJqWVc0Z1lXUmtJSFZ3WkdGMFpYSnpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQmhaR1FnZFhCa1lYUmxjbk1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk9EY3RPRGtLSUNBZ0lDOHZJQ01nU1c0Z2NISnZaSFZqZEdsdmJpd2dkMjkxYkdRZ2JtVmxaQ0J3Y205d1pYSWdZV1JrY21WemN5QjJZV3hwWkdGMGFXOXVDaUFnSUNBdkx5QWpJRVp2Y2lCemFXMXdiR2xqYVhSNUxDQnFkWE4wSUdsdVkzSmxiV1Z1ZEdsdVp5QmpiM1Z1ZEFvZ0lDQWdMeThnYzJWc1ppNTFjR1JoZEdWeVgyTnZkVzUwTG5aaGJIVmxJRDBnYzJWc1ppNTFjR1JoZEdWeVgyTnZkVzUwTG5aaGJIVmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkWEJrWVhSbGNsOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTFjR1JoZEdWeVgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5Wd1pHRjBaWEpmWTI5MWJuUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRvNU1Rb2dJQ0FnTHk4Z2JHOW5LR0lpVUhKcFkyVWdkWEJrWVhSbGNpQmhaR1JsWkNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU1EY3lOamsyTXpZMU1qQTNOVGN3TmpRMk1UYzBOalUzTWpJd05qRTJORFkwTmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlFjbWxqWlNCMWNHUmhkR1Z5SUdGa1pHVmtJSE4xWTJObGMzTm1kV3hzZVNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxCeWFXTmxJSFZ3WkdGMFpYSWdZV1JrWldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnlhV05sWDI5eVlXTnNaUzVqYjI1MGNtRmpkQzVRY21salpVOXlZV05zWlM1MWNHUmhkR1ZmY0hKcFkyVW9ibVYzWDNCeWFXTmxPaUIxYVc1ME5qUXNJR052Ym1acFpHVnVZMlU2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25Wd1pHRjBaVjl3Y21salpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2T1RRdE9Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlIVndaR0YwWlY5d2NtbGpaU2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUc1bGQxOXdjbWxqWlRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHTnZibVpwWkdWdVkyVTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDa2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpYM0JoZFhObFpDNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pQY21GamJHVWdhWE1nY0dGMWMyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltbHpYM0JoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5d1lYVnpaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDNKaFkyeGxJR2x6SUhCaGRYTmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbU5wY21OMWFYUmZZbkpsWVd0bGNsOWhZM1JwZG1VdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RBcExDQWlRMmx5WTNWcGRDQmljbVZoYTJWeUlHRmpkR2wyWlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pqYVhKamRXbDBYMkp5WldGclpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTJseVkzVnBkRjlpY21WaGEyVnlYMkZqZEdsMlpTQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhWEpqZFdsMElHSnlaV0ZyWlhJZ1lXTjBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdZWE56WlhKMElHNWxkMTl3Y21salpTQStJRlZKYm5RMk5DZ3dLU3dnSWxCeWFXTmxJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtbGpaU0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pFd05Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJtWnBaR1Z1WTJVZ1BEMGdWVWx1ZERZMEtERXdNREF3S1N3Z0lrTnZibVpwWkdWdVkyVWdZMkZ1Ym05MElHVjRZMlZsWkNBeE1EQWxJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXVabWxrWlc1alpTQmpZVzV1YjNRZ1pYaGpaV1ZrSURFd01DVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TVRBNUNpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVZ2IzSWdjMlZzWmk1cGMxOTFjR1JoZEdWeVcxUjRiaTV6Wlc1a1pYSmRJRDA5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQjFjR1JoZEdWZmNISnBZMlZmWW05dmJGOTBjblZsUURJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlhWE5mZFhCa1lYUmxjaUlLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzVndaR0YwWlhJZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSjZJSFZ3WkdGMFpWOXdjbWxqWlY5aWIyOXNYMlpoYkhObFFETUtDblZ3WkdGMFpWOXdjbWxqWlY5aWIyOXNYM1J5ZFdWQU1qb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncDFjR1JoZEdWZmNISnBZMlZmWW05dmJGOXRaWEpuWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TURZdE1URXdDaUFnSUNBdkx5QWpJRU5vWldOcklHbG1JSE5sYm1SbGNpQnBjeUJoZFhSb2IzSnBlbVZrSUhWd1pHRjBaWElnS0hOcGJYQnNhV1pwWldRcENpQWdJQ0F2THlBaklFbHVJSEJ5YjJSMVkzUnBiMjRzSUhkdmRXeGtJR05vWldOcklHRm5ZV2x1YzNRZ2MzUnZjbVZrSUhWd1pHRjBaWElnYkdsemRBb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdiM0lnYzJWc1ppNXBjMTkxY0dSaGRHVnlXMVI0Ymk1elpXNWtaWEpkSUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnTHk4Z0tTd2dJazV2ZENCaGRYUm9iM0pwZW1Wa0lIUnZJSFZ3WkdGMFpTQndjbWxqWlNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ1lYVjBhRzl5YVhwbFpDQjBieUIxY0dSaGRHVWdjSEpwWTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJqZFhKeVpXNTBYM0J5YVdObElEMGdjMlZzWmk1MGIydGxibDl3Y21salpTNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2YTJWdVgzQnlhV05sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMnRsYmw5d2NtbGpaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCamRYSnlaVzUwWDNScGJXVnpkR0Z0Y0NBOUlITmxiR1l1Y0hKcFkyVmZkR2x0WlhOMFlXMXdMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0hKcFkyVmZkR2x0WlhOMFlXMXdJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKcFkyVmZkR2x0WlhOMFlXMXdJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TVRVdE1URTJDaUFnSUNBdkx5QWpJRU5vWldOcklHMXBibWx0ZFcwZ2RYQmtZWFJsSUdsdWRHVnlkbUZzSUdadmNpQmxlR2x6ZEdsdVp5QndjbWxqWlhNS0lDQWdJQzh2SUdsbUlHTjFjbkpsYm5SZmNISnBZMlVnUGlCVlNXNTBOalFvTUNrNkNpQWdJQ0JpZWlCMWNHUmhkR1ZmY0hKcFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQajBnWTNWeWNtVnVkRjkwYVcxbGMzUmhiWEFnS3lCelpXeG1MbTFwYmw5MWNHUmhkR1ZmYVc1MFpYSjJZV3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWliV2x1WDNWd1pHRjBaVjlwYm5SbGNuWmhiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGFXNWZkWEJrWVhSbFgybHVkR1Z5ZG1Gc0lHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lDc0tJQ0FnSUQ0OUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakV4TnkweE1Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1BqMGdZM1Z5Y21WdWRGOTBhVzFsYzNSaGJYQWdLeUJ6Wld4bUxtMXBibDkxY0dSaGRHVmZhVzUwWlhKMllXd0tJQ0FnSUM4dklDa3NJQ0pWY0dSaGRHVWdkRzl2SUdaeVpYRjFaVzUwSWdvZ0lDQWdZWE56WlhKMElDOHZJRlZ3WkdGMFpTQjBiMjhnWm5KbGNYVmxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1qYzVDaUFnSUNBdkx5QnBaaUJ2YkdSZmNISnBZMlVnUFQwZ1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0p1ZWlCMWNHUmhkR1ZmY0hKcFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG95T0RBS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3AxY0dSaGRHVmZjSEpwWTJWZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVjSEpwWTJWZmIzSmhZMnhsTG1OdmJuUnlZV04wTGxCeWFXTmxUM0poWTJ4bExsOWpZV3hqZFd4aGRHVmZaR1YyYVdGMGFXOXVRREU1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hNak1LSUNBZ0lDOHZJR0Z6YzJWeWRDQmtaWFpwWVhScGIyNGdQRDBnYzJWc1ppNXRZWGhmY0hKcFkyVmZaR1YyYVdGMGFXOXVMQ0FpVUhKcFkyVWdaR1YyYVdGMGFXOXVJSFJ2YnlCc1lYSm5aU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWliV0Y0WDNCeWFXTmxYMlJsZG1saGRHbHZiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dFlYaGZjSEpwWTJWZlpHVjJhV0YwYVc5dUlHVjRhWE4wY3dvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFjbWxqWlNCa1pYWnBZWFJwYjI0Z2RHOXZJR3hoY21kbENncDFjR1JoZEdWZmNISnBZMlZmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE1qY3RNVEk0Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0J3Y21salpTQmtZWFJoQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZhMlZ1WDNCeWFXTmxMblpoYkhWbElEMGdibVYzWDNCeWFXTmxDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiMnRsYmw5d2NtbGpaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1USTVDaUFnSUNBdkx5QnpaV3htTG5CeWFXTmxYM1JwYldWemRHRnRjQzUyWVd4MVpTQTlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd2NtbGpaVjkwYVcxbGMzUmhiWEFpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hNekFLSUNBZ0lDOHZJSE5sYkdZdWNISnBZMlZmWTI5dVptbGtaVzVqWlM1MllXeDFaU0E5SUdOdmJtWnBaR1Z1WTJVS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKd2NtbGpaVjlqYjI1bWFXUmxibU5sSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hNekVLSUNBZ0lDOHZJSE5sYkdZdWNISnBZMlZmZFhCa1lYUmxjaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUhCMWMyaGllWFJsY3lBaWNISnBZMlZmZFhCa1lYUmxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJNU1nb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1MGFISmxjMmh2YkdSZllXTjBhWFpsTG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d4S1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owYUhKbGMyaHZiR1JmWVdOMGFYWmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Sb2NtVnphRzlzWkY5aFkzUnBkbVVnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhWd1pHRjBaVjl3Y21salpWOWhablJsY2w5cFpsOWxiSE5sUURFeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakk1TXdvZ0lDQWdMeThnZEdoeVpYTm9iMnhrSUQwZ2MyVnNaaTUwYUhKbGMyaHZiR1JmY0hKcFkyVXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owYUhKbGMyaHZiR1JmY0hKcFkyVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Sb2NtVnphRzlzWkY5d2NtbGpaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TWprMENpQWdJQ0F2THlCcFppQmpkWEp5Wlc1MFgzQnlhV05sSUQ0OUlIUm9jbVZ6YUc5c1pEb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnUEQwS0lDQWdJR0o2SUhWd1pHRjBaVjl3Y21salpWOWhablJsY2w5cFpsOWxiSE5sUURFeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakk1TlFvZ0lDQWdMeThnYkc5bktHSWlWR2h5WlhOb2IyeGtJSEpsWVdOb1pXUWdMU0JRY21salpUb2dJaUFySUc5d0xtbDBiMklvWTNWeWNtVnVkRjl3Y21salpTa2dLeUJpSWlCVWFISmxjMmh2YkdRNklDSWdLeUJ2Y0M1cGRHOWlLSFJvY21WemFHOXNaQ2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFUwTmpnM01qWTFOek0yT0RabU5tTTJOREl3TnpJMk5UWXhOak0yT0RZMU5qUXlNREprTWpBMU1EY3lOamsyTXpZMU0yRXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TURVME5qZzNNalkxTnpNMk9EWm1ObU0yTkROaE1qQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DZ3AxY0dSaGRHVmZjSEpwWTJWZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNVE0yQ2lBZ0lDQXZMeUJzYjJjb1lpSlFjbWxqWlNCMWNHUmhkR1ZrSUMwZ1QyeGtPaUFpSUNzZ2IzQXVhWFJ2WWlodmJHUmZjSEpwWTJVcElDc2dZaUlnVG1WM09pQWlJQ3NnYjNBdWFYUnZZaWh1WlhkZmNISnBZMlVwS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFV3TnpJMk9UWXpOalV5TURjMU56QTJORFl4TnpRMk5UWTBNakF5WkRJd05HWTJZelkwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lNRFJsTmpVM056TmhNakFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hNemNLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsQnlhV05sSUhWd1pHRjBaV1FnYzNWalkyVnpjMloxYkd4NUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVVISnBZMlVnZFhCa1lYUmxaQ0J6ZFdOalpYTnpablZzYkhraUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tkWEJrWVhSbFgzQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qSTRNZ29nSUNBZ0x5OGdhV1lnYjJ4a1gzQnlhV05sSUQ0Z2JtVjNYM0J5YVdObE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQZ29nSUNBZ1lub2dkWEJrWVhSbFgzQnlhV05sWDJWc2MyVmZZbTlrZVVBeE53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG95T0RNS0lDQWdJQzh2SUdSbGRtbGhkR2x2YmlBOUlDZ29iMnhrWDNCeWFXTmxJQzBnYm1WM1gzQnlhV05sS1NBcUlGVkpiblEyTkNneE1EQXdNQ2twSUM4dklHOXNaRjl3Y21salpRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREFLSUNBZ0lDb0tJQ0FnSUhOM1lYQUtJQ0FnSUM4S0lDQWdJR0lnZFhCa1lYUmxYM0J5YVdObFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ5YVdObFgyOXlZV05zWlM1amIyNTBjbUZqZEM1UWNtbGpaVTl5WVdOc1pTNWZZMkZzWTNWc1lYUmxYMlJsZG1saGRHbHZia0F4T1FvS2RYQmtZWFJsWDNCeWFXTmxYMlZzYzJWZlltOWtlVUF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNamcxQ2lBZ0lDQXZMeUJrWlhacFlYUnBiMjRnUFNBb0tHNWxkMTl3Y21salpTQXRJRzlzWkY5d2NtbGpaU2tnS2lCVlNXNTBOalFvTVRBd01EQXBLU0F2THlCdmJHUmZjSEpwWTJVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh5SUM4dklERXdNREF3Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNBdkNpQWdJQ0JpSUhWd1pHRjBaVjl3Y21salpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV3Y21salpWOXZjbUZqYkdVdVkyOXVkSEpoWTNRdVVISnBZMlZQY21GamJHVXVYMk5oYkdOMWJHRjBaVjlrWlhacFlYUnBiMjVBTVRrS0NuVndaR0YwWlY5d2NtbGpaVjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUIxY0dSaGRHVmZjSEpwWTJWZlltOXZiRjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CeWFXTmxYMjl5WVdOc1pTNWpiMjUwY21GamRDNVFjbWxqWlU5eVlXTnNaUzV6WlhSZmRHaHlaWE5vYjJ4a0tIUm9jbVZ6YUc5c1pEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tjMlYwWDNSb2NtVnphRzlzWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNVE01TFRFME1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2MyVjBYM1JvY21WemFHOXNaQ2h6Wld4bUxDQjBhSEpsYzJodmJHUTZJRlZKYm5RMk5Da2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakUwTWdvZ0lDQWdMeThnWVhOelpYSjBJSFJvY21WemFHOXNaQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lsUm9jbVZ6YUc5c1pDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGNuUWdMeThnVkdoeVpYTm9iMnhrSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1UUTBDaUFnSUNBdkx5QlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdiM0lnYzJWc1ppNXBjMTkxY0dSaGRHVnlXMVI0Ymk1elpXNWtaWEpkSUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ6WlhSZmRHaHlaWE5vYjJ4a1gySnZiMnhmZEhKMVpVQXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1selgzVndaR0YwWlhJaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBjMTkxY0dSaGRHVnlJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCelpYUmZkR2h5WlhOb2IyeGtYMkp2YjJ4ZlptRnNjMlZBTXdvS2MyVjBYM1JvY21WemFHOXNaRjlpYjI5c1gzUnlkV1ZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwelpYUmZkR2h5WlhOb2IyeGtYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNVFF6TFRFME5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdiM0lnYzJWc1ppNXBjMTkxY0dSaGRHVnlXMVI0Ymk1elpXNWtaWEpkSUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnTHk4Z0tTd2dJazV2ZENCaGRYUm9iM0pwZW1Wa0lIUnZJSE5sZENCMGFISmxjMmh2YkdRaUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHRjFkR2h2Y21sNlpXUWdkRzhnYzJWMElIUm9jbVZ6YUc5c1pBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TkRjS0lDQWdJQzh2SUhObGJHWXVkR2h5WlhOb2IyeGtYM0J5YVdObExuWmhiSFZsSUQwZ2RHaHlaWE5vYjJ4a0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGFISmxjMmh2YkdSZmNISnBZMlVpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdjMlZzWmk1MGFISmxjMmh2YkdSZllXTjBhWFpsTG5aaGJIVmxJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owYUhKbGMyaHZiR1JmWVdOMGFYWmxJZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pFME9Rb2dJQ0FnTHk4Z2MyVnNaaTUwYUhKbGMyaHZiR1JmYzJWMGRHVnlMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKMGFISmxjMmh2YkdSZmMyVjBkR1Z5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1UVXhDaUFnSUNBdkx5QnNiMmNvWWlKVWFISmxjMmh2YkdRZ2MyVjBJQzBnVm1Gc2RXVTZJQ0lnS3lCdmNDNXBkRzlpS0hSb2NtVnphRzlzWkNrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVME5qZzNNalkxTnpNMk9EWm1ObU0yTkRJd056TTJOVGMwTWpBeVpESXdOVFkyTVRaak56VTJOVE5oTWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakUxTWdvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lWR2h5WlhOb2IyeGtJSE5sZENCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlVhSEpsYzJodmJHUWdjMlYwSUhOMVkyTmxjM05tZFd4c2VTSUtJQ0FnSUhKbGRITjFZZ29LYzJWMFgzUm9jbVZ6YUc5c1pGOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnpaWFJmZEdoeVpYTm9iMnhrWDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3Y21salpWOXZjbUZqYkdVdVkyOXVkSEpoWTNRdVVISnBZMlZQY21GamJHVXVaMlYwWDNCeWFXTmxLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUmZjSEpwWTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakUxTndvZ0lDQWdMeThnWTNWeWNtVnVkRjl3Y21salpTQTlJSE5sYkdZdWRHOXJaVzVmY0hKcFkyVXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjJ0bGJsOXdjbWxqWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMnRsYmw5d2NtbGpaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TVRVNENpQWdJQ0F2THlCd2NtbGpaVjkwYVcxbGMzUmhiWEFnUFNCelpXeG1MbkJ5YVdObFgzUnBiV1Z6ZEdGdGNDNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkJ5YVdObFgzUnBiV1Z6ZEdGdGNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y21salpWOTBhVzFsYzNSaGJYQWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakUyTUFvZ0lDQWdMeThnWVhOelpYSjBJR04xY25KbGJuUmZjSEpwWTJVZ1BpQlZTVzUwTmpRb01Da3NJQ0pPYnlCd2NtbGpaU0JoZG1GcGJHRmliR1VpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUhCeWFXTmxJR0YyWVdsc1lXSnNaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUR3OUlIQnlhV05sWDNScGJXVnpkR0Z0Y0NBcklITmxiR1l1YzNSaGJHVnVaWE56WDNSb2NtVnphRzlzWkFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbk4wWVd4bGJtVnpjMTkwYUhKbGMyaHZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhiR1Z1WlhOelgzUm9jbVZ6YUc5c1pDQmxlR2x6ZEhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnUEQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNVFl4TFRFMk13b2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBOFBTQndjbWxqWlY5MGFXMWxjM1JoYlhBZ0t5QnpaV3htTG5OMFlXeGxibVZ6YzE5MGFISmxjMmh2YkdRS0lDQWdJQzh2SUNrc0lDSlFjbWxqWlNCcGN5QnpkR0ZzWlNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJRY21salpTQnBjeUJ6ZEdGc1pRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TmpVS0lDQWdJQzh2SUhKbGRIVnliaUJqZFhKeVpXNTBYM0J5YVdObENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0hKcFkyVmZiM0poWTJ4bExtTnZiblJ5WVdOMExsQnlhV05sVDNKaFkyeGxMbWRsZEY5d2NtbGpaVjlwYm1adktDa2dMVDRnWW5sMFpYTTZDbWRsZEY5d2NtbGpaVjlwYm1adk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5clpXNWZjSEpwWTJVdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2YTJWdVgzQnlhV05sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZhMlZ1WDNCeWFXTmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TnpJS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y0hKcFkyVmZkR2x0WlhOMFlXMXdMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd2NtbGpaVjkwYVcxbGMzUmhiWEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNISnBZMlZmZEdsdFpYTjBZVzF3SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE56TUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWNISnBZMlZmWTI5dVptbGtaVzVqWlM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljSEpwWTJWZlkyOXVabWxrWlc1alpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y21salpWOWpiMjVtYVdSbGJtTmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TnpBdE1UYzBDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29DaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjJ0bGJsOXdjbWxqWlM1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1d2NtbGpaVjkwYVcxbGMzUmhiWEF1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y0hKcFkyVmZZMjl1Wm1sa1pXNWpaUzUyWVd4MVpTa0tJQ0FnSUM4dklDa3BDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CeWFXTmxYMjl5WVdOc1pTNWpiMjUwY21GamRDNVFjbWxqWlU5eVlXTnNaUzVwYzE5d2NtbGpaVjl6ZEdGc1pTZ3BJQzArSUhWcGJuUTJORG9LYVhOZmNISnBZMlZmYzNSaGJHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pFM05pMHhOemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHbHpYM0J5YVdObFgzTjBZV3hsS0hObGJHWXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURBZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94TnprS0lDQWdJQzh2SUhCeWFXTmxYM1JwYldWemRHRnRjQ0E5SUhObGJHWXVjSEpwWTJWZmRHbHRaWE4wWVcxd0xuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljSEpwWTJWZmRHbHRaWE4wWVcxd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtbGpaVjkwYVcxbGMzUmhiWEFnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pFNE1Rb2dJQ0FnTHk4Z2FXWWdjSEpwWTJWZmRHbHRaWE4wWVcxd0lEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUJwYzE5d2NtbGpaVjl6ZEdGc1pWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNVGd5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtERXBJQ0FqSUU1dklIQnlhV05sSUhObGRDd2dZMjl1YzJsa1pYSmxaQ0J6ZEdGc1pRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0thWE5mY0hKcFkyVmZjM1JoYkdWZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hPRFFLSUNBZ0lDOHZJR2xtSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRDRnY0hKcFkyVmZkR2x0WlhOMFlXMXdJQ3NnYzJWc1ppNXpkR0ZzWlc1bGMzTmZkR2h5WlhOb2IyeGtPZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luTjBZV3hsYm1WemMxOTBhSEpsYzJodmJHUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGJHVnVaWE56WDNSb2NtVnphRzlzWkNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBckNpQWdJQ0ErQ2lBZ0lDQmllaUJwYzE5d2NtbGpaVjl6ZEdGc1pWOWxiSE5sWDJKdlpIbEFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveE9EVUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrZ0lDTWdVM1JoYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NtbHpYM0J5YVdObFgzTjBZV3hsWDJWc2MyVmZZbTlrZVVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94T0RjS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tnSUNNZ1JuSmxjMmdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNISnBZMlZmYjNKaFkyeGxMbU52Ym5SeVlXTjBMbEJ5YVdObFQzSmhZMnhsTG5Sb2NtVnphRzlzWkY5eVpXRmphR1ZrS0NrZ0xUNGdkV2x1ZERZME9ncDBhSEpsYzJodmJHUmZjbVZoWTJobFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TVRnNUxURTVNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ2RHaHlaWE5vYjJ4a1gzSmxZV05vWldRb2MyVnNaaWtnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01DQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94T1RJS0lDQWdJQzh2SUdsbUlITmxiR1l1ZEdoeVpYTm9iMnhrWDJGamRHbDJaUzUyWVd4MVpTQTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkR2h5WlhOb2IyeGtYMkZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYUhKbGMyaHZiR1JmWVdOMGFYWmxJR1Y0YVhOMGN3b2dJQ0FnWW01NklIUm9jbVZ6YUc5c1pGOXlaV0ZqYUdWa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hPVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da2dJQ01nVkdoeVpYTm9iMnhrSUc1dmRDQmhZM1JwZG1VS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS2RHaHlaWE5vYjJ4a1gzSmxZV05vWldSZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hPVFVLSUNBZ0lDOHZJR04xY25KbGJuUmZjSEpwWTJVZ1BTQnpaV3htTG5SdmEyVnVYM0J5YVdObExuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzlyWlc1ZmNISnBZMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZhMlZ1WDNCeWFXTmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUhSb2NtVnphRzlzWkNBOUlITmxiR1l1ZEdoeVpYTm9iMnhrWDNCeWFXTmxMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEdoeVpYTm9iMnhrWDNCeWFXTmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdoeVpYTm9iMnhrWDNCeWFXTmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG94T1RnS0lDQWdJQzh2SUdsbUlHTjFjbkpsYm5SZmNISnBZMlVnUFQwZ1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW01NklIUm9jbVZ6YUc5c1pGOXlaV0ZqYUdWa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3hPVGtLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da2dJQ01nVG04Z2NISnBZMlVnWVhaaGFXeGhZbXhsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ25Sb2NtVnphRzlzWkY5eVpXRmphR1ZrWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1qQXhMVEl3TWdvZ0lDQWdMeThnSXlCRGFHVmpheUJwWmlCd2NtbGpaU0JwY3lCbWNtVnphQW9nSUNBZ0x5OGdhV1lnYzJWc1ppNXBjMTl3Y21salpWOXpkR0ZzWlNncElEMDlJRlZKYm5RMk5DZ3hLVG9LSUNBZ0lHTmhiR3h6ZFdJZ2FYTmZjSEpwWTJWZmMzUmhiR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RHaHlaWE5vYjJ4a1gzSmxZV05vWldSZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qSXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnd0tTQWdJeUJRY21salpTQnBjeUJ6ZEdGc1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncDBhSEpsYzJodmJHUmZjbVZoWTJobFpGOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakl3TlFvZ0lDQWdMeThnYVdZZ1kzVnljbVZ1ZEY5d2NtbGpaU0ErUFNCMGFISmxjMmh2YkdRNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lENDlDaUFnSUNCaWVpQjBhSEpsYzJodmJHUmZjbVZoWTJobFpGOWxiSE5sWDJKdlpIbEFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrZ0lDTWdWR2h5WlhOb2IyeGtJSEpsWVdOb1pXUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tkR2h5WlhOb2IyeGtYM0psWVdOb1pXUmZaV3h6WlY5aWIyUjVRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qSXdPQW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnd0tTQWdJeUJVYUhKbGMyaHZiR1FnYm05MElISmxZV05vWldRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdjbWxqWlY5dmNtRmpiR1V1WTI5dWRISmhZM1F1VUhKcFkyVlBjbUZqYkdVdVoyVjBYM1JvY21WemFHOXNaRjlwYm1adktDa2dMVDRnWW5sMFpYTTZDbWRsZEY5MGFISmxjMmh2YkdSZmFXNW1iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1qRTBDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUm9jbVZ6YUc5c1pGOXdjbWxqWlM1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkR2h5WlhOb2IyeGtYM0J5YVdObElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJvY21WemFHOXNaRjl3Y21salpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNakUxQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblJvY21WemFHOXNaRjloWTNScGRtVXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEdoeVpYTm9iMnhrWDJGamRHbDJaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGFISmxjMmh2YkdSZllXTjBhWFpsSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveU1UTXRNakUyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGFISmxjMmh2YkdSZmNISnBZMlV1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEdoeVpYTm9iMnhrWDJGamRHbDJaUzUyWVd4MVpTa0tJQ0FnSUM4dklDa3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXdjbWxqWlY5dmNtRmpiR1V1WTI5dWRISmhZM1F1VUhKcFkyVlBjbUZqYkdVdVlXTjBhWFpoZEdWZlkybHlZM1ZwZEY5aWNtVmhhMlZ5S0NrZ0xUNGdZbmwwWlhNNkNtRmpkR2wyWVhSbFgyTnBjbU4xYVhSZlluSmxZV3RsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNakl4Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpVDI1c2VTQmhaRzFwYmlCallXNGdZV04wYVhaaGRHVWdZMmx5WTNWcGRDQmljbVZoYTJWeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVJR05oYmlCaFkzUnBkbUYwWlNCamFYSmpkV2wwSUdKeVpXRnJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1qSXpDaUFnSUNBdkx5QnpaV3htTG1OcGNtTjFhWFJmWW5KbFlXdGxjbDloWTNScGRtVXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltTnBjbU4xYVhSZlluSmxZV3RsY2lJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3lNalVLSUNBZ0lDOHZJR3h2WnloaUlrTnBjbU4xYVhRZ1luSmxZV3RsY2lCaFkzUnBkbUYwWldRaUtRb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z01IZzBNelk1TnpJMk16YzFOamszTkRJd05qSTNNalkxTmpFMllqWTFOekl5TURZeE5qTTNORFk1TnpZMk1UYzBOalUyTkFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwWTJWZmIzSmhZMnhsTDJOdmJuUnlZV04wTG5CNU9qSXlOZ29nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVEybHlZM1ZwZENCaWNtVmhhMlZ5SUdGamRHbDJZWFJsWkNJcENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVEybHlZM1ZwZENCaWNtVmhhMlZ5SUdGamRHbDJZWFJsWkNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3Y21salpWOXZjbUZqYkdVdVkyOXVkSEpoWTNRdVVISnBZMlZQY21GamJHVXVjbVZ6WlhSZlkybHlZM1ZwZEY5aWNtVmhhMlZ5S0NrZ0xUNGdZbmwwWlhNNkNuSmxjMlYwWDJOcGNtTjFhWFJmWW5KbFlXdGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1qTXhDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlUMjVzZVNCaFpHMXBiaUJqWVc0Z2NtVnpaWFFnWTJseVkzVnBkQ0JpY21WaGEyVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQnlaWE5sZENCamFYSmpkV2wwSUdKeVpXRnJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1qTXpDaUFnSUNBdkx5QnpaV3htTG1OcGNtTjFhWFJmWW5KbFlXdGxjbDloWTNScGRtVXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltTnBjbU4xYVhSZlluSmxZV3RsY2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3lNelVLSUNBZ0lDOHZJR3h2WnloaUlrTnBjbU4xYVhRZ1luSmxZV3RsY2lCeVpYTmxkQ0lwQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUF3ZURRek5qazNNall6TnpVMk9UYzBNakEyTWpjeU5qVTJNVFppTmpVM01qSXdOekkyTlRjek5qVTNOQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJek5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpUTJseVkzVnBkQ0JpY21WaGEyVnlJSEpsYzJWMElpa0tJQ0FnSUdKNWRHVmpJREUxSUM4dklDSkRhWEpqZFdsMElHSnlaV0ZyWlhJZ2NtVnpaWFFpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjSEpwWTJWZmIzSmhZMnhsTG1OdmJuUnlZV04wTGxCeWFXTmxUM0poWTJ4bExuQmhkWE5sWDI5eVlXTnNaU2dwSUMwK0lHSjVkR1Z6T2dwd1lYVnpaVjl2Y21GamJHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJME1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUhCaGRYTmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQndZWFZ6WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3lORElLSUNBZ0lDOHZJSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUJzYjJjb1lpSlBjbUZqYkdVZ2NHRjFjMlZrSWlrS0lDQWdJR0o1ZEdWaklERTJJQzh2SURCNE5HWTNNall4TmpNMll6WTFNakEzTURZeE56VTNNelkxTmpRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3lORFVLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lrOXlZV05zWlNCd1lYVnpaV1FpS1FvZ0lDQWdZbmwwWldNZ01UWWdMeThnSWs5eVlXTnNaU0J3WVhWelpXUWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNISnBZMlZmYjNKaFkyeGxMbU52Ym5SeVlXTjBMbEJ5YVdObFQzSmhZMnhsTG5WdWNHRjFjMlZmYjNKaFkyeGxLQ2tnTFQ0Z1lubDBaWE02Q25WdWNHRjFjMlZmYjNKaFkyeGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveU5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSlBibXg1SUdGa2JXbHVJR05oYmlCMWJuQmhkWE5sSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUlHTmhiaUIxYm5CaGRYTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJMU1Rb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5d1lYVnpaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbWx6WDNCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhV05sWDI5eVlXTnNaUzlqYjI1MGNtRmpkQzV3ZVRveU5UTUtJQ0FnSUM4dklHeHZaeWhpSWs5eVlXTnNaU0IxYm5CaGRYTmxaQ0lwQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUF3ZURSbU56STJNVFl6Tm1NMk5USXdOelUyWlRjd05qRTNOVGN6TmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakkxTkFvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lUM0poWTJ4bElIVnVjR0YxYzJWa0lpa0tJQ0FnSUdKNWRHVmpJREUzSUM4dklDSlBjbUZqYkdVZ2RXNXdZWFZ6WldRaUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0hKcFkyVmZiM0poWTJ4bExtTnZiblJ5WVdOMExsQnlhV05sVDNKaFkyeGxMbWRsZEY5dmNtRmpiR1ZmYzNSaGRIVnpLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOXZjbUZqYkdWZmMzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVdObFgyOXlZV05zWlM5amIyNTBjbUZqZEM1d2VUb3lOakFLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVhWE5mY0dGMWMyVmtMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mY0dGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFXTmxYMjl5WVdOc1pTOWpiMjUwY21GamRDNXdlVG95TmpFS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1WTJseVkzVnBkRjlpY21WaGEyVnlYMkZqZEdsMlpTNTJZV3gxWlNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTJseVkzVnBkRjlpY21WaGEyVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OcGNtTjFhWFJmWW5KbFlXdGxjbDloWTNScGRtVWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPakkyTWdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUxY0dSaGRHVnlYMk52ZFc1MExuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblZ3WkdGMFpYSmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWEJrWVhSbGNsOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWxqWlY5dmNtRmpiR1V2WTI5dWRISmhZM1F1Y0hrNk1qVTVMVEkyTXdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0FvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtTnBjbU4xYVhSZlluSmxZV3RsY2w5aFkzUnBkbVV1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZFhCa1lYUmxjbDlqYjNWdWRDNTJZV3gxWlNrS0lDQWdJQzh2SUNrcENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkJ5YVdObFgyOXlZV05zWlM1amIyNTBjbUZqZEM1UWNtbGpaVTl5WVdOc1pTNXlaVzF2ZG1WZmRHaHlaWE5vYjJ4a0tDa2dMVDRnWW5sMFpYTTZDbkpsYlc5MlpWOTBhSEpsYzJodmJHUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJMk9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUhKbGJXOTJaU0IwYUhKbGMyaHZiR1FpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJSEpsYlc5MlpTQjBhSEpsYzJodmJHUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbGpaVjl2Y21GamJHVXZZMjl1ZEhKaFkzUXVjSGs2TWpjd0NpQWdJQ0F2THlCelpXeG1MblJvY21WemFHOXNaRjloWTNScGRtVXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUm9jbVZ6YUc5c1pGOWhZM1JwZG1VaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNamN4Q2lBZ0lDQXZMeUJ6Wld4bUxuUm9jbVZ6YUc5c1pGOXdjbWxqWlM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEdoeVpYTm9iMnhrWDNCeWFXTmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJM013b2dJQ0FnTHk4Z2JHOW5LR0lpVkdoeVpYTm9iMnhrSUhKbGJXOTJaV1FpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRRMk9EY3lOalUzTXpZNE5tWTJZelkwTWpBM01qWTFObVEyWmpjMk5qVTJOQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBZMlZmYjNKaFkyeGxMMk52Ym5SeVlXTjBMbkI1T2pJM05Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVkdoeVpYTm9iMnhrSUhKbGJXOTJaV1FnYzNWalkyVnpjMloxYkd4NUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVZHaHlaWE5vYjJ4a0lISmxiVzkyWldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQnlhV05sWDI5eVlXTnNaUzVqYjI1MGNtRmpkQzVRY21salpVOXlZV05zWlM1blpYUmZjSEpwWTJWZmFHbHpkRzl5ZVY5emRXMXRZWEo1S0NrZ0xUNGdZbmwwWlhNNkNtZGxkRjl3Y21salpWOW9hWE4wYjNKNVgzTjFiVzFoY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcFkyVmZiM0poWTJ4bEwyTnZiblJ5WVdOMExuQjVPak13TXdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjJ0bGJsOXdjbWxqWlM1MllXeDFaU2tzSUNBaklFTjFjbkpsYm5RZ2NISnBZMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiMnRsYmw5d2NtbGpaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIydGxibDl3Y21salpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21salpWOXZjbUZqYkdVdlkyOXVkSEpoWTNRdWNIazZNekF3TFRNd05nb2dJQ0FnTHk4Z0l5QkpiaUJ3Y205a2RXTjBhVzl1TENCM2IzVnNaQ0J0WVdsdWRHRnBiaUJ3Y21salpTQm9hWE4wYjNKNUNpQWdJQ0F2THlBaklFWnZjaUJ1YjNjc0lISmxkSFZ5Ym1sdVp5QmpkWEp5Wlc1MElIQnlhV05sSUdsdVptOEtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtDZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblJ2YTJWdVgzQnlhV05sTG5aaGJIVmxLU3dnSUNNZ1EzVnljbVZ1ZENCd2NtbGpaUW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5clpXNWZjSEpwWTJVdWRtRnNkV1VwTENBZ0l5Qk5ZWGdnY0hKcFkyVWdLSE5wYlhCc2FXWnBaV1FwQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIydGxibDl3Y21salpTNTJZV3gxWlNrZ0lDQWpJRTFwYmlCd2NtbGpaU0FvYzJsdGNHeHBabWxsWkNrS0lDQWdJQzh2SUNrcENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFHUVRpWVNCQlVmZkhVRllXUnRhVzRMZEc5clpXNWZjSEpwWTJVUGNISnBZMlZmZEdsdFpYTjBZVzF3RDNSb2NtVnphRzlzWkY5d2NtbGpaUkIwYUhKbGMyaHZiR1JmWVdOMGFYWmxEMk5wY21OMWFYUmZZbkpsWVd0bGNnbHBjMTl3WVhWelpXUU5kWEJrWVhSbGNsOWpiM1Z1ZEJOemRHRnNaVzVsYzNOZmRHaHlaWE5vYjJ4a0VIQnlhV05sWDJOdmJtWnBaR1Z1WTJVS2FYTmZkWEJrWVhSbGNoTnRZWGhmY0hKcFkyVmZaR1YyYVdGMGFXOXVFMjFwYmw5MWNHUmhkR1ZmYVc1MFpYSjJZV3daUTJseVkzVnBkQ0JpY21WaGEyVnlJR0ZqZEdsMllYUmxaQlZEYVhKamRXbDBJR0p5WldGclpYSWdjbVZ6WlhRTlQzSmhZMnhsSUhCaGRYTmxaQTlQY21GamJHVWdkVzV3WVhWelpXUXhHRUFBRWljTWdlZ0haeWNOZ2F3Q1p5Y0pnWkFjWnpFYlFRSFdnaEFFaVhyUnB3VGRtZFdhQkJMQkVtOEVmY1pJUEFSZE9IalFCQlJQNVBrRWFuYmU4Z1Q2alA4dEJQMmNVK0FFUmFCYk1BUjZSUjZxQkcva0QrRUVqYXhWMHdSMHRsaDJCQ1UzYVZBRVRQTmtXallhQUk0UUFVY0JLUUVKQU8wQTNBRE1BTHNBcWdDYUFJSUFhZ0JTQURvQUtnQVNBQUlpUXpFWkZFUXhHRVNJQlMwb1RGQ3dJME14R1JSRU1SaEVpQVRZU1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRWlBU29LRXhRc0NORE1Sa1VSREVZUklnRWhra1ZGbGNHQWt4UUtFeFFzQ05ETVJrVVJERVlSSWdFWEVrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJJZ0VNa2tWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUklnRUNFa1ZGbGNHQWt4UUtFeFFzQ05ETVJrVVJERVlSSWdENGloTVVMQWpRekVaRkVReEdFU0lBNHNXS0V4UXNDTkRNUmtVUkRFWVJJZ0RWUllvVEZDd0kwTXhHUlJFTVJoRWlBTXVLRXhRc0NORE1Sa1VSREVZUklnREJoWW9URkN3STBNeEdSUkVNUmhFTmhvQkY0Z0NkVWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFSYzJHZ0lYaUFFU1NSVVdWd1lDVEZBb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQWlBQ2xTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFaUFBWlNSVVdWd1lDVEZBb1RGQ3dJME14R1VEK25ERVlGRVFqUXpFQU1na1NSQ2t4QUdjbkJpSm5Kd2NpWnljSUltY3FJbWNySW1jbkNpSm5Kd1FpWnljRkltY3hBQ2NMSTJZbkNDTm5nQmRRY21salpVOXlZV05zWlNCcGJtbDBhV0ZzYVhwbFpMQ0FKVkJ5YVdObElHOXlZV05zWlNCcGJtbDBhV0ZzYVhwbFpDQnpkV05qWlhOelpuVnNiSG1KaWdFQk1RQWlLV1ZFRWtRaUp3aGxSQ01JSndoTVo0QVRVSEpwWTJVZ2RYQmtZWFJsY2lCaFpHUmxaTENBSUZCeWFXTmxJSFZ3WkdGMFpYSWdZV1JrWldRZ2MzVmpZMlZ6YzJaMWJHeDVpWW9DQVlBQVJ3SWlKd2RsUkJSRUlpY0daVVFVUkl2K1JJdi9KQTVFTVFBaUtXVkVFa0FBRERFQUlpY0xZMFFqRWtFQkRDTkVJaXBsVEVsT0Fvd0FSQ0lyWlV5TUFVUkJBQmt5QnlJbkRXVkVpd0VJRDBTTEFFQUF3U0lpSnd4bFJBNUVLb3YrWnlzeUIyY25Db3YvWjRBTmNISnBZMlZmZFhCa1lYUmxjakVBWnlJbkJXVkVJeEpCQUVjaUp3UmxURWxPQW93Q1JJditEa0VBTm92K0ZvQWJWR2h5WlhOb2IyeGtJSEpsWVdOb1pXUWdMU0JRY21salpUb2dURkNBRENCVWFISmxjMmh2YkdRNklGQ0xBaFpRc0lzQUZvQVZVSEpwWTJVZ2RYQmtZWFJsWkNBdElFOXNaRG9nVEZDQUJpQk9aWGM2SUZDTC9oWlFzSUFhVUhKcFkyVWdkWEJrWVhSbFpDQnpkV05qWlhOelpuVnNiSG1NQUltTEFJditEVUVBRFlzQVNZditDU1FMVEFwQy95dUwvb3NBU1U0Q0NTUUxUQXBDL3h3aVF2N3hpZ0VCaS85RU1RQWlLV1ZFRWtBQURERUFJaWNMWTBRakVrRUFYQ05FSndTTC8yY25CU05uZ0JCMGFISmxjMmh2YkdSZmMyVjBkR1Z5TVFCbmkvOFdnQmRVYUhKbGMyaHZiR1FnYzJWMElDMGdWbUZzZFdVNklFeFFzSUFhVkdoeVpYTm9iMnhrSUhObGRDQnpkV05qWlhOelpuVnNiSG1KSWtML29TSXFaVVFpSzJWRVN3RkVNZ2NpSndsbFJFOENDQTVFaVNJcVpVUVdJaXRsUkJZaUp3cGxSQlpPQWxCTVVJbUtBQUVpSzJWTVNVOENSRUFBQXlOTWlUSUhJaWNKWlVTTEFBZ05RUUFESTB5SklreUppZ0FCZ0FCSklpY0ZaVVJBQUFRaWpBQ0pJaXBsVEVsT0Fvd0FSQ0luQkdWTWpBRkVRQUFFSW93QWlZai9yU01TUVFBRUlvd0FpWXNBaXdFUFFRQUVJNHdBaVNLTUFJa2lKd1JsUkJZaUp3VmxSQlpRaVRFQUlpbGxSQkpFSndZalp5Y09zQ2NPaVRFQUlpbGxSQkpFSndZaVp5Y1BzQ2NQaVRFQUlpbGxSQkpFSndjalp5Y1FzQ2NRaVRFQUlpbGxSQkpFSndjaVp5Y1JzQ2NSaVNJbkIyVkVGaUluQm1WRUZpSW5DR1ZFRms0Q1VFeFFpVEVBSWlsbFJCSkVKd1VpWnljRUltZUFFVlJvY21WemFHOXNaQ0J5WlcxdmRtVmtzSUFlVkdoeVpYTm9iMnhrSUhKbGJXOTJaV1FnYzNWalkyVnpjMloxYkd4NWlTSXFaVVFXU1VzQlVFeFFpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
