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

namespace Arc56.Generated.manuelmauro.algonaut.vault_f0b47496
{


    //
    // An ARC-56 contract exercising named-struct arguments
    //
    public class VaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Pair : AVMObjectType
            {
                public ulong First { get; set; }

                public ulong Second { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirst = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFirst.From(First);
                    ret.AddRange(vFirst.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSecond = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSecond.From(Second);
                    ret.AddRange(vSecond.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Pair Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Pair();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirst = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFirst.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFirst = vFirst.ToValue();
                    if (valueFirst is ulong vFirstValue) { ret.First = vFirstValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSecond = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSecond.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSecond = vSecond.ToValue();
                    if (valueSecond is ulong vSecondValue) { ret.Second = vSecondValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Pair);
                }
                public bool Equals(Pair? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Pair left, Pair right)
                {
                    return EqualityComparer<Pair>.Default.Equals(left, right);
                }
                public static bool operator !=(Pair left, Pair right)
                {
                    return !(left == right);
                }

            }

            public class Holder : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public ulong Amount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Holder Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Holder();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Holder);
                }
                public bool Equals(Holder? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Holder left, Holder right)
                {
                    return EqualityComparer<Holder>.Default.Equals(left, right);
                }
                public static bool operator !=(Holder left, Holder right)
                {
                    return !(left == right);
                }

            }

            public class Wrapper : AVMObjectType
            {
                public Structs.Pair Inner { get; set; } = new Structs.Pair();

                public string Label { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Inner.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLabel.From(Label);
                    stringRef[ret.Count] = vLabel.Encode();
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

                public static Wrapper Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Wrapper();
                    ret.Inner = Structs.Pair.Parse(queue.ToArray());
                    { var consumedInner = ret.Inner.ToByteArray().Length; for (int i = 0; i < consumedInner && queue.Count > 0; i++) { queue.Dequeue(); } }
                    var indexLabel = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLabel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLabel.Decode(bytes.Skip(indexLabel + prefixOffset).ToArray());
                    var valueLabel = vLabel.ToValue();
                    if (valueLabel is string vLabelValue) { ret.Label = vLabelValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Wrapper);
                }
                public bool Equals(Wrapper? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Wrapper left, Wrapper right)
                {
                    return EqualityComparer<Wrapper>.Default.Equals(left, right);
                }
                public static bool operator !=(Wrapper left, Wrapper right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class CountedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 75, 28, 181, 156 };
                public const string Signature = "Counted(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Total { get; set; }

