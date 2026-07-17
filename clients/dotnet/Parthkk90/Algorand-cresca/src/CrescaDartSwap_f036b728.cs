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

namespace Arc56.Generated.Parthkk90.Algorand_cresca.CrescaDartSwap_f036b728
{


    public class CrescaDartSwapProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CrescaDartSwapProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BestQuote : AVMObjectType
            {
                public ulong AssetId { get; set; }

                public ulong AmountOut { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountOut.From(AmountOut);
                    ret.AddRange(vAmountOut.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BestQuote Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BestQuote();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountOut.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountOut = vAmountOut.ToValue();
                    if (valueAmountOut is ulong vAmountOutValue) { ret.AmountOut = vAmountOutValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BestQuote);
                }
                public bool Equals(BestQuote? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BestQuote left, BestQuote right)
                {
                    return EqualityComparer<BestQuote>.Default.Equals(left, right);
                }
                public static bool operator !=(BestQuote left, BestQuote right)
                {
                    return !(left == right);
                }

            }

            public class Pool : AVMObjectType
            {
                public ulong AssetId { get; set; }

                public ulong AlgoReserve { get; set; }

                public ulong AssetReserve { get; set; }

                public bool Enabled { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAlgoReserve = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAlgoReserve.From(AlgoReserve);
                    ret.AddRange(vAlgoReserve.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetReserve = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetReserve.From(AssetReserve);
                    ret.AddRange(vAssetReserve.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vEnabled.From(Enabled);
                    ret.AddRange(vEnabled.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Pool Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Pool();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAlgoReserve = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAlgoReserve.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAlgoReserve = vAlgoReserve.ToValue();
                    if (valueAlgoReserve is ulong vAlgoReserveValue) { ret.AlgoReserve = vAlgoReserveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetReserve = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetReserve.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetReserve = vAssetReserve.ToValue();
                    if (valueAssetReserve is ulong vAssetReserveValue) { ret.AssetReserve = vAssetReserveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vEnabled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEnabled = vEnabled.ToValue();
                    if (valueEnabled is bool vEnabledValue) { ret.Enabled = vEnabledValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Pool);
                }
                public bool Equals(Pool? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Pool left, Pool right)
                {
                    return EqualityComparer<Pool>.Default.Equals(left, right);
                }
                public static bool operator !=(Pool left, Pool right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class SwapExecutedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 37, 124, 54, 31 };
                public const string Signature = "SwapExecuted(address,uint64,bool,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }
                public bool Field3 { get; set; }
                public ulong Field4 { get; set; }
                public ulong Field5 { get; set; }

                public static SwapExecutedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SwapExecutedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fee_bps"> </param>
        public async Task<bool> SetFeeBps(ulong fee_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 69, 195, 174 };
            var fee_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_bpsAbi.From(fee_bps);

            var result = await base.CallApp(new List<object> { abiHandle, fee_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetFeeBps_Transactions(ulong fee_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 69, 195, 174 };
            var fee_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_bpsAbi.From(fee_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, fee_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        /// <param name="enabled"> </param>
        public async Task<bool> ConfigurePool(ulong asset_id, bool enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 178, 21, 29 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); enabledAbi.From(enabled);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ConfigurePool_Transactions(ulong asset_id, bool enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 178, 21, 29 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); enabledAbi.From(enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task<bool> OptInAsset(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 177, 231, 153 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OptInAsset_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 177, 231, 153 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment_txn"> </param>
        /// <param name="asset_id"> </param>
        public async Task<bool> FundPoolAlgo(PaymentTransaction payment_txn, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 220, 137, 246, 187 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FundPoolAlgo_Transactions(PaymentTransaction payment_txn, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 220, 137, 246, 187 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_txn"> </param>
        /// <param name="asset_id"> </param>
        public async Task<bool> FundPoolAsset(AssetTransferTransaction asset_txn, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_txn });
            byte[] abiHandle = { 151, 17, 7, 83 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, asset_txn, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FundPoolAsset_Transactions(AssetTransferTransaction asset_txn, ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_txn });
            byte[] abiHandle = { 151, 17, 7, 83 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_txn, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        /// <param name="is_algo_in"> </param>
        /// <param name="amount_in"> </param>
        public async Task<ulong> GetQuoteExactIn(ulong asset_id, bool is_algo_in, ulong amount_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 248, 46, 245 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var is_algo_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_algo_inAbi.From(is_algo_in);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);

            var result = await base.SimApp(new List<object> { abiHandle, asset_idAbi, is_algo_inAbi, amount_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetQuoteExactIn_Transactions(ulong asset_id, bool is_algo_in, ulong amount_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 248, 46, 245 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var is_algo_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_algo_inAbi.From(is_algo_in);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi, is_algo_inAbi, amount_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///DART-like selection: returns best output among provided candidate pools.
        ///Output packing: (asset_id << 64) | amount_out
        ///</summary>
        /// <param name="asset_ids"> </param>
        /// <param name="amount_in"> </param>
        /// <param name="is_algo_in"> </param>
        public async Task<Structs.BestQuote> GetBestQuoteExactIn(ulong[] asset_ids, ulong amount_in, bool is_algo_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 76, 136, 246 };
            var asset_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); asset_idsAbi.From(asset_ids);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var is_algo_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_algo_inAbi.From(is_algo_in);

            var result = await base.SimApp(new List<object> { abiHandle, asset_idsAbi, amount_inAbi, is_algo_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BestQuote.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBestQuoteExactIn_Transactions(ulong[] asset_ids, ulong amount_in, bool is_algo_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 76, 136, 246 };
            var asset_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); asset_idsAbi.From(asset_ids);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var is_algo_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_algo_inAbi.From(is_algo_in);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idsAbi, amount_inAbi, is_algo_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment_txn"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="min_asset_out"> </param>
        /// <param name="recipient"> </param>
        public async Task<ulong> SwapExactAlgoForAsset(PaymentTransaction payment_txn, ulong asset_id, ulong min_asset_out, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 211, 241, 56, 81 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var min_asset_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_asset_outAbi.From(min_asset_out);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn, asset_idAbi, min_asset_outAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SwapExactAlgoForAsset_Transactions(PaymentTransaction payment_txn, ulong asset_id, ulong min_asset_out, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 211, 241, 56, 81 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var min_asset_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_asset_outAbi.From(min_asset_out);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn, asset_idAbi, min_asset_outAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_txn"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="min_algo_out"> </param>
        /// <param name="recipient"> </param>
        public async Task<ulong> SwapExactAssetForAlgo(AssetTransferTransaction asset_txn, ulong asset_id, ulong min_algo_out, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_txn });
            byte[] abiHandle = { 60, 29, 49, 151 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var min_algo_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_algo_outAbi.From(min_algo_out);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, asset_txn, asset_idAbi, min_algo_outAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SwapExactAssetForAlgo_Transactions(AssetTransferTransaction asset_txn, ulong asset_id, ulong min_algo_out, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_txn });
            byte[] abiHandle = { 60, 29, 49, 151 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var min_algo_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_algo_outAbi.From(min_algo_out);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_txn, asset_idAbi, min_algo_outAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task<Structs.Pool> GetPool(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 156, 16, 207 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.SimApp(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Pool.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPool_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 156, 16, 207 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetFeeBps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 93, 169, 203 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetFeeBps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 93, 169, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment_txn"> </param>
        public async Task<bool> FundContract(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 21, 100, 117, 168 };

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FundContract_Transactions(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 21, 100, 117, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3Jlc2NhRGFydFN3YXAiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmVzdFF1b3RlIjpbeyJuYW1lIjoiYXNzZXRfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYW1vdW50X291dCIsInR5cGUiOiJ1aW50NjQifV0sIlBvb2wiOlt7Im5hbWUiOiJhc3NldF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbGdvX3Jlc2VydmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXRfcmVzZXJ2ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbmFibGVkIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoic2V0X2ZlZV9icHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX2JwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25maWd1cmVfcG9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVuYWJsZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX2Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ1bmRfcG9vbF9hbGdvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kX3Bvb2xfYXNzZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9xdW90ZV9leGFjdF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2FsZ29faW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Jlc3RfcXVvdGVfZXhhY3RfaW4iLCJkZXNjIjoiREFSVC1saWtlIHNlbGVjdGlvbjogcmV0dXJucyBiZXN0IG91dHB1dCBhbW9uZyBwcm92aWRlZCBjYW5kaWRhdGUgcG9vbHMuXG5PdXRwdXQgcGFja2luZzogKGFzc2V0X2lkIDw8IDY0KSB8IGFtb3VudF9vdXQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2FsZ29faW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQmVzdFF1b3RlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzd2FwX2V4YWN0X2FsZ29fZm9yX2Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX2Fzc2V0X291dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTd2FwRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzd2FwX2V4YWN0X2Fzc2V0X2Zvcl9hbGdvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluX2FsZ29fb3V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN3YXBFeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxib29sKSIsInN0cnVjdCI6IlBvb2wiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9mZWVfYnBzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kX2NvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjkxLDczMCw5OTMsMTEzMSwxMjg2XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwOSwxMzEyXSwiZXJyb3JNZXNzYWdlIjoiRW1wdHkgcG9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4N10sImVycm9yTWVzc2FnZSI6IkZlZSB0b28gaGlnaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2MV0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0MCwxMTg3XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHBvb2wgbGlxdWlkaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg1LDcyNCwxMjgxXSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBmdW5kIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4NywxMTI1XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBwYXkgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODMzXSwiZXJyb3JNZXNzYWdlIjoiTm8gY2FuZGlkYXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzUsMTE4Ml0sImVycm9yTWVzc2FnZSI6Ik5vIG91dHB1dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NywxODMsMTk5LDIyMywyNzUsMzI2LDM3NCw0MTQsNDQ5LDQ4Myw1MDcsNTM5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc5LDYwMiw2NTFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3ODEsMTAxMCwxMTU3XSwiZXJyb3JNZXNzYWdlIjoiUG9vbCBkaXNhYmxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMDBdLCJlcnJvck1lc3NhZ2UiOiJQb29sIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzMsMTE4MF0sImVycm9yTWVzc2FnZSI6IlNsaXBwYWdlIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzM5LDExNDBdLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MCwxODYsMjAyLDIyNiwyNzgsMzI5LDM3Nyw0MTcsNDUyLDQ4Niw1MTAsNTQyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNjgsMTMxN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZmVlX2JwcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTYsODgzLDEzMDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBvb2xzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MSwzOTMsNTI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYyLDMxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTAsMjQ1LDI1MywyOTYsMzA0LDM1MywzODUsNDAxLDQzNiw0NzAsNDk0LDUxOCw1NTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzcsNDI4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MCwyODgsNDYyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xrTnlaWE5qWVVSaGNuUlRkMkZ3TGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ09DQXdJREUySURFNU1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlEQjRPREFnTUhnM01EWmpOV1lnTUhnd01DQWlabVZsWDJKd2N5SWdNSGd3TURBd01EQXdNREF3TURBd01EQXdJREI0TWpVM1l6TTJNV1lLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZOVFlLSUNBZ0lDOHZJSE5sYkdZdVptVmxYMkp3Y3lBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DaEVSVVpCVlV4VVgwWkZSVjlDVUZNcEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVptVmxYMkp3Y3lJS0lDQWdJSEIxYzJocGJuUWdNekFnTHk4Z016QUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk5URUtJQ0FnSUM4dklHTnNZWE56SUVOeVpYTmpZVVJoY25SVGQyRndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UY0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzNOalExWXpOaFpTQXdlREE0WWpJeE5URmtJREI0WXpSaU1XVTNPVGtnTUhoa1l6ZzVaalppWWlBd2VEazNNVEV3TnpVeklEQjROR1ZtT0RKbFpqVWdNSGhpWWpSak9EaG1OaUF3ZUdRelpqRXpPRFV4SURCNE0yTXhaRE14T1RjZ01IZ3paVGxqTVRCalppQXdlRFZsTldSaE9XTmlJREI0TVRVMk5EYzFZVGdnTHk4Z2JXVjBhRzlrSUNKelpYUmZabVZsWDJKd2N5aDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWTI5dVptbG5kWEpsWDNCdmIyd29kV2x1ZERZMExHSnZiMndwWW05dmJDSXNJRzFsZEdodlpDQWliM0IwWDJsdVgyRnpjMlYwS0hWcGJuUTJOQ2xpYjI5c0lpd2diV1YwYUc5a0lDSm1kVzVrWDNCdmIyeGZZV3huYnlod1lYa3NkV2x1ZERZMEtXSnZiMndpTENCdFpYUm9iMlFnSW1aMWJtUmZjRzl2YkY5aGMzTmxkQ2hoZUdabGNpeDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzRjFiM1JsWDJWNFlXTjBYMmx1S0hWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWlaWE4wWDNGMWIzUmxYMlY0WVdOMFgybHVLSFZwYm5RMk5GdGRMSFZwYm5RMk5DeGliMjlzS1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpYzNkaGNGOWxlR0ZqZEY5aGJHZHZYMlp2Y2w5aGMzTmxkQ2h3WVhrc2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljM2RoY0Y5bGVHRmpkRjloYzNObGRGOW1iM0pmWVd4bmJ5aGhlR1psY2l4MWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmY0c5dmJDaDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3cElpd2diV1YwYUc5a0lDSm5aWFJmWm1WbFgySndjeWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ptZFc1a1gyTnZiblJ5WVdOMEtIQmhlU2xpYjI5c0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5elpYUmZabVZsWDJKd2MxOXliM1YwWlVBMUlHMWhhVzVmWTI5dVptbG5kWEpsWDNCdmIyeGZjbTkxZEdWQU5pQnRZV2x1WDI5d2RGOXBibDloYzNObGRGOXliM1YwWlVBM0lHMWhhVzVmWm5WdVpGOXdiMjlzWDJGc1oyOWZjbTkxZEdWQU9DQnRZV2x1WDJaMWJtUmZjRzl2YkY5aGMzTmxkRjl5YjNWMFpVQTVJRzFoYVc1ZloyVjBYM0YxYjNSbFgyVjRZV04wWDJsdVgzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFgySmxjM1JmY1hWdmRHVmZaWGhoWTNSZmFXNWZjbTkxZEdWQU1URWdiV0ZwYmw5emQyRndYMlY0WVdOMFgyRnNaMjlmWm05eVgyRnpjMlYwWDNKdmRYUmxRREV5SUcxaGFXNWZjM2RoY0Y5bGVHRmpkRjloYzNObGRGOW1iM0pmWVd4bmIxOXliM1YwWlVBeE15QnRZV2x1WDJkbGRGOXdiMjlzWDNKdmRYUmxRREUwSUcxaGFXNWZaMlYwWDJabFpWOWljSE5mY205MWRHVkFNVFVnYldGcGJsOW1kVzVrWDJOdmJuUnlZV04wWDNKdmRYUmxRREUyQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UazZDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPalV4Q2lBZ0lDQXZMeUJqYkdGemN5QkRjbVZ6WTJGRVlYSjBVM2RoY0NoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW1kVzVrWDJOdmJuUnlZV04wWDNKdmRYUmxRREUyT2dvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRvek1EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUbzFNUW9nSUNBZ0x5OGdZMnhoYzNNZ1EzSmxjMk5oUkdGeWRGTjNZWEFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRvek1EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWm5WdVpGOWpiMjUwY21GamRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZabVZsWDJKd2MxOXliM1YwWlVBeE5Ub0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNamsyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyWmxaVjlpY0hNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzQnZiMnhmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJNE9TMHlPVElLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklGWnBaWGR6Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pVeENpQWdJQ0F2THlCamJHRnpjeUJEY21WelkyRkVZWEowVTNkaGNDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lPRGt0TWpreUNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJXYVdWM2N3b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzQnZiMndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjM2RoY0Y5bGVHRmpkRjloYzNObGRGOW1iM0pmWVd4bmIxOXliM1YwWlVBeE16b0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNalEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TlRFS0lDQWdJQzh2SUdOc1lYTnpJRU55WlhOallVUmhjblJUZDJGd0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qSTBOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCemQyRndYMlY0WVdOMFgyRnpjMlYwWDJadmNsOWhiR2R2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM04zWVhCZlpYaGhZM1JmWVd4bmIxOW1iM0pmWVhOelpYUmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakU1TmkweE9Ua0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUZOM1lYQnpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pVeENpQWdJQ0F2THlCamJHRnpjeUJEY21WelkyRkVZWEowVTNkaGNDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakU1TmkweE9Ua0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUZOM1lYQnpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQnpkMkZ3WDJWNFlXTjBYMkZzWjI5ZlptOXlYMkZ6YzJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWlaWE4wWDNGMWIzUmxYMlY0WVdOMFgybHVYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG8xTVFvZ0lDQWdMeThnWTJ4aGMzTWdRM0psYzJOaFJHRnlkRk4zWVhBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERZMFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRVekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjlpWlhOMFgzRjFiM1JsWDJWNFlXTjBYMmx1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5eGRXOTBaVjlsZUdGamRGOXBibDl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRJMUxURXlPQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1VYVnZkR1Z6Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pVeENpQWdJQ0F2THlCamJHRnpjeUJEY21WelkyRkVZWEowVTNkaGNDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRJMUxURXlPQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1VYVnZkR1Z6Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmY1hWdmRHVmZaWGhoWTNSZmFXNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpuVnVaRjl3YjI5c1gyRnpjMlYwWDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pFeE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qVXhDaUFnSUNBdkx5QmpiR0Z6Y3lCRGNtVnpZMkZFWVhKMFUzZGhjQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE1UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWm5WdVpGOXdiMjlzWDJGemMyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyWjFibVJmY0c5dmJGOWhiR2R2WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2prM0xURXdNQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1VHOXZiQ0JtZFc1a2FXNW5DaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pVeENpQWdJQ0F2THlCamJHRnpjeUJEY21WelkyRkVZWEowVTNkaGNDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2prM0xURXdNQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1VHOXZiQ0JtZFc1a2FXNW5DaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQm1kVzVrWDNCdmIyeGZZV3huYndvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl2Y0hSZmFXNWZZWE56WlhSZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk9EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUbzFNUW9nSUNBZ0x5OGdZMnhoYzNNZ1EzSmxjMk5oUkdGeWRGTjNZWEFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2T0RZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdiM0IwWDJsdVgyRnpjMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk52Ym1acFozVnlaVjl3YjI5c1gzSnZkWFJsUURZNkNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qWTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZOVEVLSUNBZ0lDOHZJR05zWVhOeklFTnlaWE5qWVVSaGNuUlRkMkZ3S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRvMk9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJqYjI1bWFXZDFjbVZmY0c5dmJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUmZabVZsWDJKd2MxOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUbzFPUzAyTWdvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdRV1J0YVc0S0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZOVEVLSUNBZ0lDOHZJR05zWVhOeklFTnlaWE5qWVVSaGNuUlRkMkZ3S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pVNUxUWXlDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCQlpHMXBiZ29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdjMlYwWDJabFpWOWljSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFM09nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUbzFNUW9nSUNBZ0x5OGdZMnhoYzNNZ1EzSmxjMk5oUkdGeWRGTjNZWEFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNURjbVZ6WTJGRVlYSjBVM2RoY0M1elpYUmZabVZsWDJKd2N5aG1aV1ZmWW5Cek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuTmxkRjltWldWZlluQnpPZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG8xT1MwMk13b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nUVdSdGFXNEtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2MyVjBYMlpsWlY5aWNITW9jMlZzWml3Z1ptVmxYMkp3Y3pvZ1lYSmpOQzVWU1c1ME5qUXBJQzArSUdGeVl6UXVRbTl2YkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG8yTkFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dZM0psWVhSdmNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TmpVS0lDQWdJQzh2SUdGemMyVnlkQ0JtWldWZlluQnpMbTVoZEdsMlpTQThQU0JWU1c1ME5qUW9UVUZZWDBaRlJWOUNVRk1wTENBaVJtVmxJSFJ2YnlCb2FXZG9JZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBd0lDOHZJREV3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdaV1VnZEc5dklHaHBaMmdLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TmpZS0lDQWdJQzh2SUhObGJHWXVabVZsWDJKd2N5NTJZV3gxWlNBOUlHWmxaVjlpY0hNdWJtRjBhWFpsQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ptWldWZlluQnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TmpjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzRNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNURjbVZ6WTJGRVlYSjBVM2RoY0M1amIyNW1hV2QxY21WZmNHOXZiQ2hoYzNObGRGOXBaRG9nWW5sMFpYTXNJR1Z1WVdKc1pXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZMjl1Wm1sbmRYSmxYM0J2YjJ3NkNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qWTVMVGN3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1kyOXVabWxuZFhKbFgzQnZiMndvYzJWc1ppd2dZWE56WlhSZmFXUTZJR0Z5WXpRdVZVbHVkRFkwTENCbGJtRmliR1ZrT2lCaGNtTTBMa0p2YjJ3cElDMCtJR0Z5WXpRdVFtOXZiRG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUbzNNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ1kzSmxZWFJ2Y2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZOek1LSUNBZ0lDOHZJR2xtSUdGemMyVjBYMmxrSUdsdUlITmxiR1l1Y0c5dmJITTZDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekEyWXpWbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR052Ym1acFozVnlaVjl3YjI5c1gyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPamMwQ2lBZ0lDQXZMeUJ3YjI5c0lEMGdjMlZzWmk1d2IyOXNjMXRoYzNObGRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ2YjJ4eklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG8zTlFvZ0lDQWdMeThnY0c5dmJDNWxibUZpYkdWa0lEMGdaVzVoWW14bFpBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JwYm5SaklEUWdMeThnTVRreUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZOellLSUNBZ0lDOHZJSE5sYkdZdWNHOXZiSE5iWVhOelpYUmZhV1JkSUQwZ2NHOXZiQzVqYjNCNUtDa0tJQ0FnSUdKdmVGOXdkWFFLQ21OdmJtWnBaM1Z5WlY5d2IyOXNYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZPRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnNE1Bb2dJQ0FnY21WMGMzVmlDZ3BqYjI1bWFXZDFjbVZmY0c5dmJGOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TnpndE9ETUtJQ0FnSUM4dklITmxiR1l1Y0c5dmJITmJZWE56WlhSZmFXUmRJRDBnVUc5dmJDZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXBaRDFoYzNObGRGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGJHZHZYM0psYzJWeWRtVTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVnpaWEoyWlQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCbGJtRmliR1ZrUFdWdVlXSnNaV1FzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2T0RBS0lDQWdJQzh2SUdGc1oyOWZjbVZ6WlhKMlpUMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pjNExUZ3pDaUFnSUNBdkx5QnpaV3htTG5CdmIyeHpXMkZ6YzJWMFgybGtYU0E5SUZCdmIyd29DaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E5WVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lXeG5iMTl5WlhObGNuWmxQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxjMlZ5ZG1VOVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pXNWhZbXhsWkQxbGJtRmliR1ZrTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qZ3hDaUFnSUNBdkx5QmhjM05sZEY5eVpYTmxjblpsUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZOemd0T0RNS0lDQWdJQzh2SUhObGJHWXVjRzl2YkhOYllYTnpaWFJmYVdSZElEMGdVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5cFpEMWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0JoYkdkdlgzSmxjMlZ5ZG1VOVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WelpYSjJaVDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JsYm1GaWJHVmtQV1Z1WVdKc1pXUXNDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUdOdmJtWnBaM1Z5WlY5d2IyOXNYMkZtZEdWeVgybG1YMlZzYzJWQU13b0tDaTh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1UTNKbGMyTmhSR0Z5ZEZOM1lYQXViM0IwWDJsdVgyRnpjMlYwS0dGemMyVjBYMmxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q205d2RGOXBibDloYzNObGREb0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZPRFl0T0RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnZjSFJmYVc1ZllYTnpaWFFvYzJWc1ppd2dZWE56WlhSZmFXUTZJR0Z5WXpRdVZVbHVkRFkwS1NBdFBpQmhjbU0wTGtKdmIydzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk9EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUdOeVpXRjBiM0lpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qZzVMVGswQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEY5cFpDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPamt3Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFdGemMyVjBYMmxrTG01aGRHbDJaU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG81TVFvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPamt5Q2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk9Ea0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG81TXdvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUbzRPUzA1TkFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZWE56WlhSZmFXUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2T1RVS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzRNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNURjbVZ6WTJGRVlYSjBVM2RoY0M1bWRXNWtYM0J2YjJ4ZllXeG5ieWh3WVhsdFpXNTBYM1I0YmpvZ2RXbHVkRFkwTENCaGMzTmxkRjlwWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwbWRXNWtYM0J2YjJ4ZllXeG5iem9LSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2T1RjdE1UQXhDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCUWIyOXNJR1oxYm1ScGJtY0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1puVnVaRjl3YjI5c1gyRnNaMjhvYzJWc1ppd2djR0Y1YldWdWRGOTBlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVMQ0JoYzNObGRGOXBaRG9nWVhKak5DNVZTVzUwTmpRcElDMCtJR0Z5WXpRdVFtOXZiRG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3hNRElLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgzUjRiaTV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVRYVnpkQ0JtZFc1a0lHRndjQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnWm5WdVpDQmhjSEFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRBekNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNWJXVnVkRjkwZUc0dVlXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlRVzF2ZFc1MElHMTFjM1FnWW1VZ1BpQXdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUVGdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE1EVUtJQ0FnSUM4dklIQnZiMndnUFNCelpXeG1MbDl5WlhGMWFYSmxYM0J2YjJ3b1lYTnpaWFJmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdYM0psY1hWcGNtVmZjRzl2YkFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE1EWUtJQ0FnSUM4dklIQnZiMnd1WVd4bmIxOXlaWE5sY25abElEMGdZWEpqTkM1VlNXNTBOalFvY0c5dmJDNWhiR2R2WDNKbGMyVnlkbVV1Ym1GMGFYWmxJQ3NnY0dGNWJXVnVkRjkwZUc0dVlXMXZkVzUwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdPQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TURjS0lDQWdJQzh2SUhObGJHWXVjRzl2YkhOYllYTnpaWFJmYVdSZElEMGdjRzl2YkM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGczTURaak5XWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pFd09Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoVWNuVmxLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRGd3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMa055WlhOallVUmhjblJUZDJGd0xtWjFibVJmY0c5dmJGOWhjM05sZENoaGMzTmxkRjkwZUc0NklIVnBiblEyTkN3Z1lYTnpaWFJmYVdRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1puVnVaRjl3YjI5c1gyRnpjMlYwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE1UQXRNVEUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1puVnVaRjl3YjI5c1gyRnpjMlYwS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmZEhodU9pQm5kSGh1TGtGemMyVjBWSEpoYm5ObVpYSlVjbUZ1YzJGamRHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjlwWkRvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVRbTl2YkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TVRZS0lDQWdJQzh2SUdGemMyVnlkQ0JoYzNObGRGOTBlRzR1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWsxMWMzUWdablZ1WkNCaGNIQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTExYzNRZ1puVnVaQ0JoY0hBS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1URTNDaUFnSUNBdkx5QmhjM05sY25RZ1lYTnpaWFJmZEhodUxtRnpjMlYwWDJGdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01DSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3hNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjM05sZEY5MGVHNHVlR1psY2w5aGMzTmxkQzVwWkNBOVBTQmhjM05sZEY5cFpDNXVZWFJwZG1Vc0lDSlhjbTl1WnlCaGMzTmxkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1YzSnZibWNnWVhOelpYUUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNVEl3Q2lBZ0lDQXZMeUJ3YjI5c0lEMGdjMlZzWmk1ZmNtVnhkV2x5WlY5d2IyOXNLR0Z6YzJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5eVpYRjFhWEpsWDNCdmIyd0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNVEl4Q2lBZ0lDQXZMeUJ3YjI5c0xtRnpjMlYwWDNKbGMyVnlkbVVnUFNCaGNtTTBMbFZKYm5RMk5DaHdiMjlzTG1GemMyVjBYM0psYzJWeWRtVXVibUYwYVhabElDc2dZWE56WlhSZmRIaHVMbUZ6YzJWMFgyRnRiM1Z1ZENrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF4TmdvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE1qSUtJQ0FnSUM4dklITmxiR1l1Y0c5dmJITmJZWE56WlhSZmFXUmRJRDBnY0c5dmJDNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01EWmpOV1lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qRXlNd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaFVjblZsS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURnd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TGtOeVpYTmpZVVJoY25SVGQyRndMbWRsZEY5eGRXOTBaVjlsZUdGamRGOXBiaWhoYzNObGRGOXBaRG9nWW5sMFpYTXNJR2x6WDJGc1oyOWZhVzQ2SUdKNWRHVnpMQ0JoYlc5MWJuUmZhVzQ2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFgzRjFiM1JsWDJWNFlXTjBYMmx1T2dvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE1qVXRNVE0wQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QlJkVzkwWlhNS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDNGMWIzUmxYMlY0WVdOMFgybHVLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDJGc1oyOWZhVzQ2SUdGeVl6UXVRbTl2YkN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZmFXNDZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnS1NBdFBpQmhjbU0wTGxWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3hNelVLSUNBZ0lDOHZJSEJ2YjJ3Z1BTQnpaV3htTGw5eVpYRjFhWEpsWDNCdmIyd29ZWE56WlhSZmFXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOaGJHeHpkV0lnWDNKbGNYVnBjbVZmY0c5dmJBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qRXpOZ29nSUNBZ0x5OGdZWE56WlhKMElIQnZiMnd1Wlc1aFlteGxaQzV1WVhScGRtVXNJQ0pRYjI5c0lHUnBjMkZpYkdWa0lnb2dJQ0FnYVc1MFl5QTBJQzh2SURFNU1nb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWVhOelpYSjBJQzh2SUZCdmIyd2daR2x6WVdKc1pXUUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNVE00Q2lBZ0lDQXZMeUJwWmlCcGMxOWhiR2R2WDJsdUxtNWhkR2wyWlRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbm9nWjJWMFgzRjFiM1JsWDJWNFlXTjBYMmx1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TkRBS0lDQWdJQzh2SUdGdGIzVnVkRjlwYmk1dVlYUnBkbVVzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRReENpQWdJQ0F2THlCd2IyOXNMbUZzWjI5ZmNtVnpaWEoyWlM1dVlYUnBkbVVzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TkRJS0lDQWdJQzh2SUhCdmIyd3VZWE56WlhSZmNtVnpaWEoyWlM1dVlYUnBkbVVzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pFek9TMHhORE1LSUNBZ0lDOHZJRzkxZENBOUlITmxiR1l1WDNGMWIzUmxYMlY0WVdOMFgybHVLQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRjlwYmk1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiQzVoYkdkdlgzSmxjMlZ5ZG1VdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lIQnZiMnd1WVhOelpYUmZjbVZ6WlhKMlpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBcENpQWdJQ0JqWVd4c2MzVmlJRjl4ZFc5MFpWOWxlR0ZqZEY5cGJnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3hORFFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h2ZFhRcENpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhSemRXSUtDbWRsZEY5eGRXOTBaVjlsZUdGamRGOXBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakUwTndvZ0lDQWdMeThnWVcxdmRXNTBYMmx1TG01aGRHbDJaU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TkRnS0lDQWdJQzh2SUhCdmIyd3VZWE56WlhSZmNtVnpaWEoyWlM1dVlYUnBkbVVzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRRNUNpQWdJQ0F2THlCd2IyOXNMbUZzWjI5ZmNtVnpaWEoyWlM1dVlYUnBkbVVzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRRMkxURTFNQW9nSUNBZ0x5OGdiM1YwSUQwZ2MyVnNaaTVmY1hWdmRHVmZaWGhoWTNSZmFXNG9DaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMmx1TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNMbUZ6YzJWMFgzSmxjMlZ5ZG1VdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lIQnZiMnd1WVd4bmIxOXlaWE5sY25abExtNWhkR2wyWlN3S0lDQWdJQzh2SUNrS0lDQWdJR05oYkd4emRXSWdYM0YxYjNSbFgyVjRZV04wWDJsdUNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qRTFNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLRzkxZENrS0lDQWdJR2wwYjJJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1UTNKbGMyTmhSR0Z5ZEZOM1lYQXVaMlYwWDJKbGMzUmZjWFZ2ZEdWZlpYaGhZM1JmYVc0b1lYTnpaWFJmYVdSek9pQmllWFJsY3l3Z1lXMXZkVzUwWDJsdU9pQmllWFJsY3l3Z2FYTmZZV3huYjE5cGJqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJmWW1WemRGOXhkVzkwWlY5bGVHRmpkRjlwYmpvS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1UVXpMVEUxT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOWlaWE4wWDNGMWIzUmxYMlY0WVdOMFgybHVLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1J6T2lCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0aGNtTTBMbFZKYm5RMk5GMHNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYMmx1T2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JwYzE5aGJHZHZYMmx1T2lCaGNtTTBMa0p2YjJ3c0NpQWdJQ0F2THlBcElDMCtJRUpsYzNSUmRXOTBaVG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1UWTBDaUFnSUNBdkx5QmhjM05sY25RZ1lYTnpaWFJmYVdSekxteGxibWQwYUNBK0lGVkpiblEyTkNnd0tTd2dJazV2SUdOaGJtUnBaR0YwWlhNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWTJGdVpHbGtZWFJsY3dvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE5qWUtJQ0FnSUM4dklHSmxjM1JmWVhOelpYUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakUyTndvZ0lDQWdMeThnWW1WemRGOXZkWFFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR1IxY0c0Z01nb0taMlYwWDJKbGMzUmZjWFZ2ZEdWZlpYaGhZM1JmYVc1ZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TmprS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hoYzNObGRGOXBaSE11YkdWdVozUm9LVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTRDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFgySmxjM1JmY1hWdmRHVmZaWGhoWTNSZmFXNWZZV1owWlhKZlptOXlRREV6Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pFM01Bb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQmhjM05sZEY5cFpITmJhVjBLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnT0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qRTNNUW9nSUNBZ0x5OGdhV1lnWVhOelpYUmZhV1FnYm05MElHbHVJSE5sYkdZdWNHOXZiSE02Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TnpBMll6Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdkbGRGOWlaWE4wWDNGMWIzUmxYMlY0WVdOMFgybHVYMlp2Y2w5bWIyOTBaWEpBTVRJS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1UY3pDaUFnSUNBdkx5QndiMjlzSUQwZ2MyVnNaaTV3YjI5c2MxdGhjM05sZEY5cFpGMHVZMjl3ZVNncENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnZiMnh6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3hOelFLSUNBZ0lDOHZJR2xtSUc1dmRDQndiMjlzTG1WdVlXSnNaV1F1Ym1GMGFYWmxPZ29nSUNBZ2FXNTBZeUEwSUM4dklERTVNZ29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lub2daMlYwWDJKbGMzUmZjWFZ2ZEdWZlpYaGhZM1JmYVc1ZlptOXlYMlp2YjNSbGNrQXhNZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TnpjS0lDQWdJQzh2SUdsbUlHbHpYMkZzWjI5ZmFXNHVibUYwYVhabE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZWlCblpYUmZZbVZ6ZEY5eGRXOTBaVjlsZUdGamRGOXBibDlsYkhObFgySnZaSGxBT0FvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE56a0tJQ0FnSUM4dklHRnRiM1Z1ZEY5cGJpNXVZWFJwZG1Vc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1UZ3dDaUFnSUNBdkx5QndiMjlzTG1Gc1oyOWZjbVZ6WlhKMlpTNXVZWFJwZG1Vc0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TVRneENpQWdJQ0F2THlCd2IyOXNMbUZ6YzJWMFgzSmxjMlZ5ZG1VdWJtRjBhWFpsTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE56Z3RNVGd5Q2lBZ0lDQXZMeUJ2ZFhRZ1BTQnpaV3htTGw5eGRXOTBaVjlsZUdGamRGOXBiaWdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmYVc0dWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lIQnZiMnd1WVd4bmIxOXlaWE5sY25abExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQndiMjlzTG1GemMyVjBYM0psYzJWeWRtVXVibUYwYVhabExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTJGc2JITjFZaUJmY1hWdmRHVmZaWGhoWTNSZmFXNEtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb0taMlYwWDJKbGMzUmZjWFZ2ZEdWZlpYaGhZM1JmYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE9UQUtJQ0FnSUM4dklHbG1JRzkxZENBK0lHSmxjM1JmYjNWME9nb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQStDaUFnSUNCaWVpQm5aWFJmWW1WemRGOXhkVzkwWlY5bGVHRmpkRjlwYmw5bWIzSmZabTl2ZEdWeVFERXlDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakU1TWdvZ0lDQWdMeThnWW1WemRGOWhjM05sZENBOUlHRnpjMlYwWDJsa0xtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBM0NncG5aWFJmWW1WemRGOXhkVzkwWlY5bGVHRmpkRjlwYmw5bWIzSmZabTl2ZEdWeVFERXlPZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94TmprS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hoYzNObGRGOXBaSE11YkdWdVozUm9LVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0E0Q2lBZ0lDQmlJR2RsZEY5aVpYTjBYM0YxYjNSbFgyVjRZV04wWDJsdVgyWnZjbDlvWldGa1pYSkFNUW9LWjJWMFgySmxjM1JmY1hWdmRHVmZaWGhoWTNSZmFXNWZaV3h6WlY5aWIyUjVRRGc2Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pFNE5Rb2dJQ0FnTHk4Z1lXMXZkVzUwWDJsdUxtNWhkR2wyWlN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE9EWUtJQ0FnSUM4dklIQnZiMnd1WVhOelpYUmZjbVZ6WlhKMlpTNXVZWFJwZG1Vc0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pFNE53b2dJQ0FnTHk4Z2NHOXZiQzVoYkdkdlgzSmxjMlZ5ZG1VdWJtRjBhWFpsTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pFNE5DMHhPRGdLSUNBZ0lDOHZJRzkxZENBOUlITmxiR1l1WDNGMWIzUmxYMlY0WVdOMFgybHVLQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRjlwYmk1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiQzVoYzNObGRGOXlaWE5sY25abExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQndiMjlzTG1Gc1oyOWZjbVZ6WlhKMlpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBcENpQWdJQ0JqWVd4c2MzVmlJRjl4ZFc5MFpWOWxlR0ZqZEY5cGJnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0JpSUdkbGRGOWlaWE4wWDNGMWIzUmxYMlY0WVdOMFgybHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb0taMlYwWDJKbGMzUmZjWFZ2ZEdWZlpYaGhZM1JmYVc1ZllXWjBaWEpmWm05eVFERXpPZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG94T1RRS0lDQWdJQzh2SUhKbGRIVnliaUJDWlhOMFVYVnZkR1VvWVhOelpYUmZhV1E5WVhKak5DNVZTVzUwTmpRb1ltVnpkRjloYzNObGRDa3NJR0Z0YjNWdWRGOXZkWFE5WVhKak5DNVZTVzUwTmpRb1ltVnpkRjl2ZFhRcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURZS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzVEY21WelkyRkVZWEowVTNkaGNDNXpkMkZ3WDJWNFlXTjBYMkZzWjI5ZlptOXlYMkZ6YzJWMEtIQmhlVzFsYm5SZmRIaHVPaUIxYVc1ME5qUXNJR0Z6YzJWMFgybGtPaUJpZVhSbGN5d2diV2x1WDJGemMyVjBYMjkxZERvZ1lubDBaWE1zSUhKbFkybHdhV1Z1ZERvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwemQyRndYMlY0WVdOMFgyRnNaMjlmWm05eVgyRnpjMlYwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveE9UWXRNakEyQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QlRkMkZ3Y3dvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJ6ZDJGd1gyVjRZV04wWDJGc1oyOWZabTl5WDJGemMyVjBLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkRjkwZUc0NklHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJsa09pQmhjbU0wTGxWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCdGFXNWZZWE56WlhSZmIzVjBPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnlaV05wY0dsbGJuUTZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNrZ0xUNGdZWEpqTkM1VlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNakEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRGOTBlRzR1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3Z0lrMTFjM1FnY0dGNUlHRndjQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnY0dGNUlHRndjQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG95TURnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYM1I0Ymk1aGJXOTFiblFnUGlCVlNXNTBOalFvTUNrc0lDSkJiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnUVcxdmRXNTBJRzExYzNRZ1ltVWdQaUF3Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJeE1Bb2dJQ0FnTHk4Z2NHOXZiQ0E5SUhObGJHWXVYM0psY1hWcGNtVmZjRzl2YkNoaGMzTmxkRjlwWkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMkZzYkhOMVlpQmZjbVZ4ZFdseVpWOXdiMjlzQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCdmIyd3VaVzVoWW14bFpDNXVZWFJwZG1Vc0lDSlFiMjlzSUdScGMyRmliR1ZrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVGt5Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmhjM05sY25RZ0x5OGdVRzl2YkNCa2FYTmhZbXhsWkFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveU1UVUtJQ0FnSUM4dklIQnZiMnd1WVd4bmIxOXlaWE5sY25abExtNWhkR2wyWlN3S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJeE5nb2dJQ0FnTHk4Z2NHOXZiQzVoYzNObGRGOXlaWE5sY25abExtNWhkR2wyWlN3S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qSXhNeTB5TVRjS0lDQWdJQzh2SUdGdGIzVnVkRjl2ZFhRZ1BTQnpaV3htTGw5eGRXOTBaVjlsZUdGamRGOXBiaWdLSUNBZ0lDOHZJQ0FnSUNCd1lYbHRaVzUwWDNSNGJpNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkM1aGJHZHZYM0psYzJWeWRtVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ3dVlYTnpaWFJmY21WelpYSjJaUzV1WVhScGRtVXNDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOXhkVzkwWlY5bGVHRmpkRjlwYmdvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveU1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblJmYjNWMElENDlJRzFwYmw5aGMzTmxkRjl2ZFhRdWJtRjBhWFpsTENBaVUyeHBjSEJoWjJVZ1pYaGpaV1ZrWldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRk5zYVhCd1lXZGxJR1Y0WTJWbFpHVmtDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakl4T1FvZ0lDQWdMeThnWVhOelpYSjBJR0Z0YjNWdWRGOXZkWFFnUGlCVlNXNTBOalFvTUNrc0lDSk9ieUJ2ZFhSd2RYUWlDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QnZkWFJ3ZFhRS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1qSXdDaUFnSUNBdkx5QmhjM05sY25RZ2NHOXZiQzVoYzNObGRGOXlaWE5sY25abExtNWhkR2wyWlNBK1BTQmhiVzkxYm5SZmIzVjBMQ0FpU1c1emRXWm1hV05wWlc1MElIQnZiMndnYkdseGRXbGthWFI1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUhCdmIyd2diR2x4ZFdsa2FYUjVDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakl5TWdvZ0lDQWdMeThnY0c5dmJDNWhiR2R2WDNKbGMyVnlkbVVnUFNCaGNtTTBMbFZKYm5RMk5DaHdiMjlzTG1Gc1oyOWZjbVZ6WlhKMlpTNXVZWFJwZG1VZ0t5QndZWGx0Wlc1MFgzUjRiaTVoYlc5MWJuUXBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNd29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQTRDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakl5TXdvZ0lDQWdMeThnY0c5dmJDNWhjM05sZEY5eVpYTmxjblpsSUQwZ1lYSmpOQzVWU1c1ME5qUW9jRzl2YkM1aGMzTmxkRjl5WlhObGNuWmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRGOXZkWFFwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBeE5nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lNalFLSUNBZ0lDOHZJSE5sYkdZdWNHOXZiSE5iWVhOelpYUmZhV1JkSUQwZ2NHOXZiQzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNRFpqTldZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakl5TmkweU16RUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBYMmxrTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajF5WldOcGNHbGxiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMWhiVzkxYm5SZmIzVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qSXlOd29nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDFoYzNObGRGOXBaQzV1WVhScGRtVXNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNakkyQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1qTXdDaUFnSUNBdkx5Qm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJeU5pMHlNekVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwWDJsa0xtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxeVpXTnBjR2xsYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUmZiM1YwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG95TXpVS0lDQWdJQzh2SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNak00Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNod1lYbHRaVzUwWDNSNGJpNWhiVzkxYm5RcExBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJek9Rb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9ZVzF2ZFc1MFgyOTFkQ2tzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNak16TFRJME1Bb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtBb2dJQ0FnTHk4Z0lDQWdJQ0pUZDJGd1JYaGxZM1YwWldRb1lXUmtjbVZ6Y3l4MWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVRbTl2YkNoVWNuVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHdZWGx0Wlc1MFgzUjRiaTVoYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtHRnRiM1Z1ZEY5dmRYUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lNemNLSUNBZ0lDOHZJR0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzRNQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG95TXpNdE1qUXdDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9DaUFnSUNBdkx5QWdJQ0FnSWxOM1lYQkZlR1ZqZFhSbFpDaGhaR1J5WlhOekxIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRcElpd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSEJoZVcxbGJuUmZkSGh1TG1GdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9ZVzF2ZFc1MFgyOTFkQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTJJQzh2SUcxbGRHaHZaQ0FpVTNkaGNFVjRaV04xZEdWa0tHRmtaSEpsYzNNc2RXbHVkRFkwTEdKdmIyd3NkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lORElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2hoYlc5MWJuUmZiM1YwS1FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzVEY21WelkyRkVZWEowVTNkaGNDNXpkMkZ3WDJWNFlXTjBYMkZ6YzJWMFgyWnZjbDloYkdkdktHRnpjMlYwWDNSNGJqb2dkV2x1ZERZMExDQmhjM05sZEY5cFpEb2dZbmwwWlhNc0lHMXBibDloYkdkdlgyOTFkRG9nWW5sMFpYTXNJSEpsWTJsd2FXVnVkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3B6ZDJGd1gyVjRZV04wWDJGemMyVjBYMlp2Y2w5aGJHZHZPZ29nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG95TkRRdE1qVXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYzNkaGNGOWxlR0ZqZEY5aGMzTmxkRjltYjNKZllXeG5ieWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM1I0YmpvZ1ozUjRiaTVCYzNObGRGUnlZVzV6Wm1WeVZISmhibk5oWTNScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJRzFwYmw5aGJHZHZYMjkxZERvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnY21WamFYQnBaVzUwT2lCaGNtTTBMa0ZrWkhKbGMzTXNDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJMU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdGemMyVjBYM1I0Ymk1aGMzTmxkRjl5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVRYVnpkQ0J3WVhrZ1lYQndJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElIQmhlU0JoY0hBS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1qVXpDaUFnSUNBdkx5QmhjM05sY25RZ1lYTnpaWFJmZEhodUxtRnpjMlYwWDJGdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01DSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjM05sZEY5MGVHNHVlR1psY2w5aGMzTmxkQzVwWkNBOVBTQmhjM05sZEY5cFpDNXVZWFJwZG1Vc0lDSlhjbTl1WnlCaGMzTmxkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSjBiMmtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1YzSnZibWNnWVhOelpYUUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNalUyQ2lBZ0lDQXZMeUJ3YjI5c0lEMGdjMlZzWmk1ZmNtVnhkV2x5WlY5d2IyOXNLR0Z6YzJWMFgybGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCallXeHNjM1ZpSUY5eVpYRjFhWEpsWDNCdmIyd0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNalUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjRzl2YkM1bGJtRmliR1ZrTG01aGRHbDJaU3dnSWxCdmIyd2daR2x6WVdKc1pXUWlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE9USUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdGemMyVnlkQ0F2THlCUWIyOXNJR1JwYzJGaWJHVmtDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakkyTVFvZ0lDQWdMeThnY0c5dmJDNWhjM05sZEY5eVpYTmxjblpsTG01aGRHbDJaU3dLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG95TmpJS0lDQWdJQzh2SUhCdmIyd3VZV3huYjE5eVpYTmxjblpsTG01aGRHbDJaU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TWpVNUxUSTJNd29nSUNBZ0x5OGdZVzF2ZFc1MFgyOTFkQ0E5SUhObGJHWXVYM0YxYjNSbFgyVjRZV04wWDJsdUtBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzUjRiaTVoYzNObGRGOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkM1aGMzTmxkRjl5WlhObGNuWmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0J3YjI5c0xtRnNaMjlmY21WelpYSjJaUzV1WVhScGRtVXNDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOXhkVzkwWlY5bGVHRmpkRjlwYmdvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveU5qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblJmYjNWMElENDlJRzFwYmw5aGJHZHZYMjkxZEM1dVlYUnBkbVVzSUNKVGJHbHdjR0ZuWlNCbGVHTmxaV1JsWkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURFS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMnhwY0hCaFoyVWdaWGhqWldWa1pXUUtJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNalkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MFgyOTFkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrNXZJRzkxZEhCMWRDSUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklHOTFkSEIxZEFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveU5qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCd2IyOXNMbUZzWjI5ZmNtVnpaWEoyWlM1dVlYUnBkbVVnUGowZ1lXMXZkVzUwWDI5MWRDd2dJa2x1YzNWbVptbGphV1Z1ZENCd2IyOXNJR3hwY1hWcFpHbDBlU0lLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1ZtWm1samFXVnVkQ0J3YjI5c0lHeHBjWFZwWkdsMGVRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lOamdLSUNBZ0lDOHZJSEJ2YjJ3dVlYTnpaWFJmY21WelpYSjJaU0E5SUdGeVl6UXVWVWx1ZERZMEtIQnZiMnd1WVhOelpYUmZjbVZ6WlhKMlpTNXVZWFJwZG1VZ0t5QmhjM05sZEY5MGVHNHVZWE56WlhSZllXMXZkVzUwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTVRZS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1qWTVDaUFnSUNBdkx5QndiMjlzTG1Gc1oyOWZjbVZ6WlhKMlpTQTlJR0Z5WXpRdVZVbHVkRFkwS0hCdmIyd3VZV3huYjE5eVpYTmxjblpsTG01aGRHbDJaU0F0SUdGdGIzVnVkRjl2ZFhRcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEZ0tJQ0FnSUM4dklHTnlaWE5qWVY5a1lYSjBYM04zWVhBdWNIazZNamN3Q2lBZ0lDQXZMeUJ6Wld4bUxuQnZiMnh6VzJGemMyVjBYMmxrWFNBOUlIQnZiMnd1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekEyWXpWbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG95TnpJdE1qYzJDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWNtVmphWEJwWlc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwWDI5MWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJM01nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lOelVLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1qY3lMVEkzTmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWEpsWTJsd2FXVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z0YjNWdWRGOXZkWFFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakk0TUFvZ0lDQWdMeThnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJSaGNuUmZjM2RoY0M1d2VUb3lPRE1LSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0dGemMyVjBYM1I0Ymk1aGMzTmxkRjloYlc5MWJuUXBMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qSTROQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvWVcxdmRXNTBYMjkxZENrc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TWpjNExUSTROUW9nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQW9nSUNBZ0x5OGdJQ0FnSUNKVGQyRndSWGhsWTNWMFpXUW9ZV1JrY21WemN5eDFhVzUwTmpRc1ltOXZiQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvWVhOelpYUmZkSGh1TG1GemMyVjBYMkZ0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb1lXMXZkVzUwWDI5MWRDa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qSTRNZ29nSUNBZ0x5OGdZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG95TnpndE1qZzFDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9DaUFnSUNBdkx5QWdJQ0FnSWxOM1lYQkZlR1ZqZFhSbFpDaGhaR1J5WlhOekxIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRcElpd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2hoYzNObGRGOTBlRzR1WVhOelpYUmZZVzF2ZFc1MEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoaGJXOTFiblJmYjNWMEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdiV1YwYUc5a0lDSlRkMkZ3UlhobFkzVjBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXNZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pJNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtHRnRiM1Z1ZEY5dmRYUXBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xrTnlaWE5qWVVSaGNuUlRkMkZ3TG1kbGRGOXdiMjlzS0dGemMyVjBYMmxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGOXdiMjlzT2dvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRveU9Ea3RNamt6Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QldhV1YzY3dvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmY0c5dmJDaHpaV3htTENCaGMzTmxkRjlwWkRvZ1lYSmpOQzVWU1c1ME5qUXBJQzArSUZCdmIydzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk1qazBDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVmY21WeGRXbHlaVjl3YjI5c0tHRnpjMlYwWDJsa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjl5WlhGMWFYSmxYM0J2YjJ3S0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1UTNKbGMyTmhSR0Z5ZEZOM1lYQXVaMlYwWDJabFpWOWljSE1vS1NBdFBpQmllWFJsY3pvS1oyVjBYMlpsWlY5aWNITTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPakk1T0FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVabVZsWDJKd2N5NTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ptWldWZlluQnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1abFpWOWljSE1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xrTnlaWE5qWVVSaGNuUlRkMkZ3TG1aMWJtUmZZMjl1ZEhKaFkzUW9jR0Y1YldWdWRGOTBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21aMWJtUmZZMjl1ZEhKaFkzUTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPak13TUMwek1ERUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJtZFc1a1gyTnZiblJ5WVdOMEtITmxiR1lzSUhCaGVXMWxiblJmZEhodU9pQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2YmlrZ0xUNGdZWEpqTkM1Q2IyOXNPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qTXdNZ29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5SZmRIaHVMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKTmRYTjBJR1oxYm1RZ1lYQndJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RYVnpkQ0JtZFc1a0lHRndjQW9nSUNBZ0x5OGdZM0psYzJOaFgyUmhjblJmYzNkaGNDNXdlVG96TURNS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYM1I0Ymk1aGJXOTFiblFnUGlCVlNXNTBOalFvTUNrc0lDSkJiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWVhOelpYSjBJQzh2SUVGdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRvek1EUUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1ZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGc0TUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzVEY21WelkyRkVZWEowVTNkaGNDNWZjbVZ4ZFdseVpWOXdiMjlzS0dGemMyVjBYMmxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2w5eVpYRjFhWEpsWDNCdmIydzZDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPak13Tmkwek1UQUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUVobGJIQmxjbk1LSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjl5WlhGMWFYSmxYM0J2YjJ3b2MyVnNaaXdnWVhOelpYUmZhV1E2SUdGeVl6UXVWVWx1ZERZMEtTQXRQaUJRYjI5c09nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pNeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGemMyVjBYMmxrSUdsdUlITmxiR1l1Y0c5dmJITXNJQ0pRYjI5c0lHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNRFpqTldZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGQnZiMndnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pNeE1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjRzl2YkhOYllYTnpaWFJmYVdSZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHOXZiSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0J5WlhSemRXSUtDZ292THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TGtOeVpYTmpZVVJoY25SVGQyRndMbDl4ZFc5MFpWOWxlR0ZqZEY5cGJpaGhiVzkxYm5SZmFXNDZJSFZwYm5RMk5Dd2djbVZ6WlhKMlpWOXBiam9nZFdsdWREWTBMQ0J5WlhObGNuWmxYMjkxZERvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNsOXhkVzkwWlY5bGVHRmpkRjlwYmpvS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk16RTBMVE15TUFvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQmZjWFZ2ZEdWZlpYaGhZM1JmYVc0b0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZmFXNDZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxYMmx1T2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlY5dmRYUTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCamNtVnpZMkZmWkdGeWRGOXpkMkZ3TG5CNU9qTXlNUW9nSUNBZ0x5OGdZWE56WlhKMElISmxjMlZ5ZG1WZmFXNGdQaUJWU1c1ME5qUW9NQ2tzSUNKRmJYQjBlU0J3YjI5c0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoYzNObGNuUWdMeThnUlcxd2RIa2djRzl2YkFvZ0lDQWdMeThnWTNKbGMyTmhYMlJoY25SZmMzZGhjQzV3ZVRvek1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYTmxjblpsWDI5MWRDQStJRlZKYm5RMk5DZ3dLU3dnSWtWdGNIUjVJSEJ2YjJ3aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWeWRDQXZMeUJGYlhCMGVTQndiMjlzQ2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pNeU5Bb2dJQ0FnTHk4Z1ptVmxYMjExYkhScGNHeHBaWElnUFNCVlNXNTBOalFvUmtWRlgwSlFVMTlFUlU1UFRTa2dMU0J6Wld4bUxtWmxaVjlpY0hNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSm1aV1ZmWW5Ceklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVpsWlY5aWNITWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd0lDOHZJREV3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJqY21WelkyRmZaR0Z5ZEY5emQyRndMbkI1T2pNeU5Rb2dJQ0FnTHk4Z1lXMXZkVzUwWDJsdVgyRm1kR1Z5WDJabFpTQTlJQ2hoYlc5MWJuUmZhVzRnS2lCbVpXVmZiWFZzZEdsd2JHbGxjaWtnTHk4Z1ZVbHVkRFkwS0VaRlJWOUNVRk5mUkVWT1QwMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lDOHZJR055WlhOallWOWtZWEowWDNOM1lYQXVjSGs2TXpJMkNpQWdJQ0F2THlCdWRXMWxjbUYwYjNJZ1BTQmhiVzkxYm5SZmFXNWZZV1owWlhKZlptVmxJQ29nY21WelpYSjJaVjl2ZFhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXFDaUFnSUNBdkx5QmpjbVZ6WTJGZlpHRnlkRjl6ZDJGd0xuQjVPak15TndvZ0lDQWdMeThnWkdWdWIyMXBibUYwYjNJZ1BTQnlaWE5sY25abFgybHVJQ3NnWVcxdmRXNTBYMmx1WDJGbWRHVnlYMlpsWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJQzh2SUdOeVpYTmpZVjlrWVhKMFgzTjNZWEF1Y0hrNk16STRDaUFnSUNBdkx5QnlaWFIxY200Z2JuVnRaWEpoZEc5eUlDOHZJR1JsYm05dGFXNWhkRzl5Q2lBZ0lDQXZDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZBUWdBRU1BQkpnY0VGUjk4ZFFHQUEzQnNYd0VBQjJabFpWOWljSE1JQUFBQUFBQUFBQUFFSlh3Mkh6RVlRQUFGSndTQkhtY3hHMEVCODRJTUJIWkZ3NjRFQ0xJVkhRVEVzZWVaQk55Sjlyc0VseEVIVXdSTytDNzFCTHRNaVBZRTAvRTRVUVE4SFRHWEJENmNFTThFWGwycHl3UVZaSFdvTmhvQWpnd0JnQUZnQVVnQkpnRURBTnNBcXdCNEFFUUFMQUFjQUFJa1F6RVpGRVF4R0VReEZpSUpTVGdRSWhKRWlBUkpLRXhRc0NKRE1Sa1VSREVZUklnRU1paE1VTEFpUXpFWkZFUXhHRVEyR2dGSkZTTVNSSWdFRVNoTVVMQWlRekVaRkVReEdFUXhGaUlKU1RnUWdRUVNSRFlhQVVrVkl4SkVOaG9DU1JVakVrUTJHZ05KRllFZ0VrU0lBMUVvVEZDd0lrTXhHUlJFTVJoRU1SWWlDVWs0RUNJU1JEWWFBVWtWSXhKRU5ob0NTUlVqRWtRMkdnTkpGWUVnRWtTSUFwUW9URkN3SWtNeEdSUkVNUmhFTmhvQlNTUlpJd3VCQWdoTEFSVVNSRFlhQWtrVkl4SkVOaG9EU1JVaUVrU0lBY1lvVEZDd0lrTXhHUlJFTVJoRU5ob0JTUlVqRWtRMkdnSkpGU0lTUkRZYUEwa1ZJeEpFaUFGbEtFeFFzQ0pETVJrVVJERVlSREVXSWdsSk9CQ0JCQkpFTmhvQlNSVWpFa1NJQVJJb1RGQ3dJa014R1JSRU1SaEVNUllpQ1VrNEVDSVNSRFlhQVVrVkl4SkVpQURKS0V4UXNDSkRNUmtVUkRFWVJEWWFBVWtWSXhKRWlBQ1JLRXhRc0NKRE1Sa1VSREVZUkRZYUFVa1ZJeEpFTmhvQ1NSVWlFa1NJQUVBb1RGQ3dJa014R1JSRU1SaEVOaG9CU1JVakVrU0lBQkVvVEZDd0lrTXhHVUQrWXpFWUZFUWlRNG9CQVRFQU1na1NSSXYvRjBtQlpBNUVKd1JNWnltSmlnSUJNUUF5Q1JKRUtvditVRW05UlFGQkFBNUp2a1NML3lSVElRUk1WTDhwaVl2K0p3VlFKd1ZRaS85UXYwTC83NG9CQVRFQU1na1NSTEdML3hjeUNpU3lFcklVc2hHQkJMSVFKTElCc3ltSmlnSUJpLzQ0QnpJS0VrU0wvamdJU1VTTC80Z0NVRWtqVzA4Q0NCWmNDQ3FMLzFCTXZ5bUppZ0lCaS80NEZESUtFa1NML2pnU1NVU0wvamdSaS84WEVrU0wvNGdDSUVrbFcwOENDQlpjRUNxTC8xQk12eW1KaWdNQmkvMklBZ2RKSVFSVEt5UlBBbFFrVTBTTC9pUlRRUUFQaS84WFRFa2pXMHdsVzRnQjloYUppLzhYVEVrbFcwd2pXNGdCNXhhSmlnTUJKRWNDZ0FCSmkvMGtXVWxFSkVjQ2l3aUxCUXhCQUhxTC9WY0NBRW1NQUlzSUl3dEpqQU1qV0NwTVVFbU1BYjFGQVVFQVFZc0J2a3hKVGdLTUFrUWhCRk1ySkU4Q1ZDUlRRUUFxaS84a1UwRUFMSXYrRjRzQ1NTTmJUQ1ZiaUFHQ2pBU0xCSXNIRFVFQUM0c0Fpd05iakFhTEJJd0hpd2dpQ0l3SVF2K1JpLzRYaXdKSkpWdE1JMXVJQVZhTUJFTC8wWXNHRm9zSEZsQ01BSW1LQkFHTC9EZ0hNZ29TUkl2OE9BaEpSSXY5aUFFaVNTRUVVeXNrVHdKVUpGTkVTU05iU3dFbFcwc0RTd0pMQW9nQkZZditGMHNCRGtSSlJFeExBUTlFVEVzRENCWlBBa3hjQ0VrbFcwc0NDUlpjRUNxTC9WQk12N0dML1JkTEFiSVNpLyt5RkxJUmdRU3lFQ1N5QWJNeEFFOENGazhDRms4Q2kvMVFLVkJQQWxCTEFWQW5Ca3hRc0ltS0JBR0wvRGdVTWdvU1JJdjhPQkpKUkl2OE9CR0wvUmNTUkl2OWlBQ1BTU0VFVXlza1R3SlVKRk5FU1NWYlN3RWpXMHNEU3dKTEFvZ0Fnb3YrRjBzQkRrUkpSRXhMQVE5RVRFc0RDQlpQQWt4Y0VFa2pXMHNDQ1JaY0NDcUwvVkJNdjdGSnNnaUwvN0lISXJJUUpMSUJzekVBVHdJV1R3SVdUd0tML1ZBclVFOENVRXNCVUNjR1RGQ3dpWW9CQVl2L2lBQWFpU1FuQkdWRUZvbUtBUUdML3pnSE1nb1NSSXYvT0FoRUtZbUtBUUVxaS85UVNiMUZBVVMrUkltS0F3R0wva1NMLzBRa0p3UmxSSUdRVGt3SmkvMExnWkJPQ2ttTC93dUwvazhDQ0FxSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjExLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJTd2FwRXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
