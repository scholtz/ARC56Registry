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

namespace Arc56.Generated.aryarahimi1.proof_of_handshake.HandshakeContract_b06dfc88
{


    public class HandshakeContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HandshakeContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class HandshakeRecord : AVMObjectType
            {
                public ulong HandshakeId { get; set; }

                public Algorand.Address Initiator { get; set; }

                public Algorand.Address Receiver { get; set; }

                public ulong Timestamp { get; set; }

                public string Note { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHandshakeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHandshakeId.From(HandshakeId);
                    ret.AddRange(vHandshakeId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitiator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vInitiator.From(Initiator);
                    ret.AddRange(vInitiator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNote.From(Note);
                    stringRef[ret.Count] = vNote.Encode();
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

                public static HandshakeRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new HandshakeRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHandshakeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHandshakeId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHandshakeId = vHandshakeId.ToValue();
                    if (valueHandshakeId is ulong vHandshakeIdValue) { ret.HandshakeId = vHandshakeIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitiator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vInitiator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitiator = vInitiator.ToValue();
                    if (valueInitiator is Algorand.Address vInitiatorValue) { ret.Initiator = vInitiatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is Algorand.Address vReceiverValue) { ret.Receiver = vReceiverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    var indexNote = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNote.Decode(bytes.Skip(indexNote + prefixOffset).ToArray());
                    var valueNote = vNote.ToValue();
                    if (valueNote is string vNoteValue) { ret.Note = vNoteValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as HandshakeRecord);
                }
                public bool Equals(HandshakeRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(HandshakeRecord left, HandshakeRecord right)
                {
                    return EqualityComparer<HandshakeRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(HandshakeRecord left, HandshakeRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="other_user"> </param>
        /// <param name="note"> </param>
        public async Task<ulong> CreateHandshake(Algorand.Address other_user, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 38, 197, 204 };
            var other_userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); other_userAbi.From(other_user);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            var result = await base.CallApp(new List<object> { abiHandle, other_userAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateHandshake_Transactions(Algorand.Address other_user, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 38, 197, 204 };
            var other_userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); other_userAbi.From(other_user);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            return await base.MakeTransactionList(new List<object> { abiHandle, other_userAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the note of an existing handshake (only by participants)
        ///</summary>
        /// <param name="handshake_id"> </param>
        /// <param name="new_note"> </param>
        public async Task UpdateHandshakeNote(ulong handshake_id, string new_note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 133, 118, 177 };
            var handshake_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); handshake_idAbi.From(handshake_id);
            var new_noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_noteAbi.From(new_note);

            var result = await base.CallApp(new List<object> { abiHandle, handshake_idAbi, new_noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateHandshakeNote_Transactions(ulong handshake_id, string new_note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 133, 118, 177 };
            var handshake_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); handshake_idAbi.From(handshake_id);
            var new_noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_noteAbi.From(new_note);

            return await base.MakeTransactionList(new List<object> { abiHandle, handshake_idAbi, new_noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetCounter(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 201, 55, 90 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCounter_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 201, 55, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="handshake_id"> </param>
        public async Task<Structs.HandshakeRecord> GetHandshake(ulong handshake_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 6, 183, 238 };
            var handshake_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); handshake_idAbi.From(handshake_id);

            var result = await base.CallApp(new List<object> { abiHandle, handshake_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.HandshakeRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetHandshake_Transactions(ulong handshake_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 6, 183, 238 };
            var handshake_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); handshake_idAbi.From(handshake_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, handshake_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///NEW: Get all handshake IDs for a specific user
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong[]> GetUserHandshakes(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 53, 253, 213 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetUserHandshakes_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 53, 253, 213 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGFuZHNoYWtlQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSGFuZHNoYWtlUmVjb3JkIjpbeyJuYW1lIjoiaGFuZHNoYWtlX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImluaXRpYXRvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVjZWl2ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJub3RlIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfaGFuZHNoYWtlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvdGhlcl91c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2hhbmRzaGFrZV9ub3RlIiwiZGVzYyI6IlVwZGF0ZSB0aGUgbm90ZSBvZiBhbiBleGlzdGluZyBoYW5kc2hha2UgKG9ubHkgYnkgcGFydGljaXBhbnRzKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoYW5kc2hha2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19ub3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jb3VudGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2hhbmRzaGFrZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoYW5kc2hha2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJIYW5kc2hha2VSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9oYW5kc2hha2VzIiwiZGVzYyI6Ik5FVzogR2V0IGFsbCBoYW5kc2hha2UgSURzIGZvciBhIHNwZWNpZmljIHVzZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzkyLDQwNCw0MTgsNDIzLDQyOF0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0LDEzMywxNTIsMTY4LDE4Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNywxMzYsMTU1LDE3MSwxODldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxLDQ2Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY291bnRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTEsNDc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5oYW5kc2hha2VzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MywzMTgsNDk1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51c2VyX2hhbmRzaGFrZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhR0Z1WkhOb1lXdGxMbU52Ym5SeVlXTjBMa2hoYm1SemFHRnJaVU52Ym5SeVlXTjBMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUNBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKamIzVnVkR1Z5SWlBd2VERTFNV1kzWXpjMUlDSm9ZVzVrYzJoaGEyVnpJaUFpZFhObGNsOW9ZVzVrYzJoaGEyVnpJaUF3ZURBd05USWdNSGd3TURBeENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pFekNpQWdJQ0F2THlCelpXeG1MbU52ZFc1MFpYSWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52ZFc1MFpYSWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRveE1Rb2dJQ0FnTHk4Z1kyeGhjM01nU0dGdVpITm9ZV3RsUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE5rTWpaak5XTmpJREI0TmpRNE5UYzJZakVnTUhoak9XTTVNemMxWVNBd2VEVTBNRFppTjJWbElEQjRaVFl6Tldaa1pEVWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZhR0Z1WkhOb1lXdGxLR0ZrWkhKbGMzTXNjM1J5YVc1bktYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsWDJoaGJtUnphR0ZyWlY5dWIzUmxLSFZwYm5RMk5DeHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyTnZkVzUwWlhJb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYMmhoYm1SemFHRnJaU2gxYVc1ME5qUXBLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRFkwTEhOMGNtbHVaeWtpTENCdFpYUm9iMlFnSW1kbGRGOTFjMlZ5WDJoaGJtUnphR0ZyWlhNb1lXUmtjbVZ6Y3lsMWFXNTBOalJiWFNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxYMmhoYm1SemFHRnJaVjl5YjNWMFpVQTFJRzFoYVc1ZmRYQmtZWFJsWDJoaGJtUnphR0ZyWlY5dWIzUmxYM0p2ZFhSbFFEWWdiV0ZwYmw5blpYUmZZMjkxYm5SbGNsOXliM1YwWlVBM0lHMWhhVzVmWjJWMFgyaGhibVJ6YUdGclpWOXliM1YwWlVBNElHMWhhVzVmWjJWMFgzVnpaWEpmYUdGdVpITm9ZV3RsYzE5eWIzVjBaVUE1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QklZVzVrYzJoaGEyVkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRYTmxjbDlvWVc1a2MyaGhhMlZ6WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG94TVFvZ0lDQWdMeThnWTJ4aGMzTWdTR0Z1WkhOb1lXdGxRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZFhObGNsOW9ZVzVrYzJoaGEyVnpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjlvWVc1a2MyaGhhMlZmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QklZVzVrYzJoaGEyVkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjlvWVc1a2MyaGhhMlVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJOdmRXNTBaWEpmY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOWpiM1Z1ZEdWeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWd1pHRjBaVjlvWVc1a2MyaGhhMlZmYm05MFpWOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk1URUtJQ0FnSUM4dklHTnNZWE56SUVoaGJtUnphR0ZyWlVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPalkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnZFhCa1lYUmxYMmhoYm1SemFHRnJaVjl1YjNSbENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjlvWVc1a2MyaGhhMlZmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QklZVzVrYzJoaGEyVkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlY5b1lXNWtjMmhoYTJVS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG94TVFvZ0lDQWdMeThnWTJ4aGMzTWdTR0Z1WkhOb1lXdGxRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1oaGJtUnphR0ZyWlM1amIyNTBjbUZqZEM1SVlXNWtjMmhoYTJWRGIyNTBjbUZqZEM1amNtVmhkR1ZmYUdGdVpITm9ZV3RsS0c5MGFHVnlYM1Z6WlhJNklHSjVkR1Z6TENCdWIzUmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU55WldGMFpWOW9ZVzVrYzJoaGEyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPakUzTFRFNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCamNtVmhkR1ZmYUdGdVpITm9ZV3RsS0hObGJHWXNJRzkwYUdWeVgzVnpaWEk2SUdGeVl6UXVRV1JrY21WemN5d2dibTkwWlRvZ1lYSmpOQzVUZEhKcGJtY3BJQzArSUdGeVl6UXVWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pFNUxUSXdDaUFnSUNBdkx5QWpJRWRsZENCMGFHVWdZMkZzYkdWeUNpQWdJQ0F2THlCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pJMUxUSTJDaUFnSUNBdkx5QWpJRlpoYkdsa1lYUnBiMjQ2SUVOaGJpZDBJR2hoYm1SemFHRnJaU0I1YjNWeWMyVnNaZ29nSUNBZ0x5OGdZWE56WlhKMElITmxibVJsY2lBaFBTQnZkR2hsY2w5MWMyVnlYMjVoZEdsMlpRb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk1qZ3RNamtLSUNBZ0lDOHZJQ01nUjJWMElHTjFjbkpsYm5RZ2RHbHRaWE4wWVcxd0NpQWdJQ0F2THlCamRYSnlaVzUwWDNScGJXVWdQU0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUb3pNUzB6TWdvZ0lDQWdMeThnSXlCSFpXNWxjbUYwWlNCMWJtbHhkV1VnYUdGdVpITm9ZV3RsSUVsRUNpQWdJQ0F2THlCb1lXNWtjMmhoYTJWZmFXUWdQU0J6Wld4bUxtTnZkVzUwWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmRXNTBaWElnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZkVzUwWlhJZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TXpjS0lDQWdJQzh2SUdoaGJtUnphR0ZyWlY5cFpEMWhjbU0wTGxWSmJuUTJOQ2hvWVc1a2MyaGhhMlZmYVdRcExBb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUIwYVcxbGMzUmhiWEE5WVhKak5DNVZTVzUwTmpRb1kzVnljbVZ1ZEY5MGFXMWxLU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TXpVdE5ESUtJQ0FnSUM4dklDTWdRM0psWVhSbElHRnVaQ0J6ZEc5eVpTQm9ZVzVrYzJoaGEyVWdjbVZqYjNKa0lGZEpWRWdnVGs5VVJRb2dJQ0FnTHk4Z2FHRnVaSE5vWVd0bFgzSmxZMjl5WkNBOUlFaGhibVJ6YUdGclpWSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQm9ZVzVrYzJoaGEyVmZhV1E5WVhKak5DNVZTVzUwTmpRb2FHRnVaSE5vWVd0bFgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCcGJtbDBhV0YwYjNJOVlYSmpOQzVCWkdSeVpYTnpLSE5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YjNSb1pYSmZkWE5sY2l3S0lDQWdJQzh2SUNBZ0lDQjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvWTNWeWNtVnVkRjkwYVcxbEtTd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbFBXNXZkR1VnSUNNZ1RrVlhPaUJUZEc5eVpTQjBhR1VnYm05MFpRb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EVXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pRMExUUTFDaUFnSUNBdkx5QWpJRk4wYjNKbElIUm9aU0JvWVc1a2MyaGhhMlVnY21WamIzSmtDaUFnSUNBdkx5QnpaV3htTG1oaGJtUnphR0ZyWlhOYmFHRnVaSE5vWVd0bFgybGtYU0E5SUdoaGJtUnphR0ZyWlY5eVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSm9ZVzVrYzJoaGEyVnpJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pRM0xUUTRDaUFnSUNBdkx5QWpJRUZrWkNCMGJ5QnBibWwwYVdGMGIzSW5jeUJvWVc1a2MyaGhhMlVnYkdsemRBb2dJQ0FnTHk4Z2FXWWdjMlZ1WkdWeUlHbHVJSE5sYkdZdWRYTmxjbDlvWVc1a2MyaGhhMlZ6T2dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZFhObGNsOW9ZVzVrYzJoaGEyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1kzSmxZWFJsWDJoaGJtUnphR0ZyWlY5bGJITmxYMkp2WkhsQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdhVzVwZEdsaGRHOXlYMnhwYzNRZ1BTQnpaV3htTG5WelpYSmZhR0Z1WkhOb1lXdGxjMXR6Wlc1a1pYSmRMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRYTmxjbDlvWVc1a2MyaGhhMlZ6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdhVzVwZEdsaGRHOXlYMnhwYzNRdVlYQndaVzVrS0dGeVl6UXVWVWx1ZERZMEtHaGhibVJ6YUdGclpWOXBaQ2twQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F2Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pVeENpQWdJQ0F2THlCelpXeG1MblZ6WlhKZmFHRnVaSE5vWVd0bGMxdHpaVzVrWlhKZElEMGdhVzVwZEdsaGRHOXlYMnhwYzNRdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDZ3BqY21WaGRHVmZhR0Z1WkhOb1lXdGxYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZOVFl0TlRjS0lDQWdJQzh2SUNNZ1FXUmtJSFJ2SUhKbFkyVnBkbVZ5SjNNZ2FHRnVaSE5vWVd0bElHeHBjM1FLSUNBZ0lDOHZJR2xtSUc5MGFHVnlYM1Z6WlhKZmJtRjBhWFpsSUdsdUlITmxiR1l1ZFhObGNsOW9ZVzVrYzJoaGEyVnpPZ29nSUNBZ1lubDBaV05mTXlBdkx5QWlkWE5sY2w5b1lXNWtjMmhoYTJWeklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJqY21WaGRHVmZhR0Z1WkhOb1lXdGxYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCeVpXTmxhWFpsY2w5c2FYTjBJRDBnYzJWc1ppNTFjMlZ5WDJoaGJtUnphR0ZyWlhOYmIzUm9aWEpmZFhObGNsOXVZWFJwZG1WZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyVnlYMmhoYm1SemFHRnJaWE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnlaV05sYVhabGNsOXNhWE4wTG1Gd2NHVnVaQ2hoY21NMExsVkpiblEyTkNob1lXNWtjMmhoYTJWZmFXUXBLUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnYzJWc1ppNTFjMlZ5WDJoaGJtUnphR0ZyWlhOYmIzUm9aWEpmZFhObGNsOXVZWFJwZG1WZElEMGdjbVZqWldsMlpYSmZiR2x6ZEM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2hvWVc1a2MyaGhhMlZmYVdRcENpQWdJQ0J5WlhSemRXSUtDbU55WldGMFpWOW9ZVzVrYzJoaGEyVmZaV3h6WlY5aWIyUjVRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCdVpYZGZiR2x6ZENBOUlHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNUtHRnlZelF1VlVsdWREWTBLR2hoYm1SemFHRnJaVjlwWkNrcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQXdNUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG8yTXdvZ0lDQWdMeThnYzJWc1ppNTFjMlZ5WDJoaGJtUnphR0ZyWlhOYmIzUm9aWEpmZFhObGNsOXVZWFJwZG1WZElEMGdibVYzWDJ4cGMzUXVZMjl3ZVNncENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0doaGJtUnphR0ZyWlY5cFpDa0tJQ0FnSUhKbGRITjFZZ29LWTNKbFlYUmxYMmhoYm1SemFHRnJaVjlsYkhObFgySnZaSGxBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklHNWxkMTlzYVhOMElEMGdZWEpqTkM1RWVXNWhiV2xqUVhKeVlYa29ZWEpqTkM1VlNXNTBOalFvYUdGdVpITm9ZV3RsWDJsa0tTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNREF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCelpXeG1MblZ6WlhKZmFHRnVaSE5vWVd0bGMxdHpaVzVrWlhKZElEMGdibVYzWDJ4cGMzUXVZMjl3ZVNncENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdJZ1kzSmxZWFJsWDJoaGJtUnphR0ZyWlY5aFpuUmxjbDlwWmw5bGJITmxRRE1LQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFHRnVaSE5vWVd0bExtTnZiblJ5WVdOMExraGhibVJ6YUdGclpVTnZiblJ5WVdOMExuVndaR0YwWlY5b1lXNWtjMmhoYTJWZmJtOTBaU2hvWVc1a2MyaGhhMlZmYVdRNklHSjVkR1Z6TENCdVpYZGZibTkwWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVjlvWVc1a2MyaGhhMlZmYm05MFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZOamN0TmpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhWd1pHRjBaVjlvWVc1a2MyaGhhMlZmYm05MFpTaHpaV3htTENCb1lXNWtjMmhoYTJWZmFXUTZJR0Z5WXpRdVZVbHVkRFkwTENCdVpYZGZibTkwWlRvZ1lYSmpOQzVUZEhKcGJtY3BJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklITmxibVJsY2lBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvM01pMDNNd29nSUNBZ0x5OGdJeUJIWlhRZ1pYaHBjM1JwYm1jZ2FHRnVaSE5vWVd0bElIZHBkR2dnTG1OdmNIa29LUW9nSUNBZ0x5OGdhR0Z1WkhOb1lXdGxJRDBnYzJWc1ppNW9ZVzVrYzJoaGEyVnpXMmhoYm1SemFHRnJaVjlwWkM1dVlYUnBkbVZkTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklDSm9ZVzVrYzJoaGEyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YUdGdVpITm9ZV3RsY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZOelV0TnpZS0lDQWdJQzh2SUNNZ1QyNXNlU0JwYm1sMGFXRjBiM0lnYjNJZ2NtVmpaV2wyWlhJZ1kyRnVJSFZ3WkdGMFpTQnViM1JsQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZ1WkdWeUlEMDlJR2hoYm1SemFHRnJaUzVwYm1sMGFXRjBiM0l1Ym1GMGFYWmxJRzl5SUhObGJtUmxjaUE5UFNCb1lXNWtjMmhoYTJVdWNtVmpaV2wyWlhJdWJtRjBhWFpsQ2lBZ0lDQmxlSFJ5WVdOMElEZ2dNeklnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaWJub2dkWEJrWVhSbFgyaGhibVJ6YUdGclpWOXViM1JsWDJKdmIyeGZkSEoxWlVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaWGgwY21GamRDQTBNQ0F6TWlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RYQmtZWFJsWDJoaGJtUnphR0ZyWlY5dWIzUmxYMkp2YjJ4ZlptRnNjMlZBTXdvS2RYQmtZWFJsWDJoaGJtUnphR0ZyWlY5dWIzUmxYMkp2YjJ4ZmRISjFaVUF5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ25Wd1pHRjBaVjlvWVc1a2MyaGhhMlZmYm05MFpWOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pjMUxUYzJDaUFnSUNBdkx5QWpJRTl1YkhrZ2FXNXBkR2xoZEc5eUlHOXlJSEpsWTJWcGRtVnlJR05oYmlCMWNHUmhkR1VnYm05MFpRb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJtUmxjaUE5UFNCb1lXNWtjMmhoYTJVdWFXNXBkR2xoZEc5eUxtNWhkR2wyWlNCdmNpQnpaVzVrWlhJZ1BUMGdhR0Z1WkhOb1lXdGxMbkpsWTJWcGRtVnlMbTVoZEdsMlpRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJvWVc1a2MyaGhhMlZmYVdROWFHRnVaSE5vWVd0bExtaGhibVJ6YUdGclpWOXBaQ3dLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBNElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOWFHRnVaSE5vWVd0bExuSmxZMlZwZG1WeUxBb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTkRBZ016SWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlhR0Z1WkhOb1lXdGxMblJwYldWemRHRnRjQ3dLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0EzTWlBNElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvM09DMDROUW9nSUNBZ0x5OGdJeUJWY0dSaGRHVWdkR2hsSUc1dmRHVUtJQ0FnSUM4dklIVndaR0YwWldSZmFHRnVaSE5vWVd0bElEMGdTR0Z1WkhOb1lXdGxVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJR2hoYm1SemFHRnJaVjlwWkQxb1lXNWtjMmhoYTJVdWFHRnVaSE5vWVd0bFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUdsdWFYUnBZWFJ2Y2oxb1lXNWtjMmhoYTJVdWFXNXBkR2xoZEc5eUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQV2hoYm1SemFHRnJaUzV5WldObGFYWmxjaXdLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxjM1JoYlhBOWFHRnVaSE5vWVd0bExuUnBiV1Z6ZEdGdGNDd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbFBXNWxkMTl1YjNSbElDQWpJRlZ3WkdGMFpTQjNhWFJvSUc1bGR5QnViM1JsQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNRFV5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qZzNMVGc0Q2lBZ0lDQXZMeUFqSUZOMGIzSmxJSFZ3WkdGMFpXUWdjbVZqYjNKa0NpQWdJQ0F2THlCelpXeG1MbWhoYm1SemFHRnJaWE5iYUdGdVpITm9ZV3RsWDJsa0xtNWhkR2wyWlYwZ1BTQjFjR1JoZEdWa1gyaGhibVJ6YUdGclpTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ3AxY0dSaGRHVmZhR0Z1WkhOb1lXdGxYMjV2ZEdWZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2RYQmtZWFJsWDJoaGJtUnphR0ZyWlY5dWIzUmxYMkp2YjJ4ZmJXVnlaMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW9ZVzVrYzJoaGEyVXVZMjl1ZEhKaFkzUXVTR0Z1WkhOb1lXdGxRMjl1ZEhKaFkzUXVaMlYwWDJOdmRXNTBaWElvS1NBdFBpQmllWFJsY3pvS1oyVjBYMk52ZFc1MFpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWpiM1Z1ZEdWeUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdmRXNTBaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOTFiblJsY2lCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW9ZVzVrYzJoaGEyVXVZMjl1ZEhKaFkzUXVTR0Z1WkhOb1lXdGxRMjl1ZEhKaFkzUXVaMlYwWDJoaGJtUnphR0ZyWlNob1lXNWtjMmhoYTJWZmFXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwWDJoaGJtUnphR0ZyWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk9UUXRPVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5b1lXNWtjMmhoYTJVb2MyVnNaaXdnYUdGdVpITm9ZV3RsWDJsa09pQmhjbU0wTGxWSmJuUTJOQ2tnTFQ0Z1NHRnVaSE5vWVd0bFVtVmpiM0prT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPamsyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1b1lXNWtjMmhoYTJWelcyaGhibVJ6YUdGclpWOXBaQzV1WVhScGRtVmRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltaGhibVJ6YUdGclpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1oaGJtUnphR0ZyWlhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFHRnVaSE5vWVd0bExtTnZiblJ5WVdOMExraGhibVJ6YUdGclpVTnZiblJ5WVdOMExtZGxkRjkxYzJWeVgyaGhibVJ6YUdGclpYTW9kWE5sY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUmZkWE5sY2w5b1lXNWtjMmhoYTJWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzVPQzA1T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWjJWMFgzVnpaWEpmYUdGdVpITm9ZV3RsY3loelpXeG1MQ0IxYzJWeU9pQmhjbU0wTGtGa1pISmxjM01wSUMwK0lHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcyRnlZelF1VlVsdWREWTBYVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUb3hNREVLSUNBZ0lDOHZJR2xtSUhWelpYSXVibUYwYVhabElHbHVJSE5sYkdZdWRYTmxjbDlvWVc1a2MyaGhhMlZ6T2dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZFhObGNsOW9ZVzVrYzJoaGEyVnpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCblpYUmZkWE5sY2w5b1lXNWtjMmhoYTJWelgyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWRYTmxjbDlvWVc1a2MyaGhhMlZ6VzNWelpYSXVibUYwYVhabFhRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuVnpaWEpmYUdGdVpITm9ZV3RsY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LWjJWMFgzVnpaWEpmYUdGdVpITm9ZV3RsYzE5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZNVEEwTFRFd05Rb2dJQ0FnTHk4Z0l5QlNaWFIxY200Z1pXMXdkSGtnWVhKeVlYa2dhV1lnZFhObGNpQm9ZWE1nYm04Z2FHRnVaSE5vWVd0bGN3b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVWVWx1ZERZMFhTZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQVFBSUpnWUhZMjkxYm5SbGNnUVZIM3gxQ21oaGJtUnphR0ZyWlhNUGRYTmxjbDlvWVc1a2MyaGhhMlZ6QWdCU0FnQUJNUmhBQUFNb0kyY3hHMEVBaW9JRkJEMG14Y3dFWklWMnNRVEp5VGRhQkZRR3QrNEU1alg5MVRZYUFJNEZBRW9BT0FBb0FCVUFBaU5ETVJrVVJERVlSRFlhQVlnQllpbE1VTEFpUXpFWkZFUXhHRVEyR2dHSUFVSXBURkN3SWtNeEdSUkVNUmhFaUFFc0tVeFFzQ0pETVJrVVJERVlSRFlhQVRZYUFvZ0F1eUpETVJrVVJERVlSRFlhQVRZYUFvZ0FFU2xNVUxBaVF6RVpRUCtiTVJnVVJDSkRpZ0lCTVFCSmkvNFRSRElISXlobFJFa2lDQ2hNWnhaSlRnTk1Ga3NCU3dOUWkvNVFURkFuQkZDTC8xQXFUd0pRU2J4SVRMOHJURkJKdlVVQlFRQktpd0ZKdmtSWEFnQ0xBRkJKRlNRS0ZsY0dBa3hRU3dHOFNMOHJpLzVRU2IxRkFVRUFHVW0rUkZjQ0FJc0FVRWtWSkFvV1Z3WUNURkJMQWJ4SXY0a25CWXNBVUV4SnZFaE12NGtuQllzQVVJc0JTYnhJVEw5Qy84R0tBZ0F4QUVtTC9oY1dLa3hRU1U0Q3ZreEpUZ0pPQTBSWENDQkpUZ0lTUUFBTGl3SlhLQ0NMQUJKQkFDb2lSSXNDU1ZjQUNFc0JWeWdnVHdKWFNBaFBBb3NEVUU4Q1VFeFFKd1JRaS85UWl3Rkp2RWhNdjRralF2L1RJeWhsUkJhSmlnRUJpLzhYRmlwTVVMNUVpWW9CQVN1TC8xQkp2VVVCUVFBR2l3QytSRXlKZ0FJQUFFeUoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
