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

namespace Arc56.Generated.ogsamrat.a2a_ecommerce.ZKCommitment_1fe29404
{


    public class ZKCommitmentProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ZKCommitmentProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CommitmentRecord : AVMObjectType
            {
                public Algorand.Address Committer { get; set; }

                public ulong CreatedRound { get; set; }

                public ulong IsRevealed { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCommitter.From(Committer);
                    ret.AddRange(vCommitter.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedRound.From(CreatedRound);
                    ret.AddRange(vCreatedRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsRevealed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIsRevealed.From(IsRevealed);
                    ret.AddRange(vIsRevealed.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CommitmentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CommitmentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCommitter.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitter = vCommitter.ToValue();
                    if (valueCommitter is Algorand.Address vCommitterValue) { ret.Committer = vCommitterValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedRound = vCreatedRound.ToValue();
                    if (valueCreatedRound is ulong vCreatedRoundValue) { ret.CreatedRound = vCreatedRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsRevealed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIsRevealed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsRevealed = vIsRevealed.ToValue();
                    if (valueIsRevealed is ulong vIsRevealedValue) { ret.IsRevealed = vIsRevealedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CommitmentRecord);
                }
                public bool Equals(CommitmentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CommitmentRecord left, CommitmentRecord right)
                {
                    return EqualityComparer<CommitmentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(CommitmentRecord left, CommitmentRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Store a commitment hash on-chain.
        ///The commitment is SHA-256(secret|seller|price|desc) computed off-chain.
        ///The seller sends the 32-byte hash; the contract stores it.
        ///</summary>
        /// <param name="commitmentHash"> </param>
        public async Task Commit(byte[] commitmentHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 73, 37, 115 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);

            var result = await base.CallApp(new List<object> { abiHandle, commitmentHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Commit_Transactions(byte[] commitmentHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 73, 37, 115 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, commitmentHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reveal and verify a commitment on-chain.
        ///The caller provides the preimage; the contract computes SHA-256 on-chain
        ///and asserts it matches the stored commitment hash.
        ///</summary>
        /// <param name="commitmentHash"> </param>
        /// <param name="preimage"> </param>
        public async Task Reveal(byte[] commitmentHash, byte[] preimage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 135, 4, 146 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);
            var preimageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); preimageAbi.From(preimage);

            var result = await base.CallApp(new List<object> { abiHandle, commitmentHashAbi, preimageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Reveal_Transactions(byte[] commitmentHash, byte[] preimage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 135, 4, 146 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);
            var preimageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); preimageAbi.From(preimage);

            return await base.MakeTransactionList(new List<object> { abiHandle, commitmentHashAbi, preimageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a commitment exists and whether it has been revealed.
        ///Returns: 0 = not found, 1 = committed but not revealed, 2 = revealed & verified
        ///</summary>
        /// <param name="commitmentHash"> </param>
        public async Task<ulong> GetStatus(byte[] commitmentHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 237, 112, 134 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);

            var result = await base.SimApp(new List<object> { abiHandle, commitmentHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStatus_Transactions(byte[] commitmentHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 237, 112, 134 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, commitmentHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="commitmentHash"> </param>
        public async Task<Algorand.Address> GetCommitter(byte[] commitmentHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 219, 203, 109 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);

            var result = await base.SimApp(new List<object> { abiHandle, commitmentHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetCommitter_Transactions(byte[] commitmentHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 219, 203, 109 };
            var commitmentHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); commitmentHashAbi.From(commitmentHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, commitmentHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetCommitCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 85, 229, 83 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCommitCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 85, 229, 83 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetRevealCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 114, 62, 11 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRevealCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 114, 62, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWktDb21taXRtZW50IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNvbW1pdG1lbnRSZWNvcmQiOlt7Im5hbWUiOiJjb21taXR0ZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImNyZWF0ZWRSb3VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc1JldmVhbGVkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21taXQiLCJkZXNjIjoiU3RvcmUgYSBjb21taXRtZW50IGhhc2ggb24tY2hhaW4uXG5UaGUgY29tbWl0bWVudCBpcyBTSEEtMjU2KHNlY3JldHxzZWxsZXJ8cHJpY2V8ZGVzYykgY29tcHV0ZWQgb2ZmLWNoYWluLlxuVGhlIHNlbGxlciBzZW5kcyB0aGUgMzItYnl0ZSBoYXNoOyB0aGUgY29udHJhY3Qgc3RvcmVzIGl0LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbW1pdG1lbnRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldmVhbCIsImRlc2MiOiJSZXZlYWwgYW5kIHZlcmlmeSBhIGNvbW1pdG1lbnQgb24tY2hhaW4uXG5UaGUgY2FsbGVyIHByb3ZpZGVzIHRoZSBwcmVpbWFnZTsgdGhlIGNvbnRyYWN0IGNvbXB1dGVzIFNIQS0yNTYgb24tY2hhaW5cbmFuZCBhc3NlcnRzIGl0IG1hdGNoZXMgdGhlIHN0b3JlZCBjb21taXRtZW50IGhhc2guIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWl0bWVudEhhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByZWltYWdlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN0YXR1cyIsImRlc2MiOiJDaGVjayBpZiBhIGNvbW1pdG1lbnQgZXhpc3RzIGFuZCB3aGV0aGVyIGl0IGhhcyBiZWVuIHJldmVhbGVkLlxuUmV0dXJuczogMCA9IG5vdCBmb3VuZCwgMSA9IGNvbW1pdHRlZCBidXQgbm90IHJldmVhbGVkLCAyID0gcmV2ZWFsZWQgJiB2ZXJpZmllZCIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbW1pdG1lbnRIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb21taXR0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb21taXRtZW50SGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldENvbW1pdENvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZXZlYWxDb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjQxXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSByZXZlYWxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Ml0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzhdLCJlcnJvck1lc3NhZ2UiOiJDb21taXRtZW50IGFscmVhZHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM0LDMyNF0sImVycm9yTWVzc2FnZSI6IkNvbW1pdG1lbnQgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgRGVsZXRlQXBwbGljYXRpb24gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0N10sImVycm9yTWVzc2FnZSI6IlNIQS0yNTYgbWlzbWF0Y2g6IHByZWltYWdlIGRvZXMgbm90IG1hdGNoIGNvbW1pdG1lbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjZdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkzLDI1NiwzMzksMzUwLDM2NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjksMjA4LDI3MSwzMTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUlEUXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmpiMjF0YVhSRGIzVnVkQ0lnSW5KbGRtVmhiRU52ZFc1MElpQWlZeUlnTUhneE5URm1OMk0zTlNBaVlXUnRhVzRpQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUdOdmJXMXBkRU52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTI5dGJXbDBRMjkxYm5RaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5YVMwTnZiVzFwZEcxbGJuUXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdjbVYyWldGc1EyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnlaWFpsWVd4RGIzVnVkQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldrdERiMjF0YVhSdFpXNTBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCYVMwTnZiVzFwZEcxbGJuUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lORGczWXpNeVl5QXZMeUJ0WlhSb2IyUWdJbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5a1pXeGxkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRnBMUTI5dGJXbDBiV1Z1ZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TkFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURnd05Ea3lOVGN6SURCNE56TTROekEwT1RJZ01IZzVOR1ZrTnpBNE5pQXdlREJrWkdKallqWmtJREI0TXpFMU5XVTFOVE1nTUhoak1UY3lNMlV3WWlBdkx5QnRaWFJvYjJRZ0ltTnZiVzFwZENoaWVYUmxXek15WFNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhabFlXd29ZbmwwWlZzek1sMHNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGTjBZWFIxY3loaWVYUmxXek15WFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRFTnZiVzFwZEhSbGNpaGllWFJsV3pNeVhTbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSm5aWFJEYjIxdGFYUkRiM1Z1ZENncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUlNaWFpsWVd4RGIzVnVkQ2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTI5dGJXbDBJSEpsZG1WaGJDQm5aWFJUZEdGMGRYTWdaMlYwUTI5dGJXbDBkR1Z5SUdkbGRFTnZiVzFwZEVOdmRXNTBJR2RsZEZKbGRtVmhiRU52ZFc1MENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QmFTME52YlcxcGRHMWxiblFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHVnljZ29LYldGcGJsOWtaV3hsZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSWtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SWlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWWlCa1pXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvNldrdERiMjF0YVhSdFpXNTBMbU55WldGMFpVRndjR3hwWTJGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxRWEJ3YkdsallYUnBiMjQ2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklHRmtiV2x1SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUIwYUdsekxtRmtiV2x1TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2pzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSk9iMDl3SWl3Z2IyNURjbVZoZEdVNklDSnlaWEYxYVhKbElpQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem82V2t0RGIyMXRhWFJ0Wlc1MExtTnZiVzFwZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnZiVzFwZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5YVMwTnZiVzFwZEcxbGJuUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdjSFZpYkdsaklHTnZiVzFwZENoamIyMXRhWFJ0Wlc1MFNHRnphRG9nWW5sMFpYTThNekkrS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1kyOXRiV2wwYldWdWRITWdQU0JDYjNoTllYQThZbmwwWlhNOE16SStMQ0JEYjIxdGFYUnRaVzUwVW1WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0ltTWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWXlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdVkyOXRiV2wwYldWdWRITW9ZMjl0YldsMGJXVnVkRWhoYzJncExtVjRhWE4wY3l3Z0lrTnZiVzFwZEcxbGJuUWdZV3h5WldGa2VTQmxlR2x6ZEhNaUtUc0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXRiV2wwYldWdWRDQmhiSEpsWVdSNUlHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QmpiMjF0YVhSMFpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUdOeVpXRjBaV1JTYjNWdVpEb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem8xTXkwMU53b2dJQ0FnTHk4Z1kyOXVjM1FnY21WamIzSmtPaUJEYjIxdGFYUnRaVzUwVW1WamIzSmtJRDBnZXdvZ0lDQWdMeThnSUNCamIyMXRhWFIwWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJR055WldGMFpXUlNiM1Z1WkRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQnBjMUpsZG1WaGJHVmtPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUI5T3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhSb2FYTXVZMjl0YldsMGJXVnVkSE1vWTI5dGJXbDBiV1Z1ZEVoaGMyZ3BMblpoYkhWbElEMGdZMnh2Ym1Vb2NtVmpiM0prS1RzS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnZEdocGN5NWpiMjF0YVhSRGIzVnVkQzUyWVd4MVpTQTlJSFJvYVhNdVkyOXRiV2wwUTI5MWJuUXVkbUZzZFdVZ0t5QlZhVzUwTmpRb01TazdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJqYjIxdGFYUkRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52YlcxcGRFTnZkVzUwSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QjBhR2x6TG1OdmJXMXBkRU52ZFc1MExuWmhiSFZsSUQwZ2RHaHBjeTVqYjIxdGFYUkRiM1Z1ZEM1MllXeDFaU0FySUZWcGJuUTJOQ2d4S1RzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJqYjIxdGFYUkRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52YlcxcGRFTnZkVzUwSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QjBhR2x6TG1OdmJXMXBkRU52ZFc1MExuWmhiSFZsSUQwZ2RHaHBjeTVqYjIxdGFYUkRiM1Z1ZEM1MllXeDFaU0FySUZWcGJuUTJOQ2d4S1RzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldrdERiMjF0YVhSdFpXNTBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJSEIxWW14cFl5QmpiMjF0YVhRb1kyOXRiV2wwYldWdWRFaGhjMmc2SUdKNWRHVnpQRE15UGlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvNldrdERiMjF0YVhSdFpXNTBMbkpsZG1WaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsZG1WaGJEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnY0hWaWJHbGpJSEpsZG1WaGJDaGpiMjF0YVhSdFpXNTBTR0Z6YURvZ1lubDBaWE04TXpJK0xDQndjbVZwYldGblpUb2dZbmwwWlhNcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1kyOXRiV2wwYldWdWRITWdQU0JDYjNoTllYQThZbmwwWlhNOE16SStMQ0JEYjIxdGFYUnRaVzUwVW1WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0ltTWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWXlJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVkyOXRiV2wwYldWdWRITW9ZMjl0YldsMGJXVnVkRWhoYzJncExtVjRhWE4wY3l3Z0lrTnZiVzFwZEcxbGJuUWdibTkwSUdadmRXNWtJaWs3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVOdmJXMXBkRzFsYm5RZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldrdERiMjF0YVhSdFpXNTBMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJR052Ym5OMElISmxZMjl5WkNBOUlHTnNiMjVsS0hSb2FYTXVZMjl0YldsMGJXVnVkSE1vWTI5dGJXbDBiV1Z1ZEVoaGMyZ3BMblpoYkhWbEtUc0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdGemMyVnlkQ2h5WldOdmNtUXVhWE5TWlhabFlXeGxaQ0E5UFQwZ1ZXbHVkRFkwS0RBcExDQWlRV3h5WldGa2VTQnlaWFpsWVd4bFpDSXBPd29nSUNBZ2FXNTBZMTh6SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2NtVmhaSGtnY21WMlpXRnNaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z1kyOXVjM1FnWTI5dGNIVjBaV1E2SUdKNWRHVnpQRE15UGlBOUlHOXdMbk5vWVRJMU5paHdjbVZwYldGblpTazdDaUFnSUNCemQyRndDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dOdmJYQjFkR1ZrSUQwOVBTQmpiMjF0YVhSdFpXNTBTR0Z6YUN3Z0lsTklRUzB5TlRZZ2JXbHpiV0YwWTJnNklIQnlaV2x0WVdkbElHUnZaWE1nYm05MElHMWhkR05vSUdOdmJXMXBkRzFsYm5RaUtUc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRTRUV0TWpVMklHMXBjMjFoZEdOb09pQndjbVZwYldGblpTQmtiMlZ6SUc1dmRDQnRZWFJqYUNCamIyMXRhWFJ0Wlc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldrdERiMjF0YVhSdFpXNTBMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJSFZ3WkdGMFpXUXVhWE5TWlhabFlXeGxaQ0E5SUZWcGJuUTJOQ2d4S1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk56Y3ROemdLSUNBZ0lDOHZJSFZ3WkdGMFpXUXVhWE5TWlhabFlXeGxaQ0E5SUZWcGJuUTJOQ2d4S1RzS0lDQWdJQzh2SUhSb2FYTXVZMjl0YldsMGJXVnVkSE1vWTI5dGJXbDBiV1Z1ZEVoaGMyZ3BMblpoYkhWbElEMGdZMnh2Ym1Vb2RYQmtZWFJsWkNrN0NpQWdJQ0JwYm5Salh6TWdMeThnTkRBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk56a0tJQ0FnSUM4dklIUm9hWE11Y21WMlpXRnNRMjkxYm5RdWRtRnNkV1VnUFNCMGFHbHpMbkpsZG1WaGJFTnZkVzUwTG5aaGJIVmxJQ3NnVldsdWREWTBLREVwT3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2NtVjJaV0ZzUTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKeVpYWmxZV3hEYjNWdWRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnZEdocGN5NXlaWFpsWVd4RGIzVnVkQzUyWVd4MVpTQTlJSFJvYVhNdWNtVjJaV0ZzUTI5MWJuUXVkbUZzZFdVZ0t5QlZhVzUwTmpRb01TazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2NtVjJaV0ZzUTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKeVpYWmxZV3hEYjNWdWRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnZEdocGN5NXlaWFpsWVd4RGIzVnVkQzUyWVd4MVpTQTlJSFJvYVhNdWNtVjJaV0ZzUTI5MWJuUXVkbUZzZFdVZ0t5QlZhVzUwTmpRb01TazdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMXBMUTI5dGJXbDBiV1Z1ZEM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCd2RXSnNhV01nY21WMlpXRnNLR052YlcxcGRHMWxiblJJWVhOb09pQmllWFJsY3p3ek1qNHNJSEJ5WldsdFlXZGxPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5YVMwTnZiVzFwZEcxbGJuUXVZV3huYnk1MGN6bzZXa3REYjIxdGFYUnRaVzUwTG1kbGRGTjBZWFIxYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRk4wWVhSMWN6b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5YVMwTnZiVzFwZEcxbGJuUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdZMjl0YldsMGJXVnVkSE1nUFNCQ2IzaE5ZWEE4WW5sMFpYTThNekkrTENCRGIyMXRhWFJ0Wlc1MFVtVmpiM0prUGloN0lHdGxlVkJ5WldacGVEb2dJbU1pSUgwcE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVl5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1amIyMXRhWFJ0Wlc1MGN5aGpiMjF0YVhSdFpXNTBTR0Z6YUNrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJuWlhSVGRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02T0RrS0lDQWdJQzh2SUhKbGRIVnliaUJWYVc1ME5qUW9NQ2s3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LWjJWMFUzUmhkSFZ6WDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMMXBMUTI5dGJXbDBiV1Z1ZEM1aGJHZHZMblJ6T2pwYVMwTnZiVzFwZEcxbGJuUXVaMlYwVTNSaGRIVnpRRFk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFUzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnY21WamIzSmtJRDBnWTJ4dmJtVW9kR2hwY3k1amIyMXRhWFJ0Wlc1MGN5aGpiMjF0YVhSdFpXNTBTR0Z6YUNrdWRtRnNkV1VwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QnBaaUFvY21WamIzSmtMbWx6VW1WMlpXRnNaV1FnUFQwOUlGVnBiblEyTkNneEtTa2dld29nSUNBZ2FXNTBZMTh6SUM4dklEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCblpYUlRkR0YwZFhOZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklISmxkSFZ5YmlCVmFXNTBOalFvTWlrN0NpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0lnWjJWMFUzUmhkSFZ6WDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMMXBMUTI5dGJXbDBiV1Z1ZEM1aGJHZHZMblJ6T2pwYVMwTnZiVzFwZEcxbGJuUXVaMlYwVTNSaGRIVnpRRFlLQ21kbGRGTjBZWFIxYzE5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklISmxkSFZ5YmlCVmFXNTBOalFvTVNrN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSWdaMlYwVTNSaGRIVnpYMkZtZEdWeVgybHViR2x1WldSZlkyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPanBhUzBOdmJXMXBkRzFsYm5RdVoyVjBVM1JoZEhWelFEWUtDZ292THlCamIyNTBjbUZqZEhNdldrdERiMjF0YVhSdFpXNTBMbUZzWjI4dWRITTZPbHBMUTI5dGJXbDBiV1Z1ZEM1blpYUkRiMjF0YVhSMFpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSRGIyMXRhWFIwWlhJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldrdERiMjF0YVhSdFpXNTBMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHTnZiVzFwZEcxbGJuUnpJRDBnUW05NFRXRndQR0o1ZEdWelBETXlQaXdnUTI5dGJXbDBiV1Z1ZEZKbFkyOXlaRDRvZXlCclpYbFFjbVZtYVhnNklDSmpJaUI5S1RzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem94TURBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtTnZiVzFwZEcxbGJuUnpLR052YlcxcGRHMWxiblJJWVhOb0tTNWxlR2x6ZEhNc0lDSkRiMjF0YVhSdFpXNTBJRzV2ZENCbWIzVnVaQ0lwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyMXRhWFJ0Wlc1MElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnY21WMGRYSnVJR05zYjI1bEtIUm9hWE11WTI5dGJXbDBiV1Z1ZEhNb1kyOXRiV2wwYldWdWRFaGhjMmdwTG5aaGJIVmxLUzVqYjIxdGFYUjBaWEk3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02T2xwTFEyOXRiV2wwYldWdWRDNW5aWFJEYjIxdGFYUkRiM1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRU52YlcxcGRFTnZkVzUwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qRXdOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WTI5dGJXbDBRMjkxYm5RdWRtRnNkV1U3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMXBMUTI5dGJXbDBiV1Z1ZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCamIyMXRhWFJEYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdmJXMXBkRU52ZFc1MElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxcExRMjl0YldsMGJXVnVkQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVkyOXRiV2wwUTI5MWJuUXVkbUZzZFdVN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFwTFEyOXRiV2wwYldWdWRDNWhiR2R2TG5Sek9qRXdOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMXBMUTI5dGJXbDBiV1Z1ZEM1aGJHZHZMblJ6T2pwYVMwTnZiVzFwZEcxbGJuUXVaMlYwVW1WMlpXRnNRMjkxYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJTWlhabFlXeERiM1Z1ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5YVMwTnZiVzFwZEcxbGJuUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG5KbGRtVmhiRU52ZFc1MExuWmhiSFZsT3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2NtVjJaV0ZzUTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKeVpYWmxZV3hEYjNWdWRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWFTME52YlcxcGRHMWxiblF1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuSmxkbVZoYkVOdmRXNTBMblpoYkhWbE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5YVMwTnZiVzFwZEcxbGJuUXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlhUzBOdmJXMXBkRzFsYm5RdVlXeG5ieTUwY3pvNldrdERiMjF0YVhSdFpXNTBMbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWc1pYUmxRWEJ3YkdsallYUnBiMjQ2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V2t0RGIyMXRhWFJ0Wlc1MExtRnNaMjh1ZEhNNk1URTJDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2hVZUc0c0lIc2djMlZ1WkdWeU9pQjBhR2x6TG1Ga2JXbHVMblpoYkhWbElIMHBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5YVMwTnZiVzFwZEcxbGJuUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwT3dvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXa3REYjIxdGFYUnRaVzUwTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaFVlRzRzSUhzZ2MyVnVaR1Z5T2lCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUgwcE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMXBMUTI5dGJXbDBiV1Z1ZEM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlpQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBZ0tDWUZDMk52YlcxcGRFTnZkVzUwQzNKbGRtVmhiRU52ZFc1MEFXTUVGUjk4ZFFWaFpHMXBiakVZUUFBR0tDTm5LU05uZ0FRa2g4TXNOaG9BamdFQVNURVpGRVF4R0VFQU1vSUdCSUJKSlhNRWM0Y0VrZ1NVN1hDR0JBM2J5MjBFTVZYbFV3VEJjajRMTmhvQWpnWUFJZ0JKQUlnQXRRRFFBTnNBZ0FTNFJIczJOaG9BamdFQURRQXhHWUVGRWpFWUVFUkNBTXNuQkRFQVp5SkROaG9CU1JVa0VrUXFURkJKdlVVQkZFUXhBQ01XVEVzQlVFeFF2eU1vWlVRaUNDaE1aeUpETmhvQlNSVWtFa1EyR2dKSkkxbUJBZ2hMQVJVU1JGY0NBQ3BMQWxCSnZVVUJSRW0rU0NWYkZFUk1BVThDRWtRaUZpVk11eU1wWlVRaUNDbE1aeUpETmhvQlNSVWtFa1FxVEZCSnZVVUJRQUFJSXhZclRGQ3dJa05KdmtRbFd5SVNRUUFGZ1FKQy8rb2lRdi9tTmhvQlNSVWtFa1FxVEZCSnZVVUJSTDVJVndBZ0sweFFzQ0pESXlobFJCWXJURkN3SWtNaktXVkVGaXRNVUxBaVF6RUFJeWNFWlVRU1JDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
