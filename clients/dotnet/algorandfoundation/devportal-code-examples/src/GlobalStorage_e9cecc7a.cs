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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.GlobalStorage_e9cecc7a
{


    //
    // A contract demonstrating global storage functionality
    //
    public class GlobalStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GlobalStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReadGlobalStateReturn : AVMObjectType
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

                public static ReadGlobalStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ReadGlobalStateReturn();
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
                    return Equals(obj as ReadGlobalStateReturn);
                }
                public bool Equals(ReadGlobalStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadGlobalStateReturn left, ReadGlobalStateReturn right)
                {
                    return EqualityComparer<ReadGlobalStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadGlobalStateReturn left, ReadGlobalStateReturn right)
                {
                    return !(left == right);
                }

            }

            public class HasGlobalStateReturn : AVMObjectType
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

                public static HasGlobalStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new HasGlobalStateReturn();
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
                    return Equals(obj as HasGlobalStateReturn);
                }
                public bool Equals(HasGlobalStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(HasGlobalStateReturn left, HasGlobalStateReturn right)
                {
                    return EqualityComparer<HasGlobalStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(HasGlobalStateReturn left, HasGlobalStateReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Reads and returns all global state values from the contract
        ///</summary>
        public async Task<Structs.ReadGlobalStateReturn> ReadGlobalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 143, 96, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReadGlobalStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadGlobalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 143, 96, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Checks if a global state value exists and returns it
        ///</summary>
        public async Task<Structs.HasGlobalStateReturn> HasGlobalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 180, 92, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.HasGlobalStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> HasGlobalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 180, 92, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Updates multiple global state values
        ///</summary>
        /// <param name="valueString"> </param>
        /// <param name="valueBool">New value for globalBool </param>
        /// <param name="valueAccount">New value for globalAccount </param>
        public async Task WriteGlobalState(string valueString, bool valueBool, Algorand.Address valueAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 121, 83, 220 };
            var valueStringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueStringAbi.From(valueString);
            var valueBoolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueBoolAbi.From(valueBool);
            var valueAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAccountAbi.From(valueAccount);

            var result = await base.CallApp(new List<object> { abiHandle, valueStringAbi, valueBoolAbi, valueAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WriteGlobalState_Transactions(string valueString, bool valueBool, Algorand.Address valueAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 121, 83, 220 };
            var valueStringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueStringAbi.From(valueString);
            var valueBoolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueBoolAbi.From(valueBool);
            var valueAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAccountAbi.From(valueAccount);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueStringAbi, valueBoolAbi, valueAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Writes a value to global state using a dynamic key and returns the stored value
        ///</summary>
        /// <param name="key">The key to store the value under in global state </param>
        /// <param name="value">The string value to store in global state </param>
        public async Task<string> WriteDynamicGlobalState(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 76, 107, 246 };
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

        public async Task<List<Transaction>> WriteDynamicGlobalState_Transactions(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 76, 107, 246 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> DeleteGlobalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 123, 31, 0 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DeleteGlobalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 123, 31, 0 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2xvYmFsU3RvcmFnZSIsImRlc2MiOiJBIGNvbnRyYWN0IGRlbW9uc3RyYXRpbmcgZ2xvYmFsIHN0b3JhZ2UgZnVuY3Rpb25hbGl0eSIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJSZWFkR2xvYmFsU3RhdGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiSGFzR2xvYmFsU3RhdGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVhZEdsb2JhbFN0YXRlIiwiZGVzYyI6IlJlYWRzIGFuZCByZXR1cm5zIGFsbCBnbG9iYWwgc3RhdGUgdmFsdWVzIGZyb20gdGhlIGNvbnRyYWN0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LGJ5dGVbXSxzdHJpbmcsYm9vbCxhZGRyZXNzKSIsInN0cnVjdCI6IlJlYWRHbG9iYWxTdGF0ZVJldHVybiIsImRlc2MiOiJBIHR1cGxlIGNvbnRhaW5pbmcgW2dsb2JhbEludCwgZ2xvYmFsSW50Tm9EZWZhdWx0LCBnbG9iYWxCeXRlcywgZ2xvYmFsU3RyaW5nLCBnbG9iYWxCb29sLCBnbG9iYWxBY2NvdW50XVxud2hlcmUgZWFjaCB2YWx1ZSBjb3JyZXNwb25kcyB0byB0aGUgY3VycmVudCBzdGF0ZSBvZiB0aGUgcmVzcGVjdGl2ZSBnbG9iYWwgdmFyaWFibGUifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoYXNHbG9iYWxTdGF0ZSIsImRlc2MiOiJDaGVja3MgaWYgYSBnbG9iYWwgc3RhdGUgdmFsdWUgZXhpc3RzIGFuZCByZXR1cm5zIGl0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJIYXNHbG9iYWxTdGF0ZVJldHVybiIsImRlc2MiOiJBIHR1cGxlIGNvbnRhaW5pbmcgW3ZhbHVlLCBoYXNWYWx1ZV0gd2hlcmUgdmFsdWUgaXMgdGhlIGN1cnJlbnQgZ2xvYmFsSW50Tm9EZWZhdWx0IHZhbHVlXG5hbmQgaGFzVmFsdWUgaW5kaWNhdGVzIGlmIHRoZSB2YWx1ZSBoYXMgYmVlbiBpbml0aWFsaXplZCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndyaXRlR2xvYmFsU3RhdGUiLCJkZXNjIjoiVXBkYXRlcyBtdWx0aXBsZSBnbG9iYWwgc3RhdGUgdmFsdWVzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlU3RyaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWVCb29sIiwiZGVzYyI6Ik5ldyB2YWx1ZSBmb3IgZ2xvYmFsQm9vbCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlQWNjb3VudCIsImRlc2MiOiJOZXcgdmFsdWUgZm9yIGdsb2JhbEFjY291bnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid3JpdGVEeW5hbWljR2xvYmFsU3RhdGUiLCJkZXNjIjoiV3JpdGVzIGEgdmFsdWUgdG8gZ2xvYmFsIHN0YXRlIHVzaW5nIGEgZHluYW1pYyBrZXkgYW5kIHJldHVybnMgdGhlIHN0b3JlZCB2YWx1ZSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiVGhlIGtleSB0byBzdG9yZSB0aGUgdmFsdWUgdW5kZXIgaW4gZ2xvYmFsIHN0YXRlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOiJUaGUgc3RyaW5nIHZhbHVlIHRvIHN0b3JlIGluIGdsb2JhbCBzdGF0ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3RvcmVkIHN0cmluZyB2YWx1ZSwgY29uZmlybWluZyBzdWNjZXNzZnVsIHN0b3JhZ2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVHbG9iYWxTdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0MF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OSwyMDMsMjA3LDIxMiwyMTYsMjIwLDI5NiwzNDMsMzUxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0puYkc5aVlXeFRkSEpwYm1jaUlDSm5iRzlpWVd4Q2IyOXNJaUFpWjJ4dlltRnNTVzUwSWlBaVoyeHZZbUZzU1c1MFRtOUVaV1poZFd4MElpQWlaMnh2WW1Gc1FXTmpiM1Z1ZENJZ01IZ3hOVEZtTjJNM05TQWlaMnh2WW1Gc1FubDBaWE1pQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZSMnh2WW1Gc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCd2RXSnNhV01nWjJ4dlltRnNTVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RVd0tTQjlLU0F2THlCVlNXNTBOalFnZDJsMGFDQmtaV1poZFd4MElIWmhiSFZsQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0puYkc5aVlXeEpiblFpQ2lBZ0lDQndkWE5vYVc1MElEVXdJQzh2SURVd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnY0hWaWJHbGpJR2RzYjJKaGJFSjVkR1Z6SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCQ2VYUmxjeWduVTJsc2RtbHZKeWtnZlNrZ0x5OGdRbmwwWlhNZ2QybDBhQ0JrWldaaGRXeDBJSFpoYkhWbENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKbmJHOWlZV3hDZVhSbGN5SUtJQ0FnSUhCMWMyaGllWFJsY3lBaVUybHNkbWx2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSEIxWW14cFl5Qm5iRzlpWVd4VGRISnBibWNnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBblRXbGpZV3hwSnlCOUtTQXZMeUJDZVhSbGN5QjNhWFJvSUdSbFptRjFiSFFnZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHNiMkpoYkZOMGNtbHVaeUlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlUV2xqWVd4cElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUhiRzlpWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUhCMVlteHBZeUJuYkc5aVlXeENiMjlzSUQwZ1IyeHZZbUZzVTNSaGRHVW9leUJwYm1sMGFXRnNWbUZzZFdVNklIUnlkV1VnZlNrZ0x5OGdRbTl2YkNCM2FYUm9JR1JsWm1GMWJIUWdkbUZzZFdVS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1kc2IySmhiRUp2YjJ3aUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJSEIxWW14cFl5Qm5iRzlpWVd4SmJuUk9iMFJsWm1GMWJIUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrZ0x5OGdWVWx1ZERZMElIZHBkR2dnYm04Z1pHVm1ZWFZzZENCMllXeDFaUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlaMnh2WW1Gc1NXNTBUbTlFWldaaGRXeDBJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z2RHaHBjeTVuYkc5aVlXeEpiblJPYjBSbFptRjFiSFF1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdkc2IySmhiRUZqWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncElDOHZJRUZrWkhKbGMzTWdkMmwwYUNCdWJ5QmtaV1poZFd4MElIWmhiSFZsQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0puYkc5aVlXeEJZMk52ZFc1MElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnZEdocGN5NW5iRzlpWVd4QlkyTnZkVzUwTG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnkweE9Bb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUhzZ1oyeHZZbUZzUW5sMFpYTTZJRFFzSUdkc2IySmhiRlZwYm5Sek9pQXpJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklFZHNiMkpoYkZOMGIzSmhaMlVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaRE00WmpZd056SWdNSGcwTjJJME5XTmtNU0F3ZUdKaE56azFNMlJqSURCNE5HRTBZelppWmpZZ01IZ3pZemRpTVdZd01DQXZMeUJ0WlhSb2IyUWdJbkpsWVdSSGJHOWlZV3hUZEdGMFpTZ3BLSFZwYm5RMk5DeDFhVzUwTmpRc1lubDBaVnRkTEhOMGNtbHVaeXhpYjI5c0xHRmtaSEpsYzNNcElpd2diV1YwYUc5a0lDSm9ZWE5IYkc5aVlXeFRkR0YwWlNncEtIVnBiblEyTkN4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpZDNKcGRHVkhiRzlpWVd4VGRHRjBaU2h6ZEhKcGJtY3NZbTl2YkN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbmR5YVhSbFJIbHVZVzFwWTBkc2IySmhiRk4wWVhSbEtITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0prWld4bGRHVkhiRzlpWVd4VGRHRjBaU2dwWW05dmJDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSEpsWVdSSGJHOWlZV3hUZEdGMFpTQm9ZWE5IYkc5aVlXeFRkR0YwWlNCM2NtbDBaVWRzYjJKaGJGTjBZWFJsSUhkeWFYUmxSSGx1WVcxcFkwZHNiMkpoYkZOMFlYUmxJR1JsYkdWMFpVZHNiMkpoYkZOMFlYUmxDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnkweE9Bb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUhzZ1oyeHZZbUZzUW5sMFpYTTZJRFFzSUdkc2IySmhiRlZwYm5Sek9pQXpJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklFZHNiMkpoYkZOMGIzSmhaMlVnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmlBdkx5QnZiaUJsY25KdmNqb2dUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNDQW1KaUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLQ2dvdkx5QmpiMjUwY21GamRITXZSMnh2WW1Gc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwSGJHOWlZV3hUZEc5eVlXZGxMbkpsWVdSSGJHOWlZV3hUZEdGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWVdSSGJHOWlZV3hUZEdGMFpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUhiRzlpWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdOdmJuTjBJR0ZqWTI5MWJuUkJaR1J5WlhOeklEMGdibVYzSUdGeVl6UXVRV1JrY21WemN5aDBhR2x6TG1kc2IySmhiRUZqWTI5MWJuUXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBkc2IySmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdjSFZpYkdsaklHZHNiMkpoYkVGalkyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BJQzh2SUVGa1pISmxjM01nZDJsMGFDQnVieUJrWldaaGRXeDBJSFpoYkhWbENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbmJHOWlZV3hCWTJOdmRXNTBJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z1kyOXVjM1FnWVdOamIzVnVkRUZrWkhKbGMzTWdQU0J1WlhjZ1lYSmpOQzVCWkdSeVpYTnpLSFJvYVhNdVoyeHZZbUZzUVdOamIzVnVkQzUyWVd4MVpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlIyeHZZbUZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUIwYUdsekxtZHNiMkpoYkVsdWRDNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UjJ4dlltRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QndkV0pzYVdNZ1oyeHZZbUZzU1c1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEVXdLU0I5S1NBdkx5QlZTVzUwTmpRZ2QybDBhQ0JrWldaaGRXeDBJSFpoYkhWbENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbmJHOWlZV3hKYm5RaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlIyeHZZbUZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUIwYUdsekxtZHNiMkpoYkVsdWRDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UjJ4dlltRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QjBhR2x6TG1kc2IySmhiRWx1ZEU1dlJHVm1ZWFZzZEM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZSMnh2WW1Gc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCd2RXSnNhV01nWjJ4dlltRnNTVzUwVG05RVpXWmhkV3gwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BJQzh2SUZWSmJuUTJOQ0IzYVhSb0lHNXZJR1JsWm1GMWJIUWdkbUZzZFdVS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1kc2IySmhiRWx1ZEU1dlJHVm1ZWFZzZENJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJSFJvYVhNdVoyeHZZbUZzU1c1MFRtOUVaV1poZFd4MExuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIUm9hWE11WjJ4dlltRnNRbmwwWlhNdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdkc2IySmhiRUo1ZEdWeklEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQkNlWFJsY3lnblUybHNkbWx2SnlrZ2ZTa2dMeThnUW5sMFpYTWdkMmwwYUNCa1pXWmhkV3gwSUhaaGJIVmxDaUFnSUNCaWVYUmxZeUEySUM4dklDSm5iRzlpWVd4Q2VYUmxjeUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIUm9hWE11WjJ4dlltRnNRbmwwWlhNdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTVuYkc5aVlXeFRkSEpwYm1jdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2NIVmliR2xqSUdkc2IySmhiRk4wY21sdVp5QTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJQ2ROYVdOaGJHa25JSDBwSUM4dklFSjVkR1Z6SUhkcGRHZ2daR1ZtWVhWc2RDQjJZV3gxWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWjJ4dlltRnNVM1J5YVc1bklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnZEdocGN5NW5iRzlpWVd4VGRISnBibWN1ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnZEdocGN5NW5iRzlpWVd4Q2IyOXNMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSEIxWW14cFl5Qm5iRzlpWVd4Q2IyOXNJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUhSeWRXVWdmU2tnTHk4Z1FtOXZiQ0IzYVhSb0lHUmxabUYxYkhRZ2RtRnNkV1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWRzYjJKaGJFSnZiMndpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UjJ4dlltRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QjBhR2x6TG1kc2IySmhiRUp2YjJ3dWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9DMDFOUW9nSUNBZ0x5OGdjbVYwZFhKdUlGc0tJQ0FnSUM4dklDQWdkR2hwY3k1bmJHOWlZV3hKYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUhSb2FYTXVaMnh2WW1Gc1NXNTBUbTlFWldaaGRXeDBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQjBhR2x6TG1kc2IySmhiRUo1ZEdWekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCMGFHbHpMbWRzYjJKaGJGTjBjbWx1Wnk1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZEdocGN5NW5iRzlpWVd4Q2IyOXNMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhZMk52ZFc1MFFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUYwS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBek5Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURVeklDOHZJRFV6Q2lBZ0lDQXJDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWVdSSGJHOWlZV3hUZEdGMFpTZ3BPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUXNJR0o1ZEdWekxDQnpkSEpwYm1jc0lHSnZiMnhsWVc0c0lHRnlZelF1UVdSa2NtVnpjMTBnZXdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rZHNiMkpoYkZOMGIzSmhaMlV1YUdGelIyeHZZbUZzVTNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BvWVhOSGJHOWlZV3hUZEdGMFpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUhiRzlpWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdOdmJuTjBJR2hoYzFaaGJIVmxJRDBnZEdocGN5NW5iRzlpWVd4SmJuUk9iMFJsWm1GMWJIUXVhR0Z6Vm1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlIyeHZZbUZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMnh2WW1Gc1NXNTBUbTlFWldaaGRXeDBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncElDOHZJRlZKYm5RMk5DQjNhWFJvSUc1dklHUmxabUYxYkhRZ2RtRnNkV1VLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWRzYjJKaGJFbHVkRTV2UkdWbVlYVnNkQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHTnZibk4wSUdoaGMxWmhiSFZsSUQwZ2RHaHBjeTVuYkc5aVlXeEpiblJPYjBSbFptRjFiSFF1YUdGelZtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlIyeHZZbUZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJqYjI1emRDQjJZV3gxWlNBOUlIUm9hWE11WjJ4dlltRnNTVzUwVG05RVpXWmhkV3gwTG5aaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklISmxkSFZ5YmlCYmRtRnNkV1VzSUdoaGMxWmhiSFZsWFFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UjJ4dlltRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QndkV0pzYVdNZ2FHRnpSMnh2WW1Gc1UzUmhkR1VvS1RvZ1czVnBiblEyTkN3Z1ltOXZiR1ZoYmwwZ2V3b2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa2RzYjJKaGJGTjBiM0poWjJVdWQzSnBkR1ZIYkc5aVlXeFRkR0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHlhWFJsUjJ4dlltRnNVM1JoZEdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlIyeHZZbUZzVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkM0pwZEdWSGJHOWlZV3hUZEdGMFpTaDJZV3gxWlZOMGNtbHVaem9nYzNSeWFXNW5MQ0IyWVd4MVpVSnZiMnc2SUdKdmIyeGxZVzRzSUhaaGJIVmxRV05qYjNWdWREb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSEIxWW14cFl5Qm5iRzlpWVd4VGRISnBibWNnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBblRXbGpZV3hwSnlCOUtTQXZMeUJDZVhSbGN5QjNhWFJvSUdSbFptRjFiSFFnZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHNiMkpoYkZOMGNtbHVaeUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklIUm9hWE11WjJ4dlltRnNVM1J5YVc1bkxuWmhiSFZsSUQwZ2RtRnNkV1ZUZEhKcGJtY0tJQ0FnSUdScFp5QXpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdkc2IySmhiRUp2YjJ3Z1BTQkhiRzlpWVd4VGRHRjBaU2g3SUdsdWFYUnBZV3hXWVd4MVpUb2dkSEoxWlNCOUtTQXZMeUJDYjI5c0lIZHBkR2dnWkdWbVlYVnNkQ0IyWVd4MVpRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVoyeHZZbUZzUW05dmJDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUhiRzlpWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUhSb2FYTXVaMnh2WW1Gc1FtOXZiQzUyWVd4MVpTQTlJSFpoYkhWbFFtOXZiQW9nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UjJ4dlltRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QndkV0pzYVdNZ1oyeHZZbUZzUVdOamIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDa2dMeThnUVdSa2NtVnpjeUIzYVhSb0lHNXZJR1JsWm1GMWJIUWdkbUZzZFdVS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1kc2IySmhiRUZqWTI5MWJuUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZSMnh2WW1Gc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCMGFHbHpMbWRzYjJKaGJFRmpZMjkxYm5RdWRtRnNkV1VnUFNCMllXeDFaVUZqWTI5MWJuUUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZSMnh2WW1Gc1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NW5iRzlpWVd4VGRISnBibWN1ZG1Gc2RXVWdQVDA5SUhaaGJIVmxVM1J5YVc1bktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSEIxWW14cFl5Qm5iRzlpWVd4VGRISnBibWNnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBblRXbGpZV3hwSnlCOUtTQXZMeUJDZVhSbGN5QjNhWFJvSUdSbFptRjFiSFFnZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZHNiMkpoYkZOMGNtbHVaeUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWRzYjJKaGJGTjBjbWx1Wnk1MllXeDFaU0E5UFQwZ2RtRnNkV1ZUZEhKcGJtY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UjJ4dlltRnNVM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVuYkc5aVlXeENiMjlzTG5aaGJIVmxJRDA5UFNCMllXeDFaVUp2YjJ3cENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBkc2IySmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdjSFZpYkdsaklHZHNiMkpoYkVKdmIyd2dQU0JIYkc5aVlXeFRkR0YwWlNoN0lHbHVhWFJwWVd4V1lXeDFaVG9nZEhKMVpTQjlLU0F2THlCQ2IyOXNJSGRwZEdnZ1pHVm1ZWFZzZENCMllXeDFaUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaMnh2WW1Gc1FtOXZiQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbWRzYjJKaGJFSnZiMnd1ZG1Gc2RXVWdQVDA5SUhaaGJIVmxRbTl2YkNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z2NIVmliR2xqSUhkeWFYUmxSMnh2WW1Gc1UzUmhkR1VvZG1Gc2RXVlRkSEpwYm1jNklITjBjbWx1Wnl3Z2RtRnNkV1ZDYjI5c09pQmliMjlzWldGdUxDQjJZV3gxWlVGalkyOTFiblE2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlIYkc5aVlXeFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rZHNiMkpoYkZOMGIzSmhaMlV1ZDNKcGRHVkVlVzVoYldsalIyeHZZbUZzVTNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzY21sMFpVUjVibUZ0YVdOSGJHOWlZV3hUZEdGMFpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUhiRzlpWVd4VGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUhCMVlteHBZeUIzY21sMFpVUjVibUZ0YVdOSGJHOWlZV3hUZEdGMFpTaHJaWGs2SUhOMGNtbHVaeXdnZG1Gc2RXVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SGJHOWlZV3hUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF5Q2lBZ0lDQXZMeUJuYkc5aVlXeEVlVzVoYldsalFXTmpaWE56TG5aaGJIVmxJRDBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhkeWFYUmxSSGx1WVcxcFkwZHNiMkpoYkZOMFlYUmxLR3RsZVRvZ2MzUnlhVzVuTENCMllXeDFaVG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UjJ4dlltRnNVM1J2Y21GblpTNWtaV3hsZEdWSGJHOWlZV3hUZEdGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsYkdWMFpVZHNiMkpoYkZOMFlYUmxPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGRzYjJKaGJGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdkc2IySmhiRWx1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnMU1Da2dmU2tnTHk4Z1ZVbHVkRFkwSUhkcGRHZ2daR1ZtWVhWc2RDQjJZV3gxWlFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWjJ4dlltRnNTVzUwSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBkc2IySmhiRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJSFJvYVhNdVoyeHZZbUZzU1c1MExtUmxiR1YwWlNncENpQWdJQ0JoY0hCZloyeHZZbUZzWDJSbGJBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwZHNiMkpoYkZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUhCMVlteHBZeUJrWld4bGRHVkhiRzlpWVd4VGRHRjBaU2dwT2lCaWIyOXNaV0Z1SUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FBRW1Cd3huYkc5aVlXeFRkSEpwYm1jS1oyeHZZbUZzUW05dmJBbG5iRzlpWVd4SmJuUVNaMnh2WW1Gc1NXNTBUbTlFWldaaGRXeDBEV2RzYjJKaGJFRmpZMjkxYm5RRUZSOThkUXRuYkc5aVlXeENlWFJsY3pFWVFBQWtLb0V5WnljR2dBWlRhV3gyYVc5bktJQUdUV2xqWVd4cFp5a2paeXNpWnljRU1RQm5NUnRCQURJeEdSUkVNUmhFZ2dVRTA0OWdjZ1JIdEZ6UkJMcDVVOXdFU2t4cjlnUThleDhBTmhvQWpnVUFDUUJxQUlBQXFBREhBREVaRkRFWUZCQkRJaWNFWlVRaUttVkVJaXRsUkNJbkJtVkVJaWhsUkNJcFpVUlBCQlpQQkJaUVN3TVZGbGNHQWs4RVVFeUFBZ0ExVUVzQkZZRTFDRXNFRlJaWEJnSlBCVkJNRmxjR0FrOENURkNBQVFBaVR3VlVVRThEVUU4Q1VFeFFKd1ZNVUxBalF5SXJaVWxFVEJhQUFRQWlUd05VVUNjRlRGQ3dJME0yR2dGWEFnQTJHZ0lpVXpZYUF5aExBMmNwU3dKbkp3Uk1aeUlvWlVSUEFoSkVJaWxsUkJKRE5ob0JWd0lBTmhvQ1Z3SUFURXNCWjBrVkZsY0dBa3hRSndWTVVMQWpReXBwZ0FVVkgzeDFnTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
