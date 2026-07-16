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

namespace Arc56.Generated.akita_protocol.akita_sc.AkitaSocialGraph_c980df3b
{


    public class AkitaSocialGraphProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AkitaSocialGraphProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AkitaSocialMbrData : AVMObjectType
            {
                public ulong Follows { get; set; }

                public ulong Blocks { get; set; }

                public ulong Posts { get; set; }

                public ulong Votes { get; set; }

                public ulong Votelist { get; set; }

                public ulong Reactions { get; set; }

                public ulong Reactionlist { get; set; }

                public ulong Meta { get; set; }

                public ulong Moderators { get; set; }

                public ulong Banned { get; set; }

                public ulong Actions { get; set; }

                public ulong RefTypes { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFollows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFollows.From(Follows);
                    ret.AddRange(vFollows.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlocks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBlocks.From(Blocks);
                    ret.AddRange(vBlocks.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPosts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPosts.From(Posts);
                    ret.AddRange(vPosts.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVotes.From(Votes);
                    ret.AddRange(vVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotelist = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVotelist.From(Votelist);
                    ret.AddRange(vVotelist.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReactions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReactions.From(Reactions);
                    ret.AddRange(vReactions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReactionlist = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReactionlist.From(Reactionlist);
                    ret.AddRange(vReactionlist.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMeta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMeta.From(Meta);
                    ret.AddRange(vMeta.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vModerators = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vModerators.From(Moderators);
                    ret.AddRange(vModerators.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBanned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBanned.From(Banned);
                    ret.AddRange(vBanned.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActions.From(Actions);
                    ret.AddRange(vActions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefTypes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRefTypes.From(RefTypes);
                    ret.AddRange(vRefTypes.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AkitaSocialMbrData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AkitaSocialMbrData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFollows = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFollows.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFollows = vFollows.ToValue();
                    if (valueFollows is ulong vFollowsValue) { ret.Follows = vFollowsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlocks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBlocks.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBlocks = vBlocks.ToValue();
                    if (valueBlocks is ulong vBlocksValue) { ret.Blocks = vBlocksValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPosts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPosts.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePosts = vPosts.ToValue();
                    if (valuePosts is ulong vPostsValue) { ret.Posts = vPostsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotes = vVotes.ToValue();
                    if (valueVotes is ulong vVotesValue) { ret.Votes = vVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotelist = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVotelist.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotelist = vVotelist.ToValue();
                    if (valueVotelist is ulong vVotelistValue) { ret.Votelist = vVotelistValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReactions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReactions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReactions = vReactions.ToValue();
                    if (valueReactions is ulong vReactionsValue) { ret.Reactions = vReactionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReactionlist = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReactionlist.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReactionlist = vReactionlist.ToValue();
                    if (valueReactionlist is ulong vReactionlistValue) { ret.Reactionlist = vReactionlistValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMeta = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMeta.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMeta = vMeta.ToValue();
                    if (valueMeta is ulong vMetaValue) { ret.Meta = vMetaValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vModerators = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vModerators.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueModerators = vModerators.ToValue();
                    if (valueModerators is ulong vModeratorsValue) { ret.Moderators = vModeratorsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBanned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBanned.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBanned = vBanned.ToValue();
                    if (valueBanned is ulong vBannedValue) { ret.Banned = vBannedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActions = vActions.ToValue();
                    if (valueActions is ulong vActionsValue) { ret.Actions = vActionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRefTypes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRefTypes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRefTypes = vRefTypes.ToValue();
                    if (valueRefTypes is ulong vRefTypesValue) { ret.RefTypes = vRefTypesValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AkitaSocialMbrData);
                }
                public bool Equals(AkitaSocialMbrData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AkitaSocialMbrData left, AkitaSocialMbrData right)
                {
                    return EqualityComparer<AkitaSocialMbrData>.Default.Equals(left, right);
                }
                public static bool operator !=(AkitaSocialMbrData left, AkitaSocialMbrData right)
                {
                    return !(left == right);
                }

            }

            public class BlockListKey : AVMObjectType
            {
                public byte[] User { get; set; }

                public byte[] Blocked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    vUser.From(User);
                    ret.AddRange(vUser.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    vBlocked.From(Blocked);
                    ret.AddRange(vBlocked.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BlockListKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BlockListKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    count = vUser.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUser = vUser.ToValue();
                    if (valueUser is byte[] vUserValue) { ret.User = vUserValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    count = vBlocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBlocked = vBlocked.ToValue();
                    if (valueBlocked is byte[] vBlockedValue) { ret.Blocked = vBlockedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BlockListKey);
                }
                public bool Equals(BlockListKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BlockListKey left, BlockListKey right)
                {
                    return EqualityComparer<BlockListKey>.Default.Equals(left, right);
                }
                public static bool operator !=(BlockListKey left, BlockListKey right)
                {
                    return !(left == right);
                }

            }

            public class FollowsKey : AVMObjectType
            {
                public byte[] User { get; set; }

                public byte[] Follower { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    vUser.From(User);
                    ret.AddRange(vUser.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFollower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    vFollower.From(Follower);
                    ret.AddRange(vFollower.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FollowsKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FollowsKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    count = vUser.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUser = vUser.ToValue();
                    if (valueUser is byte[] vUserValue) { ret.User = vUserValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFollower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[16]");
                    count = vFollower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFollower = vFollower.ToValue();
                    if (valueFollower is byte[] vFollowerValue) { ret.Follower = vFollowerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FollowsKey);
                }
                public bool Equals(FollowsKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FollowsKey left, FollowsKey right)
                {
                    return EqualityComparer<FollowsKey>.Default.Equals(left, right);
                }
                public static bool operator !=(FollowsKey left, FollowsKey right)
                {
                    return !(left == right);
                }

            }

            public class ViewPayWallValue : AVMObjectType
            {
                public (uint8, uint64, uint64)[][] UserPayInfo { get; set; }

                public (uint8, uint64, uint64)[][] AgentPayInfo { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUserPayInfo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("(uint8,uint64,uint64)[]");
                    vUserPayInfo.From(UserPayInfo);
                    ret.AddRange(vUserPayInfo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentPayInfo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("(uint8,uint64,uint64)[]");
                    vAgentPayInfo.From(AgentPayInfo);
                    ret.AddRange(vAgentPayInfo.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ViewPayWallValue Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ViewPayWallValue();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUserPayInfo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("(uint8,uint64,uint64)[]");
                    count = vUserPayInfo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUserPayInfo = vUserPayInfo.ToValue();
                    if (valueUserPayInfo is (uint8, uint64, uint64)[][] vUserPayInfoValue) { ret.UserPayInfo = vUserPayInfoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentPayInfo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("(uint8,uint64,uint64)[]");
                    count = vAgentPayInfo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentPayInfo = vAgentPayInfo.ToValue();
                    if (valueAgentPayInfo is (uint8, uint64, uint64)[][] vAgentPayInfoValue) { ret.AgentPayInfo = vAgentPayInfoValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ViewPayWallValue);
                }
                public bool Equals(ViewPayWallValue? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ViewPayWallValue left, ViewPayWallValue right)
                {
                    return EqualityComparer<ViewPayWallValue>.Default.Equals(left, right);
                }
                public static bool operator !=(ViewPayWallValue left, ViewPayWallValue right)
                {
                    return !(left == right);
                }

            }

            public class TipMbrInfo : AVMObjectType
            {
                public byte Type { get; set; }

                public ulong Arc58 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vType.From(Type);
                    ret.AddRange(vType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArc58 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vArc58.From(Arc58);
                    ret.AddRange(vArc58.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TipMbrInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TipMbrInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueType = vType.ToValue();
                    if (valueType is byte vTypeValue) { ret.Type = vTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArc58 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vArc58.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArc58 = vArc58.ToValue();
                    if (valueArc58 is ulong vArc58Value) { ret.Arc58 = vArc58Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TipMbrInfo);
                }
                public bool Equals(TipMbrInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TipMbrInfo left, TipMbrInfo right)
                {
                    return EqualityComparer<TipMbrInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(TipMbrInfo left, TipMbrInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create method to initialize the contract with the DAO reference
        ///</summary>
        /// <param name="akitaDao">The Akita DAO app ID </param>
        /// <param name="version">The version string for this contract </param>
        public async Task Create(ulong akitaDao, string version, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 152, 23, 246 };
            var akitaDaoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDaoAbi.From(akitaDao);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDaoAbi, versionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong akitaDao, string version, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 152, 23, 246 };
            var akitaDaoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDaoAbi.From(akitaDao);
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDaoAbi, versionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="address"> </param>
        public async Task Block(PaymentTransaction mbrPayment, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 181, 156, 138, 84 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Block_Transactions(PaymentTransaction mbrPayment, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 181, 156, 138, 84 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task Unblock(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 235, 179, 120 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unblock_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 235, 179, 120 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="gateTxn"> </param>
        /// <param name="address"> </param>
        public async Task GatedFollow(PaymentTransaction mbrPayment, ApplicationCallTransaction gateTxn, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, gateTxn });
            byte[] abiHandle = { 134, 103, 84, 148 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, gateTxn, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedFollow_Transactions(PaymentTransaction mbrPayment, ApplicationCallTransaction gateTxn, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, gateTxn });
            byte[] abiHandle = { 134, 103, 84, 148 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, gateTxn, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="address"> </param>
        public async Task Follow(PaymentTransaction mbrPayment, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 75, 111, 144, 127 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Follow_Transactions(PaymentTransaction mbrPayment, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 75, 111, 144, 127 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task Unfollow(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 27, 58, 122 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unfollow_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 27, 58, 122 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="blocked"> </param>
        public async Task<bool> IsBlocked(Algorand.Address user, Algorand.Address blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 3, 102, 142 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); blockedAbi.From(blocked);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBlocked_Transactions(Algorand.Address user, Algorand.Address blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 3, 102, 142 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); blockedAbi.From(blocked);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="follower"> </param>
        /// <param name="user"> </param>
        public async Task<bool> IsFollowing(Algorand.Address follower, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 98, 245, 8 };
            var followerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); followerAbi.From(follower);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, followerAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsFollowing_Transactions(Algorand.Address follower, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 98, 245, 8 };
            var followerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); followerAbi.From(follower);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, followerAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="follower"> </param>
        /// <param name="user"> </param>
        public async Task<ulong> GetFollowIndex(Algorand.Address follower, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 131, 128, 164 };
            var followerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); followerAbi.From(follower);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, followerAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetFollowIndex_Transactions(Algorand.Address follower, Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 131, 128, 164 };
            var followerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); followerAbi.From(follower);
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, followerAbi, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ref"> </param>
        /// <param name="refTypeName"> </param>
        /// <param name="refTypeSchema"> </param>
        public async Task<Structs.AkitaSocialMbrData> Mbr(byte[] @ref, string refTypeName, byte[] refTypeSchema, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 50, 79, 183 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(); refAbi.From(@ref);
            var refTypeNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); refTypeNameAbi.From(refTypeName);
            var refTypeSchemaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(); refTypeSchemaAbi.From(refTypeSchema);

            var result = await base.CallApp(new List<object> { abiHandle, refAbi, refTypeNameAbi, refTypeSchemaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AkitaSocialMbrData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Mbr_Transactions(byte[] @ref, string refTypeName, byte[] refTypeSchema, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 50, 79, 183 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(); refAbi.From(@ref);
            var refTypeNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); refTypeNameAbi.From(refTypeName);
            var refTypeSchemaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(); refTypeSchemaAbi.From(refTypeSchema);

            return await base.MakeTransactionList(new List<object> { abiHandle, refAbi, refTypeNameAbi, refTypeSchemaAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="paywall"> ViewPayWallValue</param>
        public async Task<ulong> PayWallMbr(Structs.ViewPayWallValue paywall, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 52, 162, 120 };

            var result = await base.CallApp(new List<object> { abiHandle, paywall }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PayWallMbr_Transactions(Structs.ViewPayWallValue paywall, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 52, 162, 120 };

            return await base.MakeTransactionList(new List<object> { abiHandle, paywall }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        /// <param name="creator"> </param>
        /// <param name="wallet"> </param>
        public async Task<Structs.TipMbrInfo> CheckTipMbrRequirements(ulong akitaDAO, Algorand.Address creator, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 65, 117, 240 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi, creatorAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TipMbrInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CheckTipMbrRequirements_Transactions(ulong akitaDAO, Algorand.Address creator, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 65, 117, 240 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi, creatorAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newVersion"> </param>
        public async Task Update(string newVersion, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 145, 128, 221 };
            var newVersionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newVersionAbi.From(newVersion);

            var result = await base.CallApp(new List<object> { abiHandle, newVersionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(string newVersion, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 145, 128, 221 };
            var newVersionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newVersionAbi.From(newVersion);

            return await base.MakeTransactionList(new List<object> { abiHandle, newVersionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        public async Task UpdateAkitaDao(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAkitaDao_Transactions(ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 233, 44, 148 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFTb2NpYWxHcmFwaCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBa2l0YVNvY2lhbE1CUkRhdGEiOlt7Im5hbWUiOiJmb2xsb3dzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJsb2NrcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3N0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlbGlzdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWFjdGlvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVhY3Rpb25saXN0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1ldGEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibW9kZXJhdG9ycyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYW5uZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aW9ucyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWZUeXBlcyIsInR5cGUiOiJ1aW50NjQifV0sIkJsb2NrTGlzdEtleSI6W3sibmFtZSI6InVzZXIiLCJ0eXBlIjoiYnl0ZVsxNl0ifSx7Im5hbWUiOiJibG9ja2VkIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJGb2xsb3dzS2V5IjpbeyJuYW1lIjoidXNlciIsInR5cGUiOiJieXRlWzE2XSJ9LHsibmFtZSI6ImZvbGxvd2VyIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJWaWV3UGF5V2FsbFZhbHVlIjpbeyJuYW1lIjoidXNlclBheUluZm8iLCJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10ifSx7Im5hbWUiOiJhZ2VudFBheUluZm8iLCJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10ifV0sInRpcE1CUkluZm8iOlt7Im5hbWUiOiJ0eXBlIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiYXJjNTgiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJDcmVhdGUgbWV0aG9kIHRvIGluaXRpYWxpemUgdGhlIGNvbnRyYWN0IHdpdGggdGhlIERBTyByZWZlcmVuY2UiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEYW8iLCJkZXNjIjoiVGhlIEFraXRhIERBTyBhcHAgSUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjoiVGhlIHZlcnNpb24gc3RyaW5nIGZvciB0aGlzIGNvbnRyYWN0IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJsb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuYmxvY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2F0ZWRGb2xsb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdhdGVUeG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZvbGxvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bmZvbGxvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0Jsb2NrZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibG9ja2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNGb2xsb3dpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvbGxvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEZvbGxvd0luZGV4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmb2xsb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1iciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZlR5cGVOYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWZUeXBlU2NoZW1hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBa2l0YVNvY2lhbE1CUkRhdGEiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXlXYWxsTWJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IigodWludDgsdWludDY0LHVpbnQ2NClbXSwodWludDgsdWludDY0LHVpbnQ2NClbXSkiLCJzdHJ1Y3QiOiJWaWV3UGF5V2FsbFZhbHVlIiwibmFtZSI6InBheXdhbGwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVja1RpcE1iclJlcXVpcmVtZW50cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJha2l0YURBTyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDgsdWludDY0KSIsInN0cnVjdCI6InRpcE1CUkluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzg5OV0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTc2LDEzNzQsMTQ4NV0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOkFGTFciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjMwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOkFVVE8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTIsMzc3LDcxNiwxNTU3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOkJBTkQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTg2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOkJMS0QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzRdLCJlcnJvck1lc3NhZ2UiOiJFUlI6RkdURSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1N10sImVycm9yTWVzc2FnZSI6IkVSUjpIR1RFIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQxLDYwNCw2ODddLCJlcnJvck1lc3NhZ2UiOiJFUlI6SVBBWSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyODBdLCJlcnJvck1lc3NhZ2UiOiJFUlI6SVVQRyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNTEsMTMxOF0sImVycm9yTWVzc2FnZSI6IkVSUjpOREFPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOk5GTFciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTJdLCJlcnJvck1lc3NhZ2UiOiJFUlI6U0JMSyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MDZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6U0ZMVyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwOV0sImVycm9yTWVzc2FnZSI6IkVSUjpVTkJLIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM5NiwxNDA3LDE0MjMsMTQzNF0sImVycm9yTWVzc2FnZSI6Ikxlbmd0aCBtdXN0IGJlIDE2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0MywxMzEwXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgyLDEyMzYsMTI1NSwxMzAzLDEzMzEsMTQ0MywxNDk5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQzLDkxMyw5MjksOTQ1LDk4NywxMDExLDEwMjksMTIyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MCw5MjAsOTM2LDk1MiwxMjI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MSwzNjYsNDcxLDYzNiw3MDUsODAyLDgxMCw4NDEsODQ5LDg4MSw4ODksMTA2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzYsMTA1NCwxMDczLDEyOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTgxLDEzNzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3NvY2lhbC90eXBlcy50czo6TWV0YVZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvc29jaWFsL3R5cGVzLnRzOjpWaWV3UGF5V2FsbFZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbisodWludDgsdWludDY0LHVpbnQ2NClbXSksKGxlbisodWludDgsdWludDY0LHVpbnQ2NClbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pLChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3Myw5OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYwXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBhcHBsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczLDQ0OCw2MjddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUZyYVhSaFgyUmhieUlnTUhneE5URm1OMk0zTlNBaUlpQWlSVkpTT2tKQlRrUWlJQ0ppSWlBaVppSWdJa1ZTVWpwSlVFRlpJaUFpYzJGc0lpQWlkbVZ5YzJsdmJpSWdJbkJoYkNJZ0luZGhiR3hsZENJZ0lrVlNVanBPUkVGUElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd0cGRHRlRiMk5wWVd4SGNtRndhQ0JsZUhSbGJtUnpJR05zWVhOelpYTW9RbUZ6WlZOdlkybGhiQ3dnVlhCbmNtRmtaV0ZpYkdWQmEybDBZVUpoYzJWRGIyNTBjbUZqZENrZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpXRTVNVGd3WkdRZ0x5OGdiV1YwYUc5a0lDSjFjR1JoZEdVb2MzUnlhVzVuS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzVndaR0YwWlY5eWIzVjBaVUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnJhWFJoVTI5amFXRnNSM0poY0dnZ1pYaDBaVzVrY3lCamJHRnpjMlZ6S0VKaGMyVlRiMk5wWVd3c0lGVndaM0poWkdWaFlteGxRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUXBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1qRUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGlOVGxqT0dFMU5DQXdlR0ZsWldKaU16YzRJREI0T0RZMk56VTBPVFFnTUhnMFlqWm1PVEEzWmlBd2VERTJNV0l6WVRkaElEQjRORE13TXpZMk9HVWdNSGhsWWpZeVpqVXdPQ0F3ZURBNU9ETTRNR0UwSURCNE1UUXpNalJtWWpjZ01IaGhNVE0wWVRJM09DQXdlRE0wTkRFM05XWXdJREI0TXpObE9USmpPVFFnTUhnNE5UUmtaV1JsTUNBdkx5QnRaWFJvYjJRZ0ltSnNiMk5yS0hCaGVTeGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5WdVlteHZZMnNvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5ZWFJsWkVadmJHeHZkeWh3WVhrc1lYQndiQ3hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltWnZiR3h2ZHlod1lYa3NZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKMWJtWnZiR3h2ZHloaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWx6UW14dlkydGxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXBZbTl2YkNJc0lHMWxkR2h2WkNBaWFYTkdiMnhzYjNkcGJtY29ZV1JrY21WemN5eGhaR1J5WlhOektXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRFWnZiR3h2ZDBsdVpHVjRLR0ZrWkhKbGMzTXNZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltMWljaWhpZVhSbFcxMHNjM1J5YVc1bkxHSjVkR1ZiWFNrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0p3WVhsWFlXeHNUV0p5S0Nnb2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DbGJYU3dvZFdsdWREZ3NkV2x1ZERZMExIVnBiblEyTkNsYlhTa3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwY3loMWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXBLSFZwYm5RNExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luVndaR0YwWlVGcmFYUmhSRUZQS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnZjRlZ3S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWW14dlkyc2dkVzVpYkc5amF5Qm5ZWFJsWkVadmJHeHZkeUJtYjJ4c2IzY2dkVzVtYjJ4c2IzY2dhWE5DYkc5amEyVmtJR2x6Um05c2JHOTNhVzVuSUdkbGRFWnZiR3h2ZDBsdVpHVjRJRzFpY2lCd1lYbFhZV3hzVFdKeUlHTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6SUhWd1pHRjBaVUZyYVhSaFJFRlBJRzFoYVc1ZmIzQlZjRjl5YjNWMFpVQXhPUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdWWEJmY205MWRHVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8wTVFvZ0lDQWdMeThnYjNCVmNDZ3BPaUIyYjJsa0lIc2dmUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF5TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZyYVhSaFUyOWphV0ZzUjNKaGNHZ2daWGgwWlc1a2N5QmpiR0Z6YzJWektFSmhjMlZUYjJOcFlXd3NJRlZ3WjNKaFpHVmhZbXhsUVd0cGRHRkNZWE5sUTI5dWRISmhZM1FwSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURabU9UZ3hOMlkySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0hWcGJuUTJOQ3h6ZEhKcGJtY3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dwdFlXbHVYM1Z3WkdGMFpWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk5EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25WWEJrWVhSbFFYQndiR2xqWVhScGIyNG5YU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklGVndaR0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ2RYQmtZWFJsQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkVkeVlYQm9MbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VnUFNCaGEybDBZVVJoYndvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNalVLSUNBZ0lDOHZJSFpsY25OcGIyNGdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVWWmxjbk5wYjI0Z2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luWmxjbk5wYjI0aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklIUm9hWE11ZG1WeWMybHZiaTUyWVd4MVpTQTlJSFpsY25OcGIyNEtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRWR5WVhCb0xtSnNiMk5yVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lteHZZMnM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdKc2IyTnJLRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdnWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLQ0YwYUdsekxtbHpRbUZ1Ym1Wa0tGUjRiaTV6Wlc1a1pYSXBMQ0JGVWxKZlFrRk9Ua1ZFS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCcGMwSmhibTVsWkFvZ0lDQWdZbm9nWW14dlkydGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWalh6TWdMeThnSWtWU1VqcENRVTVFSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPa0pCVGtRS0NtSnNiMk5yWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamszQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQWhQVDBnWVdSa2NtVnpjeXdnUlZKU1gxTkZURVpmUWt4UFEwc3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnSVQwS0lDQWdJR0p1ZWlCaWJHOWphMTloWm5SbGNsOWhjM05sY25SQU5Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZVMEpNU3lJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBUUWt4TENncGliRzlqYTE5aFpuUmxjbDloYzNObGNuUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TURBdE1UQTJDaUFnSUNBdkx5QnRZWFJqYUNnS0lDQWdJQzh2SUNBZ2JXSnlVR0Y1YldWdWRDd0tJQ0FnSUM4dklDQWdld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2t1WW14dlkydHpDaUFnSUNBdkx5QWdJSDBLSUNBZ0lDOHZJQ2tzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFd013b2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1EQXRNVEEyQ2lBZ0lDQXZMeUJ0WVhSamFDZ0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrdVlteHZZMnR6Q2lBZ0lDQXZMeUFnSUgwS0lDQWdJQzh2SUNrc0NpQWdJQ0E5UFFvZ0lDQWdjM2RoY0FvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCaGJXOTFiblE2SUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2t1WW14dlkydHpDaUFnSUNCaWVYUmxZMTh5SUM4dklDSWlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHTmhiR3h6ZFdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG0xaWNnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFd01DMHhNRFlLSUNBZ0lDOHZJRzFoZEdOb0tBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhsdFpXNTBMQW9nSUNBZ0x5OGdJQ0I3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTV0WW5Jb1FubDBaWE1vSnljcExDQW5KeXdnUW5sMFpYTW9KeWNwS1M1aWJHOWphM01LSUNBZ0lDOHZJQ0FnZlFvZ0lDQWdMeThnS1N3S0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPams1TFRFd09Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J0WVhSamFDZ0tJQ0FnSUM4dklDQWdJQ0J0WW5KUVlYbHRaVzUwTEFvZ0lDQWdMeThnSUNBZ0lIc0tJQ0FnSUM4dklDQWdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTV0WW5Jb1FubDBaWE1vSnljcExDQW5KeXdnUW5sMFpYTW9KeWNwS1M1aWJHOWphM01LSUNBZ0lDOHZJQ0FnSUNCOUNpQWdJQ0F2THlBZ0lDa3NDaUFnSUNBdkx5QWdJRVZTVWw5SlRsWkJURWxFWDFCQldVMUZUbFFLSUNBZ0lDOHZJQ2tLSUNBZ0lHSnVlaUJpYkc5amExOWhablJsY2w5aGMzTmxjblJBTndvZ0lDQWdZbmwwWldNZ05pQXZMeUFpUlZKU09rbFFRVmtpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZTVkJCV1FvS1lteHZZMnRmWVdaMFpYSmZZWE56WlhKMFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEV3Q2lBZ0lDQXZMeUJqYjI1emRDQmliRzlqYTNOTFpYa2dQU0IwYUdsekxtSnNheWhVZUc0dWMyVnVaR1Z5TENCaFpHUnlaWE56S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1lteHJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR0pzYjJOcmN5QTlJRUp2ZUUxaGNEeENiRzlqYTB4cGMzUkxaWGtzSUdKNWRHVnpQREErUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhDYkc5amEzTWdmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1URUtJQ0FnSUM4dklIUm9hWE11WW14dlkydHpLR0pzYjJOcmMwdGxlU2t1WTNKbFlYUmxLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z1lteHZZMnNvYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCaFpHUnlaWE56T2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkVkeVlYQm9MblZ1WW14dlkydGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxYm1Kc2IyTnJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJSFZ1WW14dlkyc29ZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvSVhSb2FYTXVhWE5DWVc1dVpXUW9WSGh1TG5ObGJtUmxjaWtzSUVWU1VsOUNRVTVPUlVRcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlHbHpRbUZ1Ym1Wa0NpQWdJQ0JpZWlCMWJtSnNiMk5yWDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZMTh6SUM4dklDSkZVbEk2UWtGT1JDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwQ1FVNUVDZ3AxYm1Kc2IyTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXhOd29nSUNBZ0x5OGdZMjl1YzNRZ1lteHZZMnR6UzJWNUlEMGdkR2hwY3k1aWJHc29WSGh1TG5ObGJtUmxjaXdnWVdSa2NtVnpjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUdKc2F3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QmliRzlqYTNNZ1BTQkNiM2hOWVhBOFFteHZZMnRNYVhOMFMyVjVMQ0JpZVhSbGN6d3dQajRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRRbXh2WTJ0eklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFeE9Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFJvYVhNdVlteHZZMnR6S0dKc2IyTnJjMHRsZVNrdVpYaHBjM1J6TENCRlVsSmZWVk5GVWw5T1QxUmZRa3hQUTB0RlJDa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUhWdVlteHZZMnRmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbFZPUWtzaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2VlU1Q1N3b0tkVzVpYkc5amExOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1Ua0tJQ0FnSUM4dklIUm9hWE11WW14dlkydHpLR0pzYjJOcmMwdGxlU2t1WkdWc1pYUmxLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1qRXRNVEkyQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrdVlteHZZMnR6Q2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFeU13b2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5QmhiVzkxYm5RNklIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrdVlteHZZMnR6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtMWljZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNakV0TVRJMUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa3VZbXh2WTJ0ekNpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRJeExURXlOZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCMGFHbHpMbTFpY2loQ2VYUmxjeWduSnlrc0lDY25MQ0JDZVhSbGN5Z25KeWtwTG1Kc2IyTnJjd29nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCMWJtSnNiMk5yS0dGa1pISmxjM002SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzUjNKaGNHZ3VaMkYwWldSR2IyeHNiM2RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbllYUmxaRVp2Ykd4dmR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNamt0TVRNekNpQWdJQ0F2THlCbllYUmxaRVp2Ykd4dmR5Z0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQW9nSUNBZ0x5OGdJQ0JuWVhSbFZIaHVPaUJuZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkZSNGJpd0tJQ0FnSUM4dklDQWdZV1JrY21WemN6b2dRV05qYjNWdWRBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoY0hCc0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdZMjl1YzNRZ2V5Qm1iMnhzYjNkSFlYUmxTVVFnZlNBOUlIUm9hWE11WjJWMFRXVjBZU2hoWkdSeVpYTnpLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUk5aWFJoQ2lBZ0lDQmxlSFJ5WVdOMElEVXdJRGdLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TXpVS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaG5ZWFJsUTJobFkyc29aMkYwWlZSNGJpd2dkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnVkhodUxuTmxibVJsY2l3Z1ptOXNiRzkzUjJGMFpVbEVLU3dnUlZKU1gwWkJTVXhGUkY5SFFWUkZLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qSTNDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR2RoZEdWRGFHVmpheWhuWVhSbFZIaHVMQ0IwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCVWVHNHVjMlZ1WkdWeUxDQm1iMnhzYjNkSFlYUmxTVVFwTENCRlVsSmZSa0ZKVEVWRVgwZEJWRVVwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lNek1LSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3U1dRZ1BUMDlJRUZ3Y0d4cFkyRjBhVzl1S0dkbGRFRnJhWFJoUVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1WjJGMFpTa2dKaVlLSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EUUtJQ0FnSUM4dklHTnZibk4wSUZ0aGNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6UVd0cGRHRkJjSEJNYVhOMEtTa0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVlXRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TXpNS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1NXUWdQVDA5SUVGd2NHeHBZMkYwYVc5dUtHZGxkRUZyYVhSaFFYQndUR2x6ZENoaGEybDBZVVJCVHlrdVoyRjBaU2tnSmlZS0lDQWdJSEIxYzJocGJuUWdOREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lNek10TWpNMENpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFbGtJRDA5UFNCQmNIQnNhV05oZEdsdmJpaG5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExtZGhkR1VwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG05dVEyOXRjR3hsZEdsdmJpQTlQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0lDWW1DaUFnSUNCaWVpQm5ZWFJsWkVadmJHeHZkMTlpYjI5c1gyWmhiSE5sUURFekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJek5Bb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dmJrTnZiWEJzWlhScGIyNGdQVDA5SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VG05UGNDQW1KZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHZDBlRzV6SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU16TXRNak0wQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3SUNZbUNpQWdJQ0JpYm5vZ1oyRjBaV1JHYjJ4c2IzZGZZbTl2YkY5bVlXeHpaVUF4TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TXpVS0lDQWdJQzh2SUdkaGRHVlVlRzR1Ym5WdFFYQndRWEpuY3lBOVBUMGdOQ0FtSmdvZ0lDQWdaR2xuSURNS0lDQWdJR2QwZUc1eklFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNak16TFRJek5Rb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkpaQ0E5UFQwZ1FYQndiR2xqWVhScGIyNG9aMlYwUVd0cGRHRkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNW5ZWFJsS1NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dmJrTnZiWEJzWlhScGIyNGdQVDA5SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VG05UGNDQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNXVkVzFCY0hCQmNtZHpJRDA5UFNBMElDWW1DaUFnSUNCaWVpQm5ZWFJsWkVadmJHeHZkMTlpYjI5c1gyWmhiSE5sUURFekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJek5nb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkJjbWR6S0RBcElEMDlQU0J0WlhSb2IyUlRaV3hsWTNSdmNqeDBlWEJsYjJZZ1IyRjBaUzV3Y205MGIzUjVjR1V1YlhWemRFTm9aV05yUGlncElDWW1DaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkMGVHNXpZWE1nUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBNemt5TWpZMU5TQXZMeUJ0WlhSb2IyUWdJbTExYzNSRGFHVmpheWhoWkdSeVpYTnpMSFZwYm5RMk5DeGllWFJsVzExYlhTbDJiMmxrSWdvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNak16TFRJek5nb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkpaQ0E5UFQwZ1FYQndiR2xqWVhScGIyNG9aMlYwUVd0cGRHRkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNW5ZWFJsS1NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dmJrTnZiWEJzWlhScGIyNGdQVDA5SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VG05UGNDQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNXVkVzFCY0hCQmNtZHpJRDA5UFNBMElDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRUZ5WjNNb01Da2dQVDA5SUcxbGRHaHZaRk5sYkdWamRHOXlQSFI1Y0dWdlppQkhZWFJsTG5CeWIzUnZkSGx3WlM1dGRYTjBRMmhsWTJzK0tDa2dKaVlLSUNBZ0lHSjZJR2RoZEdWa1JtOXNiRzkzWDJKdmIyeGZabUZzYzJWQU1UTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qTTNDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRUZ5WjNNb01Ta2dQVDA5SUc1bGR5QkJaR1J5WlhOektHTmhiR3hsY2lrdVlubDBaWE1nSmlZS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdaM1I0Ym5OaGN5QkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TXpNdE1qTTNDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRWxrSUQwOVBTQkJjSEJzYVdOaGRHbHZiaWhuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbWRoZEdVcElDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtOXVRMjl0Y0d4bGRHbHZiaUE5UFQwZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTUxYlVGd2NFRnlaM01nUFQwOUlEUWdKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3UVhKbmN5Z3dLU0E5UFQwZ2JXVjBhRzlrVTJWc1pXTjBiM0k4ZEhsd1pXOW1JRWRoZEdVdWNISnZkRzkwZVhCbExtMTFjM1JEYUdWamF6NG9LU0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCQmNtZHpLREVwSUQwOVBTQnVaWGNnUVdSa2NtVnpjeWhqWVd4c1pYSXBMbUo1ZEdWeklDWW1DaUFnSUNCaWVpQm5ZWFJsWkVadmJHeHZkMTlpYjI5c1gyWmhiSE5sUURFekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJek9Bb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkJjbWR6S0RJcElEMDlQU0JwZEc5aUtHbGtLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCbmRIaHVjMkZ6SUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXpNeTB5TXpnS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1NXUWdQVDA5SUVGd2NHeHBZMkYwYVc5dUtHZGxkRUZyYVhSaFFYQndUR2x6ZENoaGEybDBZVVJCVHlrdVoyRjBaU2tnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1YjI1RGIyMXdiR1YwYVc5dUlEMDlQU0JQYmtOdmJYQnNaWFJsUVdOMGFXOXVMazV2VDNBZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWJuVnRRWEJ3UVhKbmN5QTlQVDBnTkNBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkJjbWR6S0RBcElEMDlQU0J0WlhSb2IyUlRaV3hsWTNSdmNqeDBlWEJsYjJZZ1IyRjBaUzV3Y205MGIzUjVjR1V1YlhWemRFTm9aV05yUGlncElDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRUZ5WjNNb01Ta2dQVDA5SUc1bGR5QkJaR1J5WlhOektHTmhiR3hsY2lrdVlubDBaWE1nSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1FYSm5jeWd5S1NBOVBUMGdhWFJ2WWlocFpDa0tJQ0FnSUdKNklHZGhkR1ZrUm05c2JHOTNYMkp2YjJ4ZlptRnNjMlZBTVRNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwbllYUmxaRVp2Ykd4dmQxOWliMjlzWDIxbGNtZGxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR2RoZEdWRGFHVmpheWhuWVhSbFZIaHVMQ0IwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCVWVHNHVjMlZ1WkdWeUxDQm1iMnhzYjNkSFlYUmxTVVFwTENCRlVsSmZSa0ZKVEVWRVgwZEJWRVVwQ2lBZ0lDQmlibm9nWjJGMFpXUkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2taSFZFVWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlJrZFVSUW9LWjJGMFpXUkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRNM0NpQWdJQ0F2THlCamIyNXpkQ0I3SUdadmJHeHZkM01nZlNBOUlIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk9rSmhjMlZUYjJOcFlXd3ViV0p5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TXprdE1UUTFDaUFnSUNBdkx5QnRZWFJqYUNnS0lDQWdJQzh2SUNBZ2JXSnlVR0Y1YldWdWRDd0tJQ0FnSUM4dklDQWdld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdadmJHeHZkM01LSUNBZ0lDOHZJQ0FnZlFvZ0lDQWdMeThnS1N3S0lDQWdJR1JwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UUXlDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXpPUzB4TkRVS0lDQWdJQzh2SUcxaGRHTm9LQW9nSUNBZ0x5OGdJQ0J0WW5KUVlYbHRaVzUwTEFvZ0lDQWdMeThnSUNCN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dabTlzYkc5M2N3b2dJQ0FnTHk4Z0lDQjlDaUFnSUNBdkx5QXBMQW9nSUNBZ1BUMEtJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNemd0TVRRM0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9DaUFnSUNBdkx5QWdJRzFoZEdOb0tBb2dJQ0FnTHk4Z0lDQWdJRzFpY2xCaGVXMWxiblFzQ2lBZ0lDQXZMeUFnSUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUNBZ1lXMXZkVzUwT2lCbWIyeHNiM2R6Q2lBZ0lDQXZMeUFnSUNBZ2ZRb2dJQ0FnTHk4Z0lDQXBMQW9nSUNBZ0x5OGdJQ0JGVWxKZlNVNVdRVXhKUkY5UVFWbE5SVTVVQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmlibm9nWjJGMFpXUkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJa1ZTVWpwSlVFRlpJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09rbFFRVmtLQ21kaGRHVmtSbTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFME9Rb2dJQ0FnTHk4Z2RHaHBjeTVqY21WaGRHVkdiMnhzYjNjb1ZIaHVMbk5sYm1SbGNpd2dZV1JrY21WemN5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpVWnZiR3h2ZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFeU9TMHhNek1LSUNBZ0lDOHZJR2RoZEdWa1JtOXNiRzkzS0FvZ0lDQWdMeThnSUNCdFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0NpQWdJQ0F2THlBZ0lHZGhkR1ZVZUc0NklHZDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNWSGh1TEFvZ0lDQWdMeThnSUNCaFpHUnlaWE56T2lCQlkyTnZkVzUwQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kaGRHVmtSbTlzYkc5M1gySnZiMnhmWm1Gc2MyVkFNVE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQm5ZWFJsWkVadmJHeHZkMTlpYjI5c1gyMWxjbWRsUURFMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFZHlZWEJvTG1admJHeHZkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21admJHeHZkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUdadmJHeHZkeWh0WW5KUVlYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzSUdGa1pISmxjM002SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVFV6Q2lBZ0lDQXZMeUJqYjI1emRDQjdJR1p2Ykd4dmQwZGhkR1ZKUkNCOUlEMGdkR2hwY3k1blpYUk5aWFJoS0dGa1pISmxjM01wQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRTFsZEdFS0lDQWdJSEIxYzJocGJuUWdOVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRVMENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9abTlzYkc5M1IyRjBaVWxFSUQwOVBTQXdMQ0JGVWxKZlNFRlRYMGRCVkVVcENpQWdJQ0JpZWlCbWIyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa2hIVkVVaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2U0VkVVJRb0tabTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFMU5nb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCbWIyeHNiM2R6SUgwZ1BTQjBhR2x6TG0xaWNpaENlWFJsY3lnbkp5a3NJQ2NuTENCQ2VYUmxjeWduSnlrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbTFpY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRVNExURTJOQW9nSUNBZ0x5OGdiV0YwWTJnb0NpQWdJQ0F2THlBZ0lHMWljbEJoZVcxbGJuUXNDaUFnSUNBdkx5QWdJSHNLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCbWIyeHNiM2R6Q2lBZ0lDQXZMeUFnSUgwS0lDQWdJQzh2SUNrc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTJNUW9nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hOVGd0TVRZMENpQWdJQ0F2THlCdFlYUmphQ2dLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR1p2Ykd4dmQzTUtJQ0FnSUM4dklDQWdmUW9nSUNBZ0x5OGdLU3dLSUNBZ0lEMDlDaUFnSUNCemQyRndDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVFUzTFRFMk5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J0WVhSamFDZ0tJQ0FnSUM4dklDQWdJQ0J0WW5KUVlYbHRaVzUwTEFvZ0lDQWdMeThnSUNBZ0lIc0tJQ0FnSUM4dklDQWdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNBZ0lHRnRiM1Z1ZERvZ1ptOXNiRzkzY3dvZ0lDQWdMeThnSUNBZ0lIMEtJQ0FnSUM4dklDQWdLU3dLSUNBZ0lDOHZJQ0FnUlZKU1gwbE9Wa0ZNU1VSZlVFRlpUVVZPVkFvZ0lDQWdMeThnS1FvZ0lDQWdZbTU2SUdadmJHeHZkMTloWm5SbGNsOWhjM05sY25SQU5Rb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVJWSlNPa2xRUVZraUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2U1ZCQldRb0tabTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFMk9Bb2dJQ0FnTHk4Z2RHaHBjeTVqY21WaGRHVkdiMnhzYjNjb1ZIaHVMbk5sYm1SbGNpd2dZV1JrY21WemN5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpVWnZiR3h2ZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z1ptOXNiRzkzS0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzUxYm1admJHeHZkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25WdVptOXNiRzkzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TnpFS0lDQWdJQzh2SUhWdVptOXNiRzkzS0dGa1pISmxjM002SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUzTWdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtDRjBhR2x6TG1selFtRnVibVZrS0ZSNGJpNXpaVzVrWlhJcExDQkZVbEpmUWtGT1RrVkVLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJwYzBKaGJtNWxaQW9nSUNBZ1lub2dkVzVtYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWalh6TWdMeThnSWtWU1VqcENRVTVFSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPa0pCVGtRS0NuVnVabTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFM05Bb2dJQ0FnTHk4Z1kyOXVjM1FnWm05c2JHOTNjMHRsZVNBOUlIUm9hWE11Wm14M0tHRmtaSEpsYzNNc0lGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCa2RYQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdabXgzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdadmJHeHZkM01nUFNCQ2IzaE5ZWEE4Um05c2JHOTNjMHRsZVN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhHYjJ4c2IzZHpJSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ptSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0hSb2FYTXVabTlzYkc5M2N5aG1iMnhzYjNkelMyVjVLUzVsZUdsemRITXNJRVZTVWw5T1QxUmZSazlNVEU5WFNVNUhLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ2RXNW1iMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2s1R1RGY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlRrWk1Wd29LZFc1bWIyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGM0Q2lBZ0lDQXZMeUJqYjI1emRDQjdJR1p2Ykd4dmQyVnlRMjkxYm5Rc0lHWnZiR3h2ZDJWeVNXNWtaWGdnZlNBOUlIUm9hWE11WjJWMFRXVjBZU2hoWkdSeVpYTnpLUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRTFsZEdFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ016TUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGd3Q2lBZ0lDQXZMeUIwYUdsekxuVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlTaGhaR1J5WlhOekxDQm1iMnhzYjNkbGNrbHVaR1Y0TENCbWIyeHNiM2RsY2tOdmRXNTBJQzBnTVNrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFNE1Rb2dJQ0FnTHk4Z2RHaHBjeTVtYjJ4c2IzZHpLR1p2Ykd4dmQzTkxaWGtwTG1SbGJHVjBaU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UZ3pMVEU0T0FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQjBhR2x6TG0xaWNpaENlWFJsY3lnbkp5a3NJQ2NuTENCQ2VYUmxjeWduSnlrcExtWnZiR3h2ZDNNS0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UZzFDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hPRFlLSUNBZ0lDOHZJR0Z0YjNWdWREb2dkR2hwY3k1dFluSW9RbmwwWlhNb0p5Y3BMQ0FuSnl3Z1FubDBaWE1vSnljcEtTNW1iMnhzYjNkekNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbTFpY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFNE15MHhPRGNLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTV0WW5Jb1FubDBaWE1vSnljcExDQW5KeXdnUW5sMFpYTW9KeWNwS1M1bWIyeHNiM2R6Q2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGd6TFRFNE9Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUIwYUdsekxtMWljaWhDZVhSbGN5Z25KeWtzSUNjbkxDQkNlWFJsY3lnbkp5a3BMbVp2Ykd4dmQzTUtJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUzTVFvZ0lDQWdMeThnZFc1bWIyeHNiM2NvWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNXBjMEpzYjJOclpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzBKc2IyTnJaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1Ua3pDaUFnSUNBdkx5QmpiMjV6ZENCaWJHOWphM05MWlhrZ1BTQjBhR2x6TG1Kc2F5aDFjMlZ5TENCaWJHOWphMlZrS1FvZ0lDQWdZMkZzYkhOMVlpQmliR3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnWW14dlkydHpJRDBnUW05NFRXRndQRUpzYjJOclRHbHpkRXRsZVN3Z1lubDBaWE04TUQ0K0tIc2dhMlY1VUhKbFptbDRPaUJCYTJsMFlWTnZZMmxoYkVKdmVGQnlaV1pwZUVKc2IyTnJjeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWWlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTVOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WW14dlkydHpLR0pzYjJOcmMwdGxlU2t1WlhocGMzUnpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1cGMwWnZiR3h2ZDJsdVoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx6Um05c2JHOTNhVzVuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFNU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTVPUW9nSUNBZ0x5OGdZMjl1YzNRZ1ptOXNiRzkzYzB0bGVTQTlJSFJvYVhNdVpteDNLSFZ6WlhJc0lHWnZiR3h2ZDJWeUtRb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJtYkhjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1ptOXNiRzkzY3lBOUlFSnZlRTFoY0R4R2IyeHNiM2R6UzJWNUxDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUJCYTJsMFlWTnZZMmxoYkVKdmVGQnlaV1pwZUVadmJHeHZkM01nZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1ZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3lNREFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1admJHeHZkM01vWm05c2JHOTNjMHRsZVNrdVpYaHBjM1J6Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNW5aWFJHYjJ4c2IzZEpibVJsZUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRVp2Ykd4dmQwbHVaR1Y0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJd013b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qSXdOUW9nSUNBZ0x5OGdZMjl1YzNRZ1ptOXNiRzkzYzB0bGVTQTlJSFJvYVhNdVpteDNLSFZ6WlhJc0lHWnZiR3h2ZDJWeUtRb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJtYkhjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1ptOXNiRzkzY3lBOUlFSnZlRTFoY0R4R2IyeHNiM2R6UzJWNUxDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUJCYTJsMFlWTnZZMmxoYkVKdmVGQnlaV1pwZUVadmJHeHZkM01nZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1ZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3lNRFlLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1admJHeHZkM01vWm05c2JHOTNjMHRsZVNrdWRtRnNkV1VLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpBekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZPa0poYzJWVGIyTnBZV3d1YldKeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiV0p5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qRTFDaUFnSUNBdkx5QnRZbklvY21WbU9pQmllWFJsY3l3Z2NtVm1WSGx3WlU1aGJXVTZJSE4wY21sdVp5d2djbVZtVkhsd1pWTmphR1Z0WVRvZ1lubDBaWE1wT2lCQmEybDBZVk52WTJsaGJFMUNVa1JoZEdFZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZPa0poYzJWVGIyTnBZV3d1YldKeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbkJoZVZkaGJHeE5ZbkpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd1lYbFhZV3hzVFdKeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPak0wQ2lBZ0lDQXZMeUJ3WVhsWFlXeHNUV0p5S0hCaGVYZGhiR3c2SUZacFpYZFFZWGxYWVd4c1ZtRnNkV1VwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURBZ2IyWWdLQ2hzWlc0cktIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME5qUXBXMTBwTENoc1pXNHJLSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFwVzEwcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXhDaUFnSUNCa2FXY2dNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UY0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ0t3b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2dvYkdWdUt5aDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBLVnRkS1N3b2JHVnVLeWgxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZEtTa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRFVLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UY0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOTBlWEJsY3k1MGN6bzZWbWxsZDFCaGVWZGhiR3hXWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPak0zQ2lBZ0lDQXZMeUJRWVhsWFlXeHNVR0Y1VDNCMGFXOXVVMmw2WlNBcUlDaHdZWGwzWVd4c0xtRm5aVzUwVUdGNVNXNW1ieTVzWlc1bmRHZ2dLeUJ3WVhsM1lXeHNMblZ6WlhKUVlYbEpibVp2TG14bGJtZDBhQ2tLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk16WXRNemdLSUNBZ0lDOHZJRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2dLQW9nSUNBZ0x5OGdJQ0JRWVhsWFlXeHNVR0Y1VDNCMGFXOXVVMmw2WlNBcUlDaHdZWGwzWVd4c0xtRm5aVzUwVUdGNVNXNW1ieTVzWlc1bmRHZ2dLeUJ3WVhsM1lXeHNMblZ6WlhKUVlYbEpibVp2TG14bGJtZDBhQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhwYm5RZ05qZ3dNQW9nSUNBZ0tnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPak0xQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdUV2x1VUdGNVYyRnNiRTFDVWlBcklDZ0tJQ0FnSUhCMWMyaHBiblFnTlRJd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPak0xTFRNNUNpQWdJQ0F2THlCeVpYUjFjbTRnVFdsdVVHRjVWMkZzYkUxQ1VpQXJJQ2dLSUNBZ0lDOHZJQ0FnUW05NFEyOXpkRkJsY2tKNWRHVWdLaUFvQ2lBZ0lDQXZMeUFnSUNBZ1VHRjVWMkZzYkZCaGVVOXdkR2x2YmxOcGVtVWdLaUFvY0dGNWQyRnNiQzVoWjJWdWRGQmhlVWx1Wm04dWJHVnVaM1JvSUNzZ2NHRjVkMkZzYkM1MWMyVnlVR0Y1U1c1bWJ5NXNaVzVuZEdncENpQWdJQ0F2THlBZ0lDa0tJQ0FnSUM4dklDa0tJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6b3pOQW9nSUNBZ0x5OGdjR0Y1VjJGc2JFMWljaWh3WVhsM1lXeHNPaUJXYVdWM1VHRjVWMkZzYkZaaGJIVmxLVG9nZFdsdWREWTBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02T2tKaGMyVlRiMk5wWVd3dVkyaGxZMnRVYVhCTlluSlNaWEYxYVhKbGJXVnVkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvMU5Rb2dJQ0FnTHk4Z1kyaGxZMnRVYVhCTlluSlNaWEYxYVhKbGJXVnVkSE1vWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUxDQmpjbVZoZEc5eU9pQkJZMk52ZFc1MExDQjNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVLVG9nZEdsd1RVSlNTVzVtYnlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qazRDaUFnSUNBdkx5QmpiMjV6ZENCaGEybDBZVUZ6YzJWMGMwSjVkR1Z6SUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselFXdHBkR0ZCYzNObGRITXBLVnN3WFFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poYTJsMFlWOWhjM05sZEhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TlRZS0lDQWdJQzh2SUdOdmJuTjBJR0ZyZEdFZ1BTQkJjM05sZENoblpYUkJhMmwwWVVGemMyVjBjeWhoYTJsMFlVUkJUeWt1WVd0MFlTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalU0Q2lBZ0lDQXZMeUJwWmlBb0lXTnlaV0YwYjNJdWFYTlBjSFJsWkVsdUtHRnJkR0VwSUNZbUlIZGhiR3hsZEM1cFpDQWhQVDBnTUNrZ2V3b2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQmphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwYzE5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lHUjFjQW9nSUNBZ1lub2dZMmhsWTJ0VWFYQk5ZbkpTWlhGMWFYSmxiV1Z1ZEhOZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk5ETXROVElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhZbWxEWVd4c1BIUjVjR1Z2WmlCQlluTjBjbUZqZEdWa1FXTmpiM1Z1ZEM1d2NtOTBiM1I1Y0dVdVlYSmpOVGhmWTJGdVEyRnNiRDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUdkbGRGQnNkV2RwYmtGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG05d2RHbHVMQW9nSUNBZ0x5OGdJQ0FnSUVOaGJHeGxjbFI1Y0dWSGJHOWlZV3dzQ2lBZ0lDQXZMeUFnSUNBZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJQ2NuTEFvZ0lDQWdMeThnSUNBZ0lHMWxkR2h2WkZObGJHVmpkRzl5UEhSNWNHVnZaaUJQY0hSSmJsQnNkV2RwYmk1d2NtOTBiM1I1Y0dVdWIzQjBTVzQrS0NrS0lDQWdJQzh2SUNBZ1hRb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5UUUtJQ0FnSUM4dklHTnZibk4wSUZ0d2JIVm5hVzVCY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpVR3gxWjJsdVFYQndUR2x6ZENrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWNHRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qUTJDaUFnSUNBdkx5Qm5aWFJRYkhWbmFXNUJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNXZjSFJwYml3S0lDQWdJR1Y0ZEhKaFkzUWdNQ0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk5EY0tJQ0FnSUM4dklFTmhiR3hsY2xSNWNHVkhiRzlpWVd3c0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qUTRDaUFnSUNBdkx5QkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem8wTXkwMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRUZpYzNSeVlXTjBaV1JCWTJOdmRXNTBMbkJ5YjNSdmRIbHdaUzVoY21NMU9GOWpZVzVEWVd4c1BpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdaMlYwVUd4MVoybHVRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3ViM0IwYVc0c0NpQWdJQ0F2THlBZ0lDQWdRMkZzYkdWeVZIbHdaVWRzYjJKaGJDd0tJQ0FnSUM4dklDQWdJQ0JIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ0p5Y3NDaUFnSUNBdkx5QWdJQ0FnYldWMGFHOWtVMlZzWldOMGIzSThkSGx3Wlc5bUlFOXdkRWx1VUd4MVoybHVMbkJ5YjNSdmRIbHdaUzV2Y0hSSmJqNG9LUW9nSUNBZ0x5OGdJQ0JkQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqTTJNak0wWVRVZ0x5OGdiV1YwYUc5a0lDSmhjbU0xT0Y5allXNURZV3hzS0hWcGJuUTJOQ3gxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jc1lubDBaVnMwWFNsaWIyOXNJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qUTVDaUFnSUNBdkx5QW5KeXdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TlRBS0lDQWdJQzh2SUcxbGRHaHZaRk5sYkdWamRHOXlQSFI1Y0dWdlppQlBjSFJKYmxCc2RXZHBiaTV3Y205MGIzUjVjR1V1YjNCMFNXNCtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFk0TXpWbE0ySmpJQzh2SUcxbGRHaHZaQ0FpYjNCMFNXNG9kV2x1ZERZMExHSnZiMndzZFdsdWREWTBXMTBzY0dGNUtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalF6TFRVeUNpQWdJQ0F2THlCeVpYUjFjbTRnWVdKcFEyRnNiRHgwZVhCbGIyWWdRV0p6ZEhKaFkzUmxaRUZqWTI5MWJuUXVjSEp2ZEc5MGVYQmxMbUZ5WXpVNFgyTmhia05oYkd3K0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQm5aWFJRYkhWbmFXNUJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNXZjSFJwYml3S0lDQWdJQzh2SUNBZ0lDQkRZV3hzWlhKVWVYQmxSMnh2WW1Gc0xBb2dJQ0FnTHk4Z0lDQWdJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNBbkp5d0tJQ0FnSUM4dklDQWdJQ0J0WlhSb2IyUlRaV3hsWTNSdmNqeDBlWEJsYjJZZ1QzQjBTVzVRYkhWbmFXNHVjSEp2ZEc5MGVYQmxMbTl3ZEVsdVBpZ3BDaUFnSUNBdkx5QWdJRjBLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pZd0NpQWdJQ0F2THlCcFppQW9ZMkZ1UTJGc2JFRnlZelU0VDNCMFNXNHBJSHNLSUNBZ0lHSjZJR05vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qWXpDaUFnSUNBdkx5QmhjbU0xT0RvZ1IyeHZZbUZzTG1GemMyVjBUM0IwU1c1TmFXNUNZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRWE56WlhSUGNIUkpiazFwYmtKaGJHRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvMk1TMDJOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdkSGx3WlRvZ1ZHbHdVMlZ1WkZSNWNHVkJVa00xT0N3S0lDQWdJQzh2SUNBZ1lYSmpOVGc2SUVkc2IySmhiQzVoYzNObGRFOXdkRWx1VFdsdVFtRnNZVzVqWlFvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qWXlDaUFnSUNBdkx5QjBlWEJsT2lCVWFYQlRaVzVrVkhsd1pVRlNRelU0TEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzJNUzAyTkFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dWR2x3VTJWdVpGUjVjR1ZCVWtNMU9Dd0tJQ0FnSUM4dklDQWdZWEpqTlRnNklFZHNiMkpoYkM1aGMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnTHk4Z2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDZ3BqYUdWamExUnBjRTFpY2xKbGNYVnBjbVZ0Wlc1MGMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzZRbUZ6WlZOdlkybGhiQzVqYUdWamExUnBjRTFpY2xKbGNYVnBjbVZ0Wlc1MGMwQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pVMUNpQWdJQ0F2THlCamFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0c0lHTnlaV0YwYjNJNklFRmpZMjkxYm5Rc0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHBPaUIwYVhCTlFsSkpibVp2SUhzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvMk9DMDNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdkSGx3WlRvZ1ZHbHdVMlZ1WkZSNWNHVkVhWEpsWTNRc0NpQWdJQ0F2THlBZ0lHRnlZelU0T2lBd0NpQWdJQ0F2THlCOUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1lUQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzFOUW9nSUNBZ0x5OGdZMmhsWTJ0VWFYQk5ZbkpTWlhGMWFYSmxiV1Z1ZEhNb1lXdHBkR0ZFUVU4NklFRndjR3hwWTJGMGFXOXVMQ0JqY21WaGRHOXlPaUJCWTJOdmRXNTBMQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ2RHbHdUVUpTU1c1bWJ5QjdDaUFnSUNCaUlHTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6UURjS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem82VlhCbmNtRmtaV0ZpYkdWQmEybDBZVUpoYzJWRGIyNTBjbUZqZEM1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8wTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlkZElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TkRnS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luZGhiR3hsZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qUTRDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1blpYUkJhMmwwWVVSQlQxZGhiR3hsZENncExtRmtaSEpsYzNNc0lFVlNVbDlPVDFSZlFVdEpWRUZmUkVGUEtRb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCMWNHUmhkR1ZmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSkZVbEk2VGtSQlR5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwT1JFRlBDZ3AxY0dSaGRHVmZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME9Rb2dJQ0FnTHk4Z1kyOXVjM1FnZFhCa1lYUmxVR3gxWjJsdUlEMGdaMlYwVUd4MVoybHVRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzUxY0dSaGRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pveU53b2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPalE1Q2lBZ0lDQXZMeUJqYjI1emRDQjFjR1JoZEdWUWJIVm5hVzRnUFNCblpYUlFiSFZuYVc1QmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcExuVndaR0YwWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOVFFLSUNBZ0lDOHZJR052Ym5OMElGdHdiSFZuYVc1QmNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VUd4MVoybHVRWEJ3VEdsemRDa3BDaUFnSUNCaWVYUmxZeUE1SUM4dklDSndZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME9Rb2dJQ0FnTHk4Z1kyOXVjM1FnZFhCa1lYUmxVR3gxWjJsdUlEMGdaMlYwVUd4MVoybHVRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzUxY0dSaGRHVUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvMU1Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRWRzYjJKaGJDNWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrbGtJRDA5UFNCMWNHUmhkR1ZRYkhWbmFXNHNJRVZTVWw5SlRsWkJURWxFWDFWUVIxSkJSRVVwQ2lBZ0lDQm5iRzlpWVd3Z1EyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCMWNHUmhkR1ZmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa2xWVUVjaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2U1ZWUVJ3b0tkWEJrWVhSbFgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpVS0lDQWdJQzh2SUhabGNuTnBiMjRnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVlpsY25OcGIyNGdmU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblpsY25OcGIyNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzFNUW9nSUNBZ0x5OGdkR2hwY3k1MlpYSnphVzl1TG5aaGJIVmxJRDBnYm1WM1ZtVnljMmx2YmdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZFZjR1JoZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZPa0ZyYVhSaFFtRnpaVU52Ym5SeVlXTjBMblZ3WkdGMFpVRnJhWFJoUkVGUFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFFXdHBkR0ZFUVU4NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek5nb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk16Y0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1JWSlNYMDVQVkY5QlMwbFVRVjlFUVU4cENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem96TUFvZ0lDQWdMeThnWTI5dWMzUWdXM2RoYkd4bGRFbEVYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUZWcGJuUTJOQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxZGhiR3hsZENrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbmRoYkd4bGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPak0zQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJRVZTVWw5T1QxUmZRVXRKVkVGZlJFRlBLUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQjFjR1JoZEdWQmEybDBZVVJCVDE5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV01nTVRFZ0x5OGdJa1ZTVWpwT1JFRlBJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09rNUVRVThLQ25Wd1pHRjBaVUZyYVhSaFJFRlBYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qY0tJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem96T0FvZ0lDQWdMeThnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNBOUlHRnJhWFJoUkVGUENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qTTJDaUFnSUNBdkx5QjFjR1JoZEdWQmEybDBZVVJCVHloaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9rRnJhWFJoVTI5amFXRnNSM0poY0dndWFYTkNZVzV1WldRb1lXTmpiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2FYTkNZVzV1WldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklIQnlhWFpoZEdVZ2FYTkNZVzV1WldRb1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZENrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdOdmJuTjBJSHNnYlc5a1pYSmhkR2x2YmlCOUlEMGdaMlYwUVd0cGRHRlRiMk5wWVd4QmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJR052Ym5OMElIc2diVzlrWlhKaGRHbHZiaUI5SUQwZ1oyVjBRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBPUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyRndjRXhwYzNSQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoYTJsMFlVUkJUeXdnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVk52WTJsaGJFRndjRXhwYzNRcEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWMyRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCamIyNXpkQ0I3SUcxdlpHVnlZWFJwYjI0Z2ZTQTlJR2RsZEVGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtRb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvek15MHpOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRmlhVU5oYkd3OGRIbHdaVzltSUVGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpNXdjbTkwYjNSNWNHVXVhWE5DWVc1dVpXUStLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJRzF2WkdWeVlYUnBiMjRzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRoWTJOdmRXNTBYUW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RReU5qbGpOemdnTHk4Z2JXVjBhRzlrSUNKcGMwSmhibTVsWkNoaFpHUnlaWE56S1dKdmIyd2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHSnZiMndLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzVpYkdzb2RYTmxja0ZrWkhKbGMzTTZJR0o1ZEdWekxDQmliRzlqYTJWa1FXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwaWJHczZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdZbXhyS0hWelpYSkJaR1J5WlhOek9pQkJZMk52ZFc1MExDQmliRzlqYTJWa1FXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklFSnNiMk5yVEdsemRFdGxlU0I3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYTmxjaUE5SUhWelpYSkJaR1J5WlhOekxtSjVkR1Z6TG5Oc2FXTmxLREFzSURFMktTNTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQXhOaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWTI5dWMzUWdZbXh2WTJ0bFpDQTlJR0pzYjJOclpXUkJaR1J5WlhOekxtSjVkR1Z6TG5Oc2FXTmxLREFzSURFMktTNTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQXhOaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnY21WMGRYSnVJSHNnZFhObGNpd2dZbXh2WTJ0bFpDQjlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzVtYkhjb2RYTmxjam9nWW5sMFpYTXNJR1p2Ykd4dmQyVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbVpzZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z2NISnBkbUYwWlNCbWJIY29kWE5sY2pvZ1FXTmpiM1Z1ZEN3Z1ptOXNiRzkzWlhJNklFRmpZMjkxYm5RcE9pQkdiMnhzYjNkelMyVjVJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmpiMjV6ZENCMWMyVnlRbmwwWlhNZ1BTQjFjMlZ5TG1KNWRHVnpMbk5zYVdObEtEQXNJREUyS1M1MGIwWnBlR1ZrS0hzZ2JHVnVaM1JvT2lBeE5pQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemRXSnpkSEpwYm1jZ01DQXhOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUR1Z1WjNSb0lHMTFjM1FnWW1VZ01UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZMjl1YzNRZ1ptOXNiRzkzWlhKQ2VYUmxjeUE5SUdadmJHeHZkMlZ5TG1KNWRHVnpMbk5zYVdObEtEQXNJREUyS1M1MGIwWnBlR1ZrS0hzZ2JHVnVaM1JvT2lBeE5pQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ01DQXhOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUR1Z1WjNSb0lHMTFjM1FnWW1VZ01UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIc2dkWE5sY2pvZ2RYTmxja0o1ZEdWekxDQm1iMnhzYjNkbGNqb2dabTlzYkc5M1pYSkNlWFJsY3lCOUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNW5aWFJOWlhSaEtHRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBUV1YwWVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2NISnBkbUYwWlNCblpYUk5aWFJoS0dGa1pISmxjM002SUVGalkyOTFiblFwT2lCTlpYUmhWbUZzZFdVZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUdOdmJuTjBJSHNnYzI5amFXRnNJSDBnUFNCblpYUkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCemIyTnBZV3dnZlNBOUlHZGxkRUZyYVhSaFUyOWphV0ZzUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORGtLSUNBZ0lDOHZJR052Ym5OMElGdGhjSEJNYVhOMFFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselFXdHBkR0ZUYjJOcFlXeEJjSEJNYVhOMEtTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luTmhiQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCemIyTnBZV3dnZlNBOUlHZGxkRUZyYVhSaFUyOWphV0ZzUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TlRVdE5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaFltbERZV3hzUEhSNWNHVnZaaUJCYTJsMFlWTnZZMmxoYkM1d2NtOTBiM1I1Y0dVdVoyVjBUV1YwWVQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2MyOWphV0ZzTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWVdSa2NtVnpjMTBLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjek9XVmhOekJpSUM4dklHMWxkR2h2WkNBaVoyVjBUV1YwWVNoaFpHUnlaWE56S1NoaWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ056UUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZkSGx3WlhNdWRITTZPazFsZEdGV1lXeDFaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkVkeVlYQm9MblZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZU2hoWTJOdmRXNTBPaUJpZVhSbGN5d2dibVYzUm05c2JHOTNaWEpKYm1SbGVEb2dkV2x1ZERZMExDQnVaWGRHYjJ4c2IzZGxja052ZFc1ME9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdjSEpwZG1GMFpTQjFjR1JoZEdWR2IyeHNiM2RsY2sxbGRHRW9ZV05qYjNWdWREb2dRV05qYjNWdWRDd2dibVYzUm05c2JHOTNaWEpKYm1SbGVEb2dkV2x1ZERZMExDQnVaWGRHYjJ4c2IzZGxja052ZFc1ME9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJqYjI1emRDQjdJSE52WTJsaGJDQjlJRDBnWjJWMFFXdHBkR0ZUYjJOcFlXeEJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qY0tJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUdOdmJuTjBJSHNnYzI5amFXRnNJSDBnUFNCblpYUkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qUTVDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENrcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKellXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUdOdmJuTjBJSHNnYzI5amFXRnNJSDBnUFNCblpYUkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPall6TFRZMkNpQWdJQ0F2THlCaFltbERZV3hzUEhSNWNHVnZaaUJCYTJsMFlWTnZZMmxoYkM1d2NtOTBiM1I1Y0dVdWRYQmtZWFJsUm05c2JHOTNaWEpOWlhSaFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQnpiMk5wWVd3c0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0aFkyTnZkVzUwTENCdVpYZEdiMnhzYjNkbGNrbHVaR1Y0TENCdVpYZEdiMnhzYjNkbGNrTnZkVzUwWFFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8yTlFvZ0lDQWdMeThnWVhKbmN6b2dXMkZqWTI5MWJuUXNJRzVsZDBadmJHeHZkMlZ5U1c1a1pYZ3NJRzVsZDBadmJHeHZkMlZ5UTI5MWJuUmRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvMk15MDJOZ29nSUNBZ0x5OGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1FXdHBkR0ZUYjJOcFlXd3VjSEp2ZEc5MGVYQmxMblZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nYzI5amFXRnNMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJZV05qYjNWdWRDd2dibVYzUm05c2JHOTNaWEpKYm1SbGVDd2dibVYzUm05c2JHOTNaWEpEYjNWdWRGMEtJQ0FnSUM4dklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3pNekEyWWpNeVlTQXZMeUJ0WlhSb2IyUWdJblZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9rRnJhWFJoVTI5amFXRnNSM0poY0dndVkzSmxZWFJsUm05c2JHOTNLSE5sYm1SbGNqb2dZbmwwWlhNc0lHRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZHYjJ4c2IzYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdZM0psWVhSbFJtOXNiRzkzS0hObGJtUmxjam9nUVdOamIzVnVkQ3dnWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9JWFJvYVhNdWFYTkNZVzV1WldRb2MyVnVaR1Z5S1N3Z1JWSlNYMEpCVGs1RlJDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJwYzBKaGJtNWxaQW9nSUNBZ1lub2dZM0psWVhSbFJtOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQXlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSkZVbEk2UWtGT1JDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwQ1FVNUVDZ3BqY21WaGRHVkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRrekNpQWdJQ0F2THlCamIyNXpkQ0JpYkc5amEzTkxaWGtnUFNCMGFHbHpMbUpzYXloMWMyVnlMQ0JpYkc5amEyVmtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnWW14ckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHSnNiMk5yY3lBOUlFSnZlRTFoY0R4Q2JHOWphMHhwYzNSTFpYa3NJR0o1ZEdWelBEQStQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaENiRzlqYTNNZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94T1RRS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtSnNiMk5yY3loaWJHOWphM05MWlhrcExtVjRhWE4wY3dvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENnaGRHaHBjeTVwYzBKc2IyTnJaV1FvWVdSa2NtVnpjeXdnYzJWdVpHVnlLU3dnUlZKU1gwSk1UME5MUlVRcENpQWdJQ0JpZWlCamNtVmhkR1ZHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURRS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rSk1TMFFpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZRa3hMUkFvS1kzSmxZWFJsUm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYzJWdVpHVnlJQ0U5UFNCaFpHUnlaWE56TENCRlVsSmZVMFZNUmw5R1QweE1UMWNwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0lUMEtJQ0FnSUdKdWVpQmpjbVZoZEdWR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFEWUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbE5HVEZjaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2VTBaTVZ3b0tZM0psWVhSbFJtOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJqYjI1emRDQjdJR0YxZEc5dFlYUmxaQ0I5SUQwZ2RHaHBjeTVuWlhSTlpYUmhLSE5sYm1SbGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJuWlhSTlpYUmhDaUFnSUNCd2RYTm9hVzUwSURNNU1nb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENnaFlYVjBiMjFoZEdWa0xDQkZVbEpmUVZWVVQwMUJWRVZFWDBGRFEwOVZUbFFwQ2lBZ0lDQmllaUJqY21WaGRHVkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRGdLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2tGVlZFOGlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlFWVlVUd29LWTNKbFlYUmxSbTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pjNUNpQWdJQ0F2THlCamIyNXpkQ0JtYjJ4c2IzZHpTMlY1SUQwZ2RHaHBjeTVtYkhjb1lXUmtjbVZ6Y3l3Z2MyVnVaR1Z5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1pteDNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJR1p2Ykd4dmQzTWdQU0JDYjNoTllYQThSbTlzYkc5M2MwdGxlU3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaEdiMnhzYjNkeklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSm1JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb0lYUm9hWE11Wm05c2JHOTNjeWhtYjJ4c2IzZHpTMlY1S1M1bGVHbHpkSE1zSUVWU1VsOUJURkpGUVVSWlgwWlBURXhQVjBsT1J5a0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWTNKbFlYUmxSbTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUF4TUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlFVWk1WeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcEJSa3hYQ2dwamNtVmhkR1ZHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QmpiMjV6ZENCN0lHWnZiR3h2ZDJWeVEyOTFiblFzSUdadmJHeHZkMlZ5U1c1a1pYZ2dmU0E5SUhSb2FYTXVaMlYwVFdWMFlTaGhaR1J5WlhOektRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJR2RsZEUxbGRHRUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwTVFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNek1LSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUhSb2FYTXVabTlzYkc5M2N5aG1iMnhzYjNkelMyVjVLUzUyWVd4MVpTQTlJR1p2Ykd4dmQyVnlTVzVrWlhnZ0t5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCMGFHbHpMblZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZU2hoWkdSeVpYTnpMQ0JtYjJ4c2IzZGxja2x1WkdWNElDc2dNU3dnWm05c2JHOTNaWEpEYjNWdWRDQXJJREVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbTFpY2loeVpXWTZJR0o1ZEdWekxDQnlaV1pVZVhCbFRtRnRaVG9nWW5sMFpYTXNJSEpsWmxSNWNHVlRZMmhsYldFNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG0xaWNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem94TlFvZ0lDQWdMeThnYldKeUtISmxaam9nWW5sMFpYTXNJSEpsWmxSNWNHVk9ZVzFsT2lCemRISnBibWNzSUhKbFpsUjVjR1ZUWTJobGJXRTZJR0o1ZEdWektUb2dRV3RwZEdGVGIyTnBZV3hOUWxKRVlYUmhJSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPakU1Q2lBZ0lDQXZMeUJ3YjNOMGN6b2dUV2x1VUc5emRITk5RbElnS3lBb1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lCeVpXWXViR1Z1WjNSb0tTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFF3TUFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBME5qVXdNQW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPak13Q2lBZ0lDQXZMeUJ5WldaVWVYQmxjem9nVW1WbVZIbHdaWE5DWVhObFRVSlNJQ3NnS0VKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nS0VKNWRHVnpLSEpsWmxSNWNHVk9ZVzFsS1M1c1pXNW5kR2dnS3lCQ2VYUmxjeWh5WldaVWVYQmxVMk5vWlcxaEtTNXNaVzVuZEdncEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQXJDaUFnSUNCd2RYTm9hVzUwSURRd01Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTVNekF3Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TVRZdE16RUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHWnZiR3h2ZDNNNklFWnZiR3h2ZDNOTlFsSXNDaUFnSUNBdkx5QWdJR0pzYjJOcmN6b2dRbXh2WTJ0elRVSlNMQW9nSUNBZ0x5OGdJQ0J3YjNOMGN6b2dUV2x1VUc5emRITk5RbElnS3lBb1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lCeVpXWXViR1Z1WjNSb0tTd0tJQ0FnSUM4dklDQWdkbTkwWlhNNklGWnZkR1Z6VFVKU0xBb2dJQ0FnTHk4Z0lDQjJiM1JsYkdsemREb2dWbTkwWld4cGMzUk5RbElzQ2lBZ0lDQXZMeUFnSUhKbFlXTjBhVzl1Y3pvZ1VtVmhZM1JwYjI1elRVSlNMQW9nSUNBZ0x5OGdJQ0J5WldGamRHbHZibXhwYzNRNklGSmxZV04wYVc5dWJHbHpkRTFDVWl3S0lDQWdJQzh2SUNBZ2JXVjBZVG9nVFdWMFlVMUNVaXdLSUNBZ0lDOHZJQ0FnYlc5a1pYSmhkRzl5Y3pvZ1RXOWtaWEpoZEc5eWMwMUNVaXdLSUNBZ0lDOHZJQ0FnWW1GdWJtVmtPaUJDWVc1dVpXUk5RbElzQ2lBZ0lDQXZMeUFnSUdGamRHbHZibk02SUVGamRHbHZibk5OUWxJc0NpQWdJQ0F2THlBZ0lDOHZJRUp2ZUNCclpYazZJSEJ5WldacGVDZ3hLU0FySUhWcGJuUTJOQ2c0S1NBOUlEa2dZbmwwWlhNS0lDQWdJQzh2SUNBZ0x5OGdRbTk0SUhaaGJIVmxPaUJCVWtNdE5DQm9aV0ZrWlhJb05Da2dLeUJ6ZEhKcGJtY2diR1Z1WjNSb0tESXBJQ3NnYm1GdFpTQXJJR0o1ZEdWeklHeGxibWQwYUNneUtTQXJJSE5qYUdWdFlRb2dJQ0FnTHk4Z0lDQnlaV1pVZVhCbGN6b2dVbVZtVkhsd1pYTkNZWE5sVFVKU0lDc2dLRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2dLRUo1ZEdWektISmxabFI1Y0dWT1lXMWxLUzVzWlc1bmRHZ2dLeUJDZVhSbGN5aHlaV1pVZVhCbFUyTm9aVzFoS1M1c1pXNW5kR2dwS1FvZ0lDQWdMeThnZlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd04ySmtOREF3TURBd01EQXdNREF3TUROa05UUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pJd0NpQWdJQ0F2THlCMmIzUmxjem9nVm05MFpYTk5RbElzQ2lBZ0lDQndkWE5vYVc1MElERTVNekF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1UWXRNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQjdDaUFnSUNBdkx5QWdJR1p2Ykd4dmQzTTZJRVp2Ykd4dmQzTk5RbElzQ2lBZ0lDQXZMeUFnSUdKc2IyTnJjem9nUW14dlkydHpUVUpTTEFvZ0lDQWdMeThnSUNCd2IzTjBjem9nVFdsdVVHOXpkSE5OUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnlaV1l1YkdWdVozUm9LU3dLSUNBZ0lDOHZJQ0FnZG05MFpYTTZJRlp2ZEdWelRVSlNMQW9nSUNBZ0x5OGdJQ0IyYjNSbGJHbHpkRG9nVm05MFpXeHBjM1JOUWxJc0NpQWdJQ0F2THlBZ0lISmxZV04wYVc5dWN6b2dVbVZoWTNScGIyNXpUVUpTTEFvZ0lDQWdMeThnSUNCeVpXRmpkR2x2Ym14cGMzUTZJRkpsWVdOMGFXOXViR2x6ZEUxQ1Vpd0tJQ0FnSUM4dklDQWdiV1YwWVRvZ1RXVjBZVTFDVWl3S0lDQWdJQzh2SUNBZ2JXOWtaWEpoZEc5eWN6b2dUVzlrWlhKaGRHOXljMDFDVWl3S0lDQWdJQzh2SUNBZ1ltRnVibVZrT2lCQ1lXNXVaV1JOUWxJc0NpQWdJQ0F2THlBZ0lHRmpkR2x2Ym5NNklFRmpkR2x2Ym5OTlFsSXNDaUFnSUNBdkx5QWdJQzh2SUVKdmVDQnJaWGs2SUhCeVpXWnBlQ2d4S1NBcklIVnBiblEyTkNnNEtTQTlJRGtnWW5sMFpYTUtJQ0FnSUM4dklDQWdMeThnUW05NElIWmhiSFZsT2lCQlVrTXROQ0JvWldGa1pYSW9OQ2tnS3lCemRISnBibWNnYkdWdVozUm9LRElwSUNzZ2JtRnRaU0FySUdKNWRHVnpJR3hsYm1kMGFDZ3lLU0FySUhOamFHVnRZUW9nSUNBZ0x5OGdJQ0J5WldaVWVYQmxjem9nVW1WbVZIbHdaWE5DWVhObFRVSlNJQ3NnS0VKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nS0VKNWRHVnpLSEpsWmxSNWNHVk9ZVzFsS1M1c1pXNW5kR2dnS3lCQ2VYUmxjeWh5WldaVWVYQmxVMk5vWlcxaEtTNXNaVzVuZEdncEtRb2dJQ0FnTHk4Z2ZRb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1qSUtJQ0FnSUM4dklISmxZV04wYVc5dWN6b2dVbVZoWTNScGIyNXpUVUpTTEFvZ0lDQWdjSFZ6YUdsdWRDQXlNakV3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qRTJMVE14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0JtYjJ4c2IzZHpPaUJHYjJ4c2IzZHpUVUpTTEFvZ0lDQWdMeThnSUNCaWJHOWphM002SUVKc2IyTnJjMDFDVWl3S0lDQWdJQzh2SUNBZ2NHOXpkSE02SUUxcGJsQnZjM1J6VFVKU0lDc2dLRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2djbVZtTG14bGJtZDBhQ2tzQ2lBZ0lDQXZMeUFnSUhadmRHVnpPaUJXYjNSbGMwMUNVaXdLSUNBZ0lDOHZJQ0FnZG05MFpXeHBjM1E2SUZadmRHVnNhWE4wVFVKU0xBb2dJQ0FnTHk4Z0lDQnlaV0ZqZEdsdmJuTTZJRkpsWVdOMGFXOXVjMDFDVWl3S0lDQWdJQzh2SUNBZ2NtVmhZM1JwYjI1c2FYTjBPaUJTWldGamRHbHZibXhwYzNSTlFsSXNDaUFnSUNBdkx5QWdJRzFsZEdFNklFMWxkR0ZOUWxJc0NpQWdJQ0F2THlBZ0lHMXZaR1Z5WVhSdmNuTTZJRTF2WkdWeVlYUnZjbk5OUWxJc0NpQWdJQ0F2THlBZ0lHSmhibTVsWkRvZ1FtRnVibVZrVFVKU0xBb2dJQ0FnTHk4Z0lDQmhZM1JwYjI1ek9pQkJZM1JwYjI1elRVSlNMQW9nSUNBZ0x5OGdJQ0F2THlCQ2IzZ2dhMlY1T2lCd2NtVm1hWGdvTVNrZ0t5QjFhVzUwTmpRb09Da2dQU0E1SUdKNWRHVnpDaUFnSUNBdkx5QWdJQzh2SUVKdmVDQjJZV3gxWlRvZ1FWSkRMVFFnYUdWaFpHVnlLRFFwSUNzZ2MzUnlhVzVuSUd4bGJtZDBhQ2d5S1NBcklHNWhiV1VnS3lCaWVYUmxjeUJzWlc1bmRHZ29NaWtnS3lCelkyaGxiV0VLSUNBZ0lDOHZJQ0FnY21WbVZIbHdaWE02SUZKbFpsUjVjR1Z6UW1GelpVMUNVaUFySUNoQ2IzaERiM04wVUdWeVFubDBaU0FxSUNoQ2VYUmxjeWh5WldaVWVYQmxUbUZ0WlNrdWJHVnVaM1JvSUNzZ1FubDBaWE1vY21WbVZIbHdaVk5qYUdWdFlTa3ViR1Z1WjNSb0tTa0tJQ0FnSUM4dklIMEtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pJekNpQWdJQ0F2THlCeVpXRmpkR2x2Ym14cGMzUTZJRkpsWVdOMGFXOXViR2x6ZEUxQ1Vpd0tJQ0FnSUhCMWMyaHBiblFnTVRnNU1EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem94Tmkwek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ1ptOXNiRzkzY3pvZ1JtOXNiRzkzYzAxQ1Vpd0tJQ0FnSUM4dklDQWdZbXh2WTJ0ek9pQkNiRzlqYTNOTlFsSXNDaUFnSUNBdkx5QWdJSEJ2YzNSek9pQk5hVzVRYjNOMGMwMUNVaUFySUNoQ2IzaERiM04wVUdWeVFubDBaU0FxSUhKbFppNXNaVzVuZEdncExBb2dJQ0FnTHk4Z0lDQjJiM1JsY3pvZ1ZtOTBaWE5OUWxJc0NpQWdJQ0F2THlBZ0lIWnZkR1ZzYVhOME9pQldiM1JsYkdsemRFMUNVaXdLSUNBZ0lDOHZJQ0FnY21WaFkzUnBiMjV6T2lCU1pXRmpkR2x2Ym5OTlFsSXNDaUFnSUNBdkx5QWdJSEpsWVdOMGFXOXViR2x6ZERvZ1VtVmhZM1JwYjI1c2FYTjBUVUpTTEFvZ0lDQWdMeThnSUNCdFpYUmhPaUJOWlhSaFRVSlNMQW9nSUNBZ0x5OGdJQ0J0YjJSbGNtRjBiM0p6T2lCTmIyUmxjbUYwYjNKelRVSlNMQW9nSUNBZ0x5OGdJQ0JpWVc1dVpXUTZJRUpoYm01bFpFMUNVaXdLSUNBZ0lDOHZJQ0FnWVdOMGFXOXVjem9nUVdOMGFXOXVjMDFDVWl3S0lDQWdJQzh2SUNBZ0x5OGdRbTk0SUd0bGVUb2djSEpsWm1sNEtERXBJQ3NnZFdsdWREWTBLRGdwSUQwZ09TQmllWFJsY3dvZ0lDQWdMeThnSUNBdkx5QkNiM2dnZG1Gc2RXVTZJRUZTUXkwMElHaGxZV1JsY2lnMEtTQXJJSE4wY21sdVp5QnNaVzVuZEdnb01pa2dLeUJ1WVcxbElDc2dZbmwwWlhNZ2JHVnVaM1JvS0RJcElDc2djMk5vWlcxaENpQWdJQ0F2THlBZ0lISmxabFI1Y0dWek9pQlNaV1pVZVhCbGMwSmhjMlZOUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQW9RbmwwWlhNb2NtVm1WSGx3WlU1aGJXVXBMbXhsYm1kMGFDQXJJRUo1ZEdWektISmxabFI1Y0dWVFkyaGxiV0VwTG14bGJtZDBhQ2twQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNalFLSUNBZ0lDOHZJRzFsZEdFNklFMWxkR0ZOUWxJc0NpQWdJQ0J3ZFhOb2FXNTBJRFExTXpBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNVFl0TXpFS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUdadmJHeHZkM002SUVadmJHeHZkM05OUWxJc0NpQWdJQ0F2THlBZ0lHSnNiMk5yY3pvZ1FteHZZMnR6VFVKU0xBb2dJQ0FnTHk4Z0lDQndiM04wY3pvZ1RXbHVVRzl6ZEhOTlFsSWdLeUFvUW05NFEyOXpkRkJsY2tKNWRHVWdLaUJ5WldZdWJHVnVaM1JvS1N3S0lDQWdJQzh2SUNBZ2RtOTBaWE02SUZadmRHVnpUVUpTTEFvZ0lDQWdMeThnSUNCMmIzUmxiR2x6ZERvZ1ZtOTBaV3hwYzNSTlFsSXNDaUFnSUNBdkx5QWdJSEpsWVdOMGFXOXVjem9nVW1WaFkzUnBiMjV6VFVKU0xBb2dJQ0FnTHk4Z0lDQnlaV0ZqZEdsdmJteHBjM1E2SUZKbFlXTjBhVzl1YkdsemRFMUNVaXdLSUNBZ0lDOHZJQ0FnYldWMFlUb2dUV1YwWVUxQ1Vpd0tJQ0FnSUM4dklDQWdiVzlrWlhKaGRHOXljem9nVFc5a1pYSmhkRzl5YzAxQ1Vpd0tJQ0FnSUM4dklDQWdZbUZ1Ym1Wa09pQkNZVzV1WldSTlFsSXNDaUFnSUNBdkx5QWdJR0ZqZEdsdmJuTTZJRUZqZEdsdmJuTk5RbElzQ2lBZ0lDQXZMeUFnSUM4dklFSnZlQ0JyWlhrNklIQnlaV1pwZUNneEtTQXJJSFZwYm5RMk5DZzRLU0E5SURrZ1lubDBaWE1LSUNBZ0lDOHZJQ0FnTHk4Z1FtOTRJSFpoYkhWbE9pQkJVa010TkNCb1pXRmtaWElvTkNrZ0t5QnpkSEpwYm1jZ2JHVnVaM1JvS0RJcElDc2dibUZ0WlNBcklHSjVkR1Z6SUd4bGJtZDBhQ2d5S1NBcklITmphR1Z0WVFvZ0lDQWdMeThnSUNCeVpXWlVlWEJsY3pvZ1VtVm1WSGx3WlhOQ1lYTmxUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNlWFJsSUNvZ0tFSjVkR1Z6S0hKbFpsUjVjR1ZPWVcxbEtTNXNaVzVuZEdnZ0t5QkNlWFJsY3loeVpXWlVlWEJsVTJOb1pXMWhLUzVzWlc1bmRHZ3BLUW9nSUNBZ0x5OGdmUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem95TndvZ0lDQWdMeThnWVdOMGFXOXVjem9nUVdOMGFXOXVjMDFDVWl3S0lDQWdJSEIxYzJocGJuUWdNamszTURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6b3hOaTB6TVFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnWm05c2JHOTNjem9nUm05c2JHOTNjMDFDVWl3S0lDQWdJQzh2SUNBZ1lteHZZMnR6T2lCQ2JHOWphM05OUWxJc0NpQWdJQ0F2THlBZ0lIQnZjM1J6T2lCTmFXNVFiM04wYzAxQ1VpQXJJQ2hDYjNoRGIzTjBVR1Z5UW5sMFpTQXFJSEpsWmk1c1pXNW5kR2dwTEFvZ0lDQWdMeThnSUNCMmIzUmxjem9nVm05MFpYTk5RbElzQ2lBZ0lDQXZMeUFnSUhadmRHVnNhWE4wT2lCV2IzUmxiR2x6ZEUxQ1Vpd0tJQ0FnSUM4dklDQWdjbVZoWTNScGIyNXpPaUJTWldGamRHbHZibk5OUWxJc0NpQWdJQ0F2THlBZ0lISmxZV04wYVc5dWJHbHpkRG9nVW1WaFkzUnBiMjVzYVhOMFRVSlNMQW9nSUNBZ0x5OGdJQ0J0WlhSaE9pQk5aWFJoVFVKU0xBb2dJQ0FnTHk4Z0lDQnRiMlJsY21GMGIzSnpPaUJOYjJSbGNtRjBiM0p6VFVKU0xBb2dJQ0FnTHk4Z0lDQmlZVzV1WldRNklFSmhibTVsWkUxQ1Vpd0tJQ0FnSUM4dklDQWdZV04wYVc5dWN6b2dRV04wYVc5dWMwMUNVaXdLSUNBZ0lDOHZJQ0FnTHk4Z1FtOTRJR3RsZVRvZ2NISmxabWw0S0RFcElDc2dkV2x1ZERZMEtEZ3BJRDBnT1NCaWVYUmxjd29nSUNBZ0x5OGdJQ0F2THlCQ2IzZ2dkbUZzZFdVNklFRlNReTAwSUdobFlXUmxjaWcwS1NBcklITjBjbWx1WnlCc1pXNW5kR2dvTWlrZ0t5QnVZVzFsSUNzZ1lubDBaWE1nYkdWdVozUm9LRElwSUNzZ2MyTm9aVzFoQ2lBZ0lDQXZMeUFnSUhKbFpsUjVjR1Z6T2lCU1pXWlVlWEJsYzBKaGMyVk5RbElnS3lBb1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lBb1FubDBaWE1vY21WbVZIbHdaVTVoYldVcExteGxibWQwYUNBcklFSjVkR1Z6S0hKbFpsUjVjR1ZUWTJobGJXRXBMbXhsYm1kMGFDa3BDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ0FpWU1DV0ZyYVhSaFgyUmhid1FWSDN4MUFBaEZVbEk2UWtGT1JBRmlBV1lJUlZKU09rbFFRVmtEYzJGc0IzWmxjbk5wYjI0RGNHRnNCbmRoYkd4bGRBaEZVbEk2VGtSQlQ0QUU2cEdBM1RZYUFJNEJBSHd4R1JSRU1SaEJBR1dDRFFTMW5JcFVCSzdyczNnRWhtZFVsQVJMYjVCL0JCWWJPbm9FUXdObWpnVHJZdlVJQkFtRGdLUUVGREpQdHdTaE5LSjRCRFJCZGZBRU0ra3NsQVNGVGUzZ05ob0FqZzBBUVFDZkFQQUJvd0h5QWxRQ2V3S2pBc1VDL2dOUEJFRUFBUUFqUTRBRWI1Z1g5allhQUk0QkFBMEFNUm1CQkJJeEdCQkVRZ1BiTmhvQlNSV0JDQkpFRnpZYUFra2lXU1VJU3dFVkVrUlhBZ0FvVHdKbkp3aE1aeU5ETVJZakNVazRFQ01TUkRZYUFVa1ZKQkpFTVFDSUJBNUJBQU1yc0FBeEFFc0JFMEFBRElBSVJWSlNPbE5DVEV1d0FFc0JTVGdITWdvU1REZ0lLa2NDaUFWVmdRaGJFaEJBQUFRbkJyQUFNUUJMQVlnRUNpY0VURkFpdVVnalF5STJHZ0ZKRlNRU1JERUFpQU81UVFBREs3QUFNUUJMQVlnRDVpY0VURkJKUlFPOVJRRkFBQXlBQ0VWU1VqcFZUa0pMc0FCTEFieElzVEVBS2tjQ2lBVDRnUWhic2dpeUJ5T3lFQ0t5QWJNalF6RVdKUWxKT0JBakVrUXhGaU1KUndJNEVJRUdFa1EyR2dGSlRnSkpGU1FTUklnRHdsY3lDRXdpS0dWRU1RQk9Ba3c0R0V5QUEyRmhiR1ZJZ1NoYkVrRUFiVXNET0JsQUFHWkxBemdiZ1FRU1FRQmNTd01pd2hxQUJFT1NKbFVTUVFCTlN3TWp3aHBMQVJKQkFFSkxBeVhDR2tzQ0VrRUFOeU5BQUF5QUNFVlNVanBHUjFSRnNBQXFSd0tJQkZvaVcwc0ZTVGdITWdvU1REZ0lUd0lTRUVBQUJDY0dzQUF4QUVzRGlBT2pJME1pUXYvR01SWWpDVWs0RUNNU1JEWWFBVWNDRlNRU1JJZ0RIWUV5VzBFQURJQUlSVkpTT2toSFZFV3dBQ3BIQW9nRUJ5SmJTd0pKT0FjeUNoSk1PQWhQQWhJUVFBQUVKd2F3QURFQVN3R0lBMUFqUXlJMkdnRkpGU1FTUkRFQWlBSm1RUUFESzdBQVNURUFpQUt2SndWTVVFbEZBNzFGQVVBQURJQUlSVkpTT2s1R1RGZXdBRWNDaUFLc1NZRXBXMHlCSVZ0TUl3bUlBdFpMQWJ4SXNURUFLa2NDaUFPVElsdXlDTElISTdJUUlySUJzeU5ETmhvQlNSVWtFa1EyR2dKSkZTUVNSSWdDT1NjRVRGQzlSUUdBQVFBaVR3SlVLVXhRc0NORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkV5SUFpd25CVXhRdlVVQmdBRUFJazhDVkNsTVVMQWpRellhQVVrVkpCSkVOaG9DU1JVa0VrUk1pQUlFSndWTVVMNUVGeFlwVEZDd0kwTTJHZ0ZKSWxrbENFc0JGUkpFVndJQU5ob0NTU0paSlFoTEFSVVNSRmNDQURZYUEwa2lXU1VJU3dFVkVrUlhBZ0NJQXVBcFRGQ3dJME0yR2dGSkZVc0JJbGxKZ1FRU1JFc0NTd0ZMQTFJaVdZRVJDNEVHQ0VzREpWbEpTd0lTUkVzRVN3RkxCVklpV1VtQkVRc2xDRThEQ0U4RUVrUk9BMUlpV1FpQmtEVUxnZEFvQ0JZcFRGQ3dJME0yR2dGSkZZRUlFa1FYU1RZYUFra1ZKQkpFTmhvRFNSV0JDQkpFRjA0Q1RJQU1ZV3RwZEdGZllYTnpaWFJ6WlVnaVczQUFSUUZBQUdKSlFRQmVzVXNCSndsbFNGY0FDQ01XTWdOTEE3SVlnQVN6WWpTbHNocFBBcklhVExJYXNocUFBZ0FBc2hxQUJHZzE0N3l5R29FR3NoQWlzZ0d6dEQ1SlZ3UUFURmNBQkNrU1JFa1ZJeEpFSWxOQkFBNHlFQmFBQVJSTVVDbE1VTEFqUTRBSkNnQUFBQUFBQUFBQVF2L3NOaG9CU1NKWkpRaExBUlVTUkZjQ0FERUFJaWhsUkNjS1pVaHlDRVFTUUFBRUp3dXdBQ0lvWlVRbkNXVklnUkJiTWcwU1FBQU1nQWhGVWxJNlNWVlFSN0FBSndoTEFXY2pRellhQVVrVmdRZ1NSQmN4QUNJb1pVUW5DbVZJY2doRUVrQUFCQ2NMc0FBb1N3Rm5JME9LQVFFaUtHVkVKd2RsU0lFWVc3R3lHSUFFaENhY2VMSWFpLyt5R29FR3NoQWlzZ0d6dEQ1SlZ3UUFURmNBQkNrU1JFa1ZJeEpFSWxPSmlnSUJpLzVSQUJCSkZZRVFFa1NMLzFFQUVFa1ZnUkFTUkZDSmlnSUJpLzVSQUJCSkZZRVFFa1NMLzFFQUVFa1ZnUkFTUkZDSmlnRUJJaWhsUkNjSFpVZ2lXN0d5R0lBRWM1Nm5DN0lhaS8reUdvRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDa1NSRWtWZ1VvU1JJbUtBd0FpS0dWRUp3ZGxTQ0pic1l2K0Zvdi9GazhDc2hpQUJETUdzeXF5R292OXNocE1zaHF5R29FR3NoQWlzZ0d6aVlvQ0FDS0wvb2ovSFVFQUF5dXdBSXYvaS82SS8wb25CRXhRdlVVQlFRQU1nQWhGVWxJNlFreExSTEFBaS82TC94TkFBQXlBQ0VWU1VqcFRSa3hYc0FDTC9vai9VWUdJQTFOQkFBeUFDRVZTVWpwQlZWUlBzQUNMLzR2K2lQOGNKd1ZNVUVtTUFMMUZBVUVBRElBSVJWSlNPa0ZHVEZld0FJdi9pUDhaU1lFcFcweUJJVnNqQ0VrV2l3Qk12MHdqQ0l2L1RnS0kvemVKaWdNQmkvMFZnWkFEQzRHazZ3SUlpLzRWaS84VkNJR1FBd3VCMUVnSVRCYUFFQUFBQUFBQUFIdlVBQUFBQUFBQVBWUk1VSUhrbGdFV1RFc0JVRXhRZ2RTc0FSWlFnZFNUQVJaTVN3RlFnZlRoQWhaUVN3RlFURkNCaE9nQkZsQk1GbENKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
