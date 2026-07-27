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

namespace Arc56.Generated.algorandfoundation.puya_ts.GtxnsAlgo_b13b47fd
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3R4bnNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDM0ODhBOTNGIjpbeyJuYW1lIjoic2VuZGVyIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpcnN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmlyc3RWYWxpZFRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFZhbGlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vdGUiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoibGVhc2UiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJ0eXBlQnl0ZXMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZ3JvdXBJbmRleCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0eG5JZCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InJla2V5VG8iLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbG9zZVJlbWFpbmRlclRvIiwidHlwZSI6ImJ5dGVbMzJdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im90aGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZmxlY3RBbGxQYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbMzJdLGJ5dGVbXSx1aW50NjQsYnl0ZVszMl0sYnl0ZVszMl0sYnl0ZVszMl0sdWludDY0LGJ5dGVbMzJdKSIsInN0cnVjdCI6Ik9iamVjdDM0ODhBOTNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMjVdLCJlcnJvck1lc3NhZ2UiOiJPQ0EgbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk3XSwiZXJyb3JNZXNzYWdlIjoiT3RoZXIgdHhuIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOCw0NDhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBMklEUWdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlR1JtT1RJd1pqTTNJREI0TVRVeFpqZGpOelVnSWtobGJHeHZJSFJsYzNRMElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSGRIaHVjMEZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVE1LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0UzT0RBd01HUmxJREI0WmpFNU1EZzFNalFnTHk4Z2JXVjBhRzlrSUNKMFpYTjBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wTWlncGRtOXBaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTXlncGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhsWkdJMFpqazNNeUF3ZURFelpHVTJZVFUwSURCNE56UTFPV1ppTVdZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTkNoaGNIQnNLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxabXhsWTNSQmJHeFFZWGtvY0dGNUtTaGllWFJsV3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExHSjVkR1ZiTXpKZExHSjVkR1ZiWFN4MWFXNTBOalFzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBzZFdsdWREWTBMR0o1ZEdWYk16SmRLU0lzSUcxbGRHaHZaQ0FpZEdWemREVW9kSGh1S1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEY5eWIzVjBaVUEwSUcxaGFXNWZkR1Z6ZERKZmNtOTFkR1ZBTlNCdFlXbHVYM1JsYzNRelgzSnZkWFJsUURZZ2JXRnBibDkwWlhOME5GOXliM1YwWlVBM0lHMWhhVzVmY21WbWJHVmpkRUZzYkZCaGVWOXliM1YwWlVBNElHMWhhVzVmZEdWemREVmZjbTkxZEdWQU9Rb2dJQ0FnWlhKeUNncHRZV2x1WDNSbGMzUTFYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnZEdWemREVW9kSGh1T2lCbmRIaHVMbFJ5WVc1ellXTjBhVzl1S1RvZ2RXbHVkRFkwSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdsbUlDaDBlRzR1ZEhsd1pTQTlQVDBnVkhKaGJuTmhZM1JwYjI1VWVYQmxMbEJoZVcxbGJuUXBJSHNLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JXRnBibDlsYkhObFgySnZaSGxBTVRnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklISmxkSFZ5YmlBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvS2JXRnBibDloWm5SbGNsOXBibXhwYm1Wa1gzUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPanBIZEhodWMwRnNaMjh1ZEdWemREVkFNakU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z2RHVnpkRFVvZEhodU9pQm5kSGh1TGxSeVlXNXpZV04wYVc5dUtUb2dkV2x1ZERZMElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXeHpaVjlpYjJSNVFERTRPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUgwZ1pXeHpaU0JwWmlBb2RIaHVMblI1Y0dVZ1BUMDlJRlJ5WVc1ellXTjBhVzl1Vkhsd1pTNUJjM05sZEZSeVlXNXpabVZ5S1NCN0NpQWdJQ0JwYm5Salh6SWdMeThnTkFvZ0lDQWdQVDBLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUhKbGRIVnliaUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSbGMzUTFLSFI0YmpvZ1ozUjRiaTVVY21GdWMyRmpkR2x2YmlrNklIVnBiblEyTkNCN0NpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXNXNhVzVsWkY5MFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzZSM1I0Ym5OQmJHZHZMblJsYzNRMVFESXhDZ3B0WVdsdVgzSmxabXhsWTNSQmJHeFFZWGxmY205MWRHVkFPRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCeVpXWnNaV04wUVd4c1VHRjVLSEJoZVRvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1NCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCelpXNWtaWEk2SUhCaGVTNXpaVzVrWlhJdVlubDBaWE1zQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUdabFpUb2djR0Y1TG1abFpTd0tJQ0FnSUdScFp5QXhDaUFnSUNCbmRIaHVjeUJHWldVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5Qm1hWEp6ZEZaaGJHbGtPaUJ3WVhrdVptbHljM1JXWVd4cFpDd0tJQ0FnSUdScFp5QXlDaUFnSUNCbmRIaHVjeUJHYVhKemRGWmhiR2xrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1ptbHljM1JXWVd4cFpGUnBiV1U2SUhCaGVTNW1hWEp6ZEZaaGJHbGtWR2x0WlN3S0lDQWdJR1JwWnlBekNpQWdJQ0JuZEhodWN5QkdhWEp6ZEZaaGJHbGtWR2x0WlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHeGhjM1JXWVd4cFpEb2djR0Y1TG14aGMzUldZV3hwWkN3S0lDQWdJR1JwWnlBMENpQWdJQ0JuZEhodWN5Qk1ZWE4wVm1Gc2FXUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJ1YjNSbE9pQndZWGt1Ym05MFpTd0tJQ0FnSUdScFp5QTFDaUFnSUNCbmRIaHVjeUJPYjNSbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdiR1ZoYzJVNklIQmhlUzVzWldGelpTd0tJQ0FnSUdScFp5QTJDaUFnSUNCbmRIaHVjeUJNWldGelpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJSFI1Y0dWQ2VYUmxjem9nY0dGNUxuUjVjR1ZDZVhSbGN5d0tJQ0FnSUdScFp5QTNDaUFnSUNCbmRIaHVjeUJVZVhCbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdaM0p2ZFhCSmJtUmxlRG9nY0dGNUxtZHliM1Z3U1c1a1pYZ3NDaUFnSUNCa2FXY2dPQW9nSUNBZ1ozUjRibk1nUjNKdmRYQkpibVJsZUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk56SUtJQ0FnSUM4dklIUjRia2xrT2lCd1lYa3VkSGh1U1dRc0NpQWdJQ0JrYVdjZ09Rb2dJQ0FnWjNSNGJuTWdWSGhKUkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklISmxhMlY1Vkc4NklIQmhlUzV5Wld0bGVWUnZMbUo1ZEdWekxBb2dJQ0FnWkdsbklERXdDaUFnSUNCbmRIaHVjeUJTWld0bGVWUnZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUhCaGVTNXlaV05sYVhabGNpNWllWFJsY3l3S0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJSEJoZVM1aGJXOTFiblFzQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklIQmhlUzVqYkc5elpWSmxiV0ZwYm1SbGNsUnZMbUo1ZEdWekxBb2dJQ0FnZFc1amIzWmxjaUF4TXdvZ0lDQWdaM1I0Ym5NZ1EyeHZjMlZTWlcxaGFXNWtaWEpVYndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5qSXROemNLSUNBZ0lDOHZJSEpsZEhWeWJpQjdDaUFnSUNBdkx5QWdJSE5sYm1SbGNqb2djR0Y1TG5ObGJtUmxjaTVpZVhSbGN5d0tJQ0FnSUM4dklDQWdabVZsT2lCd1lYa3VabVZsTEFvZ0lDQWdMeThnSUNCbWFYSnpkRlpoYkdsa09pQndZWGt1Wm1seWMzUldZV3hwWkN3S0lDQWdJQzh2SUNBZ1ptbHljM1JXWVd4cFpGUnBiV1U2SUhCaGVTNW1hWEp6ZEZaaGJHbGtWR2x0WlN3S0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa09pQndZWGt1YkdGemRGWmhiR2xrTEFvZ0lDQWdMeThnSUNCdWIzUmxPaUJ3WVhrdWJtOTBaU3dLSUNBZ0lDOHZJQ0FnYkdWaGMyVTZJSEJoZVM1c1pXRnpaU3dLSUNBZ0lDOHZJQ0FnZEhsd1pVSjVkR1Z6T2lCd1lYa3VkSGx3WlVKNWRHVnpMQW9nSUNBZ0x5OGdJQ0JuY205MWNFbHVaR1Y0T2lCd1lYa3VaM0p2ZFhCSmJtUmxlQ3dLSUNBZ0lDOHZJQ0FnZEhodVNXUTZJSEJoZVM1MGVHNUpaQ3dLSUNBZ0lDOHZJQ0FnY21WclpYbFViem9nY0dGNUxuSmxhMlY1Vkc4dVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCd1lYa3VjbVZqWldsMlpYSXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2NHRjVMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2djR0Y1TG1Oc2IzTmxVbVZ0WVdsdVpHVnlWRzh1WW5sMFpYTXNDaUFnSUNBdkx5QjlDaUFnSUNCMWJtTnZkbVZ5SURFeUNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJREV6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUE1Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdaalFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlORFFLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEa0tJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCeVpXWnNaV04wUVd4c1VHRjVLSEJoZVRvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1NCN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUTBYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnZEdWemREUW9iM1JvWlhJNklHZDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNWSGh1S1NCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklHRndjR3dLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhjSEJzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0c5MGFHVnlMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3TENBblQzUm9aWElnZEhodUlHMTFjM1FnWW1VZ1RtOVBjQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDNSb1pYSWdkSGh1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZkR2hsY2k1MGVYQmxJRDA5UFNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhCd2JHbGpZWFJwYjI1RFlXeHNLUW9nSUNBZ2FXNTBZMTh4SUM4dklEWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJoYzNObGNuUW9iM1JvWlhJdWJHRnpkRXh2WnlBOVBUMGdRbmwwWlhNb0owaGxiR3h2SUhSbGMzUTBKeWtwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUV4aGMzUk1iMmNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJa2hsYkd4dklIUmxjM1EwSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENodmRHaGxjaTVoY0hCQmNtZHpLREFwSUQwOVBTQnRaWFJvYjJSVFpXeGxZM1J2Y2loSGRIaHVjMEZzWjI4dWNISnZkRzkwZVhCbExuUmxjM1F6S1NrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5OaElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUcxbGRHaHZaQ0FpZEdWemRETW9LWFp2YVdRaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdZWE56WlhKMEtHOTBhR1Z5TG1Gd2NFbGtJRDA5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRcENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUIwWlhOME5DaHZkR2hsY2pvZ1ozUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHeFVlRzRwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWemRETmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG05dVEyOXRjR3hsZEdsdmJpQTlQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0xDQW5UME5CSUcxMWMzUWdZbVVnVG05UGNDY3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QwTkJJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVkSGx3WlVWdWRXMGdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCY0hCc2FXTmhkR2x2YmtOaGJHd3BDaUFnSUNCMGVHNGdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdiRzluS0NkSVpXeHNieUIwWlhOME5DY3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSklaV3hzYnlCMFpYTjBOQ0lLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUhSbGMzUXpLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhOME1sOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVNCdlppQjFjbUZ1WjJVb1IyeHZZbUZzTG1keWIzVndVMmw2WlNrcElIc0tJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lHbHVkR05mTXlBdkx5QXdDZ3B0WVdsdVgyWnZjbDlvWldGa1pYSkFNekE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQnBJRzltSUhWeVlXNW5aU2hIYkc5aVlXd3VaM0p2ZFhCVGFYcGxLU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDltYjNKQU5ETUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJ6ZDJsMFkyZ2dLSFI0Ymk1MGVYQmxLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCY0hCc2FXTmhkR2x2YmtOaGJHdzZDaUFnSUNCcGJuUmpYekVnTHk4Z05nb2dJQ0FnUFQwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qSTFMVEkzQ2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmNIQnNhV05oZEdsdmJrTmhiR3c2Q2lBZ0lDQXZMeUFnSUd4dlp5aDBlRzR1WVhCd1NXUXVhV1FwQ2lBZ0lDQXZMeUFnSUdKeVpXRnJDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNek1LSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHeHZaeWgwZUc0dVlYQndTV1F1YVdRcENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbDBiMklLSUNBZ0lHeHZad29LYldGcGJsOWliRzlqYTBBME1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdrZ2IyWWdkWEpoYm1kbEtFZHNiMkpoYkM1bmNtOTFjRk5wZW1VcEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUJ0WVdsdVgyWnZjbDlvWldGa1pYSkFNekFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmMzTmxkRlJ5WVc1elptVnlPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNamd0TXpBS0lDQWdJQzh2SUdOaGMyVWdWSEpoYm5OaFkzUnBiMjVVZVhCbExrRnpjMlYwVkhKaGJuTm1aWEk2Q2lBZ0lDQXZMeUFnSUd4dlp5aDBlRzR1ZUdabGNrRnpjMlYwTG1sa0tRb2dJQ0FnTHk4Z0lDQmljbVZoYXdvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNMUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJzYjJjb2RIaHVMbmhtWlhKQmMzTmxkQzVwWkNrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1dHWmxja0Z6YzJWMENpQWdJQ0JwZEc5aUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmljbVZoYXdvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURReUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNelU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSRGIyNW1hV2M2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNekV0TXpNS0lDQWdJQzh2SUdOaGMyVWdWSEpoYm5OaFkzUnBiMjVVZVhCbExrRnpjMlYwUTI5dVptbG5PZ29nSUNBZ0x5OGdJQ0JzYjJjb2RIaHVMbU52Ym1acFowRnpjMlYwTG1sa0tRb2dJQ0FnTHk4Z0lDQmljbVZoYXdvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNM0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJzYjJjb2RIaHVMbU52Ym1acFowRnpjMlYwTG1sa0tRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QkRiMjVtYVdkQmMzTmxkQW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWW5KbFlXc0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQTBNZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJR05oYzJVZ1ZISmhibk5oWTNScGIyNVVlWEJsTGxCaGVXMWxiblE2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TkMwek5nb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVVR0Y1YldWdWREb0tJQ0FnSUM4dklDQWdiRzluS0hSNGJpNXlaV05sYVhabGNpa0tJQ0FnSUM4dklDQWdZbkpsWVdzS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek9Rb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnYkc5bktIUjRiaTV5WldObGFYWmxjaWtLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUdKeVpXRnJDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFORElLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek9Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJqWVhObElGUnlZVzV6WVdOMGFXOXVWSGx3WlM1TFpYbFNaV2RwYzNSeVlYUnBiMjQ2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQwOUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3pOeTB6T1FvZ0lDQWdMeThnWTJGelpTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVMyVjVVbVZuYVhOMGNtRjBhVzl1T2dvZ0lDQWdMeThnSUNCc2IyY29kSGh1TG5admRHVkxaWGtwQ2lBZ0lDQXZMeUFnSUdKeVpXRnJDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCc2IyY29kSGh1TG5admRHVkxaWGtwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZadmRHVlFTd29nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnWW5KbFlXc0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQTBNZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURReE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJR3h2WnloMGVHNHVabkpsWlhwbFFYTnpaWFF1YVdRcENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFWnlaV1Y2WlVGemMyVjBDaUFnSUNCcGRHOWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJpY21WaGF3b2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEUXlDZ3B0WVdsdVgyRm1kR1Z5WDJadmNrQTBNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCMFpYTjBNaWdwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWemRGOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5kSGh1TGxCaGVXMWxiblJVZUc0b01Da3VZVzF2ZFc1MElENGdNQ2tLSUNBZ0lHZDBlRzRnTUNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdaM1I0YmlBd0lFRnRiM1Z1ZEFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdkR1Z6ZENncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSGRIaHVjMEZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFZRUFDWURCTitTRHpjRUZSOThkUXRJWld4c2J5QjBaWE4wTkRFYlFRR2pNUmtVUkRFWVJJSUNCS2VBQU40RThaQ0ZKQ2lDQXdUdHRQbHpCQlBlYWxRRWRGbjdIellhQUk0R0FXRUE5UURvQUw4QUhRQUJBREVXSWdrNEVFa2lFa0VBQ1VnaUZpbE1VTEFpUXlRU1NDVkMvL0l4RmlJSlNUZ1FJaEpFU1RnQVN3RTRBVXNDT0FKTEF6Z0RTd1E0QkVzRk9BVkxCamdHU3djNEQwc0lPQlpMQ1RnWFN3bzRJRXNMT0FkTEREZ0lUdzA0Q1U4TUZrOE5URkJQREJaUVR3c1dVRThLRmxCTENSVVdWd1lDVHdwUVRJQUNBUFJRU3dFVmdmUUJDRXhQQ2xCTENSVVdWd1lDVHdwUVR3SVdWd1lDVHdKTVVFOElGbEJQQjFCUEJsQlBCVkJQQkJaUVR3TlFUd0pRVEZBcFRGQ3dJa014RmlJSlNUZ1FTU01TUkVzQk9Ca1VSQ01TUkVrNFBpb1NSRWs1R2dBb0VrUTRHRElJRWtRaVF6RVpGRVF4RUNNU1JDcXdJa015QkNWSlN3SU1RUUJnU1RnUVNVNENJeEpCQUF4RkFVazRHQmF3SWdoQy8rSkxBU1FTUVFBS1JRRkpPQkVXc0VMLzZrc0JnUU1TUVFBS1JRRkpPQ0VXc0VMLzJFc0JJaEpCQUFsRkFVazRCN0JDLzhoTWdRSVNRUUFIU1RnS3NFTC91a2s0TFJhd1F2K3lJa016QUJBaUVrUXpBQWhFSWtNeEdSUXhHQlFRUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
