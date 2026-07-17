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

namespace Arc56.Generated.algorandfoundation.puya_ts.GtxnsAlgo_932fa0e5
{


    public class GtxnsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GtxnsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object3488A93F : AVMObjectType
            {
                public byte[] Sender { get; set; }

                public ulong Fee { get; set; }

                public ulong FirstValid { get; set; }

                public ulong FirstValidTime { get; set; }

                public ulong LastValid { get; set; }

                public byte[] Note { get; set; }

                public byte[] Lease { get; set; }

                public byte[] TypeBytes { get; set; }

                public ulong GroupIndex { get; set; }

                public byte[] TxnId { get; set; }

                public byte[] RekeyTo { get; set; }

                public byte[] Receiver { get; set; }

                public ulong Amount { get; set; }

                public byte[] CloseRemainderTo { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSender.From(Sender);
                    ret.AddRange(vSender.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFee.From(Fee);
                    ret.AddRange(vFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFirstValid.From(FirstValid);
                    ret.AddRange(vFirstValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValidTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFirstValidTime.From(FirstValidTime);
                    ret.AddRange(vFirstValidTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValid.From(LastValid);
                    ret.AddRange(vLastValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vNote.From(Note);
                    ret.AddRange(vNote.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLease = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vLease.From(Lease);
                    ret.AddRange(vLease.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTypeBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vTypeBytes.From(TypeBytes);
                    ret.AddRange(vTypeBytes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroupIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGroupIndex.From(GroupIndex);
                    ret.AddRange(vGroupIndex.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxnId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vTxnId.From(TxnId);
                    ret.AddRange(vTxnId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRekeyTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vRekeyTo.From(RekeyTo);
                    ret.AddRange(vRekeyTo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCloseRemainderTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vCloseRemainderTo.From(CloseRemainderTo);
                    ret.AddRange(vCloseRemainderTo.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object3488A93F Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object3488A93F();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFee = vFee.ToValue();
                    if (valueFee is ulong vFeeValue) { ret.Fee = vFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFirstValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFirstValid = vFirstValid.ToValue();
                    if (valueFirstValid is ulong vFirstValidValue) { ret.FirstValid = vFirstValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValidTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFirstValidTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFirstValidTime = vFirstValidTime.ToValue();
                    if (valueFirstValidTime is ulong vFirstValidTimeValue) { ret.FirstValidTime = vFirstValidTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValid = vLastValid.ToValue();
                    if (valueLastValid is ulong vLastValidValue) { ret.LastValid = vLastValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vNote.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNote = vNote.ToValue();
                    if (valueNote is byte[] vNoteValue) { ret.Note = vNoteValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLease = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vLease.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLease = vLease.ToValue();
                    if (valueLease is byte[] vLeaseValue) { ret.Lease = vLeaseValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTypeBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vTypeBytes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTypeBytes = vTypeBytes.ToValue();
                    if (valueTypeBytes is byte[] vTypeBytesValue) { ret.TypeBytes = vTypeBytesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroupIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGroupIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGroupIndex = vGroupIndex.ToValue();
                    if (valueGroupIndex is ulong vGroupIndexValue) { ret.GroupIndex = vGroupIndexValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxnId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vTxnId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTxnId = vTxnId.ToValue();
                    if (valueTxnId is byte[] vTxnIdValue) { ret.TxnId = vTxnIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRekeyTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vRekeyTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRekeyTo = vRekeyTo.ToValue();
                    if (valueRekeyTo is byte[] vRekeyToValue) { ret.RekeyTo = vRekeyToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCloseRemainderTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vCloseRemainderTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCloseRemainderTo = vCloseRemainderTo.ToValue();
                    if (valueCloseRemainderTo is byte[] vCloseRemainderToValue) { ret.CloseRemainderTo = vCloseRemainderToValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object3488A93F);
                }
                public bool Equals(Object3488A93F? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object3488A93F left, Object3488A93F right)
                {
                    return EqualityComparer<Object3488A93F>.Default.Equals(left, right);
                }
                public static bool operator !=(Object3488A93F left, Object3488A93F right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Test2(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 144, 133, 36 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test2_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 144, 133, 36 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Test3(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 146, 15, 55 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test3_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 146, 15, 55 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="other"> </param>
        public async Task Test4(ApplicationCallTransaction other, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { other });
            byte[] abiHandle = { 237, 180, 249, 115 };

            var result = await base.CallApp(new List<object> { abiHandle, other }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test4_Transactions(ApplicationCallTransaction other, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { other });
            byte[] abiHandle = { 237, 180, 249, 115 };

            return await base.MakeTransactionList(new List<object> { abiHandle, other }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task<Structs.Object3488A93F> ReflectAllPay(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 19, 222, 106, 84 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Object3488A93F.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReflectAllPay_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 19, 222, 106, 84 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        public async Task<ulong> Test5(Transaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 116, 89, 251, 31 };

            var result = await base.CallApp(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test5_Transactions(Transaction txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 116, 89, 251, 31 };

            return await base.MakeTransactionList(new List<object> { abiHandle, txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3R4bnNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDM0ODhBOTNGIjpbeyJuYW1lIjoic2VuZGVyIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpcnN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmlyc3RWYWxpZFRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFZhbGlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vdGUiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoibGVhc2UiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJ0eXBlQnl0ZXMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZ3JvdXBJbmRleCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0eG5JZCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InJla2V5VG8iLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbG9zZVJlbWFpbmRlclRvIiwidHlwZSI6ImJ5dGVbMzJdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im90aGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZmxlY3RBbGxQYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbMzJdLGJ5dGVbXSx1aW50NjQsYnl0ZVszMl0sYnl0ZVszMl0sYnl0ZVszMl0sdWludDY0LGJ5dGVbMzJdKSIsInN0cnVjdCI6Ik9iamVjdDM0ODhBOTNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMjBdLCJlcnJvck1lc3NhZ2UiOiJPQ0EgbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ2XSwiZXJyb3JNZXNzYWdlIjoiT3RoZXIgdHhuIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNCwyODBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBMklEQWdOQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlR1JtT1RJd1pqTTNJQ0pJWld4c2J5QjBaWE4wTkNJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSGRIaHVjMEZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVE1LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0UzT0RBd01HUmxJREI0WmpFNU1EZzFNalFnTHk4Z2JXVjBhRzlrSUNKMFpYTjBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wTWlncGRtOXBaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTXlncGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsWkdJMFpqazNNeUF3ZURFelpHVTJZVFUwSURCNE56UTFPV1ppTVdZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTkNoaGNIQnNLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxabXhsWTNSQmJHeFFZWGtvY0dGNUtTaGllWFJsV3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExHSjVkR1ZiTXpKZExHSjVkR1ZiWFN4MWFXNTBOalFzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzZFdsdWREWTBMR0o1ZEdWYk16SmRLU0lzSUcxbGRHaHZaQ0FpZEdWemREVW9kSGh1S1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUWdkR1Z6ZERJZ2RHVnpkRE1nZEdWemREUWdjbVZtYkdWamRFRnNiRkJoZVNCMFpYTjBOUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1IzUjRibk5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENobmRIaHVMbEJoZVcxbGJuUlVlRzRvTUNrdVlXMXZkVzUwSUQ0Z01Da0tJQ0FnSUdkMGVHNGdNQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ1ozUjRiaUF3SUVGdGIzVnVkQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2RHVnpkQ2dwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1F5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkREk2Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHa2diMllnZFhKaGJtZGxLRWRzYjJKaGJDNW5jbTkxY0ZOcGVtVXBLU0I3Q2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6SWdMeThnTUFvS2RHVnpkREpmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVNCdlppQjFjbUZ1WjJVb1IyeHZZbUZzTG1keWIzVndVMmw2WlNrcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUXlYMkZtZEdWeVgyWnZja0F5TWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklITjNhWFJqYUNBb2RIaHVMblI1Y0dVcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnWTJGelpTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVFYQndiR2xqWVhScGIyNURZV3hzT2dvZ0lDQWdhVzUwWTE4eElDOHZJRFlLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem95TlMweU53b2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWEJ3YkdsallYUnBiMjVEWVd4c09nb2dJQ0FnTHk4Z0lDQnNiMmNvZEhodUxtRndjRWxrTG1sa0tRb2dJQ0FnTHk4Z0lDQmljbVZoYXdvZ0lDQWdZbm9nZEdWemRESmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdiRzluS0hSNGJpNWhjSEJKWkM1cFpDa0tJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdiRzluQ2dwMFpYTjBNbDlpYkc5amEwQXlNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHa2diMllnZFhKaGJtZGxLRWRzYjJKaGJDNW5jbTkxY0ZOcGVtVXBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2RHVnpkREpmWm05eVgyaGxZV1JsY2tBeUNncDBaWE4wTWw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSVWNtRnVjMlpsY2pvS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6TWdMeThnTkFvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJNExUTXdDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRGUnlZVzV6Wm1WeU9nb2dJQ0FnTHk4Z0lDQnNiMmNvZEhodUxuaG1aWEpCYzNObGRDNXBaQ2tLSUNBZ0lDOHZJQ0FnWW5KbFlXc0tJQ0FnSUdKNklIUmxjM1F5WDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUd4dlp5aDBlRzR1ZUdabGNrRnpjMlYwTG1sa0tRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QllabVZ5UVhOelpYUUtJQ0FnSUdsMGIySUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR0p5WldGckNpQWdJQ0JpSUhSbGMzUXlYMkpzYjJOclFESXdDZ3AwWlhOME1sOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdZMkZ6WlNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhOelpYUkRiMjVtYVdjNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TXpFdE16TUtJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z6YzJWMFEyOXVabWxuT2dvZ0lDQWdMeThnSUNCc2IyY29kSGh1TG1OdmJtWnBaMEZ6YzJWMExtbGtLUW9nSUNBZ0x5OGdJQ0JpY21WaGF3b2dJQ0FnWW5vZ2RHVnpkREpmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUd4dlp5aDBlRzR1WTI5dVptbG5RWE56WlhRdWFXUXBDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRU52Ym1acFowRnpjMlYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCaWNtVmhhd29nSUNBZ1lpQjBaWE4wTWw5aWJHOWphMEF5TUFvS2RHVnpkREpmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCallYTmxJRlJ5WVc1ellXTjBhVzl1Vkhsd1pTNVFZWGx0Wlc1ME9nb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk16UXRNellLSUNBZ0lDOHZJR05oYzJVZ1ZISmhibk5oWTNScGIyNVVlWEJsTGxCaGVXMWxiblE2Q2lBZ0lDQXZMeUFnSUd4dlp5aDBlRzR1Y21WalpXbDJaWElwQ2lBZ0lDQXZMeUFnSUdKeVpXRnJDaUFnSUNCaWVpQjBaWE4wTWw5aFpuUmxjbDlwWmw5bGJITmxRREUxQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2JHOW5LSFI0Ymk1eVpXTmxhWFpsY2lrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklHSnlaV0ZyQ2lBZ0lDQmlJSFJsYzNReVgySnNiMk5yUURJd0NncDBaWE4wTWw5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa3RsZVZKbFoybHpkSEpoZEdsdmJqb0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvek55MHpPUW9nSUNBZ0x5OGdZMkZ6WlNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UzJWNVVtVm5hWE4wY21GMGFXOXVPZ29nSUNBZ0x5OGdJQ0JzYjJjb2RIaHVMblp2ZEdWTFpYa3BDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCMFpYTjBNbDloWm5SbGNsOXBabDlsYkhObFFERTRDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnYkc5bktIUjRiaTUyYjNSbFMyVjVLUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJXYjNSbFVFc0tJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJR0p5WldGckNpQWdJQ0JpSUhSbGMzUXlYMkpzYjJOclFESXdDZ3AwWlhOME1sOWhablJsY2w5cFpsOWxiSE5sUURFNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJR3h2WnloMGVHNHVabkpsWlhwbFFYTnpaWFF1YVdRcENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFWnlaV1Y2WlVGemMyVjBDaUFnSUNCcGRHOWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJpY21WaGF3b2dJQ0FnWWlCMFpYTjBNbDlpYkc5amEwQXlNQW9LZEdWemRESmZZV1owWlhKZlptOXlRREl5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIUmxjM1F5S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZEROYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3TENBblQwTkJJRzExYzNRZ1ltVWdUbTlQY0NjcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDBOQklHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWRIbHdaVVZ1ZFcwZ1BUMDlJRlJ5WVc1ellXTjBhVzl1Vkhsd1pTNUJjSEJzYVdOaGRHbHZia05oYkd3cENpQWdJQ0IwZUc0Z1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUEyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2JHOW5LQ2RJWld4c2J5QjBaWE4wTkNjcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKSVpXeHNieUIwWlhOME5DSUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJSFJsYzNRektDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemREUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOME5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUIwWlhOME5DaHZkR2hsY2pvZ1ozUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHeFVlRzRwSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z1lYQndiQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRndjR3dLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCaGMzTmxjblFvYjNSb1pYSXViMjVEYjIxd2JHVjBhVzl1SUQwOVBTQlBia052YlhCc1pYUmxRV04wYVc5dUxrNXZUM0FzSUNkUGRHaGxjaUIwZUc0Z2JYVnpkQ0JpWlNCT2IwOXdKeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQZEdobGNpQjBlRzRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZWE56WlhKMEtHOTBhR1Z5TG5SNWNHVWdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCY0hCc2FXTmhkR2x2YmtOaGJHd3BDaUFnSUNCcGJuUmpYekVnTHk4Z05nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZkR2hsY2k1c1lYTjBURzluSUQwOVBTQkNlWFJsY3lnblNHVnNiRzhnZEdWemREUW5LU2tLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVEdGemRFeHZad29nSUNBZ1lubDBaV05mTVNBdkx5QWlTR1ZzYkc4Z2RHVnpkRFFpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z1lYTnpaWEowS0c5MGFHVnlMbUZ3Y0VGeVozTW9NQ2tnUFQwOUlHMWxkR2h2WkZObGJHVmpkRzl5S0VkMGVHNXpRV3huYnk1d2NtOTBiM1I1Y0dVdWRHVnpkRE1wS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnYldWMGFHOWtJQ0owWlhOME15Z3BkbTlwWkNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QmhjM05sY25Rb2IzUm9aWEl1WVhCd1NXUWdQVDA5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKWkNrS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJsYzNRMEtHOTBhR1Z5T2lCbmRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JGUjRiaWtnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWNtVm1iR1ZqZEVGc2JGQmhlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFpteGxZM1JCYkd4UVlYazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY21WbWJHVmpkRUZzYkZCaGVTaHdZWGs2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWtnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnYzJWdVpHVnlPaUJ3WVhrdWMyVnVaR1Z5TG1KNWRHVnpMQW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJtWldVNklIQmhlUzVtWldVc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdSbVZsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z1ptbHljM1JXWVd4cFpEb2djR0Y1TG1acGNuTjBWbUZzYVdRc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWjNSNGJuTWdSbWx5YzNSV1lXeHBaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdacGNuTjBWbUZzYVdSVWFXMWxPaUJ3WVhrdVptbHljM1JXWVd4cFpGUnBiV1VzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaM1I0Ym5NZ1JtbHljM1JXWVd4cFpGUnBiV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCc1lYTjBWbUZzYVdRNklIQmhlUzVzWVhOMFZtRnNhV1FzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaM1I0Ym5NZ1RHRnpkRlpoYkdsa0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdibTkwWlRvZ2NHRjVMbTV2ZEdVc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWjNSNGJuTWdUbTkwWlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklHeGxZWE5sT2lCd1lYa3ViR1ZoYzJVc0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWjNSNGJuTWdUR1ZoYzJVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QjBlWEJsUW5sMFpYTTZJSEJoZVM1MGVYQmxRbmwwWlhNc0NpQWdJQ0JrYVdjZ053b2dJQ0FnWjNSNGJuTWdWSGx3WlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklHZHliM1Z3U1c1a1pYZzZJSEJoZVM1bmNtOTFjRWx1WkdWNExBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdkMGVHNXpJRWR5YjNWd1NXNWtaWGdLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCMGVHNUpaRG9nY0dGNUxuUjRia2xrTEFvZ0lDQWdaR2xuSURrS0lDQWdJR2QwZUc1eklGUjRTVVFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCd1lYa3VjbVZyWlhsVWJ5NWllWFJsY3l3S0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWjNSNGJuTWdVbVZyWlhsVWJ3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJ3WVhrdWNtVmpaV2wyWlhJdVlubDBaWE1zQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZVzF2ZFc1ME9pQndZWGt1WVcxdmRXNTBMQW9nSUNBZ1pHbG5JREV5Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCd1lYa3VZMnh2YzJWU1pXMWhhVzVrWlhKVWJ5NWllWFJsY3l3S0lDQWdJSFZ1WTI5MlpYSWdNVE1LSUNBZ0lHZDBlRzV6SUVOc2IzTmxVbVZ0WVdsdVpHVnlWRzhLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZeUxUYzNDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQnpaVzVrWlhJNklIQmhlUzV6Wlc1a1pYSXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lHWmxaVG9nY0dGNUxtWmxaU3dLSUNBZ0lDOHZJQ0FnWm1seWMzUldZV3hwWkRvZ2NHRjVMbVpwY25OMFZtRnNhV1FzQ2lBZ0lDQXZMeUFnSUdacGNuTjBWbUZzYVdSVWFXMWxPaUJ3WVhrdVptbHljM1JXWVd4cFpGUnBiV1VzQ2lBZ0lDQXZMeUFnSUd4aGMzUldZV3hwWkRvZ2NHRjVMbXhoYzNSV1lXeHBaQ3dLSUNBZ0lDOHZJQ0FnYm05MFpUb2djR0Y1TG01dmRHVXNDaUFnSUNBdkx5QWdJR3hsWVhObE9pQndZWGt1YkdWaGMyVXNDaUFnSUNBdkx5QWdJSFI1Y0dWQ2VYUmxjem9nY0dGNUxuUjVjR1ZDZVhSbGN5d0tJQ0FnSUM4dklDQWdaM0p2ZFhCSmJtUmxlRG9nY0dGNUxtZHliM1Z3U1c1a1pYZ3NDaUFnSUNBdkx5QWdJSFI0Ymtsa09pQndZWGt1ZEhodVNXUXNDaUFnSUNBdkx5QWdJSEpsYTJWNVZHODZJSEJoZVM1eVpXdGxlVlJ2TG1KNWRHVnpMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nY0dGNUxuSmxZMlZwZG1WeUxtSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhCaGVTNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklIQmhlUzVqYkc5elpWSmxiV0ZwYm1SbGNsUnZMbUo1ZEdWekxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnZFc1amIzWmxjaUF4TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXhNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01URUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01HWTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01qUTBDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBNUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY21WbWJHVmpkRUZzYkZCaGVTaHdZWGs2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWtnZXdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkRFZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCMFpYTjBOU2gwZUc0NklHZDBlRzR1VkhKaGJuTmhZM1JwYjI0cE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z2FXWWdLSFI0Ymk1MGVYQmxJRDA5UFNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1VUdGNWJXVnVkQ2tnZXdvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQjBaWE4wTlY5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPRElLSUNBZ0lDOHZJSEpsZEhWeWJpQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0tkR1Z6ZERWZllXWjBaWEpmYVc1c2FXNWxaRjkwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1ExUURjNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdkR1Z6ZERVb2RIaHVPaUJuZEhodUxsUnlZVzV6WVdOMGFXOXVLVG9nZFdsdWREWTBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25SbGMzUTFYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklIMGdaV3h6WlNCcFppQW9kSGh1TG5SNWNHVWdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRGUnlZVzV6Wm1WeUtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBMENpQWdJQ0E5UFFvZ0lDQWdZbm9nZEdWemREVmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdjbVYwZFhKdUlEQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdkR1Z6ZERVb2RIaHVPaUJuZEhodUxsUnlZVzV6WVdOMGFXOXVLVG9nZFdsdWREWTBJSHNLSUNBZ0lHSWdkR1Z6ZERWZllXWjBaWEpmYVc1c2FXNWxaRjkwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1ExUURjS0NuUmxjM1ExWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCeVpYUjFjbTRnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCMFpYTjBOU2gwZUc0NklHZDBlRzR1VkhKaGJuTmhZM1JwYjI0cE9pQjFhVzUwTmpRZ2V3b2dJQ0FnWWlCMFpYTjBOVjloWm5SbGNsOXBibXhwYm1Wa1gzUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemREVkFOd289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRWUFCQ1lEQk4rU0R6Y0xTR1ZzYkc4Z2RHVnpkRFFFRlI5OGRURWJRUUEzTVJrVVJERVlSSUlDQktlQUFONEU4WkNGSkNpQ0F3VHR0UGx6QkJQZWFsUUVkRm43SHpZYUFJNEdBQWtBRlFCL0FJd0F0UUZYQURFWkZERVlGQkJETXdBUUloSkVNd0FJUkNKRGdBQXlCQ1JKU3dJTVFRQmNTVGdRU1VVRUl4SkJBQTFKT0JnV3NFa2lDRVVCUXYvaFN3SWxFa0VBQ0VrNEVSYXdRdi9wU3dLQkF4SkJBQWhKT0NFV3NFTC8yVXNDSWhKQkFBZEpPQWV3UXYvTFN3S0JBaEpCQUFkSk9BcXdRdis4U1RndEZyQkMvN1FpUXpFWkZFUXhFQ01TUkNtd0lrTXhGaUlKU1RnUVNTTVNSRXNCT0JrVVJDTVNSRWs0UGlrU1JFazVHZ0FvRWtRNEdESUlFa1FpUXpFV0lnbEpPQkFpRWtSSk9BQkxBVGdCU3dJNEFrc0RPQU5MQkRnRVN3VTRCVXNHT0FaTEJ6Z1BTd2c0RmtzSk9CZExDamdnU3dzNEIwc01PQWhQRFRnSlR3d1dUdzFNVUU4TUZsQlBDeFpRVHdvV1VFc0pGUlpYQmdKUENsQk1nQUlBOUZCTEFSV0I5QUVJVEU4S1VFc0pGUlpYQmdKUENsQlBBaFpYQmdKUEFreFFUd2dXVUU4SFVFOEdVRThGVUU4RUZsQlBBMUJQQWxCTVVDcE1VTEFpUXpFV0lnazRFRWtpRWtFQUNDSVdLa3hRc0NKRFNTVVNRUUFFSkVMLzd5UkMvK3M9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
