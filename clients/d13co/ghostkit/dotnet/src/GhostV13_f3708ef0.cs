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

namespace Arc56.Generated.d13co.ghostkit.GhostV13_f3708ef0
{


    public class GhostV13Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GhostV13Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AcctBalanceData : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public ulong Balance { get; set; }

                public ulong MinBalance { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBalance.From(Balance);
                    ret.AddRange(vBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinBalance.From(MinBalance);
                    ret.AddRange(vMinBalance.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AcctBalanceData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AcctBalanceData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBalance = vBalance.ToValue();
                    if (valueBalance is ulong vBalanceValue) { ret.Balance = vBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinBalance = vMinBalance.ToValue();
                    if (valueMinBalance is ulong vMinBalanceValue) { ret.MinBalance = vMinBalanceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AcctBalanceData);
                }
                public bool Equals(AcctBalanceData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AcctBalanceData left, AcctBalanceData right)
                {
                    return EqualityComparer<AcctBalanceData>.Default.Equals(left, right);
                }
                public static bool operator !=(AcctBalanceData left, AcctBalanceData right)
                {
                    return !(left == right);
                }

            }

            public class BlkData : AVMObjectType
            {
                public ulong Round { get; set; }

                public ulong Timestamp { get; set; }

                public ulong TxnCounter { get; set; }

                public Algorand.Address Proposer { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRound.From(Round);
                    ret.AddRange(vRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxnCounter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTxnCounter.From(TxnCounter);
                    ret.AddRange(vTxnCounter.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vProposer.From(Proposer);
                    ret.AddRange(vProposer.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BlkData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BlkData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRound = vRound.ToValue();
                    if (valueRound is ulong vRoundValue) { ret.Round = vRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxnCounter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTxnCounter.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTxnCounter = vTxnCounter.ToValue();
                    if (valueTxnCounter is ulong vTxnCounterValue) { ret.TxnCounter = vTxnCounterValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vProposer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposer = vProposer.ToValue();
                    if (valueProposer is Algorand.Address vProposerValue) { ret.Proposer = vProposerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BlkData);
                }
                public bool Equals(BlkData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BlkData left, BlkData right)
                {
                    return EqualityComparer<BlkData>.Default.Equals(left, right);
                }
                public static bool operator !=(BlkData left, BlkData right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="firstRound"> </param>
        /// <param name="lastRound"> </param>
        public async Task<ulong> BlkTimestamp(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 183, 57, 15 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            var result = await base.SimApp(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BlkTimestamp_Transactions(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 183, 57, 15 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            return await base.MakeTransactionList(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="firstRound"> </param>
        /// <param name="lastRound"> </param>
        public async Task<ulong> BlkTxnCounter(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 54, 148, 221 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            var result = await base.SimApp(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BlkTxnCounter_Transactions(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 54, 148, 221 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            return await base.MakeTransactionList(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="firstRound"> </param>
        /// <param name="lastRound"> </param>
        public async Task<Algorand.Address> BlkProposer(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 238, 129, 97 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            var result = await base.SimApp(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> BlkProposer_Transactions(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 238, 129, 97 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            return await base.MakeTransactionList(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="firstRound"> </param>
        /// <param name="lastRound"> </param>
        public async Task<Structs.BlkData> BlkData(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 190, 75, 61 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            var result = await base.SimApp(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BlkData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BlkData_Transactions(ulong firstRound, ulong lastRound, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 190, 75, 61 };
            var firstRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); firstRoundAbi.From(firstRound);
            var lastRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lastRoundAbi.From(lastRound);

            return await base.MakeTransactionList(new List<object> { abiHandle, firstRoundAbi, lastRoundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="accounts"> </param>
        public async Task<Structs.AcctBalanceData> AcctBalanceData(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 52, 163, 82 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            var result = await base.SimApp(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AcctBalanceData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> AcctBalanceData_Transactions(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 52, 163, 82 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2hvc3RWMTMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWNjdEJhbGFuY2VEYXRhIjpbeyJuYW1lIjoiYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9XSwiQmxrRGF0YSI6W3sibmFtZSI6InJvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0eG5Db3VudGVyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3Bvc2VyIiwidHlwZSI6ImFkZHJlc3MifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYmxrVGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpcnN0Um91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhc3RSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmxrVHhuQ291bnRlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXJzdFJvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYXN0Um91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJsa1Byb3Bvc2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpcnN0Um91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhc3RSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJsa0RhdGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlyc3RSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFzdFJvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkJsa0RhdGEiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFjY3RCYWxhbmNlRGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFjY3RCYWxhbmNlRGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDNdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lETXlDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM0xURTRDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJoZG0xV1pYSnphVzl1T2lBeE1TQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVkb2IzTjBiMlpoZG0wZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGs1WWpjek9UQm1JREI0WWpBek5qazBaR1FnTUhnMU1tVmxPREUyTVNBd2VEY3dZbVUwWWpOa0lEQjRZalV6TkdFek5USWdMeThnYldWMGFHOWtJQ0ppYkd0VWFXMWxjM1JoYlhBb2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbUpzYTFSNGJrTnZkVzUwWlhJb2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbUpzYTFCeWIzQnZjMlZ5S0hWcGJuUTJOQ3gxYVc1ME5qUXBZV1JrY21WemN5SXNJRzFsZEdodlpDQWlZbXhyUkdGMFlTaDFhVzUwTmpRc2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOektTSXNJRzFsZEdodlpDQWlZV05qZEVKaGJHRnVZMlZFWVhSaEtHRmtaSEpsYzNOYlhTa29ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHSnNhMVJwYldWemRHRnRjQ0JpYkd0VWVHNURiM1Z1ZEdWeUlHSnNhMUJ5YjNCdmMyVnlJR0pzYTBSaGRHRWdZV05qZEVKaGJHRnVZMlZFWVhSaENpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBIYUc5emRHOW1ZWFp0TG1Kc2ExUnBiV1Z6ZEdGdGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUpzYTFScGJXVnpkR0Z0Y0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2IyNURjbVZoZEdVNklDZGhiR3h2ZHljZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtDbUpzYTFScGJXVnpkR0Z0Y0Y5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHWnZjaUFvYkdWMElISnZkVzVrT2lCMWFXNTBOalFnUFNCbWFYSnpkRkp2ZFc1a095QnliM1Z1WkNBOFBTQnNZWE4wVW05MWJtUTdJSEp2ZFc1a0t5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEdzlDaUFnSUNCaWVpQmliR3RVYVcxbGMzUmhiWEJmWVdaMFpYSmZkMmhwYkdWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkb2IzTjBiMlpoZG0wdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z2JHOW5LRzl3TGtKc2IyTnJMbUpzYTFScGJXVnpkR0Z0Y0NoeWIzVnVaQ2twQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0pzYjJOcklFSnNhMVJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnliM1Z1WkRvZ2RXbHVkRFkwSUQwZ1ptbHljM1JTYjNWdVpEc2djbTkxYm1RZ1BEMGdiR0Z6ZEZKdmRXNWtPeUJ5YjNWdVpDc3JLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHSnNhMVJwYldWemRHRnRjRjkzYUdsc1pWOTBiM0JBTWdvS1lteHJWR2x0WlhOMFlXMXdYMkZtZEdWeVgzZG9hV3hsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQW5ZV3hzYjNjbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBIYUc5emRHOW1ZWFp0TG1Kc2ExUjRia052ZFc1MFpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYkd0VWVHNURiM1Z1ZEdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkb2IzTjBiMlpoZG0wdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dKMkZzYkc5M0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9LWW14clZIaHVRMjkxYm5SbGNsOTNhR2xzWlY5MGIzQkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJSEp2ZFc1a09pQjFhVzUwTmpRZ1BTQm1hWEp6ZEZKdmRXNWtPeUJ5YjNWdVpDQThQU0JzWVhOMFVtOTFibVE3SUhKdmRXNWtLeXNwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHc5Q2lBZ0lDQmllaUJpYkd0VWVHNURiM1Z1ZEdWeVgyRm1kR1Z5WDNkb2FXeGxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR3h2WnlodmNDNUNiRzlqYXk1aWJHdFVlRzVEYjNWdWRHVnlLSEp2ZFc1a0tTa0tJQ0FnSUdSMWNHNGdNZ29nSUNBZ1lteHZZMnNnUW14clZIaHVRMjkxYm5SbGNnb2dJQ0FnYVhSdllnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCeWIzVnVaRG9nZFdsdWREWTBJRDBnWm1seWMzUlNiM1Z1WkRzZ2NtOTFibVFnUEQwZ2JHRnpkRkp2ZFc1a095QnliM1Z1WkNzcktTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdKc2ExUjRia052ZFc1MFpYSmZkMmhwYkdWZmRHOXdRRElLQ21Kc2ExUjRia052ZFc1MFpYSmZZV1owWlhKZmQyaHBiR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2IyNURjbVZoZEdVNklDZGhiR3h2ZHljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa2RvYjNOMGIyWmhkbTB1WW14clVISnZjRzl6WlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliR3RRY205d2IzTmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNkaGJHeHZkeWNnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0NtSnNhMUJ5YjNCdmMyVnlYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRvYjNOMGIyWmhkbTB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnWm05eUlDaHNaWFFnY205MWJtUTZJSFZwYm5RMk5DQTlJR1pwY25OMFVtOTFibVE3SUhKdmRXNWtJRHc5SUd4aGMzUlNiM1Z1WkRzZ2NtOTFibVFyS3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEQwS0lDQWdJR0o2SUdKc2ExQnliM0J2YzJWeVgyRm1kR1Z5WDNkb2FXeGxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJR3h2WnlodmNDNUNiRzlqYXk1aWJHdFFjbTl3YjNObGNpaHliM1Z1WkNrcENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdKc2IyTnJJRUpzYTFCeWIzQnZjMlZ5Q2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJSEp2ZFc1a09pQjFhVzUwTmpRZ1BTQm1hWEp6ZEZKdmRXNWtPeUJ5YjNWdVpDQThQU0JzWVhOMFVtOTFibVE3SUhKdmRXNWtLeXNwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdZbXhyVUhKdmNHOXpaWEpmZDJocGJHVmZkRzl3UURJS0NtSnNhMUJ5YjNCdmMyVnlYMkZtZEdWeVgzZG9hV3hsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQW5ZV3hzYjNjbklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0VOVlVGaFpOVWxCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwSGFHOXpkRzltWVhadExtSnNhMFJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliR3RFWVhSaE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkb2IzTjBiMlpoZG0wdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbExDQnZia055WldGMFpUb2dKMkZzYkc5M0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9LWW14clJHRjBZVjkzYUdsc1pWOTBiM0JBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUdadmNpQW9iR1YwSUhKdmRXNWtPaUIxYVc1ME5qUWdQU0JtYVhKemRGSnZkVzVrT3lCeWIzVnVaQ0E4UFNCc1lYTjBVbTkxYm1RN0lISnZkVzVrS3lzcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3OUNpQWdJQ0JpZWlCaWJHdEVZWFJoWDJGbWRHVnlYM2RvYVd4bFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIUnBiV1Z6ZEdGdGNEb2diM0F1UW14dlkyc3VZbXhyVkdsdFpYTjBZVzF3S0hKdmRXNWtLU3dLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbXh2WTJzZ1FteHJWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QndjbTl3YjNObGNqb2diM0F1UW14dlkyc3VZbXhyVUhKdmNHOXpaWElvY205MWJtUXBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnNiMk5ySUVKc2ExQnliM0J2YzJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCMGVHNURiM1Z1ZEdWeU9pQnZjQzVDYkc5amF5NWliR3RVZUc1RGIzVnVkR1Z5S0hKdmRXNWtLU3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliRzlqYXlCQ2JHdFVlRzVEYjNWdWRHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJMVFV4Q2lBZ0lDQXZMeUJqYjI1emRDQmliR3RFWVhSaE9pQkNiR3RFWVhSaElEMGdld29nSUNBZ0x5OGdJQ0J5YjNWdVpDd0tJQ0FnSUM4dklDQWdkR2x0WlhOMFlXMXdPaUJ2Y0M1Q2JHOWpheTVpYkd0VWFXMWxjM1JoYlhBb2NtOTFibVFwTEFvZ0lDQWdMeThnSUNCd2NtOXdiM05sY2pvZ2IzQXVRbXh2WTJzdVlteHJVSEp2Y0c5elpYSW9jbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQjBlRzVEYjNWdWRHVnlPaUJ2Y0M1Q2JHOWpheTVpYkd0VWVHNURiM1Z1ZEdWeUtISnZkVzVrS1N3S0lDQWdJQzh2SUgwS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHeHZaeWhsYm1OdlpHVkJjbU0wS0dKc2EwUmhkR0VwS1FvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0J5YjNWdVpEb2dkV2x1ZERZMElEMGdabWx5YzNSU2IzVnVaRHNnY205MWJtUWdQRDBnYkdGemRGSnZkVzVrT3lCeWIzVnVaQ3NyS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR0pzYTBSaGRHRmZkMmhwYkdWZmRHOXdRRElLQ21Kc2EwUmhkR0ZmWVdaMFpYSmZkMmhwYkdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTd2diMjVEY21WaGRHVTZJQ2RoYkd4dmR5Y2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTXpJb1ExVlFXRmsxU1VGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCS1FvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZG9iM04wYjJaaGRtMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSMmh2YzNSdlptRjJiUzVoWTJOMFFtRnNZVzVqWlVSaGRHRmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWTJOMFFtRnNZVzVqWlVSaGRHRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVXNJRzl1UTNKbFlYUmxPaUFuWVd4c2IzY25JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVdOamIzVnVkQ0J2WmlCaFkyTnZkVzUwY3lrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvS1lXTmpkRUpoYkdGdVkyVkVZWFJoWDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZV05qYjNWdWRDQnZaaUJoWTJOdmRXNTBjeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2dZV05qZEVKaGJHRnVZMlZFWVhSaFgyRm1kR1Z5WDJadmNrQTFDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHSmhiR0Z1WTJVNklHOXdMbUpoYkdGdVkyVW9ZV05qYjNWdWRDa3NJQzh2SUdGalkyOTFiblF1WW1Gc1lXNWpaU0JoYzNObGNuUnpJRzV2YmlCNlpYSnZMaUIzWlNCa2IyNTBJSGRoYm5RZ2RHaGhkQW9nSUNBZ1pIVndDaUFnSUNCaVlXeGhibU5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJ0YVc1Q1lXeGhibU5sT2lCdmNDNXRhVzVDWVd4aGJtTmxLR0ZqWTI5MWJuUXBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHMXBibDlpWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXdMVFkwQ2lBZ0lDQXZMeUJqYjI1emRDQmhZMk4wUW1Gc1lXNWpaVVJoZEdFNklFRmpZM1JDWVd4aGJtTmxSR0YwWVNBOUlIc0tJQ0FnSUM4dklDQWdZV1JrY21WemN6b2dZV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdZbUZzWVc1alpUb2diM0F1WW1Gc1lXNWpaU2hoWTJOdmRXNTBLU3dnTHk4Z1lXTmpiM1Z1ZEM1aVlXeGhibU5sSUdGemMyVnlkSE1nYm05dUlIcGxjbTh1SUhkbElHUnZiblFnZDJGdWRDQjBhR0YwQ2lBZ0lDQXZMeUFnSUcxcGJrSmhiR0Z1WTJVNklHOXdMbTFwYmtKaGJHRnVZMlVvWVdOamIzVnVkQ2tzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJzYjJjb1pXNWpiMlJsUVhKak5DaGhZMk4wUW1Gc1lXNWpaVVJoZEdFcEtRb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR0ZqWTNSQ1lXeGhibU5sUkdGMFlWOW1iM0pmYUdWaFpHVnlRRElLQ21GalkzUkNZV3hoYm1ObFJHRjBZVjloWm5SbGNsOW1iM0pBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2IyNURjbVZoZEdVNklDZGhiR3h2ZHljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxNeklvUTFWUVdGazFTVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQktRb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFekNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkRTQURBUUFnSmdFTUZSOThkUUFBQUFBQUFBQUFNUmtVUklJRkJKbTNPUThFc0RhVTNRUlM3b0ZoQkhDK1N6MEV0VFNqVWpZYUFJNEZBQUVBSUFBL0FJSUE4UUEyR2dFWE5ob0NGMHhKU3dJT1FSaEhBdEVCRnJBaUNFVUJRaDhvc0NKRE5ob0JGellhQWhkTVNVc0NEa0VZUndMUkNCYXdJZ2hGQVVJZktMQWlRellhQVJjMkdnSVhURWxMQWc1QkZrY0MwUUt3SWdoRkFVSWRnQ1FWSDN4MUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUN3SWtNMkdnRVhOaG9DRjB4SlN3SU9RVDVIQXRFQlN3SFJBa3NDMFFoTEF4WlBBeFpRVEJaUVRGQ3dJZ2hGQVVKRmdEd1ZIM3gxQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDd0lrTTJHZ0ZKSTFralNVc0NERUZHU3dKWEFnQkxBVWxPQWlRTEpGaEpZRXNCZUV3V1R3Sk1VRXdXVUxBaUNFVUJRazJBTkJVZmZIVUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUN3SWtNPSIsImNsZWFyIjoiRFlFQlF5QUJBUT09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
