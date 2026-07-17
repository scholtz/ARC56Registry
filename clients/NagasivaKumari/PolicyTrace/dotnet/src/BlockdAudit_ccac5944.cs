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

namespace Arc56.Generated.NagasivaKumari.PolicyTrace.BlockdAudit_ccac5944
{


    public class BlockdAuditProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BlockdAuditProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AuditRecord : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public string UrlHash { get; set; }

                public ulong RiskScore { get; set; }

                public string IpfsCid { get; set; }

                public ulong Timestamp { get; set; }

                public ulong VouchCount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrlHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrlHash.From(UrlHash);
                    stringRef[ret.Count] = vUrlHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRiskScore.From(RiskScore);
                    ret.AddRange(vRiskScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsCid.From(IpfsCid);
                    stringRef[ret.Count] = vIpfsCid.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVouchCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVouchCount.From(VouchCount);
                    ret.AddRange(vVouchCount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AuditRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AuditRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    var indexUrlHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUrlHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUrlHash.Decode(bytes.Skip(indexUrlHash + prefixOffset).ToArray());
                    var valueUrlHash = vUrlHash.ToValue();
                    if (valueUrlHash is string vUrlHashValue) { ret.UrlHash = vUrlHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRiskScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRiskScore = vRiskScore.ToValue();
                    if (valueRiskScore is ulong vRiskScoreValue) { ret.RiskScore = vRiskScoreValue; }
                    var indexIpfsCid = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsCid.Decode(bytes.Skip(indexIpfsCid + prefixOffset).ToArray());
                    var valueIpfsCid = vIpfsCid.ToValue();
                    if (valueIpfsCid is string vIpfsCidValue) { ret.IpfsCid = vIpfsCidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVouchCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVouchCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVouchCount = vVouchCount.ToValue();
                    if (valueVouchCount is ulong vVouchCountValue) { ret.VouchCount = vVouchCountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AuditRecord);
                }
                public bool Equals(AuditRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AuditRecord left, AuditRecord right)
                {
                    return EqualityComparer<AuditRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(AuditRecord left, AuditRecord right)
                {
                    return !(left == right);
                }

            }

            public class UserProfile : AVMObjectType
            {
                public string Username { get; set; }

                public ulong IsWorking { get; set; }

                public ulong JoinedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUsername = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUsername.From(Username);
                    stringRef[ret.Count] = vUsername.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsWorking = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIsWorking.From(IsWorking);
                    ret.AddRange(vIsWorking.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJoinedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vJoinedAt.From(JoinedAt);
                    ret.AddRange(vJoinedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UserProfile Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new UserProfile();
                    uint count = 0;
                    var indexUsername = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUsername = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUsername.Decode(bytes.Skip(indexUsername + prefixOffset).ToArray());
                    var valueUsername = vUsername.ToValue();
                    if (valueUsername is string vUsernameValue) { ret.Username = vUsernameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsWorking = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIsWorking.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsWorking = vIsWorking.ToValue();
                    if (valueIsWorking is ulong vIsWorkingValue) { ret.IsWorking = vIsWorkingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJoinedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vJoinedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueJoinedAt = vJoinedAt.ToValue();
                    if (valueJoinedAt is ulong vJoinedAtValue) { ret.JoinedAt = vJoinedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UserProfile);
                }
                public bool Equals(UserProfile? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UserProfile left, UserProfile right)
                {
                    return EqualityComparer<UserProfile>.Default.Equals(left, right);
                }
                public static bool operator !=(UserProfile left, UserProfile right)
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
        ///Assign or revoke Expert status (Manager only).
        ///</summary>
        /// <param name="expert"> </param>
        /// <param name="is_expert"> </param>
        public async Task SetExpert(Algorand.Address expert, ulong is_expert, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 145, 98, 9 };
            var expertAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); expertAbi.From(expert);
            var is_expertAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); is_expertAbi.From(is_expert);

            var result = await base.CallApp(new List<object> { abiHandle, expertAbi, is_expertAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetExpert_Transactions(Algorand.Address expert, ulong is_expert, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 145, 98, 9 };
            var expertAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); expertAbi.From(expert);
            var is_expertAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); is_expertAbi.From(is_expert);

            return await base.MakeTransactionList(new List<object> { abiHandle, expertAbi, is_expertAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if an address is a verified expert.
        ///</summary>
        /// <param name="expert"> </param>
        public async Task<ulong> IsExpert(Algorand.Address expert, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 48, 18, 3 };
            var expertAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); expertAbi.From(expert);

            var result = await base.SimApp(new List<object> { abiHandle, expertAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsExpert_Transactions(Algorand.Address expert, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 48, 18, 3 };
            var expertAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); expertAbi.From(expert);

            return await base.MakeTransactionList(new List<object> { abiHandle, expertAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Expert adds their signature to an existing audit.
        ///</summary>
        /// <param name="scan_id"> </param>
        public async Task VouchForAudit(string scan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 102, 84, 129 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);

            var result = await base.CallApp(new List<object> { abiHandle, scan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VouchForAudit_Transactions(string scan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 102, 84, 129 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, scan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Anchor a privacy audit on-chain. If owner is Working, charge 1 ALGO.
        ///</summary>
        /// <param name="scan_id"> </param>
        /// <param name="owner"> </param>
        /// <param name="url_hash"> </param>
        /// <param name="risk_score"> </param>
        /// <param name="ipfs_cid"> </param>
        public async Task AnchorAudit(string scan_id, Algorand.Address owner, string url_hash, ulong risk_score, string ipfs_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 87, 64, 138 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var url_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); url_hashAbi.From(url_hash);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var ipfs_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_cidAbi.From(ipfs_cid);

            var result = await base.CallApp(new List<object> { abiHandle, scan_idAbi, ownerAbi, url_hashAbi, risk_scoreAbi, ipfs_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AnchorAudit_Transactions(string scan_id, Algorand.Address owner, string url_hash, ulong risk_score, string ipfs_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 87, 64, 138 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var url_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); url_hashAbi.From(url_hash);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var ipfs_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_cidAbi.From(ipfs_cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, scan_idAbi, ownerAbi, url_hashAbi, risk_scoreAbi, ipfs_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update a user's employment status (Manager only).
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="status"> </param>
        public async Task SetUserStatus(Algorand.Address user, ulong status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 91, 169, 223 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); statusAbi.From(status);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetUserStatus_Transactions(Algorand.Address user, ulong status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 91, 169, 223 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read a user's employment status.
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetUserStatus(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 6, 61, 219 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUserStatus_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 6, 61, 219 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set or update user profile on-chain. Caller is owner.
        ///</summary>
        /// <param name="username"> </param>
        public async Task SetProfile(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 34, 34, 99 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            var result = await base.CallApp(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetProfile_Transactions(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 34, 34, 99 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            return await base.MakeTransactionList(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve the on-chain user profile.
        ///</summary>
        /// <param name="user"> </param>
        public async Task<Structs.UserProfile> GetProfile(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 22, 71, 242 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.UserProfile.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProfile_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 22, 71, 242 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read total number of audits anchored.
        ///</summary>
        public async Task<ulong> GetTotalAudits(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 214, 229, 107 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalAudits_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 214, 229, 107 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve the on-chain audit record.
        ///</summary>
        /// <param name="scan_id"> </param>
        public async Task<Structs.AuditRecord> GetAudit(string scan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 166, 240, 245 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);

            var result = await base.SimApp(new List<object> { abiHandle, scan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AuditRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAudit_Transactions(string scan_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 166, 240, 245 };
            var scan_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scan_idAbi.From(scan_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, scan_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmxvY2tkQXVkaXQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQXVkaXRSZWNvcmQiOlt7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidXJsX2hhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmlza19zY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpcGZzX2NpZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ0aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidm91Y2hfY291bnQiLCJ0eXBlIjoidWludDY0In1dLCJVc2VyUHJvZmlsZSI6W3sibmFtZSI6InVzZXJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImlzX3dvcmtpbmciLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiam9pbmVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2V4cGVydCIsImRlc2MiOiJBc3NpZ24gb3IgcmV2b2tlIEV4cGVydCBzdGF0dXMgKE1hbmFnZXIgb25seSkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlcnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2V4cGVydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19leHBlcnQiLCJkZXNjIjoiQ2hlY2sgaWYgYW4gYWRkcmVzcyBpcyBhIHZlcmlmaWVkIGV4cGVydC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm91Y2hfZm9yX2F1ZGl0IiwiZGVzYyI6IkV4cGVydCBhZGRzIHRoZWlyIHNpZ25hdHVyZSB0byBhbiBleGlzdGluZyBhdWRpdC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2Nhbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhbmNob3JfYXVkaXQiLCJkZXNjIjoiQW5jaG9yIGEgcHJpdmFjeSBhdWRpdCBvbi1jaGFpbi4gSWYgb3duZXIgaXMgV29ya2luZywgY2hhcmdlIDEgQUxHTy4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2Nhbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cmxfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmlza19zY29yZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBmc19jaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3VzZXJfc3RhdHVzIiwiZGVzYyI6IlVwZGF0ZSBhIHVzZXIncyBlbXBsb3ltZW50IHN0YXR1cyAoTWFuYWdlciBvbmx5KS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXR1cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9zdGF0dXMiLCJkZXNjIjoiUmVhZCBhIHVzZXIncyBlbXBsb3ltZW50IHN0YXR1cy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9wcm9maWxlIiwiZGVzYyI6IlNldCBvciB1cGRhdGUgdXNlciBwcm9maWxlIG9uLWNoYWluLiBDYWxsZXIgaXMgb3duZXIuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wcm9maWxlIiwiZGVzYyI6IlJldHJpZXZlIHRoZSBvbi1jaGFpbiB1c2VyIHByb2ZpbGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJVc2VyUHJvZmlsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX2F1ZGl0cyIsImRlc2MiOiJSZWFkIHRvdGFsIG51bWJlciBvZiBhdWRpdHMgYW5jaG9yZWQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXVkaXQiLCJkZXNjIjoiUmV0cmlldmUgdGhlIG9uLWNoYWluIGF1ZGl0IHJlY29yZC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2Nhbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyxzdHJpbmcsdWludDY0LHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkF1ZGl0UmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUxNl0sImVycm9yTWVzc2FnZSI6IkFwcCBjYWxsIG11c3QgYmUgc2Vjb25kIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk2XSwiZXJyb3JNZXNzYWdlIjoiQXVkaXQgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTAsODE2XSwiZXJyb3JNZXNzYWdlIjoiQXVkaXQgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ1XSwiZXJyb3JNZXNzYWdlIjoiRmVlIG11c3QgYmUgYXQgbGVhc3QgMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI5XSwiZXJyb3JNZXNzYWdlIjoiRmVlIG11c3QgYmUgcGFpZCBieSBzZW5kZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzZdLCJlcnJvck1lc3NhZ2UiOiJGZWUgbXVzdCBnbyB0byBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG1hbmFnZXIgY2FuIGFzc2lnbiBleHBlcnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBtYW5hZ2VyIGNhbiB1cGRhdGUgdXNlciBzdGF0dXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHZlcmlmaWVkIGV4cGVydHMgY2FuIHZvdWNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg0XSwiZXJyb3JNZXNzYWdlIjoiT3duZXIgbXVzdCBtYXRjaCBzZW5kZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzJdLCJlcnJvck1lc3NhZ2UiOiJQcm9maWxlIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMV0sImVycm9yTWVzc2FnZSI6IldvcmtpbmcgdXNlcnMgbXVzdCBwYXkgMSBBTEdPIGZlZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZXhwZXJ0cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDgsNjIyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYW5hZ2VyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJvZmlsZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkwLDc4NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfYXVkaXRzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudXNlcl9zdGF0dXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgyLDQxMiw0NDMsNDcyLDY5OSw3OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTAsNDIwLDQ1Myw0NzksNzA2LDgwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzQsMjY3LDQzNCw2MDUsNjgzLDc2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDIsNDYzLDYxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyMl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNeklnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKMGIzUmhiRjloZFdScGRITWlJQ0p0WVc1aFoyVnlJaUFpWVhWa2FYUnpJaUF3ZURBd01EQXdNREF3TURBd01EQXdNREFnSW5CeWIyWnBiR1Z6SWlBaVpYaHdaWEowY3lJZ01IZ3dNREF3TURBd01EQXdNREF3TURBeElEQjRNREF6WXlBaWRYTmxjbDl6ZEdGMGRYTWlJREI0TURBeE1nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjloZFdScGRITWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyRjFaR2wwY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdjMlZzWmk1dFlXNWhaMlZ5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdFlXNWhaMlZ5SWdvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdjMlZzWmk1MlpYSnphVzl1SUQwZ1UzUnlhVzVuS0NJMkxqQXVNQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTnpJQ0oyWlhKemFXOXVJaUFpTmk0d0xqQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakkyQ2lBZ0lDQXZMeUJqYkdGemN5QkNiRzlqYTJSQmRXUnBkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TmdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURrMU9URTJNakE1SURCNE56VXpNREV5TURNZ01IZzFOalkyTlRRNE1TQXdlR1ppTlRjME1EaGhJREI0TVRjMVltRTVaR1lnTUhnMll6QTJNMlJrWWlBd2VHSm1Nakl5TWpZeklEQjRaak14TmpRM1pqSWdNSGhsTVdRMlpUVTJZaUF3ZURVMFlUWm1NR1kxSUM4dklHMWxkR2h2WkNBaWMyVjBYMlY0Y0dWeWRDaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0pwYzE5bGVIQmxjblFvWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblp2ZFdOb1gyWnZjbDloZFdScGRDaHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVc1amFHOXlYMkYxWkdsMEtITjBjbWx1Wnl4aFpHUnlaWE56TEhOMGNtbHVaeXgxYVc1ME5qUXNjM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOTFjMlZ5WDNOMFlYUjFjeWhoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZkWE5sY2w5emRHRjBkWE1vWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZEY5d2NtOW1hV3hsS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmY0hKdlptbHNaU2hoWkdSeVpYTnpLU2h6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltZGxkRjkwYjNSaGJGOWhkV1JwZEhNb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYMkYxWkdsMEtITjBjbWx1Wnlrb1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREWTBMSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lITmxkRjlsZUhCbGNuUWdhWE5mWlhod1pYSjBJSFp2ZFdOb1gyWnZjbDloZFdScGRDQmhibU5vYjNKZllYVmthWFFnYzJWMFgzVnpaWEpmYzNSaGRIVnpJR2RsZEY5MWMyVnlYM04wWVhSMWN5QnpaWFJmY0hKdlptbHNaU0JuWlhSZmNISnZabWxzWlNCblpYUmZkRzkwWVd4ZllYVmthWFJ6SUdkbGRGOWhkV1JwZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnWTJ4aGMzTWdRbXh2WTJ0a1FYVmthWFFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZjbTkxZEdWQU1UY0tJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qTTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUNiRzlqYTJSQmRXUnBkQzV6WlhSZlpYaHdaWEowVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMlY0Y0dWeWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QmhjM05sY25RZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOUlITmxiR1l1YldGdVlXZGxjaXdnSWs5dWJIa2diV0Z1WVdkbGNpQmpZVzRnWVhOemFXZHVJR1Y0Y0dWeWRITWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYldGdVlXZGxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dFlXNWhaMlZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzFoYm1GblpYSWdZMkZ1SUdGemMybG5iaUJsZUhCbGNuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCelpXeG1MbVY0Y0dWeWRITmJaWGh3WlhKMFhTQTlJR2x6WDJWNGNHVnlkQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlaWGh3WlhKMGN5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUNiRzlqYTJSQmRXUnBkQzVwYzE5bGVIQmxjblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMxOWxlSEJsY25RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZMkZzYkhOMVlpQmpiMjUwY21GamRDNUNiRzlqYTJSQmRXUnBkQzVwYzE5bGVIQmxjblFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUNiRzlqYTJSQmRXUnBkQzUyYjNWamFGOW1iM0pmWVhWa2FYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyYjNWamFGOW1iM0pmWVhWa2FYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YVhOZlpYaHdaWEowS0dGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU2tnUFQwZ1lYSmpOQzVWU1c1ME5qUW9NU2tzSUNKUGJteDVJSFpsY21sbWFXVmtJR1Y0Y0dWeWRITWdZMkZ1SUhadmRXTm9JZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJqYjI1MGNtRmpkQzVDYkc5amEyUkJkV1JwZEM1cGMxOWxlSEJsY25RS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhabGNtbG1hV1ZrSUdWNGNHVnlkSE1nWTJGdUlIWnZkV05vQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QmhjM05sY25RZ2MyTmhibDlwWkNCcGJpQnpaV3htTG1GMVpHbDBjeXdnSWtGMVpHbDBJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUYxWkdsMGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCZFdScGRDQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUdOMWNuSmxiblFnUFNCelpXeG1MbUYxWkdsMGMxdHpZMkZ1WDJsa1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPalU1TFRZd0NpQWdJQ0F2THlCamRYSnlaVzUwSUQwZ2MyVnNaaTVoZFdScGRITmJjMk5oYmw5cFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCdVpYZGZkbTkxWTJoZlkyOTFiblFnUFNCamRYSnlaVzUwTG5admRXTm9YMk52ZFc1MExtNWhkR2wyWlNBcklGVkpiblEyTkNneEtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFV5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUc1bGQxOTJiM1ZqYUY5amIzVnVkQ0E5SUdOMWNuSmxiblF1ZG05MVkyaGZZMjkxYm5RdWJtRjBhWFpsSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z2IzZHVaWEk5WTNWeWNtVnVkQzV2ZDI1bGNpd0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdkWEpzWDJoaGMyZzlZM1Z5Y21WdWRDNTFjbXhmYUdGemFDd0tJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBME1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QnlhWE5yWDNOamIzSmxQV04xY25KbGJuUXVjbWx6YTE5elkyOXlaU3dLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElETTBDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJR2x3Wm5OZlkybGtQV04xY25KbGJuUXVhWEJtYzE5amFXUXNDaUFnSUNCa2FXY2dOZ29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlZM1Z5Y21WdWRDNTBhVzFsYzNSaGJYQXNDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBME5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QjJiM1ZqYUY5amIzVnVkRDFoY21NMExsVkpiblEyTkNodVpYZGZkbTkxWTJoZlkyOTFiblFwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TmpFdE5qZ0tJQ0FnSUM4dklITmxiR1l1WVhWa2FYUnpXM05qWVc1ZmFXUmRJRDBnUVhWa2FYUlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdiM2R1WlhJOVkzVnljbVZ1ZEM1dmQyNWxjaXdLSUNBZ0lDOHZJQ0FnSUNCMWNteGZhR0Z6YUQxamRYSnlaVzUwTG5WeWJGOW9ZWE5vTEFvZ0lDQWdMeThnSUNBZ0lISnBjMnRmYzJOdmNtVTlZM1Z5Y21WdWRDNXlhWE5yWDNOamIzSmxMQW9nSUNBZ0x5OGdJQ0FnSUdsd1puTmZZMmxrUFdOMWNuSmxiblF1YVhCbWMxOWphV1FzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXTjFjbkpsYm5RdWRHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z0lDQWdJSFp2ZFdOb1gyTnZkVzUwUFdGeVl6UXVWVWx1ZERZMEtHNWxkMTkyYjNWamFGOWpiM1Z1ZENrS0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF3TTJNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEVUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTUFvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGtKc2IyTnJaRUYxWkdsMExtRnVZMmh2Y2w5aGRXUnBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GdVkyaHZjbDloZFdScGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TnpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzRNQzA0TVFvZ0lDQWdMeThnSXlCSmJuUmxaM0pwZEhrNklIUm9aU0JqWVd4c1pYSWdiWFZ6ZENCaVpTQjBhR1VnWTJ4aGFXMWxaQ0J2ZDI1bGNpQW9jSEpsZG1WdWRITWdabTl5WjJsdVp5QmhkV1JwZEhNZ1ptOXlJRzkwYUdWeWN5a0tJQ0FnSUM4dklHRnpjMlZ5ZENCdmQyNWxjaUE5UFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzSUNKUGQyNWxjaUJ0ZFhOMElHMWhkR05vSUhObGJtUmxjaUlLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQZDI1bGNpQnRkWE4wSUcxaGRHTm9JSE5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG80TWkwNE13b2dJQ0FnTHk4Z0l5QlFjbVYyWlc1MElHOTJaWEozY21sMGFXNW5JR0Z1SUdWNGFYTjBhVzVuSUdGMVpHbDBDaUFnSUNBdkx5QmhjM05sY25RZ2MyTmhibDlwWkNCdWIzUWdhVzRnYzJWc1ppNWhkV1JwZEhNc0lDSkJkV1JwZENCaGJISmxZV1I1SUdWNGFYTjBjeUlLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUYxWkdsMGN5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRjFaR2wwSUdGc2NtVmhaSGtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pnMUxUZzJDaUFnSUNBdkx5QWpJRU52YzNRZ1kyaGxZMnM2SUVsbUlIVnpaWElnYVhNZ2QyOXlhMmx1WnlBb2MzUmhkSFZ6SURFcExDQjNaU0JsYm1admNtTmxJREVnUVV4SFR5QndZWGx0Wlc1MElIUnZJR052Ym5SeVlXTjBDaUFnSUNBdkx5QjFjMlZ5WDNOMFlYUjFjeUE5SUhObGJHWXVaMlYwWDNWelpYSmZjM1JoZEhWektHOTNibVZ5S1FvZ0lDQWdZMkZzYkhOMVlpQmpiMjUwY21GamRDNUNiRzlqYTJSQmRXUnBkQzVuWlhSZmRYTmxjbDl6ZEdGMGRYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUdsbUlIVnpaWEpmYzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERZMEtERXBPZ29nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ1lXNWphRzl5WDJGMVpHbDBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG80T0MwNU1Bb2dJQ0FnTHk4Z0l5QkZibVp2Y21ObElERWdRVXhIVHlCd1lYbHRaVzUwSUdsdUlIUm9aU0J6WVcxbElHZHliM1Z3Q2lBZ0lDQXZMeUFqSUZ0VWVHNGdNRG9nVUdGNWJXVnVkQ3dnVkhodUlERTZJRUZ3Y0NCRFlXeHNYUW9nSUNBZ0x5OGdZWE56WlhKMElFZHNiMkpoYkM1bmNtOTFjRjl6YVhwbElEMDlJRlZKYm5RMk5DZ3lLU3dnSWxkdmNtdHBibWNnZFhObGNuTWdiWFZ6ZENCd1lYa2dNU0JCVEVkUElHWmxaU0lLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWGIzSnJhVzVuSUhWelpYSnpJRzExYzNRZ2NHRjVJREVnUVV4SFR5Qm1aV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVaM0p2ZFhCZmFXNWtaWGdnUFQwZ1ZVbHVkRFkwS0RFcExDQWlRWEJ3SUdOaGJHd2diWFZ6ZENCaVpTQnpaV052Ym1RZ2FXNGdaM0p2ZFhBaUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRWEJ3SUdOaGJHd2diWFZ6ZENCaVpTQnpaV052Ym1RZ2FXNGdaM0p2ZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZPVElLSUNBZ0lDOHZJR1psWlY5MGVHNGdQU0JuZEhodUxsQmhlVzFsYm5SVWNtRnVjMkZqZEdsdmJpZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG81TXdvZ0lDQWdMeThnWVhOelpYSjBJR1psWlY5MGVHNHVjMlZ1WkdWeUlEMDlJRlI0Ymk1elpXNWtaWElzSUNKR1pXVWdiWFZ6ZENCaVpTQndZV2xrSUdKNUlITmxibVJsY2lJS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCR1pXVWdiWFZ6ZENCaVpTQndZV2xrSUdKNUlITmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdabVZsWDNSNGJpQTlJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnWVhOelpYSjBJR1psWlY5MGVHNHVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWtabFpTQnRkWE4wSUdkdklIUnZJR0Z3Y0NJS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJHWldVZ2JYVnpkQ0JuYnlCMGJ5QmhjSEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHWmxaVjkwZUc0Z1BTQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2Ymlnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZPVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQm1aV1ZmZEhodUxtRnRiM1Z1ZENBK1BTQlZTVzUwTmpRb01WOHdNREJmTURBd0tTd2dJa1psWlNCdGRYTjBJR0psSUdGMElHeGxZWE4wSURFZ1FVeEhUeUlLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2NIVnphR2x1ZENBeE1EQXdNREF3Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFWmxaU0J0ZFhOMElHSmxJR0YwSUd4bFlYTjBJREVnUVV4SFR3b0tZVzVqYUc5eVgyRjFaR2wwWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvNU55MHhNRFFLSUNBZ0lDOHZJSE5sYkdZdVlYVmthWFJ6VzNOallXNWZhV1JkSUQwZ1FYVmthWFJTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYjNkdVpYSTliM2R1WlhJc0NpQWdJQ0F2THlBZ0lDQWdkWEpzWDJoaGMyZzlkWEpzWDJoaGMyZ3NDaUFnSUNBdkx5QWdJQ0FnY21semExOXpZMjl5WlQxeWFYTnJYM05qYjNKbExBb2dJQ0FnTHk4Z0lDQWdJR2x3Wm5OZlkybGtQV2x3Wm5OZlkybGtMQW9nSUNBZ0x5OGdJQ0FnSUhScGJXVnpkR0Z0Y0QxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lDQWdkbTkxWTJoZlkyOTFiblE5WVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QTJDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNREF6WXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb2FXNTBJRFl3Q2lBZ0lDQmthV2NnTmdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnZG05MVkyaGZZMjkxYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2prM0xURXdOQW9nSUNBZ0x5OGdjMlZzWmk1aGRXUnBkSE5iYzJOaGJsOXBaRjBnUFNCQmRXUnBkRkpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0J2ZDI1bGNqMXZkMjVsY2l3S0lDQWdJQzh2SUNBZ0lDQjFjbXhmYUdGemFEMTFjbXhmYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0J5YVhOclgzTmpiM0psUFhKcGMydGZjMk52Y21Vc0NpQWdJQ0F2THlBZ0lDQWdhWEJtYzE5amFXUTlhWEJtYzE5amFXUXNDaUFnSUNBdkx5QWdJQ0FnZEdsdFpYTjBZVzF3UFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1N3S0lDQWdJQzh2SUNBZ0lDQjJiM1ZqYUY5amIzVnVkRDFoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMkYxWkdsMGN5QXJQU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZllYVmthWFJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJGMVpHbDBjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOWhkV1JwZEhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVFteHZZMnRrUVhWa2FYUXVjMlYwWDNWelpYSmZjM1JoZEhWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDNWelpYSmZjM1JoZEhWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVEV3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlJSE5sYkdZdWJXRnVZV2RsY2l3Z0lrOXViSGtnYldGdVlXZGxjaUJqWVc0Z2RYQmtZWFJsSUhWelpYSWdjM1JoZEhWeklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTFoYm1GblpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YldGdVlXZGxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnRZVzVoWjJWeUlHTmhiaUIxY0dSaGRHVWdkWE5sY2lCemRHRjBkWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1URXhDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZjM1JoZEhWelczVnpaWEpkSUQwZ2MzUmhkSFZ6Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0oxYzJWeVgzTjBZWFIxY3lJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1URXpMVEV4TkFvZ0lDQWdMeThnSXlCQmJITnZJSFZ3WkdGMFpTQjBhR1VnY0hKdlptbHNaU0JwWmlCcGRDQmxlR2x6ZEhNS0lDQWdJQzh2SUdsbUlIVnpaWElnYVc0Z2MyVnNaaTV3Y205bWFXeGxjem9LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbkJ5YjJacGJHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ2MyVjBYM1Z6WlhKZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklHTjFjbkpsYm5RZ1BTQnpaV3htTG5CeWIyWnBiR1Z6VzNWelpYSmRMbU52Y0hrb0tRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205bWFXeGxjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUIxYzJWeWJtRnRaVDFqZFhKeVpXNTBMblZ6WlhKdVlXMWxMQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVEU1Q2lBZ0lDQXZMeUJxYjJsdVpXUmZZWFE5WTNWeWNtVnVkQzVxYjJsdVpXUmZZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVEUyTFRFeU1Bb2dJQ0FnTHk4Z2MyVnNaaTV3Y205bWFXeGxjMXQxYzJWeVhTQTlJRlZ6WlhKUWNtOW1hV3hsS0FvZ0lDQWdMeThnSUNBZ0lIVnpaWEp1WVcxbFBXTjFjbkpsYm5RdWRYTmxjbTVoYldVc0NpQWdJQ0F2THlBZ0lDQWdhWE5mZDI5eWEybHVaejF6ZEdGMGRYTXNDaUFnSUNBdkx5QWdJQ0FnYW05cGJtVmtYMkYwUFdOMWNuSmxiblF1YW05cGJtVmtYMkYwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURBd01USUtJQ0FnSUdScFp5QTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2dwelpYUmZkWE5sY2w5emRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMa0pzYjJOclpFRjFaR2wwTG1kbGRGOTFjMlZ5WDNOMFlYUjFjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTFjMlZ5WDNOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1USXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCamIyNTBjbUZqZEM1Q2JHOWphMlJCZFdScGRDNW5aWFJmZFhObGNsOXpkR0YwZFhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkQzVDYkc5amEyUkJkV1JwZEM1elpYUmZjSEp2Wm1sc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5d2NtOW1hV3hsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hNamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hNeklLSUNBZ0lDOHZJSE5sYm1SbGNpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJSE4wWVhSMWN5QTlJSE5sYkdZdVoyVjBYM1Z6WlhKZmMzUmhkSFZ6S0hObGJtUmxjaWtLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCamIyNTBjbUZqZEM1Q2JHOWphMlJCZFdScGRDNW5aWFJmZFhObGNsOXpkR0YwZFhNS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJxYjJsdVpXUWdQU0JoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UTTJDaUFnSUNBdkx5QnBaaUJ6Wlc1a1pYSWdhVzRnYzJWc1ppNXdjbTltYVd4bGN6b0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luQnliMlpwYkdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nYzJWMFgzQnliMlpwYkdWZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdhbTlwYm1Wa0lEMGdjMlZzWmk1d2NtOW1hV3hsYzF0elpXNWtaWEpkTG1wdmFXNWxaRjloZEFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0oxY25rZ01nb0tjMlYwWDNCeWIyWnBiR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE16a3RNVFF6Q2lBZ0lDQXZMeUJ6Wld4bUxuQnliMlpwYkdWelczTmxibVJsY2wwZ1BTQlZjMlZ5VUhKdlptbHNaU2dLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlibUZ0WlQxMWMyVnlibUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQnBjMTkzYjNKcmFXNW5QWE4wWVhSMWN5d0tJQ0FnSUM4dklDQWdJQ0JxYjJsdVpXUmZZWFE5YW05cGJtVmtDaUFnSUNBdkx5QXBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3TVRJS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE1qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMa0pzYjJOclpFRjFaR2wwTG1kbGRGOXdjbTltYVd4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNCeWIyWnBiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRTBOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UUTRDaUFnSUNBdkx5QmhjM05sY25RZ2RYTmxjaUJwYmlCelpXeG1MbkJ5YjJacGJHVnpMQ0FpVUhKdlptbHNaU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p3Y205bWFXeGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtOW1hV3hsSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hORGtLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5CeWIyWnBiR1Z6VzNWelpYSmRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UUTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUNiRzlqYTJSQmRXUnBkQzVuWlhSZmRHOTBZV3hmWVhWa2FYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUnZkR0ZzWDJGMVpHbDBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UVTBDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTUwYjNSaGJGOWhkV1JwZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOWhkV1JwZEhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZllYVmthWFJ6SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExrSnNiMk5yWkVGMVpHbDBMbWRsZEY5aGRXUnBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWhkV1JwZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkc5amEyUmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVFUyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc2IyTnJaRjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TlRrS0lDQWdJQzh2SUdGemMyVnlkQ0J6WTJGdVgybGtJR2x1SUhObGJHWXVZWFZrYVhSekxDQWlRWFZrYVhRZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlYVmthWFJ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFRjFaR2wwSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1GMVpHbDBjMXR6WTJGdVgybGtYUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXh2WTJ0a1gyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRTFOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUXVRbXh2WTJ0a1FYVmthWFF1YVhOZlpYaHdaWEowS0dWNGNHVnlkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BqYjI1MGNtRmpkQzVDYkc5amEyUkJkV1JwZEM1cGMxOWxlSEJsY25RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPalEyTFRRM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJwYzE5bGVIQmxjblFvYzJWc1ppd2daWGh3WlhKME9pQmhjbU0wTGtGa1pISmxjM01wSUMwK0lHRnlZelF1VlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14dlkydGtYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJwWmlCbGVIQmxjblFnYVc0Z2MyVnNaaTVsZUhCbGNuUnpPZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlaWGh3WlhKMGN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWTI5dWRISmhZM1F1UW14dlkydGtRWFZrYVhRdWFYTmZaWGh3WlhKMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzYjJOclpGOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Wlhod1pYSjBjMXRsZUhCbGNuUmRDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaWGh3WlhKMGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1kyOXVkSEpoWTNRdVFteHZZMnRrUVhWa2FYUXVhWE5mWlhod1pYSjBYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOdmJuUnlZV04wTGtKc2IyTnJaRUYxWkdsMExtZGxkRjkxYzJWeVgzTjBZWFIxY3loMWMyVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU52Ym5SeVlXTjBMa0pzYjJOclpFRjFaR2wwTG1kbGRGOTFjMlZ5WDNOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliRzlqYTJSZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1USXlMVEV5TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDNWelpYSmZjM1JoZEhWektITmxiR1lzSUhWelpYSTZJR0Z5WXpRdVFXUmtjbVZ6Y3lrZ0xUNGdZWEpqTkM1VlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHOWphMlJmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCcFppQjFjMlZ5SUdsdUlITmxiR1l1ZFhObGNsOXpkR0YwZFhNNkNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMWMyVnlYM04wWVhSMWN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWTI5dWRISmhZM1F1UW14dlkydGtRWFZrYVhRdVoyVjBYM1Z6WlhKZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNiMk5yWkY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE1qWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblZ6WlhKZmMzUmhkSFZ6VzNWelpYSmRDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWE5sY2w5emRHRjBkWE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbU52Ym5SeVlXTjBMa0pzYjJOclpFRjFaR2wwTG1kbGRGOTFjMlZ5WDNOMFlYUjFjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteHZZMnRrWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtEQXBJQ01nUkdWbVlYVnNkQ0IwYnlCS2IySXRjMlZsYTJWeUwwWnlaV1VLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdDQ1lMQkJVZmZIVU1kRzkwWVd4ZllYVmthWFJ6QjIxaGJtRm5aWElHWVhWa2FYUnpDQUFBQUFBQUFBQUFDSEJ5YjJacGJHVnpCMlY0Y0dWeWRITUlBQUFBQUFBQUFBRUNBRHdMZFhObGNsOXpkR0YwZFhNQ0FCSXhHRUFBR0NraVp5b3lDV2VDQWdkMlpYSnphVzl1QlRZdU1DNHdaekVaRkVReEdFRUFUb0lLQkpXUllna0VkVEFTQXdSV1psU0JCUHRYUUlvRUYxdXAzd1JzQmozYkJMOGlJbU1FOHhaSDhnVGgxdVZyQkZTbThQVTJHZ0NPQ2dBUkFESUFRd0RGQVlRQjBnSGpBaUlDT3dKR0FJQUVURnhodWpZYUFJNEJBQUVBSTBNMkdnRkpGU1FTUkRZYUFra1ZKUkpFTVFBaUttVkVFa1FuQms4Q1VFeS9JME0yR2dGSkZTUVNSSWdDS2loTVVMQWpRellhQVVraVdZRUNDRXNCRlJKRVZ3SUFNUUNJQWc0bkI2aEVLMHhRU2IxRkFVUkp2a2hNU1lFMEpib1hJd2hMQVNJa3Vrc0RKRmxMQklFcVdVc0ZUd0pMQWxKTEJJRWlKYnBMQmhWUEIwOEVUd0pTU3dXQkxDVzZUd1VXVHdVbkNGQkxCUldCUEFoTVR3VlFUQlpYQmdKUVR3SlFURkJQQWxCTVVFc0J2RWkvSTBNMkdnRkpJbG1CQWdoTEFSVVNSRmNDQURZYUFrbE9Ba2tWSkJKRU5ob0RTVTREU1NKWmdRSUlUQlZKVGdRU1JEWWFCRWxPQXhVbEVrUTJHZ1ZKVGdOSklsbUJBZ2hNRlJKRVNURUFFa1FyVHdKUVNVNEN2VVVCRkVTSUFWNG5CNmhCQUNneUJJRUNFa1F4RmlNU1JDSTRFQ01TUkNJNEFERUFFa1FpT0FjeUNoSkVJamdJZ2NDRVBROUVNZ2NXU3dZbkNGQ0JQRXNHQ0V4TEJWQk1GbGNHQWxCTVVDY0VVRXNGVUVzQ1VFc0JTYnhJVEw4aUtXVkVJd2dwVEdjalF6WWFBVWtWSkJKRU5ob0NTVTRDU1JVbEVrUXhBQ0lxWlVRU1JDY0pTd0pRVEw4bkJVeFFTYjFGQVVFQUgwY0N2a1JKSWxsTEFSVlNTd0dCQ2lXNkp3cExCVkJNVUV4UVN3RzhTTDhqUXpZYUFVa1ZKQkpFaUFDaktFeFFzQ05ETmhvQlJ3SWlXWUVDQ0V3VkVrUXhBRW1JQUlsTU1nY1dUQ2NGVEZCSnZVVUJRUUFIU1lFS0picEZBaWNLU3dOUVN3SlFTd1JRU3dGSnZFaE12eU5ETmhvQlNSVWtFa1FuQlV4UVNiMUZBVVMrU0NoTVVMQWpReUlwWlVRV0tFeFFzQ05ETmhvQlNTSlpnUUlJU3dFVkVrUlhBZ0FyVEZCSnZVVUJSTDVJS0V4UXNDTkRpZ0VCSndhTC8xQkp2VVVCUVFBR2l3QytSRXlKSndSTWlZb0JBU2NKaS85UVNiMUZBVUVBQm9zQXZrUk1pU2NFVElrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
