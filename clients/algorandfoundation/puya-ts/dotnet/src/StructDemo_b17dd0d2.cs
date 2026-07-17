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

namespace Arc56.Generated.algorandfoundation.puya_ts.StructDemo_b17dd0d2
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0RGVtbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3RGOEM1MjlCQiI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifV0sIlBsdWdpbkluZm8iOlt7Im5hbWUiOiJsYXN0VmFsaWRSb3VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb29sZG93biIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0Q2FsbGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFkbWluUHJpdmlsZWdlcyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibWV0aG9kcyIsInR5cGUiOiJQbHVnaW5JbmZvTWV0aG9kc1tdIn1dLCJWZWN0b3IiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InkiLCJ0eXBlIjoidWludDY0In1dLCJQbHVnaW5JbmZvTWV0aG9kcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlWzRdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdFZlY3RvckNyZWF0aW9uQW5kRXF1YWxpdHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkVmVjdG9ycyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtdXRhdGVWZWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdYIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdZIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImltcGxpY2l0Q2FzdGluZ0FuZFNwcmVhZGluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9BbmRGcm9tQnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvTmF0aXZlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3RGOEM1MjlCQiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wsKGJ5dGVbNF0sdWludDY0LHVpbnQ2NClbXSkiLCJzdHJ1Y3QiOiJQbHVnaW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFpbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCwoYnl0ZVs0XSx1aW50NjQsdWludDY0KVtdKSIsInN0cnVjdCI6IlBsdWdpbkluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRMYXN0Q2FsbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhc3RDYWxsZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UGx1Z2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMwOCwzMjNdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE0LDMyOV0sImVycm9yTWVzc2FnZSI6Ikxhc3QgY2FsbGVkIG5vdCB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyLDMyNywzODRdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxLDM0MSwzOTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDcsMTU1LDE5MCwyMjcsMjY1LDI3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBWZWN0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTksMzQ5LDQwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTgsMjA2LDM2MCwzNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXhOaUE0SURBS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaWNHeDFaMmx1Y3lJZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0lDSnRZV2x1SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdOc1lYTnpJRk4wY25WamRFUmxiVzhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UY0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEZzVNemc0WkdSa0lEQjRaV1l6TWpKa05tUWdNSGd3TWpRMU9EZ3dOeUF3ZUdOaU9ERmtaV0k0SURCNFpqYzVaRFpqTkRZZ01IZzVNVGt4TlRVME5TQXdlRE00TVRSbU9USmhJREI0TURBM1lUUmpZakFnTUhnMFpESXhZbU5oTmlBd2VHRTVZbU0yTVdZeElDOHZJRzFsZEdodlpDQWlkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGtvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZrWkZabFkzUnZjbk1vS0hWcGJuUTJOQ3gxYVc1ME5qUXBMQ2gxYVc1ME5qUXNkV2x1ZERZMEtTa29kV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltMTFkR0YwWlZabFkzUnZjaWdvZFdsdWREWTBMSFZwYm5RMk5Da3NkV2x1ZERZMExIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1sdGNHeHBZMmwwUTJGemRHbHVaMEZ1WkZOd2NtVmhaR2x1Wnlnb2RXbHVkRFkwTEhWcGJuUTJOQ2twZG05cFpDSXNJRzFsZEdodlpDQWlkRzlCYm1SR2NtOXRRbmwwWlhNb0tIVnBiblEyTkN4MWFXNTBOalFwS1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpZEc5T1lYUnBkbVVvS0hWcGJuUTJOQ3gxYVc1ME5qUXBLU2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwVUd4MVoybHVLSE4wY21sdVp5a29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDd29ZbmwwWlZzMFhTeDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZEtTSXNJRzFsZEdodlpDQWlaMlYwVFdGcGJpZ3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NLR0o1ZEdWYk5GMHNkV2x1ZERZMExIVnBiblEyTkNsYlhTa2lMQ0J0WlhSb2IyUWdJbk5sZEV4aGMzUkRZV3hzWldRb2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBVR3gxWjJsdUtITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhrZ1lXUmtWbVZqZEc5eWN5QnRkWFJoZEdWV1pXTjBiM0lnYVcxd2JHbGphWFJEWVhOMGFXNW5RVzVrVTNCeVpXRmthVzVuSUhSdlFXNWtSbkp2YlVKNWRHVnpJSFJ2VG1GMGFYWmxJR2RsZEZCc2RXZHBiaUJuWlhSTllXbHVJSE5sZEV4aGMzUkRZV3hzWldRZ2MyVjBVR3gxWjJsdUNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdOc1lYTnpJRk4wY25WamRFUmxiVzhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG5SbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnYkc5bktIWXhMbmdwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdiRzluS0hZeExua3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNUtDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qcFRkSEoxWTNSRVpXMXZMbUZrWkZabFkzUnZjbk5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUldaV04wYjNKek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklIQjFZbXhwWXlCaFpHUldaV04wYjNKektIWXhPaUJXWldOMGIzSXNJSFl5T2lCV1pXTjBiM0lwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGWmxZM1J2Y2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ZtVmpkRzl5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnZURvZ2JtVjNJRUZTUXpSVmFXNTBOalFvZGpFdWVDNWhjMVZwYm5RMk5DZ3BJQ3NnZGpJdWVDNWhjMVZwYm5RMk5DZ3BLU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QjVPaUJ1WlhjZ1FWSkRORlZwYm5RMk5DaDJNUzU1TG1GelZXbHVkRFkwS0NrZ0t5QjJNaTU1TG1GelZXbHVkRFkwS0NrcExBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem95TUMweU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QldaV04wYjNJb2V3b2dJQ0FnTHk4Z0lDQjRPaUJ1WlhjZ1FWSkRORlZwYm5RMk5DaDJNUzU0TG1GelZXbHVkRFkwS0NrZ0t5QjJNaTU0TG1GelZXbHVkRFkwS0NrcExBb2dJQ0FnTHk4Z0lDQjVPaUJ1WlhjZ1FWSkRORlZwYm5RMk5DaDJNUzU1TG1GelZXbHVkRFkwS0NrZ0t5QjJNaTU1TG1GelZXbHVkRFkwS0NrcExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSEIxWW14cFl5QmhaR1JXWldOMGIzSnpLSFl4T2lCV1pXTjBiM0lzSUhZeU9pQldaV04wYjNJcElIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wUkdWdGJ5NXRkWFJoZEdWV1pXTjBiM0piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdGRYUmhkR1ZXWldOMGIzSTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdjSFZpYkdsaklHMTFkR0YwWlZabFkzUnZjaWgyTVRvZ1ZtVmpkRzl5TENCdVpYZFlPaUJCVWtNMFZXbHVkRFkwTENCdVpYZFpPaUJCVWtNMFZXbHVkRFkwS1RvZ1ZtVmpkRzl5SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGWmxZM1J2Y2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSFl4TG5nZ1BTQnVaWGRZQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnZGpFdWVTQTlJRzVsZDFrS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJRGdLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiWFYwWVhSbFZtVmpkRzl5S0hZeE9pQldaV04wYjNJc0lHNWxkMWc2SUVGU1F6UlZhVzUwTmpRc0lHNWxkMWs2SUVGU1F6UlZhVzUwTmpRcE9pQldaV04wYjNJZ2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxtbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhVzF3YkdsamFYUkRZWE4wYVc1blFXNWtVM0J5WldGa2FXNW5LSFl4T2lCV1pXTjBiM0lwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlGWmxZM1J2Y2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdOdmJuTjBJSFl5SUQwZ2JtVjNJRlpsWTNSdmNpaDJNU2tLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURnZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdZMjl1YzNRZ2RqTWdQU0J1WlhjZ1ZtVmpkRzl5S0hzZ0xpNHVkaklnZlNrS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnWVhOelpYSjBLSFl4TG1KNWRHVnpJRDA5UFNCMk1pNWllWFJsY3lrS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJoYzNObGNuUW9kak11WW5sMFpYTWdQVDA5SUhZeExtSjVkR1Z6S1FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhCMVlteHBZeUJwYlhCc2FXTnBkRU5oYzNScGJtZEJibVJUY0hKbFlXUnBibWNvZGpFNklGWmxZM1J2Y2lrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JFWlcxdkxuUnZRVzVrUm5KdmJVSjVkR1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOUJibVJHY205dFFubDBaWE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2UVc1a1JuSnZiVUo1ZEdWektIWXhPaUJXWldOMGIzSXBPaUJXWldOMGIzSWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVm1WamRHOXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk9sTjBjblZqZEVSbGJXOHVkRzlPWVhScGRtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwYjA1aGRHbDJaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzlPWVhScGRtVW9kakU2SUZabFkzUnZjaWtnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ZtVmpkRzl5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0YzNSeWRXTjBMbUZzWjI4dWRITTZPbE4wY25WamRFUmxiVzh1WjJWMFVHeDFaMmx1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVR3gxWjJsdU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIQjFZbXhwWXlCblpYUlFiSFZuYVc0b2EyVjVPaUJ6ZEhKcGJtY3BPaUJRYkhWbmFXNUpibVp2SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIQnNkV2RwYm5NZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCUWJIVm5hVzVKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNCc2RXZHBibk1uSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd2JIVm5hVzV6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1kyOXVjM1FnZG1Gc2RXVWdQU0JqYkc5dVpTaDBhR2x6TG5Cc2RXZHBibk1vYTJWNUtTNTJZV3gxWlNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pVekxUVTBDaUFnSUNBdkx5QmpiMjV6ZENCMllXeDFaU0E5SUdOc2IyNWxLSFJvYVhNdWNHeDFaMmx1Y3loclpYa3BMblpoYkhWbEtRb2dJQ0FnTHk4Z1lYTnpaWEowS0haaGJIVmxMbXhoYzNSRFlXeHNaV1F1WVhOVmFXNTBOalFvS1NBK0lEQXNJQ2RNWVhOMElHTmhiR3hsWkNCdWIzUWdlbVZ5YnljcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVRZS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklHRnpjMlZ5ZENoMllXeDFaUzVzWVhOMFEyRnNiR1ZrTG1GelZXbHVkRFkwS0NrZ1BpQXdMQ0FuVEdGemRDQmpZV3hzWldRZ2JtOTBJSHBsY204bktRb2dJQ0FnWW5SdmFRb2dJQ0FnWVhOelpYSjBJQzh2SUV4aGMzUWdZMkZzYkdWa0lHNXZkQ0I2WlhKdkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGQnNkV2RwYmloclpYazZJSE4wY21sdVp5azZJRkJzZFdkcGJrbHVabThnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG1kbGRFMWhhVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUk5ZV2x1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUhCc2RXZHBiaUE5SUVKdmVEeFFiSFZuYVc1SmJtWnZQaWg3SUd0bGVUb2dKMjFoYVc0bklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnRZV2x1SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdOdmJuTjBJSFpoYkhWbElEMGdZMnh2Ym1Vb2RHaHBjeTV3YkhWbmFXNHVkbUZzZFdVcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklIQnNkV2RwYmlBOUlFSnZlRHhRYkhWbmFXNUpibVp2UGloN0lHdGxlVG9nSjIxaGFXNG5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p0WVdsdUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRjM1J5ZFdOMExtRnNaMjh1ZEhNNk5Ua3ROakFLSUNBZ0lDOHZJR052Ym5OMElIWmhiSFZsSUQwZ1kyeHZibVVvZEdocGN5NXdiSFZuYVc0dWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kbUZzZFdVdWJHRnpkRU5oYkd4bFpDNWhjMVZwYm5RMk5DZ3BJRDRnTUN3Z0oweGhjM1FnWTJGc2JHVmtJRzV2ZENCNlpYSnZKeWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhOZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxemRISjFZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWVhOelpYSjBLSFpoYkhWbExteGhjM1JEWVd4c1pXUXVZWE5WYVc1ME5qUW9LU0ErSURBc0lDZE1ZWE4wSUdOaGJHeGxaQ0J1YjNRZ2VtVnlieWNwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR0Z6ZENCallXeHNaV1FnYm05MElIcGxjbThLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVFdGcGJpZ3BJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzF6ZEhKMVkzUXVZV3huYnk1MGN6bzZVM1J5ZFdOMFJHVnRieTV6WlhSTVlYTjBRMkZzYkdWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVEdGemRFTmhiR3hsWkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFRHRnpkRU5oYkd4bFpDaHJaWGs2SUhOMGNtbHVaeXdnYVc1a1pYZzZJSFZwYm5RMk5Dd2diR0Z6ZEVOaGJHeGxaRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJ3YkhWbmFXNXpJRDBnUW05NFRXRndQSE4wY21sdVp5d2dVR3gxWjJsdVNXNW1iejRvZXlCclpYbFFjbVZtYVhnNklDZHdiSFZuYVc1ekp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljR3gxWjJsdWN5SUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2RHaHBjeTV3YkhWbmFXNXpLR3RsZVNrdWRtRnNkV1V1YldWMGFHOWtjMXRwYm1SbGVGMHViR0Z6ZEVOaGJHeGxaQ0E5SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2hzWVhOMFEyRnNiR1ZrS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURJd0NpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElEUXhDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMXpkSEoxWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRFeGhjM1JEWVd4c1pXUW9hMlY1T2lCemRISnBibWNzSUdsdVpHVjRPaUIxYVc1ME5qUXNJR3hoYzNSRFlXeHNaV1E2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFhOMGNuVmpkQzVoYkdkdkxuUnpPanBUZEhKMVkzUkVaVzF2TG5ObGRGQnNkV2RwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRkJzZFdkcGJqb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMWE4wY25WamRDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBVR3gxWjJsdUtHdGxlVG9nYzNSeWFXNW5LU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCd2JIVm5hVzV6SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnVUd4MVoybHVTVzVtYno0b2V5QnJaWGxRY21WbWFYZzZJQ2R3YkhWbmFXNXpKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0d4MVoybHVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdGMzUnlkV04wTG1Gc1oyOHVkSE02TmprdE9ERUtJQ0FnSUM4dklIUm9hWE11Y0d4MVoybHVjeWhyWlhrcExuWmhiSFZsSUQwZ2JtVjNJRkJzZFdkcGJrbHVabThvZXdvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdSU2IzVnVaRG9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0JoWkcxcGJsQnlhWFpwYkdWblpYTTZJRzVsZHlCaGNtTTBMa0p2YjJ3b1ptRnNjMlVwTEFvZ0lDQWdMeThnSUNCdFpYUm9iMlJ6T2lCdVpYY2dZWEpqTkM1RWVXNWhiV2xqUVhKeVlYa29DaUFnSUNBdkx5QWdJQ0FnYm1WM0lFMWxkR2h2WkVsdVptOG9ld29nSUNBZ0x5OGdJQ0FnSUNBZ2MyVnNaV04wYjNJNklHNWxkeUJoY21NMExsTjBZWFJwWTBKNWRHVnpLRzFsZEdodlpGTmxiR1ZqZEc5eUtDZDBaWE4wS0NsMmIybGtKeWtwTEFvZ0lDQWdMeThnSUNBZ0lDQWdZMjl2YkdSdmQyNDZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCOUtTd0tJQ0FnSUM4dklDQWdLU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREZpTURBd01XRTNPREF3TUdSbE1EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExYTjBjblZqZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFVHeDFaMmx1S0d0bGVUb2djM1J5YVc1bktTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFSQUlBQ1lFQkJVZmZIVUhjR3gxWjJsdWN3Z0FBQUFBQUFBQUFBUnRZV2x1TVJ0QkFGVXhHUlJFTVJoRWdnb0VpVGlOM1FUdk1pMXRCQUpGaUFjRXk0SGV1QVQzbld4R0JKR1JWVVVFT0JUNUtnUUFla3l3QkUwaHZLWUVxYnhoOFRZYUFJNEtBQWtBRHdBNkFGOEFoUUNUQUtFQXhBRFRBUVlBTVJrVU1SZ1VFRU1xc0Nxd0lrTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRVN3RWxXMHNCSlZzSUZrOENKRnRQQWlSYkNCWlFLRXhRc0NKRE5ob0JTUlVqRWtRMkdnSkpGU1FTUkRZYUEwa1ZKQkpFVGdKY0FFeGNDQ2hNVUxBaVF6WWFBVWtWSXhKRVNWY0FDRXNCVndnSVVFbFhBQWhMQVZjSUNGQkxBazhDRWtRU1JDSkROaG9CU1JVakVrUW9URkN3SWtNMkdnRkpGU01TUkNoTVVMQWlRellhQVVrbFdZRUNDRXNCRlJKRVZ3SUFLVXhRU2I1RVRDTWt1aGRFS0V4UXNDSkRLNzVFS3lNa3VoZEVLRXhRc0NKRE5ob0JTU1ZaZ1FJSVN3RVZFa1JYQWdBMkdnSkpGU1FTUkJjMkdnTkpGU1FTUkNsUEExQlBBb0VVQzRFcENFOEN1eUpETmhvQlNTVlpnUUlJU3dFVkVrUlhBZ0FwVEZCSnZFaUFNUUFBQUFBQUFBQUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFHd0FCcDRBQTNnQUFBQUFBQUFBQkFBQUFBQUFBQUFHL0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
