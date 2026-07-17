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

namespace Arc56.Generated.MitudruDutta.Marlin.YTAutoConverter_6396b203
{


    //
    // AI-powered YT to PT auto converter
    //
    public class YTAutoConverterProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public YTAutoConverterProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetUserConfigReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetUserConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserConfigReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetUserConfigReturn);
                }
                public bool Equals(GetUserConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserConfigReturn left, GetUserConfigReturn right)
                {
                    return EqualityComparer<GetUserConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserConfigReturn left, GetUserConfigReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetUserBalancesReturn : AVMObjectType
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

                public static GetUserBalancesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserBalancesReturn();
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
                    return Equals(obj as GetUserBalancesReturn);
                }
                public bool Equals(GetUserBalancesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserBalancesReturn left, GetUserBalancesReturn right)
                {
                    return EqualityComparer<GetUserBalancesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserBalancesReturn left, GetUserBalancesReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetConversionInfoReturn : AVMObjectType
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

                public static GetConversionInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetConversionInfoReturn();
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
                    return Equals(obj as GetConversionInfoReturn);
                }
                public bool Equals(GetConversionInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetConversionInfoReturn left, GetConversionInfoReturn right)
                {
                    return EqualityComparer<GetConversionInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetConversionInfoReturn left, GetConversionInfoReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetAiRecommendationReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
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

                public static GetAiRecommendationReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetAiRecommendationReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetAiRecommendationReturn);
                }
                public bool Equals(GetAiRecommendationReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetAiRecommendationReturn left, GetAiRecommendationReturn right)
                {
                    return EqualityComparer<GetAiRecommendationReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetAiRecommendationReturn left, GetAiRecommendationReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the auto converter
        ///</summary>
        /// <param name="oracle_address"> </param>
        /// <param name="tokenization_address"> </param>
        /// <param name="amm_address"> </param>
        public async Task<string> Initialize(byte[] oracle_address, byte[] tokenization_address, byte[] amm_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 105, 223, 93 };
            var oracle_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); oracle_addressAbi.From(oracle_address);
            var tokenization_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); tokenization_addressAbi.From(tokenization_address);
            var amm_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); amm_addressAbi.From(amm_address);

            var result = await base.CallApp(new List<object> { abiHandle, oracle_addressAbi, tokenization_addressAbi, amm_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(byte[] oracle_address, byte[] tokenization_address, byte[] amm_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 105, 223, 93 };
            var oracle_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); oracle_addressAbi.From(oracle_address);
            var tokenization_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); tokenization_addressAbi.From(tokenization_address);
            var amm_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); amm_addressAbi.From(amm_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, oracle_addressAbi, tokenization_addressAbi, amm_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Configure automatic conversion for user
        ///</summary>
        /// <param name="enabled"> </param>
        /// <param name="threshold_price"> </param>
        /// <param name="maturity"> </param>
        public async Task<string> ConfigureConversion(ulong enabled, ulong threshold_price, ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 154, 175, 52 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);
            var threshold_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); threshold_priceAbi.From(threshold_price);
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            var result = await base.CallApp(new List<object> { abiHandle, enabledAbi, threshold_priceAbi, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ConfigureConversion_Transactions(ulong enabled, ulong threshold_price, ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 154, 175, 52 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);
            var threshold_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); threshold_priceAbi.From(threshold_price);
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            return await base.MakeTransactionList(new List<object> { abiHandle, enabledAbi, threshold_priceAbi, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit YT tokens for conversion (for testing)
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> DepositYtTokens(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 232, 140, 89 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DepositYtTokens_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 232, 140, 89 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute YT to PT conversion
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="min_pt_amount"> </param>
        /// <param name="deadline"> </param>
        public async Task<string> ExecuteConversion(byte[] user, ulong min_pt_amount, ulong deadline, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 215, 195, 2 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userAbi.From(user);
            var min_pt_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_pt_amountAbi.From(min_pt_amount);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, min_pt_amountAbi, deadlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ExecuteConversion_Transactions(byte[] user, ulong min_pt_amount, ulong deadline, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 215, 195, 2 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userAbi.From(user);
            var min_pt_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_pt_amountAbi.From(min_pt_amount);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, min_pt_amountAbi, deadlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if conversion can be executed for user
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> CanExecuteConversion(byte[] user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 87, 226, 249 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanExecuteConversion_Transactions(byte[] user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 87, 226, 249 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's conversion configuration
        ///</summary>
        public async Task<Structs.GetUserConfigReturn> GetUserConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 118, 217, 81 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 118, 217, 81 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's YT and PT balances
        ///</summary>
        public async Task<Structs.GetUserBalancesReturn> GetUserBalances(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 78, 223, 217 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserBalancesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserBalances_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 78, 223, 217 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get conversion information
        ///</summary>
        public async Task<Structs.GetConversionInfoReturn> GetConversionInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 209, 66, 140 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetConversionInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConversionInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 209, 66, 140 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate expected PT output for YT input
        ///</summary>
        /// <param name="yt_amount"> </param>
        public async Task<Structs.GetUserBalancesReturn> CalculateConversionOutput(ulong yt_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 251, 236, 53 };
            var yt_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yt_amountAbi.From(yt_amount);

            var result = await base.SimApp(new List<object> { abiHandle, yt_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserBalancesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CalculateConversionOutput_Transactions(ulong yt_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 251, 236, 53 };
            var yt_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yt_amountAbi.From(yt_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, yt_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a maturity for conversion
        ///</summary>
        /// <param name="maturity"> </param>
        public async Task<string> AddMaturity(ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 145, 163, 1 };
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            var result = await base.CallApp(new List<object> { abiHandle, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AddMaturity_Transactions(ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 145, 163, 1 };
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            return await base.MakeTransactionList(new List<object> { abiHandle, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove user's maturity
        ///</summary>
        public async Task<string> RemoveMaturity(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 48, 210, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RemoveMaturity_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 48, 210, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set conversion fee (admin only)
        ///</summary>
        /// <param name="new_fee"> </param>
        public async Task<string> SetConversionFee(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 240, 55, 0 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            var result = await base.CallApp(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetConversionFee_Transactions(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 240, 55, 0 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause the converter (admin only)
        ///</summary>
        public async Task<string> PauseConverter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 38, 84, 180 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PauseConverter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 38, 84, 180 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unpause the converter (admin only)
        ///</summary>
        public async Task<string> UnpauseConverter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 40, 32, 67 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnpauseConverter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 40, 32, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency disable conversion for user
        ///</summary>
        public async Task<string> EmergencyDisableConversion(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 99, 142, 194 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyDisableConversion_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 99, 142, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw PT tokens
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> WithdrawPtTokens(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 32, 93, 173 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> WithdrawPtTokens_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 32, 93, 173 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get AI recommendation for conversion (simplified)
        ///</summary>
        /// <param name="yt_amount"> </param>
        /// <param name="current_price"> </param>
        public async Task<Structs.GetAiRecommendationReturn> GetAiRecommendation(ulong yt_amount, ulong current_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 255, 1, 80 };
            var yt_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yt_amountAbi.From(yt_amount);
            var current_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_priceAbi.From(current_price);

            var result = await base.SimApp(new List<object> { abiHandle, yt_amountAbi, current_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetAiRecommendationReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAiRecommendation_Transactions(ulong yt_amount, ulong current_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 255, 1, 80 };
            var yt_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yt_amountAbi.From(yt_amount);
            var current_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_priceAbi.From(current_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, yt_amountAbi, current_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update contract addresses (admin only)
        ///</summary>
        /// <param name="oracle_address"> </param>
        /// <param name="tokenization_address"> </param>
        /// <param name="amm_address"> </param>
        public async Task<string> UpdateAddresses(byte[] oracle_address, byte[] tokenization_address, byte[] amm_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 97, 53, 15 };
            var oracle_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); oracle_addressAbi.From(oracle_address);
            var tokenization_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); tokenization_addressAbi.From(tokenization_address);
            var amm_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); amm_addressAbi.From(amm_address);

            var result = await base.CallApp(new List<object> { abiHandle, oracle_addressAbi, tokenization_addressAbi, amm_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateAddresses_Transactions(byte[] oracle_address, byte[] tokenization_address, byte[] amm_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 97, 53, 15 };
            var oracle_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); oracle_addressAbi.From(oracle_address);
            var tokenization_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); tokenization_addressAbi.From(tokenization_address);
            var amm_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); amm_addressAbi.From(amm_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, oracle_addressAbi, tokenization_addressAbi, amm_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWVRBdXRvQ29udmVydGVyIiwiZGVzYyI6IkFJLXBvd2VyZWQgWVQgdG8gUFQgYXV0byBjb252ZXJ0ZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0VXNlckNvbmZpZ1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkdldFVzZXJCYWxhbmNlc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dLCJHZXRDb252ZXJzaW9uSW5mb1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0QWlSZWNvbW1lbmRhdGlvblJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgYXV0byBjb252ZXJ0ZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JhY2xlX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuaXphdGlvbl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW1fYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpZ3VyZV9jb252ZXJzaW9uIiwiZGVzYyI6IkNvbmZpZ3VyZSBhdXRvbWF0aWMgY29udmVyc2lvbiBmb3IgdXNlciIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmFibGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aHJlc2hvbGRfcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hdHVyaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdF95dF90b2tlbnMiLCJkZXNjIjoiRGVwb3NpdCBZVCB0b2tlbnMgZm9yIGNvbnZlcnNpb24gKGZvciB0ZXN0aW5nKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleGVjdXRlX2NvbnZlcnNpb24iLCJkZXNjIjoiRXhlY3V0ZSBZVCB0byBQVCBjb252ZXJzaW9uIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbl9wdF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuX2V4ZWN1dGVfY29udmVyc2lvbiIsImRlc2MiOiJDaGVjayBpZiBjb252ZXJzaW9uIGNhbiBiZSBleGVjdXRlZCBmb3IgdXNlciIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9jb25maWciLCJkZXNjIjoiR2V0IHVzZXIncyBjb252ZXJzaW9uIGNvbmZpZ3VyYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyQ29uZmlnUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9iYWxhbmNlcyIsImRlc2MiOiJHZXQgdXNlcidzIFlUIGFuZCBQVCBiYWxhbmNlcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyQmFsYW5jZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jb252ZXJzaW9uX2luZm8iLCJkZXNjIjoiR2V0IGNvbnZlcnNpb24gaW5mb3JtYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldENvbnZlcnNpb25JbmZvUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVfY29udmVyc2lvbl9vdXRwdXQiLCJkZXNjIjoiQ2FsY3VsYXRlIGV4cGVjdGVkIFBUIG91dHB1dCBmb3IgWVQgaW5wdXQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieXRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVzZXJCYWxhbmNlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX21hdHVyaXR5IiwiZGVzYyI6IkFkZCBhIG1hdHVyaXR5IGZvciBjb252ZXJzaW9uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hdHVyaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlX21hdHVyaXR5IiwiZGVzYyI6IlJlbW92ZSB1c2VyJ3MgbWF0dXJpdHkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfY29udmVyc2lvbl9mZWUiLCJkZXNjIjoiU2V0IGNvbnZlcnNpb24gZmVlIChhZG1pbiBvbmx5KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2VfY29udmVydGVyIiwiZGVzYyI6IlBhdXNlIHRoZSBjb252ZXJ0ZXIgKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZV9jb252ZXJ0ZXIiLCJkZXNjIjoiVW5wYXVzZSB0aGUgY29udmVydGVyIChhZG1pbiBvbmx5KSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtZXJnZW5jeV9kaXNhYmxlX2NvbnZlcnNpb24iLCJkZXNjIjoiRW1lcmdlbmN5IGRpc2FibGUgY29udmVyc2lvbiBmb3IgdXNlciIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X3B0X3Rva2VucyIsImRlc2MiOiJXaXRoZHJhdyBQVCB0b2tlbnMiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FpX3JlY29tbWVuZGF0aW9uIiwiZGVzYyI6IkdldCBBSSByZWNvbW1lbmRhdGlvbiBmb3IgY29udmVyc2lvbiAoc2ltcGxpZmllZCkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieXRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdXJyZW50X3ByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IkdldEFpUmVjb21tZW5kYXRpb25SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9hZGRyZXNzZXMiLCJkZXNjIjoiVXBkYXRlIGNvbnRyYWN0IGFkZHJlc3NlcyAoYWRtaW4gb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JhY2xlX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuaXphdGlvbl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW1fYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo1LCJieXRlcyI6NH0sImxvY2FsIjp7ImludHMiOjYsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE2NiwyMDA5XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjg5XSwiZXJyb3JNZXNzYWdlIjoiQ29udmVyc2lvbiBhbHJlYWR5IGV4ZWN1dGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4MF0sImVycm9yTWVzc2FnZSI6IkNvbnZlcnNpb24gbm90IGVuYWJsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjY0XSwiZXJyb3JNZXNzYWdlIjoiQ29udmVydGVyIGlzIHBhdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OThdLCJlcnJvck1lc3NhZ2UiOiJGZWUgdG9vIGhpZ2ggKG1heCAxMCUpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAyMV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBQVCBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMzM10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBvdXRwdXQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzNiwxNjU0XSwiZXJyb3JNZXNzYWdlIjoiTWF0dXJpdHkgbXVzdCBiZSBpbiBmdXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzA1XSwiZXJyb3JNZXNzYWdlIjoiTm8gWVQgdG9rZW5zIHRvIGNvbnZlcnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjQsNDY2LDQ5MCw1MTgsNTQyLDU2Niw1OTAsNjE4LDY0Miw2NzAsNjkwLDcwNiw3MjIsNzM4LDc2MSw3OTksODI3LDg2M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBwYXVzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OTFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBzZXQgZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxOV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHVucGF1c2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzY3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gdXBkYXRlIGFkZHJlc3NlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gaW5pdGlhbGl6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOTddLCJlcnJvck1lc3NhZ2UiOiJUaHJlc2hvbGQgbm90IHJlYWNoZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDMwXSwiZXJyb3JNZXNzYWdlIjoiVGhyZXNob2xkIHByaWNlIG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjcwXSwiZXJyb3JNZXNzYWdlIjoiVHJhbnNhY3Rpb24gZXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxMF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNyw0NjksNDkzLDUyMSw1NDUsNTY5LDU5Myw2MjEsNjQ1LDY3Myw2OTMsNzA5LDcyNSw3NDEsNzY0LDgwMiw4MzAsODY2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3ODksMTg5OSwxOTE3LDIzNjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNzcsMTQ2MSwxNTEyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb252ZXJzaW9uX2VuYWJsZWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4NywxNDczLDE1MzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNvbnZlcnNpb25fZXhlY3V0ZWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwOSwxNTY5LDE2MTksMTgwMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29udmVyc2lvbl9mZWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxNywxNjI3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5mZWVfZGVub21pbmF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2MiwxNTgxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc19wYXVzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0NSwxNTYyLDIwMTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnB0X2JhbGFuY2UgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5NiwxNDk4LDE1MjAsMjE2Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGhyZXNob2xkX3ByaWNlIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNjYsMTU3NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfY29udmVyc2lvbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudXNlcl9tYXR1cml0eSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTcyLDEzMDMsMTQ4NiwxNTU0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi55dF9iYWxhbmNlIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl1WTI5dWRISmhZM1F1V1ZSQmRYUnZRMjl1ZG1WeWRHVnlMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTVNBeE1EQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJQ0pqYjI1MlpYSnphVzl1WDJabFpTSWdJbmwwWDJKaGJHRnVZMlVpSUNKaFpHMXBiaUlnSW1selgzQmhkWE5sWkNJZ0ltTnZiblpsY25OcGIyNWZaVzVoWW14bFpDSWdJblJvY21WemFHOXNaRjl3Y21salpTSWdJbU52Ym5abGNuTnBiMjVmWlhobFkzVjBaV1FpSUNKd2RGOWlZV3hoYm1ObElpQWlkRzkwWVd4ZlkyOXVkbVZ5YzJsdmJuTWlJQ0oxYzJWeVgyMWhkSFZ5YVhSNUlpQWlabVZsWDJSbGJtOXRhVzVoZEc5eUlpQWliM0poWTJ4bFgyRmtaSEpsYzNNaUlDSjBiMnRsYm1sNllYUnBiMjVmWVdSa2NtVnpjeUlnSW1GdGJWOWhaR1J5WlhOeklpQXdlRFF6Tm1ZMlpUYzJOalUzTWpjME5qVTNNakl3TnpBMk1UYzFOek0yTlRZMElEQjRORE0yWmpabE56WTJOVGN5TnpRMk5UY3lNakEzTlRabE56QTJNVGMxTnpNMk5UWTBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk5EUXRORFVLSUNBZ0lDOHZJQ01nUTI5dWMzUmhiblJ6Q2lBZ0lDQXZMeUJ6Wld4bUxtMWhlRjl6Ykdsd2NHRm5aU0E5SUZWSmJuUTJOQ2cxTURBcElDQWpJRFVsQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbTFoZUY5emJHbHdjR0ZuWlNJS0lDQWdJSEIxYzJocGJuUWdOVEF3SUM4dklEVXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnYzJWc1ppNW1aV1ZmWkdWdWIyMXBibUYwYjNJZ1BTQlZTVzUwTmpRb01UQXdNREFwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWm1WbFgyUmxibTl0YVc1aGRHOXlJZ29nSUNBZ2FXNTBZMTh5SUM4dklERXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJR05zWVhOeklGbFVRWFYwYjBOdmJuWmxjblJsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREl6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0Tm1FMk9XUm1OV1FnTUhnMllqbGhZV1l6TkNBd2VETTVaVGc0WXpVNUlEQjRObUZrTjJNek1ESWdNSGhoTmpVM1pUSm1PU0F3ZURZMk56WmtPVFV4SURCNFptVTBaV1JtWkRrZ01IZzJZbVF4TkRJNFl5QXdlRFUwWm1KbFl6TTFJREI0TlRrNU1XRXpNREVnTUhoak56TXdaREl5WXlBd2VERmhaakF6TnpBd0lEQjRORFV5TmpVMFlqUWdNSGhrTXpJNE1qQTBNeUF3ZURFeE5qTTRaV015SURCNFl6QXlNRFZrWVdRZ01IZzJPV1ptTURFMU1DQXdlRGN4TmpFek5UQm1JQzh2SUcxbGRHaHZaQ0FpYVc1cGRHbGhiR2w2WlNoaWVYUmxXMTBzWW5sMFpWdGRMR0o1ZEdWYlhTbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltTnZibVpwWjNWeVpWOWpiMjUyWlhKemFXOXVLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWkdWd2IzTnBkRjk1ZEY5MGIydGxibk1vZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaWGhsWTNWMFpWOWpiMjUyWlhKemFXOXVLR0o1ZEdWYlhTeDFhVzUwTmpRc2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWTJGdVgyVjRaV04xZEdWZlkyOXVkbVZ5YzJsdmJpaGllWFJsVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZkWE5sY2w5amIyNW1hV2NvS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmZFhObGNsOWlZV3hoYm1ObGN5Z3BLSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmWTI5dWRtVnljMmx2Ymw5cGJtWnZLQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSmpZV3hqZFd4aGRHVmZZMjl1ZG1WeWMybHZibDl2ZFhSd2RYUW9kV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVlXUmtYMjFoZEhWeWFYUjVLSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luSmxiVzkyWlY5dFlYUjFjbWwwZVNncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKelpYUmZZMjl1ZG1WeWMybHZibDltWldVb2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpY0dGMWMyVmZZMjl1ZG1WeWRHVnlLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblZ1Y0dGMWMyVmZZMjl1ZG1WeWRHVnlLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbVZ0WlhKblpXNWplVjlrYVhOaFlteGxYMk52Ym5abGNuTnBiMjRvS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpZDJsMGFHUnlZWGRmY0hSZmRHOXJaVzV6S0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEY5aGFWOXlaV052YlcxbGJtUmhkR2x2YmloMWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNjM1J5YVc1bktTSXNJRzFsZEdodlpDQWlkWEJrWVhSbFgyRmtaSEpsYzNObGN5aGllWFJsVzEwc1lubDBaVnRkTEdKNWRHVmJYU2x6ZEhKcGJtY2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgybHVhWFJwWVd4cGVtVmZjbTkxZEdWQU5TQnRZV2x1WDJOdmJtWnBaM1Z5WlY5amIyNTJaWEp6YVc5dVgzSnZkWFJsUURZZ2JXRnBibDlrWlhCdmMybDBYM2wwWDNSdmEyVnVjMTl5YjNWMFpVQTNJRzFoYVc1ZlpYaGxZM1YwWlY5amIyNTJaWEp6YVc5dVgzSnZkWFJsUURnZ2JXRnBibDlqWVc1ZlpYaGxZM1YwWlY5amIyNTJaWEp6YVc5dVgzSnZkWFJsUURrZ2JXRnBibDluWlhSZmRYTmxjbDlqYjI1bWFXZGZjbTkxZEdWQU1UQWdiV0ZwYmw5blpYUmZkWE5sY2w5aVlXeGhibU5sYzE5eWIzVjBaVUF4TVNCdFlXbHVYMmRsZEY5amIyNTJaWEp6YVc5dVgybHVabTlmY205MWRHVkFNVElnYldGcGJsOWpZV3hqZFd4aGRHVmZZMjl1ZG1WeWMybHZibDl2ZFhSd2RYUmZjbTkxZEdWQU1UTWdiV0ZwYmw5aFpHUmZiV0YwZFhKcGRIbGZjbTkxZEdWQU1UUWdiV0ZwYmw5eVpXMXZkbVZmYldGMGRYSnBkSGxmY205MWRHVkFNVFVnYldGcGJsOXpaWFJmWTI5dWRtVnljMmx2Ymw5bVpXVmZjbTkxZEdWQU1UWWdiV0ZwYmw5d1lYVnpaVjlqYjI1MlpYSjBaWEpmY205MWRHVkFNVGNnYldGcGJsOTFibkJoZFhObFgyTnZiblpsY25SbGNsOXliM1YwWlVBeE9DQnRZV2x1WDJWdFpYSm5aVzVqZVY5a2FYTmhZbXhsWDJOdmJuWmxjbk5wYjI1ZmNtOTFkR1ZBTVRrZ2JXRnBibDkzYVhSb1pISmhkMTl3ZEY5MGIydGxibk5mY205MWRHVkFNakFnYldGcGJsOW5aWFJmWVdsZmNtVmpiMjF0Wlc1a1lYUnBiMjVmY205MWRHVkFNakVnYldGcGJsOTFjR1JoZEdWZllXUmtjbVZ6YzJWelgzSnZkWFJsUURJeUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNalU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdOc1lYTnpJRmxVUVhWMGIwTnZiblpsY25SbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxY0dSaGRHVmZZV1JrY21WemMyVnpYM0p2ZFhSbFFESXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPak14TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1dWUkJkWFJ2UTI5dWRtVnlkR1Z5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpFeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2RYQmtZWFJsWDJGa1pISmxjM05sY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJGcFgzSmxZMjl0YldWdVpHRjBhVzl1WDNKdmRYUmxRREl4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJNU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1dWUkJkWFJ2UTI5dWRtVnlkR1Z5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNamsxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdaMlYwWDJGcFgzSmxZMjl0YldWdVpHRjBhVzl1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM2RwZEdoa2NtRjNYM0IwWDNSdmEyVnVjMTl5YjNWMFpVQXlNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG95TmpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJR05zWVhOeklGbFVRWFYwYjBOdmJuWmxjblJsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakkyT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhkcGRHaGtjbUYzWDNCMFgzUnZhMlZ1Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaVzFsY21kbGJtTjVYMlJwYzJGaWJHVmZZMjl1ZG1WeWMybHZibDl5YjNWMFpVQXhPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG95TmpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdWdFpYSm5aVzVqZVY5a2FYTmhZbXhsWDJOdmJuWmxjbk5wYjI0S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1Z1Y0dGMWMyVmZZMjl1ZG1WeWRHVnlYM0p2ZFhSbFFERTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakkxTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnZFc1d1lYVnpaVjlqYjI1MlpYSjBaWElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzQmhkWE5sWDJOdmJuWmxjblJsY2w5eWIzVjBaVUF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlIQmhkWE5sWDJOdmJuWmxjblJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMlYwWDJOdmJuWmxjbk5wYjI1ZlptVmxYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakl6TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1dWUkJkWFJ2UTI5dWRtVnlkR1Z5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNak13Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzJWMFgyTnZiblpsY25OcGIyNWZabVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaVzF2ZG1WZmJXRjBkWEpwZEhsZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qSXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnlaVzF2ZG1WZmJXRjBkWEpwZEhrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZrWkY5dFlYUjFjbWwwZVY5eWIzVjBaVUF4TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUdOc1lYTnpJRmxVUVhWMGIwTnZiblpsY25SbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHRmtaRjl0WVhSMWNtbDBlUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyRnNZM1ZzWVhSbFgyTnZiblpsY25OcGIyNWZiM1YwY0hWMFgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTVOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnWTJ4aGMzTWdXVlJCZFhSdlEyOXVkbVZ5ZEdWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWTJGc1kzVnNZWFJsWDJOdmJuWmxjbk5wYjI1ZmIzVjBjSFYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5amIyNTJaWEp6YVc5dVgybHVabTlmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRnM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZlkyOXVkbVZ5YzJsdmJsOXBibVp2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5MWMyVnlYMkpoYkdGdVkyVnpYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakUzT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwWDNWelpYSmZZbUZzWVc1alpYTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYM1Z6WlhKZlkyOXVabWxuWDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pFMk9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzVnpaWEpmWTI5dVptbG5DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTmhibDlsZUdWamRYUmxYMk52Ym5abGNuTnBiMjVmY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklHTnNZWE56SUZsVVFYVjBiME52Ym5abGNuUmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCallXNWZaWGhsWTNWMFpWOWpiMjUyWlhKemFXOXVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVjRaV04xZEdWZlkyOXVkbVZ5YzJsdmJsOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qRXdOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1kyeGhjM01nV1ZSQmRYUnZRMjl1ZG1WeWRHVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pFd05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHVjRaV04xZEdWZlkyOXVkbVZ5YzJsdmJnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWkdWd2IzTnBkRjk1ZEY5MGIydGxibk5mY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1dWUkJkWFJ2UTI5dWRtVnlkR1Z5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJrWlhCdmMybDBYM2wwWDNSdmEyVnVjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyOXVabWxuZFhKbFgyTnZiblpsY25OcGIyNWZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUbzNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1kyeGhjM01nV1ZSQmRYUnZRMjl1ZG1WeWRHVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQmpiMjVtYVdkMWNtVmZZMjl1ZG1WeWMybHZiZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmFXNXBkR2xoYkdsNlpWOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCamJHRnpjeUJaVkVGMWRHOURiMjUyWlhKMFpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR2x1YVhScFlXeHBlbVVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF5TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1kyeGhjM01nV1ZSQmRYUnZRMjl1ZG1WeWRHVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREkxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k1amIyNTBjbUZqZEM1WlZFRjFkRzlEYjI1MlpYSjBaWEl1YVc1cGRHbGhiR2w2WlNodmNtRmpiR1ZmWVdSa2NtVnpjem9nWW5sMFpYTXNJSFJ2YTJWdWFYcGhkR2x2Ymw5aFpHUnlaWE56T2lCaWVYUmxjeXdnWVcxdFgyRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2FXNXBkR2xoYkdsNlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUbzFOaTAyTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYVc1cGRHbGhiR2w2WlNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lHOXlZV05zWlY5aFpHUnlaWE56T2lCQ2VYUmxjeXdLSUNBZ0lDOHZJQ0FnSUNCMGIydGxibWw2WVhScGIyNWZZV1JrY21WemN6b2dRbmwwWlhNc0NpQWdJQ0F2THlBZ0lDQWdZVzF0WDJGa1pISmxjM002SUVKNWRHVnpMQW9nSUNBZ0x5OGdLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdhVzVwZEdsaGJHbDZaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR2x1YVhScFlXeHBlbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG8yTmdvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmk1MllXeDFaU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z2MyVnNaaTV2Y21GamJHVmZZV1JrY21WemN5NTJZV3gxWlNBOUlHOXlZV05zWlY5aFpHUnlaWE56Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpYjNKaFkyeGxYMkZrWkhKbGMzTWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJSE5sYkdZdWRHOXJaVzVwZW1GMGFXOXVYMkZrWkhKbGMzTXVkbUZzZFdVZ1BTQjBiMnRsYm1sNllYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJblJ2YTJWdWFYcGhkR2x2Ymw5aFpHUnlaWE56SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlCelpXeG1MbUZ0YlY5aFpHUnlaWE56TG5aaGJIVmxJRDBnWVcxdFgyRmtaSEpsYzNNS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKaGJXMWZZV1JrY21WemN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdjMlZzWmk1amIyNTJaWEp6YVc5dVgyWmxaUzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3pNQ2tnSUNNZ01DNHpKUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZMjl1ZG1WeWMybHZibDltWldVaUNpQWdJQ0J3ZFhOb2FXNTBJRE13SUM4dklETXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJ6Wld4bUxtbHpYM0JoZFhObFpDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWFYTmZjR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZZMjl1ZG1WeWMybHZibk11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJ2ZEdGc1gyTnZiblpsY25OcGIyNXpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZOelFLSUNBZ0lDOHZJR3h2WnloaUlsbFVRWFYwYjBOdmJuWmxjblJsY2lCcGJtbDBhV0ZzYVhwbFpDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFPVFUwTkRFM05UYzBObVkwTXpabU5tVTNOalkxTnpJM05EWTFOekl5TURZNU5tVTJPVGMwTmprMk1UWmpOamszWVRZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qYzFDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKQmRYUnZJR052Ym5abGNuUmxjaUJwYm1sMGFXRnNhWHBsWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkJkWFJ2SUdOdmJuWmxjblJsY2lCcGJtbDBhV0ZzYVhwbFpDQnpkV05qWlhOelpuVnNiSGtpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXVZMjl1ZEhKaFkzUXVXVlJCZFhSdlEyOXVkbVZ5ZEdWeUxtTnZibVpwWjNWeVpWOWpiMjUyWlhKemFXOXVLR1Z1WVdKc1pXUTZJSFZwYm5RMk5Dd2dkR2h5WlhOb2IyeGtYM0J5YVdObE9pQjFhVzUwTmpRc0lHMWhkSFZ5YVhSNU9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncGpiMjVtYVdkMWNtVmZZMjl1ZG1WeWMybHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG8zTnkwNE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1kyOXVabWxuZFhKbFgyTnZiblpsY25OcGIyNG9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0JsYm1GaWJHVmtPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnZEdoeVpYTm9iMnhrWDNCeWFXTmxPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnYldGMGRYSnBkSGs2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBhSEpsYzJodmJHUmZjSEpwWTJVZ1BpQlZTVzUwTmpRb01Da3NJQ0pVYUhKbGMyaHZiR1FnY0hKcFkyVWdiWFZ6ZENCaVpTQndiM05wZEdsMlpTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhOelpYSjBJQzh2SUZSb2NtVnphRzlzWkNCd2NtbGpaU0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZWFIxY21sMGVTQStJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0xDQWlUV0YwZFhKcGRIa2diWFZ6ZENCaVpTQnBiaUJtZFhSMWNtVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJOWVhSMWNtbDBlU0J0ZFhOMElHSmxJR2x1SUdaMWRIVnlaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPamc0Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZiblpsY25OcGIyNWZaVzVoWW14bFpGdFVlRzR1YzJWdVpHVnlYU0E5SUdWdVlXSnNaV1FLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiblpsY25OcGIyNWZaVzVoWW14bFpDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qZzVDaUFnSUNBdkx5QnpaV3htTG5Sb2NtVnphRzlzWkY5d2NtbGpaVnRVZUc0dWMyVnVaR1Z5WFNBOUlIUm9jbVZ6YUc5c1pGOXdjbWxqWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlkR2h5WlhOb2IyeGtYM0J5YVdObElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklITmxiR1l1ZFhObGNsOXRZWFIxY21sMGVWdFVlRzR1YzJWdVpHVnlYU0E5SUcxaGRIVnlhWFI1Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkWE5sY2w5dFlYUjFjbWwwZVNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2preENpQWdJQ0F2THlCelpXeG1MbU52Ym5abGNuTnBiMjVmWlhobFkzVjBaV1JiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Da2dJQ01nVW1WelpYUWdaWGhsWTNWMGFXOXVJSE4wWVhSMWN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldNZ055QXZMeUFpWTI5dWRtVnljMmx2Ymw5bGVHVmpkWFJsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RNS0lDQWdJQzh2SUd4dlp5aGlJa052Ym5abGNuTnBiMjRnWTI5dVptbG5kWEpsWkNBdElFVnVZV0pzWldRNklDSWdLeUJ2Y0M1cGRHOWlLR1Z1WVdKc1pXUXBJQ3NnWWlJZ1ZHaHlaWE5vYjJ4a09pQWlJQ3NnYjNBdWFYUnZZaWgwYUhKbGMyaHZiR1JmY0hKcFkyVXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBNelptTm1VM05qWTFOekkzTXpZNU5tWTJaVEl3TmpNMlpqWmxOalkyT1RZM056VTNNalkxTmpReU1ESmtNakEwTlRabE5qRTJNalpqTmpVMk5ETmhNakFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpBMU5EWTROekkyTlRjek5qZzJaalpqTmpRellUSXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lRMjl1ZG1WeWMybHZiaUJqYjI1bWFXZDFjbVZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrTnZiblpsY25OcGIyNGdZMjl1Wm1sbmRYSmxaQ0J6ZFdOalpYTnpablZzYkhraUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl1WTI5dWRISmhZM1F1V1ZSQmRYUnZRMjl1ZG1WeWRHVnlMbVJsY0c5emFYUmZlWFJmZEc5clpXNXpLR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taR1Z3YjNOcGRGOTVkRjkwYjJ0bGJuTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZPVFl0T1RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdSbGNHOXphWFJmZVhSZmRHOXJaVzV6S0hObGJHWXNJR0Z0YjNWdWREb2dWVWx1ZERZMEtTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklITmxiR1l1ZVhSZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQTlJSE5sYkdZdWVYUmZZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0FySUdGdGIzVnVkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5sMFgySmhiR0Z1WTJVaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTVkRjlpWVd4aGJtTmxJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBckNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0o1ZEY5aVlXeGhibU5sSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJzYjJjb1lpSlpWQ0IwYjJ0bGJuTWdaR1Z3YjNOcGRHVmtJQzBnUVcxdmRXNTBPaUFpSUNzZ2IzQXVhWFJ2WWloaGJXOTFiblFwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxT1RVME1qQTNORFptTm1JMk5UWmxOek15TURZME5qVTNNRFptTnpNMk9UYzBOalUyTkRJd01tUXlNRFF4Tm1RMlpqYzFObVUzTkROaE1qQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlpWQ0IwYjJ0bGJuTWdaR1Z3YjNOcGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxsVUlIUnZhMlZ1Y3lCa1pYQnZjMmwwWldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxubDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUxtTnZiblJ5WVdOMExsbFVRWFYwYjBOdmJuWmxjblJsY2k1bGVHVmpkWFJsWDJOdmJuWmxjbk5wYjI0b2RYTmxjam9nWW5sMFpYTXNJRzFwYmw5d2RGOWhiVzkxYm5RNklIVnBiblEyTkN3Z1pHVmhaR3hwYm1VNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtVjRaV04xZEdWZlkyOXVkbVZ5YzJsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hNRFl0TVRFeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCbGVHVmpkWFJsWDJOdmJuWmxjbk5wYjI0b0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5T2lCQ2VYUmxjeXdLSUNBZ0lDOHZJQ0FnSUNCdGFXNWZjSFJmWVcxdmRXNTBPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWkdWaFpHeHBibVU2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVEUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOXdZWFZ6WldRdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RBcExDQWlRMjl1ZG1WeWRHVnlJR2x6SUhCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnBjMTl3WVhWelpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOZmNHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVOdmJuWmxjblJsY2lCcGN5QndZWFZ6WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0E4UFNCa1pXRmtiR2x1WlN3Z0lsUnlZVzV6WVdOMGFXOXVJR1Y0Y0dseVpXUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVkhKaGJuTmhZM1JwYjI0Z1pYaHdhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZMjl1ZG1WeWMybHZibDlsYm1GaWJHVmtXMVI0Ymk1elpXNWtaWEpkSUQwOUlGVkpiblEyTkNneEtTd2dJa052Ym5abGNuTnBiMjRnYm05MElHVnVZV0pzWldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZMjl1ZG1WeWMybHZibDlsYm1GaWJHVmtJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dWRtVnljMmx2Ymw5bGJtRmliR1ZrSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXVkbVZ5YzJsdmJpQnViM1FnWlc1aFlteGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakV5TVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVkyOXVkbVZ5YzJsdmJsOWxlR1ZqZFhSbFpGdFVlRzR1YzJWdVpHVnlYU0E5UFNCVlNXNTBOalFvTUNrc0lDSkRiMjUyWlhKemFXOXVJR0ZzY21WaFpIa2daWGhsWTNWMFpXUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpWTI5dWRtVnljMmx2Ymw5bGVHVmpkWFJsWkNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZiblpsY25OcGIyNWZaWGhsWTNWMFpXUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTI5dWRtVnljMmx2YmlCaGJISmxZV1I1SUdWNFpXTjFkR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJekxURXlOUW9nSUNBZ0x5OGdJeUJEYUdWamF5QnBaaUIwYUhKbGMyaHZiR1FnYVhNZ2NtVmhZMmhsWkNBb2MybHRjR3hwWm1sbFpDQXRJSGR2ZFd4a0lHTmhiR3dnYjNKaFkyeGxJR052Ym5SeVlXTjBLUW9nSUNBZ0x5OGdJeUJHYjNJZ1pHVnRieXdnWVhOemRXMWxJSFJvY21WemFHOXNaQ0JwY3lCeVpXRmphR1ZrSUdsbUlIUm9jbVZ6YUc5c1pGOXdjbWxqWlNBK0lEQUtJQ0FnSUM4dklIVnpaWEpmZEdoeVpYTm9iMnhrSUQwZ2MyVnNaaTUwYUhKbGMyaHZiR1JmY0hKcFkyVmJWSGh1TG5ObGJtUmxjbDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGFISmxjMmh2YkdSZmNISnBZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGFISmxjMmh2YkdSZmNISnBZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCaGMzTmxjblFnZFhObGNsOTBhSEpsYzJodmJHUWdQaUJWU1c1ME5qUW9NQ2tzSUNKVWFISmxjMmh2YkdRZ2JtOTBJSEpsWVdOb1pXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHaHlaWE5vYjJ4a0lHNXZkQ0J5WldGamFHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVEk0TFRFeU9Rb2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCWlZDQmlZV3hoYm1ObENpQWdJQ0F2THlCMWMyVnlYM2wwWDJKaGJHRnVZMlVnUFNCelpXeG1MbmwwWDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjVkRjlpWVd4aGJtTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZVhSZlltRnNZVzVqWlNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveE16QUtJQ0FnSUM4dklHRnpjMlZ5ZENCMWMyVnlYM2wwWDJKaGJHRnVZMlVnUGlCVlNXNTBOalFvTUNrc0lDSk9ieUJaVkNCMGIydGxibk1nZEc4Z1kyOXVkbVZ5ZENJS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUZsVUlIUnZhMlZ1Y3lCMGJ5QmpiMjUyWlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UTXlMVEV6TXdvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ1kyOXVkbVZ5YzJsdmJpQm1aV1VLSUNBZ0lDOHZJR1psWlY5aGJXOTFiblFnUFNBb2RYTmxjbDk1ZEY5aVlXeGhibU5sSUNvZ2MyVnNaaTVqYjI1MlpYSnphVzl1WDJabFpTNTJZV3gxWlNrZ0x5OGdjMlZzWmk1bVpXVmZaR1Z1YjIxcGJtRjBiM0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpiMjUyWlhKemFXOXVYMlpsWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiMjUyWlhKemFXOXVYMlpsWlNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltWmxaVjlrWlc1dmJXbHVZWFJ2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW1aV1ZmWkdWdWIyMXBibUYwYjNJZ1pYaHBjM1J6Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJqYjI1MlpYSnphVzl1WDJGdGIzVnVkQ0E5SUhWelpYSmZlWFJmWW1Gc1lXNWpaU0F0SUdabFpWOWhiVzkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpnM0xUSTRPQW9nSUNBZ0x5OGdJeUJUYVcxMWJHRjBaU0J6Ykdsd2NHRm5aU0JoYm1RZ2JXRnlhMlYwSUdsdGNHRmpkQW9nSUNBZ0x5OGdjMnhwY0hCaFoyVmZabUZqZEc5eUlEMGdWVWx1ZERZMEtEazVOVEFwSUNBaklEQXVOU1VnYzJ4cGNIQmhaMlVLSUNBZ0lIQjFjMmhwYm5RZ09UazFNQ0F2THlBNU9UVXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNamc1Q2lBZ0lDQXZMeUJ0WVhKclpYUmZjbUYwWlNBOUlDaGhiVzkxYm5RZ0tpQnpiR2x3Y0dGblpWOW1ZV04wYjNJcElDOHZJRlZKYm5RMk5DZ3hNREF3TUNrS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXhNREF3TUFvZ0lDQWdMd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakk1TVFvZ0lDQWdMeThnWVhOelpYSjBJRzFoY210bGRGOXlZWFJsSUQ0OUlHMXBibDl2ZFhSd2RYUXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2IzVjBjSFYwSUdGdGIzVnVkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQnZkWFJ3ZFhRZ1lXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNNUxURTBNQW9nSUNBZ0x5OGdJeUJWY0dSaGRHVWdZbUZzWVc1alpYTUtJQ0FnSUM4dklITmxiR1l1ZVhSZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQTlJRlZKYm5RMk5DZ3dLU0FnSXlCQmJHd2dXVlFnZEc5clpXNXpJR052Ym5abGNuUmxaQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWVYUmZZbUZzWVc1alpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UUXhDaUFnSUNBdkx5QnpaV3htTG5CMFgySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMGdQU0J6Wld4bUxuQjBYMkpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBnS3lCeVpXTmxhWFpsWkY5d2RBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbkIwWDJKaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2RGOWlZV3hoYm1ObElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbkIwWDJKaGJHRnVZMlVpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJSE5sYkdZdVkyOXVkbVZ5YzJsdmJsOWxlR1ZqZFhSbFpGdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTnlBdkx5QWlZMjl1ZG1WeWMybHZibDlsZUdWamRYUmxaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVFEwTFRFME5Rb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ1oyeHZZbUZzSUhOMFlYUnpDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMk52Ym5abGNuTnBiMjV6TG5aaGJIVmxJRDBnYzJWc1ppNTBiM1JoYkY5amIyNTJaWEp6YVc5dWN5NTJZV3gxWlNBcklGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5SdmRHRnNYMk52Ym5abGNuTnBiMjV6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJOdmJuWmxjbk5wYjI1eklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUnZkR0ZzWDJOdmJuWmxjbk5wYjI1eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hORGNLSUNBZ0lDOHZJR3h2WnloaUlrTnZiblpsY25OcGIyNGdaWGhsWTNWMFpXUWdMU0JaVkRvZ0lpQXJJRzl3TG1sMGIySW9kWE5sY2w5NWRGOWlZV3hoYm1ObEtTQXJJR0lpSUZCVU9pQWlJQ3NnYjNBdWFYUnZZaWh5WldObGFYWmxaRjl3ZENrcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME16Wm1ObVUzTmpZMU56STNNelk1Tm1ZMlpUSXdOalUzT0RZMU5qTTNOVGMwTmpVMk5ESXdNbVF5TURVNU5UUXpZVEl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJd05UQTFORE5oTWpBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lrTnZiblpsY25OcGIyNGdaWGhsWTNWMFpXUWdjM1ZqWTJWemMyWjFiR3g1SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUTI5dWRtVnljMmx2YmlCbGVHVmpkWFJsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVYUmZZWFYwYjE5amIyNTJaWEowWlhJdVkyOXVkSEpoWTNRdVdWUkJkWFJ2UTI5dWRtVnlkR1Z5TG1OaGJsOWxlR1ZqZFhSbFgyTnZiblpsY25OcGIyNG9kWE5sY2pvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1kyRnVYMlY0WldOMWRHVmZZMjl1ZG1WeWMybHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG94TlRBdE1UVXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCallXNWZaWGhsWTNWMFpWOWpiMjUyWlhKemFXOXVLSE5sYkdZc0lIVnpaWEk2SUVKNWRHVnpLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hOVE10TVRVMENpQWdJQ0F2THlBaklGTnBiWEJzYVdacFpXUWdZMmhsWTJzZ2RYTnBibWNnYzJWdVpHVnlKM01nWkdGMFlRb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1amIyNTJaWEp6YVc5dVgyVnVZV0pzWldSYlZIaHVMbk5sYm1SbGNsMGdQVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiblpsY25OcGIyNWZaVzVoWW14bFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU52Ym5abGNuTnBiMjVmWlc1aFlteGxaQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHSnVlaUJqWVc1ZlpYaGxZM1YwWlY5amIyNTJaWEp6YVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pFMU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1NBZ0l5Qk9iM1FnWlc1aFlteGxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRITjFZZ29LWTJGdVgyVjRaV04xZEdWZlkyOXVkbVZ5YzJsdmJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UVTNDaUFnSUNBdkx5QnBaaUJ6Wld4bUxtTnZiblpsY25OcGIyNWZaWGhsWTNWMFpXUmJWSGh1TG5ObGJtUmxjbDBnUFQwZ1ZVbHVkRFkwS0RFcE9nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbU52Ym5abGNuTnBiMjVmWlhobFkzVjBaV1FpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIyNTJaWEp6YVc5dVgyVjRaV04xZEdWa0lHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJqWVc1ZlpYaGxZM1YwWlY5amIyNTJaWEp6YVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pFMU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1NBZ0l5QkJiSEpsWVdSNUlHVjRaV04xZEdWa0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwYzNWaUNncGpZVzVmWlhobFkzVjBaVjlqYjI1MlpYSnphVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG94TmpBS0lDQWdJQzh2SUdsbUlITmxiR1l1ZVhSZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWVYUmZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbmwwWDJKaGJHRnVZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQmlibm9nWTJGdVgyVjRaV04xZEdWZlkyOXVkbVZ5YzJsdmJsOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5qRUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTUNrZ0lDTWdUbThnV1ZRZ2RHOXJaVzV6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBjM1ZpQ2dwallXNWZaWGhsWTNWMFpWOWpiMjUyWlhKemFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJR2xtSUhObGJHWXVkR2h5WlhOb2IyeGtYM0J5YVdObFcxUjRiaTV6Wlc1a1pYSmRJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBhSEpsYzJodmJHUmZjSEpwWTJVaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBhSEpsYzJodmJHUmZjSEpwWTJVZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JpYm5vZ1kyRnVYMlY0WldOMWRHVmZZMjl1ZG1WeWMybHZibDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da2dJQ01nVG04Z2RHaHlaWE5vYjJ4a0lITmxkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRITjFZZ29LWTJGdVgyVjRaV04xZEdWZlkyOXVkbVZ5YzJsdmJsOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UWTJMVEUyTndvZ0lDQWdMeThnSXlCSmJpQndjbTlrZFdOMGFXOXVMQ0IzYjNWc1pDQmphR1ZqYXlCdmNtRmpiR1VnWm05eUlHRmpkSFZoYkNCMGFISmxjMmh2YkdRZ2MzUmhkSFZ6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtERXBJQ0FqSUVOaGJpQmxlR1ZqZFhSbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmwwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMbU52Ym5SeVlXTjBMbGxVUVhWMGIwTnZiblpsY25SbGNpNW5aWFJmZFhObGNsOWpiMjVtYVdjb0tTQXRQaUJpZVhSbGN6b0taMlYwWDNWelpYSmZZMjl1Wm1sbk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTNNd29nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWpiMjUyWlhKemFXOXVYMlZ1WVdKc1pXUmJWSGh1TG5ObGJtUmxjbDBwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiblpsY25OcGIyNWZaVzVoWW14bFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU52Ym5abGNuTnBiMjVmWlc1aFlteGxaQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG94TnpRS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEdoeVpYTm9iMnhrWDNCeWFXTmxXMVI0Ymk1elpXNWtaWEpkS1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBhSEpsYzJodmJHUmZjSEpwWTJVaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBhSEpsYzJodmJHUmZjSEpwWTJVZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1UYzFDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuVnpaWEpmYldGMGRYSnBkSGxiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0oxYzJWeVgyMWhkSFZ5YVhSNUlnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWE5sY2w5dFlYUjFjbWwwZVNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdVkyOXVkbVZ5YzJsdmJsOWxlR1ZqZFhSbFpGdFVlRzR1YzJWdVpHVnlYU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKamIyNTJaWEp6YVc5dVgyVjRaV04xZEdWa0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl1ZG1WeWMybHZibDlsZUdWamRYUmxaQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG94TnpJdE1UYzNDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29DaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTVqYjI1MlpYSnphVzl1WDJWdVlXSnNaV1JiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkR2h5WlhOb2IyeGtYM0J5YVdObFcxUjRiaTV6Wlc1a1pYSmRLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5WelpYSmZiV0YwZFhKcGRIbGJWSGh1TG5ObGJtUmxjbDBwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdVkyOXVkbVZ5YzJsdmJsOWxlR1ZqZFhSbFpGdFVlRzR1YzJWdVpHVnlYU2tLSUNBZ0lDOHZJQ2twQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl1WTI5dWRISmhZM1F1V1ZSQmRYUnZRMjl1ZG1WeWRHVnlMbWRsZEY5MWMyVnlYMkpoYkdGdVkyVnpLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOTFjMlZ5WDJKaGJHRnVZMlZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pFNE13b2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1NWRGOWlZV3hoYm1ObFcxUjRiaTV6Wlc1a1pYSmRLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKNWRGOWlZV3hoYm1ObElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVlWFJmWW1Gc1lXNWpaU0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG94T0RRS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y0hSZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0p3ZEY5aVlXeGhibU5sSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNIUmZZbUZzWVc1alpTQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hPREl0TVRnMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTVkRjlpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuQjBYMkpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBwQ2lBZ0lDQXZMeUFwS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl1WTI5dWRISmhZM1F1V1ZSQmRYUnZRMjl1ZG1WeWRHVnlMbWRsZEY5amIyNTJaWEp6YVc5dVgybHVabThvS1NBdFBpQmllWFJsY3pvS1oyVjBYMk52Ym5abGNuTnBiMjVmYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3hPVEVLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVZMjl1ZG1WeWMybHZibDltWldVdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU52Ym5abGNuTnBiMjVmWm1WbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU52Ym5abGNuTnBiMjVmWm1WbElHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pFNU1nb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjlqYjI1MlpYSnphVzl1Y3k1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzkwWVd4ZlkyOXVkbVZ5YzJsdmJuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZZMjl1ZG1WeWMybHZibk1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVGt6Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbWx6WDNCaGRYTmxaQzUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mY0dGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTVNQzB4T1RRS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtTnZiblpsY25OcGIyNWZabVZsTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYMk52Ym5abGNuTnBiMjV6TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1selgzQmhkWE5sWkM1MllXeDFaU2tLSUNBZ0lDOHZJQ2twQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxubDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUxtTnZiblJ5WVdOMExsbFVRWFYwYjBOdmJuWmxjblJsY2k1allXeGpkV3hoZEdWZlkyOXVkbVZ5YzJsdmJsOXZkWFJ3ZFhRb2VYUmZZVzF2ZFc1ME9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncGpZV3hqZFd4aGRHVmZZMjl1ZG1WeWMybHZibDl2ZFhSd2RYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNVGsyTFRFNU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnWTJGc1kzVnNZWFJsWDJOdmJuWmxjbk5wYjI1ZmIzVjBjSFYwS0hObGJHWXNJSGwwWDJGdGIzVnVkRG9nVlVsdWREWTBLU0F0UGlCaGNtTTBMbFIxY0d4bFcyRnlZelF1VlVsdWREWTBMQ0JoY21NMExsVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG94T1RrS0lDQWdJQzh2SUdsbUlIbDBYMkZ0YjNWdWRDQTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnVlaUJqWVd4amRXeGhkR1ZmWTI5dWRtVnljMmx2Ymw5dmRYUndkWFJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNakF3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvWVhKak5DNVZTVzUwTmpRb01Da3NJR0Z5WXpRdVZVbHVkRFkwS0RBcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWFJ6ZFdJS0NtTmhiR04xYkdGMFpWOWpiMjUyWlhKemFXOXVYMjkxZEhCMWRGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qQXlDaUFnSUNBdkx5Qm1aV1ZmWVcxdmRXNTBJRDBnS0hsMFgyRnRiM1Z1ZENBcUlITmxiR1l1WTI5dWRtVnljMmx2Ymw5bVpXVXVkbUZzZFdVcElDOHZJSE5sYkdZdVptVmxYMlJsYm05dGFXNWhkRzl5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZMjl1ZG1WeWMybHZibDltWldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl1ZG1WeWMybHZibDltWldVZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVptVmxYMlJsYm05dGFXNWhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtWmxaVjlrWlc1dmJXbHVZWFJ2Y2lCbGVHbHpkSE1LSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJR052Ym5abGNuTnBiMjVmWVcxdmRXNTBJRDBnZVhSZllXMXZkVzUwSUMwZ1ptVmxYMkZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JrYVdjZ01Rb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJd05TMHlNRFlLSUNBZ0lDOHZJQ01nVTJsdGNHeHBabWxsWkNCamIyNTJaWEp6YVc5dUlISmhkR1VnS0RFNk1TQnRhVzUxY3lCemJHbHdjR0ZuWlNrS0lDQWdJQzh2SUhOc2FYQndZV2RsWDJGdGIzVnVkQ0E5SUNoamIyNTJaWEp6YVc5dVgyRnRiM1Z1ZENBcUlGVkpiblEyTkNnMU1Da3BJQzh2SUZWSmJuUTJOQ2d4TURBd01Da2dJQ01nTUM0MUpTQnpiR2x3Y0dGblpRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFV3SUM4dklEVXdDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTVRBd01EQUtJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1EY0tJQ0FnSUM4dklHVjRjR1ZqZEdWa1gzQjBJRDBnWTI5dWRtVnljMmx2Ymw5aGJXOTFiblFnTFNCemJHbHdjR0ZuWlY5aGJXOTFiblFLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3lNRGtLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExsVkpiblEyTkNobGVIQmxZM1JsWkY5d2RDa3NJR0Z5WXpRdVZVbHVkRFkwS0dabFpWOWhiVzkxYm5RcEtTa0tJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxubDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUxtTnZiblJ5WVdOMExsbFVRWFYwYjBOdmJuWmxjblJsY2k1aFpHUmZiV0YwZFhKcGRIa29iV0YwZFhKcGRIazZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbUZrWkY5dFlYUjFjbWwwZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1URXRNakV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJoWkdSZmJXRjBkWEpwZEhrb2MyVnNaaXdnYldGMGRYSnBkSGs2SUZWSmJuUTJOQ2tnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNakUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV0YwZFhKcGRIa2dQaUJIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDd2dJazFoZEhWeWFYUjVJRzExYzNRZ1ltVWdhVzRnWm5WMGRYSmxJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVFdGMGRYSnBkSGtnYlhWemRDQmlaU0JwYmlCbWRYUjFjbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG95TVRZdE1qRTNDaUFnSUNBdkx5QWpJRVp2Y2lCemFXMXdiR2xqYVhSNUxDQnFkWE4wSUhWd1pHRjBaU0IxYzJWeUozTWdiV0YwZFhKcGRIa0tJQ0FnSUM4dklITmxiR1l1ZFhObGNsOXRZWFIxY21sMGVWdFVlRzR1YzJWdVpHVnlYU0E5SUcxaGRIVnlhWFI1Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkWE5sY2w5dFlYUjFjbWwwZVNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z2JHOW5LR0lpVFdGMGRYSnBkSGtnWVdSa1pXUWdMU0JXWVd4MVpUb2dJaUFySUc5d0xtbDBiMklvYldGMGRYSnBkSGtwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwWkRZeE56UTNOVGN5TmprM05EYzVNakEyTVRZME5qUTJOVFkwTWpBeVpESXdOVFkyTVRaak56VTJOVE5oTWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qSXdDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKTllYUjFjbWwwZVNCaFpHUmxaQ0J6ZFdOalpYTnpablZzYkhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKTllYUjFjbWwwZVNCaFpHUmxaQ0J6ZFdOalpYTnpablZzYkhraUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl1WTI5dWRISmhZM1F1V1ZSQmRYUnZRMjl1ZG1WeWRHVnlMbkpsYlc5MlpWOXRZWFIxY21sMGVTZ3BJQzArSUdKNWRHVnpPZ3B5WlcxdmRtVmZiV0YwZFhKcGRIazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNakkxQ2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmYldGMGRYSnBkSGxiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKMWMyVnlYMjFoZEhWeWFYUjVJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3lNamNLSUNBZ0lDOHZJR3h2WnloaUlrMWhkSFZ5YVhSNUlISmxiVzkyWldRaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5HUTJNVGMwTnpVM01qWTVOelEzT1RJd056STJOVFprTm1ZM05qWTFOalFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lUV0YwZFhKcGRIa2djbVZ0YjNabFpDQnpkV05qWlhOelpuVnNiSGtpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pOWVhSMWNtbDBlU0J5WlcxdmRtVmtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTVqYjI1MGNtRmpkQzVaVkVGMWRHOURiMjUyWlhKMFpYSXVjMlYwWDJOdmJuWmxjbk5wYjI1ZlptVmxLRzVsZDE5bVpXVTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbk5sZEY5amIyNTJaWEp6YVc5dVgyWmxaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG95TXpBdE1qTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpaWFJmWTI5dWRtVnljMmx2Ymw5bVpXVW9jMlZzWml3Z2JtVjNYMlpsWlRvZ1ZVbHVkRFkwS1NBdFBpQlRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG95TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5SUhObGJHWXVZV1J0YVc0dWRtRnNkV1VzSUNKUGJteDVJR0ZrYldsdUlHTmhiaUJ6WlhRZ1ptVmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQnpaWFFnWm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qTTBDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYMlpsWlNBOFBTQlZTVzUwTmpRb01UQXdNQ2tzSUNKR1pXVWdkRzl2SUdocFoyZ2dLRzFoZUNBeE1DVXBJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURFd01EQWdMeThnTVRBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJHWldVZ2RHOXZJR2hwWjJnZ0tHMWhlQ0F4TUNVcENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qTTJDaUFnSUNBdkx5QnZiR1JmWm1WbElEMGdjMlZzWmk1amIyNTJaWEp6YVc5dVgyWmxaUzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OdmJuWmxjbk5wYjI1ZlptVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmJuWmxjbk5wYjI1ZlptVmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qSXpOd29nSUNBZ0x5OGdjMlZzWmk1amIyNTJaWEp6YVc5dVgyWmxaUzUyWVd4MVpTQTlJRzVsZDE5bVpXVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnZiblpsY25OcGIyNWZabVZsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJek9Rb2dJQ0FnTHk4Z2JHOW5LR0lpUTI5dWRtVnljMmx2YmlCbVpXVWdkWEJrWVhSbFpDQXRJRTlzWkRvZ0lpQXJJRzl3TG1sMGIySW9iMnhrWDJabFpTa2dLeUJpSWlCT1pYYzZJQ0lnS3lCdmNDNXBkRzlpS0c1bGQxOW1aV1VwS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRNMlpqWmxOelkyTlRjeU56TTJPVFptTm1VeU1EWTJOalUyTlRJd056VTNNRFkwTmpFM05EWTFOalF5TURKa01qQTBaalpqTmpRellUSXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREl3TkdVMk5UYzNNMkV5TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qUXdDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKRGIyNTJaWEp6YVc5dUlHWmxaU0IxY0dSaGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtOdmJuWmxjbk5wYjI0Z1ptVmxJSFZ3WkdGMFpXUWdjM1ZqWTJWemMyWjFiR3g1SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmwwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMbU52Ym5SeVlXTjBMbGxVUVhWMGIwTnZiblpsY25SbGNpNXdZWFZ6WlY5amIyNTJaWEowWlhJb0tTQXRQaUJpZVhSbGN6b0tjR0YxYzJWZlkyOXVkbVZ5ZEdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qSTBOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJazl1YkhrZ1lXUnRhVzRnWTJGdUlIQmhkWE5sSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUlHTmhiaUJ3WVhWelpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qSTBOZ29nSUNBZ0x5OGdjMlZzWmk1cGMxOXdZWFZ6WldRdWRtRnNkV1VnUFNCVlNXNTBOalFvTVNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1selgzQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJME9Bb2dJQ0FnTHk4Z2JHOW5LR0lpUTI5dWRtVnlkR1Z5SUhCaGRYTmxaQ0lwQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUF3ZURRek5tWTJaVGMyTmpVM01qYzBOalUzTWpJd056QTJNVGMxTnpNMk5UWTBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3lORGtLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lrTnZiblpsY25SbGNpQndZWFZ6WldRaUtRb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0lrTnZiblpsY25SbGNpQndZWFZ6WldRaUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl1WTI5dWRISmhZM1F1V1ZSQmRYUnZRMjl1ZG1WeWRHVnlMblZ1Y0dGMWMyVmZZMjl1ZG1WeWRHVnlLQ2tnTFQ0Z1lubDBaWE02Q25WdWNHRjFjMlZmWTI5dWRtVnlkR1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUhWdWNHRjFjMlVpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJSFZ1Y0dGMWMyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3lOVFVLSUNBZ0lDOHZJSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU5UY0tJQ0FnSUM4dklHeHZaeWhpSWtOdmJuWmxjblJsY2lCMWJuQmhkWE5sWkNJcENpQWdJQ0JpZVhSbFl5QXhOaUF2THlBd2VEUXpObVkyWlRjMk5qVTNNamMwTmpVM01qSXdOelUyWlRjd05qRTNOVGN6TmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qVTRDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKRGIyNTJaWEowWlhJZ2RXNXdZWFZ6WldRaUtRb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0lrTnZiblpsY25SbGNpQjFibkJoZFhObFpDSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k1amIyNTBjbUZqZEM1WlZFRjFkRzlEYjI1MlpYSjBaWEl1WlcxbGNtZGxibU41WDJScGMyRmliR1ZmWTI5dWRtVnljMmx2YmlncElDMCtJR0o1ZEdWek9ncGxiV1Z5WjJWdVkzbGZaR2x6WVdKc1pWOWpiMjUyWlhKemFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbDBYMkYxZEc5ZlkyOXVkbVZ5ZEdWeUwyTnZiblJ5WVdOMExuQjVPakkyTXdvZ0lDQWdMeThnYzJWc1ppNWpiMjUyWlhKemFXOXVYMlZ1WVdKc1pXUmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52Ym5abGNuTnBiMjVmWlc1aFlteGxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNalkxQ2lBZ0lDQXZMeUJzYjJjb1lpSkRiMjUyWlhKemFXOXVJR1Z0WlhKblpXNWplU0JrYVhOaFlteGxaQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTXpabU5tVTNOalkxTnpJM016WTVObVkyWlRJd05qVTJaRFkxTnpJMk56WTFObVUyTXpjNU1qQTJORFk1TnpNMk1UWXlObU0yTlRZMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU5qWUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWtOdmJuWmxjbk5wYjI0Z1pHbHpZV0pzWldRZ1ptOXlJR1Z0WlhKblpXNWplU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa052Ym5abGNuTnBiMjRnWkdsellXSnNaV1FnWm05eUlHVnRaWEpuWlc1amVTSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k1amIyNTBjbUZqZEM1WlZFRjFkRzlEYjI1MlpYSjBaWEl1ZDJsMGFHUnlZWGRmY0hSZmRHOXJaVzV6S0dGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LZDJsMGFHUnlZWGRmY0hSZmRHOXJaVzV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJMk9DMHlOamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSGRwZEdoa2NtRjNYM0IwWDNSdmEyVnVjeWh6Wld4bUxDQmhiVzkxYm5RNklGVkpiblEyTkNrZ0xUNGdVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpjeENpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnVlVsdWREWTBLREFwTENBaVFXMXZkVzUwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pJM013b2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5d2RGOWlZV3hoYm1ObElEMGdjMlZzWmk1d2RGOWlZV3hoYm1ObFcxUjRiaTV6Wlc1a1pYSmRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpY0hSZlltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQjBYMkpoYkdGdVkyVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVYUmZZWFYwYjE5amIyNTJaWEowWlhJdlkyOXVkSEpoWTNRdWNIazZNamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZM1Z5Y21WdWRGOXdkRjlpWVd4aGJtTmxJRDQ5SUdGdGIzVnVkQ3dnSWtsdWMzVm1abWxqYVdWdWRDQlFWQ0JpWVd4aGJtTmxJZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElGQlVJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3lOellLSUNBZ0lDOHZJSE5sYkdZdWNIUmZZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0E5SUdOMWNuSmxiblJmY0hSZlltRnNZVzVqWlNBdElHRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKd2RGOWlZV3hoYm1ObElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpjNENpQWdJQ0F2THlCc2IyY29ZaUpRVkNCMGIydGxibk1nZDJsMGFHUnlZWGR1SUMwZ1FXMXZkVzUwT2lBaUlDc2diM0F1YVhSdllpaGhiVzkxYm5RcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU1EVTBNakEzTkRabU5tSTJOVFpsTnpNeU1EYzNOamszTkRZNE5qUTNNall4TnpjMlpUSXdNbVF5TURReE5tUTJaamMxTm1VM05ETmhNakFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpjNUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pRVkNCMGIydGxibk1nZDJsMGFHUnlZWGR1SUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsQlVJSFJ2YTJWdWN5QjNhWFJvWkhKaGQyNGdjM1ZqWTJWemMyWjFiR3g1SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmwwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMbU52Ym5SeVlXTjBMbGxVUVhWMGIwTnZiblpsY25SbGNpNW5aWFJmWVdsZmNtVmpiMjF0Wlc1a1lYUnBiMjRvZVhSZllXMXZkVzUwT2lCMWFXNTBOalFzSUdOMWNuSmxiblJmY0hKcFkyVTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbWRsZEY5aGFWOXlaV052YlcxbGJtUmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU9UVXRNamsyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmWVdsZmNtVmpiMjF0Wlc1a1lYUnBiMjRvYzJWc1ppd2dlWFJmWVcxdmRXNTBPaUJWU1c1ME5qUXNJR04xY25KbGJuUmZjSEpwWTJVNklGVkpiblEyTkNrZ0xUNGdZWEpqTkM1VWRYQnNaVnRoY21NMExsVkpiblEyTkN3Z1lYSmpOQzVUZEhKcGJtZGRPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRveU9UZ0tJQ0FnSUM4dklHbG1JSGwwWDJGdGIzVnVkQ0E5UFNCVlNXNTBOalFvTUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p1ZWlCblpYUmZZV2xmY21WamIyMXRaVzVrWVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVhSZllYVjBiMTlqYjI1MlpYSjBaWEl2WTI5dWRISmhZM1F1Y0hrNk1qazVDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29ZWEpqTkM1VlNXNTBOalFvTUNrc0lHRnlZelF1VTNSeWFXNW5LQ0pPYnlCWlZDQjBiMnRsYm5NZ2RHOGdZMjl1ZG1WeWRDSXBLU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREJoTURBeE56UmxObVl5TURVNU5UUXlNRGMwTm1ZMllqWTFObVUzTXpJd056UTJaakl3TmpNMlpqWmxOelkyTlRjeU56UUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFgyRnBYM0psWTI5dGJXVnVaR0YwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRvek1ERUtJQ0FnSUM4dklIVnpaWEpmZEdoeVpYTm9iMnhrSUQwZ2MyVnNaaTUwYUhKbGMyaHZiR1JmY0hKcFkyVmJWSGh1TG5ObGJtUmxjbDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGFISmxjMmh2YkdSZmNISnBZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHaHlaWE5vYjJ4a1gzQnlhV05sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pNd013b2dJQ0FnTHk4Z2FXWWdZM1Z5Y21WdWRGOXdjbWxqWlNBK1BTQjFjMlZ5WDNSb2NtVnphRzlzWkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQRDBLSUNBZ0lHSjZJR2RsZEY5aGFWOXlaV052YlcxbGJtUmhkR2x2Ymw5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qTXdOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LR0Z5WXpRdVZVbHVkRFkwS0RFcExDQmhjbU0wTGxOMGNtbHVaeWdpVW1WamIyMXRaVzVrSUdOdmJuWmxjbk5wYjI0Z0xTQjBhSEpsYzJodmJHUWdjbVZoWTJobFpDSXBLU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ERXdNREJoTURBeU9EVXlOalUyTXpabU5tUTJaRFkxTm1VMk5ESXdOak0yWmpabE56WTJOVGN5TnpNMk9UWm1ObVV5TURKa01qQTNORFk0TnpJMk5UY3pOamcyWmpaak5qUXlNRGN5TmpVMk1UWXpOamcyTlRZMENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWRsZEY5aGFWOXlaV052YlcxbGJtUmhkR2x2Ymw5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNRFlLSUNBZ0lDOHZJSEpsYldGcGJtbHVaMTkxY0hOcFpHVWdQU0FvS0hWelpYSmZkR2h5WlhOb2IyeGtJQzBnWTNWeWNtVnVkRjl3Y21salpTa2dLaUJWU1c1ME5qUW9NVEF3S1NrZ0x5OGdZM1Z5Y21WdWRGOXdjbWxqWlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0xRb2dJQ0FnY0hWemFHbHVkQ0F4TURBZ0x5OGdNVEF3Q2lBZ0lDQXFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTlqYjI1MGNtRmpkQzV3ZVRvek1EY0tJQ0FnSUM4dklHbG1JSEpsYldGcGJtbHVaMTkxY0hOcFpHVWdQQ0JWU1c1ME5qUW9OU2s2SUNBaklFeGxjM01nZEdoaGJpQTFKU0IwYnlCMGFISmxjMmh2YkdRS0lDQWdJSEIxYzJocGJuUWdOU0F2THlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUJuWlhSZllXbGZjbVZqYjIxdFpXNWtZWFJwYjI1ZlpXeHpaVjlpYjJSNVFEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNRGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2hoY21NMExsVkpiblEyTkNneEtTd2dZWEpqTkM1VGRISnBibWNvSWxKbFkyOXRiV1Z1WkNCamIyNTJaWEp6YVc5dUlDMGdZMnh2YzJVZ2RHOGdkR2h5WlhOb2IyeGtJaWtwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNVEF3TUdFd01ESTVOVEkyTlRZek5tWTJaRFprTmpVMlpUWTBNakEyTXpabU5tVTNOalkxTnpJM016WTVObVkyWlRJd01tUXlNRFl6Tm1NMlpqY3pOalV5TURjME5tWXlNRGMwTmpnM01qWTFOek0yT0RabU5tTTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwblpYUmZZV2xmY21WamIyMXRaVzVrWVhScGIyNWZaV3h6WlY5aWIyUjVRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpFd0NpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb1lYSmpOQzVWU1c1ME5qUW9NQ2tzSUdGeVl6UXVVM1J5YVc1bktDSkliMnhrSUZsVUlIUnZhMlZ1Y3lBdElIUm9jbVZ6YUc5c1pDQnViM1FnY21WaFkyaGxaQ0lwS1NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURCaE1EQXlOalE0Tm1ZMll6WTBNakExT1RVME1qQTNORFptTm1JMk5UWmxOek15TURKa01qQTNORFk0TnpJMk5UY3pOamcyWmpaak5qUXlNRFpsTm1ZM05ESXdOekkyTlRZeE5qTTJPRFkxTmpRS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU1ZEY5aGRYUnZYMk52Ym5abGNuUmxjaTVqYjI1MGNtRmpkQzVaVkVGMWRHOURiMjUyWlhKMFpYSXVkWEJrWVhSbFgyRmtaSEpsYzNObGN5aHZjbUZqYkdWZllXUmtjbVZ6Y3pvZ1lubDBaWE1zSUhSdmEyVnVhWHBoZEdsdmJsOWhaR1J5WlhOek9pQmllWFJsY3l3Z1lXMXRYMkZrWkhKbGMzTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkWEJrWVhSbFgyRmtaSEpsYzNObGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNVEl0TXpFNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCMWNHUmhkR1ZmWVdSa2NtVnpjMlZ6S0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ2IzSmhZMnhsWDJGa1pISmxjM002SUVKNWRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUhSdmEyVnVhWHBoZEdsdmJsOWhaR1J5WlhOek9pQkNlWFJsY3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzFmWVdSa2NtVnpjem9nUW5sMFpYTXNDaUFnSUNBdkx5QXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qTXlNQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJazl1YkhrZ1lXUnRhVzRnWTJGdUlIVndaR0YwWlNCaFpHUnlaWE56WlhNaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNGdZMkZ1SUhWd1pHRjBaU0JoWkdSeVpYTnpaWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVkRjloZFhSdlgyTnZiblpsY25SbGNpOWpiMjUwY21GamRDNXdlVG96TWpJS0lDQWdJQzh2SUhObGJHWXViM0poWTJ4bFgyRmtaSEpsYzNNdWRtRnNkV1VnUFNCdmNtRmpiR1ZmWVdSa2NtVnpjd29nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbTl5WVdOc1pWOWhaR1J5WlhOeklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNsMFgyRjFkRzlmWTI5dWRtVnlkR1Z5TDJOdmJuUnlZV04wTG5CNU9qTXlNd29nSUNBZ0x5OGdjMlZzWmk1MGIydGxibWw2WVhScGIyNWZZV1JrY21WemN5NTJZV3gxWlNBOUlIUnZhMlZ1YVhwaGRHbHZibDloWkdSeVpYTnpDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlkRzlyWlc1cGVtRjBhVzl1WDJGa1pISmxjM01pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlWFJmWVhWMGIxOWpiMjUyWlhKMFpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpJMENpQWdJQ0F2THlCelpXeG1MbUZ0YlY5aFpHUnlaWE56TG5aaGJIVmxJRDBnWVcxdFgyRmtaSEpsYzNNS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKaGJXMWZZV1JrY21WemN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWRGOWhkWFJ2WDJOdmJuWmxjblJsY2k5amIyNTBjbUZqZEM1d2VUb3pNallLSUNBZ0lDOHZJR3h2WnloaUlrTnZiblJ5WVdOMElHRmtaSEpsYzNObGN5QjFjR1JoZEdWa0lpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUXpObVkyWlRjME56STJNVFl6TnpReU1EWXhOalEyTkRjeU5qVTNNemN6TmpVM016SXdOelUzTURZME5qRTNORFkxTmpRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2wwWDJGMWRHOWZZMjl1ZG1WeWRHVnlMMk52Ym5SeVlXTjBMbkI1T2pNeU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpUTI5dWRISmhZM1FnWVdSa2NtVnpjMlZ6SUhWd1pHRjBaV1FnYzNWalkyVnpjMloxYkd4NUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVEyOXVkSEpoWTNRZ1lXUmtjbVZ6YzJWeklIVndaR0YwWldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFHUVRpWVJCQlVmZkhVT1kyOXVkbVZ5YzJsdmJsOW1aV1VLZVhSZlltRnNZVzVqWlFWaFpHMXBiZ2xwYzE5d1lYVnpaV1FTWTI5dWRtVnljMmx2Ymw5bGJtRmliR1ZrRDNSb2NtVnphRzlzWkY5d2NtbGpaUk5qYjI1MlpYSnphVzl1WDJWNFpXTjFkR1ZrQ25CMFgySmhiR0Z1WTJVUmRHOTBZV3hmWTI5dWRtVnljMmx2Ym5NTmRYTmxjbDl0WVhSMWNtbDBlUTltWldWZlpHVnViMjFwYm1GMGIzSU9iM0poWTJ4bFgyRmtaSEpsYzNNVWRHOXJaVzVwZW1GMGFXOXVYMkZrWkhKbGMzTUxZVzF0WDJGa1pISmxjM01RUTI5dWRtVnlkR1Z5SUhCaGRYTmxaQkpEYjI1MlpYSjBaWElnZFc1d1lYVnpaV1F4R0VBQUZvQU1iV0Y0WDNOc2FYQndZV2RsZ2ZRRFp5Y0xKR2N4RzBFQ2FJSVNCR3BwMzEwRWE1cXZOQVE1Nkl4WkJHclh3d0lFcGxmaStRUm1kdGxSQlA1TzM5a0VhOUZDakFSVSsrdzFCRm1Sb3dFRXh6RFNMQVFhOERjQUJFVW1WTFFFMHlnZ1F3UVJZNDdDQk1BZ1hhMEVhZjhCVUFSeFlUVVBOaG9BamhJQnVRR1ZBWGtCVXdFOEFTd0JIQUVNQVBnQTNBREVBS2dBa0FCNEFHQUFSQUFzQUFJaVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ05YQWdDSUIzUkpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGNGdHV0NoTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFYZlNSVVdWd1lDVEZBb1RGQ3dJME14R1JSRU1SaEVpQVY5U1JVV1Z3WUNURkFvVEZDd0kwTXhHUlJFTVJoRWlBVlRTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFaUFVcFNSVVdWd1lDVEZBb1RGQ3dJME14R1JSRU1SaEVOaG9CRjRnRW5Fa1ZGbGNHQWt4UUtFeFFzQ05ETVJrVVJERVlSSWdFUzBrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmVJQStGSkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFUTJHZ0VYaUFPTUtFeFFzQ05ETVJrVVJERVlSSWdEWlNoTVVMQWpRekVaRkVReEdFU0lBMFFvVEZDd0kwTXhHUlJFTVJoRWlBTUpLRXhRc0NORE1Sa1VSREVZUkRZYUFWY0NBSWdDdlJZb1RGQ3dJME14R1JSRU1SaEVOaG9CVndJQU5ob0NGellhQXhlSUFkbEpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVEyR2dFWGlBRmZTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQkZ6WWFBaGMyR2dNWGlBQ3pTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQlZ3SUFOaG9DVndJQU5ob0RWd0lBaUFBWlNSVVdWd1lDVEZBb1RGQ3dJME14R1VEK0dERVlGRVFqUTRvREFURUFNZ2tTUkNzeEFHY25ESXY5WnljTmkvNW5KdzZMLzJjcGdSNW5Kd1FpWnljSkltZUFHMWxVUVhWMGIwTnZiblpsY25SbGNpQnBibWwwYVdGc2FYcGxaTENBSjBGMWRHOGdZMjl1ZG1WeWRHVnlJR2x1YVhScFlXeHBlbVZrSUhOMVkyTmxjM05tZFd4c2VZbUtBd0dML2tTTC96SUhEVVF4QUNjRmkvMW1NUUFuQm92K1pqRUFKd3FMLzJZeEFDY0hJbWFML1JhQUlVTnZiblpsY25OcGIyNGdZMjl1Wm1sbmRYSmxaQ0F0SUVWdVlXSnNaV1E2SUV4UWdBd2dWR2h5WlhOb2IyeGtPaUJRaS80V1VMQ0FJa052Ym5abGNuTnBiMjRnWTI5dVptbG5kWEpsWkNCemRXTmpaWE56Wm5Wc2JIbUppZ0VCaS85RU1RQWlLbU5FaS84SU1RQXFUd0ptaS84V2dCNVpWQ0IwYjJ0bGJuTWdaR1Z3YjNOcGRHVmtJQzBnUVcxdmRXNTBPaUJNVUxDQUlGbFVJSFJ2YTJWdWN5QmtaWEJ2YzJsMFpXUWdjM1ZqWTJWemMyWjFiR3g1aVlvREFTSW5CR1ZFRkVReUI0di9Ea1F4QUNJbkJXTkVJeEpFTVFBaUp3ZGpSQlJFTVFBaUp3WmpSRVF4QUNJcVkwUkpSQ0lwWlVSTEFRc2lKd3RsUkFwTEFVd0pnZDVOQ3lRS1NZditEMFF4QUNvaVpqRUFJaWNJWTBSTEFRZ3hBQ2NJVHdKbU1RQW5CeU5tSWljSlpVUWpDQ2NKVEdkTUZvQWFRMjl1ZG1WeWMybHZiaUJsZUdWamRYUmxaQ0F0SUZsVU9pQk1VSUFGSUZCVU9pQlFUQlpRc0lBZ1EyOXVkbVZ5YzJsdmJpQmxlR1ZqZFhSbFpDQnpkV05qWlhOelpuVnNiSG1KaWdFQk1RQWlKd1ZqUkVBQUFpS0pNUUFpSndkalJDTVNRUUFDSW9reEFDSXFZMFJBQUFJaWlURUFJaWNHWTBSQUFBSWlpU09KTVFBaUp3VmpSQll4QUNJbkJtTkVGakVBSWljS1kwUVdNUUFpSndkalJCWlBBMDhEVUU4Q1VFeFFpVEVBSWlwalJCWXhBQ0luQ0dORUZsQ0pJaWxsUkJZaUp3bGxSQllpSndSbFJCWk9BbEJNVUltS0FRR0wvMEFBRTRBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlraUtXVkVpLzhMSWljTFpVUUtpLzlMQVFsSmdUSUxKQW9KRmt3V1VJbUtBUUdML3pJSERVUXhBQ2NLaS85bWkvOFdnQmhOWVhSMWNtbDBlU0JoWkdSbFpDQXRJRlpoYkhWbE9pQk1VTENBRzAxaGRIVnlhWFI1SUdGa1pHVmtJSE4xWTJObGMzTm1kV3hzZVlreEFDY0tJbWFBRUUxaGRIVnlhWFI1SUhKbGJXOTJaV1N3Z0IxTllYUjFjbWwwZVNCeVpXMXZkbVZrSUhOMVkyTmxjM05tZFd4c2VZbUtBUUV4QUNJclpVUVNSSXYvZ2VnSERrUWlLV1ZFS1l2L1p4YUFIa052Ym5abGNuTnBiMjRnWm1WbElIVndaR0YwWldRZ0xTQlBiR1E2SUV4UWdBWWdUbVYzT2lCUWkvOFdVTENBSTBOdmJuWmxjbk5wYjI0Z1ptVmxJSFZ3WkdGMFpXUWdjM1ZqWTJWemMyWjFiR3g1aVRFQUlpdGxSQkpFSndRalp5Y1BzQ2NQaVRFQUlpdGxSQkpFSndRaVp5Y1FzQ2NRaVRFQUp3VWlab0FkUTI5dWRtVnljMmx2YmlCbGJXVnlaMlZ1WTNrZ1pHbHpZV0pzWldTd2dDRkRiMjUyWlhKemFXOXVJR1JwYzJGaWJHVmtJR1p2Y2lCbGJXVnlaMlZ1WTNtSmlnRUJpLzlFTVFBaUp3aGpSRW1ML3c5RWkvOEpNUUFuQ0U4Q1pvdi9Gb0FlVUZRZ2RHOXJaVzV6SUhkcGRHaGtjbUYzYmlBdElFRnRiM1Z1ZERvZ1RGQ3dnQ0JRVkNCMGIydGxibk1nZDJsMGFHUnlZWGR1SUhOMVkyTmxjM05tZFd4c2VZbUtBZ0dBQUl2K1FBQW5nQ01BQUFBQUFBQUFBQUFLQUJkT2J5QlpWQ0IwYjJ0bGJuTWdkRzhnWTI5dWRtVnlkRXlKTVFBaUp3WmpURWxPQW93QVJJdi9Ea0VBT0lBMEFBQUFBQUFBQUFFQUNnQW9VbVZqYjIxdFpXNWtJR052Ym5abGNuTnBiMjRnTFNCMGFISmxjMmh2YkdRZ2NtVmhZMmhsWkV5Sml3Q0wvd21CWkF1TC93cUJCUXhCQURtQU5RQUFBQUFBQUFBQkFBb0FLVkpsWTI5dGJXVnVaQ0JqYjI1MlpYSnphVzl1SUMwZ1kyeHZjMlVnZEc4Z2RHaHlaWE5vYjJ4a1RJbUFNZ0FBQUFBQUFBQUFBQW9BSmtodmJHUWdXVlFnZEc5clpXNXpJQzBnZEdoeVpYTm9iMnhrSUc1dmRDQnlaV0ZqYUdWa1RJbUtBd0V4QUNJclpVUVNSQ2NNaS8xbkp3MkwvbWNuRG92L1o0QWFRMjl1ZEhKaFkzUWdZV1JrY21WemMyVnpJSFZ3WkdGMFpXU3dnQ2REYjI1MGNtRmpkQ0JoWkdSeVpYTnpaWE1nZFhCa1lYUmxaQ0J6ZFdOalpYTnpablZzYkhtSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
