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

namespace Arc56.Generated.algorandecosystem.escrow_session_vault.EscrowSessionVaultHybridManager_0155e8ef
{


    public class EscrowSessionVaultHybridManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowSessionVaultHybridManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object43Bc5A10 : AVMObjectType
            {
                public Algorand.Address Payer { get; set; }

                public Algorand.Address Payee { get; set; }

                public byte[] AuthorizedSigner { get; set; }

                public ulong TotalDeposit { get; set; }

                public ulong LastSettled { get; set; }

                public ulong LatestVoucherAmount { get; set; }

                public ulong StartRound { get; set; }

                public ulong StartTimestamp { get; set; }

                public ulong CloseRequestedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayee.From(Payee);
                    ret.AddRange(vPayee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorizedSigner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vAuthorizedSigner.From(AuthorizedSigner);
                    ret.AddRange(vAuthorizedSigner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDeposit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalDeposit.From(TotalDeposit);
                    ret.AddRange(vTotalDeposit.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastSettled.From(LastSettled);
                    ret.AddRange(vLastSettled.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLatestVoucherAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLatestVoucherAmount.From(LatestVoucherAmount);
                    ret.AddRange(vLatestVoucherAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartRound.From(StartRound);
                    ret.AddRange(vStartRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartTimestamp.From(StartTimestamp);
                    ret.AddRange(vStartTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCloseRequestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCloseRequestedAt.From(CloseRequestedAt);
                    ret.AddRange(vCloseRequestedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object43Bc5A10 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object43Bc5A10();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayee = vPayee.ToValue();
                    if (valuePayee is Algorand.Address vPayeeValue) { ret.Payee = vPayeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorizedSigner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vAuthorizedSigner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuthorizedSigner = vAuthorizedSigner.ToValue();
                    if (valueAuthorizedSigner is byte[] vAuthorizedSignerValue) { ret.AuthorizedSigner = vAuthorizedSignerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDeposit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalDeposit.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalDeposit = vTotalDeposit.ToValue();
                    if (valueTotalDeposit is ulong vTotalDepositValue) { ret.TotalDeposit = vTotalDepositValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastSettled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastSettled = vLastSettled.ToValue();
                    if (valueLastSettled is ulong vLastSettledValue) { ret.LastSettled = vLastSettledValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLatestVoucherAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLatestVoucherAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLatestVoucherAmount = vLatestVoucherAmount.ToValue();
                    if (valueLatestVoucherAmount is ulong vLatestVoucherAmountValue) { ret.LatestVoucherAmount = vLatestVoucherAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartRound = vStartRound.ToValue();
                    if (valueStartRound is ulong vStartRoundValue) { ret.StartRound = vStartRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartTimestamp = vStartTimestamp.ToValue();
                    if (valueStartTimestamp is ulong vStartTimestampValue) { ret.StartTimestamp = vStartTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCloseRequestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCloseRequestedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCloseRequestedAt = vCloseRequestedAt.ToValue();
                    if (valueCloseRequestedAt is ulong vCloseRequestedAtValue) { ret.CloseRequestedAt = vCloseRequestedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object43Bc5A10);
                }
                public bool Equals(Object43Bc5A10? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object43Bc5A10 left, Object43Bc5A10 right)
                {
                    return EqualityComparer<Object43Bc5A10>.Default.Equals(left, right);
                }
                public static bool operator !=(Object43Bc5A10 left, Object43Bc5A10 right)
                {
                    return !(left == right);
                }

            }

            public class ObjectAacf8510 : AVMObjectType
            {
                public Algorand.Address Receiver { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectAacf8510 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectAacf8510();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is Algorand.Address vReceiverValue) { ret.Receiver = vReceiverValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectAacf8510);
                }
                public bool Equals(ObjectAacf8510? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectAacf8510 left, ObjectAacf8510 right)
                {
                    return EqualityComparer<ObjectAacf8510>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectAacf8510 left, ObjectAacf8510 right)
                {
                    return !(left == right);
                }

            }

            public class GetSessionStaticDataReturn : AVMObjectType
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

                public static GetSessionStaticDataReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetSessionStaticDataReturn();
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
                    return Equals(obj as GetSessionStaticDataReturn);
                }
                public bool Equals(GetSessionStaticDataReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetSessionStaticDataReturn left, GetSessionStaticDataReturn right)
                {
                    return EqualityComparer<GetSessionStaticDataReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetSessionStaticDataReturn left, GetSessionStaticDataReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetSessionDynamicDataReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public Algorand.Address Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static GetSessionDynamicDataReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetSessionDynamicDataReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetSessionDynamicDataReturn);
                }
                public bool Equals(GetSessionDynamicDataReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetSessionDynamicDataReturn left, GetSessionDynamicDataReturn right)
                {
                    return EqualityComparer<GetSessionDynamicDataReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetSessionDynamicDataReturn left, GetSessionDynamicDataReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Opens a channel with initial USDC deposit and returns derived channelId.
        ///Caller becomes payer.
        ///authorizedSigner is signer pubkey hash (32 bytes) computed client-side. The full
        ///public key is not stored on-chain: it is compiled into the settlement LogicSig,
        ///which performs voucher verification.
        ///</summary>
        /// <param name="payee"> </param>
        /// <param name="deposit"> </param>
        /// <param name="salt"> </param>
        /// <param name="authorizedSigner"> </param>
        public async Task<byte[]> Open(AssetTransferTransaction deposit, Algorand.Address payee, byte[] salt, byte[] authorizedSigner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { deposit });
            byte[] abiHandle = { 17, 99, 197, 19 };
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);

            var result = await base.CallApp(new List<object> { abiHandle, payeeAbi, deposit, saltAbi, authorizedSignerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Open_Transactions(AssetTransferTransaction deposit, Algorand.Address payee, byte[] salt, byte[] authorizedSigner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { deposit });
            byte[] abiHandle = { 17, 99, 197, 19 };
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);

            return await base.MakeTransactionList(new List<object> { abiHandle, payeeAbi, deposit, saltAbi, authorizedSignerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Adds funds to an existing channel using a grouped USDC asset transfer.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="cumulativeAmount"> </param>
        public async Task TopUp(AssetTransferTransaction cumulativeAmount, byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cumulativeAmount });
            byte[] abiHandle = { 189, 207, 172, 88 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, cumulativeAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TopUp_Transactions(AssetTransferTransaction cumulativeAmount, byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cumulativeAmount });
            byte[] abiHandle = { 189, 207, 172, 88 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, cumulativeAmount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Payer-controlled: records a new payer signer by updating channel.authorizedSigner
        ///to sha512_256(authorizedSignerPublicKey). Record only: voucher authority is the
        ///registered settlement LogicSig, so also call setSettlementLogicSig with a LogicSig
        ///compiled for the new key (or revokeSettlementLogicSig) to actually switch signers.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="authorizedSignerPublicKey"> </param>
        public async Task SetAuthorizedPayerSigner(byte[] channelId, byte[] authorizedSignerPublicKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 251, 23, 114 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var authorizedSignerPublicKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerPublicKeyAbi.From(authorizedSignerPublicKey);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, authorizedSignerPublicKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAuthorizedPayerSigner_Transactions(byte[] channelId, byte[] authorizedSignerPublicKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 251, 23, 114 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var authorizedSignerPublicKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerPublicKeyAbi.From(authorizedSignerPublicKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, authorizedSignerPublicKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Payee-controlled: registers a delegate account that may call close on the
        ///payee's behalf (e.g. so a Seed Vault payee can close without a fingerprint).
        ///
        ///- channelId empty  -> ACCOUNT-LEVEL default: applies to every channel (current
        ///  and future) where the sender is the payee, so the payee signs once.
        ///- channelId set    -> CHANNEL-LEVEL: applies to that channel only and overrides
        ///  the account-level default for it. Sender must be that channel's payee.
        ///
        ///The sender pays the box MBR via the grouped payment (required only when first
        ///creating the entry; replacing an existing delegate accepts any amount).
        ///Only the payee account itself (never a delegate) can set, replace, or revoke.
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="payeeSigner"> </param>
        /// <param name="channelId"> </param>
        public async Task SetAuthorizedPayeeSigner(PaymentTransaction mbrPayment, Algorand.Address payeeSigner, byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 253, 92, 169, 225 };
            var payeeSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeSignerAbi.From(payeeSigner);
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, payeeSignerAbi, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAuthorizedPayeeSigner_Transactions(PaymentTransaction mbrPayment, Algorand.Address payeeSigner, byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 253, 92, 169, 225 };
            var payeeSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeSignerAbi.From(payeeSigner);
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, payeeSignerAbi, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Payee-controlled: removes a delegate and refunds its box MBR to the payee.
        ///channelId empty -> removes the account-level default; channelId set -> removes
        ///that channel's override (the channel then falls back to the account-level default).
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task RevokeAuthorizedPayeeSigner(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 137, 167, 248 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeAuthorizedPayeeSigner_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 137, 167, 248 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Registers the channel-specific LogicSig used for Falcon-authorized settlement.
        ///The payer compiles it with this app id, channel id, payee, and the public key
        ///whose sha512_256 hash is stored on the channel.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="logicSig"> </param>
        public async Task SetSettlementLogicSig(byte[] channelId, Algorand.Address logicSig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 217, 117, 166 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var logicSigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); logicSigAbi.From(logicSig);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, logicSigAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSettlementLogicSig_Transactions(byte[] channelId, Algorand.Address logicSig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 217, 117, 166 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var logicSigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); logicSigAbi.From(logicSig);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, logicSigAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency stop: payer immediately revokes the AI agent's settlement authority
        ///(e.g. if the ephemeral Falcon session key is suspected compromised) without
        ///closing the channel or losing the deposit. settleFromLogicSig will fail until
        ///the payer registers a fresh LogicSig via setSettlementLogicSig.
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task RevokeSettlementLogicSig(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 185, 190, 155 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeSettlementLogicSig_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 185, 190, 155 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Settle through the registered LogicSig. Falcon verification occurs in the
        ///LogicSig program; this call binds that authorization to the channel box and
        ///advances its voucher watermark, preventing voucher replay.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="cumulativeAmount"> </param>
        public async Task SettleFromLogicSig(byte[] channelId, ulong cumulativeAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 156, 95, 177 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SettleFromLogicSig_Transactions(byte[] channelId, ulong cumulativeAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 156, 95, 177 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Payee (or the payee's registered authorizedPayeeSigner) closes channel.
        ///Honors the latest on-chain voucher before refunding the payer. Payouts
        ///always go to data.payee, never to the delegate.
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task Close(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 106, 233, 233 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Close_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 106, 233, 233 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Payer requests channel closure, starting forced-close grace period.
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task RequestClose(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 104, 80, 80 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestClose_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 104, 80, 80 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Payer withdraws remaining funds after grace period expires.
        ///Honors the latest on-chain voucher before refunding the payer.
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task Withdraw(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 5, 212, 244 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 5, 212, 244 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Funds MBR/fees pool using ALGO.
        ///</summary>
        /// <param name="payment"> ObjectAACF8510</param>
        public async Task FundMbrPool(Structs.ObjectAacf8510 payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 20, 196, 249 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundMbrPool_Transactions(Structs.ObjectAacf8510 payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 20, 196, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt app account into configured USDC ASA so it can receive deposits.
        ///Should be called once by admin/creator.
        ///</summary>
        public async Task OptInUsdc(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 63, 74, 104 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInUsdc_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 63, 74, 104 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns latest session static data tuple:
        ///[startRound, startTimestamp]
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task<Structs.GetSessionStaticDataReturn> GetSessionStaticData(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 112, 73, 3 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.SimApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetSessionStaticDataReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSessionStaticData_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 112, 73, 3 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns latest session dynamic data tuple:
        ///[totalDeposit, lastSettled, latestVoucherAmount, settlementLogicSig]
        ///settlementLogicSig is the zero address (Account()) if none is currently
        ///registered (never set, or revoked via revokeSettlementLogicSig) — callers
        ///can use that to detect when setSettlementLogicSig needs to be (re)called.
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task<Structs.GetSessionDynamicDataReturn> GetSessionDynamicData(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 222, 159, 182 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.SimApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetSessionDynamicDataReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSessionDynamicData_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 222, 159, 182 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns a delegated close signer, or the zero address if none applies.
        ///channelId empty -> the payee account's account-level default.
        ///channelId set   -> the signer effective for that channel (channel-level override
        ///                   if set, otherwise the channel payee's account-level default);
        ///                   the payee argument is ignored in this case.
        ///</summary>
        /// <param name="payee"> </param>
        /// <param name="channelId"> </param>
        public async Task<Algorand.Address> GetAuthorizedPayeeSigner(Algorand.Address payee, byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 143, 117, 130 };
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.SimApp(new List<object> { abiHandle, payeeAbi, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAuthorizedPayeeSigner_Transactions(Algorand.Address payee, byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 143, 117, 130 };
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, payeeAbi, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only helper for clients: deterministic channelId derivation.
        ///authorizedSigner must be signer pubkey hash (32 bytes).
        ///</summary>
        /// <param name="payer"> </param>
        /// <param name="payee"> </param>
        /// <param name="authorizedSigner"> </param>
        /// <param name="salt"> </param>
        public async Task<byte[]> DeriveChannelId(Algorand.Address payer, Algorand.Address payee, byte[] authorizedSigner, byte[] salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 246, 9, 224 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);

            var result = await base.SimApp(new List<object> { abiHandle, payerAbi, payeeAbi, authorizedSignerAbi, saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> DeriveChannelId_Transactions(Algorand.Address payer, Algorand.Address payee, byte[] authorizedSigner, byte[] salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 246, 9, 224 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);

            return await base.MakeTransactionList(new List<object> { abiHandle, payerAbi, payeeAbi, authorizedSignerAbi, saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93U2Vzc2lvblZhdWx0SHlicmlkTWFuYWdlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3Q0M0JDNUExMCI6W3sibmFtZSI6InBheWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXllZSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJ0b3RhbERlcG9zaXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFNldHRsZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGF0ZXN0Vm91Y2hlckFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFydFJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXJ0VGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNsb3NlUmVxdWVzdGVkQXQiLCJ0eXBlIjoidWludDY0In1dLCJPYmplY3RBQUNGODUxMCI6W3sibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6ImFkZHJlc3MifV0sIkdldFNlc3Npb25TdGF0aWNEYXRhUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldFNlc3Npb25EeW5hbWljRGF0YVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wZW4iLCJkZXNjIjoiT3BlbnMgYSBjaGFubmVsIHdpdGggaW5pdGlhbCBVU0RDIGRlcG9zaXQgYW5kIHJldHVybnMgZGVyaXZlZCBjaGFubmVsSWQuXG5DYWxsZXIgYmVjb21lcyBwYXllci5cbmF1dGhvcml6ZWRTaWduZXIgaXMgc2lnbmVyIHB1YmtleSBoYXNoICgzMiBieXRlcykgY29tcHV0ZWQgY2xpZW50LXNpZGUuIFRoZSBmdWxsXG5wdWJsaWMga2V5IGlzIG5vdCBzdG9yZWQgb24tY2hhaW46IGl0IGlzIGNvbXBpbGVkIGludG8gdGhlIHNldHRsZW1lbnQgTG9naWNTaWcsXG53aGljaCBwZXJmb3JtcyB2b3VjaGVyIHZlcmlmaWNhdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvcml6ZWRTaWduZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3BVcCIsImRlc2MiOiJBZGRzIGZ1bmRzIHRvIGFuIGV4aXN0aW5nIGNoYW5uZWwgdXNpbmcgYSBncm91cGVkIFVTREMgYXNzZXQgdHJhbnNmZXIuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdW11bGF0aXZlQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEF1dGhvcml6ZWRQYXllclNpZ25lciIsImRlc2MiOiJQYXllci1jb250cm9sbGVkOiByZWNvcmRzIGEgbmV3IHBheWVyIHNpZ25lciBieSB1cGRhdGluZyBjaGFubmVsLmF1dGhvcml6ZWRTaWduZXJcbnRvIHNoYTUxMl8yNTYoYXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSkuIFJlY29yZCBvbmx5OiB2b3VjaGVyIGF1dGhvcml0eSBpcyB0aGVcbnJlZ2lzdGVyZWQgc2V0dGxlbWVudCBMb2dpY1NpZywgc28gYWxzbyBjYWxsIHNldFNldHRsZW1lbnRMb2dpY1NpZyB3aXRoIGEgTG9naWNTaWdcbmNvbXBpbGVkIGZvciB0aGUgbmV3IGtleSAob3IgcmV2b2tlU2V0dGxlbWVudExvZ2ljU2lnKSB0byBhY3R1YWxseSBzd2l0Y2ggc2lnbmVycy4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyUHVibGljS2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEF1dGhvcml6ZWRQYXllZVNpZ25lciIsImRlc2MiOiJQYXllZS1jb250cm9sbGVkOiByZWdpc3RlcnMgYSBkZWxlZ2F0ZSBhY2NvdW50IHRoYXQgbWF5IGNhbGwgY2xvc2Ugb24gdGhlXG5wYXllZSdzIGJlaGFsZiAoZS5nLiBzbyBhIFNlZWQgVmF1bHQgcGF5ZWUgY2FuIGNsb3NlIHdpdGhvdXQgYSBmaW5nZXJwcmludCkuXG5cbi0gY2hhbm5lbElkIGVtcHR5ICAtPiBBQ0NPVU5ULUxFVkVMIGRlZmF1bHQ6IGFwcGxpZXMgdG8gZXZlcnkgY2hhbm5lbCAoY3VycmVudFxuICBhbmQgZnV0dXJlKSB3aGVyZSB0aGUgc2VuZGVyIGlzIHRoZSBwYXllZSwgc28gdGhlIHBheWVlIHNpZ25zIG9uY2UuXG4tIGNoYW5uZWxJZCBzZXQgICAgLT4gQ0hBTk5FTC1MRVZFTDogYXBwbGllcyB0byB0aGF0IGNoYW5uZWwgb25seSBhbmQgb3ZlcnJpZGVzXG4gIHRoZSBhY2NvdW50LWxldmVsIGRlZmF1bHQgZm9yIGl0LiBTZW5kZXIgbXVzdCBiZSB0aGF0IGNoYW5uZWwncyBwYXllZS5cblxuVGhlIHNlbmRlciBwYXlzIHRoZSBib3ggTUJSIHZpYSB0aGUgZ3JvdXBlZCBwYXltZW50IChyZXF1aXJlZCBvbmx5IHdoZW4gZmlyc3RcbmNyZWF0aW5nIHRoZSBlbnRyeTsgcmVwbGFjaW5nIGFuIGV4aXN0aW5nIGRlbGVnYXRlIGFjY2VwdHMgYW55IGFtb3VudCkuXG5Pbmx5IHRoZSBwYXllZSBhY2NvdW50IGl0c2VsZiAobmV2ZXIgYSBkZWxlZ2F0ZSkgY2FuIHNldCwgcmVwbGFjZSwgb3IgcmV2b2tlLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWVTaWduZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VBdXRob3JpemVkUGF5ZWVTaWduZXIiLCJkZXNjIjoiUGF5ZWUtY29udHJvbGxlZDogcmVtb3ZlcyBhIGRlbGVnYXRlIGFuZCByZWZ1bmRzIGl0cyBib3ggTUJSIHRvIHRoZSBwYXllZS5cbmNoYW5uZWxJZCBlbXB0eSAtPiByZW1vdmVzIHRoZSBhY2NvdW50LWxldmVsIGRlZmF1bHQ7IGNoYW5uZWxJZCBzZXQgLT4gcmVtb3Zlc1xudGhhdCBjaGFubmVsJ3Mgb3ZlcnJpZGUgKHRoZSBjaGFubmVsIHRoZW4gZmFsbHMgYmFjayB0byB0aGUgYWNjb3VudC1sZXZlbCBkZWZhdWx0KS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFNldHRsZW1lbnRMb2dpY1NpZyIsImRlc2MiOiJSZWdpc3RlcnMgdGhlIGNoYW5uZWwtc3BlY2lmaWMgTG9naWNTaWcgdXNlZCBmb3IgRmFsY29uLWF1dGhvcml6ZWQgc2V0dGxlbWVudC5cblRoZSBwYXllciBjb21waWxlcyBpdCB3aXRoIHRoaXMgYXBwIGlkLCBjaGFubmVsIGlkLCBwYXllZSwgYW5kIHRoZSBwdWJsaWMga2V5XG53aG9zZSBzaGE1MTJfMjU2IGhhc2ggaXMgc3RvcmVkIG9uIHRoZSBjaGFubmVsLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2dpY1NpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VTZXR0bGVtZW50TG9naWNTaWciLCJkZXNjIjoiRW1lcmdlbmN5IHN0b3A6IHBheWVyIGltbWVkaWF0ZWx5IHJldm9rZXMgdGhlIEFJIGFnZW50J3Mgc2V0dGxlbWVudCBhdXRob3JpdHlcbihlLmcuIGlmIHRoZSBlcGhlbWVyYWwgRmFsY29uIHNlc3Npb24ga2V5IGlzIHN1c3BlY3RlZCBjb21wcm9taXNlZCkgd2l0aG91dFxuY2xvc2luZyB0aGUgY2hhbm5lbCBvciBsb3NpbmcgdGhlIGRlcG9zaXQuIHNldHRsZUZyb21Mb2dpY1NpZyB3aWxsIGZhaWwgdW50aWxcbnRoZSBwYXllciByZWdpc3RlcnMgYSBmcmVzaCBMb2dpY1NpZyB2aWEgc2V0U2V0dGxlbWVudExvZ2ljU2lnLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlRnJvbUxvZ2ljU2lnIiwiZGVzYyI6IlNldHRsZSB0aHJvdWdoIHRoZSByZWdpc3RlcmVkIExvZ2ljU2lnLiBGYWxjb24gdmVyaWZpY2F0aW9uIG9jY3VycyBpbiB0aGVcbkxvZ2ljU2lnIHByb2dyYW07IHRoaXMgY2FsbCBiaW5kcyB0aGF0IGF1dGhvcml6YXRpb24gdG8gdGhlIGNoYW5uZWwgYm94IGFuZFxuYWR2YW5jZXMgaXRzIHZvdWNoZXIgd2F0ZXJtYXJrLCBwcmV2ZW50aW5nIHZvdWNoZXIgcmVwbGF5LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1bXVsYXRpdmVBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2UiLCJkZXNjIjoiUGF5ZWUgKG9yIHRoZSBwYXllZSdzIHJlZ2lzdGVyZWQgYXV0aG9yaXplZFBheWVlU2lnbmVyKSBjbG9zZXMgY2hhbm5lbC5cbkhvbm9ycyB0aGUgbGF0ZXN0IG9uLWNoYWluIHZvdWNoZXIgYmVmb3JlIHJlZnVuZGluZyB0aGUgcGF5ZXIuIFBheW91dHNcbmFsd2F5cyBnbyB0byBkYXRhLnBheWVlLCBuZXZlciB0byB0aGUgZGVsZWdhdGUuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXF1ZXN0Q2xvc2UiLCJkZXNjIjoiUGF5ZXIgcmVxdWVzdHMgY2hhbm5lbCBjbG9zdXJlLCBzdGFydGluZyBmb3JjZWQtY2xvc2UgZ3JhY2UgcGVyaW9kLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiUGF5ZXIgd2l0aGRyYXdzIHJlbWFpbmluZyBmdW5kcyBhZnRlciBncmFjZSBwZXJpb2QgZXhwaXJlcy5cbkhvbm9ycyB0aGUgbGF0ZXN0IG9uLWNoYWluIHZvdWNoZXIgYmVmb3JlIHJlZnVuZGluZyB0aGUgcGF5ZXIuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kTWJyUG9vbCIsImRlc2MiOiJGdW5kcyBNQlIvZmVlcyBwb29sIHVzaW5nIEFMR08uIiwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzKSIsInN0cnVjdCI6Ik9iamVjdEFBQ0Y4NTEwIiwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Vc2RjIiwiZGVzYyI6Ik9wdCBhcHAgYWNjb3VudCBpbnRvIGNvbmZpZ3VyZWQgVVNEQyBBU0Egc28gaXQgY2FuIHJlY2VpdmUgZGVwb3NpdHMuXG5TaG91bGQgYmUgY2FsbGVkIG9uY2UgYnkgYWRtaW4vY3JlYXRvci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2Vzc2lvblN0YXRpY0RhdGEiLCJkZXNjIjoiUmV0dXJucyBsYXRlc3Qgc2Vzc2lvbiBzdGF0aWMgZGF0YSB0dXBsZTpcbltzdGFydFJvdW5kLCBzdGFydFRpbWVzdGFtcF0iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFNlc3Npb25TdGF0aWNEYXRhUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTZXNzaW9uRHluYW1pY0RhdGEiLCJkZXNjIjoiUmV0dXJucyBsYXRlc3Qgc2Vzc2lvbiBkeW5hbWljIGRhdGEgdHVwbGU6XG5bdG90YWxEZXBvc2l0LCBsYXN0U2V0dGxlZCwgbGF0ZXN0Vm91Y2hlckFtb3VudCwgc2V0dGxlbWVudExvZ2ljU2lnXVxuc2V0dGxlbWVudExvZ2ljU2lnIGlzIHRoZSB6ZXJvIGFkZHJlc3MgKEFjY291bnQoKSkgaWYgbm9uZSBpcyBjdXJyZW50bHlcbnJlZ2lzdGVyZWQgKG5ldmVyIHNldCwgb3IgcmV2b2tlZCB2aWEgcmV2b2tlU2V0dGxlbWVudExvZ2ljU2lnKSDigJQgY2FsbGVyc1xuY2FuIHVzZSB0aGF0IHRvIGRldGVjdCB3aGVuIHNldFNldHRsZW1lbnRMb2dpY1NpZyBuZWVkcyB0byBiZSAocmUpY2FsbGVkLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGFkZHJlc3MpIiwic3RydWN0IjoiR2V0U2Vzc2lvbkR5bmFtaWNEYXRhUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBdXRob3JpemVkUGF5ZWVTaWduZXIiLCJkZXNjIjoiUmV0dXJucyBhIGRlbGVnYXRlZCBjbG9zZSBzaWduZXIsIG9yIHRoZSB6ZXJvIGFkZHJlc3MgaWYgbm9uZSBhcHBsaWVzLlxuY2hhbm5lbElkIGVtcHR5IC0+IHRoZSBwYXllZSBhY2NvdW50J3MgYWNjb3VudC1sZXZlbCBkZWZhdWx0LlxuY2hhbm5lbElkIHNldCAgIC0+IHRoZSBzaWduZXIgZWZmZWN0aXZlIGZvciB0aGF0IGNoYW5uZWwgKGNoYW5uZWwtbGV2ZWwgb3ZlcnJpZGVcbiAgICAgICAgICAgICAgICAgICBpZiBzZXQsIG90aGVyd2lzZSB0aGUgY2hhbm5lbCBwYXllZSdzIGFjY291bnQtbGV2ZWwgZGVmYXVsdCk7XG4gICAgICAgICAgICAgICAgICAgdGhlIHBheWVlIGFyZ3VtZW50IGlzIGlnbm9yZWQgaW4gdGhpcyBjYXNlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcml2ZUNoYW5uZWxJZCIsImRlc2MiOiJSZWFkLW9ubHkgaGVscGVyIGZvciBjbGllbnRzOiBkZXRlcm1pbmlzdGljIGNoYW5uZWxJZCBkZXJpdmF0aW9uLlxuYXV0aG9yaXplZFNpZ25lciBtdXN0IGJlIHNpZ25lciBwdWJrZXkgaGFzaCAoMzIgYnl0ZXMpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTUwXSwiZXJyb3JNZXNzYWdlIjoiQXNzZXQgY2xvc2Ugbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDZdLCJlcnJvck1lc3NhZ2UiOiJBdXRob3JpemVkIHNpZ25lciBoYXNoIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcyXSwiZXJyb3JNZXNzYWdlIjoiQXV0aG9yaXplZCBzaWduZXIgcHVia2V5IHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA5LDEyNjgsMTMzOSwxNDczLDE0OTNdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkyLDQ1NCw3NDMsNzg2LDg0NCw5NjUsMTAzNywxMDc2LDExODAsMTIyNiwxMzU2LDE0NDRdLCJlcnJvck1lc3NhZ2UiOiJDaGFubmVsIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA4XSwiZXJyb3JNZXNzYWdlIjoiQ2hhbm5lbCBwYXllZSBzaWduZXIgbm90IHNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDJdLCJlcnJvck1lc3NhZ2UiOiJDbGF3YmFjayB0cmFuc2ZlciBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDddLCJlcnJvck1lc3NhZ2UiOiJDbG9zZSBncmFjZSBwZXJpb2Qgbm90IGVsYXBzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk4XSwiZXJyb3JNZXNzYWdlIjoiQ2xvc2Ugbm90IHJlcXVlc3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3NF0sImVycm9yTWVzc2FnZSI6IkNsb3NlIHJlbWFpbmRlciBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzRdLCJlcnJvck1lc3NhZ2UiOiJEZXBvc2l0IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA1LDYzN10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBNQlIgcGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1N10sImVycm9yTWVzc2FnZSI6IkxvZ2ljU2lnIGFjY291bnQgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjddLCJlcnJvck1lc3NhZ2UiOiJNQlIgcGF5bWVudCBtdXN0IGJlIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYwXSwiZXJyb3JNZXNzYWdlIjoiTUJSIHBheW1lbnQgc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc3XSwiZXJyb3JNZXNzYWdlIjoiTm90aGluZyBuZXcgdG8gc2V0dGxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIG9wdCBpbiBVU0RDIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ1M10sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZWUgY2FuIG1hbmFnZSBwYXllZSBzaWduZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDAyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllZSBvciBwYXllZSBzaWduZXIgY2FuIGNsb3NlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllciBjYW4gcmVvcGVuIGNoYW5uZWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQ2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllciBjYW4gcmVxdWVzdCBjbG9zZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHJldm9rZSBMb2dpY1NpZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1Ml0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHNldCBMb2dpY1NpZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHNldCBhdXRob3JpemVkIHNpZ25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHRvcCB1cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVyIGNhbiB3aXRoZHJhdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2Nl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgc2V0dGxlbWVudCBMb2dpY1NpZyBjYW4gc2V0dGxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI3XSwiZXJyb3JNZXNzYWdlIjoiUGF5ZWUgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDldLCJlcnJvck1lc3NhZ2UiOiJQYXllZSBzaWduZXIgYWNjb3VudCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1M10sImVycm9yTWVzc2FnZSI6IlBheWVlIHNpZ25lciBtdXN0IGRpZmZlciBmcm9tIHBheWVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc1XSwiZXJyb3JNZXNzYWdlIjoiUGF5ZWUgc2lnbmVyIG5vdCBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTI4XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBhc3NldCBtdXN0IGJlIFVTREMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTI5LDE1MjBdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTEyXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODBdLCJlcnJvck1lc3NhZ2UiOiJSZWtleSBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMyw4NTldLCJlcnJvck1lc3NhZ2UiOiJTZXR0bGVtZW50IExvZ2ljU2lnIG5vdCBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTNdLCJlcnJvck1lc3NhZ2UiOiJTaWduZXIgaGFzaCBtdXN0IGJlIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg5XSwiZXJyb3JNZXNzYWdlIjoiVm91Y2hlciBleGNlZWRzIGRlcG9zaXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYsMTkyLDM2NSw0MjIsNDM4LDUyOSw2NTEsNzE5LDc3MSw4MTMsOTQ5LDEwMjIsMTA2MSwxMTY1LDEyMTEsMTMwNywxMzg4LDE0MDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTIyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE9iamVjdEFBQ0Y4NTEwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgzLDE5OSwzNzIsNDI5LDQ0NSw1MzYsNjU4LDcyNiw3NzgsODIwLDk1NiwxMDI5LDEwNjgsMTE3MiwxMjE4LDEzMTQsMTM5NSwxNDExXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1Nyw1MjMsNzM3LDEzMDEsMTM3NCwxMzgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MCwzODZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTEyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJjYmxvY2tzIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURJZ1ZFMVFURjlWVTBSRFgwRlRVMFZVWDBsRUlESTROVEF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pzSWlBaVpDSWdJbVVpSURCNE1UVXhaamRqTnpVZ01IZ3hOVEZtTjJNM05UQXdNakFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwU0hsaWNtbGtUV0Z1WVdkbGNpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneE1UWXpZelV4TXlBd2VHSmtZMlpoWXpVNElEQjRNMlJtWWpFM056SWdNSGhtWkRWallUbGxNU0F3ZUdGbE9EbGhOMlk0SURCNE5ESmtPVGMxWVRZZ01IZ3lNR0k1WW1VNVlpQXdlRFF6T1dNMVptSXhJREI0WlRnMllXVTVaVGtnTUhnek5EWTROVEExTUNBd2VEVTVNRFZrTkdZMElEQjRZV0V4TkdNMFpqa2dNSGczWlRObU5HRTJPQ0F3ZUdFNE56QTBPVEF6SURCNFkyTmtaVGxtWWpZZ01IZzRZVGhtTnpVNE1pQXdlREppWmpZd09XVXdJQzh2SUcxbGRHaHZaQ0FpYjNCbGJpaGhaR1J5WlhOekxHRjRabVZ5TEdKNWRHVmJYU3hpZVhSbFcxMHBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSjBiM0JWY0NoaWVYUmxXMTBzWVhobVpYSXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBRWFYwYUc5eWFYcGxaRkJoZVdWeVUybG5ibVZ5S0dKNWRHVmJYU3hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBRWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5S0hCaGVTeGhaR1J5WlhOekxHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhadmEyVkJkWFJvYjNKcGVtVmtVR0Y1WldWVGFXZHVaWElvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRk5sZEhSc1pXMWxiblJNYjJkcFkxTnBaeWhpZVhSbFcxMHNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYWnZhMlZUWlhSMGJHVnRaVzUwVEc5bmFXTlRhV2NvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkSFJzWlVaeWIyMU1iMmRwWTFOcFp5aGllWFJsVzEwc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5zYjNObEtHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhGMVpYTjBRMnh2YzJVb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbWRXNWtUV0p5VUc5dmJDZ29ZV1JrY21WemN5a3BkbTlwWkNJc0lHMWxkR2h2WkNBaWIzQjBTVzVWYzJSaktDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUlRaWE56YVc5dVUzUmhkR2xqUkdGMFlTaGllWFJsVzEwcEtIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUlRaWE56YVc5dVJIbHVZVzFwWTBSaGRHRW9ZbmwwWlZ0ZEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLU0lzSUcxbGRHaHZaQ0FpWjJWMFFYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlLR0ZrWkhKbGMzTXNZbmwwWlZ0ZEtXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltUmxjbWwyWlVOb1lXNXVaV3hKWkNoaFpHUnlaWE56TEdGa1pISmxjM01zWW5sMFpWdGRMR0o1ZEdWYlhTbGllWFJsVzEwaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnZjR1Z1SUhSdmNGVndJSE5sZEVGMWRHaHZjbWw2WldSUVlYbGxjbE5wWjI1bGNpQnpaWFJCZFhSb2IzSnBlbVZrVUdGNVpXVlRhV2R1WlhJZ2NtVjJiMnRsUVhWMGFHOXlhWHBsWkZCaGVXVmxVMmxuYm1WeUlITmxkRk5sZEhSc1pXMWxiblJNYjJkcFkxTnBaeUJ5WlhadmEyVlRaWFIwYkdWdFpXNTBURzluYVdOVGFXY2djMlYwZEd4bFJuSnZiVXh2WjJsalUybG5JR05zYjNObElISmxjWFZsYzNSRGJHOXpaU0IzYVhSb1pISmhkeUJtZFc1a1RXSnlVRzl2YkNCdmNIUkpibFZ6WkdNZ1oyVjBVMlZ6YzJsdmJsTjBZWFJwWTBSaGRHRWdaMlYwVTJWemMybHZia1I1Ym1GdGFXTkVZWFJoSUdkbGRFRjFkR2h2Y21sNlpXUlFZWGxsWlZOcFoyNWxjaUJrWlhKcGRtVkRhR0Z1Ym1Wc1NXUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTWpRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWElnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbTl3Wlc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZjR1Z1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREV0T0RZS0lDQWdJQzh2SUc5d1pXNG9DaUFnSUNBdkx5QWdJSEJoZVdWbE9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmtaWEJ2YzJsME9pQm5kSGh1TGtGemMyVjBWSEpoYm5ObVpYSlVlRzRzQ2lBZ0lDQXZMeUFnSUhOaGJIUTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeU9pQmllWFJsY3l3S0lDQWdJQzh2SUNrNklHSjVkR1Z6SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhlR1psY2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNpNXNaVzVuZEdnZ1BUMDlJRE15TENBblUybG5ibVZ5SUdoaGMyZ2diWFZ6ZENCaVpTQXpNaUJpZVhSbGN5Y3BDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVTJsbmJtVnlJR2hoYzJnZ2JYVnpkQ0JpWlNBek1pQmllWFJsY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGtLSUNBZ0lDOHZJR052Ym5OMElHTm9ZVzV1Wld4SlpDQTlJSFJvYVhNdVpHVnlhWFpsUTJoaGJtNWxiRWxrS0ZSNGJpNXpaVzVrWlhJc0lIQmhlV1ZsTENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5TENCellXeDBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprMUNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdWMyaGhNalUyS0hCaGVXVnlMbUo1ZEdWekxtTnZibU5oZENod1lYbGxaUzVpZVhSbGN5a3VZMjl1WTJGMEtHOXdMbWwwYjJJb1ZWTkVRMTlCVTFORlZGOUpSQ2twTG1OdmJtTmhkQ2h6WVd4MEtTNWpiMjVqWVhRb1lYVjBhRzl5YVhwbFpGTnBaMjVsY2lrcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWTkVRMTlCVTFORlZGOUpSQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUdsbUlDZ2hZMmhoYm01bGJDNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUc5d1pXNWZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURBS0lDQWdJQzh2SUhOMFlYSjBVbTkxYm1RNklHOXdMa2RzYjJKaGJDNXliM1Z1WkN3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUJ6ZEdGeWRGUnBiV1Z6ZEdGdGNEb2diM0F1UjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCd1lYbGxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3pMVEV3TXdvZ0lDQWdMeThnWTI5dWMzUWdaR0YwWVRvZ1EyaGhibTVsYkVsdVptOGdQU0I3Q2lBZ0lDQXZMeUFnSUhCaGVXVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCd1lYbGxaU3dLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjaXdLSUNBZ0lDOHZJQ0FnZEc5MFlXeEVaWEJ2YzJsME9pQXdMQW9nSUNBZ0x5OGdJQ0JzWVhOMFUyVjBkR3hsWkRvZ01Dd0tJQ0FnSUM4dklDQWdiR0YwWlhOMFZtOTFZMmhsY2tGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2MzUmhjblJTYjNWdVpEb2diM0F1UjJ4dlltRnNMbkp2ZFc1a0xBb2dJQ0FnTHk4Z0lDQnpkR0Z5ZEZScGJXVnpkR0Z0Y0RvZ2IzQXVSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0N3S0lDQWdJQzh2SUNBZ1kyeHZjMlZTWlhGMVpYTjBaV1JCZERvZ01Dd0tJQ0FnSUM4dklIMEtJQ0FnSUdScFp5QTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOeklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJSFJ2ZEdGc1JHVndiM05wZERvZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TXkweE1ETUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRTZJRU5vWVc1dVpXeEpibVp2SUQwZ2V3b2dJQ0FnTHk4Z0lDQndZWGxsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRjFkR2h2Y21sNlpXUlRhV2R1WlhJc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzUkdWd2IzTnBkRG9nTUN3S0lDQWdJQzh2SUNBZ2JHRnpkRk5sZEhSc1pXUTZJREFzQ2lBZ0lDQXZMeUFnSUd4aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJSE4wWVhKMFVtOTFibVE2SUc5d0xrZHNiMkpoYkM1eWIzVnVaQ3dLSUNBZ0lDOHZJQ0FnYzNSaGNuUlVhVzFsYzNSaGJYQTZJRzl3TGtkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QWdJR05zYjNObFVtVnhkV1Z6ZEdWa1FYUTZJREFzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFFLSUNBZ0lDOHZJSFJvYVhNdVlYQndiSGxVYjNCVmNDaGtZWFJoTENCa1pYQnZjMmwwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmhjSEJzZVZSdmNGVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklHTm9ZVzV1Wld3dWRtRnNkV1VnUFNCamJHOXVaU2hrWVhSaEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2dwdmNHVnVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEVoNVluSnBaRTFoYm1GblpYSXViM0JsYmtBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RFdE9EWUtJQ0FnSUM4dklHOXdaVzRvQ2lBZ0lDQXZMeUFnSUhCaGVXVmxPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0JrWlhCdmMybDBPaUJuZEhodUxrRnpjMlYwVkhKaGJuTm1aWEpVZUc0c0NpQWdJQ0F2THlBZ0lITmhiSFE2SUdKNWRHVnpMQW9nSUNBZ0x5OGdJQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlPaUJpZVhSbGN5d0tJQ0FnSUM4dklDazZJR0o1ZEdWeklIc0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05UQXdNakFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2IzQmxibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Ea0tJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnlaVzl3Wlc0Z1kyaGhibTVsYkNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGt0TVRFd0NpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2NtVnZjR1Z1SUdOb1lXNXVaV3duS1FvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnY21WdmNHVnVJR05vWVc1dVpXd25LUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJoZVdWeUlHTmhiaUJ5Wlc5d1pXNGdZMmhoYm01bGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeENpQWdJQ0F2THlCaGMzTmxjblFvY0dGNVpXVWdQVDA5SUdSaGRHRXVjR0Y1WldVc0lDZFFZWGxsWlNCdGFYTnRZWFJqYUNjcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTndvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGxsWlNCdGFYTnRZWFJqYUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV5Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNpQTlQVDBnWkdGMFlTNWhkWFJvYjNKcGVtVmtVMmxuYm1WeUxDQW5RWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSWdhR0Z6YUNCdGFYTnRZWFJqYUNjcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOalFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJkWFJvYjNKcGVtVmtJSE5wWjI1bGNpQm9ZWE5vSUcxcGMyMWhkR05vQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJSFJvYVhNdVlYQndiSGxVYjNCVmNDaGtZWFJoTENCa1pYQnZjMmwwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUdGd2NHeDVWRzl3VlhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TlFvZ0lDQWdMeThnWTJoaGJtNWxiQzUyWVd4MVpTQTlJR05zYjI1bEtHUmhkR0VwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1TMDROZ29nSUNBZ0x5OGdiM0JsYmlnS0lDQWdJQzh2SUNBZ2NHRjVaV1U2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdSbGNHOXphWFE2SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpd0tJQ0FnSUM4dklDQWdjMkZzZERvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFnSUdGMWRHaHZjbWw2WldSVGFXZHVaWEk2SUdKNWRHVnpMQW9nSUNBZ0x5OGdLVG9nWW5sMFpYTWdld29nSUNBZ1lpQnZjR1Z1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1YjNCbGJrQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEVoNVluSnBaRTFoYm1GblpYSXVkRzl3VlhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBiM0JWY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TXdvZ0lDQWdMeThnZEc5d1ZYQW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2daM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTFDaUFnSUNBdkx5QmhjM05sY25Rb1kyaGhibTVsYkM1bGVHbHpkSE1zSUNkRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJNENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSFJ2Y0NCMWNDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpjdE1USTRDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdkRzl3SUhWd0p5a0tJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIUnZjQ0IxY0NjcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NHRjVaWElnWTJGdUlIUnZjQ0IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE13Q2lBZ0lDQXZMeUIwYUdsekxtRndjR3g1Vkc5d1ZYQW9aR0YwWVN3Z1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZENrS0lDQWdJR05oYkd4emRXSWdZWEJ3YkhsVWIzQlZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QmphR0Z1Ym1Wc0xuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TXdvZ0lDQWdMeThnZEc5d1ZYQW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2daM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1YzJWMFFYVjBhRzl5YVhwbFpGQmhlV1Z5VTJsbmJtVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFFYVjBhRzl5YVhwbFpGQmhlV1Z5VTJsbmJtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5QnpaWFJCZFhSb2IzSnBlbVZrVUdGNVpYSlRhV2R1WlhJb1kyaGhibTVsYkVsa09pQmllWFJsY3l3Z1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXlDaUFnSUNBdkx5QmhjM05sY25Rb1kyaGhibTVsYkM1bGVHbHpkSE1zSUNkRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EUUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTFDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsY2l3Z0owOXViSGtnY0dGNVpYSWdZMkZ1SUhObGRDQmhkWFJvYjNKcGVtVmtJSE5wWjI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRRdE1UUTFDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdjMlYwSUdGMWRHaHZjbWw2WldRZ2MybG5ibVZ5SnlrS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTFDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsY2l3Z0owOXViSGtnY0dGNVpYSWdZMkZ1SUhObGRDQmhkWFJvYjNKcGVtVmtJSE5wWjI1bGNpY3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djR0Y1WlhJZ1kyRnVJSE5sZENCaGRYUm9iM0pwZW1Wa0lITnBaMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTNXNaVzVuZEdnZ1BpQXdMQ0FuUVhWMGFHOXlhWHBsWkNCemFXZHVaWElnY0hWaWEyVjVJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1FYVjBhRzl5YVhwbFpDQnphV2R1WlhJZ2NIVmlhMlY1SUhKbGNYVnBjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJR1JoZEdFdVlYVjBhRzl5YVhwbFpGTnBaMjVsY2lBOUlITm9ZVFV4TWw4eU5UWW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTa0tJQ0FnSUhOb1lUVXhNbDh5TlRZS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01qQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ05qUWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBPUW9nSUNBZ0x5OGdZMmhoYm01bGJDNTJZV3gxWlNBOUlHTnNiMjVsS0dSaGRHRXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRBS0lDQWdJQzh2SUhObGRFRjFkR2h2Y21sNlpXUlFZWGxsY2xOcFoyNWxjaWhqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUk5ZVzVoWjJWeUxuTmxkRUYxZEdodmNtbDZaV1JRWVhsbFpWTnBaMjVsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRUYxZEdodmNtbDZaV1JRWVhsbFpWTnBaMjVsY2pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOUW9nSUNBZ0x5OGdjMlYwUVhWMGFHOXlhWHBsWkZCaGVXVmxVMmxuYm1WeUtHMWljbEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2djR0Y1WldWVGFXZHVaWEk2SUVGalkyOTFiblFzSUdOb1lXNXVaV3hKWkRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOZ29nSUNBZ0x5OGdZWE56WlhKMEtIQmhlV1ZsVTJsbmJtVnlJQ0U5UFNCQlkyTnZkVzUwS0Nrc0lDZFFZWGxsWlNCemFXZHVaWElnWVdOamIzVnVkQ0J5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsbFpTQnphV2R1WlhJZ1lXTmpiM1Z1ZENCeVpYRjFhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1WldWVGFXZHVaWElnSVQwOUlGUjRiaTV6Wlc1a1pYSXNJQ2RRWVhsbFpTQnphV2R1WlhJZ2JYVnpkQ0JrYVdabVpYSWdabkp2YlNCd1lYbGxaU2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXVmxJSE5wWjI1bGNpQnRkWE4wSUdScFptWmxjaUJtY205dElIQmhlV1ZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbk5sYm1SbGNpQTlQVDBnVkhodUxuTmxibVJsY2l3Z0owMUNVaUJ3WVhsdFpXNTBJSE5sYm1SbGNpQnRhWE50WVhSamFDY3BDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5RbElnY0dGNWJXVnVkQ0J6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaWNsQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMDlJRzl3TGtkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0FuVFVKU0lIQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QmpiMjUwY21GamRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTlFsSWdjR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR052Ym5SeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56QUtJQ0FnSUM4dklHRnpjMlZ5ZENodFluSlFZWGx0Wlc1MExtTnNiM05sVW1WdFlXbHVaR1Z5Vkc4Z1BUMDlJRUZqWTI5MWJuUW9LU3dnSjBOc2IzTmxJSEpsYldGcGJtUmxjaUJ1YjNRZ1lXeHNiM2RsWkNjcENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFTnNiM05sVW1WdFlXbHVaR1Z5Vkc4S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRGJHOXpaU0J5WlcxaGFXNWtaWElnYm05MElHRnNiRzkzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTVFvZ0lDQWdMeThnWVhOelpYSjBLRzFpY2xCaGVXMWxiblF1Y21WclpYbFVieUE5UFQwZ1FXTmpiM1Z1ZENncExDQW5VbVZyWlhrZ2JtOTBJR0ZzYkc5M1pXUW5LUW9nSUNBZ1ozUjRibk1nVW1WclpYbFVid29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkpsYTJWNUlHNXZkQ0JoYkd4dmQyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklHbG1JQ2hqYUdGdWJtVnNTV1F1YkdWdVozUm9JRDA5UFNBd0tTQjdDaUFnSUNCc1pXNEtJQ0FnSUdKdWVpQnpaWFJCZFhSb2IzSnBlbVZrVUdGNVpXVlRhV2R1WlhKZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVGalkyOTFiblErS0hzZ2EyVjVVSEpsWm1sNE9pQW5aQ2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUdOdmJuTjBJR1Z1ZEhKNUlEMGdkR2hwY3k1aGRYUm9iM0pwZW1Wa1VHRjVaV1ZUYVdkdVpYSW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCaGRYUm9iM0pwZW1Wa1VHRjVaV1ZUYVdkdVpYSWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRV05qYjNWdWRENG9leUJyWlhsUWNtVm1hWGc2SUNka0p5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMxQ2lBZ0lDQXZMeUJwWmlBb0lXVnVkSEo1TG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2djMlYwUVhWMGFHOXlhWHBsWkZCaGVXVmxVMmxuYm1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJoYzNObGNuUW9iV0p5VUdGNWJXVnVkQzVoYlc5MWJuUWdQajBnVUVGWlJVVmZVMGxIVGtWU1gwSlBXRjlOUWxJc0lDZEpibk4xWm1acFkybGxiblFnVFVKU0lIQmhlVzFsYm5RbktRb2dJQ0FnWkdsbklESUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnYVc1MFl5QTFJQzh2SURJNE5UQXdDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQk5RbElnY0dGNWJXVnVkQW9LYzJWMFFYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM09Bb2dJQ0FnTHk4Z1pXNTBjbmt1ZG1Gc2RXVWdQU0J3WVhsbFpWTnBaMjVsY2dvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZmNIVjBDZ3B6WlhSQmRYUm9iM0pwZW1Wa1VHRjVaV1ZUYVdkdVpYSmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwU0hsaWNtbGtUV0Z1WVdkbGNpNXpaWFJCZFhSb2IzSnBlbVZrVUdGNVpXVlRhV2R1WlhKQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5Rb2dJQ0FnTHk4Z2MyVjBRWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5S0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z2NHRjVaV1ZUYVdkdVpYSTZJRUZqWTI5MWJuUXNJR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEVGMWRHaHZjbWw2WldSUVlYbGxaVk5wWjI1bGNsOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RJS0lDQWdJQzh2SUhSb2FYTXVZWE56WlhKMFUyVnVaR1Z5U1hORGFHRnVibVZzVUdGNVpXVW9ZMmhoYm01bGJFbGtLUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlZ5ZEZObGJtUmxja2x6UTJoaGJtNWxiRkJoZVdWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnWTJoaGJtNWxiRkJoZVdWbFUybG5ibVZ5SUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JCWTJOdmRXNTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0psSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMENpQWdJQ0F2THlCcFppQW9JV1Z1ZEhKNUxtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nYzJWMFFYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCaGMzTmxjblFvYldKeVVHRjViV1Z1ZEM1aGJXOTFiblFnUGowZ1VFRlpSVVZmVTBsSFRrVlNYMEpQV0Y5TlFsSXNJQ2RKYm5OMVptWnBZMmxsYm5RZ1RVSlNJSEJoZVcxbGJuUW5LUW9nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2FXNTBZeUExSUM4dklESTROVEF3Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1ZtWm1samFXVnVkQ0JOUWxJZ2NHRjViV1Z1ZEFvS2MyVjBRWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROd29nSUNBZ0x5OGdaVzUwY25rdWRtRnNkV1VnUFNCd1lYbGxaVk5wWjI1bGNnb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOalVLSUNBZ0lDOHZJSE5sZEVGMWRHaHZjbWw2WldSUVlYbGxaVk5wWjI1bGNpaHRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJSEJoZVdWbFUybG5ibVZ5T2lCQlkyTnZkVzUwTENCamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQmlJSE5sZEVGMWRHaHZjbWw2WldSUVlYbGxaVk5wWjI1bGNsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUk5ZVzVoWjJWeUxuTmxkRUYxZEdodmNtbDZaV1JRWVhsbFpWTnBaMjVsY2tBNENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRWg1WW5KcFpFMWhibUZuWlhJdWNtVjJiMnRsUVhWMGFHOXlhWHBsWkZCaGVXVmxVMmxuYm1WeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVYyYjJ0bFFYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazFDaUFnSUNBdkx5QnlaWFp2YTJWQmRYUm9iM0pwZW1Wa1VHRjVaV1ZUYVdkdVpYSW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazJDaUFnSUNBdkx5QnBaaUFvWTJoaGJtNWxiRWxrTG14bGJtZDBhQ0E5UFQwZ01Da2dld29nSUNBZ2JHVnVDaUFnSUNCaWJub2djbVYyYjJ0bFFYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlYMlZzYzJWZlltOWtlVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVGalkyOTFiblErS0hzZ2EyVjVVSEpsWm1sNE9pQW5aQ2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RjS0lDQWdJQzh2SUdOdmJuTjBJR1Z1ZEhKNUlEMGdkR2hwY3k1aGRYUm9iM0pwZW1Wa1VHRjVaV1ZUYVdkdVpYSW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCaGRYUm9iM0pwZW1Wa1VHRjVaV1ZUYVdkdVpYSWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRV05qYjNWdWRENG9leUJyWlhsUWNtVm1hWGc2SUNka0p5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGxiblJ5ZVM1bGVHbHpkSE1zSUNkUVlYbGxaU0J6YVdkdVpYSWdibTkwSUhObGRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVdWbElITnBaMjVsY2lCdWIzUWdjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGtLSUNBZ0lDOHZJR1Z1ZEhKNUxtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtDbkpsZG05clpVRjFkR2h2Y21sNlpXUlFZWGxsWlZOcFoyNWxjbDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EY3RNakV3Q2lBZ0lDQXZMeUJwZEhodUxuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJRUVZsRlJWOVRTVWRPUlZKZlFrOVlYMDFDVWl3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRGdLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTVDaUFnSUNBdkx5QmhiVzkxYm5RNklGQkJXVVZGWDFOSlIwNUZVbDlDVDFoZlRVSlNMQW9nSUNBZ2FXNTBZeUExSUM4dklESTROVEF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakEzTFRJeE1Bb2dJQ0FnTHk4Z2FYUjRiaTV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1VFRlpSVVZmVTBsSFRrVlNYMEpQV0Y5TlFsSXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOUW9nSUNBZ0x5OGdjbVYyYjJ0bFFYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsZG05clpVRjFkR2h2Y21sNlpXUlFZWGxsWlZOcFoyNWxjbDlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TVFvZ0lDQWdMeThnZEdocGN5NWhjM05sY25SVFpXNWtaWEpKYzBOb1lXNXVaV3hRWVhsbFpTaGphR0Z1Ym1Wc1NXUXBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHTmhiR3h6ZFdJZ1lYTnpaWEowVTJWdVpHVnlTWE5EYUdGdWJtVnNVR0Y1WldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJqYUdGdWJtVnNVR0Y1WldWVGFXZHVaWElnUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJRUZqWTI5MWJuUStLSHNnYTJWNVVISmxabWw0T2lBblpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbVVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TXdvZ0lDQWdMeThnWVhOelpYSjBLR1Z1ZEhKNUxtVjRhWE4wY3l3Z0owTm9ZVzV1Wld3Z2NHRjVaV1VnYzJsbmJtVnlJRzV2ZENCelpYUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJSEJoZVdWbElITnBaMjVsY2lCdWIzUWdjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRFFLSUNBZ0lDOHZJR1Z1ZEhKNUxtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdJZ2NtVjJiMnRsUVhWMGFHOXlhWHBsWkZCaGVXVmxVMmxuYm1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdSTllXNWhaMlZ5TG5ObGRGTmxkSFJzWlcxbGJuUk1iMmRwWTFOcFoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZObGRIUnNaVzFsYm5STWIyZHBZMU5wWnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4T0FvZ0lDQWdMeThnYzJWMFUyVjBkR3hsYldWdWRFeHZaMmxqVTJsbktHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHeHZaMmxqVTJsbk9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qQUtJQ0FnSUM4dklHRnpjMlZ5ZENoamFHRnVibVZzTG1WNGFYTjBjeXdnSjBOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUW5LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU13b2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaWElzSUNkUGJteDVJSEJoZVdWeUlHTmhiaUJ6WlhRZ1RHOW5hV05UYVdjbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakl5TFRJeU13b2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlITmxkQ0JNYjJkcFkxTnBaeWNwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU13b2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaWElzSUNkUGJteDVJSEJoZVdWeUlHTmhiaUJ6WlhRZ1RHOW5hV05UYVdjbktRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIQmhlV1Z5SUdOaGJpQnpaWFFnVEc5bmFXTlRhV2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlOQW9nSUNBZ0x5OGdZWE56WlhKMEtHeHZaMmxqVTJsbklDRTlQU0JCWTJOdmRXNTBLQ2tzSUNkTWIyZHBZMU5wWnlCaFkyTnZkVzUwSUhKbGNYVnBjbVZrSnlrS0lDQWdJR1IxY0FvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUV4dloybGpVMmxuSUdGalkyOTFiblFnY21WeGRXbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QnpaWFIwYkdWdFpXNTBURzluYVdOVGFXY2dQU0JDYjNoTllYQThZbmwwWlhNc0lFRmpZMjkxYm5RK0tIc2dhMlY1VUhKbFptbDRPaUFuYkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltd2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJMkNpQWdJQ0F2THlCMGFHbHpMbk5sZEhSc1pXMWxiblJNYjJkcFkxTnBaeWhqYUdGdWJtVnNTV1FwTG5aaGJIVmxJRDBnYkc5bmFXTlRhV2NLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4T0FvZ0lDQWdMeThnYzJWMFUyVjBkR3hsYldWdWRFeHZaMmxqVTJsbktHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHeHZaMmxqVTJsbk9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRWg1WW5KcFpFMWhibUZuWlhJdWNtVjJiMnRsVTJWMGRHeGxiV1Z1ZEV4dloybGpVMmxuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVjJiMnRsVTJWMGRHeGxiV1Z1ZEV4dloybGpVMmxuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0xQ2lBZ0lDQXZMeUJ5WlhadmEyVlRaWFIwYkdWdFpXNTBURzluYVdOVGFXY29ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpOd29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaWElzSUNkUGJteDVJSEJoZVdWeUlHTmhiaUJ5WlhadmEyVWdURzluYVdOVGFXY25LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNNUxUSTBNQW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsZG05clpTQk1iMmRwWTFOcFp5Y3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnlaWFp2YTJVZ1RHOW5hV05UYVdjbktRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIQmhlV1Z5SUdOaGJpQnlaWFp2YTJVZ1RHOW5hV05UYVdjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJ6WlhSMGJHVnRaVzUwVEc5bmFXTlRhV2NnUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJRUZqWTI5MWJuUStLSHNnYTJWNVVISmxabWw0T2lBbmJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTXdvZ0lDQWdMeThnWVhOelpYSjBLR3h2WjJsalUybG5MbVY0YVhOMGN5d2dKMU5sZEhSc1pXMWxiblFnVEc5bmFXTlRhV2NnYm05MElITmxkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZObGRIUnNaVzFsYm5RZ1RHOW5hV05UYVdjZ2JtOTBJSE5sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalEwQ2lBZ0lDQXZMeUJzYjJkcFkxTnBaeTVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNelVLSUNBZ0lDOHZJSEpsZG05clpWTmxkSFJzWlcxbGJuUk1iMmRwWTFOcFp5aGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRWg1WW5KcFpFMWhibUZuWlhJdWMyVjBkR3hsUm5KdmJVeHZaMmxqVTJsblczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwZEd4bFJuSnZiVXh2WjJsalUybG5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVXlDaUFnSUNBdkx5QnpaWFIwYkdWR2NtOXRURzluYVdOVGFXY29ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVMENpQWdJQ0F2THlCaGMzTmxjblFvWTJoaGJtNWxiQzVsZUdsemRITXNJQ2REYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdScFp5QXlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRZS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhObGRIUnNaVzFsYm5STWIyZHBZMU5wWnlBOUlFSnZlRTFoY0R4aWVYUmxjeXdnUVdOamIzVnVkRDRvZXlCclpYbFFjbVZtYVhnNklDZHNKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYkNJS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0d4dloybGpVMmxuTG1WNGFYTjBjeXdnSjFObGRIUnNaVzFsYm5RZ1RHOW5hV05UYVdjZ2JtOTBJSE5sZENjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGTmxkSFJzWlcxbGJuUWdURzluYVdOVGFXY2dibTkwSUhObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVNUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdiRzluYVdOVGFXY3VkbUZzZFdVc0lDZFBibXg1SUhObGRIUnNaVzFsYm5RZ1RHOW5hV05UYVdjZ1kyRnVJSE5sZEhSc1pTY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnpaWFIwYkdWdFpXNTBJRXh2WjJsalUybG5JR05oYmlCelpYUjBiR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpNQW9nSUNBZ0x5OGdZWE56WlhKMEtHTjFiWFZzWVhScGRtVkJiVzkxYm5RZ1BpQmtZWFJoTG14aGMzUlRaWFIwYkdWa0xDQW5UbTkwYUdsdVp5QnVaWGNnZEc4Z2MyVjBkR3hsSnlrS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBjeUEzTkNBNElDOHZJRGMwTENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3TWdvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZkR2hwYm1jZ2JtVjNJSFJ2SUhObGRIUnNaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETXhDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZENBOFBTQmtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDd2dKMVp2ZFdOb1pYSWdaWGhqWldWa2N5QmtaWEJ2YzJsMEp5a0tJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwY3lBMk5pQTRJQzh2SURZMkxDQTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnVm05MVkyaGxjaUJsZUdObFpXUnpJR1JsY0c5emFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRek13b2dJQ0FnTHk4Z1kyOXVjM1FnY0dGNWIzVjBPaUIxYVc1ME5qUWdQU0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBJQzBnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQW9nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRek5DMDBNemdLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpXVXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbHZkWFFzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETTFDaUFnSUNBdkx5QjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWTkVRMTlCVTFORlZGOUpSQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETTJDaUFnSUNBdkx5QmhjM05sZEZKbFkyVnBkbVZ5T2lCa1lYUmhMbkJoZVdWbExBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRek5DMDBNemdLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpXVXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbHZkWFFzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRME1Bb2dJQ0FnTHk4Z1pHRjBZUzVzWVhOMFUyVjBkR3hsWkNBOUlHTjFiWFZzWVhScGRtVkJiVzkxYm5RS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhKbGNHeGhZMlV5SURjMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRME1Rb2dJQ0FnTHk4Z2FXWWdLR04xYlhWc1lYUnBkbVZCYlc5MWJuUWdQaUJrWVhSaExteGhkR1Z6ZEZadmRXTm9aWEpCYlc5MWJuUXBJSHNLSUNBZ0lIQjFjMmhwYm5RZ09ESWdMeThnT0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErQ2lBZ0lDQmllaUJ6WlhSMGJHVkdjbTl0VEc5bmFXTlRhV2RmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5ESUtJQ0FnSUM4dklHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZENBOUlHTjFiWFZzWVhScGRtVkJiVzkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0J5WlhCc1lXTmxNaUE0TWdvS2MyVjBkR3hsUm5KdmJVeHZaMmxqVTJsblgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTWdvZ0lDQWdMeThnWTJoaGJtNWxiQzUyWVd4MVpTQTlJR05zYjI1bEtHUmhkR0VwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU1nb2dJQ0FnTHk4Z2MyVjBkR3hsUm5KdmJVeHZaMmxqVTJsbktHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdSTllXNWhaMlZ5TG1Oc2IzTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJ4dmMyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56QUtJQ0FnSUM4dklHTnNiM05sS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM01nb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TnpRS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNOZ29nSUNBZ0x5OGdZMjl1YzNRZ2NHRjVaV1ZUYVdkdVpYSWdQU0IwYUdsekxtVm1abVZqZEdsMlpWQmhlV1ZsVTJsbmJtVnlLR05vWVc1dVpXeEpaQ3dnWkdGMFlTNXdZWGxsWlNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1pXWm1aV04wYVhabFVHRjVaV1ZUYVdkdVpYSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjM0NpQWdJQ0F2THlCamIyNXpkQ0JwYzFCaGVXVmxVMmxuYm1WeUlEMGdjR0Y1WldWVGFXZHVaWElnSVQwOUlFRmpZMjkxYm5Rb0tTQW1KaUJVZUc0dWMyVnVaR1Z5SUQwOVBTQndZWGxsWlZOcFoyNWxjZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZbm9nWTJ4dmMyVmZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdKNklHTnNiM05sWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtTnNiM05sWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM09Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaV1VnZkh3Z2FYTlFZWGxsWlZOcFoyNWxjaXdnSjA5dWJIa2djR0Y1WldVZ2IzSWdjR0Y1WldVZ2MybG5ibVZ5SUdOaGJpQmpiRzl6WlNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQVDBLSUNBZ0lIeDhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J3WVhsbFpTQnZjaUJ3WVhsbFpTQnphV2R1WlhJZ1kyRnVJR05zYjNObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RBS0lDQWdJQzh2SUhSb2FYTXVabWx1WVd4cGVtVkRhR0Z1Ym1Wc0tHTm9ZVzV1Wld4SlpDd2daR0YwWVNrS0lDQWdJR1JwWnlBekNpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJtYVc1aGJHbDZaVU5vWVc1dVpXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjd0NpQWdJQ0F2THlCamJHOXpaU2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BqYkc5elpWOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQmpiRzl6WlY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwU0hsaWNtbGtUV0Z1WVdkbGNpNXlaWEYxWlhOMFEyeHZjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYRjFaWE4wUTJ4dmMyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EWUtJQ0FnSUM4dklISmxjWFZsYzNSRGJHOXpaU2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamc0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZMmhoYm01bGJDNWxlR2x6ZEhNc0lDZERhR0Z1Ym1Wc0lHUnZaWE1nYm05MElHVjRhWE4wSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3hDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsY2l3Z0owOXViSGtnY0dGNVpYSWdZMkZ1SUhKbGNYVmxjM1FnWTJ4dmMyVW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprd0xUSTVNUW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsY1hWbGMzUWdZMnh2YzJVbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2NtVnhkV1Z6ZENCamJHOXpaU2NwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY0dGNVpYSWdZMkZ1SUhKbGNYVmxjM1FnWTJ4dmMyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU13b2dJQ0FnTHk4Z1pHRjBZUzVqYkc5elpWSmxjWFZsYzNSbFpFRjBJRDBnYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3pMVEk1TkFvZ0lDQWdMeThnWkdGMFlTNWpiRzl6WlZKbGNYVmxjM1JsWkVGMElEMGdiM0F1UjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z1kyaGhibTVsYkM1MllXeDFaU0E5SUdOc2IyNWxLR1JoZEdFcENpQWdJQ0J3ZFhOb2FXNTBJREV3TmlBdkx5QXhNRFlLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EWUtJQ0FnSUM4dklISmxjWFZsYzNSRGJHOXpaU2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEVoNVluSnBaRTFoYm1GblpYSXVkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdNUW9nSUNBZ0x5OGdkMmwwYUdSeVlYY29ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdNd29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd05Rb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIZHBkR2hrY21GM0p5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13TlMwek1EWUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjNhWFJvWkhKaGR5Y3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13TmdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjNhWFJvWkhKaGR5Y3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djR0Y1WlhJZ1kyRnVJSGRwZEdoa2NtRjNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdQaUF3TENBblEyeHZjMlVnYm05MElISmxjWFZsYzNSbFpDY3BDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblJ6SURFd05pQTRJQzh2SURFd05pd2dPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUVOc2IzTmxJRzV2ZENCeVpYRjFaWE4wWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13T1FvZ0lDQWdMeThnYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0ErUFNCa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdLeUJEVEU5VFJWOUhVa0ZEUlY5UVJWSkpUMFJmVTBWRFQwNUVVeXdLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ09EZzRJQzh2SURnNE9Bb2dJQ0FnS3dvZ0lDQWdQajBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdPQzB6TVRFS0lDQWdJQzh2SUdGemMyVnlkQ2dLSUNBZ0lDOHZJQ0FnYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0ErUFNCa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdLeUJEVEU5VFJWOUhVa0ZEUlY5UVJWSkpUMFJmVTBWRFQwNUVVeXdLSUNBZ0lDOHZJQ0FnSjBOc2IzTmxJR2R5WVdObElIQmxjbWx2WkNCdWIzUWdaV3hoY0hObFpDY3NDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1EyeHZjMlVnWjNKaFkyVWdjR1Z5YVc5a0lHNXZkQ0JsYkdGd2MyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1UTUtJQ0FnSUM4dklIUm9hWE11Wm1sdVlXeHBlbVZEYUdGdWJtVnNLR05vWVc1dVpXeEpaQ3dnWkdGMFlTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWm1sdVlXeHBlbVZEYUdGdWJtVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd01Rb2dJQ0FnTHk4Z2QybDBhR1J5WVhjb1kyaGhibTVsYkVsa09pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdSTllXNWhaMlZ5TG1aMWJtUk5ZbkpRYjI5c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tablZ1WkUxaWNsQnZiMnc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNVGtLSUNBZ0lDOHZJR1oxYm1STlluSlFiMjlzS0hCaGVXMWxiblE2SUhzZ2NtVmpaV2wyWlhJNklFRmpZMjkxYm5RZ2ZTazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdUMkpxWldOMFFVRkRSamcxTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15TUFvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUc5d0xrZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENBblVHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHTnZiblJ5WVdOMEp5a0tJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNVGtLSUNBZ0lDOHZJR1oxYm1STlluSlFiMjlzS0hCaGVXMWxiblE2SUhzZ2NtVmpaV2wyWlhJNklFRmpZMjkxYm5RZ2ZTazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUk5ZVzVoWjJWeUxtOXdkRWx1VlhOa1kxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTl3ZEVsdVZYTmtZem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlPQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUc5d0xrZHNiMkpoYkM1amNtVmhkRzl5UVdSa2NtVnpjeXdnSjA5dWJIa2dZM0psWVhSdmNpQmpZVzRnYjNCMElHbHVJRlZUUkVNbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2IzQjBJR2x1SUZWVFJFTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNek1DMHpNelFLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNekVLSUNBZ0lDOHZJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNeklLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNek13b2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TXdMVE16TkFvZ0lDQWdMeThnYVhSNGJpNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ2VHWmxja0Z6YzJWME9pQkJjM05sZENoVlUwUkRYMEZUVTBWVVgwbEVLU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2diM0F1UjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNamNLSUNBZ0lDOHZJRzl3ZEVsdVZYTmtZeWdwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFNIbGljbWxrVFdGdVlXZGxjaTVuWlhSVFpYTnphVzl1VTNSaGRHbGpSR0YwWVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRk5sYzNOcGIyNVRkR0YwYVdORVlYUmhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkRRS0lDQWdJQzh2SUdGemMyVnlkQ2hqYUdGdWJtVnNMbVY0YVhOMGN5d2dKME5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR0Z1Ym1Wc0lHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORFl0TXpRM0NpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lDOHZJSEpsZEhWeWJpQmJaR0YwWVM1emRHRnlkRkp2ZFc1a0xDQmtZWFJoTG5OMFlYSjBWR2x0WlhOMFlXMXdYUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwY3lBNU1DQTRJQzh2SURrd0xDQTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRM0NpQWdJQ0F2THlCeVpYUjFjbTRnVzJSaGRHRXVjM1JoY25SU2IzVnVaQ3dnWkdGMFlTNXpkR0Z5ZEZScGJXVnpkR0Z0Y0YwS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wTmkwek5EY0tJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnY21WMGRYSnVJRnRrWVhSaExuTjBZWEowVW05MWJtUXNJR1JoZEdFdWMzUmhjblJVYVcxbGMzUmhiWEJkQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MGN5QTVPQ0E0SUM4dklEazRMQ0E0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UTNDaUFnSUNBdkx5QnlaWFIxY200Z1cyUmhkR0V1YzNSaGNuUlNiM1Z1WkN3Z1pHRjBZUzV6ZEdGeWRGUnBiV1Z6ZEdGdGNGMEtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFNIbGljbWxrVFdGdVlXZGxjaTVuWlhSVFpYTnphVzl1UkhsdVlXMXBZMFJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJUWlhOemFXOXVSSGx1WVcxcFkwUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJ6WlhSMGJHVnRaVzUwVEc5bmFXTlRhV2NnUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJRUZqWTI5MWJuUStLSHNnYTJWNVVISmxabWw0T2lBbmJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXdpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WTBDaUFnSUNBdkx5QnlaWFIxY200Z1cyUmhkR0V1ZEc5MFlXeEVaWEJ2YzJsMExDQmtZWFJoTG14aGMzUlRaWFIwYkdWa0xDQmtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5Rc0lHeHZaMmxqVTJsbkxtVjRhWE4wY3lBL0lHeHZaMmxqVTJsbkxuWmhiSFZsSURvZ1FXTmpiM1Z1ZENncFhRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBjeUEyTmlBNElDOHZJRFkyTENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBjeUEzTkNBNElDOHZJRGMwTENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkSE1nT0RJZ09DQXZMeUE0TWl3Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwVTJWemMybHZia1I1Ym1GdGFXTkVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2dwblpYUlRaWE56YVc5dVJIbHVZVzFwWTBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZMENpQWdJQ0F2THlCeVpYUjFjbTRnVzJSaGRHRXVkRzkwWVd4RVpYQnZjMmwwTENCa1lYUmhMbXhoYzNSVFpYUjBiR1ZrTENCa1lYUmhMbXhoZEdWemRGWnZkV05vWlhKQmJXOTFiblFzSUd4dloybGpVMmxuTG1WNGFYTjBjeUEvSUd4dloybGpVMmxuTG5aaGJIVmxJRG9nUVdOamIzVnVkQ2dwWFFvZ0lDQWdaR2xuSURNS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelUzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRk5sYzNOcGIyNUVlVzVoYldsalJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5qUUtJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzUwYjNSaGJFUmxjRzl6YVhRc0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZEN3Z2JHOW5hV05UYVdjdVpYaHBjM1J6SUQ4Z2JHOW5hV05UYVdjdWRtRnNkV1VnT2lCQlkyTnZkVzUwS0NsZENpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHSWdaMlYwVTJWemMybHZia1I1Ym1GdGFXTkVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbWRsZEVGMWRHaHZjbWw2WldSUVlYbGxaVk5wWjI1bGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVGMWRHaHZjbWw2WldSUVlYbGxaVk5wWjI1bGNqb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek56WUtJQ0FnSUM4dklHbG1JQ2hqYUdGdWJtVnNTV1F1YkdWdVozUm9JRDA5UFNBd0tTQjdDaUFnSUNCc1pXNEtJQ0FnSUdKdWVpQm5aWFJCZFhSb2IzSnBlbVZrVUdGNVpXVlRhV2R1WlhKZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVGalkyOTFiblErS0hzZ2EyVjVVSEpsWm1sNE9pQW5aQ2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1RaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16YzRDaUFnSUNBdkx5QnlaWFIxY200Z2NHRjVaV1ZUYVdkdVpYSXVaWGhwYzNSeklEOGdjR0Y1WldWVGFXZHVaWEl1ZG1Gc2RXVWdPaUJCWTJOdmRXNTBLQ2tLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1oyVjBRWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5WDNSbGNtNWhjbmxmWm1Gc2MyVkFOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2dwblpYUkJkWFJvYjNKcGVtVmtVR0Y1WldWVGFXZHVaWEpmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFNIbGljbWxrVFdGdVlXZGxjaTVuWlhSQmRYUm9iM0pwZW1Wa1VHRjVaV1ZUYVdkdVpYSkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUkJkWFJvYjNKcGVtVmtVR0Y1WldWVGFXZHVaWEpmZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16YzRDaUFnSUNBdkx5QnlaWFIxY200Z2NHRjVaV1ZUYVdkdVpYSXVaWGhwYzNSeklEOGdjR0Y1WldWVGFXZHVaWEl1ZG1Gc2RXVWdPaUJCWTJOdmRXNTBLQ2tLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpjMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdJZ1oyVjBRWFYwYUc5eWFYcGxaRkJoZVdWbFUybG5ibVZ5WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1WjJWMFFYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlRRGNLQ21kbGRFRjFkR2h2Y21sNlpXUlFZWGxsWlZOcFoyNWxjbDloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENoamFHRnVibVZzTG1WNGFYTjBjeXdnSjBOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUW5LUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9ETXRNemcwQ2lBZ0lDQXZMeUJqYjI1emRDQmtZWFJoSUQwZ1kyeHZibVVvWTJoaGJtNWxiQzUyWVd4MVpTa0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbVZtWm1WamRHbDJaVkJoZVdWbFUybG5ibVZ5S0dOb1lXNXVaV3hKWkN3Z1pHRjBZUzV3WVhsbFpTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1WbVptVmpkR2wyWlZCaGVXVmxVMmxuYm1WeUtHTm9ZVzV1Wld4SlpDd2daR0YwWVM1d1lYbGxaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1pXWm1aV04wYVhabFVHRjVaV1ZUYVdkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM05Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaUlHZGxkRUYxZEdodmNtbDZaV1JRWVhsbFpWTnBaMjVsY2w5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdSTllXNWhaMlZ5TG1kbGRFRjFkR2h2Y21sNlpXUlFZWGxsWlZOcFoyNWxja0EzQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1WkdWeWFYWmxRMmhoYm01bGJFbGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWeWFYWmxRMmhoYm01bGJFbGtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0xuTm9ZVEkxTmlod1lYbGxjaTVpZVhSbGN5NWpiMjVqWVhRb2NHRjVaV1V1WW5sMFpYTXBMbU52Ym1OaGRDaHZjQzVwZEc5aUtGVlRSRU5mUVZOVFJWUmZTVVFwS1M1amIyNWpZWFFvYzJGc2RDa3VZMjl1WTJGMEtHRjFkR2h2Y21sNlpXUlRhV2R1WlhJcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZeUEwSUM4dklGUk5VRXhmVlZORVExOUJVMU5GVkY5SlJBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1RFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMU1EQXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFNIbGljbWxrVFdGdVlXZGxjaTVoYzNObGNuUlRaVzVrWlhKSmMwTm9ZVzV1Wld4UVlYbGxaU2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoYzNObGNuUlRaVzVrWlhKSmMwTm9ZVzV1Wld4UVlYbGxaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdOQW9nSUNBZ0x5OGdjSEpwZG1GMFpTQmhjM05sY25SVFpXNWtaWEpKYzBOb1lXNXVaV3hRWVhsbFpTaGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdOZ29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd09Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaV1VzSUNkUGJteDVJSEJoZVdWbElHTmhiaUJ0WVc1aFoyVWdjR0Y1WldVZ2MybG5ibVZ5SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdOeTAwTURnS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WldVc0lDZFBibXg1SUhCaGVXVmxJR05oYmlCdFlXNWhaMlVnY0dGNVpXVWdjMmxuYm1WeUp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNRGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWbExDQW5UMjVzZVNCd1lYbGxaU0JqWVc0Z2JXRnVZV2RsSUhCaGVXVmxJSE5wWjI1bGNpY3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djR0Y1WldVZ1kyRnVJRzFoYm1GblpTQndZWGxsWlNCemFXZHVaWElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdSTllXNWhaMlZ5TG1WbVptVmpkR2wyWlZCaGVXVmxVMmxuYm1WeUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lIQmhlV1ZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21WbVptVmpkR2wyWlZCaGVXVmxVMmxuYm1WeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFMUNpQWdJQ0F2THlCd2NtbDJZWFJsSUdWbVptVmpkR2wyWlZCaGVXVmxVMmxuYm1WeUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lIQmhlV1ZsT2lCQlkyTnZkVzUwS1RvZ1FXTmpiM1Z1ZENCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z1kyaGhibTVsYkZCaGVXVmxVMmxuYm1WeUlEMGdRbTk0VFdGd1BHSjVkR1Z6TENCQlkyTnZkVzUwUGloN0lHdGxlVkJ5WldacGVEb2dKMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFM0NpQWdJQ0F2THlCcFppQW9ZMmhoYm01bGJGTnBaMjVsY2k1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daV1ptWldOMGFYWmxVR0Y1WldWVGFXZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCamFHRnVibVZzVTJsbmJtVnlMblpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGxabVpsWTNScGRtVlFZWGxsWlZOcFoyNWxjbDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1lYVjBhRzl5YVhwbFpGQmhlV1ZsVTJsbmJtVnlJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRUZqWTI5MWJuUStLSHNnYTJWNVVISmxabWw0T2lBblpDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRmpZMjkxYm5SVGFXZHVaWEl1WlhocGMzUnpJRDhnWVdOamIzVnVkRk5wWjI1bGNpNTJZV3gxWlNBNklFRmpZMjkxYm5Rb0tRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJsWm1abFkzUnBkbVZRWVhsbFpWTnBaMjVsY2w5MFpYSnVZWEo1WDJaaGJITmxRRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9LWldabVpXTjBhWFpsVUdGNVpXVlRhV2R1WlhKZmRHVnlibUZ5ZVY5dFpYSm5aVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV05qYjNWdWRGTnBaMjVsY2k1bGVHbHpkSE1nUHlCaFkyTnZkVzUwVTJsbmJtVnlMblpoYkhWbElEb2dRV05qYjNWdWRDZ3BDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWldabVpXTjBhWFpsVUdGNVpXVlRhV2R1WlhKZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV05qYjNWdWRGTnBaMjVsY2k1bGVHbHpkSE1nUHlCaFkyTnZkVzUwVTJsbmJtVnlMblpoYkhWbElEb2dRV05qYjNWdWRDZ3BDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0lnWldabVpXTjBhWFpsVUdGNVpXVlRhV2R1WlhKZmRHVnlibUZ5ZVY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1WVhCd2JIbFViM0JWY0Noa1lYUmhPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tZWEJ3YkhsVWIzQlZjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBOZ29nSUNBZ0x5OGdjSEpwZG1GMFpTQmhjSEJzZVZSdmNGVndLR1JoZEdFNklFTm9ZVzV1Wld4SmJtWnZMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBPaUJuZEhodUxrRnpjMlYwVkhKaGJuTm1aWEpVZUc0cE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EUTNDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEM1elpXNWtaWElnUFQwOUlGUjRiaTV6Wlc1a1pYSXNJQ2RRWVhsdFpXNTBJSE5sYm1SbGNpQnRhWE50WVhSamFDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGx0Wlc1MElITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFE0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDNWhjM05sZEZKbFkyVnBkbVZ5SUQwOVBTQnZjQzVIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dKMUJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJqYjI1MGNtRmpkQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQmlaU0IwYnlCamIyNTBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDNTRabVZ5UVhOelpYUXVhV1FnUFQwOUlGVlRSRU5mUVZOVFJWUmZTVVFzSUNkUVlYbHRaVzUwSUdGemMyVjBJRzExYzNRZ1ltVWdWVk5FUXljcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnYVc1MFl5QTBJQzh2SUZSTlVFeGZWVk5FUTE5QlUxTkZWRjlKUkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGx0Wlc1MElHRnpjMlYwSUcxMWMzUWdZbVVnVlZORVF3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRVd0NpQWdJQ0F2THlCaGMzTmxjblFvWTNWdGRXeGhkR2wyWlVGdGIzVnVkQzVoYzNObGRFRnRiM1Z1ZENBK0lEQXNJQ2RFWlhCdmMybDBJRzExYzNRZ1ltVWdQaUF3SnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUVSbGNHOXphWFFnYlhWemRDQmlaU0ErSURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExTVFvZ0lDQWdMeThnWVhOelpYSjBLR04xYlhWc1lYUnBkbVZCYlc5MWJuUXVZWE56WlhSVFpXNWtaWElnUFQwOUlFRmpZMjkxYm5Rb0tTd2dKME5zWVhkaVlXTnJJSFJ5WVc1elptVnlJRzV2ZENCaGJHeHZkMlZrSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiR0YzWW1GamF5QjBjbUZ1YzJabGNpQnViM1FnWVd4c2IzZGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVXlDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEM1aGMzTmxkRU5zYjNObFZHOGdQVDA5SUVGalkyOTFiblFvS1N3Z0owRnpjMlYwSUdOc2IzTmxJRzV2ZENCaGJHeHZkMlZrSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJEYkc5elpWUnZDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRWE56WlhRZ1kyeHZjMlVnYm05MElHRnNiRzkzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExTkFvZ0lDQWdMeThnWkdGMFlTNTBiM1JoYkVSbGNHOXphWFFnS3owZ1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEM1aGMzTmxkRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJRFkySUM4dklEWTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUEyTmdvZ0lDQWdabkpoYldWZlluVnllU0F0TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFUyQ2lBZ0lDQXZMeUJrWVhSaExtTnNiM05sVW1WeGRXVnpkR1ZrUVhRZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF4TURZS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F0TWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRWg1WW5KcFpFMWhibUZuWlhJdVptbHVZV3hwZW1WRGFHRnVibVZzS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUdSaGRHRTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tabWx1WVd4cGVtVkRhR0Z1Ym1Wc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRVNUNpQWdJQ0F2THlCd2NtbDJZWFJsSUdacGJtRnNhWHBsUTJoaGJtNWxiQ2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JrWVhSaE9pQkRhR0Z1Ym1Wc1NXNW1ieWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJNQW9nSUNBZ0x5OGdZMjl1YzNRZ2NHRjVaV1ZRWVhsdmRYUTZJSFZwYm5RMk5DQTlJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRDQXRJR1JoZEdFdWJHRnpkRk5sZEhSc1pXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0E0TWlBdkx5QTRNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURjMElDOHZJRGMwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5qRUtJQ0FnSUM4dklHbG1JQ2h3WVhsbFpWQmhlVzkxZENBK0lEQXBJSHNLSUNBZ0lHSjZJR1pwYm1Gc2FYcGxRMmhoYm01bGJGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyTWkwME5qWUtJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdSaGRHRXVjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUJ3WVhsbFpWQmhlVzkxZEN3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOak1LSUNBZ0lDOHZJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOalFLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpXVXNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmpJdE5EWTJDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUVGemMyVjBLRlZUUkVOZlFWTlRSVlJmU1VRcExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCa1lYUmhMbkJoZVdWbExBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nY0dGNVpXVlFZWGx2ZFhRc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLQ21acGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5qa0tJQ0FnSUM4dklHTnZibk4wSUhCaGVXVnlVbVZtZFc1a09pQjFhVzUwTmpRZ1BTQmtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDQXRJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRFkySUM4dklEWTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOekFLSUNBZ0lDOHZJR2xtSUNod1lYbGxjbEpsWm5WdVpDQStJREFwSUhzS0lDQWdJR0o2SUdacGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM01TMDBOelVLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpYSXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbGxjbEpsWm5WdVpDd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTnpJS0lDQWdJQzh2SUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlWVTBSRFgwRlRVMFZVWDBsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTnpNS0lDQWdJQzh2SUdGemMyVjBVbVZqWldsMlpYSTZJR1JoZEdFdWNHRjVaWElzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM01TMDBOelVLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpYSXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbGxjbEpsWm5WdVpDd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1ptbHVZV3hwZW1WRGFHRnVibVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNPQW9nSUNBZ0x5OGdkR2hwY3k1amFHRnVibVZzY3loamFHRnVibVZzU1dRcExtUmxiR1YwWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhObGRIUnNaVzFsYm5STWIyZHBZMU5wWnlBOUlFSnZlRTFoY0R4aWVYUmxjeXdnUVdOamIzVnVkRDRvZXlCclpYbFFjbVZtYVhnNklDZHNKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGd3Q2lBZ0lDQXZMeUJwWmlBb2JHOW5hV05UYVdjdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR1pwYm1Gc2FYcGxRMmhoYm01bGJGOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0TVFvZ0lDQWdMeThnYkc5bmFXTlRhV2N1WkdWc1pYUmxLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ21acGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z1kyaGhibTVsYkZCaGVXVmxVMmxuYm1WeUlEMGdRbTk0VFdGd1BHSjVkR1Z6TENCQlkyTnZkVzUwUGloN0lHdGxlVkJ5WldacGVEb2dKMlVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RZS0lDQWdJQzh2SUdsbUlDaGphR0Z1Ym1Wc1UybG5ibVZ5TG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQm1hVzVoYkdsNlpVTm9ZVzV1Wld4ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGczQ2lBZ0lDQXZMeUJqYUdGdWJtVnNVMmxuYm1WeUxtUmxiR1YwWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RndE5Ea3hDaUFnSUNBdkx5QnBkSGh1TG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ1pHRjBZUzV3WVhsbFpTd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQlFRVmxGUlY5VFNVZE9SVkpmUWs5WVgwMUNVaXdLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Ea0tJQ0FnSUM4dklISmxZMlZwZG1WeU9pQmtZWFJoTG5CaGVXVmxMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9UQUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ1VFRlpSVVZmVTBsSFRrVlNYMEpQV0Y5TlFsSXNDaUFnSUNCcGJuUmpJRFVnTHk4Z01qZzFNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPRGd0TkRreENpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nWkdGMFlTNXdZWGxsWlN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCUVFWbEZSVjlUU1VkT1JWSmZRazlZWDAxQ1Vpd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWm1sdVlXeHBlbVZEYUdGdWJtVnNYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFHQUFFZ0FnRFUzZ0VtQlFGc0FXUUJaUVFWSDN4MUJoVWZmSFVBSURFYlFRQ0dNUmtVUkRFWVJJSVJCQkZqeFJNRXZjK3NXQVE5K3hkeUJQMWNxZUVFcm9tbitBUkMyWFdtQkNDNXZwc0VRNXhmc1FUb2F1bnBCRFJvVUZBRVdRWFU5QVNxRk1UNUJINC9TbWdFcUhCSkF3VE0zcCsyQklxUGRZSUVLL1lKNERZYUFJNFJBQXNBM2dFWEFXb0IvQUpBQW5RQ25nTW1BMjhEbGdQUkErSUQvZ1FzQklNRXpRQXhHUlF4R0JRUVJDTkROaG9CUndJVkpCSkVNUllqQ1VsT0FqZ1FnUVFTUkRZYUFra2lXU1VJU3dFVkVrUlhBZ0EyR2dOSklsa2xDRXNCRlJKRVZ3SUFTVTRFU1JWSlRnWWtFa1F4QUU4RFVDRUVGbEJQQWxCTVVBRkpUZ085UlFGQUFFTXlCaklITVFCTEIxQkxCaFpYQmdKUEJWQk1nQUlBY2xBaUZreExBVkJMQVZCTEFWQlBCQlpRVHdNV1VFeFFURkJNaUFTOFN3Rkp2RWhNdnljRVN3RlFzQ05EU3dKSnZrUXhBRXNDSWlTNkVrUkxBU1JKdWtzSEVrUkpnVUJaU3dFVlN3Sk9BbEpYQWdCUEJCSkVUd0tJQkg1TEFieEl2MEwvd1RZYUFVa2lXU1VJU3dFVkVrUlhBZ0F4RmlNSlNUZ1FnUVFTUkVzQnZVVUJSRXNCdmtoTU1RQkxBeUlrdWhKRWlBUkVTd0c4U0w4alF6WWFBVWtpV1NVSVN3RVZFa1JYQWdBMkdnSkpJbGtsQ0VzQkZSSkVWd0lBU3dHOVJRRkVTd0crU0U0Q01RQkxBaUlrdWhKRVNSVkVBNEFDQUNCTVVFc0NnVUJaVHdNaVR3SllURkJMQWJ4SXZ5TkRJa2t4RmlNSlJ3STRFQ01TUkRZYUFVbE9Ba2tWSkJKRU5ob0NTU0paSlFoTEFSVVNSRmNDQUVsT0EwNERTVElERTBReEFCTkVTVGdBTVFBU1JFazRCeklLRWtSSk9Ba3lBeEpFT0NBeUF4SkVGVUFBSENreEFGQkpSUWE5UlFGQUFBaExBamdJSVFVUFJFc0VTd0svSTBOSEFvZ0RNaXBNVUVsRkJiMUZBVUFBQ0VzQ09BZ2hCUTlFU3dOTEFyOUMvOTAyR2dGSklsa2xDRXNCRlJKRVZ3SUFTUlZBQUIwcE1RQlFTYjFGQVVTOFNMRXhBQ0VGc2dpeUJ5T3lFQ0t5QWJNalEwY0NpQUxmS2t4UVNiMUZBVVM4U0VMLzNEWWFBVWtpV1NVSVN3RVZFa1JYQWdBMkdnSkpGU1FTUkVzQnZVVUJSREVBU3dJaUpMb1NSRWt5QXhORUtFOENVRXkvSTBNMkdnRkpJbGtsQ0VzQkZSSkVWd0lBU2IxRkFVUXhBRXNCSWlTNkVrUW9URkJKdlVVQlJMeElJME0yR2dGSklsa2xDRXNCRlJKRVZ3SUFTVFlhQWtsT0Fra1ZnUWdTUkVrWFN3SzlSUUZFU3dLK1NFNENLRXNFVUVtOVJRRkVNUUJNdmtnU1JFc0Rnd0pLQ0xvWFNnMUVTd1NEQWtJSXVoZExBZzlFU3dGTUNiRWhCRXhQQlNSSnVySVVzaEt5RVlFRXNoQWlzZ0d6VGdKY1NrbE9Bb0ZTV3cxQkFBUkxBVnhTU3dKSnZFaE12eU5ETmhvQlNTSlpKUWhMQVJVU1JGY0NBRWNDdlVVQlJFbStTRXhKSkVtNlNVNENpQUhiU1RJREUwRUFHakVBU3dFU1FRQVNJekVBU3dNU0VVUkxBMHNEaUFJMlNDTkRJa0wvNnpZYUFVa2lXU1VJU3dFVkVrUlhBZ0JKdlVVQlJERUFTd0VpSkxvU1JESUhGb0ZxVExzalF6WWFBVWtpV1NVSVN3RVZFa1JYQWdCSnZVVUJSRW0rU0V3eEFFc0JJaVM2RWtSSmd3SnFDTG9YU1VReUIweUIrQVlJRDBSTWlBSFFTQ05ETmhvQlNSVWtFa1JYQUNBeUNoSkVJME14QURJSkVrU3hJUVF5Q2lLeUVySVVzaEdCQkxJUUlySUJzeU5ETmhvQlNTSlpKUWhMQVJVU1JGY0NBRW05UlFGRVNZTUNXZ2k2RjB5REFtSUl1aGRNRmt3V1VDdE1VTEFqUXpZYUFVa2lXU1VJU3dFVkVrUlhBZ0JKdlVVQlJDaExBVkJKVHdKSmd3SkNDTG9YVGdKSmd3SktDTG9YVGdLREFsSUl1aGRNdlVVQlFRQVhTd08rUkVzREZrc0RGbEJMQWhaUVRGQXJURkN3STBNeUEwTC82Q0kyR2dGSkZTUVNSRFlhQWtraVdTVUlTd0VWRWtSWEFnQkpGVUFBSENsTEFsQkpSUVM5UlFGQkFBcExBcjVFSzB4UXNDTkRNZ05DLy9WSEFyMUZBVVJKSkVtNmlBQmJRdi9sTmhvQlNSVWtFa1EyR2dKSkZTUVNSRFlhQTBraVdTVUlTd0VWRWtSWEFnQTJHZ1JKSWxrbENFc0JGUkpFVndJQVR3TlBBMUFoQkJaUVRGQk1VQUVuQkV4UXNDTkRpZ0VBaS8rOVJRRkVNUUNML3lSSnVoSkVpWW9DQVNJcWkvNVFTYjFGQVVFQUI0c0J2a1NNQUlrcGkvOVFTWXdBdlVVQlFRQUhpd0MrUkl3QWlUSURRdi80aWdJQmkvODRBREVBRWtTTC96Z1VNZ29TUkl2L09CRWhCQkpFaS84NEVrbEVpLzg0RXpJREVrU0wvemdWTWdNU1JJditnVUpiQ0JhTC9reGNRb3orSWhhTC9reGNha21NL29tS0FnRWlTWUFBaS8rQlVsdEppLytCU2xzSlNVRUFHTEVoQkl2L1Z5QWdpd1N5RXJJVXNoR0JCTElRSXJJQnM0di9nVUpiaXdNSlNZd0NRUUFZc1NFRWkvOVhBQ0NMQXJJU3NoU3lFWUVFc2hBaXNnR3ppLzY4U0NpTC9sQkpqQUc5UlFGQkFBU0xBYnhJS292K1VFbU1BTDFGQVVFQUY0c0F2RWl4aS85WElDQWhCYklJc2djanNoQWlzZ0d6aS8rTUFJaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJVU0RDX0FTU0VUX0lEIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
