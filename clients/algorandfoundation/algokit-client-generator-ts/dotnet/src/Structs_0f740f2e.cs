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

namespace Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Structs_0f740f2e
{


    public class StructsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StructsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0cyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJOZXN0ZWRTdHJ1Y3QiOlt7Im5hbWUiOiJjb250ZW50IiwidHlwZSI6IlZlY3RvciJ9XSwiUm9vdFN0cnVjdCI6W3sibmFtZSI6Im5lc3RlZCIsInR5cGUiOiJOZXN0ZWRTdHJ1Y3QifV0sIlZlY3RvciI6W3sibmFtZSI6IngiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoieSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaGVsbG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdpdmVfbWVfcm9vdF9zdHJ1Y3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKCgoc3RyaW5nLHN0cmluZykpKSIsInN0cnVjdCI6IlJvb3RTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRfaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjoyfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjE0LDI0NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgT3B0SW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDUsMjE3LDI0N10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUnlkV04wY3k1amIyNTBjbUZqZEM1VGRISjFZM1J6TGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnd01EQTBNREF3TnpBd01ERXpNVEF3TURFek1pQXdlREF3TURJd01EQXlNREF3TkRBd01EY3dNREF4TXpFd01EQXhNeklnSW0xNVgySnZlRjl6ZEhKMVkzUWlJQ0p0ZVY5dVpYTjBaV1JmWW05NFgzTjBjblZqZENJZ01IZzJaRGM1TldZMk1qWm1OemcyWkRZeE56QTFaamN6TnpRM01qYzFOak0zTkRBd01EQXdNREF3TURBd01EQXdOMklnTUhnMlpEYzVOV1kyWlRZMU56TTNORFkxTmpRMVpqWXlObVkzT0Raa05qRTNNRFZtTnpNM05EY3lOelUyTXpjME1EQXdNREF3TURBd01EQXdNREEzWWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBjblZqZEhNdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJSE5sYkdZdWJYbGZjM1J5ZFdOMElEMGdSMnh2WW1Gc1UzUmhkR1VvVm1WamRHOXlLSGc5WVhKak5DNVRkSEpwYm1jb0lqRWlLU3dnZVQxaGNtTTBMbE4wY21sdVp5Z2lNaUlwS1NrS0lDQWdJSEIxYzJoaWVYUmxjeUFpYlhsZmMzUnlkV04wSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EUXdNREEzTURBd01UTXhNREF3TVRNeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklITmxiR1l1YlhsZmJtVnpkR1ZrWDNOMGNuVmpkQ0E5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdGVWOXVaWE4wWldSZmMzUnlkV04wSWdvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUZKdmIzUlRkSEoxWTNRb2JtVnpkR1ZrUFU1bGMzUmxaRk4wY25WamRDaGpiMjUwWlc1MFBWWmxZM1J2Y2loNFBXRnlZelF1VTNSeWFXNW5LQ0l4SWlrc0lIazlZWEpqTkM1VGRISnBibWNvSWpJaUtTa3BLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURJd01EQXlNREF3TkRBd01EY3dNREF4TXpFd01EQXhNeklLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPakl5TFRJMENpQWdJQ0F2THlCelpXeG1MbTE1WDI1bGMzUmxaRjl6ZEhKMVkzUWdQU0JIYkc5aVlXeFRkR0YwWlNnS0lDQWdJQzh2SUNBZ0lDQlNiMjkwVTNSeWRXTjBLRzVsYzNSbFpEMU9aWE4wWldSVGRISjFZM1FvWTI5dWRHVnVkRDFXWldOMGIzSW9lRDFoY21NMExsTjBjbWx1WnlnaU1TSXBMQ0I1UFdGeVl6UXVVM1J5YVc1bktDSXlJaWtwS1NrS0lDQWdJQzh2SUNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPakU1Q2lBZ0lDQXZMeUJqYkdGemN5QlRkSEoxWTNSektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBT0FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURBeVltVmpaVEV4SURCNFlUUmhNMk5sT1dFZ01IZ3pNR00yWkRVNFlTQXZMeUJ0WlhSb2IyUWdJbWhsYkd4dktITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kcGRtVmZiV1ZmY205dmRGOXpkSEoxWTNRb0tTZ29LSE4wY21sdVp5eHpkSEpwYm1jcEtTa2lMQ0J0WlhSb2IyUWdJbTl3ZEY5cGJpZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmYUdWc2JHOWZjbTkxZEdWQU5TQnRZV2x1WDJkcGRtVmZiV1ZmY205dmRGOXpkSEoxWTNSZmNtOTFkR1ZBTmlCdFlXbHVYMjl3ZEY5cGJsOXliM1YwWlVBM0NncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEE2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG94T1FvZ0lDQWdMeThnWTJ4aGMzTWdVM1J5ZFdOMGN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdsdWRDQXdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dmNIUmZhVzVmY205MWRHVkFOem9LSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrOXdkRWx1SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1QzQjBTVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQlBjSFJKYmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUc5d2RGOXBiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5hWFpsWDIxbFgzSnZiM1JmYzNSeWRXTjBYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQXlNREF3TWpBd01EUXdNREEzTURBd01UTXhNREF3TVRNeUNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYUdWc2JHOWZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qTXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveE9Rb2dJQ0FnTHk4Z1kyeGhjM01nVTNSeWRXTjBjeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2hsYkd4dkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEZzZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUb3hPUW9nSUNBZ0x5OGdZMnhoYzNNZ1UzUnlkV04wY3loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVjM1J5ZFdOMGN5NWpiMjUwY21GamRDNVRkSEoxWTNSekxtaGxiR3h2S0c1aGJXVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0thR1ZzYkc4NkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvek1pMHpNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJvWld4c2J5aHpaV3htTENCdVlXMWxPaUJoY21NMExsTjBjbWx1WnlrZ0xUNGdZWEpqTkM1VGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QnlaWFIxY200Z0lraGxiR3h2TENBaUlDc2dibUZ0WlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORGcyTlRaak5tTTJaakpqTWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdWNFlXMXdiR1Z6TG5OdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEhKMVkzUnpMbU52Ym5SeVlXTjBMbE4wY25WamRITXViM0IwWDJsdUtDa2dMVDRnZG05cFpEb0tiM0IwWDJsdU9nb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5EQXROREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVQzQjBTVzRpWFNrS0lDQWdJQzh2SUdSbFppQnZjSFJmYVc0b2MyVnNaaWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURBZ01Bb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklITmxiR1l1YlhsZlltOTRYM04wY25WamRDNTJZV3gxWlNBOUlGWmxZM1J2Y2loNFBXRnlZelF1VTNSeWFXNW5LQ0l4SWlrc0lIazlZWEpqTkM1VGRISnBibWNvSWpJaUtTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltMTVYMkp2ZUY5emRISjFZM1FpQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW0xNVgySnZlRjl6ZEhKMVkzUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TkRBd01EY3dNREF4TXpFd01EQXhNeklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCelpXeG1MbTE1WDI1bGMzUmxaRjlpYjNoZmMzUnlkV04wTG5aaGJIVmxJRDBnVW05dmRGTjBjblZqZENnS0lDQWdJR0o1ZEdWalh6TWdMeThnSW0xNVgyNWxjM1JsWkY5aWIzaGZjM1J5ZFdOMElnb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMGNuVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5ETXRORFVLSUNBZ0lDOHZJSE5sYkdZdWJYbGZibVZ6ZEdWa1gySnZlRjl6ZEhKMVkzUXVkbUZzZFdVZ1BTQlNiMjkwVTNSeWRXTjBLQW9nSUNBZ0x5OGdJQ0FnSUc1bGMzUmxaRDFPWlhOMFpXUlRkSEoxWTNRb1kyOXVkR1Z1ZEQxV1pXTjBiM0lvZUQxaGNtTTBMbE4wY21sdVp5Z2lNU0lwTENCNVBXRnlZelF1VTNSeWFXNW5LQ0l5SWlrcEtRb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdjMlZzWmk1dGVWOXVaWE4wWldSZlltOTRYM04wY25WamRDNTJZV3gxWlNBOUlGSnZiM1JUZEhKMVkzUW9DaUFnSUNCaWVYUmxZMTh6SUM4dklDSnRlVjl1WlhOMFpXUmZZbTk0WDNOMGNuVmpkQ0lLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkSEoxWTNSekwyTnZiblJ5WVdOMExuQjVPalF6TFRRMUNpQWdJQ0F2THlCelpXeG1MbTE1WDI1bGMzUmxaRjlpYjNoZmMzUnlkV04wTG5aaGJIVmxJRDBnVW05dmRGTjBjblZqZENnS0lDQWdJQzh2SUNBZ0lDQnVaWE4wWldROVRtVnpkR1ZrVTNSeWRXTjBLR052Ym5SbGJuUTlWbVZqZEc5eUtIZzlZWEpqTkM1VGRISnBibWNvSWpFaUtTd2dlVDFoY21NMExsTjBjbWx1WnlnaU1pSXBLU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBeU1EQXdNakF3TURRd01EQTNNREF3TVRNeE1EQXdNVE15Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSeWRXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z2MyVnNaaTV0ZVY5aWIzaHRZWEJmYzNSeWRXTjBXMkZ5WXpRdVZVbHVkRFkwS0RFeU15bGRJRDBnVm1WamRHOXlLSGc5WVhKak5DNVRkSEpwYm1jb0lqRWlLU3dnZVQxaGNtTTBMbE4wY21sdVp5Z2lNaUlwS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURaa056azFaall5Tm1ZM09EWmtOakUzTURWbU56TTNORGN5TnpVMk16YzBNREF3TURBd01EQXdNREF3TURBM1lnb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRObVEzT1RWbU5qSTJaamM0Tm1RMk1UY3dOV1kzTXpjME56STNOVFl6TnpRd01EQXdNREF3TURBd01EQXdNRGRpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5aWIzaHRZWEJmYzNSeWRXTjBXMkZ5WXpRdVZVbHVkRFkwS0RFeU15bGRJRDBnVW05dmRGTjBjblZqZENnS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnMlpEYzVOV1kyWlRZMU56TTNORFkxTmpRMVpqWXlObVkzT0Raa05qRTNNRFZtTnpNM05EY3lOelUyTXpjME1EQXdNREF3TURBd01EQXdNREEzWWdvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wY25WamRITXZZMjl1ZEhKaFkzUXVjSGs2TkRjdE5Ea0tJQ0FnSUM4dklITmxiR1l1YlhsZmJtVnpkR1ZrWDJKdmVHMWhjRjl6ZEhKMVkzUmJZWEpqTkM1VlNXNTBOalFvTVRJektWMGdQU0JTYjI5MFUzUnlkV04wS0FvZ0lDQWdMeThnSUNBZ0lHNWxjM1JsWkQxT1pYTjBaV1JUZEhKMVkzUW9ZMjl1ZEdWdWREMVdaV04wYjNJb2VEMWhjbU0wTGxOMGNtbHVaeWdpTVNJcExDQjVQV0Z5WXpRdVUzUnlhVzVuS0NJeUlpa3BLUW9nSUNBZ0x5OGdLUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1J5ZFdOMGN5OWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnYzJWc1ppNXRlVjl1WlhOMFpXUmZZbTk0YldGd1gzTjBjblZqZEZ0aGNtTTBMbFZKYm5RMk5DZ3hNak1wWFNBOUlGSnZiM1JUZEhKMVkzUW9DaUFnSUNCaWVYUmxZeUExSUM4dklEQjRObVEzT1RWbU5tVTJOVGN6TnpRMk5UWTBOV1kyTWpabU56ZzJaRFl4TnpBMVpqY3pOelEzTWpjMU5qTTNOREF3TURBd01EQXdNREF3TURBd04ySUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRISjFZM1J6TDJOdmJuUnlZV04wTG5CNU9qUTNMVFE1Q2lBZ0lDQXZMeUJ6Wld4bUxtMTVYMjVsYzNSbFpGOWliM2h0WVhCZmMzUnlkV04wVzJGeVl6UXVWVWx1ZERZMEtERXlNeWxkSUQwZ1VtOXZkRk4wY25WamRDZ0tJQ0FnSUM4dklDQWdJQ0J1WlhOMFpXUTlUbVZ6ZEdWa1UzUnlkV04wS0dOdmJuUmxiblE5Vm1WamRHOXlLSGc5WVhKak5DNVRkSEpwYm1jb0lqRWlLU3dnZVQxaGNtTTBMbE4wY21sdVp5Z2lNaUlwS1NrS0lDQWdJQzh2SUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXlNREF3TWpBd01EUXdNREEzTURBd01UTXhNREF3TVRNeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUnlkV04wY3k5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdjMlZzWmk1dGVWOXNiMk5oYkhOMFlYUmxYM04wY25WamRGdFVlRzR1YzJWdVpHVnlYU0E5SUZabFkzUnZjaWg0UFdGeVl6UXVVM1J5YVc1bktDSXhJaWtzSUhrOVlYSmpOQzVUZEhKcGJtY29JaklpS1NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QWliWGxmYkc5allXeHpkR0YwWlY5emRISjFZM1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd05EQXdNRGN3TURBeE16RXdNREF4TXpJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVeENpQWdJQ0F2THlCelpXeG1MbTE1WDI1bGMzUmxaRjlzYjJOaGJITjBZWFJsWDNOMGNuVmpkRnRVZUc0dWMyVnVaR1Z5WFNBOUlGSnZiM1JUZEhKMVkzUW9DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW0xNVgyNWxjM1JsWkY5c2IyTmhiSE4wWVhSbFgzTjBjblZqZENJS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEhKMVkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVeExUVXpDaUFnSUNBdkx5QnpaV3htTG0xNVgyNWxjM1JsWkY5c2IyTmhiSE4wWVhSbFgzTjBjblZqZEZ0VWVHNHVjMlZ1WkdWeVhTQTlJRkp2YjNSVGRISjFZM1FvQ2lBZ0lDQXZMeUFnSUNBZ2JtVnpkR1ZrUFU1bGMzUmxaRk4wY25WamRDaGpiMjUwWlc1MFBWWmxZM1J2Y2loNFBXRnlZelF1VTNSeWFXNW5LQ0l4SWlrc0lIazlZWEpqTkM1VGRISnBibWNvSWpJaUtTa3BDaUFnSUNBdkx5QXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TWpBd01ESXdNREEwTURBd056QXdNREV6TVRBd01ERXpNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVNZR0NnQUVBQWNBQVRFQUFUSU9BQUlBQWdBRUFBY0FBVEVBQVRJTmJYbGZZbTk0WDNOMGNuVmpkQlJ0ZVY5dVpYTjBaV1JmWW05NFgzTjBjblZqZEJodGVWOWliM2h0WVhCZmMzUnlkV04wQUFBQUFBQUFBSHNmYlhsZmJtVnpkR1ZrWDJKdmVHMWhjRjl6ZEhKMVkzUUFBQUFBQUFBQWV6RVlRQUFoZ0FsdGVWOXpkSEoxWTNRb1o0QVFiWGxmYm1WemRHVmtYM04wY25WamRDbG5NUnRCQUdLQ0F3UUN2czRSQktTanpwb0VNTWJWaWpZYUFJNERBQzRBRUFBRGdRQkRNUmtpRWtReEdFU0lBRjhpUXpFWkZFUXhHRVNBRWhVZmZIVUFBZ0FDQUFRQUJ3QUJNUUFCTXJBaVF6RVpGRVF4R0VRMkdnR0lBQmFBQkJVZmZIVk1VTEFpUXpFWlFQKzFNUmdVUkNKRGlnRUJpLzlYQWdDQUIwaGxiR3h2TENCTVVFa1ZGbGNHQWt4UWlZb0FBQ3E4U0Nvb3Z5dThTQ3NwdnljRXZFZ25CQ2kvSndXOFNDY0ZLYjh4QUlBVWJYbGZiRzlqWVd4emRHRjBaVjl6ZEhKMVkzUW9aakVBZ0J0dGVWOXVaWE4wWldSZmJHOWpZV3h6ZEdGMFpWOXpkSEoxWTNRcFpvaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
