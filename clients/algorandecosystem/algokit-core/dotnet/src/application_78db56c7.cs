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

namespace Arc56.Generated.algorandecosystem.algokit_core.application_78db56c7
{


    public class ComplexStructTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ComplexStructTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NestedStruct : AVMObjectType
            {
                public Structs.Vector Content { get; set; } = new Structs.Vector();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Content.ToByteArray();
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

                public static NestedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestedStruct();
                    var indexContent = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Content = Structs.Vector.Parse(bytes.Skip(indexContent + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedStruct);
                }
                public bool Equals(NestedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedStruct left, NestedStruct right)
                {
                    return EqualityComparer<NestedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedStruct left, NestedStruct right)
                {
                    return !(left == right);
                }

            }

            public class RootStruct : AVMObjectType
            {
                public Structs.NestedStruct Nested { get; set; } = new Structs.NestedStruct();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Nested.ToByteArray();
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

                public static RootStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new RootStruct();
                    var indexNested = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Nested = Structs.NestedStruct.Parse(bytes.Skip(indexNested + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RootStruct);
                }
                public bool Equals(RootStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RootStruct left, RootStruct right)
                {
                    return EqualityComparer<RootStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(RootStruct left, RootStruct right)
                {
                    return !(left == right);
                }

            }

            public class Vector : AVMObjectType
            {
                public string X { get; set; }

                public string Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vX.From(X);
                    stringRef[ret.Count] = vX.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vY.From(Y);
                    stringRef[ret.Count] = vY.Encode();
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

