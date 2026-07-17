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

namespace Arc56.Generated.algorandfoundation.puya_ts.GtxnsAlgo_6907edc9
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3R4bnNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDM0ODhBOTNGIjpbeyJuYW1lIjoic2VuZGVyIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpcnN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmlyc3RWYWxpZFRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFZhbGlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vdGUiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoibGVhc2UiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJ0eXBlQnl0ZXMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZ3JvdXBJbmRleCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0eG5JZCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InJla2V5VG8iLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbG9zZVJlbWFpbmRlclRvIiwidHlwZSI6ImJ5dGVbMzJdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im90aGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZmxlY3RBbGxQYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbMzJdLGJ5dGVbXSx1aW50NjQsYnl0ZVszMl0sYnl0ZVszMl0sYnl0ZVszMl0sdWludDY0LGJ5dGVbMzJdKSIsInN0cnVjdCI6Ik9iamVjdDM0ODhBOTNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NTNdLCJlcnJvck1lc3NhZ2UiOiJPQ0EgbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc0XSwiZXJyb3JNZXNzYWdlIjoiT3RoZXIgdHhuIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4N10sImVycm9yTWVzc2FnZSI6IlN0ZXAgY2Fubm90IGJlIHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFwcGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzEsMjY4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRFlnTkFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZUNBd2VHUm1PVEl3WmpNM0lEQjRNVFV4Wmpkak56VWdJa2hsYkd4dklIUmxjM1EwSWdvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURBS0NtMWhhVzVmWW14dlkydEFNRG9LSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEF4Q2dwdFlXbHVYMkpzYjJOclFERTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFZDBlRzV6UVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXpDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1nb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkhkSGh1YzBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TVFvZ0lDQWdZaUJ0WVdsdVgyTmhiR3hmVG05UGNFQXpDZ3B0WVdsdVgyTmhiR3hmVG05UGNFQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkhkSGh1YzBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhOemd3TURCa1pTQXZMeUJ0WlhSb2IyUWdJblJsYzNRb0tYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtTVRrd09EVXlOQ0F2THlCdFpYUm9iMlFnSW5SbGMzUXlLQ2wyYjJsa0lnb2dJQ0FnWW5sMFpXTmZNU0F2THlCdFpYUm9iMlFnSW5SbGMzUXpLQ2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpXUmlOR1k1TnpNZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTkNoaGNIQnNLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE0yUmxObUUxTkNBdkx5QnRaWFJvYjJRZ0luSmxabXhsWTNSQmJHeFFZWGtvY0dGNUtTaGllWFJsV3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExHSjVkR1ZiTXpKZExHSjVkR1ZiWFN4MWFXNTBOalFzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzZFdsdWREWTBMR0o1ZEdWYk16SmRLU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGMwTlRsbVlqRm1JQzh2SUcxbGRHaHZaQ0FpZEdWemREVW9kSGh1S1hWcGJuUTJOQ0lLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MFpYTjBYM0p2ZFhSbFFEUWdiV0ZwYmw5MFpYTjBNbDl5YjNWMFpVQTFJRzFoYVc1ZmRHVnpkRE5mY205MWRHVkFOaUJ0WVdsdVgzUmxjM1EwWDNKdmRYUmxRRGNnYldGcGJsOXlaV1pzWldOMFFXeHNVR0Y1WDNKdmRYUmxRRGdnYldGcGJsOTBaWE4wTlY5eWIzVjBaVUE1Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Bb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFd09nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRWQwZUc1elFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHVnljZ29LYldGcGJsOTBaWE4wTlY5eWIzVjBaVUE1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklIUmxjM1ExS0hSNGJqb2daM1I0Ymk1VWNtRnVjMkZqZEdsdmJpazZJSFZwYm5RMk5DQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUTFDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TUFvS2JXRnBibDl5Wldac1pXTjBRV3hzVUdGNVgzSnZkWFJsUURnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdjbVZtYkdWamRFRnNiRkJoZVNod1lYazZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpa2dld29nSUNBZ1kyRnNiSE4xWWlCeVpXWnNaV04wUVd4c1VHRjVDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TUFvS2JXRnBibDkwWlhOME5GOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJsYzNRMEtHOTBhR1Z5T2lCbmRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JGUjRiaWtnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wTkFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UQUtDbTFoYVc1ZmRHVnpkRE5mY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCMFpYTjBNeWdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZERNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXdDZ3B0WVdsdVgzUmxjM1F5WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2RHVnpkRElvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNReUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNQW9LYldGcGJsOTBaWE4wWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2RHVnpkQ2dwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UQUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVEU2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRWQwZUc1elFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZMkZzYkhOMVlpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBPZ29nSUNBZ1lpQjBaWE4wWDJKc2IyTnJRREFLQ25SbGMzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUIwWlhOMEtDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1F5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkREk2Q2lBZ0lDQmlJSFJsYzNReVgySnNiMk5yUURBS0NuUmxjM1F5WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2RHVnpkRElvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkRElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRETTZDaUFnSUNCaUlIUmxjM1F6WDJKc2IyTnJRREFLQ25SbGMzUXpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnZEdWemRETW9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemRETUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZERRNkNpQWdJQ0JpSUhSbGMzUTBYMkpzYjJOclFEQUtDblJsYzNRMFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdkR1Z6ZERRb2IzUm9aWEk2SUdkMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c1ZIaHVLU0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNaUF2THlCaGNIQnNDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYQndiQW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NXlaV1pzWldOMFFXeHNVR0Y1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm1iR1ZqZEVGc2JGQmhlVG9LSUNBZ0lHSWdjbVZtYkdWamRFRnNiRkJoZVY5aWJHOWphMEF3Q2dweVpXWnNaV04wUVd4c1VHRjVYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY21WbWJHVmpkRUZzYkZCaGVTaHdZWGs2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWtnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVjbVZtYkdWamRFRnNiRkJoZVFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME5WdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNRMU9nb2dJQ0FnWWlCMFpYTjBOVjlpYkc5amEwQXdDZ3AwWlhOME5WOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJSFJsYzNRMUtIUjRiam9nWjNSNGJpNVVjbUZ1YzJGamRHbHZiaWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOMEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnWVhOelpYSjBLR2QwZUc0dVVHRjViV1Z1ZEZSNGJpZ3dLUzVoYlc5MWJuUWdQaUF3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReUtDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCMFpYTjBNaWdwSUhzS0lDQWdJSEJ5YjNSdklEQWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXlYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkREpmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHa2diMllnZFhKaGJtZGxLRWRzYjJKaGJDNW5jbTkxY0ZOcGVtVXBLU0I3Q2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZWE56WlhKMElDOHZJRk4wWlhBZ1kyRnVibTkwSUdKbElIcGxjbThLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemRESmZabTl5WDJobFlXUmxja0F4Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReVgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHa2diMllnZFhKaGJtZGxLRWRzYjJKaGJDNW5jbTkxY0ZOcGVtVXBLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZERKZllXWjBaWEpmWm05eVFESXhDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemRESmZabTl5WDJKdlpIbEFNZ29LZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTWw5bWIzSmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVNCdlppQjFjbUZ1WjJVb1IyeHZZbUZzTG1keWIzVndVMmw2WlNrcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdZMjl1YzNRZ2RIaHVJRDBnWjNSNGJpNVVjbUZ1YzJGamRHbHZiaWhwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCemQybDBZMmdnS0hSNGJpNTBlWEJsS1NCN0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCY0hCc2FXTmhkR2x2YmtOaGJHdzZDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnUFQwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qSTFMVEkzQ2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmNIQnNhV05oZEdsdmJrTmhiR3c2Q2lBZ0lDQXZMeUFnSUd4dlp5aDBlRzR1WVhCd1NXUXVhV1FwQ2lBZ0lDQXZMeUFnSUdKeVpXRnJDaUFnSUNCaWVpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXlYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReVgybG1YMkp2WkhsQU13b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNbDlwWmw5aWIyUjVRRE02Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkREpmWW14dlkydEFOQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTWw5aWJHOWphMEEwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHeHZaeWgwZUc0dVlYQndTV1F1YVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnWW5KbFlXc0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOWliRzlqYTBBeE9Rb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNbDlpYkc5amEwQXhPVG9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNbDltYjNKZlptOXZkR1Z5UURJd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXlYMlp2Y2w5bWIyOTBaWEpBTWpBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwSUc5bUlIVnlZVzVuWlNoSGJHOWlZV3d1WjNKdmRYQlRhWHBsS1NrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOW1iM0pmYUdWaFpHVnlRREVLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZERKZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z6YzJWMFZISmhibk5tWlhJNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem95T0Mwek1Bb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSVWNtRnVjMlpsY2pvS0lDQWdJQzh2SUNBZ2JHOW5LSFI0Ymk1NFptVnlRWE56WlhRdWFXUXBDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1F5WDJsbVgySnZaSGxBTmdvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOXBabDlpYjJSNVFEWTZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemRESmZZbXh2WTJ0QU53b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNbDlpYkc5amEwQTNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUd4dlp5aDBlRzR1ZUdabGNrRnpjMlYwTG1sa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnYVhSdllnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZbkpsWVdzS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTWw5aWJHOWphMEF4T1FvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdZMkZ6WlNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhOelpYUkRiMjVtYVdjNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNekV0TXpNS0lDQWdJQzh2SUdOaGMyVWdWSEpoYm5OaFkzUnBiMjVVZVhCbExrRnpjMlYwUTI5dVptbG5PZ29nSUNBZ0x5OGdJQ0JzYjJjb2RIaHVMbU52Ym1acFowRnpjMlYwTG1sa0tRb2dJQ0FnTHk4Z0lDQmljbVZoYXdvZ0lDQWdZbm9nZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTWw5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkREpmYVdaZlltOWtlVUE1Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReVgybG1YMkp2WkhsQU9Ub0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOWliRzlqYTBBeE1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNbDlpYkc5amEwQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCc2IyY29kSGh1TG1OdmJtWnBaMEZ6YzJWMExtbGtLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdkMGVHNXpJRU52Ym1acFowRnpjMlYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCaWNtVmhhd29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXlYMkpzYjJOclFERTVDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1F5WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVVR0Y1YldWdWREb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNMExUTTJDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVRWVhsdFpXNTBPZ29nSUNBZ0x5OGdJQ0JzYjJjb2RIaHVMbkpsWTJWcGRtVnlLUW9nSUNBZ0x5OGdJQ0JpY21WaGF3b2dJQ0FnWW5vZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOWhablJsY2w5cFpsOWxiSE5sUURFMENpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZERKZmFXWmZZbTlrZVVBeE1nb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNbDlwWmw5aWIyUjVRREV5T2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1F5WDJKc2IyTnJRREV6Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReVgySnNiMk5yUURFek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR3h2WnloMGVHNHVjbVZqWldsMlpYSXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJR0p5WldGckNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZERKZllteHZZMnRBTVRrS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemRESmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1TFpYbFNaV2RwYzNSeVlYUnBiMjQ2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk16Y3RNemtLSUNBZ0lDOHZJR05oYzJVZ1ZISmhibk5oWTNScGIyNVVlWEJsTGt0bGVWSmxaMmx6ZEhKaGRHbHZiam9LSUNBZ0lDOHZJQ0FnYkc5bktIUjRiaTUyYjNSbFMyVjVLUW9nSUNBZ0x5OGdJQ0JpY21WaGF3b2dJQ0FnWW5vZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZERKZmFXWmZZbTlrZVVBeE5Rb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBNbDlwWmw5aWIyUjVRREUxT2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1F5WDJKc2IyTnJRREUyQ2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReVgySnNiMk5yUURFMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJR3h2WnloMGVHNHVkbTkwWlV0bGVTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JuZEhodWN5QldiM1JsVUVzS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklHSnlaV0ZyQ2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkREpmWW14dlkydEFNVGtLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZERKZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTWw5aWJHOWphMEF4T0FvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME1sOWliRzlqYTBBeE9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJzYjJjb2RIaHVMbVp5WldWNlpVRnpjMlYwTG1sa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2QwZUc1eklFWnlaV1Y2WlVGemMyVjBDaUFnSUNCcGRHOWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJpY21WaGF3b2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNReVgySnNiMk5yUURFNUNncDBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXlYMkZtZEdWeVgyWnZja0F5TVRvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qcEhkSGh1YzBGc1oyOHVkR1Z6ZERNb0tTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXpPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUXpYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkRE5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxtOXVRMjl0Y0d4bGRHbHZiaUE5UFQwZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdMQ0FuVDBOQklHMTFjM1FnWW1VZ1RtOVBjQ2NwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBRMEVnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTUwZVhCbFJXNTFiU0E5UFQwZ1ZISmhibk5oWTNScGIyNVVlWEJsTGtGd2NHeHBZMkYwYVc5dVEyRnNiQ2tLSUNBZ0lIUjRiaUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJzYjJjb0owaGxiR3h2SUhSbGMzUTBKeWtLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJa2hsYkd4dklIUmxjM1EwSWdvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1EwS0c5MGFHVnlPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkRFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2RHVnpkRFFvYjNSb1pYSTZJR2QwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzVkhodUtTQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTkY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRMFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZWE56WlhKMEtHOTBhR1Z5TG05dVEyOXRjR3hsZEdsdmJpQTlQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0xDQW5UM1JvWlhJZ2RIaHVJRzExYzNRZ1ltVWdUbTlQY0NjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDNSb1pYSWdkSGh1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZkR2hsY2k1MGVYQmxJRDA5UFNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhCd2JHbGpZWFJwYjI1RFlXeHNLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJoYzNObGNuUW9iM1JvWlhJdWJHRnpkRXh2WnlBOVBUMGdRbmwwWlhNb0owaGxiR3h2SUhSbGMzUTBKeWtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUV4aGMzUk1iMmNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJa2hsYkd4dklIUmxjM1EwSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENodmRHaGxjaTVoY0hCQmNtZHpLREFwSUQwOVBTQnRaWFJvYjJSVFpXeGxZM1J2Y2loSGRIaHVjMEZzWjI4dWNISnZkRzkwZVhCbExuUmxjM1F6S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZDBlRzV6WVhNZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmllWFJsWTE4eElDOHZJRzFsZEdodlpDQWlkR1Z6ZERNb0tYWnZhV1FpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0c5MGFHVnlMbUZ3Y0Vsa0lEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1FwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NXlaV1pzWldOMFFXeHNVR0Y1S0hCaGVUb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1eVpXWnNaV04wUVd4c1VHRjVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUhKbFpteGxZM1JCYkd4UVlYa29jR0Y1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5KbFpteGxZM1JCYkd4UVlYbGZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1eVpXWnNaV04wUVd4c1VHRjVYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnYzJWdVpHVnlPaUJ3WVhrdWMyVnVaR1Z5TG1KNWRHVnpMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJtWldVNklIQmhlUzVtWldVc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFWmxaUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklHWnBjbk4wVm1Gc2FXUTZJSEJoZVM1bWFYSnpkRlpoYkdsa0xBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkdhWEp6ZEZaaGJHbGtDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1ptbHljM1JXWVd4cFpGUnBiV1U2SUhCaGVTNW1hWEp6ZEZaaGJHbGtWR2x0WlN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1JtbHljM1JXWVd4cFpGUnBiV1VLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QnNZWE4wVm1Gc2FXUTZJSEJoZVM1c1lYTjBWbUZzYVdRc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFeGhjM1JXWVd4cFpBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUc1dmRHVTZJSEJoZVM1dWIzUmxMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJPYjNSbENpQWdJQ0JqYjNabGNpQTFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnYkdWaGMyVTZJSEJoZVM1c1pXRnpaU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVEdWaGMyVUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCMGVYQmxRbmwwWlhNNklIQmhlUzUwZVhCbFFubDBaWE1zQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZSNWNHVUtJQ0FnSUdOdmRtVnlJRGNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCbmNtOTFjRWx1WkdWNE9pQndZWGt1WjNKdmRYQkpibVJsZUN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1IzSnZkWEJKYm1SbGVBb2dJQ0FnWTI5MlpYSWdPQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUhSNGJrbGtPaUJ3WVhrdWRIaHVTV1FzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZSNFNVUUtJQ0FnSUdOdmRtVnlJRGtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCd1lYa3VjbVZyWlhsVWJ5NWllWFJsY3l3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1VtVnJaWGxVYndvZ0lDQWdZMjkyWlhJZ01UQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJ5WldObGFYWmxjam9nY0dGNUxuSmxZMlZwZG1WeUxtSjVkR1Z6TEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdZMjkyWlhJZ01URUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJSEJoZVM1aGJXOTFiblFzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1kyOTJaWElnTVRJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQndZWGt1WTJ4dmMyVlNaVzFoYVc1a1pYSlVieTVpZVhSbGN5d0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnWTI5MlpYSWdNVE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZeUxUYzNDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQnpaVzVrWlhJNklIQmhlUzV6Wlc1a1pYSXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lHWmxaVG9nY0dGNUxtWmxaU3dLSUNBZ0lDOHZJQ0FnWm1seWMzUldZV3hwWkRvZ2NHRjVMbVpwY25OMFZtRnNhV1FzQ2lBZ0lDQXZMeUFnSUdacGNuTjBWbUZzYVdSVWFXMWxPaUJ3WVhrdVptbHljM1JXWVd4cFpGUnBiV1VzQ2lBZ0lDQXZMeUFnSUd4aGMzUldZV3hwWkRvZ2NHRjVMbXhoYzNSV1lXeHBaQ3dLSUNBZ0lDOHZJQ0FnYm05MFpUb2djR0Y1TG01dmRHVXNDaUFnSUNBdkx5QWdJR3hsWVhObE9pQndZWGt1YkdWaGMyVXNDaUFnSUNBdkx5QWdJSFI1Y0dWQ2VYUmxjem9nY0dGNUxuUjVjR1ZDZVhSbGN5d0tJQ0FnSUM4dklDQWdaM0p2ZFhCSmJtUmxlRG9nY0dGNUxtZHliM1Z3U1c1a1pYZ3NDaUFnSUNBdkx5QWdJSFI0Ymtsa09pQndZWGt1ZEhodVNXUXNDaUFnSUNBdkx5QWdJSEpsYTJWNVZHODZJSEJoZVM1eVpXdGxlVlJ2TG1KNWRHVnpMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nY0dGNUxuSmxZMlZwZG1WeUxtSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhCaGVTNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklIQmhlUzVqYkc5elpWSmxiV0ZwYm1SbGNsUnZMbUo1ZEdWekxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhwYm5RZ01qUTBDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU5EUUtJQ0FnSUNzS0lDQWdJR052ZG1WeUlERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBOU2gwZUc0NklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncDBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSbGMzUTFLSFI0YmpvZ1ozUjRiaTVVY21GdWMyRmpkR2x2YmlrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBOVjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1ExWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z2FXWWdLSFI0Ymk1MGVYQmxJRDA5UFNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1VUdGNWJXVnVkQ2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUTFYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pwSGRIaHVjMEZzWjI4dWRHVnpkRFZmYVdaZlltOWtlVUF4Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRMVgybG1YMkp2WkhsQU1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdNUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRITjFZZ29LZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9rZDBlRzV6UVd4bmJ5NTBaWE4wTlY5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUI5SUdWc2MyVWdhV1lnS0hSNGJpNTBlWEJsSUQwOVBTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVFYTnpaWFJVY21GdWMyWmxjaWtnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lEMDlDaUFnSUNCaWVpQjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUTFYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRMVgybG1YMkp2WkhsQU13b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T2tkMGVHNXpRV3huYnk1MFpYTjBOVjlwWmw5aWIyUjVRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnlaWFJ6ZFdJS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemREVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRMVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPa2QwZUc1elFXeG5ieTUwWlhOME5WOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdjbVYwZFhKdUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUdCQ1lFQUFUZmtnODNCQlVmZkhVTFNHVnNiRzhnZEdWemREUkNBQUJDQUFBeEd5TVRRUUIxUWdBQU1Sa2pFa1F4R0NNVFFRQmpRZ0FBTmhvQWdBU25nQURlZ0FUeGtJVWtLWUFFN2JUNWM0QUVFOTVxVklBRWRGbjdIMDhHamdZQUtBQWlBQndBRmdBUUFBcENBQUJDQUFCQ0FBQUFpQUIwUXYvemlBQlhRdi90aUFBL1F2L25pQUF4UXYvaGlBQWpRdi9iaUFBVlF2L1ZRdi9WTVJrakVqRVlJeElRUklnQ0xpSkRRZ0FBaUFCTklrTkNBQUNJQUZVaVEwSUFBSWdBOXlKRFFnQUFNUllpQ1VrNEVDUVNSSWdBOVNKRFFnQUFNUllpQ1VrNEVDSVNSSWdCRHlwUEFWQ3dJa05DQUFBeEZpSUppQUc2RmlwUEFWQ3dJa05DQUFBak9CQWlFa1FqT0FnakRVU0ppZ0FBS0NoQ0FBQXlCQ0pFSTBJQUFJc0Rpd0lNUVFDUlFnQUFpd05KakFFNEVFbU1BQ1FTUVFBYlFnQUFRZ0FBaXdFNEdCYXdRZ0FBUWdBQWl3TWlDSXdEUXYvTGl3QWxFa0VBRDBJQUFFSUFBSXNCT0JFV3NFTC8zb3NBZ1FNU1FRQVBRZ0FBUWdBQWl3RTRJUmF3UXYvSGl3QWlFa0VBRGtJQUFFSUFBSXNCT0Fld1F2K3lpd0NCQWhKQkFBNUNBQUJDQUFDTEFUZ0tzRUwvbkVJQUFJc0JPQzBXc0VML2tJbENBQUF4R1NNU1JERVFKQkpFSzdDSmlnRUFRZ0FBaS84NEdTTVNSSXYvT0JBa0VrU0wvemcrS3hKRWkvOGp3aG9wRWtTTC96Z1lNZ2dTUkltS0FRRkNBQUNML3pnQWkvODRBVTRCaS84NEFrNENpLzg0QTA0RGkvODRCRTRFaS84NEJVNEZpLzg0Qms0R2kvODREMDRIaS84NEZrNElpLzg0RjA0SmkvODRJRTRLaS84NEIwNExpLzg0Q0U0TWkvODRDVTROS0U4QlVFOEJGbEJQQVJaUVR3RVdVRThCRmxCTEFSVVdWd1lDVHdKUWdmUUJGbGNHQWs4Q1R3RlFTd0VWZ2ZRQkNFNEJUd05RVGdGTEF4VVdWd1lDVHdSUVRnSVdWd1lDVUU4REZsQlBBMUJQQTFCUEExQlBBeFpRVHdOUVR3SlFUd0ZRaVlvQkFVSUFBSXYvT0JBaUVrRUFCVUlBQUNLSmkvODRFQ1VTUVFBRlFnQUFJNGxDQUFBamlVSUFBSWs9IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
