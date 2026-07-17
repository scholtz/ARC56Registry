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

namespace Arc56.Generated.YashDiwan_16.CollateralX.CollateralXStablecoinController_9a2cf201
{


    //
    // Stablecoin control logic.
    //
    //Safety-critical assumption: the stable ASA has a fixed reserve held by this
    //app account. The protocol manager is the only caller allowed to move reserve
    //units to vault owners.
    //
    public class CollateralXStablecoinControllerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CollateralXStablecoinControllerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class StablecoinControlState : AVMObjectType
            {
                public Algorand.Address Admin { get; set; }

                public ulong Initialized { get; set; }

                public ulong ProtocolManagerAppId { get; set; }

                public ulong StableAssetId { get; set; }

                public ulong IssuedSupplyMicroStable { get; set; }

                public ulong SupplyCeilingMicroStable { get; set; }

                public ulong PauseFlags { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAdmin.From(Admin);
                    ret.AddRange(vAdmin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInitialized.From(Initialized);
                    ret.AddRange(vInitialized.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProtocolManagerAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProtocolManagerAppId.From(ProtocolManagerAppId);
                    ret.AddRange(vProtocolManagerAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStableAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStableAssetId.From(StableAssetId);
                    ret.AddRange(vStableAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIssuedSupplyMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIssuedSupplyMicroStable.From(IssuedSupplyMicroStable);
                    ret.AddRange(vIssuedSupplyMicroStable.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSupplyCeilingMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSupplyCeilingMicroStable.From(SupplyCeilingMicroStable);
                    ret.AddRange(vSupplyCeilingMicroStable.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPauseFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPauseFlags.From(PauseFlags);
                    ret.AddRange(vPauseFlags.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StablecoinControlState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StablecoinControlState();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInitialized.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitialized = vInitialized.ToValue();
                    if (valueInitialized is ulong vInitializedValue) { ret.Initialized = vInitializedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProtocolManagerAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProtocolManagerAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProtocolManagerAppId = vProtocolManagerAppId.ToValue();
                    if (valueProtocolManagerAppId is ulong vProtocolManagerAppIdValue) { ret.ProtocolManagerAppId = vProtocolManagerAppIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStableAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStableAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStableAssetId = vStableAssetId.ToValue();
                    if (valueStableAssetId is ulong vStableAssetIdValue) { ret.StableAssetId = vStableAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIssuedSupplyMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIssuedSupplyMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIssuedSupplyMicroStable = vIssuedSupplyMicroStable.ToValue();
                    if (valueIssuedSupplyMicroStable is ulong vIssuedSupplyMicroStableValue) { ret.IssuedSupplyMicroStable = vIssuedSupplyMicroStableValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSupplyCeilingMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSupplyCeilingMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSupplyCeilingMicroStable = vSupplyCeilingMicroStable.ToValue();
                    if (valueSupplyCeilingMicroStable is ulong vSupplyCeilingMicroStableValue) { ret.SupplyCeilingMicroStable = vSupplyCeilingMicroStableValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPauseFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPauseFlags.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePauseFlags = vPauseFlags.ToValue();
                    if (valuePauseFlags is ulong vPauseFlagsValue) { ret.PauseFlags = vPauseFlagsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StablecoinControlState);
                }
                public bool Equals(StablecoinControlState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StablecoinControlState left, StablecoinControlState right)
                {
                    return EqualityComparer<StablecoinControlState>.Default.Equals(left, right);
                }
                public static bool operator !=(StablecoinControlState left, StablecoinControlState right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class StablecoinAdminCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 42, 193, 249, 116 };
                public const string Signature = "StablecoinAdminCreated(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field0 { get; set; }

                public static StablecoinAdminCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new StablecoinAdminCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

            }

            public class StablecoinControllerInitializedEventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 199, 103, 112, 211 };
                public const string Signature = "StablecoinControllerInitializedEvent(address,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Admin { get; set; }
                public ulong ProtocolManagerAppId { get; set; }
                public ulong StableAssetId { get; set; }
                public ulong SupplyCeilingMicroStable { get; set; }

                public static StablecoinControllerInitializedEventEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new StablecoinControllerInitializedEventEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProtocolManagerAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProtocolManagerAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProtocolManagerAppId = vProtocolManagerAppId.ToValue();
                    if (valueProtocolManagerAppId is ulong vProtocolManagerAppIdValue) { ret.ProtocolManagerAppId = vProtocolManagerAppIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStableAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStableAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStableAssetId = vStableAssetId.ToValue();
                    if (valueStableAssetId is ulong vStableAssetIdValue) { ret.StableAssetId = vStableAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSupplyCeilingMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSupplyCeilingMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSupplyCeilingMicroStable = vSupplyCeilingMicroStable.ToValue();
                    if (valueSupplyCeilingMicroStable is ulong vSupplyCeilingMicroStableValue) { ret.SupplyCeilingMicroStable = vSupplyCeilingMicroStableValue; }
                    return ret;

                }

            }

            public class StablecoinConfigUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 6, 62, 194, 118 };
                public const string Signature = "StablecoinConfigUpdated(address,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field0 { get; set; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }
                public ulong Field3 { get; set; }

                public static StablecoinConfigUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new StablecoinConfigUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

            public class StablecoinPauseFlagsUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 0, 75, 249, 54 };
                public const string Signature = "StablecoinPauseFlagsUpdated(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field0 { get; set; }
                public ulong Field1 { get; set; }

                public static StablecoinPauseFlagsUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new StablecoinPauseFlagsUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class StablecoinAssetOptedInEventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 222, 202, 194, 249 };
                public const string Signature = "StablecoinAssetOptedInEvent(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Admin { get; set; }
                public ulong StableAssetId { get; set; }

                public static StablecoinAssetOptedInEventEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new StablecoinAssetOptedInEventEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStableAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStableAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStableAssetId = vStableAssetId.ToValue();
                    if (valueStableAssetId is ulong vStableAssetIdValue) { ret.StableAssetId = vStableAssetIdValue; }
                    return ret;

                }

            }

            public class StablecoinMintedForVaultEventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 4, 62, 157, 65 };
                public const string Signature = "StablecoinMintedForVaultEvent(uint64,address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong VaultId { get; set; }
                public Algorand.Address Receiver { get; set; }
                public ulong AmountMicroStable { get; set; }
                public ulong IssuedSupplyMicroStable { get; set; }

                public static StablecoinMintedForVaultEventEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new StablecoinMintedForVaultEventEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVaultId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVaultId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVaultId = vVaultId.ToValue();
                    if (valueVaultId is ulong vVaultIdValue) { ret.VaultId = vVaultIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is Algorand.Address vReceiverValue) { ret.Receiver = vReceiverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountMicroStable = vAmountMicroStable.ToValue();
                    if (valueAmountMicroStable is ulong vAmountMicroStableValue) { ret.AmountMicroStable = vAmountMicroStableValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIssuedSupplyMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIssuedSupplyMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIssuedSupplyMicroStable = vIssuedSupplyMicroStable.ToValue();
                    if (valueIssuedSupplyMicroStable is ulong vIssuedSupplyMicroStableValue) { ret.IssuedSupplyMicroStable = vIssuedSupplyMicroStableValue; }
                    return ret;

                }

            }

            public class StablecoinRetiredForVaultEventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 75, 181, 240, 31 };
                public const string Signature = "StablecoinRetiredForVaultEvent(uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong VaultId { get; set; }
                public ulong AmountMicroStable { get; set; }
                public ulong IssuedSupplyMicroStable { get; set; }

                public static StablecoinRetiredForVaultEventEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new StablecoinRetiredForVaultEventEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVaultId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVaultId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVaultId = vVaultId.ToValue();
                    if (valueVaultId is ulong vVaultIdValue) { ret.VaultId = vVaultIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountMicroStable = vAmountMicroStable.ToValue();
                    if (valueAmountMicroStable is ulong vAmountMicroStableValue) { ret.AmountMicroStable = vAmountMicroStableValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIssuedSupplyMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIssuedSupplyMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIssuedSupplyMicroStable = vIssuedSupplyMicroStable.ToValue();
                    if (valueIssuedSupplyMicroStable is ulong vIssuedSupplyMicroStableValue) { ret.IssuedSupplyMicroStable = vIssuedSupplyMicroStableValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task CreateApplication(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///One-time stablecoin controller initialization by admin.
        ///</summary>
        /// <param name="protocolManagerAppId"> </param>
        /// <param name="stableAssetId"> </param>
        /// <param name="supplyCeilingMicroStable"> </param>
        public async Task InitializeStablecoinController(ulong protocolManagerAppId, ulong stableAssetId, ulong supplyCeilingMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 176, 20, 18 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var stableAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stableAssetIdAbi.From(stableAssetId);
            var supplyCeilingMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyCeilingMicroStableAbi.From(supplyCeilingMicroStable);

            var result = await base.CallApp(new List<object> { abiHandle, protocolManagerAppIdAbi, stableAssetIdAbi, supplyCeilingMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitializeStablecoinController_Transactions(ulong protocolManagerAppId, ulong stableAssetId, ulong supplyCeilingMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 176, 20, 18 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var stableAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stableAssetIdAbi.From(stableAssetId);
            var supplyCeilingMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyCeilingMicroStableAbi.From(supplyCeilingMicroStable);

            return await base.MakeTransactionList(new List<object> { abiHandle, protocolManagerAppIdAbi, stableAssetIdAbi, supplyCeilingMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read stablecoin controller state.
        ///</summary>
        public async Task<Structs.StablecoinControlState> ReadStablecoinControlState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 159, 146, 116 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.StablecoinControlState.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadStablecoinControlState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 159, 146, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only controller configuration update.
        ///</summary>
        /// <param name="protocolManagerAppId"> </param>
        /// <param name="stableAssetId"> </param>
        /// <param name="supplyCeilingMicroStable"> </param>
        public async Task AdminSetStablecoinConfig(ulong protocolManagerAppId, ulong stableAssetId, ulong supplyCeilingMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 105, 76, 235 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var stableAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stableAssetIdAbi.From(stableAssetId);
            var supplyCeilingMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyCeilingMicroStableAbi.From(supplyCeilingMicroStable);

            var result = await base.CallApp(new List<object> { abiHandle, protocolManagerAppIdAbi, stableAssetIdAbi, supplyCeilingMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminSetStablecoinConfig_Transactions(ulong protocolManagerAppId, ulong stableAssetId, ulong supplyCeilingMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 105, 76, 235 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var stableAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stableAssetIdAbi.From(stableAssetId);
            var supplyCeilingMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supplyCeilingMicroStableAbi.From(supplyCeilingMicroStable);

            return await base.MakeTransactionList(new List<object> { abiHandle, protocolManagerAppIdAbi, stableAssetIdAbi, supplyCeilingMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only replacement of stablecoin control pause flags.
        ///</summary>
        /// <param name="pauseFlags"> </param>
        public async Task AdminSetPauseFlags(ulong pauseFlags, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 205, 137, 128 };
            var pauseFlagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pauseFlagsAbi.From(pauseFlags);

            var result = await base.CallApp(new List<object> { abiHandle, pauseFlagsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminSetPauseFlags_Transactions(ulong pauseFlags, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 205, 137, 128 };
            var pauseFlagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pauseFlagsAbi.From(pauseFlags);

            return await base.MakeTransactionList(new List<object> { abiHandle, pauseFlagsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opts the app account into the stable ASA so it can hold mint reserves.
        ///The app account must be pre-funded for the ASA opt-in MBR and inner fee.
        ///</summary>
        public async Task OptInToStableAsset(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 84, 198, 130 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToStableAsset_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 84, 198, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Manager-authorized reserve transfer to a vault owner.
        ///</summary>
        /// <param name="vaultId"> </param>
        /// <param name="receiver"> </param>
        /// <param name="amountMicroStable"> </param>
        public async Task MintForVault(ulong vaultId, Algorand.Address receiver, ulong amountMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 247, 100, 118 };
            var vaultIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vaultIdAbi.From(vaultId);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountMicroStableAbi.From(amountMicroStable);

            var result = await base.CallApp(new List<object> { abiHandle, vaultIdAbi, receiverAbi, amountMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MintForVault_Transactions(ulong vaultId, Algorand.Address receiver, ulong amountMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 247, 100, 118 };
            var vaultIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vaultIdAbi.From(vaultId);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountMicroStableAbi.From(amountMicroStable);

            return await base.MakeTransactionList(new List<object> { abiHandle, vaultIdAbi, receiverAbi, amountMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Manager-authorized repayment accounting.
        ///
        ///The protocol manager validates the grouped user ASA transfer into this app
        ///before calling this method. The ASA units are retired by returning them to
        ///the controller reserve and decrementing issued protocol supply.
        ///</summary>
        /// <param name="vaultId"> </param>
        /// <param name="amountMicroStable"> </param>
        public async Task BurnForVault(ulong vaultId, ulong amountMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 6, 192, 73 };
            var vaultIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vaultIdAbi.From(vaultId);
            var amountMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountMicroStableAbi.From(amountMicroStable);

            var result = await base.CallApp(new List<object> { abiHandle, vaultIdAbi, amountMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BurnForVault_Transactions(ulong vaultId, ulong amountMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 6, 192, 73 };
            var vaultIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vaultIdAbi.From(vaultId);
            var amountMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountMicroStableAbi.From(amountMicroStable);

            return await base.MakeTransactionList(new List<object> { abiHandle, vaultIdAbi, amountMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29sbGF0ZXJhbFhTdGFibGVjb2luQ29udHJvbGxlciIsImRlc2MiOiJTdGFibGVjb2luIGNvbnRyb2wgbG9naWMuXG5cblNhZmV0eS1jcml0aWNhbCBhc3N1bXB0aW9uOiB0aGUgc3RhYmxlIEFTQSBoYXMgYSBmaXhlZCByZXNlcnZlIGhlbGQgYnkgdGhpc1xuYXBwIGFjY291bnQuIFRoZSBwcm90b2NvbCBtYW5hZ2VyIGlzIHRoZSBvbmx5IGNhbGxlciBhbGxvd2VkIHRvIG1vdmUgcmVzZXJ2ZVxudW5pdHMgdG8gdmF1bHQgb3duZXJzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdGFibGVjb2luQ29udHJvbFN0YXRlIjpbeyJuYW1lIjoiYWRtaW4iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImluaXRpYWxpemVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3RvY29sTWFuYWdlckFwcElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YWJsZUFzc2V0SWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNzdWVkU3VwcGx5TWljcm9TdGFibGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3VwcGx5Q2VpbGluZ01pY3JvU3RhYmxlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBhdXNlRmxhZ3MiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU3RhYmxlY29pbkFkbWluQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXRpYWxpemVTdGFibGVjb2luQ29udHJvbGxlciIsImRlc2MiOiJPbmUtdGltZSBzdGFibGVjb2luIGNvbnRyb2xsZXIgaW5pdGlhbGl6YXRpb24gYnkgYWRtaW4uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3RvY29sTWFuYWdlckFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFibGVBc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdXBwbHlDZWlsaW5nTWljcm9TdGFibGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN0YWJsZWNvaW5Db250cm9sbGVySW5pdGlhbGl6ZWRFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm90b2NvbE1hbmFnZXJBcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWJsZUFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdXBwbHlDZWlsaW5nTWljcm9TdGFibGUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWFkU3RhYmxlY29pbkNvbnRyb2xTdGF0ZSIsImRlc2MiOiJSZWFkIHN0YWJsZWNvaW4gY29udHJvbGxlciBzdGF0ZS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiU3RhYmxlY29pbkNvbnRyb2xTdGF0ZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRtaW5TZXRTdGFibGVjb2luQ29uZmlnIiwiZGVzYyI6IkFkbWluLW9ubHkgY29udHJvbGxlciBjb25maWd1cmF0aW9uIHVwZGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvdG9jb2xNYW5hZ2VyQXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWJsZUFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN1cHBseUNlaWxpbmdNaWNyb1N0YWJsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU3RhYmxlY29pbkNvbmZpZ1VwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZG1pblNldFBhdXNlRmxhZ3MiLCJkZXNjIjoiQWRtaW4tb25seSByZXBsYWNlbWVudCBvZiBzdGFibGVjb2luIGNvbnRyb2wgcGF1c2UgZmxhZ3MuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdXNlRmxhZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN0YWJsZWNvaW5QYXVzZUZsYWdzVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJblRvU3RhYmxlQXNzZXQiLCJkZXNjIjoiT3B0cyB0aGUgYXBwIGFjY291bnQgaW50byB0aGUgc3RhYmxlIEFTQSBzbyBpdCBjYW4gaG9sZCBtaW50IHJlc2VydmVzLlxuVGhlIGFwcCBhY2NvdW50IG11c3QgYmUgcHJlLWZ1bmRlZCBmb3IgdGhlIEFTQSBvcHQtaW4gTUJSIGFuZCBpbm5lciBmZWUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTdGFibGVjb2luQXNzZXRPcHRlZEluRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhYmxlQXNzZXRJZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRGb3JWYXVsdCIsImRlc2MiOiJNYW5hZ2VyLWF1dGhvcml6ZWQgcmVzZXJ2ZSB0cmFuc2ZlciB0byBhIHZhdWx0IG93bmVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YXVsdElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudE1pY3JvU3RhYmxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTdGFibGVjb2luTWludGVkRm9yVmF1bHRFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YXVsdElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50TWljcm9TdGFibGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc3N1ZWRTdXBwbHlNaWNyb1N0YWJsZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1cm5Gb3JWYXVsdCIsImRlc2MiOiJNYW5hZ2VyLWF1dGhvcml6ZWQgcmVwYXltZW50IGFjY291bnRpbmcuXG5cblRoZSBwcm90b2NvbCBtYW5hZ2VyIHZhbGlkYXRlcyB0aGUgZ3JvdXBlZCB1c2VyIEFTQSB0cmFuc2ZlciBpbnRvIHRoaXMgYXBwXG5iZWZvcmUgY2FsbGluZyB0aGlzIG1ldGhvZC4gVGhlIEFTQSB1bml0cyBhcmUgcmV0aXJlZCBieSByZXR1cm5pbmcgdGhlbSB0b1xudGhlIGNvbnRyb2xsZXIgcmVzZXJ2ZSBhbmQgZGVjcmVtZW50aW5nIGlzc3VlZCBwcm90b2NvbCBzdXBwbHkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhdWx0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudE1pY3JvU3RhYmxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTdGFibGVjb2luUmV0aXJlZEZvclZhdWx0RXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmF1bHRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudE1pY3JvU3RhYmxlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXNzdWVkU3VwcGx5TWljcm9TdGFibGUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzcxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5M10sImVycm9yTWVzc2FnZSI6ImFjY291bnQgb3B0ZWQgaW50byBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0MV0sImVycm9yTWVzc2FnZSI6ImFkbWluIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOiJhZG1pbiByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMl0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTldLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTFdLCJlcnJvck1lc3NhZ2UiOiJidXJuIGV4Y2VlZHMgaXNzdWVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0XSwiZXJyb3JNZXNzYWdlIjoiY2VpbGluZyBiZWxvdyBzdXBwbHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzddLCJlcnJvck1lc3NhZ2UiOiJjZWlsaW5nIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE3LDM2Nl0sImVycm9yTWVzc2FnZSI6ImNlaWxpbmcgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTAsMjYyLDI2NiwyNzAsMjc0LDI3OCwyODMsMjg4LDM3MCw0NTIsNTQwLDU0Niw1NzMsNjgzLDY4OCw3MjgsNzM5LDc0OCw3NzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTUsNTA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NCwxOTMsMjAyLDMzMywzNDMsMzUzLDQxNSw0OTcsNTE0LDY1Myw2NjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTNdLCJlcnJvck1lc3NhZ2UiOiJtYW5hZ2VyIGFwcCBvbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1LDM2NF0sImVycm9yTWVzc2FnZSI6Im1hbmFnZXIgYXBwIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzYxXSwiZXJyb3JNZXNzYWdlIjoibWFuYWdlciBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODZdLCJlcnJvck1lc3NhZ2UiOiJyZWNlaXZlciBhc3NldCBvcHQtaW4gcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzFdLCJlcnJvck1lc3NhZ2UiOiJyZWNlaXZlciByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1NCw1NDIsNjg0XSwiZXJyb3JNZXNzYWdlIjoic3RhYmxlIGFzc2V0IHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk3XSwiZXJyb3JNZXNzYWdlIjoic3RhYmxlIHJlc2VydmUgaW5zdWZmaWNpZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMxXSwiZXJyb3JNZXNzYWdlIjoic3RhYmxlY29pbiBjb250cm9sbGVyIG5vdCBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3NV0sImVycm9yTWVzc2FnZSI6InN0YWJsZWNvaW4gcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY3XSwiZXJyb3JNZXNzYWdlIjoidWludDY0IG92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjk2XSwiZXJyb3JNZXNzYWdlIjoidWludDY0IHVuZGVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNCw2NzddLCJlcnJvck1lc3NhZ2UiOiJ2YXVsdCBpZCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3OV0sImVycm9yTWVzc2FnZSI6Inplcm8gYnVybiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNl0sImVycm9yTWVzc2FnZSI6Inplcm8gbWludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ2dNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUZ6WVNJZ0luTjFjSEJzZVNJZ0ltbHVhWFFpSUNKdFozSWlJQ0pqWldsc0lpQWljR1pzWnlJZ0ltRmtiU0lLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oybHVhWFFuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYVc1cGRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdjSEp2ZEc5amIyeE5ZVzVoWjJWeVFYQndTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmJXZHlKeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTFuY2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z2MzUmhZbXhsUVhOelpYUkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaGMyRW5MQ0JwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWE5oSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCcGMzTjFaV1JUZFhCd2JIbE5hV055YjFOMFlXSnNaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkemRYQndiSGtuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzNWd2NHeDVJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJ6ZFhCd2JIbERaV2xzYVc1blRXbGpjbTlUZEdGaWJHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWTJWcGJDY3NJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpaV2xzSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCd1lYVnpaVVpzWVdkeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM0JtYkdjbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNHWnNaeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUTI5c2JHRjBaWEpoYkZoVGRHRmliR1ZqYjJsdVEyOXVkSEp2Ykd4bGNpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE13b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWTNZakF4TkRFeUlEQjRaV1k1WmpreU56UWdNSGcxTmpZNU5HTmxZaUF3ZUdZM1kyUTRPVGd3SURCNE9EazFOR00yT0RJZ01IZ3hNR1kzTmpRM05pQXdlRFJrTURaak1EUTVJQzh2SUcxbGRHaHZaQ0FpYVc1cGRHbGhiR2w2WlZOMFlXSnNaV052YVc1RGIyNTBjbTlzYkdWeUtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxZV1JUZEdGaWJHVmpiMmx1UTI5dWRISnZiRk4wWVhSbEtDa29ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltRmtiV2x1VTJWMFUzUmhZbXhsWTI5cGJrTnZibVpwWnloMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaFpHMXBibE5sZEZCaGRYTmxSbXhoWjNNb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3ZEVsdVZHOVRkR0ZpYkdWQmMzTmxkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWliV2x1ZEVadmNsWmhkV3gwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaWRYSnVSbTl5Vm1GMWJIUW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYVc1cGRHbGhiR2w2WlZOMFlXSnNaV052YVc1RGIyNTBjbTlzYkdWeUlISmxZV1JUZEdGaWJHVmpiMmx1UTI5dWRISnZiRk4wWVhSbElHRmtiV2x1VTJWMFUzUmhZbXhsWTI5cGJrTnZibVpwWnlCaFpHMXBibE5sZEZCaGRYTmxSbXhoWjNNZ2IzQjBTVzVVYjFOMFlXSnNaVUZ6YzJWMElHMXBiblJHYjNKV1lYVnNkQ0JpZFhKdVJtOXlWbUYxYkhRS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGIyeHNZWFJsY21Gc1dGTjBZV0pzWldOdmFXNURiMjUwY205c2JHVnlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaRE15TkdKbFlUUWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWhoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEyOXNiR0YwWlhKaGJGaFRkR0ZpYkdWamIybHVRMjl1ZEhKdmJHeGxjaTVqY21WaGRHVkJjSEJzYVdOaGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dGa2JXbHVJQ0U5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0lDZGhaRzFwYmlCeVpYRjFhWEpsWkNjcENpQWdJQ0JrZFhBS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaFpHMXBiaUJ5WlhGMWFYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjJGa2JTY2dmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUZrYlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklIUm9hWE11WVdSdGFXNHVkbUZzZFdVZ1BTQmhaRzFwYmdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzNDaUFnSUNBdkx5QmxiV2wwS0NkVGRHRmliR1ZqYjJsdVFXUnRhVzVEY21WaGRHVmtKeXdnWVdSdGFXNHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lZV014WmprM05DQXZMeUJ0WlhSb2IyUWdJbE4wWVdKc1pXTnZhVzVCWkcxcGJrTnlaV0YwWldRb1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERiMnhzWVhSbGNtRnNXRk4wWVdKc1pXTnZhVzVEYjI1MGNtOXNiR1Z5TG1sdWFYUnBZV3hwZW1WVGRHRmliR1ZqYjJsdVEyOXVkSEp2Ykd4bGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx1YVhScFlXeHBlbVZUZEdGaWJHVmpiMmx1UTI5dWRISnZiR3hsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ERXRPRFVLSUNBZ0lDOHZJSEIxWW14cFl5QnBibWwwYVdGc2FYcGxVM1JoWW14bFkyOXBia052Ym5SeWIyeHNaWElvQ2lBZ0lDQXZMeUFnSUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lITjBZV0pzWlVGemMyVjBTV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYzNWd2NHeDVRMlZwYkdsdVowMXBZM0p2VTNSaFlteGxPaUIxYVc1ME5qUUtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJCWkcxcGJpZ3BDaUFnSUNCallXeHNjM1ZpSUdGemMyVnlkRUZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaU0E5UFQwZ1ZXbHVkRFkwS0RBcExDQW5ZV3h5WldGa2VTQnBibWwwYVdGc2FYcGxaQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnYVc1cGRHbGhiR2w2WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5hVzVwZENjc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKcGJtbDBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVZ1BUMDlJRlZwYm5RMk5DZ3dLU3dnSjJGc2NtVmhaSGtnYVc1cGRHbGhiR2w2WldRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhiSEpsWVdSNUlHbHVhWFJwWVd4cGVtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTWdvZ0lDQWdMeThnWVhOelpYSjBLSEJ5YjNSdlkyOXNUV0Z1WVdkbGNrRndjRWxrSUQ0Z1ZXbHVkRFkwS0RBcExDQW5iV0Z1WVdkbGNpQmhjSEFnY21WeGRXbHlaV1FuS1FvZ0lDQWdaR2xuSURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJ0WVc1aFoyVnlJR0Z3Y0NCeVpYRjFhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5ETUtJQ0FnSUM4dklHRnpjMlZ5ZENoemRYQndiSGxEWldsc2FXNW5UV2xqY205VGRHRmliR1VnUGlCVmFXNTBOalFvTUNrc0lDZGpaV2xzYVc1bklISmxjWFZwY21Wa0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUdObGFXeHBibWNnY21WeGRXbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMjFuY2ljc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKdFozSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUIwYUdsekxuQnliM1J2WTI5c1RXRnVZV2RsY2tGd2NFbGtMblpoYkhWbElEMGdjSEp2ZEc5amIyeE5ZVzVoWjJWeVFYQndTV1FLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z2MzUmhZbXhsUVhOelpYUkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaGMyRW5MQ0JwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZWE5oSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGaWJHVkJjM05sZEVsa0xuWmhiSFZsSUQwZ2MzUmhZbXhsUVhOelpYUkpaQW9nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCemRYQndiSGxEWldsc2FXNW5UV2xqY205VGRHRmliR1VnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBblkyVnBiQ2NzSUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pqWldsc0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdkR2hwY3k1emRYQndiSGxEWldsc2FXNW5UV2xqY205VGRHRmliR1V1ZG1Gc2RXVWdQU0J6ZFhCd2JIbERaV2xzYVc1blRXbGpjbTlUZEdGaWJHVUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnYVc1cGRHbGhiR2w2WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5hVzVwZENjc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKcGJtbDBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTQTlJRlZwYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJoWkcxcGJqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVE10T1RnS0lDQWdJQzh2SUdWdGFYUThVM1JoWW14bFkyOXBia052Ym5SeWIyeHNaWEpKYm1sMGFXRnNhWHBsWkVWMlpXNTBQaWg3Q2lBZ0lDQXZMeUFnSUdGa2JXbHVPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCd2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpDd0tJQ0FnSUM4dklDQWdjM1JoWW14bFFYTnpaWFJKWkN3S0lDQWdJQzh2SUNBZ2MzVndjR3g1UTJWcGJHbHVaMDFwWTNKdlUzUmhZbXhsTEFvZ0lDQWdMeThnZlNrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqTnpZM056QmtNeUF2THlCdFpYUm9iMlFnSWxOMFlXSnNaV052YVc1RGIyNTBjbTlzYkdWeVNXNXBkR2xoYkdsNlpXUkZkbVZ1ZENoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd4TFRnMUNpQWdJQ0F2THlCd2RXSnNhV01nYVc1cGRHbGhiR2w2WlZOMFlXSnNaV052YVc1RGIyNTBjbTlzYkdWeUtBb2dJQ0FnTHk4Z0lDQndjbTkwYjJOdmJFMWhibUZuWlhKQmNIQkpaRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J6ZEdGaWJHVkJjM05sZEVsa09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lITjFjSEJzZVVObGFXeHBibWROYVdOeWIxTjBZV0pzWlRvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjJ4c1lYUmxjbUZzV0ZOMFlXSnNaV052YVc1RGIyNTBjbTlzYkdWeUxuSmxZV1JUZEdGaWJHVmpiMmx1UTI5dWRISnZiRk4wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZoWkZOMFlXSnNaV052YVc1RGIyNTBjbTlzVTNSaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TlFvZ0lDQWdMeThnWVdSdGFXNDZJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMkZrYlNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltRmtiU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCaFpHMXBiam9nZEdocGN5NWhaRzFwYmk1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnYVc1cGRHbGhiR2w2WldRNklIUm9hWE11YVc1cGRHbGhiR2w2WldRdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnYVc1cGRHbGhiR2w2WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5hVzVwZENjc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKcGJtbDBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURZS0lDQWdJQzh2SUdsdWFYUnBZV3hwZW1Wa09pQjBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCd2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpEb2dkR2hwY3k1d2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpDNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCd2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R0WjNJbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJXZHlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURjS0lDQWdJQzh2SUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjBhR2x6TG5CeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0xuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCemRHRmliR1ZCYzNObGRFbGtPaUIwYUdsekxuTjBZV0pzWlVGemMyVjBTV1F1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdjM1JoWW14bFFYTnpaWFJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGhjMkVuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVhOaElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGdLSUNBZ0lDOHZJSE4wWVdKc1pVRnpjMlYwU1dRNklIUm9hWE11YzNSaFlteGxRWE56WlhSSlpDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd09Rb2dJQ0FnTHk4Z2FYTnpkV1ZrVTNWd2NHeDVUV2xqY205VGRHRmliR1U2SUhSb2FYTXVhWE56ZFdWa1UzVndjR3g1VFdsamNtOVRkR0ZpYkdVdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnYVhOemRXVmtVM1Z3Y0d4NVRXbGpjbTlUZEdGaWJHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYzNWd2NHeDVKeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk4xY0hCc2VTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUJwYzNOMVpXUlRkWEJ3YkhsTmFXTnliMU4wWVdKc1pUb2dkR2hwY3k1cGMzTjFaV1JUZFhCd2JIbE5hV055YjFOMFlXSnNaUzUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdjM1Z3Y0d4NVEyVnBiR2x1WjAxcFkzSnZVM1JoWW14bE9pQjBhR2x6TG5OMWNIQnNlVU5sYVd4cGJtZE5hV055YjFOMFlXSnNaUzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnpkWEJ3YkhsRFpXbHNhVzVuVFdsamNtOVRkR0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZMlZwYkNjc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKalpXbHNJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUhOMWNIQnNlVU5sYVd4cGJtZE5hV055YjFOMFlXSnNaVG9nZEdocGN5NXpkWEJ3YkhsRFpXbHNhVzVuVFdsamNtOVRkR0ZpYkdVdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUhCaGRYTmxSbXhoWjNNNklIUm9hWE11Y0dGMWMyVkdiR0ZuY3k1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUJ3WVhWelpVWnNZV2R6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozQm1iR2NuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpY0dac1p5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJ3WVhWelpVWnNZV2R6T2lCMGFHbHpMbkJoZFhObFJteGhaM011ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFF0TVRFeUNpQWdJQ0F2THlCeVpYUjFjbTRnZXdvZ0lDQWdMeThnSUNCaFpHMXBiam9nZEdocGN5NWhaRzFwYmk1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnYVc1cGRHbGhiR2w2WldRNklIUm9hWE11YVc1cGRHbGhiR2w2WldRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjBhR2x6TG5CeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNCemRHRmliR1ZCYzNObGRFbGtPaUIwYUdsekxuTjBZV0pzWlVGemMyVjBTV1F1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR2x6YzNWbFpGTjFjSEJzZVUxcFkzSnZVM1JoWW14bE9pQjBhR2x6TG1semMzVmxaRk4xY0hCc2VVMXBZM0p2VTNSaFlteGxMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQnpkWEJ3YkhsRFpXbHNhVzVuVFdsamNtOVRkR0ZpYkdVNklIUm9hWE11YzNWd2NHeDVRMlZwYkdsdVowMXBZM0p2VTNSaFlteGxMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQndZWFZ6WlVac1lXZHpPaUIwYUdsekxuQmhkWE5sUm14aFozTXVkbUZzZFdVc0NpQWdJQ0F2THlCOUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01pMHhNRE1LSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklISmxZV1JUZEdGaWJHVmpiMmx1UTI5dWRISnZiRk4wWVhSbEtDazZJRk4wWVdKc1pXTnZhVzVEYjI1MGNtOXNVM1JoZEdVZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEyOXNiR0YwWlhKaGJGaFRkR0ZpYkdWamIybHVRMjl1ZEhKdmJHeGxjaTVoWkcxcGJsTmxkRk4wWVdKc1pXTnZhVzVEYjI1bWFXZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkcxcGJsTmxkRk4wWVdKc1pXTnZhVzVEYjI1bWFXYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TmkweE1qQUtJQ0FnSUM4dklIQjFZbXhwWXlCaFpHMXBibE5sZEZOMFlXSnNaV052YVc1RGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lITjBZV0pzWlVGemMyVjBTV1E2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYzNWd2NHeDVRMlZwYkdsdVowMXBZM0p2VTNSaFlteGxPaUIxYVc1ME5qUUtJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklIUm9hWE11WVhOelpYSjBVbVZoWkhrb0tRb2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUlNaV0ZrZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qSUtJQ0FnSUM4dklIUm9hWE11WVhOelpYSjBRV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUkJaRzFwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5ESUtJQ0FnSUM4dklHRnpjMlZ5ZENod2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpDQStJRlZwYm5RMk5DZ3dLU3dnSjIxaGJtRm5aWElnWVhCd0lISmxjWFZwY21Wa0p5a0tJQ0FnSUdScFp5QTBDaUFnSUNCaGMzTmxjblFnTHk4Z2JXRnVZV2RsY2lCaGNIQWdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9jM1Z3Y0d4NVEyVnBiR2x1WjAxcFkzSnZVM1JoWW14bElENGdWV2x1ZERZMEtEQXBMQ0FuWTJWcGJHbHVaeUJ5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpaV2xzYVc1bklISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YVhOemRXVmtVM1Z3Y0d4NVRXbGpjbTlUZEdGaWJHVXVkbUZzZFdVZ1BEMGdjM1Z3Y0d4NVEyVnBiR2x1WjAxcFkzSnZVM1JoWW14bExDQW5ZMlZwYkdsdVp5QmlaV3h2ZHlCemRYQndiSGtuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUdsemMzVmxaRk4xY0hCc2VVMXBZM0p2VTNSaFlteGxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNOMWNIQnNlU2NzSUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6ZFhCd2JIa2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWFYTnpkV1ZrVTNWd2NHeDVUV2xqY205VGRHRmliR1V1ZG1Gc2RXVWdQRDBnYzNWd2NHeDVRMlZwYkdsdVowMXBZM0p2VTNSaFlteGxMQ0FuWTJWcGJHbHVaeUJpWld4dmR5QnpkWEJ3YkhrbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJR05sYVd4cGJtY2dZbVZzYjNjZ2MzVndjR3g1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCd2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R0WjNJbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJXZHlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpVS0lDQWdJQzh2SUhSb2FYTXVjSEp2ZEc5amIyeE5ZVzVoWjJWeVFYQndTV1F1ZG1Gc2RXVWdQU0J3Y205MGIyTnZiRTFoYm1GblpYSkJjSEJKWkFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnYzNSaFlteGxRWE56WlhSSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2RoYzJFbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlYTmhJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpZS0lDQWdJQzh2SUhSb2FYTXVjM1JoWW14bFFYTnpaWFJKWkM1MllXeDFaU0E5SUhOMFlXSnNaVUZ6YzJWMFNXUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklITjFjSEJzZVVObGFXeHBibWROYVdOeWIxTjBZV0pzWlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGpaV2xzSnl3Z2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1ObGFXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TndvZ0lDQWdMeThnZEdocGN5NXpkWEJ3YkhsRFpXbHNhVzVuVFdsamNtOVRkR0ZpYkdVdWRtRnNkV1VnUFNCemRYQndiSGxEWldsc2FXNW5UV2xqY205VGRHRmliR1VLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z1pXMXBkQ2duVTNSaFlteGxZMjlwYmtOdmJtWnBaMVZ3WkdGMFpXUW5MQ0JVZUc0dWMyVnVaR1Z5TENCd2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpDd2djM1JoWW14bFFYTnpaWFJKWkN3Z2MzVndjR3g1UTJWcGJHbHVaMDFwWTNKdlUzUmhZbXhsS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQTJNMlZqTWpjMklDOHZJRzFsZEdodlpDQWlVM1JoWW14bFkyOXBia052Ym1acFoxVndaR0YwWldRb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRZdE1USXdDaUFnSUNBdkx5QndkV0pzYVdNZ1lXUnRhVzVUWlhSVGRHRmliR1ZqYjJsdVEyOXVabWxuS0FvZ0lDQWdMeThnSUNCd2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQnpkR0ZpYkdWQmMzTmxkRWxrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhOMWNIQnNlVU5sYVd4cGJtZE5hV055YjFOMFlXSnNaVG9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERiMnhzWVhSbGNtRnNXRk4wWVdKc1pXTnZhVzVEYjI1MGNtOXNiR1Z5TG1Ga2JXbHVVMlYwVUdGMWMyVkdiR0ZuYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtiV2x1VTJWMFVHRjFjMlZHYkdGbmN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZV1J0YVc1VFpYUlFZWFZ6WlVac1lXZHpLSEJoZFhObFJteGhaM002SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek13b2dJQ0FnTHk4Z2RHaHBjeTVoYzNObGNuUlNaV0ZrZVNncENpQWdJQ0JqWVd4c2MzVmlJR0Z6YzJWeWRGSmxZV1I1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5Bb2dJQ0FnTHk4Z2RHaHBjeTVoYzNObGNuUkJaRzFwYmlncENpQWdJQ0JqWVd4c2MzVmlJR0Z6YzJWeWRFRmtiV2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCd1lYVnpaVVpzWVdkeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM0JtYkdjbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNHWnNaeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCMGFHbHpMbkJoZFhObFJteGhaM011ZG1Gc2RXVWdQU0J3WVhWelpVWnNZV2R6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16WUtJQ0FnSUM4dklHVnRhWFFvSjFOMFlXSnNaV052YVc1UVlYVnpaVVpzWVdkelZYQmtZWFJsWkNjc0lGUjRiaTV6Wlc1a1pYSXNJSEJoZFhObFJteGhaM01wQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TkdKbU9UTTJJQzh2SUcxbGRHaHZaQ0FpVTNSaFlteGxZMjlwYmxCaGRYTmxSbXhoWjNOVmNHUmhkR1ZrS0dGa1pISmxjM01zZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdGa2JXbHVVMlYwVUdGMWMyVkdiR0ZuY3lod1lYVnpaVVpzWVdkek9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGIyeHNZWFJsY21Gc1dGTjBZV0pzWldOdmFXNURiMjUwY205c2JHVnlMbTl3ZEVsdVZHOVRkR0ZpYkdWQmMzTmxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205d2RFbHVWRzlUZEdGaWJHVkJjM05sZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTBDaUFnSUNBdkx5QjBhR2x6TG1GemMyVnlkRkpsWVdSNUtDa0tJQ0FnSUdOaGJHeHpkV0lnWVhOelpYSjBVbVZoWkhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTFDaUFnSUNBdkx5QjBhR2x6TG1GemMyVnlkRUZrYldsdUtDa0tJQ0FnSUdOaGJHeHpkV0lnWVhOelpYSjBRV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTJDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV6ZEdGaWJHVkJjM05sZEVsa0xuWmhiSFZsSUQ0Z1ZXbHVkRFkwS0RBcExDQW5jM1JoWW14bElHRnpjMlYwSUhKbGNYVnBjbVZrSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCemRHRmliR1ZCYzNObGRFbGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJGellTY3NJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhjMkVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjM1JoWW14bFFYTnpaWFJKWkM1MllXeDFaU0ErSUZWcGJuUTJOQ2d3S1N3Z0ozTjBZV0pzWlNCaGMzTmxkQ0J5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z2MzUmhZbXhsSUdGemMyVjBJSEpsY1hWcGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0MweE5UVUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ2MzUmhZbXhsUVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNUW9nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5USUtJQ0FnSUM4dklHRnpjMlYwUVcxdmRXNTBPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0MweE5UUUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ2MzUmhZbXhsUVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNd29nSUNBZ0x5OGdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTRMVEUxTlFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJ6ZEdGaWJHVkJjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU53b2dJQ0FnTHk4Z1lXUnRhVzQ2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5pMHhOVGtLSUNBZ0lDOHZJR1Z0YVhROFUzUmhZbXhsWTI5cGJrRnpjMlYwVDNCMFpXUkpia1YyWlc1MFBpaDdDaUFnSUNBdkx5QWdJR0ZrYldsdU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J6ZEdGaWJHVkJjM05sZEVsa09pQjBhR2x6TG5OMFlXSnNaVUZ6YzJWMFNXUXVkbUZzZFdVc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtaV05oWXpKbU9TQXZMeUJ0WlhSb2IyUWdJbE4wWVdKc1pXTnZhVzVCYzNObGRFOXdkR1ZrU1c1RmRtVnVkQ2hoWkdSeVpYTnpMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRNS0lDQWdJQzh2SUhCMVlteHBZeUJ2Y0hSSmJsUnZVM1JoWW14bFFYTnpaWFFvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTI5c2JHRjBaWEpoYkZoVGRHRmliR1ZqYjJsdVEyOXVkSEp2Ykd4bGNpNXRhVzUwUm05eVZtRjFiSFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdGFXNTBSbTl5Vm1GMWJIUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTXdvZ0lDQWdMeThnY0hWaWJHbGpJRzFwYm5SR2IzSldZWFZzZENoMllYVnNkRWxrT2lCMWFXNTBOalFzSUhKbFkyVnBkbVZ5T2lCQlkyTnZkVzUwTENCaGJXOTFiblJOYVdOeWIxTjBZV0pzWlRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkwQ2lBZ0lDQXZMeUIwYUdsekxtRnpjMlZ5ZEZKbFlXUjVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYTnpaWEowVW1WaFpIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkxQ2lBZ0lDQXZMeUIwYUdsekxtRnpjMlZ5ZEUxaGJtRm5aWEpEWVd4c1pYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGMzTmxjblJOWVc1aFoyVnlRMkZzYkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOZ29nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJPYjNSUVlYVnpaV1FvVUVGVlUwVmZUVWxPVkNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlZ5ZEU1dmRGQmhkWE5sWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENoeVpXTmxhWFpsY2lBaFBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQ0FuY21WalpXbDJaWElnY21WeGRXbHlaV1FuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCeVpXTmxhWFpsY2lCeVpYRjFhWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMllYVnNkRWxrSUQ0Z1ZXbHVkRFkwS0RBcExDQW5kbUYxYkhRZ2FXUWdjbVZ4ZFdseVpXUW5LUW9nSUNBZ1pHbG5JRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QjJZWFZzZENCcFpDQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamtLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhiVzkxYm5STmFXTnliMU4wWVdKc1pTQStJRlZwYm5RMk5DZ3dLU3dnSjNwbGNtOGdiV2x1ZENjcENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUI2WlhKdklHMXBiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjd0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXpkR0ZpYkdWQmMzTmxkRWxrTG5aaGJIVmxJRDRnVldsdWREWTBLREFwTENBbmMzUmhZbXhsSUdGemMyVjBJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJ6ZEdGaWJHVkJjM05sZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMkZ6WVNjc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGMyRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWMzUmhZbXhsUVhOelpYUkpaQzUyWVd4MVpTQStJRlZwYm5RMk5DZ3dLU3dnSjNOMFlXSnNaU0JoYzNObGRDQnlaWEYxYVhKbFpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnYzNSaFlteGxJR0Z6YzJWMElISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNZ29nSUNBZ0x5OGdZMjl1YzNRZ2JtVjNTWE56ZFdWa1UzVndjR3g1SUQwZ2MyRm1aVUZrWkNoMGFHbHpMbWx6YzNWbFpGTjFjSEJzZVUxcFkzSnZVM1JoWW14bExuWmhiSFZsTENCaGJXOTFiblJOYVdOeWIxTjBZV0pzWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCcGMzTjFaV1JUZFhCd2JIbE5hV055YjFOMFlXSnNaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkemRYQndiSGtuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzNWd2NHeDVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpJS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDBsemMzVmxaRk4xY0hCc2VTQTlJSE5oWm1WQlpHUW9kR2hwY3k1cGMzTjFaV1JUZFhCd2JIbE5hV055YjFOMFlXSnNaUzUyWVd4MVpTd2dZVzF2ZFc1MFRXbGpjbTlUZEdGaWJHVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTm9ZWEpsWkM5eWFYTnJMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJSEpsZEhWeWJpQmlhV2RVYjFWcGJuUTJOQ2hDYVdkVmFXNTBLR3hsWm5RcElDc2dRbWxuVldsdWRDaHlhV2RvZENrcENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdJckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMyaGhjbVZrTDNKcGMyc3VZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdZWE56WlhKMEtIWmhiSFZsSUR3OUlFSnBaMVZwYm5Rb1ZXbHVkRFkwTGsxQldGOVdRVXhWUlNrc0lDZDFhVzUwTmpRZ2IzWmxjbVpzYjNjbktRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjFhVzUwTmpRZ2IzWmxjbVpzYjNjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emFHRnlaV1F2Y21semF5NWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVZblJ2YVNoQ2VYUmxjeWgyWVd4MVpTa3BDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnWVhOelpYSjBLRzVsZDBsemMzVmxaRk4xY0hCc2VTQThQU0IwYUdsekxuTjFjSEJzZVVObGFXeHBibWROYVdOeWIxTjBZV0pzWlM1MllXeDFaU3dnSjJObGFXeHBibWNnWlhoalpXVmtaV1FuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUhOMWNIQnNlVU5sYVd4cGJtZE5hV055YjFOMFlXSnNaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkalpXbHNKeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbU5sYVd3aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdZWE56WlhKMEtHNWxkMGx6YzNWbFpGTjFjSEJzZVNBOFBTQjBhR2x6TG5OMWNIQnNlVU5sYVd4cGJtZE5hV055YjFOMFlXSnNaUzUyWVd4MVpTd2dKMk5sYVd4cGJtY2daWGhqWldWa1pXUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdObGFXeHBibWNnWlhoalpXVmtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMkNpQWdJQ0F2THlCaGMzTmxjblFvY21WalpXbDJaWEl1YVhOUGNIUmxaRWx1S0hOMFlXSnNaVUZ6YzJWMEtTd2dKM0psWTJWcGRtVnlJR0Z6YzJWMElHOXdkQzFwYmlCeVpYRjFhWEpsWkNjcENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklETUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2NtVmpaV2wyWlhJZ1lYTnpaWFFnYjNCMExXbHVJSEpsY1hWcGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTndvZ0lDQWdMeThnWVhOelpYSjBLSE4wWVdKc1pVRnpjMlYwTG1KaGJHRnVZMlVvUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXBJRDQ5SUdGdGIzVnVkRTFwWTNKdlUzUmhZbXhsTENBbmMzUmhZbXhsSUhKbGMyVnlkbVVnYVc1emRXWm1hV05wWlc1MEp5a0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2FXY2dNd29nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCdmNIUmxaQ0JwYm5SdklHRnpjMlYwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnpkR0ZpYkdVZ2NtVnpaWEoyWlNCcGJuTjFabVpwWTJsbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGM1TFRFNE5nb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCemRHRmliR1ZCYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQnlaV05sYVhabGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1lXMXZkVzUwVFdsamNtOVRkR0ZpYkdVc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lCVmFXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzT1MweE9EVUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ2MzUmhZbXhsUVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2djbVZqWldsMlpYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklHRnRiM1Z1ZEUxcFkzSnZVM1JoWW14bExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcwQ2lBZ0lDQXZMeUJtWldVNklGVnBiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOemt0TVRnMkNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUhOMFlXSnNaVUZ6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMlZwZG1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCaGJXOTFiblJOYVdOeWIxTjBZV0pzWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdhWE56ZFdWa1UzVndjR3g1VFdsamNtOVRkR0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jM1Z3Y0d4NUp5d2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luTjFjSEJzZVNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzRDaUFnSUNBdkx5QjBhR2x6TG1semMzVmxaRk4xY0hCc2VVMXBZM0p2VTNSaFlteGxMblpoYkhWbElEMGdibVYzU1hOemRXVmtVM1Z3Y0d4NUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGc1TFRFNU5Bb2dJQ0FnTHk4Z1pXMXBkRHhUZEdGaWJHVmpiMmx1VFdsdWRHVmtSbTl5Vm1GMWJIUkZkbVZ1ZEQ0b2V3b2dJQ0FnTHk4Z0lDQjJZWFZzZEVsa0xBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNpd0tJQ0FnSUM4dklDQWdZVzF2ZFc1MFRXbGpjbTlUZEdGaWJHVXNDaUFnSUNBdkx5QWdJR2x6YzNWbFpGTjFjSEJzZVUxcFkzSnZVM1JoWW14bE9pQnVaWGRKYzNOMVpXUlRkWEJ3Ykhrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRFF6WlRsa05ERWdMeThnYldWMGFHOWtJQ0pUZEdGaWJHVmpiMmx1VFdsdWRHVmtSbTl5Vm1GMWJIUkZkbVZ1ZENoMWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTXdvZ0lDQWdMeThnY0hWaWJHbGpJRzFwYm5SR2IzSldZWFZzZENoMllYVnNkRWxrT2lCMWFXNTBOalFzSUhKbFkyVnBkbVZ5T2lCQlkyTnZkVzUwTENCaGJXOTFiblJOYVdOeWIxTjBZV0pzWlRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTI5c2JHRjBaWEpoYkZoVGRHRmliR1ZqYjJsdVEyOXVkSEp2Ykd4bGNpNWlkWEp1Um05eVZtRjFiSFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWRYSnVSbTl5Vm1GMWJIUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TkFvZ0lDQWdMeThnY0hWaWJHbGpJR0oxY201R2IzSldZWFZzZENoMllYVnNkRWxrT2lCMWFXNTBOalFzSUdGdGIzVnVkRTFwWTNKdlUzUmhZbXhsT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakExQ2lBZ0lDQXZMeUIwYUdsekxtRnpjMlZ5ZEZKbFlXUjVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYTnpaWEowVW1WaFpIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakEyQ2lBZ0lDQXZMeUIwYUdsekxtRnpjMlZ5ZEUxaGJtRm5aWEpEWVd4c1pYSW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGMzTmxjblJOWVc1aFoyVnlRMkZzYkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOd29nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJPYjNSUVlYVnpaV1FvVUVGVlUwVmZRbFZTVGlrS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0JqWVd4c2MzVmlJR0Z6YzJWeWRFNXZkRkJoZFhObFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDJZWFZzZEVsa0lENGdWV2x1ZERZMEtEQXBMQ0FuZG1GMWJIUWdhV1FnY21WeGRXbHlaV1FuS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0Z6YzJWeWRDQXZMeUIyWVhWc2RDQnBaQ0J5WlhGMWFYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURrS0lDQWdJQzh2SUdGemMyVnlkQ2hoYlc5MWJuUk5hV055YjFOMFlXSnNaU0ErSUZWcGJuUTJOQ2d3S1N3Z0ozcGxjbThnWW5WeWJpY3BDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCNlpYSnZJR0oxY200S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRXdDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV6ZEdGaWJHVkJjM05sZEVsa0xuWmhiSFZsSUQ0Z1ZXbHVkRFkwS0RBcExDQW5jM1JoWW14bElHRnpjMlYwSUhKbGNYVnBjbVZrSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCemRHRmliR1ZCYzNObGRFbGtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJGellTY3NJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhjMkVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYzNSaFlteGxZMjlwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjM1JoWW14bFFYTnpaWFJKWkM1MllXeDFaU0ErSUZWcGJuUTJOQ2d3S1N3Z0ozTjBZV0pzWlNCaGMzTmxkQ0J5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklITjBZV0pzWlNCaGMzTmxkQ0J5WlhGMWFYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRFS0lDQWdJQzh2SUdGemMyVnlkQ2hoYlc5MWJuUk5hV055YjFOMFlXSnNaU0E4UFNCMGFHbHpMbWx6YzNWbFpGTjFjSEJzZVUxcFkzSnZVM1JoWW14bExuWmhiSFZsTENBblluVnliaUJsZUdObFpXUnpJR2x6YzNWbFpDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdhWE56ZFdWa1UzVndjR3g1VFdsamNtOVRkR0ZpYkdVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jM1Z3Y0d4NUp5d2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luTjFjSEJzZVNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRXhDaUFnSUNBdkx5QmhjM05sY25Rb1lXMXZkVzUwVFdsamNtOVRkR0ZpYkdVZ1BEMGdkR2hwY3k1cGMzTjFaV1JUZFhCd2JIbE5hV055YjFOMFlXSnNaUzUyWVd4MVpTd2dKMkoxY200Z1pYaGpaV1ZrY3lCcGMzTjFaV1FuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHUjFjRElLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1luVnliaUJsZUdObFpXUnpJR2x6YzNWbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTm9ZWEpsWkM5eWFYTnJMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR0Z6YzJWeWRDaHNaV1owSUQ0OUlISnBaMmgwTENBbmRXbHVkRFkwSUhWdVpHVnlabXh2ZHljcENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJSFZwYm5RMk5DQjFibVJsY21ac2IzY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXphR0Z5WldRdmNtbHpheTVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdiR1ZtZENBdElISnBaMmgwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYM04wWVdKc1pXTnZhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnYVhOemRXVmtVM1Z3Y0d4NVRXbGpjbTlUZEdGaWJHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYzNWd2NHeDVKeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk4xY0hCc2VTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakUwQ2lBZ0lDQXZMeUIwYUdsekxtbHpjM1ZsWkZOMWNIQnNlVTFwWTNKdlUzUmhZbXhsTG5aaGJIVmxJRDBnYm1WM1NYTnpkV1ZrVTNWd2NHeDVDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFMUxUSXhPUW9nSUNBZ0x5OGdaVzFwZER4VGRHRmliR1ZqYjJsdVVtVjBhWEpsWkVadmNsWmhkV3gwUlhabGJuUStLSHNLSUNBZ0lDOHZJQ0FnZG1GMWJIUkpaQ3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBUV2xqY205VGRHRmliR1VzQ2lBZ0lDQXZMeUFnSUdsemMzVmxaRk4xY0hCc2VVMXBZM0p2VTNSaFlteGxPaUJ1WlhkSmMzTjFaV1JUZFhCd2JIa3NDaUFnSUNBdkx5QjlLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFltSTFaakF4WmlBdkx5QnRaWFJvYjJRZ0lsTjBZV0pzWldOdmFXNVNaWFJwY21Wa1JtOXlWbUYxYkhSRmRtVnVkQ2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRFFLSUNBZ0lDOHZJSEIxWW14cFl5QmlkWEp1Um05eVZtRjFiSFFvZG1GMWJIUkpaRG9nZFdsdWREWTBMQ0JoYlc5MWJuUk5hV055YjFOMFlXSnNaVG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRMjlzYkdGMFpYSmhiRmhUZEdGaWJHVmpiMmx1UTI5dWRISnZiR3hsY2k1aGMzTmxjblJTWldGa2VTZ3BJQzArSUhadmFXUTZDbUZ6YzJWeWRGSmxZV1I1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qTUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWx1YVhScFlXeHBlbVZrTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTVNrc0lDZHpkR0ZpYkdWamIybHVJR052Ym5SeWIyeHNaWElnYm05MElHbHVhWFJwWVd4cGVtVmtKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJwYm1sMGFXRnNhWHBsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHBibWwwSnl3Z2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1sdWFYUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVZ1BUMDlJRlZwYm5RMk5DZ3hLU3dnSjNOMFlXSnNaV052YVc0Z1kyOXVkSEp2Ykd4bGNpQnViM1FnYVc1cGRHbGhiR2w2WldRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklITjBZV0pzWldOdmFXNGdZMjl1ZEhKdmJHeGxjaUJ1YjNRZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa052Ykd4aGRHVnlZV3hZVTNSaFlteGxZMjlwYmtOdmJuUnliMnhzWlhJdVlYTnpaWEowUVdSdGFXNG9LU0F0UGlCMmIybGtPZ3BoYzNObGNuUkJaRzFwYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTNDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWhaRzFwYmk1MllXeDFaU3dnSjJGa2JXbHVJRzl1YkhrbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdGa2JXbHVJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUNkaFpHMG5JSDBwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poWkcwaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlOd29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VzSUNkaFpHMXBiaUJ2Ym14NUp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0ZrYldsdUlHOXViSGtLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOdmJHeGhkR1Z5WVd4WVUzUmhZbXhsWTI5cGJrTnZiblJ5YjJ4c1pYSXVZWE56WlhKMFRXRnVZV2RsY2tOaGJHeGxjaWdwSUMwK0lIWnZhV1E2Q21GemMyVnlkRTFoYm1GblpYSkRZV3hzWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmMzUmhZbXhsWTI5cGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpNUW9nSUNBZ0x5OGdZWE56WlhKMEtFZHNiMkpoYkM1allXeHNaWEpCY0hCc2FXTmhkR2x2Ymtsa0lEMDlQU0IwYUdsekxuQnliM1J2WTI5c1RXRnVZV2RsY2tGd2NFbGtMblpoYkhWbExDQW5iV0Z1WVdkbGNpQmhjSEFnYjI1c2VTY3BDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjl6ZEdGaWJHVmpiMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMjFuY2ljc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKdFozSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TVFvZ0lDQWdMeThnWVhOelpYSjBLRWRzYjJKaGJDNWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrbGtJRDA5UFNCMGFHbHpMbkJ5YjNSdlkyOXNUV0Z1WVdkbGNrRndjRWxrTG5aaGJIVmxMQ0FuYldGdVlXZGxjaUJoY0hBZ2IyNXNlU2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JXRnVZV2RsY2lCaGNIQWdiMjVzZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16TUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0J0WVc1aFoyVnlRWEJ3TG1Ga1pISmxjM01zSUNkdFlXNWhaMlZ5SUhObGJtUmxjaUJ0YVhOdFlYUmphQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUcxaGJtRm5aWElnYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZjM1JoWW14bFkyOXBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjJ4c1lYUmxjbUZzV0ZOMFlXSnNaV052YVc1RGIyNTBjbTlzYkdWeUxtRnpjMlZ5ZEU1dmRGQmhkWE5sWkNobWJHRm5PaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbUZ6YzJWeWRFNXZkRkJoZFhObFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXpkR0ZpYkdWamIybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0yQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJR0Z6YzJWeWRFNXZkRkJoZFhObFpDaG1iR0ZuT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNemNLSUNBZ0lDOHZJR052Ym5OMElHRmpkR2wyWlRvZ2RXbHVkRFkwSUQwZ2RHaHBjeTV3WVhWelpVWnNZV2R6TG5aaGJIVmxJQ1lnWm14aFp3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5emRHRmliR1ZqYjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklIQmhkWE5sUm14aFozTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuY0dac1p5Y3NJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSndabXhuSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDNOMFlXSnNaV052YVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16Y0tJQ0FnSUM4dklHTnZibk4wSUdGamRHbDJaVG9nZFdsdWREWTBJRDBnZEdocGN5NXdZWFZ6WlVac1lXZHpMblpoYkhWbElDWWdabXhoWndvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0pnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgzTjBZV0pzWldOdmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhZM1JwZG1VZ1BUMDlJRlZwYm5RMk5DZ3dLU3dnSjNOMFlXSnNaV052YVc0Z2NHRjFjMlZrSnlrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnpkR0ZpYkdWamIybHVJSEJoZFhObFpBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUlDWUhBMkZ6WVFaemRYQndiSGtFYVc1cGRBTnRaM0lFWTJWcGJBUndabXhuQTJGa2JURVlRQUFVS2lKbkt5Sm5LQ0puS1NKbkp3UWlaeWNGSW1jeEdSUkVNUmhCQURtQ0J3VDNzQlFTQk8rZmtuUUVWbWxNNndUM3pZbUFCSWxVeG9JRUVQZGtkZ1JOQnNCSk5ob0FqZ2NBTEFCOUFNRUJFd0UyQVdVQ0FRQ0FCTk1rdnFRMkdnQ09BUUFCQURZYUFVa1ZKUkpFU1RJREUwUW5Ca3NCWjRBRUtzSDVkRXhRc0NORE5ob0JTUlVrRWtRWE5ob0NTUlVrRWtRWE5ob0RTUlVrRWtRWGlBSU9JaXBsUkJSRVN3SkVTVVFyU3dObktFc0NaeWNFU3dGbktpTm5NUUJQQXhaUVR3SVdVRXdXVUlBRXgyZHcwMHhRc0NORElpY0daVVFpS21WRUlpdGxSQ0lvWlVRaUtXVkVJaWNFWlVRaUp3VmxSRThGRms4R1RGQlBCUlpRVHdRV1VFOERGbEJQQWhaUVRCWlFnQVFWSDN4MVRGQ3dJME0yR2dGSkZTUVNSRWtYTmhvQ1NSVWtFa1JKRnpZYUEwa1ZKQkpFU1JlSUFXNklBWE5MQkVSSlJDSXBaVVJMQVE1RUswOEZaeWhQQTJjbkJFeG5NUUJQQTFCUEFsQk1VSUFFQmo3Q2RreFFzQ05ETmhvQlNSVWtFa1JKRjRnQk1JZ0JOU2NGVEdjeEFFeFFnQVFBUy9rMlRGQ3dJME9JQVJlSUFSd2lLR1ZFU1VTeE1nb2lzaEt5RkVteUVZRUVzaEFpc2dHek1RQk1GbENBQk43S3d2bE1VTEFqUXpZYUFVa1ZKQkpFRnpZYUFra1ZKUkpFTmhvRFNSVWtFa1FYaUFET2lBRGRJNGdBN1VzQk1nTVRSRXNDUkVsRUlpaGxSRWxFSWlsbFJCWkxBaFpNU3dHZ1NZQUkvLy8vLy8vLy8vK21SQmNpSndSbFJFc0JEMFJMQkVzRGNBQkZBVVF5Q2tzRGNBQkVTd1FQUkxGUEE3SVNTd095RkU4Q3NoR0JCTElRSXJJQnN5bExBV2RQQXhaUEExQlBBbEJNRmxDQUJBUStuVUZNVUxBalF6WWFBVWtWSkJKRUZ6WWFBa2tWSkJKRUY0Z0FPb2dBU1lFQ2lBQllTd0ZFU1VRaUtHVkVSQ0lwWlVSS0RrUkpTd0lQUkVzQkNTbExBV2RQQWhaUEFoWlFUQlpRZ0FSTHRmQWZURkN3STBNaUttVkVJeEpFaVRFQUlpY0daVVFTUklreURTSXJaVVJNU3dFU1JERUFUSElJUkJKRWlZb0JBQ0luQldWRWkvOGFGRVNKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiU3RhYmxlY29pbkFkbWluQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3RhYmxlY29pbkNvbnRyb2xsZXJJbml0aWFsaXplZEV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3RvY29sTWFuYWdlckFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhYmxlQXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN1cHBseUNlaWxpbmdNaWNyb1N0YWJsZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3RhYmxlY29pbkNvbmZpZ1VwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlN0YWJsZWNvaW5QYXVzZUZsYWdzVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlN0YWJsZWNvaW5Bc3NldE9wdGVkSW5FdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFibGVBc3NldElkIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJTdGFibGVjb2luTWludGVkRm9yVmF1bHRFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YXVsdElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50TWljcm9TdGFibGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc3N1ZWRTdXBwbHlNaWNyb1N0YWJsZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3RhYmxlY29pblJldGlyZWRGb3JWYXVsdEV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhdWx0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRNaWNyb1N0YWJsZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imlzc3VlZFN1cHBseU1pY3JvU3RhYmxlIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