                public static CountedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CountedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotal = vTotal.ToValue();
                    if (valueTotal is ulong vTotalValue) { ret.Total = vTotalValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Store a pair
        ///</summary>
        /// <param name="p"> Pair</param>
        public async Task Store(Structs.Pair p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 185, 190, 40 };

            var result = await base.CallApp(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Store_Transactions(Structs.Pair p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 185, 190, 40 };

            return await base.MakeTransactionList(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="w"> Wrapper</param>
        public async Task StoreWrapped(Structs.Wrapper w, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 196, 170, 253 };

            var result = await base.CallApp(new List<object> { abiHandle, w }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StoreWrapped_Transactions(Structs.Wrapper w, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 196, 170, 253 };

            return await base.MakeTransactionList(new List<object> { abiHandle, w }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Pair> GetPair(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 87, 130, 71 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Pair.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPair_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 87, 130, 71 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mix a struct argument with a scalar
        ///</summary>
        /// <param name="p"> Pair</param>
        /// <param name="factor"> </param>
        public async Task<ulong> Scale(Structs.Pair p, ulong factor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 17, 141, 69 };
            var factorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factorAbi.From(factor);

            var result = await base.CallApp(new List<object> { abiHandle, p, factorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Scale_Transactions(Structs.Pair p, ulong factor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 17, 141, 69 };
            var factorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); factorAbi.From(factor);

            return await base.MakeTransactionList(new List<object> { abiHandle, p, factorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increment by a step that defaults to the literal 1
        ///</summary>
        /// <param name="step"> </param>
        public async Task<ulong> Incr(ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 116, 112, 11 };
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            var result = await base.CallApp(new List<object> { abiHandle, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Incr_Transactions(ulong step, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 116, 112, 11 };
            var stepAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stepAbi.From(step);

            return await base.MakeTransactionList(new List<object> { abiHandle, stepAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the caller into the app
        ///</summary>
        public async Task Enroll(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 249, 2, 204 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Enroll_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 249, 2, 204 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sum a dynamic uint64 array (array-argument round trip)
        ///</summary>
        /// <param name="xs"> </param>
        public async Task<ulong> Sum(ulong[] xs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 148, 253, 194 };
            var xsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); xsAbi.From(xs);

            var result = await base.CallApp(new List<object> { abiHandle, xsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Sum_Transactions(ulong[] xs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 148, 253, 194 };
            var xsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); xsAbi.From(xs);

            return await base.MakeTransactionList(new List<object> { abiHandle, xsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sum a static uint64[3] array
        ///</summary>
        /// <param name="xs"> </param>
        public async Task<ulong> Sum3(ulong[] xs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 116, 202, 156 };
            var xsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(3, "uint64"); xsAbi.From(xs);

            var result = await base.CallApp(new List<object> { abiHandle, xsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Sum3_Transactions(ulong[] xs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 116, 202, 156 };
            var xsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(3, "uint64"); xsAbi.From(xs);

            return await base.MakeTransactionList(new List<object> { abiHandle, xsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Echo a referenced account (reference-argument round trip)
        ///</summary>
        /// <param name="acct"> </param>
        public async Task<Algorand.Address> Who(Address acct, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acct });
            byte acctRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 155, 173, 178, 11 };
            var acctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctAbi.From(acct);

            var result = await base.CallApp(new List<object> { abiHandle, acctRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Who_Transactions(Address acct, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { acct });
            byte acctRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 155, 173, 178, 11 };
            var acctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctAbi.From(acct);

            return await base.MakeTransactionList(new List<object> { abiHandle, acctRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Write a uint64 into a box (box-reference round trip)
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="value"> </param>
        public async Task BoxPut(string name, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 245, 95, 115 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BoxPut_Transactions(string name, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 245, 95, 115 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read a uint64 from a box
        ///</summary>
        /// <param name="name"> </param>
        public async Task<ulong> BoxGet(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 174, 93, 138 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BoxGet_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 123, 174, 93, 138 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify a grouped payment (transaction-argument round trip)
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="expected"> </param>
        public async Task Deposit(PaymentTransaction payment, ulong expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 242, 53, 91, 85 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedAbi.From(expected);

            var result = await base.CallApp(new List<object> { abiHandle, payment, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payment, ulong expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 242, 53, 91, 85 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedAbi.From(expected);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sum an anonymous (uint64,uint64) tuple argument
        ///</summary>
        /// <param name="p"> Pair</param>
        public async Task<ulong> AddPair(Structs.Pair p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 255, 91, 32 };

            var result = await base.CallApp(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddPair_Transactions(Structs.Pair p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 255, 91, 32 };

            return await base.MakeTransactionList(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the raw, unscaled integer of a ufixed64x2 argument
        ///</summary>
        /// <param name="p"> </param>
        public async Task<ulong> PriceRaw(System.Numerics.BigInteger p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 170, 89, 85 };
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UFixed(64, 2); pAbi.From(p);

            var result = await base.CallApp(new List<object> { abiHandle, pAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PriceRaw_Transactions(System.Numerics.BigInteger p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 170, 89, 85 };
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UFixed(64, 2); pAbi.From(p);

            return await base.MakeTransactionList(new List<object> { abiHandle, pAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNTZdLCJuYW1lIjoiVmF1bHQiLCJkZXNjIjoiQW4gQVJDLTU2IGNvbnRyYWN0IGV4ZXJjaXNpbmcgbmFtZWQtc3RydWN0IGFyZ3VtZW50cyIsIm5ldHdvcmtzIjp7IndHSEUyUHdkdmQ3UzEyQkw1RmFPUDIwRUdZZXNONzNrdGlDMXF6a2tpdDg9Ijp7ImFwcElEIjo3Nzd9fSwic3RydWN0cyI6eyJQYWlyIjpbeyJuYW1lIjoiZmlyc3QiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2Vjb25kIiwidHlwZSI6InVpbnQ2NCJ9XSwiSG9sZGVyIjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifV0sIldyYXBwZXIiOlt7Im5hbWUiOiJpbm5lciIsInR5cGUiOiJQYWlyIn0seyJuYW1lIjoibGFiZWwiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InN0b3JlIiwiZGVzYyI6IlN0b3JlIGEgcGFpciIsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYWlyIiwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOm51bGwsInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoic3RvcmVfd3JhcHBlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQpLHN0cmluZykiLCJzdHJ1Y3QiOiJXcmFwcGVyIiwibmFtZSI6InciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOm51bGwsInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0X3BhaXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUGFpciIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjpudWxsLCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InNjYWxlIiwiZGVzYyI6Ik1peCBhIHN0cnVjdCBhcmd1bWVudCB3aXRoIGEgc2NhbGFyIiwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlBhaXIiLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmFjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOm51bGwsInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiaW5jciIsImRlc2MiOiJJbmNyZW1lbnQgYnkgYSBzdGVwIHRoYXQgZGVmYXVsdHMgdG8gdGhlIGxpdGVyYWwgMSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGVwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjp7InNvdXJjZSI6ImxpdGVyYWwiLCJkYXRhIjoiQUFBQUFBQUFBQUU9IiwidHlwZSI6InVpbnQ2NCJ9fV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOm51bGwsInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZW5yb2xsIiwiZGVzYyI6Ik9wdCB0aGUgY2FsbGVyIGludG8gdGhlIGFwcCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiLCJPcHRJbiJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJzdW0iLCJkZXNjIjoiU3VtIGEgZHluYW1pYyB1aW50NjQgYXJyYXkgKGFycmF5LWFyZ3VtZW50IHJvdW5kIHRyaXApIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoieHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6bnVsbCwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJzdW0zIiwiZGVzYyI6IlN1bSBhIHN0YXRpYyB1aW50NjRbM10gYXJyYXkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0WzNdIiwic3RydWN0IjpudWxsLCJuYW1lIjoieHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6bnVsbCwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJ3aG8iLCJkZXNjIjoiRWNobyBhIHJlZmVyZW5jZWQgYWNjb3VudCAocmVmZXJlbmNlLWFyZ3VtZW50IHJvdW5kIHRyaXApIiwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2N0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjpudWxsLCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImJveF9wdXQiLCJkZXNjIjoiV3JpdGUgYSB1aW50NjQgaW50byBhIGJveCAoYm94LXJlZmVyZW5jZSByb3VuZCB0cmlwKSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6bnVsbCwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJib3hfZ2V0IiwiZGVzYyI6IlJlYWQgYSB1aW50NjQgZnJvbSBhIGJveCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOm51bGwsInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOiJWZXJpZnkgYSBncm91cGVkIHBheW1lbnQgKHRyYW5zYWN0aW9uLWFyZ3VtZW50IHJvdW5kIHRyaXApIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVjdGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjpudWxsLCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImFkZF9wYWlyIiwiZGVzYyI6IlN1bSBhbiBhbm9ueW1vdXMgKHVpbnQ2NCx1aW50NjQpIHR1cGxlIGFyZ3VtZW50IiwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlBhaXIiLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjpudWxsLCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InByaWNlX3JhdyIsImRlc2MiOiJSZXR1cm4gdGhlIHJhdywgdW5zY2FsZWQgaW50ZWdlciBvZiBhIHVmaXhlZDY0eDIgYXJndW1lbnQiLCJhcmdzIjpbeyJ0eXBlIjoidWZpeGVkNjR4MiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6bnVsbCwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjpudWxsLCJzb3VyY2VJbmZvIjpudWxsLCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlEZ0tDaTh2SUZaaGRXeDBJQzBnWVNCdGFXNXBiV0ZzSUdKMWRDQnlaV0ZzSUVGU1F5MDFOaUJ5WldabGNtVnVZMlVnWTI5dWRISmhZM1F1Q2k4dkNpOHZJRWwwSUdKaFkydHpJR0JsZUdGdGNHeGxjeTlqYjI1MGNtRmpkRjloY21NMU5pNXljMkFnWVc1a0lIUm9aU0JnZG1GMWJIUXVZWEpqTlRZdWFuTnZibUFnWVhCd0lITndaV002Q2k4dklIUm9aU0JsYldKbFpHUmxaQ0JpWVhObE5qUWdhVzRnZEdoaGRDQnpjR1ZqSjNNZ1lITnZkWEpqWlM1aGNIQnliM1poYkdBZ2FYTWdkR2hwY3lCbWFXeGxMQ0JoYm1RS0x5OGdZRlpoZFd4ME9qcGtaWEJzYjNsZ0lHTnZiWEJwYkdWeklHbDBJSFJvY205MVoyZ2dZV3huYjJRZ1lYUWdjblZ1ZEdsdFpTNEtMeThLTHk4Z1IyeHZZbUZzSUhOMFlYUmxJQ2h0WVhSamFHVnpJSFJvWlNCemNHVmpJSE5qYUdWdFlUb2dNU0IxYVc1MExDQXhJR0o1ZEdWemJHbGpaU2s2Q2k4dklDQWdJblJ2ZEdGc0lpQTZJRUZXVFZWcGJuUTJOQ0F0SUhKMWJtNXBibWNnWTI5MWJuUmxjZ292THlBZ0lDSnZkMjVsY2lJZ09pQmhaR1J5WlhOeklDQWdMU0IwYUdVZ1lXTmpiM1Z1ZENCMGFHRjBJR055WldGMFpXUWdkR2hsSUdGd2NBb3ZMd292THlCTWIyTmhiQ0J6ZEdGMFpTQW9iV0YwWTJobGN5QjBhR1VnYzNCbFl5QnpZMmhsYldFNklERWdkV2x1ZENrNkNpOHZJQ0FnSW5ObFpXNGlJQ0E2SUVGV1RWVnBiblEyTkNBdElITmxkQ0IwYnlBeElHbHVJSFJvWlNCallXeHNaWEluY3lCc2IyTmhiQ0J6ZEdGMFpTQnZiaUJ2Y0hRdGFXNEtMeThLTHk4Z1NYUWdZV3h6YnlCM2NtbDBaWE1nZFdsdWREWTBJR0p2ZUdWeklIWnBZU0JnWW05NFgzQjFkR0E3SUhSb1pTQmdZbTk0WlhOZ0lITjBZWFJsSUcxaGNDQmtaV05zWVhKbGN3b3ZMeUIwYUc5elpTQW9RVlpOVTNSeWFXNW5JR3RsZVNBdFBpQkJWazFWYVc1ME5qUWdkbUZzZFdVcElITnZJSFJvWlNCamJHbGxiblFnWjJWMGN5QmhJR0p2ZUMxdFlYQWdaMlYwZEdWeUxnb3ZMd292THlCSmRDQmthWE53WVhSamFHVnpJRUZTUXkwMElFRkNTU0JqWVd4c2N5QmllU0J6Wld4bFkzUnZjaUJoYm1RZ1pXMXBkSE1nZEdobElFRlNReTB5T0Fvdkx5QmdRMjkxYm5SbFpDaDFhVzUwTmpRcFlDQmxkbVZ1ZENCM2FHVnVaWFpsY2lCZ2RHOTBZV3hnSUdOb1lXNW5aWE11SUZSb1pTQmdiV1YwYUc5a0lDSXVMaTRpWUFvdkx5QndjMlYxWkc4dGIzQnpJR0psYkc5M0lHRnpjMlZ0WW14bElIUnZJSFJvWlNCellXMWxJRk5JUVMwMU1USXZNalUySUhObGJHVmpkRzl5Y3lCMGFHVWdaMlZ1WlhKaGRHVmtDaTh2SUZKMWMzUWdZMnhwWlc1MElITmxibVJ6TENCemJ5QjBhR1VnZEhkdklHRnNkMkY1Y3lCaFozSmxaUzRLQ2k4dklDMHRMU0JoY0hBZ1kzSmxZWFJwYjI0Z0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLYVc1MElEQUtQVDBLWW01NklHTnlaV0YwWlFvS0x5OGdMUzB0SUc5d2RDMXBiam9nZEdobElHQmxibkp2Ykd4Z0lHeHBabVZqZVdOc1pTQmhZM1JwYjI0Z0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFwMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q21sdWRDQlBjSFJKYmdvOVBRcGlibm9nYjNCMGFXNEtDaTh2SUMwdExTQkJRa2tnYldWMGFHOWtJR1JwYzNCaGRHTm9JQ2hPYjA5d0tTQXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtkSGh1SUU5dVEyOXRjR3hsZEdsdmJncHBiblFnVG05UGNBbzlQUXBpYm5vZ1pHbHpjR0YwWTJnS0NpOHZJRkpsYW1WamRDQmxkbVZ5ZVNCdmRHaGxjaUJ2YmkxamIyMXdiR1YwYVc5dUlDaDFjR1JoZEdVZ0x5QmtaV3hsZEdVZ0x5QmpiRzl6WlMxdmRYUXBMZ3BsY25JS0NtUnBjM0JoZEdOb09nb2dJQ0FnYldWMGFHOWtJQ0p6ZEc5eVpTZ29kV2x1ZERZMExIVnBiblEyTkNrcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lEMDlDaUFnSUNCaWJub2djM1J2Y21VS0NpQWdJQ0J0WlhSb2IyUWdJbk4wYjNKbFgzZHlZWEJ3WldRb0tDaDFhVzUwTmpRc2RXbHVkRFkwS1N4emRISnBibWNwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNBOVBRb2dJQ0FnWW01NklITjBiM0psWDNkeVlYQndaV1FLQ2lBZ0lDQnRaWFJvYjJRZ0ltZGxkRjl3WVdseUtDa29kV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdkbGRGOXdZV2x5Q2dvZ0lDQWdiV1YwYUc5a0lDSnpZMkZzWlNnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2MyTmhiR1VLQ2lBZ0lDQnRaWFJvYjJRZ0ltbHVZM0lvZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2FXNWpjZ29LSUNBZ0lHMWxkR2h2WkNBaVpXNXliMnhzS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQmhjSEJ5YjNabENnb2dJQ0FnYldWMGFHOWtJQ0ozYUc4b1lXTmpiM1Z1ZENsaFpHUnlaWE56SWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIzYUc4S0NpQWdJQ0J0WlhSb2IyUWdJbk4xYlNoMWFXNTBOalJiWFNsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSE4xYlFvS0lDQWdJRzFsZEdodlpDQWljM1Z0TXloMWFXNTBOalJiTTEwcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ6ZFcwekNnb2dJQ0FnYldWMGFHOWtJQ0ppYjNoZmNIVjBLSE4wY21sdVp5eDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lEMDlDaUFnSUNCaWJub2dZbTk0WDNCMWRBb0tJQ0FnSUcxbGRHaHZaQ0FpWW05NFgyZGxkQ2h6ZEhKcGJtY3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCaWIzaGZaMlYwQ2dvZ0lDQWdiV1YwYUc5a0lDSmtaWEJ2YzJsMEtIQmhlU3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWkdWd2IzTnBkQW9LSUNBZ0lHMWxkR2h2WkNBaVlXUmtYM0JoYVhJb0tIVnBiblEyTkN4MWFXNTBOalFwS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lEMDlDaUFnSUNCaWJub2dZV1JrWDNCaGFYSUtDaUFnSUNCdFpYUm9iMlFnSW5CeWFXTmxYM0poZHloMVptbDRaV1EyTkhneUtYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY0hKcFkyVmZjbUYzQ2dvZ0lDQWdaWEp5Q2dvdkx5QnZjSFF0YVc0Z0tIUm9aU0JnWlc1eWIyeHNZQ0JzYVdabFkzbGpiR1VnWVdOMGFXOXVLVG9nY21WamIzSmtJR3h2WTJGc0lDSnpaV1Z1SWlBOUlERWdabTl5SUhSb1pRb3ZMeUJqWVd4c1pYSXNJSFJvWlc0Z1lYQndjbTkyWlM0Z1VtVnhkV2x5WlhNZ2RHaGxJR3h2WTJGc0lITmphR1Z0WVNCMGJ5QmhiR3h2ZHlBeElIVnBiblF1Q205d2RHbHVPZ29nSUNBZ2FXNTBJREFnSUNBZ0lDQWdJQ0FnTHk4Z1lXTmpiM1Z1ZENCcGJtUmxlQ0F3SUQwZ1ZIaHVMbE5sYm1SbGNnb2dJQ0FnWW5sMFpTQWljMlZsYmlJS0lDQWdJR2x1ZENBeENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0JpSUdGd2NISnZkbVVLQ2k4dklHTnlaV0YwWlNncE9pQnZkMjVsY2lBOUlHTmhiR3hsY2l3Z2RHOTBZV3dnUFNBd0NtTnlaV0YwWlRvS0lDQWdJR0o1ZEdVZ0ltOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1VnSW5SdmRHRnNJZ29nSUNBZ2FXNTBJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmlJR0Z3Y0hKdmRtVUtDaTh2SUhOMGIzSmxLSEFwT2lCMGIzUmhiQ0E5SUhBdVptbHljM1FnS3lCd0xuTmxZMjl1WkRzZ1pXMXBkQ0JEYjNWdWRHVmtLSFJ2ZEdGc0tRb3ZMeUJVYUdVZ0tIVnBiblEyTkN4MWFXNTBOalFwSUhSMWNHeGxJR2x6SUdFZ01UWXRZbmwwWlNCemRHRjBhV01nWlc1amIyUnBibWNnYVc0Z1lYSm5JREV1Q25OMGIzSmxPZ29nSUNBZ1lubDBaU0FpZEc5MFlXd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCcGJuUWdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHbHVkQ0E0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdLd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHMWxkR2h2WkNBaVEyOTFiblJsWkNoMWFXNTBOalFwSWdvZ0lDQWdZbmwwWlNBaWRHOTBZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR0lnWVhCd2NtOTJaUW9LTHk4Z2MzUnZjbVZmZDNKaGNIQmxaQ2gzS1RvZ2RHOTBZV3dnUFNCM0xtbHVibVZ5TG1acGNuTjBJQ3NnZHk1cGJtNWxjaTV6WldOdmJtUTdJR1Z0YVhRZ1EyOTFiblJsWkNoMGIzUmhiQ2tLTHk4Z1ZHaGxJSGR5WVhCd1pYSWdhWE1nS0Nnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzYzNSeWFXNW5LU2s3SUhSb1pTQnBibTVsY2lCd1lXbHlJR2x6SUhSb1pTQnpkR0YwYVdNZ2FHVmhaQW92THlCaGRDQnZabVp6WlhRZ01Dd2djMjhnZEdobElIUnlZV2xzYVc1bklITjBjbWx1WnlCcGN5QnphVzF3YkhrZ2FXZHViM0psWkNCb1pYSmxMZ3B6ZEc5eVpWOTNjbUZ3Y0dWa09nb2dJQ0FnWW5sMFpTQWlkRzkwWVd3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JwYm5RZ01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdsdWRDQTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0t3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUcxbGRHaHZaQ0FpUTI5MWJuUmxaQ2gxYVc1ME5qUXBJZ29nSUNBZ1lubDBaU0FpZEc5MFlXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHSWdZWEJ3Y205MlpRb0tMeThnWjJWMFgzQmhhWElvS1NBdFBpQW9kV2x1ZERZMExIVnBiblEyTkNrNklISmxkSFZ5Ym5NZ0tIUnZkR0ZzTENCMGIzUmhiQ2tLWjJWMFgzQmhhWEk2Q2lBZ0lDQmllWFJsSURCNE1UVXhaamRqTnpVS0lDQWdJR0o1ZEdVZ0luUnZkR0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdVZ0luUnZkR0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdJZ1lYQndjbTkyWlFvS0x5OGdjMk5oYkdVb2NDd2dabUZqZEc5eUtTQXRQaUIxYVc1ME5qUTZJQ2h3TG1acGNuTjBJQ3NnY0M1elpXTnZibVFwSUNvZ1ptRmpkRzl5Q2k4dklHRnlaeUF4SUdseklIUm9aU0FvZFdsdWREWTBMSFZwYm5RMk5Da2djR0ZwY2l3Z1lYSm5JRElnYVhNZ2RHaGxJSE5qWVd4aGNpQm1ZV04wYjNJdUNuTmpZV3hsT2dvZ0lDQWdZbmwwWlNBd2VERTFNV1kzWXpjMUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JwYm5RZ01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdsdWRDQTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0t3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnS2dvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR0lnWVhCd2NtOTJaUW9LTHk4Z2FXNWpjaWh6ZEdWd0tTQXRQaUIxYVc1ME5qUTZJSFJ2ZEdGc0lDczlJSE4wWlhBN0lISmxkSFZ5Ym5NZ2RHOTBZV3dLYVc1amNqb0tJQ0FnSUdKNWRHVWdJblJ2ZEdGc0lnb2dJQ0FnWW5sMFpTQWlkRzkwWVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnS3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdVZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnWW5sMFpTQWlkRzkwWVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdJZ1lYQndjbTkyWlFvS0x5OGdkMmh2S0dGalkyOTFiblFwSUMwK0lHRmtaSEpsYzNNNklISmxkSFZ5Ym5NZ2RHaGxJSEpsWm1WeVpXNWpaV1FnWVdOamIzVnVkQ0FvY21WemIyeDJaV1FnZG1saElIUm9aUW92THlCMWFXNTBPQ0JwYm1SbGVDQjBhR1VnWTJ4cFpXNTBJR1Z1WTI5a1pXUWdhVzUwYnlCMGFHVWdRV05qYjNWdWRITWdabTl5WldsbmJpQmhjbkpoZVNrdUNuZG9iem9LSUNBZ0lHSjVkR1VnTUhneE5URm1OMk0zTlFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JpSUdGd2NISnZkbVVLQ2k4dklITjFiU2gxYVc1ME5qUmJYU2tnTFQ0Z2RXbHVkRFkwT2lCemRXMGdZU0JrZVc1aGJXbGpJR0Z5Y21GNUlDZ3lMV0o1ZEdVZ2JHVnVaM1JvSUhCeVpXWnBlQ3dnZEdobGJnb3ZMeUJpYVdjdFpXNWthV0Z1SUhWcGJuUTJOSE1wTGlCTWIyOXdjeUJ2ZG1WeUlIUm9aU0JqYjNWdWRDNEtjM1Z0T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdhVzUwSURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCcGJuUWdNQW9nSUNBZ2MzUnZjbVVnTVFvZ0lDQWdhVzUwSURBS0lDQWdJSE4wYjNKbElESUtjM1Z0WDJ4dmIzQTZDaUFnSUNCc2IyRmtJREVLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ6ZFcxZlpHOXVaUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2FXNTBJRElLSUNBZ0lHeHZZV1FnTVFvZ0lDQWdhVzUwSURnS0lDQWdJQ29LSUNBZ0lDc0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCc2IyRmtJRElLSUNBZ0lDc0tJQ0FnSUhOMGIzSmxJRElLSUNBZ0lHeHZZV1FnTVFvZ0lDQWdhVzUwSURFS0lDQWdJQ3NLSUNBZ0lITjBiM0psSURFS0lDQWdJR0lnYzNWdFgyeHZiM0FLYzNWdFgyUnZibVU2Q2lBZ0lDQmllWFJsSURCNE1UVXhaamRqTnpVS0lDQWdJR3h2WVdRZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdJZ1lYQndjbTkyWlFvS0x5OGdjM1Z0TXloMWFXNTBOalJiTTEwcElDMCtJSFZwYm5RMk5Eb2djM1Z0SUdFZ1ptbDRaV1FnTXkxbGJHVnRaVzUwSUhOMFlYUnBZeUJoY25KaGVTQW9NalFnWW5sMFpYTXNJRzV2Q2k4dklHeGxibWQwYUNCd2NtVm1hWGdwTGdwemRXMHpPZ29nSUNBZ1lubDBaU0F3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnBiblFnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR2x1ZENBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnS3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdhVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR0lnWVhCd2NtOTJaUW9LTHk4Z1ltOTRYM0IxZENodVlXMWxMQ0IyWVd4MVpTazZJSGR5YVhSbElIUm9aU0E0TFdKNWRHVWdkV2x1ZERZMElHQjJZV3gxWldBZ2FXNTBieUJpYjNnZ1lHNWhiV1ZnTGdvdkx5QmhjbWN4SUdseklHRnVJRUZDU1NCemRISnBibWNnS0RJdFlubDBaU0JzWlc1bmRHZ2djSEpsWm1sNElDc2dZbmwwWlhNcE95QnpkSEpwY0NCMGFHVWdjSEpsWm1sNElIUnZJR2RsZEFvdkx5QjBhR1VnY21GM0lHdGxlU0IwYUdVZ1kyeHBaVzUwSUdGMGRHRmphR1Z6SUdGeklHRWdZbTk0SUhKbFptVnlaVzVqWlM0Z1lYSm5NaUJwY3lCMGFHVWdPQzFpZVhSbElIVnBiblEyTkM0S1ltOTRYM0IxZERvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUdGd2NISnZkbVVLQ2k4dklHSnZlRjluWlhRb2JtRnRaU2tnTFQ0Z2RXbHVkRFkwT2lCeVpXRmtJR0p2ZUNCZ2JtRnRaV0FnWVc1a0lISmxkSFZ5YmlCcGRITWdPQ0JpZVhSbGN5QmhjeUIxYVc1ME5qUXVDbUp2ZUY5blpYUTZDaUFnSUNCaWVYUmxJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JpSUdGd2NISnZkbVVLQ2k4dklHUmxjRzl6YVhRb2NHRjVMQ0JsZUhCbFkzUmxaQ2s2SUhSb1pTQndjbVZqWldScGJtY2daM0p2ZFhBZ2RISmhibk5oWTNScGIyNGdiWFZ6ZENCaVpTQmhJSEJoZVcxbGJuUWdiMllLTHk4Z1lHVjRjR1ZqZEdWa1lDQnRhV055YjBGc1oyOXpJSFJ2SUhSb2FYTWdZWEJ3SjNNZ1lXTmpiM1Z1ZEM0Z1ZHaGxJSEJoZVNCemFYUnpJR0YwSUc5MWNpQm5jbTkxY0NCcGJtUmxlQW92THlCdGFXNTFjeUJ2Ym1VZ0tIUm9aU0JpZFdsc1pHVnlJSEJzWVdObGN5QjBjbUZ1YzJGamRHbHZiaUJoY21keklISnBaMmgwSUdKbFptOXlaU0IwYUdVZ1kyRnNiQ2t1Q21SbGNHOXphWFE2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwSURFS0lDQWdJQzBLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCc2IyRmtJREFLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQmhjSEJ5YjNabENnb3ZMeUJoWkdSZmNHRnBjaWh3S1NBdFBpQjFhVzUwTmpRNklIQXVabWx5YzNRZ0t5QndMbk5sWTI5dVpDd2dkMmhsY21VZ2NDQnBjeUJoYmlBcVlXNXZibmx0YjNWektpQkJRa2tLTHk4Z2RIVndiR1VnS0hWcGJuUTJOQ3gxYVc1ME5qUXBJT0tBbENCMGFHVWdNVFl0WW5sMFpTQnpkR0YwYVdNZ1pXNWpiMlJwYm1jZ2FXNGdZWEpuSURFdUlGUm9hWE1nYldseWNtOXljd292THlCZ2MzUnZjbVZnTENCaWRYUWdkR2hsSUdkbGJtVnlZWFJsWkNCamJHbGxiblFnZEdGclpYTWdZU0J3YkdGcGJpQlNkWE4wSUdBb2RUWTBMQ0IxTmpRcFlDQjBkWEJzWlFvdkx5QnlZWFJvWlhJZ2RHaGhiaUJoSUc1aGJXVmtJSE4wY25WamRDNEtZV1JrWDNCaGFYSTZDaUFnSUNCaWVYUmxJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHbHVkQ0F3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdhVzUwSURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdZaUJoY0hCeWIzWmxDZ292THlCd2NtbGpaVjl5WVhjb2NDa2dMVDRnZFdsdWREWTBPaUJ5WlhSMWNtNXpJSFJvWlNCeVlYY3NJSFZ1YzJOaGJHVmtJR2x1ZEdWblpYSWdiMllnWVNCMVptbDRaV1EyTkhneUxnb3ZMeUJCSUhWbWFYaGxaRFkwZURJZ1pXNWpiMlJsY3lCdmJpQjBhR1VnZDJseVpTQmxlR0ZqZEd4NUlHRnpJR0VnZFdsdWREWTBMQ0J6YnlCaGNtY2dNU0JwY3lCMGFHVWdPQzFpZVhSbENpOHZJR0pwWnkxbGJtUnBZVzRnYVc1MFpXZGxjaUIwYUdVZ1lGVm1hWGhsWkdBZ1kyeHBaVzUwSUhaaGJIVmxJSGR5WVhCd1pXUWc0b0NVSUhKbGRIVnliaUJwZENCMlpYSmlZWFJwYlM0S2NISnBZMlZmY21GM09nb2dJQ0FnWW5sMFpTQXdlREUxTVdZM1l6YzFDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCcGJuUWdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQmlJR0Z3Y0hKdmRtVUtDbUZ3Y0hKdmRtVTZDaUFnSUNCcGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJRGdLQ2k4dklGWmhkV3gwSUdOc1pXRnlMWE4wWVhSbElIQnliMmR5WVcwNklHRnNkMkY1Y3lCaGNIQnliM1psTGlCVWFHVWdRVlpOSUhKbFkyeGhhVzF6SUhSb1pTQmpZV3hzWlhJbmN3b3ZMeUJzYjJOaGJDQWljMlZsYmlJZ2MyeHZkQ0J2YmlCamJHVmhjaTF6ZEdGMFpTQmhkWFJ2YldGMGFXTmhiR3g1TENCemJ5QnViM1JvYVc1bklIUnZJR1J2SUdobGNtVXVDbWx1ZENBeENuSmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJDb3VudGVkIiwiZGVzYyI6IkVtaXR0ZWQgd2hlbiB0aGUgY291bnRlciBjaGFuZ2VzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
