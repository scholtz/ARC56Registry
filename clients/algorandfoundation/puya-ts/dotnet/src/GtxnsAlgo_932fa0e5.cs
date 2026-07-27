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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3R4bnNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDM0ODhBOTNGIjpbeyJuYW1lIjoic2VuZGVyIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpcnN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmlyc3RWYWxpZFRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFZhbGlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vdGUiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoibGVhc2UiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJ0eXBlQnl0ZXMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZ3JvdXBJbmRleCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0eG5JZCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InJla2V5VG8iLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbG9zZVJlbWFpbmRlclRvIiwidHlwZSI6ImJ5dGVbMzJdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im90aGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZmxlY3RBbGxQYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbMzJdLGJ5dGVbXSx1aW50NjQsYnl0ZVszMl0sYnl0ZVszMl0sYnl0ZVszMl0sdWludDY0LGJ5dGVbMzJdKSIsInN0cnVjdCI6Ik9iamVjdDM0ODhBOTNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMjJdLCJlcnJvck1lc3NhZ2UiOiJPQ0EgbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ4XSwiZXJyb3JNZXNzYWdlIjoiT3RoZXIgdHhuIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNCwyODJdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBMklEQWdOQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlR1JtT1RJd1pqTTNJQ0pJWld4c2J5QjBaWE4wTkNJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSGRIaHVjMEZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVE1LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0UzT0RBd01HUmxJREI0WmpFNU1EZzFNalFnTHk4Z2JXVjBhRzlrSUNKMFpYTjBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wTWlncGRtOXBaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTXlncGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsWkdJMFpqazNNeUF3ZURFelpHVTJZVFUwSURCNE56UTFPV1ppTVdZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTkNoaGNIQnNLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxabXhsWTNSQmJHeFFZWGtvY0dGNUtTaGllWFJsV3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExHSjVkR1ZiTXpKZExHSjVkR1ZiWFN4MWFXNTBOalFzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzZFdsdWREWTBMR0o1ZEdWYk16SmRLU0lzSUcxbGRHaHZaQ0FpZEdWemREVW9kSGh1S1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUWdkR1Z6ZERJZ2RHVnpkRE1nZEdWemREUWdjbVZtYkdWamRFRnNiRkJoZVNCMFpYTjBOUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1IzUjRibk5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENobmRIaHVMbEJoZVcxbGJuUlVlRzRvTUNrdVlXMXZkVzUwSUQ0Z01Da0tJQ0FnSUdkMGVHNGdNQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ1ozUjRiaUF3SUVGdGIzVnVkQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2RHVnpkQ2dwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1F5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQnBJRzltSUhWeVlXNW5aU2hIYkc5aVlXd3VaM0p2ZFhCVGFYcGxLU2tnZXdvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0NuUmxjM1F5WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdrZ2IyWWdkWEpoYm1kbEtFZHNiMkpoYkM1bmNtOTFjRk5wZW1VcEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBNbDloWm5SbGNsOW1iM0pBTWpJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnpkMmwwWTJnZ0tIUjRiaTUwZVhCbEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCallYTmxJRlJ5WVc1ellXTjBhVzl1Vkhsd1pTNUJjSEJzYVdOaGRHbHZia05oYkd3NkNpQWdJQ0JwYm5Salh6RWdMeThnTmdvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJMUxUSTNDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCY0hCc2FXTmhkR2x2YmtOaGJHdzZDaUFnSUNBdkx5QWdJR3h2WnloMGVHNHVZWEJ3U1dRdWFXUXBDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCMFpYTjBNbDloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUd4dlp5aDBlRzR1WVhCd1NXUXVhV1FwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsMGIySUtJQ0FnSUd4dlp3b0tkR1Z6ZERKZllteHZZMnRBTWpBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwSUc5bUlIVnlZVzVuWlNoSGJHOWlZV3d1WjNKdmRYQlRhWHBsS1NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdkR1Z6ZERKZlptOXlYMmhsWVdSbGNrQXlDZ3AwWlhOME1sOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdZMkZ6WlNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhOelpYUlVjbUZ1YzJabGNqb0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qSTRMVE13Q2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmMzTmxkRlJ5WVc1elptVnlPZ29nSUNBZ0x5OGdJQ0JzYjJjb2RIaHVMbmhtWlhKQmMzTmxkQzVwWkNrS0lDQWdJQzh2SUNBZ1luSmxZV3NLSUNBZ0lHSjZJSFJsYzNReVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdiRzluS0hSNGJpNTRabVZ5UVhOelpYUXVhV1FwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZobVpYSkJjM05sZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z1luSmxZV3NLSUNBZ0lHSWdkR1Z6ZERKZllteHZZMnRBTWpBS0NuUmxjM1F5WDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCallYTmxJRlJ5WVc1ellXTjBhVzl1Vkhsd1pTNUJjM05sZEVOdmJtWnBaem9LSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3pNUzB6TXdvZ0lDQWdMeThnWTJGelpTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVFYTnpaWFJEYjI1bWFXYzZDaUFnSUNBdkx5QWdJR3h2WnloMGVHNHVZMjl1Wm1sblFYTnpaWFF1YVdRcENpQWdJQ0F2THlBZ0lHSnlaV0ZyQ2lBZ0lDQmllaUIwWlhOME1sOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJzYjJjb2RIaHVMbU52Ym1acFowRnpjMlYwTG1sa0tRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QkRiMjVtYVdkQmMzTmxkQW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWW5KbFlXc0tJQ0FnSUdJZ2RHVnpkREpmWW14dlkydEFNakFLQ25SbGMzUXlYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWTJGelpTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVVHRjViV1Z1ZERvS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNMExUTTJDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVRWVhsdFpXNTBPZ29nSUNBZ0x5OGdJQ0JzYjJjb2RIaHVMbkpsWTJWcGRtVnlLUW9nSUNBZ0x5OGdJQ0JpY21WaGF3b2dJQ0FnWW5vZ2RHVnpkREpmWVdaMFpYSmZhV1pmWld4elpVQXhOUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2JHOW5LSFI0Ymk1eVpXTmxhWFpsY2lrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklHSnlaV0ZyQ2lBZ0lDQmlJSFJsYzNReVgySnNiMk5yUURJd0NncDBaWE4wTWw5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa3RsZVZKbFoybHpkSEpoZEdsdmJqb0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNM0xUTTVDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVMWlhsU1pXZHBjM1J5WVhScGIyNDZDaUFnSUNBdkx5QWdJR3h2WnloMGVHNHVkbTkwWlV0bGVTa0tJQ0FnSUM4dklDQWdZbkpsWVdzS0lDQWdJR0o2SUhSbGMzUXlYMkZtZEdWeVgybG1YMlZzYzJWQU1UZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJzYjJjb2RIaHVMblp2ZEdWTFpYa3BDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlp2ZEdWUVN3b2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdZbkpsWVdzS0lDQWdJR0lnZEdWemRESmZZbXh2WTJ0QU1qQUtDblJsYzNReVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdiRzluS0hSNGJpNW1jbVZsZW1WQmMzTmxkQzVwWkNrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1JuSmxaWHBsUVhOelpYUUtJQ0FnSUdsMGIySUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJR0p5WldGckNpQWdJQ0JpSUhSbGMzUXlYMkpzYjJOclFESXdDZ3AwWlhOME1sOWhablJsY2w5bWIzSkFNakk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2RHVnpkRElvS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1F6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHViMjVEYjIxd2JHVjBhVzl1SUQwOVBTQlBia052YlhCc1pYUmxRV04wYVc5dUxrNXZUM0FzSUNkUFEwRWdiWFZ6ZENCaVpTQk9iMDl3SnlrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQUTBFZ2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1MGVYQmxSVzUxYlNBOVBUMGdWSEpoYm5OaFkzUnBiMjVVZVhCbExrRndjR3hwWTJGMGFXOXVRMkZzYkNrS0lDQWdJSFI0YmlCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJRFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCc2IyY29KMGhsYkd4dklIUmxjM1EwSnlrS0lDQWdJR0o1ZEdWalh6RWdMeThnSWtobGJHeHZJSFJsYzNRMElnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdkR1Z6ZERNb0tTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME5GdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNRME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJsYzNRMEtHOTBhR1Z5T2lCbmRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JGUjRiaWtnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlCaGNIQnNDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYQndiQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUdGemMyVnlkQ2h2ZEdobGNpNXZia052YlhCc1pYUnBiMjRnUFQwOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVRtOVBjQ3dnSjA5MGFHVnlJSFI0YmlCdGRYTjBJR0psSUU1dlQzQW5LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHZDBlRzV6SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTkwYUdWeUlIUjRiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QmhjM05sY25Rb2IzUm9aWEl1ZEhsd1pTQTlQVDBnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDa0tJQ0FnSUdsdWRHTmZNU0F2THlBMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdZWE56WlhKMEtHOTBhR1Z5TG14aGMzUk1iMmNnUFQwOUlFSjVkR1Z6S0NkSVpXeHNieUIwWlhOME5DY3BLUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJNWVhOMFRHOW5DaUFnSUNCaWVYUmxZMTh4SUM4dklDSklaV3hzYnlCMFpYTjBOQ0lLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaGMzTmxjblFvYjNSb1pYSXVZWEJ3UVhKbmN5Z3dLU0E5UFQwZ2JXVjBhRzlrVTJWc1pXTjBiM0lvUjNSNGJuTkJiR2R2TG5CeWIzUnZkSGx3WlM1MFpYTjBNeWtwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUJ0WlhSb2IyUWdJblJsYzNRektDbDJiMmxrSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENodmRHaGxjaTVoY0hCSlpDQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrS1FvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdkR1Z6ZERRb2IzUm9aWEk2SUdkMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c1ZIaHVLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1eVpXWnNaV04wUVd4c1VHRjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbWJHVmpkRUZzYkZCaGVUb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJ5Wldac1pXTjBRV3hzVUdGNUtIQmhlVG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLU0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJ6Wlc1a1pYSTZJSEJoZVM1elpXNWtaWEl1WW5sMFpYTXNDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJR1psWlRvZ2NHRjVMbVpsWlN3S0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QkdaV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCbWFYSnpkRlpoYkdsa09pQndZWGt1Wm1seWMzUldZV3hwWkN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JuZEhodWN5QkdhWEp6ZEZaaGJHbGtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWm1seWMzUldZV3hwWkZScGJXVTZJSEJoZVM1bWFYSnpkRlpoYkdsa1ZHbHRaU3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5kSGh1Y3lCR2FYSnpkRlpoYkdsa1ZHbHRaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUd4aGMzUldZV3hwWkRvZ2NHRjVMbXhoYzNSV1lXeHBaQ3dLSUNBZ0lHUnBaeUEwQ2lBZ0lDQm5kSGh1Y3lCTVlYTjBWbUZzYVdRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QnViM1JsT2lCd1lYa3VibTkwWlN3S0lDQWdJR1JwWnlBMUNpQWdJQ0JuZEhodWN5Qk9iM1JsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z2JHVmhjMlU2SUhCaGVTNXNaV0Z6WlN3S0lDQWdJR1JwWnlBMkNpQWdJQ0JuZEhodWN5Qk1aV0Z6WlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklIUjVjR1ZDZVhSbGN6b2djR0Y1TG5SNWNHVkNlWFJsY3l3S0lDQWdJR1JwWnlBM0NpQWdJQ0JuZEhodWN5QlVlWEJsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z1ozSnZkWEJKYm1SbGVEb2djR0Y1TG1keWIzVndTVzVrWlhnc0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnWjNSNGJuTWdSM0p2ZFhCSmJtUmxlQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUhSNGJrbGtPaUJ3WVhrdWRIaHVTV1FzQ2lBZ0lDQmthV2NnT1FvZ0lDQWdaM1I0Ym5NZ1ZIaEpSQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUhKbGEyVjVWRzg2SUhCaGVTNXlaV3RsZVZSdkxtSjVkR1Z6TEFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JuZEhodWN5QlNaV3RsZVZSdkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdjbVZqWldsMlpYSTZJSEJoZVM1eVpXTmxhWFpsY2k1aWVYUmxjeXdLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmhiVzkxYm5RNklIQmhlUzVoYlc5MWJuUXNDaUFnSUNCa2FXY2dNVElLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUhCaGVTNWpiRzl6WlZKbGJXRnBibVJsY2xSdkxtSjVkR1Z6TEFvZ0lDQWdkVzVqYjNabGNpQXhNd29nSUNBZ1ozUjRibk1nUTJ4dmMyVlNaVzFoYVc1a1pYSlVid29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TmpJdE56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ2NHRjVMbk5sYm1SbGNpNWllWFJsY3l3S0lDQWdJQzh2SUNBZ1ptVmxPaUJ3WVhrdVptVmxMQW9nSUNBZ0x5OGdJQ0JtYVhKemRGWmhiR2xrT2lCd1lYa3VabWx5YzNSV1lXeHBaQ3dLSUNBZ0lDOHZJQ0FnWm1seWMzUldZV3hwWkZScGJXVTZJSEJoZVM1bWFYSnpkRlpoYkdsa1ZHbHRaU3dLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrT2lCd1lYa3ViR0Z6ZEZaaGJHbGtMQW9nSUNBZ0x5OGdJQ0J1YjNSbE9pQndZWGt1Ym05MFpTd0tJQ0FnSUM4dklDQWdiR1ZoYzJVNklIQmhlUzVzWldGelpTd0tJQ0FnSUM4dklDQWdkSGx3WlVKNWRHVnpPaUJ3WVhrdWRIbHdaVUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQm5jbTkxY0VsdVpHVjRPaUJ3WVhrdVozSnZkWEJKYm1SbGVDd0tJQ0FnSUM4dklDQWdkSGh1U1dRNklIQmhlUzUwZUc1SlpDd0tJQ0FnSUM4dklDQWdjbVZyWlhsVWJ6b2djR0Y1TG5KbGEyVjVWRzh1WW5sMFpYTXNDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUJ3WVhrdWNtVmpaV2wyWlhJdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nY0dGNUxtRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ2NHRjVMbU5zYjNObFVtVnRZV2x1WkdWeVZHOHVZbmwwWlhNc0NpQWdJQ0F2THlCOUNpQWdJQ0IxYm1OdmRtVnlJREV5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlERXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01USUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTVDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd1pqUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU5EUUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURrS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJ5Wldac1pXTjBRV3hzVUdGNUtIQmhlVG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLU0I3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBOVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSbGMzUTFLSFI0YmpvZ1ozUjRiaTVVY21GdWMyRmpkR2x2YmlrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCcFppQW9kSGh1TG5SNWNHVWdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVRWVhsdFpXNTBLU0I3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklIUmxjM1ExWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QnlaWFIxY200Z01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NuUmxjM1ExWDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBOVUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklIUmxjM1ExS0hSNGJqb2daM1I0Ymk1VWNtRnVjMkZqZEdsdmJpazZJSFZwYm5RMk5DQjdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AwWlhOME5WOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCOUlHVnNjMlVnYVdZZ0tIUjRiaTUwZVhCbElEMDlQU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSVWNtRnVjMlpsY2lrZ2V3b2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQmllaUIwWlhOME5WOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QnlaWFIxY200Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QjBaWE4wTlNoMGVHNDZJR2QwZUc0dVZISmhibk5oWTNScGIyNHBPaUIxYVc1ME5qUWdld29nSUNBZ1lpQjBaWE4wTlY5aFpuUmxjbDlwYm14cGJtVmtYM1JsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkRFZBTndvS2RHVnpkRFZmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RjS0lDQWdJQzh2SUhKbGRIVnliaUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSbGMzUTFLSFI0YmpvZ1ozUjRiaTVVY21GdWMyRmpkR2x2YmlrNklIVnBiblEyTkNCN0NpQWdJQ0JpSUhSbGMzUTFYMkZtZEdWeVgybHViR2x1WldSZmRHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME5VQTNDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRWUFCQ1lEQk4rU0R6Y0xTR1ZzYkc4Z2RHVnpkRFFFRlI5OGRURWJRUUEzTVJrVVJERVlSSUlDQktlQUFONEU4WkNGSkNpQ0F3VHR0UGx6QkJQZWFsUUVkRm43SHpZYUFJNEdBQWtBRlFDQkFJNEF0d0ZaQURFWkZERVlGQkJETXdBUUloSkVNd0FJUkNKRE1nUWtTVXNDREVFQVlFazRFRWxPQWlNU1FRQU1SUUZKT0JnV3NDSUlRdi9pU3dFbEVrRUFDa1VCU1RnUkZyQkMvK3BMQVlFREVrRUFDa1VCU1RnaEZyQkMvOWhMQVNJU1FRQUpSUUZKT0Fld1F2L0lUSUVDRWtFQUIwazRDckJDLzdwSk9DMFdzRUwvc2lKRE1Sa1VSREVRSXhKRUtiQWlRekVXSWdsSk9CQkpJeEpFU3dFNEdSUkVJeEpFU1RnK0tSSkVTVGthQUNnU1JEZ1lNZ2dTUkNKRE1SWWlDVWs0RUNJU1JFazRBRXNCT0FGTEFqZ0NTd000QTBzRU9BUkxCVGdGU3dZNEJrc0hPQTlMQ0RnV1N3azRGMHNLT0NCTEN6Z0hTd3c0Q0U4Tk9BbFBEQlpQRFV4UVR3d1dVRThMRmxCUENoWlFTd2tWRmxjR0FrOEtVRXlBQWdEMFVFc0JGWUgwQVFoTVR3cFFTd2tWRmxjR0FrOEtVRThDRmxjR0FrOENURkJQQ0JaUVR3ZFFUd1pRVHdWUVR3UVdVRThEVUU4Q1VFeFFLa3hRc0NKRE1SWWlDVGdRU1NJU1FRQUpTQ0lXS2t4UXNDSkRKUkpCQUFRa1F2L3dKRUwvN0E9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
