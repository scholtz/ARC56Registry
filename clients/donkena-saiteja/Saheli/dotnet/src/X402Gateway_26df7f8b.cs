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

namespace Arc56.Generated.donkena_saiteja.Saheli.X402Gateway_26df7f8b
{


    //
    // Records and splits x402 pay-per-use settlements.
    //
    public class X402GatewayProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public X402GatewayProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PaymentReceipt : AVMObjectType
            {
                public Algorand.Address Payer { get; set; }

                public string ResourceId { get; set; }

                public ulong Amount { get; set; }

                public ulong TreasuryShare { get; set; }

                public ulong Timestamp { get; set; }

                public ulong RoundSettled { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResourceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vResourceId.From(ResourceId);
                    stringRef[ret.Count] = vResourceId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTreasuryShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTreasuryShare.From(TreasuryShare);
                    ret.AddRange(vTreasuryShare.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoundSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRoundSettled.From(RoundSettled);
                    ret.AddRange(vRoundSettled.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PaymentReceipt Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PaymentReceipt();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    var indexResourceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResourceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vResourceId.Decode(bytes.Skip(indexResourceId + prefixOffset).ToArray());
                    var valueResourceId = vResourceId.ToValue();
                    if (valueResourceId is string vResourceIdValue) { ret.ResourceId = vResourceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTreasuryShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTreasuryShare.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTreasuryShare = vTreasuryShare.ToValue();
                    if (valueTreasuryShare is ulong vTreasuryShareValue) { ret.TreasuryShare = vTreasuryShareValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoundSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRoundSettled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRoundSettled = vRoundSettled.ToValue();
                    if (valueRoundSettled is ulong vRoundSettledValue) { ret.RoundSettled = vRoundSettledValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentReceipt);
                }
                public bool Equals(PaymentReceipt? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentReceipt left, PaymentReceipt right)
                {
                    return EqualityComparer<PaymentReceipt>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentReceipt left, PaymentReceipt right)
                {
                    return !(left == right);
                }

            }

            public class RevenueSummaryReturn : AVMObjectType
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

                public static RevenueSummaryReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RevenueSummaryReturn();
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
                    return Equals(obj as RevenueSummaryReturn);
                }
                public bool Equals(RevenueSummaryReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RevenueSummaryReturn left, RevenueSummaryReturn right)
                {
                    return EqualityComparer<RevenueSummaryReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(RevenueSummaryReturn left, RevenueSummaryReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="treasury"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="share_bps"> </param>
        public async Task Configure(Algorand.Address treasury, ulong asset_id, ulong share_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 96, 84, 3 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var share_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_bpsAbi.From(share_bps);

            var result = await base.CallApp(new List<object> { abiHandle, treasuryAbi, asset_idAbi, share_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(Algorand.Address treasury, ulong asset_id, ulong share_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 96, 84, 3 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var share_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); share_bpsAbi.From(share_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasuryAbi, asset_idAbi, share_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verifies the x402 payment transfer sitting in this atomic group, writes
        ///a receipt, and forwards the treasury's share.
        ///Returns the receipt id.
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="resource_id"> </param>
        public async Task<ulong> Settle(AssetTransferTransaction payment, string resource_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 23, 248, 1, 247 };
            var resource_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); resource_idAbi.From(resource_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment, resource_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Settle_Transactions(AssetTransferTransaction payment, string resource_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 23, 248, 1, 247 };
            var resource_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); resource_idAbi.From(resource_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, resource_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="receipt_id"> </param>
        public async Task<Structs.PaymentReceipt> GetReceipt(ulong receipt_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 38, 80, 49 };
            var receipt_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); receipt_idAbi.From(receipt_id);

            var result = await base.SimApp(new List<object> { abiHandle, receipt_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PaymentReceipt.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetReceipt_Transactions(ulong receipt_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 38, 80, 49 };
            var receipt_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); receipt_idAbi.From(receipt_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, receipt_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns (total calls, gross revenue, amount routed to treasury).
        ///</summary>
        public async Task<Structs.RevenueSummaryReturn> RevenueSummary(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 216, 24, 137 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RevenueSummaryReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RevenueSummary_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 216, 24, 137 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opts the application account into the settlement asset.
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task OptInToAsset(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 84, 232, 170 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWDQwMkdhdGV3YXkiLCJkZXNjIjoiUmVjb3JkcyBhbmQgc3BsaXRzIHg0MDIgcGF5LXBlci11c2Ugc2V0dGxlbWVudHMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlBheW1lbnRSZWNlaXB0IjpbeyJuYW1lIjoicGF5ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlc291cmNlX2lkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0cmVhc3VyeV9zaGFyZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicm91bmRfc2V0dGxlZCIsInR5cGUiOiJ1aW50NjQifV0sIlJldmVudWVTdW1tYXJ5UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNvbmZpZ3VyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJlYXN1cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZV9icHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlIiwiZGVzYyI6IlZlcmlmaWVzIHRoZSB4NDAyIHBheW1lbnQgdHJhbnNmZXIgc2l0dGluZyBpbiB0aGlzIGF0b21pYyBncm91cCwgd3JpdGVzXG5hIHJlY2VpcHQsIGFuZCBmb3J3YXJkcyB0aGUgdHJlYXN1cnkncyBzaGFyZS5cblJldHVybnMgdGhlIHJlY2VpcHQgaWQuIiwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzb3VyY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVjZWlwdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXB0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHN0cmluZyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUGF5bWVudFJlY2VpcHQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldmVudWVfc3VtbWFyeSIsImRlc2MiOiJSZXR1cm5zICh0b3RhbCBjYWxscywgZ3Jvc3MgcmV2ZW51ZSwgYW1vdW50IHJvdXRlZCB0byB0cmVhc3VyeSkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJSZXZlbnVlU3VtbWFyeVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX3RvX2Fzc2V0IiwiZGVzYyI6Ik9wdHMgdGhlIGFwcGxpY2F0aW9uIGFjY291bnQgaW50byB0aGUgc2V0dGxlbWVudCBhc3NldC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjUsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMDZdLCJlcnJvck1lc3NhZ2UiOiJhbW91bnQgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNSw1MjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MCw0MjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFzc2V0X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MSw0ODVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2NhbGxzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMiw0OTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3JldmVudWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEyLDQ5NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfdG9fdHJlYXN1cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50cmVhc3VyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRyZWFzdXJ5X3NoYXJlX2JwcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOCwyMjcsNDYxLDUxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNF0sImVycm9yTWVzc2FnZSI6Im11c3Qgbm90IGNsb3NlIGFzc2V0IGhvbGRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjJdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IG5vdCByZWtleSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNyw1MjZdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQzXSwiZXJyb3JNZXNzYWdlIjoic2hhcmUgY2Fubm90IGV4Y2VlZCAxMDAlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3Ml0sImVycm9yTWVzc2FnZSI6InVua25vd24gcmVjZWlwdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMF0sImVycm9yTWVzc2FnZSI6Indyb25nIHJlY2VpdmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkyXSwiZXJyb3JNZXNzYWdlIjoid3Jvbmcgc2V0dGxlbWVudCBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBMENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaGMzTmxkRjlwWkNJZ0luUnZkR0ZzWDJOaGJHeHpJaUFpZEc5MFlXeGZjbVYyWlc1MVpTSWdJblJ2ZEdGc1gzUnZYM1J5WldGemRYSjVJaUFpWVdSdGFXNGlJQ0owY21WaGMzVnllU0lnSW5SeVpXRnpkWEo1WDNOb1lYSmxYMkp3Y3lJZ01IZ3hOVEZtTjJNM05TQXdlRGN5TmpNM01EYzBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1SUQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJ6Wld4bUxuUnlaV0Z6ZFhKNUlEMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEhKbFlYTjFjbmtpQ2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5bllYUmxkMkY1TDJOdmJuUnlZV04wTG5CNU9qUTNMVFE0Q2lBZ0lDQXZMeUFqSUZObGRIUnNaVzFsYm5RZ1lYTnpaWFFnS0ZWVFJFTWdiMjRnZEdobElHRmpkR2wyWlNCdVpYUjNiM0pyS1M0S0lDQWdJQzh2SUhObGJHWXVZWE56WlhSZmFXUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDluWVhSbGQyRjVMMk52Ym5SeVlXTjBMbkI1T2pVd0xUVXhDaUFnSUNBdkx5QWpJRk5vWVhKbElHOW1JR1ZoWTJnZ2NHRjViV1Z1ZENCeWIzVjBaV1FnZEc4Z2RHaGxJRk5JUnlCMGNtVmhjM1Z5ZVN3Z2FXNGdZbUZ6YVhNZ2NHOXBiblJ6TGdvZ0lDQWdMeThnYzJWc1ppNTBjbVZoYzNWeWVWOXphR0Z5WlY5aWNITWdQU0JWU1c1ME5qUW9PREF3TUNrZ0lDTWdPREFsQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owY21WaGMzVnllVjl6YUdGeVpWOWljSE1pQ2lBZ0lDQndkWE5vYVc1MElEZ3dNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5bllYUmxkMkY1TDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMk5oYkd4eklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5allXeHNjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXlaWFpsYm5WbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5eVpYWmxiblZsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5bllYUmxkMkY1TDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM1J2WDNSeVpXRnpkWEo1SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjkwYjE5MGNtVmhjM1Z5ZVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDluWVhSbGQyRjVMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCamJHRnpjeUJZTkRBeVIyRjBaWGRoZVNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURnNE5qQTFOREF6SURCNE1UZG1PREF4WmpjZ01IZzBNakkyTlRBek1TQXdlRFpsWkRneE9EZzVJREI0WkdZMU5HVTRZV0VnTHk4Z2JXVjBhRzlrSUNKamIyNW1hV2QxY21Vb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkSFJzWlNoaGVHWmxjaXh6ZEhKcGJtY3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmY21WalpXbHdkQ2gxYVc1ME5qUXBLR0ZrWkhKbGMzTXNjM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbkpsZG1WdWRXVmZjM1Z0YldGeWVTZ3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWIzQjBYMmx1WDNSdlgyRnpjMlYwS0hWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZMjl1Wm1sbmRYSmxJSE5sZEhSc1pTQm5aWFJmY21WalpXbHdkQ0J5WlhabGJuVmxYM04xYlcxaGNua2diM0IwWDJsdVgzUnZYMkZ6YzJWMENpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFE2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTROREF5WDJkaGRHVjNZWGt1WTI5dWRISmhZM1F1V0RRd01rZGhkR1YzWVhrdVkyOXVabWxuZFhKbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl1Wm1sbmRYSmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxDQWliMjVzZVNCaFpHMXBiaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjI1c2VTQmhaRzFwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZloyRjBaWGRoZVM5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdZWE56WlhKMElITm9ZWEpsWDJKd2N5QThQU0JWU1c1ME5qUW9NVEJmTURBd0tTd2dJbk5vWVhKbElHTmhibTV2ZENCbGVHTmxaV1FnTVRBd0pTSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6YUdGeVpTQmpZVzV1YjNRZ1pYaGpaV1ZrSURFd01DVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMmRoZEdWM1lYa3ZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUhObGJHWXVkSEpsWVhOMWNua2dQU0IwY21WaGMzVnllUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkSEpsWVhOMWNua2lDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPalkyQ2lBZ0lDQXZMeUJ6Wld4bUxtRnpjMlYwWDJsa0lEMGdZWE56WlhSZmFXUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnpjMlYwWDJsa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZloyRjBaWGRoZVM5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdjMlZzWmk1MGNtVmhjM1Z5ZVY5emFHRnlaVjlpY0hNZ1BTQnphR0Z5WlY5aWNITUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUnlaV0Z6ZFhKNVgzTm9ZWEpsWDJKd2N5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDluWVhSbGQyRjVMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVEUXdNbDluWVhSbGQyRjVMbU52Ym5SeVlXTjBMbGcwTURKSFlYUmxkMkY1TG5ObGRIUnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRIUnNaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJkaGRHVjNZWGt2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhlR1psY2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMmRoZEdWM1lYa3ZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbmhtWlhKZllYTnpaWFF1YVdRZ1BUMGdjMlZzWmk1aGMzTmxkRjlwWkN3Z0luZHliMjVuSUhObGRIUnNaVzFsYm5RZ1lYTnpaWFFpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVhOelpYUmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlYTnpaWFJmYVdRZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIZHliMjVuSUhObGRIUnNaVzFsYm5RZ1lYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJkaGRHVjNZWGt2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GemMyVjBYM0psWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKM2NtOXVaeUJ5WldObGFYWmxjaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCM2NtOXVaeUJ5WldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVhOelpYUmZZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBMQ0FpWVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nUVhOelpYUkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJR0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNWhjM05sZEY5amJHOXpaVjkwYnlBOVBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQ0FpYlhWemRDQnViM1FnWTJ4dmMyVWdZWE56WlhRZ2FHOXNaR2x1WnlJS0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QkJjM05sZEVOc2IzTmxWRzhLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ0ZFhOMElHNXZkQ0JqYkc5elpTQmhjM05sZENCb2IyeGthVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5bllYUmxkMkY1TDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXdGxlVjkwYnlBOVBTQkhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQ0FpYlhWemRDQnViM1FnY21WclpYa2lDaUFnSUNCa2FXY2dNZ29nSUNBZ1ozUjRibk1nVW1WclpYbFVid29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzExYzNRZ2JtOTBJSEpsYTJWNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPamc0Q2lBZ0lDQXZMeUIwY21WaGMzVnllVjlqZFhRZ1BTQW9ZVzF2ZFc1MElDb2djMlZzWmk1MGNtVmhjM1Z5ZVY5emFHRnlaVjlpY0hNcElDOHZJRlZKYm5RMk5DZ3hNRjh3TURBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZEhKbFlYTjFjbmxmYzJoaGNtVmZZbkJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnlaV0Z6ZFhKNVgzTm9ZWEpsWDJKd2N5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3Q2lBZ0lDQXZDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJkaGRHVjNZWGt2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklISmxZMlZwY0hSZmFXUWdQU0J6Wld4bUxuUnZkR0ZzWDJOaGJHeHpJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZlkyRnNiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWTJGc2JITWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2NHRjVaWEk5WVhKak5DNUJaR1J5WlhOektIQmhlVzFsYm5RdWMyVnVaR1Z5S1N3S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDluWVhSbGQyRjVMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCaGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb1lXMXZkVzUwS1N3S0lDQWdJR1JwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUIwY21WaGMzVnllVjl6YUdGeVpUMWhjbU0wTGxWSmJuUTJOQ2gwY21WaGMzVnllVjlqZFhRcExBb2dJQ0FnWkdsbklETUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMmRoZEdWM1lYa3ZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUhScGJXVnpkR0Z0Y0QxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJ5YjNWdVpGOXpaWFIwYkdWa1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgyZGhkR1YzWVhrdlkyOXVkSEpoWTNRdWNIazZPVEV0T1RnS0lDQWdJQzh2SUhObGJHWXVjbVZqWldsd2RITmJjbVZqWldsd2RGOXBaRjBnUFNCUVlYbHRaVzUwVW1WalpXbHdkQ2dLSUNBZ0lDOHZJQ0FnSUNCd1lYbGxjajFoY21NMExrRmtaSEpsYzNNb2NHRjViV1Z1ZEM1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lISmxjMjkxY21ObFgybGtQWEpsYzI5MWNtTmxYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DaGhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJSFJ5WldGemRYSjVYM05vWVhKbFBXRnlZelF1VlVsdWREWTBLSFJ5WldGemRYSjVYMk4xZENrc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCeWIzVnVaRjl6WlhSMGJHVmtQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd05ESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZloyRjBaWGRoZVM5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdjMlZzWmk1eVpXTmxhWEIwYzF0eVpXTmxhWEIwWDJsa1hTQTlJRkJoZVcxbGJuUlNaV05sYVhCMEtBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlRGN5TmpNM01EYzBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJkaGRHVjNZWGt2WTI5dWRISmhZM1F1Y0hrNk9URXRPVGdLSUNBZ0lDOHZJSE5sYkdZdWNtVmpaV2x3ZEhOYmNtVmpaV2x3ZEY5cFpGMGdQU0JRWVhsdFpXNTBVbVZqWldsd2RDZ0tJQ0FnSUM4dklDQWdJQ0J3WVhsbGNqMWhjbU0wTGtGa1pISmxjM01vY0dGNWJXVnVkQzV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOTFjbU5sWDJsa1BYSmxjMjkxY21ObFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoY21NMExsVkpiblEyTkNoaGJXOTFiblFwTEFvZ0lDQWdMeThnSUNBZ0lIUnlaV0Z6ZFhKNVgzTm9ZWEpsUFdGeVl6UXVWVWx1ZERZMEtIUnlaV0Z6ZFhKNVgyTjFkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0J5YjNWdVpGOXpaWFIwYkdWa1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0F2THlBcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZZMkZzYkhNZ1BTQnlaV05sYVhCMFgybGtDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5allXeHNjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5bllYUmxkMkY1TDJOdmJuUnlZV04wTG5CNU9qRXdNUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl5WlhabGJuVmxJQ3M5SUdGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNKbGRtVnVkV1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmY21WMlpXNTFaU0JsZUdsemRITUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZmNtVjJaVzUxWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5MGIxOTBjbVZoYzNWeWVTQXJQU0IwY21WaGMzVnllVjlqZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOTBiMTkwY21WaGMzVnllU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjkwYjE5MGNtVmhjM1Z5ZVNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5MGIxOTBjbVZoYzNWeWVTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDluWVhSbGQyRjVMMk52Ym5SeVlXTjBMbkI1T2pFd05DMHhNRFVLSUNBZ0lDOHZJQ01nVkdobElGTklSeWR6SUdOMWRDQnNaV0YyWlhNZ2FXNGdkR2hsSUhOaGJXVWdkSEpoYm5OaFkzUnBiMjRnZEdoaGRDQnlaV052Y21SbFpDQnBkQzRLSUNBZ0lDOHZJR2xtSUhSeVpXRnpkWEo1WDJOMWRDQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSjZJSE5sZEhSc1pWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgyZGhkR1YzWVhrdlkyOXVkSEpoWTNRdWNIazZNVEEyTFRFeE1Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5YzJWc1ppNWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMXpaV3htTG5SeVpXRnpkWEo1TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDEwY21WaGMzVnllVjlqZFhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5bllYUmxkMkY1TDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDF6Wld4bUxtRnpjMlYwWDJsa0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GemMyVjBYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnpjMlYwWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZloyRjBaWGRoZVM5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTmxiR1l1ZEhKbFlYTjFjbmtzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkSEpsWVhOMWNua2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEhKbFlYTjFjbmtnWlhocGMzUnpDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRveE1EWUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNeUF2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZaMkYwWlhkaGVTOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDluWVhSbGQyRjVMMk52Ym5SeVlXTjBMbkI1T2pFd05pMHhNVEVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBYTmxiR1l1WVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YzJWc1ppNTBjbVZoYzNWeWVTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWRISmxZWE4xY25sZlkzVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbk5sZEhSc1pWOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZURRd01sOW5ZWFJsZDJGNUwyTnZiblJ5WVdOMExuQjVPalk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZURRd01sOW5ZWFJsZDJGNUxtTnZiblJ5WVdOMExsZzBNREpIWVhSbGQyRjVMbWRsZEY5eVpXTmxhWEIwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM0psWTJWcGNIUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVEUXdNbDluWVhSbGQyRjVMMk52Ym5SeVlXTjBMbkI1T2pFeE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlRFF3TWw5bllYUmxkMkY1TDJOdmJuUnlZV04wTG5CNU9qRXhOd29nSUNBZ0x5OGdZWE56WlhKMElISmxZMlZwY0hSZmFXUWdhVzRnYzJWc1ppNXlaV05sYVhCMGN5d2dJblZ1YTI1dmQyNGdjbVZqWldsd2RDSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzNNall6TnpBM05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1YTI1dmQyNGdjbVZqWldsd2RBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZaMkYwWlhkaGVTOWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxuSmxZMlZwY0hSelczSmxZMlZwY0hSZmFXUmRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJkaGRHVjNZWGt2WTI5dWRISmhZM1F1Y0hrNk1URTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVEUXdNbDluWVhSbGQyRjVMbU52Ym5SeVlXTjBMbGcwTURKSFlYUmxkMkY1TG5KbGRtVnVkV1ZmYzNWdGJXRnllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGRtVnVkV1ZmYzNWdGJXRnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJkaGRHVjNZWGt2WTI5dWRISmhZM1F1Y0hrNk1USTFDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDJOaGJHeHpLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5allXeHNjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlqWVd4c2N5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgyZGhkR1YzWVhrdlkyOXVkSEpoWTNRdWNIazZNVEkyQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzSmxkbVZ1ZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM0psZG1WdWRXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjbVYyWlc1MVpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgyZGhkR1YzWVhrdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzUnZYM1J5WldGemRYSjVLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5MGIxOTBjbVZoYzNWeWVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOTBiMTkwY21WaGMzVnllU0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMmRoZEdWM1lYa3ZZMjl1ZEhKaFkzUXVjSGs2TVRJekxURXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9DaUFnSUNBdkx5QWdJQ0FnS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gyTmhiR3h6S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXlaWFpsYm5WbEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjkwYjE5MGNtVmhjM1Z5ZVNrc0NpQWdJQ0F2THlBZ0lDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMmRoZEdWM1lYa3ZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZURRd01sOW5ZWFJsZDJGNUxtTnZiblJ5WVdOMExsZzBNREpIWVhSbGQyRjVMbTl3ZEY5cGJsOTBiMTloYzNObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEY5cGJsOTBiMTloYzNObGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMmRoZEdWM1lYa3ZZMjl1ZEhKaFkzUXVjSGs2TVRNeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgyZGhkR1YzWVhrdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxDQWliMjVzZVNCaFpHMXBiaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjI1c2VTQmhaRzFwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2cwTURKZloyRjBaWGRoZVM5amIyNTBjbUZqZEM1d2VUb3hNell0TVRReENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHdMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNnME1ESmZaMkYwWlhkaGVTOWpiMjUwY21GamRDNXdlVG94TXpnS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRveE16a0tJQ0FnSUM4dklHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTROREF5WDJkaGRHVjNZWGt2WTI5dWRISmhZM1F1Y0hrNk1UTTJDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYek1nTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NE5EQXlYMmRoZEdWM1lYa3ZZMjl1ZEhKaFkzUXVjSGs2TVRRd0NpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZzBNREpmWjJGMFpYZGhlUzlqYjI1MGNtRmpkQzV3ZVRveE16WXRNVFF4Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0TkRBeVgyZGhkR1YzWVhrdlkyOXVkSEpoWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUJDWUpDR0Z6YzJWMFgybGtDM1J2ZEdGc1gyTmhiR3h6RFhSdmRHRnNYM0psZG1WdWRXVVJkRzkwWVd4ZmRHOWZkSEpsWVhOMWNua0ZZV1J0YVc0SWRISmxZWE4xY25rU2RISmxZWE4xY25sZmMyaGhjbVZmWW5CekJCVWZmSFVFY21Od2RERVlRQUFjSndReUNXY25CVElKWnlnaVp5Y0dnY0ErWnlraVp5b2laeXNpWnpFYlFRQXlNUmtVUkRFWVJJSUZCSWhnVkFNRUYvZ0I5d1JDSmxBeEJHN1lHSWtFMzFUb3FqWWFBSTRGQUFrQVFnRUZBU0VCUEFBeEdSUXhHQlFRUXpZYUFVa1ZnU0FTUkRZYUFra1ZKQkpFRnpZYUEwa1ZKQkpFRnpFQUlpY0VaVVFTUkVtQmtFNE9SQ2NGVHdObktFOENaeWNHVEdjalF6RVdJd2xKT0JBbEVrUTJHZ0ZKSWxtQkFnaExBUlVTUkVzQk9CRWlLR1ZFRWtSTEFUZ1VNZ29TUkVzQk9CSkpSRXNDT0JVeUF4SkVTd0k0SURJREVrUWlKd1psUkVzQkM0R1FUZ3BKVGdRaUtXVkVJd2hQQkRnQVN3TVdTd01XTWdjV01nWVdUd1NBQWdCQ1VFOEVVRThEVUU4Q1VFeFFUd1JRU3dFV1NVNEZKd2hNVUVtOFNFeS9LVXhuSWlwbFJFOENDQ3BNWnlJclpVUkxBUWdyVEdkQkFCbXhJaWhsUkNJbkJXVkVTd095RXJJVXNoRWxzaEFpc2dHekp3ZE1VTEFqUXpZYUFVa1ZKQkpFRnhZbkNFeFFTYjFGQVVTK1NDY0hURkN3STBNaUtXVkVGaUlxWlVRV0lpdGxSQlpPQWxCTVVDY0hURkN3STBNMkdnRkpGU1FTUkJjeEFDSW5CR1ZFRWtTeE1nb2lzaEt5RkxJUkpiSVFJcklCc3lORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
