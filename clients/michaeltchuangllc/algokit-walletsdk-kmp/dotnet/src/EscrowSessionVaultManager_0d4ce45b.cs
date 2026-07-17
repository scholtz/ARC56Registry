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

namespace Arc56.Generated.michaeltchuangllc.algokit_walletsdk_kmp.EscrowSessionVaultManager_0d4ce45b
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93U2Vzc2lvblZhdWx0TWFuYWdlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3Q0M0JDNUExMCI6W3sibmFtZSI6InBheWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXllZSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJ0b3RhbERlcG9zaXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdFNldHRsZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGF0ZXN0Vm91Y2hlckFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFydFJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXJ0VGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNsb3NlUmVxdWVzdGVkQXQiLCJ0eXBlIjoidWludDY0In1dLCJPYmplY3RBQUNGODUxMCI6W3sibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6ImFkZHJlc3MifV0sIkdldFNlc3Npb25TdGF0aWNEYXRhUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV0sIkdldFNlc3Npb25EeW5hbWljRGF0YVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcGVuIiwiZGVzYyI6Ik9wZW5zIGEgY2hhbm5lbCB3aXRoIGluaXRpYWwgVVNEQyBkZXBvc2l0IGFuZCByZXR1cm5zIGRlcml2ZWQgY2hhbm5lbElkLlxuQ2FsbGVyIGJlY29tZXMgcGF5ZXIuXG5hdXRob3JpemVkU2lnbmVyIGlzIHNpZ25lciBwdWJrZXkgaGFzaCAoMzIgYnl0ZXMpIGNvbXB1dGVkIGNsaWVudC1zaWRlLlxuYXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSBpcyBvcHRpb25hbDogaWYgcHJvdmlkZWQsIHN0b3JlcyBmdWxsIHNpZ25lciBwdWJrZXkgaW4gYm94LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvcFVwIiwiZGVzYyI6IkFkZHMgZnVuZHMgdG8gYW4gZXhpc3RpbmcgY2hhbm5lbCB1c2luZyBhIGdyb3VwZWQgVVNEQyBhc3NldCB0cmFuc2Zlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1bXVsYXRpdmVBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSIsImRlc2MiOiJTZXQgZnVsbCBhdXRob3JpemVkIHNpZ25lciBwdWJsaWMga2V5IGFuZCB1cGRhdGUgY2hhbm5lbC5hdXRob3JpemVkU2lnbmVyIGhhc2guIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lclB1YmxpY0tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVWb3VjaGVyIiwiZGVzYyI6IlN0b3JlcyBsYXRlc3QgY3VtdWxhdGl2ZSB2b3VjaGVyIGFtb3VudCBvbi1jaGFpbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdW11bGF0aXZlQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlIiwiZGVzYyI6IlBheWVlIHNldHRsZXMgc2lnbmVkIHZvdWNoZXIgZnVuZHMsIHdpdGggc3VwcG9ydCBmb3IgcGFydGlhbCBzZXR0bGVtZW50LlxuQWxzbyBhZHZhbmNlcyBsYXRlc3RWb3VjaGVyQW1vdW50IHdoZW4gdGhlIHN1Ym1pdHRlZCBzaWduZWQgdm91Y2hlciBpcyBuZXdlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdW11bGF0aXZlQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0dGxlTGF0ZXN0IiwiZGVzYyI6IkhlbHBlciBmb3IgcGF5ZWU6IHNldHRsZSBhbGwgY3VycmVudGx5IHVuY2xhaW1lZCB2b3VjaGVyIGFtb3VudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsb3NlIiwiZGVzYyI6IlBheWVlIGNsb3NlcyBjaGFubmVsLlxuSG9ub3JzIHRoZSBsYXRlc3Qgb24tY2hhaW4gdm91Y2hlciBiZWZvcmUgcmVmdW5kaW5nIHRoZSBwYXllci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcXVlc3RDbG9zZSIsImRlc2MiOiJQYXllciByZXF1ZXN0cyBjaGFubmVsIGNsb3N1cmUsIHN0YXJ0aW5nIGZvcmNlZC1jbG9zZSBncmFjZSBwZXJpb2QuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNoYW5uZWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOiJQYXllciB3aXRoZHJhd3MgcmVtYWluaW5nIGZ1bmRzIGFmdGVyIGdyYWNlIHBlcmlvZCBleHBpcmVzLlxuSG9ub3JzIHRoZSBsYXRlc3Qgb24tY2hhaW4gdm91Y2hlciBiZWZvcmUgcmVmdW5kaW5nIHRoZSBwYXllci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ1bmRNYnJQb29sIiwiZGVzYyI6IkZ1bmRzIE1CUi9mZWVzIHBvb2wgdXNpbmcgQUxHTy4iLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MpIiwic3RydWN0IjoiT2JqZWN0QUFDRjg1MTAiLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJblVzZGMiLCJkZXNjIjoiT3B0IGFwcCBhY2NvdW50IGludG8gY29uZmlndXJlZCBVU0RDIEFTQSBzbyBpdCBjYW4gcmVjZWl2ZSBkZXBvc2l0cy5cblNob3VsZCBiZSBjYWxsZWQgb25jZSBieSBhZG1pbi9jcmVhdG9yLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTZXNzaW9uU3RhdGljRGF0YSIsImRlc2MiOiJSZXR1cm5zIGxhdGVzdCBzZXNzaW9uIHN0YXRpYyBkYXRhIHR1cGxlOlxuW3N0YXJ0Um91bmQsIHN0YXJ0VGltZXN0YW1wXSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0U2Vzc2lvblN0YXRpY0RhdGFSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRTZXNzaW9uRHluYW1pY0RhdGEiLCJkZXNjIjoiUmV0dXJucyBsYXRlc3Qgc2Vzc2lvbiBkeW5hbWljIGRhdGEgdHVwbGU6XG5bdG90YWxEZXBvc2l0LCBsYXN0U2V0dGxlZCwgbGF0ZXN0Vm91Y2hlckFtb3VudF0iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRTZXNzaW9uRHluYW1pY0RhdGFSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21wdXRlQ2hhbm5lbElkIiwiZGVzYyI6IkJhY2t3YXJkcy1jb21wYXRpYmxlIGFsaWFzIGZvciBkZXRlcm1pbmlzdGljIGNoYW5uZWxJZCBkZXJpdmF0aW9uLlxuYXV0aG9yaXplZFNpZ25lciBtdXN0IGJlIHNpZ25lciBwdWJrZXkgaGFzaCAoMzIgYnl0ZXMpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXplZFNpZ25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldHRsZU1lc3NhZ2UiLCJkZXNjIjoiUmVhZC1vbmx5IGhlbHBlciBmb3IgY2xpZW50czogZXhhY3QgYnl0ZXMgc2lnbmVkIGZvciBzZXR0bGUvdXBkYXRlVm91Y2hlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hhbm5lbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdW11bGF0aXZlQW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5U2V0dGxlU2lnbmF0dXJlIiwiZGVzYyI6IlJlYWQtb25seSBoZWxwZXIgZm9yIGNsaWVudHM6IHZlcmlmaWVzIHNldHRsZSBhdXRob3JpemF0aW9uIGV4YWN0bHkgYXMgc2V0dGxlL3VwZGF0ZVZvdWNoZXIgZG8uXG5Vc2VzIGZ1bGwgYXV0aG9yaXplZCBzaWduZXIgcHVibGljIGtleSBzdG9yZWQgaW4gYSBib3ggZm9yIHRoZSBjaGFubmVsLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaGFubmVsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1bXVsYXRpdmVBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXJpdmVDaGFubmVsSWQiLCJkZXNjIjoiUmVhZC1vbmx5IGhlbHBlciBmb3IgY2xpZW50czogZGV0ZXJtaW5pc3RpYyBjaGFubmVsSWQgZGVyaXZhdGlvbi5cbmF1dGhvcml6ZWRTaWduZXIgbXVzdCBiZSBzaWduZXIgcHVia2V5IGhhc2ggKDMyIGJ5dGVzKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvcml6ZWRTaWduZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1NjldLCJlcnJvck1lc3NhZ2UiOiJBc3NldCBjbG9zZSBub3QgYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3OSwxNzAxXSwiZXJyb3JNZXNzYWdlIjoiQXV0aG9yaXplZCBzaWduZXIgaGFzaCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNF0sImVycm9yTWVzc2FnZSI6IkF1dGhvcml6ZWQgc2lnbmVyIHB1YmtleSByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MzhdLCJlcnJvck1lc3NhZ2UiOiJBdXRob3JpemVkIHNpZ25lciBwdWJsaWMga2V5IG5vdCBzZXQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQwXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNCw0OTYsNjAwLDcxMSw4MzMsOTEzLDk1NCw5OTMsMTA5NywxMTQzLDE0MThdLCJlcnJvck1lc3NhZ2UiOiJDaGFubmVsIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU2MV0sImVycm9yTWVzc2FnZSI6IkNsYXdiYWNrIHRyYW5zZmVyIG5vdCBhbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyNF0sImVycm9yTWVzc2FnZSI6IkNsb3NlIGdyYWNlIHBlcmlvZCBub3QgZWxhcHNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTVdLCJlcnJvck1lc3NhZ2UiOiJDbG9zZSBub3QgcmVxdWVzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU1M10sImVycm9yTWVzc2FnZSI6IkRlcG9zaXQgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTExXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBFZDI1NTE5IHNpZ25hdHVyZSBsZW5ndGgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTE5XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzaWduYXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDkyXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzaWduZXIgcHVia2V5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQzLDg2NV0sImVycm9yTWVzc2FnZSI6Ik5vdGhpbmcgbmV3IHRvIHNldHRsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDU0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBvcHQgaW4gVVNEQyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZWUgY2FuIGNsb3NlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI5LDg0NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZWUgY2FuIHNldHRsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHJlb3BlbiBjaGFubmVsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTYzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBwYXllciBjYW4gcmVxdWVzdCBjbG9zZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHNldCBhdXRob3JpemVkIHNpZ25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHRvcCB1cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwOV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHVwZGF0ZSB2b3VjaGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGF5ZXIgY2FuIHdpdGhkcmF3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU4XSwiZXJyb3JNZXNzYWdlIjoiUGF5ZWUgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTQ3XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBhc3NldCBtdXN0IGJlIFVTREMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQ2LDE1MzldLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTMxXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzFdLCJlcnJvck1lc3NhZ2UiOiJTaWduZXIgaGFzaCBtdXN0IGJlIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIxXSwiZXJyb3JNZXNzYWdlIjoiVm91Y2hlciBiZWxvdyBzZXR0bGVkIGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0NSw3NTVdLCJlcnJvck1lc3NhZ2UiOiJWb3VjaGVyIGV4Y2VlZHMgZGVwb3NpdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzM10sImVycm9yTWVzc2FnZSI6IlZvdWNoZXIgbm90IGluY3JlYXNpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYsMTkyLDIxMSw0MDcsNDY0LDQ4MCw1NTcsNTg0LDY2NCw2OTUsODE4LDg5OCw5MzksOTc4LDEwODIsMTEyOCwxMjA0LDEyMjAsMTI1NiwxMjk5LDEzMjUsMTM2MiwxMzc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBPYmplY3RBQUNGODUxMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MywxOTksMjE4LDQxNCw0NzEsNDg3LDU2NCw1OTEsNjcxLDcwMiw4MjUsOTA1LDk0Niw5ODUsMTA4OSwxMTM1LDEyMTEsMTIyNywxMjYzLDEzMDYsMTMzMiwxMzY5LDEzODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3LDExOTAsMTE5OCwxMzQ4LDEzNTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc2LDY4NywxMjc1LDEzMThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzAsNDI4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeUlERWdNeklnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelV3TURJd0lEQjRNVFV4Wmpkak56VWdJaUlnSW5BaUlEQjRNRFk0TVRBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBUV0Z1WVdkbGNpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnME9HUTFNMlV6TWlBd2VHSmtZMlpoWXpVNElEQjROR0l4WkdKaU5qY2dNSGhoT1Roa09ESmtZU0F3ZUdZM1pHWTRaR1V5SURCNE5tVTROekkzT0RrZ01IaGxPRFpoWlRsbE9TQXdlRE0wTmpnMU1EVXdJREI0TlRrd05XUTBaalFnTUhoaFlURTBZelJtT1NBd2VEZGxNMlkwWVRZNElEQjRZVGczTURRNU1ETWdNSGd4WlRsak1EQTVNQ0F3ZURoak5HTm1ZMlkzSURCNE5qY3lNR1E0Wm1ZZ01IZ3lOekEwT1RJNE9TQXdlREppWmpZd09XVXdJQzh2SUcxbGRHaHZaQ0FpYjNCbGJpaGhaR1J5WlhOekxHRjRabVZ5TEdKNWRHVmJYU3hpZVhSbFcxMHNZbmwwWlZ0ZEtXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaWRHOXdWWEFvWW5sMFpWdGRMR0Y0Wm1WeUtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhrb1lubDBaVnRkTEdKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWV2IzVmphR1Z5S0dKNWRHVmJYU3gxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRIUnNaU2hpZVhSbFcxMHNkV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSMGJHVk1ZWFJsYzNRb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5zYjNObEtHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhGMVpYTjBRMnh2YzJVb1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNLR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbWRXNWtUV0p5VUc5dmJDZ29ZV1JrY21WemN5a3BkbTlwWkNJc0lHMWxkR2h2WkNBaWIzQjBTVzVWYzJSaktDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUlRaWE56YVc5dVUzUmhkR2xqUkdGMFlTaGllWFJsVzEwcEtIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUlRaWE56YVc5dVJIbHVZVzFwWTBSaGRHRW9ZbmwwWlZ0ZEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1OdmJYQjFkR1ZEYUdGdWJtVnNTV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0o1ZEdWYlhTeGllWFJsVzEwcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKelpYUjBiR1ZOWlhOellXZGxLR0o1ZEdWYlhTeDFhVzUwTmpRcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxUWlhSMGJHVlRhV2R1WVhSMWNtVW9ZbmwwWlZ0ZExIVnBiblEyTkN4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaR1Z5YVhabFEyaGhibTVsYkVsa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWVYUmxXMTBzWW5sMFpWdGRLV0o1ZEdWYlhTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzl3Wlc0Z2RHOXdWWEFnYzJWMFFYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNCMWNHUmhkR1ZXYjNWamFHVnlJSE5sZEhSc1pTQnpaWFIwYkdWTVlYUmxjM1FnWTJ4dmMyVWdjbVZ4ZFdWemRFTnNiM05sSUhkcGRHaGtjbUYzSUdaMWJtUk5ZbkpRYjI5c0lHOXdkRWx1VlhOa1l5Qm5aWFJUWlhOemFXOXVVM1JoZEdsalJHRjBZU0JuWlhSVFpYTnphVzl1UkhsdVlXMXBZMFJoZEdFZ1kyOXRjSFYwWlVOb1lXNXVaV3hKWkNCelpYUjBiR1ZOWlhOellXZGxJSFpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlNCa1pYSnBkbVZEYUdGdWJtVnNTV1FLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1qUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwVFdGdVlXZGxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1dmNHVnVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCbGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRXROamdLSUNBZ0lDOHZJRzl3Wlc0b0NpQWdJQ0F2THlBZ0lIQmhlV1ZsT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCa1pYQnZjMmwwT2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHNDaUFnSUNBdkx5QWdJSE5oYkhRNklHSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5T2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVG9nWW5sMFpYTXNDaUFnSUNBdkx5QUtJQ0FnSUM4dklDazZJR0o1ZEdWeklIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdZWGhtWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoZUdabGNnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCaGMzTmxjblFvWVhWMGFHOXlhWHBsWkZOcFoyNWxjaTVzWlc1bmRHZ2dQVDA5SURNeUxDQW5VMmxuYm1WeUlHaGhjMmdnYlhWemRDQmlaU0F6TWlCaWVYUmxjeWNwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1UybG5ibVZ5SUdoaGMyZ2diWFZ6ZENCaVpTQXpNaUJpZVhSbGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTJoaGJtNWxiRWxrSUQwZ2RHaHBjeTVrWlhKcGRtVkRhR0Z1Ym1Wc1NXUW9WSGh1TG5ObGJtUmxjaXdnY0dGNVpXVXNJR0YxZEdodmNtbDZaV1JUYVdkdVpYSXNJSE5oYkhRcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xTlFvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG5Ob1lUSTFOaWh3WVhsbGNpNWllWFJsY3k1amIyNWpZWFFvY0dGNVpXVXVZbmwwWlhNcExtTnZibU5oZENodmNDNXBkRzlpS0ZWVFJFTmZRVk5UUlZSZlNVUXBLUzVqYjI1allYUW9jMkZzZENrdVkyOXVZMkYwS0dGMWRHaHZjbWw2WldSVGFXZHVaWElwS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR01nTkNBdkx5QlVUVkJNWDFWVFJFTmZRVk5UUlZSZlNVUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUdsbUlDZ2hZMmhoYm01bGJDNWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUc5d1pXNWZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCemRHRnlkRkp2ZFc1a09pQnZjQzVIYkc5aVlXd3VjbTkxYm1Rc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUhOMFlYSjBWR2x0WlhOMFlXMXdPaUJ2Y0M1SGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdjR0Y1WlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMUxUZzFDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhPaUJEYUdGdWJtVnNTVzVtYnlBOUlIc0tJQ0FnSUM4dklDQWdjR0Y1WlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJSEJoZVdWbExBb2dJQ0FnTHk4Z0lDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeUxBb2dJQ0FnTHk4Z0lDQjBiM1JoYkVSbGNHOXphWFE2SURBc0NpQWdJQ0F2THlBZ0lHeGhjM1JUWlhSMGJHVmtPaUF3TEFvZ0lDQWdMeThnSUNCc1lYUmxjM1JXYjNWamFHVnlRVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0J6ZEdGeWRGSnZkVzVrT2lCdmNDNUhiRzlpWVd3dWNtOTFibVFzQ2lBZ0lDQXZMeUFnSUhOMFlYSjBWR2x0WlhOMFlXMXdPaUJ2Y0M1SGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0JqYkc5elpWSmxjWFZsYzNSbFpFRjBPaUF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdaR2xuSURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TnpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Rb2dJQ0FnTHk4Z2RHOTBZV3hFWlhCdmMybDBPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelV0T0RVS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFNklFTm9ZVzV1Wld4SmJtWnZJRDBnZXdvZ0lDQWdMeThnSUNCd1lYbGxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ2NHRjVaV1VzQ2lBZ0lDQXZMeUFnSUdGMWRHaHZjbWw2WldSVGFXZHVaWElzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNSR1Z3YjNOcGREb2dNQ3dLSUNBZ0lDOHZJQ0FnYkdGemRGTmxkSFJzWldRNklEQXNDaUFnSUNBdkx5QWdJR3hoZEdWemRGWnZkV05vWlhKQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lITjBZWEowVW05MWJtUTZJRzl3TGtkc2IySmhiQzV5YjNWdVpDd0tJQ0FnSUM4dklDQWdjM1JoY25SVWFXMWxjM1JoYlhBNklHOXdMa2RzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WeGRXVnpkR1ZrUVhRNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QjBhR2x6TG5ObGRFRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhsSlpsQnliM1pwWkdWa0tHTm9ZVzV1Wld4SlpDd2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTd2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNpa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlITmxkRUYxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYbEpabEJ5YjNacFpHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QjBhR2x6TG1Gd2NHeDVWRzl3VlhBb1pHRjBZU3dnWkdWd2IzTnBkQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJoY0hCc2VWUnZjRlZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJqYUdGdWJtVnNMblpoYkhWbElEMGdZMnh2Ym1Vb1pHRjBZU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtDbTl3Wlc1ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMbTl3Wlc1QU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qRXROamdLSUNBZ0lDOHZJRzl3Wlc0b0NpQWdJQ0F2THlBZ0lIQmhlV1ZsT2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCa1pYQnZjMmwwT2lCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWVHNHNDaUFnSUNBdkx5QWdJSE5oYkhRNklHSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5T2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVG9nWW5sMFpYTXNDaUFnSUNBdkx5QUtJQ0FnSUM4dklDazZJR0o1ZEdWeklIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05UQXdNakFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2IzQmxibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsYjNCbGJpQmphR0Z1Ym1Wc0p5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJdE9UTUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQnlaVzl3Wlc0Z1kyaGhibTVsYkNjcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCa1lYUmhMbkJoZVdWeUxDQW5UMjVzZVNCd1lYbGxjaUJqWVc0Z2NtVnZjR1Z1SUdOb1lXNXVaV3duS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhCaGVXVnlJR05oYmlCeVpXOXdaVzRnWTJoaGJtNWxiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOQW9nSUNBZ0x5OGdZWE56WlhKMEtIQmhlV1ZsSUQwOVBTQmtZWFJoTG5CaGVXVmxMQ0FuVUdGNVpXVWdiV2x6YldGMFkyZ25LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWkdsbklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNVpXVWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoaGRYUm9iM0pwZW1Wa1UybG5ibVZ5SUQwOVBTQmtZWFJoTG1GMWRHaHZjbWw2WldSVGFXZHVaWElzSUNkQmRYUm9iM0pwZW1Wa0lITnBaMjVsY2lCb1lYTm9JRzFwYzIxaGRHTm9KeWtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMk5DQXZMeUEyTkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURjS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUYxZEdodmNtbDZaV1FnYzJsbmJtVnlJR2hoYzJnZ2JXbHpiV0YwWTJnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUhSb2FYTXVjMlYwUVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVWxtVUhKdmRtbGtaV1FvWTJoaGJtNWxiRWxrTENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1TENCa1lYUmhMbUYxZEdodmNtbDZaV1JUYVdkdVpYSXBDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklIUm9hWE11WVhCd2JIbFViM0JWY0Noa1lYUmhMQ0JrWlhCdmMybDBLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJR0Z3Y0d4NVZHOXdWWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJR05vWVc1dVpXd3VkbUZzZFdVZ1BTQmpiRzl1WlNoa1lYUmhLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1TMDJPQW9nSUNBZ0x5OGdiM0JsYmlnS0lDQWdJQzh2SUNBZ2NHRjVaV1U2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdSbGNHOXphWFE2SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSNGJpd0tJQ0FnSUM4dklDQWdjMkZzZERvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFnSUdGMWRHaHZjbWw2WldSVGFXZHVaWEk2SUdKNWRHVnpMQW9nSUNBZ0x5OGdJQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVPaUJpZVhSbGN5d0tJQ0FnSUM4dklBb2dJQ0FnTHk4Z0tUb2dZbmwwWlhNZ2V3b2dJQ0FnWWlCdmNHVnVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1dmNHVnVRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxuUnZjRlZ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOXdWWEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TndvZ0lDQWdMeThnZEc5d1ZYQW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWREb2daM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaGphR0Z1Ym1Wc0xtVjRhWE4wY3l3Z0owTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFTm9ZVzV1Wld3Z1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJqYjI1emRDQmtZWFJoSUQwZ1kyeHZibVVvWTJoaGJtNWxiQzUyWVd4MVpTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV5Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlIUnZjQ0IxY0NjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TVMweE1USUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjBiM0FnZFhBbktRb2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TWdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHUmhkR0V1Y0dGNVpYSXNJQ2RQYm14NUlIQmhlV1Z5SUdOaGJpQjBiM0FnZFhBbktRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIQmhlV1Z5SUdOaGJpQjBiM0FnZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCMGFHbHpMbUZ3Y0d4NVZHOXdWWEFvWkdGMFlTd2dZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDa0tJQ0FnSUdOaGJHeHpkV0lnWVhCd2JIbFViM0JWY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUdOb1lXNXVaV3d1ZG1Gc2RXVWdQU0JqYkc5dVpTaGtZWFJoS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSFJ2Y0ZWd0tHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklHZDBlRzR1UVhOelpYUlVjbUZ1YzJabGNsUjRiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFMWhibUZuWlhJdWMyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEVGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TVFvZ0lDQWdMeThnYzJWMFFYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1T2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdZWE56WlhKMEtHTm9ZVzV1Wld3dVpYaHBjM1J6TENBblEyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJR052Ym5OMElHUmhkR0VnUFNCamJHOXVaU2hqYUdGdWJtVnNMblpoYkhWbEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpZS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdjMlYwSUdGMWRHaHZjbWw2WldRZ2MybG5ibVZ5SnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkxTFRFeU5nb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlITmxkQ0JoZFhSb2IzSnBlbVZrSUhOcFoyNWxjaWNwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTJDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnWkdGMFlTNXdZWGxsY2l3Z0owOXViSGtnY0dGNVpYSWdZMkZ1SUhObGRDQmhkWFJvYjNKcGVtVmtJSE5wWjI1bGNpY3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djR0Y1WlhJZ1kyRnVJSE5sZENCaGRYUm9iM0pwZW1Wa0lITnBaMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpjS0lDQWdJQzh2SUdGemMyVnlkQ2hoZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVMbXhsYm1kMGFDQStJREFzSUNkQmRYUm9iM0pwZW1Wa0lITnBaMjVsY2lCd2RXSnJaWGtnY21WeGRXbHlaV1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJkWFJvYjNKcGVtVmtJSE5wWjI1bGNpQndkV0pyWlhrZ2NtVnhkV2x5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJNUNpQWdJQ0F2THlCamIyNXpkQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlTR0Z6YUNBOUlITm9ZVFV4TWw4eU5UWW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTa0tJQ0FnSUdSMWNBb2dJQ0FnYzJoaE5URXlYekkxTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpBS0lDQWdJQzh2SUhSb2FYTXVjMlYwUVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlVWxtVUhKdmRtbGtaV1FvWTJoaGJtNWxiRWxrTENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1TENCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5U0dGemFDa0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJSE5sZEVGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGxKWmxCeWIzWnBaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TWdvZ0lDQWdMeThnWkdGMFlTNWhkWFJvYjNKcGVtVmtVMmxuYm1WeUlEMGdZWFYwYUc5eWFYcGxaRk5wWjI1bGNraGhjMmdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXpDaUFnSUNBdkx5QmphR0Z1Ym1Wc0xuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeENpQWdJQ0F2THlCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHRjFkR2h2Y21sNlpXUlRhV2R1WlhKUWRXSnNhV05MWlhrNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBUV0Z1WVdkbGNpNTFjR1JoZEdWV2IzVmphR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsVm05MVkyaGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE01Q2lBZ0lDQXZMeUIxY0dSaGRHVldiM1ZqYUdWeUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklIVnBiblEyTkN3Z2MybG5ibUYwZFhKbE9pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5QmhjM05sY25Rb1kyaGhibTVsYkM1bGVHbHpkSE1zSUNkRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHRnVibVZzSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCMWNHUmhkR1VnZG05MVkyaGxjaWNwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCd1lYbGxjaUJqWVc0Z2RYQmtZWFJsSUhadmRXTm9aWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDQStQU0JrWVhSaExteGhjM1JUWlhSMGJHVmtMQ0FuVm05MVkyaGxjaUJpWld4dmR5QnpaWFIwYkdWa0lHRnRiM1Z1ZENjcENpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkSE1nTnpRZ09DQXZMeUEzTkN3Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRlp2ZFdOb1pYSWdZbVZzYjNjZ2MyVjBkR3hsWkNCaGJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEzQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDQStJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRDd2dKMVp2ZFdOb1pYSWdibTkwSUdsdVkzSmxZWE5wYm1jbktRb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblJ6SURneUlEZ2dMeThnT0RJc0lEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJRlp2ZFdOb1pYSWdibTkwSUdsdVkzSmxZWE5wYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNENpQWdJQ0F2THlCaGMzTmxjblFvWTNWdGRXeGhkR2wyWlVGdGIzVnVkQ0E4UFNCa1lYUmhMblJ2ZEdGc1JHVndiM05wZEN3Z0oxWnZkV05vWlhJZ1pYaGpaV1ZrY3lCa1pYQnZjMmwwSnlrS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBjeUEyTmlBNElDOHZJRFkyTENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbTkxWTJobGNpQmxlR05sWldSeklHUmxjRzl6YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVd0NpQWdJQ0F2THlCMGFHbHpMblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlNoamFHRnVibVZzU1dRc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5Rc0lITnBaMjVoZEhWeVpTa0tJQ0FnSUdScFp5QXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFMWhibUZuWlhJdWRtVnlhV1o1VTJWMGRHeGxVMmxuYm1GMGRYSmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNaTB4TlRNS0lDQWdJQzh2SUdSaGRHRXViR0YwWlhOMFZtOTFZMmhsY2tGdGIzVnVkQ0E5SUdOMWJYVnNZWFJwZG1WQmJXOTFiblFLSUNBZ0lDOHZJR05vWVc1dVpXd3VkbUZzZFdVZ1BTQmpiRzl1WlNoa1lYUmhLUW9nSUNBZ2NIVnphR2x1ZENBNE1pQXZMeUE0TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE01Q2lBZ0lDQXZMeUIxY0dSaGRHVldiM1ZqYUdWeUtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklIVnBiblEyTkN3Z2MybG5ibUYwZFhKbE9pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRTFoYm1GblpYSXVjMlYwZEd4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwZEd4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklITmxkSFJzWlNoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCamRXMTFiR0YwYVhabFFXMXZkVzUwT2lCMWFXNTBOalFzSUhOcFoyNWhkSFZ5WlRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENoamFHRnVibVZzTG1WNGFYTjBjeXdnSjBOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUW5LUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTBDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbFpTd2dKMDl1YkhrZ2NHRjVaV1VnWTJGdUlITmxkSFJzWlNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJoZVdWbElHTmhiaUJ6WlhSMGJHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTNDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZENBK0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lDZE9iM1JvYVc1bklHNWxkeUIwYnlCelpYUjBiR1VuS1FvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJocGJuUnpJRGMwSURnZ0x5OGdOelFzSURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURFS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1JvYVc1bklHNWxkeUIwYnlCelpYUjBiR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDQThQU0JrWVhSaExuUnZkR0ZzUkdWd2IzTnBkQ3dnSjFadmRXTm9aWElnWlhoalpXVmtjeUJrWlhCdmMybDBKeWtLSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vYVc1MGN5QTJOaUE0SUM4dklEWTJMQ0E0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pHbG5JRFFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZtOTFZMmhsY2lCbGVHTmxaV1J6SUdSbGNHOXphWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN3Q2lBZ0lDQXZMeUIwYUdsekxuWmxjbWxtZVZObGRIUnNaVk5wWjI1aGRIVnlaU2hqYUdGdWJtVnNTV1FzSUdOMWJYVnNZWFJwZG1WQmJXOTFiblFzSUhOcFoyNWhkSFZ5WlNrS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpJS0lDQWdJQzh2SUdOdmJuTjBJSEJoZVc5MWREb2dkV2x1ZERZMElEMGdZM1Z0ZFd4aGRHbDJaVUZ0YjNWdWRDQXRJR1JoZEdFdWJHRnpkRk5sZEhSc1pXUUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM05DMHhOemdLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHUmhkR0V1Y0dGNVpXVXNDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCd1lYbHZkWFFzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOelVLSUNBZ0lDOHZJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTkMweE56Z0tJQ0FnSUM4dklHbDBlRzR1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdSaGRHRXVjR0Y1WldVc0NpQWdJQ0F2THlBZ0lHRnpjMlYwUVcxdmRXNTBPaUJ3WVhsdmRYUXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnd0NpQWdJQ0F2THlCa1lYUmhMbXhoYzNSVFpYUjBiR1ZrSUQwZ1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY21Wd2JHRmpaVElnTnpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ERUtJQ0FnSUM4dklHbG1JQ2hqZFcxMWJHRjBhWFpsUVcxdmRXNTBJRDRnWkdGMFlTNXNZWFJsYzNSV2IzVmphR1Z5UVcxdmRXNTBLU0I3Q2lBZ0lDQndkWE5vYVc1MElEZ3lJQzh2SURneUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUGdvZ0lDQWdZbm9nYzJWMGRHeGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ESUtJQ0FnSUM4dklHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZENBOUlHTjFiWFZzWVhScGRtVkJiVzkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0J5WlhCc1lXTmxNaUE0TWdvS2MyVjBkR3hsWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcwQ2lBZ0lDQXZMeUJqYUdGdWJtVnNMblpoYkhWbElEMGdZMnh2Ym1Vb1pHRjBZU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklITmxkSFJzWlNoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCamRXMTFiR0YwYVhabFFXMXZkVzUwT2lCMWFXNTBOalFzSUhOcFoyNWhkSFZ5WlRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxuTmxkSFJzWlV4aGRHVnpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRIUnNaVXhoZEdWemREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QnpaWFIwYkdWTVlYUmxjM1FvWTJoaGJtNWxiRWxrT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreUNpQWdJQ0F2THlCaGMzTmxjblFvWTJoaGJtNWxiQzVsZUdsemRITXNJQ2REYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMmhoYm01bGJDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RZS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVmxMQ0FuVDI1c2VTQndZWGxsWlNCallXNGdjMlYwZEd4bEp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY0dGNVpXVWdZMkZ1SUhObGRIUnNaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaGtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RZ1BpQmtZWFJoTG14aGMzUlRaWFIwYkdWa0xDQW5UbTkwYUdsdVp5QnVaWGNnZEc4Z2MyVjBkR3hsSnlrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBjeUE0TWlBNElDOHZJRGd5TENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRITWdOelFnT0NBdkx5QTNOQ3dnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjRElLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUm9hVzVuSUc1bGR5QjBieUJ6WlhSMGJHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazVDaUFnSUNBdkx5QmpiMjV6ZENCd1lYbHZkWFE2SUhWcGJuUTJOQ0E5SUdSaGRHRXViR0YwWlhOMFZtOTFZMmhsY2tGdGIzVnVkQ0F0SUdSaGRHRXViR0Z6ZEZObGRIUnNaV1FLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXhMVEl3TlFvZ0lDQWdMeThnYVhSNGJpNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ2VHWmxja0Z6YzJWME9pQkJjM05sZENoVlUwUkRYMEZUVTBWVVgwbEVLU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2daR0YwWVM1d1lYbGxaU3dLSUNBZ0lDOHZJQ0FnWVhOelpYUkJiVzkxYm5RNklIQmhlVzkxZEN3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TWdvZ0lDQWdMeThnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2hWVTBSRFgwRlRVMFZVWDBsRUtTd0tJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZUUkVOZlFWTlRSVlJmU1VRS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNREV0TWpBMUNpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJrWVhSaExuQmhlV1ZsTEFvZ0lDQWdMeThnSUNCaGMzTmxkRUZ0YjNWdWREb2djR0Y1YjNWMExBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TnkweU1EZ0tJQ0FnSUM4dklHUmhkR0V1YkdGemRGTmxkSFJzWldRZ1BTQmtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5RS0lDQWdJQzh2SUdOb1lXNXVaV3d1ZG1Gc2RXVWdQU0JqYkc5dVpTaGtZWFJoS1FvZ0lDQWdjSFZ6YUdsdWRDQTNOQ0F2THlBM05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrd0NpQWdJQ0F2THlCelpYUjBiR1ZNWVhSbGMzUW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1WTJ4dmMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYkc5elpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTFDaUFnSUNBdkx5QmpiRzl6WlNoamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENoamFHRnVibVZzTG1WNGFYTjBjeXdnSjBOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpFS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVmxMQ0FuVDI1c2VTQndZWGxsWlNCallXNGdZMnh2YzJVbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSEJoZVdWbElHTmhiaUJqYkc5elpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qTUtJQ0FnSUM4dklIUm9hWE11Wm1sdVlXeHBlbVZEYUdGdWJtVnNLR05vWVc1dVpXeEpaQ3dnWkdGMFlTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWm1sdVlXeHBlbVZEYUdGdWJtVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTFDaUFnSUNBdkx5QmpiRzl6WlNoamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBUV0Z1WVdkbGNpNXlaWEYxWlhOMFEyeHZjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYRjFaWE4wUTJ4dmMyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlPUW9nSUNBZ0x5OGdjbVZ4ZFdWemRFTnNiM05sS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNMENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdaR0YwWVM1d1lYbGxjaXdnSjA5dWJIa2djR0Y1WlhJZ1kyRnVJSEpsY1hWbGMzUWdZMnh2YzJVbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXpNdE1qTTBDaUFnSUNBdkx5QmpiMjV6ZENCa1lYUmhJRDBnWTJ4dmJtVW9ZMmhoYm01bGJDNTJZV3gxWlNrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdjbVZ4ZFdWemRDQmpiRzl6WlNjcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0wQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pHRjBZUzV3WVhsbGNpd2dKMDl1YkhrZ2NHRjVaWElnWTJGdUlISmxjWFZsYzNRZ1kyeHZjMlVuS1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhCaGVXVnlJR05oYmlCeVpYRjFaWE4wSUdOc2IzTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpOZ29nSUNBZ0x5OGdaR0YwWVM1amJHOXpaVkpsY1hWbGMzUmxaRUYwSUQwZ2IzQXVSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TXpZdE1qTTNDaUFnSUNBdkx5QmtZWFJoTG1Oc2IzTmxVbVZ4ZFdWemRHVmtRWFFnUFNCdmNDNUhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQXZMeUJqYUdGdWJtVnNMblpoYkhWbElEMGdZMnh2Ym1Vb1pHRjBZU2tLSUNBZ0lIQjFjMmhwYm5RZ01UQTJJQzh2SURFd05nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJNUNpQWdJQ0F2THlCeVpYRjFaWE4wUTJ4dmMyVW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1ZDJsMGFHUnlZWGRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwM2FYUm9aSEpoZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRMENpQWdJQ0F2THlCM2FYUm9aSEpoZHloamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EWUtJQ0FnSUM4dklHRnpjMlZ5ZENoamFHRnVibVZzTG1WNGFYTjBjeXdnSjBOb1lXNXVaV3dnWkc5bGN5QnViM1FnWlhocGMzUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdWJtVnNJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME9Bb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmtZWFJoTG5CaGVXVnlMQ0FuVDI1c2VTQndZWGxsY2lCallXNGdkMmwwYUdSeVlYY25LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EZ3RNalE1Q2lBZ0lDQXZMeUJqYjI1emRDQmtZWFJoSUQwZ1kyeHZibVVvWTJoaGJtNWxiQzUyWVd4MVpTa0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JrWVhSaExuQmhlV1Z5TENBblQyNXNlU0J3WVhsbGNpQmpZVzRnZDJsMGFHUnlZWGNuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBPUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdSaGRHRXVjR0Y1WlhJc0lDZFBibXg1SUhCaGVXVnlJR05oYmlCM2FYUm9aSEpoZHljcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2NHRjVaWElnWTJGdUlIZHBkR2hrY21GM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dSaGRHRXVZMnh2YzJWU1pYRjFaWE4wWldSQmRDQStJREFzSUNkRGJHOXpaU0J1YjNRZ2NtVnhkV1Z6ZEdWa0p5a0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkSE1nTVRBMklEZ2dMeThnTVRBMkxDQTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnUTJ4dmMyVWdibTkwSUhKbGNYVmxjM1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRJS0lDQWdJQzh2SUc5d0xrZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFnUGowZ1pHRjBZUzVqYkc5elpWSmxjWFZsYzNSbFpFRjBJQ3NnUTB4UFUwVmZSMUpCUTBWZlVFVlNTVTlFWDFORlEwOU9SRk1zQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEZzRPQ0F2THlBNE9EZ0tJQ0FnSUNzS0lDQWdJRDQ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTVMweU5UUUtJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ2IzQXVSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NBK1BTQmtZWFJoTG1Oc2IzTmxVbVZ4ZFdWemRHVmtRWFFnS3lCRFRFOVRSVjlIVWtGRFJWOVFSVkpKVDBSZlUwVkRUMDVFVXl3S0lDQWdJQzh2SUNBZ0owTnNiM05sSUdkeVlXTmxJSEJsY21sdlpDQnViM1FnWld4aGNITmxaQ2NzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRMnh2YzJVZ1ozSmhZMlVnY0dWeWFXOWtJRzV2ZENCbGJHRndjMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTmdvZ0lDQWdMeThnZEdocGN5NW1hVzVoYkdsNlpVTm9ZVzV1Wld3b1kyaGhibTVsYkVsa0xDQmtZWFJoS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQm1hVzVoYkdsNlpVTm9ZVzV1Wld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRRS0lDQWdJQzh2SUhkcGRHaGtjbUYzS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxtWjFibVJOWW5KUWIyOXNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm5WdVpFMWljbEJ2YjJ3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMk1nb2dJQ0FnTHk4Z1puVnVaRTFpY2xCdmIyd29jR0Y1YldWdWREb2dleUJ5WldObGFYWmxjam9nUVdOamIzVnVkQ0I5S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCUFltcGxZM1JCUVVOR09EVXhNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDaHdZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlQU0J2Y0M1SGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnSjFCaGVXMWxiblFnYlhWemRDQmlaU0IwYnlCamIyNTBjbUZqZENjcENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJqYjI1MGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOaklLSUNBZ0lDOHZJR1oxYm1STlluSlFiMjlzS0hCaGVXMWxiblE2SUhzZ2NtVmpaV2wyWlhJNklFRmpZMjkxYm5RZ2ZTazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1YjNCMFNXNVZjMlJqVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzQjBTVzVWYzJSak9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56RUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0J2Y0M1SGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNJQ2RQYm14NUlHTnlaV0YwYjNJZ1kyRnVJRzl3ZENCcGJpQlZVMFJESnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUc5d2RDQnBiaUJWVTBSRENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM015MHlOemNLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNBdkx5QWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTkFvZ0lDQWdMeThnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2hWVTBSRFgwRlRVMFZVWDBsRUtTd0tJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZUUkVOZlFWTlRSVlJmU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjMUNpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJ2Y0M1SGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTmdvZ0lDQWdMeThnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56TXRNamMzQ2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCNFptVnlRWE56WlhRNklFRnpjMlYwS0ZWVFJFTmZRVk5UUlZSZlNVUXBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQnZjQzVIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamN3Q2lBZ0lDQXZMeUJ2Y0hSSmJsVnpaR01vS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M1UyVnpjMmx2YmxaaGRXeDBUV0Z1WVdkbGNpNW5aWFJUWlhOemFXOXVVM1JoZEdsalJHRjBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGTmxjM05wYjI1VGRHRjBhV05FWVhSaE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EUUtJQ0FnSUM4dklHZGxkRk5sYzNOcGIyNVRkR0YwYVdORVlYUmhLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXBPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUmRJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE5nb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnNExUSTRPUW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLR05vWVc1dVpXd3VkbUZzZFdVcENpQWdJQ0F2THlCeVpYUjFjbTRnVzJSaGRHRXVjM1JoY25SU2IzVnVaQ3dnWkdGMFlTNXpkR0Z5ZEZScGJXVnpkR0Z0Y0YwS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRITWdPVEFnT0NBdkx5QTVNQ3dnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamc1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMlJoZEdFdWMzUmhjblJTYjNWdVpDd2daR0YwWVM1emRHRnlkRlJwYldWemRHRnRjRjBLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamc0TFRJNE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWkdGMFlTQTlJR05zYjI1bEtHTm9ZVzV1Wld3dWRtRnNkV1VwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMlJoZEdFdWMzUmhjblJTYjNWdVpDd2daR0YwWVM1emRHRnlkRlJwYldWemRHRnRjRjBLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5SeklEazRJRGdnTHk4Z09UZ3NJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGdGtZWFJoTG5OMFlYSjBVbTkxYm1Rc0lHUmhkR0V1YzNSaGNuUlVhVzFsYzNSaGJYQmRDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamcwQ2lBZ0lDQXZMeUJuWlhSVFpYTnphVzl1VTNSaGRHbGpSR0YwWVNoamFHRnVibVZzU1dRNklHSjVkR1Z6S1RvZ1czVnBiblEyTkN3Z2RXbHVkRFkwWFNCN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwVFdGdVlXZGxjaTVuWlhSVFpYTnphVzl1UkhsdVlXMXBZMFJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJUWlhOemFXOXVSSGx1WVcxcFkwUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1TmdvZ0lDQWdMeThnWjJWMFUyVnpjMmx2YmtSNWJtRnRhV05FWVhSaEtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNcE9pQmJkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkYwZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNams0Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZMmhoYm01bGJDNWxlR2x6ZEhNc0lDZERhR0Z1Ym1Wc0lHUnZaWE1nYm05MElHVjRhWE4wSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGhibTVsYkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNREF0TXpBeENpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lDOHZJSEpsZEhWeWJpQmJaR0YwWVM1MGIzUmhiRVJsY0c5emFYUXNJR1JoZEdFdWJHRnpkRk5sZEhSc1pXUXNJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRGMEtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkSE1nTmpZZ09DQXZMeUEyTml3Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBeENpQWdJQ0F2THlCeVpYUjFjbTRnVzJSaGRHRXVkRzkwWVd4RVpYQnZjMmwwTENCa1lYUmhMbXhoYzNSVFpYUjBiR1ZrTENCa1lYUmhMbXhoZEdWemRGWnZkV05vWlhKQmJXOTFiblJkQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13TUMwek1ERUtJQ0FnSUM4dklHTnZibk4wSUdSaGRHRWdQU0JqYkc5dVpTaGphR0Z1Ym1Wc0xuWmhiSFZsS1FvZ0lDQWdMeThnY21WMGRYSnVJRnRrWVhSaExuUnZkR0ZzUkdWd2IzTnBkQ3dnWkdGMFlTNXNZWE4wVTJWMGRHeGxaQ3dnWkdGMFlTNXNZWFJsYzNSV2IzVmphR1Z5UVcxdmRXNTBYUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5SeklEYzBJRGdnTHk4Z056UXNJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdNUW9nSUNBZ0x5OGdjbVYwZFhKdUlGdGtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDd2daR0YwWVM1c1lYTjBVMlYwZEd4bFpDd2daR0YwWVM1c1lYUmxjM1JXYjNWamFHVnlRVzF2ZFc1MFhRb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1EQXRNekF4Q2lBZ0lDQXZMeUJqYjI1emRDQmtZWFJoSUQwZ1kyeHZibVVvWTJoaGJtNWxiQzUyWVd4MVpTa0tJQ0FnSUM4dklISmxkSFZ5YmlCYlpHRjBZUzUwYjNSaGJFUmxjRzl6YVhRc0lHUmhkR0V1YkdGemRGTmxkSFJzWldRc0lHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZEYwS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZEhNZ09ESWdPQ0F2THlBNE1pd2dPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QXhDaUFnSUNBdkx5QnlaWFIxY200Z1cyUmhkR0V1ZEc5MFlXeEVaWEJ2YzJsMExDQmtZWFJoTG14aGMzUlRaWFIwYkdWa0xDQmtZWFJoTG14aGRHVnpkRlp2ZFdOb1pYSkJiVzkxYm5SZENpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamsyQ2lBZ0lDQXZMeUJuWlhSVFpYTnphVzl1UkhsdVlXMXBZMFJoZEdFb1kyaGhibTVsYkVsa09pQmllWFJsY3lrNklGdDFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwWFNCN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwVFdGdVlXZGxjaTVqYjIxd2RYUmxRMmhoYm01bGJFbGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5dGNIVjBaVU5vWVc1dVpXeEpaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekE0Q2lBZ0lDQXZMeUJqYjIxd2RYUmxRMmhoYm01bGJFbGtLSEJoZVdWeU9pQkJZMk52ZFc1MExDQndZWGxsWlRvZ1FXTmpiM1Z1ZEN3Z1lYVjBhRzl5YVhwbFpGTnBaMjVsY2pvZ1lubDBaWE1zSUhOaGJIUTZJR0o1ZEdWektUb2dZbmwwWlhNZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlRVS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1emFHRXlOVFlvY0dGNVpYSXVZbmwwWlhNdVkyOXVZMkYwS0hCaGVXVmxMbUo1ZEdWektTNWpiMjVqWVhRb2IzQXVhWFJ2WWloVlUwUkRYMEZUVTBWVVgwbEVLU2t1WTI5dVkyRjBLSE5oYkhRcExtTnZibU5oZENoaGRYUm9iM0pwZW1Wa1UybG5ibVZ5S1NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZUUkVOZlFWTlRSVlJmU1VRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TURnS0lDQWdJQzh2SUdOdmJYQjFkR1ZEYUdGdWJtVnNTV1FvY0dGNVpYSTZJRUZqWTI5MWJuUXNJSEJoZVdWbE9pQkJZMk52ZFc1MExDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeU9pQmllWFJsY3l3Z2MyRnNkRG9nWW5sMFpYTXBPaUJpZVhSbGN5QjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VXdNREl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRTFoYm1GblpYSXVjMlYwZEd4bFRXVnpjMkZuWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkSFJzWlUxbGMzTmhaMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TlFvZ0lDQWdMeThnYzJWMGRHeGxUV1Z6YzJGblpTaGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWekxDQmpkVzExYkdGMGFYWmxRVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQmllWFJsY3lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0NBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1UWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbWRsZEZObGRIUnNaVTFsYzNOaFoyVW9ZMmhoYm01bGJFbGtMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUlRaWFIwYkdWTlpYTnpZV2RsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TlFvZ0lDQWdMeThnYzJWMGRHeGxUV1Z6YzJGblpTaGphR0Z1Ym1Wc1NXUTZJR0o1ZEdWekxDQmpkVzExYkdGMGFYWmxRVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQmllWFJsY3lCN0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRTFoYm1GblpYSXVkbVZ5YVdaNVUyVjBkR3hsVTJsbmJtRjBkWEpsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtVnlhV1o1VTJWMGRHeGxVMmxuYm1GMGRYSmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNak1LSUNBZ0lDOHZJSFpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlNoamFHRnVibVZzU1dRNklHSjVkR1Z6TENCamRXMTFiR0YwYVhabFFXMXZkVzUwT2lCMWFXNTBOalFzSUhOcFoyNWhkSFZ5WlRvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa1Z6WTNKdmQxTmxjM05wYjI1V1lYVnNkRTFoYm1GblpYSXVaR1Z5YVhabFEyaGhibTVsYkVsa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1Z5YVhabFEyaGhibTVsYkVsa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5USUtJQ0FnSUM4dklHUmxjbWwyWlVOb1lXNXVaV3hKWkNod1lYbGxjam9nUVdOamIzVnVkQ3dnY0dGNVpXVTZJRUZqWTI5MWJuUXNJR0YxZEdodmNtbDZaV1JUYVdkdVpYSTZJR0o1ZEdWekxDQnpZV3gwT2lCaWVYUmxjeWs2SUdKNWRHVnpJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VTFDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVjMmhoTWpVMktIQmhlV1Z5TG1KNWRHVnpMbU52Ym1OaGRDaHdZWGxsWlM1aWVYUmxjeWt1WTI5dVkyRjBLRzl3TG1sMGIySW9WVk5FUTE5QlUxTkZWRjlKUkNrcExtTnZibU5oZENoellXeDBLUzVqYjI1allYUW9ZWFYwYUc5eWFYcGxaRk5wWjI1bGNpa3BDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5VlUwUkRYMEZUVTBWVVgwbEVDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VXlDaUFnSUNBdkx5QmtaWEpwZG1WRGFHRnVibVZzU1dRb2NHRjVaWEk2SUVGalkyOTFiblFzSUhCaGVXVmxPaUJCWTJOdmRXNTBMQ0JoZFhSb2IzSnBlbVZrVTJsbmJtVnlPaUJpZVhSbGN5d2djMkZzZERvZ1lubDBaWE1wT2lCaWVYUmxjeUI3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelV3TURJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkMU5sYzNOcGIyNVdZWFZzZEUxaGJtRm5aWEl1ZG1WeWFXWjVVMlYwZEd4bFUybG5ibUYwZFhKbEtHTm9ZVzV1Wld4SlpEb2dZbmwwWlhNc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RNklIVnBiblEyTkN3Z2MybG5ibUYwZFhKbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1MlpYSnBabmxUWlhSMGJHVlRhV2R1WVhSMWNtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlNd29nSUNBZ0x5OGdkbVZ5YVdaNVUyVjBkR3hsVTJsbmJtRjBkWEpsS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUdOMWJYVnNZWFJwZG1WQmJXOTFiblE2SUhWcGJuUTJOQ3dnYzJsbmJtRjBkWEpsT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeU5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dOb1lXNXVaV3d1WlhocGMzUnpMQ0FuUTJoaGJtNWxiQ0JrYjJWeklHNXZkQ0JsZUdsemRDY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWVc1dVpXd2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJM0NpQWdJQ0F2THlCamIyNXpkQ0JrWVhSaElEMGdZMnh2Ym1Vb1kyaGhibTVsYkM1MllXeDFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15T0FvZ0lDQWdMeThnWTI5dWMzUWdiV1Z6YzJGblpTQTlJSFJvYVhNdVoyVjBVMlYwZEd4bFRXVnpjMkZuWlNoamFHRnVibVZzU1dRc0lHTjFiWFZzWVhScGRtVkJiVzkxYm5RcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJUWlhSMGJHVk5aWE56WVdkbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCaGRYUm9iM0pwZW1Wa1UybG5ibVZ5VUhWaWJHbGpTMlY1SUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JpZVhSbGN6NG9leUJyWlhsUWNtVm1hWGc2SUNkd0p5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16TVFvZ0lDQWdMeThnWVhOelpYSjBLR0YxZEdodmNtbDZaV1JUYVdkdVpYSlFkV0pzYVdOTFpYa3VaWGhwYzNSekxDQW5RWFYwYUc5eWFYcGxaQ0J6YVdkdVpYSWdjSFZpYkdsaklHdGxlU0J1YjNRZ2MyVjBJSGxsZENjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFRjFkR2h2Y21sNlpXUWdjMmxuYm1WeUlIQjFZbXhwWXlCclpYa2dibTkwSUhObGRDQjVaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek16Q2lBZ0lDQXZMeUJqYjI1emRDQmhkWFJvYjNKcGVtVmtVMmxuYm1WeUlEMGdZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVTNTJZV3gxWlFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNkVFpYTnphVzl1Vm1GMWJIUk5ZVzVoWjJWeUxuWmxjbWxtZVZObGRIUnNaVk5wWjI1aGRIVnlaVjkzYUdsc1pWOTBiM0JBTkRvS0lDQWdJSEIxYzJocGJuUWdOVEF4TUNBdkx5QTFNREV3Q2lBZ0lDQm5iRzlpWVd3Z1QzQmpiMlJsUW5Wa1oyVjBDaUFnSUNBK0NpQWdJQ0JpZWlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSTllXNWhaMlZ5TG5abGNtbG1lVk5sZEhSc1pWTnBaMjVoZEhWeVpWOWhablJsY2w5M2FHbHNaVUE1Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREEyT0RFd01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnliM1poYkZCeWIyZHlZVzBLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TmpneE1ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeGxZWEpUZEdGMFpWQnliMmR5WVcwS0lDQWdJR2RzYjJKaGJDQk5hVzVVZUc1R1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWWlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSTllXNWhaMlZ5TG5abGNtbG1lVk5sZEhSc1pWTnBaMjVoZEhWeVpWOTNhR2xzWlY5MGIzQkFOQW9LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwVFdGdVlXZGxjaTUyWlhKcFpubFRaWFIwYkdWVGFXZHVZWFIxY21WZllXWjBaWEpmZDJocGJHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek0yQ2lBZ0lDQXZMeUJoYzNObGNuUW9jMmhoTlRFeVh6STFOaWhoZFhSb2IzSnBlbVZrVTJsbmJtVnlLU0E5UFQwZ1pHRjBZUzVoZFhSb2IzSnBlbVZrVTJsbmJtVnlMQ0FuU1c1MllXeHBaQ0J6YVdkdVpYSWdjSFZpYTJWNUp5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0J6YUdFMU1USmZNalUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZMElDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0J6YVdkdVpYSWdjSFZpYTJWNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNek9Bb2dJQ0FnTHk4Z2FXWWdLSE5wWjI1aGRIVnlaUzVzWlc1bmRHZ2dQaUEyTkNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQndkWE5vYVc1MElEWTBJQzh2SURZMENpQWdJQ0ErQ2lBZ0lDQmllaUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzZFRaWE56YVc5dVZtRjFiSFJOWVc1aFoyVnlMblpsY21sbWVWTmxkSFJzWlZOcFoyNWhkSFZ5WlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelF3Q2lBZ0lDQXZMeUJ5WlhSMWNtNEtJQ0FnSUhKbGRITjFZZ29LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNVMlZ6YzJsdmJsWmhkV3gwVFdGdVlXZGxjaTUyWlhKcFpubFRaWFIwYkdWVGFXZHVZWFIxY21WZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdGemMyVnlkQ2h6YVdkdVlYUjFjbVV1YkdWdVozUm9JRDA5UFNBMk5Dd2dKMGx1ZG1Gc2FXUWdSV1F5TlRVeE9TQnphV2R1WVhSMWNtVWdiR1Z1WjNSb0p5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb2FXNTBJRFkwSUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnUldReU5UVXhPU0J6YVdkdVlYUjFjbVVnYkdWdVozUm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzWDNObGMzTnBiMjVmZG1GMWJIUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdZMjl1YzNRZ2MybG5ibUYwZFhKbFNYTldZV3hwWkNBOUlHOXdMbVZrTWpVMU1UbDJaWEpwWm5sQ1lYSmxLRzFsYzNOaFoyVXNJSE5wWjI1aGRIVnlaU3dnWVhWMGFHOXlhWHBsWkZOcFoyNWxjaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JsWkRJMU5URTVkbVZ5YVdaNVgySmhjbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelExQ2lBZ0lDQXZMeUJoYzNObGNuUW9jMmxuYm1GMGRYSmxTWE5XWVd4cFpDd2dKMGx1ZG1Gc2FXUWdjMmxuYm1GMGRYSmxKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lITnBaMjVoZEhWeVpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1aGNIQnNlVlJ2Y0ZWd0tHUmhkR0U2SUdKNWRHVnpMQ0JqZFcxMWJHRjBhWFpsUVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BoY0hCc2VWUnZjRlZ3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmpRS0lDQWdJQzh2SUhCeWFYWmhkR1VnWVhCd2JIbFViM0JWY0Noa1lYUmhPaUJEYUdGdWJtVnNTVzVtYnl3Z1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZERvZ1ozUjRiaTVCYzNObGRGUnlZVzV6Wm1WeVZIaHVLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZMUNpQWdJQ0F2THlCaGMzTmxjblFvWTNWdGRXeGhkR2wyWlVGdGIzVnVkQzV6Wlc1a1pYSWdQVDA5SUZSNGJpNXpaVzVrWlhJc0lDZFFZWGx0Wlc1MElITmxibVJsY2lCdGFYTnRZWFJqYUNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUhObGJtUmxjaUJ0YVhOdFlYUmphQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOallLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpkVzExYkdGMGFYWmxRVzF2ZFc1MExtRnpjMlYwVW1WalpXbDJaWElnUFQwOUlHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQW5VR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR052Ym5SeVlXTjBKeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yTndvZ0lDQWdMeThnWVhOelpYSjBLR04xYlhWc1lYUnBkbVZCYlc5MWJuUXVlR1psY2tGemMyVjBMbWxrSUQwOVBTQlZVMFJEWDBGVFUwVlVYMGxFTENBblVHRjViV1Z1ZENCaGMzTmxkQ0J0ZFhOMElHSmxJRlZUUkVNbktRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QllabVZ5UVhOelpYUUtJQ0FnSUdsdWRHTWdOQ0F2THlCVVRWQk1YMVZUUkVOZlFWTlRSVlJmU1VRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQmhjM05sZENCdGRYTjBJR0psSUZWVFJFTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WTRDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEM1aGMzTmxkRUZ0YjNWdWRDQStJREFzSUNkRVpYQnZjMmwwSUcxMWMzUWdZbVVnUGlBd0p5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFUmxjRzl6YVhRZ2JYVnpkQ0JpWlNBK0lEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WTVDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEM1aGMzTmxkRk5sYm1SbGNpQTlQVDBnUVdOamIzVnVkQ2dwTENBblEyeGhkMkpoWTJzZ2RISmhibk5tWlhJZ2JtOTBJR0ZzYkc5M1pXUW5LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJCYzNObGRGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVOc1lYZGlZV05ySUhSeVlXNXpabVZ5SUc1dmRDQmhiR3h2ZDJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM01Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOMWJYVnNZWFJwZG1WQmJXOTFiblF1WVhOelpYUkRiRzl6WlZSdklEMDlQU0JCWTJOdmRXNTBLQ2tzSUNkQmMzTmxkQ0JqYkc5elpTQnViM1FnWVd4c2IzZGxaQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGemMyVjBRMnh2YzJWVWJ3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRnpjMlYwSUdOc2IzTmxJRzV2ZENCaGJHeHZkMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0zTWdvZ0lDQWdMeThnWkdGMFlTNTBiM1JoYkVSbGNHOXphWFFnS3owZ1kzVnRkV3hoZEdsMlpVRnRiM1Z1ZEM1aGMzTmxkRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJRFkySUM4dklEWTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUEyTmdvZ0lDQWdabkpoYldWZlluVnllU0F0TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnpRS0lDQWdJQzh2SUdSaGRHRXVZMnh2YzJWU1pYRjFaWE4wWldSQmRDQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURFd05nb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMweUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmMyTnliM2RUWlhOemFXOXVWbUYxYkhSTllXNWhaMlZ5TG1acGJtRnNhWHBsUTJoaGJtNWxiQ2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtWnBibUZzYVhwbFEyaGhibTVsYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpjM0NpQWdJQ0F2THlCd2NtbDJZWFJsSUdacGJtRnNhWHBsUTJoaGJtNWxiQ2hqYUdGdWJtVnNTV1E2SUdKNWRHVnpMQ0JrWVhSaE9pQkRhR0Z1Ym1Wc1NXNW1ieWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM09Bb2dJQ0FnTHk4Z1kyOXVjM1FnY0dGNVpXVlFZWGx2ZFhRNklIVnBiblEyTkNBOUlHUmhkR0V1YkdGMFpYTjBWbTkxWTJobGNrRnRiM1Z1ZENBdElHUmhkR0V1YkdGemRGTmxkSFJzWldRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQTRNaUF2THlBNE1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRGMwSUM4dklEYzBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM09Rb2dJQ0FnTHk4Z2FXWWdLSEJoZVdWbFVHRjViM1YwSUQ0Z01Da2dld29nSUNBZ1lub2dabWx1WVd4cGVtVkRhR0Z1Ym1Wc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0RBdE16ZzBDaUFnSUNBdkx5QnBkSGh1TG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUVGemMyVjBLRlZUUkVOZlFWTlRSVlJmU1VRcExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCa1lYUmhMbkJoZVdWbExBb2dJQ0FnTHk4Z0lDQmhjM05sZEVGdGIzVnVkRG9nY0dGNVpXVlFZWGx2ZFhRc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0RFS0lDQWdJQzh2SUhobVpYSkJjM05sZERvZ1FYTnpaWFFvVlZORVExOUJVMU5GVkY5SlJDa3NDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlWVTBSRFgwRlRVMFZVWDBsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNE1nb2dJQ0FnTHk4Z1lYTnpaWFJTWldObGFYWmxjam9nWkdGMFlTNXdZWGxsWlN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemd3TFRNNE5Bb2dJQ0FnTHk4Z2FYUjRiaTVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdlR1psY2tGemMyVjBPaUJCYzNObGRDaFZVMFJEWDBGVFUwVlVYMGxFS1N3S0lDQWdJQzh2SUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWkdGMFlTNXdZWGxsWlN3S0lDQWdJQzh2SUNBZ1lYTnpaWFJCYlc5MWJuUTZJSEJoZVdWbFVHRjViM1YwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3BtYVc1aGJHbDZaVU5vWVc1dVpXeGZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9EY0tJQ0FnSUM4dklHTnZibk4wSUhCaGVXVnlVbVZtZFc1a09pQjFhVzUwTmpRZ1BTQmtZWFJoTG5SdmRHRnNSR1Z3YjNOcGRDQXRJR1JoZEdFdWJHRjBaWE4wVm05MVkyaGxja0Z0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRFkySUM4dklEWTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00T0FvZ0lDQWdMeThnYVdZZ0tIQmhlV1Z5VW1WbWRXNWtJRDRnTUNrZ2V3b2dJQ0FnWW5vZ1ptbHVZV3hwZW1WRGFHRnVibVZzWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPRGt0TXprekNpQWdJQ0F2THlCcGRIaHVMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQjRabVZ5UVhOelpYUTZJRUZ6YzJWMEtGVlRSRU5mUVZOVFJWUmZTVVFwTEFvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJrWVhSaExuQmhlV1Z5TEFvZ0lDQWdMeThnSUNCaGMzTmxkRUZ0YjNWdWREb2djR0Y1WlhKU1pXWjFibVFzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZDE5elpYTnphVzl1WDNaaGRXeDBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPVEFLSUNBZ0lDOHZJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9WVk5FUTE5QlUxTkZWRjlKUkNrc0NpQWdJQ0JwYm5SaklEUWdMeThnVkUxUVRGOVZVMFJEWDBGVFUwVlVYMGxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01TVFvZ0lDQWdMeThnWVhOelpYUlNaV05sYVhabGNqb2daR0YwWVM1d1lYbGxjaXdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Ea3RNemt6Q2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCNFptVnlRWE56WlhRNklFRnpjMlYwS0ZWVFJFTmZRVk5UUlZSZlNVUXBMQW9nSUNBZ0x5OGdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmtZWFJoTG5CaGVXVnlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ2NHRjVaWEpTWldaMWJtUXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0NtWnBibUZzYVhwbFEyaGhibTVsYkY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01TmdvZ0lDQWdMeThnZEdocGN5NWphR0Z1Ym1Wc2N5aGphR0Z1Ym1Wc1NXUXBMbVJsYkdWMFpTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2RmYzJWemMybHZibDkyWVhWc2RGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZDFObGMzTnBiMjVXWVhWc2RFMWhibUZuWlhJdWMyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUW9ZMmhoYm01bGJFbGtPaUJpZVhSbGN5d2dZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVUb2dZbmwwWlhNc0lHVjRjR1ZqZEdWa1FYVjBhRzl5YVhwbFpGTnBaMjVsY2toaGMyZzZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHpaWFJCZFhSb2IzSnBlbVZrVTJsbmJtVnlVSFZpYkdsalMyVjVTV1pRY205MmFXUmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNems1TFRRd013b2dJQ0FnTHk4Z2NISnBkbUYwWlNCelpYUkJkWFJvYjNKcGVtVmtVMmxuYm1WeVVIVmliR2xqUzJWNVNXWlFjbTkyYVdSbFpDZ0tJQ0FnSUM4dklDQWdZMmhoYm01bGJFbGtPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdZWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVUb2dZbmwwWlhNc0NpQWdJQ0F2THlBZ0lHVjRjR1ZqZEdWa1FYVjBhRzl5YVhwbFpGTnBaMjVsY2toaGMyZzZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREEwQ2lBZ0lDQXZMeUJwWmlBb1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVM1c1pXNW5kR2dnUGlBd0tTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWW5vZ2MyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd05Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hOb1lUVXhNbDh5TlRZb1lYVjBhRzl5YVhwbFpGTnBaMjVsY2xCMVlteHBZMHRsZVNrZ1BUMDlJR1Y0Y0dWamRHVmtRWFYwYUc5eWFYcGxaRk5wWjI1bGNraGhjMmdzSUNkQmRYUm9iM0pwZW1Wa0lITnBaMjVsY2lCb1lYTm9JRzFwYzIxaGRHTm9KeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MyaGhOVEV5WHpJMU5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUYxZEdodmNtbDZaV1FnYzJsbmJtVnlJR2hoYzJnZ2JXbHpiV0YwWTJnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdGMWRHaHZjbWw2WldSVGFXZHVaWEpRZFdKc2FXTkxaWGtnUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJR0o1ZEdWelBpaDdJR3RsZVZCeVpXWnBlRG9nSjNBbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNkZmMyVnpjMmx2Ymw5MllYVnNkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREEzQ2lBZ0lDQXZMeUJoZFhSb2IzSnBlbVZrVTJsbmJtVnlTMlY1TG5aaGJIVmxJRDBnWVhWMGFHOXlhWHBsWkZOcFoyNWxjbEIxWW14cFkwdGxlUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYM0IxZEFvS2MyVjBRWFYwYUc5eWFYcGxaRk5wWjI1bGNsQjFZbXhwWTB0bGVVbG1VSEp2ZG1sa1pXUmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYTmpjbTkzVTJWemMybHZibFpoZFd4MFRXRnVZV2RsY2k1blpYUlRaWFIwYkdWTlpYTnpZV2RsS0dOb1lXNXVaV3hKWkRvZ1lubDBaWE1zSUdOMWJYVnNZWFJwZG1WQmJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21kbGRGTmxkSFJzWlUxbGMzTmhaMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4TVFvZ0lDQWdMeThnY0hKcGRtRjBaU0JuWlhSVFpYUjBiR1ZOWlhOellXZGxLR05vWVc1dVpXeEpaRG9nWW5sMFpYTXNJR04xYlhWc1lYUnBkbVZCYlc5MWJuUTZJSFZwYm5RMk5DazZJR0o1ZEdWeklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRNS0lDQWdJQzh2SUM1cGRHOWlLRzl3TGtkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKWkM1cFpDa0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRJdE5ERXpDaUFnSUNBdkx5QnlaWFIxY200Z2IzQUtJQ0FnSUM4dklDQWdMbWwwYjJJb2IzQXVSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtMbWxrS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmQxOXpaWE56YVc5dVgzWmhkV3gwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRJdE5ERTBDaUFnSUNBdkx5QnlaWFIxY200Z2IzQUtJQ0FnSUM4dklDQWdMbWwwYjJJb2IzQXVSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtMbWxrS1FvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0dOb1lXNXVaV3hKWkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNYM05sYzNOcGIyNWZkbUYxYkhSZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReE5Rb2dJQ0FnTHk4Z0xtTnZibU5oZENodmNDNXBkRzlpS0dOMWJYVnNZWFJwZG1WQmJXOTFiblFwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M1gzTmxjM05wYjI1ZmRtRjFiSFJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4TWkwME1UVUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNBb2dJQ0FnTHk4Z0lDQXVhWFJ2WWlodmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNXUXVhV1FwQ2lBZ0lDQXZMeUFnSUM1amIyNWpZWFFvWTJoaGJtNWxiRWxrS1FvZ0lDQWdMeThnSUNBdVkyOXVZMkYwS0c5d0xtbDBiMklvWTNWdGRXeGhkR2wyWlVGdGIzVnVkQ2twQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzZGZjMlZ6YzJsdmJsOTJZWFZzZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFMkNpQWdJQ0F2THlBdVkyOXVZMkYwS0VKNWRHVnpLQ2R6WlhSMGJHVW5LU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWljMlYwZEd4bElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkMTl6WlhOemFXOXVYM1poZFd4MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1USXROREUyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0FLSUNBZ0lDOHZJQ0FnTG1sMGIySW9iM0F1UjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTG1sa0tRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtHTm9ZVzV1Wld4SlpDa0tJQ0FnSUM4dklDQWdMbU52Ym1OaGRDaHZjQzVwZEc5aUtHTjFiWFZzWVhScGRtVkJiVzkxYm5RcEtRb2dJQ0FnTHk4Z0lDQXVZMjl1WTJGMEtFSjVkR1Z6S0NkelpYUjBiR1VuS1NrS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFJQklBQW1CUVlWSDN4MUFDQUVGUjk4ZFFBQmNBTUdnUUV4RzBFQWhqRVpGRVF4R0VTQ0VRUkkxVDR5QkwzUHJGZ0VTeDI3WndTcGpZTGFCUGZmamVJRWJvY25pUVRvYXVucEJEUm9VRkFFV1FYVTlBU3FGTVQ1Qkg0L1NtZ0VxSEJKQXdRZW5BQ1FCSXhNL1BjRVp5RFkvd1FuQkpLSkJDdjJDZUEyR2dDT0VRQUxBUWdCUVFHZUFna0Nvd0x6QXh3RFF3TitBNDhEcXdQWkJCVUVXUVNFQkxNQU1Sa1VNUmdVRUVRa1F6WWFBVWNDRlNVU1JERVdKQWxKVGdJNEVJRUVFa1EyR2dKSklsa2pDRXNCRlJKRVZ3SUFOaG9EU1NKWkl3aExBUlVTUkZjQ0FFbE9CRFlhQkVraVdTTUlTd0VWRWtSWEFnQk9CRWtWU1U0R0pSSkVNUUJQQTFBaEJCWlFUd0pRVEZBQlNVNER2VVVCUUFCUU1nWXlCekVBU3doUVN3WVdWd1lDU3doSlRnVlFUSUFDQUhKUUloWk1Td0ZRU3dGUVN3RlFUd1FXVUU4REZsQk1VRXhRU3dSSlRnSlBCVThFaUFWWFR3S0lCSzFMQWJ4SXZ5aExBVkN3SkVOTEFrbStSREVBU3dJaUpib1NSRXNCSlVtNlN3Z1NSRW1CUUZsTEFSVkxBazRDVWxjQ0FFc0hTd0VTUkVzQ1R3VlBBb2dGRVU4Q2lBUm5Td0c4U0w5Qy83YzJHZ0ZKSWxrakNFc0JGUkpFVndJQU1SWWtDVWs0RUlFRUVrUkxBYjFGQVVSTEFiNUlUREVBU3dNaUpib1NSSWdFTFVzQnZFaS9KRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFOaG9DU1NKWkl3aExBUlVTUkZjQ0FFc0J2VVVCUkVzQnZraE9BakVBU3dJaUpib1NSRWtWUkVrRFN3SlBBa3NDaUFTSWdBSUFJRXhRU3dLQlFGbFBBeUpQQWxoTVVFc0J2RWkvSkVNMkdnRkpJbGtqQ0VzQkZSSkVWd0lBTmhvQ1NSV0JDQkpFU1JjMkdnTkpJbGtqQ0VzQkZSSkVWd0lBU3dPOVJRRkVNUUJMQkNJbHVoSkVTd09EQWtvSXVoZExBZzVFU3dPREFsSUl1aGRMQWd4RVN3T0RBa0lJdWhkTEFnOUVTd05PQW9nQzlJRlNUTHNrUXpZYUFVa2lXU01JU3dFVkVrUlhBZ0JKTmhvQ1NVNENTUldCQ0JKRVNSYzJHZ05KSWxrakNFc0JGUkpFVndJQVN3TzlSUUZFU3dPK1NFNERNUUJMQlNWSnVreExBUkpFU3dXREFrb0l1aGRMQTBzQkRVUkxCb01DUWdpNkYwc0VEMFJQQmtzRVR3U0lBb1JMQWt3SnNTRUVzaEd5RXJJVWdRU3lFQ0t5QWJOT0FseEtTVTRDZ1ZKYkRVRUFCRXNCWEZKTEFrbThTRXkvSkVNMkdnRkpJbGtqQ0VzQkZSSkVWd0lBU2IxRkFVUXhBRXNCSlVtNlRFc0JFa1JMQVlNQ1VnaTZTUmRMQTRNQ1NnaTZGMG9OUkFteElRUk1zaEpQQXJJVXNoR0JCTElRSXJJQnM0RktUTHNrUXpZYUFVa2lXU01JU3dFVkVrUlhBZ0JKdlVVQlJFbStTRXd4QUVzQkpVbTZFa1JNaUFLWVNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FFbTlSUUZFTVFCTEFTSWx1aEpFTWdjV2dXcE11eVJETmhvQlNTSlpJd2hMQVJVU1JGY0NBRW05UlFGRVNiNUlUREVBU3dFaUpib1NSRW1EQW1vSXVoZEpSRElIVElINEJnZ1BSRXlJQWpaSUpFTTJHZ0ZKRlNVU1JGY0FJRElLRWtRa1F6RUFNZ2tTUkxFaEJESUtJcklTc2hTeUVZRUVzaEFpc2dHekpFTTJHZ0ZKSWxrakNFc0JGUkpFVndJQVNiMUZBVVJKZ3dKYUNMb1hUSU1DWWdpNkYwd1dUQlpRS1V4UXNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FFbTlSUUZFU1lNQ1FnaTZGMHNCZ3dKS0NMb1hUd0tEQWxJSXVoZFBBaFpQQWhaUVRCWlFLVXhRc0NSRE5ob0JTUlVsRWtRMkdnSkpGU1VTUkRZYUEwa2lXU01JU3dFVkVrUlhBZ0EyR2dSSklsa2pDRXNCRlJKRVZ3SUFUd05QQTFBaEJCWlFURkJNVUFFb1RGQ3dKRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFOaG9DU1JXQkNCSkVGNGdCc1VrVkZsY0dBa3hRS1V4UXNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FEWWFBa2tWZ1FnU1JCYzJHZ05KSWxrakNFc0JGUkpFVndJQWlBQkdKRU0yR2dGSkZTVVNSRFlhQWtrVkpSSkVOaG9EU1NKWkl3aExBUlVTUkZjQ0FEWWFCRWtpV1NNSVN3RVZFa1JYQWdCUEEwOERVQ0VFRmxCTVVFeFFBU2hNVUxBa1E0b0RBQ3FML2IxRkFVU0wvYjVJaS8yTC9vZ0JHeXVML1ZCSnZVVUJSTDVJZ1pJbk1nd05RUUFac1lFR3NoQ0JCYklaSndTeUhpY0VzaDh5QUxJQnMwTC8zb3NEQTRzQlNZRkFXVXNCRlZKWEFnQVNSSXYvRlVtTUFJRkFEVUVBQVltTEFJRkFFa1NMQW92L2l3T0VSSW1LQWdHTC96Z0FNUUFTUkl2L09CUXlDaEpFaS84NEVTRUVFa1NML3pnU1NVU0wvemdUTWdNU1JJdi9PQlV5QXhKRWkvNkJRbHNJRm92K1RGeENqUDRpRm92K1RGeHFTWXoraVlvQ0FTcUwvNEZTVzBtTC80RktXd2xKUVFBWXNTRUVpLzlYSUNDTEFySVNzaFN5RVlFRXNoQWlzZ0d6aS8rQlFsdUxBUWxKakFCQkFCaXhJUVNMLzFjQUlJc0FzaEt5RkxJUmdRU3lFQ0t5QWJPTC9yeElpLytNQUltS0F3Q0wvaFZCQUJHTC9nT0wveEpFSzR2OVVFbThTSXYrdjRtS0FnRXlDQmFML2xDTC94WlFnQVp6WlhSMGJHVlFpUT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnsiVVNEQ19BU1NFVF9JRCI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
