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
                public Structs.ViewPayWallValueUserPayInfo[] UserPayInfo { get; set; }

                public Structs.ViewPayWallValueUserPayInfo[] AgentPayInfo { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    var arrUserPayInfo = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ViewPayWallValueUserPayInfo>(x => Structs.ViewPayWallValueUserPayInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrUserPayInfo.Value = (UserPayInfo ?? Array.Empty<Structs.ViewPayWallValueUserPayInfo>()).ToList();
                    stringRef[ret.Count] = arrUserPayInfo.Encode();
                    ret.AddRange(new byte[2]);
                    var arrAgentPayInfo = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ViewPayWallValueUserPayInfo>(x => Structs.ViewPayWallValueUserPayInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAgentPayInfo.Value = (AgentPayInfo ?? Array.Empty<Structs.ViewPayWallValueUserPayInfo>()).ToList();
                    stringRef[ret.Count] = arrAgentPayInfo.Encode();
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

                public static ViewPayWallValue Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ViewPayWallValue();
                    var indexUserPayInfo = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrUserPayInfo = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ViewPayWallValueUserPayInfo>(x => Structs.ViewPayWallValueUserPayInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrUserPayInfo.Decode(bytes.Skip(indexUserPayInfo + prefixOffset).ToArray());
                    ret.UserPayInfo = arrUserPayInfo.Value.ToArray();
                    var indexAgentPayInfo = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrAgentPayInfo = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ViewPayWallValueUserPayInfo>(x => Structs.ViewPayWallValueUserPayInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAgentPayInfo.Decode(bytes.Skip(indexAgentPayInfo + prefixOffset).ToArray());
                    ret.AgentPayInfo = arrAgentPayInfo.Value.ToArray();
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

            public class ViewPayWallValueUserPayInfo : AVMObjectType
            {
                public byte Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ViewPayWallValueUserPayInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ViewPayWallValueUserPayInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte vField0Value) { ret.Field0 = vField0Value; }
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ViewPayWallValueUserPayInfo);
                }
                public bool Equals(ViewPayWallValueUserPayInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ViewPayWallValueUserPayInfo left, ViewPayWallValueUserPayInfo right)
                {
                    return EqualityComparer<ViewPayWallValueUserPayInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(ViewPayWallValueUserPayInfo left, ViewPayWallValueUserPayInfo right)
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
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); refAbi.From(@ref);
            var refTypeNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); refTypeNameAbi.From(refTypeName);
            var refTypeSchemaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); refTypeSchemaAbi.From(refTypeSchema);

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
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); refAbi.From(@ref);
            var refTypeNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); refTypeNameAbi.From(refTypeName);
            var refTypeSchemaAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); refTypeSchemaAbi.From(refTypeSchema);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFTb2NpYWxHcmFwaCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBa2l0YVNvY2lhbE1CUkRhdGEiOlt7Im5hbWUiOiJmb2xsb3dzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJsb2NrcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3N0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlbGlzdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWFjdGlvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVhY3Rpb25saXN0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1ldGEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibW9kZXJhdG9ycyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYW5uZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aW9ucyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWZUeXBlcyIsInR5cGUiOiJ1aW50NjQifV0sIkJsb2NrTGlzdEtleSI6W3sibmFtZSI6InVzZXIiLCJ0eXBlIjoiYnl0ZVsxNl0ifSx7Im5hbWUiOiJibG9ja2VkIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJGb2xsb3dzS2V5IjpbeyJuYW1lIjoidXNlciIsInR5cGUiOiJieXRlWzE2XSJ9LHsibmFtZSI6ImZvbGxvd2VyIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJWaWV3UGF5V2FsbFZhbHVlIjpbeyJuYW1lIjoidXNlclBheUluZm8iLCJ0eXBlIjoiVmlld1BheVdhbGxWYWx1ZVVzZXJQYXlJbmZvW10ifSx7Im5hbWUiOiJhZ2VudFBheUluZm8iLCJ0eXBlIjoiVmlld1BheVdhbGxWYWx1ZVVzZXJQYXlJbmZvW10ifV0sInRpcE1CUkluZm8iOlt7Im5hbWUiOiJ0eXBlIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiYXJjNTgiLCJ0eXBlIjoidWludDY0In1dLCJWaWV3UGF5V2FsbFZhbHVlVXNlclBheUluZm8iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiQ3JlYXRlIG1ldGhvZCB0byBpbml0aWFsaXplIHRoZSBjb250cmFjdCB3aXRoIHRoZSBEQU8gcmVmZXJlbmNlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhRGFvIiwiZGVzYyI6IlRoZSBBa2l0YSBEQU8gYXBwIElEIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6IlRoZSB2ZXJzaW9uIHN0cmluZyBmb3IgdGhpcyBjb250cmFjdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJibG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bmJsb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdhdGVkRm9sbG93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXRlVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmb2xsb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5mb2xsb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNCbG9ja2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxvY2tlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzRm9sbG93aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmb2xsb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRGb2xsb3dJbmRleCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9sbG93ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWZUeXBlTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmVHlwZVNjaGVtYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQWtpdGFTb2NpYWxNQlJEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5V2FsbE1iciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10sKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pIiwic3RydWN0IjoiVmlld1BheVdhbGxWYWx1ZSIsIm5hbWUiOiJwYXl3YWxsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tUaXBNYnJSZXF1aXJlbWVudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJ0aXBNQlJJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4OTldLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4NiwxMzc0LDE0ODVdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2Ml0sImVycm9yTWVzc2FnZSI6IkVSUjpBRkxXIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzMF0sImVycm9yTWVzc2FnZSI6IkVSUjpBVVRPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkyLDM3Nyw3MTYsMTU1N10sImVycm9yTWVzc2FnZSI6IkVSUjpCQU5EIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4Nl0sImVycm9yTWVzc2FnZSI6IkVSUjpCTEtEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc0XSwiZXJyb3JNZXNzYWdlIjoiRVJSOkZHVEUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTddLCJlcnJvck1lc3NhZ2UiOiJFUlI6SEdURSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MSw2MDQsNjg3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOklQQVkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzNdLCJlcnJvck1lc3NhZ2UiOiJFUlI6SVVQRyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0NCwxMDExXSwiZXJyb3JNZXNzYWdlIjoiRVJSOk5EQU8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDddLCJlcnJvck1lc3NhZ2UiOiJFUlI6TkZMVyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMl0sImVycm9yTWVzc2FnZSI6IkVSUjpTQkxLIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwNl0sImVycm9yTWVzc2FnZSI6IkVSUjpTRkxXIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA5XSwiZXJyb3JNZXNzYWdlIjoiRVJSOlVOQksiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzk2LDE0MDcsMTQyMywxNDM0XSwiZXJyb3JNZXNzYWdlIjoiTGVuZ3RoIG11c3QgYmUgMTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzYsMTAwM10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4Miw5MjksOTQ4LDk5NiwxMzMxLDE0NDMsMTQ5OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0Myw5MTMsMTAyMywxMDM5LDEwNTUsMTA5NywxMTIxLDExMzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTAsOTIwLDEwMzAsMTA0NiwxMDYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MSwzNjYsNDcxLDYzNiw3MDUsODAyLDgxMCw4NDEsODQ5LDg4MSw4ODksMTE3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzYsOTg5LDExNjQsMTE4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOTEsMTM3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvc29jaWFsL3R5cGVzLnRzOjpNZXRhVmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9zb2NpYWwvdHlwZXMudHM6OlZpZXdQYXlXYWxsVmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbisodWludDgsdWludDY0LHVpbnQ2NClbXSksKGxlbisodWludDgsdWludDY0LHVpbnQ2NClbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pLChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODMsMTEwN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFwcGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzMsNDQ4LDYyN10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlESUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRnJhWFJoWDJSaGJ5SWdNSGd4TlRGbU4yTTNOU0FpSWlBaVJWSlNPa0pCVGtRaUlDSmlJaUFpWmlJZ0lrVlNVanBKVUVGWklpQWljMkZzSWlBaWRtVnljMmx2YmlJZ0luZGhiR3hsZENJZ0lrVlNVanBPUkVGUElpQWljR0ZzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV3RwZEdGVGIyTnBZV3hIY21Gd2FDQmxlSFJsYm1SeklHTnNZWE56WlhNb1FtRnpaVk52WTJsaGJDd2dWWEJuY21Ga1pXRmliR1ZCYTJsMFlVSmhjMlZEYjI1MGNtRmpkQ2tnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldFNU1UZ3daR1FnTHk4Z2JXVjBhRzlrSUNKMWNHUmhkR1VvYzNSeWFXNW5LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNWd1pHRjBaVjl5YjNWMFpVQTBDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGcmFYUmhVMjlqYVdGc1IzSmhjR2dnWlhoMFpXNWtjeUJqYkdGemMyVnpLRUpoYzJWVGIyTnBZV3dzSUZWd1ozSmhaR1ZoWW14bFFXdHBkR0ZDWVhObFEyOXVkSEpoWTNRcElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTWpFS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaU5UbGpPR0UxTkNBd2VHRmxaV0ppTXpjNElEQjRPRFkyTnpVME9UUWdNSGcwWWpabU9UQTNaaUF3ZURFMk1XSXpZVGRoSURCNE5ETXdNelkyT0dVZ01IaGxZall5WmpVd09DQXdlREE1T0RNNE1HRTBJREI0TXpObE9USmpPVFFnTUhnNE5UUmtaV1JsTUNBd2VERTBNekkwWm1JM0lEQjRZVEV6TkdFeU56Z2dNSGd6TkRReE56Vm1NQ0F2THlCdFpYUm9iMlFnSW1Kc2IyTnJLSEJoZVN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ1WW14dlkyc29ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKbllYUmxaRVp2Ykd4dmR5aHdZWGtzWVhCd2JDeGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1admJHeHZkeWh3WVhrc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0oxYm1admJHeHZkeWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHpRbXh2WTJ0bFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpYVhOR2IyeHNiM2RwYm1jb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEVadmJHeHZkMGx1WkdWNEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVUZyYVhSaFJFRlBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNGVndLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnRZbklvWW5sMFpWdGRMSE4wY21sdVp5eGllWFJsVzEwcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpY0dGNVYyRnNiRTFpY2lnb0tIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME5qUXBXMTBzS0hWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMmhsWTJ0VWFYQk5ZbkpTWlhGMWFYSmxiV1Z1ZEhNb2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWREWTBLU2gxYVc1ME9DeDFhVzUwTmpRcElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZbXh2WTJzZ2RXNWliRzlqYXlCbllYUmxaRVp2Ykd4dmR5Qm1iMnhzYjNjZ2RXNW1iMnhzYjNjZ2FYTkNiRzlqYTJWa0lHbHpSbTlzYkc5M2FXNW5JR2RsZEVadmJHeHZkMGx1WkdWNElIVndaR0YwWlVGcmFYUmhSRUZQSUcxaGFXNWZiM0JWY0Y5eWIzVjBaVUF4TmlCdFluSWdjR0Y1VjJGc2JFMWljaUJqYUdWamExUnBjRTFpY2xKbGNYVnBjbVZ0Wlc1MGN3b2dJQ0FnWlhKeUNncHRZV2x1WDI5d1ZYQmZjbTkxZEdWQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzBNUW9nSUNBZ0x5OGdiM0JWY0NncE9pQjJiMmxrSUhzZ2ZRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXlNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnJhWFJoVTI5amFXRnNSM0poY0dnZ1pYaDBaVzVrY3lCamJHRnpjMlZ6S0VKaGMyVlRiMk5wWVd3c0lGVndaM0poWkdWaFlteGxRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUXBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFptT1RneE4yWTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSFZwYm5RMk5DeHpkSEpwYm1jcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgzVndaR0YwWlY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TkRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUZzblZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0blhTQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUZWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnZFhCa1lYUmxDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRWR5WVhCb0xtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVWdQU0JoYTJsMFlVUmhid29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qVUtJQ0FnSUM4dklIWmxjbk5wYjI0Z1BTQkhiRzlpWVd4VGRHRjBaVHh6ZEhKcGJtYytLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVZabGNuTnBiMjRnZlNrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5abGNuTnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhSb2FYTXVkbVZ5YzJsdmJpNTJZV3gxWlNBOUlIWmxjbk5wYjI0S0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFZHlZWEJvTG1Kc2IyTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW14dlkyczZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJR0pzYjJOcktHMWljbEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2dZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem81TmdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtDRjBhR2x6TG1selFtRnVibVZrS0ZSNGJpNXpaVzVrWlhJcExDQkZVbEpmUWtGT1RrVkVLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJwYzBKaGJtNWxaQW9nSUNBZ1lub2dZbXh2WTJ0ZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJa1ZTVWpwQ1FVNUVJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09rSkJUa1FLQ21Kc2IyTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qazNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBaFBUMGdZV1JrY21WemN5d2dSVkpTWDFORlRFWmZRa3hQUTBzcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdJVDBLSUNBZ0lHSnVlaUJpYkc5amExOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlUwSk1TeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcFRRa3hMQ2dwaWJHOWphMTloWm5SbGNsOWhjM05sY25SQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNREF0TVRBMkNpQWdJQ0F2THlCdFlYUmphQ2dLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa3VZbXh2WTJ0ekNpQWdJQ0F2THlBZ0lIMEtJQ0FnSUM4dklDa3NDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TURBdE1UQTJDaUFnSUNBdkx5QnRZWFJqYUNnS0lDQWdJQzh2SUNBZ2JXSnlVR0Y1YldWdWRDd0tJQ0FnSUM4dklDQWdld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2t1WW14dlkydHpDaUFnSUNBdkx5QWdJSDBLSUNBZ0lDOHZJQ2tzQ2lBZ0lDQTlQUW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEEwQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa3VZbXh2WTJ0ekNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbTFpY2dvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV3TUMweE1EWUtJQ0FnSUM4dklHMWhkR05vS0FvZ0lDQWdMeThnSUNCdFluSlFZWGx0Wlc1MExBb2dJQ0FnTHk4Z0lDQjdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nZEdocGN5NXRZbklvUW5sMFpYTW9KeWNwTENBbkp5d2dRbmwwWlhNb0p5Y3BLUzVpYkc5amEzTUtJQ0FnSUM4dklDQWdmUW9nSUNBZ0x5OGdLU3dLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qazVMVEV3T0FvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQnRZWFJqYUNnS0lDQWdJQzh2SUNBZ0lDQnRZbkpRWVhsdFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhzS0lDQWdJQzh2SUNBZ0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0FnSUdGdGIzVnVkRG9nZEdocGN5NXRZbklvUW5sMFpYTW9KeWNwTENBbkp5d2dRbmwwWlhNb0p5Y3BLUzVpYkc5amEzTUtJQ0FnSUM4dklDQWdJQ0I5Q2lBZ0lDQXZMeUFnSUNrc0NpQWdJQ0F2THlBZ0lFVlNVbDlKVGxaQlRFbEVYMUJCV1UxRlRsUUtJQ0FnSUM4dklDa0tJQ0FnSUdKdWVpQmliRzlqYTE5aFpuUmxjbDloYzNObGNuUkFOd29nSUNBZ1lubDBaV01nTmlBdkx5QWlSVkpTT2tsUVFWa2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlNWQkJXUW9LWW14dlkydGZZV1owWlhKZllYTnpaWEowUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5QmpiMjV6ZENCaWJHOWphM05MWlhrZ1BTQjBhR2x6TG1Kc2F5aFVlRzR1YzJWdVpHVnlMQ0JoWkdSeVpYTnpLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdOaGJHeHpkV0lnWW14ckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHSnNiMk5yY3lBOUlFSnZlRTFoY0R4Q2JHOWphMHhwYzNSTFpYa3NJR0o1ZEdWelBEQStQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaENiRzlqYTNNZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUhSb2FYTXVZbXh2WTJ0ektHSnNiMk5yYzB0bGVTa3VZM0psWVhSbEtDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem81TlFvZ0lDQWdMeThnWW14dlkyc29iV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JoWkdSeVpYTnpPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRWR5WVhCb0xuVnVZbXh2WTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFibUpzYjJOck9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1UUUtJQ0FnSUM4dklIVnVZbXh2WTJzb1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9JWFJvYVhNdWFYTkNZVzV1WldRb1ZIaHVMbk5sYm1SbGNpa3NJRVZTVWw5Q1FVNU9SVVFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUdselFtRnVibVZrQ2lBZ0lDQmllaUIxYm1Kc2IyTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKRlVsSTZRa0ZPUkNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBDUVU1RUNncDFibUpzYjJOclgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z1kyOXVjM1FnWW14dlkydHpTMlY1SUQwZ2RHaHBjeTVpYkdzb1ZIaHVMbk5sYm1SbGNpd2dZV1JrY21WemN5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJR0pzYXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCaWJHOWphM01nUFNCQ2IzaE5ZWEE4UW14dlkydE1hWE4wUzJWNUxDQmllWFJsY3p3d1BqNG9leUJyWlhsUWNtVm1hWGc2SUVGcmFYUmhVMjlqYVdGc1FtOTRVSEpsWm1sNFFteHZZMnR6SUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV4T0FvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUm9hWE11WW14dlkydHpLR0pzYjJOcmMwdGxlU2t1WlhocGMzUnpMQ0JGVWxKZlZWTkZVbDlPVDFSZlFreFBRMHRGUkNrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJSFZ1WW14dlkydGZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09sVk9Ra3NpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZWVTVDU3dvS2RXNWliRzlqYTE5aFpuUmxjbDloYzNObGNuUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TVRrS0lDQWdJQzh2SUhSb2FYTXVZbXh2WTJ0ektHSnNiMk5yYzB0bGVTa3VaR1ZzWlhSbEtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TWpFdE1USTJDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2t1WW14dlkydHpDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV5TXdvZ0lDQWdMeThnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCaGJXOTFiblE2SUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2t1WW14dlkydHpDaUFnSUNCaWVYUmxZMTh5SUM4dklDSWlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHTmhiR3h6ZFdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG0xaWNnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1qRXRNVEkxQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrdVlteHZZMnR6Q2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEl4TFRFeU5nb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUIwYUdsekxtMWljaWhDZVhSbGN5Z25KeWtzSUNjbkxDQkNlWFJsY3lnbkp5a3BMbUpzYjJOcmN3b2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUIxYm1Kc2IyTnJLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9rRnJhWFJoVTI5amFXRnNSM0poY0dndVoyRjBaV1JHYjJ4c2IzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWVhSbFpFWnZiR3h2ZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1qa3RNVE16Q2lBZ0lDQXZMeUJuWVhSbFpFWnZiR3h2ZHlnS0lDQWdJQzh2SUNBZ2JXSnlVR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxBb2dJQ0FnTHk4Z0lDQm5ZWFJsVkhodU9pQm5kSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiRlI0Yml3S0lDQWdJQzh2SUNBZ1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhjSEJzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFek5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZXlCbWIyeHNiM2RIWVhSbFNVUWdmU0E5SUhSb2FYTXVaMlYwVFdWMFlTaGhaR1J5WlhOektRb2dJQ0FnWTJGc2JITjFZaUJuWlhSTlpYUmhDaUFnSUNCbGVIUnlZV04wSURVd0lEZ0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNelVLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENobllYUmxRMmhsWTJzb1oyRjBaVlI0Yml3Z2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dWSGh1TG5ObGJtUmxjaXdnWm05c2JHOTNSMkYwWlVsRUtTd2dSVkpTWDBaQlNVeEZSRjlIUVZSRktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pJM0NpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV6TlFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHZGhkR1ZEYUdWamF5aG5ZWFJsVkhodUxDQjBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JVZUc0dWMyVnVaR1Z5TENCbWIyeHNiM2RIWVhSbFNVUXBMQ0JGVWxKZlJrRkpURVZFWDBkQlZFVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU5Ea0tJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRRS0lDQWdJQzh2SUdOdmJuTjBJRnRoY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpRV3RwZEdGQmNIQk1hWE4wS1NrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVdGc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lORGtLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3U1dRZ1BUMDlJRUZ3Y0d4cFkyRjBhVzl1S0dkbGRFRnJhWFJoUVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1WjJGMFpTa2dKaVlLSUNBZ0lIQjFjMmhwYm5RZ05EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU5Ea3RNalV3Q2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3SUNZbUNpQWdJQ0JpZWlCbllYUmxaRVp2Ykd4dmQxOWliMjlzWDJaaGJITmxRREV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakkxTUFvZ0lDQWdMeThnWjJGMFpWUjRiaTV2YmtOdmJYQnNaWFJwYjI0Z1BUMDlJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0NBbUpnb2dJQ0FnWkdsbklETUtJQ0FnSUdkMGVHNXpJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TkRrdE1qVXdDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRWxrSUQwOVBTQkJjSEJzYVdOaGRHbHZiaWhuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbWRoZEdVcElDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtOXVRMjl0Y0d4bGRHbHZiaUE5UFQwZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdJQ1ltQ2lBZ0lDQmlibm9nWjJGMFpXUkdiMnhzYjNkZlltOXZiRjltWVd4elpVQXhNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lOVEVLSUNBZ0lDOHZJR2RoZEdWVWVHNHViblZ0UVhCd1FYSm5jeUE5UFQwZ05DQW1KZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHZDBlRzV6SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qUTVMVEkxTVFvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCSlpDQTlQVDBnUVhCd2JHbGpZWFJwYjI0b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1bllYUmxLU0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV2YmtOdmJYQnNaWFJwYjI0Z1BUMDlJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dWRXMUJjSEJCY21keklEMDlQU0EwSUNZbUNpQWdJQ0JpZWlCbllYUmxaRVp2Ykd4dmQxOWliMjlzWDJaaGJITmxRREV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakkxTWdvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCQmNtZHpLREFwSUQwOVBTQnRaWFJvYjJSVFpXeGxZM1J2Y2p4MGVYQmxiMllnUjJGMFpTNXdjbTkwYjNSNWNHVXViWFZ6ZEVOb1pXTnJQaWdwSUNZbUNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2QwZUc1ellYTWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME16a3lNalkxTlNBdkx5QnRaWFJvYjJRZ0ltMTFjM1JEYUdWamF5aGhaR1J5WlhOekxIVnBiblEyTkN4aWVYUmxXMTFiWFNsMmIybGtJZ29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qUTVMVEkxTWdvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCSlpDQTlQVDBnUVhCd2JHbGpZWFJwYjI0b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1bllYUmxLU0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV2YmtOdmJYQnNaWFJwYjI0Z1BUMDlJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dWRXMUJjSEJCY21keklEMDlQU0EwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFRnlaM01vTUNrZ1BUMDlJRzFsZEdodlpGTmxiR1ZqZEc5eVBIUjVjR1Z2WmlCSFlYUmxMbkJ5YjNSdmRIbHdaUzV0ZFhOMFEyaGxZMnMrS0NrZ0ppWUtJQ0FnSUdKNklHZGhkR1ZrUm05c2JHOTNYMkp2YjJ4ZlptRnNjMlZBTVRNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpVekNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFRnlaM01vTVNrZ1BUMDlJRzVsZHlCQlpHUnlaWE56S0dOaGJHeGxjaWt1WW5sMFpYTWdKaVlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1ozUjRibk5oY3lCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lORGt0TWpVekNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFbGtJRDA5UFNCQmNIQnNhV05oZEdsdmJpaG5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExtZGhkR1VwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG05dVEyOXRjR3hsZEdsdmJpQTlQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0lDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtNTFiVUZ3Y0VGeVozTWdQVDA5SURRZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndRWEpuY3lnd0tTQTlQVDBnYldWMGFHOWtVMlZzWldOMGIzSThkSGx3Wlc5bUlFZGhkR1V1Y0hKdmRHOTBlWEJsTG0xMWMzUkRhR1ZqYXo0b0tTQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJCY21kektERXBJRDA5UFNCdVpYY2dRV1JrY21WemN5aGpZV3hzWlhJcExtSjVkR1Z6SUNZbUNpQWdJQ0JpZWlCbllYUmxaRVp2Ykd4dmQxOWliMjlzWDJaaGJITmxRREV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakkxTkFvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCQmNtZHpLRElwSUQwOVBTQnBkRzlpS0dsa0tRb2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0JuZEhodWMyRnpJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJME9TMHlOVFFLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3U1dRZ1BUMDlJRUZ3Y0d4cFkyRjBhVzl1S0dkbGRFRnJhWFJoUVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1WjJGMFpTa2dKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHViMjVEYjIxd2JHVjBhVzl1SUQwOVBTQlBia052YlhCc1pYUmxRV04wYVc5dUxrNXZUM0FnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1Ym5WdFFYQndRWEpuY3lBOVBUMGdOQ0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCQmNtZHpLREFwSUQwOVBTQnRaWFJvYjJSVFpXeGxZM1J2Y2p4MGVYQmxiMllnUjJGMFpTNXdjbTkwYjNSNWNHVXViWFZ6ZEVOb1pXTnJQaWdwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFRnlaM01vTVNrZ1BUMDlJRzVsZHlCQlpHUnlaWE56S0dOaGJHeGxjaWt1WW5sMFpYTWdKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3UVhKbmN5Z3lLU0E5UFQwZ2FYUnZZaWhwWkNrS0lDQWdJR0o2SUdkaGRHVmtSbTlzYkc5M1gySnZiMnhmWm1Gc2MyVkFNVE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BuWVhSbFpFWnZiR3h2ZDE5aWIyOXNYMjFsY21kbFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV6TlFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHZGhkR1ZEYUdWamF5aG5ZWFJsVkhodUxDQjBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JVZUc0dWMyVnVaR1Z5TENCbWIyeHNiM2RIWVhSbFNVUXBMQ0JGVWxKZlJrRkpURVZFWDBkQlZFVXBDaUFnSUNCaWJub2daMkYwWldSR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa1pIVkVVaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2UmtkVVJRb0taMkYwWldSR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVE0zQ2lBZ0lDQXZMeUJqYjI1emRDQjdJR1p2Ykd4dmQzTWdmU0E5SUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02T2tKaGMyVlRiMk5wWVd3dWJXSnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNemt0TVRRMUNpQWdJQ0F2THlCdFlYUmphQ2dLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR1p2Ykd4dmQzTUtJQ0FnSUM4dklDQWdmUW9nSUNBZ0x5OGdLU3dLSUNBZ0lHUnBaeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRReUNpQWdJQ0F2THlCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFek9TMHhORFVLSUNBZ0lDOHZJRzFoZEdOb0tBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhsdFpXNTBMQW9nSUNBZ0x5OGdJQ0I3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1ptOXNiRzkzY3dvZ0lDQWdMeThnSUNCOUNpQWdJQ0F2THlBcExBb2dJQ0FnUFQwS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE16Z3RNVFEzQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb0NpQWdJQ0F2THlBZ0lHMWhkR05vS0FvZ0lDQWdMeThnSUNBZ0lHMWljbEJoZVcxbGJuUXNDaUFnSUNBdkx5QWdJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJQ0FnWVcxdmRXNTBPaUJtYjJ4c2IzZHpDaUFnSUNBdkx5QWdJQ0FnZlFvZ0lDQWdMeThnSUNBcExBb2dJQ0FnTHk4Z0lDQkZVbEpmU1U1V1FVeEpSRjlRUVZsTlJVNVVDaUFnSUNBdkx5QXBDaUFnSUNCaWJub2daMkYwWldSR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lrVlNVanBKVUVGWklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2tsUVFWa0tDbWRoZEdWa1JtOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUwT1FvZ0lDQWdMeThnZEdocGN5NWpjbVZoZEdWR2IyeHNiM2NvVkhodUxuTmxibVJsY2l3Z1lXUmtjbVZ6Y3lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVadmJHeHZkd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV5T1MweE16TUtJQ0FnSUM4dklHZGhkR1ZrUm05c2JHOTNLQW9nSUNBZ0x5OGdJQ0J0WW5KUVlYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzQ2lBZ0lDQXZMeUFnSUdkaGRHVlVlRzQ2SUdkMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c1ZIaHVMQW9nSUNBZ0x5OGdJQ0JoWkdSeVpYTnpPaUJCWTJOdmRXNTBDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRoZEdWa1JtOXNiRzkzWDJKdmIyeGZabUZzYzJWQU1UTTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCbllYUmxaRVp2Ykd4dmQxOWliMjlzWDIxbGNtZGxRREUwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkVkeVlYQm9MbVp2Ykd4dmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVp2Ykd4dmR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJR1p2Ykd4dmR5aHRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNJR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UVXpDaUFnSUNBdkx5QmpiMjV6ZENCN0lHWnZiR3h2ZDBkaGRHVkpSQ0I5SUQwZ2RHaHBjeTVuWlhSTlpYUmhLR0ZrWkhKbGMzTXBDaUFnSUNCallXeHNjM1ZpSUdkbGRFMWxkR0VLSUNBZ0lIQjFjMmhwYm5RZ05UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVFUwQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ptOXNiRzkzUjJGMFpVbEVJRDA5UFNBd0xDQkZVbEpmU0VGVFgwZEJWRVVwQ2lBZ0lDQmllaUJtYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09raEhWRVVpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZTRWRVUlFvS1ptOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUxTmdvZ0lDQWdMeThnWTI5dWMzUWdleUJtYjJ4c2IzZHpJSDBnUFNCMGFHbHpMbTFpY2loQ2VYUmxjeWduSnlrc0lDY25MQ0JDZVhSbGN5Z25KeWtwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtMWljZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVFU0TFRFMk5Bb2dJQ0FnTHk4Z2JXRjBZMmdvQ2lBZ0lDQXZMeUFnSUcxaWNsQmhlVzFsYm5Rc0NpQWdJQ0F2THlBZ0lIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJtYjJ4c2IzZHpDaUFnSUNBdkx5QWdJSDBLSUNBZ0lDOHZJQ2tzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFMk1Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE5UZ3RNVFkwQ2lBZ0lDQXZMeUJ0WVhSamFDZ0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHWnZiR3h2ZDNNS0lDQWdJQzh2SUNBZ2ZRb2dJQ0FnTHk4Z0tTd0tJQ0FnSUQwOUNpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UVTNMVEUyTmdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQnRZWFJqYUNnS0lDQWdJQzh2SUNBZ0lDQnRZbkpRWVhsdFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhzS0lDQWdJQzh2SUNBZ0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0FnSUdGdGIzVnVkRG9nWm05c2JHOTNjd29nSUNBZ0x5OGdJQ0FnSUgwS0lDQWdJQzh2SUNBZ0tTd0tJQ0FnSUM4dklDQWdSVkpTWDBsT1ZrRk1TVVJmVUVGWlRVVk9WQW9nSUNBZ0x5OGdLUW9nSUNBZ1ltNTZJR1p2Ykd4dmQxOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpUlZKU09rbFFRVmtpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZTVkJCV1FvS1ptOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUyT0FvZ0lDQWdMeThnZEdocGN5NWpjbVZoZEdWR2IyeHNiM2NvVkhodUxuTmxibVJsY2l3Z1lXUmtjbVZ6Y3lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVadmJHeHZkd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUxTWdvZ0lDQWdMeThnWm05c2JHOTNLRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdnWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNTFibVp2Ykd4dmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ1Wm05c2JHOTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hOekVLSUNBZ0lDOHZJSFZ1Wm05c2JHOTNLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTNNZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0NGMGFHbHpMbWx6UW1GdWJtVmtLRlI0Ymk1elpXNWtaWElwTENCRlVsSmZRa0ZPVGtWRUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQnBjMEpoYm01bFpBb2dJQ0FnWW5vZ2RXNW1iMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJa1ZTVWpwQ1FVNUVJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09rSkJUa1FLQ25WdVptOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnWTI5dWMzUWdabTlzYkc5M2MwdGxlU0E5SUhSb2FYTXVabXgzS0dGa1pISmxjM01zSUZSNGJpNXpaVzVrWlhJcENpQWdJQ0JrZFhBS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTmhiR3h6ZFdJZ1pteDNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJR1p2Ykd4dmQzTWdQU0JDYjNoTllYQThSbTlzYkc5M2MwdGxlU3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaEdiMnhzYjNkeklIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSm1JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFM05nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFJvYVhNdVptOXNiRzkzY3lobWIyeHNiM2R6UzJWNUtTNWxlR2x6ZEhNc0lFVlNVbDlPVDFSZlJrOU1URTlYU1U1SEtRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nZFc1bWIyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPazVHVEZjaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2VGtaTVZ3b0tkVzVtYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UYzRDaUFnSUNBdkx5QmpiMjV6ZENCN0lHWnZiR3h2ZDJWeVEyOTFiblFzSUdadmJHeHZkMlZ5U1c1a1pYZ2dmU0E5SUhSb2FYTXVaMlYwVFdWMFlTaGhaR1J5WlhOektRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCallXeHNjM1ZpSUdkbGRFMWxkR0VLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME1Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTXpNS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UZ3dDaUFnSUNBdkx5QjBhR2x6TG5Wd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVNoaFpHUnlaWE56TENCbWIyeHNiM2RsY2tsdVpHVjRMQ0JtYjJ4c2IzZGxja052ZFc1MElDMGdNU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JqWVd4c2MzVmlJSFZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakU0TVFvZ0lDQWdMeThnZEdocGN5NW1iMnhzYjNkektHWnZiR3h2ZDNOTFpYa3BMbVJsYkdWMFpTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRnekxURTRPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCMGFHbHpMbTFpY2loQ2VYUmxjeWduSnlrc0lDY25MQ0JDZVhSbGN5Z25KeWtwTG1admJHeHZkM01LSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCeVpXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE9EWUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ2RHaHBjeTV0WW5Jb1FubDBaWE1vSnljcExDQW5KeXdnUW5sMFpYTW9KeWNwS1M1bWIyeHNiM2R6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtMWljZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakU0TXkweE9EY0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nZEdocGN5NXRZbklvUW5sMFpYTW9KeWNwTENBbkp5d2dRbmwwWlhNb0p5Y3BLUzVtYjJ4c2IzZHpDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UZ3pMVEU0T0FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQjBhR2x6TG0xaWNpaENlWFJsY3lnbkp5a3NJQ2NuTENCQ2VYUmxjeWduSnlrcExtWnZiR3h2ZDNNS0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTNNUW9nSUNBZ0x5OGdkVzVtYjJ4c2IzY29ZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1cGMwSnNiMk5yWldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjMEpzYjJOclpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGt4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRrekNpQWdJQ0F2THlCamIyNXpkQ0JpYkc5amEzTkxaWGtnUFNCMGFHbHpMbUpzYXloMWMyVnlMQ0JpYkc5amEyVmtLUW9nSUNBZ1kyRnNiSE4xWWlCaWJHc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdZbXh2WTJ0eklEMGdRbTk0VFdGd1BFSnNiMk5yVEdsemRFdGxlU3dnWW5sMFpYTThNRDQrS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRUpzYjJOcmN5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFNU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZbXh2WTJ0ektHSnNiMk5yYzB0bGVTa3VaWGhwYzNSekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94T1RFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzVwYzBadmJHeHZkMmx1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpSbTlzYkc5M2FXNW5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakU1TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFNU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWm05c2JHOTNjMHRsZVNBOUlIUm9hWE11Wm14M0tIVnpaWElzSUdadmJHeHZkMlZ5S1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQm1iSGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnWm05c2JHOTNjeUE5SUVKdmVFMWhjRHhHYjJ4c2IzZHpTMlY1TENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRVp2Ykd4dmQzTWdmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbVlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveU1EQUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbVp2Ykd4dmQzTW9abTlzYkc5M2MwdGxlU2t1WlhocGMzUnpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE9UY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1blpYUkdiMnhzYjNkSmJtUmxlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFWnZiR3h2ZDBsdVpHVjRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakl3TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJd05Rb2dJQ0FnTHk4Z1kyOXVjM1FnWm05c2JHOTNjMHRsZVNBOUlIUm9hWE11Wm14M0tIVnpaWElzSUdadmJHeHZkMlZ5S1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQm1iSGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnWm05c2JHOTNjeUE5SUVKdmVFMWhjRHhHYjJ4c2IzZHpTMlY1TENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRVp2Ykd4dmQzTWdmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbVlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveU1EWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbVp2Ykd4dmQzTW9abTlzYkc5M2MwdGxlU2t1ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNakF6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem82VlhCbmNtRmtaV0ZpYkdWQmEybDBZVUpoYzJWRGIyNTBjbUZqZEM1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8wTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlkZElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TkRnS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdPU0F2THlBaWQyRnNiR1YwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk5EZ0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1JWSlNYMDVQVkY5QlMwbFVRVjlFUVU4cENpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhWd1pHRjBaVjloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lrVlNVanBPUkVGUElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2s1RVFVOEtDblZ3WkdGMFpWOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pRNUNpQWdJQ0F2THlCamIyNXpkQ0IxY0dSaGRHVlFiSFZuYVc0Z1BTQm5aWFJRYkhWbmFXNUJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMblZ3WkdGMFpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pJM0NpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZORGtLSUNBZ0lDOHZJR052Ym5OMElIVndaR0YwWlZCc2RXZHBiaUE5SUdkbGRGQnNkV2RwYmtGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrdWRYQmtZWFJsQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzFOQW9nSUNBZ0x5OGdZMjl1YzNRZ1czQnNkV2RwYmtGd2NFeHBjM1JDZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5aGhhMmwwWVVSQlR5d2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5RYkhWbmFXNUJjSEJNYVhOMEtTa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSndZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME9Rb2dJQ0FnTHk4Z1kyOXVjM1FnZFhCa1lYUmxVR3gxWjJsdUlEMGdaMlYwVUd4MVoybHVRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUzUxY0dSaGRHVUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvMU1Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRWRzYjJKaGJDNWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrbGtJRDA5UFNCMWNHUmhkR1ZRYkhWbmFXNHNJRVZTVWw5SlRsWkJURWxFWDFWUVIxSkJSRVVwQ2lBZ0lDQm5iRzlpWVd3Z1EyRnNiR1Z5UVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCMWNHUmhkR1ZmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa2xWVUVjaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2U1ZWUVJ3b0tkWEJrWVhSbFgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpVS0lDQWdJQzh2SUhabGNuTnBiMjRnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVlpsY25OcGIyNGdmU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblpsY25OcGIyNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzFNUW9nSUNBZ0x5OGdkR2hwY3k1MlpYSnphVzl1TG5aaGJIVmxJRDBnYm1WM1ZtVnljMmx2YmdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZFZjR1JoZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZPa0ZyYVhSaFFtRnpaVU52Ym5SeVlXTjBMblZ3WkdGMFpVRnJhWFJoUkVGUFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFFXdHBkR0ZFUVU4NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek5nb2dJQ0FnTHk4Z2RYQmtZWFJsUVd0cGRHRkVRVThvWVd0cGRHRkVRVTg2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk16Y0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1JWSlNYMDVQVkY5QlMwbFVRVjlFUVU4cENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem96TUFvZ0lDQWdMeThnWTI5dWMzUWdXM2RoYkd4bGRFbEVYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUZWcGJuUTJOQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxZGhiR3hsZENrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV01nT1NBdkx5QWlkMkZzYkdWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNemNLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtZGxkRUZyYVhSaFJFRlBWMkZzYkdWMEtDa3VZV1JrY21WemN5d2dSVkpTWDA1UFZGOUJTMGxVUVY5RVFVOHBDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklIVndaR0YwWlVGcmFYUmhSRUZQWDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlSVkpTT2s1RVFVOGlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlRrUkJUd29LZFhCa1lYUmxRV3RwZEdGRVFVOWZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pveU53b2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPak00Q2lBZ0lDQXZMeUIwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsSUQwZ1lXdHBkR0ZFUVU4S0lDQWdJR1JwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk16WUtJQ0FnSUM4dklIVndaR0YwWlVGcmFYUmhSRUZQS0dGcmFYUmhSRUZQT2lCQmNIQnNhV05oZEdsdmJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzZRbUZ6WlZOdlkybGhiQzV0WW5KYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHRZbkk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1UVUtJQ0FnSUM4dklHMWljaWh5WldZNklHSjVkR1Z6TENCeVpXWlVlWEJsVG1GdFpUb2djM1J5YVc1bkxDQnlaV1pVZVhCbFUyTm9aVzFoT2lCaWVYUmxjeWs2SUVGcmFYUmhVMjlqYVdGc1RVSlNSR0YwWVNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCallXeHNjM1ZpSUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzZRbUZ6WlZOdlkybGhiQzV0WW5JS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk9rSmhjMlZUYjJOcFlXd3VjR0Y1VjJGc2JFMWljbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CaGVWZGhiR3hOWW5JNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNelFLSUNBZ0lDOHZJSEJoZVZkaGJHeE5ZbklvY0dGNWQyRnNiRG9nVm1sbGQxQmhlVmRoYkd4V1lXeDFaU2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTUNCdlppQW9LR3hsYmlzb2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DbGJYU2tzS0d4bGJpc29kV2x1ZERnc2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE53b2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNBckNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFZ2IyWWdLQ2hzWlc0cktIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME5qUXBXMTBwTENoc1pXNHJLSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFwVzEwcEtRb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXhDaUFnSUNCa2FXY2dOUW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE53b2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wzUjVjR1Z6TG5Sek9qcFdhV1YzVUdGNVYyRnNiRlpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNemNLSUNBZ0lDOHZJRkJoZVZkaGJHeFFZWGxQY0hScGIyNVRhWHBsSUNvZ0tIQmhlWGRoYkd3dVlXZGxiblJRWVhsSmJtWnZMbXhsYm1kMGFDQXJJSEJoZVhkaGJHd3VkWE5sY2xCaGVVbHVabTh1YkdWdVozUm9LUW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvek5pMHpPQW9nSUNBZ0x5OGdRbTk0UTI5emRGQmxja0o1ZEdVZ0tpQW9DaUFnSUNBdkx5QWdJRkJoZVZkaGJHeFFZWGxQY0hScGIyNVRhWHBsSUNvZ0tIQmhlWGRoYkd3dVlXZGxiblJRWVhsSmJtWnZMbXhsYm1kMGFDQXJJSEJoZVhkaGJHd3VkWE5sY2xCaGVVbHVabTh1YkdWdVozUm9LUW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR2x1ZENBMk9EQXdDaUFnSUNBcUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNelVLSUNBZ0lDOHZJSEpsZEhWeWJpQk5hVzVRWVhsWFlXeHNUVUpTSUNzZ0tBb2dJQ0FnY0hWemFHbHVkQ0ExTWpBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNelV0TXprS0lDQWdJQzh2SUhKbGRIVnliaUJOYVc1UVlYbFhZV3hzVFVKU0lDc2dLQW9nSUNBZ0x5OGdJQ0JDYjNoRGIzTjBVR1Z5UW5sMFpTQXFJQ2dLSUNBZ0lDOHZJQ0FnSUNCUVlYbFhZV3hzVUdGNVQzQjBhVzl1VTJsNlpTQXFJQ2h3WVhsM1lXeHNMbUZuWlc1MFVHRjVTVzVtYnk1c1pXNW5kR2dnS3lCd1lYbDNZV3hzTG5WelpYSlFZWGxKYm1adkxteGxibWQwYUNrS0lDQWdJQzh2SUNBZ0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qTTBDaUFnSUNBdkx5QndZWGxYWVd4c1RXSnlLSEJoZVhkaGJHdzZJRlpwWlhkUVlYbFhZV3hzVm1Gc2RXVXBPaUIxYVc1ME5qUWdld29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem82UW1GelpWTnZZMmxoYkM1amFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ob1pXTnJWR2x3VFdKeVVtVnhkV2x5WlcxbGJuUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pVMUNpQWdJQ0F2THlCamFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0c0lHTnlaV0YwYjNJNklFRmpZMjkxYm5Rc0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHBPaUIwYVhCTlFsSkpibVp2SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UZ0tJQ0FnSUM4dklHTnZibk4wSUdGcmFYUmhRWE56WlhSelFubDBaWE1nUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoYTJsMFlVUkJUeXdnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOQmEybDBZVUZ6YzJWMGN5a3BXekJkQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbUZyYVhSaFgyRnpjMlYwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem8xTmdvZ0lDQWdMeThnWTI5dWMzUWdZV3QwWVNBOUlFRnpjMlYwS0dkbGRFRnJhWFJoUVhOelpYUnpLR0ZyYVhSaFJFRlBLUzVoYTNSaEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZOVGdLSUNBZ0lDOHZJR2xtSUNnaFkzSmxZWFJ2Y2k1cGMwOXdkR1ZrU1c0b1lXdDBZU2tnSmlZZ2QyRnNiR1YwTG1sa0lDRTlQU0F3S1NCN0NpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ1pIVndDaUFnSUNCaWVpQmphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwYzE5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvME15MDFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRmlhVU5oYkd3OGRIbHdaVzltSUVGaWMzUnlZV04wWldSQlkyTnZkVzUwTG5CeWIzUnZkSGx3WlM1aGNtTTFPRjlqWVc1RFlXeHNQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnWjJWMFVHeDFaMmx1UVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1YjNCMGFXNHNDaUFnSUNBdkx5QWdJQ0FnUTJGc2JHVnlWSGx3WlVkc2IySmhiQ3dLSUNBZ0lDOHZJQ0FnSUNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdKeWNzQ2lBZ0lDQXZMeUFnSUNBZ2JXVjBhRzlrVTJWc1pXTjBiM0k4ZEhsd1pXOW1JRTl3ZEVsdVVHeDFaMmx1TG5CeWIzUnZkSGx3WlM1dmNIUkpiajRvS1FvZ0lDQWdMeThnSUNCZENpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvMU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNCc2RXZHBia0Z3Y0V4cGMzUkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGEybDBZVVJCVHl3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlFiSFZuYVc1QmNIQk1hWE4wS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWNHRnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qUTJDaUFnSUNBdkx5Qm5aWFJRYkhWbmFXNUJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNXZjSFJwYml3S0lDQWdJR1Y0ZEhKaFkzUWdNQ0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk5EY0tJQ0FnSUM4dklFTmhiR3hsY2xSNWNHVkhiRzlpWVd3c0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qUTRDaUFnSUNBdkx5QkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem8wTXkwMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRUZpYzNSeVlXTjBaV1JCWTJOdmRXNTBMbkJ5YjNSdmRIbHdaUzVoY21NMU9GOWpZVzVEWVd4c1BpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdaMlYwVUd4MVoybHVRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3ViM0IwYVc0c0NpQWdJQ0F2THlBZ0lDQWdRMkZzYkdWeVZIbHdaVWRzYjJKaGJDd0tJQ0FnSUM4dklDQWdJQ0JIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ0p5Y3NDaUFnSUNBdkx5QWdJQ0FnYldWMGFHOWtVMlZzWldOMGIzSThkSGx3Wlc5bUlFOXdkRWx1VUd4MVoybHVMbkJ5YjNSdmRIbHdaUzV2Y0hSSmJqNG9LUW9nSUNBZ0x5OGdJQ0JkQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlqTTJNak0wWVRVZ0x5OGdiV1YwYUc5a0lDSmhjbU0xT0Y5allXNURZV3hzS0hWcGJuUTJOQ3gxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jc1lubDBaVnMwWFNsaWIyOXNJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qUTVDaUFnSUNBdkx5QW5KeXdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TlRBS0lDQWdJQzh2SUcxbGRHaHZaRk5sYkdWamRHOXlQSFI1Y0dWdlppQlBjSFJKYmxCc2RXZHBiaTV3Y205MGIzUjVjR1V1YjNCMFNXNCtLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFk0TXpWbE0ySmpJQzh2SUcxbGRHaHZaQ0FpYjNCMFNXNG9kV2x1ZERZMExHSnZiMndzZFdsdWREWTBXMTBzY0dGNUtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalF6TFRVeUNpQWdJQ0F2THlCeVpYUjFjbTRnWVdKcFEyRnNiRHgwZVhCbGIyWWdRV0p6ZEhKaFkzUmxaRUZqWTI5MWJuUXVjSEp2ZEc5MGVYQmxMbUZ5WXpVNFgyTmhia05oYkd3K0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQm5aWFJRYkhWbmFXNUJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNXZjSFJwYml3S0lDQWdJQzh2SUNBZ0lDQkRZV3hzWlhKVWVYQmxSMnh2WW1Gc0xBb2dJQ0FnTHk4Z0lDQWdJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNBbkp5d0tJQ0FnSUM4dklDQWdJQ0J0WlhSb2IyUlRaV3hsWTNSdmNqeDBlWEJsYjJZZ1QzQjBTVzVRYkhWbmFXNHVjSEp2ZEc5MGVYQmxMbTl3ZEVsdVBpZ3BDaUFnSUNBdkx5QWdJRjBLSUNBZ0lDOHZJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pZd0NpQWdJQ0F2THlCcFppQW9ZMkZ1UTJGc2JFRnlZelU0VDNCMFNXNHBJSHNLSUNBZ0lHSjZJR05vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qWXpDaUFnSUNBdkx5QmhjbU0xT0RvZ1IyeHZZbUZzTG1GemMyVjBUM0IwU1c1TmFXNUNZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRWE56WlhSUGNIUkpiazFwYmtKaGJHRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvMk1TMDJOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdkSGx3WlRvZ1ZHbHdVMlZ1WkZSNWNHVkJVa00xT0N3S0lDQWdJQzh2SUNBZ1lYSmpOVGc2SUVkc2IySmhiQzVoYzNObGRFOXdkRWx1VFdsdVFtRnNZVzVqWlFvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qWXlDaUFnSUNBdkx5QjBlWEJsT2lCVWFYQlRaVzVrVkhsd1pVRlNRelU0TEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzJNUzAyTkFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dWR2x3VTJWdVpGUjVjR1ZCVWtNMU9Dd0tJQ0FnSUM4dklDQWdZWEpqTlRnNklFZHNiMkpoYkM1aGMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnTHk4Z2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDZ3BqYUdWamExUnBjRTFpY2xKbGNYVnBjbVZ0Wlc1MGMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzZRbUZ6WlZOdlkybGhiQzVqYUdWamExUnBjRTFpY2xKbGNYVnBjbVZ0Wlc1MGMwQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pVMUNpQWdJQ0F2THlCamFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0c0lHTnlaV0YwYjNJNklFRmpZMjkxYm5Rc0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHBPaUIwYVhCTlFsSkpibVp2SUhzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvMk9DMDNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdkSGx3WlRvZ1ZHbHdVMlZ1WkZSNWNHVkVhWEpsWTNRc0NpQWdJQ0F2THlBZ0lHRnlZelU0T2lBd0NpQWdJQ0F2THlCOUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1lUQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzFOUW9nSUNBZ0x5OGdZMmhsWTJ0VWFYQk5ZbkpTWlhGMWFYSmxiV1Z1ZEhNb1lXdHBkR0ZFUVU4NklFRndjR3hwWTJGMGFXOXVMQ0JqY21WaGRHOXlPaUJCWTJOdmRXNTBMQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ2RHbHdUVUpTU1c1bWJ5QjdDaUFnSUNCaUlHTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6UURjS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1IzSmhjR2d1YVhOQ1lXNXVaV1FvWVdOamIzVnVkRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LYVhOQ1lXNXVaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhCeWFYWmhkR1VnYVhOQ1lXNXVaV1FvWVdOamIzVnVkRG9nUVdOamIzVnVkQ2s2SUdKdmIyeGxZVzRnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJR052Ym5OMElIc2diVzlrWlhKaGRHbHZiaUI5SUQwZ1oyVjBRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklHTnZibk4wSUhzZ2JXOWtaWEpoZEdsdmJpQjlJRDBnWjJWMFFXdHBkR0ZUYjJOcFlXeEJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvME9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzJGd2NFeHBjM1JDZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5aGhhMmwwWVVSQlR5d2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5CYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FwS1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpYzJGc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJqYjI1emRDQjdJRzF2WkdWeVlYUnBiMjRnZlNBOUlHZGxkRUZyYVhSaFUyOWphV0ZzUVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1FvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem96TXkwek5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRUZyYVhSaFUyOWphV0ZzVFc5a1pYSmhkR2x2Ymk1d2NtOTBiM1I1Y0dVdWFYTkNZVzV1WldRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHMXZaR1Z5WVhScGIyNHNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGhZMk52ZFc1MFhRb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPRFF5Tmpsak56Z2dMeThnYldWMGFHOWtJQ0pwYzBKaGJtNWxaQ2hoWkdSeVpYTnpLV0p2YjJ3aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdKdmIyd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNWliR3NvZFhObGNrRmtaSEpsYzNNNklHSjVkR1Z6TENCaWJHOWphMlZrUVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BpYkdzNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklIQnlhWFpoZEdVZ1lteHJLSFZ6WlhKQlpHUnlaWE56T2lCQlkyTnZkVzUwTENCaWJHOWphMlZrUVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUVKc2IyTnJUR2x6ZEV0bGVTQjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1kyOXVjM1FnZFhObGNpQTlJSFZ6WlhKQlpHUnlaWE56TG1KNWRHVnpMbk5zYVdObEtEQXNJREUyS1M1MGIwWnBlR1ZrS0hzZ2JHVnVaM1JvT2lBeE5pQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemRXSnpkSEpwYm1jZ01DQXhOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUR1Z1WjNSb0lHMTFjM1FnWW1VZ01UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdZMjl1YzNRZ1lteHZZMnRsWkNBOUlHSnNiMk5yWldSQlpHUnlaWE56TG1KNWRHVnpMbk5zYVdObEtEQXNJREUyS1M1MGIwWnBlR1ZrS0hzZ2JHVnVaM1JvT2lBeE5pQjlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCemRXSnpkSEpwYm1jZ01DQXhOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUR1Z1WjNSb0lHMTFjM1FnWW1VZ01UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdjbVYwZFhKdUlIc2dkWE5sY2l3Z1lteHZZMnRsWkNCOUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNW1iSGNvZFhObGNqb2dZbmwwWlhNc0lHWnZiR3h2ZDJWeU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtWnNkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnY0hKcGRtRjBaU0JtYkhjb2RYTmxjam9nUVdOamIzVnVkQ3dnWm05c2JHOTNaWEk2SUVGalkyOTFiblFwT2lCR2IyeHNiM2R6UzJWNUlIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCamIyNXpkQ0IxYzJWeVFubDBaWE1nUFNCMWMyVnlMbUo1ZEdWekxuTnNhV05sS0RBc0lERTJLUzUwYjBacGVHVmtLSHNnYkdWdVozUm9PaUF4TmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZFdKemRISnBibWNnTUNBeE5nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHVnVaM1JvSUcxMWMzUWdZbVVnTVRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWm05c2JHOTNaWEpDZVhSbGN5QTlJR1p2Ykd4dmQyVnlMbUo1ZEdWekxuTnNhV05sS0RBc0lERTJLUzUwYjBacGVHVmtLSHNnYkdWdVozUm9PaUF4TmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZFdKemRISnBibWNnTUNBeE5nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHVnVaM1JvSUcxMWMzUWdZbVVnTVRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzZ2RYTmxjam9nZFhObGNrSjVkR1Z6TENCbWIyeHNiM2RsY2pvZ1ptOXNiRzkzWlhKQ2VYUmxjeUI5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1blpYUk5aWFJoS0dGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFRXVjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnY0hKcGRtRjBaU0JuWlhSTlpYUmhLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUJOWlhSaFZtRnNkV1VnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJR052Ym5OMElIc2djMjlqYVdGc0lIMGdQU0JuWlhSQmEybDBZVk52WTJsaGJFRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pveU53b2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWTI5dWMzUWdleUJ6YjJOcFlXd2dmU0E5SUdkbGRFRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5Ea0tJQ0FnSUM4dklHTnZibk4wSUZ0aGNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6UVd0cGRHRlRiMk5wWVd4QmNIQk1hWE4wS1NrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5OaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWTI5dWMzUWdleUJ6YjJOcFlXd2dmU0E5SUdkbGRFRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOVFV0TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJoWW1sRFlXeHNQSFI1Y0dWdlppQkJhMmwwWVZOdlkybGhiQzV3Y205MGIzUjVjR1V1WjJWMFRXVjBZVDRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nYzI5amFXRnNMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJZV1JrY21WemMxMEtJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGN6T1dWaE56QmlJQzh2SUcxbGRHaHZaQ0FpWjJWMFRXVjBZU2hoWkdSeVpYTnpLU2hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTnpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmRIbHdaWE11ZEhNNk9rMWxkR0ZXWVd4MVpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRWR5WVhCb0xuVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlTaGhZMk52ZFc1ME9pQmllWFJsY3l3Z2JtVjNSbTlzYkc5M1pYSkpibVJsZURvZ2RXbHVkRFkwTENCdVpYZEdiMnhzYjNkbGNrTnZkVzUwT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2NISnBkbUYwWlNCMWNHUmhkR1ZHYjJ4c2IzZGxjazFsZEdFb1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZEN3Z2JtVjNSbTlzYkc5M1pYSkpibVJsZURvZ2RXbHVkRFkwTENCdVpYZEdiMnhzYjNkbGNrTnZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmpiMjV6ZENCN0lITnZZMmxoYkNCOUlEMGdaMlYwUVd0cGRHRlRiMk5wWVd4QmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJR052Ym5OMElIc2djMjlqYVdGc0lIMGdQU0JuWlhSQmEybDBZVk52WTJsaGJFRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRNUNpQWdJQ0F2THlCamIyNXpkQ0JiWVhCd1RHbHpkRUo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektHRnJhWFJoUkVGUExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMEZyYVhSaFUyOWphV0ZzUVhCd1RHbHpkQ2twQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p6WVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOaklLSUNBZ0lDOHZJR052Ym5OMElIc2djMjlqYVdGc0lIMGdQU0JuWlhSQmEybDBZVk52WTJsaGJFRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qWXpMVFkyQ2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQkJhMmwwWVZOdlkybGhiQzV3Y205MGIzUjVjR1V1ZFhCa1lYUmxSbTlzYkc5M1pYSk5aWFJoUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCemIyTnBZV3dzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRoWTJOdmRXNTBMQ0J1WlhkR2IyeHNiM2RsY2tsdVpHVjRMQ0J1WlhkR2IyeHNiM2RsY2tOdmRXNTBYUW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdZWEpuY3pvZ1cyRmpZMjkxYm5Rc0lHNWxkMFp2Ykd4dmQyVnlTVzVrWlhnc0lHNWxkMFp2Ykd4dmQyVnlRMjkxYm5SZENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8yTXkwMk5nb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVd0cGRHRlRiMk5wWVd3dWNISnZkRzkwZVhCbExuVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djMjlqYVdGc0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYllXTmpiM1Z1ZEN3Z2JtVjNSbTlzYkc5M1pYSkpibVJsZUN3Z2JtVjNSbTlzYkc5M1pYSkRiM1Z1ZEYwS0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek16QTJZak15WVNBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlTaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1IzSmhjR2d1WTNKbFlYUmxSbTlzYkc5M0tITmxibVJsY2pvZ1lubDBaWE1zSUdGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BqY21WaGRHVkdiMnhzYjNjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklIQnlhWFpoZEdVZ1kzSmxZWFJsUm05c2JHOTNLSE5sYm1SbGNqb2dRV05qYjNWdWRDd2dZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb0lYUm9hWE11YVhOQ1lXNXVaV1FvYzJWdVpHVnlLU3dnUlZKU1gwSkJUazVGUkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQnBjMEpoYm01bFpBb2dJQ0FnWW5vZ1kzSmxZWFJsUm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBeUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKRlVsSTZRa0ZPUkNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBDUVU1RUNncGpjbVZoZEdWR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGt6Q2lBZ0lDQXZMeUJqYjI1emRDQmliRzlqYTNOTFpYa2dQU0IwYUdsekxtSnNheWgxYzJWeUxDQmliRzlqYTJWa0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdZbXhyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUdKc2IyTnJjeUE5SUVKdmVFMWhjRHhDYkc5amEweHBjM1JMWlhrc0lHSjVkR1Z6UERBK1BpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoQ2JHOWphM01nZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1JaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hPVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1Kc2IyTnJjeWhpYkc5amEzTkxaWGtwTG1WNGFYTjBjd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2doZEdocGN5NXBjMEpzYjJOclpXUW9ZV1JrY21WemN5d2djMlZ1WkdWeUtTd2dSVkpTWDBKTVQwTkxSVVFwQ2lBZ0lDQmllaUJqY21WaGRHVkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2tKTVMwUWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlFreExSQW9LWTNKbFlYUmxSbTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9jMlZ1WkdWeUlDRTlQU0JoWkdSeVpYTnpMQ0JGVWxKZlUwVk1SbDlHVDB4TVQxY3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnSVQwS0lDQWdJR0p1ZWlCamNtVmhkR1ZHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURZS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09sTkdURmNpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZVMFpNVndvS1kzSmxZWFJsUm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCN0lHRjFkRzl0WVhSbFpDQjlJRDBnZEdocGN5NW5aWFJOWlhSaEtITmxibVJsY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJOWlhSaENpQWdJQ0J3ZFhOb2FXNTBJRE01TWdvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2doWVhWMGIyMWhkR1ZrTENCRlVsSmZRVlZVVDAxQlZFVkVYMEZEUTA5VlRsUXBDaUFnSUNCaWVpQmpjbVZoZEdWR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFEZ0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa0ZWVkU4aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2UVZWVVR3b0tZM0psWVhSbFJtOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJqYjI1emRDQm1iMnhzYjNkelMyVjVJRDBnZEdocGN5NW1iSGNvWVdSa2NtVnpjeXdnYzJWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnWm14M0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHWnZiR3h2ZDNNZ1BTQkNiM2hOWVhBOFJtOXNiRzkzYzB0bGVTd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoR2IyeHNiM2R6SUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvSVhSb2FYTXVabTlzYkc5M2N5aG1iMnhzYjNkelMyVjVLUzVsZUdsemRITXNJRVZTVWw5QlRGSkZRVVJaWDBaUFRFeFBWMGxPUnlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZM0psWVhSbFJtOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQXhNQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2UVVaTVZ5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwQlJreFhDZ3BqY21WaGRHVkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCamIyNXpkQ0I3SUdadmJHeHZkMlZ5UTI5MWJuUXNJR1p2Ykd4dmQyVnlTVzVrWlhnZ2ZTQTlJSFJvYVhNdVoyVjBUV1YwWVNoaFpHUnlaWE56S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRTFsZEdFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBNUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ016TUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJSFJvYVhNdVptOXNiRzkzY3lobWIyeHNiM2R6UzJWNUtTNTJZV3gxWlNBOUlHWnZiR3h2ZDJWeVNXNWtaWGdnS3lBeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUIwYUdsekxuVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlTaGhaR1J5WlhOekxDQm1iMnhzYjNkbGNrbHVaR1Y0SUNzZ01Td2dabTlzYkc5M1pYSkRiM1Z1ZENBcklERXBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJSFZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtMWljaWh5WldZNklHSjVkR1Z6TENCeVpXWlVlWEJsVG1GdFpUb2dZbmwwWlhNc0lISmxabFI1Y0dWVFkyaGxiV0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbTFpY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6b3hOUW9nSUNBZ0x5OGdiV0p5S0hKbFpqb2dZbmwwWlhNc0lISmxabFI1Y0dWT1lXMWxPaUJ6ZEhKcGJtY3NJSEpsWmxSNWNHVlRZMmhsYldFNklHSjVkR1Z6S1RvZ1FXdHBkR0ZUYjJOcFlXeE5RbEpFWVhSaElIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qRTVDaUFnSUNBdkx5QndiM04wY3pvZ1RXbHVVRzl6ZEhOTlFsSWdLeUFvUW05NFEyOXpkRkJsY2tKNWRHVWdLaUJ5WldZdWJHVnVaM1JvS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUXdNQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0EwTmpVd01Bb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qTXdDaUFnSUNBdkx5QnlaV1pVZVhCbGN6b2dVbVZtVkhsd1pYTkNZWE5sVFVKU0lDc2dLRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2dLRUo1ZEdWektISmxabFI1Y0dWT1lXMWxLUzVzWlc1bmRHZ2dLeUJDZVhSbGN5aHlaV1pVZVhCbFUyTm9aVzFoS1M1c1pXNW5kR2dwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNBckNpQWdJQ0J3ZFhOb2FXNTBJRFF3TUFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBNU16QXdDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNVFl0TXpFS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUdadmJHeHZkM002SUVadmJHeHZkM05OUWxJc0NpQWdJQ0F2THlBZ0lHSnNiMk5yY3pvZ1FteHZZMnR6VFVKU0xBb2dJQ0FnTHk4Z0lDQndiM04wY3pvZ1RXbHVVRzl6ZEhOTlFsSWdLeUFvUW05NFEyOXpkRkJsY2tKNWRHVWdLaUJ5WldZdWJHVnVaM1JvS1N3S0lDQWdJQzh2SUNBZ2RtOTBaWE02SUZadmRHVnpUVUpTTEFvZ0lDQWdMeThnSUNCMmIzUmxiR2x6ZERvZ1ZtOTBaV3hwYzNSTlFsSXNDaUFnSUNBdkx5QWdJSEpsWVdOMGFXOXVjem9nVW1WaFkzUnBiMjV6VFVKU0xBb2dJQ0FnTHk4Z0lDQnlaV0ZqZEdsdmJteHBjM1E2SUZKbFlXTjBhVzl1YkdsemRFMUNVaXdLSUNBZ0lDOHZJQ0FnYldWMFlUb2dUV1YwWVUxQ1Vpd0tJQ0FnSUM4dklDQWdiVzlrWlhKaGRHOXljem9nVFc5a1pYSmhkRzl5YzAxQ1Vpd0tJQ0FnSUM4dklDQWdZbUZ1Ym1Wa09pQkNZVzV1WldSTlFsSXNDaUFnSUNBdkx5QWdJR0ZqZEdsdmJuTTZJRUZqZEdsdmJuTk5RbElzQ2lBZ0lDQXZMeUFnSUM4dklFSnZlQ0JyWlhrNklIQnlaV1pwZUNneEtTQXJJSFZwYm5RMk5DZzRLU0E5SURrZ1lubDBaWE1LSUNBZ0lDOHZJQ0FnTHk4Z1FtOTRJSFpoYkhWbE9pQkJVa010TkNCb1pXRmtaWElvTkNrZ0t5QnpkSEpwYm1jZ2JHVnVaM1JvS0RJcElDc2dibUZ0WlNBcklHSjVkR1Z6SUd4bGJtZDBhQ2d5S1NBcklITmphR1Z0WVFvZ0lDQWdMeThnSUNCeVpXWlVlWEJsY3pvZ1VtVm1WSGx3WlhOQ1lYTmxUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNlWFJsSUNvZ0tFSjVkR1Z6S0hKbFpsUjVjR1ZPWVcxbEtTNXNaVzVuZEdnZ0t5QkNlWFJsY3loeVpXWlVlWEJsVTJOb1pXMWhLUzVzWlc1bmRHZ3BLUW9nSUNBZ0x5OGdmUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TjJKa05EQXdNREF3TURBd01EQXdNRE5rTlRRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPakl3Q2lBZ0lDQXZMeUIyYjNSbGN6b2dWbTkwWlhOTlFsSXNDaUFnSUNCd2RYTm9hVzUwSURFNU16QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TVRZdE16RUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHWnZiR3h2ZDNNNklFWnZiR3h2ZDNOTlFsSXNDaUFnSUNBdkx5QWdJR0pzYjJOcmN6b2dRbXh2WTJ0elRVSlNMQW9nSUNBZ0x5OGdJQ0J3YjNOMGN6b2dUV2x1VUc5emRITk5RbElnS3lBb1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lCeVpXWXViR1Z1WjNSb0tTd0tJQ0FnSUM4dklDQWdkbTkwWlhNNklGWnZkR1Z6VFVKU0xBb2dJQ0FnTHk4Z0lDQjJiM1JsYkdsemREb2dWbTkwWld4cGMzUk5RbElzQ2lBZ0lDQXZMeUFnSUhKbFlXTjBhVzl1Y3pvZ1VtVmhZM1JwYjI1elRVSlNMQW9nSUNBZ0x5OGdJQ0J5WldGamRHbHZibXhwYzNRNklGSmxZV04wYVc5dWJHbHpkRTFDVWl3S0lDQWdJQzh2SUNBZ2JXVjBZVG9nVFdWMFlVMUNVaXdLSUNBZ0lDOHZJQ0FnYlc5a1pYSmhkRzl5Y3pvZ1RXOWtaWEpoZEc5eWMwMUNVaXdLSUNBZ0lDOHZJQ0FnWW1GdWJtVmtPaUJDWVc1dVpXUk5RbElzQ2lBZ0lDQXZMeUFnSUdGamRHbHZibk02SUVGamRHbHZibk5OUWxJc0NpQWdJQ0F2THlBZ0lDOHZJRUp2ZUNCclpYazZJSEJ5WldacGVDZ3hLU0FySUhWcGJuUTJOQ2c0S1NBOUlEa2dZbmwwWlhNS0lDQWdJQzh2SUNBZ0x5OGdRbTk0SUhaaGJIVmxPaUJCVWtNdE5DQm9aV0ZrWlhJb05Da2dLeUJ6ZEhKcGJtY2diR1Z1WjNSb0tESXBJQ3NnYm1GdFpTQXJJR0o1ZEdWeklHeGxibWQwYUNneUtTQXJJSE5qYUdWdFlRb2dJQ0FnTHk4Z0lDQnlaV1pVZVhCbGN6b2dVbVZtVkhsd1pYTkNZWE5sVFVKU0lDc2dLRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2dLRUo1ZEdWektISmxabFI1Y0dWT1lXMWxLUzVzWlc1bmRHZ2dLeUJDZVhSbGN5aHlaV1pVZVhCbFUyTm9aVzFoS1M1c1pXNW5kR2dwS1FvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TWpJS0lDQWdJQzh2SUhKbFlXTjBhVzl1Y3pvZ1VtVmhZM1JwYjI1elRVSlNMQW9nSUNBZ2NIVnphR2x1ZENBeU1qRXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pFMkxUTXhDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQm1iMnhzYjNkek9pQkdiMnhzYjNkelRVSlNMQW9nSUNBZ0x5OGdJQ0JpYkc5amEzTTZJRUpzYjJOcmMwMUNVaXdLSUNBZ0lDOHZJQ0FnY0c5emRITTZJRTFwYmxCdmMzUnpUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNlWFJsSUNvZ2NtVm1MbXhsYm1kMGFDa3NDaUFnSUNBdkx5QWdJSFp2ZEdWek9pQldiM1JsYzAxQ1Vpd0tJQ0FnSUM4dklDQWdkbTkwWld4cGMzUTZJRlp2ZEdWc2FYTjBUVUpTTEFvZ0lDQWdMeThnSUNCeVpXRmpkR2x2Ym5NNklGSmxZV04wYVc5dWMwMUNVaXdLSUNBZ0lDOHZJQ0FnY21WaFkzUnBiMjVzYVhOME9pQlNaV0ZqZEdsdmJteHBjM1JOUWxJc0NpQWdJQ0F2THlBZ0lHMWxkR0U2SUUxbGRHRk5RbElzQ2lBZ0lDQXZMeUFnSUcxdlpHVnlZWFJ2Y25NNklFMXZaR1Z5WVhSdmNuTk5RbElzQ2lBZ0lDQXZMeUFnSUdKaGJtNWxaRG9nUW1GdWJtVmtUVUpTTEFvZ0lDQWdMeThnSUNCaFkzUnBiMjV6T2lCQlkzUnBiMjV6VFVKU0xBb2dJQ0FnTHk4Z0lDQXZMeUJDYjNnZ2EyVjVPaUJ3Y21WbWFYZ29NU2tnS3lCMWFXNTBOalFvT0NrZ1BTQTVJR0o1ZEdWekNpQWdJQ0F2THlBZ0lDOHZJRUp2ZUNCMllXeDFaVG9nUVZKRExUUWdhR1ZoWkdWeUtEUXBJQ3NnYzNSeWFXNW5JR3hsYm1kMGFDZ3lLU0FySUc1aGJXVWdLeUJpZVhSbGN5QnNaVzVuZEdnb01pa2dLeUJ6WTJobGJXRUtJQ0FnSUM4dklDQWdjbVZtVkhsd1pYTTZJRkpsWmxSNWNHVnpRbUZ6WlUxQ1VpQXJJQ2hDYjNoRGIzTjBVR1Z5UW5sMFpTQXFJQ2hDZVhSbGN5aHlaV1pVZVhCbFRtRnRaU2t1YkdWdVozUm9JQ3NnUW5sMFpYTW9jbVZtVkhsd1pWTmphR1Z0WVNrdWJHVnVaM1JvS1NrS0lDQWdJQzh2SUgwS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPakl6Q2lBZ0lDQXZMeUJ5WldGamRHbHZibXhwYzNRNklGSmxZV04wYVc5dWJHbHpkRTFDVWl3S0lDQWdJSEIxYzJocGJuUWdNVGc1TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6b3hOaTB6TVFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnWm05c2JHOTNjem9nUm05c2JHOTNjMDFDVWl3S0lDQWdJQzh2SUNBZ1lteHZZMnR6T2lCQ2JHOWphM05OUWxJc0NpQWdJQ0F2THlBZ0lIQnZjM1J6T2lCTmFXNVFiM04wYzAxQ1VpQXJJQ2hDYjNoRGIzTjBVR1Z5UW5sMFpTQXFJSEpsWmk1c1pXNW5kR2dwTEFvZ0lDQWdMeThnSUNCMmIzUmxjem9nVm05MFpYTk5RbElzQ2lBZ0lDQXZMeUFnSUhadmRHVnNhWE4wT2lCV2IzUmxiR2x6ZEUxQ1Vpd0tJQ0FnSUM4dklDQWdjbVZoWTNScGIyNXpPaUJTWldGamRHbHZibk5OUWxJc0NpQWdJQ0F2THlBZ0lISmxZV04wYVc5dWJHbHpkRG9nVW1WaFkzUnBiMjVzYVhOMFRVSlNMQW9nSUNBZ0x5OGdJQ0J0WlhSaE9pQk5aWFJoVFVKU0xBb2dJQ0FnTHk4Z0lDQnRiMlJsY21GMGIzSnpPaUJOYjJSbGNtRjBiM0p6VFVKU0xBb2dJQ0FnTHk4Z0lDQmlZVzV1WldRNklFSmhibTVsWkUxQ1Vpd0tJQ0FnSUM4dklDQWdZV04wYVc5dWN6b2dRV04wYVc5dWMwMUNVaXdLSUNBZ0lDOHZJQ0FnTHk4Z1FtOTRJR3RsZVRvZ2NISmxabWw0S0RFcElDc2dkV2x1ZERZMEtEZ3BJRDBnT1NCaWVYUmxjd29nSUNBZ0x5OGdJQ0F2THlCQ2IzZ2dkbUZzZFdVNklFRlNReTAwSUdobFlXUmxjaWcwS1NBcklITjBjbWx1WnlCc1pXNW5kR2dvTWlrZ0t5QnVZVzFsSUNzZ1lubDBaWE1nYkdWdVozUm9LRElwSUNzZ2MyTm9aVzFoQ2lBZ0lDQXZMeUFnSUhKbFpsUjVjR1Z6T2lCU1pXWlVlWEJsYzBKaGMyVk5RbElnS3lBb1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lBb1FubDBaWE1vY21WbVZIbHdaVTVoYldVcExteGxibWQwYUNBcklFSjVkR1Z6S0hKbFpsUjVjR1ZUWTJobGJXRXBMbXhsYm1kMGFDa3BDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1qUUtJQ0FnSUM4dklHMWxkR0U2SUUxbGRHRk5RbElzQ2lBZ0lDQndkWE5vYVc1MElEUTFNekF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1UWXRNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQjdDaUFnSUNBdkx5QWdJR1p2Ykd4dmQzTTZJRVp2Ykd4dmQzTk5RbElzQ2lBZ0lDQXZMeUFnSUdKc2IyTnJjem9nUW14dlkydHpUVUpTTEFvZ0lDQWdMeThnSUNCd2IzTjBjem9nVFdsdVVHOXpkSE5OUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnlaV1l1YkdWdVozUm9LU3dLSUNBZ0lDOHZJQ0FnZG05MFpYTTZJRlp2ZEdWelRVSlNMQW9nSUNBZ0x5OGdJQ0IyYjNSbGJHbHpkRG9nVm05MFpXeHBjM1JOUWxJc0NpQWdJQ0F2THlBZ0lISmxZV04wYVc5dWN6b2dVbVZoWTNScGIyNXpUVUpTTEFvZ0lDQWdMeThnSUNCeVpXRmpkR2x2Ym14cGMzUTZJRkpsWVdOMGFXOXViR2x6ZEUxQ1Vpd0tJQ0FnSUM4dklDQWdiV1YwWVRvZ1RXVjBZVTFDVWl3S0lDQWdJQzh2SUNBZ2JXOWtaWEpoZEc5eWN6b2dUVzlrWlhKaGRHOXljMDFDVWl3S0lDQWdJQzh2SUNBZ1ltRnVibVZrT2lCQ1lXNXVaV1JOUWxJc0NpQWdJQ0F2THlBZ0lHRmpkR2x2Ym5NNklFRmpkR2x2Ym5OTlFsSXNDaUFnSUNBdkx5QWdJQzh2SUVKdmVDQnJaWGs2SUhCeVpXWnBlQ2d4S1NBcklIVnBiblEyTkNnNEtTQTlJRGtnWW5sMFpYTUtJQ0FnSUM4dklDQWdMeThnUW05NElIWmhiSFZsT2lCQlVrTXROQ0JvWldGa1pYSW9OQ2tnS3lCemRISnBibWNnYkdWdVozUm9LRElwSUNzZ2JtRnRaU0FySUdKNWRHVnpJR3hsYm1kMGFDZ3lLU0FySUhOamFHVnRZUW9nSUNBZ0x5OGdJQ0J5WldaVWVYQmxjem9nVW1WbVZIbHdaWE5DWVhObFRVSlNJQ3NnS0VKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nS0VKNWRHVnpLSEpsWmxSNWNHVk9ZVzFsS1M1c1pXNW5kR2dnS3lCQ2VYUmxjeWh5WldaVWVYQmxVMk5vWlcxaEtTNXNaVzVuZEdncEtRb2dJQ0FnTHk4Z2ZRb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV04wYVc5dWN6b2dRV04wYVc5dWMwMUNVaXdLSUNBZ0lIQjFjMmhwYm5RZ01qazNNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pveE5pMHpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdabTlzYkc5M2N6b2dSbTlzYkc5M2MwMUNVaXdLSUNBZ0lDOHZJQ0FnWW14dlkydHpPaUJDYkc5amEzTk5RbElzQ2lBZ0lDQXZMeUFnSUhCdmMzUnpPaUJOYVc1UWIzTjBjMDFDVWlBcklDaENiM2hEYjNOMFVHVnlRbmwwWlNBcUlISmxaaTVzWlc1bmRHZ3BMQW9nSUNBZ0x5OGdJQ0IyYjNSbGN6b2dWbTkwWlhOTlFsSXNDaUFnSUNBdkx5QWdJSFp2ZEdWc2FYTjBPaUJXYjNSbGJHbHpkRTFDVWl3S0lDQWdJQzh2SUNBZ2NtVmhZM1JwYjI1ek9pQlNaV0ZqZEdsdmJuTk5RbElzQ2lBZ0lDQXZMeUFnSUhKbFlXTjBhVzl1YkdsemREb2dVbVZoWTNScGIyNXNhWE4wVFVKU0xBb2dJQ0FnTHk4Z0lDQnRaWFJoT2lCTlpYUmhUVUpTTEFvZ0lDQWdMeThnSUNCdGIyUmxjbUYwYjNKek9pQk5iMlJsY21GMGIzSnpUVUpTTEFvZ0lDQWdMeThnSUNCaVlXNXVaV1E2SUVKaGJtNWxaRTFDVWl3S0lDQWdJQzh2SUNBZ1lXTjBhVzl1Y3pvZ1FXTjBhVzl1YzAxQ1Vpd0tJQ0FnSUM4dklDQWdMeThnUW05NElHdGxlVG9nY0hKbFptbDRLREVwSUNzZ2RXbHVkRFkwS0RncElEMGdPU0JpZVhSbGN3b2dJQ0FnTHk4Z0lDQXZMeUJDYjNnZ2RtRnNkV1U2SUVGU1F5MDBJR2hsWVdSbGNpZzBLU0FySUhOMGNtbHVaeUJzWlc1bmRHZ29NaWtnS3lCdVlXMWxJQ3NnWW5sMFpYTWdiR1Z1WjNSb0tESXBJQ3NnYzJOb1pXMWhDaUFnSUNBdkx5QWdJSEpsWmxSNWNHVnpPaUJTWldaVWVYQmxjMEpoYzJWTlFsSWdLeUFvUW05NFEyOXpkRkJsY2tKNWRHVWdLaUFvUW5sMFpYTW9jbVZtVkhsd1pVNWhiV1VwTG14bGJtZDBhQ0FySUVKNWRHVnpLSEpsWmxSNWNHVlRZMmhsYldFcExteGxibWQwYUNrcENpQWdJQ0F2THlCOUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQWlZTUNXRnJhWFJoWDJSaGJ3UVZIM3gxQUFoRlVsSTZRa0ZPUkFGaUFXWUlSVkpTT2tsUVFWa0RjMkZzQjNabGNuTnBiMjRHZDJGc2JHVjBDRVZTVWpwT1JFRlBBM0JoYklBRTZwR0EzVFlhQUk0QkFId3hHUlJFTVJoQkFHV0NEUVMxbklwVUJLN3JzM2dFaG1kVWxBUkxiNUIvQkJZYk9ub0VRd05tamdUcll2VUlCQW1EZ0tRRU0ra3NsQVNGVGUzZ0JCUXlUN2NFb1RTaWVBUTBRWFh3TmhvQWpnMEFRUUNmQVBBQm93SHlBbFFDZXdLakF3NEFBUU16QTJ3RHZRQWpRNEFFYjVnWDlqWWFBSTRCQUEwQU1SbUJCQkl4R0JCRVFnS29OaG9CU1JXQkNCSkVGellhQWtraVdTVUlTd0VWRWtSWEFnQW9Ud0puSndoTVp5TkRNUllqQ1VrNEVDTVNSRFlhQVVrVkpCSkVNUUNJQkE1QkFBTXJzQUF4QUVzQkUwQUFESUFJUlZKU09sTkNURXV3QUVzQlNUZ0hNZ29TVERnSUtrY0NpQVZWZ1FoYkVoQkFBQVFuQnJBQU1RQkxBWWdFQ2ljRVRGQWl1VWdqUXlJMkdnRkpGU1FTUkRFQWlBTzVRUUFESzdBQU1RQkxBWWdENWljRVRGQkpSUU85UlFGQUFBeUFDRVZTVWpwVlRrSkxzQUJMQWJ4SXNURUFLa2NDaUFUNGdRaGJzZ2l5QnlPeUVDS3lBYk1qUXpFV0pRbEpPQkFqRWtReEZpTUpSd0k0RUlFR0VrUTJHZ0ZKVGdKSkZTUVNSSWdEd2xjeUNFd2lLR1ZFTVFCT0FrdzRHRXlBQTJGaGJHVklnU2hiRWtFQWJVc0RPQmxBQUdaTEF6Z2JnUVFTUVFCY1N3TWl3aHFBQkVPU0psVVNRUUJOU3dNandocExBUkpCQUVKTEF5WENHa3NDRWtFQU55TkFBQXlBQ0VWU1VqcEdSMVJGc0FBcVJ3S0lCRm9pVzBzRlNUZ0hNZ29TVERnSVR3SVNFRUFBQkNjR3NBQXhBRXNEaUFPakkwTWlRdi9HTVJZakNVazRFQ01TUkRZYUFVY0NGU1FTUklnREhZRXlXMEVBRElBSVJWSlNPa2hIVkVXd0FDcEhBb2dFQnlKYlN3SkpPQWN5Q2hKTU9BaFBBaElRUUFBRUp3YXdBREVBU3dHSUExQWpReUkyR2dGSkZTUVNSREVBaUFKbVFRQURLN0FBU1RFQWlBS3ZKd1ZNVUVsRkE3MUZBVUFBRElBSVJWSlNPazVHVEZld0FFY0NpQUtzU1lFcFcweUJJVnRNSXdtSUF0WkxBYnhJc1RFQUtrY0NpQU9USWx1eUNMSUhJN0lRSXJJQnN5TkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JJZ0NPU2NFVEZDOVJRR0FBUUFpVHdKVUtVeFFzQ05ETmhvQlNSVWtFa1EyR2dKSkZTUVNSRXlJQWl3bkJVeFF2VVVCZ0FFQUlrOENWQ2xNVUxBalF6WWFBVWtWSkJKRU5ob0NTUlVrRWtSTWlBSUVKd1ZNVUw1RUZ4WXBURkN3STBNMkdnRkpJbGtsQ0VzQkZSSkVWd0lBTVFBaUtHVkVKd2xsU0hJSVJCSkFBQVFuQ3JBQUlpaGxSQ2NMWlVpQkVGc3lEUkpBQUF5QUNFVlNVanBKVlZCSHNBQW5DRXNCWnlORE5ob0JTUldCQ0JKRUZ6RUFJaWhsUkNjSlpVaHlDRVFTUUFBRUp3cXdBQ2hMQVdjalF6WWFBVWtpV1NVSVN3RVZFa1JYQWdBMkdnSkpJbGtsQ0VzQkZSSkVWd0lBTmhvRFNTSlpKUWhMQVJVU1JGY0NBSWdDY2lsTVVMQWpRellhQVVrVlN3RWlXVW1CQkJKRVN3SkxBVXNEVWlKWmdSRUxnUVlJU3dNbFdVbExBaEpFU3dSTEFVc0ZVaUpaU1lFUkN5VUlUd01JVHdRU1JFNERVaUpaQ0lHUU5RdUIwQ2dJRmlsTVVMQWpRellhQVVrVmdRZ1NSQmRKTmhvQ1NSVWtFa1EyR2dOSkZZRUlFa1FYVGdKTWdBeGhhMmwwWVY5aGMzTmxkSE5sU0NKYmNBQkZBVUFBWWtsQkFGNnhTd0VuQzJWSVZ3QUlJeFl5QTBzRHNoaUFCTE5pTktXeUdrOENzaHBNc2hxeUdvQUNBQUN5R29BRWFEWGp2TElhZ1FheUVDS3lBYk8wUGtsWEJBQk1Wd0FFS1JKRVNSVWpFa1FpVTBFQURqSVFGb0FCRkV4UUtVeFFzQ05EZ0FrS0FBQUFBQUFBQUFCQy8reUtBUUVpS0dWRUp3ZGxTSUVZVzdHeUdJQUVoQ2FjZUxJYWkvK3lHb0VHc2hBaXNnR3p0RDVKVndRQVRGY0FCQ2tTUkVrVkl4SkVJbE9KaWdJQmkvNVJBQkJKRllFUUVrU0wvMUVBRUVrVmdSQVNSRkNKaWdJQmkvNVJBQkJKRllFUUVrU0wvMUVBRUVrVmdSQVNSRkNKaWdFQklpaGxSQ2NIWlVnaVc3R3lHSUFFYzU2bkM3SWFpLyt5R29FR3NoQWlzZ0d6dEQ1SlZ3UUFURmNBQkNrU1JFa1ZnVW9TUkltS0F3QWlLR1ZFSndkbFNDSmJzWXYrRm92L0ZrOENzaGlBQkRNR3N5cXlHb3Y5c2hwTXNocXlHb0VHc2hBaXNnR3ppWW9DQUNLTC9vai9IVUVBQXl1d0FJdi9pLzZJLzBvbkJFeFF2VVVCUVFBTWdBaEZVbEk2UWt4TFJMQUFpLzZML3hOQUFBeUFDRVZTVWpwVFJreFhzQUNML29qL1VZR0lBMU5CQUF5QUNFVlNVanBCVlZSUHNBQ0wvNHYraVA4Y0p3Vk1VRW1NQUwxRkFVRUFESUFJUlZKU09rRkdURmV3QUl2L2lQOFpTWUVwVzB5QklWc2pDRWtXaXdCTXYwd2pDSXYvVGdLSS96ZUppZ01CaS8wVmdaQURDNEdrNndJSWkvNFZpLzhWQ0lHUUF3dUIxRWdJVEJhQUVBQUFBQUFBQUh2VUFBQUFBQUFBUFZSTVVJSGtsZ0VXVEVzQlVFeFFnZFNzQVJaUWdkU1RBUlpNU3dGUWdmVGhBaFpRU3dGUVRGQ0JoT2dCRmxCTUZsQ0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
