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
        public async Task<ulong> CallWithReferences(ulong application, Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { application });
            byte applicationRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 254, 253, 241, 30 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var applicationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); applicationAbi.From(application);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, accountRefIndex, applicationRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CallWithReferences_Transactions(ulong application, Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { application });
            byte applicationRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 254, 253, 241, 30 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var applicationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); applicationAbi.From(application);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, accountRefIndex, applicationRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSW5wdXQiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFnZSIsInR5cGUiOiJ1aW50NjQifV0sIk91dHB1dCI6W3sibmFtZSI6Im1lc3NhZ2UiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVzdWx0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnB1dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXJyb3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbF9hYmlfdHhuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxfd2l0aF9yZWZlcmVuY2VzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsaWNhdGlvbiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVmYXVsdF92YWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxpdGVyYWwiLCJkYXRhIjoiQUExa1pXWmhkV3gwSUhaaGJIVmwiLCJ0eXBlIjoic3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ193aXRoX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQUFBQUFBQUFIcz0iLCJ0eXBlIjoidWludDY0In19XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9hYmkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsaXRlcmFsIiwiZGF0YSI6IkFBMWtaV1poZFd4MElIWmhiSFZsIiwidHlwZSI6InN0cmluZyJ9fV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWZhdWx0X3ZhbHVlX2Zyb21fZ2xvYmFsX3N0YXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ193aXRoX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoiZ2xvYmFsIiwiZGF0YSI6ImFXNTBNUT09IiwidHlwZSI6IkFWTVN0cmluZyJ9fV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWZhdWx0X3ZhbHVlX2Zyb21fbG9jYWxfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsb2NhbCIsImRhdGEiOiJiRzlqWVd4ZllubDBaWE14IiwidHlwZSI6IkFWTVN0cmluZyJ9fV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdHJ1Y3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IklucHV0IiwibmFtZSI6Im5hbWVfYWdlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6Ik91dHB1dCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9nbG9iYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9sb2NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2JveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCIsIk9wdEluIl0sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iLCJVcGRhdGVBcHBsaWNhdGlvbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYxNyw5MTddLCJlcnJvck1lc3NhZ2UiOiJDaGVjayBhcHAgaXMgZGVsZXRhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA2LDkxMV0sImVycm9yTWVzc2FnZSI6IkNoZWNrIGFwcCBpcyB1cGRhdGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjZdLCJlcnJvck1lc3NhZ2UiOiJEZWxpYmVyYXRlIGVycm9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBEZWxldGVBcHBsaWNhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNiwxNTQsMTgzLDIxMiwyMzEsMjUzLDI2OCwyODcsMzAyLDMxNywzNTIsMzkyLDQyMiw1MDRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE9wdEluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBVcGRhdGVBcHBsaWNhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2OF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgbm90IHByb3ZpZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjcxXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gbm90IHByb3ZpZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjYyXSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgbm90IHByb3ZpZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA4LDU3MF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOSwxNTcsMTg2LDIxNSwyMzQsMjU2LDI3MSwyOTAsMzA1LDMyMCwzNTUsMzk1LDQyNSw0MzQsNDQ1LDQ3Nyw1NTMsNTYxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI3XSwiZXJyb3JNZXNzYWdlIjoidW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVjM1JoZEdVdVkyOXVkSEpoWTNRdVUzUmhkR1V1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lGUk5VRXhmVlZCRVFWUkJRa3hGSUZSTlVFeGZSRVZNUlZSQlFreEZJRlJOVUV4ZlZrRk1WVVVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpU0dWc2JHOHNJQ0lnSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdVb1JYaGhiWEJzWlVGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNaklLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc1WkRVeU16QTBNQ0F3ZUROallUVmpaV0kzSURCNE1qY3hZalJsWlRrZ01IZ3pNR00yWkRVNFlTQXdlRFEwWkRCa1lUQmtJREI0WmpFM1pUZ3dZVFVnTUhnd1lUa3lZVGd4WlNBd2VHWmxabVJtTVRGbElEQjROVGMwWWpVMVl6Z2dNSGd6TmpBek5qSmxPU0F3ZURRMlpESXhNV0V6SURCNE1HTm1ZMkppTURBZ01IaGtNR1l3WW1GbU9DQXdlREkwTm1KbFlqZ3pJREI0WVRSalpqaGtaV0VnTUhoalpXTXlPRE0wWVNBd2VHRTBZalJoTWpNd0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgyRmlhU2h6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSjFjR1JoZEdWZllXSnBLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltUmxiR1YwWlY5aFlta29jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWIzQjBYMmx1S0NsMmIybGtJaXdnYldWMGFHOWtJQ0psY25KdmNpZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyRnNiRjloWW1rb2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWTJGc2JGOWhZbWxmZEhodUtIQmhlU3h6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSmpZV3hzWDNkcGRHaGZjbVZtWlhKbGJtTmxjeWhoYzNObGRDeGhZMk52ZFc1MExHRndjR3hwWTJGMGFXOXVLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaR1ZtWVhWc2RGOTJZV3gxWlNoemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0prWldaaGRXeDBYM1poYkhWbFgybHVkQ2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZZV0pwS0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbVJsWm1GMWJIUmZkbUZzZFdWZlpuSnZiVjluYkc5aVlXeGZjM1JoZEdVb2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWkdWbVlYVnNkRjkyWVd4MVpWOW1jbTl0WDJ4dlkyRnNYM04wWVhSbEtITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW5OMGNuVmpkSE1vS0hOMGNtbHVaeXgxYVc1ME5qUXBLU2h6ZEhKcGJtY3NkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWljMlYwWDJkc2IySmhiQ2gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1Wnl4aWVYUmxXelJkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5c2IyTmhiQ2gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1Wnl4aWVYUmxXelJkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5aWIzZ29ZbmwwWlZzMFhTeHpkSEpwYm1jcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgyRmlhVjl5YjNWMFpVQTFJRzFoYVc1ZmRYQmtZWFJsWDJGaWFWOXliM1YwWlVBMklHMWhhVzVmWkdWc1pYUmxYMkZpYVY5eWIzVjBaVUEzSUcxaGFXNWZiM0IwWDJsdVgzSnZkWFJsUURnZ2JXRnBibDlsY25KdmNsOXliM1YwWlVBNUlHMWhhVzVmWTJGc2JGOWhZbWxmY205MWRHVkFNVEFnYldGcGJsOWpZV3hzWDJGaWFWOTBlRzVmY205MWRHVkFNVEVnYldGcGJsOWpZV3hzWDNkcGRHaGZjbVZtWlhKbGJtTmxjMTl5YjNWMFpVQXhNaUJ0WVdsdVgyUmxabUYxYkhSZmRtRnNkV1ZmY205MWRHVkFNVE1nYldGcGJsOWtaV1poZFd4MFgzWmhiSFZsWDJsdWRGOXliM1YwWlVBeE5DQnRZV2x1WDJSbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5aFltbGZjbTkxZEdWQU1UVWdiV0ZwYmw5a1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZloyeHZZbUZzWDNOMFlYUmxYM0p2ZFhSbFFERTJJRzFoYVc1ZlpHVm1ZWFZzZEY5MllXeDFaVjltY205dFgyeHZZMkZzWDNOMFlYUmxYM0p2ZFhSbFFERTNJRzFoYVc1ZmMzUnlkV04wYzE5eWIzVjBaVUF4T0NCdFlXbHVYM05sZEY5bmJHOWlZV3hmY205MWRHVkFNVGtnYldGcGJsOXpaWFJmYkc5allXeGZjbTkxZEdWQU1qQWdiV0ZwYmw5elpYUmZZbTk0WDNKdmRYUmxRREl4Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklHTnNZWE56SUZOMFlYUmxLRVY0WVcxd2JHVkJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6WlhSZlltOTRYM0p2ZFhSbFFESXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdVb1JYaGhiWEJzWlVGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UUTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdjMlYwWDJKdmVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUmZiRzlqWVd4ZmNtOTFkR1ZBTWpBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBaU2hGZUdGdGNHeGxRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVE00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzJWMFgyeHZZMkZzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM05sZEY5bmJHOWlZV3hmY205MWRHVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCamJHRnpjeUJUZEdGMFpTaEZlR0Z0Y0d4bFFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1USTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdjMlYwWDJkc2IySmhiQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpkSEoxWTNSelgzSnZkWFJsUURFNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFeU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdZMnhoYzNNZ1UzUmhkR1VvUlhoaGJYQnNaVUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2MzUnlkV04wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlrWldaaGRXeDBYM1poYkhWbFgyWnliMjFmYkc5allXeGZjM1JoZEdWZmNtOTFkR1ZBTVRjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2daR1ZtWVhWc2RGOWhjbWR6UFhzaVlYSm5YM2RwZEdoZlpHVm1ZWFZzZENJNklDSnNiMk5oYkY5aWVYUmxjekVpZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJqYkdGemN5QlRkR0YwWlNoRmVHRnRjR3hsUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2daR1ZtWVhWc2RGOWhjbWR6UFhzaVlYSm5YM2RwZEdoZlpHVm1ZWFZzZENJNklDSnNiMk5oYkY5aWVYUmxjekVpZlNrS0lDQWdJR05oYkd4emRXSWdaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMnh2WTJGc1gzTjBZWFJsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlJsWm1GMWJIUmZkbUZzZFdWZlpuSnZiVjluYkc5aVlXeGZjM1JoZEdWZmNtOTFkR1ZBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRFM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2daR1ZtWVhWc2RGOWhjbWR6UFhzaVlYSm5YM2RwZEdoZlpHVm1ZWFZzZENJNklDSnBiblF4SW4wcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJqYkdGemN5QlRkR0YwWlNoRmVHRnRjR3hsUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxMQ0JrWldaaGRXeDBYMkZ5WjNNOWV5SmhjbWRmZDJsMGFGOWtaV1poZFd4MElqb2dJbWx1ZERFaWZTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOWhZbWxmY205MWRHVkFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlN3Z1pHVm1ZWFZzZEY5aGNtZHpQWHNpWVhKblgzZHBkR2hmWkdWbVlYVnNkQ0k2SUdGeVl6UXVVM1J5YVc1bktDSmtaV1poZFd4MElIWmhiSFZsSWlsOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhSbEtFVjRZVzF3YkdWQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VzSUdSbFptRjFiSFJmWVhKbmN6MTdJbUZ5WjE5M2FYUm9YMlJsWm1GMWJIUWlPaUJoY21NMExsTjBjbWx1WnlnaVpHVm1ZWFZzZENCMllXeDFaU0lwZlNrS0lDQWdJR05oYkd4emRXSWdaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMkZpYVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlrWldaaGRXeDBYM1poYkhWbFgybHVkRjl5YjNWMFpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsTENCa1pXWmhkV3gwWDJGeVozTTlleUpoY21kZmQybDBhRjlrWldaaGRXeDBJam9nWVhKak5DNVZTVzUwTmpRb01USXpLWDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBaU2hGZUdGdGNHeGxRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmtaV1poZFd4MFgyRnlaM005ZXlKaGNtZGZkMmwwYUY5a1pXWmhkV3gwSWpvZ1lYSmpOQzVWU1c1ME5qUW9NVEl6S1gwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5a1pXWmhkV3gwWDNaaGJIVmxYM0p2ZFhSbFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VzSUdSbFptRjFiSFJmWVhKbmN6MTdJbUZ5WjE5M2FYUm9YMlJsWm1GMWJIUWlPaUJoY21NMExsTjBjbWx1WnlnaVpHVm1ZWFZzZENCMllXeDFaU0lwZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNelFLSUNBZ0lDOHZJR05zWVhOeklGTjBZWFJsS0VWNFlXMXdiR1ZCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXNJR1JsWm1GMWJIUmZZWEpuY3oxN0ltRnlaMTkzYVhSb1gyUmxabUYxYkhRaU9pQmhjbU0wTGxOMGNtbHVaeWdpWkdWbVlYVnNkQ0IyWVd4MVpTSXBmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk5oYkd4ZmQybDBhRjl5WldabGNtVnVZMlZ6WDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCamJHRnpjeUJUZEdGMFpTaEZlR0Z0Y0d4bFFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGd2NHeHBZMkYwYVc5dWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1kyRnNiRjkzYVhSb1gzSmxabVZ5Wlc1alpYTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyRnNiRjloWW1sZmRIaHVYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBaU2hGZUdGdGNHeGxRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdOaGJHeGZZV0pwWDNSNGJnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJGc2JGOWhZbWxmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNelFLSUNBZ0lDOHZJR05zWVhOeklGTjBZWFJsS0VWNFlXMXdiR1ZCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR05oYkd4ZllXSnBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bGNuSnZjbDl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QmhjM05sY25RZ1JtRnNjMlVzSUNKRVpXeHBZbVZ5WVhSbElHVnljbTl5SWlBZ0l5QnViM0ZoT2lCUVZEQXhOU3dnUWpBeE1Rb2dJQ0FnWlhKeUlDOHZJRVJsYkdsaVpYSmhkR1VnWlhKeWIzSUtDbTFoYVc1ZmIzQjBYMmx1WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVQzQjBTVzRpWFNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlCUGNIUkpiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFOXdkRWx1Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpHVnNaWFJsWDJGaWFWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pjMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z1JHVnNaWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhSbEtFVjRZVzF3YkdWQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpFWld4bGRHVkJjSEJzYVdOaGRHbHZiaUpkS1FvZ0lDQWdZMkZzYkhOMVlpQmtaV3hsZEdWZllXSnBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWNHUmhkR1ZmWVdKcFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TnpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lWWEJrWVhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRlZ3WkdGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdVb1JYaGhiWEJzWlVGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQmpZV3hzYzNWaUlIVndaR0YwWlY5aFlta0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjloWW1sZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBaU2hGZUdGdGNHeGxRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVmZZV0pwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTWpJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhSbEtFVjRZVzF3YkdWQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjM2RwZEdOb0lHMWhhVzVmWTNKbFlYUmxRREl6SUcxaGFXNWZZM0psWVhSbFFESXpJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TmlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qWWdiV0ZwYmw5MWNHUmhkR1ZBTWpRZ2JXRnBibDlrWld4bGRHVkFNalVLSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREkyQ2dwdFlXbHVYMlJsYkdWMFpVQXlOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHUmxiR1YwWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxY0dSaGRHVkFNalE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQjFjR1JoZEdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxRREl6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXNJR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWl3Z0lrOXdkRWx1SWwwcENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVjM1JoZEdVdVkyOXVkSEpoWTNRdVUzUmhkR1V1WTNKbFlYUmxLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QnpaV3htTG1GMWRHaHZjbWw2WlY5amNtVmhkRzl5S0NrS0lDQWdJR05oYkd4emRXSWdZWFYwYUc5eWFYcGxYMk55WldGMGIzSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z2MyVnNaaTUyWVd4MVpTQTlJRlJsYlhCc1lYUmxWbUZ5VzFWSmJuUTJORjBvVmtGTVZVVmZWRVZOVUV4QlZFVmZUa0ZOUlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpZG1Gc2RXVWlDaUFnSUNCcGJuUmpJRFFnTHk4Z1ZFMVFURjlXUVV4VlJRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxuTnRZWEowWDJOdmJuUnlZV04wY3k1emRHRjBaUzVqYjI1MGNtRmpkQzVUZEdGMFpTNWpjbVZoZEdWZllXSnBLR2x1Y0hWME9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTnlaV0YwWlY5aFltazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk5qVXROallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOWhZbWtvYzJWc1ppd2dhVzV3ZFhRNklGTjBjbWx1WnlrZ0xUNGdVM1J5YVc1bk9pQWdJeUJ1YjNGaE9pQkJNREF5Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z2MyVnNaaTVoZFhSb2IzSnBlbVZmWTNKbFlYUnZjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHRjFkR2h2Y21sNlpWOWpjbVZoZEc5eUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUhKbGRIVnliaUJwYm5CMWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGRHVXVZMjl1ZEhKaFkzUXVVM1JoZEdVdWRYQmtZWFJsWDJGaWFTaHBibkIxZERvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMWNHUmhkR1ZmWVdKcE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pjd0xUY3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWxWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0F2THlCa1pXWWdkWEJrWVhSbFgyRmlhU2h6Wld4bUxDQnBibkIxZERvZ1UzUnlhVzVuS1NBdFBpQlRkSEpwYm1jNklDQWpJRzV2Y1dFNklFRXdNRElLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCelpXeG1MbUYxZEdodmNtbDZaVjlqY21WaGRHOXlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnWVhOelpYSjBJRlJsYlhCc1lYUmxWbUZ5VzJKdmIyeGRLRlZRUkVGVVFVSk1SVjlVUlUxUVRFRlVSVjlPUVUxRktTd2dJa05vWldOcklHRndjQ0JwY3lCMWNHUmhkR0ZpYkdVaUNpQWdJQ0JwYm5Salh6SWdMeThnVkUxUVRGOVZVRVJCVkVGQ1RFVUtJQ0FnSUdGemMyVnlkQ0F2THlCRGFHVmpheUJoY0hBZ2FYTWdkWEJrWVhSaFlteGxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklISmxkSFZ5YmlCcGJuQjFkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1VTNSaGRHVXVaR1ZzWlhSbFgyRmlhU2hwYm5CMWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGtaV3hsZEdWZllXSnBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qYzJMVGMzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNBdkx5QmtaV1lnWkdWc1pYUmxYMkZpYVNoelpXeG1MQ0JwYm5CMWREb2dVM1J5YVc1bktTQXRQaUJUZEhKcGJtYzZJQ0FqSUc1dmNXRTZJRUV3TURJS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnpaV3htTG1GMWRHaHZjbWw2WlY5amNtVmhkRzl5S0NrS0lDQWdJR05oYkd4emRXSWdZWFYwYUc5eWFYcGxYMk55WldGMGIzSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSbGJYQnNZWFJsVm1GeVcySnZiMnhkS0VSRlRFVlVRVUpNUlY5VVJVMVFURUZVUlY5T1FVMUZLU3dnSWtOb1pXTnJJR0Z3Y0NCcGN5QmtaV3hsZEdGaWJHVWlDaUFnSUNCcGJuUmpYek1nTHk4Z1ZFMVFURjlFUlV4RlZFRkNURVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR1ZqYXlCaGNIQWdhWE1nWkdWc1pYUmhZbXhsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJSEpsZEhWeWJpQnBibkIxZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVjM1JoZEdVdVkyOXVkSEpoWTNRdVUzUmhkR1V1WTJGc2JGOWhZbWtvZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZMkZzYkY5aFltazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk9UQXRPVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHTmhiR3hmWVdKcEtITmxiR1lzSUhaaGJIVmxPaUJUZEhKcGJtY3BJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2preUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pJWld4c2J5d2dJaWtnS3lCMllXeDFaUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlTR1ZzYkc4c0lDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1VTNSaGRHVXVZMkZzYkY5aFltbGZkSGh1S0hSNGJqb2dkV2x1ZERZMExDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwallXeHNYMkZpYVY5MGVHNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk9UUXRPVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHTmhiR3hmWVdKcFgzUjRiaWh6Wld4bUxDQjBlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVMQ0IyWVd4MVpUb2dVM1J5YVc1bktTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lVMlZ1ZENBaUtTQXJJSE5sYkdZdWFYUnZZU2gwZUc0dVlXMXZkVzUwS1NBcklGTjBjbWx1WnlnaUxpQWlLU0FySUhaaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWTJGc2JITjFZaUJwZEc5aENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxObGJuUWdJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaTRnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlYUmxMbU52Ym5SeVlXTjBMbE4wWVhSbExtTmhiR3hmZDJsMGFGOXlaV1psY21WdVkyVnpLR0Z6YzJWME9pQjFhVzUwTmpRc0lHRmpZMjkxYm5RNklHSjVkR1Z6TENCaGNIQnNhV05oZEdsdmJqb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbU5oYkd4ZmQybDBhRjl5WldabGNtVnVZMlZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPams0TFRrNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCallXeHNYM2RwZEdoZmNtVm1aWEpsYm1ObGN5aHpaV3htTENCaGMzTmxkRG9nUVhOelpYUXNJR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXNJR0Z3Y0d4cFkyRjBhVzl1T2lCQmNIQnNhV05oZEdsdmJpa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRBd0NpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUXNJQ0poYzNObGRDQnViM1FnY0hKdmRtbGtaV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCdWIzUWdjSEp2ZG1sa1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCaFkyTnZkVzUwTENBaVlXTmpiM1Z1ZENCdWIzUWdjSEp2ZG1sa1pXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHNXZkQ0J3Y205MmFXUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXdNZ29nSUNBZ0x5OGdZWE56WlhKMElHRndjR3hwWTJGMGFXOXVMQ0FpWVhCd2JHbGpZWFJwYjI0Z2JtOTBJSEJ5YjNacFpHVmtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdibTkwSUhCeWIzWnBaR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlYUmxMbU52Ym5SeVlXTjBMbE4wWVhSbExtUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOWhZbWtvWVhKblgzZHBkR2hmWkdWbVlYVnNkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BrWldaaGRXeDBYM1poYkhWbFgyWnliMjFmWVdKcE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFeE15MHhNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsTENCa1pXWmhkV3gwWDJGeVozTTlleUpoY21kZmQybDBhRjlrWldaaGRXeDBJam9nWVhKak5DNVRkSEpwYm1jb0ltUmxabUYxYkhRZ2RtRnNkV1VpS1gwcENpQWdJQ0F2THlCa1pXWWdaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMkZpYVNoelpXeG1MQ0JoY21kZmQybDBhRjlrWldaaGRXeDBPaUJoY21NMExsTjBjbWx1WnlrZ0xUNGdZWEpqTkM1VGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWtGQ1NTd2dJaWtnS3lCaGNtZGZkMmwwYUY5a1pXWmhkV3gwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBNVFF5TkRreVl6SXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1VTNSaGRHVXVaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMnh2WTJGc1gzTjBZWFJsS0dGeVoxOTNhWFJvWDJSbFptRjFiSFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWkdWbVlYVnNkRjkyWVd4MVpWOW1jbTl0WDJ4dlkyRnNYM04wWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFeU1TMHhNaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsTENCa1pXWmhkV3gwWDJGeVozTTlleUpoY21kZmQybDBhRjlrWldaaGRXeDBJam9nSW14dlkyRnNYMko1ZEdWek1TSjlLUW9nSUNBZ0x5OGdaR1ZtSUdSbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5c2IyTmhiRjl6ZEdGMFpTaHpaV3htTENCaGNtZGZkMmwwYUY5a1pXWmhkV3gwT2lCVGRISnBibWNwSUMwK0lHRnlZelF1VTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVRkSEpwYm1jb1UzUnlhVzVuS0NKTWIyTmhiQ0J6ZEdGMFpTd2dJaWtnS3lCaGNtZGZkMmwwYUY5a1pXWmhkV3gwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pNYjJOaGJDQnpkR0YwWlN3Z0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGRHVXVZMjl1ZEhKaFkzUXVVM1JoZEdVdWMzUnlkV04wY3lodVlXMWxYMkZuWlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwemRISjFZM1J6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPakV5TlMweE1qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlITjBjblZqZEhNb2MyVnNaaXdnYm1GdFpWOWhaMlU2SUVsdWNIVjBLU0F0UGlCUGRYUndkWFE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1qY0tJQ0FnSUM4dklISmxkSFZ5YmlCUGRYUndkWFFvWVhKak5DNVRkSEpwYm1jb1UzUnlhVzVuS0NKSVpXeHNieXdnSWlrZ0t5QnVZVzFsWDJGblpTNXVZVzFsTG01aGRHbDJaU2tzSUdGeVl6UXVWVWx1ZERZMEtHNWhiV1ZmWVdkbExtRm5aUzV1WVhScGRtVWdLaUF5S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVNHVnNiRzhzSUNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd1lRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR1Y0WVcxd2JHVnpMbk50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0YwWlM1amIyNTBjbUZqZEM1VGRHRjBaUzV6WlhSZloyeHZZbUZzS0dsdWRERTZJSFZwYm5RMk5Dd2dhVzUwTWpvZ2RXbHVkRFkwTENCaWVYUmxjekU2SUdKNWRHVnpMQ0JpZVhSbGN6STZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHpaWFJmWjJ4dlltRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXlPUzB4TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhObGRGOW5iRzlpWVd3b0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3Z2FXNTBNVG9nVlVsdWREWTBMQ0JwYm5ReU9pQlZTVzUwTmpRc0lHSjVkR1Z6TVRvZ1UzUnlhVzVuTENCaWVYUmxjekk2SUdGeVl6UXVVM1JoZEdsalFYSnlZWGxiWVhKak5DNUNlWFJsTENCTWFYUmxjbUZzV3pSZFhRb2dJQ0FnTHk4Z0tTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdOQ0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVE16Q2lBZ0lDQXZMeUJ6Wld4bUxtbHVkREVnUFNCcGJuUXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltbHVkREVpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJ6Wld4bUxtbHVkRElnUFNCcGJuUXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltbHVkRElpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJ6Wld4bUxtSjVkR1Z6TVNBOUlHSjVkR1Z6TVM1aWVYUmxjd29nSUNBZ2NIVnphR0o1ZEdWeklDSmllWFJsY3pFaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNMkNpQWdJQ0F2THlCelpXeG1MbUo1ZEdWek1pQTlJR0o1ZEdWek1pNWllWFJsY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ppZVhSbGN6SWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1VTNSaGRHVXVjMlYwWDJ4dlkyRnNLR2x1ZERFNklIVnBiblEyTkN3Z2FXNTBNam9nZFdsdWREWTBMQ0JpZVhSbGN6RTZJR0o1ZEdWekxDQmllWFJsY3pJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwelpYUmZiRzlqWVd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNNExURTBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdjMlYwWDJ4dlkyRnNLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNJR2x1ZERFNklGVkpiblEyTkN3Z2FXNTBNam9nVlVsdWREWTBMQ0JpZVhSbGN6RTZJRk4wY21sdVp5d2dZbmwwWlhNeU9pQmhjbU0wTGxOMFlYUnBZMEZ5Y21GNVcyRnlZelF1UW5sMFpTd2dUR2wwWlhKaGJGczBYVjBLSUNBZ0lDOHZJQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFME1nb2dJQ0FnTHk4Z2MyVnNaaTVzYjJOaGJGOXBiblF4VzFSNGJpNXpaVzVrWlhKZElEMGdhVzUwTVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2NIVnphR0o1ZEdWeklDSnNiMk5oYkY5cGJuUXhJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QnpaV3htTG14dlkyRnNYMmx1ZERKYlZIaHVMbk5sYm1SbGNsMGdQU0JwYm5ReUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbXh2WTJGc1gybHVkRElpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hORFFLSUNBZ0lDOHZJSE5sYkdZdWJHOWpZV3hmWW5sMFpYTXhXMVI0Ymk1elpXNWtaWEpkSUQwZ1lubDBaWE14TG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW14dlkyRnNYMko1ZEdWek1TSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z2MyVnNaaTVzYjJOaGJGOWllWFJsY3pKYlZIaHVMbk5sYm1SbGNsMGdQU0JpZVhSbGN6SXVZbmwwWlhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QWliRzlqWVd4ZllubDBaWE15SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVjM1JoZEdVdVkyOXVkSEpoWTNRdVUzUmhkR1V1YzJWMFgySnZlQ2h1WVcxbE9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3B6WlhSZlltOTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRTBOeTB4TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhObGRGOWliM2dvYzJWc1ppd2dibUZ0WlRvZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVZ0aGNtTTBMa0o1ZEdVc0lFeHBkR1Z5WVd4Yk5GMWRMQ0IyWVd4MVpUb2dZWEpqTkM1VGRISnBibWNwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklITmxiR1l1WW05NFcyNWhiV1ZkSUQwZ2RtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUpoYzJVdVkyOXVkSEpoWTNRdVNXMXRkWFJoWW1sc2FYUjVRMjl1ZEhKdmJFRlNRelJEYjI1MGNtRmpkQzUxY0dSaGRHVW9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRveU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSbGJYQnNZWFJsVm1GeVcySnZiMnhkS0ZWUVJFRlVRVUpNUlY5VVJVMVFURUZVUlY5T1FVMUZLU3dnSWtOb1pXTnJJR0Z3Y0NCcGN5QjFjR1JoZEdGaWJHVWlDaUFnSUNCcGJuUmpYeklnTHk4Z1ZFMVFURjlWVUVSQlZFRkNURVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR1ZqYXlCaGNIQWdhWE1nZFhCa1lYUmhZbXhsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncENpQWdJQ0JqWVd4c2MzVmlJR0YxZEdodmNtbDZaVjlqY21WaGRHOXlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltRnpaUzVqYjI1MGNtRmpkQzVRWlhKdFlXNWxibU5sUTI5dWRISnZiRUZTUXpSRGIyNTBjbUZqZEM1a1pXeGxkR1VvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3pNZ29nSUNBZ0x5OGdZWE56WlhKMElGUmxiWEJzWVhSbFZtRnlXMkp2YjJ4ZEtFUkZURVZVUVVKTVJWOVVSVTFRVEVGVVJWOU9RVTFGS1N3Z0lrTm9aV05ySUdGd2NDQnBjeUJrWld4bGRHRmliR1VpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdWRTFRVEY5RVJVeEZWRUZDVEVVS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdWamF5QmhjSEFnYVhNZ1pHVnNaWFJoWW14bENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnYzJWc1ppNWhkWFJvYjNKcGVtVmZZM0psWVhSdmNpZ3BDaUFnSUNCallXeHNjM1ZpSUdGMWRHaHZjbWw2WlY5amNtVmhkRzl5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVZbUZ6WlM1amIyNTBjbUZqZEM1Q1lYTmxRVkpETkVOdmJuUnlZV04wTG1GMWRHaHZjbWw2WlY5amNtVmhkRzl5S0NrZ0xUNGdkbTlwWkRvS1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSW5WdVlYVjBhRzl5YVhwbFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjFibUYxZEdodmNtbDZaV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR1Y0WVcxd2JHVnpMbk50WVhKMFgyTnZiblJ5WVdOMGN5NWlZWE5sTG1OdmJuUnlZV04wTGtKaGMyVkJVa00wUTI5dWRISmhZM1F1YVhSdllTaHBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BwZEc5aE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TVRJdE1UTUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnYVhSdllTaHpaV3htTENCcE9pQlZTVzUwTmpRcElDMCtJRk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlkyOXVkSEpoWTNRdWNIazZNVFFLSUNBZ0lDOHZJR2xtSUdrZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWJub2dhWFJ2WVY5bGJITmxYMkp2WkhsQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TVRVS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JakFpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncHBkRzloWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUhKbGRIVnliaUFvYzJWc1ppNXBkRzloS0drZ0x5OGdWVWx1ZERZMEtERXdLU2tnYVdZZ0tHa2dMeThnVlVsdWREWTBLREV3S1NrZ1BpQlZTVzUwTmpRb01Da2daV3h6WlNCVGRISnBibWNvSWlJcEtTQXJJRk4wY21sdVp5NW1jbTl0WDJKNWRHVnpLQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURFd0lDOHZJREV3Q2lBZ0lDQXZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWW5vZ2FYUnZZVjkwWlhKdVlYSjVYMlpoYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqWVd4c2MzVmlJR2wwYjJFS0NtbDBiMkZmZEdWeWJtRnllVjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhjMlV2WTI5dWRISmhZM1F1Y0hrNk1UZ0tJQ0FnSUM4dklGTjBjbWx1WnlnaU1ERXlNelExTmpjNE9TSXBMbUo1ZEdWelcya2dKU0JWU1c1ME5qUW9NVEFwWFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERXdJQzh2SURFd0NpQWdJQ0FsQ2lBZ0lDQndkWE5vWW5sMFpYTWdJakF4TWpNME5UWTNPRGtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwyTnZiblJ5WVdOMExuQjVPakUzTFRFNUNpQWdJQ0F2THlCeVpYUjFjbTRnS0hObGJHWXVhWFJ2WVNocElDOHZJRlZKYm5RMk5DZ3hNQ2twSUdsbUlDaHBJQzh2SUZWSmJuUTJOQ2d4TUNrcElENGdWVWx1ZERZMEtEQXBJR1ZzYzJVZ1UzUnlhVzVuS0NJaUtTa2dLeUJUZEhKcGJtY3Vabkp2YlY5aWVYUmxjeWdLSUNBZ0lDOHZJQ0FnSUNCVGRISnBibWNvSWpBeE1qTTBOVFkzT0RraUtTNWllWFJsYzF0cElDVWdWVWx1ZERZMEtERXdLVjBLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncHBkRzloWDNSbGNtNWhjbmxmWm1Gc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QnlaWFIxY200Z0tITmxiR1l1YVhSdllTaHBJQzh2SUZWSmJuUTJOQ2d4TUNrcElHbG1JQ2hwSUM4dklGVkpiblEyTkNneE1Da3BJRDRnVlVsdWREWTBLREFwSUdWc2MyVWdVM1J5YVc1bktDSWlLU2tnS3lCVGRISnBibWN1Wm5KdmJWOWllWFJsY3lnS0lDQWdJR0o1ZEdWalh6SWdMeThnSWlJS0lDQWdJR0lnYVhSdllWOTBaWEp1WVhKNVgyMWxjbWRsUURVSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQVFBQUFBQW1Bd1FWSDN4MUIwaGxiR3h2TENBQU1SdEJBZytDRVFTZFVqQkFCRHlsenJjRUp4dE82UVF3eHRXS0JFVFEyZzBFOFg2QXBRUUtrcWdlQlA3OThSNEVWMHRWeUFRMkEyTHBCRWJTRWFNRURQeTdBQVRROExyNEJDUnI2NE1FcE0rTjZnVE93b05LQktTMG9qQTJHZ0NPRVFGeUFWSUJNZ0VvQVNBQkFnRGFBTGNBcUFDWkFJWUFkd0JoQUU0QU1RQVVBQUlqUXpFWkZFUXhHRVEyR2dFMkdnS0lBdXdpUXpFWkZFUXhHRVEyR2dFWE5ob0NGellhQTFjQ0FEWWFCSWdDZ3lKRE1Sa1VSREVZUkRZYUFSYzJHZ0lYTmhvRFZ3SUFOaG9FaUFJNklrTXhHUlJFTVJoRU5ob0JpQUg4S0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQUlnQnlDaE1VTEFpUXpFWkZFUXhHRVFvTmhvQlVMQWlRekVaRkVReEdFUTJHZ0dJQVl3b1RGQ3dJa014R1JSRU1SaEVLRFlhQVZDd0lrTXhHUlJFTVJoRUtEWWFBVkN3SWtNeEdSUkVNUmhFTmhvQkY4QXdOaG9DRjhBY05ob0RGOEF5aUFFN0ZpaE1VTEFpUXpFWkZFUXhHRVF4RmlJSlNUZ1FJaEpFTmhvQlZ3SUFpQUQrU1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBaUFEWVNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVBREVaSWhKRU1SaEVJa014R1lFRkVrUXhHRVEyR2dGWEFnQ0lBSnRKRlJaWEJnSk1VQ2hNVUxBaVF6RVpnUVFTUkRFWVJEWWFBVmNDQUlnQWNFa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlGRVEyR2dGWEFnQ0lBRWhKRlJaWEJnSk1VQ2hNVUxBaVF6RVpqUVlBRXdBVC9sLytYd0FMQUFOQy9sd3hHRVNJQVdjaVF6RVlSSWdCV1NKRE1SZ1VSSWdBQWlKRGlBRlhnQVYyWVd4MVpTRUVaNG1LQVFHSUFVYUwvNG1LQVFHSUFUMGtSSXYvaVlvQkFZZ0JNaVZFaS8rSmlnRUJLWXYvVUltS0FnR0wvamdJaUFFaWdBVlRaVzUwSUV4UWdBSXVJRkNMLzFDSmlnTUJpLzFFaS80eUF4TkVpLzlFSW9tS0FRR0wvMWNDQUlBRlFVSkpMQ0JNVUVrVkZsY0dBa3hRaVlvQkFZQU5URzlqWVd3Z2MzUmhkR1VzSUl2L1VFa1ZGbGNHQWt4UWlZb0JBWXYvSTFtTC94V0wvMDRDVWxjQ0FDbE1VRWtWRmxjR0FreFFpLytCQWx1QkFnc1dnQUlBQ2t4UVRGQ0ppZ1FBZ0FScGJuUXhpL3huZ0FScGJuUXlpLzFuZ0FaaWVYUmxjekdML21lQUJtSjVkR1Z6TW92L1o0bUtCQUF4QUlBS2JHOWpZV3hmYVc1ME1ZdjhaakVBZ0Fwc2IyTmhiRjlwYm5ReWkvMW1NUUNBREd4dlkyRnNYMko1ZEdWek1ZditaakVBZ0F4c2IyTmhiRjlpZVhSbGN6S0wvMmFKaWdJQWkvNjhTSXYraS8rL2lTUkVpQUFIaVNWRWlBQUJpVEVBTWdrU1JJbUtBUUVxaS85QUFBV0FBVEJNaVl2L2dRb0tTWXdBUVFBY2l3Q0kvK0tMLzRFS0dJQUtNREV5TXpRMU5qYzRPVXdpV0ZCTWlTcEMvK1U9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnsiVVBEQVRBQkxFIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH0sIkRFTEVUQUJMRSI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9LCJWQUxVRSI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
