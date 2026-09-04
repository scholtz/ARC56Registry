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

namespace Arc56.Generated.algorandecosystem.escrow_session_vault.EscrowSessionVaultManager_38df680e
{


    public class EscrowSessionVaultManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowSessionVaultManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        ///Stores latest cumulative voucher amount on-chain.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="cumulativeAmount"> </param>
        /// <param name="signature"> </param>
        public async Task UpdateVoucher(byte[] channelId, ulong cumulativeAmount, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 141, 130, 218 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateVoucher_Transactions(byte[] channelId, ulong cumulativeAmount, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 141, 130, 218 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Payee settles signed voucher funds, with support for partial settlement.
        ///Also advances latestVoucherAmount when the submitted signed voucher is newer.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="cumulativeAmount"> </param>
        /// <param name="signature"> </param>
        public async Task Settle(byte[] channelId, ulong cumulativeAmount, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 223, 141, 226 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Settle_Transactions(byte[] channelId, ulong cumulativeAmount, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 223, 141, 226 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Helper for payee: settle all currently unclaimed voucher amount.
        ///</summary>
        /// <param name="channelId"> </param>
        public async Task SettleLatest(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 135, 39, 137 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SettleLatest_Transactions(byte[] channelId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 135, 39, 137 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///Read-only helper for clients: exact bytes signed for settle/updateVoucher.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="cumulativeAmount"> </param>
        public async Task<byte[]> SettleMessage(byte[] channelId, ulong cumulativeAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 32, 216, 255 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> SettleMessage_Transactions(byte[] channelId, ulong cumulativeAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 32, 216, 255 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only helper for clients: verifies settle authorization exactly as settle/updateVoucher do.
        ///Uses full authorized signer public key stored in a box for the channel.
        ///</summary>
        /// <param name="channelId"> </param>
        /// <param name="cumulativeAmount"> </param>
        /// <param name="signature"> </param>
        public async Task VerifySettleSignature(byte[] channelId, ulong cumulativeAmount, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 4, 146, 137 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifySettleSignature_Transactions(byte[] channelId, ulong cumulativeAmount, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 4, 146, 137 };
            var channelIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); channelIdAbi.From(channelId);
            var cumulativeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cumulativeAmountAbi.From(cumulativeAmount);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, channelIdAbi, cumulativeAmountAbi, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93U2Vzc2lvblZhdWx0TWFuYWdlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3Q0M0JDNUExMCI6W3sibmFtZSI6InBheWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXllZSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJ0b3RhbERlcG9zaXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFNldHRsZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGF0ZXN0Vm91Y2hlckFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFydFJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXJ0VGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNsb3NlUmVxdWVzdGVkQXQiLCJ0eXBlIjoidWludDY0In1dLCJPYmplY3RBQUNGODUxMCI6W3sibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6ImFkZHJlc3MifV0sIkdldFNlc3Npb25TdGF0aWNEYXRhUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldFNlc3Npb25EeW5hbWljRGF0YVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcGVuIiwiZGVzYyI6Ik9wZW5zIGEgY2hhbm5lbCB3aXRoIGluaXRpYWwgVVNEQyBkZXBvc2l0IGFuZCByZXR1cm5zIGRlcml2ZWQgY2hhbm5lbElkLlxuQ2FsbGVyIGJlY29tZXMgcGF5ZXIuXG5hdXRob3JpemVkU2lnbmVyIGlzIHNpZ25lciBwdWJrZXkgaGFzaCAoMzIgYnl0ZXMpIGNvbXB1dGVkIGNsaWVudC1zaWRlLlxuYXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSBpcyBvcHRpb25hbDogaWYgcHJvdmlkZWQsIHN0b3JlcyBmdWxsIHNpZ25lciBwdWJrZXkgaW4gYm94LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvcFVwIiwiZGVzYyI6IkFkZHMgZnVuZHMgdG8gYW4gZXhpc3RpbmcgY2hhbm5lbCB1c2luZyBhIGdyb3VwZWQgVVNEQyBhc3NldCB0cmFuc2Zlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1bXVsYXRpdmVBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSIsImRlc2MiOiJTZXQgZnVsbCBhdXRob3JpemVkIHNpZ25lciBwdWJsaWMga2V5IGFuZCB1cGRhdGUgY2hhbm5lbC5hdXRob3JpemVkU2lnbmVyIGhhc2guIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVWb3VjaGVyIiwiZGVzYyI6IlN0b3JlcyBsYXRlc3QgY3VtdWxhdGl2ZSB2b3VjaGVyIGFtb3VudCBvbi1jaGFpbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdW11bGF0aXZlQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlIiwiZGVzYyI6IlBheWVlIHNldHRsZXMgc2lnbmVkIHZvdWNoZXIgZnVuZHMsIHdpdGggc3VwcG9ydCBmb3IgcGFydGlhbCBzZXR0bGVtZW50LlxuQWxzbyBhZHZhbmNlcyBsYXRlc3RWb3VjaGVyQW1vdW50IHdoZW4gdGhlIHN1Ym1pdHRlZCBzaWduZWQgdm91Y2hlciBpcyBuZXdlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdW11bGF0aXZlQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlTGF0ZXN0IiwiZGVzYyI6IkhlbHBlciBmb3IgcGF5ZWU6IHNldHRsZSBhbGwgY3VycmVudGx5IHVuY2xhaW1lZCB2b3VjaGVyIGFtb3VudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsb3NlIiwiZGVzYyI6IlBheWVlIGNsb3NlcyBjaGFubmVsLlxuSG9ub3JzIHRoZSBsYXRlc3Qgb24tY2hhaW4gdm91Y2hlciBiZWZvcmUgcmVmdW5kaW5nIHRoZSBwYXllci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcXVlc3RDbG9zZSIsImRlc2MiOiJQYXllciByZXF1ZXN0cyBjaGFubmVsIGNsb3N1cmUsIHN0YXJ0aW5nIGZvcmNlZC1jbG9zZSBncmFjZSBwZXJpb2QuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOiJQYXllciB3aXRoZHJhd3MgcmVtYWluaW5nIGZ1bmRzIGFmdGVyIGdyYWNlIHBlcmlvZCBleHBpcmVzLlxuSG9ub3JzIHRoZSBsYXRlc3Qgb24tY2hhaW4gdm91Y2hlciBiZWZvcmUgcmVmdW5kaW5nIHRoZSBwYXllci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ1bmRNYnJQb29sIiwiZGVzYyI6IkZ1bmRzIE1CUi9mZWVzIHBvb2wgdXNpbmcgQUxHTy4iLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MpIiwic3RydWN0IjoiT2JqZWN0QUFDRjg1MTAiLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJblVzZGMiLCJkZXNjIjoiT3B0IGFwcCBhY2NvdW50IGludG8gY29uZmlndXJlZCBVU0RDIEFTQSBzbyBpdCBjYW4gcmVjZWl2ZSBkZXBvc2l0cy5cblNob3VsZCBiZSBjYWxsZWQgb25jZSBieSBhZG1pbi9jcmVhdG9yLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTZXNzaW9uU3RhdGljRGF0YSIsImRlc2MiOiJSZXR1cm5zIGxhdGVzdCBzZXNzaW9uIHN0YXRpYyBkYXRhIHR1cGxlOlxuW3N0YXJ0Um91bmQsIHN0YXJ0VGltZXN0YW1wXSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0U2Vzc2lvblN0YXRpY0RhdGFSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTZXNzaW9uRHluYW1pY0RhdGEiLCJkZXNjIjoiUmV0dXJucyBsYXRlc3Qgc2Vzc2lvbiBkeW5hbWljIGRhdGEgdHVwbGU6XG5bdG90YWxEZXBvc2l0LCBsYXN0U2V0dGxlZCwgbGF0ZXN0Vm91Y2hlckFtb3VudF0iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRTZXNzaW9uRHluYW1pY0RhdGFSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21wdXRlQ2hhbm5lbElkIiwiZGVzYyI6IkJhY2t3YXJkcy1jb21wYXRpYmxlIGFsaWFzIGZvciBkZXRlcm1pbmlzdGljIGNoYW5uZWxJZCBkZXJpdmF0aW9uLlxuYXV0aG9yaXplZFNpZ25lciBtdXN0IGJlIHNpZ25lciBwdWJrZXkgaGFzaCAoMzIgYnl0ZXMpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldHRsZU1lc3NhZ2UiLCJkZXNjIjoiUmVhZC1vbmx5IGhlbHBlciBmb3IgY2xpZW50czogZXhhY3QgYnl0ZXMgc2lnbmVkIGZvciBzZXR0bGUvdXBkYXRlVm91Y2hlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdW11bGF0aXZlQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5U2V0dGxlU2lnbmF0dXJlIiwiZGVzYyI6IlJlYWQtb25seSBoZWxwZXIgZm9yIGNsaWVudHM6IHZlcmlmaWVzIHNldHRsZSBhdXRob3JpemF0aW9uIGV4YWN0bHkgYXMgc2V0dGxlL3VwZGF0ZVZvdWNoZXIgZG8uXG5Vc2VzIGZ1bGwgYXV0aG9yaXplZCBzaWduZXIgcHVibGljIGtleSBzdG9yZWQgaW4gYSBib3ggZm9yIHRoZSBjaGFubmVsLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1bXVsYXRpdmVBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXJpdmVDaGFubmVsSWQiLCJkZXNjIjoiUmVhZC1vbmx5IGhlbHBlciBmb3IgY2xpZW50czogZGV0ZXJtaW5pc3RpYyBjaGFubmVsSWQgZGVyaXZhdGlvbi5cbmF1dGhvcml6ZWRTaWduZXIgbXVzdCBiZSBzaWduZXIgcHVia2V5IGhhc2ggKDMyIGJ5dGVzKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvcml6ZWRTaWduZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1NTVdLCJlcnJvck1lc3NhZ2UiOiJBc3NldCBjbG9zZSBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3MCwxNjg3XSwiZXJyb3JNZXNzYWdlIjoiQXV0aG9yaXplZCBzaWduZXIgaGFzaCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwN10sImVycm9yTWVzc2FnZSI6IkF1dGhvcml6ZWQgc2lnbmVyIHB1YmtleSByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MjRdLCJlcnJvck1lc3NhZ2UiOiJBdXRob3JpemVkIHNpZ25lciBwdWJsaWMga2V5IG5vdCBzZXQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI5XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNSw0ODgsNTg5LDY5Nyw4MTgsODk3LDkzOSw5NzksMTA4NCwxMTI4LDE0MDJdLCJlcnJvck1lc3NhZ2UiOiJDaGFubmVsIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0N10sImVycm9yTWVzc2FnZSI6IkNsYXdiYWNrIHRyYW5zZmVyIG5vdCBhbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxMF0sImVycm9yTWVzc2FnZSI6IkNsb3NlIGdyYWNlIHBlcmlvZCBub3QgZWxhcHNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDFdLCJlcnJvck1lc3NhZ2UiOiJDbG9zZSBub3QgcmVxdWVzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUzOV0sImVycm9yTWVzc2FnZSI6IkRlcG9zaXQgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDk3XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBFZDI1NTE5IHNpZ25hdHVyZSBsZW5ndGgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTA1XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzaWduYXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDc4XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzaWduZXIgcHVia2V5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI5LDg0OV0sImVycm9yTWVzc2FnZSI6Ik5vdGhpbmcgbmV3IHRvIHNldHRsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBvcHQgaW4gVVNEQyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZWUgY2FuIGNsb3NlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE2LDgzMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZWUgY2FuIHNldHRsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHJlb3BlbiBjaGFubmVsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQ5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllciBjYW4gcmVxdWVzdCBjbG9zZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHNldCBhdXRob3JpemVkIHNpZ25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHRvcCB1cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHVwZGF0ZSB2b3VjaGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTkzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllciBjYW4gd2l0aGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDldLCJlcnJvck1lc3NhZ2UiOiJQYXllZSBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzNdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IGFzc2V0IG11c3QgYmUgVVNEQyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzMsMTUyNV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MTddLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxMF0sImVycm9yTWVzc2FnZSI6IlZvdWNoZXIgYmVsb3cgc2V0dGxlZCBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzIsNzQwXSwiZXJyb3JNZXNzYWdlIjoiVm91Y2hlciBleGNlZWRzIGRlcG9zaXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjFdLCJlcnJvck1lc3NhZ2UiOiJWb3VjaGVyIG5vdCBpbmNyZWFzaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc3LDE5MywyMTIsMzk4LDQ1Niw0NzIsNTQ3LDU3Myw2NTEsNjgxLDgwMyw4ODIsOTI0LDk2NCwxMDY5LDExMTMsMTE4OCwxMjA0LDEyNDAsMTI4MiwxMzA3LDEzNDYsMTM2Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgT2JqZWN0QUFDRjg1MTAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODQsMjAwLDIxOSw0MDUsNDYzLDQ3OSw1NTQsNTgwLDY1OCw2ODgsODEwLDg4OSw5MzEsOTcxLDEwNzYsMTEyMCwxMTk1LDEyMTEsMTI0NywxMjg5LDEzMTQsMTM1MywxMzY5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1OCwxMTczLDExODIsMTMzMSwxMzQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2NSw2NzMsMTI1OCwxMzAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxLDQxOV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJjYmxvY2tzIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXlJREVnT0NCVVRWQk1YMVZUUkVOZlFWTlRSVlJmU1VRS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlRBd01qQWdNSGd4TlRGbU4yTTNOU0F3ZURBd01qQWdJaUlnTUhnd05qZ3hNREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSTllXNWhaMlZ5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFESTBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFE0WkRVelpUTXlJREI0WW1SalptRmpOVGdnTUhnMFlqRmtZbUkyTnlBd2VHRTVPR1E0TW1SaElEQjRaamRrWmpoa1pUSWdNSGcyWlRnM01qYzRPU0F3ZUdVNE5tRmxPV1U1SURCNE16UTJPRFV3TlRBZ01IZzFPVEExWkRSbU5DQXdlR0ZoTVRSak5HWTVJREI0TjJVelpqUmhOamdnTUhoaE9EY3dORGt3TXlBd2VERmxPV013TURrd0lEQjRPR00wWTJaalpqY2dNSGcyTnpJd1pEaG1aaUF3ZURJM01EUTVNamc1SURCNE1tSm1OakE1WlRBZ0x5OGdiV1YwYUc5a0lDSnZjR1Z1S0dGa1pISmxjM01zWVhobVpYSXNZbmwwWlZ0ZExHSjVkR1ZiWFN4aWVYUmxXMTBwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0owYjNCVmNDaGllWFJsVzEwc1lYaG1aWElwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwUVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlU2hpZVhSbFcxMHNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVlp2ZFdOb1pYSW9ZbmwwWlZ0ZExIVnBiblEyTkN4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwZEd4bEtHSjVkR1ZiWFN4MWFXNTBOalFzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkSFJzWlV4aGRHVnpkQ2hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVkyeHZjMlVvWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxjWFZsYzNSRGJHOXpaU2hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhjb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVoxYm1STlluSlFiMjlzS0NoaFpHUnlaWE56S1NsMmIybGtJaXdnYldWMGFHOWtJQ0p2Y0hSSmJsVnpaR01vS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEZObGMzTnBiMjVUZEdGMGFXTkVZWFJoS0dKNWRHVmJYU2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEZObGMzTnBiMjVFZVc1aGJXbGpSR0YwWVNoaWVYUmxXMTBwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlZMjl0Y0hWMFpVTm9ZVzV1Wld4SlpDaGhaR1J5WlhOekxHRmtaSEpsYzNNc1lubDBaVnRkTEdKNWRHVmJYU2xpZVhSbFcxMGlMQ0J0WlhSb2IyUWdJbk5sZEhSc1pVMWxjM05oWjJVb1lubDBaVnRkTEhWcGJuUTJOQ2xpZVhSbFcxMGlMQ0J0WlhSb2IyUWdJblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlNoaWVYUmxXMTBzZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pYSnBkbVZEYUdGdWJtVnNTV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0o1ZEdWYlhTeGllWFJsVzEwcFlubDBaVnRkSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2IzQmxiaUIwYjNCVmNDQnpaWFJCZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVJSFZ3WkdGMFpWWnZkV05vWlhJZ2MyVjBkR3hsSUhObGRIUnNaVXhoZEdWemRDQmpiRzl6WlNCeVpYRjFaWE4wUTJ4dmMyVWdkMmwwYUdSeVlYY2dablZ1WkUxaWNsQnZiMndnYjNCMFNXNVZjMlJqSUdkbGRGTmxjM05wYjI1VGRHRjBhV05FWVhSaElHZGxkRk5sYzNOcGIyNUVlVzVoYldsalJHRjBZU0JqYjIxd2RYUmxRMmhoYm01bGJFbGtJSE5sZEhSc1pVMWxjM05oWjJVZ2RtVnlhV1o1VTJWMGRHeGxVMmxuYm1GMGRYSmxJR1JsY21sMlpVTm9ZVzV1Wld4SlpBb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMbTl3Wlc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZjR1Z1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVMwMk53b2dJQ0FnTHk4Z2IzQmxiaWdLSUNBZ0lDOHZJQ0FnY0dGNVpXVTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR1JsY0c5emFYUTZJR2QwZUc0dVFYTnpaWFJVY21GdWMyWmxjbFI0Yml3S0lDQWdJQzh2SUNBZ2MyRnNkRG9nWW5sMFpYTXNDaUFnSUNBdkx5QWdJR0YxZEdodmNtbDZaV1JUYVdkdVpYSTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNU9pQmllWFJsY3l3S0lDQWdJQzh2SUNrNklHSjVkR1Z6SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVhobVpYSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWVhWMGFHOXlhWHBsWkZOcFoyNWxja2hoYzJnZ1BTQnphR0UxTVRKZk1qVTJLR0YxZEdodmNtbDZaV1JUYVdkdVpYSXBDaUFnSUNCa2RYQUtJQ0FnSUhOb1lUVXhNbDh5TlRZS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklHTnZibk4wSUdOb1lXNXVaV3hKWkNBOUlIUm9hWE11WkdWeWFYWmxRMmhoYm01bGJFbGtLRlI0Ymk1elpXNWtaWElzSUhCaGVXVmxMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlMQ0J6WVd4MEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlRVS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1emFHRXlOVFlvY0dGNVpYSXVZbmwwWlhNdVkyOXVZMkYwS0hCaGVXVmxMbUo1ZEdWektTNWpiMjVqWVhRb2IzQXVhWFJ2WWloVlUwUkRYMEZUVTBWVVgwbEVLU2t1WTI5dVkyRjBLSE5oYkhRcExtTnZibU5oZENoaGRYUm9iM0pwZW1Wa1UybG5ibVZ5S1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlUwUkRYMEZUVTBWVVgwbEVDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCcFppQW9JV05vWVc1dVpXd3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCdmNHVnVYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z2MzUmhjblJTYjNWdVpEb2diM0F1UjJ4dlltRnNMbkp2ZFc1a0xBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCemRHRnlkRlJwYldWemRHRnRjRG9nYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJSEJoZVdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05TMDROUW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZVG9nUTJoaGJtNWxiRWx1Wm04Z1BTQjdDaUFnSUNBdkx5QWdJSEJoZVdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J3WVhsbFpTd0tJQ0FnSUM4dklDQWdZWFYwYUc5eWFYcGxaRk5wWjI1bGNqb2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNraGhjMmdzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNSR1Z3YjNOcGREb2dNQ3dLSUNBZ0lDOHZJQ0FnYkdGemRGTmxkSFJzWldRNklEQXNDaUFnSUNBdkx5QWdJR3hoZEdWemRGWnZkV05vWlhKQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lITjBZWEowVW05MWJtUTZJRzl3TGtkc2IySmhiQzV5YjNWdVpDd0tJQ0FnSUM4dklDQWdjM1JoY25SVWFXMWxjM1JoYlhBNklHOXdMa2RzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WeGRXVnpkR1ZrUVhRNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCa2FXY2dPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBeU1Bb2dJQ0FnWkdsbklEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREEzTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNUNpQWdJQ0F2THlCMGIzUmhiRVJsY0c5emFYUTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOUzA0TlFvZ0lDQWdMeThnWTI5dWMzUWdaR0YwWVRvZ1EyaGhibTVsYkVsdVptOGdQU0I3Q2lBZ0lDQXZMeUFnSUhCaGVXVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCd1lYbGxaU3dLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjam9nWVhWMGFHOXlhWHBsWkZOcFoyNWxja2hoYzJnc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzUkdWd2IzTnBkRG9nTUN3S0lDQWdJQzh2SUNBZ2JHRnpkRk5sZEhSc1pXUTZJREFzQ2lBZ0lDQXZMeUFnSUd4aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJSE4wWVhKMFVtOTFibVE2SUc5d0xrZHNiMkpoYkM1eWIzVnVaQ3dLSUNBZ0lDOHZJQ0FnYzNSaGNuUlVhVzFsYzNSaGJYQTZJRzl3TGtkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QWdJR05zYjNObFVtVnhkV1Z6ZEdWa1FYUTZJREFzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUIwYUdsekxuTmxkRUYxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYbEpabEJ5YjNacFpHVmtLR05vWVc1dVpXeEpaQ3dnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlU3dnWVhWMGFHOXlhWHBsWkZOcFoyNWxjaWtLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklIUm9hWE11WVhCd2JIbFViM0JWY0Noa1lYUmhMQ0JrWlhCdmMybDBLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJR0Z3Y0d4NVZHOXdWWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJR05vWVc1dVpXd3VkbUZzZFdVZ1BTQmpiRzl1WlNoa1lYUmhLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0tiM0JsYmw5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRTFoYm1GblpYSXViM0JsYmtBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1TMDJOd29nSUNBZ0x5OGdiM0JsYmlnS0lDQWdJQzh2SUNBZ2NHRjVaV1U2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdSbGNHOXphWFE2SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpd0tJQ0FnSUM4dklDQWdjMkZzZERvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFnSUdGMWRHaHZjbWw2WldSVGFXZHVaWEk2SUdKNWRHVnpMQW9nSUNBZ0x5OGdJQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVPaUJpZVhSbGN5d0tJQ0FnSUM4dklDazZJR0o1ZEdWeklIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05UQXdNakFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2IzQmxibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsYjNCbGJpQmphR0Z1Ym1Wc0p5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJdE9UTUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnlaVzl3Wlc0Z1kyaGhibTVsYkNjcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsYjNCbGJpQmphR0Z1Ym1Wc0p5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQndZWGxsY2lCallXNGdjbVZ2Y0dWdUlHTm9ZVzV1Wld3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsbFpTQTlQVDBnWkdGMFlTNXdZWGxsWlN3Z0oxQmhlV1ZsSUcxcGMyMWhkR05vSnlrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsbFpTQnRhWE50WVhSamFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dGMWRHaHZjbWw2WldSVGFXZHVaWElnUFQwOUlHUmhkR0V1WVhWMGFHOXlhWHBsWkZOcFoyNWxjaXdnSjBGMWRHaHZjbWw2WldRZ2MybG5ibVZ5SUdoaGMyZ2diV2x6YldGMFkyZ25LUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZMElDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTndvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSWdhR0Z6YUNCdGFYTnRZWFJqYUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnZEdocGN5NXpaWFJCZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVTV1pRY205MmFXUmxaQ2hqYUdGdWJtVnNTV1FzSUdGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGtzSUdSaGRHRXVZWFYwYUc5eWFYcGxaRk5wWjI1bGNpa0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z2RHaHBjeTVoY0hCc2VWUnZjRlZ3S0dSaGRHRXNJR1JsY0c5emFYUXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdZWEJ3YkhsVWIzQlZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdZMmhoYm01bGJDNTJZV3gxWlNBOUlHTnNiMjVsS0dSaGRHRXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeExUWTNDaUFnSUNBdkx5QnZjR1Z1S0FvZ0lDQWdMeThnSUNCd1lYbGxaVG9nUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWkdWd2IzTnBkRG9nWjNSNGJpNUJjM05sZEZSeVlXNXpabVZ5VkhodUxBb2dJQ0FnTHk4Z0lDQnpZV3gwT2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjam9nWW5sMFpYTXNDaUFnSUNBdkx5QWdJR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYazZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0tUb2dZbmwwWlhNZ2V3b2dJQ0FnWWlCdmNHVnVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1dmNHVnVRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxuUnZjRlZ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOXdWWEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TndvZ0lDQWdMeThnZEc5d1ZYQW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2daM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaGphR0Z1Ym1Wc0xtVjRhWE4wY3l3Z0owTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJqYjI1emRDQmtZWFJoSUQwZ1kyeHZibVVvWTJoaGJtNWxiQzUyWVd4MVpTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV5Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIUnZjQ0IxY0NjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TVMweE1USUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjBiM0FnZFhBbktRb2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1USUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnZEc5d0lIVndKeWtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J3WVhsbGNpQmpZVzRnZEc5d0lIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOQW9nSUNBZ0x5OGdkR2hwY3k1aGNIQnNlVlJ2Y0ZWd0tHUmhkR0VzSUdOMWJYVnNZWFJwZG1WQmJXOTFiblFwQ2lBZ0lDQmpZV3hzYzNWaUlHRndjR3g1Vkc5d1ZYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QmphR0Z1Ym1Wc0xuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCMGIzQlZjQ2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBPaUJuZEhodUxrRnpjMlYwVkhKaGJuTm1aWEpVZUc0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMbk5sZEVGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklITmxkRUYxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa29ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVUb2dZbmwwWlhNcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpNS0lDQWdJQzh2SUdGemMyVnlkQ2hqYUdGdWJtVnNMbVY0YVhOMGN5d2dKME5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMUNpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTJDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsY2l3Z0owOXViSGtnY0dGNVpYSWdZMkZ1SUhObGRDQmhkWFJvYjNKcGVtVmtJSE5wWjI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5TMHhNallLSUNBZ0lDOHZJR052Ym5OMElHUmhkR0VnUFNCamJHOXVaU2hqYUdGdWJtVnNMblpoYkhWbEtRb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaWElzSUNkUGJteDVJSEJoZVdWeUlHTmhiaUJ6WlhRZ1lYVjBhRzl5YVhwbFpDQnphV2R1WlhJbktRb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qWUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnYzJWMElHRjFkR2h2Y21sNlpXUWdjMmxuYm1WeUp5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQndZWGxsY2lCallXNGdjMlYwSUdGMWRHaHZjbWw2WldRZ2MybG5ibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TndvZ0lDQWdMeThnWVhOelpYSjBLR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa3ViR1Z1WjNSb0lENGdNQ3dnSjBGMWRHaHZjbWw2WldRZ2MybG5ibVZ5SUhCMVltdGxlU0J5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklFRjFkR2h2Y21sNlpXUWdjMmxuYm1WeUlIQjFZbXRsZVNCeVpYRjFhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWprS0lDQWdJQzh2SUdOdmJuTjBJR0YxZEdodmNtbDZaV1JUYVdkdVpYSklZWE5vSUQwZ2MyaGhOVEV5WHpJMU5paGhkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNUtRb2dJQ0FnWkhWd0NpQWdJQ0J6YUdFMU1USmZNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TUFvZ0lDQWdMeThnZEdocGN5NXpaWFJCZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVTV1pRY205MmFXUmxaQ2hqYUdGdWJtVnNTV1FzSUdGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGtzSUdGMWRHaHZjbWw2WldSVGFXZHVaWEpJWVhOb0tRb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdjMlYwUVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVWxtVUhKdmRtbGtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJrWVhSaExtRjFkR2h2Y21sNlpXUlRhV2R1WlhJZ1BTQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVNHRnphQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXpDaUFnSUNBdkx5QmphR0Z1Ym1Wc0xuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeENpQWdJQ0F2THlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhrNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBUV0Z1WVdkbGNpNTFjR1JoZEdWV2IzVmphR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsVm05MVkyaGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE01Q2lBZ0lDQXZMeUIxY0dSaGRHVldiM1ZqYUdWeUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklIVnBiblEyTkN3Z2MybG5ibUYwZFhKbE9pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRReENpQWdJQ0F2THlCaGMzTmxjblFvWTJoaGJtNWxiQzVsZUdsemRITXNJQ2REYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdScFp5QXpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1JoZEdFdWNHRjVaWElzSUNkUGJteDVJSEJoZVdWeUlHTmhiaUIxY0dSaGRHVWdkbTkxWTJobGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NHRjVaWElnWTJGdUlIVndaR0YwWlNCMmIzVmphR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTmdvZ0lDQWdMeThnWVhOelpYSjBLR04xYlhWc1lYUnBkbVZCYlc5MWJuUWdQajBnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQ3dnSjFadmRXTm9aWElnWW1Wc2IzY2djMlYwZEd4bFpDQmhiVzkxYm5RbktRb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTnpRZ0x5OGdOelFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklESUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVm05MVkyaGxjaUJpWld4dmR5QnpaWFIwYkdWa0lHRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRjS0lDQWdJQzh2SUdGemMyVnlkQ2hqZFcxMWJHRjBhWFpsUVcxdmRXNTBJRDRnWkdGMFlTNXNZWFJsYzNSV2IzVmphR1Z5UVcxdmRXNTBMQ0FuVm05MVkyaGxjaUJ1YjNRZ2FXNWpjbVZoYzJsdVp5Y3BDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBNE1pQXZMeUE0TWdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUZadmRXTm9aWElnYm05MElHbHVZM0psWVhOcGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTRDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZENBOFBTQmtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDd2dKMVp2ZFdOb1pYSWdaWGhqWldWa2N5QmtaWEJ2YzJsMEp5a0tJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURZMklDOHZJRFkyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZadmRXTm9aWElnWlhoalpXVmtjeUJrWlhCdmMybDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNQW9nSUNBZ0x5OGdkR2hwY3k1MlpYSnBabmxUWlhSMGJHVlRhV2R1WVhSMWNtVW9ZMmhoYm01bGJFbGtMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBMQ0J6YVdkdVlYUjFjbVVwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJdE1UVXpDaUFnSUNBdkx5QmtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RZ1BTQmpkVzExYkdGMGFYWmxRVzF2ZFc1MENpQWdJQ0F2THlCamFHRnVibVZzTG5aaGJIVmxJRDBnWTJ4dmJtVW9aR0YwWVNrS0lDQWdJSEIxYzJocGJuUWdPRElnTHk4Z09ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z2RYQmtZWFJsVm05MVkyaGxjaWhqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBPaUIxYVc1ME5qUXNJSE5wWjI1aGRIVnlaVG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSTllXNWhaMlZ5TG5ObGRIUnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRIUnNaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl3Q2lBZ0lDQXZMeUJ6WlhSMGJHVW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2dkV2x1ZERZMExDQnphV2R1WVhSMWNtVTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXlDaUFnSUNBdkx5QmhjM05sY25Rb1kyaGhibTVsYkM1bGVHbHpkSE1zSUNkRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOQW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0JrYVdjZ013b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTmdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpXVXNJQ2RQYm14NUlIQmhlV1ZsSUdOaGJpQnpaWFIwYkdVbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NHRjVaV1VnWTJGdUlITmxkSFJzWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpjS0lDQWdJQzh2SUdGemMyVnlkQ2hqZFcxMWJHRjBhWFpsUVcxdmRXNTBJRDRnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQ3dnSjA1dmRHaHBibWNnYm1WM0lIUnZJSE5sZEhSc1pTY3BDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBM05DQXZMeUEzTkFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JREVLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUm9hVzVuSUc1bGR5QjBieUJ6WlhSMGJHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTRDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZENBOFBTQmtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDd2dKMVp2ZFdOb1pYSWdaWGhqWldWa2N5QmtaWEJ2YzJsMEp5a0tJQ0FnSUdScFp5QTJDaUFnSUNCd2RYTm9hVzUwSURZMklDOHZJRFkyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QTBDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZadmRXTm9aWElnWlhoalpXVmtjeUJrWlhCdmMybDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNQW9nSUNBZ0x5OGdkR2hwY3k1MlpYSnBabmxUWlhSMGJHVlRhV2R1WVhSMWNtVW9ZMmhoYm01bGJFbGtMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBMQ0J6YVdkdVlYUjFjbVVwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdScFp5QTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBUV0Z1WVdkbGNpNTJaWEpwWm5sVFpYUjBiR1ZUYVdkdVlYUjFjbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJqYjI1emRDQndZWGx2ZFhRNklIVnBiblEyTkNBOUlHTjFiWFZzWVhScGRtVkJiVzkxYm5RZ0xTQmtZWFJoTG14aGMzUlRaWFIwYkdWa0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpRdE1UYzRDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUVGemMyVjBLRlZUUkVOZlFWTlRSVlJmU1VRcExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCa1lYUmhMbkJoZVdWbExBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nY0dGNWIzVjBMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdhVzUwWXlBMElDOHZJRlJOVUV4ZlZWTkVRMTlCVTFORlZGOUpSQW9nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOelF0TVRjNENpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJrWVhSaExuQmhlV1ZsTEFvZ0lDQWdMeThnSUNCaGMzTmxkRUZ0YjNWdWREb2djR0Y1YjNWMExBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TUFvZ0lDQWdMeThnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQ0E5SUdOMWJYVnNZWFJwZG1WQmJXOTFiblFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXlJRGMwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRneENpQWdJQ0F2THlCcFppQW9ZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDQStJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRDa2dld29nSUNBZ2NIVnphR2x1ZENBNE1pQXZMeUE0TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJRDRLSUNBZ0lHSjZJSE5sZEhSc1pWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRneUNpQWdJQ0F2THlCa1lYUmhMbXhoZEdWemRGWnZkV05vWlhKQmJXOTFiblFnUFNCamRXMTFiR0YwYVhabFFXMXZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjbVZ3YkdGalpUSWdPRElLQ25ObGRIUnNaVjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROQW9nSUNBZ0x5OGdZMmhoYm01bGJDNTJZV3gxWlNBOUlHTnNiMjVsS0dSaGRHRXBDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZd0NpQWdJQ0F2THlCelpYUjBiR1VvWTJoaGJtNWxiRWxrT2lCaWVYUmxjeXdnWTNWdGRXeGhkR2wyWlVGdGIzVnVkRG9nZFdsdWREWTBMQ0J6YVdkdVlYUjFjbVU2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1elpYUjBiR1ZNWVhSbGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSMGJHVk1ZWFJsYzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU1Bb2dJQ0FnTHk4Z2MyVjBkR3hsVEdGMFpYTjBLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TWdvZ0lDQWdMeThnWVhOelpYSjBLR05vWVc1dVpXd3VaWGhwYzNSekxDQW5RMmhoYm01bGJDQmtiMlZ6SUc1dmRDQmxlR2x6ZENjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGsyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbFpTd2dKMDl1YkhrZ2NHRjVaV1VnWTJGdUlITmxkSFJzWlNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCd1lYbGxaU0JqWVc0Z2MyVjBkR3hsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TndvZ0lDQWdMeThnWVhOelpYSjBLR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRDQStJR1JoZEdFdWJHRnpkRk5sZEhSc1pXUXNJQ2RPYjNSb2FXNW5JRzVsZHlCMGJ5QnpaWFIwYkdVbktRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT0RJZ0x5OGdPRElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0EzTkNBdkx5QTNOQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBeUNpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwYUdsdVp5QnVaWGNnZEc4Z2MyVjBkR3hsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1T1FvZ0lDQWdMeThnWTI5dWMzUWdjR0Y1YjNWME9pQjFhVzUwTmpRZ1BTQmtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RZ0xTQmtZWFJoTG14aGMzUlRaWFIwYkdWa0NpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TVMweU1EVUtJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdSaGRHRXVjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUJ3WVhsdmRYUXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1ESUtJQ0FnSUM4dklIaG1aWEpCYzNObGREb2dRWE56WlhRb1ZWTkVRMTlCVTFORlZGOUpSQ2tzQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlUwUkRYMEZUVTBWVVgwbEVDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBeExUSXdOUW9nSUNBZ0x5OGdhWFI0Ymk1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2hWVTBSRFgwRlRVMFZVWDBsRUtTd0tJQ0FnSUM4dklDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1pHRjBZUzV3WVhsbFpTd0tJQ0FnSUM4dklDQWdZWE56WlhSQmJXOTFiblE2SUhCaGVXOTFkQ3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EY3RNakE0Q2lBZ0lDQXZMeUJrWVhSaExteGhjM1JUWlhSMGJHVmtJRDBnWkdGMFlTNXNZWFJsYzNSV2IzVmphR1Z5UVcxdmRXNTBDaUFnSUNBdkx5QmphR0Z1Ym1Wc0xuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUhCMWMyaHBiblFnTnpRZ0x5OGdOelFLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVNQW9nSUNBZ0x5OGdjMlYwZEd4bFRHRjBaWE4wS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxtTnNiM05sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyeHZjMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TlFvZ0lDQWdMeThnWTJ4dmMyVW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakUzQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZMmhoYm01bGJDNWxlR2x6ZEhNc0lDZERhR0Z1Ym1Wc0lHUnZaWE1nYm05MElHVjRhWE4wSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVGtLSUNBZ0lDOHZJR052Ym5OMElHUmhkR0VnUFNCamJHOXVaU2hqYUdGdWJtVnNMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSXhDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsWlN3Z0owOXViSGtnY0dGNVpXVWdZMkZ1SUdOc2IzTmxKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djR0Y1WldVZ1kyRnVJR05zYjNObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU13b2dJQ0FnTHk4Z2RHaHBjeTVtYVc1aGJHbDZaVU5vWVc1dVpXd29ZMmhoYm01bGJFbGtMQ0JrWVhSaEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJtYVc1aGJHbDZaVU5vWVc1dVpXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UVUtJQ0FnSUM4dklHTnNiM05sS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxuSmxjWFZsYzNSRGJHOXpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGNYVmxjM1JEYkc5elpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTVDaUFnSUNBdkx5QnlaWEYxWlhOMFEyeHZjMlVvWTJoaGJtNWxiRWxrT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNeENpQWdJQ0F2THlCaGMzTmxjblFvWTJoaGJtNWxiQzVsZUdsemRITXNJQ2REYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMmhoYm01bGJDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXpRS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdjbVZ4ZFdWemRDQmpiRzl6WlNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TXkweU16UUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnlaWEYxWlhOMElHTnNiM05sSnlrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNMENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsY1hWbGMzUWdZMnh2YzJVbktRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIQmhlV1Z5SUdOaGJpQnlaWEYxWlhOMElHTnNiM05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TmdvZ0lDQWdMeThnWkdGMFlTNWpiRzl6WlZKbGNYVmxjM1JsWkVGMElEMGdiM0F1UjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16WXRNak0zQ2lBZ0lDQXZMeUJrWVhSaExtTnNiM05sVW1WeGRXVnpkR1ZrUVhRZ1BTQnZjQzVIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCamFHRnVibVZzTG5aaGJIVmxJRDBnWTJ4dmJtVW9aR0YwWVNrS0lDQWdJSEIxYzJocGJuUWdNVEEySUM4dklERXdOZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTVDaUFnSUNBdkx5QnlaWEYxWlhOMFEyeHZjMlVvWTJoaGJtNWxiRWxrT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFMWhibUZuWlhJdWQybDBhR1J5WVhkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUTBDaUFnSUNBdkx5QjNhWFJvWkhKaGR5aGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaGphR0Z1Ym1Wc0xtVjRhWE4wY3l3Z0owTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBPQW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnZDJsMGFHUnlZWGNuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORGd0TWpRNUNpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2QybDBhR1J5WVhjbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnZDJsMGFHUnlZWGNuS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhCaGVXVnlJR05oYmlCM2FYUm9aSEpoZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRBS0lDQWdJQzh2SUdGemMyVnlkQ2hrWVhSaExtTnNiM05sVW1WeGRXVnpkR1ZrUVhRZ1BpQXdMQ0FuUTJ4dmMyVWdibTkwSUhKbGNYVmxjM1JsWkNjcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEEySUM4dklERXdOZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYkc5elpTQnViM1FnY21WeGRXVnpkR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTWdvZ0lDQWdMeThnYjNBdVIyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0ErUFNCa1lYUmhMbU5zYjNObFVtVnhkV1Z6ZEdWa1FYUWdLeUJEVEU5VFJWOUhVa0ZEUlY5UVJWSkpUMFJmVTBWRFQwNUVVeXdLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ09EZzRJQzh2SURnNE9Bb2dJQ0FnS3dvZ0lDQWdQajBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV4TFRJMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCdmNDNUhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3SUQ0OUlHUmhkR0V1WTJ4dmMyVlNaWEYxWlhOMFpXUkJkQ0FySUVOTVQxTkZYMGRTUVVORlgxQkZVa2xQUkY5VFJVTlBUa1JUTEFvZ0lDQWdMeThnSUNBblEyeHZjMlVnWjNKaFkyVWdjR1Z5YVc5a0lHNXZkQ0JsYkdGd2MyVmtKeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiRzl6WlNCbmNtRmpaU0J3WlhKcGIyUWdibTkwSUdWc1lYQnpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalUyQ2lBZ0lDQXZMeUIwYUdsekxtWnBibUZzYVhwbFEyaGhibTVsYkNoamFHRnVibVZzU1dRc0lHUmhkR0VwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlHWnBibUZzYVhwbFEyaGhibTVsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTkFvZ0lDQWdMeThnZDJsMGFHUnlZWGNvWTJoaGJtNWxiRWxrT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFMWhibUZuWlhJdVpuVnVaRTFpY2xCdmIyeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtZFc1a1RXSnlVRzl2YkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZeUNpQWdJQ0F2THlCbWRXNWtUV0p5VUc5dmJDaHdZWGx0Wlc1ME9pQjdJSEpsWTJWcGRtVnlPaUJCWTJOdmRXNTBJSDBwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQlBZbXBsWTNSQlFVTkdPRFV4TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmpNS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5UFNCdmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3Z0oxQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QmpiMjUwY21GamRDY3BDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYlhWemRDQmlaU0IwYnlCamIyNTBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmpJS0lDQWdJQzh2SUdaMWJtUk5ZbkpRYjI5c0tIQmhlVzFsYm5RNklIc2djbVZqWldsMlpYSTZJRUZqWTI5MWJuUWdmU2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFMWhibUZuWlhJdWIzQjBTVzVWYzJSalczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0IwU1c1VmMyUmpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCdmNDNUhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01zSUNkUGJteDVJR055WldGMGIzSWdZMkZ1SUc5d2RDQnBiaUJWVTBSREp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHOXdkQ0JwYmlCVlUwUkRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNeTB5TnpjS0lDQWdJQzh2SUdsMGVHNHVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lIaG1aWEpCYzNObGREb2dRWE56WlhRb1ZWTkVRMTlCVTFORlZGOUpSQ2tzQ2lBZ0lDQXZMeUFnSUdGemMyVjBVbVZqWldsMlpYSTZJRzl3TGtkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM05Bb2dJQ0FnTHk4Z2VHWmxja0Z6YzJWME9pQkJjM05sZENoVlUwUkRYMEZUVTBWVVgwbEVLU3dLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWVFJFTmZRVk5UUlZSZlNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qYzFDaUFnSUNBdkx5QmhjM05sZEZKbFkyVnBkbVZ5T2lCdmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM05nb2dJQ0FnTHk4Z1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOek10TWpjM0NpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJ2Y0M1SGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjd0NpQWdJQ0F2THlCdmNIUkpibFZ6WkdNb0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwVFdGdVlXZGxjaTVuWlhSVFpYTnphVzl1VTNSaGRHbGpSR0YwWVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRk5sYzNOcGIyNVRkR0YwYVdORVlYUmhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPRFFLSUNBZ0lDOHZJR2RsZEZObGMzTnBiMjVUZEdGMGFXTkVZWFJoS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1wT2lCYmRXbHVkRFkwTENCMWFXNTBOalJkSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTROZ29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZzRMVEk0T1FvZ0lDQWdMeThnWTI5dWMzUWdaR0YwWVNBOUlHTnNiMjVsS0dOb1lXNXVaV3d1ZG1Gc2RXVXBDaUFnSUNBdkx5QnlaWFIxY200Z1cyUmhkR0V1YzNSaGNuUlNiM1Z1WkN3Z1pHRjBZUzV6ZEdGeWRGUnBiV1Z6ZEdGdGNGMEtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E1TUNBdkx5QTVNQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0a1lYUmhMbk4wWVhKMFVtOTFibVFzSUdSaGRHRXVjM1JoY25SVWFXMWxjM1JoYlhCZENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE9DMHlPRGtLSUNBZ0lDOHZJR052Ym5OMElHUmhkR0VnUFNCamJHOXVaU2hqYUdGdWJtVnNMblpoYkhWbEtRb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0a1lYUmhMbk4wWVhKMFVtOTFibVFzSUdSaGRHRXVjM1JoY25SVWFXMWxjM1JoYlhCZENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRGs0SUM4dklEazRDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnNUNpQWdJQ0F2THlCeVpYUjFjbTRnVzJSaGRHRXVjM1JoY25SU2IzVnVaQ3dnWkdGMFlTNXpkR0Z5ZEZScGJXVnpkR0Z0Y0YwS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EUUtJQ0FnSUM4dklHZGxkRk5sYzNOcGIyNVRkR0YwYVdORVlYUmhLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUmRJSHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxtZGxkRk5sYzNOcGIyNUVlVzVoYldsalJHRjBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGTmxjM05wYjI1RWVXNWhiV2xqUkdGMFlUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qazJDaUFnSUNBdkx5Qm5aWFJUWlhOemFXOXVSSGx1WVcxcFkwUmhkR0VvWTJoaGJtNWxiRWxrT2lCaWVYUmxjeWs2SUZ0MWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBYU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoamFHRnVibVZzTG1WNGFYTjBjeXdnSjBOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd01DMHpNREVLSUNBZ0lDOHZJR052Ym5OMElHUmhkR0VnUFNCamJHOXVaU2hqYUdGdWJtVnNMblpoYkhWbEtRb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0a1lYUmhMblJ2ZEdGc1JHVndiM05wZEN3Z1pHRjBZUzVzWVhOMFUyVjBkR3hsWkN3Z1pHRjBZUzVzWVhSbGMzUldiM1ZqYUdWeVFXMXZkVzUwWFFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEWTJJQzh2SURZMkNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMlJoZEdFdWRHOTBZV3hFWlhCdmMybDBMQ0JrWVhSaExteGhjM1JUWlhSMGJHVmtMQ0JrWVhSaExteGhkR1Z6ZEZadmRXTm9aWEpCYlc5MWJuUmRDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdNQzB6TURFS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoamFHRnVibVZzTG5aaGJIVmxLUW9nSUNBZ0x5OGdjbVYwZFhKdUlGdGtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDd2daR0YwWVM1c1lYTjBVMlYwZEd4bFpDd2daR0YwWVM1c1lYUmxjM1JXYjNWamFHVnlRVzF2ZFc1MFhRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTnpRZ0x5OGdOelFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzUwYjNSaGJFUmxjRzl6YVhRc0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZEYwS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBd0xUTXdNUW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0F2THlCeVpYUjFjbTRnVzJSaGRHRXVkRzkwWVd4RVpYQnZjMmwwTENCa1lYUmhMbXhoYzNSVFpYUjBiR1ZrTENCa1lYUmhMbXhoZEdWemRGWnZkV05vWlhKQmJXOTFiblJkQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnT0RJZ0x5OGdPRElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzUwYjNSaGJFUmxjRzl6YVhRc0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZEYwS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVFlLSUNBZ0lDOHZJR2RsZEZObGMzTnBiMjVFZVc1aGJXbGpSR0YwWVNoamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ1czVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalJkSUhzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMbU52YlhCMWRHVkRhR0Z1Ym1Wc1NXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjIxd2RYUmxRMmhoYm01bGJFbGtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNRGdLSUNBZ0lDOHZJR052YlhCMWRHVkRhR0Z1Ym1Wc1NXUW9jR0Y1WlhJNklFRmpZMjkxYm5Rc0lIQmhlV1ZsT2lCQlkyTnZkVzUwTENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5T2lCaWVYUmxjeXdnYzJGc2REb2dZbmwwWlhNcE9pQmllWFJsY3lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelUxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1YzJoaE1qVTJLSEJoZVdWeUxtSjVkR1Z6TG1OdmJtTmhkQ2h3WVhsbFpTNWllWFJsY3lrdVkyOXVZMkYwS0c5d0xtbDBiMklvVlZORVExOUJVMU5GVkY5SlJDa3BMbU52Ym1OaGRDaHpZV3gwS1M1amIyNWpZWFFvWVhWMGFHOXlhWHBsWkZOcFoyNWxjaWtwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekE0Q2lBZ0lDQXZMeUJqYjIxd2RYUmxRMmhoYm01bGJFbGtLSEJoZVdWeU9pQkJZMk52ZFc1MExDQndZWGxsWlRvZ1FXTmpiM1Z1ZEN3Z1lYVjBhRzl5YVhwbFpGTnBaMjVsY2pvZ1lubDBaWE1zSUhOaGJIUTZJR0o1ZEdWektUb2dZbmwwWlhNZ2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMU1EQXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxuTmxkSFJzWlUxbGMzTmhaMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUjBiR1ZOWlhOellXZGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNVFVLSUNBZ0lDOHZJSE5sZEhSc1pVMWxjM05oWjJVb1kyaGhibTVsYkVsa09pQmllWFJsY3l3Z1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ1lubDBaWE1nZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekUyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1blpYUlRaWFIwYkdWTlpYTnpZV2RsS0dOb1lXNXVaV3hKWkN3Z1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZENrS0lDQWdJR05oYkd4emRXSWdaMlYwVTJWMGRHeGxUV1Z6YzJGblpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1UVUtJQ0FnSUM4dklITmxkSFJzWlUxbGMzTmhaMlVvWTJoaGJtNWxiRWxrT2lCaWVYUmxjeXdnWTNWdGRXeGhkR2wyWlVGdGIzVnVkRG9nZFdsdWREWTBLVG9nWW5sMFpYTWdld29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSTllXNWhaMlZ5TG5abGNtbG1lVk5sZEhSc1pWTnBaMjVoZEhWeVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJekNpQWdJQ0F2THlCMlpYSnBabmxUWlhSMGJHVlRhV2R1WVhSMWNtVW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2dkV2x1ZERZMExDQnphV2R1WVhSMWNtVTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwVFdGdVlXZGxjaTUyWlhKcFpubFRaWFIwYkdWVGFXZHVZWFIxY21VS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMbVJsY21sMlpVTm9ZVzV1Wld4SlpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsY21sMlpVTm9ZVzV1Wld4SlpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VXlDaUFnSUNBdkx5QmtaWEpwZG1WRGFHRnVibVZzU1dRb2NHRjVaWEk2SUVGalkyOTFiblFzSUhCaGVXVmxPaUJCWTJOdmRXNTBMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlPaUJpZVhSbGN5d2djMkZzZERvZ1lubDBaWE1wT2lCaWVYUmxjeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VTFDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVjMmhoTWpVMktIQmhlV1Z5TG1KNWRHVnpMbU52Ym1OaGRDaHdZWGxsWlM1aWVYUmxjeWt1WTI5dVkyRjBLRzl3TG1sMGIySW9WVk5FUTE5QlUxTkZWRjlKUkNrcExtTnZibU5oZENoellXeDBLUzVqYjI1allYUW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNpa3BDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlUwUkRYMEZUVTBWVVgwbEVDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VXlDaUFnSUNBdkx5QmtaWEpwZG1WRGFHRnVibVZzU1dRb2NHRjVaWEk2SUVGalkyOTFiblFzSUhCaGVXVmxPaUJCWTJOdmRXNTBMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlPaUJpZVhSbGN5d2djMkZzZERvZ1lubDBaWE1wT2lCaWVYUmxjeUI3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelV3TURJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1ZG1WeWFXWjVVMlYwZEd4bFUybG5ibUYwZFhKbEtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklIVnBiblEyTkN3Z2MybG5ibUYwZFhKbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1MlpYSnBabmxUWlhSMGJHVlRhV2R1WVhSMWNtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlNd29nSUNBZ0x5OGdkbVZ5YVdaNVUyVjBkR3hsVTJsbmJtRjBkWEpsS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUdOMWJYVnNZWFJwZG1WQmJXOTFiblE2SUhWcGJuUTJOQ3dnYzJsbmJtRjBkWEpsT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJM0NpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15T0FvZ0lDQWdMeThnWTI5dWMzUWdiV1Z6YzJGblpTQTlJSFJvYVhNdVoyVjBVMlYwZEd4bFRXVnpjMkZuWlNoamFHRnVibVZzU1dRc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJUWlhSMGJHVk5aWE56WVdkbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1SUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JpZVhSbGN6NG9leUJyWlhsUWNtVm1hWGc2SUNkd0p5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSndJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek14Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTNWxlR2x6ZEhNc0lDZEJkWFJvYjNKcGVtVmtJSE5wWjI1bGNpQndkV0pzYVdNZ2EyVjVJRzV2ZENCelpYUWdlV1YwSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FYVjBhRzl5YVhwbFpDQnphV2R1WlhJZ2NIVmliR2xqSUd0bGVTQnViM1FnYzJWMElIbGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNek1LSUNBZ0lDOHZJR052Ym5OMElHRjFkR2h2Y21sNlpXUlRhV2R1WlhJZ1BTQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNUxuWmhiSFZsQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0NuTnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFMWhibUZuWlhJdWRtVnlhV1o1VTJWMGRHeGxVMmxuYm1GMGRYSmxYM2RvYVd4bFgzUnZjRUEwT2dvZ0lDQWdjSFZ6YUdsdWRDQXlNVEV3SUM4dklESXhNVEFLSUNBZ0lHZHNiMkpoYkNCUGNHTnZaR1ZDZFdSblpYUUtJQ0FnSUQ0S0lDQWdJR0o2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1ZG1WeWFXWjVVMlYwZEd4bFUybG5ibUYwZFhKbFgyRm1kR1Z5WDNkb2FXeGxRRGtLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNRFk0TVRBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREEyT0RFd01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlFvZ0lDQWdaMnh2WW1Gc0lFMXBibFI0YmtabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpSUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1ZG1WeWFXWjVVMlYwZEd4bFUybG5ibUYwZFhKbFgzZG9hV3hsWDNSdmNFQTBDZ3B6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlY5aFpuUmxjbDkzYUdsc1pVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNellLSUNBZ0lDOHZJR0Z6YzJWeWRDaHphR0UxTVRKZk1qVTJLR0YxZEdodmNtbDZaV1JUYVdkdVpYSXBJRDA5UFNCa1lYUmhMbUYxZEdodmNtbDZaV1JUYVdkdVpYSXNJQ2RKYm5aaGJHbGtJSE5wWjI1bGNpQndkV0pyWlhrbktRb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJSE5vWVRVeE1sOHlOVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJSE5wWjI1bGNpQndkV0pyWlhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpNNENpQWdJQ0F2THlCcFppQW9jMmxuYm1GMGRYSmxMbXhsYm1kMGFDQStJRFkwS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lIQjFjMmhwYm5RZ05qUWdMeThnTmpRS0lDQWdJRDRLSUNBZ0lHSjZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRTFoYm1GblpYSXVkbVZ5YVdaNVUyVjBkR3hsVTJsbmJtRjBkWEpsWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOREFLSUNBZ0lDOHZJSEpsZEhWeWJnb2dJQ0FnY21WMGMzVmlDZ3B6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWVhOelpYSjBLSE5wWjI1aGRIVnlaUzVzWlc1bmRHZ2dQVDA5SURZMExDQW5TVzUyWVd4cFpDQkZaREkxTlRFNUlITnBaMjVoZEhWeVpTQnNaVzVuZEdnbktRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSEIxYzJocGJuUWdOalFnTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0JGWkRJMU5URTVJSE5wWjI1aGRIVnlaU0JzWlc1bmRHZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UTBDaUFnSUNBdkx5QmpiMjV6ZENCemFXZHVZWFIxY21WSmMxWmhiR2xrSUQwZ2IzQXVaV1F5TlRVeE9YWmxjbWxtZVVKaGNtVW9iV1Z6YzJGblpTd2djMmxuYm1GMGRYSmxMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1ZrTWpVMU1UbDJaWEpwWm5sZlltRnlaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHphV2R1WVhSMWNtVkpjMVpoYkdsa0xDQW5TVzUyWVd4cFpDQnphV2R1WVhSMWNtVW5LUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ2MybG5ibUYwZFhKbENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSTllXNWhaMlZ5TG1Gd2NHeDVWRzl3VlhBb1pHRjBZVG9nWW5sMFpYTXNJR04xYlhWc1lYUnBkbVZCYlc5MWJuUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbUZ3Y0d4NVZHOXdWWEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yTkFvZ0lDQWdMeThnY0hKcGRtRjBaU0JoY0hCc2VWUnZjRlZ3S0dSaGRHRTZJRU5vWVc1dVpXeEpibVp2TENCamRXMTFiR0YwYVhabFFXMXZkVzUwT2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmpVS0lDQWdJQzh2SUdGemMyVnlkQ2hqZFcxMWJHRjBhWFpsUVcxdmRXNTBMbk5sYm1SbGNpQTlQVDBnVkhodUxuTmxibVJsY2l3Z0oxQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxcGMyMWhkR05vSnlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJOZ29nSUNBZ0x5OGdZWE56WlhKMEtHTjFiWFZzWVhScGRtVkJiVzkxYm5RdVlYTnpaWFJTWldObGFYWmxjaUE5UFQwZ2IzQXVSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0lDZFFZWGx0Wlc1MElHMTFjM1FnWW1VZ2RHOGdZMjl1ZEhKaFkzUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelkzQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDNTRabVZ5UVhOelpYUXVhV1FnUFQwOUlGVlRSRU5mUVZOVFJWUmZTVVFzSUNkUVlYbHRaVzUwSUdGemMyVjBJRzExYzNRZ1ltVWdWVk5FUXljcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGaG1aWEpCYzNObGRBb2dJQ0FnYVc1MFl5QTBJQzh2SUZSTlVFeGZWVk5FUTE5QlUxTkZWRjlKUkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGx0Wlc1MElHRnpjMlYwSUcxMWMzUWdZbVVnVlZORVF3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoamRXMTFiR0YwYVhabFFXMXZkVzUwTG1GemMyVjBRVzF2ZFc1MElENGdNQ3dnSjBSbGNHOXphWFFnYlhWemRDQmlaU0ErSURBbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJjM05sZEVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1JHVndiM05wZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5qa0tJQ0FnSUM4dklHRnpjMlZ5ZENoamRXMTFiR0YwYVhabFFXMXZkVzUwTG1GemMyVjBVMlZ1WkdWeUlEMDlQU0JCWTJOdmRXNTBLQ2tzSUNkRGJHRjNZbUZqYXlCMGNtRnVjMlpsY2lCdWIzUWdZV3hzYjNkbFpDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRUZ6YzJWMFUyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUTJ4aGQySmhZMnNnZEhKaGJuTm1aWElnYm05MElHRnNiRzkzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpjd0NpQWdJQ0F2THlCaGMzTmxjblFvWTNWdGRXeGhkR2wyWlVGdGIzVnVkQzVoYzNObGRFTnNiM05sVkc4Z1BUMDlJRUZqWTI5MWJuUW9LU3dnSjBGemMyVjBJR05zYjNObElHNXZkQ0JoYkd4dmQyVmtKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVhOelpYUkRiRzl6WlZSdkNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FYTnpaWFFnWTJ4dmMyVWdibTkwSUdGc2JHOTNaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemN5Q2lBZ0lDQXZMeUJrWVhSaExuUnZkR0ZzUkdWd2IzTnBkQ0FyUFNCamRXMTFiR0YwYVhabFFXMXZkVzUwTG1GemMyVjBRVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdOallnTHk4Z05qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJRFkyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zTkFvZ0lDQWdMeThnWkdGMFlTNWpiRzl6WlZKbGNYVmxjM1JsWkVGMElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTVRBMkNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1Wm1sdVlXeHBlbVZEYUdGdWJtVnNLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXNJR1JoZEdFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1ptbHVZV3hwZW1WRGFHRnVibVZzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnpjS0lDQWdJQzh2SUhCeWFYWmhkR1VnWm1sdVlXeHBlbVZEYUdGdWJtVnNLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXNJR1JoZEdFNklFTm9ZVzV1Wld4SmJtWnZLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpjNENpQWdJQ0F2THlCamIyNXpkQ0J3WVhsbFpWQmhlVzkxZERvZ2RXbHVkRFkwSUQwZ1pHRjBZUzVzWVhSbGMzUldiM1ZqYUdWeVFXMXZkVzUwSUMwZ1pHRjBZUzVzWVhOMFUyVjBkR3hsWkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEZ3lJQzh2SURneUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOelFnTHk4Z056UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpjNUNpQWdJQ0F2THlCcFppQW9jR0Y1WldWUVlYbHZkWFFnUGlBd0tTQjdDaUFnSUNCaWVpQm1hVzVoYkdsNlpVTm9ZVzV1Wld4ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TUMwek9EUUtJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdSaGRHRXVjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUJ3WVhsbFpWQmhlVzkxZEN3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TVFvZ0lDQWdMeThnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2hWVTBSRFgwRlRVMFZVWDBsRUtTd0tJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZUUkVOZlFWTlRSVlJmU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpneUNpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJrWVhSaExuQmhlV1ZsTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPREF0TXpnMENpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJrWVhSaExuQmhlV1ZsTEFvZ0lDQWdMeThnSUNCaGMzTmxkRUZ0YjNWdWREb2djR0Y1WldWUVlYbHZkWFFzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbVpwYm1Gc2FYcGxRMmhoYm01bGJGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNE53b2dJQ0FnTHk4Z1kyOXVjM1FnY0dGNVpYSlNaV1oxYm1RNklIVnBiblEyTkNBOUlHUmhkR0V1ZEc5MFlXeEVaWEJ2YzJsMElDMGdaR0YwWVM1c1lYUmxjM1JXYjNWamFHVnlRVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOallnTHk4Z05qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemc0Q2lBZ0lDQXZMeUJwWmlBb2NHRjVaWEpTWldaMWJtUWdQaUF3S1NCN0NpQWdJQ0JpZWlCbWFXNWhiR2w2WlVOb1lXNXVaV3hmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRPUzB6T1RNS0lDQWdJQzh2SUdsMGVHNHVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lIaG1aWEpCYzNObGREb2dRWE56WlhRb1ZWTkVRMTlCVTFORlZGOUpSQ2tzQ2lBZ0lDQXZMeUFnSUdGemMyVjBVbVZqWldsMlpYSTZJR1JoZEdFdWNHRjVaWElzQ2lBZ0lDQXZMeUFnSUdGemMyVjBRVzF2ZFc1ME9pQndZWGxsY2xKbFpuVnVaQ3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVNQW9nSUNBZ0x5OGdlR1psY2tGemMyVjBPaUJCYzNObGRDaFZVMFJEWDBGVFUwVlVYMGxFS1N3S0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgxVlRSRU5mUVZOVFJWUmZTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemt4Q2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQmtZWFJoTG5CaGVXVnlMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNE9TMHpPVE1LSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpYSXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbGxjbEpsWm5WdVpDd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1ptbHVZV3hwZW1WRGFHRnVibVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemsyQ2lBZ0lDQXZMeUIwYUdsekxtTm9ZVzV1Wld4ektHTm9ZVzV1Wld4SlpDa3VaR1ZzWlhSbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1elpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpDaGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWekxDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNU9pQmllWFJsY3l3Z1pYaHdaV04wWldSQmRYUm9iM0pwZW1Wa1UybG5ibVZ5U0dGemFEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuTmxkRUYxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYbEpabEJ5YjNacFpHVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPVGt0TkRBekNpQWdJQ0F2THlCd2NtbDJZWFJsSUhObGRFRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhsSlpsQnliM1pwWkdWa0tBb2dJQ0FnTHk4Z0lDQmphR0Z1Ym1Wc1NXUTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNU9pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ1pYaHdaV04wWldSQmRYUm9iM0pwZW1Wa1UybG5ibVZ5U0dGemFEb2dZbmwwWlhNc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNRFFLSUNBZ0lDOHZJR2xtSUNoaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1TG14bGJtZDBhQ0ErSURBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JpZWlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBMUNpQWdJQ0F2THlCaGMzTmxjblFvYzJoaE5URXlYekkxTmloaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1S1NBOVBUMGdaWGh3WldOMFpXUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVNHRnphQ3dnSjBGMWRHaHZjbWw2WldRZ2MybG5ibVZ5SUdoaGMyZ2diV2x6YldGMFkyZ25LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemFHRTFNVEpmTWpVMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSWdhR0Z6YUNCdGFYTnRZWFJqYUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlU0E5SUVKdmVFMWhjRHhpZVhSbGN5d2dZbmwwWlhNK0tIc2dhMlY1VUhKbFptbDRPaUFuY0NjZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWNDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdOd29nSUNBZ0x5OGdZWFYwYUc5eWFYcGxaRk5wWjI1bGNrdGxlUzUyWVd4MVpTQTlJR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdmVGOXdkWFFLQ25ObGRFRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhsSlpsQnliM1pwWkdWa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1WjJWMFUyVjBkR3hsVFdWemMyRm5aU2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSVFpYUjBiR1ZOWlhOellXZGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNVEVLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdaMlYwVTJWMGRHeGxUV1Z6YzJGblpTaGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWekxDQmpkVzExYkdGMGFYWmxRVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQmllWFJsY3lCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREV6Q2lBZ0lDQXZMeUF1YVhSdllpaHZjQzVIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1F1YVdRcENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREV5TFRReE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0NpQWdJQ0F2THlBZ0lDNXBkRzlpS0c5d0xrZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDNXBaQ2tLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREV5TFRReE5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc5d0NpQWdJQ0F2THlBZ0lDNXBkRzlpS0c5d0xrZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDNXBaQ2tLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2hqYUdGdWJtVnNTV1FwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRVS0lDQWdJQzh2SUM1amIyNWpZWFFvYjNBdWFYUnZZaWhqZFcxMWJHRjBhWFpsUVcxdmRXNTBLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNVEl0TkRFMUNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBS0lDQWdJQzh2SUNBZ0xtbDBiMklvYjNBdVIyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2Ymtsa0xtbGtLUW9nSUNBZ0x5OGdJQ0F1WTI5dVkyRjBLR05vWVc1dVpXeEpaQ2tLSUNBZ0lDOHZJQ0FnTG1OdmJtTmhkQ2h2Y0M1cGRHOWlLR04xYlhWc1lYUnBkbVZCYlc5MWJuUXBLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4TmdvZ0lDQWdMeThnTG1OdmJtTmhkQ2hDZVhSbGN5Z25jMlYwZEd4bEp5a3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTmxkSFJzWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFeUxUUXhOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHOXdDaUFnSUNBdkx5QWdJQzVwZEc5aUtHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVwWkNrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoamFHRnVibVZzU1dRcENpQWdJQ0F2THlBZ0lDNWpiMjVqWVhRb2IzQXVhWFJ2WWloamRXMTFiR0YwYVhabFFXMXZkVzUwS1NrS0lDQWdJQzh2SUNBZ0xtTnZibU5oZENoQ2VYUmxjeWduYzJWMGRHeGxKeWtwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBQUlCQ0FBbUJRWVZIM3gxQUNBRUZSOThkUUlBSUFBREJvRUJNUnRCQUlZeEdSUkVNUmhFZ2hFRVNOVStNZ1M5ejZ4WUJFc2R1MmNFcVkyQzJnVDMzNDNpQkc2SEo0a0U2R3JwNlFRMGFGQlFCRmtGMVBRRXFoVEUrUVIrUDBwb0JLaHdTUU1FSHB3QWtBU01UUHozQkdjZzJQOEVKd1NTaVFRcjlnbmdOaG9BamhFQUN3RC9BVGtCbEFIOEFwUUM0d01OQXpVRGNBT0NBNTREeWdRREJFa0Vjd1NoQURFWkZERVlGQkJFSkVNMkdnRkhBaFdCSUJKRU1SWWtDVWxPQWpnUWdRUVNSRFlhQWtraVdTTUlTd0VWRWtSWEFnQTJHZ05KSWxrakNFc0JGUkpFVndJQVNVNEVOaG9FU1NKWkl3aExBUlVTUkZjQ0FFNEVTUU5PQlRFQVR3TlFJUVFXVUU4Q1VFeFFBVWxPQTcxRkFVQUFTRElHTWdjeEFFc0lVQ3BMQjFCTWdBSUFjbEFpRmt4TEFWQkxBVkJMQVZCUEJCWlFUd01XVUV4UVRGQkxBMGxPQWs4RVN3ZUlCVlJQQW9nRXFrc0J2RWkvS0VzQlVMQWtRMHNDU2I1RU1RQkxBaUtCSUxvU1JFc0JnU0JKdWtzSUVrUkpnVUJaU3dFVlN3Sk9BbEpYQWdCTEIwc0JFa1JMQWs4RlR3S0lCUXhQQW9nRVlrc0J2RWkvUXYrMU5ob0JTU0paSXdoTEFSVVNSRmNDQURFV0pBbEpPQkNCQkJKRVN3RzlSUUZFU3dHK1NFd3hBRXNESW9FZ3VoSkVpQVFuU3dHOFNMOGtRellhQVVraVdTTUlTd0VWRWtSWEFnQTJHZ0pKSWxrakNFc0JGUkpFVndJQVN3RzlSUUZFU3dHK1NFNENNUUJMQWlLQklMb1NSRWtWUkVrRFN3SlBBa3NDaUFTQktreFFTd0tCUUZsUEF5SlBBbGhNVUVzQnZFaS9KRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUkpGellhQTBraVdTTUlTd0VWRWtSWEFnQkxBNzFGQVVReEFFc0VJb0VndWhKRVN3T0JTaVc2RjBzQ0RrUkxBNEZTSmJvWFN3SU1SRXNEZ1VJbHVoZExBZzlFU3dOT0FvZ0M4WUZTVExza1F6WWFBVWtpV1NNSVN3RVZFa1JYQWdCSk5ob0NTVTRDU1JVbEVrUkpGellhQTBraVdTTUlTd0VWRWtSWEFnQkxBNzFGQVVSTEE3NUlUZ014QUVzRmdTQkp1a3hMQVJKRVN3V0JTaVc2RjBzRFN3RU5SRXNHZ1VJbHVoZExCQTlFVHdaTEJFOEVpQUtEU3dKTUNiRWhCTElSc2hLeUZJRUVzaEFpc2dHelRnSmNTa2xPQW9GU1d3MUJBQVJMQVZ4U1N3Skp2RWhNdnlSRE5ob0JTU0paSXdoTEFSVVNSRmNDQUVtOVJRRkVNUUJMQVlFZ1NicE1Td0VTUkVzQmdWSWx1a2tYU3dPQlNpVzZGMG9OUkFteElRUk1zaEpQQXJJVXNoR0JCTElRSXJJQnM0RktUTHNrUXpZYUFVa2lXU01JU3dFVkVrUlhBZ0JKdlVVQlJFbStTRXd4QUVzQmdTQkp1aEpFVElnQ21VZ2tRellhQVVraVdTTUlTd0VWRWtSWEFnQkp2VVVCUkRFQVN3RWlnU0M2RWtReUJ4YUJha3k3SkVNMkdnRkpJbGtqQ0VzQkZSSkVWd0lBU2IxRkFVUkp2a2hNTVFCTEFTS0JJTG9TUkVtQmFpVzZGMGxFTWdkTWdmZ0dDQTlFVElnQ05rZ2tRellhQVVrVmdTQVNSRmNBSURJS0VrUWtRekVBTWdrU1JMRWhCRElLSXJJU3NoU3lFWUVFc2hBaXNnR3pKRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFTYjFGQVVSSmdWb2x1aGRNZ1dJbHVoZE1Ga3dXVUNsTVVMQWtRellhQVVraVdTTUlTd0VWRWtSWEFnQkp2VVVCUkVtQlFpVzZGMHNCZ1VvbHVoZFBBb0ZTSmJvWFR3SVdUd0lXVUV3V1VDbE1VTEFrUXpZYUFVa1ZnU0FTUkRZYUFra1ZnU0FTUkRZYUEwa2lXU01JU3dFVkVrUlhBZ0EyR2dSSklsa2pDRXNCRlJKRVZ3SUFUd05QQTFBaEJCWlFURkJNVUFFb1RGQ3dKRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUVhpQUcyU1JVV1Z3WUNURkFwVEZDd0pFTTJHZ0ZKSWxrakNFc0JGUkpFVndJQU5ob0NTUlVsRWtRWE5ob0RTU0paSXdoTEFSVVNSRmNDQUlnQVNDUkROaG9CU1JXQklCSkVOaG9DU1JXQklCSkVOaG9EU1NKWkl3aExBUlVTUkZjQ0FEWWFCRWtpV1NNSVN3RVZFa1JYQWdCUEEwOERVQ0VFRmxCTVVFeFFBU2hNVUxBa1E0b0RBQ3VML2IxRkFVU0wvYjVJaS8yTC9vZ0JINEFCY0l2OVVFbTlSUUZFdmtpQnZoQXlEQTFCQUJteGdRYXlFSUVGc2hrbkJMSWVKd1N5SHpJQXNnR3pRdi9laXdNRGl3RkpnVUJaU3dFVlVsY0NBQkpFaS84VlNZd0FnVUFOUVFBQmlZc0FnVUFTUklzQ2kvK0xBNFJFaVlvQ0FZdi9PQUF4QUJKRWkvODRGRElLRWtTTC96Z1JJUVFTUkl2L09CSkpSSXYvT0JNeUF4SkVpLzg0RlRJREVrU0wvb0ZDV3dnV2kvNU1YRUtNL2lJV2kvNU1YR3BKalA2SmlnSUJLNHYvZ1ZKYlNZdi9nVXBiQ1VsQkFCaXhJUVNMLzFjZ0lJc0NzaEt5RkxJUmdRU3lFQ0t5QWJPTC80RkNXNHNCQ1VtTUFFRUFHTEVoQkl2L1Z3QWdpd0N5RXJJVXNoR0JCTElRSXJJQnM0dit2RWlMLzR3QWlZb0RBSXYrRlVFQUU0ditBNHYvRWtTQUFYQ0wvVkJKdkVpTC9yK0ppZ0lCTWdnV2kvNVFpLzhXVUlBR2MyVjBkR3hsVUlrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlVTRENfQVNTRVRfSUQiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
