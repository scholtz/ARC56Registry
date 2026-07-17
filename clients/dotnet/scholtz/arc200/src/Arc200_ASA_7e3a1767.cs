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

namespace Arc56.Generated.scholtz.arc200.Arc200_ASA_7e3a1767
{


    //
    // Smart Contract Token Base Interface
    //
    public class Arc200_ASAProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc200_ASAProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ApprovalStruct : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 ApprovalAmount { get; set; }

                public Algorand.Address Owner { get; set; }

                public Algorand.Address Spender { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApprovalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vApprovalAmount.From(ApprovalAmount);
                    ret.AddRange(vApprovalAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSpender.From(Spender);
                    ret.AddRange(vSpender.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ApprovalStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ApprovalStruct();
                    uint count = 0;
                    var vApprovalAmount = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vApprovalAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ApprovalAmount = vApprovalAmount;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ApprovalStruct);
                }
                public bool Equals(ApprovalStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ApprovalStruct left, ApprovalStruct right)
                {
                    return EqualityComparer<ApprovalStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(ApprovalStruct left, ApprovalStruct right)
                {
                    return !(left == right);
                }

            }

            public class Arc200ExchangeInfo : AVMObjectType
            {
                public ulong ExchangeAsset { get; set; }

                public Algorand.Address Sink { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExchangeAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExchangeAsset.From(ExchangeAsset);
                    ret.AddRange(vExchangeAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSink = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSink.From(Sink);
                    ret.AddRange(vSink.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc200ExchangeInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc200ExchangeInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExchangeAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExchangeAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExchangeAsset = vExchangeAsset.ToValue();
                    if (valueExchangeAsset is ulong vExchangeAssetValue) { ret.ExchangeAsset = vExchangeAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSink = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSink.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSink = vSink.ToValue();
                    if (valueSink is Algorand.Address vSinkValue) { ret.Sink = vSinkValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc200ExchangeInfo);
                }
                public bool Equals(Arc200ExchangeInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc200ExchangeInfo left, Arc200ExchangeInfo right)
                {
                    return EqualityComparer<Arc200ExchangeInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc200ExchangeInfo left, Arc200ExchangeInfo right)
                {
                    return !(left == right);
                }

            }

            public class AsaProps : AVMObjectType
            {
                public byte[] MetadataHash { get; set; }

                public byte[] Url { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vMetadataHash.From(MetadataHash);
                    ret.AddRange(vMetadataHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vUrl.From(Url);
                    ret.AddRange(vUrl.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AsaProps Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AsaProps();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vMetadataHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMetadataHash = vMetadataHash.ToValue();
                    if (valueMetadataHash is byte[] vMetadataHashValue) { ret.MetadataHash = vMetadataHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vUrl.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUrl = vUrl.ToValue();
                    if (valueUrl is byte[] vUrlValue) { ret.Url = vUrlValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AsaProps);
                }
                public bool Equals(AsaProps? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AsaProps left, AsaProps right)
                {
                    return EqualityComparer<AsaProps>.Default.Equals(left, right);
                }
                public static bool operator !=(AsaProps left, AsaProps right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class Arc200TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 121, 131, 195, 92 };
                public const string Signature = "arc200_Transfer(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address From { get; set; }
                public Algorand.Address To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static Arc200TransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc200TransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is Algorand.Address vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is Algorand.Address vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class Arc200ApprovalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 25, 105, 248, 101 };
                public const string Signature = "arc200_Approval(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Owner { get; set; }
                public Algorand.Address Spender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static Arc200ApprovalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc200ApprovalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is Algorand.Address vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="decimals"> </param>
        /// <param name="totalSupply"> </param>
        /// <param name="asset"> asaProps</param>
        public async Task<bool> Bootstrap(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Structs.AsaProps asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 217, 117, 31 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply, asset }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(byte[] name, byte[] symbol, byte decimals, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalSupply, Structs.AsaProps asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 217, 117, 31 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); symbolAbi.From(symbol);
            var decimalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); decimalsAbi.From(decimals);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, decimalsAbi, totalSupply, asset }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the name of the token
        ///</summary>
        public async Task<byte[]> Arc200Name(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 125, 19, 236 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc200Name_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 125, 19, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the symbol of the token
        ///</summary>
        public async Task<byte[]> Arc200Symbol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 174, 26, 37 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(8, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc200Symbol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 174, 26, 37 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the decimals of the token
        ///</summary>
        public async Task<byte> Arc200Decimals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 236, 19, 213 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> Arc200Decimals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 236, 19, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the total supply of the token
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200TotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 153, 96, 65 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200TotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 153, 96, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current balance of the owner of the token
        ///</summary>
        /// <param name="owner">The address of the owner of the token </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200BalanceOf(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 229, 115, 196 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200BalanceOf_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 229, 115, 196 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers tokens
        ///</summary>
        /// <param name="to">The destination of the transfer </param>
        /// <param name="value">Amount of tokens to transfer </param>
        public async Task<bool> Arc200Transfer(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 112, 37, 185 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200Transfer_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 112, 37, 185 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers tokens from source to destination as approved spender
        ///</summary>
        /// <param name="from">The source of the transfer </param>
        /// <param name="to">The destination of the transfer </param>
        /// <param name="value">Amount of tokens to transfer </param>
        public async Task<bool> Arc200TransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 150, 143, 143 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200TransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 150, 143, 143 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approve spender for a token
        ///</summary>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        /// <param name="value">Amount of tokens to be taken by spender </param>
        public async Task<bool> Arc200Approve(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 66, 33, 37 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200Approve_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 66, 33, 37 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increases the allowance of spender by value, avoiding the classic approve() front-running
        ///race condition where an in-flight transferFrom can consume both the old and new allowance.
        ///</summary>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        /// <param name="value">Amount to add to the current allowance </param>
        public async Task<bool> Arc200IncreaseAllowance(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 240, 38, 205 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200IncreaseAllowance_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 240, 38, 205 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Decreases the allowance of spender by value, avoiding the classic approve() front-running
        ///race condition where an in-flight transferFrom can consume both the old and new allowance.
        ///</summary>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        /// <param name="value">Amount to subtract from the current allowance </param>
        public async Task<bool> Arc200DecreaseAllowance(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 190, 243, 205 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc200DecreaseAllowance_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 190, 243, 205 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///arc200_exchange() → (uint64 exchange_asset, address sink)
        ///Returns configuration parameters used by the exchange mechanism:
        ///exchange_asset: The ASA ID that the ARC200 token can be exchanged with.
        ///
        ///sink: The address that holds ARC200 tokens for redemption operations.
        ///
        ///This method MUST NOT mutate state.
        ///
        ///https://docs.google.com/document/d/1Uy9kbWF6yfM7W_VbBp1W5c2VqVdcoCj_hyoXUf1FIV0/edit?tab=t.0#heading=h.socgebj776o0
        ///</summary>
        public async Task<Structs.Arc200ExchangeInfo> Arc200Exchange(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 155, 84, 151 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Arc200ExchangeInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Arc200Exchange_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 155, 84, 151 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Exchanges ASA tokens for ARC200 tokens.
        ///Requirements:
        ///The user MUST include a valid ASA transfer to the contract in the same transaction group.
        ///
        ///The ASA ID MUST match the configured exchange_asset.
        ///
        ///The amount transferred MUST be equal to or greater than the amount requested.
        ///
        ///The contract MUST transfer ARC200 tokens to the user from the sink address.
        ///
        ///No ARC200 tokens may be minted or burned during the exchange.
        ///
        ///https://docs.google.com/document/d/1Uy9kbWF6yfM7W_VbBp1W5c2VqVdcoCj_hyoXUf1FIV0/edit?tab=t.0#heading=h.socgebj776o0
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Arc200Redeem(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 212, 28, 223 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc200Redeem_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 212, 28, 223 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///wnnt200 for arc200_redeem
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Deposit(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 35, 38, 124 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Deposit_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 35, 38, 124 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///arc200_swapBack(uint64 amount) → void
        ///
        ///Exchanges ARC200 tokens back into ASA tokens.
        ///Requirements:
        ///The user MUST transfer ARC200 tokens to the configured sink address.
        ///
        ///Upon receiving the ARC200 tokens, the contract MUST transfer the equivalent amount of ASA tokens to the user.
        ///
        ///The ASA MUST be transferred from the application's own account.
        ///
        ///No ARC200 tokens may be minted or burned during the exchange.
        ///
        ///https://docs.google.com/document/d/1Uy9kbWF6yfM7W_VbBp1W5c2VqVdcoCj_hyoXUf1FIV0/edit?tab=t.0#heading=h.socgebj776o0
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Arc200SwapBack(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 2, 218, 175 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc200SwapBack_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 2, 218, 175 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///wnnt200 for arc200_swapBack
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 207, 152, 206 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 207, 152, 206 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///wnnt200 method to create balance box for an address.
        ///
        ///The caller MUST cover the box's minimum balance requirement with a payment transaction
        ///immediately preceding this call in the group, to prevent unauthenticated callers from
        ///forcing the app account to fund unlimited boxes for arbitrary addresses at no cost to
        ///themselves.
        ///</summary>
        /// <param name="owner">Owner </param>
        public async Task<byte> CreateBalanceBox(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 89, 228, 117 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> CreateBalanceBox_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 89, 228, 117 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current allowance of the spender of the tokens of the owner
        ///</summary>
        /// <param name="owner">Owner's account </param>
        /// <param name="spender">Who is allowed to take tokens on owner's behalf </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc200Allowance(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 179, 25, 243 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc200Allowance_Transactions(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 179, 25, 243 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjMjAwX0FTQSIsImRlc2MiOiJTbWFydCBDb250cmFjdCBUb2tlbiBCYXNlIEludGVyZmFjZSIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBcHByb3ZhbFN0cnVjdCI6W3sibmFtZSI6ImFwcHJvdmFsQW1vdW50IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic3BlbmRlciIsInR5cGUiOiJhZGRyZXNzIn1dLCJhcmMyMDBfZXhjaGFuZ2VJbmZvIjpbeyJuYW1lIjoiZXhjaGFuZ2VfYXNzZXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2luayIsInR5cGUiOiJhZGRyZXNzIn1dLCJhc2FQcm9wcyI6W3sibmFtZSI6Im1ldGFkYXRhSGFzaCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InVybCIsInR5cGUiOiJieXRlW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWNpbWFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYnl0ZVszMl0sYnl0ZVtdKSIsInN0cnVjdCI6ImFzYVByb3BzIiwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfbmFtZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBuYW1lIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBuYW1lIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3N5bWJvbCIsImRlc2MiOiJSZXR1cm5zIHRoZSBzeW1ib2wgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbOF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3ltYm9sIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2RlY2ltYWxzIiwiZGVzYyI6IlJldHVybnMgdGhlIGRlY2ltYWxzIG9mIHRoZSB0b2tlbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBkZWNpbWFscyBvZiB0aGUgdG9rZW4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90b3RhbFN1cHBseSIsImRlc2MiOiJSZXR1cm5zIHRoZSB0b3RhbCBzdXBwbHkgb2YgdGhlIHRva2VuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgdG90YWwgc3VwcGx5IG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2JhbGFuY2VPZiIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGJhbGFuY2Ugb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIG93bmVyIG9mIHRoZSB0b2tlbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGN1cnJlbnQgYmFsYW5jZSBvZiB0aGUgaG9sZGVyIG9mIHRoZSB0b2tlbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3RyYW5zZmVyIiwiZGVzYyI6IlRyYW5zZmVycyB0b2tlbnMiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6IlRoZSBkZXN0aW5hdGlvbiBvZiB0aGUgdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgb2YgdG9rZW5zIHRvIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImFyYzIwMF9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF90cmFuc2ZlckZyb20iLCJkZXNjIjoiVHJhbnNmZXJzIHRva2VucyBmcm9tIHNvdXJjZSB0byBkZXN0aW5hdGlvbiBhcyBhcHByb3ZlZCBzcGVuZGVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6IlRoZSBzb3VyY2Ugb2YgdGhlIHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjoiVGhlIGRlc3RpbmF0aW9uIG9mIHRoZSB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6IkFtb3VudCBvZiB0b2tlbnMgdG8gdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX0FwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfYXBwcm92ZSIsImRlc2MiOiJBcHByb3ZlIHNwZW5kZXIgZm9yIGEgdG9rZW4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjoiV2hvIGlzIGFsbG93ZWQgdG8gdGFrZSB0b2tlbnMgb24gb3duZXIncyBiZWhhbGYiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgb2YgdG9rZW5zIHRvIGJlIHRha2VuIGJ5IHNwZW5kZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX0FwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX2luY3JlYXNlQWxsb3dhbmNlIiwiZGVzYyI6IkluY3JlYXNlcyB0aGUgYWxsb3dhbmNlIG9mIHNwZW5kZXIgYnkgdmFsdWUsIGF2b2lkaW5nIHRoZSBjbGFzc2ljIGFwcHJvdmUoKSBmcm9udC1ydW5uaW5nXG5yYWNlIGNvbmRpdGlvbiB3aGVyZSBhbiBpbi1mbGlnaHQgdHJhbnNmZXJGcm9tIGNhbiBjb25zdW1lIGJvdGggdGhlIG9sZCBhbmQgbmV3IGFsbG93YW5jZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjoiV2hvIGlzIGFsbG93ZWQgdG8gdGFrZSB0b2tlbnMgb24gb3duZXIncyBiZWhhbGYiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJBbW91bnQgdG8gYWRkIHRvIHRoZSBjdXJyZW50IGFsbG93YW5jZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfZGVjcmVhc2VBbGxvd2FuY2UiLCJkZXNjIjoiRGVjcmVhc2VzIHRoZSBhbGxvd2FuY2Ugb2Ygc3BlbmRlciBieSB2YWx1ZSwgYXZvaWRpbmcgdGhlIGNsYXNzaWMgYXBwcm92ZSgpIGZyb250LXJ1bm5pbmdcbnJhY2UgY29uZGl0aW9uIHdoZXJlIGFuIGluLWZsaWdodCB0cmFuc2ZlckZyb20gY2FuIGNvbnN1bWUgYm90aCB0aGUgb2xkIGFuZCBuZXcgYWxsb3dhbmNlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOiJXaG8gaXMgYWxsb3dlZCB0byB0YWtlIHRva2VucyBvbiBvd25lcidzIGJlaGFsZiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6IkFtb3VudCB0byBzdWJ0cmFjdCBmcm9tIHRoZSBjdXJyZW50IGFsbG93YW5jZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfZXhjaGFuZ2UiLCJkZXNjIjoiYXJjMjAwX2V4Y2hhbmdlKCkg4oaSICh1aW50NjQgZXhjaGFuZ2VfYXNzZXQsIGFkZHJlc3Mgc2luaylcblJldHVybnMgY29uZmlndXJhdGlvbiBwYXJhbWV0ZXJzIHVzZWQgYnkgdGhlIGV4Y2hhbmdlIG1lY2hhbmlzbTpcbmV4Y2hhbmdlX2Fzc2V0OiBUaGUgQVNBIElEIHRoYXQgdGhlIEFSQzIwMCB0b2tlbiBjYW4gYmUgZXhjaGFuZ2VkIHdpdGguXG5cbnNpbms6IFRoZSBhZGRyZXNzIHRoYXQgaG9sZHMgQVJDMjAwIHRva2VucyBmb3IgcmVkZW1wdGlvbiBvcGVyYXRpb25zLlxuXG5UaGlzIG1ldGhvZCBNVVNUIE5PVCBtdXRhdGUgc3RhdGUuXG5cbmh0dHBzOi8vZG9jcy5nb29nbGUuY29tL2RvY3VtZW50L2QvMVV5OWtiV0Y2eWZNN1dfVmJCcDFXNWMyVnFWZGNvQ2pfaHlvWFVmMUZJVjAvZWRpdD90YWI9dC4wI2hlYWRpbmc9aC5zb2NnZWJqNzc2bzAiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6ImFyYzIwMF9leGNoYW5nZUluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzIwMF9yZWRlZW0iLCJkZXNjIjoiRXhjaGFuZ2VzIEFTQSB0b2tlbnMgZm9yIEFSQzIwMCB0b2tlbnMuXG5SZXF1aXJlbWVudHM6XG5UaGUgdXNlciBNVVNUIGluY2x1ZGUgYSB2YWxpZCBBU0EgdHJhbnNmZXIgdG8gdGhlIGNvbnRyYWN0IGluIHRoZSBzYW1lIHRyYW5zYWN0aW9uIGdyb3VwLlxuXG5UaGUgQVNBIElEIE1VU1QgbWF0Y2ggdGhlIGNvbmZpZ3VyZWQgZXhjaGFuZ2VfYXNzZXQuXG5cblRoZSBhbW91bnQgdHJhbnNmZXJyZWQgTVVTVCBiZSBlcXVhbCB0byBvciBncmVhdGVyIHRoYW4gdGhlIGFtb3VudCByZXF1ZXN0ZWQuXG5cblRoZSBjb250cmFjdCBNVVNUIHRyYW5zZmVyIEFSQzIwMCB0b2tlbnMgdG8gdGhlIHVzZXIgZnJvbSB0aGUgc2luayBhZGRyZXNzLlxuXG5ObyBBUkMyMDAgdG9rZW5zIG1heSBiZSBtaW50ZWQgb3IgYnVybmVkIGR1cmluZyB0aGUgZXhjaGFuZ2UuXG5cbmh0dHBzOi8vZG9jcy5nb29nbGUuY29tL2RvY3VtZW50L2QvMVV5OWtiV0Y2eWZNN1dfVmJCcDFXNWMyVnFWZGNvQ2pfaHlvWFVmMUZJVjAvZWRpdD90YWI9dC4wI2hlYWRpbmc9aC5zb2NnZWJqNzc2bzAiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6IndubnQyMDAgZm9yIGFyYzIwMF9yZWRlZW0iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6IiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX1RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjMjAwX3N3YXBCYWNrIiwiZGVzYyI6ImFyYzIwMF9zd2FwQmFjayh1aW50NjQgYW1vdW50KSDihpIgdm9pZFxuXG5FeGNoYW5nZXMgQVJDMjAwIHRva2VucyBiYWNrIGludG8gQVNBIHRva2Vucy5cblJlcXVpcmVtZW50czpcblRoZSB1c2VyIE1VU1QgdHJhbnNmZXIgQVJDMjAwIHRva2VucyB0byB0aGUgY29uZmlndXJlZCBzaW5rIGFkZHJlc3MuXG5cblVwb24gcmVjZWl2aW5nIHRoZSBBUkMyMDAgdG9rZW5zLCB0aGUgY29udHJhY3QgTVVTVCB0cmFuc2ZlciB0aGUgZXF1aXZhbGVudCBhbW91bnQgb2YgQVNBIHRva2VucyB0byB0aGUgdXNlci5cblxuVGhlIEFTQSBNVVNUIGJlIHRyYW5zZmVycmVkIGZyb20gdGhlIGFwcGxpY2F0aW9uJ3Mgb3duIGFjY291bnQuXG5cbk5vIEFSQzIwMCB0b2tlbnMgbWF5IGJlIG1pbnRlZCBvciBidXJuZWQgZHVyaW5nIHRoZSBleGNoYW5nZS5cblxuaHR0cHM6Ly9kb2NzLmdvb2dsZS5jb20vZG9jdW1lbnQvZC8xVXk5a2JXRjZ5Zk03V19WYkJwMVc1YzJWcVZkY29Dal9oeW9YVWYxRklWMC9lZGl0P3RhYj10LjAjaGVhZGluZz1oLnNvY2dlYmo3NzZvMCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOiJ3bm50MjAwIGZvciBhcmMyMDBfc3dhcEJhY2siLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6IiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjMjAwX1RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlQmFsYW5jZUJveCIsImRlc2MiOiJ3bm50MjAwIG1ldGhvZCB0byBjcmVhdGUgYmFsYW5jZSBib3ggZm9yIGFuIGFkZHJlc3MuXG5cblRoZSBjYWxsZXIgTVVTVCBjb3ZlciB0aGUgYm94J3MgbWluaW11bSBiYWxhbmNlIHJlcXVpcmVtZW50IHdpdGggYSBwYXltZW50IHRyYW5zYWN0aW9uXG5pbW1lZGlhdGVseSBwcmVjZWRpbmcgdGhpcyBjYWxsIGluIHRoZSBncm91cCwgdG8gcHJldmVudCB1bmF1dGhlbnRpY2F0ZWQgY2FsbGVycyBmcm9tXG5mb3JjaW5nIHRoZSBhcHAgYWNjb3VudCB0byBmdW5kIHVubGltaXRlZCBib3hlcyBmb3IgYXJiaXRyYXJ5IGFkZHJlc3NlcyBhdCBubyBjb3N0IHRvXG50aGVtc2VsdmVzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjoiT3duZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IjEgaWYgYm94IHdhcyBjcmVhdGVkLiAwIGlmIGJveCBleGlzdHMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmMyMDBfYWxsb3dhbmNlIiwiZGVzYyI6IlJldHVybnMgdGhlIGN1cnJlbnQgYWxsb3dhbmNlIG9mIHRoZSBzcGVuZGVyIG9mIHRoZSB0b2tlbnMgb2YgdGhlIG93bmVyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJPd25lcidzIGFjY291bnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6IldobyBpcyBhbGxvd2VkIHRvIHRha2UgdG9rZW5zIG9uIG93bmVyJ3MgYmVoYWxmIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgcmVtYWluaW5nIGFsbG93YW5jZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzA0XSwiZXJyb3JNZXNzYWdlIjoiQSB6ZXJvLXZhbHVlIGFwcHJvdmFsIGNhbm5vdCBiZSB1c2VkIHRvIGNyZWF0ZSBhIG5ldyBhcHByb3ZhbCBib3giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDcwXSwiZXJyb3JNZXNzYWdlIjoiQSB6ZXJvLXZhbHVlIHRyYW5zZmVyIGNhbm5vdCBiZSB1c2VkIHRvIGNyZWF0ZSBhIG5ldyBiYWxhbmNlIGJveCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNzRdLCJlcnJvck1lc3NhZ2UiOiJBU0EgSUQgbXVzdCBtYXRjaCBjb25maWd1cmVkIGV4Y2hhbmdlX2Fzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4Ml0sImVycm9yTWVzc2FnZSI6IkFTQSBtdXN0IGJlIHNlbnQgdG8gdGhlIHNpbmsgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExODldLCJlcnJvck1lc3NhZ2UiOiJBU0Egc2VuZGVyIG11c3QgbWF0Y2ggQVJDMjAwIHJlZGVlbWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxNSwxMjcxXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTFdLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgdHJhbnNmZXIgdG8gdGhlIHplcm8gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3MV0sImVycm9yTWVzc2FnZSI6IkRlY3JlYXNlIGV4Y2VlZHMgY3VycmVudCBhbGxvd2FuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM3XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGJhbGFuY2UgYXQgdGhlIHNlbmRlciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAxXSwiZXJyb3JNZXNzYWdlIjoiTGVuZ3RoIG11c3QgYmUgMzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MTddLCJlcnJvck1lc3NhZ2UiOiJNdXN0IGJlIHByZWNlZGVkIGJ5IGEgcGF5bWVudCBjb3ZlcmluZyB0aGUgYmFsYW5jZSBib3ggTUJSIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzMl0sImVycm9yTWVzc2FnZSI6Ik11c3QgYmUgcHJlY2VkZWQgYnkgYW4gQVNBIHRyYW5zZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1XSwiZXJyb3JNZXNzYWdlIjoiTmFtZSBvZiB0aGUgYXNzZXQgbXVzdCBiZSBsb25nZXIgb3IgZXF1YWwgdG8gMSBjaGFyYWN0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDhdLCJlcnJvck1lc3NhZ2UiOiJOYW1lIG9mIHRoZSBhc3NldCBtdXN0IGJlIHNob3J0ZXIgb3IgZXF1YWwgdG8gMzIgY2hhcmFjdGVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxM10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBkZXBsb3llciBvZiB0aGlzIHNtYXJ0IGNvbnRyYWN0IGNhbiBjYWxsIGJvb3RzdHJhcCBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDFdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgc2VudCB0byB0aGUgYXBwIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDldLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgY292ZXIgdGhlIGJhbGFuY2UgYm94IE1CUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzNF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgc2VuZGVyIG11c3QgbWF0Y2ggY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0Ml0sImVycm9yTWVzc2FnZSI6IlByZXZpb3VzIHR4biBtdXN0IGJlIEFTQSB0cmFuc2ZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxN10sImVycm9yTWVzc2FnZSI6IlN5bWJvbCBvZiB0aGUgYXNzZXQgbXVzdCBiZSBsb25nZXIgb3IgZXF1YWwgdG8gMSBjaGFyYWN0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjBdLCJlcnJvck1lc3NhZ2UiOiJTeW1ib2wgb2YgdGhlIGFzc2V0IG11c3QgYmUgc2hvcnRlciBvciBlcXVhbCB0byA4IGNoYXJhY3RlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTYzXSwiZXJyb3JNZXNzYWdlIjoiVGhlIGFtb3VudCB0cmFuc2ZlcnJlZCBNVVNUIGJlIGVxdWFsIHRvIG9yIGdyZWF0ZXIgdGhhbiB0aGUgYW1vdW50IHJlcXVlc3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyN10sImVycm9yTWVzc2FnZSI6IlRoaXMgbWV0aG9kIGNhbiBiZSBjYWxsZWQgb25seSBvbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDczLDQ5Myw1MTMsNTIzLDc5OCwxMTcxLDEyMjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjNdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgYXBwcm92YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjEsMjM1LDI4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOSwyNDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM3LDU1NCw1ODQsNTk0LDY3NCw3MDMsNzUwLDkwNCw5NzYsOTg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MCw1NjIsNjA1LDY4Miw3MTEsNzU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxNSw4MzgsODY1LDg3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFzYVByb3BzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgxLDUwMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKHVpbnQ4WzMyXSwobGVuK3VpbnQ4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODAsNjM4LDcyNyw3NzksODg3LDEwODAsMTEwMiwxMjA3XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDFdLCJlcnJvck1lc3NhZ2UiOiJ0b3RhbFN1cHBseSBtdXN0IGZpdCBpbiB1aW50NjQgdG8gYmUgcmVwcmVzZW50YWJsZSBhcyB0aGUgd3JhcHBlZCBBU0EgdG90YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUzXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyN10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNeklnTVNBd0lEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQWlZaUlnSW1GellTSWdJblFpSURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQXdlRGM1T0ROak16VmpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYSmpNakF3WDBGVFFTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TlFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNE9XUTVOelV4WmlBd2VEWTFOMlF4TTJWaklEQjRZalpoWlRGaE1qVWdNSGc0TkdWak1UTmtOU0F3ZUdWak9UazJNRFF4SURCNE9ESmxOVGN6WXpRZ01IaGtZVGN3TWpWaU9TQXdlRFJoT1RZNFpqaG1JREI0WWpVME1qSXhNalVnTUhnNU1HWXdNalpqWkNBd2VHSTRZbVZtTTJOa0lEQjROREE1WWpVME9UY2dNSGcyTW1RME1XTmtaaUF3ZURBeU1qTXlOamRqSURCNE4yTXdNbVJoWVdZZ01IZzJPR05tT1RoalpTQXdlR0V6TlRsbE5EYzFJREI0WW1KaU16RTVaak1nTHk4Z2JXVjBhRzlrSUNKaWIyOTBjM1J5WVhBb1lubDBaVnRkTEdKNWRHVmJYU3gxYVc1ME9DeDFhVzUwTWpVMkxDaGllWFJsV3pNeVhTeGllWFJsVzEwcEtXSnZiMndpTENCdFpYUm9iMlFnSW1GeVl6SXdNRjl1WVcxbEtDbGllWFJsV3pNeVhTSXNJRzFsZEdodlpDQWlZWEpqTWpBd1gzTjViV0p2YkNncFlubDBaVnM0WFNJc0lHMWxkR2h2WkNBaVlYSmpNakF3WDJSbFkybHRZV3h6S0NsMWFXNTBPQ0lzSUcxbGRHaHZaQ0FpWVhKak1qQXdYM1J2ZEdGc1UzVndjR3g1S0NsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmWW1Gc1lXNWpaVTltS0dGa1pISmxjM01wZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWVhKak1qQXdYM1J5WVc1elptVnlLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmZEhKaGJuTm1aWEpHY205dEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbUZ5WXpJd01GOWhjSEJ5YjNabEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsaWIyOXNJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZhVzVqY21WaGMyVkJiR3h2ZDJGdVkyVW9ZV1JrY21WemN5eDFhVzUwTWpVMktXSnZiMndpTENCdFpYUm9iMlFnSW1GeVl6SXdNRjlrWldOeVpXRnpaVUZzYkc5M1lXNWpaU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXBZbTl2YkNJc0lHMWxkR2h2WkNBaVlYSmpNakF3WDJWNFkyaGhibWRsS0Nrb2RXbHVkRFkwTEdGa1pISmxjM01wSWl3Z2JXVjBhRzlrSUNKaGNtTXlNREJmY21Wa1pXVnRLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pYQnZjMmwwS0hWcGJuUTJOQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0poY21NeU1EQmZjM2RoY0VKaFkyc29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzS0hWcGJuUTJOQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0pqY21WaGRHVkNZV3hoYm1ObFFtOTRLR0ZrWkhKbGMzTXBZbmwwWlNJc0lHMWxkR2h2WkNBaVlYSmpNakF3WDJGc2JHOTNZVzVqWlNoaFpHUnlaWE56TEdGa1pISmxjM01wZFdsdWRESTFOaUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdKdmIzUnpkSEpoY0NCaGNtTXlNREJmYm1GdFpTQmhjbU15TURCZmMzbHRZbTlzSUdGeVl6SXdNRjlrWldOcGJXRnNjeUJoY21NeU1EQmZkRzkwWVd4VGRYQndiSGtnWVhKak1qQXdYMkpoYkdGdVkyVlBaaUJoY21NeU1EQmZkSEpoYm5ObVpYSWdZWEpqTWpBd1gzUnlZVzV6Wm1WeVJuSnZiU0JoY21NeU1EQmZZWEJ3Y205MlpTQmhjbU15TURCZmFXNWpjbVZoYzJWQmJHeHZkMkZ1WTJVZ1lYSmpNakF3WDJSbFkzSmxZWE5sUVd4c2IzZGhibU5sSUdGeVl6SXdNRjlsZUdOb1lXNW5aU0JoY21NeU1EQmZjbVZrWldWdElHUmxjRzl6YVhRZ1lYSmpNakF3WDNOM1lYQkNZV05ySUhkcGRHaGtjbUYzSUdOeVpXRjBaVUpoYkdGdVkyVkNiM2dnWVhKak1qQXdYMkZzYkc5M1lXNWpaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeU5Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTXlNREJmUVZOQklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pwQmNtTXlNREJmUVZOQkxtSnZiM1J6ZEhKaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUp2YjNSemRISmhjRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TkNBdkx5QXpOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNoMWFXNTBPRnN6TWwwc0tHeGxiaXQxYVc1ME9GdGRLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXpOaUF2THlBek5nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGMyRlFjbTl3Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveE1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lDZFBibXg1SUdSbGNHeHZlV1Z5SUc5bUlIUm9hWE1nYzIxaGNuUWdZMjl1ZEhKaFkzUWdZMkZ1SUdOaGJHd2dZbTl2ZEhOMGNtRndJRzFsZEdodlpDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCa1pYQnNiM2xsY2lCdlppQjBhR2x6SUhOdFlYSjBJR052Ym5SeVlXTjBJR05oYmlCallXeHNJR0p2YjNSemRISmhjQ0J0WlhSb2IyUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEExQ2lBZ0lDQXZMeUJoYzNObGNuUW9ibUZ0WlM1dVlYUnBkbVV1YkdWdVozUm9JRDRnTUN3Z0owNWhiV1VnYjJZZ2RHaGxJR0Z6YzJWMElHMTFjM1FnWW1VZ2JHOXVaMlZ5SUc5eUlHVnhkV0ZzSUhSdklERWdZMmhoY21GamRHVnlKeWtLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUU1aGJXVWdiMllnZEdobElHRnpjMlYwSUcxMWMzUWdZbVVnYkc5dVoyVnlJRzl5SUdWeGRXRnNJSFJ2SURFZ1kyaGhjbUZqZEdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdZWE56WlhKMEtHNWhiV1V1Ym1GMGFYWmxMbXhsYm1kMGFDQThQU0F6TWl3Z0owNWhiV1VnYjJZZ2RHaGxJR0Z6YzJWMElHMTFjM1FnWW1VZ2MyaHZjblJsY2lCdmNpQmxjWFZoYkNCMGJ5QXpNaUJqYUdGeVlXTjBaWEp6SnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9ZVzFsSUc5bUlIUm9aU0JoYzNObGRDQnRkWE4wSUdKbElITm9iM0owWlhJZ2IzSWdaWEYxWVd3Z2RHOGdNeklnWTJoaGNtRmpkR1Z5Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoemVXMWliMnd1Ym1GMGFYWmxMbXhsYm1kMGFDQStJREFzSUNkVGVXMWliMndnYjJZZ2RHaGxJR0Z6YzJWMElHMTFjM1FnWW1VZ2JHOXVaMlZ5SUc5eUlHVnhkV0ZzSUhSdklERWdZMmhoY21GamRHVnlKeWtLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUZONWJXSnZiQ0J2WmlCMGFHVWdZWE56WlhRZ2JYVnpkQ0JpWlNCc2IyNW5aWElnYjNJZ1pYRjFZV3dnZEc4Z01TQmphR0Z5WVdOMFpYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEE0Q2lBZ0lDQXZMeUJoYzNObGNuUW9jM2x0WW05c0xtNWhkR2wyWlM1c1pXNW5kR2dnUEQwZ09Dd2dKMU41YldKdmJDQnZaaUIwYUdVZ1lYTnpaWFFnYlhWemRDQmlaU0J6YUc5eWRHVnlJRzl5SUdWeGRXRnNJSFJ2SURnZ1kyaGhjbUZqZEdWeWN5Y3BDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUZVcxaWIyd2diMllnZEdobElHRnpjMlYwSUcxMWMzUWdZbVVnYzJodmNuUmxjaUJ2Y2lCbGNYVmhiQ0IwYnlBNElHTm9ZWEpoWTNSbGNuTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWRHOTBZV3hUZFhCd2JIa3VhR0Z6Vm1Gc2RXVXNJQ2RVYUdseklHMWxkR2h2WkNCallXNGdZbVVnWTJGc2JHVmtJRzl1YkhrZ2IyNWpaU2NwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2ZEdGc1UzVndjR3g1SUQwZ1IyeHZZbUZzVTNSaGRHVThWV2x1ZERJMU5qNG9leUJyWlhrNklDZDBKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZENJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk1UQTVDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11ZEc5MFlXeFRkWEJ3YkhrdWFHRnpWbUZzZFdVc0lDZFVhR2x6SUcxbGRHaHZaQ0JqWVc0Z1ltVWdZMkZzYkdWa0lHOXViSGtnYjI1alpTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWR2hwY3lCdFpYUm9iMlFnWTJGdUlHSmxJR05oYkd4bFpDQnZibXg1SUc5dVkyVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUIwYjNSaGJGTjFjSEJzZVM1aGMwSnBaMVZwYm5Rb0tTQThQU0F5YmlBcUtpQTJORzRnTFNBeGJpd0tJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpUEQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk1URXdMVEV4TXdvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0IwYjNSaGJGTjFjSEJzZVM1aGMwSnBaMVZwYm5Rb0tTQThQU0F5YmlBcUtpQTJORzRnTFNBeGJpd0tJQ0FnSUM4dklDQWdKM1J2ZEdGc1UzVndjR3g1SUcxMWMzUWdabWwwSUdsdUlIVnBiblEyTkNCMGJ5QmlaU0J5WlhCeVpYTmxiblJoWW14bElHRnpJSFJvWlNCM2NtRndjR1ZrSUVGVFFTQjBiM1JoYkNjc0NpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnZEc5MFlXeFRkWEJ3YkhrZ2JYVnpkQ0JtYVhRZ2FXNGdkV2x1ZERZMElIUnZJR0psSUhKbGNISmxjMlZ1ZEdGaWJHVWdZWE1nZEdobElIZHlZWEJ3WldRZ1FWTkJJSFJ2ZEdGc0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QndkV0pzYVdNZ2JtRnRaU0E5SUVkc2IySmhiRk4wWVhSbFBFUjVibUZ0YVdOQ2VYUmxjejRvZXlCclpYazZJQ2R1SnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3hNVFVLSUNBZ0lDOHZJSFJvYVhNdWJtRnRaUzUyWVd4MVpTQTlJRzVoYldVS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUhCMVlteHBZeUJ6ZVcxaWIyd2dQU0JIYkc5aVlXeFRkR0YwWlR4RWVXNWhiV2xqUW5sMFpYTStLSHNnYTJWNU9pQW5jeWNnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpY3lJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk1URTJDaUFnSUNBdkx5QjBhR2x6TG5ONWJXSnZiQzUyWVd4MVpTQTlJSE41YldKdmJBb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdmRHRnNVM1Z3Y0d4NUlEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWRESTFOajRvZXlCclpYazZJQ2QwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEUzQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzVTNWd2NHeDVMblpoYkhWbElEMGdkRzkwWVd4VGRYQndiSGtLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdSbFkybHRZV3h6SUQwZ1IyeHZZbUZzVTNSaGRHVThWV2x1ZERnK0tIc2dhMlY1T2lBblpDY2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlaQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TVRFNENpQWdJQ0F2THlCMGFHbHpMbVJsWTJsdFlXeHpMblpoYkhWbElEMGdaR1ZqYVcxaGJITUtJQ0FnSUdScFp5QTNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem94TWpBS0lDQWdJQzh2SUdOdmJuTjBJSE5sYm1SbGNpQTlJRzVsZHlCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCd2RXSnNhV01nWW1Gc1lXNWpaWE1nUFNCQ2IzaE5ZWEE4UVdSa2NtVnpjeXdnVldsdWRESTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWWlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUIwYUdsekxtSmhiR0Z1WTJWektITmxibVJsY2lrdWRtRnNkV1VnUFNCMGIzUmhiRk4xY0hCc2VRb2dJQ0FnWkdsbklEY0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TVRJMExURXpOd29nSUNBZ0x5OGdZMjl1YzNRZ1kzSmxZWFJsWkVGemMyVjBJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSRGIyNW1hV2NvZXdvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzT2lCMGIzUmhiRk4xY0hCc2VTNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJHY205NlpXNDZJR1poYkhObExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhST1lXMWxPaUJ6ZVcxaWIyd3VibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFRtRnRaVG9nYm1GdFpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJRzFsZEdGa1lYUmhTR0Z6YURvZ1lYTnpaWFF1YldWMFlXUmhkR0ZJWVhOb0xtNWhkR2wyWlM1MGIwWnBlR1ZrS0hzZ2JHVnVaM1JvT2lBek1pQjlLU3dLSUNBZ0lDOHZJQ0FnSUNCMWNtdzZJR0Z6YzJWMExuVnliQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE02SUdSbFkybHRZV3h6TG1GelZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUzVqY21WaGRHVmtRWE56WlhRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCMGIzUmhiRG9nZEc5MFlXeFRkWEJ3YkhrdVlYTlZhVzUwTmpRb0tTd0tJQ0FnSUdScFp5QTJDaUFnSUNCaWFYUnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdScFp5QTJDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem94TXpBS0lDQWdJQzh2SUcxaGJtRm5aWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCeVpYTmxjblpsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem94TXpNS0lDQWdJQzh2SUcxbGRHRmtZWFJoU0dGemFEb2dZWE56WlhRdWJXVjBZV1JoZEdGSVlYTm9MbTVoZEdsMlpTNTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQXpNaUI5S1N3S0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRXhsYm1kMGFDQnRkWE4wSUdKbElETXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnZFhKc09pQmhjM05sZEM1MWNtd3VibUYwYVhabExBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUdSbFkybHRZV3h6T2lCa1pXTnBiV0ZzY3k1aGMxVnBiblEyTkNncExBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJWVWt3S0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTlpYUmhaR0YwWVVoaGMyZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlNaWE5sY25abENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRXRnVZV2RsY2dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJrWldaaGRXeDBSbkp2ZW1WdU9pQm1ZV3h6WlN3S0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWbVlYVnNkRVp5YjNwbGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGUnZkR0ZzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pFeU5DMHhNellLSUNBZ0lDOHZJR052Ym5OMElHTnlaV0YwWldSQmMzTmxkQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkRvZ2RHOTBZV3hUZFhCd2JIa3VZWE5WYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXWmhkV3gwUm5KdmVtVnVPaUJtWVd4elpTd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFRtRnRaVG9nYzNsdFltOXNMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFNWhiV1U2SUc1aGJXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdJQ0J0WlhSaFpHRjBZVWhoYzJnNklHRnpjMlYwTG0xbGRHRmtZWFJoU0dGemFDNXVZWFJwZG1VdWRHOUdhWGhsWkNoN0lHeGxibWQwYURvZ016SWdmU2tzQ2lBZ0lDQXZMeUFnSUNBZ2RYSnNPaUJoYzNObGRDNTFjbXd1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6T2lCa1pXTnBiV0ZzY3k1aGMxVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJtWldVNklEQXNDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVEkwTFRFek53b2dJQ0FnTHk4Z1kyOXVjM1FnWTNKbFlYUmxaRUZ6YzJWMElEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJEYjI1bWFXY29ld29nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNPaUIwYjNSaGJGTjFjSEJzZVM1aGMxVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQWdJR1JsWm1GMWJIUkdjbTk2Wlc0NklHWmhiSE5sTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJPWVcxbE9pQnplVzFpYjJ3dWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVG1GdFpUb2dibUZ0WlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlRvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHMWxkR0ZrWVhSaFNHRnphRG9nWVhOelpYUXViV1YwWVdSaGRHRklZWE5vTG01aGRHbDJaUzUwYjBacGVHVmtLSHNnYkdWdVozUm9PaUF6TWlCOUtTd0tJQ0FnSUM4dklDQWdJQ0IxY213NklHRnpjMlYwTG5WeWJDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTZJR1JsWTJsdFlXeHpMbUZ6VldsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tTNWpjbVZoZEdWa1FYTnpaWFFLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qRXpPUW9nSUNBZ0x5OGdkR2hwY3k1aGMzTmxkRWxrTG5aaGJIVmxJRDBnYm1WM0lGVnBiblEyTkNoamNtVmhkR1ZrUVhOelpYUXVhV1FwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCd2RXSnNhV01nWVhOelpYUkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblEyTkQ0b2V5QnJaWGs2SUNkaGMyRW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poYzJFaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qRXpPUW9nSUNBZ0x5OGdkR2hwY3k1aGMzTmxkRWxrTG5aaGJIVmxJRDBnYm1WM0lGVnBiblEyTkNoamNtVmhkR1ZrUVhOelpYUXVhV1FwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveE5ERUtJQ0FnSUM4dklHVnRhWFFvYm1WM0lHRnlZekl3TUY5VWNtRnVjMlpsY2loN0lHWnliMjA2SUc1bGR5QkJaR1J5WlhOektFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5a3NJSFJ2T2lCelpXNWtaWElzSUhaaGJIVmxPaUIwYjNSaGJGTjFjSEJzZVNCOUtTa0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z2JXVjBhRzlrSUNKaGNtTXlNREJmVkhKaGJuTm1aWElvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPanBCY21NeU1EQmZRVk5CTG1GeVl6SXdNRjl1WVcxbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEpqTWpBd1gyNWhiV1U2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QlRkR0YwYVdOQ2VYUmxjend6TWo0b2RHaHBjeTV1WVcxbExuWmhiSFZsTG01aGRHbDJaU2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdibUZ0WlNBOUlFZHNiMkpoYkZOMFlYUmxQRVI1Ym1GdGFXTkNlWFJsY3o0b2V5QnJaWGs2SUNkdUp5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnVJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1UzUmhkR2xqUW5sMFpYTThNekkrS0hSb2FYTXVibUZ0WlM1MllXeDFaUzV1WVhScGRtVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCemFYcGxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPakUxTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPanBCY21NeU1EQmZRVk5CTG1GeVl6SXdNRjl6ZVcxaWIyeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoY21NeU1EQmZjM2x0WW05c09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3hOaklLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnVTNSaGRHbGpRbmwwWlhNOE9ENG9kR2hwY3k1emVXMWliMnd1ZG1Gc2RXVXVibUYwYVhabEtRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklIQjFZbXhwWXlCemVXMWliMndnUFNCSGJHOWlZV3hUZEdGMFpUeEVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuY3ljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWN5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNVFl5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUZOMFlYUnBZMEo1ZEdWelBEZytLSFJvYVhNdWMzbHRZbTlzTG5aaGJIVmxMbTVoZEdsMlpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYzJsNlpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3hOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzZRWEpqTWpBd1gwRlRRUzVoY21NeU1EQmZaR1ZqYVcxaGJITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoY21NeU1EQmZaR1ZqYVcxaGJITTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPakUzTWdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVpHVmphVzFoYkhNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZqYVcxaGJITWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBPRDRvZXlCclpYazZJQ2RrSnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKa0lnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3hOeklLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1SbFkybHRZV3h6TG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3hOekFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzZRWEpqTWpBd1gwRlRRUzVoY21NeU1EQmZkRzkwWVd4VGRYQndiSGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNtTXlNREJmZEc5MFlXeFRkWEJ3YkhrNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qRTRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeFRkWEJ3YkhrdWRtRnNkV1VLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4VGRYQndiSGtnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwTWpVMlBpaDdJR3RsZVRvZ0ozUW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveE9ESUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMblJ2ZEdGc1UzVndjR3g1TG5aaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3hPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzZRWEpqTWpBd1gwRlRRUzVoY21NeU1EQmZZbUZzWVc1alpVOW1XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak1qQXdYMkpoYkdGdVkyVlBaam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pFNU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYMkpoYkdGdVkyVlBaaWh2ZDI1bGNpa0tJQ0FnSUdOaGJHeHpkV0lnWDJKaGJHRnVZMlZQWmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNlFYSmpNakF3WDBGVFFTNWhjbU15TURCZmRISmhibk5tWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjbU15TURCZmRISmhibk5tWlhJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qSXdNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pJd05Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYM1J5WVc1elptVnlLRzVsZHlCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExDQjBieXdnZG1Gc2RXVXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveU1ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNlFYSmpNakF3WDBGVFFTNWhjbU15TURCZmRISmhibk5tWlhKR2NtOXRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak1qQXdYM1J5WVc1elptVnlSbkp2YlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk1qRTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPakl4T0FvZ0lDQWdMeThnWTI5dWMzUWdjM0JsYm1SbGNpQTlJRzVsZHlCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk1qRTVDaUFnSUNBdkx5QmpiMjV6ZENCemNHVnVaR1Z5WDJGc2JHOTNZVzVqWlNBOUlIUm9hWE11WDJGc2JHOTNZVzVqWlNobWNtOXRMQ0J6Y0dWdVpHVnlLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjloYkd4dmQyRnVZMlVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveU1qQUtJQ0FnSUM4dklHRnpjMlZ5ZENoemNHVnVaR1Z5WDJGc2JHOTNZVzVqWlM1aGMwSnBaMVZwYm5Rb0tTQStQU0IyWVd4MVpTNWhjMEpwWjFWcGJuUW9LU3dnSjJsdWMzVm1abWxqYVdWdWRDQmhjSEJ5YjNaaGJDY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1lqNDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNXpkV1ptYVdOcFpXNTBJR0Z3Y0hKdmRtRnNDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPakl5TVFvZ0lDQWdMeThnYVdZZ0tIWmhiSFZsTG1GelFtbG5WV2x1ZENncElENGdNRzRwSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSjZJR0Z5WXpJd01GOTBjbUZ1YzJabGNrWnliMjFmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPakl5TlFvZ0lDQWdMeThnWTI5dWMzUWdibVYzWDNOd1pXNWtaWEpmWVd4c2IzZGhibU5sSUQwZ2JtVjNJRlZwYm5ReU5UWW9jM0JsYm1SbGNsOWhiR3h2ZDJGdVkyVXVZWE5DYVdkVmFXNTBLQ2tnTFNCMllXeDFaUzVoYzBKcFoxVnBiblFvS1NrS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem95TWpZS0lDQWdJQzh2SUhSb2FYTXVYMkZ3Y0hKdmRtVW9abkp2YlN3Z2MzQmxibVJsY2l3Z2JtVjNYM053Wlc1a1pYSmZZV3hzYjNkaGJtTmxLUW9nSUNBZ1pHbG5JRFVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWDJGd2NISnZkbVVLSUNBZ0lIQnZjQW9LWVhKak1qQXdYM1J5WVc1elptVnlSbkp2YlY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pJeU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYM1J5WVc1elptVnlLR1p5YjIwc0lIUnZMQ0IyWVd4MVpTa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnlZVzV6Wm1WeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qSXhOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qcEJjbU15TURCZlFWTkJMbUZ5WXpJd01GOWhjSEJ5YjNabFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEpqTWpBd1gyRndjSEp2ZG1VNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qSXpPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pJME1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYjNkdVpYSWdQU0J1WlhjZ1FXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveU5ERUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbDloY0hCeWIzWmxLRzkzYm1WeUxDQnpjR1Z1WkdWeUxDQjJZV3gxWlNrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWDJGd2NISnZkbVVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TWpNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02T2tGeVl6SXdNRjlCVTBFdVlYSmpNakF3WDJsdVkzSmxZWE5sUVd4c2IzZGhibU5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYSmpNakF3WDJsdVkzSmxZWE5sUVd4c2IzZGhibU5sT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveU5USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem95TlRRS0lDQWdJQzh2SUdOdmJuTjBJRzkzYm1WeUlEMGdibVYzSUVGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TWpVMUNpQWdJQ0F2THlCamIyNXpkQ0JqZFhKeVpXNTBJRDBnZEdocGN5NWZZV3hzYjNkaGJtTmxLRzkzYm1WeUxDQnpjR1Z1WkdWeUtRb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJmWVd4c2IzZGhibU5sQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pJMU5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVYMkZ3Y0hKdmRtVW9iM2R1WlhJc0lITndaVzVrWlhJc0lHNWxkeUJWYVc1ME1qVTJLR04xY25KbGJuUXVZWE5DYVdkVmFXNTBLQ2tnS3lCMllXeDFaUzVoYzBKcFoxVnBiblFvS1NrcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSXJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCZllYQndjbTkyWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveU5USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNlFYSmpNakF3WDBGVFFTNWhjbU15TURCZlpHVmpjbVZoYzJWQmJHeHZkMkZ1WTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjbU15TURCZlpHVmpjbVZoYzJWQmJHeHZkMkZ1WTJVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qSTJOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pJMk9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYjNkdVpYSWdQU0J1WlhjZ1FXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pveU56QUtJQ0FnSUM4dklHTnZibk4wSUdOMWNuSmxiblFnUFNCMGFHbHpMbDloYkd4dmQyRnVZMlVvYjNkdVpYSXNJSE53Wlc1a1pYSXBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUY5aGJHeHZkMkZ1WTJVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk1qY3hDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnljbVZ1ZEM1aGMwSnBaMVZwYm5Rb0tTQStQU0IyWVd4MVpTNWhjMEpwWjFWcGJuUW9LU3dnSjBSbFkzSmxZWE5sSUdWNFkyVmxaSE1nWTNWeWNtVnVkQ0JoYkd4dmQyRnVZMlVuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSR1ZqY21WaGMyVWdaWGhqWldWa2N5QmpkWEp5Wlc1MElHRnNiRzkzWVc1alpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3lOeklLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5aGNIQnliM1psS0c5M2JtVnlMQ0J6Y0dWdVpHVnlMQ0J1WlhjZ1ZXbHVkREkxTmloamRYSnlaVzUwTG1GelFtbG5WV2x1ZENncElDMGdkbUZzZFdVdVlYTkNhV2RWYVc1MEtDa3BLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpTFFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdYMkZ3Y0hKdmRtVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNalkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZPa0Z5WXpJd01GOUJVMEV1WVhKak1qQXdYMlY0WTJoaGJtZGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak1qQXdYMlY0WTJoaGJtZGxPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem95T0RrS0lDQWdJQzh2SUdWNFkyaGhibWRsWDJGemMyVjBPaUIwYUdsekxtRnpjMlYwU1dRdWRtRnNkV1VzSUM4dklGUm9aU0JCVTBFZ1NVUWdkR2hoZENCMGFHVWdRVkpETWpBd0lIUnZhMlZ1SUdOaGJpQmlaU0JsZUdOb1lXNW5aV1FnZDJsMGFDNEtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QndkV0pzYVdNZ1lYTnpaWFJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQRlZwYm5RMk5ENG9leUJyWlhrNklDZGhjMkVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaGMyRWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPakk0T1FvZ0lDQWdMeThnWlhoamFHRnVaMlZmWVhOelpYUTZJSFJvYVhNdVlYTnpaWFJKWkM1MllXeDFaU3dnTHk4Z1ZHaGxJRUZUUVNCSlJDQjBhR0YwSUhSb1pTQkJVa015TURBZ2RHOXJaVzRnWTJGdUlHSmxJR1Y0WTJoaGJtZGxaQ0IzYVhSb0xnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk1qa3dDaUFnSUNBdkx5QnphVzVyT2lCdVpYY2dRV1JrY21WemN5aEhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3lrc0lDOHZJRlJvWlNCaFpHUnlaWE56SUhSb1lYUWdhRzlzWkhNZ1FWSkRNakF3SUhSdmEyVnVjeUJtYjNJZ2NtVmtaVzF3ZEdsdmJpQnZjR1Z5WVhScGIyNXpMZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TWpnNExUSTVNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJoY21NeU1EQmZaWGhqYUdGdVoyVkpibVp2S0hzS0lDQWdJQzh2SUNBZ1pYaGphR0Z1WjJWZllYTnpaWFE2SUhSb2FYTXVZWE56WlhSSlpDNTJZV3gxWlN3Z0x5OGdWR2hsSUVGVFFTQkpSQ0IwYUdGMElIUm9aU0JCVWtNeU1EQWdkRzlyWlc0Z1kyRnVJR0psSUdWNFkyaGhibWRsWkNCM2FYUm9MZ29nSUNBZ0x5OGdJQ0J6YVc1ck9pQnVaWGNnUVdSa2NtVnpjeWhIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5a3NJQzh2SUZSb1pTQmhaR1J5WlhOeklIUm9ZWFFnYUc5c1pITWdRVkpETWpBd0lIUnZhMlZ1Y3lCbWIzSWdjbVZrWlcxd2RHbHZiaUJ2Y0dWeVlYUnBiMjV6TGdvZ0lDQWdMeThnZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3lPRFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzZRWEpqTWpBd1gwRlRRUzVoY21NeU1EQmZjbVZrWldWdFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEpqTWpBd1gzSmxaR1ZsYlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk16QTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96TVRFS0lDQWdJQzh2SUdOdmJuTjBJSEpsWTJWcGRtVmtJRDBnZEdocGN5NWZkbUZzYVdSaGRHVkpibU52YldsdVowRjRabVZ5S0dGdGIzVnVkQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gzWmhiR2xrWVhSbFNXNWpiMjFwYm1kQmVHWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96TVRNS0lDQWdJQzh2SUc1bGR5QkJaR1J5WlhOektFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56S1N3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qTXhOQW9nSUNBZ0x5OGdibVYzSUVGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pNeE1pMHpNVFlLSUNBZ0lDOHZJSFJvYVhNdVgzUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQnVaWGNnUVdSa2NtVnpjeWhIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5a3NDaUFnSUNBdkx5QWdJRzVsZHlCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabFpDd2dMeThnYzJWdVpDQjBhR1VnY21WaGJDQmhiVzkxYm5RZ2QyaHBZMmdnYlhWemRDQmlaU0JuY21WaGRHVnlJRzl5SUdWeGRXRnNJSFJ2SUhKbGNYVmxjM1JsWkNCaGJXOTFiblFLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJmZEhKaGJuTm1aWElLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96TURrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem82UVhKak1qQXdYMEZUUVM1a1pYQnZjMmwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVndiM05wZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk16STFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96TWpjS0lDQWdJQzh2SUdOdmJuTjBJSEpsWTJWcGRtVmtJRDBnZEdocGN5NWZkbUZzYVdSaGRHVkpibU52YldsdVowRjRabVZ5S0dGdGIzVnVkQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gzWmhiR2xrWVhSbFNXNWpiMjFwYm1kQmVHWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96TWprS0lDQWdJQzh2SUc1bGR5QkJaR1J5WlhOektFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56S1N3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qTXpNQW9nSUNBZ0x5OGdibVYzSUVGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pNeU9DMHpNeklLSUNBZ0lDOHZJSFJvYVhNdVgzUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQnVaWGNnUVdSa2NtVnpjeWhIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5a3NDaUFnSUNBdkx5QWdJRzVsZHlCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabFpDd2dMeThnYzJWdVpDQjBhR1VnY21WaGJDQmhiVzkxYm5RZ2QyaHBZMmdnYlhWemRDQmlaU0JuY21WaGRHVnlJRzl5SUdWeGRXRnNJSFJ2SUhKbGNYVmxjM1JsWkNCaGJXOTFiblFLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNnb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qTXlOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qcEJjbU15TURCZlFWTkJMbUZ5WXpJd01GOXpkMkZ3UW1GamExdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ5WXpJd01GOXpkMkZ3UW1GamF6b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZNelV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvek5UUUtJQ0FnSUM4dklIUm9hWE11WDNKbGJHVmhjMlZCYzJFb1lXMXZkVzUwS1FvZ0lDQWdZMkZzYkhOMVlpQmZjbVZzWldGelpVRnpZUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96TlRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem82UVhKak1qQXdYMEZUUVM1M2FYUm9aSEpoZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3pOak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TXpZMUNpQWdJQ0F2THlCMGFHbHpMbDl5Wld4bFlYTmxRWE5oS0dGdGIzVnVkQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlGOXlaV3hsWVhObFFYTmhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPak0yTmdvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCVmFXNTBNalUyS0dGdGIzVnVkQzVoYzBKcFoxVnBiblFvS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk16WXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk9rRnlZekl3TUY5QlUwRXVZM0psWVhSbFFtRnNZVzVqWlVKdmVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpVSmhiR0Z1WTJWQ2IzZzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPak00TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnY0hWaWJHbGpJR0poYkdGdVkyVnpJRDBnUW05NFRXRndQRUZrWkhKbGMzTXNJRlZwYm5ReU5UWStLSHNnYTJWNVVISmxabWw0T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvek9ESUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NWlZV3hoYm1ObGN5aHZkMjVsY2lrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJqY21WaGRHVkNZV3hoYm1ObFFtOTRYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6b3pPRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1WjNKdmRYQkpibVJsZUNBK0lEQXNJQ2ROZFhOMElHSmxJSEJ5WldObFpHVmtJR0o1SUdFZ2NHRjViV1Z1ZENCamIzWmxjbWx1WnlCMGFHVWdZbUZzWVc1alpTQmliM2dnVFVKU0p5a0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1RYVnpkQ0JpWlNCd2NtVmpaV1JsWkNCaWVTQmhJSEJoZVcxbGJuUWdZMjkyWlhKcGJtY2dkR2hsSUdKaGJHRnVZMlVnWW05NElFMUNVZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96T0RRS0lDQWdJQzh2SUdOdmJuTjBJSEJoZVNBOUlHZDBlRzR1VUdGNWJXVnVkRlI0YmloVWVHNHVaM0p2ZFhCSmJtUmxlQ0F0SURFcENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TXpnMUNpQWdJQ0F2THlCaGMzTmxjblFvY0dGNUxuTmxibVJsY2lBOVBUMGdWSGh1TG5ObGJtUmxjaXdnSjFCaGVXMWxiblFnYzJWdVpHVnlJRzExYzNRZ2JXRjBZMmdnWTJGc2JHVnlKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dZMkZzYkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qTTROZ29nSUNBZ0x5OGdZWE56WlhKMEtIQmhlUzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUNkUVlYbHRaVzUwSUcxMWMzUWdZbVVnYzJWdWRDQjBieUIwYUdVZ1lYQndJR0ZqWTI5MWJuUW5LUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJR0psSUhObGJuUWdkRzhnZEdobElHRndjQ0JoWTJOdmRXNTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPak00TndvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVM1aGJXOTFiblFnUGowZ1FrRk1RVTVEUlY5Q1QxaGZUVUpTTENBblVHRjViV1Z1ZENCdGRYTjBJR052ZG1WeUlIUm9aU0JpWVd4aGJtTmxJR0p2ZUNCTlFsSW5LUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCd2RYTm9hVzUwSURJNE5UQXdJQzh2SURJNE5UQXdDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQmpiM1psY2lCMGFHVWdZbUZzWVc1alpTQmliM2dnVFVKU0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qTTRPQW9nSUNBZ0x5OGdkR2hwY3k1aVlXeGhibU5sY3lodmQyNWxjaWt1ZG1Gc2RXVWdQU0J1WlhjZ1ZXbHVkREkxTmlnd0tRb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem96T0RrS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVDZVhSbEtERXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNUW9LWTNKbFlYUmxRbUZzWVc1alpVSnZlRjloWm5SbGNsOXBibXhwYm1Wa1gyTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZPa0Z5WXpJd01GOUJVMEV1WTNKbFlYUmxRbUZzWVc1alpVSnZlRUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvek9EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGpjbVZoZEdWQ1lXeGhibU5sUW05NFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk16a3hDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpRdVFubDBaU2d3S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk16Z3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWWlCamNtVmhkR1ZDWVd4aGJtTmxRbTk0WDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem82UVhKak1qQXdYMEZUUVM1amNtVmhkR1ZDWVd4aGJtTmxRbTk0UURRS0Nnb3ZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pwQmNtTXlNREJmUVZOQkxtRnlZekl3TUY5aGJHeHZkMkZ1WTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjbU15TURCZllXeHNiM2RoYm1ObE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzBNREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzBNRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TGw5aGJHeHZkMkZ1WTJVb2IzZHVaWElzSUhOd1pXNWtaWElwQ2lBZ0lDQmpZV3hzYzNWaUlGOWhiR3h2ZDJGdVkyVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZOREF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZPa0Z5WXpJd01GOUJVMEV1WDJKaGJHRnVZMlZQWmlodmQyNWxjam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BmWW1Gc1lXNWpaVTltT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvME1EWUtJQ0FnSUM4dklIQnlhWFpoZEdVZ1gySmhiR0Z1WTJWUFppaHZkMjVsY2pvZ1FXUmtjbVZ6Y3lrNklGVnBiblF5TlRZZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCd2RXSnNhV01nWW1Gc1lXNWpaWE1nUFNCQ2IzaE5ZWEE4UVdSa2NtVnpjeXdnVldsdWRESTFOajRvZXlCclpYbFFjbVZtYVhnNklDZGlKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5EQTNDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVZbUZzWVc1alpYTW9iM2R1WlhJcExtVjRhWE4wY3lrZ2NtVjBkWEp1SUc1bGR5QlZhVzUwTWpVMktEQXBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCZlltRnNZVzVqWlU5bVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tYMkpoYkdGdVkyVlBabDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalF3T0FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVltRnNZVzVqWlhNb2IzZHVaWElwTG5aaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZPa0Z5WXpJd01GOUJVMEV1WDNSeVlXNXpabVZ5S0hObGJtUmxjam9nWW5sMFpYTXNJSEpsWTJsd2FXVnVkRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZkSEpoYm5ObVpYSTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalF4TVFvZ0lDQWdMeThnY0hKcGRtRjBaU0JmZEhKaGJuTm1aWElvYzJWdVpHVnlPaUJCWkdSeVpYTnpMQ0J5WldOcGNHbGxiblE2SUVGa1pISmxjM01zSUdGdGIzVnVkRG9nVldsdWRESTFOaWs2SUVKdmIyd2dld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvME1USUtJQ0FnSUM4dklHTnZibk4wSUhObGJtUmxjbDlpWVd4aGJtTmxJRDBnZEdocGN5NWZZbUZzWVc1alpVOW1LSE5sYm1SbGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTJGc2JITjFZaUJmWW1Gc1lXNWpaVTltQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TkRFekNpQWdJQ0F2THlCamIyNXpkQ0J5WldOcGNHbGxiblJmWW1Gc1lXNWpaU0E5SUhSb2FYTXVYMkpoYkdGdVkyVlBaaWh5WldOcGNHbGxiblFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1gySmhiR0Z1WTJWUFpnb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzBNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHpaVzVrWlhKZlltRnNZVzVqWlM1aGMwSnBaMVZwYm5Rb0tTQStQU0JoYlc5MWJuUXVZWE5DYVdkVmFXNTBLQ2tzSUNkSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpTQmhkQ0IwYUdVZ2MyVnVaR1Z5SUdGalkyOTFiblFuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnWW1Gc1lXNWpaU0JoZENCMGFHVWdjMlZ1WkdWeUlHRmpZMjkxYm5RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5ERTJDaUFnSUNBdkx5QnBaaUFvYzJWdVpHVnlJQ0U5UFNCeVpXTnBjR2xsYm5RcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0FoUFFvZ0lDQWdZbm9nWDNSeVlXNXpabVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTVRjS0lDQWdJQzh2SUdGemMyVnlkQ2h5WldOcGNHbGxiblFnSVQwOUlHNWxkeUJCWkdSeVpYTnpLRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeWtzSUNkRFlXNXViM1FnZEhKaGJuTm1aWElnZEc4Z2RHaGxJSHBsY204Z1lXUmtjbVZ6Y3ljcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRFlXNXViM1FnZEhKaGJuTm1aWElnZEc4Z2RHaGxJSHBsY204Z1lXUmtjbVZ6Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2NIVmliR2xqSUdKaGJHRnVZMlZ6SUQwZ1FtOTRUV0Z3UEVGa1pISmxjM01zSUZWcGJuUXlOVFkrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZaWNnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1JaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5ERTRDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXVZbUZzWVc1alpYTW9jbVZqYVhCcFpXNTBLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklGOTBjbUZ1YzJabGNsOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5ESXhDaUFnSUNBdkx5QmhjM05sY25Rb1lXMXZkVzUwTG1GelFtbG5WV2x1ZENncElENGdNRzRzSUNkQklIcGxjbTh0ZG1Gc2RXVWdkSEpoYm5ObVpYSWdZMkZ1Ym05MElHSmxJSFZ6WldRZ2RHOGdZM0psWVhSbElHRWdibVYzSUdKaGJHRnVZMlVnWW05NEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJRUVnZW1WeWJ5MTJZV3gxWlNCMGNtRnVjMlpsY2lCallXNXViM1FnWW1VZ2RYTmxaQ0IwYnlCamNtVmhkR1VnWVNCdVpYY2dZbUZzWVc1alpTQmliM2dLQ2w5MGNtRnVjMlpsY2w5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pReU13b2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWh6Wlc1a1pYSXBMblpoYkhWbElEMGdibVYzSUZWcGJuUXlOVFlvYzJWdVpHVnlYMkpoYkdGdVkyVXVZWE5DYVdkVmFXNTBLQ2tnTFNCaGJXOTFiblF1WVhOQ2FXZFZhVzUwS0NrcENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbUZzWVc1alpYTWdQU0JDYjNoTllYQThRV1JrY21WemN5d2dWV2x1ZERJMU5qNG9leUJyWlhsUWNtVm1hWGc2SUNkaUp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pReU13b2dJQ0FnTHk4Z2RHaHBjeTVpWVd4aGJtTmxjeWh6Wlc1a1pYSXBMblpoYkhWbElEMGdibVYzSUZWcGJuUXlOVFlvYzJWdVpHVnlYMkpoYkdGdVkyVXVZWE5DYVdkVmFXNTBLQ2tnTFNCaGJXOTFiblF1WVhOQ2FXZFZhVzUwS0NrcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalF5TkFvZ0lDQWdMeThnZEdocGN5NWlZV3hoYm1ObGN5aHlaV05wY0dsbGJuUXBMblpoYkhWbElEMGdibVYzSUZWcGJuUXlOVFlvY21WamFYQnBaVzUwWDJKaGJHRnVZMlV1WVhOQ2FXZFZhVzUwS0NrZ0t5QmhiVzkxYm5RdVlYTkNhV2RWYVc1MEtDa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZbndLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2dwZmRISmhibk5tWlhKZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvME1qWUtJQ0FnSUM4dklHVnRhWFFvYm1WM0lHRnlZekl3TUY5VWNtRnVjMlpsY2loN0lHWnliMjA2SUhObGJtUmxjaXdnZEc4NklISmxZMmx3YVdWdWRDd2dkbUZzZFdVNklHRnRiM1Z1ZENCOUtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUExSUM4dklHMWxkR2h2WkNBaVlYSmpNakF3WDFSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pReU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QkNiMjlzS0hSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPanBCY21NeU1EQmZRVk5CTGw5MllXeHBaR0YwWlVsdVkyOXRhVzVuUVhobVpYSW9ZVzF2ZFc1ME9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOTJZV3hwWkdGMFpVbHVZMjl0YVc1blFYaG1aWEk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pRek5nb2dJQ0FnTHk4Z2NISnBkbUYwWlNCZmRtRnNhV1JoZEdWSmJtTnZiV2x1WjBGNFptVnlLR0Z0YjNWdWREb2dWV2x1ZERZMEtUb2dWV2x1ZERJMU5pQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5ETTNDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbWR5YjNWd1NXNWtaWGdnUGlBd0xDQW5UWFZ6ZENCaVpTQndjbVZqWldSbFpDQmllU0JoYmlCQlUwRWdkSEpoYm5ObVpYSW5LUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5kWE4wSUdKbElIQnlaV05sWkdWa0lHSjVJR0Z1SUVGVFFTQjBjbUZ1YzJabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzBNemdLSUNBZ0lDOHZJR052Ym5OMElIQnlaWFlnUFNCbmRIaHVMbFJ5WVc1ellXTjBhVzl1S0ZSNGJpNW5jbTkxY0VsdVpHVjRJQzBnTVNrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTXprS0lDQWdJQzh2SUdGemMyVnlkQ2h3Y21WMkxuUjVjR1VnUFQwOUlGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmMzTmxkRlJ5WVc1elptVnlMQ0FuVUhKbGRtbHZkWE1nZEhodUlHMTFjM1FnWW1VZ1FWTkJJSFJ5WVc1elptVnlKeWtLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFjbVYyYVc5MWN5QjBlRzRnYlhWemRDQmlaU0JCVTBFZ2RISmhibk5tWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5EUXdDaUFnSUNBdkx5QmpiMjV6ZENCaGVHWmxjaUE5SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpaFVlRzR1WjNKdmRYQkpibVJsZUNBdElERXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pRME1nb2dJQ0FnTHk4Z1lYaG1aWEl1WVhOelpYUkJiVzkxYm5RZ1BqMGdZVzF2ZFc1MExtRnpWV2x1ZERZMEtDa3NDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQThQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTkRFdE5EUTBDaUFnSUNBdkx5QmhjM05sY25Rb0NpQWdJQ0F2THlBZ0lHRjRabVZ5TG1GemMyVjBRVzF2ZFc1MElENDlJR0Z0YjNWdWRDNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FuVkdobElHRnRiM1Z1ZENCMGNtRnVjMlpsY25KbFpDQk5WVk5VSUdKbElHVnhkV0ZzSUhSdklHOXlJR2R5WldGMFpYSWdkR2hoYmlCMGFHVWdZVzF2ZFc1MElISmxjWFZsYzNSbFpDY3NDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHaGxJR0Z0YjNWdWRDQjBjbUZ1YzJabGNuSmxaQ0JOVlZOVUlHSmxJR1Z4ZFdGc0lIUnZJRzl5SUdkeVpXRjBaWElnZEdoaGJpQjBhR1VnWVcxdmRXNTBJSEpsY1hWbGMzUmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTkRVS0lDQWdJQzh2SUdGemMyVnlkQ2hoZUdabGNpNTRabVZ5UVhOelpYUXVhV1FnUFQwOUlIUm9hWE11WVhOelpYUkpaQzUyWVd4MVpTNWhjMVZwYm5RMk5DZ3BMQ0FuUVZOQklFbEVJRzExYzNRZ2JXRjBZMmdnWTI5dVptbG5kWEpsWkNCbGVHTm9ZVzVuWlY5aGMzTmxkQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdGemMyVjBTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwTmpRK0tIc2dhMlY1T2lBbllYTmhKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhOaElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzBORFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhlR1psY2k1NFptVnlRWE56WlhRdWFXUWdQVDA5SUhSb2FYTXVZWE56WlhSSlpDNTJZV3gxWlM1aGMxVnBiblEyTkNncExDQW5RVk5CSUVsRUlHMTFjM1FnYldGMFkyZ2dZMjl1Wm1sbmRYSmxaQ0JsZUdOb1lXNW5aVjloYzNObGRDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCVTBFZ1NVUWdiWFZ6ZENCdFlYUmphQ0JqYjI1bWFXZDFjbVZrSUdWNFkyaGhibWRsWDJGemMyVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalEwTmdvZ0lDQWdMeThnWVhOelpYSjBLR0Y0Wm1WeUxtRnpjMlYwVW1WalpXbDJaWElnUFQwOUlFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENBblFWTkJJRzExYzNRZ1ltVWdjMlZ1ZENCMGJ5QjBhR1VnYzJsdWF5QmhaR1J5WlhOekp5a0tJQ0FnSUdScFp5QXhDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCVTBFZ2JYVnpkQ0JpWlNCelpXNTBJSFJ2SUhSb1pTQnphVzVySUdGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TkRRM0NpQWdJQ0F2THlCaGMzTmxjblFvWVhobVpYSXVjMlZ1WkdWeUlEMDlQU0JVZUc0dWMyVnVaR1Z5TENBblFWTkJJSE5sYm1SbGNpQnRkWE4wSUcxaGRHTm9JRUZTUXpJd01DQnlaV1JsWlcxbGNpY3BDaUFnSUNCemQyRndDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVk5CSUhObGJtUmxjaUJ0ZFhOMElHMWhkR05vSUVGU1F6SXdNQ0J5WldSbFpXMWxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTkRnS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1ZXbHVkREkxTmloaGVHWmxjaTVoYzNObGRFRnRiM1Z1ZENrZ0x5OGdkR2hsSUhKbFlXd2dZVzF2ZFc1MElISmxZMlZwZG1Wa0xDQjNhR2xqYUNCcGN5QStQU0JoYlc5MWJuUWdjbVZ4ZFdWemRHVmtDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzZRWEpqTWpBd1gwRlRRUzVmY21Wc1pXRnpaVUZ6WVNoaGJXOTFiblE2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmY21Wc1pXRnpaVUZ6WVRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5EVTFDaUFnSUNBdkx5QndjbWwyWVhSbElGOXlaV3hsWVhObFFYTmhLR0Z0YjNWdWREb2dWV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TkRVM0NpQWdJQ0F2THlCdVpYY2dRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZORFU0Q2lBZ0lDQXZMeUJ1WlhjZ1FXUmtjbVZ6Y3loSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeWtzQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvME5Ua0tJQ0FnSUM4dklHNWxkeUJWYVc1ME1qVTJLR0Z0YjNWdWRDNWhjMEpwWjFWcGJuUW9LU2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalExTmkwME5qQUtJQ0FnSUM4dklIUm9hWE11WDNSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNCdVpYY2dRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnYm1WM0lFRmtaSEpsYzNNb1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01wTEFvZ0lDQWdMeThnSUNCdVpYY2dWV2x1ZERJMU5paGhiVzkxYm5RdVlYTkNhV2RWYVc1MEtDa3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyRnNiSE4xWWlCZmRISmhibk5tWlhJS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvME5qRXRORFk0Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblF1WVhOVmFXNTBOalFvS1N3S0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJSFJvYVhNdVlYTnpaWFJKWkM1MllXeDFaUzVoYzFWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qUTJNd29nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTXlNREJmWVhOaExtRnNaMjh1ZEhNNk5EWTBDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nWVcxdmRXNTBMbUZ6VldsdWREWTBLQ2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TkRZMUNpQWdJQ0F2THlCNFptVnlRWE56WlhRNklIUm9hWE11WVhOelpYUkpaQzUyWVd4MVpTNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJSEIxWW14cFl5QmhjM05sZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWREWTBQaWg3SUd0bGVUb2dKMkZ6WVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRnpZU0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TkRZMUNpQWdJQ0F2THlCNFptVnlRWE56WlhRNklIUm9hWE11WVhOelpYUkpaQzUyWVd4MVpTNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZORFl4TFRRMk53b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZVzF2ZFc1MExtRnpWV2x1ZERZMEtDa3NDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCMGFHbHpMbUZ6YzJWMFNXUXVkbUZzZFdVdVlYTlZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTmpZS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTmpFdE5EWTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJoYlc5MWJuUXVZWE5WYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklIUm9hWE11WVhOelpYUkpaQzUyWVd4MVpTNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTI5dWRISmhZM1J6TDJGeVl6SXdNRjloYzJFdVlXeG5ieTUwY3pvNlFYSmpNakF3WDBGVFFTNWZZV3hzYjNkaGJtTmxLRzkzYm1WeU9pQmllWFJsY3l3Z2MzQmxibVJsY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwZllXeHNiM2RoYm1ObE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZekl3TUY5aGMyRXVZV3huYnk1MGN6bzBOelVLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdYMkZzYkc5M1lXNWpaU2h2ZDI1bGNqb2dRV1JrY21WemN5d2djM0JsYm1SbGNqb2dRV1JrY21WemN5azZJRlZwYm5ReU5UWWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qUTNNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJUZEdGMGFXTkNlWFJsY3p3ek1qNG9iM0F1YzJoaE1qVTJLRzl3TG1OdmJtTmhkQ2h2ZDI1bGNpNWllWFJsY3l3Z2MzQmxibVJsY2k1aWVYUmxjeWtwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QndkV0pzYVdNZ1lYQndjbTkyWVd4eklEMGdRbTk0VFdGd1BGTjBZWFJwWTBKNWRHVnpQRE15UGl3Z1FYQndjbTkyWVd4VGRISjFZM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZU2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qUTNOd29nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbUZ3Y0hKdmRtRnNjeWhyWlhrcExtVjRhWE4wY3lrZ2NtVjBkWEp1SUc1bGR5QlZhVzUwTWpVMktEQXBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCZllXeHNiM2RoYm1ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tYMkZzYkc5M1lXNWpaVjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalEzT0FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVlYQndjbTkyWVd4ektHdGxlU2t1ZG1Gc2RXVXVZWEJ3Y205MllXeEJiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pwQmNtTXlNREJmUVZOQkxsOWhjSEJ5YjNabEtHOTNibVZ5T2lCaWVYUmxjeXdnYzNCbGJtUmxjam9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZZWEJ3Y205MlpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU15TURCZllYTmhMbUZzWjI4dWRITTZORGd4Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJRjloY0hCeWIzWmxLRzkzYm1WeU9pQkJaR1J5WlhOekxDQnpjR1Z1WkdWeU9pQkJaR1J5WlhOekxDQmhiVzkxYm5RNklGVnBiblF5TlRZcE9pQkNiMjlzSUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpJd01GOWhjMkV1WVd4bmJ5NTBjem8wTnpJS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1UzUmhkR2xqUW5sMFpYTThNekkrS0c5d0xuTm9ZVEkxTmlodmNDNWpiMjVqWVhRb2IzZHVaWEl1WW5sMFpYTXNJSE53Wlc1a1pYSXVZbmwwWlhNcEtTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYzJoaE1qVTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWEJ3Y205MllXeHpJRDBnUW05NFRXRndQRk4wWVhScFkwSjVkR1Z6UERNeVBpd2dRWEJ3Y205MllXeFRkSEoxWTNRK0tIc2dhMlY1VUhKbFptbDRPaUFuWVNjZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTWpBd1gyRnpZUzVoYkdkdkxuUnpPalE0TXdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1Gd2NISnZkbUZzY3loclpYa3BMbVY0YVhOMGN5a2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1gyRndjSEp2ZG1WZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak1qQXdYMkZ6WVM1aGJHZHZMblJ6T2pRNE53b2dJQ0FnTHk4Z1lYTnpaWEowS0dGdGIzVnVkQzVoYzBKcFoxVnBiblFvS1NBK0lEQnVMQ0FuUVNCNlpYSnZMWFpoYkhWbElHRndjSEp2ZG1Gc0lHTmhibTV2ZENCaVpTQjFjMlZrSUhSdklHTnlaV0YwWlNCaElHNWxkeUJoY0hCeWIzWmhiQ0JpYjNnbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0krQ2lBZ0lDQmhjM05sY25RZ0x5OGdRU0I2WlhKdkxYWmhiSFZsSUdGd2NISnZkbUZzSUdOaGJtNXZkQ0JpWlNCMWMyVmtJSFJ2SUdOeVpXRjBaU0JoSUc1bGR5QmhjSEJ5YjNaaGJDQmliM2dLQ2w5aGNIQnliM1psWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TkRnNUxUUTVNd29nSUNBZ0x5OGdZMjl1YzNRZ1lYQndjbTkyWVd4Q2IzZzZJRUZ3Y0hKdmRtRnNVM1J5ZFdOMElEMGdibVYzSUVGd2NISnZkbUZzVTNSeWRXTjBLSHNLSUNBZ0lDOHZJQ0FnWVhCd2NtOTJZV3hCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdiM2R1WlhJNklHOTNibVZ5TEFvZ0lDQWdMeThnSUNCemNHVnVaR1Z5T2lCemNHVnVaR1Z5TEFvZ0lDQWdMeThnZlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qUTVOQW9nSUNBZ0x5OGdkR2hwY3k1aGNIQnliM1poYkhNb2EyVjVLUzUyWVd4MVpTQTlJR05zYjI1bEtHRndjSEp2ZG1Gc1FtOTRLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NeU1EQmZZWE5oTG1Gc1oyOHVkSE02TkRrMUNpQWdJQ0F2THlCbGJXbDBLRzVsZHlCaGNtTXlNREJmUVhCd2NtOTJZV3dvZXlCdmQyNWxjam9nYjNkdVpYSXNJSE53Wlc1a1pYSTZJSE53Wlc1a1pYSXNJSFpoYkhWbE9pQmhiVzkxYm5RZ2ZTa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTVOamxtT0RZMUlDOHZJRzFsZEdodlpDQWlZWEpqTWpBd1gwRndjSEp2ZG1Gc0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpNakF3WDJGellTNWhiR2R2TG5Sek9qUTVOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJDYjI5c0tIUnlkV1VwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUlBRUFDQ1lHQkJVZmZIVUJZZ05oYzJFQmRDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFSNWc4TmNNUnRCQUkweEdSUkVNUmhFZ2hJRWlkbDFId1JsZlJQc0JMYXVHaVVFaE93VDFRVHNtV0JCQklMbGM4UUUybkFsdVFSS2xvK1BCTFZDSVNVRWtQQW16UVM0dnZQTkJFQ2JWSmNFWXRRYzN3UUNJeVo4Qkh3QzJxOEVhTStZemdTaldlUjFCTHV6R2ZNMkdnQ09FZ0FMQVFjQkd3RXZBVHNCUlFGV0FYTUJ6Z0hyQWhvQ1RnSmJBbklDalFLYUFyUUMvQUF4R1JReEdCUVFSQ05ETmhvQlNTUlpnUUlJU3dFVkVrUTJHZ0pKSkZtQkFnaExBUlVTUkRZYUEwa1ZJeEpFTmhvRVNSVkpJaEpFTmhvRlNSVkxBU0paU1lFaUVrUkxBa3hMQWxKSkpGbUJKQWhQQWhKRU1RQXlDUkpFU3daWEFnQkpGVWxFSWc1RVN3WlhBZ0JKRlVsRUpRNUVKQ3RsUlFFVVJFc0ZnQWovLy8vLy8vLy8vNlpFZ0FGdVR3bG5nQUZ6VHdobkswc0daNEFCWkVzSFp6RUFLVXNCVUVzSHY3RkxCcE9CUUE1RVR3VWxDVXNHVEZzeUNrbFBCMWNBSUVrVkloSkVUd2RYQWdCUENSZXlJN0luc2lpeUtySXBUd095Sms4Q3NpVWtzaVN5SW9FRHNoQWtzZ0d6dER3V0treG5NZ05NVUV4UUp3Vk1VTENBQlJVZmZIV0FzQ05ESklBQmJtVkVWd0lBU1JVaUVrUW9URkN3STBNa2dBRnpaVVJYQWdCSkZTVVNSQ2hNVUxBalF5U0FBV1JsUkNoTVVMQWpReVFyWlVRb1RGQ3dJME0yR2dGSkZTSVNSSWdCeFNoTVVMQWpRellhQVVrVkloSkVOaG9DU1JVaUVrUXhBRTRDaUFIQUtFeFFzQ05ETmhvQlJ3SVZJaEpFTmhvQ1NVNENGU0lTUkRZYUEwbE9Ba2tWSWhKRU1RQkpUZ05QQWt5SUFuSkpUZ0pMQWFkRWdBQ2xRUUFXU1VzRG9Va1ZJZzVFSXErclN3VkxBMDhDaUFKeVNFc0VTd1JMQklnQlpTaE1VTEFqUXpZYUFVa1ZJaEpFTmhvQ1NSVWlFa1F4QUU0Q2lBSkxLRXhRc0NORE5ob0JTUlVpRWtRMkdnSkpGU0lTUkRFQVNVc0RpQUlMVHdLZ1NSVWlEa1FpcjZ0TVRnS0lBaHdvVEZDd0kwTTJHZ0ZKRlNJU1JEWWFBa2tWSWhKRU1RQkpTd09JQWR4SlN3T25SRThDb1VrVklnNUVJcStyVEU0Q2lBSG9LRXhRc0NOREpDcGxSRElLVUNoTVVMQWpRellhQVVrVkpSSkVpQUUwTWdveEFFOENpQUMrU0NORE5ob0JTUlVsRWtTSUFSMHlDakVBU3dLSUFLZElLRXhRc0NORE5ob0JTUlVsRWtTSUFVWWpRellhQVVrVlNTVVNSRXNCaUFFMklnNUVJcStyS0V4UXNDTkROaG9CU1JVaUVrUXBURkJKdlVVQlFBQXdNUlpFTVJZakNVazRFQ01TUkVrNEFERUFFa1JKT0FjeUNoSkVPQWlCMU40QkQwUkpKd1MvZ0FFQktFeFFzQ05EZ0FFQVF2LzBOaG9CU1JVaUVrUTJHZ0pKRlNJU1JJZ0EveWhNVUxBalE0b0JBU21MLzFCSnZVVUJRQUFFSndSTWlZc0F2a1JNaVlvREFTU0wvWWovMzBtTC9vai8yVXlMLzZkRWkvMkwvaE5CQUQ2TC9qSURFMFFwaS81UVNZd0F2VVVCUUFBR2kvK0FBS1ZFaXdHTC82RkpGU0lPUkNLdlRFc0JxeW1ML1ZCTXY0c0NpLytnU1JVaURrU3Jpd0JNdjR2OWkvNVFpLzlRSndWTVVMQ0FBWUNNQUltS0FRRXhGa1F4RmlNSk9CQ0JCQkpFTVJZakNVazRFSUVFRWtSSk9CS0wveGRMQVE1RVN3RTRFU1FxWlVRWEVrUkxBVGdVTWdvU1JFdzRBREVBRWtRV0lxK3JpWW9CQURFQU1ncUwveFVpRGtRaXI0di9xNGovT2tpeE1RQ0wveGNrS21WRUY3SVJzaEt5RklFRXNoQWtzZ0d6aVlvQ0FZditpLzlRQVlBQllVeFFTYjFGQVVBQUJDY0VUSW1MQUw1RVZ3QWdUSW1LQXdHTC9ZditVRWtCZ0FGaFRGQkp2VVVCUUFBR2kvK0FBS1ZFaS8rTC9WQ0wvbENMQVV5L2l3Q0wvMUNBQkJscCtHVk1VTENBQVlDTUFJaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJhcmMyMDBfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzIwMF9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
