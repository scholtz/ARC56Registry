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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.BoxStorage_d1bc697d
{


    public class BoxStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BoxStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class UserStruct : AVMObjectType
            {
                public string Name { get; set; }

                public ulong Id { get; set; }

                public ulong Asset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UserStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new UserStruct();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UserStruct);
                }
                public bool Equals(UserStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UserStruct left, UserStruct right)
                {
                    return EqualityComparer<UserStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(UserStruct left, UserStruct right)
                {
                    return !(left == right);
                }

            }

            public class MaybeBoxReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static MaybeBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MaybeBoxReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MaybeBoxReturn);
                }
                public bool Equals(MaybeBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MaybeBoxReturn left, MaybeBoxReturn right)
                {
                    return EqualityComparer<MaybeBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MaybeBoxReturn left, MaybeBoxReturn right)
                {
                    return !(left == right);
                }

            }

            public class MaybeBoxMapReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static MaybeBoxMapReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MaybeBoxMapReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MaybeBoxMapReturn);
                }
                public bool Equals(MaybeBoxMapReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MaybeBoxMapReturn left, MaybeBoxMapReturn right)
                {
                    return EqualityComparer<MaybeBoxMapReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MaybeBoxMapReturn left, MaybeBoxMapReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetBoxExampleReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public string Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
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

                public static GetBoxExampleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetBoxExampleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBoxExampleReturn);
                }
                public bool Equals(GetBoxExampleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBoxExampleReturn left, GetBoxExampleReturn right)
                {
                    return EqualityComparer<GetBoxExampleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBoxExampleReturn left, GetBoxExampleReturn right)
                {
                    return !(left == right);
                }

            }

            public class ExistBoxExampleReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static ExistBoxExampleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ExistBoxExampleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ExistBoxExampleReturn);
                }
                public bool Equals(ExistBoxExampleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ExistBoxExampleReturn left, ExistBoxExampleReturn right)
                {
                    return EqualityComparer<ExistBoxExampleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ExistBoxExampleReturn left, ExistBoxExampleReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 136, 185, 152 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 136, 185, 152 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<string> GetItemBoxMap(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 208, 251, 227 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetItemBoxMap_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 208, 251, 227 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> GetBoxMap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 242, 55, 40 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetBoxMap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 242, 55, 40 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.MaybeBoxReturn> MaybeBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 194, 121, 225 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MaybeBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MaybeBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 194, 121, 225 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.MaybeBoxMapReturn> MaybeBoxMap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 246, 105, 113 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MaybeBoxMapReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MaybeBoxMap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 246, 105, 113 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetBoxExampleReturn> GetBoxExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 111, 8, 158 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBoxExampleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBoxExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 111, 8, 158 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> GetBoxMapExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 128, 111, 107 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBoxMapExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 128, 111, 107 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task MaybeBoxExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 237, 52, 133 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MaybeBoxExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 237, 52, 133 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task MaybeBoxMapExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 226, 126, 175 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MaybeBoxMapExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 226, 126, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<Structs.UserStruct> GetBoxMapStruct(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 145, 21, 144 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.UserStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBoxMapStruct_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 145, 21, 144 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value_int"> </param>
        public async Task SetBox(ulong value_int, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 132, 172, 77 };
            var value_intAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_intAbi.From(value_int);

            var result = await base.CallApp(new List<object> { abiHandle, value_intAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBox_Transactions(ulong value_int, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 132, 172, 77 };
            var value_intAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_intAbi.From(value_int);

            return await base.MakeTransactionList(new List<object> { abiHandle, value_intAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetBoxMap(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 245, 182, 87 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBoxMap_Transactions(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 245, 182, 87 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> UserStruct</param>
        public async Task<bool> SetBoxMapStruct(ulong key, Structs.UserStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 141, 173, 224 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetBoxMapStruct_Transactions(ulong key, Structs.UserStruct value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 141, 173, 224 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value_int"> </param>
        /// <param name="value_dbytes"> </param>
        /// <param name="value_string"> </param>
        public async Task SetBoxExample(ulong value_int, byte[] value_dbytes, string value_string, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 195, 6, 62 };
            var value_intAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_intAbi.From(value_int);
            var value_dbytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); value_dbytesAbi.From(value_dbytes);
            var value_stringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); value_stringAbi.From(value_string);

            var result = await base.CallApp(new List<object> { abiHandle, value_intAbi, value_dbytesAbi, value_stringAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBoxExample_Transactions(ulong value_int, byte[] value_dbytes, string value_string, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 195, 6, 62 };
            var value_intAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); value_intAbi.From(value_int);
            var value_dbytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); value_dbytesAbi.From(value_dbytes);
            var value_stringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); value_stringAbi.From(value_string);

            return await base.MakeTransactionList(new List<object> { abiHandle, value_intAbi, value_dbytesAbi, value_stringAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 112, 133, 101 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 112, 133, 101 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task DeleteBoxMap(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 187, 112, 67 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxMap_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 187, 112, 67 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> BoxMapLength(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 176, 115, 78 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapLength_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 176, 115, 78 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> BoxMapStructLength(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 119, 137, 235 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapStructLength_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 119, 137, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task BoxMapLengthExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 229, 211, 244 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BoxMapLengthExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 229, 211, 244 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ExtractBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 5, 45, 106 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExtractBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 5, 45, 106 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ValueBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 223, 87, 252 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValueBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 223, 87, 252 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> ExistBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 97, 37, 185 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ExistBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 97, 37, 185 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ExistBoxExampleReturn> ExistBoxExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 172, 166, 255 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ExistBoxExampleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ExistBoxExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 172, 166, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task SliceBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 239, 73, 113 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SliceBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 239, 73, 113 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc4Box(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 236, 179, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc4Box_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 236, 179, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> KeyBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 209, 209, 249 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> KeyBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 209, 209, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task KeyBoxExample(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 162, 209, 192 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> KeyBoxExample_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 162, 209, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<bool> BoxMapExists(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 226, 195, 100 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapExists_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 226, 195, 100 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<bool> BoxMapStructExists(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 2, 8, 140 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapStructExists_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 2, 8, 140 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> KeyPrefixBoxMap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 248, 108, 142 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> KeyPrefixBoxMap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 248, 108, 142 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm94U3RvcmFnZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJVc2VyU3RydWN0IjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifV0sIk1heWJlQm94UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dLCJNYXliZUJveE1hcFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XSwiR2V0Qm94RXhhbXBsZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9XSwiRXhpc3RCb3hFeGFtcGxlUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldF9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfaXRlbV9ib3hfbWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ib3hfbWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWF5YmVfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJNYXliZUJveFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1heWJlX2JveF9tYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxib29sKSIsInN0cnVjdCI6Ik1heWJlQm94TWFwUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JveF9leGFtcGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYnl0ZVtdLHN0cmluZykiLCJzdHJ1Y3QiOiJHZXRCb3hFeGFtcGxlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JveF9tYXBfZXhhbXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXliZV9ib3hfZXhhbXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXliZV9ib3hfbWFwX2V4YW1wbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JveF9tYXBfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVXNlclN0cnVjdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVfaW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9ib3hfbWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2JveF9tYXBfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlVzZXJTdHJ1Y3QiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2JveF9leGFtcGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlX2ludCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVfZGJ5dGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZV9zdHJpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlX2JveCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfYm94X21hcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm94X21hcF9sZW5ndGgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hfbWFwX3N0cnVjdF9sZW5ndGgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm94X21hcF9sZW5ndGhfZXhhbXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleHRyYWN0X2JveCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWx1ZV9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhpc3RfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4aXN0X2JveF9leGFtcGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iihib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJFeGlzdEJveEV4YW1wbGVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzbGljZV9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNF9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoia2V5X2JveCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImtleV9ib3hfZXhhbXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hfbWFwX2V4aXN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm94X21hcF9zdHJ1Y3RfZXhpc3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJrZXlfcHJlZml4X2JveF9tYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwMl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNV0sImVycm9yTWVzc2FnZSI6ImJveCBzdHJpbmcga2V5IG9rIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ib3hfZHluYW1pY19ieXRlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzYsNDg5LDY5OCw5MDldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJveF9pbnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkxLDc4N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94X21hcCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJveF9tYXBfc3RydWN0IGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94X3N0cmluZyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ05ESWdNVEFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUp2ZUY5cGJuUWlJREI0TVRVeFpqZGpOelVnTUhnME1qUm1OVGcxWmpReklEQjRNREFnSW1JaUlDSmliRzlpSWlBaU1DSWdJbVJsWm1GMWJIUWlJREI0TVRVeFpqZGpOelU0TUNBaWRYTmxjbk1pSUNKaWIzaGZZbmwwWlhNaUlEQjRNREF3TWpNME16SWdNSGczTlRjek5qVTNNamN6TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZURZNE5qVTJZelpqTm1ZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lOQW9nSUNBZ0x5OGdZMnhoYzNNZ1FtOTRVM1J2Y21GblpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU16a0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROVGc0T0dJNU9UZ2dNSGd4T0dRd1ptSmxNeUF3ZUROaFpqSXpOekk0SURCNE5HWmpNamM1WlRFZ01IZzVaV1kyTmprM01TQXdlRFJsTm1Zd09EbGxJREI0TVRJNE1EWm1ObUlnTUhnM05XVmtNelE0TlNBd2VEVTRaVEkzWldGbUlEQjRZV1k1TVRFMU9UQWdNSGhoWlRnMFlXTTBaQ0F3ZUdWbVpqVmlOalUzSURCNE1XSTRaR0ZrWlRBZ01IZzJOV016TURZelpTQXdlRGd5TnpBNE5UWTFJREI0TkRkaVlqY3dORE1nTUhnM09HSXdOek0wWlNBd2VHUTJOemM0T1dWaUlEQjRPVFJsTldRelpqUWdNSGhpWkRBMU1tUTJZU0F3ZURjNVpHWTFOMlpqSURCNFpqYzJNVEkxWWprZ01IZ3lNV0ZqWVRabVppQXdlREEwWldZME9UY3hJREI0TWpObFkySXpNbU1nTUhobFkyUXhaREZtT1NBd2VEZG1ZVEprTVdNd0lEQjRPR1ZsTW1Nek5qUWdNSGc1T0RBeU1EZzRZeUF3ZURNMlpqZzJZemhsSUM4dklHMWxkR2h2WkNBaVoyVjBYMkp2ZUNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZhWFJsYlY5aWIzaGZiV0Z3S0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEY5aWIzaGZiV0Z3S0NsemRISnBibWNpTENCdFpYUm9iMlFnSW0xaGVXSmxYMkp2ZUNncEtIVnBiblEyTkN4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpYldGNVltVmZZbTk0WDIxaGNDZ3BLSE4wY21sdVp5eGliMjlzS1NJc0lHMWxkR2h2WkNBaVoyVjBYMkp2ZUY5bGVHRnRjR3hsS0Nrb2RXbHVkRFkwTEdKNWRHVmJYU3h6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0puWlhSZlltOTRYMjFoY0Y5bGVHRnRjR3hsS0NsaWIyOXNJaXdnYldWMGFHOWtJQ0p0WVhsaVpWOWliM2hmWlhoaGJYQnNaU2dwZG05cFpDSXNJRzFsZEdodlpDQWliV0Y1WW1WZlltOTRYMjFoY0Y5bGVHRnRjR3hsS0NsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZlltOTRYMjFoY0Y5emRISjFZM1FvZFdsdWREWTBLU2h6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luTmxkRjlpYjNnb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5aWIzaGZiV0Z3S0hWcGJuUTJOQ3h6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYMkp2ZUY5dFlYQmZjM1J5ZFdOMEtIVnBiblEyTkN3b2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luTmxkRjlpYjNoZlpYaGhiWEJzWlNoMWFXNTBOalFzWW5sMFpWdGRMSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pXeGxkR1ZmWW05NEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pXeGxkR1ZmWW05NFgyMWhjQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVltOTRYMjFoY0Y5c1pXNW5kR2dvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWW05NFgyMWhjRjl6ZEhKMVkzUmZiR1Z1WjNSb0tDbGliMjlzSWl3Z2JXVjBhRzlrSUNKaWIzaGZiV0Z3WDJ4bGJtZDBhRjlsZUdGdGNHeGxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmxlSFJ5WVdOMFgySnZlQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlkbUZzZFdWZlltOTRLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmxlR2x6ZEY5aWIzZ29LV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltVjRhWE4wWDJKdmVGOWxlR0Z0Y0d4bEtDa29ZbTl2YkN4aWIyOXNMR0p2YjJ3cElpd2diV1YwYUc5a0lDSnpiR2xqWlY5aWIzZ29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnlZelJmWW05NEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKclpYbGZZbTk0S0NsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW10bGVWOWliM2hmWlhoaGJYQnNaU2dwZG05cFpDSXNJRzFsZEdodlpDQWlZbTk0WDIxaGNGOWxlR2x6ZEhNb2RXbHVkRFkwS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbUp2ZUY5dFlYQmZjM1J5ZFdOMFgyVjRhWE4wY3loMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlhMlY1WDNCeVpXWnBlRjlpYjNoZmJXRndLQ2xpZVhSbFcxMGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JuWlhSZlltOTRJR2RsZEY5cGRHVnRYMkp2ZUY5dFlYQWdaMlYwWDJKdmVGOXRZWEFnYldGNVltVmZZbTk0SUcxaGVXSmxYMkp2ZUY5dFlYQWdaMlYwWDJKdmVGOWxlR0Z0Y0d4bElHZGxkRjlpYjNoZmJXRndYMlY0WVcxd2JHVWdiV0Y1WW1WZlltOTRYMlY0WVcxd2JHVWdiV0Y1WW1WZlltOTRYMjFoY0Y5bGVHRnRjR3hsSUdkbGRGOWliM2hmYldGd1gzTjBjblZqZENCelpYUmZZbTk0SUhObGRGOWliM2hmYldGd0lITmxkRjlpYjNoZmJXRndYM04wY25WamRDQnpaWFJmWW05NFgyVjRZVzF3YkdVZ1pHVnNaWFJsWDJKdmVDQmtaV3hsZEdWZlltOTRYMjFoY0NCaWIzaGZiV0Z3WDJ4bGJtZDBhQ0JpYjNoZmJXRndYM04wY25WamRGOXNaVzVuZEdnZ1ltOTRYMjFoY0Y5c1pXNW5kR2hmWlhoaGJYQnNaU0JsZUhSeVlXTjBYMkp2ZUNCMllXeDFaVjlpYjNnZ1pYaHBjM1JmWW05NElHVjRhWE4wWDJKdmVGOWxlR0Z0Y0d4bElITnNhV05sWDJKdmVDQnRZV2x1WDJGeVl6UmZZbTk0WDNKdmRYUmxRRE13SUcxaGFXNWZhMlY1WDJKdmVGOXliM1YwWlVBek1TQnRZV2x1WDJ0bGVWOWliM2hmWlhoaGJYQnNaVjl5YjNWMFpVQXpNaUJpYjNoZmJXRndYMlY0YVhOMGN5QmliM2hmYldGd1gzTjBjblZqZEY5bGVHbHpkSE1nYldGcGJsOXJaWGxmY0hKbFptbDRYMkp2ZUY5dFlYQmZjbTkxZEdWQU16VUtJQ0FnSUdWeWNnb0tiV0ZwYmw5clpYbGZjSEpsWm1sNFgySnZlRjl0WVhCZmNtOTFkR1ZBTXpVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNalkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgydGxlVjlpYjNoZlpYaGhiWEJzWlY5eWIzVjBaVUF6TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWlhKeUlDOHZJR0p2ZUNCemRISnBibWNnYTJWNUlHOXJDZ3B0WVdsdVgydGxlVjlpYjNoZmNtOTFkR1ZBTXpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdOell5Tm1ZM09EVm1OamsyWlRjMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak5GOWliM2hmY205MWRHVkFNekE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1qTTBMVEl6TndvZ0lDQWdMeThnWW05NFgySjVkR1Z6SUQwZ1FtOTRLRk4wWVhScFkwbHVkSE1zSUd0bGVUMUNlWFJsY3loaUltUWlLU2tLSUNBZ0lDOHZJR0p2ZUY5aWVYUmxjeTUyWVd4MVpTQTlJRk4wWVhScFkwbHVkSE1vQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME9DZ3dLU3dnWVhKak5DNVZTVzUwT0NneEtTd2dZWEpqTkM1VlNXNTBPQ2d5S1N3Z1lYSmpOQzVWU1c1ME9DZ3pLUW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFkwSURCNE1EQXdNVEF5TURNZ0x5OGdNSGcyTkN3Z01IZ3dNREF4TURJd013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakl6TlMweU16Y0tJQ0FnSUM4dklHSnZlRjlpZVhSbGN5NTJZV3gxWlNBOUlGTjBZWFJwWTBsdWRITW9DaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwT0Nnd0tTd2dZWEpqTkM1VlNXNTBPQ2d4S1N3Z1lYSmpOQzVWU1c1ME9DZ3lLU3dnWVhKak5DNVZTVzUwT0NnektRb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pJek1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFETTVPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRnTHk4Z2IyNGdaWEp5YjNJNklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1KdmVGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExrSnZlRk4wYjNKaFoyVXVaMlYwWDJKdmVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5aWIzZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRFS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlRjlwYm5RdWRtRnNkV1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUY5cGJuUWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYjNoZmFXNTBJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPak00TFRNNUNpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFZEZWRjlDVDFoZlUxUlBVa0ZIUlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1KdmVGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExrSnZlRk4wYjNKaFoyVXVaMlYwWDJsMFpXMWZZbTk0WDIxaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5cGRHVnRYMkp2ZUY5dFlYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2hmYldGd1cydGxlVjBLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KdmVGOXRZWEFnWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZbTk0WDNOMGIzSmhaMlV1WTI5dWRISmhZM1F1UW05NFUzUnZjbUZuWlM1blpYUmZZbTk0WDIxaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5aWIzaGZiV0Z3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QnJaWGxmTVNBOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NFgyMWhjQzVuWlhRb2EyVjVYekVzSUdSbFptRjFiSFE5VTNSeWFXNW5LQ0prWldaaGRXeDBJaWtwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKa1pXWmhkV3gwSWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WW05NFgzTjBiM0poWjJVdVkyOXVkSEpoWTNRdVFtOTRVM1J2Y21GblpTNXRZWGxpWlY5aWIzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WVhsaVpWOWliM2c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklHSnZlRjlwYm5SZmRtRnNkV1VzSUdKdmVGOXBiblJmWlhocGMzUnpJRDBnYzJWc1ppNWliM2hmYVc1MExtMWhlV0psS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVGOXBiblFpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVpYjNoZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1Q2IzaFRkRzl5WVdkbExtMWhlV0psWDJKdmVGOXRZWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdFlYbGlaVjlpYjNoZmJXRndPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCclpYbGZNU0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2RtRnNkV1VzSUdWNGFYTjBjeUE5SUhObGJHWXVZbTk0WDIxaGNDNXRZWGxpWlNoclpYbGZNU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUdsbUlHNXZkQ0JsZUdsemRITTZDaUFnSUNCaWJub2diV0Y1WW1WZlltOTRYMjFoY0Y5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z2RtRnNkV1VnUFNCVGRISnBibWNvSWlJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR0oxY25rZ01Rb0tiV0Y1WW1WZlltOTRYMjFoY0Y5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1JwWnlBMENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUp2ZUY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGtKdmVGTjBiM0poWjJVdVoyVjBYMkp2ZUY5bGVHRnRjR3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkp2ZUY5bGVHRnRjR3hsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QnpaV3htTG1KdmVGOXBiblF1ZG1Gc2RXVXNDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2hmYVc1MElnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbTk0WDJsdWRDQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzNNZ29nSUNBZ0x5OGdjMlZzWmk1aWIzaGZaSGx1WVcxcFkxOWllWFJsY3k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NFgyUjVibUZ0YVdOZllubDBaWE1nWlhocGMzUnpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlRjl6ZEhKcGJtY3VkbUZzZFdVc0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5ESTBaalU0TldZME13b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbTk0WDNOMGNtbHVaeUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8yTnkwMk9Bb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQkhSVlJmUWs5WVgxTlVUMUpCUjBWZlJWaEJUVkJNUlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3WXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREV5SUM4dklERXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aWIzaGZjM1J2Y21GblpTNWpiMjUwY21GamRDNUNiM2hUZEc5eVlXZGxMbWRsZEY5aWIzaGZiV0Z3WDJWNFlXMXdiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZbTk0WDIxaGNGOWxlR0Z0Y0d4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJyWlhsZk1TQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8zT1FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRYMjFoY0M1blpYUW9hMlY1WHpFc0lHUmxabUYxYkhROVUzUnlhVzVuS0NKa1pXWmhkV3gwSWlrcElEMDlJRk4wY21sdVp5Z2laR1ZtWVhWc2RDSXBDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0prWldaaGRXeDBJZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKa1pXWmhkV3gwSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZbTk0WDNOMGIzSmhaMlV1WTI5dWRISmhZM1F1UW05NFUzUnZjbUZuWlM1dFlYbGlaVjlpYjNoZlpYaGhiWEJzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMWhlV0psWDJKdmVGOWxlR0Z0Y0d4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVpYjNoZmFXNTBMblpoYkhWbENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzaGZhVzUwSWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVGOXBiblF1WjJWMEtHUmxabUYxYkhROVZVbHVkRFkwS0RReUtTa2dQVDBnTkRJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVGOXBiblFpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6SWdMeThnTkRJS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ013b2dJQ0FnYzJWc1pXTjBDaUFnSUNCcGJuUmpYeklnTHk4Z05ESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG80TndvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCaWIzaGZhVzUwWDJWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0JpYjNoZmFXNTBYM1poYkhWbElEMDlJREFLSUNBZ0lDRUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltOTRYM04wYjNKaFoyVXVZMjl1ZEhKaFkzUXVRbTk0VTNSdmNtRm5aUzV0WVhsaVpWOWliM2hmYldGd1gyVjRZVzF3YkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHRZWGxpWlY5aWIzaGZiV0Z3WDJWNFlXMXdiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklHdGxlVjh4SUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QjJZV3gxWlN3Z1pYaHBjM1J6SUQwZ2MyVnNaaTVpYjNoZmJXRndMbTFoZVdKbEtHdGxlVjh4S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2EyVjVYekFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk9UWUtJQ0FnSUM4dklHRnpjMlZ5ZENCclpYbGZNQ0JwYmlCelpXeG1MbUp2ZUY5dFlYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVpYjNoZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1Q2IzaFRkRzl5WVdkbExtZGxkRjlpYjNoZmJXRndYM04wY25WamRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5aWIzaGZiV0Z3WDNOMGNuVmpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUY5dFlYQmZjM1J5ZFdOMFcydGxlVjBLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblZ6WlhKeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlRjl0WVhCZmMzUnlkV04wVzJ0bGVWMEtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NFgyMWhjRjl6ZEhKMVkzUWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWliM2hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVDYjNoVGRHOXlZV2RsTG5ObGRGOWliM2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZZbTk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXdOQzB4TURVS0lDQWdJQzh2SUNNZ1pYaGhiWEJzWlRvZ1UwVlVYMEpQV0Y5VFZFOVNRVWRGQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUhObGJHWXVZbTk0WDJsdWRDNTJZV3gxWlNBOUlIWmhiSFZsWDJsdWRBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRYMmx1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURRdE1UQTFDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRk5GVkY5Q1QxaGZVMVJQVWtGSFJRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUZOMGIzSmhaMlV1YzJWMFgySnZlRjl0WVhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmWW05NFgyMWhjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklITmxiR1l1WW05NFgyMWhjRnRyWlhsZElEMGdkbUZzZFdVS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRBNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltOTRYM04wYjNKaFoyVXVZMjl1ZEhKaFkzUXVRbTk0VTNSdmNtRm5aUzV6WlhSZlltOTRYMjFoY0Y5emRISjFZM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZZbTk0WDIxaGNGOXpkSEoxWTNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TVRVS0lDQWdJQzh2SUhObGJHWXVZbTk0WDIxaGNGOXpkSEoxWTNSYmEyVjVYU0E5SUhaaGJIVmxMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRYTmxjbk1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1URXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNVFVLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMjFoY0Y5emRISjFZM1JiYTJWNVhTQTlJSFpoYkhWbExtTnZjSGtvS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFeE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUZOMGIzSmhaMlV1YzJWMFgySnZlRjlsZUdGdGNHeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgySnZlRjlsZUdGdGNHeGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFeU1TMHhNaklLSUNBZ0lDOHZJQ01nWlhoaGJYQnNaVG9nVTBWVVgwSlBXRjlUVkU5U1FVZEZYMFZZUVUxUVRFVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdjMlZzWmk1aWIzaGZhVzUwTG5aaGJIVmxJRDBnZG1Gc2RXVmZhVzUwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlRjlwYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCelpXeG1MbUp2ZUY5a2VXNWhiV2xqWDJKNWRHVnpMblpoYkhWbElEMGdkbUZzZFdWZlpHSjVkR1Z6TG1OdmNIa29LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWWlJS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRNeENpQWdJQ0F2THlCelpXeG1MbUp2ZUY5emRISnBibWN1ZG1Gc2RXVWdQU0IyWVd4MVpWOXpkSEpwYm1jS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnME1qUm1OVGcxWmpRekNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzBNalJtTlRnMVpqUXpDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QnpaV3htTG1KdmVGOWllWFJsY3k1MllXeDFaU0E5SUhaaGJIVmxYMlJpZVhSbGN5NXVZWFJwZG1VS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWW05NFgySjVkR1Z6SWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVltOTRYMko1ZEdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFek9Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNoZmFXNTBMblpoYkhWbElDczlJRE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUY5cGJuUWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYjNoZmFXNTBJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklETUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVGOXBiblFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEl4TFRFeU1nb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQlRSVlJmUWs5WVgxTlVUMUpCUjBWZlJWaEJUVkJNUlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1KdmVGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExrSnZlRk4wYjNKaFoyVXVaR1ZzWlhSbFgySnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGJHVjBaVjlpYjNnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFEyQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVpYjNoZmFXNTBMblpoYkhWbENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzaGZhVzUwSWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVpYjNoZlpIbHVZVzFwWTE5aWVYUmxjeTUyWVd4MVpRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlpSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFME9Bb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVltOTRYM04wY21sdVp5NTJZV3gxWlFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURReU5HWTFPRFZtTkRNS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRYMmx1ZEM1blpYUW9aR1ZtWVhWc2REMVZTVzUwTmpRb05ESXBLU0E5UFNBME1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRYMmx1ZENJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBME1nb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR2x1ZEdOZk1pQXZMeUEwTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTFNZ29nSUNBZ0x5OGdjMlZzWmk1aWIzaGZaSGx1WVcxcFkxOWllWFJsY3k1blpYUW9aR1ZtWVhWc2REMWhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aGlJalF5SWlrcExtNWhkR2wyWlNBOVBTQmlJalF5SWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWWlJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREF3TWpNME16SUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE0wTXpJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UVXhMVEUxTXdvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MbUp2ZUY5a2VXNWhiV2xqWDJKNWRHVnpMbWRsZENoa1pXWmhkV3gwUFdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S0dJaU5ESWlLU2t1Ym1GMGFYWmxJRDA5SUdJaU5ESWlDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUp2ZUY5emRISnBibWN1WjJWMEtHUmxabUYxYkhROVlYSmpOQzVUZEhKcGJtY29JalF5SWlrcElEMDlJQ0kwTWlJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnME1qUm1OVGcxWmpRekNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF3TURJek5ETXlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWaklERXhJQzh2SURCNE1EQXdNak0wTXpJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UUXpMVEUwTkFvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCRVJVeEZWRVZmUWs5WVgxTlVUMUpCUjBVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUZOMGIzSmhaMlV1WkdWc1pYUmxYMkp2ZUY5dFlYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVmZZbTk0WDIxaGNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFMU9Bb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVltOTRYMjFoY0Z0clpYbGRDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWliM2hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVDYjNoVGRHOXlZV2RsTG1KdmVGOXRZWEJmYkdWdVozUm9XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05NFgyMWhjRjlzWlc1bmRHZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRZMUNpQWdJQ0F2THlCclpYbGZNQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE5qWUtJQ0FnSUM4dklHbG1JR3RsZVY4d0lHNXZkQ0JwYmlCelpXeG1MbUp2ZUY5dFlYQTZDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdKdmVGOXRZWEJmYkdWdVozUm9YMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakUyTndvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtDbUp2ZUY5dFlYQmZiR1Z1WjNSb1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUp2ZUY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGtKdmVGTjBiM0poWjJVdVltOTRYMjFoY0Y5c1pXNW5kR2hBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOakl0TVRZekNpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFeEZUa2RVU0Y5Q1QxaGZVMVJQVWtGSFJRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwaWIzaGZiV0Z3WDJ4bGJtZDBhRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRZNENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2hmYldGd0xteGxibWQwYUNoclpYbGZNQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NFgyMWhjQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOakl0TVRZekNpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFeEZUa2RVU0Y5Q1QxaGZVMVJQVWtGSFJRb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmlJR0p2ZUY5dFlYQmZiR1Z1WjNSb1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUp2ZUY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGtKdmVGTjBiM0poWjJVdVltOTRYMjFoY0Y5c1pXNW5kR2hBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWliM2hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVDYjNoVGRHOXlZV2RsTG1KdmVGOXRZWEJmYzNSeWRXTjBYMnhsYm1kMGFGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUp2ZUY5dFlYQmZjM1J5ZFdOMFgyeGxibWQwYURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOelVLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMjFoY0Y5emRISjFZM1JiYTJWNVh6QmRJRDBnZG1Gc2RXVXVZMjl3ZVNncENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VEYzFOek0yTlRjeU56TXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjROelUzTXpZMU56STNNekF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TnpNS0lDQWdJQzh2SUhaaGJIVmxJRDBnVlhObGNsTjBjblZqZENoaGNtTTBMbE4wY21sdVp5Z2lkR1Z6ZEU1aGJXVWlLU3dnWVhKak5DNVZTVzUwTmpRb056QXBMQ0JoY21NMExsVkpiblEyTkNneUtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNVEl3TURBd01EQXdNREF3TURBd01EUTJNREF3TURBd01EQXdNREF3TURBd01qQXdNRGczTkRZMU56TTNORFJsTmpFMlpEWTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMUNpQWdJQ0F2THlCelpXeG1MbUp2ZUY5dFlYQmZjM1J5ZFdOMFcydGxlVjh3WFNBOUlIWmhiSFZsTG1OdmNIa29LUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTNOZ29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NFgyMWhjRjl6ZEhKMVkzUmJhMlY1WHpCZExtSjVkR1Z6TG14bGJtZDBhQ0E5UFNCMllXeDFaUzVpZVhSbGN5NXNaVzVuZEdnS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE56VTNNelkxTnpJM016QXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnY0hWemFHbHVkQ0F5T0NBdkx5QXlPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFM01Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUZOMGIzSmhaMlV1WW05NFgyMWhjRjlzWlc1bmRHaGZaWGhoYlhCc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUp2ZUY5dFlYQmZiR1Z1WjNSb1gyVjRZVzF3YkdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVGcxQ2lBZ0lDQXZMeUJyWlhsZk1DQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94T0RjS0lDQWdJQzh2SUhObGJHWXVZbTk0WDIxaGNGdHJaWGxmTUYwZ1BTQjJZV3gxWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdkbUZzZFdVZ1BTQlRkSEpwYm1jb0lraHRiVzF0YlNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtodGJXMXRiU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE9EY0tJQ0FnSUM4dklITmxiR1l1WW05NFgyMWhjRnRyWlhsZk1GMGdQU0IyWVd4MVpRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0WDIxaGNGdHJaWGxmTUYwdVlubDBaWE11YkdWdVozUm9JRDA5SUhaaGJIVmxMbUo1ZEdWekxteGxibWQwYUFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z05nb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hPREl0TVRnekNpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFeEZUa2RVU0Y5Q1QxaGZVMVJQVWtGSFJWOUZXRUZOVUV4RlV3b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZbTk0WDNOMGIzSmhaMlV1WTI5dWRISmhZM1F1UW05NFUzUnZjbUZuWlM1bGVIUnlZV04wWDJKdmVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVY0ZEhKaFkzUmZZbTk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTVOZ29nSUNBZ0x5OGdZbTk0SUQwZ1FtOTRLRUo1ZEdWekxDQnJaWGs5VTNSeWFXNW5LQ0ppYkc5aUlpa3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSmliRzlpSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTVOd29nSUNBZ0x5OGdZWE56WlhKMElHSnZlQzVqY21WaGRHVW9jMmw2WlQxVlNXNTBOalFvTXpJcEtRb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrNUNpQWdJQ0F2THlCelpXNWtaWEpmWW5sMFpYTWdQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNakF3Q2lBZ0lDQXZMeUJoY0hCZllXUmtjbVZ6Y3lBOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNdVlubDBaWE1LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UazJDaUFnSUNBdkx5QmliM2dnUFNCQ2IzZ29RbmwwWlhNc0lHdGxlVDFUZEhKcGJtY29JbUpzYjJJaUtTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltSnNiMklpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1qQXlDaUFnSUNBdkx5QmliM2d1Y21Wd2JHRmpaU2d3TENCelpXNWtaWEpmWW5sMFpYTXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkdsbklETUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVGsyQ2lBZ0lDQXZMeUJpYjNnZ1BTQkNiM2dvUW5sMFpYTXNJR3RsZVQxVGRISnBibWNvSW1Kc2IySWlLU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUpzYjJJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNakF6Q2lBZ0lDQXZMeUJpYjNndWMzQnNhV05sS0RBc0lEQXNJR0Z3Y0Y5aFpHUnlaWE56S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSnZlRjl6Y0d4cFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUdKdmVDQTlJRUp2ZUNoQ2VYUmxjeXdnYTJWNVBWTjBjbWx1WnlnaVlteHZZaUlwS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWW14dllpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG95TURRS0lDQWdJQzh2SUdKdmVDNXlaWEJzWVdObEtEWTBMQ0IyWVd4MVpWOHpLUW9nSUNBZ2NIVnphR2x1ZENBMk5DQXZMeUEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qSXdNUW9nSUNBZ0x5OGdkbUZzZFdWZk15QTlJRUo1ZEdWektHSWlhR1ZzYkc4aUtRb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z01IZzJPRFkxTm1NMll6Wm1DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpBMENpQWdJQ0F2THlCaWIzZ3VjbVZ3YkdGalpTZzJOQ3dnZG1Gc2RXVmZNeWtLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCaWIzZ2dQU0JDYjNnb1FubDBaWE1zSUd0bGVUMVRkSEpwYm1jb0ltSnNiMklpS1NrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1Kc2IySWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpBMUNpQWdJQ0F2THlCd2NtVm1hWGdnUFNCaWIzZ3VaWGgwY21GamRDZ3dMQ0F6TWlBcUlESWdLeUIyWVd4MVpWOHpMbXhsYm1kMGFDa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRFk1SUM4dklEWTVDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakl3TmdvZ0lDQWdMeThnWVhOelpYSjBJSEJ5WldacGVDQTlQU0JoY0hCZllXUmtjbVZ6Y3lBcklITmxibVJsY2w5aWVYUmxjeUFySUhaaGJIVmxYek1LSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpBeENpQWdJQ0F2THlCMllXeDFaVjh6SUQwZ1FubDBaWE1vWWlKb1pXeHNieUlwQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZURZNE5qVTJZelpqTm1ZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lNRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQndjbVZtYVhnZ1BUMGdZWEJ3WDJGa1pISmxjM01nS3lCelpXNWtaWEpmWW5sMFpYTWdLeUIyWVd4MVpWOHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrekxURTVOQW9nSUNBZ0x5OGdJeUJsZUdGdGNHeGxPaUJGV0ZSU1FVTlVYMEpQV0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltOTRYM04wYjNKaFoyVXVZMjl1ZEhKaFkzUXVRbTk0VTNSdmNtRm5aUzUyWVd4MVpWOWliM2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMllXeDFaVjlpYjNnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNakV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzaGZhVzUwTG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d4TUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVGOXBiblFpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWIzaGZhVzUwSUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh6SUM4dklERXdDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakl4TUMweU1URUtJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dUMVJJUlZKZlQxQlRYMEpQV0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltOTRYM04wYjNKaFoyVXVZMjl1ZEhKaFkzUXVRbTk0VTNSdmNtRm5aUzVsZUdsemRGOWliM2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHbHpkRjlpYjNnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNakUzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZbTl2YkNoelpXeG1MbUp2ZUY5cGJuUXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2hmYVc1MElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1qRTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUZOMGIzSmhaMlV1WlhocGMzUmZZbTk0WDJWNFlXMXdiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHbHpkRjlpYjNoZlpYaGhiWEJzWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lNakVLSUNBZ0lDOHZJSEpsZEhWeWJpQmliMjlzS0hObGJHWXVZbTk0WDJSNWJtRnRhV05mWW5sMFpYTXBMQ0JpYjI5c0tITmxiR1l1WW05NFgzTjBjbWx1Wnlrc0lHSnZiMndvYzJWc1ppNWliM2hmWW5sMFpYTXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlJZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5ESTBaalU0TldZME13b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWW05NFgySjVkR1Z6SWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpFNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWliM2hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVDYjNoVGRHOXlZV2RsTG5Oc2FXTmxYMkp2ZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTnNhV05sWDJKdmVEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG95TWpVS0lDQWdJQzh2SUdKdmVGOHdJRDBnUW05NEtFSjVkR1Z6TENCclpYazlVM1J5YVc1bktDSXdJaWtwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0l3SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qSXlOZ29nSUNBZ0x5OGdZbTk0WHpBdWRtRnNkV1VnUFNCQ2VYUmxjeWhpSWxSbGMzUnBibWNnZEdWemRHbHVaeUF4TWpNaUtRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCaWIzaGZNQ0E5SUVKdmVDaENlWFJsY3l3Z2EyVjVQVk4wY21sdVp5Z2lNQ0lwS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpTUNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lNallLSUNBZ0lDOHZJR0p2ZUY4d0xuWmhiSFZsSUQwZ1FubDBaWE1vWWlKVVpYTjBhVzVuSUhSbGMzUnBibWNnTVRJeklpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVTBOalUzTXpjME5qazJaVFkzTWpBM05EWTFOek0zTkRZNU5tVTJOekl3TXpFek1qTXpDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1qSTFDaUFnSUNBdkx5QmliM2hmTUNBOUlFSnZlQ2hDZVhSbGN5d2dhMlY1UFZOMGNtbHVaeWdpTUNJcEtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaU1DSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG95TWpjS0lDQWdJQzh2SUdGemMyVnlkQ0JpYjNoZk1DNTJZV3gxWlZzd09qZGRJRDA5SUdJaVZHVnpkR2x1WnlJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnY0hWemFHbHVkQ0EzSUM4dklEY0tJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ055QXZMeUEzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG95TWpVS0lDQWdJQzh2SUdKdmVGOHdJRDBnUW05NEtFSjVkR1Z6TENCclpYazlVM1J5YVc1bktDSXdJaWtwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0l3SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qSXlOd29nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjh3TG5aaGJIVmxXekE2TjEwZ1BUMGdZaUpVWlhOMGFXNW5JZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFUwTmpVM016YzBOamsyWlRZM0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNakk1Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlRjl6ZEhKcGJtY3VkbUZzZFdVZ1BTQmhjbU0wTGxOMGNtbHVaeWdpU0dWc2JHOGlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFF5TkdZMU9EVm1ORE1LSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURReU5HWTFPRFZtTkRNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EVTBPRFkxTm1NMll6Wm1DaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1qTXdDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNoZmMzUnlhVzVuTG5aaGJIVmxMbUo1ZEdWeld6STZNVEJkSUQwOUlHSWlTR1ZzYkc4aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5ESTBaalU0TldZME13b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lEd0tJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Bb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh6SUM4dklERXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklERUtJQ0FnSUMwS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnME1qUm1OVGcxWmpRekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5EZzJOVFpqTm1NMlpnb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lNak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1KdmVGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExrSnZlRk4wYjNKaFoyVXVZbTk0WDIxaGNGOWxlR2x6ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliM2hmYldGd1gyVjRhWE4wY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lOVFl0TWpVM0NpQWdJQ0F2THlBaklHVjRZVzF3YkdVNklFOVVTRVZTWDA5UVUxOUNUMWhmVFVGUUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveU5Ua0tJQ0FnSUM4dklISmxkSFZ5YmlCclpYa2dhVzRnYzJWc1ppNWliM2hmYldGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveU5UWXRNalUzQ2lBZ0lDQXZMeUFqSUdWNFlXMXdiR1U2SUU5VVNFVlNYMDlRVTE5Q1QxaGZUVUZRQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUp2ZUY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGtKdmVGTjBiM0poWjJVdVltOTRYMjFoY0Y5emRISjFZM1JmWlhocGMzUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05NFgyMWhjRjl6ZEhKMVkzUmZaWGhwYzNSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakkyTXdvZ0lDQWdMeThnY21WMGRYSnVJR3RsZVNCcGJpQnpaV3htTG1KdmVGOXRZWEJmYzNSeWRXTjBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSjFjMlZ5Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lOakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakkyTXdvZ0lDQWdMeThnY21WMGRYSnVJR3RsZVNCcGJpQnpaV3htTG1KdmVGOXRZWEJmYzNSeWRXTjBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakkyTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQXFDaVlPQjJKdmVGOXBiblFFRlI5OGRRVkNUMWhmUXdFQUFXSUVZbXh2WWdFd0IyUmxabUYxYkhRRkZSOThkWUFGZFhObGNuTUpZbTk0WDJKNWRHVnpCQUFDTkRJTmRYTmxjbk1BQUFBQUFBQUFBQVZvWld4c2J6RWJRUUVMTVJrVVJERVlSSUllQkZpSXVaZ0VHTkQ3NHdRNjhqY29CRS9DZWVFRW52WnBjUVJPYndpZUJCS0FiMnNFZGUwMGhRUlk0bjZ2QksrUkZaQUVyb1NzVFFUdjliWlhCQnVOcmVBRVpjTUdQZ1NDY0lWbEJFZTdjRU1FZUxCelRnVFdkNG5yQkpUbDAvUUV2UVV0YWdSNTMxZjhCUGRoSmJrRUlheW0vd1FFNzBseEJDUHNzeXdFN05IUitRUi9vdEhBQkk3aXcyUUVtQUlJakFRMitHeU9OaG9Bamg0QU13QStBRk1BYVFCNkFLUUEyZ0RyQVFBQkRRRWJBU1VCT0FGTEFZSUJ0QUc5QWRRQ0JnSWJBa2dDVHdKZUFvSUFId0FOQUF3Qy9RTVFBQUVBZ0FZVkgzeDFBQUN3SWtNQWdBMFZIM3gxQUFkaWIzaGZhVzUwc0NKRGdnSUJaQVFBQVFJRHZ5SkRNUmtVTVJnVUVFTW92a1FYRmlsTVVMQWlRellhQVJjV3ZrUkpGUlpYQmdKTVVDbE1VTEFpUXlJV3ZpY0hUZ0pOU1JVV1Z3WUNURkFwVEZDd0lrTW92a3dYRmlzalR3TlVVQ2xNVUxBaVF5SVd2a2xQQWt4QUFBU0FBRVVCUndJVkZsY0dBa3hRS3lOTEJGU0FBZ0FEVEZCTVVDbE1VTEFpUXlpK1JCY25CTDVFVndJQUtyNUVUd0lXU3dJVkZsY0dBazhEVUV5QUFnQU1VRXNCRllFTUNCWlhCZ0pRVEZCTVVDbE1VTEFpUXlJV3ZpY0hUZ0pOSndjU1JDY0lzQ0pES0x4SUtMNU1GeVJMQVVzRFRTUVNSRXdVUkJSREloYTlSUUVVUkNNV3ZVVUJReWNKTmhvQlVMNUVLVXhRc0NKRE5ob0JGeFlvVEw4aVF6WWFBUmMyR2dKWEFnQk1Ga204U0V5L0lrTTJHZ0luQ1RZYUFWQkp2RWhNdnljSXNDSkROaG9CRnpZYUFqWWFBMDhDRmloTXZ5Y0V2RWduQkVzQ3Z5cThTQ3BNdjFjQ0FDY0t2RWduQ2t5L0tMNUVGNEVEQ0JZb1RMOGlReWk4U0NjRXZFZ3F2RWdvdmt3WEpFeFBBazBrRWtRbkJMNG5DMDRDVFZjQ0FJQUNORElTUkNxK0p3dE9BazBuQ3hKRE5ob0JGeGE4U0NKREl4Wkp2VVVCUUFBSUl4WXBURkN3SWtOSnZVUkMvL01uREx4SUp3eUFIQUFTQUFBQUFBQUFBRVlBQUFBQUFBQUFBZ0FJZEdWemRFNWhiV1cvSnd5OVNJRWNFa1FuQ0xBaVF5TVdTYnhJU1lBR1NHMXRiVzF0djcxSWdRWVNReWNGZ1NDNVJERUFNZ29uQlNOTEE3c25CU05KU3dQU0p3V0JRQ2NOdXljRkk0RkZ1a3hQQWxBbkRWQVNReWkrUkJjbEVrTW92VVVCS3lOUEFsUXBURkN3SWtNbkJMMUZBU3E5VGdKSUp3cTlUZ05JS3lOUEFsUWlUd0pVZ1FKUEFsUXBURkN3SWtNbkJyeElKd2FBRTFSbGMzUnBibWNnZEdWemRHbHVaeUF4TWpPL0p3YTlTRWtqU3dKTmdRZExBZ3hQQW9FSFR3Sk5Td0VKSndaT0FycUFCMVJsYzNScGJtY1NSQ3E4U0NxQUJ3QUZTR1ZzYkcrL0tyMUlnUUpMQVF4TEFZRUNUd0pOSlVzQ0RFOENKVThDVFVzQkNTcE9BcnFBQlVobGJHeHZFa00yR2dFWEZyMUZBU3NqVHdKVUtVeFFzQ0pESndrMkdnRlF2VVVCS3lOUEFsUXBURkN3SWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
