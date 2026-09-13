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

namespace Arc56.Generated.debojyoti10CC.turnstile.X402BatchSettlement_0807cba1
{


    public class X402BatchSettlementProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public X402BatchSettlementProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ChannelConfig : AVMObjectType
            {
                public Algorand.Address Payer { get; set; }

                public Algorand.Address PayerAuthorizer { get; set; }

                public Algorand.Address Receiver { get; set; }

                public Algorand.Address ReceiverAuthorizer { get; set; }

                public ulong Asset { get; set; }

                public ulong WithdrawDelay { get; set; }

                public byte[] Salt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayerAuthorizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayerAuthorizer.From(PayerAuthorizer);
                    ret.AddRange(vPayerAuthorizer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiverAuthorizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReceiverAuthorizer.From(ReceiverAuthorizer);
                    ret.AddRange(vReceiverAuthorizer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWithdrawDelay.From(WithdrawDelay);
                    ret.AddRange(vWithdrawDelay.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSalt.From(Salt);
                    ret.AddRange(vSalt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ChannelConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ChannelConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayerAuthorizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayerAuthorizer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayerAuthorizer = vPayerAuthorizer.ToValue();
                    if (valuePayerAuthorizer is Algorand.Address vPayerAuthorizerValue) { ret.PayerAuthorizer = vPayerAuthorizerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is Algorand.Address vReceiverValue) { ret.Receiver = vReceiverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiverAuthorizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiverAuthorizer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiverAuthorizer = vReceiverAuthorizer.ToValue();
                    if (valueReceiverAuthorizer is Algorand.Address vReceiverAuthorizerValue) { ret.ReceiverAuthorizer = vReceiverAuthorizerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawDelay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWithdrawDelay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWithdrawDelay = vWithdrawDelay.ToValue();
                    if (valueWithdrawDelay is ulong vWithdrawDelayValue) { ret.WithdrawDelay = vWithdrawDelayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSalt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSalt = vSalt.ToValue();
                    if (valueSalt is byte[] vSaltValue) { ret.Salt = vSaltValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ChannelConfig);
                }
                public bool Equals(ChannelConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ChannelConfig left, ChannelConfig right)
                {
                    return EqualityComparer<ChannelConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(ChannelConfig left, ChannelConfig right)
                {
                    return !(left == right);
                }

            }

            public class ChannelState : AVMObjectType
            {
                public Structs.ChannelConfig Config { get; set; } = new Structs.ChannelConfig();

                public ulong Balance { get; set; }

                public ulong TotalClaimed { get; set; }

                public ulong WithdrawRequestedAt { get; set; }

                public ulong WithdrawAmount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Config.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBalance.From(Balance);
                    ret.AddRange(vBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalClaimed.From(TotalClaimed);
                    ret.AddRange(vTotalClaimed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawRequestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWithdrawRequestedAt.From(WithdrawRequestedAt);
                    ret.AddRange(vWithdrawRequestedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWithdrawAmount.From(WithdrawAmount);
                    ret.AddRange(vWithdrawAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ChannelState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ChannelState();
                    uint count = 0;
                    ret.Config = Structs.ChannelConfig.Parse(queue.ToArray());
                    { var consumedConfig = ret.Config.ToByteArray().Length; for (int i = 0; i < consumedConfig && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBalance = vBalance.ToValue();
                    if (valueBalance is ulong vBalanceValue) { ret.Balance = vBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalClaimed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalClaimed = vTotalClaimed.ToValue();
                    if (valueTotalClaimed is ulong vTotalClaimedValue) { ret.TotalClaimed = vTotalClaimedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawRequestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWithdrawRequestedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWithdrawRequestedAt = vWithdrawRequestedAt.ToValue();
                    if (valueWithdrawRequestedAt is ulong vWithdrawRequestedAtValue) { ret.WithdrawRequestedAt = vWithdrawRequestedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWithdrawAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWithdrawAmount = vWithdrawAmount.ToValue();
                    if (valueWithdrawAmount is ulong vWithdrawAmountValue) { ret.WithdrawAmount = vWithdrawAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ChannelState);
                }
                public bool Equals(ChannelState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ChannelState left, ChannelState right)
                {
                    return EqualityComparer<ChannelState>.Default.Equals(left, right);
                }
                public static bool operator !=(ChannelState left, ChannelState right)
                {
                    return !(left == right);
                }

            }

            public class ChannelView : AVMObjectType
            {
                public ulong Balance { get; set; }

                public ulong TotalClaimed { get; set; }

                public ulong WithdrawRequestedAt { get; set; }

                public ulong WithdrawAmount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBalance.From(Balance);
                    ret.AddRange(vBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalClaimed.From(TotalClaimed);
                    ret.AddRange(vTotalClaimed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawRequestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWithdrawRequestedAt.From(WithdrawRequestedAt);
                    ret.AddRange(vWithdrawRequestedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWithdrawAmount.From(WithdrawAmount);
                    ret.AddRange(vWithdrawAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ChannelView Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ChannelView();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBalance = vBalance.ToValue();
                    if (valueBalance is ulong vBalanceValue) { ret.Balance = vBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalClaimed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalClaimed = vTotalClaimed.ToValue();
                    if (valueTotalClaimed is ulong vTotalClaimedValue) { ret.TotalClaimed = vTotalClaimedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawRequestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWithdrawRequestedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWithdrawRequestedAt = vWithdrawRequestedAt.ToValue();
                    if (valueWithdrawRequestedAt is ulong vWithdrawRequestedAtValue) { ret.WithdrawRequestedAt = vWithdrawRequestedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWithdrawAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWithdrawAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWithdrawAmount = vWithdrawAmount.ToValue();
                    if (valueWithdrawAmount is ulong vWithdrawAmountValue) { ret.WithdrawAmount = vWithdrawAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ChannelView);
                }
                public bool Equals(ChannelView? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ChannelView left, ChannelView right)
                {
                    return EqualityComparer<ChannelView>.Default.Equals(left, right);
                }
                public static bool operator !=(ChannelView left, ChannelView right)
                {
                    return !(left == right);
                }

            }

            public class ClaimArgClaims : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
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

                public static ClaimArgClaims Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ClaimArgClaims();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
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
                    return Equals(obj as ClaimArgClaims);
                }
                public bool Equals(ClaimArgClaims? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ClaimArgClaims left, ClaimArgClaims right)
                {
                    return EqualityComparer<ClaimArgClaims>.Default.Equals(left, right);
                }
                public static bool operator !=(ClaimArgClaims left, ClaimArgClaims right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Permissionless: anyone may pay the MBR to let the escrow hold an ASA.
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="mbr"> </param>
        public async Task OptInAsset(PaymentTransaction mbr, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr });
            byte[] abiHandle = { 0, 19, 74, 17 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, mbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInAsset_Transactions(PaymentTransaction mbr, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr });
            byte[] abiHandle = { 0, 19, 74, 17 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, mbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="config"> ChannelConfig</param>
        public async Task<byte[]> ChannelId(Structs.ChannelConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 125, 67, 84 };

            var result = await base.SimApp(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ChannelId_Transactions(Structs.ChannelConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 125, 67, 84 };

            return await base.MakeTransactionList(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="channel_id"> </param>
        /// <param name="max_claimable"> </param>
        public async Task<byte[]> VoucherMessage(byte[] channel_id, ulong max_claimable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 0, 67, 198 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);
            var max_claimableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_claimableAbi.From(max_claimable);

            var result = await base.SimApp(new List<object> { abiHandle, channel_idAbi, max_claimableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> VoucherMessage_Transactions(byte[] channel_id, ulong max_claimable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 0, 67, 198 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);
            var max_claimableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_claimableAbi.From(max_claimable);

            return await base.MakeTransactionList(new List<object> { abiHandle, channel_idAbi, max_claimableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="channel_id"> </param>
        public async Task<Structs.ChannelView> GetChannel(byte[] channel_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 82, 118, 204 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);

            var result = await base.SimApp(new List<object> { abiHandle, channel_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ChannelView.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetChannel_Transactions(byte[] channel_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 82, 118, 204 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, channel_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="asset"> </param>
        public async Task<ulong> GetUnsettled(Algorand.Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 86, 217, 119 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, receiverAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUnsettled_Transactions(Algorand.Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 86, 217, 119 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="config"> ChannelConfig</param>
        public async Task<ulong> OpenMbr(Structs.ChannelConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 106, 217, 60 };

            var result = await base.SimApp(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OpenMbr_Transactions(Structs.ChannelConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 106, 217, 60 };

            return await base.MakeTransactionList(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create the channel on first deposit, top it up afterwards.
        ///The app-call sender may be anyone (e.g. a fee-paying facilitator); the asset transfer MUST be signed by config.payer. When the channel box (or the receiver's unsettled box) does not exist yet, `mbr` must cover it; otherwise `mbr` may be a 0-amount payment.
        ///</summary>
        /// <param name="config"> ChannelConfig</param>
        /// <param name="xfer"> </param>
        /// <param name="mbr"> </param>
        public async Task<byte[]> Deposit(AssetTransferTransaction xfer, PaymentTransaction mbr, Structs.ChannelConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer, mbr });
            byte[] abiHandle = { 183, 173, 242, 111 };

            var result = await base.CallApp(new List<object> { abiHandle, config, xfer, mbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Deposit_Transactions(AssetTransferTransaction xfer, PaymentTransaction mbr, Structs.ChannelConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { xfer, mbr });
            byte[] abiHandle = { 183, 173, 242, 111 };

            return await base.MakeTransactionList(new List<object> { abiHandle, config, xfer, mbr }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Batch-claim vouchers. Accounting only; funds move in settle().
        ///Rows whose total_claimed does not exceed the on-chain value are no-ops, so a settler can safely retry a batch. Returns the total newly claimed amount.
        ///</summary>
        /// <param name="claims"> ClaimArgClaims</param>
        public async Task<ulong> Claim(Structs.ClaimArgClaims[] claims, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 247, 136, 247 };
            var claimsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ClaimArgClaims>(x => Structs.ClaimArgClaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; claimsAbi.From(claims);

            var result = await base.CallApp(new List<object> { abiHandle, claimsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Claim_Transactions(Structs.ClaimArgClaims[] claims, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 247, 136, 247 };
            var claimsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ClaimArgClaims>(x => Structs.ClaimArgClaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; claimsAbi.From(claims);

            return await base.MakeTransactionList(new List<object> { abiHandle, claimsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Permissionless sweep of claimed funds to the receiver.
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="asset"> </param>
        public async Task<ulong> Settle(Algorand.Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 83, 188, 218 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Settle_Transactions(Algorand.Address receiver, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 83, 188, 218 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cooperative refund by the receiver side. Caps to unclaimed escrow.
        ///</summary>
        /// <param name="channel_id"> </param>
        /// <param name="amount"> </param>
        public async Task<ulong> Refund(byte[] channel_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 184, 132, 31 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, channel_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Refund_Transactions(byte[] channel_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 184, 132, 31 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, channel_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="channel_id"> </param>
        /// <param name="amount"> </param>
        public async Task<ulong> InitiateWithdraw(byte[] channel_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 97, 204, 137 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, channel_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InitiateWithdraw_Transactions(byte[] channel_id, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 97, 204, 137 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, channel_idAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="channel_id"> </param>
        public async Task<ulong> FinalizeWithdraw(byte[] channel_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 19, 221, 177 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);

            var result = await base.CallApp(new List<object> { abiHandle, channel_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FinalizeWithdraw_Transactions(byte[] channel_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 19, 221, 177 };
            var channel_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); channel_idAbi.From(channel_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, channel_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWDQwMkJhdGNoU2V0dGxlbWVudCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDaGFubmVsQ29uZmlnIjpbeyJuYW1lIjoicGF5ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBheWVyX2F1dGhvcml6ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJyZWNlaXZlcl9hdXRob3JpemVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3aXRoZHJhd19kZWxheSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzYWx0IiwidHlwZSI6ImJ5dGVbMzJdIn1dLCJDaGFubmVsU3RhdGUiOlt7Im5hbWUiOiJjb25maWciLCJ0eXBlIjoiQ2hhbm5lbENvbmZpZyJ9LHsibmFtZSI6ImJhbGFuY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfY2xhaW1lZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3aXRoZHJhd19yZXF1ZXN0ZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2l0aGRyYXdfYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9XSwiQ2hhbm5lbFZpZXciOlt7Im5hbWUiOiJiYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX2NsYWltZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2l0aGRyYXdfcmVxdWVzdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IndpdGhkcmF3X2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifV0sIkNsYWltQXJnQ2xhaW1zIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJieXRlWzY0XSJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoib3B0X2luX2Fzc2V0IiwiZGVzYyI6IlBlcm1pc3Npb25sZXNzOiBhbnlvbmUgbWF5IHBheSB0aGUgTUJSIHRvIGxldCB0aGUgZXNjcm93IGhvbGQgYW4gQVNBLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoYW5uZWxfaWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCxieXRlWzMyXSkiLCJzdHJ1Y3QiOiJDaGFubmVsQ29uZmlnIiwibmFtZSI6ImNvbmZpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3VjaGVyX21lc3NhZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfY2xhaW1hYmxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY2hhbm5lbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJDaGFubmVsVmlldyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Vuc2V0dGxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcGVuX21iciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDY0LGJ5dGVbMzJdKSIsInN0cnVjdCI6IkNoYW5uZWxDb25maWciLCJuYW1lIjoiY29uZmlnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6IkNyZWF0ZSB0aGUgY2hhbm5lbCBvbiBmaXJzdCBkZXBvc2l0LCB0b3AgaXQgdXAgYWZ0ZXJ3YXJkcy5cblRoZSBhcHAtY2FsbCBzZW5kZXIgbWF5IGJlIGFueW9uZSAoZS5nLiBhIGZlZS1wYXlpbmcgZmFjaWxpdGF0b3IpOyB0aGUgYXNzZXQgdHJhbnNmZXIgTVVTVCBiZSBzaWduZWQgYnkgY29uZmlnLnBheWVyLiBXaGVuIHRoZSBjaGFubmVsIGJveCAob3IgdGhlIHJlY2VpdmVyJ3MgdW5zZXR0bGVkIGJveCkgZG9lcyBub3QgZXhpc3QgeWV0LCBgbWJyYCBtdXN0IGNvdmVyIGl0OyBvdGhlcndpc2UgYG1icmAgbWF5IGJlIGEgMC1hbW91bnQgcGF5bWVudC4iLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCxieXRlWzMyXSkiLCJzdHJ1Y3QiOiJDaGFubmVsQ29uZmlnIiwibmFtZSI6ImNvbmZpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4ZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltIiwiZGVzYyI6IkJhdGNoLWNsYWltIHZvdWNoZXJzLiBBY2NvdW50aW5nIG9ubHk7IGZ1bmRzIG1vdmUgaW4gc2V0dGxlKCkuXG5Sb3dzIHdob3NlIHRvdGFsX2NsYWltZWQgZG9lcyBub3QgZXhjZWVkIHRoZSBvbi1jaGFpbiB2YWx1ZSBhcmUgbm8tb3BzLCBzbyBhIHNldHRsZXIgY2FuIHNhZmVseSByZXRyeSBhIGJhdGNoLiBSZXR1cm5zIHRoZSB0b3RhbCBuZXdseSBjbGFpbWVkIGFtb3VudC4iLCJhcmdzIjpbeyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCxieXRlWzY0XSx1aW50NjQpW10iLCJzdHJ1Y3QiOiJDbGFpbUFyZ0NsYWltcyIsIm5hbWUiOiJjbGFpbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXR0bGUiLCJkZXNjIjoiUGVybWlzc2lvbmxlc3Mgc3dlZXAgb2YgY2xhaW1lZCBmdW5kcyB0byB0aGUgcmVjZWl2ZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWZ1bmQiLCJkZXNjIjoiQ29vcGVyYXRpdmUgcmVmdW5kIGJ5IHRoZSByZWNlaXZlciBzaWRlLiBDYXBzIHRvIHVuY2xhaW1lZCBlc2Nyb3cuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdGlhdGVfd2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmaW5hbGl6ZV93aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3MV0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgb3B0ZWQgaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTldLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzNl0sImVycm9yTWVzc2FnZSI6ImJhZCB2b3VjaGVyIHNpZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Miw1MDUsNzM2LDk4NywxMTY5LDEyNDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNoYW5uZWxzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2NSw5MjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVuc2V0dGxlZCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzBdLCJlcnJvck1lc3NhZ2UiOiJjbGF3YmFjayBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1NF0sImVycm9yTWVzc2FnZSI6ImNsb3NlX3RvIHNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxM10sImVycm9yTWVzc2FnZSI6ImNvbmZpZyBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxM10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIyLDg0OF0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHNtYXJ0X2NvbnRyYWN0cy54NDAyX2JhdGNoX3NldHRsZW1lbnQuY29udHJhY3QuQ2xhaW0+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMyLDI2NywzMTUsOTAwLDk2NiwxMTM3LDEyNDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwLDI0MSwzMjQsOTA5LDk3NSwxMTQ5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE0LDM1MywzNzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzLng0MDJfYmF0Y2hfc2V0dGxlbWVudC5jb250cmFjdC5DaGFubmVsQ29uZmlnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAzXSwiZXJyb3JNZXNzYWdlIjoibWF4X2NsYWltYWJsZSA+IGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODYsNDg5XSwiZXJyb3JNZXNzYWdlIjoibWJyIGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OCw0NzhdLCJlcnJvck1lc3NhZ2UiOiJtYnIgcmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjY1XSwiZXJyb3JNZXNzYWdlIjoibm8gd2l0aGRyYXcgcGVuZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MjRdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjUsMTAxNl0sImVycm9yTWVzc2FnZSI6Im5vdCByZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyNV0sImVycm9yTWVzc2FnZSI6Im5vdGhpbmcgdG8gc2V0dGxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY5XSwiZXJyb3JNZXNzYWdlIjoicGF5ZXIgPT0gcmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQ1XSwiZXJyb3JNZXNzYWdlIjoicmVmdW5kIG5vIGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjJdLCJlcnJvck1lc3NhZ2UiOiJyZWtleSBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTJdLCJlcnJvck1lc3NhZ2UiOiJ0b3RhbCA+IG1heF9jbGFpbWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxLDM5N10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIwMV0sImVycm9yTWVzc2FnZSI6IndpdGhkcmF3IGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNzddLCJlcnJvck1lc3NhZ2UiOiJ3aXRoZHJhdyBkZWxheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1NV0sImVycm9yTWVzc2FnZSI6IndpdGhkcmF3IGRlbGF5IHJhbmdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI3XSwiZXJyb3JNZXNzYWdlIjoieGZlciByZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzOF0sImVycm9yTWVzc2FnZSI6InhmZXIgc2VuZGVyICE9IHBheWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQ2XSwiZXJyb3JNZXNzYWdlIjoiemVybyBkZXBvc2l0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNVGMySURNeUlERTROQ0F4TWpnZ01UTTJDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdNSGcyTXlBd2VEYzFJQ0lpSURCNE1EWTRNVEF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QmpiR0Z6Y3lCWU5EQXlRbUYwWTJoVFpYUjBiR1Z0Wlc1MEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeU1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1EQXhNelJoTVRFZ01IZ3laRGRrTkRNMU5DQXdlRGd6TURBME0yTTJJREI0T1RrMU1qYzJZMk1nTUhoa1l6VTJaRGszTnlBd2VHVmxObUZrT1ROaklEQjRZamRoWkdZeU5tWWdNSGhsTkdZM09EaG1OeUF3ZURsbU5UTmlZMlJoSURCNE1XRmlPRGcwTVdZZ01IZzJORFl4WTJNNE9TQXdlR0V6TVROa1pHSXhJQzh2SUcxbGRHaHZaQ0FpYjNCMFgybHVYMkZ6YzJWMEtIVnBiblEyTkN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyaGhibTVsYkY5cFpDZ29ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYk16SmRLU2xpZVhSbFd6TXlYU0lzSUcxbGRHaHZaQ0FpZG05MVkyaGxjbDl0WlhOellXZGxLR0o1ZEdWYk16SmRMSFZwYm5RMk5DbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0ltZGxkRjlqYUdGdWJtVnNLR0o1ZEdWYk16SmRLU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUmZkVzV6WlhSMGJHVmtLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWIzQmxibDl0WW5Jb0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeGllWFJsV3pNeVhTa3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmtaWEJ2YzJsMEtDaGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZzek1sMHBMR0Y0Wm1WeUxIQmhlU2xpZVhSbFd6TXlYU0lzSUcxbGRHaHZaQ0FpWTJ4aGFXMG9LR0o1ZEdWYk16SmRMSFZwYm5RMk5DeGllWFJsV3pZMFhTeDFhVzUwTmpRcFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnpaWFIwYkdVb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WldaMWJtUW9ZbmwwWlZzek1sMHNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWFXNXBkR2xoZEdWZmQybDBhR1J5WVhjb1lubDBaVnN6TWwwc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWm1sdVlXeHBlbVZmZDJsMGFHUnlZWGNvWW5sMFpWc3pNbDBwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYjNCMFgybHVYMkZ6YzJWMElHTm9ZVzV1Wld4ZmFXUWdkbTkxWTJobGNsOXRaWE56WVdkbElHZGxkRjlqYUdGdWJtVnNJR2RsZEY5MWJuTmxkSFJzWldRZ2IzQmxibDl0WW5JZ1pHVndiM05wZENCamJHRnBiU0J6WlhSMGJHVWdjbVZtZFc1a0lHbHVhWFJwWVhSbFgzZHBkR2hrY21GM0lHWnBibUZzYVhwbFgzZHBkR2hrY21GM0NpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF1WTI5dWRISmhZM1F1V0RRd01rSmhkR05vVTJWMGRHeGxiV1Z1ZEM1dmNIUmZhVzVmWVhOelpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0hSZmFXNWZZWE56WlhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPamc1TFRrd0NpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMU0J6WlhSMWNBb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCaGMzTmxjblFnYm05MElFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNdWFYTmZiM0IwWldSZmFXNG9ZWE56WlhRcExDQWlZV3h5WldGa2VTQnZjSFJsWkNCcGJpSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCaGJISmxZV1I1SUc5d2RHVmtJR2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QmhjM05sY25RZ2JXSnlMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKdFluSWdjbVZqWldsMlpYSWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdFluSWdjbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUdGemMyVnlkQ0J0WW5JdVlXMXZkVzUwSUQ0OUlFRlRVMFZVWDA5UVZGOUpUbDlOUWxJc0lDSnRZbklnWVcxdmRXNTBJZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNQW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCdFluSWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPamsyTFRFd01Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZPVGdLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG81T1FvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T1RZdE1UQXhDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHdMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T0RrdE9UQUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0SUhObGRIVndDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTG1OdmJuUnlZV04wTGxnME1ESkNZWFJqYUZObGRIUnNaVzFsYm5RdVkyaGhibTVsYkY5cFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5vWVc1dVpXeGZhV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdNeTB4TURRS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdElIWnBaWGR6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVGMyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMbU52Ym5SeVlXTjBMa05vWVc1dVpXeERiMjVtYVdjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVEEyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdRbmwwWlhNek1pNW1jbTl0WDJKNWRHVnpLSE5sYkdZdVgyTm9ZVzV1Wld4ZmFXUW9ZMjl1Wm1sbktTa0tJQ0FnSUdOaGJHeHpkV0lnWDJOb1lXNXVaV3hmYVdRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3hNRE10TVRBMENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTQjJhV1YzY3dvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmcwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM1amIyNTBjbUZqZEM1WU5EQXlRbUYwWTJoVFpYUjBiR1Z0Wlc1MExuWnZkV05vWlhKZmJXVnpjMkZuWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWnZkV05vWlhKZmJXVnpjMkZuWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVEE0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVEV3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTW9jMlZzWmk1ZmRtOTFZMmhsY2w5dFpYTnpZV2RsS0dOb1lXNXVaV3hmYVdRdVlubDBaWE1zSUcxaGVGOWpiR0ZwYldGaWJHVXVZWE5mZFdsdWREWTBLQ2twS1FvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQmZkbTkxWTJobGNsOXRaWE56WVdkbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF1WTI5dWRISmhZM1F1V0RRd01rSmhkR05vVTJWMGRHeGxiV1Z1ZEM1blpYUmZZMmhoYm01bGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5amFHRnVibVZzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXhOQW9nSUNBZ0x5OGdjM1FnUFNCelpXeG1MbU5vWVc1dVpXeHpXMk5vWVc1dVpXeGZhV1F1WW5sMFpYTmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ob1lXNXVaV3h6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94TVRZS0lDQWdJQzh2SUdKaGJHRnVZMlU5YzNRdVltRnNZVzVqWlN3S0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXhOellnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3hNVGNLSUNBZ0lDOHZJSFJ2ZEdGc1gyTnNZV2x0WldROWMzUXVkRzkwWVd4ZlkyeGhhVzFsWkN3S0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREU0TkNBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnZDJsMGFHUnlZWGRmY21WeGRXVnpkR1ZrWDJGMFBYTjBMbmRwZEdoa2NtRjNYM0psY1hWbGMzUmxaRjloZEN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREU1TWlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV4T1FvZ0lDQWdMeThnZDJsMGFHUnlZWGRmWVcxdmRXNTBQWE4wTG5kcGRHaGtjbUYzWDJGdGIzVnVkQ3dLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F5TURBZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94TVRVdE1USXdDaUFnSUNBdkx5QnlaWFIxY200Z1EyaGhibTVsYkZacFpYY29DaUFnSUNBdkx5QWdJQ0FnWW1Gc1lXNWpaVDF6ZEM1aVlXeGhibU5sTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDJOc1lXbHRaV1E5YzNRdWRHOTBZV3hmWTJ4aGFXMWxaQ3dLSUNBZ0lDOHZJQ0FnSUNCM2FYUm9aSEpoZDE5eVpYRjFaWE4wWldSZllYUTljM1F1ZDJsMGFHUnlZWGRmY21WeGRXVnpkR1ZrWDJGMExBb2dJQ0FnTHk4Z0lDQWdJSGRwZEdoa2NtRjNYMkZ0YjNWdWREMXpkQzUzYVhSb1pISmhkMTloYlc5MWJuUXNDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXhNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzVqYjI1MGNtRmpkQzVZTkRBeVFtRjBZMmhUWlhSMGJHVnRaVzUwTG1kbGRGOTFibk5sZEhSc1pXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmRXNXpaWFIwYkdWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94TWpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95T1RjS0lDQWdJQzh2SUhKbGRIVnliaUJ5WldObGFYWmxjaTVpZVhSbGN5QXJJRzl3TG1sMGIySW9ZWE56WlhRdWFXUXBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1USTBDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTUxYm5ObGRIUnNaV1F1WjJWMEtITmxiR1l1WDNWdWMyVjBkR3hsWkY5clpYa29jbVZqWldsMlpYSXNJR0Z6YzJWMEtTd2daR1ZtWVhWc2REMVZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXlNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzVqYjI1MGNtRmpkQzVZTkRBeVFtRjBZMmhUWlhSMGJHVnRaVzUwTG05d1pXNWZiV0p5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzQmxibDl0WW5JNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUzTmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdjMjFoY25SZlkyOXVkSEpoWTNSekxuZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzVqYjI1MGNtRmpkQzVEYUdGdWJtVnNRMjl1Wm1sbkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV5T0FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVgyOXdaVzVmYldKeUtHTnZibVpwWnlrS0lDQWdJR05oYkd4emRXSWdYMjl3Wlc1ZmJXSnlDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MExtTnZiblJ5WVdOMExsZzBNREpDWVhSamFGTmxkSFJzWlcxbGJuUXVaR1Z3YjNOcGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsY0c5emFYUTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV6TUMweE16RUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTQmtaWEJ2YzJsMGN3b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklERTNOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TG5nME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDNWpiMjUwY21GamRDNURhR0Z1Ym1Wc1EyOXVabWxuQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhlR1psY2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z1kybGtJRDBnYzJWc1ppNWZZMmhoYm01bGJGOXBaQ2hqYjI1bWFXY3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdYMk5vWVc1dVpXeGZhV1FLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG96TVRJS0lDQWdJQzh2SUdGemMyVnlkQ0I0Wm1WeUxuaG1aWEpmWVhOelpYUXVhV1FnUFQwZ1kyOXVabWxuTG1GemMyVjBMbUZ6WDNWcGJuUTJOQ2dwTENBaVlYTnpaWFFnYldsemJXRjBZMmdpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFl5QTFJQzh2SURFeU9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TXpFekNpQWdJQ0F2THlCaGMzTmxjblFnZUdabGNpNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWllR1psY2lCeVpXTmxhWFpsY2lJS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjRabVZ5SUhKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qTXhOQW9nSUNBZ0x5OGdZWE56WlhKMElIaG1aWEl1YzJWdVpHVnlJRDA5SUdOdmJtWnBaeTV3WVhsbGNpNXVZWFJwZG1Vc0lDSjRabVZ5SUhObGJtUmxjaUFoUFNCd1lYbGxjaUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2VHWmxjaUJ6Wlc1a1pYSWdJVDBnY0dGNVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TXpFMUNpQWdJQ0F2THlCaGMzTmxjblFnZUdabGNpNWhjM05sZEY5aGJXOTFiblFnUGlBd0xDQWllbVZ5YnlCa1pYQnZjMmwwSWdvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lHRnpjMlZ5ZENBdkx5QjZaWEp2SUdSbGNHOXphWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk16RTJDaUFnSUNBdkx5QmhjM05sY25RZ2VHWmxjaTVoYzNObGRGOWpiRzl6WlY5MGJ5QTlQU0JIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56TENBaVkyeHZjMlZmZEc4Z2MyVjBJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUVGemMyVjBRMnh2YzJWVWJ3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHTnNiM05sWDNSdklITmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvek1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCNFptVnlMbkpsYTJWNVgzUnZJRDA5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0lDSnlaV3RsZVNCelpYUWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1ozUjRibk1nVW1WclpYbFVid29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSEpsYTJWNUlITmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvek1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCNFptVnlMbUZ6YzJWMFgzTmxibVJsY2lBOVBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQ0FpWTJ4aGQySmhZMnNnYm05MElHRnNiRzkzWldRaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHZDBlRzV6SUVGemMyVjBVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyeGhkMkpoWTJzZ2JtOTBJR0ZzYkc5M1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRRM0NpQWdJQ0F2THlCaGMzTmxjblFnYldKeUxuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0p0WW5JZ2NtVmpaV2wyWlhJaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUcxaWNpQnlaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUdGemMyVnlkQ0J0WW5JdVlXMXZkVzUwSUQ0OUlITmxiR1l1WDI5d1pXNWZiV0p5S0dOdmJtWnBaeWtzSUNKdFluSWdZVzF2ZFc1MElnb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjl2Y0dWdVgyMWljZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnRZbklnWVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMU1Bb2dJQ0FnTHk4Z2FXWWdZMmxrSUdsdUlITmxiR1l1WTJoaGJtNWxiSE02Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TmpNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdSbGNHOXphWFJmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVFV4Q2lBZ0lDQXZMeUJ6ZENBOUlITmxiR1l1WTJoaGJtNWxiSE5iWTJsa1hTNWpiM0I1S0NrS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyaGhibTVsYkhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhOMExtTnZibVpwWnlBOVBTQmpiMjVtYVdjc0lDSmpiMjVtYVdjZ2JXbHpiV0YwWTJnaUNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4TnpZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCamIyNW1hV2NnYldsemJXRjBZMmdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1UVXpDaUFnSUNBdkx5QnpkQzVpWVd4aGJtTmxJRDBnWVhKak5DNVZTVzUwTmpRb2MzUXVZbUZzWVc1alpTNWhjMTkxYVc1ME5qUW9LU0FySUhobVpYSXVZWE56WlhSZllXMXZkVzUwS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREUzTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94TlRNdE1UVTBDaUFnSUNBdkx5QnpkQzVpWVd4aGJtTmxJRDBnWVhKak5DNVZTVzUwTmpRb2MzUXVZbUZzWVc1alpTNWhjMTkxYVc1ME5qUW9LU0FySUhobVpYSXVZWE56WlhSZllXMXZkVzUwS1FvZ0lDQWdMeThnYzJWc1ppNWphR0Z1Ym1Wc2MxdGphV1JkSUQwZ2MzUXVZMjl3ZVNncENpQWdJQ0JwYm5Salh6SWdMeThnTVRjMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29LWkdWd2IzTnBkRjloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE16QXRNVE14Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBnWkdWd2IzTnBkSE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taR1Z3YjNOcGRGOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QmtaV3hoZVNBOUlHTnZibVpwWnk1M2FYUm9aSEpoZDE5a1pXeGhlUzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVE0yQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVFUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdaR1ZzWVhrZ1BqMGdUVWxPWDFkSlZFaEVVa0ZYWDBSRlRFRlpJR0Z1WkNCa1pXeGhlU0E4UFNCTlFWaGZWMGxVU0VSU1FWZGZSRVZNUVZrc0lDSjNhWFJvWkhKaGR5QmtaV3hoZVNCeVlXNW5aU0lLSUNBZ0lIQjFjMmhwYm5RZ09UQXdDaUFnSUNBK1BRb2dJQ0FnWW5vZ1pHVndiM05wZEY5aWIyOXNYMlpoYkhObFFEWUtJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURJMU9USXdNREFLSUNBZ0lEdzlDaUFnSUNCaWVpQmtaWEJ2YzJsMFgySnZiMnhmWm1Gc2MyVkFOZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtDbVJsY0c5emFYUmZZbTl2YkY5dFpYSm5aVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtaV3hoZVNBK1BTQk5TVTVmVjBsVVNFUlNRVmRmUkVWTVFWa2dZVzVrSUdSbGJHRjVJRHc5SUUxQldGOVhTVlJJUkZKQlYxOUVSVXhCV1N3Z0luZHBkR2hrY21GM0lHUmxiR0Y1SUhKaGJtZGxJZ29nSUNBZ1lYTnpaWEowSUM4dklIZHBkR2hrY21GM0lHUmxiR0Y1SUhKaGJtZGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJtWnBaeTV3WVhsbGNpQWhQU0JqYjI1bWFXY3VjbVZqWldsMlpYSXNJQ0p3WVhsbGNpQTlQU0J5WldObGFYWmxjaUlLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjVaWElnUFQwZ2NtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJpWVd4aGJtTmxQV0Z5WXpRdVZVbHVkRFkwS0hobVpYSXVZWE56WlhSZllXMXZkVzUwS1N3S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklIUnZkR0ZzWDJOc1lXbHRaV1E5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1UVTVMVEUyTlFvZ0lDQWdMeThnYzJWc1ppNWphR0Z1Ym1Wc2MxdGphV1JkSUQwZ1EyaGhibTVsYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUdOdmJtWnBaejFqYjI1bWFXY3VZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJR0poYkdGdVkyVTlZWEpqTkM1VlNXNTBOalFvZUdabGNpNWhjM05sZEY5aGJXOTFiblFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDJOc1lXbHRaV1E5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZDJsMGFHUnlZWGRmY21WeGRXVnpkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIZHBkR2hrY21GM1gyRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qRTJOZ29nSUNBZ0x5OGdkV3RsZVNBOUlITmxiR1l1WDNWdWMyVjBkR3hsWkY5clpYa29ZMjl1Wm1sbkxuSmxZMlZwZG1WeUxtNWhkR2wyWlN3Z1FYTnpaWFFvWTI5dVptbG5MbUZ6YzJWMExtRnpYM1ZwYm5RMk5DZ3BLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1qazNDaUFnSUNBdkx5QnlaWFIxY200Z2NtVmpaV2wyWlhJdVlubDBaWE1nS3lCdmNDNXBkRzlpS0dGemMyVjBMbWxrS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakUyTndvZ0lDQWdMeThnYVdZZ2RXdGxlU0J1YjNRZ2FXNGdjMlZzWmk1MWJuTmxkSFJzWldRNkNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3hOamdLSUNBZ0lDOHZJSE5sYkdZdWRXNXpaWFIwYkdWa1czVnJaWGxkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEUUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHSWdaR1Z3YjNOcGRGOWhablJsY2w5cFpsOWxiSE5sUURFd0NncGtaWEJ2YzJsMFgySnZiMnhmWm1Gc2MyVkFOam9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHUmxjRzl6YVhSZlltOXZiRjl0WlhKblpVQTNDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5nME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDNWpiMjUwY21GamRDNVlOREF5UW1GMFkyaFRaWFIwYkdWdFpXNTBMbU5zWVdsdFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnhoYVcwNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3YmlBMENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRjeExURTNNZ29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0SUdOc1lXbHRjd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNVElLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHh6YldGeWRGOWpiMjUwY21GamRITXVlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTG1OdmJuUnlZV04wTGtOc1lXbHRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE9ERUtJQ0FnSUM4dklHVnVjM1Z5WlY5aWRXUm5aWFFvYmlBcUlDaEZSREkxTlRFNVgwTlBVMVFnS3lCUVJWSmZVazlYWDA5V1JWSklSVUZFS1N3Z1QzQlZjRVpsWlZOdmRYSmpaUzVIY205MWNFTnlaV1JwZENrS0lDQWdJSEIxYzJocGJuUWdNall3TUFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnS3dvS1kyeGhhVzFmZDJocGJHVmZkRzl3UURFek9nb2dJQ0FnWkhWd0NpQWdJQ0JuYkc5aVlXd2dUM0JqYjJSbFFuVmtaMlYwQ2lBZ0lDQStDaUFnSUNCaWVpQmpiR0ZwYlY5aFpuUmxjbDkzYUdsc1pVQXhPQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QkVaV3hsZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dOamd4TURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2NtOTJZV3hRY205bmNtRnRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNRFk0TVRBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaUlHTnNZV2x0WDNkb2FXeGxYM1J2Y0VBeE13b0tZMnhoYVcxZllXWjBaWEpmZDJocGJHVkFNVGc2Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1UZ3lDaUFnSUNBdkx5QjBiM1JoYkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVGd6Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9iaWs2Q2lBZ0lDQmtkWEFLQ21Oc1lXbHRYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVGd6Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9iaWs2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQmpiR0ZwYlY5aFpuUmxjbDltYjNKQU1URUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRnMExURTROUW9nSUNBZ0x5OGdjbTkzSUQwZ1kyeGhhVzF6VzJsZExtTnZjSGtvS1FvZ0lDQWdMeThnWTJsa0lEMGdjbTkzTG1Ob1lXNXVaV3hmYVdRdVlubDBaWE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01URXlDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJREV4TWdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UTUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFNE5nb2dJQ0FnTHk4Z2MzUWdQU0J6Wld4bUxtTm9ZVzV1Wld4elcyTnBaRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROak1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTJoaGJtNWxiSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakU0T1FvZ0lDQWdMeThnVkhodUxuTmxibVJsY2lBOVBTQmpabWN1Y21WalpXbDJaWEpmWVhWMGFHOXlhWHBsY2k1dVlYUnBkbVVnYjNJZ1ZIaHVMbk5sYm1SbGNpQTlQU0JqWm1jdWNtVmpaV2wyWlhJdWJtRjBhWFpsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ01UYzJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFFLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lEMDlDaUFnSUNCaWJub2dZMnhoYVcxZlltOXZiRjkwY25WbFFEVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnUFQwS0lDQWdJR0o2SUdOc1lXbHRYMkp2YjJ4ZlptRnNjMlZBTmdvS1kyeGhhVzFmWW05dmJGOTBjblZsUURVNkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvS1kyeGhhVzFmWW05dmJGOXRaWEpuWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94T0RndE1Ua3dDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJRlI0Ymk1elpXNWtaWElnUFQwZ1kyWm5MbkpsWTJWcGRtVnlYMkYxZEdodmNtbDZaWEl1Ym1GMGFYWmxJRzl5SUZSNGJpNXpaVzVrWlhJZ1BUMGdZMlpuTG5KbFkyVnBkbVZ5TG01aGRHbDJaUW9nSUNBZ0x5OGdLU3dnSW01dmRDQnlaV05sYVhabGNpSUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCdFlYaGZZeUE5SUhKdmR5NXRZWGhmWTJ4aGFXMWhZbXhsTG1GelgzVnBiblEyTkNncENpQWdJQ0JrYVdjZ01USUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qRTVNZ29nSUNBZ0x5OGdibVYzWDNSdmRHRnNJRDBnY205M0xuUnZkR0ZzWDJOc1lXbHRaV1F1WVhOZmRXbHVkRFkwS0NrS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXhNRFFnT0FvZ0lDQWdZblZ5ZVNBeE13b2dJQ0FnY0hWemFHbHVkQ0F4TURRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94T1RNS0lDQWdJQzh2SUdGemMyVnlkQ0J1WlhkZmRHOTBZV3dnUEQwZ2JXRjRYMk1zSUNKMGIzUmhiQ0ErSUcxaGVGOWpiR0ZwYldGaWJHVWlDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSdmRHRnNJRDRnYldGNFgyTnNZV2x0WVdKc1pRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94T1RRS0lDQWdJQzh2SUdGemMyVnlkQ0J0WVhoZll5QThQU0J6ZEM1aVlXeGhibU5sTG1GelgzVnBiblEyTkNncExDQWliV0Y0WDJOc1lXbHRZV0pzWlNBK0lHSmhiR0Z1WTJVaUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREUzTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCdFlYaGZZMnhoYVcxaFlteGxJRDRnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE9UVUtJQ0FnSUM4dklHbG1JRzVsZDE5MGIzUmhiQ0ErSUhOMExuUnZkR0ZzWDJOc1lXbHRaV1F1WVhOZmRXbHVkRFkwS0NrNkNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5SaklEUWdMeThnTVRnMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEY0tJQ0FnSUQ0S0lDQWdJR0o2SUdOc1lXbHRYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUcxelp5QTlJSE5sYkdZdVgzWnZkV05vWlhKZmJXVnpjMkZuWlNoamFXUXNJRzFoZUY5aktRb2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QTNDaUFnSUNCallXeHNjM1ZpSUY5MmIzVmphR1Z5WDIxbGMzTmhaMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1UazNDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVaV1F5TlRVeE9YWmxjbWxtZVY5aVlYSmxLRzF6Wnl3Z2NtOTNMbk5wWjI1aGRIVnlaUzVpZVhSbGN5d2dZMlpuTG5CaGVXVnlYMkYxZEdodmNtbDZaWEl1WW5sMFpYTXBMQ0FpWW1Ga0lIWnZkV05vWlhJZ2MybG5JZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQmxlSFJ5WVdOMElEUXdJRFkwQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWldReU5UVXhPWFpsY21sbWVWOWlZWEpsQ2lBZ0lDQmhjM05sY25RZ0x5OGdZbUZrSUhadmRXTm9aWElnYzJsbkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakU1T0FvZ0lDQWdMeThnWkdWc2RHRWdQU0J1WlhkZmRHOTBZV3dnTFNCemRDNTBiM1JoYkY5amJHRnBiV1ZrTG1GelgzVnBiblEyTkNncENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkdsbklEWUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNVGs1TFRJd01Bb2dJQ0FnTHk4Z2MzUXVkRzkwWVd4ZlkyeGhhVzFsWkNBOUlHRnlZelF1VlVsdWREWTBLRzVsZDE5MGIzUmhiQ2tLSUNBZ0lDOHZJSE5sYkdZdVkyaGhibTVsYkhOYlkybGtYU0E5SUhOMExtTnZjSGtvS1FvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdNZ05DQXZMeUF4T0RRS0lDQWdJR1JwWnlBeE13b2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1qQXhDaUFnSUNBdkx5QjFhMlY1SUQwZ2MyVnNaaTVmZFc1elpYUjBiR1ZrWDJ0bGVTaGpabWN1Y21WalpXbDJaWEl1Ym1GMGFYWmxMQ0JCYzNObGRDaGpabWN1WVhOelpYUXVZWE5mZFdsdWREWTBLQ2twS1FvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBeE1qZ2dPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU9UY0tJQ0FnSUM4dklISmxkSFZ5YmlCeVpXTmxhWFpsY2k1aWVYUmxjeUFySUc5d0xtbDBiMklvWVhOelpYUXVhV1FwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNakF5Q2lBZ0lDQXZMeUJ6Wld4bUxuVnVjMlYwZEd4bFpGdDFhMlY1WFNBclBTQmtaV3gwWVFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkVzV6WlhSMGJHVmtJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNakF6Q2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0JrWld4MFlRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDZ3BqYkdGcGJWOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakU0TXdvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLRzRwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ1kyeGhhVzFmWm05eVgyaGxZV1JsY2tBeUNncGpiR0ZwYlY5aWIyOXNYMlpoYkhObFFEWTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCamJHRnBiVjlpYjI5c1gyMWxjbWRsUURjS0NtTnNZV2x0WDJGbWRHVnlYMlp2Y2tBeE1Ub0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG94TnpFdE1UY3lDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBnWTJ4aGFXMXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTG1OdmJuUnlZV04wTGxnME1ESkNZWFJqYUZObGRIUnNaVzFsYm5RdWMyVjBkR3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBkR3hsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lNRFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95T1RjS0lDQWdJQzh2SUhKbGRIVnliaUJ5WldObGFYWmxjaTVpZVhSbGN5QXJJRzl3TG1sMGIySW9ZWE56WlhRdWFXUXBDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1qRXdDaUFnSUNBdkx5QmhiVzkxYm5RZ1BTQnpaV3htTG5WdWMyVjBkR3hsWkZ0MWEyVjVYUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRGMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRXNXpaWFIwYkdWa0lHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU1URUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblFnUGlBd0xDQWlibTkwYUdsdVp5QjBieUJ6WlhSMGJHVWlDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUm9hVzVuSUhSdklITmxkSFJzWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lNVElLSUNBZ0lDOHZJSE5sYkdZdWRXNXpaWFIwYkdWa1czVnJaWGxkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSXhNd29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLSGhtWlhKZllYTnpaWFE5WVhOelpYUXNJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYSmxZMlZwZG1WeUxDQmhjM05sZEY5aGJXOTFiblE5WVcxdmRXNTBMQ0JtWldVOU1Da3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdZWGhtWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpBMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMbU52Ym5SeVlXTjBMbGcwTURKQ1lYUmphRk5sZEhSc1pXMWxiblF1Y21WbWRXNWtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbWRXNWtPZ29nSUNBZ1lubDBaV05mTXlBdkx5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU1UWXRNakUzQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0SUhKbFpuVnVaSE1nTHlCbGVHbDBjd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl5TVFvZ0lDQWdMeThnYzNRZ1BTQnpaV3htTG1Ob1lXNXVaV3h6VzJOcFpGMHVZMjl3ZVNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qTUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyaGhibTVsYkhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeU5Bb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpQTlQU0JqWm1jdWNtVmpaV2wyWlhKZllYVjBhRzl5YVhwbGNpNXVZWFJwZG1VZ2IzSWdWSGh1TG5ObGJtUmxjaUE5UFNCalptY3VjbVZqWldsMlpYSXVibUYwYVhabENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNVGMyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WbWRXNWtYMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1BUMEtJQ0FnSUdKNklISmxablZ1WkY5aWIyOXNYMlpoYkhObFFEUUtDbkpsWm5WdVpGOWliMjlzWDNSeWRXVkFNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3B5WldaMWJtUmZZbTl2YkY5dFpYSm5aVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lNak10TWpJMUNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lGUjRiaTV6Wlc1a1pYSWdQVDBnWTJabkxuSmxZMlZwZG1WeVgyRjFkR2h2Y21sNlpYSXVibUYwYVhabElHOXlJRlI0Ymk1elpXNWtaWElnUFQwZ1kyWm5MbkpsWTJWcGRtVnlMbTVoZEdsMlpRb2dJQ0FnTHk4Z0tTd2dJbTV2ZENCeVpXTmxhWFpsY2lJS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNakkyQ2lBZ0lDQXZMeUJoZG1GcGJHRmliR1VnUFNCemRDNWlZV3hoYm1ObExtRnpYM1ZwYm5RMk5DZ3BJQzBnYzNRdWRHOTBZV3hmWTJ4aGFXMWxaQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVGMyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdNZ05DQXZMeUF4T0RRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lNamNLSUNBZ0lDOHZJR0Z0ZENBOUlHRnRiM1Z1ZENCcFppQmhiVzkxYm5RZ1BDQmhkbUZwYkdGaWJHVWdaV3h6WlNCaGRtRnBiR0ZpYkdVS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpJNENpQWdJQ0F2THlCaGMzTmxjblFnWVcxMElENGdNQ3dnSW5KbFpuVnVaQ0J1YnlCaVlXeGhibU5sSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdjbVZtZFc1a0lHNXZJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpJNUNpQWdJQ0F2THlCemRDNWlZV3hoYm1ObElEMGdZWEpqTkM1VlNXNTBOalFvYzNRdVltRnNZVzVqWlM1aGMxOTFhVzUwTmpRb0tTQXRJR0Z0ZENrS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlERTNOZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJek1DMHlNekVLSUNBZ0lDOHZJQ01nWTJGd0lDaHZjaUJqWVc1alpXd3BJR0VnY0dWdVpHbHVaeUIwYVcxbFpDQjNhWFJvWkhKaGQyRnNJSFJ2SUhkb1lYUWdhWE1nYzNScGJHd2dkVzVqYkdGcGJXVmtDaUFnSUNBdkx5QnBaaUJ6ZEM1M2FYUm9aSEpoZDE5eVpYRjFaWE4wWldSZllYUXVZWE5mZFdsdWREWTBLQ2tnUGlBd09nb2dJQ0FnY0hWemFHbHVkQ0F4T1RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZWlCeVpXWjFibVJmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU16SUtJQ0FnSUM4dklHeGxablFnUFNCemRDNWlZV3hoYm1ObExtRnpYM1ZwYm5RMk5DZ3BJQzBnYzNRdWRHOTBZV3hmWTJ4aGFXMWxaQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6SWdMeThnTVRjMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFl5QTBJQzh2SURFNE5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl6TXdvZ0lDQWdMeThnYVdZZ2JHVm1kQ0E5UFNBd09nb2dJQ0FnWW01NklISmxablZ1WkY5bGJITmxYMkp2WkhsQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TXpRS0lDQWdJQzh2SUhOMExuZHBkR2hrY21GM1gzSmxjWFZsYzNSbFpGOWhkQ0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUhKbGNHeGhZMlV5SURFNU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TXpVS0lDQWdJQzh2SUhOMExuZHBkR2hrY21GM1gyRnRiM1Z1ZENBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXlNREFLQ25KbFpuVnVaRjloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU16Z0tJQ0FnSUM4dklITmxiR1l1WTJoaGJtNWxiSE5iWTJsa1hTQTlJSE4wTG1OdmNIa29LUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJek9Rb2dJQ0FnTHk4Z2MyVnNaaTVmY0dGNUtHTm1aeTV3WVhsbGNpNXVZWFJwZG1Vc0lHTm1aeTVoYzNObGRDNWhjMTkxYVc1ME5qUW9LU3dnWVcxMEtRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdNZ05TQXZMeUF4TWpnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJmY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl4TmkweU1UY0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMGdjbVZtZFc1a2N5QXZJR1Y0YVhSekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbFpuVnVaRjlsYkhObFgySnZaSGxBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNak0yQ2lBZ0lDQXZMeUJsYkdsbUlITjBMbmRwZEdoa2NtRjNYMkZ0YjNWdWRDNWhjMTkxYVc1ME5qUW9LU0ErSUd4bFpuUTZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklEVUtJQ0FnSUQ0S0lDQWdJR0o2SUhKbFpuVnVaRjloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJek53b2dJQ0FnTHk4Z2MzUXVkMmwwYUdSeVlYZGZZVzF2ZFc1MElEMGdZWEpqTkM1VlNXNTBOalFvYkdWbWRDa0tJQ0FnSUdScFp5QTBDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBeU1EQUtJQ0FnSUdJZ2NtVm1kVzVrWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ25KbFpuVnVaRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ5WldaMWJtUmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzVqYjI1MGNtRmpkQzVZTkRBeVFtRjBZMmhUWlhSMGJHVnRaVzUwTG1sdWFYUnBZWFJsWDNkcGRHaGtjbUYzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoZEdWZmQybDBhR1J5WVhjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakkwTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TkRVS0lDQWdJQzh2SUhOMElEMGdjMlZzWmk1amFHRnVibVZzYzF0amFXUmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYUdGdWJtVnNjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNalEyQ2lBZ0lDQXZMeUJqWm1jZ1BTQnpkQzVqYjI1bWFXY3VZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4TnpZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNalEzQ2lBZ0lDQXZMeUJ6Wld4bUxsOWhjM05sY25SZmNHRjVaWEpmYzJsa1pTaGpabWNwQ2lBZ0lDQmpZV3hzYzNWaUlGOWhjM05sY25SZmNHRjVaWEpmYzJsa1pRb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU5EZ0tJQ0FnSUM4dklHRjJZV2xzWVdKc1pTQTlJSE4wTG1KaGJHRnVZMlV1WVhOZmRXbHVkRFkwS0NrZ0xTQnpkQzUwYjNSaGJGOWpiR0ZwYldWa0xtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE56WUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpJRFFnTHk4Z01UZzBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0xRb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblFnUGlBd0lHRnVaQ0JoYlc5MWJuUWdQRDBnWVhaaGFXeGhZbXhsTENBaWQybDBhR1J5WVhjZ1lXMXZkVzUwSWdvZ0lDQWdZbm9nYVc1cGRHbGhkR1ZmZDJsMGFHUnlZWGRmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklEVUtJQ0FnSUR3OUNpQWdJQ0JpZWlCcGJtbDBhV0YwWlY5M2FYUm9aSEpoZDE5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENncHBibWwwYVdGMFpWOTNhWFJvWkhKaGQxOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTBPUW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBK0lEQWdZVzVrSUdGdGIzVnVkQ0E4UFNCaGRtRnBiR0ZpYkdVc0lDSjNhWFJvWkhKaGR5QmhiVzkxYm5RaUNpQWdJQ0JoYzNObGNuUWdMeThnZDJsMGFHUnlZWGNnWVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJMU1Bb2dJQ0FnTHk4Z2MzUXVkMmwwYUdSeVlYZGZjbVZ4ZFdWemRHVmtYMkYwSUQwZ1lYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcENpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF4T1RJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNalV4Q2lBZ0lDQXZMeUJ6ZEM1M2FYUm9aSEpoZDE5aGJXOTFiblFnUFNCaGNtTTBMbFZKYm5RMk5DaGhiVzkxYm5RcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxjR3hoWTJVeUlESXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU5USUtJQ0FnSUM4dklITmxiR1l1WTJoaGJtNWxiSE5iWTJsa1hTQTlJSE4wTG1OdmNIa29LUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJMU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnWTJabkxuZHBkR2hrY21GM1gyUmxiR0Y1TG1GelgzVnBiblEyTkNncENpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5SaklEWWdMeThnTVRNMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lORElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0thVzVwZEdsaGRHVmZkMmwwYUdSeVlYZGZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdhVzVwZEdsaGRHVmZkMmwwYUdSeVlYZGZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzVqYjI1MGNtRmpkQzVZTkRBeVFtRjBZMmhUWlhSMGJHVnRaVzUwTG1acGJtRnNhWHBsWDNkcGRHaGtjbUYzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ptbHVZV3hwZW1WZmQybDBhR1J5WVhjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakkxTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpVNENpQWdJQ0F2THlCemRDQTlJSE5sYkdZdVkyaGhibTVsYkhOYlkybGtYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ob1lXNXVaV3h6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TlRrS0lDQWdJQzh2SUdObVp5QTlJSE4wTG1OdmJtWnBaeTVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURFM05nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TmpBS0lDQWdJQzh2SUhObGJHWXVYMkZ6YzJWeWRGOXdZWGxsY2w5emFXUmxLR05tWnlrS0lDQWdJR05oYkd4emRXSWdYMkZ6YzJWeWRGOXdZWGxsY2w5emFXUmxDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNall4Q2lBZ0lDQXZMeUJ5WlhGMVpYTjBaV1FnUFNCemRDNTNhWFJvWkhKaGQxOXlaWEYxWlhOMFpXUmZZWFF1WVhOZmRXbHVkRFkwS0NrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhPVElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTJNZ29nSUNBZ0x5OGdZWE56WlhKMElISmxjWFZsYzNSbFpDQStJREFzSUNKdWJ5QjNhWFJvWkhKaGR5QndaVzVrYVc1bklnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnYm04Z2QybDBhR1J5WVhjZ2NHVnVaR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBK1BTQnlaWEYxWlhOMFpXUWdLeUJqWm1jdWQybDBhR1J5WVhkZlpHVnNZWGt1WVhOZmRXbHVkRFkwS0Nrc0lDSjNhWFJvWkhKaGR5QmtaV3hoZVNJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZeUEySUM4dklERXpOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjNhWFJvWkhKaGR5QmtaV3hoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lOalFLSUNBZ0lDOHZJR0YyWVdsc1lXSnNaU0E5SUhOMExtSmhiR0Z1WTJVdVlYTmZkV2x1ZERZMEtDa2dMU0J6ZEM1MGIzUmhiRjlqYkdGcGJXVmtMbUZ6WDNWcGJuUTJOQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhOellLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWXlBMElDOHZJREU0TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTJOUW9nSUNBZ0x5OGdkMkZ1ZENBOUlITjBMbmRwZEdoa2NtRjNYMkZ0YjNWdWRDNWhjMTkxYVc1ME5qUW9LUW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01qQXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU5qWUtJQ0FnSUM4dklHRnRkQ0E5SUhkaGJuUWdhV1lnZDJGdWRDQThJR0YyWVdsc1lXSnNaU0JsYkhObElHRjJZV2xzWVdKc1pRb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpZM0NpQWdJQ0F2THlCemRDNWlZV3hoYm1ObElEMGdZWEpqTkM1VlNXNTBOalFvYzNRdVltRnNZVzVqWlM1aGMxOTFhVzUwTmpRb0tTQXRJR0Z0ZENrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURFM05nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TmpnS0lDQWdJQzh2SUhOMExuZHBkR2hrY21GM1gzSmxjWFZsYzNSbFpGOWhkQ0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUhKbGNHeGhZMlV5SURFNU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TmprS0lDQWdJQzh2SUhOMExuZHBkR2hrY21GM1gyRnRiM1Z1ZENBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXlNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1qY3dDaUFnSUNBdkx5QnpaV3htTG1Ob1lXNXVaV3h6VzJOcFpGMGdQU0J6ZEM1amIzQjVLQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU56RUtJQ0FnSUM4dklHbG1JR0Z0ZENBK0lEQTZDaUFnSUNCaWVpQm1hVzVoYkdsNlpWOTNhWFJvWkhKaGQxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNamN5Q2lBZ0lDQXZMeUJ6Wld4bUxsOXdZWGtvWTJabkxuQmhlV1Z5TG01aGRHbDJaU3dnWTJabkxtRnpjMlYwTG1GelgzVnBiblEyTkNncExDQmhiWFFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR01nTlNBdkx5QXhNamdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQmZjR0Y1Q2dwbWFXNWhiR2w2WlY5M2FYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTFOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmcwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM1amIyNTBjbUZqZEM1WU5EQXlRbUYwWTJoVFpYUjBiR1Z0Wlc1MExsOWphR0Z1Ym1Wc1gybGtLR052Ym1acFp6b2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1gyTm9ZVzV1Wld4ZmFXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJM05TMHlOemNLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMU0JvWld4d1pYSnpDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5amFHRnVibVZzWDJsa0tITmxiR1lzSUdOdmJtWnBaem9nUTJoaGJtNWxiRU52Ym1acFp5a2dMVDRnUW5sMFpYTTZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgySmhkR05vWDNObGRIUnNaVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNamM1Q2lBZ0lDQXZMeUJDZVhSbGN5aERTRUZPVGtWTVgxQlNSVVpKV0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjNE16UXpNRE15TW1RMk1UYzJObVF5WkRZeU56TXlaRFl6TmpnMk1UWmxObVUyTlRaak1tUTNOak14Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTRNQW9nSUNBZ0x5OGdLeUJIYkc5aVlXd3VaMlZ1WlhOcGMxOW9ZWE5vQ2lBZ0lDQm5iRzlpWVd3Z1IyVnVaWE5wYzBoaGMyZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpjNUxUSTRNQW9nSUNBZ0x5OGdRbmwwWlhNb1EwaEJUazVGVEY5UVVrVkdTVmdwQ2lBZ0lDQXZMeUFySUVkc2IySmhiQzVuWlc1bGMybHpYMmhoYzJnS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95T0RFS0lDQWdJQzh2SUNzZ2IzQXVhWFJ2WWloSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5cFpDNXBaQ2tLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95TnprdE1qZ3hDaUFnSUNBdkx5QkNlWFJsY3loRFNFRk9Ua1ZNWDFCU1JVWkpXQ2tLSUNBZ0lDOHZJQ3NnUjJ4dlltRnNMbWRsYm1WemFYTmZhR0Z6YUFvZ0lDQWdMeThnS3lCdmNDNXBkRzlpS0Vkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJsa0xtbGtLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTNPUzB5T0RJS0lDQWdJQzh2SUVKNWRHVnpLRU5JUVU1T1JVeGZVRkpGUmtsWUtRb2dJQ0FnTHk4Z0t5QkhiRzlpWVd3dVoyVnVaWE5wYzE5b1lYTm9DaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1F1YVdRcENpQWdJQ0F2THlBcklHTnZibVpwWnk1aWVYUmxjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1qYzRMVEk0TXdvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG5Ob1lUSTFOaWdLSUNBZ0lDOHZJQ0FnSUNCQ2VYUmxjeWhEU0VGT1RrVk1YMUJTUlVaSldDa0tJQ0FnSUM4dklDQWdJQ0FySUVkc2IySmhiQzVuWlc1bGMybHpYMmhoYzJnS0lDQWdJQzh2SUNBZ0lDQXJJRzl3TG1sMGIySW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1F1YVdRcENpQWdJQ0F2THlBZ0lDQWdLeUJqYjI1bWFXY3VZbmwwWlhNS0lDQWdJQzh2SUNrS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MExtTnZiblJ5WVdOMExsZzBNREpDWVhSamFGTmxkSFJzWlcxbGJuUXVYM1p2ZFdOb1pYSmZiV1Z6YzJGblpTaGphV1E2SUdKNWRHVnpMQ0J0WVhoZlkyeGhhVzFoWW14bE9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncGZkbTkxWTJobGNsOXRaWE56WVdkbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95T0RVdE1qZzJDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5MmIzVmphR1Z5WDIxbGMzTmhaMlVvYzJWc1ppd2dZMmxrT2lCQ2VYUmxjeXdnYldGNFgyTnNZV2x0WVdKc1pUb2dWVWx1ZERZMEtTQXRQaUJDZVhSbGN6b0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lPRGdLSUNBZ0lDOHZJRUo1ZEdWektGWlBWVU5JUlZKZlVGSkZSa2xZS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Tnpnek5ETXdNekl5WkRZeE56WTJaREprTmpJM016SmtOelkyWmpjMU5qTTJPRFkxTnpJeVpEYzJNekVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1qZzVDaUFnSUNBdkx5QXJJRWRzYjJKaGJDNW5aVzVsYzJselgyaGhjMmdLSUNBZ0lHZHNiMkpoYkNCSFpXNWxjMmx6U0dGemFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG95T0RndE1qZzVDaUFnSUNBdkx5QkNlWFJsY3loV1QxVkRTRVZTWDFCU1JVWkpXQ2tLSUNBZ0lDOHZJQ3NnUjJ4dlltRnNMbWRsYm1WemFYTmZhR0Z6YUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakk1TUFvZ0lDQWdMeThnS3lCdmNDNXBkRzlpS0Vkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJsa0xtbGtLUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakk0T0MweU9UQUtJQ0FnSUM4dklFSjVkR1Z6S0ZaUFZVTklSVkpmVUZKRlJrbFlLUW9nSUNBZ0x5OGdLeUJIYkc5aVlXd3VaMlZ1WlhOcGMxOW9ZWE5vQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmYVdRdWFXUXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk1qZzRMVEk1TVFvZ0lDQWdMeThnUW5sMFpYTW9WazlWUTBoRlVsOVFVa1ZHU1ZncENpQWdJQ0F2THlBcklFZHNiMkpoYkM1blpXNWxjMmx6WDJoaGMyZ0tJQ0FnSUM4dklDc2diM0F1YVhSdllpaEhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOXBaQzVwWkNrS0lDQWdJQzh2SUNzZ1kybGtDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU9USUtJQ0FnSUM4dklDc2diM0F1YVhSdllpaHRZWGhmWTJ4aGFXMWhZbXhsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTRPQzB5T1RJS0lDQWdJQzh2SUVKNWRHVnpLRlpQVlVOSVJWSmZVRkpGUmtsWUtRb2dJQ0FnTHk4Z0t5QkhiRzlpWVd3dVoyVnVaWE5wYzE5b1lYTm9DaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZhV1F1YVdRcENpQWdJQ0F2THlBcklHTnBaQW9nSUNBZ0x5OGdLeUJ2Y0M1cGRHOWlLRzFoZUY5amJHRnBiV0ZpYkdVcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpnM0xUSTVNd29nSUNBZ0x5OGdjbVYwZFhKdUlDZ0tJQ0FnSUM4dklDQWdJQ0JDZVhSbGN5aFdUMVZEU0VWU1gxQlNSVVpKV0NrS0lDQWdJQzh2SUNBZ0lDQXJJRWRzYjJKaGJDNW5aVzVsYzJselgyaGhjMmdLSUNBZ0lDOHZJQ0FnSUNBcklHOXdMbWwwYjJJb1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZmFXUXVhV1FwQ2lBZ0lDQXZMeUFnSUNBZ0t5QmphV1FLSUNBZ0lDOHZJQ0FnSUNBcklHOXdMbWwwYjJJb2JXRjRYMk5zWVdsdFlXSnNaU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTROREF5WDJKaGRHTm9YM05sZEhSc1pXMWxiblF1WTI5dWRISmhZM1F1V0RRd01rSmhkR05vVTJWMGRHeGxiV1Z1ZEM1ZmIzQmxibDl0WW5Jb1kyOXVabWxuT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCaWVYUmxjem9LWDI5d1pXNWZiV0p5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lPVGt0TXpBd0NpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjl2Y0dWdVgyMWljaWh6Wld4bUxDQmpiMjVtYVdjNklFTm9ZVzV1Wld4RGIyNW1hV2NwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvek1ERUtJQ0FnSUM4dklISmxjWFZwY21Wa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG96TURJS0lDQWdJQzh2SUdOcFpDQTlJSE5sYkdZdVgyTm9ZVzV1Wld4ZmFXUW9ZMjl1Wm1sbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdGdWJtVnNYMmxrQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qTXdNd29nSUNBZ0x5OGdhV1lnWTJsa0lHNXZkQ0JwYmlCelpXeG1MbU5vWVc1dVpXeHpPZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFl6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJRjl2Y0dWdVgyMWljbDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TXpBMENpQWdJQ0F2THlCeVpYRjFhWEpsWkNBclBTQkNUMWhmUmt4QlZGOU5RbElnS3lCQ1QxaGZRbGxVUlY5TlFsSWdLaUFvTVNBcklETXlJQ3NnYzJsNlpWOXZaaWhEYUdGdWJtVnNVM1JoZEdVcEtRb2dJQ0FnY0hWemFHbHVkQ0E1T0Rrd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncGZiM0JsYmw5dFluSmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG96TURVS0lDQWdJQzh2SUhWclpYa2dQU0J6Wld4bUxsOTFibk5sZEhSc1pXUmZhMlY1S0dOdmJtWnBaeTV5WldObGFYWmxjaTV1WVhScGRtVXNJRUZ6YzJWMEtHTnZibVpwWnk1aGMzTmxkQzVoYzE5MWFXNTBOalFvS1NrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXhNamdnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3lPVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaV05sYVhabGNpNWllWFJsY3lBcklHOXdMbWwwYjJJb1lYTnpaWFF1YVdRcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMkpoZEdOb1gzTmxkSFJzWlcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TXpBMkNpQWdJQ0F2THlCcFppQjFhMlY1SUc1dmRDQnBiaUJ6Wld4bUxuVnVjMlYwZEd4bFpEb0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmZiM0JsYmw5dFluSmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPak13TndvZ0lDQWdMeThnY21WeGRXbHlaV1FnS3owZ1FrOVlYMFpNUVZSZlRVSlNJQ3NnUWs5WVgwSlpWRVZmVFVKU0lDb2dLREVnS3lBME1DQXJJRGdwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2NIVnphR2x1ZENBeU1qRXdNQW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncGZiM0JsYmw5dFluSmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG96TURnS0lDQWdJQzh2SUhKbGRIVnliaUJ5WlhGMWFYSmxaQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTG1OdmJuUnlZV04wTGxnME1ESkNZWFJqYUZObGRIUnNaVzFsYm5RdVgyRnpjMlZ5ZEY5d1lYbGxjbDl6YVdSbEtHTm1aem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BmWVhOelpYSjBYM0JoZVdWeVgzTnBaR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5aVlYUmphRjl6WlhSMGJHVnRaVzUwTDJOdmJuUnlZV04wTG5CNU9qTXlNQzB6TWpFS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYMkZ6YzJWeWRGOXdZWGxsY2w5emFXUmxLSE5sYkdZc0lHTm1aem9nUTJoaGJtNWxiRU52Ym1acFp5a2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZlltRjBZMmhmYzJWMGRHeGxiV1Z1ZEM5amIyNTBjbUZqZEM1d2VUb3pNaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUdObVp5NXdZWGxsY2k1dVlYUnBkbVVnYjNJZ1ZIaHVMbk5sYm1SbGNpQTlQU0JqWm1jdWNHRjVaWEpmWVhWMGFHOXlhWHBsY2k1dVlYUnBkbVVzSUNKdWIzUWdjR0Y1WlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZZWE56WlhKMFgzQmhlV1Z5WDNOcFpHVmZZbTl2YkY5MGNuVmxRRElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnUFQwS0lDQWdJR0o2SUY5aGMzTmxjblJmY0dGNVpYSmZjMmxrWlY5aWIyOXNYMlpoYkhObFFETUtDbDloYzNObGNuUmZjR0Y1WlhKZmMybGtaVjlpYjI5c1gzUnlkV1ZBTWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwZllYTnpaWEowWDNCaGVXVnlYM05wWkdWZlltOXZiRjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWW1GMFkyaGZjMlYwZEd4bGJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvek1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJR05tWnk1d1lYbGxjaTV1WVhScGRtVWdiM0lnVkhodUxuTmxibVJsY2lBOVBTQmpabWN1Y0dGNVpYSmZZWFYwYUc5eWFYcGxjaTV1WVhScGRtVXNJQ0p1YjNRZ2NHRjVaWElpQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhKbGRITjFZZ29LWDJGemMyVnlkRjl3WVhsbGNsOXphV1JsWDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUY5aGMzTmxjblJmY0dGNVpYSmZjMmxrWlY5aWIyOXNYMjFsY21kbFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MExtTnZiblJ5WVdOMExsZzBNREpDWVhSamFGTmxkSFJzWlcxbGJuUXVYM0JoZVNoeVpXTmxhWFpsY2pvZ1lubDBaWE1zSUdGemMyVjBYMmxrT2lCMWFXNTBOalFzSUdGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BmY0dGNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZZbUYwWTJoZmMyVjBkR3hsYldWdWRDOWpiMjUwY21GamRDNXdlVG96TWpRdE16STFDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5d1lYa29jMlZzWml3Z2NtVmpaV2wyWlhJNklFRmpZMjkxYm5Rc0lHRnpjMlYwWDJsa09pQlZTVzUwTmpRc0lHRnRiM1Z1ZERvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pNeU5pMHpNamdLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0dGemMyVjBYMmxrS1N3Z1lYTnpaWFJmY21WalpXbDJaWEk5Y21WalpXbDJaWElzSUdGemMyVjBYMkZ0YjNWdWREMWhiVzkxYm5Rc0lHWmxaVDB3Q2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPak15TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOWlZWFJqYUY5elpYUjBiR1Z0Wlc1MEwyTnZiblJ5WVdOMExuQjVPak15TndvZ0lDQWdMeThnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2hoYzNObGRGOXBaQ2tzSUdGemMyVjBYM0psWTJWcGRtVnlQWEpsWTJWcGRtVnlMQ0JoYzNObGRGOWhiVzkxYm5ROVlXMXZkVzUwTENCbVpXVTlNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDlpWVhSamFGOXpaWFIwYkdWdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pNeU5pMHpNamdLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0dGemMyVjBYMmxrS1N3Z1lYTnpaWFJmY21WalpXbDJaWEk5Y21WalpXbDJaWElzSUdGemMyVjBYMkZ0YjNWdWREMWhiVzkxYm5Rc0lHWmxaVDB3Q2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUhBUUN3QVNDNEFZQUJpQUVtQlFRVkgzeDFBV01CZFFBREJvRUJNUnRCQUdNeEdSUkVNUmhFZ2d3RUFCTktFUVF0ZlVOVUJJTUFROFlFbVZKMnpBVGNWdGwzQk81cTJUd0V0NjN5YndUazk0ajNCSjlUdk5vRUdyaUVId1JrWWN5SkJLTVQzYkUyR2dDT0RBQUpBRW9BWEFCL0FLOEExUURvQWV3QytBTTVBK1VFVEFBeEdSUXhHQlFRUXpZYUFVa1ZnUWdTUkJjeEZpSUpTVGdRSWhKRU1ncExBbkFBUlFFVVJFazRCeklLRWtRNENJR2dqUVlQUkxFeUNpT3lFcklVc2hHQkJMSVFJN0lCc3lKRE5ob0JTUlVrRWtTSUJHOUlLRXhRc0NKRE5ob0JTUlVsRWtRMkdnSkpGWUVJRWtRWGlBUjhTUlVXVndZQ1RGQW9URkN3SWtNMkdnRkpGU1VTUkNsTVVMNUVTVmV3Q0VzQlY3Z0lTd0pYd0FoUEExZklDRThEVHdOUVR3SlFURkFvVEZDd0lrTTJHZ0ZKRlNVU1JEWWFBa2tWZ1FnU1JCY1dVQ3BNVUw1TUZ5Tk1Ud0pORmloTVVMQWlRellhQVVrVkpCSkVpQVEzU0JZb1RGQ3dJa01qU1NzMkdnRkpGU1FTUkRFV2dRSUpTVGdRZ1FRU1JERVdJZ2xKT0JBaUVrUlBBb2dEdGt4SlRnUk9CRXNDT0JGTEFTRUZXeEpFU3dJNEZESUtFa1JMQWpnQVN3RlhBQ0FTUkVzQ09CSkpUZ1pFU3dJNEZUSURFa1JMQWpnZ01nTVNSRThDT0JNeUF4SkVTd0U0QnpJS0VrUk1PQWhNaUFPMlRnTVBSQ2xNVUVsT0FyMUZBVUVBRzB4SnZrUkpWd0N3VHdNU1JDUmJUd01JRmlSTXV5aE1VTEFpUTBraEJsdEpSUWFCaEFjUFFRQk9Td1NCZ0pxZUFRNUJBRU1pUkVsWEFDQkxBVmRBSUV4TEFSTkVUd1FXSXhaSlRnSkZDVXNEVEZCTEFWQkxBVkJNVUU4RFRMOU1WNEFJVUNwTVVFbEZCTDFGQVVEL3Brc0NTd1MvUXYrZUkwTC91aU5IQkN0SEFqWWFBVWNDSTFsSlRnSkpnWEFMZ1FJSVR3SVZFa1NCcUJRTGdRb0lTVElNRFVFQUdMR0JCcklRZ1FXeUdTY0VzaDRuQkxJZkk3SUJzMEwvNFVnalNVbExBd3hCQUxoTEExY0NBRXNCZ1hBTGdYQllTVVVOVndBZ1NVVUtLVXhRU1VVSnZreEpUZ0pPQTBReEFFeFhBTEJKUlE1WFlDQVNRQUFMTVFCTERGZEFJQkpCQUhVaVJFc01TU1ZiU1U0Q1JRcEpWMmdJUlEyQmFGdEpSUWxKU3dJT1JFOERTVTRDSkZ0UEF3OUVUQ0VFVzBsRkJ3MUJBRDFMQ0VzSGlBSThTd3hYS0VCTERFbE9BMWNnSUlSRVN3WkxCZ2xMQ1NFRVN3MjdTd0ZYUUNCUEFsZUFDRkFxVEZCSnZrUVhTd0lJRnI5UEFnaE1JZ2hDLzBValF2K0lTQllvVEZDd0lrTTJHZ0ZKRlNVU1JEWWFBa2tWZ1FnU1JCZEpGa3NDVEZBcVRGQkp2a1FYU1VRakZrOENUTCt4U2JJU1R3S3lGRXl5RVlFRXNoQWpzZ0d6RmloTVVMQWlReXMyR2dGSkZTVVNSRFlhQWtrVmdRZ1NSQmRNS1V4UVNiNU1TVThDUkRFQVRGY0FzRWxPQTFkZ0lCSkFBQXN4QUVzQ1YwQWdFa0VBYnlKRVNTUmJTd0VoQkZ0TEFVd0pUd1ZKVGdKTEFReE1UZ0pOU1U0RlNVUUpGbHl3U1lIQUFWdEJBQmxIQWlSYlRDRUVXd2xKUlFaQUFDSWpGa3hMQVZ6QVRGeklUd0pNdjBsWEFDQk1JUVZiU3dLSUFiQVdLRXhRc0NKRFNZSElBVnRMQlExQi85MUxCQlpjeUVMLzFTTkMvNDQyR2dGSkZTVVNSRFlhQWtsT0Fra1ZnUWdTUkJkSlRnSk9BeWxNVUVsT0FyNU1TVTRDVGdORVNWY0FzSWdCUVU0RFNTUmJUQ0VFV3dsT0JVRUFKVXNGU3dVT1FRQWRJa1F5QnhaY3dFOERYTWhQQWt5L01nZE1JUVpiQ0JZb1RGQ3dJa01qUXYvZ05ob0JTUlVsRWtRcFRGQkp2a1JKVndDd2lBRDBTVTRDVGdOSmdjQUJXMGxFTWdkUEF5RUdXMDhDQ0E5RVNTUmJTd0VoQkZ0TEFVd0pTd0tCeUFGYlNVc0NERTFKVGdSTVN3RUpGazhDVEZ5d0l4Wk1Td0Zjd0V4Y3lFOENUTDlCQUE5TEFVbFhBQ0JNSVFWYlN3S0lBTG9XS0V4UXNDSkRpZ0VDZ0JaNE5EQXlMV0YyYlMxaWN5MWphR0Z1Ym1Wc0xYWXhNaEZRTWdnV1VJdi9VQUdMLzRtS0FnR0FGbmcwTURJdFlYWnRMV0p6TFhadmRXTm9aWEl0ZGpFeUVWQXlDQlpRaS81UWkvOFdVSW1LQVFJamkvK0kvNlNNL3lsTVVMMUZBVUFBQm9IVWhBYU1BSXYvVjBBZ2kvOVhnQWhRS2t4UXZVVUJRQUFKaXdDQjFLd0JDSXdBaXdDTC8wOENpWW9CQVRFQWkvOVhBQ0FTUUFBTE1RQ0wvMWNnSUJKQkFBVWlSSXYvaVNOQy8vaUtBd0N4aS8reUVvdjlzaFNML3JJUmdRU3lFQ095QWJPSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
