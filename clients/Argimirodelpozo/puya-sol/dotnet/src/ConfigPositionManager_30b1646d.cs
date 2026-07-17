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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.ConfigPositionManager_30b1646d
{


    //
    // @title ConfigPositionManager
    // @author Aave Labs
    // @notice Position manager to handle position configuration actions on behalf of users.
    //
    public class ConfigPositionManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConfigPositionManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ConfigPermissionValues : AVMObjectType
            {
                public bool CanSetUsingAsCollateral { get; set; }

                public bool CanUpdateUserRiskPremium { get; set; }

                public bool CanUpdateUserDynamicConfig { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanSetUsingAsCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCanSetUsingAsCollateral.From(CanSetUsingAsCollateral);
                    ret.AddRange(vCanSetUsingAsCollateral.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserRiskPremium = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCanUpdateUserRiskPremium.From(CanUpdateUserRiskPremium);
                    ret.AddRange(vCanUpdateUserRiskPremium.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserDynamicConfig = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCanUpdateUserDynamicConfig.From(CanUpdateUserDynamicConfig);
                    ret.AddRange(vCanUpdateUserDynamicConfig.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ConfigPermissionValues Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ConfigPermissionValues();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanSetUsingAsCollateral = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCanSetUsingAsCollateral.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCanSetUsingAsCollateral = vCanSetUsingAsCollateral.ToValue();
                    if (valueCanSetUsingAsCollateral is bool vCanSetUsingAsCollateralValue) { ret.CanSetUsingAsCollateral = vCanSetUsingAsCollateralValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserRiskPremium = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCanUpdateUserRiskPremium.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCanUpdateUserRiskPremium = vCanUpdateUserRiskPremium.ToValue();
                    if (valueCanUpdateUserRiskPremium is bool vCanUpdateUserRiskPremiumValue) { ret.CanUpdateUserRiskPremium = vCanUpdateUserRiskPremiumValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanUpdateUserDynamicConfig = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCanUpdateUserDynamicConfig.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCanUpdateUserDynamicConfig = vCanUpdateUserDynamicConfig.ToValue();
                    if (valueCanUpdateUserDynamicConfig is bool vCanUpdateUserDynamicConfigValue) { ret.CanUpdateUserDynamicConfig = vCanUpdateUserDynamicConfigValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ConfigPermissionValues);
                }
                public bool Equals(ConfigPermissionValues? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ConfigPermissionValues left, ConfigPermissionValues right)
                {
                    return EqualityComparer<ConfigPermissionValues>.Default.Equals(left, right);
                }
                public static bool operator !=(ConfigPermissionValues left, ConfigPermissionValues right)
                {
                    return !(left == right);
                }

            }

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

            public class ConfigPermissionsUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 31, 138, 245, 39 };
                public const string Signature = "ConfigPermissionsUpdated(uint8[32],uint8[32],uint8[32],uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Spoke { get; set; }
                public byte[] Delegator { get; set; }
                public byte[] Delegatee { get; set; }
                public ulong Permissions { get; set; }

                public static ConfigPermissionsUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ConfigPermissionsUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpoke = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpoke.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpoke = vSpoke.ToValue();
                    if (valueSpoke is byte[] vSpokeValue) { ret.Spoke = vSpokeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vDelegator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelegator = vDelegator.ToValue();
                    if (valueDelegator is byte[] vDelegatorValue) { ret.Delegator = vDelegatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegatee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vDelegatee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelegatee = vDelegatee.ToValue();
                    if (valueDelegatee is byte[] vDelegateeValue) { ret.Delegatee = vDelegateeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPermissions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPermissions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePermissions = vPermissions.ToValue();
                    if (valuePermissions is ulong vPermissionsValue) { ret.Permissions = vPermissionsValue; }
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
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegatee"> </param>
        /// <param name="permission"> </param>
        public async Task SetGlobalPermission(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 202, 102, 59 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGlobalPermission_Transactions(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 202, 102, 59 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegatee"> </param>
        /// <param name="permission"> </param>
        public async Task SetCanUpdateUsingAsCollateralPermission(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 69, 146, 66 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetCanUpdateUsingAsCollateralPermission_Transactions(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 69, 146, 66 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegatee"> </param>
        /// <param name="permission"> </param>
        public async Task SetCanUpdateUserRiskPremiumPermission(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 79, 94, 67 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetCanUpdateUserRiskPremiumPermission_Transactions(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 79, 94, 67 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegatee"> </param>
        /// <param name="permission"> </param>
        public async Task SetCanUpdateUserDynamicConfigPermission(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 41, 81, 94 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetCanUpdateUserDynamicConfigPermission_Transactions(Algorand.Address spoke, Algorand.Address delegatee, bool permission, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 41, 81, 94 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var permissionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); permissionAbi.From(permission);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegateeAbi, permissionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegator"> </param>
        public async Task RenounceGlobalPermission(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 83, 170, 188 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceGlobalPermission_Transactions(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 83, 170, 188 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegator"> </param>
        public async Task RenounceCanUpdateUsingAsCollateralPermission(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 247, 212, 179 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceCanUpdateUsingAsCollateralPermission_Transactions(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 247, 212, 179 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegator"> </param>
        public async Task RenounceCanUpdateUserRiskPremiumPermission(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 70, 54 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceCanUpdateUserRiskPremiumPermission_Transactions(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 70, 54 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegator"> </param>
        public async Task RenounceCanUpdateUserDynamicConfigPermission(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 214, 22, 210 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceCanUpdateUserDynamicConfigPermission_Transactions(Algorand.Address spoke, Algorand.Address delegator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 214, 22, 210 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="usingAsCollateral"> </param>
        /// <param name="onBehalfOf"> </param>
        public async Task SetUsingAsCollateralOnBehalfOf(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool usingAsCollateral, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 20, 200, 57 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var usingAsCollateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); usingAsCollateralAbi.From(usingAsCollateral);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, usingAsCollateralAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetUsingAsCollateralOnBehalfOf_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool usingAsCollateral, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 20, 200, 57 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var usingAsCollateralAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); usingAsCollateralAbi.From(usingAsCollateral);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, usingAsCollateralAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="onBehalfOf"> </param>
        public async Task UpdateUserRiskPremiumOnBehalfOf(Algorand.Address spoke, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 190, 228, 159 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateUserRiskPremiumOnBehalfOf_Transactions(Algorand.Address spoke, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 190, 228, 159 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="onBehalfOf"> </param>
        public async Task UpdateUserDynamicConfigOnBehalfOf(Algorand.Address spoke, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 144, 207, 14 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateUserDynamicConfigOnBehalfOf_Transactions(Algorand.Address spoke, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 144, 207, 14 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IConfigPositionManager
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="delegatee"> </param>
        /// <param name="onBehalfOf"> </param>
        public async Task<Structs.ConfigPermissionValues> GetConfigPermissions(Algorand.Address spoke, Algorand.Address delegatee, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 66, 101, 133 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            var result = await base.SimApp(new List<object> { abiHandle, spokeAbi, delegateeAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ConfigPermissionValues.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConfigPermissions_Transactions(Algorand.Address spoke, Algorand.Address delegatee, Algorand.Address onBehalfOf, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 66, 101, 133 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var delegateeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegateeAbi.From(delegatee);
            var onBehalfOfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); onBehalfOfAbi.From(onBehalfOf);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, delegateeAbi, onBehalfOfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 2;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uZmlnUG9zaXRpb25NYW5hZ2VyIiwiZGVzYyI6IkB0aXRsZSBDb25maWdQb3NpdGlvbk1hbmFnZXJcbiBAYXV0aG9yIEFhdmUgTGFic1xuIEBub3RpY2UgUG9zaXRpb24gbWFuYWdlciB0byBoYW5kbGUgcG9zaXRpb24gY29uZmlndXJhdGlvbiBhY3Rpb25zIG9uIGJlaGFsZiBvZiB1c2Vycy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ29uZmlnUGVybWlzc2lvblZhbHVlcyI6W3sibmFtZSI6ImNhblNldFVzaW5nQXNDb2xsYXRlcmFsIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJjYW5VcGRhdGVVc2VyUmlza1ByZW1pdW0iLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImNhblVwZGF0ZVVzZXJEeW5hbWljQ29uZmlnIiwidHlwZSI6ImJvb2wifV0sImVpcDcxMkRvbWFpblJldHVybiI6W3sibmFtZSI6ImZpZWxkcyIsInR5cGUiOiJieXRlWzFdIn0seyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ2ZXJzaW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImNoYWluSWQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InZlcmlmeWluZ0NvbnRyYWN0IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzYWx0IiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiZXh0ZW5zaW9ucyIsInR5cGUiOiJ1aW50MjU2W10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiX19wb3N0SW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbE93bmVyXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0R2xvYmFsUGVybWlzc2lvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQ29uZmlnUG9zaXRpb25NYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pc3Npb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbmZpZ1Blcm1pc3Npb25zVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRlZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pc3Npb25zIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Q2FuVXBkYXRlVXNpbmdBc0NvbGxhdGVyYWxQZXJtaXNzaW9uIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElDb25maWdQb3NpdGlvbk1hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdGVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWlzc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29uZmlnUGVybWlzc2lvbnNVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdGVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWlzc2lvbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRDYW5VcGRhdGVVc2VyUmlza1ByZW1pdW1QZXJtaXNzaW9uIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElDb25maWdQb3NpdGlvbk1hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdGVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWlzc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29uZmlnUGVybWlzc2lvbnNVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdGVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWlzc2lvbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRDYW5VcGRhdGVVc2VyRHluYW1pY0NvbmZpZ1Blcm1pc3Npb24iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUNvbmZpZ1Bvc2l0aW9uTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtaXNzaW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDb25maWdQZXJtaXNzaW9uc1VwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0ZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtaXNzaW9ucyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbm91bmNlR2xvYmFsUGVybWlzc2lvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQ29uZmlnUG9zaXRpb25NYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29uZmlnUGVybWlzc2lvbnNVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdGVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWlzc2lvbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW5vdW5jZUNhblVwZGF0ZVVzaW5nQXNDb2xsYXRlcmFsUGVybWlzc2lvbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQ29uZmlnUG9zaXRpb25NYW5hZ2VyIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29uZmlnUGVybWlzc2lvbnNVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdGVlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWlzc2lvbnMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW5vdW5jZUNhblVwZGF0ZVVzZXJSaXNrUHJlbWl1bVBlcm1pc3Npb24iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUNvbmZpZ1Bvc2l0aW9uTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbmZpZ1Blcm1pc3Npb25zVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRlZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pc3Npb25zIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VDYW5VcGRhdGVVc2VyRHluYW1pY0NvbmZpZ1Blcm1pc3Npb24iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUNvbmZpZ1Bvc2l0aW9uTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbmZpZ1Blcm1pc3Npb25zVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRlZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pc3Npb25zIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VXNpbmdBc0NvbGxhdGVyYWxPbkJlaGFsZk9mIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElDb25maWdQb3NpdGlvbk1hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3Jlc2VydmVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzaW5nQXNDb2xsYXRlcmFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGZPZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVVc2VyUmlza1ByZW1pdW1PbkJlaGFsZk9mIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElDb25maWdQb3NpdGlvbk1hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGZPZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVVc2VyRHluYW1pY0NvbmZpZ09uQmVoYWxmT2YiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUNvbmZpZ1Bvc2l0aW9uTWFuYWdlciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbkJlaGFsZk9mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENvbmZpZ1Blcm1pc3Npb25zIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElDb25maWdQb3NpdGlvbk1hbmFnZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdGVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib25CZWhhbGZPZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiQ29uZmlnUGVybWlzc2lvblZhbHVlcyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJTcG9rZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUG9zaXRpb25NYW5hZ2VyQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTcG9rZVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0ZXJlZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFNlbGZBc1VzZXJQb3NpdGlvbk1hbmFnZXJXaXRoU2lnIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElQb3NpdGlvbk1hbmFnZXJCYXNlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uQmVoYWxmT2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X25vbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2RlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGVybWl0UmVzZXJ2ZVVuZGVybHlpbmciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVBvc2l0aW9uTWFuYWdlckJhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3Jlc2VydmVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9uQmVoYWxmT2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfdmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfZGVhZGxpbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcm1pdFYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGVybWl0UiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtaXRTIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbm91bmNlUG9zaXRpb25NYW5hZ2VyUm9sZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUG9zaXRpb25NYW5hZ2VyQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11bHRpY2FsbCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTXVsdGljYWxsIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNTcG9rZVJlZ2lzdGVyZWQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVBvc2l0aW9uTWFuYWdlckJhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzY3VlVG9rZW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSVJlc2N1YWJsZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzY3VlTmF0aXZlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElSZXNjdWFibGUiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNjdWVHdWFyZGlhbiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJUmVzY3VhYmxlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiRE9NQUlOX1NFUEFSQVRPUiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJSW50ZW50Q29uc3VtZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWlwNzEyRG9tYWluIiwiZGVzYyI6IkBkZXYgU2VlOiBodHRwczovL2VpcHMuZXRoZXJldW0ub3JnL0VJUFMvZWlwLTUyNjciLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMV0sc3RyaW5nLHN0cmluZyx1aW50NTEyLGFkZHJlc3MsYnl0ZVszMl0sdWludDI1NltdKSIsInN0cnVjdCI6ImVpcDcxMkRvbWFpblJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXNlTm9uY2UiLCJkZXNjIjoiQGluaGVyaXRkb2MgSU5vbmNlc0tleWVkIiwiYXJncyI6W3sidHlwZSI6InVpbnQxOTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfa2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5vbmNlcyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTm9uY2VzS2V5ZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTkyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBlbmRpbmdPd25lciIsImRlc2MiOiIgQGRldiBSZXR1cm5zIHRoZSBhZGRyZXNzIG9mIHRoZSBwZW5kaW5nIG93bmVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyT3duZXJzaGlwIiwiZGVzYyI6IiBAZGV2IFN0YXJ0cyB0aGUgb3duZXJzaGlwIHRyYW5zZmVyIG9mIHRoZSBjb250cmFjdCB0byBhIG5ldyBhY2NvdW50LiBSZXBsYWNlcyB0aGUgcGVuZGluZyB0cmFuc2ZlciBpZiB0aGVyZSBpcyBvbmUuXG4gQ2FuIG9ubHkgYmUgY2FsbGVkIGJ5IHRoZSBjdXJyZW50IG93bmVyLlxuIFNldHRpbmcgYG5ld093bmVyYCB0byB0aGUgemVybyBhZGRyZXNzIGlzIGFsbG93ZWQ7IHRoaXMgY2FuIGJlIHVzZWQgdG8gY2FuY2VsIGFuIGluaXRpYXRlZCBvd25lcnNoaXAgdHJhbnNmZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJTdGFydGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFjY2VwdE93bmVyc2hpcCIsImRlc2MiOiIgQGRldiBUaGUgbmV3IG93bmVyIGFjY2VwdHMgdGhlIG93bmVyc2hpcCB0cmFuc2Zlci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im93bmVyIiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIGFkZHJlc3Mgb2YgdGhlIGN1cnJlbnQgb3duZXIuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VPd25lcnNoaXAiLCJkZXNjIjoiIEBkZXYgTGVhdmVzIHRoZSBjb250cmFjdCB3aXRob3V0IG93bmVyLiBJdCB3aWxsIG5vdCBiZSBwb3NzaWJsZSB0byBjYWxsXG4gYG9ubHlPd25lcmAgZnVuY3Rpb25zLiBDYW4gb25seSBiZSBjYWxsZWQgYnkgdGhlIGN1cnJlbnQgb3duZXIuXG4gTk9URTogUmVub3VuY2luZyBvd25lcnNoaXAgd2lsbCBsZWF2ZSB0aGUgY29udHJhY3Qgd2l0aG91dCBhbiBvd25lcixcbiB0aGVyZWJ5IGRpc2FibGluZyBhbnkgZnVuY3Rpb25hbGl0eSB0aGF0IGlzIG9ubHkgYXZhaWxhYmxlIHRvIHRoZSBvd25lci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZXZpb3VzT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6N30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjM1MiwyNTA3LDI4NzYsMzMxNCwzNDA4LDM1MDIsMzU5Nl0sImVycm9yTWVzc2FnZSI6IkFCSSBib29sIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTIwLDQzNzIsNDM4NV0sImVycm9yTWVzc2FnZSI6IkFCSSB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY4MiwyNzczLDI4OTRdLCJlcnJvck1lc3NhZ2UiOiJEZWxlZ2F0ZWVOb3RBbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk3N10sImVycm9yTWVzc2FnZSI6IkZhaWxlZENhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTU5XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50QmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MTNdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkQWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1MDRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5UmVzY3VlR3VhcmRpYW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjkxXSwiZXJyb3JNZXNzYWdlIjoiT3duYWJsZUludmFsaWRPd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4OSw0NjAwXSwiZXJyb3JNZXNzYWdlIjoiT3duYWJsZVVuYXV0aG9yaXplZEFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjI5XSwiZXJyb3JNZXNzYWdlIjoiU2FmZUVSQzIwRmFpbGVkT3BlcmF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExMywyMzQ3LDI2NjQsMjc1NSwyODY4LDI5OTEsMzA2NywzMTQzLDMyMTksMzMwNiwzNDAwLDM0OTQsMzU4OF0sImVycm9yTWVzc2FnZSI6IlNwb2tlTm90UmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NDFdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIzM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRDaGFpbklkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkRG9tYWluU2VwYXJhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkTmFtZUhhc2ggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRUaGlzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkVmVyc2lvbkhhc2ggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU1MSw0NTg3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX293bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1MjcsNDU0Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9wZW5kaW5nT3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM5Nl0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2Ml0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NDQsMTY5NiwyMzE1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI4NSwyNDgxLDI4MzQsMzI4MiwzMzc2LDM0NzAsMzU2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzE2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDgsODcxLDE0OTQsMTU0MywxNTUzLDE2MDQsMTk0OCwxOTU4LDIwMjEsMjA0MSwyMDgzLDIwOTMsMjI2NCwyMjc0LDI0NzAsMjU1MSwyNTYxLDI1NzEsMjYzNCwyNjQ0LDI3MjUsMjczNSwyODE2LDI4NDgsMjk2MSwyOTcxLDMwMzcsMzA0NywzMTEzLDMxMjMsMzE4OSwzMTk5LDMyNjQsMzI3NCwzMzU4LDMzNjgsMzQ1MiwzNDYyLDM1NDYsMzU1NiwzNjM3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4Miw5NjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MTkyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwNCwxNTYzLDIwMzEsMjA1MSwyMDYxLDIyOTksMjMwOSwyODI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50OFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0NCw3NzksODIxLDg5NSw5NzYsMTA1OCwxMjIwLDE0NzEsMTUxNywxNTc2LDE2MTcsMTcyOSwxNzQyLDE5NzEsMjEwNiwyMzQwLDI0OTgsMjU4NCwyNjU3LDI3NDgsMjg2MSwyOTg0LDMwNjAsMzEzNiwzMjEyLDMyOTksMzM5MywzNDg3LDM1ODEsNDUyMiw0NTgyXSwiZXJyb3JNZXNzYWdlIjoibm90IHBheWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDEsMTAzNF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIxNSw0MzM3XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBOdmJtWnBaMUJ2YzJsMGFXOXVUV0Z1WVdkbGNpNXpiMnd1UTI5dVptbG5VRzl6YVhScGIyNU5ZVzVoWjJWeUxtRndjSEp2ZG1Gc1gzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lETXlJRElnTWpVMUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNElEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQXdlREUxTVdZM1l6YzFJREI0TURFZ0lsOXdaVzVrYVc1blQzZHVaWElpSURCNE1EQWdJbDl2ZDI1bGNpSWdJbDlmWTNSdmNsOXdaVzVrYVc1bklpQWlYMk5oWTJobFpFUnZiV0ZwYmxObGNHRnlZWFJ2Y2lJZ0lsOWpZV05vWldSRGFHRnBia2xrSWlBaVgyTmhZMmhsWkZSb2FYTWlJQ0pmWTJGamFHVmtUbUZ0WlVoaGMyZ2lJQ0pmWTJGamFHVmtWbVZ5YzJsdmJraGhjMmdpSURCNE1qQWdNSGd3TURBd0lDSmZjbVZuYVhOMFpYSmxaRk53YjJ0bGN5SWdJbDlqYjI1bWFXY2lJQ0pmYm05dVkyVnpJaUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBZ01IZzRZamN6WXpOak5qbGlZamhtWlROa05URXlaV05qTkdObU56VTVZMk0zT1RJek9XWTNZakUzT1dJd1ptWmhZMkZoT1dFM05XUTFNakppTXprME1EQm1JREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVNBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlnTUhnMU5tTTNaVGRqT0dVMFpUUmhaamxrTkRjMk5qSTJOakk0WW1ZMk5qSXdObVl4WVdaak1tWXhNRGsxWVRrMU4yRmpNekk1WldVNU9XUTBaR1JqTmpSaUlEQjRZemc1Wldaa1lXRTFOR013WmpJd1l6ZGhaR1kyTVRJNE9ESmtaakE1TlRCbU5XRTVOVEUyTXpkbE1ETXdOMk5rWTJJMFl6WTNNbVl5T1RoaU9HSmpOZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNHNGdNalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnT1FvZ0lDQWdjSFZ6YUdsdWRDQTBNRGsyQ2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBMUNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaWVYUmxZeUE0SUM4dklDSmZYMk4wYjNKZmNHVnVaR2x1WnlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzVPVEJtTXpCaFpTQXdlR1prWTJFMk5qTmlJREI0TkdVME5Ua3lORElnTUhobVlUUm1OV1UwTXlBd2VEWXlNamsxTVRWbElEQjRNalExTTJGaFltTWdNSGhqWldZM1pEUmlNeUF3ZURJNU16RTBOak0ySURCNE1qSmtOakUyWkRJZ01IZzNPREUwWXpnek9TQXdlRGRpWW1WbE5EbG1JREI0TWpjNU1HTm1NR1VnTUhnMllqUXlOalU0TlNBd2VHSTRNbVpoTWprNElEQjRPREZoT1RRME16TWdNSGczTnpBd05HUTRNeUF3ZUdGak16Sm1NV001SURCNE1EUTVNVGxoTWpZZ01IZ3pOV1F5WmpneE5DQXdlRGRoWWprNFl6Vm1JREI0TVdKa1lqRXdPVGdnTUhobFl6WmhNalprWmlBd2VHSmtNR0k0WlRRMklEQjRZemcyWWpFNE16SWdNSGhrTm1RMk9EVTVNeUF3ZURSaVpXSm1PVEZpSURCNFpEVmhaRFExTVRZZ01IaGxNVGRpWVdaaU5DQXdlR1ExTWpGa05qQTBJREI0WWpGaVltSXdZVGdnTUhnelpUSmpOakZsTlNBdkx5QnRaWFJvYjJRZ0lsOWZjRzl6ZEVsdWFYUW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUkhiRzlpWVd4UVpYSnRhWE56YVc5dUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aWIyOXNLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRU5oYmxWd1pHRjBaVlZ6YVc1blFYTkRiMnhzWVhSbGNtRnNVR1Z5YldsemMybHZiaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSRFlXNVZjR1JoZEdWVmMyVnlVbWx6YTFCeVpXMXBkVzFRWlhKdGFYTnphVzl1S0dGa1pISmxjM01zWVdSa2NtVnpjeXhpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFTmhibFZ3WkdGMFpWVnpaWEpFZVc1aGJXbGpRMjl1Wm1sblVHVnliV2x6YzJsdmJpaGhaR1J5WlhOekxHRmtaSEpsYzNNc1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaVzV2ZFc1alpVZHNiMkpoYkZCbGNtMXBjM05wYjI0b1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYm05MWJtTmxRMkZ1VlhCa1lYUmxWWE5wYm1kQmMwTnZiR3hoZEdWeVlXeFFaWEp0YVhOemFXOXVLR0ZrWkhKbGMzTXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXNXZkVzVqWlVOaGJsVndaR0YwWlZWelpYSlNhWE5yVUhKbGJXbDFiVkJsY20xcGMzTnBiMjRvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxibTkxYm1ObFEyRnVWWEJrWVhSbFZYTmxja1I1Ym1GdGFXTkRiMjVtYVdkUVpYSnRhWE56YVc5dUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSVmMybHVaMEZ6UTI5c2JHRjBaWEpoYkU5dVFtVm9ZV3htVDJZb1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEdKdmIyd3NZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZWYzJWeVVtbHphMUJ5WlcxcGRXMVBia0psYUdGc1prOW1LR0ZrWkhKbGMzTXNZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZWYzJWeVJIbHVZVzFwWTBOdmJtWnBaMDl1UW1Wb1lXeG1UMllvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRU52Ym1acFoxQmxjbTFwYzNOcGIyNXpLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOektTaGliMjlzTEdKdmIyd3NZbTl2YkNraUxDQnRaWFJvYjJRZ0luSmxaMmx6ZEdWeVUzQnZhMlVvWVdSa2NtVnpjeXhpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGTmxiR1pCYzFWelpYSlFiM05wZEdsdmJrMWhibUZuWlhKWGFYUm9VMmxuS0dGa1pISmxjM01zWVdSa2NtVnpjeXhpYjI5c0xIVnBiblF5TlRZc2RXbHVkREkxTml4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWljR1Z5YldsMFVtVnpaWEoyWlZWdVpHVnliSGxwYm1jb1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEdGa1pISmxjM01zZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5RMk5DeGllWFJsV3pNeVhTeGllWFJsV3pNeVhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXNXZkVzVqWlZCdmMybDBhVzl1VFdGdVlXZGxjbEp2YkdVb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbTExYkhScFkyRnNiQ2hpZVhSbFcxMWJYU2xpZVhSbFcxMWJYU0lzSUcxbGRHaHZaQ0FpYVhOVGNHOXJaVkpsWjJsemRHVnlaV1FvWVdSa2NtVnpjeWxpYjI5c0lpd2diV1YwYUc5a0lDSnlaWE5qZFdWVWIydGxiaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYTmpkV1ZPWVhScGRtVW9ZV1JrY21WemN5eDFhVzUwTWpVMktYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGMyTjFaVWQxWVhKa2FXRnVLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0pFVDAxQlNVNWZVMFZRUVZKQlZFOVNLQ2xpZVhSbFd6TXlYU0lzSUcxbGRHaHZaQ0FpWldsd056RXlSRzl0WVdsdUtDa29ZbmwwWlZzeFhTeHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTFNVElzWVdSa2NtVnpjeXhpZVhSbFd6TXlYU3gxYVc1ME1qVTJXMTBwSWl3Z2JXVjBhRzlrSUNKMWMyVk9iMjVqWlNoMWFXNTBNVGt5S1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW01dmJtTmxjeWhoWkdSeVpYTnpMSFZwYm5ReE9USXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWljR1Z1WkdsdVowOTNibVZ5S0NsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2s5M2JtVnljMmhwY0NoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZqWTJWd2RFOTNibVZ5YzJocGNDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWIzZHVaWElvS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW5KbGJtOTFibU5sVDNkdVpYSnphR2x3S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWZYM0J2YzNSSmJtbDBYM0p2ZFhSbFFEVWdiV0ZwYmw5elpYUkhiRzlpWVd4UVpYSnRhWE56YVc5dVgzSnZkWFJsUURZZ2JXRnBibDl6WlhSRFlXNVZjR1JoZEdWVmMybHVaMEZ6UTI5c2JHRjBaWEpoYkZCbGNtMXBjM05wYjI1ZmNtOTFkR1ZBTnlCdFlXbHVYM05sZEVOaGJsVndaR0YwWlZWelpYSlNhWE5yVUhKbGJXbDFiVkJsY20xcGMzTnBiMjVmY205MWRHVkFPQ0J0WVdsdVgzTmxkRU5oYmxWd1pHRjBaVlZ6WlhKRWVXNWhiV2xqUTI5dVptbG5VR1Z5YldsemMybHZibDl5YjNWMFpVQTVJRzFoYVc1ZmNtVnViM1Z1WTJWSGJHOWlZV3hRWlhKdGFYTnphVzl1WDNKdmRYUmxRREV3SUcxaGFXNWZjbVZ1YjNWdVkyVkRZVzVWY0dSaGRHVlZjMmx1WjBGelEyOXNiR0YwWlhKaGJGQmxjbTFwYzNOcGIyNWZjbTkxZEdWQU1URWdiV0ZwYmw5eVpXNXZkVzVqWlVOaGJsVndaR0YwWlZWelpYSlNhWE5yVUhKbGJXbDFiVkJsY20xcGMzTnBiMjVmY205MWRHVkFNVElnYldGcGJsOXlaVzV2ZFc1alpVTmhibFZ3WkdGMFpWVnpaWEpFZVc1aGJXbGpRMjl1Wm1sblVHVnliV2x6YzJsdmJsOXliM1YwWlVBeE15QnRZV2x1WDNObGRGVnphVzVuUVhORGIyeHNZWFJsY21Gc1QyNUNaV2hoYkdaUFpsOXliM1YwWlVBeE5DQnRZV2x1WDNWd1pHRjBaVlZ6WlhKU2FYTnJVSEpsYldsMWJVOXVRbVZvWVd4bVQyWmZjbTkxZEdWQU1UVWdiV0ZwYmw5MWNHUmhkR1ZWYzJWeVJIbHVZVzFwWTBOdmJtWnBaMDl1UW1Wb1lXeG1UMlpmY205MWRHVkFNVFlnYldGcGJsOW5aWFJEYjI1bWFXZFFaWEp0YVhOemFXOXVjMTl5YjNWMFpVQXhOeUJ0WVdsdVgzSmxaMmx6ZEdWeVUzQnZhMlZmY205MWRHVkFNVGdnYldGcGJsOXpaWFJUWld4bVFYTlZjMlZ5VUc5emFYUnBiMjVOWVc1aFoyVnlWMmwwYUZOcFoxOXliM1YwWlVBeE9TQnRZV2x1WDNCbGNtMXBkRkpsYzJWeWRtVlZibVJsY214NWFXNW5YM0p2ZFhSbFFESXdJRzFoYVc1ZmNtVnViM1Z1WTJWUWIzTnBkR2x2YmsxaGJtRm5aWEpTYjJ4bFgzSnZkWFJsUURJeElHMWhhVzVmYlhWc2RHbGpZV3hzWDNKdmRYUmxRREl5SUcxaGFXNWZhWE5UY0c5clpWSmxaMmx6ZEdWeVpXUmZjbTkxZEdWQU1qTWdiV0ZwYmw5eVpYTmpkV1ZVYjJ0bGJsOXliM1YwWlVBeU5DQnRZV2x1WDNKbGMyTjFaVTVoZEdsMlpWOXliM1YwWlVBeU5TQnRZV2x1WDNKbGMyTjFaVWQxWVhKa2FXRnVYM0p2ZFhSbFFESTJJRzFoYVc1ZlJFOU5RVWxPWDFORlVFRlNRVlJQVWw5eWIzVjBaVUF5TnlCdFlXbHVYMlZwY0RjeE1rUnZiV0ZwYmw5eWIzVjBaVUF5T0NCdFlXbHVYM1Z6WlU1dmJtTmxYM0p2ZFhSbFFESTVJRzFoYVc1ZmJtOXVZMlZ6WDNKdmRYUmxRRE13SUcxaGFXNWZjR1Z1WkdsdVowOTNibVZ5WDNKdmRYUmxRRE14SUcxaGFXNWZkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQmZjbTkxZEdWQU16SWdiV0ZwYmw5aFkyTmxjSFJQZDI1bGNuTm9hWEJmY205MWRHVkFNek1nYldGcGJsOXZkMjVsY2w5eWIzVjBaVUF6TkNCdFlXbHVYM0psYm05MWJtTmxUM2R1WlhKemFHbHdYM0p2ZFhSbFFETTFDaUFnSUNCbGNuSUtDbTFoYVc1ZmNtVnViM1Z1WTJWUGQyNWxjbk5vYVhCZmNtOTFkR1ZBTXpVNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEUXlPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwOTNibVZ5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQmZkSEpoYm5ObVpYSlBkMjVsY25Ob2FYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTVRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTWdvS2JXRnBibDl2ZDI1bGNsOXliM1YwWlVBek5Eb0tJQ0FnSUdOaGJHeHpkV0lnYjNkdVpYSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXTmpaWEIwVDNkdVpYSnphR2x3WDNKdmRYUmxRRE16T2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME9Ub0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCd1pXNWthVzVuVDNkdVpYSUtJQ0FnSUdScFp5QXhDaUFnSUNBaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTkzYm1GaWJHVlZibUYxZEdodmNtbDZaV1JCWTJOdmRXNTBDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUTRPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEUTVDZ3B0WVdsdVgzUnlZVzV6Wm1WeVQzZHVaWEp6YUdsd1gzSnZkWFJsUURNeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFV6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFUwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCallXeHNjM1ZpSUY5amFHVmphMDkzYm1WeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKZmNHVnVaR2x1WjA5M2JtVnlJZ29nSUNBZ1pHbG5JREkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JqWVd4c2MzVmlJRzkzYm1WeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEaGxOV0UzT1RnM0lDOHZJRzFsZEdodlpDQWlUM2R1WlhKemFHbHdWSEpoYm5ObVpYSlRkR0Z5ZEdWa0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU5Bb0tiV0ZwYmw5d1pXNWthVzVuVDNkdVpYSmZjbTkxZEdWQU16RTZDaUFnSUNCallXeHNjM1ZpSUhCbGJtUnBibWRQZDI1bGNnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dWIyNWpaWE5mY205MWRHVkFNekE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBek5Bb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXhPVElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpFNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE0wQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURJMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbDl1YjI1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFl3T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFl4Q2dwdFlXbHVYM1Z6WlU1dmJtTmxYM0p2ZFhSbFFESTVPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE0wQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERFNU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTJOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJOam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXpVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVgyNXZibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmllWFJsWXlBeE9TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbndLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpZS0NtMWhhVzVmWldsd056RXlSRzl0WVdsdVgzSnZkWFJsUURJNE9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTNNQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HWXdNRGczTURBNVpUQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURCaE1UQXdNVFUwTXpabU5tVTJOalk1TmpjMU1EWm1Oek0yT1RjME5qazJaalpsTkdRMk1UWmxOakUyTnpZMU56SXdNREF4TXpFd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBM01Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBM01Rb0tiV0ZwYmw5RVQwMUJTVTVmVTBWUVFWSkJWRTlTWDNKdmRYUmxRREkzT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBM05Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBM05qb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbDlqWVdOb1pXUkViMjFoYVc1VFpYQmhjbUYwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F4T1FvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0lnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lsOWpZV05vWldSRGFHRnBia2xrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJmWTJGamFHVmtRMmhoYVc1SlpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWDJOaFkyaGxaRlJvYVhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5allXTm9aV1JVYUdseklHVjRhWE4wY3dvZ0lDQWdiRzloWkNBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZajA5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaVBUMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJSE4zWVhBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlNRGNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlYMk5oWTJobFpFNWhiV1ZJWVhOb0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCZlkyRmphR1ZrVG1GdFpVaGhjMmdnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0lsOWpZV05vWldSV1pYSnphVzl1U0dGemFDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1gyTmhZMmhsWkZabGNuTnBiMjVJWVhOb0lHVjRhWE4wY3dvZ0lDQWdiRzloWkNBd0NpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaSFZ3TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbmwwWldNZ01qQWdMeThnTUhnNFlqY3pZek5qTmpsaVlqaG1aVE5rTlRFeVpXTmpOR05tTnpVNVkyTTNPVEl6T1dZM1lqRTNPV0l3Wm1aaFkyRmhPV0UzTldRMU1qSmlNemswTURCbUNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TWpBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBNQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2FXY2dOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTXdvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVYUmxZeUF5TVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWTI5dVkyRjBDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21Wd2JHRmpaVE1LSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J3ZFhOb2FXNTBJREUyTUFvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUd0bFkyTmhhekkxTmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWW5WeWVTQXhPUW9nSUNBZ2MzUnZjbVVnTUFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESXdOem9LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1pHbG5JREU0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEYzFPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEYzJDZ3B0WVdsdVgzSmxjMk4xWlVkMVlYSmthV0Z1WDNKdmRYUmxRREkyT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE1Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE1Ub0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdZMkZzYkhOMVlpQnZkMjVsY2dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEZ3dPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEZ3hDZ3B0WVdsdVgzSmxjMk4xWlU1aGRHbDJaVjl5YjNWMFpVQXlOVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNMkNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURnMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURnMk9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTFKbGMyTjFaVWQxWVhKa2FXRnVDaUFnSUNCa2FXY2dNVElLSUNBZ0lHUnBaeUF6TlFvZ0lDQWdZMkZzYkhOMVlpQkJaR1J5WlhOekxuTmxibVJXWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGcxT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGcyQ2dwdFlXbHVYM0psYzJOMVpWUnZhMlZ1WDNKdmRYUmxRREkwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpOZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTVNQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTVNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydFNaWE5qZFdWSGRXRnlaR2xoYmdvZ0lDQWdaR2xuSURFeENpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdScFp5QXpOZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxSVkpETWpBdWMyRm1aVlJ5WVc1elptVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBT1RBNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT1RFS0NtMWhhVzVmYVhOVGNHOXJaVkpsWjJsemRHVnlaV1JmY205MWRHVkFNak02Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRjS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9UVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU9UWTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWTJGc2JITjFZaUJmYVhOVGNHOXJaVkpsWjJsemRHVnlaV1FLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBT1RVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT1RZS0NtMWhhVzVmYlhWc2RHbGpZV3hzWDNKdmRYUmxRREl5T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS2dvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZblZ5ZVNBeU9Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0oxY25rZ053b0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEazVPZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUE1Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMlp2Y2tBeE1ERUtJQ0FnSUdScFp5QTJDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWprS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dPUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR1p2Y2lBb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1luVnllU0EzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTNDaUFnSUNCaUlHMWhhVzVmWm05eVgyaGxZV1JsY2tBNU9Rb0tiV0ZwYmw5aFpuUmxjbDltYjNKQU1UQXhPZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBqNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEF6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV3TkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TVRNS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpFME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUF3ZURBd01EQUtJQ0FnSUdKMWNua2dNamtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWRYSjVJREV3Q2dwdFlXbHVYM2RvYVd4bFgzUnZjRUF5TVRVNkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWkdsbklEa0tJQ0FnSUR3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmQyaHBiR1ZBTWpFM0NpQWdJQ0JrYVdjZ01qZ0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUdKNlpYSnZDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR0o1ZEdWaklERTFJQzh2SURCNE1EQXdNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHSjFjbmtnTWprS0lDQWdJR0lnYldGcGJsOTNhR2xzWlY5MGIzQkFNakUxQ2dwdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURJeE56b0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdKMWNua2dNalVLSUNBZ0lHUnBaeUF5T0FvZ0lDQWdZblZ5ZVNBeE9Rb0tiV0ZwYmw5M2FHbHNaVjkwYjNCQU1qRTRPZ29nSUNBZ1pHbG5JRGdLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5TlFvZ0lDQWdZajRLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmZDJocGJHVkFNakl3Q2lBZ0lDQnNiMkZrSURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeU5Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWpBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjBiMmtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZ3dNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlGOXlaV05oYkdOMWJHRjBaVjlvWldGa1gyWnZjbDlsYkdWdFpXNTBjMTkzYVhSb1gySjVkR1ZmYkdWdVozUm9YMmhsWVdRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF4Q2lBZ0lDQmlLd29nSUNBZ1luVnllU0F5TlFvZ0lDQWdZaUJ0WVdsdVgzZG9hV3hsWDNSdmNFQXlNVGdLQ20xaGFXNWZZV1owWlhKZmQyaHBiR1ZBTWpJd09nb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpFek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJeE5Bb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV3TXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TURRS0NtMWhhVzVmY21WdWIzVnVZMlZRYjNOcGRHbHZiazFoYm1GblpYSlNiMnhsWDNKdmRYUmxRREl4T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFM0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01USUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEE0Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV3T1RvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnRQZDI1bGNnb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURFMUNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaVpXUXpOemhsT0NBdkx5QnRaWFJvYjJRZ0luSmxibTkxYm1ObFVHOXphWFJwYjI1TllXNWhaMlZ5VW05c1pTaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklERXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1EZzZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UQTVDZ3B0WVdsdVgzQmxjbTFwZEZKbGMyVnlkbVZWYm1SbGNteDVhVzVuWDNKdmRYUmxRREl3T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFM0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ016SUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU5Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ016VUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeE13b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1UUTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjlwYzFOd2IydGxVbVZuYVhOMFpYSmxaQW9nSUNBZ1lYTnpaWEowSUM4dklGTndiMnRsVG05MFVtVm5hWE4wWlhKbFpBb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTBJQzh2SURJMU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnYVc1MFl5QTBJQzh2SURJMU5Rb2dJQ0FnSmdvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNelFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNFpUTTFabVkzWlNBdkx5QnRaWFJvYjJRZ0ltZGxkRkpsYzJWeWRtVW9kV2x1ZERJMU5pa29kV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME1UWXNkV2x1ZERnc2RXbHVkREkwTEhWcGJuUTRMSFZwYm5Rek1pa2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F6TWdvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTXpRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNemdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJoT0dSa01EaG1JQzh2SUcxbGRHaHZaQ0FpY0dWeWJXbDBLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkRFkwTEdKNWRHVmJNekpkTEdKNWRHVmJNekpkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURJMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNakFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeE16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1UUUtDbTFoYVc1ZmMyVjBVMlZzWmtGelZYTmxjbEJ2YzJsMGFXOXVUV0Z1WVdkbGNsZHBkR2hUYVdkZmNtOTFkR1ZBTVRrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UY0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZblZ5ZVNBNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ016TUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBek5Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKMWNua2dNVGNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRFNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFeE9Ub0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdYMmx6VTNCdmEyVlNaV2RwYzNSbGNtVmtDaUFnSUNCaGMzTmxjblFnTHk4Z1UzQnZhMlZPYjNSU1pXZHBjM1JsY21Wa0NpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUdKdmIyd2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHUnBaeUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURFMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EWXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ016WUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVTNaVGxoTkdNNElDOHZJRzFsZEdodlpDQWljMlYwVlhObGNsQnZjMmwwYVc5dVRXRnVZV2RsY25OWGFYUm9VMmxuS0NoMWFXNTBPRnN6TWwwc0tIVnBiblE0V3pNeVhTeGliMjlzS1Z0ZExIVnBiblF5TlRZc2RXbHVkREkxTmlrc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeE9Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1Ua0tDbTFoYVc1ZmNtVm5hWE4wWlhKVGNHOXJaVjl5YjNWMFpVQXhPRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TndvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5WeWVTQXpDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV5TXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TWpRNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yVDNkdVpYSUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZDU1NCaWIyOXNJSFpoYkdsa1lYUnBiMjRLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1FXUmtjbVZ6Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKZmNtVm5hWE4wWlhKbFpGTndiMnRsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVEU1TURNMU9EWWdMeThnYldWMGFHOWtJQ0pUY0c5clpWSmxaMmx6ZEdWeVpXUW9kV2x1ZERoYk16SmRMR0p2YjJ3cElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TWpNNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRJMENncHRZV2x1WDJkbGRFTnZibVpwWjFCbGNtMXBjM05wYjI1elgzSnZkWFJsUURFM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTNDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNamdLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qZ0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1USTVPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0E0T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQmthV2NnTVRVS0lDQWdJR1JwWnlBeU13b2dJQ0FnWkdsbklESTRDaUFnSUNCallXeHNjM1ZpSUY5blpYUlFaWEp0YVhOemFXOXVjd29nSUNBZ1kyRnNiSE4xWWlCRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNW5aWFJEYjI1bWFXZFFaWEp0YVhOemFXOXVWbUZzZFdWekNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEk0T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV5T1FvS2JXRnBibDkxY0dSaGRHVlZjMlZ5UkhsdVlXMXBZME52Ym1acFowOXVRbVZvWVd4bVQyWmZjbTkxZEdWQU1UWTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGNLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE16TUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UTTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJmYVhOVGNHOXJaVkpsWjJsemRHVnlaV1FLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRjRzlyWlU1dmRGSmxaMmx6ZEdWeVpXUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ01qVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjluWlhSUVpYSnRhWE56YVc5dWN3b2dJQ0FnWTJGc2JITjFZaUJEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1allXNVZjR1JoZEdWVmMyVnlSSGx1WVcxcFkwTnZibVpwWndvZ0lDQWdZWE56WlhKMElDOHZJRVJsYkdWbllYUmxaVTV2ZEVGc2JHOTNaV1FLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERm1NV1F4WWpBMklDOHZJRzFsZEdodlpDQWlkWEJrWVhSbFZYTmxja1I1Ym1GdGFXTkRiMjVtYVdjb1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV6TXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TXpRS0NtMWhhVzVmZFhCa1lYUmxWWE5sY2xKcGMydFFjbVZ0YVhWdFQyNUNaV2hoYkdaUFpsOXliM1YwWlVBeE5Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREkwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFek9Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE16azZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjlwYzFOd2IydGxVbVZuYVhOMFpYSmxaQW9nSUNBZ1lYTnpaWEowSUM4dklGTndiMnRsVG05MFVtVm5hWE4wWlhKbFpBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJR1JwWnlBeU5Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdYMmRsZEZCbGNtMXBjM05wYjI1ekNpQWdJQ0JqWVd4c2MzVmlJRU52Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TG1OaGJsVndaR0YwWlZWelpYSlNhWE5yVUhKbGJXbDFiUW9nSUNBZ1lYTnpaWEowSUM4dklFUmxiR1ZuWVhSbFpVNXZkRUZzYkc5M1pXUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFek1USTNNVGRoSUM4dklHMWxkR2h2WkNBaWRYQmtZWFJsVlhObGNsSnBjMnRRY21WdGFYVnRLR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE16ZzZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UTTVDZ3B0WVdsdVgzTmxkRlZ6YVc1blFYTkRiMnhzWVhSbGNtRnNUMjVDWldoaGJHWlBabDl5YjNWMFpVQXhORG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TndvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFF6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUwTkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gybHpVM0J2YTJWU1pXZHBjM1JsY21Wa0NpQWdJQ0JoYzNObGNuUWdMeThnVTNCdmEyVk9iM1JTWldkcGMzUmxjbVZrQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnWW05dmJDQjJZV3hwWkdGMGFXOXVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkdsbklESTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJmWjJWMFVHVnliV2x6YzJsdmJuTUtJQ0FnSUdOaGJHeHpkV0lnUTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVkyRnVVMlYwVlhOcGJtZEJjME52Ykd4aGRHVnlZV3dLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaV3hsWjJGMFpXVk9iM1JCYkd4dmQyVmtDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ016UUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZekpoWW1VMk9EZ2dMeThnYldWMGFHOWtJQ0p6WlhSVmMybHVaMEZ6UTI5c2JHRjBaWEpoYkNoMWFXNTBNalUyTEdKdmIyd3NZV1JrY21WemN5bDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRRek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFME5Bb0tiV0ZwYmw5eVpXNXZkVzVqWlVOaGJsVndaR0YwWlZWelpYSkVlVzVoYldsalEyOXVabWxuVUdWeWJXbHpjMmx2Ymw5eWIzVjBaVUF4TXpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE53b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESTNDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUwT0FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TkRrNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOXBjMU53YjJ0bFVtVm5hWE4wWlhKbFpBb2dJQ0FnWVhOelpYSjBJQzh2SUZOd2IydGxUbTkwVW1WbmFYTjBaWEpsWkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF5T0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRkJsY20xcGMzTnBiMjV6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUVOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xuTmxkRU5oYmxWd1pHRjBaVlZ6WlhKRWVXNWhiV2xqUTI5dVptbG5DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOaGJHeHpkV0lnWDNWd1pHRjBaVkJsY20xcGMzTnBiMjV6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UUTRPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTBPUW9LYldGcGJsOXlaVzV2ZFc1alpVTmhibFZ3WkdGMFpWVnpaWEpTYVhOclVISmxiV2wxYlZCbGNtMXBjM05wYjI1ZmNtOTFkR1ZBTVRJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UY0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlOd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TlRNS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRVME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmthV2NnTVRVS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQmZhWE5UY0c5clpWSmxaMmx6ZEdWeVpXUUtJQ0FnSUdGemMyVnlkQ0F2THlCVGNHOXJaVTV2ZEZKbFoybHpkR1Z5WldRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTWpnS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJRWlhKdGFYTnphVzl1Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1kyRnNiSE4xWWlCRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNXpaWFJEWVc1VmNHUmhkR1ZWYzJWeVVtbHphMUJ5WlcxcGRXMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTJGc2JITjFZaUJmZFhCa1lYUmxVR1Z5YldsemMybHZibk1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5UTTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UVTBDZ3B0WVdsdVgzSmxibTkxYm1ObFEyRnVWWEJrWVhSbFZYTnBibWRCYzBOdmJHeGhkR1Z5WVd4UVpYSnRhWE56YVc5dVgzSnZkWFJsUURFeE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTNDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNamNLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRVNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFMU9Ub0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdYMmx6VTNCdmEyVlNaV2RwYzNSbGNtVmtDaUFnSUNCaGMzTmxjblFnTHk4Z1UzQnZhMlZPYjNSU1pXZHBjM1JsY21Wa0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURJNENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQmZaMlYwVUdWeWJXbHpjMmx2Ym5NS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVjMlYwUTJGdVUyVjBWWE5wYm1kQmMwTnZiR3hoZEdWeVlXd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTJGc2JITjFZaUJmZFhCa1lYUmxVR1Z5YldsemMybHZibk1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5UZzZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UVTVDZ3B0WVdsdVgzSmxibTkxYm1ObFIyeHZZbUZzVUdWeWJXbHpjMmx2Ymw5eWIzVjBaVUF4TURvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE53b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESTNDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUyTXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TmpRNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOXBjMU53YjJ0bFVtVm5hWE4wWlhKbFpBb2dJQ0FnWVhOelpYSjBJQzh2SUZOd2IydGxUbTkwVW1WbmFYTjBaWEpsWkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF5T0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRkJsY20xcGMzTnBiMjV6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1kyRnNiSE4xWWlCRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNXpaWFJHZFd4c1VHVnliV2x6YzJsdmJuTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTJGc2JITjFZaUJmZFhCa1lYUmxVR1Z5YldsemMybHZibk1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5qTTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UWTBDZ3B0WVdsdVgzTmxkRU5oYmxWd1pHRjBaVlZ6WlhKRWVXNWhiV2xqUTI5dVptbG5VR1Z5YldsemMybHZibDl5YjNWMFpVQTVPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpnS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZFhKNUlEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFk0Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUyT1RvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gybHpVM0J2YTJWU1pXZHBjM1JsY21Wa0NpQWdJQ0JoYzNObGNuUWdMeThnVTNCdmEyVk9iM1JTWldkcGMzUmxjbVZrQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnWW05dmJDQjJZV3hwWkdGMGFXOXVDaUFnSUNCa2RYQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBek1Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUY5blpYUlFaWEp0YVhOemFXOXVjd29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEF1YzJWMFEyRnVWWEJrWVhSbFZYTmxja1I1Ym1GdGFXTkRiMjVtYVdjS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQmZkWEJrWVhSbFVHVnliV2x6YzJsdmJuTUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TmpnNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRZNUNncHRZV2x1WDNObGRFTmhibFZ3WkdGMFpWVnpaWEpTYVhOclVISmxiV2wxYlZCbGNtMXBjM05wYjI1ZmNtOTFkR1ZBT0RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE53b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESTRDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFM013b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE56UTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjlwYzFOd2IydGxVbVZuYVhOMFpYSmxaQW9nSUNBZ1lYTnpaWEowSUM4dklGTndiMnRsVG05MFVtVm5hWE4wWlhKbFpBb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklHSnZiMndnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNekFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQmZaMlYwVUdWeWJXbHpjMmx2Ym5NS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUVOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xuTmxkRU5oYmxWd1pHRjBaVlZ6WlhKU2FYTnJVSEpsYldsMWJRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJRjkxY0dSaGRHVlFaWEp0YVhOemFXOXVjd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFM016b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE56UUtDbTFoYVc1ZmMyVjBRMkZ1VlhCa1lYUmxWWE5wYm1kQmMwTnZiR3hoZEdWeVlXeFFaWEp0YVhOemFXOXVYM0p2ZFhSbFFEYzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGNLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5T0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0oxY25rZ05Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhOemdLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVGM1T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZmFYTlRjRzlyWlZKbFoybHpkR1Z5WldRS0lDQWdJR0Z6YzJWeWRDQXZMeUJUY0c5clpVNXZkRkpsWjJsemRHVnlaV1FLSUNBZ0lHUnBaeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0JpYjI5c0lIWmhiR2xrWVhScGIyNEtJQ0FnSUdSMWNBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURNd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGQmxjbTFwYzNOcGIyNXpDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQkRiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzV6WlhSRFlXNVRaWFJWYzJsdVowRnpRMjlzYkdGMFpYSmhiQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUY5MWNHUmhkR1ZRWlhKdGFYTnphVzl1Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTNPRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhOemtLQ20xaGFXNWZjMlYwUjJ4dlltRnNVR1Z5YldsemMybHZibDl5YjNWMFpVQTJPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpnS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZFhKNUlEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGd6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREU0TkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gybHpVM0J2YTJWU1pXZHBjM1JsY21Wa0NpQWdJQ0JoYzNObGNuUWdMeThnVTNCdmEyVk9iM1JTWldkcGMzUmxjbVZrQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJRa2tnWW05dmJDQjJZV3hwWkdGMGFXOXVDaUFnSUNCa2RYQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBek1Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUY5blpYUlFaWEp0YVhOemFXOXVjd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJRU52Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TG5ObGRFWjFiR3hRWlhKdGFYTnphVzl1Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjNabGNpQTBDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlGOTFjR1JoZEdWUVpYSnRhWE56YVc5dWN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREU0TXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4T0RRS0NtMWhhVzVmWDE5d2IzTjBTVzVwZEY5eWIzVjBaVUExT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1gxOXdiM04wU1c1cGRDQmhiSEpsWVdSNUlHTmhiR3hsWkFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREUySUM4dklDSmZjbVZuYVhOMFpYSmxaRk53YjJ0bGN5SUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0pmWTI5dVptbG5JZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ055QXZMeUFpWDI5M2JtVnlJZ29nSUNBZ1lubDBaV05mTWlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmZjR1Z1WkdsdVowOTNibVZ5SWdvZ0lDQWdZbmwwWldOZk1pQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWDJOaFkyaGxaRlJvYVhNaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lsOWpZV05vWldSRGFHRnBia2xrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKZlkyRmphR1ZrVG1GdFpVaGhjMmdpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKZlkyRmphR1ZrVm1WeWMybHZia2hoYzJnaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0lsOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0lpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBkMjVoWW14bFNXNTJZV3hwWkU5M2JtVnlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2s5M2JtVnljMmhwY0FvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0o1ZEdWaklESXlJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpJREl5SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pmWTJGamFHVmtWR2hwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVgyTmhZMmhsWkVOb1lXbHVTV1FpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVgyTmhZMmhsWkU1aGJXVklZWE5vSWdvZ0lDQWdZbmwwWldNZ01qTWdMeThnTUhnMU5tTTNaVGRqT0dVMFpUUmhaamxrTkRjMk5qSTJOakk0WW1ZMk5qSXdObVl4WVdaak1tWXhNRGsxWVRrMU4yRmpNekk1WldVNU9XUTBaR1JqTmpSaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0lsOWpZV05vWldSV1pYSnphVzl1U0dGemFDSUtJQ0FnSUdKNWRHVmpJREkwSUM4dklEQjRZemc1Wldaa1lXRTFOR013WmpJd1l6ZGhaR1kyTVRJNE9ESmtaakE1TlRCbU5XRTVOVEUyTXpkbE1ETXdOMk5rWTJJMFl6WTNNbVl5T1RoaU9HSmpOZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUjFjRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pHbG5JREVLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJREI0T0dJM00yTXpZelk1WW1JNFptVXpaRFV4TW1Wall6UmpaamMxT1dOak56a3lNemxtTjJJeE56bGlNR1ptWVdOaFlUbGhOelZrTlRJeVlqTTVOREF3WmdvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdScFp5QXlDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QXdlREl3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZVhSbFl5QXlNeUF2THlBd2VEVTJZemRsTjJNNFpUUmxOR0ZtT1dRME56WTJNalkyTWpoaVpqWTJNakEyWmpGaFptTXlaakV3T1RWaE9UVTNZV016TWpsbFpUazVaRFJrWkdNMk5HSUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKNWRHVmpJREkwSUM4dklEQjRZemc1Wldaa1lXRTFOR013WmpJd1l6ZGhaR1kyTVRJNE9ESmtaakE1TlRCbU5XRTVOVEUyTXpkbE1ETXdOMk5rWTJJMFl6WTNNbVl5T1RoaU9HSmpOZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMk1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1lubDBaV01nTWpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TmpBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbDlqWVdOb1pXUkViMjFoYVc1VFpYQmhjbUYwYjNJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUY5d2RYbGhYMnhwWWk1aGNtTTBMbDl5WldOaGJHTjFiR0YwWlY5b1pXRmtYMlp2Y2w5bGJHVnRaVzUwYzE5M2FYUm9YMko1ZEdWZmJHVnVaM1JvWDJobFlXUW9ZWEp5WVhsZmFHVmhaRjloYm1SZmRHRnBiRG9nWW5sMFpYTXNJR3hsYm1kMGFEb2dkV2x1ZERZMExDQnpkR0Z5ZEY5aGRGOXBibVJsZURvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1gzSmxZMkZzWTNWc1lYUmxYMmhsWVdSZlptOXlYMlZzWlcxbGJuUnpYM2RwZEdoZllubDBaVjlzWlc1bmRHaGZhR1ZoWkRvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjM2RoY0FvS1gzSmxZMkZzWTNWc1lYUmxYMmhsWVdSZlptOXlYMlZzWlcxbGJuUnpYM2RwZEdoZllubDBaVjlzWlc1bmRHaGZhR1ZoWkY5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJRHdLSUNBZ0lHSjZJRjl5WldOaGJHTjFiR0YwWlY5b1pXRmtYMlp2Y2w5bGJHVnRaVzUwYzE5M2FYUm9YMko1ZEdWZmJHVnVaM1JvWDJobFlXUmZZV1owWlhKZlptOXlRRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F0TXdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCaUlGOXlaV05oYkdOMWJHRjBaVjlvWldGa1gyWnZjbDlsYkdWdFpXNTBjMTkzYVhSb1gySjVkR1ZmYkdWdVozUm9YMmhsWVdSZlptOXlYMmhsWVdSbGNrQXhDZ3BmY21WallXeGpkV3hoZEdWZmFHVmhaRjltYjNKZlpXeGxiV1Z1ZEhOZmQybDBhRjlpZVhSbFgyeGxibWQwYUY5b1pXRmtYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UTI5dVptbG5VRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVCWkdSeVpYTnpMbk5sYm1SV1lXeDFaU2h5WldOcGNHbGxiblE2SUdKNWRHVnpMQ0JoYlc5MWJuUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncEJaR1J5WlhOekxuTmxibVJXWVd4MVpUb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wUW1Gc1lXNWpaUW9nSUNBZ2NHOXdDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJOENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwUW1Gc1lXNWpaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUdOaGJHeHpkV0lnVEc5M1RHVjJaV3hEWVd4c0xtTmhiR3hPYjFKbGRIVnliZ29nSUNBZ1lub2dRV1JrY21WemN5NXpaVzVrVm1Gc2RXVmZaV3h6WlY5aWIyUjVRRFFLSUNBZ0lISmxkSE4xWWdvS1FXUmtjbVZ6Y3k1elpXNWtWbUZzZFdWZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNCallXeHNjM1ZpSUV4dmQweGxkbVZzUTJGc2JDNXlaWFIxY201RVlYUmhVMmw2WlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdZV2xzWldSRFlXeHNDaUFnSUNCaUlFeHZkMHhsZG1Wc1EyRnNiQzVpZFdKaWJHVlNaWFpsY25RS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBOdmJtWnBaMUJ2YzJsMGFXOXVUV0Z1WVdkbGNpNXpiMnd1UTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdWMyVjBSblZzYkZCbGNtMXBjM05wYjI1ektITjBZWFIxY3pvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbk5sZEVaMWJHeFFaWEp0YVhOemFXOXVjem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lDb0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRMjl1Wm1sblVHOXphWFJwYjI1TllXNWhaMlZ5TG5OdmJDNURiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzV6WlhSRFlXNVRaWFJWYzJsdVowRnpRMjlzYkdGMFpYSmhiQ2h6Wld4bU9pQjFhVzUwTmpRc0lITjBZWFIxY3pvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbk5sZEVOaGJsTmxkRlZ6YVc1blFYTkRiMnhzWVhSbGNtRnNPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1EyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVYM05sZEZOMFlYUjFjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlEYjI1bWFXZFFiM05wZEdsdmJrMWhibUZuWlhJdWMyOXNMa052Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TG5ObGRFTmhibFZ3WkdGMFpWVnpaWEpTYVhOclVISmxiV2wxYlNoelpXeG1PaUIxYVc1ME5qUXNJSE4wWVhSMWN6b2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDa052Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TG5ObGRFTmhibFZ3WkdGMFpWVnpaWEpTYVhOclVISmxiV2wxYlRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRU52Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TGw5elpYUlRkR0YwZFhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlEyOXVabWxuVUc5emFYUnBiMjVOWVc1aFoyVnlMbk52YkM1RGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNXpaWFJEWVc1VmNHUmhkR1ZWYzJWeVJIbHVZVzFwWTBOdmJtWnBaeWh6Wld4bU9pQjFhVzUwTmpRc0lITjBZWFIxY3pvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbk5sZEVOaGJsVndaR0YwWlZWelpYSkVlVzVoYldsalEyOXVabWxuT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlFTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbDl6WlhSVGRHRjBkWE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UTI5dVptbG5VRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1blpYUkRiMjVtYVdkUVpYSnRhWE56YVc5dVZtRnNkV1Z6S0hObGJHWTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDa052Ym1acFoxQmxjbTFwYzNOcGIyNXpUV0Z3TG1kbGRFTnZibVpwWjFCbGNtMXBjM05wYjI1V1lXeDFaWE02Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1allXNVRaWFJWYzJsdVowRnpRMjlzYkdGMFpYSmhiQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1allXNVZjR1JoZEdWVmMyVnlSSGx1WVcxcFkwTnZibVpwWndvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNWpZVzVWY0dSaGRHVlZjMlZ5VW1semExQnlaVzFwZFcwS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lITjNZWEFLSUNBZ0lITmxkR0pwZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5RGIyNW1hV2RRYjNOcGRHbHZiazFoYm1GblpYSXVjMjlzTGtOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xtTmhibE5sZEZWemFXNW5RWE5EYjJ4c1lYUmxjbUZzS0hObGJHWTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1allXNVRaWFJWYzJsdVowRnpRMjlzYkdGMFpYSmhiRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZMkZzYkhOMVlpQkRiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzVmWjJWMFUzUmhkSFZ6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBOdmJtWnBaMUJ2YzJsMGFXOXVUV0Z1WVdkbGNpNXpiMnd1UTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVkyRnVWWEJrWVhSbFZYTmxjbEpwYzJ0UWNtVnRhWFZ0S0hObGJHWTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1allXNVZjR1JoZEdWVmMyVnlVbWx6YTFCeVpXMXBkVzA2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR05oYkd4emRXSWdRMjl1Wm1sblVHVnliV2x6YzJsdmJuTk5ZWEF1WDJkbGRGTjBZWFIxY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5RGIyNW1hV2RRYjNOcGRHbHZiazFoYm1GblpYSXVjMjlzTGtOdmJtWnBaMUJsY20xcGMzTnBiMjV6VFdGd0xtTmhibFZ3WkdGMFpWVnpaWEpFZVc1aGJXbGpRMjl1Wm1sbktITmxiR1k2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwRGIyNW1hV2RRWlhKdGFYTnphVzl1YzAxaGNDNWpZVzVWY0dSaGRHVlZjMlZ5UkhsdVlXMXBZME52Ym1acFp6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdOaGJHeHpkV0lnUTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVgyZGxkRk4wWVhSMWN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUWIzTnBkR2x2YmsxaGJtRm5aWEl1YzI5c0xrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbVZ4S0hObGJHWTZJSFZwYm5RMk5Dd2diM1JvWlhJNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncERiMjVtYVdkUVpYSnRhWE56YVc5dWMwMWhjQzVsY1RvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwTnZibVpwWjFCdmMybDBhVzl1VFdGdVlXZGxjaTV6YjJ3dVEyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVYM05sZEZOMFlYUjFjeWh6Wld4bU9pQjFhVzUwTmpRc0lHMWhjMnM2SUhWcGJuUTJOQ3dnYzNSaGRIVnpPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LUTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVgzTmxkRk4wWVhSMWN6b0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllaUJEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1ZmMyVjBVM1JoZEhWelgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lId0tJQ0FnSUhKbGRITjFZZ29LUTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVgzTmxkRk4wWVhSMWMxOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdNZ05DQXZMeUF5TlRVS0lDQWdJRjRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ0pnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUWIzTnBkR2x2YmsxaGJtRm5aWEl1YzI5c0xrTnZibVpwWjFCbGNtMXBjM05wYjI1elRXRndMbDluWlhSVGRHRjBkWE1vTWlsZk1DaHpaV3htT2lCMWFXNTBOalFzSUcxaGMyczZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1ZloyVjBVM1JoZEhWek9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwTnZibVpwWjFCdmMybDBhVzl1VFdGdVlXZGxjaTV6YjJ3dVEyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVYMmRsZEZOMFlYUjFjeWd5S1Y4eENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwTnZibVpwWjFCdmMybDBhVzl1VFdGdVlXZGxjaTV6YjJ3dVEyOXVabWxuVUdWeWJXbHpjMmx2Ym5OTllYQXVYMmRsZEZOMFlYUjFjeWd5S1Y4eEtITmxiR1k2SUhWcGJuUTJOQ3dnYldGemF6b2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UTI5dVptbG5VRzl6YVhScGIyNU5ZVzVoWjJWeUxuTnZiQzVEYjI1bWFXZFFaWEp0YVhOemFXOXVjMDFoY0M1ZloyVjBVM1JoZEhWektESXBYekU2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FtQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRMjl1Wm1sblVHOXphWFJwYjI1TllXNWhaMlZ5TG5OdmJDNU1iM2RNWlhabGJFTmhiR3d1WTJGc2JFNXZVbVYwZFhKdUtETXBLSFJoY21kbGREb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeXdnWkdGMFlUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tURzkzVEdWMlpXeERZV3hzTG1OaGJHeE9iMUpsZEhWeWJqb0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdiRzloWkNBd0NpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TWpBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUWIzTnBkR2x2YmsxaGJtRm5aWEl1YzI5c0xreHZkMHhsZG1Wc1EyRnNiQzV5WlhSMWNtNUVZWFJoVTJsNlpTZ3BJQzArSUdKNWRHVnpPZ3BNYjNkTVpYWmxiRU5oYkd3dWNtVjBkWEp1UkdGMFlWTnBlbVU2Q2lBZ0lDQnNiMkZrSURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRMjl1Wm1sblVHOXphWFJwYjI1TllXNWhaMlZ5TG5OdmJDNU1iM2RNWlhabGJFTmhiR3d1WW5WaVlteGxVbVYyWlhKMEtEQXBLQ2tnTFQ0Z2RtOXBaRG9LVEc5M1RHVjJaV3hEWVd4c0xtSjFZbUpzWlZKbGRtVnlkRG9LSUNBZ0lHVnljaUF2THlCeVpYWmxjblFLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMME52Ym1acFoxQnZjMmwwYVc5dVRXRnVZV2RsY2k1emIyd3VVMkZtWlVWU1F6SXdMbk5oWm1WVWNtRnVjMlpsY2loMGIydGxiam9nWW5sMFpYTXNJSFJ2T2lCaWVYUmxjeXdnZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncFRZV1psUlZKRE1qQXVjMkZtWlZSeVlXNXpabVZ5T2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUlZKRE1qQXVYM05oWm1WVWNtRnVjMlpsY2dvZ0lDQWdZWE56WlhKMElDOHZJRk5oWm1WRlVrTXlNRVpoYVd4bFpFOXdaWEpoZEdsdmJnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OURiMjVtYVdkUWIzTnBkR2x2YmsxaGJtRm5aWEl1YzI5c0xsTmhabVZGVWtNeU1DNWZjMkZtWlZSeVlXNXpabVZ5S0hSdmEyVnVPaUJpZVhSbGN5d2dkRzg2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNc0lHSjFZbUpzWlRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNsTmhabVZGVWtNeU1DNWZjMkZtWlZSeVlXNXpabVZ5T2dvZ0lDQWdjSEp2ZEc4Z05DQXhDaUFnSUNCc2IyRmtJREFLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFNU1EVTVZMkppTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQTBDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21Wd2JHRmpaVElnTXpZS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRFk0Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01Rb2dJQ0FnWWowOUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0o2SUZOaFptVkZVa015TUM1ZmMyRm1aVlJ5WVc1elptVnlYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJSEpsZG1WeWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvS1UyRm1aVVZTUXpJd0xsOXpZV1psVkhKaGJuTm1aWEpmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlEYjI1bWFXZFFiM05wZEdsdmJrMWhibUZuWlhJdWMyOXNMa052Ym1acFoxQnZjMmwwYVc5dVRXRnVZV2RsY2k1ZmRYQmtZWFJsVUdWeWJXbHpjMmx2Ym5Nb2MzQnZhMlU2SUdKNWRHVnpMQ0JrWld4bFoyRjBiM0k2SUdKNWRHVnpMQ0JrWld4bFoyRjBaV1U2SUdKNWRHVnpMQ0J2YkdSUVpYSnRhWE56YVc5dWN6b2dkV2x1ZERZMExDQnVaWGRRWlhKdGFYTnphVzl1Y3pvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwZmRYQmtZWFJsVUdWeWJXbHpjMmx2Ym5NNkNpQWdJQ0J3Y205MGJ5QTFJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZeUEwSUM4dklESTFOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpJRFFnTHk4Z01qVTFDaUFnSUNBbUNpQWdJQ0JtY21GdFpWOWlkWEo1SUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdNZ05DQXZMeUF5TlRVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUhaaGJHbGtZWFJwYjI0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWXlBMElDOHZJREkxTlFvZ0lDQWdKZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnUTI5dVptbG5VR1Z5YldsemMybHZibk5OWVhBdVpYRUtJQ0FnSUdKNklGOTFjR1JoZEdWUVpYSnRhWE56YVc5dWMxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJSEpsZEhOMVlnb0tYM1Z3WkdGMFpWQmxjbTFwYzNOcGIyNXpYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbDlqYjI1bWFXY2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XWTRZV1kxTWpjZ0x5OGdiV1YwYUc5a0lDSkRiMjVtYVdkUVpYSnRhWE56YVc5dWMxVndaR0YwWldRb2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMME52Ym1acFoxQnZjMmwwYVc5dVRXRnVZV2RsY2k1emIyd3VRMjl1Wm1sblVHOXphWFJwYjI1TllXNWhaMlZ5TGw5blpYUlFaWEp0YVhOemFXOXVjeWh6Y0c5clpUb2dZbmwwWlhNc0lHUmxiR1ZuWVhSdmNqb2dZbmwwWlhNc0lHUmxiR1ZuWVhSbFpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tYMmRsZEZCbGNtMXBjM05wYjI1ek9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhOeUF2THlBaVgyTnZibVpwWnlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwTnZibVpwWjFCdmMybDBhVzl1VFdGdVlXZGxjaTV6YjJ3dVEyOXVabWxuVUc5emFYUnBiMjVOWVc1aFoyVnlMbDlwYzFOd2IydGxVbVZuYVhOMFpYSmxaQ2h6Y0c5clpUb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tYMmx6VTNCdmEyVlNaV2RwYzNSbGNtVmtPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0lsOXlaV2RwYzNSbGNtVmtVM0J2YTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZRMjl1Wm1sblVHOXphWFJwYjI1TllXNWhaMlZ5TG5OdmJDNURiMjVtYVdkUWIzTnBkR2x2YmsxaGJtRm5aWEl1WDJOb1pXTnJVbVZ6WTNWbFIzVmhjbVJwWVc0b0tTQXRQaUIyYjJsa09ncGZZMmhsWTJ0U1pYTmpkV1ZIZFdGeVpHbGhiam9LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnYjNkdVpYSUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1gyTm9aV05yVW1WelkzVmxSM1ZoY21ScFlXNWZZbTl2YkY5MGNuVmxRRElLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqWVd4c2MzVmlJRzkzYm1WeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWDJOb1pXTnJVbVZ6WTNWbFIzVmhjbVJwWVc1ZlltOXZiRjltWVd4elpVQXpDZ3BmWTJobFkydFNaWE5qZFdWSGRXRnlaR2xoYmw5aWIyOXNYM1J5ZFdWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENncGZZMmhsWTJ0U1pYTmpkV1ZIZFdGeVpHbGhibDlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VWSmxjMk4xWlVkMVlYSmthV0Z1Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWphR1ZqYTFKbGMyTjFaVWQxWVhKa2FXRnVYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRjlqYUdWamExSmxjMk4xWlVkMVlYSmthV0Z1WDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlEyOXVabWxuVUc5emFYUnBiMjVOWVc1aFoyVnlMbk52YkM1RGIyNW1hV2RRYjNOcGRHbHZiazFoYm1GblpYSXVjR1Z1WkdsdVowOTNibVZ5S0NrZ0xUNGdZbmwwWlhNNkNuQmxibVJwYm1kUGQyNWxjam9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ3Wlc1a2FXNW5UM2R1WlhKZmRHVnlibUZ5ZVY5bVlXeHpaVUF5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tjR1Z1WkdsdVowOTNibVZ5WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSWw5d1pXNWthVzVuVDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOXdaVzVrYVc1blQzZHVaWElnWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLQ25CbGJtUnBibWRQZDI1bGNsOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ3Wlc1a2FXNW5UM2R1WlhKZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlEYjI1bWFXZFFiM05wZEdsdmJrMWhibUZuWlhJdWMyOXNMa052Ym1acFoxQnZjMmwwYVc5dVRXRnVZV2RsY2k1ZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBb2JtVjNUM2R1WlhJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZmRISmhibk5tWlhKUGQyNWxjbk5vYVhBNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmZjR1Z1WkdsdVowOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5d1pXNWthVzVuVDNkdVpYSWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKZmNHVnVaR2x1WjA5M2JtVnlJZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlYMjkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCZmIzZHVaWElnWlhocGMzUnpDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmZiM2R1WlhJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qSTJOamhtWTJNZ0x5OGdiV1YwYUc5a0lDSlBkMjVsY25Ob2FYQlVjbUZ1YzJabGNuSmxaQ2gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwTnZibVpwWjFCdmMybDBhVzl1VFdGdVlXZGxjaTV6YjJ3dVEyOXVabWxuVUc5emFYUnBiMjVOWVc1aFoyVnlMbTkzYm1WeUtDa2dMVDRnWW5sMFpYTTZDbTkzYm1WeU9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHOTNibVZ5WDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtOTNibVZ5WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSWw5dmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMjkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNncHZkMjVsY2w5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnZkMjVsY2w5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMME52Ym1acFoxQnZjMmwwYVc5dVRXRnVZV2RsY2k1emIyd3VRMjl1Wm1sblVHOXphWFJwYjI1TllXNWhaMlZ5TGw5amFHVmphMDkzYm1WeUtDa2dMVDRnZG05cFpEb0tYMk5vWldOclQzZHVaWEk2Q2lBZ0lDQmpZV3hzYzNWaUlHOTNibVZ5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBaFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTkzYm1GaWJHVlZibUYxZEdodmNtbDZaV1JCWTJOdmRXNTBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBOdmJtWnBaMUJ2YzJsMGFXOXVUV0Z1WVdkbGNpNXpiMnd1UTI5dVptbG5VRzl6YVhScGIyNU5ZVzVoWjJWeUxtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQVFBZ0F2OEJKaGtBSVFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUVZIM3gxQVFFTlgzQmxibVJwYm1kUGQyNWxjZ0VBQmw5dmQyNWxjZzVmWDJOMGIzSmZjR1Z1WkdsdVp4WmZZMkZqYUdWa1JHOXRZV2x1VTJWd1lYSmhkRzl5RGw5allXTm9aV1JEYUdGcGJrbGtDMTlqWVdOb1pXUlVhR2x6RDE5allXTm9aV1JPWVcxbFNHRnphQkpmWTJGamFHVmtWbVZ5YzJsdmJraGhjMmdCSUFJQUFCRmZjbVZuYVhOMFpYSmxaRk53YjJ0bGN3ZGZZMjl1Wm1sbkIxOXViMjVqWlhNZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFBQUFBQUFBQUFnaTNQRHhwdTQvajFSTHN4TTkxbk1lU09mZXhlYkQvcktxYWRkVWlzNVFBOGdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFVS8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vOGdWc2ZueU9Ua3I1MUhaaVppaS9aaUJ2R3Z3dkVKV3BWNnd5bnVtZFRkeGtzZ3lKNzlxbFRBOGd4NjMyRW9ndDhKVVBXcFVXTitBd2ZOeTB4bkx5bUxpOFlqUnhnb1J3bUJnQ0N2U1RVRk5RQTBBSUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQmNRRFVBTVJoQUFBWW5DQ0puSWtNeEdSUkVNUmhFZ2g4RW1ROHdyZ1Q5eW1ZN0JFNUZra0lFK2s5ZVF3UmlLVkZlQkNSVHFyd0V6dmZVc3dRcE1VWTJCQ0xXRnRJRWVCVElPUVI3dnVTZkJDZVF6dzRFYTBKbGhRUzRMNktZQklHcFJETUVkd0JOZ3dTc012SEpCQVNSbWlZRU5kTDRGQVI2dVl4ZkJCdmJFSmdFN0dvbTN3UzlDNDVHQk1ockdESUUxdGFGa3dSTDYva2JCTld0UlJZRTRYdXZ0QVRWSWRZRUJMRzdzS2dFUGl4aDVUWWFBSTRmQzFNSzlncVlDam9KM0FtUkNVVUkrUWl0Q0J3SHdRZG1CeE1Hd2dYMEJRRUV1QU9NQTJBREl3THlBdGdCM1FFN0FONEFnd0I2QUVRQUpBQWJBQUVBTVJaQkFCRXhGaUlKT0FnVVJJZ1BCU3FJRHNVaVF5TkMvL0dJRHVFclRGQ3dJa014RmtFQUZ6RVdJZ2s0Q0JSRU1RQ0lEbzFMQVJNVVJJZ09uQ0pESTBMLzZ6WWFBVWxGR1JVa0VrUXhGa0VBSXpFV0lnazRDQlJFaUE2NEp3VkxHRWxPQW1lSURwWk1VSUFFamxwNWgweFFzQ0pESTBMLzM0Z09SaXRNVUxBaVF6WWFBVWxGRnhVa0VrUTJHZ0pKUlNJVmdSZ1NSREVXUVFBOU1SWWlDVGdJRkVRa3IwbExJa2xPQWxCSkZTUUpKRmhMR0V4UUFTY1NURkMrVEJjalRFOENUVXduRTZNcHFrd1dxMGtWSkE1RXF5dE1VTEFpUXlOQy84VTJHZ0ZKUlNJVmdSZ1NSREVXUVFCSk1SWWlDVGdJRkVReEFDU3ZTVXNqU1U0RFVFa1ZKQWtrV0U4RFRGQUJKeEpNVUVtK1RCY2pURThDVFVraUNCWlBBa3kvVHdJbkU2TXBxa3dXcTBrVkpBNUVxeXRNVUxBaVF5TkMvN2t4RmtFQW1URVdJZ2s0Q0JSRWdFVVBBSWNBbmdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFeUNsQ0FQZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFLRUFGVU52Ym1acFoxQnZjMmwwYVc5dVRXRnVZV2RsY2dBQk1RQUFVQ3RNVUxBaVF5TkMvMmt4RmtFQThqRVdJZ2s0Q0JSRUl5Y0paVXhGRTBRakp3cGxSQ01uQzJWRU5BQW5CRThEcUNnbkJFOENUVElLVHdPb0tDY0VUd0pOckNpb1REVUFRUUN3SXljTVpVUWpKdzFsUkRRQWdRaXZTd0ZYUUNCS1VFa1ZnUWdKV3lTdlR3UkxBaWNVWFVzREp3NmdLYXBMQlV4UVNSV0JDQWxiU3dKUENGQkpGU1FKSkZoZFN3T0FBVUNnS2FwTEJVeFFTUldCQ0FsYlN3SlBCMUJKRlNRSkpGaGRTd09BQVdDZ0thcExCVXhRU1JXQkNBbGJKeFZkVHdPQUFZQ2dLYXBQQkV4UVNSV0JDQWxiU3dJeUNsQkxBeklLVUJVa0NTUllYVWxQQTRHZ0FWZ0NUd0pNVUVrVkpBa2tXRmNBSUVVVE5RQXJTeEpRc0NKREkwTC9FREVXUVFBUk1SWWlDVGdJRkVTSURCY3JURkN3SWtNalF2L3hOaG9CU1VVT0ZTUVNSRFlhQWtsRkpCVWtFa1F4RmtFQUZERVdJZ2s0Q0JSRWlBdVBTd3hMSTRnSmNpSkRJMEwvN2pZYUFVbEZEUlVrRWtRMkdnSkpSUTRWSkJKRU5ob0RTVVVrRlNRU1JERVdRUUFXTVJZaUNUZ0lGRVNJQzFSTEMwc05TeVNJQ2tNaVF5TkMvK3cyR2dGSlJSRVZKQkpFTVJaQkFCa3hGaUlKT0FnVVJFc1BpQXNXSndZalR3SlVLMHhRc0NKREkwTC82VFlhQVVraldVbEZDeVVMUlFkSkZVVURWd0lBUlJ3alJRZExCa3NKREVFQUpVc0dTU1VMU3gxSlR3SlpTVXNKU1U0RUVrUkxBUlZTSTFrbENBaEZCeUlJUlFkQy85TkxCU1VJU3dJU1JERVdRUURWTVJZaUNUZ0lGRVF4RmtFQXhERVdJZ2s0Q0JSRUp3OUZIU05GQ2tzSlN3a01RUUE3U3h4SkkxbEpKUXNsQ0VzQ0pVc0NVaVd2VUVzREZVOEVUd05QQWxJbkQxQlFUQ0lJU1JaWEJnQk9BaU9JQ0JWUVN3b2lDRVVMUlIxQy83MG9SUmxMSEVVVFN3Z1dTeG1sUVFCYk5BQTFBSUVJcjBzWlNVNENVRWtWZ1FnSlcwc1VTVTRDSTFsTEFRMUVTd0ZSQUFKSkYwOERWd0lBU3dNbEMwc0JURmxLV1VzQkNDVUlTd0lqVHdOU0p3OVFTd0lWVEU0RFVsQk1Ud09JQjZsUVJSUW5CS0JGR1VML25DdExFMUN3SWtNalF2OCtJMEwvTFRZYUFVbEZFUlVrRWtRMkdnSkpSUXdWSkJKRU1SWkJBQ3d4RmlJSk9BZ1VSSWdLT3JGTEQ0RVlXNEVHc2hBanNoa2pzZ0d5R0lBRXZ0TjQ2TElhU3dxeUdyTWlReU5DLzlZMkdnRkpSUkVWSkJKRU5ob0NTVVVnRlNRU1JEWWFBMGxGR0JVa0VrUTJHZ1JKUlI4VkpCSkVOaG9GU1VVakZTUVNSRFlhQmtrVmdRZ1NSQmRGQkRZYUIwbEZGaFVrRWtRMkdnaEpSUlVWSkJKRU1SWkJBSmd4RmlJSk9BZ1VSRXNQU1lnSkxFUkxCRWtoQkE1RUlRUWFzU1N2U1VzaVVFa1ZKQWtrV0U4RGdSaGJnUWF5RUNPeUdTT3lBYklZZ0FTT05mOStzaHF5R3JPMFBsY0VJTEV5Q2tzQ1N5SlFTUlVrQ1NSWVR3TkxKbEJKRlNRSkpGaFBCQlpQQklFWVc0RUdzaEFqc2hranNnR3lHSUFFU28zUWo3SWFTeHF5R2s4RHNocFBBcklhVExJYXNocExGTElhU3hPeUdyTWlReU5DLzJvMkdnRkpSUkVWSkJKRU5ob0NTVVVRRlNRU1JEWWFBMGxGRDBrVkloSkVJMU5GQ0RZYUJFbEZJUlVrRWtRMkdnVkpSU01WSkJKRU5ob0dTU05aSlFoTEFSVVNSRmNDQUVVUk1SWkJBSHd4RmlJSk9BZ1VSRXNQU1lnSVFrUkxDQ0lPUkRJS1N3OVFnQ01BQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRXhjQXJGTEVJQUNBR0pRU3lKUVN5UlFURkJMRWtrVkZsY0dBa3hRVHdLQkdGdUJCcklRSTdJWkk3SUJzaGlBQkZmcHBNaXlHa3l5R3JJYXN5SkRJMEwvaGpZYUFVbEZFUlVrRWtRMkdnSkpSUkJKRlNJU1JDTlRSUU14RmtFQUx6RVdJZ2s0Q0JSRWlBZ3JTd0pKSWc1RVN4QkpLaE5FU1FFbkVFeFFUd0lXdjBzUFVJQUVvWkExaGt4UXNDSkRJMEwvMHpZYUFVbEZFUlVrRWtRMkdnSkpSUndWSkJKRU5ob0RTVVVZRlNRU1JERVdRUUFzTVJZaUNUZ0lGRVEwQUlFWXIwc0JnVmhiSWdnV1VGeEFOUUJMRDBzWFN4eUlCeUNJQllRclRGQ3dJa01qUXYvV05ob0JTVVVSRlNRU1JEWWFBa2xGR0JVa0VrUXhGa0VBUGpFV0lnazRDQlJFU3c5SmlBY0ZSREVBU3dGTEdVbE9CRThDaUFiZGlBV0lSTEdCR0Z1QkJySVFJN0laSTdJQnNoaUFCQjhkR3dheUdySWFzeUpESTBML3hEWWFBVWxGRVJVa0VrUTJHZ0pKUlJnVkpCSkVNUlpCQUQ0eEZpSUpPQWdVUkVzUFNZZ0dxa1F4QUVzQlN4bEpUZ1JQQW9nR2dvZ0ZJMFN4Z1JoYmdRYXlFQ095R1NPeUFiSVlnQVFURW5GNnNocXlHck1pUXlOQy84UTJHZ0ZKUlJFVkpCSkVOaG9DU1VVZ0ZTUVNSRFlhQTBrVkloSkVJMU5GQVRZYUJFbEZHQlVrRWtReEZrRUFYakVXSWdrNENCUkVTdzlKaUFZNVJFc0JTVTRDSWc1RU1RQkxBVXNhU1U0RlR3S0lCZ21JQktCRXNTU3ZTeUpRU1JVa0NTUllKd1lqVHdSVVR3S0JHRnVCQnJJUUk3SVpJN0lCc2hpQUJNS3I1b2l5R2t5eUdySWFzaHF6SWtNalF2K2tOaG9CU1VVUkZTUVNSRFlhQWtsRkd4VWtFa1F4RmtFQUx6RVdJZ2s0Q0JSRVN3OUppQVcrUkRFQVN3RkxIRWxPQkU4Q2lBV1dTU09JQStzeEFFNENUd05PQklnRlBpSkRJMEwvMHpZYUFVbEZFUlVrRWtRMkdnSkpSUnNWSkJKRU1SWkJBQzh4RmlJSk9BZ1VSRXNQU1lnRmNrUXhBRXNCU3h4SlRnUlBBb2dGU2tramlBT1RNUUJPQWs4RFRnU0lCUElpUXlOQy85TTJHZ0ZKUlJFVkpCSkVOaG9DU1VVYkZTUVNSREVXUVFBdk1SWWlDVGdJRkVSTEQwbUlCU1pFTVFCTEFVc2NTVTRFVHdLSUJQNUpJNGdET3pFQVRnSlBBMDRFaUFTbUlrTWpRdi9UTmhvQlNVVVJGU1FTUkRZYUFrbEZHeFVrRWtReEZrRUFMakVXSWdrNENCUkVTdzlKaUFUYVJERUFTd0ZMSEVsT0JFOENpQVN5STRnQzV6RUFUZ0pQQTA0RWlBUmJJa01qUXYvVU5ob0JTVVVSRlNRU1JEWWFBa2xGSEJVa0VrUTJHZ05KRlNJU1JDTlRSUVV4RmtFQU5URVdJZ2s0Q0JSRVN3OUppQVNEUkVzRlNVNENJZzVFU1RFQVN4NUpUZ1NJQkZaSlR3U0lBcW94QUU4RFRnUk9BNGdEL1NKREkwTC96VFlhQVVsRkVSVWtFa1EyR2dKSlJSd1ZKQkpFTmhvRFNSVWlFa1FqVTBVRk1SWkJBRFV4RmlJSk9BZ1VSRXNQU1lnRUpVUkxCVWxPQWlJT1JFa3hBRXNlU1U0RWlBUDRTVThFaUFKQU1RQlBBMDRFVGdPSUE1OGlReU5DLzgwMkdnRkpSUkVWSkJKRU5ob0NTVVVjRlNRU1JEWWFBMGtWSWhKRUkxTkZCVEVXUVFBMU1SWWlDVGdJRkVSTEQwbUlBOGRFU3dWSlRnSWlEa1JKTVFCTEhrbE9CSWdEbWtsUEJJZ0IxakVBVHdOT0JFNERpQU5CSWtNalF2L05OaG9CU1VVUkZTUVNSRFlhQWtsRkhCVWtFa1EyR2dOSkZTSVNSQ05UUlFVeEZrRUFOREVXSWdrNENCUkVTdzlKaUFOcFJFc0ZTVTRDSWc1RVNURUFTeDVKVGdTSUF6eFBBNGdCY0RFQVR3Tk9CRTREaUFMa0lrTWpRdi9PTmhvQlNSVWtFa1FuQ0dSRUp3Z2paeWNRSmJsSUp4RWx1VWduQnlwbkp3VXFaeWNMS0djbkNpaG5Kd3dxWnljTkttY25DU3BuSks5TEFTb1NGRVJNaUFORk1nb25GcXduRnF3bkMweG5Kd29uQkdjbkRDY1haeWNOSnhobk5BQ0JDSzlMQVZkQUlFcFFTUldCQ0FsYlR3TkxBU2NVWFVzQ0p3NmdLYXBMQkV4UVNSV0JDQWxiSnhkZFN3S0FBVUNnS2FwTEJFeFFTUldCQ0FsYkp4aGRTd0tBQVdDZ0thcExCRXhRU1JXQkNBbGJKeFZkVHdLQUFZQ2dLYXBQQTB4UVNSV0JDQWxiU3dNeUNsQkxCRElLVUJVa0NTUllYVWxQQW9HZ0FWZ0NUd0pNVUVrVkpBa2tXRmNBSUV3MUFDY0pUR2NpUTRvREFZditKUXRKaS84bEM0djlTd0ZaVHdKTWkvOU5USXNDaXdBTVFRQWppd0ZKRmxjR0FJdjlpd0pKVGdSUEFsMUpqUDFMQVZrbENBaU1BU1VJakFKQy85V0wvWXdBaVlvQ0FESUtjd0JJRm92L3BCUkVpLzZML3lpSUFNTkJBQUdKaUFEcUtLVkVRZ0RxaWdFQmkvK0JCd3VKaWdJQmkvNGlpLytJQUhXSmlnSUJpLzRsaS8rSUFHbUppZ0lCaS82QkJJdi9pQUJjaVlvQkFZdi9pQUFySndZalR3SlVpLytJQURRbkJpTlBBbFNMLzRnQUh5Y0dJMDhDVkNOVFR3SWlUd0pVVENOVEpVeFVpWW9CQVl2L0lvZ0FOb21LQVFHTC95V0lBQ3lKaWdFQmkvK0JCSWdBSVltS0FnR0wvb3YvRW9tS0F3R0wvMEVBQm92OWkvNFppWXYrSVFRYmkvMGFpWW9DQVl2K2kvK0lBQUdKaWdJQmkvNkwveG9qRTRtS0F3RTBBSUVJcjR2L0p3NmdLYXBMQVV4UVNSV0JDQWxiVEl2L1VFa1ZnUWdKVzBzQ1RnSllYQUExQUNLSk5BQTFBQ2lKQUlvREFJdjlpLzZML3lLSUFBSkVpWW9FQVRRQVNWZEFJRXdrcjBsUEFvQWdxUVdjdXdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCY0FDcGNCRXlML2xCSkZTUUpKRmhjSkVsWEFFUmNBRWtpVEZjQUlDY0VxQ2duQkU4Q1RTY0VyQ2lvUVFBUEtDY0VpLzlOS0t3b3FSUkVJb3dEaXdHTEFGQkpGU1FKSkZpTEFreGNRRFVBaXdPTUFJbUtCUUNML2lFRURrU0wvaUVFR296K2kvOGhCQTVFaS84aEJCcU0vNHYraS8rSS90MUJBQUdKaS91TC9GQ0wvVkJKQVNjUlRGQ0wveFpNU3dHL1VJQUVINHIxSjB4UXNJbUtBd0dML1l2K1VJdi9VQUVuRVV4UXZrd1hJMHhQQWsySmlnRUJpLzhCSnhCTVVMNU1GeU5NVHdKTmlURUFpQUJWRWtBQURvRVlyeklORmxDSUFFY1NRUUFESWtTSkkwTC8rakVXUVFBT01SWWlDVGdJRkVRakp3VmxSSWtqUXYvMGlnRUFJeWNGWlVVQlJDY0ZLbWNqSndkbFJDY0hpLzluaS85UWdBUmlaby9NVEZDd2lURVdRUUFPTVJZaUNUZ0lGRVFqSndkbFJJa2pRdi8waVAvbU1RQVRGRVNKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJzaGlwVHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJldmlvdXNPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDb25maWdQZXJtaXNzaW9uc1VwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0ZWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJtaXNzaW9ucyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3Bva2VSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik93bmVyc2hpcFRyYW5zZmVyU3RhcnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c093bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
