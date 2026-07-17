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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.GiverPositionManager_50cdb363
{


    //
    // @title GiverPositionManager
    // @author Aave Labs
    // @notice Position manager to handle supply and repay actions on behalf of users.
    //
    public class GiverPositionManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GiverPositionManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Eip712DomainReturn : AVMObjectType
            {
                public byte[] Fields { get; set; }

                public string Name { get; set; }

                public string Version { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 ChainId { get; set; }

                public Algorand.Address VerifyingContract { get; set; }

                public byte[] Salt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Extensions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    vFields.From(Fields);
                    ret.AddRange(vFields.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.From(Version);
                    stringRef[ret.Count] = vVersion.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChainId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vChainId.From(ChainId);
                    ret.AddRange(vChainId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vVerifyingContract.From(VerifyingContract);
                    ret.AddRange(vVerifyingContract.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSalt.From(Salt);
                    ret.AddRange(vSalt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    vExtensions.From(Extensions);
                    ret.AddRange(vExtensions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Eip712DomainReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Eip712DomainReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    count = vFields.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFields = vFields.ToValue();
                    if (valueFields is byte[] vFieldsValue) { ret.Fields = vFieldsValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexVersion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.Decode(bytes.Skip(indexVersion + prefixOffset).ToArray());
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is string vVersionValue) { ret.Version = vVersionValue; }
                    var vChainId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vChainId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ChainId = vChainId;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVerifyingContract.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifyingContract = vVerifyingContract.ToValue();
                    if (valueVerifyingContract is Algorand.Address vVerifyingContractValue) { ret.VerifyingContract = vVerifyingContractValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSalt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSalt = vSalt.ToValue();
                    if (valueSalt is byte[] vSaltValue) { ret.Salt = vSaltValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    count = vExtensions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExtensions = vExtensions.ToValue();
                    if (valueExtensions is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vExtensionsValue) { ret.Extensions = vExtensionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Eip712DomainReturn);
                }
                public bool Equals(Eip712DomainReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return EqualityComparer<Eip712DomainReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return !(left == right);
                }

            }

            public class SupplyOnBehalfOfReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
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

                public static SupplyOnBehalfOfReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SupplyOnBehalfOfReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SupplyOnBehalfOfReturn);
                }
                public bool Equals(SupplyOnBehalfOfReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SupplyOnBehalfOfReturn left, SupplyOnBehalfOfReturn right)
                {
                    return EqualityComparer<SupplyOnBehalfOfReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(SupplyOnBehalfOfReturn left, SupplyOnBehalfOfReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class OwnershipTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 98, 102, 143, 204 };
                public const string Signature = "OwnershipTransferred(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] PreviousOwner { get; set; }
                public byte[] NewOwner { get; set; }

                public static OwnershipTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnershipTransferredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is byte[] vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class SpokeRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 161, 144, 53, 134 };
                public const string Signature = "SpokeRegistered(uint8[32],bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Spoke { get; set; }
                public bool Registered { get; set; }

                public static SpokeRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SpokeRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistered = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vRegistered.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistered = vRegistered.ToValue();
                    if (valueRegistered is bool vRegisteredValue) { ret.Registered = vRegisteredValue; }
                    return ret;

                }

            }

            public class OwnershipTransferStartedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 142, 90, 121, 135 };
                public const string Signature = "OwnershipTransferStarted(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] PreviousOwner { get; set; }
                public byte[] NewOwner { get; set; }

                public static OwnershipTransferStartedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnershipTransferStartedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vPreviousOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousOwner = vPreviousOwner.ToValue();
                    if (valuePreviousOwner is byte[] vPreviousOwnerValue) { ret.PreviousOwner = vPreviousOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="initialOwner_"> </param>
        public async Task PostInit(Algorand.Address initialOwner_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialOwner_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialOwner_Abi.From(initialOwner_);

            var result = await base.CallApp(new List<object> { abiHandle, initialOwner_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Algorand.Address initialOwner_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var initialOwner_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); initialOwner_Abi.From(initialOwner_);

            return await base.MakeTransactionList(new List<object> { abiHandle, initialOwner_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IGiverPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="__arc4_amount"> </param>
        /// <param name="onBehalfOf"> </param>
        public async Task<Structs.SupplyOnBehalfOfReturn> SupplyOnBehalfOf(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 155, 79, 233 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_amount, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SupplyOnBehalfOfReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> SupplyOnBehalfOf_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 155, 79, 233 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_amount, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IGiverPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="__arc4_amount"> </param>
        /// <param name="onBehalfOf"> </param>
        public async Task<Structs.SupplyOnBehalfOfReturn> RepayOnBehalfOf(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 218, 150, 134 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_amount, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SupplyOnBehalfOfReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RepayOnBehalfOf_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 218, 150, 134 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_amount, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="registered"> </param>
        public async Task RegisterSpoke(Algorand.Address spoke, bool registered, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 47, 162, 152 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var registeredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); registeredAbi.From(registered);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, registeredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterSpoke_Transactions(Algorand.Address spoke, bool registered, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 47, 162, 152 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var registeredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); registeredAbi.From(registered);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, registeredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="onBehalfOf"> </param>
        /// <param name="approve"> </param>
        /// <param name="__arc4_nonce"> </param>
        /// <param name="__arc4_deadline"> </param>
        /// <param name="signature"> </param>
        public async Task SetSelfAsUserPositionManagerWithSig(Algorand.Address spoke, Algorand.Address onBehalfOf, bool approve, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_nonce, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 169, 68, 51 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var approveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approveAbi.From(approve);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi, approveAbi, __arc4_nonce, __arc4_deadline, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSelfAsUserPositionManagerWithSig_Transactions(Algorand.Address spoke, Algorand.Address onBehalfOf, bool approve, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_nonce, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 169, 68, 51 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var approveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approveAbi.From(approve);
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi, approveAbi, __arc4_nonce, __arc4_deadline, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="onBehalfOf"> </param>
        /// <param name="__arc4_value"> </param>
        /// <param name="__arc4_deadline"> </param>
        /// <param name="permitV"> </param>
        /// <param name="permitR"> </param>
        /// <param name="permitS"> </param>
        public async Task PermitReserveUnderlying(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Algorand.Address onBehalfOf, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong permitV, byte[] permitR, byte[] permitS, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 0, 77, 131 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var permitVAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permitVAbi.From(permitV);
            var permitRAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitRAbi.From(permitR);
            var permitSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitSAbi.From(permitS);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, onBehalfOfAbi, __arc4_value, __arc4_deadline, permitVAbi, permitRAbi, permitSAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PermitReserveUnderlying_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Algorand.Address onBehalfOf, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong permitV, byte[] permitR, byte[] permitS, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 0, 77, 131 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);
            var permitVAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); permitVAbi.From(permitV);
            var permitRAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitRAbi.From(permitR);
            var permitSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); permitSAbi.From(permitS);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, onBehalfOfAbi, __arc4_value, __arc4_deadline, permitVAbi, permitRAbi, permitSAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="user"> </param>
        public async Task RenouncePositionManagerRole(Algorand.Address spoke, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 50, 241, 201 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenouncePositionManagerRole_Transactions(Algorand.Address spoke, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 50, 241, 201 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IMulticall
        ///</summary>
        /// <param name="data"> </param>
        public async Task<byte[][]> Multicall(byte[][] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 145, 154, 38 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> Multicall_Transactions(byte[][] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 145, 154, 38 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IPositionManagerBase
        ///</summary>
        /// <param name="spoke"> </param>
        public async Task<bool> IsSpokeRegistered(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 210, 248, 20 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.SimApp(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsSpokeRegistered_Transactions(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 210, 248, 20 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IRescuable
        ///</summary>
        /// <param name="token"> </param>
        /// <param name="to"> </param>
        /// <param name="__arc4_amount"> </param>
        public async Task RescueToken(Algorand.Address token, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 185, 140, 95 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, tokenAbi, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RescueToken_Transactions(Algorand.Address token, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 185, 140, 95 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IRescuable
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="__arc4_amount"> </param>
        public async Task RescueNative(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 219, 16, 152 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RescueNative_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 219, 16, 152 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, __arc4_amount }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IRescuable
        ///</summary>
        public async Task<Algorand.Address> RescueGuardian(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 106, 38, 223 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> RescueGuardian_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 106, 38, 223 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IIntentConsumer
        ///</summary>
        public async Task<byte[]> DomainSeparator(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 11, 142, 70 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> DomainSeparator_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 11, 142, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev See: https://eips.ethereum.org/EIPS/eip-5267
        ///</summary>
        public async Task<Structs.Eip712DomainReturn> Eip712Domain(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 107, 24, 50 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Eip712DomainReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Eip712Domain_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 107, 24, 50 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc INoncesKeyed
        ///</summary>
        /// <param name="__arc4_key"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UseNonce(System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 214, 133, 147 };
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> UseNonce_Transactions(System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 214, 133, 147 };
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc INoncesKeyed
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="__arc4_key"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Nonces(Algorand.Address owner, System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 235, 249, 27 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Nonces_Transactions(Algorand.Address owner, System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 235, 249, 27 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the address of the pending owner.
        ///</summary>
        public async Task<Algorand.Address> PendingOwner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 173, 69, 22 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> PendingOwner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 173, 69, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Starts the ownership transfer of the contract to a new account. Replaces the pending transfer if there is one.
        /// Can only be called by the current owner.
        /// Setting `newOwner` to the zero address is allowed; this can be used to cancel an initiated ownership transfer.
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task TransferOwnership(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferOwnership_Transactions(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 123, 175, 180 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev The new owner accepts the ownership transfer.
        ///</summary>
        public async Task AcceptOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 33, 214, 4 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AcceptOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 33, 214, 4 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the address of the current owner.
        ///</summary>
        public async Task<Algorand.Address> Owner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Owner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Leaves the contract without owner. It will not be possible to call
        /// `onlyOwner` functions. Can only be called by the current owner.
        /// NOTE: Renouncing ownership will leave the contract without an owner,
        /// thereby disabling any functionality that is only available to the owner.
        ///</summary>
        public async Task RenounceOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 44, 97, 229 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 44, 97, 229 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2l2ZXJQb3NpdGlvbk1hbmFnZXIiLCJkZXNjIjoiQHRpdGxlIEdpdmVyUG9zaXRpb25NYW5hZ2VyXG4gQGF1dGhvciBBYXZlIExhYnNcbiBAbm90aWNlIFBvc2l0aW9uIG1hbmFnZXIgdG8gaGFuZGxlIHN1cHBseSBhbmQgcmVwYXkgYWN0aW9ucyBvbiBiZWhhbGYgb2YgdXNlcnMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7ImVpcDcxMkRvbWFpblJldHVybiI6W3sibmFtZSI6ImZpZWxkcyIsInR5cGUiOiJieXRlWzFdIn0seyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ2ZXJzaW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImNoYWluSWQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InZlcmlmeWluZ0NvbnRyYWN0IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzYWx0IiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZXh0ZW5zaW9ucyIsInR5cGUiOiJ1aW50MjU2W10ifV0sIlN1cHBseU9uQmVoYWxmT2ZSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NTEyIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxPd25lcl8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1cHBseU9uQmVoYWxmT2YiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUdpdmVyUG9zaXRpb25NYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGZPZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlN1cHBseU9uQmVoYWxmT2ZSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBheU9uQmVoYWxmT2YiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUdpdmVyUG9zaXRpb25NYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGZPZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDUxMix1aW50NTEyKSIsInN0cnVjdCI6IlN1cHBseU9uQmVoYWxmT2ZSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlclNwb2tlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElQb3NpdGlvbk1hbmFnZXJCYXNlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlNwb2tlUmVnaXN0ZXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RlcmVkIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0U2VsZkFzVXNlclBvc2l0aW9uTWFuYWdlcldpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVBvc2l0aW9uTWFuYWdlckJhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGZPZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfbm9uY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfZGVhZGxpbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwZXJtaXRSZXNlcnZlVW5kZXJseWluZyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUG9zaXRpb25NYW5hZ2VyQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfcmVzZXJ2ZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGZPZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF92YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9kZWFkbGluZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWl0ViIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtaXRSIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pdFMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VQb3NpdGlvbk1hbmFnZXJSb2xlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElQb3NpdGlvbk1hbmFnZXJCYXNlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXVsdGljYWxsIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElNdWx0aWNhbGwiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc1Nwb2tlUmVnaXN0ZXJlZCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUG9zaXRpb25NYW5hZ2VyQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNjdWVUb2tlbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUmVzY3VhYmxlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNjdWVOYXRpdmUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVJlc2N1YWJsZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc2N1ZUd1YXJkaWFuIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElSZXNjdWFibGUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJET01BSU5fU0VQQVJBVE9SIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElJbnRlbnRDb25zdW1lciIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlaXA3MTJEb21haW4iLCJkZXNjIjoiQGRldiBTZWU6IGh0dHBzOi8vZWlwcy5ldGhlcmV1bS5vcmcvRUlQUy9laXAtNTI2NyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVsxXSxzdHJpbmcsc3RyaW5nLHVpbnQ1MTIsYWRkcmVzcyxieXRlWzMyXSx1aW50MjU2W10pIiwic3RydWN0IjoiZWlwNzEyRG9tYWluUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1c2VOb25jZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTm9uY2VzS2V5ZWQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDE5MiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibm9uY2VzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElOb25jZXNLZXllZCIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxOTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfa2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGVuZGluZ093bmVyIiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIGFkZHJlc3Mgb2YgdGhlIHBlbmRpbmcgb3duZXIuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJPd25lcnNoaXAiLCJkZXNjIjoiIEBkZXYgU3RhcnRzIHRoZSBvd25lcnNoaXAgdHJhbnNmZXIgb2YgdGhlIGNvbnRyYWN0IHRvIGEgbmV3IGFjY291bnQuIFJlcGxhY2VzIHRoZSBwZW5kaW5nIHRyYW5zZmVyIGlmIHRoZXJlIGlzIG9uZS5cbiBDYW4gb25seSBiZSBjYWxsZWQgYnkgdGhlIGN1cnJlbnQgb3duZXIuXG4gU2V0dGluZyBgbmV3T3duZXJgIHRvIHRoZSB6ZXJvIGFkZHJlc3MgaXMgYWxsb3dlZDsgdGhpcyBjYW4gYmUgdXNlZCB0byBjYW5jZWwgYW4gaW5pdGlhdGVkIG93bmVyc2hpcCB0cmFuc2Zlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lcnNoaXBUcmFuc2ZlclN0YXJ0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjZXB0T3duZXJzaGlwIiwiZGVzYyI6IiBAZGV2IFRoZSBuZXcgb3duZXIgYWNjZXB0cyB0aGUgb3duZXJzaGlwIHRyYW5zZmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjoiIEBkZXYgUmV0dXJucyB0aGUgYWRkcmVzcyBvZiB0aGUgY3VycmVudCBvd25lci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW5vdW5jZU93bmVyc2hpcCIsImRlc2MiOiIgQGRldiBMZWF2ZXMgdGhlIGNvbnRyYWN0IHdpdGhvdXQgb3duZXIuIEl0IHdpbGwgbm90IGJlIHBvc3NpYmxlIHRvIGNhbGxcbiBgb25seU93bmVyYCBmdW5jdGlvbnMuIENhbiBvbmx5IGJlIGNhbGxlZCBieSB0aGUgY3VycmVudCBvd25lci5cbiBOT1RFOiBSZW5vdW5jaW5nIG93bmVyc2hpcCB3aWxsIGxlYXZlIHRoZSBjb250cmFjdCB3aXRob3V0IGFuIG93bmVyLFxuIHRoZXJlYnkgZGlzYWJsaW5nIGFueSBmdW5jdGlvbmFsaXR5IHRoYXQgaXMgb25seSBhdmFpbGFibGUgdG8gdGhlIG93bmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjo3fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMjM2LDIzOTFdLCJlcnJvck1lc3NhZ2UiOiJBQkkgYm9vbCB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA0Ml0sImVycm9yTWVzc2FnZSI6IkFCSSB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIyM10sImVycm9yTWVzc2FnZSI6IkZhaWxlZENhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjA1XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50QmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzOTddLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkQWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4MzZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5UmVzY3VlR3VhcmRpYW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTM2XSwiZXJyb3JNZXNzYWdlIjoiT3duYWJsZUludmFsaWRPd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwNywzOTMyXSwiZXJyb3JNZXNzYWdlIjoiT3duYWJsZVVuYXV0aG9yaXplZEFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTI2XSwiZXJyb3JNZXNzYWdlIjoiUmVwYXlPbkJlaGFsZk1heFVpbnROb3RBbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI5MSwzMzA4LDMzMzgsMzM0OV0sImVycm9yTWVzc2FnZSI6IlNhZmVFUkMyMEZhaWxlZE9wZXJhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMzQsMjIzMSwyNDg1LDI3NTVdLCJlcnJvck1lc3NhZ2UiOiJTcG9rZU5vdFJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODkwXSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkQ2hhaW5JZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQ3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2NhY2hlZERvbWFpblNlcGFyYXRvciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTkyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2NhY2hlZE5hbWVIYXNoIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkVGhpcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2NhY2hlZFZlcnNpb25IYXNoIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4ODMsMzkxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODU5LDM4NzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfcGVuZGluZ093bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyODBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3ODNdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTU5LDE2MTMsMjE5OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNjgsMjM2NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjYsNzg5LDE0MDgsMTQ1NywxNDY3LDE1MTgsMTg3MCwxODgwLDE5NDMsMTk2MywyMDA0LDIwMTQsMjE0NywyMTU3LDIzNTQsMjQzNSwyNDY1LDI3MDUsMjczNSwyODg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMCw4ODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MTkyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQxOCwxNDc3LDE5NTMsMTk3MywxOTgzLDIxODIsMjE5MiwyNDQ1LDI0NTUsMjcxNSwyNzI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjA3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50OFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2Miw2OTcsNzM5LDgxMyw4OTUsOTc4LDExMzksMTM4NSwxNDMxLDE0OTAsMTUzMSwxNjQ4LDE2NjEsMTg5MywyMDI3LDIyMjQsMjM4MiwyNDc4LDI3NDgsMzg1NCwzOTE0XSwiZXJyb3JNZXNzYWdlIjoibm90IHBheWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NjAsOTU0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjc3LDM0NTMsMzU4NSwzNzE3XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBkcGRtVnlVRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVIYVhabGNsQnZjMmwwYVc5dVRXRnVZV2RsY2k1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRE15SURBZ01TQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRJREI0TURFZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TVRVeFpqZGpOelVnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdJbDl3Wlc1a2FXNW5UM2R1WlhJaUlDSmZiM2R1WlhJaUlDSmZYMk4wYjNKZmNHVnVaR2x1WnlJZ0lsOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0lpSUNKZlkyRmphR1ZrUTJoaGFXNUpaQ0lnSWw5allXTm9aV1JVYUdseklpQWlYMk5oWTJobFpFNWhiV1ZJWVhOb0lpQWlYMk5oWTJobFpGWmxjbk5wYjI1SVlYTm9JaUF3ZURJd0lEQjRNREF3TUNBaVgzSmxaMmx6ZEdWeVpXUlRjRzlyWlhNaUlDSmZibTl1WTJWeklpQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREFnTUhnNFlqY3pZek5qTmpsaVlqaG1aVE5rTlRFeVpXTmpOR05tTnpVNVkyTTNPVEl6T1dZM1lqRTNPV0l3Wm1aaFkyRmhPV0UzTldRMU1qSmlNemswTURCbUlEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNU0F3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWWdNSGhqTWpGa09UZzRabU00WkRrNU56bG1NREE0WW1Vd05tWTJNMlJqTXpjM1ptUTFPR00xTnpObU16VTBNak13TURoa1pqRTFOV1kxTldFME1EY3paR0ZoSURCNFl6ZzVaV1prWVdFMU5HTXdaakl3WXpkaFpHWTJNVEk0T0RKa1pqQTVOVEJtTldFNU5URTJNemRsTURNd04yTmtZMkkwWXpZM01tWXlPVGhpT0dKak5nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1IxY0c0Z01qSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUdSMWNHNGdOd29nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNU9UQm1NekJoWlNBd2VHSmlPV0kwWm1VNUlEQjRNekZrWVRrMk9EWWdNSGhpT0RKbVlUSTVPQ0F3ZURneFlUazBORE16SURCNE56Y3dNRFJrT0RNZ01IaGhZek15WmpGak9TQXdlREEwT1RFNVlUSTJJREI0TXpWa01tWTRNVFFnTUhnM1lXSTVPR00xWmlBd2VERmlaR0l4TURrNElEQjRaV00yWVRJMlpHWWdNSGhpWkRCaU9HVTBOaUF3ZUdNNE5tSXhPRE15SURCNFpEWmtOamcxT1RNZ01IZzBZbVZpWmpreFlpQXdlR1ExWVdRME5URTJJREI0WlRFM1ltRm1ZalFnTUhoa05USXhaRFl3TkNBd2VHSXhZbUppTUdFNElEQjRNMlV5WXpZeFpUVWdMeThnYldWMGFHOWtJQ0pmWDNCdmMzUkpibWwwS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljM1Z3Y0d4NVQyNUNaV2hoYkdaUFppaGhaR1J5WlhOekxIVnBiblF5TlRZc2RXbHVkREkxTml4aFpHUnlaWE56S1NoMWFXNTBOVEV5TEhWcGJuUTFNVElwSWl3Z2JXVjBhRzlrSUNKeVpYQmhlVTl1UW1Wb1lXeG1UMllvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNZV1JrY21WemN5a29kV2x1ZERVeE1peDFhVzUwTlRFeUtTSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSlRjRzlyWlNoaFpHUnlaWE56TEdKdmIyd3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBVMlZzWmtGelZYTmxjbEJ2YzJsMGFXOXVUV0Z1WVdkbGNsZHBkR2hUYVdjb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKdmIyd3NkV2x1ZERJMU5peDFhVzUwTWpVMkxHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0p3WlhKdGFYUlNaWE5sY25abFZXNWtaWEpzZVdsdVp5aGhaR1J5WlhOekxIVnBiblF5TlRZc1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWREWTBMR0o1ZEdWYk16SmRMR0o1ZEdWYk16SmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxibTkxYm1ObFVHOXphWFJwYjI1TllXNWhaMlZ5VW05c1pTaGhaR1J5WlhOekxHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYlhWc2RHbGpZV3hzS0dKNWRHVmJYVnRkS1dKNWRHVmJYVnRkSWl3Z2JXVjBhRzlrSUNKcGMxTndiMnRsVW1WbmFYTjBaWEpsWkNoaFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbkpsYzJOMVpWUnZhMlZ1S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxjMk4xWlU1aGRHbDJaU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVnpZM1ZsUjNWaGNtUnBZVzRvS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSWtSUFRVRkpUbDlUUlZCQlVrRlVUMUlvS1dKNWRHVmJNekpkSWl3Z2JXVjBhRzlrSUNKbGFYQTNNVEpFYjIxaGFXNG9LU2hpZVhSbFd6RmRMSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFV4TWl4aFpHUnlaWE56TEdKNWRHVmJNekpkTEhWcGJuUXlOVFpiWFNraUxDQnRaWFJvYjJRZ0luVnpaVTV2Ym1ObEtIVnBiblF4T1RJcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWJtOXVZMlZ6S0dGa1pISmxjM01zZFdsdWRERTVNaWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0p3Wlc1a2FXNW5UM2R1WlhJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0luUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd0tHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdOalpYQjBUM2R1WlhKemFHbHdLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnZkMjVsY2lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWNtVnViM1Z1WTJWUGQyNWxjbk5vYVhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMTlmY0c5emRFbHVhWFJmY205MWRHVkFOU0J0WVdsdVgzTjFjSEJzZVU5dVFtVm9ZV3htVDJaZmNtOTFkR1ZBTmlCdFlXbHVYM0psY0dGNVQyNUNaV2hoYkdaUFpsOXliM1YwWlVBM0lHMWhhVzVmY21WbmFYTjBaWEpUY0c5clpWOXliM1YwWlVBNElHMWhhVzVmYzJWMFUyVnNaa0Z6VlhObGNsQnZjMmwwYVc5dVRXRnVZV2RsY2xkcGRHaFRhV2RmY205MWRHVkFPU0J0WVdsdVgzQmxjbTFwZEZKbGMyVnlkbVZWYm1SbGNteDVhVzVuWDNKdmRYUmxRREV3SUcxaGFXNWZjbVZ1YjNWdVkyVlFiM05wZEdsdmJrMWhibUZuWlhKU2IyeGxYM0p2ZFhSbFFERXhJRzFoYVc1ZmJYVnNkR2xqWVd4c1gzSnZkWFJsUURFeUlHMWhhVzVmYVhOVGNHOXJaVkpsWjJsemRHVnlaV1JmY205MWRHVkFNVE1nYldGcGJsOXlaWE5qZFdWVWIydGxibDl5YjNWMFpVQXhOQ0J0WVdsdVgzSmxjMk4xWlU1aGRHbDJaVjl5YjNWMFpVQXhOU0J0WVdsdVgzSmxjMk4xWlVkMVlYSmthV0Z1WDNKdmRYUmxRREUySUcxaGFXNWZSRTlOUVVsT1gxTkZVRUZTUVZSUFVsOXliM1YwWlVBeE55QnRZV2x1WDJWcGNEY3hNa1J2YldGcGJsOXliM1YwWlVBeE9DQnRZV2x1WDNWelpVNXZibU5sWDNKdmRYUmxRREU1SUcxaGFXNWZibTl1WTJWelgzSnZkWFJsUURJd0lHMWhhVzVmY0dWdVpHbHVaMDkzYm1WeVgzSnZkWFJsUURJeElHMWhhVzVmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEJmY205MWRHVkFNaklnYldGcGJsOWhZMk5sY0hSUGQyNWxjbk5vYVhCZmNtOTFkR1ZBTWpNZ2JXRnBibDl2ZDI1bGNsOXliM1YwWlVBeU5DQnRZV2x1WDNKbGJtOTFibU5sVDNkdVpYSnphR2x3WDNKdmRYUmxRREkxQ2lBZ0lDQmxjbklLQ20xaGFXNWZjbVZ1YjNWdVkyVlBkMjVsY25Ob2FYQmZjbTkxZEdWQU1qVTZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE14Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE15T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCallXeHNjM1ZpSUY5amFHVmphMDkzYm1WeUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Ub0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek1nb0tiV0ZwYmw5dmQyNWxjbDl5YjNWMFpVQXlORG9LSUNBZ0lHTmhiR3h6ZFdJZ2IzZHVaWElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV05qWlhCMFQzZHVaWEp6YUdsd1gzSnZkWFJsUURJek9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpPQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpPVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQndaVzVrYVc1blQzZHVaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQWhQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5M2JtRmliR1ZWYm1GMWRHaHZjbWw2WldSQlkyTnZkVzUwQ2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE00T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE01Q2dwdFlXbHVYM1J5WVc1elptVnlUM2R1WlhKemFHbHdYM0p2ZFhSbFFESXlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURRekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTA5M2JtVnlDaUFnSUNCaWVYUmxZeUExSUM4dklDSmZjR1Z1WkdsdVowOTNibVZ5SWdvZ0lDQWdaR2xuSURJeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCallXeHNjM1ZpSUc5M2JtVnlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGhsTldFM09UZzNJQzh2SUcxbGRHaHZaQ0FpVDNkdVpYSnphR2x3VkhKaGJuTm1aWEpUZEdGeWRHVmtLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTBNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBOQW9LYldGcGJsOXdaVzVrYVc1blQzZHVaWEpmY205MWRHVkFNakU2Q2lBZ0lDQmpZV3hzYzNWaUlIQmxibVJwYm1kUGQyNWxjZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXViMjVqWlhOZmNtOTFkR1ZBTWpBNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qRUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpNQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF4T1RJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5UQUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5URTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklESXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UWWdMeThnSWw5dWIyNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbmwwWldNZ01UY2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS2dvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR0o4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVd09nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVeENncHRZV2x1WDNWelpVNXZibU5sWDNKdmRYUmxRREU1T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRERTVNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTmpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ016RUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlYMjV2Ym1ObGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZVhSbFl5QXhOeUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW53S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5UVTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5UWUtDbTFoYVc1ZlpXbHdOekV5Ukc5dFlXbHVYM0p2ZFhSbFFERTRPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyTUFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTVRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR1l3TURnM01EQTVaREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQmhNREF3TVRRME56WTVOelkyTlRjeU5UQTJaamN6TmprM05EWTVObVkyWlRSa05qRTJaVFl4TmpjMk5UY3lNREF3TVRNeE1EQXdNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qQTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qRUtDbTFoYVc1ZlJFOU5RVWxPWDFORlVFRlNRVlJQVWw5eWIzVjBaVUF4TnpvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qWTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pmWTJGamFHVmtSRzl0WVdsdVUyVndZWEpoZEc5eUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTVRjS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZZMkZqYUdWa1JHOXRZV2x1VTJWd1lYSmhkRzl5SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0lsOWpZV05vWldSRGFHRnBia2xrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmWTJGamFHVmtRMmhoYVc1SlpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWDJOaFkyaGxaRlJvYVhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5allXTm9aV1JVYUdseklHVjRhWE4wY3dvZ0lDQWdiRzloWkNBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZajA5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaVBUMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJSE4zWVhBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhORGNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlYMk5oWTJobFpFNWhiV1ZJWVhOb0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCZlkyRmphR1ZrVG1GdFpVaGhjMmdnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0lsOWpZV05vWldSV1pYSnphVzl1U0dGemFDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyTmhZMmhsWkZabGNuTnBiMjVJWVhOb0lHVjRhWE4wY3dvZ0lDQWdiRzloWkNBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrZFhBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpJREU0SUM4dklEQjRPR0kzTTJNell6WTVZbUk0Wm1VelpEVXhNbVZqWXpSalpqYzFPV05qTnpreU16bG1OMkl4TnpsaU1HWm1ZV05oWVRsaE56VmtOVEl5WWpNNU5EQXdaZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBekNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VESXdDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9hVzUwSURFMk1Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHdGxZMk5oYXpJMU5nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1luVnllU0F4TndvZ0lDQWdjM1J2Y21VZ01Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUwTnpvS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdaR2xuSURFMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFkxT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFkyQ2dwdFlXbHVYM0psYzJOMVpVZDFZWEprYVdGdVgzSnZkWFJsUURFMk9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTNNQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWTJGc2JITjFZaUJ2ZDI1bGNnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGN3T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGN4Q2dwdFlXbHVYM0psYzJOMVpVNWhkR2wyWlY5eWIzVjBaVUF4TlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEYzFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEYzJPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamExSmxjMk4xWlVkMVlYSmthV0Z1Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1JwWnlBek1Rb2dJQ0FnWTJGc2JITjFZaUJCWkdSeVpYTnpMbk5sYm1SV1lXeDFaUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjMU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURjMkNncHRZV2x1WDNKbGMyTjFaVlJ2YTJWdVgzSnZkWFJsUURFME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUE0TUFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUE0TVRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnRTWlhOamRXVkhkV0Z5WkdsaGJnb2dJQ0FnWkdsbklEa0tJQ0FnSUdScFp5QXhNUW9nSUNBZ1pHbG5JRE15Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZGVWtNeU1DNXpZV1psVkhKaGJuTm1aWElLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE1Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE1Rb0tiV0ZwYmw5cGMxTndiMnRsVW1WbmFYTjBaWEpsWkY5eWIzVjBaVUF4TXpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTROUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTROam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWkdsbklERXpDaUFnSUNCallXeHNjM1ZpSUY5cGMxTndiMnRsVW1WbmFYTjBaWEpsWkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURnMU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURnMkNncHRZV2x1WDIxMWJIUnBZMkZzYkY5eWIzVjBaVUF4TWpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTVDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ29LSUNBZ0lHSjFjbmtnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjFjbmtnTWpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlkWEo1SURVS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBNE9Ub0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dOd29nSUNBZ1BBb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOW1iM0pBT1RFS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklESTFDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCbWIzSWdLR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURVS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRFVLSUNBZ0lHSWdiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEZzVDZ3B0WVdsdVgyRm1kR1Z5WDJadmNrQTVNVG9LSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK1Bnb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTVNd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTVORG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhOVE1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVFUwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QXdlREF3TURBS0lDQWdJR0oxY25rZ01qVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZFhKNUlEZ0tDbTFoYVc1ZmQyaHBiR1ZmZEc5d1FERTFOVG9LSUNBZ0lHUnBaeUEzQ2lBZ0lDQmthV2NnTndvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQXhOVGNLSUNBZ0lHUnBaeUF5TkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0o2WlhKdkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZMkZzYkhOMVlpQmZjbVZqWVd4amRXeGhkR1ZmYUdWaFpGOW1iM0pmWld4bGJXVnVkSE5mZDJsMGFGOWllWFJsWDJ4bGJtZDBhRjlvWldGa0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpZFhKNUlESTFDaUFnSUNCaUlHMWhhVzVmZDJocGJHVmZkRzl3UURFMU5Rb0tiV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQXhOVGM2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlkWEo1SURJekNpQWdJQ0JrYVdjZ01qUUtJQ0FnSUdKMWNua2dNVGNLQ20xaGFXNWZkMmhwYkdWZmRHOXdRREUxT0RvS0lDQWdJR1JwWnlBMkNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01qTUtJQ0FnSUdJK0NpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURFMk1Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREVLSUNBZ0lITjFZbk4wY21sdVp5QXdJRElLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2RYQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRnS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWlzS0lDQWdJR0oxY25rZ01qTUtJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBTVRVNENncHRZV2x1WDJGbWRHVnlYM2RvYVd4bFFERTJNRG9LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1pHbG5JREUzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhOVFFLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNU16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNU5Bb0tiV0ZwYmw5eVpXNXZkVzVqWlZCdmMybDBhVzl1VFdGdVlXZGxjbEp2YkdWZmNtOTFkR1ZBTVRFNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUE1T0FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUE1T1RvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnRQZDI1bGNnb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURFekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaVpXUXpOemhsT0NBdkx5QnRaWFJvYjJRZ0luSmxibTkxYm1ObFVHOXphWFJwYjI1TllXNWhaMlZ5VW05c1pTaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURrNE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURrNUNncHRZV2x1WDNCbGNtMXBkRkpsYzJWeWRtVlZibVJsY214NWFXNW5YM0p2ZFhSbFFERXdPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpnS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJM0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXpFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ013b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXdDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTRDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGtLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRBekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFd05Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdaR2xuSURFekNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdYMmx6VTNCdmEyVlNaV2RwYzNSbGNtVmtDaUFnSUNCaGMzTmxjblFnTHk4Z1UzQnZhMlZPYjNSU1pXZHBjM1JsY21Wa0NpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREkxTlFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdjSFZ6YUdsdWRDQXlOVFVLSUNBZ0lDWUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlPQW9nSUNBZ1kyRnNiSE4xWWlCZloyVjBVbVZ6WlhKMlpWVnVaR1Z5YkhscGJtY0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBek1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ016UUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmhPR1JrTURobUlDOHZJRzFsZEdodlpDQWljR1Z5YldsMEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWREWTBMR0o1ZEdWYk16SmRMR0o1ZEdWYk16SmRLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV3TXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TURRS0NtMWhhVzVmYzJWMFUyVnNaa0Z6VlhObGNsQnZjMmwwYVc5dVRXRnVZV2RsY2xkcGRHaFRhV2RmY205MWRHVkFPVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UTUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWRYSjVJRFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5T1FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE14Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UQTRDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXdPVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWkdsbklERXpDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDJselUzQnZhMlZTWldkcGMzUmxjbVZrQ2lBZ0lDQmhjM05sY25RZ0x5OGdVM0J2YTJWT2IzUlNaV2RwYzNSbGNtVmtDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklHSnZiMndnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1JwWnlBeE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF5SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklERTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFl5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBek1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNeklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFUzWlRsaE5HTTRJQzh2SUcxbGRHaHZaQ0FpYzJWMFZYTmxjbEJ2YzJsMGFXOXVUV0Z1WVdkbGNuTlhhWFJvVTJsbktDaDFhVzUwT0Zzek1sMHNLSFZwYm5RNFd6TXlYU3hpYjI5c0tWdGRMSFZwYm5ReU5UWXNkV2x1ZERJMU5pa3NZbmwwWlZ0ZEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXdPRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNRGtLQ20xaGFXNWZjbVZuYVhOMFpYSlRjRzlyWlY5eWIzVjBaVUE0T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWRYSjVJRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRFekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFeE5Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdZMkZzYkhOMVlpQmZZMmhsWTJ0UGQyNWxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklHSnZiMndnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdaR2xuSURFMENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUkJaR1J5WlhOekNpQWdJQ0JrZFhBS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0lsOXlaV2RwYzNSbGNtVmtVM0J2YTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdScFp5QXhNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoTVRrd016VTROaUF2THlCdFpYUm9iMlFnSWxOd2IydGxVbVZuYVhOMFpYSmxaQ2gxYVc1ME9Gc3pNbDBzWW05dmJDa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeE16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1UUUtDbTFoYVc1ZmNtVndZWGxQYmtKbGFHRnNaazltWDNKdmRYUmxRRGM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU9Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1URTRDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXhPVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWkdsbklERXpDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDJselUzQnZhMlZTWldkcGMzUmxjbVZrQ2lBZ0lDQmhjM05sY25RZ0x5OGdVM0J2YTJWT2IzUlNaV2RwYzNSbGNtVmtDaUFnSUNCa2FXY2dNekVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaUU5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZ3WVhsUGJrSmxhR0ZzWmsxaGVGVnBiblJPYjNSQmJHeHZkMlZrQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5T1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjluWlhSU1pYTmxjblpsVlc1a1pYSnNlV2x1WndvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURRMk56RmhaR0lnTHk4Z2JXVjBhRzlrSUNKblpYUlZjMlZ5Vkc5MFlXeEVaV0owS0hWcGJuUXlOVFlzWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREkyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaR2xuSURjS0lDQWdJR1JwWnlBeENpQWdJQ0JpUGdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVVlNRekl3TG5OaFptVlVjbUZ1YzJabGNrWnliMjBLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUlZKRE1qQXVabTl5WTJWQmNIQnliM1psQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaE4yWXlZemRsWWlBdkx5QnRaWFJvYjJRZ0luSmxjR0Y1S0hWcGJuUXlOVFlzZFdsdWRESTFOaXhoWkdSeVpYTnpLU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F6TWdvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElETTJJRE15Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCaWVtVnlid29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRnNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRFNUNncHRZV2x1WDNOMWNIQnNlVTl1UW1Wb1lXeG1UMlpmY205MWRHVkFOam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJNENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXpJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qTUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1USTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJmYVhOVGNHOXJaVkpsWjJsemRHVnlaV1FLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRjRzlyWlU1dmRGSmxaMmx6ZEdWeVpXUUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESTRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRkpsYzJWeWRtVlZibVJsY214NWFXNW5DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWkdsbklESUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUnBaeUF6TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRlVrTXlNQzV6WVdabFZISmhibk5tWlhKR2NtOXRDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVVZTUXpJd0xtWnZjbU5sUVhCd2NtOTJaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREF4TlRJell6RWdMeThnYldWMGFHOWtJQ0p6ZFhCd2JIa29kV2x1ZERJMU5peDFhVzUwTWpVMkxHRmtaSEpsYzNNcEtIVnBiblF5TlRZc2RXbHVkREkxTmlraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNeklLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBek5pQXpNZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR0o4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEl6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV5TkFvS2JXRnBibDlmWDNCdmMzUkpibWwwWDNKdmRYUmxRRFU2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbDlmWTNSdmNsOXdaVzVrYVc1bklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCZlgzQnZjM1JKYm1sMElHRnNjbVZoWkhrZ1kyRnNiR1ZrQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0lsOXlaV2RwYzNSbGNtVmtVM0J2YTJWeklnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOXZkMjVsY2lJS0lDQWdJR0o1ZEdWalh6SWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDNCbGJtUnBibWRQZDI1bGNpSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lsOWpZV05vWldSVWFHbHpJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbDlqWVdOb1pXUkRhR0ZwYmtsa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmZZMkZqYUdWa1RtRnRaVWhoYzJnaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSmZZMkZqYUdWa1ZtVnljMmx2YmtoaGMyZ2lDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbDlqWVdOb1pXUkViMjFoYVc1VFpYQmhjbUYwYjNJaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1BUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQZDI1aFlteGxTVzUyWVd4cFpFOTNibVZ5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOTBjbUZ1YzJabGNrOTNibVZ5YzJocGNBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdKNWRHVmpJREl3SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKZlkyRmphR1ZrVkdocGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmZZMkZqYUdWa1EyaGhhVzVKWkNJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmZZMkZqYUdWa1RtRnRaVWhoYzJnaUNpQWdJQ0JpZVhSbFl5QXlNU0F2THlBd2VHTXlNV1E1T0RobVl6aGtPVGszT1dZd01EaGlaVEEyWmpZelpHTXpOemRtWkRVNFl6VTNNMll6TlRReU16QXdPR1JtTVRVMVpqVTFZVFF3TnpOa1lXRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlYMk5oWTJobFpGWmxjbk5wYjI1SVlYTm9JZ29nSUNBZ1lubDBaV01nTWpJZ0x5OGdNSGhqT0RsbFptUmhZVFUwWXpCbU1qQmpOMkZrWmpZeE1qZzRNbVJtTURrMU1HWTFZVGsxTVRZek4yVXdNekEzWTJSallqUmpOamN5WmpJNU9HSTRZbU0yQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdiRzloWkNBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0JrZFhBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklERUtJQ0FnSUdKNWRHVmpJREU0SUM4dklEQjRPR0kzTTJNell6WTVZbUk0Wm1VelpEVXhNbVZqWXpSalpqYzFPV05qTnpreU16bG1OMkl4TnpsaU1HWm1ZV05oWVRsaE56VmtOVEl5WWpNNU5EQXdaZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBeUNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VESXdDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o1ZEdWaklESXhJQzh2SURCNFl6SXhaRGs0T0daak9HUTVPVGM1WmpBd09HSmxNRFptTmpOa1l6TTNOMlprTlRoak5UY3paak0xTkRJek1EQTRaR1l4TlRWbU5UVmhOREEzTTJSaFlRb2dJQ0FnY21Wd2JHRmpaVE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVYUmxZeUF5TWlBdkx5QXdlR000T1dWbVpHRmhOVFJqTUdZeU1HTTNZV1JtTmpFeU9EZ3laR1l3T1RVd1pqVmhPVFV4TmpNM1pUQXpNRGRqWkdOaU5HTTJOekptTWprNFlqaGlZellLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qQUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeENpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklETUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElERTJNQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVgyTmhZMmhsWkVSdmJXRnBibE5sY0dGeVlYUnZjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdYM0IxZVdGZmJHbGlMbUZ5WXpRdVgzSmxZMkZzWTNWc1lYUmxYMmhsWVdSZlptOXlYMlZzWlcxbGJuUnpYM2RwZEdoZllubDBaVjlzWlc1bmRHaGZhR1ZoWkNoaGNuSmhlVjlvWldGa1gyRnVaRjkwWVdsc09pQmllWFJsY3l3Z2JHVnVaM1JvT2lCMWFXNTBOalFzSUhOMFlYSjBYMkYwWDJsdVpHVjRPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0tnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0tnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSE4zWVhBS0NsOXlaV05oYkdOMWJHRjBaVjlvWldGa1gyWnZjbDlsYkdWdFpXNTBjMTkzYVhSb1gySjVkR1ZmYkdWdVozUm9YMmhsWVdSZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0E4Q2lBZ0lDQmllaUJmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtYMkZtZEdWeVgyWnZja0EwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpSUY5eVpXTmhiR04xYkdGMFpWOW9aV0ZrWDJadmNsOWxiR1Z0Wlc1MGMxOTNhWFJvWDJKNWRHVmZiR1Z1WjNSb1gyaGxZV1JmWm05eVgyaGxZV1JsY2tBeENncGZjbVZqWVd4amRXeGhkR1ZmYUdWaFpGOW1iM0pmWld4bGJXVnVkSE5mZDJsMGFGOWllWFJsWDJ4bGJtZDBhRjlvWldGa1gyRm1kR1Z5WDJadmNrQTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZSMmwyWlhKUWIzTnBkR2x2YmsxaGJtRm5aWEl1YzI5c0xrRmtaSEpsYzNNdWMyVnVaRlpoYkhWbEtISmxZMmx3YVdWdWREb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q2tGa1pISmxjM011YzJWdVpGWmhiSFZsT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUkNZV3hoYm1ObENpQWdJQ0J3YjNBS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZandLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUkNZV3hoYm1ObENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpSWdvZ0lDQWdZMkZzYkhOMVlpQk1iM2RNWlhabGJFTmhiR3d1WTJGc2JFNXZVbVYwZFhKdUNpQWdJQ0JpZWlCQlpHUnlaWE56TG5ObGJtUldZV3gxWlY5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnY21WMGMzVmlDZ3BCWkdSeVpYTnpMbk5sYm1SV1lXeDFaVjlsYkhObFgySnZaSGxBTkRvS0lDQWdJR05oYkd4emRXSWdURzkzVEdWMlpXeERZV3hzTG5KbGRIVnlia1JoZEdGVGFYcGxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWVhOelpYSjBJQzh2SUVaaGFXeGxaRU5oYkd3S0lDQWdJR0lnVEc5M1RHVjJaV3hEWVd4c0xtSjFZbUpzWlZKbGRtVnlkQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZSMmwyWlhKUWIzTnBkR2x2YmsxaGJtRm5aWEl1YzI5c0xreHZkMHhsZG1Wc1EyRnNiQzVqWVd4c1RtOVNaWFIxY200b015a29kR0Z5WjJWME9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncE1iM2RNWlhabGJFTmhiR3d1WTJGc2JFNXZVbVYwZFhKdU9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZURJd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjBiM0psSURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBkcGRtVnlVRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlWTnBlbVVvS1NBdFBpQmllWFJsY3pvS1RHOTNUR1YyWld4RFlXeHNMbkpsZEhWeWJrUmhkR0ZUYVhwbE9nb2dJQ0FnYkc5aFpDQXdDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBkcGRtVnlVRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVNYjNkTVpYWmxiRU5oYkd3dVluVmlZbXhsVW1WMlpYSjBLREFwS0NrZ0xUNGdkbTlwWkRvS1RHOTNUR1YyWld4RFlXeHNMbUoxWW1Kc1pWSmxkbVZ5ZERvS0lDQWdJR1Z5Y2lBdkx5QnlaWFpsY25RS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBkcGRtVnlVRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVUWVdabFJWSkRNakF1YzJGbVpWUnlZVzV6Wm1WeUtIUnZhMlZ1T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbE5oWm1WRlVrTXlNQzV6WVdabFZISmhibk5tWlhJNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRlVrTXlNQzVmYzJGbVpWUnlZVzV6Wm1WeUNpQWdJQ0JoYzNObGNuUWdMeThnVTJGbVpVVlNRekl3Um1GcGJHVmtUM0JsY21GMGFXOXVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMGRwZG1WeVVHOXphWFJwYjI1TllXNWhaMlZ5TG5OdmJDNVRZV1psUlZKRE1qQXVjMkZtWlZSeVlXNXpabVZ5Um5KdmJTaDBiMnRsYmpvZ1lubDBaWE1zSUdaeWIyMDZJR0o1ZEdWekxDQjBiem9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1UyRm1aVVZTUXpJd0xuTmhabVZVY21GdWMyWmxja1p5YjIwNkNpQWdJQ0J3Y205MGJ5QTBJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR05oYkd4emRXSWdVMkZtWlVWU1F6SXdMbDl6WVdabFZISmhibk5tWlhKR2NtOXRDaUFnSUNCaGMzTmxjblFnTHk4Z1UyRm1aVVZTUXpJd1JtRnBiR1ZrVDNCbGNtRjBhVzl1Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBkcGRtVnlVRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVUWVdabFJWSkRNakF1Wm05eVkyVkJjSEJ5YjNabEtIUnZhMlZ1T2lCaWVYUmxjeXdnYzNCbGJtUmxjam9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1UyRm1aVVZTUXpJd0xtWnZjbU5sUVhCd2NtOTJaVG9LSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVVZTUXpJd0xsOXpZV1psUVhCd2NtOTJaUW9nSUNBZ1ltNTZJRk5oWm1WRlVrTXlNQzVtYjNKalpVRndjSEp2ZG1WZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVVZTUXpJd0xsOXpZV1psUVhCd2NtOTJaUW9nSUNBZ1lYTnpaWEowSUM4dklGTmhabVZGVWtNeU1FWmhhV3hsWkU5d1pYSmhkR2x2YmdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVVlNRekl3TGw5ellXWmxRWEJ3Y205MlpRb2dJQ0FnWVhOelpYSjBJQzh2SUZOaFptVkZVa015TUVaaGFXeGxaRTl3WlhKaGRHbHZiZ29LVTJGbVpVVlNRekl3TG1admNtTmxRWEJ3Y205MlpWOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwZHBkbVZ5VUc5emFYUnBiMjVOWVc1aFoyVnlMbk52YkM1VFlXWmxSVkpETWpBdVgzTmhabVZVY21GdWMyWmxjaWgwYjJ0bGJqb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6TENCaWRXSmliR1U2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwVFlXWmxSVkpETWpBdVgzTmhabVZVY21GdWMyWmxjam9LSUNBZ0lIQnliM1J2SURRZ01Rb2dJQ0FnYkc5aFpDQXdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTmpRZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoT1RBMU9XTmlZakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRJZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJRE0yQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTJPQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFS0lDQWdJR0k5UFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpSmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmllaUJUWVdabFJWSkRNakF1WDNOaFptVlVjbUZ1YzJabGNsOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaWFpsY25RS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LQ2xOaFptVkZVa015TUM1ZmMyRm1aVlJ5WVc1elptVnlYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZSMmwyWlhKUWIzTnBkR2x2YmsxaGJtRm5aWEl1YzI5c0xsTmhabVZGVWtNeU1DNWZjMkZtWlZSeVlXNXpabVZ5Um5KdmJTaDBiMnRsYmpvZ1lubDBaWE1zSUdaeWIyMDZJR0o1ZEdWekxDQjBiem9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3l3Z1luVmlZbXhsT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1UyRm1aVVZTUXpJd0xsOXpZV1psVkhKaGJuTm1aWEpHY205dE9nb2dJQ0FnY0hKdmRHOGdOU0F4Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESXpZamczTW1Sa01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNaUEwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjbVZ3YkdGalpUSWdNellLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTWlBMk9Bb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTVRBd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNUW9nSUNBZ1lqMDlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREVLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBUMEtJQ0FnSUdKNklGTmhabVZGVWtNeU1DNWZjMkZtWlZSeVlXNXpabVZ5Um5KdmJWOWhablJsY2w5cFpsOWxiSE5sUURFMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUpnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdjbVYyWlhKMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F6Q2dwVFlXWmxSVkpETWpBdVgzTmhabVZVY21GdWMyWmxja1p5YjIxZllXWjBaWEpmYVdaZlpXeHpaVUF4TkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNaUE1TmdvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5SGFYWmxjbEJ2YzJsMGFXOXVUV0Z1WVdkbGNpNXpiMnd1VTJGbVpVVlNRekl3TGw5ellXWmxRWEJ3Y205MlpTaDBiMnRsYmpvZ1lubDBaWE1zSUhOd1pXNWtaWEk2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNc0lHSjFZbUpzWlRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNsTmhabVZGVWtNeU1DNWZjMkZtWlVGd2NISnZkbVU2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURrMVpXRTNZak13TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUF6TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOamdLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeENpQWdJQ0JpUFQwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nVTJGbVpVVlNRekl3TGw5ellXWmxRWEJ3Y205MlpWOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaWFpsY25RS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LQ2xOaFptVkZVa015TUM1ZmMyRm1aVUZ3Y0hKdmRtVmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUhhWFpsY2xCdmMybDBhVzl1VFdGdVlXZGxjaTV6YjJ3dVIybDJaWEpRYjNOcGRHbHZiazFoYm1GblpYSXVYMmx6VTNCdmEyVlNaV2RwYzNSbGNtVmtLSE53YjJ0bE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGZhWE5UY0c5clpWSmxaMmx6ZEdWeVpXUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaVgzSmxaMmx6ZEdWeVpXUlRjRzlyWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OUhhWFpsY2xCdmMybDBhVzl1VFdGdVlXZGxjaTV6YjJ3dVIybDJaWEpRYjNOcGRHbHZiazFoYm1GblpYSXVYMmRsZEZKbGMyVnlkbVZWYm1SbGNteDVhVzVuS0hOd2IydGxPaUJpZVhSbGN5d2djbVZ6WlhKMlpVbGtPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbDluWlhSU1pYTmxjblpsVlc1a1pYSnNlV2x1WnpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0dVek5XWm1OMlVnTHk4Z2JXVjBhRzlrSUNKblpYUlNaWE5sY25abEtIVnBiblF5TlRZcEtIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERFMkxIVnBiblE0TEhWcGJuUXlOQ3gxYVc1ME9DeDFhVzUwTXpJcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNeklLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UjJsMlpYSlFiM05wZEdsdmJrMWhibUZuWlhJdWMyOXNMa2RwZG1WeVVHOXphWFJwYjI1TllXNWhaMlZ5TGw5amFHVmphMUpsYzJOMVpVZDFZWEprYVdGdUtDa2dMVDRnZG05cFpEb0tYMk5vWldOclVtVnpZM1ZsUjNWaGNtUnBZVzQ2Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUc5M2JtVnlDaUFnSUNBOVBRb2dJQ0FnWW01NklGOWphR1ZqYTFKbGMyTjFaVWQxWVhKa2FXRnVYMkp2YjJ4ZmRISjFaVUF5Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCaWVtVnlid29nSUNBZ1oyeHZZbUZzSUVOaGJHeGxja0Z3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTJGc2JITjFZaUJ2ZDI1bGNnb2dJQ0FnUFQwS0lDQWdJR0o2SUY5amFHVmphMUpsYzJOMVpVZDFZWEprYVdGdVgySnZiMnhmWm1Gc2MyVkFNd29LWDJOb1pXTnJVbVZ6WTNWbFIzVmhjbVJwWVc1ZlltOXZiRjkwY25WbFFESTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb0tYMk5vWldOclVtVnpZM1ZsUjNWaGNtUnBZVzVmWW05dmJGOXRaWEpuWlVBME9nb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIbFNaWE5qZFdWSGRXRnlaR2xoYmdvZ0lDQWdjbVYwYzNWaUNncGZZMmhsWTJ0U1pYTmpkV1ZIZFdGeVpHbGhibDlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJmWTJobFkydFNaWE5qZFdWSGRXRnlaR2xoYmw5aWIyOXNYMjFsY21kbFFEUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwZHBkbVZ5VUc5emFYUnBiMjVOWVc1aFoyVnlMbk52YkM1SGFYWmxjbEJ2YzJsMGFXOXVUV0Z1WVdkbGNpNXdaVzVrYVc1blQzZHVaWElvS1NBdFBpQmllWFJsY3pvS2NHVnVaR2x1WjA5M2JtVnlPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJSEJsYm1ScGJtZFBkMjVsY2w5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHdaVzVrYVc1blQzZHVaWEpmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDNCbGJtUnBibWRQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gzQmxibVJwYm1kUGQyNWxjaUJsZUdsemRITUtJQ0FnSUhKbGRITjFZZ29LY0dWdVpHbHVaMDkzYm1WeVgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJSEJsYm1ScGJtZFBkMjVsY2w5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMGRwZG1WeVVHOXphWFJwYjI1TllXNWhaMlZ5TG5OdmJDNUhhWFpsY2xCdmMybDBhVzl1VFdGdVlXZGxjaTVmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEFvYm1WM1QzZHVaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmZEhKaGJuTm1aWEpQZDI1bGNuTm9hWEE2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKZmNHVnVaR2x1WjA5M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRjl3Wlc1a2FXNW5UM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pmY0dWdVpHbHVaMDkzYm1WeUlnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVgyOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKZmIzZHVaWElpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpJMk5qaG1ZMk1nTHk4Z2JXVjBhRzlrSUNKUGQyNWxjbk5vYVhCVWNtRnVjMlpsY25KbFpDaDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBkcGRtVnlVRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVIYVhabGNsQnZjMmwwYVc5dVRXRnVZV2RsY2k1dmQyNWxjaWdwSUMwK0lHSjVkR1Z6T2dwdmQyNWxjam9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ2ZDI1bGNsOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B2ZDI1bGNsOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmZiM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5dmQyNWxjaUJsZUdsemRITUtJQ0FnSUhKbGRITjFZZ29LYjNkdVpYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYjNkdVpYSmZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5SGFYWmxjbEJ2YzJsMGFXOXVUV0Z1WVdkbGNpNXpiMnd1UjJsMlpYSlFiM05wZEdsdmJrMWhibUZuWlhJdVgyTm9aV05yVDNkdVpYSW9LU0F0UGlCMmIybGtPZ3BmWTJobFkydFBkMjVsY2pvS0lDQWdJR05oYkd4emRXSWdiM2R1WlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDRTlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDNkdVlXSnNaVlZ1WVhWMGFHOXlhWHBsWkVGalkyOTFiblFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwZHBkbVZ5VUc5emFYUnBiMjVOWVc1aFoyVnlMbk52YkM1SGFYWmxjbEJ2YzJsMGFXOXVUV0Z1WVdkbGNpNWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFSUFBQkNDWVhBQUVCSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQlVmZkhVaEFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRFY5d1pXNWthVzVuVDNkdVpYSUdYMjkzYm1WeURsOWZZM1J2Y2w5d1pXNWthVzVuRmw5allXTm9aV1JFYjIxaGFXNVRaWEJoY21GMGIzSU9YMk5oWTJobFpFTm9ZV2x1U1dRTFgyTmhZMmhsWkZSb2FYTVBYMk5oWTJobFpFNWhiV1ZJWVhOb0VsOWpZV05vWldSV1pYSnphVzl1U0dGemFBRWdBZ0FBRVY5eVpXZHBjM1JsY21Wa1UzQnZhMlZ6QjE5dWIyNWpaWE1nQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJBQUFBQUFBQUFBQWdpM1BEeHB1NC9qMVJMc3hNOTFuTWVTT2ZleGViRC9yS3FhZGRVaXM1UUE4Z0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVVLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy84Z3doMllqOGpabDU4QWkrQnZZOXczZjlXTVZ6ODFRakFJM3hWZlZhUUhQYW9neUo3OXFsVEE4Z3g2MzJFb2d0OEpVUFdwVVdOK0F3Zk55MHhuTHltTGk4WWpSeFlvUndlQmdDQ3ZTVFVGTlFBMEFJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlCY1FEVUFNUmhBQUFZbkJ5Um5KRU14R1JSRU1SaEVnaFVFbVE4d3JnUzdtMC9wQkRIYWxvWUV1QytpbUFTQnFVUXpCSGNBVFlNRXJETHh5UVFFa1pvbUJEWFMrQlFFZXJtTVh3UWIyeENZQk94cUp0OEV2UXVPUmdUSWF4Z3lCTmJXaFpNRVMrdjVHd1RWclVVV0JPRjdyN1FFMVNIV0JBU3h1N0NvQkQ0c1llVTJHZ0NPRlFpMkIvOEc4UWFnQmRFRkJRUzhBNGtEWEFNZkF1NEMxQUhlQVQwQTN3Q0RBSG9BUkFBa0FCc0FBUUF4RmtFQUVURVdKQWs0Q0JSRWlBeTdLb2dNZXlSREkwTC84WWdNbHl0TVVMQWtRekVXUVFBWE1SWWtDVGdJRkVReEFJZ01RMHNCRXhSRWlBeFNKRU1qUXYvck5ob0JTVVVYRlNJU1JERVdRUUFqTVJZa0NUZ0lGRVNJREc0bkJVc1dTVTRDWjRnTVRFeFFnQVNPV25tSFRGQ3dKRU1qUXYvZmlBdjhLMHhRc0NSRE5ob0JTVVVWRlNJU1JEWWFBa2xGSGhXQkdCSkVNUlpCQUQ0eEZpUUpPQWdVUkNLdlNVc2VTVTRDVUVrVklna2lXRXNXVEZBQkp4Qk1VTDVNRnlOTVR3Sk5UQ2NSb3ljRXFrd1dxMGtWSWc1RXF5dE1VTEFrUXlOQy84UTJHZ0ZKUlI0VmdSZ1NSREVXUVFCS01SWWtDVGdJRkVReEFDS3ZTVXNmU1U0RFVFa1ZJZ2tpV0U4RFRGQUJKeEJNVUVtK1RCY2pURThDVFVra0NCWlBBa3kvVHdJbkVhTW5CS3BNRnF0SkZTSU9SS3NyVEZDd0pFTWpRdis0TVJaQkFKZ3hGaVFKT0FnVVJJQkZEd0NIQUowQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQk1ncFFnRDBBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2dBQlJIYVhabGNsQnZjMmwwYVc5dVRXRnVZV2RsY2dBQk1RQUFVQ3RNVUxBa1F5TkMvMm94RmtFQTdURVdKQWs0Q0JSRUl5Y0laVXhGRVVRakp3bGxSQ01uQ21WRU5BQXBUd09vS0NsUEFrMHlDazhEcUNncFR3Sk5yQ2lvVERVQVFRQ3VJeWNMWlVRakp3eGxSRFFBSmE5TEFWZEFJRXBRU1JVbENWc2lyMDhFU3dJbkVsMUxBeWNOb0NjRXFrc0ZURkJKRlNVSlcwc0NUd2hRU1JVaUNTSllYVXNEZ0FGQW9DY0Vxa3NGVEZCSkZTVUpXMHNDVHdkUVNSVWlDU0pZWFVzRGdBRmdvQ2NFcWtzRlRGQkpGU1VKV3ljVFhVOERnQUdBb0NjRXFrOEVURkJKRlNVSlcwc0NNZ3BRU3dNeUNsQVZJZ2tpV0YxSlR3T0JvQUZZQWs4Q1RGQkpGU0lKSWxoWEFDQkZFVFVBSzBzUVVMQWtReU5DL3hVeEZrRUFFVEVXSkFrNENCUkVpQW5SSzB4UXNDUkRJMEwvOFRZYUFVbEZEQlVpRWtRMkdnSkpSU0FWSWhKRU1SWkJBQlF4RmlRSk9BZ1VSSWdKU1VzS1N4K0lCdFlrUXlOQy8rNDJHZ0ZKUlFzVkloSkVOaG9DU1VVTUZTSVNSRFlhQTBsRklCVWlFa1F4RmtFQUZqRVdKQWs0Q0JSRWlBa09Td2xMQzBzZ2lBYnZKRU1qUXYvc05ob0JTVVVQRlNJU1JERVdRUUFhTVJZa0NUZ0lGRVJMRFlnSW40QUJBQ05QQWxRclRGQ3dKRU1qUXYvb05ob0JTU05aU1VVSmdRSUxSUVZKRlVVQ1Z3SUFSUmdqUlFWTEJFc0hERUVBSjBzRVNZRUNDMHNaU1U4Q1dVbExCMGxPQkJKRVN3RVZVaU5aZ1FJSUNFVUZKQWhGQlVMLzBVc0RnUUlJU3dFU1JERVdRUURZTVJZa0NUZ0lGRVF4RmtFQXh6RVdKQWs0Q0JSRUp3NUZHU05GQ0VzSFN3Y01RUUEvU3hoSkkxbEpnUUlMZ1FJSVN3S0JBa3NDVW9FQ3IxQkxBeFZQQkU4RFR3SlNKdzVRVUV3a0NFa1dWd1lBVGdJamlBVnNVRXNJSkFoRkNVVVpRdis1S0VVWFN4aEZFVXNHRmtzWHBVRUFXalFBTlFBbHIwc1hTVTRDVUVrVkpRbGJTeEpKVGdJaldVc0JEVVJMQVZFQUFra1hUd05YQWdCTEE0RUNDMHNCVEZsS1dVc0JDSUVDQ0VzQ0kwOERVaWNPVUVzQ0ZVeE9BMUpRVEU4RGlBVUFVRVVTS2FCRkYwTC9uU3RMRVZDd0pFTWpRdjg3STBML0tqWWFBVWxGRHhVaUVrUTJHZ0pKUlFvVkloSkVNUlpCQUN3eEZpUUpPQWdVUklnSDdMRkxEWUVZVzRFR3NoQWpzaGtqc2dHeUdJQUV2dE40NkxJYVN3aXlHck1rUXlOQy85WTJHZ0ZKUlE4VkloSkVOaG9DU1VVY0ZTSVNSRFlhQTBsRkZoVWlFa1EyR2dSSlJSc1ZJaEpFTmhvRlNVVWZGU0lTUkRZYUJra1ZKUkpFRjBVRE5ob0hTVVVVRlNJU1JEWWFDRWxGRXhVaUVrUXhGa0VBY2pFV0pBazRDQlJFU3cxSmlBYXVSRXNEU1lIL0FRNUVnZjhCR2t4TEhJZ0dyckV5Q2lLdlNVc2VVRWtWSWdraVdFeExJbEJKRlNJSklsaFBCQlpQQklFWVc0RUdzaEFqc2hranNnR3lHSUFFU28zUWo3SWFTeGl5R2s4RHNocFBBcklhVExJYXNocExFcklhU3hHeUdyTWtReU5DLzVBMkdnRkpSUThWSWhKRU5ob0NTVVVPRlNJU1JEWWFBMGxGRFVrVkpCSkVJMU5GQmpZYUJFbEZIUlVpRWtRMkdnVkpSUjhWSWhKRU5ob0dTU05aZ1FJSVN3RVZFa1JYQWdCRkR6RVdRUUI4TVJZa0NUZ0lGRVJMRFVtSUJlbEVTd1lrRGtReUNrc05VSUFqQUFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJNWEFLeFN3NkFBZ0JpVUVzZVVFc2dVRXhRU3hCSkZSWlhCZ0pNVUU4Q2dSaGJnUWF5RUNPeUdTT3lBYklZZ0FSWDZhVElzaHBNc2hxeUdyTWtReU5DLzRZMkdnRkpSUThWSWhKRU5ob0NTVVVPU1JVa0VrUWpVMFVDTVJaQkFDOHhGaVFKT0FnVVJJZ0dBMHNCU1NRT1JFc09TU29UUkVrQkp3OU1VRThDRnI5TERWQ0FCS0dRTllaTVVMQWtReU5DLzlNMkdnRkpSUThWSWhKRU5ob0NTVVVjRlNJU1JEWWFBMGxGSUJVaUVrUTJHZ1JKUlJZVkloSkVNUlpCQU4weEZpUUpPQWdVUkVzTlNZZ0U2MFJMSDBsT0FvQWcvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8rcFJFbExIVWxPQW9nRXk3RWlyMGxQQTFCSkZTSUpJbGhMQTRFWVc0RUdzaEFqc2hranNnRkpzaGlBQkFSbkd0dXlHa3NCc2hwTEdrbE9CcklhczdRK1Z3UUFTd2RMQWFWUENFNENUVEVBTWdwTEJrNENTd09JQXFaUEJFOEZTd0tJQXE2eFR3Tk1VRWtWSWdraVdJRUdzaEFqc2hranNnRk1zaGlBQktmeXgrdXlHa3l5R3JJYXNocXp0RDVYQkNDMFBsY2tJSUZBcjA4Q1N3R3JUZ0tyVUN0TVVMQWtReU5DL3lVMkdnRkpSUThWSWhKRU5ob0NTVVVjRlNJU1JEWWFBMGxGSUJVaUVrUTJHZ1JKUlJZVkloSkVNUlpCQUlZeEZpUUpPQWdVUkVzTlNZZ0QzVVJKU3h4SlRnT0lBK1l4QURJS1N3Sk9Ba3NrU1U0RWlBSUFURXNDU3dLSUFnbXhJcTlKVHdSUVNSVWlDU0pZVEU4Q1VFa1ZJZ2tpV0U4Q2dSaGJnUWF5RUNPeUdTT3lBYklZZ0FTQUZTUEJzaHBNc2hxeUdrc1VzaHF6dEQ1WEJDQzBQbGNrSUlGQXIwOENTd0dyVGdLclVDdE1VTEFrUXlOQy8zdzJHZ0ZKRlNJU1JDY0haRVFuQnlObkp3K0JBcmxJSndZcVp5Y0ZLbWNuQ2lobkp3a29aeWNMS21jbkRDcG5Kd2dxWnlLdlN3RXFFaFJFVElnRG5ESUtKeFNzSnhTc0p3cE1aeWNKS1djbkN5Y1ZaeWNNSnhabk5BQWxyMHNCVjBBZ1NsQkpGU1VKVzA4RFN3RW5FbDFMQWljTm9DY0Vxa3NFVEZCSkZTVUpXeWNWWFVzQ2dBRkFvQ2NFcWtzRVRGQkpGU1VKV3ljV1hVc0NnQUZnb0NjRXFrc0VURkJKRlNVSld5Y1RYVThDZ0FHQW9DY0VxazhEVEZCSkZTVUpXMHNETWdwUVN3UXlDbEFWSWdraVdGMUpUd0tCb0FGWUFrOENURkJKRlNJSklsaFhBQ0JNTlFBbkNFeG5KRU9LQXdHTC9vRUNDMG1MLzRFQ0M0djlTd0ZaVHdKTWkvOU5USXNDaXdBTVFRQWxpd0ZKRmxjR0FJdjlpd0pKVGdSUEFsMUpqUDFMQVZtQkFnZ0lqQUdCQWdpTUFrTC8wNHY5akFDSmlnSUFNZ3B6QUVnV2kvK2tGRVNML292L0tJZ0FEVUVBQVltSUFESW9wVVJDQURLS0F3RTBBQ1d2aS84bkRhQW5CS3BMQVV4UVNSVWxDVnRNaS85UVNSVWxDVnRMQWs0Q1dGd0FOUUFraVRRQU5RQW9pUUNLQXdDTC9ZditpLzhraUFBOFJJbUtCQUNML0l2OWkvNkwveVNJQUt4RWlZb0RBSXY5aS82TC95T0lBU1JBQUJnakZvdjlpLzVQQWlTSUFSVkVpLzJML292L0pJZ0JDa1NKaWdRQk5BQkpWMEFnVENLdlNVOENnQ0NwQlp5N0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFGd0FLbHdFVEl2K1VFa1ZJZ2tpV0Z3a1NWY0FSRndBU1NSTVZ3QWdLYWdvS1U4Q1RTbXNLS2hCQUE0b0tZdi9UU2lzS0trVVJDU01BNHNCaXdCUVNSVWlDU0pZaXdKTVhFQTFBSXNEakFDSmlnVUJOQUJKVjBBZ1RDS3ZTVThDZ0NBanVITGRBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRndBS2x3RUtsd2tUSXYrVUVrVklna2lXRnhFU1ZjQVpGd0FTU1JNVndBZ0thZ29LVThDVFNtc0tLaEJBQTRvS1l2L1RTaXNLS2tVUkNTTUE0c0Jpd0JRU1JVaUNTSllpd0pNWEVBcVhHQTFBSXNEakFDSmlnUUJOQUJKVjBBZ1RDS3ZTVThDZ0NBSlhxZXpBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRndBS2x3RVRJditVRWtWSWdraVdGd2tTVmNBUkZ3QVNTUk1Wd0FnS2Fnb0tVOENUU21zS0toQkFBNG9LWXYvVFNpc0tLa1VSQ1NNQTRzQml3QlFTUlVpQ1NKWWl3Sk1YRUExQUlzRGpBQ0ppZ0VCaS84Qkp3OU1VTDVNRnlOTVR3Sk5pWW9DQWJFaXI0di9VRWtWSWdraVdJditnUmhiZ1FheUVDT3lHU095QWJJWWdBU09OZjkrc2hxeUdyTzBQbGNFSUlreEFJZ0FWUkpBQUE2QkdLOHlEUlpRaUFCSEVrRUFBeVJFaVNOQy8vb3hGa0VBRGpFV0pBazRDQlJFSXljRlpVU0pJMEwvOUlvQkFDTW5CV1ZGQVVRbkJTcG5JeWNHWlVRbkJvdi9aNHYvVUlBRVltYVB6RXhRc0lreEZrRUFEakVXSkFrNENCUkVJeWNHWlVTSkkwTC85SWovNWpFQUV4UkVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJTcG9rZVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0ZXJlZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJTdGFydGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
