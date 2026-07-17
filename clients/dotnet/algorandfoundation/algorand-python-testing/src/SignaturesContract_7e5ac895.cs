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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.SignaturesContract_7e5ac895
{


    public class SignaturesContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SignaturesContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AnotherStruct : AVMObjectType
            {
                public ulong One { get; set; }

                public string Two { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOne.From(One);
                    ret.AddRange(vOne.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTwo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTwo.From(Two);
                    stringRef[ret.Count] = vTwo.Encode();
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

                public static AnotherStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AnotherStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOne.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOne = vOne.ToValue();
                    if (valueOne is ulong vOneValue) { ret.One = vOneValue; }
                    var indexTwo = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTwo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTwo.Decode(bytes.Skip(indexTwo + prefixOffset).ToArray());
                    var valueTwo = vTwo.ToValue();
                    if (valueTwo is string vTwoValue) { ret.Two = vTwoValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AnotherStruct);
                }
                public bool Equals(AnotherStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AnotherStruct left, AnotherStruct right)
                {
                    return EqualityComparer<AnotherStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(AnotherStruct left, AnotherStruct right)
                {
                    return !(left == right);
                }

            }

            public class MyStruct : AVMObjectType
            {
                public Structs.AnotherStruct AnotherStruct { get; set; } = new Structs.AnotherStruct();

                public Structs.AnotherStruct AnotherStructAlias { get; set; } = new Structs.AnotherStruct();

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt128 Three { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt128 Four { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = AnotherStruct.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = AnotherStructAlias.ToByteArray();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThree = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint128");
                    vThree.From(Three);
                    ret.AddRange(vThree.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFour = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint128");
                    vFour.From(Four);
                    ret.AddRange(vFour.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MyStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MyStruct();
                    uint count = 0;
                    var indexAnotherStruct = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.AnotherStruct = Structs.AnotherStruct.Parse(bytes.Skip(indexAnotherStruct + prefixOffset).ToArray());
                    var indexAnotherStructAlias = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.AnotherStructAlias = Structs.AnotherStruct.Parse(bytes.Skip(indexAnotherStructAlias + prefixOffset).ToArray());
                    var vThree = new AVM.ClientGenerator.ABI.ARC4.Types.UInt128();
                    count = vThree.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Three = vThree;
                    var vFour = new AVM.ClientGenerator.ABI.ARC4.Types.UInt128();
                    count = vFour.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Four = vFour;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MyStruct);
                }
                public bool Equals(MyStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MyStruct left, MyStruct right)
                {
                    return EqualityComparer<MyStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(MyStruct left, MyStruct right)
                {
                    return !(left == right);
                }

            }

            public class ComplexSigReturn : AVMObjectType
            {
                public Structs.AnotherStruct Field0 { get; set; } = new Structs.AnotherStruct();

                public Structs.MyStruct Field1 { get; set; } = new Structs.MyStruct();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Field0.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Field1.ToByteArray();
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

                public static ComplexSigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ComplexSigReturn();
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field0 = Structs.AnotherStruct.Parse(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.MyStruct.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ComplexSigReturn);
                }
                public bool Equals(ComplexSigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ComplexSigReturn left, ComplexSigReturn right)
                {
                    return EqualityComparer<ComplexSigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ComplexSigReturn left, ComplexSigReturn right)
                {
                    return !(left == right);
                }

            }

            public class EchoResourceByIndexReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EchoResourceByIndexReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EchoResourceByIndexReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EchoResourceByIndexReturn);
                }
                public bool Equals(EchoResourceByIndexReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EchoResourceByIndexReturn left, EchoResourceByIndexReturn right)
                {
                    return EqualityComparer<EchoResourceByIndexReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(EchoResourceByIndexReturn left, EchoResourceByIndexReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        /// <param name="arr"> </param>
        /// <param name="fixed_bytes"> </param>
        public async Task Sink(string value, byte[] arr, byte[] fixed_bytes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 1, 120, 30 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);
            var fixed_bytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); fixed_bytesAbi.From(fixed_bytes);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi, arrAbi, fixed_bytesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Sink_Transactions(string value, byte[] arr, byte[] fixed_bytes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 1, 120, 30 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);
            var fixed_bytesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); fixed_bytesAbi.From(fixed_bytes);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi, arrAbi, fixed_bytesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        /// <param name="arr"> </param>
        public async Task Alias(string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 5, 207, 23 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Alias_Transactions(string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 5, 207, 23 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        /// <param name="pay"> </param>
        /// <param name="arr"> </param>
        public async Task WithTxn(PaymentTransaction pay, string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 6, 88, 220, 195 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi, pay, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithTxn_Transactions(PaymentTransaction pay, string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 6, 88, 220, 195 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi, pay, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        /// <param name="asset"> </param>
        /// <param name="arr"> </param>
        public async Task WithAsset(ulong asset, string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 91, 100, 71, 222 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi, assetRefIndex, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithAsset_Transactions(ulong asset, string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 91, 100, 71, 222 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi, assetRefIndex, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        /// <param name="app"> </param>
        /// <param name="app_id"> </param>
        /// <param name="arr"> </param>
        public async Task WithApp(ulong app, string value, ulong app_id, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 6, 31, 78, 119 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi, appRefIndex, app_idAbi, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithApp_Transactions(ulong app, string value, ulong app_id, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            byte[] abiHandle = { 6, 31, 78, 119 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi, appRefIndex, app_idAbi, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        /// <param name="acc"> </param>
        /// <param name="arr"> </param>
        public async Task WithAcc(Address acc, string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 234, 168, 145, 57 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi, accRefIndex, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithAcc_Transactions(Address acc, string value, byte[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 234, 168, 145, 57 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi, accRefIndex, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="struct1"> MyStruct</param>
        /// <param name="txn"> </param>
        /// <param name="acc"> </param>
        /// <param name="five"> </param>
        public async Task<Structs.ComplexSigReturn> ComplexSig(Transaction txn, Address acc, Structs.MyStruct struct1, byte[] five, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 81, 14, 114, 164 };
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);
            var fiveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); fiveAbi.From(five);

            var result = await base.CallApp(new List<object> { abiHandle, struct1, txn, accRefIndex, fiveAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ComplexSigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ComplexSig_Transactions(Transaction txn, Address acc, Structs.MyStruct struct1, byte[] five, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txn });
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 81, 14, 114, 164 };
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);
            var fiveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); fiveAbi.From(five);

            return await base.MakeTransactionList(new List<object> { abiHandle, struct1, txn, accRefIndex, fiveAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="app"> </param>
        /// <param name="acc"> </param>
        public async Task<Structs.EchoResourceByIndexReturn> EchoResourceByIndex(ulong app, Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 214, 194, 172, 127 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            var result = await base.CallApp(new List<object> { abiHandle, assetRefIndex, appRefIndex, accRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoResourceByIndexReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoResourceByIndex_Transactions(ulong app, Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { app });
            byte appRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acc });
            byte accRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 214, 194, 172, 127 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetRefIndex, appRefIndex, accRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="app"> </param>
        /// <param name="acc"> </param>
        public async Task<Structs.EchoResourceByIndexReturn> EchoResourceByValue(ulong asset, ulong app, Algorand.Address acc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 20, 45, 94 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, appAbi, accAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EchoResourceByIndexReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> EchoResourceByValue_Transactions(ulong asset, ulong app, Algorand.Address acc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 20, 45, 94 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, appAbi, accAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2lnbmF0dXJlc0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFub3RoZXJTdHJ1Y3QiOlt7Im5hbWUiOiJvbmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidHdvIiwidHlwZSI6InN0cmluZyJ9XSwiTXlTdHJ1Y3QiOlt7Im5hbWUiOiJhbm90aGVyX3N0cnVjdCIsInR5cGUiOiJBbm90aGVyU3RydWN0In0seyJuYW1lIjoiYW5vdGhlcl9zdHJ1Y3RfYWxpYXMiLCJ0eXBlIjoiQW5vdGhlclN0cnVjdCJ9LHsibmFtZSI6InRocmVlIiwidHlwZSI6InVpbnQxMjgifSx7Im5hbWUiOiJmb3VyIiwidHlwZSI6InVpbnQxMjgifV0sIkNvbXBsZXhTaWdSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiQW5vdGhlclN0cnVjdCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJNeVN0cnVjdCJ9XSwiRWNob1Jlc291cmNlQnlJbmRleFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImFkZHJlc3MifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNpbmsiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXhlZF9ieXRlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbGlhcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDhbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhfYXNzZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aF9hcHAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aF9hY2MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29tcGxleF9zaWciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKCh1aW50NjQsc3RyaW5nKSwodWludDY0LHN0cmluZyksdWludDEyOCx1aW50MTI4KSIsInN0cnVjdCI6Ik15U3RydWN0IiwibmFtZSI6InN0cnVjdDEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InR4biIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDhbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpdmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKCh1aW50NjQsc3RyaW5nKSwoKHVpbnQ2NCxzdHJpbmcpLCh1aW50NjQsc3RyaW5nKSx1aW50MTI4LHVpbnQxMjgpKSIsInN0cnVjdCI6IkNvbXBsZXhTaWdSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlY2hvX3Jlc291cmNlX2J5X2luZGV4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGxpY2F0aW9uIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LGFkZHJlc3MpIiwic3RydWN0IjoiRWNob1Jlc291cmNlQnlJbmRleFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fcmVzb3VyY2VfYnlfdmFsdWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkVjaG9SZXNvdXJjZUJ5SW5kZXhSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM0OCwzNTMsNTQ3LDU1Ml0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg0XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQyXSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM5XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYWNjb3VudCB0byBiZSBwYXNzZWQgYnkgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTNdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhY2NvdW50IHRvIGJlIHBhc3NlZCBieSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFwcCBpZCB0byBtYXRjaCBwcm92aWRlZCBhcHAgaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhcHBsaWNhdGlvbiB0byBiZSBwYXNzZWQgYnkgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODddLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhcHBsaWNhdGlvbiB0byBiZSBwYXNzZWQgYnkgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCB0byBiZSBwYXNzZWQgYnkgaW5kZXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBhc3NldCB0byBiZSBwYXNzZWQgYnkgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzhdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBnbG9iYWwgdG8gaGF2ZSBhcHAgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMl0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGdsb2JhbCB0byBoYXZlIGFwcCBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIG90aGVyIGFwcCB0byBoYXZlIHNhbWUgY3JlYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MywxNDddLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCB0eG4gdG8gaGF2ZSAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI5LDI5NF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdOaUF4TWpNS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnd01EQXdJREI0TVRVeFpqZGpOelVnTUhnd01EQXdNREF3TURBd01EQXdNREF4SURCNE1EQXdNVE15Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdZMnhoYzNNZ1UybG5ibUYwZFhKbGMwTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXpDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNbVV3TVRjNE1XVWdNSGd6WWpBMVkyWXhOeUF3ZURBMk5UaGtZMk16SURCNE5XSTJORFEzWkdVZ01IZ3dOakZtTkdVM055QXdlR1ZoWVRnNU1UTTVJREI0TlRFd1pUY3lZVFFnTUhoa05tTXlZV00zWmlBd2VEUTRNVFF5WkRWbElDOHZJRzFsZEdodlpDQWljMmx1YXloemRISnBibWNzZFdsdWREaGJYU3hpZVhSbFd6UmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnNhV0Z6S0hOMGNtbHVaeXgxYVc1ME9GdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luZHBkR2hmZEhodUtITjBjbWx1Wnl4d1lYa3NkV2x1ZERoYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKM2FYUm9YMkZ6YzJWMEtITjBjbWx1Wnl4aGMzTmxkQ3gxYVc1ME9GdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luZHBkR2hmWVhCd0tITjBjbWx1Wnl4aGNIQnNhV05oZEdsdmJpeDFhVzUwTmpRc2RXbHVkRGhiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0ozYVhSb1gyRmpZeWh6ZEhKcGJtY3NZV05qYjNWdWRDeDFhVzUwT0Z0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1OdmJYQnNaWGhmYzJsbktDZ29kV2x1ZERZMExITjBjbWx1Wnlrc0tIVnBiblEyTkN4emRISnBibWNwTEhWcGJuUXhNamdzZFdsdWRERXlPQ2tzZEhodUxHRmpZMjkxYm5Rc2RXbHVkRGhiWFNrb0tIVnBiblEyTkN4emRISnBibWNwTENnb2RXbHVkRFkwTEhOMGNtbHVaeWtzS0hWcGJuUTJOQ3h6ZEhKcGJtY3BMSFZwYm5ReE1qZ3NkV2x1ZERFeU9Da3BJaXdnYldWMGFHOWtJQ0psWTJodlgzSmxjMjkxY21ObFgySjVYMmx1WkdWNEtHRnpjMlYwTEdGd2NHeHBZMkYwYVc5dUxHRmpZMjkxYm5RcEtIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeWtpTENCdFpYUm9iMlFnSW1WamFHOWZjbVZ6YjNWeVkyVmZZbmxmZG1Gc2RXVW9kV2x1ZERZMExIVnBiblEyTkN4aFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJsdWF5QnphVzVyTWlCM2FYUm9YM1I0YmlCM2FYUm9YMkZ6YzJWMElIZHBkR2hmWVhCd0lIZHBkR2hmWVdOaklHTnZiWEJzWlhoZmMybG5JR1ZqYUc5ZmNtVnpiM1Z5WTJWZllubGZhVzVrWlhnZ1pXTm9iMTl5WlhOdmRYSmpaVjlpZVY5MllXeDFaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6T2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZNalVLSUNBZ0lDOHZJR05zWVhOeklGTnBaMjVoZEhWeVpYTkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdNMVl6WXhZbUVnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVCY21NMFFVSkpUV1YwYUc5a0xtTnZiblJ5WVdOMExsTnBaMjVoZEhWeVpYTkRiMjUwY21GamRDNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnWVhCd1gzUjRiaUE5SUdkMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c1ZISmhibk5oWTNScGIyNG9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklHRndjR3dLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhjSEJzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdZWE56WlhKMElHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMmxrSUNFOUlEQXNJQ0psZUhCbFkzUmxaQ0JuYkc5aVlXd2dkRzhnYUdGMlpTQmhjSEFnYVdRaUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQm5iRzlpWVd3Z2RHOGdhR0YyWlNCaGNIQWdhV1FLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QnZjQzVIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpJQ0U5SUc5d0xrZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUb3pNQzB6TWdvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCdmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOeklDRTlJRzl3TGtkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNS0lDQWdJQzh2SUNrc0lDSmxlSEJsWTNSbFpDQm5iRzlpWVd3Z2RHOGdhR0YyWlNCaGNIQWdZV1JrY21WemN5SUtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCbmJHOWlZV3dnZEc4Z2FHRjJaU0JoY0hBZ1lXUmtjbVZ6Y3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJR0Z3Y0Y5MGVHNGdQU0JuZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkZSeVlXNXpZV04wYVc5dUtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0JoY0hCZmRIaHVMbUZ3Y0Y5cFpDQTlQU0F3TENBaVpYaHdaV04wWldRZ2RIaHVJSFJ2SUdoaGRtVWdNQ0lLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0IwZUc0Z2RHOGdhR0YyWlNBd0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1aGNIQnNhV05oZEdsdmJsOXBaQ0E5UFNBd0xDQWlaWGh3WldOMFpXUWdkSGh1SUhSdklHaGhkbVVnTUNJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnZEhodUlIUnZJR2hoZG1VZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TWpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1QmNtTTBRVUpKVFdWMGFHOWtMbU52Ym5SeVlXTjBMbE5wWjI1aGRIVnlaWE5EYjI1MGNtRmpkQzV6YVc1clczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMmx1YXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9kbUZzYVdSaGRHVmZaVzVqYjJScGJtYzlJblZ1YzJGbVpWOWthWE5oWW14bFpDSXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSmpORUZDU1UxbGRHaHZaQzlqYjI1MGNtRmpkQzV3ZVRvME1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGJIVmxDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd0NpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG96TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSFpoYkdsa1lYUmxYMlZ1WTI5a2FXNW5QU0oxYm5OaFptVmZaR2x6WVdKc1pXUWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1QmNtTTBRVUpKVFdWMGFHOWtMbU52Ym5SeVlXTjBMbE5wWjI1aGRIVnlaWE5EYjI1MGNtRmpkQzV6YVc1ck1sdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5wYm1zeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h1WVcxbFBTSmhiR2xoY3lJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnWVhOelpYSjBJSFpoYkhWbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnlZelJCUWtsTlpYUm9iMlF2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGNuSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHNWhiV1U5SW1Gc2FXRnpJaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVFYSmpORUZDU1UxbGRHaHZaQzVqYjI1MGNtRmpkQzVUYVdkdVlYUjFjbVZ6UTI5dWRISmhZM1F1ZDJsMGFGOTBlRzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwM2FYUm9YM1I0YmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJZV3gxWlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd0NpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVM1bmNtOTFjRjlwYm1SbGVDQTlQU0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVkeWIzVndTVzVrWlhnS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1WjNKdmRYQmZhVzVrWlhnZ1BUMGdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSmpORUZDU1UxbGRHaHZaQzlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVTNWhiVzkxYm5RZ1BUMGdNVEl6Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHbHVkR05mTXlBdkx5QXhNak1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVRWEpqTkVGQ1NVMWxkR2h2WkM1amIyNTBjbUZqZEM1VGFXZHVZWFIxY21WelEyOXVkSEpoWTNRdWQybDBhRjloYzNObGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbmRwZEdoZllYTnpaWFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxjMjkxY21ObFgyVnVZMjlrYVc1blBTSnBibVJsZUNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJjM05sZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01Bb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUdGemMyVnlkQ0JoYzNObGRDNTBiM1JoYkNBOVBTQXhNak1LSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWFJmY0dGeVlXMXpYMmRsZENCQmMzTmxkRlJ2ZEdGc0NpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6TWdMeThnTVRJekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1aGMzTmxkSE1vTUNrZ1BUMGdZWE56WlhRS0lDQWdJSFI0Ym1FZ1FYTnpaWFJ6SURBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZ6YjNWeVkyVmZaVzVqYjJScGJtYzlJbWx1WkdWNElpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11UVhKak5FRkNTVTFsZEdodlpDNWpiMjUwY21GamRDNVRhV2R1WVhSMWNtVnpRMjl1ZEhKaFkzUXVkMmwwYUY5aGNIQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1gyRndjRG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRndjR3hwWTJGMGFXOXVjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnlZelJCUWtsTlpYUm9iMlF2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCMllXeDFaUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnlZelJCUWtsTlpYUm9iMlF2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGNuSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdZWE56WlhKMElHRndjQzVwWkNBOVBTQmhjSEJmYVdRc0lDSmxlSEJsWTNSbFpDQmhjSEFnYVdRZ2RHOGdiV0YwWTJnZ2NISnZkbWxrWldRZ1lYQndJR2xrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0Z3Y0NCcFpDQjBieUJ0WVhSamFDQndjbTkyYVdSbFpDQmhjSEFnYVdRS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEJ3TG1OeVpXRjBiM0lnUFQwZ2IzQXVSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0ltVjRjR1ZqZEdWa0lHOTBhR1Z5SUdGd2NDQjBieUJvWVhabElITmhiV1VnWTNKbFlYUnZjaUlLSUNBZ0lHUjFjQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1EzSmxZWFJ2Y2dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUc5MGFHVnlJR0Z3Y0NCMGJ5Qm9ZWFpsSUhOaGJXVWdZM0psWVhSdmNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TnpJS0lDQWdJQzh2SUdGd2NGOTBlRzRnUFNCbmRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JGUnlZVzV6WVdOMGFXOXVLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTWlBdkx5QmhjSEJzQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWEJ3YkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5QmhjM05sY25RZ1lYQndYM1I0Ymk1aGNIQnpLREFwSUQwOUlHOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMmxrQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6WVhNZ1FYQndiR2xqWVhScGIyNXpDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG1Gd2NHeHBZMkYwYVc5dWN5Z3dLU0E5UFNCdmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOXBaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2Ym5NZ01Bb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzNNZ29nSUNBZ0x5OGdZWEJ3WDNSNGJpQTlJR2QwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzVkhKaGJuTmhZM1JwYjI0b01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnWVhOelpYSjBJR0Z3Y0Y5MGVHNHVZWEJ3Y3lneEtTQTlQU0JoY0hBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQm5kSGh1YzJGeklFRndjR3hwWTJGMGFXOXVjd29nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbUZ3Y0d4cFkyRjBhVzl1Y3lneEtTQTlQU0JoY0hBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNXpJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVRWEpqTkVGQ1NVMWxkR2h2WkM1amIyNTBjbUZqZEM1VGFXZHVZWFIxY21WelEyOXVkSEpoWTNRdWQybDBhRjloWTJOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWDJGall6b0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNtTTBRVUpKVFdWMGFHOWtMMk52Ym5SeVlXTjBMbkI1T2pjNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WemIzVnlZMlZmWlc1amIyUnBibWM5SW1sdVpHVjRJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdZWE56WlhKMElIWmhiSFZsQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdZWE56WlhKMElHRnljZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV05qTG1KaGJHRnVZMlVnUFQwZ1lXTmpMbTFwYmw5aVlXeGhibU5sSUNzZ01USXpOQW9nSUNBZ1pIVndDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnWkdsbklERUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNCd2RYTm9hVzUwSURFeU16UUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG1GalkyOTFiblJ6S0RBcElEMDlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRibUVnUVdOamIzVnVkSE1nTUFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnlZelJCUWtsTlpYUm9iMlF2WTI5dWRISmhZM1F1Y0hrNk9EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVZV05qYjNWdWRITW9NU2tnUFQwZ1lXTmpDaUFnSUNCMGVHNWhJRUZqWTI5MWJuUnpJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVRWEpqTkVGQ1NVMWxkR2h2WkM1amIyNTBjbUZqZEM1VGFXZHVZWFIxY21WelEyOXVkSEpoWTNRdVkyOXRjR3hsZUY5emFXZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjIxd2JHVjRYM05wWnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamcyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZ6YjNWeVkyVmZaVzVqYjJScGJtYzlJbWx1WkdWNElpa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJtYVhabExuWmhiR2xrWVhSbEtDa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV1ZFcxZllYQndYMkZ5WjNNZ1BUMGdOQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2T1RJdE9UTUtJQ0FnSUM4dklDTWdjM1J5ZFdOMENpQWdJQ0F2THlCaGMzTmxjblFnYzNSeWRXTjBNUzVoYm05MGFHVnlYM04wY25WamRDNXZibVVnUFQwZ01Rb2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamt5TFRrMENpQWdJQ0F2THlBaklITjBjblZqZEFvZ0lDQWdMeThnWVhOelpYSjBJSE4wY25WamRERXVZVzV2ZEdobGNsOXpkSEoxWTNRdWIyNWxJRDA5SURFS0lDQWdJQzh2SUdGemMyVnlkQ0J6ZEhKMVkzUXhMbUZ1YjNSb1pYSmZjM1J5ZFdOMExuUjNieUE5UFNBaU1pSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNtTTBRVUpKVFdWMGFHOWtMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCaGMzTmxjblFnYzNSeWRXTjBNUzVoYm05MGFHVnlYM04wY25WamRDNTBkMjhnUFQwZ0lqSWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TVRNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnWVhOelpYSjBJSE4wY25WamRERXVZVzV2ZEdobGNsOXpkSEoxWTNSZllXeHBZWE11YjI1bElEMDlJREVLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUEzQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG81TlMwNU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhOMGNuVmpkREV1WVc1dmRHaGxjbDl6ZEhKMVkzUmZZV3hwWVhNdWIyNWxJRDA5SURFS0lDQWdJQzh2SUdGemMyVnlkQ0J6ZEhKMVkzUXhMbUZ1YjNSb1pYSmZjM1J5ZFdOMFgyRnNhV0Z6TG5SM2J5QTlQU0FpTWlJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUdGemMyVnlkQ0J6ZEhKMVkzUXhMbUZ1YjNSb1pYSmZjM1J5ZFdOMExuUjNieUE5UFNBaU1pSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF4TXpJS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPamsyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjM1J5ZFdOME1TNWhibTkwYUdWeVgzTjBjblZqZEY5aGJHbGhjeTUwZDI4Z1BUMGdJaklpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdZWE56WlhKMElITjBjblZqZERFdWRHaHlaV1VnUFQwZ013b2dJQ0FnWkdsbklEVUtJQ0FnSUdWNGRISmhZM1FnTkNBeE5nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRE1LSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdZWE56WlhKMElITjBjblZqZERFdVptOTFjaUE5UFNBMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F5TUNBeE5nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRFFLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUb3hNREF0TVRBeENpQWdJQ0F2THlBaklIUjRiZ29nSUNBZ0x5OGdZWE56WlhKMElIUjRiaTVuY205MWNGOXBibVJsZUNBOVBTQlVlRzR1WjNKdmRYQmZhVzVrWlhnZ0xTQXhDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2QwZUc1eklFZHliM1Z3U1c1a1pYZ0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZNVEF6TFRFd05Bb2dJQ0FnTHk4Z0l5QmhZMk1LSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWd5S1NBOVBTQmhjbU0wTGxWSmJuUTRLREVwTG1KNWRHVnpJQ0FqSUdGall5QmhjbkpoZVNCeVpXWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSmpORUZDU1UxbGRHaHZaQzlqYjI1MGNtRmpkQzV3ZVRveE1EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaFkyTXVZbUZzWVc1alpTQTlQU0JoWTJNdWJXbHVYMkpoYkdGdVkyVWdLeUF4TWpNMENpQWdJQ0JrYVdjZ013b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSQ1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lIQjFjMmhwYm5RZ01USXpOQW9nSUNBZ0t3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TVRBMkNpQWdJQ0F2THlCaGMzTmxjblFnWm1sMlpWc3dYU0E5UFNBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dOUW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWlrS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVRWEpqTkVGQ1NVMWxkR2h2WkM1amIyNTBjbUZqZEM1VGFXZHVZWFIxY21WelEyOXVkSEpoWTNRdVpXTm9iMTl5WlhOdmRYSmpaVjlpZVY5cGJtUmxlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WamFHOWZjbVZ6YjNWeVkyVmZZbmxmYVc1a1pYZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSmpORUZDU1UxbGRHaHZaQzlqYjI1MGNtRmpkQzV3ZVRveE1UQXRNVEV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9DaUFnSUNBdkx5QWdJQ0FnY21WemIzVnlZMlZmWlc1amIyUnBibWM5SW1sdVpHVjRJaXdLSUNBZ0lDOHZJQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGemMyVjBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVhCd2JHbGpZWFJwYjI1ekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJZMk52ZFc1MGN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkNpQWdJQ0F2THlCaGMzTmxkRjlwWkhnZ1BTQnZjQzVpZEc5cEtGUjRiaTVoY0hCc2FXTmhkR2x2Ymw5aGNtZHpLREVwS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWE56WlhRZ1BUMGdWSGh1TG1GemMyVjBjeWhoYzNObGRGOXBaSGdwTENBaVpYaHdaV04wWldRZ1lYTnpaWFFnZEc4Z1ltVWdjR0Z6YzJWa0lHSjVJR2x1WkdWNElnb2dJQ0FnZEhodVlYTWdRWE56WlhSekNpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoYzNObGRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2FXNWtaWGdLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdZWEJ3WDJsa2VDQTlJRzl3TG1KMGIya29WSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTWlrcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUdGemMyVnlkQ0JoY0hBZ1BUMGdWSGh1TG1Gd2NHeHBZMkYwYVc5dWN5aGhjSEJmYVdSNEtTd2dJbVY0Y0dWamRHVmtJR0Z3Y0d4cFkyRjBhVzl1SUhSdklHSmxJSEJoYzNObFpDQmllU0JwYm1SbGVDSUtJQ0FnSUhSNGJtRnpJRUZ3Y0d4cFkyRjBhVzl1Y3dvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZWEJ3YkdsallYUnBiMjRnZEc4Z1ltVWdjR0Z6YzJWa0lHSjVJR2x1WkdWNENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKak5FRkNTVTFsZEdodlpDOWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUdGalkxOXBaSGdnUFNCdmNDNWlkRzlwS0ZSNGJpNWhjSEJzYVdOaGRHbHZibDloY21kektETXBLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnlZelJCUWtsTlpYUm9iMlF2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QmhjM05sY25RZ1lXTmpJRDA5SUZSNGJpNWhZMk52ZFc1MGN5aGhZMk5mYVdSNEtTd2dJbVY0Y0dWamRHVmtJR0ZqWTI5MWJuUWdkRzhnWW1VZ2NHRnpjMlZrSUdKNUlHbHVaR1Y0SWdvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0ZqWTI5MWJuUWdkRzhnWW1VZ2NHRnpjMlZrSUdKNUlHbHVaR1Y0Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEpqTkVGQ1NVMWxkR2h2WkM5amIyNTBjbUZqZEM1d2VUb3hNVEF0TVRFeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpiM1Z5WTJWZlpXNWpiMlJwYm1jOUltbHVaR1Y0SWl3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1QmNtTTBRVUpKVFdWMGFHOWtMbU52Ym5SeVlXTjBMbE5wWjI1aGRIVnlaWE5EYjI1MGNtRmpkQzVsWTJodlgzSmxjMjkxY21ObFgySjVYM1poYkhWbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taV05vYjE5eVpYTnZkWEpqWlY5aWVWOTJZV3gxWlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPakV5TkMweE1qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNnS0lDQWdJQzh2SUNBZ0lDQnlaWE52ZFhKalpWOWxibU52WkdsdVp6MGlkbUZzZFdVaUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeVl6UkJRa2xOWlhSb2IyUXZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCaFkyTXVkbUZzYVdSaGRHVW9LUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNtTTBRVUpKVFdWMGFHOWtMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQnZjQzVpZEc5cEtGUjRiaTVoY0hCc2FXTmhkR2x2Ymw5aGNtZHpLREVwS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5WXpSQlFrbE5aWFJvYjJRdlkyOXVkSEpoWTNRdWNIazZNVE15Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWE56WlhRdWFXUWdQVDBnWVhOelpYUmZhV1FzSUNKbGVIQmxZM1JsWkNCaGMzTmxkQ0IwYnlCaVpTQndZWE56WldRZ1lua2dkbUZzZFdVaUNpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoYzNObGRDQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2RtRnNkV1VLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdZWEJ3WDJsa0lEMGdiM0F1WW5SdmFTaFVlRzR1WVhCd2JHbGpZWFJwYjI1ZllYSm5jeWd5S1NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPakV6TkFvZ0lDQWdMeThnWVhOelpYSjBJR0Z3Y0M1cFpDQTlQU0JoY0hCZmFXUXNJQ0psZUhCbFkzUmxaQ0JoY0hCc2FXTmhkR2x2YmlCMGJ5QmlaU0J3WVhOelpXUWdZbmtnZG1Gc2RXVWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCaGNIQnNhV05oZEdsdmJpQjBieUJpWlNCd1lYTnpaV1FnWW5rZ2RtRnNkV1VLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbU0wUVVKSlRXVjBhRzlrTDJOdmJuUnlZV04wTG5CNU9qRXpOZ29nSUNBZ0x5OGdZWE56WlhKMElHRmpZeTVpZVhSbGN5QTlQU0JoWkdSeVpYTnpMQ0FpWlhod1pXTjBaV1FnWVdOamIzVnVkQ0IwYnlCaVpTQndZWE56WldRZ1lua2dkbUZzZFdVaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY21NMFFVSkpUV1YwYUc5a0wyTnZiblJ5WVdOMExuQjVPakV6TlFvZ0lDQWdMeThnWVdSa2NtVnpjeUE5SUZSNGJpNWhjSEJzYVdOaGRHbHZibDloY21kektETXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSmpORUZDU1UxbGRHaHZaQzlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklHRnpjMlZ5ZENCaFkyTXVZbmwwWlhNZ1BUMGdZV1JrY21WemN5d2dJbVY0Y0dWamRHVmtJR0ZqWTI5MWJuUWdkRzhnWW1VZ2NHRnpjMlZrSUdKNUlIWmhiSFZsSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmhZMk52ZFc1MElIUnZJR0psSUhCaGMzTmxaQ0JpZVNCMllXeDFaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnlZelJCUWtsTlpYUm9iMlF2WTI5dWRISmhZM1F1Y0hrNk1USTBMVEV5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOTFjbU5sWDJWdVkyOWthVzVuUFNKMllXeDFaU0lzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBR2V5WUVBZ0FBQkJVZmZIVUlBQUFBQUFBQUFBRURBQUV5TVJrVVJERVlRUUJIZ2drRUxnRjRIZ1E3QmM4WEJBWlkzTU1FVzJSSDNnUUdIMDUzQk9xb2tUa0VVUTV5cEFUV3dxeC9CRWdVTFY0MkdnQ09DUUFwQURjQVJRQnVBSkFBMkFFSkFlTUNJZ0NBQkV4Y1libzJHZ0NPQVFBQkFDTTRFQ1FTUkRJSVJESUtNZ01UUkNNNEdCUkVNUmdVUkNKRE5ob0NOaG9CS0JORUtCTkVJa00yR2dJMkdnRW9FMFFvRTBRaVF6WWFBVEVXSWdsSk9CQWlFa1EyR2dKUEFpZ1RSQ2dUUkVrNEZoUkVNUllpRWtRNENDVVNSQ0pETmhvQk5ob0NGOEF3TmhvRFR3SW9FMFFvRTBSSmNRQkVKUkpFTmpBQUVrUWlRellhQVRZYUFoZkFNallhQXpZYUJFOERLQk5FS0JORVN3RVdxRVJKY2dkRU1na1NSQ000RUNRU1JDTkp3akl5Q0JKRU5qSUFNZ2dTUkNNaXdqSkxBUkpFTmpJQkVrUWlRellhQVRZYUFoZkFIRFlhQTA4Q0tCTkVLQk5FU1hNQVJFc0Jjd0ZFZ2RJSkNCSkVOaHdBTVFBU1JEWWNBUkpFSWtNMkdnRXhGaUlKTmhvQ0Y4QWNOaG9EU1NOWmdRSUlTd0VWRWtReEc0RUVFa1JMQXlOWlN3U0JBbGxMQlU4Q1N3SlNTVmNBQ0Nxb1JFbUJDRmxMQVJWTEFrOENTd0pTS3hKRVN3WVZTd2RQQkU4Q1VrbFhBQWdxcUVSSmdRaFpTd0VWVWlzU1JFc0ZWd1FRZ0JBQUFBQUFBQUFBQUFBQUFBQUFBQUFEcUVSTEJWY1VFSUFRQUFBQUFBQUFBQUFBQUFBQUFBQUFCS2hFVHdRNEZqRVdJZ2tTUkRZYUFvQUJBUkpFU3dOekFFUlBCSE1CUklIU0NRZ1NSRThDVndJQmdBRUZxRVNCQkFnV1Z3WUNnQUlBQkV4UVRGQk1VQ2xNVUxBaVF6WWFBUmZBTURZYUFoZkFNallhQXhmQUhEWWFBUmZBTUVzREVrUTJHZ0lYd0RKTEFoSkVOaG9ERjhBY1N3RVNSRThDRms4Q0ZsQk1VQ2xNVUxBaVF6WWFBUmMyR2dJWE5ob0RTUldCSUJKRU5ob0JGMHNERWtRMkdnSVhTd0lTUkVrMkdnTVNSRThDRms4Q0ZsQk1VQ2xNVUxBaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
