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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXV0YWJsZU9iamVjdERlbW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUGx1Z2luSW5mbyI6W3sibmFtZSI6Imxhc3RWYWxpZFJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvb2xkb3duIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RDYWxsZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWRtaW5Qcml2aWxlZ2VzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJtZXRob2RzIiwidHlwZSI6IlBsdWdpbkluZm9NZXRob2RzW10ifV0sIlBvaW50IjpbeyJuYW1lIjoieSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9XSwiVmVjdG9yIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ2NCJ9XSwiVmVjdG9yUG9pbnQiOlt7Im5hbWUiOiJ2IiwidHlwZSI6IlZlY3RvciJ9LHsibmFtZSI6InAiLCJ0eXBlIjoiUG9pbnQifV0sIlBsdWdpbkluZm9NZXRob2RzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJ5dGVbNF0ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0VmVjdG9yQ3JlYXRpb25BbmRFcXVhbGl0eSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRWZWN0b3JzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwibmFtZSI6InYyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11dGF0ZVZlY3RvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWZWN0b3IiLCJuYW1lIjoidjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVmVjdG9yIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW1wbGljaXRDYXN0aW5nQW5kU3ByZWFkaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJ2MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TmVzdGVkT2JqZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQpLCh1aW50NjQsdWludDY0KSkiLCJzdHJ1Y3QiOiJWZWN0b3JQb2ludCIsIm5hbWUiOiJ2cCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWV0aG9kU2VsZWN0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFzc2VydE1hdGNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFyYzRFbmNvZGluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQb2ludCIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFBsdWdpbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wsKGJ5dGVbNF0sdWludDY0LHVpbnQ2NClbXSkiLCJzdHJ1Y3QiOiJQbHVnaW5JbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TWFpbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCwoYnl0ZVs0XSx1aW50NjQsdWludDY0KVtdKSIsInN0cnVjdCI6IlBsdWdpbkluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRQbHVnaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTI3MSwxMjkxXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNTddLCJlcnJvck1lc3NhZ2UiOiJFbmNvZGVkIG9yZGVyIHNob3VsZCBiZSBzd2FwcGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3NV0sImVycm9yTWVzc2FnZSI6IkZvciB0aGUgcHVycG9zZSBvZiB0aGlzIHRlc3QsIGEgc2hvdWxkIG5vdCBlcXVhbCBiIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI3OSwxMjk5XSwiZXJyb3JNZXNzYWdlIjoiTGFzdCBjYWxsZWQgbm90IHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjIsNzI4LDc4NCwxMDExLDEwNzksMTEzNywxMTQ2LDExNTRdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxLDQ3Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0MSw0ODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIyLDMzMSw0MDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdHMvYXBwcm92YWxzL211dGFibGUtb2JqZWN0LmFsZ28udHM6OlBvaW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg1LDI5MywzMTQsMzU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RzL2FwcHJvdmFscy9tdXRhYmxlLW9iamVjdC5hbGdvLnRzOjpWZWN0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdHMvYXBwcm92YWxzL211dGFibGUtb2JqZWN0LmFsZ28udHM6OlZlY3RvclBvaW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc2l6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBd0lERTJJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGdnTUhneE5URm1OMk0zTlNBd2VEQXlORFU0T0RBM0lEQjRZbUV5TjJFNVltRWdNSGd6T0RFMFpqa3lZU0F3ZURBd01EQXdNREF3TURBd01EQXdNREVnSW5Cc2RXZHBibk1pSURCNFlUYzRNREF3WkdVZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhPQW9nSUNBZ1lpQnRZV2x1WDJGaWFWOXliM1YwYVc1blFESUtDbTFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TmdvZ0lDQWdZaUJ0WVdsdVgyTmhiR3hmVG05UGNFQXpDZ3B0WVdsdVgyTmhiR3hmVG05UGNFQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk5kWFJoWW14bFQySnFaV04wUkdWdGJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZzVNemc0WkdSa0lDOHZJRzFsZEdodlpDQWlkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGtvS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxaak15TW1RMlpDQXZMeUJ0WlhSb2IyUWdJbUZrWkZabFkzUnZjbk1vS0hWcGJuUTJOQ3gxYVc1ME5qUXBMQ2gxYVc1ME5qUXNkV2x1ZERZMEtTa29kV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUcxbGRHaHZaQ0FpYlhWMFlYUmxWbVZqZEc5eUtDaDFhVzUwTmpRc2RXbHVkRFkwS1N4MWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTmlPREZrWldJNElDOHZJRzFsZEdodlpDQWlhVzF3YkdsamFYUkRZWE4wYVc1blFXNWtVM0J5WldGa2FXNW5LQ2gxYVc1ME5qUXNkV2x1ZERZMEtTbDJiMmxrSWdvZ0lDQWdZbmwwWldOZk15QXZMeUJ0WlhSb2IyUWdJblJsYzNST1pYTjBaV1JQWW1wbFkzUnpLQ2dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeDFhVzUwTmpRcEtTbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TW1ZMk56QmhOVFVnTHk4Z2JXVjBhRzlrSUNKMFpYTjBUV1YwYUc5a1UyVnNaV04wYjNJb0tYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTkdNNE1XWTFZaUF2THlCdFpYUm9iMlFnSW5SbGMzUkJjM05sY25STllYUmphQ2gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdZME9ETTFZekl6SUM4dklHMWxkR2h2WkNBaWRHVnpkRUZ5WXpSRmJtTnZaR2x1Wnlnb2RXbHVkRFkwTEhWcGJuUTJOQ2twZG05cFpDSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z2JXVjBhRzlrSUNKblpYUlFiSFZuYVc0b2MzUnlhVzVuS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTENoaWVYUmxXelJkTEhWcGJuUTJOQ3gxYVc1ME5qUXBXMTBwSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBM1lUUmpZakFnTHk4Z2JXVjBhRzlrSUNKblpYUk5ZV2x1S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN3b1lubDBaVnMwWFN4MWFXNTBOalFzZFdsdWREWTBLVnRkS1NJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFNVltTTJNV1l4SUM4dklHMWxkR2h2WkNBaWMyVjBVR3gxWjJsdUtITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2RXNWpiM1psY2lBeE1Rb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MFpYTjBWbVZqZEc5eVEzSmxZWFJwYjI1QmJtUkZjWFZoYkdsMGVWOXliM1YwWlVBMElHMWhhVzVmWVdSa1ZtVmpkRzl5YzE5eWIzVjBaVUExSUcxaGFXNWZiWFYwWVhSbFZtVmpkRzl5WDNKdmRYUmxRRFlnYldGcGJsOXBiWEJzYVdOcGRFTmhjM1JwYm1kQmJtUlRjSEpsWVdScGJtZGZjbTkxZEdWQU55QnRZV2x1WDNSbGMzUk9aWE4wWldSUFltcGxZM1J6WDNKdmRYUmxRRGdnYldGcGJsOTBaWE4wVFdWMGFHOWtVMlZzWldOMGIzSmZjbTkxZEdWQU9TQnRZV2x1WDNSbGMzUkJjM05sY25STllYUmphRjl5YjNWMFpVQXhNQ0J0WVdsdVgzUmxjM1JCY21NMFJXNWpiMlJwYm1kZmNtOTFkR1ZBTVRFZ2JXRnBibDluWlhSUWJIVm5hVzVmY205MWRHVkFNVElnYldGcGJsOW5aWFJOWVdsdVgzSnZkWFJsUURFeklHMWhhVzVmYzJWMFVHeDFaMmx1WDNKdmRYUmxRREUwQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE5Rb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMU9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFNUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTExZEdGaWJHVlBZbXBsWTNSRVpXMXZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1pYSnlDZ3B0WVdsdVgzTmxkRkJzZFdkcGJsOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV5TXdvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEZCc2RXZHBiaWhyWlhrNklITjBjbWx1WnlrZ2V3b2dJQ0FnWTJGc2JITjFZaUJ6WlhSUWJIVm5hVzRLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFMUNncHRZV2x1WDJkbGRFMWhhVzVmY205MWRHVkFNVE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklIQjFZbXhwWXlCblpYUk5ZV2x1S0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUJuWlhSTllXbHVDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TlFvS2JXRnBibDluWlhSUWJIVm5hVzVmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklIQjFZbXhwWXlCblpYUlFiSFZuYVc0b2EyVjVPaUJ6ZEhKcGJtY3BPaUJRYkhWbmFXNUpibVp2SUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVUd4MVoybHVDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TlFvS2JXRnBibDkwWlhOMFFYSmpORVZ1WTI5a2FXNW5YM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUhSbGMzUkJjbU0wUlc1amIyUnBibWNvY0RvZ1VHOXBiblFwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEVGeVl6UkZibU52WkdsdVp3b2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVFVLQ20xaGFXNWZkR1Z6ZEVGemMyVnlkRTFoZEdOb1gzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSFJsYzNSQmMzTmxjblJOWVhSamFDaDRPaUIxYVc1ME5qUXBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRUZ6YzJWeWRFMWhkR05vQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE5Rb0tiV0ZwYmw5MFpYTjBUV1YwYUc5a1UyVnNaV04wYjNKZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qWXdDaUFnSUNBdkx5QndkV0pzYVdNZ2RHVnpkRTFsZEdodlpGTmxiR1ZqZEc5eUtDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBUV1YwYUc5a1UyVnNaV04wYjNJS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTFDZ3B0WVdsdVgzUmxjM1JPWlhOMFpXUlBZbXBsWTNSelgzSnZkWFJsUURnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdjSFZpYkdsaklIUmxjM1JPWlhOMFpXUlBZbXBsWTNSektIWndPaUJXWldOMGIzSlFiMmx1ZENrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMFRtVnpkR1ZrVDJKcVpXTjBjd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRVS0NtMWhhVzVmYVcxd2JHbGphWFJEWVhOMGFXNW5RVzVrVTNCeVpXRmthVzVuWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdsdGNHeHBZMmwwUTJGemRHbHVaMEZ1WkZOd2NtVmhaR2x1WnloMk1Ub2dWbVZqZEc5eUtTQjdDaUFnSUNCallXeHNjM1ZpSUdsdGNHeHBZMmwwUTJGemRHbHVaMEZ1WkZOd2NtVmhaR2x1WndvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UVUtDbTFoYVc1ZmJYVjBZWFJsVm1WamRHOXlYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJRzExZEdGMFpWWmxZM1J2Y2loMk1Ub2dWbVZqZEc5eUxDQnVaWGRZT2lCMWFXNTBOalFzSUc1bGQxazZJSFZwYm5RMk5DazZJRlpsWTNSdmNpQjdDaUFnSUNCallXeHNjM1ZpSUcxMWRHRjBaVlpsWTNSdmNnb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVFVLQ20xaGFXNWZZV1JrVm1WamRHOXljMTl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJoWkdSV1pXTjBiM0p6S0hZeE9pQldaV04wYjNJc0lIWXlPaUJXWldOMGIzSXBPaUJXWldOMGIzSWdld29nSUNBZ1kyRnNiSE4xWWlCaFpHUldaV04wYjNKekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOUW9LYldGcGJsOTBaWE4wVm1WamRHOXlRM0psWVhScGIyNUJibVJGY1hWaGJHbDBlVjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhCMVlteHBZeUIwWlhOMFZtVmpkRzl5UTNKbFlYUnBiMjVCYm1SRmNYVmhiR2wwZVNncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhrS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERTFDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUyT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREU0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJOZFhSaFlteGxUMkpxWldOMFJHVnRieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZMkZzYkhOMVlpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFZtVmpkRzl5UTNKbFlYUnBiMjVCYm1SRmNYVmhiR2wwZVRvS0lDQWdJR0lnZEdWemRGWmxZM1J2Y2tOeVpXRjBhVzl1UVc1a1JYRjFZV3hwZEhsZllteHZZMnRBTUFvS2RHVnpkRlpsWTNSdmNrTnlaV0YwYVc5dVFXNWtSWEYxWVd4cGRIbGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEZabFkzUnZja055WldGMGFXOXVRVzVrUlhGMVlXeHBkSGtvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1MFpYTjBWbVZqZEc5eVEzSmxZWFJwYjI1QmJtUkZjWFZoYkdsMGVRb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NWhaR1JXWldOMGIzSnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSa1ZtVmpkRzl5Y3pvS0lDQWdJR0lnWVdSa1ZtVmpkRzl5YzE5aWJHOWphMEF3Q2dwaFpHUldaV04wYjNKelgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdjSFZpYkdsaklHRmtaRlpsWTNSdmNuTW9kakU2SUZabFkzUnZjaXdnZGpJNklGWmxZM1J2Y2lrNklGWmxZM1J2Y2lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82Vm1WamRHOXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlZtVmpkRzl5Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTVoWkdSV1pXTjBiM0p6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHViWFYwWVhSbFZtVmpkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JYVjBZWFJsVm1WamRHOXlPZ29nSUNBZ1lpQnRkWFJoZEdWV1pXTjBiM0pmWW14dlkydEFNQW9LYlhWMFlYUmxWbVZqZEc5eVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdjSFZpYkdsaklHMTFkR0YwWlZabFkzUnZjaWgyTVRvZ1ZtVmpkRzl5TENCdVpYZFlPaUIxYVc1ME5qUXNJRzVsZDFrNklIVnBiblEyTkNrNklGWmxZM1J2Y2lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82Vm1WamRHOXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTV0ZFhSaGRHVldaV04wYjNJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTVwYlhCc2FXTnBkRU5oYzNScGJtZEJibVJUY0hKbFlXUnBibWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJYQnNhV05wZEVOaGMzUnBibWRCYm1SVGNISmxZV1JwYm1jNkNpQWdJQ0JpSUdsdGNHeHBZMmwwUTJGemRHbHVaMEZ1WkZOd2NtVmhaR2x1WjE5aWJHOWphMEF3Q2dwcGJYQnNhV05wZEVOaGMzUnBibWRCYm1SVGNISmxZV1JwYm1kZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndkV0pzYVdNZ2FXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1bktIWXhPaUJXWldOMGIzSXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcFdaV04wYjNJS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG1sdGNHeHBZMmwwUTJGemRHbHVaMEZ1WkZOd2NtVmhaR2x1WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1MFpYTjBUbVZ6ZEdWa1QySnFaV04wYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JPWlhOMFpXUlBZbXBsWTNSek9nb2dJQ0FnWWlCMFpYTjBUbVZ6ZEdWa1QySnFaV04wYzE5aWJHOWphMEF3Q2dwMFpYTjBUbVZ6ZEdWa1QySnFaV04wYzE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklIQjFZbXhwWXlCMFpYTjBUbVZ6ZEdWa1QySnFaV04wY3loMmNEb2dWbVZqZEc5eVVHOXBiblFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZWbVZqZEc5eVVHOXBiblFLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMblJsYzNST1pYTjBaV1JQWW1wbFkzUnpDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMblJsYzNSTlpYUm9iMlJUWld4bFkzUnZjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUk5aWFJvYjJSVFpXeGxZM1J2Y2pvS0lDQWdJR0lnZEdWemRFMWxkR2h2WkZObGJHVmpkRzl5WDJKc2IyTnJRREFLQ25SbGMzUk5aWFJvYjJSVFpXeGxZM1J2Y2w5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIQjFZbXhwWXlCMFpYTjBUV1YwYUc5a1UyVnNaV04wYjNJb0tTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wVFdWMGFHOWtVMlZzWldOMGIzSUtJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVkR1Z6ZEVGemMyVnlkRTFoZEdOb1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEVGemMyVnlkRTFoZEdOb09nb2dJQ0FnWWlCMFpYTjBRWE56WlhKMFRXRjBZMmhmWW14dlkydEFNQW9LZEdWemRFRnpjMlZ5ZEUxaGRHTm9YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnZEdWemRFRnpjMlZ5ZEUxaGRHTm9LSGc2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWRHVnpkRUZ6YzJWeWRFMWhkR05vQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5SbGMzUkJjbU0wUlc1amIyUnBibWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBRWEpqTkVWdVkyOWthVzVuT2dvZ0lDQWdZaUIwWlhOMFFYSmpORVZ1WTI5a2FXNW5YMkpzYjJOclFEQUtDblJsYzNSQmNtTTBSVzVqYjJScGJtZGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUIwWlhOMFFYSmpORVZ1WTI5a2FXNW5LSEE2SUZCdmFXNTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZVRzlwYm5RS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5SbGMzUkJjbU0wUlc1amIyUnBibWNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1WjJWMFVHeDFaMmx1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVR3gxWjJsdU9nb2dJQ0FnWWlCblpYUlFiSFZuYVc1ZllteHZZMnRBTUFvS1oyVjBVR3gxWjJsdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJRYkhWbmFXNG9hMlY1T2lCemRISnBibWNwT2lCUWJIVm5hVzVKYm1adklIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG1kbGRGQnNkV2RwYmdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbWRsZEUxaGFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSTllXbHVPZ29nSUNBZ1lpQm5aWFJOWVdsdVgySnNiMk5yUURBS0NtZGxkRTFoYVc1ZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXhNd29nSUNBZ0x5OGdjSFZpYkdsaklHZGxkRTFoYVc0b0tTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NW5aWFJOWVdsdUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1YzJWMFVHeDFaMmx1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBVR3gxWjJsdU9nb2dJQ0FnWWlCelpYUlFiSFZuYVc1ZllteHZZMnRBTUFvS2MyVjBVR3gxWjJsdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJRYkhWbmFXNG9hMlY1T2lCemRISnBibWNwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbk5sZEZCc2RXZHBiZ29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFZtVmpkRzl5UTNKbFlYUnBiMjVCYm1SRmNYVmhiR2wwZVNncElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFZtVmpkRzl5UTNKbFlYUnBiMjVCYm1SRmNYVmhiR2wwZVRvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuUmxjM1JXWldOMGIzSkRjbVZoZEdsdmJrRnVaRVZ4ZFdGc2FYUjVYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1MFpYTjBWbVZqZEc5eVEzSmxZWFJwYjI1QmJtUkZjWFZoYkdsMGVWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR052Ym5OMElIWXhPaUJXWldOMGIzSWdQU0I3SUhrNklERXNJSGc2SURBZ2ZRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2JHOW5LSFl4TG5ncENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHeHZaeWgyTVM1NUtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmpiMjV6ZENCMk1qb2dWbVZqZEc5eUlEMGdleUI1T2lBeExDQjRPaUF3SUgwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tIWXhMQ0IyTWlrS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1WVdSa1ZtVmpkRzl5Y3loMk1Ub2dZbmwwWlhNc0lIWXlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1aFpHUldaV04wYjNKek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJSEIxWW14cFl5QmhaR1JXWldOMGIzSnpLSFl4T2lCV1pXTjBiM0lzSUhZeU9pQldaV04wYjNJcE9pQldaV04wYjNJZ2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pwTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1aFpHUldaV04wYjNKelgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTVoWkdSV1pXTjBiM0p6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2VEb2dkakV1ZUNBcklIWXlMbmdzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSGs2SUhZeExua2dLeUIyTWk1NUxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJQ3NLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pJeUxUSTFDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQjRPaUIyTVM1NElDc2dkakl1ZUN3S0lDQWdJQzh2SUNBZ2VUb2dkakV1ZVNBcklIWXlMbmtzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxtMTFkR0YwWlZabFkzUnZjaWgyTVRvZ1lubDBaWE1zSUc1bGQxZzZJSFZwYm5RMk5Dd2dibVYzV1RvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbTExZEdGMFpWWmxZM1J2Y2pvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QndkV0pzYVdNZ2JYVjBZWFJsVm1WamRHOXlLSFl4T2lCV1pXTjBiM0lzSUc1bGQxZzZJSFZwYm5RMk5Dd2dibVYzV1RvZ2RXbHVkRFkwS1RvZ1ZtVmpkRzl5SUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1YlhWMFlYUmxWbVZqZEc5eVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTV0ZFhSaGRHVldaV04wYjNKZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QjJNUzU0SUQwZ2JtVjNXQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JtY21GdFpWOWlkWEo1SUMwekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdkakV1ZVNBOUlHNWxkMWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SUMwekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIWXhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1YVcxd2JHbGphWFJEWVhOMGFXNW5RVzVrVTNCeVpXRmthVzVuS0hZeE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbWx0Y0d4cFkybDBRMkZ6ZEdsdVowRnVaRk53Y21WaFpHbHVaem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCd2RXSnNhV01nYVcxd2JHbGphWFJEWVhOMGFXNW5RVzVrVTNCeVpXRmthVzVuS0hZeE9pQldaV04wYjNJcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvNlRYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWFXMXdiR2xqYVhSRFlYTjBhVzVuUVc1a1UzQnlaV0ZrYVc1blgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTVwYlhCc2FXTnBkRU5oYzNScGJtZEJibVJUY0hKbFlXUnBibWRmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCamIyNXpkQ0IyTWlBOUlHTnNiMjVsS0hZeEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdZMjl1YzNRZ2RqTWdQU0I3SUM0dUxuWXlJSDBLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDJNUzU0SUQwOVBTQjJNaTU0S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoMk1TNTVJRDA5UFNCMk1pNTVLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tIWXhMQ0IyTWlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJRDA5Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMk15NTRJRDA5UFNCMk1TNTRLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJoYzNObGNuUW9kak11ZVNBOVBUMGdkakV1ZVNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29kak1zSUhZeEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJRDA5Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdQVDBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCNExDQjVJSDBnUFNCMk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUdGemMyVnlkQ2g0SUQwOVBTQjJNeTU0S1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmhjM05sY25Rb2VTQTlQVDBnZGpNdWVTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFRtVnpkR1ZrVDJKcVpXTjBjeWgyY0RvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wVG1WemRHVmtUMkpxWldOMGN6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEU1bGMzUmxaRTlpYW1WamRITW9kbkE2SUZabFkzUnZjbEJ2YVc1MEtTQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuUmxjM1JPWlhOMFpXUlBZbXBsWTNSelgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFRtVnpkR1ZrVDJKcVpXTjBjMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUdOdmJuTjBJSFl4SUQwZ2V5QjRPaUIyY0M1MkxuZ3NJSGs2SUhad0xuWXVlU0I5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHTnZibk4wSUhBeElEMGdleUI0T2lCMmNDNXdMbmdzSUhrNklIWndMbkF1ZVNCOUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWTI5dWMzUWdkbkF4SUQwZ2V5QjJPaUJqYkc5dVpTaDJNU2tzSUhBNklHTnNiMjVsS0hBeEtTQjlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QnNiMmNvZG5BeExuWXVlQ2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbDBiMklLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUd4dlp5aDJjREV1ZGk1NUtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdiRzluS0had01TNXdMbmdwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2JHOW5LSFp3TVM1d0xua3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2RuQXhMQ0IyY0NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTWlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJRDA5Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0E5UFFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBbUpnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeE5nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh5SUM4dklERTJDaUFnSUNCcGJuUmpYeklnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQTlQUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlZ5ZENCMFlYSm5aWFFnYVhNZ2JXRjBZMmdnWm05eUlHTnZibVJwZEdsdmJuTUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFRXVjBhRzlrVTJWc1pXTjBiM0lvS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVkR1Z6ZEUxbGRHaHZaRk5sYkdWamRHOXlPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1ZEdWemRFMWxkR2h2WkZObGJHVmpkRzl5WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wVFdWMGFHOWtVMlZzWldOMGIzSmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJ0WlhSb2IyUlRaV3hsWTNSdmNpaE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NXdjbTkwYjNSNWNHVXViWFYwWVhSbFZtVmpkRzl5S1NBOVBUMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z2JXVjBhRzlrSUNKdGRYUmhkR1ZXWldOMGIzSW9LSFZwYm5RMk5DeDFhVzUwTmpRcExIVnBiblEyTkN4MWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUcxbGRHaHZaRk5sYkdWamRHOXlLQ2R0ZFhSaGRHVldaV04wYjNJb0tIVnBiblEyTkN4MWFXNTBOalFwTEhWcGJuUTJOQ3gxYVc1ME5qUXBLSFZwYm5RMk5DeDFhVzUwTmpRcEp5a3NDaUFnSUNCaWVYUmxZMTh5SUM4dklHMWxkR2h2WkNBaWJYVjBZWFJsVm1WamRHOXlLQ2gxYVc1ME5qUXNkV2x1ZERZMEtTeDFhVzUwTmpRc2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pZeUxUWXpDaUFnSUNBdkx5QnRaWFJvYjJSVFpXeGxZM1J2Y2loTmRYUmhZbXhsVDJKcVpXTjBSR1Z0Ynk1d2NtOTBiM1I1Y0dVdWJYVjBZWFJsVm1WamRHOXlLU0E5UFQwS0lDQWdJQzh2SUNBZ2JXVjBhRzlrVTJWc1pXTjBiM0lvSjIxMWRHRjBaVlpsWTNSdmNpZ29kV2x1ZERZMExIVnBiblEyTkNrc2RXbHVkRFkwTEhWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da25LU3dLSUNBZ0lEMDlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8yTVMwMk5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCdFpYUm9iMlJUWld4bFkzUnZjaWhOZFhSaFlteGxUMkpxWldOMFJHVnRieTV3Y205MGIzUjVjR1V1YlhWMFlYUmxWbVZqZEc5eUtTQTlQVDBLSUNBZ0lDOHZJQ0FnSUNCdFpYUm9iMlJUWld4bFkzUnZjaWduYlhWMFlYUmxWbVZqZEc5eUtDaDFhVzUwTmpRc2RXbHVkRFkwS1N4MWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMEtTY3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2JXVjBhRzlrVTJWc1pXTjBiM0lvVFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1Y0hKdmRHOTBlWEJsTG1kbGRGQnNkV2RwYmlrZ1BUMDlDaUFnSUNCaWVYUmxZeUEwSUM4dklHMWxkR2h2WkNBaVoyVjBVR3gxWjJsdUtITjBjbWx1Wnlrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN3b1lubDBaVnMwWFN4MWFXNTBOalFzZFdsdWREWTBLVnRkS1NJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QnRaWFJvYjJSVFpXeGxZM1J2Y2lnbloyVjBVR3gxWjJsdUtITjBjbWx1Wnlrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN3b1lubDBaVnMwWFN4MWFXNTBOalFzZFdsdWREWTBLVnRkS1NjcExBb2dJQ0FnWW5sMFpXTWdOQ0F2THlCdFpYUm9iMlFnSW1kbGRGQnNkV2RwYmloemRISnBibWNwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndzS0dKNWRHVmJORjBzZFdsdWREWTBMSFZwYm5RMk5DbGJYU2tpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pvMk5pMDJOd29nSUNBZ0x5OGdiV1YwYUc5a1UyVnNaV04wYjNJb1RYVjBZV0pzWlU5aWFtVmpkRVJsYlc4dWNISnZkRzkwZVhCbExtZGxkRkJzZFdkcGJpa2dQVDA5Q2lBZ0lDQXZMeUFnSUcxbGRHaHZaRk5sYkdWamRHOXlLQ2RuWlhSUWJIVm5hVzRvYzNSeWFXNW5LU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNMQ2hpZVhSbFd6UmRMSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBKeWtzQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TmpVdE5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ2JXVjBhRzlrVTJWc1pXTjBiM0lvVFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1Y0hKdmRHOTBlWEJsTG1kbGRGQnNkV2RwYmlrZ1BUMDlDaUFnSUNBdkx5QWdJQ0FnYldWMGFHOWtVMlZzWldOMGIzSW9KMmRsZEZCc2RXZHBiaWh6ZEhKcGJtY3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NLR0o1ZEdWYk5GMHNkV2x1ZERZMExIVnBiblEyTkNsYlhTa25LU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHMWxkR2h2WkZObGJHVmpkRzl5S0UxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5CeWIzUnZkSGx3WlM1MFpYTjBUbVZ6ZEdWa1QySnFaV04wY3lrZ1BUMDlDaUFnSUNCaWVYUmxZMTh6SUM4dklHMWxkR2h2WkNBaWRHVnpkRTVsYzNSbFpFOWlhbVZqZEhNb0tDaDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ2twS1hadmFXUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnYldWMGFHOWtVMlZzWldOMGIzSW9KM1JsYzNST1pYTjBaV1JQWW1wbFkzUnpLQ2dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeDFhVzUwTmpRcEtTbDJiMmxrSnlrc0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUcxbGRHaHZaQ0FpZEdWemRFNWxjM1JsWkU5aWFtVmpkSE1vS0NoMWFXNTBOalFzZFdsdWREWTBLU3dvZFdsdWREWTBMSFZwYm5RMk5Da3BLWFp2YVdRaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzNNQzAzTVFvZ0lDQWdMeThnYldWMGFHOWtVMlZzWldOMGIzSW9UWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVjSEp2ZEc5MGVYQmxMblJsYzNST1pYTjBaV1JQWW1wbFkzUnpLU0E5UFQwS0lDQWdJQzh2SUNBZ2JXVjBhRzlrVTJWc1pXTjBiM0lvSjNSbGMzUk9aWE4wWldSUFltcGxZM1J6S0Nnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzS0hWcGJuUTJOQ3gxYVc1ME5qUXBLU2wyYjJsa0p5a3NDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZOamt0TnpJS0lDQWdJQzh2SUdGemMyVnlkQ2dLSUNBZ0lDOHZJQ0FnYldWMGFHOWtVMlZzWldOMGIzSW9UWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVjSEp2ZEc5MGVYQmxMblJsYzNST1pYTjBaV1JQWW1wbFkzUnpLU0E5UFQwS0lDQWdJQzh2SUNBZ0lDQnRaWFJvYjJSVFpXeGxZM1J2Y2lnbmRHVnpkRTVsYzNSbFpFOWlhbVZqZEhNb0tDaDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ2twS1hadmFXUW5LU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuUmxjM1JCYzNObGNuUk5ZWFJqYUNoNE9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFFYTnpaWEowVFdGMFkyZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnZEdWemRFRnpjMlZ5ZEUxaGRHTm9LSGc2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTUwWlhOMFFYTnpaWEowVFdGMFkyaGZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5SbGMzUkJjM05sY25STllYUmphRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhrNklDaGlJRDBnZUNBcUlESXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ29LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pjM0xUZ3dDaUFnSUNBdkx5QmpiMjV6ZENCdlltbzZJRlpsWTNSdmNpQTlJSHNLSUNBZ0lDOHZJQ0FnZVRvZ0tHSWdQU0I0SUNvZ01pa3NDaUFnSUNBdkx5QWdJSGc2SUdJc0NpQWdJQ0F2THlCOUNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T0RFdE9EUUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LRzlpYWl3Z2V3b2dJQ0FnTHk4Z0lDQjVPaUI0SUNvZ01pd0tJQ0FnSUM4dklDQWdlRG9nZUNBcUlESXNDaUFnSUNBdkx5QjlLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnZVRvZ2VDQXFJRElzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9ERXRPRFFLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0c5aWFpd2dld29nSUNBZ0x5OGdJQ0I1T2lCNElDb2dNaXdLSUNBZ0lDOHZJQ0FnZURvZ2VDQXFJRElzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdQVDBLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklIZzZJSGdnS2lBeUxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPamd4TFRnMENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHZZbW9zSUhzS0lDQWdJQzh2SUNBZ2VUb2dlQ0FxSURJc0NpQWdJQ0F2THlBZ0lIZzZJSGdnS2lBeUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUQwOUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR052Ym5OMElIWWdQU0I3SUhrNklHOWlhaTU1TENCNE9pQnZZbW91ZUNCOUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNodlltb3NJSHNnZURvZ2RpNTRMQ0I1T2lCMkxua2dmU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUQwOUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0c5aWFpd2dleUI1T2lCN0lHZHlaV0YwWlhKVWFHRnVPaUI0SUgwZ2ZTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHOWlhaXdnZXlCNE9pQjdJR2R5WldGMFpYSlVhR0Z1T2lCNElIMGdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NTBaWE4wUVhKak5FVnVZMjlrYVc1bktIQTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1ZEdWemRFRnlZelJGYm1OdlpHbHVaem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCMFpYTjBRWEpqTkVWdVkyOWthVzVuS0hBNklGQnZhVzUwS1NCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5SbGMzUkJjbU0wUlc1amIyUnBibWRmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxuUmxjM1JCY21NMFJXNWpiMlJwYm1kZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QmhjM05sY25Rb2NDNTRJQ0U5UFNCd0xua3NJQ2RHYjNJZ2RHaGxJSEIxY25CdmMyVWdiMllnZEdocGN5QjBaWE4wTENCaElITm9iM1ZzWkNCdWIzUWdaWEYxWVd3Z1lpY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJHYjNJZ2RHaGxJSEIxY25CdmMyVWdiMllnZEdocGN5QjBaWE4wTENCaElITm9iM1ZzWkNCdWIzUWdaWEYxWVd3Z1lnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJSGc2SUhBdWVDd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJSGs2SUhBdWVTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPVFF0T1RjS0lDQWdJQzh2SUdOdmJuTjBJRzlpYWpvZ1ZtVmpkRzl5SUQwZ2V3b2dJQ0FnTHk4Z0lDQjRPaUJ3TG5nc0NpQWdJQ0F2THlBZ0lIazZJSEF1ZVN3S0lDQWdJQzh2SUgwS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzVPQW9nSUNBZ0x5OGdZMjl1YzNRZ2NFVnVZMjlrWldRZ1BTQmxibU52WkdWQmNtTTBLSEFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdZWE56WlhKMEtIQkZibU52WkdWa0lEMDlQU0J2WW1wRmJtTnZaR1ZrTG5Oc2FXTmxLRGdwTG1OdmJtTmhkQ2h2WW1wRmJtTnZaR1ZrTG5Oc2FXTmxLREFzSURncEtTd2dKMFZ1WTI5a1pXUWdiM0prWlhJZ2MyaHZkV3hrSUdKbElITjNZWEJ3WldRbktRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JqYjI1allYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUlc1amIyUmxaQ0J2Y21SbGNpQnphRzkxYkdRZ1ltVWdjM2RoY0hCbFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbWRsZEZCc2RXZHBiaWhyWlhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbWRsZEZCc2RXZHBiam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGQnNkV2RwYmloclpYazZJSE4wY21sdVp5azZJRkJzZFdkcGJrbHVabThnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTVuWlhSUWJIVm5hVzVmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk9rMTFkR0ZpYkdWUFltcGxZM1JFWlcxdkxtZGxkRkJzZFdkcGJsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJ3YkhWbmFXNXpJRDBnUW05NFRXRndQSE4wY21sdVp5d2dVR3gxWjJsdVNXNW1iejRvZXlCclpYbFFjbVZtYVhnNklDZHdiSFZuYVc1ekp5QjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWljR3gxWjJsdWN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TURnS0lDQWdJQzh2SUdOdmJuTjBJSFpoYkhWbElEMGdZMnh2Ym1Vb2RHaHBjeTV3YkhWbmFXNXpLR3RsZVNrdWRtRnNkV1VwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1UQTVDaUFnSUNBdkx5QmhjM05sY25Rb2RtRnNkV1V1YkdGemRFTmhiR3hsWkM1aGMxVnBiblEyTkNncElENGdNQ3dnSjB4aGMzUWdZMkZzYkdWa0lHNXZkQ0I2WlhKdkp5a0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFMkNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdUR0Z6ZENCallXeHNaV1FnYm05MElIcGxjbThLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhaaGJIVmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem82VFhWMFlXSnNaVTlpYW1WamRFUmxiVzh1WjJWMFRXRnBiaWdwSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6bzZUWFYwWVdKc1pVOWlhbVZqZEVSbGJXOHVaMlYwVFdGcGJqb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbWRsZEUxaGFXNWZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG1kbGRFMWhhVzVmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2NHeDFaMmx1SUQwZ1FtOTRQRkJzZFdkcGJrbHVabTgrS0hzZ2EyVjVPaUFuYldGcGJpY2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWliV0ZwYmlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXhOQW9nSUNBZ0x5OGdZMjl1YzNRZ2RtRnNkV1VnUFNCamJHOXVaU2gwYUdsekxuQnNkV2RwYmk1MllXeDFaU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoMllXeDFaUzVzWVhOMFEyRnNiR1ZrTG1GelZXbHVkRFkwS0NrZ1BpQXdMQ0FuVEdGemRDQmpZV3hzWldRZ2JtOTBJSHBsY204bktRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1ZWE4wSUdOaGJHeGxaQ0J1YjNRZ2VtVnlid29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCeVpYUjFjbTRnZG1Gc2RXVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPanBOZFhSaFlteGxUMkpxWldOMFJHVnRieTV6WlhSUWJIVm5hVzRvYTJWNU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZPazExZEdGaWJHVlBZbXBsWTNSRVpXMXZMbk5sZEZCc2RXZHBiam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFeU13b2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRGQnNkV2RwYmloclpYazZJSE4wY21sdVp5a2dld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qcE5kWFJoWW14bFQySnFaV04wUkdWdGJ5NXpaWFJRYkhWbmFXNWZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TG5ObGRGQnNkV2RwYmw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExZEdGaWJHVXRiMkpxWldOMExtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QmhaRzFwYmxCeWFYWnBiR1ZuWlhNNklHNWxkeUJoY21NMExrSnZiMndvWm1Gc2MyVXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TXpFS0lDQWdJQzh2SUhObGJHVmpkRzl5T2lCdVpYY2dZWEpqTkM1VGRHRjBhV05DZVhSbGN5aHRaWFJvYjJSVFpXeGxZM1J2Y2lnbmRHVnpkQ2dwZG05cFpDY3BLU3dLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdiV1YwYUc5a0lDSjBaWE4wS0NsMmIybGtJZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnphWHBsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1qUXRNVE0yQ2lBZ0lDQXZMeUIwYUdsekxuQnNkV2RwYm5Nb2EyVjVLUzUyWVd4MVpTQTlJSHNLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrVW05MWJtUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdZV1J0YVc1UWNtbDJhV3hsWjJWek9pQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLU3dLSUNBZ0lDOHZJQ0FnYldWMGFHOWtjem9nV3dvZ0lDQWdMeThnSUNBZ0lIc0tJQ0FnSUM4dklDQWdJQ0FnSUhObGJHVmpkRzl5T2lCdVpYY2dZWEpqTkM1VGRHRjBhV05DZVhSbGN5aHRaWFJvYjJSVFpXeGxZM1J2Y2lnbmRHVnpkQ2dwZG05cFpDY3BLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnZlN3S0lDQWdJQzh2SUNBZ1hTd0tJQ0FnSUM4dklIMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV6TVFvZ0lDQWdMeThnYzJWc1pXTjBiM0k2SUc1bGR5QmhjbU0wTGxOMFlYUnBZMEo1ZEdWektHMWxkR2h2WkZObGJHVmpkRzl5S0NkMFpYTjBLQ2wyYjJsa0p5a3BMQW9nSUNBZ1lubDBaV01nTnlBdkx5QnRaWFJvYjJRZ0luUmxjM1FvS1hadmFXUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TWpRdE1UTTJDaUFnSUNBdkx5QjBhR2x6TG5Cc2RXZHBibk1vYTJWNUtTNTJZV3gxWlNBOUlIc0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtVbTkxYm1RNklHNWxkeUJoY21NMExsVnBiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdZMjl2YkdSdmQyNDZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0JzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvS1N3S0lDQWdJQzh2SUNBZ1lXUnRhVzVRY21sMmFXeGxaMlZ6T2lCdVpYY2dZWEpqTkM1Q2IyOXNLR1poYkhObEtTd0tJQ0FnSUM4dklDQWdiV1YwYUc5a2N6b2dXd29nSUNBZ0x5OGdJQ0FnSUhzS0lDQWdJQzh2SUNBZ0lDQWdJSE5sYkdWamRHOXlPaUJ1WlhjZ1lYSmpOQzVUZEdGMGFXTkNlWFJsY3lodFpYUm9iMlJUWld4bFkzUnZjaWduZEdWemRDZ3BkbTlwWkNjcEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUdOdmIyeGtiM2R1T2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0JzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdmU3dLSUNBZ0lDOHZJQ0FnWFN3S0lDQWdJQzh2SUgwS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJqYjI5c1pHOTNiam9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkWFJoWW14bExXOWlhbVZqZEM1aGJHZHZMblJ6T2pFeU5DMHhNellLSUNBZ0lDOHZJSFJvYVhNdWNHeDFaMmx1Y3loclpYa3BMblpoYkhWbElEMGdld29nSUNBZ0x5OGdJQ0JzWVhOMFZtRnNhV1JTYjNWdVpEb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtERXBMQW9nSUNBZ0x5OGdJQ0JqYjI5c1pHOTNiam9nYm1WM0lHRnlZelF1VldsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUd4aGMzUkRZV3hzWldRNklHNWxkeUJoY21NMExsVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQmhaRzFwYmxCeWFYWnBiR1ZuWlhNNklHNWxkeUJoY21NMExrSnZiMndvWm1Gc2MyVXBMQW9nSUNBZ0x5OGdJQ0J0WlhSb2IyUnpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJQ0FnYzJWc1pXTjBiM0k2SUc1bGR5QmhjbU0wTGxOMFlYUnBZMEo1ZEdWektHMWxkR2h2WkZObGJHVmpkRzl5S0NkMFpYTjBLQ2wyYjJsa0p5a3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ1kyOXZiR1J2ZDI0NklHNWxkeUJoY21NMExsVnBiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUd4aGMzUkRZV3hzWldRNklHNWxkeUJoY21NMExsVnBiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0I5TEFvZ0lDQWdMeThnSUNCZExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TXpNS0lDQWdJQzh2SUd4aGMzUkRZV3hzWldRNklHNWxkeUJoY21NMExsVnBiblEyTkNneEtTd0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNalF0TVRNMkNpQWdJQ0F2THlCMGFHbHpMbkJzZFdkcGJuTW9hMlY1S1M1MllXeDFaU0E5SUhzS0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa1VtOTFibVE2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ1kyOXZiR1J2ZDI0NklHNWxkeUJoY21NMExsVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQnNZWE4wUTJGc2JHVmtPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnWVdSdGFXNVFjbWwyYVd4bFoyVnpPaUJ1WlhjZ1lYSmpOQzVDYjI5c0tHWmhiSE5sS1N3S0lDQWdJQzh2SUNBZ2JXVjBhRzlrY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJSHNLSUNBZ0lDOHZJQ0FnSUNBZ0lITmxiR1ZqZEc5eU9pQnVaWGNnWVhKak5DNVRkR0YwYVdOQ2VYUmxjeWh0WlhSb2IyUlRaV3hsWTNSdmNpZ25kR1Z6ZENncGRtOXBaQ2NwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJR052YjJ4a2IzZHVPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQnNZWE4wUTJGc2JHVmtPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFnSUNBZ2ZTd0tJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJSDBLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEkxQ2lBZ0lDQXZMeUJzWVhOMFZtRnNhV1JTYjNWdVpEb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtERXBMQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRYUmhZbXhsTFc5aWFtVmpkQzVoYkdkdkxuUnpPakV5TkMweE16WUtJQ0FnSUM4dklIUm9hWE11Y0d4MVoybHVjeWhyWlhrcExuWmhiSFZsSUQwZ2V3b2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUlNiM1Z1WkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQmpiMjlzWkc5M2Jqb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtDa3NDaUFnSUNBdkx5QWdJR3hoYzNSRFlXeHNaV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCaFpHMXBibEJ5YVhacGJHVm5aWE02SUc1bGR5QmhjbU0wTGtKdmIyd29abUZzYzJVcExBb2dJQ0FnTHk4Z0lDQnRaWFJvYjJSek9pQmJDaUFnSUNBdkx5QWdJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lDQWdjMlZzWldOMGIzSTZJRzVsZHlCaGNtTTBMbE4wWVhScFkwSjVkR1Z6S0cxbGRHaHZaRk5sYkdWamRHOXlLQ2QwWlhOMEtDbDJiMmxrSnlrcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQWdJR3hoYzNSRFlXeHNaV1E2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQjlMQW9nSUNBZ0x5OGdJQ0JkTEFvZ0lDQWdMeThnZlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWMFlXSnNaUzF2WW1wbFkzUXVZV3huYnk1MGN6b3hNallLSUNBZ0lDOHZJR052YjJ4a2IzZHVPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9LU3dLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVjBZV0pzWlMxdlltcGxZM1F1WVd4bmJ5NTBjem94TWpRdE1UTTJDaUFnSUNBdkx5QjBhR2x6TG5Cc2RXZHBibk1vYTJWNUtTNTJZV3gxWlNBOUlIc0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtVbTkxYm1RNklHNWxkeUJoY21NMExsVnBiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdZMjl2YkdSdmQyNDZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0JzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvS1N3S0lDQWdJQzh2SUNBZ1lXUnRhVzVRY21sMmFXeGxaMlZ6T2lCdVpYY2dZWEpqTkM1Q2IyOXNLR1poYkhObEtTd0tJQ0FnSUM4dklDQWdiV1YwYUc5a2N6b2dXd29nSUNBZ0x5OGdJQ0FnSUhzS0lDQWdJQzh2SUNBZ0lDQWdJSE5sYkdWamRHOXlPaUJ1WlhjZ1lYSmpOQzVUZEdGMGFXTkNlWFJsY3lodFpYUm9iMlJUWld4bFkzUnZjaWduZEdWemRDZ3BkbTlwWkNjcEtTd0tJQ0FnSUM4dklDQWdJQ0FnSUdOdmIyeGtiM2R1T2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0JzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdmU3dLSUNBZ0lDOHZJQ0FnWFN3S0lDQWdJQzh2SUgwS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWRHRmliR1V0YjJKcVpXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJzWVhOMFEyRnNiR1ZrT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvS1N3S0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1qUXRNVE0yQ2lBZ0lDQXZMeUIwYUdsekxuQnNkV2RwYm5Nb2EyVjVLUzUyWVd4MVpTQTlJSHNLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrVW05MWJtUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnWTI5dmJHUnZkMjQ2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdZV1J0YVc1UWNtbDJhV3hsWjJWek9pQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLU3dLSUNBZ0lDOHZJQ0FnYldWMGFHOWtjem9nV3dvZ0lDQWdMeThnSUNBZ0lIc0tJQ0FnSUM4dklDQWdJQ0FnSUhObGJHVmpkRzl5T2lCdVpYY2dZWEpqTkM1VGRHRjBhV05DZVhSbGN5aHRaWFJvYjJSVFpXeGxZM1J2Y2lnbmRHVnpkQ2dwZG05cFpDY3BLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHTnZiMnhrYjNkdU9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnSUNCc1lYTjBRMkZzYkdWa09pQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnZlN3S0lDQWdJQzh2SUNBZ1hTd0tJQ0FnSUM4dklIMEtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTWpjS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFYwWVdKc1pTMXZZbXBsWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklIQnNkV2RwYm5NZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCUWJIVm5hVzVKYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNCc2RXZHBibk1uSUgwcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKd2JIVm5hVzV6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFhSaFlteGxMVzlpYW1WamRDNWhiR2R2TG5Sek9qRXlOQzB4TXpZS0lDQWdJQzh2SUhSb2FYTXVjR3gxWjJsdWN5aHJaWGtwTG5aaGJIVmxJRDBnZXdvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdSU2IzVnVaRG9nYm1WM0lHRnlZelF1VldsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNCamIyOXNaRzkzYmpvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0JoWkcxcGJsQnlhWFpwYkdWblpYTTZJRzVsZHlCaGNtTTBMa0p2YjJ3b1ptRnNjMlVwTEFvZ0lDQWdMeThnSUNCdFpYUm9iMlJ6T2lCYkNpQWdJQ0F2THlBZ0lDQWdld29nSUNBZ0x5OGdJQ0FnSUNBZ2MyVnNaV04wYjNJNklHNWxkeUJoY21NMExsTjBZWFJwWTBKNWRHVnpLRzFsZEdodlpGTmxiR1ZqZEc5eUtDZDBaWE4wS0NsMmIybGtKeWtwTEFvZ0lDQWdMeThnSUNBZ0lDQWdZMjl2YkdSdmQyNDZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lHeGhjM1JEWVd4c1pXUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCOUxBb2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdmUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFkR0ZpYkdVdGIySnFaV04wTG1Gc1oyOHVkSE02T2sxMWRHRmliR1ZQWW1wbFkzUkVaVzF2TGw5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaU2dwSUMwK0lIWnZhV1E2Q2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVG9LSUNBZ0lHSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBS0NsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVDQUFRQVNZSkFBUVZIM3gxQkFKRmlBY0V1aWVwdWdRNEZQa3FDQUFBQUFBQUFBQUJCM0JzZFdkcGJuTUVwNEFBM2dnQUFBQUFBQUFBQUVJQUFFSUFBREViSXhOQkFMSkNBQUF4R1NNU1JERVlJeE5CQUtCQ0FBQTJHZ0NBQklrNGpkMkFCTzh5TFcwcWdBVExnZDY0SzRBRUwyY0tWWUFFMU1nZlc0QUU5SU5jSXljRWdBUUFla3l3Z0FTcHZHSHhUd3VPQ3dCR0FFQUFPZ0EwQUM0QUtBQWlBQndBRmdBUUFBcENBQUJDQUFCQ0FBQUFpQUVhUXYvemlBRUhRdi90aUFEaFF2L25pQURMUXYvaGlBQzBRdi9iaUFDbVF2L1ZpQUNQUXYvUGlBQjVRdi9KaUFCR1F2L0RpQUFqUXYrOWlBQVZRdiszUXYrM01Sa2pFakVZSXhJUVJJZ0VWQ1ZEUWdBQWlBRGVKVU5DQUFBMkdnRkpGU1FTUkRZYUFra1ZKQkpFaUFFTEtVOEJVTEFsUTBJQUFEWWFBVWtWSkJKRU5ob0NTUlVpRWtRWE5ob0RTUlVpRWtRWFR3SlBBazhDaUFFS0tVOEJVTEFsUTBJQUFEWWFBVWtWSkJKRWlBRVRKVU5DQUFBMkdnRkpGWUVnRWtTSUFiWWxRMElBQUlnQ2NTVkRRZ0FBTmhvQlNSVWlFa1FYaUFKeUpVTkNBQUEyR2dGSkZTUVNSSWdDM3lWRFFnQUFOaG9CU1NOWkpRdUJBZ2hMQVJVU1JGY0NBSWdES3lsUEFWQ3dKVU5DQUFDSUF6UXBUd0ZRc0NWRFFnQUFOaG9CU1NOWkpRdUJBZ2hMQVJVU1JGY0NBSWdES0NWRFFnQUFJeFlvVHdGUUpSWlFTU01pV0JjV3NFa2lJbGdYRnJBakZpaFBBVkFsRmxCTEFTTWlXQmRPQVVraklsZ1hUd0lTVGdKUEFTSWlXQmRQQVNJaVdCY1NFRVNKaWdJQlFnQUFpLzRqSWxnWGkvOGpJbGdYQ0l2K0lpSllGNHYvSWlKWUZ3aFBBUllvVHdGUVR3RVdVSW1LQXdGQ0FBQ0wvaGFML1NOUEFsMk0vWXYvRm92OUlrOENYVW1NL1ltS0FRQkNBQUNMLzBraklsZ1hUZ0ZKSWlKWUYwOENGaWhQQVZCUEFSWlFUZ0dML3lNaVdCZExBU01pV0JjU1JJdi9JaUpZRjBzQklpSllGeEpFaS84aklsZ1hTd0VqSWxnWEVrNEJpLzhpSWxnWFR3RWlJbGdYRWhCRVNTTWlXQmVML3lNaVdCY1NSRWtpSWxnWGkvOGlJbGdYRWtSSkl5SllGNHYvSXlKWUZ4Sk9BVWtpSWxnWGkvOGlJbGdYRWs4Q0VFUkpJeUpZRjA0QlNTSWlXQmRQQWs0QlRnSkxBU01pV0JjU1JDSWlXQmNTUkltS0FRQkNBQUNML3lNa1dDTWlXQmVML3lNa1dDSWlXQmRQQVJZb1R3RlFUd0VXVUl2L0pDUllJaUpZRjR2L0pDUllJeUpZRjA4QkZpaFBBVkJQQVJaUUtFOENVRThCVUVrakpGZ2pJbGdYRnJCSkl5UllJaUpZRnhhd1NTUWtXQ01pV0JjV3NFa2tKRmdpSWxnWEZyQkpJeVJZSXlKWUY0di9JeVJZSXlKWUZ4Sk9BVWtqSkZnaUlsZ1hpLzhqSkZnaUlsZ1hFazhDRUU0QlNTUWtXQ0lpV0JlTC95UWtXQ01pV0JjU1RnRWtKRmdqSWxnWGkvOGtKRmdpSWxnWEVoQVFSSWxDQUFBcUtoSkVKd1FuQkJKRUt5c1NSSW1LQVFCQ0FBQ0wvNEVDQzBrV0tFOEJVRThCRmxCSklpSllGNHYvZ1FJTEVrNEJTU01pV0JlTC80RUNDeEpQQWhCRVNTSWlXQmRPQVVraklsZ1hUd0lXS0U4QlVFOEJGbEJMQVNNaVdCZE9BVWtpSWxnWFR3SVNUZ0pMQVNJaVdCZFBBU01pV0JjU1R3SVFSRWtpSWxnWGkvOE5SQ01pV0JlTC93MUVpWW9CQUVJQUFJdi9JaUpZRjR2L0l5SllGeE5FaS84aUlsZ1hpLzhqSWxnWFR3RVdLRThCVUU4QkZsQ0wvMDRCU1JVaVN3RVBJa3NDVHdKTlN3SlBBVThDVWs0QlNSVWpTd0VQSTBzQ1R3Sk5UZ0VpU3dFUElrOENUd0pOVHdKUEFrOENVbEFTUkltS0FRRkNBQUFuQm92L1VMNUVTU1FpV0JjakRVU0pRZ0FBZ0FSdFlXbHV2a1JKSkNKWUZ5TU5SSW1LQVFCQ0FBQ0FBUUFqSTFRbkJ4V0JCQkpFS0NjSFVDY0ZVQ2NGVUNVV1Z3WUNUd0ZRS0NjRlVDY0lVQ2NJVUU4Q1VJRWJGbGNHQWxCUEFWQW5Cb3YvVUVtOFNFOEJ2NGxDQUFDSiIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
