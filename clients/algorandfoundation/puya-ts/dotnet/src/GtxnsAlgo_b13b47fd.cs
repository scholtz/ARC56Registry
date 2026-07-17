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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3R4bnNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDM0ODhBOTNGIjpbeyJuYW1lIjoic2VuZGVyIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpcnN0VmFsaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmlyc3RWYWxpZFRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFZhbGlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vdGUiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoibGVhc2UiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJ0eXBlQnl0ZXMiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZ3JvdXBJbmRleCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0eG5JZCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6InJla2V5VG8iLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbG9zZVJlbWFpbmRlclRvIiwidHlwZSI6ImJ5dGVbMzJdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im90aGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZmxlY3RBbGxQYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbMzJdLGJ5dGVbXSx1aW50NjQsYnl0ZVszMl0sYnl0ZVszMl0sYnl0ZVszMl0sdWludDY0LGJ5dGVbMzJdKSIsInN0cnVjdCI6Ik9iamVjdDM0ODhBOTNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdDUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidHhuIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMzFdLCJlcnJvck1lc3NhZ2UiOiJPQ0EgbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzXSwiZXJyb3JNZXNzYWdlIjoiT3RoZXIgdHhuIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5N10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNCw0NjBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBMklEUWdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlR1JtT1RJd1pqTTNJREI0TVRVeFpqZGpOelVnSWtobGJHeHZJSFJsYzNRMElnb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1IzUjRibk5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV6Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhoTnpnd01EQmtaU0F3ZUdZeE9UQTROVEkwSUM4dklHMWxkR2h2WkNBaWRHVnpkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZERJb0tYWnZhV1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJRzFsZEdodlpDQWlkR1Z6ZERNb0tYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WldSaU5HWTVOek1nTUhneE0yUmxObUUxTkNBd2VEYzBOVGxtWWpGbUlDOHZJRzFsZEdodlpDQWlkR1Z6ZERRb1lYQndiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV1pzWldOMFFXeHNVR0Y1S0hCaGVTa29ZbmwwWlZzek1sMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYlhTeGllWFJsV3pNeVhTeGllWFJsVzEwc2RXbHVkRFkwTEdKNWRHVmJNekpkTEdKNWRHVmJNekpkTEdKNWRHVmJNekpkTEhWcGJuUTJOQ3hpZVhSbFd6TXlYU2tpTENCdFpYUm9iMlFnSW5SbGMzUTFLSFI0YmlsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTkNCdFlXbHVYM1JsYzNReVgzSnZkWFJsUURVZ2JXRnBibDkwWlhOME0xOXliM1YwWlVBMklHMWhhVzVmZEdWemREUmZjbTkxZEdWQU55QnRZV2x1WDNKbFpteGxZM1JCYkd4UVlYbGZjbTkxZEdWQU9DQnRZV2x1WDNSbGMzUTFYM0p2ZFhSbFFEa0tJQ0FnSUdWeWNnb0tiV0ZwYmw5MFpYTjBOVjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSbGMzUTFLSFI0YmpvZ1ozUjRiaTVVY21GdWMyRmpkR2x2YmlrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCcFppQW9kSGh1TG5SNWNHVWdQVDA5SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVRWVhsdFpXNTBLU0I3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5bGJITmxYMkp2WkhsQU1UZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdNUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtDbTFoYVc1ZllXWjBaWEpmYVc1c2FXNWxaRjkwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvNlIzUjRibk5CYkdkdkxuUmxjM1ExUURJeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJSFJsYzNRMUtIUjRiam9nWjNSNGJpNVVjbUZ1YzJGamRHbHZiaWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlZzYzJWZlltOWtlVUF4T0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QjlJR1ZzYzJVZ2FXWWdLSFI0Ymk1MGVYQmxJRDA5UFNCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhOelpYUlVjbUZ1YzJabGNpa2dld29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklISmxkSFZ5YmlBd0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklIUmxjM1ExS0hSNGJqb2daM1I0Ymk1VWNtRnVjMkZqZEdsdmJpazZJSFZwYm5RMk5DQjdDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOTBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem82UjNSNGJuTkJiR2R2TG5SbGMzUTFRREl4Q2dwdFlXbHVYM0psWm14bFkzUkJiR3hRWVhsZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QnlaV1pzWldOMFFXeHNVR0Y1S0hCaGVUb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtTQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QnpaVzVrWlhJNklIQmhlUzV6Wlc1a1pYSXVZbmwwWlhNc0NpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklHWmxaVG9nY0dGNUxtWmxaU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCR1pXVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJtYVhKemRGWmhiR2xrT2lCd1lYa3VabWx5YzNSV1lXeHBaQ3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQm5kSGh1Y3lCR2FYSnpkRlpoYkdsa0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdabWx5YzNSV1lXeHBaRlJwYldVNklIQmhlUzVtYVhKemRGWmhiR2xrVkdsdFpTd0tJQ0FnSUdScFp5QXpDaUFnSUNCbmRIaHVjeUJHYVhKemRGWmhiR2xrVkdsdFpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJR3hoYzNSV1lXeHBaRG9nY0dGNUxteGhjM1JXWVd4cFpDd0tJQ0FnSUdScFp5QTBDaUFnSUNCbmRIaHVjeUJNWVhOMFZtRnNhV1FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCdWIzUmxPaUJ3WVhrdWJtOTBaU3dLSUNBZ0lHUnBaeUExQ2lBZ0lDQm5kSGh1Y3lCT2IzUmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnYkdWaGMyVTZJSEJoZVM1c1pXRnpaU3dLSUNBZ0lHUnBaeUEyQ2lBZ0lDQm5kSGh1Y3lCTVpXRnpaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUhSNWNHVkNlWFJsY3pvZ2NHRjVMblI1Y0dWQ2VYUmxjeXdLSUNBZ0lHUnBaeUEzQ2lBZ0lDQm5kSGh1Y3lCVWVYQmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnWjNKdmRYQkpibVJsZURvZ2NHRjVMbWR5YjNWd1NXNWtaWGdzQ2lBZ0lDQmthV2NnT0FvZ0lDQWdaM1I0Ym5NZ1IzSnZkWEJKYm1SbGVBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOeklLSUNBZ0lDOHZJSFI0Ymtsa09pQndZWGt1ZEhodVNXUXNDaUFnSUNCa2FXY2dPUW9nSUNBZ1ozUjRibk1nVkhoSlJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJSEpsYTJWNVZHODZJSEJoZVM1eVpXdGxlVlJ2TG1KNWRHVnpMQW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQm5kSGh1Y3lCU1pXdGxlVlJ2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklIQmhlUzV5WldObGFYWmxjaTVpZVhSbGN5d0tJQ0FnSUdScFp5QXhNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCaGJXOTFiblE2SUhCaGVTNWhiVzkxYm5Rc0NpQWdJQ0JrYVdjZ01USUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJSEJoZVM1amJHOXpaVkpsYldGcGJtUmxjbFJ2TG1KNWRHVnpMQW9nSUNBZ2RXNWpiM1psY2lBeE13b2dJQ0FnWjNSNGJuTWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOakl0TnpjS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUhObGJtUmxjam9nY0dGNUxuTmxibVJsY2k1aWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWm1WbE9pQndZWGt1Wm1WbExBb2dJQ0FnTHk4Z0lDQm1hWEp6ZEZaaGJHbGtPaUJ3WVhrdVptbHljM1JXWVd4cFpDd0tJQ0FnSUM4dklDQWdabWx5YzNSV1lXeHBaRlJwYldVNklIQmhlUzVtYVhKemRGWmhiR2xrVkdsdFpTd0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtPaUJ3WVhrdWJHRnpkRlpoYkdsa0xBb2dJQ0FnTHk4Z0lDQnViM1JsT2lCd1lYa3VibTkwWlN3S0lDQWdJQzh2SUNBZ2JHVmhjMlU2SUhCaGVTNXNaV0Z6WlN3S0lDQWdJQzh2SUNBZ2RIbHdaVUo1ZEdWek9pQndZWGt1ZEhsd1pVSjVkR1Z6TEFvZ0lDQWdMeThnSUNCbmNtOTFjRWx1WkdWNE9pQndZWGt1WjNKdmRYQkpibVJsZUN3S0lDQWdJQzh2SUNBZ2RIaHVTV1E2SUhCaGVTNTBlRzVKWkN3S0lDQWdJQzh2SUNBZ2NtVnJaWGxVYnpvZ2NHRjVMbkpsYTJWNVZHOHVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQndZWGt1Y21WalpXbDJaWEl1WW5sMFpYTXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2djR0Y1TG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nY0dGNUxtTnNiM05sVW1WdFlXbHVaR1Z5Vkc4dVlubDBaWE1zQ2lBZ0lDQXZMeUI5Q2lBZ0lDQjFibU52ZG1WeUlERXlDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURFekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREV3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBNUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3WmpRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5TkRRS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGtLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QnlaV1pzWldOMFFXeHNVR0Y1S0hCaGVUb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtTQjdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1EwWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2RHVnpkRFFvYjNSb1pYSTZJR2QwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzVkhodUtTQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJR0Z3Y0d3S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoY0hCc0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZWE56WlhKMEtHOTBhR1Z5TG05dVEyOXRjR3hsZEdsdmJpQTlQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0xDQW5UM1JvWlhJZ2RIaHVJRzExYzNRZ1ltVWdUbTlQY0NjcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QzUm9aWElnZEhodUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUdGemMyVnlkQ2h2ZEdobGNpNTBlWEJsSUQwOVBTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVFYQndiR2xqWVhScGIyNURZV3hzS1FvZ0lDQWdhVzUwWTE4eElDOHZJRFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCaGMzTmxjblFvYjNSb1pYSXViR0Z6ZEV4dlp5QTlQVDBnUW5sMFpYTW9KMGhsYkd4dklIUmxjM1EwSnlrcENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFeGhjM1JNYjJjS0lDQWdJR0o1ZEdWalh6SWdMeThnSWtobGJHeHZJSFJsYzNRMElnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZkR2hsY2k1aGNIQkJjbWR6S0RBcElEMDlQU0J0WlhSb2IyUlRaV3hsWTNSdmNpaEhkSGh1YzBGc1oyOHVjSEp2ZEc5MGVYQmxMblJsYzNRektTa0tJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklHMWxkR2h2WkNBaWRHVnpkRE1vS1hadmFXUWlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnWVhOelpYSjBLRzkwYUdWeUxtRndjRWxrSUQwOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNXUXBDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCMFpYTjBOQ2h2ZEdobGNqb2daM1I0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3hVZUc0cElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRE5mY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxtOXVRMjl0Y0d4bGRHbHZiaUE5UFQwZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdMQ0FuVDBOQklHMTFjM1FnWW1VZ1RtOVBjQ2NwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUME5CSUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1ZEhsd1pVVnVkVzBnUFQwOUlGUnlZVzV6WVdOMGFXOXVWSGx3WlM1QmNIQnNhV05oZEdsdmJrTmhiR3dwQ2lBZ0lDQjBlRzRnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnYkc5bktDZElaV3hzYnlCMFpYTjBOQ2NwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pJWld4c2J5QjBaWE4wTkNJS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIUmxjM1F6S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYTjBNbDl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FTQnZaaUIxY21GdVoyVW9SMnh2WW1Gc0xtZHliM1Z3VTJsNlpTa3BJSHNLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR0oxY25rZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR0oxY25rZ01nb0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFETXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FTQnZaaUIxY21GdVoyVW9SMnh2WW1Gc0xtZHliM1Z3VTJsNlpTa3BJSHNLSUNBZ0lHUjFjRElLSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURRekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdjM2RwZEdOb0lDaDBlRzR1ZEhsd1pTa2dld29nSUNBZ1pHbG5JREVLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklHTmhjMlVnVkhKaGJuTmhZM1JwYjI1VWVYQmxMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JEb0tJQ0FnSUdsdWRHTmZNU0F2THlBMkNpQWdJQ0E5UFFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1qVXRNamNLSUNBZ0lDOHZJR05oYzJVZ1ZISmhibk5oWTNScGIyNVVlWEJsTGtGd2NHeHBZMkYwYVc5dVEyRnNiRG9LSUNBZ0lDOHZJQ0FnYkc5bktIUjRiaTVoY0hCSlpDNXBaQ2tLSUNBZ0lDOHZJQ0FnWW5KbFlXc0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXpNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUd4dlp5aDBlRzR1WVhCd1NXUXVhV1FwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DZ3B0WVdsdVgySnNiMk5yUURReU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVNCdlppQjFjbUZ1WjJVb1IyeHZZbUZzTG1keWIzVndVMmw2WlNrcElIc0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0F6TUFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFETXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdOaGMyVWdWSEpoYm5OaFkzUnBiMjVVZVhCbExrRnpjMlYwVkhKaGJuTm1aWEk2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRFFLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem95T0Mwek1Bb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSVWNtRnVjMlpsY2pvS0lDQWdJQzh2SUNBZ2JHOW5LSFI0Ymk1NFptVnlRWE56WlhRdWFXUXBDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16VUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJzYjJjb2RIaHVMbmhtWlhKQmMzTmxkQzVwWkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QllabVZ5UVhOelpYUUtJQ0FnSUdsMGIySUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkMGVHNXpMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR0p5WldGckNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU5ESUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6TlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRFTnZibVpwWnpvS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TVMwek13b2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSRGIyNW1hV2M2Q2lBZ0lDQXZMeUFnSUd4dlp5aDBlRzR1WTI5dVptbG5RWE56WlhRdWFXUXBDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16Y0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmRIaHVjeTVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJzYjJjb2RIaHVMbU52Ym1acFowRnpjMlYwTG1sa0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdkMGVHNXpJRU52Ym1acFowRnpjMlYwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCaWNtVmhhd29nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRRFF5Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16YzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnWTJGelpTQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVVHRjViV1Z1ZERvS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5kSGh1Y3k1aGJHZHZMblJ6T2pNMExUTTJDaUFnSUNBdkx5QmpZWE5sSUZSeVlXNXpZV04wYVc5dVZIbHdaUzVRWVhsdFpXNTBPZ29nSUNBZ0x5OGdJQ0JzYjJjb2RIaHVMbkpsWTJWcGRtVnlLUW9nSUNBZ0x5OGdJQ0JpY21WaGF3b2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFETTVDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnYkc5bktIUjRiaTV5WldObGFYWmxjaWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z1luSmxZV3NLSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEEwTWdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFETTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZDBlRzV6TG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUdOaGMyVWdWSEpoYm5OaFkzUnBiMjVVZVhCbExrdGxlVkpsWjJsemRISmhkR2x2YmpvS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem96Tnkwek9Rb2dJQ0FnTHk4Z1kyRnpaU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVTMlY1VW1WbmFYTjBjbUYwYVc5dU9nb2dJQ0FnTHk4Z0lDQnNiMmNvZEhodUxuWnZkR1ZMWlhrcENpQWdJQ0F2THlBZ0lHSnlaV0ZyQ2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnNiMmNvZEhodUxuWnZkR1ZMWlhrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdWbTkwWlZCTENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QmljbVZoYXdvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURReUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaM1I0Ym5NdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2JHOW5LSFI0Ymk1bWNtVmxlbVZCYzNObGRDNXBaQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCR2NtVmxlbVZCYzNObGRBb2dJQ0FnYVhSdllnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjNSNGJuTXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdZbkpsWVdzS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBME1nb0tiV0ZwYmw5aFpuUmxjbDltYjNKQU5ETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlozUjRibk11WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnZEdWemRESW9LU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QmhjM05sY25Rb1ozUjRiaTVRWVhsdFpXNTBWSGh1S0RBcExtRnRiM1Z1ZENBK0lEQXBDaUFnSUNCbmRIaHVJREFnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lHZDBlRzRnTUNCQmJXOTFiblFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmQwZUc1ekxtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIUmxjM1FvS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluZEhodWN5NWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUjNSNGJuTkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUVlFQUNZREJOK1NEemNFRlI5OGRRdElaV3hzYnlCMFpYTjBOSUFBUndJeEcwRUJxekVaRkVReEdFU0NBZ1NuZ0FEZUJQR1FoU1FvZ2dNRTdiVDVjd1FUM21wVUJIUloreDgyR2dDT0JnRnBBUGNBNmdEQkFCOEFBUUF4RmlJSk9CQkpSUUlpRWtFQUNDSVdLVXhRc0NKRFNTUVNTQ1ZDLy9FeEZpSUpTVGdRSWhKRVNUZ0FTd0U0QVVzQ09BSkxBemdEU3dRNEJFc0ZPQVZMQmpnR1N3YzREMHNJT0JaTENUZ1hTd280SUVzTE9BZExERGdJVHcwNENVOE1GazhOVEZCUERCWlFUd3NXVUU4S0ZsQkxDUlVXVndZQ1R3cFFUSUFDQVBSUVN3RVZnZlFCQ0V4UENsQkxDUlVXVndZQ1R3cFFUd0lXVndZQ1R3Sk1VRThJRmxCUEIxQlBCbEJQQlZCUEJCWlFUd05RVHdKUVRGQXBURkN3SWtNeEZpSUpTVGdRU1NNU1JFc0JPQmtVUkNNU1JFazRQaW9TUkVrNUdnQW9Fa1E0R0RJSUVrUWlRekVaRkVReEVDTVNSQ3F3SWtNeUJFVUJKVVVDU2d4QkFHUkxBVGdRU1VVRUl4SkJBQTlMQVRnWUZyQkxBU0lJUlFKQy8rQkxBaVFTUVFBSlN3RTRFUmF3UXYvblN3S0JBeEpCQUFsTEFUZ2hGckJDLzlaTEFpSVNRUUFJU3dFNEI3QkMvOGRMQW9FQ0VrRUFDRXNCT0Fxd1F2KzNTd0U0TFJhd1F2K3VJa016QUJBaUVrUXpBQWhFSWtNeEdSUXhHQlFRUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
