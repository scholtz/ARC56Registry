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

namespace Arc56.Generated.algorandfoundation.puya_ts.MutableObjectDemo_45ec41ec
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXV0YWJsZU9iamVjdERlbW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUGx1Z2luSW5mbyI6W3sibmFtZSI6Imxhc3RWYWxpZFJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvb2xkb3duIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RDYWxsZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWRtaW5Qcml2aWxlZ2VzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJtZXRob2RzIiwidHlwZSI6IlBsdWdpbkluZm9NZXRob2RzW10ifV0sIlBvaW50IjpbeyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9XSwiVmVjdG9yIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ2NCJ9XSwiVmVjdG9yUG9pbnQiOlt7Im5hbWUiOiJ2IiwidHlwZSI6IlZlY3RvciJ9LHsibmFtZSI6InAiLCJ0eXBlIjoiUG9pbnQifV0sIlBsdWdpbkluZm9NZXRob2RzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJ5dGVbNF0ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0VmVjdG9yQ3JlYXRpb25BbmRFcXVhbGl0eSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRWZWN0b3JzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11dGF0ZVZlY3RvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW1wbGljaXRDYXN0aW5nQW5kU3ByZWFkaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TmVzdGVkT2JqZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQpLCh1aW50NjQsdWludDY0KSkiLCJzdHJ1Y3QiOiJWZWN0b3JQb2ludCIsIm5hbWUiOiJ2cCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWV0aG9kU2VsZWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFzc2VydE1hdGNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFyYzRFbmNvZGluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQb2ludCIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wsKGJ5dGVbNF0sdWludDY0LHVpbnQ2NClbXSkiLCJzdHJ1Y3QiOiJQbHVnaW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFpbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCwoYnl0ZVs0XSx1aW50NjQsdWludDY0KVtdKSIsInN0cnVjdCI6IlBsdWdpbkluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQbHVnaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTI1MywxMjczXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMzldLCJlcnJvck1lc3NhZ2UiOiJFbmNvZGVkIG9yZGVyIHNob3VsZCBiZSBzd2FwcGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1N10sImVycm9yTWVzc2FnZSI6IkZvciB0aGUgcHVycG9zZSBvZiB0aGlzIHRlc3QsIGEgc2hvdWxkIG5vdCBlcXVhbCBiIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2MSwxMjgxXSwiZXJyb3JNZXNzYWdlIjoiTGFzdCBjYWxsZWQgbm90IHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDQsNzEwLDc2Niw5OTMsMTA2MSwxMTE5LDExMjgsMTEzNl0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTMsNDU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIzLDQ2OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDQsMzEzLDM4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0cy9hcHByb3ZhbHMvbXV0YWJsZS1vYmplY3QuYWxnby50czo6UG9pbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjcsMjc1LDI5NiwzNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdHMvYXBwcm92YWxzL211dGFibGUtb2JqZWN0LmFsZ28udHM6OlZlY3RvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0cy9hcHByb3ZhbHMvbXV0YWJsZS1vYmplY3QuYWxnby50czo6VmVjdG9yUG9pbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzA3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBzaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dPQ0F3SURFMklERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dNSGd4TlRGbU4yTTNOU0F3ZURBeU5EVTRPREEzSURCNFltRXlOMkU1WW1FZ01IZ3pPREUwWmpreVlTQWljR3gxWjJsdWN5SWdNSGhoTnpnd01EQmtaUW9nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREFLQ20xaGFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXhDZ3B0WVdsdVgySnNiMk5yUURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxMWRHRmliR1ZQWW1wbFkzUkVaVzF2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRnS0lDQWdJR0lnYldGcGJsOWhZbWxmY205MWRHbHVaMEF5Q2dwdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxMWRHRmliR1ZQWW1wbFkzUkVaVzF2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UWUtJQ0FnSUdJZ2JXRnBibDlqWVd4c1gwNXZUM0JBTXdvS2JXRnBibDlqWVd4c1gwNXZUM0JBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVFhWMFlXSnNaVTlpYW1WamRFUmxiVzhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0T1RNNE9HUmtaQ0F2THlCdFpYUm9iMlFnSW5SbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNUtDbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldZek1qSmtObVFnTHk4Z2JXVjBhRzlrSUNKaFpHUldaV04wYjNKektDaDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ2twS0hWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ1lubDBaV05mTWlBdkx5QnRaWFJvYjJRZ0ltMTFkR0YwWlZabFkzUnZjaWdvZFdsdWREWTBMSFZwYm5RMk5Da3NkV2x1ZERZMExIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqWWpneFpHVmlPQ0F2THlCdFpYUm9iMlFnSW1sdGNHeHBZMmwwUTJGemRHbHVaMEZ1WkZOd2NtVmhaR2x1Wnlnb2RXbHVkRFkwTEhWcGJuUTJOQ2twZG05cFpDSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z2JXVjBhRzlrSUNKMFpYTjBUbVZ6ZEdWa1QySnFaV04wY3lnb0tIVnBiblEyTkN4MWFXNTBOalFwTENoMWFXNTBOalFzZFdsdWREWTBLU2twZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESm1OamN3WVRVMUlDOHZJRzFsZEdodlpDQWlkR1Z6ZEUxbGRHaHZaRk5sYkdWamRHOXlLQ2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpEUmpPREZtTldJZ0x5OGdiV1YwYUc5a0lDSjBaWE4wUVhOelpYSjBUV0YwWTJnb2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1ORGd6TldNeU15QXZMeUJ0WlhSb2IyUWdJblJsYzNSQmNtTTBSVzVqYjJScGJtY29LSFZwYm5RMk5DeDFhVzUwTmpRcEtYWnZhV1FpQ2lBZ0lDQmllWFJsWXlBMElDOHZJRzFsZEdodlpDQWlaMlYwVUd4MVoybHVLSE4wY21sdVp5a29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDd29ZbmwwWlZzMFhTeDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZEtTSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOMkUwWTJJd0lDOHZJRzFsZEdodlpDQWlaMlYwVFdGcGJpZ3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NLR0o1ZEdWYk5GMHNkV2x1ZERZMExIVnBiblEyTkNsYlhTa2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGhPV0pqTmpGbU1TQXZMeUJ0WlhSb2IyUWdJbk5sZEZCc2RXZHBiaWh6ZEhKcGJtY3BkbTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNVEVLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGxmY205MWRHVkFOQ0J0WVdsdVgyRmtaRlpsWTNSdmNuTmZjbTkxZEdWQU5TQnRZV2x1WDIxMWRHRjBaVlpsWTNSdmNsOXliM1YwWlVBMklHMWhhVzVmYVcxd2JHbGphWFJEWVhOMGFXNW5RVzVrVTNCeVpXRmthVzVuWDNKdmRYUmxRRGNnYldGcGJsOTBaWE4wVG1WemRHVmtUMkpxWldOMGMxOXliM1YwWlVBNElHMWhhVzVmZEdWemRFMWxkR2h2WkZObGJHVmpkRzl5WDNKdmRYUmxRRGtnYldGcGJsOTBaWE4wUVhOelpYSjBUV0YwWTJoZmNtOTFkR1ZBTVRBZ2JXRnBibDkwWlhOMFFYSmpORVZ1WTI5a2FXNW5YM0p2ZFhSbFFERXhJRzFoYVc1ZloyVjBVR3gxWjJsdVgzSnZkWFJsUURFeUlHMWhhVzVmWjJWMFRXRnBibDl5YjNWMFpVQXhNeUJ0WVdsdVgzTmxkRkJzZFdkcGJsOXliM1YwWlVBeE5Bb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVFVLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOVG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUzQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhPUW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmRYUmhZbXhsVDJKcVpXTjBSR1Z0YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR1Z5Y2dvS2JXRnBibDl6WlhSUWJIVm5hVzVmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlFiSFZuYVc0b2EyVjVPaUJ6ZEhKcGJtY3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBVR3gxWjJsdUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOUW9LYldGcGJsOW5aWFJOWVdsdVgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEV6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVFdGcGJpZ3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBUV0ZwYmdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UVUtDbTFoYVc1ZloyVjBVR3gxWjJsdVgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEEzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVUd4MVoybHVLR3RsZVRvZ2MzUnlhVzVuS1RvZ1VHeDFaMmx1U1c1bWJ5QjdDaUFnSUNCallXeHNjM1ZpSUdkbGRGQnNkV2RwYmdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UVUtDbTFoYVc1ZmRHVnpkRUZ5WXpSRmJtTnZaR2x1WjE5eWIzVjBaVUF4TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QjBaWE4wUVhKak5FVnVZMjlrYVc1bktIQTZJRkJ2YVc1MEtTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUkJjbU0wUlc1amIyUnBibWNLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMUNncHRZV2x1WDNSbGMzUkJjM05sY25STllYUmphRjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCMFpYTjBRWE56WlhKMFRXRjBZMmdvZURvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSQmMzTmxjblJOWVhSamFBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVFVLQ20xaGFXNWZkR1Z6ZEUxbGRHaHZaRk5sYkdWamRHOXlYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnY0hWaWJHbGpJSFJsYzNSTlpYUm9iMlJUWld4bFkzUnZjaWdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEUxbGRHaHZaRk5sYkdWamRHOXlDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TlFvS2JXRnBibDkwWlhOMFRtVnpkR1ZrVDJKcVpXTjBjMTl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhCMVlteHBZeUIwWlhOMFRtVnpkR1ZrVDJKcVpXTjBjeWgyY0RvZ1ZtVmpkRzl5VUc5cGJuUXBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRTVsYzNSbFpFOWlhbVZqZEhNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTFDZ3B0WVdsdVgybHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVoxOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSEIxWW14cFl5QnBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtY29kakU2SUZabFkzUnZjaWtnZXdvZ0lDQWdZMkZzYkhOMVlpQnBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtY0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREUxQ2dwdFlXbHVYMjExZEdGMFpWWmxZM1J2Y2w5eWIzVjBaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIQjFZbXhwWXlCdGRYUmhkR1ZXWldOMGIzSW9kakU2SUZabFkzUnZjaXdnYm1WM1dEb2dkV2x1ZERZMExDQnVaWGRaT2lCMWFXNTBOalFwT2lCV1pXTjBiM0lnZXdvZ0lDQWdZMkZzYkhOMVlpQnRkWFJoZEdWV1pXTjBiM0lLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMUNncHRZV2x1WDJGa1pGWmxZM1J2Y25OZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QndkV0pzYVdNZ1lXUmtWbVZqZEc5eWN5aDJNVG9nVm1WamRHOXlMQ0IyTWpvZ1ZtVmpkRzl5S1RvZ1ZtVmpkRzl5SUhzS0lDQWdJR05oYkd4emRXSWdZV1JrVm1WamRHOXljd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRVS0NtMWhhVzVmZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhsZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QndkV0pzYVdNZ2RHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIa29LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1JXWldOMGIzSkRjbVZoZEdsdmJrRnVaRVZ4ZFdGc2FYUjVDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TlFvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE5qb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTNDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RYVjBZV0pzWlU5aWFtVmpkRVJsYlc4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMblJsYzNSV1pXTjBiM0pEY21WaGRHbHZia0Z1WkVWeGRXRnNhWFI1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIazZDaUFnSUNCaUlIUmxjM1JXWldOMGIzSkRjbVZoZEdsdmJrRnVaRVZ4ZFdGc2FYUjVYMkpzYjJOclFEQUtDblJsYzNSV1pXTjBiM0pEY21WaGRHbHZia0Z1WkVWeGRXRnNhWFI1WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUldaV04wYjNKRGNtVmhkR2x2YmtGdVpFVnhkV0ZzYVhSNUtDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGtLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1WVdSa1ZtVmpkRzl5YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRlpsWTNSdmNuTTZDaUFnSUNCaUlHRmtaRlpsWTNSdmNuTmZZbXh2WTJ0QU1Bb0tZV1JrVm1WamRHOXljMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJoWkdSV1pXTjBiM0p6S0hZeE9pQldaV04wYjNJc0lIWXlPaUJXWldOMGIzSXBPaUJXWldOMGIzSWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9sWmxZM1J2Y2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPbFpsWTNSdmNnb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dVlXUmtWbVZqZEc5eWN3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG0xMWRHRjBaVlpsWTNSdmNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTExZEdGMFpWWmxZM1J2Y2pvS0lDQWdJR0lnYlhWMFlYUmxWbVZqZEc5eVgySnNiMk5yUURBS0NtMTFkR0YwWlZabFkzUnZjbDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhCMVlteHBZeUJ0ZFhSaGRHVldaV04wYjNJb2RqRTZJRlpsWTNSdmNpd2dibVYzV0RvZ2RXbHVkRFkwTENCdVpYZFpPaUIxYVc1ME5qUXBPaUJXWldOMGIzSWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9sWmxZM1J2Y2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWJYVjBZWFJsVm1WamRHOXlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWFXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzF3YkdsamFYUkRZWE4wYVc1blFXNWtVM0J5WldGa2FXNW5PZ29nSUNBZ1lpQnBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtZGZZbXh2WTJ0QU1Bb0thVzF3YkdsamFYUkRZWE4wYVc1blFXNWtVM0J5WldGa2FXNW5YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hWaWJHbGpJR2x0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaeWgyTVRvZ1ZtVmpkRzl5S1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82Vm1WamRHOXlDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NXBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtY0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVkR1Z6ZEU1bGMzUmxaRTlpYW1WamRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFRtVnpkR1ZrVDJKcVpXTjBjem9LSUNBZ0lHSWdkR1Z6ZEU1bGMzUmxaRTlpYW1WamRITmZZbXh2WTJ0QU1Bb0tkR1Z6ZEU1bGMzUmxaRTlpYW1WamRITmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEU1bGMzUmxaRTlpYW1WamRITW9kbkE2SUZabFkzUnZjbEJ2YVc1MEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2xabFkzUnZjbEJ2YVc1MENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1MFpYTjBUbVZ6ZEdWa1QySnFaV04wY3dvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1MFpYTjBUV1YwYUc5a1UyVnNaV04wYjNKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVFdWMGFHOWtVMlZzWldOMGIzSTZDaUFnSUNCaUlIUmxjM1JOWlhSb2IyUlRaV3hsWTNSdmNsOWliRzlqYTBBd0NncDBaWE4wVFdWMGFHOWtVMlZzWldOMGIzSmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEUxbGRHaHZaRk5sYkdWamRHOXlLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1ZEdWemRFMWxkR2h2WkZObGJHVmpkRzl5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5SbGMzUkJjM05sY25STllYUmphRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUkJjM05sY25STllYUmphRG9LSUNBZ0lHSWdkR1Z6ZEVGemMyVnlkRTFoZEdOb1gySnNiMk5yUURBS0NuUmxjM1JCYzNObGNuUk5ZWFJqYUY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklIUmxjM1JCYzNObGNuUk5ZWFJqYUNoNE9pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMblJsYzNSQmMzTmxjblJOWVhSamFBb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wUVhKak5FVnVZMjlrYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEVGeVl6UkZibU52WkdsdVp6b0tJQ0FnSUdJZ2RHVnpkRUZ5WXpSRmJtTnZaR2x1WjE5aWJHOWphMEF3Q2dwMFpYTjBRWEpqTkVWdVkyOWthVzVuWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z2RHVnpkRUZ5WXpSRmJtTnZaR2x1Wnlod09pQlFiMmx1ZENrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2xCdmFXNTBDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wUVhKak5FVnVZMjlrYVc1bkNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxtZGxkRkJzZFdkcGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZCc2RXZHBiam9LSUNBZ0lHSWdaMlYwVUd4MVoybHVYMkpzYjJOclFEQUtDbWRsZEZCc2RXZHBibDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFVHeDFaMmx1S0d0bGVUb2djM1J5YVc1bktUb2dVR3gxWjJsdVNXNW1ieUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NW5aWFJRYkhWbmFXNEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1blpYUk5ZV2x1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBUV0ZwYmpvS0lDQWdJR0lnWjJWMFRXRnBibDlpYkc5amEwQXdDZ3BuWlhSTllXbHVYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TVRNS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSTllXbHVLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1WjJWMFRXRnBiZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuTmxkRkJzZFdkcGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZCc2RXZHBiam9LSUNBZ0lHSWdjMlYwVUd4MVoybHVYMkpzYjJOclFEQUtDbk5sZEZCc2RXZHBibDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRJekNpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFVHeDFaMmx1S0d0bGVUb2djM1J5YVc1bktTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1elpYUlFiSFZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIa29LU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIazZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFZtVmpkRzl5UTNKbFlYUnBiMjVCYm1SRmNYVmhiR2wwZVY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGxmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCamIyNXpkQ0IyTVRvZ1ZtVmpkRzl5SUQwZ2V5QjVPaUF4TENCNE9pQXdJSDBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR3h2WnloMk1TNTRLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJzYjJjb2RqRXVlU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWTI5dWMzUWdkakk2SUZabFkzUnZjaUE5SUhzZ2VUb2dNU3dnZURvZ01DQjlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2gyTVN3Z2RqSXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxtRmtaRlpsWTNSdmNuTW9kakU2SUdKNWRHVnpMQ0IyTWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVZV1JrVm1WamRHOXljem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCd2RXSnNhV01nWVdSa1ZtVmpkRzl5Y3loMk1Ub2dWbVZqZEc5eUxDQjJNam9nVm1WamRHOXlLVG9nVm1WamRHOXlJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVZV1JrVm1WamRHOXljMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dVlXUmtWbVZqZEc5eWMxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSGc2SUhZeExuZ2dLeUIyTWk1NExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJQ3NLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCNU9pQjJNUzU1SUNzZ2RqSXVlU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNBckNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3lNaTB5TlFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZURvZ2RqRXVlQ0FySUhZeUxuZ3NDaUFnSUNBdkx5QWdJSGs2SUhZeExua2dLeUIyTWk1NUxBb2dJQ0FnTHk4Z2ZRb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTV0ZFhSaGRHVldaV04wYjNJb2RqRTZJR0o1ZEdWekxDQnVaWGRZT2lCMWFXNTBOalFzSUc1bGQxazZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1dGRYUmhkR1ZXWldOMGIzSTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJRzExZEdGMFpWWmxZM1J2Y2loMk1Ub2dWbVZqZEc5eUxDQnVaWGRZT2lCMWFXNTBOalFzSUc1bGQxazZJSFZwYm5RMk5DazZJRlpsWTNSdmNpQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxtMTFkR0YwWlZabFkzUnZjbDlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWJYVjBZWFJsVm1WamRHOXlYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnZGpFdWVDQTlJRzVsZDFnS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhZeExua2dQU0J1WlhkWkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY21Wd2JHRmpaVE1LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhKbGRIVnliaUIyTVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxtbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVp5aDJNVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1cGJYQnNhV05wZEVOaGMzUnBibWRCYm1SVGNISmxZV1JwYm1jNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdjSFZpYkdsaklHbHRjR3hwWTJsMFEyRnpkR2x1WjBGdVpGTndjbVZoWkdsdVp5aDJNVG9nVm1WamRHOXlLU0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbWx0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWFXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1blgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdZMjl1YzNRZ2RqSWdQU0JqYkc5dVpTaDJNU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUdOdmJuTjBJSFl6SUQwZ2V5QXVMaTUyTWlCOUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCaGMzTmxjblFvZGpFdWVDQTlQVDBnZGpJdWVDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJoYzNObGNuUW9kakV1ZVNBOVBUMGdkakl1ZVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2gyTVN3Z2RqSXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNBOVBRb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlZ5ZENCMFlYSm5aWFFnYVhNZ2JXRjBZMmdnWm05eUlHTnZibVJwZEdsdmJuTUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJoYzNObGNuUW9kak11ZUNBOVBUMGdkakV1ZUNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hZekxua2dQVDA5SUhZeExua3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0hZekxDQjJNU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNBOVBRb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUQwOUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJR052Ym5OMElIc2dlQ3dnZVNCOUlEMGdkak1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QmhjM05sY25Rb2VDQTlQVDBnZGpNdWVDa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWVhOelpYSjBLSGtnUFQwOUlIWXpMbmtwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRTVsYzNSbFpFOWlhbVZqZEhNb2RuQTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1ZEdWemRFNWxjM1JsWkU5aWFtVmpkSE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhSbGMzUk9aWE4wWldSUFltcGxZM1J6S0had09pQldaV04wYjNKUWIybHVkQ2tnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFRtVnpkR1ZrVDJKcVpXTjBjMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRTVsYzNSbFpFOWlhbVZqZEhOZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QmpiMjV6ZENCMk1TQTlJSHNnZURvZ2RuQXVkaTU0TENCNU9pQjJjQzUyTG5rZ2ZRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJqYjI1emRDQndNU0E5SUhzZ2VEb2dkbkF1Y0M1NExDQjVPaUIyY0M1d0xua2dmUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHTnZibk4wSUhad01TQTlJSHNnZGpvZ1kyeHZibVVvZGpFcExDQndPaUJqYkc5dVpTaHdNU2tnZlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnYkc5bktIWndNUzUyTG5ncENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QnNiMmNvZG5BeExuWXVlU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbDBiMklLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUd4dlp5aDJjREV1Y0M1NEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR3h2WnloMmNERXVjQzU1S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LSFp3TVN3Z2RuQXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNBOVBRb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdKaVlLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnUFQwS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRTFsZEdodlpGTmxiR1ZqZEc5eUtDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5SbGMzUk5aWFJvYjJSVFpXeGxZM1J2Y2pvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuUmxjM1JOWlhSb2IyUlRaV3hsWTNSdmNsOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1ZEdWemRFMWxkR2h2WkZObGJHVmpkRzl5WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z2JXVjBhRzlrVTJWc1pXTjBiM0lvVFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1Y0hKdmRHOTBlWEJsTG0xMWRHRjBaVlpsWTNSdmNpa2dQVDA5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWliWFYwWVhSbFZtVmpkRzl5S0NoMWFXNTBOalFzZFdsdWREWTBLU3gxYVc1ME5qUXNkV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QnRaWFJvYjJSVFpXeGxZM1J2Y2lnbmJYVjBZWFJsVm1WamRHOXlLQ2gxYVc1ME5qUXNkV2x1ZERZMEtTeDFhVzUwTmpRc2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBLU2NwTEFvZ0lDQWdZbmwwWldOZk1pQXZMeUJ0WlhSb2IyUWdJbTExZEdGMFpWWmxZM1J2Y2lnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzZFdsdWREWTBMSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzJNaTAyTXdvZ0lDQWdMeThnYldWMGFHOWtVMlZzWldOMGIzSW9UWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVjSEp2ZEc5MGVYQmxMbTExZEdGMFpWWmxZM1J2Y2lrZ1BUMDlDaUFnSUNBdkx5QWdJRzFsZEdodlpGTmxiR1ZqZEc5eUtDZHRkWFJoZEdWV1pXTjBiM0lvS0hWcGJuUTJOQ3gxYVc1ME5qUXBMSFZwYm5RMk5DeDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFwSnlrc0NpQWdJQ0E5UFFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5qRXROalFLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdiV1YwYUc5a1UyVnNaV04wYjNJb1RYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWNISnZkRzkwZVhCbExtMTFkR0YwWlZabFkzUnZjaWtnUFQwOUNpQWdJQ0F2THlBZ0lDQWdiV1YwYUc5a1UyVnNaV04wYjNJb0oyMTFkR0YwWlZabFkzUnZjaWdvZFdsdWREWTBMSFZwYm5RMk5Da3NkV2x1ZERZMExIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ2tuS1N3S0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJRzFsZEdodlpGTmxiR1ZqZEc5eUtFMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuQnliM1J2ZEhsd1pTNW5aWFJRYkhWbmFXNHBJRDA5UFFvZ0lDQWdZbmwwWldNZ05DQXZMeUJ0WlhSb2IyUWdJbWRsZEZCc2RXZHBiaWh6ZEhKcGJtY3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NLR0o1ZEdWYk5GMHNkV2x1ZERZMExIVnBiblEyTkNsYlhTa2lDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnYldWMGFHOWtVMlZzWldOMGIzSW9KMmRsZEZCc2RXZHBiaWh6ZEhKcGJtY3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NLR0o1ZEdWYk5GMHNkV2x1ZERZMExIVnBiblEyTkNsYlhTa25LU3dLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdiV1YwYUc5a0lDSm5aWFJRYkhWbmFXNG9jM1J5YVc1bktTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0xDaGllWFJsV3pSZExIVnBiblEyTkN4MWFXNTBOalFwVzEwcElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOall0TmpjS0lDQWdJQzh2SUcxbGRHaHZaRk5sYkdWamRHOXlLRTExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbkJ5YjNSdmRIbHdaUzVuWlhSUWJIVm5hVzRwSUQwOVBRb2dJQ0FnTHk4Z0lDQnRaWFJvYjJSVFpXeGxZM1J2Y2lnbloyVjBVR3gxWjJsdUtITjBjbWx1Wnlrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN3b1lubDBaVnMwWFN4MWFXNTBOalFzZFdsdWREWTBLVnRkS1NjcExBb2dJQ0FnUFQwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qWTFMVFk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJRzFsZEdodlpGTmxiR1ZqZEc5eUtFMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuQnliM1J2ZEhsd1pTNW5aWFJRYkhWbmFXNHBJRDA5UFFvZ0lDQWdMeThnSUNBZ0lHMWxkR2h2WkZObGJHVmpkRzl5S0NkblpYUlFiSFZuYVc0b2MzUnlhVzVuS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTENoaWVYUmxXelJkTEhWcGJuUTJOQ3gxYVc1ME5qUXBXMTBwSnlrc0NpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJ0WlhSb2IyUlRaV3hsWTNSdmNpaE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NXdjbTkwYjNSNWNHVXVkR1Z6ZEU1bGMzUmxaRTlpYW1WamRITXBJRDA5UFFvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJblJsYzNST1pYTjBaV1JQWW1wbFkzUnpLQ2dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeDFhVzUwTmpRcEtTbDJiMmxrSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklHMWxkR2h2WkZObGJHVmpkRzl5S0NkMFpYTjBUbVZ6ZEdWa1QySnFaV04wY3lnb0tIVnBiblEyTkN4MWFXNTBOalFwTENoMWFXNTBOalFzZFdsdWREWTBLU2twZG05cFpDY3BMQW9nSUNBZ1lubDBaV05mTXlBdkx5QnRaWFJvYjJRZ0luUmxjM1JPWlhOMFpXUlBZbXBsWTNSektDZ29kV2x1ZERZMExIVnBiblEyTkNrc0tIVnBiblEyTkN4MWFXNTBOalFwS1NsMmIybGtJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TnpBdE56RUtJQ0FnSUM4dklHMWxkR2h2WkZObGJHVmpkRzl5S0UxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5CeWIzUnZkSGx3WlM1MFpYTjBUbVZ6ZEdWa1QySnFaV04wY3lrZ1BUMDlDaUFnSUNBdkx5QWdJRzFsZEdodlpGTmxiR1ZqZEc5eUtDZDBaWE4wVG1WemRHVmtUMkpxWldOMGN5Z29LSFZwYm5RMk5DeDFhVzUwTmpRcExDaDFhVzUwTmpRc2RXbHVkRFkwS1NrcGRtOXBaQ2NwTEFvZ0lDQWdQVDBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pZNUxUY3lDaUFnSUNBdkx5QmhjM05sY25Rb0NpQWdJQ0F2THlBZ0lHMWxkR2h2WkZObGJHVmpkRzl5S0UxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5CeWIzUnZkSGx3WlM1MFpYTjBUbVZ6ZEdWa1QySnFaV04wY3lrZ1BUMDlDaUFnSUNBdkx5QWdJQ0FnYldWMGFHOWtVMlZzWldOMGIzSW9KM1JsYzNST1pYTjBaV1JQWW1wbFkzUnpLQ2dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeDFhVzUwTmpRcEtTbDJiMmxrSnlrc0NpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFFYTnpaWEowVFdGMFkyZ29lRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRUZ6YzJWeWRFMWhkR05vT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklIUmxjM1JCYzNObGNuUk5ZWFJqYUNoNE9pQjFhVzUwTmpRcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRUZ6YzJWeWRFMWhkR05vWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wUVhOelpYSjBUV0YwWTJoZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QjVPaUFvWWlBOUlIZ2dLaUF5S1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBcUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzNOeTA0TUFvZ0lDQWdMeThnWTI5dWMzUWdiMkpxT2lCV1pXTjBiM0lnUFNCN0NpQWdJQ0F2THlBZ0lIazZJQ2hpSUQwZ2VDQXFJRElwTEFvZ0lDQWdMeThnSUNCNE9pQmlMQW9nSUNBZ0x5OGdmUW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qZ3hMVGcwQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNodlltb3NJSHNLSUNBZ0lDOHZJQ0FnZVRvZ2VDQXFJRElzQ2lBZ0lDQXZMeUFnSUhnNklIZ2dLaUF5TEFvZ0lDQWdMeThnZlNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklIazZJSGdnS2lBeUxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPamd4TFRnMENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHZZbW9zSUhzS0lDQWdJQzh2SUNBZ2VUb2dlQ0FxSURJc0NpQWdJQ0F2THlBZ0lIZzZJSGdnS2lBeUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUQwOUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUI0T2lCNElDb2dNaXdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FxQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNE1TMDROQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvYjJKcUxDQjdDaUFnSUNBdkx5QWdJSGs2SUhnZ0tpQXlMQW9nSUNBZ0x5OGdJQ0I0T2lCNElDb2dNaXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQTlQUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCamIyNXpkQ0IySUQwZ2V5QjVPaUJ2WW1vdWVTd2dlRG9nYjJKcUxuZ2dmUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29iMkpxTENCN0lIZzZJSFl1ZUN3Z2VUb2dkaTU1SUgwcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQTlQUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pnNENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHZZbW9zSUhzZ2VUb2dleUJuY21WaGRHVnlWR2hoYmpvZ2VDQjlJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qZzVDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2h2WW1vc0lIc2dlRG9nZXlCbmNtVmhkR1Z5VkdoaGJqb2dlQ0I5SUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1ZEdWemRFRnlZelJGYm1OdlpHbHVaeWh3T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuUmxjM1JCY21NMFJXNWpiMlJwYm1jNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR1Z6ZEVGeVl6UkZibU52WkdsdVp5aHdPaUJRYjJsdWRDa2dld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wUVhKak5FVnVZMjlrYVc1blgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFFYSmpORVZ1WTI5a2FXNW5YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnWVhOelpYSjBLSEF1ZUNBaFBUMGdjQzU1TENBblJtOXlJSFJvWlNCd2RYSndiM05sSUc5bUlIUm9hWE1nZEdWemRDd2dZU0J6YUc5MWJHUWdibTkwSUdWeGRXRnNJR0luS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1JtOXlJSFJvWlNCd2RYSndiM05sSUc5bUlIUm9hWE1nZEdWemRDd2dZU0J6YUc5MWJHUWdibTkwSUdWeGRXRnNJR0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCNE9pQndMbmdzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCNU9pQndMbmtzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2prMExUazNDaUFnSUNBdkx5QmpiMjV6ZENCdlltbzZJRlpsWTNSdmNpQTlJSHNLSUNBZ0lDOHZJQ0FnZURvZ2NDNTRMQW9nSUNBZ0x5OGdJQ0I1T2lCd0xua3NDaUFnSUNBdkx5QjlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUdOdmJuTjBJSEJGYm1OdlpHVmtJRDBnWlc1amIyUmxRWEpqTkNod0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjNabGNpQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TURBS0lDQWdJQzh2SUdGemMyVnlkQ2h3Ulc1amIyUmxaQ0E5UFQwZ2IySnFSVzVqYjJSbFpDNXpiR2xqWlNnNEtTNWpiMjVqWVhRb2IySnFSVzVqYjJSbFpDNXpiR2xqWlNnd0xDQTRLU2tzSUNkRmJtTnZaR1ZrSUc5eVpHVnlJSE5vYjNWc1pDQmlaU0J6ZDJGd2NHVmtKeWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lENDlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFVnVZMjlrWldRZ2IzSmtaWElnYzJodmRXeGtJR0psSUhOM1lYQndaV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1blpYUlFiSFZuYVc0b2EyVjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1blpYUlFiSFZuYVc0NkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJRYkhWbmFXNG9hMlY1T2lCemRISnBibWNwT2lCUWJIVm5hVzVKYm1adklIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dVoyVjBVR3gxWjJsdVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTVuWlhSUWJIVm5hVzVmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFd013b2dJQ0FnTHk4Z2NHeDFaMmx1Y3lBOUlFSnZlRTFoY0R4emRISnBibWNzSUZCc2RXZHBia2x1Wm04K0tIc2dhMlY1VUhKbFptbDRPaUFuY0d4MVoybHVjeWNnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5Cc2RXZHBibk1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1UQTRDaUFnSUNBdkx5QmpiMjV6ZENCMllXeDFaU0E5SUdOc2IyNWxLSFJvYVhNdWNHeDFaMmx1Y3loclpYa3BMblpoYkhWbEtRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV3T1FvZ0lDQWdMeThnWVhOelpYSjBLSFpoYkhWbExteGhjM1JEWVd4c1pXUXVZWE5WYVc1ME5qUW9LU0ErSURBc0lDZE1ZWE4wSUdOaGJHeGxaQ0J1YjNRZ2VtVnlieWNwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUV4aGMzUWdZMkZzYkdWa0lHNXZkQ0I2WlhKdkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQjJZV3gxWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxtZGxkRTFoYVc0b0tTQXRQaUJpZVhSbGN6b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG1kbGRFMWhhVzQ2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1blpYUk5ZV2x1WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NW5aWFJOWVdsdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNRFVLSUNBZ0lDOHZJSEJzZFdkcGJpQTlJRUp2ZUR4UWJIVm5hVzVKYm1adlBpaDdJR3RsZVRvZ0oyMWhhVzRuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW0xaGFXNGlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUdOdmJuTjBJSFpoYkhWbElEMGdZMnh2Ym1Vb2RHaHBjeTV3YkhWbmFXNHVkbUZzZFdVcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEUxQ2lBZ0lDQXZMeUJoYzNObGNuUW9kbUZzZFdVdWJHRnpkRU5oYkd4bFpDNWhjMVZwYm5RMk5DZ3BJRDRnTUN3Z0oweGhjM1FnWTJGc2JHVmtJRzV2ZENCNlpYSnZKeWtLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnVEdGemRDQmpZV3hzWldRZ2JtOTBJSHBsY204S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIWmhiSFZsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWMyVjBVR3gxWjJsdUtHdGxlVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1elpYUlFiSFZuYVc0NkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJRYkhWbmFXNG9hMlY1T2lCemRISnBibWNwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1YzJWMFVHeDFaMmx1WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NXpaWFJRYkhWbmFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV5TlFvZ0lDQWdMeThnYkdGemRGWmhiR2xrVW05MWJtUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TWpZS0lDQWdJQzh2SUdOdmIyeGtiM2R1T2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvS1N3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV5T0FvZ0lDQWdMeThnWVdSdGFXNVFjbWwyYVd4bFoyVnpPaUJ1WlhjZ1lYSmpOQzVDYjI5c0tHWmhiSE5sS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QnpaV3hsWTNSdmNqb2dibVYzSUdGeVl6UXVVM1JoZEdsalFubDBaWE1vYldWMGFHOWtVMlZzWldOMGIzSW9KM1JsYzNRb0tYWnZhV1FuS1Nrc0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUcxbGRHaHZaQ0FpZEdWemRDZ3BkbTlwWkNJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYzJsNlpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJqYjI5c1pHOTNiam9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFek13b2dJQ0FnTHk4Z2JHRnpkRU5oYkd4bFpEb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtERXBMQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV5TkMweE16WUtJQ0FnSUM4dklIUm9hWE11Y0d4MVoybHVjeWhyWlhrcExuWmhiSFZsSUQwZ2V3b2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUlNiM1Z1WkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQmpiMjlzWkc5M2Jqb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtDa3NDaUFnSUNBdkx5QWdJR3hoYzNSRFlXeHNaV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCaFpHMXBibEJ5YVhacGJHVm5aWE02SUc1bGR5QmhjbU0wTGtKdmIyd29abUZzYzJVcExBb2dJQ0FnTHk4Z0lDQnRaWFJvYjJSek9pQmJDaUFnSUNBdkx5QWdJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lDQWdjMlZzWldOMGIzSTZJRzVsZHlCaGNtTTBMbE4wWVhScFkwSjVkR1Z6S0cxbGRHaHZaRk5sYkdWamRHOXlLQ2QwWlhOMEtDbDJiMmxrSnlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQWdJR3hoYzNSRFlXeHNaV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQjlMQW9nSUNBZ0x5OGdJQ0JkTEFvZ0lDQWdMeThnZlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QnpaV3hsWTNSdmNqb2dibVYzSUdGeVl6UXVVM1JoZEdsalFubDBaWE1vYldWMGFHOWtVMlZzWldOMGIzSW9KM1JsYzNRb0tYWnZhV1FuS1Nrc0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUcxbGRHaHZaQ0FpZEdWemRDZ3BkbTlwWkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXlOQzB4TXpZS0lDQWdJQzh2SUhSb2FYTXVjR3gxWjJsdWN5aHJaWGtwTG5aaGJIVmxJRDBnZXdvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdSU2IzVnVaRG9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0JoWkcxcGJsQnlhWFpwYkdWblpYTTZJRzVsZHlCaGNtTTBMa0p2YjJ3b1ptRnNjMlVwTEFvZ0lDQWdMeThnSUNCdFpYUm9iMlJ6T2lCYkNpQWdJQ0F2THlBZ0lDQWdld29nSUNBZ0x5OGdJQ0FnSUNBZ2MyVnNaV04wYjNJNklHNWxkeUJoY21NMExsTjBZWFJwWTBKNWRHVnpLRzFsZEdodlpGTmxiR1ZqZEc5eUtDZDBaWE4wS0NsMmIybGtKeWtwTEFvZ0lDQWdMeThnSUNBZ0lDQWdZMjl2YkdSdmQyNDZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCOUxBb2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdmUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vYVc1MElESTNDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJ3YkhWbmFXNXpJRDBnUW05NFRXRndQSE4wY21sdVp5d2dVR3gxWjJsdVNXNW1iejRvZXlCclpYbFFjbVZtYVhnNklDZHdiSFZuYVc1ekp5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWljR3gxWjJsdWN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TWpRdE1UTTJDaUFnSUNBdkx5QjBhR2x6TG5Cc2RXZHBibk1vYTJWNUtTNTJZV3gxWlNBOUlIc0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtVbTkxYm1RNklHNWxkeUJoY21NMExsVnBiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdZMjl2YkdSdmQyNDZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0JzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvS1N3S0lDQWdJQzh2SUNBZ1lXUnRhVzVRY21sMmFXeGxaMlZ6T2lCdVpYY2dZWEpqTkM1Q2IyOXNLR1poYkhObEtTd0tJQ0FnSUM4dklDQWdiV1YwYUc5a2N6b2dXd29nSUNBZ0x5OGdJQ0FnSUhzS0lDQWdJQzh2SUNBZ0lDQWdJSE5sYkdWamRHOXlPaUJ1WlhjZ1lYSmpOQzVUZEdGMGFXTkNlWFJsY3lodFpYUm9iMlJUWld4bFkzUnZjaWduZEdWemRDZ3BkbTlwWkNjcEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUdOdmIyeGtiM2R1T2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0JzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdmU3dLSUNBZ0lDOHZJQ0FnWFN3S0lDQWdJQzh2SUgwS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVNkNpQWdJQ0JpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdDZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQ0FBUUFTWUhBQVFWSDN4MUJBSkZpQWNFdWllcHVnUTRGUGtxQjNCc2RXZHBibk1FcDRBQTNrSUFBRUlBQURFYkl4TkJBTEpDQUFBeEdTTVNSREVZSXhOQkFLQkNBQUEyR2dDQUJJazRqZDJBQk84eUxXMHFnQVRMZ2Q2NEs0QUVMMmNLVllBRTFNZ2ZXNEFFOUlOY0l5Y0VnQVFBZWt5d2dBU3B2R0h4VHd1T0N3QkdBRUFBT2dBMEFDNEFLQUFpQUJ3QUZnQVFBQXBDQUFCQ0FBQkNBQUFBaUFFYVF2L3ppQUVIUXYvdGlBRGhRdi9uaUFETFF2L2hpQUMwUXYvYmlBQ21Rdi9WaUFDUFF2L1BpQUI1UXYvSmlBQkdRdi9EaUFBalF2KzlpQUFWUXYrM1F2KzNNUmtqRWpFWUl4SVFSSWdFWGlWRFFnQUFpQURlSlVOQ0FBQTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRWlBRUxLVThCVUxBbFEwSUFBRFlhQVVrVkpCSkVOaG9DU1JVaUVrUVhOaG9EU1JVaUVrUVhUd0pQQWs4Q2lBRUtLVThCVUxBbFEwSUFBRFlhQVVrVkpCSkVpQUVUSlVOQ0FBQTJHZ0ZKRllFZ0VrU0lBYllsUTBJQUFJZ0NjU1ZEUWdBQU5ob0JTUlVpRWtRWGlBSnlKVU5DQUFBMkdnRkpGU1FTUklnQzN5VkRRZ0FBTmhvQlNTTlpKUXVCQWdoTEFSVVNSRmNDQUlnREt5bFBBVkN3SlVOQ0FBQ0lBelFwVHdGUXNDVkRRZ0FBTmhvQlNTTlpKUXVCQWdoTEFSVVNSRmNDQUlnREtDVkRRZ0FBSXhZb1R3RlFKUlpRU1NNaVdCY1dzRWtpSWxnWEZyQWpGaWhQQVZBbEZsQkxBU01pV0JkT0FVa2pJbGdYVHdJU1RnSlBBU0lpV0JkUEFTSWlXQmNTRUVTSmlnSUJRZ0FBaS80aklsZ1hpLzhqSWxnWENJditJaUpZRjR2L0lpSllGd2hQQVJZb1R3RlFUd0VXVUltS0F3RkNBQUNML2hhTC9TTlBBbDJNL1l2L0ZvdjlJazhDWFVtTS9ZbUtBUUJDQUFDTC8wa2pJbGdYVGdGSklpSllGMDhDRmloUEFWQlBBUlpRVGdHTC95TWlXQmRMQVNNaVdCY1NSSXYvSWlKWUYwc0JJaUpZRnhKRWkvOGpJbGdYU3dFaklsZ1hFazRCaS84aUlsZ1hUd0VpSWxnWEVoQkVTU01pV0JlTC95TWlXQmNTUkVraUlsZ1hpLzhpSWxnWEVrUkpJeUpZRjR2L0l5SllGeEpPQVVraUlsZ1hpLzhpSWxnWEVrOENFRVJKSXlKWUYwNEJTU0lpV0JkUEFrNEJUZ0pMQVNNaVdCY1NSQ0lpV0JjU1JJbUtBUUJDQUFDTC95TWtXQ01pV0JlTC95TWtXQ0lpV0JkUEFSWW9Ud0ZRVHdFV1VJdi9KQ1JZSWlKWUY0di9KQ1JZSXlKWUYwOEJGaWhQQVZCUEFSWlFLRThDVUU4QlVFa2pKRmdqSWxnWEZyQkpJeVJZSWlKWUZ4YXdTU1FrV0NNaVdCY1dzRWtrSkZnaUlsZ1hGckJKSXlSWUl5SllGNHYvSXlSWUl5SllGeEpPQVVrakpGZ2lJbGdYaS84akpGZ2lJbGdYRWs4Q0VFNEJTU1FrV0NJaVdCZUwveVFrV0NNaVdCY1NUZ0VrSkZnaklsZ1hpLzhrSkZnaUlsZ1hFaEFRUklsQ0FBQXFLaEpFSndRbkJCSkVLeXNTUkltS0FRQkNBQUNMLzRFQ0Mwa1dLRThCVUU4QkZsQkpJaUpZRjR2L2dRSUxFazRCU1NNaVdCZUwvNEVDQ3hKUEFoQkVTU0lpV0JkT0FVa2pJbGdYVHdJV0tFOEJVRThCRmxCTEFTTWlXQmRPQVVraUlsZ1hUd0lTVGdKTEFTSWlXQmRQQVNNaVdCY1NUd0lRUkVraUlsZ1hpLzhOUkNNaVdCZUwvdzFFaVlvQkFFSUFBSXYvSWlKWUY0di9JeUpZRnhORWkvOGlJbGdYaS84aklsZ1hUd0VXS0U4QlVFOEJGbENMLzA0QlNSVWlTd0VQSWtzQ1R3Sk5Td0pQQVU4Q1VrNEJTUlVqU3dFUEkwc0NUd0pOVGdFaVN3RVBJazhDVHdKTlR3SlBBazhDVWxBU1JJbUtBUUZDQUFBbkJZdi9VTDVFU1NRaVdCY2pEVVNKUWdBQWdBUnRZV2x1dmtSSkpDSllGeU1OUkltS0FRQkNBQUFsRmlNV0l4YUFBUUFqSTFRbkJoV0JCQkpFSlJZbEZpZ25CbEJQQWxCUEFWQWxGbGNHQWs4QlVDaFBCVkJQQkZCUEExQlBBbENCR3haWEJnSlFUd0ZRSndXTC8xQkp2RWhQQWIrSlFnQUFpUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
