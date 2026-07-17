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

namespace Arc56.Generated.d13co.ghostofavm.Ghostofavm_e1e1bb27
{


    public class GhostofavmProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GhostofavmProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2hvc3RvZmF2bSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBY2N0QmFsYW5jZURhdGEiOlt7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJiYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1pbkJhbGFuY2UiLCJ0eXBlIjoidWludDY0In1dLCJCbGtEYXRhIjpbeyJuYW1lIjoicm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InR4bkNvdW50ZXIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvcG9zZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJibGtUaW1lc3RhbXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlyc3RSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFzdFJvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJibGtUeG5Db3VudGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpcnN0Um91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhc3RSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmxrUHJvcG9zZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlyc3RSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGFzdFJvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmxrRGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXJzdFJvdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsYXN0Um91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LGFkZHJlc3MpIiwic3RydWN0IjoiQmxrRGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjdEJhbGFuY2VEYXRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQWNjdEJhbGFuY2VEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0M10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTFRFNENpQWdJQ0F2THlCQVkyOXVkSEpoWTNRb2V5QmhkbTFXWlhKemFXOXVPaUF4TVNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRWRvYjNOMGIyWmhkbTBnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEazVZamN6T1RCbUlEQjRZakF6TmprMFpHUWdNSGcxTW1WbE9ERTJNU0F3ZURjd1ltVTBZak5rSURCNFlqVXpOR0V6TlRJZ0x5OGdiV1YwYUc5a0lDSmliR3RVYVcxbGMzUmhiWEFvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltSnNhMVI0YmtOdmRXNTBaWElvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltSnNhMUJ5YjNCdmMyVnlLSFZwYm5RMk5DeDFhVzUwTmpRcFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaVlteHJSR0YwWVNoMWFXNTBOalFzZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aFpHUnlaWE56S1NJc0lHMWxkR2h2WkNBaVlXTmpkRUpoYkdGdVkyVkVZWFJoS0dGa1pISmxjM05iWFNrb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdKc2ExUnBiV1Z6ZEdGdGNDQmliR3RVZUc1RGIzVnVkR1Z5SUdKc2ExQnliM0J2YzJWeUlHSnNhMFJoZEdFZ1lXTmpkRUpoYkdGdVkyVkVZWFJoQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEhhRzl6ZEc5bVlYWnRMbUpzYTFScGJXVnpkR0Z0Y0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnNhMVJwYldWemRHRnRjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNkaGJHeHZkeWNnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0NtSnNhMVJwYldWemRHRnRjRjkzYUdsc1pWOTBiM0JBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUdadmNpQW9iR1YwSUhKdmRXNWtPaUIxYVc1ME5qUWdQU0JtYVhKemRGSnZkVzVrT3lCeWIzVnVaQ0E4UFNCc1lYTjBVbTkxYm1RN0lISnZkVzVrS3lzcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3OUNpQWdJQ0JpZWlCaWJHdFVhVzFsYzNSaGJYQmZZV1owWlhKZmQyaHBiR1ZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRvYjNOMGIyWmhkbTB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnYkc5bktHOXdMa0pzYjJOckxtSnNhMVJwYldWemRHRnRjQ2h5YjNWdVpDa3BDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSnNiMk5ySUVKc2ExUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCbWIzSWdLR3hsZENCeWIzVnVaRG9nZFdsdWREWTBJRDBnWm1seWMzUlNiM1Z1WkRzZ2NtOTFibVFnUEQwZ2JHRnpkRkp2ZFc1a095QnliM1Z1WkNzcktTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdKc2ExUnBiV1Z6ZEdGdGNGOTNhR2xzWlY5MGIzQkFNZ29LWW14clZHbHRaWE4wWVcxd1gyRm1kR1Z5WDNkb2FXeGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBbllXeHNiM2NuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEhhRzl6ZEc5bVlYWnRMbUpzYTFSNGJrTnZkVzUwWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGliR3RVZUc1RGIzVnVkR1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRvYjNOMGIyWmhkbTB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsTENCdmJrTnlaV0YwWlRvZ0oyRnNiRzkzSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb0tZbXhyVkhodVEyOTFiblJsY2w5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHWnZjaUFvYkdWMElISnZkVzVrT2lCMWFXNTBOalFnUFNCbWFYSnpkRkp2ZFc1a095QnliM1Z1WkNBOFBTQnNZWE4wVW05MWJtUTdJSEp2ZFc1a0t5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEdzlDaUFnSUNCaWVpQmliR3RVZUc1RGIzVnVkR1Z5WDJGbWRHVnlYM2RvYVd4bFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHeHZaeWh2Y0M1Q2JHOWpheTVpYkd0VWVHNURiM1Z1ZEdWeUtISnZkVzVrS1NrS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW14dlkyc2dRbXhyVkhodVEyOTFiblJsY2dvZ0lDQWdhWFJ2WWdvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0J5YjNWdVpEb2dkV2x1ZERZMElEMGdabWx5YzNSU2IzVnVaRHNnY205MWJtUWdQRDBnYkdGemRGSnZkVzVrT3lCeWIzVnVaQ3NyS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR0pzYTFSNGJrTnZkVzUwWlhKZmQyaHBiR1ZmZEc5d1FESUtDbUpzYTFSNGJrTnZkVzUwWlhKZllXWjBaWEpmZDJocGJHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNkaGJHeHZkeWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rZG9iM04wYjJaaGRtMHVZbXhyVUhKdmNHOXpaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWJHdFFjbTl3YjNObGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTd2diMjVEY21WaGRHVTZJQ2RoYkd4dmR5Y2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLQ21Kc2ExQnliM0J2YzJWeVgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZG9iM04wYjJaaGRtMHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdabTl5SUNoc1pYUWdjbTkxYm1RNklIVnBiblEyTkNBOUlHWnBjbk4wVW05MWJtUTdJSEp2ZFc1a0lEdzlJR3hoYzNSU2IzVnVaRHNnY205MWJtUXJLeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQRDBLSUNBZ0lHSjZJR0pzYTFCeWIzQnZjMlZ5WDJGbWRHVnlYM2RvYVd4bFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHeHZaeWh2Y0M1Q2JHOWpheTVpYkd0UWNtOXdiM05sY2loeWIzVnVaQ2twQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0pzYjJOcklFSnNhMUJ5YjNCdmMyVnlDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHWnZjaUFvYkdWMElISnZkVzVrT2lCMWFXNTBOalFnUFNCbWFYSnpkRkp2ZFc1a095QnliM1Z1WkNBOFBTQnNZWE4wVW05MWJtUTdJSEp2ZFc1a0t5c3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1lteHJVSEp2Y0c5elpYSmZkMmhwYkdWZmRHOXdRRElLQ21Kc2ExQnliM0J2YzJWeVgyRm1kR1Z5WDNkb2FXeGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VzSUc5dVEzSmxZWFJsT2lBbllXeHNiM2NuSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRU5WVUZoWk5VbEJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVFcENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBIYUc5emRHOW1ZWFp0TG1Kc2EwUmhkR0ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWJHdEVZWFJoT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmRvYjNOMGIyWmhkbTB2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsTENCdmJrTnlaV0YwWlRvZ0oyRnNiRzkzSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb0tZbXhyUkdGMFlWOTNhR2xzWlY5MGIzQkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJSEp2ZFc1a09pQjFhVzUwTmpRZ1BTQm1hWEp6ZEZKdmRXNWtPeUJ5YjNWdVpDQThQU0JzWVhOMFVtOTFibVE3SUhKdmRXNWtLeXNwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHc5Q2lBZ0lDQmllaUJpYkd0RVlYUmhYMkZtZEdWeVgzZG9hV3hsUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhScGJXVnpkR0Z0Y0RvZ2IzQXVRbXh2WTJzdVlteHJWR2x0WlhOMFlXMXdLSEp2ZFc1a0tTd0tJQ0FnSUdSMWNHNGdNZ29nSUNBZ1lteHZZMnNnUW14clZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCd2NtOXdiM05sY2pvZ2IzQXVRbXh2WTJzdVlteHJVSEp2Y0c5elpYSW9jbTkxYm1RcExBb2dJQ0FnWkdsbklERUtJQ0FnSUdKc2IyTnJJRUpzYTFCeWIzQnZjMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaMmh2YzNSdlptRjJiUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUIwZUc1RGIzVnVkR1Z5T2lCdmNDNUNiRzlqYXk1aWJHdFVlRzVEYjNWdWRHVnlLSEp2ZFc1a0tTd0tJQ0FnSUdScFp5QXlDaUFnSUNCaWJHOWpheUJDYkd0VWVHNURiM1Z1ZEdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkxUVXhDaUFnSUNBdkx5QmpiMjV6ZENCaWJHdEVZWFJoT2lCQ2JHdEVZWFJoSUQwZ2V3b2dJQ0FnTHk4Z0lDQnliM1Z1WkN3S0lDQWdJQzh2SUNBZ2RHbHRaWE4wWVcxd09pQnZjQzVDYkc5amF5NWliR3RVYVcxbGMzUmhiWEFvY205MWJtUXBMQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmxjam9nYjNBdVFteHZZMnN1WW14clVISnZjRzl6WlhJb2NtOTFibVFwTEFvZ0lDQWdMeThnSUNCMGVHNURiM1Z1ZEdWeU9pQnZjQzVDYkc5amF5NWliR3RVZUc1RGIzVnVkR1Z5S0hKdmRXNWtLU3dLSUNBZ0lDOHZJSDBLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUd4dlp5aGxibU52WkdWQmNtTTBLR0pzYTBSaGRHRXBLUW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnliM1Z1WkRvZ2RXbHVkRFkwSUQwZ1ptbHljM1JTYjNWdVpEc2djbTkxYm1RZ1BEMGdiR0Z6ZEZKdmRXNWtPeUJ5YjNWdVpDc3JLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHSnNhMFJoZEdGZmQyaHBiR1ZmZEc5d1FESUtDbUpzYTBSaGRHRmZZV1owWlhKZmQyaHBiR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2IyNURjbVZoZEdVNklDZGhiR3h2ZHljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxNeklvUTFWUVdGazFTVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkb2IzTjBiMlpoZG0wdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlIyaHZjM1J2Wm1GMmJTNWhZMk4wUW1Gc1lXNWpaVVJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhZMk4wUW1Gc1lXNWpaVVJoZEdFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVc0lHOXVRM0psWVhSbE9pQW5ZV3hzYjNjbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bmFHOXpkRzltWVhadEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZV05qYjNWdWRDQnZaaUJoWTJOdmRXNTBjeWtnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LWVdOamRFSmhiR0Z1WTJWRVlYUmhYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1lXTmpiM1Z1ZENCdlppQmhZMk52ZFc1MGN5a2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ1lXTmpkRUpoYkdGdVkyVkVZWFJoWDJGbWRHVnlYMlp2Y2tBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluYUc5emRHOW1ZWFp0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUdKaGJHRnVZMlU2SUc5d0xtSmhiR0Z1WTJVb1lXTmpiM1Z1ZENrc0lDOHZJR0ZqWTI5MWJuUXVZbUZzWVc1alpTQmhjM05sY25SeklHNXZiaUI2WlhKdkxpQjNaU0JrYjI1MElIZGhiblFnZEdoaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpWVd4aGJtTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QnRhVzVDWVd4aGJtTmxPaUJ2Y0M1dGFXNUNZV3hoYm1ObEtHRmpZMjkxYm5RcExBb2dJQ0FnWkdsbklERUtJQ0FnSUcxcGJsOWlZV3hoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJodmMzUnZabUYyYlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZd0xUWTBDaUFnSUNBdkx5QmpiMjV6ZENCaFkyTjBRbUZzWVc1alpVUmhkR0U2SUVGalkzUkNZV3hoYm1ObFJHRjBZU0E5SUhzS0lDQWdJQzh2SUNBZ1lXUmtjbVZ6Y3pvZ1lXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1ltRnNZVzVqWlRvZ2IzQXVZbUZzWVc1alpTaGhZMk52ZFc1MEtTd2dMeThnWVdOamIzVnVkQzVpWVd4aGJtTmxJR0Z6YzJWeWRITWdibTl1SUhwbGNtOHVJSGRsSUdSdmJuUWdkMkZ1ZENCMGFHRjBDaUFnSUNBdkx5QWdJRzFwYmtKaGJHRnVZMlU2SUc5d0xtMXBia0poYkdGdVkyVW9ZV05qYjNWdWRDa3NDaUFnSUNBdkx5QjlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdloyaHZjM1J2Wm1GMmJTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnNiMmNvWlc1amIyUmxRWEpqTkNoaFkyTjBRbUZzWVc1alpVUmhkR0VwS1FvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHRmpZM1JDWVd4aGJtTmxSR0YwWVY5bWIzSmZhR1ZoWkdWeVFESUtDbUZqWTNSQ1lXeGhibU5sUkdGMFlWOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5hRzl6ZEc5bVlYWnRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU3dnYjI1RGNtVmhkR1U2SUNkaGJHeHZkeWNnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE16SW9RMVZRV0ZrMVNVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCS1FvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQWdKZ0VNRlI5OGRRQUFBQUFBQUFBQU1Sa1VSSUlGQkptM09ROEVzRGFVM1FSUzdvRmhCSEMrU3owRXRUU2pVallhQUk0RkFBRUFJZ0JEQUlnQStRQTJHZ0VYTmhvQ0YweEpTd0lPUVFBTlJ3TFJBUmF3SWdoRkFVTC83Q2l3SWtNMkdnRVhOaG9DRjB4SlN3SU9RUUFOUndMUkNCYXdJZ2hGQVVMLzdDaXdJa00yR2dFWE5ob0NGMHhKU3dJT1FRQU1Sd0xSQXJBaUNFVUJRdi90Z0NRVkgzeDFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDd0lrTTJHZ0VYTmhvQ0YweEpTd0lPUVFBZ1J3TFJBVXNCMFFKTEF0RUlTd01XVHdNV1VFd1dVRXhRc0NJSVJRRkMvOW1BUEJVZmZIVUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBTEFpUXpZYUFVa2pXU05KU3dJTVFRQWtTd0pYQWdCTEFVbE9BaVFMSkZoSllFc0JlRXdXVHdKTVVFd1dVTEFpQ0VVQlF2L1ZnRFFWSDN4MUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFzQ0pEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
