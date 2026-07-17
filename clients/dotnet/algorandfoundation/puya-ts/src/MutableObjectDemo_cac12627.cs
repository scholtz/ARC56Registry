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

namespace Arc56.Generated.algorandfoundation.puya_ts.MutableObjectDemo_cac12627
{


    public class MutableObjectDemoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MutableObjectDemoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

            public class Point : AVMObjectType
            {
                public ulong Y { get; set; }

                public ulong X { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Point Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Point();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is ulong vYValue) { ret.Y = vYValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Point);
                }
                public bool Equals(Point? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Point left, Point right)
                {
                    return EqualityComparer<Point>.Default.Equals(left, right);
                }
                public static bool operator !=(Point left, Point right)
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

            public class VectorPoint : AVMObjectType
            {
                public Structs.Vector V { get; set; } = new Structs.Vector();

                public Structs.Point P { get; set; } = new Structs.Point();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(V.ToByteArray());
                    ret.AddRange(P.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VectorPoint Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VectorPoint();
                    ret.V = Structs.Vector.Parse(queue.ToArray());
                    { var consumedV = ret.V.ToByteArray().Length; for (int i = 0; i < consumedV && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.P = Structs.Point.Parse(queue.ToArray());
                    { var consumedP = ret.P.ToByteArray().Length; for (int i = 0; i < consumedP && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VectorPoint);
                }
                public bool Equals(VectorPoint? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VectorPoint left, VectorPoint right)
                {
                    return EqualityComparer<VectorPoint>.Default.Equals(left, right);
                }
                public static bool operator !=(VectorPoint left, VectorPoint right)
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
        /// <param name="vp"> VectorPoint</param>
        public async Task TestNestedObjects(Structs.VectorPoint vp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 39, 169, 186 };

            var result = await base.CallApp(new List<object> { abiHandle, vp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNestedObjects_Transactions(Structs.VectorPoint vp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 39, 169, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle, vp }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestMethodSelector(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 103, 10, 85 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestMethodSelector_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 103, 10, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task TestAssertMatch(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 200, 31, 91 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAssertMatch_Transactions(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 200, 31, 91 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            return await base.MakeTransactionList(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="p"> Point</param>
        public async Task TestArc4Encoding(Structs.Point p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 131, 92, 35 };

            var result = await base.CallApp(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestArc4Encoding_Transactions(Structs.Point p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 131, 92, 35 };

            return await base.MakeTransactionList(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXV0YWJsZU9iamVjdERlbW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUGx1Z2luSW5mbyI6W3sibmFtZSI6Imxhc3RWYWxpZFJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvb2xkb3duIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RDYWxsZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWRtaW5Qcml2aWxlZ2VzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJtZXRob2RzIiwidHlwZSI6IlBsdWdpbkluZm9NZXRob2RzW10ifV0sIlBvaW50IjpbeyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9XSwiVmVjdG9yIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ2NCJ9XSwiVmVjdG9yUG9pbnQiOlt7Im5hbWUiOiJ2IiwidHlwZSI6IlZlY3RvciJ9LHsibmFtZSI6InAiLCJ0eXBlIjoiUG9pbnQifV0sIlBsdWdpbkluZm9NZXRob2RzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJ5dGVbNF0ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0VmVjdG9yQ3JlYXRpb25BbmRFcXVhbGl0eSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRWZWN0b3JzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11dGF0ZVZlY3RvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW1wbGljaXRDYXN0aW5nQW5kU3ByZWFkaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TmVzdGVkT2JqZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQpLCh1aW50NjQsdWludDY0KSkiLCJzdHJ1Y3QiOiJWZWN0b3JQb2ludCIsIm5hbWUiOiJ2cCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWV0aG9kU2VsZWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFzc2VydE1hdGNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFyYzRFbmNvZGluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQb2ludCIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wsKGJ5dGVbNF0sdWludDY0LHVpbnQ2NClbXSkiLCJzdHJ1Y3QiOiJQbHVnaW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFpbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCwoYnl0ZVs0XSx1aW50NjQsdWludDY0KVtdKSIsInN0cnVjdCI6IlBsdWdpbkluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQbHVnaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTIzLDUzOF0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OThdLCJlcnJvck1lc3NhZ2UiOiJFbmNvZGVkIG9yZGVyIHNob3VsZCBiZSBzd2FwcGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU1XSwiZXJyb3JNZXNzYWdlIjoiRm9yIHRoZSBwdXJwb3NlIG9mIHRoaXMgdGVzdCwgYSBzaG91bGQgbm90IGVxdWFsIGIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjksNTQ0XSwiZXJyb3JNZXNzYWdlIjoiTGFzdCBjYWxsZWQgbm90IHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjMsMzY5LDQwNyw0MjgsNDMzLDQzNV0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjcsNTQyXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNiw1NTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTQsNTY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMywyMTEsMzc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQ1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RzL2FwcHJvdmFscy9tdXRhYmxlLW9iamVjdC5hbGdvLnRzOjpQb2ludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCwxNTgsMTk1LDIzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0cy9hcHByb3ZhbHMvbXV0YWJsZS1vYmplY3QuYWxnby50czo6VmVjdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RzL2FwcHJvdmFscy9tdXRhYmxlLW9iamVjdC5hbGdvLnRzOjpWZWN0b3JQb2ludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBd0lERWdNVFlLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpY0d4MVoybHVjeUlnSW0xaGFXNGlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMTFkR0ZpYkdWUFltcGxZM1JFWlcxdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREU0Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0T1RNNE9HUmtaQ0F3ZUdWbU16SXlaRFprSURCNE1ESTBOVGc0TURjZ01IaGpZamd4WkdWaU9DQXdlR0poTWpkaE9XSmhJREI0TW1ZMk56QmhOVFVnTUhoa05HTTRNV1kxWWlBd2VHWTBPRE0xWXpJeklEQjRNemd4TkdZNU1tRWdNSGd3TURkaE5HTmlNQ0F3ZUdFNVltTTJNV1l4SUM4dklHMWxkR2h2WkNBaWRHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIa29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRlpsWTNSdmNuTW9LSFZwYm5RMk5DeDFhVzUwTmpRcExDaDFhVzUwTmpRc2RXbHVkRFkwS1Nrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW0xMWRHRjBaVlpsWTNSdmNpZ29kV2x1ZERZMExIVnBiblEyTkNrc2RXbHVkRFkwTEhWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWx0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaeWdvZFdsdWREWTBMSFZwYm5RMk5Da3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRTVsYzNSbFpFOWlhbVZqZEhNb0tDaDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ2twS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSTlpYUm9iMlJUWld4bFkzUnZjaWdwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEVGemMyVnlkRTFoZEdOb0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFFYSmpORVZ1WTI5a2FXNW5LQ2gxYVc1ME5qUXNkV2x1ZERZMEtTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUlFiSFZuYVc0b2MzUnlhVzVuS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTENoaWVYUmxXelJkTEhWcGJuUTJOQ3gxYVc1ME5qUXBXMTBwSWl3Z2JXVjBhRzlrSUNKblpYUk5ZV2x1S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN3b1lubDBaVnMwWFN4MWFXNTBOalFzZFdsdWREWTBLVnRkS1NJc0lHMWxkR2h2WkNBaWMyVjBVR3gxWjJsdUtITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhrZ1lXUmtWbVZqZEc5eWN5QnRkWFJoZEdWV1pXTjBiM0lnYVcxd2JHbGphWFJEWVhOMGFXNW5RVzVrVTNCeVpXRmthVzVuSUhSbGMzUk9aWE4wWldSUFltcGxZM1J6SUcxaGFXNWZkR1Z6ZEUxbGRHaHZaRk5sYkdWamRHOXlYM0p2ZFhSbFFEa2dkR1Z6ZEVGemMyVnlkRTFoZEdOb0lIUmxjM1JCY21NMFJXNWpiMlJwYm1jZ1oyVjBVR3gxWjJsdUlHZGxkRTFoYVc0Z2MyVjBVR3gxWjJsdUNpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRFMWxkR2h2WkZObGJHVmpkRzl5WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUk5aWFJvYjJSVFpXeGxZM1J2Y2lncElIc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmRYUmhZbXhsVDJKcVpXTjBSR1Z0YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuUmxjM1JXWldOMGIzSkRjbVZoZEdsdmJrRnVaRVZ4ZFdGc2FYUjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdZMjl1YzNRZ2RqRTZJRlpsWTNSdmNpQTlJSHNnZVRvZ01Td2dlRG9nTUNCOUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCc2IyY29kakV1ZUNrS0lDQWdJSE4zWVhBS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHeHZaeWgyTVM1NUtRb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdjSFZpYkdsaklIUmxjM1JXWldOMGIzSkRjbVZoZEdsdmJrRnVaRVZ4ZFdGc2FYUjVLQ2tnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1aFpHUldaV04wYjNKelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV1JrVm1WamRHOXljem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCd2RXSnNhV01nWVdSa1ZtVmpkRzl5Y3loMk1Ub2dWbVZqZEc5eUxDQjJNam9nVm1WamRHOXlLVG9nVm1WamRHOXlJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcFdaV04wYjNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBXWldOMGIzSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUI0T2lCMk1TNTRJQ3NnZGpJdWVDd0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNzS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QjVPaUIyTVM1NUlDc2dkakl1ZVN3S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdLd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TWpJdE1qVUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lIZzZJSFl4TG5nZ0t5QjJNaTU0TEFvZ0lDQWdMeThnSUNCNU9pQjJNUzU1SUNzZ2RqSXVlU3dLSUNBZ0lDOHZJSDBLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIQjFZbXhwWXlCaFpHUldaV04wYjNKektIWXhPaUJXWldOMGIzSXNJSFl5T2lCV1pXTjBiM0lwT2lCV1pXTjBiM0lnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1dGRYUmhkR1ZXWldOMGIzSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0ZFhSaGRHVldaV04wYjNJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdjSFZpYkdsaklHMTFkR0YwWlZabFkzUnZjaWgyTVRvZ1ZtVmpkRzl5TENCdVpYZFlPaUIxYVc1ME5qUXNJRzVsZDFrNklIVnBiblEyTkNrNklGWmxZM1J2Y2lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82Vm1WamRHOXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdkakV1ZUNBOUlHNWxkMWdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCMk1TNTVJRDBnYm1WM1dRb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnT0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIQjFZbXhwWXlCdGRYUmhkR1ZXWldOMGIzSW9kakU2SUZabFkzUnZjaXdnYm1WM1dEb2dkV2x1ZERZMExDQnVaWGRaT2lCMWFXNTBOalFwT2lCV1pXTjBiM0lnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1cGJYQnNhV05wZEVOaGMzUnBibWRCYm1SVGNISmxZV1JwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hWaWJHbGpJR2x0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaeWgyTVRvZ1ZtVmpkRzl5S1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82Vm1WamRHOXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnWTI5dWMzUWdkak1nUFNCN0lDNHVMbll5SUgwS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdZWE56WlhKMEtIWXpMbmdnUFQwOUlIWXhMbmdwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QmhjM05sY25Rb2RqTXVlU0E5UFQwZ2RqRXVlU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2gyTXl3Z2RqRXBDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndkV0pzYVdNZ2FXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1bktIWXhPaUJXWldOMGIzSXBJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1ZEdWemRFNWxjM1JsWkU5aWFtVmpkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBUbVZ6ZEdWa1QySnFaV04wY3pvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QndkV0pzYVdNZ2RHVnpkRTVsYzNSbFpFOWlhbVZqZEhNb2RuQTZJRlpsWTNSdmNsQnZhVzUwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPbFpsWTNSdmNsQnZhVzUwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z1kyOXVjM1FnZGpFZ1BTQjdJSGc2SUhad0xuWXVlQ3dnZVRvZ2RuQXVkaTU1SUgwS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHTnZibk4wSUhBeElEMGdleUI0T2lCMmNDNXdMbmdzSUhrNklIWndMbkF1ZVNCOUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNRZ01UWWdNVFlLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1kyOXVjM1FnZG5BeElEMGdleUIyT2lCamJHOXVaU2gyTVNrc0lIQTZJR05zYjI1bEtIQXhLU0I5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUd4dlp5aDJjREV1ZGk1NEtRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTVRZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUd4dlp5aDJjREV1ZGk1NUtRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOVE10TlRRS0lDQWdJQzh2SUd4dlp5aDJjREV1ZGk1NEtRb2dJQ0FnTHk4Z2JHOW5LSFp3TVM1Mkxua3BDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJR3h2WnloMmNERXVkaTU1S1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z2JHOW5LSFp3TVM1d0xuZ3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNVFlnTVRZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUd4dlp5aDJjREV1Y0M1NUtRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOVFV0TlRZS0lDQWdJQzh2SUd4dlp5aDJjREV1Y0M1NEtRb2dJQ0FnTHk4Z2JHOW5LSFp3TVM1d0xua3BDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR3h2WnloMmNERXVjQzU1S1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29kbkF4TENCMmNDa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNBOVBRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBOVBRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnY0hWaWJHbGpJSFJsYzNST1pYTjBaV1JQWW1wbFkzUnpLSFp3T2lCV1pXTjBiM0pRYjJsdWRDa2dld29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFFYTnpaWEowVFdGMFkyaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFFYTnpaWEowVFdGMFkyZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnZEdWemRFRnpjMlZ5ZEUxaGRHTm9LSGc2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJSGs2SUNoaUlEMGdlQ0FxSURJcExBb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPamMzTFRnd0NpQWdJQ0F2THlCamIyNXpkQ0J2WW1vNklGWmxZM1J2Y2lBOUlIc0tJQ0FnSUM4dklDQWdlVG9nS0dJZ1BTQjRJQ29nTWlrc0NpQWdJQ0F2THlBZ0lIZzZJR0lzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNE1TMDROQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvYjJKcUxDQjdDaUFnSUNBdkx5QWdJSGs2SUhnZ0tpQXlMQW9nSUNBZ0x5OGdJQ0I0T2lCNElDb2dNaXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1BUMEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnUFQwS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxjblFnZEdGeVoyVjBJR2x6SUcxaGRHTm9JR1p2Y2lCamIyNWthWFJwYjI1ekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdZMjl1YzNRZ2RpQTlJSHNnZVRvZ2IySnFMbmtzSUhnNklHOWlhaTU0SUgwS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2IySnFMQ0I3SUhnNklIWXVlQ3dnZVRvZ2RpNTVJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29iMkpxTENCN0lIazZJSHNnWjNKbFlYUmxjbFJvWVc0NklIZ2dmU0I5S1FvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2IySnFMQ0I3SUhnNklIc2daM0psWVhSbGNsUm9ZVzQ2SUhnZ2ZTQjlLUW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QjBaWE4wUVhOelpYSjBUV0YwWTJnb2VEb2dkV2x1ZERZMEtTQjdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMblJsYzNSQmNtTTBSVzVqYjJScGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFFYSmpORVZ1WTI5a2FXNW5PZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUhSbGMzUkJjbU0wUlc1amIyUnBibWNvY0RvZ1VHOXBiblFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBRYjJsdWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaHdMbmdnSVQwOUlIQXVlU3dnSjBadmNpQjBhR1VnY0hWeWNHOXpaU0J2WmlCMGFHbHpJSFJsYzNRc0lHRWdjMmh2ZFd4a0lHNXZkQ0JsY1hWaGJDQmlKeWtLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQXlDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVadmNpQjBhR1VnY0hWeWNHOXpaU0J2WmlCMGFHbHpJSFJsYzNRc0lHRWdjMmh2ZFd4a0lHNXZkQ0JsY1hWaGJDQmlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem81TkMwNU53b2dJQ0FnTHk4Z1kyOXVjM1FnYjJKcU9pQldaV04wYjNJZ1BTQjdDaUFnSUNBdkx5QWdJSGc2SUhBdWVDd0tJQ0FnSUM4dklDQWdlVG9nY0M1NUxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TURBS0lDQWdJQzh2SUdGemMyVnlkQ2h3Ulc1amIyUmxaQ0E5UFQwZ2IySnFSVzVqYjJSbFpDNXpiR2xqWlNnNEtTNWpiMjVqWVhRb2IySnFSVzVqYjJSbFpDNXpiR2xqWlNnd0xDQTRLU2tzSUNkRmJtTnZaR1ZrSUc5eVpHVnlJSE5vYjNWc1pDQmlaU0J6ZDJGd2NHVmtKeWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pHbG5JRE1LSUNBZ0lENDlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmJtTnZaR1ZrSUc5eVpHVnlJSE5vYjNWc1pDQmlaU0J6ZDJGd2NHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnZEdWemRFRnlZelJGYm1OdlpHbHVaeWh3T2lCUWIybHVkQ2tnZXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1blpYUlFiSFZuYVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJRYkhWbmFXNDZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TURjS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSUWJIVm5hVzRvYTJWNU9pQnpkSEpwYm1jcE9pQlFiSFZuYVc1SmJtWnZJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QndiSFZuYVc1eklEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1VHeDFaMmx1U1c1bWJ6NG9leUJyWlhsUWNtVm1hWGc2SUNkd2JIVm5hVzV6SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNHeDFaMmx1Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEE0Q2lBZ0lDQXZMeUJqYjI1emRDQjJZV3gxWlNBOUlHTnNiMjVsS0hSb2FYTXVjR3gxWjJsdWN5aHJaWGtwTG5aaGJIVmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRBNExURXdPUW9nSUNBZ0x5OGdZMjl1YzNRZ2RtRnNkV1VnUFNCamJHOXVaU2gwYUdsekxuQnNkV2RwYm5Nb2EyVjVLUzUyWVd4MVpTa0tJQ0FnSUM4dklHRnpjMlZ5ZENoMllXeDFaUzVzWVhOMFEyRnNiR1ZrTG1GelZXbHVkRFkwS0NrZ1BpQXdMQ0FuVEdGemRDQmpZV3hzWldRZ2JtOTBJSHBsY204bktRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV3T1FvZ0lDQWdMeThnWVhOelpYSjBLSFpoYkhWbExteGhjM1JEWVd4c1pXUXVZWE5WYVc1ME5qUW9LU0ErSURBc0lDZE1ZWE4wSUdOaGJHeGxaQ0J1YjNRZ2VtVnlieWNwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR0Z6ZENCallXeHNaV1FnYm05MElIcGxjbThLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGQnNkV2RwYmloclpYazZJSE4wY21sdVp5azZJRkJzZFdkcGJrbHVabThnZXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1blpYUk5ZV2x1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBUV0ZwYmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXdOUW9nSUNBZ0x5OGdjR3gxWjJsdUlEMGdRbTk0UEZCc2RXZHBia2x1Wm04K0tIc2dhMlY1T2lBbmJXRnBiaWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW0xaGFXNGlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUdOdmJuTjBJSFpoYkhWbElEMGdZMnh2Ym1Vb2RHaHBjeTV3YkhWbmFXNHVkbUZzZFdVcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEExQ2lBZ0lDQXZMeUJ3YkhWbmFXNGdQU0JDYjNnOFVHeDFaMmx1U1c1bWJ6NG9leUJyWlhrNklDZHRZV2x1SnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJXRnBiaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFeE5DMHhNVFVLSUNBZ0lDOHZJR052Ym5OMElIWmhiSFZsSUQwZ1kyeHZibVVvZEdocGN5NXdiSFZuYVc0dWRtRnNkV1VwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kbUZzZFdVdWJHRnpkRU5oYkd4bFpDNWhjMVZwYm5RMk5DZ3BJRDRnTUN3Z0oweGhjM1FnWTJGc2JHVmtJRzV2ZENCNlpYSnZKeWtLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoMllXeDFaUzVzWVhOMFEyRnNiR1ZrTG1GelZXbHVkRFkwS0NrZ1BpQXdMQ0FuVEdGemRDQmpZV3hzWldRZ2JtOTBJSHBsY204bktRb2dJQ0FnWW5SdmFRb2dJQ0FnWVhOelpYSjBJQzh2SUV4aGMzUWdZMkZzYkdWa0lHNXZkQ0I2WlhKdkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNVE1LSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJOWVdsdUtDa2dld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTV6WlhSUWJIVm5hVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUlFiSFZuYVc0NkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJRYkhWbmFXNG9hMlY1T2lCemRISnBibWNwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJ3YkhWbmFXNXpJRDBnUW05NFRXRndQSE4wY21sdVp5d2dVR3gxWjJsdVNXNW1iejRvZXlCclpYbFFjbVZtYVhnNklDZHdiSFZuYVc1ekp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljR3gxWjJsdWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRJMExURXpOZ29nSUNBZ0x5OGdkR2hwY3k1d2JIVm5hVzV6S0d0bGVTa3VkbUZzZFdVZ1BTQjdDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaRkp2ZFc1a09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJR052YjJ4a2IzZHVPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnYkdGemRFTmhiR3hsWkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lHRmtiV2x1VUhKcGRtbHNaV2RsY3pvZ2JtVjNJR0Z5WXpRdVFtOXZiQ2htWVd4elpTa3NDaUFnSUNBdkx5QWdJRzFsZEdodlpITTZJRnNLSUNBZ0lDOHZJQ0FnSUNCN0NpQWdJQ0F2THlBZ0lDQWdJQ0J6Wld4bFkzUnZjam9nYm1WM0lHRnlZelF1VTNSaGRHbGpRbmwwWlhNb2JXVjBhRzlrVTJWc1pXTjBiM0lvSjNSbGMzUW9LWFp2YVdRbktTa3NDaUFnSUNBdkx5QWdJQ0FnSUNCamIyOXNaRzkzYmpvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnYkdGemRFTmhiR3hsWkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJSDBzQ2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlCOUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURGaU1EQXdNV0UzT0RBd01HUmxNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV5TXdvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZCc2RXZHBiaWhyWlhrNklITjBjbWx1WnlrZ2V3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQ0FBQkVDWURCQlVmZkhVSGNHeDFaMmx1Y3dSdFlXbHVNUnRCQUY0eEdSUkVNUmhFZ2dzRWlUaU4zUVR2TWkxdEJBSkZpQWNFeTRIZXVBUzZKNm02QkM5bkNsVUUxTWdmV3dUMGcxd2pCRGdVK1NvRUFIcE1zQVNwdkdIeE5ob0FqZ3NBQ3dBVUFFRUFaZ0NQQUFFQStRRTdBWG9CblFHc0FDUkRNUmtVTVJnVUVFTWpGaVFXVExDd0pFTTJHZ0ZKRlNVU1JEWWFBa2tWSlJKRVN3RWpXMHNCSTFzSVR3SWlXMDhDSWxzSVRCWk1GbEFvVEZDd0pFTTJHZ0ZKRlNVU1JEWWFBa2tWSWhKRU5ob0RTUlVpRWtST0Fsd0FURndJS0V4UXNDUkROaG9CU1JVbEVrUkpJMXRNSWx0TEFSWkxBUlpRU1NOYlR3TVNTVVJNSWx0UEFoSkpSQkJFSkVNMkdnRkpGWUVnRWtSSlZ3QVFTU05iVENKYlN3RVdTd0VXVUU4RFZ4QVFTU0piVENOYlN3RVdTd0VXVUU4RFRGQkpWd0FRU1NOYlNSYXdUQ0piU1Jhd1R3SlhFQkJKSTF0SkZyQk1JbHRKRnJCUEEwOEhFazhEVHdZU0VFeFBBeEpQQWs4REVoQVFSQ1JETmhvQlNSVWlFa1FYU1lFQ0Mwa1dTVkJKSWx0SlN3TVNUd0lqVzBsUEJCSlBBaEJFU3dFV1N3RVdVRWtpVzBzQ0Vrd2pXMHNERWhCRVRFc0NEVVFNUkNSRE5ob0JTUlVsRWtSSklsdExBU05iU2hORVRCWk1GbEJKRlNKTEFROGlTd0pQQWsxTEFrc0JTd05TSTBzRER5TlBCRThDVFU4RFRFOERVbEFTUkNSRE5ob0JTU05aZ1FJSVN3RVZFa1JYQWdBcFRGQkp2a1JNSlNLNkYwUW9URkN3SkVNcXZrUXFKU0s2RjBRb1RGQ3dKRU0yR2dGSkkxbUJBZ2hMQVJVU1JGY0NBQ2xNVUVtOFNJQXhBQUFBQUFBQUFBRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWJBQUduZ0FEZUFBQUFBQUFBQUFFQUFBQUFBQUFBQWI4a1F3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
