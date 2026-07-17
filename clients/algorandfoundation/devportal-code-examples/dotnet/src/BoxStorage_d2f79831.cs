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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.BoxStorage_d2f79831
{


    //
    // BoxStorage Contract
    //
    //This contract demonstrates various box storage operations in Algorand smart contracts.
    //It shows how to:
    //- Create and manage different types of boxes (int, bytes, dynamic bytes, string)
    //- Use BoxMap for key-value storage
    //- Work with BoxRef for direct box manipulation
    //- Perform operations like get, set, delete, and length calculations
    //- Handle complex data structures in boxes
    //
    //The contract implements the same functionality as its Python counterpart
    //in python-examples/smart_contracts/box_storage/contract.py
    //
    public class BoxStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BoxStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class User : AVMObjectType
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

                public static User Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new User();
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
                    return Equals(obj as User);
                }
                public bool Equals(User? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(User left, User right)
                {
                    return EqualityComparer<User>.Default.Equals(left, right);
                }
                public static bool operator !=(User left, User right)
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

        }

        ///<summary>
        ///Retrieves the value stored in the boxInt box
        ///</summary>
        public async Task<ulong> GetBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 73, 19, 68 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 183, 73, 19, 68 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the value of the boxInt box
        ///</summary>
        public async Task<ulong> ValueBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 207, 65, 5 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValueBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 207, 65, 5 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the value stored in the boxInt box and checks if it exists
        ///</summary>
        public async Task<Structs.MaybeBoxReturn> MaybeBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 179, 233, 188 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 106, 179, 233, 188 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the value stored in the boxMap box
        ///</summary>
        /// <param name="key">The key of the boxMap to retrieve the value from </param>
        public async Task<string> GetBoxMap(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 202, 100, 138 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetBoxMap_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 202, 100, 138 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the value stored in the boxMap box with a default value if the key does not exist
        ///</summary>
        /// <param name="key">The key of the boxMap to retrieve the value from </param>
        public async Task<string> GetBoxMapWithDefault(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 204, 113, 57 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetBoxMapWithDefault_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 204, 113, 57 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the value stored in the boxMap box and checks if it exists
        ///</summary>
        /// <param name="key">The key to check in the boxMap </param>
        public async Task<Structs.MaybeBoxMapReturn> MaybeBoxMap(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 74, 57, 148 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MaybeBoxMapReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MaybeBoxMap_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 74, 57, 148 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the key prefix of the boxMap box
        ///</summary>
        public async Task<byte[]> KeyPrefixBoxMap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 245, 169, 182 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 177, 245, 169, 182 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Checks if the boxMap box exists
        ///</summary>
        /// <param name="key">The key to check for </param>
        public async Task<bool> BoxMapExists(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 41, 210, 163 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
            byte[] abiHandle = { 216, 41, 210, 163 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the value of the boxInt box
        ///</summary>
        /// <param name="valueInt">The uint64 value to set in the boxInt box </param>
        public async Task SetBox(ulong valueInt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 21, 98, 247 };
            var valueIntAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueIntAbi.From(valueInt);

            var result = await base.CallApp(new List<object> { abiHandle, valueIntAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBox_Transactions(ulong valueInt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 21, 98, 247 };
            var valueIntAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueIntAbi.From(valueInt);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueIntAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the value of the boxString box
        ///</summary>
        /// <param name="value">The string value to set in the boxString box </param>
        public async Task SetBoxString(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 151, 188, 111 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBoxString_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 151, 188, 111 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the value of the boxDynamicBytes box
        ///</summary>
        /// <param name="value">The dynamic bytes value to set in the boxDynamicBytes box </param>
        public async Task SetBoxDynamicBytes(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 249, 203, 173 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBoxDynamicBytes_Transactions(byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 249, 203, 173 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the value of the boxMap box
        ///</summary>
        /// <param name="key">The key to set the value for </param>
        /// <param name="value">The value to set in the boxMap box </param>
        public async Task SetBoxMap(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 17, 253, 122 };
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
            byte[] abiHandle = { 158, 17, 253, 122 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the length of the boxMap box
        ///</summary>
        /// <param name="key">The key to get the length for </param>
        public async Task<ulong> BoxMapLength(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 52, 24, 196 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapLength_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 52, 24, 196 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes the value of the boxInt box
        ///</summary>
        public async Task DeleteBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 1, 167, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 1, 167, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes the value of the boxMap box
        ///</summary>
        /// <param name="key">The key to delete the value from </param>
        public async Task DeleteBoxMap(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 85, 46, 181 };
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
            byte[] abiHandle = { 164, 85, 46, 181 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Extracts a value from the boxRef box
        ///</summary>
        /// <param name="key">The key to extract from </param>
        public async Task ExtractBox(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 49, 250, 51 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExtractBox_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 49, 250, 51 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the value stored in the boxMapObject box
        ///</summary>
        /// <param name="key">The key to retrieve the value from </param>
        public async Task<Structs.User> GetBoxMapObject(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 150, 137, 213 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.User.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBoxMapObject_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 150, 137, 213 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Checks if the boxMapObject box exists
        ///</summary>
        /// <param name="key">The key to check for </param>
        public async Task<bool> BoxMapObjectExists(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 110, 242, 141 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapObjectExists_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 110, 242, 141 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the value of the boxMapObject box
        ///</summary>
        /// <param name="key">The key to set the value for </param>
        /// <param name="value">The value to set in the boxMapObject box User</param>
        public async Task<bool> SetBoxMapObject(ulong key, Structs.User value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 211, 159, 234 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetBoxMapObject_Transactions(ulong key, Structs.User value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 211, 159, 234 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the length of the boxMapObject box
        ///</summary>
        /// <param name="key">The key to get the length for </param>
        public async Task<ulong> BoxMapObjectLength(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 64, 54, 205 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapObjectLength_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 64, 54, 205 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creates and manipulates a box containing a fixed array of 8-bit unsigned integers
        ///</summary>
        /// <param name="key">The key for the static array box </param>
        public async Task<byte[]> Arc4Box(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 127, 10, 116 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc4Box_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 127, 10, 116 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm94U3RvcmFnZSIsImRlc2MiOiJCb3hTdG9yYWdlIENvbnRyYWN0XG5cblRoaXMgY29udHJhY3QgZGVtb25zdHJhdGVzIHZhcmlvdXMgYm94IHN0b3JhZ2Ugb3BlcmF0aW9ucyBpbiBBbGdvcmFuZCBzbWFydCBjb250cmFjdHMuXG5JdCBzaG93cyBob3cgdG86XG4tIENyZWF0ZSBhbmQgbWFuYWdlIGRpZmZlcmVudCB0eXBlcyBvZiBib3hlcyAoaW50LCBieXRlcywgZHluYW1pYyBieXRlcywgc3RyaW5nKVxuLSBVc2UgQm94TWFwIGZvciBrZXktdmFsdWUgc3RvcmFnZVxuLSBXb3JrIHdpdGggQm94UmVmIGZvciBkaXJlY3QgYm94IG1hbmlwdWxhdGlvblxuLSBQZXJmb3JtIG9wZXJhdGlvbnMgbGlrZSBnZXQsIHNldCwgZGVsZXRlLCBhbmQgbGVuZ3RoIGNhbGN1bGF0aW9uc1xuLSBIYW5kbGUgY29tcGxleCBkYXRhIHN0cnVjdHVyZXMgaW4gYm94ZXNcblxuVGhlIGNvbnRyYWN0IGltcGxlbWVudHMgdGhlIHNhbWUgZnVuY3Rpb25hbGl0eSBhcyBpdHMgUHl0aG9uIGNvdW50ZXJwYXJ0XG5pbiBweXRob24tZXhhbXBsZXMvc21hcnRfY29udHJhY3RzL2JveF9zdG9yYWdlL2NvbnRyYWN0LnB5IiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlVzZXIiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9XSwiTWF5YmVCb3hSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifV0sIk1heWJlQm94TWFwUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldEJveCIsImRlc2MiOiJSZXRyaWV2ZXMgdGhlIHZhbHVlIHN0b3JlZCBpbiB0aGUgYm94SW50IGJveCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgdWludDY0IHZhbHVlIHN0b3JlZCBpbiBib3hJbnQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbHVlQm94IiwiZGVzYyI6IlJldHJpZXZlcyB0aGUgdmFsdWUgb2YgdGhlIGJveEludCBib3giLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1heWJlQm94IiwiZGVzYyI6IlJldHJpZXZlcyB0aGUgdmFsdWUgc3RvcmVkIGluIHRoZSBib3hJbnQgYm94IGFuZCBjaGVja3MgaWYgaXQgZXhpc3RzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJNYXliZUJveFJldHVybiIsImRlc2MiOiJBIHR1cGxlIGNvbnRhaW5pbmcgdGhlIHZhbHVlIGFuZCBhIGJvb2xlYW4gaW5kaWNhdGluZyBpZiB0aGUgYm94IGV4aXN0cyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Qm94TWFwIiwiZGVzYyI6IlJldHJpZXZlcyB0aGUgdmFsdWUgc3RvcmVkIGluIHRoZSBib3hNYXAgYm94IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOiJUaGUga2V5IG9mIHRoZSBib3hNYXAgdG8gcmV0cmlldmUgdGhlIHZhbHVlIGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHZhbHVlIHN0b3JlZCBpbiB0aGUgYm94TWFwIGJveCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Qm94TWFwV2l0aERlZmF1bHQiLCJkZXNjIjoiUmV0cmlldmVzIHRoZSB2YWx1ZSBzdG9yZWQgaW4gdGhlIGJveE1hcCBib3ggd2l0aCBhIGRlZmF1bHQgdmFsdWUgaWYgdGhlIGtleSBkb2VzIG5vdCBleGlzdCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiVGhlIGtleSBvZiB0aGUgYm94TWFwIHRvIHJldHJpZXZlIHRoZSB2YWx1ZSBmcm9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSB2YWx1ZSBzdG9yZWQgaW4gdGhlIGJveE1hcCBib3gifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1heWJlQm94TWFwIiwiZGVzYyI6IlJldHJpZXZlcyB0aGUgdmFsdWUgc3RvcmVkIGluIHRoZSBib3hNYXAgYm94IGFuZCBjaGVja3MgaWYgaXQgZXhpc3RzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOiJUaGUga2V5IHRvIGNoZWNrIGluIHRoZSBib3hNYXAiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxib29sKSIsInN0cnVjdCI6Ik1heWJlQm94TWFwUmV0dXJuIiwiZGVzYyI6IkEgdHVwbGUgY29udGFpbmluZyB0aGUgdmFsdWUgYW5kIGEgYm9vbGVhbiBpbmRpY2F0aW5nIGlmIHRoZSBib3ggZXhpc3RzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJrZXlQcmVmaXhCb3hNYXAiLCJkZXNjIjoiUmV0cmlldmVzIHRoZSBrZXkgcHJlZml4IG9mIHRoZSBib3hNYXAgYm94IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBrZXkgcHJlZml4IG9mIHRoZSBib3hNYXAgYm94In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hNYXBFeGlzdHMiLCJkZXNjIjoiQ2hlY2tzIGlmIHRoZSBib3hNYXAgYm94IGV4aXN0cyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiVGhlIGtleSB0byBjaGVjayBmb3IiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6InRydWUgaWYgdGhlIGJveCBleGlzdHMsIGZhbHNlIG90aGVyd2lzZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Qm94IiwiZGVzYyI6IlNldHMgdGhlIHZhbHVlIG9mIHRoZSBib3hJbnQgYm94IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlSW50IiwiZGVzYyI6IlRoZSB1aW50NjQgdmFsdWUgdG8gc2V0IGluIHRoZSBib3hJbnQgYm94IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEJveFN0cmluZyIsImRlc2MiOiJTZXRzIHRoZSB2YWx1ZSBvZiB0aGUgYm94U3RyaW5nIGJveCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJUaGUgc3RyaW5nIHZhbHVlIHRvIHNldCBpbiB0aGUgYm94U3RyaW5nIGJveCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRCb3hEeW5hbWljQnl0ZXMiLCJkZXNjIjoiU2V0cyB0aGUgdmFsdWUgb2YgdGhlIGJveER5bmFtaWNCeXRlcyBib3giLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiVGhlIGR5bmFtaWMgYnl0ZXMgdmFsdWUgdG8gc2V0IGluIHRoZSBib3hEeW5hbWljQnl0ZXMgYm94IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEJveE1hcCIsImRlc2MiOiJTZXRzIHRoZSB2YWx1ZSBvZiB0aGUgYm94TWFwIGJveCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiVGhlIGtleSB0byBzZXQgdGhlIHZhbHVlIGZvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiVGhlIHZhbHVlIHRvIHNldCBpbiB0aGUgYm94TWFwIGJveCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hNYXBMZW5ndGgiLCJkZXNjIjoiUmV0cmlldmVzIHRoZSBsZW5ndGggb2YgdGhlIGJveE1hcCBib3giLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6IlRoZSBrZXkgdG8gZ2V0IHRoZSBsZW5ndGggZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBsZW5ndGggb2YgdGhlIGJveE1hcCBib3gifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUJveCIsImRlc2MiOiJEZWxldGVzIHRoZSB2YWx1ZSBvZiB0aGUgYm94SW50IGJveCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hNYXAiLCJkZXNjIjoiRGVsZXRlcyB0aGUgdmFsdWUgb2YgdGhlIGJveE1hcCBib3giLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6IlRoZSBrZXkgdG8gZGVsZXRlIHRoZSB2YWx1ZSBmcm9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4dHJhY3RCb3giLCJkZXNjIjoiRXh0cmFjdHMgYSB2YWx1ZSBmcm9tIHRoZSBib3hSZWYgYm94IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOiJUaGUga2V5IHRvIGV4dHJhY3QgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCb3hNYXBPYmplY3QiLCJkZXNjIjoiUmV0cmlldmVzIHRoZSB2YWx1ZSBzdG9yZWQgaW4gdGhlIGJveE1hcE9iamVjdCBib3giLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6IlRoZSBrZXkgdG8gcmV0cmlldmUgdGhlIHZhbHVlIGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlVzZXIiLCJkZXNjIjoiVGhlIHZhbHVlIHN0b3JlZCBpbiB0aGUgYm94TWFwT2JqZWN0IGJveCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm94TWFwT2JqZWN0RXhpc3RzIiwiZGVzYyI6IkNoZWNrcyBpZiB0aGUgYm94TWFwT2JqZWN0IGJveCBleGlzdHMiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6IlRoZSBrZXkgdG8gY2hlY2sgZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJ0cnVlIGlmIHRoZSBib3ggZXhpc3RzLCBmYWxzZSBvdGhlcndpc2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEJveE1hcE9iamVjdCIsImRlc2MiOiJTZXRzIHRoZSB2YWx1ZSBvZiB0aGUgYm94TWFwT2JqZWN0IGJveCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiVGhlIGtleSB0byBzZXQgdGhlIHZhbHVlIGZvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlVzZXIiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiVGhlIHZhbHVlIHRvIHNldCBpbiB0aGUgYm94TWFwT2JqZWN0IGJveCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hNYXBPYmplY3RMZW5ndGgiLCJkZXNjIjoiUmV0cmlldmVzIHRoZSBsZW5ndGggb2YgdGhlIGJveE1hcE9iamVjdCBib3giLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6IlRoZSBrZXkgdG8gZ2V0IHRoZSBsZW5ndGggZm9yIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBsZW5ndGggb2YgdGhlIGJveE1hcE9iamVjdCBib3gifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM0Qm94IiwiZGVzYyI6IkNyZWF0ZXMgYW5kIG1hbmlwdWxhdGVzIGEgYm94IGNvbnRhaW5pbmcgYSBmaXhlZCBhcnJheSBvZiA4LWJpdCB1bnNpZ25lZCBpbnRlZ2VycyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiVGhlIGtleSBmb3IgdGhlIHN0YXRpYyBhcnJheSBib3giLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDhbNF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3RhdGljIGFycmF5IHN0b3JlZCBpbiB0aGUgYm94In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNjQsMjc1LDMxMSw1MjAsNjQ4XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzNV0sImVycm9yTWVzc2FnZSI6IkZpcnN0IHBhcnQgc2hvdWxkIG1hdGNoIGFwcCBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzddLCJlcnJvck1lc3NhZ2UiOiJTZWNvbmQgcGFydCBzaG91bGQgbWF0Y2ggc2VuZGVyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA1XSwiZXJyb3JNZXNzYWdlIjoiYm94IGNyZWF0aW9uIGZhaWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyNl0sImVycm9yTWVzc2FnZSI6ImJveE1hcE9iamVjdCB2YWx1ZSBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lESWdORElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpWW05NFRXRndJaUFpWW05NFNXNTBJaUF3ZURBd01ERXdNakF6SURCNE1EQWdJbUp2ZUZOMGNtbHVaeUlnSW1KdmVFUjVibUZ0YVdOQ2VYUmxjeUlnSW5WelpYSnpJaUFpTkRJaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QmxlSEJ2Y25RZ1pHVm1ZWFZzZENCamJHRnpjeUJDYjNoVGRHOXlZV2RsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFESTRDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0kzTkRreE16UTBJREI0TkRsalpqUXhNRFVnTUhnMllXSXpaVGxpWXlBd2VESTJZMkUyTkRoaElEQjRNamhqWXpjeE16a2dNSGcyTkRSaE16azVOQ0F3ZUdJeFpqVmhPV0kySURCNFpEZ3lPV1F5WVRNZ01IaG1ZVEUxTmpKbU55QXdlR00wT1RkaVl6Wm1JREI0WmpSbU9XTmlZV1FnTUhnNVpURXhabVEzWVNBd2VHWTFNelF4T0dNMElEQjRPVEV3TVdFM1pHVWdNSGhoTkRVMU1tVmlOU0F3ZUdOaU16Rm1ZVE16SURCNE56azVOamc1WkRVZ01IZ3hOVFpsWmpJNFpDQXdlR0l5WkRNNVptVmhJREI0TUdFME1ETTJZMlFnTUhnMU5EZG1NR0UzTkNBdkx5QnRaWFJvYjJRZ0ltZGxkRUp2ZUNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMllXeDFaVUp2ZUNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKdFlYbGlaVUp2ZUNncEtIVnBiblEyTkN4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpWjJWMFFtOTRUV0Z3S0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEVKdmVFMWhjRmRwZEdoRVpXWmhkV3gwS0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbTFoZVdKbFFtOTRUV0Z3S0hWcGJuUTJOQ2tvYzNSeWFXNW5MR0p2YjJ3cElpd2diV1YwYUc5a0lDSnJaWGxRY21WbWFYaENiM2hOWVhBb0tXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaVltOTRUV0Z3UlhocGMzUnpLSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKelpYUkNiM2dvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRUp2ZUZOMGNtbHVaeWh6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBRbTk0UkhsdVlXMXBZMEo1ZEdWektHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSQ2IzaE5ZWEFvZFdsdWREWTBMSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKaWIzaE5ZWEJNWlc1bmRHZ29kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHVnNaWFJsUW05NEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa1pXeGxkR1ZDYjNoTllYQW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1WNGRISmhZM1JDYjNnb2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEVKdmVFMWhjRTlpYW1WamRDaDFhVzUwTmpRcEtITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWW05NFRXRndUMkpxWldOMFJYaHBjM1J6S0hWcGJuUTJOQ2xpYjI5c0lpd2diV1YwYUc5a0lDSnpaWFJDYjNoTllYQlBZbXBsWTNRb2RXbHVkRFkwTENoemRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5Da3BZbTl2YkNJc0lHMWxkR2h2WkNBaVltOTRUV0Z3VDJKcVpXTjBUR1Z1WjNSb0tIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1GeVl6UkNiM2dvYzNSeWFXNW5LWFZwYm5RNFd6UmRJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWjJWMFFtOTRJSFpoYkhWbFFtOTRJRzFoZVdKbFFtOTRJR2RsZEVKdmVFMWhjQ0JuWlhSQ2IzaE5ZWEJYYVhSb1JHVm1ZWFZzZENCdFlYbGlaVUp2ZUUxaGNDQnRZV2x1WDJ0bGVWQnlaV1pwZUVKdmVFMWhjRjl5YjNWMFpVQXhNQ0JpYjNoTllYQkZlR2x6ZEhNZ2MyVjBRbTk0SUhObGRFSnZlRk4wY21sdVp5QnpaWFJDYjNoRWVXNWhiV2xqUW5sMFpYTWdjMlYwUW05NFRXRndJR0p2ZUUxaGNFeGxibWQwYUNCa1pXeGxkR1ZDYjNnZ1pHVnNaWFJsUW05NFRXRndJR1Y0ZEhKaFkzUkNiM2dnWjJWMFFtOTRUV0Z3VDJKcVpXTjBJR0p2ZUUxaGNFOWlhbVZqZEVWNGFYTjBjeUJ6WlhSQ2IzaE5ZWEJQWW1wbFkzUWdZbTk0VFdGd1QySnFaV04wVEdWdVozUm9JR0Z5WXpSQ2IzZ0tJQ0FnSUdWeWNnb0tiV0ZwYmw5clpYbFFjbVZtYVhoQ2IzaE5ZWEJmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5DMHhNVFVLSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklHdGxlVkJ5WldacGVFSnZlRTFoY0NncE9pQmllWFJsY3lCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EWTJNalptTnpnMFpEWXhOekFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1qZzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF4Q2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCQ2IzaFRkRzl5WVdkbElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNGdMeThnYjI0Z1pYSnliM0k2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FnSmlZZ1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNnb0tMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTRVM1J2Y21GblpTNW5aWFJDYjNoYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJDYjNnNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOTRTVzUwSUQwZ1FtOTRQSFZwYm5RMk5ENG9leUJyWlhrNklDZGliM2hKYm5RbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmliM2hKYm5RaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVpYjNoSmJuUXVkbUZzZFdVS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJMVFUzQ2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJDYjNnb0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM2hUZEc5eVlXZGxMblpoYkhWbFFtOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1Gc2RXVkNiM2c2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCd2RXSnNhV01nWW05NFNXNTBJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEpiblFuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaEpiblFpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWliM2hKYm5RdWRtRnNkV1VLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMExUWTFDaUFnSUNBdkx5QkFjbVZoWkc5dWJIa0tJQ0FnSUM4dklIQjFZbXhwWXlCMllXeDFaVUp2ZUNncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZlRk4wYjNKaFoyVXViV0Y1WW1WQ2IzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WVhsaVpVSnZlRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUhCMVlteHBZeUJpYjNoSmJuUWdQU0JDYjNnOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJKdmVFbHVkQ2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVFbHVkQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdOdmJuTjBJRnRpYjNoSmJuUldZV3gxWlN3Z1ltOTRTVzUwUlhocGMzUnpYU0E5SUhSb2FYTXVZbTk0U1c1MExtMWhlV0psS0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJSEpsZEhWeWJpQmJZbTk0U1c1MFZtRnNkV1VzSUdKdmVFbHVkRVY0YVhOMGMxMEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek10TnpRS0lDQWdJQzh2SUVCeVpXRmtiMjVzZVFvZ0lDQWdMeThnY0hWaWJHbGpJRzFoZVdKbFFtOTRLQ2s2SUZ0MWFXNTBOalFzSUdKdmIyeGxZVzVkSUhzS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ2IzaFRkRzl5WVdkbExtZGxkRUp2ZUUxaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVKdmVFMWhjRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRdE9EVUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFSnZlRTFoY0NoclpYazZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aWIzaE5ZWEFvYTJWNUtTNTJZV3gxWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z2NIVmliR2xqSUdKdmVFMWhjQ0E5SUVKdmVFMWhjRHgxYVc1ME5qUXNJSE4wY21sdVp6NG9leUJyWlhsUWNtVm1hWGc2SUNkaWIzaE5ZWEFuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWIzaE5ZWEFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUp2ZUUxaGNDaHJaWGtwTG5aaGJIVmxDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TkMwNE5Rb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFFtOTRUV0Z3S0d0bGVUb2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTRVM1J2Y21GblpTNW5aWFJDYjNoTllYQlhhWFJvUkdWbVlYVnNkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFSnZlRTFoY0ZkcGRHaEVaV1poZFd4ME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOQzA1TlFvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwUW05NFRXRndWMmwwYUVSbFptRjFiSFFvYTJWNU9pQjFhVzUwTmpRcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW05NFRXRndLR3RsZVNrdVoyVjBLSHNnWkdWbVlYVnNkRG9nSjJSbFptRjFiSFFuSUgwcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOTRUV0Z3SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnYzNSeWFXNW5QaWg3SUd0bGVWQnlaV1pwZURvZ0oySnZlRTFoY0NjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnZlRTFoY0NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW05NFRXRndLR3RsZVNrdVoyVjBLSHNnWkdWbVlYVnNkRG9nSjJSbFptRjFiSFFuSUgwcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltUmxabUYxYkhRaUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RRdE9UVUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFSnZlRTFoY0ZkcGRHaEVaV1poZFd4MEtHdGxlVG9nZFdsdWREWTBLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRbTk0VTNSdmNtRm5aUzV0WVhsaVpVSnZlRTFoY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMWhlV0psUW05NFRXRndPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURRdE1UQTFDaUFnSUNBdkx5QkFjbVZoWkc5dWJIa0tJQ0FnSUM4dklIQjFZbXhwWXlCdFlYbGlaVUp2ZUUxaGNDaHJaWGs2SUhWcGJuUTJOQ2s2SUZ0emRISnBibWNzSUdKdmIyeGxZVzVkSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmpiMjV6ZENCYmRtRnNkV1VzSUdWNGFYTjBjMTBnUFNCMGFHbHpMbUp2ZUUxaGNDaHJaWGtwTG0xaGVXSmxLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUhCMVlteHBZeUJpYjNoTllYQWdQU0JDYjNoTllYQThkV2x1ZERZMExDQnpkSEpwYm1jK0tIc2dhMlY1VUhKbFptbDRPaUFuWW05NFRXRndKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW05NFRXRndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05nb2dJQ0FnTHk4Z1kyOXVjM1FnVzNaaGJIVmxMQ0JsZUdsemRITmRJRDBnZEdocGN5NWliM2hOWVhBb2EyVjVLUzV0WVhsaVpTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQmJaWGhwYzNSeklEOGdkbUZzZFdVZ09pQW5KeXdnWlhocGMzUnpYUW9nSUNBZ1lub2diV0Y1WW1WQ2IzaE5ZWEJmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCa2RYQUtDbTFoZVdKbFFtOTRUV0Z3WDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCeVpYUjFjbTRnVzJWNGFYTjBjeUEvSUhaaGJIVmxJRG9nSnljc0lHVjRhWE4wYzEwS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EUXRNVEExQ2lBZ0lDQXZMeUJBY21WaFpHOXViSGtLSUNBZ0lDOHZJSEIxWW14cFl5QnRZWGxpWlVKdmVFMWhjQ2hyWlhrNklIVnBiblEyTkNrNklGdHpkSEpwYm1jc0lHSnZiMnhsWVc1ZElIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoZVdKbFFtOTRUV0Z3WDNSbGNtNWhjbmxmWm1Gc2MyVkFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCeVpYUjFjbTRnVzJWNGFYTjBjeUEvSUhaaGJIVmxJRG9nSnljc0lHVjRhWE4wYzEwS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdZaUJ0WVhsaVpVSnZlRTFoY0Y5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYjNoVGRHOXlZV2RsTG1KdmVFMWhjRVY0YVhOMGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUp2ZUUxaGNFVjRhWE4wY3pvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTBMVEV5TlFvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbTk0VFdGd1JYaHBjM1J6S0d0bGVUb2dkV2x1ZERZMEtUb2dZbTl2YkdWaGJpQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TmdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVltOTRUV0Z3S0d0bGVTa3VaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOTRUV0Z3SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnYzNSeWFXNW5QaWg3SUd0bGVWQnlaV1pwZURvZ0oySnZlRTFoY0NjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnZlRTFoY0NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNallLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1KdmVFMWhjQ2hyWlhrcExtVjRhWE4wY3dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TkMweE1qVUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdKdmVFMWhjRVY0YVhOMGN5aHJaWGs2SUhWcGJuUTJOQ2s2SUdKdmIyeGxZVzRnZXdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYjNoVGRHOXlZV2RsTG5ObGRFSnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRFSnZlRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFFtOTRLSFpoYkhWbFNXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0yQ2lBZ0lDQXZMeUIwYUdsekxtSnZlRWx1ZEM1MllXeDFaU0E5SUhaaGJIVmxTVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCd2RXSnNhV01nWW05NFNXNTBJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEpiblFuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaEpiblFpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5nb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoSmJuUXVkbUZzZFdVZ1BTQjJZV3gxWlVsdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSQ2IzZ29kbUZzZFdWSmJuUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZlRk4wYjNKaFoyVXVjMlYwUW05NFUzUnlhVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBRbTk0VTNSeWFXNW5PZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRNS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSQ2IzaFRkSEpwYm1jb2RtRnNkV1U2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSEIxWW14cFl5QmliM2hUZEhKcGJtY2dQU0JDYjNnOGMzUnlhVzVuUGloN0lHdGxlVG9nSjJKdmVGTjBjbWx1WnljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltSnZlRk4wY21sdVp5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFEwQ2lBZ0lDQXZMeUIwYUdsekxtSnZlRk4wY21sdVp5NTJZV3gxWlNBOUlIWmhiSFZsQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklIQjFZbXhwWXlCaWIzaFRkSEpwYm1jZ1BTQkNiM2c4YzNSeWFXNW5QaWg3SUd0bGVUb2dKMkp2ZUZOMGNtbHVaeWNnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1KdmVGTjBjbWx1WnlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTBDaUFnSUNBdkx5QjBhR2x6TG1KdmVGTjBjbWx1Wnk1MllXeDFaU0E5SUhaaGJIVmxDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME13b2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRFSnZlRk4wY21sdVp5aDJZV3gxWlRvZ2MzUnlhVzVuS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW05NFUzUnZjbUZuWlM1elpYUkNiM2hFZVc1aGJXbGpRbmwwWlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJDYjNoRWVXNWhiV2xqUW5sMFpYTTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTVFvZ0lDQWdMeThnY0hWaWJHbGpJSE5sZEVKdmVFUjVibUZ0YVdOQ2VYUmxjeWgyWVd4MVpUb2dZWEpqTkM1RWVXNWhiV2xqUW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSEIxWW14cFl5QmliM2hFZVc1aGJXbGpRbmwwWlhNZ1BTQkNiM2c4WVhKak5DNUVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuWW05NFJIbHVZVzFwWTBKNWRHVnpKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWW05NFJIbHVZVzFwWTBKNWRHVnpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUhSb2FYTXVZbTk0UkhsdVlXMXBZMEo1ZEdWekxuWmhiSFZsSUQwZ2RtRnNkV1VLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z2NIVmliR2xqSUdKdmVFUjVibUZ0YVdOQ2VYUmxjeUE5SUVKdmVEeGhjbU0wTGtSNWJtRnRhV05DZVhSbGN6NG9leUJyWlhrNklDZGliM2hFZVc1aGJXbGpRbmwwWlhNbklIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSmliM2hFZVc1aGJXbGpRbmwwWlhNaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdkR2hwY3k1aWIzaEVlVzVoYldsalFubDBaWE11ZG1Gc2RXVWdQU0IyWVd4MVpRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRFS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSQ2IzaEVlVzVoYldsalFubDBaWE1vZG1Gc2RXVTZJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRbTk0VTNSdmNtRm5aUzV6WlhSQ2IzaE5ZWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkNiM2hOWVhBNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdjSFZpYkdsaklITmxkRUp2ZUUxaGNDaHJaWGs2SUhWcGJuUTJOQ3dnZG1Gc2RXVTZJSE4wY21sdVp5azZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXhDaUFnSUNBdkx5QjBhR2x6TG1KdmVFMWhjQ2hyWlhrcExuWmhiSFZsSUQwZ2RtRnNkV1VLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUhCMVlteHBZeUJpYjNoTllYQWdQU0JDYjNoTllYQThkV2x1ZERZMExDQnpkSEpwYm1jK0tIc2dhMlY1VUhKbFptbDRPaUFuWW05NFRXRndKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW05NFRXRndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTllYQW9hMlY1S1M1MllXeDFaU0E5SUhaaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUkNiM2hOWVhBb2EyVjVPaUIxYVc1ME5qUXNJSFpoYkhWbE9pQnpkSEpwYm1jcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ2IzaFRkRzl5WVdkbExtSnZlRTFoY0V4bGJtZDBhRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KdmVFMWhjRXhsYm1kMGFEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN4TFRFM01nb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWW05NFRXRndUR1Z1WjNSb0tHdGxlVG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjekNpQWdJQ0F2THlCcFppQW9JWFJvYVhNdVltOTRUV0Z3S0d0bGVTa3VaWGhwYzNSektTQjdDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbTk0VFdGd0lEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z2MzUnlhVzVuUGloN0lHdGxlVkJ5WldacGVEb2dKMkp2ZUUxaGNDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUp2ZUUxaGNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1KdmVFMWhjQ2hyWlhrcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWW05NFRXRndUR1Z1WjNSb1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56UUtJQ0FnSUM4dklISmxkSFZ5YmlCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2dwaWIzaE5ZWEJNWlc1bmRHaGZZV1owWlhKZmFXNXNhVzVsWkY5amIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM2hUZEc5eVlXZGxMbUp2ZUUxaGNFeGxibWQwYUVBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOekV0TVRjeUNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJpYjNoTllYQk1aVzVuZEdnb2EyVjVPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWW05NFRXRndUR1Z1WjNSb1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzNDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVpYjNoTllYQW9hMlY1S1M1c1pXNW5kR2dLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjeExURTNNZ29nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1ltOTRUV0Z3VEdWdVozUm9LR3RsZVRvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR0lnWW05NFRXRndUR1Z1WjNSb1gyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTRVM1J2Y21GblpTNWliM2hOWVhCTVpXNW5kR2hBTkFvS0NpOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKdmVGTjBiM0poWjJVdVpHVnNaWFJsUW05NFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFFtOTRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnY0hWaWJHbGpJR0p2ZUVsdWRDQTlJRUp2ZUR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW05NFNXNTBKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NFNXNTBJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RZS0lDQWdJQzh2SUhSb2FYTXVZbTk0U1c1MExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSEIxWW14cFl5QmliM2hFZVc1aGJXbGpRbmwwWlhNZ1BTQkNiM2c4WVhKak5DNUVlVzVoYldsalFubDBaWE0rS0hzZ2EyVjVPaUFuWW05NFJIbHVZVzFwWTBKNWRHVnpKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWW05NFJIbHVZVzFwWTBKNWRHVnpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RjS0lDQWdJQzh2SUhSb2FYTXVZbTk0UkhsdVlXMXBZMEo1ZEdWekxtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSEIxWW14cFl5QmliM2hUZEhKcGJtY2dQU0JDYjNnOGMzUnlhVzVuUGloN0lHdGxlVG9nSjJKdmVGTjBjbWx1WnljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltSnZlRk4wY21sdVp5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGc0Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRk4wY21sdVp5NWtaV3hsZEdVb0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZbTk0U1c1MElEMGdRbTk0UEhWcGJuUTJORDRvZXlCclpYazZJQ2RpYjNoSmJuUW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppYjNoSmJuUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRTVzUwTG1kbGRDaDdJR1JsWm1GMWJIUTZJRlZwYm5RMk5DZzBNaWtnZlNrZ1BUMDlJRFF5S1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHpJQzh2SURReUNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWTE4eklDOHZJRFF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCd2RXSnNhV01nWW05NFJIbHVZVzFwWTBKNWRHVnpJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oySnZlRVI1Ym1GdGFXTkNlWFJsY3ljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltSnZlRVI1Ym1GdGFXTkNlWFJsY3lJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoRWVXNWhiV2xqUW5sMFpYTXVaMlYwS0hzZ1pHVm1ZWFZzZERvZ2JtVjNJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLQ2MwTWljcElIMHBMbTVoZEdsMlpTQTlQVDBnUW5sMFpYTW9KelF5SnlrcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF5TXpRek1nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlORElpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCd2RXSnNhV01nWW05NFUzUnlhVzVuSUQwZ1FtOTRQSE4wY21sdVp6NG9leUJyWlhrNklDZGliM2hUZEhKcGJtY25JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppYjNoVGRISnBibWNpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0VTNSeWFXNW5MbWRsZENoN0lHUmxabUYxYkhRNklDYzBNaWNnZlNrZ1BUMDlJQ2MwTWljcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUE0SUM4dklDSTBNaUlLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaU5ESWlDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFVLSUNBZ0lDOHZJSEIxWW14cFl5QmtaV3hsZEdWQ2IzZ29LVG9nZG05cFpDQjdDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYjNoVGRHOXlZV2RsTG1SbGJHVjBaVUp2ZUUxaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsYkdWMFpVSnZlRTFoY0RvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazVDaUFnSUNBdkx5QndkV0pzYVdNZ1pHVnNaWFJsUW05NFRXRndLR3RsZVRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd01Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoTllYQW9hMlY1S1M1a1pXeGxkR1VvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z2NIVmliR2xqSUdKdmVFMWhjQ0E5SUVKdmVFMWhjRHgxYVc1ME5qUXNJSE4wY21sdVp6NG9leUJyWlhsUWNtVm1hWGc2SUNkaWIzaE5ZWEFuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWIzaE5ZWEFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXdDaUFnSUNBdkx5QjBhR2x6TG1KdmVFMWhjQ2hyWlhrcExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGs1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1ZzWlhSbFFtOTRUV0Z3S0d0bGVUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTRVM1J2Y21GblpTNWxlSFJ5WVdOMFFtOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWlhoMGNtRmpkRUp2ZURvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTVDaUFnSUNBdkx5QndkV0pzYVdNZ1pYaDBjbUZqZEVKdmVDaHJaWGs2SUhOMGNtbHVaeWs2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakV3Q2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhKQ2VYUmxjeUE5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakV4Q2lBZ0lDQXZMeUJqYjI1emRDQmhjSEJCWkdSeVpYTnpJRDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXVZbmwwWlhNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhOUW9nSUNBZ0x5OGdZWE56WlhKMEtHSnZlQzVqY21WaGRHVW9leUJ6YVhwbE9pQjBiM1JoYkZOcGVtVWdmU2tzSUNkaWIzZ2dZM0psWVhScGIyNGdabUZwYkdWa0p5a0tJQ0FnSUdScFp5QXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TWdvZ0lDQWdMeThnWTI5dWMzUWdkRzkwWVd4VGFYcGxJRDBnVldsdWREWTBLR0Z3Y0VGa1pISmxjM011YkdWdVozUm9JQ3NnYzJWdVpHVnlRbmwwWlhNdWJHVnVaM1JvS1FvZ0lDQWdjSFZ6YUdsdWRDQTJOQ0F2THlBMk5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGliM2d1WTNKbFlYUmxLSHNnYzJsNlpUb2dkRzkwWVd4VGFYcGxJSDBwTENBblltOTRJR055WldGMGFXOXVJR1poYVd4bFpDY3BDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0JoYzNObGNuUWdMeThnWW05NElHTnlaV0YwYVc5dUlHWmhhV3hsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UY0tJQ0FnSUM4dklHSnZlQzV5WlhCc1lXTmxLREFzSUhObGJtUmxja0o1ZEdWektRb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrYVdjZ013b2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTRDaUFnSUNBdkx5QmliM2d1YzNCc2FXTmxLREFzSURBc0lHRndjRUZrWkhKbGMzTXBDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUdKdmVGOXpjR3hwWTJVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSXdDaUFnSUNBdkx5QmpiMjV6ZENCd1lYSjBNU0E5SUdKdmVDNWxlSFJ5WVdOMEtEQXNJRE15S1FvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qRUtJQ0FnSUM4dklHTnZibk4wSUhCaGNuUXlJRDBnWW05NExtVjRkSEpoWTNRb016SXNJRE15S1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TXdvZ0lDQWdMeThnWVhOelpYSjBLSEJoY25ReExtVnhkV0ZzY3loaGNIQkJaR1J5WlhOektTd2dKMFpwY25OMElIQmhjblFnYzJodmRXeGtJRzFoZEdOb0lHRndjQ0JoWkdSeVpYTnpKeWtLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJHYVhKemRDQndZWEowSUhOb2IzVnNaQ0J0WVhSamFDQmhjSEFnWVdSa2NtVnpjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpRS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhKME1pNWxjWFZoYkhNb2MyVnVaR1Z5UW5sMFpYTXBMQ0FuVTJWamIyNWtJSEJoY25RZ2MyaHZkV3hrSUcxaGRHTm9JSE5sYm1SbGNpQmllWFJsY3ljcENpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Ea0tJQ0FnSUM4dklIQjFZbXhwWXlCbGVIUnlZV04wUW05NEtHdGxlVG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCeVpYUjFjbTRnTHk4Z2IyNGdaWEp5YjNJNklGTmxZMjl1WkNCd1lYSjBJSE5vYjNWc1pDQnRZWFJqYUNCelpXNWtaWElnWW5sMFpYTUtDZ292THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM2hUZEc5eVlXZGxMbWRsZEVKdmVFMWhjRTlpYW1WamRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVKdmVFMWhjRTlpYW1WamREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0wTFRJek5Rb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFFtOTRUV0Z3VDJKcVpXTjBLR3RsZVRvZ2RXbHVkRFkwS1RvZ1ZYTmxjaUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZbTk0VFdGd1QySnFaV04wS0d0bGVTa3VkbUZzZFdVS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIQjFZbXhwWXlCaWIzaE5ZWEJQWW1wbFkzUWdQU0JDYjNoTllYQThkV2x1ZERZMExDQlZjMlZ5UGloN0lHdGxlVkJ5WldacGVEb2dKM1Z6WlhKekp5QjlLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkWE5sY25NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0yQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aWIzaE5ZWEJQWW1wbFkzUW9hMlY1S1M1MllXeDFaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNMExUSXpOUW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBRbTk0VFdGd1QySnFaV04wS0d0bGVUb2dkV2x1ZERZMEtUb2dWWE5sY2lCN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTRVM1J2Y21GblpTNWliM2hOWVhCUFltcGxZM1JGZUdsemRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjNoTllYQlBZbXBsWTNSRmVHbHpkSE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UW05NFUzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME5DMHlORFVLSUNBZ0lDOHZJRUJ5WldGa2IyNXNlUW9nSUNBZ0x5OGdjSFZpYkdsaklHSnZlRTFoY0U5aWFtVmpkRVY0YVhOMGN5aHJaWGs2SUhWcGJuUTJOQ2s2SUdKdmIyeGxZVzRnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUp2ZUUxaGNFOWlhbVZqZENoclpYa3BMbVY0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPQW9nSUNBZ0x5OGdjSFZpYkdsaklHSnZlRTFoY0U5aWFtVmpkQ0E5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRlZ6WlhJK0tIc2dhMlY1VUhKbFptbDRPaUFuZFhObGNuTW5JSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYzJWeWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRZS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtSnZlRTFoY0U5aWFtVmpkQ2hyWlhrcExtVjRhWE4wY3dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTkMweU5EVUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdKdmVFMWhjRTlpYW1WamRFVjRhWE4wY3loclpYazZJSFZwYm5RMk5DazZJR0p2YjJ4bFlXNGdld29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM2hUZEc5eVlXZGxMbk5sZEVKdmVFMWhjRTlpYW1WamRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEVKdmVFMWhjRTlpYW1WamREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalUwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwUW05NFRXRndUMkpxWldOMEtHdGxlVG9nZFdsdWREWTBMQ0IyWVd4MVpUb2dWWE5sY2lrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVFVLSUNBZ0lDOHZJSFJvYVhNdVltOTRUV0Z3VDJKcVpXTjBLR3RsZVNrdWRtRnNkV1VnUFNCamJHOXVaU2gyWVd4MVpTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUNiM2hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSEIxWW14cFl5QmliM2hOWVhCUFltcGxZM1FnUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JWYzJWeVBpaDdJR3RsZVZCeVpXWnBlRG9nSjNWelpYSnpKeUI5S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpZFhObGNuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVMUNpQWdJQ0F2THlCMGFHbHpMbUp2ZUUxaGNFOWlhbVZqZENoclpYa3BMblpoYkhWbElEMGdZMnh2Ym1Vb2RtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVFl0TWpZMENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDZ0tJQ0FnSUM4dklDQWdkR2hwY3k1aWIzaE5ZWEJQWW1wbFkzUW9hMlY1S1M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lHNWhiV1U2SUhaaGJIVmxMbTVoYldVc0NpQWdJQ0F2THlBZ0lDQWdhV1E2SUhaaGJIVmxMbWxrTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwT2lCMllXeDFaUzVoYzNObGRDd0tJQ0FnSUM4dklDQWdmU3dLSUNBZ0lDOHZJQ0FnSjJKdmVFMWhjRTlpYW1WamRDQjJZV3gxWlNCdGFYTnRZWFJqYUNjc0NpQWdJQ0F2THlBcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZd0NpQWdJQ0F2THlCcFpEb2dkbUZzZFdVdWFXUXNDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTmkweU5qUUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LQW9nSUNBZ0x5OGdJQ0IwYUdsekxtSnZlRTFoY0U5aWFtVmpkQ2hyWlhrcExuWmhiSFZsTEFvZ0lDQWdMeThnSUNCN0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlRvZ2RtRnNkV1V1Ym1GdFpTd0tJQ0FnSUM4dklDQWdJQ0JwWkRvZ2RtRnNkV1V1YVdRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhRNklIWmhiSFZsTG1GemMyVjBMQW9nSUNBZ0x5OGdJQ0I5TEFvZ0lDQWdMeThnSUNBblltOTRUV0Z3VDJKcVpXTjBJSFpoYkhWbElHMXBjMjFoZEdOb0p5d0tJQ0FnSUM4dklDa0tJQ0FnSUQwOUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdKaVlLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5SeklERXdJRGdnTHk4Z01UQXNJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTVFvZ0lDQWdMeThnWVhOelpYUTZJSFpoYkhWbExtRnpjMlYwTEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURFd0lDOHZJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UWXRNalkwQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNnS0lDQWdJQzh2SUNBZ2RHaHBjeTVpYjNoTllYQlBZbXBsWTNRb2EyVjVLUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdld29nSUNBZ0x5OGdJQ0FnSUc1aGJXVTZJSFpoYkhWbExtNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2FXUTZJSFpoYkhWbExtbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBPaUIyWVd4MVpTNWhjM05sZEN3S0lDQWdJQzh2SUNBZ2ZTd0tJQ0FnSUM4dklDQWdKMkp2ZUUxaGNFOWlhbVZqZENCMllXeDFaU0J0YVhOdFlYUmphQ2NzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCaWIzaE5ZWEJQWW1wbFkzUWdkbUZzZFdVZ2JXbHpiV0YwWTJnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5Q2IzaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVTBDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBRbTk0VFdGd1QySnFaV04wS0d0bGVUb2dkV2x1ZERZMExDQjJZV3gxWlRvZ1ZYTmxjaWs2SUdKdmIyeGxZVzRnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW05NFUzUnZjbUZuWlM1aWIzaE5ZWEJQWW1wbFkzUk1aVzVuZEdoYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliM2hOWVhCUFltcGxZM1JNWlc1bmRHZzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRbTk0VTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkzTXdvZ0lDQWdMeThnY0hWaWJHbGpJR0p2ZUUxaGNFOWlhbVZqZEV4bGJtZDBhQ2hyWlhrNklIVnBiblEyTkNrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRNQW9nSUNBZ0x5OGdkR2hwY3k1aWIzaE5ZWEJQWW1wbFkzUW9hMlY1S1M1MllXeDFaU0E5SUdOc2IyNWxLSFpoYkhWbEtRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPQW9nSUNBZ0x5OGdjSFZpYkdsaklHSnZlRTFoY0U5aWFtVmpkQ0E5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRlZ6WlhJK0tIc2dhMlY1VUhKbFptbDRPaUFuZFhObGNuTW5JSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oxYzJWeWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RBS0lDQWdJQzh2SUhSb2FYTXVZbTk0VFdGd1QySnFaV04wS0d0bGVTa3VkbUZzZFdVZ1BTQmpiRzl1WlNoMllXeDFaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TVRJd01EQXdNREF3TURBd01EQXdNRFEyTURBd01EQXdNREF3TURBd01EUmtNakF3TURnM05EWTFOek0zTkRSbE5qRTJaRFkxQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW05NFRXRndUMkpxWldOMEtHdGxlU2t1YkdWdVozUm9DaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlDYjNoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjekNpQWdJQ0F2THlCd2RXSnNhV01nWW05NFRXRndUMkpxWldOMFRHVnVaM1JvS0d0bGVUb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM2hUZEc5eVlXZGxMbUZ5WXpSQ2IzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoY21NMFFtOTRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1RJS0lDQWdJQzh2SUhCMVlteHBZeUJoY21NMFFtOTRLR3RsZVRvZ2MzUnlhVzVuS1RvZ1ZXbHVkRGg0TkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UVUtJQ0FnSUM4dklITjBZWFJwWTBsdWRFSnZlQzUyWVd4MVpTQTlJRzVsZHlCR2FYaGxaRUZ5Y21GNVBHRnlZelF1VldsdWREZ3NJRFErS0c1bGR5QlZhVzUwT0Nnd0tTd2dibVYzSUZWcGJuUTRLREVwTENCdVpYY2dWV2x1ZERnb01pa3NJRzVsZHlCVmFXNTBPQ2d6S1NrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXhNREl3TXdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdNREV3TWpBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFtOTRVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVOd29nSUNBZ0x5OGdZWE56WlhKMEtITjBZWFJwWTBsdWRFSnZlQzUyWVd4MVpWc3dYUzVoYzFWcGJuUTJOQ2dwSUQwOVBTQXdLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSjVkR1VLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1RVS0lDQWdJQzh2SUhOMFlYUnBZMGx1ZEVKdmVDNTJZV3gxWlNBOUlHNWxkeUJHYVhobFpFRnljbUY1UEdGeVl6UXVWV2x1ZERnc0lEUStLRzVsZHlCVmFXNTBPQ2d3S1N3Z2JtVjNJRlZwYm5RNEtERXBMQ0J1WlhjZ1ZXbHVkRGdvTWlrc0lHNWxkeUJWYVc1ME9DZ3pLU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBeE1ESXdNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEp2ZUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1RnS0lDQWdJQzh2SUdGemMyVnlkQ2h6ZEdGMGFXTkpiblJDYjNndWRtRnNkV1ZiTVYwdVlYTlZhVzUwTmpRb0tTQTlQVDBnTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UVUtJQ0FnSUM4dklITjBZWFJwWTBsdWRFSnZlQzUyWVd4MVpTQTlJRzVsZHlCR2FYaGxaRUZ5Y21GNVBHRnlZelF1VldsdWREZ3NJRFErS0c1bGR5QlZhVzUwT0Nnd0tTd2dibVYzSUZWcGJuUTRLREVwTENCdVpYY2dWV2x1ZERnb01pa3NJRzVsZHlCVmFXNTBPQ2d6S1NrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXhNREl3TXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBKdmVGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENoemRHRjBhV05KYm5SQ2IzZ3VkbUZzZFdWYk1sMHVZWE5WYVc1ME5qUW9LU0E5UFQwZ01pa0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JuWlhSaWVYUmxDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVFVLSUNBZ0lDOHZJSE4wWVhScFkwbHVkRUp2ZUM1MllXeDFaU0E5SUc1bGR5QkdhWGhsWkVGeWNtRjVQR0Z5WXpRdVZXbHVkRGdzSURRK0tHNWxkeUJWYVc1ME9DZ3dLU3dnYm1WM0lGVnBiblE0S0RFcExDQnVaWGNnVldsdWREZ29NaWtzSUc1bGR5QlZhVzUwT0NnektTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF4TURJd013b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHpkR0YwYVdOSmJuUkNiM2d1ZG1Gc2RXVmJNMTB1WVhOVmFXNTBOalFvS1NBOVBUMGdNeWtLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUF6Q2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwSnZlRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVElLSUNBZ0lDOHZJSEIxWW14cFl5QmhjbU0wUW05NEtHdGxlVG9nYzNSeWFXNW5LVG9nVldsdWREaDROQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURFd01qQXpDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDS2lZSkJCVWZmSFVHWW05NFRXRndCbUp2ZUVsdWRBUUFBUUlEQVFBSlltOTRVM1J5YVc1bkQySnZlRVI1Ym1GdGFXTkNlWFJsY3dWMWMyVnljd0kwTWpFYlFRQ3pNUmtVUkRFWVJJSVZCTGRKRTBRRVNjOUJCUVJxcyttOEJDYktaSW9FS014eE9RUmtTam1VQkxIMXFiWUUyQ25Tb3dUNkZXTDNCTVNYdkc4RTlQbkxyUVNlRWYxNkJQVTBHTVFFa1FHbjNnU2tWUzYxQk1zeCtqTUVlWmFKMVFRVmJ2S05CTExUbitvRUNrQTJ6UVJVZndwME5ob0FqaFVBR2dBbEFEQUFRZ0JhQUgwQUFRQ3ZBTVlBMEFEZ0FPMEJBd0VnQVZZQllnR1NBYU1CdXdIMUFpb0FnQXdWSDN4MUFBWmliM2hOWVhDd0lrTXhHUlF4R0JRUVF5cStSQmNXS0V4UXNDSkRLcjVFRnhZb1RGQ3dJa01xdmt3WEZpY0VJMDhEVkZBb1RGQ3dJa00yR2dFWEZpbE1VTDVFU1JVV1Z3WUNURkFvVEZDd0lrTTJHZ0VYRmlsTVVMNkFCMlJsWm1GMWJIUk9BazFKRlJaWEJnSk1VQ2hNVUxBaVF6WWFBUmNXS1V4UXZrbFBBa3hCQUIxSlNSVVdWd1lDVEZBbkJDTkxCRlNBQWdBRFRGQk1VQ2hNVUxBaVE0QUFRdi9mTmhvQkZ4WXBURkM5UlFFbkJDTlBBbFFvVEZDd0lrTTJHZ0VYRmlwTXZ5SkROaG9CVndJQUp3VzhTQ2NGVEw4aVF6WWFBU2NHdkVnbkJreS9Ja00yR2dFWE5ob0NWd0lBVEJZcFRGQkp2RWhNdnlKRE5ob0JGeFlwVEZCSnZVVUJRQUFJSXhZb1RGQ3dJa05KdlVSQy8vTXF2RWduQnJ4SUp3VzhTQ3ErVEJjbFRFOENUU1VTUkNjR3ZvQUVBQUkwTWs0Q1RWY0NBQ2NJRWtRbkJiNG5DRTRDVFNjSUVrTTJHZ0VYRmlsTVVMeElJa00yR2dGWEFnQXhBRElLU3dLQlFMbEVTd0lqU3dPN1N3SWpTVXNEMGtzQ0k0RWd1azhEZ1NCSnVreFBBaEpFRWtNMkdnRVhGaWNIVEZDK1JDaE1VTEFpUXpZYUFSY1dKd2RNVUwxRkFTY0VJMDhDVkNoTVVMQWlRellhQVJjMkdnSk1GaWNIVEZCSnZFaEpTd0svU1NTQkNMb1hTd0lrV3hJaUVFeURBZ29JdWhkUEFvRUtXeElRUklBRkZSOThkWUN3SWtNMkdnRVhGaWNIVEZCSnZFaEpnQndBRWdBQUFBQUFBQUJHQUFBQUFBQUFCTklBQ0hSbGMzUk9ZVzFsdjcxSUZpaE1VTEFpUXpZYUFWY0NBQ3UvS3lOVkZFUXJJbFVpRWtRckpGVWtFa1FyZ1FOVmdRTVNSSUFJRlI5OGRRQUJBZ093SWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