                public static Vector Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Vector();
                    var indexX = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vX.Decode(bytes.Skip(indexX + prefixOffset).ToArray());
                    var valueX = vX.ToValue();
                    if (valueX is string vXValue) { ret.X = vXValue; }
                    var indexY = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vY.Decode(bytes.Skip(indexY + prefixOffset).ToArray());
                    var valueY = vY.ToValue();
                    if (valueY is string vYValue) { ret.Y = vYValue; }
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

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.RootStruct> GiveMeRootStruct(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 163, 206, 154 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RootStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GiveMeRootStruct_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 163, 206, 154 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29tcGxleFN0cnVjdFRlc3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTmVzdGVkU3RydWN0IjpbeyJuYW1lIjoiY29udGVudCIsInR5cGUiOiJWZWN0b3IifV0sIlJvb3RTdHJ1Y3QiOlt7Im5hbWUiOiJuZXN0ZWQiLCJ0eXBlIjoiTmVzdGVkU3RydWN0In1dLCJWZWN0b3IiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InkiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnaXZlX21lX3Jvb3Rfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IigoKHN0cmluZyxzdHJpbmcpKSkiLCJzdHJ1Y3QiOiJSb290U3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6Mn19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIxNCwyNDRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE9wdEluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA1LDIxNywyNDddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVjM1J5ZFdOMGN5NWpiMjUwY21GamRDNVRkSEoxWTNSekxsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNREEwTURBd056QXdNREV6TVRBd01ERXpNaUF3ZURBd01ESXdNREF5TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJZ0ltMTVYMkp2ZUY5emRISjFZM1FpSUNKdGVWOXVaWE4wWldSZlltOTRYM04wY25WamRDSWdNSGcyWkRjNU5XWTJNalptTnpnMlpEWXhOekExWmpjek56UTNNamMxTmpNM05EQXdNREF3TURBd01EQXdNREF3TjJJZ01IZzJaRGM1TldZMlpUWTFOek0zTkRZMU5qUTFaall5Tm1ZM09EWmtOakUzTURWbU56TTNORGN5TnpVMk16YzBNREF3TURBd01EQXdNREF3TURBM1lnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUhObGJHWXViWGxmYzNSeWRXTjBJRDBnUjJ4dlltRnNVM1JoZEdVb1ZtVmpkRzl5S0hnOVlYSmpOQzVUZEhKcGJtY29JakVpS1N3Z2VUMWhjbU0wTGxOMGNtbHVaeWdpTWlJcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJYbGZjM1J5ZFdOMElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNRFF3TURBM01EQXdNVE14TURBd01UTXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZNaklLSUNBZ0lDOHZJSE5sYkdZdWJYbGZibVZ6ZEdWa1gzTjBjblZqZENBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ2NIVnphR0o1ZEdWeklDSnRlVjl1WlhOMFpXUmZjM1J5ZFdOMElnb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qTUtJQ0FnSUM4dklGSnZiM1JUZEhKMVkzUW9ibVZ6ZEdWa1BVNWxjM1JsWkZOMGNuVmpkQ2hqYjI1MFpXNTBQVlpsWTNSdmNpaDRQV0Z5WXpRdVUzUnlhVzVuS0NJeElpa3NJSGs5WVhKak5DNVRkSEpwYm1jb0lqSWlLU2twS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01ESXdNREF5TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJeUxUSTBDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5emRISjFZM1FnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JTYjI5MFUzUnlkV04wS0c1bGMzUmxaRDFPWlhOMFpXUlRkSEoxWTNRb1kyOXVkR1Z1ZEQxV1pXTjBiM0lvZUQxaGNtTTBMbE4wY21sdVp5Z2lNU0lwTENCNVBXRnlZelF1VTNSeWFXNW5LQ0l5SWlrcEtTa0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pFNUNpQWdJQ0F2THlCamJHRnpjeUJUZEhKMVkzUnpLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU9Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQXlZbVZqWlRFeElEQjRZVFJoTTJObE9XRWdNSGd6TUdNMlpEVTRZU0F2THlCdFpYUm9iMlFnSW1obGJHeHZLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZHBkbVZmYldWZmNtOXZkRjl6ZEhKMVkzUW9LU2dvS0hOMGNtbHVaeXh6ZEhKcGJtY3BLU2tpTENCdFpYUm9iMlFnSW05d2RGOXBiaWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmFHVnNiRzlmY205MWRHVkFOU0J0WVdsdVgyZHBkbVZmYldWZmNtOXZkRjl6ZEhKMVkzUmZjbTkxZEdWQU5pQnRZV2x1WDI5d2RGOXBibDl5YjNWMFpVQTNDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveE9Rb2dJQ0FnTHk4Z1kyeGhjM01nVTNSeWRXTjBjeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHbHVkQ0F3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXZjSFJmYVc1ZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazl3ZEVsdUlsMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUM0IwU1c0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JQY0hSSmJnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHOXdkRjlwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluYVhabFgyMWxYM0p2YjNSZmMzUnlkV04wWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG96TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREF5TURBd01qQXdNRFF3TURBM01EQXdNVE14TURBd01UTXlDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmFHVnNiRzlmY205MWRHVkFOVG9LSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUb3hPUW9nSUNBZ0x5OGdZMnhoYzNNZ1UzUnlkV04wY3loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZNeklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdobGJHeHZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGc2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG94T1FvZ0lDQWdMeThnWTJ4aGMzTWdVM1J5ZFdOMGN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSeWRXTjBjeTVqYjI1MGNtRmpkQzVUZEhKMVkzUnpMbWhsYkd4dktHNWhiV1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYUdWc2JHODZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUb3pNaTB6TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCb1pXeHNieWh6Wld4bUxDQnVZVzFsT2lCaGNtTTBMbE4wY21sdVp5a2dMVDRnWVhKak5DNVRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdJa2hsYkd4dkxDQWlJQ3NnYm1GdFpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRnMk5UWmpObU0yWmpKak1qQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxuTnRZWEowWDJOdmJuUnlZV04wY3k1emRISjFZM1J6TG1OdmJuUnlZV04wTGxOMGNuVmpkSE11YjNCMFgybHVLQ2tnTFQ0Z2RtOXBaRG9LYjNCMFgybHVPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZOREF0TkRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUM0IwU1c0aVhTa0tJQ0FnSUM4dklHUmxaaUJ2Y0hSZmFXNG9jMlZzWmlrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklEQWdNQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZORElLSUNBZ0lDOHZJSE5sYkdZdWJYbGZZbTk0WDNOMGNuVmpkQzUyWVd4MVpTQTlJRlpsWTNSdmNpaDRQV0Z5WXpRdVUzUnlhVzVuS0NJeElpa3NJSGs5WVhKak5DNVRkSEpwYm1jb0lqSWlLU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTE1WDJKdmVGOXpkSEoxWTNRaUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltMTVYMkp2ZUY5emRISjFZM1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5aWIzaGZjM1J5ZFdOMExuWmhiSFZsSUQwZ1VtOXZkRk4wY25WamRDZ0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltMTVYMjVsYzNSbFpGOWliM2hmYzNSeWRXTjBJZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZORE10TkRVS0lDQWdJQzh2SUhObGJHWXViWGxmYm1WemRHVmtYMkp2ZUY5emRISjFZM1F1ZG1Gc2RXVWdQU0JTYjI5MFUzUnlkV04wS0FvZ0lDQWdMeThnSUNBZ0lHNWxjM1JsWkQxT1pYTjBaV1JUZEhKMVkzUW9ZMjl1ZEdWdWREMVdaV04wYjNJb2VEMWhjbU0wTGxOMGNtbHVaeWdpTVNJcExDQjVQV0Z5WXpRdVUzUnlhVzVuS0NJeUlpa3BLUW9nSUNBZ0x5OGdLUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYzJWc1ppNXRlVjl1WlhOMFpXUmZZbTk0WDNOMGNuVmpkQzUyWVd4MVpTQTlJRkp2YjNSVGRISjFZM1FvQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p0ZVY5dVpYTjBaV1JmWW05NFgzTjBjblZqZENJS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRekxUUTFDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5aWIzaGZjM1J5ZFdOMExuWmhiSFZsSUQwZ1VtOXZkRk4wY25WamRDZ0tJQ0FnSUM4dklDQWdJQ0J1WlhOMFpXUTlUbVZ6ZEdWa1UzUnlkV04wS0dOdmJuUmxiblE5Vm1WamRHOXlLSGc5WVhKak5DNVRkSEpwYm1jb0lqRWlLU3dnZVQxaGNtTTBMbE4wY21sdVp5Z2lNaUlwS1NrS0lDQWdJQzh2SUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXlNREF3TWpBd01EUXdNREEzTURBd01UTXhNREF3TVRNeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzBOZ29nSUNBZ0x5OGdjMlZzWmk1dGVWOWliM2h0WVhCZmMzUnlkV04wVzJGeVl6UXVWVWx1ZERZMEtERXlNeWxkSUQwZ1ZtVmpkRzl5S0hnOVlYSmpOQzVUZEhKcGJtY29JakVpS1N3Z2VUMWhjbU0wTGxOMGNtbHVaeWdpTWlJcEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWmtOemsxWmpZeU5tWTNPRFprTmpFM01EVm1Oek0zTkRjeU56VTJNemMwTURBd01EQXdNREF3TURBd01EQTNZZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0Tm1RM09UVm1OakkyWmpjNE5tUTJNVGN3TldZM016YzBOekkzTlRZek56UXdNREF3TURBd01EQXdNREF3TURkaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdOREF3TURjd01EQXhNekV3TURBeE16SUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMjVsYzNSbFpGOWliM2h0WVhCZmMzUnlkV04wVzJGeVl6UXVWVWx1ZERZMEtERXlNeWxkSUQwZ1VtOXZkRk4wY25WamRDZ0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzJaRGM1TldZMlpUWTFOek0zTkRZMU5qUTFaall5Tm1ZM09EWmtOakUzTURWbU56TTNORGN5TnpVMk16YzBNREF3TURBd01EQXdNREF3TURBM1lnb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5EY3RORGtLSUNBZ0lDOHZJSE5sYkdZdWJYbGZibVZ6ZEdWa1gySnZlRzFoY0Y5emRISjFZM1JiWVhKak5DNVZTVzUwTmpRb01USXpLVjBnUFNCU2IyOTBVM1J5ZFdOMEtBb2dJQ0FnTHk4Z0lDQWdJRzVsYzNSbFpEMU9aWE4wWldSVGRISjFZM1FvWTI5dWRHVnVkRDFXWldOMGIzSW9lRDFoY21NMExsTjBjbWx1WnlnaU1TSXBMQ0I1UFdGeVl6UXVVM1J5YVc1bktDSXlJaWtwS1FvZ0lDQWdMeThnS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z2MyVnNaaTV0ZVY5dVpYTjBaV1JmWW05NGJXRndYM04wY25WamRGdGhjbU0wTGxWSmJuUTJOQ2d4TWpNcFhTQTlJRkp2YjNSVGRISjFZM1FvQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0Tm1RM09UVm1ObVUyTlRjek56UTJOVFkwTldZMk1qWm1OemcyWkRZeE56QTFaamN6TnpRM01qYzFOak0zTkRBd01EQXdNREF3TURBd01EQXdOMklLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalEzTFRRNUNpQWdJQ0F2THlCelpXeG1MbTE1WDI1bGMzUmxaRjlpYjNodFlYQmZjM1J5ZFdOMFcyRnlZelF1VlVsdWREWTBLREV5TXlsZElEMGdVbTl2ZEZOMGNuVmpkQ2dLSUNBZ0lDOHZJQ0FnSUNCdVpYTjBaV1E5VG1WemRHVmtVM1J5ZFdOMEtHTnZiblJsYm5ROVZtVmpkRzl5S0hnOVlYSmpOQzVUZEhKcGJtY29JakVpS1N3Z2VUMWhjbU0wTGxOMGNtbHVaeWdpTWlJcEtTa0tJQ0FnSUM4dklDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF5TURBd01qQXdNRFF3TURBM01EQXdNVE14TURBd01UTXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG8xTUFvZ0lDQWdMeThnYzJWc1ppNXRlVjlzYjJOaGJITjBZWFJsWDNOMGNuVmpkRnRVZUc0dWMyVnVaR1Z5WFNBOUlGWmxZM1J2Y2loNFBXRnlZelF1VTNSeWFXNW5LQ0l4SWlrc0lIazlZWEpqTkM1VGRISnBibWNvSWpJaUtTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSEIxYzJoaWVYUmxjeUFpYlhsZmJHOWpZV3h6ZEdGMFpWOXpkSEoxWTNRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdOREF3TURjd01EQXhNekV3TURBeE16SUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5c2IyTmhiSE4wWVhSbFgzTjBjblZqZEZ0VWVHNHVjMlZ1WkdWeVhTQTlJRkp2YjNSVGRISjFZM1FvQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltMTVYMjVsYzNSbFpGOXNiMk5oYkhOMFlYUmxYM04wY25WamRDSUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qVXhMVFV6Q2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMjVsYzNSbFpGOXNiMk5oYkhOMFlYUmxYM04wY25WamRGdFVlRzR1YzJWdVpHVnlYU0E5SUZKdmIzUlRkSEoxWTNRb0NpQWdJQ0F2THlBZ0lDQWdibVZ6ZEdWa1BVNWxjM1JsWkZOMGNuVmpkQ2hqYjI1MFpXNTBQVlpsWTNSdmNpaDRQV0Z5WXpRdVUzUnlhVzVuS0NJeElpa3NJSGs5WVhKak5DNVRkSEpwYm1jb0lqSWlLU2twQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01qQXdNREl3TURBME1EQXdOekF3TURFek1UQXdNREV6TWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFTWUdDZ0FFQUFjQUFURUFBVElPQUFJQUFnQUVBQWNBQVRFQUFUSU5iWGxmWW05NFgzTjBjblZqZEJSdGVWOXVaWE4wWldSZlltOTRYM04wY25WamRCaHRlVjlpYjNodFlYQmZjM1J5ZFdOMEFBQUFBQUFBQUhzZmJYbGZibVZ6ZEdWa1gySnZlRzFoY0Y5emRISjFZM1FBQUFBQUFBQUFlekVZUUFBaGdBbHRlVjl6ZEhKMVkzUW9aNEFRYlhsZmJtVnpkR1ZrWDNOMGNuVmpkQ2xuTVJ0QkFHS0NBd1FDdnM0UkJLU2p6cG9FTU1iVmlqWWFBSTREQUM0QUVBQURnUUJETVJraUVrUXhHRVNJQUY4aVF6RVpGRVF4R0VTQUVoVWZmSFVBQWdBQ0FBUUFCd0FCTVFBQk1yQWlRekVaRkVReEdFUTJHZ0dJQUJhQUJCVWZmSFZNVUxBaVF6RVpRUCsxTVJnVVJDSkRpZ0VCaS85WEFnQ0FCMGhsYkd4dkxDQk1VRWtWRmxjR0FreFFpWW9BQUNxOFNDb292eXU4U0NzcHZ5Y0V2RWduQkNpL0p3VzhTQ2NGS2I4eEFJQVViWGxmYkc5allXeHpkR0YwWlY5emRISjFZM1FvWmpFQWdCdHRlVjl1WlhOMFpXUmZiRzlqWVd4emRHRjBaVjl6ZEhKMVkzUXBab2s9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MSwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
