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

namespace Arc56.Generated.algorandecosystem.escrow_session_vault.EscrowSessionVaultHybrid_6bc9571c
{


    public class EscrowSessionVaultHybridProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowSessionVaultHybridProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        ///authorizedSigner is signer pubkey hash (32 bytes) computed client-side.
        ///authorizedSignerPublicKey is optional: if provided, stores full signer pubkey in box.
        ///</summary>
        /// <param name="payee"> </param>
        /// <param name="deposit"> </param>
        /// <param name="salt"> </param>
        /// <param name="authorizedSigner"> </param>
        /// <param name="authorizedSignerPublicKey"> </param>
        public async Task<byte[]> Open(AssetTransferTransaction deposit, Algorand.Address payee, byte[] salt, byte[] authorizedSigner, byte[] authorizedSignerPublicKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { deposit });
            byte[] abiHandle = { 72, 213, 62, 50 };
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);
            var authorizedSignerPublicKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerPublicKeyAbi.From(authorizedSignerPublicKey);

            var result = await base.CallApp(new List<object> { abiHandle, payeeAbi, deposit, saltAbi, authorizedSignerAbi, authorizedSignerPublicKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Open_Transactions(AssetTransferTransaction deposit, Algorand.Address payee, byte[] salt, byte[] authorizedSigner, byte[] authorizedSignerPublicKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { deposit });
            byte[] abiHandle = { 72, 213, 62, 50 };
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);
            var authorizedSignerPublicKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerPublicKeyAbi.From(authorizedSignerPublicKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, payeeAbi, deposit, saltAbi, authorizedSignerAbi, authorizedSignerPublicKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Set full authorized signer public key and update channel.authorizedSigner hash.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="authorizedSignerPublicKey"> </param>
        public async Task SetAuthorizedSignerPublicKey(byte[] channelId, byte[] authorizedSignerPublicKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 29, 187, 103 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var authorizedSignerPublicKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerPublicKeyAbi.From(authorizedSignerPublicKey);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, authorizedSignerPublicKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAuthorizedSignerPublicKey_Transactions(byte[] channelId, byte[] authorizedSignerPublicKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 29, 187, 103 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var authorizedSignerPublicKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerPublicKeyAbi.From(authorizedSignerPublicKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, authorizedSignerPublicKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Payee closes channel.
        ///Honors the latest on-chain voucher before refunding the payer.
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

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
        ///[totalDeposit, lastSettled, latestVoucherAmount]
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task<Structs.GetSessionDynamicDataReturn> GetSessionDynamicData(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 156, 0, 144 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 30, 156, 0, 144 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Backwards-compatible alias for deterministic channelId derivation.
        ///authorizedSigner must be signer pubkey hash (32 bytes).
        ///</summary>
        /// <param name="payer"> </param>
        /// <param name="payee"> </param>
        /// <param name="authorizedSigner"> </param>
        /// <param name="salt"> </param>
        public async Task<byte[]> ComputeChannelId(Algorand.Address payer, Algorand.Address payee, byte[] authorizedSigner, byte[] salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 76, 252, 247 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);

            var result = await base.CallApp(new List<object> { abiHandle, payerAbi, payeeAbi, authorizedSignerAbi, saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ComputeChannelId_Transactions(Algorand.Address payer, Algorand.Address payee, byte[] authorizedSigner, byte[] salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 76, 252, 247 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var payeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payeeAbi.From(payee);
            var authorizedSignerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); authorizedSignerAbi.From(authorizedSigner);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); saltAbi.From(salt);

            return await base.MakeTransactionList(new List<object> { abiHandle, payerAbi, payeeAbi, authorizedSignerAbi, saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

            var result = await base.CallApp(new List<object> { abiHandle, payerAbi, payeeAbi, authorizedSignerAbi, saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93U2Vzc2lvblZhdWx0SHlicmlkIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDQzQkM1QTEwIjpbeyJuYW1lIjoicGF5ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBheWVlIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhdXRob3JpemVkU2lnbmVyIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InRvdGFsRGVwb3NpdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0U2V0dGxlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXRlc3RWb3VjaGVyQW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXJ0Um91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhcnRUaW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY2xvc2VSZXF1ZXN0ZWRBdCIsInR5cGUiOiJ1aW50NjQifV0sIk9iamVjdEFBQ0Y4NTEwIjpbeyJuYW1lIjoicmVjZWl2ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiR2V0U2Vzc2lvblN0YXRpY0RhdGFSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0U2Vzc2lvbkR5bmFtaWNEYXRhUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wZW4iLCJkZXNjIjoiT3BlbnMgYSBjaGFubmVsIHdpdGggaW5pdGlhbCBVU0RDIGRlcG9zaXQgYW5kIHJldHVybnMgZGVyaXZlZCBjaGFubmVsSWQuXG5DYWxsZXIgYmVjb21lcyBwYXllci5cbmF1dGhvcml6ZWRTaWduZXIgaXMgc2lnbmVyIHB1YmtleSBoYXNoICgzMiBieXRlcykgY29tcHV0ZWQgY2xpZW50LXNpZGUuXG5hdXRob3JpemVkU2lnbmVyUHVibGljS2V5IGlzIG9wdGlvbmFsOiBpZiBwcm92aWRlZCwgc3RvcmVzIGZ1bGwgc2lnbmVyIHB1YmtleSBpbiBib3guIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyUHVibGljS2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9wVXAiLCJkZXNjIjoiQWRkcyBmdW5kcyB0byBhbiBleGlzdGluZyBjaGFubmVsIHVzaW5nIGEgZ3JvdXBlZCBVU0RDIGFzc2V0IHRyYW5zZmVyLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VtdWxhdGl2ZUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRBdXRob3JpemVkU2lnbmVyUHVibGljS2V5IiwiZGVzYyI6IlNldCBmdWxsIGF1dGhvcml6ZWQgc2lnbmVyIHB1YmxpYyBrZXkgYW5kIHVwZGF0ZSBjaGFubmVsLmF1dGhvcml6ZWRTaWduZXIgaGFzaC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyUHVibGljS2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFNldHRsZW1lbnRMb2dpY1NpZyIsImRlc2MiOiJSZWdpc3RlcnMgdGhlIGNoYW5uZWwtc3BlY2lmaWMgTG9naWNTaWcgdXNlZCBmb3IgRmFsY29uLWF1dGhvcml6ZWQgc2V0dGxlbWVudC5cblRoZSBwYXllciBjb21waWxlcyBpdCB3aXRoIHRoaXMgYXBwIGlkLCBjaGFubmVsIGlkLCBwYXllZSwgYW5kIHRoZSBwdWJsaWMga2V5XG53aG9zZSBzaGE1MTJfMjU2IGhhc2ggaXMgc3RvcmVkIG9uIHRoZSBjaGFubmVsLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2dpY1NpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXR0bGVGcm9tTG9naWNTaWciLCJkZXNjIjoiU2V0dGxlIHRocm91Z2ggdGhlIHJlZ2lzdGVyZWQgTG9naWNTaWcuIEZhbGNvbiB2ZXJpZmljYXRpb24gb2NjdXJzIGluIHRoZVxuTG9naWNTaWcgcHJvZ3JhbTsgdGhpcyBjYWxsIGJpbmRzIHRoYXQgYXV0aG9yaXphdGlvbiB0byB0aGUgY2hhbm5lbCBib3ggYW5kXG5hZHZhbmNlcyBpdHMgdm91Y2hlciB3YXRlcm1hcmssIHByZXZlbnRpbmcgdm91Y2hlciByZXBsYXkuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VtdWxhdGl2ZUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbG9zZSIsImRlc2MiOiJQYXllZSBjbG9zZXMgY2hhbm5lbC5cbkhvbm9ycyB0aGUgbGF0ZXN0IG9uLWNoYWluIHZvdWNoZXIgYmVmb3JlIHJlZnVuZGluZyB0aGUgcGF5ZXIuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXF1ZXN0Q2xvc2UiLCJkZXNjIjoiUGF5ZXIgcmVxdWVzdHMgY2hhbm5lbCBjbG9zdXJlLCBzdGFydGluZyBmb3JjZWQtY2xvc2UgZ3JhY2UgcGVyaW9kLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiUGF5ZXIgd2l0aGRyYXdzIHJlbWFpbmluZyBmdW5kcyBhZnRlciBncmFjZSBwZXJpb2QgZXhwaXJlcy5cbkhvbm9ycyB0aGUgbGF0ZXN0IG9uLWNoYWluIHZvdWNoZXIgYmVmb3JlIHJlZnVuZGluZyB0aGUgcGF5ZXIuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kTWJyUG9vbCIsImRlc2MiOiJGdW5kcyBNQlIvZmVlcyBwb29sIHVzaW5nIEFMR08uIiwiYXJncyI6W3sidHlwZSI6IihhZGRyZXNzKSIsInN0cnVjdCI6Ik9iamVjdEFBQ0Y4NTEwIiwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Vc2RjIiwiZGVzYyI6Ik9wdCBhcHAgYWNjb3VudCBpbnRvIGNvbmZpZ3VyZWQgVVNEQyBBU0Egc28gaXQgY2FuIHJlY2VpdmUgZGVwb3NpdHMuXG5TaG91bGQgYmUgY2FsbGVkIG9uY2UgYnkgYWRtaW4vY3JlYXRvci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2Vzc2lvblN0YXRpY0RhdGEiLCJkZXNjIjoiUmV0dXJucyBsYXRlc3Qgc2Vzc2lvbiBzdGF0aWMgZGF0YSB0dXBsZTpcbltzdGFydFJvdW5kLCBzdGFydFRpbWVzdGFtcF0iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFNlc3Npb25TdGF0aWNEYXRhUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2Vzc2lvbkR5bmFtaWNEYXRhIiwiZGVzYyI6IlJldHVybnMgbGF0ZXN0IHNlc3Npb24gZHluYW1pYyBkYXRhIHR1cGxlOlxuW3RvdGFsRGVwb3NpdCwgbGFzdFNldHRsZWQsIGxhdGVzdFZvdWNoZXJBbW91bnRdIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0U2Vzc2lvbkR5bmFtaWNEYXRhUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29tcHV0ZUNoYW5uZWxJZCIsImRlc2MiOiJCYWNrd2FyZHMtY29tcGF0aWJsZSBhbGlhcyBmb3IgZGV0ZXJtaW5pc3RpYyBjaGFubmVsSWQgZGVyaXZhdGlvbi5cbmF1dGhvcml6ZWRTaWduZXIgbXVzdCBiZSBzaWduZXIgcHVia2V5IGhhc2ggKDMyIGJ5dGVzKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvcml6ZWRTaWduZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXJpdmVDaGFubmVsSWQiLCJkZXNjIjoiUmVhZC1vbmx5IGhlbHBlciBmb3IgY2xpZW50czogZGV0ZXJtaW5pc3RpYyBjaGFubmVsSWQgZGVyaXZhdGlvbi5cbmF1dGhvcml6ZWRTaWduZXIgbXVzdCBiZSBzaWduZXIgcHVia2V5IGhhc2ggKDMyIGJ5dGVzKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvcml6ZWRTaWduZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExOTNdLCJlcnJvck1lc3NhZ2UiOiJBc3NldCBjbG9zZSBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1OCwxMzYyXSwiZXJyb3JNZXNzYWdlIjoiQXV0aG9yaXplZCBzaWduZXIgaGFzaCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5M10sImVycm9yTWVzc2FnZSI6IkF1dGhvcml6ZWQgc2lnbmVyIHB1YmtleSByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOV0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTMsNDc1LDU2MCw2MTksNzM5LDc4MCw4MTksOTIzLDk2OV0sImVycm9yTWVzc2FnZSI6IkNoYW5uZWwgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTg1XSwiZXJyb3JNZXNzYWdlIjoiQ2xhd2JhY2sgdHJhbnNmZXIgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTBdLCJlcnJvck1lc3NhZ2UiOiJDbG9zZSBncmFjZSBwZXJpb2Qgbm90IGVsYXBzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDFdLCJlcnJvck1lc3NhZ2UiOiJDbG9zZSBub3QgcmVxdWVzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3N10sImVycm9yTWVzc2FnZSI6IkRlcG9zaXQgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzRdLCJlcnJvck1lc3NhZ2UiOiJMb2dpY1NpZyBhY2NvdW50IHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUyXSwiZXJyb3JNZXNzYWdlIjoiTm90aGluZyBuZXcgdG8gc2V0dGxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gb3B0IGluIFVTREMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVlIGNhbiBjbG9zZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHJlb3BlbiBjaGFubmVsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzg5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllciBjYW4gcmVxdWVzdCBjbG9zZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHNldCBMb2dpY1NpZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHNldCBhdXRob3JpemVkIHNpZ25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyN10sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHRvcCB1cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzMl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHdpdGhkcmF3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBzZXR0bGVtZW50IExvZ2ljU2lnIGNhbiBzZXR0bGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzddLCJlcnJvck1lc3NhZ2UiOiJQYXllZSBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNzFdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IGFzc2V0IG11c3QgYmUgVVNEQyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3MiwxMTYzXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGJlIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1NV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM0XSwiZXJyb3JNZXNzYWdlIjoiU2V0dGxlbWVudCBMb2dpY1NpZyBub3Qgc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwXSwiZXJyb3JNZXNzYWdlIjoiU2lnbmVyIGhhc2ggbXVzdCBiZSAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2NF0sImVycm9yTWVzc2FnZSI6IlZvdWNoZXIgZXhjZWVkcyBkZXBvc2l0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU1LDE3MSwxOTAsMzg2LDQ0Myw0NTksNTM2LDU4OCw3MjQsNzY1LDgwNCw5MDgsOTU0LDEwMzAsMTA0NiwxMDk4LDExMTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0QUFDRjg1MTAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjIsMTc4LDE5NywzOTMsNDUwLDQ2Niw1NDMsNTk1LDczMSw3NzIsODExLDkxNSw5NjEsMTAzNywxMDUzLDExMDUsMTEyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzYsNTU0LDEwMTYsMTAyNCwxMDg0LDEwOTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjExXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ5LDQwN10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJjYmxvY2tzIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURJZ1ZFMVFURjlWVTBSRFgwRlRVMFZVWDBsRUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVd01ESXdJQ0pzSWlBd2VERTFNV1kzWXpjMUlDSndJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTWpFS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5EaGtOVE5sTXpJZ01IaGlaR05tWVdNMU9DQXdlRFJpTVdSaVlqWTNJREI0TkRKa09UYzFZVFlnTUhnME16bGpOV1ppTVNBd2VHVTRObUZsT1dVNUlEQjRNelEyT0RVd05UQWdNSGcxT1RBMVpEUm1OQ0F3ZUdGaE1UUmpOR1k1SURCNE4yVXpaalJoTmpnZ01IaGhPRGN3TkRrd015QXdlREZsT1dNd01Ea3dJREI0T0dNMFkyWmpaamNnTUhneVltWTJNRGxsTUNBdkx5QnRaWFJvYjJRZ0ltOXdaVzRvWVdSa2NtVnpjeXhoZUdabGNpeGllWFJsVzEwc1lubDBaVnRkTEdKNWRHVmJYU2xpZVhSbFcxMGlMQ0J0WlhSb2IyUWdJblJ2Y0ZWd0tHSjVkR1ZiWFN4aGVHWmxjaWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJCZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVLR0o1ZEdWYlhTeGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFUyVjBkR3hsYldWdWRFeHZaMmxqVTJsbktHSjVkR1ZiWFN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEhSc1pVWnliMjFNYjJkcFkxTnBaeWhpZVhSbFcxMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Oc2IzTmxLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYRjFaWE4wUTJ4dmMyVW9ZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5kcGRHaGtjbUYzS0dKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSm1kVzVrVFdKeVVHOXZiQ2dvWVdSa2NtVnpjeWtwZG05cFpDSXNJRzFsZEdodlpDQWliM0IwU1c1VmMyUmpLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJUWlhOemFXOXVVM1JoZEdsalJHRjBZU2hpZVhSbFcxMHBLSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJUWlhOemFXOXVSSGx1WVcxcFkwUmhkR0VvWW5sMFpWdGRLU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltTnZiWEIxZEdWRGFHRnVibVZzU1dRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKNWRHVmJYU3hpZVhSbFcxMHBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSmtaWEpwZG1WRGFHRnVibVZzU1dRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKNWRHVmJYU3hpZVhSbFcxMHBZbmwwWlZ0ZElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diM0JsYmlCMGIzQlZjQ0J6WlhSQmRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1SUhObGRGTmxkSFJzWlcxbGJuUk1iMmRwWTFOcFp5QnpaWFIwYkdWR2NtOXRURzluYVdOVGFXY2dZMnh2YzJVZ2NtVnhkV1Z6ZEVOc2IzTmxJSGRwZEdoa2NtRjNJR1oxYm1STlluSlFiMjlzSUc5d2RFbHVWWE5rWXlCblpYUlRaWE56YVc5dVUzUmhkR2xqUkdGMFlTQm5aWFJUWlhOemFXOXVSSGx1WVcxcFkwUmhkR0VnWTI5dGNIVjBaVU5vWVc1dVpXeEpaQ0JrWlhKcGRtVkRhR0Z1Ym1Wc1NXUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkM1dmNHVnVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCbGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMExUY3hDaUFnSUNBdkx5QnZjR1Z1S0FvZ0lDQWdMeThnSUNCd1lYbGxaVG9nUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWkdWd2IzTnBkRG9nWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUxBb2dJQ0FnTHk4Z0lDQnpZV3gwT2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjam9nWW5sMFpYTXNDaUFnSUNBdkx5QWdJR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYazZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0NpQWdJQ0F2THlBcE9pQmllWFJsY3lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOeklLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhkWFJvYjNKcGVtVmtVMmxuYm1WeUxteGxibWQwYUNBOVBUMGdNeklzSUNkVGFXZHVaWElnYUdGemFDQnRkWE4wSUdKbElETXlJR0o1ZEdWekp5a0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEWUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUYVdkdVpYSWdhR0Z6YUNCdGRYTjBJR0psSURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdZMjl1YzNRZ1kyaGhibTVsYkVsa0lEMGdkR2hwY3k1a1pYSnBkbVZEYUdGdWJtVnNTV1FvVkhodUxuTmxibVJsY2l3Z2NHRjVaV1VzSUdGMWRHaHZjbWw2WldSVGFXZHVaWElzSUhOaGJIUXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RFS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1emFHRXlOVFlvY0dGNVpYSXVZbmwwWlhNdVkyOXVZMkYwS0hCaGVXVmxMbUo1ZEdWektTNWpiMjVqWVhRb2IzQXVhWFJ2WWloVlUwUkRYMEZUVTBWVVgwbEVLU2t1WTI5dVkyRjBLSE5oYkhRcExtTnZibU5oZENoaGRYUm9iM0pwZW1Wa1UybG5ibVZ5S1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlUwUkRYMEZUVTBWVVgwbEVDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnYVdZZ0tDRmphR0Z1Ym1Wc0xtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nYjNCbGJsOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJ6ZEdGeWRGSnZkVzVrT2lCdmNDNUhiRzlpWVd3dWNtOTFibVFzQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QnpkR0Z5ZEZScGJXVnpkR0Z0Y0RvZ2IzQXVSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0N3S0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJ3WVhsbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNExUZzRDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhPaUJEYUdGdWJtVnNTVzVtYnlBOUlIc0tJQ0FnSUM4dklDQWdjR0Y1WlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJSEJoZVdWbExBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeUxBb2dJQ0FnTHk4Z0lDQjBiM1JoYkVSbGNHOXphWFE2SURBc0NpQWdJQ0F2THlBZ0lHeGhjM1JUWlhSMGJHVmtPaUF3TEFvZ0lDQWdMeThnSUNCc1lYUmxjM1JXYjNWamFHVnlRVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0J6ZEdGeWRGSnZkVzVrT2lCdmNDNUhiRzlpWVd3dWNtOTFibVFzQ2lBZ0lDQXZMeUFnSUhOMFlYSjBWR2x0WlhOMFlXMXdPaUJ2Y0M1SGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0JqYkc5elpWSmxjWFZsYzNSbFpFRjBPaUF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdaR2xuSURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TnpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUhSdmRHRnNSR1Z3YjNOcGREb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09DMDRPQW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZVG9nUTJoaGJtNWxiRWx1Wm04Z1BTQjdDaUFnSUNBdkx5QWdJSEJoZVdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J3WVhsbFpTd0tJQ0FnSUM4dklDQWdZWFYwYUc5eWFYcGxaRk5wWjI1bGNpd0tJQ0FnSUM4dklDQWdkRzkwWVd4RVpYQnZjMmwwT2lBd0xBb2dJQ0FnTHk4Z0lDQnNZWE4wVTJWMGRHeGxaRG9nTUN3S0lDQWdJQzh2SUNBZ2JHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnYzNSaGNuUlNiM1Z1WkRvZ2IzQXVSMnh2WW1Gc0xuSnZkVzVrTEFvZ0lDQWdMeThnSUNCemRHRnlkRlJwYldWemRHRnRjRG9nYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ3dLSUNBZ0lDOHZJQ0FnWTJ4dmMyVlNaWEYxWlhOMFpXUkJkRG9nTUN3S0lDQWdJQzh2SUgwS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUIwYUdsekxuTmxkRUYxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYbEpabEJ5YjNacFpHVmtLR05vWVc1dVpXeEpaQ3dnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlU3dnWVhWMGFHOXlhWHBsWkZOcFoyNWxjaWtLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJSE5sZEVGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGxKWmxCeWIzWnBaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdkR2hwY3k1aGNIQnNlVlJ2Y0ZWd0tHUmhkR0VzSUdSbGNHOXphWFFwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWVhCd2JIbFViM0JWY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEVLSUNBZ0lDOHZJR05vWVc1dVpXd3VkbUZzZFdVZ1BTQmpiRzl1WlNoa1lYUmhLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0tiM0JsYmw5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdRdWIzQmxia0EwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalF0TnpFS0lDQWdJQzh2SUc5d1pXNG9DaUFnSUNBdkx5QWdJSEJoZVdWbE9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmtaWEJ2YzJsME9pQm5kSGh1TGtGemMyVjBWSEpoYm5ObVpYSlVlRzRzQ2lBZ0lDQXZMeUFnSUhOaGJIUTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeU9pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVRvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFLSUNBZ0lDOHZJQ2s2SUdKNWRHVnpJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TWpBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiM0JsYmw5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdjbVZ2Y0dWdUlHTm9ZVzV1Wld3bktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFV0T1RZS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCeVpXOXdaVzRnWTJoaGJtNWxiQ2NwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsYjNCbGJpQmphR0Z1Ym1Wc0p5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQndZWGxsY2lCallXNGdjbVZ2Y0dWdUlHTm9ZVzV1Wld3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamszQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1WldVZ1BUMDlJR1JoZEdFdWNHRjVaV1VzSUNkUVlYbGxaU0J0YVhOdFlYUmphQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2FXY2dPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbGxaU0J0YVhOdFlYUmphQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoaGRYUm9iM0pwZW1Wa1UybG5ibVZ5SUQwOVBTQmtZWFJoTG1GMWRHaHZjbWw2WldSVGFXZHVaWElzSUNkQmRYUm9iM0pwZW1Wa0lITnBaMjVsY2lCb1lYTm9JRzFwYzIxaGRHTm9KeWtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMk5DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURjS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUYxZEdodmNtbDZaV1FnYzJsbmJtVnlJR2hoYzJnZ2JXbHpiV0YwWTJnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnZEdocGN5NXpaWFJCZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVTV1pRY205MmFXUmxaQ2hqYUdGdWJtVnNTV1FzSUdGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGtzSUdSaGRHRXVZWFYwYUc5eWFYcGxaRk5wWjI1bGNpa0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCMGFHbHpMbUZ3Y0d4NVZHOXdWWEFvWkdGMFlTd2daR1Z3YjNOcGRDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQmhjSEJzZVZSdmNGVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ESUtJQ0FnSUM4dklHTm9ZVzV1Wld3dWRtRnNkV1VnUFNCamJHOXVaU2hrWVhSaEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalF0TnpFS0lDQWdJQzh2SUc5d1pXNG9DaUFnSUNBdkx5QWdJSEJoZVdWbE9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmtaWEJ2YzJsME9pQm5kSGh1TGtGemMyVjBWSEpoYm5ObVpYSlVlRzRzQ2lBZ0lDQXZMeUFnSUhOaGJIUTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeU9pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVRvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFLSUNBZ0lDOHZJQ2s2SUdKNWRHVnpJSHNLSUNBZ0lHSWdiM0JsYmw5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdRdWIzQmxia0EwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkM1MGIzQlZjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SdmNGVndPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5QjBiM0JWY0NoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCamRXMTFiR0YwYVhabFFXMXZkVzUwT2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRJS0lDQWdJQzh2SUdGemMyVnlkQ2hqYUdGdWJtVnNMbVY0YVhOMGN5d2dKME5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnWTI5dWMzUWdaR0YwWVNBOUlHTnNiMjVsS0dOb1lXNXVaV3d1ZG1Gc2RXVXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2RHOXdJSFZ3SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOQzB4TVRVS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCMGIzQWdkWEFuS1FvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnZEc5d0lIVndKeWtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J3WVhsbGNpQmpZVzRnZEc5d0lIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UY0tJQ0FnSUM4dklIUm9hWE11WVhCd2JIbFViM0JWY0Noa1lYUmhMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBLUW9nSUNBZ1kyRnNiSE4xWWlCaGNIQnNlVlJ2Y0ZWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUdOb1lXNXVaV3d1ZG1Gc2RXVWdQU0JqYkc5dVpTaGtZWFJoS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5QjBiM0JWY0NoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCamRXMTFiR0YwYVhabFFXMXZkVzUwT2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwU0hsaWNtbGtMbk5sZEVGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhrNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOZ29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCelpYUWdZWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJNExURXlPUW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSE5sZENCaGRYUm9iM0pwZW1Wa0lITnBaMjVsY2ljcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCelpYUWdZWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSW5LUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJoZVdWeUlHTmhiaUJ6WlhRZ1lYVjBhRzl5YVhwbFpDQnphV2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TUFvZ0lDQWdMeThnWVhOelpYSjBLR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa3ViR1Z1WjNSb0lENGdNQ3dnSjBGMWRHaHZjbWw2WldRZ2MybG5ibVZ5SUhCMVltdGxlU0J5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklFRjFkR2h2Y21sNlpXUWdjMmxuYm1WeUlIQjFZbXRsZVNCeVpYRjFhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJqYjI1emRDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVNHRnphQ0E5SUhOb1lUVXhNbDh5TlRZb1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNrS0lDQWdJR1IxY0FvZ0lDQWdjMmhoTlRFeVh6STFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXpDaUFnSUNBdkx5QjBhR2x6TG5ObGRFRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhsSlpsQnliM1pwWkdWa0tHTm9ZVzV1Wld4SlpDd2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTd2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNraGhjMmdwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCa1lYUmhMbUYxZEdodmNtbDZaV1JUYVdkdVpYSWdQU0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlTR0Z6YUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBMk5DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTJDaUFnSUNBdkx5QmphR0Z1Ym1Wc0xuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnYzJWMFFYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1T2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1F1YzJWMFUyVjBkR3hsYldWdWRFeHZaMmxqVTJsblczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVTJWMGRHeGxiV1Z1ZEV4dloybGpVMmxuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEwQ2lBZ0lDQXZMeUJ6WlhSVFpYUjBiR1Z0Wlc1MFRHOW5hV05UYVdjb1kyaGhibTVsYkVsa09pQmllWFJsY3l3Z2JHOW5hV05UYVdjNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5nb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSE5sZENCTWIyZHBZMU5wWnljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGd0TVRRNUNpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2MyVjBJRXh2WjJsalUybG5KeWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSE5sZENCTWIyZHBZMU5wWnljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NHRjVaWElnWTJGdUlITmxkQ0JNYjJkcFkxTnBad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5QmhjM05sY25Rb2JHOW5hV05UYVdjZ0lUMDlJRUZqWTI5MWJuUW9LU3dnSjB4dloybGpVMmxuSUdGalkyOTFiblFnY21WeGRXbHlaV1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnVEc5bmFXTlRhV2NnWVdOamIzVnVkQ0J5WlhGMWFYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklITmxkSFJzWlcxbGJuUk1iMmRwWTFOcFp5QTlJRUp2ZUUxaGNEeGllWFJsY3l3Z1FXTmpiM1Z1ZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RzSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJDSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUhSb2FYTXVjMlYwZEd4bGJXVnVkRXh2WjJsalUybG5LR05vWVc1dVpXeEpaQ2t1ZG1Gc2RXVWdQU0JzYjJkcFkxTnBad29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEwQ2lBZ0lDQXZMeUJ6WlhSVFpYUjBiR1Z0Wlc1MFRHOW5hV05UYVdjb1kyaGhibTVsYkVsa09pQmllWFJsY3l3Z2JHOW5hV05UYVdjNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBTSGxpY21sa0xuTmxkSFJzWlVaeWIyMU1iMmRwWTFOcFoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEhSc1pVWnliMjFNYjJkcFkxTnBaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdjMlYwZEd4bFJuSnZiVXh2WjJsalUybG5LR05vWVc1dVpXeEpaRG9nWW5sMFpYTXNJR04xYlhWc1lYUnBkbVZCYlc5MWJuUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1nb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMENpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCelpYUjBiR1Z0Wlc1MFRHOW5hV05UYVdjZ1BTQkNiM2hOWVhBOFlubDBaWE1zSUVGalkyOTFiblErS0hzZ2EyVjVVSEpsWm1sNE9pQW5iQ2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW13aUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qWUtJQ0FnSUM4dklHRnpjMlZ5ZENoc2IyZHBZMU5wWnk1bGVHbHpkSE1zSUNkVFpYUjBiR1Z0Wlc1MElFeHZaMmxqVTJsbklHNXZkQ0J6WlhRbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRaWFIwYkdWdFpXNTBJRXh2WjJsalUybG5JRzV2ZENCelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk53b2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR3h2WjJsalUybG5MblpoYkhWbExDQW5UMjVzZVNCelpYUjBiR1Z0Wlc1MElFeHZaMmxqVTJsbklHTmhiaUJ6WlhSMGJHVW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djMlYwZEd4bGJXVnVkQ0JNYjJkcFkxTnBaeUJqWVc0Z2MyVjBkR3hsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpkVzExYkdGMGFYWmxRVzF2ZFc1MElENGdaR0YwWVM1c1lYTjBVMlYwZEd4bFpDd2dKMDV2ZEdocGJtY2dibVYzSUhSdklITmxkSFJzWlNjcENpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkSE1nTnpRZ09DQXZMeUEzTkN3Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0RJS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1JvYVc1bklHNWxkeUIwYnlCelpYUjBiR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVOd29nSUNBZ0x5OGdZWE56WlhKMEtHTjFiWFZzWVhScGRtVkJiVzkxYm5RZ1BEMGdaR0YwWVM1MGIzUmhiRVJsY0c5emFYUXNJQ2RXYjNWamFHVnlJR1Y0WTJWbFpITWdaR1Z3YjNOcGRDY3BDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZEhNZ05qWWdPQ0F2THlBMk5pd2dPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZadmRXTm9aWElnWlhoalpXVmtjeUJrWlhCdmMybDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Ua0tJQ0FnSUM4dklHTnZibk4wSUhCaGVXOTFkRG9nZFdsdWREWTBJRDBnWTNWdGRXeGhkR2wyWlVGdGIzVnVkQ0F0SUdSaGRHRXViR0Z6ZEZObGRIUnNaV1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1EQXRNekEwQ2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCNFptVnlRWE56WlhRNklFRnpjMlYwS0ZWVFJFTmZRVk5UUlZSZlNVUXBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmtZWFJoTG5CaGVXVmxMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ2NHRjViM1YwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdNUW9nSUNBZ0x5OGdlR1psY2tGemMyVjBPaUJCYzNObGRDaFZVMFJEWDBGVFUwVlVYMGxFS1N3S0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlRSRU5mUVZOVFJWUmZTVVFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdNZ29nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1pHRjBZUzV3WVhsbFpTd0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1EQXRNekEwQ2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCNFptVnlRWE56WlhRNklFRnpjMlYwS0ZWVFJFTmZRVk5UUlZSZlNVUXBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmtZWFJoTG5CaGVXVmxMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ2NHRjViM1YwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1EWUtJQ0FnSUM4dklHUmhkR0V1YkdGemRGTmxkSFJzWldRZ1BTQmpkVzExYkdGMGFYWmxRVzF2ZFc1MENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCeVpYQnNZV05sTWlBM05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1EY0tJQ0FnSUM4dklHbG1JQ2hqZFcxMWJHRjBhWFpsUVcxdmRXNTBJRDRnWkdGMFlTNXNZWFJsYzNSV2IzVmphR1Z5UVcxdmRXNTBLU0I3Q2lBZ0lDQndkWE5vYVc1MElEZ3lJQzh2SURneUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUGdvZ0lDQWdZbm9nYzJWMGRHeGxSbkp2YlV4dloybGpVMmxuWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QTRDaUFnSUNBdkx5QmtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RZ1BTQmpkVzExYkdGMGFYWmxRVzF2ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY21Wd2JHRmpaVElnT0RJS0NuTmxkSFJzWlVaeWIyMU1iMmRwWTFOcFoxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpBS0lDQWdJQzh2SUdOb1lXNXVaV3d1ZG1Gc2RXVWdQU0JqYkc5dVpTaGtZWFJoS1FvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklITmxkSFJzWlVaeWIyMU1iMmRwWTFOcFp5aGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWekxDQmpkVzExYkdGMGFYWmxRVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBTSGxpY21sa0xtTnNiM05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyeHZjMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOemNLSUNBZ0lDOHZJR05zYjNObEtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56a0tJQ0FnSUM4dklHRnpjMlZ5ZENoamFHRnVibVZzTG1WNGFYTjBjeXdnSjBOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RFS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNd29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WldVc0lDZFBibXg1SUhCaGVXVmxJR05oYmlCamJHOXpaU2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NHRjVaV1VnWTJGdUlHTnNiM05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFVLSUNBZ0lDOHZJSFJvYVhNdVptbHVZV3hwZW1WRGFHRnVibVZzS0dOb1lXNXVaV3hKWkN3Z1pHRjBZU2tLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1ptbHVZV3hwZW1WRGFHRnVibVZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOd29nSUNBZ0x5OGdZMnh2YzJVb1kyaGhibTVsYkVsa09pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdRdWNtVnhkV1Z6ZEVOc2IzTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WeGRXVnpkRU5zYjNObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCeVpYRjFaWE4wUTJ4dmMyVW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVNd29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU5nb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaWElzSUNkUGJteDVJSEJoZVdWeUlHTmhiaUJ5WlhGMVpYTjBJR05zYjNObEp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TlMweE9UWUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnlaWEYxWlhOMElHTnNiM05sSnlrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazJDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsY2l3Z0owOXViSGtnY0dGNVpYSWdZMkZ1SUhKbGNYVmxjM1FnWTJ4dmMyVW5LUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJoZVdWeUlHTmhiaUJ5WlhGMVpYTjBJR05zYjNObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RnS0lDQWdJQzh2SUdSaGRHRXVZMnh2YzJWU1pYRjFaWE4wWldSQmRDQTlJRzl3TGtkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU9DMHhPVGtLSUNBZ0lDOHZJR1JoZEdFdVkyeHZjMlZTWlhGMVpYTjBaV1JCZENBOUlHOXdMa2RzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUdOb1lXNXVaV3d1ZG1Gc2RXVWdQU0JqYkc5dVpTaGtZWFJoS1FvZ0lDQWdjSFZ6YUdsdWRDQXhNRFlnTHk4Z01UQTJDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCeVpYRjFaWE4wUTJ4dmMyVW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUXVkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOZ29nSUNBZ0x5OGdkMmwwYUdSeVlYY29ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdPQW9nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakV4Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIZHBkR2hrY21GM0p5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TUMweU1URUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjNhWFJvWkhKaGR5Y3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TVFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjNhWFJvWkhKaGR5Y3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djR0Y1WlhJZ1kyRnVJSGRwZEdoa2NtRjNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1USUtJQ0FnSUM4dklHRnpjMlZ5ZENoa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdQaUF3TENBblEyeHZjMlVnYm05MElISmxjWFZsYzNSbFpDY3BDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblJ6SURFd05pQTRJQzh2SURFd05pd2dPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUVOc2IzTmxJRzV2ZENCeVpYRjFaWE4wWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TkFvZ0lDQWdMeThnYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0ErUFNCa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdLeUJEVEU5VFJWOUhVa0ZEUlY5UVJWSkpUMFJmVTBWRFQwNUVVeXdLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ09EZzRJQzh2SURnNE9Bb2dJQ0FnS3dvZ0lDQWdQajBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhNeTB5TVRZS0lDQWdJQzh2SUdGemMyVnlkQ2dLSUNBZ0lDOHZJQ0FnYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0ErUFNCa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdLeUJEVEU5VFJWOUhVa0ZEUlY5UVJWSkpUMFJmVTBWRFQwNUVVeXdLSUNBZ0lDOHZJQ0FnSjBOc2IzTmxJR2R5WVdObElIQmxjbWx2WkNCdWIzUWdaV3hoY0hObFpDY3NDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1EyeHZjMlVnWjNKaFkyVWdjR1Z5YVc5a0lHNXZkQ0JsYkdGd2MyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UZ0tJQ0FnSUM4dklIUm9hWE11Wm1sdVlXeHBlbVZEYUdGdWJtVnNLR05vWVc1dVpXeEpaQ3dnWkdGMFlTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWm1sdVlXeHBlbVZEYUdGdWJtVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd05nb2dJQ0FnTHk4Z2QybDBhR1J5WVhjb1kyaGhibTVsYkVsa09pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdRdVpuVnVaRTFpY2xCdmIyeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtZFc1a1RXSnlVRzl2YkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TkFvZ0lDQWdMeThnWm5WdVpFMWljbEJ2YjJ3b2NHRjViV1Z1ZERvZ2V5QnlaV05sYVhabGNqb2dRV05qYjNWdWRDQjlLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJQWW1wbFkzUkJRVU5HT0RVeE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJMUNpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ2IzQXVSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0lDZFFZWGx0Wlc1MElHMTFjM1FnWW1VZ2RHOGdZMjl1ZEhKaFkzUW5LUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z1kyOXVkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TkFvZ0lDQWdMeThnWm5WdVpFMWljbEJ2YjJ3b2NHRjViV1Z1ZERvZ2V5QnlaV05sYVhabGNqb2dRV05qYjNWdWRDQjlLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEVoNVluSnBaQzV2Y0hSSmJsVnpaR05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNIUkpibFZ6WkdNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXpNS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQnZjQzVIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lDZFBibXg1SUdOeVpXRjBiM0lnWTJGdUlHOXdkQ0JwYmlCVlUwUkRKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJRzl3ZENCcGJpQlZVMFJEQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNelV0TWpNNUNpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJ2Y0M1SGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNMkNpQWdJQ0F2THlCNFptVnlRWE56WlhRNklFRnpjMlYwS0ZWVFJFTmZRVk5UUlZSZlNVUXBMQW9nSUNBZ2FXNTBZeUEwSUM4dklGUk5VRXhmVlZORVExOUJVMU5GVkY5SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNM0NpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJ2Y0M1SGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNemdLSUNBZ0lDOHZJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TlMweU16a0tJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUc5d0xrZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNeUNpQWdJQ0F2THlCdmNIUkpibFZ6WkdNb0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRWg1WW5KcFpDNW5aWFJUWlhOemFXOXVVM1JoZEdsalJHRjBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGTmxjM05wYjI1VGRHRjBhV05FWVhSaE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRMkNpQWdJQ0F2THlCblpYUlRaWE56YVc5dVUzUmhkR2xqUkdGMFlTaGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWektUb2dXM1ZwYm5RMk5Dd2dkV2x1ZERZMFhTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalE0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZMmhoYm01bGJDNWxlR2x6ZEhNc0lDZERhR0Z1Ym1Wc0lHUnZaWE1nYm05MElHVjRhWE4wSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVXdMVEkxTVFvZ0lDQWdMeThnWTI5dWMzUWdaR0YwWVNBOUlHTnNiMjVsS0dOb1lXNXVaV3d1ZG1Gc2RXVXBDaUFnSUNBdkx5QnlaWFIxY200Z1cyUmhkR0V1YzNSaGNuUlNiM1Z1WkN3Z1pHRjBZUzV6ZEdGeWRGUnBiV1Z6ZEdGdGNGMEtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkSE1nT1RBZ09DQXZMeUE1TUN3Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTVFvZ0lDQWdMeThnY21WMGRYSnVJRnRrWVhSaExuTjBZWEowVW05MWJtUXNJR1JoZEdFdWMzUmhjblJVYVcxbGMzUmhiWEJkQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVEF0TWpVeENpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lDOHZJSEpsZEhWeWJpQmJaR0YwWVM1emRHRnlkRkp2ZFc1a0xDQmtZWFJoTG5OMFlYSjBWR2x0WlhOMFlXMXdYUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZEhNZ09UZ2dPQ0F2THlBNU9Dd2dPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0a1lYUmhMbk4wWVhKMFVtOTFibVFzSUdSaGRHRXVjM1JoY25SVWFXMWxjM1JoYlhCZENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME5nb2dJQ0FnTHk4Z1oyVjBVMlZ6YzJsdmJsTjBZWFJwWTBSaGRHRW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJRnQxYVc1ME5qUXNJSFZwYm5RMk5GMGdld29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1F1WjJWMFUyVnpjMmx2YmtSNWJtRnRhV05FWVhSaFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwVTJWemMybHZia1I1Ym1GdGFXTkVZWFJoT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalU0Q2lBZ0lDQXZMeUJuWlhSVFpYTnphVzl1UkhsdVlXMXBZMFJoZEdFb1kyaGhibTVsYkVsa09pQmllWFJsY3lrNklGdDFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwWFNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWXdDaUFnSUNBdkx5QmhjM05sY25Rb1kyaGhibTVsYkM1bGVHbHpkSE1zSUNkRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZeUxUSTJNd29nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0F2THlCeVpYUjFjbTRnVzJSaGRHRXVkRzkwWVd4RVpYQnZjMmwwTENCa1lYUmhMbXhoYzNSVFpYUjBiR1ZrTENCa1lYUmhMbXhoZEdWemRGWnZkV05vWlhKQmJXOTFiblJkQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5SeklEWTJJRGdnTHk4Z05qWXNJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qTUtJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzUwYjNSaGJFUmxjRzl6YVhRc0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZEYwS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTWkweU5qTUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnY21WMGRYSnVJRnRrWVhSaExuUnZkR0ZzUkdWd2IzTnBkQ3dnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQ3dnWkdGMFlTNXNZWFJsYzNSV2IzVmphR1Z5UVcxdmRXNTBYUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5SeklEYzBJRGdnTHk4Z056UXNJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qTUtJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzUwYjNSaGJFUmxjRzl6YVhRc0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZEYwS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTWkweU5qTUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnY21WMGRYSnVJRnRrWVhSaExuUnZkR0ZzUkdWd2IzTnBkQ3dnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQ3dnWkdGMFlTNXNZWFJsYzNSV2IzVmphR1Z5UVcxdmRXNTBYUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBjeUE0TWlBNElDOHZJRGd5TENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNall6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMlJoZEdFdWRHOTBZV3hFWlhCdmMybDBMQ0JrWVhSaExteGhjM1JUWlhSMGJHVmtMQ0JrWVhSaExteGhkR1Z6ZEZadmRXTm9aWEpCYlc5MWJuUmRDaUFnSUNCaWRHOXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxT0FvZ0lDQWdMeThnWjJWMFUyVnpjMmx2YmtSNWJtRnRhV05FWVhSaEtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNcE9pQmJkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkYwZ2V3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUXVZMjl0Y0hWMFpVTm9ZVzV1Wld4SlpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52YlhCMWRHVkRhR0Z1Ym1Wc1NXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56QUtJQ0FnSUM4dklHTnZiWEIxZEdWRGFHRnVibVZzU1dRb2NHRjVaWEk2SUVGalkyOTFiblFzSUhCaGVXVmxPaUJCWTJOdmRXNTBMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlPaUJpZVhSbGN5d2djMkZzZERvZ1lubDBaWE1wT2lCaWVYUmxjeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9ERUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNXphR0V5TlRZb2NHRjVaWEl1WW5sMFpYTXVZMjl1WTJGMEtIQmhlV1ZsTG1KNWRHVnpLUzVqYjI1allYUW9iM0F1YVhSdllpaFZVMFJEWDBGVFUwVlVYMGxFS1NrdVkyOXVZMkYwS0hOaGJIUXBMbU52Ym1OaGRDaGhkWFJvYjNKcGVtVmtVMmxuYm1WeUtTa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWVFJFTmZRVk5UUlZSZlNVUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjd0NpQWdJQ0F2THlCamIyMXdkWFJsUTJoaGJtNWxiRWxrS0hCaGVXVnlPaUJCWTJOdmRXNTBMQ0J3WVhsbFpUb2dRV05qYjNWdWRDd2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNqb2dZbmwwWlhNc0lITmhiSFE2SUdKNWRHVnpLVG9nWW5sMFpYTWdld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFNREF5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBTSGxpY21sa0xtUmxjbWwyWlVOb1lXNXVaV3hKWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxjbWwyWlVOb1lXNXVaV3hKWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzT0FvZ0lDQWdMeThnWkdWeWFYWmxRMmhoYm01bGJFbGtLSEJoZVdWeU9pQkJZMk52ZFc1MExDQndZWGxsWlRvZ1FXTmpiM1Z1ZEN3Z1lYVjBhRzl5YVhwbFpGTnBaMjVsY2pvZ1lubDBaWE1zSUhOaGJIUTZJR0o1ZEdWektUb2dZbmwwWlhNZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamd4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1YzJoaE1qVTJLSEJoZVdWeUxtSjVkR1Z6TG1OdmJtTmhkQ2h3WVhsbFpTNWllWFJsY3lrdVkyOXVZMkYwS0c5d0xtbDBiMklvVlZORVExOUJVMU5GVkY5SlJDa3BMbU52Ym1OaGRDaHpZV3gwS1M1amIyNWpZWFFvWVhWMGFHOXlhWHBsWkZOcFoyNWxjaWtwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNPQW9nSUNBZ0x5OGdaR1Z5YVhabFEyaGhibTVsYkVsa0tIQmhlV1Z5T2lCQlkyTnZkVzUwTENCd1lYbGxaVG9nUVdOamIzVnVkQ3dnWVhWMGFHOXlhWHBsWkZOcFoyNWxjam9nWW5sMFpYTXNJSE5oYkhRNklHSjVkR1Z6S1RvZ1lubDBaWE1nZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxTURBeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwU0hsaWNtbGtMbUZ3Y0d4NVZHOXdWWEFvWkdGMFlUb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtRndjR3g1Vkc5d1ZYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1USUtJQ0FnSUM4dklIQnlhWFpoZEdVZ1lYQndiSGxVYjNCVmNDaGtZWFJoT2lCRGFHRnVibVZzU1c1bWJ5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2daM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0dOMWJYVnNZWFJwZG1WQmJXOTFiblF1YzJWdVpHVnlJRDA5UFNCVWVHNHVjMlZ1WkdWeUxDQW5VR0Y1YldWdWRDQnpaVzVrWlhJZ2JXbHpiV0YwWTJnbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhOQW9nSUNBZ0x5OGdZWE56WlhKMEtHTjFiWFZzWVhScGRtVkJiVzkxYm5RdVlYTnpaWFJTWldObGFYWmxjaUE5UFQwZ2IzQXVSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0lDZFFZWGx0Wlc1MElHMTFjM1FnWW1VZ2RHOGdZMjl1ZEhKaFkzUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhOUW9nSUNBZ0x5OGdZWE56WlhKMEtHTjFiWFZzWVhScGRtVkJiVzkxYm5RdWVHWmxja0Z6YzJWMExtbGtJRDA5UFNCVlUwUkRYMEZUVTBWVVgwbEVMQ0FuVUdGNWJXVnVkQ0JoYzNObGRDQnRkWE4wSUdKbElGVlRSRU1uS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCWVptVnlRWE56WlhRS0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlRSRU5mUVZOVFJWUmZTVVFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCaGMzTmxkQ0J0ZFhOMElHSmxJRlZUUkVNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TmdvZ0lDQWdMeThnWVhOelpYSjBLR04xYlhWc1lYUnBkbVZCYlc5MWJuUXVZWE56WlhSQmJXOTFiblFnUGlBd0xDQW5SR1Z3YjNOcGRDQnRkWE4wSUdKbElENGdNQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJFWlhCdmMybDBJRzExYzNRZ1ltVWdQaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpkVzExYkdGMGFYWmxRVzF2ZFc1MExtRnpjMlYwVTJWdVpHVnlJRDA5UFNCQlkyTnZkVzUwS0Nrc0lDZERiR0YzWW1GamF5QjBjbUZ1YzJabGNpQnViM1FnWVd4c2IzZGxaQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1EyeGhkMkpoWTJzZ2RISmhibk5tWlhJZ2JtOTBJR0ZzYkc5M1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeE9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOMWJYVnNZWFJwZG1WQmJXOTFiblF1WVhOelpYUkRiRzl6WlZSdklEMDlQU0JCWTJOdmRXNTBLQ2tzSUNkQmMzTmxkQ0JqYkc5elpTQnViM1FnWVd4c2IzZGxaQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBRMnh2YzJWVWJ3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRnpjMlYwSUdOc2IzTmxJRzV2ZENCaGJHeHZkMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNakFLSUNBZ0lDOHZJR1JoZEdFdWRHOTBZV3hFWlhCdmMybDBJQ3M5SUdOMWJYVnNZWFJwZG1WQmJXOTFiblF1WVhOelpYUkJiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQTJOaUF2THlBMk5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOallLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlNZ29nSUNBZ0x5OGdaR0YwWVM1amJHOXpaVkpsY1hWbGMzUmxaRUYwSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNVEEyQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdRdVptbHVZV3hwZW1WRGFHRnVibVZzS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUdSaGRHRTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tabWx1WVd4cGVtVkRhR0Z1Ym1Wc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJMUNpQWdJQ0F2THlCd2NtbDJZWFJsSUdacGJtRnNhWHBsUTJoaGJtNWxiQ2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JrWVhSaE9pQkRhR0Z1Ym1Wc1NXNW1ieWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlOZ29nSUNBZ0x5OGdZMjl1YzNRZ2NHRjVaV1ZRWVhsdmRYUTZJSFZwYm5RMk5DQTlJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRDQXRJR1JoZEdFdWJHRnpkRk5sZEhSc1pXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0E0TWlBdkx5QTRNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURjMElDOHZJRGMwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qY0tJQ0FnSUM4dklHbG1JQ2h3WVhsbFpWQmhlVzkxZENBK0lEQXBJSHNLSUNBZ0lHSjZJR1pwYm1Gc2FYcGxRMmhoYm01bGJGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15T0Mwek16SUtJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdSaGRHRXVjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUJ3WVhsbFpWQmhlVzkxZEN3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNamtLSUNBZ0lDOHZJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNekFLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpXVXNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWpndE16TXlDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUVGemMyVjBLRlZUUkVOZlFWTlRSVlJmU1VRcExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCa1lYUmhMbkJoZVdWbExBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nY0dGNVpXVlFZWGx2ZFhRc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLQ21acGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16VUtJQ0FnSUM4dklHTnZibk4wSUhCaGVXVnlVbVZtZFc1a09pQjFhVzUwTmpRZ1BTQmtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDQXRJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRFkySUM4dklEWTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNellLSUNBZ0lDOHZJR2xtSUNod1lYbGxjbEpsWm5WdVpDQStJREFwSUhzS0lDQWdJR0o2SUdacGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNek55MHpOREVLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpYSXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbGxjbEpsWm5WdVpDd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXpnS0lDQWdJQzh2SUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlWVTBSRFgwRlRVMFZVWDBsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXprS0lDQWdJQzh2SUdGemMyVjBVbVZqWldsMlpYSTZJR1JoZEdFdWNHRjVaWElzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNek55MHpOREVLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpYSXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbGxjbEpsWm5WdVpDd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1ptbHVZV3hwZW1WRGFHRnVibVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdkR2hwY3k1amFHRnVibVZzY3loamFHRnVibVZzU1dRcExtUmxiR1YwWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGtnUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJR0o1ZEdWelBpaDdJR3RsZVZCeVpXWnBlRG9nSjNBbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5EWUtJQ0FnSUM4dklHbG1JQ2h6YVdkdVpYSlFkV0pzYVdOTFpYa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdacGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME53b2dJQ0FnTHk4Z2MybG5ibVZ5VUhWaWJHbGpTMlY1TG1SbGJHVjBaU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2dwbWFXNWhiR2w2WlVOb1lXNXVaV3hmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklITmxkSFJzWlcxbGJuUk1iMmRwWTFOcFp5QTlJRUp2ZUUxaGNEeGllWFJsY3l3Z1FXTmpiM1Z1ZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RzSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVd0NpQWdJQ0F2THlCcFppQW9iRzluYVdOVGFXY3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdacGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5URUtJQ0FnSUM4dklHeHZaMmxqVTJsbkxtUmxiR1YwWlNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NncG1hVzVoYkdsNlpVTm9ZVzV1Wld4ZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBTSGxpY21sa0xuTmxkRUYxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYbEpabEJ5YjNacFpHVmtLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXNJR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYazZJR0o1ZEdWekxDQmxlSEJsWTNSbFpFRjFkR2h2Y21sNlpXUlRhV2R1WlhKSVlYTm9PaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tjMlYwUVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVWxtVUhKdmRtbGtaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOVFV0TXpVNUNpQWdJQ0F2THlCd2NtbDJZWFJsSUhObGRFRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhsSlpsQnliM1pwWkdWa0tBb2dJQ0FnTHk4Z0lDQmphR0Z1Ym1Wc1NXUTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNU9pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ1pYaHdaV04wWldSQmRYUm9iM0pwZW1Wa1UybG5ibVZ5U0dGemFEb2dZbmwwWlhNc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WXdDaUFnSUNBdkx5QnBaaUFvWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlUzVzWlc1bmRHZ2dQaUF3S1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdZbm9nYzJWMFFYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVVsbVVISnZkbWxrWldSZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHphR0UxTVRKZk1qVTJLR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa3BJRDA5UFNCbGVIQmxZM1JsWkVGMWRHaHZjbWw2WldSVGFXZHVaWEpJWVhOb0xDQW5RWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSWdhR0Z6YUNCdGFYTnRZWFJqYUNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE5vWVRVeE1sOHlOVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQmRYUm9iM0pwZW1Wa0lITnBaMjVsY2lCb1lYTm9JRzFwYzIxaGRHTm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNBOUlFSnZlRTFoY0R4aWVYUmxjeXdnWW5sMFpYTStLSHNnYTJWNVVISmxabWw0T2lBbmNDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNell6Q2lBZ0lDQXZMeUJoZFhSb2IzSnBlbVZrVTJsbmJtVnlTMlY1TG5aaGJIVmxJRDBnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYM0IxZEFvS2MyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFZ0FnQW1CQVlWSDN4MUFDQUJiQVFWSDN4MUFYQXhHMEVBY1RFWkZFUXhHRVNDRGdSSTFUNHlCTDNQckZnRVN4Mjdad1JDMlhXbUJFT2NYN0VFNkdycDZRUTBhRkJRQkZrRjFQUUVxaFRFK1FSK1AwcG9CS2h3U1FNRUhwd0FrQVNNVFB6M0JDdjJDZUEyR2dDT0RnQUxBUWdCUVFHZUFkSUNXZ0tEQXFvQzVRTDJBeElEUUFOOEE4QUFNUmtVTVJnVUVFUWpRellhQVVjQ0ZTUVNSREVXSXdsSlRnSTRFSUVFRWtRMkdnSkpJbGtsQ0VzQkZSSkVWd0lBTmhvRFNTSlpKUWhMQVJVU1JGY0NBRWxPQkRZYUJFa2lXU1VJU3dFVkVrUlhBZ0JPQkVrVlNVNEdKQkpFTVFCUEExQWhCQlpRVHdKUVRGQUJTVTREdlVVQlFBQlFNZ1l5QnpFQVN3aFFTd1lXVndZQ1N3aEpUZ1ZRVElBQ0FISlFJaFpNU3dGUVN3RlFTd0ZRVHdRV1VFOERGbEJNVUV4UVN3UkpUZ0pQQlU4RWlBUVpUd0tJQTBwTEFieEl2eWhMQVZDd0kwTkxBa20rUkRFQVN3SWlKTG9TUkVzQkpFbTZTd2dTUkVtQlFGbExBUlZMQWs0Q1VsY0NBRXNIU3dFU1JFc0NUd1ZQQW9nRDAwOENpQU1FU3dHOFNMOUMvN2MyR2dGSklsa2xDRXNCRlJKRVZ3SUFNUllqQ1VrNEVJRUVFa1JMQWIxRkFVUkxBYjVJVERFQVN3TWlKTG9TUklnQ3lrc0J2RWkvSTBNMkdnRkpJbGtsQ0VzQkZSSkVWd0lBTmhvQ1NTSlpKUWhMQVJVU1JGY0NBRXNCdlVVQlJFc0J2a2hPQWpFQVN3SWlKTG9TUkVrVlJFa0RTd0pQQWtzQ2lBTktnQUlBSUV4UVN3S0JRRmxQQXlKUEFsaE1VRXNCdkVpL0kwTTJHZ0ZKSWxrbENFc0JGUkpFVndJQU5ob0NTUlVrRWtSTEFiMUZBVVF4QUVzQ0lpUzZFa1JKTWdNVFJDbFBBbEJNdnlORE5ob0JTU0paSlFoTEFSVVNSRmNDQUVrMkdnSkpUZ0pKRllFSUVrUkpGMHNDdlVVQlJFc0N2a2hPQWlsTEJGQkp2VVVCUkRFQVRMNUlFa1JMQTRNQ1NnaTZGMG9OUkVzRWd3SkNDTG9YU3dJUFJFc0JUQW14SVFSTVR3VWtTYnF5RkxJU3NoR0JCTElRSXJJQnMwNENYRXBKVGdLQlVsc05RUUFFU3dGY1Vrc0NTYnhJVEw4alF6WWFBVWtpV1NVSVN3RVZFa1JYQWdCSnZVVUJSRW0rU0V3eEFFc0JKRW02RWtSTWlBSE9TQ05ETmhvQlNTSlpKUWhMQVJVU1JGY0NBRW05UlFGRU1RQkxBU0lrdWhKRU1nY1dnV3BNdXlORE5ob0JTU0paSlFoTEFSVVNSRmNDQUVtOVJRRkVTYjVJVERFQVN3RWlKTG9TUkVtREFtb0l1aGRKUkRJSFRJSDRCZ2dQUkV5SUFXeElJME0yR2dGSkZTUVNSRmNBSURJS0VrUWpRekVBTWdrU1JMRWhCRElLSXJJU3NoU3lFWUVFc2hBaXNnR3pJME0yR2dGSklsa2xDRXNCRlJKRVZ3SUFTYjFGQVVSSmd3SmFDTG9YVElNQ1lnaTZGMHdXVEJaUUtreFFzQ05ETmhvQlNTSlpKUWhMQVJVU1JGY0NBRW05UlFGRVNZTUNRZ2k2RjBzQmd3SktDTG9YVHdLREFsSUl1aGRQQWhaUEFoWlFUQlpRS2t4UXNDTkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JEWWFBMGtpV1NVSVN3RVZFa1JYQWdBMkdnUkpJbGtsQ0VzQkZSSkVWd0lBVHdOUEExQWhCQlpRVEZCTVVBRW9URkN3STBNMkdnRkpGU1FTUkRZYUFra1ZKQkpFTmhvRFNTSlpKUWhMQVJVU1JGY0NBRFlhQkVraVdTVUlTd0VWRWtSWEFnQlBBMDhEVUNFRUZsQk1VRXhRQVNoTVVMQWpRNG9DQVl2L09BQXhBQkpFaS84NEZESUtFa1NML3pnUklRUVNSSXYvT0JKSlJJdi9PQk15QXhKRWkvODRGVElERWtTTC9vRkNXd2dXaS81TVhFS00vaUlXaS81TVhHcEpqUDZKaWdJQklrbUFBSXYvZ1ZKYlNZdi9nVXBiQ1VsQkFCaXhJUVNMLzFjZ0lJc0VzaEt5RkxJUmdRU3lFQ0t5QWJPTC80RkNXNHNEQ1VtTUFrRUFHTEVoQkl2L1Z3QWdpd0t5RXJJVXNoR0JCTElRSXJJQnM0dit2RWdyaS81UVNZd0J2VVVCUVFBRWl3RzhTQ21ML2xCSmpBQzlSUUZCQUFTTEFMeElpLytNQUltS0F3Q0wvaFZCQUJHTC9nT0wveEpFSzR2OVVFbThTSXYrdjRrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlVTRENfQVNTRVRfSUQiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
