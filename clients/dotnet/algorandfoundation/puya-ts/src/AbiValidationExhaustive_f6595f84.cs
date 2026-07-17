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

namespace Arc56.Generated.algorandfoundation.puya_ts.AbiValidationExhaustive_f6595f84
{


    public class AbiValidationExhaustiveProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AbiValidationExhaustiveProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Arc4DynamicStruct : AVMObjectType
            {
                public ulong Foo { get; set; }

                public byte Bar { get; set; }

                public string Baz { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vBaz.From(Baz);
                    stringRef[ret.Count] = vBaz.Encode();
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

                public static Arc4DynamicStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Arc4DynamicStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is ulong vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte vBarValue) { ret.Bar = vBarValue; }
                    var indexBaz = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vBaz.Decode(bytes.Skip(indexBaz + prefixOffset).ToArray());
                    var valueBaz = vBaz.ToValue();
                    if (valueBaz is string vBazValue) { ret.Baz = vBazValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc4DynamicStruct);
                }
                public bool Equals(Arc4DynamicStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc4DynamicStruct left, Arc4DynamicStruct right)
                {
                    return EqualityComparer<Arc4DynamicStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc4DynamicStruct left, Arc4DynamicStruct right)
                {
                    return !(left == right);
                }

            }

            public class Arc4StaticStruct : AVMObjectType
            {
                public ulong Foo { get; set; }

                public byte Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Arc4StaticStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Arc4StaticStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is ulong vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Arc4StaticStruct);
                }
                public bool Equals(Arc4StaticStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Arc4StaticStruct left, Arc4StaticStruct right)
                {
                    return EqualityComparer<Arc4StaticStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(Arc4StaticStruct left, Arc4StaticStruct right)
                {
                    return !(left == right);
                }

            }

            public class WithABool : AVMObjectType
            {
                public byte Foo { get; set; }

                public byte[] Bar { get; set; }

                public bool Baz { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vBaz.From(Baz);
                    ret.AddRange(vBaz.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static WithABool Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new WithABool();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is byte vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte[] vBarValue) { ret.Bar = vBarValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vBaz.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaz = vBaz.ToValue();
                    if (valueBaz is bool vBazValue) { ret.Baz = vBazValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as WithABool);
                }
                public bool Equals(WithABool? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(WithABool left, WithABool right)
                {
                    return EqualityComparer<WithABool>.Default.Equals(left, right);
                }
                public static bool operator !=(WithABool left, WithABool right)
                {
                    return !(left == right);
                }

            }

            public class NativeDynamicStruct : AVMObjectType
            {
                public ulong Foo { get; set; }

                public byte Bar { get; set; }

                public string Baz { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vBaz.From(Baz);
                    stringRef[ret.Count] = vBaz.Encode();
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

                public static NativeDynamicStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NativeDynamicStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is ulong vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte vBarValue) { ret.Bar = vBarValue; }
                    var indexBaz = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vBaz.Decode(bytes.Skip(indexBaz + prefixOffset).ToArray());
                    var valueBaz = vBaz.ToValue();
                    if (valueBaz is string vBazValue) { ret.Baz = vBazValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NativeDynamicStruct);
                }
                public bool Equals(NativeDynamicStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NativeDynamicStruct left, NativeDynamicStruct right)
                {
                    return EqualityComparer<NativeDynamicStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(NativeDynamicStruct left, NativeDynamicStruct right)
                {
                    return !(left == right);
                }

            }

            public class NativeStaticStruct : AVMObjectType
            {
                public ulong Foo { get; set; }

                public byte Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NativeStaticStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NativeStaticStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is ulong vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NativeStaticStruct);
                }
                public bool Equals(NativeStaticStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NativeStaticStruct left, NativeStaticStruct right)
                {
                    return EqualityComparer<NativeStaticStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(NativeStaticStruct left, NativeStaticStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint64(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 117, 140, 89 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint64_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 117, 140, 89 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint8(byte value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 183, 185, 99 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint8_Transactions(byte value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 183, 185, 99 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint512(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 133, 44, 214 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint512_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 133, 44, 214 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUfixed64(System.Numerics.BigInteger value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 46, 251, 225 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UFixed(64, 2); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUfixed64_Transactions(System.Numerics.BigInteger value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 46, 251, 225 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UFixed(64, 2); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint8Arr(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 202, 122, 152 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint8Arr_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 202, 122, 152 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateUint8Arr3(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 218, 115, 192 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(3, "byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateUint8Arr3_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 218, 115, 192 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(3, "byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBool(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 35, 13, 225 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBool_Transactions(bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 35, 13, 225 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateByte(byte value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 199, 127, 172 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateByte_Transactions(byte value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 199, 127, 172 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateString(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 17, 192, 126 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateString_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 17, 192, 126 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBytes(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 104, 183, 209 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBytes_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 104, 183, 209 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateAddress(Algorand.Address value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 76, 14, 135 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateAddress_Transactions(Algorand.Address value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 76, 14, 135 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateAccount(Algorand.Address value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 26, 184, 72 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateAccount_Transactions(Algorand.Address value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 26, 184, 72 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBoolArr(bool[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 40, 159, 184 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBoolArr_Transactions(bool[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 40, 159, 184 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task ValidateBoolArr3(bool[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 172, 238, 81 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>(3, "bool"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateBoolArr3_Transactions(bool[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 172, 238, 81 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>(3, "bool"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4StaticStruct</param>
        public async Task ValidateStaticTuple(Structs.Arc4StaticStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 100, 30, 153 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticTuple_Transactions(Structs.Arc4StaticStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 100, 30, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4DynamicStruct</param>
        public async Task ValidateDynamicTuple(Structs.Arc4DynamicStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 54, 227, 194 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicTuple_Transactions(Structs.Arc4DynamicStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 54, 227, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4StaticStruct</param>
        public async Task ValidateStaticStruct(Structs.Arc4StaticStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 82, 44, 184 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticStruct_Transactions(Structs.Arc4StaticStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 82, 44, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4DynamicStruct</param>
        public async Task ValidateDynamicStruct(Structs.Arc4DynamicStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 136, 136, 37 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStruct_Transactions(Structs.Arc4DynamicStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 136, 136, 37 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4StaticStruct</param>
        public async Task ValidateStaticStructArr(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 170, 144, 214 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticStructArr_Transactions(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 170, 144, 214 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4StaticStruct</param>
        public async Task ValidateStaticStructArr3(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 236, 180, 157 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateStaticStructArr3_Transactions(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 236, 180, 157 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4DynamicStruct</param>
        public async Task ValidateDynamicStructArr(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 56, 136, 41 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStructArr_Transactions(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 56, 136, 41 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4DynamicStruct</param>
        public async Task ValidateDynamicStructArr3(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 128, 75, 191 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStructArr3_Transactions(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 128, 75, 191 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> WithABool</param>
        public async Task ValidateDynamicStructWithABool(Structs.WithABool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 38, 199, 44 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateDynamicStructWithABool_Transactions(Structs.WithABool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 38, 199, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> NativeStaticStruct</param>
        public async Task ValidateNativeStaticStruct(Structs.NativeStaticStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 86, 18, 111 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeStaticStruct_Transactions(Structs.NativeStaticStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 86, 18, 111 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> NativeDynamicStruct</param>
        public async Task ValidateNativeDynamicStruct(Structs.NativeDynamicStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 103, 75, 86 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStruct_Transactions(Structs.NativeDynamicStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 103, 75, 86 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4StaticStruct</param>
        public async Task ValidateNativeStaticStructArr(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 123, 5, 40 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeStaticStructArr_Transactions(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 123, 5, 40 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4StaticStruct</param>
        public async Task ValidateNativeStaticStructArr3(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 81, 149, 253 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeStaticStructArr3_Transactions(Structs.Arc4StaticStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 81, 149, 253 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4StaticStruct>(x => Structs.Arc4StaticStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4DynamicStruct</param>
        public async Task ValidateNativeDynamicStructArr(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 107, 50, 36 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStructArr_Transactions(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 107, 50, 36 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> ARC4DynamicStruct</param>
        public async Task ValidateNativeDynamicStructArr3(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 78, 148, 121 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateNativeDynamicStructArr3_Transactions(Structs.Arc4DynamicStruct[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 78, 148, 121 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Arc4DynamicStruct>(x => Structs.Arc4DynamicStruct.Parse(x)) { IsFixedLength = true, FixedLength = 3 }; valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ValidateC2C(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 181, 130, 241 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateC2C_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 181, 130, 241 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJpVmFsaWRhdGlvbkV4aGF1c3RpdmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQVJDNER5bmFtaWNTdHJ1Y3QiOlt7Im5hbWUiOiJmb28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmFyIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiYmF6IiwidHlwZSI6InN0cmluZyJ9XSwiQVJDNFN0YXRpY1N0cnVjdCI6W3sibmFtZSI6ImZvbyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYXIiLCJ0eXBlIjoidWludDgifV0sIldpdGhBQm9vbCI6W3sibmFtZSI6ImZvbyIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImJhciIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJiYXoiLCJ0eXBlIjoiYm9vbCJ9XSwiTmF0aXZlRHluYW1pY1N0cnVjdCI6W3sibmFtZSI6ImZvbyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYXIiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJiYXoiLCJ0eXBlIjoic3RyaW5nIn1dLCJOYXRpdmVTdGF0aWNTdHJ1Y3QiOlt7Im5hbWUiOiJmb28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmFyIiwidHlwZSI6InVpbnQ4In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InZhbGlkYXRlX3VpbnQ2NCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV91aW50OCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX3VpbnQ1MTIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX3VmaXhlZDY0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVmaXhlZDY0eDIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV91aW50OF9hcnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX3VpbnQ4X2FycjMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbM10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9ib29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9ieXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGUiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9zdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYWNjb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYm9vbF9hcnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfYm9vbF9hcnIzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2xbM10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9zdGF0aWNfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCkiLCJzdHJ1Y3QiOiJBUkM0U3RhdGljU3RydWN0IiwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX2R5bmFtaWNfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCxzdHJpbmcpIiwic3RydWN0IjoiQVJDNER5bmFtaWNTdHJ1Y3QiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfc3RhdGljX3N0cnVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ4KSIsInN0cnVjdCI6IkFSQzRTdGF0aWNTdHJ1Y3QiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfZHluYW1pY19zdHJ1Y3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCxzdHJpbmcpIiwic3RydWN0IjoiQVJDNER5bmFtaWNTdHJ1Y3QiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfc3RhdGljX3N0cnVjdF9hcnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OClbXSIsInN0cnVjdCI6IkFSQzRTdGF0aWNTdHJ1Y3QiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfc3RhdGljX3N0cnVjdF9hcnIzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDgpWzNdIiwic3RydWN0IjoiQVJDNFN0YXRpY1N0cnVjdCIsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9keW5hbWljX3N0cnVjdF9hcnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCxzdHJpbmcpW10iLCJzdHJ1Y3QiOiJBUkM0RHluYW1pY1N0cnVjdCIsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9keW5hbWljX3N0cnVjdF9hcnIzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDgsc3RyaW5nKVszXSIsInN0cnVjdCI6IkFSQzREeW5hbWljU3RydWN0IiwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX2R5bmFtaWNfc3RydWN0X3dpdGhfYV9ib29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCxieXRlW10sYm9vbCkiLCJzdHJ1Y3QiOiJXaXRoQUJvb2wiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfbmF0aXZlX3N0YXRpY19zdHJ1Y3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCkiLCJzdHJ1Y3QiOiJOYXRpdmVTdGF0aWNTdHJ1Y3QiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfbmF0aXZlX2R5bmFtaWNfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDgsc3RyaW5nKSIsInN0cnVjdCI6Ik5hdGl2ZUR5bmFtaWNTdHJ1Y3QiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfbmF0aXZlX3N0YXRpY19zdHJ1Y3RfYXJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDgpW10iLCJzdHJ1Y3QiOiJBUkM0U3RhdGljU3RydWN0IiwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX25hdGl2ZV9zdGF0aWNfc3RydWN0X2FycjMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OClbM10iLCJzdHJ1Y3QiOiJBUkM0U3RhdGljU3RydWN0IiwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX25hdGl2ZV9keW5hbWljX3N0cnVjdF9hcnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCxzdHJpbmcpW10iLCJzdHJ1Y3QiOiJBUkM0RHluYW1pY1N0cnVjdCIsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9uYXRpdmVfZHluYW1pY19zdHJ1Y3RfYXJyMyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ4LHN0cmluZylbM10iLCJzdHJ1Y3QiOiJBUkM0RHluYW1pY1N0cnVjdCIsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV9jMmMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTcyXSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMzEsMTMzMywxNTc0LDE2NzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg0LDk0NCw5NjQsMTAxMiwxMDgyLDExMzUsMTE1NywxMTkyLDEyNjgsMTM2OCwxNDI0LDE0NzgsMTUwMCwxNTM1LDE2MTEsMTcxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgQVJDNER5bmFtaWNTdHJ1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTA3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIEFSQzRTdGF0aWNTdHJ1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFdpdGhBQm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjk4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxBUkM0RHluYW1pY1N0cnVjdD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxBUkM0U3RhdGljU3RydWN0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuYm9vbD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OTMsOTUzLDk3M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx0ZXN0cy9hcHByb3ZhbHMvYWJpLXZhbGlkYXRpb24tZXhoYXVzdGl2ZS5hbGdvLnRzOjpOYXRpdmVEeW5hbWljU3RydWN0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RzL2FwcHJvdmFscy9hYmktdmFsaWRhdGlvbi1leGhhdXN0aXZlLmFsZ28udHM6Ok5hdGl2ZVN0YXRpY1N0cnVjdD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PEFSQzREeW5hbWljU3RydWN0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8QVJDNFN0YXRpY1N0cnVjdCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQuYm9vbCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4NywxMDAxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8dGVzdHMvYXBwcm92YWxzL2FiaS12YWxpZGF0aW9uLWV4aGF1c3RpdmUuYWxnby50czo6TmF0aXZlRHluYW1pY1N0cnVjdCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PHRlc3RzL2FwcHJvdmFscy9hYmktdmFsaWRhdGlvbi1leGhhdXN0aXZlLmFsZ28udHM6Ok5hdGl2ZVN0YXRpY1N0cnVjdCwgMz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8YXJjNC51aW50NjQsYXJjNC51aW50OCxhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPGFyYzQudWludDY0LGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWZpeGVkNjR4MiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDUsOTMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDg5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RzL2FwcHJvdmFscy9hYmktdmFsaWRhdGlvbi1leGhhdXN0aXZlLmFsZ28udHM6Ok5hdGl2ZUR5bmFtaWNTdHJ1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RzL2FwcHJvdmFscy9hYmktdmFsaWRhdGlvbi1leGhhdXN0aXZlLmFsZ28udHM6Ok5hdGl2ZVN0YXRpY1N0cnVjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50OCwobGVuK3VpbnQ4W10pLGJvb2wxKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNzMsMTEyNiwxMjYzLDEzNjMsMTQ2OSwxNjA2LDE3MDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICh1aW50NjQsdWludDgsKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMzksMTU4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyh1aW50NjQsdWludDgsKGxlbit1dGY4W10pKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNDEsMTY4NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAodWludDY0LHVpbnQ4LChsZW4rdXRmOFtdKSlbM10iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDY5LDExMjIsMTI1OSwxMzU5LDE0MTAsMTQ2NSwxNjAyLDE3MDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURJZ01URUtJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXdDZ3B0WVdsdVgySnNiMk5yUURBNkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Rb0tiV0ZwYmw5aWJHOWphMEF4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdZMnhoYzNNZ1FXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF6TndvZ0lDQWdZaUJ0WVdsdVgyRmlhVjl5YjNWMGFXNW5RRElLQ20xaGFXNWZZV0pwWDNKdmRYUnBibWRBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR05zWVhOeklFRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU16VUtJQ0FnSUdJZ2JXRnBibDlqWVd4c1gwNXZUM0JBTXdvS2JXRnBibDlqWVd4c1gwNXZUM0JBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR05zWVhOeklFRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdRM05UaGpOVGtnTHk4Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5MWFXNTBOalFvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMlltSTNZamsyTXlBdkx5QnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgzVnBiblE0S0hWcGJuUTRLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE9EZzFNbU5rTmlBdkx5QnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgzVnBiblExTVRJb2RXbHVkRFV4TWlsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROV0l5WldaaVpURWdMeThnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjkxWm1sNFpXUTJOQ2gxWm1sNFpXUTJOSGd5S1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxZMk5oTjJFNU9DQXZMeUJ0WlhSb2IyUWdJblpoYkdsa1lYUmxYM1ZwYm5RNFgyRnljaWgxYVc1ME9GdGRLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNU5HUmhOek5qTUNBdkx5QnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgzVnBiblE0WDJGeWNqTW9kV2x1ZERoYk0xMHBkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJMk1qTXdaR1V4SUM4dklHMWxkR2h2WkNBaWRtRnNhV1JoZEdWZlltOXZiQ2hpYjI5c0tYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6WldNM04yWmhZeUF2THlCdFpYUm9iMlFnSW5aaGJHbGtZWFJsWDJKNWRHVW9ZbmwwWlNsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaakV4TVdNd04yVWdMeThnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjl6ZEhKcGJtY29jM1J5YVc1bktYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6WmpZNFlqZGtNU0F2THlCdFpYUm9iMlFnSW5aaGJHbGtZWFJsWDJKNWRHVnpLR0o1ZEdWYlhTbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpjMFl6QmxPRGNnTHk4Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5aFpHUnlaWE56S0dGa1pISmxjM01wZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQTVNV0ZpT0RRNElDOHZJRzFsZEdodlpDQWlkbUZzYVdSaGRHVmZZV05qYjNWdWRDaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtTXpJNE9XWmlPQ0F2THlCdFpYUm9iMlFnSW5aaGJHbGtZWFJsWDJKdmIyeGZZWEp5S0dKdmIyeGJYU2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9URmhZMlZsTlRFZ0x5OGdiV1YwYUc5a0lDSjJZV3hwWkdGMFpWOWliMjlzWDJGeWNqTW9ZbTl2YkZzelhTbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdVMk5ERmxPVGtnTHk4Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5emRHRjBhV05mZEhWd2JHVW9LSFZwYm5RMk5DeDFhVzUwT0NrcGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFkxTXpabE0yTXlJQzh2SUcxbGRHaHZaQ0FpZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTkwZFhCc1pTZ29kV2x1ZERZMExIVnBiblE0TEhOMGNtbHVaeWtwZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEa3pOVEl5WTJJNElDOHZJRzFsZEdodlpDQWlkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZENnb2RXbHVkRFkwTEhWcGJuUTRLU2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFltWTRPRGc0TWpVZ0x5OGdiV1YwYUc5a0lDSjJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZENnb2RXbHVkRFkwTEhWcGJuUTRMSE4wY21sdVp5a3BkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJeVlXRTVNR1EySUM4dklHMWxkR2h2WkNBaWRtRnNhV1JoZEdWZmMzUmhkR2xqWDNOMGNuVmpkRjloY25Jb0tIVnBiblEyTkN4MWFXNTBPQ2xiWFNsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRObVZsWTJJME9XUWdMeThnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgyRnljak1vS0hWcGJuUTJOQ3gxYVc1ME9DbGJNMTBwZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTRNemc0T0RJNUlDOHZJRzFsZEdodlpDQWlkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlLQ2gxYVc1ME5qUXNkV2x1ZERnc2MzUnlhVzVuS1Z0ZEtYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczWlRnd05HSmlaaUF2THlCdFpYUm9iMlFnSW5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pNb0tIVnBiblEyTkN4MWFXNTBPQ3h6ZEhKcGJtY3BXek5kS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpaVEkyWXpjeVl5QXZMeUJ0WlhSb2IyUWdJblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgzZHBkR2hmWVY5aWIyOXNLQ2gxYVc1ME9DeGllWFJsVzEwc1ltOXZiQ2twZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHVmpOVFl4TWpabUlDOHZJRzFsZEdodlpDQWlkbUZzYVdSaGRHVmZibUYwYVhabFgzTjBZWFJwWTE5emRISjFZM1FvS0hWcGJuUTJOQ3gxYVc1ME9Da3BkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdNek5qYzBZalUySUM4dklHMWxkR2h2WkNBaWRtRnNhV1JoZEdWZmJtRjBhWFpsWDJSNWJtRnRhV05mYzNSeWRXTjBLQ2gxYVc1ME5qUXNkV2x1ZERnc2MzUnlhVzVuS1NsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRabUkzWWpBMU1qZ2dMeThnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVjl1WVhScGRtVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSW9LSFZwYm5RMk5DeDFhVzUwT0NsYlhTbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WW1FMU1UazFabVFnTHk4Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWhjbkl6S0NoMWFXNTBOalFzZFdsdWREZ3BXek5kS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxNelppTXpJeU5DQXZMeUJ0WlhSb2IyUWdJblpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSW9LSFZwYm5RMk5DeDFhVzUwT0N4emRISnBibWNwVzEwcGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFUzTkdVNU5EYzVJQzh2SUcxbGRHaHZaQ0FpZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak1vS0hWcGJuUTJOQ3gxYVc1ME9DeHpkSEpwYm1jcFd6TmRLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa01HSTFPREptTVNBdkx5QnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgyTXlZeWdwZG05cFpDSUtJQ0FnSUhWdVkyOTJaWElnTXpBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZG1Gc2FXUmhkR1ZmZFdsdWREWTBYM0p2ZFhSbFFEUWdiV0ZwYmw5MllXeHBaR0YwWlY5MWFXNTBPRjl5YjNWMFpVQTFJRzFoYVc1ZmRtRnNhV1JoZEdWZmRXbHVkRFV4TWw5eWIzVjBaVUEySUcxaGFXNWZkbUZzYVdSaGRHVmZkV1pwZUdWa05qUmZjbTkxZEdWQU55QnRZV2x1WDNaaGJHbGtZWFJsWDNWcGJuUTRYMkZ5Y2w5eWIzVjBaVUE0SUcxaGFXNWZkbUZzYVdSaGRHVmZkV2x1ZERoZllYSnlNMTl5YjNWMFpVQTVJRzFoYVc1ZmRtRnNhV1JoZEdWZlltOXZiRjl5YjNWMFpVQXhNQ0J0WVdsdVgzWmhiR2xrWVhSbFgySjVkR1ZmY205MWRHVkFNVEVnYldGcGJsOTJZV3hwWkdGMFpWOXpkSEpwYm1kZmNtOTFkR1ZBTVRJZ2JXRnBibDkyWVd4cFpHRjBaVjlpZVhSbGMxOXliM1YwWlVBeE15QnRZV2x1WDNaaGJHbGtZWFJsWDJGa1pISmxjM05mY205MWRHVkFNVFFnYldGcGJsOTJZV3hwWkdGMFpWOWhZMk52ZFc1MFgzSnZkWFJsUURFMUlHMWhhVzVmZG1Gc2FXUmhkR1ZmWW05dmJGOWhjbkpmY205MWRHVkFNVFlnYldGcGJsOTJZV3hwWkdGMFpWOWliMjlzWDJGeWNqTmZjbTkxZEdWQU1UY2diV0ZwYmw5MllXeHBaR0YwWlY5emRHRjBhV05mZEhWd2JHVmZjbTkxZEdWQU1UZ2diV0ZwYmw5MllXeHBaR0YwWlY5a2VXNWhiV2xqWDNSMWNHeGxYM0p2ZFhSbFFERTVJRzFoYVc1ZmRtRnNhV1JoZEdWZmMzUmhkR2xqWDNOMGNuVmpkRjl5YjNWMFpVQXlNQ0J0WVdsdVgzWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDNKdmRYUmxRREl4SUcxaGFXNWZkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSmZjbTkxZEdWQU1qSWdiV0ZwYmw5MllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2pOZmNtOTFkR1ZBTWpNZ2JXRnBibDkyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkpmY205MWRHVkFNalFnYldGcGJsOTJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpYM0p2ZFhSbFFESTFJRzFoYVc1ZmRtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmZDJsMGFGOWhYMkp2YjJ4ZmNtOTFkR1ZBTWpZZ2JXRnBibDkyWVd4cFpHRjBaVjl1WVhScGRtVmZjM1JoZEdsalgzTjBjblZqZEY5eWIzVjBaVUF5TnlCdFlXbHVYM1poYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5eWIzVjBaVUF5T0NCdFlXbHVYM1poYkdsa1lYUmxYMjVoZEdsMlpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNsOXliM1YwWlVBeU9TQnRZV2x1WDNaaGJHbGtZWFJsWDI1aGRHbDJaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgyRnljak5mY205MWRHVkFNekFnYldGcGJsOTJZV3hwWkdGMFpWOXVZWFJwZG1WZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeVgzSnZkWFJsUURNeElHMWhhVzVmZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mY205MWRHVkFNeklnYldGcGJsOTJZV3hwWkdGMFpWOWpNbU5mY205MWRHVkFNek1LSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNMENncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTXpRNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRE0yT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpnS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXpPRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHTnNZWE56SUVGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1pYSnlDZ3B0WVdsdVgzWmhiR2xrWVhSbFgyTXlZMTl5YjNWMFpVQXpNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1UTTJDaUFnSUNBdkx5QjJZV3hwWkdGMFpWOWpNbU1vS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFpoYkdsa1lYUmxYMk15WXdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU16UUtDbTFoYVc1ZmRtRnNhV1JoZEdWZmJtRjBhWFpsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pOZmNtOTFkR1ZBTXpJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV6TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJR05oYkd4emRXSWdkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNqTUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRE0wQ2dwdFlXbHVYM1poYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSmZjbTkxZEdWQU16RTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pFeU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTXpRS0NtMWhhVzVmZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlNMTl5YjNWMFpVQXpNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1USXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCMllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWhjbkl6Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBek5Bb0tiV0ZwYmw5MllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWhjbkpmY205MWRHVkFNams2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qRXhPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBek5Bb0tiV0ZwYmw5MllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZjbTkxZEdWQU1qZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pFeE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXpOQW9LYldGcGJsOTJZV3hwWkdGMFpWOXVZWFJwZG1WZmMzUmhkR2xqWDNOMGNuVmpkRjl5YjNWMFpVQXlOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1URXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCMllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNelFLQ20xaGFXNWZkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZmQybDBhRjloWDJKdmIyeGZjbTkxZEdWQU1qWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pFd053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZkMmwwYUY5aFgySnZiMndLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNMENncHRZV2x1WDNaaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pOZmNtOTFkR1ZBTWpVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJR05oYkd4emRXSWdkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTXpRS0NtMWhhVzVmZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5WDNKdmRYUmxRREkwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXpOQW9LYldGcGJsOTJZV3hwWkdGMFpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNqTmZjbTkxZEdWQU1qTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnWTJGc2JITjFZaUIyWVd4cFpHRjBaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgyRnljak1LSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNMENncHRZV2x1WDNaaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5WDNKdmRYUmxRREl5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtRnNhV1JoZEdWZmMzUmhkR2xqWDNOMGNuVmpkRjloY25JS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFETTBDZ3B0WVdsdVgzWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDNKdmRYUmxRREl4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1FLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNMENncHRZV2x1WDNaaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUmZjbTkxZEdWQU1qQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnWTJGc2JITjFZaUIyWVd4cFpHRjBaVjl6ZEdGMGFXTmZjM1J5ZFdOMENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXpOQW9LYldGcGJsOTJZV3hwWkdGMFpWOWtlVzVoYldsalgzUjFjR3hsWDNKdmRYUmxRREU1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtRnNhV1JoZEdWZlpIbHVZVzFwWTE5MGRYQnNaUW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTXpRS0NtMWhhVzVmZG1Gc2FXUmhkR1ZmYzNSaGRHbGpYM1IxY0d4bFgzSnZkWFJsUURFNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJR05oYkd4emRXSWdkbUZzYVdSaGRHVmZjM1JoZEdsalgzUjFjR3hsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBek5Bb0tiV0ZwYmw5MllXeHBaR0YwWlY5aWIyOXNYMkZ5Y2pOZmNtOTFkR1ZBTVRjNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdZMkZzYkhOMVlpQjJZV3hwWkdGMFpWOWliMjlzWDJGeWNqTUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRE0wQ2dwdFlXbHVYM1poYkdsa1lYUmxYMkp2YjJ4ZllYSnlYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnZG1Gc2FXUmhkR1ZmWW05dmJGOWhjbklLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNMENncHRZV2x1WDNaaGJHbGtZWFJsWDJGalkyOTFiblJmY205MWRHVkFNVFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCMllXeHBaR0YwWlY5aFkyTnZkVzUwQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBek5Bb0tiV0ZwYmw5MllXeHBaR0YwWlY5aFpHUnlaWE56WDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2RtRnNhV1JoZEdWZllXUmtjbVZ6Y3dvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU16UUtDbTFoYVc1ZmRtRnNhV1JoZEdWZllubDBaWE5mY205MWRHVkFNVE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ1kyRnNiSE4xWWlCMllXeHBaR0YwWlY5aWVYUmxjd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTXpRS0NtMWhhVzVmZG1Gc2FXUmhkR1ZmYzNSeWFXNW5YM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnZG1Gc2FXUmhkR1ZmYzNSeWFXNW5DaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF6TkFvS2JXRnBibDkyWVd4cFpHRjBaVjlpZVhSbFgzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJR05oYkd4emRXSWdkbUZzYVdSaGRHVmZZbmwwWlFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU16UUtDbTFoYVc1ZmRtRnNhV1JoZEdWZlltOXZiRjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCallXeHNjM1ZpSUhaaGJHbGtZWFJsWDJKdmIyd0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRE0wQ2dwdFlXbHVYM1poYkdsa1lYUmxYM1ZwYm5RNFgyRnljak5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCallXeHNjM1ZpSUhaaGJHbGtZWFJsWDNWcGJuUTRYMkZ5Y2pNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFETTBDZ3B0WVdsdVgzWmhiR2xrWVhSbFgzVnBiblE0WDJGeWNsOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJR05oYkd4emRXSWdkbUZzYVdSaGRHVmZkV2x1ZERoZllYSnlDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF6TkFvS2JXRnBibDkyWVd4cFpHRjBaVjkxWm1sNFpXUTJORjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnZG1Gc2FXUmhkR1ZmZFdacGVHVmtOalFLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNMENncHRZV2x1WDNaaGJHbGtZWFJsWDNWcGJuUTFNVEpmY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCallXeHNjM1ZpSUhaaGJHbGtZWFJsWDNWcGJuUTFNVElLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNMENncHRZV2x1WDNaaGJHbGtZWFJsWDNWcGJuUTRYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnWTJGc2JITjFZaUIyWVd4cFpHRjBaVjkxYVc1ME9Bb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNelFLQ20xaGFXNWZkbUZzYVdSaGRHVmZkV2x1ZERZMFgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdZMkZzYkhOMVlpQjJZV3hwWkdGMFpWOTFhVzUwTmpRS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFETTBDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRE0xT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpZS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRE0zT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdZMnhoYzNNZ1FXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmRXbHVkRFkwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtRnNhV1JoZEdWZmRXbHVkRFkwT2dvZ0lDQWdZaUIyWVd4cFpHRjBaVjkxYVc1ME5qUmZZbXh2WTJ0QU1Bb0tkbUZzYVdSaGRHVmZkV2x1ZERZMFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOTFhVzUwT0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgzVnBiblE0T2dvZ0lDQWdZaUIyWVd4cFpHRjBaVjkxYVc1ME9GOWliRzlqYTBBd0NncDJZV3hwWkdGMFpWOTFhVzUwT0Y5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZkV2x1ZERnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5MWFXNTBOVEV5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtRnNhV1JoZEdWZmRXbHVkRFV4TWpvS0lDQWdJR0lnZG1Gc2FXUmhkR1ZmZFdsdWREVXhNbDlpYkc5amEwQXdDZ3AyWVd4cFpHRjBaVjkxYVc1ME5URXlYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5MWFXNTBOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmZFdacGVHVmtOalJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5MVptbDRaV1EyTkRvS0lDQWdJR0lnZG1Gc2FXUmhkR1ZmZFdacGVHVmtOalJmWW14dlkydEFNQW9LZG1Gc2FXUmhkR1ZmZFdacGVHVmtOalJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgzVm1hWGhsWkRZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmRXbHVkRGhmWVhKeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZkV2x1ZERoZllYSnlPZ29nSUNBZ1lpQjJZV3hwWkdGMFpWOTFhVzUwT0Y5aGNuSmZZbXh2WTJ0QU1Bb0tkbUZzYVdSaGRHVmZkV2x1ZERoZllYSnlYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5MWFXNTBPRjloY25JS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5MWFXNTBPRjloY25JelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZkV2x1ZERoZllYSnlNem9LSUNBZ0lHSWdkbUZzYVdSaGRHVmZkV2x1ZERoZllYSnlNMTlpYkc5amEwQXdDZ3AyWVd4cFpHRjBaVjkxYVc1ME9GOWhjbkl6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOTFhVzUwT0Y5aGNuSXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZbTl2YkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgySnZiMnc2Q2lBZ0lDQmlJSFpoYkdsa1lYUmxYMkp2YjJ4ZllteHZZMnRBTUFvS2RtRnNhV1JoZEdWZlltOXZiRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMko1ZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOWllWFJsT2dvZ0lDQWdZaUIyWVd4cFpHRjBaVjlpZVhSbFgySnNiMk5yUURBS0NuWmhiR2xrWVhSbFgySjVkR1ZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgySjVkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjl6ZEhKcGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWVd4cFpHRjBaVjl6ZEhKcGJtYzZDaUFnSUNCaUlIWmhiR2xrWVhSbFgzTjBjbWx1WjE5aWJHOWphMEF3Q2dwMllXeHBaR0YwWlY5emRISnBibWRmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgzTjBjbWx1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJKNWRHVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmWW5sMFpYTTZDaUFnSUNCaUlIWmhiR2xrWVhSbFgySjVkR1Z6WDJKc2IyTnJRREFLQ25aaGJHbGtZWFJsWDJKNWRHVnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5aWVYUmxjd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMkZrWkhKbGMzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWVd4cFpHRjBaVjloWkdSeVpYTnpPZ29nSUNBZ1lpQjJZV3hwWkdGMFpWOWhaR1J5WlhOelgySnNiMk5yUURBS0NuWmhiR2xrWVhSbFgyRmtaSEpsYzNOZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMkZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWhZMk52ZFc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZZV05qYjNWdWREb0tJQ0FnSUdJZ2RtRnNhV1JoZEdWZllXTmpiM1Z1ZEY5aWJHOWphMEF3Q2dwMllXeHBaR0YwWlY5aFkyTnZkVzUwWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWhZMk52ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlltOXZiRjloY25KYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOWliMjlzWDJGeWNqb0tJQ0FnSUdJZ2RtRnNhV1JoZEdWZlltOXZiRjloY25KZllteHZZMnRBTUFvS2RtRnNhV1JoZEdWZlltOXZiRjloY25KZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMkp2YjJ4ZllYSnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZbTl2YkY5aGNuSXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmWW05dmJGOWhjbkl6T2dvZ0lDQWdZaUIyWVd4cFpHRjBaVjlpYjI5c1gyRnljak5mWW14dlkydEFNQW9LZG1Gc2FXUmhkR1ZmWW05dmJGOWhjbkl6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWliMjlzWDJGeWNqTUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOXpkR0YwYVdOZmRIVndiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5emRHRjBhV05mZEhWd2JHVTZDaUFnSUNCaUlIWmhiR2xrWVhSbFgzTjBZWFJwWTE5MGRYQnNaVjlpYkc5amEwQXdDZ3AyWVd4cFpHRjBaVjl6ZEdGMGFXTmZkSFZ3YkdWZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYM04wWVhScFkxOTBkWEJzWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mZEhWd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM1IxY0d4bE9nb2dJQ0FnWWlCMllXeHBaR0YwWlY5a2VXNWhiV2xqWDNSMWNHeGxYMkpzYjJOclFEQUtDblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZkSFZ3YkdWZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZOemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZkSFZ3YkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2FXUmhkR1ZmYzNSaGRHbGpYM04wY25WamREb0tJQ0FnSUdJZ2RtRnNhV1JoZEdWZmMzUmhkR2xqWDNOMGNuVmpkRjlpYkc5amEwQXdDZ3AyWVd4cFpHRjBaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjl6ZEdGMGFXTmZjM1J5ZFdOMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5a2VXNWhiV2xqWDNOMGNuVmpkRG9LSUNBZ0lHSWdkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllteHZZMnRBTUFvS2RtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYzNSaGRHbGpYM04wY25WamRGOWhjbkpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2pvS0lDQWdJR0lnZG1Gc2FXUmhkR1ZmYzNSaGRHbGpYM04wY25WamRGOWhjbkpmWW14dlkydEFNQW9LZG1Gc2FXUmhkR1ZmYzNSaGRHbGpYM04wY25WamRGOWhjbkpmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgzTjBZWFJwWTE5emRISjFZM1JmWVhKeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmMzUmhkR2xqWDNOMGNuVmpkRjloY25JelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSXpPZ29nSUNBZ1lpQjJZV3hwWkdGMFpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNqTmZZbXh2WTJ0QU1Bb0tkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSXpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2pNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25KYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSTZDaUFnSUNCaUlIWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOWliRzlqYTBBd0NncDJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhaaGJHbGtZWFJsUlc1amIyUnBibWM2SUNkMWJuTmhabVV0WkdsellXSnNaV1FuSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpPZ29nSUNBZ1lpQjJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpYMkpzYjJOclFEQUtDblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZmQybDBhRjloWDJKdmIyeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOTNhWFJvWDJGZlltOXZiRG9LSUNBZ0lHSWdkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZmQybDBhRjloWDJKdmIyeGZZbXh2WTJ0QU1Bb0tkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZmQybDBhRjloWDJKdmIyeGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjkzYVhSb1gyRmZZbTl2YkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDI1aGRHbDJaVjl6ZEdGMGFXTmZjM1J5ZFdOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHVmZibUYwYVhabFgzTjBZWFJwWTE5emRISjFZM1E2Q2lBZ0lDQmlJSFpoYkdsa1lYUmxYMjVoZEdsMlpWOXpkR0YwYVdOZmMzUnlkV04wWDJKc2IyTnJRREFLQ25aaGJHbGtZWFJsWDI1aGRHbDJaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV4TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNRNkNpQWdJQ0JpSUhaaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRGOWliRzlqYTBBd0NncDJZV3hwWkdGMFpWOXVZWFJwZG1WZlpIbHVZVzFwWTE5emRISjFZM1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOXVZWFJwZG1WZlpIbHVZVzFwWTE5emRISjFZM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjl1WVhScGRtVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWVd4cFpHRjBaVjl1WVhScGRtVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSTZDaUFnSUNCaUlIWmhiR2xrWVhSbFgyNWhkR2wyWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2w5aWJHOWphMEF3Q2dwMllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWhjbkpmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOXVZWFJwZG1WZmMzUmhkR2xqWDNOMGNuVmpkRjloY25JS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWhjbkl6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5TXpvS0lDQWdJR0lnZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlNMTlpYkc5amEwQXdDZ3AyWVd4cFpHRjBaVjl1WVhScGRtVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSXpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pFeU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5TXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5T2dvZ0lDQWdZaUIyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlYMkpzYjJOclFEQUtDblpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TVRJM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5TXpvS0lDQWdJR0lnZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWW14dlkydEFNQW9LZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOXVZWFJwZG1WZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeU13b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyTXlZMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsWDJNeVl6b0tJQ0FnSUdJZ2RtRnNhV1JoZEdWZll6SmpYMkpzYjJOclFEQUtDblpoYkdsa1lYUmxYMk15WTE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hNellLSUNBZ0lDOHZJSFpoYkdsa1lYUmxYMk15WXlncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZll6SmpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZkV2x1ZERZMEtIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmRXbHVkRFkwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hPUzB5TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJQzh2SUhaaGJHbGtZWFJsWDNWcGJuUTJOQ2gyWVd4MVpUb2dZWEpqTkM1VmFXNTBOalFwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjkxYVc1ME5qUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmZFdsdWREWTBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCMllXeHBaR0YwWlVWdVkyOWthVzVuS0haaGJIVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDNWcGJuUTRLSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZkV2x1ZERnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakl6TFRJMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWZmRXbHVkRGdvZG1Gc2RXVTZJR0Z5WXpRdVZXbHVkRGdwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjkxYVc1ME9GOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjkxYVc1ME9GOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBPQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmZFdsdWREVXhNaWgyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYM1ZwYm5RMU1USTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pJM0xUSTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ0x5OGdkbUZzYVdSaGRHVmZkV2x1ZERVeE1paDJZV3gxWlRvZ1lYSmpOQzVWYVc1MFBEVXhNajRwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjkxYVc1ME5URXlYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDNWcGJuUTFNVEpmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklIWmhiR2xrWVhSbFJXNWpiMlJwYm1jb2RtRnNkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOTFabWw0WldRMk5DaDJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgzVm1hWGhsWkRZME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem96TVMwek1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUM4dklIWmhiR2xrWVhSbFgzVm1hWGhsWkRZMEtIWmhiSFZsT2lCaGNtTTBMbFZHYVhobFpEdzJOQ3dnTWo0cElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5MVptbDRaV1EyTkY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOTFabWw0WldRMk5GOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdacGVHVmtOalI0TWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmRXbHVkRGhmWVhKeUtIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmRXbHVkRGhmWVhKeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem96TlMwek5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUM4dklIWmhiR2xrWVhSbFgzVnBiblE0WDJGeWNpaDJZV3gxWlRvZ1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhrOFlYSmpOQzVWYVc1ME9ENHBJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOTFhVzUwT0Y5aGNuSmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmZFdsdWREaGZZWEp5WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bktIWmhiSFZsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5MWFXNTBPRjloY25JektIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmRXbHVkRGhmWVhKeU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TXprdE5EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNBdkx5QjJZV3hwWkdGMFpWOTFhVzUwT0Y5aGNuSXpLSFpoYkhWbE9pQmhjbU0wTGxOMFlYUnBZMEZ5Y21GNVBHRnlZelF1VldsdWREZ3NJRE0rS1NCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmZFdsdWREaGZZWEp5TTE5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOTFhVzUwT0Y5aGNuSXpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMllXeHBaR0YwWlVWdVkyOWthVzVuS0haaGJIVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXo0S0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgySnZiMndvZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlpYjI5c09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem8wTXkwME5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUM4dklIWmhiR2xrWVhSbFgySnZiMndvZG1Gc2RXVTZJR0Z5WXpRdVFtOXZiQ2tnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMkp2YjJ4ZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZbTl2YkY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdkbUZzYVdSaGRHVkZibU52WkdsdVp5aDJZV3gxWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWllWFJsS0haaGJIVmxPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWW5sMFpUb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TkRjdE5EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNBdkx5QjJZV3hwWkdGMFpWOWllWFJsS0haaGJIVmxPaUJoY21NMExrSjVkR1VwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlpZVhSbFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMko1ZEdWZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJSFpoYkdsa1lYUmxSVzVqYjJScGJtY29kbUZzZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREZ0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYM04wY21sdVp5aDJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgzTjBjbWx1WnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZOVEV0TlRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhaaGJHbGtZWFJsUlc1amIyUnBibWM2SUNkMWJuTmhabVV0WkdsellXSnNaV1FuSUgwcENpQWdJQ0F2THlCMllXeHBaR0YwWlY5emRISnBibWNvZG1Gc2RXVTZJR0Z5WXpRdVUzUnlLU0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZjM1J5YVc1blgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYM04wY21sdVoxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZbmwwWlhNb2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5aWVYUmxjem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk5UVXROVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQXZMeUIyWVd4cFpHRjBaVjlpZVhSbGN5aDJZV3gxWlRvZ1lYSmpOQzVFZVc1aGJXbGpRbmwwWlhNcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5aWVYUmxjMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5aWVYUmxjMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z2RtRnNhV1JoZEdWRmJtTnZaR2x1WnloMllXeDFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWVdSa2NtVnpjeWgyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMkZrWkhKbGMzTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pVNUxUWXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ0x5OGdkbUZzYVdSaGRHVmZZV1JrY21WemN5aDJZV3gxWlRvZ1lYSmpOQzVCWkdSeVpYTnpLU0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZV1JrY21WemMxOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjloWkdSeVpYTnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCMllXeHBaR0YwWlVWdVkyOWthVzVuS0haaGJIVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZV05qYjNWdWRDaDJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyRmpZMjkxYm5RNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPall6TFRZMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCMllXeHBaR0YwWlVWdVkyOWthVzVuT2lBbmRXNXpZV1psTFdScGMyRmliR1ZrSnlCOUtRb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWZllXTmpiM1Z1ZENoMllXeDFaVG9nUVdOamIzVnVkQ2tnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMkZqWTI5MWJuUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWVdOamIzVnVkRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWRmJtTnZaR2x1WnloMllXeDFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMkp2YjJ4ZllYSnlLSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZbTl2YkY5aGNuSTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pZM0xUWTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bk9pQW5kVzV6WVdabExXUnBjMkZpYkdWa0p5QjlLUW9nSUNBZ0x5OGdkbUZzYVdSaGRHVmZZbTl2YkY5aGNuSW9kbUZzZFdVNklHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVBHRnlZelF1UW05dmJENHBJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWliMjlzWDJGeWNsOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlpYjI5c1gyRnljbDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWRmJtTnZaR2x1WnloMllXeDFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURjS0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTHdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNWliMjlzUGdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlltOXZiRjloY25JektIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlltOXZiRjloY25Jek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem8zTVMwM01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUM4dklIWmhiR2xrWVhSbFgySnZiMnhmWVhKeU15aDJZV3gxWlRvZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVR4aGNtTTBMa0p2YjJ3c0lETStLU0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZbTl2YkY5aGNuSXpYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJKdmIyeGZZWEp5TTE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdkbUZzYVdSaGRHVkZibU52WkdsdVp5aDJZV3gxWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzVpYjI5c0xDQXpQZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYzNSaGRHbGpYM1IxY0d4bEtIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmMzUmhkR2xqWDNSMWNHeGxPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvM05TMDNOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lDOHZJSFpoYkdsa1lYUmxYM04wWVhScFkxOTBkWEJzWlNoMllXeDFaVG9nUVZKRE5GTjBZWFJwWTFSMWNHeGxLU0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZjM1JoZEdsalgzUjFjR3hsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgzTjBZWFJwWTE5MGRYQnNaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z2RtRnNhV1JoZEdWRmJtTnZaR2x1WnloMllXeDFaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwTmpRc1lYSmpOQzUxYVc1ME9ENEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZkSFZ3YkdVb2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5a2VXNWhiV2xqWDNSMWNHeGxPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvM09TMDRNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lDOHZJSFpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZkSFZ3YkdVb2RtRnNkV1U2SUVGU1F6UkVlVzVoYldsalZIVndiR1VwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM1IxY0d4bFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZkSFZ3YkdWZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJSFpoYkdsa1lYUmxSVzVqYjJScGJtY29kbUZzZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeUlHOW1JQ2gxYVc1ME5qUXNkV2x1ZERnc0tHeGxiaXQxZEdZNFcxMHBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ2FXNTBZMTh6SUM4dklERXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MGRYQnNaVHhoY21NMExuVnBiblEyTkN4aGNtTTBMblZwYm5RNExHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQajRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUW9kbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOXpkR0YwYVdOZmMzUnlkV04wT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzRNeTA0TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJQzh2SUhaaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUW9kbUZzZFdVNklFRlNRelJUZEdGMGFXTlRkSEoxWTNRcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUhaaGJHbGtZWFJsUlc1amIyUnBibWNvZG1Gc2RXVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQkJVa00wVTNSaGRHbGpVM1J5ZFdOMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZENoMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNE55MDRPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lDOHZJSFpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMEtIWmhiSFZsT2lCQlVrTTBSSGx1WVcxcFkxTjBjblZqZENrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCMllXeHBaR0YwWlVWdVkyOWthVzVuS0haaGJIVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNaUJ2WmlBb2RXbHVkRFkwTEhWcGJuUTRMQ2hzWlc0cmRYUm1PRnRkS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk15QXZMeUF4TVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUVGU1F6UkVlVzVoYldsalUzUnlkV04wQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2loMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzVNUzA1TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJQzh2SUhaaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5S0haaGJIVmxPaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlVHhCVWtNMFUzUmhkR2xqVTNSeWRXTjBQaWtnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bktIWmhiSFZsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeEJVa00wVTNSaGRHbGpVM1J5ZFdOMFBnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSXpLSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZjM1JoZEdsalgzTjBjblZqZEY5aGNuSXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNU5TMDVOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lDOHZJSFpoYkdsa1lYUmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlNeWgyWVd4MVpUb2dZWEpqTkM1VGRHRjBhV05CY25KaGVUeEJVa00wVTNSaGRHbGpVM1J5ZFdOMExDQXpQaWtnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlNMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2pOZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJSFpoYkdsa1lYUmxSVzVqYjJScGJtY29kbUZzZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFFWSkRORk4wWVhScFkxTjBjblZqZEN3Z016NEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljaWgyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9Ua3RNVEF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5S0haaGJIVmxPaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlVHhCVWtNMFJIbHVZVzFwWTFOMGNuVmpkRDRwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkpmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljbDltYjNKZmFHVmhaR1Z5UURFS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljbDltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5WDJGbWRHVnlYMlp2Y2tBMENpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOW1iM0pmWW05a2VVQXlDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25KZlptOXlYMkp2WkhsQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCMllXeHBaR0YwWlVWdVkyOWthVzVuS0haaGJIVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1ptOXlJQ2hzWlc0cktIVnBiblEyTkN4MWFXNTBPQ3dvYkdWdUszVjBaamhiWFNrcFcxMHBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXlJRzltSUNoMWFXNTBOalFzZFdsdWREZ3NLR3hsYml0MWRHWTRXMTBwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYek1nTHk4Z01URUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkpmWm05eVgyWnZiM1JsY2tBekNncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkpmWm05eVgyWnZiM1JsY2tBek9nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlYMlp2Y2w5b1pXRmtaWEpBTVFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hNREVLSUNBZ0lDOHZJSFpoYkdsa1lYUmxSVzVqYjJScGJtY29kbUZzZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4UVZKRE5FUjVibUZ0YVdOVGRISjFZM1ErQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25JektIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TVRBekxURXdOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lDOHZJSFpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak1vZG1Gc2RXVTZJR0Z5WXpRdVUzUmhkR2xqUVhKeVlYazhRVkpETkVSNWJtRnRhV05UZEhKMVkzUXNJRE0rS1NCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5TTE5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2RtRnNhV1JoZEdWRmJtTnZaR2x1WnloMllXeDFaU2tLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWm05eVgyaGxZV1JsY2tBeENncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkl6WDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCMllXeHBaR0YwWlVWdVkyOWthVzVuS0haaGJIVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5TTE5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpYMlp2Y2w5aWIyUjVRRElLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNqTmZabTl5WDJKdlpIbEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bktIWmhiSFZsS1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQm1iM0lnS0hWcGJuUTJOQ3gxYVc1ME9Dd29iR1Z1SzNWMFpqaGJYU2twV3pOZENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBNUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTWlCdlppQW9kV2x1ZERZMExIVnBiblE0TENoc1pXNHJkWFJtT0Z0ZEtTa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdhVzUwWTE4eklDOHZJREV4Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeU0xOW1iM0pmWm05dmRHVnlRRE1LQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNqTmZabTl5WDJadmIzUmxja0F6T2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZlpIbHVZVzFwWTE5emRISjFZM1JmWVhKeU0xOW1iM0pmYUdWaFpHVnlRREVLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNqTmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qRXdOUW9nSUNBZ0x5OGdkbUZzYVdSaGRHVkZibU52WkdsdVp5aDJZV3gxWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFFWSkRORVI1Ym1GdGFXTlRkSEoxWTNRc0lETStDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjlrZVc1aGJXbGpYM04wY25WamRGOTNhWFJvWDJGZlltOXZiQ2gyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgzZHBkR2hmWVY5aWIyOXNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pveE1EY3RNVEE0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZkMmwwYUY5aFgySnZiMndvZG1Gc2RXVTZJRmRwZEdoQlFtOXZiQ2tnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgzZHBkR2hmWVY5aWIyOXNYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDJSNWJtRnRhV05mYzNSeWRXTjBYM2RwZEdoZllWOWliMjlzWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdkbUZzYVdSaGRHVkZibU52WkdsdVp5aDJZV3gxWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTVNCdlppQW9kV2x1ZERnc0tHeGxiaXQxYVc1ME9GdGRLU3hpYjI5c01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZkcGRHaEJRbTl2YkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUW9kbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOXVZWFJwZG1WZmMzUmhkR2xqWDNOMGNuVmpkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1URXhMVEV4TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJQzh2SUhaaGJHbGtZWFJsWDI1aGRHbDJaVjl6ZEdGMGFXTmZjM1J5ZFdOMEtIWmhiSFZsT2lCT1lYUnBkbVZUZEdGMGFXTlRkSEoxWTNRcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjl1WVhScGRtVmZjM1JoZEdsalgzTjBjblZqZEY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hNVE1LSUNBZ0lDOHZJSFpoYkdsa1lYUmxSVzVqYjJScGJtY29kbUZzZFdVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBPWVhScGRtVlRkR0YwYVdOVGRISjFZM1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRDaDJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1URTFMVEV4TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJQzh2SUhaaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRDaDJZV3gxWlRvZ1RtRjBhWFpsUkhsdVlXMXBZMU4wY25WamRDa2dld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TVRFM0NpQWdJQ0F2THlCMllXeHBaR0YwWlVWdVkyOWthVzVuS0haaGJIVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNaUJ2WmlBb2RXbHVkRFkwTEhWcGJuUTRMQ2hzWlc0cmRYUm1PRnRkS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk15QXZMeUF4TVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPazVoZEdsMlpVUjVibUZ0YVdOVGRISjFZM1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDI1aGRHbDJaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgyRnljaWgyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMjVoZEdsMlpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNqb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02TVRFNUxURXlNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2dkbUZzYVdSaGRHVkZibU52WkdsdVp6b2dKM1Z1YzJGbVpTMWthWE5oWW14bFpDY2dmU2tLSUNBZ0lDOHZJSFpoYkdsa1lYUmxYMjVoZEdsMlpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNpaDJZV3gxWlRvZ1FYSnlZWGs4VG1GMGFYWmxVM1JoZEdsalUzUnlkV04wUGlrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDI1aGRHbDJaVjl6ZEdGMGFXTmZjM1J5ZFdOMFgyRnljbDlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmYzNSaGRHbGpYM04wY25WamRGOWhjbkpmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1USXhDaUFnSUNBdkx5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bktIWmhiSFZsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwT1lYUnBkbVZUZEdGMGFXTlRkSEoxWTNRK0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOXVZWFJwZG1WZmMzUmhkR2xqWDNOMGNuVmpkRjloY25JektIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmJtRjBhWFpsWDNOMFlYUnBZMTl6ZEhKMVkzUmZZWEp5TXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZNVEl6TFRFeU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2RtRnNhV1JoZEdWRmJtTnZaR2x1WnpvZ0ozVnVjMkZtWlMxa2FYTmhZbXhsWkNjZ2ZTa0tJQ0FnSUM4dklIWmhiR2xrWVhSbFgyNWhkR2wyWlY5emRHRjBhV05mYzNSeWRXTjBYMkZ5Y2pNb2RtRnNkV1U2SUVacGVHVmtRWEp5WVhrOFRtRjBhWFpsVTNSaGRHbGpVM1J5ZFdOMExDQXpQaWtnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMjVoZEdsMlpWOXpkR0YwYVdOZmMzUnlkV04wWDJGeWNqTmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYM04wWVhScFkxOXpkSEoxWTNSZllYSnlNMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pveE1qVUtJQ0FnSUM4dklIWmhiR2xrWVhSbFJXNWpiMlJwYm1jb2RtRnNkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU53b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4ZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZUbUYwYVhabFUzUmhkR2xqVTNSeWRXTjBMQ0F6UGdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmJtRjBhWFpsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2loMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qRXlOeTB4TWpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhaaGJHbGtZWFJsUlc1amIyUnBibWM2SUNkMWJuTmhabVV0WkdsellXSnNaV1FuSUgwcENpQWdJQ0F2THlCMllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5S0haaGJIVmxPaUJPWVhScGRtVkVlVzVoYldsalUzUnlkV04wVzEwcElIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25KZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZNVEk1Q2lBZ0lDQXZMeUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5LSFpoYkhWbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOW1iM0pmYUdWaFpHVnlRREVLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25KZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pveE1qa0tJQ0FnSUM4dklIWmhiR2xrWVhSbFJXNWpiMlJwYm1jb2RtRnNkV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25KZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOW1iM0pmWW05a2VVQXlDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcEJZbWxXWVd4cFpHRjBhVzl1Ulhob1lYVnpkR2wyWlM1MllXeHBaR0YwWlY5dVlYUnBkbVZmWkhsdVlXMXBZMTl6ZEhKMVkzUmZZWEp5WDJadmNsOWliMlI1UURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV5T1FvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdadmNpQW9iR1Z1S3loMWFXNTBOalFzZFdsdWREZ3NLR3hsYml0MWRHWTRXMTBwS1Z0ZEtRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTVDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01URUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01pQnZaaUFvZFdsdWREWTBMSFZwYm5RNExDaHNaVzRyZFhSbU9GdGRLU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYVc1MFkxOHpJQzh2SURFeENpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNsOW1iM0pmWm05dmRHVnlRRE1LQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25KZlptOXlYMlp2YjNSbGNrQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljbDltYjNKZmFHVmhaR1Z5UURFS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdkbUZzYVdSaGRHVkZibU52WkdsdVp5aDJZV3gxWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qcE9ZWFJwZG1WRWVXNWhiV2xqVTNSeWRXTjBQZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak1vZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1UTXhMVEV6TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaem9nSjNWdWMyRm1aUzFrYVhOaFlteGxaQ2NnZlNrS0lDQWdJQzh2SUhaaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkl6S0haaGJIVmxPaUJHYVhobFpFRnljbUY1UEU1aGRHbDJaVVI1Ym1GdGFXTlRkSEoxWTNRc0lETStLU0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZibUYwYVhabFgyUjVibUZ0YVdOZmMzUnlkV04wWDJGeWNqTmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk1UTXpDaUFnSUNBdkx5QjJZV3hwWkdGMFpVVnVZMjlrYVc1bktIWmhiSFZsS1FvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWm05eVgyaGxZV1JsY2tBeENncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNMTltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV6TXdvZ0lDQWdMeThnZG1Gc2FXUmhkR1ZGYm1OdlpHbHVaeWgyWVd4MVpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpYMkZtZEdWeVgyWnZja0EwQ2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTG5aaGJHbGtZWFJsWDI1aGRHbDJaVjlrZVc1aGJXbGpYM04wY25WamRGOWhjbkl6WDJadmNsOWliMlI1UURJS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RkbUZzYVdSaGRHbHZiaTFsZUdoaGRYTjBhWFpsTG1Gc1oyOHVkSE02T2tGaWFWWmhiR2xrWVhScGIyNUZlR2hoZFhOMGFYWmxMblpoYkdsa1lYUmxYMjVoZEdsMlpWOWtlVzVoYldsalgzTjBjblZqZEY5aGNuSXpYMlp2Y2w5aWIyUjVRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFhaaGJHbGtZWFJwYjI0dFpYaG9ZWFZ6ZEdsMlpTNWhiR2R2TG5Sek9qRXpNd29nSUNBZ0x5OGdkbUZzYVdSaGRHVkZibU52WkdsdVp5aDJZV3gxWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoMWFXNTBOalFzZFdsdWREZ3NLR3hsYml0MWRHWTRXMTBwS1ZzelhRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURJZ2IyWWdLSFZwYm5RMk5DeDFhVzUwT0N3b2JHVnVLM1YwWmpoYlhTa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk15QXZMeUF4TVFvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyNWhkR2wyWlY5a2VXNWhiV2xqWDNOMGNuVmpkRjloY25JelgyWnZjbDltYjI5MFpYSkFNd29LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZmJtRjBhWFpsWDJSNWJtRnRhV05mYzNSeWRXTjBYMkZ5Y2pOZlptOXlYMlp2YjNSbGNrQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmYm1GMGFYWmxYMlI1Ym1GdGFXTmZjM1J5ZFdOMFgyRnljak5mWm05eVgyaGxZV1JsY2tBeENncDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwQlltbFdZV3hwWkdGMGFXOXVSWGhvWVhWemRHbDJaUzUyWVd4cFpHRjBaVjl1WVhScGRtVmZaSGx1WVcxcFkxOXpkSEoxWTNSZllYSnlNMTloWm5SbGNsOW1iM0pBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZNVE16Q2lBZ0lDQXZMeUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5LSFpoYkhWbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeDBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pwT1lYUnBkbVZFZVc1aGJXbGpVM1J5ZFdOMExDQXpQZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWXpKaktDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pvNlFXSnBWbUZzYVdSaGRHbHZia1Y0YUdGMWMzUnBkbVV1ZG1Gc2FXUmhkR1ZmWXpKak9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWpNbU5mWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZll6SmpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXSnBMWFpoYkdsa1lYUnBiMjR0Wlhob1lYVnpkR2wyWlM1aGJHZHZMblJ6T2pFek9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWVhCd0lEMGdZMjl0Y0dsc1pXUXVZMkZzYkM1amNtVmhkR1VvZTMwcExtbDBlRzR1WTNKbFlYUmxaRUZ3Y0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzEyWVd4cFpHRjBhVzl1TFdWNGFHRjFjM1JwZG1VdVlXeG5ieTUwY3pveE16Y0tJQ0FnSUM4dklHTnZibk4wSUdOdmJYQnBiR1ZrSUQwZ1kyOXRjR2xzWlVGeVl6UW9TVzUyWVd4cFpFTnZiblJ5WVdOMEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUlhoMGNtRlFjbTluY21GdFVHRm5aWE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFeHZZMkZzVG5WdFZXbHVkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1RHOWpZV3hPZFcxQ2VYUmxVMnhwWTJVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRWRzYjJKaGJFNTFiVUo1ZEdWVGJHbGpaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1IyeHZZbUZzVG5WdFZXbHVkQW9nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlUyTkNoRE1FbEJRVWxGUWxGM1BUMHBDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNaV0Z5VTNSaGRHVlFjbTluY21GdFVHRm5aWE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRZMEtFTjVRVU5CUVVaRFFVRkNRMEZCUVhoSFUwbFRVa1JGV1Vsb1RrSkJRamxEUVVGQk1rZG5RMEZDUlZoUVFtVTVVRUZaTkVKQlFXUkRRVUZDUTBGQlFVRnBRVUZ0VVhZdk1rNW9iMEZuUVZKTldFZEhObFIzUjA5QlVVRkhVV2RCUVZGMkwydHBRVUZFVVhZdk0xRm5RVUZwUVVGVlNUQk9RMEZCUTBsQlFrTkJRa0pWWm1aSVZsQkJWa04zU1RCT1EwRkJRMHBSWjBGQlowRmtjR0p1V21oaVIyeHJhVkU5UFNrS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2NtOTJZV3hRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCeWIzWmhiRkJ5YjJkeVlXMVFZV2RsY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hNemtLSUNBZ0lDOHZJR052Ym5OMElHRndjQ0E5SUdOdmJYQnBiR1ZrTG1OaGJHd3VZM0psWVhSbEtIdDlLUzVwZEhodUxtTnlaV0YwWldSQmNIQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5HTTFZell4WW1FZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb0tYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPanBCWW1sV1lXeHBaR0YwYVc5dVJYaG9ZWFZ6ZEdsMlpTNTJZV3hwWkdGMFpWOWpNbU5mYm1WNGRGOTBlRzVBTVFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMTJZV3hwWkdGMGFXOXVMV1Y0YUdGMWMzUnBkbVV1WVd4bmJ5NTBjem82UVdKcFZtRnNhV1JoZEdsdmJrVjRhR0YxYzNScGRtVXVkbUZzYVdSaGRHVmZZekpqWDI1bGVIUmZkSGh1UURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdKcExYWmhiR2xrWVhScGIyNHRaWGhvWVhWemRHbDJaUzVoYkdkdkxuUnpPakV6T1FvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3SUQwZ1kyOXRjR2xzWldRdVkyRnNiQzVqY21WaGRHVW9lMzBwTG1sMGVHNHVZM0psWVhSbFpFRndjQW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdkcGRIaHVJREFnUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZNVFF4TFRFME5Bb2dJQ0FnTHk4Z1lXSnBRMkZzYkNoN0NpQWdJQ0F2THlBZ0lHMWxkR2h2WkRvZ1NXNTJZV3hwWkVOdmJuUnlZV04wTG5CeWIzUnZkSGx3WlM1cGJuWmhiR2xrVm1Gc2RXVXNDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQmhjSEFzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTldObU1EVmxaaUF2THlCdFpYUm9iMlFnSW1sdWRtRnNhV1JXWVd4MVpTZ3BkV2x1ZERZMFd6TmRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6bzZRV0pwVm1Gc2FXUmhkR2x2YmtWNGFHRjFjM1JwZG1VdWRtRnNhV1JoZEdWZll6SmpYMjVsZUhSZmRIaHVRRElLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdGRtRnNhV1JoZEdsdmJpMWxlR2hoZFhOMGFYWmxMbUZzWjI4dWRITTZPa0ZpYVZaaGJHbGtZWFJwYjI1RmVHaGhkWE4wYVhabExuWmhiR2xrWVhSbFgyTXlZMTl1WlhoMFgzUjRia0F5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxMllXeHBaR0YwYVc5dUxXVjRhR0YxYzNScGRtVXVZV3huYnk1MGN6b3hOREV0TVRRMENpQWdJQ0F2THlCaFltbERZV3hzS0hzS0lDQWdJQzh2SUNBZ2JXVjBhRzlrT2lCSmJuWmhiR2xrUTI5dWRISmhZM1F1Y0hKdmRHOTBlWEJsTG1sdWRtRnNhV1JXWVd4MVpTd0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHRndjQ3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JqYjNabGNpQXhDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RMk5Dd2dNejRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0ZG1Gc2FXUmhkR2x2YmkxbGVHaGhkWE4wYVhabExtRnNaMjh1ZEhNNk9rRmlhVlpoYkdsa1lYUnBiMjVGZUdoaGRYTjBhWFpsTGw5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaU2dwSUMwK0lIWnZhV1E2Q2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVG9LSUNBZ0lHSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBS0NsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDQzBJQUFFSUFBREViSXhOQkFjcENBQUF4R1NNU1JERVlJeE5CQWJoQ0FBQTJHZ0NBQkUxMWpGbUFCR3UzdVdPQUJCaUZMTmFBQkZzdSsrR0FCT3pLZXBpQUJKVGFjOENBQkNZakRlR0FCRDdIZjZ5QUJQRVJ3SDZBQkQ5b3Q5R0FCR2RNRG9lQUJBa2F1RWlBQlBNb243aUFCSkdzN2xHQUJFNWtIcG1BQkdVMjQ4S0FCSk5TTExpQUJMK0lpQ1dBQkNLcWtOYUFCRzdzdEoyQUJDZzRpQ21BQkg2QVM3K0FCTTRteHl5QUJPeFdFbStBQk1OblMxYUFCUHQ3QlNpQUJMcFJsZjJBQk9Ock1pU0FCRmRPbEhtQUJOQzFndkZQSG80ZUFMZ0FzZ0NzQUtZQW9BQ2FBSlFBamdDSUFJSUFmQUIyQUhBQWFnQmtBRjRBV0FCU0FFd0FSZ0JBQURvQU5BQXVBQ2dBSWdBY0FCWUFFQUFLUWdBQVFnQUFRZ0FBQUlnQ0FrTC84NGdCOFVMLzdZZ0I0RUwvNTRnQnowTC80WWdCdmtMLzI0Z0JyVUwvMVlnQm5FTC96NGdCaTBML3lZZ0Jla0wvdzRnQmFVTC92WWdCV0VML3Q0Z0JSMEwvc1lnQk5rTC9xNGdCSlVML3BZZ0JGRUwvbjRnQkEwTC9tWWdBOGtML2s0Z0E0VUwvallnQTBFTC9oNGdBdjBML2dZZ0Fya0wvZTRnQW5VTC9kWWdBakVML2I0Z0FlMEwvYVlnQWFrTC9ZNGdBV1VML1hZZ0FTRUwvVjRnQU4wTC9VWWdBSmtML1M0Z0FGVUwvUlVML1JURVpJeEl4R0NNU0VFU0lCZEFpUTBJQUFEWWFBWWdCUGlKRFFnQUFOaG9CaUFGQklrTkNBQUEyR2dHSUFVTWlRMElBQURZYUFZZ0JSaUpEUWdBQU5ob0JpQUZKSWtOQ0FBQTJHZ0dJQVZJaVEwSUFBRFlhQVlnQlZTSkRRZ0FBTmhvQmlBRlhJa05DQUFBMkdnR0lBVmtpUTBJQUFEWWFBWWdCWWlKRFFnQUFOaG9CaUFGcklrTkNBQUEyR2dHSUFXNGlRMElBQURZYUFZZ0JjU0pEUWdBQU5ob0JpQUdBSWtOQ0FBQTJHZ0dJQVlJaVEwSUFBRFlhQVlnQmhTSkRRZ0FBTmhvQmlBR2hJa05DQUFBMkdnR0lBYVFpUTBJQUFEWWFBWWdCd0NKRFFnQUFOaG9CaUFIS0lrTkNBQUEyR2dHSUFjMGlRMElBQURZYUFZZ0NOeUpEUWdBQU5ob0JpQUtPSWtOQ0FBQTJHZ0dJQXFzaVEwSUFBRFlhQVlnQ3JpSkRRZ0FBTmhvQmlBTEtJa05DQUFBMkdnR0lBdFFpUTBJQUFEWWFBWWdDMXlKRFFnQUFOaG9CaUFOQklrTkNBQUNJQTVzaVE0b0JBRUlBQUl2L0ZZRUlFa1NKaWdFQVFnQUFpLzhWSWhKRWlZb0JBRUlBQUl2L0ZZRkFFa1NKaWdFQVFnQUFpLzhWZ1FnU1JJbUtBUUJDQUFDTC95TlpJZ3NrQ0l2L0ZSSkVpWW9CQUVJQUFJdi9GWUVERWtTSmlnRUFRZ0FBaS84VkloSkVpWW9CQUVJQUFJdi9GU0lTUkltS0FRQkNBQUNML3lOWklnc2tDSXYvRlJKRWlZb0JBRUlBQUl2L0kxa2lDeVFJaS84VkVrU0ppZ0VBUWdBQWkvOFZnU0FTUkltS0FRQkNBQUNML3hXQklCSkVpWW9CQUVJQUFJdi9JMWtpQzRFSENJRUlDaVFJaS84VkVrU0ppZ0VBUWdBQWkvOFZJaEpFaVlvQkFFSUFBSXYvRllFSkVrU0ppZ0VBUWdBQWkvOFZpLytCQ1ZsSkpSSkVpLzlQQVU4Q1VpTlpJZ3NrQ0NVSWkvOFZFa1NKaWdFQVFnQUFpLzhWZ1FrU1JJbUtBUUJDQUFDTC94V0wvNEVKV1VrbEVrU0wvMDhCVHdKU0kxa2lDeVFJSlFpTC94VVNSSW1LQVFCQ0FBQ0wveU5aZ1FrTEpBaUwveFVTUkltS0FRQkNBQUNML3hXQkd4SkVpWW9CQUVJQUFJdi9JMWxKSkF1TC94V0wveVJQQWxJalFnQUFpd09MQUF4QkFFbENBQUNMQXlRTGl3SkpUZ0pQQVZsSml3RkpUZ1FTUkVzQkZVNEJUd0pQQVU4Q1Vra1ZUZ0ZKZ1FsWlNTVVNSRThDVWlOWklnc2tDQ1VJQ0l3QlFnQUFpd01pQ0l3RFF2K3Zpd0VrQ0l2L0ZSSkVpWW9CQUVJQUFJRURKQXNqUWdBQWl3R0JBd3hCQUVSQ0FBQ0xBU1FMaS85UEFWbEppd0JKVGdNU1JJdi9GWXYvVHdKUEFsSkpGVTRCU1lFSldVa2xFa1JQQWxJaldTSUxKQWdsQ0FpTUFFSUFBSXNCSWdpTUFVTC90SXYvRllzQUVrU0ppZ0VBUWdBQWkvOFZpLzhpV1VtQkJCSkVpLzlQQVU4Q1VpTlpJZ3NrQ0lFRUNJdi9GUkpFaVlvQkFFSUFBSXYvRllFSkVrU0ppZ0VBUWdBQWkvOFZpLytCQ1ZsSkpSSkVpLzlQQVU4Q1VpTlpJZ3NrQ0NVSWkvOFZFa1NKaWdFQVFnQUFpLzhqV1lFSkN5UUlpLzhWRWtTSmlnRUFRZ0FBaS84VmdSc1NSSW1LQVFCQ0FBQ0wveU5aU1NRTGkvOFZpLzhrVHdKU0kwSUFBSXNEaXdBTVFRQkpRZ0FBaXdNa0M0c0NTVTRDVHdGWlNZc0JTVTRFRWtSTEFSVk9BVThDVHdGUEFsSkpGVTRCU1lFSldVa2xFa1JQQWxJaldTSUxKQWdsQ0FpTUFVSUFBSXNESWdpTUEwTC9yNHNCSkFpTC94VVNSSW1LQVFCQ0FBQ0JBeVFMSTBJQUFJc0JnUU1NUVFCRVFnQUFpd0VrQzR2L1R3RlpTWXNBU1U0REVrU0wveFdMLzA4Q1R3SlNTUlZPQVVtQkNWbEpKUkpFVHdKU0kxa2lDeVFJSlFnSWpBQkNBQUNMQVNJSWpBRkMvN1NML3hXTEFCSkVpVUlBQUxFanNqZ2pzallqc2pjanNqVWpzalNBQnd0Q0FBQ0JBVU95UW9BQXNrS0FmQXNnQWdBQlFnQUFRZ0FBTVJraUVrUXhHQ0lUUVFBZlFnQUFOaG9BZ0FSRnp3WHZUd0dPQVFBSFFnQUFRZ0FBQUlnQUprTC85allhQUlBRVRGeGh1azhCamdFQUJrSUFBRUwvNUlnQUEwTC85MElBQUlnQUZDTkRRZ0FBaUFBUWdBUVZIM3gxVHdGUXNDTkRRZ0FBaVVJQUFJQUhhVzUyWVd4cFpJbXlRSUFBc2tBanNobUFCRXhjWWJxeUdvRUdzaEFqc2dGQ0FBQ3p0d0E5c2JJWWdBUkZ6d1h2c2hxQkJySVFJN0lCUWdBQXM3UStTVmNFQUU0QlZ3QUVnQVFWSDN4MUVrUVZnUmdTUklsQ0FBQ0oiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
