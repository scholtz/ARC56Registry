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

namespace Arc56.Generated.aorumbayev.puya.BoxContract_5cb9caa8
{


    public class BoxContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BoxContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReadBoxesReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public string Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
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

                public static ReadBoxesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ReadBoxesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReadBoxesReturn);
                }
                public bool Equals(ReadBoxesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadBoxesReturn left, ReadBoxesReturn right)
                {
                    return EqualityComparer<ReadBoxesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadBoxesReturn left, ReadBoxesReturn right)
                {
                    return !(left == right);
                }

            }

            public class BoxesExistReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static BoxesExistReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BoxesExistReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BoxesExistReturn);
                }
                public bool Equals(BoxesExistReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BoxesExistReturn left, BoxesExistReturn right)
                {
                    return EqualityComparer<BoxesExistReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(BoxesExistReturn left, BoxesExistReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task SetBoxes(ulong a, byte[] b, string c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 55, 41, 110 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBoxes_Transactions(ulong a, byte[] b, string c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 55, 41, 110 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CheckKeys(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 50, 93, 61 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckKeys_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 50, 93, 61 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 102, 198, 50 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 102, 198, 50 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ReadBoxesReturn> ReadBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 218, 155, 160 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReadBoxesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 218, 155, 160 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.BoxesExistReturn> BoxesExist(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 163, 237, 82 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BoxesExistReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BoxesExist_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 163, 237, 82 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task SliceBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 239, 73, 113 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SliceBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 239, 73, 113 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc4Box(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 236, 179, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc4Box_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 236, 179, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestBoxRef(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 247, 88, 22 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBoxRef_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 247, 88, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task BoxMapTest(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 50, 145, 58 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BoxMapTest_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 50, 145, 58 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task BoxMapSet(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 159, 22, 105 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BoxMapSet_Transactions(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 159, 22, 105 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<string> BoxMapGet(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 136, 140, 9 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> BoxMapGet_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 136, 140, 9 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task BoxMapDel(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 246, 133, 6 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BoxMapDel_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 246, 133, 6 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<bool> BoxMapExists(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 226, 195, 100 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxMapExists_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 226, 195, 100 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm94Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUmVhZEJveGVzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoic3RyaW5nIn1dLCJCb3hlc0V4aXN0UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNldF9ib3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrX2tleXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlX2JveGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWRfYm94ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10sc3RyaW5nKSIsInN0cnVjdCI6IlJlYWRCb3hlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJveGVzX2V4aXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iihib29sLGJvb2wsYm9vbCkiLCJzdHJ1Y3QiOiJCb3hlc0V4aXN0UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2xpY2VfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzRfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYm94X3JlZiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hfbWFwX3Rlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm94X21hcF9zZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hfbWFwX2dldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib3hfbWFwX2RlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm94X21hcF9leGlzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTIwNF0sImVycm9yTWVzc2FnZSI6IkJsb2IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1NSwxMDY2LDEwNzgsMTA5MF0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwLDIwNywyMjMsMjUyLDI3NCwyODYsMjk4LDMxMCwzMjIsMzcyLDQyMyw0MzUsNDQ0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgzLDIxMCwyMjYsMjU1LDI3NywyODksMzAxLDMxMywzMjUsMzc1LDQyNiw0MzgsNDQ3XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4OCwxMDU0LDEwNjUsMTA3NywxMDg5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQm94IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBCb3hNYXAgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIwNywxMjE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQm94UmVmIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzMSw1NDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJveF9hIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNCw1MTgsNTQ5LDg5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94X2IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU3LDkwMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94X2MgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ib3hfZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjUzLDEyNjAsMTMyNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94X21hcCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjVdLCJlcnJvck1lc3NhZ2UiOiJkaXJlY3QgcmVmZXJlbmNlIHNob3VsZCBtYXRjaCBjb3B5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzMiwxMjMwXSwiZXJyb3JNZXNzYWdlIjoiaGFzIGRhdGEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTA0LDExMTAsMTExNiwxMTIyXSwiZXJyb3JNZXNzYWdlIjoibm8gZGF0YSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCbGVHRnRjR3hsY3k1aWIzaGZjM1J2Y21GblpTNWpiMjUwY21GamRDNUNiM2hEYjI1MGNtRmpkQzVmWDJGc1oyOXdlVjlsYm5SeWVYQnZhVzUwWDNkcGRHaGZhVzVwZENncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ01pQTFDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjROREkwWmpVNE5XWTBNeUF3ZURZeU5tTTJaall5SUNKaWIzaGZaQ0lnSW1KdmVGOWhJaUFpWWlJZ01IZ3dNQ0F3ZURZMElEQjRNVFV4Wmpkak56VWdJakFpSURCNE5qZzJOVFpqTm1NMlppQXdlREF3TURJek5ETXlJQ0ppYjNoZmNtVm1JaUFpWkdWbVlYVnNkQ0lLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qZ0tJQ0FnSUM4dklHTnNZWE56SUVKdmVFTnZiblJ5WVdOMEtHRnlZelF1UVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhPQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGRrTXpjeU9UWmxJREI0TXpNek1qVmtNMlFnTUhoa05UWTJZell6TWlBd2VHWmlaR0U1WW1Fd0lEQjRaVFZoTTJWa05USWdNSGd3TkdWbU5EazNNU0F3ZURJelpXTmlNekpqSURCNFpXVm1OelU0TVRZZ01IaGlOVE15T1RFellTQXdlR015T1dZeE5qWTVJREI0T1dNNE9EaGpNRGtnTUhobE5tWTJPRFV3TmlBd2VEaGxaVEpqTXpZMElDOHZJRzFsZEdodlpDQWljMlYwWDJKdmVHVnpLSFZwYm5RMk5DeGllWFJsVzEwc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5vWldOclgydGxlWE1vS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsYkdWMFpWOWliM2hsY3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WaFpGOWliM2hsY3lncEtIVnBiblEyTkN4aWVYUmxXMTBzYzNSeWFXNW5LU0lzSUcxbGRHaHZaQ0FpWW05NFpYTmZaWGhwYzNRb0tTaGliMjlzTEdKdmIyd3NZbTl2YkNraUxDQnRaWFJvYjJRZ0luTnNhV05sWDJKdmVDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVlYSmpORjlpYjNnb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5SbGMzUmZZbTk0WDNKbFppZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVltOTRYMjFoY0Y5MFpYTjBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmliM2hmYldGd1gzTmxkQ2gxYVc1ME5qUXNjM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1KdmVGOXRZWEJmWjJWMEtIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW1KdmVGOXRZWEJmWkdWc0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0ppYjNoZmJXRndYMlY0YVhOMGN5aDFhVzUwTmpRcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZjMlYwWDJKdmVHVnpYM0p2ZFhSbFFEVWdiV0ZwYmw5amFHVmphMTlyWlhselgzSnZkWFJsUURZZ2JXRnBibDlrWld4bGRHVmZZbTk0WlhOZmNtOTFkR1ZBTnlCdFlXbHVYM0psWVdSZlltOTRaWE5mY205MWRHVkFPQ0J0WVdsdVgySnZlR1Z6WDJWNGFYTjBYM0p2ZFhSbFFEa2diV0ZwYmw5emJHbGpaVjlpYjNoZmNtOTFkR1ZBTVRBZ2JXRnBibDloY21NMFgySnZlRjl5YjNWMFpVQXhNU0J0WVdsdVgzUmxjM1JmWW05NFgzSmxabDl5YjNWMFpVQXhNaUJ0WVdsdVgySnZlRjl0WVhCZmRHVnpkRjl5YjNWMFpVQXhNeUJ0WVdsdVgySnZlRjl0WVhCZmMyVjBYM0p2ZFhSbFFERTBJRzFoYVc1ZlltOTRYMjFoY0Y5blpYUmZjbTkxZEdWQU1UVWdiV0ZwYmw5aWIzaGZiV0Z3WDJSbGJGOXliM1YwWlVBeE5pQnRZV2x1WDJKdmVGOXRZWEJmWlhocGMzUnpYM0p2ZFhSbFFERTNDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBNkNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG80Q2lBZ0lDQXZMeUJqYkdGemN5QkNiM2hEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkp2ZUY5dFlYQmZaWGhwYzNSelgzSnZkWFJsUURFM09nb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk9Bb2dJQ0FnTHk4Z1kyeGhjM01nUW05NFEyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1ltOTRYMjFoY0Y5bGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySnZlRjl0WVhCZlpHVnNYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UY3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZPQW9nSUNBZ0x5OGdZMnhoYzNNZ1FtOTRRMjl1ZEhKaFkzUW9ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UY3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdZbTk0WDIxaGNGOWtaV3dLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbTk0WDIxaGNGOW5aWFJmY205MWRHVkFNVFU2Q2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG80Q2lBZ0lDQXZMeUJqYkdGemN5QkNiM2hEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJpYjNoZmJXRndYMmRsZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbTk0WDIxaGNGOXpaWFJmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG80Q2lBZ0lDQXZMeUJqYkdGemN5QkNiM2hEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdZbTk0WDIxaGNGOXpaWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbTk0WDIxaGNGOTBaWE4wWDNKdmRYUmxRREV6T2dvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJpYjNoZmJXRndYM1JsYzNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWemRGOWliM2hmY21WbVgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T1RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhSbGMzUmZZbTk0WDNKbFpnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aGNtTTBYMkp2ZUY5eWIzVjBaVUF4TVRvS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJoY21NMFgySnZlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpiR2xqWlY5aWIzaGZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ2MyeHBZMlZmWW05NENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKdmVHVnpYMlY0YVhOMFgzSnZkWFJsUURrNkNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWW05NFpYTmZaWGhwYzNRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnYzNkaGNBb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxZV1JmWW05NFpYTmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCeVpXRmtYMkp2ZUdWekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdZd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERXlJQzh2SURFeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5a1pXeGxkR1ZmWW05NFpYTmZjbTkxZEdWQU56b0tJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCa1pXeGxkR1ZmWW05NFpYTUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyaGxZMnRmYTJWNWMxOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTmxkRjlpYjNobGMxOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNENpQWdJQ0F2THlCamJHRnpjeUJDYjNoRGIyNTBjbUZqZENoaGNtTTBMa0ZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhObGRGOWliM2hsY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UZzZDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNENpQWdJQ0F2THlCamJHRnpjeUJDYjNoRGIyNTBjbUZqZENoaGNtTTBMa0ZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHVjRZVzF3YkdWekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUVOdmJuUnlZV04wTG5ObGRGOWliM2hsY3loaE9pQjFhVzUwTmpRc0lHSTZJR0o1ZEdWekxDQmpPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tjMlYwWDJKdmVHVnpPZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UY3RNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSE5sZEY5aWIzaGxjeWh6Wld4bUxDQmhPaUJWU1c1ME5qUXNJR0k2SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6TENCak9pQmhjbU0wTGxOMGNtbHVaeWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUhObGJHWXVZbTk0WDJFdWRtRnNkV1VnUFNCaENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVGOWhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMkl1ZG1Gc2RXVWdQU0JpTG1OdmNIa29LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUhObGJHWXVZbTk0WDJNdWRtRnNkV1VnUFNCakNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5ESTBaalU0TldZME13b2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROREkwWmpVNE5XWTBNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lNZ29nSUNBZ0x5OGdjMlZzWmk1aWIzaGZaQzUyWVd4MVpTQTlJR0l1Ym1GMGFYWmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaGZaQ0lLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NFgyUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNalFLSUNBZ0lDOHZJR0pmZG1Gc2RXVWdQU0J6Wld4bUxtSnZlRjlpTG5aaGJIVmxMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlpSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2ZUY5aUlHVjRhWE4wY3dvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVGOWlMblpoYkhWbExteGxibWQwYUNBOVBTQmlYM1poYkhWbExteGxibWQwYUN3Z0ltUnBjbVZqZENCeVpXWmxjbVZ1WTJVZ2MyaHZkV3hrSUcxaGRHTm9JR052Y0hraUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaUlnb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbTk0WDJJZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCa2FYSmxZM1FnY21WbVpYSmxibU5sSUhOb2IzVnNaQ0J0WVhSamFDQmpiM0I1Q2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3lOd29nSUNBZ0x5OGdjMlZzWmk1aWIzaGZZUzUyWVd4MVpTQXJQU0F6Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ppYjNoZllTSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2ZUY5aElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2ZUY5aElnb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1qa3RNekFLSUNBZ0lDOHZJQ01nZEdWemRDQXViR1Z1WjNSb0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2hmWVM1c1pXNW5kR2dnUFQwZ09Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVltOTRYMkVpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWIzaGZZU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnT0NBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0WDJJdWJHVnVaM1JvSUQwOUlHSXVZbmwwWlhNdWJHVnVaM1JvQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppSWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOTRYMklnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TXpJS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtSnZlRjlqTG14bGJtZDBhQ0E5UFNCakxtSjVkR1Z6TG14bGJtZDBhQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFF5TkdZMU9EVm1ORE1LSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KdmVGOWpJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRYMlF1YkdWdVozUm9JRDA5SUdJdWJtRjBhWFpsTG14bGJtZDBhQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZbTk0WDJRaUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWliM2hmWkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3pOUzB6TmdvZ0lDQWdMeThnSXlCMFpYTjBJQzUyWVd4MVpTNWllWFJsY3dvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRYMk11ZG1Gc2RXVXVZbmwwWlhOYk1GMGdQVDBnWXk1aWVYUmxjMXN3WFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURReU5HWTFPRFZtTkRNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzaGZZeTUyWVd4MVpTNWllWFJsYzFzdE1WMGdQVDBnWXk1aWVYUmxjMXN0TVYwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnME1qUm1OVGcxWmpRekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCd2IzQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TkRJMFpqVTROV1kwTXdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRYMk11ZG1Gc2RXVXVZbmwwWlhOYk9pMHhYU0E5UFNCakxtSjVkR1Z6V3pvdE1WMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzBNalJtTlRnMVpqUXpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCa2FXY2dNUW9nSUNBZ1BBb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFF5TkdZMU9EVm1ORE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1pHbG5JRE1LSUNBZ0lENDlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NFgyTXVkbUZzZFdVdVlubDBaWE5iT2pKZElEMDlJR011WW5sMFpYTmJPakpkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TkRJMFpqVTROV1kwTXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdaR2xuSURFS0lDQWdJRHdLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCemQyRndDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcwTWpSbU5UZzFaalF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5ERXRORElLSUNBZ0lDOHZJQ01nZEdWemRDQXVkbUZzZFdVZ2QybDBhQ0JDZVhSbGN5QjBlWEJsQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzaGZaQzUyWVd4MVpWc3dYU0E5UFNCaUxtNWhkR2wyWlZzd1hRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVltOTRYMlFpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NFgyUXVkbUZzZFdWYkxURmRJRDA5SUdJdWJtRjBhWFpsV3kweFhRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVltOTRYMlFpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmliM2hmWkNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0WDJRdWRtRnNkV1ZiT2kweFhTQTlQU0JpTG01aGRHbDJaVnM2TFRGZENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaGZaQ0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQThDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0F0Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppYjNoZlpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklESUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNoZlpDNTJZV3gxWlZzNk5WMGdQVDBnWWk1dVlYUnBkbVZiT2pWZENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWIzaGZaQ0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eklDOHZJRFVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQThDaUFnSUNCcGJuUmpYek1nTHk4Z05Rb2dJQ0FnYzNkaGNBb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmliM2hmWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JwYm5Salh6TWdMeThnTlFvZ0lDQWdaR2xuSURJS0lDQWdJRDQ5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOUW9nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUp2ZUY5a0xuWmhiSFZsV3pvZ1ZVbHVkRFkwS0RJcFhTQTlQU0JpTG01aGRHbDJaVnM2SUZWSmJuUTJOQ2d5S1YwS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVGOWtJZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdjRzl3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lEd0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSnZlRjlrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUVOdmJuUnlZV04wTG1SbGJHVjBaVjlpYjNobGN5Z3BJQzArSUhadmFXUTZDbVJsYkdWMFpWOWliM2hsY3pvS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVpYjNoZllTNTJZV3gxWlFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFgyRWlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNWliM2hmWWk1MllXeDFaUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbUp2ZUY5akxuWmhiSFZsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TkRJMFpqVTROV1kwTXdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRYMkV1WjJWMEtHUmxabUYxYkhROVZVbHVkRFkwS0RReUtTa2dQVDBnTkRJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVGOWhJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdjSFZ6YUdsdWRDQTBNaUF2THlBME1nb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSEIxYzJocGJuUWdORElnTHk4Z05ESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2hmWWk1blpYUW9aR1ZtWVhWc2REMWhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aGlJalF5SWlrcExtNWhkR2wyWlNBOVBTQmlJalF5SWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWWlJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNREF3TWpNME16SUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE0wTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPall4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzaGZZeTVuWlhRb1pHVm1ZWFZzZEQxaGNtTTBMbE4wY21sdVp5Z2lORElpS1NrZ1BUMGdJalF5SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURReU5HWTFPRFZtTkRNS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNREF3TWpNME16SUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd01EQXlNelF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJR0VzSUdGZlpYaHBjM1J6SUQwZ2MyVnNaaTVpYjNoZllTNXRZWGxpWlNncENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaWIzaGZZU0lLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUdGZlpYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QmhjM05sY25RZ1lTQTlQU0F3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR1Y0WVcxd2JHVnpMbUp2ZUY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGtKdmVFTnZiblJ5WVdOMExuSmxZV1JmWW05NFpYTW9LU0F0UGlCMWFXNTBOalFzSUdKNWRHVnpMQ0JpZVhSbGN6b0tjbVZoWkY5aWIzaGxjem9LSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QnlaWFIxY200Z1oyVjBYMkp2ZUY5MllXeDFaVjl3YkhWelh6RW9jMlZzWmk1aWIzaGZZU2tnTFNBeExDQnpaV3htTG1KdmVGOWlMblpoYkhWbExtNWhkR2wyWlN3Z2MyVnNaaTVpYjNoZll5NTJZV3gxWlFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFgyRWlDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE9ERUtJQ0FnSUM4dklISmxkSFZ5YmlCaWIzZ3VkbUZzZFdVZ0t5QXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FtOTRJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QnlaWFIxY200Z1oyVjBYMkp2ZUY5MllXeDFaVjl3YkhWelh6RW9jMlZzWmk1aWIzaGZZU2tnTFNBeExDQnpaV3htTG1KdmVGOWlMblpoYkhWbExtNWhkR2wyWlN3Z2MyVnNaaTVpYjNoZll5NTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSWlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpYjNoZllpQmxlR2x6ZEhNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TkRJMFpqVTROV1kwTXdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOTRYMk1nWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NWliM2hmYzNSdmNtRm5aUzVqYjI1MGNtRmpkQzVDYjNoRGIyNTBjbUZqZEM1aWIzaGxjMTlsZUdsemRDZ3BJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBMQ0IxYVc1ME5qUTZDbUp2ZUdWelgyVjRhWE4wT2dvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOeklLSUNBZ0lDOHZJSEpsZEhWeWJpQmliMjlzS0hObGJHWXVZbTk0WDJFcExDQmliMjlzS0hObGJHWXVZbTk0WDJJcExDQmliMjlzS0hObGJHWXVZbTk0WDJNcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaWIzaGZZU0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlpSUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURReU5HWTFPRFZtTkRNS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdaWGhoYlhCc1pYTXVZbTk0WDNOMGIzSmhaMlV1WTI5dWRISmhZM1F1UW05NFEyOXVkSEpoWTNRdWMyeHBZMlZmWW05NEtDa2dMVDRnZG05cFpEb0tjMnhwWTJWZlltOTRPZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk56WUtJQ0FnSUM4dklHSnZlRjh3SUQwZ1FtOTRLRUo1ZEdWekxDQnJaWGs5VTNSeWFXNW5LQ0l3SWlrcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNJd0lnb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUdKdmVGOHdMblpoYkhWbElEMGdRbmwwWlhNb1lpSlVaWE4wYVc1bklIUmxjM1JwYm1jZ01USXpJaWtLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJR0p2ZUY4d0lEMGdRbTk0S0VKNWRHVnpMQ0JyWlhrOVUzUnlhVzVuS0NJd0lpa3BDaUFnSUNCaWVYUmxZeUE0SUM4dklDSXdJZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklHSnZlRjh3TG5aaGJIVmxJRDBnUW5sMFpYTW9ZaUpVWlhOMGFXNW5JSFJsYzNScGJtY2dNVEl6SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVME5qVTNNemMwTmprMlpUWTNNakEzTkRZMU56TTNORFk1Tm1VMk56SXdNekV6TWpNekNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvM05nb2dJQ0FnTHk4Z1ltOTRYekFnUFNCQ2IzZ29RbmwwWlhNc0lHdGxlVDFUZEhKcGJtY29JakFpS1NrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSWpBaUNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnWVhOelpYSjBJR0p2ZUY4d0xuWmhiSFZsV3pBNk4xMGdQVDBnWWlKVVpYTjBhVzVuSWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J3ZFhOb2FXNTBJRGNnTHk4Z053b2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBM0lDOHZJRGNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUdKdmVGOHdJRDBnUW05NEtFSjVkR1Z6TENCclpYazlVM1J5YVc1bktDSXdJaWtwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0l3SWdvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmliM2hmTUM1MllXeDFaVnN3T2pkZElEMDlJR0lpVkdWemRHbHVaeUlLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTkRZMU56TTNORFk1Tm1VMk53b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUhObGJHWXVZbTk0WDJNdWRtRnNkV1VnUFNCaGNtTTBMbE4wY21sdVp5Z2lTR1ZzYkc4aUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEUXlOR1kxT0RWbU5ETUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFF5TkdZMU9EVm1ORE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURVME9EWTFObU0yWXpabUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0WDJNdWRtRnNkV1V1WW5sMFpYTmJNam94TUYwZ1BUMGdZaUpJWld4c2J5SUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzBNalJtTlRnMVpqUXpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1BBb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjSFZ6YUdsdWRDQXhNQ0F2THlBeE1Bb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeE1DQXZMeUF4TUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROREkwWmpVNE5XWTBNd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFE0TmpVMll6WmpObVlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR1Y0WVcxd2JHVnpMbUp2ZUY5emRHOXlZV2RsTG1OdmJuUnlZV04wTGtKdmVFTnZiblJ5WVdOMExtRnlZelJmWW05NEtDa2dMVDRnZG05cFpEb0tZWEpqTkY5aWIzZzZDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1ltOTRYMlFnUFNCQ2IzZ29VM1JoZEdsalNXNTBjeXdnYTJWNVBVSjVkR1Z6S0dJaVpDSXBLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlRFkwQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzROZ29nSUNBZ0x5OGdZbTk0WDJRdWRtRnNkV1VnUFNCVGRHRjBhV05KYm5SektHRnlZelF1VlVsdWREZ29NQ2tzSUdGeVl6UXVWVWx1ZERnb01Ta3NJR0Z5WXpRdVZVbHVkRGdvTWlrc0lHRnlZelF1VlVsdWREZ29NeWtwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBeE1ESXdNd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR0p2ZUY5a0lEMGdRbTk0S0ZOMFlYUnBZMGx1ZEhNc0lHdGxlVDFDZVhSbGN5aGlJbVFpS1NrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnMk5Bb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0JpYjNoZlpDNTJZV3gxWlZzd1hTQTlQU0F3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0SUdWNGFYTjBjd29nSUNBZ1pYaDBjbUZqZENBd0lERWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQUtJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1ltOTRYMlFnUFNCQ2IzZ29VM1JoZEdsalNXNTBjeXdnYTJWNVBVSjVkR1Z6S0dJaVpDSXBLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlRFkwQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjlrTG5aaGJIVmxXekZkSUQwOUlERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQ2IzZ2daWGhwYzNSekNpQWdJQ0JsZUhSeVlXTjBJREVnTVNBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4Q2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR0p2ZUY5a0lEMGdRbTk0S0ZOMFlYUnBZMGx1ZEhNc0lHdGxlVDFDZVhSbGN5aGlJbVFpS1NrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnMk5Bb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUdGemMyVnlkQ0JpYjNoZlpDNTJZV3gxWlZzeVhTQTlQU0F5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0SUdWNGFYTjBjd29nSUNBZ1pYaDBjbUZqZENBeUlERWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01nb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCaWIzaGZaQ0E5SUVKdmVDaFRkR0YwYVdOSmJuUnpMQ0JyWlhrOVFubDBaWE1vWWlKa0lpa3BDaUFnSUNCaWVYUmxZeUEySUM4dklEQjROalFLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QmhjM05sY25RZ1ltOTRYMlF1ZG1Gc2RXVmJNMTBnUFQwZ013b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVKdmVDQmxlR2x6ZEhNS0lDQWdJR1Y0ZEhKaFkzUWdNeUF4SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRE1LSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTVpYjNoZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1Q2IzaERiMjUwY21GamRDNTBaWE4wWDJKdmVGOXlaV1lvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMkp2ZUY5eVpXWTZDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNU5TMDVOZ29nSUNBZ0x5OGdJeUJwYm1sMElISmxaaXdnZDJsMGFDQjJZV3hwWkNCclpYa2dkSGx3WlhNS0lDQWdJQzh2SUdKdmVGOXlaV1lnUFNCQ2IzaFNaV1lvYTJWNVBTSmliRzlpSWlrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Kc2IySWlDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRvNU53b2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQmliM2hmY21WbUxDQWlibThnWkdGMFlTSUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJR1JoZEdFS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUJpYjNoZmNtVm1JRDBnUW05NFVtVm1LR3RsZVQxaUltSnNiMklpS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZeU5tTTJaall5Q2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUbzVPUW9nSUNBZ0x5OGdZWE56WlhKMElHNXZkQ0JpYjNoZmNtVm1MQ0FpYm04Z1pHRjBZU0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2SUdSaGRHRUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z1ltOTRYM0psWmlBOUlFSnZlRkpsWmloclpYazlRbmwwWlhNb1lpSmliRzlpSWlrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qSTJZelptTmpJS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCaWIzaGZjbVZtTENBaWJtOGdaR0YwWVNJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dklHUmhkR0VLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXdNZ29nSUNBZ0x5OGdZbTk0WDNKbFppQTlJRUp2ZUZKbFppaHJaWGs5VTNSeWFXNW5LQ0ppYkc5aUlpa3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliRzlpSWdvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUdKdmVGOXlaV1lzSUNKdWJ5QmtZWFJoSWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm04Z1pHRjBZUW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QmliM2hmY21WbUlEMGdRbTk0VW1WbUtHdGxlVDFUZEhKcGJtY29JbUpzYjJJaUtTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNRFV0TVRBMkNpQWdJQ0F2THlBaklHTnlaV0YwWlFvZ0lDQWdMeThnWVhOelpYSjBJR0p2ZUY5eVpXWXVZM0psWVhSbEtITnBlbVU5TXpJcENpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z1ltOTRYM0psWmlBOUlFSnZlRkpsWmloclpYazlVM1J5YVc1bktDSmliRzlpSWlrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJHOWlJZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QmhjM05sY25RZ1ltOTRYM0psWml3Z0ltaGhjeUJrWVhSaElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR0Z6SUdSaGRHRUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFd09TMHhNVEFLSUNBZ0lDOHZJQ01nYldGdWFYQjFiR0YwWlNCa1lYUmhDaUFnSUNBdkx5QnpaVzVrWlhKZllubDBaWE1nUFNCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklHRndjRjloWkdSeVpYTnpJRDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeTVpZVhSbGN3b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z1ltOTRYM0psWmlBOUlFSnZlRkpsWmloclpYazlVM1J5YVc1bktDSmliRzlpSWlrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJHOWlJZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1URXpDaUFnSUNBdkx5QmliM2hmY21WbUxuSmxjR3hoWTJVb01Dd2djMlZ1WkdWeVgySjVkR1Z6S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QmliM2hmY21WbUlEMGdRbTk0VW1WbUtHdGxlVDFUZEhKcGJtY29JbUpzYjJJaUtTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNiMklpQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNVFFLSUNBZ0lDOHZJR0p2ZUY5eVpXWXVjbVZ6YVhwbEtEZ3dNREFwQ2lBZ0lDQndkWE5vYVc1MElEZ3dNREFnTHk4Z09EQXdNQW9nSUNBZ1ltOTRYM0psYzJsNlpRb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCaWIzaGZjbVZtSUQwZ1FtOTRVbVZtS0d0bGVUMVRkSEpwYm1jb0ltSnNiMklpS1NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Kc2IySWlDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklHSnZlRjl5WldZdWMzQnNhV05sS0RBc0lEQXNJR0Z3Y0Y5aFpHUnlaWE56S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSnZlRjl6Y0d4cFkyVUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z1ltOTRYM0psWmlBOUlFSnZlRkpsWmloclpYazlVM1J5YVc1bktDSmliRzlpSWlrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJHOWlJZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QmliM2hmY21WbUxuSmxjR3hoWTJVb05qUXNJSFpoYkhWbFh6TXBDaUFnSUNCd2RYTm9hVzUwSURZMElDOHZJRFkwQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJSFpoYkhWbFh6TWdQU0JDZVhSbGN5aGlJbWhsYkd4dklpa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZzJPRFkxTm1NMll6Wm1DaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklHSnZlRjl5WldZdWNtVndiR0ZqWlNnMk5Dd2dkbUZzZFdWZk15a0tJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TURJS0lDQWdJQzh2SUdKdmVGOXlaV1lnUFNCQ2IzaFNaV1lvYTJWNVBWTjBjbWx1WnlnaVlteHZZaUlwS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14dllpSUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z2NISmxabWw0SUQwZ1ltOTRYM0psWmk1bGVIUnlZV04wS0RBc0lETXlJQ29nTWlBcklIWmhiSFZsWHpNdWJHVnVaM1JvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhwYm5RZ05qa2dMeThnTmprS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQndjbVZtYVhnZ1BUMGdZWEJ3WDJGa1pISmxjM01nS3lCelpXNWtaWEpmWW5sMFpYTWdLeUIyWVd4MVpWOHpDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUIyWVd4MVpWOHpJRDBnUW5sMFpYTW9ZaUpvWld4c2J5SXBDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjROamcyTlRaak5tTTJaZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1URTRDaUFnSUNBdkx5QmhjM05sY25RZ2NISmxabWw0SUQwOUlHRndjRjloWkdSeVpYTnpJQ3NnYzJWdVpHVnlYMko1ZEdWeklDc2dkbUZzZFdWZk13b2dJQ0FnWTI5dVkyRjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklHSnZlRjl5WldZZ1BTQkNiM2hTWldZb2EyVjVQVk4wY21sdVp5Z2lZbXh2WWlJcEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlteHZZaUlLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXlNQzB4TWpFS0lDQWdJQzh2SUNNZ1pHVnNaWFJsQ2lBZ0lDQXZMeUJoYzNObGNuUWdZbTk0WDNKbFppNWtaV3hsZEdVb0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR0p2ZUY5eVpXWWdQU0JDYjNoU1pXWW9hMlY1UFZOMGNtbHVaeWdpWW14dllpSXBLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV5TkMweE1qVUtJQ0FnSUM4dklDTWdjWFZsY25rS0lDQWdJQzh2SUhaaGJIVmxMQ0JsZUdsemRITWdQU0JpYjNoZmNtVm1MbTFoZVdKbEtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXlOZ29nSUNBZ0x5OGdZWE56WlhKMElHNXZkQ0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRJM0NpQWdJQ0F2THlCaGMzTmxjblFnZG1Gc2RXVWdQVDBnWWlJaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnWW05NFgzSmxaaUE5SUVKdmVGSmxaaWhyWlhrOVUzUnlhVzVuS0NKaWJHOWlJaWtwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkc5aUlnb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCaGMzTmxjblFnWW05NFgzSmxaaTVuWlhRb1pHVm1ZWFZzZEQxelpXNWtaWEpmWW5sMFpYTXBJRDA5SUhObGJtUmxjbDlpZVhSbGN3b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFek1DMHhNekVLSUNBZ0lDOHZJQ01nZFhCa1lYUmxDaUFnSUNBdkx5QmliM2hmY21WbUxuQjFkQ2h6Wlc1a1pYSmZZbmwwWlhNZ0t5QmhjSEJmWVdSa2NtVnpjeWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJpYjNoZmNtVm1JRDBnUW05NFVtVm1LR3RsZVQxVGRISnBibWNvSW1Kc2IySWlLU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TXpBdE1UTXhDaUFnSUNBdkx5QWpJSFZ3WkdGMFpRb2dJQ0FnTHk4Z1ltOTRYM0psWmk1d2RYUW9jMlZ1WkdWeVgySjVkR1Z6SUNzZ1lYQndYMkZrWkhKbGMzTXBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR0p2ZUY5eVpXWWdQU0JDYjNoU1pXWW9hMlY1UFZOMGNtbHVaeWdpWW14dllpSXBLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakV6TWdvZ0lDQWdMeThnWVhOelpYSjBJR0p2ZUY5eVpXWXNJQ0pDYkc5aUlHVjRhWE4wY3lJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFSnNiMklnWlhocGMzUnpDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklHSnZlRjl5WldZZ1BTQkNiM2hTWldZb2EyVjVQVk4wY21sdVp5Z2lZbXh2WWlJcEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlteHZZaUlLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjl5WldZdWJHVnVaM1JvSUQwOUlEWTBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FtOTRVbVZtSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBMk5DQXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJpYjNoZmNtVm1JRDBnUW05NFVtVm1LR3RsZVQxVGRISnBibWNvSW1Kc2IySWlLU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94T0RZS0lDQWdJQzh2SUhKbGRIVnliaUJ5WldZdWJHVnVaM1JvQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRbTk0VW1WbUlHVjRhWE4wY3dvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdaMlYwWDJKdmVGOXlaV1pmYkdWdVozUm9LR0p2ZUY5eVpXWXBJRDA5SURZMENpQWdJQ0J3ZFhOb2FXNTBJRFkwSUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE16WXRNVE0zQ2lBZ0lDQXZMeUFqSUdsdWMzUmhibU5sSUdKdmVDQnlaV1lLSUNBZ0lDOHZJSE5sYkdZdVltOTRYM0psWmk1amNtVmhkR1VvYzJsNlpUMVZTVzUwTmpRb016SXBLUW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2ZUY5eVpXWWlDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFek9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0WDNKbFppd2dJbWhoY3lCa1lYUmhJZ29nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUp2ZUY5eVpXWWlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWVhNZ1pHRjBZUW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QnpaV3htTG1KdmVGOXlaV1l1WkdWc1pYUmxLQ2tLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0ppYjNoZmNtVm1JZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTVpYjNoZmMzUnZjbUZuWlM1amIyNTBjbUZqZEM1Q2IzaERiMjUwY21GamRDNWliM2hmYldGd1gzUmxjM1FvS1NBdFBpQjJiMmxrT2dwaWIzaGZiV0Z3WDNSbGMzUTZDaUFnSUNBdkx5QmliM2hmYzNSdmNtRm5aUzlqYjI1MGNtRmpkQzV3ZVRveE5ETUtJQ0FnSUM4dklHdGxlVjh3SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFEyQ2lBZ0lDQXZMeUJ6Wld4bUxtSnZlRjl0WVhCYmEyVjVYekJkSUQwZ2RtRnNkV1VLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTBOUW9nSUNBZ0x5OGdkbUZzZFdVZ1BTQlRkSEpwYm1jb0lraHRiVzF0YlNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtodGJXMXRiU0lLSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTBOZ29nSUNBZ0x5OGdjMlZzWmk1aWIzaGZiV0Z3VzJ0bGVWOHdYU0E5SUhaaGJIVmxDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVGOXRZWEJiYTJWNVh6QmRMbUo1ZEdWekxteGxibWQwYUNBOVBTQjJZV3gxWlM1aWVYUmxjeTVzWlc1bmRHZ0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbTk0WDIxaGNDQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUEyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVGOXRZWEF1YkdWdVozUm9LR3RsZVY4d0tTQTlQU0IyWVd4MVpTNWllWFJsY3k1c1pXNW5kR2dLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NFgyMWhjQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlBMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaWIzaGZjM1J2Y21GblpTOWpiMjUwY21GamRDNXdlVG94TkRRS0lDQWdJQzh2SUd0bGVWOHhJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UVXdDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNoZmJXRndMbWRsZENoclpYbGZNU3dnWkdWbVlYVnNkRDFUZEhKcGJtY29JbVJsWm1GMWJIUWlLU2tnUFQwZ1UzUnlhVzVuS0NKa1pXWmhkV3gwSWlrS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltUmxabUYxYkhRaUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0prWldaaGRXeDBJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UVXhDaUFnSUNBdkx5QjJZV3gxWlN3Z1pYaHBjM1J6SUQwZ2MyVnNaaTVpYjNoZmJXRndMbTFoZVdKbEtHdGxlVjh4S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdhMlY1WHpBZ2FXNGdjMlZzWmk1aWIzaGZiV0Z3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UVTRDaUFnSUNBdkx5QjBiWEJmWW05NFgyMWhjRnRyWlhsZk1WMGdQU0JUZEhKcGJtY29JbWhsYkd4dklpa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltaGxiR3h2SWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCeVpYUjFjbTRnWW05NFgyMWhjRnRyWlhrZ0t5QXhYUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FtOTRUV0Z3SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRVNUNpQWdJQ0F2THlCaGMzTmxjblFnWjJWMFgySnZlRjl0WVhCZmRtRnNkV1ZmWm5KdmJWOXJaWGxmY0d4MWMxOHhLSFJ0Y0Y5aWIzaGZiV0Z3TENCVlNXNTBOalFvTUNrcElEMDlJQ0pvWld4c2J5SUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltaGxiR3h2SWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFl3Q2lBZ0lDQXZMeUJrWld3Z2RHMXdYMkp2ZUY5dFlYQmJhMlY1WHpGZENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxtSnZlRjl6ZEc5eVlXZGxMbU52Ym5SeVlXTjBMa0p2ZUVOdmJuUnlZV04wTG1KdmVGOXRZWEJmYzJWMEtHdGxlVG9nZFdsdWREWTBMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtSnZlRjl0WVhCZmMyVjBPZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UWXlMVEUyTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWW05NFgyMWhjRjl6WlhRb2MyVnNaaXdnYTJWNU9pQlZTVzUwTmpRc0lIWmhiSFZsT2lCVGRISnBibWNwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklHSnZlRjl6ZEc5eVlXZGxMMk52Ym5SeVlXTjBMbkI1T2pFMk5Bb2dJQ0FnTHk4Z2MyVnNaaTVpYjNoZmJXRndXMnRsZVYwZ1BTQjJZV3gxWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCbGVHRnRjR3hsY3k1aWIzaGZjM1J2Y21GblpTNWpiMjUwY21GamRDNUNiM2hEYjI1MGNtRmpkQzVpYjNoZmJXRndYMmRsZENoclpYazZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbUp2ZUY5dFlYQmZaMlYwT2dvZ0lDQWdMeThnWW05NFgzTjBiM0poWjJVdlkyOXVkSEpoWTNRdWNIazZNVFkyTFRFMk53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1ltOTRYMjFoY0Y5blpYUW9jMlZzWml3Z2EyVjVPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z1ltOTRYM04wYjNKaFoyVXZZMjl1ZEhKaFkzUXVjSGs2TVRZNENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2hmYldGd1cydGxlVjBLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NFgyMWhjQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdWNFlXMXdiR1Z6TG1KdmVGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExrSnZlRU52Ym5SeVlXTjBMbUp2ZUY5dFlYQmZaR1ZzS0d0bGVUb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGliM2hmYldGd1gyUmxiRG9LSUNBZ0lDOHZJR0p2ZUY5emRHOXlZV2RsTDJOdmJuUnlZV04wTG5CNU9qRTNNQzB4TnpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdKdmVGOXRZWEJmWkdWc0tITmxiR1lzSUd0bGVUb2dWVWx1ZERZMEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJpYjNoZmMzUnZjbUZuWlM5amIyNTBjbUZqZEM1d2VUb3hOeklLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbUp2ZUY5dFlYQmJhMlY1WFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdWNFlXMXdiR1Z6TG1KdmVGOXpkRzl5WVdkbExtTnZiblJ5WVdOMExrSnZlRU52Ym5SeVlXTjBMbUp2ZUY5dFlYQmZaWGhwYzNSektHdGxlVG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q21KdmVGOXRZWEJmWlhocGMzUnpPZ29nSUNBZ0x5OGdZbTk0WDNOMGIzSmhaMlV2WTI5dWRISmhZM1F1Y0hrNk1UYzBMVEUzTlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWW05NFgyMWhjRjlsZUdsemRITW9jMlZzWml3Z2EyVjVPaUJWU1c1ME5qUXBJQzArSUdKdmIydzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdKdmVGOXpkRzl5WVdkbEwyTnZiblJ5WVdOMExuQjVPakUzTmdvZ0lDQWdMeThnY21WMGRYSnVJR3RsZVNCcGJpQnpaV3htTG1KdmVGOXRZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQUNCU1lOQlVKUFdGOURCR0pzYjJJRlltOTRYMlFGWW05NFgyRUJZZ0VBQVdRRUZSOThkUUV3QldobGJHeHZCQUFDTkRJSFltOTRYM0psWmdka1pXWmhkV3gwTVJ0QkFZS0NEUVI5TnlsdUJETXlYVDBFMVdiR01nVDcycHVnQk9XajdWSUVCTzlKY1FRajdMTXNCTzczV0JZRXRUS1JPZ1RDbnhacEJKeUlqQWtFNXZhRkJnU080c05rTmhvQWpnMEJDZ0VCQVBVQXdnQ1FBSVFBZUFCc0FHQUFTZ0F0QUIwQUFpTkRNUmtVUkRFWVJEWWFBUmVJQkhvbkJTTlBBbFFuQjB4UXNDSkRNUmtVUkRFWVJEWWFBUmVJQkZZaVF6RVpGRVF4R0VRMkdnRVhpQVE5U1JVV1Z3WUNURkFuQjB4UXNDSkRNUmtVUkRFWVJEWWFBUmMyR2dKWEFnQ0lCQTBpUXpFWkZFUXhHRVNJQTdzaVF6RVpGRVF4R0VTSUF5WWlRekVaRkVReEdFU0lBdUVpUXpFWkZFUXhHRVNJQWxraVF6RVpGRVF4R0VTSUFqOG5CU05QQkZRbkJTTlBCRlFuQlNOUEJGUk1JMU5QQWlKUEFsUk1JMU1rVEZRbkIweFFzQ0pETVJrVVJERVlSSWdCK0U4Q0Zrc0NGUlpYQmdKUEExQk1nQUlBREZCTEFSV0JEQWdXVndZQ1VFeFFURkFuQjB4UXNDSkRNUmtVUkRFWVJJZ0JoeUpETVJrVVJERVlSQ0pETVJrVVJERVlSRFlhQVJjMkdnSTJHZ09JQUEwaVF6RVpRUDdiTVJnVVJDSkRpZ01BaS8wV0sweS9Kd1M4U0NjRWkvNi9LTHhJS0l2L3Y0ditWd0lBS3J4SUtrc0J2eWNFdmtRbkJMNUVJMWxNSTFrU1JDdStUQmRNUklFRENCWXJUTDhydlVTQkNCSkVKd1M5Ukl2K0ZSSkVLTDFFaS84VlRFc0JFa1FxdlVSTEFoVk1Td0VTUkNnaklycUwvMWNBQVJKRUtMMUlJZ2tvVENLNlN3SWlDWXYvVENKWUVrUW92VWdpU3dFTVN3RWlUd0pOQ1NnalR3SzZJa3NERHlKTEJFOENUVXNEVEFtTC95TlBBbElTUkNpOVNDUkxBUXdrVEUwb0kwOEN1aVJMQXc4a1R3UlBBazJML3lOUEFsSVNSQ29qSXJxTC9sY0NBUkpFS3IxSUlna3FUQ0s2U3dFaUNVc0RUQ0pZRWtRcXZVZ2lTd0VNU3dFaVR3Sk5DU29qVHdLNklrc0NEeUpMQTA4Q1RVc0NUQWxMQXlOUEFsSVNSQ3E5U0NWTEFRd2xURTBxSTA4Q3VpVkxBZzhsU3dOUEFrMUxBeU5QQWxJU1JDcTlTQ1JMQVF3a1RFMHFJMDhDdWlSTEFnOGtUd05QQWsxUEFpTlBBbElTUklrcnZFZ25CTHhJS0x4SUs3NU1GNEVxVEU4Q1RZRXFFa1FuQkw0bkNrNENUVmNDQUlBQ05ESVNSQ2krSndwT0FrMG5DaEpFSzc1TUYwd1VSQlJFaVN1K1RCZE1SQ0lJSWdrbkJMNUVWd0lBS0w1RWlTdTlSUUVuQkwxRkFTaTlSUUdKSndpOFNDY0lnQk5VWlhOMGFXNW5JSFJsYzNScGJtY2dNVEl6dnljSXZVaEpJMHNDVFlFSFN3SU1Ud0tCQjA4Q1RVc0JDU2NJVGdLNmdBZFVaWE4wYVc1bkVrUW92RWdvZ0FjQUJVaGxiR3h2dnlpOVNDUkxBUXhMQVNSUEFrMkJDa3NDREU4Q2dRcFBBazFMQVFrb1RnSzZnQVZJWld4c2J4SkVpU2NHZ0FRQUFRSUR2eWNHdmtSWEFBRW5CYWhFSndhK1JGY0JBWUFCQWFoRUp3YStSRmNDQVlBQkFxaEVKd2ErUkZjREFZQUJBNmhFaVNtOVJRRVVSQ205UlFFVVJDbTlSUUVVUkNtOVJRRVVSQ21CSUxsRUtiMUZBVVF4QURJS0tTTkxBN3NwZ2NBKzB5a2pTVXNEMGltQlFDY0p1eWtqZ1VXNlN3RkxBMUFuQ1ZBU1JDbThSQ20rRkVTQUFCSkVLYjVMQTA0Q1RVc0NFa1JRS1V5L0tiMUZBVVFwdlVTQlFCSkVLYjFFZ1VBU1JDY0xnU0M1U0NjTHZVVUJSQ2NMdkVpSkl4Wkp2RWhKZ0FaSWJXMXRiVzIvU2IxRWdRWVNSRW05UklFR0VrUWlGa20rSnd4T0FrMG5EQkpFU2I1RkFSUkVUTDFGQVVSSnZFaEpKd20vU2I1RUp3a1NSTHhJaVlvQ0FJditGa204U0l2L3Y0bUtBUUdML3hhK1JJbUtBUUNML3hhOFNJbUtBUUdML3hhOVJRR0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
