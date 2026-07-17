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

namespace Arc56.Generated.algorandfoundation.puya_ts.StructDemo_54696b52
{


    public class StructDemoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StructDemoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ObjectF8C529Bb : AVMObjectType
            {
                public ulong X { get; set; }

                public ulong Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectF8C529Bb Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectF8C529Bb();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is ulong vYValue) { ret.Y = vYValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectF8C529Bb);
                }
                public bool Equals(ObjectF8C529Bb? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectF8C529Bb left, ObjectF8C529Bb right)
                {
                    return EqualityComparer<ObjectF8C529Bb>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectF8C529Bb left, ObjectF8C529Bb right)
                {
                    return !(left == right);
                }

            }

            public class PluginInfo : AVMObjectType
            {
                public ulong LastValidRound { get; set; }

                public ulong Cooldown { get; set; }

                public ulong LastCalled { get; set; }

                public bool AdminPrivileges { get; set; }

                public Structs.PluginInfoMethods[] Methods { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValidRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValidRound.From(LastValidRound);
                    ret.AddRange(vLastValidRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCooldown.From(Cooldown);
                    ret.AddRange(vCooldown.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastCalled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastCalled.From(LastCalled);
                    ret.AddRange(vLastCalled.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdminPrivileges = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vAdminPrivileges.From(AdminPrivileges);
                    ret.AddRange(vAdminPrivileges.Encode());
                    var arrMethods = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PluginInfoMethods>(x => Structs.PluginInfoMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMethods.Value = (Methods ?? Array.Empty<Structs.PluginInfoMethods>()).ToList();
                    stringRef[ret.Count] = arrMethods.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PluginInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PluginInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValidRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValidRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValidRound = vLastValidRound.ToValue();
                    if (valueLastValidRound is ulong vLastValidRoundValue) { ret.LastValidRound = vLastValidRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCooldown.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCooldown = vCooldown.ToValue();
                    if (valueCooldown is ulong vCooldownValue) { ret.Cooldown = vCooldownValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastCalled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastCalled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastCalled = vLastCalled.ToValue();
                    if (valueLastCalled is ulong vLastCalledValue) { ret.LastCalled = vLastCalledValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdminPrivileges = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vAdminPrivileges.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdminPrivileges = vAdminPrivileges.ToValue();
                    if (valueAdminPrivileges is bool vAdminPrivilegesValue) { ret.AdminPrivileges = vAdminPrivilegesValue; }
                    var indexMethods = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrMethods = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PluginInfoMethods>(x => Structs.PluginInfoMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMethods.Decode(bytes.Skip(indexMethods + prefixOffset).ToArray());
                    ret.Methods = arrMethods.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PluginInfo);
                }
                public bool Equals(PluginInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PluginInfo left, PluginInfo right)
                {
                    return EqualityComparer<PluginInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(PluginInfo left, PluginInfo right)
                {
                    return !(left == right);
                }

            }

            public class Vector : AVMObjectType
            {
                public ulong X { get; set; }

                public ulong Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Vector Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Vector();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is ulong vYValue) { ret.Y = vYValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Vector);
                }
                public bool Equals(Vector? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Vector left, Vector right)
                {
                    return EqualityComparer<Vector>.Default.Equals(left, right);
                }
                public static bool operator !=(Vector left, Vector right)
                {
                    return !(left == right);
                }

            }

            public class PluginInfoMethods : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
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

                public static PluginInfoMethods Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PluginInfoMethods();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as PluginInfoMethods);
                }
                public bool Equals(PluginInfoMethods? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PluginInfoMethods left, PluginInfoMethods right)
                {
                    return EqualityComparer<PluginInfoMethods>.Default.Equals(left, right);
                }
                public static bool operator !=(PluginInfoMethods left, PluginInfoMethods right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestVectorCreationAndEquality(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 56, 141, 221 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestVectorCreationAndEquality_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 56, 141, 221 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="v1"> Vector</param>
        /// <param name="v2"> Vector</param>
        public async Task<Structs.Vector> AddVectors(Structs.Vector v1, Structs.Vector v2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 50, 45, 109 };

            var result = await base.CallApp(new List<object> { abiHandle, v1, v2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Vector.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> AddVectors_Transactions(Structs.Vector v1, Structs.Vector v2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 50, 45, 109 };

            return await base.MakeTransactionList(new List<object> { abiHandle, v1, v2 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="v1"> Vector</param>
        /// <param name="newX"> </param>
        /// <param name="newY"> </param>
        public async Task<Structs.Vector> MutateVector(Structs.Vector v1, ulong newX, ulong newY, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 69, 136, 7 };
            var newXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newXAbi.From(newX);
            var newYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newYAbi.From(newY);

            var result = await base.CallApp(new List<object> { abiHandle, v1, newXAbi, newYAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Vector.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MutateVector_Transactions(Structs.Vector v1, ulong newX, ulong newY, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 69, 136, 7 };
            var newXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newXAbi.From(newX);
            var newYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newYAbi.From(newY);

            return await base.MakeTransactionList(new List<object> { abiHandle, v1, newXAbi, newYAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="v1"> Vector</param>
        public async Task ImplicitCastingAndSpreading(Structs.Vector v1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 129, 222, 184 };

            var result = await base.CallApp(new List<object> { abiHandle, v1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ImplicitCastingAndSpreading_Transactions(Structs.Vector v1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 129, 222, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle, v1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="v1"> Vector</param>
        public async Task<Structs.Vector> ToAndFromBytes(Structs.Vector v1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 157, 108, 70 };

            var result = await base.CallApp(new List<object> { abiHandle, v1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Vector.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ToAndFromBytes_Transactions(Structs.Vector v1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 157, 108, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle, v1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="v1"> Vector</param>
        public async Task<Structs.ObjectF8C529Bb> ToNative(Structs.Vector v1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 145, 85, 69 };

            var result = await base.CallApp(new List<object> { abiHandle, v1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ObjectF8C529Bb.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ToNative_Transactions(Structs.Vector v1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 145, 85, 69 };

            return await base.MakeTransactionList(new List<object> { abiHandle, v1 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<Structs.PluginInfo> GetPlugin(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 20, 249, 42 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PluginInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPlugin_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 20, 249, 42 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.PluginInfo> GetMain(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 122, 76, 176 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PluginInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMain_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 122, 76, 176 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="index"> </param>
        /// <param name="lastCalled"> </param>
        public async Task SetLastCalled(string key, ulong index, ulong lastCalled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 33, 188, 166 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var lastCalledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastCalledAbi.From(lastCalled);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, indexAbi, lastCalledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLastCalled_Transactions(string key, ulong index, ulong lastCalled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 33, 188, 166 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var lastCalledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastCalledAbi.From(lastCalled);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, indexAbi, lastCalledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task SetPlugin(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 188, 97, 241 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPlugin_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 188, 97, 241 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0RGVtbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3RGOEM1MjlCQiI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifV0sIlBsdWdpbkluZm8iOlt7Im5hbWUiOiJsYXN0VmFsaWRSb3VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb29sZG93biIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0Q2FsbGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFkbWluUHJpdmlsZWdlcyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibWV0aG9kcyIsInR5cGUiOiJQbHVnaW5JbmZvTWV0aG9kc1tdIn1dLCJWZWN0b3IiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InkiLCJ0eXBlIjoidWludDY0In1dLCJQbHVnaW5JbmZvTWV0aG9kcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlWzRdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdFZlY3RvckNyZWF0aW9uQW5kRXF1YWxpdHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkVmVjdG9ycyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtdXRhdGVWZWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdYIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdZIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImltcGxpY2l0Q2FzdGluZ0FuZFNwcmVhZGluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9BbmRGcm9tQnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvTmF0aXZlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3RGOEM1MjlCQiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wsKGJ5dGVbNF0sdWludDY0LHVpbnQ2NClbXSkiLCJzdHJ1Y3QiOiJQbHVnaW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFpbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCwoYnl0ZVs0XSx1aW50NjQsdWludDY0KVtdKSIsInN0cnVjdCI6IlBsdWdpbkluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRMYXN0Q2FsbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhc3RDYWxsZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UGx1Z2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1NiwyOTFdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYyLDI5N10sImVycm9yTWVzc2FnZSI6Ikxhc3QgY2FsbGVkIG5vdCB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUxLDI2MCwyOTVdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxLDIwOCwyNzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTEsMzI1LDM2Myw0MDAsNDA4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFZlY3RvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOSwyMTYsMjgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNywyMzYsMzcxLDM3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBNElERTJJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpY0d4MVoybHVjeUlnSW0xaGFXNGlJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR05zWVhOeklGTjBjblZqZEVSbGJXOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRjS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURnNU16ZzRaR1JrSURCNFpXWXpNakprTm1RZ01IZ3dNalExT0Rnd055QXdlR05pT0RGa1pXSTRJREI0WmpjNVpEWmpORFlnTUhnNU1Ua3hOVFUwTlNBd2VETTRNVFJtT1RKaElEQjRNREEzWVRSallqQWdNSGcwWkRJeFltTmhOaUF3ZUdFNVltTTJNV1l4SUM4dklHMWxkR2h2WkNBaWRHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIa29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRlpsWTNSdmNuTW9LSFZwYm5RMk5DeDFhVzUwTmpRcExDaDFhVzUwTmpRc2RXbHVkRFkwS1Nrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW0xMWRHRjBaVlpsWTNSdmNpZ29kV2x1ZERZMExIVnBiblEyTkNrc2RXbHVkRFkwTEhWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWx0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaeWdvZFdsdWREWTBMSFZwYm5RMk5Da3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHOUJibVJHY205dFFubDBaWE1vS0hWcGJuUTJOQ3gxYVc1ME5qUXBLU2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlkRzlPWVhScGRtVW9LSFZwYm5RMk5DeDFhVzUwTmpRcEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBVR3gxWjJsdUtITjBjbWx1Wnlrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN3b1lubDBaVnMwWFN4MWFXNTBOalFzZFdsdWREWTBLVnRkS1NJc0lHMWxkR2h2WkNBaVoyVjBUV0ZwYmlncEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3c0tHSjVkR1ZiTkYwc2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFNraUxDQnRaWFJvYjJRZ0luTmxkRXhoYzNSRFlXeHNaV1FvYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFVHeDFaMmx1S0hOMGNtbHVaeWwyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MFpYTjBWbVZqZEc5eVEzSmxZWFJwYjI1QmJtUkZjWFZoYkdsMGVWOXliM1YwWlVBMElHMWhhVzVmWVdSa1ZtVmpkRzl5YzE5eWIzVjBaVUExSUcxaGFXNWZiWFYwWVhSbFZtVmpkRzl5WDNKdmRYUmxRRFlnYldGcGJsOXBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtZGZjbTkxZEdWQU55QnRZV2x1WDNSdlFXNWtSbkp2YlVKNWRHVnpYM0p2ZFhSbFFEZ2diV0ZwYmw5MGIwRnVaRVp5YjIxQ2VYUmxjMTl5YjNWMFpVQTRJRzFoYVc1ZloyVjBVR3gxWjJsdVgzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFRXRnBibDl5YjNWMFpVQXhNU0J0WVdsdVgzTmxkRXhoYzNSRFlXeHNaV1JmY205MWRHVkFNVElnYldGcGJsOXpaWFJRYkhWbmFXNWZjbTkxZEdWQU1UTUtJQ0FnSUdWeWNnb0tiV0ZwYmw5elpYUlFiSFZuYVc1ZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRGQnNkV2RwYmloclpYazZJSE4wY21sdVp5a2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnY0d4MVoybHVjeUE5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRkJzZFdkcGJrbHVabTgrS0hzZ2EyVjVVSEpsWm1sNE9pQW5jR3gxWjJsdWN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkJzZFdkcGJuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalk1TFRneENpQWdJQ0F2THlCMGFHbHpMbkJzZFdkcGJuTW9hMlY1S1M1MllXeDFaU0E5SUc1bGR5QlFiSFZuYVc1SmJtWnZLSHNLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrVW05MWJtUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdZV1J0YVc1UWNtbDJhV3hsWjJWek9pQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLU3dLSUNBZ0lDOHZJQ0FnYldWMGFHOWtjem9nYm1WM0lHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNUtBb2dJQ0FnTHk4Z0lDQWdJRzVsZHlCTlpYUm9iMlJKYm1adktIc0tJQ0FnSUM4dklDQWdJQ0FnSUhObGJHVmpkRzl5T2lCdVpYY2dZWEpqTkM1VGRHRjBhV05DZVhSbGN5aHRaWFJvYjJSVFpXeGxZM1J2Y2lnbmRHVnpkQ2dwZG05cFpDY3BLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnZlNrc0NpQWdJQ0F2THlBZ0lDa3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhZakF3TURGaE56Z3dNREJrWlRBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZCc2RXZHBiaWhyWlhrNklITjBjbWx1WnlrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUk1ZWE4wUTJGc2JHVmtYM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJNWVhOMFEyRnNiR1ZrS0d0bGVUb2djM1J5YVc1bkxDQnBibVJsZURvZ2RXbHVkRFkwTENCc1lYTjBRMkZzYkdWa09pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIQnNkV2RwYm5NZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCUWJIVm5hVzVKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNCc2RXZHBibk1uSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd2JIVm5hVzV6SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxuQnNkV2RwYm5Nb2EyVjVLUzUyWVd4MVpTNXRaWFJvYjJSelcybHVaR1Y0WFM1c1lYTjBRMkZzYkdWa0lEMGdibVYzSUdGeVl6UXVWV2x1ZERZMEtHeGhjM1JEWVd4c1pXUXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNakFLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTkRFS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVEdGemRFTmhiR3hsWkNoclpYazZJSE4wY21sdVp5d2dhVzVrWlhnNklIVnBiblEyTkN3Z2JHRnpkRU5oYkd4bFpEb2dkV2x1ZERZMEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRTFoYVc1ZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2NHeDFaMmx1SUQwZ1FtOTRQRkJzZFdkcGJrbHVabTgrS0hzZ2EyVjVPaUFuYldGcGJpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTFoYVc0aUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnZG1Gc2RXVWdQU0JqYkc5dVpTaDBhR2x6TG5Cc2RXZHBiaTUyWVd4MVpTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdjR3gxWjJsdUlEMGdRbTk0UEZCc2RXZHBia2x1Wm04K0tIc2dhMlY1T2lBbmJXRnBiaWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW0xaGFXNGlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6bzFPUzAyTUFvZ0lDQWdMeThnWTI5dWMzUWdkbUZzZFdVZ1BTQmpiRzl1WlNoMGFHbHpMbkJzZFdkcGJpNTJZV3gxWlNrS0lDQWdJQzh2SUdGemMyVnlkQ2gyWVd4MVpTNXNZWE4wUTJGc2JHVmtMbUZ6VldsdWREWTBLQ2tnUGlBd0xDQW5UR0Z6ZENCallXeHNaV1FnYm05MElIcGxjbThuS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCaGMzTmxjblFvZG1Gc2RXVXViR0Z6ZEVOaGJHeGxaQzVoYzFWcGJuUTJOQ2dwSUQ0Z01Dd2dKMHhoYzNRZ1kyRnNiR1ZrSUc1dmRDQjZaWEp2SnlrS0lDQWdJR0owYjJrS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWVhOMElHTmhiR3hsWkNCdWIzUWdlbVZ5YndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSTllXbHVLQ2tnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSUWJIVm5hVzVmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEZCc2RXZHBiaWhyWlhrNklITjBjbWx1WnlrNklGQnNkV2RwYmtsdVptOGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnY0d4MVoybHVjeUE5SUVKdmVFMWhjRHh6ZEhKcGJtY3NJRkJzZFdkcGJrbHVabTgrS0hzZ2EyVjVVSEpsWm1sNE9pQW5jR3gxWjJsdWN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkJzZFdkcGJuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJqYjI1emRDQjJZV3gxWlNBOUlHTnNiMjVsS0hSb2FYTXVjR3gxWjJsdWN5aHJaWGtwTG5aaGJIVmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZOVE10TlRRS0lDQWdJQzh2SUdOdmJuTjBJSFpoYkhWbElEMGdZMnh2Ym1Vb2RHaHBjeTV3YkhWbmFXNXpLR3RsZVNrdWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kbUZzZFdVdWJHRnpkRU5oYkd4bFpDNWhjMVZwYm5RMk5DZ3BJRDRnTUN3Z0oweGhjM1FnWTJGc2JHVmtJRzV2ZENCNlpYSnZKeWtLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWVhOelpYSjBLSFpoYkhWbExteGhjM1JEWVd4c1pXUXVZWE5WYVc1ME5qUW9LU0ErSURBc0lDZE1ZWE4wSUdOaGJHeGxaQ0J1YjNRZ2VtVnlieWNwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR0Z6ZENCallXeHNaV1FnYm05MElIcGxjbThLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVUd4MVoybHVLR3RsZVRvZ2MzUnlhVzVuS1RvZ1VHeDFaMmx1U1c1bWJ5QjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUnZRVzVrUm5KdmJVSjVkR1Z6WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2UVc1a1JuSnZiVUo1ZEdWektIWXhPaUJXWldOMGIzSXBPaUJXWldOMGIzSWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVm1WamRHOXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVoxOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQjFZbXhwWXlCcGJYQnNhV05wZEVOaGMzUnBibWRCYm1SVGNISmxZV1JwYm1jb2RqRTZJRlpsWTNSdmNpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVm1WamRHOXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdZMjl1YzNRZ2RqSWdQU0J1WlhjZ1ZtVmpkRzl5S0hZeEtRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdPQ0E0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCamIyNXpkQ0IyTXlBOUlHNWxkeUJXWldOMGIzSW9leUF1TGk1Mk1pQjlLUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QmhjM05sY25Rb2RqRXVZbmwwWlhNZ1BUMDlJSFl5TG1KNWRHVnpLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklHRnpjMlZ5ZENoMk15NWllWFJsY3lBOVBUMGdkakV1WW5sMFpYTXBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdjSFZpYkdsaklHbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVp5aDJNVG9nVm1WamRHOXlLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjExZEdGMFpWWmxZM1J2Y2w5eWIzVjBaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUhCMVlteHBZeUJ0ZFhSaGRHVldaV04wYjNJb2RqRTZJRlpsWTNSdmNpd2dibVYzV0RvZ1FWSkRORlZwYm5RMk5Dd2dibVYzV1RvZ1FWSkRORlZwYm5RMk5DazZJRlpsWTNSdmNpQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJXWldOMGIzSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCMk1TNTRJRDBnYm1WM1dBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIWXhMbmtnUFNCdVpYZFpDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBNENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2NIVmliR2xqSUcxMWRHRjBaVlpsWTNSdmNpaDJNVG9nVm1WamRHOXlMQ0J1WlhkWU9pQkJVa00wVldsdWREWTBMQ0J1WlhkWk9pQkJVa00wVldsdWREWTBLVG9nVm1WamRHOXlJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1JrVm1WamRHOXljMTl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSEIxWW14cFl5QmhaR1JXWldOMGIzSnpLSFl4T2lCV1pXTjBiM0lzSUhZeU9pQldaV04wYjNJcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRlpsWTNSdmNnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdWbVZqZEc5eUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2VEb2dibVYzSUVGU1F6UlZhVzUwTmpRb2RqRXVlQzVoYzFWcGJuUTJOQ2dwSUNzZ2RqSXVlQzVoYzFWcGJuUTJOQ2dwS1N3S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUI1T2lCdVpYY2dRVkpETkZWcGJuUTJOQ2gyTVM1NUxtRnpWV2x1ZERZMEtDa2dLeUIyTWk1NUxtRnpWV2x1ZERZMEtDa3BMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveU1DMHlNd29nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJXWldOMGIzSW9ld29nSUNBZ0x5OGdJQ0I0T2lCdVpYY2dRVkpETkZWcGJuUTJOQ2gyTVM1NExtRnpWV2x1ZERZMEtDa2dLeUIyTWk1NExtRnpWV2x1ZERZMEtDa3BMQW9nSUNBZ0x5OGdJQ0I1T2lCdVpYY2dRVkpETkZWcGJuUTJOQ2gyTVM1NUxtRnpWV2x1ZERZMEtDa2dLeUIyTWk1NUxtRnpWV2x1ZERZMEtDa3BMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUhCMVlteHBZeUJoWkdSV1pXTjBiM0p6S0hZeE9pQldaV04wYjNJc0lIWXlPaUJXWldOMGIzSXBJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGxmY205MWRHVkFORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJzYjJjb2RqRXVlQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QnNiMmNvZGpFdWVTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhrb0tTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRISjFZM1JFWlcxdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFnUUFDWUVCQlVmZkhVSGNHeDFaMmx1Y3dSdFlXbHVDQUFBQUFBQUFBQUFNUnRCQVpFeEdSUkVNUmhFZ2dvRWlUaU4zUVR2TWkxdEJBSkZpQWNFeTRIZXVBVDNuV3hHQkpHUlZVVUVPQlQ1S2dRQWVreXdCRTBodktZRXFieGg4VFlhQUk0S0FUY0JEQURuQU1FQXN3Q3pBSkFBZ1FCT0FBRUFOaG9CU1NWWmdRSUlTd0VWRWtSWEFnQXBURkJKdkVpQU1RQUFBQUFBQUFBQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUd3QUJwNEFBM2dBQUFBQUFBQUFCQUFBQUFBQUFBQUcvSWtNMkdnRkpKVm1CQWdoTEFSVVNSRmNDQURZYUFra1ZJeEpFRnpZYUEwa1ZJeEpFS1U4RFVFOENnUlFMZ1NrSVR3SzdJa01xdmtRcUpDTzZGMFFvVEZDd0lrTTJHZ0ZKSlZtQkFnaExBUlVTUkZjQ0FDbE1VRW0rUkV3a0k3b1hSQ2hNVUxBaVF6WWFBVWtWSkJKRUtFeFFzQ0pETmhvQlNSVWtFa1JKVndBSVN3RlhDQWhRU1ZjQUNFc0JWd2dJVUVzQ1R3SVNSQkpFSWtNMkdnRkpGU1FTUkRZYUFra1ZJeEpFTmhvRFNSVWpFa1JPQWx3QVRGd0lLRXhRc0NKRE5ob0JTUlVrRWtRMkdnSkpGU1FTUkVzQkpWdExBU1ZiQ0JaUEFpTmJUd0lqV3dnV1VDaE1VTEFpUXl1d0s3QWlRekVaRkRFWUZCQkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
