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

namespace Arc56.Generated.algorandfoundation.puya_ts.StructDemo_ac2d566f
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0RGVtbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3RGOEM1MjlCQiI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifV0sIlBsdWdpbkluZm8iOlt7Im5hbWUiOiJsYXN0VmFsaWRSb3VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb29sZG93biIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0Q2FsbGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFkbWluUHJpdmlsZWdlcyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibWV0aG9kcyIsInR5cGUiOiJQbHVnaW5JbmZvTWV0aG9kc1tdIn1dLCJWZWN0b3IiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InkiLCJ0eXBlIjoidWludDY0In1dLCJQbHVnaW5JbmZvTWV0aG9kcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlWzRdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdFZlY3RvckNyZWF0aW9uQW5kRXF1YWxpdHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkVmVjdG9ycyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtdXRhdGVWZWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdYIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdZIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImltcGxpY2l0Q2FzdGluZ0FuZFNwcmVhZGluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9BbmRGcm9tQnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvTmF0aXZlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3RGOEM1MjlCQiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wsKGJ5dGVbNF0sdWludDY0LHVpbnQ2NClbXSkiLCJzdHJ1Y3QiOiJQbHVnaW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFpbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCwoYnl0ZVs0XSx1aW50NjQsdWludDY0KVtdKSIsInN0cnVjdCI6IlBsdWdpbkluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRMYXN0Q2FsbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhc3RDYWxsZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UGx1Z2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY4NCw3MDRdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjkyLDcxMl0sImVycm9yTWVzc2FnZSI6Ikxhc3QgY2FsbGVkIG5vdCB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5OCw0NDMsNDk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcwLDI3OCwyOTksMzQyLDM1OCwzNzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVmVjdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA4LDQ1Myw1MDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA3LDMxNSw0NjQsNDczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBzaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dPQ0F3SURFZ01UWUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dNSGd4TlRGbU4yTTNOU0F3ZURBd01EQXdNREF3TURBd01EQXdNREFnSW5Cc2RXZHBibk1pSURCNE1EQXdNREF3TURBd01EQXdNREF3TVNBd2VHRTNPREF3TUdSbENpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJqYkdGemN5QlRkSEoxWTNSRVpXMXZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVGNLSUNBZ0lHSWdiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlDZ3B0WVdsdVgyRmlhVjl5YjNWMGFXNW5RREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWTJ4aGMzTWdVM1J5ZFdOMFJHVnRieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFMUNpQWdJQ0JpSUcxaGFXNWZZMkZzYkY5T2IwOXdRRE1LQ20xaGFXNWZZMkZzYkY5T2IwOXdRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWTJ4aGMzTWdVM1J5ZFdOMFJHVnRieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGc1TXpnNFpHUmtJQzh2SUcxbGRHaHZaQ0FpZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhrb0tYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhsWmpNeU1tUTJaQ0F2THlCdFpYUm9iMlFnSW1Ga1pGWmxZM1J2Y25Nb0tIVnBiblEyTkN4MWFXNTBOalFwTENoMWFXNTBOalFzZFdsdWREWTBLU2tvZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNalExT0Rnd055QXZMeUJ0WlhSb2IyUWdJbTExZEdGMFpWWmxZM1J2Y2lnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzZFdsdWREWTBMSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoallqZ3haR1ZpT0NBdkx5QnRaWFJvYjJRZ0ltbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVp5Z29kV2x1ZERZMExIVnBiblEyTkNrcGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1kzT1dRMll6UTJJQzh2SUcxbGRHaHZaQ0FpZEc5QmJtUkdjbTl0UW5sMFpYTW9LSFZwYm5RMk5DeDFhVzUwTmpRcEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURreE9URTFOVFExSUM4dklHMWxkR2h2WkNBaWRHOU9ZWFJwZG1Vb0tIVnBiblEyTkN4MWFXNTBOalFwS1NoMWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE00TVRSbU9USmhJQzh2SUcxbGRHaHZaQ0FpWjJWMFVHeDFaMmx1S0hOMGNtbHVaeWtvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ3dvWW5sMFpWczBYU3gxYVc1ME5qUXNkV2x1ZERZMEtWdGRLU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TjJFMFkySXdJQzh2SUcxbGRHaHZaQ0FpWjJWMFRXRnBiaWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndzS0dKNWRHVmJORjBzZFdsdWREWTBMSFZwYm5RMk5DbGJYU2tpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwWkRJeFltTmhOaUF2THlCdFpYUm9iMlFnSW5ObGRFeGhjM1JEWVd4c1pXUW9jM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRTVZbU0yTVdZeElDOHZJRzFsZEdodlpDQWljMlYwVUd4MVoybHVLSE4wY21sdVp5bDJiMmxrSWdvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOTBaWE4wVm1WamRHOXlRM0psWVhScGIyNUJibVJGY1hWaGJHbDBlVjl5YjNWMFpVQTBJRzFoYVc1ZllXUmtWbVZqZEc5eWMxOXliM1YwWlVBMUlHMWhhVzVmYlhWMFlYUmxWbVZqZEc5eVgzSnZkWFJsUURZZ2JXRnBibDlwYlhCc2FXTnBkRU5oYzNScGJtZEJibVJUY0hKbFlXUnBibWRmY205MWRHVkFOeUJ0WVdsdVgzUnZRVzVrUm5KdmJVSjVkR1Z6WDNKdmRYUmxRRGdnYldGcGJsOTBiMDVoZEdsMlpWOXliM1YwWlVBNUlHMWhhVzVmWjJWMFVHeDFaMmx1WDNKdmRYUmxRREV3SUcxaGFXNWZaMlYwVFdGcGJsOXliM1YwWlVBeE1TQnRZV2x1WDNObGRFeGhjM1JEWVd4c1pXUmZjbTkxZEdWQU1USWdiV0ZwYmw5elpYUlFiSFZuYVc1ZmNtOTFkR1ZBTVRNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UUTZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMk9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UZ0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4T0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pFd0NpQWdJQ0F2THlCamJHRnpjeUJUZEhKMVkzUkVaVzF2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM05sZEZCc2RXZHBibDl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVUd4MVoybHVLR3RsZVRvZ2MzUnlhVzVuS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSE5sZEZCc2RXZHBiZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmYzJWMFRHRnpkRU5oYkd4bFpGOXliM1YwWlVBeE1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBUR0Z6ZEVOaGJHeGxaQ2hyWlhrNklITjBjbWx1Wnl3Z2FXNWtaWGc2SUhWcGJuUTJOQ3dnYkdGemRFTmhiR3hsWkRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSE5sZEV4aGMzUkRZV3hzWldRS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgyZGxkRTFoYVc1ZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFMWhhVzRvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEUxaGFXNEtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREUwQ2dwdFlXbHVYMmRsZEZCc2RXZHBibDl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVUd4MVoybHVLR3RsZVRvZ2MzUnlhVzVuS1RvZ1VHeDFaMmx1U1c1bWJ5QjdDaUFnSUNCallXeHNjM1ZpSUdkbGRGQnNkV2RwYmdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UUUtDbTFoYVc1ZmRHOU9ZWFJwZG1WZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCd2RXSnNhV01nZEc5T1lYUnBkbVVvZGpFNklGWmxZM1J2Y2lrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwYjA1aGRHbDJaUW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmZEc5QmJtUkdjbTl0UW5sMFpYTmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QndkV0pzYVdNZ2RHOUJibVJHY205dFFubDBaWE1vZGpFNklGWmxZM1J2Y2lrNklGWmxZM1J2Y2lCN0NpQWdJQ0JqWVd4c2MzVmlJSFJ2UVc1a1JuSnZiVUo1ZEdWekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOQW9LYldGcGJsOXBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtZGZjbTkxZEdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QndkV0pzYVdNZ2FXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1bktIWXhPaUJXWldOMGIzSXBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2FXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1bkNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOQW9LYldGcGJsOXRkWFJoZEdWV1pXTjBiM0pmY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiWFYwWVhSbFZtVmpkRzl5S0hZeE9pQldaV04wYjNJc0lHNWxkMWc2SUVGU1F6UlZhVzUwTmpRc0lHNWxkMWs2SUVGU1F6UlZhVzUwTmpRcE9pQldaV04wYjNJZ2V3b2dJQ0FnWTJGc2JITjFZaUJ0ZFhSaGRHVldaV04wYjNJS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTBDZ3B0WVdsdVgyRmtaRlpsWTNSdmNuTmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QndkV0pzYVdNZ1lXUmtWbVZqZEc5eWN5aDJNVG9nVm1WamRHOXlMQ0IyTWpvZ1ZtVmpkRzl5S1NCN0NpQWdJQ0JqWVd4c2MzVmlJR0ZrWkZabFkzUnZjbk1LSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMENncHRZV2x1WDNSbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNVgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNUtDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBWbVZqZEc5eVEzSmxZWFJwYjI1QmJtUkZjWFZoYkdsMGVRb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVFFLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRVNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5nb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRjNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSeWRXTjBSR1Z0YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NTBaWE4wVm1WamRHOXlRM0psWVhScGIyNUJibVJGY1hWaGJHbDBlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNU9nb2dJQ0FnWWlCMFpYTjBWbVZqZEc5eVEzSmxZWFJwYjI1QmJtUkZjWFZoYkdsMGVWOWliRzlqYTBBd0NncDBaWE4wVm1WamRHOXlRM0psWVhScGIyNUJibVJGY1hWaGJHbDBlVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJSEIxWW14cFl5QjBaWE4wVm1WamRHOXlRM0psWVhScGIyNUJibVJGY1hWaGJHbDBlU2dwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZPbE4wY25WamRFUmxiVzh1ZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem82VTNSeWRXTjBSR1Z0Ynk1aFpHUldaV04wYjNKelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV1JrVm1WamRHOXljem9LSUNBZ0lHSWdZV1JrVm1WamRHOXljMTlpYkc5amEwQXdDZ3BoWkdSV1pXTjBiM0p6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY0hWaWJHbGpJR0ZrWkZabFkzUnZjbk1vZGpFNklGWmxZM1J2Y2l3Z2RqSTZJRlpsWTNSdmNpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVm1WamRHOXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJXWldOMGIzSUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dVlXUmtWbVZqZEc5eWN3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZPbE4wY25WamRFUmxiVzh1YlhWMFlYUmxWbVZqZEc5eVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiWFYwWVhSbFZtVmpkRzl5T2dvZ0lDQWdZaUJ0ZFhSaGRHVldaV04wYjNKZllteHZZMnRBTUFvS2JYVjBZWFJsVm1WamRHOXlYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdjSFZpYkdsaklHMTFkR0YwWlZabFkzUnZjaWgyTVRvZ1ZtVmpkRzl5TENCdVpYZFlPaUJCVWtNMFZXbHVkRFkwTENCdVpYZFpPaUJCVWtNMFZXbHVkRFkwS1RvZ1ZtVmpkRzl5SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGWmxZM1J2Y2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem82VTNSeWRXTjBSR1Z0Ynk1dGRYUmhkR1ZXWldOMGIzSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG1sdGNHeHBZMmwwUTJGemRHbHVaMEZ1WkZOd2NtVmhaR2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVp6b0tJQ0FnSUdJZ2FXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1blgySnNiMk5yUURBS0NtbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVoxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQjFZbXhwWXlCcGJYQnNhV05wZEVOaGMzUnBibWRCYm1SVGNISmxZV1JwYm1jb2RqRTZJRlpsWTNSdmNpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVm1WamRHOXlDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxtbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxuUnZRVzVrUm5KdmJVSjVkR1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOUJibVJHY205dFFubDBaWE02Q2lBZ0lDQmlJSFJ2UVc1a1JuSnZiVUo1ZEdWelgySnNiMk5yUURBS0NuUnZRVzVrUm5KdmJVSjVkR1Z6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2UVc1a1JuSnZiVUo1ZEdWektIWXhPaUJXWldOMGIzSXBPaUJXWldOMGIzSWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVm1WamRHOXlDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxuUnZRVzVrUm5KdmJVSjVkR1Z6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NTBiMDVoZEdsMlpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2VG1GMGFYWmxPZ29nSUNBZ1lpQjBiMDVoZEdsMlpWOWliRzlqYTBBd0NncDBiMDVoZEdsMlpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIwNWhkR2wyWlNoMk1Ub2dWbVZqZEc5eUtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJXWldOMGIzSUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dWRHOU9ZWFJwZG1VS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMbWRsZEZCc2RXZHBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGQnNkV2RwYmpvS0lDQWdJR0lnWjJWMFVHeDFaMmx1WDJKc2IyTnJRREFLQ21kbGRGQnNkV2RwYmw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSUWJIVm5hVzRvYTJWNU9pQnpkSEpwYm1jcE9pQlFiSFZuYVc1SmJtWnZJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dVoyVjBVR3gxWjJsdUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6bzZVM1J5ZFdOMFJHVnRieTVuWlhSTllXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFRXRnBiam9LSUNBZ0lHSWdaMlYwVFdGcGJsOWliRzlqYTBBd0NncG5aWFJOWVdsdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFMWhhVzRvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG1kbGRFMWhhVzRLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxuTmxkRXhoYzNSRFlXeHNaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUk1ZWE4wUTJGc2JHVmtPZ29nSUNBZ1lpQnpaWFJNWVhOMFEyRnNiR1ZrWDJKc2IyTnJRREFLQ25ObGRFeGhjM1JEWVd4c1pXUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBUR0Z6ZEVOaGJHeGxaQ2hyWlhrNklITjBjbWx1Wnl3Z2FXNWtaWGc2SUhWcGJuUTJOQ3dnYkdGemRFTmhiR3hsWkRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG5ObGRFeGhjM1JEWVd4c1pXUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NXpaWFJRYkhWbmFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSUWJIVm5hVzQ2Q2lBZ0lDQmlJSE5sZEZCc2RXZHBibDlpYkc5amEwQXdDZ3B6WlhSUWJIVm5hVzVmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVUd4MVoybHVLR3RsZVRvZ2MzUnlhVzVuS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMbk5sZEZCc2RXZHBiZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMblJsYzNSV1pXTjBiM0pEY21WaGRHbHZia0Z1WkVWeGRXRnNhWFI1S0NrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk9sTjBjblZqZEVSbGJXOHVkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGs2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG5SbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMblJsYzNSV1pXTjBiM0pEY21WaGRHbHZia0Z1WkVWeGRXRnNhWFI1WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnWTI5dWMzUWdkakVnUFNCdVpYY2dWbVZqZEc5eUtIc2dlRG9nYm1WM0lFRlNRelJWYVc1ME5qUW9NQ2tzSUhrNklHNWxkeUJCVWtNMFZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdiRzluS0hZeExuZ3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHeHZaeWgyTVM1NUtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCamIyNXpkQ0IyTWlBOUlHNWxkeUJXWldOMGIzSW9leUI1T2lCdVpYY2dRVkpETkZWcGJuUTJOQ2d3S1N3Z2VEb2dibVYzSUVGU1F6UlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kakVnUFQwOUlIWXlLUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZPbE4wY25WamRFUmxiVzh1WVdSa1ZtVmpkRzl5Y3loMk1Ub2dZbmwwWlhNc0lIWXlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG1Ga1pGWmxZM1J2Y25NNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdGa1pGWmxZM1J2Y25Nb2RqRTZJRlpsWTNSdmNpd2dkakk2SUZabFkzUnZjaWtnZXdvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMbUZrWkZabFkzUnZjbk5mWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dVlXUmtWbVZqZEc5eWMxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIZzZJRzVsZHlCQlVrTTBWV2x1ZERZMEtIWXhMbmd1WVhOVmFXNTBOalFvS1NBcklIWXlMbmd1WVhOVmFXNTBOalFvS1Nrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSGs2SUc1bGR5QkJVa00wVldsdWREWTBLSFl4TG5rdVlYTlZhVzUwTmpRb0tTQXJJSFl5TG5rdVlYTlZhVzUwTmpRb0tTa3NDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TWpBdE1qTUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dWbVZqZEc5eUtIc0tJQ0FnSUM4dklDQWdlRG9nYm1WM0lFRlNRelJWYVc1ME5qUW9kakV1ZUM1aGMxVnBiblEyTkNncElDc2dkakl1ZUM1aGMxVnBiblEyTkNncEtTd0tJQ0FnSUM4dklDQWdlVG9nYm1WM0lFRlNRelJWYVc1ME5qUW9kakV1ZVM1aGMxVnBiblEyTkNncElDc2dkakl1ZVM1aGMxVnBiblEyTkNncEtTd0tJQ0FnSUM4dklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxtMTFkR0YwWlZabFkzUnZjaWgyTVRvZ1lubDBaWE1zSUc1bGQxZzZJR0o1ZEdWekxDQnVaWGRaT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxtMTFkR0YwWlZabFkzUnZjam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiWFYwWVhSbFZtVmpkRzl5S0hZeE9pQldaV04wYjNJc0lHNWxkMWc2SUVGU1F6UlZhVzUwTmpRc0lHNWxkMWs2SUVGU1F6UlZhVzUwTmpRcE9pQldaV04wYjNJZ2V3b2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG0xMWRHRjBaVlpsWTNSdmNsOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6bzZVM1J5ZFdOMFJHVnRieTV0ZFhSaGRHVldaV04wYjNKZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCMk1TNTRJRDBnYm1WM1dBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMwekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2RqRXVlU0E5SUc1bGQxa0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ0xUTUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QnlaWFIxY200Z2RqRUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMbWx0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaeWgyTVRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxtbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVp6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QndkV0pzYVdNZ2FXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1bktIWXhPaUJXWldOMGIzSXBJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NXBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtZGZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZPbE4wY25WamRFUmxiVzh1YVcxd2JHbGphWFJEWVhOMGFXNW5RVzVrVTNCeVpXRmthVzVuWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWTI5dWMzUWdkaklnUFNCdVpYY2dWbVZqZEc5eUtIWXhLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUdOdmJuTjBJSFl6SUQwZ2JtVjNJRlpsWTNSdmNpaDdJQzR1TG5ZeUlIMHBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hZeExtSjVkR1Z6SUQwOVBTQjJNaTVpZVhSbGN5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnWVhOelpYSjBLSFl6TG1KNWRHVnpJRDA5UFNCMk1TNWllWFJsY3lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dWRHOUJibVJHY205dFFubDBaWE1vZGpFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk9sTjBjblZqZEVSbGJXOHVkRzlCYm1SR2NtOXRRbmwwWlhNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdlFXNWtSbkp2YlVKNWRHVnpLSFl4T2lCV1pXTjBiM0lwT2lCV1pXTjBiM0lnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMblJ2UVc1a1JuSnZiVUo1ZEdWelgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMblJ2UVc1a1JuSnZiVUo1ZEdWelgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z1kyOXVjM1FnZGpGZllubDBaWE1nUFNCMk1TNWllWFJsY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnY21WMGRYSnVJR052Ym5abGNuUkNlWFJsY3p4V1pXTjBiM0krS0hZeFgySjVkR1Z6TENCN0lITjBjbUYwWldkNU9pQW5kVzV6WVdabExXTmhjM1FuSUgwcENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NTBiMDVoZEdsMlpTaDJNVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem82VTNSeWRXTjBSR1Z0Ynk1MGIwNWhkR2wyWlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCd2RXSnNhV01nZEc5T1lYUnBkbVVvZGpFNklGWmxZM1J2Y2lrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG5SdlRtRjBhWFpsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxuUnZUbUYwYVhabFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhZeExtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem82VTNSeWRXTjBSR1Z0Ynk1blpYUlFiSFZuYVc0b2EyVjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG1kbGRGQnNkV2RwYmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFVHeDFaMmx1S0d0bGVUb2djM1J5YVc1bktUb2dVR3gxWjJsdVNXNW1ieUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk9sTjBjblZqZEVSbGJXOHVaMlYwVUd4MVoybHVYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG1kbGRGQnNkV2RwYmw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhCc2RXZHBibk1nUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JRYkhWbmFXNUpibVp2UGloN0lHdGxlVkJ5WldacGVEb2dKM0JzZFdkcGJuTW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YkhWbmFXNXpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJqYjI1emRDQjJZV3gxWlNBOUlHTnNiMjVsS0hSb2FYTXVjR3gxWjJsdWN5aHJaWGtwTG5aaGJIVmxLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kbUZzZFdVdWJHRnpkRU5oYkd4bFpDNWhjMVZwYm5RMk5DZ3BJRDRnTUN3Z0oweGhjM1FnWTJGc2JHVmtJRzV2ZENCNlpYSnZKeWtLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVEdGemRDQmpZV3hzWldRZ2JtOTBJSHBsY204S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCeVpYUjFjbTRnZG1Gc2RXVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMbWRsZEUxaGFXNG9LU0F0UGlCaWVYUmxjem9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dVoyVjBUV0ZwYmpvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dVoyVjBUV0ZwYmw5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NW5aWFJOWVdsdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2NHeDFaMmx1SUQwZ1FtOTRQRkJzZFdkcGJrbHVabTgrS0hzZ2EyVjVPaUFuYldGcGJpY2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWliV0ZwYmlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCamIyNXpkQ0IyWVd4MVpTQTlJR05zYjI1bEtIUm9hWE11Y0d4MVoybHVMblpoYkhWbEtRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QmhjM05sY25Rb2RtRnNkV1V1YkdGemRFTmhiR3hsWkM1aGMxVnBiblEyTkNncElENGdNQ3dnSjB4aGMzUWdZMkZzYkdWa0lHNXZkQ0I2WlhKdkp5a0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR0Z6ZENCallXeHNaV1FnYm05MElIcGxjbThLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxuTmxkRXhoYzNSRFlXeHNaV1FvYTJWNU9pQmllWFJsY3l3Z2FXNWtaWGc2SUhWcGJuUTJOQ3dnYkdGemRFTmhiR3hsWkRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NXpaWFJNWVhOMFEyRnNiR1ZrT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSTVlYTjBRMkZzYkdWa0tHdGxlVG9nYzNSeWFXNW5MQ0JwYm1SbGVEb2dkV2x1ZERZMExDQnNZWE4wUTJGc2JHVmtPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NXpaWFJNWVhOMFEyRnNiR1ZrWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxuTmxkRXhoYzNSRFlXeHNaV1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxuQnNkV2RwYm5Nb2EyVjVLUzUyWVd4MVpTNXRaWFJvYjJSelcybHVaR1Y0WFM1c1lYTjBRMkZzYkdWa0lEMGdibVYzSUdGeVl6UXVWV2x1ZERZMEtHeGhjM1JEWVd4c1pXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QndiSFZuYVc1eklEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1VHeDFaMmx1U1c1bWJ6NG9leUJyWlhsUWNtVm1hWGc2SUNkd2JIVm5hVzV6SnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHeDFaMmx1Y3lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2RHaHBjeTV3YkhWbmFXNXpLR3RsZVNrdWRtRnNkV1V1YldWMGFHOWtjMXRwYm1SbGVGMHViR0Z6ZEVOaGJHeGxaQ0E5SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2hzWVhOMFEyRnNiR1ZrS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhwYm5RZ01qY0tJQ0FnSUNzS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6bzZVM1J5ZFdOMFJHVnRieTV6WlhSUWJIVm5hVzRvYTJWNU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk9sTjBjblZqZEVSbGJXOHVjMlYwVUd4MVoybHVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJRYkhWbmFXNG9hMlY1T2lCemRISnBibWNwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6bzZVM1J5ZFdOMFJHVnRieTV6WlhSUWJIVm5hVzVmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dWMyVjBVR3gxWjJsdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z1lXUnRhVzVRY21sMmFXeGxaMlZ6T2lCdVpYY2dZWEpqTkM1Q2IyOXNLR1poYkhObEtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklITmxiR1ZqZEc5eU9pQnVaWGNnWVhKak5DNVRkR0YwYVdOQ2VYUmxjeWh0WlhSb2IyUlRaV3hsWTNSdmNpZ25kR1Z6ZENncGRtOXBaQ2NwS1N3S0lDQWdJR0o1ZEdWaklEVWdMeThnYldWMGFHOWtJQ0owWlhOMEtDbDJiMmxrSWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J6YVhwbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvM05TMDNPUW9nSUNBZ0x5OGdibVYzSUUxbGRHaHZaRWx1Wm04b2V3b2dJQ0FnTHk4Z0lDQnpaV3hsWTNSdmNqb2dibVYzSUdGeVl6UXVVM1JoZEdsalFubDBaWE1vYldWMGFHOWtVMlZzWldOMGIzSW9KM1JsYzNRb0tYWnZhV1FuS1Nrc0NpQWdJQ0F2THlBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJR3hoYzNSRFlXeHNaV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUgwcExBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklITmxiR1ZqZEc5eU9pQnVaWGNnWVhKak5DNVRkR0YwYVdOQ2VYUmxjeWh0WlhSb2IyUlRaV3hsWTNSdmNpZ25kR1Z6ZENncGRtOXBaQ2NwS1N3S0lDQWdJR0o1ZEdWaklEVWdMeThnYldWMGFHOWtJQ0owWlhOMEtDbDJiMmxrSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TnpVdE56a0tJQ0FnSUM4dklHNWxkeUJOWlhSb2IyUkpibVp2S0hzS0lDQWdJQzh2SUNBZ2MyVnNaV04wYjNJNklHNWxkeUJoY21NMExsTjBZWFJwWTBKNWRHVnpLRzFsZEdodlpGTmxiR1ZqZEc5eUtDZDBaWE4wS0NsMmIybGtKeWtwTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQnNZWE4wUTJGc2JHVmtPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9NU2tzQ2lBZ0lDQXZMeUI5S1N3S0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk56VXROemtLSUNBZ0lDOHZJRzVsZHlCTlpYUm9iMlJKYm1adktIc0tJQ0FnSUM4dklDQWdjMlZzWldOMGIzSTZJRzVsZHlCaGNtTTBMbE4wWVhScFkwSjVkR1Z6S0cxbGRHaHZaRk5sYkdWamRHOXlLQ2QwWlhOMEtDbDJiMmxrSnlrcExBb2dJQ0FnTHk4Z0lDQmpiMjlzWkc5M2Jqb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtERXBMQW9nSUNBZ0x5OGdJQ0JzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlCOUtTd0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJR3hoYzNSRFlXeHNaV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8zTlMwM09Rb2dJQ0FnTHk4Z2JtVjNJRTFsZEdodlpFbHVabThvZXdvZ0lDQWdMeThnSUNCelpXeGxZM1J2Y2pvZ2JtVjNJR0Z5WXpRdVUzUmhkR2xqUW5sMFpYTW9iV1YwYUc5a1UyVnNaV04wYjNJb0ozUmxjM1FvS1hadmFXUW5LU2tzQ2lBZ0lDQXZMeUFnSUdOdmIyeGtiM2R1T2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJSDBwTEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvM05DMDRNQW9nSUNBZ0x5OGdiV1YwYUc5a2N6b2dibVYzSUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1S0FvZ0lDQWdMeThnSUNCdVpYY2dUV1YwYUc5a1NXNW1ieWg3Q2lBZ0lDQXZMeUFnSUNBZ2MyVnNaV04wYjNJNklHNWxkeUJoY21NMExsTjBZWFJwWTBKNWRHVnpLRzFsZEdodlpGTmxiR1ZqZEc5eUtDZDBaWE4wS0NsMmIybGtKeWtwTEFvZ0lDQWdMeThnSUNBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRFTmhiR3hsWkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQjlLU3dLSUNBZ0lDOHZJQ2tzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMk9TMDRNUW9nSUNBZ0x5OGdkR2hwY3k1d2JIVm5hVzV6S0d0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnVUd4MVoybHVTVzVtYnloN0NpQWdJQ0F2THlBZ0lHeGhjM1JXWVd4cFpGSnZkVzVrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdiR0Z6ZEVOaGJHeGxaRG9nYm1WM0lHRnlZelF1VldsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUdGa2JXbHVVSEpwZG1sc1pXZGxjem9nYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrc0NpQWdJQ0F2THlBZ0lHMWxkR2h2WkhNNklHNWxkeUJoY21NMExrUjVibUZ0YVdOQmNuSmhlU2dLSUNBZ0lDOHZJQ0FnSUNCdVpYY2dUV1YwYUc5a1NXNW1ieWg3Q2lBZ0lDQXZMeUFnSUNBZ0lDQnpaV3hsWTNSdmNqb2dibVYzSUdGeVl6UXVVM1JoZEdsalFubDBaWE1vYldWMGFHOWtVMlZzWldOMGIzSW9KM1JsYzNRb0tYWnZhV1FuS1Nrc0NpQWdJQ0F2THlBZ0lDQWdJQ0JqYjI5c1pHOTNiam9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNBZ0lDQWdiR0Z6ZEVOaGJHeGxaRG9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNBZ0lIMHBMQW9nSUNBZ0x5OGdJQ0FwTEFvZ0lDQWdMeThnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCc1lYTjBWbUZzYVdSU2IzVnVaRG9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalk1TFRneENpQWdJQ0F2THlCMGFHbHpMbkJzZFdkcGJuTW9hMlY1S1M1MllXeDFaU0E5SUc1bGR5QlFiSFZuYVc1SmJtWnZLSHNLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrVW05MWJtUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdZV1J0YVc1UWNtbDJhV3hsWjJWek9pQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLU3dLSUNBZ0lDOHZJQ0FnYldWMGFHOWtjem9nYm1WM0lHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNUtBb2dJQ0FnTHk4Z0lDQWdJRzVsZHlCTlpYUm9iMlJKYm1adktIc0tJQ0FnSUM4dklDQWdJQ0FnSUhObGJHVmpkRzl5T2lCdVpYY2dZWEpqTkM1VGRHRjBhV05DZVhSbGN5aHRaWFJvYjJSVFpXeGxZM1J2Y2lnbmRHVnpkQ2dwZG05cFpDY3BLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnZlNrc0NpQWdJQ0F2THlBZ0lDa3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalk1TFRneENpQWdJQ0F2THlCMGFHbHpMbkJzZFdkcGJuTW9hMlY1S1M1MllXeDFaU0E5SUc1bGR5QlFiSFZuYVc1SmJtWnZLSHNLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrVW05MWJtUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdZV1J0YVc1UWNtbDJhV3hsWjJWek9pQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLU3dLSUNBZ0lDOHZJQ0FnYldWMGFHOWtjem9nYm1WM0lHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNUtBb2dJQ0FnTHk4Z0lDQWdJRzVsZHlCTlpYUm9iMlJKYm1adktIc0tJQ0FnSUM4dklDQWdJQ0FnSUhObGJHVmpkRzl5T2lCdVpYY2dZWEpqTkM1VGRHRjBhV05DZVhSbGN5aHRaWFJvYjJSVFpXeGxZM1J2Y2lnbmRHVnpkQ2dwZG05cFpDY3BLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnZlNrc0NpQWdJQ0F2THlBZ0lDa3NDaUFnSUNBdkx5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnYkdGemRFTmhiR3hsWkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0Nrc0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TmprdE9ERUtJQ0FnSUM4dklIUm9hWE11Y0d4MVoybHVjeWhyWlhrcExuWmhiSFZsSUQwZ2JtVjNJRkJzZFdkcGJrbHVabThvZXdvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdSU2IzVnVaRG9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0JoWkcxcGJsQnlhWFpwYkdWblpYTTZJRzVsZHlCaGNtTTBMa0p2YjJ3b1ptRnNjMlVwTEFvZ0lDQWdMeThnSUNCdFpYUm9iMlJ6T2lCdVpYY2dZWEpqTkM1RWVXNWhiV2xqUVhKeVlYa29DaUFnSUNBdkx5QWdJQ0FnYm1WM0lFMWxkR2h2WkVsdVptOG9ld29nSUNBZ0x5OGdJQ0FnSUNBZ2MyVnNaV04wYjNJNklHNWxkeUJoY21NMExsTjBZWFJwWTBKNWRHVnpLRzFsZEdodlpGTmxiR1ZqZEc5eUtDZDBaWE4wS0NsMmIybGtKeWtwTEFvZ0lDQWdMeThnSUNBZ0lDQWdZMjl2YkdSdmQyNDZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCOUtTd0tJQ0FnSUM4dklDQWdLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vYVc1MElESTNDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIQnNkV2RwYm5NZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCUWJIVm5hVzVKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNCc2RXZHBibk1uSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd2JIVm5hVzV6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pZNUxUZ3hDaUFnSUNBdkx5QjBhR2x6TG5Cc2RXZHBibk1vYTJWNUtTNTJZV3gxWlNBOUlHNWxkeUJRYkhWbmFXNUpibVp2S0hzS0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa1VtOTFibVE2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ1kyOXZiR1J2ZDI0NklHNWxkeUJoY21NMExsVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQnNZWE4wUTJGc2JHVmtPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnWVdSdGFXNVFjbWwyYVd4bFoyVnpPaUJ1WlhjZ1lYSmpOQzVDYjI5c0tHWmhiSE5sS1N3S0lDQWdJQzh2SUNBZ2JXVjBhRzlrY3pvZ2JtVjNJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVLQW9nSUNBZ0x5OGdJQ0FnSUc1bGR5Qk5aWFJvYjJSSmJtWnZLSHNLSUNBZ0lDOHZJQ0FnSUNBZ0lITmxiR1ZqZEc5eU9pQnVaWGNnWVhKak5DNVRkR0YwYVdOQ2VYUmxjeWh0WlhSb2IyUlRaV3hsWTNSdmNpZ25kR1Z6ZENncGRtOXBaQ2NwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJR052YjJ4a2IzZHVPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQnNZWE4wUTJGc2JHVmtPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ2ZTa3NDaUFnSUNBdkx5QWdJQ2tzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRVJsYlc4dVgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsT2dvZ0lDQWdZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Bb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVDQUFCRUNZR0FBUVZIM3gxQ0FBQUFBQUFBQUFBQjNCc2RXZHBibk1JQUFBQUFBQUFBQUVFcDRBQTNrSUFBRUlBQURFYkl4TkJBTEpDQUFBeEdTTVNSREVZSXhOQkFLQkNBQUEyR2dDQUJJazRqZDJBQk84eUxXMkFCQUpGaUFlQUJNdUIzcmlBQlBlZGJFYUFCSkdSVlVXQUJEZ1UrU3FBQkFCNlRMQ0FCRTBodkthQUJLbThZZkZQQ280S0FFQUFPZ0EwQUM0QUtBQWlBQndBRmdBUUFBcENBQUJDQUFCQ0FBQUFpQUUxUXYvemlBRDhRdi90aUFEcFF2L25pQUREUXYvaGlBQ29Rdi9iaUFDTlF2L1ZpQUIzUXYvUGlBQkdRdi9KaUFBalF2L0RpQUFWUXYrOVF2KzlNUmtqRWpFWUl4SVFSSWdDTmlSRFFnQUFpQUQvSkVOQ0FBQTJHZ0ZKRlNVU1JEWWFBa2tWSlJKRWlBRUJLVThCVUxBa1EwSUFBRFlhQVVrVkpSSkVOaG9DU1JVaUVrUTJHZ05KRlNJU1JFOENUd0pQQW9nQkFDbFBBVkN3SkVOQ0FBQTJHZ0ZKRlNVU1JJZ0JBaVJEUWdBQU5ob0JTUlVsRWtTSUFTVXBUd0ZRc0NSRFFnQUFOaG9CU1JVbEVrU0lBUmtwVHdGUXNDUkRRZ0FBTmhvQlNTTlpKQXVCQWdoTEFSVVNSRmNDQUlnQkFpbFBBVkN3SkVOQ0FBQ0lBUW9wVHdGUXNDUkRRZ0FBTmhvQlNTTlpKQXVCQWdoTEFSVVNSRmNDQURZYUFra1ZJaEpFRnpZYUEwa1ZJaEpFRjA4Q1R3SlBBb2dBNWlSRFFnQUFOaG9CU1NOWkpBdUJBZ2hMQVJVU1JGY0NBSWdBN0NSRFFnQUFLQ3BRS2xCSkl5SllzRWtpSWxpd0tDcFFLbEFTUkltS0FnRkNBQUNML2lNaVdCZUwveU1pV0JjSUZvditJaUpZRjR2L0lpSllGd2dXS0U4Q1VFOEJVSW1LQXdGQ0FBQ0wvU09ML2wxSmpQMGlpLzlkU1l6OWlZb0JBRUlBQUl2L0l5SllpLzhpSWxnb1R3SlFUd0ZRU1NNaVdFNEJTU0lpV0NoUEExQlBBVkNMLzA4Q0VrU0wveEpFaVlvQkFVSUFBSXYvaVlvQkFVSUFBSXYvaVlvQkFVSUFBQ3VMLzFDK1JFa2xJbGdYSXcxRWlVSUFBSUFFYldGcGJyNUVTU1VpV0JjakRVU0ppZ01BUWdBQWkvOFdLNHY5VUNPQkd3aUJBZ2lML29FVUN3aUJEQWhQQXJ1SmlnRUFRZ0FBZ0FFQUl5TlVKd1VWZ1FRU1JDZ25CVkFuQkZBbkJGQWtGbGNHQWs4QlVDZ25CRkFxVUNwUVR3SlFnUnNXVndZQ1VFOEJVQ3VMLzFCSnZFaFBBYitKUWdBQWlRPT0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
