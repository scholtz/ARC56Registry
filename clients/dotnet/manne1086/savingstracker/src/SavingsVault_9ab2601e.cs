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

namespace Arc56.Generated.manne1086.savingstracker.SavingsVault_9ab2601e
{


    //
    // Non-custodial savings vault with streaks, XP, levels, and milestones.
    //
    public class SavingsVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SavingsVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStatsReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetStatsReturn);
                }
                public bool Equals(GetStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStatsReturn left, GetStatsReturn right)
                {
                    return EqualityComparer<GetStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStatsReturn left, GetStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetGlobalStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetGlobalStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetGlobalStatsReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetGlobalStatsReturn);
                }
                public bool Equals(GetGlobalStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetGlobalStatsReturn left, GetGlobalStatsReturn right)
                {
                    return EqualityComparer<GetGlobalStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetGlobalStatsReturn left, GetGlobalStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetMilestoneThresholdsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetMilestoneThresholdsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetMilestoneThresholdsReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetMilestoneThresholdsReturn);
                }
                public bool Equals(GetMilestoneThresholdsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetMilestoneThresholdsReturn left, GetMilestoneThresholdsReturn right)
                {
                    return EqualityComparer<GetMilestoneThresholdsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetMilestoneThresholdsReturn left, GetMilestoneThresholdsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Deposit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 54, 37, 228, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task Withdraw(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 241, 221, 255 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetSavings(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 1, 164, 180 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetSavings_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 1, 164, 180 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetStatsReturn> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 6, 41, 236 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 6, 41, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetGlobalStatsReturn> GetGlobalStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 254, 229, 58 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetGlobalStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetGlobalStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 254, 229, 58 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetMilestoneThresholdsReturn> GetMilestoneThresholds(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 125, 59, 152 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetMilestoneThresholdsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMilestoneThresholds_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 125, 59, 152 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2F2aW5nc1ZhdWx0IiwiZGVzYyI6Ik5vbi1jdXN0b2RpYWwgc2F2aW5ncyB2YXVsdCB3aXRoIHN0cmVha3MsIFhQLCBsZXZlbHMsIGFuZCBtaWxlc3RvbmVzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRTdGF0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0R2xvYmFsU3RhdHNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0TWlsZXN0b25lVGhyZXNob2xkc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3NhdmluZ3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zdGF0cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0U3RhdHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9nbG9iYWxfc3RhdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0R2xvYmFsU3RhdHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9taWxlc3RvbmVfdGhyZXNob2xkcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRNaWxlc3RvbmVUaHJlc2hvbGRzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NywiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjo3LCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiQ2xvc2VPdXQiLCJPcHRJbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU0Niw5NDZdLCJlcnJvck1lc3NhZ2UiOiJBY2NvdW50IG11c3Qgb3B0IGluIGZpcnN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTcxXSwiZXJyb3JNZXNzYWdlIjoiRGVwb3NpdCBhbW91bnQgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1NV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYyXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IHRhcmdldCB0aGUgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU0XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDldLCJlcnJvck1lc3NhZ2UiOiJXaXRoZHJhdyBhbW91bnQgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVwb3NpdF9jb3VudCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmhpZ2hlc3RfbWlsZXN0b25lIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubGFzdF9kZXBvc2l0X3JvdW5kIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyMSwxMTc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taWxlc3RvbmVfMTAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzg1LDExODRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbGVzdG9uZV8xMDAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA2LDExOTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbGVzdG9uZV8xMDAwIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMywxMTc5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taWxlc3RvbmVfNTAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY4LDExODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbGVzdG9uZV81MDAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTk0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdHJlYWtfZGF5cyBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTUsNzM0LDEwMTMsMTE1M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZGVwb3NpdGVkX2dsb2JhbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjQsNDMxLDQ5NiwxMTU3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF91c2VycyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnhwX3BvaW50cyBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzZdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTlNBMENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKMGIzUmhiRjlrWlhCdmMybDBaV1JmWjJ4dlltRnNJaUFpZEc5MFlXeGZjMkYyWldRaUlDSjBiM1JoYkY5MWMyVnljeUlnSW1SbGNHOXphWFJmWTI5MWJuUWlJQ0pvYVdkb1pYTjBYMjFwYkdWemRHOXVaU0lnSW5OMGNtVmhhMTlrWVhseklpQWllSEJmY0c5cGJuUnpJaUF3ZURFMU1XWTNZemMxSUNKdGFXeGxjM1J2Ym1WZk1UQWlJQ0p0YVd4bGMzUnZibVZmTlRBaUlDSnRhV3hsYzNSdmJtVmZNVEF3SWlBaWJXbHNaWE4wYjI1bFh6VXdNQ0lnSW0xcGJHVnpkRzl1WlY4eE1EQXdJaUFpYkdGemRGOWtaWEJ2YzJsMFgzSnZkVzVrSWlBaWJHVjJaV3dpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUd0bGVUMGliV2xzWlhOMGIyNWxYekV3SWl3S0lDQWdJR0o1ZEdWaklEZ2dMeThnSW0xcGJHVnpkRzl1WlY4eE1DSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRvek5Rb2dJQ0FnTHk4Z1ZVbHVkRFkwS0RFd1h6QXdNRjh3TURBcExBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qTTBMVE00Q2lBZ0lDQXZMeUJ6Wld4bUxtMXBiR1Z6ZEc5dVpWOHhNQ0E5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DZ3hNRjh3TURCZk1EQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCclpYazlJbTFwYkdWemRHOXVaVjh4TUNJc0NpQWdJQ0F2THlBZ0lDQWdaR1Z6WTNKcGNIUnBiMjQ5SWxSb2NtVnphRzlzWkNCbWIzSWdNVEFnUVV4SFR5QnRhV3hsYzNSdmJtVWlMQW9nSUNBZ0x5OGdLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdhMlY1UFNKdGFXeGxjM1J2Ym1WZk5UQWlMQW9nSUNBZ1lubDBaV01nT1NBdkx5QWliV2xzWlhOMGIyNWxYelV3SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJWU1c1ME5qUW9OVEJmTURBd1h6QXdNQ2tzQ2lBZ0lDQndkWE5vYVc1MElEVXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TXprdE5ETUtJQ0FnSUM4dklITmxiR1l1Yldsc1pYTjBiMjVsWHpVd0lEMGdSMnh2WW1Gc1UzUmhkR1VvQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0RVd1h6QXdNRjh3TURBcExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQwaWJXbHNaWE4wYjI1bFh6VXdJaXdLSUNBZ0lDOHZJQ0FnSUNCa1pYTmpjbWx3ZEdsdmJqMGlWR2h5WlhOb2IyeGtJR1p2Y2lBMU1DQkJURWRQSUcxcGJHVnpkRzl1WlNJc0NpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCclpYazlJbTFwYkdWemRHOXVaVjh4TURBaUxBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0ltMXBiR1Z6ZEc5dVpWOHhNREFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJRlZKYm5RMk5DZ3hNREJmTURBd1h6QXdNQ2tzQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pRMExUUTRDaUFnSUNBdkx5QnpaV3htTG0xcGJHVnpkRzl1WlY4eE1EQWdQU0JIYkc5aVlXeFRkR0YwWlNnS0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb01UQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUd0bGVUMGliV2xzWlhOMGIyNWxYekV3TUNJc0NpQWdJQ0F2THlBZ0lDQWdaR1Z6WTNKcGNIUnBiMjQ5SWxSb2NtVnphRzlzWkNCbWIzSWdNVEF3SUVGTVIwOGdiV2xzWlhOMGIyNWxJaXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR3RsZVQwaWJXbHNaWE4wYjI1bFh6VXdNQ0lzQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpYldsc1pYTjBiMjVsWHpVd01DSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z1ZVbHVkRFkwS0RVd01GOHdNREJmTURBd0tTd0tJQ0FnSUhCMWMyaHBiblFnTlRBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZORGt0TlRNS0lDQWdJQzh2SUhObGJHWXViV2xzWlhOMGIyNWxYelV3TUNBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2cxTURCZk1EQXdYekF3TUNrc0NpQWdJQ0F2THlBZ0lDQWdhMlY1UFNKdGFXeGxjM1J2Ym1WZk5UQXdJaXdLSUNBZ0lDOHZJQ0FnSUNCa1pYTmpjbWx3ZEdsdmJqMGlWR2h5WlhOb2IyeGtJR1p2Y2lBMU1EQWdRVXhIVHlCdGFXeGxjM1J2Ym1VaUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z2EyVjVQU0p0YVd4bGMzUnZibVZmTVRBd01DSXNDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWliV2xzWlhOMGIyNWxYekV3TURBaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUZWSmJuUTJOQ2d4WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPalUwTFRVNENpQWdJQ0F2THlCelpXeG1MbTFwYkdWemRHOXVaVjh4TURBd0lEMGdSMnh2WW1Gc1UzUmhkR1VvQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0RGZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUd0bGVUMGliV2xzWlhOMGIyNWxYekV3TURBaUxBb2dJQ0FnTHk4Z0lDQWdJR1JsYzJOeWFYQjBhVzl1UFNKVWFISmxjMmh2YkdRZ1ptOXlJREV3TURBZ1FVeEhUeUJ0YVd4bGMzUnZibVVpTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnYTJWNVBTSjBiM1JoYkY5a1pYQnZjMmwwWldSZloyeHZZbUZzSWl3S0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMlJsY0c5emFYUmxaRjluYkc5aVlXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklGVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TlRrdE5qTUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRHVmtYMmRzYjJKaGJDQTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOUluUnZkR0ZzWDJSbGNHOXphWFJsWkY5bmJHOWlZV3dpTEFvZ0lDQWdMeThnSUNBZ0lHUmxjMk55YVhCMGFXOXVQU0pUZFcwZ2IyWWdZV3hzSUhWelpYSWdaR1Z3YjNOcGRITWlMQW9nSUNBZ0x5OGdLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdhMlY1UFNKMGIzUmhiRjkxYzJWeWN5SXNDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5MWMyVnljeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRvMk5DMDJPQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjkxYzJWeWN5QTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOUluUnZkR0ZzWDNWelpYSnpJaXdLSUNBZ0lDOHZJQ0FnSUNCa1pYTmpjbWx3ZEdsdmJqMGlRMjkxYm5RZ2IyWWdiM0IwWldRdGFXNGdkWE5sY25NaUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJqYkdGemN5QlRZWFpwYm1kelZtRjFiSFFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhOUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNell5TldVMFpXSWdNSGd5TVdZeFpHUm1aaUF3ZUdZNU1ERmhOR0kwSURCNE5tRXdOakk1WldNZ01IaGxNMlpsWlRVellTQXdlREppTjJRellqazRJQzh2SUcxbGRHaHZaQ0FpWkdWd2IzTnBkQ2h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZDJsMGFHUnlZWGNvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjl6WVhacGJtZHpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5emRHRjBjeWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFgyZHNiMkpoYkY5emRHRjBjeWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmJXbHNaWE4wYjI1bFgzUm9jbVZ6YUc5c1pITW9LU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdSbGNHOXphWFFnZDJsMGFHUnlZWGNnWjJWMFgzTmhkbWx1WjNNZ1oyVjBYM04wWVhSeklHZGxkRjluYkc5aVlXeGZjM1JoZEhNZ1oyVjBYMjFwYkdWemRHOXVaVjkwYUhKbGMyaHZiR1J6Q2lBZ0lDQmxjbklLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCamJHRnpjeUJUWVhacGJtZHpWbUYxYkhRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSE4zYVhSamFDQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREUySUcxaGFXNWZiM0IwWDJsdVFERTNJRzFoYVc1ZlkyeHZjMlZmYjNWMFFERTRDaUFnSUNCbGNuSUtDbTFoYVc1ZlkyeHZjMlZmYjNWMFFERTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qSTBNZ29nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVEyeHZjMlZQZFhRaVhTd2dZM0psWVhSbFBTSmthWE5oYkd4dmR5SXBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TWpRMENpQWdJQ0F2THlCaFkyTnZkVzUwSUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TkRVS0lDQWdJQzh2SUhSdmRHRnNYM05oZG1Wa0lEMGdjMlZzWmk1MGIzUmhiRjl6WVhabFpDNW5aWFFvWVdOamIzVnVkQ3dnVlVsdWREWTBLREFwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gzTmhkbVZrSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3lORGNLSUNBZ0lDOHZJR2xtSUhSdmRHRnNYM05oZG1Wa0lENGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNalE0TFRJMU1nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFdGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhSdmRHRnNYM05oZG1Wa0xBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVOVlpSkRiRzl6YVc1bklHRmpZMjkxYm5RZ1puSnZiU0JUWVhacGJtZHpWbUYxYkhRaUxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakkxTVFvZ0lDQWdMeThnYm05MFpUMWlJa05zYjNOcGJtY2dZV05qYjNWdWRDQm1jbTl0SUZOaGRtbHVaM05XWVhWc2RDSXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBNelpqTm1ZM016WTVObVUyTnpJd05qRTJNell6Tm1ZM05UWmxOelF5TURZMk56STJaalprTWpBMU16WXhOelkyT1RabE5qYzNNelUyTmpFM05UWmpOelFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUbTkwWlFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveU5EZ0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pJME9DMHlOVElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMWhZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMTBiM1JoYkY5ellYWmxaQ3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxQV0lpUTJ4dmMybHVaeUJoWTJOdmRXNTBJR1p5YjIwZ1UyRjJhVzVuYzFaaGRXeDBJaXdLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1qVTBDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaRjluYkc5aVlXd3VkbUZzZFdVZ0xTQjBiM1JoYkY5ellYWmxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzWDJSbGNHOXphWFJsWkY5bmJHOWlZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWkdWd2IzTnBkR1ZrWDJkc2IySmhiQ0JsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TlRNS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZlpHVndiM05wZEdWa1gyZHNiMkpoYkM1MllXeDFaU0E5SUNnS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMlJsY0c5emFYUmxaRjluYkc5aVlXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1qVXpMVEkxTlFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwWldSZloyeHZZbUZzTG5aaGJIVmxJRDBnS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRHVmtYMmRzYjJKaGJDNTJZV3gxWlNBdElIUnZkR0ZzWDNOaGRtVmtDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pJMU53b2dJQ0FnTHk4Z2FXWWdjMlZzWmk1MGIzUmhiRjkxYzJWeWN5NTJZV3gxWlNBK0lGVkpiblEyTkNnd0tUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjkxYzJWeWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOTFjMlZ5Y3lCbGVHbHpkSE1LSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakkxT0FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5MWMyVnljeTUyWVd4MVpTQTlJSE5sYkdZdWRHOTBZV3hmZFhObGNuTXVkbUZzZFdVZ0xTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjkxYzJWeWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOTFjMlZ5Y3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjkxYzJWeWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TWpZd0NpQWdJQ0F2THlCc2IyY29Ja0ZqWTI5MWJuUWdZMnh2YzJWa0lpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVFXTmpiM1Z1ZENCamJHOXpaV1FpQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3lORElLSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrTnNiM05sVDNWMElsMHNJR055WldGMFpUMGlaR2x6WVd4c2IzY2lLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXZjSFJmYVc1QU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UUXdDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkTENCamNtVmhkR1U5SW1ScGMyRnNiRzkzSWlrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJR0ZqWTI5MWJuUWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UUTBDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM05oZG1Wa1cyRmpZMjkxYm5SZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDNOaGRtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE5EVUtJQ0FnSUM4dklITmxiR1l1WkdWd2IzTnBkRjlqYjNWdWRGdGhZMk52ZFc1MFhTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmtaWEJ2YzJsMFgyTnZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hORFlLSUNBZ0lDOHZJSE5sYkdZdWFHbG5hR1Z6ZEY5dGFXeGxjM1J2Ym1WYllXTmpiM1Z1ZEYwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWFHbG5hR1Z6ZEY5dGFXeGxjM1J2Ym1VaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnYzJWc1ppNXNZWE4wWDJSbGNHOXphWFJmY205MWJtUmJZV05qYjNWdWRGMGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbXhoYzNSZlpHVndiM05wZEY5eWIzVnVaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UUTRDaUFnSUNBdkx5QnpaV3htTG5OMGNtVmhhMTlrWVhselcyRmpZMjkxYm5SZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luTjBjbVZoYTE5a1lYbHpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklITmxiR1l1ZUhCZmNHOXBiblJ6VzJGalkyOTFiblJkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5od1gzQnZhVzUwY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVFV3Q2lBZ0lDQXZMeUJ6Wld4bUxteGxkbVZzVzJGalkyOTFiblJkSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaWJHVjJaV3dpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRTFNZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjkxYzJWeWN5NTJZV3gxWlNBOUlITmxiR1l1ZEc5MFlXeGZkWE5sY25NdWRtRnNkV1VnS3lCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOTFjMlZ5Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5MWMyVnljeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOTFjMlZ5Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCc2IyY29JbFZ6WlhJZ2IzQjBaV1FnYVc0aUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVmMyVnlJRzl3ZEdWa0lHbHVJZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UUXdDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKUGNIUkpiaUpkTENCamNtVmhkR1U5SW1ScGMyRnNiRzkzSWlrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFk2Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkMkZzYkdWMExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVrWlhCdmMybDBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWd2IzTnBkRG9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UVTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRTFOd29nSUNBZ0x5OGdZV05qYjNWdWRDQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOTBiM1JoYkY5ellYWmxaQ3dnWlhocGMzUnpJRDBnYzJWc1ppNTBiM1JoYkY5ellYWmxaQzV0WVhsaVpTaGhZMk52ZFc1MEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZjMkYyWldRaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UQTVDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6TENBaVFXTmpiM1Z1ZENCdGRYTjBJRzl3ZENCcGJpQm1hWEp6ZENJS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWTJOdmRXNTBJRzExYzNRZ2IzQjBJR2x1SUdacGNuTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UWXdDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1elpXNWtaWElnUFQwZ1lXTmpiM1Z1ZEN3Z0lsQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxcGMyMWhkR05vSWdvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94TmpJS0lDQWdJQzh2SUhCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94TmpFdE1UWXpDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ0x5OGdLU3dnSWxCaGVXMWxiblFnYlhWemRDQjBZWEpuWlhRZ2RHaGxJR0Z3Y0NJS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ2RHRnlaMlYwSUhSb1pTQmhjSEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExtRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJa1JsY0c5emFYUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaWEJ2YzJsMElHRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVFkzQ2lBZ0lDQXZMeUJrWlhCdmMybDBYMk52ZFc1MElEMGdjMlZzWmk1a1pYQnZjMmwwWDJOdmRXNTBXMkZqWTI5MWJuUmRDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltUmxjRzl6YVhSZlkyOTFiblFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1a1pYQnZjMmwwWDJOdmRXNTBJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRTJPQW9nSUNBZ0x5OGdiR0Z6ZEY5eWIzVnVaQ0E5SUhObGJHWXViR0Z6ZEY5a1pYQnZjMmwwWDNKdmRXNWtXMkZqWTI5MWJuUmRDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSnNZWE4wWDJSbGNHOXphWFJmY205MWJtUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzWVhOMFgyUmxjRzl6YVhSZmNtOTFibVFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVFk1Q2lBZ0lDQXZMeUJ6ZEhKbFlXdGZaR0Y1Y3lBOUlITmxiR1l1YzNSeVpXRnJYMlJoZVhOYllXTmpiM1Z1ZEYwS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYzNSeVpXRnJYMlJoZVhNaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEhKbFlXdGZaR0Y1Y3lCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94TnpBS0lDQWdJQzh2SUhod1gzQnZhVzUwY3lBOUlITmxiR1l1ZUhCZmNHOXBiblJ6VzJGalkyOTFiblJkQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbmh3WDNCdmFXNTBjeUlLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlEWUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuaHdYM0J2YVc1MGN5QmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE56RUtJQ0FnSUM4dklHaHBaMmhsYzNSZmJXbHNaWE4wYjI1bElEMGdjMlZzWmk1b2FXZG9aWE4wWDIxcGJHVnpkRzl1WlZ0aFkyTnZkVzUwWFFvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pvYVdkb1pYTjBYMjFwYkdWemRHOXVaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlEWUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtaHBaMmhsYzNSZmJXbHNaWE4wYjI1bElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pFM013b2dJQ0FnTHk4Z2JtVjNYM1J2ZEdGc1gzTmhkbVZrSUQwZ2RHOTBZV3hmYzJGMlpXUWdLeUJ3WVhsdFpXNTBMbUZ0YjNWdWRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pFM05Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXpZWFpsWkZ0aFkyTnZkVzUwWFNBOUlHNWxkMTkwYjNSaGJGOXpZWFpsWkFvZ0lDQWdaR2xuSURNS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYM05oZG1Wa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVGMxQ2lBZ0lDQXZMeUJ6Wld4bUxtUmxjRzl6YVhSZlkyOTFiblJiWVdOamIzVnVkRjBnUFNCa1pYQnZjMmwwWDJOdmRXNTBJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltUmxjRzl6YVhSZlkyOTFiblFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklITmxiR1l1YkdGemRGOWtaWEJ2YzJsMFgzSnZkVzVrVzJGalkyOTFiblJkSUQwZ1IyeHZZbUZzTG5KdmRXNWtDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW14aGMzUmZaR1Z3YjNOcGRGOXliM1Z1WkNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRTNPQW9nSUNBZ0x5OGdjbTkxYm1SelgzTnBibU5sWDJ4aGMzUWdQU0JIYkc5aVlXd3VjbTkxYm1RZ0xTQnNZWE4wWDNKdmRXNWtDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRjNUNpQWdJQ0F2THlCcFppQnNZWE4wWDNKdmRXNWtJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR0p1ZWlCa1pYQnZjMmwwWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRnd0NpQWdJQ0F2THlCdVpYZGZjM1J5WldGcklEMGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0taR1Z3YjNOcGRGOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pFNE53b2dJQ0FnTHk4Z2MyVnNaaTV6ZEhKbFlXdGZaR0Y1YzF0aFkyTnZkVzUwWFNBOUlHNWxkMTl6ZEhKbFlXc0tJQ0FnSUdScFp5QTNDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luTjBjbVZoYTE5a1lYbHpJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRnNUNpQWdJQ0F2THlCaGJHZHZYMkZ0YjNWdWRDQTlJSEJoZVcxbGJuUXVZVzF2ZFc1MElDOHZJRTFKUTFKUFgwRk1SMDhLSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hPVEFLSUNBZ0lDOHZJSGh3WDJkaGFXNWxaQ0E5SUdGc1oyOWZZVzF2ZFc1MElDb2dWVWx1ZERZMEtERXdLUW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnS2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakU1TVFvZ0lDQWdMeThnYm1WM1gzaHdJRDBnZUhCZmNHOXBiblJ6SUNzZ2VIQmZaMkZwYm1Wa0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRreUNpQWdJQ0F2THlCelpXeG1Mbmh3WDNCdmFXNTBjMXRoWTJOdmRXNTBYU0E5SUc1bGQxOTRjQW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV01nTmlBdkx5QWllSEJmY0c5cGJuUnpJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hNVFFLSUNBZ0lDOHZJR2xtSUhod0lEd2dWVWx1ZERZMEtEVXdNQ2s2Q2lBZ0lDQndkWE5vYVc1MElEVXdNQW9nSUNBZ1BBb2dJQ0FnWW5vZ1pHVndiM05wZEY5aFpuUmxjbDlwWmw5bGJITmxRREUxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVEUxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0taR1Z3YjNOcGRGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WVhacGJtZHpYM2RoYkd4bGRDNWpiMjUwY21GamRDNVRZWFpwYm1kelZtRjFiSFF1WDJOaGJHTjFiR0YwWlY5c1pYWmxiRUF5TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94T1RNS0lDQWdJQzh2SUhObGJHWXViR1YyWld4YllXTmpiM1Z1ZEYwZ1BTQnpaV3htTGw5allXeGpkV3hoZEdWZmJHVjJaV3dvYm1WM1gzaHdLUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pzWlhabGJDSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakV5T0FvZ0lDQWdMeThnYVdZZ2RHOTBZV3hmYzJGMlpXUWdQajBnYzJWc1ppNXRhV3hsYzNSdmJtVmZNVEF3TUM1MllXeDFaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWliV2xzWlhOMGIyNWxYekV3TURBaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV2xzWlhOMGIyNWxYekV3TURBZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQRDBLSUNBZ0lHSjZJR1JsY0c5emFYUmZZV1owWlhKZmFXWmZaV3h6WlVBeU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2cxS1FvZ0lDQWdhVzUwWTE4eUlDOHZJRFVLSUNBZ0lHSjFjbmtnT1FvS1pHVndiM05wZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpZWFpwYm1kelgzZGhiR3hsZEM1amIyNTBjbUZqZEM1VFlYWnBibWR6Vm1GMWJIUXVYMk5vWldOclgyMXBiR1Z6ZEc5dVpVQXpOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hPVFlLSUNBZ0lDOHZJR2xtSUc1bGQxOXRhV3hsYzNSdmJtVWdQaUJvYVdkb1pYTjBYMjFwYkdWemRHOXVaVG9LSUNBZ0lHUnBaeUE0Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQZ29nSUNBZ1lub2daR1Z3YjNOcGRGOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRrM0NpQWdJQ0F2THlCelpXeG1MbWhwWjJobGMzUmZiV2xzWlhOMGIyNWxXMkZqWTI5MWJuUmRJRDBnYm1WM1gyMXBiR1Z6ZEc5dVpRb2dJQ0FnWkdsbklEWUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltaHBaMmhsYzNSZmJXbHNaWE4wYjI1bElnb2dJQ0FnWkdsbklERXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDZ3BrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1qQXdDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaRjluYkc5aVlXd3VkbUZzZFdVZ0t5QndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyUmxjRzl6YVhSbFpGOW5iRzlpWVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZlpHVndiM05wZEdWa1gyZHNiMkpoYkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1UazVDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaRjluYkc5aVlXd3VkbUZzZFdVZ1BTQW9DaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5a1pYQnZjMmwwWldSZloyeHZZbUZzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakU1T1MweU1ERUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRHVmtYMmRzYjJKaGJDNTJZV3gxWlNBOUlDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxuUnZkR0ZzWDJSbGNHOXphWFJsWkY5bmJHOWlZV3d1ZG1Gc2RXVWdLeUJ3WVhsdFpXNTBMbUZ0YjNWdWRBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveU1ESUtJQ0FnSUM4dklHeHZaeWdpUkdWd2IzTnBkQ0J6ZFdOalpYTnpablZzSWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUkdWd2IzTnBkQ0J6ZFdOalpYTnpablZzSWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVFUxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbVJsY0c5emFYUmZZV1owWlhKZmFXWmZaV3h6WlVBeU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE16QUtJQ0FnSUM4dklHbG1JSFJ2ZEdGc1gzTmhkbVZrSUQ0OUlITmxiR1l1Yldsc1pYTjBiMjVsWHpVd01DNTJZV3gxWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpYldsc1pYTjBiMjVsWHpVd01DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVd4bGMzUnZibVZmTlRBd0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURJS0lDQWdJRHc5Q2lBZ0lDQmllaUJrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU1qa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE16RUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTkNrS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQmlkWEo1SURrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94T1RVS0lDQWdJQzh2SUc1bGQxOXRhV3hsYzNSdmJtVWdQU0J6Wld4bUxsOWphR1ZqYTE5dGFXeGxjM1J2Ym1Vb2JtVjNYM1J2ZEdGc1gzTmhkbVZrS1FvZ0lDQWdZaUJrWlhCdmMybDBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5OaGRtbHVaM05mZDJGc2JHVjBMbU52Ym5SeVlXTjBMbE5oZG1sdVozTldZWFZzZEM1ZlkyaGxZMnRmYldsc1pYTjBiMjVsUURNMkNncGtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWprNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRNeUNpQWdJQ0F2THlCcFppQjBiM1JoYkY5ellYWmxaQ0ErUFNCelpXeG1MbTFwYkdWemRHOXVaVjh4TURBdWRtRnNkV1U2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbTFwYkdWemRHOXVaVjh4TURBaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV2xzWlhOMGIyNWxYekV3TUNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQThQUW9nSUNBZ1lub2daR1Z3YjNOcGRGOWhablJsY2w5cFpsOWxiSE5sUURNeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLRE1wQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdKMWNua2dPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRTVOUW9nSUNBZ0x5OGdibVYzWDIxcGJHVnpkRzl1WlNBOUlITmxiR1l1WDJOb1pXTnJYMjFwYkdWemRHOXVaU2h1WlhkZmRHOTBZV3hmYzJGMlpXUXBDaUFnSUNCaUlHUmxjRzl6YVhSZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVjMkYyYVc1bmMxOTNZV3hzWlhRdVkyOXVkSEpoWTNRdVUyRjJhVzVuYzFaaGRXeDBMbDlqYUdWamExOXRhV3hsYzNSdmJtVkFNellLQ21SbGNHOXphWFJmWVdaMFpYSmZhV1pmWld4elpVQXpNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hNelFLSUNBZ0lDOHZJR2xtSUhSdmRHRnNYM05oZG1Wa0lENDlJSE5sYkdZdWJXbHNaWE4wYjI1bFh6VXdMblpoYkhWbE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW0xcGJHVnpkRzl1WlY4MU1DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVd4bGMzUnZibVZmTlRBZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQRDBLSUNBZ0lHSjZJR1JsY0c5emFYUmZZV1owWlhKZmFXWmZaV3h6WlVBek13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d5S1FvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCaWRYSjVJRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hPVFVLSUNBZ0lDOHZJRzVsZDE5dGFXeGxjM1J2Ym1VZ1BTQnpaV3htTGw5amFHVmphMTl0YVd4bGMzUnZibVVvYm1WM1gzUnZkR0ZzWDNOaGRtVmtLUW9nSUNBZ1lpQmtaWEJ2YzJsMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkMkZzYkdWMExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVmWTJobFkydGZiV2xzWlhOMGIyNWxRRE0yQ2dwa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFNek02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVE0yQ2lBZ0lDQXZMeUJwWmlCMGIzUmhiRjl6WVhabFpDQStQU0J6Wld4bUxtMXBiR1Z6ZEc5dVpWOHhNQzUyWVd4MVpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKdGFXeGxjM1J2Ym1WZk1UQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Yldsc1pYTjBiMjVsWHpFd0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURJS0lDQWdJRHc5Q2lBZ0lDQmllaUJrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU16VUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmlkWEo1SURrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94T1RVS0lDQWdJQzh2SUc1bGQxOXRhV3hsYzNSdmJtVWdQU0J6Wld4bUxsOWphR1ZqYTE5dGFXeGxjM1J2Ym1Vb2JtVjNYM1J2ZEdGc1gzTmhkbVZrS1FvZ0lDQWdZaUJrWlhCdmMybDBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5OaGRtbHVaM05mZDJGc2JHVjBMbU52Ym5SeVlXTjBMbE5oZG1sdVozTldZWFZzZEM1ZlkyaGxZMnRmYldsc1pYTjBiMjVsUURNMkNncGtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0E1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVGsxQ2lBZ0lDQXZMeUJ1WlhkZmJXbHNaWE4wYjI1bElEMGdjMlZzWmk1ZlkyaGxZMnRmYldsc1pYTjBiMjVsS0c1bGQxOTBiM1JoYkY5ellYWmxaQ2tLSUNBZ0lHSWdaR1Z3YjNOcGRGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTV6WVhacGJtZHpYM2RoYkd4bGRDNWpiMjUwY21GamRDNVRZWFpwYm1kelZtRjFiSFF1WDJOb1pXTnJYMjFwYkdWemRHOXVaVUF6TmdvS1pHVndiM05wZEY5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnYVdZZ2VIQWdQQ0JWU1c1ME5qUW9NVjgxTURBcE9nb2dJQ0FnWkdsbklEY0tJQ0FnSUhCMWMyaHBiblFnTVRVd01Bb2dJQ0FnUEFvZ0lDQWdZbm9nWkdWd2IzTnBkRjloWm5SbGNsOXBabDlsYkhObFFERTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1URTNDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RJcENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3hPVE1LSUNBZ0lDOHZJSE5sYkdZdWJHVjJaV3hiWVdOamIzVnVkRjBnUFNCelpXeG1MbDlqWVd4amRXeGhkR1ZmYkdWMlpXd29ibVYzWDNod0tRb2dJQ0FnWWlCa1pYQnZjMmwwWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxuTmhkbWx1WjNOZmQyRnNiR1YwTG1OdmJuUnlZV04wTGxOaGRtbHVaM05XWVhWc2RDNWZZMkZzWTNWc1lYUmxYMnhsZG1Wc1FESTBDZ3BrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1URTRDaUFnSUNBdkx5QnBaaUI0Y0NBOElGVkpiblEyTkNnelh6QXdNQ2s2Q2lBZ0lDQmthV2NnTndvZ0lDQWdjSFZ6YUdsdWRDQXpNREF3Q2lBZ0lDQThDaUFnSUNCaWVpQmtaWEJ2YzJsMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NeWtLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pFNU13b2dJQ0FnTHk4Z2MyVnNaaTVzWlhabGJGdGhZMk52ZFc1MFhTQTlJSE5sYkdZdVgyTmhiR04xYkdGMFpWOXNaWFpsYkNodVpYZGZlSEFwQ2lBZ0lDQmlJR1JsY0c5emFYUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11YzJGMmFXNW5jMTkzWVd4c1pYUXVZMjl1ZEhKaFkzUXVVMkYyYVc1bmMxWmhkV3gwTGw5allXeGpkV3hoZEdWZmJHVjJaV3hBTWpRS0NtUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF4T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUdsbUlIaHdJRHdnVlVsdWREWTBLRFZmTURBd0tUb0tJQ0FnSUdScFp5QTNDaUFnSUNCd2RYTm9hVzUwSURVd01EQUtJQ0FnSUR3S0lDQWdJR0o2SUdSbGNHOXphWFJmWVdaMFpYSmZhV1pmWld4elpVQXlNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRXlNUW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnMEtRb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94T1RNS0lDQWdJQzh2SUhObGJHWXViR1YyWld4YllXTmpiM1Z1ZEYwZ1BTQnpaV3htTGw5allXeGpkV3hoZEdWZmJHVjJaV3dvYm1WM1gzaHdLUW9nSUNBZ1lpQmtaWEJ2YzJsMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkMkZzYkdWMExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVmWTJGc1kzVnNZWFJsWDJ4bGRtVnNRREkwQ2dwa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFNakU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVEl5Q2lBZ0lDQXZMeUJwWmlCNGNDQThJRlZKYm5RMk5DZzRYekF3TUNrNkNpQWdJQ0JrYVdjZ053b2dJQ0FnY0hWemFHbHVkQ0E0TURBd0NpQWdJQ0E4Q2lBZ0lDQmllaUJrWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU1qTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVGt6Q2lBZ0lDQXZMeUJ6Wld4bUxteGxkbVZzVzJGalkyOTFiblJkSUQwZ2MyVnNaaTVmWTJGc1kzVnNZWFJsWDJ4bGRtVnNLRzVsZDE5NGNDa0tJQ0FnSUdJZ1pHVndiM05wZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpZWFpwYm1kelgzZGhiR3hsZEM1amIyNTBjbUZqZEM1VFlYWnBibWR6Vm1GMWJIUXVYMk5oYkdOMWJHRjBaVjlzWlhabGJFQXlOQW9LWkdWd2IzTnBkRjloWm5SbGNsOXBabDlsYkhObFFESXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qRXlOQW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnMktRb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNVGt6Q2lBZ0lDQXZMeUJ6Wld4bUxteGxkbVZzVzJGalkyOTFiblJkSUQwZ2MyVnNaaTVmWTJGc1kzVnNZWFJsWDJ4bGRtVnNLRzVsZDE5NGNDa0tJQ0FnSUdJZ1pHVndiM05wZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpZWFpwYm1kelgzZGhiR3hsZEM1amIyNTBjbUZqZEM1VFlYWnBibWR6Vm1GMWJIUXVYMk5oYkdOMWJHRjBaVjlzWlhabGJFQXlOQW9LWkdWd2IzTnBkRjlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94T0RFS0lDQWdJQzh2SUdWc2FXWWdjbTkxYm1SelgzTnBibU5sWDJ4aGMzUWdQRDBnVDA1RlgwUkJXVjlTVDFWT1JGTTZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRRME1Bb2dJQ0FnUEQwS0lDQWdJR0o2SUdSbGNHOXphWFJmWld4elpWOWliMlI1UURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94T0RJS0lDQWdJQzh2SUc1bGQxOXpkSEpsWVdzZ1BTQnpkSEpsWVd0ZlpHRjVjeUFySUZWSmJuUTJOQ2d4S1FvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlHUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE9ETUtJQ0FnSUM4dklHVnNhV1lnY205MWJtUnpYM05wYm1ObFgyeGhjM1FnUEQwZ1ZGZFBYMFJCV1Y5U1QxVk9SRk02Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01qZzRNQW9nSUNBZ1BEMEtJQ0FnSUdKNklHUmxjRzl6YVhSZlpXeHpaVjlpYjJSNVFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE9EUUtJQ0FnSUM4dklHNWxkMTl6ZEhKbFlXc2dQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaUlHUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS1pHVndiM05wZEY5bGJITmxYMkp2WkhsQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveE9EWUtJQ0FnSUM4dklHNWxkMTl6ZEhKbFlXc2dQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaUlHUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpZWFpwYm1kelgzZGhiR3hsZEM1amIyNTBjbUZqZEM1VFlYWnBibWR6Vm1GMWJIUXVkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3lNRFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklHRmpZMjkxYm5RZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TVRBNENpQWdJQ0F2THlCamRYSnlaVzUwWDNSdmRHRnNYM05oZG1Wa0xDQmxlR2x6ZEhNZ1BTQnpaV3htTG5SdmRHRnNYM05oZG1Wa0xtMWhlV0psS0dGalkyOTFiblFwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5ellYWmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0pCWTJOdmRXNTBJRzExYzNRZ2IzQjBJR2x1SUdacGNuTjBJZ29nSUNBZ1lYTnpaWEowSUM4dklFRmpZMjkxYm5RZ2JYVnpkQ0J2Y0hRZ2FXNGdabWx5YzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TURrS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tzSUNKWGFYUm9aSEpoZHlCaGJXOTFiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaU0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWMmwwYUdSeVlYY2dZVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TVRJS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUWdQRDBnZEc5MFlXeGZjMkYyWldRc0lDSkpibk4xWm1acFkybGxiblFnWW1Gc1lXNWpaU0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qSXhOQzB5TVRnS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFoWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMWlJbGRwZEdoa2NtRjNZV3dnWm5KdmJTQlRZWFpwYm1kelZtRjFiSFFpTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qSXhOd29nSUNBZ0x5OGdibTkwWlQxaUlsZHBkR2hrY21GM1lXd2dabkp2YlNCVFlYWnBibWR6Vm1GMWJIUWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROVGMyT1RjME5qZzJORGN5TmpFM056WXhObU15TURZMk56STJaalprTWpBMU16WXhOelkyT1RabE5qYzNNelUyTmpFM05UWmpOelFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUbTkwWlFvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pJeE5Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TWpFMExUSXhPQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBXRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsUFdJaVYybDBhR1J5WVhkaGJDQm1jbTl0SUZOaGRtbHVaM05XWVhWc2RDSXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pJeU1Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXpZWFpsWkZ0aFkyTnZkVzUwWFNBOUlIUnZkR0ZzWDNOaGRtVmtJQzBnWVcxdmRXNTBDaUFnSUNCa2FXY2dNZ29nSUNBZ0xRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmYzJGMlpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1qSXlDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaRjluYkc5aVlXd3VkbUZzZFdVZ0xTQmhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOWtaWEJ2YzJsMFpXUmZaMnh2WW1Gc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhSbFpGOW5iRzlpWVd3Z1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1qSXhDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlJsY0c5emFYUmxaRjluYkc5aVlXd3VkbUZzZFdVZ1BTQW9DaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5a1pYQnZjMmwwWldSZloyeHZZbUZzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakl5TVMweU1qTUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRHVmtYMmRzYjJKaGJDNTJZV3gxWlNBOUlDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxuUnZkR0ZzWDJSbGNHOXphWFJsWkY5bmJHOWlZV3d1ZG1Gc2RXVWdMU0JoYlc5MWJuUUtJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyRjJhVzVuYzE5M1lXeHNaWFF2WTI5dWRISmhZM1F1Y0hrNk1qSTBDaUFnSUNBdkx5QnNiMmNvSWxkcGRHaGtjbUYzWVd3Z2MzVmpZMlZ6YzJaMWJDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsZHBkR2hrY21GM1lXd2djM1ZqWTJWemMyWjFiQ0lLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qSXdOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkMkZzYkdWMExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVuWlhSZmMyRjJhVzVuYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl6WVhacGJtZHpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qSXlPQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1ZEc5MFlXeGZjMkYyWldRdVoyVjBLRlI0Ymk1elpXNWtaWElzSUZWSmJuUTJOQ2d3S1NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5ellYWmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveU1qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTnlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1ellYWnBibWR6WDNkaGJHeGxkQzVqYjI1MGNtRmpkQzVUWVhacGJtZHpWbUYxYkhRdVoyVjBYM04wWVhSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNOMFlYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qSXpNZ29nSUNBZ0x5OGdZV05qYjNWdWRDQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveU16UUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjMkYyWldRdVoyVjBLR0ZqWTI5MWJuUXNJRlZKYm5RMk5DZ3dLU2tzQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5ellYWmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5ellYWnBibWR6WDNkaGJHeGxkQzlqYjI1MGNtRmpkQzV3ZVRveU16VUtJQ0FnSUM4dklITmxiR1l1WkdWd2IzTnBkRjlqYjNWdWRDNW5aWFFvWVdOamIzVnVkQ3dnVlVsdWREWTBLREFwS1N3S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWkdWd2IzTnBkRjlqYjNWdWRDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TXpZS0lDQWdJQzh2SUhObGJHWXVjM1J5WldGclgyUmhlWE11WjJWMEtHRmpZMjkxYm5Rc0lGVkpiblEyTkNnd0tTa3NDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luTjBjbVZoYTE5a1lYbHpJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOaGRtbHVaM05mZDJGc2JHVjBMMk52Ym5SeVlXTjBMbkI1T2pJek53b2dJQ0FnTHk4Z2MyVnNaaTU0Y0Y5d2IybHVkSE11WjJWMEtHRmpZMjkxYm5Rc0lGVkpiblEyTkNnd0tTa3NDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luaHdYM0J2YVc1MGN5SUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TXpnS0lDQWdJQzh2SUhObGJHWXViR1YyWld3dVoyVjBLR0ZqWTI5MWJuUXNJRlZKYm5RMk5DZ3hLU2tzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pzWlhabGJDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TXprS0lDQWdJQzh2SUhObGJHWXVhR2xuYUdWemRGOXRhV3hsYzNSdmJtVXVaMlYwS0dGalkyOTFiblFzSUZWSmJuUTJOQ2d3S1Nrc0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSm9hV2RvWlhOMFgyMXBiR1Z6ZEc5dVpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TXpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5oZG1sdVozTmZkMkZzYkdWMExtTnZiblJ5WVdOMExsTmhkbWx1WjNOV1lYVnNkQzVuWlhSZloyeHZZbUZzWDNOMFlYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyZHNiMkpoYkY5emRHRjBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpZWFpwYm1kelgzZGhiR3hsZEM5amIyNTBjbUZqZEM1d2VUb3lOalFLSUNBZ0lDOHZJSEpsZEhWeWJpQW9jMlZzWmk1MGIzUmhiRjlrWlhCdmMybDBaV1JmWjJ4dlltRnNMblpoYkhWbExDQnpaV3htTG5SdmRHRnNYM1Z6WlhKekxuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyUmxjRzl6YVhSbFpGOW5iRzlpWVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZlpHVndiM05wZEdWa1gyZHNiMkpoYkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5MWMyVnljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjkxYzJWeWN5QmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TmpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OaGRtbHVaM05mZDJGc2JHVjBMbU52Ym5SeVlXTjBMbE5oZG1sdVozTldZWFZzZEM1blpYUmZiV2xzWlhOMGIyNWxYM1JvY21WemFHOXNaSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZiV2xzWlhOMGIyNWxYM1JvY21WemFHOXNaSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMkYyYVc1bmMxOTNZV3hzWlhRdlkyOXVkSEpoWTNRdWNIazZNamN4Q2lBZ0lDQXZMeUJ6Wld4bUxtMXBiR1Z6ZEc5dVpWOHhNQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKdGFXeGxjM1J2Ym1WZk1UQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Yldsc1pYTjBiMjVsWHpFd0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05oZG1sdVozTmZkMkZzYkdWMEwyTnZiblJ5WVdOMExuQjVPakkzTWdvZ0lDQWdMeThnYzJWc1ppNXRhV3hsYzNSdmJtVmZOVEF1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWJXbHNaWE4wYjI1bFh6VXdJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xcGJHVnpkRzl1WlY4MU1DQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TnpNS0lDQWdJQzh2SUhObGJHWXViV2xzWlhOMGIyNWxYekV3TUM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWliV2xzWlhOMGIyNWxYekV3TUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhV3hsYzNSdmJtVmZNVEF3SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTmhkbWx1WjNOZmQyRnNiR1YwTDJOdmJuUnlZV04wTG5CNU9qSTNOQW9nSUNBZ0x5OGdjMlZzWmk1dGFXeGxjM1J2Ym1WZk5UQXdMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKdGFXeGxjM1J2Ym1WZk5UQXdJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xcGJHVnpkRzl1WlY4MU1EQWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJGMmFXNW5jMTkzWVd4c1pYUXZZMjl1ZEhKaFkzUXVjSGs2TWpjMUNpQWdJQ0F2THlCelpXeG1MbTFwYkdWemRHOXVaVjh4TURBd0xuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0p0YVd4bGMzUnZibVZmTVRBd01DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVd4bGMzUnZibVZmTVRBd01DQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6WVhacGJtZHpYM2RoYkd4bGRDOWpiMjUwY21GamRDNXdlVG95TmpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFRkJDWVBGblJ2ZEdGc1gyUmxjRzl6YVhSbFpGOW5iRzlpWVd3TGRHOTBZV3hmYzJGMlpXUUxkRzkwWVd4ZmRYTmxjbk1OWkdWd2IzTnBkRjlqYjNWdWRCRm9hV2RvWlhOMFgyMXBiR1Z6ZEc5dVpRdHpkSEpsWVd0ZlpHRjVjd2w0Y0Y5d2IybHVkSE1FRlI5OGRReHRhV3hsYzNSdmJtVmZNVEFNYldsc1pYTjBiMjVsWHpVd0RXMXBiR1Z6ZEc5dVpWOHhNREFOYldsc1pYTjBiMjVsWHpVd01BNXRhV3hsYzNSdmJtVmZNVEF3TUJKc1lYTjBYMlJsY0c5emFYUmZjbTkxYm1RRmJHVjJaV3dpZ0FBeEdFQUFNQ2NJZ1lDdDRnUm5Kd21CZ09IckYyY25Db0dBd3Rjdlp5Y0xnWURLdGU0Qlp5Y01nWUNVNjl3RFp5Z2laeW9pWnpFYlFRQTVNUmtVUkRFWVJJSUdCRFlsNU9zRUlmSGQvd1Q1QWFTMEJHb0dLZXdFNC83bE9nUXJmVHVZTmhvQWpnWUF4Z0pjQXM4QzRBTTRBMHdBTVJtTkF3QzNBSGNBQVFBeEdFUXhBRWxGQXlJcFl5Sk9BazFKUlFKQkFENnhnQ0ZEYkc5emFXNW5JR0ZqWTI5MWJuUWdabkp2YlNCVFlYWnBibWR6Vm1GMWJIU3lCVWNDc2doTEFySUhJN0lRSXJJQnN5SW9aVVJNQ1NoTVp5SXFaVVJCQUFraUttVkVJd2txVEdlQURrRmpZMjkxYm5RZ1kyeHZjMlZrc0NORE1SaEVNUUJKS1NKbVNTc2laa2tuQkNKbVNTY05JbVpKSndVaVpra25CaUptSnc0alppSXFaVVFqQ0NwTVo0QU5WWE5sY2lCdmNIUmxaQ0JwYnJBalF6RVlGRU9BQUVreEZpTUpTVGdRSXhKRU1RQkpUZ0pKSWlsalJFc0NPQUJMQWhKRVN3STRCeklLRWtSUEFqZ0lTVTREU1VSTEFpSXJZMFJMQXlJbkRXTkVTd1FpSndWalRFNEdSRXNFSWljR1kweE9Ca1JMQkNJbkJHTk1UZ1pFVHdOUEF3aEpUZ1JMQXlsUEFtWk1Jd2hMQWl0UEFtWXlCazhDSncxUEFtWXlCa3NCQ1V4QUFQTWpTd2RKSndWUEEyWkxCb0hBaEQwS2dRb0xTd1VJU1VVS1RDY0dTd0ptZ2ZRRERFRUFraU5MQnljT1R3Sm1JaWNNWlVSTEFnNUJBRE1rUlFsTENFc0REVUVBQjBzR0p3UkxDbVlpS0dWRVN3WUlLRXhuZ0JKRVpYQnZjMmwwSUhOMVkyTmxjM05tZFd5d0kwTWlKd3RsUkVzQ0RrRUFCaVZGQ1VML3Z5SW5DbVZFU3dJT1FRQUhnUU5GQ1VML3JTSW5DV1ZFU3dJT1FRQUhnUUpGQ1VML215SW5DR1ZFU3dJT1FRQUdJMFVKUXYrS0lrVUpRditFU3dlQjNBc01RUUFGZ1FKQy8yRkxCNEc0Rnd4QkFBV0JBMEwvVTBzSGdZZ25ERUVBQkNWQy8wWkxCNEhBUGd4QkFBUWtRdjg1Z1FaQy96UkpnYUFMRGtFQUIwc0VJd2hDL3Y5SmdjQVdEa0VBQkNOQy92TWpRdjd2TmhvQlNSV0JDQkpFRnpFQVNTSXBZMFJMQWtSTEFrc0JEa1N4Z0J4WGFYUm9aSEpoZDJGc0lHWnliMjBnVTJGMmFXNW5jMVpoZFd4MHNnVkxBcklJU3dHeUJ5T3lFQ0t5QWJOTEFna3BUR1lpS0dWRVRBa29UR2VBRlZkcGRHaGtjbUYzWVd3Z2MzVmpZMlZ6YzJaMWJMQWpRekVBSWlsaklrNENUUlluQjB4UXNDTkRNUUJKSWlsaklrNENUVXNCSWl0aklrNENUVXNDSWljRll5Sk9BazFMQXlJbkJtTWlUZ0pOU3dRaUp3NWpJMDRDVFU4RklpY0VZeUpPQWsxUEJSWlBCUlpRVHdRV1VFOERGbEJQQWhaUVRCWlFKd2RNVUxBalF5SW9aVVFpS21WRVRCWk1GbEFuQjB4UXNDTkRJaWNJWlVRaUp3bGxSQ0luQ21WRUlpY0xaVVFpSnd4bFJFOEVGazhFRmxCUEF4WlFUd0lXVUV3V1VDY0hURkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
