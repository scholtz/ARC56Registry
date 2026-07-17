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

namespace Arc56.Generated.sumit_bhagat_2004.NeuroChain.LiveProof_5c472100
{


    //
    // 
    //    LiveProof — on-chain knowledge proof anchoring.
    //    Stores cryptographic fingerprints of ideas and their
    //    AI semantic embeddings. Each proof is queryable by node_id.
    //    
    //
    public class LiveProofProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LiveProofProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ProofRecord : AVMObjectType
            {
                public string NodeId { get; set; }

                public string TextHash { get; set; }

                public string EmbeddingHash { get; set; }

                public ulong Timestamp { get; set; }

                public Algorand.Address Creator { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNodeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNodeId.From(NodeId);
                    stringRef[ret.Count] = vNodeId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTextHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTextHash.From(TextHash);
                    stringRef[ret.Count] = vTextHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEmbeddingHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEmbeddingHash.From(EmbeddingHash);
                    stringRef[ret.Count] = vEmbeddingHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProofRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProofRecord();
                    uint count = 0;
                    var indexNodeId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNodeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNodeId.Decode(bytes.Skip(indexNodeId + prefixOffset).ToArray());
                    var valueNodeId = vNodeId.ToValue();
                    if (valueNodeId is string vNodeIdValue) { ret.NodeId = vNodeIdValue; }
                    var indexTextHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTextHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTextHash.Decode(bytes.Skip(indexTextHash + prefixOffset).ToArray());
                    var valueTextHash = vTextHash.ToValue();
                    if (valueTextHash is string vTextHashValue) { ret.TextHash = vTextHashValue; }
                    var indexEmbeddingHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEmbeddingHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEmbeddingHash.Decode(bytes.Skip(indexEmbeddingHash + prefixOffset).ToArray());
                    var valueEmbeddingHash = vEmbeddingHash.ToValue();
                    if (valueEmbeddingHash is string vEmbeddingHashValue) { ret.EmbeddingHash = vEmbeddingHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProofRecord);
                }
                public bool Equals(ProofRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProofRecord left, ProofRecord right)
                {
                    return EqualityComparer<ProofRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ProofRecord left, ProofRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploy contract. Called once by creator.
        ///</summary>
        public async Task Initialize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 44, 147, 205 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 44, 147, 205 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Anchor a knowledge node proof on-chain.
        ///Anyone can anchor — the caller's address is recorded as creator. node_id must be unique.
        ///</summary>
        /// <param name="node_id"> </param>
        /// <param name="text_hash"> </param>
        /// <param name="embedding_hash"> </param>
        /// <param name="timestamp"> </param>
        public async Task AnchorProof(string node_id, string text_hash, string embedding_hash, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 149, 238, 38 };
            var node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); node_idAbi.From(node_id);
            var text_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); text_hashAbi.From(text_hash);
            var embedding_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); embedding_hashAbi.From(embedding_hash);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, node_idAbi, text_hashAbi, embedding_hashAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AnchorProof_Transactions(string node_id, string text_hash, string embedding_hash, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 149, 238, 38 };
            var node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); node_idAbi.From(node_id);
            var text_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); text_hashAbi.From(text_hash);
            var embedding_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); embedding_hashAbi.From(embedding_hash);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, node_idAbi, text_hashAbi, embedding_hashAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Fetch a proof record by node_id.
        ///Frontend calls this to display verification details.
        ///</summary>
        /// <param name="node_id"> </param>
        public async Task<Structs.ProofRecord> GetProof(string node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 184, 131, 91 };
            var node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); node_idAbi.From(node_id);

            var result = await base.SimApp(new List<object> { abiHandle, node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProofRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProof_Transactions(string node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 184, 131, 91 };
            var node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); node_idAbi.From(node_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a proof exists without fetching the full record.
        ///</summary>
        /// <param name="node_id"> </param>
        public async Task<bool> ProofExists(string node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 254, 91, 36 };
            var node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); node_idAbi.From(node_id);

            var result = await base.SimApp(new List<object> { abiHandle, node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProofExists_Transactions(string node_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 254, 91, 36 };
            var node_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); node_idAbi.From(node_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, node_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return total number of proofs anchored.
        ///</summary>
        public async Task<ulong> GetTotalProofs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 130, 214, 16 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalProofs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 130, 214, 16 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGl2ZVByb29mIiwiZGVzYyI6IlxuICAgIExpdmVQcm9vZiDigJQgb24tY2hhaW4ga25vd2xlZGdlIHByb29mIGFuY2hvcmluZy5cbiAgICBTdG9yZXMgY3J5cHRvZ3JhcGhpYyBmaW5nZXJwcmludHMgb2YgaWRlYXMgYW5kIHRoZWlyXG4gICAgQUkgc2VtYW50aWMgZW1iZWRkaW5ncy4gRWFjaCBwcm9vZiBpcyBxdWVyeWFibGUgYnkgbm9kZV9pZC5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJvb2ZSZWNvcmQiOlt7Im5hbWUiOiJub2RlX2lkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRleHRfaGFzaCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJlbWJlZGRpbmdfaGFzaCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ0aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3JlYXRvciIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiRGVwbG95IGNvbnRyYWN0LiBDYWxsZWQgb25jZSBieSBjcmVhdG9yLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbmNob3JfcHJvb2YiLCJkZXNjIjoiQW5jaG9yIGEga25vd2xlZGdlIG5vZGUgcHJvb2Ygb24tY2hhaW4uXG5BbnlvbmUgY2FuIGFuY2hvciDigJQgdGhlIGNhbGxlcidzIGFkZHJlc3MgaXMgcmVjb3JkZWQgYXMgY3JlYXRvci4gbm9kZV9pZCBtdXN0IGJlIHVuaXF1ZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9kZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGV4dF9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbWJlZGRpbmdfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wcm9vZiIsImRlc2MiOiJGZXRjaCBhIHByb29mIHJlY29yZCBieSBub2RlX2lkLlxuRnJvbnRlbmQgY2FsbHMgdGhpcyB0byBkaXNwbGF5IHZlcmlmaWNhdGlvbiBkZXRhaWxzLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub2RlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsc3RyaW5nLHN0cmluZyx1aW50NjQsYWRkcmVzcykiLCJzdHJ1Y3QiOiJQcm9vZlJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvb2ZfZXhpc3RzIiwiZGVzYyI6IkNoZWNrIGlmIGEgcHJvb2YgZXhpc3RzIHdpdGhvdXQgZmV0Y2hpbmcgdGhlIGZ1bGwgcmVjb3JkLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub2RlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX3Byb29mcyIsImRlc2MiOiJSZXR1cm4gdG90YWwgbnVtYmVyIG9mIHByb29mcyBhbmNob3JlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTYyXSwiZXJyb3JNZXNzYWdlIjoiUHJvb2YgYWxyZWFkeSBhbmNob3JlZCBmb3IgdGhpcyBub2RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUwXSwiZXJyb3JNZXNzYWdlIjoiUHJvb2Ygbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIyLDI5NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcHJvb2ZzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3Ml0sImVycm9yTWVzc2FnZSI6ImVtYmVkZGluZ19oYXNoIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNCwxMjAsMTM2LDIzNSwyNjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQsMTMwLDE0MywyNDIsMjcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6InRleHRfaGFzaCBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHOTBZV3dpSUNKd1h5SWdNSGd4TlRGbU4yTTNOU0F3ZURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpYVnliMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakl3Q2lBZ0lDQXZMeUJqYkdGemN5Qk1hWFpsVUhKdmIyWW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVEFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhtTlRrMVpXVXlOaUF3ZURka1lqZzRNelZpSURCNFltRm1aVFZpTWpRZ01IZzBOamd5WkRZeE1DQXZMeUJ0WlhSb2IyUWdJbUZ1WTJodmNsOXdjbTl2WmloemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzQnliMjltS0hOMGNtbHVaeWtvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwTEdGa1pISmxjM01wSWl3Z2JXVjBhRzlrSUNKd2NtOXZabDlsZUdsemRITW9jM1J5YVc1bktXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGOTBiM1JoYkY5d2NtOXZabk1vS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdGdVkyaHZjbDl3Y205dlppQm5aWFJmY0hKdmIyWWdjSEp2YjJaZlpYaHBjM1J6SUdkbGRGOTBiM1JoYkY5d2NtOXZabk1LSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WlhWeWIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSXdDaUFnSUNBdkx5QmpiR0Z6Y3lCTWFYWmxVSEp2YjJZb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1prTW1NNU0yTmtJQzh2SUcxbGRHaHZaQ0FpYVc1cGRHbGhiR2w2WlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdsdWFYUnBZV3hwZW1VS0lDQWdJR1Z5Y2dvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVaWFZ5YjJOb1lXbHVMbU52Ym5SeVlXTjBMa3hwZG1WUWNtOXZaaTVwYm1sMGFXRnNhWHBsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNXBkR2xoYkdsNlpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpYVnliMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNCeWIyOW1jeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd3aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WlhWeWIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qTTJDaUFnSUNBdkx5QnpaV3htTG05M2JtVnlMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2NIVnphR0o1ZEdWeklDSnZkMjVsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVYxY205amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRvek1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHNJR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG01bGRYSnZZMmhoYVc0dVkyOXVkSEpoWTNRdVRHbDJaVkJ5YjI5bUxtRnVZMmh2Y2w5d2NtOXZabHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GdVkyaHZjbDl3Y205dlpqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpYVnliMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpYVnliMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPalV4Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTlrWlY5cFpDQnViM1FnYVc0Z2MyVnNaaTV3Y205dlpuTXNJQ0pRY205dlppQmhiSEpsWVdSNUlHRnVZMmh2Y21Wa0lHWnZjaUIwYUdseklHNXZaR1VpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3WHlJS0lDQWdJR1JwWnlBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1VISnZiMllnWVd4eVpXRmtlU0JoYm1Ob2IzSmxaQ0JtYjNJZ2RHaHBjeUJ1YjJSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WMWNtOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdZWE56WlhKMElHRnlZelF1VTNSeWFXNW5LQ0lpS1NBaFBTQjBaWGgwWDJoaGMyZ3NJQ0owWlhoMFgyaGhjMmdnWTJGdWJtOTBJR0psSUdWdGNIUjVJZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3TURBS0lDQWdJR1JwWnlBMUNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJSFJsZUhSZmFHRnphQ0JqWVc1dWIzUWdZbVVnWlcxd2RIa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZibVYxY205amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdGeVl6UXVVM1J5YVc1bktDSWlLU0FoUFNCbGJXSmxaR1JwYm1kZmFHRnphQ3dnSW1WdFltVmtaR2x1WjE5b1lYTm9JR05oYm01dmRDQmlaU0JsYlhCMGVTSUtJQ0FnSUdScFp5QXpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWdFltVmtaR2x1WjE5b1lYTm9JR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bGRYSnZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJR055WldGMGIzSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsZFhKdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk5UVXROakVLSUNBZ0lDOHZJSE5sYkdZdWNISnZiMlp6VzI1dlpHVmZhV1JkSUQwZ1VISnZiMlpTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYm05a1pWOXBaRDF1YjJSbFgybGtMQW9nSUNBZ0x5OGdJQ0FnSUhSbGVIUmZhR0Z6YUQxMFpYaDBYMmhoYzJnc0NpQWdJQ0F2THlBZ0lDQWdaVzFpWldSa2FXNW5YMmhoYzJnOVpXMWlaV1JrYVc1blgyaGhjMmdzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BYUnBiV1Z6ZEdGdGNDd0tJQ0FnSUM4dklDQWdJQ0JqY21WaGRHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTkRZS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeVpRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaWFZ5YjJOb1lXbHVMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzQnliMjltY3k1MllXeDFaU0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXdjbTl2Wm5NZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjVsZFhKdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXVaWFZ5YjJOb1lXbHVMbU52Ym5SeVlXTjBMa3hwZG1WUWNtOXZaaTVuWlhSZmNISnZiMlpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjSEp2YjJZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ym1WMWNtOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVjFjbTlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnWVhOelpYSjBJRzV2WkdWZmFXUWdhVzRnYzJWc1ppNXdjbTl2Wm5Nc0lDSlFjbTl2WmlCdWIzUWdabTkxYm1RaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd1h5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJRY205dlppQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpYVnliMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1d2NtOXZabk5iYm05a1pWOXBaRjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXVaWFZ5YjJOb1lXbHVMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ym1WMWNtOWphR0ZwYmk1amIyNTBjbUZqZEM1TWFYWmxVSEp2YjJZdWNISnZiMlpmWlhocGMzUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0hKdmIyWmZaWGhwYzNSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI1bGRYSnZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZOelFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyNWxkWEp2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvYm05a1pWOXBaQ0JwYmlCelpXeG1MbkJ5YjI5bWN5a0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQmZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl1WlhWeWIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJtVjFjbTlqYUdGcGJpNWpiMjUwY21GamRDNU1hWFpsVUhKdmIyWXVaMlYwWDNSdmRHRnNYM0J5YjI5bWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5MGIzUmhiRjl3Y205dlpuTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJtVjFjbTlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZmNISnZiMlp6TG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNCeWIyOW1jeUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dVpYVnliMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVDSmdRRmRHOTBZV3dDY0Y4RUZSOThkUUlBQURFWkZFUXhHRUVBSklJRUJQV1Y3aVlFZmJpRFd3UzYvbHNrQkVhQzFoQTJHZ0NPQkFBZUFLRUF2Z0RlQUlBRS9TeVR6VFlhQUk0QkFBRUFLQ0puZ0FWdmQyNWxjakVBWnlORE5ob0JTU0paSkFoTEFSVkpUd0lTUkRZYUFra2lXU1FJU3dFVlNVOENFa1EyR2dOSklsa2tDRXNCRlJKRU5ob0VTUldCQ0JKRUtVc0dVRW05UlFFVVJDdExCUk5FSzBzREUwUXhBSUV1VHdjSVNSWlhCZ0tBQWdBdVRGQk1Ud1lJRmxjR0FsQlBBMUJNVUU4RVVFOERVRThDVUVzQnZFaS9JaWhsUkNNSUtFeG5JME0yR2dGSklsa2tDRXNCRlJKRUtVeFFTYjFGQVVTK1NDcE1VTEFqUXpZYUFVa2lXU1FJU3dFVkVrUXBURkM5UlFHQUFRQWlUd0pVS2t4UXNDTkRJaWhsUkJZcVRGQ3dJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
