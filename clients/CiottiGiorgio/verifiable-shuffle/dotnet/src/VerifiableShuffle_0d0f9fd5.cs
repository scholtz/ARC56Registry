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

namespace Arc56.Generated.CiottiGiorgio.verifiable_shuffle.VerifiableShuffle_0d0f9fd5
{


    public class VerifiableShuffleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VerifiableShuffleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Commitment : AVMObjectType
            {
                public byte[] TxId { get; set; }

                public ulong Round { get; set; }

                public uint Participants { get; set; }

                public byte Winners { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vTxId.From(TxId);
                    ret.AddRange(vTxId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRound.From(Round);
                    ret.AddRange(vRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipants = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vParticipants.From(Participants);
                    ret.AddRange(vParticipants.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinners = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vWinners.From(Winners);
                    ret.AddRange(vWinners.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Commitment Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Commitment();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vTxId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTxId = vTxId.ToValue();
                    if (valueTxId is byte[] vTxIdValue) { ret.TxId = vTxIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRound = vRound.ToValue();
                    if (valueRound is ulong vRoundValue) { ret.Round = vRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipants = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vParticipants.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueParticipants = vParticipants.ToValue();
                    if (valueParticipants is uint vParticipantsValue) { ret.Participants = vParticipantsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinners = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vWinners.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWinners = vWinners.ToValue();
                    if (valueWinners is byte vWinnersValue) { ret.Winners = vWinnersValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Commitment);
                }
                public bool Equals(Commitment? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Commitment left, Commitment right)
                {
                    return EqualityComparer<Commitment>.Default.Equals(left, right);
                }
                public static bool operator !=(Commitment left, Commitment right)
                {
                    return !(left == right);
                }

            }

            public class Reveal : AVMObjectType
            {
                public byte[] CommitmentTxId { get; set; }

                public uint[] Winners { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitmentTxId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vCommitmentTxId.From(CommitmentTxId);
                    ret.AddRange(vCommitmentTxId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinners = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32[]");
                    vWinners.From(Winners);
                    ret.AddRange(vWinners.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Reveal Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Reveal();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitmentTxId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vCommitmentTxId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitmentTxId = vCommitmentTxId.ToValue();
                    if (valueCommitmentTxId is byte[] vCommitmentTxIdValue) { ret.CommitmentTxId = vCommitmentTxIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinners = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32[]");
                    count = vWinners.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWinners = vWinners.ToValue();
                    if (valueWinners is uint[] vWinnersValue) { ret.Winners = vWinnersValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Reveal);
                }
                public bool Equals(Reveal? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Reveal left, Reveal right)
                {
                    return EqualityComparer<Reveal>.Default.Equals(left, right);
                }
                public static bool operator !=(Reveal left, Reveal right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTemplatedRandomnessBeaconId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 235, 35, 61 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTemplatedRandomnessBeaconId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 235, 35, 61 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTemplatedOpupId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 239, 229, 255 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTemplatedOpupId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 239, 229, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTemplatedSafetyRoundGap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 130, 116, 85 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTemplatedSafetyRoundGap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 130, 116, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="delay"> </param>
        /// <param name="participants"> </param>
        /// <param name="winners"> </param>
        public async Task Commit(byte delay, uint participants, byte winners, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 114, 67, 132 };
            var delayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); delayAbi.From(delay);
            var participantsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); participantsAbi.From(participants);
            var winnersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); winnersAbi.From(winners);

            var result = await base.CallApp(new List<object> { abiHandle, delayAbi, participantsAbi, winnersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Commit_Transactions(byte delay, uint participants, byte winners, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 114, 67, 132 };
            var delayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); delayAbi.From(delay);
            var participantsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); participantsAbi.From(participants);
            var winnersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); winnersAbi.From(winners);

            return await base.MakeTransactionList(new List<object> { abiHandle, delayAbi, participantsAbi, winnersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Reveal> Reveal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 206, 17, 235 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Reveal.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Reveal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 206, 17, 235 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmVyaWZpYWJsZVNodWZmbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ29tbWl0bWVudCI6W3sibmFtZSI6InR4X2lkIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoicm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGFydGljaXBhbnRzIiwidHlwZSI6InVpbnQzMiJ9LHsibmFtZSI6Indpbm5lcnMiLCJ0eXBlIjoidWludDgifV0sIlJldmVhbCI6W3sibmFtZSI6ImNvbW1pdG1lbnRfdHhfaWQiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJ3aW5uZXJzIiwidHlwZSI6InVpbnQzMltdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldF90ZW1wbGF0ZWRfcmFuZG9tbmVzc19iZWFjb25faWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90ZW1wbGF0ZWRfb3B1cF9pZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RlbXBsYXRlZF9zYWZldHlfcm91bmRfZ2FwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21taXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDMyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGFydGljaXBhbnRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Indpbm5lcnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIiwiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZlYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQzMltdKSIsInN0cnVjdCI6IlJldmVhbCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCIsIkNsb3NlT3V0Il19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIiwiVXBkYXRlQXBwbGljYXRpb24iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTUsMTI2XSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBpcyBub3QgdGhlIGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MjldLCJlcnJvck1lc3NhZ2UiOiJUaGUgY29tbWl0dGVkIHJvdW5kIGhhcyBub3QgZWxhcHNlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjFdLCJlcnJvck1lc3NhZ2UiOiJUaGUgbnVtYmVyIG9mIGstcGVybXV0YXRpb24gZXhjZWVkcyB0aGUgc2FmZXR5IHBhcmFtZXRlcnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODVdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcm91bmQgZGVsYXkgaXMgbGVzcyB0aGFuIHRoZSBzYWZldHkgcGFyYW1ldGVycyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5OV0sImVycm9yTWVzc2FnZSI6IlRoZXJlIG11c3QgYmUgYXQgbGVhc3Qgb25lIHdpbm5lciBhbmQgbGVzcyB0aGFuIDM1IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjEwXSwiZXJyb3JNZXNzYWdlIjoiVGhlcmUgbXVzdCBiZSBhdCBsZWFzdCB0d28gcGFydGljaXBhbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE3XSwiZXJyb3JNZXNzYWdlIjoiV2lubmVycyBtdXN0IGJlIGxlc3MgdGhhbiBvciBlcXVhbCB0byBQYXJ0aWNpcGFudHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NzhdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBsb2cgdmFsdWUgaXMgbm90IHRoZSByZXN1bHQgb2YgYW4gQUJJIHJldHVybiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29tbWl0bWVudCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDMyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU0LDU3Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE2OSwxMjU5LDEyOTUsMTMxOSwxMzMwLDE0NTIsMTU0Nl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdOak0yTkRFek5qSXlNemcwTmpjNU16QXdOU0F6TWlBME1qazBPVFkzTWprMUlERTBOREkyT1RVd05EQTRPRGc1TmpNME1EY2dNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXdPU0F4TkRReU5qazFNRFF3T0RnNE9UWXpOREV4SURFME5ESTJPVFV3TkRBNE9EZzVOak0wTVRNZ1ZFMVFURjlXUlZKSlJrbEJRa3hGWDFOSVZVWkdURVZmVDFCVlVDQlVUVkJNWDFKQlRrUlBUVTVGVTFOZlFrVkJRMDlPSUZSTlVFeGZVMEZHUlZSWlgxSlBWVTVFWDBkQlVBb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VDQXdlREUxTVdZM1l6YzFJQ0pqYjIxdGFYUnRaVzUwSWlBd2VEQXhJREI0TURBd01DQXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhOUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFV3TnpJME16ZzBJREI0TXpOalpURXhaV0lnTHk4Z2JXVjBhRzlrSUNKamIyMXRhWFFvZFdsdWREZ3NkV2x1ZERNeUxIVnBiblE0S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsZG1WaGJDZ3BLR0o1ZEdWYk16SmRMSFZwYm5Rek1sdGRLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZMjl0YldsMFgzSnZkWFJsUURVZ2JXRnBibDl5WlhabFlXeGZjbTkxZEdWQU5nb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURjNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnM1lXVmlNak16WkNBd2VHVTBaV1psTldabUlEQjROVGs0TWpjME5UVWdMeThnYldWMGFHOWtJQ0puWlhSZmRHVnRjR3hoZEdWa1gzSmhibVJ2Ylc1bGMzTmZZbVZoWTI5dVgybGtLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MFpXMXdiR0YwWldSZmIzQjFjRjlwWkNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZkR1Z0Y0d4aGRHVmtYM05oWm1WMGVWOXliM1Z1WkY5bllYQW9LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2RsZEY5MFpXMXdiR0YwWldSZmNtRnVaRzl0Ym1WemMxOWlaV0ZqYjI1ZmFXUWdaMlYwWDNSbGJYQnNZWFJsWkY5dmNIVndYMmxrSUdkbGRGOTBaVzF3YkdGMFpXUmZjMkZtWlhSNVgzSnZkVzVrWDJkaGNBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl3T2dvZ0lDQWdaWEp5Q2dwdFlXbHVYM0psZG1WaGJGOXliM1YwWlVBMk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhOb2JBb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQW1DaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZaUJ5WlhabFlXd0tDbTFoYVc1ZlkyOXRiV2wwWDNKdmRYUmxRRFU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjMmhzQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUNZS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlHTnZiVzFwZEFvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnpkMmwwWTJnZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESXdJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TUNCdFlXbHVYM1Z3WkdGMFpVQXhOeUJ0WVdsdVgyUmxiR1YwWlVBeE9Bb2dJQ0FnWlhKeUNncHRZV2x1WDJSbGJHVjBaVUF4T0RvS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR2x6SUc1dmRDQjBhR1VnWTNKbFlYUnZjZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWQU1UYzZDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUmtjbVZ6Y3lCcGN5QnViM1FnZEdobElHTnlaV0YwYjNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFk2Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYkdsaVgzQmpaeTV3WTJjeE1qZ3VYMTl3WTJjeE1qaGZkVzVpYjNWdVpHVmtYM0poYm1SdmJTaHpkR0YwWlM0d09pQjFhVzUwTmpRc0lITjBZWFJsTGpFNklIVnBiblEyTkN3Z2MzUmhkR1V1TWpvZ2RXbHVkRFkwTENCemRHRjBaUzR6T2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJOQ3dnWW5sMFpYTTZDbDlmY0dObk1USTRYM1Z1WW05MWJtUmxaRjl5WVc1a2IyMDZDaUFnSUNCd2NtOTBieUEwSURVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4eUlDOHZJRFl6TmpReE16WXlNak00TkRZM09UTXdNRFVLSUNBZ0lHMTFiSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWXlBMUlDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQWhDaUFnSUNCcGJuUmpJRFlnTHk4Z01UUTBNalk1TlRBME1EZzRPRGsyTXpRd09Rb2dJQ0FnYzNkaGNBb2dJQ0FnYzJoc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0ZrWkhjS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWkhWd0NpQWdJQ0FoQ2lBZ0lDQnBiblJqSURjZ0x5OGdNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXhNUW9nSUNBZ2MzZGhjQW9nSUNBZ2MyaHNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNaUF2THlBMk16WTBNVE0yTWpJek9EUTJOemt6TURBMUNpQWdJQ0J0ZFd4M0NpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGa1pIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1pIVndDaUFnSUNBaENpQWdJQ0JwYm5SaklEZ2dMeThnTVRRME1qWTVOVEEwTURnNE9EazJNelF4TXdvZ0lDQWdjM2RoY0FvZ0lDQWdjMmhzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QTJNelkwTVRNMk1qSXpPRFEyTnprek1EQTFDaUFnSUNCdGRXeDNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQndkWE5vYVc1MElERTRDaUFnSUNCemFISUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWGdvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ2MyaHlDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQndkWE5vYVc1MElEVTVDaUFnSUNCemFISUtJQ0FnSUdSMWNESUtJQ0FnSUhOb2Nnb2dJQ0FnYzNkaGNBb2dJQ0FnZmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpNUW9nSUNBZ0pnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnphR3dLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0I4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lITm9iQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0J6YUhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdYZ29nSUNBZ2NIVnphR2x1ZENBeU53b2dJQ0FnYzJoeUNpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdKZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCd2RYTm9hVzUwSURVNUNpQWdJQ0J6YUhJS0lDQWdJR1IxY0RJS0lDQWdJSE5vY2dvZ0lDQWdjM2RoY0FvZ0lDQWdmZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGa1pIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2NIVnphR2x1ZENBek1Rb2dJQ0FnSmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCemFHd0tJQ0FnSUdsdWRHTWdOQ0F2THlBME1qazBPVFkzTWprMUNpQWdJQ0FtQ2lBZ0lDQjhDaUFnSUNCOENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdNVGdLSUNBZ0lITm9jZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCZUNpQWdJQ0J3ZFhOb2FXNTBJREkzQ2lBZ0lDQnphSElLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBbUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdOVGtLSUNBZ0lITm9jZ29nSUNBZ1pIVndNZ29nSUNBZ2MyaHlDaUFnSUNCemQyRndDaUFnSUNCK0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZV1JrZHdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0J3ZFhOb2FXNTBJRE14Q2lBZ0lDQW1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSE5vYkFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUh3S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdjMmhzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUhOb2Nnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JlQ2lBZ0lDQndkWE5vYVc1MElESTNDaUFnSUNCemFISUtJQ0FnSUdsdWRHTWdOQ0F2THlBME1qazBPVFkzTWprMUNpQWdJQ0FtQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ05Ua0tJQ0FnSUhOb2Nnb2dJQ0FnWkhWd01nb2dJQ0FnYzJoeUNpQWdJQ0J6ZDJGd0NpQWdJQ0IrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQndkWE5vYVc1MElETXhDaUFnSUNBbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lITm9iQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXlPVFE1TmpjeU9UVUtJQ0FnSUNZS0lDQWdJSHdLSUNBZ0lId0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuWmxjbWxtYVdGaWJHVmZjMmgxWm1ac1pTNWpiMjUwY21GamRDNWlhVzVoY25sZmJHOW5ZWEpwZEdodEtHNDZJSFZwYm5RMk5Dd2diVG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q21KcGJtRnllVjlzYjJkaGNtbDBhRzA2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCemQyRndDaUFnSUNCemFHd0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWW1sdVlYSjVYMnh2WjJGeWFYUm9iVjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5vYkFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtSnBibUZ5ZVY5c2IyZGhjbWwwYUcxZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb0tZbWx1WVhKNVgyeHZaMkZ5YVhSb2JWOW1iM0pmYUdWaFpHVnlRRE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOENpQWdJQ0JpZWlCaWFXNWhjbmxmYkc5bllYSnBkR2h0WDJGbWRHVnlYMlp2Y2tBNENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lITm9iQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdSMWNBb2dJQ0FnYlhWc2R3b2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1JwZG5jS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUhOb2JBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0E4UFFvZ0lDQWdZbm9nWW1sdVlYSjVYMnh2WjJGeWFYUm9iVjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdmQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J6YUhJS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0NtSnBibUZ5ZVY5c2IyZGhjbWwwYUcxZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0lnWW1sdVlYSjVYMnh2WjJGeWFYUm9iVjltYjNKZmFHVmhaR1Z5UURNS0NtSnBibUZ5ZVY5c2IyZGhjbWwwYUcxZllXWjBaWEpmWm05eVFEZzZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6YUd3S0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQjhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MlpYSnBabWxoWW14bFgzTm9kV1ptYkdVdVkyOXVkSEpoWTNRdWJHbHVaV0Z5WDNObFlYSmphQ2hpYVc1ZmJHbHpkRG9nWW5sMFpYTXNJR3RsZVRvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwc2FXNWxZWEpmYzJWaGNtTm9PZ29nSUNBZ2NISnZkRzhnTWlBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREFLQ214cGJtVmhjbDl6WldGeVkyaGZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBOENpQWdJQ0JpZWlCc2FXNWxZWEpmYzJWaGNtTm9YMkZtZEdWeVgyWnZja0EyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXpNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JHbHVaV0Z5WDNObFlYSmphRjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5Rek1nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCeVpYUnpkV0lLQ214cGJtVmhjbDl6WldGeVkyaGZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JpSUd4cGJtVmhjbDl6WldGeVkyaGZabTl5WDJobFlXUmxja0F4Q2dwc2FXNWxZWEpmYzJWaGNtTm9YMkZtZEdWeVgyWnZja0EyT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUyWlhKcFptbGhZbXhsWDNOb2RXWm1iR1V1WTI5dWRISmhZM1F1Vm1WeWFXWnBZV0pzWlZOb2RXWm1iR1V1WjJWMFgzUmxiWEJzWVhSbFpGOXlZVzVrYjIxdVpYTnpYMkpsWVdOdmJsOXBaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTBaVzF3YkdGMFpXUmZjbUZ1Wkc5dGJtVnpjMTlpWldGamIyNWZhV1E2Q2lBZ0lDQnBiblJqSURFd0lDOHZJRlJOVUV4ZlVrRk9SRTlOVGtWVFUxOUNSVUZEVDA0S0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbVZ5YVdacFlXSnNaVjl6YUhWbVpteGxMbU52Ym5SeVlXTjBMbFpsY21sbWFXRmliR1ZUYUhWbVpteGxMbWRsZEY5MFpXMXdiR0YwWldSZmIzQjFjRjlwWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjkwWlcxd2JHRjBaV1JmYjNCMWNGOXBaRG9LSUNBZ0lHbHVkR01nT1NBdkx5QlVUVkJNWDFaRlVrbEdTVUZDVEVWZlUwaFZSa1pNUlY5UFVGVlFDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5abGNtbG1hV0ZpYkdWZmMyaDFabVpzWlM1amIyNTBjbUZqZEM1V1pYSnBabWxoWW14bFUyaDFabVpzWlM1blpYUmZkR1Z0Y0d4aGRHVmtYM05oWm1WMGVWOXliM1Z1WkY5bllYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmRHVnRjR3hoZEdWa1gzTmhabVYwZVY5eWIzVnVaRjluWVhBNkNpQWdJQ0JwYm5SaklERXhJQzh2SUZSTlVFeGZVMEZHUlZSWlgxSlBWVTVFWDBkQlVBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUyWlhKcFptbGhZbXhsWDNOb2RXWm1iR1V1WTI5dWRISmhZM1F1Vm1WeWFXWnBZV0pzWlZOb2RXWm1iR1V1WTI5dGJXbDBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5dGJXbDBPZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ1pIVndiaUEzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRETXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5SaklERXhJQzh2SUZSTlVFeGZVMEZHUlZSWlgxSlBWVTVFWDBkQlVBb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJVYUdVZ2NtOTFibVFnWkdWc1lYa2dhWE1nYkdWemN5QjBhR0Z1SUhSb1pTQnpZV1psZEhrZ2NHRnlZVzFsZEdWeWN3b2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JpZWlCamIyMXRhWFJmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNelVLSUNBZ0lEd0tJQ0FnSUdKNklHTnZiVzFwZEY5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENncGpiMjF0YVhSZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ1lYTnpaWEowSUM4dklGUm9aWEpsSUcxMWMzUWdZbVVnWVhRZ2JHVmhjM1FnYjI1bElIZHBibTVsY2lCaGJtUWdiR1Z6Y3lCMGFHRnVJRE0xQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZSb1pYSmxJRzExYzNRZ1ltVWdZWFFnYkdWaGMzUWdkSGR2SUhCaGNuUnBZMmx3WVc1MGN3b2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGZHBibTVsY25NZ2JYVnpkQ0JpWlNCc1pYTnpJSFJvWVc0Z2IzSWdaWEYxWVd3Z2RHOGdVR0Z5ZEdsamFYQmhiblJ6Q2lBZ0lDQndkWE5vYVc1MElEWXdNQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0EzTURBS0lDQWdJQzhLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNZ29LWTI5dGJXbDBYMlp2Y2w5b1pXRmtaWEpBTmpvS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWkdsbklERXdDaUFnSUNBOENpQWdJQ0JpZWlCamIyMXRhWFJmWVdaMFpYSmZabTl5UURFd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqSURrZ0x5OGdWRTFRVEY5V1JWSkpSa2xCUWt4RlgxTklWVVpHVEVWZlQxQlZVQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ1lpQmpiMjF0YVhSZlptOXlYMmhsWVdSbGNrQTJDZ3BqYjIxdGFYUmZZV1owWlhKZlptOXlRREV3T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSjFjbmtnT1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjFjbmtnTmdvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOZ29nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFeENncGpiMjF0YVhSZlptOXlYMmhsWVdSbGNrQXhNam9LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaR2xuSURVS0lDQWdJRHdLSUNBZ0lHSjZJR052YlcxcGRGOWhablJsY2w5bWIzSkFNVGdLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmthV2NnTVRFS0lDQWdJRzExYkhjS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWW01NklHTnZiVzFwZEY5cFpsOWliMlI1UURFMUNpQWdJQ0JrYVdjZ053b2dJQ0FnWW1sMGJHVnVDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0E5UFFvZ0lDQWdZbm9nWTI5dGJXbDBYMlZzYzJWZlltOWtlVUF4TmdvS1kyOXRiV2wwWDJsbVgySnZaSGxBTVRVNkNpQWdJQ0JrYVdjZ09Bb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdZMkZzYkhOMVlpQmlhVzVoY25sZmJHOW5ZWEpwZEdodENpQWdJQ0JrYVdjZ05nb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdKMWNua2dPUW9LWTI5dGJXbDBYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERXhDaUFnSUNCaUlHTnZiVzFwZEY5bWIzSmZhR1ZoWkdWeVFERXlDZ3BqYjIxdGFYUmZaV3h6WlY5aWIyUjVRREUyT2dvZ0lDQWdaR2xuSURnS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnS2dvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JpSUdOdmJXMXBkRjloWm5SbGNsOXBabDlsYkhObFFERTNDZ3BqYjIxdGFYUmZZV1owWlhKZlptOXlRREU0T2dvZ0lDQWdaR2xuSURnS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHTmhiR3h6ZFdJZ1ltbHVZWEo1WDJ4dloyRnlhWFJvYlFvZ0lDQWdaR2xuSURZS0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ09ETTRPRFl3T0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVhR1VnYm5WdFltVnlJRzltSUdzdGNHVnliWFYwWVhScGIyNGdaWGhqWldWa2N5QjBhR1VnYzJGbVpYUjVJSEJoY21GdFpYUmxjbk1LSUNBZ0lIUjRiaUJVZUVsRUNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR1JwWnlBekNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTnZiVzFwZEcxbGJuUWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtTnZiVzFwZEY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCamIyMXRhWFJmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblpsY21sbWFXRmliR1ZmYzJoMVptWnNaUzVqYjI1MGNtRmpkQzVXWlhKcFptbGhZbXhsVTJoMVptWnNaUzV5WlhabFlXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhabFlXdzZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd2JpQTJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCa2RYQnVJREV4Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyOXRiV2wwYldWdWRDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU52YlcxcGRHMWxiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpiMjF0YVhSdFpXNTBJZ29nSUNBZ1lYQndYMnh2WTJGc1gyUmxiQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5Rek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFEwQ2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0J6ZDJGd0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRE15SURnS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHaGxJR052YlcxcGRIUmxaQ0J5YjNWdVpDQm9ZWE1nYm05MElHVnNZWEJ6WldRZ2VXVjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqSURFd0lDOHZJRlJOVUV4ZlVrRk9SRTlOVGtWVFUxOUNSVUZEVDA0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5EZGpNakJqTWpNZ0x5OGdiV1YwYUc5a0lDSnRkWE4wWDJkbGRDaDFhVzUwTmpRc1lubDBaVnRkS1dKNWRHVmJYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQnNiMmNnZG1Gc2RXVWdhWE1nYm05MElIUm9aU0J5WlhOMWJIUWdiMllnWVc0Z1FVSkpJSEpsZEhWeWJnb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NncHlaWFpsWVd4ZlptOXlYMmhsWVdSbGNrQXpPZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFeENpQWdJQ0E4Q2lBZ0lDQmllaUJ5WlhabFlXeGZZV1owWlhKZlptOXlRRFlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdjM1J2Y21WekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSEpsZG1WaGJGOW1iM0pmYUdWaFpHVnlRRE1LQ25KbGRtVmhiRjloWm5SbGNsOW1iM0pBTmpvS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJRFV3TUFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBM01EQUtJQ0FnSUM4S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1luVnllU0F4TndvS2NtVjJaV0ZzWDJadmNsOW9aV0ZrWlhKQU56b0tJQ0FnSUdScFp5QXhOZ29nSUNBZ1pHbG5JREUwQ2lBZ0lDQThDaUFnSUNCaWVpQnlaWFpsWVd4ZllXWjBaWEpmWm05eVFERXhDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5SaklEa2dMeThnVkUxUVRGOVdSVkpKUmtsQlFreEZYMU5JVlVaR1RFVmZUMUJWVUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdaR2xuSURFMkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4TndvZ0lDQWdZaUJ5WlhabFlXeGZabTl5WDJobFlXUmxja0EzQ2dweVpYWmxZV3hmWVdaMFpYSmZabTl5UURFeE9nb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QTFDaUFnSUNBOENpQWdJQ0JpZWlCeVpYWmxZV3hmZEdWeWJtRnllVjltWVd4elpVQXhNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHSjFjbmtnTVRFS0NuSmxkbVZoYkY5MFpYSnVZWEo1WDIxbGNtZGxRREUwT2dvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMUlDOHZJREUwTkRJMk9UVXdOREE0T0RnNU5qTTBNRGNLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaFpHUjNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR05mTWlBdkx5QTJNelkwTVRNMk1qSXpPRFEyTnprek1EQTFDaUFnSUNCdGRXeDNDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR01nTlNBdkx5QXhORFF5TmprMU1EUXdPRGc0T1RZek5EQTNDaUFnSUNCaFpHUjNDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQndiM0FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZeUEySUM4dklERTBOREkyT1RVd05EQTRPRGc1TmpNME1Ea0tJQ0FnSUdGa1pIY0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOak0yTkRFek5qSXlNemcwTmpjNU16QXdOUW9nSUNBZ2JYVnNkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQnBiblJqSURZZ0x5OGdNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXdPUW9nSUNBZ1lXUmtkd29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdjRzl3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqSURjZ0x5OGdNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXhNUW9nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdNZ055QXZMeUF4TkRReU5qazFNRFF3T0RnNE9UWXpOREV4Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqSURnZ0x5OGdNVFEwTWpZNU5UQTBNRGc0T0RrMk16UXhNd29nSUNBZ1lXUmtkd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUEyTXpZME1UTTJNakl6T0RRMk56a3pNREExQ2lBZ0lDQnRkV3gzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR2x1ZEdNZ09DQXZMeUF4TkRReU5qazFNRFF3T0RnNE9UWXpOREV6Q2lBZ0lDQmhaR1IzQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdDaUFnSUNCaWRYSjVJREl5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdZblZ5ZVNBeENncHlaWFpsWVd4ZlptOXlYMmhsWVdSbGNrQXhOVG9LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQThDaUFnSUNCaWVpQnlaWFpsWVd4ZllXWjBaWEpmWm05eVFESXhDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbDBiMklLSUNBZ0lHSjFjbmtnTWpBS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdDaUFnSUNCaWRYSjVJREl5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJSEpsZG1WaGJGOWxiSE5sWDJKdlpIbEFNekFLSUNBZ0lHUnBaeUF4T0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmllaUJ5WlhabFlXeGZaV3h6WlY5aWIyUjVRRE13Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1luVnllU0F4TmdvS2NtVjJaV0ZzWDJadmNsOW9aV0ZrWlhKQU1qYzZDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOENpQWdJQ0JpZWlCeVpYWmxZV3hmWVdaMFpYSmZhV1pmWld4elpVQTBNQW9nSUNBZ1pHbG5JRGtLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmthV2NnT1FvZ0lDQWdaR2xuSURrS0lDQWdJR05oYkd4emRXSWdYMTl3WTJjeE1qaGZkVzVpYjNWdVpHVmtYM0poYm1SdmJRb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWkdsbklESXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNakVLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVFlLSUNBZ0lHSWdjbVYyWldGc1gyWnZjbDlvWldGa1pYSkFNamNLQ25KbGRtVmhiRjloWm5SbGNsOXBabDlsYkhObFFEUXdPZ29nSUNBZ1pHbG5JREl3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNVFlLSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRETXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01URUtJQ0FnSUNVS0lDQWdJR3h2WVdSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJzYVc1bFlYSmZjMlZoY21Ob0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2IzQUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1luVnllU0F4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBbENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnYkc5aFpITUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ2JHbHVaV0Z5WDNObFlYSmphQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBeE5nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWlhoMGNtRmpkQ0EwSURRS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZFhKNUlESXdDaUFnSUNCaWVpQnlaWFpsWVd4ZlpXeHpaVjlpYjJSNVFERTRDaUFnSUNCa2FXY2dNVElLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnS3dvZ0lDQWdaR2xuSURFMkNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbGVIUnlZV04wSURRZ05Bb2dJQ0FnY21Wd2JHRmpaVE1LQ25KbGRtVmhiRjloWm5SbGNsOXBabDlsYkhObFFERTVPZ29nSUNBZ1pHbG5JRFlLSUNBZ0lITjNZWEFLSUNBZ0lITjBiM0psY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlISmxkbVZoYkY5bWIzSmZhR1ZoWkdWeVFERTFDZ3B5WlhabFlXeGZaV3h6WlY5aWIyUjVRREU0T2dvZ0lDQWdaR2xuSURFekNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbGVIUnlZV04wSURRZ05Bb2dJQ0FnWkdsbklERTJDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKcGRHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmxlSFJ5WVdOMElEUWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0lnY21WMlpXRnNYMkZtZEdWeVgybG1YMlZzYzJWQU1Ua0tDbkpsZG1WaGJGOWxiSE5sWDJKdlpIbEFNekE2Q2lBZ0lDQmthV2NnTVRnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nY21WMlpXRnNYMlZzYzJWZlltOWtlVUF6TWdvZ0lDQWdaR2xuSURFNENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Rb2dJQ0FnWWo0S0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZandLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFS0lDQWdJR0l0Q2lBZ0lDQmthV2NnTWpNS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaVBBb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUxRb2dJQ0FnWW5WeWVTQXlOQW9LY21WMlpXRnNYMkZtZEdWeVgybG1YMlZzYzJWQU16TTZDaUFnSUNCa2FXY2dNak1LSUNBZ0lHUjFjQW9nSUNBZ1luNEtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNUW9nSUNBZ1lpc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ2MzZGhjQW9nSUNBZ1lpVUtJQ0FnSUdKMWNua2dNakFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWRYSjVJREUyQ2dweVpYWmxZV3hmWm05eVgyaGxZV1JsY2tBek5Eb0tJQ0FnSUdScFp5QXhOUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUR3S0lDQWdJR0o2SUhKbGRtVmhiRjloWm5SbGNsOXBabDlsYkhObFFEUXdDZ3B5WlhabFlXeGZkMmhwYkdWZmRHOXdRRE0yT2dvZ0lDQWdaR2xuSURrS0lDQWdJR1JwWnlBNUNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWkdsbklEa0tJQ0FnSUdOaGJHeHpkV0lnWDE5d1kyY3hNamhmZFc1aWIzVnVaR1ZrWDNKaGJtUnZiUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQmlkWEo1SURJNENpQWdJQ0JpZFhKNUlERXhDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmlkWEo1SURFeENpQWdJQ0JpZFhKNUlERXhDaUFnSUNCa2FXY2dNakFLSUNBZ0lHSStQUW9nSUNBZ1lub2djbVYyWldGc1gzZG9hV3hsWDNSdmNFQXpOZ29nSUNBZ1pHbG5JREl5Q2lBZ0lDQmthV2NnTWpRS0lDQWdJR0lsQ2lBZ0lDQmthV2NnTWpJS0lDQWdJR0lyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JrYVdjZ01qRUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXlNUW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhOZ29nSUNBZ1lpQnlaWFpsWVd4ZlptOXlYMmhsWVdSbGNrQXpOQW9LY21WMlpXRnNYMlZzYzJWZlltOWtlVUF6TWpvS0lDQWdJR1JwWnlBeU1Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqd0tJQ0FnSUdGemMyVnlkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhOM1lYQUtJQ0FnSUdJdENpQWdJQ0JpZFhKNUlESTBDaUFnSUNCaUlISmxkbVZoYkY5aFpuUmxjbDlwWmw5bGJITmxRRE16Q2dweVpYWmxZV3hmWVdaMFpYSmZabTl5UURJeE9nb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QTBDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtVjJaV0ZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNak1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV4Q2lBZ0lDQWxDaUFnSUNCc2IyRmtjd29nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ2JHbHVaV0Z5WDNObFlYSmphQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTkNBMENpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXhPQW9LY21WMlpXRnNYMkZtZEdWeVgybG1YMlZzYzJWQU1qTTZDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF5TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WMlpXRnNYM1JsY201aGNubGZabUZzYzJWQU1UTTZDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR0oxY25rZ01URUtJQ0FnSUdJZ2NtVjJaV0ZzWDNSbGNtNWhjbmxmYldWeVoyVkFNVFFLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBTUFRQ3QvdFhrMUlYOXFGZ2cvLy8vL3cvUGdwNjc3Ky9lZ2hUUmdwNjc3Ky9lZ2hUVGdwNjc3Ky9lZ2hUVmdwNjc3Ky9lZ2hRQUFBQW1CZ0FFRlI5OGRRcGpiMjF0YVhSdFpXNTBBUUVDQUFBUkFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBeEcwRUFWWUlDQkZCeVE0UUVNODRSNnpZYUFJNENBRElBSkRFWkZFUXhHRVNDQXdSNjZ5TTlCT1R2NWY4RVdZSjBWVFlhQUk0REFjZ0IwUUhhQUNJeEdaQ0JCUm94R0JCRVFnTEpJakVaa0lFREdqRVlFRVJDQWNZeEdZMEdBQmYvMC8vVC85TUFEQUFCQURFWVJERUFNZ2tTUkNKRE1SaEVNUUF5Q1JKRUlrTXhHQlJEaWdRRmkvd2tIVVVCSVFVZVJRRkpGQ0VHVEpDTC9TUWRSUUVlUlFGSkZDRUhUSkNML2lRZFJRRWVSUUZKRkNFSVRKQ0wveVFkUlFFZVJRR0wvSUVTa1l2OEc0RWJrU0VFR292OGdUdVJTcEZNSENJZVJRR0JIeHBQQWt5UUlRUWFHU1dRaS8yQkVwR0wvUnVCRzVFaEJCcUwvWUU3a1VxUlRCd2lIa1VCZ1I4YVR3Sk1rQ0VFR2hrWkZvditnUktSaS80YmdSdVJJUVFhaS82Qk81RktrVXdjSWg1RkFZRWZHazhDVEpBaEJCb1pKWkNMLzRFU2tZdi9HNEVia1NFRUdvdi9nVHVSU3BGTUhDSWVSUUdCSHhwUEFreVFJUVFhR1JrV1VJbUtBZ0VvU1l2K2t5SUpTU0pNa0VtTC9oSkJBQWlMQW92L2tJd0FpU09NQVNPTUFJc0FpLzhNUVFBdml3RWlrSXdCaS81SkhZc0RsNHorZ1FLTEFwQ0wvZzVCQUF5TEFTSVpqQUdML2lLUmpQNkxBQ0lJakFCQy84bUxBb3Yva0lzQkdZd0FpWW9DQTR2K0ZTT0xBWXNBREVFQUo0ditpd0ZhaS84U1FRQVNpd0ZKZ1FRSWkvNU1XaUpPQWs4RVR3U0ppd0dCQ0FpTUFVTC8wU05IQWs4RVR3U0pJUW9XS1V4UXNDSkRJUWtXS1V4UXNDSkRJUXNXS1V4UXNDSkRLRWNITmhvQlNSVWlFa1EyR2dKSlRnSVZnUVFTUkRZYUEwbE9Ba2tWSWhKRVRCZEpUZ0loQ3c5RUYwbEJBTUpKZ1NNTVFRQzdJa1JMQXhkSlJRaEpnUUlQUkVzQlNVOENEa1NCMkFRTGdid0ZDaUlJUlFvalJReExDMHNLREVFQUZyRWhDYklZZ1FheUVDT3lBYk5MQ3lJSVJReEMvK0lpUlFralJRWkxCa2tpQ0VVR1N3RUpJZ2hGQzBzS1N3VU1RUUEyU3doTEN4MUZDVUFBQ1VzSGs0RkFFa0VBR1VzSWdSQ0kvcFZMQmdoRkJrc0tSUWxMQ2lJSVJRdEMvOHhMQ0VzTEMwVUpRdi90U3dpQkVJaitja3NHQ0lHQWdJQUVEa1F4RnpJR1N3TUlGbEJMQkZCTEExQXhBQ3BQQW1ZaVF5TkMvMElqUndZb1J3c3hBQ01xWTBReEFDcG9TWUVvV2t4SmdTeFZURElHU3dGWElBaExBaVZiVHdJT1JMRk1Wd0FnU1U0Q2dBSUFJRXhRSVFxeUdJQUVSOElNSTdJYVRMSWFzaHFCQnJJUUk3SUJzN1ErUndKWEFBUXBFa1JYQkFCSkkxbUJBZ2hNRlJKRUkwbUJDd3hCQUF0SEFpZy9JZ2hGQVVMLzdrc0RnZlFEQzRHOEJRb2lDRVVPSTBVUlN4QkxEZ3hCQUJheElRbXlHSUVHc2hBanNnR3pTeEFpQ0VVUlF2L2lTd05MQlF4QkFtbExBMFVMU3dGWEJnQkpGU1VTUkVrald5TWtIVVVCU1NFRkhrVUJUd0llUlFFa0hVVUJJUVVlVGdOSVN3R0JDRnRMQVNFR0hrVUJIa1VCSkIxRkFTRUdIazREU0VzQmdSQmJTd0VoQng1RkFSNUZBU1FkUlFFaEJ4NU9BMGhNZ1JoYlRDRUlIa1VCSGtVQkpCMUZBU0VJSGtVQkp3UkZGaU5NUlF0TVJRdE1SUXRNUlF0RkFVbExDd3hCQVpoSkZrbEZGMHNGRmtVVUp3UkZGaWlvUVFEVlN4SW9xRUVBemlORkVFc1BJZ3hCQURsTENVc0pTd2xMQ1lqOEEwNEVSUXRGQzBVTFJRdEpGWUVRRGtTQkVLK3JTeFZKSTFraUNCWlhCZ0JjQUV4UVJSVkxEeUlJUlJCQy84QkxGRmNDRUlFTVdrbEZEa3NCU1lFTEdENUxBWWo5QUU0Q1NFMUZFRW1CQ3hoSlJRZytTVTRDU3dHSS9PcE9Ba1VRVGdKTEFrMFdTWk1sRGtSWEJBUkxGRWtqV1NJSUZsY0dBRndBVEZCRkZFRUFIVXNNZ1FRSVN4QVdTWk1sRGtSWEJBUmRTd1pNUDBraUNFVUJRdjhzU3cwV1NaTWxEa1JYQkFSTEVCWkpreVVPUkZjRUJGQlFRdi9aU3hJb3FVRUFpVXNTU1N1bFJFa25CYVJFU1N1aFN4ZEpUd0trUktGRkdFc1hTYTRyb0lBUS8vLy8vLy8vLy8vLy8vLy8vLy8vLzZ4TXFrVVVJMFVRU3c4aURFSC9MMHNKU3dsTENVc0ppUHI1U1U0RlJSeEZDMFVMUlF0RkMwc1VwMEgvNGtzV1N4aXFTeGFnU1JXQkVBNUVnUkN2cTBzVlNTTlpJZ2dXVndZQVhBQk1VRVVWU3c4aUNFVVFRdit2U3hWSmdCQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQXBFUW5CVXloUlJoQy8yOUxCRXNFRWtFQUxFc0RJZ2xKZ1FzWVBrc0JpUHZHVGdKSVRSWkpreVVPUkZjRUJFc1NTU05aSWdnV1Z3WUFYQUJNVUVVU1N3S0FBZ0FpVUVzU1VDbE1VTEFpUTBzRElnbEZDMEw5a2c9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlZFUklGSUFCTEVfU0hVRkZMRV9PUFVQIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH0sIlJBTkRPTU5FU1NfQkVBQ09OIjp7InR5cGUiOiJBVk1VaW50NjQiLCJ2YWx1ZSI6bnVsbH0sIlNBRkVUWV9ST1VORF9HQVAiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
