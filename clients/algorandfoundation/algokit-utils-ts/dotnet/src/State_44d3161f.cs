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

namespace Arc56.Generated.algorandfoundation.algokit_utils_ts.State_44d3161f
{


    public class StateProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Input : AVMObjectType
            {
                public string Name { get; set; }

                public ulong Age { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAge.From(Age);
                    ret.AddRange(vAge.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Input Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Input();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAge.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAge = vAge.ToValue();
                    if (valueAge is ulong vAgeValue) { ret.Age = vAgeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Input);
                }
                public bool Equals(Input? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Input left, Input right)
                {
                    return EqualityComparer<Input>.Default.Equals(left, right);
                }
                public static bool operator !=(Input left, Input right)
                {
                    return !(left == right);
                }

            }

            public class Output : AVMObjectType
            {
                public string Message { get; set; }

                public ulong Result { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.From(Message);
                    stringRef[ret.Count] = vMessage.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResult = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vResult.From(Result);
                    ret.AddRange(vResult.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Output Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Output();
                    uint count = 0;
                    var indexMessage = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMessage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMessage.Decode(bytes.Skip(indexMessage + prefixOffset).ToArray());
                    var valueMessage = vMessage.ToValue();
                    if (valueMessage is string vMessageValue) { ret.Message = vMessageValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResult = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vResult.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResult = vResult.ToValue();
                    if (valueResult is ulong vResultValue) { ret.Result = vResultValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Output);
                }
                public bool Equals(Output? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Output left, Output right)
                {
                    return EqualityComparer<Output>.Default.Equals(left, right);
                }
                public static bool operator !=(Output left, Output right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<string> CreateAbi(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 82, 48, 64 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateAbi_Transactions(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 82, 48, 64 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<string> UpdateAbi(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 165, 206, 183 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateAbi_Transactions(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 165, 206, 183 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<string> DeleteAbi(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 27, 78, 233 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DeleteAbi_Transactions(string input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 27, 78, 233 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///
        ///</summary>
        public async Task Error(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 208, 218, 13 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Error_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 208, 218, 13 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> CallAbi(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 126, 128, 165 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.SimApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallAbi_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 126, 128, 165 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<uint> CallAbiUint32(uint input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 101, 79, 22 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt32(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallAbiUint32_Transactions(uint input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 101, 79, 22 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<uint> CallAbiUint32Readonly(uint input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 64, 78, 238 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); inputAbi.From(input);

            var result = await base.SimApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt32(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallAbiUint32Readonly_Transactions(uint input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 64, 78, 238 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<ulong> CallAbiUint64(ulong input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 172, 126, 8 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); inputAbi.From(input);

            var result = await base.CallApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallAbiUint64_Transactions(ulong input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 172, 126, 8 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="input"> </param>
        public async Task<ulong> CallAbiUint64Readonly(ulong input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 26, 150, 79 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); inputAbi.From(input);

            var result = await base.SimApp(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallAbiUint64Readonly_Transactions(ulong input, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 26, 150, 79 };
            var inputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); inputAbi.From(input);

            return await base.MakeTransactionList(new List<object> { abiHandle, inputAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="txn"> </param>
        /// <param name="value"> </param>
        public async Task<string> CallAbiTxn(PaymentTransaction txn, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 10, 146, 168, 30 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.SimApp(new List<object> { abiHandle, txn, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallAbiTxn_Transactions(PaymentTransaction txn, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            byte[] abiHandle = { 10, 146, 168, 30 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, txn, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="account"> </param>
        /// <param name="application"> </param>
        public async Task<ulong> CallWithReferences(ulong asset, Algorand.Address account, ulong application, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 225, 180, 43 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var applicationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); applicationAbi.From(application);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, accountAbi, applicationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallWithReferences_Transactions(ulong asset, Algorand.Address account, ulong application, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 225, 180, 43 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var applicationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); applicationAbi.From(application);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, accountAbi, applicationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<string> DefaultValue(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 75, 85, 200 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DefaultValue_Transactions(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 75, 85, 200 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<ulong> DefaultValueInt(ulong arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 3, 98, 233 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DefaultValueInt_Transactions(ulong arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 3, 98, 233 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<string> DefaultValueFromAbi(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 210, 17, 163 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DefaultValueFromAbi_Transactions(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 210, 17, 163 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<ulong> DefaultValueFromGlobalState(ulong arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 252, 187, 0 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DefaultValueFromGlobalState_Transactions(ulong arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 252, 187, 0 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg_with_default"> </param>
        public async Task<string> DefaultValueFromLocalState(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 240, 186, 248 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            var result = await base.SimApp(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DefaultValueFromLocalState_Transactions(string arg_with_default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 240, 186, 248 };
            var arg_with_defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arg_with_defaultAbi.From(arg_with_default);

            return await base.MakeTransactionList(new List<object> { abiHandle, arg_with_defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name_age"> Input</param>
        public async Task<Structs.Output> Structs(Structs.Input name_age, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 107, 235, 131 };

            var result = await base.CallApp(new List<object> { abiHandle, name_age }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Output.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Structs_Transactions(Structs.Input name_age, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 107, 235, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle, name_age }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="int1"> </param>
        /// <param name="int2"> </param>
        /// <param name="bytes1"> </param>
        /// <param name="bytes2"> </param>
        public async Task SetGlobal(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 207, 141, 234 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            var result = await base.CallApp(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGlobal_Transactions(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 207, 141, 234 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            return await base.MakeTransactionList(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="int1"> </param>
        /// <param name="int2"> </param>
        /// <param name="bytes1"> </param>
        /// <param name="bytes2"> </param>
        public async Task SetLocal(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 194, 131, 74 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            var result = await base.CallApp(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLocal_Transactions(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 194, 131, 74 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            return await base.MakeTransactionList(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="value"> </param>
        public async Task SetBox(byte[] name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 180, 162, 48 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBox_Transactions(byte[] name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 180, 162, 48 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSW5wdXQiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFnZSIsInR5cGUiOiJ1aW50NjQifV0sIk91dHB1dCI6W3sibmFtZSI6Im1lc3NhZ2UiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVzdWx0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnB1dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXJyb3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbF9hYmlfdWludDMyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQzMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQzMiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbF9hYmlfdWludDMyX3JlYWRvbmx5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQzMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQzMiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX2FiaV91aW50NjQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5wdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX2FiaV91aW50NjRfcmVhZG9ubHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5wdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxfYWJpX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX3dpdGhfcmVmZXJlbmNlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVmYXVsdF92YWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxpdGVyYWwiLCJkYXRhIjoiQUExa1pXWmhkV3gwSUhaaGJIVmwiLCJ0eXBlIjoic3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ193aXRoX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFIcz0iLCJ0eXBlIjoidWludDY0In19XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9hYmkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsaXRlcmFsIiwiZGF0YSI6IkFBMWtaV1poZFd4MElIWmhiSFZsIiwidHlwZSI6InN0cmluZyJ9fV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWZhdWx0X3ZhbHVlX2Zyb21fZ2xvYmFsX3N0YXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ193aXRoX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoiZ2xvYmFsIiwiZGF0YSI6ImFXNTBNUT09IiwidHlwZSI6IkFWTVN0cmluZyJ9fV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWZhdWx0X3ZhbHVlX2Zyb21fbG9jYWxfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsb2NhbCIsImRhdGEiOiJiRzlqWVd4ZllubDBaWE14IiwidHlwZSI6IkFWTVN0cmluZyJ9fV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdHJ1Y3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IklucHV0IiwibmFtZSI6Im5hbWVfYWdlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6Ik91dHB1dCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9nbG9iYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9sb2NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2JveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCIsIk9wdEluIl0sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iLCJVcGRhdGVBcHBsaWNhdGlvbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIzOCwzMzldLCJlcnJvck1lc3NhZ2UiOiJDaGVjayBhcHAgaXMgZGVsZXRhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ5LDMxNF0sImVycm9yTWVzc2FnZSI6IkNoZWNrIGFwcCBpcyB1cGRhdGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjldLCJlcnJvck1lc3NhZ2UiOiJEZWxpYmVyYXRlIGVycm9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM0XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBub3QgcHJvdmlkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzVdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBub3QgcHJvdmlkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjhdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBub3QgcHJvdmlkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzksMzAxLDMyNiwzNTEsNDUyLDU1OCw1OTEsNjQ5LDcxMyw3NzgsODYyLDk3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NiwzMDgsMzMzLDM1OCw0NTksNTY1LDU5OCw2NTYsNzg1LDg2OSw5NzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5Nyw4ODEsOTY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg3LDQwMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQzMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNiw0MzAsNTA2LDUyNCw1NzksNjM3LDc2Miw3NzEsODQ2LDg1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBjb250cmFjdC5JbnB1dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxMl0sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5MF0sImVycm9yTWVzc2FnZSI6InVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTWlBNElGUk5VRXhmUkVWTVJWUkJRa3hGSUZSTlVFeGZWVkJFUVZSQlFreEZJRlJOVUV4ZlZrRk1WVVVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpU0dWc2JHOHNJQ0lnSWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBaU2hGZUdGdGNHeGxRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBek1nb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VETmpZVFZqWldJM0lEQjRNamN4WWpSbFpUa2dNSGd6TUdNMlpEVTRZU0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVjloWW1rb2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWkdWc1pYUmxYMkZpYVNoemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0p2Y0hSZmFXNG9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNWd1pHRjBaVjloWW1sZmNtOTFkR1ZBTlNCdFlXbHVYMlJsYkdWMFpWOWhZbWxmY205MWRHVkFOaUJ0WVdsdVgyOXdkRjlwYmw5eWIzVjBaVUEzQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCamJHRnpjeUJUZEdGMFpTaEZlR0Z0Y0d4bFFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1qZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBOR1F3WkdFd1pDQXdlR1l4TjJVNE1HRTFJREI0WlRFMk5UUm1NVFlnTUhnNE5UUXdOR1ZsWlNBd2VESmlZV00zWlRBNElEQjRNREV4WVRrMk5HWWdNSGd3WVRreVlUZ3haU0F3ZURBMVpURmlOREppSURCNE5UYzBZalUxWXpnZ01IZ3pOakF6TmpKbE9TQXdlRFEyWkRJeE1XRXpJREI0TUdObVkySmlNREFnTUhoa01HWXdZbUZtT0NBd2VESTBObUpsWWpneklEQjRZVFJqWmpoa1pXRWdNSGhqWldNeU9ETTBZU0F3ZUdFMFlqUmhNak13SUM4dklHMWxkR2h2WkNBaVpYSnliM0lvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5oYkd4ZllXSnBLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltTmhiR3hmWVdKcFgzVnBiblF6TWloMWFXNTBNeklwZFdsdWRETXlJaXdnYldWMGFHOWtJQ0pqWVd4c1gyRmlhVjkxYVc1ME16SmZjbVZoWkc5dWJIa29kV2x1ZERNeUtYVnBiblF6TWlJc0lHMWxkR2h2WkNBaVkyRnNiRjloWW1sZmRXbHVkRFkwS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5oYkd4ZllXSnBYM1ZwYm5RMk5GOXlaV0ZrYjI1c2VTaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKallXeHNYMkZpYVY5MGVHNG9jR0Y1TEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbU5oYkd4ZmQybDBhRjl5WldabGNtVnVZMlZ6S0hWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltUmxabUYxYkhSZmRtRnNkV1VvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaR1ZtWVhWc2RGOTJZV3gxWlY5cGJuUW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHVm1ZWFZzZEY5MllXeDFaVjltY205dFgyRmlhU2h6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSmtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZaMnh2WW1Gc1gzTjBZWFJsS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbVJsWm1GMWJIUmZkbUZzZFdWZlpuSnZiVjlzYjJOaGJGOXpkR0YwWlNoemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0p6ZEhKMVkzUnpLQ2h6ZEhKcGJtY3NkV2x1ZERZMEtTa29jM1J5YVc1bkxIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luTmxkRjluYkc5aVlXd29kV2x1ZERZMExIVnBiblEyTkN4emRISnBibWNzWW5sMFpWczBYU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmYkc5allXd29kV2x1ZERZMExIVnBiblEyTkN4emRISnBibWNzWW5sMFpWczBYU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmWW05NEtHSjVkR1ZiTkYwc2MzUnlhVzVuS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyVnljbTl5WDNKdmRYUmxRREV3SUdOaGJHeGZZV0pwSUdOaGJHeGZZV0pwWDNWcGJuUXpNaUJqWVd4c1gyRmlhVjkxYVc1ME16SmZjbVZoWkc5dWJIa2dZMkZzYkY5aFltbGZkV2x1ZERZMElHTmhiR3hmWVdKcFgzVnBiblEyTkY5eVpXRmtiMjVzZVNCallXeHNYMkZpYVY5MGVHNGdZMkZzYkY5M2FYUm9YM0psWm1WeVpXNWpaWE1nWkdWbVlYVnNkRjkyWVd4MVpTQmtaV1poZFd4MFgzWmhiSFZsWDJsdWRDQmtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZZV0pwSUdSbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5bmJHOWlZV3hmYzNSaGRHVWdaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMnh2WTJGc1gzTjBZWFJsSUhOMGNuVmpkSE1nYzJWMFgyZHNiMkpoYkNCelpYUmZiRzlqWVd3Z2MyVjBYMkp2ZUFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFETTNPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhSbEtFVjRZVzF3YkdWQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyVnljbTl5WDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1URXpDaUFnSUNBdkx5QmhjM05sY25RZ1JtRnNjMlVzSUNKRVpXeHBZbVZ5WVhSbElHVnljbTl5SWlBZ0l5QnViM0ZoT2lCUVZEQXhOU3dnUWpBeE1Rb2dJQ0FnWlhKeUlDOHZJRVJsYkdsaVpYSmhkR1VnWlhKeWIzSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNamc2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHVW9SWGhoYlhCc1pVRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1WkRVeU16QTBNQ0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjloWW1rb2MzUnlhVzVuS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVjloWW1rS0lDQWdJR1Z5Y2dvS2JXRnBibDl2Y0hSZmFXNWZjbTkxZEdWQU56b0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SlBjSFJKYmlKZEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFOXdkRWx1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWkdWc1pYUmxYMkZpYVY5eWIzVjBaVUEyT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQmtaV3hsZEdWZllXSnBDZ3B0WVdsdVgzVndaR0YwWlY5aFltbGZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklsVndaR0YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZaUIxY0dSaGRHVmZZV0pwQ2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBek1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJqYkdGemN5QlRkR0YwWlNoRmVHRnRjR3hsUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lITjNhWFJqYUNCdFlXbHVYMk55WldGMFpVQXpNeUJ0WVdsdVgyTnlaV0YwWlVBek15QnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNemNnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNM0lHMWhhVzVmZFhCa1lYUmxRRE0wSUcxaGFXNWZaR1ZzWlhSbFFETTFDaUFnSUNCbGNuSUtDbTFoYVc1ZlpHVnNaWFJsUURNMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdZWE56WlhKMElGUmxiWEJzWVhSbFZtRnlXMkp2YjJ4ZEtFUkZURVZVUVVKTVJWOVVSVTFRVEVGVVJWOU9RVTFGS1N3Z0lrTm9aV05ySUdGd2NDQnBjeUJrWld4bGRHRmliR1VpQ2lBZ0lDQnBiblJqSURRZ0x5OGdWRTFRVEY5RVJVeEZWRUZDVEVVS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdWamF5QmhjSEFnYVhNZ1pHVnNaWFJoWW14bENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncENpQWdJQ0JqWVd4c2MzVmlJR0YxZEdodmNtbDZaVjlqY21WaGRHOXlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnUUdGeVl6UXVZbUZ5WlcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFFETTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnWVhOelpYSjBJRlJsYlhCc1lYUmxWbUZ5VzJKdmIyeGRLRlZRUkVGVVFVSk1SVjlVUlUxUVRFRlVSVjlPUVUxRktTd2dJa05vWldOcklHRndjQ0JwY3lCMWNHUmhkR0ZpYkdVaUNpQWdJQ0JwYm5SaklEVWdMeThnVkUxUVRGOVZVRVJCVkVGQ1RFVUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHVmpheUJoY0hBZ2FYTWdkWEJrWVhSaFlteGxDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYzJWc1ppNWhkWFJvYjNKcGVtVmZZM0psWVhSdmNpZ3BDaUFnSUNCallXeHNjM1ZpSUdGMWRHaHZjbWw2WlY5amNtVmhkRzl5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxRRE16T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklFQmhjbU0wTG1KaGNtVnRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWl3Z1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlMQ0FpVDNCMFNXNGlYU2tLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QnpaV3htTG1GMWRHaHZjbWw2WlY5amNtVmhkRzl5S0NrS0lDQWdJR05oYkd4emRXSWdZWFYwYUc5eWFYcGxYMk55WldGMGIzSUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamc0Q2lBZ0lDQXZMeUJ6Wld4bUxuWmhiSFZsSUQwZ1ZHVnRjR3hoZEdWV1lYSmJWVWx1ZERZMFhTaFdRVXhWUlY5VVJVMVFURUZVUlY5T1FVMUZLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSjJZV3gxWlNJS0lDQWdJR2x1ZEdNZ05pQXZMeUJVVFZCTVgxWkJURlZGQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklFQmhjbU0wTG1KaGNtVnRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWl3Z1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlMQ0FpVDNCMFNXNGlYU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNVRkR0YwWlM1amNtVmhkR1ZmWVdKcFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFgyRmlhVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJ6Wld4bUxtRjFkR2h2Y21sNlpWOWpjbVZoZEc5eUtDa0tJQ0FnSUdOaGJHeHpkV0lnWVhWMGFHOXlhWHBsWDJOeVpXRjBiM0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNVRkR0YwWlM1MWNHUmhkR1ZmWVdKcFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgyRmlhVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG81TndvZ0lDQWdMeThnYzJWc1ppNWhkWFJvYjNKcGVtVmZZM0psWVhSdmNpZ3BDaUFnSUNCallXeHNjM1ZpSUdGMWRHaHZjbWw2WlY5amNtVmhkRzl5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSbGJYQnNZWFJsVm1GeVcySnZiMnhkS0ZWUVJFRlVRVUpNUlY5VVJVMVFURUZVUlY5T1FVMUZLU3dnSWtOb1pXTnJJR0Z3Y0NCcGN5QjFjR1JoZEdGaWJHVWlDaUFnSUNCcGJuUmpJRFVnTHk4Z1ZFMVFURjlWVUVSQlZFRkNURVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR1ZqYXlCaGNIQWdhWE1nZFhCa1lYUmhZbXhsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvNU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpWY0dSaGRHVkJjSEJzYVdOaGRHbHZiaUpkS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMbE4wWVhSbExtUmxiR1YwWlY5aFltbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVmZZV0pwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1ETUtJQ0FnSUM4dklITmxiR1l1WVhWMGFHOXlhWHBsWDJOeVpXRjBiM0lvS1FvZ0lDQWdZMkZzYkhOMVlpQmhkWFJvYjNKcGVtVmZZM0psWVhSdmNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdWR1Z0Y0d4aGRHVldZWEpiWW05dmJGMG9SRVZNUlZSQlFreEZYMVJGVFZCTVFWUkZYMDVCVFVVcExDQWlRMmhsWTJzZ1lYQndJR2x6SUdSbGJHVjBZV0pzWlNJS0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgwUkZURVZVUVVKTVJRb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1pXTnJJR0Z3Y0NCcGN5QmtaV3hsZEdGaWJHVUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExsTjBZWFJsTG1OaGJHeGZZV0pwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnNiRjloWW1rNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hNVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV4TndvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lTR1ZzYkc4c0lDSXBJQ3NnZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lraGxiR3h2TENBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMbE4wWVhSbExtTmhiR3hmWVdKcFgzVnBiblF6TWx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhiR3hmWVdKcFgzVnBiblF6TWpvS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXhPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5Rek1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGxOMFlYUmxMbU5oYkd4ZllXSnBYM1ZwYm5Rek1sOXlaV0ZrYjI1c2VWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oYkd4ZllXSnBYM1ZwYm5Rek1sOXlaV0ZrYjI1c2VUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV5TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5Rek1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGxOMFlYUmxMbU5oYkd4ZllXSnBYM1ZwYm5RMk5GdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oYkd4ZllXSnBYM1ZwYm5RMk5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV5TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUXVVM1JoZEdVdVkyRnNiRjloWW1sZmRXbHVkRFkwWDNKbFlXUnZibXg1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnNiRjloWW1sZmRXbHVkRFkwWDNKbFlXUnZibXg1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkQzVUZEdGMFpTNWpZV3hzWDJGaWFWOTBlRzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwallXeHNYMkZpYVY5MGVHNDZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlRaVzUwSUNJcElDc2djMlZzWmk1cGRHOWhLSFI0Ymk1aGJXOTFiblFwSUNzZ1UzUnlhVzVuS0NJdUlDSXBJQ3NnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWTJGc2JITjFZaUJwZEc5aENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxObGJuUWdJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaTRnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV6TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMbE4wWVhSbExtTmhiR3hmZDJsMGFGOXlaV1psY21WdVkyVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGc2JGOTNhWFJvWDNKbFptVnlaVzVqWlhNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRReENpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUXNJQ0poYzNObGRDQnViM1FnY0hKdmRtbGtaV1FpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0J1YjNRZ2NISnZkbWxrWldRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRTBNZ29nSUNBZ0x5OGdZWE56WlhKMElHRmpZMjkxYm5Rc0lDSmhZMk52ZFc1MElHNXZkQ0J3Y205MmFXUmxaQ0lLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ2JtOTBJSEJ5YjNacFpHVmtDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TkRNS0lDQWdJQzh2SUdGemMyVnlkQ0JoY0hCc2FXTmhkR2x2Yml3Z0ltRndjR3hwWTJGMGFXOXVJRzV2ZENCd2NtOTJhV1JsWkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCdWIzUWdjSEp2ZG1sa1pXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMbE4wWVhSbExtUmxabUYxYkhSZmRtRnNkV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXWmhkV3gwWDNaaGJIVmxPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRRMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2daR1ZtWVhWc2RGOWhjbWR6UFhzaVlYSm5YM2RwZEdoZlpHVm1ZWFZzZENJNklHRnlZelF1VTNSeWFXNW5LQ0prWldaaGRXeDBJSFpoYkhWbElpbDlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGxOMFlYUmxMbVJsWm1GMWJIUmZkbUZzZFdWZmFXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWbVlYVnNkRjkyWVd4MVpWOXBiblE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxMQ0JrWldaaGRXeDBYMkZ5WjNNOWV5SmhjbWRmZDJsMGFGOWtaV1poZFd4MElqb2dZWEpqTkM1VlNXNTBOalFvTVRJektYMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUXVVM1JoZEdVdVpHVm1ZWFZzZEY5MllXeDFaVjltY205dFgyRmlhVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5aFltazZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TlRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmtaV1poZFd4MFgyRnlaM005ZXlKaGNtZGZkMmwwYUY5a1pXWmhkV3gwSWpvZ1lYSmpOQzVUZEhKcGJtY29JbVJsWm1GMWJIUWdkbUZzZFdVaUtYMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lrRkNTU3dnSWlrZ0t5QmhjbWRmZDJsMGFGOWtaV1poZFd4MENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd05UUXhOREkwT1RKak1qQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQ0F2THlCdmJpQmxjbkp2Y2pvZ2JXRjRJR0Z5Y21GNUlHeGxibWQwYUNCbGVHTmxaV1JsWkFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UVTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU3dnWkdWbVlYVnNkRjloY21kelBYc2lZWEpuWDNkcGRHaGZaR1ZtWVhWc2RDSTZJR0Z5WXpRdVUzUnlhVzVuS0NKa1pXWmhkV3gwSUhaaGJIVmxJaWw5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMbE4wWVhSbExtUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOW5iRzlpWVd4ZmMzUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZloyeHZZbUZzWDNOMFlYUmxPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2daR1ZtWVhWc2RGOWhjbWR6UFhzaVlYSm5YM2RwZEdoZlpHVm1ZWFZzZENJNklDSnBiblF4SW4wcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVUzUmhkR1V1WkdWbVlYVnNkRjkyWVd4MVpWOW1jbTl0WDJ4dlkyRnNYM04wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMnh2WTJGc1gzTjBZWFJsT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU3dnWkdWbVlYVnNkRjloY21kelBYc2lZWEpuWDNkcGRHaGZaR1ZtWVhWc2RDSTZJQ0pzYjJOaGJGOWllWFJsY3pFaWZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE5qUUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbE4wY21sdVp5aFRkSEpwYm1jb0lreHZZMkZzSUhOMFlYUmxMQ0FpS1NBcklHRnlaMTkzYVhSb1gyUmxabUYxYkhRcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWt4dlkyRnNJSE4wWVhSbExDQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TmpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmtaV1poZFd4MFgyRnlaM005ZXlKaGNtZGZkMmwwYUY5a1pXWmhkV3gwSWpvZ0lteHZZMkZzWDJKNWRHVnpNU0o5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMbE4wWVhSbExuTjBjblZqZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkSEoxWTNSek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVFkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNQ0J2WmlBb0tHeGxiaXQxZEdZNFcxMHBMSFZwYm5RMk5Da0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCamIyNTBjbUZqZEM1SmJuQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRZNENpQWdJQ0F2THlCeVpYUjFjbTRnVDNWMGNIVjBLR0Z5WXpRdVUzUnlhVzVuS0ZOMGNtbHVaeWdpU0dWc2JHOHNJQ0lwSUNzZ2JtRnRaVjloWjJVdWJtRnRaUzV1WVhScGRtVXBMQ0JoY21NMExsVkpiblEyTkNodVlXMWxYMkZuWlM1aFoyVXVibUYwYVhabElDb2dNaWtwQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlTR1ZzYkc4c0lDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TUdFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TmpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExsTjBZWFJsTG5ObGRGOW5iRzlpWVd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmWjJ4dlltRnNPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRjd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVGMwQ2lBZ0lDQXZMeUJ6Wld4bUxtbHVkREVnUFNCcGJuUXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltbHVkREVpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TnpVS0lDQWdJQzh2SUhObGJHWXVhVzUwTWlBOUlHbHVkRElLSUNBZ0lIQjFjMmhpZVhSbGN5QWlhVzUwTWlJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFM05nb2dJQ0FnTHk4Z2MyVnNaaTVpZVhSbGN6RWdQU0JpZVhSbGN6RXVZbmwwWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUFpWW5sMFpYTXhJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVGMzQ2lBZ0lDQXZMeUJ6Wld4bUxtSjVkR1Z6TWlBOUlHSjVkR1Z6TWk1aWVYUmxjd29nSUNBZ2NIVnphR0o1ZEdWeklDSmllWFJsY3pJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVGN3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEM1VGRHRjBaUzV6WlhSZmJHOWpZV3hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZiRzlqWVd3NkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRFErQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE9ETUtJQ0FnSUM4dklITmxiR1l1Ykc5allXeGZhVzUwTVZ0VWVHNHVjMlZ1WkdWeVhTQTlJR2x1ZERFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QWliRzlqWVd4ZmFXNTBNU0lLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVGcwQ2lBZ0lDQXZMeUJ6Wld4bUxteHZZMkZzWDJsdWRESmJWSGh1TG5ObGJtUmxjbDBnUFNCcGJuUXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW14dlkyRnNYMmx1ZERJaUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFNE5Rb2dJQ0FnTHk4Z2MyVnNaaTVzYjJOaGJGOWllWFJsY3pGYlZIaHVMbk5sYm1SbGNsMGdQU0JpZVhSbGN6RXVZbmwwWlhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QWliRzlqWVd4ZllubDBaWE14SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94T0RZS0lDQWdJQzh2SUhObGJHWXViRzlqWVd4ZllubDBaWE15VzFSNGJpNXpaVzVrWlhKZElEMGdZbmwwWlhNeUxtSjVkR1Z6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lteHZZMkZzWDJKNWRHVnpNaUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVGM1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEM1VGRHRjBaUzV6WlhSZlltOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgySnZlRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFNE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1Ua3dDaUFnSUNBdkx5QnpaV3htTG1KdmVGdHVZVzFsWFNBOUlIWmhiSFZsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94T0RnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExrSmhjMlZCVWtNMFEyOXVkSEpoWTNRdVlYVjBhRzl5YVhwbFgyTnlaV0YwYjNJb0tTQXRQaUIyYjJsa09ncGhkWFJvYjNKcGVtVmZZM0psWVhSdmNqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpZFc1aGRYUm9iM0pwZW1Wa0lnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIVnVZWFYwYUc5eWFYcGxaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdZMjl1ZEhKaFkzUXVRbUZ6WlVGU1F6UkRiMjUwY21GamRDNXBkRzloS0drNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtbDBiMkU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvek1DMHpNUW9nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVLSUNBZ0lDOHZJR1JsWmlCcGRHOWhLSE5sYkdZc0lHazZJRlZKYm5RMk5Da2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pNZ29nSUNBZ0x5OGdhV1lnYVNBOVBTQlZTVzUwTmpRb01DazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdWVpQnBkRzloWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaU1DSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqQWlDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21sMGIyRmZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvek5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUNoelpXeG1MbWwwYjJFb2FTQXZMeUJWU1c1ME5qUW9NVEFwS1NCcFppQW9hU0F2THlCVlNXNTBOalFvTVRBcEtTQStJRlZKYm5RMk5DZ3dLU0JsYkhObElGTjBjbWx1WnlnaUlpa3BJQ3NnVTNSeWFXNW5MbVp5YjIxZllubDBaWE1vQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUM4S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmllaUJwZEc5aFgzUmxjbTVoY25sZlptRnNjMlZBTkFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHTmhiR3h6ZFdJZ2FYUnZZUW9LYVhSdllWOTBaWEp1WVhKNVgyMWxjbWRsUURVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdVM1J5YVc1bktDSXdNVEl6TkRVMk56ZzVJaWt1WW5sMFpYTmJhU0FsSUZWSmJuUTJOQ2d4TUNsZENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lDVUtJQ0FnSUhCMWMyaGllWFJsY3lBaU1ERXlNelExTmpjNE9TSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpVdE16Y0tJQ0FnSUM4dklISmxkSFZ5YmlBb2MyVnNaaTVwZEc5aEtHa2dMeThnVlVsdWREWTBLREV3S1NrZ2FXWWdLR2tnTHk4Z1ZVbHVkRFkwS0RFd0tTa2dQaUJWU1c1ME5qUW9NQ2tnWld4elpTQlRkSEpwYm1jb0lpSXBLU0FySUZOMGNtbHVaeTVtY205dFgySjVkR1Z6S0FvZ0lDQWdMeThnSUNBZ0lGTjBjbWx1WnlnaU1ERXlNelExTmpjNE9TSXBMbUo1ZEdWelcya2dKU0JWU1c1ME5qUW9NVEFwWFFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWwwYjJGZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklISmxkSFZ5YmlBb2MyVnNaaTVwZEc5aEtHa2dMeThnVlVsdWREWTBLREV3S1NrZ2FXWWdLR2tnTHk4Z1ZVbHVkRFkwS0RFd0tTa2dQaUJWU1c1ME5qUW9NQ2tnWld4elpTQlRkSEpwYm1jb0lpSXBLU0FySUZOMGNtbHVaeTVtY205dFgySjVkR1Z6S0FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpSWdvZ0lDQWdZaUJwZEc5aFgzUmxjbTVoY25sZmJXVnlaMlZBTlFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUhBUUFDQ0FBQUFDWURCQlVmZkhVSFNHVnNiRzhzSUFBeEcwRUEwNElEQkR5bHpyY0VKeHRPNlFRd3h0V0tOaG9BamdNQXF3Q2ZBSmN4R1JSRU1SaEJBSUNDRVFSRTBOb05CUEYrZ0tVRTRXVlBGZ1NGUUU3dUJDdXNmZ2dFQVJxV1R3UUtrcWdlQkFYaHRDc0VWMHRWeUFRMkEyTHBCRWJTRWFNRURQeTdBQVRROExyNEJDUnI2NE1FcE0rTjZnVE93b05LQktTMG9qQTJHZ0NPRVFBQkFMSUEwd0RpQVBFQS93RU5BVXNCZ1FHVUFhSUJ6Z0hjQWdzQ1N3S2ZBeFFBQUlBRW5WSXdRRFlhQUk0QkFGc0FNUmtpRWpFWUVFTXhHWUVGRWpFWUVFUkNBSFV4R1lFRUVqRVlFRVJDQUZBeEdZMEdBQmNBRi8vQS84QUFEQUFCQURFWVJDRUVSSWdDNXlKRE1SaEVJUVZFaUFMY0lrTXhHQlJFaUFMVGdBVjJZV3gxWlNFR1p5SkROaG9CU1NOWkpBaExBUlVTUklnQ3R5aE1VTEFpUXpZYUFVa2pXU1FJU3dFVkVrU0lBcUVoQlVRb1RGQ3dJa00yR2dGSkkxa2tDRXNCRlJKRWlBS0lJUVJFS0V4UXNDSkROaG9CU1NOWkpBaExBUlVTUkZjQ0FDbE1VRWtWRmxjR0FreFFLRXhRc0NKRE5ob0JTUldCQkJKRUtFeFFzQ0pETmhvQlNSV0JCQkpFS0V4UXNDSkROaG9CU1JVbEVrUW9URkN3SWtNMkdnRkpGU1VTUkNoTVVMQWlRekVXSWdsSk9CQWlFa1EyR2dGSkkxa2tDRXNCRlJKRVZ3SUFURGdJaUFJTGdBVlRaVzUwSUV4UWdBSXVJRkJNVUVrVkZsY0dBa3hRS0V4UXNDSkROaG9CU1JVbEVrUVhOaG9DU1JXQklCSkVOaG9EU1JVbEVrUVhUd0pFTWdOUEFoTkVSSUFNRlI5OGRRQUFBQUFBQUFBQnNDSkROaG9CU1NOWkpBaExBUlVTUkNoTVVMQWlRellhQVVrVkpSSkVLRXhRc0NKRE5ob0JTU05aSkFoTEFSVVNSRmNDQUlBSEFBVkJRa2tzSUV4UVNWY0NBQlVXVndZQ1hBQW9URkN3SWtNMkdnRkpGU1VTUkNoTVVMQWlRellhQVVraldTUUlTd0VWRWtSWEFnQ0FEVXh2WTJGc0lITjBZWFJsTENCTVVFa1ZGbGNHQWt4UUtFeFFzQ0pETmhvQlNSVkxBU05aU1lFS0VrUkxBa3hMQWxKSkkxbUJEQWhQQWhKRVZ3SUFLVXhRU1JVV1Z3WUNURkJNSkZza0N4YUFBZ0FLVEZCTVVDaE1VTEFpUXpZYUFVa1ZKUkpFRnpZYUFra1ZKUkpFRnpZYUEwa2pXU1FJU3dFVkVrUlhBZ0EyR2dSSkZZRUVFa1NBQkdsdWRERlBCR2VBQkdsdWRESlBBMmVBQm1KNWRHVnpNVThDWjRBR1lubDBaWE15VEdjaVF6WWFBVWtWSlJKRUZ6WWFBa2tWSlJKRUZ6WWFBMGtqV1NRSVN3RVZFa1JYQWdBMkdnUkpGWUVFRWtReEFJQUtiRzlqWVd4ZmFXNTBNVThGWmpFQWdBcHNiMk5oYkY5cGJuUXlUd1JtTVFDQURHeHZZMkZzWDJKNWRHVnpNVThEWmpFQWdBeHNiMk5oYkY5aWVYUmxjekpQQW1ZaVF6WWFBVWtWZ1FRU1JEWWFBa2tqV1NRSVN3RVZFa1JMQWJ4SXZ5SkRNUUF5Q1JKRWlZb0JBU3FMLzBBQUJZQUJNRXlKaS8rQkNncEpqQUJCQUJ5TEFJai80b3YvZ1FvWWdBb3dNVEl6TkRVMk56ZzVUQ0pZVUV5SktrTC81UT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnsiREVMRVRBQkxFIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH0sIlVQREFUQUJMRSI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9LCJWQUxVRSI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
