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

namespace Arc56.Generated.algorandecosystem.escrow_session_vault.EscrowSessionVaultHybridManager_c9c32e1b
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93U2Vzc2lvblZhdWx0SHlicmlkTWFuYWdlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3Q0M0JDNUExMCI6W3sibmFtZSI6InBheWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXllZSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJ0b3RhbERlcG9zaXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFNldHRsZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGF0ZXN0Vm91Y2hlckFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFydFJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXJ0VGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNsb3NlUmVxdWVzdGVkQXQiLCJ0eXBlIjoidWludDY0In1dLCJPYmplY3RBQUNGODUxMCI6W3sibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6ImFkZHJlc3MifV0sIkdldFNlc3Npb25TdGF0aWNEYXRhUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldFNlc3Npb25EeW5hbWljRGF0YVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wZW4iLCJkZXNjIjoiT3BlbnMgYSBjaGFubmVsIHdpdGggaW5pdGlhbCBVU0RDIGRlcG9zaXQgYW5kIHJldHVybnMgZGVyaXZlZCBjaGFubmVsSWQuXG5DYWxsZXIgYmVjb21lcyBwYXllci5cbmF1dGhvcml6ZWRTaWduZXIgaXMgc2lnbmVyIHB1YmtleSBoYXNoICgzMiBieXRlcykgY29tcHV0ZWQgY2xpZW50LXNpZGUuXG5hdXRob3JpemVkU2lnbmVyUHVibGljS2V5IGlzIG9wdGlvbmFsOiBpZiBwcm92aWRlZCwgc3RvcmVzIGZ1bGwgc2lnbmVyIHB1YmtleSBpbiBib3guIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXBvc2l0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyUHVibGljS2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9wVXAiLCJkZXNjIjoiQWRkcyBmdW5kcyB0byBhbiBleGlzdGluZyBjaGFubmVsIHVzaW5nIGEgZ3JvdXBlZCBVU0RDIGFzc2V0IHRyYW5zZmVyLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3VtdWxhdGl2ZUFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRBdXRob3JpemVkU2lnbmVyUHVibGljS2V5IiwiZGVzYyI6IlNldCBmdWxsIGF1dGhvcml6ZWQgc2lnbmVyIHB1YmxpYyBrZXkgYW5kIHVwZGF0ZSBjaGFubmVsLmF1dGhvcml6ZWRTaWduZXIgaGFzaC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyUHVibGljS2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFNldHRsZW1lbnRMb2dpY1NpZyIsImRlc2MiOiJSZWdpc3RlcnMgdGhlIGNoYW5uZWwtc3BlY2lmaWMgTG9naWNTaWcgdXNlZCBmb3IgRmFsY29uLWF1dGhvcml6ZWQgc2V0dGxlbWVudC5cblRoZSBwYXllciBjb21waWxlcyBpdCB3aXRoIHRoaXMgYXBwIGlkLCBjaGFubmVsIGlkLCBwYXllZSwgYW5kIHRoZSBwdWJsaWMga2V5XG53aG9zZSBzaGE1MTJfMjU2IGhhc2ggaXMgc3RvcmVkIG9uIHRoZSBjaGFubmVsLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2dpY1NpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VTZXR0bGVtZW50TG9naWNTaWciLCJkZXNjIjoiRW1lcmdlbmN5IHN0b3A6IHBheWVyIGltbWVkaWF0ZWx5IHJldm9rZXMgdGhlIEFJIGFnZW50J3Mgc2V0dGxlbWVudCBhdXRob3JpdHlcbihlLmcuIGlmIHRoZSBlcGhlbWVyYWwgRmFsY29uIHNlc3Npb24ga2V5IGlzIHN1c3BlY3RlZCBjb21wcm9taXNlZCkgd2l0aG91dFxuY2xvc2luZyB0aGUgY2hhbm5lbCBvciBsb3NpbmcgdGhlIGRlcG9zaXQuIHNldHRsZUZyb21Mb2dpY1NpZyB3aWxsIGZhaWwgdW50aWxcbnRoZSBwYXllciByZWdpc3RlcnMgYSBmcmVzaCBMb2dpY1NpZyB2aWEgc2V0U2V0dGxlbWVudExvZ2ljU2lnLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlRnJvbUxvZ2ljU2lnIiwiZGVzYyI6IlNldHRsZSB0aHJvdWdoIHRoZSByZWdpc3RlcmVkIExvZ2ljU2lnLiBGYWxjb24gdmVyaWZpY2F0aW9uIG9jY3VycyBpbiB0aGVcbkxvZ2ljU2lnIHByb2dyYW07IHRoaXMgY2FsbCBiaW5kcyB0aGF0IGF1dGhvcml6YXRpb24gdG8gdGhlIGNoYW5uZWwgYm94IGFuZFxuYWR2YW5jZXMgaXRzIHZvdWNoZXIgd2F0ZXJtYXJrLCBwcmV2ZW50aW5nIHZvdWNoZXIgcmVwbGF5LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1bXVsYXRpdmVBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2UiLCJkZXNjIjoiUGF5ZWUgY2xvc2VzIGNoYW5uZWwuXG5Ib25vcnMgdGhlIGxhdGVzdCBvbi1jaGFpbiB2b3VjaGVyIGJlZm9yZSByZWZ1bmRpbmcgdGhlIHBheWVyLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVxdWVzdENsb3NlIiwiZGVzYyI6IlBheWVyIHJlcXVlc3RzIGNoYW5uZWwgY2xvc3VyZSwgc3RhcnRpbmcgZm9yY2VkLWNsb3NlIGdyYWNlIHBlcmlvZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IlBheWVyIHdpdGhkcmF3cyByZW1haW5pbmcgZnVuZHMgYWZ0ZXIgZ3JhY2UgcGVyaW9kIGV4cGlyZXMuXG5Ib25vcnMgdGhlIGxhdGVzdCBvbi1jaGFpbiB2b3VjaGVyIGJlZm9yZSByZWZ1bmRpbmcgdGhlIHBheWVyLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZE1iclBvb2wiLCJkZXNjIjoiRnVuZHMgTUJSL2ZlZXMgcG9vbCB1c2luZyBBTEdPLiIsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcykiLCJzdHJ1Y3QiOiJPYmplY3RBQUNGODUxMCIsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdEluVXNkYyIsImRlc2MiOiJPcHQgYXBwIGFjY291bnQgaW50byBjb25maWd1cmVkIFVTREMgQVNBIHNvIGl0IGNhbiByZWNlaXZlIGRlcG9zaXRzLlxuU2hvdWxkIGJlIGNhbGxlZCBvbmNlIGJ5IGFkbWluL2NyZWF0b3IuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFNlc3Npb25TdGF0aWNEYXRhIiwiZGVzYyI6IlJldHVybnMgbGF0ZXN0IHNlc3Npb24gc3RhdGljIGRhdGEgdHVwbGU6XG5bc3RhcnRSb3VuZCwgc3RhcnRUaW1lc3RhbXBdIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRTZXNzaW9uU3RhdGljRGF0YVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2Vzc2lvbkR5bmFtaWNEYXRhIiwiZGVzYyI6IlJldHVybnMgbGF0ZXN0IHNlc3Npb24gZHluYW1pYyBkYXRhIHR1cGxlOlxuW3RvdGFsRGVwb3NpdCwgbGFzdFNldHRsZWQsIGxhdGVzdFZvdWNoZXJBbW91bnQsIHNldHRsZW1lbnRMb2dpY1NpZ11cbnNldHRsZW1lbnRMb2dpY1NpZyBpcyB0aGUgemVybyBhZGRyZXNzIChBY2NvdW50KCkpIGlmIG5vbmUgaXMgY3VycmVudGx5XG5yZWdpc3RlcmVkIChuZXZlciBzZXQsIG9yIHJldm9rZWQgdmlhIHJldm9rZVNldHRsZW1lbnRMb2dpY1NpZykg4oCUIGNhbGxlcnNcbmNhbiB1c2UgdGhhdCB0byBkZXRlY3Qgd2hlbiBzZXRTZXR0bGVtZW50TG9naWNTaWcgbmVlZHMgdG8gYmUgKHJlKWNhbGxlZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkdldFNlc3Npb25EeW5hbWljRGF0YVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVyaXZlQ2hhbm5lbElkIiwiZGVzYyI6IlJlYWQtb25seSBoZWxwZXIgZm9yIGNsaWVudHM6IGRldGVybWluaXN0aWMgY2hhbm5lbElkIGRlcml2YXRpb24uXG5hdXRob3JpemVkU2lnbmVyIG11c3QgYmUgc2lnbmVyIHB1YmtleSBoYXNoICgzMiBieXRlcykuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpemVkU2lnbmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExOTRdLCJlcnJvck1lc3NhZ2UiOiJBc3NldCBjbG9zZSBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1OCwxMzYzXSwiZXJyb3JNZXNzYWdlIjoiQXV0aG9yaXplZCBzaWduZXIgaGFzaCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5M10sImVycm9yTWVzc2FnZSI6IkF1dGhvcml6ZWQgc2lnbmVyIHB1YmtleSByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOSwxMDUzXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxMyw0NzUsNTYwLDYwMyw2NjEsNzgxLDgyMiw4NjEsOTY1LDEwMTFdLCJlcnJvck1lc3NhZ2UiOiJDaGFubmVsIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4Nl0sImVycm9yTWVzc2FnZSI6IkNsYXdiYWNrIHRyYW5zZmVyIG5vdCBhbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODkyXSwiZXJyb3JNZXNzYWdlIjoiQ2xvc2UgZ3JhY2UgcGVyaW9kIG5vdCBlbGFwc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODgzXSwiZXJyb3JNZXNzYWdlIjoiQ2xvc2Ugbm90IHJlcXVlc3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNzhdLCJlcnJvck1lc3NhZ2UiOiJEZXBvc2l0IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc0XSwiZXJyb3JNZXNzYWdlIjoiTG9naWNTaWcgYWNjb3VudCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5NF0sImVycm9yTWVzc2FnZSI6Ik5vdGhpbmcgbmV3IHRvIHNldHRsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIG9wdCBpbiBVU0RDIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzk0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllZSBjYW4gY2xvc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjhdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVyIGNhbiByZW9wZW4gY2hhbm5lbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHJlcXVlc3QgY2xvc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVyIGNhbiByZXZva2UgTG9naWNTaWciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVyIGNhbiBzZXQgTG9naWNTaWciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVyIGNhbiBzZXQgYXV0aG9yaXplZCBzaWduZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVyIGNhbiB0b3AgdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NzRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHBheWVyIGNhbiB3aXRoZHJhdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4M10sImVycm9yTWVzc2FnZSI6Ik9ubHkgc2V0dGxlbWVudCBMb2dpY1NpZyBjYW4gc2V0dGxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM3XSwiZXJyb3JNZXNzYWdlIjoiUGF5ZWUgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTcyXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBhc3NldCBtdXN0IGJlIFVTREMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MTQsMTE2NF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTZdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyMCw2NzZdLCJlcnJvck1lc3NhZ2UiOiJTZXR0bGVtZW50IExvZ2ljU2lnIG5vdCBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTBdLCJlcnJvck1lc3NhZ2UiOiJTaWduZXIgaGFzaCBtdXN0IGJlIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA2XSwiZXJyb3JNZXNzYWdlIjoiVm91Y2hlciBleGNlZWRzIGRlcG9zaXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTUsMTcxLDE5MCwzODYsNDQzLDQ1OSw1MzYsNTg4LDYzMCw3NjYsODA3LDg0Niw5NTAsOTk2LDEwOTksMTExNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBPYmplY3RBQUNGODUxMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MiwxNzgsMTk3LDM5Myw0NTAsNDY2LDU0Myw1OTUsNjM3LDc3Myw4MTQsODUzLDk1NywxMDAzLDExMDYsMTEyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzYsNTU0LDEwODUsMTA5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDksNDA3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRElnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pzSWlBd2VERTFNV1kzWXpjMU1EQXlNQ0F3ZURFMU1XWTNZemMxSUNKd0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdSTllXNWhaMlZ5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFESXhDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFE0WkRVelpUTXlJREI0WW1SalptRmpOVGdnTUhnMFlqRmtZbUkyTnlBd2VEUXlaRGszTldFMklEQjRNakJpT1dKbE9XSWdNSGcwTXpsak5XWmlNU0F3ZUdVNE5tRmxPV1U1SURCNE16UTJPRFV3TlRBZ01IZzFPVEExWkRSbU5DQXdlR0ZoTVRSak5HWTVJREI0TjJVelpqUmhOamdnTUhoaE9EY3dORGt3TXlBd2VHTmpaR1U1Wm1JMklEQjRNbUptTmpBNVpUQWdMeThnYldWMGFHOWtJQ0p2Y0dWdUtHRmtaSEpsYzNNc1lYaG1aWElzWW5sMFpWdGRMR0o1ZEdWYlhTeGllWFJsVzEwcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKMGIzQlZjQ2hpZVhSbFcxMHNZWGhtWlhJcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFFYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNoaWVYUmxXMTBzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRk5sZEhSc1pXMWxiblJNYjJkcFkxTnBaeWhpZVhSbFcxMHNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYWnZhMlZUWlhSMGJHVnRaVzUwVEc5bmFXTlRhV2NvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkSFJzWlVaeWIyMU1iMmRwWTFOcFp5aGllWFJsVzEwc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5zYjNObEtHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhGMVpYTjBRMnh2YzJVb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbWRXNWtUV0p5VUc5dmJDZ29ZV1JrY21WemN5a3BkbTlwWkNJc0lHMWxkR2h2WkNBaWIzQjBTVzVWYzJSaktDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUlRaWE56YVc5dVUzUmhkR2xqUkdGMFlTaGllWFJsVzEwcEtIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUlRaWE56YVc5dVJIbHVZVzFwWTBSaGRHRW9ZbmwwWlZ0ZEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpLU0lzSUcxbGRHaHZaQ0FpWkdWeWFYWmxRMmhoYm01bGJFbGtLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGllWFJsVzEwc1lubDBaVnRkS1dKNWRHVmJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUc5d1pXNGdkRzl3VlhBZ2MyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTQnpaWFJUWlhSMGJHVnRaVzUwVEc5bmFXTlRhV2NnY21WMmIydGxVMlYwZEd4bGJXVnVkRXh2WjJsalUybG5JSE5sZEhSc1pVWnliMjFNYjJkcFkxTnBaeUJqYkc5elpTQnlaWEYxWlhOMFEyeHZjMlVnZDJsMGFHUnlZWGNnWm5WdVpFMWljbEJ2YjJ3Z2IzQjBTVzVWYzJSaklHZGxkRk5sYzNOcGIyNVRkR0YwYVdORVlYUmhJR2RsZEZObGMzTnBiMjVFZVc1aGJXbGpSR0YwWVNCa1pYSnBkbVZEYUdGdWJtVnNTV1FLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVZ6WTNKdmQxTmxjM05wYjI1V1lYVnNkRWg1WW5KcFpFMWhibUZuWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUkllV0p5YVdSTllXNWhaMlZ5TG05d1pXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0dWdU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVdE56SUtJQ0FnSUM4dklHOXdaVzRvQ2lBZ0lDQXZMeUFnSUhCaGVXVmxPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0JrWlhCdmMybDBPaUJuZEhodUxrRnpjMlYwVkhKaGJuTm1aWEpVZUc0c0NpQWdJQ0F2THlBZ0lITmhiSFE2SUdKNWRHVnpMQW9nSUNBZ0x5OGdJQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVUb2dZbmwwWlhNc0NpQWdJQ0F2THlBS0lDQWdJQzh2SUNrNklHSjVkR1Z6SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhlR1psY2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdZWE56WlhKMEtHRjFkR2h2Y21sNlpXUlRhV2R1WlhJdWJHVnVaM1JvSUQwOVBTQXpNaXdnSjFOcFoyNWxjaUJvWVhOb0lHMTFjM1FnWW1VZ016SWdZbmwwWlhNbktRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05nb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRk5wWjI1bGNpQm9ZWE5vSUcxMWMzUWdZbVVnTXpJZ1lubDBaWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCamFHRnVibVZzU1dRZ1BTQjBhR2x6TG1SbGNtbDJaVU5vWVc1dVpXeEpaQ2hVZUc0dWMyVnVaR1Z5TENCd1lYbGxaU3dnWVhWMGFHOXlhWHBsWkZOcFoyNWxjaXdnYzJGc2RDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1T1FvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG5Ob1lUSTFOaWh3WVhsbGNpNWllWFJsY3k1amIyNWpZWFFvY0dGNVpXVXVZbmwwWlhNcExtTnZibU5oZENodmNDNXBkRzlpS0ZWVFJFTmZRVk5UUlZSZlNVUXBLUzVqYjI1allYUW9jMkZzZENrdVkyOXVZMkYwS0dGMWRHaHZjbWw2WldSVGFXZHVaWElwS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWVFJFTmZRVk5UUlZSZlNVUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUJwWmlBb0lXTm9ZVzV1Wld3dVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJ2Y0dWdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSE4wWVhKMFVtOTFibVE2SUc5d0xrZHNiMkpoYkM1eWIzVnVaQ3dLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklITjBZWEowVkdsdFpYTjBZVzF3T2lCdmNDNUhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3TEFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJSEJoZVdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnprdE9Ea0tJQ0FnSUM4dklHTnZibk4wSUdSaGRHRTZJRU5vWVc1dVpXeEpibVp2SUQwZ2V3b2dJQ0FnTHk4Z0lDQndZWGxsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRjFkR2h2Y21sNlpXUlRhV2R1WlhJc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzUkdWd2IzTnBkRG9nTUN3S0lDQWdJQzh2SUNBZ2JHRnpkRk5sZEhSc1pXUTZJREFzQ2lBZ0lDQXZMeUFnSUd4aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJSE4wWVhKMFVtOTFibVE2SUc5d0xrZHNiMkpoYkM1eWIzVnVaQ3dLSUNBZ0lDOHZJQ0FnYzNSaGNuUlVhVzFsYzNSaGJYQTZJRzl3TGtkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QWdJR05zYjNObFVtVnhkV1Z6ZEdWa1FYUTZJREFzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQmthV2NnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1JwWnlBNENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREEzTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnZEc5MFlXeEVaWEJ2YzJsME9pQXdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNUxUZzVDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhPaUJEYUdGdWJtVnNTVzVtYnlBOUlIc0tJQ0FnSUM4dklDQWdjR0Y1WlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJSEJoZVdWbExBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeUxBb2dJQ0FnTHk4Z0lDQjBiM1JoYkVSbGNHOXphWFE2SURBc0NpQWdJQ0F2THlBZ0lHeGhjM1JUWlhSMGJHVmtPaUF3TEFvZ0lDQWdMeThnSUNCc1lYUmxjM1JXYjNWamFHVnlRVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0J6ZEdGeWRGSnZkVzVrT2lCdmNDNUhiRzlpWVd3dWNtOTFibVFzQ2lBZ0lDQXZMeUFnSUhOMFlYSjBWR2x0WlhOMFlXMXdPaUJ2Y0M1SGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0JqYkc5elpWSmxjWFZsYzNSbFpFRjBPaUF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJSFJvYVhNdWMyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUW9ZMmhoYm01bGJFbGtMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdjMlYwUVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVWxtVUhKdmRtbGtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QjBhR2x6TG1Gd2NHeDVWRzl3VlhBb1pHRjBZU3dnWkdWd2IzTnBkQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJoY0hCc2VWUnZjRlZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdZMmhoYm01bGJDNTJZV3gxWlNBOUlHTnNiMjVsS0dSaGRHRXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENncHZjR1Z1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1YjNCbGJrQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qVXROeklLSUNBZ0lDOHZJRzl3Wlc0b0NpQWdJQ0F2THlBZ0lIQmhlV1ZsT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCa1pYQnZjMmwwT2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHNDaUFnSUNBdkx5QWdJSE5oYkhRNklHSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5T2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVG9nWW5sMFpYTXNDaUFnSUNBdkx5QUtJQ0FnSUM4dklDazZJR0o1ZEdWeklIc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05UQXdNakFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2IzQmxibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5nb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2NtVnZjR1Z1SUdOb1lXNXVaV3duS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UWXRPVGNLSUNBZ0lDOHZJR052Ym5OMElHUmhkR0VnUFNCamJHOXVaU2hqYUdGdWJtVnNMblpoYkhWbEtRb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaWElzSUNkUGJteDVJSEJoZVdWeUlHTmhiaUJ5Wlc5d1pXNGdZMmhoYm01bGJDY3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamszQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlISmxiM0JsYmlCamFHRnVibVZzSnlrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCd1lYbGxjaUJqWVc0Z2NtVnZjR1Z1SUdOb1lXNXVaV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjVaV1VnUFQwOUlHUmhkR0V1Y0dGNVpXVXNJQ2RRWVhsbFpTQnRhWE50WVhSamFDY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsbFpTQnRhWE50WVhSamFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUdGemMyVnlkQ2hoZFhSb2IzSnBlbVZrVTJsbmJtVnlJRDA5UFNCa1lYUmhMbUYxZEdodmNtbDZaV1JUYVdkdVpYSXNJQ2RCZFhSb2IzSnBlbVZrSUhOcFoyNWxjaUJvWVhOb0lHMXBjMjFoZEdOb0p5a0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EyTkNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRjFkR2h2Y21sNlpXUWdjMmxuYm1WeUlHaGhjMmdnYldsemJXRjBZMmdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNUW9nSUNBZ0x5OGdkR2hwY3k1elpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpDaGphR0Z1Ym1Wc1NXUXNJR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa3NJR1JoZEdFdVlYVjBhRzl5YVhwbFpGTnBaMjVsY2lrS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJ6WlhSQmRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1U1daUWNtOTJhV1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF5Q2lBZ0lDQXZMeUIwYUdsekxtRndjR3g1Vkc5d1ZYQW9aR0YwWVN3Z1pHVndiM05wZENrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCaGNIQnNlVlJ2Y0ZWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUdOb1lXNXVaV3d1ZG1Gc2RXVWdQU0JqYkc5dVpTaGtZWFJoS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qVXROeklLSUNBZ0lDOHZJRzl3Wlc0b0NpQWdJQ0F2THlBZ0lIQmhlV1ZsT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCa1pYQnZjMmwwT2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHNDaUFnSUNBdkx5QWdJSE5oYkhRNklHSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5T2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVG9nWW5sMFpYTXNDaUFnSUNBdkx5QUtJQ0FnSUM4dklDazZJR0o1ZEdWeklIc0tJQ0FnSUdJZ2IzQmxibDloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbTl3Wlc1QU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUk5ZVzVoWjJWeUxuUnZjRlZ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOXdWWEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJSFJ2Y0ZWd0tHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUjRiaWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVhobVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TmdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjBiM0FnZFhBbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUxTFRFeE5nb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIUnZjQ0IxY0NjcENpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCMGIzQWdkWEFuS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhCaGVXVnlJR05oYmlCMGIzQWdkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdkR2hwY3k1aGNIQnNlVlJ2Y0ZWd0tHUmhkR0VzSUdOMWJYVnNZWFJwZG1WQmJXOTFiblFwQ2lBZ0lDQmpZV3hzYzNWaUlHRndjR3g1Vkc5d1ZYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE9Rb2dJQ0FnTHk4Z1kyaGhibTVsYkM1MllXeDFaU0E5SUdOc2IyNWxLR1JoZEdFcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJSFJ2Y0ZWd0tHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUjRiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbk5sZEVGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMUNpQWdJQ0F2THlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhrNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOd29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTVDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCelpYUWdZWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJNUxURXpNQW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSE5sZENCaGRYUm9iM0pwZW1Wa0lITnBaMjVsY2ljcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCelpYUWdZWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSW5LUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJoZVdWeUlHTmhiaUJ6WlhRZ1lYVjBhRzl5YVhwbFpDQnphV2R1WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TVFvZ0lDQWdMeThnWVhOelpYSjBLR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa3ViR1Z1WjNSb0lENGdNQ3dnSjBGMWRHaHZjbWw2WldRZ2MybG5ibVZ5SUhCMVltdGxlU0J5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklFRjFkR2h2Y21sNlpXUWdjMmxuYm1WeUlIQjFZbXRsZVNCeVpYRjFhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE16Q2lBZ0lDQXZMeUJqYjI1emRDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVNHRnphQ0E5SUhOb1lUVXhNbDh5TlRZb1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNrS0lDQWdJR1IxY0FvZ0lDQWdjMmhoTlRFeVh6STFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTBDaUFnSUNBdkx5QjBhR2x6TG5ObGRFRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhsSlpsQnliM1pwWkdWa0tHTm9ZVzV1Wld4SlpDd2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTd2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNraGhjMmdwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMkNpQWdJQ0F2THlCa1lYUmhMbUYxZEdodmNtbDZaV1JUYVdkdVpYSWdQU0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlTR0Z6YUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBMk5DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QmphR0Z1Ym1Wc0xuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TlFvZ0lDQWdMeThnYzJWMFFYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1T2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbk5sZEZObGRIUnNaVzFsYm5STWIyZHBZMU5wWjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRk5sZEhSc1pXMWxiblJNYjJkcFkxTnBaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOUW9nSUNBZ0x5OGdjMlYwVTJWMGRHeGxiV1Z1ZEV4dloybGpVMmxuS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUd4dloybGpVMmxuT2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRjS0lDQWdJQzh2SUdGemMyVnlkQ2hqYUdGdWJtVnNMbVY0YVhOMGN5d2dKME5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnpaWFFnVEc5bmFXTlRhV2NuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTVMVEUxTUFvZ0lDQWdMeThnWTI5dWMzUWdaR0YwWVNBOUlHTnNiMjVsS0dOb1lXNXVaV3d1ZG1Gc2RXVXBDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsY2l3Z0owOXViSGtnY0dGNVpYSWdZMkZ1SUhObGRDQk1iMmRwWTFOcFp5Y3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTUFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnpaWFFnVEc5bmFXTlRhV2NuS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhCaGVXVnlJR05oYmlCelpYUWdURzluYVdOVGFXY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0d4dloybGpVMmxuSUNFOVBTQkJZMk52ZFc1MEtDa3NJQ2RNYjJkcFkxTnBaeUJoWTJOdmRXNTBJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUjFjQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRXh2WjJsalUybG5JR0ZqWTI5MWJuUWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCelpYUjBiR1Z0Wlc1MFRHOW5hV05UYVdjZ1BTQkNiM2hOWVhBOFlubDBaWE1zSUVGalkyOTFiblErS0hzZ2EyVjVVSEpsWm1sNE9pQW5iQ2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW13aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV6Q2lBZ0lDQXZMeUIwYUdsekxuTmxkSFJzWlcxbGJuUk1iMmRwWTFOcFp5aGphR0Z1Ym1Wc1NXUXBMblpoYkhWbElEMGdiRzluYVdOVGFXY0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOUW9nSUNBZ0x5OGdjMlYwVTJWMGRHeGxiV1Z1ZEV4dloybGpVMmxuS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUd4dloybGpVMmxuT2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1Y21WMmIydGxVMlYwZEd4bGJXVnVkRXh2WjJsalUybG5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WMmIydGxVMlYwZEd4bGJXVnVkRXh2WjJsalUybG5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXlDaUFnSUNBdkx5QnlaWFp2YTJWVFpYUjBiR1Z0Wlc1MFRHOW5hV05UYVdjb1kyaGhibTVsYkVsa09pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTndvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnlaWFp2YTJVZ1RHOW5hV05UYVdjbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkyTFRFMk53b2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlISmxkbTlyWlNCTWIyZHBZMU5wWnljcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCeVpYWnZhMlVnVEc5bmFXTlRhV2NuS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhCaGVXVnlJR05oYmlCeVpYWnZhMlVnVEc5bmFXTlRhV2NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QnpaWFIwYkdWdFpXNTBURzluYVdOVGFXY2dQU0JDYjNoTllYQThZbmwwWlhNc0lFRmpZMjkxYm5RK0tIc2dhMlY1VUhKbFptbDRPaUFuYkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltd2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNQW9nSUNBZ0x5OGdZWE56WlhKMEtHeHZaMmxqVTJsbkxtVjRhWE4wY3l3Z0oxTmxkSFJzWlcxbGJuUWdURzluYVdOVGFXY2dibTkwSUhObGRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRk5sZEhSc1pXMWxiblFnVEc5bmFXTlRhV2NnYm05MElITmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3hDaUFnSUNBdkx5QnNiMmRwWTFOcFp5NWtaV3hsZEdVb0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qSUtJQ0FnSUM4dklISmxkbTlyWlZObGRIUnNaVzFsYm5STWIyZHBZMU5wWnloamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1YzJWMGRHeGxSbkp2YlV4dloybGpVMmxuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBkR3hsUm5KdmJVeHZaMmxqVTJsbk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjNUNpQWdJQ0F2THlCelpYUjBiR1ZHY205dFRHOW5hV05UYVdjb1kyaGhibTVsYkVsa09pQmllWFJsY3l3Z1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd4Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZMmhoYm01bGJDNWxlR2x6ZEhNc0lDZERhR0Z1Ym1Wc0lHUnZaWE1nYm05MElHVjRhWE4wSnlrS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR0Z1Ym1Wc0lHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRE1LSUNBZ0lDOHZJR052Ym5OMElHUmhkR0VnUFNCamJHOXVaU2hqYUdGdWJtVnNMblpoYkhWbEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSE5sZEhSc1pXMWxiblJNYjJkcFkxTnBaeUE5SUVKdmVFMWhjRHhpZVhSbGN5d2dRV05qYjNWdWRENG9leUJyWlhsUWNtVm1hWGc2SUNkc0p5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWliQ0lLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TlFvZ0lDQWdMeThnWVhOelpYSjBLR3h2WjJsalUybG5MbVY0YVhOMGN5d2dKMU5sZEhSc1pXMWxiblFnVEc5bmFXTlRhV2NnYm05MElITmxkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZObGRIUnNaVzFsYm5RZ1RHOW5hV05UYVdjZ2JtOTBJSE5sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2JHOW5hV05UYVdjdWRtRnNkV1VzSUNkUGJteDVJSE5sZEhSc1pXMWxiblFnVEc5bmFXTlRhV2NnWTJGdUlITmxkSFJzWlNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCelpYUjBiR1Z0Wlc1MElFeHZaMmxqVTJsbklHTmhiaUJ6WlhSMGJHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeE5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOMWJYVnNZWFJwZG1WQmJXOTFiblFnUGlCa1lYUmhMbXhoYzNSVFpYUjBiR1ZrTENBblRtOTBhR2x1WnlCdVpYY2dkRzhnYzJWMGRHeGxKeWtLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MGN5QTNOQ0E0SUM4dklEYzBMQ0E0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndNZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRHaHBibWNnYm1WM0lIUnZJSE5sZEhSc1pRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFMUNpQWdJQ0F2THlCaGMzTmxjblFvWTNWdGRXeGhkR2wyWlVGdGIzVnVkQ0E4UFNCa1lYUmhMblJ2ZEdGc1JHVndiM05wZEN3Z0oxWnZkV05vWlhJZ1pYaGpaV1ZrY3lCa1pYQnZjMmwwSnlrS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBjeUEyTmlBNElDOHZJRFkyTENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbTkxWTJobGNpQmxlR05sWldSeklHUmxjRzl6YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TndvZ0lDQWdMeThnWTI5dWMzUWdjR0Y1YjNWME9pQjFhVzUwTmpRZ1BTQmpkVzExYkdGMGFYWmxRVzF2ZFc1MElDMGdaR0YwWVM1c1lYTjBVMlYwZEd4bFpBb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14T0Mwek1qSUtJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdSaGRHRXVjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUJ3WVhsdmRYUXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFNUNpQWdJQ0F2THlCNFptVnlRWE56WlhRNklFRnpjMlYwS0ZWVFJFTmZRVk5UUlZSZlNVUXBMQW9nSUNBZ2FXNTBZeUEwSUM4dklGUk5VRXhmVlZORVExOUJVMU5GVkY5SlJBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJd0NpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJrWVhSaExuQmhlV1ZsTEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14T0Mwek1qSUtJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdSaGRHRXVjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUJ3WVhsdmRYUXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15TkFvZ0lDQWdMeThnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQ0E5SUdOMWJYVnNZWFJwZG1WQmJXOTFiblFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXlJRGMwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15TlFvZ0lDQWdMeThnYVdZZ0tHTjFiWFZzWVhScGRtVkJiVzkxYm5RZ1BpQmtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RcElIc0tJQ0FnSUhCMWMyaHBiblFnT0RJZ0x5OGdPRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQStDaUFnSUNCaWVpQnpaWFIwYkdWR2NtOXRURzluYVdOVGFXZGZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWpZS0lDQWdJQzh2SUdSaGRHRXViR0YwWlhOMFZtOTFZMmhsY2tGdGIzVnVkQ0E5SUdOMWJYVnNZWFJwZG1WQmJXOTFiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnlaWEJzWVdObE1pQTRNZ29LYzJWMGRHeGxSbkp2YlV4dloybGpVMmxuWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRPUW9nSUNBZ0x5OGdZMmhoYm01bGJDNTJZV3gxWlNBOUlHTnNiMjVsS0dSaGRHRXBDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzT1FvZ0lDQWdMeThnYzJWMGRHeGxSbkp2YlV4dloybGpVMmxuS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUdOMWJYVnNZWFJwZG1WQmJXOTFiblE2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbU5zYjNObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnh2YzJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RZS0lDQWdJQzh2SUdOc2IzTmxLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGphR0Z1Ym1Wc0xtVjRhWE4wY3l3Z0owTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EQUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TWdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpXVXNJQ2RQYm14NUlIQmhlV1ZsSUdOaGJpQmpiRzl6WlNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djR0Y1WldVZ1kyRnVJR05zYjNObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURRS0lDQWdJQzh2SUhSb2FYTXVabWx1WVd4cGVtVkRhR0Z1Ym1Wc0tHTm9ZVzV1Wld4SlpDd2daR0YwWVNrS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdabWx1WVd4cGVtVkRhR0Z1Ym1Wc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TmdvZ0lDQWdMeThnWTJ4dmMyVW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJJZVdKeWFXUk5ZVzVoWjJWeUxuSmxjWFZsYzNSRGJHOXpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGNYVmxjM1JEYkc5elpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z2NtVnhkV1Z6ZEVOc2IzTmxLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVElLSUNBZ0lDOHZJR0Z6YzJWeWRDaGphR0Z1Ym1Wc0xtVjRhWE4wY3l3Z0owTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnY21WeGRXVnpkQ0JqYkc5elpTY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRRdE1qRTFDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdjbVZ4ZFdWemRDQmpiRzl6WlNjcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhOUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCeVpYRjFaWE4wSUdOc2IzTmxKeWtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J3WVhsbGNpQmpZVzRnY21WeGRXVnpkQ0JqYkc5elpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFM0NpQWdJQ0F2THlCa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdQU0J2Y0M1SGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UY3RNakU0Q2lBZ0lDQXZMeUJrWVhSaExtTnNiM05sVW1WeGRXVnpkR1ZrUVhRZ1BTQnZjQzVIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCamFHRnVibVZzTG5aaGJIVmxJRDBnWTJ4dmJtVW9aR0YwWVNrS0lDQWdJSEIxYzJocGJuUWdNVEEySUM4dklERXdOZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z2NtVnhkV1Z6ZEVOc2IzTmxLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwU0hsaWNtbGtUV0Z1WVdkbGNpNTNhWFJvWkhKaGQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRwZEdoa2NtRjNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTFDaUFnSUNBdkx5QjNhWFJvWkhKaGR5aGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTNDaUFnSUNBdkx5QmhjM05sY25Rb1kyaGhibTVsYkM1bGVHbHpkSE1zSUNkRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJNUNpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNekFLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2QybDBhR1J5WVhjbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakk1TFRJek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIZHBkR2hrY21GM0p5a0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak13Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIZHBkR2hrY21GM0p5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQndZWGxsY2lCallXNGdkMmwwYUdSeVlYY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dSaGRHRXVZMnh2YzJWU1pYRjFaWE4wWldSQmRDQStJREFzSUNkRGJHOXpaU0J1YjNRZ2NtVnhkV1Z6ZEdWa0p5a0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkSE1nTVRBMklEZ2dMeThnTVRBMkxDQTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnUTJ4dmMyVWdibTkwSUhKbGNYVmxjM1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak16Q2lBZ0lDQXZMeUJ2Y0M1SGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJRDQ5SUdSaGRHRXVZMnh2YzJWU1pYRjFaWE4wWldSQmRDQXJJRU5NVDFORlgwZFNRVU5GWDFCRlVrbFBSRjlUUlVOUFRrUlRMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBNE9EZ2dMeThnT0RnNENpQWdJQ0FyQ2lBZ0lDQStQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTXlMVEl6TlFvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J2Y0M1SGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJRDQ5SUdSaGRHRXVZMnh2YzJWU1pYRjFaWE4wWldSQmRDQXJJRU5NVDFORlgwZFNRVU5GWDFCRlVrbFBSRjlUUlVOUFRrUlRMQW9nSUNBZ0x5OGdJQ0FuUTJ4dmMyVWdaM0poWTJVZ2NHVnlhVzlrSUc1dmRDQmxiR0Z3YzJWa0p5d0tJQ0FnSUM4dklDa0tJQ0FnSUdGemMyVnlkQ0F2THlCRGJHOXpaU0JuY21GalpTQndaWEpwYjJRZ2JtOTBJR1ZzWVhCelpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek53b2dJQ0FnTHk4Z2RHaHBjeTVtYVc1aGJHbDZaVU5vWVc1dVpXd29ZMmhoYm01bGJFbGtMQ0JrWVhSaEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJtYVc1aGJHbDZaVU5vWVc1dVpXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJMUNpQWdJQ0F2THlCM2FYUm9aSEpoZHloamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFaDVZbkpwWkUxaGJtRm5aWEl1Wm5WdVpFMWljbEJ2YjJ4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG1kVzVrVFdKeVVHOXZiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBNd29nSUNBZ0x5OGdablZ1WkUxaWNsQnZiMndvY0dGNWJXVnVkRG9nZXlCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZENCOUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlBZbXBsWTNSQlFVTkdPRFV4TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalEwQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnYjNBdVIyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUNkUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z1kyOXVkSEpoWTNRbktRb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBNd29nSUNBZ0x5OGdablZ1WkUxaWNsQnZiMndvY0dGNWJXVnVkRG9nZXlCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZENCOUtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRWg1WW5KcFpFMWhibUZuWlhJdWIzQjBTVzVWYzJSalczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0IwU1c1VmMyUmpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVXlDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnYjNBdVIyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpMQ0FuVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ2Y0hRZ2FXNGdWVk5FUXljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCdmNIUWdhVzRnVlZORVF3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVMExUSTFPQW9nSUNBZ0x5OGdhWFI0Ymk1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2hWVTBSRFgwRlRVMFZVWDBsRUtTd0tJQ0FnSUM4dklDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ2IzQXVSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFOUW9nSUNBZ0x5OGdlR1psY2tGemMyVjBPaUJCYzNObGRDaFZVMFJEWDBGVFUwVlVYMGxFS1N3S0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlRSRU5mUVZOVFJWUmZTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFOZ29nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ2IzQXVSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVM0NpQWdJQ0F2THlCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UUXRNalU0Q2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCNFptVnlRWE56WlhRNklFRnpjMlYwS0ZWVFJFTmZRVk5UUlZSZlNVUXBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQnZjQzVIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFNUW9nSUNBZ0x5OGdiM0IwU1c1VmMyUmpLQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbWRsZEZObGMzTnBiMjVUZEdGMGFXTkVZWFJoVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVMlZ6YzJsdmJsTjBZWFJwWTBSaGRHRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyT0FvZ0lDQWdMeThnWVhOelpYSjBLR05vWVc1dVpXd3VaWGhwYzNSekxDQW5RMmhoYm01bGJDQmtiMlZ6SUc1dmRDQmxlR2x6ZENjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNQzB5TnpFS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ0x5OGdjbVYwZFhKdUlGdGtZWFJoTG5OMFlYSjBVbTkxYm1Rc0lHUmhkR0V1YzNSaGNuUlVhVzFsYzNSaGJYQmRDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblJ6SURrd0lEZ2dMeThnT1RBc0lEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TnpFS0lDQWdJQzh2SUhKbGRIVnliaUJiWkdGMFlTNXpkR0Z5ZEZKdmRXNWtMQ0JrWVhSaExuTjBZWEowVkdsdFpYTjBZVzF3WFFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamN3TFRJM01Rb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMlJoZEdFdWMzUmhjblJTYjNWdVpDd2daR0YwWVM1emRHRnlkRlJwYldWemRHRnRjRjBLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5SeklEazRJRGdnTHk4Z09UZ3NJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56RUtJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzV6ZEdGeWRGSnZkVzVrTENCa1lYUmhMbk4wWVhKMFZHbHRaWE4wWVcxd1hRb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbWRsZEZObGMzTnBiMjVFZVc1aGJXbGpSR0YwWVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRk5sYzNOcGIyNUVlVzVoYldsalJHRjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnMENpQWdJQ0F2THlCaGMzTmxjblFvWTJoaGJtNWxiQzVsZUdsemRITXNJQ2REYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMmhoYm01bGJDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSE5sZEhSc1pXMWxiblJNYjJkcFkxTnBaeUE5SUVKdmVFMWhjRHhpZVhSbGN5d2dRV05qYjNWdWRENG9leUJyWlhsUWNtVm1hWGc2SUNkc0p5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWliQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzUwYjNSaGJFUmxjRzl6YVhRc0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZEN3Z2JHOW5hV05UYVdjdVpYaHBjM1J6SUQ4Z2JHOW5hV05UYVdjdWRtRnNkV1VnT2lCQlkyTnZkVzUwS0NsZENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUnpJRFkySURnZ0x5OGdOallzSURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUnpJRGMwSURnZ0x5OGdOelFzSURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBjeUE0TWlBNElDOHZJRGd5TENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQm5aWFJUWlhOemFXOXVSSGx1WVcxcFkwUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLQ21kbGRGTmxjM05wYjI1RWVXNWhiV2xqUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RnS0lDQWdJQzh2SUhKbGRIVnliaUJiWkdGMFlTNTBiM1JoYkVSbGNHOXphWFFzSUdSaGRHRXViR0Z6ZEZObGRIUnNaV1FzSUdSaGRHRXViR0YwWlhOMFZtOTFZMmhsY2tGdGIzVnVkQ3dnYkc5bmFXTlRhV2N1WlhocGMzUnpJRDhnYkc5bmFXTlRhV2N1ZG1Gc2RXVWdPaUJCWTJOdmRXNTBLQ2xkQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBVMlZ6YzJsdmJrUjVibUZ0YVdORVlYUmhYM1JsY201aGNubGZabUZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0a1lYUmhMblJ2ZEdGc1JHVndiM05wZEN3Z1pHRjBZUzVzWVhOMFUyVjBkR3hsWkN3Z1pHRjBZUzVzWVhSbGMzUldiM1ZqYUdWeVFXMXZkVzUwTENCc2IyZHBZMU5wWnk1bGVHbHpkSE1nUHlCc2IyZHBZMU5wWnk1MllXeDFaU0E2SUVGalkyOTFiblFvS1YwS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lpQm5aWFJUWlhOemFXOXVSSGx1WVcxcFkwUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEVoNVluSnBaRTFoYm1GblpYSXVaR1Z5YVhabFEyaGhibTVsYkVsa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1Z5YVhabFEyaGhibTVsYkVsa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1T1FvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG5Ob1lUSTFOaWh3WVhsbGNpNWllWFJsY3k1amIyNWpZWFFvY0dGNVpXVXVZbmwwWlhNcExtTnZibU5oZENodmNDNXBkRzlpS0ZWVFJFTmZRVk5UUlZSZlNVUXBLUzVqYjI1allYUW9jMkZzZENrdVkyOXVZMkYwS0dGMWRHaHZjbWw2WldSVGFXZHVaWElwS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFl5QTBJQzh2SUZSTlVFeGZWVk5FUTE5QlUxTkZWRjlKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxTURBeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwU0hsaWNtbGtUV0Z1WVdkbGNpNWhjSEJzZVZSdmNGVndLR1JoZEdFNklHSjVkR1Z6TENCamRXMTFiR0YwYVhabFFXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwaGNIQnNlVlJ2Y0ZWd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpNd0NpQWdJQ0F2THlCd2NtbDJZWFJsSUdGd2NHeDVWRzl3VlhBb1pHRjBZVG9nUTJoaGJtNWxiRWx1Wm04c0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUjRiaWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXpFS0lDQWdJQzh2SUdGemMyVnlkQ2hqZFcxMWJHRjBhWFpsUVcxdmRXNTBMbk5sYm1SbGNpQTlQVDBnVkhodUxuTmxibVJsY2l3Z0oxQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxcGMyMWhkR05vSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16SUtJQ0FnSUM4dklHRnpjMlZ5ZENoamRXMTFiR0YwYVhabFFXMXZkVzUwTG1GemMyVjBVbVZqWldsMlpYSWdQVDA5SUc5d0xrZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENBblVHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHTnZiblJ5WVdOMEp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR052Ym5SeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16TUtJQ0FnSUM4dklHRnpjMlZ5ZENoamRXMTFiR0YwYVhabFFXMXZkVzUwTG5obVpYSkJjM05sZEM1cFpDQTlQVDBnVlZORVExOUJVMU5GVkY5SlJDd2dKMUJoZVcxbGJuUWdZWE56WlhRZ2JYVnpkQ0JpWlNCVlUwUkRKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlUwUkRYMEZUVTBWVVgwbEVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnWVhOelpYUWdiWFZ6ZENCaVpTQlZVMFJEQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpkVzExYkdGMGFYWmxRVzF2ZFc1MExtRnpjMlYwUVcxdmRXNTBJRDRnTUN3Z0owUmxjRzl6YVhRZ2JYVnpkQ0JpWlNBK0lEQW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdSR1Z3YjNOcGRDQnRkWE4wSUdKbElENGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TTFDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEM1aGMzTmxkRk5sYm1SbGNpQTlQVDBnUVdOamIzVnVkQ2dwTENBblEyeGhkMkpoWTJzZ2RISmhibk5tWlhJZ2JtOTBJR0ZzYkc5M1pXUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYzNObGRGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVOc1lYZGlZV05ySUhSeVlXNXpabVZ5SUc1dmRDQmhiR3h2ZDJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXpZS0lDQWdJQzh2SUdGemMyVnlkQ2hqZFcxMWJHRjBhWFpsUVcxdmRXNTBMbUZ6YzJWMFEyeHZjMlZVYnlBOVBUMGdRV05qYjNWdWRDZ3BMQ0FuUVhOelpYUWdZMnh2YzJVZ2JtOTBJR0ZzYkc5M1pXUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYzNObGRFTnNiM05sVkc4S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQmMzTmxkQ0JqYkc5elpTQnViM1FnWVd4c2IzZGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TTRDaUFnSUNBdkx5QmtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDQXJQU0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBMbUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ05qWWdMeThnTmpZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEWTJDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMHlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5EQUtJQ0FnSUM4dklHUmhkR0V1WTJ4dmMyVlNaWEYxWlhOMFpXUkJkQ0E5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlERXdOZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMHlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZhSGxpY21sa1gyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFNIbGljbWxrVFdGdVlXZGxjaTVtYVc1aGJHbDZaVU5vWVc1dVpXd29ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2daR0YwWVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwbWFXNWhiR2w2WlVOb1lXNXVaV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJSEJ5YVhaaGRHVWdabWx1WVd4cGVtVkRhR0Z1Ym1Wc0tHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHUmhkR0U2SUVOb1lXNXVaV3hKYm1adktUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRMENpQWdJQ0F2THlCamIyNXpkQ0J3WVhsbFpWQmhlVzkxZERvZ2RXbHVkRFkwSUQwZ1pHRjBZUzVzWVhSbGMzUldiM1ZqYUdWeVFXMXZkVzUwSUMwZ1pHRjBZUzVzWVhOMFUyVjBkR3hsWkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEZ3lJQzh2SURneUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOelFnTHk4Z056UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wTlFvZ0lDQWdMeThnYVdZZ0tIQmhlV1ZsVUdGNWIzVjBJRDRnTUNrZ2V3b2dJQ0FnWW5vZ1ptbHVZV3hwZW1WRGFHRnVibVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMmg1WW5KcFpGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UTJMVE0xTUFvZ0lDQWdMeThnYVhSNGJpNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ2VHWmxja0Z6YzJWME9pQkJjM05sZENoVlUwUkRYMEZUVTBWVVgwbEVLU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2daR0YwWVM1d1lYbGxaU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUkJiVzkxYm5RNklIQmhlV1ZsVUdGNWIzVjBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME53b2dJQ0FnTHk4Z2VHWmxja0Z6YzJWME9pQkJjM05sZENoVlUwUkRYMEZUVTBWVVgwbEVLU3dLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWVFJFTmZRVk5UUlZSZlNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME9Bb2dJQ0FnTHk4Z1lYTnpaWFJTWldObGFYWmxjam9nWkdGMFlTNXdZWGxsWlN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBOaTB6TlRBS0lDQWdJQzh2SUdsMGVHNHVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lIaG1aWEpCYzNObGREb2dRWE56WlhRb1ZWTkVRMTlCVTFORlZGOUpSQ2tzQ2lBZ0lDQXZMeUFnSUdGemMyVjBVbVZqWldsMlpYSTZJR1JoZEdFdWNHRjVaV1VzQ2lBZ0lDQXZMeUFnSUdGemMyVjBRVzF2ZFc1ME9pQndZWGxsWlZCaGVXOTFkQ3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tabWx1WVd4cGVtVkRhR0Z1Ym1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xTXdvZ0lDQWdMeThnWTI5dWMzUWdjR0Y1WlhKU1pXWjFibVE2SUhWcGJuUTJOQ0E5SUdSaGRHRXVkRzkwWVd4RVpYQnZjMmwwSUMwZ1pHRjBZUzVzWVhSbGMzUldiM1ZqYUdWeVFXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ05qWWdMeThnTmpZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMU5Bb2dJQ0FnTHk4Z2FXWWdLSEJoZVdWeVVtVm1kVzVrSUQ0Z01Da2dld29nSUNBZ1lub2dabWx1WVd4cGVtVkRhR0Z1Ym1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelUxTFRNMU9Rb2dJQ0FnTHk4Z2FYUjRiaTVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdlR1psY2tGemMyVjBPaUJCYzNObGRDaFZVMFJEWDBGVFUwVlVYMGxFS1N3S0lDQWdJQzh2SUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWkdGMFlTNXdZWGxsY2l3S0lDQWdJQzh2SUNBZ1lYTnpaWFJCYlc5MWJuUTZJSEJoZVdWeVVtVm1kVzVrTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFOZ29nSUNBZ0x5OGdlR1psY2tGemMyVjBPaUJCYzNObGRDaFZVMFJEWDBGVFUwVlVYMGxFS1N3S0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlRSRU5mUVZOVFJWUmZTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjlvZVdKeWFXUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFOd29nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1pHRjBZUzV3WVhsbGNpd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelUxTFRNMU9Rb2dJQ0FnTHk4Z2FYUjRiaTVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdlR1psY2tGemMyVjBPaUJCYzNObGRDaFZVMFJEWDBGVFUwVlVYMGxFS1N3S0lDQWdJQzh2SUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWkdGMFlTNXdZWGxsY2l3S0lDQWdJQzh2SUNBZ1lYTnpaWFJCYlc5MWJuUTZJSEJoZVdWeVVtVm1kVzVrTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3BtYVc1aGJHbDZaVU5vWVc1dVpXeGZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZeUNpQWdJQ0F2THlCMGFHbHpMbU5vWVc1dVpXeHpLR05vWVc1dVpXeEpaQ2t1WkdWc1pYUmxLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTQTlJRUp2ZUUxaGNEeGllWFJsY3l3Z1lubDBaWE0rS0hzZ2EyVjVVSEpsWm1sNE9pQW5jQ2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5BaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yTkFvZ0lDQWdMeThnYVdZZ0tITnBaMjVsY2xCMVlteHBZMHRsZVM1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dabWx1WVd4cGVtVkRhR0Z1Ym1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelkxQ2lBZ0lDQXZMeUJ6YVdkdVpYSlFkV0pzYVdOTFpYa3VaR1ZzWlhSbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtDbVpwYm1Gc2FYcGxRMmhoYm01bGJGOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnYzJWMGRHeGxiV1Z1ZEV4dloybGpVMmxuSUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JCWTJOdmRXNTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyd25JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pzSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOamdLSUNBZ0lDOHZJR2xtSUNoc2IyZHBZMU5wWnk1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dabWx1WVd4cGVtVkRhR0Z1Ym1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5b2VXSnlhV1JmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yT1FvZ0lDQWdMeThnYkc5bmFXTlRhV2N1WkdWc1pYUmxLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ21acGJtRnNhWHBsUTJoaGJtNWxiRjloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOW9lV0p5YVdSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSSWVXSnlhV1JOWVc1aFoyVnlMbk5sZEVGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGxKWmxCeWIzWnBaR1ZrS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUdGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGs2SUdKNWRHVnpMQ0JsZUhCbFkzUmxaRUYxZEdodmNtbDZaV1JUYVdkdVpYSklZWE5vT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LYzJWMFFYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVVsbVVISnZkbWxrWldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnpNdE16YzNDaUFnSUNBdkx5QndjbWwyWVhSbElITmxkRUYxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYbEpabEJ5YjNacFpHVmtLQW9nSUNBZ0x5OGdJQ0JqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQW9nSUNBZ0x5OGdJQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdaWGh3WldOMFpXUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVNHRnphRG9nWW5sMFpYTXNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDJoNVluSnBaRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemM0Q2lBZ0lDQXZMeUJwWmlBb1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVM1c1pXNW5kR2dnUGlBd0tTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWW5vZ2MyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmFIbGljbWxrWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnprS0lDQWdJQzh2SUdGemMyVnlkQ2h6YUdFMU1USmZNalUyS0dGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGtwSUQwOVBTQmxlSEJsWTNSbFpFRjFkR2h2Y21sNlpXUlRhV2R1WlhKSVlYTm9MQ0FuUVhWMGFHOXlhWHBsWkNCemFXZHVaWElnYUdGemFDQnRhWE50WVhSamFDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOb1lUVXhNbDh5TlRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJkWFJvYjNKcGVtVmtJSE5wWjI1bGNpQm9ZWE5vSUcxcGMyMWhkR05vQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYUhsaWNtbGtYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTQTlJRUp2ZUUxaGNEeGllWFJsY3l3Z1lubDBaWE0rS0hzZ2EyVjVVSEpsWm1sNE9pQW5jQ2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5BaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyaDVZbkpwWkY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpneENpQWdJQ0F2THlCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5UzJWNUxuWmhiSFZsSUQwZ1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbTk0WDNCMWRBb0tjMlYwUVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVWxtVUhKdmRtbGtaV1JmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRWdBZ0FtQkFGc0JoVWZmSFVBSUFRVkgzeDFBWEF4RzBFQWNURVpGRVF4R0VTQ0RnUkkxVDR5QkwzUHJGZ0VTeDI3WndSQzJYV21CQ0M1dnBzRVE1eGZzUVRvYXVucEJEUm9VRkFFV1FYVTlBU3FGTVQ1Qkg0L1NtZ0VxSEJKQXdUTTNwKzJCQ3YyQ2VBMkdnQ09EZ0FMQVFnQlFRR2VBZElCL0FLRUFxMEMxQU1QQXlBRFBBTnFBOEVBTVJrVU1SZ1VFRVFqUXpZYUFVY0NGU1FTUkRFV0l3bEpUZ0k0RUlFRUVrUTJHZ0pKSWxrbENFc0JGUkpFVndJQU5ob0RTU0paSlFoTEFSVVNSRmNDQUVsT0JEWWFCRWtpV1NVSVN3RVZFa1JYQWdCT0JFa1ZTVTRHSkJKRU1RQlBBMUFoQkJaUVR3SlFURkFCU1U0RHZVVUJRQUJRTWdZeUJ6RUFTd2hRU3dZV1Z3WUNTd2hKVGdWUVRJQUNBSEpRSWhaTVN3RlFTd0ZRU3dGUVR3UVdVRThERmxCTVVFeFFTd1JKVGdKUEJVOEVpQVFhVHdLSUEwdExBYnhJdnlsTEFWQ3dJME5MQWttK1JERUFTd0lpSkxvU1JFc0JKRW02U3dnU1JFbUJRRmxMQVJWTEFrNENVbGNDQUVzSFN3RVNSRXNDVHdWUEFvZ0QxRThDaUFNRlN3RzhTTDlDLzdjMkdnRkpJbGtsQ0VzQkZSSkVWd0lBTVJZakNVazRFSUVFRWtSTEFiMUZBVVJMQWI1SVRERUFTd01pSkxvU1JJZ0N5MHNCdkVpL0kwTTJHZ0ZKSWxrbENFc0JGUkpFVndJQU5ob0NTU0paSlFoTEFSVVNSRmNDQUVzQnZVVUJSRXNCdmtoT0FqRUFTd0lpSkxvU1JFa1ZSRWtEU3dKUEFrc0NpQU5MZ0FJQUlFeFFTd0tCUUZsUEF5SlBBbGhNVUVzQnZFaS9JME0yR2dGSklsa2xDRXNCRlJKRVZ3SUFOaG9DU1JVa0VrUkxBYjFGQVVReEFFc0NJaVM2RWtSSk1nTVRSQ2hQQWxCTXZ5TkROaG9CU1NKWkpRaExBUlVTUkZjQ0FFbTlSUUZFTVFCTEFTSWt1aEpFS0V4UVNiMUZBVVM4U0NORE5ob0JTU0paSlFoTEFSVVNSRmNDQUVrMkdnSkpUZ0pKRllFSUVrUkpGMHNDdlVVQlJFc0N2a2hPQWloTEJGQkp2VVVCUkRFQVRMNUlFa1JMQTRNQ1NnaTZGMG9OUkVzRWd3SkNDTG9YU3dJUFJFc0JUQW14SVFSTVR3VWtTYnF5RkxJU3NoR0JCTElRSXJJQnMwNENYRXBKVGdLQlVsc05RUUFFU3dGY1Vrc0NTYnhJVEw4alF6WWFBVWtpV1NVSVN3RVZFa1JYQWdCSnZVVUJSRW0rU0V3eEFFc0JKRW02RWtSTWlBR2xTQ05ETmhvQlNTSlpKUWhMQVJVU1JGY0NBRW05UlFGRU1RQkxBU0lrdWhKRU1nY1dnV3BNdXlORE5ob0JTU0paSlFoTEFSVVNSRmNDQUVtOVJRRkVTYjVJVERFQVN3RWlKTG9TUkVtREFtb0l1aGRKUkRJSFRJSDRCZ2dQUkV5SUFVTklJME0yR2dGSkZTUVNSRmNBSURJS0VrUWpRekVBTWdrU1JMRWhCRElLSXJJU3NoU3lFWUVFc2hBaXNnR3pJME0yR2dGSklsa2xDRXNCRlJKRVZ3SUFTYjFGQVVSSmd3SmFDTG9YVElNQ1lnaTZGMHdXVEJaUUtreFFzQ05ETmhvQlNTSlpKUWhMQVJVU1JGY0NBRW05UlFGRUtFc0JVRWxQQWttREFrSUl1aGRPQWttREFrb0l1aGRPQW9NQ1VnaTZGMHk5UlFGQkFCZExBNzVFU3dNV1N3TVdVRXNDRmxCTVVDcE1VTEFqUXpJRFF2L29OaG9CU1JVa0VrUTJHZ0pKRlNRU1JEWWFBMGtpV1NVSVN3RVZFa1JYQWdBMkdnUkpJbGtsQ0VzQkZSSkVWd0lBVHdOUEExQWhCQlpRVEZCTVVBRXBURkN3STBPS0FnR0wvemdBTVFBU1JJdi9PQlF5Q2hKRWkvODRFU0VFRWtTTC96Z1NTVVNML3pnVE1nTVNSSXYvT0JVeUF4SkVpLzZCUWxzSUZvditURnhDalA0aUZvditURnhxU1l6K2lZb0NBU0pKZ0FDTC80RlNXMG1MLzRGS1d3bEpRUUFZc1NFRWkvOVhJQ0NMQkxJU3NoU3lFWUVFc2hBaXNnR3ppLytCUWx1TEF3bEpqQUpCQUJpeElRU0wvMWNBSUlzQ3NoS3lGTElSZ1FTeUVDS3lBYk9ML3J4SUs0ditVRW1NQWIxRkFVRUFCSXNCdkVnb2kvNVFTWXdBdlVVQlFRQUVpd0M4U0l2L2pBQ0ppZ01BaS80VlFRQVJpLzREaS84U1JDdUwvVkJKdkVpTC9yK0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJVU0RDX0FTU0VUX0lEIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
