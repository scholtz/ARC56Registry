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

namespace Arc56.Generated.algorandfoundation.algokit_client_generator_py.State_af18f32b
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSW5wdXQiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFnZSIsInR5cGUiOiJ1aW50NjQifV0sIk91dHB1dCI6W3sibmFtZSI6Im1lc3NhZ2UiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVzdWx0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnB1dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXJyb3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbF9hYmlfdHhuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxfd2l0aF9yZWZlcmVuY2VzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWZhdWx0X3ZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ193aXRoX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQTFrWldaaGRXeDBJSFpoYkhWbCIsInR5cGUiOiJzdHJpbmcifX1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVmYXVsdF92YWx1ZV9pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsaXRlcmFsIiwiZGF0YSI6IkFBQUFBQUFBQUhzPSIsInR5cGUiOiJ1aW50NjQifX1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVmYXVsdF92YWx1ZV9mcm9tX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxpdGVyYWwiLCJkYXRhIjoiQUExa1pXWmhkV3gwSUhaaGJIVmwiLCJ0eXBlIjoic3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9nbG9iYWxfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJnbG9iYWwiLCJkYXRhIjoiYVc1ME1RPT0iLCJ0eXBlIjoiQVZNU3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9sb2NhbF9zdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxvY2FsIiwiZGF0YSI6ImJHOWpZV3hmWW5sMFpYTXgiLCJ0eXBlIjoiQVZNU3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0cnVjdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZyx1aW50NjQpIiwic3RydWN0IjoiSW5wdXQiLCJuYW1lIjoibmFtZV9hZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyx1aW50NjQpIiwic3RydWN0IjoiT3V0cHV0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2dsb2JhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2xvY2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludDEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ5dGVzMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ5dGVzMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjoyLCJieXRlcyI6M319LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIiwiT3B0SW4iXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiIsIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjEwLDMxMV0sImVycm9yTWVzc2FnZSI6IkNoZWNrIGFwcCBpcyBkZWxldGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjEsMjg2XSwiZXJyb3JNZXNzYWdlIjoiQ2hlY2sgYXBwIGlzIHVwZGF0YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MV0sImVycm9yTWVzc2FnZSI6IkRlbGliZXJhdGUgZXJyb3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDhdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IG5vdCBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0OV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIG5vdCBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Ml0sImVycm9yTWVzc2FnZSI6ImFzc2V0IG5vdCBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MSwyNzMsMjk4LDMyMywzNjYsNDcyLDUwNSw1NjYsNjMwLDY5NSw3NzksODg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU4LDI4MCwzMDUsMzMwLDM3Myw0NzksNTEzLDU3Myw3MDIsNzg2LDg5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE0LDc5OCw4ODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjAsNDM4LDQ5Myw1NTQsNjc5LDY4OCw3NjMsNzcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGV4YW1wbGVzLnNtYXJ0X2NvbnRyYWN0cy5zdGF0ZS5jb250cmFjdC5JbnB1dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTA3XSwiZXJyb3JNZXNzYWdlIjoidW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNaUE0SUZSTlVFeGZSRVZNUlZSQlFreEZJRlJOVUV4ZlZWQkVRVlJCUWt4RklGUk5VRXhmVmtGTVZVVUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQWlTR1ZzYkc4c0lDSWdJaUlLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdZMnhoYzNNZ1UzUmhkR1VvUlhoaGJYQnNaVUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1qZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3pZMkUxWTJWaU55QXdlREkzTVdJMFpXVTVJREI0TXpCak5tUTFPR0VnTHk4Z2JXVjBhRzlrSUNKMWNHUmhkR1ZmWVdKcEtITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1SbGJHVjBaVjloWW1rb2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpYjNCMFgybHVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5MWNHUmhkR1ZmWVdKcFgzSnZkWFJsUURVZ2JXRnBibDlrWld4bGRHVmZZV0pwWDNKdmRYUmxRRFlnYldGcGJsOXZjSFJmYVc1ZmNtOTFkR1ZBTndvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGc2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNelFLSUNBZ0lDOHZJR05zWVhOeklGTjBZWFJsS0VWNFlXMXdiR1ZCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF5TkFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURRMFpEQmtZVEJrSURCNFpqRTNaVGd3WVRVZ01IZ3dZVGt5WVRneFpTQXdlREExWlRGaU5ESmlJREI0TlRjMFlqVTFZemdnTUhnek5qQXpOakpsT1NBd2VEUTJaREl4TVdFeklEQjRNR05tWTJKaU1EQWdNSGhrTUdZd1ltRm1PQ0F3ZURJME5tSmxZamd6SURCNFlUUmpaamhrWldFZ01IaGpaV015T0RNMFlTQXdlR0UwWWpSaE1qTXdJQzh2SUcxbGRHaHZaQ0FpWlhKeWIzSW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTmhiR3hmWVdKcEtITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1OaGJHeGZZV0pwWDNSNGJpaHdZWGtzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMkZzYkY5M2FYUm9YM0psWm1WeVpXNWpaWE1vZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHVm1ZWFZzZEY5MllXeDFaU2h6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSmtaV1poZFd4MFgzWmhiSFZsWDJsdWRDaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKa1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZllXSnBLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOW5iRzlpWVd4ZmMzUmhkR1VvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMnh2WTJGc1gzTjBZWFJsS0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbk4wY25WamRITW9LSE4wY21sdVp5eDFhVzUwTmpRcEtTaHpkSEpwYm1jc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWMyVjBYMmRzYjJKaGJDaDFhVzUwTmpRc2RXbHVkRFkwTEhOMGNtbHVaeXhpZVhSbFd6UmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjlzYjJOaGJDaDFhVzUwTmpRc2RXbHVkRFkwTEhOMGNtbHVaeXhpZVhSbFd6UmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjlpYjNnb1lubDBaVnMwWFN4emRISnBibWNwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlpYSnliM0pmY205MWRHVkFNVEFnWTJGc2JGOWhZbWtnWTJGc2JGOWhZbWxmZEhodUlHTmhiR3hmZDJsMGFGOXlaV1psY21WdVkyVnpJR1JsWm1GMWJIUmZkbUZzZFdVZ1pHVm1ZWFZzZEY5MllXeDFaVjlwYm5RZ1pHVm1ZWFZzZEY5MllXeDFaVjltY205dFgyRmlhU0JrWldaaGRXeDBYM1poYkhWbFgyWnliMjFmWjJ4dlltRnNYM04wWVhSbElHUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOXNiMk5oYkY5emRHRjBaU0J6ZEhKMVkzUnpJSE5sZEY5bmJHOWlZV3dnYzJWMFgyeHZZMkZzSUhObGRGOWliM2dLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek16b0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHVW9SWGhoYlhCc1pVRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQmxjbklLQ20xaGFXNWZaWEp5YjNKZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0JHWVd4elpTd2dJa1JsYkdsaVpYSmhkR1VnWlhKeWIzSWlJQ0FqSUc1dmNXRTZJRkJVTURFMUxDQkNNREV4Q2lBZ0lDQmxjbklnTHk4Z1JHVnNhV0psY21GMFpTQmxjbkp2Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeU5Eb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHVW9SWGhoYlhCc1pVRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1WkRVeU16QTBNQ0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjloWW1rb2MzUnlhVzVuS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVjloWW1rS0lDQWdJR1Z5Y2dvS2JXRnBibDl2Y0hSZmFXNWZjbTkxZEdWQU56b0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpQY0hSSmJpSmRLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTl3ZEVsdUNpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpHVnNaWFJsWDJGaWFWOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pjMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCa1pXeGxkR1ZmWVdKcENncHRZV2x1WDNWd1pHRjBaVjloWW1sZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SlZjR1JoZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUZWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnZFhCa1lYUmxYMkZpYVFvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1qZzZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklHTnNZWE56SUZOMFlYUmxLRVY0WVcxd2JHVkJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYzNkcGRHTm9JRzFoYVc1ZlkzSmxZWFJsUURJNUlHMWhhVzVmWTNKbFlYUmxRREk1SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek15QnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNek1nYldGcGJsOTFjR1JoZEdWQU16QWdiV0ZwYmw5a1pXeGxkR1ZBTXpFS0lDQWdJR1Z5Y2dvS2JXRnBibDlrWld4bGRHVkFNekU2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJoYzNObGNuUWdWR1Z0Y0d4aGRHVldZWEpiWW05dmJGMG9SRVZNUlZSQlFreEZYMVJGVFZCTVFWUkZYMDVCVFVVcExDQWlRMmhsWTJzZ1lYQndJR2x6SUdSbGJHVjBZV0pzWlNJS0lDQWdJR2x1ZEdNZ05DQXZMeUJVVFZCTVgwUkZURVZVUVVKTVJRb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1pXTnJJR0Z3Y0NCcGN5QmtaV3hsZEdGaWJHVUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCelpXeG1MbUYxZEdodmNtbDZaVjlqY21WaGRHOXlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWQU16QTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmhjM05sY25RZ1ZHVnRjR3hoZEdWV1lYSmJZbTl2YkYwb1ZWQkVRVlJCUWt4RlgxUkZUVkJNUVZSRlgwNUJUVVVwTENBaVEyaGxZMnNnWVhCd0lHbHpJSFZ3WkdGMFlXSnNaU0lLSUNBZ0lHbHVkR01nTlNBdkx5QlVUVkJNWDFWUVJFRlVRVUpNUlFvZ0lDQWdZWE56WlhKMElDOHZJRU5vWldOcklHRndjQ0JwY3lCMWNHUmhkR0ZpYkdVS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwyTnZiblJ5WVdOMExuQjVPakkyQ2lBZ0lDQXZMeUJ6Wld4bUxtRjFkR2h2Y21sNlpWOWpjbVZoZEc5eUtDa0tJQ0FnSUdOaGJHeHpkV0lnWVhWMGFHOXlhWHBsWDJOeVpXRjBiM0lLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJOdmJuUnlZV04wTG5CNU9qSXpDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZBTWprNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaXdnWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaUxDQWlUM0IwU1c0aVhTa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncENpQWdJQ0JqWVd4c2MzVmlJR0YxZEdodmNtbDZaVjlqY21WaGRHOXlDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklITmxiR1l1ZG1Gc2RXVWdQU0JVWlcxd2JHRjBaVlpoY2x0VlNXNTBOalJkS0ZaQlRGVkZYMVJGVFZCTVFWUkZYMDVCVFVVcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5aaGJIVmxJZ29nSUNBZ2FXNTBZeUEySUM4dklGUk5VRXhmVmtGTVZVVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklFQmhjbU0wTG1KaGNtVnRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWl3Z1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlMQ0FpVDNCMFNXNGlYU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1VTNSaGRHVXVZM0psWVhSbFgyRmlhVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVjloWW1rNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCelpXeG1MbUYxZEdodmNtbDZaVjlqY21WaGRHOXlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlYUmxMbU52Ym5SeVlXTjBMbE4wWVhSbExuVndaR0YwWlY5aFltbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVmZZV0pwT2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklsVndaR0YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TnpJS0lDQWdJQzh2SUhObGJHWXVZWFYwYUc5eWFYcGxYMk55WldGMGIzSW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJoYzNObGNuUWdWR1Z0Y0d4aGRHVldZWEpiWW05dmJGMG9WVkJFUVZSQlFreEZYMVJGVFZCTVFWUkZYMDVCVFVVcExDQWlRMmhsWTJzZ1lYQndJR2x6SUhWd1pHRjBZV0pzWlNJS0lDQWdJR2x1ZEdNZ05TQXZMeUJVVFZCTVgxVlFSRUZVUVVKTVJRb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1pXTnJJR0Z3Y0NCcGN5QjFjR1JoZEdGaWJHVUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvM01Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpWY0dSaGRHVkJjSEJzYVdOaGRHbHZiaUpkS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1Y0WVcxd2JHVnpMbk50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0YwWlM1amIyNTBjbUZqZEM1VGRHRjBaUzVrWld4bGRHVmZZV0pwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsWDJGaWFUb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpFWld4bGRHVkJjSEJzYVdOaGRHbHZiaUpkS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnpaV3htTG1GMWRHaHZjbWw2WlY5amNtVmhkRzl5S0NrS0lDQWdJR05oYkd4emRXSWdZWFYwYUc5eWFYcGxYMk55WldGMGIzSUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSbGJYQnNZWFJsVm1GeVcySnZiMnhkS0VSRlRFVlVRVUpNUlY5VVJVMVFURUZVUlY5T1FVMUZLU3dnSWtOb1pXTnJJR0Z3Y0NCcGN5QmtaV3hsZEdGaWJHVWlDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlFUlV4RlZFRkNURVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR1ZqYXlCaGNIQWdhWE1nWkdWc1pYUmhZbXhsQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGRHVXVZMjl1ZEhKaFkzUXVVM1JoZEdVdVkyRnNiRjloWW1sYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hzWDJGaWFUb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSklaV3hzYnl3Z0lpa2dLeUIyWVd4MVpRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVNHVnNiRzhzSUNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVhSbExtTnZiblJ5WVdOMExsTjBZWFJsTG1OaGJHeGZZV0pwWDNSNGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oYkd4ZllXSnBYM1I0YmpvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JbE5sYm5RZ0lpa2dLeUJ6Wld4bUxtbDBiMkVvZEhodUxtRnRiM1Z1ZENrZ0t5QlRkSEpwYm1jb0lpNGdJaWtnS3lCMllXeDFaUW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCallXeHNjM1ZpSUdsMGIyRUtJQ0FnSUhCMWMyaGllWFJsY3lBaVUyVnVkQ0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpTGlBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlYUmxMbU52Ym5SeVlXTjBMbE4wWVhSbExtTmhiR3hmZDJsMGFGOXlaV1psY21WdVkyVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGc2JGOTNhWFJvWDNKbFptVnlaVzVqWlhNNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2T1RnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnWVhOelpYSjBJR0Z6YzJWMExDQWlZWE56WlhRZ2JtOTBJSEJ5YjNacFpHVmtJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdibTkwSUhCeWIzWnBaR1ZrQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV05qYjNWdWRDd2dJbUZqWTI5MWJuUWdibTkwSUhCeWIzWnBaR1ZrSWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQnViM1FnY0hKdmRtbGtaV1FLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjSEJzYVdOaGRHbHZiaXdnSW1Gd2NHeHBZMkYwYVc5dUlHNXZkQ0J3Y205MmFXUmxaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJ1YjNRZ2NISnZkbWxrWldRS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1Y0WVcxd2JHVnpMbk50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0YwWlM1amIyNTBjbUZqZEM1VGRHRjBaUzVrWldaaGRXeDBYM1poYkhWbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZtWVhWc2RGOTJZV3gxWlRvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmtaV1poZFd4MFgyRnlaM005ZXlKaGNtZGZkMmwwYUY5a1pXWmhkV3gwSWpvZ1lYSmpOQzVUZEhKcGJtY29JbVJsWm1GMWJIUWdkbUZzZFdVaUtYMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVhSbExtTnZiblJ5WVdOMExsTjBZWFJsTG1SbFptRjFiSFJmZG1Gc2RXVmZhVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVm1ZWFZzZEY5MllXeDFaVjlwYm5RNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRBNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2daR1ZtWVhWc2RGOWhjbWR6UFhzaVlYSm5YM2RwZEdoZlpHVm1ZWFZzZENJNklHRnlZelF1VlVsdWREWTBLREV5TXlsOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHVjRZVzF3YkdWekxuTnRZWEowWDJOdmJuUnlZV04wY3k1emRHRjBaUzVqYjI1MGNtRmpkQzVUZEdGMFpTNWtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZZV0pwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVm1ZWFZzZEY5MllXeDFaVjltY205dFgyRmlhVG9LSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsTENCa1pXWmhkV3gwWDJGeVozTTlleUpoY21kZmQybDBhRjlrWldaaGRXeDBJam9nWVhKak5DNVRkSEpwYm1jb0ltUmxabUYxYkhRZ2RtRnNkV1VpS1gwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lrRkNTU3dnSWlrZ0t5QmhjbWRmZDJsMGFGOWtaV1poZFd4MENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1URTFDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKQlFra3NJQ0lwSUNzZ1lYSm5YM2RwZEdoZlpHVm1ZWFZzZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd05UUXhOREkwT1RKak1qQUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFeE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXNJR1JsWm1GMWJIUmZZWEpuY3oxN0ltRnlaMTkzYVhSb1gyUmxabUYxYkhRaU9pQmhjbU0wTGxOMGNtbHVaeWdpWkdWbVlYVnNkQ0IyWVd4MVpTSXBmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1VTNSaGRHVXVaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMmRzYjJKaGJGOXpkR0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOW5iRzlpWVd4ZmMzUmhkR1U2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlN3Z1pHVm1ZWFZzZEY5aGNtZHpQWHNpWVhKblgzZHBkR2hmWkdWbVlYVnNkQ0k2SUNKcGJuUXhJbjBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVhSbExtTnZiblJ5WVdOMExsTjBZWFJsTG1SbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5c2IyTmhiRjl6ZEdGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsWm1GMWJIUmZkbUZzZFdWZlpuSnZiVjlzYjJOaGJGOXpkR0YwWlRvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TWpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmtaV1poZFd4MFgyRnlaM005ZXlKaGNtZGZkMmwwYUY5a1pXWmhkV3gwSWpvZ0lteHZZMkZzWDJKNWRHVnpNU0o5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbE4wY21sdVp5aFRkSEpwYm1jb0lreHZZMkZzSUhOMFlYUmxMQ0FpS1NBcklHRnlaMTkzYVhSb1gyUmxabUYxYkhRcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWt4dlkyRnNJSE4wWVhSbExDQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU3dnWkdWbVlYVnNkRjloY21kelBYc2lZWEpuWDNkcGRHaGZaR1ZtWVhWc2RDSTZJQ0pzYjJOaGJGOWllWFJsY3pFaWZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGRHVXVZMjl1ZEhKaFkzUXVVM1JoZEdVdWMzUnlkV04wYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjBjblZqZEhNNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTUNCdlppQW9LR3hsYml0MWRHWTRXMTBwTEhWcGJuUTJOQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXhNZ29nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1U1c1d2RYUUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1qY0tJQ0FnSUM4dklISmxkSFZ5YmlCUGRYUndkWFFvWVhKak5DNVRkSEpwYm1jb1UzUnlhVzVuS0NKSVpXeHNieXdnSWlrZ0t5QnVZVzFsWDJGblpTNXVZVzFsTG01aGRHbDJaU2tzSUdGeVl6UXVWVWx1ZERZMEtHNWhiV1ZmWVdkbExtRm5aUzV1WVhScGRtVWdLaUF5S1NrS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pJWld4c2J5d2dJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd1lRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWNFlXMXdiR1Z6TG5OdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEdGMFpTNWpiMjUwY21GamRDNVRkR0YwWlM1elpYUmZaMnh2WW1Gc1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDJkc2IySmhiRG9LSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRFErQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVE16Q2lBZ0lDQXZMeUJ6Wld4bUxtbHVkREVnUFNCcGJuUXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltbHVkREVpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UTTBDaUFnSUNBdkx5QnpaV3htTG1sdWRESWdQU0JwYm5ReUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1sdWRESWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCelpXeG1MbUo1ZEdWek1TQTlJR0o1ZEdWek1TNWllWFJsY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ppZVhSbGN6RWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNMkNpQWdJQ0F2THlCelpXeG1MbUo1ZEdWek1pQTlJR0o1ZEdWek1pNWllWFJsY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ppZVhSbGN6SWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVhSbExtTnZiblJ5WVdOMExsTjBZWFJsTG5ObGRGOXNiMk5oYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlzYjJOaGJEb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE16Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lEUStDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UUXlDaUFnSUNBdkx5QnpaV3htTG14dlkyRnNYMmx1ZERGYlZIaHVMbk5sYm1SbGNsMGdQU0JwYm5ReENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbXh2WTJGc1gybHVkREVpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE5ETUtJQ0FnSUM4dklITmxiR1l1Ykc5allXeGZhVzUwTWx0VWVHNHVjMlZ1WkdWeVhTQTlJR2x1ZERJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QWliRzlqWVd4ZmFXNTBNaUlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z2MyVnNaaTVzYjJOaGJGOWllWFJsY3pGYlZIaHVMbk5sYm1SbGNsMGdQU0JpZVhSbGN6RXVZbmwwWlhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QWliRzlqWVd4ZllubDBaWE14SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UUTFDaUFnSUNBdkx5QnpaV3htTG14dlkyRnNYMko1ZEdWek1sdFVlRzR1YzJWdVpHVnlYU0E5SUdKNWRHVnpNaTVpZVhSbGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pzYjJOaGJGOWllWFJsY3pJaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNemdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWNFlXMXdiR1Z6TG5OdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEdGMFpTNWpiMjUwY21GamRDNVRkR0YwWlM1elpYUmZZbTk0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMkp2ZURvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TkRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTkQ0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hORGtLSUNBZ0lDOHZJSE5sYkdZdVltOTRXMjVoYldWZElEMGdkbUZzZFdVS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hORGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdWNFlXMXdiR1Z6TG5OdFlYSjBYMk52Ym5SeVlXTjBjeTVpWVhObExtTnZiblJ5WVdOMExrSmhjMlZCVWtNMFEyOXVkSEpoWTNRdVlYVjBhRzl5YVhwbFgyTnlaV0YwYjNJb0tTQXRQaUIyYjJsa09ncGhkWFJvYjNKcGVtVmZZM0psWVhSdmNqb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMk52Ym5SeVlXTjBMbkI1T2pFd0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaWRXNWhkWFJvYjNKcGVtVmtJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUpoYzJVdVkyOXVkSEpoWTNRdVFtRnpaVUZTUXpSRGIyNTBjbUZqZEM1cGRHOWhLR2s2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21sMGIyRTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRveE1pMHhNd29nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVLSUNBZ0lDOHZJR1JsWmlCcGRHOWhLSE5sYkdZc0lHazZJRlZKYm5RMk5Da2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnYVdZZ2FTQTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnVlaUJwZEc5aFgyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRveE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpTUNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWpBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWwwYjJGZlpXeHpaVjlpYjJSNVFESTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUNoelpXeG1MbWwwYjJFb2FTQXZMeUJWU1c1ME5qUW9NVEFwS1NCcFppQW9hU0F2THlCVlNXNTBOalFvTVRBcEtTQStJRlZKYm5RMk5DZ3dLU0JsYkhObElGTjBjbWx1WnlnaUlpa3BJQ3NnVTNSeWFXNW5MbVp5YjIxZllubDBaWE1vQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUM4S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmllaUJwZEc5aFgzUmxjbTVoY25sZlptRnNjMlZBTkFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHTmhiR3h6ZFdJZ2FYUnZZUW9LYVhSdllWOTBaWEp1WVhKNVgyMWxjbWRsUURVNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG94T0FvZ0lDQWdMeThnVTNSeWFXNW5LQ0l3TVRJek5EVTJOemc1SWlrdVlubDBaWE5iYVNBbElGVkpiblEyTkNneE1DbGRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJQ1VLSUNBZ0lIQjFjMmhpZVhSbGN5QWlNREV5TXpRMU5qYzRPU0lLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlkyOXVkSEpoWTNRdWNIazZNVGN0TVRrS0lDQWdJQzh2SUhKbGRIVnliaUFvYzJWc1ppNXBkRzloS0drZ0x5OGdWVWx1ZERZMEtERXdLU2tnYVdZZ0tHa2dMeThnVlVsdWREWTBLREV3S1NrZ1BpQlZTVzUwTmpRb01Da2daV3h6WlNCVGRISnBibWNvSWlJcEtTQXJJRk4wY21sdVp5NW1jbTl0WDJKNWRHVnpLQW9nSUNBZ0x5OGdJQ0FnSUZOMGNtbHVaeWdpTURFeU16UTFOamM0T1NJcExtSjVkR1Z6VzJrZ0pTQlZTVzUwTmpRb01UQXBYUW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NtbDBiMkZmZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwySmhjMlV2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklISmxkSFZ5YmlBb2MyVnNaaTVwZEc5aEtHa2dMeThnVlVsdWREWTBLREV3S1NrZ2FXWWdLR2tnTHk4Z1ZVbHVkRFkwS0RFd0tTa2dQaUJWU1c1ME5qUW9NQ2tnWld4elpTQlRkSEpwYm1jb0lpSXBLU0FySUZOMGNtbHVaeTVtY205dFgySjVkR1Z6S0FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpSWdvZ0lDQWdZaUJwZEc5aFgzUmxjbTVoY25sZmJXVnlaMlZBTlFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUhBUUFDQ0FBQUFDWURCQlVmZkhVSFNHVnNiRzhzSUFBeEcwRUF0NElEQkR5bHpyY0VKeHRPNlFRd3h0V0tOaG9BamdNQWp3Q0RBSHN4R1JSRU1SaEJBR1NDRFFSRTBOb05CUEYrZ0tVRUNwS29IZ1FGNGJRckJGZExWY2dFTmdOaTZRUkcwaEdqQkF6OHV3QUUwUEM2K0FRa2ErdURCS1RQamVvRXpzS0RTZ1NrdEtJd05ob0FqZzBBQVFDeUFOTUJFUUZIQVZvQmFBR1hBYVVCMUFJVUFtZ0MzUUFBZ0FTZFVqQkFOaG9BamdFQVd3QXhHU0lTTVJnUVF6RVpnUVVTTVJnUVJFSUFkVEVaZ1FRU01SZ1FSRUlBVURFWmpRWUFGd0FYLzhEL3dBQU1BQUVBTVJoRUlRUkVpQUt3SWtNeEdFUWhCVVNJQXFVaVF6RVlGRVNJQXB5QUJYWmhiSFZsSVFabklrTTJHZ0ZKSTFra0NFc0JGUkpFaUFLQUtFeFFzQ0pETmhvQlNTTlpKQWhMQVJVU1JJZ0NhaUVGUkNoTVVMQWlRellhQVVraldTUUlTd0VWRWtTSUFsRWhCRVFvVEZDd0lrTTJHZ0ZKSTFra0NFc0JGUkpFVndJQUtVeFFTUlVXVndZQ1RGQW9URkN3SWtNeEZpSUpTVGdRSWhKRU5ob0JTU05aSkFoTEFSVVNSRmNDQUV3NENJZ0NEb0FGVTJWdWRDQk1VSUFDTGlCUVRGQkpGUlpYQmdKTVVDaE1VTEFpUXpZYUFVa1ZKUkpFRnpZYUFra1ZnU0FTUkRZYUEwa1ZKUkpFRjA4Q1JESURUd0lUUkVTQURCVWZmSFVBQUFBQUFBQUFBYkFpUXpZYUFVa2pXU1FJU3dFVkVrUW9URkN3SWtNMkdnRkpGU1VTUkNoTVVMQWlRellhQVVraldVa2tDRXNDRlJKRVRGY0NBSUVGVHdJSUZsY0dBSUFIQUFWQlFra3NJRXhjQUV4UUtFeFFzQ0pETmhvQlNSVWxFa1FvVEZDd0lrTTJHZ0ZKSTFra0NFc0JGUkpFVndJQWdBMU1iMk5oYkNCemRHRjBaU3dnVEZCSkZSWlhCZ0pNVUNoTVVMQWlRellhQVVrVlN3RWpXVW1CQ2hKRVN3Sk1Td0pTU1NOWmdRd0lUd0lTUkZjQ0FDbE1VRWtWRmxjR0FreFFUQ1JiSkFzV2dBSUFDa3hRVEZBb1RGQ3dJa00yR2dGSkZTVVNSQmMyR2dKSkZTVVNSQmMyR2dOSkkxa2tDRXNCRlJKRVZ3SUFOaG9FU1JXQkJCSkVnQVJwYm5ReFR3Um5nQVJwYm5ReVR3Tm5nQVppZVhSbGN6RlBBbWVBQm1KNWRHVnpNa3huSWtNMkdnRkpGU1VTUkJjMkdnSkpGU1VTUkJjMkdnTkpJMWtrQ0VzQkZSSkVWd0lBTmhvRVNSV0JCQkpFTVFDQUNteHZZMkZzWDJsdWRERlBCV1l4QUlBS2JHOWpZV3hmYVc1ME1rOEVaakVBZ0F4c2IyTmhiRjlpZVhSbGN6RlBBMll4QUlBTWJHOWpZV3hmWW5sMFpYTXlUd0ptSWtNMkdnRkpGWUVFRWtRMkdnSkpJMWtrQ0VzQkZSSkVTd0c4U0w4aVF6RUFNZ2tTUkltS0FRRXFpLzlBQUFXQUFUQk1pWXYvZ1FvS1NZd0FRUUFjaXdDSS8rS0wvNEVLR0lBS01ERXlNelExTmpjNE9Vd2lXRkJNaVNwQy8rVT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJERUxFVEFCTEUiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfSwiVVBEQVRBQkxFIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH0sIlZBTFVFIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
