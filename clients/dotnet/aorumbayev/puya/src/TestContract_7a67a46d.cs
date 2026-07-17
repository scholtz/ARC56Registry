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

namespace Arc56.Generated.aorumbayev.puya.TestContract_7a67a46d
{


    public class TestContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CreateArgTupleParam : AVMObjectType
            {
                public bool Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public string Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.From(Field4);
                    stringRef[ret.Count] = vField4.Encode();
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

                public static CreateArgTupleParam Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new CreateArgTupleParam();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
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
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    var indexField4 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.Decode(bytes.Skip(indexField4 + prefixOffset).ToArray());
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is string vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CreateArgTupleParam);
                }
                public bool Equals(CreateArgTupleParam? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CreateArgTupleParam left, CreateArgTupleParam right)
                {
                    return EqualityComparer<CreateArgTupleParam>.Default.Equals(left, right);
                }
                public static bool operator !=(CreateArgTupleParam left, CreateArgTupleParam right)
                {
                    return !(left == right);
                }

            }

            public class TupleOfArc4ArgArgs : AVMObjectType
            {
                public byte Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static TupleOfArc4ArgArgs Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TupleOfArc4ArgArgs();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TupleOfArc4ArgArgs);
                }
                public bool Equals(TupleOfArc4ArgArgs? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TupleOfArc4ArgArgs left, TupleOfArc4ArgArgs right)
                {
                    return EqualityComparer<TupleOfArc4ArgArgs>.Default.Equals(left, right);
                }
                public static bool operator !=(TupleOfArc4ArgArgs left, TupleOfArc4ArgArgs right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bool_param"> </param>
        /// <param name="uint64_param"> </param>
        /// <param name="bytes_param"> </param>
        /// <param name="biguint_param"> </param>
        /// <param name="string_param"> </param>
        /// <param name="tuple_param"> CreateArgTupleParam</param>
        public async Task<Structs.CreateArgTupleParam> Create(bool bool_param, ulong uint64_param, byte[] bytes_param, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 biguint_param, string string_param, Structs.CreateArgTupleParam tuple_param, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 113, 102, 82 };
            var bool_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); bool_paramAbi.From(bool_param);
            var uint64_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uint64_paramAbi.From(uint64_param);
            var bytes_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bytes_paramAbi.From(bytes_param);
            var string_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); string_paramAbi.From(string_param);

            var result = await base.CallApp(new List<object> { abiHandle, bool_paramAbi, uint64_paramAbi, bytes_paramAbi, biguint_param, string_paramAbi, tuple_param }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CreateArgTupleParam.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Create_Transactions(bool bool_param, ulong uint64_param, byte[] bytes_param, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 biguint_param, string string_param, Structs.CreateArgTupleParam tuple_param, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 113, 102, 82 };
            var bool_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); bool_paramAbi.From(bool_param);
            var uint64_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uint64_paramAbi.From(uint64_param);
            var bytes_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bytes_paramAbi.From(bytes_param);
            var string_paramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); string_paramAbi.From(string_param);

            return await base.MakeTransactionList(new List<object> { abiHandle, bool_paramAbi, uint64_paramAbi, bytes_paramAbi, biguint_param, string_paramAbi, tuple_param }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="args"> TupleOfArc4ArgArgs</param>
        public async Task<Structs.TupleOfArc4ArgArgs> TupleOfArc4(Structs.TupleOfArc4ArgArgs args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 166, 64, 120 };

            var result = await base.CallApp(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TupleOfArc4ArgArgs.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TupleOfArc4_Transactions(Structs.TupleOfArc4ArgArgs args, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 166, 64, 120 };

            return await base.MakeTransactionList(new List<object> { abiHandle, args }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNyZWF0ZUFyZ1R1cGxlUGFyYW0iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoic3RyaW5nIn1dLCJUdXBsZU9mQXJjNEFyZ0FyZ3MiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvb2xfcGFyYW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVpbnQ2NF9wYXJhbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXNfcGFyYW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWd1aW50X3BhcmFtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdHJpbmdfcGFyYW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iihib29sLHVpbnQ2NCxieXRlW10sdWludDUxMixzdHJpbmcpIiwic3RydWN0IjoiQ3JlYXRlQXJnVHVwbGVQYXJhbSIsIm5hbWUiOiJ0dXBsZV9wYXJhbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQsYnl0ZVtdLHVpbnQ1MTIsc3RyaW5nKSIsInN0cnVjdCI6IkNyZWF0ZUFyZ1R1cGxlUGFyYW0iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0dXBsZV9vZl9hcmM0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50OCxhZGRyZXNzKSIsInN0cnVjdCI6IlR1cGxlT2ZBcmM0QXJnQXJncyIsIm5hbWUiOiJhcmdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50OCxhZGRyZXNzKSIsInN0cnVjdCI6IlR1cGxlT2ZBcmM0QXJnQXJncyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTQsNTgsMTQyXSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0Niw3NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ05qUUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQXdlREF3Q2lBZ0lDQXZMeUJoZG0xZmRIbHdaWE5mYVc1ZllXSnBMMk52Ym5SeVlXTjBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRlJsYzNSRGIyNTBjbUZqZENoaGNtTTBMa0ZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaG1ZamN4TmpZMU1pQXdlRGRsWVRZME1EYzRJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLR0p2YjJ3c2RXbHVkRFkwTEdKNWRHVmJYU3gxYVc1ME5URXlMSE4wY21sdVp5d29ZbTl2YkN4MWFXNTBOalFzWW5sMFpWdGRMSFZwYm5RMU1USXNjM1J5YVc1bktTa29ZbTl2YkN4MWFXNTBOalFzWW5sMFpWdGRMSFZwYm5RMU1USXNjM1J5YVc1bktTSXNJRzFsZEdodlpDQWlkSFZ3YkdWZmIyWmZZWEpqTkNnb2RXbHVkRGdzWVdSa2NtVnpjeWtwS0hWcGJuUTRMR0ZrWkhKbGMzTXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTXlCdFlXbHVYM1IxY0d4bFgyOW1YMkZ5WXpSZmNtOTFkR1ZBTkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QmhkbTFmZEhsd1pYTmZhVzVmWVdKcEwyTnZiblJ5WVdOMExuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklGUmxjM1JEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1IxY0d4bFgyOW1YMkZ5WXpSZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUdGMmJWOTBlWEJsYzE5cGJsOWhZbWt2WTI5dWRISmhZM1F1Y0hrNk1Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJoZG0xZmRIbHdaWE5mYVc1ZllXSnBMMk52Ym5SeVlXTjBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRlJsYzNSRGIyNTBjbUZqZENoaGNtTTBMa0ZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeElETXlJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1lYWnRYM1I1Y0dWelgybHVYMkZpYVM5amIyNTBjbUZqZEM1d2VUb3hPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSFIxY0d4bFgyOW1YMkZ5WXpRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNem9LSUNBZ0lDOHZJR0YyYlY5MGVYQmxjMTlwYmw5aFlta3ZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1lYWnRYM1I1Y0dWelgybHVYMkZpYVM5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCVVpYTjBRMjl1ZEhKaFkzUW9ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQTVJQzh2SURrS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0EzTlNBdkx5QTNOUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdNVEVnTmpRZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnWVhadFgzUjVjR1Z6WDJsdVgyRmlhUzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTd2dZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSE5sZEdKcGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTBDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh5SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JpZkFvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURSa0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTnpjZ0x5OGdOemNLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGRtMWZkSGx3WlhOZmFXNWZZV0pwTG1OdmJuUnlZV04wTGxSbGMzUkRiMjUwY21GamRDNWpjbVZoZEdVb1ltOXZiRjl3WVhKaGJUb2dkV2x1ZERZMExDQjFhVzUwTmpSZmNHRnlZVzA2SUhWcGJuUTJOQ3dnWW5sMFpYTmZjR0Z5WVcwNklHSjVkR1Z6TENCaWFXZDFhVzUwWDNCaGNtRnRPaUJpZVhSbGN5d2djM1J5YVc1blgzQmhjbUZ0T2lCaWVYUmxjeXdnZEhWd2JHVmZjR0Z5WVcwdU1Eb2dkV2x1ZERZMExDQjBkWEJzWlY5d1lYSmhiUzR4T2lCMWFXNTBOalFzSUhSMWNHeGxYM0JoY21GdExqSTZJR0o1ZEdWekxDQjBkWEJzWlY5d1lYSmhiUzR6T2lCaWVYUmxjeXdnZEhWd2JHVmZjR0Z5WVcwdU5Eb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QmhkbTFmZEhsd1pYTmZhVzVmWVdKcEwyTnZiblJ5WVdOMExuQjVPalV0TVRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpTZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJR0p2YjJ4ZmNHRnlZVzA2SUdKdmIyd3NDaUFnSUNBdkx5QWdJQ0FnZFdsdWREWTBYM0JoY21GdE9pQlZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdZbmwwWlhOZmNHRnlZVzA2SUVKNWRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUdKcFozVnBiblJmY0dGeVlXMDZJRUpwWjFWSmJuUXNDaUFnSUNBdkx5QWdJQ0FnYzNSeWFXNW5YM0JoY21GdE9pQlRkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkSFZ3YkdWZmNHRnlZVzA2SUhSMWNHeGxXMkp2YjJ3c0lGVkpiblEyTkN3Z1FubDBaWE1zSUVKcFoxVkpiblFzSUZOMGNtbHVaMTBzQ2lBZ0lDQXZMeUFwSUMwK0lIUjFjR3hsVzJKdmIyd3NJRlZKYm5RMk5Dd2dRbmwwWlhNc0lFSnBaMVZKYm5Rc0lGTjBjbWx1WjEwNkNpQWdJQ0J3Y205MGJ5QXhNQ0ExQ2lBZ0lDQXZMeUJoZG0xZmRIbHdaWE5mYVc1ZllXSnBMMk52Ym5SeVlXTjBMbkI1T2pFMkNpQWdJQ0F2THlCaGMzTmxjblFnY21WemRXeDBJRDA5SUhSMWNHeGxYM0JoY21GdENpQWdJQ0JtY21GdFpWOWthV2NnTFRFd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJRDA5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVGtLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRnS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCbWNtRnRaVjlrYVdjZ0xUY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWowOUNpQWdJQ0FtSmdvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhkbTFmZEhsd1pYTmZhVzVmWVdKcEwyTnZiblJ5WVdOMExuQjVPakUzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjbVZ6ZFd4MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRrS0lDQWdJR1p5WVcxbFgyUnBaeUF0T0FvZ0lDQWdabkpoYldWZlpHbG5JQzAzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhadFgzUjVjR1Z6WDJsdVgyRmlhUzVqYjI1MGNtRmpkQzVVWlhOMFEyOXVkSEpoWTNRdWRIVndiR1ZmYjJaZllYSmpOQ2hoY21kekxqQTZJR0o1ZEdWekxDQmhjbWR6TGpFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q25SMWNHeGxYMjltWDJGeVl6UTZDaUFnSUNBdkx5QmhkbTFmZEhsd1pYTmZhVzVmWVdKcEwyTnZiblJ5WVdOMExuQjVPakU1TFRJeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCMGRYQnNaVjl2Wmw5aGNtTTBLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNJR0Z5WjNNNklIUjFjR3hsVzJGeVl6UXVWVWx1ZERnc0lHRnlZelF1UVdSa2NtVnpjMTBLSUNBZ0lDOHZJQ2tnTFQ0Z2RIVndiR1ZiWVhKak5DNVZTVzUwT0N3Z1lYSmpOQzVCWkdSeVpYTnpYVG9LSUNBZ0lIQnliM1J2SURJZ01nb2dJQ0FnTHk4Z1lYWnRYM1I1Y0dWelgybHVYMkZpYVM5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdZWE56WlhKMElHRnlaM05iTUYwdVlubDBaWE11YkdWdVozUm9JRDA5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WDNSNWNHVnpYMmx1WDJGaWFTOWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnWVhOelpYSjBJR0Z5WjNOYk1WMHVZbmwwWlhNdWJHVnVaM1JvSUQwOUlETXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WDNSNWNHVnpYMmx1WDJGaWFTOWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFGQUpnSUVGUjk4ZFFFQU1SdEJBQldDQWdUN2NXWlNCSDZtUUhnMkdnQ09BZ0FlQUFJaVF6RVpGRVF4R0VRMkdnRkpWd0FCVEZjQklJZ0EyVkFvVEZDd0kwTXhHUlJFTVJnVVJEWWFBU0pUTmhvQ0Z6WWFBMWNDQURZYUJEWWFCVmNDQURZYUJra2lVeWtpVHdKVUlsTkxBU05iU3dLQkNWbExBNEZMV1VzRVR3SkxBbEpYQWdCTEJGY0xRRXNGRlU4R1R3UlBBbEpYQWdDSUFFd3BJazhHVkU4RUZrc0VGUlpYQmdKUEJWQkxCQlVrRGtRa3IwOEZxMHNFRlJaWEJnSlBCVkJQQkU4RVVJQUNBRTFRU3dNVmdVMElURThEVUV3V1Z3WUNVRThDVUV4UUtFeFFzQ05EaWdvRmkvYUwreEtMOTR2OEVoQ0wrSXY5RWhDTCtZditxQkNMK292L0VoQkVpL2FMOTR2NGkvbUwrb21LQWdLTC9oVWpFa1NML3hXQklCSkVpLzZMLzRrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
