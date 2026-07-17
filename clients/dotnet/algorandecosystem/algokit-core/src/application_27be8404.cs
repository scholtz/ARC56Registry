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

namespace Arc56.Generated.algorandecosystem.algokit_core.application_27be8404
{


    public class StateManagementDemoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StateManagementDemoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGVNYW5hZ2VtZW50RGVtbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJJbnB1dCI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWdlIiwidHlwZSI6InVpbnQ2NCJ9XSwiT3V0cHV0IjpbeyJuYW1lIjoibWVzc2FnZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJyZXN1bHQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hYmkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5wdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZV9hYmkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5wdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlcnJvciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX2FiaV90eG4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsbF93aXRoX3JlZmVyZW5jZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYXNzZXQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWZhdWx0X3ZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyZ193aXRoX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOnsic291cmNlIjoibGl0ZXJhbCIsImRhdGEiOiJBQTFrWldaaGRXeDBJSFpoYkhWbCIsInR5cGUiOiJzdHJpbmcifX1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVmYXVsdF92YWx1ZV9pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJsaXRlcmFsIiwiZGF0YSI6IkFBQUFBQUFBQUhzPSIsInR5cGUiOiJ1aW50NjQifX1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVmYXVsdF92YWx1ZV9mcm9tX2FiaSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxpdGVyYWwiLCJkYXRhIjoiQUExa1pXWmhkV3gwSUhaaGJIVmwiLCJ0eXBlIjoic3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9nbG9iYWxfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJnX3dpdGhfZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6eyJzb3VyY2UiOiJnbG9iYWwiLCJkYXRhIjoiYVc1ME1RPT0iLCJ0eXBlIjoiQVZNU3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlZmF1bHRfdmFsdWVfZnJvbV9sb2NhbF9zdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmdfd2l0aF9kZWZhdWx0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxvY2FsIiwiZGF0YSI6ImJHOWpZV3hmWW5sMFpYTXgiLCJ0eXBlIjoiQVZNU3RyaW5nIn19XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0cnVjdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZyx1aW50NjQpIiwic3RydWN0IjoiSW5wdXQiLCJuYW1lIjoibmFtZV9hZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyx1aW50NjQpIiwic3RydWN0IjoiT3V0cHV0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2dsb2JhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2xvY2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludDEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ5dGVzMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ5dGVzMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjoyLCJieXRlcyI6M319LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIiwiT3B0SW4iXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiIsIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjIwLDkyN10sImVycm9yTWVzc2FnZSI6IkNoZWNrIGFwcCBpcyBkZWxldGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDksOTE4XSwiZXJyb3JNZXNzYWdlIjoiQ2hlY2sgYXBwIGlzIHVwZGF0YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNl0sImVycm9yTWVzc2FnZSI6IkRlbGliZXJhdGUgZXJyb3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjRdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgRGVsZXRlQXBwbGljYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzYsMTU0LDE4MywyMTIsMjMxLDI1MywyNjgsMjg3LDMwMiwzMTcsMzUyLDM5Miw0MjIsNTA0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBPcHRJbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgVXBkYXRlQXBwbGljYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzFdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IG5vdCBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3NF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIG5vdCBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2NV0sImVycm9yTWVzc2FnZSI6ImFzc2V0IG5vdCBwcm92aWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwOCw1NzBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzksMTU3LDE4NiwyMTUsMjM0LDI1NiwyNzEsMjkwLDMwNSwzMjAsMzU1LDM5NSw0MjUsNDM0LDQ0NSw0NzcsNTUzLDU2MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0MF0sImVycm9yTWVzc2FnZSI6InVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGRHVXVZMjl1ZEhKaFkzUXVVM1JoZEdVdVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRlJOVUV4ZlZWQkVRVlJCUWt4RklGUk5VRXhmUkVWTVJWUkJRa3hGSUZSTlVFeGZWa0ZNVlVVS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaVNHVnNiRzhzSUNJZ0lpSUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHVW9SWGhoYlhCc1pVRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTWpJS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNVpEVXlNekEwTUNBd2VETmpZVFZqWldJM0lEQjRNamN4WWpSbFpUa2dNSGd6TUdNMlpEVTRZU0F3ZURRMFpEQmtZVEJrSURCNFpqRTNaVGd3WVRVZ01IZ3dZVGt5WVRneFpTQXdlR1psWm1SbU1URmxJREI0TlRjMFlqVTFZemdnTUhnek5qQXpOakpsT1NBd2VEUTJaREl4TVdFeklEQjRNR05tWTJKaU1EQWdNSGhrTUdZd1ltRm1PQ0F3ZURJME5tSmxZamd6SURCNFlUUmpaamhrWldFZ01IaGpaV015T0RNMFlTQXdlR0UwWWpSaE1qTXdJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMkZpYVNoemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0oxY0dSaGRHVmZZV0pwS0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbVJsYkdWMFpWOWhZbWtvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWliM0IwWDJsdUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbGNuSnZjaWdwZG05cFpDSXNJRzFsZEdodlpDQWlZMkZzYkY5aFlta29jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVkyRnNiRjloWW1sZmRIaHVLSEJoZVN4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pqWVd4c1gzZHBkR2hmY21WbVpYSmxibU5sY3loaGMzTmxkQ3hoWTJOdmRXNTBMR0Z3Y0d4cFkyRjBhVzl1S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWkdWbVlYVnNkRjkyWVd4MVpTaHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKa1pXWmhkV3gwWDNaaGJIVmxYMmx1ZENoMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0prWldaaGRXeDBYM1poYkhWbFgyWnliMjFmWVdKcEtITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1SbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5bmJHOWlZV3hmYzNSaGRHVW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHVm1ZWFZzZEY5MllXeDFaVjltY205dFgyeHZZMkZzWDNOMFlYUmxLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTjBjblZqZEhNb0tITjBjbWx1Wnl4MWFXNTBOalFwS1NoemRISnBibWNzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpYzJWMFgyZHNiMkpoYkNoMWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5eGllWFJsV3pSZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOXNiMk5oYkNoMWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5eGllWFJsV3pSZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOWliM2dvWW5sMFpWczBYU3h6ZEhKcGJtY3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxYMkZpYVY5eWIzVjBaVUExSUcxaGFXNWZkWEJrWVhSbFgyRmlhVjl5YjNWMFpVQTJJRzFoYVc1ZlpHVnNaWFJsWDJGaWFWOXliM1YwWlVBM0lHMWhhVzVmYjNCMFgybHVYM0p2ZFhSbFFEZ2diV0ZwYmw5bGNuSnZjbDl5YjNWMFpVQTVJRzFoYVc1ZlkyRnNiRjloWW1sZmNtOTFkR1ZBTVRBZ2JXRnBibDlqWVd4c1gyRmlhVjkwZUc1ZmNtOTFkR1ZBTVRFZ2JXRnBibDlqWVd4c1gzZHBkR2hmY21WbVpYSmxibU5sYzE5eWIzVjBaVUF4TWlCdFlXbHVYMlJsWm1GMWJIUmZkbUZzZFdWZmNtOTFkR1ZBTVRNZ2JXRnBibDlrWldaaGRXeDBYM1poYkhWbFgybHVkRjl5YjNWMFpVQXhOQ0J0WVdsdVgyUmxabUYxYkhSZmRtRnNkV1ZmWm5KdmJWOWhZbWxmY205MWRHVkFNVFVnYldGcGJsOWtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZaMnh2WW1Gc1gzTjBZWFJsWDNKdmRYUmxRREUySUcxaGFXNWZaR1ZtWVhWc2RGOTJZV3gxWlY5bWNtOXRYMnh2WTJGc1gzTjBZWFJsWDNKdmRYUmxRREUzSUcxaGFXNWZjM1J5ZFdOMGMxOXliM1YwWlVBeE9DQnRZV2x1WDNObGRGOW5iRzlpWVd4ZmNtOTFkR1ZBTVRrZ2JXRnBibDl6WlhSZmJHOWpZV3hmY205MWRHVkFNakFnYldGcGJsOXpaWFJmWW05NFgzSnZkWFJsUURJeENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNalk2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNelFLSUNBZ0lDOHZJR05zWVhOeklGTjBZWFJsS0VWNFlXMXdiR1ZCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUmZZbTk0WDNKdmRYUmxRREl4T2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHVW9SWGhoYlhCc1pVRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzJWMFgySnZlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJmYkc5allXeGZjbTkxZEdWQU1qQTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJqYkdGemN5QlRkR0YwWlNoRmVHRnRjR3hsUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBYMnh2WTJGc0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGOW5iRzlpWVd4ZmNtOTFkR1ZBTVRrNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBaU2hGZUdGdGNHeGxRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVEk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzJWMFgyZHNiMkpoYkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6ZEhKMVkzUnpYM0p2ZFhSbFFERTRPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXlOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdVb1JYaGhiWEJzWlVGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1USTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdjM1J5ZFdOMGN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5a1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZmJHOWpZV3hmYzNSaGRHVmZjbTkxZEdWQU1UYzZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU3dnWkdWbVlYVnNkRjloY21kelBYc2lZWEpuWDNkcGRHaGZaR1ZtWVhWc2RDSTZJQ0pzYjJOaGJGOWllWFJsY3pFaWZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCamJHRnpjeUJUZEdGMFpTaEZlR0Z0Y0d4bFFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU3dnWkdWbVlYVnNkRjloY21kelBYc2lZWEpuWDNkcGRHaGZaR1ZtWVhWc2RDSTZJQ0pzYjJOaGJGOWllWFJsY3pFaWZTa0tJQ0FnSUdOaGJHeHpkV0lnWkdWbVlYVnNkRjkyWVd4MVpWOW1jbTl0WDJ4dlkyRnNYM04wWVhSbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJSbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5bmJHOWlZV3hmYzNSaGRHVmZjbTkxZEdWQU1UWTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1URTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU3dnWkdWbVlYVnNkRjloY21kelBYc2lZWEpuWDNkcGRHaGZaR1ZtWVhWc2RDSTZJQ0pwYm5ReEluMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCamJHRnpjeUJUZEdGMFpTaEZlR0Z0Y0d4bFFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsTENCa1pXWmhkV3gwWDJGeVozTTlleUpoY21kZmQybDBhRjlrWldaaGRXeDBJam9nSW1sdWRERWlmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlJsWm1GMWJIUmZkbUZzZFdWZlpuSnZiVjloWW1sZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTd2daR1ZtWVhWc2RGOWhjbWR6UFhzaVlYSm5YM2RwZEdoZlpHVm1ZWFZzZENJNklHRnlZelF1VTNSeWFXNW5LQ0prWldaaGRXeDBJSFpoYkhWbElpbDlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklHTnNZWE56SUZOMFlYUmxLRVY0WVcxd2JHVkJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVc0lHUmxabUYxYkhSZllYSm5jejE3SW1GeVoxOTNhWFJvWDJSbFptRjFiSFFpT2lCaGNtTTBMbE4wY21sdVp5Z2laR1ZtWVhWc2RDQjJZV3gxWlNJcGZTa0tJQ0FnSUdOaGJHeHpkV0lnWkdWbVlYVnNkRjkyWVd4MVpWOW1jbTl0WDJGaWFRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5a1pXWmhkV3gwWDNaaGJIVmxYMmx1ZEY5eWIzVjBaVUF4TkRvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmtaV1poZFd4MFgyRnlaM005ZXlKaGNtZGZkMmwwYUY5a1pXWmhkV3gwSWpvZ1lYSmpOQzVWU1c1ME5qUW9NVEl6S1gwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJqYkdGemN5QlRkR0YwWlNoRmVHRnRjR3hsUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxMQ0JrWldaaGRXeDBYMkZ5WjNNOWV5SmhjbWRmZDJsMGFGOWtaV1poZFd4MElqb2dZWEpqTkM1VlNXNTBOalFvTVRJektYMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtaV1poZFd4MFgzWmhiSFZsWDNKdmRYUmxRREV6T2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPakV3TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVc0lHUmxabUYxYkhSZllYSm5jejE3SW1GeVoxOTNhWFJvWDJSbFptRjFiSFFpT2lCaGNtTTBMbE4wY21sdVp5Z2laR1ZtWVhWc2RDQjJZV3gxWlNJcGZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhSbEtFVjRZVzF3YkdWQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VzSUdSbFptRjFiSFJmWVhKbmN6MTdJbUZ5WjE5M2FYUm9YMlJsWm1GMWJIUWlPaUJoY21NMExsTjBjbWx1WnlnaVpHVm1ZWFZzZENCMllXeDFaU0lwZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOaGJHeGZkMmwwYUY5eVpXWmxjbVZ1WTJWelgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBaU2hGZUdGdGNHeGxRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRndjR3hwWTJGMGFXOXVjd29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdZMkZzYkY5M2FYUm9YM0psWm1WeVpXNWpaWE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZzYkY5aFltbGZkSGh1WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPamswQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJqYkdGemN5QlRkR0YwWlNoRmVHRnRjR3hsUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzVOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHTmhiR3hmWVdKcFgzUjRiZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyRnNiRjloWW1sZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhSbEtFVjRZVzF3YkdWQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdOaGJHeGZZV0pwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWxjbkp2Y2w5eWIzVjBaVUE1T2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPamcyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPamc0Q2lBZ0lDQXZMeUJoYzNObGNuUWdSbUZzYzJVc0lDSkVaV3hwWW1WeVlYUmxJR1Z5Y205eUlpQWdJeUJ1YjNGaE9pQlFWREF4TlN3Z1FqQXhNUW9nSUNBZ1pYSnlJQzh2SUVSbGJHbGlaWEpoZEdVZ1pYSnliM0lLQ20xaGFXNWZiM0IwWDJsdVgzSnZkWFJsUURnNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUM0IwU1c0aVhTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QlBjSFJKYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTl3ZEVsdUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaR1ZzWlhSbFgyRmlhVjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklHTnNZWE56SUZOMFlYUmxLRVY0WVcxd2JHVkJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnWTJGc2JITjFZaUJrWld4bGRHVmZZV0pwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWZllXSnBYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QlZjR1JoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUZWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHVW9SWGhoYlhCc1pVRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWxWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1SWwwcENpQWdJQ0JqWVd4c2MzVmlJSFZ3WkdGMFpWOWhZbWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5aFltbGZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJqYkdGemN5QlRkR0YwWlNoRmVHRnRjR3hsUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZmWVdKcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1qSTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklHTnNZWE56SUZOMFlYUmxLRVY0WVcxd2JHVkJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYzNkcGRHTm9JRzFoYVc1ZlkzSmxZWFJsUURJeklHMWhhVzVmWTNKbFlYUmxRREl6SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU5pQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNallnYldGcGJsOTFjR1JoZEdWQU1qUWdiV0ZwYmw5a1pXeGxkR1ZBTWpVS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJMkNncHRZV2x1WDJSbGJHVjBaVUF5TlRvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR1JsYkdWMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWNHUmhkR1ZBTWpRNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnUUdGeVl6UXVZbUZ5WlcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lWWEJrWVhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkzSmxZWFJsUURJek9nb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCQVlYSmpOQzVpWVhKbGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lzSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lpd2dJazl3ZEVsdUlsMHBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGRHVXVZMjl1ZEhKaFkzUXVVM1JoZEdVdVkzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPall3TFRZeENpQWdJQ0F2THlCQVlYSmpOQzVpWVhKbGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lzSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lpd2dJazl3ZEVsdUlsMHBDaUFnSUNBdkx5QmtaV1lnWTNKbFlYUmxLSE5sYkdZcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXdJREFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncENpQWdJQ0JqWVd4c2MzVmlJR0YxZEdodmNtbDZaVjlqY21WaGRHOXlDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklITmxiR1l1ZG1Gc2RXVWdQU0JVWlcxd2JHRjBaVlpoY2x0VlNXNTBOalJkS0ZaQlRGVkZYMVJGVFZCTVFWUkZYMDVCVFVVcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5aaGJIVmxJZ29nSUNBZ2FXNTBZeUEwSUM4dklGUk5VRXhmVmtGTVZVVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhkR1V1WTI5dWRISmhZM1F1VTNSaGRHVXVZM0psWVhSbFgyRmlhU2hwYm5CMWREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGpjbVZoZEdWZllXSnBPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qWTFMVFkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUM4dklHUmxaaUJqY21WaGRHVmZZV0pwS0hObGJHWXNJR2x1Y0hWME9pQlRkSEpwYm1jcElDMCtJRk4wY21sdVp6b2dJQ01nYm05eFlUb2dRVEF3TWdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklITmxiR1l1WVhWMGFHOXlhWHBsWDJOeVpXRjBiM0lvS1FvZ0lDQWdZMkZzYkhOMVlpQmhkWFJvYjNKcGVtVmZZM0psWVhSdmNnb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pZNENpQWdJQ0F2THlCeVpYUjFjbTRnYVc1d2RYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlYUmxMbU52Ym5SeVlXTjBMbE4wWVhSbExuVndaR0YwWlY5aFlta29hVzV3ZFhRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RYQmtZWFJsWDJGaWFUb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvM01DMDNNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnTHk4Z1pHVm1JSFZ3WkdGMFpWOWhZbWtvYzJWc1ppd2dhVzV3ZFhRNklGTjBjbWx1WnlrZ0xUNGdVM1J5YVc1bk9pQWdJeUJ1YjNGaE9pQkJNREF5Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z2MyVnNaaTVoZFhSb2IzSnBlbVZmWTNKbFlYUnZjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHRjFkR2h2Y21sNlpWOWpjbVZoZEc5eUNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUdGemMyVnlkQ0JVWlcxd2JHRjBaVlpoY2x0aWIyOXNYU2hWVUVSQlZFRkNURVZmVkVWTlVFeEJWRVZmVGtGTlJTa3NJQ0pEYUdWamF5QmhjSEFnYVhNZ2RYQmtZWFJoWW14bElnb2dJQ0FnYVc1MFkxOHlJQzh2SUZSTlVFeGZWVkJFUVZSQlFreEZDaUFnSUNCaGMzTmxjblFnTHk4Z1EyaGxZMnNnWVhCd0lHbHpJSFZ3WkdGMFlXSnNaUW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QnlaWFIxY200Z2FXNXdkWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdaWGhoYlhCc1pYTXVjMjFoY25SZlkyOXVkSEpoWTNSekxuTjBZWFJsTG1OdmJuUnlZV04wTGxOMFlYUmxMbVJsYkdWMFpWOWhZbWtvYVc1d2RYUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taR1ZzWlhSbFgyRmlhVG9LSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzNOaTAzTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ0x5OGdaR1ZtSUdSbGJHVjBaVjloWW1rb2MyVnNaaXdnYVc1d2RYUTZJRk4wY21sdVp5a2dMVDRnVTNSeWFXNW5PaUFnSXlCdWIzRmhPaUJCTURBeUNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncENpQWdJQ0JqWVd4c2MzVmlJR0YxZEdodmNtbDZaVjlqY21WaGRHOXlDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklHRnpjMlZ5ZENCVVpXMXdiR0YwWlZaaGNsdGliMjlzWFNoRVJVeEZWRUZDVEVWZlZFVk5VRXhCVkVWZlRrRk5SU2tzSUNKRGFHVmpheUJoY0hBZ2FYTWdaR1ZzWlhSaFlteGxJZ29nSUNBZ2FXNTBZMTh6SUM4dklGUk5VRXhmUkVWTVJWUkJRa3hGQ2lBZ0lDQmhjM05sY25RZ0x5OGdRMmhsWTJzZ1lYQndJR2x6SUdSbGJHVjBZV0pzWlFvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdhVzV3ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVhSbExtTnZiblJ5WVdOMExsTjBZWFJsTG1OaGJHeGZZV0pwS0haaGJIVmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU5oYkd4ZllXSnBPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qa3dMVGt4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQmpZV3hzWDJGaWFTaHpaV3htTENCMllXeDFaVG9nVTNSeWFXNW5LU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpU0dWc2JHOHNJQ0lwSUNzZ2RtRnNkV1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJa2hsYkd4dkxDQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdaWGhoYlhCc1pYTXVjMjFoY25SZlkyOXVkSEpoWTNSekxuTjBZWFJsTG1OdmJuUnlZV04wTGxOMFlYUmxMbU5oYkd4ZllXSnBYM1I0YmloMGVHNDZJSFZwYm5RMk5Dd2dkbUZzZFdVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1kyRnNiRjloWW1sZmRIaHVPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qazBMVGsxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQmpZV3hzWDJGaWFWOTBlRzRvYzJWc1ppd2dkSGh1T2lCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaXdnZG1Gc2RXVTZJRk4wY21sdVp5a2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JbE5sYm5RZ0lpa2dLeUJ6Wld4bUxtbDBiMkVvZEhodUxtRnRiM1Z1ZENrZ0t5QlRkSEpwYm1jb0lpNGdJaWtnS3lCMllXeDFaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdOaGJHeHpkV0lnYVhSdllRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVFpXNTBJQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l1SUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxuTnRZWEowWDJOdmJuUnlZV04wY3k1emRHRjBaUzVqYjI1MGNtRmpkQzVUZEdGMFpTNWpZV3hzWDNkcGRHaGZjbVZtWlhKbGJtTmxjeWhoYzNObGREb2dkV2x1ZERZMExDQmhZMk52ZFc1ME9pQmllWFJsY3l3Z1lYQndiR2xqWVhScGIyNDZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BqWVd4c1gzZHBkR2hmY21WbVpYSmxibU5sY3pvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG81T0MwNU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1kyRnNiRjkzYVhSb1gzSmxabVZ5Wlc1alpYTW9jMlZzWml3Z1lYTnpaWFE2SUVGemMyVjBMQ0JoWTJOdmRXNTBPaUJCWTJOdmRXNTBMQ0JoY0hCc2FXTmhkR2x2YmpvZ1FYQndiR2xqWVhScGIyNHBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGemMyVjBMQ0FpWVhOelpYUWdibTkwSUhCeWIzWnBaR1ZrSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhRZ2JtOTBJSEJ5YjNacFpHVmtDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QmhjM05sY25RZ1lXTmpiM1Z1ZEN3Z0ltRmpZMjkxYm5RZ2JtOTBJSEJ5YjNacFpHVmtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQnViM1FnY0hKdmRtbGtaV1FLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjSEJzYVdOaGRHbHZiaXdnSW1Gd2NHeHBZMkYwYVc5dUlHNXZkQ0J3Y205MmFXUmxaQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJRzV2ZENCd2NtOTJhV1JsWkFvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxuTnRZWEowWDJOdmJuUnlZV04wY3k1emRHRjBaUzVqYjI1MGNtRmpkQzVUZEdGMFpTNWtaV1poZFd4MFgzWmhiSFZsWDJaeWIyMWZZV0pwS0dGeVoxOTNhWFJvWDJSbFptRjFiSFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWkdWbVlYVnNkRjkyWVd4MVpWOW1jbTl0WDJGaWFUb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1UTXRNVEUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlN3Z1pHVm1ZWFZzZEY5aGNtZHpQWHNpWVhKblgzZHBkR2hmWkdWbVlYVnNkQ0k2SUdGeVl6UXVVM1J5YVc1bktDSmtaV1poZFd4MElIWmhiSFZsSWlsOUtRb2dJQ0FnTHk4Z1pHVm1JR1JsWm1GMWJIUmZkbUZzZFdWZlpuSnZiVjloWW1rb2MyVnNaaXdnWVhKblgzZHBkR2hmWkdWbVlYVnNkRG9nWVhKak5DNVRkSEpwYm1jcElDMCtJR0Z5WXpRdVUzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1URTFDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKQlFra3NJQ0lwSUNzZ1lYSm5YM2RwZEdoZlpHVm1ZWFZzZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROREUwTWpRNU1tTXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdaWGhoYlhCc1pYTXVjMjFoY25SZlkyOXVkSEpoWTNSekxuTjBZWFJsTG1OdmJuUnlZV04wTGxOMFlYUmxMbVJsWm1GMWJIUmZkbUZzZFdWZlpuSnZiVjlzYjJOaGJGOXpkR0YwWlNoaGNtZGZkMmwwYUY5a1pXWmhkV3gwT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21SbFptRjFiSFJmZG1Gc2RXVmZabkp2YlY5c2IyTmhiRjl6ZEdGMFpUb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5emRHRjBaUzlqYjI1MGNtRmpkQzV3ZVRveE1qRXRNVEl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlN3Z1pHVm1ZWFZzZEY5aGNtZHpQWHNpWVhKblgzZHBkR2hmWkdWbVlYVnNkQ0k2SUNKc2IyTmhiRjlpZVhSbGN6RWlmU2tLSUNBZ0lDOHZJR1JsWmlCa1pXWmhkV3gwWDNaaGJIVmxYMlp5YjIxZmJHOWpZV3hmYzNSaGRHVW9jMlZzWml3Z1lYSm5YM2RwZEdoZlpHVm1ZWFZzZERvZ1UzUnlhVzVuS1NBdFBpQmhjbU0wTGxOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFeU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVVM1J5YVc1bktGTjBjbWx1WnlnaVRHOWpZV3dnYzNSaGRHVXNJQ0lwSUNzZ1lYSm5YM2RwZEdoZlpHVm1ZWFZzZENrS0lDQWdJSEIxYzJoaWVYUmxjeUFpVEc5allXd2djM1JoZEdVc0lDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlYUmxMbU52Ym5SeVlXTjBMbE4wWVhSbExuTjBjblZqZEhNb2JtRnRaVjloWjJVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2MzUnlkV04wY3pvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TWpVdE1USTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpkSEoxWTNSektITmxiR1lzSUc1aGJXVmZZV2RsT2lCSmJuQjFkQ2tnTFQ0Z1QzVjBjSFYwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhkR1V2WTI5dWRISmhZM1F1Y0hrNk1USTNDaUFnSUNBdkx5QnlaWFIxY200Z1QzVjBjSFYwS0dGeVl6UXVVM1J5YVc1bktGTjBjbWx1WnlnaVNHVnNiRzhzSUNJcElDc2dibUZ0WlY5aFoyVXVibUZ0WlM1dVlYUnBkbVVwTENCaGNtTTBMbFZKYm5RMk5DaHVZVzFsWDJGblpTNWhaMlV1Ym1GMGFYWmxJQ29nTWlrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lraGxiR3h2TENBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNaUE0SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNR0VLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCbGVHRnRjR3hsY3k1emJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGRHVXVZMjl1ZEhKaFkzUXVVM1JoZEdVdWMyVjBYMmRzYjJKaGJDaHBiblF4T2lCMWFXNTBOalFzSUdsdWRESTZJSFZwYm5RMk5Dd2dZbmwwWlhNeE9pQmllWFJsY3l3Z1lubDBaWE15T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LYzJWMFgyZHNiMkpoYkRvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TWprdE1UTXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpaWFJmWjJ4dlltRnNLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNJR2x1ZERFNklGVkpiblEyTkN3Z2FXNTBNam9nVlVsdWREWTBMQ0JpZVhSbGN6RTZJRk4wY21sdVp5d2dZbmwwWlhNeU9pQmhjbU0wTGxOMFlYUnBZMEZ5Y21GNVcyRnlZelF1UW5sMFpTd2dUR2wwWlhKaGJGczBYVjBLSUNBZ0lDOHZJQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z2MyVnNaaTVwYm5ReElEMGdhVzUwTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pwYm5ReElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z2MyVnNaaTVwYm5ReUlEMGdhVzUwTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pwYm5ReUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlYUmxMMk52Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z2MyVnNaaTVpZVhSbGN6RWdQU0JpZVhSbGN6RXVZbmwwWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUFpWW5sMFpYTXhJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXpOZ29nSUNBZ0x5OGdjMlZzWmk1aWVYUmxjeklnUFNCaWVYUmxjekl1WW5sMFpYTUtJQ0FnSUhCMWMyaGllWFJsY3lBaVlubDBaWE15SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVhSbExtTnZiblJ5WVdOMExsTjBZWFJsTG5ObGRGOXNiMk5oYkNocGJuUXhPaUIxYVc1ME5qUXNJR2x1ZERJNklIVnBiblEyTkN3Z1lubDBaWE14T2lCaWVYUmxjeXdnWW5sMFpYTXlPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tjMlYwWDJ4dlkyRnNPZ29nSUNBZ0x5OGdaWGhoYlhCc1pYTXZjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZWFJsTDJOdmJuUnlZV04wTG5CNU9qRXpPQzB4TkRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhObGRGOXNiMk5oYkNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTENCcGJuUXhPaUJWU1c1ME5qUXNJR2x1ZERJNklGVkpiblEyTkN3Z1lubDBaWE14T2lCVGRISnBibWNzSUdKNWRHVnpNam9nWVhKak5DNVRkR0YwYVdOQmNuSmhlVnRoY21NMExrSjVkR1VzSUV4cGRHVnlZV3hiTkYxZENpQWdJQ0F2THlBcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QTBJREFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJSE5sYkdZdWJHOWpZV3hmYVc1ME1WdFVlRzR1YzJWdVpHVnlYU0E5SUdsdWRERUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSEIxYzJoaWVYUmxjeUFpYkc5allXeGZhVzUwTVNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVhSbEwyTnZiblJ5WVdOMExuQjVPakUwTXdvZ0lDQWdMeThnYzJWc1ppNXNiMk5oYkY5cGJuUXlXMVI0Ymk1elpXNWtaWEpkSUQwZ2FXNTBNZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKc2IyTmhiRjlwYm5ReUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCelpXeG1MbXh2WTJGc1gySjVkR1Z6TVZ0VWVHNHVjMlZ1WkdWeVhTQTlJR0o1ZEdWek1TNWllWFJsY3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2NIVnphR0o1ZEdWeklDSnNiMk5oYkY5aWVYUmxjekVpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0YwWlM5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJSE5sYkdZdWJHOWpZV3hmWW5sMFpYTXlXMVI0Ymk1elpXNWtaWEpkSUQwZ1lubDBaWE15TG1KNWRHVnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW14dlkyRnNYMko1ZEdWek1pSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1pYaGhiWEJzWlhNdWMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlYUmxMbU52Ym5SeVlXTjBMbE4wWVhSbExuTmxkRjlpYjNnb2JtRnRaVG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyVjBYMkp2ZURvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGMFpTOWpiMjUwY21GamRDNXdlVG94TkRjdE1UUTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpaWFJmWW05NEtITmxiR1lzSUc1aGJXVTZJR0Z5WXpRdVUzUmhkR2xqUVhKeVlYbGJZWEpqTkM1Q2VYUmxMQ0JNYVhSbGNtRnNXelJkWFN3Z2RtRnNkV1U2SUdGeVl6UXVVM1J5YVc1bktTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZjM1JoZEdVdlkyOXVkSEpoWTNRdWNIazZNVFE1Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlRnR1WVcxbFhTQTlJSFpoYkhWbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxuTnRZWEowWDJOdmJuUnlZV04wY3k1aVlYTmxMbU52Ym5SeVlXTjBMa2x0YlhWMFlXSnBiR2wwZVVOdmJuUnliMnhCVWtNMFEyOXVkSEpoWTNRdWRYQmtZWFJsS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsT2dvZ0lDQWdMeThnWlhoaGJYQnNaWE12YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlkyOXVkSEpoWTNRdWNIazZNak10TWpRS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQXZMeUJrWldZZ2RYQmtZWFJsS0hObGJHWXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF3SURBS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwyTnZiblJ5WVdOMExuQjVPakkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdWR1Z0Y0d4aGRHVldZWEpiWW05dmJGMG9WVkJFUVZSQlFreEZYMVJGVFZCTVFWUkZYMDVCVFVVcExDQWlRMmhsWTJzZ1lYQndJR2x6SUhWd1pHRjBZV0pzWlNJS0lDQWdJR2x1ZEdOZk1pQXZMeUJVVFZCTVgxVlFSRUZVUVVKTVJRb2dJQ0FnWVhOelpYSjBJQzh2SUVOb1pXTnJJR0Z3Y0NCcGN5QjFjR1JoZEdGaWJHVUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMk52Ym5SeVlXTjBMbkI1T2pJMkNpQWdJQ0F2THlCelpXeG1MbUYxZEdodmNtbDZaVjlqY21WaGRHOXlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdWNFlXMXdiR1Z6TG5OdFlYSjBYMk52Ym5SeVlXTjBjeTVpWVhObExtTnZiblJ5WVdOMExsQmxjbTFoYm1WdVkyVkRiMjUwY205c1FWSkRORU52Ym5SeVlXTjBMbVJsYkdWMFpTZ3BJQzArSUhadmFXUTZDbVJsYkdWMFpUb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMk52Ym5SeVlXTjBMbkI1T2pNd0xUTXhDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnTHk4Z1pHVm1JR1JsYkdWMFpTaHpaV3htS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01DQXdDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRvek1nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSbGJYQnNZWFJsVm1GeVcySnZiMnhkS0VSRlRFVlVRVUpNUlY5VVJVMVFURUZVUlY5T1FVMUZLU3dnSWtOb1pXTnJJR0Z3Y0NCcGN5QmtaV3hsZEdGaWJHVWlDaUFnSUNCcGJuUmpYek1nTHk4Z1ZFMVFURjlFUlV4RlZFRkNURVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR1ZqYXlCaGNIQWdhWE1nWkdWc1pYUmhZbXhsQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncENpQWdJQ0JqWVd4c2MzVmlJR0YxZEdodmNtbDZaVjlqY21WaGRHOXlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltRnpaUzVqYjI1MGNtRmpkQzVDWVhObFFWSkRORU52Ym5SeVlXTjBMbUYxZEdodmNtbDZaVjlqY21WaGRHOXlLQ2tnTFQ0Z2RtOXBaRG9LWVhWMGFHOXlhWHBsWDJOeVpXRjBiM0k2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUbzRMVGtLSUNBZ0lDOHZJRUJ6ZFdKeWIzVjBhVzVsQ2lBZ0lDQXZMeUJrWldZZ1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJb2MyVnNaaWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURBZ01Bb2dJQ0FnTHk4Z1pYaGhiWEJzWlhNdmMyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TVRBS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKMWJtRjFkR2h2Y21sNlpXUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVoZFhSb2IzSnBlbVZrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVZbUZ6WlM1amIyNTBjbUZqZEM1Q1lYTmxRVkpETkVOdmJuUnlZV04wTG1sMGIyRW9hVG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LYVhSdllUb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMk52Ym5SeVlXTjBMbkI1T2pFeUxURXpDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUdsMGIyRW9jMlZzWml3Z2FUb2dWVWx1ZERZMEtTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR0o1ZEdWalh6SWdMeThnSWlJS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwyTnZiblJ5WVdOMExuQjVPakUwQ2lBZ0lDQXZMeUJwWmlCcElEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ltNTZJR2wwYjJGZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMk52Ym5SeVlXTjBMbkI1T2pFMUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0l3SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpTUNJS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0thWFJ2WVY5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklHVjRZVzF3YkdWekwzTnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMk52Ym5SeVlXTjBMbkI1T2pFM0NpQWdJQ0F2THlCeVpYUjFjbTRnS0hObGJHWXVhWFJ2WVNocElDOHZJRlZKYm5RMk5DZ3hNQ2twSUdsbUlDaHBJQzh2SUZWSmJuUTJOQ2d4TUNrcElENGdWVWx1ZERZMEtEQXBJR1ZzYzJVZ1UzUnlhVzVuS0NJaUtTa2dLeUJUZEhKcGJtY3Vabkp2YlY5aWVYUmxjeWdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBeE1DQXZMeUF4TUFvZ0lDQWdMd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdKNklHbDBiMkZmZEdWeWJtRnllVjltWVd4elpVQTBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWTJGc2JITjFZaUJwZEc5aENncHBkRzloWDNSbGNtNWhjbmxmYldWeVoyVkFOVG9LSUNBZ0lDOHZJR1Y0WVcxd2JHVnpMM050WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QlRkSEpwYm1jb0lqQXhNak0wTlRZM09Ea2lLUzVpZVhSbGMxdHBJQ1VnVlVsdWREWTBLREV3S1YwS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXhNQ0F2THlBeE1Bb2dJQ0FnSlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l3TVRJek5EVTJOemc1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG94TnkweE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUNoelpXeG1MbWwwYjJFb2FTQXZMeUJWU1c1ME5qUW9NVEFwS1NCcFppQW9hU0F2THlCVlNXNTBOalFvTVRBcEtTQStJRlZKYm5RMk5DZ3dLU0JsYkhObElGTjBjbWx1WnlnaUlpa3BJQ3NnVTNSeWFXNW5MbVp5YjIxZllubDBaWE1vQ2lBZ0lDQXZMeUFnSUNBZ1UzUnlhVzVuS0NJd01USXpORFUyTnpnNUlpa3VZbmwwWlhOYmFTQWxJRlZKYm5RMk5DZ3hNQ2xkQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0thWFJ2WVY5MFpYSnVZWEo1WDJaaGJITmxRRFE2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdjbVYwZFhKdUlDaHpaV3htTG1sMGIyRW9hU0F2THlCVlNXNTBOalFvTVRBcEtTQnBaaUFvYVNBdkx5QlZTVzUwTmpRb01UQXBLU0ErSUZWSmJuUTJOQ2d3S1NCbGJITmxJRk4wY21sdVp5Z2lJaWtwSUNzZ1UzUnlhVzVuTG1aeWIyMWZZbmwwWlhNb0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0JpSUdsMGIyRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFRQUFBQUFtQXdRVkgzeDFCMGhsYkd4dkxDQUFNUnRCQWcrQ0VRU2RVakJBQkR5bHpyY0VKeHRPNlFRd3h0V0tCRVRRMmcwRThYNkFwUVFLa3FnZUJQNzk4UjRFVjB0VnlBUTJBMkxwQkViU0VhTUVEUHk3QUFUUThMcjRCQ1JyNjRNRXBNK042Z1RPd29OS0JLUzBvakEyR2dDT0VRRnlBVklCTWdFb0FTQUJBZ0RhQUxjQXFBQ1pBSVlBZHdCaEFFNEFNUUFVQUFJalF6RVpGRVF4R0VRMkdnRTJHZ0tJQXZBaVF6RVpGRVF4R0VRMkdnRVhOaG9DRnpZYUExY0NBRFlhQklnQ2h5SkRNUmtVUkRFWVJEWWFBUmMyR2dJWE5ob0RWd0lBTmhvRWlBSStJa014R1JSRU1SaEVOaG9CaUFIL0tFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FJZ0J5eWhNVUxBaVF6RVpGRVF4R0VRb05ob0JVTEFpUXpFWkZFUXhHRVEyR2dHSUFZOG9URkN3SWtNeEdSUkVNUmhFS0RZYUFWQ3dJa014R1JSRU1SaEVLRFlhQVZDd0lrTXhHUlJFTVJoRU5ob0JGOEF3TmhvQ0Y4QWNOaG9ERjhBeWlBRStGaWhNVUxBaVF6RVpGRVF4R0VReEZpSUpTVGdRSWhKRU5ob0JWd0lBaUFFQlNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQWlBRGJTUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFQURFWkloSkVNUmhFSWtNeEdZRUZFa1F4R0VRMkdnRlhBZ0NJQUo1SkZSWlhCZ0pNVUNoTVVMQWlRekVaZ1FRU1JERVlSRFlhQVZjQ0FJZ0FjMGtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZRkVRMkdnRlhBZ0NJQUV0SkZSWlhCZ0pNVUNoTVVMQWlRekVaalFZQUV3QVQvbC8rWHdBTEFBTkMvbHd4R0VTSUFXNGlRekVZUklnQlhTSkRNUmdVUklnQUFpSkRpZ0FBaUFGZWdBVjJZV3gxWlNFRVo0bUtBUUdJQVUyTC80bUtBUUdJQVVRa1JJdi9pWW9CQVlnQk9TVkVpLytKaWdFQktZdi9VSW1LQWdHTC9qZ0lpQUVzZ0FWVFpXNTBJRXhRZ0FJdUlGQ0wvMUNKaWdNQmkvMUVpLzR5QXhORWkvOUVJb21LQVFHTC8xY0NBSUFGUVVKSkxDQk1VRWtWRmxjR0FreFFpWW9CQVlBTlRHOWpZV3dnYzNSaGRHVXNJSXYvVUVrVkZsY0dBa3hRaVlvQkFZdi9JMW1ML3hXTC8wNENVbGNDQUNsTVVFa1ZGbGNHQWt4UWkvOVhBZ2dYZ1FJTEZvQUNBQXBNVUV4UWlZb0VBSUFFYVc1ME1ZdjhaNEFFYVc1ME1vdjlaNEFHWW5sMFpYTXhpLzVuZ0FaaWVYUmxjektMLzJlSmlnUUFNUUNBQ214dlkyRnNYMmx1ZERHTC9HWXhBSUFLYkc5allXeGZhVzUwTW92OVpqRUFnQXhzYjJOaGJGOWllWFJsY3pHTC9tWXhBSUFNYkc5allXeGZZbmwwWlhNeWkvOW1pWW9DQUl2K3ZFaUwvb3YvdjRtS0FBQWtSSWdBQ29tS0FBQWxSSWdBQVltS0FBQXhBRElKRWtTSmlnRUJLb3YvUUFBRmdBRXdUSW1MLzRFS0NrbU1BRUVBSElzQWlQL2lpLytCQ2hpQUNqQXhNak0wTlRZM09EbE1JbGhRVElrcVF2L2wiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjozLCJwYXRjaCI6MywiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJVUERBVEFCTEUiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfSwiREVMRVRBQkxFIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH0sIlZBTFVFIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
