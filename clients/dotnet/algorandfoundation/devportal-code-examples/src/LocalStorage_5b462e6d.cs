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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.LocalStorage_5b462e6d
{


    //
    // A contract demonstrating local storage functionality.
    //This contract shows how to use local state storage in an Algorand smart contract,
    //including initialization, reading, writing, and clearing of local state values.
    //Local state is per-account storage that requires accounts to opt-in before use.
    //
    public class LocalStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LocalStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReadLocalStateReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public string Field3 { get; set; }

                public bool Field4 { get; set; }

                public Algorand.Address Field5 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReadLocalStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ReadLocalStateReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is bool vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is Algorand.Address vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReadLocalStateReturn);
                }
                public bool Equals(ReadLocalStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadLocalStateReturn left, ReadLocalStateReturn right)
                {
                    return EqualityComparer<ReadLocalStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadLocalStateReturn left, ReadLocalStateReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initializes local state values when an account opts into the application.
        ///This method can only be called during an OptIn transaction.
        ///Sets initial values for all local state variables:
        ///- localInt: 100
        ///- localIntNoDefault: 200
        ///- localBytes: 'Silvio'
        ///- localString: 'Micali'
        ///- localBool: true
        ///- localAccount: sender's address
        ///</summary>
        public async Task OptInToApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 163, 163, 255 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 163, 163, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reads and returns all local state values for the transaction sender.
        ///</summary>
        public async Task<Structs.ReadLocalStateReturn> ReadLocalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 1, 63, 197 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReadLocalStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadLocalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 1, 63, 197 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Updates multiple local state values for the transaction sender.
        ///Requires the account to be opted into the application.
        ///</summary>
        /// <param name="valueString">- New string value to store </param>
        /// <param name="valueBool">- New boolean value to store </param>
        /// <param name="valueAccount">- New account address to store </param>
        public async Task WriteLocalState(string valueString, bool valueBool, Algorand.Address valueAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 183, 156, 61 };
            var valueStringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueStringAbi.From(valueString);
            var valueBoolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueBoolAbi.From(valueBool);
            var valueAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAccountAbi.From(valueAccount);

            var result = await base.CallApp(new List<object> { abiHandle, valueStringAbi, valueBoolAbi, valueAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WriteLocalState_Transactions(string valueString, bool valueBool, Algorand.Address valueAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 183, 156, 61 };
            var valueStringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueStringAbi.From(valueString);
            var valueBoolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueBoolAbi.From(valueBool);
            var valueAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAccountAbi.From(valueAccount);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueStringAbi, valueBoolAbi, valueAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Writes a value to local state using a dynamic key.
        ///Demonstrates dynamic key-value storage in local state.
        ///</summary>
        /// <param name="key">- The dynamic key to store the value under </param>
        /// <param name="value">- The string value to store </param>
        public async Task<string> WriteDynamicLocalState(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 147, 194, 73 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> WriteDynamicLocalState_Transactions(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 147, 194, 73 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reads a value from local state using a dynamic key.
        ///</summary>
        /// <param name="key">- The dynamic key to read the value from </param>
        public async Task<string> ReadDynamicLocalState(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 54, 49, 245 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ReadDynamicLocalState_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 54, 49, 245 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Clears all local state values for the transaction sender.
        ///After calling this method, all local state values will be deleted.
        ///</summary>
        public async Task ClearLocalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 88, 5, 26 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClearLocalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 88, 5, 26 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9jYWxTdG9yYWdlIiwiZGVzYyI6IkEgY29udHJhY3QgZGVtb25zdHJhdGluZyBsb2NhbCBzdG9yYWdlIGZ1bmN0aW9uYWxpdHkuXG5UaGlzIGNvbnRyYWN0IHNob3dzIGhvdyB0byB1c2UgbG9jYWwgc3RhdGUgc3RvcmFnZSBpbiBhbiBBbGdvcmFuZCBzbWFydCBjb250cmFjdCxcbmluY2x1ZGluZyBpbml0aWFsaXphdGlvbiwgcmVhZGluZywgd3JpdGluZywgYW5kIGNsZWFyaW5nIG9mIGxvY2FsIHN0YXRlIHZhbHVlcy5cbkxvY2FsIHN0YXRlIGlzIHBlci1hY2NvdW50IHN0b3JhZ2UgdGhhdCByZXF1aXJlcyBhY2NvdW50cyB0byBvcHQtaW4gYmVmb3JlIHVzZS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUmVhZExvY2FsU3RhdGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcHRJblRvQXBwbGljYXRpb24iLCJkZXNjIjoiSW5pdGlhbGl6ZXMgbG9jYWwgc3RhdGUgdmFsdWVzIHdoZW4gYW4gYWNjb3VudCBvcHRzIGludG8gdGhlIGFwcGxpY2F0aW9uLlxuVGhpcyBtZXRob2QgY2FuIG9ubHkgYmUgY2FsbGVkIGR1cmluZyBhbiBPcHRJbiB0cmFuc2FjdGlvbi5cblNldHMgaW5pdGlhbCB2YWx1ZXMgZm9yIGFsbCBsb2NhbCBzdGF0ZSB2YXJpYWJsZXM6XG4tIGxvY2FsSW50OiAxMDBcbi0gbG9jYWxJbnROb0RlZmF1bHQ6IDIwMFxuLSBsb2NhbEJ5dGVzOiAnU2lsdmlvJ1xuLSBsb2NhbFN0cmluZzogJ01pY2FsaSdcbi0gbG9jYWxCb29sOiB0cnVlXG4tIGxvY2FsQWNjb3VudDogc2VuZGVyJ3MgYWRkcmVzcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZExvY2FsU3RhdGUiLCJkZXNjIjoiUmVhZHMgYW5kIHJldHVybnMgYWxsIGxvY2FsIHN0YXRlIHZhbHVlcyBmb3IgdGhlIHRyYW5zYWN0aW9uIHNlbmRlci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYnl0ZVtdLHN0cmluZyxib29sLGFkZHJlc3MpIiwic3RydWN0IjoiUmVhZExvY2FsU3RhdGVSZXR1cm4iLCJkZXNjIjoiQSB0dXBsZSBjb250YWluaW5nOlxuLSBbMF0gdWludDY0OiBUaGUgdmFsdWUgb2YgbG9jYWxJbnRcbi0gWzFdIHVpbnQ2NDogVGhlIHZhbHVlIG9mIGxvY2FsSW50Tm9EZWZhdWx0XG4tIFsyXSBieXRlczogVGhlIHZhbHVlIG9mIGxvY2FsQnl0ZXNcbi0gWzNdIHN0cmluZzogVGhlIHZhbHVlIG9mIGxvY2FsU3RyaW5nXG4tIFs0XSBib29sZWFuOiBUaGUgdmFsdWUgb2YgbG9jYWxCb29sXG4tIFs1XSBBZGRyZXNzOiBUaGUgdmFsdWUgb2YgbG9jYWxBY2NvdW50IGNvbnZlcnRlZCB0byBBZGRyZXNzIHR5cGUifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3cml0ZUxvY2FsU3RhdGUiLCJkZXNjIjoiVXBkYXRlcyBtdWx0aXBsZSBsb2NhbCBzdGF0ZSB2YWx1ZXMgZm9yIHRoZSB0cmFuc2FjdGlvbiBzZW5kZXIuXG5SZXF1aXJlcyB0aGUgYWNjb3VudCB0byBiZSBvcHRlZCBpbnRvIHRoZSBhcHBsaWNhdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVTdHJpbmciLCJkZXNjIjoiLSBOZXcgc3RyaW5nIHZhbHVlIHRvIHN0b3JlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVCb29sIiwiZGVzYyI6Ii0gTmV3IGJvb2xlYW4gdmFsdWUgdG8gc3RvcmUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZUFjY291bnQiLCJkZXNjIjoiLSBOZXcgYWNjb3VudCBhZGRyZXNzIHRvIHN0b3JlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndyaXRlRHluYW1pY0xvY2FsU3RhdGUiLCJkZXNjIjoiV3JpdGVzIGEgdmFsdWUgdG8gbG9jYWwgc3RhdGUgdXNpbmcgYSBkeW5hbWljIGtleS5cbkRlbW9uc3RyYXRlcyBkeW5hbWljIGtleS12YWx1ZSBzdG9yYWdlIGluIGxvY2FsIHN0YXRlLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiLSBUaGUgZHluYW1pYyBrZXkgdG8gc3RvcmUgdGhlIHZhbHVlIHVuZGVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiItIFRoZSBzdHJpbmcgdmFsdWUgdG8gc3RvcmUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHN0b3JlZCBzdHJpbmcgdmFsdWUifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWFkRHluYW1pY0xvY2FsU3RhdGUiLCJkZXNjIjoiUmVhZHMgYSB2YWx1ZSBmcm9tIGxvY2FsIHN0YXRlIHVzaW5nIGEgZHluYW1pYyBrZXkuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOiItIFRoZSBkeW5hbWljIGtleSB0byByZWFkIHRoZSB2YWx1ZSBmcm9tIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBzdG9yZWQgc3RyaW5nIHZhbHVlIGZvciB0aGUgZ2l2ZW4ga2V5In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXJMb2NhbFN0YXRlIiwiZGVzYyI6IkNsZWFycyBhbGwgbG9jYWwgc3RhdGUgdmFsdWVzIGZvciB0aGUgdHJhbnNhY3Rpb24gc2VuZGVyLlxuQWZ0ZXIgY2FsbGluZyB0aGlzIG1ldGhvZCwgYWxsIGxvY2FsIHN0YXRlIHZhbHVlcyB3aWxsIGJlIGRlbGV0ZWQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjMsImJ5dGVzIjo0fX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzQ5LDM5OCw0MzEsNDU4XSwiZXJyb3JNZXNzYWdlIjoiQWNjb3VudCBtdXN0IG9wdCBpbiB0byBjb250cmFjdCBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNl0sImVycm9yTWVzc2FnZSI6IktleSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBPcHRJbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI1LDIzMSwyMzgsMjQ1LDI1MSwyNTcsMzY5LDM3N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIExvY2FsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pzYjJOaGJGTjBjbWx1WnlJZ0lteHZZMkZzUW05dmJDSWdJbXh2WTJGc1FXTmpiM1Z1ZENJZ0ltbHVkQ0lnSW14dlkyRnNTVzUwVG05RVpXWmhkV3gwSWlBaWJHOWpZV3hDZVhSbGN5SWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJekxUSTBDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6ZEdGMFpWUnZkR0ZzY3pvZ2V5QnNiMk5oYkVKNWRHVnpPaUEwTENCc2IyTmhiRlZwYm5Sek9pQXpJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklFeHZZMkZzVTNSdmNtRm5aU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE5Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERmhNMkV6Wm1ZZ0x5OGdiV1YwYUc5a0lDSnZjSFJKYmxSdlFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDI5d2RFbHVWRzlCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU15MHlOQW9nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2diRzlqWVd4Q2VYUmxjem9nTkN3Z2JHOWpZV3hWYVc1MGN6b2dNeUI5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWkdWbVlYVnNkQ0JqYkdGemN5Qk1iMk5oYkZOMGIzSmhaMlVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdRd01ERXpabU0xSURCNFlUWmlOemxqTTJRZ01IZ3lOemt6WXpJME9TQXdlREl4TXpZek1XWTFJREI0TldVMU9EQTFNV0VnTHk4Z2JXVjBhRzlrSUNKeVpXRmtURzlqWVd4VGRHRjBaU2dwS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExITjBjbWx1Wnl4aWIyOXNMR0ZrWkhKbGMzTXBJaXdnYldWMGFHOWtJQ0ozY21sMFpVeHZZMkZzVTNSaGRHVW9jM1J5YVc1bkxHSnZiMndzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSjNjbWwwWlVSNWJtRnRhV05NYjJOaGJGTjBZWFJsS0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnlaV0ZrUkhsdVlXMXBZMHh2WTJGc1UzUmhkR1VvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMnhsWVhKTWIyTmhiRk4wWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2NtVmhaRXh2WTJGc1UzUmhkR1VnZDNKcGRHVk1iMk5oYkZOMFlYUmxJSGR5YVhSbFJIbHVZVzFwWTB4dlkyRnNVM1JoZEdVZ2NtVmhaRVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxJR05zWldGeVRHOWpZV3hUZEdGMFpRb2dJQ0FnWlhKeUNncHRZV2x1WDI5d2RFbHVWRzlCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkUGNIUkpiaWNnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCUGNIUkpiZ29nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTl3ZEVsdUlDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR0lnYjNCMFNXNVViMEZ3Y0d4cFkyRjBhVzl1Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU15MHlOQW9nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2diRzlqWVd4Q2VYUmxjem9nTkN3Z2JHOWpZV3hWYVc1MGN6b2dNeUI5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWkdWbVlYVnNkQ0JqYkdGemN5Qk1iMk5oYkZOMGIzSmhaMlVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmlBdkx5QnZiaUJsY25KdmNqb2dUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLQ2dvdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1J2Y21GblpTNXZjSFJKYmxSdlFYQndiR2xqWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0hSSmJsUnZRWEJ3YkdsallYUnBiMjQ2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VEc5allXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIUm9hWE11Ykc5allXeEpiblFvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNBeE1EQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdjSFZpYkdsaklHeHZZMkZzU1c1MElEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5hVzUwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWFXNTBJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1NXNTBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnTVRBd0NpQWdJQ0J3ZFhOb2FXNTBJREV3TUNBdkx5QXhNREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFbHVkRTV2UkdWbVlYVnNkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SURJd01Bb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QndkV0pzYVdNZ2JHOWpZV3hKYm5ST2IwUmxabUYxYkhRZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWliRzlqWVd4SmJuUk9iMFJsWm1GMWJIUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4SmJuUk9iMFJsWm1GMWJIUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0F5TURBS0lDQWdJSEIxYzJocGJuUWdNakF3SUM4dklESXdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1FubDBaWE1vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCQ2VYUmxjeWduVTJsc2RtbHZKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJR3h2WTJGc1FubDBaWE1nUFNCTWIyTmhiRk4wWVhSbFBHSjVkR1Z6UGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKc2IyTmhiRUo1ZEdWeklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW5sMFpYTW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JDZVhSbGN5Z25VMmxzZG1sdkp5a0tJQ0FnSUhCMWMyaGllWFJsY3lBaVUybHNkbWx2SWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNVM1J5YVc1bktGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdKMDFwWTJGc2FTY0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdjSFZpYkdsaklHeHZZMkZzVTNSeWFXNW5JRDBnVEc5allXeFRkR0YwWlR4emRISnBibWMrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW14dlkyRnNVM1J5YVc1bklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVTNSeWFXNW5LRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnSjAxcFkyRnNhU2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlUV2xqWVd4cElnb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW05dmJDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSFJ5ZFdVS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUd4dlkyRnNRbTl2YkNBOUlFeHZZMkZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliRzlqWVd4Q2IyOXNJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1FtOXZiQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUhSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hCWTJOdmRXNTBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCd2RXSnNhV01nYkc5allXeEJZMk52ZFc1MElEMGdURzlqWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pzYjJOaGJFRmpZMjkxYm5RaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hCWTJOdmRXNTBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RQY0hSSmJpY2dmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1J2Y21GblpTNXlaV0ZrVEc5allXeFRkR0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZV1JNYjJOaGJGTjBZWFJsT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QmpiMjV6ZENCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VEc5allXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklHTnZibk4wSUdGalkyOTFiblJCWkdSeVpYTnpJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWgwYUdsekxteHZZMkZzUVdOamIzVnVkQ2h6Wlc1a1pYSXBMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QndkV0pzYVdNZ2JHOWpZV3hCWTJOdmRXNTBJRDBnVEc5allXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc2IyTmhiRUZqWTI5MWJuUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdOdmJuTjBJR0ZqWTI5MWJuUkJaR1J5WlhOeklEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5aDBhR2x6TG14dlkyRnNRV05qYjNWdWRDaHpaVzVrWlhJcExuWmhiSFZsS1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4SmJuUW9jMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QndkV0pzYVdNZ2JHOWpZV3hKYm5RZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHBiblFuSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKcGJuUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4SmJuUW9jMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1NXNTBUbTlFWldaaGRXeDBLSE5sYm1SbGNpa3VkbUZzZFdVc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdjSFZpYkdsaklHeHZZMkZzU1c1MFRtOUVaV1poZFd4MElEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WTJGc1NXNTBUbTlFWldaaGRXeDBJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1NXNTBUbTlFWldaaGRXeDBLSE5sYm1SbGNpa3VkbUZzZFdVc0NpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05nb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFSjVkR1Z6S0hObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJR3h2WTJGc1FubDBaWE1nUFNCTWIyTmhiRk4wWVhSbFBHSjVkR1Z6UGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKc2IyTmhiRUo1ZEdWeklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW5sMFpYTW9jMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1UzUnlhVzVuS0hObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY0hWaWJHbGpJR3h2WTJGc1UzUnlhVzVuSUQwZ1RHOWpZV3hUZEdGMFpUeHpkSEpwYm1jK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lteHZZMkZzVTNSeWFXNW5JZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1UzUnlhVzVuS0hObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRUp2YjJ3b2MyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdjSFZpYkdsaklHeHZZMkZzUW05dmJDQTlJRXh2WTJGc1UzUmhkR1U4WW05dmJHVmhiajRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYkc5allXeENiMjlzSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNRbTl2YkNoelpXNWtaWElwTG5aaGJIVmxMQW9nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFeHZZMkZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek10T0RBS0lDQWdJQzh2SUhKbGRIVnliaUJiQ2lBZ0lDQXZMeUFnSUhSb2FYTXViRzlqWVd4SmJuUW9jMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2RHaHBjeTVzYjJOaGJFbHVkRTV2UkdWbVlYVnNkQ2h6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQjBhR2x6TG14dlkyRnNRbmwwWlhNb2MyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZEdocGN5NXNiMk5oYkZOMGNtbHVaeWh6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQjBhR2x6TG14dlkyRnNRbTl2YkNoelpXNWtaWElwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoWTJOdmRXNTBRV1JrY21WemN5d0tJQ0FnSUM4dklGMEtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEVXpJQzh2SURVekNpQWdJQ0FyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCd2RXSnNhV01nY21WaFpFeHZZMkZzVTNSaGRHVW9LVG9nVzNWcGJuUTJOQ3dnZFdsdWREWTBMQ0JpZVhSbGN5d2djM1J5YVc1bkxDQmliMjlzWldGdUxDQmhjbU0wTGtGa1pISmxjM05kSUhzS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12VEc5allXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9reHZZMkZzVTNSdmNtRm5aUzUzY21sMFpVeHZZMkZzVTNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzY21sMFpVeHZZMkZzVTNSaGRHVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUhCMVlteHBZeUIzY21sMFpVeHZZMkZzVTNSaGRHVW9kbUZzZFdWVGRISnBibWM2SUhOMGNtbHVaeXdnZG1Gc2RXVkNiMjlzT2lCaWIyOXNaV0Z1TENCMllXeDFaVUZqWTI5MWJuUTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2lBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdZWE56WlhKMEtITmxibVJsY2k1cGMwOXdkR1ZrU1c0b1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2Ymtsa0tTd2dKMEZqWTI5MWJuUWdiWFZ6ZENCdmNIUWdhVzRnZEc4Z1kyOXVkSEpoWTNRZ1ptbHljM1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGd2NGOXZjSFJsWkY5cGJnb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyOTFiblFnYlhWemRDQnZjSFFnYVc0Z2RHOGdZMjl1ZEhKaFkzUWdabWx5YzNRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVPQW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRk4wY21sdVp5aHpaVzVrWlhJcExuWmhiSFZsSUQwZ2RtRnNkV1ZUZEhKcGJtY0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiRzlqWVd4VGRISnBibWNnUFNCTWIyTmhiRk4wWVhSbFBITjBjbWx1Wno0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJHOWpZV3hUZEhKcGJtY2lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4VGRISnBibWNvYzJWdVpHVnlLUzUyWVd4MVpTQTlJSFpoYkhWbFUzUnlhVzVuQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazVDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNRbTl2YkNoelpXNWtaWElwTG5aaGJIVmxJRDBnZG1Gc2RXVkNiMjlzQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUd4dlkyRnNRbTl2YkNBOUlFeHZZMkZzVTNSaGRHVThZbTl2YkdWaGJqNG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliRzlqWVd4Q2IyOXNJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1FtOXZiQ2h6Wlc1a1pYSXBMblpoYkhWbElEMGdkbUZzZFdWQ2IyOXNDaUFnSUNCa2FXY2dOQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFRmpZMjkxYm5Rb2MyVnVaR1Z5S1M1MllXeDFaU0E5SUhaaGJIVmxRV05qYjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEIxWW14cFl5QnNiMk5oYkVGalkyOTFiblFnUFNCTWIyTmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lteHZZMkZzUVdOamIzVnVkQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeEJZMk52ZFc1MEtITmxibVJsY2lrdWRtRnNkV1VnUFNCMllXeDFaVUZqWTI5MWJuUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11Ykc5allXeFRkSEpwYm1jb2MyVnVaR1Z5S1M1MllXeDFaU0E5UFQwZ2RtRnNkV1ZUZEhKcGJtY3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJSEIxWW14cFl5QnNiMk5oYkZOMGNtbHVaeUE5SUV4dlkyRnNVM1JoZEdVOGMzUnlhVzVuUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKc2IyTmhiRk4wY21sdVp5SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxteHZZMkZzVTNSeWFXNW5LSE5sYm1SbGNpa3VkbUZzZFdVZ1BUMDlJSFpoYkhWbFUzUnlhVzVuS1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG14dlkyRnNRbTl2YkNoelpXNWtaWElwTG5aaGJIVmxJRDA5UFNCMllXeDFaVUp2YjJ3cENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QndkV0pzYVdNZ2JHOWpZV3hDYjI5c0lEMGdURzlqWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pzYjJOaGJFSnZiMndpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VEc5allXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVzYjJOaGJFSnZiMndvYzJWdVpHVnlLUzUyWVd4MVpTQTlQVDBnZG1Gc2RXVkNiMjlzS1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkM0pwZEdWTWIyTmhiRk4wWVhSbEtIWmhiSFZsVTNSeWFXNW5PaUJ6ZEhKcGJtY3NJSFpoYkhWbFFtOXZiRG9nWW05dmJHVmhiaXdnZG1Gc2RXVkJZMk52ZFc1ME9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa3h2WTJGc1UzUnZjbUZuWlM1M2NtbDBaVVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDNKcGRHVkVlVzVoYldsalRHOWpZV3hUZEdGMFpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUhCMVlteHBZeUIzY21sMFpVUjVibUZ0YVdOTWIyTmhiRk4wWVhSbEtHdGxlVG9nYzNSeWFXNW5MQ0IyWVd4MVpUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOd29nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5SUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhPUW9nSUNBZ0x5OGdZWE56WlhKMEtITmxibVJsY2k1cGMwOXdkR1ZrU1c0b1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2Ymtsa0tTd2dKMEZqWTI5MWJuUWdiWFZ6ZENCdmNIUWdhVzRnZEc4Z1kyOXVkSEpoWTNRZ1ptbHljM1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGd2NGOXZjSFJsWkY5cGJnb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyOTFiblFnYlhWemRDQnZjSFFnYVc0Z2RHOGdZMjl1ZEhKaFkzUWdabWx5YzNRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5TWIyTmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJR3h2WTJGc1JIbHVZVzFwWTBGalkyVnpjeWh6Wlc1a1pYSXBMblpoYkhWbElEMGdkbUZzZFdVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UWUtJQ0FnSUM4dklIQjFZbXhwWXlCM2NtbDBaVVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxLR3RsZVRvZ2MzUnlhVzVuTENCMllXeDFaVG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBNYjJOaGJGTjBiM0poWjJVdWNtVmhaRVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WaFpFUjVibUZ0YVdOTWIyTmhiRk4wWVhSbE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TndvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWVdSRWVXNWhiV2xqVEc5allXeFRkR0YwWlNoclpYazZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T0FvZ0lDQWdMeThnWTI5dWMzUWdjMlZ1WkdWeUlEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTUFvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNpNXBjMDl3ZEdWa1NXNG9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtLU3dnSjBGalkyOTFiblFnYlhWemRDQnZjSFFnYVc0Z2RHOGdZMjl1ZEhKaFkzUWdabWx5YzNRbktRb2dJQ0FnWkhWd0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRndjRjl2Y0hSbFpGOXBiZ29nSUNBZ1lYTnpaWEowSUM4dklFRmpZMjkxYm5RZ2JYVnpkQ0J2Y0hRZ2FXNGdkRzhnWTI5dWRISmhZM1FnWm1seWMzUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRRS0lDQWdJQzh2SUdGemMyVnlkQ2hzYjJOaGJFUjVibUZ0YVdOQlkyTmxjM01vYzJWdVpHVnlLUzVvWVhOV1lXeDFaU3dnSjB0bGVTQnViM1FnWm05MWJtUW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUV0bGVTQnViM1FnWm05MWJtUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldGa1JIbHVZVzFwWTB4dlkyRnNVM1JoZEdVb2EyVjVPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa3h2WTJGc1UzUnZjbUZuWlM1amJHVmhja3h2WTJGc1UzUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamJHVmhja3h2WTJGc1UzUmhkR1U2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VEc5allXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QmpiMjV6ZENCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VEc5allXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTRDaUFnSUNBdkx5QmhjM05sY25Rb2MyVnVaR1Z5TG1selQzQjBaV1JKYmloSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRcExDQW5RV05qYjNWdWRDQnRkWE4wSUc5d2RDQnBiaUIwYnlCamIyNTBjbUZqZENCbWFYSnpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhCd1gyOXdkR1ZrWDJsdUNpQWdJQ0JoYzNObGNuUWdMeThnUVdOamIzVnVkQ0J0ZFhOMElHOXdkQ0JwYmlCMGJ5QmpiMjUwY21GamRDQm1hWEp6ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRWx1ZENoelpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2NIVmliR2xqSUd4dlkyRnNTVzUwSUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmFXNTBKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpYVc1MElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTUFvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkVsdWRDaHpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0JoY0hCZmJHOWpZV3hmWkdWc0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlRHOWpZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl4Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzU1c1MFRtOUVaV1poZFd4MEtITmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QndkV0pzYVdNZ2JHOWpZV3hKYm5ST2IwUmxabUYxYkhRZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWliRzlqWVd4SmJuUk9iMFJsWm1GMWJIUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZeENpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1NXNTBUbTlFWldaaGRXeDBLSE5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUdGd2NGOXNiMk5oYkY5a1pXd0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpJS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4Q2VYUmxjeWh6Wlc1a1pYSXBMbVJsYkdWMFpTZ3BDaUFnSUNCa2RYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJR3h2WTJGc1FubDBaWE1nUFNCTWIyTmhiRk4wWVhSbFBHSjVkR1Z6UGlncENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKc2IyTmhiRUo1ZEdWeklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTWdvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkVKNWRHVnpLSE5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUdGd2NGOXNiMk5oYkY5a1pXd0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OU1iMk5oYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpNS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4VGRISnBibWNvYzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ1pIVndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZURzlqWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUhCMVlteHBZeUJzYjJOaGJGTjBjbWx1WnlBOUlFeHZZMkZzVTNSaGRHVThjM1J5YVc1blBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnNiMk5oYkZOMGNtbHVaeUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qTUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeFRkSEpwYm1jb2MyVnVaR1Z5S1M1a1pXeGxkR1VvS1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYMlJsYkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDB4dlkyRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOQW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRUp2YjJ3b2MyVnVaR1Z5S1M1a1pXeGxkR1VvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VEc5allXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIQjFZbXhwWXlCc2IyTmhiRUp2YjJ3Z1BTQk1iMk5oYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXh2WTJGc1FtOXZiQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qUUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeENiMjlzS0hObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lHRndjRjlzYjJOaGJGOWtaV3dLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlNYjJOaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUd4dlkyRnNRV05qYjNWdWRDQTlJRXh2WTJGc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkc5allXeEJZMk52ZFc1MElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwweHZZMkZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTlFvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkVGalkyOTFiblFvYzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ1lYQndYMnh2WTJGc1gyUmxiQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMHh2WTJGc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOc1pXRnlURzlqWVd4VGRHRjBaU2dwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUJ3dHNiMk5oYkZOMGNtbHVad2xzYjJOaGJFSnZiMndNYkc5allXeEJZMk52ZFc1MEEybHVkQkZzYjJOaGJFbHVkRTV2UkdWbVlYVnNkQXBzYjJOaGJFSjVkR1Z6QkJVZmZIVXhHMEVBU29BRUFhT2ovellhQUk0QkFESXhHUlJFTVJoRWdnVUUwQUUveFFTbXQ1dzlCQ2VUd2trRUlUWXg5UVJlV0FVYU5ob0FqZ1VBU0FDMkFPa0JFQUV4QURFWkl4SXhHQkJFUWdBSU1Sa1VNUmdVRUVNeEFDdUJaR1l4QUNjRWdjZ0JaakVBSndXQUJsTnBiSFpwYjJZeEFDaUFCazFwWTJGc2FXWXhBQ2tqWmpFQUtqRUFaaU5ETVFCSklpcGpSRXNCSWl0alJFc0NJaWNFWTBSTEF5SW5CV05FU3dRaUtHTkVUd1VpS1dORVR3UVdUd1FXVUVzREZSWlhCZ0pQQkZCTWdBSUFOVkJMQVJXQk5RaExCQlVXVndZQ1R3VlFUQlpYQmdKUEFreFFnQUVBSWs4RlZGQlBBMUJQQWxCTVVDY0dURkN3STBNMkdnRlhBZ0EyR2dJaVV6WWFBekVBU1RJSVlVUkpLRXNGWmtrcFN3Um1TU3BQQTJaSklpaGpSRThERWtRaUtXTkVFa00yR2dGWEFnQTJHZ0pYQWdBeEFFa3lDR0ZFVHdKTEFtWkpGUlpYQmdKTVVDY0dURkN3STBNMkdnRlhBZ0F4QUVreUNHRkVJazhDWTBSSkZSWlhCZ0pNVUNjR1RGQ3dJME14QUVreUNHRkVTU3RvU1NjRWFFa25CV2hKS0doSktXZ3FhQ05EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
